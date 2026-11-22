# Inventory seeder

Requires Python 3.10+ and an existing MySQL database with the tables from
`db/inventory_schema.dbml` applied using InnoDB. This script does not create the
database or tables. Connection settings are read directly from the plain
`CONNECTION_STRING` literal in `Shared/Connection.cs`, relative to the script,
so it works from any working directory without copying credentials.

From the repository root:

```powershell
python -m venv scripts/seeder/.venv
scripts/seeder/.venv/Scripts/python.exe -m pip install -r scripts/seeder/requirements.txt
scripts/seeder/.venv/Scripts/python.exe scripts/seeder/seed.py --dry-run
scripts/seeder/.venv/Scripts/python.exe scripts/seeder/seed.py
```

Choose a size with `--preset` (defaults to `small`):

| Preset | Users | Categories | Suppliers | Products | Movements per product | Total rows |
| --- | ---: | ---: | ---: | ---: | ---: | ---: |
| `small` | 10 | 8 | 15 | 100 | 10 | 1,239 |
| `medium` | 25 | 8 | 50 | 1,000 | 20 | 22,089 |
| `large` | 100 | 8 | 200 | 10,000 | 20 | 220,314 |
| `extremely-large` | 500 | 8 | 1,000 | 100,000 | 5 | 701,514 |

Totals include six standard units and one creation audit log per product.
Existing matching categories and units are reused, so the actual number of new
rows can be lower. `--list-presets` prints the sizes without connecting to MySQL.
Individual flags override the chosen preset: `--users`, `--categories`,
`--suppliers`, `--products`, and `--movements` (per product). All must be positive.

```powershell
# Generate all rows without writing to MySQL:
scripts/seeder/.venv/Scripts/python.exe scripts/seeder/seed.py --preset extremely-large --dry-run

# Insert approximately 700,000 rows:
scripts/seeder/.venv/Scripts/python.exe scripts/seeder/seed.py --preset extremely-large

# Customize a preset: 250,000 products and 2,500,000 movements:
scripts/seeder/.venv/Scripts/python.exe scripts/seeder/seed.py --preset extremely-large --products 250000 --movements 10 --batch-size 2000
```

Products, movements, and audit logs are generated incrementally and inserted
using parameterized bulk inserts. `--batch-size` controls the maximum rows per
generation/insert batch (default 1,000), including when one product has many
movements. Product IDs are looked up by their unique SKUs after each batch;
the script does not assume auto-increment IDs are contiguous. Only the current
product/movement batches and parent lookups remain in memory. Parent tables
(users, categories, units, suppliers) are generated in memory and inserted
individually; keep those counts modest for the fastest large runs.

The script prints progress about every five seconds during product/movement
processing and a final row count and duration. `--quiet` hides periodic progress.
All batches share one transaction, committed at the end. An error or Ctrl+C
rolls back the entire run; batches are not individually committed. Large runs
therefore also require sufficient MySQL transaction/undo space. Dry runs fully
generate and discard the data, exercising the same bounded batches.

Faker generates realistic people's names, companies, and contact details, and
selects recognizable products such as "Wireless Mouse" and "Jasmine Rice" from
a catalog. Products belong to suitable categories such as "Electronics" and
"Food and Groceries", with appropriate stocking units. Usernames follow the
person's name, such as `jessica.smith`, with numeric suffixes for duplicates.
`--seed` controls the generated values; SKUs include a fresh batch token.
Matching categories and standard units are reused on subsequent runs. Requests
for more than eight categories add numbered sections of those categories.
Conflicting unit names/symbols cause a rollback. Existing
rows are never deleted or updated. Inserts use parameters and one transaction;
a failed insert rolls back the batch. Dry runs do not connect to MySQL.

The first generated user is an active `Admin`; the others are active `Staff`.
The script prints the generated admin username. All generated users have the
demo password `Seeder123!`, configurable with `--password`. Passwords are stored
as plain text to match the application's current authentication query; use
these accounts only for development/demo data.

Products have nonnegative prices and reorder levels. Stock movements use
positive quantities, whole numbers for units that disallow fractions, and
chronological timestamps. Each product starts with an incoming movement and
never has a negative running balance. Inventory remains derived from movements.
Audit log entity IDs and all foreign keys use the actual inserted database IDs.

Implementation references: [Faker](https://faker.readthedocs.io/en/master/) and
[PyMySQL transactions](https://pymysql.readthedocs.io/en/latest/modules/connections.html).

## Reset the database

`reset_db.py` empties all seven inventory tables, including users and audit
logs, and resets auto-increment counters. It reads the same connection settings
from `Shared/Connection.cs` and preserves the table definitions, indexes, and
foreign keys. Preview or execute from the repository root:

```powershell
scripts/seeder/.venv/Scripts/python.exe scripts/seeder/reset_db.py --dry-run
scripts/seeder/.venv/Scripts/python.exe scripts/seeder/reset_db.py --yes
```

The reset checks that all seven tables exist before clearing any. Foreign key
checks are disabled only for its connection and their previous setting is
restored on success, error, or interruption. It uses
[`TRUNCATE TABLE`](https://dev.mysql.com/doc/refman/8.4/en/truncate-table.html)
for large datasets: data removal cannot be rolled back, and a failed reset can
leave some tables cleared. Stop application writes while resetting. The MySQL
user needs permission to truncate tables (the `DROP` privilege).

Run `seed.py` afterward with the desired preset to populate the empty tables.

Run the seeder tests from the repository root:

```powershell
scripts/seeder/.venv/Scripts/python.exe -m unittest discover -s scripts/seeder -v
```
