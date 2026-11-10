"""Empty all seven inventory tables and reset their auto-increment counters."""

import argparse
import sys

import pymysql

from seed import ROOT, TABLES, connection_options


RESET_ORDER = tuple(reversed(TABLES))


def reset_tables(connection):
    """TRUNCATE is fast for large seed datasets and preserves table definitions."""
    with connection.cursor() as cursor:
        cursor.execute(
            "SELECT TABLE_NAME FROM information_schema.TABLES "
            "WHERE TABLE_SCHEMA = DATABASE() AND TABLE_TYPE = 'BASE TABLE'"
        )
        existing = {row[0].lower() for row in cursor.fetchall()}
        missing = [table for table in RESET_ORDER if table.lower() not in existing]
        if missing:
            raise ValueError(f"Missing inventory tables: {', '.join(missing)}. No tables reset.")

        cursor.execute("SELECT @@SESSION.FOREIGN_KEY_CHECKS")
        previous_checks = int(cursor.fetchone()[0])
        try:
            cursor.execute("SET SESSION FOREIGN_KEY_CHECKS = 0")
            for table in RESET_ORDER:
                # Identifiers come exclusively from the fixed schema table list.
                cursor.execute(f"TRUNCATE TABLE `{table}`")
                print(f"Reset {table}", flush=True)
        finally:
            cursor.execute("SET SESSION FOREIGN_KEY_CHECKS = %s", (previous_checks,))


def main(argv=None):
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument("--dry-run", action="store_true", help="show reset plan without connecting")
    parser.add_argument("--yes", action="store_true", help="delete all data in the seven inventory tables")
    args = parser.parse_args(argv)
    if not args.dry_run and not args.yes:
        parser.error("reset deletes all inventory data; use --yes to execute or --dry-run to preview")

    connection = None
    try:
        options = connection_options(ROOT / "Shared" / "Connection.cs")
        print(f"Reset target: {options['database']} at {options['host']}:{options['port']}")
        if args.dry_run:
            print("Dry run: no database connection or writes. Planned reset:")
            print("SET SESSION FOREIGN_KEY_CHECKS = 0;")
            for table in RESET_ORDER:
                print(f"TRUNCATE TABLE `{table}`;")
            print("Restore the previous session FOREIGN_KEY_CHECKS value.")
            return 0

        connection = pymysql.connect(**options)
        reset_tables(connection)
        print("Reset complete: all seven inventory tables are empty; auto-increment counters reset.")
        return 0
    except (OSError, ValueError, pymysql.MySQLError, KeyboardInterrupt) as error:
        print(f"Reset failed: {error or 'interrupted'}", file=sys.stderr)
        if connection is not None:
            print("TRUNCATE cannot be rolled back; check the Reset messages for completed tables.",
                  file=sys.stderr)
        return 1
    finally:
        if connection is not None:
            connection.close()


if __name__ == "__main__":
    sys.exit(main())
