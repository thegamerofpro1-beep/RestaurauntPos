# Operational validation

Validation was performed against the recovered `RestaurantPOS14` source and the locally configured workstation. Operational checks avoid financial side effects; the additive schema-version upgrade was explicitly applied to the configured database as part of the requested compatibility work.

## Verified

- The solution rebuilds for both `Debug|x86` and `Release|x86` with Visual Studio 2022 MSBuild and the .NET Framework 4.8 targeting pack.
- The configured SQL connection opens successfully against `RPOS_DB` on SQL Server 10.50.4000.
- A read-only schema probe found 104 user tables and confirmed the required `Hotel`, `OtherSetting`, `PosPrinterSetting`, `RestaurantPOS_BillingInfoKOT`, and `RestaurantPOS_OrderedProductKOT` tables.
- The payment-provider dry run completes without contacting a payment terminal.
- The print-service dry run completes without creating a Windows print job.
- The integration-event dry run completes without publishing to an external endpoint.
- Crystal Reports can load `RestaurantPOS14.rptCreditCustomerBalance.rpt`: one table, zero parameters, and five sections were discovered, and a Crystal viewer control created its window handle.
- The invoice print smoke test rendered the exact reported `DIB-0008` dataset through `rptRestaurantPOSFinalBillKOTInvoice`, exported a non-empty PDF through the Microsoft Print to PDF route, and rejected a missing printer with a clear result without creating a Windows print job.
- The freshly rebuilt Debug application remained running throughout a bounded eight-second startup observation and was then stopped by the test harness.
- Visual Studio loads the solution and opens recovered VB source files.
- The untouched original `DBscript.sql` and `BlankDBscript.sql` schemas each created 104-table disposable databases and upgraded successfully to schema version 4.
- Both original-schema upgrade cases produced all 6 Advanced Setting columns, 3 printer compatibility columns, 21 invoice MyInvois columns, and the complete 11-column e-invoice queue.
- A second migration run preserved the upgraded legacy row counts, proving idempotency. Both uniquely named disposable databases were removed after verification.
- The configured `RPOS_DB` was upgraded and independently passed the complete current-schema check; repeated current-schema checks left the four migration-history rows unchanged.

The repeatable diagnostic source is `build\phase3\OperationalSmoke.vb`. Its configuration file now targets the same Crystal `13.0.3500.0` assembly version as the application and installed SP24 x86 runtime.

## Designer limitation

The Windows Forms designer was retried with `frmLogin.vb`. Visual Studio entered the `[Design]` view but refused to render the form, reporting one design-time parsing error at recovered line 1420 (`MyBase.SuspendLayout()` within `InitializeComponent`). This is a limitation of the one-file decompiler output, not a compiler error. No line-ending normalization, designer rewrite, or save was accepted during the check.

The application source remains buildable, but designer round-tripping is not claimed. Restoring designer compatibility would require a separate, behavior-sensitive normalization pass over recovered `InitializeComponent` methods and should not be mixed into the fidelity-preserving delivery.

## Environment readiness

- Windows printers detected: AnyDesk Printer, Brother DCP-T420W, Microsoft Print to PDF, OneNote, and PDF-XChange Lite.
- No COM ports were detected, so caller ID, weighing scale, customer display, cash drawer, and payment-terminal serial communication could not be exercised.
- The installed x86 Crystal runtime is SP24 `13.0.24.2970` and exposes assemblies versioned `13.0.3500.0`, matching the application's compile-time assemblies.

## Deliberately not executed

- No order, bill, settlement, tax, work-period, stock, or customer records were inserted, updated, or deleted.
- No real payment authorization, MyInvois submission, online-order publication, email, or Excel automation was attempted.
- No physical printer, cash-drawer, display, scale, caller-ID, or payment-terminal command was sent.

Those flows require representative test hardware, test credentials/endpoints, and an isolated database before they can be validated safely.
