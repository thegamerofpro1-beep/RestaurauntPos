Imports System
Imports System.CodeDom.Compiler
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Data
Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports RestaurantPOS14.My

Namespace RestaurantPOS14.RPOS_DBDataSet1TableAdapters

    ''' <summary>
    ''' Represents the connection and commands used to retrieve and save data.
    ''' </summary>
    <System.ComponentModel.DesignerCategoryAttribute("code")>
    <System.ComponentModel.ToolboxItemAttribute(True)>
    <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
    <System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")>
    <System.ComponentModel.DataObjectAttribute(True)>
    Public Class EmployeeRegistrationTableAdapter
        Inherits System.ComponentModel.Component

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("_adapter")>
        Private __adapter As System.Data.SqlClient.SqlDataAdapter

        Private _connection As System.Data.SqlClient.SqlConnection

        Private _transaction As System.Data.SqlClient.SqlTransaction

        Private _commandCollection As System.Data.SqlClient.SqlCommand()

        Private _clearBeforeFill As Boolean

        Private Property _adapter As System.Data.SqlClient.SqlDataAdapter
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me.__adapter
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Data.SqlClient.SqlDataAdapter)
                Me.__adapter = value
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Protected Friend ReadOnly Property Adapter As System.Data.SqlClient.SqlDataAdapter
            Get
                If Me._adapter Is Nothing Then
                    Me.InitAdapter()
                End If

                Return Me._adapter
            End Get
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Friend Property Connection As System.Data.SqlClient.SqlConnection
            Get
                If Me._connection Is Nothing Then
                    Me.InitConnection()
                End If

                Return Me._connection
            End Get

            Set(value As System.Data.SqlClient.SqlConnection)
                Me._connection = value
                If Me.Adapter.InsertCommand IsNot Nothing Then
                    Me.Adapter.InsertCommand.Connection = value
                End If

                If Me.Adapter.DeleteCommand IsNot Nothing Then
                    Me.Adapter.DeleteCommand.Connection = value
                End If

                If Me.Adapter.UpdateCommand IsNot Nothing Then
                    Me.Adapter.UpdateCommand.Connection = value
                End If

                Dim i As Integer = 0
                While i < Me.CommandCollection.Length
                    If Me.CommandCollection(i) IsNot Nothing Then
                        Me.CommandCollection(CInt((i))).Connection = value
                    End If

                    i = i + 1
                End While
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Friend Property Transaction As System.Data.SqlClient.SqlTransaction
            Get
                Return Me._transaction
            End Get

            Set(value As System.Data.SqlClient.SqlTransaction)
                Me._transaction = value
                Dim i As Integer = 0
                While i < Me.CommandCollection.Length
                    Me.CommandCollection(CInt((i))).Transaction = Me._transaction
                    i = i + 1
                End While

                If Me.Adapter IsNot Nothing AndAlso Me.Adapter.DeleteCommand IsNot Nothing Then
                    Me.Adapter.DeleteCommand.Transaction = Me._transaction
                End If

                If Me.Adapter IsNot Nothing AndAlso Me.Adapter.InsertCommand IsNot Nothing Then
                    Me.Adapter.InsertCommand.Transaction = Me._transaction
                End If

                If Me.Adapter IsNot Nothing AndAlso Me.Adapter.UpdateCommand IsNot Nothing Then
                    Me.Adapter.UpdateCommand.Transaction = Me._transaction
                End If
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Protected ReadOnly Property CommandCollection As System.Data.SqlClient.SqlCommand()
            Get
                If Me._commandCollection Is Nothing Then
                    Me.InitCommandCollection()
                End If

                Return Me._commandCollection
            End Get
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Property ClearBeforeFill As Boolean
            Get
                Return Me._clearBeforeFill
            End Get

            Set(value As Boolean)
                Me._clearBeforeFill = value
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.RPOS_DBDataSet1TableAdapters.EmployeeRegistrationTableAdapter.__ENCList
                If RestaurantPOS14.RPOS_DBDataSet1TableAdapters.EmployeeRegistrationTableAdapter.__ENCList.Count = RestaurantPOS14.RPOS_DBDataSet1TableAdapters.EmployeeRegistrationTableAdapter.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.RPOS_DBDataSet1TableAdapters.EmployeeRegistrationTableAdapter.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.RPOS_DBDataSet1TableAdapters.EmployeeRegistrationTableAdapter.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.RPOS_DBDataSet1TableAdapters.EmployeeRegistrationTableAdapter.__ENCList(num) = RestaurantPOS14.RPOS_DBDataSet1TableAdapters.EmployeeRegistrationTableAdapter.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.RPOS_DBDataSet1TableAdapters.EmployeeRegistrationTableAdapter.__ENCList.RemoveRange(num, RestaurantPOS14.RPOS_DBDataSet1TableAdapters.EmployeeRegistrationTableAdapter.__ENCList.Count - num)
                    RestaurantPOS14.RPOS_DBDataSet1TableAdapters.EmployeeRegistrationTableAdapter.__ENCList.Capacity = RestaurantPOS14.RPOS_DBDataSet1TableAdapters.EmployeeRegistrationTableAdapter.__ENCList.Count
                End If

                Call RestaurantPOS14.RPOS_DBDataSet1TableAdapters.EmployeeRegistrationTableAdapter.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Sub New()
            Call RestaurantPOS14.RPOS_DBDataSet1TableAdapters.EmployeeRegistrationTableAdapter.__ENCAddToList(Me)
            Me.ClearBeforeFill = True
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Private Sub InitAdapter()
            Me._adapter = New System.Data.SqlClient.SqlDataAdapter()
            Dim dataTableMapping As System.Data.Common.DataTableMapping = New System.Data.Common.DataTableMapping()
            dataTableMapping.SourceTable = "Table"
            dataTableMapping.DataSetTable = "EmployeeRegistration"
            dataTableMapping.ColumnMappings.Add("EmpId", "EmpId")
            dataTableMapping.ColumnMappings.Add("EmployeeID", "EmployeeID")
            dataTableMapping.ColumnMappings.Add("EmployeeName", "EmployeeName")
            dataTableMapping.ColumnMappings.Add("Address", "Address")
            dataTableMapping.ColumnMappings.Add("City", "City")
            dataTableMapping.ColumnMappings.Add("ContactNo", "ContactNo")
            dataTableMapping.ColumnMappings.Add("Email", "Email")
            dataTableMapping.ColumnMappings.Add("DateOfJoining", "DateOfJoining")
            dataTableMapping.ColumnMappings.Add("Photo", "Photo")
            dataTableMapping.ColumnMappings.Add("Active", "Active")
            Me._adapter.TableMappings.Add(dataTableMapping)
            Me._adapter.DeleteCommand = New System.Data.SqlClient.SqlCommand()
            Me._adapter.DeleteCommand.Connection = Me.Connection
            Me._adapter.DeleteCommand.CommandText = "DELETE FROM [dbo].[EmployeeRegistration] WHERE (([EmpId] = @Original_EmpId) AND ([EmployeeID] = @Original_EmployeeID) AND ([EmployeeName] = @Original_EmployeeName) AND ([Address] = @Original_Address) AND ([City] = @Original_City) AND ([ContactNo] = @Original_ContactNo) AND ([Email] = @Original_Email) AND ([DateOfJoining] = @Original_DateOfJoining) AND ((@IsNull_Active = 1 AND [Active] IS NULL) OR ([Active] = @Original_Active)))"
            Me._adapter.DeleteCommand.CommandType = System.Data.CommandType.Text
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_EmpId", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "EmpId", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_EmployeeID", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "EmployeeID", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_EmployeeName", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "EmployeeName", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Address", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Address", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_City", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "City", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ContactNo", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "ContactNo", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Email", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Email", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DateOfJoining", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, 0, 0, "DateOfJoining", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Active", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Active", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Active", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Active", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand = New System.Data.SqlClient.SqlCommand()
            Me._adapter.InsertCommand.Connection = Me.Connection
            Me._adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[EmployeeRegistration] ([EmpId], [EmployeeID], [EmployeeName], [Address], [City], [ContactNo], [Email], [DateOfJoining], [Photo], [Active]) VALUES (@EmpId, @EmployeeID, @EmployeeName, @Address, @City, @ContactNo, @Email, @DateOfJoining, @Photo, @Active);" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "SELECT EmpId, EmployeeID, EmployeeName, Address, City, ContactNo, Email, DateOfJoining, Photo, Active FROM EmployeeRegistration WHERE (EmpId = @EmpId)"
            Me._adapter.InsertCommand.CommandType = System.Data.CommandType.Text
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@EmpId", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "EmpId", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@EmployeeID", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "EmployeeID", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@EmployeeName", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "EmployeeName", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Address", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Address", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@City", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "City", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ContactNo", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "ContactNo", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Email", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Email", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DateOfJoining", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, 0, 0, "DateOfJoining", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Photo", System.Data.SqlDbType.Image, 0, System.Data.ParameterDirection.Input, 0, 0, "Photo", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Active", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Active", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand = New System.Data.SqlClient.SqlCommand()
            Me._adapter.UpdateCommand.Connection = Me.Connection
            Me._adapter.UpdateCommand.CommandText = "UPDATE [dbo].[EmployeeRegistration] SET [EmpId] = @EmpId, [EmployeeID] = @EmployeeID, [EmployeeName] = @EmployeeName, [Address] = @Address, [City] = @City, [ContactNo] = @ContactNo, [Email] = @Email, [DateOfJoining] = @DateOfJoining, [Photo] = @Photo, [Active] = @Active WHERE (([EmpId] = @Original_EmpId) AND ([EmployeeID] = @Original_EmployeeID) AND ([EmployeeName] = @Original_EmployeeName) AND ([Address] = @Original_Address) AND ([City] = @Original_City) AND ([ContactNo] = @Original_ContactNo) AND ([Email] = @Original_Email) AND ([DateOfJoining] = @Original_DateOfJoining) AND ((@IsNull_Active = 1 AND [Active] IS NULL) OR ([Active] = @Original_Active)));" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "SELECT EmpId, EmployeeID, EmployeeName, Address, City, ContactNo, Email, DateOfJoining, Photo, Active FROM EmployeeRegistration WHERE (EmpId = @EmpId)"
            Me._adapter.UpdateCommand.CommandType = System.Data.CommandType.Text
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@EmpId", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "EmpId", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@EmployeeID", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "EmployeeID", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@EmployeeName", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "EmployeeName", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Address", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Address", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@City", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "City", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ContactNo", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "ContactNo", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Email", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Email", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DateOfJoining", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, 0, 0, "DateOfJoining", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Photo", System.Data.SqlDbType.Image, 0, System.Data.ParameterDirection.Input, 0, 0, "Photo", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Active", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Active", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_EmpId", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "EmpId", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_EmployeeID", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "EmployeeID", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_EmployeeName", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "EmployeeName", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Address", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Address", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_City", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "City", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ContactNo", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "ContactNo", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Email", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Email", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DateOfJoining", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, 0, 0, "DateOfJoining", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Active", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Active", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Active", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Active", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
        End Sub

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Sub InitConnection()
            Me._connection = New System.Data.SqlClient.SqlConnection()
            Me._connection.ConnectionString = RestaurantPOS14.My.MySettings.[Default].RPOS_DBConnectionString
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Private Sub InitCommandCollection()
            Me._commandCollection = New System.Data.SqlClient.SqlCommand(0) {}
            Me._commandCollection(0) = New System.Data.SqlClient.SqlCommand()
            Me._commandCollection(CInt((0))).Connection = Me.Connection
            Me._commandCollection(CInt((0))).CommandText = "SELECT EmpId, EmployeeID, EmployeeName, Address, City, ContactNo, Email, DateOfJoining, Photo, Active FROM dbo.EmployeeRegistration"
            Me._commandCollection(CInt((0))).CommandType = System.Data.CommandType.Text
        End Sub

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Fill, True)>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Overridable Function Fill(dataTable As RestaurantPOS14.RPOS_DBDataSet1.EmployeeRegistrationDataTable) As Integer
            Me.Adapter.SelectCommand = Me.CommandCollection(0)
            If Me.ClearBeforeFill Then
                dataTable.Clear()
            End If

            Return Me.Adapter.Fill(dataTable)
        End Function

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.[Select], True)>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Overridable Function GetData() As RestaurantPOS14.RPOS_DBDataSet1.EmployeeRegistrationDataTable
            Me.Adapter.SelectCommand = Me.CommandCollection(0)
            Dim employeeRegistrationDataTable As RestaurantPOS14.RPOS_DBDataSet1.EmployeeRegistrationDataTable = New RestaurantPOS14.RPOS_DBDataSet1.EmployeeRegistrationDataTable()
            Me.Adapter.Fill(employeeRegistrationDataTable)
            Return employeeRegistrationDataTable
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Overridable Function Update(dataTable As RestaurantPOS14.RPOS_DBDataSet1.EmployeeRegistrationDataTable) As Integer
            Return Me.Adapter.Update(dataTable)
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        Public Overridable Function Update(dataSet As RestaurantPOS14.RPOS_DBDataSet1) As Integer
            Return Me.Adapter.Update(dataSet, "EmployeeRegistration")
        End Function

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Overridable Function Update(dataRow As System.Data.DataRow) As Integer
            Return Me.Adapter.Update(New System.Data.DataRow(0) {dataRow})
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        Public Overridable Function Update(dataRows As System.Data.DataRow()) As Integer
            Return Me.Adapter.Update(dataRows)
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, True)>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Overridable Function Delete(Original_EmpId As Integer, Original_EmployeeID As String, Original_EmployeeName As String, Original_Address As String, Original_City As String, Original_ContactNo As String, Original_Email As String, Original_DateOfJoining As System.DateTime, Original_Active As String) As Integer
            Me.Adapter.DeleteCommand.Parameters(CInt((0))).Value = Original_EmpId
            If Equals(Original_EmployeeID, Nothing) Then
                Throw New System.ArgumentNullException("Original_EmployeeID")
            End If

            Me.Adapter.DeleteCommand.Parameters(CInt((1))).Value = Original_EmployeeID
            If Equals(Original_EmployeeName, Nothing) Then
                Throw New System.ArgumentNullException("Original_EmployeeName")
            End If

            Me.Adapter.DeleteCommand.Parameters(CInt((2))).Value = Original_EmployeeName
            If Equals(Original_Address, Nothing) Then
                Throw New System.ArgumentNullException("Original_Address")
            End If

            Me.Adapter.DeleteCommand.Parameters(CInt((3))).Value = Original_Address
            If Equals(Original_City, Nothing) Then
                Throw New System.ArgumentNullException("Original_City")
            End If

            Me.Adapter.DeleteCommand.Parameters(CInt((4))).Value = Original_City
            If Equals(Original_ContactNo, Nothing) Then
                Throw New System.ArgumentNullException("Original_ContactNo")
            End If

            Me.Adapter.DeleteCommand.Parameters(CInt((5))).Value = Original_ContactNo
            If Equals(Original_Email, Nothing) Then
                Throw New System.ArgumentNullException("Original_Email")
            End If

            Me.Adapter.DeleteCommand.Parameters(CInt((6))).Value = Original_Email
            Me.Adapter.DeleteCommand.Parameters(CInt((7))).Value = Original_DateOfJoining
            If Equals(Original_Active, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((8))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((9))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((8))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((9))).Value = Original_Active
            End If

            Dim state As System.Data.ConnectionState = Me.Adapter.DeleteCommand.Connection.State
            If(Me.Adapter.DeleteCommand.Connection.State And System.Data.ConnectionState.Open) <> System.Data.ConnectionState.Open Then
                Me.Adapter.DeleteCommand.Connection.Open()
            End If

            Try
                Return Me.Adapter.DeleteCommand.ExecuteNonQuery()
            Finally
                If state = System.Data.ConnectionState.Closed Then
                    Me.Adapter.DeleteCommand.Connection.Close()
                End If
            End Try
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, True)>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Overridable Function Insert(EmpId As Integer, EmployeeID As String, EmployeeName As String, Address As String, City As String, ContactNo As String, Email As String, DateOfJoining As System.DateTime, Photo As Byte(), Active As String) As Integer
            Me.Adapter.InsertCommand.Parameters(CInt((0))).Value = EmpId
            If Equals(EmployeeID, Nothing) Then
                Throw New System.ArgumentNullException("EmployeeID")
            End If

            Me.Adapter.InsertCommand.Parameters(CInt((1))).Value = EmployeeID
            If Equals(EmployeeName, Nothing) Then
                Throw New System.ArgumentNullException("EmployeeName")
            End If

            Me.Adapter.InsertCommand.Parameters(CInt((2))).Value = EmployeeName
            If Equals(Address, Nothing) Then
                Throw New System.ArgumentNullException("Address")
            End If

            Me.Adapter.InsertCommand.Parameters(CInt((3))).Value = Address
            If Equals(City, Nothing) Then
                Throw New System.ArgumentNullException("City")
            End If

            Me.Adapter.InsertCommand.Parameters(CInt((4))).Value = City
            If Equals(ContactNo, Nothing) Then
                Throw New System.ArgumentNullException("ContactNo")
            End If

            Me.Adapter.InsertCommand.Parameters(CInt((5))).Value = ContactNo
            If Equals(Email, Nothing) Then
                Throw New System.ArgumentNullException("Email")
            End If

            Me.Adapter.InsertCommand.Parameters(CInt((6))).Value = Email
            Me.Adapter.InsertCommand.Parameters(CInt((7))).Value = DateOfJoining
            If Photo Is Nothing Then
                Throw New System.ArgumentNullException("Photo")
            End If

            Me.Adapter.InsertCommand.Parameters(CInt((8))).Value = Photo
            If Equals(Active, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((9))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((9))).Value = Active
            End If

            Dim state As System.Data.ConnectionState = Me.Adapter.InsertCommand.Connection.State
            If(Me.Adapter.InsertCommand.Connection.State And System.Data.ConnectionState.Open) <> System.Data.ConnectionState.Open Then
                Me.Adapter.InsertCommand.Connection.Open()
            End If

            Try
                Return Me.Adapter.InsertCommand.ExecuteNonQuery()
            Finally
                If state = System.Data.ConnectionState.Closed Then
                    Me.Adapter.InsertCommand.Connection.Close()
                End If
            End Try
        End Function

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, True)>
        Public Overridable Function Update(EmpId As Integer, EmployeeID As String, EmployeeName As String, Address As String, City As String, ContactNo As String, Email As String, DateOfJoining As System.DateTime, Photo As Byte(), Active As String, Original_EmpId As Integer, Original_EmployeeID As String, Original_EmployeeName As String, Original_Address As String, Original_City As String, Original_ContactNo As String, Original_Email As String, Original_DateOfJoining As System.DateTime, Original_Active As String) As Integer
            Me.Adapter.UpdateCommand.Parameters(CInt((0))).Value = EmpId
            If Equals(EmployeeID, Nothing) Then
                Throw New System.ArgumentNullException("EmployeeID")
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((1))).Value = EmployeeID
            If Equals(EmployeeName, Nothing) Then
                Throw New System.ArgumentNullException("EmployeeName")
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((2))).Value = EmployeeName
            If Equals(Address, Nothing) Then
                Throw New System.ArgumentNullException("Address")
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((3))).Value = Address
            If Equals(City, Nothing) Then
                Throw New System.ArgumentNullException("City")
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((4))).Value = City
            If Equals(ContactNo, Nothing) Then
                Throw New System.ArgumentNullException("ContactNo")
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((5))).Value = ContactNo
            If Equals(Email, Nothing) Then
                Throw New System.ArgumentNullException("Email")
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((6))).Value = Email
            Me.Adapter.UpdateCommand.Parameters(CInt((7))).Value = DateOfJoining
            If Photo Is Nothing Then
                Throw New System.ArgumentNullException("Photo")
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((8))).Value = Photo
            If Equals(Active, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((9))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((9))).Value = Active
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((10))).Value = Original_EmpId
            If Equals(Original_EmployeeID, Nothing) Then
                Throw New System.ArgumentNullException("Original_EmployeeID")
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((11))).Value = Original_EmployeeID
            If Equals(Original_EmployeeName, Nothing) Then
                Throw New System.ArgumentNullException("Original_EmployeeName")
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((12))).Value = Original_EmployeeName
            If Equals(Original_Address, Nothing) Then
                Throw New System.ArgumentNullException("Original_Address")
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((13))).Value = Original_Address
            If Equals(Original_City, Nothing) Then
                Throw New System.ArgumentNullException("Original_City")
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((14))).Value = Original_City
            If Equals(Original_ContactNo, Nothing) Then
                Throw New System.ArgumentNullException("Original_ContactNo")
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((15))).Value = Original_ContactNo
            If Equals(Original_Email, Nothing) Then
                Throw New System.ArgumentNullException("Original_Email")
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((16))).Value = Original_Email
            Me.Adapter.UpdateCommand.Parameters(CInt((17))).Value = Original_DateOfJoining
            If Equals(Original_Active, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((18))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((19))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((18))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((19))).Value = Original_Active
            End If

            Dim state As System.Data.ConnectionState = Me.Adapter.UpdateCommand.Connection.State
            If(Me.Adapter.UpdateCommand.Connection.State And System.Data.ConnectionState.Open) <> System.Data.ConnectionState.Open Then
                Me.Adapter.UpdateCommand.Connection.Open()
            End If

            Try
                Return Me.Adapter.UpdateCommand.ExecuteNonQuery()
            Finally
                If state = System.Data.ConnectionState.Closed Then
                    Me.Adapter.UpdateCommand.Connection.Close()
                End If
            End Try
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, True)>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        Public Overridable Function Update(EmployeeID As String, EmployeeName As String, Address As String, City As String, ContactNo As String, Email As String, DateOfJoining As System.DateTime, Photo As Byte(), Active As String, Original_EmpId As Integer, Original_EmployeeID As String, Original_EmployeeName As String, Original_Address As String, Original_City As String, Original_ContactNo As String, Original_Email As String, Original_DateOfJoining As System.DateTime, Original_Active As String) As Integer
            Return Me.Update(Original_EmpId, EmployeeID, EmployeeName, Address, City, ContactNo, Email, DateOfJoining, Photo, Active, Original_EmpId, Original_EmployeeID, Original_EmployeeName, Original_Address, Original_City, Original_ContactNo, Original_Email, Original_DateOfJoining, Original_Active)
        End Function
    End Class
End Namespace
