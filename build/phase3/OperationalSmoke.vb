Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Linq
Imports System.Reflection
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Windows.Forms
Imports RestaurantPOS14.Extensions.Events
Imports RestaurantPOS14.Extensions.Payments
Imports RestaurantPOS14.Extensions.Printing

Friend NotInheritable Class DryRunPaymentProvider
    Implements IPaymentProvider

    Public ReadOnly Property Name As String Implements IPaymentProvider.Name
        Get
            Return "OperationalSmoke/DryRun"
        End Get
    End Property

    Public Function SendSale(request As PaymentRequest) As PaymentResponse Implements IPaymentProvider.SendSale
        Return New PaymentResponse With {
            .ProviderName = Name,
            .RawResponse = "DRY-RUN:" & request.Reference,
            .TransportCompleted = True
        }
    End Function
End Class

Friend NotInheritable Class CaptureEventSink
    Implements IIntegrationEventSink

    Public Property Calls As Integer

    Public ReadOnly Property Name As String Implements IIntegrationEventSink.Name
        Get
            Return "OperationalSmoke/Capture"
        End Get
    End Property

    Public Sub Handle(value As PosIntegrationEvent) Implements IIntegrationEventSink.Handle
        Calls += 1
    End Sub
End Class

Module OperationalSmoke
    Public Sub Main()
        Dim executableDirectory = AppDomain.CurrentDomain.BaseDirectory
        Environment.CurrentDirectory = executableDirectory

        Try
            Dim applicationAssembly = Assembly.LoadFrom(Path.Combine(executableDirectory, "RestaurantPOS14.exe"))
            Dim settingsHost = applicationAssembly.GetType("RestaurantPOS14.Configuration.SettingsHost", throwOnError:=True)
            Dim publicStatic = BindingFlags.Public Or BindingFlags.Static
            settingsHost.GetMethod("Initialize", publicStatic).Invoke(Nothing, New Object() {})

            Dim settings = settingsHost.GetProperty("Current", publicStatic).GetValue(Nothing, Nothing)
            Dim database = settings.GetType().GetProperty("Database").GetValue(settings, Nothing)
            Dim connectionString = CStr(database.GetType().GetProperty("ConnectionString").GetValue(database, Nothing))
            Dim builder As New SqlConnectionStringBuilder(connectionString)
            builder.ConnectTimeout = Math.Min(Math.Max(builder.ConnectTimeout, 1), 8)

            Using connection As New SqlConnection(builder.ConnectionString)
                connection.Open()
                Console.WriteLine("SqlConnectionSucceeded=True")
                Console.WriteLine("SqlDataSource=" & connection.DataSource)
                Console.WriteLine("SqlDatabase=" & connection.Database)
                Console.WriteLine("SqlServerVersion=" & connection.ServerVersion)

                Using command As New SqlCommand("SELECT COUNT(*) FROM sys.tables WHERE is_ms_shipped=0", connection)
                    command.CommandTimeout = 8
                    Console.WriteLine("SqlUserTableCount=" & Convert.ToInt32(command.ExecuteScalar()))
                End Using

                Dim requiredTables = {"Hotel", "OtherSetting", "PosPrinterSetting", "RestaurantPOS_BillingInfoKOT", "RestaurantPOS_OrderedProductKOT"}
                For Each tableName In requiredTables
                    Using command As New SqlCommand("SELECT CASE WHEN OBJECT_ID(@name, 'U') IS NULL THEN 0 ELSE 1 END", connection)
                        command.CommandTimeout = 8
                        command.Parameters.Add("@name", SqlDbType.NVarChar, 260).Value = "dbo." & tableName
                        Console.WriteLine("SqlTable." & tableName & "=" & (Convert.ToInt32(command.ExecuteScalar()) = 1).ToString())
                    End Using
                Next
            End Using

            Dim previousPaymentProvider = PaymentProviderHost.OverrideProvider
            Try
                PaymentProviderHost.OverrideProvider = New DryRunPaymentProvider()
                Dim payment = PaymentProviderHost.SendSale(1.23D, "verification-only")
                Console.WriteLine("PaymentDryRunSucceeded=" & (payment.TransportCompleted AndAlso payment.ProviderName = "OperationalSmoke/DryRun").ToString())
            Finally
                PaymentProviderHost.OverrideProvider = previousPaymentProvider
            End Try

            Dim nullPrinter As New NullPrintService()
            Dim printResult = nullPrinter.Print(New PrintJob With {.DocumentName = "Operational smoke", .Copies = 1})
            Console.WriteLine("PrintDryRunSucceeded=" & (printResult.Accepted AndAlso nullPrinter.Jobs.Count = 1).ToString())

            Dim eventHub As New IntegrationEventHub()
            Dim captureSink As New CaptureEventSink()
            eventHub.Register(captureSink)
            Dim dispatch = eventHub.Publish(New PosIntegrationEvent With {.EventName = IntegrationEventNames.OrderCreated, .Reference = "DRY-RUN:1"})
            Console.WriteLine("IntegrationDryRunSucceeded=" & (dispatch.Errors.Count = 0 AndAlso dispatch.SubscribersInvoked = 1 AndAlso captureSink.Calls = 1).ToString())

            Dim reportResource = applicationAssembly.GetManifestResourceNames().First(Function(name) name.EndsWith("rptCreditCustomerBalance.rpt", StringComparison.OrdinalIgnoreCase))
            Dim temporaryReport = Path.Combine(Path.GetTempPath(), "RestaurantPOS14-" & Guid.NewGuid().ToString("N") & ".rpt")
            Try
                Using input = applicationAssembly.GetManifestResourceStream(reportResource), output = File.Create(temporaryReport)
                    input.CopyTo(output)
                End Using

                Using report As New ReportDocument()
                    report.Load(temporaryReport)
                    Console.WriteLine("CrystalReportLoadSucceeded=True")
                    Console.WriteLine("CrystalReportResource=" & reportResource)
                    Console.WriteLine("CrystalReportTables=" & report.Database.Tables.Count)
                    Console.WriteLine("CrystalReportParameters=" & report.ParameterFields.Count)
                    Console.WriteLine("CrystalReportSections=" & report.ReportDefinition.Sections.Count)

                    Using viewer As New CrystalReportViewer()
                        viewer.ReportSource = report
                        Dim viewerHandle = viewer.Handle
                        Console.WriteLine("CrystalViewerHandleCreated=" & (viewerHandle <> IntPtr.Zero).ToString())
                    End Using
                End Using
            Finally
                If File.Exists(temporaryReport) Then File.Delete(temporaryReport)
            End Try
        Catch ex As Exception
            Console.WriteLine("OperationalSmokeSucceeded=False")
            Console.WriteLine("FailureType=" & ex.GetBaseException().GetType().FullName)
            Console.WriteLine("FailureMessage=" & ex.GetBaseException().Message)
            Environment.ExitCode = 1
            Return
        End Try

        Console.WriteLine("OperationalSmokeSucceeded=True")
    End Sub
End Module
