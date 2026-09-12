# Building RestaurantPOS14

RestaurantPOS14 is a recovered, old-style VB.NET WinForms solution targeting .NET Framework 4.8 and x86. Only `Debug|x86` and `Release|x86` are supported.

## Known-good build environment

The final delivery was built on Windows with:

- Visual Studio 2022 Community 17.14 (`devenv.exe` product version `17.14.36930.0`)
- Visual Studio **.NET desktop development** workload, including the VB compiler
- MSBuild for .NET Framework `17.14.40.60911`
- .NET Framework 4.8 Developer Pack/targeting pack
- PowerShell 7 or Windows PowerShell 5.1 for the commands below

The project is not SDK-style. Use the Visual Studio MSBuild executable rather than `dotnet build` so the legacy WinForms, resource, manifest, and VB targets are available.

## Binary dependencies

All compile-time third-party references are supplied under `src\RestaurantPOS14\lib` and use relative `HintPath` entries. There is no NuGet restore step. The principal shipped versions are:

| Component | Shipped assembly version |
|---|---:|
| SAP Crystal Reports for .NET Framework | `13.0.3500.0` |
| Telerik UI for WinForms | `2020.1.113.40` |
| MetroFramework | `1.4.0.0` |
| Newtonsoft.Json | `9.0.0.0` |
| Microsoft SQL Server SMO/ConnectionInfo | `10.0.0.0` |
| Microsoft Office Excel interop | `14.0.0.0` |

See [DEPENDENCIES.md](DEPENDENCIES.md) for the complete file, version, public-key-token, platform, and SHA-256 inventory. These DLLs are binary references only; no third-party component was decompiled.

The local DLLs and embedded `RestaurantPOS14.exe.licenses` resource are sufficient for command-line compilation. Visual Studio designer support for vendor controls may require the corresponding licensed Telerik/Crystal developer installation. A direct designer retry is documented in [OPERATIONAL_VALIDATION.md](OPERATIONAL_VALIDATION.md); designer round-tripping for the recovered one-file forms is not asserted.

## Build commands

Run from the repository root in PowerShell:

```powershell
$msbuild = 'C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\MSBuild.exe'
$solution = '.\src\RestaurantPOS14\RestaurantPOS14.sln'

& $msbuild $solution /t:Rebuild /p:Configuration=Debug /p:Platform=x86 /m /nologo /v:normal
& $msbuild $solution /t:Rebuild /p:Configuration=Release /p:Platform=x86 /m /nologo /v:normal
```

To retain verification logs:

```powershell
New-Item -ItemType Directory -Force '.\build\logs' | Out-Null
& $msbuild $solution /t:Rebuild /p:Configuration=Debug /p:Platform=x86 /m /nologo /v:normal *> '.\build\logs\phase3-final-debug-x86.log'
& $msbuild $solution /t:Rebuild /p:Configuration=Release /p:Platform=x86 /m /nologo /v:normal *> '.\build\logs\phase3-final-release-x86.log'
```

Build outputs are written to:

- Debug: `src\RestaurantPOS14\bin\Debug\RestaurantPOS14.exe`
- Release: `src\RestaurantPOS14\bin\Release\RestaurantPOS14.exe`

Copy or deploy the complete output directory. The executable depends on the copied DLLs, SQL scripts, XML files, fonts, report assets, and image/output directories beside it.

## Setup installer

The supported workstation package is built with `installer\Build-Installer.ps1`. It rebuilds `Release|x86`, verifies the bundled prerequisite installers by SHA-256, and creates a single setup executable under `output\installer`.

The package installs to `%ProgramFiles(x86)%\Hitech Computers\RestaurantPOS14`, silently installs missing/older .NET 4.8, Visual C++ x86, and Crystal Reports x86 runtimes, and preserves writable licence, image, and PDF data across upgrades. It also detects and removes the original `%ProgramFiles(x86)%\Hi Tech Computers\Rest Touch\RestaurantPOS14` Inno Setup installation.

## Project invariants

- Platform must remain `x86`; do not introduce Any CPU solution mappings.
- Target framework must remain `.NET Framework 4.8`.
- `Option Strict` remains `Off` because the recovered code relies on VB implicit conversion and late binding.
- The root namespace remains blank because source files declare `Namespace RestaurantPOS14` explicitly.
- `<MyType>Empty</MyType>` remains intentional because the recovered `RestaurantPOS14.My` implementation is compiled directly.
- Crystal `.rpt`, form `.resx`, and `RestaurantPOS14.exe.licenses` files remain embedded resources.
- Do not replace the supplied vendor DLLs with arbitrary newer versions; Crystal and Telerik binding/API compatibility is version-sensitive.

## Runtime prerequisites

For a production terminal, install or provide:

- Windows with the .NET Framework 4.8 runtime
- SAP Crystal Reports runtime for .NET Framework **x86**, SP24 file version `13.0.24.2970` / assembly version `13.0.3500.0`, for report preview, printing, and export
- Network access and credentials for the configured SQL Server/database
- Microsoft Excel/Office when using recovered Excel automation workflows
- Vendor drivers and reachable COM/network devices for configured printers, cash drawer, customer display, caller ID, weighing scale, and Ingenico terminal

Runtime settings are layered as documented in [CONFIGURATION.md](CONFIGURATION.md). Machine settings live at `%ProgramData%\RestaurantPOS14\settings.json`; terminal settings and DPAPI-protected secrets live under `%LocalAppData%\RestaurantPOS14`. DPAPI secrets are bound to the Windows user that created them and must be provisioned separately for each service/user profile.

## Known build warnings

The post-delivery Debug and Release rebuilds each produce 12 recovered-source warnings and 0 errors:

| Code | Count | Reason retained |
|---|---:|---|
| `BC40054` | 10 | Recovered pizza-form constructors do not call `InitializeComponent`; changing constructor behavior was outside the fidelity-safe delivery scope. |
| `BC40000` | 1 | Recovered system-info code calls obsolete `Dns.GetHostByName`. |
| `BC42356` | 1 | A recovered `Async` method contains no `Await`. |

Eight `BC42030` warnings were removed by explicitly initializing the affected `ByRef` locals to `Nothing`, preserving their previous runtime value. One `BC40003` warning was removed with an explicit `Shadows` modifier, preserving the recovered typed-DataSet API. The remaining warnings are documented rather than suppressed globally. The authoritative post-delivery logs are `build\logs\postdelivery-final-debug-x86.log` and `build\logs\postdelivery-final-release-x86.log`.

## Troubleshooting

- **Reference not found:** confirm `src\RestaurantPOS14\lib` is present and unchanged.
- **`BadImageFormatException`:** build and run x86, and install the x86 Crystal runtime rather than relying only on an x64 runtime.
- **Crystal assembly/version error:** verify the installed runtime matches the shipped `13.0.3500.0` assemblies and preserve the binding redirects in `App.config`.
- **Connection failure:** configure the layered protected connection; do not restore plaintext passwords to `App.config` or `SQLSettings.dat`.
- **Application starts but hardware does not respond:** verify terminal-specific ports, printer assignments, feature flags, and restart-required settings in `CONFIGURATION.md`.
