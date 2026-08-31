Imports System
Imports System.CodeDom.Compiler
Imports System.Collections
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Diagnostics
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace RestaurantPOS14.My

    <Microsoft.VisualBasic.HideModuleNameAttribute>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("MyTemplate", "10.0.0.0")>
    <Microsoft.VisualBasic.CompilerServices.StandardModuleAttribute>
    Friend NotInheritable Class MyProject

        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)>
        Friend NotInheritable Class MyForms

            Public m_frmAbout As RestaurantPOS14.frmAbout

            Public m_frmAccountingReport As RestaurantPOS14.frmAccountingReport

            Public m_frmAddFunds As RestaurantPOS14.frmAddFunds

            Public m_frmAddFundsRecord As RestaurantPOS14.frmAddFundsRecord

            Public m_frmAssignedTablesList_Waiter As RestaurantPOS14.frmAssignedTablesList_Waiter

            Public m_frmAttendance As RestaurantPOS14.frmAttendance

            Public m_frmAvailableTables As RestaurantPOS14.frmAvailableTables

            Public m_frmBackOffice As RestaurantPOS14.frmBackOffice

            Public m_frmBank As RestaurantPOS14.frmBank

            Public m_frmBankAccountRegistration As RestaurantPOS14.frmBankAccountRegistration

            Public m_frmBankAccountStatements As RestaurantPOS14.frmBankAccountStatements

            Public m_frmBankReconciliation As RestaurantPOS14.frmBankReconciliation

            Public m_frmBarcodeLabelPrinting As RestaurantPOS14.frmBarcodeLabelPrinting

            Public m_frmBillSplit As RestaurantPOS14.frmBillSplit

            Public m_frmBranchMaster_Bank As RestaurantPOS14.frmBranchMaster_Bank

            Public m_frmCallerID As RestaurantPOS14.frmCallerID

            Public m_frmCards As RestaurantPOS14.frmCards

            Public m_frmCards_POS As RestaurantPOS14.frmCards_POS

            Public m_frmCategoriesExportImport As RestaurantPOS14.frmCategoriesExportImport

            Public m_frmChangeQty As RestaurantPOS14.frmChangeQty

            Public m_frmChangeRate As RestaurantPOS14.frmChangeRate

            Public m_frmClockINandOUT As RestaurantPOS14.frmClockINandOUT

            Public m_frmCMISetting As RestaurantPOS14.frmCMISetting

            Public m_frmCreditCustomer As RestaurantPOS14.frmCreditCustomer

            Public m_frmCreditCustomerBalance As RestaurantPOS14.frmCreditCustomerBalance

            Public m_frmCreditCustomerLedger As RestaurantPOS14.frmCreditCustomerLedger

            Public m_frmCreditCustomerReceipt As RestaurantPOS14.frmCreditCustomerReceipt

            Public m_frmCreditCustomerReceiptRecord As RestaurantPOS14.frmCreditCustomerReceiptRecord

            Public m_frmCreditCustomerRegistration As RestaurantPOS14.frmCreditCustomerRegistration

            Public m_frmCreditCustomersList As RestaurantPOS14.frmCreditCustomersList

            Public m_frmCurrency As RestaurantPOS14.frmCurrency

            Public m_frmCustomDialog1 As RestaurantPOS14.frmCustomDialog1

            Public m_frmCustomDialog10 As RestaurantPOS14.frmCustomDialog10

            Public m_frmCustomDialog11 As RestaurantPOS14.frmCustomDialog11

            Public m_frmCustomDialog12 As RestaurantPOS14.frmCustomDialog12

            Public m_frmCustomDialog13 As RestaurantPOS14.frmCustomDialog13

            Public m_frmCustomDialog14 As RestaurantPOS14.frmCustomDialog14

            Public m_frmCustomDialog15 As RestaurantPOS14.frmCustomDialog15

            Public m_frmCustomDialog16 As RestaurantPOS14.frmCustomDialog16

            Public m_frmCustomDialog17 As RestaurantPOS14.frmCustomDialog17

            Public m_frmCustomDialog18 As RestaurantPOS14.frmCustomDialog18

            Public m_frmCustomDialog19 As RestaurantPOS14.frmCustomDialog19

            Public m_frmCustomDialog19X As RestaurantPOS14.frmCustomDialog19X

            Public m_frmCustomDialog2 As RestaurantPOS14.frmCustomDialog2

            Public m_frmCustomDialog20 As RestaurantPOS14.frmCustomDialog20

            Public m_frmCustomDialog21 As RestaurantPOS14.frmCustomDialog21

            Public m_frmCustomDialog3 As RestaurantPOS14.frmCustomDialog3

            Public m_frmCustomDialog4 As RestaurantPOS14.frmCustomDialog4

            Public m_frmCustomDialog4X As RestaurantPOS14.frmCustomDialog4X

            Public m_frmCustomDialog5 As RestaurantPOS14.frmCustomDialog5

            Public m_frmCustomDialog6 As RestaurantPOS14.frmCustomDialog6

            Public m_frmCustomDialog7 As RestaurantPOS14.frmCustomDialog7

            Public m_frmCustomDialog8 As RestaurantPOS14.frmCustomDialog8

            Public m_frmCustomDialog8X As RestaurantPOS14.frmCustomDialog8X

            Public m_frmCustomDialog9 As RestaurantPOS14.frmCustomDialog9

            Public m_frmCustomDialogWS As RestaurantPOS14.frmCustomDialogWS

            Public m_frmCustomDialogX As RestaurantPOS14.frmCustomDialogX

            Public m_frmCustomDialogX1 As RestaurantPOS14.frmCustomDialogX1

            Public m_frmCustomDialogX2 As RestaurantPOS14.frmCustomDialogX2

            Public m_frmCustomer As RestaurantPOS14.frmCustomer

            Public m_frmCustomersExportImport As RestaurantPOS14.frmCustomersExportImport

            Public m_frmCustomersRecord As RestaurantPOS14.frmCustomersRecord

            Public m_frmDatabase As RestaurantPOS14.frmDatabase

            Public m_frmDelete As RestaurantPOS14.frmDelete

            Public m_frmDeliveryPersonLedger As RestaurantPOS14.frmDeliveryPersonLedger

            Public m_frmDeliveryPersonRecord As RestaurantPOS14.frmDeliveryPersonRecord

            Public m_frmEmailSetting As RestaurantPOS14.frmEmailSetting

            Public m_frmEmployeeRegistration As RestaurantPOS14.frmEmployeeRegistration

            Public m_frmEmployeeSession As RestaurantPOS14.frmEmployeeSession

            Public m_frmEmployeesRecord As RestaurantPOS14.frmEmployeesRecord

            Public m_frmEnterQty As RestaurantPOS14.frmEnterQty

            Public m_frmEnterQtyX As RestaurantPOS14.frmEnterQtyX

            Public m_frmExecuteQuery As RestaurantPOS14.frmExecuteQuery

            Public m_frmExpense As RestaurantPOS14.frmExpense

            Public m_frmExpenseType As RestaurantPOS14.frmExpenseType

            Public m_frmExpiredProductsRecord As RestaurantPOS14.frmExpiredProductsRecord

            Public m_frmFreeToppingsList As RestaurantPOS14.frmFreeToppingsList

            Public m_frmFrontOffice As RestaurantPOS14.frmFrontOffice

            Public m_frmFrontOffice_Report As RestaurantPOS14.frmFrontOffice_Report

            Public m_frmFundDeposit As RestaurantPOS14.frmFundDeposit

            Public m_frmFundTransfer As RestaurantPOS14.frmFundTransfer

            Public m_frmGeneralLedger As RestaurantPOS14.frmGeneralLedger

            Public m_frmGiftCard As RestaurantPOS14.frmGiftCard

            Public m_frmGiftCardRecord As RestaurantPOS14.frmGiftCardRecord

            Public m_frmHDStatus As RestaurantPOS14.frmHDStatus

            Public m_frmHoldBills As RestaurantPOS14.frmHoldBills

            Public m_frmHoldBillsHD As RestaurantPOS14.frmHoldBillsHD

            Public m_frmHoldDineInKOTs As RestaurantPOS14.frmHoldDineInKOTs

            Public m_frmHomeDelivery As RestaurantPOS14.frmHomeDelivery

            Public m_frmImportExportExcel_Products As RestaurantPOS14.frmImportExportExcel_Products

            Public m_frmImportExportExcel_Supplier As RestaurantPOS14.frmImportExportExcel_Supplier

            Public m_frmItemsTransfer As RestaurantPOS14.frmItemsTransfer

            Public m_frmJournalEntries As RestaurantPOS14.frmJournalEntries

            Public m_frmKDS As RestaurantPOS14.frmKDS

            Public m_frmKitchen_Section As RestaurantPOS14.frmKitchen_Section

            Public m_frmLogin As RestaurantPOS14.frmLogin

            Public m_frmLogs As RestaurantPOS14.frmLogs

            Public m_frmLowStockRecord As RestaurantPOS14.frmLowStockRecord

            Public m_frmLoyaltyCard As RestaurantPOS14.frmLoyaltyCard

            Public m_frmLoyaltyCardMemberLedger As RestaurantPOS14.frmLoyaltyCardMemberLedger

            Public m_frmLoyaltyCardMemberList As RestaurantPOS14.frmLoyaltyCardMemberList

            Public m_frmLoyaltyCardMemberPoints As RestaurantPOS14.frmLoyaltyCardMemberPoints

            Public m_frmLoyaltyMember As RestaurantPOS14.frmLoyaltyMember

            Public m_frmLoyaltySetting As RestaurantPOS14.frmLoyaltySetting

            Public m_frmMarketingTools As RestaurantPOS14.frmMarketingTools

            Public m_frmMember As RestaurantPOS14.frmMember

            Public m_frmMemberBalance As RestaurantPOS14.frmMemberBalance

            Public m_frmMemberLedger As RestaurantPOS14.frmMemberLedger

            Public m_frmMemberList As RestaurantPOS14.frmMemberList

            Public m_frmMenuItem As RestaurantPOS14.frmMenuItem

            Public m_frmMenuItemsCategory As RestaurantPOS14.frmMenuItemsCategory

            Public m_frmMenuItemsExportImport As RestaurantPOS14.frmMenuItemsExportImport

            Public m_frmMenuItemsList As RestaurantPOS14.frmMenuItemsList

            Public m_frmMenuItemsModifiers As RestaurantPOS14.frmMenuItemsModifiers

            Public m_frmModifiersExportImport As RestaurantPOS14.frmModifiersExportImport

            Public m_frmModifiersList As RestaurantPOS14.frmModifiersList

            Public m_frmModifiersList_AutoPopUp As RestaurantPOS14.frmModifiersList_AutoPopUp

            Public m_frmMpesaSetting As RestaurantPOS14.frmMpesaSetting

            Public m_frmNotes As RestaurantPOS14.frmNotes

            Public m_frmNotes1 As RestaurantPOS14.frmNotes1

            Public m_frmNotesMaster As RestaurantPOS14.frmNotesMaster

            Public m_frmOnscreenKeyboard As RestaurantPOS14.frmOnscreenKeyboard

            Public m_frmOpenItems As RestaurantPOS14.frmOpenItems

            Public m_frmOpenTicketsRecord As RestaurantPOS14.frmOpenTicketsRecord

            Public m_frmOption As RestaurantPOS14.frmOption

            Public m_frmOrderedItemDetails As RestaurantPOS14.frmOrderedItemDetails

            Public m_frmOthersSetting As RestaurantPOS14.frmOthersSetting

            Public m_frmPayment As RestaurantPOS14.frmPayment

            Public m_frmPayment_Withdrawal As RestaurantPOS14.frmPayment_Withdrawal

            Public m_frmPaymentRecord As RestaurantPOS14.frmPaymentRecord

            Public m_frmPayroll As RestaurantPOS14.frmPayroll

            Public m_frmPayroll_HB As RestaurantPOS14.frmPayroll_HB

            Public m_frmPayroll_MB As RestaurantPOS14.frmPayroll_MB

            Public m_frmPayroll_MBRecord As RestaurantPOS14.frmPayroll_MBRecord

            Public m_frmPayrollRecord_HB As RestaurantPOS14.frmPayrollRecord_HB

            Public m_frmPizza As RestaurantPOS14.frmPizza

            Public m_frmPizzaMaster As RestaurantPOS14.frmPizzaMaster

            Public m_frmPizzaModifiers As RestaurantPOS14.frmPizzaModifiers

            Public m_frmPizzaModifiersList As RestaurantPOS14.frmPizzaModifiersList

            Public m_frmPizzaModifiersList_AutoPopUp As RestaurantPOS14.frmPizzaModifiersList_AutoPopUp

            Public m_frmPizzaPOS As RestaurantPOS14.frmPizzaPOS

            Public m_frmPizzasExportImport As RestaurantPOS14.frmPizzasExportImport

            Public m_frmPizzaSize As RestaurantPOS14.frmPizzaSize

            Public m_frmPizzaToppings As RestaurantPOS14.frmPizzaToppings

            Public m_frmPizzaToppingsExportImport As RestaurantPOS14.frmPizzaToppingsExportImport

            Public m_frmPO_CRViewer As RestaurantPOS14.frmPO_CRViewer

            Public m_frmPOS As RestaurantPOS14.frmPOS

            Public m_frmPOSRecord As RestaurantPOS14.frmPOSRecord

            Public m_frmPOSReport As RestaurantPOS14.frmPOSReport

            Public m_frmPOSReport_CRViewer As RestaurantPOS14.frmPOSReport_CRViewer

            Public m_frmPOSReport_CRViewer1 As RestaurantPOS14.frmPOSReport_CRViewer1

            Public m_frmPrinterStatus As RestaurantPOS14.frmPrinterStatus

            Public m_frmPrintLoyaltyCard As RestaurantPOS14.frmPrintLoyaltyCard

            Public m_frmPrintVIPMemberCard As RestaurantPOS14.frmPrintVIPMemberCard

            Public m_frmProduct As RestaurantPOS14.frmProduct

            Public m_frmProductRecord As RestaurantPOS14.frmProductRecord

            Public m_frmPromotion As RestaurantPOS14.frmPromotion

            Public m_frmPurchaseEntry As RestaurantPOS14.frmPurchaseEntry

            Public m_frmPurchaseOrder As RestaurantPOS14.frmPurchaseOrder

            Public m_frmPurchaseOrderRecord As RestaurantPOS14.frmPurchaseOrderRecord

            Public m_frmPurchaseRecord As RestaurantPOS14.frmPurchaseRecord

            Public m_frmRawMaterialsCategory As RestaurantPOS14.frmRawMaterialsCategory

            Public m_frmRawMaterialsUsed As RestaurantPOS14.frmRawMaterialsUsed

            Public m_frmRecipe As RestaurantPOS14.frmRecipe

            Public m_frmRecipeRecord As RestaurantPOS14.frmRecipeRecord

            Public m_frmRecoveryPIN As RestaurantPOS14.frmRecoveryPIN

            Public m_frmRefundMoney As RestaurantPOS14.frmRefundMoney

            Public m_frmRefundMoneyRecord As RestaurantPOS14.frmRefundMoneyRecord

            Public m_frmRegistration As RestaurantPOS14.frmRegistration

            Public m_frmReport As RestaurantPOS14.frmReport

            Public m_frmRestaurantMaster As RestaurantPOS14.frmRestaurantMaster

            Public m_frmRestaurantPOSEBRecord As RestaurantPOS14.frmRestaurantPOSEBRecord

            Public m_frmRestaurantPOSEBRecord_Unpaid As RestaurantPOS14.frmRestaurantPOSEBRecord_Unpaid

            Public m_frmRestaurantPOSHDRecord As RestaurantPOS14.frmRestaurantPOSHDRecord

            Public m_frmRestaurantPOSHDRecord1 As RestaurantPOS14.frmRestaurantPOSHDRecord1

            Public m_frmRestaurantPOSKOTFinalBillRecord As RestaurantPOS14.frmRestaurantPOSKOTFinalBillRecord

            Public m_frmRestaurantPOSKOTFinalBillRecord_Unpaid As RestaurantPOS14.frmRestaurantPOSKOTFinalBillRecord_Unpaid

            Public m_frmRestaurantPOSKOTRecord As RestaurantPOS14.frmRestaurantPOSKOTRecord

            Public m_frmRestaurantPOSTARecord As RestaurantPOS14.frmRestaurantPOSTARecord

            Public m_frmRestaurantPOSTARecord_Unpaid As RestaurantPOS14.frmRestaurantPOSTARecord_Unpaid

            Public m_frmSecondaryDisplay As RestaurantPOS14.frmSecondaryDisplay

            Public m_frmSendBroadcastSMS As RestaurantPOS14.frmSendBroadcastSMS

            Public m_frmSendEmail As RestaurantPOS14.frmSendEmail

            Public m_frmSetDiscount As RestaurantPOS14.frmSetDiscount

            Public m_frmSetNOP As RestaurantPOS14.frmSetNOP

            Public m_frmSettings As RestaurantPOS14.frmSettings

            Public m_frmSMSSetting As RestaurantPOS14.frmSMSSetting

            Public m_frmSoftwareLicenceRenewal As RestaurantPOS14.frmSoftwareLicenceRenewal

            Public m_frmSplash As RestaurantPOS14.frmSplash

            Public m_frmSqlServerSetting As RestaurantPOS14.frmSqlServerSetting

            Public m_frmStock_Store As RestaurantPOS14.frmStock_Store

            Public m_frmStock_StoreRecord As RestaurantPOS14.frmStock_StoreRecord

            Public m_frmStockAdjustment As RestaurantPOS14.frmStockAdjustment

            Public m_frmStockAdjustment_MI As RestaurantPOS14.frmStockAdjustment_MI

            Public m_frmStockAdjustment_MI_Record As RestaurantPOS14.frmStockAdjustment_MI_Record

            Public m_frmStockAdjustment_Store As RestaurantPOS14.frmStockAdjustment_Store

            Public m_frmStockAdjustment_Store_Record As RestaurantPOS14.frmStockAdjustment_Store_Record

            Public m_frmStockAdjustment_Warehouse As RestaurantPOS14.frmStockAdjustment_Warehouse

            Public m_frmStockAdjustment_Warehouse_Record As RestaurantPOS14.frmStockAdjustment_Warehouse_Record

            Public m_frmStockIn_RM As RestaurantPOS14.frmStockIn_RM

            Public m_frmStockIn_StoreRecord As RestaurantPOS14.frmStockIn_StoreRecord

            Public m_frmStockInRecord As RestaurantPOS14.frmStockInRecord

            Public m_frmStockOUT_RM As RestaurantPOS14.frmStockOUT_RM

            Public m_frmStockOUT_StoreRecord As RestaurantPOS14.frmStockOUT_StoreRecord

            Public m_frmStockOUTRecord As RestaurantPOS14.frmStockOUTRecord

            Public m_frmStockTransfer As RestaurantPOS14.frmStockTransfer

            Public m_frmStockTransferRecord As RestaurantPOS14.frmStockTransferRecord

            Public m_frmSupplier As RestaurantPOS14.frmSupplier

            Public m_frmSupplierRecord As RestaurantPOS14.frmSupplierRecord

            Public m_frmSystemInfo As RestaurantPOS14.frmSystemInfo

            Public m_frmTable As RestaurantPOS14.frmTable

            Public m_frmTableLayout As RestaurantPOS14.frmTableLayout

            Public m_frmTableLayoutSettings As RestaurantPOS14.frmTableLayoutSettings

            Public m_frmTableList As RestaurantPOS14.frmTableList

            Public m_frmTableMapping_Waiter As RestaurantPOS14.frmTableMapping_Waiter

            Public m_frmTableReservation As RestaurantPOS14.frmTableReservation

            Public m_frmTablesExportImport As RestaurantPOS14.frmTablesExportImport

            Public m_frmTerminalSetting As RestaurantPOS14.frmTerminalSetting

            Public m_frmTestDualDisplay As RestaurantPOS14.frmTestDualDisplay

            Public m_frmToppingsList As RestaurantPOS14.frmToppingsList

            Public m_frmToppingsList1 As RestaurantPOS14.frmToppingsList1

            Public m_frmUnit As RestaurantPOS14.frmUnit

            Public m_frmUserRights As RestaurantPOS14.frmUserRights

            Public m_frmVIPMemberCard As RestaurantPOS14.frmVIPMemberCard

            Public m_frmVoucher As RestaurantPOS14.frmVoucher

            Public m_frmVoucherRecord As RestaurantPOS14.frmVoucherRecord

            Public m_frmWaiterList As RestaurantPOS14.frmWaiterList

            Public m_frmWalletList As RestaurantPOS14.frmWalletList

            Public m_frmWalletType As RestaurantPOS14.frmWalletType

            Public m_frmWarehouse As RestaurantPOS14.frmWarehouse

            Public m_frmWarehouseType As RestaurantPOS14.frmWarehouseType

            Public m_frmWorkPeriod As RestaurantPOS14.frmWorkPeriod

            Public m_frmWorkPeriod_Del As RestaurantPOS14.frmWorkPeriod_Del

            Public m_frmWorkPeriodReport As RestaurantPOS14.frmWorkPeriodReport

            Public m_frmWPReport_CRViewer As RestaurantPOS14.frmWPReport_CRViewer

            <System.ThreadStaticAttribute>
            Private Shared m_FormBeingCreated As System.Collections.Hashtable

            Public Property frmAbout As RestaurantPOS14.frmAbout
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmAbout = Create__Instance__(Me.m_frmAbout)
                    Return Me.m_frmAbout
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmAbout)
                    If value IsNot Me.m_frmAbout Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmAbout)
                    End If
                End Set
            End Property

            Public Property frmAccountingReport As RestaurantPOS14.frmAccountingReport
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmAccountingReport = Create__Instance__(Me.m_frmAccountingReport)
                    Return Me.m_frmAccountingReport
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmAccountingReport)
                    If value IsNot Me.m_frmAccountingReport Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmAccountingReport)
                    End If
                End Set
            End Property

            Public Property frmAddFunds As RestaurantPOS14.frmAddFunds
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmAddFunds = Create__Instance__(Me.m_frmAddFunds)
                    Return Me.m_frmAddFunds
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmAddFunds)
                    If value IsNot Me.m_frmAddFunds Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmAddFunds)
                    End If
                End Set
            End Property

            Public Property frmAddFundsRecord As RestaurantPOS14.frmAddFundsRecord
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmAddFundsRecord = Create__Instance__(Me.m_frmAddFundsRecord)
                    Return Me.m_frmAddFundsRecord
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmAddFundsRecord)
                    If value IsNot Me.m_frmAddFundsRecord Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmAddFundsRecord)
                    End If
                End Set
            End Property

            Public Property frmAssignedTablesList_Waiter As RestaurantPOS14.frmAssignedTablesList_Waiter
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmAssignedTablesList_Waiter = Create__Instance__(Me.m_frmAssignedTablesList_Waiter)
                    Return Me.m_frmAssignedTablesList_Waiter
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmAssignedTablesList_Waiter)
                    If value IsNot Me.m_frmAssignedTablesList_Waiter Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmAssignedTablesList_Waiter)
                    End If
                End Set
            End Property

            Public Property frmAttendance As RestaurantPOS14.frmAttendance
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmAttendance = Create__Instance__(Me.m_frmAttendance)
                    Return Me.m_frmAttendance
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmAttendance)
                    If value IsNot Me.m_frmAttendance Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmAttendance)
                    End If
                End Set
            End Property

            Public Property frmAvailableTables As RestaurantPOS14.frmAvailableTables
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmAvailableTables = Create__Instance__(Me.m_frmAvailableTables)
                    Return Me.m_frmAvailableTables
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmAvailableTables)
                    If value IsNot Me.m_frmAvailableTables Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmAvailableTables)
                    End If
                End Set
            End Property

            Public Property frmBackOffice As RestaurantPOS14.frmBackOffice
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmBackOffice = Create__Instance__(Me.m_frmBackOffice)
                    Return Me.m_frmBackOffice
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmBackOffice)
                    If value IsNot Me.m_frmBackOffice Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmBackOffice)
                    End If
                End Set
            End Property

            Public Property frmBank As RestaurantPOS14.frmBank
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmBank = Create__Instance__(Me.m_frmBank)
                    Return Me.m_frmBank
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmBank)
                    If value IsNot Me.m_frmBank Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmBank)
                    End If
                End Set
            End Property

            Public Property frmBankAccountRegistration As RestaurantPOS14.frmBankAccountRegistration
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmBankAccountRegistration = Create__Instance__(Me.m_frmBankAccountRegistration)
                    Return Me.m_frmBankAccountRegistration
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmBankAccountRegistration)
                    If value IsNot Me.m_frmBankAccountRegistration Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmBankAccountRegistration)
                    End If
                End Set
            End Property

            Public Property frmBankAccountStatements As RestaurantPOS14.frmBankAccountStatements
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmBankAccountStatements = Create__Instance__(Me.m_frmBankAccountStatements)
                    Return Me.m_frmBankAccountStatements
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmBankAccountStatements)
                    If value IsNot Me.m_frmBankAccountStatements Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmBankAccountStatements)
                    End If
                End Set
            End Property

            Public Property frmBankReconciliation As RestaurantPOS14.frmBankReconciliation
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmBankReconciliation = Create__Instance__(Me.m_frmBankReconciliation)
                    Return Me.m_frmBankReconciliation
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmBankReconciliation)
                    If value IsNot Me.m_frmBankReconciliation Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmBankReconciliation)
                    End If
                End Set
            End Property

            Public Property frmBarcodeLabelPrinting As RestaurantPOS14.frmBarcodeLabelPrinting
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmBarcodeLabelPrinting = Create__Instance__(Me.m_frmBarcodeLabelPrinting)
                    Return Me.m_frmBarcodeLabelPrinting
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmBarcodeLabelPrinting)
                    If value IsNot Me.m_frmBarcodeLabelPrinting Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmBarcodeLabelPrinting)
                    End If
                End Set
            End Property

            Public Property frmBillSplit As RestaurantPOS14.frmBillSplit
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmBillSplit = Create__Instance__(Me.m_frmBillSplit)
                    Return Me.m_frmBillSplit
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmBillSplit)
                    If value IsNot Me.m_frmBillSplit Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmBillSplit)
                    End If
                End Set
            End Property

            Public Property frmBranchMaster_Bank As RestaurantPOS14.frmBranchMaster_Bank
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmBranchMaster_Bank = Create__Instance__(Me.m_frmBranchMaster_Bank)
                    Return Me.m_frmBranchMaster_Bank
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmBranchMaster_Bank)
                    If value IsNot Me.m_frmBranchMaster_Bank Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmBranchMaster_Bank)
                    End If
                End Set
            End Property

            Public Property frmCallerID As RestaurantPOS14.frmCallerID
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmCallerID = Create__Instance__(Me.m_frmCallerID)
                    Return Me.m_frmCallerID
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmCallerID)
                    If value IsNot Me.m_frmCallerID Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmCallerID)
                    End If
                End Set
            End Property

            Public Property frmCards As RestaurantPOS14.frmCards
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmCards = Create__Instance__(Me.m_frmCards)
                    Return Me.m_frmCards
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmCards)
                    If value IsNot Me.m_frmCards Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmCards)
                    End If
                End Set
            End Property

            Public Property frmCards_POS As RestaurantPOS14.frmCards_POS
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmCards_POS = Create__Instance__(Me.m_frmCards_POS)
                    Return Me.m_frmCards_POS
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmCards_POS)
                    If value IsNot Me.m_frmCards_POS Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmCards_POS)
                    End If
                End Set
            End Property

            Public Property frmCategoriesExportImport As RestaurantPOS14.frmCategoriesExportImport
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmCategoriesExportImport = Create__Instance__(Me.m_frmCategoriesExportImport)
                    Return Me.m_frmCategoriesExportImport
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmCategoriesExportImport)
                    If value IsNot Me.m_frmCategoriesExportImport Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmCategoriesExportImport)
                    End If
                End Set
            End Property

            Public Property frmChangeQty As RestaurantPOS14.frmChangeQty
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmChangeQty = Create__Instance__(Me.m_frmChangeQty)
                    Return Me.m_frmChangeQty
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmChangeQty)
                    If value IsNot Me.m_frmChangeQty Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmChangeQty)
                    End If
                End Set
            End Property

            Public Property frmChangeRate As RestaurantPOS14.frmChangeRate
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmChangeRate = Create__Instance__(Me.m_frmChangeRate)
                    Return Me.m_frmChangeRate
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmChangeRate)
                    If value IsNot Me.m_frmChangeRate Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmChangeRate)
                    End If
                End Set
            End Property

            Public Property frmClockINandOUT As RestaurantPOS14.frmClockINandOUT
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmClockINandOUT = Create__Instance__(Me.m_frmClockINandOUT)
                    Return Me.m_frmClockINandOUT
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmClockINandOUT)
                    If value IsNot Me.m_frmClockINandOUT Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmClockINandOUT)
                    End If
                End Set
            End Property

            Public Property frmCMISetting As RestaurantPOS14.frmCMISetting
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmCMISetting = Create__Instance__(Me.m_frmCMISetting)
                    Return Me.m_frmCMISetting
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmCMISetting)
                    If value IsNot Me.m_frmCMISetting Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmCMISetting)
                    End If
                End Set
            End Property

            Public Property frmCreditCustomer As RestaurantPOS14.frmCreditCustomer
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmCreditCustomer = Create__Instance__(Me.m_frmCreditCustomer)
                    Return Me.m_frmCreditCustomer
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmCreditCustomer)
                    If value IsNot Me.m_frmCreditCustomer Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmCreditCustomer)
                    End If
                End Set
            End Property

            Public Property frmCreditCustomerBalance As RestaurantPOS14.frmCreditCustomerBalance
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmCreditCustomerBalance = Create__Instance__(Me.m_frmCreditCustomerBalance)
                    Return Me.m_frmCreditCustomerBalance
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmCreditCustomerBalance)
                    If value IsNot Me.m_frmCreditCustomerBalance Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmCreditCustomerBalance)
                    End If
                End Set
            End Property

            Public Property frmCreditCustomerLedger As RestaurantPOS14.frmCreditCustomerLedger
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmCreditCustomerLedger = Create__Instance__(Me.m_frmCreditCustomerLedger)
                    Return Me.m_frmCreditCustomerLedger
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmCreditCustomerLedger)
                    If value IsNot Me.m_frmCreditCustomerLedger Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmCreditCustomerLedger)
                    End If
                End Set
            End Property

            Public Property frmCreditCustomerReceipt As RestaurantPOS14.frmCreditCustomerReceipt
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmCreditCustomerReceipt = Create__Instance__(Me.m_frmCreditCustomerReceipt)
                    Return Me.m_frmCreditCustomerReceipt
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmCreditCustomerReceipt)
                    If value IsNot Me.m_frmCreditCustomerReceipt Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmCreditCustomerReceipt)
                    End If
                End Set
            End Property

            Public Property frmCreditCustomerReceiptRecord As RestaurantPOS14.frmCreditCustomerReceiptRecord
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmCreditCustomerReceiptRecord = Create__Instance__(Me.m_frmCreditCustomerReceiptRecord)
                    Return Me.m_frmCreditCustomerReceiptRecord
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmCreditCustomerReceiptRecord)
                    If value IsNot Me.m_frmCreditCustomerReceiptRecord Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmCreditCustomerReceiptRecord)
                    End If
                End Set
            End Property

            Public Property frmCreditCustomerRegistration As RestaurantPOS14.frmCreditCustomerRegistration
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmCreditCustomerRegistration = Create__Instance__(Me.m_frmCreditCustomerRegistration)
                    Return Me.m_frmCreditCustomerRegistration
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmCreditCustomerRegistration)
                    If value IsNot Me.m_frmCreditCustomerRegistration Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmCreditCustomerRegistration)
                    End If
                End Set
            End Property

            Public Property frmCreditCustomersList As RestaurantPOS14.frmCreditCustomersList
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmCreditCustomersList = Create__Instance__(Me.m_frmCreditCustomersList)
                    Return Me.m_frmCreditCustomersList
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmCreditCustomersList)
                    If value IsNot Me.m_frmCreditCustomersList Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmCreditCustomersList)
                    End If
                End Set
            End Property

            Public Property frmCurrency As RestaurantPOS14.frmCurrency
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmCurrency = Create__Instance__(Me.m_frmCurrency)
                    Return Me.m_frmCurrency
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmCurrency)
                    If value IsNot Me.m_frmCurrency Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmCurrency)
                    End If
                End Set
            End Property

            Public Property frmCustomDialog1 As RestaurantPOS14.frmCustomDialog1
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmCustomDialog1 = Create__Instance__(Me.m_frmCustomDialog1)
                    Return Me.m_frmCustomDialog1
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmCustomDialog1)
                    If value IsNot Me.m_frmCustomDialog1 Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmCustomDialog1)
                    End If
                End Set
            End Property

            Public Property frmCustomDialog10 As RestaurantPOS14.frmCustomDialog10
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmCustomDialog10 = Create__Instance__(Me.m_frmCustomDialog10)
                    Return Me.m_frmCustomDialog10
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmCustomDialog10)
                    If value IsNot Me.m_frmCustomDialog10 Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmCustomDialog10)
                    End If
                End Set
            End Property

            Public Property frmCustomDialog11 As RestaurantPOS14.frmCustomDialog11
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmCustomDialog11 = Create__Instance__(Me.m_frmCustomDialog11)
                    Return Me.m_frmCustomDialog11
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmCustomDialog11)
                    If value IsNot Me.m_frmCustomDialog11 Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmCustomDialog11)
                    End If
                End Set
            End Property

            Public Property frmCustomDialog12 As RestaurantPOS14.frmCustomDialog12
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmCustomDialog12 = Create__Instance__(Me.m_frmCustomDialog12)
                    Return Me.m_frmCustomDialog12
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmCustomDialog12)
                    If value IsNot Me.m_frmCustomDialog12 Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmCustomDialog12)
                    End If
                End Set
            End Property

            Public Property frmCustomDialog13 As RestaurantPOS14.frmCustomDialog13
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmCustomDialog13 = Create__Instance__(Me.m_frmCustomDialog13)
                    Return Me.m_frmCustomDialog13
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmCustomDialog13)
                    If value IsNot Me.m_frmCustomDialog13 Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmCustomDialog13)
                    End If
                End Set
            End Property

            Public Property frmCustomDialog14 As RestaurantPOS14.frmCustomDialog14
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmCustomDialog14 = Create__Instance__(Me.m_frmCustomDialog14)
                    Return Me.m_frmCustomDialog14
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmCustomDialog14)
                    If value IsNot Me.m_frmCustomDialog14 Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmCustomDialog14)
                    End If
                End Set
            End Property

            Public Property frmCustomDialog15 As RestaurantPOS14.frmCustomDialog15
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmCustomDialog15 = Create__Instance__(Me.m_frmCustomDialog15)
                    Return Me.m_frmCustomDialog15
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmCustomDialog15)
                    If value IsNot Me.m_frmCustomDialog15 Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmCustomDialog15)
                    End If
                End Set
            End Property

            Public Property frmCustomDialog16 As RestaurantPOS14.frmCustomDialog16
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmCustomDialog16 = Create__Instance__(Me.m_frmCustomDialog16)
                    Return Me.m_frmCustomDialog16
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmCustomDialog16)
                    If value IsNot Me.m_frmCustomDialog16 Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmCustomDialog16)
                    End If
                End Set
            End Property

            Public Property frmCustomDialog17 As RestaurantPOS14.frmCustomDialog17
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmCustomDialog17 = Create__Instance__(Me.m_frmCustomDialog17)
                    Return Me.m_frmCustomDialog17
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmCustomDialog17)
                    If value IsNot Me.m_frmCustomDialog17 Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmCustomDialog17)
                    End If
                End Set
            End Property

            Public Property frmCustomDialog18 As RestaurantPOS14.frmCustomDialog18
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmCustomDialog18 = Create__Instance__(Me.m_frmCustomDialog18)
                    Return Me.m_frmCustomDialog18
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmCustomDialog18)
                    If value IsNot Me.m_frmCustomDialog18 Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmCustomDialog18)
                    End If
                End Set
            End Property

            Public Property frmCustomDialog19 As RestaurantPOS14.frmCustomDialog19
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmCustomDialog19 = Create__Instance__(Me.m_frmCustomDialog19)
                    Return Me.m_frmCustomDialog19
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmCustomDialog19)
                    If value IsNot Me.m_frmCustomDialog19 Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmCustomDialog19)
                    End If
                End Set
            End Property

            Public Property frmCustomDialog19X As RestaurantPOS14.frmCustomDialog19X
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmCustomDialog19X = Create__Instance__(Me.m_frmCustomDialog19X)
                    Return Me.m_frmCustomDialog19X
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmCustomDialog19X)
                    If value IsNot Me.m_frmCustomDialog19X Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmCustomDialog19X)
                    End If
                End Set
            End Property

            Public Property frmCustomDialog2 As RestaurantPOS14.frmCustomDialog2
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmCustomDialog2 = Create__Instance__(Me.m_frmCustomDialog2)
                    Return Me.m_frmCustomDialog2
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmCustomDialog2)
                    If value IsNot Me.m_frmCustomDialog2 Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmCustomDialog2)
                    End If
                End Set
            End Property

            Public Property frmCustomDialog20 As RestaurantPOS14.frmCustomDialog20
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmCustomDialog20 = Create__Instance__(Me.m_frmCustomDialog20)
                    Return Me.m_frmCustomDialog20
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmCustomDialog20)
                    If value IsNot Me.m_frmCustomDialog20 Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmCustomDialog20)
                    End If
                End Set
            End Property

            Public Property frmCustomDialog21 As RestaurantPOS14.frmCustomDialog21
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmCustomDialog21 = Create__Instance__(Me.m_frmCustomDialog21)
                    Return Me.m_frmCustomDialog21
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmCustomDialog21)
                    If value IsNot Me.m_frmCustomDialog21 Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmCustomDialog21)
                    End If
                End Set
            End Property

            Public Property frmCustomDialog3 As RestaurantPOS14.frmCustomDialog3
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmCustomDialog3 = Create__Instance__(Me.m_frmCustomDialog3)
                    Return Me.m_frmCustomDialog3
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmCustomDialog3)
                    If value IsNot Me.m_frmCustomDialog3 Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmCustomDialog3)
                    End If
                End Set
            End Property

            Public Property frmCustomDialog4 As RestaurantPOS14.frmCustomDialog4
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmCustomDialog4 = Create__Instance__(Me.m_frmCustomDialog4)
                    Return Me.m_frmCustomDialog4
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmCustomDialog4)
                    If value IsNot Me.m_frmCustomDialog4 Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmCustomDialog4)
                    End If
                End Set
            End Property

            Public Property frmCustomDialog4X As RestaurantPOS14.frmCustomDialog4X
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmCustomDialog4X = Create__Instance__(Me.m_frmCustomDialog4X)
                    Return Me.m_frmCustomDialog4X
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmCustomDialog4X)
                    If value IsNot Me.m_frmCustomDialog4X Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmCustomDialog4X)
                    End If
                End Set
            End Property

            Public Property frmCustomDialog5 As RestaurantPOS14.frmCustomDialog5
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmCustomDialog5 = Create__Instance__(Me.m_frmCustomDialog5)
                    Return Me.m_frmCustomDialog5
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmCustomDialog5)
                    If value IsNot Me.m_frmCustomDialog5 Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmCustomDialog5)
                    End If
                End Set
            End Property

            Public Property frmCustomDialog6 As RestaurantPOS14.frmCustomDialog6
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmCustomDialog6 = Create__Instance__(Me.m_frmCustomDialog6)
                    Return Me.m_frmCustomDialog6
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmCustomDialog6)
                    If value IsNot Me.m_frmCustomDialog6 Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmCustomDialog6)
                    End If
                End Set
            End Property

            Public Property frmCustomDialog7 As RestaurantPOS14.frmCustomDialog7
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmCustomDialog7 = Create__Instance__(Me.m_frmCustomDialog7)
                    Return Me.m_frmCustomDialog7
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmCustomDialog7)
                    If value IsNot Me.m_frmCustomDialog7 Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmCustomDialog7)
                    End If
                End Set
            End Property

            Public Property frmCustomDialog8 As RestaurantPOS14.frmCustomDialog8
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmCustomDialog8 = Create__Instance__(Me.m_frmCustomDialog8)
                    Return Me.m_frmCustomDialog8
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmCustomDialog8)
                    If value IsNot Me.m_frmCustomDialog8 Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmCustomDialog8)
                    End If
                End Set
            End Property

            Public Property frmCustomDialog8X As RestaurantPOS14.frmCustomDialog8X
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmCustomDialog8X = Create__Instance__(Me.m_frmCustomDialog8X)
                    Return Me.m_frmCustomDialog8X
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmCustomDialog8X)
                    If value IsNot Me.m_frmCustomDialog8X Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmCustomDialog8X)
                    End If
                End Set
            End Property

            Public Property frmCustomDialog9 As RestaurantPOS14.frmCustomDialog9
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmCustomDialog9 = Create__Instance__(Me.m_frmCustomDialog9)
                    Return Me.m_frmCustomDialog9
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmCustomDialog9)
                    If value IsNot Me.m_frmCustomDialog9 Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmCustomDialog9)
                    End If
                End Set
            End Property

            Public Property frmCustomDialogWS As RestaurantPOS14.frmCustomDialogWS
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmCustomDialogWS = Create__Instance__(Me.m_frmCustomDialogWS)
                    Return Me.m_frmCustomDialogWS
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmCustomDialogWS)
                    If value IsNot Me.m_frmCustomDialogWS Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmCustomDialogWS)
                    End If
                End Set
            End Property

            Public Property frmCustomDialogX As RestaurantPOS14.frmCustomDialogX
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmCustomDialogX = Create__Instance__(Me.m_frmCustomDialogX)
                    Return Me.m_frmCustomDialogX
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmCustomDialogX)
                    If value IsNot Me.m_frmCustomDialogX Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmCustomDialogX)
                    End If
                End Set
            End Property

            Public Property frmCustomDialogX1 As RestaurantPOS14.frmCustomDialogX1
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmCustomDialogX1 = Create__Instance__(Me.m_frmCustomDialogX1)
                    Return Me.m_frmCustomDialogX1
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmCustomDialogX1)
                    If value IsNot Me.m_frmCustomDialogX1 Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmCustomDialogX1)
                    End If
                End Set
            End Property

            Public Property frmCustomDialogX2 As RestaurantPOS14.frmCustomDialogX2
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmCustomDialogX2 = Create__Instance__(Me.m_frmCustomDialogX2)
                    Return Me.m_frmCustomDialogX2
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmCustomDialogX2)
                    If value IsNot Me.m_frmCustomDialogX2 Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmCustomDialogX2)
                    End If
                End Set
            End Property

            Public Property frmCustomer As RestaurantPOS14.frmCustomer
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmCustomer = Create__Instance__(Me.m_frmCustomer)
                    Return Me.m_frmCustomer
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmCustomer)
                    If value IsNot Me.m_frmCustomer Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmCustomer)
                    End If
                End Set
            End Property

            Public Property frmCustomersExportImport As RestaurantPOS14.frmCustomersExportImport
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmCustomersExportImport = Create__Instance__(Me.m_frmCustomersExportImport)
                    Return Me.m_frmCustomersExportImport
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmCustomersExportImport)
                    If value IsNot Me.m_frmCustomersExportImport Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmCustomersExportImport)
                    End If
                End Set
            End Property

            Public Property frmCustomersRecord As RestaurantPOS14.frmCustomersRecord
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmCustomersRecord = Create__Instance__(Me.m_frmCustomersRecord)
                    Return Me.m_frmCustomersRecord
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmCustomersRecord)
                    If value IsNot Me.m_frmCustomersRecord Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmCustomersRecord)
                    End If
                End Set
            End Property

            Public Property frmDatabase As RestaurantPOS14.frmDatabase
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmDatabase = Create__Instance__(Me.m_frmDatabase)
                    Return Me.m_frmDatabase
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmDatabase)
                    If value IsNot Me.m_frmDatabase Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmDatabase)
                    End If
                End Set
            End Property

            Public Property frmDelete As RestaurantPOS14.frmDelete
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmDelete = Create__Instance__(Me.m_frmDelete)
                    Return Me.m_frmDelete
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmDelete)
                    If value IsNot Me.m_frmDelete Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmDelete)
                    End If
                End Set
            End Property

            Public Property frmDeliveryPersonLedger As RestaurantPOS14.frmDeliveryPersonLedger
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmDeliveryPersonLedger = Create__Instance__(Me.m_frmDeliveryPersonLedger)
                    Return Me.m_frmDeliveryPersonLedger
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmDeliveryPersonLedger)
                    If value IsNot Me.m_frmDeliveryPersonLedger Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmDeliveryPersonLedger)
                    End If
                End Set
            End Property

            Public Property frmDeliveryPersonRecord As RestaurantPOS14.frmDeliveryPersonRecord
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmDeliveryPersonRecord = Create__Instance__(Me.m_frmDeliveryPersonRecord)
                    Return Me.m_frmDeliveryPersonRecord
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmDeliveryPersonRecord)
                    If value IsNot Me.m_frmDeliveryPersonRecord Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmDeliveryPersonRecord)
                    End If
                End Set
            End Property

            Public Property frmEmailSetting As RestaurantPOS14.frmEmailSetting
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmEmailSetting = Create__Instance__(Me.m_frmEmailSetting)
                    Return Me.m_frmEmailSetting
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmEmailSetting)
                    If value IsNot Me.m_frmEmailSetting Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmEmailSetting)
                    End If
                End Set
            End Property

            Public Property frmEmployeeRegistration As RestaurantPOS14.frmEmployeeRegistration
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmEmployeeRegistration = Create__Instance__(Me.m_frmEmployeeRegistration)
                    Return Me.m_frmEmployeeRegistration
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmEmployeeRegistration)
                    If value IsNot Me.m_frmEmployeeRegistration Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmEmployeeRegistration)
                    End If
                End Set
            End Property

            Public Property frmEmployeeSession As RestaurantPOS14.frmEmployeeSession
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmEmployeeSession = Create__Instance__(Me.m_frmEmployeeSession)
                    Return Me.m_frmEmployeeSession
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmEmployeeSession)
                    If value IsNot Me.m_frmEmployeeSession Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmEmployeeSession)
                    End If
                End Set
            End Property

            Public Property frmEmployeesRecord As RestaurantPOS14.frmEmployeesRecord
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmEmployeesRecord = Create__Instance__(Me.m_frmEmployeesRecord)
                    Return Me.m_frmEmployeesRecord
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmEmployeesRecord)
                    If value IsNot Me.m_frmEmployeesRecord Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmEmployeesRecord)
                    End If
                End Set
            End Property

            Public Property frmEnterQty As RestaurantPOS14.frmEnterQty
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmEnterQty = Create__Instance__(Me.m_frmEnterQty)
                    Return Me.m_frmEnterQty
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmEnterQty)
                    If value IsNot Me.m_frmEnterQty Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmEnterQty)
                    End If
                End Set
            End Property

            Public Property frmEnterQtyX As RestaurantPOS14.frmEnterQtyX
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmEnterQtyX = Create__Instance__(Me.m_frmEnterQtyX)
                    Return Me.m_frmEnterQtyX
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmEnterQtyX)
                    If value IsNot Me.m_frmEnterQtyX Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmEnterQtyX)
                    End If
                End Set
            End Property

            Public Property frmExecuteQuery As RestaurantPOS14.frmExecuteQuery
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmExecuteQuery = Create__Instance__(Me.m_frmExecuteQuery)
                    Return Me.m_frmExecuteQuery
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmExecuteQuery)
                    If value IsNot Me.m_frmExecuteQuery Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmExecuteQuery)
                    End If
                End Set
            End Property

            Public Property frmExpense As RestaurantPOS14.frmExpense
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmExpense = Create__Instance__(Me.m_frmExpense)
                    Return Me.m_frmExpense
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmExpense)
                    If value IsNot Me.m_frmExpense Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmExpense)
                    End If
                End Set
            End Property

            Public Property frmExpenseType As RestaurantPOS14.frmExpenseType
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmExpenseType = Create__Instance__(Me.m_frmExpenseType)
                    Return Me.m_frmExpenseType
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmExpenseType)
                    If value IsNot Me.m_frmExpenseType Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmExpenseType)
                    End If
                End Set
            End Property

            Public Property frmExpiredProductsRecord As RestaurantPOS14.frmExpiredProductsRecord
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmExpiredProductsRecord = Create__Instance__(Me.m_frmExpiredProductsRecord)
                    Return Me.m_frmExpiredProductsRecord
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmExpiredProductsRecord)
                    If value IsNot Me.m_frmExpiredProductsRecord Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmExpiredProductsRecord)
                    End If
                End Set
            End Property

            Public Property frmFreeToppingsList As RestaurantPOS14.frmFreeToppingsList
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmFreeToppingsList = Create__Instance__(Me.m_frmFreeToppingsList)
                    Return Me.m_frmFreeToppingsList
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmFreeToppingsList)
                    If value IsNot Me.m_frmFreeToppingsList Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmFreeToppingsList)
                    End If
                End Set
            End Property

            Public Property frmFrontOffice As RestaurantPOS14.frmFrontOffice
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmFrontOffice = Create__Instance__(Me.m_frmFrontOffice)
                    Return Me.m_frmFrontOffice
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmFrontOffice)
                    If value IsNot Me.m_frmFrontOffice Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmFrontOffice)
                    End If
                End Set
            End Property

            Public Property frmFrontOffice_Report As RestaurantPOS14.frmFrontOffice_Report
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmFrontOffice_Report = Create__Instance__(Me.m_frmFrontOffice_Report)
                    Return Me.m_frmFrontOffice_Report
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmFrontOffice_Report)
                    If value IsNot Me.m_frmFrontOffice_Report Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmFrontOffice_Report)
                    End If
                End Set
            End Property

            Public Property frmFundDeposit As RestaurantPOS14.frmFundDeposit
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmFundDeposit = Create__Instance__(Me.m_frmFundDeposit)
                    Return Me.m_frmFundDeposit
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmFundDeposit)
                    If value IsNot Me.m_frmFundDeposit Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmFundDeposit)
                    End If
                End Set
            End Property

            Public Property frmFundTransfer As RestaurantPOS14.frmFundTransfer
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmFundTransfer = Create__Instance__(Me.m_frmFundTransfer)
                    Return Me.m_frmFundTransfer
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmFundTransfer)
                    If value IsNot Me.m_frmFundTransfer Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmFundTransfer)
                    End If
                End Set
            End Property

            Public Property frmGeneralLedger As RestaurantPOS14.frmGeneralLedger
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmGeneralLedger = Create__Instance__(Me.m_frmGeneralLedger)
                    Return Me.m_frmGeneralLedger
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmGeneralLedger)
                    If value IsNot Me.m_frmGeneralLedger Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmGeneralLedger)
                    End If
                End Set
            End Property

            Public Property frmGiftCard As RestaurantPOS14.frmGiftCard
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmGiftCard = Create__Instance__(Me.m_frmGiftCard)
                    Return Me.m_frmGiftCard
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmGiftCard)
                    If value IsNot Me.m_frmGiftCard Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmGiftCard)
                    End If
                End Set
            End Property

            Public Property frmGiftCardRecord As RestaurantPOS14.frmGiftCardRecord
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmGiftCardRecord = Create__Instance__(Me.m_frmGiftCardRecord)
                    Return Me.m_frmGiftCardRecord
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmGiftCardRecord)
                    If value IsNot Me.m_frmGiftCardRecord Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmGiftCardRecord)
                    End If
                End Set
            End Property

            Public Property frmHDStatus As RestaurantPOS14.frmHDStatus
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmHDStatus = Create__Instance__(Me.m_frmHDStatus)
                    Return Me.m_frmHDStatus
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmHDStatus)
                    If value IsNot Me.m_frmHDStatus Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmHDStatus)
                    End If
                End Set
            End Property

            Public Property frmHoldBills As RestaurantPOS14.frmHoldBills
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmHoldBills = Create__Instance__(Me.m_frmHoldBills)
                    Return Me.m_frmHoldBills
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmHoldBills)
                    If value IsNot Me.m_frmHoldBills Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmHoldBills)
                    End If
                End Set
            End Property

            Public Property frmHoldBillsHD As RestaurantPOS14.frmHoldBillsHD
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmHoldBillsHD = Create__Instance__(Me.m_frmHoldBillsHD)
                    Return Me.m_frmHoldBillsHD
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmHoldBillsHD)
                    If value IsNot Me.m_frmHoldBillsHD Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmHoldBillsHD)
                    End If
                End Set
            End Property

            Public Property frmHoldDineInKOTs As RestaurantPOS14.frmHoldDineInKOTs
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmHoldDineInKOTs = Create__Instance__(Me.m_frmHoldDineInKOTs)
                    Return Me.m_frmHoldDineInKOTs
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmHoldDineInKOTs)
                    If value IsNot Me.m_frmHoldDineInKOTs Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmHoldDineInKOTs)
                    End If
                End Set
            End Property

            Public Property frmHomeDelivery As RestaurantPOS14.frmHomeDelivery
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmHomeDelivery = Create__Instance__(Me.m_frmHomeDelivery)
                    Return Me.m_frmHomeDelivery
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmHomeDelivery)
                    If value IsNot Me.m_frmHomeDelivery Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmHomeDelivery)
                    End If
                End Set
            End Property

            Public Property frmImportExportExcel_Products As RestaurantPOS14.frmImportExportExcel_Products
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmImportExportExcel_Products = Create__Instance__(Me.m_frmImportExportExcel_Products)
                    Return Me.m_frmImportExportExcel_Products
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmImportExportExcel_Products)
                    If value IsNot Me.m_frmImportExportExcel_Products Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmImportExportExcel_Products)
                    End If
                End Set
            End Property

            Public Property frmImportExportExcel_Supplier As RestaurantPOS14.frmImportExportExcel_Supplier
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmImportExportExcel_Supplier = Create__Instance__(Me.m_frmImportExportExcel_Supplier)
                    Return Me.m_frmImportExportExcel_Supplier
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmImportExportExcel_Supplier)
                    If value IsNot Me.m_frmImportExportExcel_Supplier Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmImportExportExcel_Supplier)
                    End If
                End Set
            End Property

            Public Property frmItemsTransfer As RestaurantPOS14.frmItemsTransfer
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmItemsTransfer = Create__Instance__(Me.m_frmItemsTransfer)
                    Return Me.m_frmItemsTransfer
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmItemsTransfer)
                    If value IsNot Me.m_frmItemsTransfer Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmItemsTransfer)
                    End If
                End Set
            End Property

            Public Property frmJournalEntries As RestaurantPOS14.frmJournalEntries
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmJournalEntries = Create__Instance__(Me.m_frmJournalEntries)
                    Return Me.m_frmJournalEntries
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmJournalEntries)
                    If value IsNot Me.m_frmJournalEntries Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmJournalEntries)
                    End If
                End Set
            End Property

            Public Property frmKDS As RestaurantPOS14.frmKDS
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmKDS = Create__Instance__(Me.m_frmKDS)
                    Return Me.m_frmKDS
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmKDS)
                    If value IsNot Me.m_frmKDS Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmKDS)
                    End If
                End Set
            End Property

            Public Property frmKitchen_Section As RestaurantPOS14.frmKitchen_Section
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmKitchen_Section = Create__Instance__(Me.m_frmKitchen_Section)
                    Return Me.m_frmKitchen_Section
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmKitchen_Section)
                    If value IsNot Me.m_frmKitchen_Section Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmKitchen_Section)
                    End If
                End Set
            End Property

            Public Property frmLogin As RestaurantPOS14.frmLogin
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmLogin = Create__Instance__(Me.m_frmLogin)
                    Return Me.m_frmLogin
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmLogin)
                    If value IsNot Me.m_frmLogin Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmLogin)
                    End If
                End Set
            End Property

            Public Property frmLogs As RestaurantPOS14.frmLogs
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmLogs = Create__Instance__(Me.m_frmLogs)
                    Return Me.m_frmLogs
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmLogs)
                    If value IsNot Me.m_frmLogs Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmLogs)
                    End If
                End Set
            End Property

            Public Property frmLowStockRecord As RestaurantPOS14.frmLowStockRecord
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmLowStockRecord = Create__Instance__(Me.m_frmLowStockRecord)
                    Return Me.m_frmLowStockRecord
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmLowStockRecord)
                    If value IsNot Me.m_frmLowStockRecord Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmLowStockRecord)
                    End If
                End Set
            End Property

            Public Property frmLoyaltyCard As RestaurantPOS14.frmLoyaltyCard
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmLoyaltyCard = Create__Instance__(Me.m_frmLoyaltyCard)
                    Return Me.m_frmLoyaltyCard
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmLoyaltyCard)
                    If value IsNot Me.m_frmLoyaltyCard Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmLoyaltyCard)
                    End If
                End Set
            End Property

            Public Property frmLoyaltyCardMemberLedger As RestaurantPOS14.frmLoyaltyCardMemberLedger
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmLoyaltyCardMemberLedger = Create__Instance__(Me.m_frmLoyaltyCardMemberLedger)
                    Return Me.m_frmLoyaltyCardMemberLedger
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmLoyaltyCardMemberLedger)
                    If value IsNot Me.m_frmLoyaltyCardMemberLedger Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmLoyaltyCardMemberLedger)
                    End If
                End Set
            End Property

            Public Property frmLoyaltyCardMemberList As RestaurantPOS14.frmLoyaltyCardMemberList
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmLoyaltyCardMemberList = Create__Instance__(Me.m_frmLoyaltyCardMemberList)
                    Return Me.m_frmLoyaltyCardMemberList
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmLoyaltyCardMemberList)
                    If value IsNot Me.m_frmLoyaltyCardMemberList Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmLoyaltyCardMemberList)
                    End If
                End Set
            End Property

            Public Property frmLoyaltyCardMemberPoints As RestaurantPOS14.frmLoyaltyCardMemberPoints
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmLoyaltyCardMemberPoints = Create__Instance__(Me.m_frmLoyaltyCardMemberPoints)
                    Return Me.m_frmLoyaltyCardMemberPoints
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmLoyaltyCardMemberPoints)
                    If value IsNot Me.m_frmLoyaltyCardMemberPoints Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmLoyaltyCardMemberPoints)
                    End If
                End Set
            End Property

            Public Property frmLoyaltyMember As RestaurantPOS14.frmLoyaltyMember
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmLoyaltyMember = Create__Instance__(Me.m_frmLoyaltyMember)
                    Return Me.m_frmLoyaltyMember
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmLoyaltyMember)
                    If value IsNot Me.m_frmLoyaltyMember Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmLoyaltyMember)
                    End If
                End Set
            End Property

            Public Property frmLoyaltySetting As RestaurantPOS14.frmLoyaltySetting
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmLoyaltySetting = Create__Instance__(Me.m_frmLoyaltySetting)
                    Return Me.m_frmLoyaltySetting
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmLoyaltySetting)
                    If value IsNot Me.m_frmLoyaltySetting Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmLoyaltySetting)
                    End If
                End Set
            End Property

            Public Property frmMarketingTools As RestaurantPOS14.frmMarketingTools
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmMarketingTools = Create__Instance__(Me.m_frmMarketingTools)
                    Return Me.m_frmMarketingTools
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmMarketingTools)
                    If value IsNot Me.m_frmMarketingTools Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmMarketingTools)
                    End If
                End Set
            End Property

            Public Property frmMember As RestaurantPOS14.frmMember
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmMember = Create__Instance__(Me.m_frmMember)
                    Return Me.m_frmMember
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmMember)
                    If value IsNot Me.m_frmMember Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmMember)
                    End If
                End Set
            End Property

            Public Property frmMemberBalance As RestaurantPOS14.frmMemberBalance
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmMemberBalance = Create__Instance__(Me.m_frmMemberBalance)
                    Return Me.m_frmMemberBalance
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmMemberBalance)
                    If value IsNot Me.m_frmMemberBalance Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmMemberBalance)
                    End If
                End Set
            End Property

            Public Property frmMemberLedger As RestaurantPOS14.frmMemberLedger
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmMemberLedger = Create__Instance__(Me.m_frmMemberLedger)
                    Return Me.m_frmMemberLedger
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmMemberLedger)
                    If value IsNot Me.m_frmMemberLedger Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmMemberLedger)
                    End If
                End Set
            End Property

            Public Property frmMemberList As RestaurantPOS14.frmMemberList
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmMemberList = Create__Instance__(Me.m_frmMemberList)
                    Return Me.m_frmMemberList
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmMemberList)
                    If value IsNot Me.m_frmMemberList Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmMemberList)
                    End If
                End Set
            End Property

            Public Property frmMenuItem As RestaurantPOS14.frmMenuItem
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmMenuItem = Create__Instance__(Me.m_frmMenuItem)
                    Return Me.m_frmMenuItem
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmMenuItem)
                    If value IsNot Me.m_frmMenuItem Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmMenuItem)
                    End If
                End Set
            End Property

            Public Property frmMenuItemsCategory As RestaurantPOS14.frmMenuItemsCategory
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmMenuItemsCategory = Create__Instance__(Me.m_frmMenuItemsCategory)
                    Return Me.m_frmMenuItemsCategory
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmMenuItemsCategory)
                    If value IsNot Me.m_frmMenuItemsCategory Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmMenuItemsCategory)
                    End If
                End Set
            End Property

            Public Property frmMenuItemsExportImport As RestaurantPOS14.frmMenuItemsExportImport
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmMenuItemsExportImport = Create__Instance__(Me.m_frmMenuItemsExportImport)
                    Return Me.m_frmMenuItemsExportImport
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmMenuItemsExportImport)
                    If value IsNot Me.m_frmMenuItemsExportImport Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmMenuItemsExportImport)
                    End If
                End Set
            End Property

            Public Property frmMenuItemsList As RestaurantPOS14.frmMenuItemsList
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmMenuItemsList = Create__Instance__(Me.m_frmMenuItemsList)
                    Return Me.m_frmMenuItemsList
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmMenuItemsList)
                    If value IsNot Me.m_frmMenuItemsList Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmMenuItemsList)
                    End If
                End Set
            End Property

            Public Property frmMenuItemsModifiers As RestaurantPOS14.frmMenuItemsModifiers
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmMenuItemsModifiers = Create__Instance__(Me.m_frmMenuItemsModifiers)
                    Return Me.m_frmMenuItemsModifiers
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmMenuItemsModifiers)
                    If value IsNot Me.m_frmMenuItemsModifiers Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmMenuItemsModifiers)
                    End If
                End Set
            End Property

            Public Property frmModifiersExportImport As RestaurantPOS14.frmModifiersExportImport
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmModifiersExportImport = Create__Instance__(Me.m_frmModifiersExportImport)
                    Return Me.m_frmModifiersExportImport
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmModifiersExportImport)
                    If value IsNot Me.m_frmModifiersExportImport Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmModifiersExportImport)
                    End If
                End Set
            End Property

            Public Property frmModifiersList As RestaurantPOS14.frmModifiersList
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmModifiersList = Create__Instance__(Me.m_frmModifiersList)
                    Return Me.m_frmModifiersList
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmModifiersList)
                    If value IsNot Me.m_frmModifiersList Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmModifiersList)
                    End If
                End Set
            End Property

            Public Property frmModifiersList_AutoPopUp As RestaurantPOS14.frmModifiersList_AutoPopUp
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmModifiersList_AutoPopUp = Create__Instance__(Me.m_frmModifiersList_AutoPopUp)
                    Return Me.m_frmModifiersList_AutoPopUp
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmModifiersList_AutoPopUp)
                    If value IsNot Me.m_frmModifiersList_AutoPopUp Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmModifiersList_AutoPopUp)
                    End If
                End Set
            End Property

            Public Property frmMpesaSetting As RestaurantPOS14.frmMpesaSetting
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmMpesaSetting = Create__Instance__(Me.m_frmMpesaSetting)
                    Return Me.m_frmMpesaSetting
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmMpesaSetting)
                    If value IsNot Me.m_frmMpesaSetting Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmMpesaSetting)
                    End If
                End Set
            End Property

            Public Property frmNotes As RestaurantPOS14.frmNotes
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmNotes = Create__Instance__(Me.m_frmNotes)
                    Return Me.m_frmNotes
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmNotes)
                    If value IsNot Me.m_frmNotes Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmNotes)
                    End If
                End Set
            End Property

            Public Property frmNotes1 As RestaurantPOS14.frmNotes1
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmNotes1 = Create__Instance__(Me.m_frmNotes1)
                    Return Me.m_frmNotes1
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmNotes1)
                    If value IsNot Me.m_frmNotes1 Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmNotes1)
                    End If
                End Set
            End Property

            Public Property frmNotesMaster As RestaurantPOS14.frmNotesMaster
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmNotesMaster = Create__Instance__(Me.m_frmNotesMaster)
                    Return Me.m_frmNotesMaster
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmNotesMaster)
                    If value IsNot Me.m_frmNotesMaster Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmNotesMaster)
                    End If
                End Set
            End Property

            Public Property frmOnscreenKeyboard As RestaurantPOS14.frmOnscreenKeyboard
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmOnscreenKeyboard = Create__Instance__(Me.m_frmOnscreenKeyboard)
                    Return Me.m_frmOnscreenKeyboard
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmOnscreenKeyboard)
                    If value IsNot Me.m_frmOnscreenKeyboard Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmOnscreenKeyboard)
                    End If
                End Set
            End Property

            Public Property frmOpenItems As RestaurantPOS14.frmOpenItems
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmOpenItems = Create__Instance__(Me.m_frmOpenItems)
                    Return Me.m_frmOpenItems
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmOpenItems)
                    If value IsNot Me.m_frmOpenItems Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmOpenItems)
                    End If
                End Set
            End Property

            Public Property frmOpenTicketsRecord As RestaurantPOS14.frmOpenTicketsRecord
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmOpenTicketsRecord = Create__Instance__(Me.m_frmOpenTicketsRecord)
                    Return Me.m_frmOpenTicketsRecord
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmOpenTicketsRecord)
                    If value IsNot Me.m_frmOpenTicketsRecord Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmOpenTicketsRecord)
                    End If
                End Set
            End Property

            Public Property frmOption As RestaurantPOS14.frmOption
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmOption = Create__Instance__(Me.m_frmOption)
                    Return Me.m_frmOption
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmOption)
                    If value IsNot Me.m_frmOption Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmOption)
                    End If
                End Set
            End Property

            Public Property frmOrderedItemDetails As RestaurantPOS14.frmOrderedItemDetails
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmOrderedItemDetails = Create__Instance__(Me.m_frmOrderedItemDetails)
                    Return Me.m_frmOrderedItemDetails
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmOrderedItemDetails)
                    If value IsNot Me.m_frmOrderedItemDetails Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmOrderedItemDetails)
                    End If
                End Set
            End Property

            Public Property frmOthersSetting As RestaurantPOS14.frmOthersSetting
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmOthersSetting = Create__Instance__(Me.m_frmOthersSetting)
                    Return Me.m_frmOthersSetting
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmOthersSetting)
                    If value IsNot Me.m_frmOthersSetting Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmOthersSetting)
                    End If
                End Set
            End Property

            Public Property frmPayment As RestaurantPOS14.frmPayment
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmPayment = Create__Instance__(Me.m_frmPayment)
                    Return Me.m_frmPayment
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmPayment)
                    If value IsNot Me.m_frmPayment Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmPayment)
                    End If
                End Set
            End Property

            Public Property frmPayment_Withdrawal As RestaurantPOS14.frmPayment_Withdrawal
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmPayment_Withdrawal = Create__Instance__(Me.m_frmPayment_Withdrawal)
                    Return Me.m_frmPayment_Withdrawal
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmPayment_Withdrawal)
                    If value IsNot Me.m_frmPayment_Withdrawal Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmPayment_Withdrawal)
                    End If
                End Set
            End Property

            Public Property frmPaymentRecord As RestaurantPOS14.frmPaymentRecord
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmPaymentRecord = Create__Instance__(Me.m_frmPaymentRecord)
                    Return Me.m_frmPaymentRecord
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmPaymentRecord)
                    If value IsNot Me.m_frmPaymentRecord Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmPaymentRecord)
                    End If
                End Set
            End Property

            Public Property frmPayroll As RestaurantPOS14.frmPayroll
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmPayroll = Create__Instance__(Me.m_frmPayroll)
                    Return Me.m_frmPayroll
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmPayroll)
                    If value IsNot Me.m_frmPayroll Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmPayroll)
                    End If
                End Set
            End Property

            Public Property frmPayroll_HB As RestaurantPOS14.frmPayroll_HB
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmPayroll_HB = Create__Instance__(Me.m_frmPayroll_HB)
                    Return Me.m_frmPayroll_HB
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmPayroll_HB)
                    If value IsNot Me.m_frmPayroll_HB Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmPayroll_HB)
                    End If
                End Set
            End Property

            Public Property frmPayroll_MB As RestaurantPOS14.frmPayroll_MB
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmPayroll_MB = Create__Instance__(Me.m_frmPayroll_MB)
                    Return Me.m_frmPayroll_MB
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmPayroll_MB)
                    If value IsNot Me.m_frmPayroll_MB Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmPayroll_MB)
                    End If
                End Set
            End Property

            Public Property frmPayroll_MBRecord As RestaurantPOS14.frmPayroll_MBRecord
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmPayroll_MBRecord = Create__Instance__(Me.m_frmPayroll_MBRecord)
                    Return Me.m_frmPayroll_MBRecord
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmPayroll_MBRecord)
                    If value IsNot Me.m_frmPayroll_MBRecord Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmPayroll_MBRecord)
                    End If
                End Set
            End Property

            Public Property frmPayrollRecord_HB As RestaurantPOS14.frmPayrollRecord_HB
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmPayrollRecord_HB = Create__Instance__(Me.m_frmPayrollRecord_HB)
                    Return Me.m_frmPayrollRecord_HB
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmPayrollRecord_HB)
                    If value IsNot Me.m_frmPayrollRecord_HB Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmPayrollRecord_HB)
                    End If
                End Set
            End Property

            Public Property frmPizza As RestaurantPOS14.frmPizza
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmPizza = Create__Instance__(Me.m_frmPizza)
                    Return Me.m_frmPizza
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmPizza)
                    If value IsNot Me.m_frmPizza Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmPizza)
                    End If
                End Set
            End Property

            Public Property frmPizzaMaster As RestaurantPOS14.frmPizzaMaster
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmPizzaMaster = Create__Instance__(Me.m_frmPizzaMaster)
                    Return Me.m_frmPizzaMaster
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmPizzaMaster)
                    If value IsNot Me.m_frmPizzaMaster Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmPizzaMaster)
                    End If
                End Set
            End Property

            Public Property frmPizzaModifiers As RestaurantPOS14.frmPizzaModifiers
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmPizzaModifiers = Create__Instance__(Me.m_frmPizzaModifiers)
                    Return Me.m_frmPizzaModifiers
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmPizzaModifiers)
                    If value IsNot Me.m_frmPizzaModifiers Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmPizzaModifiers)
                    End If
                End Set
            End Property

            Public Property frmPizzaModifiersList As RestaurantPOS14.frmPizzaModifiersList
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmPizzaModifiersList = Create__Instance__(Me.m_frmPizzaModifiersList)
                    Return Me.m_frmPizzaModifiersList
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmPizzaModifiersList)
                    If value IsNot Me.m_frmPizzaModifiersList Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmPizzaModifiersList)
                    End If
                End Set
            End Property

            Public Property frmPizzaModifiersList_AutoPopUp As RestaurantPOS14.frmPizzaModifiersList_AutoPopUp
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmPizzaModifiersList_AutoPopUp = Create__Instance__(Me.m_frmPizzaModifiersList_AutoPopUp)
                    Return Me.m_frmPizzaModifiersList_AutoPopUp
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmPizzaModifiersList_AutoPopUp)
                    If value IsNot Me.m_frmPizzaModifiersList_AutoPopUp Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmPizzaModifiersList_AutoPopUp)
                    End If
                End Set
            End Property

            Public Property frmPizzaPOS As RestaurantPOS14.frmPizzaPOS
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmPizzaPOS = Create__Instance__(Me.m_frmPizzaPOS)
                    Return Me.m_frmPizzaPOS
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmPizzaPOS)
                    If value IsNot Me.m_frmPizzaPOS Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmPizzaPOS)
                    End If
                End Set
            End Property

            Public Property frmPizzasExportImport As RestaurantPOS14.frmPizzasExportImport
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmPizzasExportImport = Create__Instance__(Me.m_frmPizzasExportImport)
                    Return Me.m_frmPizzasExportImport
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmPizzasExportImport)
                    If value IsNot Me.m_frmPizzasExportImport Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmPizzasExportImport)
                    End If
                End Set
            End Property

            Public Property frmPizzaSize As RestaurantPOS14.frmPizzaSize
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmPizzaSize = Create__Instance__(Me.m_frmPizzaSize)
                    Return Me.m_frmPizzaSize
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmPizzaSize)
                    If value IsNot Me.m_frmPizzaSize Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmPizzaSize)
                    End If
                End Set
            End Property

            Public Property frmPizzaToppings As RestaurantPOS14.frmPizzaToppings
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmPizzaToppings = Create__Instance__(Me.m_frmPizzaToppings)
                    Return Me.m_frmPizzaToppings
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmPizzaToppings)
                    If value IsNot Me.m_frmPizzaToppings Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmPizzaToppings)
                    End If
                End Set
            End Property

            Public Property frmPizzaToppingsExportImport As RestaurantPOS14.frmPizzaToppingsExportImport
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmPizzaToppingsExportImport = Create__Instance__(Me.m_frmPizzaToppingsExportImport)
                    Return Me.m_frmPizzaToppingsExportImport
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmPizzaToppingsExportImport)
                    If value IsNot Me.m_frmPizzaToppingsExportImport Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmPizzaToppingsExportImport)
                    End If
                End Set
            End Property

            Public Property frmPO_CRViewer As RestaurantPOS14.frmPO_CRViewer
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmPO_CRViewer = Create__Instance__(Me.m_frmPO_CRViewer)
                    Return Me.m_frmPO_CRViewer
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmPO_CRViewer)
                    If value IsNot Me.m_frmPO_CRViewer Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmPO_CRViewer)
                    End If
                End Set
            End Property

            Public Property frmPOS As RestaurantPOS14.frmPOS
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmPOS = Create__Instance__(Me.m_frmPOS)
                    Return Me.m_frmPOS
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmPOS)
                    If value IsNot Me.m_frmPOS Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmPOS)
                    End If
                End Set
            End Property

            Public Property frmPOSRecord As RestaurantPOS14.frmPOSRecord
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmPOSRecord = Create__Instance__(Me.m_frmPOSRecord)
                    Return Me.m_frmPOSRecord
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmPOSRecord)
                    If value IsNot Me.m_frmPOSRecord Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmPOSRecord)
                    End If
                End Set
            End Property

            Public Property frmPOSReport As RestaurantPOS14.frmPOSReport
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmPOSReport = Create__Instance__(Me.m_frmPOSReport)
                    Return Me.m_frmPOSReport
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmPOSReport)
                    If value IsNot Me.m_frmPOSReport Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmPOSReport)
                    End If
                End Set
            End Property

            Public Property frmPOSReport_CRViewer As RestaurantPOS14.frmPOSReport_CRViewer
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmPOSReport_CRViewer = Create__Instance__(Me.m_frmPOSReport_CRViewer)
                    Return Me.m_frmPOSReport_CRViewer
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmPOSReport_CRViewer)
                    If value IsNot Me.m_frmPOSReport_CRViewer Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmPOSReport_CRViewer)
                    End If
                End Set
            End Property

            Public Property frmPOSReport_CRViewer1 As RestaurantPOS14.frmPOSReport_CRViewer1
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmPOSReport_CRViewer1 = Create__Instance__(Me.m_frmPOSReport_CRViewer1)
                    Return Me.m_frmPOSReport_CRViewer1
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmPOSReport_CRViewer1)
                    If value IsNot Me.m_frmPOSReport_CRViewer1 Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmPOSReport_CRViewer1)
                    End If
                End Set
            End Property

            Public Property frmPrinterStatus As RestaurantPOS14.frmPrinterStatus
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmPrinterStatus = Create__Instance__(Me.m_frmPrinterStatus)
                    Return Me.m_frmPrinterStatus
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmPrinterStatus)
                    If value IsNot Me.m_frmPrinterStatus Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmPrinterStatus)
                    End If
                End Set
            End Property

            Public Property frmPrintLoyaltyCard As RestaurantPOS14.frmPrintLoyaltyCard
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmPrintLoyaltyCard = Create__Instance__(Me.m_frmPrintLoyaltyCard)
                    Return Me.m_frmPrintLoyaltyCard
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmPrintLoyaltyCard)
                    If value IsNot Me.m_frmPrintLoyaltyCard Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmPrintLoyaltyCard)
                    End If
                End Set
            End Property

            Public Property frmPrintVIPMemberCard As RestaurantPOS14.frmPrintVIPMemberCard
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmPrintVIPMemberCard = Create__Instance__(Me.m_frmPrintVIPMemberCard)
                    Return Me.m_frmPrintVIPMemberCard
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmPrintVIPMemberCard)
                    If value IsNot Me.m_frmPrintVIPMemberCard Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmPrintVIPMemberCard)
                    End If
                End Set
            End Property

            Public Property frmProduct As RestaurantPOS14.frmProduct
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmProduct = Create__Instance__(Me.m_frmProduct)
                    Return Me.m_frmProduct
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmProduct)
                    If value IsNot Me.m_frmProduct Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmProduct)
                    End If
                End Set
            End Property

            Public Property frmProductRecord As RestaurantPOS14.frmProductRecord
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmProductRecord = Create__Instance__(Me.m_frmProductRecord)
                    Return Me.m_frmProductRecord
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmProductRecord)
                    If value IsNot Me.m_frmProductRecord Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmProductRecord)
                    End If
                End Set
            End Property

            Public Property frmPromotion As RestaurantPOS14.frmPromotion
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmPromotion = Create__Instance__(Me.m_frmPromotion)
                    Return Me.m_frmPromotion
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmPromotion)
                    If value IsNot Me.m_frmPromotion Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmPromotion)
                    End If
                End Set
            End Property

            Public Property frmPurchaseEntry As RestaurantPOS14.frmPurchaseEntry
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmPurchaseEntry = Create__Instance__(Me.m_frmPurchaseEntry)
                    Return Me.m_frmPurchaseEntry
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmPurchaseEntry)
                    If value IsNot Me.m_frmPurchaseEntry Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmPurchaseEntry)
                    End If
                End Set
            End Property

            Public Property frmPurchaseOrder As RestaurantPOS14.frmPurchaseOrder
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmPurchaseOrder = Create__Instance__(Me.m_frmPurchaseOrder)
                    Return Me.m_frmPurchaseOrder
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmPurchaseOrder)
                    If value IsNot Me.m_frmPurchaseOrder Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmPurchaseOrder)
                    End If
                End Set
            End Property

            Public Property frmPurchaseOrderRecord As RestaurantPOS14.frmPurchaseOrderRecord
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmPurchaseOrderRecord = Create__Instance__(Me.m_frmPurchaseOrderRecord)
                    Return Me.m_frmPurchaseOrderRecord
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmPurchaseOrderRecord)
                    If value IsNot Me.m_frmPurchaseOrderRecord Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmPurchaseOrderRecord)
                    End If
                End Set
            End Property

            Public Property frmPurchaseRecord As RestaurantPOS14.frmPurchaseRecord
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmPurchaseRecord = Create__Instance__(Me.m_frmPurchaseRecord)
                    Return Me.m_frmPurchaseRecord
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmPurchaseRecord)
                    If value IsNot Me.m_frmPurchaseRecord Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmPurchaseRecord)
                    End If
                End Set
            End Property

            Public Property frmRawMaterialsCategory As RestaurantPOS14.frmRawMaterialsCategory
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmRawMaterialsCategory = Create__Instance__(Me.m_frmRawMaterialsCategory)
                    Return Me.m_frmRawMaterialsCategory
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmRawMaterialsCategory)
                    If value IsNot Me.m_frmRawMaterialsCategory Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmRawMaterialsCategory)
                    End If
                End Set
            End Property

            Public Property frmRawMaterialsUsed As RestaurantPOS14.frmRawMaterialsUsed
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmRawMaterialsUsed = Create__Instance__(Me.m_frmRawMaterialsUsed)
                    Return Me.m_frmRawMaterialsUsed
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmRawMaterialsUsed)
                    If value IsNot Me.m_frmRawMaterialsUsed Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmRawMaterialsUsed)
                    End If
                End Set
            End Property

            Public Property frmRecipe As RestaurantPOS14.frmRecipe
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmRecipe = Create__Instance__(Me.m_frmRecipe)
                    Return Me.m_frmRecipe
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmRecipe)
                    If value IsNot Me.m_frmRecipe Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmRecipe)
                    End If
                End Set
            End Property

            Public Property frmRecipeRecord As RestaurantPOS14.frmRecipeRecord
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmRecipeRecord = Create__Instance__(Me.m_frmRecipeRecord)
                    Return Me.m_frmRecipeRecord
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmRecipeRecord)
                    If value IsNot Me.m_frmRecipeRecord Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmRecipeRecord)
                    End If
                End Set
            End Property

            Public Property frmRecoveryPIN As RestaurantPOS14.frmRecoveryPIN
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmRecoveryPIN = Create__Instance__(Me.m_frmRecoveryPIN)
                    Return Me.m_frmRecoveryPIN
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmRecoveryPIN)
                    If value IsNot Me.m_frmRecoveryPIN Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmRecoveryPIN)
                    End If
                End Set
            End Property

            Public Property frmRefundMoney As RestaurantPOS14.frmRefundMoney
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmRefundMoney = Create__Instance__(Me.m_frmRefundMoney)
                    Return Me.m_frmRefundMoney
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmRefundMoney)
                    If value IsNot Me.m_frmRefundMoney Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmRefundMoney)
                    End If
                End Set
            End Property

            Public Property frmRefundMoneyRecord As RestaurantPOS14.frmRefundMoneyRecord
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmRefundMoneyRecord = Create__Instance__(Me.m_frmRefundMoneyRecord)
                    Return Me.m_frmRefundMoneyRecord
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmRefundMoneyRecord)
                    If value IsNot Me.m_frmRefundMoneyRecord Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmRefundMoneyRecord)
                    End If
                End Set
            End Property

            Public Property frmRegistration As RestaurantPOS14.frmRegistration
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmRegistration = Create__Instance__(Me.m_frmRegistration)
                    Return Me.m_frmRegistration
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmRegistration)
                    If value IsNot Me.m_frmRegistration Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmRegistration)
                    End If
                End Set
            End Property

            Public Property frmReport As RestaurantPOS14.frmReport
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmReport = Create__Instance__(Me.m_frmReport)
                    Return Me.m_frmReport
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmReport)
                    If value IsNot Me.m_frmReport Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmReport)
                    End If
                End Set
            End Property

            Public Property frmRestaurantMaster As RestaurantPOS14.frmRestaurantMaster
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmRestaurantMaster = Create__Instance__(Me.m_frmRestaurantMaster)
                    Return Me.m_frmRestaurantMaster
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmRestaurantMaster)
                    If value IsNot Me.m_frmRestaurantMaster Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmRestaurantMaster)
                    End If
                End Set
            End Property

            Public Property frmRestaurantPOSEBRecord As RestaurantPOS14.frmRestaurantPOSEBRecord
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmRestaurantPOSEBRecord = Create__Instance__(Me.m_frmRestaurantPOSEBRecord)
                    Return Me.m_frmRestaurantPOSEBRecord
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmRestaurantPOSEBRecord)
                    If value IsNot Me.m_frmRestaurantPOSEBRecord Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmRestaurantPOSEBRecord)
                    End If
                End Set
            End Property

            Public Property frmRestaurantPOSEBRecord_Unpaid As RestaurantPOS14.frmRestaurantPOSEBRecord_Unpaid
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmRestaurantPOSEBRecord_Unpaid = Create__Instance__(Me.m_frmRestaurantPOSEBRecord_Unpaid)
                    Return Me.m_frmRestaurantPOSEBRecord_Unpaid
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmRestaurantPOSEBRecord_Unpaid)
                    If value IsNot Me.m_frmRestaurantPOSEBRecord_Unpaid Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmRestaurantPOSEBRecord_Unpaid)
                    End If
                End Set
            End Property

            Public Property frmRestaurantPOSHDRecord As RestaurantPOS14.frmRestaurantPOSHDRecord
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmRestaurantPOSHDRecord = Create__Instance__(Me.m_frmRestaurantPOSHDRecord)
                    Return Me.m_frmRestaurantPOSHDRecord
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmRestaurantPOSHDRecord)
                    If value IsNot Me.m_frmRestaurantPOSHDRecord Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmRestaurantPOSHDRecord)
                    End If
                End Set
            End Property

            Public Property frmRestaurantPOSHDRecord1 As RestaurantPOS14.frmRestaurantPOSHDRecord1
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmRestaurantPOSHDRecord1 = Create__Instance__(Me.m_frmRestaurantPOSHDRecord1)
                    Return Me.m_frmRestaurantPOSHDRecord1
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmRestaurantPOSHDRecord1)
                    If value IsNot Me.m_frmRestaurantPOSHDRecord1 Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmRestaurantPOSHDRecord1)
                    End If
                End Set
            End Property

            Public Property frmRestaurantPOSKOTFinalBillRecord As RestaurantPOS14.frmRestaurantPOSKOTFinalBillRecord
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmRestaurantPOSKOTFinalBillRecord = Create__Instance__(Me.m_frmRestaurantPOSKOTFinalBillRecord)
                    Return Me.m_frmRestaurantPOSKOTFinalBillRecord
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmRestaurantPOSKOTFinalBillRecord)
                    If value IsNot Me.m_frmRestaurantPOSKOTFinalBillRecord Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmRestaurantPOSKOTFinalBillRecord)
                    End If
                End Set
            End Property

            Public Property frmRestaurantPOSKOTFinalBillRecord_Unpaid As RestaurantPOS14.frmRestaurantPOSKOTFinalBillRecord_Unpaid
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmRestaurantPOSKOTFinalBillRecord_Unpaid = Create__Instance__(Me.m_frmRestaurantPOSKOTFinalBillRecord_Unpaid)
                    Return Me.m_frmRestaurantPOSKOTFinalBillRecord_Unpaid
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmRestaurantPOSKOTFinalBillRecord_Unpaid)
                    If value IsNot Me.m_frmRestaurantPOSKOTFinalBillRecord_Unpaid Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmRestaurantPOSKOTFinalBillRecord_Unpaid)
                    End If
                End Set
            End Property

            Public Property frmRestaurantPOSKOTRecord As RestaurantPOS14.frmRestaurantPOSKOTRecord
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmRestaurantPOSKOTRecord = Create__Instance__(Me.m_frmRestaurantPOSKOTRecord)
                    Return Me.m_frmRestaurantPOSKOTRecord
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmRestaurantPOSKOTRecord)
                    If value IsNot Me.m_frmRestaurantPOSKOTRecord Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmRestaurantPOSKOTRecord)
                    End If
                End Set
            End Property

            Public Property frmRestaurantPOSTARecord As RestaurantPOS14.frmRestaurantPOSTARecord
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmRestaurantPOSTARecord = Create__Instance__(Me.m_frmRestaurantPOSTARecord)
                    Return Me.m_frmRestaurantPOSTARecord
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmRestaurantPOSTARecord)
                    If value IsNot Me.m_frmRestaurantPOSTARecord Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmRestaurantPOSTARecord)
                    End If
                End Set
            End Property

            Public Property frmRestaurantPOSTARecord_Unpaid As RestaurantPOS14.frmRestaurantPOSTARecord_Unpaid
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmRestaurantPOSTARecord_Unpaid = Create__Instance__(Me.m_frmRestaurantPOSTARecord_Unpaid)
                    Return Me.m_frmRestaurantPOSTARecord_Unpaid
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmRestaurantPOSTARecord_Unpaid)
                    If value IsNot Me.m_frmRestaurantPOSTARecord_Unpaid Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmRestaurantPOSTARecord_Unpaid)
                    End If
                End Set
            End Property

            Public Property frmSecondaryDisplay As RestaurantPOS14.frmSecondaryDisplay
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmSecondaryDisplay = Create__Instance__(Me.m_frmSecondaryDisplay)
                    Return Me.m_frmSecondaryDisplay
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmSecondaryDisplay)
                    If value IsNot Me.m_frmSecondaryDisplay Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmSecondaryDisplay)
                    End If
                End Set
            End Property

            Public Property frmSendBroadcastSMS As RestaurantPOS14.frmSendBroadcastSMS
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmSendBroadcastSMS = Create__Instance__(Me.m_frmSendBroadcastSMS)
                    Return Me.m_frmSendBroadcastSMS
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmSendBroadcastSMS)
                    If value IsNot Me.m_frmSendBroadcastSMS Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmSendBroadcastSMS)
                    End If
                End Set
            End Property

            Public Property frmSendEmail As RestaurantPOS14.frmSendEmail
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmSendEmail = Create__Instance__(Me.m_frmSendEmail)
                    Return Me.m_frmSendEmail
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmSendEmail)
                    If value IsNot Me.m_frmSendEmail Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmSendEmail)
                    End If
                End Set
            End Property

            Public Property frmSetDiscount As RestaurantPOS14.frmSetDiscount
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmSetDiscount = Create__Instance__(Me.m_frmSetDiscount)
                    Return Me.m_frmSetDiscount
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmSetDiscount)
                    If value IsNot Me.m_frmSetDiscount Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmSetDiscount)
                    End If
                End Set
            End Property

            Public Property frmSetNOP As RestaurantPOS14.frmSetNOP
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmSetNOP = Create__Instance__(Me.m_frmSetNOP)
                    Return Me.m_frmSetNOP
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmSetNOP)
                    If value IsNot Me.m_frmSetNOP Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmSetNOP)
                    End If
                End Set
            End Property

            Public Property frmSettings As RestaurantPOS14.frmSettings
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmSettings = Create__Instance__(Me.m_frmSettings)
                    Return Me.m_frmSettings
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmSettings)
                    If value IsNot Me.m_frmSettings Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmSettings)
                    End If
                End Set
            End Property

            Public Property frmSMSSetting As RestaurantPOS14.frmSMSSetting
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmSMSSetting = Create__Instance__(Me.m_frmSMSSetting)
                    Return Me.m_frmSMSSetting
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmSMSSetting)
                    If value IsNot Me.m_frmSMSSetting Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmSMSSetting)
                    End If
                End Set
            End Property

            Public Property frmSoftwareLicenceRenewal As RestaurantPOS14.frmSoftwareLicenceRenewal
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmSoftwareLicenceRenewal = Create__Instance__(Me.m_frmSoftwareLicenceRenewal)
                    Return Me.m_frmSoftwareLicenceRenewal
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmSoftwareLicenceRenewal)
                    If value IsNot Me.m_frmSoftwareLicenceRenewal Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmSoftwareLicenceRenewal)
                    End If
                End Set
            End Property

            Public Property frmSplash As RestaurantPOS14.frmSplash
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmSplash = Create__Instance__(Me.m_frmSplash)
                    Return Me.m_frmSplash
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmSplash)
                    If value IsNot Me.m_frmSplash Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmSplash)
                    End If
                End Set
            End Property

            Public Property frmSqlServerSetting As RestaurantPOS14.frmSqlServerSetting
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmSqlServerSetting = Create__Instance__(Me.m_frmSqlServerSetting)
                    Return Me.m_frmSqlServerSetting
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmSqlServerSetting)
                    If value IsNot Me.m_frmSqlServerSetting Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmSqlServerSetting)
                    End If
                End Set
            End Property

            Public Property frmStock_Store As RestaurantPOS14.frmStock_Store
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmStock_Store = Create__Instance__(Me.m_frmStock_Store)
                    Return Me.m_frmStock_Store
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmStock_Store)
                    If value IsNot Me.m_frmStock_Store Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmStock_Store)
                    End If
                End Set
            End Property

            Public Property frmStock_StoreRecord As RestaurantPOS14.frmStock_StoreRecord
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmStock_StoreRecord = Create__Instance__(Me.m_frmStock_StoreRecord)
                    Return Me.m_frmStock_StoreRecord
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmStock_StoreRecord)
                    If value IsNot Me.m_frmStock_StoreRecord Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmStock_StoreRecord)
                    End If
                End Set
            End Property

            Public Property frmStockAdjustment As RestaurantPOS14.frmStockAdjustment
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmStockAdjustment = Create__Instance__(Me.m_frmStockAdjustment)
                    Return Me.m_frmStockAdjustment
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmStockAdjustment)
                    If value IsNot Me.m_frmStockAdjustment Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmStockAdjustment)
                    End If
                End Set
            End Property

            Public Property frmStockAdjustment_MI As RestaurantPOS14.frmStockAdjustment_MI
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmStockAdjustment_MI = Create__Instance__(Me.m_frmStockAdjustment_MI)
                    Return Me.m_frmStockAdjustment_MI
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmStockAdjustment_MI)
                    If value IsNot Me.m_frmStockAdjustment_MI Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmStockAdjustment_MI)
                    End If
                End Set
            End Property

            Public Property frmStockAdjustment_MI_Record As RestaurantPOS14.frmStockAdjustment_MI_Record
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmStockAdjustment_MI_Record = Create__Instance__(Me.m_frmStockAdjustment_MI_Record)
                    Return Me.m_frmStockAdjustment_MI_Record
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmStockAdjustment_MI_Record)
                    If value IsNot Me.m_frmStockAdjustment_MI_Record Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmStockAdjustment_MI_Record)
                    End If
                End Set
            End Property

            Public Property frmStockAdjustment_Store As RestaurantPOS14.frmStockAdjustment_Store
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmStockAdjustment_Store = Create__Instance__(Me.m_frmStockAdjustment_Store)
                    Return Me.m_frmStockAdjustment_Store
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmStockAdjustment_Store)
                    If value IsNot Me.m_frmStockAdjustment_Store Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmStockAdjustment_Store)
                    End If
                End Set
            End Property

            Public Property frmStockAdjustment_Store_Record As RestaurantPOS14.frmStockAdjustment_Store_Record
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmStockAdjustment_Store_Record = Create__Instance__(Me.m_frmStockAdjustment_Store_Record)
                    Return Me.m_frmStockAdjustment_Store_Record
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmStockAdjustment_Store_Record)
                    If value IsNot Me.m_frmStockAdjustment_Store_Record Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmStockAdjustment_Store_Record)
                    End If
                End Set
            End Property

            Public Property frmStockAdjustment_Warehouse As RestaurantPOS14.frmStockAdjustment_Warehouse
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmStockAdjustment_Warehouse = Create__Instance__(Me.m_frmStockAdjustment_Warehouse)
                    Return Me.m_frmStockAdjustment_Warehouse
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmStockAdjustment_Warehouse)
                    If value IsNot Me.m_frmStockAdjustment_Warehouse Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmStockAdjustment_Warehouse)
                    End If
                End Set
            End Property

            Public Property frmStockAdjustment_Warehouse_Record As RestaurantPOS14.frmStockAdjustment_Warehouse_Record
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmStockAdjustment_Warehouse_Record = Create__Instance__(Me.m_frmStockAdjustment_Warehouse_Record)
                    Return Me.m_frmStockAdjustment_Warehouse_Record
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmStockAdjustment_Warehouse_Record)
                    If value IsNot Me.m_frmStockAdjustment_Warehouse_Record Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmStockAdjustment_Warehouse_Record)
                    End If
                End Set
            End Property

            Public Property frmStockIn_RM As RestaurantPOS14.frmStockIn_RM
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmStockIn_RM = Create__Instance__(Me.m_frmStockIn_RM)
                    Return Me.m_frmStockIn_RM
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmStockIn_RM)
                    If value IsNot Me.m_frmStockIn_RM Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmStockIn_RM)
                    End If
                End Set
            End Property

            Public Property frmStockIn_StoreRecord As RestaurantPOS14.frmStockIn_StoreRecord
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmStockIn_StoreRecord = Create__Instance__(Me.m_frmStockIn_StoreRecord)
                    Return Me.m_frmStockIn_StoreRecord
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmStockIn_StoreRecord)
                    If value IsNot Me.m_frmStockIn_StoreRecord Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmStockIn_StoreRecord)
                    End If
                End Set
            End Property

            Public Property frmStockInRecord As RestaurantPOS14.frmStockInRecord
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmStockInRecord = Create__Instance__(Me.m_frmStockInRecord)
                    Return Me.m_frmStockInRecord
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmStockInRecord)
                    If value IsNot Me.m_frmStockInRecord Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmStockInRecord)
                    End If
                End Set
            End Property

            Public Property frmStockOUT_RM As RestaurantPOS14.frmStockOUT_RM
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmStockOUT_RM = Create__Instance__(Me.m_frmStockOUT_RM)
                    Return Me.m_frmStockOUT_RM
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmStockOUT_RM)
                    If value IsNot Me.m_frmStockOUT_RM Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmStockOUT_RM)
                    End If
                End Set
            End Property

            Public Property frmStockOUT_StoreRecord As RestaurantPOS14.frmStockOUT_StoreRecord
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmStockOUT_StoreRecord = Create__Instance__(Me.m_frmStockOUT_StoreRecord)
                    Return Me.m_frmStockOUT_StoreRecord
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmStockOUT_StoreRecord)
                    If value IsNot Me.m_frmStockOUT_StoreRecord Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmStockOUT_StoreRecord)
                    End If
                End Set
            End Property

            Public Property frmStockOUTRecord As RestaurantPOS14.frmStockOUTRecord
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmStockOUTRecord = Create__Instance__(Me.m_frmStockOUTRecord)
                    Return Me.m_frmStockOUTRecord
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmStockOUTRecord)
                    If value IsNot Me.m_frmStockOUTRecord Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmStockOUTRecord)
                    End If
                End Set
            End Property

            Public Property frmStockTransfer As RestaurantPOS14.frmStockTransfer
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmStockTransfer = Create__Instance__(Me.m_frmStockTransfer)
                    Return Me.m_frmStockTransfer
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmStockTransfer)
                    If value IsNot Me.m_frmStockTransfer Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmStockTransfer)
                    End If
                End Set
            End Property

            Public Property frmStockTransferRecord As RestaurantPOS14.frmStockTransferRecord
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmStockTransferRecord = Create__Instance__(Me.m_frmStockTransferRecord)
                    Return Me.m_frmStockTransferRecord
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmStockTransferRecord)
                    If value IsNot Me.m_frmStockTransferRecord Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmStockTransferRecord)
                    End If
                End Set
            End Property

            Public Property frmSupplier As RestaurantPOS14.frmSupplier
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmSupplier = Create__Instance__(Me.m_frmSupplier)
                    Return Me.m_frmSupplier
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmSupplier)
                    If value IsNot Me.m_frmSupplier Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmSupplier)
                    End If
                End Set
            End Property

            Public Property frmSupplierRecord As RestaurantPOS14.frmSupplierRecord
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmSupplierRecord = Create__Instance__(Me.m_frmSupplierRecord)
                    Return Me.m_frmSupplierRecord
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmSupplierRecord)
                    If value IsNot Me.m_frmSupplierRecord Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmSupplierRecord)
                    End If
                End Set
            End Property

            Public Property frmSystemInfo As RestaurantPOS14.frmSystemInfo
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmSystemInfo = Create__Instance__(Me.m_frmSystemInfo)
                    Return Me.m_frmSystemInfo
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmSystemInfo)
                    If value IsNot Me.m_frmSystemInfo Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmSystemInfo)
                    End If
                End Set
            End Property

            Public Property frmTable As RestaurantPOS14.frmTable
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmTable = Create__Instance__(Me.m_frmTable)
                    Return Me.m_frmTable
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmTable)
                    If value IsNot Me.m_frmTable Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmTable)
                    End If
                End Set
            End Property

            Public Property frmTableLayout As RestaurantPOS14.frmTableLayout
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmTableLayout = Create__Instance__(Me.m_frmTableLayout)
                    Return Me.m_frmTableLayout
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmTableLayout)
                    If value IsNot Me.m_frmTableLayout Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmTableLayout)
                    End If
                End Set
            End Property

            Public Property frmTableLayoutSettings As RestaurantPOS14.frmTableLayoutSettings
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmTableLayoutSettings = Create__Instance__(Me.m_frmTableLayoutSettings)
                    Return Me.m_frmTableLayoutSettings
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmTableLayoutSettings)
                    If value IsNot Me.m_frmTableLayoutSettings Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmTableLayoutSettings)
                    End If
                End Set
            End Property

            Public Property frmTableList As RestaurantPOS14.frmTableList
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmTableList = Create__Instance__(Me.m_frmTableList)
                    Return Me.m_frmTableList
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmTableList)
                    If value IsNot Me.m_frmTableList Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmTableList)
                    End If
                End Set
            End Property

            Public Property frmTableMapping_Waiter As RestaurantPOS14.frmTableMapping_Waiter
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmTableMapping_Waiter = Create__Instance__(Me.m_frmTableMapping_Waiter)
                    Return Me.m_frmTableMapping_Waiter
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmTableMapping_Waiter)
                    If value IsNot Me.m_frmTableMapping_Waiter Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmTableMapping_Waiter)
                    End If
                End Set
            End Property

            Public Property frmTableReservation As RestaurantPOS14.frmTableReservation
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmTableReservation = Create__Instance__(Me.m_frmTableReservation)
                    Return Me.m_frmTableReservation
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmTableReservation)
                    If value IsNot Me.m_frmTableReservation Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmTableReservation)
                    End If
                End Set
            End Property

            Public Property frmTablesExportImport As RestaurantPOS14.frmTablesExportImport
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmTablesExportImport = Create__Instance__(Me.m_frmTablesExportImport)
                    Return Me.m_frmTablesExportImport
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmTablesExportImport)
                    If value IsNot Me.m_frmTablesExportImport Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmTablesExportImport)
                    End If
                End Set
            End Property

            Public Property frmTerminalSetting As RestaurantPOS14.frmTerminalSetting
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmTerminalSetting = Create__Instance__(Me.m_frmTerminalSetting)
                    Return Me.m_frmTerminalSetting
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmTerminalSetting)
                    If value IsNot Me.m_frmTerminalSetting Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmTerminalSetting)
                    End If
                End Set
            End Property

            Public Property frmTestDualDisplay As RestaurantPOS14.frmTestDualDisplay
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmTestDualDisplay = Create__Instance__(Me.m_frmTestDualDisplay)
                    Return Me.m_frmTestDualDisplay
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmTestDualDisplay)
                    If value IsNot Me.m_frmTestDualDisplay Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmTestDualDisplay)
                    End If
                End Set
            End Property

            Public Property frmToppingsList As RestaurantPOS14.frmToppingsList
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmToppingsList = Create__Instance__(Me.m_frmToppingsList)
                    Return Me.m_frmToppingsList
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmToppingsList)
                    If value IsNot Me.m_frmToppingsList Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmToppingsList)
                    End If
                End Set
            End Property

            Public Property frmToppingsList1 As RestaurantPOS14.frmToppingsList1
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmToppingsList1 = Create__Instance__(Me.m_frmToppingsList1)
                    Return Me.m_frmToppingsList1
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmToppingsList1)
                    If value IsNot Me.m_frmToppingsList1 Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmToppingsList1)
                    End If
                End Set
            End Property

            Public Property frmUnit As RestaurantPOS14.frmUnit
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmUnit = Create__Instance__(Me.m_frmUnit)
                    Return Me.m_frmUnit
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmUnit)
                    If value IsNot Me.m_frmUnit Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmUnit)
                    End If
                End Set
            End Property

            Public Property frmUserRights As RestaurantPOS14.frmUserRights
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmUserRights = Create__Instance__(Me.m_frmUserRights)
                    Return Me.m_frmUserRights
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmUserRights)
                    If value IsNot Me.m_frmUserRights Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmUserRights)
                    End If
                End Set
            End Property

            Public Property frmVIPMemberCard As RestaurantPOS14.frmVIPMemberCard
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmVIPMemberCard = Create__Instance__(Me.m_frmVIPMemberCard)
                    Return Me.m_frmVIPMemberCard
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmVIPMemberCard)
                    If value IsNot Me.m_frmVIPMemberCard Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmVIPMemberCard)
                    End If
                End Set
            End Property

            Public Property frmVoucher As RestaurantPOS14.frmVoucher
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmVoucher = Create__Instance__(Me.m_frmVoucher)
                    Return Me.m_frmVoucher
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmVoucher)
                    If value IsNot Me.m_frmVoucher Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmVoucher)
                    End If
                End Set
            End Property

            Public Property frmVoucherRecord As RestaurantPOS14.frmVoucherRecord
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmVoucherRecord = Create__Instance__(Me.m_frmVoucherRecord)
                    Return Me.m_frmVoucherRecord
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmVoucherRecord)
                    If value IsNot Me.m_frmVoucherRecord Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmVoucherRecord)
                    End If
                End Set
            End Property

            Public Property frmWaiterList As RestaurantPOS14.frmWaiterList
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmWaiterList = Create__Instance__(Me.m_frmWaiterList)
                    Return Me.m_frmWaiterList
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmWaiterList)
                    If value IsNot Me.m_frmWaiterList Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmWaiterList)
                    End If
                End Set
            End Property

            Public Property frmWalletList As RestaurantPOS14.frmWalletList
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmWalletList = Create__Instance__(Me.m_frmWalletList)
                    Return Me.m_frmWalletList
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmWalletList)
                    If value IsNot Me.m_frmWalletList Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmWalletList)
                    End If
                End Set
            End Property

            Public Property frmWalletType As RestaurantPOS14.frmWalletType
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmWalletType = Create__Instance__(Me.m_frmWalletType)
                    Return Me.m_frmWalletType
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmWalletType)
                    If value IsNot Me.m_frmWalletType Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmWalletType)
                    End If
                End Set
            End Property

            Public Property frmWarehouse As RestaurantPOS14.frmWarehouse
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmWarehouse = Create__Instance__(Me.m_frmWarehouse)
                    Return Me.m_frmWarehouse
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmWarehouse)
                    If value IsNot Me.m_frmWarehouse Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmWarehouse)
                    End If
                End Set
            End Property

            Public Property frmWarehouseType As RestaurantPOS14.frmWarehouseType
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmWarehouseType = Create__Instance__(Me.m_frmWarehouseType)
                    Return Me.m_frmWarehouseType
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmWarehouseType)
                    If value IsNot Me.m_frmWarehouseType Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmWarehouseType)
                    End If
                End Set
            End Property

            Public Property frmWorkPeriod As RestaurantPOS14.frmWorkPeriod
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmWorkPeriod = Create__Instance__(Me.m_frmWorkPeriod)
                    Return Me.m_frmWorkPeriod
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmWorkPeriod)
                    If value IsNot Me.m_frmWorkPeriod Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmWorkPeriod)
                    End If
                End Set
            End Property

            Public Property frmWorkPeriod_Del As RestaurantPOS14.frmWorkPeriod_Del
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmWorkPeriod_Del = Create__Instance__(Me.m_frmWorkPeriod_Del)
                    Return Me.m_frmWorkPeriod_Del
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmWorkPeriod_Del)
                    If value IsNot Me.m_frmWorkPeriod_Del Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmWorkPeriod_Del)
                    End If
                End Set
            End Property

            Public Property frmWorkPeriodReport As RestaurantPOS14.frmWorkPeriodReport
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmWorkPeriodReport = Create__Instance__(Me.m_frmWorkPeriodReport)
                    Return Me.m_frmWorkPeriodReport
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmWorkPeriodReport)
                    If value IsNot Me.m_frmWorkPeriodReport Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmWorkPeriodReport)
                    End If
                End Set
            End Property

            Public Property frmWPReport_CRViewer As RestaurantPOS14.frmWPReport_CRViewer
                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Get
                    Me.m_frmWPReport_CRViewer = Create__Instance__(Me.m_frmWPReport_CRViewer)
                    Return Me.m_frmWPReport_CRViewer
                End Get

                <System.Diagnostics.DebuggerNonUserCodeAttribute>
                Set(value As RestaurantPOS14.frmWPReport_CRViewer)
                    If value IsNot Me.m_frmWPReport_CRViewer Then
                        If value IsNot Nothing Then
                            Throw New System.ArgumentException("Property can only be set to Nothing")
                        End If

                        Dispose__Instance__(Me.m_frmWPReport_CRViewer)
                    End If
                End Set
            End Property

            <System.Diagnostics.DebuggerHiddenAttribute>
            Private Shared Function Create__Instance__(Of T As {System.Windows.Forms.Form, New})(Instance As T) As T
                If Instance Is Nothing OrElse Instance.IsDisposed Then
                    If RestaurantPOS14.My.MyProject.MyForms.m_FormBeingCreated IsNot Nothing AndAlso RestaurantPOS14.My.MyProject.MyForms.m_FormBeingCreated.ContainsKey(GetType(T)) Then
                        Throw New System.InvalidOperationException(Microsoft.VisualBasic.CompilerServices.Utils.GetResourceString("WinForms_RecursiveFormCreate"))
                    End If

                    If RestaurantPOS14.My.MyProject.MyForms.m_FormBeingCreated Is Nothing Then
                        RestaurantPOS14.My.MyProject.MyForms.m_FormBeingCreated = New System.Collections.Hashtable()
                    End If

                    Call RestaurantPOS14.My.MyProject.MyForms.m_FormBeingCreated.Add(GetType(T), Nothing)
                    Try
                        Return New T()
                    Catch ex As System.Reflection.TargetInvocationException
                        If ex.InnerException IsNot Nothing Then
                            Throw New System.InvalidOperationException(Microsoft.VisualBasic.CompilerServices.Utils.GetResourceString("WinForms_SeeInnerException", ex.InnerException.Message), ex.InnerException)
                        End If

                        Throw
                    Finally
                        Call RestaurantPOS14.My.MyProject.MyForms.m_FormBeingCreated.Remove(GetType(T))
                    End Try
                End If

                Return Instance
            End Function

            <System.Diagnostics.DebuggerHiddenAttribute>
            Private Sub Dispose__Instance__(Of T As System.Windows.Forms.Form)(ByRef instance As T)
                instance.Dispose()
                instance = Nothing
            End Sub

            <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)>
            <System.Diagnostics.DebuggerHiddenAttribute>
            Public Sub New()
            End Sub

            <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)>
            Public Overrides Function Equals(o As Object) As Boolean
                Return MyBase.Equals(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(o))
            End Function

            <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)>
            Public Overrides Function GetHashCode() As Integer
                Return MyBase.GetHashCode()
            End Function

            <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)>
            Friend Overloads Function [GetType]() As System.Type
                Return GetType(RestaurantPOS14.My.MyProject.MyForms)
            End Function

            <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)>
            Public Overrides Function ToString() As String
                Return MyBase.ToString()
            End Function
        End Class

        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)>
        <Microsoft.VisualBasic.MyGroupCollectionAttribute("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")>
        Friend NotInheritable Class MyWebServices

            <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)>
            <System.Diagnostics.DebuggerHiddenAttribute>
            Public Overrides Function Equals(o As Object) As Boolean
                Return MyBase.Equals(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(o))
            End Function

            <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)>
            <System.Diagnostics.DebuggerHiddenAttribute>
            Public Overrides Function GetHashCode() As Integer
                Return MyBase.GetHashCode()
            End Function

            <System.Diagnostics.DebuggerHiddenAttribute>
            <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)>
            Friend Overloads Function [GetType]() As System.Type
                Return GetType(RestaurantPOS14.My.MyProject.MyWebServices)
            End Function

            <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)>
            <System.Diagnostics.DebuggerHiddenAttribute>
            Public Overrides Function ToString() As String
                Return MyBase.ToString()
            End Function

            <System.Diagnostics.DebuggerHiddenAttribute>
            Private Shared Function Create__Instance__(Of T As New)(instance As T) As T
                If instance Is Nothing Then
                    Return New T()
                End If

                Return instance
            End Function

            <System.Diagnostics.DebuggerHiddenAttribute>
            Private Sub Dispose__Instance__(Of T)(ByRef instance As T)
                instance = DirectCast(Nothing, T)
            End Sub

            <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)>
            <System.Diagnostics.DebuggerHiddenAttribute>
            Public Sub New()
            End Sub
        End Class

        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)>
        <System.Runtime.InteropServices.ComVisibleAttribute(False)>
        Friend NotInheritable Class ThreadSafeObjectProvider(Of T As New)

            <System.Runtime.CompilerServices.CompilerGeneratedAttribute>
            <System.ThreadStaticAttribute>
            Private Shared m_ThreadStaticValue As T

            Friend ReadOnly Property GetInstance As T
                <System.Diagnostics.DebuggerHiddenAttribute>
                Get
                    If RestaurantPOS14.My.MyProject.ThreadSafeObjectProvider(Of T).m_ThreadStaticValue Is Nothing Then
                        RestaurantPOS14.My.MyProject.ThreadSafeObjectProvider(Of T).m_ThreadStaticValue = New T()
                    End If

                    Return RestaurantPOS14.My.MyProject.ThreadSafeObjectProvider(Of T).m_ThreadStaticValue
                End Get
            End Property

            <System.Diagnostics.DebuggerHiddenAttribute>
            <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)>
            Public Sub New()
            End Sub
        End Class

        Private Shared ReadOnly m_ComputerObjectProvider As RestaurantPOS14.My.MyProject.ThreadSafeObjectProvider(Of RestaurantPOS14.My.MyComputer) = New RestaurantPOS14.My.MyProject.ThreadSafeObjectProvider(Of RestaurantPOS14.My.MyComputer)()

        Private Shared ReadOnly m_AppObjectProvider As RestaurantPOS14.My.MyProject.ThreadSafeObjectProvider(Of RestaurantPOS14.My.MyApplication) = New RestaurantPOS14.My.MyProject.ThreadSafeObjectProvider(Of RestaurantPOS14.My.MyApplication)()

        Private Shared ReadOnly m_UserObjectProvider As RestaurantPOS14.My.MyProject.ThreadSafeObjectProvider(Of Microsoft.VisualBasic.ApplicationServices.User) = New RestaurantPOS14.My.MyProject.ThreadSafeObjectProvider(Of Microsoft.VisualBasic.ApplicationServices.User)()

        Private Shared m_MyFormsObjectProvider As RestaurantPOS14.My.MyProject.ThreadSafeObjectProvider(Of RestaurantPOS14.My.MyProject.MyForms) = New RestaurantPOS14.My.MyProject.ThreadSafeObjectProvider(Of RestaurantPOS14.My.MyProject.MyForms)()

        Private Shared ReadOnly m_MyWebServicesObjectProvider As RestaurantPOS14.My.MyProject.ThreadSafeObjectProvider(Of RestaurantPOS14.My.MyProject.MyWebServices) = New RestaurantPOS14.My.MyProject.ThreadSafeObjectProvider(Of RestaurantPOS14.My.MyProject.MyWebServices)()

        <System.ComponentModel.Design.HelpKeywordAttribute("My.Computer")>
        Friend Shared ReadOnly Property Computer As RestaurantPOS14.My.MyComputer
            <System.Diagnostics.DebuggerHiddenAttribute>
            Get
                Return RestaurantPOS14.My.MyProject.m_ComputerObjectProvider.GetInstance
            End Get
        End Property

        <System.ComponentModel.Design.HelpKeywordAttribute("My.Application")>
        Friend Shared ReadOnly Property Application As RestaurantPOS14.My.MyApplication
            <System.Diagnostics.DebuggerHiddenAttribute>
            Get
                Return RestaurantPOS14.My.MyProject.m_AppObjectProvider.GetInstance
            End Get
        End Property

        <System.ComponentModel.Design.HelpKeywordAttribute("My.User")>
        Friend Shared ReadOnly Property User As Microsoft.VisualBasic.ApplicationServices.User
            <System.Diagnostics.DebuggerHiddenAttribute>
            Get
                Return RestaurantPOS14.My.MyProject.m_UserObjectProvider.GetInstance
            End Get
        End Property

        <System.ComponentModel.Design.HelpKeywordAttribute("My.Forms")>
        Friend Shared ReadOnly Property Forms As RestaurantPOS14.My.MyProject.MyForms
            <System.Diagnostics.DebuggerHiddenAttribute>
            Get
                Return RestaurantPOS14.My.MyProject.m_MyFormsObjectProvider.GetInstance
            End Get
        End Property

        <System.ComponentModel.Design.HelpKeywordAttribute("My.WebServices")>
        Friend Shared ReadOnly Property WebServices As RestaurantPOS14.My.MyProject.MyWebServices
            <System.Diagnostics.DebuggerHiddenAttribute>
            Get
                Return RestaurantPOS14.My.MyProject.m_MyWebServicesObjectProvider.GetInstance
            End Get
        End Property
    End Class
End Namespace
