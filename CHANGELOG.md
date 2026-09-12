# Changelog

## 2026-09-04 — Final payable totals rounded to 10 sen

- New/recalculated bills round the final payable amount to the nearest RM0.10, with midpoint values rounded away from zero (RM1.65/RM1.67 become RM1.70).
- Applies after tax, service/parcel/delivery charges, tips, gift-card deductions and loyalty redemption; item prices, quantities, discounts and tax amounts retain their existing precision.
- Dine-in, takeaway, home delivery, express and item-split billing store the rounded payable total for receipts and accounting. Cash/card payment checks and change use that same amount.
- Colored and existing pole-display balance updates use the payable total instead of a pre-charge subtotal. Home delivery no longer opens a disabled colored display during calculation.
- Historical receipt reprints remain unchanged; no database backfill or schema change. Installer version 14.1.5.10.

## 2026-09-04 — Safe unpaid-bill cancellation for every user

### Added

- Replaced the misleading Undo Bill cash-settlement action with Cancel Unpaid Bill, available to every signed-in user without an operator/administrator restriction.
- Requires a reason and confirmation of the bill and affected tables. Cancels fully unpaid normal dine-in bills only; paid/part-paid, split, account-linked, loyalty-ledger and e-invoice bills are protected.
- Archives complete bill, item and accounting snapshots and adds an entry to the existing canceled-invoice history in the same transaction as removal from active billing. Existing kitchen orders and stock are never changed.
- Automatically upgrades existing databases to schema version 6, reserves canceled bill numbers, and raises installer version to 14.1.5.9.

## 2026-09-04 — Unpaid dine-in bill table-name compatibility

### Fixed

- Fixed the intermittent "Table number must be a non-negative whole number" error when sending or updating an order for a table with an existing unpaid bill.
- Both paths now use one parameterized bill lookup, preserving first-version text table names and merged-table aggregation without parsing quoted table names as numeric IDs.
- Raised the installer file version to 14.1.5.8 for a definite in-place upgrade.

## 2026-09-04 — Receipt subtotal order and quantity alignment

### Changed

- Restored Sub Total above SST in Dine In, Take Away, Home Delivery, and Express receipt templates.
- Aligned each receipt's total quantity with the item quantity column and kept its label clear of the numeric column.
- Preserved whole-number quantities, RM formatting, SST/service-charge values, and right-aligned footer amounts.
- Raised the installer file version to 14.1.5.7 for a definite in-place upgrade.

## 2026-09-03 — Receipt SST before Sub Total

### Changed

- Moved the SST row above the Sub Total row in Dine In, Take Away, Home Delivery, and Express receipt templates.
- Preserved right alignment with the receipt Amount column and widened the SST percentage field to prevent clipping.
- Raised the installer file version to 14.1.5.6 for a definite in-place upgrade.

## 2026-09-03 — Optional SST column on colored customer display

### Added

- Added a Back Office → Other Settings checkbox to show or hide the `SST Amt.` column on the colored secondary customer display.
- Existing databases are upgraded automatically and retain the current visible SST-column behavior by default.
- Raised the installer file version to 14.1.5.5 for a definite in-place upgrade.

## 2026-09-03 — Faster login and office navigation

### Improved

- Kept all existing salted PBKDF2 PIN hashes compatible while moving the calculation to Windows native cryptography and checking independent employee records in parallel.
- Reduced the measured 20-user PIN scan on the build PC from roughly 17 seconds to about 0.7 seconds.
- Removed eager Front Office creation during administrator login and moved non-critical login audit writes off the navigation path.
- Cached the signed-in user's complete permission set after one query, so Back Office no longer performs a separate database round trip for every report permission.
- Invalidates the permission cache whenever user rights are granted, changed, or deleted.
- Raised the installer file version to 14.1.5.4 for a definite in-place upgrade.

## 2026-09-03 — Cash Drawer reliability

### Fixed

- Replaced the Front Office, Dine In billing, and split-bill cash-drawer paths with one guarded implementation that uses local database objects instead of shared mutable readers and connections.
- Validates every Windows spooler operation and never continues with a null/invalid printer handle.
- A disabled or unconfigured drawer remains silent during cash settlement; a real printer/driver failure displays a useful Cash Drawer message and no longer interrupts receipt printing.
- Cash-drawer failures are recorded in the application diagnostic log with the underlying Windows error.
- Raised the installer file version to 14.1.5.3 for a definite in-place upgrade.

## 2026-09-02 — Upgraded receipt formula compatibility

