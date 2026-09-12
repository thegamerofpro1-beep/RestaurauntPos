Option Explicit On
Option Strict On

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Reflection

Module DineInTableNameSmoke
    Private applicationDirectory As String
    Private createCommand As MethodInfo

    Public Sub Main(args As String())
        If args.Length <> 1 Then Throw New ArgumentException("Expected the application assembly path.")
        Dim appPath = Path.GetFullPath(args(0))
        applicationDirectory = Path.GetDirectoryName(appPath)
        AddHandler AppDomain.CurrentDomain.AssemblyResolve, AddressOf ResolveDependency
        Dim app = Assembly.LoadFrom(appPath)
        createCommand = app.GetType("RestaurantPOS14.Billing.DineInBillQueries", True).
            GetMethod("CreateUnpaidBillItemsCommand", BindingFlags.Public Or BindingFlags.Static)

        Using unopened As New SqlConnection()
            ExpectFailure(Sub() BuildCommand(unopened, 0))
            ExpectFailure(Sub() BuildCommand(unopened, -1))
            ExpectFailure(Sub() BuildCommand(Nothing, 100))
            Using command = BuildCommand(unopened, 100)
                Assert(command.Parameters.Count = 1, "Expected only the bill-ID parameter.")
                Assert(command.Parameters("@BillID").SqlDbType = SqlDbType.Int, "Bill ID must be typed.")
                Assert(CInt(command.Parameters("@BillID").Value) = 100, "Wrong bill-ID parameter.")
            End Using
        End Using

        Dim host = app.GetType("RestaurantPOS14.Configuration.SettingsHost", True)
        Dim settings = host.GetProperty("Current").GetValue(Nothing, Nothing)
        Dim database = settings.GetType().GetProperty("Database").GetValue(settings, Nothing)
        Dim connectionString = CStr(database.GetType().GetProperty("ConnectionString").GetValue(database, Nothing))
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            CreateFixtures(connection)
            Dim names = {"10", "0010", "TABLE 10", "A-02", "Chef's Table", "Patio, East", "桌 10", "X'); SELECT 1;--"}
            For i As Integer = 0 To names.Length - 1
                Dim billId = 100 + i
                AddBilledTable(connection, billId, names(i))
                AddBilledTable(connection, billId, names(i)) ' Two billed items must not double the sums.
                For statusIndex As Integer = 0 To 3
                    Dim ticketId = i * 10 + statusIndex + 1
                    AddOrder(connection, ticketId, names(i), {"Open", "Prepared", "Served", "Closed"}(statusIndex))
                    AddItem(connection, ticketId, statusIndex + 1, "Active")
                    AddItem(connection, ticketId, 999, "Canceled")
                Next
                Dim result = ReadFixtureItems(connection, billId)
                Assert(result.Rows.Count = 1, "Unexpected row count for " & names(i))
                Assert(result.Columns.Count = 18, "Grid column order/shape changed.")
                VerifyRow(result.Rows(0), names(i))
                Console.WriteLine("PASS|Table=" & names(i) & "|Quantity=6|Total=68.40")
            Next

            AddBilledTable(connection, 900, names(2))
            AddBilledTable(connection, 900, names(4))
            Dim merged = ReadFixtureItems(connection, 900)
            Assert(merged.Rows.Count = 2, "Merged tables were not preserved.")
            For Each row As DataRow In merged.Rows
                Dim name = CStr(row(0))
                Assert(name = names(2) OrElse name = names(4), "Unrelated table leaked into merged bill.")
                VerifyRow(row, name)
            Next
            Assert(ReadFixtureItems(connection, 9999).Rows.Count = 0, "Missing bill returned unrelated orders.")
            Console.WriteLine("PASS|MergedTables|DuplicateMembership|StatusFilters|CanceledItems|BillIsolation")

            ' Compile/execute the production query against the actual legacy schema
            ' using an ID that cannot match a validated bill. This performs no writes.
            Using command = BuildCommand(connection, Integer.MaxValue), reader = command.ExecuteReader()
                Assert(reader.FieldCount = 18, "Production schema has an incompatible result shape.")
            End Using
        End Using
        Console.WriteLine("DineInTableNameSmokeSucceeded=True|PersistentDataChanged=False")
    End Sub

    Private Sub CreateFixtures(connection As SqlConnection)
        ' Only connection-local temporary tables are created. They disappear when
        ' this connection closes; no restaurant orders/bills/settings are changed.
        Dim sql =
            "CREATE TABLE #RestaurantPOS_OrderedProductBillKOT (BillID int, TableNo nchar(30));" &
            "CREATE TABLE #RestaurantPOS_OrderInfoKOT (ID int, TableNo nchar(30), GroupName nchar(200), KOT_Status nchar(30));" &
            "CREATE TABLE #RestaurantPOS_OrderedProductKOT (TicketID int, Dish nvarchar(max)," &
            "Rate decimal(18,2), Quantity decimal(18,2), Amount decimal(18,2)," &
            "DiscountPer decimal(18,2), DiscountAmount decimal(18,3), STPer decimal(18,2), STAmount decimal(18,2)," &
            "VATPer decimal(18,2), VATAmount decimal(18,3), SCPer decimal(18,2), SCAmount decimal(18,2)," &
            "TotalAmount decimal(18,2), Category nchar(200), DishNameArabic nvarchar(250), ItemStatus nchar(20));"
        Using command As New SqlCommand(sql, connection)
            command.ExecuteNonQuery()
        End Using
    End Sub

    Private Sub AddBilledTable(connection As SqlConnection, billId As Integer, tableName As String)
        Using command As New SqlCommand("INSERT INTO #RestaurantPOS_OrderedProductBillKOT VALUES (@id,@name)", connection)
            command.Parameters.Add("@id", SqlDbType.Int).Value = billId
            command.Parameters.Add("@name", SqlDbType.NVarChar, 30).Value = tableName
            command.ExecuteNonQuery()
        End Using
    End Sub

    Private Sub AddOrder(connection As SqlConnection, ticketId As Integer, tableName As String, status As String)
        Using command As New SqlCommand("INSERT INTO #RestaurantPOS_OrderInfoKOT VALUES (@id,@name,N'Main',@status)", connection)
            command.Parameters.Add("@id", SqlDbType.Int).Value = ticketId
            command.Parameters.Add("@name", SqlDbType.NVarChar, 30).Value = tableName
            command.Parameters.Add("@status", SqlDbType.NVarChar, 30).Value = status
            command.ExecuteNonQuery()
        End Using
    End Sub

    Private Sub AddItem(connection As SqlConnection, ticketId As Integer, quantity As Integer, status As String)
        Using command As New SqlCommand(
            "INSERT INTO #RestaurantPOS_OrderedProductKOT VALUES (@id,N'Test dish',10,@q,10*@q,0,0,6,0.6*@q,8,0.8*@q,0,0,11.4*@q,N'Food',N'Item',@status)", connection)
            command.Parameters.Add("@id", SqlDbType.Int).Value = ticketId
            command.Parameters.Add("@q", SqlDbType.Int).Value = quantity
            command.Parameters.Add("@status", SqlDbType.NVarChar, 20).Value = status
            command.ExecuteNonQuery()
        End Using
    End Sub

    Private Function ReadFixtureItems(connection As SqlConnection, billId As Integer) As DataTable
        Using command = BuildCommand(connection, billId)
            For Each table In {"RestaurantPOS_OrderedProductBillKOT", "RestaurantPOS_OrderedProductKOT", "RestaurantPOS_OrderInfoKOT"}
                command.CommandText = command.CommandText.Replace(table, "#" & table)
            Next
            Dim result As New DataTable()
            Using adapter As New SqlDataAdapter(command)
                adapter.Fill(result)
            End Using
            Return result
        End Using
    End Function

    Private Sub VerifyRow(row As DataRow, tableName As String)
        Assert(CStr(row(0)) = tableName, "Table name changed.")
        Assert(CStr(row(1)) = "Test dish" AndAlso CDec(row(2)) = 10D, "Item/rate columns changed.")
        Assert(CDec(row(3)) = 6D AndAlso CDec(row(4)) = 60D, "Quantity/amount aggregation changed.")
        Assert(CDec(row(5)) = 0D AndAlso CDec(row(6)) = 0D, "Discount columns changed.")
        Assert(Decimal.Parse(CStr(row(7)), Globalization.CultureInfo.InvariantCulture) = 6D AndAlso CDec(row(8)) = 3.6D, "SST columns changed.")
        Assert(Decimal.Parse(CStr(row(9)), Globalization.CultureInfo.InvariantCulture) = 8D AndAlso CDec(row(10)) = 4.8D, "Service charge columns changed.")
        Assert(CDec(row(11)) = 0D AndAlso CDec(row(12)) = 0D AndAlso CDec(row(13)) = 68.4D, "Total columns changed.")
        Assert(CStr(row(14)) = "Main" AndAlso CDec(row(15)) = 0D AndAlso CStr(row(16)) = "Food" AndAlso CStr(row(17)) = "Item", "Trailing grid columns changed.")
    End Sub

    Private Function BuildCommand(connection As SqlConnection, billId As Integer) As SqlCommand
        Return DirectCast(createCommand.Invoke(Nothing, New Object() {connection, billId}), SqlCommand)
    End Function

    Private Sub ExpectFailure(action As Action)
        Try
            action()
        Catch ex As TargetInvocationException When TypeOf ex.InnerException Is ArgumentException
            Return
        End Try
        Throw New InvalidOperationException("Invalid bill input was accepted.")
    End Sub

    Private Sub Assert(condition As Boolean, message As String)
        If Not condition Then Throw New InvalidOperationException(message)
    End Sub

    Private Function ResolveDependency(sender As Object, args As ResolveEventArgs) As Assembly
        Dim path = IO.Path.Combine(applicationDirectory, New AssemblyName(args.Name).Name & ".dll")
        If File.Exists(path) Then Return Assembly.LoadFrom(path)
        Return Nothing
    End Function
End Module
