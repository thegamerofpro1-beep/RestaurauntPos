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

Namespace RestaurantPOS14.RPOS_DBDataSet1TableAdapters

    ''' <summary>
    ''' TableAdapterManager is used to coordinate TableAdapters in the dataset to enable Hierarchical Update scenarios
    ''' </summary>
    <System.ComponentModel.DesignerCategoryAttribute("code")>
    <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapterManager")>
    <System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")>
    <System.ComponentModel.ToolboxItemAttribute(True)>
    Public Class TableAdapterManager
        Inherits System.ComponentModel.Component

        ''' <summary>
        ''' Update Order Option
        ''' </summary>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Enum UpdateOrderOption
            InsertUpdateDelete
            UpdateInsertDelete
        End Enum

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Private Class SelfReferenceComparer
            Implements System.Collections.Generic.IComparer(Of System.Data.DataRow)

            Private _relation As System.Data.DataRelation

            Private _childFirst As Integer

            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
            Friend Sub New(relation As System.Data.DataRelation, childFirst As Boolean)
                Me._relation = relation
                If childFirst Then
                    Me._childFirst = -1
                Else
                    Me._childFirst = 1
                End If
            End Sub

            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
            Private Function GetRoot(row As System.Data.DataRow, ByRef distance As Integer) As System.Data.DataRow
                Dim result As System.Data.DataRow = row
                distance = 0
                Dim dictionary As System.Collections.Generic.IDictionary(Of System.Data.DataRow, System.Data.DataRow) = New System.Collections.Generic.Dictionary(Of System.Data.DataRow, System.Data.DataRow)()
                dictionary(row) = row
                Dim parentRow As System.Data.DataRow = row.GetParentRow(Me._relation, System.Data.DataRowVersion.[Default])
                While parentRow IsNot Nothing AndAlso Not dictionary.ContainsKey(parentRow)
                    distance += 1
                    result = parentRow
                    dictionary(parentRow) = parentRow
                    parentRow = parentRow.GetParentRow(Me._relation, System.Data.DataRowVersion.[Default])
                End While

                If distance = 0 Then
                    dictionary.Clear()
                    dictionary(row) = row
                    parentRow = row.GetParentRow(Me._relation, System.Data.DataRowVersion.Original)
                    While parentRow IsNot Nothing AndAlso Not dictionary.ContainsKey(parentRow)
                        distance += 1
                        result = parentRow
                        dictionary(parentRow) = parentRow
                        parentRow = parentRow.GetParentRow(Me._relation, System.Data.DataRowVersion.Original)
                    End While
                End If

                Return result
            End Function

            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
            Public Function Compare(row1 As System.Data.DataRow, row2 As System.Data.DataRow) As Integer
                If row1 Is row2 Then
                    Return 0
                End If

                If row1 Is Nothing Then
                    Return -1
                End If

                If row2 Is Nothing Then
                    Return 1
                End If

                Dim num As Integer = 0
                Dim root As System.Data.DataRow = Me.GetRoot(row1, num)
                Dim value As Integer = 0
                Dim root2 As System.Data.DataRow = Me.GetRoot(row2, value)
                If root Is root2 Then
                    Return Me._childFirst * num.CompareTo(value)
                End If

                If root.Table.Rows.IndexOf(root) < root2.Table.Rows.IndexOf(root2) Then
                    Return -1
                End If

                Return 1
            End Function

            Private Function Compare1(row1 As System.Data.DataRow, row2 As System.Data.DataRow) As Integer Implements Global.System.Collections.Generic.IComparer(Of Global.System.Data.DataRow).Compare
                Return Me.Compare(row1, row2)
            End Function
        End Class

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        Private _updateOrder As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption

        Private _activationTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.ActivationTableAdapter

        Private _bankTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.BankTableAdapter

        Private _bankAccountLedgerTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.BankAccountLedgerTableAdapter

        Private _bankAccountRegistrationTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.BankAccountRegistrationTableAdapter

        Private _bankBranchTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.BankBranchTableAdapter

        Private _categoryTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.CategoryTableAdapter

        Private _clockINTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.ClockINTableAdapter

        Private _clockOUTTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.ClockOUTTableAdapter

        Private _cMISettingTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.CMISettingTableAdapter

        Private _creditCustomerTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.CreditCustomerTableAdapter

        Private _creditCustomerLedgerTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.CreditCustomerLedgerTableAdapter

        Private _creditCustomerPaymentTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.CreditCustomerPaymentTableAdapter

        Private _currencyTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.CurrencyTableAdapter

        Private _deletedInvoicesTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.DeletedInvoicesTableAdapter

        Private _deletedInvoices_JoinTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.DeletedInvoices_JoinTableAdapter

        Private _dishTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.DishTableAdapter

        Private _emailSettingTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.EmailSettingTableAdapter

        Private _employeeRegistrationTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.EmployeeRegistrationTableAdapter

        Private _expenseTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.ExpenseTableAdapter

        Private _expenseTypeTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.ExpenseTypeTableAdapter

        Private _fundDepositTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.FundDepositTableAdapter

        Private _fundTransferTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.FundTransferTableAdapter

        Private _giftCardTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.GiftCardTableAdapter

        Private _gridGroupingTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.GridGroupingTableAdapter

        Private _hDCustomerTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.HDCustomerTableAdapter

        Private _holdBillTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.HoldBillTableAdapter

        Private _holdItemsTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.HoldItemsTableAdapter

        Private _hotelTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.HotelTableAdapter

        Private _journalTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.JournalTableAdapter

        Private _kitchenTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.KitchenTableAdapter

        Private _ledgerBookTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.LedgerBookTableAdapter

        Private _logsTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.LogsTableAdapter

        Private _loyaltyMemberTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.LoyaltyMemberTableAdapter

        Private _loyaltyMemberLedgerBookTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.LoyaltyMemberLedgerBookTableAdapter

        Private _loyaltySettingTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.LoyaltySettingTableAdapter

        Private _memberTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.MemberTableAdapter

        Private _memberLedgerTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.MemberLedgerTableAdapter

        Private _modifiersTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.ModifiersTableAdapter

        Private _mpesaSettingTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.MpesaSettingTableAdapter

        Private _notesMasterTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.NotesMasterTableAdapter

        Private _otherSettingTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.OtherSettingTableAdapter

        Private _paymentTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PaymentTableAdapter

        Private _payment_WithdrawTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.Payment_WithdrawTableAdapter

        Private _payrollTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PayrollTableAdapter

        Private _payroll_MBTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.Payroll_MBTableAdapter

        Private _pizzaMasterTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PizzaMasterTableAdapter

        Private _pizzaModifierTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PizzaModifierTableAdapter

        Private _pizzaSizeTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PizzaSizeTableAdapter

        Private _pizzaToppingTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PizzaToppingTableAdapter

        Private _posGroupingTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PosGroupingTableAdapter

        Private _posGrouping1TableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PosGrouping1TableAdapter

        Private _posPrinterSettingTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PosPrinterSettingTableAdapter

        Private _productTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.ProductTableAdapter

        Private _product_OpeningStockTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.Product_OpeningStockTableAdapter

        Private _promotionTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PromotionTableAdapter

        Private _purchaseTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PurchaseTableAdapter

        Private _purchase_JoinTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.Purchase_JoinTableAdapter

        Private _purchaseOrderTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PurchaseOrderTableAdapter

        Private _purchaseOrder_JoinTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PurchaseOrder_JoinTableAdapter

        Private _r_TableTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.R_TableTableAdapter

        Private _recipeTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.RecipeTableAdapter

        Private _recipe_JoinTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.Recipe_JoinTableAdapter

        Private _registrationTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.RegistrationTableAdapter

        Private _restaurantPOS_BillingInfoEBTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.RestaurantPOS_BillingInfoEBTableAdapter

        Private _restaurantPOS_BillingInfoHDTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.RestaurantPOS_BillingInfoHDTableAdapter

        Private _restaurantPOS_BillingInfoKOTTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.RestaurantPOS_BillingInfoKOTTableAdapter

        Private _restaurantPOS_BillingInfoTATableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.RestaurantPOS_BillingInfoTATableAdapter

        Private _restaurantPOS_OrderedProductBillEBTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.RestaurantPOS_OrderedProductBillEBTableAdapter

        Private _restaurantPOS_OrderedProductBillHDTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.RestaurantPOS_OrderedProductBillHDTableAdapter

        Private _restaurantPOS_OrderedProductBillKOTTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.RestaurantPOS_OrderedProductBillKOTTableAdapter

        Private _restaurantPOS_OrderedProductBillTATableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.RestaurantPOS_OrderedProductBillTATableAdapter

        Private _restaurantPOS_OrderedProductKOTTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.RestaurantPOS_OrderedProductKOTTableAdapter

        Private _restaurantPOS_OrderInfoKOTTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.RestaurantPOS_OrderInfoKOTTableAdapter

        Private _rM_UsedTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.RM_UsedTableAdapter

        Private _rM_Used_JoinTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.RM_Used_JoinTableAdapter

        Private _rMCategoryTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.RMCategoryTableAdapter

        Private _sMSSettingTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.SMSSettingTableAdapter

        Private _stock_StoreTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.Stock_StoreTableAdapter

        Private _stock_Store_JoinTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.Stock_Store_JoinTableAdapter

        Private _stockAdjustment_MITableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.StockAdjustment_MITableAdapter

        Private _stockAdjustment_StoreTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.StockAdjustment_StoreTableAdapter

        Private _stockAdjustment_WarehouseTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.StockAdjustment_WarehouseTableAdapter

        Private _stockTransferTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.StockTransferTableAdapter

        Private _stockTransfer_JoinTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.StockTransfer_JoinTableAdapter

        Private _supplierTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.SupplierTableAdapter

        Private _supplierLedgerBookTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.SupplierLedgerBookTableAdapter

        Private _tableLayoutTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.TableLayoutTableAdapter

        Private _tableMappingTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.TableMappingTableAdapter

        Private _tableReservationTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.TableReservationTableAdapter

        Private _tblOrderTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.tblOrderTableAdapter

        Private _temp_StockTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.Temp_StockTableAdapter

        Private _temp_Stock_RMTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.Temp_Stock_RMTableAdapter

        Private _temp_Stock_StoreTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.Temp_Stock_StoreTableAdapter

        Private _tempRestaurantPOS_BillingInfoKOTTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.TempRestaurantPOS_BillingInfoKOTTableAdapter

        Private _tempRestaurantPOS_OrderedProductBillKOTTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.TempRestaurantPOS_OrderedProductBillKOTTableAdapter

        Private _unitMasterTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.UnitMasterTableAdapter

        Private _userRightsTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.UserRightsTableAdapter

        Private _voucherTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.VoucherTableAdapter

        Private _voucher_OtherDetailsTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.Voucher_OtherDetailsTableAdapter

        Private _walletTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.WalletTableAdapter

        Private _warehouseTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.WarehouseTableAdapter

        Private _warehouseTypeTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.WarehouseTypeTableAdapter

        Private _workPeriodEndTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.WorkPeriodEndTableAdapter

        Private _workPeriodStartTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.WorkPeriodStartTableAdapter

        Private _backupDataSetBeforeUpdate As Boolean

        Private _connection As System.Data.IDbConnection

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Property UpdateOrder As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption
            Get
                Return Me._updateOrder
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption)
                Me._updateOrder = value
            End Set
        End Property

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        Public Property ActivationTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.ActivationTableAdapter
            Get
                Return Me._activationTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.ActivationTableAdapter)
                Me._activationTableAdapter = value
            End Set
        End Property

        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Property BankTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.BankTableAdapter
            Get
                Return Me._bankTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.BankTableAdapter)
                Me._bankTableAdapter = value
            End Set
        End Property

        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Property BankAccountLedgerTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.BankAccountLedgerTableAdapter
            Get
                Return Me._bankAccountLedgerTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.BankAccountLedgerTableAdapter)
                Me._bankAccountLedgerTableAdapter = value
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Property BankAccountRegistrationTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.BankAccountRegistrationTableAdapter
            Get
                Return Me._bankAccountRegistrationTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.BankAccountRegistrationTableAdapter)
                Me._bankAccountRegistrationTableAdapter = value
            End Set
        End Property

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        Public Property BankBranchTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.BankBranchTableAdapter
            Get
                Return Me._bankBranchTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.BankBranchTableAdapter)
                Me._bankBranchTableAdapter = value
            End Set
        End Property

        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Property CategoryTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.CategoryTableAdapter
            Get
                Return Me._categoryTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.CategoryTableAdapter)
                Me._categoryTableAdapter = value
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Property ClockINTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.ClockINTableAdapter
            Get
                Return Me._clockINTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.ClockINTableAdapter)
                Me._clockINTableAdapter = value
            End Set
        End Property

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Property ClockOUTTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.ClockOUTTableAdapter
            Get
                Return Me._clockOUTTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.ClockOUTTableAdapter)
                Me._clockOUTTableAdapter = value
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Property CMISettingTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.CMISettingTableAdapter
            Get
                Return Me._cMISettingTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.CMISettingTableAdapter)
                Me._cMISettingTableAdapter = value
            End Set
        End Property

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Property CreditCustomerTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.CreditCustomerTableAdapter
            Get
                Return Me._creditCustomerTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.CreditCustomerTableAdapter)
                Me._creditCustomerTableAdapter = value
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Property CreditCustomerLedgerTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.CreditCustomerLedgerTableAdapter
            Get
                Return Me._creditCustomerLedgerTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.CreditCustomerLedgerTableAdapter)
                Me._creditCustomerLedgerTableAdapter = value
            End Set
        End Property

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Property CreditCustomerPaymentTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.CreditCustomerPaymentTableAdapter
            Get
                Return Me._creditCustomerPaymentTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.CreditCustomerPaymentTableAdapter)
                Me._creditCustomerPaymentTableAdapter = value
            End Set
        End Property

        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Property CurrencyTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.CurrencyTableAdapter
            Get
                Return Me._currencyTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.CurrencyTableAdapter)
                Me._currencyTableAdapter = value
            End Set
        End Property

        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Property DeletedInvoicesTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.DeletedInvoicesTableAdapter
            Get
                Return Me._deletedInvoicesTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.DeletedInvoicesTableAdapter)
                Me._deletedInvoicesTableAdapter = value
            End Set
        End Property

        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Property DeletedInvoices_JoinTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.DeletedInvoices_JoinTableAdapter
            Get
                Return Me._deletedInvoices_JoinTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.DeletedInvoices_JoinTableAdapter)
                Me._deletedInvoices_JoinTableAdapter = value
            End Set
        End Property

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        Public Property DishTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.DishTableAdapter
            Get
                Return Me._dishTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.DishTableAdapter)
                Me._dishTableAdapter = value
            End Set
        End Property

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        Public Property EmailSettingTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.EmailSettingTableAdapter
            Get
                Return Me._emailSettingTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.EmailSettingTableAdapter)
                Me._emailSettingTableAdapter = value
            End Set
        End Property

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        Public Property EmployeeRegistrationTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.EmployeeRegistrationTableAdapter
            Get
                Return Me._employeeRegistrationTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.EmployeeRegistrationTableAdapter)
                Me._employeeRegistrationTableAdapter = value
            End Set
        End Property

        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Property ExpenseTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.ExpenseTableAdapter
            Get
                Return Me._expenseTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.ExpenseTableAdapter)
                Me._expenseTableAdapter = value
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Property ExpenseTypeTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.ExpenseTypeTableAdapter
            Get
                Return Me._expenseTypeTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.ExpenseTypeTableAdapter)
                Me._expenseTypeTableAdapter = value
            End Set
        End Property

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        Public Property FundDepositTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.FundDepositTableAdapter
            Get
                Return Me._fundDepositTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.FundDepositTableAdapter)
                Me._fundDepositTableAdapter = value
            End Set
        End Property

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        Public Property FundTransferTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.FundTransferTableAdapter
            Get
                Return Me._fundTransferTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.FundTransferTableAdapter)
                Me._fundTransferTableAdapter = value
            End Set
        End Property

        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Property GiftCardTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.GiftCardTableAdapter
            Get
                Return Me._giftCardTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.GiftCardTableAdapter)
                Me._giftCardTableAdapter = value
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Property GridGroupingTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.GridGroupingTableAdapter
            Get
                Return Me._gridGroupingTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.GridGroupingTableAdapter)
                Me._gridGroupingTableAdapter = value
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Property HDCustomerTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.HDCustomerTableAdapter
            Get
                Return Me._hDCustomerTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.HDCustomerTableAdapter)
                Me._hDCustomerTableAdapter = value
            End Set
        End Property

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        Public Property HoldBillTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.HoldBillTableAdapter
            Get
                Return Me._holdBillTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.HoldBillTableAdapter)
                Me._holdBillTableAdapter = value
            End Set
        End Property

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Property HoldItemsTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.HoldItemsTableAdapter
            Get
                Return Me._holdItemsTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.HoldItemsTableAdapter)
                Me._holdItemsTableAdapter = value
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        Public Property HotelTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.HotelTableAdapter
            Get
                Return Me._hotelTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.HotelTableAdapter)
                Me._hotelTableAdapter = value
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        Public Property JournalTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.JournalTableAdapter
            Get
                Return Me._journalTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.JournalTableAdapter)
                Me._journalTableAdapter = value
            End Set
        End Property

        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Property KitchenTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.KitchenTableAdapter
            Get
                Return Me._kitchenTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.KitchenTableAdapter)
                Me._kitchenTableAdapter = value
            End Set
        End Property

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Property LedgerBookTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.LedgerBookTableAdapter
            Get
                Return Me._ledgerBookTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.LedgerBookTableAdapter)
                Me._ledgerBookTableAdapter = value
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        Public Property LogsTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.LogsTableAdapter
            Get
                Return Me._logsTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.LogsTableAdapter)
                Me._logsTableAdapter = value
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Property LoyaltyMemberTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.LoyaltyMemberTableAdapter
            Get
                Return Me._loyaltyMemberTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.LoyaltyMemberTableAdapter)
                Me._loyaltyMemberTableAdapter = value
            End Set
        End Property

        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Property LoyaltyMemberLedgerBookTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.LoyaltyMemberLedgerBookTableAdapter
            Get
                Return Me._loyaltyMemberLedgerBookTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.LoyaltyMemberLedgerBookTableAdapter)
                Me._loyaltyMemberLedgerBookTableAdapter = value
            End Set
        End Property

        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Property LoyaltySettingTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.LoyaltySettingTableAdapter
            Get
                Return Me._loyaltySettingTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.LoyaltySettingTableAdapter)
                Me._loyaltySettingTableAdapter = value
            End Set
        End Property

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        Public Property MemberTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.MemberTableAdapter
            Get
                Return Me._memberTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.MemberTableAdapter)
                Me._memberTableAdapter = value
            End Set
        End Property

        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Property MemberLedgerTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.MemberLedgerTableAdapter
            Get
                Return Me._memberLedgerTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.MemberLedgerTableAdapter)
                Me._memberLedgerTableAdapter = value
            End Set
        End Property

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Property ModifiersTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.ModifiersTableAdapter
            Get
                Return Me._modifiersTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.ModifiersTableAdapter)
                Me._modifiersTableAdapter = value
            End Set
        End Property

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        Public Property MpesaSettingTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.MpesaSettingTableAdapter
            Get
                Return Me._mpesaSettingTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.MpesaSettingTableAdapter)
                Me._mpesaSettingTableAdapter = value
            End Set
        End Property

        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Property NotesMasterTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.NotesMasterTableAdapter
            Get
                Return Me._notesMasterTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.NotesMasterTableAdapter)
                Me._notesMasterTableAdapter = value
            End Set
        End Property

        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Property OtherSettingTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.OtherSettingTableAdapter
            Get
                Return Me._otherSettingTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.OtherSettingTableAdapter)
                Me._otherSettingTableAdapter = value
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        Public Property PaymentTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PaymentTableAdapter
            Get
                Return Me._paymentTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PaymentTableAdapter)
                Me._paymentTableAdapter = value
            End Set
        End Property

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Property Payment_WithdrawTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.Payment_WithdrawTableAdapter
            Get
                Return Me._payment_WithdrawTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.Payment_WithdrawTableAdapter)
                Me._payment_WithdrawTableAdapter = value
            End Set
        End Property

        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Property PayrollTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PayrollTableAdapter
            Get
                Return Me._payrollTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PayrollTableAdapter)
                Me._payrollTableAdapter = value
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Property Payroll_MBTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.Payroll_MBTableAdapter
            Get
                Return Me._payroll_MBTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.Payroll_MBTableAdapter)
                Me._payroll_MBTableAdapter = value
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Property PizzaMasterTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PizzaMasterTableAdapter
            Get
                Return Me._pizzaMasterTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PizzaMasterTableAdapter)
                Me._pizzaMasterTableAdapter = value
            End Set
        End Property

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        Public Property PizzaModifierTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PizzaModifierTableAdapter
            Get
                Return Me._pizzaModifierTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PizzaModifierTableAdapter)
                Me._pizzaModifierTableAdapter = value
            End Set
        End Property

        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Property PizzaSizeTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PizzaSizeTableAdapter
            Get
                Return Me._pizzaSizeTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PizzaSizeTableAdapter)
                Me._pizzaSizeTableAdapter = value
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Property PizzaToppingTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PizzaToppingTableAdapter
            Get
                Return Me._pizzaToppingTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PizzaToppingTableAdapter)
                Me._pizzaToppingTableAdapter = value
            End Set
        End Property

        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Property PosGroupingTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PosGroupingTableAdapter
            Get
                Return Me._posGroupingTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PosGroupingTableAdapter)
                Me._posGroupingTableAdapter = value
            End Set
        End Property

        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Property PosGrouping1TableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PosGrouping1TableAdapter
            Get
                Return Me._posGrouping1TableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PosGrouping1TableAdapter)
                Me._posGrouping1TableAdapter = value
            End Set
        End Property

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Property PosPrinterSettingTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PosPrinterSettingTableAdapter
            Get
                Return Me._posPrinterSettingTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PosPrinterSettingTableAdapter)
                Me._posPrinterSettingTableAdapter = value
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Property ProductTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.ProductTableAdapter
            Get
                Return Me._productTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.ProductTableAdapter)
                Me._productTableAdapter = value
            End Set
        End Property

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        Public Property Product_OpeningStockTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.Product_OpeningStockTableAdapter
            Get
                Return Me._product_OpeningStockTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.Product_OpeningStockTableAdapter)
                Me._product_OpeningStockTableAdapter = value
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Property PromotionTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PromotionTableAdapter
            Get
                Return Me._promotionTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PromotionTableAdapter)
                Me._promotionTableAdapter = value
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Property PurchaseTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PurchaseTableAdapter
            Get
                Return Me._purchaseTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PurchaseTableAdapter)
                Me._purchaseTableAdapter = value
            End Set
        End Property

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        Public Property Purchase_JoinTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.Purchase_JoinTableAdapter
            Get
                Return Me._purchase_JoinTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.Purchase_JoinTableAdapter)
                Me._purchase_JoinTableAdapter = value
            End Set
        End Property

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        Public Property PurchaseOrderTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PurchaseOrderTableAdapter
            Get
                Return Me._purchaseOrderTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PurchaseOrderTableAdapter)
                Me._purchaseOrderTableAdapter = value
            End Set
        End Property

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        Public Property PurchaseOrder_JoinTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PurchaseOrder_JoinTableAdapter
            Get
                Return Me._purchaseOrder_JoinTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PurchaseOrder_JoinTableAdapter)
                Me._purchaseOrder_JoinTableAdapter = value
            End Set
        End Property

        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Property R_TableTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.R_TableTableAdapter
            Get
                Return Me._r_TableTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.R_TableTableAdapter)
                Me._r_TableTableAdapter = value
            End Set
        End Property

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        Public Property RecipeTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.RecipeTableAdapter
            Get
                Return Me._recipeTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.RecipeTableAdapter)
                Me._recipeTableAdapter = value
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Property Recipe_JoinTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.Recipe_JoinTableAdapter
            Get
                Return Me._recipe_JoinTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.Recipe_JoinTableAdapter)
                Me._recipe_JoinTableAdapter = value
            End Set
        End Property

        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Property RegistrationTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.RegistrationTableAdapter
            Get
                Return Me._registrationTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.RegistrationTableAdapter)
                Me._registrationTableAdapter = value
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        Public Property RestaurantPOS_BillingInfoEBTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.RestaurantPOS_BillingInfoEBTableAdapter
            Get
                Return Me._restaurantPOS_BillingInfoEBTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.RestaurantPOS_BillingInfoEBTableAdapter)
                Me._restaurantPOS_BillingInfoEBTableAdapter = value
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Property RestaurantPOS_BillingInfoHDTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.RestaurantPOS_BillingInfoHDTableAdapter
            Get
                Return Me._restaurantPOS_BillingInfoHDTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.RestaurantPOS_BillingInfoHDTableAdapter)
                Me._restaurantPOS_BillingInfoHDTableAdapter = value
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        Public Property RestaurantPOS_BillingInfoKOTTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.RestaurantPOS_BillingInfoKOTTableAdapter
            Get
                Return Me._restaurantPOS_BillingInfoKOTTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.RestaurantPOS_BillingInfoKOTTableAdapter)
                Me._restaurantPOS_BillingInfoKOTTableAdapter = value
            End Set
        End Property

        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Property RestaurantPOS_BillingInfoTATableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.RestaurantPOS_BillingInfoTATableAdapter
            Get
                Return Me._restaurantPOS_BillingInfoTATableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.RestaurantPOS_BillingInfoTATableAdapter)
                Me._restaurantPOS_BillingInfoTATableAdapter = value
            End Set
        End Property

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        Public Property RestaurantPOS_OrderedProductBillEBTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.RestaurantPOS_OrderedProductBillEBTableAdapter
            Get
                Return Me._restaurantPOS_OrderedProductBillEBTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.RestaurantPOS_OrderedProductBillEBTableAdapter)
                Me._restaurantPOS_OrderedProductBillEBTableAdapter = value
            End Set
        End Property

        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Property RestaurantPOS_OrderedProductBillHDTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.RestaurantPOS_OrderedProductBillHDTableAdapter
            Get
                Return Me._restaurantPOS_OrderedProductBillHDTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.RestaurantPOS_OrderedProductBillHDTableAdapter)
                Me._restaurantPOS_OrderedProductBillHDTableAdapter = value
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        Public Property RestaurantPOS_OrderedProductBillKOTTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.RestaurantPOS_OrderedProductBillKOTTableAdapter
            Get
                Return Me._restaurantPOS_OrderedProductBillKOTTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.RestaurantPOS_OrderedProductBillKOTTableAdapter)
                Me._restaurantPOS_OrderedProductBillKOTTableAdapter = value
            End Set
        End Property

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Property RestaurantPOS_OrderedProductBillTATableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.RestaurantPOS_OrderedProductBillTATableAdapter
            Get
                Return Me._restaurantPOS_OrderedProductBillTATableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.RestaurantPOS_OrderedProductBillTATableAdapter)
                Me._restaurantPOS_OrderedProductBillTATableAdapter = value
            End Set
        End Property

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Property RestaurantPOS_OrderedProductKOTTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.RestaurantPOS_OrderedProductKOTTableAdapter
            Get
                Return Me._restaurantPOS_OrderedProductKOTTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.RestaurantPOS_OrderedProductKOTTableAdapter)
                Me._restaurantPOS_OrderedProductKOTTableAdapter = value
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Property RestaurantPOS_OrderInfoKOTTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.RestaurantPOS_OrderInfoKOTTableAdapter
            Get
                Return Me._restaurantPOS_OrderInfoKOTTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.RestaurantPOS_OrderInfoKOTTableAdapter)
                Me._restaurantPOS_OrderInfoKOTTableAdapter = value
            End Set
        End Property

        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Property RM_UsedTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.RM_UsedTableAdapter
            Get
                Return Me._rM_UsedTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.RM_UsedTableAdapter)
                Me._rM_UsedTableAdapter = value
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        Public Property RM_Used_JoinTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.RM_Used_JoinTableAdapter
            Get
                Return Me._rM_Used_JoinTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.RM_Used_JoinTableAdapter)
                Me._rM_Used_JoinTableAdapter = value
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        Public Property RMCategoryTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.RMCategoryTableAdapter
            Get
                Return Me._rMCategoryTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.RMCategoryTableAdapter)
                Me._rMCategoryTableAdapter = value
            End Set
        End Property

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        Public Property SMSSettingTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.SMSSettingTableAdapter
            Get
                Return Me._sMSSettingTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.SMSSettingTableAdapter)
                Me._sMSSettingTableAdapter = value
            End Set
        End Property

        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Property Stock_StoreTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.Stock_StoreTableAdapter
            Get
                Return Me._stock_StoreTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.Stock_StoreTableAdapter)
                Me._stock_StoreTableAdapter = value
            End Set
        End Property

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Property Stock_Store_JoinTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.Stock_Store_JoinTableAdapter
            Get
                Return Me._stock_Store_JoinTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.Stock_Store_JoinTableAdapter)
                Me._stock_Store_JoinTableAdapter = value
            End Set
        End Property

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        Public Property StockAdjustment_MITableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.StockAdjustment_MITableAdapter
            Get
                Return Me._stockAdjustment_MITableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.StockAdjustment_MITableAdapter)
                Me._stockAdjustment_MITableAdapter = value
            End Set
        End Property

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Property StockAdjustment_StoreTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.StockAdjustment_StoreTableAdapter
            Get
                Return Me._stockAdjustment_StoreTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.StockAdjustment_StoreTableAdapter)
                Me._stockAdjustment_StoreTableAdapter = value
            End Set
        End Property

        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Property StockAdjustment_WarehouseTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.StockAdjustment_WarehouseTableAdapter
            Get
                Return Me._stockAdjustment_WarehouseTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.StockAdjustment_WarehouseTableAdapter)
                Me._stockAdjustment_WarehouseTableAdapter = value
            End Set
        End Property

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        Public Property StockTransferTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.StockTransferTableAdapter
            Get
                Return Me._stockTransferTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.StockTransferTableAdapter)
                Me._stockTransferTableAdapter = value
            End Set
        End Property

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        Public Property StockTransfer_JoinTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.StockTransfer_JoinTableAdapter
            Get
                Return Me._stockTransfer_JoinTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.StockTransfer_JoinTableAdapter)
                Me._stockTransfer_JoinTableAdapter = value
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Property SupplierTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.SupplierTableAdapter
            Get
                Return Me._supplierTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.SupplierTableAdapter)
                Me._supplierTableAdapter = value
            End Set
        End Property

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Property SupplierLedgerBookTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.SupplierLedgerBookTableAdapter
            Get
                Return Me._supplierLedgerBookTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.SupplierLedgerBookTableAdapter)
                Me._supplierLedgerBookTableAdapter = value
            End Set
        End Property

        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Property TableLayoutTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.TableLayoutTableAdapter
            Get
                Return Me._tableLayoutTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.TableLayoutTableAdapter)
                Me._tableLayoutTableAdapter = value
            End Set
        End Property

        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Property TableMappingTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.TableMappingTableAdapter
            Get
                Return Me._tableMappingTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.TableMappingTableAdapter)
                Me._tableMappingTableAdapter = value
            End Set
        End Property

        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Property TableReservationTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.TableReservationTableAdapter
            Get
                Return Me._tableReservationTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.TableReservationTableAdapter)
                Me._tableReservationTableAdapter = value
            End Set
        End Property

        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Property tblOrderTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.tblOrderTableAdapter
            Get
                Return Me._tblOrderTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.tblOrderTableAdapter)
                Me._tblOrderTableAdapter = value
            End Set
        End Property

        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Property Temp_StockTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.Temp_StockTableAdapter
            Get
                Return Me._temp_StockTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.Temp_StockTableAdapter)
                Me._temp_StockTableAdapter = value
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Property Temp_Stock_RMTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.Temp_Stock_RMTableAdapter
            Get
                Return Me._temp_Stock_RMTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.Temp_Stock_RMTableAdapter)
                Me._temp_Stock_RMTableAdapter = value
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Property Temp_Stock_StoreTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.Temp_Stock_StoreTableAdapter
            Get
                Return Me._temp_Stock_StoreTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.Temp_Stock_StoreTableAdapter)
                Me._temp_Stock_StoreTableAdapter = value
            End Set
        End Property

        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Property TempRestaurantPOS_BillingInfoKOTTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.TempRestaurantPOS_BillingInfoKOTTableAdapter
            Get
                Return Me._tempRestaurantPOS_BillingInfoKOTTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.TempRestaurantPOS_BillingInfoKOTTableAdapter)
                Me._tempRestaurantPOS_BillingInfoKOTTableAdapter = value
            End Set
        End Property

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Property TempRestaurantPOS_OrderedProductBillKOTTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.TempRestaurantPOS_OrderedProductBillKOTTableAdapter
            Get
                Return Me._tempRestaurantPOS_OrderedProductBillKOTTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.TempRestaurantPOS_OrderedProductBillKOTTableAdapter)
                Me._tempRestaurantPOS_OrderedProductBillKOTTableAdapter = value
            End Set
        End Property

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Property UnitMasterTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.UnitMasterTableAdapter
            Get
                Return Me._unitMasterTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.UnitMasterTableAdapter)
                Me._unitMasterTableAdapter = value
            End Set
        End Property

        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Property UserRightsTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.UserRightsTableAdapter
            Get
                Return Me._userRightsTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.UserRightsTableAdapter)
                Me._userRightsTableAdapter = value
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        Public Property VoucherTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.VoucherTableAdapter
            Get
                Return Me._voucherTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.VoucherTableAdapter)
                Me._voucherTableAdapter = value
            End Set
        End Property

        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Property Voucher_OtherDetailsTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.Voucher_OtherDetailsTableAdapter
            Get
                Return Me._voucher_OtherDetailsTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.Voucher_OtherDetailsTableAdapter)
                Me._voucher_OtherDetailsTableAdapter = value
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Property WalletTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.WalletTableAdapter
            Get
                Return Me._walletTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.WalletTableAdapter)
                Me._walletTableAdapter = value
            End Set
        End Property

        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Property WarehouseTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.WarehouseTableAdapter
            Get
                Return Me._warehouseTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.WarehouseTableAdapter)
                Me._warehouseTableAdapter = value
            End Set
        End Property

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Property WarehouseTypeTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.WarehouseTypeTableAdapter
            Get
                Return Me._warehouseTypeTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.WarehouseTypeTableAdapter)
                Me._warehouseTypeTableAdapter = value
            End Set
        End Property

        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Property WorkPeriodEndTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.WorkPeriodEndTableAdapter
            Get
                Return Me._workPeriodEndTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.WorkPeriodEndTableAdapter)
                Me._workPeriodEndTableAdapter = value
            End Set
        End Property

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
        Public Property WorkPeriodStartTableAdapter As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.WorkPeriodStartTableAdapter
            Get
                Return Me._workPeriodStartTableAdapter
            End Get

            Set(value As RestaurantPOS14.RPOS_DBDataSet1TableAdapters.WorkPeriodStartTableAdapter)
                Me._workPeriodStartTableAdapter = value
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Property BackupDataSetBeforeUpdate As Boolean
            Get
                Return Me._backupDataSetBeforeUpdate
            End Get

            Set(value As Boolean)
                Me._backupDataSetBeforeUpdate = value
            End Set
        End Property

        <System.ComponentModel.BrowsableAttribute(False)>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Property Connection As System.Data.IDbConnection
            Get
                If Me._connection IsNot Nothing Then
                    Return Me._connection
                End If

                If Me._activationTableAdapter IsNot Nothing AndAlso Me._activationTableAdapter.Connection IsNot Nothing Then
                    Return Me._activationTableAdapter.Connection
                End If

                If Me._bankTableAdapter IsNot Nothing AndAlso Me._bankTableAdapter.Connection IsNot Nothing Then
                    Return Me._bankTableAdapter.Connection
                End If

                If Me._bankAccountLedgerTableAdapter IsNot Nothing AndAlso Me._bankAccountLedgerTableAdapter.Connection IsNot Nothing Then
                    Return Me._bankAccountLedgerTableAdapter.Connection
                End If

                If Me._bankAccountRegistrationTableAdapter IsNot Nothing AndAlso Me._bankAccountRegistrationTableAdapter.Connection IsNot Nothing Then
                    Return Me._bankAccountRegistrationTableAdapter.Connection
                End If

                If Me._bankBranchTableAdapter IsNot Nothing AndAlso Me._bankBranchTableAdapter.Connection IsNot Nothing Then
                    Return Me._bankBranchTableAdapter.Connection
                End If

                If Me._categoryTableAdapter IsNot Nothing AndAlso Me._categoryTableAdapter.Connection IsNot Nothing Then
                    Return Me._categoryTableAdapter.Connection
                End If

                If Me._clockINTableAdapter IsNot Nothing AndAlso Me._clockINTableAdapter.Connection IsNot Nothing Then
                    Return Me._clockINTableAdapter.Connection
                End If

                If Me._clockOUTTableAdapter IsNot Nothing AndAlso Me._clockOUTTableAdapter.Connection IsNot Nothing Then
                    Return Me._clockOUTTableAdapter.Connection
                End If

                If Me._cMISettingTableAdapter IsNot Nothing AndAlso Me._cMISettingTableAdapter.Connection IsNot Nothing Then
                    Return Me._cMISettingTableAdapter.Connection
                End If

                If Me._creditCustomerTableAdapter IsNot Nothing AndAlso Me._creditCustomerTableAdapter.Connection IsNot Nothing Then
                    Return Me._creditCustomerTableAdapter.Connection
                End If

                If Me._creditCustomerLedgerTableAdapter IsNot Nothing AndAlso Me._creditCustomerLedgerTableAdapter.Connection IsNot Nothing Then
                    Return Me._creditCustomerLedgerTableAdapter.Connection
                End If

                If Me._creditCustomerPaymentTableAdapter IsNot Nothing AndAlso Me._creditCustomerPaymentTableAdapter.Connection IsNot Nothing Then
                    Return Me._creditCustomerPaymentTableAdapter.Connection
                End If

                If Me._currencyTableAdapter IsNot Nothing AndAlso Me._currencyTableAdapter.Connection IsNot Nothing Then
                    Return Me._currencyTableAdapter.Connection
                End If

                If Me._deletedInvoicesTableAdapter IsNot Nothing AndAlso Me._deletedInvoicesTableAdapter.Connection IsNot Nothing Then
                    Return Me._deletedInvoicesTableAdapter.Connection
                End If

                If Me._deletedInvoices_JoinTableAdapter IsNot Nothing AndAlso Me._deletedInvoices_JoinTableAdapter.Connection IsNot Nothing Then
                    Return Me._deletedInvoices_JoinTableAdapter.Connection
                End If

                If Me._dishTableAdapter IsNot Nothing AndAlso Me._dishTableAdapter.Connection IsNot Nothing Then
                    Return Me._dishTableAdapter.Connection
                End If

                If Me._emailSettingTableAdapter IsNot Nothing AndAlso Me._emailSettingTableAdapter.Connection IsNot Nothing Then
                    Return Me._emailSettingTableAdapter.Connection
                End If

                If Me._employeeRegistrationTableAdapter IsNot Nothing AndAlso Me._employeeRegistrationTableAdapter.Connection IsNot Nothing Then
                    Return Me._employeeRegistrationTableAdapter.Connection
                End If

                If Me._expenseTableAdapter IsNot Nothing AndAlso Me._expenseTableAdapter.Connection IsNot Nothing Then
                    Return Me._expenseTableAdapter.Connection
                End If

                If Me._expenseTypeTableAdapter IsNot Nothing AndAlso Me._expenseTypeTableAdapter.Connection IsNot Nothing Then
                    Return Me._expenseTypeTableAdapter.Connection
                End If

                If Me._fundDepositTableAdapter IsNot Nothing AndAlso Me._fundDepositTableAdapter.Connection IsNot Nothing Then
                    Return Me._fundDepositTableAdapter.Connection
                End If

                If Me._fundTransferTableAdapter IsNot Nothing AndAlso Me._fundTransferTableAdapter.Connection IsNot Nothing Then
                    Return Me._fundTransferTableAdapter.Connection
                End If

                If Me._giftCardTableAdapter IsNot Nothing AndAlso Me._giftCardTableAdapter.Connection IsNot Nothing Then
                    Return Me._giftCardTableAdapter.Connection
                End If

                If Me._gridGroupingTableAdapter IsNot Nothing AndAlso Me._gridGroupingTableAdapter.Connection IsNot Nothing Then
                    Return Me._gridGroupingTableAdapter.Connection
                End If

                If Me._hDCustomerTableAdapter IsNot Nothing AndAlso Me._hDCustomerTableAdapter.Connection IsNot Nothing Then
                    Return Me._hDCustomerTableAdapter.Connection
                End If

                If Me._holdBillTableAdapter IsNot Nothing AndAlso Me._holdBillTableAdapter.Connection IsNot Nothing Then
                    Return Me._holdBillTableAdapter.Connection
                End If

                If Me._holdItemsTableAdapter IsNot Nothing AndAlso Me._holdItemsTableAdapter.Connection IsNot Nothing Then
                    Return Me._holdItemsTableAdapter.Connection
                End If

                If Me._hotelTableAdapter IsNot Nothing AndAlso Me._hotelTableAdapter.Connection IsNot Nothing Then
                    Return Me._hotelTableAdapter.Connection
                End If

                If Me._journalTableAdapter IsNot Nothing AndAlso Me._journalTableAdapter.Connection IsNot Nothing Then
                    Return Me._journalTableAdapter.Connection
                End If

                If Me._kitchenTableAdapter IsNot Nothing AndAlso Me._kitchenTableAdapter.Connection IsNot Nothing Then
                    Return Me._kitchenTableAdapter.Connection
                End If

                If Me._ledgerBookTableAdapter IsNot Nothing AndAlso Me._ledgerBookTableAdapter.Connection IsNot Nothing Then
                    Return Me._ledgerBookTableAdapter.Connection
                End If

                If Me._logsTableAdapter IsNot Nothing AndAlso Me._logsTableAdapter.Connection IsNot Nothing Then
                    Return Me._logsTableAdapter.Connection
                End If

                If Me._loyaltyMemberTableAdapter IsNot Nothing AndAlso Me._loyaltyMemberTableAdapter.Connection IsNot Nothing Then
                    Return Me._loyaltyMemberTableAdapter.Connection
                End If

                If Me._loyaltyMemberLedgerBookTableAdapter IsNot Nothing AndAlso Me._loyaltyMemberLedgerBookTableAdapter.Connection IsNot Nothing Then
                    Return Me._loyaltyMemberLedgerBookTableAdapter.Connection
                End If

                If Me._loyaltySettingTableAdapter IsNot Nothing AndAlso Me._loyaltySettingTableAdapter.Connection IsNot Nothing Then
                    Return Me._loyaltySettingTableAdapter.Connection
                End If

                If Me._memberTableAdapter IsNot Nothing AndAlso Me._memberTableAdapter.Connection IsNot Nothing Then
                    Return Me._memberTableAdapter.Connection
                End If

                If Me._memberLedgerTableAdapter IsNot Nothing AndAlso Me._memberLedgerTableAdapter.Connection IsNot Nothing Then
                    Return Me._memberLedgerTableAdapter.Connection
                End If

                If Me._modifiersTableAdapter IsNot Nothing AndAlso Me._modifiersTableAdapter.Connection IsNot Nothing Then
                    Return Me._modifiersTableAdapter.Connection
                End If

                If Me._mpesaSettingTableAdapter IsNot Nothing AndAlso Me._mpesaSettingTableAdapter.Connection IsNot Nothing Then
                    Return Me._mpesaSettingTableAdapter.Connection
                End If

                If Me._notesMasterTableAdapter IsNot Nothing AndAlso Me._notesMasterTableAdapter.Connection IsNot Nothing Then
                    Return Me._notesMasterTableAdapter.Connection
                End If

                If Me._otherSettingTableAdapter IsNot Nothing AndAlso Me._otherSettingTableAdapter.Connection IsNot Nothing Then
                    Return Me._otherSettingTableAdapter.Connection
                End If

                If Me._paymentTableAdapter IsNot Nothing AndAlso Me._paymentTableAdapter.Connection IsNot Nothing Then
                    Return Me._paymentTableAdapter.Connection
                End If

                If Me._payment_WithdrawTableAdapter IsNot Nothing AndAlso Me._payment_WithdrawTableAdapter.Connection IsNot Nothing Then
                    Return Me._payment_WithdrawTableAdapter.Connection
                End If

                If Me._payrollTableAdapter IsNot Nothing AndAlso Me._payrollTableAdapter.Connection IsNot Nothing Then
                    Return Me._payrollTableAdapter.Connection
                End If

                If Me._payroll_MBTableAdapter IsNot Nothing AndAlso Me._payroll_MBTableAdapter.Connection IsNot Nothing Then
                    Return Me._payroll_MBTableAdapter.Connection
                End If

                If Me._pizzaMasterTableAdapter IsNot Nothing AndAlso Me._pizzaMasterTableAdapter.Connection IsNot Nothing Then
                    Return Me._pizzaMasterTableAdapter.Connection
                End If

                If Me._pizzaModifierTableAdapter IsNot Nothing AndAlso Me._pizzaModifierTableAdapter.Connection IsNot Nothing Then
                    Return Me._pizzaModifierTableAdapter.Connection
                End If

                If Me._pizzaSizeTableAdapter IsNot Nothing AndAlso Me._pizzaSizeTableAdapter.Connection IsNot Nothing Then
                    Return Me._pizzaSizeTableAdapter.Connection
                End If

                If Me._pizzaToppingTableAdapter IsNot Nothing AndAlso Me._pizzaToppingTableAdapter.Connection IsNot Nothing Then
                    Return Me._pizzaToppingTableAdapter.Connection
                End If

                If Me._posGroupingTableAdapter IsNot Nothing AndAlso Me._posGroupingTableAdapter.Connection IsNot Nothing Then
                    Return Me._posGroupingTableAdapter.Connection
                End If

                If Me._posGrouping1TableAdapter IsNot Nothing AndAlso Me._posGrouping1TableAdapter.Connection IsNot Nothing Then
                    Return Me._posGrouping1TableAdapter.Connection
                End If

                If Me._posPrinterSettingTableAdapter IsNot Nothing AndAlso Me._posPrinterSettingTableAdapter.Connection IsNot Nothing Then
                    Return Me._posPrinterSettingTableAdapter.Connection
                End If

                If Me._productTableAdapter IsNot Nothing AndAlso Me._productTableAdapter.Connection IsNot Nothing Then
                    Return Me._productTableAdapter.Connection
                End If

                If Me._product_OpeningStockTableAdapter IsNot Nothing AndAlso Me._product_OpeningStockTableAdapter.Connection IsNot Nothing Then
                    Return Me._product_OpeningStockTableAdapter.Connection
                End If

                If Me._promotionTableAdapter IsNot Nothing AndAlso Me._promotionTableAdapter.Connection IsNot Nothing Then
                    Return Me._promotionTableAdapter.Connection
                End If

                If Me._purchaseTableAdapter IsNot Nothing AndAlso Me._purchaseTableAdapter.Connection IsNot Nothing Then
                    Return Me._purchaseTableAdapter.Connection
                End If

                If Me._purchase_JoinTableAdapter IsNot Nothing AndAlso Me._purchase_JoinTableAdapter.Connection IsNot Nothing Then
                    Return Me._purchase_JoinTableAdapter.Connection
                End If

                If Me._purchaseOrderTableAdapter IsNot Nothing AndAlso Me._purchaseOrderTableAdapter.Connection IsNot Nothing Then
                    Return Me._purchaseOrderTableAdapter.Connection
                End If

                If Me._purchaseOrder_JoinTableAdapter IsNot Nothing AndAlso Me._purchaseOrder_JoinTableAdapter.Connection IsNot Nothing Then
                    Return Me._purchaseOrder_JoinTableAdapter.Connection
                End If

                If Me._r_TableTableAdapter IsNot Nothing AndAlso Me._r_TableTableAdapter.Connection IsNot Nothing Then
                    Return Me._r_TableTableAdapter.Connection
                End If

                If Me._recipeTableAdapter IsNot Nothing AndAlso Me._recipeTableAdapter.Connection IsNot Nothing Then
                    Return Me._recipeTableAdapter.Connection
                End If

                If Me._recipe_JoinTableAdapter IsNot Nothing AndAlso Me._recipe_JoinTableAdapter.Connection IsNot Nothing Then
                    Return Me._recipe_JoinTableAdapter.Connection
                End If

                If Me._registrationTableAdapter IsNot Nothing AndAlso Me._registrationTableAdapter.Connection IsNot Nothing Then
                    Return Me._registrationTableAdapter.Connection
                End If

                If Me._restaurantPOS_BillingInfoEBTableAdapter IsNot Nothing AndAlso Me._restaurantPOS_BillingInfoEBTableAdapter.Connection IsNot Nothing Then
                    Return Me._restaurantPOS_BillingInfoEBTableAdapter.Connection
                End If

                If Me._restaurantPOS_BillingInfoHDTableAdapter IsNot Nothing AndAlso Me._restaurantPOS_BillingInfoHDTableAdapter.Connection IsNot Nothing Then
                    Return Me._restaurantPOS_BillingInfoHDTableAdapter.Connection
                End If

                If Me._restaurantPOS_BillingInfoKOTTableAdapter IsNot Nothing AndAlso Me._restaurantPOS_BillingInfoKOTTableAdapter.Connection IsNot Nothing Then
                    Return Me._restaurantPOS_BillingInfoKOTTableAdapter.Connection
                End If

                If Me._restaurantPOS_BillingInfoTATableAdapter IsNot Nothing AndAlso Me._restaurantPOS_BillingInfoTATableAdapter.Connection IsNot Nothing Then
                    Return Me._restaurantPOS_BillingInfoTATableAdapter.Connection
                End If

                If Me._restaurantPOS_OrderedProductBillEBTableAdapter IsNot Nothing AndAlso Me._restaurantPOS_OrderedProductBillEBTableAdapter.Connection IsNot Nothing Then
                    Return Me._restaurantPOS_OrderedProductBillEBTableAdapter.Connection
                End If

                If Me._restaurantPOS_OrderedProductBillHDTableAdapter IsNot Nothing AndAlso Me._restaurantPOS_OrderedProductBillHDTableAdapter.Connection IsNot Nothing Then
                    Return Me._restaurantPOS_OrderedProductBillHDTableAdapter.Connection
                End If

                If Me._restaurantPOS_OrderedProductBillKOTTableAdapter IsNot Nothing AndAlso Me._restaurantPOS_OrderedProductBillKOTTableAdapter.Connection IsNot Nothing Then
                    Return Me._restaurantPOS_OrderedProductBillKOTTableAdapter.Connection
                End If

                If Me._restaurantPOS_OrderedProductBillTATableAdapter IsNot Nothing AndAlso Me._restaurantPOS_OrderedProductBillTATableAdapter.Connection IsNot Nothing Then
                    Return Me._restaurantPOS_OrderedProductBillTATableAdapter.Connection
                End If

                If Me._restaurantPOS_OrderedProductKOTTableAdapter IsNot Nothing AndAlso Me._restaurantPOS_OrderedProductKOTTableAdapter.Connection IsNot Nothing Then
                    Return Me._restaurantPOS_OrderedProductKOTTableAdapter.Connection
                End If

                If Me._restaurantPOS_OrderInfoKOTTableAdapter IsNot Nothing AndAlso Me._restaurantPOS_OrderInfoKOTTableAdapter.Connection IsNot Nothing Then
                    Return Me._restaurantPOS_OrderInfoKOTTableAdapter.Connection
                End If

                If Me._rM_UsedTableAdapter IsNot Nothing AndAlso Me._rM_UsedTableAdapter.Connection IsNot Nothing Then
                    Return Me._rM_UsedTableAdapter.Connection
                End If

                If Me._rM_Used_JoinTableAdapter IsNot Nothing AndAlso Me._rM_Used_JoinTableAdapter.Connection IsNot Nothing Then
                    Return Me._rM_Used_JoinTableAdapter.Connection
                End If

                If Me._rMCategoryTableAdapter IsNot Nothing AndAlso Me._rMCategoryTableAdapter.Connection IsNot Nothing Then
                    Return Me._rMCategoryTableAdapter.Connection
                End If

                If Me._sMSSettingTableAdapter IsNot Nothing AndAlso Me._sMSSettingTableAdapter.Connection IsNot Nothing Then
                    Return Me._sMSSettingTableAdapter.Connection
                End If

                If Me._stock_StoreTableAdapter IsNot Nothing AndAlso Me._stock_StoreTableAdapter.Connection IsNot Nothing Then
                    Return Me._stock_StoreTableAdapter.Connection
                End If

                If Me._stock_Store_JoinTableAdapter IsNot Nothing AndAlso Me._stock_Store_JoinTableAdapter.Connection IsNot Nothing Then
                    Return Me._stock_Store_JoinTableAdapter.Connection
                End If

                If Me._stockAdjustment_MITableAdapter IsNot Nothing AndAlso Me._stockAdjustment_MITableAdapter.Connection IsNot Nothing Then
                    Return Me._stockAdjustment_MITableAdapter.Connection
                End If

                If Me._stockAdjustment_StoreTableAdapter IsNot Nothing AndAlso Me._stockAdjustment_StoreTableAdapter.Connection IsNot Nothing Then
                    Return Me._stockAdjustment_StoreTableAdapter.Connection
                End If

                If Me._stockAdjustment_WarehouseTableAdapter IsNot Nothing AndAlso Me._stockAdjustment_WarehouseTableAdapter.Connection IsNot Nothing Then
                    Return Me._stockAdjustment_WarehouseTableAdapter.Connection
                End If

                If Me._stockTransferTableAdapter IsNot Nothing AndAlso Me._stockTransferTableAdapter.Connection IsNot Nothing Then
                    Return Me._stockTransferTableAdapter.Connection
                End If

                If Me._stockTransfer_JoinTableAdapter IsNot Nothing AndAlso Me._stockTransfer_JoinTableAdapter.Connection IsNot Nothing Then
                    Return Me._stockTransfer_JoinTableAdapter.Connection
                End If

                If Me._supplierTableAdapter IsNot Nothing AndAlso Me._supplierTableAdapter.Connection IsNot Nothing Then
                    Return Me._supplierTableAdapter.Connection
                End If

                If Me._supplierLedgerBookTableAdapter IsNot Nothing AndAlso Me._supplierLedgerBookTableAdapter.Connection IsNot Nothing Then
                    Return Me._supplierLedgerBookTableAdapter.Connection
                End If

                If Me._tableLayoutTableAdapter IsNot Nothing AndAlso Me._tableLayoutTableAdapter.Connection IsNot Nothing Then
                    Return Me._tableLayoutTableAdapter.Connection
                End If

                If Me._tableMappingTableAdapter IsNot Nothing AndAlso Me._tableMappingTableAdapter.Connection IsNot Nothing Then
                    Return Me._tableMappingTableAdapter.Connection
                End If

                If Me._tableReservationTableAdapter IsNot Nothing AndAlso Me._tableReservationTableAdapter.Connection IsNot Nothing Then
                    Return Me._tableReservationTableAdapter.Connection
                End If

                If Me._tblOrderTableAdapter IsNot Nothing AndAlso Me._tblOrderTableAdapter.Connection IsNot Nothing Then
                    Return Me._tblOrderTableAdapter.Connection
                End If

                If Me._temp_StockTableAdapter IsNot Nothing AndAlso Me._temp_StockTableAdapter.Connection IsNot Nothing Then
                    Return Me._temp_StockTableAdapter.Connection
                End If

                If Me._temp_Stock_RMTableAdapter IsNot Nothing AndAlso Me._temp_Stock_RMTableAdapter.Connection IsNot Nothing Then
                    Return Me._temp_Stock_RMTableAdapter.Connection
                End If

                If Me._temp_Stock_StoreTableAdapter IsNot Nothing AndAlso Me._temp_Stock_StoreTableAdapter.Connection IsNot Nothing Then
                    Return Me._temp_Stock_StoreTableAdapter.Connection
                End If

                If Me._tempRestaurantPOS_BillingInfoKOTTableAdapter IsNot Nothing AndAlso Me._tempRestaurantPOS_BillingInfoKOTTableAdapter.Connection IsNot Nothing Then
                    Return Me._tempRestaurantPOS_BillingInfoKOTTableAdapter.Connection
                End If

                If Me._tempRestaurantPOS_OrderedProductBillKOTTableAdapter IsNot Nothing AndAlso Me._tempRestaurantPOS_OrderedProductBillKOTTableAdapter.Connection IsNot Nothing Then
                    Return Me._tempRestaurantPOS_OrderedProductBillKOTTableAdapter.Connection
                End If

                If Me._unitMasterTableAdapter IsNot Nothing AndAlso Me._unitMasterTableAdapter.Connection IsNot Nothing Then
                    Return Me._unitMasterTableAdapter.Connection
                End If

                If Me._userRightsTableAdapter IsNot Nothing AndAlso Me._userRightsTableAdapter.Connection IsNot Nothing Then
                    Return Me._userRightsTableAdapter.Connection
                End If

                If Me._voucherTableAdapter IsNot Nothing AndAlso Me._voucherTableAdapter.Connection IsNot Nothing Then
                    Return Me._voucherTableAdapter.Connection
                End If

                If Me._voucher_OtherDetailsTableAdapter IsNot Nothing AndAlso Me._voucher_OtherDetailsTableAdapter.Connection IsNot Nothing Then
                    Return Me._voucher_OtherDetailsTableAdapter.Connection
                End If

                If Me._walletTableAdapter IsNot Nothing AndAlso Me._walletTableAdapter.Connection IsNot Nothing Then
                    Return Me._walletTableAdapter.Connection
                End If

                If Me._warehouseTableAdapter IsNot Nothing AndAlso Me._warehouseTableAdapter.Connection IsNot Nothing Then
                    Return Me._warehouseTableAdapter.Connection
                End If

                If Me._warehouseTypeTableAdapter IsNot Nothing AndAlso Me._warehouseTypeTableAdapter.Connection IsNot Nothing Then
                    Return Me._warehouseTypeTableAdapter.Connection
                End If

                If Me._workPeriodEndTableAdapter IsNot Nothing AndAlso Me._workPeriodEndTableAdapter.Connection IsNot Nothing Then
                    Return Me._workPeriodEndTableAdapter.Connection
                End If

                If Me._workPeriodStartTableAdapter IsNot Nothing AndAlso Me._workPeriodStartTableAdapter.Connection IsNot Nothing Then
                    Return Me._workPeriodStartTableAdapter.Connection
                End If

                Return Nothing
            End Get

            Set(value As System.Data.IDbConnection)
                Me._connection = value
            End Set
        End Property

        <System.ComponentModel.BrowsableAttribute(False)>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public ReadOnly Property TableAdapterInstanceCount As Integer
            Get
                Dim num As Integer = 0
                If Me._activationTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._bankTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._bankAccountLedgerTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._bankAccountRegistrationTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._bankBranchTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._categoryTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._clockINTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._clockOUTTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._cMISettingTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._creditCustomerTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._creditCustomerLedgerTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._creditCustomerPaymentTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._currencyTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._deletedInvoicesTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._deletedInvoices_JoinTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._dishTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._emailSettingTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._employeeRegistrationTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._expenseTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._expenseTypeTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._fundDepositTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._fundTransferTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._giftCardTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._gridGroupingTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._hDCustomerTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._holdBillTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._holdItemsTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._hotelTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._journalTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._kitchenTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._ledgerBookTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._logsTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._loyaltyMemberTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._loyaltyMemberLedgerBookTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._loyaltySettingTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._memberTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._memberLedgerTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._modifiersTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._mpesaSettingTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._notesMasterTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._otherSettingTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._paymentTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._payment_WithdrawTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._payrollTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._payroll_MBTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._pizzaMasterTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._pizzaModifierTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._pizzaSizeTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._pizzaToppingTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._posGroupingTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._posGrouping1TableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._posPrinterSettingTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._productTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._product_OpeningStockTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._promotionTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._purchaseTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._purchase_JoinTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._purchaseOrderTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._purchaseOrder_JoinTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._r_TableTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._recipeTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._recipe_JoinTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._registrationTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._restaurantPOS_BillingInfoEBTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._restaurantPOS_BillingInfoHDTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._restaurantPOS_BillingInfoKOTTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._restaurantPOS_BillingInfoTATableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._restaurantPOS_OrderedProductBillEBTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._restaurantPOS_OrderedProductBillHDTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._restaurantPOS_OrderedProductBillKOTTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._restaurantPOS_OrderedProductBillTATableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._restaurantPOS_OrderedProductKOTTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._restaurantPOS_OrderInfoKOTTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._rM_UsedTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._rM_Used_JoinTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._rMCategoryTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._sMSSettingTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._stock_StoreTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._stock_Store_JoinTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._stockAdjustment_MITableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._stockAdjustment_StoreTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._stockAdjustment_WarehouseTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._stockTransferTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._stockTransfer_JoinTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._supplierTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._supplierLedgerBookTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._tableLayoutTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._tableMappingTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._tableReservationTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._tblOrderTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._temp_StockTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._temp_Stock_RMTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._temp_Stock_StoreTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._tempRestaurantPOS_BillingInfoKOTTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._tempRestaurantPOS_OrderedProductBillKOTTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._unitMasterTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._userRightsTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._voucherTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._voucher_OtherDetailsTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._walletTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._warehouseTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._warehouseTypeTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._workPeriodEndTableAdapter IsNot Nothing Then
                    num += 1
                End If

                If Me._workPeriodStartTableAdapter IsNot Nothing Then
                    num += 1
                End If

                Return num
            End Get
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            Call RestaurantPOS14.RPOS_DBDataSet1TableAdapters.TableAdapterManager.__ENCAddToList(Me)
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.RPOS_DBDataSet1TableAdapters.TableAdapterManager.__ENCList
                If RestaurantPOS14.RPOS_DBDataSet1TableAdapters.TableAdapterManager.__ENCList.Count = RestaurantPOS14.RPOS_DBDataSet1TableAdapters.TableAdapterManager.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.RPOS_DBDataSet1TableAdapters.TableAdapterManager.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.RPOS_DBDataSet1TableAdapters.TableAdapterManager.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.RPOS_DBDataSet1TableAdapters.TableAdapterManager.__ENCList(num) = RestaurantPOS14.RPOS_DBDataSet1TableAdapters.TableAdapterManager.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.RPOS_DBDataSet1TableAdapters.TableAdapterManager.__ENCList.RemoveRange(num, RestaurantPOS14.RPOS_DBDataSet1TableAdapters.TableAdapterManager.__ENCList.Count - num)
                    RestaurantPOS14.RPOS_DBDataSet1TableAdapters.TableAdapterManager.__ENCList.Capacity = RestaurantPOS14.RPOS_DBDataSet1TableAdapters.TableAdapterManager.__ENCList.Count
                End If

                Call RestaurantPOS14.RPOS_DBDataSet1TableAdapters.TableAdapterManager.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Function UpdateUpdatedRows(dataSet As RestaurantPOS14.RPOS_DBDataSet1, allChangedRows As System.Collections.Generic.List(Of System.Data.DataRow), allAddedRows As System.Collections.Generic.List(Of System.Data.DataRow)) As Integer
            Dim num As Integer = 0
            If Me._kitchenTableAdapter IsNot Nothing Then
                Dim array As System.Data.DataRow() = dataSet.Kitchen.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array = Me.GetRealUpdatedRows(array, allAddedRows)
                If array IsNot Nothing AndAlso array.Length <> 0 Then
                    num += Me._kitchenTableAdapter.Update(array)
                    allChangedRows.AddRange(array)
                End If
            End If

            If Me._categoryTableAdapter IsNot Nothing Then
                Dim array2 As System.Data.DataRow() = dataSet.Category.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array2 = Me.GetRealUpdatedRows(array2, allAddedRows)
                If array2 IsNot Nothing AndAlso array2.Length <> 0 Then
                    num += Me._categoryTableAdapter.Update(array2)
                    allChangedRows.AddRange(array2)
                End If
            End If

            If Me._bankTableAdapter IsNot Nothing Then
                Dim array3 As System.Data.DataRow() = dataSet.Bank.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array3 = Me.GetRealUpdatedRows(array3, allAddedRows)
                If array3 IsNot Nothing AndAlso array3.Length <> 0 Then
                    num += Me._bankTableAdapter.Update(array3)
                    allChangedRows.AddRange(array3)
                End If
            End If

            If Me._expenseTypeTableAdapter IsNot Nothing Then
                Dim array4 As System.Data.DataRow() = dataSet.ExpenseType.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array4 = Me.GetRealUpdatedRows(array4, allAddedRows)
                If array4 IsNot Nothing AndAlso array4.Length <> 0 Then
                    num += Me._expenseTypeTableAdapter.Update(array4)
                    allChangedRows.AddRange(array4)
                End If
            End If

            If Me._unitMasterTableAdapter IsNot Nothing Then
                Dim array5 As System.Data.DataRow() = dataSet.UnitMaster.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array5 = Me.GetRealUpdatedRows(array5, allAddedRows)
                If array5 IsNot Nothing AndAlso array5.Length <> 0 Then
                    num += Me._unitMasterTableAdapter.Update(array5)
                    allChangedRows.AddRange(array5)
                End If
            End If

            If Me._dishTableAdapter IsNot Nothing Then
                Dim array6 As System.Data.DataRow() = dataSet.Dish.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array6 = Me.GetRealUpdatedRows(array6, allAddedRows)
                If array6 IsNot Nothing AndAlso array6.Length <> 0 Then
                    num += Me._dishTableAdapter.Update(array6)
                    allChangedRows.AddRange(array6)
                End If
            End If

            If Me._employeeRegistrationTableAdapter IsNot Nothing Then
                Dim array7 As System.Data.DataRow() = dataSet.EmployeeRegistration.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array7 = Me.GetRealUpdatedRows(array7, allAddedRows)
                If array7 IsNot Nothing AndAlso array7.Length <> 0 Then
                    num += Me._employeeRegistrationTableAdapter.Update(array7)
                    allChangedRows.AddRange(array7)
                End If
            End If

            If Me._rMCategoryTableAdapter IsNot Nothing Then
                Dim array8 As System.Data.DataRow() = dataSet.RMCategory.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array8 = Me.GetRealUpdatedRows(array8, allAddedRows)
                If array8 IsNot Nothing AndAlso array8.Length <> 0 Then
                    num += Me._rMCategoryTableAdapter.Update(array8)
                    allChangedRows.AddRange(array8)
                End If
            End If

            If Me._pizzaSizeTableAdapter IsNot Nothing Then
                Dim array9 As System.Data.DataRow() = dataSet.PizzaSize.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array9 = Me.GetRealUpdatedRows(array9, allAddedRows)
                If array9 IsNot Nothing AndAlso array9.Length <> 0 Then
                    num += Me._pizzaSizeTableAdapter.Update(array9)
                    allChangedRows.AddRange(array9)
                End If
            End If

            If Me._r_TableTableAdapter IsNot Nothing Then
                Dim array10 As System.Data.DataRow() = dataSet.R_Table.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array10 = Me.GetRealUpdatedRows(array10, allAddedRows)
                If array10 IsNot Nothing AndAlso array10.Length <> 0 Then
                    num += Me._r_TableTableAdapter.Update(array10)
                    allChangedRows.AddRange(array10)
                End If
            End If

            If Me._registrationTableAdapter IsNot Nothing Then
                Dim array11 As System.Data.DataRow() = dataSet.Registration.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array11 = Me.GetRealUpdatedRows(array11, allAddedRows)
                If array11 IsNot Nothing AndAlso array11.Length <> 0 Then
                    num += Me._registrationTableAdapter.Update(array11)
                    allChangedRows.AddRange(array11)
                End If
            End If

            If Me._bankBranchTableAdapter IsNot Nothing Then
                Dim array12 As System.Data.DataRow() = dataSet.BankBranch.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array12 = Me.GetRealUpdatedRows(array12, allAddedRows)
                If array12 IsNot Nothing AndAlso array12.Length <> 0 Then
                    num += Me._bankBranchTableAdapter.Update(array12)
                    allChangedRows.AddRange(array12)
                End If
            End If

            If Me._supplierTableAdapter IsNot Nothing Then
                Dim array13 As System.Data.DataRow() = dataSet.Supplier.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array13 = Me.GetRealUpdatedRows(array13, allAddedRows)
                If array13 IsNot Nothing AndAlso array13.Length <> 0 Then
                    num += Me._supplierTableAdapter.Update(array13)
                    allChangedRows.AddRange(array13)
                End If
            End If

            If Me._warehouseTypeTableAdapter IsNot Nothing Then
                Dim array14 As System.Data.DataRow() = dataSet.WarehouseType.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array14 = Me.GetRealUpdatedRows(array14, allAddedRows)
                If array14 IsNot Nothing AndAlso array14.Length <> 0 Then
                    num += Me._warehouseTypeTableAdapter.Update(array14)
                    allChangedRows.AddRange(array14)
                End If
            End If

            If Me._productTableAdapter IsNot Nothing Then
                Dim array15 As System.Data.DataRow() = dataSet.Product.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array15 = Me.GetRealUpdatedRows(array15, allAddedRows)
                If array15 IsNot Nothing AndAlso array15.Length <> 0 Then
                    num += Me._productTableAdapter.Update(array15)
                    allChangedRows.AddRange(array15)
                End If
            End If

            If Me._clockINTableAdapter IsNot Nothing Then
                Dim array16 As System.Data.DataRow() = dataSet.ClockIN.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array16 = Me.GetRealUpdatedRows(array16, allAddedRows)
                If array16 IsNot Nothing AndAlso array16.Length <> 0 Then
                    num += Me._clockINTableAdapter.Update(array16)
                    allChangedRows.AddRange(array16)
                End If
            End If

            If Me._rM_UsedTableAdapter IsNot Nothing Then
                Dim array17 As System.Data.DataRow() = dataSet.RM_Used.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array17 = Me.GetRealUpdatedRows(array17, allAddedRows)
                If array17 IsNot Nothing AndAlso array17.Length <> 0 Then
                    num += Me._rM_UsedTableAdapter.Update(array17)
                    allChangedRows.AddRange(array17)
                End If
            End If

            If Me._restaurantPOS_BillingInfoTATableAdapter IsNot Nothing Then
                Dim array18 As System.Data.DataRow() = dataSet.RestaurantPOS_BillingInfoTA.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array18 = Me.GetRealUpdatedRows(array18, allAddedRows)
                If array18 IsNot Nothing AndAlso array18.Length <> 0 Then
                    num += Me._restaurantPOS_BillingInfoTATableAdapter.Update(array18)
                    allChangedRows.AddRange(array18)
                End If
            End If

            If Me._loyaltyMemberTableAdapter IsNot Nothing Then
                Dim array19 As System.Data.DataRow() = dataSet.LoyaltyMember.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array19 = Me.GetRealUpdatedRows(array19, allAddedRows)
                If array19 IsNot Nothing AndAlso array19.Length <> 0 Then
                    num += Me._loyaltyMemberTableAdapter.Update(array19)
                    allChangedRows.AddRange(array19)
                End If
            End If

            If Me._restaurantPOS_OrderInfoKOTTableAdapter IsNot Nothing Then
                Dim array20 As System.Data.DataRow() = dataSet.RestaurantPOS_OrderInfoKOT.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array20 = Me.GetRealUpdatedRows(array20, allAddedRows)
                If array20 IsNot Nothing AndAlso array20.Length <> 0 Then
                    num += Me._restaurantPOS_OrderInfoKOTTableAdapter.Update(array20)
                    allChangedRows.AddRange(array20)
                End If
            End If

            If Me._stock_StoreTableAdapter IsNot Nothing Then
                Dim array21 As System.Data.DataRow() = dataSet.Stock_Store.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array21 = Me.GetRealUpdatedRows(array21, allAddedRows)
                If array21 IsNot Nothing AndAlso array21.Length <> 0 Then
                    num += Me._stock_StoreTableAdapter.Update(array21)
                    allChangedRows.AddRange(array21)
                End If
            End If

            If Me._pizzaMasterTableAdapter IsNot Nothing Then
                Dim array22 As System.Data.DataRow() = dataSet.PizzaMaster.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array22 = Me.GetRealUpdatedRows(array22, allAddedRows)
                If array22 IsNot Nothing AndAlso array22.Length <> 0 Then
                    num += Me._pizzaMasterTableAdapter.Update(array22)
                    allChangedRows.AddRange(array22)
                End If
            End If

            If Me._bankAccountRegistrationTableAdapter IsNot Nothing Then
                Dim array23 As System.Data.DataRow() = dataSet.BankAccountRegistration.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array23 = Me.GetRealUpdatedRows(array23, allAddedRows)
                If array23 IsNot Nothing AndAlso array23.Length <> 0 Then
                    num += Me._bankAccountRegistrationTableAdapter.Update(array23)
                    allChangedRows.AddRange(array23)
                End If
            End If

            If Me._stockTransferTableAdapter IsNot Nothing Then
                Dim array24 As System.Data.DataRow() = dataSet.StockTransfer.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array24 = Me.GetRealUpdatedRows(array24, allAddedRows)
                If array24 IsNot Nothing AndAlso array24.Length <> 0 Then
                    num += Me._stockTransferTableAdapter.Update(array24)
                    allChangedRows.AddRange(array24)
                End If
            End If

            If Me._memberTableAdapter IsNot Nothing Then
                Dim array25 As System.Data.DataRow() = dataSet.Member.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array25 = Me.GetRealUpdatedRows(array25, allAddedRows)
                If array25 IsNot Nothing AndAlso array25.Length <> 0 Then
                    num += Me._memberTableAdapter.Update(array25)
                    allChangedRows.AddRange(array25)
                End If
            End If

            If Me._purchaseTableAdapter IsNot Nothing Then
                Dim array26 As System.Data.DataRow() = dataSet.Purchase.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array26 = Me.GetRealUpdatedRows(array26, allAddedRows)
                If array26 IsNot Nothing AndAlso array26.Length <> 0 Then
                    num += Me._purchaseTableAdapter.Update(array26)
                    allChangedRows.AddRange(array26)
                End If
            End If

            If Me._warehouseTableAdapter IsNot Nothing Then
                Dim array27 As System.Data.DataRow() = dataSet.Warehouse.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array27 = Me.GetRealUpdatedRows(array27, allAddedRows)
                If array27 IsNot Nothing AndAlso array27.Length <> 0 Then
                    num += Me._warehouseTableAdapter.Update(array27)
                    allChangedRows.AddRange(array27)
                End If
            End If

            If Me._creditCustomerTableAdapter IsNot Nothing Then
                Dim array28 As System.Data.DataRow() = dataSet.CreditCustomer.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array28 = Me.GetRealUpdatedRows(array28, allAddedRows)
                If array28 IsNot Nothing AndAlso array28.Length <> 0 Then
                    num += Me._creditCustomerTableAdapter.Update(array28)
                    allChangedRows.AddRange(array28)
                End If
            End If

            If Me._expenseTableAdapter IsNot Nothing Then
                Dim array29 As System.Data.DataRow() = dataSet.Expense.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array29 = Me.GetRealUpdatedRows(array29, allAddedRows)
                If array29 IsNot Nothing AndAlso array29.Length <> 0 Then
                    num += Me._expenseTableAdapter.Update(array29)
                    allChangedRows.AddRange(array29)
                End If
            End If

            If Me._workPeriodStartTableAdapter IsNot Nothing Then
                Dim array30 As System.Data.DataRow() = dataSet.WorkPeriodStart.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array30 = Me.GetRealUpdatedRows(array30, allAddedRows)
                If array30 IsNot Nothing AndAlso array30.Length <> 0 Then
                    num += Me._workPeriodStartTableAdapter.Update(array30)
                    allChangedRows.AddRange(array30)
                End If
            End If

            If Me._voucherTableAdapter IsNot Nothing Then
                Dim array31 As System.Data.DataRow() = dataSet.Voucher.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array31 = Me.GetRealUpdatedRows(array31, allAddedRows)
                If array31 IsNot Nothing AndAlso array31.Length <> 0 Then
                    num += Me._voucherTableAdapter.Update(array31)
                    allChangedRows.AddRange(array31)
                End If
            End If

            If Me._restaurantPOS_BillingInfoEBTableAdapter IsNot Nothing Then
                Dim array32 As System.Data.DataRow() = dataSet.RestaurantPOS_BillingInfoEB.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array32 = Me.GetRealUpdatedRows(array32, allAddedRows)
                If array32 IsNot Nothing AndAlso array32.Length <> 0 Then
                    num += Me._restaurantPOS_BillingInfoEBTableAdapter.Update(array32)
                    allChangedRows.AddRange(array32)
                End If
            End If

            If Me._tempRestaurantPOS_BillingInfoKOTTableAdapter IsNot Nothing Then
                Dim array33 As System.Data.DataRow() = dataSet.TempRestaurantPOS_BillingInfoKOT.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array33 = Me.GetRealUpdatedRows(array33, allAddedRows)
                If array33 IsNot Nothing AndAlso array33.Length <> 0 Then
                    num += Me._tempRestaurantPOS_BillingInfoKOTTableAdapter.Update(array33)
                    allChangedRows.AddRange(array33)
                End If
            End If

            If Me._purchaseOrderTableAdapter IsNot Nothing Then
                Dim array34 As System.Data.DataRow() = dataSet.PurchaseOrder.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array34 = Me.GetRealUpdatedRows(array34, allAddedRows)
                If array34 IsNot Nothing AndAlso array34.Length <> 0 Then
                    num += Me._purchaseOrderTableAdapter.Update(array34)
                    allChangedRows.AddRange(array34)
                End If
            End If

            If Me._restaurantPOS_BillingInfoHDTableAdapter IsNot Nothing Then
                Dim array35 As System.Data.DataRow() = dataSet.RestaurantPOS_BillingInfoHD.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array35 = Me.GetRealUpdatedRows(array35, allAddedRows)
                If array35 IsNot Nothing AndAlso array35.Length <> 0 Then
                    num += Me._restaurantPOS_BillingInfoHDTableAdapter.Update(array35)
                    allChangedRows.AddRange(array35)
                End If
            End If

            If Me._recipeTableAdapter IsNot Nothing Then
                Dim array36 As System.Data.DataRow() = dataSet.Recipe.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array36 = Me.GetRealUpdatedRows(array36, allAddedRows)
                If array36 IsNot Nothing AndAlso array36.Length <> 0 Then
                    num += Me._recipeTableAdapter.Update(array36)
                    allChangedRows.AddRange(array36)
                End If
            End If

            If Me._restaurantPOS_BillingInfoKOTTableAdapter IsNot Nothing Then
                Dim array37 As System.Data.DataRow() = dataSet.RestaurantPOS_BillingInfoKOT.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array37 = Me.GetRealUpdatedRows(array37, allAddedRows)
                If array37 IsNot Nothing AndAlso array37.Length <> 0 Then
                    num += Me._restaurantPOS_BillingInfoKOTTableAdapter.Update(array37)
                    allChangedRows.AddRange(array37)
                End If
            End If

            If Me._walletTableAdapter IsNot Nothing Then
                Dim array38 As System.Data.DataRow() = dataSet.Wallet.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array38 = Me.GetRealUpdatedRows(array38, allAddedRows)
                If array38 IsNot Nothing AndAlso array38.Length <> 0 Then
                    num += Me._walletTableAdapter.Update(array38)
                    allChangedRows.AddRange(array38)
                End If
            End If

            If Me._restaurantPOS_OrderedProductBillEBTableAdapter IsNot Nothing Then
                Dim array39 As System.Data.DataRow() = dataSet.RestaurantPOS_OrderedProductBillEB.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array39 = Me.GetRealUpdatedRows(array39, allAddedRows)
                If array39 IsNot Nothing AndAlso array39.Length <> 0 Then
                    num += Me._restaurantPOS_OrderedProductBillEBTableAdapter.Update(array39)
                    allChangedRows.AddRange(array39)
                End If
            End If

            If Me._restaurantPOS_OrderedProductBillHDTableAdapter IsNot Nothing Then
                Dim array40 As System.Data.DataRow() = dataSet.RestaurantPOS_OrderedProductBillHD.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array40 = Me.GetRealUpdatedRows(array40, allAddedRows)
                If array40 IsNot Nothing AndAlso array40.Length <> 0 Then
                    num += Me._restaurantPOS_OrderedProductBillHDTableAdapter.Update(array40)
                    allChangedRows.AddRange(array40)
                End If
            End If

            If Me._restaurantPOS_OrderedProductBillKOTTableAdapter IsNot Nothing Then
                Dim array41 As System.Data.DataRow() = dataSet.RestaurantPOS_OrderedProductBillKOT.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array41 = Me.GetRealUpdatedRows(array41, allAddedRows)
                If array41 IsNot Nothing AndAlso array41.Length <> 0 Then
                    num += Me._restaurantPOS_OrderedProductBillKOTTableAdapter.Update(array41)
                    allChangedRows.AddRange(array41)
                End If
            End If

            If Me._restaurantPOS_OrderedProductBillTATableAdapter IsNot Nothing Then
                Dim array42 As System.Data.DataRow() = dataSet.RestaurantPOS_OrderedProductBillTA.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array42 = Me.GetRealUpdatedRows(array42, allAddedRows)
                If array42 IsNot Nothing AndAlso array42.Length <> 0 Then
                    num += Me._restaurantPOS_OrderedProductBillTATableAdapter.Update(array42)
                    allChangedRows.AddRange(array42)
                End If
            End If

            If Me._activationTableAdapter IsNot Nothing Then
                Dim array43 As System.Data.DataRow() = dataSet.Activation.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array43 = Me.GetRealUpdatedRows(array43, allAddedRows)
                If array43 IsNot Nothing AndAlso array43.Length <> 0 Then
                    num += Me._activationTableAdapter.Update(array43)
                    allChangedRows.AddRange(array43)
                End If
            End If

            If Me._restaurantPOS_OrderedProductKOTTableAdapter IsNot Nothing Then
                Dim array44 As System.Data.DataRow() = dataSet.RestaurantPOS_OrderedProductKOT.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array44 = Me.GetRealUpdatedRows(array44, allAddedRows)
                If array44 IsNot Nothing AndAlso array44.Length <> 0 Then
                    num += Me._restaurantPOS_OrderedProductKOTTableAdapter.Update(array44)
                    allChangedRows.AddRange(array44)
                End If
            End If

            If Me._temp_StockTableAdapter IsNot Nothing Then
                Dim array45 As System.Data.DataRow() = dataSet.Temp_Stock.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array45 = Me.GetRealUpdatedRows(array45, allAddedRows)
                If array45 IsNot Nothing AndAlso array45.Length <> 0 Then
                    num += Me._temp_StockTableAdapter.Update(array45)
                    allChangedRows.AddRange(array45)
                End If
            End If

            If Me._temp_Stock_RMTableAdapter IsNot Nothing Then
                Dim array46 As System.Data.DataRow() = dataSet.Temp_Stock_RM.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array46 = Me.GetRealUpdatedRows(array46, allAddedRows)
                If array46 IsNot Nothing AndAlso array46.Length <> 0 Then
                    num += Me._temp_Stock_RMTableAdapter.Update(array46)
                    allChangedRows.AddRange(array46)
                End If
            End If

            If Me._tableReservationTableAdapter IsNot Nothing Then
                Dim array47 As System.Data.DataRow() = dataSet.TableReservation.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array47 = Me.GetRealUpdatedRows(array47, allAddedRows)
                If array47 IsNot Nothing AndAlso array47.Length <> 0 Then
                    num += Me._tableReservationTableAdapter.Update(array47)
                    allChangedRows.AddRange(array47)
                End If
            End If

            If Me._tblOrderTableAdapter IsNot Nothing Then
                Dim array48 As System.Data.DataRow() = dataSet.tblOrder.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array48 = Me.GetRealUpdatedRows(array48, allAddedRows)
                If array48 IsNot Nothing AndAlso array48.Length <> 0 Then
                    num += Me._tblOrderTableAdapter.Update(array48)
                    allChangedRows.AddRange(array48)
                End If
            End If

            If Me._temp_Stock_StoreTableAdapter IsNot Nothing Then
                Dim array49 As System.Data.DataRow() = dataSet.Temp_Stock_Store.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array49 = Me.GetRealUpdatedRows(array49, allAddedRows)
                If array49 IsNot Nothing AndAlso array49.Length <> 0 Then
                    num += Me._temp_Stock_StoreTableAdapter.Update(array49)
                    allChangedRows.AddRange(array49)
                End If
            End If

            If Me._userRightsTableAdapter IsNot Nothing Then
                Dim array50 As System.Data.DataRow() = dataSet.UserRights.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array50 = Me.GetRealUpdatedRows(array50, allAddedRows)
                If array50 IsNot Nothing AndAlso array50.Length <> 0 Then
                    num += Me._userRightsTableAdapter.Update(array50)
                    allChangedRows.AddRange(array50)
                End If
            End If

            If Me._voucher_OtherDetailsTableAdapter IsNot Nothing Then
                Dim array51 As System.Data.DataRow() = dataSet.Voucher_OtherDetails.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array51 = Me.GetRealUpdatedRows(array51, allAddedRows)
                If array51 IsNot Nothing AndAlso array51.Length <> 0 Then
                    num += Me._voucher_OtherDetailsTableAdapter.Update(array51)
                    allChangedRows.AddRange(array51)
                End If
            End If

            If Me._tempRestaurantPOS_OrderedProductBillKOTTableAdapter IsNot Nothing Then
                Dim array52 As System.Data.DataRow() = dataSet.TempRestaurantPOS_OrderedProductBillKOT.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array52 = Me.GetRealUpdatedRows(array52, allAddedRows)
                If array52 IsNot Nothing AndAlso array52.Length <> 0 Then
                    num += Me._tempRestaurantPOS_OrderedProductBillKOTTableAdapter.Update(array52)
                    allChangedRows.AddRange(array52)
                End If
            End If

            If Me._workPeriodEndTableAdapter IsNot Nothing Then
                Dim array53 As System.Data.DataRow() = dataSet.WorkPeriodEnd.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array53 = Me.GetRealUpdatedRows(array53, allAddedRows)
                If array53 IsNot Nothing AndAlso array53.Length <> 0 Then
                    num += Me._workPeriodEndTableAdapter.Update(array53)
                    allChangedRows.AddRange(array53)
                End If
            End If

            If Me._tableMappingTableAdapter IsNot Nothing Then
                Dim array54 As System.Data.DataRow() = dataSet.TableMapping.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array54 = Me.GetRealUpdatedRows(array54, allAddedRows)
                If array54 IsNot Nothing AndAlso array54.Length <> 0 Then
                    num += Me._tableMappingTableAdapter.Update(array54)
                    allChangedRows.AddRange(array54)
                End If
            End If

            If Me._stock_Store_JoinTableAdapter IsNot Nothing Then
                Dim array55 As System.Data.DataRow() = dataSet.Stock_Store_Join.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array55 = Me.GetRealUpdatedRows(array55, allAddedRows)
                If array55 IsNot Nothing AndAlso array55.Length <> 0 Then
                    num += Me._stock_Store_JoinTableAdapter.Update(array55)
                    allChangedRows.AddRange(array55)
                End If
            End If

            If Me._stockAdjustment_MITableAdapter IsNot Nothing Then
                Dim array56 As System.Data.DataRow() = dataSet.StockAdjustment_MI.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array56 = Me.GetRealUpdatedRows(array56, allAddedRows)
                If array56 IsNot Nothing AndAlso array56.Length <> 0 Then
                    num += Me._stockAdjustment_MITableAdapter.Update(array56)
                    allChangedRows.AddRange(array56)
                End If
            End If

            If Me._rM_Used_JoinTableAdapter IsNot Nothing Then
                Dim array57 As System.Data.DataRow() = dataSet.RM_Used_Join.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array57 = Me.GetRealUpdatedRows(array57, allAddedRows)
                If array57 IsNot Nothing AndAlso array57.Length <> 0 Then
                    num += Me._rM_Used_JoinTableAdapter.Update(array57)
                    allChangedRows.AddRange(array57)
                End If
            End If

            If Me._sMSSettingTableAdapter IsNot Nothing Then
                Dim array58 As System.Data.DataRow() = dataSet.SMSSetting.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array58 = Me.GetRealUpdatedRows(array58, allAddedRows)
                If array58 IsNot Nothing AndAlso array58.Length <> 0 Then
                    num += Me._sMSSettingTableAdapter.Update(array58)
                    allChangedRows.AddRange(array58)
                End If
            End If

            If Me._stockAdjustment_StoreTableAdapter IsNot Nothing Then
                Dim array59 As System.Data.DataRow() = dataSet.StockAdjustment_Store.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array59 = Me.GetRealUpdatedRows(array59, allAddedRows)
                If array59 IsNot Nothing AndAlso array59.Length <> 0 Then
                    num += Me._stockAdjustment_StoreTableAdapter.Update(array59)
                    allChangedRows.AddRange(array59)
                End If
            End If

            If Me._supplierLedgerBookTableAdapter IsNot Nothing Then
                Dim array60 As System.Data.DataRow() = dataSet.SupplierLedgerBook.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array60 = Me.GetRealUpdatedRows(array60, allAddedRows)
                If array60 IsNot Nothing AndAlso array60.Length <> 0 Then
                    num += Me._supplierLedgerBookTableAdapter.Update(array60)
                    allChangedRows.AddRange(array60)
                End If
            End If

            If Me._tableLayoutTableAdapter IsNot Nothing Then
                Dim array61 As System.Data.DataRow() = dataSet.TableLayout.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array61 = Me.GetRealUpdatedRows(array61, allAddedRows)
                If array61 IsNot Nothing AndAlso array61.Length <> 0 Then
                    num += Me._tableLayoutTableAdapter.Update(array61)
                    allChangedRows.AddRange(array61)
                End If
            End If

            If Me._stockAdjustment_WarehouseTableAdapter IsNot Nothing Then
                Dim array62 As System.Data.DataRow() = dataSet.StockAdjustment_Warehouse.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array62 = Me.GetRealUpdatedRows(array62, allAddedRows)
                If array62 IsNot Nothing AndAlso array62.Length <> 0 Then
                    num += Me._stockAdjustment_WarehouseTableAdapter.Update(array62)
                    allChangedRows.AddRange(array62)
                End If
            End If

            If Me._stockTransfer_JoinTableAdapter IsNot Nothing Then
                Dim array63 As System.Data.DataRow() = dataSet.StockTransfer_Join.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array63 = Me.GetRealUpdatedRows(array63, allAddedRows)
                If array63 IsNot Nothing AndAlso array63.Length <> 0 Then
                    num += Me._stockTransfer_JoinTableAdapter.Update(array63)
                    allChangedRows.AddRange(array63)
                End If
            End If

            If Me._hDCustomerTableAdapter IsNot Nothing Then
                Dim array64 As System.Data.DataRow() = dataSet.HDCustomer.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array64 = Me.GetRealUpdatedRows(array64, allAddedRows)
                If array64 IsNot Nothing AndAlso array64.Length <> 0 Then
                    num += Me._hDCustomerTableAdapter.Update(array64)
                    allChangedRows.AddRange(array64)
                End If
            End If

            If Me._holdBillTableAdapter IsNot Nothing Then
                Dim array65 As System.Data.DataRow() = dataSet.HoldBill.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array65 = Me.GetRealUpdatedRows(array65, allAddedRows)
                If array65 IsNot Nothing AndAlso array65.Length <> 0 Then
                    num += Me._holdBillTableAdapter.Update(array65)
                    allChangedRows.AddRange(array65)
                End If
            End If

            If Me._gridGroupingTableAdapter IsNot Nothing Then
                Dim array66 As System.Data.DataRow() = dataSet.GridGrouping.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array66 = Me.GetRealUpdatedRows(array66, allAddedRows)
                If array66 IsNot Nothing AndAlso array66.Length <> 0 Then
                    num += Me._gridGroupingTableAdapter.Update(array66)
                    allChangedRows.AddRange(array66)
                End If
            End If

            If Me._fundTransferTableAdapter IsNot Nothing Then
                Dim array67 As System.Data.DataRow() = dataSet.FundTransfer.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array67 = Me.GetRealUpdatedRows(array67, allAddedRows)
                If array67 IsNot Nothing AndAlso array67.Length <> 0 Then
                    num += Me._fundTransferTableAdapter.Update(array67)
                    allChangedRows.AddRange(array67)
                End If
            End If

            If Me._giftCardTableAdapter IsNot Nothing Then
                Dim array68 As System.Data.DataRow() = dataSet.GiftCard.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array68 = Me.GetRealUpdatedRows(array68, allAddedRows)
                If array68 IsNot Nothing AndAlso array68.Length <> 0 Then
                    num += Me._giftCardTableAdapter.Update(array68)
                    allChangedRows.AddRange(array68)
                End If
            End If

            If Me._ledgerBookTableAdapter IsNot Nothing Then
                Dim array69 As System.Data.DataRow() = dataSet.LedgerBook.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array69 = Me.GetRealUpdatedRows(array69, allAddedRows)
                If array69 IsNot Nothing AndAlso array69.Length <> 0 Then
                    num += Me._ledgerBookTableAdapter.Update(array69)
                    allChangedRows.AddRange(array69)
                End If
            End If

            If Me._logsTableAdapter IsNot Nothing Then
                Dim array70 As System.Data.DataRow() = dataSet.Logs.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array70 = Me.GetRealUpdatedRows(array70, allAddedRows)
                If array70 IsNot Nothing AndAlso array70.Length <> 0 Then
                    num += Me._logsTableAdapter.Update(array70)
                    allChangedRows.AddRange(array70)
                End If
            End If

            If Me._journalTableAdapter IsNot Nothing Then
                Dim array71 As System.Data.DataRow() = dataSet.Journal.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array71 = Me.GetRealUpdatedRows(array71, allAddedRows)
                If array71 IsNot Nothing AndAlso array71.Length <> 0 Then
                    num += Me._journalTableAdapter.Update(array71)
                    allChangedRows.AddRange(array71)
                End If
            End If

            If Me._holdItemsTableAdapter IsNot Nothing Then
                Dim array72 As System.Data.DataRow() = dataSet.HoldItems.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array72 = Me.GetRealUpdatedRows(array72, allAddedRows)
                If array72 IsNot Nothing AndAlso array72.Length <> 0 Then
                    num += Me._holdItemsTableAdapter.Update(array72)
                    allChangedRows.AddRange(array72)
                End If
            End If

            If Me._hotelTableAdapter IsNot Nothing Then
                Dim array73 As System.Data.DataRow() = dataSet.Hotel.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array73 = Me.GetRealUpdatedRows(array73, allAddedRows)
                If array73 IsNot Nothing AndAlso array73.Length <> 0 Then
                    num += Me._hotelTableAdapter.Update(array73)
                    allChangedRows.AddRange(array73)
                End If
            End If

            If Me._creditCustomerLedgerTableAdapter IsNot Nothing Then
                Dim array74 As System.Data.DataRow() = dataSet.CreditCustomerLedger.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array74 = Me.GetRealUpdatedRows(array74, allAddedRows)
                If array74 IsNot Nothing AndAlso array74.Length <> 0 Then
                    num += Me._creditCustomerLedgerTableAdapter.Update(array74)
                    allChangedRows.AddRange(array74)
                End If
            End If

            If Me._creditCustomerPaymentTableAdapter IsNot Nothing Then
                Dim array75 As System.Data.DataRow() = dataSet.CreditCustomerPayment.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array75 = Me.GetRealUpdatedRows(array75, allAddedRows)
                If array75 IsNot Nothing AndAlso array75.Length <> 0 Then
                    num += Me._creditCustomerPaymentTableAdapter.Update(array75)
                    allChangedRows.AddRange(array75)
                End If
            End If

            If Me._cMISettingTableAdapter IsNot Nothing Then
                Dim array76 As System.Data.DataRow() = dataSet.CMISetting.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array76 = Me.GetRealUpdatedRows(array76, allAddedRows)
                If array76 IsNot Nothing AndAlso array76.Length <> 0 Then
                    num += Me._cMISettingTableAdapter.Update(array76)
                    allChangedRows.AddRange(array76)
                End If
            End If

            If Me._bankAccountLedgerTableAdapter IsNot Nothing Then
                Dim array77 As System.Data.DataRow() = dataSet.BankAccountLedger.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array77 = Me.GetRealUpdatedRows(array77, allAddedRows)
                If array77 IsNot Nothing AndAlso array77.Length <> 0 Then
                    num += Me._bankAccountLedgerTableAdapter.Update(array77)
                    allChangedRows.AddRange(array77)
                End If
            End If

            If Me._clockOUTTableAdapter IsNot Nothing Then
                Dim array78 As System.Data.DataRow() = dataSet.ClockOUT.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array78 = Me.GetRealUpdatedRows(array78, allAddedRows)
                If array78 IsNot Nothing AndAlso array78.Length <> 0 Then
                    num += Me._clockOUTTableAdapter.Update(array78)
                    allChangedRows.AddRange(array78)
                End If
            End If

            If Me._emailSettingTableAdapter IsNot Nothing Then
                Dim array79 As System.Data.DataRow() = dataSet.EmailSetting.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array79 = Me.GetRealUpdatedRows(array79, allAddedRows)
                If array79 IsNot Nothing AndAlso array79.Length <> 0 Then
                    num += Me._emailSettingTableAdapter.Update(array79)
                    allChangedRows.AddRange(array79)
                End If
            End If

            If Me._fundDepositTableAdapter IsNot Nothing Then
                Dim array80 As System.Data.DataRow() = dataSet.FundDeposit.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array80 = Me.GetRealUpdatedRows(array80, allAddedRows)
                If array80 IsNot Nothing AndAlso array80.Length <> 0 Then
                    num += Me._fundDepositTableAdapter.Update(array80)
                    allChangedRows.AddRange(array80)
                End If
            End If

            If Me._deletedInvoices_JoinTableAdapter IsNot Nothing Then
                Dim array81 As System.Data.DataRow() = dataSet.DeletedInvoices_Join.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array81 = Me.GetRealUpdatedRows(array81, allAddedRows)
                If array81 IsNot Nothing AndAlso array81.Length <> 0 Then
                    num += Me._deletedInvoices_JoinTableAdapter.Update(array81)
                    allChangedRows.AddRange(array81)
                End If
            End If

            If Me._currencyTableAdapter IsNot Nothing Then
                Dim array82 As System.Data.DataRow() = dataSet.Currency.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array82 = Me.GetRealUpdatedRows(array82, allAddedRows)
                If array82 IsNot Nothing AndAlso array82.Length <> 0 Then
                    num += Me._currencyTableAdapter.Update(array82)
                    allChangedRows.AddRange(array82)
                End If
            End If

            If Me._deletedInvoicesTableAdapter IsNot Nothing Then
                Dim array83 As System.Data.DataRow() = dataSet.DeletedInvoices.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array83 = Me.GetRealUpdatedRows(array83, allAddedRows)
                If array83 IsNot Nothing AndAlso array83.Length <> 0 Then
                    num += Me._deletedInvoicesTableAdapter.Update(array83)
                    allChangedRows.AddRange(array83)
                End If
            End If

            If Me._loyaltyMemberLedgerBookTableAdapter IsNot Nothing Then
                Dim array84 As System.Data.DataRow() = dataSet.LoyaltyMemberLedgerBook.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array84 = Me.GetRealUpdatedRows(array84, allAddedRows)
                If array84 IsNot Nothing AndAlso array84.Length <> 0 Then
                    num += Me._loyaltyMemberLedgerBookTableAdapter.Update(array84)
                    allChangedRows.AddRange(array84)
                End If
            End If

            If Me._posGrouping1TableAdapter IsNot Nothing Then
                Dim array85 As System.Data.DataRow() = dataSet.PosGrouping1.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array85 = Me.GetRealUpdatedRows(array85, allAddedRows)
                If array85 IsNot Nothing AndAlso array85.Length <> 0 Then
                    num += Me._posGrouping1TableAdapter.Update(array85)
                    allChangedRows.AddRange(array85)
                End If
            End If

            If Me._posPrinterSettingTableAdapter IsNot Nothing Then
                Dim array86 As System.Data.DataRow() = dataSet.PosPrinterSetting.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array86 = Me.GetRealUpdatedRows(array86, allAddedRows)
                If array86 IsNot Nothing AndAlso array86.Length <> 0 Then
                    num += Me._posPrinterSettingTableAdapter.Update(array86)
                    allChangedRows.AddRange(array86)
                End If
            End If

            If Me._posGroupingTableAdapter IsNot Nothing Then
                Dim array87 As System.Data.DataRow() = dataSet.PosGrouping.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array87 = Me.GetRealUpdatedRows(array87, allAddedRows)
                If array87 IsNot Nothing AndAlso array87.Length <> 0 Then
                    num += Me._posGroupingTableAdapter.Update(array87)
                    allChangedRows.AddRange(array87)
                End If
            End If

            If Me._pizzaModifierTableAdapter IsNot Nothing Then
                Dim array88 As System.Data.DataRow() = dataSet.PizzaModifier.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array88 = Me.GetRealUpdatedRows(array88, allAddedRows)
                If array88 IsNot Nothing AndAlso array88.Length <> 0 Then
                    num += Me._pizzaModifierTableAdapter.Update(array88)
                    allChangedRows.AddRange(array88)
                End If
            End If

            If Me._pizzaToppingTableAdapter IsNot Nothing Then
                Dim array89 As System.Data.DataRow() = dataSet.PizzaTopping.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array89 = Me.GetRealUpdatedRows(array89, allAddedRows)
                If array89 IsNot Nothing AndAlso array89.Length <> 0 Then
                    num += Me._pizzaToppingTableAdapter.Update(array89)
                    allChangedRows.AddRange(array89)
                End If
            End If

            If Me._purchaseOrder_JoinTableAdapter IsNot Nothing Then
                Dim array90 As System.Data.DataRow() = dataSet.PurchaseOrder_Join.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array90 = Me.GetRealUpdatedRows(array90, allAddedRows)
                If array90 IsNot Nothing AndAlso array90.Length <> 0 Then
                    num += Me._purchaseOrder_JoinTableAdapter.Update(array90)
                    allChangedRows.AddRange(array90)
                End If
            End If

            If Me._recipe_JoinTableAdapter IsNot Nothing Then
                Dim array91 As System.Data.DataRow() = dataSet.Recipe_Join.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array91 = Me.GetRealUpdatedRows(array91, allAddedRows)
                If array91 IsNot Nothing AndAlso array91.Length <> 0 Then
                    num += Me._recipe_JoinTableAdapter.Update(array91)
                    allChangedRows.AddRange(array91)
                End If
            End If

            If Me._purchase_JoinTableAdapter IsNot Nothing Then
                Dim array92 As System.Data.DataRow() = dataSet.Purchase_Join.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array92 = Me.GetRealUpdatedRows(array92, allAddedRows)
                If array92 IsNot Nothing AndAlso array92.Length <> 0 Then
                    num += Me._purchase_JoinTableAdapter.Update(array92)
                    allChangedRows.AddRange(array92)
                End If
            End If

            If Me._product_OpeningStockTableAdapter IsNot Nothing Then
                Dim array93 As System.Data.DataRow() = dataSet.Product_OpeningStock.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array93 = Me.GetRealUpdatedRows(array93, allAddedRows)
                If array93 IsNot Nothing AndAlso array93.Length <> 0 Then
                    num += Me._product_OpeningStockTableAdapter.Update(array93)
                    allChangedRows.AddRange(array93)
                End If
            End If

            If Me._promotionTableAdapter IsNot Nothing Then
                Dim array94 As System.Data.DataRow() = dataSet.Promotion.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array94 = Me.GetRealUpdatedRows(array94, allAddedRows)
                If array94 IsNot Nothing AndAlso array94.Length <> 0 Then
                    num += Me._promotionTableAdapter.Update(array94)
                    allChangedRows.AddRange(array94)
                End If
            End If

            If Me._mpesaSettingTableAdapter IsNot Nothing Then
                Dim array95 As System.Data.DataRow() = dataSet.MpesaSetting.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array95 = Me.GetRealUpdatedRows(array95, allAddedRows)
                If array95 IsNot Nothing AndAlso array95.Length <> 0 Then
                    num += Me._mpesaSettingTableAdapter.Update(array95)
                    allChangedRows.AddRange(array95)
                End If
            End If

            If Me._notesMasterTableAdapter IsNot Nothing Then
                Dim array96 As System.Data.DataRow() = dataSet.NotesMaster.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array96 = Me.GetRealUpdatedRows(array96, allAddedRows)
                If array96 IsNot Nothing AndAlso array96.Length <> 0 Then
                    num += Me._notesMasterTableAdapter.Update(array96)
                    allChangedRows.AddRange(array96)
                End If
            End If

            If Me._modifiersTableAdapter IsNot Nothing Then
                Dim array97 As System.Data.DataRow() = dataSet.Modifiers.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array97 = Me.GetRealUpdatedRows(array97, allAddedRows)
                If array97 IsNot Nothing AndAlso array97.Length <> 0 Then
                    num += Me._modifiersTableAdapter.Update(array97)
                    allChangedRows.AddRange(array97)
                End If
            End If

            If Me._loyaltySettingTableAdapter IsNot Nothing Then
                Dim array98 As System.Data.DataRow() = dataSet.LoyaltySetting.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array98 = Me.GetRealUpdatedRows(array98, allAddedRows)
                If array98 IsNot Nothing AndAlso array98.Length <> 0 Then
                    num += Me._loyaltySettingTableAdapter.Update(array98)
                    allChangedRows.AddRange(array98)
                End If
            End If

            If Me._memberLedgerTableAdapter IsNot Nothing Then
                Dim array99 As System.Data.DataRow() = dataSet.MemberLedger.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array99 = Me.GetRealUpdatedRows(array99, allAddedRows)
                If array99 IsNot Nothing AndAlso array99.Length <> 0 Then
                    num += Me._memberLedgerTableAdapter.Update(array99)
                    allChangedRows.AddRange(array99)
                End If
            End If

            If Me._payrollTableAdapter IsNot Nothing Then
                Dim array100 As System.Data.DataRow() = dataSet.Payroll.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array100 = Me.GetRealUpdatedRows(array100, allAddedRows)
                If array100 IsNot Nothing AndAlso array100.Length <> 0 Then
                    num += Me._payrollTableAdapter.Update(array100)
                    allChangedRows.AddRange(array100)
                End If
            End If

            If Me._payroll_MBTableAdapter IsNot Nothing Then
                Dim array101 As System.Data.DataRow() = dataSet.Payroll_MB.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array101 = Me.GetRealUpdatedRows(array101, allAddedRows)
                If array101 IsNot Nothing AndAlso array101.Length <> 0 Then
                    num += Me._payroll_MBTableAdapter.Update(array101)
                    allChangedRows.AddRange(array101)
                End If
            End If

            If Me._payment_WithdrawTableAdapter IsNot Nothing Then
                Dim array102 As System.Data.DataRow() = dataSet.Payment_Withdraw.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array102 = Me.GetRealUpdatedRows(array102, allAddedRows)
                If array102 IsNot Nothing AndAlso array102.Length <> 0 Then
                    num += Me._payment_WithdrawTableAdapter.Update(array102)
                    allChangedRows.AddRange(array102)
                End If
            End If

            If Me._otherSettingTableAdapter IsNot Nothing Then
                Dim array103 As System.Data.DataRow() = dataSet.OtherSetting.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array103 = Me.GetRealUpdatedRows(array103, allAddedRows)
                If array103 IsNot Nothing AndAlso array103.Length <> 0 Then
                    num += Me._otherSettingTableAdapter.Update(array103)
                    allChangedRows.AddRange(array103)
                End If
            End If

            If Me._paymentTableAdapter IsNot Nothing Then
                Dim array104 As System.Data.DataRow() = dataSet.Payment.[Select](Nothing, Nothing, System.Data.DataViewRowState.ModifiedCurrent)
                array104 = Me.GetRealUpdatedRows(array104, allAddedRows)
                If array104 IsNot Nothing AndAlso array104.Length <> 0 Then
                    num += Me._paymentTableAdapter.Update(array104)
                    allChangedRows.AddRange(array104)
                End If
            End If

            Return num
        End Function

        ''' <summary>
        ''' Insert rows in top-down order.
        ''' </summary>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Private Function UpdateInsertedRows(dataSet As RestaurantPOS14.RPOS_DBDataSet1, allAddedRows As System.Collections.Generic.List(Of System.Data.DataRow)) As Integer
            Dim num As Integer = 0
            If Me._kitchenTableAdapter IsNot Nothing Then
                Dim array As System.Data.DataRow() = dataSet.Kitchen.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array IsNot Nothing AndAlso array.Length <> 0 Then
                    num += Me._kitchenTableAdapter.Update(array)
                    allAddedRows.AddRange(array)
                End If
            End If

            If Me._categoryTableAdapter IsNot Nothing Then
                Dim array2 As System.Data.DataRow() = dataSet.Category.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array2 IsNot Nothing AndAlso array2.Length <> 0 Then
                    num += Me._categoryTableAdapter.Update(array2)
                    allAddedRows.AddRange(array2)
                End If
            End If

            If Me._bankTableAdapter IsNot Nothing Then
                Dim array3 As System.Data.DataRow() = dataSet.Bank.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array3 IsNot Nothing AndAlso array3.Length <> 0 Then
                    num += Me._bankTableAdapter.Update(array3)
                    allAddedRows.AddRange(array3)
                End If
            End If

            If Me._expenseTypeTableAdapter IsNot Nothing Then
                Dim array4 As System.Data.DataRow() = dataSet.ExpenseType.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array4 IsNot Nothing AndAlso array4.Length <> 0 Then
                    num += Me._expenseTypeTableAdapter.Update(array4)
                    allAddedRows.AddRange(array4)
                End If
            End If

            If Me._unitMasterTableAdapter IsNot Nothing Then
                Dim array5 As System.Data.DataRow() = dataSet.UnitMaster.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array5 IsNot Nothing AndAlso array5.Length <> 0 Then
                    num += Me._unitMasterTableAdapter.Update(array5)
                    allAddedRows.AddRange(array5)
                End If
            End If

            If Me._dishTableAdapter IsNot Nothing Then
                Dim array6 As System.Data.DataRow() = dataSet.Dish.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array6 IsNot Nothing AndAlso array6.Length <> 0 Then
                    num += Me._dishTableAdapter.Update(array6)
                    allAddedRows.AddRange(array6)
                End If
            End If

            If Me._employeeRegistrationTableAdapter IsNot Nothing Then
                Dim array7 As System.Data.DataRow() = dataSet.EmployeeRegistration.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array7 IsNot Nothing AndAlso array7.Length <> 0 Then
                    num += Me._employeeRegistrationTableAdapter.Update(array7)
                    allAddedRows.AddRange(array7)
                End If
            End If

            If Me._rMCategoryTableAdapter IsNot Nothing Then
                Dim array8 As System.Data.DataRow() = dataSet.RMCategory.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array8 IsNot Nothing AndAlso array8.Length <> 0 Then
                    num += Me._rMCategoryTableAdapter.Update(array8)
                    allAddedRows.AddRange(array8)
                End If
            End If

            If Me._pizzaSizeTableAdapter IsNot Nothing Then
                Dim array9 As System.Data.DataRow() = dataSet.PizzaSize.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array9 IsNot Nothing AndAlso array9.Length <> 0 Then
                    num += Me._pizzaSizeTableAdapter.Update(array9)
                    allAddedRows.AddRange(array9)
                End If
            End If

            If Me._r_TableTableAdapter IsNot Nothing Then
                Dim array10 As System.Data.DataRow() = dataSet.R_Table.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array10 IsNot Nothing AndAlso array10.Length <> 0 Then
                    num += Me._r_TableTableAdapter.Update(array10)
                    allAddedRows.AddRange(array10)
                End If
            End If

            If Me._registrationTableAdapter IsNot Nothing Then
                Dim array11 As System.Data.DataRow() = dataSet.Registration.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array11 IsNot Nothing AndAlso array11.Length <> 0 Then
                    num += Me._registrationTableAdapter.Update(array11)
                    allAddedRows.AddRange(array11)
                End If
            End If

            If Me._bankBranchTableAdapter IsNot Nothing Then
                Dim array12 As System.Data.DataRow() = dataSet.BankBranch.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array12 IsNot Nothing AndAlso array12.Length <> 0 Then
                    num += Me._bankBranchTableAdapter.Update(array12)
                    allAddedRows.AddRange(array12)
                End If
            End If

            If Me._supplierTableAdapter IsNot Nothing Then
                Dim array13 As System.Data.DataRow() = dataSet.Supplier.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array13 IsNot Nothing AndAlso array13.Length <> 0 Then
                    num += Me._supplierTableAdapter.Update(array13)
                    allAddedRows.AddRange(array13)
                End If
            End If

            If Me._warehouseTypeTableAdapter IsNot Nothing Then
                Dim array14 As System.Data.DataRow() = dataSet.WarehouseType.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array14 IsNot Nothing AndAlso array14.Length <> 0 Then
                    num += Me._warehouseTypeTableAdapter.Update(array14)
                    allAddedRows.AddRange(array14)
                End If
            End If

            If Me._productTableAdapter IsNot Nothing Then
                Dim array15 As System.Data.DataRow() = dataSet.Product.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array15 IsNot Nothing AndAlso array15.Length <> 0 Then
                    num += Me._productTableAdapter.Update(array15)
                    allAddedRows.AddRange(array15)
                End If
            End If

            If Me._clockINTableAdapter IsNot Nothing Then
                Dim array16 As System.Data.DataRow() = dataSet.ClockIN.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array16 IsNot Nothing AndAlso array16.Length <> 0 Then
                    num += Me._clockINTableAdapter.Update(array16)
                    allAddedRows.AddRange(array16)
                End If
            End If

            If Me._rM_UsedTableAdapter IsNot Nothing Then
                Dim array17 As System.Data.DataRow() = dataSet.RM_Used.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array17 IsNot Nothing AndAlso array17.Length <> 0 Then
                    num += Me._rM_UsedTableAdapter.Update(array17)
                    allAddedRows.AddRange(array17)
                End If
            End If

            If Me._restaurantPOS_BillingInfoTATableAdapter IsNot Nothing Then
                Dim array18 As System.Data.DataRow() = dataSet.RestaurantPOS_BillingInfoTA.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array18 IsNot Nothing AndAlso array18.Length <> 0 Then
                    num += Me._restaurantPOS_BillingInfoTATableAdapter.Update(array18)
                    allAddedRows.AddRange(array18)
                End If
            End If

            If Me._loyaltyMemberTableAdapter IsNot Nothing Then
                Dim array19 As System.Data.DataRow() = dataSet.LoyaltyMember.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array19 IsNot Nothing AndAlso array19.Length <> 0 Then
                    num += Me._loyaltyMemberTableAdapter.Update(array19)
                    allAddedRows.AddRange(array19)
                End If
            End If

            If Me._restaurantPOS_OrderInfoKOTTableAdapter IsNot Nothing Then
                Dim array20 As System.Data.DataRow() = dataSet.RestaurantPOS_OrderInfoKOT.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array20 IsNot Nothing AndAlso array20.Length <> 0 Then
                    num += Me._restaurantPOS_OrderInfoKOTTableAdapter.Update(array20)
                    allAddedRows.AddRange(array20)
                End If
            End If

            If Me._stock_StoreTableAdapter IsNot Nothing Then
                Dim array21 As System.Data.DataRow() = dataSet.Stock_Store.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array21 IsNot Nothing AndAlso array21.Length <> 0 Then
                    num += Me._stock_StoreTableAdapter.Update(array21)
                    allAddedRows.AddRange(array21)
                End If
            End If

            If Me._pizzaMasterTableAdapter IsNot Nothing Then
                Dim array22 As System.Data.DataRow() = dataSet.PizzaMaster.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array22 IsNot Nothing AndAlso array22.Length <> 0 Then
                    num += Me._pizzaMasterTableAdapter.Update(array22)
                    allAddedRows.AddRange(array22)
                End If
            End If

            If Me._bankAccountRegistrationTableAdapter IsNot Nothing Then
                Dim array23 As System.Data.DataRow() = dataSet.BankAccountRegistration.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array23 IsNot Nothing AndAlso array23.Length <> 0 Then
                    num += Me._bankAccountRegistrationTableAdapter.Update(array23)
                    allAddedRows.AddRange(array23)
                End If
            End If

            If Me._stockTransferTableAdapter IsNot Nothing Then
                Dim array24 As System.Data.DataRow() = dataSet.StockTransfer.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array24 IsNot Nothing AndAlso array24.Length <> 0 Then
                    num += Me._stockTransferTableAdapter.Update(array24)
                    allAddedRows.AddRange(array24)
                End If
            End If

            If Me._memberTableAdapter IsNot Nothing Then
                Dim array25 As System.Data.DataRow() = dataSet.Member.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array25 IsNot Nothing AndAlso array25.Length <> 0 Then
                    num += Me._memberTableAdapter.Update(array25)
                    allAddedRows.AddRange(array25)
                End If
            End If

            If Me._purchaseTableAdapter IsNot Nothing Then
                Dim array26 As System.Data.DataRow() = dataSet.Purchase.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array26 IsNot Nothing AndAlso array26.Length <> 0 Then
                    num += Me._purchaseTableAdapter.Update(array26)
                    allAddedRows.AddRange(array26)
                End If
            End If

            If Me._warehouseTableAdapter IsNot Nothing Then
                Dim array27 As System.Data.DataRow() = dataSet.Warehouse.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array27 IsNot Nothing AndAlso array27.Length <> 0 Then
                    num += Me._warehouseTableAdapter.Update(array27)
                    allAddedRows.AddRange(array27)
                End If
            End If

            If Me._creditCustomerTableAdapter IsNot Nothing Then
                Dim array28 As System.Data.DataRow() = dataSet.CreditCustomer.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array28 IsNot Nothing AndAlso array28.Length <> 0 Then
                    num += Me._creditCustomerTableAdapter.Update(array28)
                    allAddedRows.AddRange(array28)
                End If
            End If

            If Me._expenseTableAdapter IsNot Nothing Then
                Dim array29 As System.Data.DataRow() = dataSet.Expense.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array29 IsNot Nothing AndAlso array29.Length <> 0 Then
                    num += Me._expenseTableAdapter.Update(array29)
                    allAddedRows.AddRange(array29)
                End If
            End If

            If Me._workPeriodStartTableAdapter IsNot Nothing Then
                Dim array30 As System.Data.DataRow() = dataSet.WorkPeriodStart.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array30 IsNot Nothing AndAlso array30.Length <> 0 Then
                    num += Me._workPeriodStartTableAdapter.Update(array30)
                    allAddedRows.AddRange(array30)
                End If
            End If

            If Me._voucherTableAdapter IsNot Nothing Then
                Dim array31 As System.Data.DataRow() = dataSet.Voucher.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array31 IsNot Nothing AndAlso array31.Length <> 0 Then
                    num += Me._voucherTableAdapter.Update(array31)
                    allAddedRows.AddRange(array31)
                End If
            End If

            If Me._restaurantPOS_BillingInfoEBTableAdapter IsNot Nothing Then
                Dim array32 As System.Data.DataRow() = dataSet.RestaurantPOS_BillingInfoEB.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array32 IsNot Nothing AndAlso array32.Length <> 0 Then
                    num += Me._restaurantPOS_BillingInfoEBTableAdapter.Update(array32)
                    allAddedRows.AddRange(array32)
                End If
            End If

            If Me._tempRestaurantPOS_BillingInfoKOTTableAdapter IsNot Nothing Then
                Dim array33 As System.Data.DataRow() = dataSet.TempRestaurantPOS_BillingInfoKOT.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array33 IsNot Nothing AndAlso array33.Length <> 0 Then
                    num += Me._tempRestaurantPOS_BillingInfoKOTTableAdapter.Update(array33)
                    allAddedRows.AddRange(array33)
                End If
            End If

            If Me._purchaseOrderTableAdapter IsNot Nothing Then
                Dim array34 As System.Data.DataRow() = dataSet.PurchaseOrder.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array34 IsNot Nothing AndAlso array34.Length <> 0 Then
                    num += Me._purchaseOrderTableAdapter.Update(array34)
                    allAddedRows.AddRange(array34)
                End If
            End If

            If Me._restaurantPOS_BillingInfoHDTableAdapter IsNot Nothing Then
                Dim array35 As System.Data.DataRow() = dataSet.RestaurantPOS_BillingInfoHD.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array35 IsNot Nothing AndAlso array35.Length <> 0 Then
                    num += Me._restaurantPOS_BillingInfoHDTableAdapter.Update(array35)
                    allAddedRows.AddRange(array35)
                End If
            End If

            If Me._recipeTableAdapter IsNot Nothing Then
                Dim array36 As System.Data.DataRow() = dataSet.Recipe.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array36 IsNot Nothing AndAlso array36.Length <> 0 Then
                    num += Me._recipeTableAdapter.Update(array36)
                    allAddedRows.AddRange(array36)
                End If
            End If

            If Me._restaurantPOS_BillingInfoKOTTableAdapter IsNot Nothing Then
                Dim array37 As System.Data.DataRow() = dataSet.RestaurantPOS_BillingInfoKOT.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array37 IsNot Nothing AndAlso array37.Length <> 0 Then
                    num += Me._restaurantPOS_BillingInfoKOTTableAdapter.Update(array37)
                    allAddedRows.AddRange(array37)
                End If
            End If

            If Me._walletTableAdapter IsNot Nothing Then
                Dim array38 As System.Data.DataRow() = dataSet.Wallet.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array38 IsNot Nothing AndAlso array38.Length <> 0 Then
                    num += Me._walletTableAdapter.Update(array38)
                    allAddedRows.AddRange(array38)
                End If
            End If

            If Me._restaurantPOS_OrderedProductBillEBTableAdapter IsNot Nothing Then
                Dim array39 As System.Data.DataRow() = dataSet.RestaurantPOS_OrderedProductBillEB.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array39 IsNot Nothing AndAlso array39.Length <> 0 Then
                    num += Me._restaurantPOS_OrderedProductBillEBTableAdapter.Update(array39)
                    allAddedRows.AddRange(array39)
                End If
            End If

            If Me._restaurantPOS_OrderedProductBillHDTableAdapter IsNot Nothing Then
                Dim array40 As System.Data.DataRow() = dataSet.RestaurantPOS_OrderedProductBillHD.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array40 IsNot Nothing AndAlso array40.Length <> 0 Then
                    num += Me._restaurantPOS_OrderedProductBillHDTableAdapter.Update(array40)
                    allAddedRows.AddRange(array40)
                End If
            End If

            If Me._restaurantPOS_OrderedProductBillKOTTableAdapter IsNot Nothing Then
                Dim array41 As System.Data.DataRow() = dataSet.RestaurantPOS_OrderedProductBillKOT.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array41 IsNot Nothing AndAlso array41.Length <> 0 Then
                    num += Me._restaurantPOS_OrderedProductBillKOTTableAdapter.Update(array41)
                    allAddedRows.AddRange(array41)
                End If
            End If

            If Me._restaurantPOS_OrderedProductBillTATableAdapter IsNot Nothing Then
                Dim array42 As System.Data.DataRow() = dataSet.RestaurantPOS_OrderedProductBillTA.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array42 IsNot Nothing AndAlso array42.Length <> 0 Then
                    num += Me._restaurantPOS_OrderedProductBillTATableAdapter.Update(array42)
                    allAddedRows.AddRange(array42)
                End If
            End If

            If Me._activationTableAdapter IsNot Nothing Then
                Dim array43 As System.Data.DataRow() = dataSet.Activation.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array43 IsNot Nothing AndAlso array43.Length <> 0 Then
                    num += Me._activationTableAdapter.Update(array43)
                    allAddedRows.AddRange(array43)
                End If
            End If

            If Me._restaurantPOS_OrderedProductKOTTableAdapter IsNot Nothing Then
                Dim array44 As System.Data.DataRow() = dataSet.RestaurantPOS_OrderedProductKOT.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array44 IsNot Nothing AndAlso array44.Length <> 0 Then
                    num += Me._restaurantPOS_OrderedProductKOTTableAdapter.Update(array44)
                    allAddedRows.AddRange(array44)
                End If
            End If

            If Me._temp_StockTableAdapter IsNot Nothing Then
                Dim array45 As System.Data.DataRow() = dataSet.Temp_Stock.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array45 IsNot Nothing AndAlso array45.Length <> 0 Then
                    num += Me._temp_StockTableAdapter.Update(array45)
                    allAddedRows.AddRange(array45)
                End If
            End If

            If Me._temp_Stock_RMTableAdapter IsNot Nothing Then
                Dim array46 As System.Data.DataRow() = dataSet.Temp_Stock_RM.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array46 IsNot Nothing AndAlso array46.Length <> 0 Then
                    num += Me._temp_Stock_RMTableAdapter.Update(array46)
                    allAddedRows.AddRange(array46)
                End If
            End If

            If Me._tableReservationTableAdapter IsNot Nothing Then
                Dim array47 As System.Data.DataRow() = dataSet.TableReservation.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array47 IsNot Nothing AndAlso array47.Length <> 0 Then
                    num += Me._tableReservationTableAdapter.Update(array47)
                    allAddedRows.AddRange(array47)
                End If
            End If

            If Me._tblOrderTableAdapter IsNot Nothing Then
                Dim array48 As System.Data.DataRow() = dataSet.tblOrder.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array48 IsNot Nothing AndAlso array48.Length <> 0 Then
                    num += Me._tblOrderTableAdapter.Update(array48)
                    allAddedRows.AddRange(array48)
                End If
            End If

            If Me._temp_Stock_StoreTableAdapter IsNot Nothing Then
                Dim array49 As System.Data.DataRow() = dataSet.Temp_Stock_Store.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array49 IsNot Nothing AndAlso array49.Length <> 0 Then
                    num += Me._temp_Stock_StoreTableAdapter.Update(array49)
                    allAddedRows.AddRange(array49)
                End If
            End If

            If Me._userRightsTableAdapter IsNot Nothing Then
                Dim array50 As System.Data.DataRow() = dataSet.UserRights.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array50 IsNot Nothing AndAlso array50.Length <> 0 Then
                    num += Me._userRightsTableAdapter.Update(array50)
                    allAddedRows.AddRange(array50)
                End If
            End If

            If Me._voucher_OtherDetailsTableAdapter IsNot Nothing Then
                Dim array51 As System.Data.DataRow() = dataSet.Voucher_OtherDetails.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array51 IsNot Nothing AndAlso array51.Length <> 0 Then
                    num += Me._voucher_OtherDetailsTableAdapter.Update(array51)
                    allAddedRows.AddRange(array51)
                End If
            End If

            If Me._tempRestaurantPOS_OrderedProductBillKOTTableAdapter IsNot Nothing Then
                Dim array52 As System.Data.DataRow() = dataSet.TempRestaurantPOS_OrderedProductBillKOT.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array52 IsNot Nothing AndAlso array52.Length <> 0 Then
                    num += Me._tempRestaurantPOS_OrderedProductBillKOTTableAdapter.Update(array52)
                    allAddedRows.AddRange(array52)
                End If
            End If

            If Me._workPeriodEndTableAdapter IsNot Nothing Then
                Dim array53 As System.Data.DataRow() = dataSet.WorkPeriodEnd.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array53 IsNot Nothing AndAlso array53.Length <> 0 Then
                    num += Me._workPeriodEndTableAdapter.Update(array53)
                    allAddedRows.AddRange(array53)
                End If
            End If

            If Me._tableMappingTableAdapter IsNot Nothing Then
                Dim array54 As System.Data.DataRow() = dataSet.TableMapping.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array54 IsNot Nothing AndAlso array54.Length <> 0 Then
                    num += Me._tableMappingTableAdapter.Update(array54)
                    allAddedRows.AddRange(array54)
                End If
            End If

            If Me._stock_Store_JoinTableAdapter IsNot Nothing Then
                Dim array55 As System.Data.DataRow() = dataSet.Stock_Store_Join.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array55 IsNot Nothing AndAlso array55.Length <> 0 Then
                    num += Me._stock_Store_JoinTableAdapter.Update(array55)
                    allAddedRows.AddRange(array55)
                End If
            End If

            If Me._stockAdjustment_MITableAdapter IsNot Nothing Then
                Dim array56 As System.Data.DataRow() = dataSet.StockAdjustment_MI.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array56 IsNot Nothing AndAlso array56.Length <> 0 Then
                    num += Me._stockAdjustment_MITableAdapter.Update(array56)
                    allAddedRows.AddRange(array56)
                End If
            End If

            If Me._rM_Used_JoinTableAdapter IsNot Nothing Then
                Dim array57 As System.Data.DataRow() = dataSet.RM_Used_Join.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array57 IsNot Nothing AndAlso array57.Length <> 0 Then
                    num += Me._rM_Used_JoinTableAdapter.Update(array57)
                    allAddedRows.AddRange(array57)
                End If
            End If

            If Me._sMSSettingTableAdapter IsNot Nothing Then
                Dim array58 As System.Data.DataRow() = dataSet.SMSSetting.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array58 IsNot Nothing AndAlso array58.Length <> 0 Then
                    num += Me._sMSSettingTableAdapter.Update(array58)
                    allAddedRows.AddRange(array58)
                End If
            End If

            If Me._stockAdjustment_StoreTableAdapter IsNot Nothing Then
                Dim array59 As System.Data.DataRow() = dataSet.StockAdjustment_Store.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array59 IsNot Nothing AndAlso array59.Length <> 0 Then
                    num += Me._stockAdjustment_StoreTableAdapter.Update(array59)
                    allAddedRows.AddRange(array59)
                End If
            End If

            If Me._supplierLedgerBookTableAdapter IsNot Nothing Then
                Dim array60 As System.Data.DataRow() = dataSet.SupplierLedgerBook.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array60 IsNot Nothing AndAlso array60.Length <> 0 Then
                    num += Me._supplierLedgerBookTableAdapter.Update(array60)
                    allAddedRows.AddRange(array60)
                End If
            End If

            If Me._tableLayoutTableAdapter IsNot Nothing Then
                Dim array61 As System.Data.DataRow() = dataSet.TableLayout.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array61 IsNot Nothing AndAlso array61.Length <> 0 Then
                    num += Me._tableLayoutTableAdapter.Update(array61)
                    allAddedRows.AddRange(array61)
                End If
            End If

            If Me._stockAdjustment_WarehouseTableAdapter IsNot Nothing Then
                Dim array62 As System.Data.DataRow() = dataSet.StockAdjustment_Warehouse.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array62 IsNot Nothing AndAlso array62.Length <> 0 Then
                    num += Me._stockAdjustment_WarehouseTableAdapter.Update(array62)
                    allAddedRows.AddRange(array62)
                End If
            End If

            If Me._stockTransfer_JoinTableAdapter IsNot Nothing Then
                Dim array63 As System.Data.DataRow() = dataSet.StockTransfer_Join.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array63 IsNot Nothing AndAlso array63.Length <> 0 Then
                    num += Me._stockTransfer_JoinTableAdapter.Update(array63)
                    allAddedRows.AddRange(array63)
                End If
            End If

            If Me._hDCustomerTableAdapter IsNot Nothing Then
                Dim array64 As System.Data.DataRow() = dataSet.HDCustomer.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array64 IsNot Nothing AndAlso array64.Length <> 0 Then
                    num += Me._hDCustomerTableAdapter.Update(array64)
                    allAddedRows.AddRange(array64)
                End If
            End If

            If Me._holdBillTableAdapter IsNot Nothing Then
                Dim array65 As System.Data.DataRow() = dataSet.HoldBill.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array65 IsNot Nothing AndAlso array65.Length <> 0 Then
                    num += Me._holdBillTableAdapter.Update(array65)
                    allAddedRows.AddRange(array65)
                End If
            End If

            If Me._gridGroupingTableAdapter IsNot Nothing Then
                Dim array66 As System.Data.DataRow() = dataSet.GridGrouping.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array66 IsNot Nothing AndAlso array66.Length <> 0 Then
                    num += Me._gridGroupingTableAdapter.Update(array66)
                    allAddedRows.AddRange(array66)
                End If
            End If

            If Me._fundTransferTableAdapter IsNot Nothing Then
                Dim array67 As System.Data.DataRow() = dataSet.FundTransfer.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array67 IsNot Nothing AndAlso array67.Length <> 0 Then
                    num += Me._fundTransferTableAdapter.Update(array67)
                    allAddedRows.AddRange(array67)
                End If
            End If

            If Me._giftCardTableAdapter IsNot Nothing Then
                Dim array68 As System.Data.DataRow() = dataSet.GiftCard.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array68 IsNot Nothing AndAlso array68.Length <> 0 Then
                    num += Me._giftCardTableAdapter.Update(array68)
                    allAddedRows.AddRange(array68)
                End If
            End If

            If Me._ledgerBookTableAdapter IsNot Nothing Then
                Dim array69 As System.Data.DataRow() = dataSet.LedgerBook.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array69 IsNot Nothing AndAlso array69.Length <> 0 Then
                    num += Me._ledgerBookTableAdapter.Update(array69)
                    allAddedRows.AddRange(array69)
                End If
            End If

            If Me._logsTableAdapter IsNot Nothing Then
                Dim array70 As System.Data.DataRow() = dataSet.Logs.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array70 IsNot Nothing AndAlso array70.Length <> 0 Then
                    num += Me._logsTableAdapter.Update(array70)
                    allAddedRows.AddRange(array70)
                End If
            End If

            If Me._journalTableAdapter IsNot Nothing Then
                Dim array71 As System.Data.DataRow() = dataSet.Journal.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array71 IsNot Nothing AndAlso array71.Length <> 0 Then
                    num += Me._journalTableAdapter.Update(array71)
                    allAddedRows.AddRange(array71)
                End If
            End If

            If Me._holdItemsTableAdapter IsNot Nothing Then
                Dim array72 As System.Data.DataRow() = dataSet.HoldItems.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array72 IsNot Nothing AndAlso array72.Length <> 0 Then
                    num += Me._holdItemsTableAdapter.Update(array72)
                    allAddedRows.AddRange(array72)
                End If
            End If

            If Me._hotelTableAdapter IsNot Nothing Then
                Dim array73 As System.Data.DataRow() = dataSet.Hotel.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array73 IsNot Nothing AndAlso array73.Length <> 0 Then
                    num += Me._hotelTableAdapter.Update(array73)
                    allAddedRows.AddRange(array73)
                End If
            End If

            If Me._creditCustomerLedgerTableAdapter IsNot Nothing Then
                Dim array74 As System.Data.DataRow() = dataSet.CreditCustomerLedger.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array74 IsNot Nothing AndAlso array74.Length <> 0 Then
                    num += Me._creditCustomerLedgerTableAdapter.Update(array74)
                    allAddedRows.AddRange(array74)
                End If
            End If

            If Me._creditCustomerPaymentTableAdapter IsNot Nothing Then
                Dim array75 As System.Data.DataRow() = dataSet.CreditCustomerPayment.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array75 IsNot Nothing AndAlso array75.Length <> 0 Then
                    num += Me._creditCustomerPaymentTableAdapter.Update(array75)
                    allAddedRows.AddRange(array75)
                End If
            End If

            If Me._cMISettingTableAdapter IsNot Nothing Then
                Dim array76 As System.Data.DataRow() = dataSet.CMISetting.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array76 IsNot Nothing AndAlso array76.Length <> 0 Then
                    num += Me._cMISettingTableAdapter.Update(array76)
                    allAddedRows.AddRange(array76)
                End If
            End If

            If Me._bankAccountLedgerTableAdapter IsNot Nothing Then
                Dim array77 As System.Data.DataRow() = dataSet.BankAccountLedger.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array77 IsNot Nothing AndAlso array77.Length <> 0 Then
                    num += Me._bankAccountLedgerTableAdapter.Update(array77)
                    allAddedRows.AddRange(array77)
                End If
            End If

            If Me._clockOUTTableAdapter IsNot Nothing Then
                Dim array78 As System.Data.DataRow() = dataSet.ClockOUT.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array78 IsNot Nothing AndAlso array78.Length <> 0 Then
                    num += Me._clockOUTTableAdapter.Update(array78)
                    allAddedRows.AddRange(array78)
                End If
            End If

            If Me._emailSettingTableAdapter IsNot Nothing Then
                Dim array79 As System.Data.DataRow() = dataSet.EmailSetting.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array79 IsNot Nothing AndAlso array79.Length <> 0 Then
                    num += Me._emailSettingTableAdapter.Update(array79)
                    allAddedRows.AddRange(array79)
                End If
            End If

            If Me._fundDepositTableAdapter IsNot Nothing Then
                Dim array80 As System.Data.DataRow() = dataSet.FundDeposit.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array80 IsNot Nothing AndAlso array80.Length <> 0 Then
                    num += Me._fundDepositTableAdapter.Update(array80)
                    allAddedRows.AddRange(array80)
                End If
            End If

            If Me._deletedInvoices_JoinTableAdapter IsNot Nothing Then
                Dim array81 As System.Data.DataRow() = dataSet.DeletedInvoices_Join.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array81 IsNot Nothing AndAlso array81.Length <> 0 Then
                    num += Me._deletedInvoices_JoinTableAdapter.Update(array81)
                    allAddedRows.AddRange(array81)
                End If
            End If

            If Me._currencyTableAdapter IsNot Nothing Then
                Dim array82 As System.Data.DataRow() = dataSet.Currency.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array82 IsNot Nothing AndAlso array82.Length <> 0 Then
                    num += Me._currencyTableAdapter.Update(array82)
                    allAddedRows.AddRange(array82)
                End If
            End If

            If Me._deletedInvoicesTableAdapter IsNot Nothing Then
                Dim array83 As System.Data.DataRow() = dataSet.DeletedInvoices.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array83 IsNot Nothing AndAlso array83.Length <> 0 Then
                    num += Me._deletedInvoicesTableAdapter.Update(array83)
                    allAddedRows.AddRange(array83)
                End If
            End If

            If Me._loyaltyMemberLedgerBookTableAdapter IsNot Nothing Then
                Dim array84 As System.Data.DataRow() = dataSet.LoyaltyMemberLedgerBook.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array84 IsNot Nothing AndAlso array84.Length <> 0 Then
                    num += Me._loyaltyMemberLedgerBookTableAdapter.Update(array84)
                    allAddedRows.AddRange(array84)
                End If
            End If

            If Me._posGrouping1TableAdapter IsNot Nothing Then
                Dim array85 As System.Data.DataRow() = dataSet.PosGrouping1.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array85 IsNot Nothing AndAlso array85.Length <> 0 Then
                    num += Me._posGrouping1TableAdapter.Update(array85)
                    allAddedRows.AddRange(array85)
                End If
            End If

            If Me._posPrinterSettingTableAdapter IsNot Nothing Then
                Dim array86 As System.Data.DataRow() = dataSet.PosPrinterSetting.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array86 IsNot Nothing AndAlso array86.Length <> 0 Then
                    num += Me._posPrinterSettingTableAdapter.Update(array86)
                    allAddedRows.AddRange(array86)
                End If
            End If

            If Me._posGroupingTableAdapter IsNot Nothing Then
                Dim array87 As System.Data.DataRow() = dataSet.PosGrouping.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array87 IsNot Nothing AndAlso array87.Length <> 0 Then
                    num += Me._posGroupingTableAdapter.Update(array87)
                    allAddedRows.AddRange(array87)
                End If
            End If

            If Me._pizzaModifierTableAdapter IsNot Nothing Then
                Dim array88 As System.Data.DataRow() = dataSet.PizzaModifier.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array88 IsNot Nothing AndAlso array88.Length <> 0 Then
                    num += Me._pizzaModifierTableAdapter.Update(array88)
                    allAddedRows.AddRange(array88)
                End If
            End If

            If Me._pizzaToppingTableAdapter IsNot Nothing Then
                Dim array89 As System.Data.DataRow() = dataSet.PizzaTopping.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array89 IsNot Nothing AndAlso array89.Length <> 0 Then
                    num += Me._pizzaToppingTableAdapter.Update(array89)
                    allAddedRows.AddRange(array89)
                End If
            End If

            If Me._purchaseOrder_JoinTableAdapter IsNot Nothing Then
                Dim array90 As System.Data.DataRow() = dataSet.PurchaseOrder_Join.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array90 IsNot Nothing AndAlso array90.Length <> 0 Then
                    num += Me._purchaseOrder_JoinTableAdapter.Update(array90)
                    allAddedRows.AddRange(array90)
                End If
            End If

            If Me._recipe_JoinTableAdapter IsNot Nothing Then
                Dim array91 As System.Data.DataRow() = dataSet.Recipe_Join.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array91 IsNot Nothing AndAlso array91.Length <> 0 Then
                    num += Me._recipe_JoinTableAdapter.Update(array91)
                    allAddedRows.AddRange(array91)
                End If
            End If

            If Me._purchase_JoinTableAdapter IsNot Nothing Then
                Dim array92 As System.Data.DataRow() = dataSet.Purchase_Join.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array92 IsNot Nothing AndAlso array92.Length <> 0 Then
                    num += Me._purchase_JoinTableAdapter.Update(array92)
                    allAddedRows.AddRange(array92)
                End If
            End If

            If Me._product_OpeningStockTableAdapter IsNot Nothing Then
                Dim array93 As System.Data.DataRow() = dataSet.Product_OpeningStock.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array93 IsNot Nothing AndAlso array93.Length <> 0 Then
                    num += Me._product_OpeningStockTableAdapter.Update(array93)
                    allAddedRows.AddRange(array93)
                End If
            End If

            If Me._promotionTableAdapter IsNot Nothing Then
                Dim array94 As System.Data.DataRow() = dataSet.Promotion.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array94 IsNot Nothing AndAlso array94.Length <> 0 Then
                    num += Me._promotionTableAdapter.Update(array94)
                    allAddedRows.AddRange(array94)
                End If
            End If

            If Me._mpesaSettingTableAdapter IsNot Nothing Then
                Dim array95 As System.Data.DataRow() = dataSet.MpesaSetting.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array95 IsNot Nothing AndAlso array95.Length <> 0 Then
                    num += Me._mpesaSettingTableAdapter.Update(array95)
                    allAddedRows.AddRange(array95)
                End If
            End If

            If Me._notesMasterTableAdapter IsNot Nothing Then
                Dim array96 As System.Data.DataRow() = dataSet.NotesMaster.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array96 IsNot Nothing AndAlso array96.Length <> 0 Then
                    num += Me._notesMasterTableAdapter.Update(array96)
                    allAddedRows.AddRange(array96)
                End If
            End If

            If Me._modifiersTableAdapter IsNot Nothing Then
                Dim array97 As System.Data.DataRow() = dataSet.Modifiers.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array97 IsNot Nothing AndAlso array97.Length <> 0 Then
                    num += Me._modifiersTableAdapter.Update(array97)
                    allAddedRows.AddRange(array97)
                End If
            End If

            If Me._loyaltySettingTableAdapter IsNot Nothing Then
                Dim array98 As System.Data.DataRow() = dataSet.LoyaltySetting.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array98 IsNot Nothing AndAlso array98.Length <> 0 Then
                    num += Me._loyaltySettingTableAdapter.Update(array98)
                    allAddedRows.AddRange(array98)
                End If
            End If

            If Me._memberLedgerTableAdapter IsNot Nothing Then
                Dim array99 As System.Data.DataRow() = dataSet.MemberLedger.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array99 IsNot Nothing AndAlso array99.Length <> 0 Then
                    num += Me._memberLedgerTableAdapter.Update(array99)
                    allAddedRows.AddRange(array99)
                End If
            End If

            If Me._payrollTableAdapter IsNot Nothing Then
                Dim array100 As System.Data.DataRow() = dataSet.Payroll.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array100 IsNot Nothing AndAlso array100.Length <> 0 Then
                    num += Me._payrollTableAdapter.Update(array100)
                    allAddedRows.AddRange(array100)
                End If
            End If

            If Me._payroll_MBTableAdapter IsNot Nothing Then
                Dim array101 As System.Data.DataRow() = dataSet.Payroll_MB.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array101 IsNot Nothing AndAlso array101.Length <> 0 Then
                    num += Me._payroll_MBTableAdapter.Update(array101)
                    allAddedRows.AddRange(array101)
                End If
            End If

            If Me._payment_WithdrawTableAdapter IsNot Nothing Then
                Dim array102 As System.Data.DataRow() = dataSet.Payment_Withdraw.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array102 IsNot Nothing AndAlso array102.Length <> 0 Then
                    num += Me._payment_WithdrawTableAdapter.Update(array102)
                    allAddedRows.AddRange(array102)
                End If
            End If

            If Me._otherSettingTableAdapter IsNot Nothing Then
                Dim array103 As System.Data.DataRow() = dataSet.OtherSetting.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array103 IsNot Nothing AndAlso array103.Length <> 0 Then
                    num += Me._otherSettingTableAdapter.Update(array103)
                    allAddedRows.AddRange(array103)
                End If
            End If

            If Me._paymentTableAdapter IsNot Nothing Then
                Dim array104 As System.Data.DataRow() = dataSet.Payment.[Select](Nothing, Nothing, System.Data.DataViewRowState.Added)
                If array104 IsNot Nothing AndAlso array104.Length <> 0 Then
                    num += Me._paymentTableAdapter.Update(array104)
                    allAddedRows.AddRange(array104)
                End If
            End If

            Return num
        End Function

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Function UpdateDeletedRows(dataSet As RestaurantPOS14.RPOS_DBDataSet1, allChangedRows As System.Collections.Generic.List(Of System.Data.DataRow)) As Integer
            Dim num As Integer = 0
            If Me._paymentTableAdapter IsNot Nothing Then
                Dim array As System.Data.DataRow() = dataSet.Payment.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array IsNot Nothing AndAlso array.Length <> 0 Then
                    num += Me._paymentTableAdapter.Update(array)
                    allChangedRows.AddRange(array)
                End If
            End If

            If Me._otherSettingTableAdapter IsNot Nothing Then
                Dim array2 As System.Data.DataRow() = dataSet.OtherSetting.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array2 IsNot Nothing AndAlso array2.Length <> 0 Then
                    num += Me._otherSettingTableAdapter.Update(array2)
                    allChangedRows.AddRange(array2)
                End If
            End If

            If Me._payment_WithdrawTableAdapter IsNot Nothing Then
                Dim array3 As System.Data.DataRow() = dataSet.Payment_Withdraw.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array3 IsNot Nothing AndAlso array3.Length <> 0 Then
                    num += Me._payment_WithdrawTableAdapter.Update(array3)
                    allChangedRows.AddRange(array3)
                End If
            End If

            If Me._payroll_MBTableAdapter IsNot Nothing Then
                Dim array4 As System.Data.DataRow() = dataSet.Payroll_MB.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array4 IsNot Nothing AndAlso array4.Length <> 0 Then
                    num += Me._payroll_MBTableAdapter.Update(array4)
                    allChangedRows.AddRange(array4)
                End If
            End If

            If Me._payrollTableAdapter IsNot Nothing Then
                Dim array5 As System.Data.DataRow() = dataSet.Payroll.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array5 IsNot Nothing AndAlso array5.Length <> 0 Then
                    num += Me._payrollTableAdapter.Update(array5)
                    allChangedRows.AddRange(array5)
                End If
            End If

            If Me._memberLedgerTableAdapter IsNot Nothing Then
                Dim array6 As System.Data.DataRow() = dataSet.MemberLedger.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array6 IsNot Nothing AndAlso array6.Length <> 0 Then
                    num += Me._memberLedgerTableAdapter.Update(array6)
                    allChangedRows.AddRange(array6)
                End If
            End If

            If Me._loyaltySettingTableAdapter IsNot Nothing Then
                Dim array7 As System.Data.DataRow() = dataSet.LoyaltySetting.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array7 IsNot Nothing AndAlso array7.Length <> 0 Then
                    num += Me._loyaltySettingTableAdapter.Update(array7)
                    allChangedRows.AddRange(array7)
                End If
            End If

            If Me._modifiersTableAdapter IsNot Nothing Then
                Dim array8 As System.Data.DataRow() = dataSet.Modifiers.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array8 IsNot Nothing AndAlso array8.Length <> 0 Then
                    num += Me._modifiersTableAdapter.Update(array8)
                    allChangedRows.AddRange(array8)
                End If
            End If

            If Me._notesMasterTableAdapter IsNot Nothing Then
                Dim array9 As System.Data.DataRow() = dataSet.NotesMaster.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array9 IsNot Nothing AndAlso array9.Length <> 0 Then
                    num += Me._notesMasterTableAdapter.Update(array9)
                    allChangedRows.AddRange(array9)
                End If
            End If

            If Me._mpesaSettingTableAdapter IsNot Nothing Then
                Dim array10 As System.Data.DataRow() = dataSet.MpesaSetting.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array10 IsNot Nothing AndAlso array10.Length <> 0 Then
                    num += Me._mpesaSettingTableAdapter.Update(array10)
                    allChangedRows.AddRange(array10)
                End If
            End If

            If Me._promotionTableAdapter IsNot Nothing Then
                Dim array11 As System.Data.DataRow() = dataSet.Promotion.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array11 IsNot Nothing AndAlso array11.Length <> 0 Then
                    num += Me._promotionTableAdapter.Update(array11)
                    allChangedRows.AddRange(array11)
                End If
            End If

            If Me._product_OpeningStockTableAdapter IsNot Nothing Then
                Dim array12 As System.Data.DataRow() = dataSet.Product_OpeningStock.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array12 IsNot Nothing AndAlso array12.Length <> 0 Then
                    num += Me._product_OpeningStockTableAdapter.Update(array12)
                    allChangedRows.AddRange(array12)
                End If
            End If

            If Me._purchase_JoinTableAdapter IsNot Nothing Then
                Dim array13 As System.Data.DataRow() = dataSet.Purchase_Join.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array13 IsNot Nothing AndAlso array13.Length <> 0 Then
                    num += Me._purchase_JoinTableAdapter.Update(array13)
                    allChangedRows.AddRange(array13)
                End If
            End If

            If Me._recipe_JoinTableAdapter IsNot Nothing Then
                Dim array14 As System.Data.DataRow() = dataSet.Recipe_Join.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array14 IsNot Nothing AndAlso array14.Length <> 0 Then
                    num += Me._recipe_JoinTableAdapter.Update(array14)
                    allChangedRows.AddRange(array14)
                End If
            End If

            If Me._purchaseOrder_JoinTableAdapter IsNot Nothing Then
                Dim array15 As System.Data.DataRow() = dataSet.PurchaseOrder_Join.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array15 IsNot Nothing AndAlso array15.Length <> 0 Then
                    num += Me._purchaseOrder_JoinTableAdapter.Update(array15)
                    allChangedRows.AddRange(array15)
                End If
            End If

            If Me._pizzaToppingTableAdapter IsNot Nothing Then
                Dim array16 As System.Data.DataRow() = dataSet.PizzaTopping.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array16 IsNot Nothing AndAlso array16.Length <> 0 Then
                    num += Me._pizzaToppingTableAdapter.Update(array16)
                    allChangedRows.AddRange(array16)
                End If
            End If

            If Me._pizzaModifierTableAdapter IsNot Nothing Then
                Dim array17 As System.Data.DataRow() = dataSet.PizzaModifier.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array17 IsNot Nothing AndAlso array17.Length <> 0 Then
                    num += Me._pizzaModifierTableAdapter.Update(array17)
                    allChangedRows.AddRange(array17)
                End If
            End If

            If Me._posGroupingTableAdapter IsNot Nothing Then
                Dim array18 As System.Data.DataRow() = dataSet.PosGrouping.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array18 IsNot Nothing AndAlso array18.Length <> 0 Then
                    num += Me._posGroupingTableAdapter.Update(array18)
                    allChangedRows.AddRange(array18)
                End If
            End If

            If Me._posPrinterSettingTableAdapter IsNot Nothing Then
                Dim array19 As System.Data.DataRow() = dataSet.PosPrinterSetting.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array19 IsNot Nothing AndAlso array19.Length <> 0 Then
                    num += Me._posPrinterSettingTableAdapter.Update(array19)
                    allChangedRows.AddRange(array19)
                End If
            End If

            If Me._posGrouping1TableAdapter IsNot Nothing Then
                Dim array20 As System.Data.DataRow() = dataSet.PosGrouping1.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array20 IsNot Nothing AndAlso array20.Length <> 0 Then
                    num += Me._posGrouping1TableAdapter.Update(array20)
                    allChangedRows.AddRange(array20)
                End If
            End If

            If Me._loyaltyMemberLedgerBookTableAdapter IsNot Nothing Then
                Dim array21 As System.Data.DataRow() = dataSet.LoyaltyMemberLedgerBook.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array21 IsNot Nothing AndAlso array21.Length <> 0 Then
                    num += Me._loyaltyMemberLedgerBookTableAdapter.Update(array21)
                    allChangedRows.AddRange(array21)
                End If
            End If

            If Me._deletedInvoicesTableAdapter IsNot Nothing Then
                Dim array22 As System.Data.DataRow() = dataSet.DeletedInvoices.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array22 IsNot Nothing AndAlso array22.Length <> 0 Then
                    num += Me._deletedInvoicesTableAdapter.Update(array22)
                    allChangedRows.AddRange(array22)
                End If
            End If

            If Me._currencyTableAdapter IsNot Nothing Then
                Dim array23 As System.Data.DataRow() = dataSet.Currency.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array23 IsNot Nothing AndAlso array23.Length <> 0 Then
                    num += Me._currencyTableAdapter.Update(array23)
                    allChangedRows.AddRange(array23)
                End If
            End If

            If Me._deletedInvoices_JoinTableAdapter IsNot Nothing Then
                Dim array24 As System.Data.DataRow() = dataSet.DeletedInvoices_Join.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array24 IsNot Nothing AndAlso array24.Length <> 0 Then
                    num += Me._deletedInvoices_JoinTableAdapter.Update(array24)
                    allChangedRows.AddRange(array24)
                End If
            End If

            If Me._fundDepositTableAdapter IsNot Nothing Then
                Dim array25 As System.Data.DataRow() = dataSet.FundDeposit.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array25 IsNot Nothing AndAlso array25.Length <> 0 Then
                    num += Me._fundDepositTableAdapter.Update(array25)
                    allChangedRows.AddRange(array25)
                End If
            End If

            If Me._emailSettingTableAdapter IsNot Nothing Then
                Dim array26 As System.Data.DataRow() = dataSet.EmailSetting.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array26 IsNot Nothing AndAlso array26.Length <> 0 Then
                    num += Me._emailSettingTableAdapter.Update(array26)
                    allChangedRows.AddRange(array26)
                End If
            End If

            If Me._clockOUTTableAdapter IsNot Nothing Then
                Dim array27 As System.Data.DataRow() = dataSet.ClockOUT.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array27 IsNot Nothing AndAlso array27.Length <> 0 Then
                    num += Me._clockOUTTableAdapter.Update(array27)
                    allChangedRows.AddRange(array27)
                End If
            End If

            If Me._bankAccountLedgerTableAdapter IsNot Nothing Then
                Dim array28 As System.Data.DataRow() = dataSet.BankAccountLedger.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array28 IsNot Nothing AndAlso array28.Length <> 0 Then
                    num += Me._bankAccountLedgerTableAdapter.Update(array28)
                    allChangedRows.AddRange(array28)
                End If
            End If

            If Me._cMISettingTableAdapter IsNot Nothing Then
                Dim array29 As System.Data.DataRow() = dataSet.CMISetting.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array29 IsNot Nothing AndAlso array29.Length <> 0 Then
                    num += Me._cMISettingTableAdapter.Update(array29)
                    allChangedRows.AddRange(array29)
                End If
            End If

            If Me._creditCustomerPaymentTableAdapter IsNot Nothing Then
                Dim array30 As System.Data.DataRow() = dataSet.CreditCustomerPayment.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array30 IsNot Nothing AndAlso array30.Length <> 0 Then
                    num += Me._creditCustomerPaymentTableAdapter.Update(array30)
                    allChangedRows.AddRange(array30)
                End If
            End If

            If Me._creditCustomerLedgerTableAdapter IsNot Nothing Then
                Dim array31 As System.Data.DataRow() = dataSet.CreditCustomerLedger.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array31 IsNot Nothing AndAlso array31.Length <> 0 Then
                    num += Me._creditCustomerLedgerTableAdapter.Update(array31)
                    allChangedRows.AddRange(array31)
                End If
            End If

            If Me._hotelTableAdapter IsNot Nothing Then
                Dim array32 As System.Data.DataRow() = dataSet.Hotel.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array32 IsNot Nothing AndAlso array32.Length <> 0 Then
                    num += Me._hotelTableAdapter.Update(array32)
                    allChangedRows.AddRange(array32)
                End If
            End If

            If Me._holdItemsTableAdapter IsNot Nothing Then
                Dim array33 As System.Data.DataRow() = dataSet.HoldItems.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array33 IsNot Nothing AndAlso array33.Length <> 0 Then
                    num += Me._holdItemsTableAdapter.Update(array33)
                    allChangedRows.AddRange(array33)
                End If
            End If

            If Me._journalTableAdapter IsNot Nothing Then
                Dim array34 As System.Data.DataRow() = dataSet.Journal.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array34 IsNot Nothing AndAlso array34.Length <> 0 Then
                    num += Me._journalTableAdapter.Update(array34)
                    allChangedRows.AddRange(array34)
                End If
            End If

            If Me._logsTableAdapter IsNot Nothing Then
                Dim array35 As System.Data.DataRow() = dataSet.Logs.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array35 IsNot Nothing AndAlso array35.Length <> 0 Then
                    num += Me._logsTableAdapter.Update(array35)
                    allChangedRows.AddRange(array35)
                End If
            End If

            If Me._ledgerBookTableAdapter IsNot Nothing Then
                Dim array36 As System.Data.DataRow() = dataSet.LedgerBook.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array36 IsNot Nothing AndAlso array36.Length <> 0 Then
                    num += Me._ledgerBookTableAdapter.Update(array36)
                    allChangedRows.AddRange(array36)
                End If
            End If

            If Me._giftCardTableAdapter IsNot Nothing Then
                Dim array37 As System.Data.DataRow() = dataSet.GiftCard.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array37 IsNot Nothing AndAlso array37.Length <> 0 Then
                    num += Me._giftCardTableAdapter.Update(array37)
                    allChangedRows.AddRange(array37)
                End If
            End If

            If Me._fundTransferTableAdapter IsNot Nothing Then
                Dim array38 As System.Data.DataRow() = dataSet.FundTransfer.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array38 IsNot Nothing AndAlso array38.Length <> 0 Then
                    num += Me._fundTransferTableAdapter.Update(array38)
                    allChangedRows.AddRange(array38)
                End If
            End If

            If Me._gridGroupingTableAdapter IsNot Nothing Then
                Dim array39 As System.Data.DataRow() = dataSet.GridGrouping.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array39 IsNot Nothing AndAlso array39.Length <> 0 Then
                    num += Me._gridGroupingTableAdapter.Update(array39)
                    allChangedRows.AddRange(array39)
                End If
            End If

            If Me._holdBillTableAdapter IsNot Nothing Then
                Dim array40 As System.Data.DataRow() = dataSet.HoldBill.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array40 IsNot Nothing AndAlso array40.Length <> 0 Then
                    num += Me._holdBillTableAdapter.Update(array40)
                    allChangedRows.AddRange(array40)
                End If
            End If

            If Me._hDCustomerTableAdapter IsNot Nothing Then
                Dim array41 As System.Data.DataRow() = dataSet.HDCustomer.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array41 IsNot Nothing AndAlso array41.Length <> 0 Then
                    num += Me._hDCustomerTableAdapter.Update(array41)
                    allChangedRows.AddRange(array41)
                End If
            End If

            If Me._stockTransfer_JoinTableAdapter IsNot Nothing Then
                Dim array42 As System.Data.DataRow() = dataSet.StockTransfer_Join.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array42 IsNot Nothing AndAlso array42.Length <> 0 Then
                    num += Me._stockTransfer_JoinTableAdapter.Update(array42)
                    allChangedRows.AddRange(array42)
                End If
            End If

            If Me._stockAdjustment_WarehouseTableAdapter IsNot Nothing Then
                Dim array43 As System.Data.DataRow() = dataSet.StockAdjustment_Warehouse.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array43 IsNot Nothing AndAlso array43.Length <> 0 Then
                    num += Me._stockAdjustment_WarehouseTableAdapter.Update(array43)
                    allChangedRows.AddRange(array43)
                End If
            End If

            If Me._tableLayoutTableAdapter IsNot Nothing Then
                Dim array44 As System.Data.DataRow() = dataSet.TableLayout.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array44 IsNot Nothing AndAlso array44.Length <> 0 Then
                    num += Me._tableLayoutTableAdapter.Update(array44)
                    allChangedRows.AddRange(array44)
                End If
            End If

            If Me._supplierLedgerBookTableAdapter IsNot Nothing Then
                Dim array45 As System.Data.DataRow() = dataSet.SupplierLedgerBook.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array45 IsNot Nothing AndAlso array45.Length <> 0 Then
                    num += Me._supplierLedgerBookTableAdapter.Update(array45)
                    allChangedRows.AddRange(array45)
                End If
            End If

            If Me._stockAdjustment_StoreTableAdapter IsNot Nothing Then
                Dim array46 As System.Data.DataRow() = dataSet.StockAdjustment_Store.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array46 IsNot Nothing AndAlso array46.Length <> 0 Then
                    num += Me._stockAdjustment_StoreTableAdapter.Update(array46)
                    allChangedRows.AddRange(array46)
                End If
            End If

            If Me._sMSSettingTableAdapter IsNot Nothing Then
                Dim array47 As System.Data.DataRow() = dataSet.SMSSetting.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array47 IsNot Nothing AndAlso array47.Length <> 0 Then
                    num += Me._sMSSettingTableAdapter.Update(array47)
                    allChangedRows.AddRange(array47)
                End If
            End If

            If Me._rM_Used_JoinTableAdapter IsNot Nothing Then
                Dim array48 As System.Data.DataRow() = dataSet.RM_Used_Join.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array48 IsNot Nothing AndAlso array48.Length <> 0 Then
                    num += Me._rM_Used_JoinTableAdapter.Update(array48)
                    allChangedRows.AddRange(array48)
                End If
            End If

            If Me._stockAdjustment_MITableAdapter IsNot Nothing Then
                Dim array49 As System.Data.DataRow() = dataSet.StockAdjustment_MI.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array49 IsNot Nothing AndAlso array49.Length <> 0 Then
                    num += Me._stockAdjustment_MITableAdapter.Update(array49)
                    allChangedRows.AddRange(array49)
                End If
            End If

            If Me._stock_Store_JoinTableAdapter IsNot Nothing Then
                Dim array50 As System.Data.DataRow() = dataSet.Stock_Store_Join.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array50 IsNot Nothing AndAlso array50.Length <> 0 Then
                    num += Me._stock_Store_JoinTableAdapter.Update(array50)
                    allChangedRows.AddRange(array50)
                End If
            End If

            If Me._tableMappingTableAdapter IsNot Nothing Then
                Dim array51 As System.Data.DataRow() = dataSet.TableMapping.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array51 IsNot Nothing AndAlso array51.Length <> 0 Then
                    num += Me._tableMappingTableAdapter.Update(array51)
                    allChangedRows.AddRange(array51)
                End If
            End If

            If Me._workPeriodEndTableAdapter IsNot Nothing Then
                Dim array52 As System.Data.DataRow() = dataSet.WorkPeriodEnd.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array52 IsNot Nothing AndAlso array52.Length <> 0 Then
                    num += Me._workPeriodEndTableAdapter.Update(array52)
                    allChangedRows.AddRange(array52)
                End If
            End If

            If Me._tempRestaurantPOS_OrderedProductBillKOTTableAdapter IsNot Nothing Then
                Dim array53 As System.Data.DataRow() = dataSet.TempRestaurantPOS_OrderedProductBillKOT.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array53 IsNot Nothing AndAlso array53.Length <> 0 Then
                    num += Me._tempRestaurantPOS_OrderedProductBillKOTTableAdapter.Update(array53)
                    allChangedRows.AddRange(array53)
                End If
            End If

            If Me._voucher_OtherDetailsTableAdapter IsNot Nothing Then
                Dim array54 As System.Data.DataRow() = dataSet.Voucher_OtherDetails.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array54 IsNot Nothing AndAlso array54.Length <> 0 Then
                    num += Me._voucher_OtherDetailsTableAdapter.Update(array54)
                    allChangedRows.AddRange(array54)
                End If
            End If

            If Me._userRightsTableAdapter IsNot Nothing Then
                Dim array55 As System.Data.DataRow() = dataSet.UserRights.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array55 IsNot Nothing AndAlso array55.Length <> 0 Then
                    num += Me._userRightsTableAdapter.Update(array55)
                    allChangedRows.AddRange(array55)
                End If
            End If

            If Me._temp_Stock_StoreTableAdapter IsNot Nothing Then
                Dim array56 As System.Data.DataRow() = dataSet.Temp_Stock_Store.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array56 IsNot Nothing AndAlso array56.Length <> 0 Then
                    num += Me._temp_Stock_StoreTableAdapter.Update(array56)
                    allChangedRows.AddRange(array56)
                End If
            End If

            If Me._tblOrderTableAdapter IsNot Nothing Then
                Dim array57 As System.Data.DataRow() = dataSet.tblOrder.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array57 IsNot Nothing AndAlso array57.Length <> 0 Then
                    num += Me._tblOrderTableAdapter.Update(array57)
                    allChangedRows.AddRange(array57)
                End If
            End If

            If Me._tableReservationTableAdapter IsNot Nothing Then
                Dim array58 As System.Data.DataRow() = dataSet.TableReservation.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array58 IsNot Nothing AndAlso array58.Length <> 0 Then
                    num += Me._tableReservationTableAdapter.Update(array58)
                    allChangedRows.AddRange(array58)
                End If
            End If

            If Me._temp_Stock_RMTableAdapter IsNot Nothing Then
                Dim array59 As System.Data.DataRow() = dataSet.Temp_Stock_RM.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array59 IsNot Nothing AndAlso array59.Length <> 0 Then
                    num += Me._temp_Stock_RMTableAdapter.Update(array59)
                    allChangedRows.AddRange(array59)
                End If
            End If

            If Me._temp_StockTableAdapter IsNot Nothing Then
                Dim array60 As System.Data.DataRow() = dataSet.Temp_Stock.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array60 IsNot Nothing AndAlso array60.Length <> 0 Then
                    num += Me._temp_StockTableAdapter.Update(array60)
                    allChangedRows.AddRange(array60)
                End If
            End If

            If Me._restaurantPOS_OrderedProductKOTTableAdapter IsNot Nothing Then
                Dim array61 As System.Data.DataRow() = dataSet.RestaurantPOS_OrderedProductKOT.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array61 IsNot Nothing AndAlso array61.Length <> 0 Then
                    num += Me._restaurantPOS_OrderedProductKOTTableAdapter.Update(array61)
                    allChangedRows.AddRange(array61)
                End If
            End If

            If Me._activationTableAdapter IsNot Nothing Then
                Dim array62 As System.Data.DataRow() = dataSet.Activation.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array62 IsNot Nothing AndAlso array62.Length <> 0 Then
                    num += Me._activationTableAdapter.Update(array62)
                    allChangedRows.AddRange(array62)
                End If
            End If

            If Me._restaurantPOS_OrderedProductBillTATableAdapter IsNot Nothing Then
                Dim array63 As System.Data.DataRow() = dataSet.RestaurantPOS_OrderedProductBillTA.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array63 IsNot Nothing AndAlso array63.Length <> 0 Then
                    num += Me._restaurantPOS_OrderedProductBillTATableAdapter.Update(array63)
                    allChangedRows.AddRange(array63)
                End If
            End If

            If Me._restaurantPOS_OrderedProductBillKOTTableAdapter IsNot Nothing Then
                Dim array64 As System.Data.DataRow() = dataSet.RestaurantPOS_OrderedProductBillKOT.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array64 IsNot Nothing AndAlso array64.Length <> 0 Then
                    num += Me._restaurantPOS_OrderedProductBillKOTTableAdapter.Update(array64)
                    allChangedRows.AddRange(array64)
                End If
            End If

            If Me._restaurantPOS_OrderedProductBillHDTableAdapter IsNot Nothing Then
                Dim array65 As System.Data.DataRow() = dataSet.RestaurantPOS_OrderedProductBillHD.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array65 IsNot Nothing AndAlso array65.Length <> 0 Then
                    num += Me._restaurantPOS_OrderedProductBillHDTableAdapter.Update(array65)
                    allChangedRows.AddRange(array65)
                End If
            End If

            If Me._restaurantPOS_OrderedProductBillEBTableAdapter IsNot Nothing Then
                Dim array66 As System.Data.DataRow() = dataSet.RestaurantPOS_OrderedProductBillEB.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array66 IsNot Nothing AndAlso array66.Length <> 0 Then
                    num += Me._restaurantPOS_OrderedProductBillEBTableAdapter.Update(array66)
                    allChangedRows.AddRange(array66)
                End If
            End If

            If Me._walletTableAdapter IsNot Nothing Then
                Dim array67 As System.Data.DataRow() = dataSet.Wallet.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array67 IsNot Nothing AndAlso array67.Length <> 0 Then
                    num += Me._walletTableAdapter.Update(array67)
                    allChangedRows.AddRange(array67)
                End If
            End If

            If Me._restaurantPOS_BillingInfoKOTTableAdapter IsNot Nothing Then
                Dim array68 As System.Data.DataRow() = dataSet.RestaurantPOS_BillingInfoKOT.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array68 IsNot Nothing AndAlso array68.Length <> 0 Then
                    num += Me._restaurantPOS_BillingInfoKOTTableAdapter.Update(array68)
                    allChangedRows.AddRange(array68)
                End If
            End If

            If Me._recipeTableAdapter IsNot Nothing Then
                Dim array69 As System.Data.DataRow() = dataSet.Recipe.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array69 IsNot Nothing AndAlso array69.Length <> 0 Then
                    num += Me._recipeTableAdapter.Update(array69)
                    allChangedRows.AddRange(array69)
                End If
            End If

            If Me._restaurantPOS_BillingInfoHDTableAdapter IsNot Nothing Then
                Dim array70 As System.Data.DataRow() = dataSet.RestaurantPOS_BillingInfoHD.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array70 IsNot Nothing AndAlso array70.Length <> 0 Then
                    num += Me._restaurantPOS_BillingInfoHDTableAdapter.Update(array70)
                    allChangedRows.AddRange(array70)
                End If
            End If

            If Me._purchaseOrderTableAdapter IsNot Nothing Then
                Dim array71 As System.Data.DataRow() = dataSet.PurchaseOrder.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array71 IsNot Nothing AndAlso array71.Length <> 0 Then
                    num += Me._purchaseOrderTableAdapter.Update(array71)
                    allChangedRows.AddRange(array71)
                End If
            End If

            If Me._tempRestaurantPOS_BillingInfoKOTTableAdapter IsNot Nothing Then
                Dim array72 As System.Data.DataRow() = dataSet.TempRestaurantPOS_BillingInfoKOT.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array72 IsNot Nothing AndAlso array72.Length <> 0 Then
                    num += Me._tempRestaurantPOS_BillingInfoKOTTableAdapter.Update(array72)
                    allChangedRows.AddRange(array72)
                End If
            End If

            If Me._restaurantPOS_BillingInfoEBTableAdapter IsNot Nothing Then
                Dim array73 As System.Data.DataRow() = dataSet.RestaurantPOS_BillingInfoEB.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array73 IsNot Nothing AndAlso array73.Length <> 0 Then
                    num += Me._restaurantPOS_BillingInfoEBTableAdapter.Update(array73)
                    allChangedRows.AddRange(array73)
                End If
            End If

            If Me._voucherTableAdapter IsNot Nothing Then
                Dim array74 As System.Data.DataRow() = dataSet.Voucher.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array74 IsNot Nothing AndAlso array74.Length <> 0 Then
                    num += Me._voucherTableAdapter.Update(array74)
                    allChangedRows.AddRange(array74)
                End If
            End If

            If Me._workPeriodStartTableAdapter IsNot Nothing Then
                Dim array75 As System.Data.DataRow() = dataSet.WorkPeriodStart.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array75 IsNot Nothing AndAlso array75.Length <> 0 Then
                    num += Me._workPeriodStartTableAdapter.Update(array75)
                    allChangedRows.AddRange(array75)
                End If
            End If

            If Me._expenseTableAdapter IsNot Nothing Then
                Dim array76 As System.Data.DataRow() = dataSet.Expense.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array76 IsNot Nothing AndAlso array76.Length <> 0 Then
                    num += Me._expenseTableAdapter.Update(array76)
                    allChangedRows.AddRange(array76)
                End If
            End If

            If Me._creditCustomerTableAdapter IsNot Nothing Then
                Dim array77 As System.Data.DataRow() = dataSet.CreditCustomer.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array77 IsNot Nothing AndAlso array77.Length <> 0 Then
                    num += Me._creditCustomerTableAdapter.Update(array77)
                    allChangedRows.AddRange(array77)
                End If
            End If

            If Me._warehouseTableAdapter IsNot Nothing Then
                Dim array78 As System.Data.DataRow() = dataSet.Warehouse.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array78 IsNot Nothing AndAlso array78.Length <> 0 Then
                    num += Me._warehouseTableAdapter.Update(array78)
                    allChangedRows.AddRange(array78)
                End If
            End If

            If Me._purchaseTableAdapter IsNot Nothing Then
                Dim array79 As System.Data.DataRow() = dataSet.Purchase.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array79 IsNot Nothing AndAlso array79.Length <> 0 Then
                    num += Me._purchaseTableAdapter.Update(array79)
                    allChangedRows.AddRange(array79)
                End If
            End If

            If Me._memberTableAdapter IsNot Nothing Then
                Dim array80 As System.Data.DataRow() = dataSet.Member.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array80 IsNot Nothing AndAlso array80.Length <> 0 Then
                    num += Me._memberTableAdapter.Update(array80)
                    allChangedRows.AddRange(array80)
                End If
            End If

            If Me._stockTransferTableAdapter IsNot Nothing Then
                Dim array81 As System.Data.DataRow() = dataSet.StockTransfer.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array81 IsNot Nothing AndAlso array81.Length <> 0 Then
                    num += Me._stockTransferTableAdapter.Update(array81)
                    allChangedRows.AddRange(array81)
                End If
            End If

            If Me._bankAccountRegistrationTableAdapter IsNot Nothing Then
                Dim array82 As System.Data.DataRow() = dataSet.BankAccountRegistration.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array82 IsNot Nothing AndAlso array82.Length <> 0 Then
                    num += Me._bankAccountRegistrationTableAdapter.Update(array82)
                    allChangedRows.AddRange(array82)
                End If
            End If

            If Me._pizzaMasterTableAdapter IsNot Nothing Then
                Dim array83 As System.Data.DataRow() = dataSet.PizzaMaster.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array83 IsNot Nothing AndAlso array83.Length <> 0 Then
                    num += Me._pizzaMasterTableAdapter.Update(array83)
                    allChangedRows.AddRange(array83)
                End If
            End If

            If Me._stock_StoreTableAdapter IsNot Nothing Then
                Dim array84 As System.Data.DataRow() = dataSet.Stock_Store.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array84 IsNot Nothing AndAlso array84.Length <> 0 Then
                    num += Me._stock_StoreTableAdapter.Update(array84)
                    allChangedRows.AddRange(array84)
                End If
            End If

            If Me._restaurantPOS_OrderInfoKOTTableAdapter IsNot Nothing Then
                Dim array85 As System.Data.DataRow() = dataSet.RestaurantPOS_OrderInfoKOT.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array85 IsNot Nothing AndAlso array85.Length <> 0 Then
                    num += Me._restaurantPOS_OrderInfoKOTTableAdapter.Update(array85)
                    allChangedRows.AddRange(array85)
                End If
            End If

            If Me._loyaltyMemberTableAdapter IsNot Nothing Then
                Dim array86 As System.Data.DataRow() = dataSet.LoyaltyMember.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array86 IsNot Nothing AndAlso array86.Length <> 0 Then
                    num += Me._loyaltyMemberTableAdapter.Update(array86)
                    allChangedRows.AddRange(array86)
                End If
            End If

            If Me._restaurantPOS_BillingInfoTATableAdapter IsNot Nothing Then
                Dim array87 As System.Data.DataRow() = dataSet.RestaurantPOS_BillingInfoTA.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array87 IsNot Nothing AndAlso array87.Length <> 0 Then
                    num += Me._restaurantPOS_BillingInfoTATableAdapter.Update(array87)
                    allChangedRows.AddRange(array87)
                End If
            End If

            If Me._rM_UsedTableAdapter IsNot Nothing Then
                Dim array88 As System.Data.DataRow() = dataSet.RM_Used.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array88 IsNot Nothing AndAlso array88.Length <> 0 Then
                    num += Me._rM_UsedTableAdapter.Update(array88)
                    allChangedRows.AddRange(array88)
                End If
            End If

            If Me._clockINTableAdapter IsNot Nothing Then
                Dim array89 As System.Data.DataRow() = dataSet.ClockIN.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array89 IsNot Nothing AndAlso array89.Length <> 0 Then
                    num += Me._clockINTableAdapter.Update(array89)
                    allChangedRows.AddRange(array89)
                End If
            End If

            If Me._productTableAdapter IsNot Nothing Then
                Dim array90 As System.Data.DataRow() = dataSet.Product.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array90 IsNot Nothing AndAlso array90.Length <> 0 Then
                    num += Me._productTableAdapter.Update(array90)
                    allChangedRows.AddRange(array90)
                End If
            End If

            If Me._warehouseTypeTableAdapter IsNot Nothing Then
                Dim array91 As System.Data.DataRow() = dataSet.WarehouseType.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array91 IsNot Nothing AndAlso array91.Length <> 0 Then
                    num += Me._warehouseTypeTableAdapter.Update(array91)
                    allChangedRows.AddRange(array91)
                End If
            End If

            If Me._supplierTableAdapter IsNot Nothing Then
                Dim array92 As System.Data.DataRow() = dataSet.Supplier.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array92 IsNot Nothing AndAlso array92.Length <> 0 Then
                    num += Me._supplierTableAdapter.Update(array92)
                    allChangedRows.AddRange(array92)
                End If
            End If

            If Me._bankBranchTableAdapter IsNot Nothing Then
                Dim array93 As System.Data.DataRow() = dataSet.BankBranch.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array93 IsNot Nothing AndAlso array93.Length <> 0 Then
                    num += Me._bankBranchTableAdapter.Update(array93)
                    allChangedRows.AddRange(array93)
                End If
            End If

            If Me._registrationTableAdapter IsNot Nothing Then
                Dim array94 As System.Data.DataRow() = dataSet.Registration.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array94 IsNot Nothing AndAlso array94.Length <> 0 Then
                    num += Me._registrationTableAdapter.Update(array94)
                    allChangedRows.AddRange(array94)
                End If
            End If

            If Me._r_TableTableAdapter IsNot Nothing Then
                Dim array95 As System.Data.DataRow() = dataSet.R_Table.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array95 IsNot Nothing AndAlso array95.Length <> 0 Then
                    num += Me._r_TableTableAdapter.Update(array95)
                    allChangedRows.AddRange(array95)
                End If
            End If

            If Me._pizzaSizeTableAdapter IsNot Nothing Then
                Dim array96 As System.Data.DataRow() = dataSet.PizzaSize.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array96 IsNot Nothing AndAlso array96.Length <> 0 Then
                    num += Me._pizzaSizeTableAdapter.Update(array96)
                    allChangedRows.AddRange(array96)
                End If
            End If

            If Me._rMCategoryTableAdapter IsNot Nothing Then
                Dim array97 As System.Data.DataRow() = dataSet.RMCategory.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array97 IsNot Nothing AndAlso array97.Length <> 0 Then
                    num += Me._rMCategoryTableAdapter.Update(array97)
                    allChangedRows.AddRange(array97)
                End If
            End If

            If Me._employeeRegistrationTableAdapter IsNot Nothing Then
                Dim array98 As System.Data.DataRow() = dataSet.EmployeeRegistration.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array98 IsNot Nothing AndAlso array98.Length <> 0 Then
                    num += Me._employeeRegistrationTableAdapter.Update(array98)
                    allChangedRows.AddRange(array98)
                End If
            End If

            If Me._dishTableAdapter IsNot Nothing Then
                Dim array99 As System.Data.DataRow() = dataSet.Dish.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array99 IsNot Nothing AndAlso array99.Length <> 0 Then
                    num += Me._dishTableAdapter.Update(array99)
                    allChangedRows.AddRange(array99)
                End If
            End If

            If Me._unitMasterTableAdapter IsNot Nothing Then
                Dim array100 As System.Data.DataRow() = dataSet.UnitMaster.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array100 IsNot Nothing AndAlso array100.Length <> 0 Then
                    num += Me._unitMasterTableAdapter.Update(array100)
                    allChangedRows.AddRange(array100)
                End If
            End If

            If Me._expenseTypeTableAdapter IsNot Nothing Then
                Dim array101 As System.Data.DataRow() = dataSet.ExpenseType.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array101 IsNot Nothing AndAlso array101.Length <> 0 Then
                    num += Me._expenseTypeTableAdapter.Update(array101)
                    allChangedRows.AddRange(array101)
                End If
            End If

            If Me._bankTableAdapter IsNot Nothing Then
                Dim array102 As System.Data.DataRow() = dataSet.Bank.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array102 IsNot Nothing AndAlso array102.Length <> 0 Then
                    num += Me._bankTableAdapter.Update(array102)
                    allChangedRows.AddRange(array102)
                End If
            End If

            If Me._categoryTableAdapter IsNot Nothing Then
                Dim array103 As System.Data.DataRow() = dataSet.Category.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array103 IsNot Nothing AndAlso array103.Length <> 0 Then
                    num += Me._categoryTableAdapter.Update(array103)
                    allChangedRows.AddRange(array103)
                End If
            End If

            If Me._kitchenTableAdapter IsNot Nothing Then
                Dim array104 As System.Data.DataRow() = dataSet.Kitchen.[Select](Nothing, Nothing, System.Data.DataViewRowState.Deleted)
                If array104 IsNot Nothing AndAlso array104.Length <> 0 Then
                    num += Me._kitchenTableAdapter.Update(array104)
                    allChangedRows.AddRange(array104)
                End If
            End If

            Return num
        End Function

        ''' <summary>
        ''' Remove inserted rows that become updated rows after calling TableAdapter.Update(inserted rows) first
        ''' </summary>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Private Function GetRealUpdatedRows(updatedRows As System.Data.DataRow(), allAddedRows As System.Collections.Generic.List(Of System.Data.DataRow)) As System.Data.DataRow()
            If updatedRows Is Nothing OrElse updatedRows.Length < 1 Then
                Return updatedRows
            End If

            If allAddedRows Is Nothing OrElse allAddedRows.Count < 1 Then
                Return updatedRows
            End If

            Dim list As System.Collections.Generic.List(Of System.Data.DataRow) = New System.Collections.Generic.List(Of System.Data.DataRow)()
            For Each item As System.Data.DataRow In updatedRows
                If Not allAddedRows.Contains(item) Then
                    list.Add(item)
                End If
            Next

            Return list.ToArray()
        End Function

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Overridable Function UpdateAll(dataSet As RestaurantPOS14.RPOS_DBDataSet1) As Integer
            If dataSet Is Nothing Then
                Throw New System.ArgumentNullException("dataSet")
            End If

            If Not dataSet.HasChanges() Then
                Return 0
            End If

            If Me._activationTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._activationTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._bankTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._bankTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._bankAccountLedgerTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._bankAccountLedgerTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._bankAccountRegistrationTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._bankAccountRegistrationTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._bankBranchTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._bankBranchTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._categoryTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._categoryTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._clockINTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._clockINTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._clockOUTTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._clockOUTTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._cMISettingTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._cMISettingTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._creditCustomerTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._creditCustomerTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._creditCustomerLedgerTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._creditCustomerLedgerTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._creditCustomerPaymentTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._creditCustomerPaymentTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._currencyTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._currencyTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._deletedInvoicesTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._deletedInvoicesTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._deletedInvoices_JoinTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._deletedInvoices_JoinTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._dishTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._dishTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._emailSettingTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._emailSettingTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._employeeRegistrationTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._employeeRegistrationTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._expenseTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._expenseTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._expenseTypeTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._expenseTypeTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._fundDepositTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._fundDepositTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._fundTransferTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._fundTransferTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._giftCardTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._giftCardTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._gridGroupingTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._gridGroupingTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._hDCustomerTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._hDCustomerTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._holdBillTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._holdBillTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._holdItemsTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._holdItemsTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._hotelTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._hotelTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._journalTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._journalTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._kitchenTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._kitchenTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._ledgerBookTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._ledgerBookTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._logsTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._logsTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._loyaltyMemberTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._loyaltyMemberTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._loyaltyMemberLedgerBookTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._loyaltyMemberLedgerBookTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._loyaltySettingTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._loyaltySettingTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._memberTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._memberTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._memberLedgerTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._memberLedgerTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._modifiersTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._modifiersTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._mpesaSettingTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._mpesaSettingTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._notesMasterTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._notesMasterTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._otherSettingTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._otherSettingTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._paymentTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._paymentTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._payment_WithdrawTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._payment_WithdrawTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._payrollTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._payrollTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._payroll_MBTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._payroll_MBTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._pizzaMasterTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._pizzaMasterTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._pizzaModifierTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._pizzaModifierTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._pizzaSizeTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._pizzaSizeTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._pizzaToppingTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._pizzaToppingTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._posGroupingTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._posGroupingTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._posGrouping1TableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._posGrouping1TableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._posPrinterSettingTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._posPrinterSettingTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._productTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._productTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._product_OpeningStockTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._product_OpeningStockTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._promotionTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._promotionTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._purchaseTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._purchaseTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._purchase_JoinTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._purchase_JoinTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._purchaseOrderTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._purchaseOrderTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._purchaseOrder_JoinTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._purchaseOrder_JoinTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._r_TableTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._r_TableTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._recipeTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._recipeTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._recipe_JoinTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._recipe_JoinTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._registrationTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._registrationTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._restaurantPOS_BillingInfoEBTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._restaurantPOS_BillingInfoEBTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._restaurantPOS_BillingInfoHDTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._restaurantPOS_BillingInfoHDTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._restaurantPOS_BillingInfoKOTTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._restaurantPOS_BillingInfoKOTTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._restaurantPOS_BillingInfoTATableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._restaurantPOS_BillingInfoTATableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._restaurantPOS_OrderedProductBillEBTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._restaurantPOS_OrderedProductBillEBTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._restaurantPOS_OrderedProductBillHDTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._restaurantPOS_OrderedProductBillHDTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._restaurantPOS_OrderedProductBillKOTTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._restaurantPOS_OrderedProductBillKOTTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._restaurantPOS_OrderedProductBillTATableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._restaurantPOS_OrderedProductBillTATableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._restaurantPOS_OrderedProductKOTTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._restaurantPOS_OrderedProductKOTTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._restaurantPOS_OrderInfoKOTTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._restaurantPOS_OrderInfoKOTTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._rM_UsedTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._rM_UsedTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._rM_Used_JoinTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._rM_Used_JoinTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._rMCategoryTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._rMCategoryTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._sMSSettingTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._sMSSettingTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._stock_StoreTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._stock_StoreTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._stock_Store_JoinTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._stock_Store_JoinTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._stockAdjustment_MITableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._stockAdjustment_MITableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._stockAdjustment_StoreTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._stockAdjustment_StoreTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._stockAdjustment_WarehouseTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._stockAdjustment_WarehouseTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._stockTransferTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._stockTransferTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._stockTransfer_JoinTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._stockTransfer_JoinTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._supplierTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._supplierTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._supplierLedgerBookTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._supplierLedgerBookTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._tableLayoutTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._tableLayoutTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._tableMappingTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._tableMappingTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._tableReservationTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._tableReservationTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._tblOrderTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._tblOrderTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._temp_StockTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._temp_StockTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._temp_Stock_RMTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._temp_Stock_RMTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._temp_Stock_StoreTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._temp_Stock_StoreTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._tempRestaurantPOS_BillingInfoKOTTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._tempRestaurantPOS_BillingInfoKOTTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._tempRestaurantPOS_OrderedProductBillKOTTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._tempRestaurantPOS_OrderedProductBillKOTTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._unitMasterTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._unitMasterTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._userRightsTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._userRightsTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._voucherTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._voucherTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._voucher_OtherDetailsTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._voucher_OtherDetailsTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._walletTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._walletTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._warehouseTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._warehouseTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._warehouseTypeTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._warehouseTypeTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._workPeriodEndTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._workPeriodEndTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            If Me._workPeriodStartTableAdapter IsNot Nothing AndAlso Not Me.MatchTableAdapterConnection(Me._workPeriodStartTableAdapter.Connection) Then
                Throw New System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
            End If

            Dim connection As System.Data.IDbConnection = Me.Connection
            If connection Is Nothing Then
                Throw New System.ApplicationException("TableAdapterManager contains no connection information. Set each TableAdapterManager TableAdapter property to a valid TableAdapter instance.")
            End If

            Dim flag As Boolean = False
            If(connection.State And System.Data.ConnectionState.Broken) = System.Data.ConnectionState.Broken Then
                connection.Close()
            End If

            If connection.State = System.Data.ConnectionState.Closed Then
                connection.Open()
                flag = True
            End If

            Dim dbTransaction As System.Data.IDbTransaction = connection.BeginTransaction()
            If dbTransaction Is Nothing Then
                Throw New System.ApplicationException("The transaction cannot begin. The current data connection does not support transactions or the current state is not allowing the transaction to begin.")
            End If

            Dim list As System.Collections.Generic.List(Of System.Data.DataRow) = New System.Collections.Generic.List(Of System.Data.DataRow)()
            Dim list2 As System.Collections.Generic.List(Of System.Data.DataRow) = New System.Collections.Generic.List(Of System.Data.DataRow)()
            Dim list3 As System.Collections.Generic.List(Of System.Data.Common.DataAdapter) = New System.Collections.Generic.List(Of System.Data.Common.DataAdapter)()
            Dim dictionary As System.Collections.Generic.Dictionary(Of Object, System.Data.IDbConnection) = New System.Collections.Generic.Dictionary(Of Object, System.Data.IDbConnection)()
            Dim num As Integer = 0
            Dim dataSet2 As System.Data.DataSet = Nothing
            If Me.BackupDataSetBeforeUpdate Then
                dataSet2 = New System.Data.DataSet()
                dataSet2.Merge(dataSet)
            End If

            Try
                If Me._activationTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._activationTableAdapter, Me._activationTableAdapter.Connection)
                    Me._activationTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._activationTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._activationTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._activationTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._activationTableAdapter.Adapter)
                    End If
                End If

                If Me._bankTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._bankTableAdapter, Me._bankTableAdapter.Connection)
                    Me._bankTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._bankTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._bankTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._bankTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._bankTableAdapter.Adapter)
                    End If
                End If

                If Me._bankAccountLedgerTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._bankAccountLedgerTableAdapter, Me._bankAccountLedgerTableAdapter.Connection)
                    Me._bankAccountLedgerTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._bankAccountLedgerTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._bankAccountLedgerTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._bankAccountLedgerTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._bankAccountLedgerTableAdapter.Adapter)
                    End If
                End If

                If Me._bankAccountRegistrationTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._bankAccountRegistrationTableAdapter, Me._bankAccountRegistrationTableAdapter.Connection)
                    Me._bankAccountRegistrationTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._bankAccountRegistrationTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._bankAccountRegistrationTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._bankAccountRegistrationTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._bankAccountRegistrationTableAdapter.Adapter)
                    End If
                End If

                If Me._bankBranchTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._bankBranchTableAdapter, Me._bankBranchTableAdapter.Connection)
                    Me._bankBranchTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._bankBranchTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._bankBranchTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._bankBranchTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._bankBranchTableAdapter.Adapter)
                    End If
                End If

                If Me._categoryTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._categoryTableAdapter, Me._categoryTableAdapter.Connection)
                    Me._categoryTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._categoryTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._categoryTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._categoryTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._categoryTableAdapter.Adapter)
                    End If
                End If

                If Me._clockINTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._clockINTableAdapter, Me._clockINTableAdapter.Connection)
                    Me._clockINTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._clockINTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._clockINTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._clockINTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._clockINTableAdapter.Adapter)
                    End If
                End If

                If Me._clockOUTTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._clockOUTTableAdapter, Me._clockOUTTableAdapter.Connection)
                    Me._clockOUTTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._clockOUTTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._clockOUTTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._clockOUTTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._clockOUTTableAdapter.Adapter)
                    End If
                End If

                If Me._cMISettingTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._cMISettingTableAdapter, Me._cMISettingTableAdapter.Connection)
                    Me._cMISettingTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._cMISettingTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._cMISettingTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._cMISettingTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._cMISettingTableAdapter.Adapter)
                    End If
                End If

                If Me._creditCustomerTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._creditCustomerTableAdapter, Me._creditCustomerTableAdapter.Connection)
                    Me._creditCustomerTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._creditCustomerTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._creditCustomerTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._creditCustomerTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._creditCustomerTableAdapter.Adapter)
                    End If
                End If

                If Me._creditCustomerLedgerTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._creditCustomerLedgerTableAdapter, Me._creditCustomerLedgerTableAdapter.Connection)
                    Me._creditCustomerLedgerTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._creditCustomerLedgerTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._creditCustomerLedgerTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._creditCustomerLedgerTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._creditCustomerLedgerTableAdapter.Adapter)
                    End If
                End If

                If Me._creditCustomerPaymentTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._creditCustomerPaymentTableAdapter, Me._creditCustomerPaymentTableAdapter.Connection)
                    Me._creditCustomerPaymentTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._creditCustomerPaymentTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._creditCustomerPaymentTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._creditCustomerPaymentTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._creditCustomerPaymentTableAdapter.Adapter)
                    End If
                End If

                If Me._currencyTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._currencyTableAdapter, Me._currencyTableAdapter.Connection)
                    Me._currencyTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._currencyTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._currencyTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._currencyTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._currencyTableAdapter.Adapter)
                    End If
                End If

                If Me._deletedInvoicesTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._deletedInvoicesTableAdapter, Me._deletedInvoicesTableAdapter.Connection)
                    Me._deletedInvoicesTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._deletedInvoicesTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._deletedInvoicesTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._deletedInvoicesTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._deletedInvoicesTableAdapter.Adapter)
                    End If
                End If

                If Me._deletedInvoices_JoinTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._deletedInvoices_JoinTableAdapter, Me._deletedInvoices_JoinTableAdapter.Connection)
                    Me._deletedInvoices_JoinTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._deletedInvoices_JoinTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._deletedInvoices_JoinTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._deletedInvoices_JoinTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._deletedInvoices_JoinTableAdapter.Adapter)
                    End If
                End If

                If Me._dishTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._dishTableAdapter, Me._dishTableAdapter.Connection)
                    Me._dishTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._dishTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._dishTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._dishTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._dishTableAdapter.Adapter)
                    End If
                End If

                If Me._emailSettingTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._emailSettingTableAdapter, Me._emailSettingTableAdapter.Connection)
                    Me._emailSettingTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._emailSettingTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._emailSettingTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._emailSettingTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._emailSettingTableAdapter.Adapter)
                    End If
                End If

                If Me._employeeRegistrationTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._employeeRegistrationTableAdapter, Me._employeeRegistrationTableAdapter.Connection)
                    Me._employeeRegistrationTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._employeeRegistrationTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._employeeRegistrationTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._employeeRegistrationTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._employeeRegistrationTableAdapter.Adapter)
                    End If
                End If

                If Me._expenseTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._expenseTableAdapter, Me._expenseTableAdapter.Connection)
                    Me._expenseTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._expenseTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._expenseTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._expenseTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._expenseTableAdapter.Adapter)
                    End If
                End If

                If Me._expenseTypeTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._expenseTypeTableAdapter, Me._expenseTypeTableAdapter.Connection)
                    Me._expenseTypeTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._expenseTypeTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._expenseTypeTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._expenseTypeTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._expenseTypeTableAdapter.Adapter)
                    End If
                End If

                If Me._fundDepositTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._fundDepositTableAdapter, Me._fundDepositTableAdapter.Connection)
                    Me._fundDepositTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._fundDepositTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._fundDepositTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._fundDepositTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._fundDepositTableAdapter.Adapter)
                    End If
                End If

                If Me._fundTransferTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._fundTransferTableAdapter, Me._fundTransferTableAdapter.Connection)
                    Me._fundTransferTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._fundTransferTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._fundTransferTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._fundTransferTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._fundTransferTableAdapter.Adapter)
                    End If
                End If

                If Me._giftCardTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._giftCardTableAdapter, Me._giftCardTableAdapter.Connection)
                    Me._giftCardTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._giftCardTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._giftCardTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._giftCardTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._giftCardTableAdapter.Adapter)
                    End If
                End If

                If Me._gridGroupingTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._gridGroupingTableAdapter, Me._gridGroupingTableAdapter.Connection)
                    Me._gridGroupingTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._gridGroupingTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._gridGroupingTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._gridGroupingTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._gridGroupingTableAdapter.Adapter)
                    End If
                End If

                If Me._hDCustomerTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._hDCustomerTableAdapter, Me._hDCustomerTableAdapter.Connection)
                    Me._hDCustomerTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._hDCustomerTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._hDCustomerTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._hDCustomerTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._hDCustomerTableAdapter.Adapter)
                    End If
                End If

                If Me._holdBillTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._holdBillTableAdapter, Me._holdBillTableAdapter.Connection)
                    Me._holdBillTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._holdBillTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._holdBillTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._holdBillTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._holdBillTableAdapter.Adapter)
                    End If
                End If

                If Me._holdItemsTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._holdItemsTableAdapter, Me._holdItemsTableAdapter.Connection)
                    Me._holdItemsTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._holdItemsTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._holdItemsTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._holdItemsTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._holdItemsTableAdapter.Adapter)
                    End If
                End If

                If Me._hotelTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._hotelTableAdapter, Me._hotelTableAdapter.Connection)
                    Me._hotelTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._hotelTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._hotelTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._hotelTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._hotelTableAdapter.Adapter)
                    End If
                End If

                If Me._journalTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._journalTableAdapter, Me._journalTableAdapter.Connection)
                    Me._journalTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._journalTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._journalTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._journalTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._journalTableAdapter.Adapter)
                    End If
                End If

                If Me._kitchenTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._kitchenTableAdapter, Me._kitchenTableAdapter.Connection)
                    Me._kitchenTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._kitchenTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._kitchenTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._kitchenTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._kitchenTableAdapter.Adapter)
                    End If
                End If

                If Me._ledgerBookTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._ledgerBookTableAdapter, Me._ledgerBookTableAdapter.Connection)
                    Me._ledgerBookTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._ledgerBookTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._ledgerBookTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._ledgerBookTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._ledgerBookTableAdapter.Adapter)
                    End If
                End If

                If Me._logsTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._logsTableAdapter, Me._logsTableAdapter.Connection)
                    Me._logsTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._logsTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._logsTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._logsTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._logsTableAdapter.Adapter)
                    End If
                End If

                If Me._loyaltyMemberTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._loyaltyMemberTableAdapter, Me._loyaltyMemberTableAdapter.Connection)
                    Me._loyaltyMemberTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._loyaltyMemberTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._loyaltyMemberTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._loyaltyMemberTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._loyaltyMemberTableAdapter.Adapter)
                    End If
                End If

                If Me._loyaltyMemberLedgerBookTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._loyaltyMemberLedgerBookTableAdapter, Me._loyaltyMemberLedgerBookTableAdapter.Connection)
                    Me._loyaltyMemberLedgerBookTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._loyaltyMemberLedgerBookTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._loyaltyMemberLedgerBookTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._loyaltyMemberLedgerBookTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._loyaltyMemberLedgerBookTableAdapter.Adapter)
                    End If
                End If

                If Me._loyaltySettingTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._loyaltySettingTableAdapter, Me._loyaltySettingTableAdapter.Connection)
                    Me._loyaltySettingTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._loyaltySettingTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._loyaltySettingTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._loyaltySettingTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._loyaltySettingTableAdapter.Adapter)
                    End If
                End If

                If Me._memberTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._memberTableAdapter, Me._memberTableAdapter.Connection)
                    Me._memberTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._memberTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._memberTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._memberTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._memberTableAdapter.Adapter)
                    End If
                End If

                If Me._memberLedgerTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._memberLedgerTableAdapter, Me._memberLedgerTableAdapter.Connection)
                    Me._memberLedgerTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._memberLedgerTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._memberLedgerTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._memberLedgerTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._memberLedgerTableAdapter.Adapter)
                    End If
                End If

                If Me._modifiersTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._modifiersTableAdapter, Me._modifiersTableAdapter.Connection)
                    Me._modifiersTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._modifiersTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._modifiersTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._modifiersTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._modifiersTableAdapter.Adapter)
                    End If
                End If

                If Me._mpesaSettingTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._mpesaSettingTableAdapter, Me._mpesaSettingTableAdapter.Connection)
                    Me._mpesaSettingTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._mpesaSettingTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._mpesaSettingTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._mpesaSettingTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._mpesaSettingTableAdapter.Adapter)
                    End If
                End If

                If Me._notesMasterTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._notesMasterTableAdapter, Me._notesMasterTableAdapter.Connection)
                    Me._notesMasterTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._notesMasterTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._notesMasterTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._notesMasterTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._notesMasterTableAdapter.Adapter)
                    End If
                End If

                If Me._otherSettingTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._otherSettingTableAdapter, Me._otherSettingTableAdapter.Connection)
                    Me._otherSettingTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._otherSettingTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._otherSettingTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._otherSettingTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._otherSettingTableAdapter.Adapter)
                    End If
                End If

                If Me._paymentTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._paymentTableAdapter, Me._paymentTableAdapter.Connection)
                    Me._paymentTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._paymentTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._paymentTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._paymentTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._paymentTableAdapter.Adapter)
                    End If
                End If

                If Me._payment_WithdrawTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._payment_WithdrawTableAdapter, Me._payment_WithdrawTableAdapter.Connection)
                    Me._payment_WithdrawTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._payment_WithdrawTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._payment_WithdrawTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._payment_WithdrawTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._payment_WithdrawTableAdapter.Adapter)
                    End If
                End If

                If Me._payrollTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._payrollTableAdapter, Me._payrollTableAdapter.Connection)
                    Me._payrollTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._payrollTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._payrollTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._payrollTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._payrollTableAdapter.Adapter)
                    End If
                End If

                If Me._payroll_MBTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._payroll_MBTableAdapter, Me._payroll_MBTableAdapter.Connection)
                    Me._payroll_MBTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._payroll_MBTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._payroll_MBTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._payroll_MBTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._payroll_MBTableAdapter.Adapter)
                    End If
                End If

                If Me._pizzaMasterTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._pizzaMasterTableAdapter, Me._pizzaMasterTableAdapter.Connection)
                    Me._pizzaMasterTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._pizzaMasterTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._pizzaMasterTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._pizzaMasterTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._pizzaMasterTableAdapter.Adapter)
                    End If
                End If

                If Me._pizzaModifierTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._pizzaModifierTableAdapter, Me._pizzaModifierTableAdapter.Connection)
                    Me._pizzaModifierTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._pizzaModifierTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._pizzaModifierTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._pizzaModifierTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._pizzaModifierTableAdapter.Adapter)
                    End If
                End If

                If Me._pizzaSizeTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._pizzaSizeTableAdapter, Me._pizzaSizeTableAdapter.Connection)
                    Me._pizzaSizeTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._pizzaSizeTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._pizzaSizeTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._pizzaSizeTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._pizzaSizeTableAdapter.Adapter)
                    End If
                End If

                If Me._pizzaToppingTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._pizzaToppingTableAdapter, Me._pizzaToppingTableAdapter.Connection)
                    Me._pizzaToppingTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._pizzaToppingTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._pizzaToppingTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._pizzaToppingTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._pizzaToppingTableAdapter.Adapter)
                    End If
                End If

                If Me._posGroupingTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._posGroupingTableAdapter, Me._posGroupingTableAdapter.Connection)
                    Me._posGroupingTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._posGroupingTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._posGroupingTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._posGroupingTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._posGroupingTableAdapter.Adapter)
                    End If
                End If

                If Me._posGrouping1TableAdapter IsNot Nothing Then
                    dictionary.Add(Me._posGrouping1TableAdapter, Me._posGrouping1TableAdapter.Connection)
                    Me._posGrouping1TableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._posGrouping1TableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._posGrouping1TableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._posGrouping1TableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._posGrouping1TableAdapter.Adapter)
                    End If
                End If

                If Me._posPrinterSettingTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._posPrinterSettingTableAdapter, Me._posPrinterSettingTableAdapter.Connection)
                    Me._posPrinterSettingTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._posPrinterSettingTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._posPrinterSettingTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._posPrinterSettingTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._posPrinterSettingTableAdapter.Adapter)
                    End If
                End If

                If Me._productTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._productTableAdapter, Me._productTableAdapter.Connection)
                    Me._productTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._productTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._productTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._productTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._productTableAdapter.Adapter)
                    End If
                End If

                If Me._product_OpeningStockTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._product_OpeningStockTableAdapter, Me._product_OpeningStockTableAdapter.Connection)
                    Me._product_OpeningStockTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._product_OpeningStockTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._product_OpeningStockTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._product_OpeningStockTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._product_OpeningStockTableAdapter.Adapter)
                    End If
                End If

                If Me._promotionTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._promotionTableAdapter, Me._promotionTableAdapter.Connection)
                    Me._promotionTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._promotionTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._promotionTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._promotionTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._promotionTableAdapter.Adapter)
                    End If
                End If

                If Me._purchaseTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._purchaseTableAdapter, Me._purchaseTableAdapter.Connection)
                    Me._purchaseTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._purchaseTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._purchaseTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._purchaseTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._purchaseTableAdapter.Adapter)
                    End If
                End If

                If Me._purchase_JoinTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._purchase_JoinTableAdapter, Me._purchase_JoinTableAdapter.Connection)
                    Me._purchase_JoinTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._purchase_JoinTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._purchase_JoinTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._purchase_JoinTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._purchase_JoinTableAdapter.Adapter)
                    End If
                End If

                If Me._purchaseOrderTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._purchaseOrderTableAdapter, Me._purchaseOrderTableAdapter.Connection)
                    Me._purchaseOrderTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._purchaseOrderTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._purchaseOrderTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._purchaseOrderTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._purchaseOrderTableAdapter.Adapter)
                    End If
                End If

                If Me._purchaseOrder_JoinTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._purchaseOrder_JoinTableAdapter, Me._purchaseOrder_JoinTableAdapter.Connection)
                    Me._purchaseOrder_JoinTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._purchaseOrder_JoinTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._purchaseOrder_JoinTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._purchaseOrder_JoinTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._purchaseOrder_JoinTableAdapter.Adapter)
                    End If
                End If

                If Me._r_TableTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._r_TableTableAdapter, Me._r_TableTableAdapter.Connection)
                    Me._r_TableTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._r_TableTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._r_TableTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._r_TableTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._r_TableTableAdapter.Adapter)
                    End If
                End If

                If Me._recipeTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._recipeTableAdapter, Me._recipeTableAdapter.Connection)
                    Me._recipeTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._recipeTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._recipeTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._recipeTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._recipeTableAdapter.Adapter)
                    End If
                End If

                If Me._recipe_JoinTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._recipe_JoinTableAdapter, Me._recipe_JoinTableAdapter.Connection)
                    Me._recipe_JoinTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._recipe_JoinTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._recipe_JoinTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._recipe_JoinTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._recipe_JoinTableAdapter.Adapter)
                    End If
                End If

                If Me._registrationTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._registrationTableAdapter, Me._registrationTableAdapter.Connection)
                    Me._registrationTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._registrationTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._registrationTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._registrationTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._registrationTableAdapter.Adapter)
                    End If
                End If

                If Me._restaurantPOS_BillingInfoEBTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._restaurantPOS_BillingInfoEBTableAdapter, Me._restaurantPOS_BillingInfoEBTableAdapter.Connection)
                    Me._restaurantPOS_BillingInfoEBTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._restaurantPOS_BillingInfoEBTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._restaurantPOS_BillingInfoEBTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._restaurantPOS_BillingInfoEBTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._restaurantPOS_BillingInfoEBTableAdapter.Adapter)
                    End If
                End If

                If Me._restaurantPOS_BillingInfoHDTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._restaurantPOS_BillingInfoHDTableAdapter, Me._restaurantPOS_BillingInfoHDTableAdapter.Connection)
                    Me._restaurantPOS_BillingInfoHDTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._restaurantPOS_BillingInfoHDTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._restaurantPOS_BillingInfoHDTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._restaurantPOS_BillingInfoHDTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._restaurantPOS_BillingInfoHDTableAdapter.Adapter)
                    End If
                End If

                If Me._restaurantPOS_BillingInfoKOTTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._restaurantPOS_BillingInfoKOTTableAdapter, Me._restaurantPOS_BillingInfoKOTTableAdapter.Connection)
                    Me._restaurantPOS_BillingInfoKOTTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._restaurantPOS_BillingInfoKOTTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._restaurantPOS_BillingInfoKOTTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._restaurantPOS_BillingInfoKOTTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._restaurantPOS_BillingInfoKOTTableAdapter.Adapter)
                    End If
                End If

                If Me._restaurantPOS_BillingInfoTATableAdapter IsNot Nothing Then
                    dictionary.Add(Me._restaurantPOS_BillingInfoTATableAdapter, Me._restaurantPOS_BillingInfoTATableAdapter.Connection)
                    Me._restaurantPOS_BillingInfoTATableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._restaurantPOS_BillingInfoTATableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._restaurantPOS_BillingInfoTATableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._restaurantPOS_BillingInfoTATableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._restaurantPOS_BillingInfoTATableAdapter.Adapter)
                    End If
                End If

                If Me._restaurantPOS_OrderedProductBillEBTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._restaurantPOS_OrderedProductBillEBTableAdapter, Me._restaurantPOS_OrderedProductBillEBTableAdapter.Connection)
                    Me._restaurantPOS_OrderedProductBillEBTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._restaurantPOS_OrderedProductBillEBTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._restaurantPOS_OrderedProductBillEBTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._restaurantPOS_OrderedProductBillEBTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._restaurantPOS_OrderedProductBillEBTableAdapter.Adapter)
                    End If
                End If

                If Me._restaurantPOS_OrderedProductBillHDTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._restaurantPOS_OrderedProductBillHDTableAdapter, Me._restaurantPOS_OrderedProductBillHDTableAdapter.Connection)
                    Me._restaurantPOS_OrderedProductBillHDTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._restaurantPOS_OrderedProductBillHDTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._restaurantPOS_OrderedProductBillHDTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._restaurantPOS_OrderedProductBillHDTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._restaurantPOS_OrderedProductBillHDTableAdapter.Adapter)
                    End If
                End If

                If Me._restaurantPOS_OrderedProductBillKOTTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._restaurantPOS_OrderedProductBillKOTTableAdapter, Me._restaurantPOS_OrderedProductBillKOTTableAdapter.Connection)
                    Me._restaurantPOS_OrderedProductBillKOTTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._restaurantPOS_OrderedProductBillKOTTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._restaurantPOS_OrderedProductBillKOTTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._restaurantPOS_OrderedProductBillKOTTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._restaurantPOS_OrderedProductBillKOTTableAdapter.Adapter)
                    End If
                End If

                If Me._restaurantPOS_OrderedProductBillTATableAdapter IsNot Nothing Then
                    dictionary.Add(Me._restaurantPOS_OrderedProductBillTATableAdapter, Me._restaurantPOS_OrderedProductBillTATableAdapter.Connection)
                    Me._restaurantPOS_OrderedProductBillTATableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._restaurantPOS_OrderedProductBillTATableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._restaurantPOS_OrderedProductBillTATableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._restaurantPOS_OrderedProductBillTATableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._restaurantPOS_OrderedProductBillTATableAdapter.Adapter)
                    End If
                End If

                If Me._restaurantPOS_OrderedProductKOTTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._restaurantPOS_OrderedProductKOTTableAdapter, Me._restaurantPOS_OrderedProductKOTTableAdapter.Connection)
                    Me._restaurantPOS_OrderedProductKOTTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._restaurantPOS_OrderedProductKOTTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._restaurantPOS_OrderedProductKOTTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._restaurantPOS_OrderedProductKOTTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._restaurantPOS_OrderedProductKOTTableAdapter.Adapter)
                    End If
                End If

                If Me._restaurantPOS_OrderInfoKOTTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._restaurantPOS_OrderInfoKOTTableAdapter, Me._restaurantPOS_OrderInfoKOTTableAdapter.Connection)
                    Me._restaurantPOS_OrderInfoKOTTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._restaurantPOS_OrderInfoKOTTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._restaurantPOS_OrderInfoKOTTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._restaurantPOS_OrderInfoKOTTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._restaurantPOS_OrderInfoKOTTableAdapter.Adapter)
                    End If
                End If

                If Me._rM_UsedTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._rM_UsedTableAdapter, Me._rM_UsedTableAdapter.Connection)
                    Me._rM_UsedTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._rM_UsedTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._rM_UsedTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._rM_UsedTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._rM_UsedTableAdapter.Adapter)
                    End If
                End If

                If Me._rM_Used_JoinTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._rM_Used_JoinTableAdapter, Me._rM_Used_JoinTableAdapter.Connection)
                    Me._rM_Used_JoinTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._rM_Used_JoinTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._rM_Used_JoinTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._rM_Used_JoinTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._rM_Used_JoinTableAdapter.Adapter)
                    End If
                End If

                If Me._rMCategoryTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._rMCategoryTableAdapter, Me._rMCategoryTableAdapter.Connection)
                    Me._rMCategoryTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._rMCategoryTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._rMCategoryTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._rMCategoryTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._rMCategoryTableAdapter.Adapter)
                    End If
                End If

                If Me._sMSSettingTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._sMSSettingTableAdapter, Me._sMSSettingTableAdapter.Connection)
                    Me._sMSSettingTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._sMSSettingTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._sMSSettingTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._sMSSettingTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._sMSSettingTableAdapter.Adapter)
                    End If
                End If

                If Me._stock_StoreTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._stock_StoreTableAdapter, Me._stock_StoreTableAdapter.Connection)
                    Me._stock_StoreTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._stock_StoreTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._stock_StoreTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._stock_StoreTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._stock_StoreTableAdapter.Adapter)
                    End If
                End If

                If Me._stock_Store_JoinTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._stock_Store_JoinTableAdapter, Me._stock_Store_JoinTableAdapter.Connection)
                    Me._stock_Store_JoinTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._stock_Store_JoinTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._stock_Store_JoinTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._stock_Store_JoinTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._stock_Store_JoinTableAdapter.Adapter)
                    End If
                End If

                If Me._stockAdjustment_MITableAdapter IsNot Nothing Then
                    dictionary.Add(Me._stockAdjustment_MITableAdapter, Me._stockAdjustment_MITableAdapter.Connection)
                    Me._stockAdjustment_MITableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._stockAdjustment_MITableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._stockAdjustment_MITableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._stockAdjustment_MITableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._stockAdjustment_MITableAdapter.Adapter)
                    End If
                End If

                If Me._stockAdjustment_StoreTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._stockAdjustment_StoreTableAdapter, Me._stockAdjustment_StoreTableAdapter.Connection)
                    Me._stockAdjustment_StoreTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._stockAdjustment_StoreTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._stockAdjustment_StoreTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._stockAdjustment_StoreTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._stockAdjustment_StoreTableAdapter.Adapter)
                    End If
                End If

                If Me._stockAdjustment_WarehouseTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._stockAdjustment_WarehouseTableAdapter, Me._stockAdjustment_WarehouseTableAdapter.Connection)
                    Me._stockAdjustment_WarehouseTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._stockAdjustment_WarehouseTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._stockAdjustment_WarehouseTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._stockAdjustment_WarehouseTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._stockAdjustment_WarehouseTableAdapter.Adapter)
                    End If
                End If

                If Me._stockTransferTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._stockTransferTableAdapter, Me._stockTransferTableAdapter.Connection)
                    Me._stockTransferTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._stockTransferTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._stockTransferTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._stockTransferTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._stockTransferTableAdapter.Adapter)
                    End If
                End If

                If Me._stockTransfer_JoinTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._stockTransfer_JoinTableAdapter, Me._stockTransfer_JoinTableAdapter.Connection)
                    Me._stockTransfer_JoinTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._stockTransfer_JoinTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._stockTransfer_JoinTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._stockTransfer_JoinTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._stockTransfer_JoinTableAdapter.Adapter)
                    End If
                End If

                If Me._supplierTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._supplierTableAdapter, Me._supplierTableAdapter.Connection)
                    Me._supplierTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._supplierTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._supplierTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._supplierTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._supplierTableAdapter.Adapter)
                    End If
                End If

                If Me._supplierLedgerBookTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._supplierLedgerBookTableAdapter, Me._supplierLedgerBookTableAdapter.Connection)
                    Me._supplierLedgerBookTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._supplierLedgerBookTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._supplierLedgerBookTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._supplierLedgerBookTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._supplierLedgerBookTableAdapter.Adapter)
                    End If
                End If

                If Me._tableLayoutTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._tableLayoutTableAdapter, Me._tableLayoutTableAdapter.Connection)
                    Me._tableLayoutTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._tableLayoutTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._tableLayoutTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._tableLayoutTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._tableLayoutTableAdapter.Adapter)
                    End If
                End If

                If Me._tableMappingTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._tableMappingTableAdapter, Me._tableMappingTableAdapter.Connection)
                    Me._tableMappingTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._tableMappingTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._tableMappingTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._tableMappingTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._tableMappingTableAdapter.Adapter)
                    End If
                End If

                If Me._tableReservationTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._tableReservationTableAdapter, Me._tableReservationTableAdapter.Connection)
                    Me._tableReservationTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._tableReservationTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._tableReservationTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._tableReservationTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._tableReservationTableAdapter.Adapter)
                    End If
                End If

                If Me._tblOrderTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._tblOrderTableAdapter, Me._tblOrderTableAdapter.Connection)
                    Me._tblOrderTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._tblOrderTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._tblOrderTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._tblOrderTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._tblOrderTableAdapter.Adapter)
                    End If
                End If

                If Me._temp_StockTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._temp_StockTableAdapter, Me._temp_StockTableAdapter.Connection)
                    Me._temp_StockTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._temp_StockTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._temp_StockTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._temp_StockTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._temp_StockTableAdapter.Adapter)
                    End If
                End If

                If Me._temp_Stock_RMTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._temp_Stock_RMTableAdapter, Me._temp_Stock_RMTableAdapter.Connection)
                    Me._temp_Stock_RMTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._temp_Stock_RMTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._temp_Stock_RMTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._temp_Stock_RMTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._temp_Stock_RMTableAdapter.Adapter)
                    End If
                End If

                If Me._temp_Stock_StoreTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._temp_Stock_StoreTableAdapter, Me._temp_Stock_StoreTableAdapter.Connection)
                    Me._temp_Stock_StoreTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._temp_Stock_StoreTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._temp_Stock_StoreTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._temp_Stock_StoreTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._temp_Stock_StoreTableAdapter.Adapter)
                    End If
                End If

                If Me._tempRestaurantPOS_BillingInfoKOTTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._tempRestaurantPOS_BillingInfoKOTTableAdapter, Me._tempRestaurantPOS_BillingInfoKOTTableAdapter.Connection)
                    Me._tempRestaurantPOS_BillingInfoKOTTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._tempRestaurantPOS_BillingInfoKOTTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._tempRestaurantPOS_BillingInfoKOTTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._tempRestaurantPOS_BillingInfoKOTTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._tempRestaurantPOS_BillingInfoKOTTableAdapter.Adapter)
                    End If
                End If

                If Me._tempRestaurantPOS_OrderedProductBillKOTTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._tempRestaurantPOS_OrderedProductBillKOTTableAdapter, Me._tempRestaurantPOS_OrderedProductBillKOTTableAdapter.Connection)
                    Me._tempRestaurantPOS_OrderedProductBillKOTTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._tempRestaurantPOS_OrderedProductBillKOTTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._tempRestaurantPOS_OrderedProductBillKOTTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._tempRestaurantPOS_OrderedProductBillKOTTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._tempRestaurantPOS_OrderedProductBillKOTTableAdapter.Adapter)
                    End If
                End If

                If Me._unitMasterTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._unitMasterTableAdapter, Me._unitMasterTableAdapter.Connection)
                    Me._unitMasterTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._unitMasterTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._unitMasterTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._unitMasterTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._unitMasterTableAdapter.Adapter)
                    End If
                End If

                If Me._userRightsTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._userRightsTableAdapter, Me._userRightsTableAdapter.Connection)
                    Me._userRightsTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._userRightsTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._userRightsTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._userRightsTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._userRightsTableAdapter.Adapter)
                    End If
                End If

                If Me._voucherTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._voucherTableAdapter, Me._voucherTableAdapter.Connection)
                    Me._voucherTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._voucherTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._voucherTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._voucherTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._voucherTableAdapter.Adapter)
                    End If
                End If

                If Me._voucher_OtherDetailsTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._voucher_OtherDetailsTableAdapter, Me._voucher_OtherDetailsTableAdapter.Connection)
                    Me._voucher_OtherDetailsTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._voucher_OtherDetailsTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._voucher_OtherDetailsTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._voucher_OtherDetailsTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._voucher_OtherDetailsTableAdapter.Adapter)
                    End If
                End If

                If Me._walletTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._walletTableAdapter, Me._walletTableAdapter.Connection)
                    Me._walletTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._walletTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._walletTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._walletTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._walletTableAdapter.Adapter)
                    End If
                End If

                If Me._warehouseTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._warehouseTableAdapter, Me._warehouseTableAdapter.Connection)
                    Me._warehouseTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._warehouseTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._warehouseTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._warehouseTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._warehouseTableAdapter.Adapter)
                    End If
                End If

                If Me._warehouseTypeTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._warehouseTypeTableAdapter, Me._warehouseTypeTableAdapter.Connection)
                    Me._warehouseTypeTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._warehouseTypeTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._warehouseTypeTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._warehouseTypeTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._warehouseTypeTableAdapter.Adapter)
                    End If
                End If

                If Me._workPeriodEndTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._workPeriodEndTableAdapter, Me._workPeriodEndTableAdapter.Connection)
                    Me._workPeriodEndTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._workPeriodEndTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._workPeriodEndTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._workPeriodEndTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._workPeriodEndTableAdapter.Adapter)
                    End If
                End If

                If Me._workPeriodStartTableAdapter IsNot Nothing Then
                    dictionary.Add(Me._workPeriodStartTableAdapter, Me._workPeriodStartTableAdapter.Connection)
                    Me._workPeriodStartTableAdapter.Connection = CType(connection, System.Data.SqlClient.SqlConnection)
                    Me._workPeriodStartTableAdapter.Transaction = CType(dbTransaction, System.Data.SqlClient.SqlTransaction)
                    If Me._workPeriodStartTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                        Me._workPeriodStartTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                        list3.Add(Me._workPeriodStartTableAdapter.Adapter)
                    End If
                End If

                If Me.UpdateOrder = RestaurantPOS14.RPOS_DBDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.UpdateInsertDelete Then
                    num += Me.UpdateUpdatedRows(dataSet, list, list2)
                    num += Me.UpdateInsertedRows(dataSet, list2)
                Else
                    num += Me.UpdateInsertedRows(dataSet, list2)
                    num += Me.UpdateUpdatedRows(dataSet, list, list2)
                End If

                num += Me.UpdateDeletedRows(dataSet, list)
                dbTransaction.Commit()
                If 0 < list2.Count Then
                    Dim array As System.Data.DataRow() = New System.Data.DataRow(list2.Count - 1 + 1 - 1) {}
                    list2.CopyTo(array)
                    Dim array2 As System.Data.DataRow() = array
                    Dim i As Integer = 0
                    While i < array2.Length
                        array2(CInt((i))).AcceptChanges()
                        i = i + 1
                    End While
                End If

                If 0 < list.Count Then
                    Dim array3 As System.Data.DataRow() = New System.Data.DataRow(list.Count - 1 + 1 - 1) {}
                    list.CopyTo(array3)
                    Dim array4 As System.Data.DataRow() = array3
                    Dim j As Integer = 0
                    While j < array4.Length
                        array4(CInt((j))).AcceptChanges()
                        j = j + 1
                    End While
                End If
            Catch ex As System.Exception
                dbTransaction.Rollback()
                If Me.BackupDataSetBeforeUpdate Then
                    dataSet.Clear()
                    dataSet.Merge(dataSet2)
                ElseIf 0 < list2.Count Then
                    Dim array5 As System.Data.DataRow() = New System.Data.DataRow(list2.Count - 1 + 1 - 1) {}
                    list2.CopyTo(array5)
                    Dim array6 As System.Data.DataRow() = array5
                    For Each obj As System.Data.DataRow In array6
                        obj.AcceptChanges()
                        obj.SetAdded()
                    Next
                End If

                Throw ex
            Finally
                If flag Then
                    connection.Close()
                End If

                If Me._activationTableAdapter IsNot Nothing Then
                    Me._activationTableAdapter.Connection = CType(dictionary(Me._activationTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._activationTableAdapter.Transaction = Nothing
                End If

                If Me._bankTableAdapter IsNot Nothing Then
                    Me._bankTableAdapter.Connection = CType(dictionary(Me._bankTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._bankTableAdapter.Transaction = Nothing
                End If

                If Me._bankAccountLedgerTableAdapter IsNot Nothing Then
                    Me._bankAccountLedgerTableAdapter.Connection = CType(dictionary(Me._bankAccountLedgerTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._bankAccountLedgerTableAdapter.Transaction = Nothing
                End If

                If Me._bankAccountRegistrationTableAdapter IsNot Nothing Then
                    Me._bankAccountRegistrationTableAdapter.Connection = CType(dictionary(Me._bankAccountRegistrationTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._bankAccountRegistrationTableAdapter.Transaction = Nothing
                End If

                If Me._bankBranchTableAdapter IsNot Nothing Then
                    Me._bankBranchTableAdapter.Connection = CType(dictionary(Me._bankBranchTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._bankBranchTableAdapter.Transaction = Nothing
                End If

                If Me._categoryTableAdapter IsNot Nothing Then
                    Me._categoryTableAdapter.Connection = CType(dictionary(Me._categoryTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._categoryTableAdapter.Transaction = Nothing
                End If

                If Me._clockINTableAdapter IsNot Nothing Then
                    Me._clockINTableAdapter.Connection = CType(dictionary(Me._clockINTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._clockINTableAdapter.Transaction = Nothing
                End If

                If Me._clockOUTTableAdapter IsNot Nothing Then
                    Me._clockOUTTableAdapter.Connection = CType(dictionary(Me._clockOUTTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._clockOUTTableAdapter.Transaction = Nothing
                End If

                If Me._cMISettingTableAdapter IsNot Nothing Then
                    Me._cMISettingTableAdapter.Connection = CType(dictionary(Me._cMISettingTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._cMISettingTableAdapter.Transaction = Nothing
                End If

                If Me._creditCustomerTableAdapter IsNot Nothing Then
                    Me._creditCustomerTableAdapter.Connection = CType(dictionary(Me._creditCustomerTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._creditCustomerTableAdapter.Transaction = Nothing
                End If

                If Me._creditCustomerLedgerTableAdapter IsNot Nothing Then
                    Me._creditCustomerLedgerTableAdapter.Connection = CType(dictionary(Me._creditCustomerLedgerTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._creditCustomerLedgerTableAdapter.Transaction = Nothing
                End If

                If Me._creditCustomerPaymentTableAdapter IsNot Nothing Then
                    Me._creditCustomerPaymentTableAdapter.Connection = CType(dictionary(Me._creditCustomerPaymentTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._creditCustomerPaymentTableAdapter.Transaction = Nothing
                End If

                If Me._currencyTableAdapter IsNot Nothing Then
                    Me._currencyTableAdapter.Connection = CType(dictionary(Me._currencyTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._currencyTableAdapter.Transaction = Nothing
                End If

                If Me._deletedInvoicesTableAdapter IsNot Nothing Then
                    Me._deletedInvoicesTableAdapter.Connection = CType(dictionary(Me._deletedInvoicesTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._deletedInvoicesTableAdapter.Transaction = Nothing
                End If

                If Me._deletedInvoices_JoinTableAdapter IsNot Nothing Then
                    Me._deletedInvoices_JoinTableAdapter.Connection = CType(dictionary(Me._deletedInvoices_JoinTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._deletedInvoices_JoinTableAdapter.Transaction = Nothing
                End If

                If Me._dishTableAdapter IsNot Nothing Then
                    Me._dishTableAdapter.Connection = CType(dictionary(Me._dishTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._dishTableAdapter.Transaction = Nothing
                End If

                If Me._emailSettingTableAdapter IsNot Nothing Then
                    Me._emailSettingTableAdapter.Connection = CType(dictionary(Me._emailSettingTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._emailSettingTableAdapter.Transaction = Nothing
                End If

                If Me._employeeRegistrationTableAdapter IsNot Nothing Then
                    Me._employeeRegistrationTableAdapter.Connection = CType(dictionary(Me._employeeRegistrationTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._employeeRegistrationTableAdapter.Transaction = Nothing
                End If

                If Me._expenseTableAdapter IsNot Nothing Then
                    Me._expenseTableAdapter.Connection = CType(dictionary(Me._expenseTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._expenseTableAdapter.Transaction = Nothing
                End If

                If Me._expenseTypeTableAdapter IsNot Nothing Then
                    Me._expenseTypeTableAdapter.Connection = CType(dictionary(Me._expenseTypeTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._expenseTypeTableAdapter.Transaction = Nothing
                End If

                If Me._fundDepositTableAdapter IsNot Nothing Then
                    Me._fundDepositTableAdapter.Connection = CType(dictionary(Me._fundDepositTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._fundDepositTableAdapter.Transaction = Nothing
                End If

                If Me._fundTransferTableAdapter IsNot Nothing Then
                    Me._fundTransferTableAdapter.Connection = CType(dictionary(Me._fundTransferTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._fundTransferTableAdapter.Transaction = Nothing
                End If

                If Me._giftCardTableAdapter IsNot Nothing Then
                    Me._giftCardTableAdapter.Connection = CType(dictionary(Me._giftCardTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._giftCardTableAdapter.Transaction = Nothing
                End If

                If Me._gridGroupingTableAdapter IsNot Nothing Then
                    Me._gridGroupingTableAdapter.Connection = CType(dictionary(Me._gridGroupingTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._gridGroupingTableAdapter.Transaction = Nothing
                End If

                If Me._hDCustomerTableAdapter IsNot Nothing Then
                    Me._hDCustomerTableAdapter.Connection = CType(dictionary(Me._hDCustomerTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._hDCustomerTableAdapter.Transaction = Nothing
                End If

                If Me._holdBillTableAdapter IsNot Nothing Then
                    Me._holdBillTableAdapter.Connection = CType(dictionary(Me._holdBillTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._holdBillTableAdapter.Transaction = Nothing
                End If

                If Me._holdItemsTableAdapter IsNot Nothing Then
                    Me._holdItemsTableAdapter.Connection = CType(dictionary(Me._holdItemsTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._holdItemsTableAdapter.Transaction = Nothing
                End If

                If Me._hotelTableAdapter IsNot Nothing Then
                    Me._hotelTableAdapter.Connection = CType(dictionary(Me._hotelTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._hotelTableAdapter.Transaction = Nothing
                End If

                If Me._journalTableAdapter IsNot Nothing Then
                    Me._journalTableAdapter.Connection = CType(dictionary(Me._journalTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._journalTableAdapter.Transaction = Nothing
                End If

                If Me._kitchenTableAdapter IsNot Nothing Then
                    Me._kitchenTableAdapter.Connection = CType(dictionary(Me._kitchenTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._kitchenTableAdapter.Transaction = Nothing
                End If

                If Me._ledgerBookTableAdapter IsNot Nothing Then
                    Me._ledgerBookTableAdapter.Connection = CType(dictionary(Me._ledgerBookTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._ledgerBookTableAdapter.Transaction = Nothing
                End If

                If Me._logsTableAdapter IsNot Nothing Then
                    Me._logsTableAdapter.Connection = CType(dictionary(Me._logsTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._logsTableAdapter.Transaction = Nothing
                End If

                If Me._loyaltyMemberTableAdapter IsNot Nothing Then
                    Me._loyaltyMemberTableAdapter.Connection = CType(dictionary(Me._loyaltyMemberTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._loyaltyMemberTableAdapter.Transaction = Nothing
                End If

                If Me._loyaltyMemberLedgerBookTableAdapter IsNot Nothing Then
                    Me._loyaltyMemberLedgerBookTableAdapter.Connection = CType(dictionary(Me._loyaltyMemberLedgerBookTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._loyaltyMemberLedgerBookTableAdapter.Transaction = Nothing
                End If

                If Me._loyaltySettingTableAdapter IsNot Nothing Then
                    Me._loyaltySettingTableAdapter.Connection = CType(dictionary(Me._loyaltySettingTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._loyaltySettingTableAdapter.Transaction = Nothing
                End If

                If Me._memberTableAdapter IsNot Nothing Then
                    Me._memberTableAdapter.Connection = CType(dictionary(Me._memberTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._memberTableAdapter.Transaction = Nothing
                End If

                If Me._memberLedgerTableAdapter IsNot Nothing Then
                    Me._memberLedgerTableAdapter.Connection = CType(dictionary(Me._memberLedgerTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._memberLedgerTableAdapter.Transaction = Nothing
                End If

                If Me._modifiersTableAdapter IsNot Nothing Then
                    Me._modifiersTableAdapter.Connection = CType(dictionary(Me._modifiersTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._modifiersTableAdapter.Transaction = Nothing
                End If

                If Me._mpesaSettingTableAdapter IsNot Nothing Then
                    Me._mpesaSettingTableAdapter.Connection = CType(dictionary(Me._mpesaSettingTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._mpesaSettingTableAdapter.Transaction = Nothing
                End If

                If Me._notesMasterTableAdapter IsNot Nothing Then
                    Me._notesMasterTableAdapter.Connection = CType(dictionary(Me._notesMasterTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._notesMasterTableAdapter.Transaction = Nothing
                End If

                If Me._otherSettingTableAdapter IsNot Nothing Then
                    Me._otherSettingTableAdapter.Connection = CType(dictionary(Me._otherSettingTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._otherSettingTableAdapter.Transaction = Nothing
                End If

                If Me._paymentTableAdapter IsNot Nothing Then
                    Me._paymentTableAdapter.Connection = CType(dictionary(Me._paymentTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._paymentTableAdapter.Transaction = Nothing
                End If

                If Me._payment_WithdrawTableAdapter IsNot Nothing Then
                    Me._payment_WithdrawTableAdapter.Connection = CType(dictionary(Me._payment_WithdrawTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._payment_WithdrawTableAdapter.Transaction = Nothing
                End If

                If Me._payrollTableAdapter IsNot Nothing Then
                    Me._payrollTableAdapter.Connection = CType(dictionary(Me._payrollTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._payrollTableAdapter.Transaction = Nothing
                End If

                If Me._payroll_MBTableAdapter IsNot Nothing Then
                    Me._payroll_MBTableAdapter.Connection = CType(dictionary(Me._payroll_MBTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._payroll_MBTableAdapter.Transaction = Nothing
                End If

                If Me._pizzaMasterTableAdapter IsNot Nothing Then
                    Me._pizzaMasterTableAdapter.Connection = CType(dictionary(Me._pizzaMasterTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._pizzaMasterTableAdapter.Transaction = Nothing
                End If

                If Me._pizzaModifierTableAdapter IsNot Nothing Then
                    Me._pizzaModifierTableAdapter.Connection = CType(dictionary(Me._pizzaModifierTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._pizzaModifierTableAdapter.Transaction = Nothing
                End If

                If Me._pizzaSizeTableAdapter IsNot Nothing Then
                    Me._pizzaSizeTableAdapter.Connection = CType(dictionary(Me._pizzaSizeTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._pizzaSizeTableAdapter.Transaction = Nothing
                End If

                If Me._pizzaToppingTableAdapter IsNot Nothing Then
                    Me._pizzaToppingTableAdapter.Connection = CType(dictionary(Me._pizzaToppingTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._pizzaToppingTableAdapter.Transaction = Nothing
                End If

                If Me._posGroupingTableAdapter IsNot Nothing Then
                    Me._posGroupingTableAdapter.Connection = CType(dictionary(Me._posGroupingTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._posGroupingTableAdapter.Transaction = Nothing
                End If

                If Me._posGrouping1TableAdapter IsNot Nothing Then
                    Me._posGrouping1TableAdapter.Connection = CType(dictionary(Me._posGrouping1TableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._posGrouping1TableAdapter.Transaction = Nothing
                End If

                If Me._posPrinterSettingTableAdapter IsNot Nothing Then
                    Me._posPrinterSettingTableAdapter.Connection = CType(dictionary(Me._posPrinterSettingTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._posPrinterSettingTableAdapter.Transaction = Nothing
                End If

                If Me._productTableAdapter IsNot Nothing Then
                    Me._productTableAdapter.Connection = CType(dictionary(Me._productTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._productTableAdapter.Transaction = Nothing
                End If

                If Me._product_OpeningStockTableAdapter IsNot Nothing Then
                    Me._product_OpeningStockTableAdapter.Connection = CType(dictionary(Me._product_OpeningStockTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._product_OpeningStockTableAdapter.Transaction = Nothing
                End If

                If Me._promotionTableAdapter IsNot Nothing Then
                    Me._promotionTableAdapter.Connection = CType(dictionary(Me._promotionTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._promotionTableAdapter.Transaction = Nothing
                End If

                If Me._purchaseTableAdapter IsNot Nothing Then
                    Me._purchaseTableAdapter.Connection = CType(dictionary(Me._purchaseTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._purchaseTableAdapter.Transaction = Nothing
                End If

                If Me._purchase_JoinTableAdapter IsNot Nothing Then
                    Me._purchase_JoinTableAdapter.Connection = CType(dictionary(Me._purchase_JoinTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._purchase_JoinTableAdapter.Transaction = Nothing
                End If

                If Me._purchaseOrderTableAdapter IsNot Nothing Then
                    Me._purchaseOrderTableAdapter.Connection = CType(dictionary(Me._purchaseOrderTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._purchaseOrderTableAdapter.Transaction = Nothing
                End If

                If Me._purchaseOrder_JoinTableAdapter IsNot Nothing Then
                    Me._purchaseOrder_JoinTableAdapter.Connection = CType(dictionary(Me._purchaseOrder_JoinTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._purchaseOrder_JoinTableAdapter.Transaction = Nothing
                End If

                If Me._r_TableTableAdapter IsNot Nothing Then
                    Me._r_TableTableAdapter.Connection = CType(dictionary(Me._r_TableTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._r_TableTableAdapter.Transaction = Nothing
                End If

                If Me._recipeTableAdapter IsNot Nothing Then
                    Me._recipeTableAdapter.Connection = CType(dictionary(Me._recipeTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._recipeTableAdapter.Transaction = Nothing
                End If

                If Me._recipe_JoinTableAdapter IsNot Nothing Then
                    Me._recipe_JoinTableAdapter.Connection = CType(dictionary(Me._recipe_JoinTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._recipe_JoinTableAdapter.Transaction = Nothing
                End If

                If Me._registrationTableAdapter IsNot Nothing Then
                    Me._registrationTableAdapter.Connection = CType(dictionary(Me._registrationTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._registrationTableAdapter.Transaction = Nothing
                End If

                If Me._restaurantPOS_BillingInfoEBTableAdapter IsNot Nothing Then
                    Me._restaurantPOS_BillingInfoEBTableAdapter.Connection = CType(dictionary(Me._restaurantPOS_BillingInfoEBTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._restaurantPOS_BillingInfoEBTableAdapter.Transaction = Nothing
                End If

                If Me._restaurantPOS_BillingInfoHDTableAdapter IsNot Nothing Then
                    Me._restaurantPOS_BillingInfoHDTableAdapter.Connection = CType(dictionary(Me._restaurantPOS_BillingInfoHDTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._restaurantPOS_BillingInfoHDTableAdapter.Transaction = Nothing
                End If

                If Me._restaurantPOS_BillingInfoKOTTableAdapter IsNot Nothing Then
                    Me._restaurantPOS_BillingInfoKOTTableAdapter.Connection = CType(dictionary(Me._restaurantPOS_BillingInfoKOTTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._restaurantPOS_BillingInfoKOTTableAdapter.Transaction = Nothing
                End If

                If Me._restaurantPOS_BillingInfoTATableAdapter IsNot Nothing Then
                    Me._restaurantPOS_BillingInfoTATableAdapter.Connection = CType(dictionary(Me._restaurantPOS_BillingInfoTATableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._restaurantPOS_BillingInfoTATableAdapter.Transaction = Nothing
                End If

                If Me._restaurantPOS_OrderedProductBillEBTableAdapter IsNot Nothing Then
                    Me._restaurantPOS_OrderedProductBillEBTableAdapter.Connection = CType(dictionary(Me._restaurantPOS_OrderedProductBillEBTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._restaurantPOS_OrderedProductBillEBTableAdapter.Transaction = Nothing
                End If

                If Me._restaurantPOS_OrderedProductBillHDTableAdapter IsNot Nothing Then
                    Me._restaurantPOS_OrderedProductBillHDTableAdapter.Connection = CType(dictionary(Me._restaurantPOS_OrderedProductBillHDTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._restaurantPOS_OrderedProductBillHDTableAdapter.Transaction = Nothing
                End If

                If Me._restaurantPOS_OrderedProductBillKOTTableAdapter IsNot Nothing Then
                    Me._restaurantPOS_OrderedProductBillKOTTableAdapter.Connection = CType(dictionary(Me._restaurantPOS_OrderedProductBillKOTTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._restaurantPOS_OrderedProductBillKOTTableAdapter.Transaction = Nothing
                End If

                If Me._restaurantPOS_OrderedProductBillTATableAdapter IsNot Nothing Then
                    Me._restaurantPOS_OrderedProductBillTATableAdapter.Connection = CType(dictionary(Me._restaurantPOS_OrderedProductBillTATableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._restaurantPOS_OrderedProductBillTATableAdapter.Transaction = Nothing
                End If

                If Me._restaurantPOS_OrderedProductKOTTableAdapter IsNot Nothing Then
                    Me._restaurantPOS_OrderedProductKOTTableAdapter.Connection = CType(dictionary(Me._restaurantPOS_OrderedProductKOTTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._restaurantPOS_OrderedProductKOTTableAdapter.Transaction = Nothing
                End If

                If Me._restaurantPOS_OrderInfoKOTTableAdapter IsNot Nothing Then
                    Me._restaurantPOS_OrderInfoKOTTableAdapter.Connection = CType(dictionary(Me._restaurantPOS_OrderInfoKOTTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._restaurantPOS_OrderInfoKOTTableAdapter.Transaction = Nothing
                End If

                If Me._rM_UsedTableAdapter IsNot Nothing Then
                    Me._rM_UsedTableAdapter.Connection = CType(dictionary(Me._rM_UsedTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._rM_UsedTableAdapter.Transaction = Nothing
                End If

                If Me._rM_Used_JoinTableAdapter IsNot Nothing Then
                    Me._rM_Used_JoinTableAdapter.Connection = CType(dictionary(Me._rM_Used_JoinTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._rM_Used_JoinTableAdapter.Transaction = Nothing
                End If

                If Me._rMCategoryTableAdapter IsNot Nothing Then
                    Me._rMCategoryTableAdapter.Connection = CType(dictionary(Me._rMCategoryTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._rMCategoryTableAdapter.Transaction = Nothing
                End If

                If Me._sMSSettingTableAdapter IsNot Nothing Then
                    Me._sMSSettingTableAdapter.Connection = CType(dictionary(Me._sMSSettingTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._sMSSettingTableAdapter.Transaction = Nothing
                End If

                If Me._stock_StoreTableAdapter IsNot Nothing Then
                    Me._stock_StoreTableAdapter.Connection = CType(dictionary(Me._stock_StoreTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._stock_StoreTableAdapter.Transaction = Nothing
                End If

                If Me._stock_Store_JoinTableAdapter IsNot Nothing Then
                    Me._stock_Store_JoinTableAdapter.Connection = CType(dictionary(Me._stock_Store_JoinTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._stock_Store_JoinTableAdapter.Transaction = Nothing
                End If

                If Me._stockAdjustment_MITableAdapter IsNot Nothing Then
                    Me._stockAdjustment_MITableAdapter.Connection = CType(dictionary(Me._stockAdjustment_MITableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._stockAdjustment_MITableAdapter.Transaction = Nothing
                End If

                If Me._stockAdjustment_StoreTableAdapter IsNot Nothing Then
                    Me._stockAdjustment_StoreTableAdapter.Connection = CType(dictionary(Me._stockAdjustment_StoreTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._stockAdjustment_StoreTableAdapter.Transaction = Nothing
                End If

                If Me._stockAdjustment_WarehouseTableAdapter IsNot Nothing Then
                    Me._stockAdjustment_WarehouseTableAdapter.Connection = CType(dictionary(Me._stockAdjustment_WarehouseTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._stockAdjustment_WarehouseTableAdapter.Transaction = Nothing
                End If

                If Me._stockTransferTableAdapter IsNot Nothing Then
                    Me._stockTransferTableAdapter.Connection = CType(dictionary(Me._stockTransferTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._stockTransferTableAdapter.Transaction = Nothing
                End If

                If Me._stockTransfer_JoinTableAdapter IsNot Nothing Then
                    Me._stockTransfer_JoinTableAdapter.Connection = CType(dictionary(Me._stockTransfer_JoinTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._stockTransfer_JoinTableAdapter.Transaction = Nothing
                End If

                If Me._supplierTableAdapter IsNot Nothing Then
                    Me._supplierTableAdapter.Connection = CType(dictionary(Me._supplierTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._supplierTableAdapter.Transaction = Nothing
                End If

                If Me._supplierLedgerBookTableAdapter IsNot Nothing Then
                    Me._supplierLedgerBookTableAdapter.Connection = CType(dictionary(Me._supplierLedgerBookTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._supplierLedgerBookTableAdapter.Transaction = Nothing
                End If

                If Me._tableLayoutTableAdapter IsNot Nothing Then
                    Me._tableLayoutTableAdapter.Connection = CType(dictionary(Me._tableLayoutTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._tableLayoutTableAdapter.Transaction = Nothing
                End If

                If Me._tableMappingTableAdapter IsNot Nothing Then
                    Me._tableMappingTableAdapter.Connection = CType(dictionary(Me._tableMappingTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._tableMappingTableAdapter.Transaction = Nothing
                End If

                If Me._tableReservationTableAdapter IsNot Nothing Then
                    Me._tableReservationTableAdapter.Connection = CType(dictionary(Me._tableReservationTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._tableReservationTableAdapter.Transaction = Nothing
                End If

                If Me._tblOrderTableAdapter IsNot Nothing Then
                    Me._tblOrderTableAdapter.Connection = CType(dictionary(Me._tblOrderTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._tblOrderTableAdapter.Transaction = Nothing
                End If

                If Me._temp_StockTableAdapter IsNot Nothing Then
                    Me._temp_StockTableAdapter.Connection = CType(dictionary(Me._temp_StockTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._temp_StockTableAdapter.Transaction = Nothing
                End If

                If Me._temp_Stock_RMTableAdapter IsNot Nothing Then
                    Me._temp_Stock_RMTableAdapter.Connection = CType(dictionary(Me._temp_Stock_RMTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._temp_Stock_RMTableAdapter.Transaction = Nothing
                End If

                If Me._temp_Stock_StoreTableAdapter IsNot Nothing Then
                    Me._temp_Stock_StoreTableAdapter.Connection = CType(dictionary(Me._temp_Stock_StoreTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._temp_Stock_StoreTableAdapter.Transaction = Nothing
                End If

                If Me._tempRestaurantPOS_BillingInfoKOTTableAdapter IsNot Nothing Then
                    Me._tempRestaurantPOS_BillingInfoKOTTableAdapter.Connection = CType(dictionary(Me._tempRestaurantPOS_BillingInfoKOTTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._tempRestaurantPOS_BillingInfoKOTTableAdapter.Transaction = Nothing
                End If

                If Me._tempRestaurantPOS_OrderedProductBillKOTTableAdapter IsNot Nothing Then
                    Me._tempRestaurantPOS_OrderedProductBillKOTTableAdapter.Connection = CType(dictionary(Me._tempRestaurantPOS_OrderedProductBillKOTTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._tempRestaurantPOS_OrderedProductBillKOTTableAdapter.Transaction = Nothing
                End If

                If Me._unitMasterTableAdapter IsNot Nothing Then
                    Me._unitMasterTableAdapter.Connection = CType(dictionary(Me._unitMasterTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._unitMasterTableAdapter.Transaction = Nothing
                End If

                If Me._userRightsTableAdapter IsNot Nothing Then
                    Me._userRightsTableAdapter.Connection = CType(dictionary(Me._userRightsTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._userRightsTableAdapter.Transaction = Nothing
                End If

                If Me._voucherTableAdapter IsNot Nothing Then
                    Me._voucherTableAdapter.Connection = CType(dictionary(Me._voucherTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._voucherTableAdapter.Transaction = Nothing
                End If

                If Me._voucher_OtherDetailsTableAdapter IsNot Nothing Then
                    Me._voucher_OtherDetailsTableAdapter.Connection = CType(dictionary(Me._voucher_OtherDetailsTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._voucher_OtherDetailsTableAdapter.Transaction = Nothing
                End If

                If Me._walletTableAdapter IsNot Nothing Then
                    Me._walletTableAdapter.Connection = CType(dictionary(Me._walletTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._walletTableAdapter.Transaction = Nothing
                End If

                If Me._warehouseTableAdapter IsNot Nothing Then
                    Me._warehouseTableAdapter.Connection = CType(dictionary(Me._warehouseTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._warehouseTableAdapter.Transaction = Nothing
                End If

                If Me._warehouseTypeTableAdapter IsNot Nothing Then
                    Me._warehouseTypeTableAdapter.Connection = CType(dictionary(Me._warehouseTypeTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._warehouseTypeTableAdapter.Transaction = Nothing
                End If

                If Me._workPeriodEndTableAdapter IsNot Nothing Then
                    Me._workPeriodEndTableAdapter.Connection = CType(dictionary(Me._workPeriodEndTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._workPeriodEndTableAdapter.Transaction = Nothing
                End If

                If Me._workPeriodStartTableAdapter IsNot Nothing Then
                    Me._workPeriodStartTableAdapter.Connection = CType(dictionary(Me._workPeriodStartTableAdapter), System.Data.SqlClient.SqlConnection)
                    Me._workPeriodStartTableAdapter.Transaction = Nothing
                End If

                If 0 < list3.Count Then
                    Dim array7 As System.Data.Common.DataAdapter() = New System.Data.Common.DataAdapter(list3.Count - 1 + 1 - 1) {}
                    list3.CopyTo(array7)
                    Dim array8 As System.Data.Common.DataAdapter() = array7
                    Dim l As Integer = 0
                    While l < array8.Length
                        array8(CInt((l))).AcceptChangesDuringUpdate = True
                        l = l + 1
                    End While
                End If
            End Try

            Return num
        End Function

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Protected Overridable Sub SortSelfReferenceRows(rows As System.Data.DataRow(), relation As System.Data.DataRelation, childFirst As Boolean)
            System.Array.Sort(rows, New RestaurantPOS14.RPOS_DBDataSet1TableAdapters.TableAdapterManager.SelfReferenceComparer(relation, childFirst))
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Protected Overridable Function MatchTableAdapterConnection(inputConnection As System.Data.IDbConnection) As Boolean
            If Me._connection Is Nothing AndAlso Me.Connection IsNot Nothing AndAlso inputConnection IsNot Nothing Then
                Return String.Equals(Me.Connection.ConnectionString, inputConnection.ConnectionString, System.StringComparison.Ordinal)
            End If

            Return True
        End Function
    End Class
End Namespace
