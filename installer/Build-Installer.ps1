[CmdletBinding()]
param(
    [switch]$SkipAppBuild
)

$ErrorActionPreference = 'Stop'
$repoRoot = Split-Path -Parent $PSScriptRoot
$solutionPath = Join-Path $repoRoot 'src\RestaurantPOS14\RestaurantPOS14.sln'
$releaseExe = Join-Path $repoRoot 'src\RestaurantPOS14\bin\Release\RestaurantPOS14.exe'
$setupScript = Join-Path $PSScriptRoot 'RestaurantPOS14.iss'
$prerequisiteDirectory = Join-Path $PSScriptRoot 'prerequisites'

$msbuildCandidates = @(
    'C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\MSBuild.exe',
    'C:\Program Files\Microsoft Visual Studio\2022\Professional\MSBuild\Current\Bin\MSBuild.exe',
    'C:\Program Files\Microsoft Visual Studio\2022\Enterprise\MSBuild\Current\Bin\MSBuild.exe',
    'C:\Program Files (x86)\Microsoft Visual Studio\2022\BuildTools\MSBuild\Current\Bin\MSBuild.exe',
    'C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\MSBuild\Current\Bin\MSBuild.exe'
)

$innoCandidates = @(
    "$env:LOCALAPPDATA\Programs\Inno Setup 6\ISCC.exe",
    'C:\Program Files (x86)\Inno Setup 6\ISCC.exe',
    'C:\Program Files\Inno Setup 6\ISCC.exe'
)

function Get-FirstExistingPath {
    param([string[]]$Candidates)
    foreach ($candidate in $Candidates) {
        if (Test-Path -LiteralPath $candidate) {
            return $candidate
        }
    }
    return $null
}

function Assert-FileHash {
    param(
        [Parameter(Mandatory)][string]$Path,
        [Parameter(Mandatory)][string]$ExpectedSha256
    )

    if (-not (Test-Path -LiteralPath $Path -PathType Leaf)) {
        throw "Required installer is missing: $Path"
    }

    $actual = (Get-FileHash -LiteralPath $Path -Algorithm SHA256).Hash
    if ($actual -ne $ExpectedSha256) {
        throw "SHA-256 mismatch for $Path. Expected $ExpectedSha256; found $actual."
    }
}

$innoCompiler = Get-FirstExistingPath -Candidates $innoCandidates
if (-not $innoCompiler) {
    throw 'Inno Setup 6 is required. Install it with: winget install --id JRSoftware.InnoSetup -e --source winget'
}

if (-not $SkipAppBuild) {
    $msbuild = Get-FirstExistingPath -Candidates $msbuildCandidates
    if (-not $msbuild) {
        throw 'Visual Studio MSBuild for .NET Framework was not found.'
    }

    & $msbuild $solutionPath /t:Rebuild /p:Configuration=Release /p:Platform=x86 /m /nologo /v:minimal
    if ($LASTEXITCODE -ne 0) {
        throw "RestaurantPOS14 Release build failed with exit code $LASTEXITCODE."
    }
}

if (-not (Test-Path -LiteralPath $releaseExe -PathType Leaf)) {
    throw "Release executable is missing: $releaseExe"
}

Assert-FileHash -Path (Join-Path $prerequisiteDirectory 'CRRuntime_32bit_13_0_24.msi') `
    -ExpectedSha256 '116283C08B3D6693E7D91B8D1165E373F67DFFCB2945189642F2195428BC2ECD'
Assert-FileHash -Path (Join-Path $prerequisiteDirectory 'VC_redist.x86.exe') `
    -ExpectedSha256 '0C09F2611660441084CE0DF425C51C11E147E6447963C3690F97E0B25C55ED64'
Assert-FileHash -Path (Join-Path $prerequisiteDirectory 'NDP48-x86-x64-AllOS-ENU.exe') `
    -ExpectedSha256 '0A3A390C47E639D0F7FC65B21195FEE6B7F65B066F80F70C60FAB191D14B7E40'

& $innoCompiler $setupScript
if ($LASTEXITCODE -ne 0) {
    throw "Installer compilation failed with exit code $LASTEXITCODE."
}

$version = (Get-Item -LiteralPath $releaseExe).VersionInfo.FileVersion
$installerPath = Join-Path $repoRoot "output\installer\Hitech_RestaurantPOS14_Setup_$version.exe"
if (-not (Test-Path -LiteralPath $installerPath -PathType Leaf)) {
    throw "Installer compiler completed but the expected output was not found: $installerPath"
}

$hash = Get-FileHash -LiteralPath $installerPath -Algorithm SHA256
$hashPath = "$installerPath.sha256"
"$($hash.Hash)  $([IO.Path]::GetFileName($installerPath))" | Set-Content -LiteralPath $hashPath -Encoding ascii

Get-Item -LiteralPath $installerPath | Select-Object FullName, Length,
    @{Name = 'Version'; Expression = { $_.VersionInfo.FileVersion }},
    @{Name = 'SHA256'; Expression = { $hash.Hash }}
