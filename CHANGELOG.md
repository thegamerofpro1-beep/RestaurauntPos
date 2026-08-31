# Changelog

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
