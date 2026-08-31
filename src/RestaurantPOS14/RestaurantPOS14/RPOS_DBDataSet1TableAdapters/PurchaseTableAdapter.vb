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
    <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
    <System.ComponentModel.ToolboxItemAttribute(True)>
    <System.ComponentModel.DesignerCategoryAttribute("code")>
    <System.ComponentModel.DataObjectAttribute(True)>
    <System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")>
    Public Class PurchaseTableAdapter
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
            SyncLock RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PurchaseTableAdapter.__ENCList
                If RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PurchaseTableAdapter.__ENCList.Count = RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PurchaseTableAdapter.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PurchaseTableAdapter.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PurchaseTableAdapter.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PurchaseTableAdapter.__ENCList(num) = RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PurchaseTableAdapter.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PurchaseTableAdapter.__ENCList.RemoveRange(num, RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PurchaseTableAdapter.__ENCList.Count - num)
                    RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PurchaseTableAdapter.__ENCList.Capacity = RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PurchaseTableAdapter.__ENCList.Count
                End If

                Call RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PurchaseTableAdapter.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            Call RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PurchaseTableAdapter.__ENCAddToList(Me)
            Me.ClearBeforeFill = True
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Private Sub InitAdapter()
            Me._adapter = New System.Data.SqlClient.SqlDataAdapter()
            Dim dataTableMapping As System.Data.Common.DataTableMapping = New System.Data.Common.DataTableMapping()
            dataTableMapping.SourceTable = "Table"
            dataTableMapping.DataSetTable = "Purchase"
            dataTableMapping.ColumnMappings.Add("ST_ID", "ST_ID")
            dataTableMapping.ColumnMappings.Add("InvoiceNo", "InvoiceNo")
            dataTableMapping.ColumnMappings.Add("Date", "Date")
            dataTableMapping.ColumnMappings.Add("PurchaseType", "PurchaseType")
            dataTableMapping.ColumnMappings.Add("Supplier_ID", "Supplier_ID")
            dataTableMapping.ColumnMappings.Add("SubTotal", "SubTotal")
            dataTableMapping.ColumnMappings.Add("DiscountPer", "DiscountPer")
            dataTableMapping.ColumnMappings.Add("Discount", "Discount")
            dataTableMapping.ColumnMappings.Add("PreviousDue", "PreviousDue")
            dataTableMapping.ColumnMappings.Add("FreightCharges", "FreightCharges")
            dataTableMapping.ColumnMappings.Add("OtherCharges", "OtherCharges")
            dataTableMapping.ColumnMappings.Add("Total", "Total")
            dataTableMapping.ColumnMappings.Add("RoundOff", "RoundOff")
            dataTableMapping.ColumnMappings.Add("GrandTotal", "GrandTotal")
            dataTableMapping.ColumnMappings.Add("TotalPayment", "TotalPayment")
            dataTableMapping.ColumnMappings.Add("PaymentDue", "PaymentDue")
            dataTableMapping.ColumnMappings.Add("Remarks", "Remarks")
            dataTableMapping.ColumnMappings.Add("HST", "HST")
            dataTableMapping.ColumnMappings.Add("HSTPer", "HSTPer")
            Me._adapter.TableMappings.Add(dataTableMapping)
            Me._adapter.DeleteCommand = New System.Data.SqlClient.SqlCommand()
            Me._adapter.DeleteCommand.Connection = Me.Connection
            Me._adapter.DeleteCommand.CommandText = "DELETE FROM [dbo].[Purchase] WHERE (([ST_ID] = @Original_ST_ID) AND ([InvoiceNo] = @Original_InvoiceNo) AND ([Date] = @Original_Date) AND ([PurchaseType] = @Original_PurchaseType) AND ([Supplier_ID] = @Original_Supplier_ID) AND ([SubTotal] = @Original_SubTotal) AND ([DiscountPer] = @Original_DiscountPer) AND ([Discount] = @Original_Discount) AND ([PreviousDue] = @Original_PreviousDue) AND ([FreightCharges] = @Original_FreightCharges) AND ([OtherCharges] = @Original_OtherCharges) AND ([Total] = @Original_Total) AND ([RoundOff] = @Original_RoundOff) AND ([GrandTotal] = @Original_GrandTotal) AND ([TotalPayment] = @Original_TotalPayment) AND ([PaymentDue] = @Original_PaymentDue) AND ((@IsNull_HST = 1 AND [HST] IS NULL) OR ([HST] = @Original_HST)) AND ((@IsNull_HSTPer = 1 AND [HSTPer] IS NULL) OR ([HSTPer] = @Original_HSTPer)))"
            Me._adapter.DeleteCommand.CommandType = System.Data.CommandType.Text
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ST_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "ST_ID", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_InvoiceNo", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "InvoiceNo", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Date", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, 0, 0, "Date", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PurchaseType", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "PurchaseType", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Supplier_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Supplier_ID", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SubTotal", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "SubTotal", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DiscountPer", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "DiscountPer", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Discount", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Discount", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PreviousDue", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "PreviousDue", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FreightCharges", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "FreightCharges", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_OtherCharges", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "OtherCharges", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Total", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Total", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RoundOff", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "RoundOff", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GrandTotal", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "GrandTotal", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TotalPayment", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "TotalPayment", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PaymentDue", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "PaymentDue", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_HST", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "HST", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_HST", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "HST", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_HSTPer", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "HSTPer", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_HSTPer", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "HSTPer", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand = New System.Data.SqlClient.SqlCommand()
            Me._adapter.InsertCommand.Connection = Me.Connection
            Me._adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[Purchase] ([ST_ID], [InvoiceNo], [Date], [PurchaseType], [Supplier_ID], [SubTotal], [DiscountPer], [Discount], [PreviousDue], [FreightCharges], [OtherCharges], [Total], [RoundOff], [GrandTotal], [TotalPayment], [PaymentDue], [Remarks], [HST], [HSTPer]) VALUES (@ST_ID, @InvoiceNo, @Date, @PurchaseType, @Supplier_ID, @SubTotal, @DiscountPer, @Discount, @PreviousDue, @FreightCharges, @OtherCharges, @Total, @RoundOff, @GrandTotal, @TotalPayment, @PaymentDue, @Remarks, @HST, @HSTPer);" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "SELECT ST_ID, InvoiceNo, Date, PurchaseType, Supplier_ID, SubTotal, DiscountPer, Discount, PreviousDue, FreightCharges, OtherCharges, Total, RoundOff, GrandTotal, TotalPayment, PaymentDue, Remarks, HST, HSTPer FROM Purchase WHERE (ST_ID = @ST_ID)"
            Me._adapter.InsertCommand.CommandType = System.Data.CommandType.Text
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ST_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "ST_ID", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@InvoiceNo", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "InvoiceNo", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Date", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, 0, 0, "Date", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PurchaseType", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "PurchaseType", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Supplier_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Supplier_ID", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SubTotal", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "SubTotal", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DiscountPer", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "DiscountPer", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Discount", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Discount", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PreviousDue", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "PreviousDue", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FreightCharges", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "FreightCharges", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@OtherCharges", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "OtherCharges", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Total", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Total", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RoundOff", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "RoundOff", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GrandTotal", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "GrandTotal", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TotalPayment", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "TotalPayment", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PaymentDue", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "PaymentDue", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Remarks", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Remarks", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@HST", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "HST", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@HSTPer", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "HSTPer", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand = New System.Data.SqlClient.SqlCommand()
            Me._adapter.UpdateCommand.Connection = Me.Connection
            Me._adapter.UpdateCommand.CommandText = "UPDATE [dbo].[Purchase] SET [ST_ID] = @ST_ID, [InvoiceNo] = @InvoiceNo, [Date] = @Date, [PurchaseType] = @PurchaseType, [Supplier_ID] = @Supplier_ID, [SubTotal] = @SubTotal, [DiscountPer] = @DiscountPer, [Discount] = @Discount, [PreviousDue] = @PreviousDue, [FreightCharges] = @FreightCharges, [OtherCharges] = @OtherCharges, [Total] = @Total, [RoundOff] = @RoundOff, [GrandTotal] = @GrandTotal, [TotalPayment] = @TotalPayment, [PaymentDue] = @PaymentDue, [Remarks] = @Remarks, [HST] = @HST, [HSTPer] = @HSTPer WHERE (([ST_ID] = @Original_ST_ID) AND ([InvoiceNo] = @Original_InvoiceNo) AND ([Date] = @Original_Date) AND ([PurchaseType] = @Original_PurchaseType) AND ([Supplier_ID] = @Original_Supplier_ID) AND ([SubTotal] = @Original_SubTotal) AND ([DiscountPer] = @Original_DiscountPer) AND ([Discount] = @Original_Discount) AND ([PreviousDue] = @Original_PreviousDue) AND ([FreightCharges] = @Original_FreightCharges) AND ([OtherCharges] = @Original_OtherCharges) AND ([Total] = @Original_Total) AND ([RoundOff] = @Original_RoundOff) AND ([GrandTotal] = @Original_GrandTotal) AND ([TotalPayment] = @Original_TotalPayment) AND ([PaymentDue] = @Original_PaymentDue) AND ((@IsNull_HST = 1 AND [HST] IS NULL) OR ([HST] = @Original_HST)) AND ((@IsNull_HSTPer = 1 AND [HSTPer] IS NULL) OR ([HSTPer] = @Original_HSTPer)));" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "SELECT ST_ID, InvoiceNo, Date, PurchaseType, Supplier_ID, SubTotal, DiscountPer, Discount, PreviousDue, FreightCharges, OtherCharges, Total, RoundOff, GrandTotal, TotalPayment, PaymentDue, Remarks, HST, HSTPer FROM Purchase WHERE (ST_ID = @ST_ID)"
            Me._adapter.UpdateCommand.CommandType = System.Data.CommandType.Text
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ST_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "ST_ID", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@InvoiceNo", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "InvoiceNo", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Date", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, 0, 0, "Date", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PurchaseType", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "PurchaseType", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Supplier_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Supplier_ID", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SubTotal", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "SubTotal", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DiscountPer", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "DiscountPer", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Discount", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Discount", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PreviousDue", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "PreviousDue", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FreightCharges", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "FreightCharges", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@OtherCharges", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "OtherCharges", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Total", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Total", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RoundOff", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "RoundOff", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GrandTotal", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "GrandTotal", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TotalPayment", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "TotalPayment", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PaymentDue", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "PaymentDue", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Remarks", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Remarks", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@HST", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "HST", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@HSTPer", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "HSTPer", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ST_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "ST_ID", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_InvoiceNo", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "InvoiceNo", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Date", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, 0, 0, "Date", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PurchaseType", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "PurchaseType", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Supplier_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Supplier_ID", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SubTotal", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "SubTotal", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DiscountPer", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "DiscountPer", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Discount", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Discount", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PreviousDue", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "PreviousDue", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FreightCharges", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "FreightCharges", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_OtherCharges", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "OtherCharges", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Total", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Total", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RoundOff", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "RoundOff", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GrandTotal", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "GrandTotal", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TotalPayment", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "TotalPayment", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PaymentDue", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "PaymentDue", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_HST", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "HST", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_HST", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "HST", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_HSTPer", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "HSTPer", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_HSTPer", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "HSTPer", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
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
            Me._commandCollection(CInt((0))).CommandText = "SELECT ST_ID, InvoiceNo, Date, PurchaseType, Supplier_ID, SubTotal, DiscountPer, Discount, PreviousDue, FreightCharges, OtherCharges, Total, RoundOff, GrandTotal, TotalPayment, PaymentDue, Remarks, HST, HSTPer FROM dbo.Purchase"
            Me._commandCollection(CInt((0))).CommandType = System.Data.CommandType.Text
        End Sub

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Fill, True)>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        Public Overridable Function Fill(dataTable As RestaurantPOS14.RPOS_DBDataSet1.PurchaseDataTable) As Integer
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
        Public Overridable Function GetData() As RestaurantPOS14.RPOS_DBDataSet1.PurchaseDataTable
            Me.Adapter.SelectCommand = Me.CommandCollection(0)
            Dim purchaseDataTable As RestaurantPOS14.RPOS_DBDataSet1.PurchaseDataTable = New RestaurantPOS14.RPOS_DBDataSet1.PurchaseDataTable()
            Me.Adapter.Fill(purchaseDataTable)
            Return purchaseDataTable
        End Function

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Overridable Function Update(dataTable As RestaurantPOS14.RPOS_DBDataSet1.PurchaseDataTable) As Integer
            Return Me.Adapter.Update(dataTable)
        End Function

        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Overridable Function Update(dataSet As RestaurantPOS14.RPOS_DBDataSet1) As Integer
            Return Me.Adapter.Update(dataSet, "Purchase")
        End Function

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        Public Overridable Function Update(dataRow As System.Data.DataRow) As Integer
            Return Me.Adapter.Update(New System.Data.DataRow(0) {dataRow})
        End Function

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        Public Overridable Function Update(dataRows As System.Data.DataRow()) As Integer
            Return Me.Adapter.Update(dataRows)
        End Function

        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, True)>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Overridable Function Delete(Original_ST_ID As Integer, Original_InvoiceNo As String, Original_Date As System.DateTime, Original_PurchaseType As String, Original_Supplier_ID As Integer, Original_SubTotal As Decimal, Original_DiscountPer As Decimal, Original_Discount As Decimal, Original_PreviousDue As Decimal, Original_FreightCharges As Decimal, Original_OtherCharges As Decimal, Original_Total As Decimal, Original_RoundOff As Decimal, Original_GrandTotal As Decimal, Original_TotalPayment As Decimal, Original_PaymentDue As Decimal, Original_HST As Decimal?, Original_HSTPer As Decimal?) As Integer
            Me.Adapter.DeleteCommand.Parameters(CInt((0))).Value = Original_ST_ID
            If Equals(Original_InvoiceNo, Nothing) Then
                Throw New System.ArgumentNullException("Original_InvoiceNo")
            End If

            Me.Adapter.DeleteCommand.Parameters(CInt((1))).Value = Original_InvoiceNo
            Me.Adapter.DeleteCommand.Parameters(CInt((2))).Value = Original_Date
            If Equals(Original_PurchaseType, Nothing) Then
                Throw New System.ArgumentNullException("Original_PurchaseType")
            End If

            Me.Adapter.DeleteCommand.Parameters(CInt((3))).Value = Original_PurchaseType
            Me.Adapter.DeleteCommand.Parameters(CInt((4))).Value = Original_Supplier_ID
            Me.Adapter.DeleteCommand.Parameters(CInt((5))).Value = Original_SubTotal
            Me.Adapter.DeleteCommand.Parameters(CInt((6))).Value = Original_DiscountPer
            Me.Adapter.DeleteCommand.Parameters(CInt((7))).Value = Original_Discount
            Me.Adapter.DeleteCommand.Parameters(CInt((8))).Value = Original_PreviousDue
            Me.Adapter.DeleteCommand.Parameters(CInt((9))).Value = Original_FreightCharges
            Me.Adapter.DeleteCommand.Parameters(CInt((10))).Value = Original_OtherCharges
            Me.Adapter.DeleteCommand.Parameters(CInt((11))).Value = Original_Total
            Me.Adapter.DeleteCommand.Parameters(CInt((12))).Value = Original_RoundOff
            Me.Adapter.DeleteCommand.Parameters(CInt((13))).Value = Original_GrandTotal
            Me.Adapter.DeleteCommand.Parameters(CInt((14))).Value = Original_TotalPayment
            Me.Adapter.DeleteCommand.Parameters(CInt((15))).Value = Original_PaymentDue
            If Original_HST.HasValue Then
                Me.Adapter.DeleteCommand.Parameters(CInt((16))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((17))).Value = Original_HST.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((16))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((17))).Value = System.DBNull.Value
            End If

            If Original_HSTPer.HasValue Then
                Me.Adapter.DeleteCommand.Parameters(CInt((18))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((19))).Value = Original_HSTPer.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((18))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((19))).Value = System.DBNull.Value
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
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, True)>
        Public Overridable Function Insert(ST_ID As Integer, InvoiceNo As String, _Date As System.DateTime, PurchaseType As String, Supplier_ID As Integer, SubTotal As Decimal, DiscountPer As Decimal, Discount As Decimal, PreviousDue As Decimal, FreightCharges As Decimal, OtherCharges As Decimal, Total As Decimal, RoundOff As Decimal, GrandTotal As Decimal, TotalPayment As Decimal, PaymentDue As Decimal, Remarks As String, HST As Decimal?, HSTPer As Decimal?) As Integer
            Me.Adapter.InsertCommand.Parameters(CInt((0))).Value = ST_ID
            If Equals(InvoiceNo, Nothing) Then
                Throw New System.ArgumentNullException("InvoiceNo")
            End If

            Me.Adapter.InsertCommand.Parameters(CInt((1))).Value = InvoiceNo
            Me.Adapter.InsertCommand.Parameters(CInt((2))).Value = _Date
            If Equals(PurchaseType, Nothing) Then
                Throw New System.ArgumentNullException("PurchaseType")
            End If

            Me.Adapter.InsertCommand.Parameters(CInt((3))).Value = PurchaseType
            Me.Adapter.InsertCommand.Parameters(CInt((4))).Value = Supplier_ID
            Me.Adapter.InsertCommand.Parameters(CInt((5))).Value = SubTotal
            Me.Adapter.InsertCommand.Parameters(CInt((6))).Value = DiscountPer
            Me.Adapter.InsertCommand.Parameters(CInt((7))).Value = Discount
            Me.Adapter.InsertCommand.Parameters(CInt((8))).Value = PreviousDue
            Me.Adapter.InsertCommand.Parameters(CInt((9))).Value = FreightCharges
            Me.Adapter.InsertCommand.Parameters(CInt((10))).Value = OtherCharges
            Me.Adapter.InsertCommand.Parameters(CInt((11))).Value = Total
            Me.Adapter.InsertCommand.Parameters(CInt((12))).Value = RoundOff
            Me.Adapter.InsertCommand.Parameters(CInt((13))).Value = GrandTotal
            Me.Adapter.InsertCommand.Parameters(CInt((14))).Value = TotalPayment
            Me.Adapter.InsertCommand.Parameters(CInt((15))).Value = PaymentDue
            If Equals(Remarks, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((16))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((16))).Value = Remarks
            End If

            If HST.HasValue Then
                Me.Adapter.InsertCommand.Parameters(CInt((17))).Value = HST.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((17))).Value = System.DBNull.Value
            End If

            If HSTPer.HasValue Then
                Me.Adapter.InsertCommand.Parameters(CInt((18))).Value = HSTPer.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((18))).Value = System.DBNull.Value
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
        Public Overridable Function Update(ST_ID As Integer, InvoiceNo As String, _Date As System.DateTime, PurchaseType As String, Supplier_ID As Integer, SubTotal As Decimal, DiscountPer As Decimal, Discount As Decimal, PreviousDue As Decimal, FreightCharges As Decimal, OtherCharges As Decimal, Total As Decimal, RoundOff As Decimal, GrandTotal As Decimal, TotalPayment As Decimal, PaymentDue As Decimal, Remarks As String, HST As Decimal?, HSTPer As Decimal?, Original_ST_ID As Integer, Original_InvoiceNo As String, Original_Date As System.DateTime, Original_PurchaseType As String, Original_Supplier_ID As Integer, Original_SubTotal As Decimal, Original_DiscountPer As Decimal, Original_Discount As Decimal, Original_PreviousDue As Decimal, Original_FreightCharges As Decimal, Original_OtherCharges As Decimal, Original_Total As Decimal, Original_RoundOff As Decimal, Original_GrandTotal As Decimal, Original_TotalPayment As Decimal, Original_PaymentDue As Decimal, Original_HST As Decimal?, Original_HSTPer As Decimal?) As Integer
            Me.Adapter.UpdateCommand.Parameters(CInt((0))).Value = ST_ID
            If Equals(InvoiceNo, Nothing) Then
                Throw New System.ArgumentNullException("InvoiceNo")
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((1))).Value = InvoiceNo
            Me.Adapter.UpdateCommand.Parameters(CInt((2))).Value = _Date
            If Equals(PurchaseType, Nothing) Then
                Throw New System.ArgumentNullException("PurchaseType")
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((3))).Value = PurchaseType
            Me.Adapter.UpdateCommand.Parameters(CInt((4))).Value = Supplier_ID
            Me.Adapter.UpdateCommand.Parameters(CInt((5))).Value = SubTotal
            Me.Adapter.UpdateCommand.Parameters(CInt((6))).Value = DiscountPer
            Me.Adapter.UpdateCommand.Parameters(CInt((7))).Value = Discount
            Me.Adapter.UpdateCommand.Parameters(CInt((8))).Value = PreviousDue
            Me.Adapter.UpdateCommand.Parameters(CInt((9))).Value = FreightCharges
            Me.Adapter.UpdateCommand.Parameters(CInt((10))).Value = OtherCharges
            Me.Adapter.UpdateCommand.Parameters(CInt((11))).Value = Total
            Me.Adapter.UpdateCommand.Parameters(CInt((12))).Value = RoundOff
            Me.Adapter.UpdateCommand.Parameters(CInt((13))).Value = GrandTotal
            Me.Adapter.UpdateCommand.Parameters(CInt((14))).Value = TotalPayment
            Me.Adapter.UpdateCommand.Parameters(CInt((15))).Value = PaymentDue
            If Equals(Remarks, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((16))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((16))).Value = Remarks
            End If

            If HST.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((17))).Value = HST.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((17))).Value = System.DBNull.Value
            End If

            If HSTPer.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((18))).Value = HSTPer.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((18))).Value = System.DBNull.Value
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((19))).Value = Original_ST_ID
            If Equals(Original_InvoiceNo, Nothing) Then
                Throw New System.ArgumentNullException("Original_InvoiceNo")
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((20))).Value = Original_InvoiceNo
            Me.Adapter.UpdateCommand.Parameters(CInt((21))).Value = Original_Date
            If Equals(Original_PurchaseType, Nothing) Then
                Throw New System.ArgumentNullException("Original_PurchaseType")
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((22))).Value = Original_PurchaseType
            Me.Adapter.UpdateCommand.Parameters(CInt((23))).Value = Original_Supplier_ID
            Me.Adapter.UpdateCommand.Parameters(CInt((24))).Value = Original_SubTotal
            Me.Adapter.UpdateCommand.Parameters(CInt((25))).Value = Original_DiscountPer
            Me.Adapter.UpdateCommand.Parameters(CInt((26))).Value = Original_Discount
            Me.Adapter.UpdateCommand.Parameters(CInt((27))).Value = Original_PreviousDue
            Me.Adapter.UpdateCommand.Parameters(CInt((28))).Value = Original_FreightCharges
            Me.Adapter.UpdateCommand.Parameters(CInt((29))).Value = Original_OtherCharges
            Me.Adapter.UpdateCommand.Parameters(CInt((30))).Value = Original_Total
            Me.Adapter.UpdateCommand.Parameters(CInt((31))).Value = Original_RoundOff
            Me.Adapter.UpdateCommand.Parameters(CInt((32))).Value = Original_GrandTotal
            Me.Adapter.UpdateCommand.Parameters(CInt((33))).Value = Original_TotalPayment
            Me.Adapter.UpdateCommand.Parameters(CInt((34))).Value = Original_PaymentDue
            If Original_HST.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((35))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((36))).Value = Original_HST.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((35))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((36))).Value = System.DBNull.Value
            End If

            If Original_HSTPer.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((37))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((38))).Value = Original_HSTPer.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((37))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((38))).Value = System.DBNull.Value
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

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, True)>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        Public Overridable Function Update(InvoiceNo As String, _Date As System.DateTime, PurchaseType As String, Supplier_ID As Integer, SubTotal As Decimal, DiscountPer As Decimal, Discount As Decimal, PreviousDue As Decimal, FreightCharges As Decimal, OtherCharges As Decimal, Total As Decimal, RoundOff As Decimal, GrandTotal As Decimal, TotalPayment As Decimal, PaymentDue As Decimal, Remarks As String, HST As Decimal?, HSTPer As Decimal?, Original_ST_ID As Integer, Original_InvoiceNo As String, Original_Date As System.DateTime, Original_PurchaseType As String, Original_Supplier_ID As Integer, Original_SubTotal As Decimal, Original_DiscountPer As Decimal, Original_Discount As Decimal, Original_PreviousDue As Decimal, Original_FreightCharges As Decimal, Original_OtherCharges As Decimal, Original_Total As Decimal, Original_RoundOff As Decimal, Original_GrandTotal As Decimal, Original_TotalPayment As Decimal, Original_PaymentDue As Decimal, Original_HST As Decimal?, Original_HSTPer As Decimal?) As Integer
            Return Me.Update(Original_ST_ID, InvoiceNo, _Date, PurchaseType, Supplier_ID, SubTotal, DiscountPer, Discount, PreviousDue, FreightCharges, OtherCharges, Total, RoundOff, GrandTotal, TotalPayment, PaymentDue, Remarks, HST, HSTPer, Original_ST_ID, Original_InvoiceNo, Original_Date, Original_PurchaseType, Original_Supplier_ID, Original_SubTotal, Original_DiscountPer, Original_Discount, Original_PreviousDue, Original_FreightCharges, Original_OtherCharges, Original_Total, Original_RoundOff, Original_GrandTotal, Original_TotalPayment, Original_PaymentDue, Original_HST, Original_HSTPer)
        End Function
    End Class
End Namespace
