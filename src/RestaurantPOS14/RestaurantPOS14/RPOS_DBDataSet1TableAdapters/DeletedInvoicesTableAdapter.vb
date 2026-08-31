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
    <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
    <System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")>
    <System.ComponentModel.DataObjectAttribute(True)>
    <System.ComponentModel.ToolboxItemAttribute(True)>
    Public Class DeletedInvoicesTableAdapter
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

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
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
            SyncLock RestaurantPOS14.RPOS_DBDataSet1TableAdapters.DeletedInvoicesTableAdapter.__ENCList
                If RestaurantPOS14.RPOS_DBDataSet1TableAdapters.DeletedInvoicesTableAdapter.__ENCList.Count = RestaurantPOS14.RPOS_DBDataSet1TableAdapters.DeletedInvoicesTableAdapter.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.RPOS_DBDataSet1TableAdapters.DeletedInvoicesTableAdapter.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.RPOS_DBDataSet1TableAdapters.DeletedInvoicesTableAdapter.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.RPOS_DBDataSet1TableAdapters.DeletedInvoicesTableAdapter.__ENCList(num) = RestaurantPOS14.RPOS_DBDataSet1TableAdapters.DeletedInvoicesTableAdapter.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.RPOS_DBDataSet1TableAdapters.DeletedInvoicesTableAdapter.__ENCList.RemoveRange(num, RestaurantPOS14.RPOS_DBDataSet1TableAdapters.DeletedInvoicesTableAdapter.__ENCList.Count - num)
                    RestaurantPOS14.RPOS_DBDataSet1TableAdapters.DeletedInvoicesTableAdapter.__ENCList.Capacity = RestaurantPOS14.RPOS_DBDataSet1TableAdapters.DeletedInvoicesTableAdapter.__ENCList.Count
                End If

                Call RestaurantPOS14.RPOS_DBDataSet1TableAdapters.DeletedInvoicesTableAdapter.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Sub New()
            Call RestaurantPOS14.RPOS_DBDataSet1TableAdapters.DeletedInvoicesTableAdapter.__ENCAddToList(Me)
            Me.ClearBeforeFill = True
        End Sub

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Sub InitAdapter()
            Me._adapter = New System.Data.SqlClient.SqlDataAdapter()
            Dim dataTableMapping As System.Data.Common.DataTableMapping = New System.Data.Common.DataTableMapping()
            dataTableMapping.SourceTable = "Table"
            dataTableMapping.DataSetTable = "DeletedInvoices"
            dataTableMapping.ColumnMappings.Add("Id", "Id")
            dataTableMapping.ColumnMappings.Add("BillNo", "BillNo")
            dataTableMapping.ColumnMappings.Add("BillDate", "BillDate")
            dataTableMapping.ColumnMappings.Add("GrandTotal", "GrandTotal")
            dataTableMapping.ColumnMappings.Add("Operator", "Operator")
            dataTableMapping.ColumnMappings.Add("PaymentMode", "PaymentMode")
            dataTableMapping.ColumnMappings.Add("Reason", "Reason")
            dataTableMapping.ColumnMappings.Add("DeletedDate", "DeletedDate")
            dataTableMapping.ColumnMappings.Add("BillType", "BillType")
            dataTableMapping.ColumnMappings.Add("Canceled_Deleted", "Canceled_Deleted")
            Me._adapter.TableMappings.Add(dataTableMapping)
            Me._adapter.DeleteCommand = New System.Data.SqlClient.SqlCommand()
            Me._adapter.DeleteCommand.Connection = Me.Connection
            Me._adapter.DeleteCommand.CommandText = "DELETE FROM [dbo].[DeletedInvoices] WHERE (([Id] = @Original_Id) AND ((@IsNull_BillNo = 1 AND [BillNo] IS NULL) OR ([BillNo] = @Original_BillNo)) AND ((@IsNull_BillDate = 1 AND [BillDate] IS NULL) OR ([BillDate] = @Original_BillDate)) AND ((@IsNull_GrandTotal = 1 AND [GrandTotal] IS NULL) OR ([GrandTotal] = @Original_GrandTotal)) AND ((@IsNull_Operator = 1 AND [Operator] IS NULL) OR ([Operator] = @Original_Operator)) AND ((@IsNull_PaymentMode = 1 AND [PaymentMode] IS NULL) OR ([PaymentMode] = @Original_PaymentMode)) AND ((@IsNull_Reason = 1 AND [Reason] IS NULL) OR ([Reason] = @Original_Reason)) AND ((@IsNull_DeletedDate = 1 AND [DeletedDate] IS NULL) OR ([DeletedDate] = @Original_DeletedDate)) AND ((@IsNull_BillType = 1 AND [BillType] IS NULL) OR ([BillType] = @Original_BillType)) AND ((@IsNull_Canceled_Deleted = 1 AND [Canceled_Deleted] IS NULL) OR ([Canceled_Deleted] = @Original_Canceled_Deleted)))"
            Me._adapter.DeleteCommand.CommandType = System.Data.CommandType.Text
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Id", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_BillNo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "BillNo", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_BillNo", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "BillNo", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_BillDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "BillDate", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_BillDate", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, 0, 0, "BillDate", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_GrandTotal", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "GrandTotal", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GrandTotal", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "GrandTotal", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Operator", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Operator", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Operator", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Operator", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_PaymentMode", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "PaymentMode", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PaymentMode", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "PaymentMode", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Reason", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Reason", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Reason", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Reason", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_DeletedDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "DeletedDate", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DeletedDate", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, 0, 0, "DeletedDate", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_BillType", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "BillType", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_BillType", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "BillType", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Canceled_Deleted", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Canceled_Deleted", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Canceled_Deleted", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Canceled_Deleted", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand = New System.Data.SqlClient.SqlCommand()
            Me._adapter.InsertCommand.Connection = Me.Connection
            Me._adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[DeletedInvoices] ([BillNo], [BillDate], [GrandTotal], [Operator], [PaymentMode], [Reason], [DeletedDate], [BillType], [Canceled_Deleted]) VALUES (@BillNo, @BillDate, @GrandTotal, @Operator, @PaymentMode, @Reason, @DeletedDate, @BillType, @Canceled_Deleted);" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "SELECT Id, BillNo, BillDate, GrandTotal, Operator, PaymentMode, Reason, DeletedDate, BillType, Canceled_Deleted FROM DeletedInvoices WHERE (Id = SCOPE_IDENTITY())"
            Me._adapter.InsertCommand.CommandType = System.Data.CommandType.Text
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@BillNo", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "BillNo", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@BillDate", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, 0, 0, "BillDate", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GrandTotal", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "GrandTotal", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Operator", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Operator", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PaymentMode", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "PaymentMode", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Reason", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Reason", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DeletedDate", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, 0, 0, "DeletedDate", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@BillType", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "BillType", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Canceled_Deleted", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Canceled_Deleted", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand = New System.Data.SqlClient.SqlCommand()
            Me._adapter.UpdateCommand.Connection = Me.Connection
            Me._adapter.UpdateCommand.CommandText = "UPDATE [dbo].[DeletedInvoices] SET [BillNo] = @BillNo, [BillDate] = @BillDate, [GrandTotal] = @GrandTotal, [Operator] = @Operator, [PaymentMode] = @PaymentMode, [Reason] = @Reason, [DeletedDate] = @DeletedDate, [BillType] = @BillType, [Canceled_Deleted] = @Canceled_Deleted WHERE (([Id] = @Original_Id) AND ((@IsNull_BillNo = 1 AND [BillNo] IS NULL) OR ([BillNo] = @Original_BillNo)) AND ((@IsNull_BillDate = 1 AND [BillDate] IS NULL) OR ([BillDate] = @Original_BillDate)) AND ((@IsNull_GrandTotal = 1 AND [GrandTotal] IS NULL) OR ([GrandTotal] = @Original_GrandTotal)) AND ((@IsNull_Operator = 1 AND [Operator] IS NULL) OR ([Operator] = @Original_Operator)) AND ((@IsNull_PaymentMode = 1 AND [PaymentMode] IS NULL) OR ([PaymentMode] = @Original_PaymentMode)) AND ((@IsNull_Reason = 1 AND [Reason] IS NULL) OR ([Reason] = @Original_Reason)) AND ((@IsNull_DeletedDate = 1 AND [DeletedDate] IS NULL) OR ([DeletedDate] = @Original_DeletedDate)) AND ((@IsNull_BillType = 1 AND [BillType] IS NULL) OR ([BillType] = @Original_BillType)) AND ((@IsNull_Canceled_Deleted = 1 AND [Canceled_Deleted] IS NULL) OR ([Canceled_Deleted] = @Original_Canceled_Deleted)));" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "SELECT Id, BillNo, BillDate, GrandTotal, Operator, PaymentMode, Reason, DeletedDate, BillType, Canceled_Deleted FROM DeletedInvoices WHERE (Id = @Id)"
            Me._adapter.UpdateCommand.CommandType = System.Data.CommandType.Text
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@BillNo", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "BillNo", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@BillDate", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, 0, 0, "BillDate", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GrandTotal", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "GrandTotal", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Operator", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Operator", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PaymentMode", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "PaymentMode", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Reason", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Reason", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DeletedDate", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, 0, 0, "DeletedDate", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@BillType", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "BillType", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Canceled_Deleted", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Canceled_Deleted", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Id", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_BillNo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "BillNo", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_BillNo", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "BillNo", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_BillDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "BillDate", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_BillDate", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, 0, 0, "BillDate", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_GrandTotal", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "GrandTotal", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GrandTotal", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "GrandTotal", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Operator", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Operator", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Operator", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Operator", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_PaymentMode", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "PaymentMode", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PaymentMode", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "PaymentMode", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Reason", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Reason", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Reason", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Reason", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_DeletedDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "DeletedDate", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DeletedDate", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, 0, 0, "DeletedDate", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_BillType", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "BillType", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_BillType", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "BillType", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Canceled_Deleted", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Canceled_Deleted", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Canceled_Deleted", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Canceled_Deleted", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, 0, 0, "Id", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Private Sub InitConnection()
            Me._connection = New System.Data.SqlClient.SqlConnection()
            Me._connection.ConnectionString = RestaurantPOS14.My.MySettings.[Default].RPOS_DBConnectionString
        End Sub

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Sub InitCommandCollection()
            Me._commandCollection = New System.Data.SqlClient.SqlCommand(0) {}
            Me._commandCollection(0) = New System.Data.SqlClient.SqlCommand()
            Me._commandCollection(CInt((0))).Connection = Me.Connection
            Me._commandCollection(CInt((0))).CommandText = "SELECT Id, BillNo, BillDate, GrandTotal, Operator, PaymentMode, Reason, DeletedDate, BillType, Canceled_Deleted FROM dbo.DeletedInvoices"
            Me._commandCollection(CInt((0))).CommandType = System.Data.CommandType.Text
        End Sub

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Fill, True)>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Overridable Function Fill(dataTable As RestaurantPOS14.RPOS_DBDataSet1.DeletedInvoicesDataTable) As Integer
            Me.Adapter.SelectCommand = Me.CommandCollection(0)
            If Me.ClearBeforeFill Then
                dataTable.Clear()
            End If

            Return Me.Adapter.Fill(dataTable)
        End Function

        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.[Select], True)>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Overridable Function GetData() As RestaurantPOS14.RPOS_DBDataSet1.DeletedInvoicesDataTable
            Me.Adapter.SelectCommand = Me.CommandCollection(0)
            Dim deletedInvoicesDataTable As RestaurantPOS14.RPOS_DBDataSet1.DeletedInvoicesDataTable = New RestaurantPOS14.RPOS_DBDataSet1.DeletedInvoicesDataTable()
            Me.Adapter.Fill(deletedInvoicesDataTable)
            Return deletedInvoicesDataTable
        End Function

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        Public Overridable Function Update(dataTable As RestaurantPOS14.RPOS_DBDataSet1.DeletedInvoicesDataTable) As Integer
            Return Me.Adapter.Update(dataTable)
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Overridable Function Update(dataSet As RestaurantPOS14.RPOS_DBDataSet1) As Integer
            Return Me.Adapter.Update(dataSet, "DeletedInvoices")
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

        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, True)>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Overridable Function Delete(Original_Id As Integer, Original_BillNo As String, Original_BillDate As System.DateTime?, Original_GrandTotal As Decimal?, Original_Operator As String, Original_PaymentMode As String, Original_Reason As String, Original_DeletedDate As System.DateTime?, Original_BillType As String, Original_Canceled_Deleted As String) As Integer
            Me.Adapter.DeleteCommand.Parameters(CInt((0))).Value = Original_Id
            If Equals(Original_BillNo, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((1))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((2))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((1))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((2))).Value = Original_BillNo
            End If

            If Original_BillDate.HasValue Then
                Me.Adapter.DeleteCommand.Parameters(CInt((3))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((4))).Value = Original_BillDate.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((3))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((4))).Value = System.DBNull.Value
            End If

            If Original_GrandTotal.HasValue Then
                Me.Adapter.DeleteCommand.Parameters(CInt((5))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((6))).Value = Original_GrandTotal.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((5))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((6))).Value = System.DBNull.Value
            End If

            If Equals(Original_Operator, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((7))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((8))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((7))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((8))).Value = Original_Operator
            End If

            If Equals(Original_PaymentMode, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((9))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((10))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((9))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((10))).Value = Original_PaymentMode
            End If

            If Equals(Original_Reason, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((11))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((12))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((11))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((12))).Value = Original_Reason
            End If

            If Original_DeletedDate.HasValue Then
                Me.Adapter.DeleteCommand.Parameters(CInt((13))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((14))).Value = Original_DeletedDate.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((13))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((14))).Value = System.DBNull.Value
            End If

            If Equals(Original_BillType, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((15))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((16))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((15))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((16))).Value = Original_BillType
            End If

            If Equals(Original_Canceled_Deleted, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((17))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((18))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((17))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((18))).Value = Original_Canceled_Deleted
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

        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, True)>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Overridable Function Insert(BillNo As String, BillDate As System.DateTime?, GrandTotal As Decimal?, _Operator As String, PaymentMode As String, Reason As String, DeletedDate As System.DateTime?, BillType As String, Canceled_Deleted As String) As Integer
            If Equals(BillNo, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((0))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((0))).Value = BillNo
            End If

            If BillDate.HasValue Then
                Me.Adapter.InsertCommand.Parameters(CInt((1))).Value = BillDate.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((1))).Value = System.DBNull.Value
            End If

            If GrandTotal.HasValue Then
                Me.Adapter.InsertCommand.Parameters(CInt((2))).Value = GrandTotal.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((2))).Value = System.DBNull.Value
            End If

            If Equals(_Operator, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((3))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((3))).Value = _Operator
            End If

            If Equals(PaymentMode, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((4))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((4))).Value = PaymentMode
            End If

            If Equals(Reason, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((5))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((5))).Value = Reason
            End If

            If DeletedDate.HasValue Then
                Me.Adapter.InsertCommand.Parameters(CInt((6))).Value = DeletedDate.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((6))).Value = System.DBNull.Value
            End If

            If Equals(BillType, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((7))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((7))).Value = BillType
            End If

            If Equals(Canceled_Deleted, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((8))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((8))).Value = Canceled_Deleted
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

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, True)>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Overridable Function Update(BillNo As String, BillDate As System.DateTime?, GrandTotal As Decimal?, _Operator As String, PaymentMode As String, Reason As String, DeletedDate As System.DateTime?, BillType As String, Canceled_Deleted As String, Original_Id As Integer, Original_BillNo As String, Original_BillDate As System.DateTime?, Original_GrandTotal As Decimal?, Original_Operator As String, Original_PaymentMode As String, Original_Reason As String, Original_DeletedDate As System.DateTime?, Original_BillType As String, Original_Canceled_Deleted As String, Id As Integer) As Integer
            If Equals(BillNo, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((0))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((0))).Value = BillNo
            End If

            If BillDate.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((1))).Value = BillDate.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((1))).Value = System.DBNull.Value
            End If

            If GrandTotal.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((2))).Value = GrandTotal.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((2))).Value = System.DBNull.Value
            End If

            If Equals(_Operator, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((3))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((3))).Value = _Operator
            End If

            If Equals(PaymentMode, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((4))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((4))).Value = PaymentMode
            End If

            If Equals(Reason, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((5))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((5))).Value = Reason
            End If

            If DeletedDate.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((6))).Value = DeletedDate.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((6))).Value = System.DBNull.Value
            End If

            If Equals(BillType, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((7))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((7))).Value = BillType
            End If

            If Equals(Canceled_Deleted, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((8))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((8))).Value = Canceled_Deleted
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((9))).Value = Original_Id
            If Equals(Original_BillNo, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((10))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((11))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((10))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((11))).Value = Original_BillNo
            End If

            If Original_BillDate.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((12))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((13))).Value = Original_BillDate.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((12))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((13))).Value = System.DBNull.Value
            End If

            If Original_GrandTotal.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((14))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((15))).Value = Original_GrandTotal.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((14))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((15))).Value = System.DBNull.Value
            End If

            If Equals(Original_Operator, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((16))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((17))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((16))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((17))).Value = Original_Operator
            End If

            If Equals(Original_PaymentMode, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((18))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((19))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((18))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((19))).Value = Original_PaymentMode
            End If

            If Equals(Original_Reason, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((20))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((21))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((20))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((21))).Value = Original_Reason
            End If

            If Original_DeletedDate.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((22))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((23))).Value = Original_DeletedDate.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((22))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((23))).Value = System.DBNull.Value
            End If

            If Equals(Original_BillType, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((24))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((25))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((24))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((25))).Value = Original_BillType
            End If

            If Equals(Original_Canceled_Deleted, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((26))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((27))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((26))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((27))).Value = Original_Canceled_Deleted
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((28))).Value = Id
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
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Overridable Function Update(BillNo As String, BillDate As System.DateTime?, GrandTotal As Decimal?, _Operator As String, PaymentMode As String, Reason As String, DeletedDate As System.DateTime?, BillType As String, Canceled_Deleted As String, Original_Id As Integer, Original_BillNo As String, Original_BillDate As System.DateTime?, Original_GrandTotal As Decimal?, Original_Operator As String, Original_PaymentMode As String, Original_Reason As String, Original_DeletedDate As System.DateTime?, Original_BillType As String, Original_Canceled_Deleted As String) As Integer
            Return Me.Update(BillNo, BillDate, GrandTotal, _Operator, PaymentMode, Reason, DeletedDate, BillType, Canceled_Deleted, Original_Id, Original_BillNo, Original_BillDate, Original_GrandTotal, Original_Operator, Original_PaymentMode, Original_Reason, Original_DeletedDate, Original_BillType, Original_Canceled_Deleted, Original_Id)
        End Function
    End Class
End Namespace
