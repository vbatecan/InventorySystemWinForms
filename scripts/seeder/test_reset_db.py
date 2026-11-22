import contextlib
import io
import unittest
from unittest.mock import MagicMock, call, patch

import reset_db


class ResetTests(unittest.TestCase):
    def connection(self, previous_checks=1):
        connection = MagicMock()
        cursor = connection.cursor.return_value.__enter__.return_value
        cursor.fetchall.return_value = [(table.lower(),) for table in reset_db.TABLES]
        cursor.fetchone.return_value = (previous_checks,)
        return connection, cursor

    def test_reset_all_tables_and_restore_original_foreign_key_setting(self):
        for previous in (0, 1):
            with self.subTest(previous=previous):
                connection, cursor = self.connection(previous)
                with contextlib.redirect_stdout(io.StringIO()):
                    reset_db.reset_tables(connection)
                commands = cursor.execute.call_args_list
                self.assertEqual(commands[2], call("SET SESSION FOREIGN_KEY_CHECKS = 0"))
                self.assertEqual(commands[3:-1], [call(f"TRUNCATE TABLE `{table}`")
                                                for table in reset_db.RESET_ORDER])
                self.assertEqual(commands[-1], call("SET SESSION FOREIGN_KEY_CHECKS = %s", (previous,)))

    def test_missing_tables_abort_before_any_reset(self):
        connection, cursor = self.connection()
        cursor.fetchall.return_value = [('users',)]
        with self.assertRaisesRegex(ValueError, 'Missing inventory tables'):
            reset_db.reset_tables(connection)
        self.assertEqual(cursor.execute.call_count, 1)

    def test_failure_or_interrupt_restores_checks(self):
        for failure in (reset_db.pymysql.OperationalError('test failure'), KeyboardInterrupt()):
            with self.subTest(failure=type(failure).__name__):
                connection, cursor = self.connection()

                def execute(sql, *args):
                    if sql.startswith('TRUNCATE'):
                        raise failure

                cursor.execute.side_effect = execute
                with self.assertRaises(type(failure)):
                    reset_db.reset_tables(connection)
                self.assertEqual(cursor.execute.call_args,
                                 call("SET SESSION FOREIGN_KEY_CHECKS = %s", (1,)))

    def test_dry_run_and_missing_confirmation_never_connect(self):
        with patch.object(reset_db.pymysql, 'connect') as connect, \
                contextlib.redirect_stdout(io.StringIO()) as output:
            self.assertEqual(reset_db.main(['--dry-run']), 0)
        connect.assert_not_called()
        self.assertEqual(output.getvalue().count('TRUNCATE TABLE'), 7)
        with patch.object(reset_db.pymysql, 'connect') as connect, \
                contextlib.redirect_stderr(io.StringIO()), self.assertRaises(SystemExit):
            reset_db.main([])
        connect.assert_not_called()

    def test_cli_closes_connection_on_success_and_failure(self):
        for failure in (None, reset_db.pymysql.OperationalError('test failure')):
            with self.subTest(failure=type(failure).__name__):
                connection, _ = self.connection()
                with patch.object(reset_db.pymysql, 'connect', return_value=connection), \
                        patch.object(reset_db, 'reset_tables', side_effect=failure), \
                        contextlib.redirect_stdout(io.StringIO()), \
                        contextlib.redirect_stderr(io.StringIO()):
                    self.assertEqual(reset_db.main(['--yes']), 0 if failure is None else 1)
                connection.close.assert_called_once()


if __name__ == '__main__':
    unittest.main()
