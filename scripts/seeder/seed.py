"""Seed the existing MySQL schema described in db/inventory_schema.dbml."""

import argparse
import json
import random
import re
import sys
from datetime import datetime, timedelta
from decimal import Decimal
from itertools import islice
from pathlib import Path
from time import monotonic
from uuid import uuid4

import pymysql
from faker import Faker


ROOT = Path(__file__).resolve().parents[2]
TABLES = (
    "Users", "Categories", "Units", "Suppliers", "Products", "StockMovements", "AuditLogs"
)
PRESETS = {
    "small": {"users": 10, "categories": 8, "suppliers": 15, "products": 100, "movements": 10},
    "medium": {"users": 25, "categories": 8, "suppliers": 50, "products": 1_000, "movements": 20},
    "large": {"users": 100, "categories": 8, "suppliers": 200, "products": 10_000, "movements": 20},
    "extremely-large": {"users": 500, "categories": 8, "suppliers": 1_000,
                        "products": 100_000, "movements": 5},
}
# Each item pairs a recognizable product with its stocking unit.
CATALOG = (
    ("Office Supplies", (("A4 Copy Paper, 500 Sheets", "pk"), ("Blue Ballpoint Pen", "pc"),
                         ("Heavy Duty Stapler", "pc"), ("Document Folder", "pc"))),
    ("Cleaning Supplies", (("Liquid Hand Soap", "L"), ("Floor Cleaner", "L"),
                           ("Microfiber Cleaning Cloth", "pc"), ("Garbage Bags, 20 Count", "pk"))),
    ("Food and Groceries", (("Jasmine Rice", "kg"), ("White Sugar", "kg"),
                            ("All Purpose Flour", "kg"), ("Ground Coffee", "kg"))),
    ("Beverages", (("Bottled Water, 24 Bottles", "box"), ("Orange Juice", "L"),
                   ("Black Tea, 100 Bags", "box"), ("Whole Milk", "L"))),
    ("Electronics", (("Wireless Mouse", "pc"), ("USB Keyboard", "pc"),
                     ("USB-C Charging Cable", "pc"), ("LED Desk Lamp", "pc"))),
    ("Hardware and Tools", (("Claw Hammer", "pc"), ("Phillips Screwdriver", "pc"),
                            ("Measuring Tape, 5 Meters", "pc"), ("Electrical Cable", "m"))),
    ("Packaging Supplies", (("Cardboard Shipping Box", "pc"), ("Bubble Wrap", "m"),
                            ("Packing Tape", "pc"), ("Shipping Labels, 100 Count", "pk"))),
    ("Personal Care", (("Shampoo", "L"), ("Bar Soap, 6 Count", "pk"),
                       ("Soft Bristle Toothbrush", "pc"), ("Cotton Pads, 100 Count", "pk"))),
)


def connection_options(path):
    """Read the C# literal directly so credentials have a single source of truth."""
    source = path.read_text(encoding="utf-8-sig")
    match = re.search(r'\bCONNECTION_STRING\s*=\s*"([^"\\]*)"\s*;', source)
    if not match:
        raise ValueError(f"Expected a plain CONNECTION_STRING literal in {path}")
    aliases = {
        "server": "host", "host": "host", "user": "user", "user id": "user",
        "uid": "user", "password": "password", "pwd": "password",
        "database": "database", "port": "port",
    }
    options = {}
    for part in match[1].split(";"):
        if not part.strip():
            continue
        key, separator, value = part.partition("=")
        if not separator or key.strip().lower() not in aliases:
            raise ValueError("Unsupported connection-string option; update connection_options().")
        options[aliases[key.strip().lower()]] = value.strip()
    if not all(options.get(key) for key in ("host", "user", "database")):
        raise ValueError("Connection string must specify server, user, and database.")
    options["port"] = int(options.get("port", 3306))
    return {**options, "charset": "utf8mb4", "autocommit": False, "connect_timeout": 10}


