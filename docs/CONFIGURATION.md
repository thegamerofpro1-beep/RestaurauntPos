# RestaurantPOS14 configuration

Phase 2 centralizes configuration behind `RestaurantPOS14.Configuration.SettingsHost`. The recovered application keeps its original defaults unless a later layer supplies an override.

## Precedence

Settings are merged recursively in this order, from lowest to highest priority:

1. Strongly typed built-in defaults
2. Machine JSON: `%ProgramData%\RestaurantPOS14\settings.json`
3. Terminal JSON: `%LocalAppData%\RestaurantPOS14\terminal.settings.json`
4. SQL database settings
5. In-process runtime overrides

Changing a property in a later layer replaces that property only. Unspecified sibling properties continue to come from earlier layers.

Both JSON files support hot reload when their parent directory exists. A valid change replaces the active settings and raises `SettingsReloaded`. Invalid JSON or invalid values leave the previous settings active and raise `ReloadFailed` with a diagnostic.

All recovered explicit SQL command-timeout assignments now read `Database.CommandTimeoutSeconds`. The default remains `0` (the recovered infinite timeout), so this extraction does not change baseline behavior; operators can set a finite value through any settings layer.

The following changes are reported as restart-required because recovered code can hold live database or device connections:

- Database connection string and connection timeout
- Cash-drawer, customer-display, and caller-ID ports
- Caller-ID diagnostic and weighing-scale ports
- Payment-terminal address and port

## Settings groups

The root object is `ApplicationSettings` and contains:

- `Database`: protected SQL connection, default catalog, and command/connection timeouts
- `Printing`: receipt, kitchen, cash drawer, display, caller ID, and terminal device values
- `Tax`: SST, service charge, currency, decimals, and rounding
- `Receipt`: business identity, header/footer, logo, template, and display switches
- `EInvoice`: MyInvois endpoint, environment, timeout, and secret-key references
- `OnlineOrders`: endpoint, polling, timeout, and secret-key references
- `Features`: optional POS capability switches
- `Ui`: theme, culture, font, touch layout, button size, named control colors, and POS button-layout overrides
- `Paths`: reports, images, export, and backup directories
- `Reports`: default format and per-report printer/format overrides

See [`settings.example.json`](settings.example.json) for a non-secret example.

## Secrets

Secrets are not accepted in either JSON settings file. The loader rejects values named `ClientId`, `ClientSecret`, `ApiKey`, `SharedSecret`, `Password`, or `Pwd`. It also rejects a JSON SQL connection string containing a password.

Secrets are encrypted using Windows DPAPI with `CurrentUser` scope and stored at:

`%LocalAppData%\RestaurantPOS14\secrets.dpapi.json`

The file contains encrypted Base64 values, not usable plaintext. Because protection is bound to the Windows user profile, copying the file to another user or machine does not make the secrets portable.

The standard secret keys are:

- `Database.ConnectionString`
- `EInvoice.ClientId`
- `EInvoice.ClientSecret`
- `OnlineOrders.ApiKey`
- `OnlineOrders.SharedSecret`

Application code writes secrets through `SettingsHost.SecretStore`. JSON contains only the corresponding `...SecretKey` property.

## POS layout

The recovered POS already populates categories, menu items, item colors, and item order from SQL rather than designer-fixed item buttons. `Ui.PosLayout` lifts the remaining recovered dimensions into configuration and adds keyed button overrides for size, ARGB background, foreground color, visibility, sort order, row, and column. The same object can be supplied by JSON or by dotted `dbo.ApplicationSettings` rows.

Defaults match the recovered layouts: 115×60 category buttons, 110×140 image panels with 108×90 image buttons, and 110×97 rate panels with 105×70 item buttons. A form can use `PosButtonLayoutResolver` to merge its database values with configuration overrides.

Theme, font, touch scaling, culture, and named color overrides are applied to forms as they open. Their built-in values are deliberately no-op (`ThemeName` empty, font/button sizes zero, touch scale 1), so an installation with no override retains the recovered designer appearance.

## Application paths

`Paths.MenuImageDirectory` and `Paths.SecondaryDisplayImageDirectory` control the active menu-item and secondary-display image workflows. Relative values resolve from the executable directory, preserving the recovered folder layout.

`Paths.BackupDirectory` controls manual and shutdown backup dialogs. If it is empty, the resolver imports the recovered `HKCU\Software\RestaurantPOS14\BackupFolder` value and otherwise uses the current database catalog name under the user's Documents folder. Backup and restore SQL quote the configured `Database.DefaultCatalog`, parameterize the file path, and use `Database.CommandTimeoutSeconds`; `RPOS_DB` remains only the compatibility fallback when no catalog is configured.

The first-run SQL setup uses the same catalog value for existence checks, create/drop operations, saved connection strings, and both recovered database scripts. The shipped scripts retain their original `RPOS_DB` token on disk; it is replaced with a safely quoted configured catalog in memory before execution.

## Editable receipt templates

An empty `Receipt.TemplatePath` keeps the existing Crystal Reports/`PrintDocument` receipt path. When set, the path points to an editable JSON `ReceiptTemplate` containing ordered, visible sections and `{{value}}` placeholders. Relative paths resolve from the executable directory. Missing files, malformed JSON, empty keys, and duplicate section keys fail explicitly. See [`receipt-template.example.json`](receipt-template.example.json).

