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
    <System.ComponentModel.DesignerCategoryAttribute("code")>
    <System.ComponentModel.DataObjectAttribute(True)>
    <System.ComponentModel.ToolboxItemAttribute(True)>
    <System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")>
    Public Class TempRestaurantPOS_BillingInfoKOTTableAdapter
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
            SyncLock RestaurantPOS14.RPOS_DBDataSet1TableAdapters.TempRestaurantPOS_BillingInfoKOTTableAdapter.__ENCList
                If RestaurantPOS14.RPOS_DBDataSet1TableAdapters.TempRestaurantPOS_BillingInfoKOTTableAdapter.__ENCList.Count = RestaurantPOS14.RPOS_DBDataSet1TableAdapters.TempRestaurantPOS_BillingInfoKOTTableAdapter.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.RPOS_DBDataSet1TableAdapters.TempRestaurantPOS_BillingInfoKOTTableAdapter.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.RPOS_DBDataSet1TableAdapters.TempRestaurantPOS_BillingInfoKOTTableAdapter.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.RPOS_DBDataSet1TableAdapters.TempRestaurantPOS_BillingInfoKOTTableAdapter.__ENCList(num) = RestaurantPOS14.RPOS_DBDataSet1TableAdapters.TempRestaurantPOS_BillingInfoKOTTableAdapter.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.RPOS_DBDataSet1TableAdapters.TempRestaurantPOS_BillingInfoKOTTableAdapter.__ENCList.RemoveRange(num, RestaurantPOS14.RPOS_DBDataSet1TableAdapters.TempRestaurantPOS_BillingInfoKOTTableAdapter.__ENCList.Count - num)
                    RestaurantPOS14.RPOS_DBDataSet1TableAdapters.TempRestaurantPOS_BillingInfoKOTTableAdapter.__ENCList.Capacity = RestaurantPOS14.RPOS_DBDataSet1TableAdapters.TempRestaurantPOS_BillingInfoKOTTableAdapter.__ENCList.Count
                End If

                Call RestaurantPOS14.RPOS_DBDataSet1TableAdapters.TempRestaurantPOS_BillingInfoKOTTableAdapter.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            Call RestaurantPOS14.RPOS_DBDataSet1TableAdapters.TempRestaurantPOS_BillingInfoKOTTableAdapter.__ENCAddToList(Me)
            Me.ClearBeforeFill = True
        End Sub

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Sub InitAdapter()
            Me._adapter = New System.Data.SqlClient.SqlDataAdapter()
            Dim dataTableMapping As System.Data.Common.DataTableMapping = New System.Data.Common.DataTableMapping()
            dataTableMapping.SourceTable = "Table"
            dataTableMapping.DataSetTable = "TempRestaurantPOS_BillingInfoKOT"
            dataTableMapping.ColumnMappings.Add("Id", "Id")
            dataTableMapping.ColumnMappings.Add("BillNo", "BillNo")
            dataTableMapping.ColumnMappings.Add("BillDate", "BillDate")
            dataTableMapping.ColumnMappings.Add("ODN", "ODN")
            dataTableMapping.ColumnMappings.Add("KOTDiscountPer", "KOTDiscountPer")
            dataTableMapping.ColumnMappings.Add("KOTDiscountAmt", "KOTDiscountAmt")
            dataTableMapping.ColumnMappings.Add("GrandTotal", "GrandTotal")
            dataTableMapping.ColumnMappings.Add("Cash", "Cash")
            dataTableMapping.ColumnMappings.Add("Change", "Change")
            dataTableMapping.ColumnMappings.Add("Operator", "Operator")
            dataTableMapping.ColumnMappings.Add("PaymentMode", "PaymentMode")
            dataTableMapping.ColumnMappings.Add("ExchangeRate", "ExchangeRate")
            dataTableMapping.ColumnMappings.Add("CurrencyCode", "CurrencyCode")
            dataTableMapping.ColumnMappings.Add("Member_ID", "Member_ID")
            dataTableMapping.ColumnMappings.Add("Waiter", "Waiter")
            dataTableMapping.ColumnMappings.Add("GiftCardID", "GiftCardID")
            dataTableMapping.ColumnMappings.Add("GiftCardAmount", "GiftCardAmount")
            dataTableMapping.ColumnMappings.Add("LP", "LP")
            dataTableMapping.ColumnMappings.Add("LA", "LA")
            dataTableMapping.ColumnMappings.Add("CustomerName", "CustomerName")
            dataTableMapping.ColumnMappings.Add("PhoneNo", "PhoneNo")
            dataTableMapping.ColumnMappings.Add("EmailID", "EmailID")
            dataTableMapping.ColumnMappings.Add("TaxType", "TaxType")
            dataTableMapping.ColumnMappings.Add("Card", "Card")
            dataTableMapping.ColumnMappings.Add("QRCode", "QRCode")
            Me._adapter.TableMappings.Add(dataTableMapping)
            Me._adapter.DeleteCommand = New System.Data.SqlClient.SqlCommand()
            Me._adapter.DeleteCommand.Connection = Me.Connection
            Me._adapter.DeleteCommand.CommandText = "DELETE FROM [dbo].[TempRestaurantPOS_BillingInfoKOT] WHERE (([Id] = @Original_Id) AND ((@IsNull_BillNo = 1 AND [BillNo] IS NULL) OR ([BillNo] = @Original_BillNo)) AND ((@IsNull_BillDate = 1 AND [BillDate] IS NULL) OR ([BillDate] = @Original_BillDate)) AND ((@IsNull_ODN = 1 AND [ODN] IS NULL) OR ([ODN] = @Original_ODN)) AND ((@IsNull_KOTDiscountPer = 1 AND [KOTDiscountPer] IS NULL) OR ([KOTDiscountPer] = @Original_KOTDiscountPer)) AND ((@IsNull_KOTDiscountAmt = 1 AND [KOTDiscountAmt] IS NULL) OR ([KOTDiscountAmt] = @Original_KOTDiscountAmt)) AND ((@IsNull_GrandTotal = 1 AND [GrandTotal] IS NULL) OR ([GrandTotal] = @Original_GrandTotal)) AND ((@IsNull_Cash = 1 AND [Cash] IS NULL) OR ([Cash] = @Original_Cash)) AND ((@IsNull_Change = 1 AND [Change] IS NULL) OR ([Change] = @Original_Change)) AND ((@IsNull_Operator = 1 AND [Operator] IS NULL) OR ([Operator] = @Original_Operator)) AND ((@IsNull_PaymentMode = 1 AND [PaymentMode] IS NULL) OR ([PaymentMode] = @Original_PaymentMode)) AND ((@IsNull_ExchangeRate = 1 AND [ExchangeRate] IS NULL) OR ([ExchangeRate] = @Original_ExchangeRate)) AND ((@IsNull_CurrencyCode = 1 AND [CurrencyCode] IS NULL) OR ([CurrencyCode] = @Original_CurrencyCode)) AND ((@IsNull_Member_ID = 1 AND [Member_ID] IS NULL) OR ([Member_ID] = @Original_Member_ID)) AND ((@IsNull_Waiter = 1 AND [Waiter] IS NULL) OR ([Waiter] = @Original_Waiter)) AND ((@IsNull_GiftCardID = 1 AND [GiftCardID] IS NULL) OR ([GiftCardID] = @Original_GiftCardID)) AND ((@IsNull_GiftCardAmount = 1 AND [GiftCardAmount] IS NULL) OR ([GiftCardAmount] = @Original_GiftCardAmount)) AND ((@IsNull_LP = 1 AND [LP] IS NULL) OR ([LP] = @Original_LP)) AND ((@IsNull_LA = 1 AND [LA] IS NULL) OR ([LA] = @Original_LA)) AND ((@IsNull_CustomerName = 1 AND [CustomerName] IS NULL) OR ([CustomerName] = @Original_CustomerName)) AND ((@IsNull_PhoneNo = 1 AND [PhoneNo] IS NULL) OR ([PhoneNo] = @Original_PhoneNo)) AND ((@IsNull_EmailID = 1 AND [EmailID] IS NULL) OR ([EmailID] = @Original_EmailID)) AND ((@IsNull_TaxType = 1 AND [TaxType] IS NULL) OR ([TaxType] = @Original_TaxType)) AND ((@IsNull_Card = 1 AND [Card] IS NULL) OR ([Card] = @Original_Card)))"
            Me._adapter.DeleteCommand.CommandType = System.Data.CommandType.Text
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Id", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_BillNo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "BillNo", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_BillNo", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "BillNo", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_BillDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "BillDate", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_BillDate", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, 0, 0, "BillDate", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_ODN", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "ODN", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ODN", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "ODN", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_KOTDiscountPer", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "KOTDiscountPer", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_KOTDiscountPer", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 4, "KOTDiscountPer", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_KOTDiscountAmt", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "KOTDiscountAmt", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_KOTDiscountAmt", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "KOTDiscountAmt", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_GrandTotal", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "GrandTotal", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GrandTotal", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "GrandTotal", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Cash", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Cash", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cash", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Cash", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Change", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Change", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Change", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Change", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Operator", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Operator", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Operator", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Operator", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_PaymentMode", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "PaymentMode", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PaymentMode", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "PaymentMode", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_ExchangeRate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "ExchangeRate", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ExchangeRate", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "ExchangeRate", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_CurrencyCode", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "CurrencyCode", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CurrencyCode", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "CurrencyCode", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Member_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Member_ID", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Member_ID", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Member_ID", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Waiter", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Waiter", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Waiter", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Waiter", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_GiftCardID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "GiftCardID", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GiftCardID", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "GiftCardID", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_GiftCardAmount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "GiftCardAmount", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GiftCardAmount", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "GiftCardAmount", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_LP", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "LP", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_LP", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "LP", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_LA", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "LA", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_LA", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "LA", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_CustomerName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "CustomerName", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CustomerName", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "CustomerName", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_PhoneNo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "PhoneNo", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PhoneNo", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "PhoneNo", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_EmailID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "EmailID", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_EmailID", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "EmailID", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_TaxType", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "TaxType", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TaxType", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "TaxType", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Card", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Card", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Card", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Card", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand = New System.Data.SqlClient.SqlCommand()
            Me._adapter.InsertCommand.Connection = Me.Connection
            Me._adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[TempRestaurantPOS_BillingInfoKOT] ([Id], [BillNo], [BillDate], [ODN], [KOTDiscountPer], [KOTDiscountAmt], [GrandTotal], [Cash], [Change], [Operator], [PaymentMode], [ExchangeRate], [CurrencyCode], [Member_ID], [Waiter], [GiftCardID], [GiftCardAmount], [LP], [LA], [CustomerName], [PhoneNo], [EmailID], [TaxType], [Card], [QRCode]) VALUES (@Id, @BillNo, @BillDate, @ODN, @KOTDiscountPer, @KOTDiscountAmt, @GrandTotal, @Cash, @Change, @Operator, @PaymentMode, @ExchangeRate, @CurrencyCode, @Member_ID, @Waiter, @GiftCardID, @GiftCardAmount, @LP, @LA, @CustomerName, @PhoneNo, @EmailID, @TaxType, @Card, @QRCode);" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "SELECT Id, BillNo, BillDate, ODN, KOTDiscountPer, KOTDiscountAmt, GrandTotal, Cash, Change, Operator, PaymentMode, ExchangeRate, CurrencyCode, Member_ID, Waiter, GiftCardID, GiftCardAmount, LP, LA, CustomerName, PhoneNo, EmailID, TaxType, Card, QRCode FROM TempRestaurantPOS_BillingInfoKOT WHERE (Id = @Id)"
            Me._adapter.InsertCommand.CommandType = System.Data.CommandType.Text
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Id", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@BillNo", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "BillNo", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@BillDate", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, 0, 0, "BillDate", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ODN", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "ODN", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@KOTDiscountPer", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 4, "KOTDiscountPer", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@KOTDiscountAmt", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "KOTDiscountAmt", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GrandTotal", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "GrandTotal", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cash", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Cash", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Change", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Change", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Operator", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Operator", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PaymentMode", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "PaymentMode", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ExchangeRate", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "ExchangeRate", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CurrencyCode", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "CurrencyCode", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Member_ID", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Member_ID", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Waiter", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Waiter", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GiftCardID", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "GiftCardID", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GiftCardAmount", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "GiftCardAmount", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@LP", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "LP", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@LA", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "LA", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CustomerName", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "CustomerName", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PhoneNo", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "PhoneNo", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@EmailID", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "EmailID", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TaxType", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "TaxType", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Card", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Card", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@QRCode", System.Data.SqlDbType.Image, 0, System.Data.ParameterDirection.Input, 0, 0, "QRCode", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand = New System.Data.SqlClient.SqlCommand()
            Me._adapter.UpdateCommand.Connection = Me.Connection
            Me._adapter.UpdateCommand.CommandText = "UPDATE [dbo].[TempRestaurantPOS_BillingInfoKOT] SET [Id] = @Id, [BillNo] = @BillNo, [BillDate] = @BillDate, [ODN] = @ODN, [KOTDiscountPer] = @KOTDiscountPer, [KOTDiscountAmt] = @KOTDiscountAmt, [GrandTotal] = @GrandTotal, [Cash] = @Cash, [Change] = @Change, [Operator] = @Operator, [PaymentMode] = @PaymentMode, [ExchangeRate] = @ExchangeRate, [CurrencyCode] = @CurrencyCode, [Member_ID] = @Member_ID, [Waiter] = @Waiter, [GiftCardID] = @GiftCardID, [GiftCardAmount] = @GiftCardAmount, [LP] = @LP, [LA] = @LA, [CustomerName] = @CustomerName, [PhoneNo] = @PhoneNo, [EmailID] = @EmailID, [TaxType] = @TaxType, [Card] = @Card, [QRCode] = @QRCode WHERE (([Id] = @Original_Id) AND ((@IsNull_BillNo = 1 AND [BillNo] IS NULL) OR ([BillNo] = @Original_BillNo)) AND ((@IsNull_BillDate = 1 AND [BillDate] IS NULL) OR ([BillDate] = @Original_BillDate)) AND ((@IsNull_ODN = 1 AND [ODN] IS NULL) OR ([ODN] = @Original_ODN)) AND ((@IsNull_KOTDiscountPer = 1 AND [KOTDiscountPer] IS NULL) OR ([KOTDiscountPer] = @Original_KOTDiscountPer)) AND ((@IsNull_KOTDiscountAmt = 1 AND [KOTDiscountAmt] IS NULL) OR ([KOTDiscountAmt] = @Original_KOTDiscountAmt)) AND ((@IsNull_GrandTotal = 1 AND [GrandTotal] IS NULL) OR ([GrandTotal] = @Original_GrandTotal)) AND ((@IsNull_Cash = 1 AND [Cash] IS NULL) OR ([Cash] = @Original_Cash)) AND ((@IsNull_Change = 1 AND [Change] IS NULL) OR ([Change] = @Original_Change)) AND ((@IsNull_Operator = 1 AND [Operator] IS NULL) OR ([Operator] = @Original_Operator)) AND ((@IsNull_PaymentMode = 1 AND [PaymentMode] IS NULL) OR ([PaymentMode] = @Original_PaymentMode)) AND ((@IsNull_ExchangeRate = 1 AND [ExchangeRate] IS NULL) OR ([ExchangeRate] = @Original_ExchangeRate)) AND ((@IsNull_CurrencyCode = 1 AND [CurrencyCode] IS NULL) OR ([CurrencyCode] = @Original_CurrencyCode)) AND ((@IsNull_Member_ID = 1 AND [Member_ID] IS NULL) OR ([Member_ID] = @Original_Member_ID)) AND ((@IsNull_Waiter = 1 AND [Waiter] IS NULL) OR ([Waiter] = @Original_Waiter)) AND ((@IsNull_GiftCardID = 1 AND [GiftCardID] IS NULL) OR ([GiftCardID] = @Original_GiftCardID)) AND ((@IsNull_GiftCardAmount = 1 AND [GiftCardAmount] IS NULL) OR ([GiftCardAmount] = @Original_GiftCardAmount)) AND ((@IsNull_LP = 1 AND [LP] IS NULL) OR ([LP] = @Original_LP)) AND ((@IsNull_LA = 1 AND [LA] IS NULL) OR ([LA] = @Original_LA)) AND ((@IsNull_CustomerName = 1 AND [CustomerName] IS NULL) OR ([CustomerName] = @Original_CustomerName)) AND ((@IsNull_PhoneNo = 1 AND [PhoneNo] IS NULL) OR ([PhoneNo] = @Original_PhoneNo)) AND ((@IsNull_EmailID = 1 AND [EmailID] IS NULL) OR ([EmailID] = @Original_EmailID)) AND ((@IsNull_TaxType = 1 AND [TaxType] IS NULL) OR ([TaxType] = @Original_TaxType)) AND ((@IsNull_Card = 1 AND [Card] IS NULL) OR ([Card] = @Original_Card)));" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "SELECT Id, BillNo, BillDate, ODN, KOTDiscountPer, KOTDiscountAmt, GrandTotal, Cash, Change, Operator, PaymentMode, ExchangeRate, CurrencyCode, Member_ID, Waiter, GiftCardID, GiftCardAmount, LP, LA, CustomerName, PhoneNo, EmailID, TaxType, Card, QRCode FROM TempRestaurantPOS_BillingInfoKOT WHERE (Id = @Id)"
            Me._adapter.UpdateCommand.CommandType = System.Data.CommandType.Text
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Id", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@BillNo", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "BillNo", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@BillDate", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, 0, 0, "BillDate", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ODN", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "ODN", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@KOTDiscountPer", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 4, "KOTDiscountPer", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@KOTDiscountAmt", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "KOTDiscountAmt", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GrandTotal", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "GrandTotal", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cash", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Cash", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Change", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Change", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Operator", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Operator", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PaymentMode", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "PaymentMode", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ExchangeRate", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "ExchangeRate", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CurrencyCode", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "CurrencyCode", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Member_ID", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Member_ID", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Waiter", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Waiter", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GiftCardID", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "GiftCardID", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GiftCardAmount", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "GiftCardAmount", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@LP", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "LP", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@LA", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "LA", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CustomerName", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "CustomerName", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PhoneNo", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "PhoneNo", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@EmailID", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "EmailID", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TaxType", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "TaxType", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Card", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Card", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@QRCode", System.Data.SqlDbType.Image, 0, System.Data.ParameterDirection.Input, 0, 0, "QRCode", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Id", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_BillNo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "BillNo", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_BillNo", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "BillNo", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_BillDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "BillDate", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_BillDate", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, 0, 0, "BillDate", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_ODN", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "ODN", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ODN", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "ODN", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_KOTDiscountPer", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "KOTDiscountPer", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_KOTDiscountPer", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 4, "KOTDiscountPer", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_KOTDiscountAmt", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "KOTDiscountAmt", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_KOTDiscountAmt", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "KOTDiscountAmt", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_GrandTotal", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "GrandTotal", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GrandTotal", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "GrandTotal", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Cash", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Cash", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cash", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Cash", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Change", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Change", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Change", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Change", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Operator", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Operator", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Operator", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Operator", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_PaymentMode", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "PaymentMode", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PaymentMode", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "PaymentMode", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_ExchangeRate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "ExchangeRate", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ExchangeRate", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "ExchangeRate", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_CurrencyCode", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "CurrencyCode", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CurrencyCode", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "CurrencyCode", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Member_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Member_ID", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Member_ID", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Member_ID", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Waiter", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Waiter", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Waiter", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Waiter", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_GiftCardID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "GiftCardID", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GiftCardID", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "GiftCardID", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_GiftCardAmount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "GiftCardAmount", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GiftCardAmount", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "GiftCardAmount", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_LP", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "LP", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_LP", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "LP", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_LA", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "LA", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_LA", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "LA", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_CustomerName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "CustomerName", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CustomerName", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "CustomerName", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_PhoneNo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "PhoneNo", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PhoneNo", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "PhoneNo", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_EmailID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "EmailID", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_EmailID", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "EmailID", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_TaxType", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "TaxType", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TaxType", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "TaxType", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Card", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Card", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Card", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Card", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
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
            Me._commandCollection(CInt((0))).CommandText = "SELECT Id, BillNo, BillDate, ODN, KOTDiscountPer, KOTDiscountAmt, GrandTotal, Cash, Change, Operator, PaymentMode, ExchangeRate, CurrencyCode, Member_ID, Waiter, GiftCardID, GiftCardAmount, LP, LA, CustomerName, PhoneNo, EmailID, TaxType, Card, QRCode FROM dbo.TempRestaurantPOS_BillingInfoKOT"
            Me._commandCollection(CInt((0))).CommandType = System.Data.CommandType.Text
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Fill, True)>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Overridable Function Fill(dataTable As RestaurantPOS14.RPOS_DBDataSet1.TempRestaurantPOS_BillingInfoKOTDataTable) As Integer
            Me.Adapter.SelectCommand = Me.CommandCollection(0)
            If Me.ClearBeforeFill Then
                dataTable.Clear()
            End If

            Return Me.Adapter.Fill(dataTable)
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.[Select], True)>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        Public Overridable Function GetData() As RestaurantPOS14.RPOS_DBDataSet1.TempRestaurantPOS_BillingInfoKOTDataTable
            Me.Adapter.SelectCommand = Me.CommandCollection(0)
            Dim tempRestaurantPOS_BillingInfoKOTDataTable As RestaurantPOS14.RPOS_DBDataSet1.TempRestaurantPOS_BillingInfoKOTDataTable = New RestaurantPOS14.RPOS_DBDataSet1.TempRestaurantPOS_BillingInfoKOTDataTable()
            Me.Adapter.Fill(tempRestaurantPOS_BillingInfoKOTDataTable)
            Return tempRestaurantPOS_BillingInfoKOTDataTable
        End Function

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Overridable Function Update(dataTable As RestaurantPOS14.RPOS_DBDataSet1.TempRestaurantPOS_BillingInfoKOTDataTable) As Integer
            Return Me.Adapter.Update(dataTable)
        End Function

        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Overridable Function Update(dataSet As RestaurantPOS14.RPOS_DBDataSet1) As Integer
            Return Me.Adapter.Update(dataSet, "TempRestaurantPOS_BillingInfoKOT")
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Overridable Function Update(dataRow As System.Data.DataRow) As Integer
            Return Me.Adapter.Update(New System.Data.DataRow(0) {dataRow})
        End Function

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        Public Overridable Function Update(dataRows As System.Data.DataRow()) As Integer
            Return Me.Adapter.Update(dataRows)
        End Function

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, True)>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        Public Overridable Function Delete(Original_Id As Integer, Original_BillNo As String, Original_BillDate As System.DateTime?, Original_ODN As String, Original_KOTDiscountPer As Decimal?, Original_KOTDiscountAmt As Decimal?, Original_GrandTotal As Decimal?, Original_Cash As Decimal?, Original_Change As Decimal?, Original_Operator As String, Original_PaymentMode As String, Original_ExchangeRate As Decimal?, Original_CurrencyCode As String, Original_Member_ID As String, Original_Waiter As String, Original_GiftCardID As String, Original_GiftCardAmount As Decimal?, Original_LP As Integer?, Original_LA As Decimal?, Original_CustomerName As String, Original_PhoneNo As String, Original_EmailID As String, Original_TaxType As String, Original_Card As Decimal?) As Integer
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

            If Equals(Original_ODN, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((5))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((6))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((5))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((6))).Value = Original_ODN
            End If

            If Original_KOTDiscountPer.HasValue Then
                Me.Adapter.DeleteCommand.Parameters(CInt((7))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((8))).Value = Original_KOTDiscountPer.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((7))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((8))).Value = System.DBNull.Value
            End If

            If Original_KOTDiscountAmt.HasValue Then
                Me.Adapter.DeleteCommand.Parameters(CInt((9))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((10))).Value = Original_KOTDiscountAmt.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((9))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((10))).Value = System.DBNull.Value
            End If

            If Original_GrandTotal.HasValue Then
                Me.Adapter.DeleteCommand.Parameters(CInt((11))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((12))).Value = Original_GrandTotal.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((11))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((12))).Value = System.DBNull.Value
            End If

            If Original_Cash.HasValue Then
                Me.Adapter.DeleteCommand.Parameters(CInt((13))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((14))).Value = Original_Cash.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((13))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((14))).Value = System.DBNull.Value
            End If

            If Original_Change.HasValue Then
                Me.Adapter.DeleteCommand.Parameters(CInt((15))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((16))).Value = Original_Change.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((15))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((16))).Value = System.DBNull.Value
            End If

            If Equals(Original_Operator, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((17))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((18))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((17))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((18))).Value = Original_Operator
            End If

            If Equals(Original_PaymentMode, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((19))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((20))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((19))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((20))).Value = Original_PaymentMode
            End If

            If Original_ExchangeRate.HasValue Then
                Me.Adapter.DeleteCommand.Parameters(CInt((21))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((22))).Value = Original_ExchangeRate.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((21))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((22))).Value = System.DBNull.Value
            End If

            If Equals(Original_CurrencyCode, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((23))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((24))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((23))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((24))).Value = Original_CurrencyCode
            End If

            If Equals(Original_Member_ID, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((25))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((26))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((25))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((26))).Value = Original_Member_ID
            End If

            If Equals(Original_Waiter, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((27))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((28))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((27))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((28))).Value = Original_Waiter
            End If

            If Equals(Original_GiftCardID, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((29))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((30))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((29))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((30))).Value = Original_GiftCardID
            End If

            If Original_GiftCardAmount.HasValue Then
                Me.Adapter.DeleteCommand.Parameters(CInt((31))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((32))).Value = Original_GiftCardAmount.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((31))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((32))).Value = System.DBNull.Value
            End If

            If Original_LP.HasValue Then
                Me.Adapter.DeleteCommand.Parameters(CInt((33))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((34))).Value = Original_LP.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((33))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((34))).Value = System.DBNull.Value
            End If

            If Original_LA.HasValue Then
                Me.Adapter.DeleteCommand.Parameters(CInt((35))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((36))).Value = Original_LA.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((35))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((36))).Value = System.DBNull.Value
            End If

            If Equals(Original_CustomerName, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((37))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((38))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((37))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((38))).Value = Original_CustomerName
            End If

            If Equals(Original_PhoneNo, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((39))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((40))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((39))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((40))).Value = Original_PhoneNo
            End If

            If Equals(Original_EmailID, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((41))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((42))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((41))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((42))).Value = Original_EmailID
            End If

            If Equals(Original_TaxType, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((43))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((44))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((43))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((44))).Value = Original_TaxType
            End If

            If Original_Card.HasValue Then
                Me.Adapter.DeleteCommand.Parameters(CInt((45))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((46))).Value = Original_Card.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((45))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((46))).Value = System.DBNull.Value
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
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Overridable Function Insert(Id As Integer, BillNo As String, BillDate As System.DateTime?, ODN As String, KOTDiscountPer As Decimal?, KOTDiscountAmt As Decimal?, GrandTotal As Decimal?, Cash As Decimal?, Change As Decimal?, _Operator As String, PaymentMode As String, ExchangeRate As Decimal?, CurrencyCode As String, Member_ID As String, Waiter As String, GiftCardID As String, GiftCardAmount As Decimal?, LP As Integer?, LA As Decimal?, CustomerName As String, PhoneNo As String, EmailID As String, TaxType As String, Card As Decimal?, QRCode As Byte()) As Integer
            Me.Adapter.InsertCommand.Parameters(CInt((0))).Value = Id
            If Equals(BillNo, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((1))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((1))).Value = BillNo
            End If

            If BillDate.HasValue Then
                Me.Adapter.InsertCommand.Parameters(CInt((2))).Value = BillDate.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((2))).Value = System.DBNull.Value
            End If

            If Equals(ODN, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((3))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((3))).Value = ODN
            End If

            If KOTDiscountPer.HasValue Then
                Me.Adapter.InsertCommand.Parameters(CInt((4))).Value = KOTDiscountPer.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((4))).Value = System.DBNull.Value
            End If

            If KOTDiscountAmt.HasValue Then
                Me.Adapter.InsertCommand.Parameters(CInt((5))).Value = KOTDiscountAmt.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((5))).Value = System.DBNull.Value
            End If

            If GrandTotal.HasValue Then
                Me.Adapter.InsertCommand.Parameters(CInt((6))).Value = GrandTotal.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((6))).Value = System.DBNull.Value
            End If

            If Cash.HasValue Then
                Me.Adapter.InsertCommand.Parameters(CInt((7))).Value = Cash.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((7))).Value = System.DBNull.Value
            End If

            If Change.HasValue Then
                Me.Adapter.InsertCommand.Parameters(CInt((8))).Value = Change.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((8))).Value = System.DBNull.Value
            End If

            If Equals(_Operator, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((9))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((9))).Value = _Operator
            End If

            If Equals(PaymentMode, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((10))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((10))).Value = PaymentMode
            End If

            If ExchangeRate.HasValue Then
                Me.Adapter.InsertCommand.Parameters(CInt((11))).Value = ExchangeRate.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((11))).Value = System.DBNull.Value
            End If

            If Equals(CurrencyCode, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((12))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((12))).Value = CurrencyCode
            End If

            If Equals(Member_ID, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((13))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((13))).Value = Member_ID
            End If

            If Equals(Waiter, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((14))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((14))).Value = Waiter
            End If

            If Equals(GiftCardID, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((15))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((15))).Value = GiftCardID
            End If

            If GiftCardAmount.HasValue Then
                Me.Adapter.InsertCommand.Parameters(CInt((16))).Value = GiftCardAmount.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((16))).Value = System.DBNull.Value
            End If

            If LP.HasValue Then
                Me.Adapter.InsertCommand.Parameters(CInt((17))).Value = LP.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((17))).Value = System.DBNull.Value
            End If

            If LA.HasValue Then
                Me.Adapter.InsertCommand.Parameters(CInt((18))).Value = LA.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((18))).Value = System.DBNull.Value
            End If

            If Equals(CustomerName, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((19))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((19))).Value = CustomerName
            End If

            If Equals(PhoneNo, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((20))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((20))).Value = PhoneNo
            End If

            If Equals(EmailID, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((21))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((21))).Value = EmailID
            End If

            If Equals(TaxType, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((22))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((22))).Value = TaxType
            End If

            If Card.HasValue Then
                Me.Adapter.InsertCommand.Parameters(CInt((23))).Value = Card.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((23))).Value = System.DBNull.Value
            End If

            If QRCode Is Nothing Then
                Me.Adapter.InsertCommand.Parameters(CInt((24))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((24))).Value = QRCode
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
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, True)>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Overridable Function Update(Id As Integer, BillNo As String, BillDate As System.DateTime?, ODN As String, KOTDiscountPer As Decimal?, KOTDiscountAmt As Decimal?, GrandTotal As Decimal?, Cash As Decimal?, Change As Decimal?, _Operator As String, PaymentMode As String, ExchangeRate As Decimal?, CurrencyCode As String, Member_ID As String, Waiter As String, GiftCardID As String, GiftCardAmount As Decimal?, LP As Integer?, LA As Decimal?, CustomerName As String, PhoneNo As String, EmailID As String, TaxType As String, Card As Decimal?, QRCode As Byte(), Original_Id As Integer, Original_BillNo As String, Original_BillDate As System.DateTime?, Original_ODN As String, Original_KOTDiscountPer As Decimal?, Original_KOTDiscountAmt As Decimal?, Original_GrandTotal As Decimal?, Original_Cash As Decimal?, Original_Change As Decimal?, Original_Operator As String, Original_PaymentMode As String, Original_ExchangeRate As Decimal?, Original_CurrencyCode As String, Original_Member_ID As String, Original_Waiter As String, Original_GiftCardID As String, Original_GiftCardAmount As Decimal?, Original_LP As Integer?, Original_LA As Decimal?, Original_CustomerName As String, Original_PhoneNo As String, Original_EmailID As String, Original_TaxType As String, Original_Card As Decimal?) As Integer
            Me.Adapter.UpdateCommand.Parameters(CInt((0))).Value = Id
            If Equals(BillNo, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((1))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((1))).Value = BillNo
            End If

            If BillDate.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((2))).Value = BillDate.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((2))).Value = System.DBNull.Value
            End If

            If Equals(ODN, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((3))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((3))).Value = ODN
            End If

            If KOTDiscountPer.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((4))).Value = KOTDiscountPer.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((4))).Value = System.DBNull.Value
            End If

            If KOTDiscountAmt.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((5))).Value = KOTDiscountAmt.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((5))).Value = System.DBNull.Value
            End If

            If GrandTotal.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((6))).Value = GrandTotal.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((6))).Value = System.DBNull.Value
            End If

            If Cash.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((7))).Value = Cash.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((7))).Value = System.DBNull.Value
            End If

            If Change.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((8))).Value = Change.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((8))).Value = System.DBNull.Value
            End If

            If Equals(_Operator, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((9))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((9))).Value = _Operator
            End If

            If Equals(PaymentMode, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((10))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((10))).Value = PaymentMode
            End If

            If ExchangeRate.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((11))).Value = ExchangeRate.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((11))).Value = System.DBNull.Value
            End If

            If Equals(CurrencyCode, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((12))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((12))).Value = CurrencyCode
            End If

            If Equals(Member_ID, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((13))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((13))).Value = Member_ID
            End If

            If Equals(Waiter, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((14))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((14))).Value = Waiter
            End If

            If Equals(GiftCardID, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((15))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((15))).Value = GiftCardID
            End If

            If GiftCardAmount.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((16))).Value = GiftCardAmount.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((16))).Value = System.DBNull.Value
            End If

            If LP.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((17))).Value = LP.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((17))).Value = System.DBNull.Value
            End If

            If LA.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((18))).Value = LA.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((18))).Value = System.DBNull.Value
            End If

            If Equals(CustomerName, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((19))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((19))).Value = CustomerName
            End If

            If Equals(PhoneNo, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((20))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((20))).Value = PhoneNo
            End If

            If Equals(EmailID, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((21))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((21))).Value = EmailID
            End If

            If Equals(TaxType, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((22))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((22))).Value = TaxType
            End If

            If Card.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((23))).Value = Card.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((23))).Value = System.DBNull.Value
            End If

            If QRCode Is Nothing Then
                Me.Adapter.UpdateCommand.Parameters(CInt((24))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((24))).Value = QRCode
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((25))).Value = Original_Id
            If Equals(Original_BillNo, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((26))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((27))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((26))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((27))).Value = Original_BillNo
            End If

            If Original_BillDate.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((28))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((29))).Value = Original_BillDate.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((28))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((29))).Value = System.DBNull.Value
            End If

            If Equals(Original_ODN, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((30))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((31))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((30))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((31))).Value = Original_ODN
            End If

            If Original_KOTDiscountPer.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((32))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((33))).Value = Original_KOTDiscountPer.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((32))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((33))).Value = System.DBNull.Value
            End If

            If Original_KOTDiscountAmt.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((34))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((35))).Value = Original_KOTDiscountAmt.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((34))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((35))).Value = System.DBNull.Value
            End If

            If Original_GrandTotal.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((36))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((37))).Value = Original_GrandTotal.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((36))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((37))).Value = System.DBNull.Value
            End If

            If Original_Cash.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((38))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((39))).Value = Original_Cash.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((38))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((39))).Value = System.DBNull.Value
            End If

            If Original_Change.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((40))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((41))).Value = Original_Change.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((40))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((41))).Value = System.DBNull.Value
            End If

            If Equals(Original_Operator, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((42))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((43))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((42))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((43))).Value = Original_Operator
            End If

            If Equals(Original_PaymentMode, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((44))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((45))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((44))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((45))).Value = Original_PaymentMode
            End If

            If Original_ExchangeRate.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((46))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((47))).Value = Original_ExchangeRate.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((46))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((47))).Value = System.DBNull.Value
            End If

            If Equals(Original_CurrencyCode, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((48))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((49))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((48))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((49))).Value = Original_CurrencyCode
            End If

            If Equals(Original_Member_ID, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((50))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((51))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((50))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((51))).Value = Original_Member_ID
            End If

            If Equals(Original_Waiter, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((52))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((53))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((52))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((53))).Value = Original_Waiter
            End If

            If Equals(Original_GiftCardID, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((54))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((55))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((54))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((55))).Value = Original_GiftCardID
            End If

            If Original_GiftCardAmount.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((56))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((57))).Value = Original_GiftCardAmount.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((56))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((57))).Value = System.DBNull.Value
            End If

            If Original_LP.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((58))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((59))).Value = Original_LP.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((58))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((59))).Value = System.DBNull.Value
            End If

            If Original_LA.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((60))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((61))).Value = Original_LA.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((60))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((61))).Value = System.DBNull.Value
            End If

            If Equals(Original_CustomerName, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((62))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((63))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((62))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((63))).Value = Original_CustomerName
            End If

            If Equals(Original_PhoneNo, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((64))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((65))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((64))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((65))).Value = Original_PhoneNo
            End If

            If Equals(Original_EmailID, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((66))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((67))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((66))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((67))).Value = Original_EmailID
            End If

            If Equals(Original_TaxType, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((68))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((69))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((68))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((69))).Value = Original_TaxType
            End If

            If Original_Card.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((70))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((71))).Value = Original_Card.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((70))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((71))).Value = System.DBNull.Value
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
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Overridable Function Update(BillNo As String, BillDate As System.DateTime?, ODN As String, KOTDiscountPer As Decimal?, KOTDiscountAmt As Decimal?, GrandTotal As Decimal?, Cash As Decimal?, Change As Decimal?, _Operator As String, PaymentMode As String, ExchangeRate As Decimal?, CurrencyCode As String, Member_ID As String, Waiter As String, GiftCardID As String, GiftCardAmount As Decimal?, LP As Integer?, LA As Decimal?, CustomerName As String, PhoneNo As String, EmailID As String, TaxType As String, Card As Decimal?, QRCode As Byte(), Original_Id As Integer, Original_BillNo As String, Original_BillDate As System.DateTime?, Original_ODN As String, Original_KOTDiscountPer As Decimal?, Original_KOTDiscountAmt As Decimal?, Original_GrandTotal As Decimal?, Original_Cash As Decimal?, Original_Change As Decimal?, Original_Operator As String, Original_PaymentMode As String, Original_ExchangeRate As Decimal?, Original_CurrencyCode As String, Original_Member_ID As String, Original_Waiter As String, Original_GiftCardID As String, Original_GiftCardAmount As Decimal?, Original_LP As Integer?, Original_LA As Decimal?, Original_CustomerName As String, Original_PhoneNo As String, Original_EmailID As String, Original_TaxType As String, Original_Card As Decimal?) As Integer
            Return Me.Update(Original_Id, BillNo, BillDate, ODN, KOTDiscountPer, KOTDiscountAmt, GrandTotal, Cash, Change, _Operator, PaymentMode, ExchangeRate, CurrencyCode, Member_ID, Waiter, GiftCardID, GiftCardAmount, LP, LA, CustomerName, PhoneNo, EmailID, TaxType, Card, QRCode, Original_Id, Original_BillNo, Original_BillDate, Original_ODN, Original_KOTDiscountPer, Original_KOTDiscountAmt, Original_GrandTotal, Original_Cash, Original_Change, Original_Operator, Original_PaymentMode, Original_ExchangeRate, Original_CurrencyCode, Original_Member_ID, Original_Waiter, Original_GiftCardID, Original_GiftCardAmount, Original_LP, Original_LA, Original_CustomerName, Original_PhoneNo, Original_EmailID, Original_TaxType, Original_Card)
        End Function
    End Class
End Namespace
