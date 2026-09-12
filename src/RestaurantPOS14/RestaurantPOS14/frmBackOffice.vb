Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Text
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports CButtonLib
Imports Microsoft.VisualBasic.CompilerServices
Imports RestaurantPOS14.My
Imports Telerik.WinControls.Themes
Imports Telerik.WinControls.UI

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public Class frmBackOffice
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel1")>
        Private _Panel1 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label30")>
        Private _Label30 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label1")>
        Private _Label1 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblUser")>
        Private _lblUser As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnCategories")>
        Private _btnCategories As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnItems")>
        Private _btnItems As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnTables")>
        Private _btnTables As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnRegistration")>
        Private _btnRegistration As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnLogs")>
        Private _btnLogs As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnCancel")>
        Private _btnCancel As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnRestaurantInfo")>
        Private _btnRestaurantInfo As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnPOSReport")>
        Private _btnPOSReport As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("OpenFileDialog1")>
        Private _OpenFileDialog1 As System.Windows.Forms.OpenFileDialog

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Timer2")>
        Private _Timer2 As System.Windows.Forms.Timer

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnMinimize")>
        Private _btnMinimize As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnRecipe")>
        Private _btnRecipe As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnItemStock")>
        Private _btnItemStock As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnEmployeeSession")>
        Private _btnEmployeeSession As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnProduct")>
        Private _btnProduct As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnSupplier")>
        Private _btnSupplier As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnPurchase")>
        Private _btnPurchase As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnPayment")>
        Private _btnPayment As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnAccountingReports")>
        Private _btnAccountingReports As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("BtnVoucher")>
        Private _BtnVoucher As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnKitchen")>
        Private _btnKitchen As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnHomeDelivery")>
        Private _btnHomeDelivery As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnSettings")>
        Private _btnSettings As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnAdvancedSetting")>
        Private _btnAdvancedSetting As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnPayroll")>
        Private _btnPayroll As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnBankReconciliation")>
        Private _btnBankReconciliation As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnStockTransfer_Issue")>
        Private _btnStockTransfer_Issue As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("TableLayoutPanel1")>
        Private _TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnKeyboard")>
        Private _btnKeyboard As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnWorkPeriodReport")>
        Private _btnWorkPeriodReport As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnDatabase")>
        Private _btnDatabase As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnAttendance")>
        Private _btnAttendance As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnMarketingTools")>
        Private _btnMarketingTools As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnPizza")>
        Private _btnPizza As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnCreditCustomer")>
        Private _btnCreditCustomer As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnStockAdjustment")>
        Private _btnStockAdjustment As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnCards")>
        Private _btnCards As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnMenuItemsModifiers")>
        Private _btnMenuItemsModifiers As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnPurchaseOrder")>
        Private _btnPurchaseOrder As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblUserType")>
        Private _lblUserType As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("RadClock1")>
        Private _RadClock1 As Telerik.WinControls.UI.RadClock

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("AquaTheme1")>
        Private _AquaTheme1 As Telerik.WinControls.Themes.AquaTheme

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("TableLayoutPanel3")>
        Private _TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnNotepad")>
        Private _btnNotepad As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnWordpad")>
        Private _btnWordpad As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnCalculator")>
        Private _btnCalculator As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnMSWord")>
        Private _btnMSWord As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnTaskManager")>
        Private _btnTaskManager As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnOSKeyboard")>
        Private _btnOSKeyboard As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnPaint")>
        Private _btnPaint As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnSysInfo")>
        Private _btnSysInfo As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnLogout")>
        Private _btnLogout As CButtonLib.CButton

        Private components As System.ComponentModel.IContainer

        Friend Overridable Property Panel1 As System.Windows.Forms.Panel
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Panel1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Panel)
                Me._Panel1 = value
            End Set
        End Property

        Friend Overridable Property Label30 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label30
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label30 = value
            End Set
        End Property

        Friend Overridable Property Label1 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label1 = value
            End Set
        End Property

        Friend Overridable Property lblUser As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._lblUser
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._lblUser = value
            End Set
        End Property

        Friend Overridable Property btnCategories As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnCategories
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnCategories_Click
                If Me._btnCategories IsNot Nothing Then
                    RemoveHandler Me._btnCategories.Click, value2
                End If

                Me._btnCategories = value
                If Me._btnCategories IsNot Nothing Then
                    AddHandler Me._btnCategories.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnItems As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnItems
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnItems_Click
                If Me._btnItems IsNot Nothing Then
                    RemoveHandler Me._btnItems.Click, value2
                End If

                Me._btnItems = value
                If Me._btnItems IsNot Nothing Then
                    AddHandler Me._btnItems.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnTables As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnTables
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnTables_Click
                If Me._btnTables IsNot Nothing Then
                    RemoveHandler Me._btnTables.Click, value2
                End If

                Me._btnTables = value
                If Me._btnTables IsNot Nothing Then
                    AddHandler Me._btnTables.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnRegistration As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnRegistration
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnRegistration_Click
                If Me._btnRegistration IsNot Nothing Then
                    RemoveHandler Me._btnRegistration.Click, value2
                End If

                Me._btnRegistration = value
                If Me._btnRegistration IsNot Nothing Then
                    AddHandler Me._btnRegistration.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnLogs As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnLogs
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnLogs_Click
                If Me._btnLogs IsNot Nothing Then
                    RemoveHandler Me._btnLogs.Click, value2
                End If

                Me._btnLogs = value
                If Me._btnLogs IsNot Nothing Then
                    AddHandler Me._btnLogs.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnCancel As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnCancel
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.Cancel_Click
                If Me._btnCancel IsNot Nothing Then
                    RemoveHandler Me._btnCancel.Click, value2
                End If

                Me._btnCancel = value
                If Me._btnCancel IsNot Nothing Then
                    AddHandler Me._btnCancel.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnRestaurantInfo As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnRestaurantInfo
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnRestaurantInfo_Click
                If Me._btnRestaurantInfo IsNot Nothing Then
                    RemoveHandler Me._btnRestaurantInfo.Click, value2
                End If

                Me._btnRestaurantInfo = value
                If Me._btnRestaurantInfo IsNot Nothing Then
                    AddHandler Me._btnRestaurantInfo.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnPOSReport As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnPOSReport
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnPOSReport_Click
                If Me._btnPOSReport IsNot Nothing Then
                    RemoveHandler Me._btnPOSReport.Click, value2
                End If

                Me._btnPOSReport = value
                If Me._btnPOSReport IsNot Nothing Then
                    AddHandler Me._btnPOSReport.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._OpenFileDialog1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.OpenFileDialog)
                Me._OpenFileDialog1 = value
            End Set
        End Property

        Friend Overridable Property Timer2 As System.Windows.Forms.Timer
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Timer2
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Timer)
                Dim value2 As System.EventHandler = AddressOf Me.Timer2_Tick
                If Me._Timer2 IsNot Nothing Then
                    RemoveHandler Me._Timer2.Tick, value2
                End If

                Me._Timer2 = value
                If Me._Timer2 IsNot Nothing Then
                    AddHandler Me._Timer2.Tick, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnMinimize As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnMinimize
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnMinimize_Click
                If Me._btnMinimize IsNot Nothing Then
                    RemoveHandler Me._btnMinimize.Click, value2
                End If

                Me._btnMinimize = value
                If Me._btnMinimize IsNot Nothing Then
                    AddHandler Me._btnMinimize.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnRecipe As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnRecipe
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnRecipe_Click
                If Me._btnRecipe IsNot Nothing Then
                    RemoveHandler Me._btnRecipe.Click, value2
                End If

                Me._btnRecipe = value
                If Me._btnRecipe IsNot Nothing Then
                    AddHandler Me._btnRecipe.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnItemStock As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnItemStock
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnItemStock_Click
                If Me._btnItemStock IsNot Nothing Then
                    RemoveHandler Me._btnItemStock.Click, value2
                End If

                Me._btnItemStock = value
                If Me._btnItemStock IsNot Nothing Then
                    AddHandler Me._btnItemStock.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnEmployeeSession As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnEmployeeSession
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnEmployeeSession_Click
                If Me._btnEmployeeSession IsNot Nothing Then
                    RemoveHandler Me._btnEmployeeSession.Click, value2
                End If

                Me._btnEmployeeSession = value
                If Me._btnEmployeeSession IsNot Nothing Then
                    AddHandler Me._btnEmployeeSession.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnProduct As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnProduct
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnProduct_Click
                If Me._btnProduct IsNot Nothing Then
                    RemoveHandler Me._btnProduct.Click, value2
                End If

                Me._btnProduct = value
                If Me._btnProduct IsNot Nothing Then
                    AddHandler Me._btnProduct.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnSupplier As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnSupplier
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnSupplier_Click
                If Me._btnSupplier IsNot Nothing Then
                    RemoveHandler Me._btnSupplier.Click, value2
                End If

                Me._btnSupplier = value
                If Me._btnSupplier IsNot Nothing Then
                    AddHandler Me._btnSupplier.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnPurchase As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnPurchase
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnPurchase_Click
                If Me._btnPurchase IsNot Nothing Then
                    RemoveHandler Me._btnPurchase.Click, value2
                End If

                Me._btnPurchase = value
                If Me._btnPurchase IsNot Nothing Then
                    AddHandler Me._btnPurchase.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnPayment As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnPayment
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnPayment_Click
                If Me._btnPayment IsNot Nothing Then
                    RemoveHandler Me._btnPayment.Click, value2
                End If

                Me._btnPayment = value
                If Me._btnPayment IsNot Nothing Then
                    AddHandler Me._btnPayment.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnAccountingReports As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnAccountingReports
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnAccountingReports_Click
                If Me._btnAccountingReports IsNot Nothing Then
                    RemoveHandler Me._btnAccountingReports.Click, value2
                End If

                Me._btnAccountingReports = value
                If Me._btnAccountingReports IsNot Nothing Then
                    AddHandler Me._btnAccountingReports.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property BtnVoucher As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._BtnVoucher
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.BtnVoucher_Click
                If Me._BtnVoucher IsNot Nothing Then
                    RemoveHandler Me._BtnVoucher.Click, value2
                End If

                Me._BtnVoucher = value
                If Me._BtnVoucher IsNot Nothing Then
                    AddHandler Me._BtnVoucher.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnKitchen As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnKitchen
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnKitchen_Click
                If Me._btnKitchen IsNot Nothing Then
                    RemoveHandler Me._btnKitchen.Click, value2
                End If

                Me._btnKitchen = value
                If Me._btnKitchen IsNot Nothing Then
                    AddHandler Me._btnKitchen.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnHomeDelivery As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnHomeDelivery
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnDeliveryPerson_Click
                If Me._btnHomeDelivery IsNot Nothing Then
                    RemoveHandler Me._btnHomeDelivery.Click, value2
                End If

                Me._btnHomeDelivery = value
                If Me._btnHomeDelivery IsNot Nothing Then
                    AddHandler Me._btnHomeDelivery.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnSettings As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnSettings
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnOtherCharges_Click
                If Me._btnSettings IsNot Nothing Then
                    RemoveHandler Me._btnSettings.Click, value2
                End If

                Me._btnSettings = value
                If Me._btnSettings IsNot Nothing Then
                    AddHandler Me._btnSettings.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnAdvancedSetting As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnAdvancedSetting
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnAdvancedSetting_Click
                If Me._btnAdvancedSetting IsNot Nothing Then
                    RemoveHandler Me._btnAdvancedSetting.Click, value2
                End If

                Me._btnAdvancedSetting = value
                If Me._btnAdvancedSetting IsNot Nothing Then
                    AddHandler Me._btnAdvancedSetting.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnPayroll As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnPayroll
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnPayroll_Click
                If Me._btnPayroll IsNot Nothing Then
                    RemoveHandler Me._btnPayroll.Click, value2
                End If

                Me._btnPayroll = value
                If Me._btnPayroll IsNot Nothing Then
                    AddHandler Me._btnPayroll.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnBankReconciliation As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnBankReconciliation
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnBankReconciliation_Click
                If Me._btnBankReconciliation IsNot Nothing Then
                    RemoveHandler Me._btnBankReconciliation.Click, value2
                End If

                Me._btnBankReconciliation = value
                If Me._btnBankReconciliation IsNot Nothing Then
                    AddHandler Me._btnBankReconciliation.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnStockTransfer_Issue As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnStockTransfer_Issue
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnStockTransfer_Issue_Click
                If Me._btnStockTransfer_Issue IsNot Nothing Then
                    RemoveHandler Me._btnStockTransfer_Issue.Click, value2
                End If

                Me._btnStockTransfer_Issue = value
                If Me._btnStockTransfer_Issue IsNot Nothing Then
                    AddHandler Me._btnStockTransfer_Issue.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._TableLayoutPanel1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TableLayoutPanel)
                Me._TableLayoutPanel1 = value
            End Set
        End Property

        Friend Overridable Property btnKeyboard As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnKeyboard
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnKeyboard_Click
                If Me._btnKeyboard IsNot Nothing Then
                    RemoveHandler Me._btnKeyboard.Click, value2
                End If

                Me._btnKeyboard = value
                If Me._btnKeyboard IsNot Nothing Then
                    AddHandler Me._btnKeyboard.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnWorkPeriodReport As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnWorkPeriodReport
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnWorkPeriodReport_Click
                If Me._btnWorkPeriodReport IsNot Nothing Then
                    RemoveHandler Me._btnWorkPeriodReport.Click, value2
                End If

                Me._btnWorkPeriodReport = value
                If Me._btnWorkPeriodReport IsNot Nothing Then
                    AddHandler Me._btnWorkPeriodReport.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnDatabase As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnDatabase
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnDatabase_Click
                If Me._btnDatabase IsNot Nothing Then
                    RemoveHandler Me._btnDatabase.Click, value2
                End If

                Me._btnDatabase = value
                If Me._btnDatabase IsNot Nothing Then
                    AddHandler Me._btnDatabase.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnAttendance As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnAttendance
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnAttendance_Click
                If Me._btnAttendance IsNot Nothing Then
                    RemoveHandler Me._btnAttendance.Click, value2
                End If

                Me._btnAttendance = value
                If Me._btnAttendance IsNot Nothing Then
                    AddHandler Me._btnAttendance.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnMarketingTools As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnMarketingTools
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnMarketingTools_Click
                If Me._btnMarketingTools IsNot Nothing Then
                    RemoveHandler Me._btnMarketingTools.Click, value2
                End If

                Me._btnMarketingTools = value
                If Me._btnMarketingTools IsNot Nothing Then
                    AddHandler Me._btnMarketingTools.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnPizza As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnPizza
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnPizza_Click
                If Me._btnPizza IsNot Nothing Then
                    RemoveHandler Me._btnPizza.Click, value2
                End If

                Me._btnPizza = value
                If Me._btnPizza IsNot Nothing Then
                    AddHandler Me._btnPizza.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnCreditCustomer As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnCreditCustomer
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnCreditCustomer_Click
                If Me._btnCreditCustomer IsNot Nothing Then
                    RemoveHandler Me._btnCreditCustomer.Click, value2
                End If

                Me._btnCreditCustomer = value
                If Me._btnCreditCustomer IsNot Nothing Then
                    AddHandler Me._btnCreditCustomer.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnStockAdjustment As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnStockAdjustment
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnStockAdjustment_Click
                If Me._btnStockAdjustment IsNot Nothing Then
                    RemoveHandler Me._btnStockAdjustment.Click, value2
                End If

                Me._btnStockAdjustment = value
                If Me._btnStockAdjustment IsNot Nothing Then
                    AddHandler Me._btnStockAdjustment.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnCards As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnCards
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnCards_Click
                If Me._btnCards IsNot Nothing Then
                    RemoveHandler Me._btnCards.Click, value2
                End If

                Me._btnCards = value
                If Me._btnCards IsNot Nothing Then
                    AddHandler Me._btnCards.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnMenuItemsModifiers As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnMenuItemsModifiers
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnMenuItemsModifiers_Click
                If Me._btnMenuItemsModifiers IsNot Nothing Then
                    RemoveHandler Me._btnMenuItemsModifiers.Click, value2
                End If

                Me._btnMenuItemsModifiers = value
                If Me._btnMenuItemsModifiers IsNot Nothing Then
                    AddHandler Me._btnMenuItemsModifiers.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnPurchaseOrder As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnPurchaseOrder
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnPurchaseOrder_Click
                If Me._btnPurchaseOrder IsNot Nothing Then
                    RemoveHandler Me._btnPurchaseOrder.Click, value2
                End If

                Me._btnPurchaseOrder = value
                If Me._btnPurchaseOrder IsNot Nothing Then
                    AddHandler Me._btnPurchaseOrder.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property lblUserType As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._lblUserType
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._lblUserType = value
            End Set
        End Property

        Friend Overridable Property RadClock1 As Telerik.WinControls.UI.RadClock
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._RadClock1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As Telerik.WinControls.UI.RadClock)
                Me._RadClock1 = value
            End Set
        End Property

        Friend Overridable Property AquaTheme1 As Telerik.WinControls.Themes.AquaTheme
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._AquaTheme1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As Telerik.WinControls.Themes.AquaTheme)
                Me._AquaTheme1 = value
            End Set
        End Property

        Friend Overridable Property TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._TableLayoutPanel3
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TableLayoutPanel)
                Me._TableLayoutPanel3 = value
            End Set
        End Property

        Friend Overridable Property btnNotepad As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnNotepad
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim obj As CButtonLib.CButton.ClickButtonAreaEventHandler = AddressOf Me.btnNotepad_ClickButtonArea
                If Me._btnNotepad IsNot Nothing Then
                    RemoveHandler Me._btnNotepad.ClickButtonArea, obj
                End If

                Me._btnNotepad = value
                If Me._btnNotepad IsNot Nothing Then
                    AddHandler Me._btnNotepad.ClickButtonArea, obj
                End If
            End Set
        End Property

        Friend Overridable Property btnWordpad As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnWordpad
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim obj As CButtonLib.CButton.ClickButtonAreaEventHandler = AddressOf Me.btnWordpad_ClickButtonArea
                If Me._btnWordpad IsNot Nothing Then
                    RemoveHandler Me._btnWordpad.ClickButtonArea, obj
                End If

                Me._btnWordpad = value
                If Me._btnWordpad IsNot Nothing Then
                    AddHandler Me._btnWordpad.ClickButtonArea, obj
                End If
            End Set
        End Property

        Friend Overridable Property btnCalculator As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnCalculator
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim obj As CButtonLib.CButton.ClickButtonAreaEventHandler = AddressOf Me.btnCalculator_ClickButtonArea
                If Me._btnCalculator IsNot Nothing Then
                    RemoveHandler Me._btnCalculator.ClickButtonArea, obj
                End If

                Me._btnCalculator = value
                If Me._btnCalculator IsNot Nothing Then
                    AddHandler Me._btnCalculator.ClickButtonArea, obj
                End If
            End Set
        End Property

        Friend Overridable Property btnMSWord As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnMSWord
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim obj As CButtonLib.CButton.ClickButtonAreaEventHandler = AddressOf Me.btnMSWord_ClickButtonArea
                If Me._btnMSWord IsNot Nothing Then
                    RemoveHandler Me._btnMSWord.ClickButtonArea, obj
                End If

                Me._btnMSWord = value
                If Me._btnMSWord IsNot Nothing Then
                    AddHandler Me._btnMSWord.ClickButtonArea, obj
                End If
            End Set
        End Property

        Friend Overridable Property btnTaskManager As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnTaskManager
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim obj As CButtonLib.CButton.ClickButtonAreaEventHandler = AddressOf Me.btnTaskManager_ClickButtonArea
                If Me._btnTaskManager IsNot Nothing Then
                    RemoveHandler Me._btnTaskManager.ClickButtonArea, obj
                End If

                Me._btnTaskManager = value
                If Me._btnTaskManager IsNot Nothing Then
                    AddHandler Me._btnTaskManager.ClickButtonArea, obj
                End If
            End Set
        End Property

        Friend Overridable Property btnOSKeyboard As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnOSKeyboard
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim obj As CButtonLib.CButton.ClickButtonAreaEventHandler = AddressOf Me.btnOSKeyboard_ClickButtonArea
                If Me._btnOSKeyboard IsNot Nothing Then
                    RemoveHandler Me._btnOSKeyboard.ClickButtonArea, obj
                End If

                Me._btnOSKeyboard = value
                If Me._btnOSKeyboard IsNot Nothing Then
                    AddHandler Me._btnOSKeyboard.ClickButtonArea, obj
                End If
            End Set
        End Property

        Friend Overridable Property btnPaint As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnPaint
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim obj As CButtonLib.CButton.ClickButtonAreaEventHandler = AddressOf Me.btnPaint_ClickButtonArea
                If Me._btnPaint IsNot Nothing Then
                    RemoveHandler Me._btnPaint.ClickButtonArea, obj
                End If

                Me._btnPaint = value
                If Me._btnPaint IsNot Nothing Then
                    AddHandler Me._btnPaint.ClickButtonArea, obj
                End If
            End Set
        End Property

        Friend Overridable Property btnSysInfo As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnSysInfo
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim obj As CButtonLib.CButton.ClickButtonAreaEventHandler = AddressOf Me.btnSysInfo_ClickButtonArea
                If Me._btnSysInfo IsNot Nothing Then
                    RemoveHandler Me._btnSysInfo.ClickButtonArea, obj
                End If

                Me._btnSysInfo = value
                If Me._btnSysInfo IsNot Nothing Then
                    AddHandler Me._btnSysInfo.ClickButtonArea, obj
                End If
            End Set
        End Property

        Friend Overridable Property btnLogout As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnLogout
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim obj As CButtonLib.CButton.ClickButtonAreaEventHandler = AddressOf Me.btnLogout_ClickButtonArea
                If Me._btnLogout IsNot Nothing Then
                    RemoveHandler Me._btnLogout.ClickButtonArea, obj
                End If

                Me._btnLogout = value
                If Me._btnLogout IsNot Nothing Then
                    AddHandler Me._btnLogout.ClickButtonArea, obj
                End If
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            AddHandler MyBase.Load, AddressOf Me.frmBackOffice_Load
            Call RestaurantPOS14.frmBackOffice.__ENCAddToList(Me)
            Me.InitializeComponent()
            Me._btnPizza.Visible = False
            Me._btnPizza.Enabled = False
            Me._btnPizza.Text = ""
            Me._btnPizza.Visible = False
            Me._btnPizza.Enabled = False
            Me._btnPizza.Text = ""
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmBackOffice.__ENCList
                If RestaurantPOS14.frmBackOffice.__ENCList.Count = RestaurantPOS14.frmBackOffice.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmBackOffice.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmBackOffice.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmBackOffice.__ENCList(num) = RestaurantPOS14.frmBackOffice.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmBackOffice.__ENCList.RemoveRange(num, RestaurantPOS14.frmBackOffice.__ENCList.Count - num)
                    RestaurantPOS14.frmBackOffice.__ENCList.Capacity = RestaurantPOS14.frmBackOffice.__ENCList.Count
                End If

                Call RestaurantPOS14.frmBackOffice.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Private Sub btnCategories_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmMenuItemsCategory.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmMenuItemsCategory.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmMenuItemsCategory.ShowDialog()
        End Sub

        Private Sub btnItems_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmMenuItem.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmMenuItem.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmMenuItem.ShowDialog()
        End Sub

        Private Sub btnTables_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmTable.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmTable.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmTable.ShowDialog()
        End Sub

        Private Sub btnRegistration_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmRegistration.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmRegistration.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmRegistration.ShowDialog()
        End Sub

        Private Sub btnLogs_Click(sender As Object, e As System.EventArgs)
            Call RestaurantPOS14.My.MyProject.Forms.frmLogs.Reset()
            RestaurantPOS14.My.MyProject.Forms.frmLogs.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmLogs.ShowDialog()
        End Sub

        Private Sub btnRestaurantInfo_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmRestaurantMaster.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmRestaurantMaster.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmRestaurantMaster.ShowDialog()
        End Sub

        Private Sub btnPOSReport_Click(sender As Object, e As System.EventArgs)
            Call RestaurantPOS14.My.MyProject.Forms.frmPOSReport.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmPOSReport.ShowDialog()
        End Sub

        Private Sub Timer2_Tick(sender As Object, e As System.EventArgs)
            MyBase.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.Timer2.Enabled = False
        End Sub

        Private Sub Cancel_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmCustomDialog17.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmCustomDialog17.ShowDialog()
        End Sub

        Private Sub btnMinimize_Click(sender As Object, e As System.EventArgs)
            MyBase.WindowState = System.Windows.Forms.FormWindowState.Minimized
        End Sub

        Private Sub btnProduct_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmProduct.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmProduct.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmProduct.ShowDialog()
        End Sub

        Private Sub btnSupplier_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmSupplier.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmSupplier.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmSupplier.ShowDialog()
        End Sub

        Private Sub btnPurchase_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmPurchaseEntry.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmPurchaseEntry.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmPurchaseEntry.ShowDialog()
        End Sub

        Private Sub btnPayment_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmPayment.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmPayment.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmPayment.ShowDialog()
        End Sub

        Private Sub BtnVoucher_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmVoucher.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmVoucher.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmVoucher.ShowDialog()
        End Sub

        Private Sub btnAccountingReports_Click(sender As Object, e As System.EventArgs)
            Call RestaurantPOS14.My.MyProject.Forms.frmAccountingReport.Reset()
            RestaurantPOS14.My.MyProject.Forms.frmAccountingReport.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmAccountingReport.ShowDialog()
        End Sub

        Private Sub btnKitchen_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmKitchen_Section.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmKitchen_Section.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmKitchen_Section.ShowDialog()
        End Sub

        Private Sub btnDeliveryPerson_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmHomeDelivery.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmHomeDelivery.ShowDialog()
        End Sub

        Private Sub btnOtherCharges_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmSettings.lblUser.Text = Me.lblUser.Text
            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblUserType.Text, "Super Admin", TextCompare:=False) = 0 Then
                RestaurantPOS14.My.MyProject.Forms.frmSettings.btnWorkPeriod.Enabled = True
            Else
                RestaurantPOS14.My.MyProject.Forms.frmSettings.btnWorkPeriod.Enabled = False
            End If

            If(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblUser.Text, "sa", TextCompare:=False) = 0) Or (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblUser.Text, "SA", TextCompare:=False) = 0) Then
                RestaurantPOS14.My.MyProject.Forms.frmSettings.btnUserRights.Enabled = True
            Else
                RestaurantPOS14.My.MyProject.Forms.frmSettings.btnUserRights.Enabled = False
            End If

            Call RestaurantPOS14.My.MyProject.Forms.frmSettings.ShowDialog()
        End Sub

        Private Sub btnAdvancedSetting_Click(sender As Object, e As System.EventArgs)
            Dim obj As RestaurantPOS14.frmAdvancedSettings = New RestaurantPOS14.frmAdvancedSettings()
            obj.lblUser.Text = Me.lblUser.Text
            obj.Reset()
            obj.ShowDialog()
        End Sub

        Private Sub btnStockTransfer_Issue_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmStockTransfer.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmStockTransfer.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmStockTransfer.ShowDialog()
        End Sub

        Private Sub btnKeyboard_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.ModFunc.OSKeyboard()
        End Sub

        Private Sub btnRecipe_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmRecipe.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmRecipe.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmRecipe.ShowDialog()
        End Sub

        Private Sub btnItemStock_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmStock_Store.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmStock_Store.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmStock_Store.ShowDialog()
        End Sub

        Private Sub btnAbout_Click(sender As Object, e As System.EventArgs)
            Call RestaurantPOS14.My.MyProject.Forms.frmAbout.ShowDialog()
        End Sub

        Private Sub btnWorkPeriodReport_Click(sender As Object, e As System.EventArgs)
            Call RestaurantPOS14.My.MyProject.Forms.frmWorkPeriodReport.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmWorkPeriodReport.ShowDialog()
        End Sub

        Private Sub btnDatabase_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmDatabase.lblUser.Text = Me.lblUser.Text
            If RestaurantPOS14.ModFunc.IsSaveAllowed(Me.lblUser.Text, "Database") Then
                RestaurantPOS14.My.MyProject.Forms.frmDatabase.btnDBBackup.Enabled = True
            Else
                RestaurantPOS14.My.MyProject.Forms.frmDatabase.btnDBBackup.Enabled = False
            End If

            If RestaurantPOS14.ModFunc.IsUpdateAllowed(Me.lblUser.Text, "Database") Then
                RestaurantPOS14.My.MyProject.Forms.frmDatabase.btnDBRestore.Enabled = True
            Else
                RestaurantPOS14.My.MyProject.Forms.frmDatabase.btnDBRestore.Enabled = False
            End If

            Call RestaurantPOS14.My.MyProject.Forms.frmDatabase.ShowDialog()
        End Sub

        Private Sub btnPizza_Click(sender As Object, e As System.EventArgs)
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT * from Category where CategoryName='ZZ_DISABLED_PIZZA'")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If Not RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call RestaurantPOS14.My.MyProject.Forms.frmCustomDialog19.ShowDialog()
                    Return
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.My.MyProject.Forms.frmPizza.lblUser.Text = Me.lblUser.Text
                Call RestaurantPOS14.My.MyProject.Forms.frmPizza.ShowDialog()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnCreditCustomer_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmCreditCustomer.lblUser.Text = Me.lblUser.Text
            If RestaurantPOS14.ModFunc.IsViewAllowed(Me.lblUser.Text, "Credit Customer") Then
                RestaurantPOS14.My.MyProject.Forms.frmCreditCustomer.btnCustomerLedger.Enabled = True
            Else
                RestaurantPOS14.My.MyProject.Forms.frmCreditCustomer.btnCustomerLedger.Enabled = False
            End If

            Call RestaurantPOS14.My.MyProject.Forms.frmCreditCustomer.ShowDialog()
        End Sub

        Private Sub btnPurchaseOrder_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmPurchaseOrder.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmPurchaseOrder.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmPurchaseOrder.ShowDialog()
        End Sub

        Private Sub btnMenuItemsModifiers_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmMenuItemsModifiers.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmMenuItemsModifiers.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmMenuItemsModifiers.ShowDialog()
        End Sub

        Private Sub btnStockAdjustment_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmStockAdjustment.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmStockAdjustment.ShowDialog()
        End Sub

        Private Sub btnCards_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmCards.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmCards.ShowDialog()
        End Sub

        Private Sub btnEmployeeSession_Click(sender As Object, e As System.EventArgs)
            Call RestaurantPOS14.My.MyProject.Forms.frmEmployeeSession.Reset()
            RestaurantPOS14.My.MyProject.Forms.frmEmployeeSession.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmEmployeeSession.ShowDialog()
        End Sub

        Private Sub btnBankReconciliation_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmBankReconciliation.lblUser.Text = Me.lblUser.Text
            If RestaurantPOS14.ModFunc.IsViewAllowed(Me.lblUser.Text, "Banking") Then
                RestaurantPOS14.My.MyProject.Forms.frmBankReconciliation.btnBankAccountStatements.Enabled = True
            Else
                RestaurantPOS14.My.MyProject.Forms.frmBankReconciliation.btnBankAccountStatements.Enabled = False
            End If

            Call RestaurantPOS14.My.MyProject.Forms.frmBankReconciliation.ShowDialog()
        End Sub

        Private Sub btnPayroll_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmPayroll.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmPayroll.ShowDialog()
        End Sub

        Private Sub btnMarketingTools_Click(sender As Object, e As System.EventArgs)
            If RestaurantPOS14.ModFunc.IsSaveAllowed(Me.lblUser.Text, "Send SMS") Then
                RestaurantPOS14.My.MyProject.Forms.frmMarketingTools.btnSendSMS.Enabled = True
            Else
                RestaurantPOS14.My.MyProject.Forms.frmMarketingTools.btnSendSMS.Enabled = False
            End If

            If RestaurantPOS14.ModFunc.IsSaveAllowed(Me.lblUser.Text, "Send Email") Then
                RestaurantPOS14.My.MyProject.Forms.frmMarketingTools.btnSendEmail.Enabled = True
            Else
                RestaurantPOS14.My.MyProject.Forms.frmMarketingTools.btnSendEmail.Enabled = False
            End If

            Call RestaurantPOS14.My.MyProject.Forms.frmMarketingTools.ShowDialog()
        End Sub

        Private Sub btnAttendance_Click(sender As Object, e As System.EventArgs)
            Call RestaurantPOS14.My.MyProject.Forms.frmAttendance.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmAttendance.ShowDialog()
        End Sub

        Private Sub frmBackOffice_Load(sender As Object, e As System.EventArgs)
            Dim tableLayoutPanel As System.Windows.Forms.TableLayoutPanel = Me.TableLayoutPanel1
            Dim location As System.Drawing.Point = New System.Drawing.Point(CInt(System.Math.Round(CDbl(MyBase.ClientSize.Width) / 2.0 - CDbl(Me.TableLayoutPanel1.Size.Width) / 2.0)), CInt(System.Math.Round(CDbl(MyBase.ClientSize.Height) / 2.0 - CDbl(Me.TableLayoutPanel1.Size.Height) / 2.0)))
            tableLayoutPanel.Location = location
            Me.TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None
        End Sub

        Private Sub btnLogout_ClickButtonArea(Sender As Object, e As System.Windows.Forms.MouseEventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmCustomDialog17.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmCustomDialog17.ShowDialog()
        End Sub

        Private Sub btnNotepad_ClickButtonArea(Sender As Object, e As System.Windows.Forms.MouseEventArgs)
            RestaurantPOS14.Security.ExternalResourceGuard.StartTrustedWindowsApplication("Notepad.exe", "Notepad")
        End Sub

        Private Sub btnWordpad_ClickButtonArea(Sender As Object, e As System.Windows.Forms.MouseEventArgs)
            RestaurantPOS14.Security.ExternalResourceGuard.StartTrustedWindowsApplication("wordpad.exe", "WordPad")
        End Sub

        Private Sub btnCalculator_ClickButtonArea(Sender As Object, e As System.Windows.Forms.MouseEventArgs)
            RestaurantPOS14.Security.ExternalResourceGuard.StartTrustedWindowsApplication("Calc.exe", "Calculator")
        End Sub

        Private Sub btnMSWord_ClickButtonArea(Sender As Object, e As System.Windows.Forms.MouseEventArgs)
            RestaurantPOS14.Security.ExternalResourceGuard.StartTrustedWindowsApplication("WinWord.exe", "Microsoft Word")
        End Sub

        Private Sub btnPaint_ClickButtonArea(Sender As Object, e As System.Windows.Forms.MouseEventArgs)
            RestaurantPOS14.Security.ExternalResourceGuard.StartTrustedWindowsApplication("MsPaint.exe", "Paint")
        End Sub

        Private Sub btnOSKeyboard_ClickButtonArea(Sender As Object, e As System.Windows.Forms.MouseEventArgs)
            RestaurantPOS14.ModFunc.OSKeyboard()
        End Sub

        Private Sub btnSysInfo_ClickButtonArea(Sender As Object, e As System.Windows.Forms.MouseEventArgs)
            Call RestaurantPOS14.My.MyProject.Forms.frmSystemInfo.ShowDialog()
        End Sub

        Private Sub btnTaskManager_ClickButtonArea(Sender As Object, e As System.Windows.Forms.MouseEventArgs)
            RestaurantPOS14.Security.ExternalResourceGuard.StartTrustedWindowsApplication("TaskMgr.exe", "Task Manager")
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Protected Overrides Sub Dispose(disposing As Boolean)
            Try
                If disposing AndAlso Me.components IsNot Nothing Then
                    Me.components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        <System.Diagnostics.DebuggerStepThroughAttribute>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim cBlendItems As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmBackOffice))
            Dim cBlendItems2 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems3 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems4 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems5 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems6 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems7 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems8 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems9 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems10 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems11 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems12 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems13 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems14 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems15 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems16 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems17 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems18 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems19 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems20 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems21 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems22 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems23 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems24 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems25 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems26 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems27 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems28 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems29 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems30 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems31 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems32 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems33 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems34 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems35 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems36 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems37 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems38 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems39 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems40 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems41 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems42 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems43 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems44 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Label30 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.lblUser = New System.Windows.Forms.Label()
            Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
            Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
            Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.btnRestaurantInfo = New CButtonLib.CButton()
            Me.btnSettings = New CButtonLib.CButton()
            Me.btnDatabase = New CButtonLib.CButton()
            Me.btnKitchen = New CButtonLib.CButton()
            Me.btnCategories = New CButtonLib.CButton()
            Me.btnItems = New CButtonLib.CButton()
            Me.btnMenuItemsModifiers = New CButtonLib.CButton()
            Me.btnPizza = New CButtonLib.CButton()
            Me.btnItemStock = New CButtonLib.CButton()
            Me.btnCards = New CButtonLib.CButton()
            Me.btnTables = New CButtonLib.CButton()
            Me.btnWorkPeriodReport = New CButtonLib.CButton()
            Me.btnPayroll = New CButtonLib.CButton()
            Me.btnPOSReport = New CButtonLib.CButton()
            Me.btnAccountingReports = New CButtonLib.CButton()
            Me.btnEmployeeSession = New CButtonLib.CButton()
            Me.btnRegistration = New CButtonLib.CButton()
            Me.btnLogs = New CButtonLib.CButton()
            Me.btnAttendance = New CButtonLib.CButton()
            Me.btnMarketingTools = New CButtonLib.CButton()
            Me.btnCreditCustomer = New CButtonLib.CButton()
            Me.btnSupplier = New CButtonLib.CButton()
            Me.btnProduct = New CButtonLib.CButton()
            Me.btnPurchaseOrder = New CButtonLib.CButton()
            Me.btnPurchase = New CButtonLib.CButton()
            Me.btnPayment = New CButtonLib.CButton()
            Me.btnBankReconciliation = New CButtonLib.CButton()
            Me.btnStockTransfer_Issue = New CButtonLib.CButton()
            Me.btnStockAdjustment = New CButtonLib.CButton()
            Me.BtnVoucher = New CButtonLib.CButton()
            Me.btnRecipe = New CButtonLib.CButton()
            Me.btnHomeDelivery = New CButtonLib.CButton()
            Me.btnAdvancedSetting = New CButtonLib.CButton()
            Me.btnKeyboard = New CButtonLib.CButton()
            Me.btnMinimize = New CButtonLib.CButton()
            Me.btnCancel = New CButtonLib.CButton()
            Me.lblUserType = New System.Windows.Forms.Label()
            Me.RadClock1 = New Telerik.WinControls.UI.RadClock()
            Me.AquaTheme1 = New Telerik.WinControls.Themes.AquaTheme()
            Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
            Me.btnNotepad = New CButtonLib.CButton()
            Me.btnWordpad = New CButtonLib.CButton()
            Me.btnCalculator = New CButtonLib.CButton()
            Me.btnMSWord = New CButtonLib.CButton()
            Me.btnTaskManager = New CButtonLib.CButton()
            Me.btnOSKeyboard = New CButtonLib.CButton()
            Me.btnPaint = New CButtonLib.CButton()
            Me.btnSysInfo = New CButtonLib.CButton()
            Me.btnLogout = New CButtonLib.CButton()
            Me.Panel1.SuspendLayout()
            Me.TableLayoutPanel1.SuspendLayout()
            CType(Me.RadClock1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TableLayoutPanel3.SuspendLayout()
            MyBase.SuspendLayout()
            Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.Panel1.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Panel1.Controls.Add(Me.Label30)
            Me.Panel1.Controls.Add(Me.Label1)
            Me.Panel1.Controls.Add(Me.lblUser)
            Dim panel As System.Windows.Forms.Panel = Me.Panel1
            Dim location As System.Drawing.Point = New System.Drawing.Point(1, 1)
            panel.Location = location
            Me.Panel1.Name = "Panel1"
            Dim panel2 As System.Windows.Forms.Panel = Me.Panel1
            Dim size As System.Drawing.Size = New System.Drawing.Size(743, 49)
            panel2.Size = size
            Me.Panel1.TabIndex = 3
            Me.Label30.BackColor = System.Drawing.Color.Transparent
            Me.Label30.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label30.ForeColor = System.Drawing.Color.White
            Dim label As System.Windows.Forms.Label = Me.Label30
            location = New System.Drawing.Point(339, 5)
            label.Location = location
            Me.Label30.Name = "Label30"
            Dim label2 As System.Windows.Forms.Label = Me.Label30
            size = New System.Drawing.Size(178, 37)
            label2.Size = size
            Me.Label30.TabIndex = 321
            Me.Label30.Text = "Operator ID :"
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label1.ForeColor = System.Drawing.Color.White
            Dim label3 As System.Windows.Forms.Label = Me.Label1
            location = New System.Drawing.Point(3, 5)
            label3.Location = location
            Me.Label1.Name = "Label1"
            Dim label4 As System.Windows.Forms.Label = Me.Label1
            size = New System.Drawing.Size(153, 37)
            label4.Size = size
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Back Office"
            Me.lblUser.AutoSize = True
            Me.lblUser.BackColor = System.Drawing.Color.Transparent
            Me.lblUser.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.lblUser.ForeColor = System.Drawing.Color.White
            Dim label5 As System.Windows.Forms.Label = Me.lblUser
            location = New System.Drawing.Point(512, 5)
            label5.Location = location
            Me.lblUser.Name = "lblUser"
            Dim label6 As System.Windows.Forms.Label = Me.lblUser
            size = New System.Drawing.Size(102, 37)
            label6.Size = size
            Me.lblUser.TabIndex = 320
            Me.lblUser.Text = "lblUser"
            Me.OpenFileDialog1.FileName = "OpenFileDialog1"
            Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
            Me.TableLayoutPanel1.ColumnCount = 4
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F))
            Me.TableLayoutPanel1.Controls.Add(Me.btnRestaurantInfo, 0, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.btnSettings, 1, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.btnDatabase, 2, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.btnKitchen, 3, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.btnCategories, 0, 1)
            Me.TableLayoutPanel1.Controls.Add(Me.btnItems, 1, 1)
            Me.TableLayoutPanel1.Controls.Add(Me.btnMenuItemsModifiers, 2, 1)
            Me.TableLayoutPanel1.Controls.Add(Me.btnPizza, 3, 1)
            Me.TableLayoutPanel1.Controls.Add(Me.btnItemStock, 0, 2)
            Me.TableLayoutPanel1.Controls.Add(Me.btnCards, 2, 2)
            Me.TableLayoutPanel1.Controls.Add(Me.btnTables, 1, 2)
            Me.TableLayoutPanel1.Controls.Add(Me.btnWorkPeriodReport, 2, 6)
            Me.TableLayoutPanel1.Controls.Add(Me.btnPayroll, 1, 6)
            Me.TableLayoutPanel1.Controls.Add(Me.btnPOSReport, 3, 6)
            Me.TableLayoutPanel1.Controls.Add(Me.btnAccountingReports, 0, 7)
            Me.TableLayoutPanel1.Controls.Add(Me.btnEmployeeSession, 1, 7)
            Me.TableLayoutPanel1.Controls.Add(Me.btnRegistration, 3, 7)
            Me.TableLayoutPanel1.Controls.Add(Me.btnLogs, 2, 7)
            Me.TableLayoutPanel1.Controls.Add(Me.btnAttendance, 0, 6)
            Me.TableLayoutPanel1.Controls.Add(Me.btnMarketingTools, 3, 5)
            Me.TableLayoutPanel1.Controls.Add(Me.btnCreditCustomer, 3, 2)
            Me.TableLayoutPanel1.Controls.Add(Me.btnSupplier, 0, 3)
            Me.TableLayoutPanel1.Controls.Add(Me.btnProduct, 1, 3)
            Me.TableLayoutPanel1.Controls.Add(Me.btnPurchaseOrder, 2, 3)
            Me.TableLayoutPanel1.Controls.Add(Me.btnPurchase, 3, 3)
            Me.TableLayoutPanel1.Controls.Add(Me.btnPayment, 0, 4)
            Me.TableLayoutPanel1.Controls.Add(Me.btnBankReconciliation, 1, 4)
            Me.TableLayoutPanel1.Controls.Add(Me.btnStockTransfer_Issue, 2, 4)
            Me.TableLayoutPanel1.Controls.Add(Me.btnStockAdjustment, 3, 4)
            Me.TableLayoutPanel1.Controls.Add(Me.BtnVoucher, 0, 5)
            Me.TableLayoutPanel1.Controls.Add(Me.btnRecipe, 2, 5)
            Me.TableLayoutPanel1.Controls.Add(Me.btnHomeDelivery, 1, 5)
            Me.TableLayoutPanel1.Controls.Add(Me.btnAdvancedSetting, 0, 8)
            Dim tableLayoutPanel As System.Windows.Forms.TableLayoutPanel = Me.TableLayoutPanel1
            location = New System.Drawing.Point(142, 56)
            tableLayoutPanel.Location = location
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 9
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F))
            Dim tableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel = Me.TableLayoutPanel1
            size = New System.Drawing.Size(741, 700)
            tableLayoutPanel2.Size = size
            Me.TableLayoutPanel1.TabIndex = 56
            Me.btnRestaurantInfo.BackColor = System.Drawing.Color.Transparent
            Me.btnRestaurantInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnRestaurantInfo.BorderColor = System.Drawing.Color.Transparent
            cBlendItems.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56)}
            cBlendItems.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnRestaurantInfo.ColorFillBlend = cBlendItems
            Me.btnRestaurantInfo.Corners.All = 3
            Me.btnRestaurantInfo.Corners.LowerLeft = 3
            Me.btnRestaurantInfo.Corners.LowerRight = 3
            Me.btnRestaurantInfo.Corners.UpperLeft = 3
            Me.btnRestaurantInfo.Corners.UpperRight = 3
            Me.btnRestaurantInfo.DesignerSelected = False
            Me.btnRestaurantInfo.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnRestaurantInfo.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnRestaurantInfo.Image = CType(componentResourceManager.GetObject("btnRestaurantInfo.Image"), System.Drawing.Image)
            Me.btnRestaurantInfo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnRestaurantInfo.ImageIndex = 0
            Dim cButton As CButtonLib.CButton = Me.btnRestaurantInfo
            size = New System.Drawing.Size(50, 50)
            cButton.ImageSize = size
            Dim cButton2 As CButtonLib.CButton = Me.btnRestaurantInfo
            location = New System.Drawing.Point(1, 1)
            cButton2.Location = location
            Dim cButton3 As CButtonLib.CButton = Me.btnRestaurantInfo
            Dim margin As System.Windows.Forms.Padding = New System.Windows.Forms.Padding(1)
            cButton3.Margin = margin
            Me.btnRestaurantInfo.Name = "btnRestaurantInfo"
            Dim cButton4 As CButtonLib.CButton = Me.btnRestaurantInfo
            size = New System.Drawing.Size(183, 75)
            cButton4.Size = size
            Me.btnRestaurantInfo.TabIndex = 30
            Me.btnRestaurantInfo.Text = "Restaurant Info"
            Me.btnRestaurantInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnRestaurantInfo.TextShadowShow = False
            Me.btnRestaurantInfo.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnSettings.BackColor = System.Drawing.Color.Transparent
            Me.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnSettings.BorderColor = System.Drawing.Color.Transparent
            cBlendItems2.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56)}
            cBlendItems2.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnSettings.ColorFillBlend = cBlendItems2
            Me.btnSettings.Corners.All = 3
            Me.btnSettings.Corners.LowerLeft = 3
            Me.btnSettings.Corners.LowerRight = 3
            Me.btnSettings.Corners.UpperLeft = 3
            Me.btnSettings.Corners.UpperRight = 3
            Me.btnSettings.DesignerSelected = False
            Me.btnSettings.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnSettings.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnSettings.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnSettings.Image = CType(componentResourceManager.GetObject("btnSettings.Image"), System.Drawing.Image)
            Me.btnSettings.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnSettings.ImageIndex = 0
            Dim cButton5 As CButtonLib.CButton = Me.btnSettings
            size = New System.Drawing.Size(50, 50)
            cButton5.ImageSize = size
            Dim cButton6 As CButtonLib.CButton = Me.btnSettings
            location = New System.Drawing.Point(186, 1)
            cButton6.Location = location
            Dim cButton7 As CButtonLib.CButton = Me.btnSettings
            margin = New System.Windows.Forms.Padding(1)
            cButton7.Margin = margin
            Me.btnSettings.Name = "btnSettings"
            Dim cButton8 As CButtonLib.CButton = Me.btnSettings
            size = New System.Drawing.Size(183, 75)
            cButton8.Size = size
            Me.btnSettings.TabIndex = 50
            Me.btnSettings.Text = "Settings"
            Me.btnSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnSettings.TextShadowShow = False
            Me.btnSettings.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnAdvancedSetting.BackColor = System.Drawing.Color.Transparent
            Me.btnAdvancedSetting.BorderColor = System.Drawing.Color.Transparent
            Me.btnAdvancedSetting.ColorFillBlend = cBlendItems2
            Me.btnAdvancedSetting.Corners.All = 3
            Me.btnAdvancedSetting.Corners.LowerLeft = 3
            Me.btnAdvancedSetting.Corners.LowerRight = 3
            Me.btnAdvancedSetting.Corners.UpperLeft = 3
            Me.btnAdvancedSetting.Corners.UpperRight = 3
            Me.btnAdvancedSetting.DesignerSelected = False
            Me.btnAdvancedSetting.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnAdvancedSetting.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnAdvancedSetting.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Dim cButton9 As CButtonLib.CButton = Me.btnAdvancedSetting
            location = New System.Drawing.Point(1, 601)
            cButton9.Location = location
            Dim cButton10 As CButtonLib.CButton = Me.btnAdvancedSetting
            Dim margin2 As System.Windows.Forms.Padding = New System.Windows.Forms.Padding(1)
            cButton10.Margin = margin2
            Me.btnAdvancedSetting.Name = "btnAdvancedSetting"
            Dim cButton11 As CButtonLib.CButton = Me.btnAdvancedSetting
            size = New System.Drawing.Size(183, 75)
            cButton11.Size = size
            Me.btnAdvancedSetting.TabIndex = 400
            Me.btnAdvancedSetting.Text = "Advanced Setting"
            Me.btnAdvancedSetting.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnAdvancedSetting.TextShadowShow = False
            Me.btnAdvancedSetting.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnDatabase.BackColor = System.Drawing.Color.Transparent
            Me.btnDatabase.BorderColor = System.Drawing.Color.Transparent
            cBlendItems3.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56)}
            cBlendItems3.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnDatabase.ColorFillBlend = cBlendItems3
            Me.btnDatabase.Corners.All = 3
            Me.btnDatabase.Corners.LowerLeft = 3
            Me.btnDatabase.Corners.LowerRight = 3
            Me.btnDatabase.Corners.UpperLeft = 3
            Me.btnDatabase.Corners.UpperRight = 3
            Me.btnDatabase.DesignerSelected = False
            Me.btnDatabase.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnDatabase.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnDatabase.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnDatabase.Image = CType(componentResourceManager.GetObject("btnDatabase.Image"), System.Drawing.Image)
            Me.btnDatabase.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnDatabase.ImageIndex = 0
            Dim cButton12 As CButtonLib.CButton = Me.btnDatabase
            size = New System.Drawing.Size(50, 50)
            cButton12.ImageSize = size
            Dim cButton13 As CButtonLib.CButton = Me.btnDatabase
            location = New System.Drawing.Point(371, 1)
            cButton13.Location = location
            Dim cButton14 As CButtonLib.CButton = Me.btnDatabase
            margin = New System.Windows.Forms.Padding(1)
            cButton14.Margin = margin
            Me.btnDatabase.Name = "btnDatabase"
            Dim cButton15 As CButtonLib.CButton = Me.btnDatabase
            size = New System.Drawing.Size(183, 75)
            cButton15.Size = size
            Me.btnDatabase.TabIndex = 58
            Me.btnDatabase.Text = "Database"
            Me.btnDatabase.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnDatabase.TextShadowShow = False
            Me.btnDatabase.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnKitchen.BackColor = System.Drawing.Color.Transparent
            Me.btnKitchen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnKitchen.BorderColor = System.Drawing.Color.Transparent
            Me.btnKitchen.BorderShow = False
            cBlendItems4.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56)}
            cBlendItems4.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnKitchen.ColorFillBlend = cBlendItems4
            Me.btnKitchen.Corners.All = 3
            Me.btnKitchen.Corners.LowerLeft = 3
            Me.btnKitchen.Corners.LowerRight = 3
            Me.btnKitchen.Corners.UpperLeft = 3
            Me.btnKitchen.Corners.UpperRight = 3
            Me.btnKitchen.DesignerSelected = False
            Me.btnKitchen.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnKitchen.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnKitchen.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnKitchen.Image = CType(componentResourceManager.GetObject("btnKitchen.Image"), System.Drawing.Image)
            Me.btnKitchen.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnKitchen.ImageIndex = 0
            Dim cButton16 As CButtonLib.CButton = Me.btnKitchen
            size = New System.Drawing.Size(50, 50)
            cButton16.ImageSize = size
            Dim cButton17 As CButtonLib.CButton = Me.btnKitchen
            location = New System.Drawing.Point(556, 1)
            cButton17.Location = location
            Dim cButton18 As CButtonLib.CButton = Me.btnKitchen
            margin = New System.Windows.Forms.Padding(1)
            cButton18.Margin = margin
            Me.btnKitchen.Name = "btnKitchen"
            Dim cButton19 As CButtonLib.CButton = Me.btnKitchen
            size = New System.Drawing.Size(184, 75)
            cButton19.Size = size
            Me.btnKitchen.TabIndex = 47
            Me.btnKitchen.Text = "Kitchen/Section"
            Me.btnKitchen.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnKitchen.TextShadowShow = False
            Me.btnKitchen.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnCategories.BackColor = System.Drawing.Color.Transparent
            Me.btnCategories.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnCategories.BorderColor = System.Drawing.Color.Transparent
            cBlendItems5.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56)}
            cBlendItems5.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnCategories.ColorFillBlend = cBlendItems5
            Me.btnCategories.Corners.All = 3
            Me.btnCategories.Corners.LowerLeft = 3
            Me.btnCategories.Corners.LowerRight = 3
            Me.btnCategories.Corners.UpperLeft = 3
            Me.btnCategories.Corners.UpperRight = 3
            Me.btnCategories.DesignerSelected = False
            Me.btnCategories.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnCategories.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnCategories.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnCategories.Image = CType(componentResourceManager.GetObject("btnCategories.Image"), System.Drawing.Image)
            Me.btnCategories.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnCategories.ImageIndex = 0
            Dim cButton20 As CButtonLib.CButton = Me.btnCategories
            size = New System.Drawing.Size(50, 50)
            cButton20.ImageSize = size
            Dim cButton21 As CButtonLib.CButton = Me.btnCategories
            location = New System.Drawing.Point(1, 78)
            cButton21.Location = location
            Dim cButton22 As CButtonLib.CButton = Me.btnCategories
            margin = New System.Windows.Forms.Padding(1)
            cButton22.Margin = margin
            Me.btnCategories.Name = "btnCategories"
            Dim cButton23 As CButtonLib.CButton = Me.btnCategories
            size = New System.Drawing.Size(183, 75)
            cButton23.Size = size
            Me.btnCategories.TabIndex = 22
            Me.btnCategories.Text = "Categories"
            Me.btnCategories.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnCategories.TextShadowShow = False
            Me.btnCategories.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnItems.BackColor = System.Drawing.Color.Transparent
            Me.btnItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnItems.BorderColor = System.Drawing.Color.Transparent
            cBlendItems6.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56)}
            cBlendItems6.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnItems.ColorFillBlend = cBlendItems6
            Me.btnItems.Corners.All = 3
            Me.btnItems.Corners.LowerLeft = 3
            Me.btnItems.Corners.LowerRight = 3
            Me.btnItems.Corners.UpperLeft = 3
            Me.btnItems.Corners.UpperRight = 3
            Me.btnItems.DesignerSelected = False
            Me.btnItems.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnItems.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnItems.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnItems.Image = CType(componentResourceManager.GetObject("btnItems.Image"), System.Drawing.Image)
            Me.btnItems.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnItems.ImageIndex = 0
            Dim cButton24 As CButtonLib.CButton = Me.btnItems
            size = New System.Drawing.Size(50, 50)
            cButton24.ImageSize = size
            Dim cButton25 As CButtonLib.CButton = Me.btnItems
            location = New System.Drawing.Point(186, 78)
            cButton25.Location = location
            Dim cButton26 As CButtonLib.CButton = Me.btnItems
            margin = New System.Windows.Forms.Padding(1)
            cButton26.Margin = margin
            Me.btnItems.Name = "btnItems"
            Dim cButton27 As CButtonLib.CButton = Me.btnItems
            size = New System.Drawing.Size(183, 75)
            cButton27.Size = size
            Me.btnItems.TabIndex = 23
            Me.btnItems.Text = "Menu Items"
            Me.btnItems.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnItems.TextShadowShow = False
            Me.btnItems.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnMenuItemsModifiers.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.btnMenuItemsModifiers.BackColor = System.Drawing.Color.Transparent
            Me.btnMenuItemsModifiers.BorderColor = System.Drawing.Color.Transparent
            cBlendItems7.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56)}
            cBlendItems7.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnMenuItemsModifiers.ColorFillBlend = cBlendItems7
            Me.btnMenuItemsModifiers.Corners.All = 3
            Me.btnMenuItemsModifiers.Corners.LowerLeft = 3
            Me.btnMenuItemsModifiers.Corners.LowerRight = 3
            Me.btnMenuItemsModifiers.Corners.UpperLeft = 3
            Me.btnMenuItemsModifiers.Corners.UpperRight = 3
            Me.btnMenuItemsModifiers.DesignerSelected = False
            Me.btnMenuItemsModifiers.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnMenuItemsModifiers.Image = CType(componentResourceManager.GetObject("btnMenuItemsModifiers.Image"), System.Drawing.Image)
            Me.btnMenuItemsModifiers.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnMenuItemsModifiers.ImageIndex = 0
            Dim cButton28 As CButtonLib.CButton = Me.btnMenuItemsModifiers
            size = New System.Drawing.Size(50, 50)
            cButton28.ImageSize = size
            Dim cButton29 As CButtonLib.CButton = Me.btnMenuItemsModifiers
            location = New System.Drawing.Point(371, 78)
            cButton29.Location = location
            Dim cButton30 As CButtonLib.CButton = Me.btnMenuItemsModifiers
            margin = New System.Windows.Forms.Padding(1)
            cButton30.Margin = margin
            Me.btnMenuItemsModifiers.Name = "btnMenuItemsModifiers"
            Dim cButton31 As CButtonLib.CButton = Me.btnMenuItemsModifiers
            size = New System.Drawing.Size(183, 75)
            cButton31.Size = size
            Me.btnMenuItemsModifiers.TabIndex = 66
            Me.btnMenuItemsModifiers.Text = "Menu Items Modifiers"
            Me.btnMenuItemsModifiers.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnMenuItemsModifiers.TextShadowShow = False
            Me.btnMenuItemsModifiers.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnPizza.BackColor = System.Drawing.Color.Transparent
            Me.btnPizza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnPizza.BorderColor = System.Drawing.Color.Black
            cBlendItems8.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56)}
            cBlendItems8.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnPizza.ColorFillBlend = cBlendItems8
            Me.btnPizza.Corners.All = 3
            Me.btnPizza.Corners.LowerLeft = 3
            Me.btnPizza.Corners.LowerRight = 3
            Me.btnPizza.Corners.UpperLeft = 3
            Me.btnPizza.Corners.UpperRight = 3
            Me.btnPizza.DesignerSelected = False
            Me.btnPizza.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnPizza.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnPizza.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnPizza.Image = CType(componentResourceManager.GetObject("btnPizza.Image"), System.Drawing.Image)
            Me.btnPizza.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnPizza.ImageIndex = 0
            Dim cButton32 As CButtonLib.CButton = Me.btnPizza
            size = New System.Drawing.Size(50, 50)
            cButton32.ImageSize = size
            Dim cButton33 As CButtonLib.CButton = Me.btnPizza
            location = New System.Drawing.Point(556, 78)
            cButton33.Location = location
            Dim cButton34 As CButtonLib.CButton = Me.btnPizza
            margin = New System.Windows.Forms.Padding(1)
            cButton34.Margin = margin
            Me.btnPizza.Name = "btnPizza"
            Dim cButton35 As CButtonLib.CButton = Me.btnPizza
            size = New System.Drawing.Size(184, 75)
            cButton35.Size = size
            Me.btnPizza.TabIndex = 62
            Me.btnPizza.Text = "Pizza"
            Me.btnPizza.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnPizza.TextShadowShow = False
            Me.btnPizza.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnItemStock.BackColor = System.Drawing.Color.Transparent
            Me.btnItemStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnItemStock.BorderColor = System.Drawing.Color.Transparent
            cBlendItems9.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56)}
            cBlendItems9.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnItemStock.ColorFillBlend = cBlendItems9
            Me.btnItemStock.Corners.All = 3
            Me.btnItemStock.Corners.LowerLeft = 3
            Me.btnItemStock.Corners.LowerRight = 3
            Me.btnItemStock.Corners.UpperLeft = 3
            Me.btnItemStock.Corners.UpperRight = 3
            Me.btnItemStock.DesignerSelected = False
            Me.btnItemStock.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnItemStock.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnItemStock.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnItemStock.Image = CType(componentResourceManager.GetObject("btnItemStock.Image"), System.Drawing.Image)
            Me.btnItemStock.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnItemStock.ImageIndex = 0
            Dim cButton36 As CButtonLib.CButton = Me.btnItemStock
            size = New System.Drawing.Size(50, 50)
            cButton36.ImageSize = size
            Dim cButton37 As CButtonLib.CButton = Me.btnItemStock
            location = New System.Drawing.Point(1, 155)
            cButton37.Location = location
            Dim cButton38 As CButtonLib.CButton = Me.btnItemStock
            margin = New System.Windows.Forms.Padding(1)
            cButton38.Margin = margin
            Me.btnItemStock.Name = "btnItemStock"
            Dim cButton39 As CButtonLib.CButton = Me.btnItemStock
            size = New System.Drawing.Size(183, 75)
            cButton39.Size = size
            Me.btnItemStock.TabIndex = 37
            Me.btnItemStock.Text = "Menu Items Stock "
            Me.btnItemStock.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnItemStock.TextShadowShow = False
            Me.btnItemStock.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnCards.BackColor = System.Drawing.Color.Transparent
            Me.btnCards.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnCards.BorderColor = System.Drawing.Color.Transparent
            cBlendItems10.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56)}
            cBlendItems10.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnCards.ColorFillBlend = cBlendItems10
            Me.btnCards.Corners.All = 3
            Me.btnCards.Corners.LowerLeft = 3
            Me.btnCards.Corners.LowerRight = 3
            Me.btnCards.Corners.UpperLeft = 3
            Me.btnCards.Corners.UpperRight = 3
            Me.btnCards.DesignerSelected = False
            Me.btnCards.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnCards.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnCards.Image = CType(componentResourceManager.GetObject("btnCards.Image"), System.Drawing.Image)
            Me.btnCards.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnCards.ImageIndex = 0
            Dim cButton40 As CButtonLib.CButton = Me.btnCards
            size = New System.Drawing.Size(50, 50)
            cButton40.ImageSize = size
            Dim cButton41 As CButtonLib.CButton = Me.btnCards
            location = New System.Drawing.Point(371, 155)
            cButton41.Location = location
            Dim cButton42 As CButtonLib.CButton = Me.btnCards
            margin = New System.Windows.Forms.Padding(1)
            cButton42.Margin = margin
            Me.btnCards.Name = "btnCards"
            Dim cButton43 As CButtonLib.CButton = Me.btnCards
            size = New System.Drawing.Size(183, 75)
            cButton43.Size = size
            Me.btnCards.TabIndex = 65
            Me.btnCards.Text = "Cards"
            Me.btnCards.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnCards.TextShadowShow = False
            Me.btnCards.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnTables.BackColor = System.Drawing.Color.Transparent
            Me.btnTables.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnTables.BorderColor = System.Drawing.Color.Transparent
            cBlendItems11.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56)}
            cBlendItems11.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnTables.ColorFillBlend = cBlendItems11
            Me.btnTables.Corners.All = 3
            Me.btnTables.Corners.LowerLeft = 3
            Me.btnTables.Corners.LowerRight = 3
            Me.btnTables.Corners.UpperLeft = 3
            Me.btnTables.Corners.UpperRight = 3
            Me.btnTables.DesignerSelected = False
            Me.btnTables.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnTables.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnTables.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnTables.Image = CType(componentResourceManager.GetObject("btnTables.Image"), System.Drawing.Image)
            Me.btnTables.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnTables.ImageIndex = 0
            Dim cButton44 As CButtonLib.CButton = Me.btnTables
            size = New System.Drawing.Size(50, 50)
            cButton44.ImageSize = size
            Dim cButton45 As CButtonLib.CButton = Me.btnTables
            location = New System.Drawing.Point(186, 155)
            cButton45.Location = location
            Dim cButton46 As CButtonLib.CButton = Me.btnTables
            margin = New System.Windows.Forms.Padding(1)
            cButton46.Margin = margin
            Me.btnTables.Name = "btnTables"
            Dim cButton47 As CButtonLib.CButton = Me.btnTables
            size = New System.Drawing.Size(183, 75)
            cButton47.Size = size
            Me.btnTables.TabIndex = 24
            Me.btnTables.Text = "Tables"
            Me.btnTables.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnTables.TextShadowShow = False
            Me.btnTables.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnWorkPeriodReport.BackColor = System.Drawing.Color.Transparent
            Me.btnWorkPeriodReport.BorderColor = System.Drawing.Color.Transparent
            cBlendItems12.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56)}
            cBlendItems12.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnWorkPeriodReport.ColorFillBlend = cBlendItems12
            Me.btnWorkPeriodReport.Corners.All = 3
            Me.btnWorkPeriodReport.Corners.LowerLeft = 3
            Me.btnWorkPeriodReport.Corners.LowerRight = 3
            Me.btnWorkPeriodReport.Corners.UpperLeft = 3
            Me.btnWorkPeriodReport.Corners.UpperRight = 3
            Me.btnWorkPeriodReport.DesignerSelected = False
            Me.btnWorkPeriodReport.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnWorkPeriodReport.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnWorkPeriodReport.Image = CType(componentResourceManager.GetObject("btnWorkPeriodReport.Image"), System.Drawing.Image)
            Me.btnWorkPeriodReport.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnWorkPeriodReport.ImageIndex = 0
            Dim cButton48 As CButtonLib.CButton = Me.btnWorkPeriodReport
            size = New System.Drawing.Size(50, 50)
            cButton48.ImageSize = size
            Dim cButton49 As CButtonLib.CButton = Me.btnWorkPeriodReport
            location = New System.Drawing.Point(371, 463)
            cButton49.Location = location
            Dim cButton50 As CButtonLib.CButton = Me.btnWorkPeriodReport
            margin = New System.Windows.Forms.Padding(1)
            cButton50.Margin = margin
            Me.btnWorkPeriodReport.Name = "btnWorkPeriodReport"
            Dim cButton51 As CButtonLib.CButton = Me.btnWorkPeriodReport
            size = New System.Drawing.Size(183, 75)
            cButton51.Size = size
            Me.btnWorkPeriodReport.TabIndex = 57
            Me.btnWorkPeriodReport.Text = "Work Period Report"
            Me.btnWorkPeriodReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnWorkPeriodReport.TextShadowShow = False
            Me.btnWorkPeriodReport.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnPayroll.BackColor = System.Drawing.Color.Transparent
            Me.btnPayroll.BorderColor = System.Drawing.Color.Transparent
            cBlendItems13.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56)}
            cBlendItems13.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnPayroll.ColorFillBlend = cBlendItems13
            Me.btnPayroll.Corners.All = 3
            Me.btnPayroll.Corners.LowerLeft = 3
            Me.btnPayroll.Corners.LowerRight = 3
            Me.btnPayroll.Corners.UpperLeft = 3
            Me.btnPayroll.Corners.UpperRight = 3
            Me.btnPayroll.DesignerSelected = False
            Me.btnPayroll.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnPayroll.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnPayroll.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnPayroll.Image = CType(componentResourceManager.GetObject("btnPayroll.Image"), System.Drawing.Image)
            Me.btnPayroll.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnPayroll.ImageIndex = 0
            Dim cButton52 As CButtonLib.CButton = Me.btnPayroll
            size = New System.Drawing.Size(50, 50)
            cButton52.ImageSize = size
            Dim cButton53 As CButtonLib.CButton = Me.btnPayroll
            location = New System.Drawing.Point(186, 463)
            cButton53.Location = location
            Dim cButton54 As CButtonLib.CButton = Me.btnPayroll
            margin = New System.Windows.Forms.Padding(1)
            cButton54.Margin = margin
            Me.btnPayroll.Name = "btnPayroll"
            Dim cButton55 As CButtonLib.CButton = Me.btnPayroll
            size = New System.Drawing.Size(183, 75)
            cButton55.Size = size
            Me.btnPayroll.TabIndex = 52
            Me.btnPayroll.Text = "Payroll"
            Me.btnPayroll.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnPayroll.TextShadowShow = False
            Me.btnPayroll.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnPOSReport.BackColor = System.Drawing.Color.Transparent
            Me.btnPOSReport.BorderColor = System.Drawing.Color.Transparent
            cBlendItems14.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56)}
            cBlendItems14.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnPOSReport.ColorFillBlend = cBlendItems14
            Me.btnPOSReport.Corners.All = 3
            Me.btnPOSReport.Corners.LowerLeft = 3
            Me.btnPOSReport.Corners.LowerRight = 3
            Me.btnPOSReport.Corners.UpperLeft = 3
            Me.btnPOSReport.Corners.UpperRight = 3
            Me.btnPOSReport.DesignerSelected = False
            Me.btnPOSReport.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnPOSReport.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnPOSReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnPOSReport.Image = CType(componentResourceManager.GetObject("btnPOSReport.Image"), System.Drawing.Image)
            Me.btnPOSReport.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnPOSReport.ImageIndex = 0
            Dim cButton56 As CButtonLib.CButton = Me.btnPOSReport
            size = New System.Drawing.Size(50, 50)
            cButton56.ImageSize = size
            Dim cButton57 As CButtonLib.CButton = Me.btnPOSReport
            location = New System.Drawing.Point(556, 463)
            cButton57.Location = location
            Dim cButton58 As CButtonLib.CButton = Me.btnPOSReport
            margin = New System.Windows.Forms.Padding(1)
            cButton58.Margin = margin
            Me.btnPOSReport.Name = "btnPOSReport"
            Dim cButton59 As CButtonLib.CButton = Me.btnPOSReport
            size = New System.Drawing.Size(184, 75)
            cButton59.Size = size
            Me.btnPOSReport.TabIndex = 33
            Me.btnPOSReport.Text = "POS Report"
            Me.btnPOSReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnPOSReport.TextShadowShow = False
            Me.btnPOSReport.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnAccountingReports.BackColor = System.Drawing.Color.Transparent
            Me.btnAccountingReports.BorderColor = System.Drawing.Color.Transparent
            cBlendItems15.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56)}
            cBlendItems15.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnAccountingReports.ColorFillBlend = cBlendItems15
            Me.btnAccountingReports.Corners.All = 3
            Me.btnAccountingReports.Corners.LowerLeft = 3
            Me.btnAccountingReports.Corners.LowerRight = 3
            Me.btnAccountingReports.Corners.UpperLeft = 3
            Me.btnAccountingReports.Corners.UpperRight = 3
            Me.btnAccountingReports.DesignerSelected = False
            Me.btnAccountingReports.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnAccountingReports.Font = New System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnAccountingReports.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnAccountingReports.Image = CType(componentResourceManager.GetObject("btnAccountingReports.Image"), System.Drawing.Image)
            Me.btnAccountingReports.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnAccountingReports.ImageIndex = 0
            Dim cButton60 As CButtonLib.CButton = Me.btnAccountingReports
            size = New System.Drawing.Size(50, 50)
            cButton60.ImageSize = size
            Dim cButton61 As CButtonLib.CButton = Me.btnAccountingReports
            location = New System.Drawing.Point(1, 540)
            cButton61.Location = location
            Dim cButton62 As CButtonLib.CButton = Me.btnAccountingReports
            margin = New System.Windows.Forms.Padding(1)
            cButton62.Margin = margin
            Me.btnAccountingReports.Name = "btnAccountingReports"
            Dim cButton63 As CButtonLib.CButton = Me.btnAccountingReports
            size = New System.Drawing.Size(183, 79)
            cButton63.Size = size
            Me.btnAccountingReports.TabIndex = 43
            Me.btnAccountingReports.Text = "Accounting Reports"
            Me.btnAccountingReports.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnAccountingReports.TextShadowShow = False
            Me.btnAccountingReports.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnEmployeeSession.BackColor = System.Drawing.Color.Transparent
            Me.btnEmployeeSession.BorderColor = System.Drawing.Color.Transparent
            cBlendItems16.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56)}
            cBlendItems16.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnEmployeeSession.ColorFillBlend = cBlendItems16
            Me.btnEmployeeSession.Corners.All = 3
            Me.btnEmployeeSession.Corners.LowerLeft = 3
            Me.btnEmployeeSession.Corners.LowerRight = 3
            Me.btnEmployeeSession.Corners.UpperLeft = 3
            Me.btnEmployeeSession.Corners.UpperRight = 3
            Me.btnEmployeeSession.DesignerSelected = False
            Me.btnEmployeeSession.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnEmployeeSession.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnEmployeeSession.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnEmployeeSession.Image = CType(componentResourceManager.GetObject("btnEmployeeSession.Image"), System.Drawing.Image)
            Me.btnEmployeeSession.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnEmployeeSession.ImageIndex = 0
            Dim cButton64 As CButtonLib.CButton = Me.btnEmployeeSession
            size = New System.Drawing.Size(50, 50)
            cButton64.ImageSize = size
            Dim cButton65 As CButtonLib.CButton = Me.btnEmployeeSession
            location = New System.Drawing.Point(186, 540)
            cButton65.Location = location
            Dim cButton66 As CButtonLib.CButton = Me.btnEmployeeSession
            margin = New System.Windows.Forms.Padding(1)
            cButton66.Margin = margin
            Me.btnEmployeeSession.Name = "btnEmployeeSession"
            Dim cButton67 As CButtonLib.CButton = Me.btnEmployeeSession
            size = New System.Drawing.Size(183, 79)
            cButton67.Size = size
            Me.btnEmployeeSession.TabIndex = 38
            Me.btnEmployeeSession.Text = "Employee Session"
            Me.btnEmployeeSession.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnEmployeeSession.TextShadowShow = False
            Me.btnEmployeeSession.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnRegistration.BackColor = System.Drawing.Color.Transparent
            Me.btnRegistration.BorderColor = System.Drawing.Color.Transparent
            cBlendItems17.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56)}
            cBlendItems17.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnRegistration.ColorFillBlend = cBlendItems17
            Me.btnRegistration.Corners.All = 3
            Me.btnRegistration.Corners.LowerLeft = 3
            Me.btnRegistration.Corners.LowerRight = 3
            Me.btnRegistration.Corners.UpperLeft = 3
            Me.btnRegistration.Corners.UpperRight = 3
            Me.btnRegistration.DesignerSelected = False
            Me.btnRegistration.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnRegistration.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnRegistration.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnRegistration.Image = CType(componentResourceManager.GetObject("btnRegistration.Image"), System.Drawing.Image)
            Me.btnRegistration.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnRegistration.ImageIndex = 0
            Dim cButton68 As CButtonLib.CButton = Me.btnRegistration
            size = New System.Drawing.Size(50, 50)
            cButton68.ImageSize = size
            Dim cButton69 As CButtonLib.CButton = Me.btnRegistration
            location = New System.Drawing.Point(556, 540)
            cButton69.Location = location
            Dim cButton70 As CButtonLib.CButton = Me.btnRegistration
            margin = New System.Windows.Forms.Padding(1)
            cButton70.Margin = margin
            Me.btnRegistration.Name = "btnRegistration"
            Dim cButton71 As CButtonLib.CButton = Me.btnRegistration
            size = New System.Drawing.Size(184, 79)
            cButton71.Size = size
            Me.btnRegistration.TabIndex = 25
            Me.btnRegistration.Text = "Registration"
            Me.btnRegistration.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnRegistration.TextShadowShow = False
            Me.btnRegistration.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnLogs.BackColor = System.Drawing.Color.Transparent
            Me.btnLogs.BorderColor = System.Drawing.Color.Transparent
            cBlendItems18.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56)}
            cBlendItems18.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnLogs.ColorFillBlend = cBlendItems18
            Me.btnLogs.Corners.All = 3
            Me.btnLogs.Corners.LowerLeft = 3
            Me.btnLogs.Corners.LowerRight = 3
            Me.btnLogs.Corners.UpperLeft = 3
            Me.btnLogs.Corners.UpperRight = 3
            Me.btnLogs.DesignerSelected = False
            Me.btnLogs.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnLogs.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnLogs.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnLogs.Image = CType(componentResourceManager.GetObject("btnLogs.Image"), System.Drawing.Image)
            Me.btnLogs.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnLogs.ImageIndex = 0
            Dim cButton72 As CButtonLib.CButton = Me.btnLogs
            size = New System.Drawing.Size(50, 50)
            cButton72.ImageSize = size
            Dim cButton73 As CButtonLib.CButton = Me.btnLogs
            location = New System.Drawing.Point(371, 540)
            cButton73.Location = location
            Dim cButton74 As CButtonLib.CButton = Me.btnLogs
            margin = New System.Windows.Forms.Padding(1)
            cButton74.Margin = margin
            Me.btnLogs.Name = "btnLogs"
            Dim cButton75 As CButtonLib.CButton = Me.btnLogs
            size = New System.Drawing.Size(183, 79)
            cButton75.Size = size
            Me.btnLogs.TabIndex = 26
            Me.btnLogs.Text = "Logs"
            Me.btnLogs.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnLogs.TextShadowShow = False
            Me.btnLogs.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnAttendance.BackColor = System.Drawing.Color.Transparent
            Me.btnAttendance.BorderColor = System.Drawing.Color.Transparent
            cBlendItems19.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56)}
            cBlendItems19.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnAttendance.ColorFillBlend = cBlendItems19
            Me.btnAttendance.Corners.All = 3
            Me.btnAttendance.Corners.LowerLeft = 3
            Me.btnAttendance.Corners.LowerRight = 3
            Me.btnAttendance.Corners.UpperLeft = 3
            Me.btnAttendance.Corners.UpperRight = 3
            Me.btnAttendance.DesignerSelected = False
            Me.btnAttendance.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnAttendance.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnAttendance.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnAttendance.Image = CType(componentResourceManager.GetObject("btnAttendance.Image"), System.Drawing.Image)
            Me.btnAttendance.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnAttendance.ImageIndex = 0
            Dim cButton76 As CButtonLib.CButton = Me.btnAttendance
            size = New System.Drawing.Size(50, 50)
            cButton76.ImageSize = size
            Dim cButton77 As CButtonLib.CButton = Me.btnAttendance
            location = New System.Drawing.Point(1, 463)
            cButton77.Location = location
            Dim cButton78 As CButtonLib.CButton = Me.btnAttendance
            margin = New System.Windows.Forms.Padding(1)
            cButton78.Margin = margin
            Me.btnAttendance.Name = "btnAttendance"
            Dim cButton79 As CButtonLib.CButton = Me.btnAttendance
            size = New System.Drawing.Size(183, 75)
            cButton79.Size = size
            Me.btnAttendance.TabIndex = 59
            Me.btnAttendance.Text = "Attendnace"
            Me.btnAttendance.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnAttendance.TextShadowShow = False
            Me.btnAttendance.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnMarketingTools.BackColor = System.Drawing.Color.Transparent
            Me.btnMarketingTools.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnMarketingTools.BorderColor = System.Drawing.Color.Transparent
            cBlendItems20.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56)}
            cBlendItems20.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnMarketingTools.ColorFillBlend = cBlendItems20
            Me.btnMarketingTools.Corners.All = 3
            Me.btnMarketingTools.Corners.LowerLeft = 3
            Me.btnMarketingTools.Corners.LowerRight = 3
            Me.btnMarketingTools.Corners.UpperLeft = 3
            Me.btnMarketingTools.Corners.UpperRight = 3
            Me.btnMarketingTools.DesignerSelected = False
            Me.btnMarketingTools.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnMarketingTools.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnMarketingTools.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnMarketingTools.Image = CType(componentResourceManager.GetObject("btnMarketingTools.Image"), System.Drawing.Image)
            Me.btnMarketingTools.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnMarketingTools.ImageIndex = 0
            Dim cButton80 As CButtonLib.CButton = Me.btnMarketingTools
            size = New System.Drawing.Size(50, 50)
            cButton80.ImageSize = size
            Dim cButton81 As CButtonLib.CButton = Me.btnMarketingTools
            location = New System.Drawing.Point(556, 386)
            cButton81.Location = location
            Dim cButton82 As CButtonLib.CButton = Me.btnMarketingTools
            margin = New System.Windows.Forms.Padding(1)
            cButton82.Margin = margin
            Me.btnMarketingTools.Name = "btnMarketingTools"
            Dim cButton83 As CButtonLib.CButton = Me.btnMarketingTools
            size = New System.Drawing.Size(184, 75)
            cButton83.Size = size
            Me.btnMarketingTools.TabIndex = 61
            Me.btnMarketingTools.Text = "Marketing Tools"
            Me.btnMarketingTools.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnMarketingTools.TextShadowShow = False
            Me.btnMarketingTools.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnCreditCustomer.BackColor = System.Drawing.Color.Transparent
            Me.btnCreditCustomer.BorderColor = System.Drawing.Color.Transparent
            cBlendItems21.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56)}
            cBlendItems21.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnCreditCustomer.ColorFillBlend = cBlendItems21
            Me.btnCreditCustomer.Corners.All = 3
            Me.btnCreditCustomer.Corners.LowerLeft = 3
            Me.btnCreditCustomer.Corners.LowerRight = 3
            Me.btnCreditCustomer.Corners.UpperLeft = 3
            Me.btnCreditCustomer.Corners.UpperRight = 3
            Me.btnCreditCustomer.DesignerSelected = False
            Me.btnCreditCustomer.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnCreditCustomer.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnCreditCustomer.Image = CType(componentResourceManager.GetObject("btnCreditCustomer.Image"), System.Drawing.Image)
            Me.btnCreditCustomer.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnCreditCustomer.ImageIndex = 0
            Dim cButton84 As CButtonLib.CButton = Me.btnCreditCustomer
            size = New System.Drawing.Size(50, 50)
            cButton84.ImageSize = size
            Dim cButton85 As CButtonLib.CButton = Me.btnCreditCustomer
            location = New System.Drawing.Point(556, 155)
            cButton85.Location = location
            Dim cButton86 As CButtonLib.CButton = Me.btnCreditCustomer
            margin = New System.Windows.Forms.Padding(1)
            cButton86.Margin = margin
            Me.btnCreditCustomer.Name = "btnCreditCustomer"
            Dim cButton87 As CButtonLib.CButton = Me.btnCreditCustomer
            size = New System.Drawing.Size(184, 75)
            cButton87.Size = size
            Me.btnCreditCustomer.TabIndex = 63
            Me.btnCreditCustomer.Text = "Credit Customer"
            Me.btnCreditCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnCreditCustomer.TextShadowShow = False
            Me.btnCreditCustomer.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnSupplier.BackColor = System.Drawing.Color.Transparent
            Me.btnSupplier.BorderColor = System.Drawing.Color.Transparent
            cBlendItems22.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56)}
            cBlendItems22.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnSupplier.ColorFillBlend = cBlendItems22
            Me.btnSupplier.Corners.All = 3
            Me.btnSupplier.Corners.LowerLeft = 3
            Me.btnSupplier.Corners.LowerRight = 3
            Me.btnSupplier.Corners.UpperLeft = 3
            Me.btnSupplier.Corners.UpperRight = 3
            Me.btnSupplier.DesignerSelected = False
            Me.btnSupplier.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnSupplier.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnSupplier.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnSupplier.Image = CType(componentResourceManager.GetObject("btnSupplier.Image"), System.Drawing.Image)
            Me.btnSupplier.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnSupplier.ImageIndex = 0
            Dim cButton88 As CButtonLib.CButton = Me.btnSupplier
            size = New System.Drawing.Size(50, 50)
            cButton88.ImageSize = size
            Dim cButton89 As CButtonLib.CButton = Me.btnSupplier
            location = New System.Drawing.Point(1, 232)
            cButton89.Location = location
            Dim cButton90 As CButtonLib.CButton = Me.btnSupplier
            margin = New System.Windows.Forms.Padding(1)
            cButton90.Margin = margin
            Me.btnSupplier.Name = "btnSupplier"
            Dim cButton91 As CButtonLib.CButton = Me.btnSupplier
            size = New System.Drawing.Size(183, 75)
            cButton91.Size = size
            Me.btnSupplier.TabIndex = 40
            Me.btnSupplier.Text = "Supplier"
            Me.btnSupplier.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnSupplier.TextShadowShow = False
            Me.btnSupplier.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnProduct.BackColor = System.Drawing.Color.Transparent
            Me.btnProduct.BorderColor = System.Drawing.Color.Transparent
            cBlendItems23.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56)}
            cBlendItems23.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnProduct.ColorFillBlend = cBlendItems23
            Me.btnProduct.Corners.All = 3
            Me.btnProduct.Corners.LowerLeft = 3
            Me.btnProduct.Corners.LowerRight = 3
            Me.btnProduct.Corners.UpperLeft = 3
            Me.btnProduct.Corners.UpperRight = 3
            Me.btnProduct.DesignerSelected = False
            Me.btnProduct.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnProduct.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnProduct.Image = CType(componentResourceManager.GetObject("btnProduct.Image"), System.Drawing.Image)
            Me.btnProduct.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnProduct.ImageIndex = 0
            Dim cButton92 As CButtonLib.CButton = Me.btnProduct
            size = New System.Drawing.Size(50, 50)
            cButton92.ImageSize = size
            Dim cButton93 As CButtonLib.CButton = Me.btnProduct
            location = New System.Drawing.Point(186, 232)
            cButton93.Location = location
            Dim cButton94 As CButtonLib.CButton = Me.btnProduct
            margin = New System.Windows.Forms.Padding(1)
            cButton94.Margin = margin
            Me.btnProduct.Name = "btnProduct"
            Dim cButton95 As CButtonLib.CButton = Me.btnProduct
            size = New System.Drawing.Size(183, 75)
            cButton95.Size = size
            Me.btnProduct.TabIndex = 39
            Me.btnProduct.Text = "Raw Materials"
            Me.btnProduct.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnProduct.TextShadowShow = False
            Me.btnProduct.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnPurchaseOrder.BackColor = System.Drawing.Color.Transparent
            Me.btnPurchaseOrder.BorderColor = System.Drawing.Color.Transparent
            cBlendItems24.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56)}
            cBlendItems24.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnPurchaseOrder.ColorFillBlend = cBlendItems24
            Me.btnPurchaseOrder.Corners.All = 3
            Me.btnPurchaseOrder.Corners.LowerLeft = 3
            Me.btnPurchaseOrder.Corners.LowerRight = 3
            Me.btnPurchaseOrder.Corners.UpperLeft = 3
            Me.btnPurchaseOrder.Corners.UpperRight = 3
            Me.btnPurchaseOrder.DesignerSelected = False
            Me.btnPurchaseOrder.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnPurchaseOrder.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnPurchaseOrder.Image = CType(componentResourceManager.GetObject("btnPurchaseOrder.Image"), System.Drawing.Image)
            Me.btnPurchaseOrder.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnPurchaseOrder.ImageIndex = 0
            Dim cButton96 As CButtonLib.CButton = Me.btnPurchaseOrder
            size = New System.Drawing.Size(50, 50)
            cButton96.ImageSize = size
            Dim cButton97 As CButtonLib.CButton = Me.btnPurchaseOrder
            location = New System.Drawing.Point(371, 232)
            cButton97.Location = location
            Dim cButton98 As CButtonLib.CButton = Me.btnPurchaseOrder
            margin = New System.Windows.Forms.Padding(1)
            cButton98.Margin = margin
            Me.btnPurchaseOrder.Name = "btnPurchaseOrder"
            Dim cButton99 As CButtonLib.CButton = Me.btnPurchaseOrder
            size = New System.Drawing.Size(183, 75)
            cButton99.Size = size
            Me.btnPurchaseOrder.TabIndex = 67
            Me.btnPurchaseOrder.Text = "Purchase Order"
            Me.btnPurchaseOrder.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnPurchaseOrder.TextShadowShow = False
            Me.btnPurchaseOrder.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnPurchase.BackColor = System.Drawing.Color.Transparent
            Me.btnPurchase.BorderColor = System.Drawing.Color.Transparent
            cBlendItems25.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56)}
            cBlendItems25.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnPurchase.ColorFillBlend = cBlendItems25
            Me.btnPurchase.Corners.All = 3
            Me.btnPurchase.Corners.LowerLeft = 3
            Me.btnPurchase.Corners.LowerRight = 3
            Me.btnPurchase.Corners.UpperLeft = 3
            Me.btnPurchase.Corners.UpperRight = 3
            Me.btnPurchase.DesignerSelected = False
            Me.btnPurchase.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnPurchase.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnPurchase.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnPurchase.Image = CType(componentResourceManager.GetObject("btnPurchase.Image"), System.Drawing.Image)
            Me.btnPurchase.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnPurchase.ImageIndex = 0
            Dim cButton100 As CButtonLib.CButton = Me.btnPurchase
            size = New System.Drawing.Size(50, 50)
            cButton100.ImageSize = size
            Dim cButton101 As CButtonLib.CButton = Me.btnPurchase
            location = New System.Drawing.Point(556, 232)
            cButton101.Location = location
            Dim cButton102 As CButtonLib.CButton = Me.btnPurchase
            margin = New System.Windows.Forms.Padding(1)
            cButton102.Margin = margin
            Me.btnPurchase.Name = "btnPurchase"
            Dim cButton103 As CButtonLib.CButton = Me.btnPurchase
            size = New System.Drawing.Size(184, 75)
            cButton103.Size = size
            Me.btnPurchase.TabIndex = 41
            Me.btnPurchase.Text = "Purchase Entry"
            Me.btnPurchase.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnPurchase.TextShadowShow = False
            Me.btnPurchase.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnPayment.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.btnPayment.BackColor = System.Drawing.Color.Transparent
            Me.btnPayment.BorderColor = System.Drawing.Color.Transparent
            cBlendItems26.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56)}
            cBlendItems26.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnPayment.ColorFillBlend = cBlendItems26
            Me.btnPayment.Corners.All = 3
            Me.btnPayment.Corners.LowerLeft = 3
            Me.btnPayment.Corners.LowerRight = 3
            Me.btnPayment.Corners.UpperLeft = 3
            Me.btnPayment.Corners.UpperRight = 3
            Me.btnPayment.DesignerSelected = False
            Me.btnPayment.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnPayment.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnPayment.Image = CType(componentResourceManager.GetObject("btnPayment.Image"), System.Drawing.Image)
            Me.btnPayment.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnPayment.ImageIndex = 0
            Dim cButton104 As CButtonLib.CButton = Me.btnPayment
            size = New System.Drawing.Size(50, 50)
            cButton104.ImageSize = size
            Dim cButton105 As CButtonLib.CButton = Me.btnPayment
            location = New System.Drawing.Point(1, 309)
            cButton105.Location = location
            Dim cButton106 As CButtonLib.CButton = Me.btnPayment
            margin = New System.Windows.Forms.Padding(1)
            cButton106.Margin = margin
            Me.btnPayment.Name = "btnPayment"
            Dim cButton107 As CButtonLib.CButton = Me.btnPayment
            size = New System.Drawing.Size(183, 75)
            cButton107.Size = size
            Me.btnPayment.TabIndex = 42
            Me.btnPayment.Text = "Payment"
            Me.btnPayment.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnPayment.TextShadowShow = False
            Me.btnPayment.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnBankReconciliation.BackColor = System.Drawing.Color.Transparent
            Me.btnBankReconciliation.BorderColor = System.Drawing.Color.Transparent
            cBlendItems27.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56)}
            cBlendItems27.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnBankReconciliation.ColorFillBlend = cBlendItems27
            Me.btnBankReconciliation.Corners.All = 3
            Me.btnBankReconciliation.Corners.LowerLeft = 3
            Me.btnBankReconciliation.Corners.LowerRight = 3
            Me.btnBankReconciliation.Corners.UpperLeft = 3
            Me.btnBankReconciliation.Corners.UpperRight = 3
            Me.btnBankReconciliation.DesignerSelected = False
            Me.btnBankReconciliation.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnBankReconciliation.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnBankReconciliation.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnBankReconciliation.Image = CType(componentResourceManager.GetObject("btnBankReconciliation.Image"), System.Drawing.Image)
            Me.btnBankReconciliation.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnBankReconciliation.ImageIndex = 0
            Dim cButton108 As CButtonLib.CButton = Me.btnBankReconciliation
            size = New System.Drawing.Size(50, 50)
            cButton108.ImageSize = size
            Dim cButton109 As CButtonLib.CButton = Me.btnBankReconciliation
            location = New System.Drawing.Point(186, 309)
            cButton109.Location = location
            Dim cButton110 As CButtonLib.CButton = Me.btnBankReconciliation
            margin = New System.Windows.Forms.Padding(1)
            cButton110.Margin = margin
            Me.btnBankReconciliation.Name = "btnBankReconciliation"
            Dim cButton111 As CButtonLib.CButton = Me.btnBankReconciliation
            size = New System.Drawing.Size(183, 75)
            cButton111.Size = size
            Me.btnBankReconciliation.TabIndex = 53
            Me.btnBankReconciliation.Text = "Banking"
            Me.btnBankReconciliation.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnBankReconciliation.TextShadowShow = False
            Me.btnBankReconciliation.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnStockTransfer_Issue.BackColor = System.Drawing.Color.Transparent
            Me.btnStockTransfer_Issue.BorderColor = System.Drawing.Color.Transparent
            cBlendItems28.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56)}
            cBlendItems28.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnStockTransfer_Issue.ColorFillBlend = cBlendItems28
            Me.btnStockTransfer_Issue.Corners.All = 3
            Me.btnStockTransfer_Issue.Corners.LowerLeft = 3
            Me.btnStockTransfer_Issue.Corners.LowerRight = 3
            Me.btnStockTransfer_Issue.Corners.UpperLeft = 3
            Me.btnStockTransfer_Issue.Corners.UpperRight = 3
            Me.btnStockTransfer_Issue.DesignerSelected = False
            Me.btnStockTransfer_Issue.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnStockTransfer_Issue.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnStockTransfer_Issue.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnStockTransfer_Issue.Image = CType(componentResourceManager.GetObject("btnStockTransfer_Issue.Image"), System.Drawing.Image)
            Me.btnStockTransfer_Issue.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnStockTransfer_Issue.ImageIndex = 0
            Dim cButton112 As CButtonLib.CButton = Me.btnStockTransfer_Issue
            size = New System.Drawing.Size(50, 50)
            cButton112.ImageSize = size
            Dim cButton113 As CButtonLib.CButton = Me.btnStockTransfer_Issue
            location = New System.Drawing.Point(371, 309)
            cButton113.Location = location
            Dim cButton114 As CButtonLib.CButton = Me.btnStockTransfer_Issue
            margin = New System.Windows.Forms.Padding(1)
            cButton114.Margin = margin
            Me.btnStockTransfer_Issue.Name = "btnStockTransfer_Issue"
            Dim cButton115 As CButtonLib.CButton = Me.btnStockTransfer_Issue
            size = New System.Drawing.Size(183, 75)
            cButton115.Size = size
            Me.btnStockTransfer_Issue.TabIndex = 55
            Me.btnStockTransfer_Issue.Text = "Stock Transfer"
            Me.btnStockTransfer_Issue.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnStockTransfer_Issue.TextShadowShow = False
            Me.btnStockTransfer_Issue.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnStockAdjustment.BackColor = System.Drawing.Color.Transparent
            Me.btnStockAdjustment.BorderColor = System.Drawing.Color.Transparent
            cBlendItems29.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56)}
            cBlendItems29.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnStockAdjustment.ColorFillBlend = cBlendItems29
            Me.btnStockAdjustment.Corners.All = 3
            Me.btnStockAdjustment.Corners.LowerLeft = 3
            Me.btnStockAdjustment.Corners.LowerRight = 3
            Me.btnStockAdjustment.Corners.UpperLeft = 3
            Me.btnStockAdjustment.Corners.UpperRight = 3
            Me.btnStockAdjustment.DesignerSelected = False
            Me.btnStockAdjustment.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnStockAdjustment.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnStockAdjustment.Image = CType(componentResourceManager.GetObject("btnStockAdjustment.Image"), System.Drawing.Image)
            Me.btnStockAdjustment.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnStockAdjustment.ImageIndex = 0
            Dim cButton116 As CButtonLib.CButton = Me.btnStockAdjustment
            size = New System.Drawing.Size(50, 50)
            cButton116.ImageSize = size
            Dim cButton117 As CButtonLib.CButton = Me.btnStockAdjustment
            location = New System.Drawing.Point(556, 309)
            cButton117.Location = location
            Dim cButton118 As CButtonLib.CButton = Me.btnStockAdjustment
            margin = New System.Windows.Forms.Padding(1)
            cButton118.Margin = margin
            Me.btnStockAdjustment.Name = "btnStockAdjustment"
            Dim cButton119 As CButtonLib.CButton = Me.btnStockAdjustment
            size = New System.Drawing.Size(184, 75)
            cButton119.Size = size
            Me.btnStockAdjustment.TabIndex = 64
            Me.btnStockAdjustment.Text = "Stock Adjustment"
            Me.btnStockAdjustment.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnStockAdjustment.TextShadowShow = False
            Me.btnStockAdjustment.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.BtnVoucher.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.BtnVoucher.BackColor = System.Drawing.Color.Transparent
            Me.BtnVoucher.BorderColor = System.Drawing.Color.Transparent
            cBlendItems30.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56)}
            cBlendItems30.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.BtnVoucher.ColorFillBlend = cBlendItems30
            Me.BtnVoucher.Corners.All = 3
            Me.BtnVoucher.Corners.LowerLeft = 3
            Me.BtnVoucher.Corners.LowerRight = 3
            Me.BtnVoucher.Corners.UpperLeft = 3
            Me.BtnVoucher.Corners.UpperRight = 3
            Me.BtnVoucher.DesignerSelected = False
            Me.BtnVoucher.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.BtnVoucher.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.BtnVoucher.Image = CType(componentResourceManager.GetObject("BtnVoucher.Image"), System.Drawing.Image)
            Me.BtnVoucher.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.BtnVoucher.ImageIndex = 0
            Dim btnVoucher As CButtonLib.CButton = Me.BtnVoucher
            size = New System.Drawing.Size(50, 50)
            btnVoucher.ImageSize = size
            Dim btnVoucher2 As CButtonLib.CButton = Me.BtnVoucher
            location = New System.Drawing.Point(1, 386)
            btnVoucher2.Location = location
            Dim btnVoucher3 As CButtonLib.CButton = Me.BtnVoucher
            margin = New System.Windows.Forms.Padding(1)
            btnVoucher3.Margin = margin
            Me.BtnVoucher.Name = "BtnVoucher"
            Dim btnVoucher4 As CButtonLib.CButton = Me.BtnVoucher
            size = New System.Drawing.Size(183, 75)
            btnVoucher4.Size = size
            Me.BtnVoucher.TabIndex = 46
            Me.BtnVoucher.Text = "Voucher/Expense"
            Me.BtnVoucher.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.BtnVoucher.TextShadowShow = False
            Me.BtnVoucher.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnRecipe.BackColor = System.Drawing.Color.Transparent
            Me.btnRecipe.BorderColor = System.Drawing.Color.Transparent
            cBlendItems31.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56)}
            cBlendItems31.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnRecipe.ColorFillBlend = cBlendItems31
            Me.btnRecipe.Corners.All = 3
            Me.btnRecipe.Corners.LowerLeft = 3
            Me.btnRecipe.Corners.LowerRight = 3
            Me.btnRecipe.Corners.UpperLeft = 3
            Me.btnRecipe.Corners.UpperRight = 3
            Me.btnRecipe.DesignerSelected = False
            Me.btnRecipe.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnRecipe.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnRecipe.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnRecipe.Image = CType(componentResourceManager.GetObject("btnRecipe.Image"), System.Drawing.Image)
            Me.btnRecipe.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnRecipe.ImageIndex = 0
            Dim cButton120 As CButtonLib.CButton = Me.btnRecipe
            size = New System.Drawing.Size(50, 50)
            cButton120.ImageSize = size
            Dim cButton121 As CButtonLib.CButton = Me.btnRecipe
            location = New System.Drawing.Point(371, 386)
            cButton121.Location = location
            Dim cButton122 As CButtonLib.CButton = Me.btnRecipe
            margin = New System.Windows.Forms.Padding(1)
            cButton122.Margin = margin
            Me.btnRecipe.Name = "btnRecipe"
            Dim cButton123 As CButtonLib.CButton = Me.btnRecipe
            size = New System.Drawing.Size(183, 75)
            cButton123.Size = size
            Me.btnRecipe.TabIndex = 36
            Me.btnRecipe.Text = "Recipe"
            Me.btnRecipe.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnRecipe.TextShadowShow = False
            Me.btnRecipe.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnHomeDelivery.BackColor = System.Drawing.Color.Transparent
            Me.btnHomeDelivery.BorderColor = System.Drawing.Color.Transparent
            cBlendItems32.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56)}
            cBlendItems32.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnHomeDelivery.ColorFillBlend = cBlendItems32
            Me.btnHomeDelivery.Corners.All = 3
            Me.btnHomeDelivery.Corners.LowerLeft = 3
            Me.btnHomeDelivery.Corners.LowerRight = 3
            Me.btnHomeDelivery.Corners.UpperLeft = 3
            Me.btnHomeDelivery.Corners.UpperRight = 3
            Me.btnHomeDelivery.DesignerSelected = False
            Me.btnHomeDelivery.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnHomeDelivery.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnHomeDelivery.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnHomeDelivery.Image = CType(componentResourceManager.GetObject("btnHomeDelivery.Image"), System.Drawing.Image)
            Me.btnHomeDelivery.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnHomeDelivery.ImageIndex = 0
            Dim cButton124 As CButtonLib.CButton = Me.btnHomeDelivery
            size = New System.Drawing.Size(50, 50)
            cButton124.ImageSize = size
            Dim cButton125 As CButtonLib.CButton = Me.btnHomeDelivery
            location = New System.Drawing.Point(186, 386)
            cButton125.Location = location
            Dim cButton126 As CButtonLib.CButton = Me.btnHomeDelivery
            margin = New System.Windows.Forms.Padding(1)
            cButton126.Margin = margin
            Me.btnHomeDelivery.Name = "btnHomeDelivery"
            Dim cButton127 As CButtonLib.CButton = Me.btnHomeDelivery
            size = New System.Drawing.Size(183, 75)
            cButton127.Size = size
            Me.btnHomeDelivery.TabIndex = 48
            Me.btnHomeDelivery.Text = "Home Delivery"
            Me.btnHomeDelivery.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnHomeDelivery.TextShadowShow = False
            Me.btnHomeDelivery.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnKeyboard.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
            Me.btnKeyboard.BackColor = System.Drawing.Color.Transparent
            Me.btnKeyboard.BorderColor = System.Drawing.Color.Transparent
            cBlendItems33.iColor = New System.Drawing.Color(2) {System.Drawing.Color.AliceBlue, System.Drawing.Color.Navy, System.Drawing.Color.Navy}
            cBlendItems33.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnKeyboard.ColorFillBlend = cBlendItems33
            Me.btnKeyboard.Corners.All = 5
            Me.btnKeyboard.Corners.LowerLeft = 5
            Me.btnKeyboard.Corners.LowerRight = 5
            Me.btnKeyboard.Corners.UpperLeft = 5
            Me.btnKeyboard.Corners.UpperRight = 5
            Me.btnKeyboard.DesignerSelected = False
            Me.btnKeyboard.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnKeyboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnKeyboard.Image = CType(componentResourceManager.GetObject("btnKeyboard.Image"), System.Drawing.Image)
            Me.btnKeyboard.ImageIndex = 0
            Dim cButton128 As CButtonLib.CButton = Me.btnKeyboard
            size = New System.Drawing.Size(64, 64)
            cButton128.ImageSize = size
            Dim cButton129 As CButtonLib.CButton = Me.btnKeyboard
            location = New System.Drawing.Point(750, 2)
            cButton129.Location = location
            Me.btnKeyboard.Name = "btnKeyboard"
            Dim cButton130 As CButtonLib.CButton = Me.btnKeyboard
            size = New System.Drawing.Size(52, 49)
            cButton130.Size = size
            Me.btnKeyboard.TabIndex = 58
            Me.btnKeyboard.Text = ""
            Me.btnKeyboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnKeyboard.TextShadowShow = False
            Me.btnMinimize.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
            Me.btnMinimize.BackColor = System.Drawing.Color.Transparent
            Me.btnMinimize.BorderColor = System.Drawing.Color.Transparent
            cBlendItems34.iColor = New System.Drawing.Color(2) {System.Drawing.Color.AliceBlue, System.Drawing.Color.Navy, System.Drawing.Color.Navy}
            cBlendItems34.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnMinimize.ColorFillBlend = cBlendItems34
            Me.btnMinimize.Corners.All = 5
            Me.btnMinimize.Corners.LowerLeft = 5
            Me.btnMinimize.Corners.LowerRight = 5
            Me.btnMinimize.Corners.UpperLeft = 5
            Me.btnMinimize.Corners.UpperRight = 5
            Me.btnMinimize.DesignerSelected = False
            Me.btnMinimize.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnMinimize.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnMinimize.Image = CType(componentResourceManager.GetObject("btnMinimize.Image"), System.Drawing.Image)
            Me.btnMinimize.ImageIndex = 0
            Dim cButton131 As CButtonLib.CButton = Me.btnMinimize
            size = New System.Drawing.Size(64, 64)
            cButton131.ImageSize = size
            Dim cButton132 As CButtonLib.CButton = Me.btnMinimize
            location = New System.Drawing.Point(806, 2)
            cButton132.Location = location
            Me.btnMinimize.Name = "btnMinimize"
            Dim cButton133 As CButtonLib.CButton = Me.btnMinimize
            size = New System.Drawing.Size(52, 49)
            cButton133.Size = size
            Me.btnMinimize.TabIndex = 35
            Me.btnMinimize.Text = ""
            Me.btnMinimize.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnMinimize.TextShadowShow = False
            Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
            Me.btnCancel.BackColor = System.Drawing.Color.Transparent
            Me.btnCancel.BorderColor = System.Drawing.Color.Transparent
            cBlendItems35.iColor = New System.Drawing.Color(2) {System.Drawing.Color.AliceBlue, System.Drawing.Color.Navy, System.Drawing.Color.Navy}
            cBlendItems35.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnCancel.ColorFillBlend = cBlendItems35
            Me.btnCancel.Corners.All = 5
            Me.btnCancel.Corners.LowerLeft = 5
            Me.btnCancel.Corners.LowerRight = 5
            Me.btnCancel.Corners.UpperLeft = 5
            Me.btnCancel.Corners.UpperRight = 5
            Me.btnCancel.DesignerSelected = False
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnCancel.Image = CType(componentResourceManager.GetObject("btnCancel.Image"), System.Drawing.Image)
            Me.btnCancel.ImageIndex = 0
            Dim cButton134 As CButtonLib.CButton = Me.btnCancel
            size = New System.Drawing.Size(64, 64)
            cButton134.ImageSize = size
            Dim cButton135 As CButtonLib.CButton = Me.btnCancel
            location = New System.Drawing.Point(863, 2)
            cButton135.Location = location
            Me.btnCancel.Name = "btnCancel"
            Dim cButton136 As CButtonLib.CButton = Me.btnCancel
            size = New System.Drawing.Size(52, 49)
            cButton136.Size = size
            Me.btnCancel.TabIndex = 29
            Me.btnCancel.Text = ""
            Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnCancel.TextShadowShow = False
            Me.lblUserType.AutoSize = True
            Dim label7 As System.Windows.Forms.Label = Me.lblUserType
            location = New System.Drawing.Point(651, 77)
            label7.Location = location
            Me.lblUserType.Name = "lblUserType"
            Dim label8 As System.Windows.Forms.Label = Me.lblUserType
            size = New System.Drawing.Size(53, 13)
            label8.Size = size
            Me.lblUserType.TabIndex = 59
            Me.lblUserType.Text = "UserType"
            Me.lblUserType.Visible = False
            Me.RadClock1.BackColor = System.Drawing.Color.Transparent
            Dim radClock As Telerik.WinControls.UI.RadClock = Me.RadClock1
            location = New System.Drawing.Point(2, 52)
            radClock.Location = location
            Me.RadClock1.Name = "RadClock1"
            Dim radClock2 As Telerik.WinControls.UI.RadClock = Me.RadClock1
            size = New System.Drawing.Size(134, 135)
            radClock2.Size = size
            Me.RadClock1.TabIndex = 407
            Me.RadClock1.ThemeName = "Aqua"
            Me.TableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left
            Me.TableLayoutPanel3.BackColor = System.Drawing.Color.Transparent
            Me.TableLayoutPanel3.ColumnCount = 1
            Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F))
            Me.TableLayoutPanel3.Controls.Add(Me.btnNotepad, 0, 0)
            Me.TableLayoutPanel3.Controls.Add(Me.btnWordpad, 0, 1)
            Me.TableLayoutPanel3.Controls.Add(Me.btnCalculator, 0, 2)
            Me.TableLayoutPanel3.Controls.Add(Me.btnMSWord, 0, 3)
            Me.TableLayoutPanel3.Controls.Add(Me.btnTaskManager, 0, 4)
            Me.TableLayoutPanel3.Controls.Add(Me.btnOSKeyboard, 0, 5)
            Me.TableLayoutPanel3.Controls.Add(Me.btnPaint, 0, 6)
            Me.TableLayoutPanel3.Controls.Add(Me.btnSysInfo, 0, 7)
            Me.TableLayoutPanel3.Controls.Add(Me.btnLogout, 0, 8)
            Dim tableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel = Me.TableLayoutPanel3
            location = New System.Drawing.Point(1, 198)
            tableLayoutPanel3.Location = location
            Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
            Me.TableLayoutPanel3.RowCount = 9
            Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F))
            Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F))
            Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F))
            Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F))
            Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F))
            Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F))
            Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F))
            Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F))
            Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F))
            Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F))
            Dim tableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel = Me.TableLayoutPanel3
            size = New System.Drawing.Size(79, 539)
            tableLayoutPanel4.Size = size
            Me.TableLayoutPanel3.TabIndex = 408
            Me.btnNotepad.BackColor = System.Drawing.Color.Transparent
            Me.btnNotepad.BorderShow = False
            cBlendItems36.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56)}
            cBlendItems36.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnNotepad.ColorFillBlend = cBlendItems36
            Me.btnNotepad.Corners.All = 5
            Me.btnNotepad.Corners.LowerLeft = 5
            Me.btnNotepad.Corners.LowerRight = 5
            Me.btnNotepad.Corners.UpperLeft = 5
            Me.btnNotepad.Corners.UpperRight = 5
            Me.btnNotepad.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnNotepad.DesignerSelected = False
            Me.btnNotepad.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnNotepad.FillTypeLinear = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
            Me.btnNotepad.Font = New System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnNotepad.Image = CType(componentResourceManager.GetObject("btnNotepad.Image"), System.Drawing.Image)
            Me.btnNotepad.ImageIndex = 0
            Dim cButton137 As CButtonLib.CButton = Me.btnNotepad
            size = New System.Drawing.Size(32, 32)
            cButton137.ImageSize = size
            Dim cButton138 As CButtonLib.CButton = Me.btnNotepad
            location = New System.Drawing.Point(3, 3)
            cButton138.Location = location
            Me.btnNotepad.Name = "btnNotepad"
            Dim cButton139 As CButtonLib.CButton = Me.btnNotepad
            size = New System.Drawing.Size(73, 53)
            cButton139.Size = size
            Me.btnNotepad.TabIndex = 403
            Me.btnNotepad.TabStop = False
            Me.btnNotepad.Text = ""
            Me.btnNotepad.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnWordpad.BackColor = System.Drawing.Color.Transparent
            Me.btnWordpad.BorderShow = False
            cBlendItems37.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56)}
            cBlendItems37.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnWordpad.ColorFillBlend = cBlendItems37
            Me.btnWordpad.Corners.All = 5
            Me.btnWordpad.Corners.LowerLeft = 5
            Me.btnWordpad.Corners.LowerRight = 5
            Me.btnWordpad.Corners.UpperLeft = 5
            Me.btnWordpad.Corners.UpperRight = 5
            Me.btnWordpad.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnWordpad.DesignerSelected = False
            Me.btnWordpad.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnWordpad.FillTypeLinear = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
            Me.btnWordpad.Font = New System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnWordpad.Image = CType(componentResourceManager.GetObject("btnWordpad.Image"), System.Drawing.Image)
            Me.btnWordpad.ImageIndex = 0
            Dim cButton140 As CButtonLib.CButton = Me.btnWordpad
            size = New System.Drawing.Size(32, 32)
            cButton140.ImageSize = size
            Dim cButton141 As CButtonLib.CButton = Me.btnWordpad
            location = New System.Drawing.Point(3, 62)
            cButton141.Location = location
            Me.btnWordpad.Name = "btnWordpad"
            Dim cButton142 As CButtonLib.CButton = Me.btnWordpad
            size = New System.Drawing.Size(73, 53)
            cButton142.Size = size
            Me.btnWordpad.TabIndex = 399
            Me.btnWordpad.TabStop = False
            Me.btnWordpad.Text = ""
            Me.btnWordpad.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnCalculator.BackColor = System.Drawing.Color.Transparent
            Me.btnCalculator.BorderShow = False
            cBlendItems38.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56)}
            cBlendItems38.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnCalculator.ColorFillBlend = cBlendItems38
            Me.btnCalculator.Corners.All = 5
            Me.btnCalculator.Corners.LowerLeft = 5
            Me.btnCalculator.Corners.LowerRight = 5
            Me.btnCalculator.Corners.UpperLeft = 5
            Me.btnCalculator.Corners.UpperRight = 5
            Me.btnCalculator.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnCalculator.DesignerSelected = False
            Me.btnCalculator.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnCalculator.FillTypeLinear = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
            Me.btnCalculator.Font = New System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnCalculator.Image = CType(componentResourceManager.GetObject("btnCalculator.Image"), System.Drawing.Image)
            Me.btnCalculator.ImageIndex = 0
            Dim cButton143 As CButtonLib.CButton = Me.btnCalculator
            size = New System.Drawing.Size(32, 32)
            cButton143.ImageSize = size
            Dim cButton144 As CButtonLib.CButton = Me.btnCalculator
            location = New System.Drawing.Point(3, 121)
            cButton144.Location = location
            Me.btnCalculator.Name = "btnCalculator"
            Dim cButton145 As CButtonLib.CButton = Me.btnCalculator
            size = New System.Drawing.Size(73, 53)
            cButton145.Size = size
            Me.btnCalculator.TabIndex = 400
            Me.btnCalculator.TabStop = False
            Me.btnCalculator.Text = ""
            Me.btnCalculator.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnMSWord.BackColor = System.Drawing.Color.Transparent
            Me.btnMSWord.BorderShow = False
            cBlendItems39.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56)}
            cBlendItems39.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnMSWord.ColorFillBlend = cBlendItems39
            Me.btnMSWord.Corners.All = 5
            Me.btnMSWord.Corners.LowerLeft = 5
            Me.btnMSWord.Corners.LowerRight = 5
            Me.btnMSWord.Corners.UpperLeft = 5
            Me.btnMSWord.Corners.UpperRight = 5
            Me.btnMSWord.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnMSWord.DesignerSelected = False
            Me.btnMSWord.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnMSWord.FillTypeLinear = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
            Me.btnMSWord.Font = New System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnMSWord.Image = CType(componentResourceManager.GetObject("btnMSWord.Image"), System.Drawing.Image)
            Me.btnMSWord.ImageIndex = 0
            Dim cButton146 As CButtonLib.CButton = Me.btnMSWord
            size = New System.Drawing.Size(32, 32)
            cButton146.ImageSize = size
            Dim cButton147 As CButtonLib.CButton = Me.btnMSWord
            location = New System.Drawing.Point(3, 180)
            cButton147.Location = location
            Me.btnMSWord.Name = "btnMSWord"
            Dim cButton148 As CButtonLib.CButton = Me.btnMSWord
            size = New System.Drawing.Size(73, 53)
            cButton148.Size = size
            Me.btnMSWord.TabIndex = 396
            Me.btnMSWord.TabStop = False
            Me.btnMSWord.Text = ""
            Me.btnMSWord.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnTaskManager.BackColor = System.Drawing.Color.Transparent
            Me.btnTaskManager.BorderShow = False
            cBlendItems40.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56)}
            cBlendItems40.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnTaskManager.ColorFillBlend = cBlendItems40
            Me.btnTaskManager.Corners.All = 5
            Me.btnTaskManager.Corners.LowerLeft = 5
            Me.btnTaskManager.Corners.LowerRight = 5
            Me.btnTaskManager.Corners.UpperLeft = 5
            Me.btnTaskManager.Corners.UpperRight = 5
            Me.btnTaskManager.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnTaskManager.DesignerSelected = False
            Me.btnTaskManager.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnTaskManager.FillTypeLinear = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
            Me.btnTaskManager.Font = New System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnTaskManager.Image = CType(componentResourceManager.GetObject("btnTaskManager.Image"), System.Drawing.Image)
            Me.btnTaskManager.ImageIndex = 0
            Dim cButton149 As CButtonLib.CButton = Me.btnTaskManager
            size = New System.Drawing.Size(32, 32)
            cButton149.ImageSize = size
            Dim cButton150 As CButtonLib.CButton = Me.btnTaskManager
            location = New System.Drawing.Point(3, 239)
            cButton150.Location = location
            Me.btnTaskManager.Name = "btnTaskManager"
            Dim cButton151 As CButtonLib.CButton = Me.btnTaskManager
            size = New System.Drawing.Size(73, 53)
            cButton151.Size = size
            Me.btnTaskManager.TabIndex = 395
            Me.btnTaskManager.TabStop = False
            Me.btnTaskManager.Text = ""
            Me.btnTaskManager.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnOSKeyboard.BackColor = System.Drawing.Color.Transparent
            Me.btnOSKeyboard.BorderShow = False
            cBlendItems41.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56)}
            cBlendItems41.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnOSKeyboard.ColorFillBlend = cBlendItems41
            Me.btnOSKeyboard.Corners.All = 5
            Me.btnOSKeyboard.Corners.LowerLeft = 5
            Me.btnOSKeyboard.Corners.LowerRight = 5
            Me.btnOSKeyboard.Corners.UpperLeft = 5
            Me.btnOSKeyboard.Corners.UpperRight = 5
            Me.btnOSKeyboard.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnOSKeyboard.DesignerSelected = False
            Me.btnOSKeyboard.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnOSKeyboard.FillTypeLinear = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
            Me.btnOSKeyboard.Font = New System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnOSKeyboard.Image = CType(componentResourceManager.GetObject("btnOSKeyboard.Image"), System.Drawing.Image)
            Me.btnOSKeyboard.ImageIndex = 0
            Dim cButton152 As CButtonLib.CButton = Me.btnOSKeyboard
            size = New System.Drawing.Size(32, 32)
            cButton152.ImageSize = size
            Dim cButton153 As CButtonLib.CButton = Me.btnOSKeyboard
            location = New System.Drawing.Point(3, 298)
            cButton153.Location = location
            Me.btnOSKeyboard.Name = "btnOSKeyboard"
            Dim cButton154 As CButtonLib.CButton = Me.btnOSKeyboard
            size = New System.Drawing.Size(73, 53)
            cButton154.Size = size
            Me.btnOSKeyboard.TabIndex = 393
            Me.btnOSKeyboard.TabStop = False
            Me.btnOSKeyboard.Text = ""
            Me.btnOSKeyboard.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnPaint.BackColor = System.Drawing.Color.Transparent
            Me.btnPaint.BorderShow = False
            cBlendItems42.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56)}
            cBlendItems42.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnPaint.ColorFillBlend = cBlendItems42
            Me.btnPaint.Corners.All = 5
            Me.btnPaint.Corners.LowerLeft = 5
            Me.btnPaint.Corners.LowerRight = 5
            Me.btnPaint.Corners.UpperLeft = 5
            Me.btnPaint.Corners.UpperRight = 5
            Me.btnPaint.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnPaint.DesignerSelected = False
            Me.btnPaint.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnPaint.FillTypeLinear = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
            Me.btnPaint.Font = New System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnPaint.Image = CType(componentResourceManager.GetObject("btnPaint.Image"), System.Drawing.Image)
            Me.btnPaint.ImageIndex = 0
            Dim cButton155 As CButtonLib.CButton = Me.btnPaint
            size = New System.Drawing.Size(32, 32)
            cButton155.ImageSize = size
            Dim cButton156 As CButtonLib.CButton = Me.btnPaint
            location = New System.Drawing.Point(3, 357)
            cButton156.Location = location
            Me.btnPaint.Name = "btnPaint"
            Dim cButton157 As CButtonLib.CButton = Me.btnPaint
            size = New System.Drawing.Size(73, 53)
            cButton157.Size = size
            Me.btnPaint.TabIndex = 391
            Me.btnPaint.TabStop = False
            Me.btnPaint.Text = ""
            Me.btnPaint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnSysInfo.BackColor = System.Drawing.Color.Transparent
            Me.btnSysInfo.BorderShow = False
            cBlendItems43.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56)}
            cBlendItems43.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnSysInfo.ColorFillBlend = cBlendItems43
            Me.btnSysInfo.Corners.All = 5
            Me.btnSysInfo.Corners.LowerLeft = 5
            Me.btnSysInfo.Corners.LowerRight = 5
            Me.btnSysInfo.Corners.UpperLeft = 5
            Me.btnSysInfo.Corners.UpperRight = 5
            Me.btnSysInfo.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnSysInfo.DesignerSelected = False
            Me.btnSysInfo.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnSysInfo.FillTypeLinear = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
            Me.btnSysInfo.Font = New System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnSysInfo.Image = CType(componentResourceManager.GetObject("btnSysInfo.Image"), System.Drawing.Image)
            Me.btnSysInfo.ImageIndex = 0
            Dim cButton158 As CButtonLib.CButton = Me.btnSysInfo
            size = New System.Drawing.Size(32, 32)
            cButton158.ImageSize = size
            Dim cButton159 As CButtonLib.CButton = Me.btnSysInfo
            location = New System.Drawing.Point(3, 416)
            cButton159.Location = location
            Me.btnSysInfo.Name = "btnSysInfo"
            Dim cButton160 As CButtonLib.CButton = Me.btnSysInfo
            size = New System.Drawing.Size(73, 53)
            cButton160.Size = size
            Me.btnSysInfo.TabIndex = 389
            Me.btnSysInfo.TabStop = False
            Me.btnSysInfo.Text = ""
            Me.btnSysInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnLogout.BackColor = System.Drawing.Color.Transparent
            Me.btnLogout.BorderShow = False
            cBlendItems44.iColor = New System.Drawing.Color(2) {System.Drawing.Color.Crimson, System.Drawing.Color.Crimson, System.Drawing.Color.Crimson}
            cBlendItems44.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnLogout.ColorFillBlend = cBlendItems44
            Me.btnLogout.Corners.All = 5
            Me.btnLogout.Corners.LowerLeft = 5
            Me.btnLogout.Corners.LowerRight = 5
            Me.btnLogout.Corners.UpperLeft = 5
            Me.btnLogout.Corners.UpperRight = 5
            Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnLogout.DesignerSelected = False
            Me.btnLogout.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnLogout.FillTypeLinear = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
            Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnLogout.Image = CType(componentResourceManager.GetObject("btnLogout.Image"), System.Drawing.Image)
            Me.btnLogout.ImageIndex = 0
            Dim cButton161 As CButtonLib.CButton = Me.btnLogout
            size = New System.Drawing.Size(32, 32)
            cButton161.ImageSize = size
            Dim cButton162 As CButtonLib.CButton = Me.btnLogout
            location = New System.Drawing.Point(3, 475)
            cButton162.Location = location
            Me.btnLogout.Name = "btnLogout"
            Dim cButton163 As CButtonLib.CButton = Me.btnLogout
            size = New System.Drawing.Size(73, 61)
            cButton163.Size = size
            Me.btnLogout.TabIndex = 17
            Me.btnLogout.TabStop = False
            Me.btnLogout.Text = ""
            Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.Honeydew
            Me.BackgroundImage = CType(componentResourceManager.GetObject("$this.BackgroundImage"), System.Drawing.Image)
            Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            size = New System.Drawing.Size(916, 738)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.TableLayoutPanel3)
            MyBase.Controls.Add(Me.TableLayoutPanel1)
            MyBase.Controls.Add(Me.RadClock1)
            MyBase.Controls.Add(Me.lblUserType)
            MyBase.Controls.Add(Me.btnKeyboard)
            MyBase.Controls.Add(Me.btnMinimize)
            MyBase.Controls.Add(Me.btnCancel)
            MyBase.Controls.Add(Me.Panel1)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.Name = "frmBackOffice"
            MyBase.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.TableLayoutPanel1.ResumeLayout(False)
            CType(Me.RadClock1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TableLayoutPanel3.ResumeLayout(False)
            MyBase.ResumeLayout(False)
            MyBase.PerformLayout()
        End Sub
    End Class
End Namespace