## Reports and printing

`Paths.ReportOutputDirectory` controls report exports. Relative paths remain relative to the executable directory, preserving the recovered `PDF Reports` default. `Reports.DefaultExportFormat` accepts `PDF`, `Excel`, `Word`, or `Crystal`; `Reports.ExportFormats` overrides that choice by Crystal report class name. `Reports.PrinterAssignments` likewise overrides `Printing.DefaultPrinterName` per report.

The central Crystal print path now uses `IPrintService`. Its default remains the recovered custom-width Crystal path. The extension layer also exposes thermal and A4 `PrintDocument` services, a PDF Crystal exporter, a network-printer decorator, and a null/dry-run service. `PrintServiceHost.Current` can be replaced for a terminal or a test and reset to the recovered default.

`Printing.SerialReadTimeoutMilliseconds` and `SerialWriteTimeoutMilliseconds` apply to customer-display, caller-ID, and weighing-scale ports. `Printing.CallerIdDiagnosticPort` retains the recovered COM5 diagnostic fallback. Runtime POS devices use `CustomerDisplayPort`, `CallerIdPort`, and `WeighingScalePort`; the latter two are enabled by `Features.CallerId` and `Features.WeighingScale`.

## Database layer

The general settings table is created during the automatic database upgrade and read with this contract:

```sql
CREATE TABLE dbo.ApplicationSettings (
    SettingPath nvarchar(200) NOT NULL PRIMARY KEY,
    JsonValue nvarchar(max) NOT NULL,
    IsEnabled bit NOT NULL CONSTRAINT DF_ApplicationSettings_IsEnabled DEFAULT (1)
);
```

`SettingPath` uses dotted property paths such as `Tax.SstRatePercent`; `JsonValue` must be one valid JSON value, such as `6.0`, `true`, or `"Aqua"`. Disabled rows are ignored. Invalid JSON is a configuration error.

The provider also reads the recovered `dbo.OtherSetting` row for `EnableChecklist`, `EnableMyInvois`, `MyInvoisBaseUrl`, `MyInvoisEnvironment`, and legacy MyInvois credentials. Legacy credentials are immediately copied into the DPAPI store. The advanced-settings form now clears those legacy credential columns when it saves.

For the current Windows host, the provider imports `dbo.PosPrinterSetting` printer, cash-drawer, customer-display, caller-ID, weighing-scale, and Ingenico settings plus their feature flags. The POS consumes that merged snapshot instead of repeatedly querying the terminal row during payments or serial-device startup.

Database settings are read during reload. A SQL connectivity failure is recorded as a diagnostic and lower layers remain active; malformed database setting data is rejected.

Before the login screen opens, the configured database is upgraded to schema version 5. The migration supports the untouched original demo and blank schemas, preserves their existing rows, and adds the following compatibility features:

- Advanced Setting Checklist and MyInvois fields in `dbo.OtherSetting`
- `DisableColoredDisplaySingleScreen` in `dbo.PosPrinterSetting`
- second and third printer fields in `dbo.Kitchen`
- `dbo.EInvoiceQueue` plus MyInvois status fields on EB, HD, and TA invoices
- `dbo.ApplicationSettings` and `dbo.POSSchemaMigrations`
- `ShowSSTOnSecondaryDisplay` in `dbo.OtherSetting`, defaulting to `Yes` so existing colored customer displays keep their current layout

Each migration is idempotent and transactional. Multiple terminals serialize the upgrade with a SQL application lock. An already current database takes a read-only fast path. The SQL login needs permission to alter the database for the first upgraded launch; later launches do not require migration writes.

## Legacy migration

On first settings-host initialization, the migrator imports known recovered sources without deleting them:

- `SQLSettings.dat`, falling back to the named `App.config` connection string
- `EInvoiceConfig.json`
- `HKCU\Software\RestaurantPOS14\BackupFolder`
- MyInvois values in `dbo.OtherSetting`

Connection strings and credentials are placed in the DPAPI store. Non-secret values and migration metadata are written atomically to terminal JSON. Existing terminal settings win over legacy non-secret values.

Malformed legacy JSON or an invalid SQL connection string fails with a specific error rather than silently reverting to a different database.

The SQL setup form now writes the selected connection directly to the DPAPI secret store. It no longer creates a plaintext `SQLSettings.dat`, including for SQL-authentication passwords. Splash startup checks the layered protected connection instead of the legacy file. Existing legacy files remain supported as migration input.

## Runtime overrides

Use `SettingsHost.RuntimeOverrides.SetValue("Ui.ThemeName", "Desert")` for a temporary, highest-priority value. `Clear()` removes all runtime overrides. Runtime values are process-local and are not persisted.

## Validation

The merged configuration is validated before it becomes active. Validation covers SQL structure, endpoints and HTTPS, enabled-feature credentials, timeouts and ports, tax ranges, rounding, shipped themes, touch sizes, and both default and per-report export formats. All discovered validation errors are returned together in `SettingsValidationException.Errors`.
