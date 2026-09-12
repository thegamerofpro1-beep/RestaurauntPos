# RestaurantPOS14 project handoff

- Last updated: 12 September 2026
- Repository: `https://github.com/thegamerofpro1-beep/RestaurauntPos`
- Default branch: `main`
- Application file version: `14.1.5.10`
- Assembly version: `14.1.5.0`
- Database schema version: `6`

## Purpose

This document is the durable context for continuing the RestaurantPOS14 work in a new Codex task or on another PC. It summarizes the user's requests and the implementation decisions established during the original task. It is not a verbatim chat transcript and does not contain credentials, production database contents, temporary screenshots, printer data, or generated installers.

A new agent should read this document, `AGENTS.md`, `README.md`, `CHANGELOG.md`, `docs/BUILD.md`, `docs/CONFIGURATION.md`, `docs/DATABASE_UPGRADES.md`, and the relevant feature document before modifying the application.

## Product and deployment baseline

- Windows desktop restaurant POS recovered as VB.NET source.
- Target framework: .NET Framework 4.8.
- Build target: x86.
- Database: Microsoft SQL Server, including databases created by the first released version.
- Receipts: SAP Crystal Reports x86 runtime 13.0.24.
- Main solution: `src/RestaurantPOS14/RestaurantPOS14.sln`.
- Main project: `src/RestaurantPOS14/RestaurantPOS14.vbproj`.
- Installation directory: `%ProgramFiles(x86)%\Hitech Computers\RestaurantPOS14`.
- The repository is private because it contains commercial application source and bundled third-party reference assemblies. Do not make it public without a licence review.
- Machine-specific credentials and runtime state must stay outside Git.

## User-visible requirements established in the original task

### SST and service charge

- Back Office > Other Settings provides a manually editable SST percentage beside Service Charge.
- The saved SST rate applies consistently to dine-in, takeaway, home-delivery, express and split-bill invoices.
- Exclusive SST is added to the total. Inclusive SST is extracted for display without increasing the total again.
- All customer receipts show numeric SST percentage and amount.
- Receipt order is currently **Sub Total first, SST below it**. This is intentional: the request to move SST above Sub Total was later explicitly undone.
- Service Charge is presented in the same style as SST, with percentage and amount aligned with the receipt Amount column.
- Receipt monetary values use `RM` and two decimal places.
- Receipt item quantities and the total quantity use whole numbers. The footer quantity is aligned with item quantities.
- The colored customer display shows the SST percentage and can optionally show an `SST Amt.` item column.
- Back Office > Other Settings controls whether the secondary-display SST column is visible.
- Secondary-display monetary values use the `RM` prefix and two decimal places.
- Large secondary-display totals must remain right-aligned and visible rather than extending beyond the screen.

### Final payable rounding

- New or recalculated final bills round to the nearest RM0.10.
- Midpoints use away-from-zero rounding: RM1.64 -> RM1.60; RM1.65 and RM1.67 -> RM1.70; RM121.85 -> RM121.90.
- Display currency retains two decimals, so the visible form is `RM 1.70`, not `RM 1.7`.
- Rounding occurs only after taxes, service/parcel/delivery charges, tips, gift-card deductions and loyalty redemption.
- Never apply 10-sen rounding to item prices, line totals, discounts, SST/service-charge amounts, cash tendered or change.
- The rounded payable value drives validation, persisted invoice GrandTotal, receipts, customer display, cash/card settlement, change and accounting entries.
- Historical paid receipt reprints keep their original stored total. There is no historical database backfill.
- The implementation boundary is `Configuration/MoneyMath.vb` plus `Billing/PayableTotal.vb`. Do not replace the general `RoundCurrency` behavior with final-total rounding.

### Printing and cash drawer

- A receipt must use the enabled printer selected for the current terminal in Terminal Settings.
- Microsoft Print to PDF exports to a PDF file; it must not silently replace a configured physical receipt printer.
- Crystal Reports printer settings must use the selected printer driver's page settings.
- Missing/unavailable printer errors must identify the printer problem instead of raising a generic null-reference exception.
- The Front Office drawer button, dine-in Save & Print and split-bill drawer paths share one guarded cash-drawer implementation.
- A disabled or unconfigured drawer is a no-op during settlement.
- Drawer failure is logged and reported as a Cash Drawer problem, but must not prevent receipt printing.
- Never call spooler functions with a null or invalid printer handle.

