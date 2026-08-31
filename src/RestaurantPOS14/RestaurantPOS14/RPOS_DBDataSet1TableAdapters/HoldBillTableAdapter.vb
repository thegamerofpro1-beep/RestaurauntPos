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
    <System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")>
    <System.ComponentModel.ToolboxItemAttribute(True)>
    <System.ComponentModel.DesignerCategoryAttribute("code")>
    <System.ComponentModel.DataObjectAttribute(True)>
    <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
    Public Class HoldBillTableAdapter
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

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Protected Friend ReadOnly Property Adapter As System.Data.SqlClient.SqlDataAdapter
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

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
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

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
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
            SyncLock RestaurantPOS14.RPOS_DBDataSet1TableAdapters.HoldBillTableAdapter.__ENCList
                If RestaurantPOS14.RPOS_DBDataSet1TableAdapters.HoldBillTableAdapter.__ENCList.Count = RestaurantPOS14.RPOS_DBDataSet1TableAdapters.HoldBillTableAdapter.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.RPOS_DBDataSet1TableAdapters.HoldBillTableAdapter.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.RPOS_DBDataSet1TableAdapters.HoldBillTableAdapter.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.RPOS_DBDataSet1TableAdapters.HoldBillTableAdapter.__ENCList(num) = RestaurantPOS14.RPOS_DBDataSet1TableAdapters.HoldBillTableAdapter.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.RPOS_DBDataSet1TableAdapters.HoldBillTableAdapter.__ENCList.RemoveRange(num, RestaurantPOS14.RPOS_DBDataSet1TableAdapters.HoldBillTableAdapter.__ENCList.Count - num)
                    RestaurantPOS14.RPOS_DBDataSet1TableAdapters.HoldBillTableAdapter.__ENCList.Capacity = RestaurantPOS14.RPOS_DBDataSet1TableAdapters.HoldBillTableAdapter.__ENCList.Count
                End If

                Call RestaurantPOS14.RPOS_DBDataSet1TableAdapters.HoldBillTableAdapter.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Sub New()
            Call RestaurantPOS14.RPOS_DBDataSet1TableAdapters.HoldBillTableAdapter.__ENCAddToList(Me)
            Me.ClearBeforeFill = True
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Private Sub InitAdapter()
            Me._adapter = New System.Data.SqlClient.SqlDataAdapter()
            Dim dataTableMapping As System.Data.Common.DataTableMapping = New System.Data.Common.DataTableMapping()
            dataTableMapping.SourceTable = "Table"
            dataTableMapping.DataSetTable = "HoldBill"
            dataTableMapping.ColumnMappings.Add("HoldID", "HoldID")
            dataTableMapping.ColumnMappings.Add("Date", "Date")
            dataTableMapping.ColumnMappings.Add("UserID", "UserID")
            dataTableMapping.ColumnMappings.Add("BillType", "BillType")
            dataTableMapping.ColumnMappings.Add("TaxType", "TaxType")
            dataTableMapping.ColumnMappings.Add("TableNo", "TableNo")
            dataTableMapping.ColumnMappings.Add("CName", "CName")
            dataTableMapping.ColumnMappings.Add("Address", "Address")
            dataTableMapping.ColumnMappings.Add("CNo", "CNo")
            Me._adapter.TableMappings.Add(dataTableMapping)
            Me._adapter.DeleteCommand = New System.Data.SqlClient.SqlCommand()
            Me._adapter.DeleteCommand.Connection = Me.Connection
            Me._adapter.DeleteCommand.CommandText = "DELETE FROM [dbo].[HoldBill] WHERE (([HoldID] = @Original_HoldID) AND ((@IsNull_Date = 1 AND [Date] IS NULL) OR ([Date] = @Original_Date)) AND ((@IsNull_UserID = 1 AND [UserID] IS NULL) OR ([UserID] = @Original_UserID)) AND ((@IsNull_BillType = 1 AND [BillType] IS NULL) OR ([BillType] = @Original_BillType)) AND ((@IsNull_TaxType = 1 AND [TaxType] IS NULL) OR ([TaxType] = @Original_TaxType)) AND ((@IsNull_TableNo = 1 AND [TableNo] IS NULL) OR ([TableNo] = @Original_TableNo)) AND ((@IsNull_CName = 1 AND [CName] IS NULL) OR ([CName] = @Original_CName)) AND ((@IsNull_Address = 1 AND [Address] IS NULL) OR ([Address] = @Original_Address)) AND ((@IsNull_CNo = 1 AND [CNo] IS NULL) OR ([CNo] = @Original_CNo)))"
            Me._adapter.DeleteCommand.CommandType = System.Data.CommandType.Text
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_HoldID", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "HoldID", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Date", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Date", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Date", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, 0, 0, "Date", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_UserID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "UserID", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_UserID", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "UserID", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_BillType", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "BillType", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_BillType", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "BillType", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_TaxType", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "TaxType", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TaxType", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "TaxType", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_TableNo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "TableNo", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TableNo", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "TableNo", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_CName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "CName", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CName", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "CName", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Address", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Address", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Address", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Address", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_CNo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "CNo", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CNo", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "CNo", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand = New System.Data.SqlClient.SqlCommand()
            Me._adapter.InsertCommand.Connection = Me.Connection
            Me._adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[HoldBill] ([HoldID], [Date], [UserID], [BillType], [TaxType], [TableNo], [CName], [Address], [CNo]) VALUES (@HoldID, @Date, @UserID, @BillType, @TaxType, @TableNo, @CName, @Address, @CNo);" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "SELECT HoldID, Date, UserID, BillType, TaxType, TableNo, CName, Address, CNo FROM HoldBill WHERE (HoldID = @HoldID)"
            Me._adapter.InsertCommand.CommandType = System.Data.CommandType.Text
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@HoldID", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "HoldID", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Date", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, 0, 0, "Date", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@UserID", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "UserID", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@BillType", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "BillType", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TaxType", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "TaxType", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TableNo", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "TableNo", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CName", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "CName", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Address", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Address", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CNo", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "CNo", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand = New System.Data.SqlClient.SqlCommand()
            Me._adapter.UpdateCommand.Connection = Me.Connection
            Me._adapter.UpdateCommand.CommandText = "UPDATE [dbo].[HoldBill] SET [HoldID] = @HoldID, [Date] = @Date, [UserID] = @UserID, [BillType] = @BillType, [TaxType] = @TaxType, [TableNo] = @TableNo, [CName] = @CName, [Address] = @Address, [CNo] = @CNo WHERE (([HoldID] = @Original_HoldID) AND ((@IsNull_Date = 1 AND [Date] IS NULL) OR ([Date] = @Original_Date)) AND ((@IsNull_UserID = 1 AND [UserID] IS NULL) OR ([UserID] = @Original_UserID)) AND ((@IsNull_BillType = 1 AND [BillType] IS NULL) OR ([BillType] = @Original_BillType)) AND ((@IsNull_TaxType = 1 AND [TaxType] IS NULL) OR ([TaxType] = @Original_TaxType)) AND ((@IsNull_TableNo = 1 AND [TableNo] IS NULL) OR ([TableNo] = @Original_TableNo)) AND ((@IsNull_CName = 1 AND [CName] IS NULL) OR ([CName] = @Original_CName)) AND ((@IsNull_Address = 1 AND [Address] IS NULL) OR ([Address] = @Original_Address)) AND ((@IsNull_CNo = 1 AND [CNo] IS NULL) OR ([CNo] = @Original_CNo)));" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "SELECT HoldID, Date, UserID, BillType, TaxType, TableNo, CName, Address, CNo FROM HoldBill WHERE (HoldID = @HoldID)"
            Me._adapter.UpdateCommand.CommandType = System.Data.CommandType.Text
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@HoldID", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "HoldID", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Date", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, 0, 0, "Date", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@UserID", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "UserID", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@BillType", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "BillType", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TaxType", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "TaxType", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TableNo", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "TableNo", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CName", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "CName", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Address", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Address", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CNo", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "CNo", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_HoldID", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "HoldID", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Date", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Date", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Date", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, 0, 0, "Date", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_UserID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "UserID", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_UserID", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "UserID", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_BillType", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "BillType", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_BillType", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "BillType", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_TaxType", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "TaxType", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TaxType", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "TaxType", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_TableNo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "TableNo", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TableNo", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "TableNo", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_CName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "CName", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CName", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "CName", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Address", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Address", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Address", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Address", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_CNo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "CNo", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CNo", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "CNo", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
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
            Me._commandCollection(CInt((0))).CommandText = "SELECT HoldID, Date, UserID, BillType, TaxType, TableNo, CName, Address, CNo FROM dbo.HoldBill"
            Me._commandCollection(CInt((0))).CommandType = System.Data.CommandType.Text
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Fill, True)>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Overridable Function Fill(dataTable As RestaurantPOS14.RPOS_DBDataSet1.HoldBillDataTable) As Integer
            Me.Adapter.SelectCommand = Me.CommandCollection(0)
            If Me.ClearBeforeFill Then
                dataTable.Clear()
            End If

            Return Me.Adapter.Fill(dataTable)
        End Function

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.[Select], True)>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        Public Overridable Function GetData() As RestaurantPOS14.RPOS_DBDataSet1.HoldBillDataTable
            Me.Adapter.SelectCommand = Me.CommandCollection(0)
            Dim holdBillDataTable As RestaurantPOS14.RPOS_DBDataSet1.HoldBillDataTable = New RestaurantPOS14.RPOS_DBDataSet1.HoldBillDataTable()
            Me.Adapter.Fill(holdBillDataTable)
            Return holdBillDataTable
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Overridable Function Update(dataTable As RestaurantPOS14.RPOS_DBDataSet1.HoldBillDataTable) As Integer
            Return Me.Adapter.Update(dataTable)
        End Function

        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Overridable Function Update(dataSet As RestaurantPOS14.RPOS_DBDataSet1) As Integer
            Return Me.Adapter.Update(dataSet, "HoldBill")
        End Function

        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Overridable Function Update(dataRow As System.Data.DataRow) As Integer
            Return Me.Adapter.Update(New System.Data.DataRow(0) {dataRow})
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Overridable Function Update(dataRows As System.Data.DataRow()) As Integer
            Return Me.Adapter.Update(dataRows)
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, True)>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        Public Overridable Function Delete(Original_HoldID As String, Original_Date As System.DateTime?, Original_UserID As String, Original_BillType As String, Original_TaxType As String, Original_TableNo As String, Original_CName As String, Original_Address As String, Original_CNo As String) As Integer
            If Equals(Original_HoldID, Nothing) Then
                Throw New System.ArgumentNullException("Original_HoldID")
            End If

            Me.Adapter.DeleteCommand.Parameters(CInt((0))).Value = Original_HoldID
            If Original_Date.HasValue Then
                Me.Adapter.DeleteCommand.Parameters(CInt((1))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((2))).Value = Original_Date.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((1))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((2))).Value = System.DBNull.Value
            End If

            If Equals(Original_UserID, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((3))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((4))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((3))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((4))).Value = Original_UserID
            End If

            If Equals(Original_BillType, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((5))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((6))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((5))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((6))).Value = Original_BillType
            End If

            If Equals(Original_TaxType, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((7))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((8))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((7))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((8))).Value = Original_TaxType
            End If

            If Equals(Original_TableNo, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((9))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((10))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((9))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((10))).Value = Original_TableNo
            End If

            If Equals(Original_CName, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((11))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((12))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((11))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((12))).Value = Original_CName
            End If

            If Equals(Original_Address, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((13))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((14))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((13))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((14))).Value = Original_Address
            End If

            If Equals(Original_CNo, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((15))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((16))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((15))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((16))).Value = Original_CNo
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

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, True)>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        Public Overridable Function Insert(HoldID As String, _Date As System.DateTime?, UserID As String, BillType As String, TaxType As String, TableNo As String, CName As String, Address As String, CNo As String) As Integer
            If Equals(HoldID, Nothing) Then
                Throw New System.ArgumentNullException("HoldID")
            End If

            Me.Adapter.InsertCommand.Parameters(CInt((0))).Value = HoldID
            If _Date.HasValue Then
                Me.Adapter.InsertCommand.Parameters(CInt((1))).Value = _Date.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((1))).Value = System.DBNull.Value
            End If

            If Equals(UserID, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((2))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((2))).Value = UserID
            End If

            If Equals(BillType, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((3))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((3))).Value = BillType
            End If

            If Equals(TaxType, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((4))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((4))).Value = TaxType
            End If

            If Equals(TableNo, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((5))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((5))).Value = TableNo
            End If

            If Equals(CName, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((6))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((6))).Value = CName
            End If

            If Equals(Address, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((7))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((7))).Value = Address
            End If

            If Equals(CNo, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((8))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((8))).Value = CNo
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

        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, True)>
        Public Overridable Function Update(HoldID As String, _Date As System.DateTime?, UserID As String, BillType As String, TaxType As String, TableNo As String, CName As String, Address As String, CNo As String, Original_HoldID As String, Original_Date As System.DateTime?, Original_UserID As String, Original_BillType As String, Original_TaxType As String, Original_TableNo As String, Original_CName As String, Original_Address As String, Original_CNo As String) As Integer
            If Equals(HoldID, Nothing) Then
                Throw New System.ArgumentNullException("HoldID")
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((0))).Value = HoldID
            If _Date.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((1))).Value = _Date.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((1))).Value = System.DBNull.Value
            End If

            If Equals(UserID, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((2))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((2))).Value = UserID
            End If

            If Equals(BillType, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((3))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((3))).Value = BillType
            End If

            If Equals(TaxType, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((4))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((4))).Value = TaxType
            End If

            If Equals(TableNo, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((5))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((5))).Value = TableNo
            End If

            If Equals(CName, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((6))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((6))).Value = CName
            End If

            If Equals(Address, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((7))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((7))).Value = Address
            End If

            If Equals(CNo, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((8))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((8))).Value = CNo
            End If

            If Equals(Original_HoldID, Nothing) Then
                Throw New System.ArgumentNullException("Original_HoldID")
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((9))).Value = Original_HoldID
            If Original_Date.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((10))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((11))).Value = Original_Date.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((10))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((11))).Value = System.DBNull.Value
            End If

            If Equals(Original_UserID, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((12))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((13))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((12))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((13))).Value = Original_UserID
            End If

            If Equals(Original_BillType, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((14))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((15))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((14))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((15))).Value = Original_BillType
            End If

            If Equals(Original_TaxType, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((16))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((17))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((16))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((17))).Value = Original_TaxType
            End If

            If Equals(Original_TableNo, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((18))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((19))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((18))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((19))).Value = Original_TableNo
            End If

            If Equals(Original_CName, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((20))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((21))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((20))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((21))).Value = Original_CName
            End If

            If Equals(Original_Address, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((22))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((23))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((22))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((23))).Value = Original_Address
            End If

            If Equals(Original_CNo, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((24))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((25))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((24))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((25))).Value = Original_CNo
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

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, True)>
        Public Overridable Function Update(_Date As System.DateTime?, UserID As String, BillType As String, TaxType As String, TableNo As String, CName As String, Address As String, CNo As String, Original_HoldID As String, Original_Date As System.DateTime?, Original_UserID As String, Original_BillType As String, Original_TaxType As String, Original_TableNo As String, Original_CName As String, Original_Address As String, Original_CNo As String) As Integer
            Return Me.Update(Original_HoldID, _Date, UserID, BillType, TaxType, TableNo, CName, Address, CNo, Original_HoldID, Original_Date, Original_UserID, Original_BillType, Original_TaxType, Original_TableNo, Original_CName, Original_Address, Original_CNo)
        End Function
    End Class
End Namespace
