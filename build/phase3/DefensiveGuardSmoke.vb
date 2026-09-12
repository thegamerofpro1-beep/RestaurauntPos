Imports System
Imports System.IO
Imports System.Reflection
Imports System.Text

Module DefensiveGuardSmoke
    Private _applicationDirectory As String

    Sub Main(arguments As String())
        If arguments.Length <> 1 Then Throw New ArgumentException("Expected the application assembly path.")

        Dim applicationAssemblyPath = Path.GetFullPath(arguments(0))
        _applicationDirectory = Path.GetDirectoryName(applicationAssemblyPath)
        AddHandler AppDomain.CurrentDomain.AssemblyResolve, AddressOf ResolveApplicationAssembly

        Dim applicationAssembly = System.Reflection.Assembly.LoadFrom(applicationAssemblyPath)
        TestPinSecurity(applicationAssembly)
        TestSqlInput(applicationAssembly)
        TestExternalResources(applicationAssembly)
        TestSafeDivision(applicationAssembly)
        Console.WriteLine("DefensiveGuardSmokeSucceeded=True")
    End Sub

    Private Sub TestPinSecurity(assembly As Assembly)
        Dim type = assembly.GetType("RestaurantPOS14.Security.PinSecurity", True)
        Dim pin = "0427"
        Dim stored = CStr(Invoke(type, "HashPin", pin))
        Assert(stored.StartsWith("P1$", StringComparison.Ordinal), "New PIN is not strongly hashed.")
        Assert(stored.Length <= 50, "New PIN hash does not fit the legacy column.")
        Assert(CBool(Invoke(type, "VerifyPin", pin, stored)), "Strong PIN verification failed.")
        Assert(Not CBool(Invoke(type, "VerifyPin", "9999", stored)), "Wrong PIN was accepted.")

        Dim legacy = Convert.ToBase64String(Encoding.UTF8.GetBytes(pin))
        Assert(CBool(Invoke(type, "VerifyPin", pin, legacy)), "First-version PIN compatibility failed.")
        Dim temporaryPin = CStr(Invoke(type, "CreateTemporaryPin"))
        Assert(temporaryPin.Length = 4 AndAlso Integer.TryParse(temporaryPin, Nothing), "Temporary PIN is invalid.")
    End Sub

    Private Sub TestSqlInput(assembly As Assembly)
        Dim type = assembly.GetType("RestaurantPOS14.Security.SqlInput", True)
        Assert(CStr(Invoke(type, "EscapeLiteral", "O'Brien")) = "O''Brien", "SQL literal escaping failed.")
        Assert(CStr(Invoke(type, "RequireInteger", "42", "ID")) = "42", "Integer normalization failed.")
        Assert(CStr(Invoke(type, "RequireIntegerList", "1, 2,3", "IDs")) = "1,2,3", "Integer-list normalization failed.")
        ExpectFailure(Sub() Invoke(type, "RequireInteger", "1 OR 1=1", "ID"), "SQL-like integer input was accepted.")
    End Sub

    Private Sub TestExternalResources(assembly As Assembly)
        Dim type = assembly.GetType("RestaurantPOS14.Security.ExternalResourceGuard", True)
        Dim httpsUri = DirectCast(Invoke(type, "RequireHttpUri", "https://example.com/path", False), Uri)
        Assert(httpsUri.Scheme = Uri.UriSchemeHttps, "HTTPS URL was rejected.")
        Dim loopbackUri = DirectCast(Invoke(type, "RequireHttpUri", "http://127.0.0.1:9500/path", True), Uri)
        Assert(loopbackUri.IsLoopback, "Loopback gateway URL was rejected.")
        ExpectFailure(Sub() Invoke(type, "RequireHttpUri", "http://example.com/path", False), "External HTTP URL was accepted.")
    End Sub

    Private Sub TestSafeDivision(assembly As Assembly)
        Dim type = assembly.GetType("RestaurantPOS14.ModFunc", True)
        Assert(Convert.ToDouble(Invoke(type, "SafeDivide", 9.0, 0.0)) = 0.0, "Zero denominator was not guarded.")
        Assert(Convert.ToDouble(Invoke(type, "SafeDivide", 9.0, 3.0)) = 3.0, "Normal division changed.")
    End Sub

    Private Function Invoke(type As Type, methodName As String, ParamArray arguments As Object()) As Object
        Return type.GetMethod(methodName, BindingFlags.Public Or BindingFlags.Static).Invoke(Nothing, arguments)
    End Function

    Private Sub ExpectFailure(action As Action, message As String)
        Try
            action()
        Catch ex As TargetInvocationException When ex.InnerException IsNot Nothing
            Return
        End Try
        Throw New InvalidOperationException(message)
    End Sub

    Private Sub Assert(condition As Boolean, message As String)
        If Not condition Then Throw New InvalidOperationException(message)
    End Sub

    Private Function ResolveApplicationAssembly(sender As Object, arguments As ResolveEventArgs) As Assembly
        Dim dependencyPath = Path.Combine(_applicationDirectory, New AssemblyName(arguments.Name).Name & ".dll")
        If File.Exists(dependencyPath) Then Return Assembly.LoadFrom(dependencyPath)
        Return Nothing
    End Function
End Module