def generate_parents(args, fake, now):
    data = {table: [] for table in TABLES[:4]}

    usernames = set()
    for index in range(args.users):
        first_name, last_name = fake.first_name(), fake.last_name()
        base = re.sub(r"[^a-z0-9.]", "", f"{first_name}.{last_name}".lower())[:40]
        username, suffix = base, 2
        while username in usernames:
            username = f"{base}{suffix}"
            suffix += 1
        usernames.add(username)
        data["Users"].append({
            "Username": username, "Password": args.password,
            "FullName": f"{first_name} {last_name}"[:120],
            "UserRole": "Admin" if index == 0 else "Staff",
            "IsActive": True, "CreatedAt": now - timedelta(days=100),
        })

    for index in range(args.categories):
        category_name = CATALOG[index % len(CATALOG)][0]
        section = index // len(CATALOG) + 1
        if section > 1:
            category_name += f" - Section {section}"
        data["Categories"].append({
            "CategoryName": category_name,
            "Description": f"Everyday {category_name.lower()} for business and household use.",
            "IsActive": True,
        })

    for name, symbol, fractional in (
        ("Piece", "pc", False), ("Box", "box", False), ("Pack", "pk", False),
        ("Kilogram", "kg", True), ("Liter", "L", True), ("Meter", "m", True),
    ):
        data["Units"].append({
            "UnitName": name, "UnitSymbol": symbol, "AllowsFraction": fractional,
        })

    for _ in range(args.suppliers):
        data["Suppliers"].append({
            "SupplierName": fake.company()[:150], "ContactPerson": fake.name()[:120],
            "Phone": fake.phone_number()[:35], "Email": fake.company_email()[:150],
            "Address": fake.address().replace("\n", ", ")[:255], "IsActive": True,
        })

    return data


def generate_products(args, fake, rng, batch, now, ids):
    for index in range(args.products):
        category_index = index % args.categories
        category_name, products = CATALOG[category_index % len(CATALOG)]
        product_name, symbol = fake.random_element(products)
        unit_index = ("pc", "box", "pk", "kg", "L", "m").index(symbol)
        cost = Decimal(rng.randint(100, 50000)) / 100
        created = now - timedelta(days=rng.randint(31, 90))
        yield {
            "Sku": f"SEED-{batch}-{index + 1:06d}",
            "ProductName": product_name,
            "Description": f"{product_name} from our {category_name.lower()} range.",
            "CategoryId": ids["Categories"][category_index + 1],
            "UnitId": ids["Units"][unit_index + 1],
            "SupplierId": ids["Suppliers"][rng.randint(1, args.suppliers)], "CostPrice": cost,
            "SellingPrice": (cost * Decimal("1.35")).quantize(Decimal("0.01")),
            "ReorderLevel": Decimal(rng.randint(5, 30)), "IsActive": True,
            "CreatedAt": created, "UpdatedAt": created,
        }


def generate_movements(products, product_ids, args, rng, batch, now, ids, fractional_units):
    remarks = {
        "In": "Received stock from supplier.", "Out": "Issued stock for customer order.",
        "AdjustIn": "Stock count correction: additional units found.",
        "AdjustOut": "Stock count correction: damaged or missing units.",
    }
    for product in products:
        balance = 0
        scale = 1000 if product["UnitId"] in fractional_units else 1
        created = product["CreatedAt"]
        product_id = product_ids[product["Sku"]]
        location = f"Aisle {rng.randint(1, 12)} / Shelf {rng.randint(1, 5)}"
        for movement_index in range(args.movements):
            kind = "In" if movement_index == 0 else rng.choice(
                ("In", "Out", "AdjustIn", "AdjustOut")
            )
            # Opening receipts precede withdrawals; no product goes below zero.
            maximum = balance if kind in ("Out", "AdjustOut") else 100 * scale
            if maximum == 0:
                kind, maximum = "In", 100 * scale
            quantity = rng.randint(1, maximum)
            balance += quantity if kind in ("In", "AdjustIn") else -quantity
            yield {
                "ProductId": product_id, "MovementType": kind,
                "Quantity": Decimal(quantity) / scale,
                "StorageLocation": location,
                "ReferenceNo": f"SEED-{batch}-{product_id}-{movement_index + 1}",
                "Remarks": remarks[kind], "CreatedBy": ids["Users"][rng.randint(1, args.users)],
                "CreatedAt": created + timedelta(
                    seconds=((movement_index + 1) * int((now - created).total_seconds()))
                    // (args.movements + 1)
                ),
            }


def generate_audits(products, product_ids, actor_id):
    for product in products:
        yield {
            "ActorUserId": actor_id, "ActionType": "CREATE", "EntityName": "Products",
            "EntityId": product_ids[product["Sku"]], "OldData": None,
            "NewData": json.dumps({"Sku": product["Sku"], "ProductName": product["ProductName"]}),
            "LoggedAt": product["CreatedAt"],
        }