### Legacy database compatibility

- The current application must open and upgrade a database created by the very first version without manual SQL changes or missing-column errors.
- Startup performs transactional, idempotent migrations guarded by a cross-terminal application lock.
- Schema state and migration history are stored in the database and verified after migration.
- New database creation and existing database upgrade use the same compatibility migration path.
- The migration adds optional settings, terminal/display fields, multi-printer fields, MyInvois queue/status fields and safe unpaid-bill cancellation storage as needed.
- Forms must tolerate old optional columns while migration is in progress; one missing optional field must not disable printing.
- First-run database creation must use the authentication mode and credentials selected in SQL Server Setting for every provisioning connection.
- Configuration is saved only after the full schema succeeds and passes required-schema validation.
- A failed provision must expose useful SQL number/procedure/line details and must not claim success or leave the app pointed at a partial database.
- Existing SQL Server data is never deleted by app setup or uninstall.

### Dine-in tables and unpaid bills

- Table numbers are business labels, not guaranteed integers. Valid examples include names, punctuation, Unicode text and merged-table sets.
- Never feed a table label into an integer parser or concatenate it into SQL.
- Existing unpaid-bill lookups use parameterized BillID queries and preserve text table names.
- The earlier error `Table number must be a non-negative whole number` was caused by incorrectly treating table labels as numeric IDs.
- If a normal unpaid bill already exists for a selected table, the operator should be guided to Dine In Billing rather than being left unable to proceed.
- `Cancel Unpaid Bill` is available to every signed-in user, not administrator-only.
- Cancellation requires a reason and confirmation and is limited to fully unpaid normal dine-in bills.
- It must reject paid/part-paid, split, account-linked, loyalty-linked and e-invoice-linked bills.
- Cancellation archives the complete bill/items/accounting snapshot and writes the existing cancellation audit in one serializable transaction.
- Kitchen-order history and stock are intentionally retained.
- Canceled bill IDs remain reserved to prevent number reuse.
- See `docs/UNPAID_BILL_CANCELLATION.md` and `Billing/UnpaidBillCancellation.vb` before changing this workflow.

### Advanced settings and MyInvois

- Enabling Checklist or MyInvois on an original database must not raise `Invalid column name` for `EnableChecklist`, `EnableMyInvoice`, `MyInvoiceBaseUrl`, `MyInvoiceClientId`, `MyInvoiceClientSecret`, or `MyInvoiceEnvironment`.
- The compatibility migration owns these fields; individual forms should not run competing ad-hoc schema patches.
- Missing MyInvois credentials keep an invoice queued with a retryable error. Never fabricate a successful approval response.
- Secrets are resolved from protected/local settings. Do not commit live client IDs, secrets, API keys or database passwords.

### Performance and defensive behavior

- Login PIN verification uses compatible salted PBKDF2 hashes through Windows native cryptography; legacy first-version PIN storage remains transparently readable and upgradable.
- Employee-record checks may run independently. Do not restore the old serial multi-second login scan.
- Do not eagerly construct Front Office during administrator login.
- Non-critical audit writes stay off the navigation path.
- User permissions are loaded into one per-user cache and invalidated after rights changes.
- Direct selected-row use requires empty/selection guards.
- Financial and quantity division requires zero-denominator guards.
- Dynamic SQL inputs must be parameterized or passed through the typed/escaped `Security/SqlInput.vb` boundary.
- External HTTP calls are bounded, use HTTPS except for explicitly allowed loopback gateways, and fail safely.
- Exceptions should reach `Diagnostics/ApplicationDiagnostics.vb`; avoid empty catch blocks.
- Graceful application shutdown replaces abrupt Visual Basic `End` behavior.
- See `docs/DEFENSIVE_CODE_AUDIT.md` for the completed broad audit and remaining architectural debt.

## Receipt reports

The four customer receipt resources are:

