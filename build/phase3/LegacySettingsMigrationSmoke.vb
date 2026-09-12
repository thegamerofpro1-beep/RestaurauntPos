Imports System
Imports System.IO
Imports System.Reflection

Module LegacySettingsMigrationSmoke
    Private _applicationDirectory As String

    Sub Main(arguments As String())
        If arguments.Length <> 2 Then Throw New ArgumentException("Expected application assembly and legacy directory paths.")

        Dim applicationAssembly = Path.GetFullPath(arguments(0))
        _applicationDirectory = Path.GetDirectoryName(applicationAssembly)
        AddHandler AppDomain.CurrentDomain.AssemblyResolve, AddressOf ResolveApplicationAssembly

        Dim loadedAssembly = Assembly.LoadFrom(applicationAssembly)
        Dim migratorType = loadedAssembly.GetType("RestaurantPOS14.Configuration.LegacySettingsMigrator", throwOnError:=True)
        Dim migrator = Activator.CreateInstance(migratorType, New Object() {
            Path.GetFullPath(arguments(1)),
            Path.Combine(Path.GetFullPath(arguments(1)), "terminal-settings.json"),
            Nothing
        })
        Dim value = CStr(migratorType.GetMethod("ReadLegacyConnectionString").Invoke(migrator, Nothing))
        If String.IsNullOrWhiteSpace(value) OrElse
           value.IndexOf("Initial Catalog=RPOS_DB", StringComparison.OrdinalIgnoreCase) < 0 Then
            Throw New InvalidOperationException("The legacy database connection string was not recovered.")
        End If

        Console.WriteLine("PASS: legacy database connection configuration is recoverable.")
    End Sub

    Private Function ResolveApplicationAssembly(sender As Object, arguments As ResolveEventArgs) As Assembly
        Dim dependencyName = New AssemblyName(arguments.Name).Name & ".dll"
        Dim dependencyPath = Path.Combine(_applicationDirectory, dependencyName)
        If File.Exists(dependencyPath) Then Return Assembly.LoadFrom(dependencyPath)
        Return Nothing
    End Function
End Module
