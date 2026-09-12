# Defensive code audit

## Scope

The audit covered all 603 Visual Basic files in `src/RestaurantPOS14/RestaurantPOS14` (approximately 489,655 lines), the application startup path, database compatibility layer, printing and Crystal report wrappers, external integrations, and the installer inputs. The application is recovered/decompiled .NET Framework 4.8 WinForms code, so the checks combine compiler validation, security scanning, targeted pattern analysis, and bounded smoke tests.

"No findings" below means no match remains for the stated check. It is not a mathematical guarantee that a legacy application has no possible defect, especially without representative POS hardware, real payment/MyInvois credentials, and an isolated production-sized database.

## Changes applied

- Added application-level UI-thread and AppDomain exception logging with 5 MB rotation.
- Replaced 61 silent exception handlers with diagnostic logging, including 13 Crystal report initialization handlers.
- Added 141 selected-row count guards covering all 140 direct `SelectedRows(0)` access sites (some methods share one guard).
- Added 195 typed/escaped SQL input guards across direct legacy query construction. New integration and authentication queries use SQL parameters.
- Added safe division and currency-rounding bounds; all identified variable-denominator calculations now fail closed to zero.
- Removed the backup-folder deletion loop. Exiting with automatic backup no longer deletes unrelated files.
- Repaired 10 forms that touched controls before `InitializeComponent`.
- Replaced abrupt `ProjectData.EndApp` calls with graceful WinForms shutdown.
- Added null-safe KDS cleanup and guarded failures when optional Windows utilities are unavailable.
- Added HTTPS-only external endpoint validation, bounded network timeouts, explicit response disposal, URL encoding, and safe browser launching. Loopback HTTP remains available only for a locally installed SMS gateway.
- Added salted PBKDF2 PIN storage, constant-time comparison, legacy Base64 PIN compatibility with upgrade-on-login, failed-login throttling, and cryptographically random temporary PINs.
- Reworked PIN recovery so the existing PIN is never decoded and emailed.
- Removed fabricated MyInvois success data when API credentials are missing.

## Verification results

| Check | Result |
| --- | --- |
| Release x86 compile | 0 warnings, 0 errors |
| Microsoft DevSkim, application-authored code | 0 findings |
| Silent/empty catch blocks | 0 |
| Abrupt `ProjectData.EndApp` calls | 0 |
| Weak-crypto API markers | 0 |
| Forced TLS protocol overrides | 0 |
| Binary formatter/deserialization markers | 0 |
| Unsafe identified `Val` divisions | 0 |
| Direct selected-row access without nearby count guard | 0 |
| `While True` blocks without an `Exit While` in the recovered loop body | 0 |
| Defensive guard smoke test | Passed |

The DevSkim run excludes `RPOS_DBDataSet*.vb`. Those two generated typed-DataSet files contain W3C XML namespace identifiers beginning with `http://`; they are schema identifiers, not outbound network endpoints.

## Runtime diagnostics

Unexpected errors are written to:

`%LocalAppData%\Hitech Computers\RestaurantPOS14\Logs\application.log`

The active file rotates to `application.previous.log` at 5 MB. User-facing messages avoid exposing SMTP credentials, access tokens, and raw integration responses; diagnostic details remain local.

## Architectural constraints

- `Option Strict Off` is retained because enabling it across the decompiled source produces behavior-sensitive conversion changes. New guard modules use explicit conversion and validation.
- Much of the original application still uses shared `ModClasses` database fields. Critical new and modified paths use local `Using` scopes; replacing every shared access should be a separate, database-backed regression project.
- Windows Forms designer round-tripping remains limited by the one-file decompiler layout described in `OPERATIONAL_VALIDATION.md`.
- Physical receipt/kitchen printers, cash drawer, serial displays/scales, payment terminals, SMTP, SMS gateway, and MyInvois production submission were not invoked during this safety audit.
- The application and installer are not Authenticode-signed because no publisher code-signing certificate is configured. The installer build emits a SHA-256 manifest for integrity checking, but production distribution should add certificate signing and timestamping.

## Repeating the checks

Build the application:

```powershell
& 'C:\Program Files (x86)\Microsoft Visual Studio\2022\BuildTools\MSBuild\Current\Bin\MSBuild.exe' `
  src\RestaurantPOS14\RestaurantPOS14.vbproj /t:Rebuild `
  /p:Configuration=Release /p:Platform=x86 /m /v:minimal
```

Run the compiled smoke test:

```powershell
build\phase3\DefensiveGuardSmoke.exe `
  src\RestaurantPOS14\bin\Release\RestaurantPOS14.exe
```

The final SARIF report is `build/logs/devskim-audit-final.sarif`.