### Fixed

- Customer receipts now repair stale Crystal Service Charge and SST percentage formulas before rendering, using the report's actual legacy `VATPer` and `STPer` field references instead of a hard-coded table alias.
- Prevented the legacy VAT display-label cleanup from rewriting `VATPer` inside Crystal database formulas, and revalidates the formulas at the common Save & Print boundary.
- A receipt with an incompatible optional percentage field no longer blocks Save & Print; the percentage is suppressed and the mismatch is written to the application diagnostic log.
- Raised the installer file version to 14.1.5.2 so PCs already running the earlier packages receive an unambiguous in-place upgrade.

## 2026-09-02 — Defensive code audit

### Fixed

- Removed an exit-time routine that deleted every file in the configured database-backup folder before creating a backup.
- Added guards to every direct selected-row access found in the recovered forms and safe handling for zero-denominator financial and quantity calculations.
- Guarded legacy dynamic SQL inputs by type or escaped literal value, while keeping first-version database compatibility.
- Repaired ten pizza form constructors that accessed controls before `InitializeComponent`.
- Replaced silent exception handlers with local diagnostics, including Crystal report initialization failures.
- Replaced abrupt Visual Basic `EndApp` termination with graceful application shutdown and protected nullable cleanup in the KDS path.
- Added bounded HTTPS network requests, blocked external clear-text endpoints, removed forced legacy TLS settings, and made Windows utility launches fail safely.
- Replaced reversible new PIN storage with salted PBKDF2 hashes, retained transparent first-version PIN login, and added login throttling and secure temporary PIN generation.
- Removed the fake MyInvois validation fallback; missing credentials now leave invoices queued with a retryable error instead of generating false approval data.

### Added

- Application-wide crash and non-fatal diagnostic logging under `%LocalAppData%\Hitech Computers\RestaurantPOS14\Logs` with bounded log rotation.
- A repeatable defensive-guard smoke test and a Microsoft DevSkim SARIF audit artifact.
- `docs/DEFENSIVE_CODE_AUDIT.md` with scope, checks, results, and remaining architectural constraints.

## 2026-09-02 — Unified setup installer

### Added

- Added one offline setup executable for RestaurantPOS14 and its .NET Framework 4.8, Visual C++ x86, Crystal Reports x86, and barcode-font prerequisites.
- Added version-aware prerequisite detection, silent runtime upgrades, Start Menu/Desktop shortcuts, uninstall support, and reproducible SHA-256 verification.
- Added automatic migration from the original `%ProgramFiles(x86)%\Hi Tech Computers\Rest Touch\RestaurantPOS14` installation to `%ProgramFiles(x86)%\Hitech Computers\RestaurantPOS14`.

### Changed

- Upgrades preserve the licence file, legacy SQL/e-invoice configuration, menu images, PDF exports, secondary-display images, database settings, and SQL Server data.
- Legacy executable configuration can now be imported after the former installer is removed.

## 2026-09-02 — Original database automatic upgrade

### Fixed

- Databases created by the original demo and blank scripts now upgrade automatically to schema version 4 before login.
- Centralized the Advanced Setting, terminal display, multi-printer kitchen, MyInvois queue, invoice-status, and layered-setting schema changes into one transactional migration path.
- Added cross-terminal migration locking, persistent migration history, complete post-upgrade verification, and an idempotent fast path for already upgraded databases.
- Added the missing MyInvois queue `UIN` and `QRUrl` columns required by the active queue implementation.
- Blank original databases receive one complete default `OtherSetting` row rather than a partially initialized row.
- New database provisioning and feature forms use the same compatibility migration instead of independent schema patches with swallowed errors.

## 2026-09-02 — Legacy terminal printer settings

### Fixed

- Fixed older `OtherSetting` schemas preventing `POSPrinterSetting` from loading during application startup.
- Isolated optional database settings so a missing feature column can no longer disable invoice printing.
- Added a direct enabled-printer lookup by till ID when the centralized setting has not yet been populated, including first-run database creation sessions.
- Terminal Setting changes now refresh the active settings immediately, and invoice printing rechecks the current till before every job.
- Cash payments no longer call the raw-printer drawer command with a null printer when Cash Drawer is disabled.

## 2026-09-02 — Invoice printing reliability

### Fixed

- Microsoft Print to PDF now exports the Crystal invoice to an explicit PDF file instead of sending an unsupported silent custom-paper print job.
- Physical Crystal printers now use the selected printer driver's page settings, avoiding a mismatch with page settings created for the Windows default printer.
- Missing, invalid, or rejected printers now produce a useful printer-specific message instead of a generic null-reference error.

