# RestaurantPOS14 Phase 2 architecture

Phase 2 is additive and backward-compatible. Existing SQL consumers still compile against the static `ConnectionString.cs` field and Crystal Reports remains the default report engine, but those compatibility paths now resolve through the settings, printing, payment, report, and integration hosts.

## Configuration flow

```text
built-in defaults
       ↓
machine JSON → terminal JSON → SQL settings → runtime overrides
       ↓              ↓
  JSON checks    legacy migration ──→ DPAPI secret store
       └──────────────┬──────────────────────────┘
                      ↓
              merge + secret hydration
                      ↓
                   validate
                      ↓
                 SettingsHost
```

`SettingsHost` owns one process-wide `SettingsService`. The connection-string compatibility class now resolves through that host, so the recovered callers gain layered configuration without a broad SQL rewrite. E-invoice startup and the advanced-settings form also use this host.

Both recovered typed-dataset generations now resolve their adapter connections through the same compatibility bridge. The generated `MySettings.RPOS_DBConnectionString` property also delegates to it, and the source `app.config` no longer embeds a developer workstation/database connection.

The 638 explicit recovered `SqlCommand.CommandTimeout = 0` assignments now read the layered command-timeout value. Its built-in value is still `0`, preserving the recovered behavior until configured.

## Customization seams

- `ThemeService` walks a WinForms control tree, applies a shipped Telerik `ThemeName` through the public property when present, and applies configured font, touch size, culture, and named color overrides. `UiCustomizationHost` applies it once as forms open; built-in UI values are no-op, so the recovered appearance remains the unconfigured default.
- `PosButtonLayoutResolver` layers keyed JSON/SQL overrides over the recovered SQL-driven categories, items, colors, and order. Default dimensions match the recovered flow-layout controls.
- `ILocalizationService` provides resource-backed captions with recovered text as a safe fallback for missing resource keys.
- `ReportProfileResolver` resolves default/per-report printer and export-format settings while keeping Crystal Reports enabled by default.
- `ReceiptTemplateService` loads optional editable JSON sections and placeholders; an empty template path keeps the compiled report/receipt path.
- `IPrintService` represents the recovered Crystal printer plus explicit thermal, A4, PDF, network, delegating, and null/dry-run services. The central `GetPrinterName` compatibility path resolves per-report profiles and dispatches through `PrintServiceHost`.
- `IPaymentProvider` represents terminal integrations. All recovered POS and bill-split Ingenico sales now use `PaymentProviderHost`; `IngenicoPaymentProvider` preserves the proven `SendSale(address, port, amount)` contract and returns the raw response to the existing approval/decline logic.
- `IntegrationEventHub` offers named `OrderCreated`, `BillSettled`, and `DayClosed` hooks. Events are emitted only after durable lifecycle points. Bill settlement is re-read from the persisted billing table and accepted only for KOT `Paid`, TA/EB `Paid Directly` or `Closed`, and HD `Delivered`. MyInvois is the default bill subscriber; its automatic queue insert is idempotent. An online-order subscriber forwards all three event types through a replaceable, contract-specific publisher and defaults to a no-op publisher because no outbound API contract was proven in the recovered binary.

Localization and editable receipt-template rendering remain extension seams until an installation chooses a template/resource set. Theme/layout overrides, report profiles, payment routing, and central Crystal printing are wired into active paths while their defaults preserve recovered behavior.

## Compatibility boundaries

- The public static connection field remains in place for decompiled callers.
- A database created by either original SQL script is upgraded transactionally before login. Versioned, idempotent migrations add only the current app's compatibility tables and nullable columns; existing sales rows are retained.
- `dbo.POSSchemaMigrations` records the four applied schema migrations, and an application lock prevents two terminals from upgrading the same database concurrently.
- `dbo.ApplicationSettings` is created by the compatibility migration and remains read-only from the configuration-provider layer.
- Existing legacy files and registry values are imported but not deleted.
- New SQL setup saves through DPAPI and splash startup recognizes the protected connection; plaintext `SQLSettings.dat` is migration-only.
- Missing SQL settings-table access degrades to lower configuration layers and emits a diagnostic.
- Invalid values and malformed legacy data fail explicitly before becoming active.
- JSON hot reload retains the previous valid settings when a reload fails.

## Source map

- `RestaurantPOS14\Configuration`: models, validation, providers, host, DPAPI store, migration
- `RestaurantPOS14\Customization`: themes/layout, localization, report profiles
- `RestaurantPOS14\Extensions`: payment, printing, integration events
- `RestaurantPOS14\ConnectionString.vb`: compatibility bridge for existing SQL code
- `RestaurantPOS14\EInvoicing\EInvoiceConfig.vb`: layered e-invoice configuration bridge
