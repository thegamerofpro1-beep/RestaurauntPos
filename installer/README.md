# RestaurantPOS14 installer

The generated setup installs RestaurantPOS14 to:

`%ProgramFiles(x86)%\Hitech Computers\RestaurantPOS14`

It includes and silently installs the core workstation prerequisites when the installed version is missing or older:

- Microsoft .NET Framework 4.8 (offline installer)
- Microsoft Visual C++ 2015-2022 Redistributable (x86), version 14.44.35211.0
- SAP Crystal Reports runtime for .NET Framework (x86), version 13.0.24.2970
- the IDAutomationHC39M barcode font

The SAP package removes older Crystal 13.x x86 products through its MSI upgrade table. The Microsoft redistributable upgrades the shared x86 runtime in place. Newer compatible Crystal, Visual C++, and .NET releases are retained rather than downgraded or removed.

The setup recognizes the former Inno Setup product and legacy location at `%ProgramFiles(x86)%\Hi Tech Computers\Rest Touch\RestaurantPOS14`. It backs up the licence file, legacy database/e-invoice configuration, menu images, exported PDFs, and secondary-display images before silently removing the former version. The preserved data is restored to the new installation. Future releases use a stable AppId so setup upgrades replace the previous release instead of creating a duplicate installation.

The database is stored in SQL Server and is not deleted by setup or uninstall. Database schema upgrades are performed by the application at startup. SQL Server itself, Microsoft Office, printer/terminal drivers, and other hardware-specific drivers are external services or licensed integrations and are not installed by this workstation package.

## Build

From the repository root:

```powershell
.\installer\Build-Installer.ps1
```

Use `-SkipAppBuild` only when the current `Release|x86` output has already been rebuilt and verified.

The setup executable and its SHA-256 file are written to `output\installer`.

For unattended deployment:

```powershell
Hitech_RestaurantPOS14_Setup_14.1.5.0.exe /VERYSILENT /SUPPRESSMSGBOXES /NORESTART
```

Prerequisite installation logs are kept under `%ProgramData%\RestaurantPOS14\InstallLogs`.