1. `src/RestaurantPOS14/RestaurantPOS14.rptRestaurantPOSFinalBillKOTInvoice.rpt`
2. `src/RestaurantPOS14/RestaurantPOS14.rptRestaurantPOSTAInvoice.rpt`
3. `src/RestaurantPOS14/RestaurantPOS14.rptRestaurantPOSHDInvoice.rpt`
4. `src/RestaurantPOS14/RestaurantPOS14.rptRestaurantPOSEBInvoice.rpt`

Their generated wrapper classes call `Reporting/ReceiptReportCompatibility.Apply`. That repair boundary exists because upgraded PCs may load Crystal formulas containing a stale `Restaurant_OrderedProduct.servicechargePer` field. The correct legacy fields are `VATPer` for Service Charge and `STPer` for SST. Do not remove the compatibility repair or perform blind text replacement inside database-field references.

Current layout invariants:

- Sub Total is above SST.
- SST and Service Charge amounts are right-aligned with the item Amount column.
- Percent fields are wide/small enough not to overlap Sub Total.
- Quantities contain no decimals.
- Total quantity aligns with the quantity column above it.
- Grand Total remains prominent and long values do not clip.

Receipt `.rpt` resources are binary. Use the existing Crystal updater/verification harnesses rather than attempting text edits.

## Secondary customer display

- Implemented in `frmSecondaryDisplay.vb`.
- `SecondaryDisplayOptions.vb` owns the optional SST-column setting.
- The summary labels are laid out from the right edge so increasing totals do not leave the display.
- An empty slideshow is valid and must not perform a modulo/division operation with zero images.
- Item rate, SST amount and total remain ordinary currency values; only the final payable total receives 10-sen rounding.

## Installer and upgrades

Build from the repository root:

```powershell
.\installer\Build-Installer.ps1
```

The generated setup is deliberately ignored by Git and is written under `output\installer`. It installs the app and the following workstation prerequisites:

- Microsoft .NET Framework 4.8.
- Microsoft Visual C++ 2015-2022 Redistributable x86, validated at 14.44.35211.0.
- SAP Crystal Reports runtime for .NET Framework x86, validated at 13.0.24.2970.
- IDAutomationHC39M barcode font.

The installer migrates the original `%ProgramFiles(x86)%\Hi Tech Computers\Rest Touch\RestaurantPOS14` installation to `%ProgramFiles(x86)%\Hitech Computers\RestaurantPOS14`. It preserves licence/configuration files, menu images, PDF exports and secondary-display images before removing the former installation. A stable Inno Setup AppId supports future in-place upgrades.

Do not commit the large prerequisite installers or generated setup executable. On a new build PC, obtain/verify the prerequisites through the installer build workflow. SQL Server, Microsoft Office and printer/payment-terminal drivers remain external dependencies.

## Build and validation

Validated app build command:

```powershell
& 'C:\Program Files (x86)\Microsoft Visual Studio\2022\BuildTools\MSBuild\Current\Bin\MSBuild.exe' `
  '.\src\RestaurantPOS14\RestaurantPOS14.vbproj' `
  /t:Rebuild /p:Configuration=Release /p:Platform=x86 /m /v:minimal
```

Important validation sources under `build/phase3`:

- `OperationalSmoke.vb`: read-only database/schema, integration seams and Crystal viewer/report checks.
- `LegacySettingsMigrationSmoke.vb`: migration from original settings/database shapes.
- `InvoicePrintSmoke.vb`: invoice print-path guards.
- `CashDrawerGuardSmoke.vb`: drawer configuration and failure behavior.
- `ReceiptUpgradeFormulaSmoke.vb`: stale Crystal percentage formula repair.
- `SstReportVerification.vb`: SST formulas and footer placement.
- `ServiceChargeReceiptLayoutVerification.vb`: service-charge layout and formula checks.
- `ReceiptCurrencyLayoutVerification.vb`: `RM` formatting and amount alignment.
- `ReceiptQuantityAndFooterLayoutVerification.vb`: whole quantities and footer alignment.
- `DineInTableNameSmoke.vb`: named, Unicode and merged-table compatibility.
- `LoginPerformanceSmoke.vb`: PIN compatibility/performance and permission-cache behavior.
- `UnpaidBillCancellationSmoke.vb`: transactional cancellation guards, rollback and concurrency.
- `UnpaidBillCancellationUiSmoke.vb`: offscreen cashier-access dialog check; no live cancellation.
- `PayableRoundingSmoke.vb`: final-total boundaries, all billing modes, discounts, split billing, change and secondary display.
- `AllReceiptRenderSmoke.vb` and `RoundingReceiptRenderSmoke.vb`: receipt PDF render checks. These query schema/data read-only and replace rounding fixtures in memory; they do not create sales.