## 2026-09-02 — Database setup reliability

### Fixed

- First-run demo and blank database creation now use the authentication mode and credentials selected in SQL Server Setting for every provisioning connection.
- Database configuration is saved only after the complete schema script succeeds and passes a required-schema check.
- Failed provisioning no longer reports success or leaves a partial database behind.
- Startup now detects a saved connection to an unavailable or incompletely provisioned database and returns to SQL Server Setting instead of continuing to login.
- SQL setup errors now show the underlying SQL error number, procedure, line, and message instead of only the generic SMO batch exception.
- Replacing an existing database now requires a separate, explicit data-loss confirmation.

## 2026-09-02 — SST charge option

### Added

- Added a manually editable SST charge percentage beside Service Charge in Back Office Others Setting.
- Applies the saved SST percentage to every menu category so dine-in, takeaway, home-delivery, express, and split-bill invoices use the same rate.

### Changed

- Activated the existing `STPer`/`STAmount` invoice path so exclusive SST is added to invoice totals and inclusive SST is extracted and displayed without increasing the total.
- Dine-in, takeaway, home-delivery, express, split-bill, and reprint receipts now show the numeric SST percentage and charge amount immediately below Sub Total.
- Reduced the SST receipt row typography to prevent overlap and prefixed every printed monetary value with `RM`.
- Printed item and summary quantities now use whole numbers, while Sub Total and SST amounts align with the receipt Amount column.
- Receipt Service Charge rows now show the saved percentage dynamically and align their amounts with the item Amount column.
- The coloured customer display now shows the SST percentage beside Total and each item's SST amount in a dedicated grid column, including recalled and quantity-adjusted orders.
- All monetary values on the coloured customer display now include the `RM` prefix and two decimal places.
- Large customer-display totals now reflow the SST and Total summary from the right edge instead of being clipped off-screen.
- An empty customer-display slideshow no longer raises an `Attempted to divide by zero` exception.
- Reused the existing `OtherSetting.ServiceTax` and invoice tax columns, so no database schema migration is required.

## 2026-08-31 — Post-delivery verification

### Added

- A read-only operational smoke harness covering the configured SQL connection and required schema, payment/printing/integration dry-run seams, Crystal report loading, and Crystal viewer creation.
- `docs/OPERATIONAL_VALIDATION.md` with the tested safety boundary, hardware readiness, Crystal runtime compatibility note, and the exact Visual Studio designer result.
- Repository hygiene rules for generated reverse-engineering artifacts and retained original binary inputs.

### Changed

- Initialized eight recovered POS `ByRef` locals to `Nothing`, preserving runtime behavior while removing eight `BC42030` warnings.
- Marked the recovered typed-DataSet `Item` member with `Shadows`, preserving its API while removing one `BC40003` warning.
- Reduced the reproducible warning count from 21 to 12 without suppressing warnings or changing the ten recovered pizza-form constructors.

### Verified

- Both `Debug|x86` and `Release|x86` rebuild with 0 errors.
- The configured `RPOS_DB` database opens read-only, exposes 104 user tables, and contains the required operational tables.
- Crystal report loading and viewer handle creation succeed under the documented diagnostic binding redirect.
- Visual Studio reaches the recovered `frmLogin.vb` designer, which reports a decompiler-layout parsing limitation at line 1420; no designer changes were saved.

## 2026-08-31 — Phase 3 delivery

### Added

- Reproducible `docs/BUILD.md` covering the known-good Visual Studio/MSBuild environment, local binary dependencies, exact x86 build commands, runtime prerequisites, deployment notes, and all 21 known warnings.
- Final Phase 3 Debug and Release x86 verification logs.

### Changed

- Clarified that `docs/FIDELITY_REPORT.md` describes the frozen Phase 1 baseline and linked its later Phase 2 deviations to the delivery documentation.

## 2026-08-31 — Phase 2 customizability completion

### Added

- Settings-driven currency rounding, report output paths, per-report export formats, terminal serial timeouts, POS dimensions, and keyed category-button overrides.
- Automatic no-op-by-default UI customization for theme, culture, font, touch scaling, and named colors.
- Explicit Crystal, thermal, A4, PDF, network, delegating, and null/dry-run `IPrintService` implementations.
- Replaceable payment, print, and online-order publisher hosts.
- Persisted-status lifecycle hooks for order creation, bill settlement, and work-period close.
- Idempotent automatic MyInvois queue insertion to prevent duplicate submissions from repeated lifecycle notifications.
- Weighing-scale and caller-ID diagnostic settings, including terminal-table migration and restart-required detection.
- Settings-aware application path resolution for menu images, secondary-display images, and database backups.
- Central backup/restore command construction using the configured catalog, parameterized paths, and configured SQL timeout.

