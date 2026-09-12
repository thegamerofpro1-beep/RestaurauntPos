Option Explicit On
Option Strict On

Imports System
Imports System.IO
Imports System.Reflection

Module CashDrawerGuardSmoke
    Private _applicationDirectory As String

    Public Sub Main(args As String())
        If args.Length <> 1 Then
            Console.Error.WriteLine("Usage: CashDrawerGuardSmoke <RestaurantPOS14.exe>")
            Environment.ExitCode = 2
            Return
        End If

        Try
            Dim applicationPath = Path.GetFullPath(args(0))
            _applicationDirectory = Path.GetDirectoryName(applicationPath)
            AddHandler AppDomain.CurrentDomain.AssemblyResolve, AddressOf ResolveApplicationAssembly

            Dim applicationAssembly = Assembly.LoadFrom(applicationPath)
            InitializeSettings(applicationAssembly)

            Dim drawerType = applicationAssembly.GetType("RestaurantPOS14.ModCashDrawer", True)
            Dim rawPrinterType = drawerType.GetNestedType(
                "RawPrinter", BindingFlags.Public Or BindingFlags.NonPublic)

            VerifyRawGuard(rawPrinterType, String.Empty, "empty printer")
            VerifyRawGuard(rawPrinterType,
                           "RestaurantPOS14 deliberately missing printer",
                           "missing printer")
            VerifyMissingTill(drawerType)
            VerifyConfiguredResolution(drawerType)

            Console.WriteLine("CashDrawerGuardSmokeSucceeded=True")
        Catch ex As Exception
            Console.Error.WriteLine(ex.ToString())
            Environment.ExitCode = 1
        End Try
    End Sub

    Private Sub InitializeSettings(applicationAssembly As Assembly)
        Dim settingsHost = applicationAssembly.GetType(
            "RestaurantPOS14.Configuration.SettingsHost", True)
        settingsHost.GetMethod("Initialize", BindingFlags.Public Or BindingFlags.Static).
            Invoke(Nothing, Nothing)
    End Sub

    Private Sub VerifyRawGuard(rawPrinterType As Type,
                               printerName As String,
                               scenario As String)
        Dim method = rawPrinterType.GetMethod(
            "TryPrintRaw", BindingFlags.Public Or BindingFlags.Static)
        If method Is Nothing Then Throw New MissingMethodException(rawPrinterType.FullName, "TryPrintRaw")

        Dim arguments As Object() = {printerName, ChrW(27) & "p0@@", String.Empty}
        Dim opened = CBool(method.Invoke(Nothing, arguments))
        Dim errorMessage = Convert.ToString(arguments(2))
        If opened Then Throw New InvalidOperationException("Drawer unexpectedly opened for " & scenario & ".")
        If String.IsNullOrWhiteSpace(errorMessage) Then
            Throw New InvalidOperationException("No diagnostic was returned for " & scenario & ".")
        End If
        If errorMessage.IndexOf("Object reference", StringComparison.OrdinalIgnoreCase) >= 0 Then
            Throw New InvalidOperationException("Null-reference text leaked for " & scenario & ".")
        End If

        Console.WriteLine("GUARDED|" & scenario & "|" & errorMessage)
    End Sub

    Private Sub VerifyMissingTill(drawerType As Type)
        Dim method = drawerType.GetMethod(
            "TryOpenConfiguredDrawer", BindingFlags.Public Or BindingFlags.Static)
        If method Is Nothing Then Throw New MissingMethodException(drawerType.FullName, "TryOpenConfiguredDrawer")

        Dim missingTill = "CASH-DRAWER-SMOKE-" & Guid.NewGuid().ToString("N")
        Dim arguments As Object() = {missingTill, String.Empty}
        Dim opened = CBool(method.Invoke(Nothing, arguments))
        Dim errorMessage = Convert.ToString(arguments(1))
        If opened Then Throw New InvalidOperationException("Drawer unexpectedly opened for an unconfigured till.")
        If errorMessage.IndexOf("Object reference", StringComparison.OrdinalIgnoreCase) >= 0 Then
            Throw New InvalidOperationException("Null-reference text leaked for an unconfigured till.")
        End If

        Console.WriteLine("GUARDED|unconfigured till|No spooler call")
    End Sub

    Private Sub VerifyConfiguredResolution(drawerType As Type)
        Dim method = drawerType.GetMethod(
            "TryResolveConfiguredPrinter", BindingFlags.Public Or BindingFlags.Static)
        If method Is Nothing Then Throw New MissingMethodException(drawerType.FullName, "TryResolveConfiguredPrinter")

        Dim arguments As Object() = {System.Net.Dns.GetHostName(), String.Empty, String.Empty}
        Dim configured = CBool(method.Invoke(Nothing, arguments))
        Dim printerName = Convert.ToString(arguments(1))
        Dim errorMessage = Convert.ToString(arguments(2))
        If Not configured AndAlso Not String.IsNullOrWhiteSpace(errorMessage) Then
            Throw New InvalidOperationException(errorMessage)
        End If

        Console.WriteLine(
            "RESOLVED|CurrentTill|Configured=" & configured.ToString() &
            "|Printer=" & printerName)
    End Sub

    Private Function ResolveApplicationAssembly(sender As Object,
                                                arguments As ResolveEventArgs) As Assembly
        Dim dependencyName = New AssemblyName(arguments.Name).Name & ".dll"
        Dim dependencyPath = Path.Combine(_applicationDirectory, dependencyName)
        If File.Exists(dependencyPath) Then Return Assembly.LoadFrom(dependencyPath)
        Return Nothing
    End Function
End Module