Most harness executables are generated locally and excluded from Git. Build them from their checked-in `.vb` sources using x86 .NET Framework references and the Release application assembly, then copy `RestaurantPOS14.exe.config` beside harnesses that initialize application settings.

## Safety rules for future work

- Never run tests that create, update, settle, refund or cancel production bills unless the user explicitly requests a live transaction test and identifies a safe test database.
- Prefer synthetic in-memory datasets or uniquely named disposable SQL databases for mutation tests.
- Do not delete production SQL databases, backup folders, menu images, exports, licence files or user configuration.
- Treat the working tree as user-owned. Inspect `git status` and preserve unrelated changes.
- Do not alter existing receipt order/layout unless the latest user request explicitly supersedes the current invariants.
- Do not silently switch a terminal from a physical printer to PDF.
- Do not log secrets or include connection strings in diagnostics, screenshots, commits or test output.
- Keep the repository private while third-party DLLs remain tracked.
- Bump `AssemblyFileVersion`, update `CHANGELOG.md`, rebuild, run risk-proportionate tests, regenerate the installer, verify its SHA-256 and then commit a release change.

## Machine-specific state intentionally absent from Git

- SQL Server names, database names and credentials.
- Email/SMS/e-invoice secrets and API credentials.
- Printer, cash-drawer, payment-terminal and COM-port selections.
- Licence files and workstation-specific legacy configuration.
- Installed runtimes and installer prerequisite packages.
- Generated setup executables and checksums.
- Compiled `bin`/`obj` output, smoke-test executables, logs and validation output.
- User-supplied error screenshots and temporary receipt/PDF renderings.
- The original Codex conversation transcript.

The new PC must configure these values locally or migrate them through the installer. Do not copy secrets into a prompt or commit merely to recreate the old workstation.

## Recommended startup prompt on another PC

After cloning and opening the repository, use a prompt similar to:

> Read `AGENTS.md`, `README.md`, `docs/PROJECT_HANDOFF.md`, `CHANGELOG.md`, and the relevant feature documents before making changes. Preserve first-version database compatibility, receipt layout invariants, printer selection behavior and final-total rounding. Inspect the current Git state, then continue with my new request. Do not run mutation tests against a production database.

## Known limits and next checks

- Physical receipt output, cash-drawer pulses, customer pole display, payment terminal and kitchen printers require tests on actual hardware after installing on each till.
- A first-version database upgrade should be tested on a backup/copy before production rollout even though automated migration coverage exists.
- Crystal report editing requires the compatible 32-bit Crystal runtime and should be visually verified from rendered PDFs plus a physical 80 mm receipt.
- The recovered application remains a large legacy WinForms codebase with shared form state and some inherited dynamic SQL. The defensive layer reduces risk but does not replace a future staged data-access refactor.
- Generated installer packages are not hosted in this repository. Build or distribute them separately through an approved private release mechanism.

## Source-of-truth documents

- Full chronological changes: `CHANGELOG.md`.
- Architecture and recovery context: `docs/ARCHITECTURE.md`, `docs/RECON.md`, `docs/FIDELITY_REPORT.md`.
- Build/dependencies: `docs/BUILD.md`, `docs/DEPENDENCIES.md`.
- Runtime configuration: `docs/CONFIGURATION.md`, `docs/settings.example.json`.
- Database migrations: `docs/DATABASE_UPGRADES.md`.
- Defensive review: `docs/DEFENSIVE_CODE_AUDIT.md`.
- Final rounding: `docs/FINAL_BILL_ROUNDING.md`.
- Unpaid cancellation: `docs/UNPAID_BILL_CANCELLATION.md`.
- Operational validation: `docs/OPERATIONAL_VALIDATION.md`.

When this handoff and the implementation disagree, verify the current code and `CHANGELOG.md`, explain the discrepancy, and update this handoff as part of the next validated release.
