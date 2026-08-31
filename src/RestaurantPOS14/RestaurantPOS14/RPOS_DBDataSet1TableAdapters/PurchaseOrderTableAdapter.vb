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
    <System.ComponentModel.ToolboxItemAttribute(True)>
    <System.ComponentModel.DesignerCategoryAttribute("code")>
    <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
    <System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")>
    <System.ComponentModel.DataObjectAttribute(True)>
    Public Class PurchaseOrderTableAdapter
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
            SyncLock RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PurchaseOrderTableAdapter.__ENCList
                If RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PurchaseOrderTableAdapter.__ENCList.Count = RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PurchaseOrderTableAdapter.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PurchaseOrderTableAdapter.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PurchaseOrderTableAdapter.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PurchaseOrderTableAdapter.__ENCList(num) = RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PurchaseOrderTableAdapter.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PurchaseOrderTableAdapter.__ENCList.RemoveRange(num, RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PurchaseOrderTableAdapter.__ENCList.Count - num)
                    RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PurchaseOrderTableAdapter.__ENCList.Capacity = RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PurchaseOrderTableAdapter.__ENCList.Count
                End If

                Call RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PurchaseOrderTableAdapter.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Sub New()
            Call RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PurchaseOrderTableAdapter.__ENCAddToList(Me)
            Me.ClearBeforeFill = True
        End Sub

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Sub InitAdapter()
            Me._adapter = New System.Data.SqlClient.SqlDataAdapter()
            Dim dataTableMapping As System.Data.Common.DataTableMapping = New System.Data.Common.DataTableMapping()
            dataTableMapping.SourceTable = "Table"
            dataTableMapping.DataSetTable = "PurchaseOrder"
            dataTableMapping.ColumnMappings.Add("PO_ID", "PO_ID")
            dataTableMapping.ColumnMappings.Add("PONumber", "PONumber")
            dataTableMapping.ColumnMappings.Add("Date", "Date")
            dataTableMapping.ColumnMappings.Add("Supplier_ID", "Supplier_ID")
            dataTableMapping.ColumnMappings.Add("Terms", "Terms")
            dataTableMapping.ColumnMappings.Add("SubTotal", "SubTotal")
            dataTableMapping.ColumnMappings.Add("VATPer", "VATPer")
            dataTableMapping.ColumnMappings.Add("VATAmount", "VATAmount")
            dataTableMapping.ColumnMappings.Add("GrandTotal", "GrandTotal")
            dataTableMapping.ColumnMappings.Add("TaxType", "TaxType")
            Me._adapter.TableMappings.Add(dataTableMapping)
            Me._adapter.DeleteCommand = New System.Data.SqlClient.SqlCommand()
            Me._adapter.DeleteCommand.Connection = Me.Connection
            Me._adapter.DeleteCommand.CommandText = "DELETE FROM [dbo].[PurchaseOrder] WHERE (([PO_ID] = @Original_PO_ID) AND ([PONumber] = @Original_PONumber) AND ((@IsNull_Date = 1 AND [Date] IS NULL) OR ([Date] = @Original_Date)) AND ((@IsNull_Supplier_ID = 1 AND [Supplier_ID] IS NULL) OR ([Supplier_ID] = @Original_Supplier_ID)) AND ((@IsNull_SubTotal = 1 AND [SubTotal] IS NULL) OR ([SubTotal] = @Original_SubTotal)) AND ((@IsNull_VATPer = 1 AND [VATPer] IS NULL) OR ([VATPer] = @Original_VATPer)) AND ((@IsNull_VATAmount = 1 AND [VATAmount] IS NULL) OR ([VATAmount] = @Original_VATAmount)) AND ((@IsNull_GrandTotal = 1 AND [GrandTotal] IS NULL) OR ([GrandTotal] = @Original_GrandTotal)) AND ((@IsNull_TaxType = 1 AND [TaxType] IS NULL) OR ([TaxType] = @Original_TaxType)))"
            Me._adapter.DeleteCommand.CommandType = System.Data.CommandType.Text
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PO_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "PO_ID", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PONumber", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "PONumber", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Date", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Date", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Date", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, 0, 0, "Date", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Supplier_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Supplier_ID", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Supplier_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Supplier_ID", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_SubTotal", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "SubTotal", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SubTotal", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "SubTotal", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_VATPer", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "VATPer", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_VATPer", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "VATPer", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_VATAmount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "VATAmount", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_VATAmount", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "VATAmount", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_GrandTotal", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "GrandTotal", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GrandTotal", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "GrandTotal", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_TaxType", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "TaxType", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TaxType", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "TaxType", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand = New System.Data.SqlClient.SqlCommand()
            Me._adapter.InsertCommand.Connection = Me.Connection
            Me._adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[PurchaseOrder] ([PO_ID], [PONumber], [Date], [Supplier_ID], [Terms], [SubTotal], [VATPer], [VATAmount], [GrandTotal], [TaxType]) VALUES (@PO_ID, @PONumber, @Date, @Supplier_ID, @Terms, @SubTotal, @VATPer, @VATAmount, @GrandTotal, @TaxType);" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "SELECT PO_ID, PONumber, Date, Supplier_ID, Terms, SubTotal, VATPer, VATAmount, GrandTotal, TaxType FROM PurchaseOrder WHERE (PO_ID = @PO_ID)"
            Me._adapter.InsertCommand.CommandType = System.Data.CommandType.Text
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PO_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "PO_ID", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PONumber", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "PONumber", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Date", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, 0, 0, "Date", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Supplier_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Supplier_ID", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Terms", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Terms", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SubTotal", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "SubTotal", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@VATPer", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "VATPer", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@VATAmount", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "VATAmount", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GrandTotal", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "GrandTotal", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TaxType", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "TaxType", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand = New System.Data.SqlClient.SqlCommand()
            Me._adapter.UpdateCommand.Connection = Me.Connection
            Me._adapter.UpdateCommand.CommandText = "UPDATE [dbo].[PurchaseOrder] SET [PO_ID] = @PO_ID, [PONumber] = @PONumber, [Date] = @Date, [Supplier_ID] = @Supplier_ID, [Terms] = @Terms, [SubTotal] = @SubTotal, [VATPer] = @VATPer, [VATAmount] = @VATAmount, [GrandTotal] = @GrandTotal, [TaxType] = @TaxType WHERE (([PO_ID] = @Original_PO_ID) AND ([PONumber] = @Original_PONumber) AND ((@IsNull_Date = 1 AND [Date] IS NULL) OR ([Date] = @Original_Date)) AND ((@IsNull_Supplier_ID = 1 AND [Supplier_ID] IS NULL) OR ([Supplier_ID] = @Original_Supplier_ID)) AND ((@IsNull_SubTotal = 1 AND [SubTotal] IS NULL) OR ([SubTotal] = @Original_SubTotal)) AND ((@IsNull_VATPer = 1 AND [VATPer] IS NULL) OR ([VATPer] = @Original_VATPer)) AND ((@IsNull_VATAmount = 1 AND [VATAmount] IS NULL) OR ([VATAmount] = @Original_VATAmount)) AND ((@IsNull_GrandTotal = 1 AND [GrandTotal] IS NULL) OR ([GrandTotal] = @Original_GrandTotal)) AND ((@IsNull_TaxType = 1 AND [TaxType] IS NULL) OR ([TaxType] = @Original_TaxType)));" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "SELECT PO_ID, PONumber, Date, Supplier_ID, Terms, SubTotal, VATPer, VATAmount, GrandTotal, TaxType FROM PurchaseOrder WHERE (PO_ID = @PO_ID)"
            Me._adapter.UpdateCommand.CommandType = System.Data.CommandType.Text
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PO_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "PO_ID", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PONumber", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "PONumber", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Date", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, 0, 0, "Date", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Supplier_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Supplier_ID", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Terms", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Terms", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SubTotal", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "SubTotal", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@VATPer", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "VATPer", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@VATAmount", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "VATAmount", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GrandTotal", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "GrandTotal", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TaxType", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "TaxType", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PO_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "PO_ID", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PONumber", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "PONumber", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Date", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Date", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Date", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, 0, 0, "Date", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Supplier_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Supplier_ID", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Supplier_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Supplier_ID", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_SubTotal", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "SubTotal", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SubTotal", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "SubTotal", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_VATPer", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "VATPer", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_VATPer", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "VATPer", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_VATAmount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "VATAmount", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_VATAmount", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "VATAmount", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_GrandTotal", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "GrandTotal", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GrandTotal", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "GrandTotal", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_TaxType", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "TaxType", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TaxType", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "TaxType", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
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
            Me._commandCollection(CInt((0))).CommandText = "SELECT PO_ID, PONumber, Date, Supplier_ID, Terms, SubTotal, VATPer, VATAmount, GrandTotal, TaxType FROM dbo.PurchaseOrder"
            Me._commandCollection(CInt((0))).CommandType = System.Data.CommandType.Text
        End Sub

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Fill, True)>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Overridable Function Fill(dataTable As RestaurantPOS14.RPOS_DBDataSet1.PurchaseOrderDataTable) As Integer
            Me.Adapter.SelectCommand = Me.CommandCollection(0)
            If Me.ClearBeforeFill Then
                dataTable.Clear()
            End If

            Return Me.Adapter.Fill(dataTable)
        End Function

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.[Select], True)>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Overridable Function GetData() As RestaurantPOS14.RPOS_DBDataSet1.PurchaseOrderDataTable
            Me.Adapter.SelectCommand = Me.CommandCollection(0)
            Dim purchaseOrderDataTable As RestaurantPOS14.RPOS_DBDataSet1.PurchaseOrderDataTable = New RestaurantPOS14.RPOS_DBDataSet1.PurchaseOrderDataTable()
            Me.Adapter.Fill(purchaseOrderDataTable)
            Return purchaseOrderDataTable
        End Function

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Overridable Function Update(dataTable As RestaurantPOS14.RPOS_DBDataSet1.PurchaseOrderDataTable) As Integer
            Return Me.Adapter.Update(dataTable)
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        Public Overridable Function Update(dataSet As RestaurantPOS14.RPOS_DBDataSet1) As Integer
            Return Me.Adapter.Update(dataSet, "PurchaseOrder")
        End Function

        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
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
        Public Overridable Function Delete(Original_PO_ID As Integer, Original_PONumber As String, Original_Date As System.DateTime?, Original_Supplier_ID As Integer?, Original_SubTotal As Decimal?, Original_VATPer As Decimal?, Original_VATAmount As Decimal?, Original_GrandTotal As Decimal?, Original_TaxType As String) As Integer
            Me.Adapter.DeleteCommand.Parameters(CInt((0))).Value = Original_PO_ID
            If Equals(Original_PONumber, Nothing) Then
                Throw New System.ArgumentNullException("Original_PONumber")
            End If

            Me.Adapter.DeleteCommand.Parameters(CInt((1))).Value = Original_PONumber
            If Original_Date.HasValue Then
                Me.Adapter.DeleteCommand.Parameters(CInt((2))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((3))).Value = Original_Date.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((2))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((3))).Value = System.DBNull.Value
            End If

            If Original_Supplier_ID.HasValue Then
                Me.Adapter.DeleteCommand.Parameters(CInt((4))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((5))).Value = Original_Supplier_ID.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((4))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((5))).Value = System.DBNull.Value
            End If

            If Original_SubTotal.HasValue Then
                Me.Adapter.DeleteCommand.Parameters(CInt((6))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((7))).Value = Original_SubTotal.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((6))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((7))).Value = System.DBNull.Value
            End If

            If Original_VATPer.HasValue Then
                Me.Adapter.DeleteCommand.Parameters(CInt((8))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((9))).Value = Original_VATPer.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((8))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((9))).Value = System.DBNull.Value
            End If

            If Original_VATAmount.HasValue Then
                Me.Adapter.DeleteCommand.Parameters(CInt((10))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((11))).Value = Original_VATAmount.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((10))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((11))).Value = System.DBNull.Value
            End If

            If Original_GrandTotal.HasValue Then
                Me.Adapter.DeleteCommand.Parameters(CInt((12))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((13))).Value = Original_GrandTotal.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((12))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((13))).Value = System.DBNull.Value
            End If

            If Equals(Original_TaxType, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((14))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((15))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((14))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((15))).Value = Original_TaxType
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

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, True)>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Overridable Function Insert(PO_ID As Integer, PONumber As String, _Date As System.DateTime?, Supplier_ID As Integer?, Terms As String, SubTotal As Decimal?, VATPer As Decimal?, VATAmount As Decimal?, GrandTotal As Decimal?, TaxType As String) As Integer
            Me.Adapter.InsertCommand.Parameters(CInt((0))).Value = PO_ID
            If Equals(PONumber, Nothing) Then
                Throw New System.ArgumentNullException("PONumber")
            End If

            Me.Adapter.InsertCommand.Parameters(CInt((1))).Value = PONumber
            If _Date.HasValue Then
                Me.Adapter.InsertCommand.Parameters(CInt((2))).Value = _Date.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((2))).Value = System.DBNull.Value
            End If

            If Supplier_ID.HasValue Then
                Me.Adapter.InsertCommand.Parameters(CInt((3))).Value = Supplier_ID.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((3))).Value = System.DBNull.Value
            End If

            If Equals(Terms, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((4))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((4))).Value = Terms
            End If

            If SubTotal.HasValue Then
                Me.Adapter.InsertCommand.Parameters(CInt((5))).Value = SubTotal.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((5))).Value = System.DBNull.Value
            End If

            If VATPer.HasValue Then
                Me.Adapter.InsertCommand.Parameters(CInt((6))).Value = VATPer.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((6))).Value = System.DBNull.Value
            End If

            If VATAmount.HasValue Then
                Me.Adapter.InsertCommand.Parameters(CInt((7))).Value = VATAmount.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((7))).Value = System.DBNull.Value
            End If

            If GrandTotal.HasValue Then
                Me.Adapter.InsertCommand.Parameters(CInt((8))).Value = GrandTotal.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((8))).Value = System.DBNull.Value
            End If

            If Equals(TaxType, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((9))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((9))).Value = TaxType
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

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, True)>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Overridable Function Update(PO_ID As Integer, PONumber As String, _Date As System.DateTime?, Supplier_ID As Integer?, Terms As String, SubTotal As Decimal?, VATPer As Decimal?, VATAmount As Decimal?, GrandTotal As Decimal?, TaxType As String, Original_PO_ID As Integer, Original_PONumber As String, Original_Date As System.DateTime?, Original_Supplier_ID As Integer?, Original_SubTotal As Decimal?, Original_VATPer As Decimal?, Original_VATAmount As Decimal?, Original_GrandTotal As Decimal?, Original_TaxType As String) As Integer
            Me.Adapter.UpdateCommand.Parameters(CInt((0))).Value = PO_ID
            If Equals(PONumber, Nothing) Then
                Throw New System.ArgumentNullException("PONumber")
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((1))).Value = PONumber
            If _Date.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((2))).Value = _Date.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((2))).Value = System.DBNull.Value
            End If

            If Supplier_ID.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((3))).Value = Supplier_ID.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((3))).Value = System.DBNull.Value
            End If

            If Equals(Terms, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((4))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((4))).Value = Terms
            End If

            If SubTotal.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((5))).Value = SubTotal.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((5))).Value = System.DBNull.Value
            End If

            If VATPer.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((6))).Value = VATPer.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((6))).Value = System.DBNull.Value
            End If

            If VATAmount.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((7))).Value = VATAmount.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((7))).Value = System.DBNull.Value
            End If

            If GrandTotal.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((8))).Value = GrandTotal.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((8))).Value = System.DBNull.Value
            End If

            If Equals(TaxType, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((9))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((9))).Value = TaxType
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((10))).Value = Original_PO_ID
            If Equals(Original_PONumber, Nothing) Then
                Throw New System.ArgumentNullException("Original_PONumber")
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((11))).Value = Original_PONumber
            If Original_Date.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((12))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((13))).Value = Original_Date.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((12))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((13))).Value = System.DBNull.Value
            End If

            If Original_Supplier_ID.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((14))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((15))).Value = Original_Supplier_ID.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((14))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((15))).Value = System.DBNull.Value
            End If

            If Original_SubTotal.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((16))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((17))).Value = Original_SubTotal.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((16))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((17))).Value = System.DBNull.Value
            End If

            If Original_VATPer.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((18))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((19))).Value = Original_VATPer.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((18))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((19))).Value = System.DBNull.Value
            End If

            If Original_VATAmount.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((20))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((21))).Value = Original_VATAmount.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((20))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((21))).Value = System.DBNull.Value
            End If

            If Original_GrandTotal.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((22))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((23))).Value = Original_GrandTotal.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((22))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((23))).Value = System.DBNull.Value
            End If

            If Equals(Original_TaxType, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((24))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((25))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((24))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((25))).Value = Original_TaxType
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
        Public Overridable Function Update(PONumber As String, _Date As System.DateTime?, Supplier_ID As Integer?, Terms As String, SubTotal As Decimal?, VATPer As Decimal?, VATAmount As Decimal?, GrandTotal As Decimal?, TaxType As String, Original_PO_ID As Integer, Original_PONumber As String, Original_Date As System.DateTime?, Original_Supplier_ID As Integer?, Original_SubTotal As Decimal?, Original_VATPer As Decimal?, Original_VATAmount As Decimal?, Original_GrandTotal As Decimal?, Original_TaxType As String) As Integer
            Return Me.Update(Original_PO_ID, PONumber, _Date, Supplier_ID, Terms, SubTotal, VATPer, VATAmount, GrandTotal, TaxType, Original_PO_ID, Original_PONumber, Original_Date, Original_Supplier_ID, Original_SubTotal, Original_VATPer, Original_VATAmount, Original_GrandTotal, Original_TaxType)
        End Function
    End Class
End Namespace
