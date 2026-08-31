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

Namespace RestaurantPOS14.RPOS_DBDataSetTableAdapters

    ''' <summary>
    ''' Represents the connection and commands used to retrieve and save data.
    ''' </summary>
    <System.ComponentModel.DesignerCategoryAttribute("code")>
    <System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")>
    <System.ComponentModel.ToolboxItemAttribute(True)>
    <System.ComponentModel.DataObjectAttribute(True)>
    <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
    Public Class WarehouseTableAdapter
        Inherits System.ComponentModel.Component

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("_adapter")>
        Private __adapter As System.Data.SqlClient.SqlDataAdapter

        Private _connection As System.Data.SqlClient.SqlConnection

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
        Private ReadOnly Property Adapter As System.Data.SqlClient.SqlDataAdapter
            Get
                If Me._adapter Is Nothing Then
                    Me.InitAdapter()
                End If

                Return Me._adapter
            End Get
        End Property

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
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
            SyncLock RestaurantPOS14.RPOS_DBDataSetTableAdapters.WarehouseTableAdapter.__ENCList
                If RestaurantPOS14.RPOS_DBDataSetTableAdapters.WarehouseTableAdapter.__ENCList.Count = RestaurantPOS14.RPOS_DBDataSetTableAdapters.WarehouseTableAdapter.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.RPOS_DBDataSetTableAdapters.WarehouseTableAdapter.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.RPOS_DBDataSetTableAdapters.WarehouseTableAdapter.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.RPOS_DBDataSetTableAdapters.WarehouseTableAdapter.__ENCList(num) = RestaurantPOS14.RPOS_DBDataSetTableAdapters.WarehouseTableAdapter.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.RPOS_DBDataSetTableAdapters.WarehouseTableAdapter.__ENCList.RemoveRange(num, RestaurantPOS14.RPOS_DBDataSetTableAdapters.WarehouseTableAdapter.__ENCList.Count - num)
                    RestaurantPOS14.RPOS_DBDataSetTableAdapters.WarehouseTableAdapter.__ENCList.Capacity = RestaurantPOS14.RPOS_DBDataSetTableAdapters.WarehouseTableAdapter.__ENCList.Count
                End If

                Call RestaurantPOS14.RPOS_DBDataSetTableAdapters.WarehouseTableAdapter.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Sub New()
            Call RestaurantPOS14.RPOS_DBDataSetTableAdapters.WarehouseTableAdapter.__ENCAddToList(Me)
            Me.ClearBeforeFill = True
        End Sub

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Sub InitAdapter()
            Me._adapter = New System.Data.SqlClient.SqlDataAdapter()
            Dim dataTableMapping As System.Data.Common.DataTableMapping = New System.Data.Common.DataTableMapping()
            dataTableMapping.SourceTable = "Table"
            dataTableMapping.DataSetTable = "Warehouse"
            dataTableMapping.ColumnMappings.Add("WarehouseName", "WarehouseName")
            dataTableMapping.ColumnMappings.Add("Address", "Address")
            dataTableMapping.ColumnMappings.Add("WarehouseType", "WarehouseType")
            dataTableMapping.ColumnMappings.Add("City", "City")
            Me._adapter.TableMappings.Add(dataTableMapping)
            Me._adapter.DeleteCommand = New System.Data.SqlClient.SqlCommand()
            Me._adapter.DeleteCommand.Connection = Me.Connection
            Me._adapter.DeleteCommand.CommandText = "DELETE FROM [dbo].[Warehouse] WHERE (([WarehouseName] = @Original_WarehouseName) AND ([Address] = @Original_Address) AND ([WarehouseType] = @Original_WarehouseType) AND ([City] = @Original_City))"
            Me._adapter.DeleteCommand.CommandType = System.Data.CommandType.Text
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_WarehouseName", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "WarehouseName", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Address", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Address", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_WarehouseType", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "WarehouseType", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_City", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "City", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand = New System.Data.SqlClient.SqlCommand()
            Me._adapter.InsertCommand.Connection = Me.Connection
            Me._adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[Warehouse] ([WarehouseName], [Address], [WarehouseType], [City]) VALUES (@WarehouseName, @Address, @WarehouseType, @City);" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "SELECT WarehouseName, Address, WarehouseType, City FROM Warehouse WHERE (WarehouseName = @WarehouseName)"
            Me._adapter.InsertCommand.CommandType = System.Data.CommandType.Text
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@WarehouseName", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "WarehouseName", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Address", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Address", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@WarehouseType", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "WarehouseType", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@City", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "City", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand = New System.Data.SqlClient.SqlCommand()
            Me._adapter.UpdateCommand.Connection = Me.Connection
            Me._adapter.UpdateCommand.CommandText = "UPDATE [dbo].[Warehouse] SET [WarehouseName] = @WarehouseName, [Address] = @Address, [WarehouseType] = @WarehouseType, [City] = @City WHERE (([WarehouseName] = @Original_WarehouseName) AND ([Address] = @Original_Address) AND ([WarehouseType] = @Original_WarehouseType) AND ([City] = @Original_City));" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "SELECT WarehouseName, Address, WarehouseType, City FROM Warehouse WHERE (WarehouseName = @WarehouseName)"
            Me._adapter.UpdateCommand.CommandType = System.Data.CommandType.Text
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@WarehouseName", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "WarehouseName", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Address", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Address", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@WarehouseType", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "WarehouseType", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@City", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "City", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_WarehouseName", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "WarehouseName", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Address", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Address", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_WarehouseType", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "WarehouseType", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_City", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "City", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Private Sub InitConnection()
            Me._connection = New System.Data.SqlClient.SqlConnection()
            Me._connection.ConnectionString = RestaurantPOS14.ConnectionString.cs
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Private Sub InitCommandCollection()
            Me._commandCollection = New System.Data.SqlClient.SqlCommand(0) {}
            Me._commandCollection(0) = New System.Data.SqlClient.SqlCommand()
            Me._commandCollection(CInt((0))).Connection = Me.Connection
            Me._commandCollection(CInt((0))).CommandText = "SELECT WarehouseName, Address, WarehouseType, City FROM dbo.Warehouse"
            Me._commandCollection(CInt((0))).CommandType = System.Data.CommandType.Text
        End Sub

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Fill, True)>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Overridable Function Fill(dataTable As RestaurantPOS14.RPOS_DBDataSet.WarehouseDataTable) As Integer
            Me.Adapter.SelectCommand = Me.CommandCollection(0)
            If Me.ClearBeforeFill Then
                dataTable.Clear()
            End If

            Return Me.Adapter.Fill(dataTable)
        End Function

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.[Select], True)>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        Public Overridable Function GetData() As RestaurantPOS14.RPOS_DBDataSet.WarehouseDataTable
            Me.Adapter.SelectCommand = Me.CommandCollection(0)
            Dim warehouseDataTable As RestaurantPOS14.RPOS_DBDataSet.WarehouseDataTable = New RestaurantPOS14.RPOS_DBDataSet.WarehouseDataTable()
            Me.Adapter.Fill(warehouseDataTable)
            Return warehouseDataTable
        End Function

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Overridable Function Update(dataTable As RestaurantPOS14.RPOS_DBDataSet.WarehouseDataTable) As Integer
            Return Me.Adapter.Update(dataTable)
        End Function

        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Overridable Function Update(dataSet As RestaurantPOS14.RPOS_DBDataSet) As Integer
            Return Me.Adapter.Update(dataSet, "Warehouse")
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        Public Overridable Function Update(dataRow As System.Data.DataRow) As Integer
            Return Me.Adapter.Update(New System.Data.DataRow(0) {dataRow})
        End Function

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Overridable Function Update(dataRows As System.Data.DataRow()) As Integer
            Return Me.Adapter.Update(dataRows)
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, True)>
        Public Overridable Function Delete(Original_WarehouseName As String, Original_Address As String, Original_WarehouseType As String, Original_City As String) As Integer
            If Equals(Original_WarehouseName, Nothing) Then
                Throw New System.ArgumentNullException("Original_WarehouseName")
            End If

            Me.Adapter.DeleteCommand.Parameters(CInt((0))).Value = Original_WarehouseName
            If Equals(Original_Address, Nothing) Then
                Throw New System.ArgumentNullException("Original_Address")
            End If

            Me.Adapter.DeleteCommand.Parameters(CInt((1))).Value = Original_Address
            If Equals(Original_WarehouseType, Nothing) Then
                Throw New System.ArgumentNullException("Original_WarehouseType")
            End If

            Me.Adapter.DeleteCommand.Parameters(CInt((2))).Value = Original_WarehouseType
            If Equals(Original_City, Nothing) Then
                Throw New System.ArgumentNullException("Original_City")
            End If

            Me.Adapter.DeleteCommand.Parameters(CInt((3))).Value = Original_City
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

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, True)>
        Public Overridable Function Insert(WarehouseName As String, Address As String, WarehouseType As String, City As String) As Integer
            If Equals(WarehouseName, Nothing) Then
                Throw New System.ArgumentNullException("WarehouseName")
            End If

            Me.Adapter.InsertCommand.Parameters(CInt((0))).Value = WarehouseName
            If Equals(Address, Nothing) Then
                Throw New System.ArgumentNullException("Address")
            End If

            Me.Adapter.InsertCommand.Parameters(CInt((1))).Value = Address
            If Equals(WarehouseType, Nothing) Then
                Throw New System.ArgumentNullException("WarehouseType")
            End If

            Me.Adapter.InsertCommand.Parameters(CInt((2))).Value = WarehouseType
            If Equals(City, Nothing) Then
                Throw New System.ArgumentNullException("City")
            End If

            Me.Adapter.InsertCommand.Parameters(CInt((3))).Value = City
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

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, True)>
        Public Overridable Function Update(WarehouseName As String, Address As String, WarehouseType As String, City As String, Original_WarehouseName As String, Original_Address As String, Original_WarehouseType As String, Original_City As String) As Integer
            If Equals(WarehouseName, Nothing) Then
                Throw New System.ArgumentNullException("WarehouseName")
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((0))).Value = WarehouseName
            If Equals(Address, Nothing) Then
                Throw New System.ArgumentNullException("Address")
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((1))).Value = Address
            If Equals(WarehouseType, Nothing) Then
                Throw New System.ArgumentNullException("WarehouseType")
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((2))).Value = WarehouseType
            If Equals(City, Nothing) Then
                Throw New System.ArgumentNullException("City")
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((3))).Value = City
            If Equals(Original_WarehouseName, Nothing) Then
                Throw New System.ArgumentNullException("Original_WarehouseName")
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((4))).Value = Original_WarehouseName
            If Equals(Original_Address, Nothing) Then
                Throw New System.ArgumentNullException("Original_Address")
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((5))).Value = Original_Address
            If Equals(Original_WarehouseType, Nothing) Then
                Throw New System.ArgumentNullException("Original_WarehouseType")
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((6))).Value = Original_WarehouseType
            If Equals(Original_City, Nothing) Then
                Throw New System.ArgumentNullException("Original_City")
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((7))).Value = Original_City
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

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, True)>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Overridable Function Update(Address As String, WarehouseType As String, City As String, Original_WarehouseName As String, Original_Address As String, Original_WarehouseType As String, Original_City As String) As Integer
            Return Me.Update(Original_WarehouseName, Address, WarehouseType, City, Original_WarehouseName, Original_Address, Original_WarehouseType, Original_City)
        End Function
    End Class
End Namespace
