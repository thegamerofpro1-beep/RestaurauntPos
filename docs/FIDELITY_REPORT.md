# RestaurantPOS14 Phase 1 Fidelity Report

Date: 2026-08-30

## Result

Phase 1 produces a buildable VB.NET reconstruction at `src/RestaurantPOS14`.
Both required x86 configurations rebuild with **0 errors**. The rebuilt executable
launches, remains responsive, creates a WinForms window, and contains every original
embedded resource byte-for-byte.

The rebuilt executable is not byte-identical to the supplied executable. The remaining
assembly differences are documented below and are dominated by C# versus VB compiler
artifacts. No third-party DLL was decompiled.

## Authoritative inputs and outputs

- Original executable: `RestaurantPOS14/RestaurantPOS14.exe`
- Original executable SHA-256: `5B9F7CC4D86E2377F7EFBEF396B86698417F650A8DDCD2850305C289D8539B71`
- Reconstructed solution: `src/RestaurantPOS14/RestaurantPOS14.sln`
- Reconstructed project: `src/RestaurantPOS14/RestaurantPOS14.vbproj`
- Reconstructed application sources: `src/RestaurantPOS14/RestaurantPOS14`
- Rebuilt Release executable: `src/RestaurantPOS14/bin/Release/RestaurantPOS14.exe`
- Rebuilt Release SHA-256: `A2549C47DF273A899669E6BC539275A8611E8D972D9A90C91D9AB50C2EFC180E`
- Final rebuilt-assembly decompilation: `build/fidelity/rebuilt-release-csharp-phase1`
- Original metadata inventory: `build/fidelity/original-metadata.json`
- Rebuilt metadata inventory: `build/fidelity/rebuilt-release-metadata.json`

Source inventory, excluding generated `obj` files:

- 575 VB files: 574 application files plus `Properties/AssemblyInfo.vb`
- 208 `.resx` files
- 71 Crystal `.rpt` files
- 35 copied third-party DLLs in `src/RestaurantPOS14/lib`

## Build verification

| Configuration | Platform | Result | Warnings | Log |
|---|---:|---:|---:|---|
| Debug | x86 | 0 errors | 21 | `build/logs/phase1-debug-x86.log` |
| Release | x86 | 0 errors | 21 | `build/logs/phase1-release-x86.log` |

The final log summaries are:

```text
Debug|x86:   21 Warning(s), 0 Error(s), Time Elapsed 00:00:08.11
Release|x86: 21 Warning(s), 0 Error(s), Time Elapsed 00:00:08.30
```

The 21 retained warnings are one generated `DataRow.Item` shadow warning, ten
designer-constructor warnings from the original pizza forms, one obsolete DNS API
warning, eight possibly-unassigned `ByRef` arguments in `frmPOS`, and one async method
without `Await`. They were not changed because doing so would alter recovered behavior.

## Assembly metadata comparison

| Item | Original | Rebuilt | Result |
|---|---:|---:|---|
| File length | 45,508,096 | 45,578,752 | differs by 70,656 bytes |
| Assembly name | RestaurantPOS14 | RestaurantPOS14 | exact |
| Assembly version | 14.1.5.0 | 14.1.5.0 | exact |
| PE machine | I386 | I386 | exact |
| CLR flags | ILOnly, Requires32Bit | ILOnly, Requires32Bit | exact |
| All metadata types | 1,295 | 1,289 | compiler-generated types differ |
| Top-level types | 579 | 577 | compiler-generated types differ |
| Methods | 38,031 | 38,051 | compiler-generated methods differ |
| Fields | 12,017 | 11,987 | compiler-generated fields differ |
| Properties | 12,654 | 12,654 | exact total |
| Events | 684 | 684 | exact total |
| Manifest resources | 280 | 280 | exact names and bytes |

All 574 non-compiler top-level application type names are present in both assemblies.
Across the complete type inventory, 1,267 names are shared and 1,263 of those have
exact method/field/property/event/nested-type counts. The four shared types with member
count differences are:

- `RestaurantPOS14.EInvoicing.EInvoiceClient`
- `RestaurantPOS14.frmAdvancedSettings`
- `RestaurantPOS14.frmEInvoicePreview`
- `RestaurantPOS14.frmPOS`

