# Database upgrades

The current POS accepts databases created by the original `DBscript.sql` and `BlankDBscript.sql` files. No manual SQL script is required.

At startup, before login, the app validates the original core tables and upgrades the database to schema version 6. Changes run in one transaction and are rolled back together if SQL Server rejects any step. Existing menu, customer, order, invoice, payment, and configuration rows are not deleted or replaced by the upgrade.

The migration adds:

1. Advanced Setting Checklist and MyInvois columns, with a complete default `OtherSetting` row only when the original table is empty.
2. Terminal display and Kitchen second/third printer columns.
3. The MyInvois queue and status columns used by express, home-delivery, and takeaway invoices.
4. The layered `ApplicationSettings` table.
5. The `ShowSSTOnSecondaryDisplay` Other Settings option, defaulted to `Yes` for unchanged upgrade behavior.
6. The `DineInBillCancellations` archive, preserving original bill/item/ledger snapshots and reserving canceled bill IDs. It is populated only when a user confirms an eligible unpaid-bill cancellation.

Applied versions are recorded in `dbo.POSSchemaMigrations`. Every migration remains idempotent so a partially upgraded database can be repaired on restart. SQL application locking prevents concurrent terminals from racing during the first upgrade.

The SQL account must have permission to alter the POS database during the first launch of the upgraded app. After the current version is present and verified, startup follows a read-only compatibility check.

Back up a production database before deploying any application upgrade, even though this migration is additive and preserves existing rows.
