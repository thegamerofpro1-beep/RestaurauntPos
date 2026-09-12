# Hitech Restaurant POS

Windows restaurant point-of-sale application written in VB.NET for .NET Framework 4.8, SQL Server and SAP Crystal Reports.

The current source includes the SST and service-charge receipt work, legacy-database migrations, guarded receipt/cash-drawer printing, faster front/back-office loading, safe unpaid-bill cancellation, secondary customer-display options and final-bill rounding.

## Open on another PC with Codex

1. Sign in to GitHub and Codex with an account that can access this private repository.
2. Clone the repository in Codex or with `git clone <repository-url>`.
3. Open `New Restauraunt Pos.sln` from `src/RestaurantPOS14`.
4. Read `AGENTS.md`, `docs/BUILD.md`, `docs/CONFIGURATION.md` and `docs/DATABASE_UPGRADES.md` before changing or running the application.

Machine-specific database credentials are not stored in Git. Configure them locally through the application or an ignored `appsettings.json`. Generated installers, runtime prerequisites, build output, logs and temporary receipt/PDF output are intentionally excluded.

## Build

Use Visual Studio 2022 Build Tools with the .NET desktop workload and target `Release|x86`:

```powershell
& 'C:\Program Files (x86)\Microsoft Visual Studio\2022\BuildTools\MSBuild\Current\Bin\MSBuild.exe' `
  '.\src\RestaurantPOS14\RestaurantPOS14.vbproj' `
  /t:Rebuild /p:Configuration=Release /p:Platform=x86 /m
```

The required application reference assemblies are kept under `src/RestaurantPOS14/lib`. A working machine also needs SQL Server access, .NET Framework 4.8, the 32-bit Crystal Reports runtime and the x86 Visual C++ runtime. See `docs/BUILD.md` for the validated versions and installer workflow.

## Repository policy

This is commercial application source and is published as a private repository. No open-source licence is granted. Do not make the repository public or redistribute bundled third-party assemblies without reviewing their licences.
