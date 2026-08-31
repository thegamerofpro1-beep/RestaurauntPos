Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Text
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports CButtonLib
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports RestaurantPOS14.My

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public Class frmAccountingReport
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel1")>
        Private _Panel1 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel2")>
        Private _Panel2 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label1")>
        Private _Label1 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel5")>
        Private _Panel5 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnClose")>
        Private _btnClose As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnReset")>
        Private _btnReset As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnPurchaseDaybook")>
        Private _btnPurchaseDaybook As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("dtpDateTo")>
        Private _dtpDateTo As System.Windows.Forms.DateTimePicker

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("dtpDateFrom")>
        Private _dtpDateFrom As System.Windows.Forms.DateTimePicker

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label2")>
        Private _Label2 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label4")>
        Private _Label4 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Timer1")>
        Private _Timer1 As System.Windows.Forms.Timer

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox1")>
        Private _GroupBox1 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtCashBook")>
        Private _txtCashBook As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnSupplierLedger")>
        Private _btnSupplierLedger As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnPurchase")>
        Private _btnPurchase As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnTrialBalance")>
        Private _btnTrialBalance As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DateTimePicker1")>
        Private _DateTimePicker1 As System.Windows.Forms.DateTimePicker

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnGeneralDaybook")>
        Private _btnGeneralDaybook As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnVouchers")>
        Private _btnVouchers As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox4")>
        Private _GroupBox4 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox3")>
        Private _GroupBox3 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox2")>
        Private _GroupBox2 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("cmbSupplierName")>
        Private _cmbSupplierName As System.Windows.Forms.ComboBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label3")>
        Private _Label3 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DateTimePicker2")>
        Private _DateTimePicker2 As System.Windows.Forms.DateTimePicker

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label5")>
        Private _Label5 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label6")>
        Private _Label6 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DateTimePicker3")>
        Private _DateTimePicker3 As System.Windows.Forms.DateTimePicker

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtSupplierID")>
        Private _txtSupplierID As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel3")>
        Private _Panel3 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnCreditors")>
        Private _btnCreditors As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnStockTransfer")>
        Private _btnStockTransfer As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnStockIN")>
        Private _btnStockIN As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnStockOut")>
        Private _btnStockOut As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnLowStock")>
        Private _btnLowStock As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnExpiredProducts")>
        Private _btnExpiredProducts As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox6")>
        Private _GroupBox6 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnStoreStockOUT")>
        Private _btnStoreStockOUT As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnStoreStockIN")>
        Private _btnStoreStockIN As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox5")>
        Private _GroupBox5 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox7")>
        Private _GroupBox7 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnStockOut_RM")>
        Private _btnStockOut_RM As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnStockIn_RM")>
        Private _btnStockIn_RM As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnCollectionsByDP")>
        Private _btnCollectionsByDP As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnTaxReport")>
        Private _btnTaxReport As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnGeneralLedger")>
        Private _btnGeneralLedger As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnStockUsed")>
        Private _btnStockUsed As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnInputTax")>
        Private _btnInputTax As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnBalanceSheet")>
        Private _btnBalanceSheet As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnJournalEntry")>
        Private _btnJournalEntry As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblUser")>
        Private _lblUser As System.Windows.Forms.Label

        Private a As Decimal

        Private d As String

        Private b As String

        Private c As String

        Private OBC As Double

        Private OBB As Double

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

        Friend Overridable Property Panel2 As System.Windows.Forms.Panel
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Panel2
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Panel)
                Me._Panel2 = value
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

        Friend Overridable Property Panel5 As System.Windows.Forms.Panel
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Panel5
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Panel)
                Me._Panel5 = value
            End Set
        End Property

        Friend Overridable Property btnClose As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnClose
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnClose_Click
                If Me._btnClose IsNot Nothing Then
                    RemoveHandler Me._btnClose.Click, value2
                End If

                Me._btnClose = value
                If Me._btnClose IsNot Nothing Then
                    AddHandler Me._btnClose.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnReset As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnReset
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnReset_Click
                If Me._btnReset IsNot Nothing Then
                    RemoveHandler Me._btnReset.Click, value2
                End If

                Me._btnReset = value
                If Me._btnReset IsNot Nothing Then
                    AddHandler Me._btnReset.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnPurchaseDaybook As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnPurchaseDaybook
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnExportExcel_Click
                If Me._btnPurchaseDaybook IsNot Nothing Then
                    RemoveHandler Me._btnPurchaseDaybook.Click, value2
                End If

                Me._btnPurchaseDaybook = value
                If Me._btnPurchaseDaybook IsNot Nothing Then
                    AddHandler Me._btnPurchaseDaybook.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property dtpDateTo As System.Windows.Forms.DateTimePicker
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._dtpDateTo
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DateTimePicker)
                Me._dtpDateTo = value
            End Set
        End Property

        Friend Overridable Property dtpDateFrom As System.Windows.Forms.DateTimePicker
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._dtpDateFrom
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DateTimePicker)
                Me._dtpDateFrom = value
            End Set
        End Property

        Friend Overridable Property Label2 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label2
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label2 = value
            End Set
        End Property

        Friend Overridable Property Label4 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label4
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label4 = value
            End Set
        End Property

        Friend Overridable Property Timer1 As System.Windows.Forms.Timer
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Timer1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Timer)
                Dim value2 As System.EventHandler = AddressOf Me.Timer1_Tick
                If Me._Timer1 IsNot Nothing Then
                    RemoveHandler Me._Timer1.Tick, value2
                End If

                Me._Timer1 = value
                If Me._Timer1 IsNot Nothing Then
                    AddHandler Me._Timer1.Tick, value2
                End If
            End Set
        End Property

        Friend Overridable Property GroupBox1 As System.Windows.Forms.GroupBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._GroupBox1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.GroupBox)
                Me._GroupBox1 = value
            End Set
        End Property

        Friend Overridable Property txtCashBook As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtCashBook
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.Button1_Click
                If Me._txtCashBook IsNot Nothing Then
                    RemoveHandler Me._txtCashBook.Click, value2
                End If

                Me._txtCashBook = value
                If Me._txtCashBook IsNot Nothing Then
                    AddHandler Me._txtCashBook.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnSupplierLedger As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnSupplierLedger
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnSupplierLedger_Click
                If Me._btnSupplierLedger IsNot Nothing Then
                    RemoveHandler Me._btnSupplierLedger.Click, value2
                End If

                Me._btnSupplierLedger = value
                If Me._btnSupplierLedger IsNot Nothing Then
                    AddHandler Me._btnSupplierLedger.Click, value2
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

        Friend Overridable Property btnTrialBalance As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnTrialBalance
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnTrialBalance_Click
                If Me._btnTrialBalance IsNot Nothing Then
                    RemoveHandler Me._btnTrialBalance.Click, value2
                End If

                Me._btnTrialBalance = value
                If Me._btnTrialBalance IsNot Nothing Then
                    AddHandler Me._btnTrialBalance.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property DateTimePicker1 As System.Windows.Forms.DateTimePicker
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._DateTimePicker1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DateTimePicker)
                Me._DateTimePicker1 = value
            End Set
        End Property

        Friend Overridable Property btnGeneralDaybook As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnGeneralDaybook
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnGeneralDaybook_Click
                If Me._btnGeneralDaybook IsNot Nothing Then
                    RemoveHandler Me._btnGeneralDaybook.Click, value2
                End If

                Me._btnGeneralDaybook = value
                If Me._btnGeneralDaybook IsNot Nothing Then
                    AddHandler Me._btnGeneralDaybook.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnVouchers As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnVouchers
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnVouchers_Click
                If Me._btnVouchers IsNot Nothing Then
                    RemoveHandler Me._btnVouchers.Click, value2
                End If

                Me._btnVouchers = value
                If Me._btnVouchers IsNot Nothing Then
                    AddHandler Me._btnVouchers.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property GroupBox4 As System.Windows.Forms.GroupBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._GroupBox4
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.GroupBox)
                Me._GroupBox4 = value
            End Set
        End Property

        Friend Overridable Property GroupBox3 As System.Windows.Forms.GroupBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._GroupBox3
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.GroupBox)
                Me._GroupBox3 = value
            End Set
        End Property

        Friend Overridable Property GroupBox2 As System.Windows.Forms.GroupBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._GroupBox2
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.GroupBox)
                Me._GroupBox2 = value
            End Set
        End Property

        Friend Overridable Property cmbSupplierName As System.Windows.Forms.ComboBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._cmbSupplierName
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ComboBox)
                Dim value2 As System.EventHandler = AddressOf Me.cmbSupplierName_SelectedIndexChanged
                If Me._cmbSupplierName IsNot Nothing Then
                    RemoveHandler Me._cmbSupplierName.SelectedIndexChanged, value2
                End If

                Me._cmbSupplierName = value
                If Me._cmbSupplierName IsNot Nothing Then
                    AddHandler Me._cmbSupplierName.SelectedIndexChanged, value2
                End If
            End Set
        End Property

        Friend Overridable Property Label3 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label3
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label3 = value
            End Set
        End Property

        Friend Overridable Property DateTimePicker2 As System.Windows.Forms.DateTimePicker
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._DateTimePicker2
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DateTimePicker)
                Me._DateTimePicker2 = value
            End Set
        End Property

        Friend Overridable Property Label5 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label5
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label5 = value
            End Set
        End Property

        Friend Overridable Property Label6 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label6
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label6 = value
            End Set
        End Property

        Friend Overridable Property DateTimePicker3 As System.Windows.Forms.DateTimePicker
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._DateTimePicker3
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DateTimePicker)
                Me._DateTimePicker3 = value
            End Set
        End Property

        Friend Overridable Property txtSupplierID As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtSupplierID
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtSupplierID = value
            End Set
        End Property

        Friend Overridable Property Panel3 As System.Windows.Forms.Panel
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Panel3
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Panel)
                Me._Panel3 = value
            End Set
        End Property

        Friend Overridable Property btnCreditors As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnCreditors
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnCreditors_Click
                If Me._btnCreditors IsNot Nothing Then
                    RemoveHandler Me._btnCreditors.Click, value2
                End If

                Me._btnCreditors = value
                If Me._btnCreditors IsNot Nothing Then
                    AddHandler Me._btnCreditors.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnStockTransfer As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnStockTransfer
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnStockTransfer_Click
                If Me._btnStockTransfer IsNot Nothing Then
                    RemoveHandler Me._btnStockTransfer.Click, value2
                End If

                Me._btnStockTransfer = value
                If Me._btnStockTransfer IsNot Nothing Then
                    AddHandler Me._btnStockTransfer.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnStockIN As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnStockIN
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnStockIN_Click
                If Me._btnStockIN IsNot Nothing Then
                    RemoveHandler Me._btnStockIN.Click, value2
                End If

                Me._btnStockIN = value
                If Me._btnStockIN IsNot Nothing Then
                    AddHandler Me._btnStockIN.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnStockOut As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnStockOut
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnStockOut_Click
                If Me._btnStockOut IsNot Nothing Then
                    RemoveHandler Me._btnStockOut.Click, value2
                End If

                Me._btnStockOut = value
                If Me._btnStockOut IsNot Nothing Then
                    AddHandler Me._btnStockOut.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnLowStock As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnLowStock
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnLowStock_Click
                If Me._btnLowStock IsNot Nothing Then
                    RemoveHandler Me._btnLowStock.Click, value2
                End If

                Me._btnLowStock = value
                If Me._btnLowStock IsNot Nothing Then
                    AddHandler Me._btnLowStock.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnExpiredProducts As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnExpiredProducts
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnExpiredProducts_Click
                If Me._btnExpiredProducts IsNot Nothing Then
                    RemoveHandler Me._btnExpiredProducts.Click, value2
                End If

                Me._btnExpiredProducts = value
                If Me._btnExpiredProducts IsNot Nothing Then
                    AddHandler Me._btnExpiredProducts.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property GroupBox6 As System.Windows.Forms.GroupBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._GroupBox6
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.GroupBox)
                Me._GroupBox6 = value
            End Set
        End Property

        Friend Overridable Property btnStoreStockOUT As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnStoreStockOUT
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnStoreStockOUT_Click
                If Me._btnStoreStockOUT IsNot Nothing Then
                    RemoveHandler Me._btnStoreStockOUT.Click, value2
                End If

                Me._btnStoreStockOUT = value
                If Me._btnStoreStockOUT IsNot Nothing Then
                    AddHandler Me._btnStoreStockOUT.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnStoreStockIN As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnStoreStockIN
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnStoreStockIN_Click
                If Me._btnStoreStockIN IsNot Nothing Then
                    RemoveHandler Me._btnStoreStockIN.Click, value2
                End If

                Me._btnStoreStockIN = value
                If Me._btnStoreStockIN IsNot Nothing Then
                    AddHandler Me._btnStoreStockIN.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property GroupBox5 As System.Windows.Forms.GroupBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._GroupBox5
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.GroupBox)
                Me._GroupBox5 = value
            End Set
        End Property

        Friend Overridable Property GroupBox7 As System.Windows.Forms.GroupBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._GroupBox7
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.GroupBox)
                Me._GroupBox7 = value
            End Set
        End Property

        Friend Overridable Property btnStockOut_RM As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnStockOut_RM
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnStockOut_RM_Click
                If Me._btnStockOut_RM IsNot Nothing Then
                    RemoveHandler Me._btnStockOut_RM.Click, value2
                End If

                Me._btnStockOut_RM = value
                If Me._btnStockOut_RM IsNot Nothing Then
                    AddHandler Me._btnStockOut_RM.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnStockIn_RM As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnStockIn_RM
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnStockIn_RM_Click
                If Me._btnStockIn_RM IsNot Nothing Then
                    RemoveHandler Me._btnStockIn_RM.Click, value2
                End If

                Me._btnStockIn_RM = value
                If Me._btnStockIn_RM IsNot Nothing Then
                    AddHandler Me._btnStockIn_RM.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnCollectionsByDP As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnCollectionsByDP
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnCollectionsByDP_Click
                If Me._btnCollectionsByDP IsNot Nothing Then
                    RemoveHandler Me._btnCollectionsByDP.Click, value2
                End If

                Me._btnCollectionsByDP = value
                If Me._btnCollectionsByDP IsNot Nothing Then
                    AddHandler Me._btnCollectionsByDP.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnTaxReport As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnTaxReport
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnTaxReport_Click
                If Me._btnTaxReport IsNot Nothing Then
                    RemoveHandler Me._btnTaxReport.Click, value2
                End If

                Me._btnTaxReport = value
                If Me._btnTaxReport IsNot Nothing Then
                    AddHandler Me._btnTaxReport.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnGeneralLedger As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnGeneralLedger
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnGeneralLedger_Click
                If Me._btnGeneralLedger IsNot Nothing Then
                    RemoveHandler Me._btnGeneralLedger.Click, value2
                End If

                Me._btnGeneralLedger = value
                If Me._btnGeneralLedger IsNot Nothing Then
                    AddHandler Me._btnGeneralLedger.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnStockUsed As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnStockUsed
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnStockUsed_Click
                If Me._btnStockUsed IsNot Nothing Then
                    RemoveHandler Me._btnStockUsed.Click, value2
                End If

                Me._btnStockUsed = value
                If Me._btnStockUsed IsNot Nothing Then
                    AddHandler Me._btnStockUsed.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnInputTax As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnInputTax
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnInputTax_Click
                If Me._btnInputTax IsNot Nothing Then
                    RemoveHandler Me._btnInputTax.Click, value2
                End If

                Me._btnInputTax = value
                If Me._btnInputTax IsNot Nothing Then
                    AddHandler Me._btnInputTax.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnBalanceSheet As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnBalanceSheet
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnBalanceSheet_Click
                If Me._btnBalanceSheet IsNot Nothing Then
                    RemoveHandler Me._btnBalanceSheet.Click, value2
                End If

                Me._btnBalanceSheet = value
                If Me._btnBalanceSheet IsNot Nothing Then
                    AddHandler Me._btnBalanceSheet.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnJournalEntry As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnJournalEntry
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnJournalEntry_Click
                If Me._btnJournalEntry IsNot Nothing Then
                    RemoveHandler Me._btnJournalEntry.Click, value2
                End If

                Me._btnJournalEntry = value
                If Me._btnJournalEntry IsNot Nothing Then
                    AddHandler Me._btnJournalEntry.Click, value2
                End If
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

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            AddHandler MyBase.Load, AddressOf Me.frmAccountingReport_Load
            Call RestaurantPOS14.frmAccountingReport.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmAccountingReport.__ENCList
                If RestaurantPOS14.frmAccountingReport.__ENCList.Count = RestaurantPOS14.frmAccountingReport.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmAccountingReport.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmAccountingReport.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmAccountingReport.__ENCList(num) = RestaurantPOS14.frmAccountingReport.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmAccountingReport.__ENCList.RemoveRange(num, RestaurantPOS14.frmAccountingReport.__ENCList.Count - num)
                    RestaurantPOS14.frmAccountingReport.__ENCList.Capacity = RestaurantPOS14.frmAccountingReport.__ENCList.Count
                End If

                Call RestaurantPOS14.frmAccountingReport.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Public Sub Reset()
            Me.dtpDateFrom.Value = Microsoft.VisualBasic.DateAndTime.Today
            Me.dtpDateTo.Value = Microsoft.VisualBasic.DateAndTime.Today
            Me.DateTimePicker1.Value = Microsoft.VisualBasic.DateAndTime.Today
            Me.DateTimePicker2.Value = Microsoft.VisualBasic.DateAndTime.Today
            Me.DateTimePicker3.Value = Microsoft.VisualBasic.DateAndTime.Today
            Me.cmbSupplierName.Text = ""
        End Sub

        Public Sub fillSupplier()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.adp = New System.Data.SqlClient.SqlDataAdapter()
                RestaurantPOS14.ModClasses.adp.SelectCommand = New System.Data.SqlClient.SqlCommand("SELECT RTRIM(Name) FROM Supplier", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.ds = New System.Data.DataSet("ds")
                RestaurantPOS14.ModClasses.adp.Fill(RestaurantPOS14.ModClasses.ds)
                RestaurantPOS14.ModClasses.dtable = RestaurantPOS14.ModClasses.ds.Tables(0)
                Me.cmbSupplierName.Items.Clear()
                For Each dataRow As System.Data.DataRow In RestaurantPOS14.ModClasses.dtable.Rows
                    Me.cmbSupplierName.Items.Add(dataRow(CInt((0))).ToString())
                Next
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnReset_Click(sender As Object, e As System.EventArgs)
            Me.Reset()
        End Sub

        Private Sub btnExportExcel_Click(sender As Object, e As System.EventArgs)
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select * from Purchase where Date Between @d2 and @d3")
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.dtpDateFrom.Value.[Date]
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.dtpDateTo.Value.[Date]
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If Not RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Sorry...No record found", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Me.Timer1.Enabled = True
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT ST_ID,Date,InvoiceNo,Name,SubTotal,Discount,FreightCharges,OtherCharges,PreviousDue,GrandTotal from Supplier,Purchase where Supplier.ID=Purchase.Supplier_ID order by [Date]", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.dtpDateFrom.Value.[Date]
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.dtpDateTo.Value.[Date]
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.adp = New System.Data.SqlClient.SqlDataAdapter(RestaurantPOS14.ModClasses.cmd)
                RestaurantPOS14.ModClasses.dtable = New System.Data.DataTable()
                RestaurantPOS14.ModClasses.adp.Fill(RestaurantPOS14.ModClasses.dtable)
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.ds = New System.Data.DataSet()
                RestaurantPOS14.ModClasses.ds.Tables.Add(RestaurantPOS14.ModClasses.dtable)
                RestaurantPOS14.ModClasses.ds.WriteXmlSchema("PurchaseDayBook.xml")
                Dim rptPurchaseDayBook2 As RestaurantPOS14.rptPurchaseDayBook = New RestaurantPOS14.rptPurchaseDayBook()
                rptPurchaseDayBook2.SetDataSource(RestaurantPOS14.ModClasses.ds)
                rptPurchaseDayBook2.SetParameterValue("p1", Me.dtpDateFrom.Value.[Date])
                rptPurchaseDayBook2.SetParameterValue("p2", Me.dtpDateTo.Value.[Date])
                RestaurantPOS14.My.MyProject.Forms.frmReport.CrystalReportViewer1.ReportSource = rptPurchaseDayBook2
                Call RestaurantPOS14.My.MyProject.Forms.frmReport.ShowDialog()
                rptPurchaseDayBook2.Close()
                rptPurchaseDayBook2.Dispose()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnClose_Click(sender As Object, e As System.EventArgs)
            MyBase.Close()
        End Sub

        Private Sub Timer1_Tick(sender As Object, e As System.EventArgs)
            MyBase.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.Timer1.Enabled = False
        End Sub

        Private Sub Button1_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
            RestaurantPOS14.ModClasses.con.Open()
            RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select CASE WHEN IsNULL((Sum(Debit)-Sum(Credit)),0)<= 0 THEN 0 ELSE IsNULL((Sum(Debit)-Sum(Credit)),0) END AS Debit,CASE WHEN IsNULL((Sum(Credit)-Sum(Debit)),0)<= 0 THEN 0 ELSE IsNULL((Sum(Credit)-Sum(debit)),0) END AS Credit from LedgerBook where Name=@d1 and Date < @d2")
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", "Cash")
            RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.dtpDateFrom.Value.[Date].AddDays(-1.0)
            RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
            RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
            RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
            If RestaurantPOS14.ModClasses.rdr.Read() Then
                Me.OBB = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                Me.OBC = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(1))
            End If

            RestaurantPOS14.ModClasses.con.Close()
            MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Me.Timer1.Enabled = True
            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
            RestaurantPOS14.ModClasses.con.Open()
            RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Select Date, LedgerNo, Label,ISNULL(Credit,0) as Credit,ISNULL(Debit,0) as Debit,AccLedger,Name from LedgerBook where Date >=@d1 and Date < @d2 and Name=@d3 order by ID,Date,LedgerNo", RestaurantPOS14.ModClasses.con)
            RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.dtpDateFrom.Value.[Date]
            RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.dtpDateTo.Value.[Date].AddDays(1.0)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", "Cash")
            RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
            RestaurantPOS14.ModClasses.adp = New System.Data.SqlClient.SqlDataAdapter(RestaurantPOS14.ModClasses.cmd)
            RestaurantPOS14.ModClasses.dtable = New System.Data.DataTable()
            RestaurantPOS14.ModClasses.adp.Fill(RestaurantPOS14.ModClasses.dtable)
            RestaurantPOS14.ModClasses.con.Close()
            RestaurantPOS14.ModClasses.ds = New System.Data.DataSet()
            RestaurantPOS14.ModClasses.ds.Tables.Add(RestaurantPOS14.ModClasses.dtable)
            RestaurantPOS14.ModClasses.ds.WriteXmlSchema("LedgerBookNew.xml")
            Dim rptGeneralLedger2 As RestaurantPOS14.rptGeneralLedger = New RestaurantPOS14.rptGeneralLedger()
            rptGeneralLedger2.SetDataSource(RestaurantPOS14.ModClasses.ds)
            rptGeneralLedger2.SetParameterValue("p1", Me.dtpDateFrom.Value.[Date])
            rptGeneralLedger2.SetParameterValue("p2", Me.dtpDateTo.Value.[Date])
            rptGeneralLedger2.SetParameterValue("OBC", Me.OBC)
            rptGeneralLedger2.SetParameterValue("OBB", Me.OBB)
            rptGeneralLedger2.SetParameterValue("p3", "Cash Book")
            RestaurantPOS14.My.MyProject.Forms.frmReport.CrystalReportViewer1.ReportSource = rptGeneralLedger2
            Call RestaurantPOS14.My.MyProject.Forms.frmReport.ShowDialog()
            rptGeneralLedger2.Close()
            rptGeneralLedger2.Dispose()
        End Sub

        Private Sub btnSupplierLedger_Click(sender As Object, e As System.EventArgs)
            Try
                If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.cmbSupplierName.Text)) = 0 Then
                    Call System.Windows.Forms.MessageBox.Show("Please Select Supplier Name", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Me.cmbSupplierName.Focus()
                    Return
                End If

                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select PartyID from LedgerBook where PartyID=@d3")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Me.txtSupplierID.Text)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If Not RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Sorry...No record found", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select CASE WHEN IsNULL((Sum(Debit)-Sum(Credit)),0)<= 0 THEN 0 ELSE IsNULL((Sum(Debit)-Sum(Credit)),0) END AS Debit,CASE WHEN IsNULL((Sum(Credit)-Sum(Debit)),0)<= 0 THEN 0 ELSE IsNULL((Sum(Credit)-Sum(debit)),0) END AS Credit from LedgerBook where PartyID=@d1 and CAST(Date AS DATE) <= CAST(@d2 AS DATE)")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtSupplierID.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.DateTimePicker3.Value.[Date].AddDays(-1.0)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.OBB = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                    Me.OBC = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(1))
                End If

                RestaurantPOS14.ModClasses.con.Close()
                MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Me.Timer1.Enabled = True
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Select Date, Name, LedgerNo, Label, Credit, Debit from LedgerBook where Date >=@d1 and Date < @d2 and PartyID=@d3 order by Date,LedgerNo", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.DateTimePicker3.Value.[Date]
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.DateTimePicker2.Value.[Date].AddDays(1.0)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Me.txtSupplierID.Text)
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.adp = New System.Data.SqlClient.SqlDataAdapter(RestaurantPOS14.ModClasses.cmd)
                RestaurantPOS14.ModClasses.dtable = New System.Data.DataTable()
                RestaurantPOS14.ModClasses.adp.Fill(RestaurantPOS14.ModClasses.dtable)
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.ds = New System.Data.DataSet()
                RestaurantPOS14.ModClasses.ds.Tables.Add(RestaurantPOS14.ModClasses.dtable)
                RestaurantPOS14.ModClasses.ds.WriteXmlSchema("SupplierLedger.xml")
                Dim rptSupplierLedger2 As RestaurantPOS14.rptSupplierLedger = New RestaurantPOS14.rptSupplierLedger()
                rptSupplierLedger2.SetDataSource(RestaurantPOS14.ModClasses.ds)
                rptSupplierLedger2.SetParameterValue("p1", Me.DateTimePicker3.Value.[Date])
                rptSupplierLedger2.SetParameterValue("p2", Me.DateTimePicker2.Value.[Date])
                rptSupplierLedger2.SetParameterValue("p3", Me.txtSupplierID.Text)
                rptSupplierLedger2.SetParameterValue("p4", Me.cmbSupplierName.Text)
                rptSupplierLedger2.SetParameterValue("p5", Me.d)
                rptSupplierLedger2.SetParameterValue("p6", Me.b)
                rptSupplierLedger2.SetParameterValue("p7", Me.c)
                rptSupplierLedger2.SetParameterValue("OBC", Me.OBC)
                rptSupplierLedger2.SetParameterValue("OBB", Me.OBB)
                RestaurantPOS14.My.MyProject.Forms.frmReport.CrystalReportViewer1.ReportSource = rptSupplierLedger2
                Call RestaurantPOS14.My.MyProject.Forms.frmReport.ShowDialog()
                rptSupplierLedger2.Dispose()
                rptSupplierLedger2.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnTrialBalance_Click(sender As Object, e As System.EventArgs)
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select * from LedgerBook where Date >=@d1 and Date < @d2")
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.dtpDateFrom.Value.[Date]
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.dtpDateTo.Value.[Date].AddDays(1.0)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If Not RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Sorry...No record found", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Me.Timer1.Enabled = True
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Select Name,CASE WHEN (Sum(Debit)-Sum(Credit))<= 0 THEN 0 ELSE (Sum(Debit)-Sum(Credit)) END AS Debit,CASE WHEN (Sum(Credit)-Sum(Debit))<= 0 THEN 0 ELSE (Sum(Credit)-Sum(debit)) END AS Credit from LedgerBook where Date >=@d1 and Date < @d2 Group By Name having (Sum(Credit)-Sum(Debit)) <> 0 order by Name", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.dtpDateFrom.Value.[Date]
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.dtpDateTo.Value.[Date].AddDays(1.0)
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.adp = New System.Data.SqlClient.SqlDataAdapter(RestaurantPOS14.ModClasses.cmd)
                RestaurantPOS14.ModClasses.dtable = New System.Data.DataTable()
                RestaurantPOS14.ModClasses.adp.Fill(RestaurantPOS14.ModClasses.dtable)
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.ds = New System.Data.DataSet()
                RestaurantPOS14.ModClasses.ds.Tables.Add(RestaurantPOS14.ModClasses.dtable)
                RestaurantPOS14.ModClasses.ds.WriteXmlSchema("TrialBalanceAccounting.xml")
                Dim rptTrialBalance2 As RestaurantPOS14.rptTrialBalance = New RestaurantPOS14.rptTrialBalance()
                rptTrialBalance2.SetDataSource(RestaurantPOS14.ModClasses.ds)
                rptTrialBalance2.SetParameterValue("p1", Me.dtpDateFrom.Value.[Date])
                rptTrialBalance2.SetParameterValue("p2", Me.dtpDateTo.Value.[Date])
                RestaurantPOS14.My.MyProject.Forms.frmReport.CrystalReportViewer1.ReportSource = rptTrialBalance2
                Call RestaurantPOS14.My.MyProject.Forms.frmReport.ShowDialog()
                rptTrialBalance2.Close()
                rptTrialBalance2.Dispose()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnPurchase_Click(sender As Object, e As System.EventArgs)
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select * from Purchase where Date Between @d2 and @d3")
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.dtpDateFrom.Value.[Date]
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.dtpDateTo.Value.[Date]
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If Not RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Sorry...No record found", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Me.Timer1.Enabled = True
                Dim rptPurchase2 As RestaurantPOS14.rptPurchase = New RestaurantPOS14.rptPurchase()
                Dim sqlCommand As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand()
                Dim sqlCommand2 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand()
                Dim sqlDataAdapter As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter()
                Dim sqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter()
                Dim dataSet As System.Data.DataSet = New System.Data.DataSet()
                sqlCommand.Connection = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                Dim sqlConnection As System.Data.SqlClient.SqlConnection = sqlCommand.Connection
                Dim connection As System.Data.SqlClient.SqlConnection = sqlConnection
                sqlCommand2.Connection = connection
                sqlCommand.CommandText = "SELECT HST,HSTPer, Supplier.ID, Supplier.SupplierID, Supplier.Name, Supplier.Address, Supplier.City, Supplier.State, Supplier.ZipCode, Supplier.ContactNo, Supplier.EmailID, Supplier.Remarks, Purchase.ST_ID, Purchase.InvoiceNo,Purchase.Date,Purchase.Supplier_ID, Purchase.PurchaseType, Purchase.SubTotal, Purchase.DiscountPer, Purchase.Discount, Purchase.PreviousDue, Purchase.FreightCharges, Purchase.OtherCharges, Purchase.Total, Purchase.RoundOff, Purchase.GrandTotal, Purchase.TotalPayment, Purchase.PaymentDue, Purchase_Join.SP_ID, Purchase_Join.PurchaseID, Purchase_Join.ProductID, Purchase_Join.Qty, Purchase_Join.HasExpiryDate,ExpiryDate, Purchase_Join.Price, Purchase_Join.TotalAmount, Product.PID, Product.ProductCode,Product.Unit, Product.ProductName, Product.Category,Product.Description FROM Supplier INNER JOIN Purchase ON Supplier.ID = Purchase.Supplier_ID INNER JOIN Purchase_Join ON Purchase.ST_ID = Purchase_Join.PurchaseID INNER JOIN Product ON Purchase_Join.ProductID = Product.PID where Purchase.date between @d1 and @d2 order by Purchase.Date"
                sqlCommand.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateFrom.Value.[Date]
                sqlCommand.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateTo.Value.[Date]
                sqlCommand.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                sqlCommand2.CommandText = "SELECT * from Hotel"
                sqlCommand.CommandType = System.Data.CommandType.Text
                sqlCommand2.CommandType = System.Data.CommandType.Text
                sqlDataAdapter.SelectCommand = sqlCommand
                sqlDataAdapter2.SelectCommand = sqlCommand2
                sqlDataAdapter.Fill(dataSet, "Supplier")
                sqlDataAdapter.Fill(dataSet, "Purchase")
                sqlDataAdapter.Fill(dataSet, "Purchase_Join")
                sqlDataAdapter.Fill(dataSet, "Product")
                sqlDataAdapter2.Fill(dataSet, "Hotel")
                rptPurchase2.SetDataSource(dataSet)
                rptPurchase2.SetParameterValue("P1", Me.dtpDateFrom.Value.[Date])
                rptPurchase2.SetParameterValue("P2", Me.dtpDateTo.Value.[Date])
                RestaurantPOS14.My.MyProject.Forms.frmReport.CrystalReportViewer1.ReportSource = rptPurchase2
                Call RestaurantPOS14.My.MyProject.Forms.frmReport.ShowDialog()
                rptPurchase2.Close()
                rptPurchase2.Dispose()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnVouchers_Click(sender As Object, e As System.EventArgs)
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select * from Voucher where Date >=@d1 and Date < @d2")
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.dtpDateFrom.Value.[Date]
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.dtpDateTo.Value.[Date].AddDays(1.0)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If Not RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Sorry...No record found", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Me.Timer1.Enabled = True
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT Voucher.ID, Voucher.VoucherNo, Voucher.Date, Voucher.Name, Voucher.Details, Voucher.GrandTotal, Voucher_OtherDetails.VD_ID, Voucher_OtherDetails.VoucherID,Voucher_OtherDetails.Particulars, Voucher_OtherDetails.Amount, Voucher_OtherDetails.Note FROM Voucher INNER JOIN Voucher_OtherDetails ON Voucher.ID = Voucher_OtherDetails.VoucherID where Date >=@d1 and Date < @d2 order by Date", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.dtpDateFrom.Value.[Date]
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.dtpDateTo.Value.[Date].AddDays(1.0)
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.adp = New System.Data.SqlClient.SqlDataAdapter(RestaurantPOS14.ModClasses.cmd)
                RestaurantPOS14.ModClasses.dtable = New System.Data.DataTable()
                RestaurantPOS14.ModClasses.adp.Fill(RestaurantPOS14.ModClasses.dtable)
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.ds = New System.Data.DataSet()
                RestaurantPOS14.ModClasses.ds.Tables.Add(RestaurantPOS14.ModClasses.dtable)
                RestaurantPOS14.ModClasses.ds.WriteXmlSchema("Expenses.xml")
                Dim rptExpenses2 As RestaurantPOS14.rptExpenses = New RestaurantPOS14.rptExpenses()
                rptExpenses2.SetDataSource(RestaurantPOS14.ModClasses.ds)
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select ISNULL(sum(GrandTotal),0) from Voucher where Date >=@d1 and Date < @d2")
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.dtpDateFrom.Value.[Date]
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.dtpDateTo.Value.[Date].AddDays(1.0)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.a = Microsoft.VisualBasic.CompilerServices.Conversions.ToDecimal(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If

                RestaurantPOS14.ModClasses.con.Close()
                rptExpenses2.SetParameterValue("p1", Me.dtpDateFrom.Value.[Date])
                rptExpenses2.SetParameterValue("p2", Me.dtpDateTo.Value.[Date])
                rptExpenses2.SetParameterValue("p3", Me.a)
                rptExpenses2.SetParameterValue("p4", Microsoft.VisualBasic.DateAndTime.Today)
                RestaurantPOS14.My.MyProject.Forms.frmReport.CrystalReportViewer1.ReportSource = rptExpenses2
                Call RestaurantPOS14.My.MyProject.Forms.frmReport.ShowDialog()
                rptExpenses2.Close()
                rptExpenses2.Dispose()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub cmbSupplierName_SelectedIndexChanged(sender As Object, e As System.EventArgs)
            Try
                Me.d = ""
                Me.b = ""
                Me.c = ""
                Me.txtSupplierID.Text = ""
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = RestaurantPOS14.ModClasses.con.CreateCommand()
                RestaurantPOS14.ModClasses.cmd.CommandText = "SELECT RTRIM(SupplierID),RTRIM(Address),RTRIM(City),RTRIM(ContactNo) FROM Supplier WHERE Name=@d1"
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.cmbSupplierName.Text)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.txtSupplierID.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                    Me.d = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(1))
                    Me.b = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(2))
                    Me.c = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(3))
                End If

                If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                    RestaurantPOS14.ModClasses.rdr.Close()
                End If

                If RestaurantPOS14.ModClasses.con.State = System.Data.ConnectionState.Open Then
                    RestaurantPOS14.ModClasses.con.Close()
                End If
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnGeneralDaybook_Click(sender As Object, e As System.EventArgs)
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select * from LedgerBook where Date between @d1 and @d2")
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.DateTimePicker1.Value.[Date]
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.DateTimePicker1.Value.[Date].AddHours(23.0).AddMinutes(59.0).AddSeconds(59.0)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If Not RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Sorry...No record found", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Me.Timer1.Enabled = True
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Select Date, Name, LedgerNo, Label, Credit, Debit from LedgerBook where Date between @d1 and @d2 order by ID,LedgerNo", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.DateTimePicker1.Value.[Date]
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.DateTimePicker1.Value.[Date].AddHours(23.0).AddMinutes(59.0).AddSeconds(59.0)
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.adp = New System.Data.SqlClient.SqlDataAdapter(RestaurantPOS14.ModClasses.cmd)
                RestaurantPOS14.ModClasses.dtable = New System.Data.DataTable()
                RestaurantPOS14.ModClasses.adp.Fill(RestaurantPOS14.ModClasses.dtable)
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.ds = New System.Data.DataSet()
                RestaurantPOS14.ModClasses.ds.Tables.Add(RestaurantPOS14.ModClasses.dtable)
                RestaurantPOS14.ModClasses.ds.WriteXmlSchema("GeneralDayBook.xml")
                Dim rptGeneralDayBook2 As RestaurantPOS14.rptGeneralDayBook = New RestaurantPOS14.rptGeneralDayBook()
                rptGeneralDayBook2.SetDataSource(RestaurantPOS14.ModClasses.ds)
                rptGeneralDayBook2.SetParameterValue("p1", Me.DateTimePicker1.Value.[Date])
                RestaurantPOS14.My.MyProject.Forms.frmReport.CrystalReportViewer1.ReportSource = rptGeneralDayBook2
                Call RestaurantPOS14.My.MyProject.Forms.frmReport.ShowDialog()
                rptGeneralDayBook2.Close()
                rptGeneralDayBook2.Dispose()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub frmAccountingReport_Load(sender As Object, e As System.EventArgs)
            Me.fillSupplier()
        End Sub

        Private Sub btnCreditors_Click(sender As Object, e As System.EventArgs)
            Try
                MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Me.Timer1.Enabled = True
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT Supplier.SupplierID, Supplier.Name,Supplier.City,Supplier.ContactNo,IsNull(Sum(Credit)-Sum(Debit),0) FROM Supplier,LedgerBook where Supplier.SupplierID=LedgerBook.PartyID group by Supplier.SupplierID, Supplier.Name,Supplier.ContactNo,Supplier.City having (sum(Credit)- sum(Debit) > 0 ) ORDER BY Supplier.Name", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.adp = New System.Data.SqlClient.SqlDataAdapter(RestaurantPOS14.ModClasses.cmd)
                RestaurantPOS14.ModClasses.dtable = New System.Data.DataTable()
                RestaurantPOS14.ModClasses.adp.Fill(RestaurantPOS14.ModClasses.dtable)
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.ds = New System.Data.DataSet()
                RestaurantPOS14.ModClasses.ds.Tables.Add(RestaurantPOS14.ModClasses.dtable)
                RestaurantPOS14.ModClasses.ds.WriteXmlSchema("Creditors.xml")
                Dim rptCreditors2 As RestaurantPOS14.rptCreditors = New RestaurantPOS14.rptCreditors()
                rptCreditors2.SetDataSource(RestaurantPOS14.ModClasses.ds)
                rptCreditors2.SetParameterValue("p1", Microsoft.VisualBasic.DateAndTime.Today)
                RestaurantPOS14.My.MyProject.Forms.frmReport.CrystalReportViewer1.ReportSource = rptCreditors2
                Call RestaurantPOS14.My.MyProject.Forms.frmReport.ShowDialog()
                rptCreditors2.Close()
                rptCreditors2.Dispose()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnStockIN_Click(sender As Object, e As System.EventArgs)
            Call RestaurantPOS14.My.MyProject.Forms.frmStockInRecord.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmStockInRecord.ShowDialog()
        End Sub

        Private Sub btnStockOut_Click(sender As Object, e As System.EventArgs)
            Call RestaurantPOS14.My.MyProject.Forms.frmStockOUTRecord.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmStockOUTRecord.ShowDialog()
        End Sub

        Private Sub btnLowStock_Click(sender As Object, e As System.EventArgs)
            Call RestaurantPOS14.My.MyProject.Forms.frmLowStockRecord.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmLowStockRecord.ShowDialog()
        End Sub

        Private Sub btnExpiredProducts_Click(sender As Object, e As System.EventArgs)
            Call RestaurantPOS14.My.MyProject.Forms.frmExpiredProductsRecord.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmExpiredProductsRecord.ShowDialog()
        End Sub

        Private Sub btnStockTransfer_Click(sender As Object, e As System.EventArgs)
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select * from StockTransfer where Date Between @d2 and @d3")
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.dtpDateFrom.Value.[Date]
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.dtpDateTo.Value.[Date]
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If Not RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Sorry...No record found", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Me.Timer1.Enabled = True
                Dim rptStockTransfer2 As RestaurantPOS14.rptStockTransfer = New RestaurantPOS14.rptStockTransfer()
                Dim sqlCommand As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand()
                Dim sqlCommand2 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand()
                Dim sqlDataAdapter As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter()
                Dim sqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter()
                Dim dataSet As System.Data.DataSet = New System.Data.DataSet()
                sqlCommand.Connection = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                Dim sqlConnection As System.Data.SqlClient.SqlConnection = sqlCommand.Connection
                Dim connection As System.Data.SqlClient.SqlConnection = sqlConnection
                sqlCommand2.Connection = connection
                sqlCommand.CommandText = "SELECT StockTransfer.ST_ID, StockTransfer.Date, StockTransfer.kitchen, StockTransfer_Join.STJ_ID, StockTransfer_Join.StockTransferID, StockTransfer_Join.Warehouse, StockTransfer_Join.ProductID,StockTransfer_Join.ExpiryDate, StockTransfer_Join.Qty, Product.PID, Product.ProductCode, Product.ProductName, Product.Category, Product.Description, Product.Unit, Product.Price, Product.ReorderPoint FROM StockTransfer INNER JOIN StockTransfer_Join ON StockTransfer.ST_ID = StockTransfer_Join.StockTransferID INNER JOIN Product ON StockTransfer_Join.ProductID = Product.PID where StockTransfer.date between @d1 and @d2 order by StockTransfer.Date"
                sqlCommand.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateFrom.Value.[Date]
                sqlCommand.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateTo.Value.[Date]
                sqlCommand2.CommandText = "SELECT * from Hotel"
                sqlCommand.CommandType = System.Data.CommandType.Text
                sqlCommand2.CommandType = System.Data.CommandType.Text
                sqlDataAdapter.SelectCommand = sqlCommand
                sqlDataAdapter2.SelectCommand = sqlCommand2
                sqlDataAdapter.Fill(dataSet, "StockTransfer")
                sqlDataAdapter.Fill(dataSet, "StockTransfer_Join")
                sqlDataAdapter.Fill(dataSet, "Product")
                sqlDataAdapter2.Fill(dataSet, "Hotel")
                rptStockTransfer2.SetDataSource(dataSet)
                rptStockTransfer2.SetParameterValue("P1", Me.dtpDateFrom.Value.[Date])
                rptStockTransfer2.SetParameterValue("P2", Me.dtpDateTo.Value.[Date])
                RestaurantPOS14.My.MyProject.Forms.frmReport.CrystalReportViewer1.ReportSource = rptStockTransfer2
                Call RestaurantPOS14.My.MyProject.Forms.frmReport.ShowDialog()
                rptStockTransfer2.Close()
                rptStockTransfer2.Dispose()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnStoreStockIN_Click(sender As Object, e As System.EventArgs)
            Call RestaurantPOS14.My.MyProject.Forms.frmStockIn_StoreRecord.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmStockIn_StoreRecord.ShowDialog()
        End Sub

        Private Sub btnStoreStockOUT_Click(sender As Object, e As System.EventArgs)
            Call RestaurantPOS14.My.MyProject.Forms.frmStockOUT_StoreRecord.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmStockOUT_StoreRecord.ShowDialog()
        End Sub

        Private Sub btnStockIn_RM_Click(sender As Object, e As System.EventArgs)
            Call RestaurantPOS14.My.MyProject.Forms.frmStockIn_RM.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmStockIn_RM.ShowDialog()
        End Sub

        Private Sub btnStockOut_RM_Click(sender As Object, e As System.EventArgs)
            Call RestaurantPOS14.My.MyProject.Forms.frmStockOUT_RM.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmStockOUT_RM.ShowDialog()
        End Sub

        Private Sub btnCollectionsByDP_Click(sender As Object, e As System.EventArgs)
            Call RestaurantPOS14.My.MyProject.Forms.frmDeliveryPersonLedger.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmDeliveryPersonLedger.ShowDialog()
        End Sub

        Private Sub btnTaxReport_Click(sender As Object, e As System.EventArgs)
            Try
                MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Me.Timer1.Enabled = True
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("select Operator from RestaurantPOS_BillingInfoKOT where BillDate >=@d1 and BillDate < @d2 and DIB_Status not in ('Unpaid','Changed to Split Bill') union select Operator from RestaurantPOS_BillingInfoTA where BillDate >=@d1 and BillDate < @d2 and TA_Status not in ('Void','Unpaid','Prepared') union select Operator from RestaurantPOS_BillingInfoHD where BillDate >=@d1 and BillDate < @d2 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') Union select Operator from RestaurantPOS_BillingInfoEB where BillDate >=@d1 and BillDate < @d2 and EB_Status not in ('Void','Unpaid','Prepared')")
                sqlCommand.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.dtpDateFrom.Value.[Date]
                sqlCommand.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.dtpDateTo.Value.[Date].AddDays(1.0)
                sqlCommand.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                sqlCommand.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.rdr = sqlCommand.ExecuteReader()
                If Not RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Sorry...No record found", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand2 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT RestaurantPOS_BillingInfoKOT.BillNo, RestaurantPOS_BillingInfoKOT.BillDate, RestaurantPOS_BillingInfoKOT.PaymentMode, RestaurantPOS_BillingInfoKOT.Operator,SUM(VATPer)/Count(OP_ID), SUM(RestaurantPOS_OrderedProductBillKOT.VATAmount),RestaurantPOS_BillingInfoKOT.GrandTotal,Cash,Card FROM RestaurantPOS_BillingInfoKOT INNER JOIN RestaurantPOS_OrderedProductBillKOT ON RestaurantPOS_BillingInfoKOT.Id = RestaurantPOS_OrderedProductBillKOT.BillID Where BillDate >=@d1 and BillDate < @d2 and DIB_Status not in ('Unpaid','Changed to Split Bill') group by RestaurantPOS_BillingInfoKOT.BillNo, RestaurantPOS_BillingInfoKOT.BillDate, RestaurantPOS_BillingInfoKOT.PaymentMode, RestaurantPOS_BillingInfoKOT.Operator,RestaurantPOS_BillingInfoKOT.GrandTotal,Cash,Card UNION SELECT RestaurantPOS_BillingInfoTA.BillNo, RestaurantPOS_BillingInfoTA.BillDate, RestaurantPOS_BillingInfoTA.PaymentMode, RestaurantPOS_BillingInfoTA.Operator,SUM(VATPer)/Count(OP_ID), SUM(RestaurantPOS_OrderedProductBillTA.VATAmount),RestaurantPOS_BillingInfoTA.GrandTotal,Cash,Card FROM RestaurantPOS_BillingInfoTA INNER JOIN RestaurantPOS_OrderedProductBillTA ON RestaurantPOS_BillingInfoTA.Id = RestaurantPOS_OrderedProductBillTA.BillID Where BillDate >=@d1 and BillDate < @d2 and TA_Status not in ('Void','Unpaid','Prepared') group by RestaurantPOS_BillingInfoTA.BillNo, RestaurantPOS_BillingInfoTA.BillDate, RestaurantPOS_BillingInfoTA.PaymentMode, RestaurantPOS_BillingInfoTA.Operator,RestaurantPOS_BillingInfoTA.GrandTotal,Cash,Card UNION SELECT RestaurantPOS_BillingInfoHD.BillNo, RestaurantPOS_BillingInfoHD.BillDate, RestaurantPOS_BillingInfoHD.PaymentMode, RestaurantPOS_BillingInfoHD.Operator,SUM(VATPer)/Count(OP_ID), SUM(RestaurantPOS_OrderedProductBillHD.VATAmount),RestaurantPOS_BillingInfoHD.GrandTotal,0,0 FROM RestaurantPOS_BillingInfoHD INNER JOIN RestaurantPOS_OrderedProductBillHD ON RestaurantPOS_BillingInfoHD.Id = RestaurantPOS_OrderedProductBillHD.BillID Where BillDate >=@d1 and BillDate < @d2 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') group by RestaurantPOS_BillingInfoHD.BillNo, RestaurantPOS_BillingInfoHD.BillDate, RestaurantPOS_BillingInfoHD.PaymentMode, RestaurantPOS_BillingInfoHD.Operator,RestaurantPOS_BillingInfoHD.GrandTotal UNION SELECT RestaurantPOS_BillingInfoEB.BillNo, RestaurantPOS_BillingInfoEB.BillDate, RestaurantPOS_BillingInfoEB.PaymentMode, RestaurantPOS_BillingInfoEB.Operator,SUM(VATPer)/Count(OP_ID), SUM(RestaurantPOS_OrderedProductBillEB.VATAmount),RestaurantPOS_BillingInfoEB.GrandTotal,Cash,Card FROM RestaurantPOS_BillingInfoEB INNER JOIN RestaurantPOS_OrderedProductBillEB ON RestaurantPOS_BillingInfoEB.Id = RestaurantPOS_OrderedProductBillEB.BillID Where BillDate >=@d1 and BillDate < @d2 and EB_Status not in ('Void','Unpaid','Prepared') group by RestaurantPOS_BillingInfoEB.BillNo, RestaurantPOS_BillingInfoEB.BillDate, RestaurantPOS_BillingInfoEB.PaymentMode, RestaurantPOS_BillingInfoEB.Operator, RestaurantPOS_BillingInfoEB.GrandTotal,Cash,Card order by 2", RestaurantPOS14.ModClasses.con)
                sqlCommand2.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.dtpDateFrom.Value.[Date]
                sqlCommand2.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.dtpDateTo.Value.[Date].AddDays(1.0)
                sqlCommand2.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                Dim sqlDataAdapter As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(sqlCommand2)
                Dim sqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(New System.Data.SqlClient.SqlCommand("Select * from Hotel", RestaurantPOS14.ModClasses.con))
                Dim dataTable As System.Data.DataTable = New System.Data.DataTable()
                Dim dataTable2 As System.Data.DataTable = New System.Data.DataTable()
                sqlDataAdapter.Fill(dataTable)
                sqlDataAdapter2.Fill(dataTable2)
                RestaurantPOS14.ModClasses.con.Close()
                Dim dataSet As System.Data.DataSet = New System.Data.DataSet()
                dataSet.Tables.Add(dataTable)
                dataSet.Tables.Add(dataTable2)
                dataSet.WriteXmlSchema("OutputTaxZ.xml")
                Dim rptTax2 As RestaurantPOS14.rptTax = New RestaurantPOS14.rptTax()
                rptTax2.SetDataSource(dataSet)
                rptTax2.SetParameterValue("p1", Me.dtpDateFrom.Value.[Date])
                rptTax2.SetParameterValue("p2", Me.dtpDateTo.Value.[Date])
                RestaurantPOS14.My.MyProject.Forms.frmReport.CrystalReportViewer1.ReportSource = rptTax2
                Call RestaurantPOS14.My.MyProject.Forms.frmReport.ShowDialog()
                rptTax2.Dispose()
                rptTax2.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnGeneralLedger_Click(sender As Object, e As System.EventArgs)
            Call RestaurantPOS14.My.MyProject.Forms.frmGeneralLedger.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmGeneralLedger.ShowDialog()
        End Sub

        Private Sub btnStockUsed_Click(sender As Object, e As System.EventArgs)
            Call RestaurantPOS14.My.MyProject.Forms.frmRawMaterialsUsed.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmRawMaterialsUsed.ShowDialog()
        End Sub

        Private Sub btnInputTax_Click(sender As Object, e As System.EventArgs)
            Try
                MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Me.Timer1.Enabled = True
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT * from Purchase where Date > = @d1 and Date < @d2 and (HST) > 0")
                sqlCommand.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.dtpDateFrom.Value.[Date]
                sqlCommand.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.dtpDateTo.Value.[Date].AddDays(1.0)
                sqlCommand.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand.ExecuteReader()
                If Not RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Sorry...No record found", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand2 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT Purchase.InvoiceNo, Purchase.Date, Supplier.Name, Supplier.TIN, Purchase.HSTPer, Purchase.HST, Purchase.GrandTotal FROM Purchase INNER JOIN Supplier ON Purchase.Supplier_ID = Supplier.ID where (HST) > 0 and Date > = @d1 and Date < @d2 order by Date", RestaurantPOS14.ModClasses.con)
                sqlCommand2.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.dtpDateFrom.Value.[Date]
                sqlCommand2.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.dtpDateTo.Value.[Date].AddDays(1.0)
                sqlCommand2.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                Dim sqlDataAdapter As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(sqlCommand2)
                Dim sqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(New System.Data.SqlClient.SqlCommand("Select * from Hotel", RestaurantPOS14.ModClasses.con))
                Dim dataTable As System.Data.DataTable = New System.Data.DataTable()
                Dim dataTable2 As System.Data.DataTable = New System.Data.DataTable()
                sqlDataAdapter.Fill(dataTable)
                sqlDataAdapter2.Fill(dataTable2)
                Dim dataSet As System.Data.DataSet = New System.Data.DataSet()
                dataSet.Tables.Add(dataTable)
                dataSet.Tables.Add(dataTable2)
                dataSet.WriteXmlSchema("InputTaxReport.xml")
                Dim rptInputTax2 As RestaurantPOS14.rptInputTax = New RestaurantPOS14.rptInputTax()
                rptInputTax2.Subreports(CInt((0))).SetDataSource(dataSet)
                rptInputTax2.SetDataSource(dataSet)
                rptInputTax2.SetParameterValue("p1", Me.dtpDateFrom.Value.[Date])
                rptInputTax2.SetParameterValue("p2", Me.dtpDateTo.Value.[Date])
                RestaurantPOS14.My.MyProject.Forms.frmReport.CrystalReportViewer1.ReportSource = rptInputTax2
                Call RestaurantPOS14.My.MyProject.Forms.frmReport.ShowDialog()
                rptInputTax2.Dispose()
                rptInputTax2.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnJournalEntry_Click(sender As Object, e As System.EventArgs)
            Call RestaurantPOS14.My.MyProject.Forms.frmJournalEntries.Reset()
            RestaurantPOS14.My.MyProject.Forms.frmJournalEntries.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmJournalEntries.ShowDialog()
        End Sub

        Private Sub btnBalanceSheet_Click(sender As Object, e As System.EventArgs)
            Try
                MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Me.Timer1.Enabled = True
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Select * FROM LedgerBook where Date >=@d1 and Date < @d2")
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.dtpDateFrom.Value.[Date]
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.dtpDateTo.Value.[Date].AddDays(1.0)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If Not RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Sorry...No record found", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT distinct Name, (Sum(Debit) - Sum(Credit)) as Debit from LedgerBook where Date >=@d1 and Date < @d2 group by Name having ((Sum(Debit) - Sum(Credit)) > 0) order by 1", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.dtpDateFrom.Value.[Date]
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.dtpDateTo.Value.[Date].AddDays(1.0)
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.cmd1 = New System.Data.SqlClient.SqlCommand("SELECT distinct Name as NameX, (Sum(Credit) - Sum(Debit)) as Credit from LedgerBook where Date >=@d1 and Date < @d2 group by Name having ((Sum(Credit) - Sum(Debit)) > 0) order by 1", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.cmd1.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.dtpDateFrom.Value.[Date]
                RestaurantPOS14.ModClasses.cmd1.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.dtpDateTo.Value.[Date].AddDays(1.0)
                RestaurantPOS14.ModClasses.cmd1.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.adp = New System.Data.SqlClient.SqlDataAdapter(RestaurantPOS14.ModClasses.cmd)
                RestaurantPOS14.ModClasses.adp1 = New System.Data.SqlClient.SqlDataAdapter(RestaurantPOS14.ModClasses.cmd1)
                RestaurantPOS14.ModClasses.dtable = New System.Data.DataTable()
                RestaurantPOS14.ModClasses.adp.Fill(RestaurantPOS14.ModClasses.dtable)
                RestaurantPOS14.ModClasses.adp1.Fill(RestaurantPOS14.ModClasses.dtable)
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.ds = New System.Data.DataSet()
                RestaurantPOS14.ModClasses.ds.Tables.Add(RestaurantPOS14.ModClasses.dtable)
                RestaurantPOS14.ModClasses.ds.WriteXmlSchema("BalanceSheetTestX.xml")
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Select IsNULL(Sum(Price*Qty),0) FROM Temp_Stock,Product where Product.PID=Temp_Stock.ProductID")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.a = Microsoft.VisualBasic.CompilerServices.Conversions.ToDecimal(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                Else
                    Me.a = DirectCast(Nothing, System.Decimal)
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Select IsNULL(Sum(Price*Qty),0) FROM Temp_Stock_RM,Product where Product.PID=Temp_Stock_RM.ProductID")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.b = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                Else
                    Me.b = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(0)
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Select IsNULL(Sum(DIRate*Qty),0) FROM Temp_Stock_Store,Dish where Dish.DishName=Temp_Stock_Store.Dish")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.c = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                Else
                    Me.c = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(0)
                End If

                RestaurantPOS14.ModClasses.con.Close()
                Dim rptBalanceSheet2 As RestaurantPOS14.rptBalanceSheet = New RestaurantPOS14.rptBalanceSheet()
                rptBalanceSheet2.SetDataSource(RestaurantPOS14.ModClasses.ds)
                rptBalanceSheet2.SetParameterValue("p1", Me.dtpDateFrom.Value.[Date])
                rptBalanceSheet2.SetParameterValue("p2", Me.dtpDateTo.Value.[Date])
                rptBalanceSheet2.SetParameterValue("p3", Me.a)
                rptBalanceSheet2.SetParameterValue("p4", Me.b)
                rptBalanceSheet2.SetParameterValue("p5", Me.c)
                RestaurantPOS14.My.MyProject.Forms.frmReport.CrystalReportViewer1.ReportSource = rptBalanceSheet2
                Call RestaurantPOS14.My.MyProject.Forms.frmReport.ShowDialog()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmAccountingReport))
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
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.GroupBox7 = New System.Windows.Forms.GroupBox()
            Me.btnStockUsed = New CButtonLib.CButton()
            Me.btnStockOut_RM = New CButtonLib.CButton()
            Me.btnStockIn_RM = New CButtonLib.CButton()
            Me.GroupBox6 = New System.Windows.Forms.GroupBox()
            Me.btnStoreStockOUT = New CButtonLib.CButton()
            Me.btnStoreStockIN = New CButtonLib.CButton()
            Me.GroupBox5 = New System.Windows.Forms.GroupBox()
            Me.btnExpiredProducts = New CButtonLib.CButton()
            Me.btnStockIN = New CButtonLib.CButton()
            Me.btnLowStock = New CButtonLib.CButton()
            Me.btnStockOut = New CButtonLib.CButton()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.btnCollectionsByDP = New CButtonLib.CButton()
            Me.btnCreditors = New CButtonLib.CButton()
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.btnGeneralDaybook = New CButtonLib.CButton()
            Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.btnBalanceSheet = New CButtonLib.CButton()
            Me.btnJournalEntry = New CButtonLib.CButton()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
            Me.dtpDateFrom = New System.Windows.Forms.DateTimePicker()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Panel5 = New System.Windows.Forms.Panel()
            Me.lblUser = New System.Windows.Forms.Label()
            Me.btnInputTax = New CButtonLib.CButton()
            Me.btnGeneralLedger = New CButtonLib.CButton()
            Me.btnTaxReport = New CButtonLib.CButton()
            Me.btnStockTransfer = New CButtonLib.CButton()
            Me.btnVouchers = New CButtonLib.CButton()
            Me.btnPurchase = New CButtonLib.CButton()
            Me.btnTrialBalance = New CButtonLib.CButton()
            Me.txtCashBook = New CButtonLib.CButton()
            Me.btnPurchaseDaybook = New CButtonLib.CButton()
            Me.btnReset = New CButtonLib.CButton()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.cmbSupplierName = New System.Windows.Forms.ComboBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.btnSupplierLedger = New CButtonLib.CButton()
            Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.txtSupplierID = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.btnClose = New CButtonLib.CButton()
            Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.Panel1.SuspendLayout()
            Me.GroupBox7.SuspendLayout()
            Me.GroupBox6.SuspendLayout()
            Me.GroupBox5.SuspendLayout()
            Me.Panel3.SuspendLayout()
            Me.GroupBox4.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.Panel5.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.Panel2.SuspendLayout()
            MyBase.SuspendLayout()
            Me.Panel1.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.GroupBox7)
            Me.Panel1.Controls.Add(Me.GroupBox6)
            Me.Panel1.Controls.Add(Me.GroupBox5)
            Me.Panel1.Controls.Add(Me.Panel3)
            Me.Panel1.Controls.Add(Me.GroupBox4)
            Me.Panel1.Controls.Add(Me.GroupBox3)
            Me.Panel1.Controls.Add(Me.btnReset)
            Me.Panel1.Controls.Add(Me.GroupBox2)
            Me.Panel1.Controls.Add(Me.Panel2)
            Me.Panel1.Controls.Add(Me.btnClose)
            Dim panel As System.Windows.Forms.Panel = Me.Panel1
            Dim location As System.Drawing.Point = New System.Drawing.Point(5, 4)
            panel.Location = location
            Me.Panel1.Name = "Panel1"
            Dim panel2 As System.Windows.Forms.Panel = Me.Panel1
            Dim size As System.Drawing.Size = New System.Drawing.Size(811, 655)
            panel2.Size = size
            Me.Panel1.TabIndex = 2
            Me.GroupBox7.Controls.Add(Me.btnStockUsed)
            Me.GroupBox7.Controls.Add(Me.btnStockOut_RM)
            Me.GroupBox7.Controls.Add(Me.btnStockIn_RM)
            Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.GroupBox7.ForeColor = System.Drawing.Color.White
            Dim groupBox As System.Windows.Forms.GroupBox = Me.GroupBox7
            location = New System.Drawing.Point(315, 495)
            groupBox.Location = location
            Me.GroupBox7.Name = "GroupBox7"
            Dim groupBox2 As System.Windows.Forms.GroupBox = Me.GroupBox7
            size = New System.Drawing.Size(243, 150)
            groupBox2.Size = size
            Me.GroupBox7.TabIndex = 116
            Me.GroupBox7.TabStop = False
            Me.GroupBox7.Text = "Raw Materials Inventory (Kitchen/Section)"
            Me.btnStockUsed.BackColor = System.Drawing.Color.Transparent
            Me.btnStockUsed.BorderColor = System.Drawing.Color.Transparent
            cBlendItems.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnStockUsed.ColorFillBlend = cBlendItems
            Me.btnStockUsed.Corners.All = 3
            Me.btnStockUsed.Corners.LowerLeft = 3
            Me.btnStockUsed.Corners.LowerRight = 3
            Me.btnStockUsed.Corners.UpperLeft = 3
            Me.btnStockUsed.Corners.UpperRight = 3
            Me.btnStockUsed.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnStockUsed.DesignerSelected = False
            Me.btnStockUsed.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnStockUsed.Image = CType(componentResourceManager.GetObject("btnStockUsed.Image"), System.Drawing.Image)
            Me.btnStockUsed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnStockUsed.ImageIndex = 0
            Dim cButton As CButtonLib.CButton = Me.btnStockUsed
            size = New System.Drawing.Size(32, 32)
            cButton.ImageSize = size
            Dim cButton2 As CButtonLib.CButton = Me.btnStockUsed
            location = New System.Drawing.Point(115, 87)
            cButton2.Location = location
            Me.btnStockUsed.Name = "btnStockUsed"
            Dim cButton3 As CButtonLib.CButton = Me.btnStockUsed
            size = New System.Drawing.Size(116, 50)
            cButton3.Size = size
            Me.btnStockUsed.TabIndex = 115
            Me.btnStockUsed.Text = "Stock Used"
            Me.btnStockUsed.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnStockUsed.TextShadowShow = False
            Me.btnStockUsed.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.btnStockOut_RM.BackColor = System.Drawing.Color.Transparent
            Me.btnStockOut_RM.BorderColor = System.Drawing.Color.Transparent
            cBlendItems2.iColor = New System.Drawing.Color(2) {System.Drawing.Color.Crimson, System.Drawing.Color.Crimson, System.Drawing.Color.Crimson}
            cBlendItems2.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnStockOut_RM.ColorFillBlend = cBlendItems2
            Me.btnStockOut_RM.Corners.All = 3
            Me.btnStockOut_RM.Corners.LowerLeft = 3
            Me.btnStockOut_RM.Corners.LowerRight = 3
            Me.btnStockOut_RM.Corners.UpperLeft = 3
            Me.btnStockOut_RM.Corners.UpperRight = 3
            Me.btnStockOut_RM.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnStockOut_RM.DesignerSelected = False
            Me.btnStockOut_RM.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnStockOut_RM.Image = CType(componentResourceManager.GetObject("btnStockOut_RM.Image"), System.Drawing.Image)
            Me.btnStockOut_RM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnStockOut_RM.ImageIndex = 0
            Dim cButton4 As CButtonLib.CButton = Me.btnStockOut_RM
            size = New System.Drawing.Size(32, 32)
            cButton4.ImageSize = size
            Dim cButton5 As CButtonLib.CButton = Me.btnStockOut_RM
            location = New System.Drawing.Point(115, 31)
            cButton5.Location = location
            Me.btnStockOut_RM.Name = "btnStockOut_RM"
            Dim cButton6 As CButtonLib.CButton = Me.btnStockOut_RM
            size = New System.Drawing.Size(116, 50)
            cButton6.Size = size
            Me.btnStockOut_RM.TabIndex = 113
            Me.btnStockOut_RM.Text = "Out of Stock"
            Me.btnStockOut_RM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnStockOut_RM.TextShadowShow = False
            Me.btnStockOut_RM.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.btnStockIn_RM.BackColor = System.Drawing.Color.Transparent
            Me.btnStockIn_RM.BorderColor = System.Drawing.Color.Transparent
            cBlendItems3.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems3.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnStockIn_RM.ColorFillBlend = cBlendItems3
            Me.btnStockIn_RM.Corners.All = 3
            Me.btnStockIn_RM.Corners.LowerLeft = 3
            Me.btnStockIn_RM.Corners.LowerRight = 3
            Me.btnStockIn_RM.Corners.UpperLeft = 3
            Me.btnStockIn_RM.Corners.UpperRight = 3
            Me.btnStockIn_RM.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnStockIn_RM.DesignerSelected = False
            Me.btnStockIn_RM.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnStockIn_RM.Image = CType(componentResourceManager.GetObject("btnStockIn_RM.Image"), System.Drawing.Image)
            Me.btnStockIn_RM.ImageIndex = 0
            Dim cButton7 As CButtonLib.CButton = Me.btnStockIn_RM
            size = New System.Drawing.Size(32, 32)
            cButton7.ImageSize = size
            Dim cButton8 As CButtonLib.CButton = Me.btnStockIn_RM
            location = New System.Drawing.Point(6, 31)
            cButton8.Location = location
            Me.btnStockIn_RM.Name = "btnStockIn_RM"
            Dim cButton9 As CButtonLib.CButton = Me.btnStockIn_RM
            size = New System.Drawing.Size(103, 106)
            cButton9.Size = size
            Me.btnStockIn_RM.TabIndex = 112
            Me.btnStockIn_RM.Text = "Available Items"
            Me.btnStockIn_RM.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnStockIn_RM.TextShadowShow = False
            Me.btnStockIn_RM.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.GroupBox6.Controls.Add(Me.btnStoreStockOUT)
            Me.GroupBox6.Controls.Add(Me.btnStoreStockIN)
            Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.GroupBox6.ForeColor = System.Drawing.Color.White
            Dim groupBox3 As System.Windows.Forms.GroupBox = Me.GroupBox6
            location = New System.Drawing.Point(564, 495)
            groupBox3.Location = location
            Me.GroupBox6.Name = "GroupBox6"
            Dim groupBox4 As System.Windows.Forms.GroupBox = Me.GroupBox6
            size = New System.Drawing.Size(232, 150)
            groupBox4.Size = size
            Me.GroupBox6.TabIndex = 115
            Me.GroupBox6.TabStop = False
            Me.GroupBox6.Text = "Menu Items Inventory (Restaurant)"
            Me.btnStoreStockOUT.BackColor = System.Drawing.Color.Transparent
            Me.btnStoreStockOUT.BorderColor = System.Drawing.Color.Transparent
            cBlendItems4.iColor = New System.Drawing.Color(2) {System.Drawing.Color.Crimson, System.Drawing.Color.Crimson, System.Drawing.Color.Crimson}
            cBlendItems4.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnStoreStockOUT.ColorFillBlend = cBlendItems4
            Me.btnStoreStockOUT.Corners.All = 3
            Me.btnStoreStockOUT.Corners.LowerLeft = 3
            Me.btnStoreStockOUT.Corners.LowerRight = 3
            Me.btnStoreStockOUT.Corners.UpperLeft = 3
            Me.btnStoreStockOUT.Corners.UpperRight = 3
            Me.btnStoreStockOUT.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnStoreStockOUT.DesignerSelected = False
            Me.btnStoreStockOUT.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnStoreStockOUT.Image = CType(componentResourceManager.GetObject("btnStoreStockOUT.Image"), System.Drawing.Image)
            Me.btnStoreStockOUT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnStoreStockOUT.ImageIndex = 0
            Dim cButton10 As CButtonLib.CButton = Me.btnStoreStockOUT
            size = New System.Drawing.Size(32, 32)
            cButton10.ImageSize = size
            Dim cButton11 As CButtonLib.CButton = Me.btnStoreStockOUT
            location = New System.Drawing.Point(6, 87)
            cButton11.Location = location
            Me.btnStoreStockOUT.Name = "btnStoreStockOUT"
            Me.btnStoreStockOUT.SideImageAlign = System.Drawing.ContentAlignment.MiddleCenter
            Dim cButton12 As CButtonLib.CButton = Me.btnStoreStockOUT
            size = New System.Drawing.Size(208, 50)
            cButton12.Size = size
            Me.btnStoreStockOUT.TabIndex = 113
            Me.btnStoreStockOUT.Text = "Out of Stock"
            Me.btnStoreStockOUT.TextShadowShow = False
            Me.btnStoreStockOUT.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.btnStoreStockIN.BackColor = System.Drawing.Color.Transparent
            Me.btnStoreStockIN.BorderColor = System.Drawing.Color.Transparent
            cBlendItems5.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems5.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnStoreStockIN.ColorFillBlend = cBlendItems5
            Me.btnStoreStockIN.Corners.All = 3
            Me.btnStoreStockIN.Corners.LowerLeft = 3
            Me.btnStoreStockIN.Corners.LowerRight = 3
            Me.btnStoreStockIN.Corners.UpperLeft = 3
            Me.btnStoreStockIN.Corners.UpperRight = 3
            Me.btnStoreStockIN.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnStoreStockIN.DesignerSelected = False
            Me.btnStoreStockIN.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnStoreStockIN.Image = CType(componentResourceManager.GetObject("btnStoreStockIN.Image"), System.Drawing.Image)
            Me.btnStoreStockIN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnStoreStockIN.ImageIndex = 0
            Dim cButton13 As CButtonLib.CButton = Me.btnStoreStockIN
            size = New System.Drawing.Size(32, 32)
            cButton13.ImageSize = size
            Dim cButton14 As CButtonLib.CButton = Me.btnStoreStockIN
            location = New System.Drawing.Point(6, 31)
            cButton14.Location = location
            Me.btnStoreStockIN.Name = "btnStoreStockIN"
            Me.btnStoreStockIN.SideImageAlign = System.Drawing.ContentAlignment.MiddleCenter
            Dim cButton15 As CButtonLib.CButton = Me.btnStoreStockIN
            size = New System.Drawing.Size(208, 50)
            cButton15.Size = size
            Me.btnStoreStockIN.TabIndex = 112
            Me.btnStoreStockIN.Text = "Available Items"
            Me.btnStoreStockIN.TextShadowShow = False
            Me.btnStoreStockIN.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.GroupBox5.Controls.Add(Me.btnExpiredProducts)
            Me.GroupBox5.Controls.Add(Me.btnStockIN)
            Me.GroupBox5.Controls.Add(Me.btnLowStock)
            Me.GroupBox5.Controls.Add(Me.btnStockOut)
            Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.GroupBox5.ForeColor = System.Drawing.Color.White
            Dim groupBox5 As System.Windows.Forms.GroupBox = Me.GroupBox5
            location = New System.Drawing.Point(5, 495)
            groupBox5.Location = location
            Me.GroupBox5.Name = "GroupBox5"
            Dim groupBox6 As System.Windows.Forms.GroupBox = Me.GroupBox5
            size = New System.Drawing.Size(304, 152)
            groupBox6.Size = size
            Me.GroupBox5.TabIndex = 114
            Me.GroupBox5.TabStop = False
            Me.GroupBox5.Text = "Warehouse Inventory"
            Me.btnExpiredProducts.BackColor = System.Drawing.Color.Transparent
            Me.btnExpiredProducts.BorderColor = System.Drawing.Color.Transparent
            cBlendItems6.iColor = New System.Drawing.Color(2) {System.Drawing.Color.Crimson, System.Drawing.Color.Crimson, System.Drawing.Color.Crimson}
            cBlendItems6.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnExpiredProducts.ColorFillBlend = cBlendItems6
            Me.btnExpiredProducts.Corners.All = 3
            Me.btnExpiredProducts.Corners.LowerLeft = 3
            Me.btnExpiredProducts.Corners.LowerRight = 3
            Me.btnExpiredProducts.Corners.UpperLeft = 3
            Me.btnExpiredProducts.Corners.UpperRight = 3
            Me.btnExpiredProducts.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnExpiredProducts.DesignerSelected = False
            Me.btnExpiredProducts.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnExpiredProducts.Image = CType(componentResourceManager.GetObject("btnExpiredProducts.Image"), System.Drawing.Image)
            Me.btnExpiredProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnExpiredProducts.ImageIndex = 0
            Dim cButton16 As CButtonLib.CButton = Me.btnExpiredProducts
            size = New System.Drawing.Size(32, 32)
            cButton16.ImageSize = size
            Dim cButton17 As CButtonLib.CButton = Me.btnExpiredProducts
            location = New System.Drawing.Point(151, 87)
            cButton17.Location = location
            Me.btnExpiredProducts.Name = "btnExpiredProducts"
            Dim cButton18 As CButtonLib.CButton = Me.btnExpiredProducts
            size = New System.Drawing.Size(139, 50)
            cButton18.Size = size
            Me.btnExpiredProducts.TabIndex = 114
            Me.btnExpiredProducts.Text = "Expired Products"
            Me.btnExpiredProducts.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnExpiredProducts.TextShadowShow = False
            Me.btnExpiredProducts.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.btnStockIN.BackColor = System.Drawing.Color.Transparent
            Me.btnStockIN.BorderColor = System.Drawing.Color.Transparent
            cBlendItems7.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems7.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnStockIN.ColorFillBlend = cBlendItems7
            Me.btnStockIN.Corners.All = 3
            Me.btnStockIN.Corners.LowerLeft = 3
            Me.btnStockIN.Corners.LowerRight = 3
            Me.btnStockIN.Corners.UpperLeft = 3
            Me.btnStockIN.Corners.UpperRight = 3
            Me.btnStockIN.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnStockIN.DesignerSelected = False
            Me.btnStockIN.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnStockIN.Image = CType(componentResourceManager.GetObject("btnStockIN.Image"), System.Drawing.Image)
            Me.btnStockIN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnStockIN.ImageIndex = 0
            Dim cButton19 As CButtonLib.CButton = Me.btnStockIN
            size = New System.Drawing.Size(32, 32)
            cButton19.ImageSize = size
            Dim cButton20 As CButtonLib.CButton = Me.btnStockIN
            location = New System.Drawing.Point(6, 31)
            cButton20.Location = location
            Me.btnStockIN.Name = "btnStockIN"
            Dim cButton21 As CButtonLib.CButton = Me.btnStockIN
            size = New System.Drawing.Size(139, 50)
            cButton21.Size = size
            Me.btnStockIN.TabIndex = 111
            Me.btnStockIN.Text = "Available Items"
            Me.btnStockIN.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnStockIN.TextShadowShow = False
            Me.btnStockIN.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.btnLowStock.BackColor = System.Drawing.Color.Transparent
            Me.btnLowStock.BorderColor = System.Drawing.Color.Transparent
            cBlendItems8.iColor = New System.Drawing.Color(2) {System.Drawing.Color.Crimson, System.Drawing.Color.Crimson, System.Drawing.Color.Crimson}
            cBlendItems8.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnLowStock.ColorFillBlend = cBlendItems8
            Me.btnLowStock.Corners.All = 3
            Me.btnLowStock.Corners.LowerLeft = 3
            Me.btnLowStock.Corners.LowerRight = 3
            Me.btnLowStock.Corners.UpperLeft = 3
            Me.btnLowStock.Corners.UpperRight = 3
            Me.btnLowStock.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnLowStock.DesignerSelected = False
            Me.btnLowStock.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnLowStock.Image = CType(componentResourceManager.GetObject("btnLowStock.Image"), System.Drawing.Image)
            Me.btnLowStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnLowStock.ImageIndex = 0
            Dim cButton22 As CButtonLib.CButton = Me.btnLowStock
            size = New System.Drawing.Size(32, 32)
            cButton22.ImageSize = size
            Dim cButton23 As CButtonLib.CButton = Me.btnLowStock
            location = New System.Drawing.Point(6, 87)
            cButton23.Location = location
            Me.btnLowStock.Name = "btnLowStock"
            Dim cButton24 As CButtonLib.CButton = Me.btnLowStock
            size = New System.Drawing.Size(139, 50)
            cButton24.Size = size
            Me.btnLowStock.TabIndex = 113
            Me.btnLowStock.Text = "Low Stock"
            Me.btnLowStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnLowStock.TextShadowShow = False
            Me.btnLowStock.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.btnStockOut.BackColor = System.Drawing.Color.Transparent
            Me.btnStockOut.BorderColor = System.Drawing.Color.Transparent
            cBlendItems9.iColor = New System.Drawing.Color(2) {System.Drawing.Color.Crimson, System.Drawing.Color.Crimson, System.Drawing.Color.Crimson}
            cBlendItems9.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnStockOut.ColorFillBlend = cBlendItems9
            Me.btnStockOut.Corners.All = 3
            Me.btnStockOut.Corners.LowerLeft = 3
            Me.btnStockOut.Corners.LowerRight = 3
            Me.btnStockOut.Corners.UpperLeft = 3
            Me.btnStockOut.Corners.UpperRight = 3
            Me.btnStockOut.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnStockOut.DesignerSelected = False
            Me.btnStockOut.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnStockOut.Image = CType(componentResourceManager.GetObject("btnStockOut.Image"), System.Drawing.Image)
            Me.btnStockOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnStockOut.ImageIndex = 0
            Dim cButton25 As CButtonLib.CButton = Me.btnStockOut
            size = New System.Drawing.Size(32, 32)
            cButton25.ImageSize = size
            Dim cButton26 As CButtonLib.CButton = Me.btnStockOut
            location = New System.Drawing.Point(151, 31)
            cButton26.Location = location
            Me.btnStockOut.Name = "btnStockOut"
            Dim cButton27 As CButtonLib.CButton = Me.btnStockOut
            size = New System.Drawing.Size(139, 50)
            cButton27.Size = size
            Me.btnStockOut.TabIndex = 112
            Me.btnStockOut.Text = "Out of Stock"
            Me.btnStockOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnStockOut.TextShadowShow = False
            Me.btnStockOut.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel3.Controls.Add(Me.btnCollectionsByDP)
            Me.Panel3.Controls.Add(Me.btnCreditors)
            Dim panel3 As System.Windows.Forms.Panel = Me.Panel3
            location = New System.Drawing.Point(343, 404)
            panel3.Location = location
            Me.Panel3.Name = "Panel3"
            Dim panel4 As System.Windows.Forms.Panel = Me.Panel3
            size = New System.Drawing.Size(306, 85)
            panel4.Size = size
            Me.Panel3.TabIndex = 113
            Me.btnCollectionsByDP.BackColor = System.Drawing.Color.Transparent
            Me.btnCollectionsByDP.BorderColor = System.Drawing.Color.Transparent
            cBlendItems10.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems10.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnCollectionsByDP.ColorFillBlend = cBlendItems10
            Me.btnCollectionsByDP.Corners.All = 3
            Me.btnCollectionsByDP.Corners.LowerLeft = 3
            Me.btnCollectionsByDP.Corners.LowerRight = 3
            Me.btnCollectionsByDP.Corners.UpperLeft = 3
            Me.btnCollectionsByDP.Corners.UpperRight = 3
            Me.btnCollectionsByDP.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnCollectionsByDP.DesignerSelected = False
            Me.btnCollectionsByDP.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnCollectionsByDP.Image = CType(componentResourceManager.GetObject("btnCollectionsByDP.Image"), System.Drawing.Image)
            Me.btnCollectionsByDP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnCollectionsByDP.ImageIndex = 0
            Dim cButton28 As CButtonLib.CButton = Me.btnCollectionsByDP
            size = New System.Drawing.Size(32, 32)
            cButton28.ImageSize = size
            Dim cButton29 As CButtonLib.CButton = Me.btnCollectionsByDP
            location = New System.Drawing.Point(9, 17)
            cButton29.Location = location
            Me.btnCollectionsByDP.Name = "btnCollectionsByDP"
            Dim cButton30 As CButtonLib.CButton = Me.btnCollectionsByDP
            size = New System.Drawing.Size(141, 50)
            cButton30.Size = size
            Me.btnCollectionsByDP.TabIndex = 112
            Me.btnCollectionsByDP.Text = "Collections By Delivery Person"
            Me.btnCollectionsByDP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnCollectionsByDP.TextShadowShow = False
            Me.btnCollectionsByDP.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.btnCreditors.BackColor = System.Drawing.Color.Transparent
            Me.btnCreditors.BorderColor = System.Drawing.Color.Transparent
            cBlendItems11.iColor = New System.Drawing.Color(2) {System.Drawing.Color.Crimson, System.Drawing.Color.Crimson, System.Drawing.Color.Crimson}
            cBlendItems11.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnCreditors.ColorFillBlend = cBlendItems11
            Me.btnCreditors.Corners.All = 3
            Me.btnCreditors.Corners.LowerLeft = 3
            Me.btnCreditors.Corners.LowerRight = 3
            Me.btnCreditors.Corners.UpperLeft = 3
            Me.btnCreditors.Corners.UpperRight = 3
            Me.btnCreditors.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnCreditors.DesignerSelected = False
            Me.btnCreditors.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnCreditors.Image = CType(componentResourceManager.GetObject("btnCreditors.Image"), System.Drawing.Image)
            Me.btnCreditors.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnCreditors.ImageIndex = 0
            Dim cButton31 As CButtonLib.CButton = Me.btnCreditors
            size = New System.Drawing.Size(32, 32)
            cButton31.ImageSize = size
            Dim cButton32 As CButtonLib.CButton = Me.btnCreditors
            location = New System.Drawing.Point(154, 17)
            cButton32.Location = location
            Me.btnCreditors.Name = "btnCreditors"
            Dim cButton33 As CButtonLib.CButton = Me.btnCreditors
            size = New System.Drawing.Size(139, 50)
            cButton33.Size = size
            Me.btnCreditors.TabIndex = 110
            Me.btnCreditors.Text = "Creditors List"
            Me.btnCreditors.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnCreditors.TextShadowShow = False
            Me.btnCreditors.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.GroupBox4.Controls.Add(Me.btnGeneralDaybook)
            Me.GroupBox4.Controls.Add(Me.DateTimePicker1)
            Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.GroupBox4.ForeColor = System.Drawing.Color.White
            Dim groupBox7 As System.Windows.Forms.GroupBox = Me.GroupBox4
            location = New System.Drawing.Point(5, 394)
            groupBox7.Location = location
            Me.GroupBox4.Name = "GroupBox4"
            Dim groupBox8 As System.Windows.Forms.GroupBox = Me.GroupBox4
            size = New System.Drawing.Size(332, 95)
            groupBox8.Size = size
            Me.GroupBox4.TabIndex = 112
            Me.GroupBox4.TabStop = False
            Me.GroupBox4.Text = "Search By Date"
            Me.btnGeneralDaybook.BackColor = System.Drawing.Color.Transparent
            Me.btnGeneralDaybook.BorderColor = System.Drawing.Color.Transparent
            cBlendItems12.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems12.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnGeneralDaybook.ColorFillBlend = cBlendItems12
            Me.btnGeneralDaybook.Corners.All = 3
            Me.btnGeneralDaybook.Corners.LowerLeft = 3
            Me.btnGeneralDaybook.Corners.LowerRight = 3
            Me.btnGeneralDaybook.Corners.UpperLeft = 3
            Me.btnGeneralDaybook.Corners.UpperRight = 3
            Me.btnGeneralDaybook.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnGeneralDaybook.DesignerSelected = False
            Me.btnGeneralDaybook.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnGeneralDaybook.Image = CType(componentResourceManager.GetObject("btnGeneralDaybook.Image"), System.Drawing.Image)
            Me.btnGeneralDaybook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnGeneralDaybook.ImageIndex = 0
            Dim cButton34 As CButtonLib.CButton = Me.btnGeneralDaybook
            size = New System.Drawing.Size(32, 32)
            cButton34.ImageSize = size
            Dim cButton35 As CButtonLib.CButton = Me.btnGeneralDaybook
            location = New System.Drawing.Point(185, 30)
            cButton35.Location = location
            Me.btnGeneralDaybook.Name = "btnGeneralDaybook"
            Dim cButton36 As CButtonLib.CButton = Me.btnGeneralDaybook
            size = New System.Drawing.Size(139, 50)
            cButton36.Size = size
            Me.btnGeneralDaybook.TabIndex = 108
            Me.btnGeneralDaybook.Text = "General Daybook"
            Me.btnGeneralDaybook.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnGeneralDaybook.TextShadowShow = False
            Me.btnGeneralDaybook.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
            Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Dim dateTimePicker As System.Windows.Forms.DateTimePicker = Me.DateTimePicker1
            location = New System.Drawing.Point(27, 41)
            dateTimePicker.Location = location
            Me.DateTimePicker1.Name = "DateTimePicker1"
            Dim dateTimePicker2 As System.Windows.Forms.DateTimePicker = Me.DateTimePicker1
            size = New System.Drawing.Size(152, 29)
            dateTimePicker2.Size = size
            Me.DateTimePicker1.TabIndex = 107
            Me.GroupBox3.Controls.Add(Me.btnBalanceSheet)
            Me.GroupBox3.Controls.Add(Me.btnJournalEntry)
            Me.GroupBox3.Controls.Add(Me.GroupBox1)
            Me.GroupBox3.Controls.Add(Me.Panel5)
            Dim groupBox9 As System.Windows.Forms.GroupBox = Me.GroupBox3
            location = New System.Drawing.Point(5, 52)
            groupBox9.Location = location
            Me.GroupBox3.Name = "GroupBox3"
            Dim groupBox10 As System.Windows.Forms.GroupBox = Me.GroupBox3
            size = New System.Drawing.Size(799, 214)
            groupBox10.Size = size
            Me.GroupBox3.TabIndex = 111
            Me.GroupBox3.TabStop = False
            Me.btnBalanceSheet.BackColor = System.Drawing.Color.Transparent
            Me.btnBalanceSheet.BorderColor = System.Drawing.Color.Transparent
            cBlendItems13.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems13.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnBalanceSheet.ColorFillBlend = cBlendItems13
            Me.btnBalanceSheet.Corners.All = 3
            Me.btnBalanceSheet.Corners.LowerLeft = 3
            Me.btnBalanceSheet.Corners.LowerRight = 3
            Me.btnBalanceSheet.Corners.UpperLeft = 3
            Me.btnBalanceSheet.Corners.UpperRight = 3
            Me.btnBalanceSheet.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnBalanceSheet.DesignerSelected = False
            Me.btnBalanceSheet.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnBalanceSheet.Image = CType(componentResourceManager.GetObject("btnBalanceSheet.Image"), System.Drawing.Image)
            Me.btnBalanceSheet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnBalanceSheet.ImageIndex = 0
            Dim cButton37 As CButtonLib.CButton = Me.btnBalanceSheet
            size = New System.Drawing.Size(32, 32)
            cButton37.ImageSize = size
            Dim cButton38 As CButtonLib.CButton = Me.btnBalanceSheet
            location = New System.Drawing.Point(151, 117)
            cButton38.Location = location
            Me.btnBalanceSheet.Name = "btnBalanceSheet"
            Dim cButton39 As CButtonLib.CButton = Me.btnBalanceSheet
            size = New System.Drawing.Size(139, 50)
            cButton39.Size = size
            Me.btnBalanceSheet.TabIndex = 46
            Me.btnBalanceSheet.Text = "Balance Sheet"
            Me.btnBalanceSheet.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnBalanceSheet.TextShadowShow = False
            Me.btnBalanceSheet.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.btnJournalEntry.BackColor = System.Drawing.Color.Transparent
            Me.btnJournalEntry.BorderColor = System.Drawing.Color.Transparent
            cBlendItems14.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems14.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnJournalEntry.ColorFillBlend = cBlendItems14
            Me.btnJournalEntry.Corners.All = 3
            Me.btnJournalEntry.Corners.LowerLeft = 3
            Me.btnJournalEntry.Corners.LowerRight = 3
            Me.btnJournalEntry.Corners.UpperLeft = 3
            Me.btnJournalEntry.Corners.UpperRight = 3
            Me.btnJournalEntry.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnJournalEntry.DesignerSelected = False
            Me.btnJournalEntry.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnJournalEntry.Image = CType(componentResourceManager.GetObject("btnJournalEntry.Image"), System.Drawing.Image)
            Me.btnJournalEntry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnJournalEntry.ImageIndex = 0
            Dim cButton40 As CButtonLib.CButton = Me.btnJournalEntry
            size = New System.Drawing.Size(32, 32)
            cButton40.ImageSize = size
            Dim cButton41 As CButtonLib.CButton = Me.btnJournalEntry
            location = New System.Drawing.Point(6, 117)
            cButton41.Location = location
            Me.btnJournalEntry.Name = "btnJournalEntry"
            Dim cButton42 As CButtonLib.CButton = Me.btnJournalEntry
            size = New System.Drawing.Size(139, 50)
            cButton42.Size = size
            Me.btnJournalEntry.TabIndex = 45
            Me.btnJournalEntry.Text = "Journal Entry"
            Me.btnJournalEntry.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnJournalEntry.TextShadowShow = False
            Me.btnJournalEntry.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.GroupBox1.Controls.Add(Me.Label4)
            Me.GroupBox1.Controls.Add(Me.dtpDateTo)
            Me.GroupBox1.Controls.Add(Me.dtpDateFrom)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.GroupBox1.ForeColor = System.Drawing.Color.White
            Dim groupBox11 As System.Windows.Forms.GroupBox = Me.GroupBox1
            location = New System.Drawing.Point(6, 9)
            groupBox11.Location = location
            Me.GroupBox1.Name = "GroupBox1"
            Dim groupBox12 As System.Windows.Forms.GroupBox = Me.GroupBox1
            size = New System.Drawing.Size(355, 102)
            groupBox12.Size = size
            Me.GroupBox1.TabIndex = 3
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Search By Date :"
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label As System.Windows.Forms.Label = Me.Label4
            location = New System.Drawing.Point(185, 32)
            label.Location = location
            Me.Label4.Name = "Label4"
            Dim label2 As System.Windows.Forms.Label = Me.Label4
            size = New System.Drawing.Size(35, 20)
            label2.Size = size
            Me.Label4.TabIndex = 10
            Me.Label4.Text = "To :"
            Me.dtpDateTo.CustomFormat = "dd/MM/yyyy"
            Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Dim dateTimePicker3 As System.Windows.Forms.DateTimePicker = Me.dtpDateTo
            location = New System.Drawing.Point(189, 60)
            dateTimePicker3.Location = location
            Me.dtpDateTo.Name = "dtpDateTo"
            Dim dateTimePicker4 As System.Windows.Forms.DateTimePicker = Me.dtpDateTo
            size = New System.Drawing.Size(156, 29)
            dateTimePicker4.Size = size
            Me.dtpDateTo.TabIndex = 107
            Me.dtpDateFrom.CustomFormat = "dd/MM/yyyy"
            Me.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Dim dateTimePicker5 As System.Windows.Forms.DateTimePicker = Me.dtpDateFrom
            location = New System.Drawing.Point(22, 60)
            dateTimePicker5.Location = location
            Me.dtpDateFrom.Name = "dtpDateFrom"
            Dim dateTimePicker6 As System.Windows.Forms.DateTimePicker = Me.dtpDateFrom
            size = New System.Drawing.Size(152, 29)
            dateTimePicker6.Size = size
            Me.dtpDateFrom.TabIndex = 106
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label3 As System.Windows.Forms.Label = Me.Label2
            location = New System.Drawing.Point(18, 32)
            label3.Location = location
            Me.Label2.Name = "Label2"
            Dim label4 As System.Windows.Forms.Label = Me.Label2
            size = New System.Drawing.Size(54, 20)
            label4.Size = size
            Me.Label2.TabIndex = 9
            Me.Label2.Text = "From :"
            Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel5.Controls.Add(Me.lblUser)
            Me.Panel5.Controls.Add(Me.btnInputTax)
            Me.Panel5.Controls.Add(Me.btnGeneralLedger)
            Me.Panel5.Controls.Add(Me.btnTaxReport)
            Me.Panel5.Controls.Add(Me.btnStockTransfer)
            Me.Panel5.Controls.Add(Me.btnVouchers)
            Me.Panel5.Controls.Add(Me.btnPurchase)
            Me.Panel5.Controls.Add(Me.btnTrialBalance)
            Me.Panel5.Controls.Add(Me.txtCashBook)
            Me.Panel5.Controls.Add(Me.btnPurchaseDaybook)
            Dim panel5 As System.Windows.Forms.Panel = Me.Panel5
            location = New System.Drawing.Point(367, 19)
            panel5.Location = location
            Me.Panel5.Name = "Panel5"
            Dim panel6 As System.Windows.Forms.Panel = Me.Panel5
            size = New System.Drawing.Size(426, 183)
            panel6.Size = size
            Me.Panel5.TabIndex = 42
            Me.lblUser.AutoSize = True
            Dim label5 As System.Windows.Forms.Label = Me.lblUser
            location = New System.Drawing.Point(265, -11)
            label5.Location = location
            Me.lblUser.Name = "lblUser"
            Dim label6 As System.Windows.Forms.Label = Me.lblUser
            size = New System.Drawing.Size(29, 13)
            label6.Size = size
            Me.lblUser.TabIndex = 402
            Me.lblUser.Text = "User"
            Me.lblUser.Visible = False
            Me.btnInputTax.BackColor = System.Drawing.Color.Transparent
            Me.btnInputTax.BorderColor = System.Drawing.Color.Transparent
            cBlendItems15.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems15.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnInputTax.ColorFillBlend = cBlendItems15
            Me.btnInputTax.Corners.All = 3
            Me.btnInputTax.Corners.LowerLeft = 3
            Me.btnInputTax.Corners.LowerRight = 3
            Me.btnInputTax.Corners.UpperLeft = 3
            Me.btnInputTax.Corners.UpperRight = 3
            Me.btnInputTax.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnInputTax.DesignerSelected = False
            Me.btnInputTax.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnInputTax.Image = CType(componentResourceManager.GetObject("btnInputTax.Image"), System.Drawing.Image)
            Me.btnInputTax.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnInputTax.ImageIndex = 0
            Dim cButton43 As CButtonLib.CButton = Me.btnInputTax
            size = New System.Drawing.Size(32, 32)
            cButton43.ImageSize = size
            Dim cButton44 As CButtonLib.CButton = Me.btnInputTax
            location = New System.Drawing.Point(282, 125)
            cButton44.Location = location
            Me.btnInputTax.Name = "btnInputTax"
            Dim cButton45 As CButtonLib.CButton = Me.btnInputTax
            size = New System.Drawing.Size(132, 50)
            cButton45.Size = size
            Me.btnInputTax.TabIndex = 115
            Me.btnInputTax.Text = "Input Tax"
            Me.btnInputTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnInputTax.TextShadowShow = False
            Me.btnInputTax.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.btnGeneralLedger.BackColor = System.Drawing.Color.Transparent
            Me.btnGeneralLedger.BorderColor = System.Drawing.Color.Transparent
            cBlendItems16.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems16.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnGeneralLedger.ColorFillBlend = cBlendItems16
            Me.btnGeneralLedger.Corners.All = 3
            Me.btnGeneralLedger.Corners.LowerLeft = 3
            Me.btnGeneralLedger.Corners.LowerRight = 3
            Me.btnGeneralLedger.Corners.UpperLeft = 3
            Me.btnGeneralLedger.Corners.UpperRight = 3
            Me.btnGeneralLedger.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnGeneralLedger.DesignerSelected = False
            Me.btnGeneralLedger.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnGeneralLedger.Image = CType(componentResourceManager.GetObject("btnGeneralLedger.Image"), System.Drawing.Image)
            Me.btnGeneralLedger.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnGeneralLedger.ImageIndex = 0
            Dim cButton46 As CButtonLib.CButton = Me.btnGeneralLedger
            size = New System.Drawing.Size(32, 32)
            cButton46.ImageSize = size
            Dim cButton47 As CButtonLib.CButton = Me.btnGeneralLedger
            location = New System.Drawing.Point(282, 13)
            cButton47.Location = location
            Me.btnGeneralLedger.Name = "btnGeneralLedger"
            Dim cButton48 As CButtonLib.CButton = Me.btnGeneralLedger
            size = New System.Drawing.Size(132, 50)
            cButton48.Size = size
            Me.btnGeneralLedger.TabIndex = 114
            Me.btnGeneralLedger.Text = "General Ledger"
            Me.btnGeneralLedger.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnGeneralLedger.TextShadowShow = False
            Me.btnGeneralLedger.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.btnTaxReport.BackColor = System.Drawing.Color.Transparent
            Me.btnTaxReport.BorderColor = System.Drawing.Color.Transparent
            cBlendItems17.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems17.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnTaxReport.ColorFillBlend = cBlendItems17
            Me.btnTaxReport.Corners.All = 3
            Me.btnTaxReport.Corners.LowerLeft = 3
            Me.btnTaxReport.Corners.LowerRight = 3
            Me.btnTaxReport.Corners.UpperLeft = 3
            Me.btnTaxReport.Corners.UpperRight = 3
            Me.btnTaxReport.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnTaxReport.DesignerSelected = False
            Me.btnTaxReport.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnTaxReport.Image = CType(componentResourceManager.GetObject("btnTaxReport.Image"), System.Drawing.Image)
            Me.btnTaxReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnTaxReport.ImageIndex = 0
            Dim cButton49 As CButtonLib.CButton = Me.btnTaxReport
            size = New System.Drawing.Size(32, 32)
            cButton49.ImageSize = size
            Dim cButton50 As CButtonLib.CButton = Me.btnTaxReport
            location = New System.Drawing.Point(152, 125)
            cButton50.Location = location
            Me.btnTaxReport.Name = "btnTaxReport"
            Dim cButton51 As CButtonLib.CButton = Me.btnTaxReport
            size = New System.Drawing.Size(124, 50)
            cButton51.Size = size
            Me.btnTaxReport.TabIndex = 113
            Me.btnTaxReport.Text = "Output Tax"
            Me.btnTaxReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnTaxReport.TextShadowShow = False
            Me.btnTaxReport.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.btnStockTransfer.BackColor = System.Drawing.Color.Transparent
            Me.btnStockTransfer.BorderColor = System.Drawing.Color.Transparent
            cBlendItems18.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems18.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnStockTransfer.ColorFillBlend = cBlendItems18
            Me.btnStockTransfer.Corners.All = 3
            Me.btnStockTransfer.Corners.LowerLeft = 3
            Me.btnStockTransfer.Corners.LowerRight = 3
            Me.btnStockTransfer.Corners.UpperLeft = 3
            Me.btnStockTransfer.Corners.UpperRight = 3
            Me.btnStockTransfer.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnStockTransfer.DesignerSelected = False
            Me.btnStockTransfer.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnStockTransfer.Image = CType(componentResourceManager.GetObject("btnStockTransfer.Image"), System.Drawing.Image)
            Me.btnStockTransfer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnStockTransfer.ImageIndex = 0
            Dim cButton52 As CButtonLib.CButton = Me.btnStockTransfer
            size = New System.Drawing.Size(32, 32)
            cButton52.ImageSize = size
            Dim cButton53 As CButtonLib.CButton = Me.btnStockTransfer
            location = New System.Drawing.Point(7, 125)
            cButton53.Location = location
            Me.btnStockTransfer.Name = "btnStockTransfer"
            Dim cButton54 As CButtonLib.CButton = Me.btnStockTransfer
            size = New System.Drawing.Size(139, 50)
            cButton54.Size = size
            Me.btnStockTransfer.TabIndex = 12
            Me.btnStockTransfer.Text = "Stock Transfer"
            Me.btnStockTransfer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnStockTransfer.TextShadowShow = False
            Me.btnStockTransfer.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.btnVouchers.BackColor = System.Drawing.Color.Transparent
            Me.btnVouchers.BorderColor = System.Drawing.Color.Transparent
            cBlendItems19.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems19.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnVouchers.ColorFillBlend = cBlendItems19
            Me.btnVouchers.Corners.All = 3
            Me.btnVouchers.Corners.LowerLeft = 3
            Me.btnVouchers.Corners.LowerRight = 3
            Me.btnVouchers.Corners.UpperLeft = 3
            Me.btnVouchers.Corners.UpperRight = 3
            Me.btnVouchers.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnVouchers.DesignerSelected = False
            Me.btnVouchers.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnVouchers.Image = CType(componentResourceManager.GetObject("btnVouchers.Image"), System.Drawing.Image)
            Me.btnVouchers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnVouchers.ImageIndex = 0
            Dim cButton55 As CButtonLib.CButton = Me.btnVouchers
            size = New System.Drawing.Size(32, 32)
            cButton55.ImageSize = size
            Dim cButton56 As CButtonLib.CButton = Me.btnVouchers
            location = New System.Drawing.Point(282, 69)
            cButton56.Location = location
            Me.btnVouchers.Name = "btnVouchers"
            Dim cButton57 As CButtonLib.CButton = Me.btnVouchers
            size = New System.Drawing.Size(132, 50)
            cButton57.Size = size
            Me.btnVouchers.TabIndex = 11
            Me.btnVouchers.Text = "Vouchers"
            Me.btnVouchers.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnVouchers.TextShadowShow = False
            Me.btnVouchers.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.btnPurchase.BackColor = System.Drawing.Color.Transparent
            Me.btnPurchase.BorderColor = System.Drawing.Color.Transparent
            cBlendItems20.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems20.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnPurchase.ColorFillBlend = cBlendItems20
            Me.btnPurchase.Corners.All = 3
            Me.btnPurchase.Corners.LowerLeft = 3
            Me.btnPurchase.Corners.LowerRight = 3
            Me.btnPurchase.Corners.UpperLeft = 3
            Me.btnPurchase.Corners.UpperRight = 3
            Me.btnPurchase.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnPurchase.DesignerSelected = False
            Me.btnPurchase.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnPurchase.Image = CType(componentResourceManager.GetObject("btnPurchase.Image"), System.Drawing.Image)
            Me.btnPurchase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnPurchase.ImageIndex = 0
            Dim cButton58 As CButtonLib.CButton = Me.btnPurchase
            size = New System.Drawing.Size(32, 32)
            cButton58.ImageSize = size
            Dim cButton59 As CButtonLib.CButton = Me.btnPurchase
            location = New System.Drawing.Point(152, 69)
            cButton59.Location = location
            Me.btnPurchase.Name = "btnPurchase"
            Dim cButton60 As CButtonLib.CButton = Me.btnPurchase
            size = New System.Drawing.Size(124, 50)
            cButton60.Size = size
            Me.btnPurchase.TabIndex = 9
            Me.btnPurchase.Text = "Purchases"
            Me.btnPurchase.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnPurchase.TextShadowShow = False
            Me.btnPurchase.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.btnTrialBalance.BackColor = System.Drawing.Color.Transparent
            Me.btnTrialBalance.BorderColor = System.Drawing.Color.Transparent
            cBlendItems21.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems21.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnTrialBalance.ColorFillBlend = cBlendItems21
            Me.btnTrialBalance.Corners.All = 3
            Me.btnTrialBalance.Corners.LowerLeft = 3
            Me.btnTrialBalance.Corners.LowerRight = 3
            Me.btnTrialBalance.Corners.UpperLeft = 3
            Me.btnTrialBalance.Corners.UpperRight = 3
            Me.btnTrialBalance.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnTrialBalance.DesignerSelected = False
            Me.btnTrialBalance.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnTrialBalance.Image = CType(componentResourceManager.GetObject("btnTrialBalance.Image"), System.Drawing.Image)
            Me.btnTrialBalance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnTrialBalance.ImageIndex = 0
            Dim cButton61 As CButtonLib.CButton = Me.btnTrialBalance
            size = New System.Drawing.Size(32, 32)
            cButton61.ImageSize = size
            Dim cButton62 As CButtonLib.CButton = Me.btnTrialBalance
            location = New System.Drawing.Point(7, 69)
            cButton62.Location = location
            Me.btnTrialBalance.Name = "btnTrialBalance"
            Dim cButton63 As CButtonLib.CButton = Me.btnTrialBalance
            size = New System.Drawing.Size(139, 50)
            cButton63.Size = size
            Me.btnTrialBalance.TabIndex = 8
            Me.btnTrialBalance.Text = "Trial Balance"
            Me.btnTrialBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnTrialBalance.TextShadowShow = False
            Me.btnTrialBalance.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.txtCashBook.BackColor = System.Drawing.Color.Transparent
            Me.txtCashBook.BorderColor = System.Drawing.Color.Transparent
            cBlendItems22.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems22.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.txtCashBook.ColorFillBlend = cBlendItems22
            Me.txtCashBook.Corners.All = 3
            Me.txtCashBook.Corners.LowerLeft = 3
            Me.txtCashBook.Corners.LowerRight = 3
            Me.txtCashBook.Corners.UpperLeft = 3
            Me.txtCashBook.Corners.UpperRight = 3
            Me.txtCashBook.Cursor = System.Windows.Forms.Cursors.Hand
            Me.txtCashBook.DesignerSelected = False
            Me.txtCashBook.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.txtCashBook.Image = CType(componentResourceManager.GetObject("txtCashBook.Image"), System.Drawing.Image)
            Me.txtCashBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.txtCashBook.ImageIndex = 0
            Dim cButton64 As CButtonLib.CButton = Me.txtCashBook
            size = New System.Drawing.Size(32, 32)
            cButton64.ImageSize = size
            Dim cButton65 As CButtonLib.CButton = Me.txtCashBook
            location = New System.Drawing.Point(152, 13)
            cButton65.Location = location
            Me.txtCashBook.Name = "txtCashBook"
            Dim cButton66 As CButtonLib.CButton = Me.txtCashBook
            size = New System.Drawing.Size(124, 50)
            cButton66.Size = size
            Me.txtCashBook.TabIndex = 6
            Me.txtCashBook.Text = "Cash Book"
            Me.txtCashBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.txtCashBook.TextShadowShow = False
            Me.txtCashBook.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.btnPurchaseDaybook.BackColor = System.Drawing.Color.Transparent
            Me.btnPurchaseDaybook.BorderColor = System.Drawing.Color.Transparent
            cBlendItems23.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems23.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnPurchaseDaybook.ColorFillBlend = cBlendItems23
            Me.btnPurchaseDaybook.Corners.All = 3
            Me.btnPurchaseDaybook.Corners.LowerLeft = 3
            Me.btnPurchaseDaybook.Corners.LowerRight = 3
            Me.btnPurchaseDaybook.Corners.UpperLeft = 3
            Me.btnPurchaseDaybook.Corners.UpperRight = 3
            Me.btnPurchaseDaybook.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnPurchaseDaybook.DesignerSelected = False
            Me.btnPurchaseDaybook.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnPurchaseDaybook.Image = CType(componentResourceManager.GetObject("btnPurchaseDaybook.Image"), System.Drawing.Image)
            Me.btnPurchaseDaybook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnPurchaseDaybook.ImageIndex = 0
            Dim cButton67 As CButtonLib.CButton = Me.btnPurchaseDaybook
            size = New System.Drawing.Size(32, 32)
            cButton67.ImageSize = size
            Dim cButton68 As CButtonLib.CButton = Me.btnPurchaseDaybook
            location = New System.Drawing.Point(7, 13)
            cButton68.Location = location
            Me.btnPurchaseDaybook.Name = "btnPurchaseDaybook"
            Dim cButton69 As CButtonLib.CButton = Me.btnPurchaseDaybook
            size = New System.Drawing.Size(139, 50)
            cButton69.Size = size
            Me.btnPurchaseDaybook.TabIndex = 5
            Me.btnPurchaseDaybook.Text = "Purchase Daybook"
            Me.btnPurchaseDaybook.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnPurchaseDaybook.TextShadowShow = False
            Me.btnPurchaseDaybook.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnReset.DesignerSelected = False
            Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnReset.Image = CType(componentResourceManager.GetObject("btnReset.Image"), System.Drawing.Image)
            Me.btnReset.ImageIndex = 0
            Dim cButton70 As CButtonLib.CButton = Me.btnReset
            size = New System.Drawing.Size(48, 48)
            cButton70.ImageSize = size
            Dim cButton71 As CButtonLib.CButton = Me.btnReset
            location = New System.Drawing.Point(719, 5)
            cButton71.Location = location
            Me.btnReset.Name = "btnReset"
            Dim cButton72 As CButtonLib.CButton = Me.btnReset
            size = New System.Drawing.Size(40, 41)
            cButton72.Size = size
            Me.btnReset.TabIndex = 0
            Me.btnReset.Text = ""
            Me.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.GroupBox2.Controls.Add(Me.cmbSupplierName)
            Me.GroupBox2.Controls.Add(Me.Label3)
            Me.GroupBox2.Controls.Add(Me.DateTimePicker2)
            Me.GroupBox2.Controls.Add(Me.Label5)
            Me.GroupBox2.Controls.Add(Me.Label6)
            Me.GroupBox2.Controls.Add(Me.btnSupplierLedger)
            Me.GroupBox2.Controls.Add(Me.DateTimePicker3)
            Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.GroupBox2.ForeColor = System.Drawing.Color.White
            Dim groupBox13 As System.Windows.Forms.GroupBox = Me.GroupBox2
            location = New System.Drawing.Point(6, 272)
            groupBox13.Location = location
            Me.GroupBox2.Name = "GroupBox2"
            Dim groupBox14 As System.Windows.Forms.GroupBox = Me.GroupBox2
            size = New System.Drawing.Size(758, 116)
            groupBox14.Size = size
            Me.GroupBox2.TabIndex = 110
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Search by Supplier Name and Date"
            Me.cmbSupplierName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
            Me.cmbSupplierName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
            Me.cmbSupplierName.FormattingEnabled = True
            Dim comboBox As System.Windows.Forms.ComboBox = Me.cmbSupplierName
            location = New System.Drawing.Point(20, 65)
            comboBox.Location = location
            Me.cmbSupplierName.Name = "cmbSupplierName"
            Dim comboBox2 As System.Windows.Forms.ComboBox = Me.cmbSupplierName
            size = New System.Drawing.Size(234, 32)
            comboBox2.Size = size
            Me.cmbSupplierName.TabIndex = 0
            Me.Label3.AutoSize = True
            Dim label7 As System.Windows.Forms.Label = Me.Label3
            location = New System.Drawing.Point(19, 38)
            label7.Location = location
            Me.Label3.Name = "Label3"
            Dim label8 As System.Windows.Forms.Label = Me.Label3
            size = New System.Drawing.Size(146, 24)
            label8.Size = size
            Me.Label3.TabIndex = 16
            Me.Label3.Text = "Supplier Name :"
            Me.DateTimePicker2.CustomFormat = "dd/MM/yyyy"
            Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Dim dateTimePicker7 As System.Windows.Forms.DateTimePicker = Me.DateTimePicker2
            location = New System.Drawing.Point(449, 64)
            dateTimePicker7.Location = location
            Me.DateTimePicker2.Name = "DateTimePicker2"
            Dim dateTimePicker8 As System.Windows.Forms.DateTimePicker = Me.DateTimePicker2
            size = New System.Drawing.Size(170, 29)
            dateTimePicker8.Size = size
            Me.DateTimePicker2.TabIndex = 2
            Me.Label5.AutoSize = True
            Dim label9 As System.Windows.Forms.Label = Me.Label5
            location = New System.Drawing.Point(445, 37)
            label9.Location = location
            Me.Label5.Name = "Label5"
            Dim label10 As System.Windows.Forms.Label = Me.Label5
            size = New System.Drawing.Size(43, 24)
            label10.Size = size
            Me.Label5.TabIndex = 13
            Me.Label5.Text = "To :"
            Me.Label6.AutoSize = True
            Dim label11 As System.Windows.Forms.Label = Me.Label6
            location = New System.Drawing.Point(262, 38)
            label11.Location = location
            Me.Label6.Name = "Label6"
            Dim label12 As System.Windows.Forms.Label = Me.Label6
            size = New System.Drawing.Size(65, 24)
            label12.Size = size
            Me.Label6.TabIndex = 12
            Me.Label6.Text = "From :"
            Me.btnSupplierLedger.BackColor = System.Drawing.Color.Transparent
            Me.btnSupplierLedger.BorderColor = System.Drawing.Color.Transparent
            cBlendItems24.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems24.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnSupplierLedger.ColorFillBlend = cBlendItems24
            Me.btnSupplierLedger.Corners.All = 3
            Me.btnSupplierLedger.Corners.LowerLeft = 3
            Me.btnSupplierLedger.Corners.LowerRight = 3
            Me.btnSupplierLedger.Corners.UpperLeft = 3
            Me.btnSupplierLedger.Corners.UpperRight = 3
            Me.btnSupplierLedger.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnSupplierLedger.DesignerSelected = False
            Me.btnSupplierLedger.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnSupplierLedger.Image = CType(componentResourceManager.GetObject("btnSupplierLedger.Image"), System.Drawing.Image)
            Me.btnSupplierLedger.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnSupplierLedger.ImageIndex = 0
            Dim cButton73 As CButtonLib.CButton = Me.btnSupplierLedger
            size = New System.Drawing.Size(32, 32)
            cButton73.ImageSize = size
            Dim cButton74 As CButtonLib.CButton = Me.btnSupplierLedger
            location = New System.Drawing.Point(625, 54)
            cButton74.Location = location
            Me.btnSupplierLedger.Name = "btnSupplierLedger"
            Dim cButton75 As CButtonLib.CButton = Me.btnSupplierLedger
            size = New System.Drawing.Size(124, 50)
            cButton75.Size = size
            Me.btnSupplierLedger.TabIndex = 7
            Me.btnSupplierLedger.Text = "Supplier Ledger"
            Me.btnSupplierLedger.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnSupplierLedger.TextShadowShow = False
            Me.btnSupplierLedger.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.DateTimePicker3.CustomFormat = "dd/MM/yyyy"
            Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Dim dateTimePicker9 As System.Windows.Forms.DateTimePicker = Me.DateTimePicker3
            location = New System.Drawing.Point(260, 64)
            dateTimePicker9.Location = location
            Me.DateTimePicker3.Name = "DateTimePicker3"
            Dim dateTimePicker10 As System.Windows.Forms.DateTimePicker = Me.DateTimePicker3
            size = New System.Drawing.Size(183, 29)
            dateTimePicker10.Size = size
            Me.DateTimePicker3.TabIndex = 1
            Me.Panel2.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel2.Controls.Add(Me.txtSupplierID)
            Me.Panel2.Controls.Add(Me.Label1)
            Dim panel7 As System.Windows.Forms.Panel = Me.Panel2
            location = New System.Drawing.Point(5, 5)
            panel7.Location = location
            Me.Panel2.Name = "Panel2"
            Dim panel8 As System.Windows.Forms.Panel = Me.Panel2
            size = New System.Drawing.Size(708, 41)
            panel8.Size = size
            Me.Panel2.TabIndex = 0
            Dim textBox As System.Windows.Forms.TextBox = Me.txtSupplierID
            location = New System.Drawing.Point(47, 12)
            textBox.Location = location
            Me.txtSupplierID.Name = "txtSupplierID"
            Dim textBox2 As System.Windows.Forms.TextBox = Me.txtSupplierID
            size = New System.Drawing.Size(16, 20)
            textBox2.Size = size
            Me.txtSupplierID.TabIndex = 2
            Me.txtSupplierID.Visible = False
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label1.ForeColor = System.Drawing.Color.White
            Dim label13 As System.Windows.Forms.Label = Me.Label1
            location = New System.Drawing.Point(255, 6)
            label13.Location = location
            Me.Label1.Name = "Label1"
            Dim label14 As System.Windows.Forms.Label = Me.Label1
            size = New System.Drawing.Size(218, 25)
            label14.Size = size
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Accounting Reports"
            Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnClose.DesignerSelected = False
            Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnClose.Image = CType(componentResourceManager.GetObject("btnClose.Image"), System.Drawing.Image)
            Me.btnClose.ImageIndex = 0
            Dim cButton76 As CButtonLib.CButton = Me.btnClose
            size = New System.Drawing.Size(48, 48)
            cButton76.ImageSize = size
            Dim cButton77 As CButtonLib.CButton = Me.btnClose
            location = New System.Drawing.Point(764, 5)
            cButton77.Location = location
            Me.btnClose.Name = "btnClose"
            Dim cButton78 As CButtonLib.CButton = Me.btnClose
            size = New System.Drawing.Size(40, 41)
            cButton78.Size = size
            Me.btnClose.TabIndex = 4
            Me.btnClose.Text = ""
            Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            size = New System.Drawing.Size(822, 662)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.Panel1)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MaximizeBox = False
            MyBase.MinimizeBox = False
            MyBase.Name = "frmAccountingReport"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Panel1.ResumeLayout(False)
            Me.GroupBox7.ResumeLayout(False)
            Me.GroupBox6.ResumeLayout(False)
            Me.GroupBox5.ResumeLayout(False)
            Me.Panel3.ResumeLayout(False)
            Me.GroupBox4.ResumeLayout(False)
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.Panel5.ResumeLayout(False)
            Me.Panel5.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            MyBase.ResumeLayout(False)
        End Sub

    End Class
End Namespace