### Changed

- Routed the central Crystal printer path through `PrintServiceHost`, including configured paper width and per-report printer profiles.
- Routed every recovered Ingenico sale call through `PaymentProviderHost` while preserving existing raw-response interpretation.
- Routed customer-display, caller-ID, and weighing-scale startup through the layered terminal settings snapshot.
- Routed the six recovered report email/export workflows through configurable Crystal export formats and output directories.
- Routed recovered menu-image and secondary-display file access through `Paths`, and backup dialogs through `Paths.BackupDirectory` with legacy-registry fallback.
- Removed the hardcoded `RPOS_DB` catalog from SQL setup, backup, and restore commands; recovered setup scripts are retargeted in memory while retaining `RPOS_DB` as the empty-configuration compatibility fallback.
- Applied POS layout settings to the recovered repeated category/item controls and activated keyed category overrides.
- Changed the built-in rounding mode to `ToEven`, matching the recovered two-argument `Math.Round` behavior.
- Removed four incorrectly placed early integration calls from temporary-grid cleanup, KOT creation, and bill voiding; settlement now publishes only after persisted paid/delivered states.

### Compatibility notes

- Empty/no-op UI values preserve every recovered designer style unless an override is supplied.
- Crystal Reports and the recovered 80 mm custom page path remain the default printing behavior.
- The online-order event subscriber defaults to a no-op publisher because the binary did not prove a safe outbound endpoint contract; deployments install an `IOnlineOrderEventPublisher` explicitly.
- Automatic MyInvois queueing never queues unpaid, partially paid, confirmed, cancelled, or void bills.

## 2026-08-30 — Phase 2 configuration and extension checkpoint

### Added

- Strongly typed settings for database, printing/devices, tax, receipts, e-invoicing, online orders, feature flags, UI, paths, and reports.
- Layered settings precedence: defaults, machine JSON, terminal JSON, database, then runtime overrides.
- JSON hot reload with validation, failure diagnostics, and restart-required change reporting.
- Windows DPAPI `CurrentUser` secret storage with atomic file replacement.
- Legacy migration from `SQLSettings.dat`, the named `App.config` connection string, `EInvoiceConfig.json`, the RestaurantPOS14 backup registry value, and MyInvois database fields.
- Optional dotted-path `dbo.ApplicationSettings` database provider.
- Opt-in theme/layout, localization, and report-profile services.
- POS button-layout settings and a resolver that layers keyed configuration over recovered SQL category/item styles.
- Editable, ordered JSON receipt templates with placeholder rendering and validation; an empty template path keeps existing receipts.
- Payment-provider, printing-service, and integration-event extension contracts, including a thin Ingenico adapter and null/dry-run printer.
- A default MyInvois `BillSettled` subscriber; settled KOT/TA/HD/EB flows now publish through the integration-event host.
- Configuration and architecture documentation plus a non-secret JSON example.

### Changed

- Kept `ConnectionString.cs` as the compatibility entry point but source its value through the layered settings host.
- Routed all 67 legacy typed-dataset adapter connection assignments and the generated `MySettings` connection property through that bridge.
- Removed recovered workstation connection strings from source `app.config` and generated settings defaults.
- Changed SQL setup and splash startup to use the DPAPI-protected connection; new setup no longer writes plaintext `SQLSettings.dat` credentials.
- Routed 638 recovered SQL command-timeout assignments through `Database.CommandTimeoutSeconds`, retaining `0` as the default.
- Source e-invoice defaults and request timeout from the layered settings host.
- Source checklist and MyInvois feature checks from the layered settings host instead of querying and altering `OtherSetting` on each check.
- Store MyInvois client credentials through DPAPI from Advanced Settings and clear the legacy plaintext database columns on save.
- Added the .NET Framework `System.Security` reference required by DPAPI.

### Compatibility notes

- Crystal Reports remains the default report engine.
- Payment and central Crystal printing call sites retain their recovered behavior through the new extension seams.
- Legacy sources are imported, not deleted.
- The decompiled form/resource inventory and x86 platform target remain unchanged.