def insert_parents(connection, data, *, clear=False):
    ids = {table: {} for table in TABLES}
    inserted = {table: 0 for table in TABLES}
    with connection.cursor() as cursor:
        # Rollback guarantees require transactional tables. Do not create/alter schema here.
        cursor.execute(
            "SELECT TABLE_NAME, ENGINE FROM information_schema.TABLES "
            "WHERE TABLE_SCHEMA = DATABASE()"
        )
        engines = {name.lower(): engine for name, engine in cursor.fetchall()}
        for table in TABLES:
            if (engines.get(table.lower()) or "").upper() != "INNODB":
                raise ValueError(f"Expected existing InnoDB table {table}; apply db schema first.")
        connection.begin()
        if clear:
            for table in reversed(TABLES):
                cursor.execute(f"DELETE FROM `{table}`")
        for table, rows in data.items():
            for local_id, original in enumerate(rows, 1):
                row = original.copy()
                if table == "Users":
                    base, suffix = row["Username"], 2
                    while True:
                        cursor.execute("SELECT UserId FROM Users WHERE Username = %s", (row["Username"],))
                        if cursor.fetchone() is None:
                            break
                        row["Username"] = f"{base}{suffix}"
                        suffix += 1
                    original["Username"] = row["Username"]
                if table == "Categories":
                    cursor.execute(
                        "SELECT CategoryId FROM Categories WHERE CategoryName = %s",
                        (row["CategoryName"],),
                    )
                    existing = cursor.fetchone()
                    if existing is not None:
                        ids[table][local_id] = existing[0]
                        continue
                if table == "Units":
                    cursor.execute(
                        "SELECT UnitId, UnitName, UnitSymbol, AllowsFraction FROM Units "
                        "WHERE UnitName = %s OR UnitSymbol = %s",
                        (row["UnitName"], row["UnitSymbol"]),
                    )
                    existing = cursor.fetchall()
                    if existing:
                        if len(existing) != 1 or tuple(existing[0][1:]) != (
                            row["UnitName"], row["UnitSymbol"], row["AllowsFraction"]
                        ):
                            raise ValueError(f"Existing unit conflicts with seed unit {row['UnitName']}.")
                        ids[table][local_id] = existing[0][0]
                        continue
                columns = ", ".join(f"`{column}`" for column in row)
                placeholders = ", ".join(["%s"] * len(row))
                cursor.execute(
                    f"INSERT INTO `{table}` ({columns}) VALUES ({placeholders})",
                    tuple(row.values()),
                )
                ids[table][local_id] = cursor.lastrowid
                inserted[table] += 1
    return ids, inserted


def chunks(rows, size):
    rows = iter(rows)
    while batch := list(islice(rows, size)):
        yield batch


def insert_batch(cursor, table, rows):
    columns = ", ".join(f"`{column}`" for column in rows[0])
    placeholders = ", ".join(["%s"] * len(rows[0]))
    cursor.executemany(
        f"INSERT INTO `{table}` ({columns}) VALUES ({placeholders})",
        [tuple(row.values()) for row in rows],
    )


def planned_counts(args):
    return {"Users": args.users, "Categories": args.categories, "Units": 6,
            "Suppliers": args.suppliers, "Products": args.products,
            "StockMovements": args.products * args.movements, "AuditLogs": args.products}


def run_seed(args, connection=None):
    """Keep only parent lookup IDs and one product/movement batch in memory."""
    fake = Faker()
    fake.seed_instance(args.seed)
    rng = random.Random(args.seed)
    movement_rng = random.Random(args.seed + 1)
    batch = uuid4().hex[:10]
    now = datetime.now().replace(microsecond=0)
    parents = generate_parents(args, fake, now)
    if connection is None:
        ids = {table: {i: i for i in range(1, len(rows) + 1)} for table, rows in parents.items()}
        counts = {table: len(parents.get(table, [])) for table in TABLES}
    else:
        ids, counts = insert_parents(connection, parents, clear=args.clear)
    username = parents["Users"][0]["Username"]
    fractional_units = {ids["Units"][i] for i, row in enumerate(parents["Units"], 1)
                        if row["AllowsFraction"]}
    del parents
    cursor = connection.cursor() if connection is not None else None
    started = monotonic()
    last_progress = started
    try:
        for products in chunks(generate_products(args, fake, rng, batch, now, ids), args.batch_size):
            if cursor is not None:
                insert_batch(cursor, "Products", products)
                # Query by unique SKUs: auto-increment IDs may have gaps or a non-unit step.
                placeholders = ", ".join(["%s"] * len(products))
                cursor.execute(
                    f"SELECT Sku, ProductId FROM Products WHERE Sku IN ({placeholders})",
                    tuple(product["Sku"] for product in products),
                )
                product_ids = dict(cursor.fetchall())
                if len(product_ids) != len(products):
                    raise ValueError("Could not resolve every inserted product ID.")
            else:
                product_ids = {p["Sku"]: counts["Products"] + i
                               for i, p in enumerate(products, 1)}
            counts["Products"] += len(products)
            streams = {
                "StockMovements": generate_movements(
                    products, product_ids, args, movement_rng, batch, now, ids, fractional_units
                ),
                "AuditLogs": generate_audits(products, product_ids, ids["Users"][1]),
            }
            for table, stream in streams.items():
                for rows in chunks(stream, args.batch_size):
                    if cursor is not None:
                        insert_batch(cursor, table, rows)
                    counts[table] += len(rows)
                    elapsed = monotonic()
                    if not args.quiet and elapsed - last_progress >= 5:
                        print(f"Processed {sum(counts.values()):,} rows; "
                              f"products {counts['Products']:,}/{args.products:,} "
                              f"({elapsed - started:.1f}s)", flush=True)
                        last_progress = elapsed
    finally:
        if cursor is not None:
            cursor.close()
    return counts, username


