#define MyAppName "RestaurantPOS14"
#define MyAppVersion GetVersionNumbersString("..\src\RestaurantPOS14\bin\Release\RestaurantPOS14.exe")
#define MyAppPublisher "Hitech Computers"
#define MyAppExeName "RestaurantPOS14.exe"
#define MyAppGuid "CF8D9C8A-8B39-4F0E-9F0D-9E0D1A23C2B4"
#define CrystalRuntimeVersion "13.0.24.2970"
#define VCRuntimeVersion "14.44.35211.0"

[Setup]
AppId={{CF8D9C8A-8B39-4F0E-9F0D-9E0D1A23C2B4}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
DefaultDirName={commonpf32}\Hitech Computers\RestaurantPOS14
DefaultGroupName=Hitech Computers\RestaurantPOS14
DisableProgramGroupPage=yes
UsePreviousAppDir=no
UninstallDisplayName={#MyAppName}
UninstallDisplayIcon={app}\{#MyAppExeName}
OutputDir=..\output\installer
OutputBaseFilename=Hitech_RestaurantPOS14_Setup_{#MyAppVersion}
SetupIconFile=..\src\RestaurantPOS14\app.ico
Compression=lzma2/ultra64
SolidCompression=yes
WizardStyle=modern
PrivilegesRequired=admin
MinVersion=6.1sp1
CloseApplications=yes
CloseApplicationsFilter={#MyAppExeName}
RestartApplications=no
SetupLogging=yes
VersionInfoVersion={#MyAppVersion}
VersionInfoCompany={#MyAppPublisher}
VersionInfoDescription={#MyAppName} installer
VersionInfoProductName={#MyAppName}
VersionInfoProductVersion={#MyAppVersion}
VersionInfoCopyright=Copyright (C) {#MyAppPublisher}

[Tasks]
Name: "desktopicon"; Description: "Create a desktop shortcut"; GroupDescription: "Additional shortcuts:"; Flags: unchecked

[InstallDelete]
Type: files; Name: "{app}\*.dll"
Type: files; Name: "{app}\*.pdb"
Type: files; Name: "{app}\{#MyAppExeName}"
Type: files; Name: "{app}\{#MyAppExeName}.config"
Type: files; Name: "{app}\AllReceiptRenderSmoke.*"
Type: files; Name: "{app}\InvoicePrintSmoke.*"
Type: files; Name: "{app}\ReportLayoutProbe.*"
Type: files; Name: "{app}\SstReceiptRenderSmoke.*"
Type: filesandordirs; Name: "{app}\lib"

[Dirs]
Name: "{app}\Menu Items Image"; Permissions: users-modify; Flags: uninsneveruninstall
Name: "{app}\PDF Reports"; Permissions: users-modify; Flags: uninsneveruninstall
Name: "{app}\Secondary Display Images"; Permissions: users-modify; Flags: uninsneveruninstall
Name: "{commonappdata}\RestaurantPOS14\InstallLogs"; Permissions: users-modify; Flags: uninsneveruninstall

[Files]
Source: "..\src\RestaurantPOS14\bin\Release\*"; DestDir: "{app}"; Excludes: "*.pdb,*.xml,*.ttf,LC.txt,*Smoke.*,ReportLayoutProbe.*,lib\*,Menu Items Image\*,PDF Reports\*,Secondary Display Images\*"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "..\src\RestaurantPOS14\bin\Release\*.xml"; DestDir: "{app}"; Permissions: users-modify; Flags: ignoreversion
Source: "..\src\RestaurantPOS14\bin\Release\LC.txt"; DestDir: "{app}"; Permissions: users-modify; Flags: ignoreversion onlyifdoesntexist uninsneveruninstall
Source: "..\src\RestaurantPOS14\bin\Release\IDAutomationHC39M.ttf"; DestDir: "{app}"; FontInstall: "IDAutomationHC39M"; Flags: ignoreversion onlyifdoesntexist uninsneveruninstall
Source: "..\src\RestaurantPOS14\bin\Release\Menu Items Image\*"; DestDir: "{app}\Menu Items Image"; Flags: ignoreversion onlyifdoesntexist recursesubdirs createallsubdirs uninsneveruninstall skipifsourcedoesntexist
Source: "..\src\RestaurantPOS14\bin\Release\Secondary Display Images\*"; DestDir: "{app}\Secondary Display Images"; Flags: ignoreversion onlyifdoesntexist recursesubdirs createallsubdirs uninsneveruninstall skipifsourcedoesntexist
Source: "prerequisites\NDP48-x86-x64-AllOS-ENU.exe"; Flags: dontcopy
Source: "prerequisites\CRRuntime_32bit_13_0_24.msi"; Flags: dontcopy
Source: "prerequisites\VC_redist.x86.exe"; Flags: dontcopy

[Icons]
Name: "{group}\RestaurantPOS14"; Filename: "{app}\{#MyAppExeName}"; WorkingDir: "{app}"
Name: "{group}\Uninstall RestaurantPOS14"; Filename: "{uninstallexe}"
Name: "{autodesktop}\RestaurantPOS14"; Filename: "{app}\{#MyAppExeName}"; WorkingDir: "{app}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "Launch RestaurantPOS14"; WorkingDir: "{app}"; Flags: nowait postinstall skipifsilent; Check: CanLaunchApplication

[Code]
const
  DotNet48Release = 528040;
  CrystalDisplayName = 'SAP Crystal Reports runtime engine for .NET Framework (32-bit)';
  CrystalRequiredVersion = '{#CrystalRuntimeVersion}';
  VCRuntimeRequiredVersion = '{#VCRuntimeVersion}';
  UninstallRoot = 'SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\';
  LegacyUninstallKey = '{CF8D9C8A-8B39-4F0E-9F0D-9E0D1A23C2B4}}_is1';
  CurrentUninstallKey = '{CF8D9C8A-8B39-4F0E-9F0D-9E0D1A23C2B4}_is1';

var
  PrerequisiteRestartRequired: Boolean;
  LegacyBackupDirectory: String;
  ProcessedUninstaller: String;

function IsSuccessfulInstallerExitCode(const ResultCode: Integer): Boolean;
begin
  Result := (ResultCode = 0) or (ResultCode = 1638) or
    (ResultCode = 1641) or (ResultCode = 3010);
end;

function IsRestartExitCode(const ResultCode: Integer): Boolean;
begin
  Result := (ResultCode = 1641) or (ResultCode = 3010);
end;

function ReadVersionPart(const Version: String; const PartIndex: Integer): Integer;
var
  I: Integer;
  CurrentPart: Integer;
  Digits: String;
begin
  Result := 0;
  CurrentPart := 0;
  Digits := '';

  for I := 1 to Length(Version) do
  begin
    if (Version[I] >= '0') and (Version[I] <= '9') then
      Digits := Digits + Version[I]
    else if Version[I] = '.' then
    begin
      if CurrentPart = PartIndex then
      begin
        Result := StrToIntDef(Digits, 0);
        exit;
      end;
      CurrentPart := CurrentPart + 1;
      Digits := '';
    end;
  end;

  if CurrentPart = PartIndex then
    Result := StrToIntDef(Digits, 0);
end;

function CompareVersions(const LeftVersion, RightVersion: String): Integer;
var
  I: Integer;
  LeftPart: Integer;
  RightPart: Integer;
begin
  Result := 0;
  for I := 0 to 3 do
  begin
    LeftPart := ReadVersionPart(LeftVersion, I);
    RightPart := ReadVersionPart(RightVersion, I);
    if LeftPart < RightPart then
    begin
      Result := -1;
      exit;
    end;
    if LeftPart > RightPart then
    begin
      Result := 1;
      exit;
    end;
  end;
end;

function IsDotNet48OrLaterInstalled: Boolean;
var
  ReleaseValue: Cardinal;
begin
  Result := False;
  if IsWin64 and RegQueryDWordValue(HKLM64,
    'SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full',
    'Release', ReleaseValue) then
    Result := ReleaseValue >= DotNet48Release;

  if (not Result) and RegQueryDWordValue(HKLM32,
    'SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full',
    'Release', ReleaseValue) then
    Result := ReleaseValue >= DotNet48Release;
end;

function IsRequiredVCRuntimeInstalled: Boolean;
var
  Installed: Cardinal;
  InstalledVersion: String;
begin
  Result := False;
  if RegQueryDWordValue(HKLM32,
    'SOFTWARE\Microsoft\VisualStudio\14.0\VC\Runtimes\x86',
    'Installed', Installed) and (Installed = 1) and
    RegQueryStringValue(HKLM32,
    'SOFTWARE\Microsoft\VisualStudio\14.0\VC\Runtimes\x86',
    'Version', InstalledVersion) then
    Result := CompareVersions(InstalledVersion, VCRuntimeRequiredVersion) >= 0;
end;

function IsRequiredCrystalRuntimeInstalled: Boolean;
var
  Subkeys: TArrayOfString;
  I: Integer;
  DisplayName: String;
  DisplayVersion: String;
  KeyName: String;
begin
  Result := False;
  if not RegGetSubkeyNames(HKLM32, UninstallRoot, Subkeys) then
    exit;

  for I := 0 to GetArrayLength(Subkeys) - 1 do
  begin
    KeyName := UninstallRoot + Subkeys[I];
    if RegQueryStringValue(HKLM32, KeyName, 'DisplayName', DisplayName) and
      (CompareText(DisplayName, CrystalDisplayName) = 0) and
      RegQueryStringValue(HKLM32, KeyName, 'DisplayVersion', DisplayVersion) and
      (CompareVersions(DisplayVersion, CrystalRequiredVersion) >= 0) then
    begin
      Result := True;
      exit;
    end;
  end;
end;

procedure SplitCommandLine(const CommandLine: String;
  var FileName, Parameters: String);
var
  P: Integer;
  Work: String;
begin
  Work := Trim(CommandLine);
  FileName := '';
  Parameters := '';
  if Work = '' then
    exit;

  if Work[1] = '"' then
  begin
    Delete(Work, 1, 1);
    P := Pos('"', Work);
    if P > 0 then
    begin
      FileName := Copy(Work, 1, P - 1);
      Parameters := Trim(Copy(Work, P + 1, MaxInt));
    end;
  end
  else
  begin
    P := Pos(' ', Work);
    if P = 0 then
      FileName := Work
    else
    begin
      FileName := Copy(Work, 1, P - 1);
      Parameters := Trim(Copy(Work, P + 1, MaxInt));
    end;
  end;
end;

function CopyDirectoryTree(const SourceDirectory, DestinationDirectory: String): Boolean;
var
  FindRec: TFindRec;
  SourcePath: String;
  DestinationPath: String;
begin
  Result := True;
  if not DirExists(SourceDirectory) then
    exit;

  if not ForceDirectories(DestinationDirectory) then
  begin
    Result := False;
    exit;
  end;

  if FindFirst(AddBackslash(SourceDirectory) + '*', FindRec) then
  begin
    try
      repeat
        if (FindRec.Name <> '.') and (FindRec.Name <> '..') then
        begin
          SourcePath := AddBackslash(SourceDirectory) + FindRec.Name;
          DestinationPath := AddBackslash(DestinationDirectory) + FindRec.Name;
          if (FindRec.Attributes and FILE_ATTRIBUTE_DIRECTORY) <> 0 then
          begin
            if not CopyDirectoryTree(SourcePath, DestinationPath) then
              Result := False;
          end
          else if not CopyFile(SourcePath, DestinationPath, False) then
            Result := False;
        end;
      until not FindNext(FindRec);
    finally
      FindClose(FindRec);
    end;
  end;
end;

function BackupFileIfPresent(const SourcePath, DestinationName: String): Boolean;
begin
  Result := True;
  if FileExists(SourcePath) then
  begin
    if not ForceDirectories(LegacyBackupDirectory) then
      Result := False
    else
      Result := CopyFile(SourcePath,
        AddBackslash(LegacyBackupDirectory) + DestinationName, False);
  end;
end;

function BackupLegacyDataFrom(const InstallDirectory: String): Boolean;
begin
  Result := True;
  if not DirExists(InstallDirectory) then
    exit;

  Log('Backing up legacy user data from ' + InstallDirectory);
  Result := BackupFileIfPresent(AddBackslash(InstallDirectory) + 'LC.txt',
    'LC.txt') and Result;
  Result := BackupFileIfPresent(AddBackslash(InstallDirectory) + 'SQLSettings.dat',
    'SQLSettings.dat') and Result;
  Result := BackupFileIfPresent(AddBackslash(InstallDirectory) + 'EInvoiceConfig.json',
    'EInvoiceConfig.json') and Result;
  Result := BackupFileIfPresent(AddBackslash(InstallDirectory) +
    'RestaurantPOS14.exe.config', 'RestaurantPOS14.exe.config.legacy') and Result;
  Result := CopyDirectoryTree(AddBackslash(InstallDirectory) + 'Menu Items Image',
    AddBackslash(LegacyBackupDirectory) + 'Menu Items Image') and Result;
  Result := CopyDirectoryTree(AddBackslash(InstallDirectory) + 'PDF Reports',
    AddBackslash(LegacyBackupDirectory) + 'PDF Reports') and Result;
  Result := CopyDirectoryTree(AddBackslash(InstallDirectory) +
    'Secondary Display Images', AddBackslash(LegacyBackupDirectory) +
    'Secondary Display Images') and Result;
end;

procedure RestoreLegacyData;
var
  AppDirectory: String;
begin
  if (LegacyBackupDirectory = '') or
    (not DirExists(LegacyBackupDirectory)) then
    exit;

  AppDirectory := ExpandConstant('{app}');
  Log('Restoring preserved user data to ' + AppDirectory);
  if FileExists(AddBackslash(LegacyBackupDirectory) + 'LC.txt') then
    CopyFile(AddBackslash(LegacyBackupDirectory) + 'LC.txt',
      AddBackslash(AppDirectory) + 'LC.txt', False);
  if FileExists(AddBackslash(LegacyBackupDirectory) + 'SQLSettings.dat') then
    CopyFile(AddBackslash(LegacyBackupDirectory) + 'SQLSettings.dat',
      AddBackslash(AppDirectory) + 'SQLSettings.dat', False);
  if FileExists(AddBackslash(LegacyBackupDirectory) + 'EInvoiceConfig.json') then
    CopyFile(AddBackslash(LegacyBackupDirectory) + 'EInvoiceConfig.json',
      AddBackslash(AppDirectory) + 'EInvoiceConfig.json', False);
  if FileExists(AddBackslash(LegacyBackupDirectory) +
    'RestaurantPOS14.exe.config.legacy') then
    CopyFile(AddBackslash(LegacyBackupDirectory) +
      'RestaurantPOS14.exe.config.legacy', AddBackslash(AppDirectory) +
      'RestaurantPOS14.exe.config.legacy', False);
  CopyDirectoryTree(AddBackslash(LegacyBackupDirectory) + 'Menu Items Image',
    AddBackslash(AppDirectory) + 'Menu Items Image');
  CopyDirectoryTree(AddBackslash(LegacyBackupDirectory) + 'PDF Reports',
    AddBackslash(AppDirectory) + 'PDF Reports');
  CopyDirectoryTree(AddBackslash(LegacyBackupDirectory) +
    'Secondary Display Images', AddBackslash(AppDirectory) +
    'Secondary Display Images');
end;

function RunLegacyUninstaller(const RootKey: Integer;
  const KeyName: String): String;
var
  CommandLine: String;
  FileName: String;
  Parameters: String;
  InstallLocation: String;
  ResultCode: Integer;
begin
  Result := '';
  if RegQueryStringValue(RootKey, UninstallRoot + KeyName,
    'InstallLocation', InstallLocation) then
  begin
    if not BackupLegacyDataFrom(RemoveBackslashUnlessRoot(InstallLocation)) then
    begin
      Result := 'The existing RestaurantPOS14 data could not be backed up. ' +
        'Setup stopped before uninstalling the old version.';
      exit;
    end;
  end;

  if not RegQueryStringValue(RootKey, UninstallRoot + KeyName,
    'QuietUninstallString', CommandLine) then
    RegQueryStringValue(RootKey, UninstallRoot + KeyName,
      'UninstallString', CommandLine);

  if CommandLine = '' then
    exit;

  SplitCommandLine(CommandLine, FileName, Parameters);
  if (FileName = '') or (CompareText(FileName, ProcessedUninstaller) = 0) then
    exit;

  if Pos('/VERYSILENT', Uppercase(Parameters)) = 0 then
    Parameters := Parameters + ' /VERYSILENT /SUPPRESSMSGBOXES /NORESTART';

  Log('Removing previous RestaurantPOS14 version with ' + FileName);
  if not Exec(FileName, Trim(Parameters), '', SW_HIDE,
    ewWaitUntilTerminated, ResultCode) then
  begin
    Result := 'Windows could not start the previous RestaurantPOS14 uninstaller.';
    exit;
  end;

  if not IsSuccessfulInstallerExitCode(ResultCode) then
  begin
    Result := 'The previous RestaurantPOS14 version could not be removed ' +
      '(exit code ' + IntToStr(ResultCode) + ').';
    exit;
  end;

  ProcessedUninstaller := FileName;
  if IsRestartExitCode(ResultCode) then
    PrerequisiteRestartRequired := True;
end;

function InstallPrerequisite(const FileName, Parameters,
  FriendlyName: String): String;
var
  ResultCode: Integer;
begin
  Result := '';
  Log('Installing prerequisite: ' + FriendlyName);
  if not Exec(ExpandConstant('{tmp}\' + FileName), Parameters, '', SW_HIDE,
    ewWaitUntilTerminated, ResultCode) then
  begin
    Result := 'Windows could not start the ' + FriendlyName + ' installer.';
    exit;
  end;

  if not IsSuccessfulInstallerExitCode(ResultCode) then
  begin
    Result := FriendlyName + ' could not be installed (exit code ' +
      IntToStr(ResultCode) + '). See ' +
      ExpandConstant('{commonappdata}\RestaurantPOS14\InstallLogs') +
      ' for the prerequisite log.';
    exit;
  end;

  if IsRestartExitCode(ResultCode) then
    PrerequisiteRestartRequired := True;
end;

function PrepareToInstall(var NeedsRestart: Boolean): String;
var
  LegacyDirectory: String;
  ErrorMessage: String;
  LogDirectory: String;
  ResultCode: Integer;
begin
  Result := '';
  LegacyBackupDirectory := ExpandConstant('{tmp}\RestaurantPOS14-LegacyData');
  LogDirectory := ExpandConstant('{commonappdata}\RestaurantPOS14\InstallLogs');
  ForceDirectories(LegacyBackupDirectory);
  ForceDirectories(LogDirectory);

  LegacyDirectory := ExpandConstant('{commonpf32}\Hi Tech Computers\Rest Touch\RestaurantPOS14');
  if not BackupLegacyDataFrom(LegacyDirectory) then
  begin
    Result := 'The legacy RestaurantPOS14 data could not be backed up.';
    exit;
  end;
  if not BackupLegacyDataFrom(ExpandConstant('{app}')) then
  begin
    Result := 'The current RestaurantPOS14 data could not be backed up.';
    exit;
  end;

  ErrorMessage := RunLegacyUninstaller(HKLM32, LegacyUninstallKey);
  if ErrorMessage = '' then
    ErrorMessage := RunLegacyUninstaller(HKCU, LegacyUninstallKey);
  if ErrorMessage = '' then
    ErrorMessage := RunLegacyUninstaller(HKLM32, CurrentUninstallKey);
  if ErrorMessage = '' then
    ErrorMessage := RunLegacyUninstaller(HKCU, CurrentUninstallKey);
  if ErrorMessage <> '' then
  begin
    Result := ErrorMessage;
    exit;
  end;

  if not IsDotNet48OrLaterInstalled then
  begin
    ExtractTemporaryFile('NDP48-x86-x64-AllOS-ENU.exe');
    ErrorMessage := InstallPrerequisite('NDP48-x86-x64-AllOS-ENU.exe',
      '/q /norestart /log "' + AddBackslash(LogDirectory) + 'dotnet48.log"',
      'Microsoft .NET Framework 4.8');
    if ErrorMessage <> '' then
    begin
      Result := ErrorMessage;
      exit;
    end;
  end;

  if not IsRequiredVCRuntimeInstalled then
  begin
    ExtractTemporaryFile('VC_redist.x86.exe');
    ErrorMessage := InstallPrerequisite('VC_redist.x86.exe',
      '/install /quiet /norestart /log "' + AddBackslash(LogDirectory) +
      'vc_redist_x86.log"', 'Microsoft Visual C++ 2015-2022 Runtime (x86)');
    if ErrorMessage <> '' then
    begin
      Result := ErrorMessage;
      exit;
    end;
  end;

  if not IsRequiredCrystalRuntimeInstalled then
  begin
    ExtractTemporaryFile('CRRuntime_32bit_13_0_24.msi');
    Log('Installing prerequisite: SAP Crystal Reports Runtime 13.0.24 (x86)');
    if not Exec(ExpandConstant('{sys}\msiexec.exe'),
      '/i "' + ExpandConstant('{tmp}\CRRuntime_32bit_13_0_24.msi') +
      '" /qn /norestart /L*v "' + AddBackslash(LogDirectory) +
      'crystal_runtime_x86.log"', '', SW_HIDE, ewWaitUntilTerminated,
      ResultCode) then
      ErrorMessage := 'Windows could not start the SAP Crystal Reports Runtime installer.'
    else if not IsSuccessfulInstallerExitCode(ResultCode) then
    begin
      ErrorMessage := 'SAP Crystal Reports Runtime 13.0.24 (x86) could not ' +
        'be installed (exit code ' + IntToStr(ResultCode) + '). See ' +
        AddBackslash(LogDirectory) + 'crystal_runtime_x86.log.';
    end
    else if IsRestartExitCode(ResultCode) then
    begin
      PrerequisiteRestartRequired := True;
    end;
    if ErrorMessage <> '' then
    begin
      Result := ErrorMessage;
      exit;
    end;
  end;

  NeedsRestart := PrerequisiteRestartRequired;
end;

procedure CurStepChanged(CurStep: TSetupStep);
begin
  if CurStep = ssPostInstall then
    RestoreLegacyData;
end;

function NeedRestart: Boolean;
begin
  Result := PrerequisiteRestartRequired;
end;

function CanLaunchApplication: Boolean;
begin
  Result := not PrerequisiteRestartRequired;
end;