Those differences are generated late-binding/lambda methods. The original executable
contains 28 C#-compiler-only types that the VB build does not emit: three C# anonymous
types, two embedded compiler attributes, four dynamic call-site holder types, and
nineteen C# async state machines. The rebuild instead contains three VB anonymous types
and nineteen VB async state machines. The original's `Microsoft.CSharp` assembly
reference is consequently absent from the VB build; its dynamic calls are compiled as
VB late binding. All assembly custom attributes match.

## Resource parity

Every one of the 280 manifest resource names has an identical SHA-256 hash in the
original and rebuilt executable:

- 208 managed `.resources` containers
- 71 Crystal `.rpt` reports
- 1 `RestaurantPOS14.exe.licenses` resource

The managed resource audit parsed 1,057 named entries without deserializing any object.
All entry names, type identities, payload lengths, and payload bytes match. During this
audit, 1,056 ILSpy-exported non-string entries were corrected from the `bytearray` MIME
tag to the original binary-serialized MIME tag; after rebuilding, the complete embedded
resource bytes became identical.

All 71 `FullResourceName` values in the Crystal wrapper classes map to an extracted
`.rpt` file and to a real manifest resource. No report file or wrapper resource is
missing.

## Recovered behavior checks

- 109 original disposal scopes are represented by 109 VB `Using` statements.
- All 684 typed-DataSet event members are present.
- Sixteen Crystal report constructors that update VAT/service-charge labels were
  restored, including traversal of main reports and subreports.
- Conversion markers are clean: no `TODO`, `Cannot convert`, `CSharpImpl`, or C#
  `dynamic` marker remains in application VB sources.
- `App.config` is byte-identical to the supplied `RestaurantPOS14.exe.config`
  (SHA-256 `4730A4035CBB03A49C30BD5F16BCD277AE0C8B13C839A6055DF8E307F54E2493`).
- The configuration API resolves
  `RestaurantPOS14.My.MySettings.RPOS_DBConnectionString` as a
  `System.Data.SqlClient` connection string.

## Smoke test

The Release executable was started from its output directory in a hidden, bounded test.
It remained alive and responsive and created a non-zero WinForms main-window handle
after approximately 6.7 seconds. The exact launched process was then terminated by PID.
This confirms startup reached the UI rather than failing during assembly/resource load.

An interactive Crystal preview and a live SQL transaction were not exercised. They
require the configured SQL Server (`DESKTOP-PUEKG2K`, database `RPOS_DB`), valid data,
and a user-driven report workflow. Static verification confirms the connection-string
entry and all Crystal report/resource mappings, but this report does not claim a live
database or preview test.

## Known deviations and rationale

1. **The binary is not byte-identical.** The source language and compiler differ, so
   compiler-generated anonymous, async, lambda, and late-binding machinery differs.
2. **The supplied executable is a C# assembly, despite the target reconstruction being
   VB.NET.** Its PDB-backed source inventory contains C# documents. The VB tree was
   reconstructed from the authoritative C# intermediate while preserving the observed
   runtime behavior and public application identifiers.
3. **Forms remain one source file per recovered top-level type.** They were not split
   into `.vb` and `.Designer.vb`, and the recovered `AccessedThroughProperty` wrappers
   were retained. Removing those members would materially worsen metadata parity with
   this C#-compiled original. WinForms designer round-tripping is therefore not asserted.
4. **Recovered `RestaurantPOS14.My` types are compiled directly.** The project uses
   `<MyType>Empty</MyType>` instead of regenerating them with `<MyType>WindowsForms</MyType>`.
   Enabling generated My types produced duplicate definitions and lower fidelity because
   the executable already contains the recovered implementations.
5. **Root namespace is intentionally blank.** Each recovered source already declares
   `Namespace RestaurantPOS14`; setting the project root namespace to the same value
   would incorrectly produce `RestaurantPOS14.RestaurantPOS14.*` types.
6. **Typed DataSets remain recovered generated VB source.** No `.xsd` regeneration is
   asserted; this is the prompt's documented fallback when reliable schema
   reconstruction is unavailable.
7. **No Git baseline tag was created.** `L:\New Restauraunt Pos` is not a Git repository.

## Phase gate

The Phase 1 gate conditions that can be completed locally are met: Debug and Release x86
build with zero errors, the fidelity inventories and rebuilt-assembly decompilation are
present, resource parity is exact, and this report records every known deviation. This
report describes the frozen Phase 1 baseline. Phase 2 customizability was subsequently
completed; its additive deviations are recorded in `CHANGELOG.md`, `CONFIGURATION.md`,
and `ARCHITECTURE.md`.