def positive_int(value):
    number = int(value)
    if number < 1:
        raise argparse.ArgumentTypeError("must be at least 1")
    return number


def parse_args(argv=None):
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument("--preset", choices=PRESETS, default="small", help="base size (default: small)")
    parser.add_argument("--list-presets", action="store_true", help="show preset counts and exit")
    for name in ("users", "categories", "suppliers", "products", "movements"):
        parser.add_argument(f"--{name}", type=positive_int,
                            help="movements per product" if name == "movements" else "override preset count")
    parser.add_argument("--batch-size", type=positive_int, default=1000,
                        help="maximum rows per generation/insert batch (default: 1000)")
    parser.add_argument("--quiet", action="store_true", help="hide periodic progress messages")
    parser.add_argument("--seed", type=int, default=42, help="Faker/random seed")
    parser.add_argument("--password", default="Seeder123!", help="password for generated demo users")
    parser.add_argument("--dry-run", action="store_true", help="generate without connecting to MySQL")
    parser.add_argument("--clear", action="store_true",
                        help="delete all rows from the seven inventory tables before inserting")
    args = parser.parse_args(argv)
    for name, value in PRESETS[args.preset].items():
        if getattr(args, name) is None:
            setattr(args, name, value)
    if not 1 <= len(args.password) <= 255:
        parser.error("--password must contain 1 to 255 characters")
    return args


def main(argv=None):
    args = parse_args(argv)
    if args.list_presets:
        for name, settings in PRESETS.items():
            total = sum(planned_counts(argparse.Namespace(**settings)).values())
            print(f"{name}: {settings['users']:,} users, {settings['categories']:,} categories, "
                  f"6 units, {settings['suppliers']:,} suppliers, {settings['products']:,} products, "
                  f"{settings['movements']:,} movements/product; {total:,} total rows")
        return 0

    connection = None
    try:
        options = connection_options(ROOT / "Shared" / "Connection.cs")
        print(f"Preset: {args.preset}; planned rows: {sum(planned_counts(args).values()):,}; "
              f"batch size: {args.batch_size:,}", flush=True)
        started = monotonic()
        if args.clear:
            action = "Would clear" if args.dry_run else "Clearing"
            print(f"{action} all seven inventory tables in {options['database']} "
                  f"at {options['host']}:{options['port']} before inserting.", flush=True)
        if args.dry_run:
            counts, username = run_seed(args)
            print("Dry run: generated all data; no database connection or writes.")
        else:
            connection = pymysql.connect(**options)
            counts, username = run_seed(args, connection)
            connection.commit()
            if args.clear:
                print("Committed table cleanup and seed data.")
            else:
                print("Committed seed data (matching existing categories and units reused).")
        for table, count in counts.items():
            print(f"  {table}: {count:,}")
        print(f"Total: {sum(counts.values()):,} rows in {monotonic() - started:.1f}s")
        print(f"Demo admin username: {username}")
        print("Demo password: the --password value (default: Seeder123!).")
        return 0
    except (OSError, ValueError, pymysql.MySQLError, KeyboardInterrupt) as error:
        if connection is not None:
            connection.rollback()
        print(f"Seeding failed: {error or 'interrupted'}", file=sys.stderr)
        return 1
    finally:
        if connection is not None:
            connection.close()


if __name__ == "__main__":
    sys.exit(main())
