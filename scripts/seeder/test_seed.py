"""Run with: python -m unittest discover -s scripts/seeder -v"""

import contextlib
import io
import unittest
from collections import defaultdict
from decimal import Decimal
from unittest.mock import MagicMock, patch

import seed


class CheckingCursor:
    """Simulate noncontiguous database IDs and validate every dependent row."""

    def __init__(self, args, ids):
        self.args = args
        self.ids = ids
        self.counts = defaultdict(int)
        self.products = {}
        self.results = []
        self.balances = defaultdict(Decimal)
        self.timestamps = {}
        self.max_batch = 0
        self.closed = False

    def executemany(self, sql, values):
        table = sql.split('`')[1]
        columns = [column.strip(' `') for column in sql.split('(')[1].split(')')[0].split(',')]
        assert 1 <= len(values) <= self.args.batch_size
        self.max_batch = max(self.max_batch, len(values))
        if table == 'Products':
            self.products = {}
            self.balances.clear()
            self.timestamps.clear()
        for values_row in values:
            row = dict(zip(columns, values_row))
            self.counts[table] += 1
            if table == 'Products':
                assert row['CategoryId'] in self.ids['Categories'].values()
                assert row['UnitId'] in self.ids['Units'].values()
                assert row['SupplierId'] in self.ids['Suppliers'].values()
                self.products[row['Sku']] = (10_000 + 7 * self.counts[table], row)
            elif table == 'StockMovements':
                products_by_id = {id_: product for id_, product in self.products.values()}
                product = products_by_id[row['ProductId']]
                assert row['CreatedBy'] in self.ids['Users'].values()
                assert row['Quantity'] > 0
                if product['UnitId'] in (self.ids['Units'][i] for i in (1, 2, 3)):
                    assert row['Quantity'] == int(row['Quantity'])
                self.balances[row['ProductId']] += row['Quantity'] * (
                    1 if row['MovementType'] in ('In', 'AdjustIn') else -1
                )
                assert self.balances[row['ProductId']] >= 0
                assert row['CreatedAt'] >= self.timestamps.get(row['ProductId'], product['CreatedAt'])
                self.timestamps[row['ProductId']] = row['CreatedAt']
            elif table == 'AuditLogs':
                assert row['EntityId'] in {id_ for id_, _ in self.products.values()}
                assert row['ActorUserId'] == self.ids['Users'][1]

    def execute(self, sql, skus):
        assert sql.startswith('SELECT Sku, ProductId')
        # Database result order need not match insertion order.
        self.results = [(sku, self.products[sku][0]) for sku in reversed(skus)]

    def fetchall(self):
        return self.results

    def close(self):
        self.closed = True


class SeederTests(unittest.TestCase):
    def test_presets_and_overrides(self):
        args = seed.parse_args(['--preset', 'extremely-large'])
        self.assertEqual(sum(seed.planned_counts(args).values()), 701_514)
        args = seed.parse_args(['--preset', 'extremely-large', '--products', '250000',
                                '--movements', '10', '--batch-size', '2000'])
        self.assertEqual((args.products, args.movements, args.batch_size), (250_000, 10, 2000))
        self.assertEqual((args.users, args.suppliers), (500, 1000))
        self.assertEqual(seed.parse_args([]).products, 100)

    def test_streamed_inserts_with_gapped_ids_and_partial_batches(self):
        for size in (1, 7, 1000):
            with self.subTest(batch_size=size):
                args = seed.parse_args(['--products', '19', '--movements', '101',
                                        '--batch-size', str(size), '--quiet'])
                counts = seed.planned_counts(args)
                ids = {table: {i: 500 + i * 3 for i in range(1, counts[table] + 1)}
                       for table in seed.TABLES[:4]}
                parent_counts = {table: counts[table] if table in ids else 0 for table in seed.TABLES}
                cursor = CheckingCursor(args, ids)
                connection = MagicMock()
                connection.cursor.return_value = cursor
                with patch.object(seed, 'insert_parents', return_value=(ids, parent_counts)):
                    actual, username = seed.run_seed(args, connection)
                self.assertEqual(actual, counts)
                self.assertEqual(cursor.counts['StockMovements'], 19 * 101)
                self.assertEqual(cursor.counts['AuditLogs'], 19)
                self.assertLessEqual(cursor.max_batch, size)
                self.assertTrue(cursor.closed)
                self.assertIn('.', username)

    def test_full_dry_run_never_connects(self):
        with patch.object(seed.pymysql, 'connect') as connect, contextlib.redirect_stdout(io.StringIO()):
            result = seed.main(['--preset', 'medium', '--dry-run', '--batch-size', '31', '--quiet'])
        self.assertEqual(result, 0)
        connect.assert_not_called()

    def test_success_commits_and_errors_or_interrupts_roll_back(self):
        for failure in (None, seed.pymysql.IntegrityError('test failure'), KeyboardInterrupt()):
            with self.subTest(failure=type(failure).__name__):
                connection = MagicMock()
                with patch.object(seed.pymysql, 'connect', return_value=connection), \
                        patch.object(seed, 'run_seed', side_effect=failure,
                                     return_value=({'Products': 1}, 'jessica.smith')), \
                        contextlib.redirect_stdout(io.StringIO()), \
                        contextlib.redirect_stderr(io.StringIO()):
                    result = seed.main([])
                if failure is None:
                    self.assertEqual(result, 0)
                    connection.commit.assert_called_once()
                    connection.rollback.assert_not_called()
                else:
                    self.assertEqual(result, 1)
                    connection.rollback.assert_called_once()
                    connection.commit.assert_not_called()
                connection.close.assert_called_once()

    def test_nonpositive_counts_rejected(self):
        for flag in ('--products', '--movements', '--batch-size'):
            with self.subTest(flag=flag), contextlib.redirect_stderr(io.StringIO()):
                with self.assertRaises(SystemExit) as error:
                    seed.parse_args([flag, '0'])
                self.assertEqual(error.exception.code, 2)


if __name__ == '__main__':
    unittest.main()
