Imports System
Imports System.Collections
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
Imports RestaurantPOS14.My.Resources

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public Class frmPurchaseEntry
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel1")>
        Private _Panel1 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label3")>
        Private _Label3 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtInvoiceNo")>
        Private _txtInvoiceNo As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel2")>
        Private _Panel2 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label1")>
        Private _Label1 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label2")>
        Private _Label2 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DataGridView1")>
        Private _DataGridView1 As System.Windows.Forms.DataGridView

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox2")>
        Private _GroupBox2 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtTotalAmount")>
        Private _txtTotalAmount As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtPricePerQty")>
        Private _txtPricePerQty As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtQty")>
        Private _txtQty As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label9")>
        Private _Label9 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label6")>
        Private _Label6 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label4")>
        Private _Label4 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label8")>
        Private _Label8 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox1")>
        Private _GroupBox1 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("dtpDate")>
        Private _dtpDate As System.Windows.Forms.DateTimePicker

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtRemarks")>
        Private _txtRemarks As System.Windows.Forms.RichTextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label12")>
        Private _Label12 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtSup_ID")>
        Private _txtSup_ID As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtST_ID")>
        Private _txtST_ID As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblUser")>
        Private _lblUser As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblSet")>
        Private _lblSet As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblUserType")>
        Private _lblUserType As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("gbPartyInfo")>
        Private _gbPartyInfo As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnSelection")>
        Private _btnSelection As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label10")>
        Private _Label10 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtSupplierID")>
        Private _txtSupplierID As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblBalance")>
        Private _lblBalance As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label11")>
        Private _Label11 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtContactNo")>
        Private _txtContactNo As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtSupplierName")>
        Private _txtSupplierName As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtCity")>
        Private _txtCity As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtAddress")>
        Private _txtAddress As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label26")>
        Private _Label26 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label29")>
        Private _Label29 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label30")>
        Private _Label30 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label36")>
        Private _Label36 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("cmbPurchaseType")>
        Private _cmbPurchaseType As System.Windows.Forms.ComboBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnClose")>
        Private _btnClose As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox3")>
        Private _GroupBox3 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnNew")>
        Private _btnNew As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnGetData")>
        Private _btnGetData As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnSave")>
        Private _btnSave As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnDelete")>
        Private _btnDelete As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("cmbProductName")>
        Private _cmbProductName As System.Windows.Forms.ComboBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtProductID")>
        Private _txtProductID As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnRemove")>
        Private _btnRemove As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnAdd")>
        Private _btnAdd As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("cmbWarehouse")>
        Private _cmbWarehouse As System.Windows.Forms.ComboBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label7")>
        Private _Label7 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("dtpExpiryDate")>
        Private _dtpExpiryDate As System.Windows.Forms.DateTimePicker

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("chkHasExpiryDate")>
        Private _chkHasExpiryDate As System.Windows.Forms.CheckBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblUnit")>
        Private _lblUnit As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column1")>
        Private _Column1 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column3")>
        Private _Column3 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column2")>
        Private _Column2 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column4")>
        Private _Column4 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column5")>
        Private _Column5 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column6")>
        Private _Column6 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column7")>
        Private _Column7 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column8")>
        Private _Column8 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("pnlCalc")>
        Private _pnlCalc As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtVATAmt")>
        Private _txtVATAmt As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label14")>
        Private _Label14 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label15")>
        Private _Label15 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtVATPer")>
        Private _txtVATPer As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtDisc")>
        Private _txtDisc As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label45")>
        Private _Label45 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label46")>
        Private _Label46 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtDiscPer")>
        Private _txtDiscPer As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label32")>
        Private _Label32 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtTotal")>
        Private _txtTotal As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label24")>
        Private _Label24 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtPreviousDue")>
        Private _txtPreviousDue As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtBalance")>
        Private _txtBalance As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label18")>
        Private _Label18 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label17")>
        Private _Label17 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label16")>
        Private _Label16 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtRoundOff")>
        Private _txtRoundOff As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtTotalPaid")>
        Private _txtTotalPaid As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtGrandTotal")>
        Private _txtGrandTotal As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtOtherCharges")>
        Private _txtOtherCharges As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtFreightCharges")>
        Private _txtFreightCharges As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label21")>
        Private _Label21 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtSubTotal")>
        Private _txtSubTotal As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label31")>
        Private _Label31 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Button1")>
        Private _Button1 As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Button2")>
        Private _Button2 As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnPayment")>
        Private _btnPayment As CButtonLib.CButton

        Private str As String

        Private st As String

        Private OBtype As String

        Private num1 As Decimal

        Private num2 As Decimal

        Private num3 As Decimal

        Private num4 As Decimal

        Private num5 As Decimal

        Private num6 As Decimal

        Private num7 As Decimal

        Private num8 As Decimal

        Private num9 As Decimal

        Private num10 As Decimal

        Private num11 As Decimal

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

        Friend Overridable Property txtInvoiceNo As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtInvoiceNo
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtInvoiceNo = value
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

        Friend Overridable Property DataGridView1 As System.Windows.Forms.DataGridView
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._DataGridView1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridView)
                Dim value2 As System.Windows.Forms.DataGridViewRowPostPaintEventHandler = AddressOf Me.DataGridView1_RowPostPaint
                Dim value3 As System.Windows.Forms.MouseEventHandler = AddressOf Me.DataGridView1_MouseClick
                If Me._DataGridView1 IsNot Nothing Then
                    RemoveHandler Me._DataGridView1.RowPostPaint, value2
                    RemoveHandler Me._DataGridView1.MouseClick, value3
                End If

                Me._DataGridView1 = value
                If Me._DataGridView1 IsNot Nothing Then
                    AddHandler Me._DataGridView1.RowPostPaint, value2
                    AddHandler Me._DataGridView1.MouseClick, value3
                End If
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

        Friend Overridable Property txtTotalAmount As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtTotalAmount
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtTotalAmount = value
            End Set
        End Property

        Friend Overridable Property txtPricePerQty As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtPricePerQty
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.Windows.Forms.KeyPressEventHandler = AddressOf Me.txtPricePerQty_KeyPress
                Dim value3 As System.EventHandler = AddressOf Me.txtPricePerQty_TextChanged
                If Me._txtPricePerQty IsNot Nothing Then
                    RemoveHandler Me._txtPricePerQty.KeyPress, value2
                    RemoveHandler Me._txtPricePerQty.TextChanged, value3
                End If

                Me._txtPricePerQty = value
                If Me._txtPricePerQty IsNot Nothing Then
                    AddHandler Me._txtPricePerQty.KeyPress, value2
                    AddHandler Me._txtPricePerQty.TextChanged, value3
                End If
            End Set
        End Property

        Friend Overridable Property txtQty As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtQty
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.EventHandler = AddressOf Me.txtQty_TextChanged
                Dim value3 As System.Windows.Forms.KeyPressEventHandler = AddressOf Me.txtQty_KeyPress
                If Me._txtQty IsNot Nothing Then
                    RemoveHandler Me._txtQty.TextChanged, value2
                    RemoveHandler Me._txtQty.KeyPress, value3
                End If

                Me._txtQty = value
                If Me._txtQty IsNot Nothing Then
                    AddHandler Me._txtQty.TextChanged, value2
                    AddHandler Me._txtQty.KeyPress, value3
                End If
            End Set
        End Property

        Friend Overridable Property Label9 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label9
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label9 = value
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

        Friend Overridable Property Label8 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label8
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label8 = value
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

        Friend Overridable Property dtpDate As System.Windows.Forms.DateTimePicker
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._dtpDate
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DateTimePicker)
                Me._dtpDate = value
            End Set
        End Property

        Friend Overridable Property txtRemarks As System.Windows.Forms.RichTextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtRemarks
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.RichTextBox)
                Me._txtRemarks = value
            End Set
        End Property

        Friend Overridable Property Label12 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label12
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label12 = value
            End Set
        End Property

        Friend Overridable Property txtSup_ID As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtSup_ID
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtSup_ID = value
            End Set
        End Property

        Friend Overridable Property txtST_ID As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtST_ID
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtST_ID = value
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

        Friend Overridable Property lblSet As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._lblSet
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._lblSet = value
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

        Friend Overridable Property gbPartyInfo As System.Windows.Forms.GroupBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._gbPartyInfo
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.GroupBox)
                Me._gbPartyInfo = value
            End Set
        End Property

        Friend Overridable Property btnSelection As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnSelection
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.Button2_Click
                If Me._btnSelection IsNot Nothing Then
                    RemoveHandler Me._btnSelection.Click, value2
                End If

                Me._btnSelection = value
                If Me._btnSelection IsNot Nothing Then
                    AddHandler Me._btnSelection.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property Label10 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label10
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label10 = value
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

        Friend Overridable Property lblBalance As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._lblBalance
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._lblBalance = value
            End Set
        End Property

        Friend Overridable Property Label11 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label11
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label11 = value
            End Set
        End Property

        Friend Overridable Property txtContactNo As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtContactNo
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtContactNo = value
            End Set
        End Property

        Friend Overridable Property txtSupplierName As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtSupplierName
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtSupplierName = value
            End Set
        End Property

        Friend Overridable Property txtCity As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtCity
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtCity = value
            End Set
        End Property

        Friend Overridable Property txtAddress As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtAddress
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtAddress = value
            End Set
        End Property

        Friend Overridable Property Label26 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label26
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label26 = value
            End Set
        End Property

        Friend Overridable Property Label29 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label29
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label29 = value
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

        Friend Overridable Property Label36 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label36
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label36 = value
            End Set
        End Property

        Friend Overridable Property cmbPurchaseType As System.Windows.Forms.ComboBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._cmbPurchaseType
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ComboBox)
                Me._cmbPurchaseType = value
            End Set
        End Property

        Friend Overridable Property btnClose As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnClose
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
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

        Friend Overridable Property btnNew As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnNew
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnNew_Click
                If Me._btnNew IsNot Nothing Then
                    RemoveHandler Me._btnNew.Click, value2
                End If

                Me._btnNew = value
                If Me._btnNew IsNot Nothing Then
                    AddHandler Me._btnNew.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnGetData As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnGetData
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnGetData_Click
                If Me._btnGetData IsNot Nothing Then
                    RemoveHandler Me._btnGetData.Click, value2
                End If

                Me._btnGetData = value
                If Me._btnGetData IsNot Nothing Then
                    AddHandler Me._btnGetData.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnSave As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnSave
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnSave_Click
                If Me._btnSave IsNot Nothing Then
                    RemoveHandler Me._btnSave.Click, value2
                End If

                Me._btnSave = value
                If Me._btnSave IsNot Nothing Then
                    AddHandler Me._btnSave.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnDelete As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnDelete
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnDelete_Click
                If Me._btnDelete IsNot Nothing Then
                    RemoveHandler Me._btnDelete.Click, value2
                End If

                Me._btnDelete = value
                If Me._btnDelete IsNot Nothing Then
                    AddHandler Me._btnDelete.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property cmbProductName As System.Windows.Forms.ComboBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._cmbProductName
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ComboBox)
                Dim value2 As System.EventHandler = AddressOf Me.cmbProductName_SelectedIndexChanged
                Dim value3 As System.Windows.Forms.ListControlConvertEventHandler = AddressOf Me.cmbProductName_Format
                If Me._cmbProductName IsNot Nothing Then
                    RemoveHandler Me._cmbProductName.SelectedIndexChanged, value2
                    RemoveHandler Me._cmbProductName.Format, value3
                End If

                Me._cmbProductName = value
                If Me._cmbProductName IsNot Nothing Then
                    AddHandler Me._cmbProductName.SelectedIndexChanged, value2
                    AddHandler Me._cmbProductName.Format, value3
                End If
            End Set
        End Property

        Friend Overridable Property txtProductID As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtProductID
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtProductID = value
            End Set
        End Property

        Public Overridable Property btnRemove As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnRemove
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnRemove_Click
                If Me._btnRemove IsNot Nothing Then
                    RemoveHandler Me._btnRemove.Click, value2
                End If

                Me._btnRemove = value
                If Me._btnRemove IsNot Nothing Then
                    AddHandler Me._btnRemove.Click, value2
                End If
            End Set
        End Property

        Public Overridable Property btnAdd As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnAdd
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnAdd_Click
                If Me._btnAdd IsNot Nothing Then
                    RemoveHandler Me._btnAdd.Click, value2
                End If

                Me._btnAdd = value
                If Me._btnAdd IsNot Nothing Then
                    AddHandler Me._btnAdd.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property cmbWarehouse As System.Windows.Forms.ComboBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._cmbWarehouse
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ComboBox)
                Me._cmbWarehouse = value
            End Set
        End Property

        Friend Overridable Property Label7 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label7
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label7 = value
            End Set
        End Property

        Friend Overridable Property dtpExpiryDate As System.Windows.Forms.DateTimePicker
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._dtpExpiryDate
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DateTimePicker)
                Me._dtpExpiryDate = value
            End Set
        End Property

        Friend Overridable Property chkHasExpiryDate As System.Windows.Forms.CheckBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._chkHasExpiryDate
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.CheckBox)
                Dim value2 As System.EventHandler = AddressOf Me.chkHasExpiryDate_CheckedChanged
                If Me._chkHasExpiryDate IsNot Nothing Then
                    RemoveHandler Me._chkHasExpiryDate.CheckedChanged, value2
                End If

                Me._chkHasExpiryDate = value
                If Me._chkHasExpiryDate IsNot Nothing Then
                    AddHandler Me._chkHasExpiryDate.CheckedChanged, value2
                End If
            End Set
        End Property

        Friend Overridable Property lblUnit As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._lblUnit
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._lblUnit = value
            End Set
        End Property

        Friend Overridable Property Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Column1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._Column1 = value
            End Set
        End Property

        Friend Overridable Property Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Column3
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._Column3 = value
            End Set
        End Property

        Friend Overridable Property Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Column2
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._Column2 = value
            End Set
        End Property

        Friend Overridable Property Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Column4
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._Column4 = value
            End Set
        End Property

        Friend Overridable Property Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Column5
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._Column5 = value
            End Set
        End Property

        Friend Overridable Property Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Column6
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._Column6 = value
            End Set
        End Property

        Friend Overridable Property Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Column7
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._Column7 = value
            End Set
        End Property

        Friend Overridable Property Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Column8
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._Column8 = value
            End Set
        End Property

        Friend Overridable Property pnlCalc As System.Windows.Forms.Panel
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._pnlCalc
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Panel)
                Me._pnlCalc = value
            End Set
        End Property

        Friend Overridable Property txtVATAmt As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtVATAmt
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtVATAmt = value
            End Set
        End Property

        Friend Overridable Property Label14 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label14
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label14 = value
            End Set
        End Property

        Friend Overridable Property Label15 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label15
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label15 = value
            End Set
        End Property

        Friend Overridable Property txtVATPer As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtVATPer
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.EventHandler = AddressOf Me.txHSTPer_TextChanged
                If Me._txtVATPer IsNot Nothing Then
                    RemoveHandler Me._txtVATPer.TextChanged, value2
                End If

                Me._txtVATPer = value
                If Me._txtVATPer IsNot Nothing Then
                    AddHandler Me._txtVATPer.TextChanged, value2
                End If
            End Set
        End Property

        Friend Overridable Property txtDisc As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtDisc
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtDisc = value
            End Set
        End Property

        Friend Overridable Property Label45 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label45
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label45 = value
            End Set
        End Property

        Friend Overridable Property Label46 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label46
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label46 = value
            End Set
        End Property

        Friend Overridable Property txtDiscPer As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtDiscPer
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.EventHandler = AddressOf Me.txtDiscPer_TextChanged_1
                If Me._txtDiscPer IsNot Nothing Then
                    RemoveHandler Me._txtDiscPer.TextChanged, value2
                End If

                Me._txtDiscPer = value
                If Me._txtDiscPer IsNot Nothing Then
                    AddHandler Me._txtDiscPer.TextChanged, value2
                End If
            End Set
        End Property

        Friend Overridable Property Label32 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label32
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label32 = value
            End Set
        End Property

        Friend Overridable Property txtTotal As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtTotal
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtTotal = value
            End Set
        End Property

        Friend Overridable Property Label24 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label24
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label24 = value
            End Set
        End Property

        Friend Overridable Property txtPreviousDue As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtPreviousDue
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtPreviousDue = value
            End Set
        End Property

        Friend Overridable Property txtBalance As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtBalance
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtBalance = value
            End Set
        End Property

        Friend Overridable Property Label18 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label18
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label18 = value
            End Set
        End Property

        Friend Overridable Property Label17 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label17
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label17 = value
            End Set
        End Property

        Friend Overridable Property Label16 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label16
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label16 = value
            End Set
        End Property

        Friend Overridable Property txtRoundOff As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtRoundOff
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.EventHandler = AddressOf Me.txtRoundOff_TextChanged_1
                If Me._txtRoundOff IsNot Nothing Then
                    RemoveHandler Me._txtRoundOff.TextChanged, value2
                End If

                Me._txtRoundOff = value
                If Me._txtRoundOff IsNot Nothing Then
                    AddHandler Me._txtRoundOff.TextChanged, value2
                End If
            End Set
        End Property

        Friend Overridable Property txtTotalPaid As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtTotalPaid
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.EventHandler = AddressOf Me.txtTotalPaid_TextChanged_1
                If Me._txtTotalPaid IsNot Nothing Then
                    RemoveHandler Me._txtTotalPaid.TextChanged, value2
                End If

                Me._txtTotalPaid = value
                If Me._txtTotalPaid IsNot Nothing Then
                    AddHandler Me._txtTotalPaid.TextChanged, value2
                End If
            End Set
        End Property

        Friend Overridable Property txtGrandTotal As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtGrandTotal
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtGrandTotal = value
            End Set
        End Property

        Friend Overridable Property txtOtherCharges As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtOtherCharges
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.EventHandler = AddressOf Me.txtOtherCharges_TextChanged_1
                If Me._txtOtherCharges IsNot Nothing Then
                    RemoveHandler Me._txtOtherCharges.TextChanged, value2
                End If

                Me._txtOtherCharges = value
                If Me._txtOtherCharges IsNot Nothing Then
                    AddHandler Me._txtOtherCharges.TextChanged, value2
                End If
            End Set
        End Property

        Friend Overridable Property txtFreightCharges As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtFreightCharges
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.EventHandler = AddressOf Me.txtFreightCharges_TextChanged_1
                If Me._txtFreightCharges IsNot Nothing Then
                    RemoveHandler Me._txtFreightCharges.TextChanged, value2
                End If

                Me._txtFreightCharges = value
                If Me._txtFreightCharges IsNot Nothing Then
                    AddHandler Me._txtFreightCharges.TextChanged, value2
                End If
            End Set
        End Property

        Friend Overridable Property Label21 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label21
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label21 = value
            End Set
        End Property

        Friend Overridable Property txtSubTotal As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtSubTotal
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.EventHandler = AddressOf Me.txtSubTotal_TextChanged_1
                If Me._txtSubTotal IsNot Nothing Then
                    RemoveHandler Me._txtSubTotal.TextChanged, value2
                End If

                Me._txtSubTotal = value
                If Me._txtSubTotal IsNot Nothing Then
                    AddHandler Me._txtSubTotal.TextChanged, value2
                End If
            End Set
        End Property

        Friend Overridable Property Label31 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label31
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label31 = value
            End Set
        End Property

        Friend Overridable Property Button1 As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Button1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.Button1_Click
                If Me._Button1 IsNot Nothing Then
                    RemoveHandler Me._Button1.Click, value2
                End If

                Me._Button1 = value
                If Me._Button1 IsNot Nothing Then
                    AddHandler Me._Button1.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property Button2 As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Button2
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.Button2_Click_1
                If Me._Button2 IsNot Nothing Then
                    RemoveHandler Me._Button2.Click, value2
                End If

                Me._Button2 = value
                If Me._Button2 IsNot Nothing Then
                    AddHandler Me._Button2.Click, value2
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
                Dim obj As CButtonLib.CButton.ClickButtonAreaEventHandler = AddressOf Me.btnPayment_ClickButtonArea
                If Me._btnPayment IsNot Nothing Then
                    RemoveHandler Me._btnPayment.ClickButtonArea, obj
                End If

                Me._btnPayment = value
                If Me._btnPayment IsNot Nothing Then
                    AddHandler Me._btnPayment.ClickButtonArea, obj
                End If
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            AddHandler MyBase.Load, AddressOf Me.frmPurchase_Load
            Call RestaurantPOS14.frmPurchaseEntry.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmPurchaseEntry.__ENCList
                If RestaurantPOS14.frmPurchaseEntry.__ENCList.Count = RestaurantPOS14.frmPurchaseEntry.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmPurchaseEntry.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmPurchaseEntry.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmPurchaseEntry.__ENCList(num) = RestaurantPOS14.frmPurchaseEntry.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmPurchaseEntry.__ENCList.RemoveRange(num, RestaurantPOS14.frmPurchaseEntry.__ENCList.Count - num)
                    RestaurantPOS14.frmPurchaseEntry.__ENCList.Capacity = RestaurantPOS14.frmPurchaseEntry.__ENCList.Count
                End If

                Call RestaurantPOS14.frmPurchaseEntry.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Private Function GenerateID() As String
            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
            Dim text As String = "0000"
            Try
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT TOP 1 ST_ID FROM Purchase ORDER BY ST_ID DESC", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                If RestaurantPOS14.ModClasses.rdr.HasRows Then
                    RestaurantPOS14.ModClasses.rdr.Read()
                    text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr("ST_ID"))
                End If

                RestaurantPOS14.ModClasses.rdr.Close()
                text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(text) + 1.0)
                If Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(text) <= 9.0 Then
                    text = "000" & text
                ElseIf Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(text) <= 99.0 Then
                    text = "00" & text
                ElseIf Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(text) <= 999.0 Then
                    text = "0" & text
                End If
            Catch __unusedException1__ As System.Exception
                If RestaurantPOS14.ModClasses.con.State = System.Data.ConnectionState.Open Then
                    RestaurantPOS14.ModClasses.con.Close()
                End If

                text = "0000"
            End Try

            Return text
        End Function

        Public Sub auto()
            Try
                Me.txtST_ID.Text = Me.GenerateID()
                Me.txtInvoiceNo.Text = "ST-" & Me.GenerateID()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub Reset()
            Me.txtAddress.Text = ""
            Me.txtBalance.Text = ""
            Me.txtCity.Text = ""
            Me.txtContactNo.Text = ""
            Me.txtDiscPer.Text = "0.00"
            Me.txtDisc.Text = "0.00"
            Me.txtSubTotal.Text = ""
            Me.txtTotal.Text = ""
            Me.txtSupplierID.Text = ""
            Me.txtSupplierName.Text = ""
            Me.txtSup_ID.Text = ""
            Me.txtVATPer.Text = "0.00"
            Me.txtVATAmt.Text = "0.00"
            Me.txtFreightCharges.Text = "0.00"
            Me.txtGrandTotal.Text = ""
            Me.txtInvoiceNo.Text = ""
            Me.txtOtherCharges.Text = "0.00"
            Me.txtPreviousDue.Text = "0.00"
            Me.txtRemarks.Text = ""
            Me.txtRoundOff.Text = "0.00"
            Me.txtTotalPaid.Text = "0.00"
            Me.cmbPurchaseType.SelectedIndex = 1
            Me.dtpDate.Value = Microsoft.VisualBasic.DateAndTime.Today
            If RestaurantPOS14.ModFunc.IsViewAllowed(Me.lblUser.Text, "Purchase Entry") Then
                Me.btnGetData.Enabled = True
            Else
                Me.btnGetData.Enabled = False
            End If

            If RestaurantPOS14.ModFunc.IsSaveAllowed(Me.lblUser.Text, "Purchase Entry") Then
                Me.btnSave.Enabled = True
            Else
                Me.btnSave.Enabled = False
            End If

            Me.btnDelete.Enabled = False
            Me.DataGridView1.Enabled = True
            Me.btnAdd.Enabled = True
            Me.pnlCalc.Enabled = True
            Me.btnRemove.Enabled = False
            Me.lblBalance.Text = "0.00"
            Me.txtTotalPaid.[ReadOnly] = True
            Me.txtTotalPaid.Enabled = False
            Me.DataGridView1.Rows.Clear()
            Me.btnSelection.Enabled = True
            Me.cmbProductName.Text = ""
            Me.lblSet.Text = ""
            Me.Clear()
            Me.auto()
        End Sub

        Public Function SubTotal() As Double
            Dim num As Double = 0.0
            Try
                For Each dataGridViewRow As System.Windows.Forms.DataGridViewRow In CType(Me.DataGridView1.Rows, System.Collections.IEnumerable)
                    num = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(num, dataGridViewRow.Cells(CInt((5))).Value))
                Next
            Catch ex As System.Exception
                Call Microsoft.VisualBasic.Interaction.MsgBox(ex.Message)
            End Try

            Return num
        End Function

        Public Sub Clear()
            Me.cmbProductName.Text = ""
            Me.cmbWarehouse.SelectedIndex = -1
            Me.lblUnit.Visible = False
            Me.chkHasExpiryDate.Checked = False
            Me.dtpExpiryDate.Enabled = False
            Me.txtQty.Text = ""
            Me.txtPricePerQty.Text = ""
            Me.txtTotalAmount.Text = ""
            Me.dtpExpiryDate.Value = Microsoft.VisualBasic.DateAndTime.Today
        End Sub

        Public Sub Compute()
            Me.num6 = New Decimal(Microsoft.VisualBasic.Conversion.Val(Me.txtSubTotal.Text) * Microsoft.VisualBasic.Conversion.Val(Me.txtDiscPer.Text) / 100.0)
            Me.num6 = System.Math.Round(Me.num6, 2)
            Me.txtDisc.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Me.num6)
            Me.num7 = New Decimal(Microsoft.VisualBasic.Conversion.Val(Me.txtSubTotal.Text) - System.Convert.ToDouble(Me.num6))
            Me.num8 = New Decimal(System.Convert.ToDouble(Me.num7) * Microsoft.VisualBasic.Conversion.Val(Me.txtVATPer.Text) / 100.0)
            Me.num8 = System.Math.Round(Me.num8, 2)
            Me.txtVATAmt.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Me.num8)
            Me.num1 = New Decimal(System.Convert.ToDouble(Me.num7) + Microsoft.VisualBasic.Conversion.Val(Me.txtFreightCharges.Text) + Microsoft.VisualBasic.Conversion.Val(Me.txtOtherCharges.Text) + Microsoft.VisualBasic.Conversion.Val(Me.txtPreviousDue.Text) + Microsoft.VisualBasic.Conversion.Val(Me.txtVATAmt.Text))
            Me.num1 = System.Math.Round(Me.num1, 2)
            Me.txtTotal.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Me.num1)
            Me.num2 = System.Math.Round(Me.num1, 1)
            Me.num3 = Decimal.Subtract(Me.num2, Me.num1)
            Me.num3 = System.Math.Round(Me.num3, 2)
            Me.txtRoundOff.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Me.num3)
            Me.num4 = New Decimal(Microsoft.VisualBasic.Conversion.Val(Me.txtTotal.Text) + Microsoft.VisualBasic.Conversion.Val(Me.txtRoundOff.Text))
            Me.num4 = System.Math.Round(Me.num4, 2)
            Me.txtGrandTotal.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Me.num4)
            Me.num5 = New Decimal(Microsoft.VisualBasic.Conversion.Val(Me.txtGrandTotal.Text) - Microsoft.VisualBasic.Conversion.Val(Me.txtTotalPaid.Text))
            Me.num5 = System.Math.Round(Me.num5, 2)
            Me.txtBalance.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Me.num5)
        End Sub

        Private Sub DataGridView1_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs)
            If Me.DataGridView1.Rows.Count > 0 Then
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "Not allowed", TextCompare:=False) = 0 Then
                    Me.btnRemove.Enabled = False
                Else
                    Me.btnRemove.Enabled = True
                End If
            End If
        End Sub

        Private Sub DataGridView1_RowPostPaint(sender As Object, e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs)
            Dim text As String =(e.RowIndex + 1).ToString()
            Dim sizeF As System.Drawing.SizeF = e.Graphics.MeasureString(text, MyBase.Font)
            If Me.DataGridView1.RowHeadersWidth < System.Convert.ToInt32(sizeF.Width + 20F) Then
                Me.DataGridView1.RowHeadersWidth = System.Convert.ToInt32(sizeF.Width + 20F)
            End If

            Dim controlText As System.Drawing.Brush = System.Drawing.SystemBrushes.ControlText
            e.Graphics.DrawString(text, MyBase.Font, controlText, e.RowBounds.Location.X + 15, CSng(e.RowBounds.Location.Y) + (CSng(e.RowBounds.Height) - sizeF.Height) / 2F)
        End Sub

        Private Sub frmPurchase_Load(sender As Object, e As System.EventArgs)
            Me.fillCombo()
            Me.FillWarehouse()
        End Sub

        Private Sub txtPricePerQty_TextChanged(sender As Object, e As System.EventArgs)
            Dim value As Double = Microsoft.VisualBasic.Conversion.Val(Me.txtQty.Text) * Microsoft.VisualBasic.Conversion.Val(Me.txtPricePerQty.Text)
            value = System.Math.Round(value, 2)
            Me.txtTotalAmount.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(value)
        End Sub

        Private Sub txtQty_TextChanged(sender As Object, e As System.EventArgs)
            Dim value As Double = Microsoft.VisualBasic.Conversion.Val(Me.txtQty.Text) * Microsoft.VisualBasic.Conversion.Val(Me.txtPricePerQty.Text)
            value = System.Math.Round(value, 2)
            Me.txtTotalAmount.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(value)
        End Sub

        Private Sub txtQty_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
            Dim keyChar As Char = e.KeyChar
            If Char.IsControl(keyChar) Then
                Return
            End If

            If Char.IsDigit(keyChar) OrElse keyChar = "."c Then
                Dim text As String = Me.txtQty.Text
                Dim selectionStart As Integer = Me.txtQty.SelectionStart
                Dim selectionLength As Integer = Me.txtQty.SelectionLength
                text = text.Substring(0, selectionStart) & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(keyChar) & text.Substring(selectionStart + selectionLength)
                Dim s As String = text
                Dim num As Integer = 0
                If Integer.TryParse(s, num) AndAlso text.Length > 16 Then
                    e.Handled = True
                    Return
                End If

                Dim s2 As String = text
                Dim num2 As Double = 0.0
                If Double.TryParse(s2, num2) AndAlso text.IndexOf("."c) < text.Length - 3 Then
                    e.Handled = False
                End If
            Else
                e.Handled = True
            End If
        End Sub

        Private Sub txtPricePerQty_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
            Dim keyChar As Char = e.KeyChar
            If Char.IsControl(keyChar) Then
                Return
            End If

            If Char.IsDigit(keyChar) OrElse keyChar = "."c Then
                Dim text As String = Me.txtPricePerQty.Text
                Dim selectionStart As Integer = Me.txtPricePerQty.SelectionStart
                Dim selectionLength As Integer = Me.txtPricePerQty.SelectionLength
                text = text.Substring(0, selectionStart) & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(keyChar) & text.Substring(selectionStart + selectionLength)
                Dim s As String = text
                Dim num As Integer = 0
                If Integer.TryParse(s, num) AndAlso text.Length > 16 Then
                    e.Handled = True
                    Return
                End If

                Dim s2 As String = text
                Dim num2 As Double = 0.0
                If Double.TryParse(s2, num2) AndAlso text.IndexOf("."c) < text.Length - 3 Then
                    e.Handled = False
                End If
            Else
                e.Handled = True
            End If
        End Sub

        Private Sub txtTotalPayment_TextChanged(sender As Object, e As System.EventArgs)
            Me.Compute()
        End Sub

        Private Sub txtTotalPayment_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
            If Microsoft.VisualBasic.Conversion.Val(Me.txtTotalPaid.Text) > Microsoft.VisualBasic.Conversion.Val(Me.txtGrandTotal.Text) Then
                Call System.Windows.Forms.MessageBox.Show("Total paid can not be more than grand total", "Input Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End If
        End Sub

        Public Sub GetSupplierBalance()
            Try
                Me.num1 = DirectCast(Nothing, System.Decimal)
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT isNULL(Sum(Credit),0)-IsNull(Sum(Debit),0) from LedgerBook where PartyID=@d1 group By PartyID", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtSupplierID.Text)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.num1 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDecimal(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If

                RestaurantPOS14.ModClasses.con.Close()
                Me.lblBalance.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Me.num1)
                If Microsoft.VisualBasic.Conversion.Val(Me.lblBalance.Text) >= 0.0 Then
                    Me.str = "CR"
                ElseIf Microsoft.VisualBasic.Conversion.Val(Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(Me.lblBalance.Text) < 0.0) <> 0.0 Then
                    Me.str = "DR"
                End If

                Me.txtPreviousDue.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Me.num1)
                Me.lblBalance.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(System.Math.Abs(Microsoft.VisualBasic.Conversion.Val(Me.lblBalance.Text)))
                Me.lblBalance.Text =(Me.lblBalance.Text & " " & Me.str).ToString()
                Me.Compute()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub GetSupplierInfo()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT SupplierID,Name,Address,City,ContactNo from Supplier Where ID=@d1", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.Conversion.Val(Me.txtSup_ID.Text))
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.txtSupplierID.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                    Me.txtSupplierName.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(1))
                    Me.txtAddress.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(2))
                    Me.txtCity.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(3))
                    Me.txtContactNo.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(4))
                End If

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub GetSupplierBalance1()
            Try
                Try
                    Me.num1 = DirectCast(Nothing, System.Decimal)
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT isNULL(Sum(Credit),0)-IsNull(Sum(Debit),0) from LedgerBook where PartyID=@d1 group By PartyID", RestaurantPOS14.ModClasses.con)
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtSupplierID.Text)
                    RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                    If RestaurantPOS14.ModClasses.rdr.Read() Then
                        Me.num1 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDecimal(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                    End If

                    RestaurantPOS14.ModClasses.con.Close()
                    Me.lblBalance.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Me.num1)
                    If Microsoft.VisualBasic.Conversion.Val(Me.lblBalance.Text) >= 0.0 Then
                        Me.str = "CR"
                    ElseIf Microsoft.VisualBasic.Conversion.Val(Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(Me.lblBalance.Text) < 0.0) <> 0.0 Then
                        Me.str = "DR"
                    End If

                    Me.lblBalance.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(System.Math.Abs(Microsoft.VisualBasic.Conversion.Val(Me.lblBalance.Text)))
                    Me.lblBalance.Text =(Me.lblBalance.Text & " " & Me.str).ToString()
                    Me.Compute()
                Catch ex As System.Exception
                    Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                End Try
            Catch ex2 As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex2.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub DeleteRecord()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("delete from Purchase where ST_ID=@d1")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.Conversion.Val(Me.txtST_ID.Text))
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                Dim num As Integer = RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                RestaurantPOS14.ModClasses.con.Close()
                If num > 0 Then
                    For Each dataGridViewRow As System.Windows.Forms.DataGridViewRow In CType(Me.DataGridView1.Rows, System.Collections.IEnumerable)
                        Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                        RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                        RestaurantPOS14.ModClasses.con.Open()
                        RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select WareHouse,ProductID,ExpiryDate from temp_Stock where Warehouse=@d1 and ProductID=@d2 and ExpiryDate=@d3")
                        RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((2))).Value))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((0))).Value)))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((7))).Value))
                        RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                        If RestaurantPOS14.ModClasses.rdr.Read() Then
                            Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                            RestaurantPOS14.ModClasses.con.Open()
                            RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Update Temp_Stock set Qty=Qty - " & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((3))).Value))) & " where Warehouse=@d1 and ProductID=@d2 and ExpiryDate=@d3")
                            RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((2))).Value))
                            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((0))).Value)))
                            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((7))).Value))
                            RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                            RestaurantPOS14.ModClasses.con.Close()
                        End If
                    Next

                    RestaurantPOS14.ModFunc.LedgerDelete(Me.txtInvoiceNo.Text, "Purchase Invoice")
                    RestaurantPOS14.ModFunc.LogFunc(Me.lblUser.Text, "deleted the purchase record having Invoice No. '" & Me.txtInvoiceNo.Text & "'")
                    Call System.Windows.Forms.MessageBox.Show("Successfully deleted", "Record", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    Me.Reset()
                Else
                    Call System.Windows.Forms.MessageBox.Show("No Record found", "Sorry", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    Me.Reset()
                End If

                If RestaurantPOS14.ModClasses.con.State = System.Data.ConnectionState.Open Then
                    RestaurantPOS14.ModClasses.con.Close()
                End If
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub Button2_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmSupplierRecord.lblSet.Text = "Purchase"
            RestaurantPOS14.My.MyProject.Forms.frmSupplierRecord.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmSupplierRecord.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmSupplierRecord.ShowDialog()
        End Sub

        Private Sub btnClose_Click(sender As Object, e As System.EventArgs)
            MyBase.Close()
        End Sub

        Private Sub btnNew_Click(sender As Object, e As System.EventArgs)
            Me.Reset()
        End Sub

        Private Sub btnSave_Click(sender As Object, e As System.EventArgs)
            If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.txtSupplierID.Text)) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please retrieve supplier id", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtSupplierID.Focus()
                Return
            End If

            If Me.DataGridView1.Rows.Count = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Sorry no product info added to grid", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Return
            End If

            If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.txtDiscPer.Text)) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please enter discount %", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtDiscPer.Focus()
                Return
            End If

            If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.txtFreightCharges.Text)) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please enter freight charges", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtFreightCharges.Focus()
                Return
            End If

            If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.txtOtherCharges.Text)) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please enter other charges", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtOtherCharges.Focus()
                Return
            End If

            If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.txtRoundOff.Text)) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please enter round off", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtRoundOff.Focus()
                Return
            End If

            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select InvoiceNo from Purchase where InvoiceNo=@d1")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtInvoiceNo.Text)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Invoice No. Already Exists", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                    Me.txtInvoiceNo.Text = ""
                    Me.txtInvoiceNo.Focus()
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                RestaurantPOS14.ModClasses.con.Close()
                For Each dataGridViewRow As System.Windows.Forms.DataGridViewRow In CType(Me.DataGridView1.Rows, System.Collections.IEnumerable)
                    Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select WareHouse,ProductID,ExpiryDate from temp_Stock where Warehouse=@d1 and ProductID=@d2 and ExpiryDate=@d3")
                    RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((2))).Value))
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((0))).Value)))
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((7))).Value))
                    RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                    If RestaurantPOS14.ModClasses.rdr.Read() Then
                        Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                        RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                        RestaurantPOS14.ModClasses.con.Open()
                        RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Update Temp_Stock set Qty=Qty + " & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((3))).Value))) & " where Warehouse=@d1 and ProductID=@d2 and ExpiryDate=@d3")
                        RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((2))).Value))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((0))).Value)))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((7))).Value))
                        RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                        RestaurantPOS14.ModClasses.con.Close()
                    Else
                        Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                        RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                        RestaurantPOS14.ModClasses.con.Open()
                        RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Insert Into Temp_Stock(Warehouse,ProductID,Qty,HasExpiryDate,ExpiryDate) values (@d1,@d2,@d3,@d4,@d5)")
                        RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((2))).Value))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((0))).Value)))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((3))).Value)))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((6))).Value))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d5", System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((7))).Value))
                        RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                        RestaurantPOS14.ModClasses.con.Close()
                    End If
                Next

                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("insert into Purchase(ST_ID, InvoiceNo, Date,PurchaseType, Supplier_ID, SubTotal, DiscountPer, Discount, PreviousDue, FreightCharges, OtherCharges, Total, RoundOff, GrandTotal, TotalPayment, PaymentDue, Remarks,HSTPer,HST) VALUES (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9,@d10,@d11,@d12,@d13,@d14,@d15,@d16,@d17," & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.txtVATPer.Text)) & "," & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.txtVATAmt.Text)) & ")")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.Conversion.Val(Me.txtST_ID.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Me.txtInvoiceNo.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Me.dtpDate.Value.[Date])
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", Me.cmbPurchaseType.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d5", Microsoft.VisualBasic.Conversion.Val(Me.txtSup_ID.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d6", Microsoft.VisualBasic.Conversion.Val(Me.txtSubTotal.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d7", Microsoft.VisualBasic.Conversion.Val(Me.txtDiscPer.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d8", Microsoft.VisualBasic.Conversion.Val(Me.txtDisc.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d9", Microsoft.VisualBasic.Conversion.Val(Me.txtPreviousDue.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d10", Microsoft.VisualBasic.Conversion.Val(Me.txtFreightCharges.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d11", Microsoft.VisualBasic.Conversion.Val(Me.txtOtherCharges.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d12", Microsoft.VisualBasic.Conversion.Val(Me.txtTotal.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d13", Microsoft.VisualBasic.Conversion.Val(Me.txtRoundOff.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d14", Microsoft.VisualBasic.Conversion.Val(Me.txtGrandTotal.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d15", Microsoft.VisualBasic.Conversion.Val(Me.txtTotalPaid.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d16", Microsoft.VisualBasic.Conversion.Val(Me.txtBalance.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d17", Me.txtRemarks.Text)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                RestaurantPOS14.ModClasses.con.Close()
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("insert into Purchase_Join(PurchaseID,ProductID,Warehouse,Qty,Price,TotalAmount,HasExpiryDate,ExpiryDate) VALUES (" & RestaurantPOS14.Security.SqlInput.RequireInteger(Me.txtST_ID.Text, "Record ID") & ",@d1,@d2,@d3,@d4,@d5,@d6,@d7)")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Prepare()
                For Each dataGridViewRow2 As System.Windows.Forms.DataGridViewRow In CType(Me.DataGridView1.Rows, System.Collections.IEnumerable)
                    If Not dataGridViewRow2.IsNewRow Then
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(CInt((0))).Value)))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(CInt((2))).Value))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(CInt((3))).Value)))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(CInt((4))).Value)))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d5", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(CInt((5))).Value)))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d6", System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(CInt((6))).Value))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d7", System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(CInt((7))).Value))
                        RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                        RestaurantPOS14.ModClasses.cmd.Parameters.Clear()
                    End If
                Next

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModFunc.LedgerSave(Me.dtpDate.Value.[Date], Me.txtSupplierName.Text, Me.txtInvoiceNo.Text, "Purchase Invoice", 0D, New Decimal(Microsoft.VisualBasic.Conversion.Val(Me.txtGrandTotal.Text) - Microsoft.VisualBasic.Conversion.Val(Me.txtPreviousDue.Text)), Me.txtSupplierID.Text, "Purchase A/c")
                RestaurantPOS14.ModFunc.LedgerSave(Me.dtpDate.Value.[Date], "Purchase A/c", Me.txtInvoiceNo.Text, "Purchase Invoice", New Decimal(Microsoft.VisualBasic.Conversion.Val(Me.txtGrandTotal.Text) - Microsoft.VisualBasic.Conversion.Val(Me.txtPreviousDue.Text)), 0D, "", Me.txtSupplierName.Text)
                RestaurantPOS14.ModFunc.LogFunc(Me.lblUser.Text, "added the new Purchase having Invoice No. '" & Me.txtInvoiceNo.Text & "'")
                Call System.Windows.Forms.MessageBox.Show("Successfully saved", "Purchase", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                Me.btnSave.Enabled = False
                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub fillCombo()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Select RTRIM(ProductName) from Product order by 1")
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                Me.cmbProductName.Items.Clear()
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Me.cmbProductName.Items.Add(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr.GetValue(0)))
                End While

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnDelete_Click(sender As Object, e As System.EventArgs)
            Try
                If System.Windows.Forms.MessageBox.Show("Do you really want to delete this record?", "Confirmation", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Exclamation) = System.Windows.Forms.DialogResult.Yes Then
                    Me.DeleteRecord()
                End If
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnGetData_Click(sender As Object, e As System.EventArgs)
            Me.Reset()
            RestaurantPOS14.My.MyProject.Forms.frmPurchaseRecord.lblSet.Text = "Purchase"
            RestaurantPOS14.My.MyProject.Forms.frmPurchaseRecord.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmPurchaseRecord.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmPurchaseRecord.ShowDialog()
        End Sub

        Private Sub cmbProductName_Format(sender As Object, e As System.Windows.Forms.ListControlConvertEventArgs)
            If e.DesiredType Is GetType(String) Then
                e.Value = e.Value.ToString().Trim()
            End If
        End Sub

        Private Sub cmbProductName_SelectedIndexChanged(sender As Object, e As System.EventArgs)
            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
            RestaurantPOS14.ModClasses.con.Open()
            RestaurantPOS14.ModClasses.cmd = RestaurantPOS14.ModClasses.con.CreateCommand()
            RestaurantPOS14.ModClasses.cmd.CommandText = "SELECT PID,RTRIM(Unit),RTRIM(Price) from Product where ProductName=@d1"
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.cmbProductName.Text)
            RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
            If RestaurantPOS14.ModClasses.rdr.Read() Then
                Me.lblUnit.Visible = True
                Me.txtProductID.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                Me.lblUnit.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(1))
                Me.txtPricePerQty.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(2))
            End If

            If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                RestaurantPOS14.ModClasses.rdr.Close()
            End If

            If RestaurantPOS14.ModClasses.con.State = System.Data.ConnectionState.Open Then
                RestaurantPOS14.ModClasses.con.Close()
            End If
        End Sub

        Private Sub btnAdd_Click(sender As Object, e As System.EventArgs)
            Try
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.cmbProductName.Text, "", TextCompare:=False) = 0 Then
                    Call System.Windows.Forms.MessageBox.Show("Please select product name", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Me.cmbProductName.Focus()
                    Return
                End If

                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.cmbWarehouse.Text, "", TextCompare:=False) = 0 Then
                    Call System.Windows.Forms.MessageBox.Show("Please select warehouse", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Me.cmbWarehouse.Focus()
                    Return
                End If

                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtQty.Text, "", TextCompare:=False) = 0 Then
                    Call System.Windows.Forms.MessageBox.Show("Please enter quantity", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Me.txtQty.Focus()
                    Return
                End If

                If Microsoft.VisualBasic.Conversion.Val(Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(Me.txtQty.Text) = 0.0) <> 0.0 Then
                    Call System.Windows.Forms.MessageBox.Show("Quantity can not be zero", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Me.txtQty.Focus()
                    Return
                End If

                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtPricePerQty.Text, "", TextCompare:=False) = 0 Then
                    Call System.Windows.Forms.MessageBox.Show("Please enter price per unit", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Me.txtPricePerQty.Focus()
                    Return
                End If

                If Microsoft.VisualBasic.Conversion.Val(Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(Me.txtPricePerQty.Text) = 0.0) <> 0.0 Then
                    Call System.Windows.Forms.MessageBox.Show("Price per unit can not be zero", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Me.txtPricePerQty.Focus()
                    Return
                End If

                If Me.chkHasExpiryDate.Checked Then
                    Me.st = "Yes"
                Else
                    Me.st = "No"
                End If

                If(Me.DataGridView1.Rows.Count = 0) And Me.chkHasExpiryDate.Checked Then
                    Me.DataGridView1.Rows.Add(Microsoft.VisualBasic.Conversion.Val(Me.txtProductID.Text), Me.cmbProductName.Text, Me.cmbWarehouse.Text, Microsoft.VisualBasic.Conversion.Val(Me.txtQty.Text), Microsoft.VisualBasic.Conversion.Val(Me.txtPricePerQty.Text), Microsoft.VisualBasic.Conversion.Val(Me.txtTotalAmount.Text), Me.st, Me.dtpExpiryDate.Text)
                    Dim value As Double = Me.SubTotal()
                    value = System.Math.Round(value, 2)
                    Me.txtSubTotal.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(value)
                    Me.Clear()
                    Return
                End If

                If(Me.DataGridView1.Rows.Count = 0) And Not Me.chkHasExpiryDate.Checked Then
                    Me.DataGridView1.Rows.Add(Microsoft.VisualBasic.Conversion.Val(Me.txtProductID.Text), Me.cmbProductName.Text, Me.cmbWarehouse.Text, Microsoft.VisualBasic.Conversion.Val(Me.txtQty.Text), Microsoft.VisualBasic.Conversion.Val(Me.txtPricePerQty.Text), Microsoft.VisualBasic.Conversion.Val(Me.txtTotalAmount.Text), Me.st, "")
                    Dim value2 As Double = Me.SubTotal()
                    value2 = System.Math.Round(value2, 2)
                    Me.txtSubTotal.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(value2)
                    Me.Clear()
                    Return
                End If

                For Each dataGridViewRow As System.Windows.Forms.DataGridViewRow In CType(Me.DataGridView1.Rows, System.Collections.IEnumerable)
                    If Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(dataGridViewRow.Cells(CInt((0))).Value, Microsoft.VisualBasic.Conversion.Val(Me.txtProductID.Text), TextCompare:=False), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(dataGridViewRow.Cells(CInt((2))).Value, Me.cmbWarehouse.Text, TextCompare:=False)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(dataGridViewRow.Cells(CInt((7))).Value, Me.dtpExpiryDate.Text, TextCompare:=False)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(dataGridViewRow.Cells(CInt((4))).Value, Microsoft.VisualBasic.Conversion.Val(Me.txtPricePerQty.Text), TextCompare:=False))) Then
                        dataGridViewRow.Cells(CInt((0))).Value = Me.txtProductID.Text
                        dataGridViewRow.Cells(CInt((1))).Value = Me.cmbProductName.Text
                        dataGridViewRow.Cells(CInt((2))).Value = Me.cmbWarehouse.Text
                        dataGridViewRow.Cells(CInt((4))).Value = Microsoft.VisualBasic.Conversion.Val(Me.txtPricePerQty.Text)
                        dataGridViewRow.Cells(CInt((3))).Value = Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((3))).Value)) + Microsoft.VisualBasic.Conversion.Val(Me.txtQty.Text)
                        dataGridViewRow.Cells(CInt((5))).Value = Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((5))).Value)) + Microsoft.VisualBasic.Conversion.Val(Me.txtTotalAmount.Text)
                        dataGridViewRow.Cells(CInt((6))).Value = Me.st
                        dataGridViewRow.Cells(CInt((7))).Value = Me.dtpExpiryDate.Text
                        Dim value3 As Double = Me.SubTotal()
                        value3 = System.Math.Round(value3, 2)
                        Me.txtSubTotal.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(value3)
                        Me.Clear()
                        Return
                    End If
                Next

                For Each dataGridViewRow2 As System.Windows.Forms.DataGridViewRow In CType(Me.DataGridView1.Rows, System.Collections.IEnumerable)
                    If Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(dataGridViewRow2.Cells(CInt((0))).Value, Microsoft.VisualBasic.Conversion.Val(Me.txtProductID.Text), TextCompare:=False), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(dataGridViewRow2.Cells(CInt((2))).Value, Me.cmbWarehouse.Text, TextCompare:=False)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(dataGridViewRow2.Cells(CInt((7))).Value, "", TextCompare:=False)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(dataGridViewRow2.Cells(CInt((4))).Value, Microsoft.VisualBasic.Conversion.Val(Me.txtPricePerQty.Text), TextCompare:=False))) Then
                        dataGridViewRow2.Cells(CInt((0))).Value = Me.txtProductID.Text
                        dataGridViewRow2.Cells(CInt((1))).Value = Me.cmbProductName.Text
                        dataGridViewRow2.Cells(CInt((2))).Value = Me.cmbWarehouse.Text
                        dataGridViewRow2.Cells(CInt((4))).Value = Microsoft.VisualBasic.Conversion.Val(Me.txtPricePerQty.Text)
                        dataGridViewRow2.Cells(CInt((3))).Value = Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(CInt((3))).Value)) + Microsoft.VisualBasic.Conversion.Val(Me.txtQty.Text)
                        dataGridViewRow2.Cells(CInt((5))).Value = Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(CInt((5))).Value)) + Microsoft.VisualBasic.Conversion.Val(Me.txtTotalAmount.Text)
                        dataGridViewRow2.Cells(CInt((6))).Value = Me.st
                        dataGridViewRow2.Cells(CInt((7))).Value = ""
                        Dim value4 As Double = Me.SubTotal()
                        value4 = System.Math.Round(value4, 2)
                        Me.txtSubTotal.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(value4)
                        Me.Clear()
                        Return
                    End If
                Next

                If Me.chkHasExpiryDate.Checked Then
                    Me.DataGridView1.Rows.Add(Microsoft.VisualBasic.Conversion.Val(Me.txtProductID.Text), Me.cmbProductName.Text, Me.cmbWarehouse.Text, Microsoft.VisualBasic.Conversion.Val(Me.txtQty.Text), Microsoft.VisualBasic.Conversion.Val(Me.txtPricePerQty.Text), Microsoft.VisualBasic.Conversion.Val(Me.txtTotalAmount.Text), Me.st, Me.dtpExpiryDate.Text)
                    Dim value5 As Double = Me.SubTotal()
                    value5 = System.Math.Round(value5, 2)
                    Me.txtSubTotal.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(value5)
                    Me.Clear()
                ElseIf Not Me.chkHasExpiryDate.Checked Then
                    Me.DataGridView1.Rows.Add(Microsoft.VisualBasic.Conversion.Val(Me.txtProductID.Text), Me.cmbProductName.Text, Me.cmbWarehouse.Text, Microsoft.VisualBasic.Conversion.Val(Me.txtQty.Text), Microsoft.VisualBasic.Conversion.Val(Me.txtPricePerQty.Text), Microsoft.VisualBasic.Conversion.Val(Me.txtTotalAmount.Text), Me.st, "")
                    Dim value6 As Double = Me.SubTotal()
                    value6 = System.Math.Round(value6, 2)
                    Me.txtSubTotal.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(value6)
                    Me.Clear()
                End If
            Catch ex As System.Exception
                Call Microsoft.VisualBasic.Interaction.MsgBox(ex.Message)
            End Try
        End Sub

        Public Sub FillWarehouse()
            Try
                Dim sqlConnection As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                sqlConnection.Open()
                RestaurantPOS14.ModClasses.adp = New System.Data.SqlClient.SqlDataAdapter()
                RestaurantPOS14.ModClasses.adp.SelectCommand = New System.Data.SqlClient.SqlCommand("SELECT distinct RTRIM(WarehouseName) FROM Warehouse", sqlConnection)
                RestaurantPOS14.ModClasses.ds = New System.Data.DataSet("ds")
                RestaurantPOS14.ModClasses.adp.Fill(RestaurantPOS14.ModClasses.ds)
                RestaurantPOS14.ModClasses.dtable = RestaurantPOS14.ModClasses.ds.Tables(0)
                Me.cmbWarehouse.Items.Clear()
                For Each dataRow As System.Data.DataRow In RestaurantPOS14.ModClasses.dtable.Rows
                    Me.cmbWarehouse.Items.Add(dataRow(CInt((0))).ToString())
                Next
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnRemove_Click(sender As Object, e As System.EventArgs)
            Try
                For Each dataGridViewRow As System.Windows.Forms.DataGridViewRow In Me.DataGridView1.SelectedRows
                    Me.DataGridView1.Rows.Remove(dataGridViewRow)
                Next

                Dim value As Double = Me.SubTotal()
                value = System.Math.Round(value, 2)
                Me.txtSubTotal.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(value)
                Me.Compute()
                Me.btnRemove.Enabled = False
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub chkHasExpiryDate_CheckedChanged(sender As Object, e As System.EventArgs)
            If Me.chkHasExpiryDate.Checked Then
                Me.dtpExpiryDate.Enabled = True
            Else
                Me.dtpExpiryDate.Enabled = False
            End If
        End Sub

        Private Sub txtDiscPer_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
            Dim keyChar As Char = e.KeyChar
            If Char.IsControl(keyChar) Then
                Return
            End If

            If Char.IsDigit(keyChar) OrElse keyChar = "."c Then
                Dim text As String = Me.txtDiscPer.Text
                Dim selectionStart As Integer = Me.txtDiscPer.SelectionStart
                Dim selectionLength As Integer = Me.txtDiscPer.SelectionLength
                text = text.Substring(0, selectionStart) & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(keyChar) & text.Substring(selectionStart + selectionLength)
                Dim s As String = text
                Dim num As Integer = 0
                If Integer.TryParse(s, num) AndAlso text.Length > 16 Then
                    e.Handled = True
                    Return
                End If

                Dim s2 As String = text
                Dim num2 As Double = 0.0
                If Double.TryParse(s2, num2) AndAlso text.IndexOf("."c) < text.Length - 3 Then
                    e.Handled = False
                End If
            Else
                e.Handled = True
            End If
        End Sub

        Private Sub txtFreightCharges_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
            Dim keyChar As Char = e.KeyChar
            If Char.IsControl(keyChar) Then
                Return
            End If

            If Char.IsDigit(keyChar) OrElse keyChar = "."c Then
                Dim text As String = Me.txtFreightCharges.Text
                Dim selectionStart As Integer = Me.txtFreightCharges.SelectionStart
                Dim selectionLength As Integer = Me.txtFreightCharges.SelectionLength
                text = text.Substring(0, selectionStart) & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(keyChar) & text.Substring(selectionStart + selectionLength)
                Dim s As String = text
                Dim num As Integer = 0
                If Integer.TryParse(s, num) AndAlso text.Length > 16 Then
                    e.Handled = True
                    Return
                End If

                Dim s2 As String = text
                Dim num2 As Double = 0.0
                If Double.TryParse(s2, num2) AndAlso text.IndexOf("."c) < text.Length - 3 Then
                    e.Handled = False
                End If
            Else
                e.Handled = True
            End If
        End Sub

        Private Sub txtOtherCharges_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
            Dim keyChar As Char = e.KeyChar
            If Char.IsControl(keyChar) Then
                Return
            End If

            If Char.IsDigit(keyChar) OrElse keyChar = "."c Then
                Dim text As String = Me.txtOtherCharges.Text
                Dim selectionStart As Integer = Me.txtOtherCharges.SelectionStart
                Dim selectionLength As Integer = Me.txtOtherCharges.SelectionLength
                text = text.Substring(0, selectionStart) & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(keyChar) & text.Substring(selectionStart + selectionLength)
                Dim s As String = text
                Dim num As Integer = 0
                If Integer.TryParse(s, num) AndAlso text.Length > 16 Then
                    e.Handled = True
                    Return
                End If

                Dim s2 As String = text
                Dim num2 As Double = 0.0
                If Double.TryParse(s2, num2) AndAlso text.IndexOf("."c) < text.Length - 3 Then
                    e.Handled = False
                End If
            Else
                e.Handled = True
            End If
        End Sub

        Private Sub txtTotalPaid_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
            Dim keyChar As Char = e.KeyChar
            If Char.IsControl(keyChar) Then
                Return
            End If

            If Char.IsDigit(keyChar) OrElse keyChar = "."c Then
                Dim text As String = Me.txtTotalPaid.Text
                Dim selectionStart As Integer = Me.txtTotalPaid.SelectionStart
                Dim selectionLength As Integer = Me.txtTotalPaid.SelectionLength
                text = text.Substring(0, selectionStart) & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(keyChar) & text.Substring(selectionStart + selectionLength)
                Dim s As String = text
                Dim num As Integer = 0
                If Integer.TryParse(s, num) AndAlso text.Length > 16 Then
                    e.Handled = True
                    Return
                End If

                Dim s2 As String = text
                Dim num2 As Double = 0.0
                If Double.TryParse(s2, num2) AndAlso text.IndexOf("."c) < text.Length - 3 Then
                    e.Handled = False
                End If
            Else
                e.Handled = True
            End If
        End Sub

        Private Sub txtSubTotal_TextChanged_1(sender As Object, e As System.EventArgs)
            Me.Compute()
        End Sub

        Private Sub txtDiscPer_TextChanged_1(sender As Object, e As System.EventArgs)
            Me.Compute()
        End Sub

        Private Sub txHSTPer_TextChanged(sender As Object, e As System.EventArgs)
            Me.Compute()
        End Sub

        Private Sub txtFreightCharges_TextChanged_1(sender As Object, e As System.EventArgs)
            Me.Compute()
        End Sub

        Private Sub txtOtherCharges_TextChanged_1(sender As Object, e As System.EventArgs)
            Me.Compute()
        End Sub

        Private Sub txtRoundOff_TextChanged_1(sender As Object, e As System.EventArgs)
            Me.Compute()
        End Sub

        Private Sub txtTotalPaid_TextChanged_1(sender As Object, e As System.EventArgs)
            Me.Compute()
        End Sub

        Private Sub Button1_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmProduct.lblUser.Text = Me.lblUser.Text
            RestaurantPOS14.My.MyProject.Forms.frmProduct.lblSet.Text = "Purchase Entry"
            Call RestaurantPOS14.My.MyProject.Forms.frmProduct.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmProduct.ShowDialog()
        End Sub

        Private Sub Button2_Click_1(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmWarehouse.lblUser.Text = Me.lblUser.Text
            RestaurantPOS14.My.MyProject.Forms.frmWarehouse.lblSet.Text = "Purchase Entry"
            Call RestaurantPOS14.My.MyProject.Forms.frmWarehouse.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmWarehouse.ShowDialog()
        End Sub

        Private Sub btnPayment_ClickButtonArea(Sender As Object, e As System.Windows.Forms.MouseEventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmPayment.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmPayment.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmPayment.ShowDialog()
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmPurchaseEntry))
            Dim dataGridViewCellStyle As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.btnPayment = New CButtonLib.CButton()
            Me.pnlCalc = New System.Windows.Forms.Panel()
            Me.txtVATAmt = New System.Windows.Forms.TextBox()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.Label15 = New System.Windows.Forms.Label()
            Me.txtVATPer = New System.Windows.Forms.TextBox()
            Me.txtDisc = New System.Windows.Forms.TextBox()
            Me.Label45 = New System.Windows.Forms.Label()
            Me.Label46 = New System.Windows.Forms.Label()
            Me.txtDiscPer = New System.Windows.Forms.TextBox()
            Me.Label32 = New System.Windows.Forms.Label()
            Me.txtTotal = New System.Windows.Forms.TextBox()
            Me.Label24 = New System.Windows.Forms.Label()
            Me.txtPreviousDue = New System.Windows.Forms.TextBox()
            Me.Label18 = New System.Windows.Forms.Label()
            Me.Label17 = New System.Windows.Forms.Label()
            Me.Label16 = New System.Windows.Forms.Label()
            Me.txtRoundOff = New System.Windows.Forms.TextBox()
            Me.txtGrandTotal = New System.Windows.Forms.TextBox()
            Me.txtOtherCharges = New System.Windows.Forms.TextBox()
            Me.txtFreightCharges = New System.Windows.Forms.TextBox()
            Me.Label21 = New System.Windows.Forms.Label()
            Me.txtSubTotal = New System.Windows.Forms.TextBox()
            Me.Label31 = New System.Windows.Forms.Label()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.btnNew = New System.Windows.Forms.Button()
            Me.btnGetData = New System.Windows.Forms.Button()
            Me.btnSave = New System.Windows.Forms.Button()
            Me.btnDelete = New System.Windows.Forms.Button()
            Me.btnClose = New System.Windows.Forms.Button()
            Me.gbPartyInfo = New System.Windows.Forms.GroupBox()
            Me.btnSelection = New System.Windows.Forms.Button()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.txtSupplierID = New System.Windows.Forms.TextBox()
            Me.lblBalance = New System.Windows.Forms.Label()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.txtContactNo = New System.Windows.Forms.TextBox()
            Me.txtSupplierName = New System.Windows.Forms.TextBox()
            Me.txtCity = New System.Windows.Forms.TextBox()
            Me.txtAddress = New System.Windows.Forms.TextBox()
            Me.Label26 = New System.Windows.Forms.Label()
            Me.Label29 = New System.Windows.Forms.Label()
            Me.Label30 = New System.Windows.Forms.Label()
            Me.Label36 = New System.Windows.Forms.Label()
            Me.txtRemarks = New System.Windows.Forms.RichTextBox()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.DataGridView1 = New System.Windows.Forms.DataGridView()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.Button2 = New System.Windows.Forms.Button()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.lblUnit = New System.Windows.Forms.Label()
            Me.dtpExpiryDate = New System.Windows.Forms.DateTimePicker()
            Me.chkHasExpiryDate = New System.Windows.Forms.CheckBox()
            Me.cmbWarehouse = New System.Windows.Forms.ComboBox()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.btnRemove = New System.Windows.Forms.Button()
            Me.btnAdd = New System.Windows.Forms.Button()
            Me.cmbProductName = New System.Windows.Forms.ComboBox()
            Me.txtTotalAmount = New System.Windows.Forms.TextBox()
            Me.txtPricePerQty = New System.Windows.Forms.TextBox()
            Me.txtQty = New System.Windows.Forms.TextBox()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.dtpDate = New System.Windows.Forms.DateTimePicker()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtInvoiceNo = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.cmbPurchaseType = New System.Windows.Forms.ComboBox()
            Me.txtProductID = New System.Windows.Forms.TextBox()
            Me.lblUserType = New System.Windows.Forms.Label()
            Me.lblSet = New System.Windows.Forms.Label()
            Me.lblUser = New System.Windows.Forms.Label()
            Me.txtSup_ID = New System.Windows.Forms.TextBox()
            Me.txtST_ID = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtTotalPaid = New System.Windows.Forms.TextBox()
            Me.txtBalance = New System.Windows.Forms.TextBox()
            Dim label As System.Windows.Forms.Label = New System.Windows.Forms.Label()
            Me.Panel1.SuspendLayout()
            Me.pnlCalc.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            Me.gbPartyInfo.SuspendLayout()
            CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox2.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            MyBase.SuspendLayout()
            label.AutoSize = True
            label.ForeColor = System.Drawing.Color.Black
            Dim location As System.Drawing.Point = New System.Drawing.Point(195, 146)
            label.Location = location
            Dim margin As System.Windows.Forms.Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
            label.Margin = margin
            label.Name = "Label13"
            Dim size As System.Drawing.Size = New System.Drawing.Size(67, 13)
            label.Size = size
            label.TabIndex = 321
            label.Text = "Expiry Date :"
            Me.Panel1.BackColor = System.Drawing.Color.White
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.btnPayment)
            Me.Panel1.Controls.Add(Me.pnlCalc)
            Me.Panel1.Controls.Add(Me.GroupBox3)
            Me.Panel1.Controls.Add(Me.btnClose)
            Me.Panel1.Controls.Add(Me.gbPartyInfo)
            Me.Panel1.Controls.Add(Me.txtRemarks)
            Me.Panel1.Controls.Add(Me.Label12)
            Me.Panel1.Controls.Add(Me.DataGridView1)
            Me.Panel1.Controls.Add(Me.GroupBox2)
            Me.Panel1.Controls.Add(Me.GroupBox1)
            Me.Panel1.Controls.Add(Me.Panel2)
            Me.Panel1.Controls.Add(Me.txtTotalPaid)
            Me.Panel1.Controls.Add(Me.txtBalance)
            Dim panel As System.Windows.Forms.Panel = Me.Panel1
            location = New System.Drawing.Point(8, 7)
            panel.Location = location
            Me.Panel1.Name = "Panel1"
            Dim panel2 As System.Windows.Forms.Panel = Me.Panel1
            size = New System.Drawing.Size(803, 647)
            panel2.Size = size
            Me.Panel1.TabIndex = 2
            Me.btnPayment.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.btnPayment.BackColor = System.Drawing.Color.Transparent
            Me.btnPayment.BorderColor = System.Drawing.Color.Transparent
            cBlendItems.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnPayment.ColorFillBlend = cBlendItems
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
            Dim cButton As CButtonLib.CButton = Me.btnPayment
            size = New System.Drawing.Size(50, 50)
            cButton.ImageSize = size
            Dim cButton2 As CButtonLib.CButton = Me.btnPayment
            location = New System.Drawing.Point(617, 277)
            cButton2.Location = location
            Dim cButton3 As CButtonLib.CButton = Me.btnPayment
            margin = New System.Windows.Forms.Padding(1)
            cButton3.Margin = margin
            Me.btnPayment.Name = "btnPayment"
            Dim cButton4 As CButtonLib.CButton = Me.btnPayment
            size = New System.Drawing.Size(179, 72)
            cButton4.Size = size
            Me.btnPayment.TabIndex = 316
            Me.btnPayment.Text = "Payment"
            Me.btnPayment.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnPayment.TextShadowShow = False
            Me.btnPayment.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.pnlCalc.BackColor = System.Drawing.Color.Transparent
            Me.pnlCalc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlCalc.Controls.Add(Me.txtVATAmt)
            Me.pnlCalc.Controls.Add(Me.Label14)
            Me.pnlCalc.Controls.Add(Me.Label15)
            Me.pnlCalc.Controls.Add(Me.txtVATPer)
            Me.pnlCalc.Controls.Add(Me.txtDisc)
            Me.pnlCalc.Controls.Add(Me.Label45)
            Me.pnlCalc.Controls.Add(Me.Label46)
            Me.pnlCalc.Controls.Add(Me.txtDiscPer)
            Me.pnlCalc.Controls.Add(Me.Label32)
            Me.pnlCalc.Controls.Add(Me.txtTotal)
            Me.pnlCalc.Controls.Add(Me.Label24)
            Me.pnlCalc.Controls.Add(Me.txtPreviousDue)
            Me.pnlCalc.Controls.Add(Me.Label18)
            Me.pnlCalc.Controls.Add(Me.Label17)
            Me.pnlCalc.Controls.Add(Me.Label16)
            Me.pnlCalc.Controls.Add(Me.txtRoundOff)
            Me.pnlCalc.Controls.Add(Me.txtGrandTotal)
            Me.pnlCalc.Controls.Add(Me.txtOtherCharges)
            Me.pnlCalc.Controls.Add(Me.txtFreightCharges)
            Me.pnlCalc.Controls.Add(Me.Label21)
            Me.pnlCalc.Controls.Add(Me.txtSubTotal)
            Me.pnlCalc.Controls.Add(Me.Label31)
            Dim panel3 As System.Windows.Forms.Panel = Me.pnlCalc
            location = New System.Drawing.Point(594, 353)
            panel3.Location = location
            Me.pnlCalc.Name = "pnlCalc"
            Dim panel4 As System.Windows.Forms.Panel = Me.pnlCalc
            size = New System.Drawing.Size(202, 287)
            panel4.Size = size
            Me.pnlCalc.TabIndex = 315
            Me.txtVATAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox As System.Windows.Forms.TextBox = Me.txtVATAmt
            location = New System.Drawing.Point(103, 90)
            textBox.Location = location
            Me.txtVATAmt.Name = "txtVATAmt"
            Me.txtVATAmt.[ReadOnly] = True
            Dim textBox2 As System.Windows.Forms.TextBox = Me.txtVATAmt
            size = New System.Drawing.Size(88, 20)
            textBox2.Size = size
            Me.txtVATAmt.TabIndex = 4
            Me.txtVATAmt.Text = "0.00"
            Me.txtVATAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.Label14.AutoSize = True
            Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label2 As System.Windows.Forms.Label = Me.Label14
            location = New System.Drawing.Point(78, 92)
            label2.Location = location
            Me.Label14.Name = "Label14"
            Dim label3 As System.Windows.Forms.Label = Me.Label14
            size = New System.Drawing.Size(20, 16)
            label3.Size = size
            Me.Label14.TabIndex = 334
            Me.Label14.Text = "%"
            Me.Label15.AutoSize = True
            Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label4 As System.Windows.Forms.Label = Me.Label15
            location = New System.Drawing.Point(10, 74)
            label4.Location = location
            Me.Label15.Name = "Label15"
            Dim label5 As System.Windows.Forms.Label = Me.Label15
            size = New System.Drawing.Size(34, 13)
            label5.Size = size
            Me.Label15.TabIndex = 333
            Me.Label15.Text = "service charge"
            Me.txtVATPer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox3 As System.Windows.Forms.TextBox = Me.txtVATPer
            location = New System.Drawing.Point(13, 90)
            textBox3.Location = location
            Me.txtVATPer.Name = "txtVATPer"
            Dim textBox4 As System.Windows.Forms.TextBox = Me.txtVATPer
            size = New System.Drawing.Size(62, 20)
            textBox4.Size = size
            Me.txtVATPer.TabIndex = 3
            Me.txtVATPer.Text = "0.00"
            Me.txtVATPer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.txtDisc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox5 As System.Windows.Forms.TextBox = Me.txtDisc
            location = New System.Drawing.Point(103, 46)
            textBox5.Location = location
            Me.txtDisc.Name = "txtDisc"
            Me.txtDisc.[ReadOnly] = True
            Dim textBox6 As System.Windows.Forms.TextBox = Me.txtDisc
            size = New System.Drawing.Size(88, 20)
            textBox6.Size = size
            Me.txtDisc.TabIndex = 2
            Me.txtDisc.Text = "0.00"
            Me.txtDisc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.Label45.AutoSize = True
            Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label6 As System.Windows.Forms.Label = Me.Label45
            location = New System.Drawing.Point(78, 48)
            label6.Location = location
            Me.Label45.Name = "Label45"
            Dim label7 As System.Windows.Forms.Label = Me.Label45
            size = New System.Drawing.Size(20, 16)
            label7.Size = size
            Me.Label45.TabIndex = 330
            Me.Label45.Text = "%"
            Me.Label46.AutoSize = True
            Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label8 As System.Windows.Forms.Label = Me.Label46
            location = New System.Drawing.Point(10, 30)
            label8.Location = location
            Me.Label46.Name = "Label46"
            Dim label9 As System.Windows.Forms.Label = Me.Label46
            size = New System.Drawing.Size(55, 13)
            label9.Size = size
            Me.Label46.TabIndex = 329
            Me.Label46.Text = "Discount :"
            Me.txtDiscPer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox7 As System.Windows.Forms.TextBox = Me.txtDiscPer
            location = New System.Drawing.Point(13, 46)
            textBox7.Location = location
            Me.txtDiscPer.Name = "txtDiscPer"
            Dim textBox8 As System.Windows.Forms.TextBox = Me.txtDiscPer
            size = New System.Drawing.Size(62, 20)
            textBox8.Size = size
            Me.txtDiscPer.TabIndex = 0
            Me.txtDiscPer.Text = "0.00"
            Me.txtDiscPer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.Label32.AutoSize = True
            Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label10 As System.Windows.Forms.Label = Me.Label32
            location = New System.Drawing.Point(10, 200)
            label10.Location = location
            Me.Label32.Name = "Label32"
            Dim label11 As System.Windows.Forms.Label = Me.Label32
            size = New System.Drawing.Size(37, 13)
            label11.Size = size
            Me.Label32.TabIndex = 112
            Me.Label32.Text = "Total :"
            Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox9 As System.Windows.Forms.TextBox = Me.txtTotal
            location = New System.Drawing.Point(103, 200)
            textBox9.Location = location
            Me.txtTotal.Name = "txtTotal"
            Me.txtTotal.[ReadOnly] = True
            Dim textBox10 As System.Windows.Forms.TextBox = Me.txtTotal
            size = New System.Drawing.Size(88, 20)
            textBox10.Size = size
            Me.txtTotal.TabIndex = 8
            Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.Label24.AutoSize = True
            Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label12 As System.Windows.Forms.Label = Me.Label24
            location = New System.Drawing.Point(10, 174)
            label12.Location = location
            Me.Label24.Name = "Label24"
            Dim label13 As System.Windows.Forms.Label = Me.Label24
            size = New System.Drawing.Size(77, 13)
            label13.Size = size
            Me.Label24.TabIndex = 104
            Me.Label24.Text = "Previous Due :"
            Me.txtPreviousDue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox11 As System.Windows.Forms.TextBox = Me.txtPreviousDue
            location = New System.Drawing.Point(103, 174)
            textBox11.Location = location
            Me.txtPreviousDue.Name = "txtPreviousDue"
            Me.txtPreviousDue.[ReadOnly] = True
            Dim textBox12 As System.Windows.Forms.TextBox = Me.txtPreviousDue
            size = New System.Drawing.Size(88, 20)
            textBox12.Size = size
            Me.txtPreviousDue.TabIndex = 7
            Me.txtPreviousDue.Text = "0.00"
            Me.txtPreviousDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.Label18.AutoSize = True
            Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label14 As System.Windows.Forms.Label = Me.Label18
            location = New System.Drawing.Point(10, 149)
            label14.Location = location
            Me.Label18.Name = "Label18"
            Dim label15 As System.Windows.Forms.Label = Me.Label18
            size = New System.Drawing.Size(81, 13)
            label15.Size = size
            Me.Label18.TabIndex = 95
            Me.Label18.Text = "Other Charges :"
            Me.Label17.AutoSize = True
            Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label16 As System.Windows.Forms.Label = Me.Label17
            location = New System.Drawing.Point(10, 227)
            label16.Location = location
            Me.Label17.Name = "Label17"
            Dim label17 As System.Windows.Forms.Label = Me.Label17
            size = New System.Drawing.Size(62, 13)
            label17.Size = size
            Me.Label17.TabIndex = 94
            Me.Label17.Text = "Round Off :"
            Me.Label16.AutoSize = True
            Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label18 As System.Windows.Forms.Label = Me.Label16
            location = New System.Drawing.Point(10, 253)
            label18.Location = location
            Me.Label16.Name = "Label16"
            Dim label19 As System.Windows.Forms.Label = Me.Label16
            size = New System.Drawing.Size(69, 13)
            label19.Size = size
            Me.Label16.TabIndex = 93
            Me.Label16.Text = "Grand Total :"
            Me.txtRoundOff.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox13 As System.Windows.Forms.TextBox = Me.txtRoundOff
            location = New System.Drawing.Point(103, 227)
            textBox13.Location = location
            Me.txtRoundOff.Name = "txtRoundOff"
            Dim textBox14 As System.Windows.Forms.TextBox = Me.txtRoundOff
            size = New System.Drawing.Size(62, 20)
            textBox14.Size = size
            Me.txtRoundOff.TabIndex = 9
            Me.txtRoundOff.Text = "0.00"
            Me.txtRoundOff.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.txtGrandTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox15 As System.Windows.Forms.TextBox = Me.txtGrandTotal
            location = New System.Drawing.Point(103, 253)
            textBox15.Location = location
            Me.txtGrandTotal.Name = "txtGrandTotal"
            Me.txtGrandTotal.[ReadOnly] = True
            Dim textBox16 As System.Windows.Forms.TextBox = Me.txtGrandTotal
            size = New System.Drawing.Size(88, 20)
            textBox16.Size = size
            Me.txtGrandTotal.TabIndex = 10
            Me.txtGrandTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.txtOtherCharges.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox17 As System.Windows.Forms.TextBox = Me.txtOtherCharges
            location = New System.Drawing.Point(103, 147)
            textBox17.Location = location
            Me.txtOtherCharges.Name = "txtOtherCharges"
            Dim textBox18 As System.Windows.Forms.TextBox = Me.txtOtherCharges
            size = New System.Drawing.Size(88, 20)
            textBox18.Size = size
            Me.txtOtherCharges.TabIndex = 6
            Me.txtOtherCharges.Text = "0.00"
            Me.txtOtherCharges.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.txtFreightCharges.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox19 As System.Windows.Forms.TextBox = Me.txtFreightCharges
            location = New System.Drawing.Point(103, 121)
            textBox19.Location = location
            Me.txtFreightCharges.Name = "txtFreightCharges"
            Dim textBox20 As System.Windows.Forms.TextBox = Me.txtFreightCharges
            size = New System.Drawing.Size(88, 20)
            textBox20.Size = size
            Me.txtFreightCharges.TabIndex = 5
            Me.txtFreightCharges.Text = "0.00"
            Me.txtFreightCharges.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.Label21.AutoSize = True
            Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label20 As System.Windows.Forms.Label = Me.Label21
            location = New System.Drawing.Point(10, 123)
            label20.Location = location
            Me.Label21.Name = "Label21"
            Dim label21 As System.Windows.Forms.Label = Me.Label21
            size = New System.Drawing.Size(87, 13)
            label21.Size = size
            Me.Label21.TabIndex = 86
            Me.Label21.Text = "Freight Charges :"
            Me.txtSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox21 As System.Windows.Forms.TextBox = Me.txtSubTotal
            location = New System.Drawing.Point(103, 9)
            textBox21.Location = location
            Me.txtSubTotal.Name = "txtSubTotal"
            Me.txtSubTotal.[ReadOnly] = True
            Dim textBox22 As System.Windows.Forms.TextBox = Me.txtSubTotal
            size = New System.Drawing.Size(88, 20)
            textBox22.Size = size
            Me.txtSubTotal.TabIndex = 0
            Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.Label31.AutoSize = True
            Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label22 As System.Windows.Forms.Label = Me.Label31
            location = New System.Drawing.Point(10, 9)
            label22.Location = location
            Me.Label31.Name = "Label31"
            Dim label23 As System.Windows.Forms.Label = Me.Label31
            size = New System.Drawing.Size(59, 13)
            label23.Size = size
            Me.Label31.TabIndex = 84
            Me.Label31.Text = "Sub Total :"
            Me.GroupBox3.Controls.Add(Me.btnNew)
            Me.GroupBox3.Controls.Add(Me.btnGetData)
            Me.GroupBox3.Controls.Add(Me.btnSave)
            Me.GroupBox3.Controls.Add(Me.btnDelete)
            Dim groupBox As System.Windows.Forms.GroupBox = Me.GroupBox3
            location = New System.Drawing.Point(688, 50)
            groupBox.Location = location
            Me.GroupBox3.Name = "GroupBox3"
            Dim groupBox2 As System.Windows.Forms.GroupBox = Me.GroupBox3
            size = New System.Drawing.Size(108, 196)
            groupBox2.Size = size
            Me.GroupBox3.TabIndex = 314
            Me.GroupBox3.TabStop = False
            Me.btnNew.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnNew.Image = CType(componentResourceManager.GetObject("btnNew.Image"), System.Drawing.Image)
            Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button As System.Windows.Forms.Button = Me.btnNew
            location = New System.Drawing.Point(8, 14)
            button.Location = location
            Me.btnNew.Name = "btnNew"
            Dim button2 As System.Windows.Forms.Button = Me.btnNew
            size = New System.Drawing.Size(92, 40)
            button2.Size = size
            Me.btnNew.TabIndex = 1
            Me.btnNew.Text = "New"
            Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnNew.UseVisualStyleBackColor = True
            Me.btnGetData.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnGetData.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnGetData.Image = CType(componentResourceManager.GetObject("btnGetData.Image"), System.Drawing.Image)
            Me.btnGetData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button3 As System.Windows.Forms.Button = Me.btnGetData
            location = New System.Drawing.Point(10, 148)
            button3.Location = location
            Me.btnGetData.Name = "btnGetData"
            Dim button4 As System.Windows.Forms.Button = Me.btnGetData
            size = New System.Drawing.Size(92, 40)
            button4.Size = size
            Me.btnGetData.TabIndex = 5
            Me.btnGetData.Text = "Get Data"
            Me.btnGetData.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnGetData.UseVisualStyleBackColor = True
            Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnSave.Image = CType(componentResourceManager.GetObject("btnSave.Image"), System.Drawing.Image)
            Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button5 As System.Windows.Forms.Button = Me.btnSave
            location = New System.Drawing.Point(9, 58)
            button5.Location = location
            Me.btnSave.Name = "btnSave"
            Dim button6 As System.Windows.Forms.Button = Me.btnSave
            size = New System.Drawing.Size(92, 40)
            button6.Size = size
            Me.btnSave.TabIndex = 2
            Me.btnSave.Text = "Save"
            Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnSave.UseVisualStyleBackColor = True
            Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnDelete.Enabled = False
            Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnDelete.Image = CType(componentResourceManager.GetObject("btnDelete.Image"), System.Drawing.Image)
            Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button7 As System.Windows.Forms.Button = Me.btnDelete
            location = New System.Drawing.Point(10, 104)
            button7.Location = location
            Me.btnDelete.Name = "btnDelete"
            Dim button8 As System.Windows.Forms.Button = Me.btnDelete
            size = New System.Drawing.Size(92, 40)
            button8.Size = size
            Me.btnDelete.TabIndex = 4
            Me.btnDelete.Text = "Delete"
            Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnDelete.UseVisualStyleBackColor = True
            Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnClose.Image = RestaurantPOS14.My.Resources.Resources.Close_32x32
            Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
            Dim button9 As System.Windows.Forms.Button = Me.btnClose
            location = New System.Drawing.Point(720, 6)
            button9.Location = location
            Me.btnClose.Name = "btnClose"
            Dim button10 As System.Windows.Forms.Button = Me.btnClose
            size = New System.Drawing.Size(76, 38)
            button10.Size = size
            Me.btnClose.TabIndex = 313
            Me.btnClose.Text = "Close"
            Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnClose.UseVisualStyleBackColor = True
            Me.gbPartyInfo.Controls.Add(Me.btnSelection)
            Me.gbPartyInfo.Controls.Add(Me.Label10)
            Me.gbPartyInfo.Controls.Add(Me.txtSupplierID)
            Me.gbPartyInfo.Controls.Add(Me.lblBalance)
            Me.gbPartyInfo.Controls.Add(Me.Label11)
            Me.gbPartyInfo.Controls.Add(Me.txtContactNo)
            Me.gbPartyInfo.Controls.Add(Me.txtSupplierName)
            Me.gbPartyInfo.Controls.Add(Me.txtCity)
            Me.gbPartyInfo.Controls.Add(Me.txtAddress)
            Me.gbPartyInfo.Controls.Add(Me.Label26)
            Me.gbPartyInfo.Controls.Add(Me.Label29)
            Me.gbPartyInfo.Controls.Add(Me.Label30)
            Me.gbPartyInfo.Controls.Add(Me.Label36)
            Dim groupBox3 As System.Windows.Forms.GroupBox = Me.gbPartyInfo
            location = New System.Drawing.Point(259, 50)
            groupBox3.Location = location
            Me.gbPartyInfo.Name = "gbPartyInfo"
            Dim groupBox4 As System.Windows.Forms.GroupBox = Me.gbPartyInfo
            size = New System.Drawing.Size(423, 196)
            groupBox4.Size = size
            Me.gbPartyInfo.TabIndex = 1
            Me.gbPartyInfo.TabStop = False
            Me.gbPartyInfo.Text = "Supplier Info"
            Dim button11 As System.Windows.Forms.Button = Me.btnSelection
            location = New System.Drawing.Point(199, 25)
            button11.Location = location
            Me.btnSelection.Name = "btnSelection"
            Dim button12 As System.Windows.Forms.Button = Me.btnSelection
            size = New System.Drawing.Size(29, 21)
            button12.Size = size
            Me.btnSelection.TabIndex = 6
            Me.btnSelection.Text = "..."
            Me.btnSelection.UseVisualStyleBackColor = True
            Me.Label10.AutoSize = True
            Dim label24 As System.Windows.Forms.Label = Me.Label10
            location = New System.Drawing.Point(11, 53)
            label24.Location = location
            Me.Label10.Name = "Label10"
            Dim label25 As System.Windows.Forms.Label = Me.Label10
            size = New System.Drawing.Size(82, 13)
            label25.Size = size
            Me.Label10.TabIndex = 36
            Me.Label10.Text = "Supplier Name :"
            Me.txtSupplierID.BackColor = System.Drawing.SystemColors.Control
            Me.txtSupplierID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox23 As System.Windows.Forms.TextBox = Me.txtSupplierID
            location = New System.Drawing.Point(95, 25)
            textBox23.Location = location
            Me.txtSupplierID.Name = "txtSupplierID"
            Me.txtSupplierID.[ReadOnly] = True
            Dim textBox24 As System.Windows.Forms.TextBox = Me.txtSupplierID
            size = New System.Drawing.Size(98, 21)
            textBox24.Size = size
            Me.txtSupplierID.TabIndex = 0
            Me.lblBalance.AutoSize = True
            Me.lblBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.lblBalance.ForeColor = System.Drawing.Color.Maroon
            Dim label26 As System.Windows.Forms.Label = Me.lblBalance
            location = New System.Drawing.Point(91, 166)
            label26.Location = location
            Me.lblBalance.Name = "lblBalance"
            Dim label27 As System.Windows.Forms.Label = Me.lblBalance
            size = New System.Drawing.Size(44, 20)
            label27.Size = size
            Me.lblBalance.TabIndex = 5
            Me.lblBalance.Text = "0.00"
            Me.Label11.AutoSize = True
            Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim label28 As System.Windows.Forms.Label = Me.Label11
            location = New System.Drawing.Point(10, 166)
            label28.Location = location
            Me.Label11.Name = "Label11"
            Dim label29 As System.Windows.Forms.Label = Me.Label11
            size = New System.Drawing.Size(84, 20)
            label29.Size = size
            Me.Label11.TabIndex = 34
            Me.Label11.Text = "Balance :"
            Me.txtContactNo.BackColor = System.Drawing.SystemColors.Control
            Me.txtContactNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox25 As System.Windows.Forms.TextBox = Me.txtContactNo
            location = New System.Drawing.Point(95, 133)
            textBox25.Location = location
            Me.txtContactNo.Name = "txtContactNo"
            Me.txtContactNo.[ReadOnly] = True
            Dim textBox26 As System.Windows.Forms.TextBox = Me.txtContactNo
            size = New System.Drawing.Size(315, 21)
            textBox26.Size = size
            Me.txtContactNo.TabIndex = 4
            Me.txtSupplierName.BackColor = System.Drawing.SystemColors.Control
            Me.txtSupplierName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox27 As System.Windows.Forms.TextBox = Me.txtSupplierName
            location = New System.Drawing.Point(95, 52)
            textBox27.Location = location
            Me.txtSupplierName.Name = "txtSupplierName"
            Me.txtSupplierName.[ReadOnly] = True
            Dim textBox28 As System.Windows.Forms.TextBox = Me.txtSupplierName
            size = New System.Drawing.Size(315, 21)
            textBox28.Size = size
            Me.txtSupplierName.TabIndex = 1
            Me.txtCity.BackColor = System.Drawing.SystemColors.Control
            Me.txtCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox29 As System.Windows.Forms.TextBox = Me.txtCity
            location = New System.Drawing.Point(95, 106)
            textBox29.Location = location
            Me.txtCity.Name = "txtCity"
            Me.txtCity.[ReadOnly] = True
            Dim textBox30 As System.Windows.Forms.TextBox = Me.txtCity
            size = New System.Drawing.Size(315, 21)
            textBox30.Size = size
            Me.txtCity.TabIndex = 3
            Me.txtAddress.BackColor = System.Drawing.SystemColors.Control
            Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox31 As System.Windows.Forms.TextBox = Me.txtAddress
            location = New System.Drawing.Point(95, 79)
            textBox31.Location = location
            Me.txtAddress.Name = "txtAddress"
            Me.txtAddress.[ReadOnly] = True
            Dim textBox32 As System.Windows.Forms.TextBox = Me.txtAddress
            size = New System.Drawing.Size(315, 21)
            textBox32.Size = size
            Me.txtAddress.TabIndex = 2
            Me.Label26.AutoSize = True
            Dim label30 As System.Windows.Forms.Label = Me.Label26
            location = New System.Drawing.Point(11, 133)
            label30.Location = location
            Me.Label26.Name = "Label26"
            Dim label31 As System.Windows.Forms.Label = Me.Label26
            size = New System.Drawing.Size(70, 13)
            label31.Size = size
            Me.Label26.TabIndex = 29
            Me.Label26.Text = "Contact No. :"
            Me.Label29.AutoSize = True
            Dim label32 As System.Windows.Forms.Label = Me.Label29
            location = New System.Drawing.Point(11, 106)
            label32.Location = location
            Me.Label29.Name = "Label29"
            Dim label33 As System.Windows.Forms.Label = Me.Label29
            size = New System.Drawing.Size(30, 13)
            label33.Size = size
            Me.Label29.TabIndex = 27
            Me.Label29.Text = "City :"
            Me.Label30.AutoSize = True
            Dim label34 As System.Windows.Forms.Label = Me.Label30
            location = New System.Drawing.Point(11, 77)
            label34.Location = location
            Me.Label30.Name = "Label30"
            Dim label35 As System.Windows.Forms.Label = Me.Label30
            size = New System.Drawing.Size(51, 13)
            label35.Size = size
            Me.Label30.TabIndex = 26
            Me.Label30.Text = "Address :"
            Me.Label36.AutoSize = True
            Dim label36 As System.Windows.Forms.Label = Me.Label36
            location = New System.Drawing.Point(11, 25)
            label36.Location = location
            Me.Label36.Name = "Label36"
            Dim label37 As System.Windows.Forms.Label = Me.Label36
            size = New System.Drawing.Size(65, 13)
            label37.Size = size
            Me.Label36.TabIndex = 23
            Me.Label36.Text = "Supplier ID :"
            Dim richTextBox As System.Windows.Forms.RichTextBox = Me.txtRemarks
            location = New System.Drawing.Point(9, 159)
            richTextBox.Location = location
            Me.txtRemarks.Name = "txtRemarks"
            Dim richTextBox2 As System.Windows.Forms.RichTextBox = Me.txtRemarks
            size = New System.Drawing.Size(242, 87)
            richTextBox2.Size = size
            Me.txtRemarks.TabIndex = 310
            Me.txtRemarks.Text = ""
            Me.Label12.AutoSize = True
            Dim label38 As System.Windows.Forms.Label = Me.Label12
            location = New System.Drawing.Point(8, 143)
            label38.Location = location
            Me.Label12.Name = "Label12"
            Dim label39 As System.Windows.Forms.Label = Me.Label12
            size = New System.Drawing.Size(55, 13)
            label39.Size = size
            Me.Label12.TabIndex = 309
            Me.Label12.Text = "Remarks :"
            Me.DataGridView1.AllowUserToAddRows = False
            Me.DataGridView1.AllowUserToDeleteRows = False
            dataGridViewCellStyle.BackColor = System.Drawing.Color.FloralWhite
            Me.DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle
            Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
            Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            dataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2
            Me.DataGridView1.ColumnHeadersHeight = 24
            Me.DataGridView1.Columns.AddRange(Me.Column1, Me.Column3, Me.Column2, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8)
            Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            dataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64)
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.DataGridView1.DefaultCellStyle = dataGridViewCellStyle3
            Me.DataGridView1.EnableHeadersVisualStyles = False
            Me.DataGridView1.GridColor = System.Drawing.Color.White
            Dim dataGridView As System.Windows.Forms.DataGridView = Me.DataGridView1
            location = New System.Drawing.Point(9, 443)
            dataGridView.Location = location
            Me.DataGridView1.Name = "DataGridView1"
            Me.DataGridView1.[ReadOnly] = True
            Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White
            dataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Moccasin
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4
            Me.DataGridView1.RowHeadersWidth = 25
            Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White
            dataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Moccasin
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
            Me.DataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5
            Me.DataGridView1.RowTemplate.Height = 18
            Me.DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Dim dataGridView2 As System.Windows.Forms.DataGridView = Me.DataGridView1
            size = New System.Drawing.Size(579, 197)
            dataGridView2.Size = size
            Me.DataGridView1.TabIndex = 5
            Me.Column1.HeaderText = "PID"
            Me.Column1.Name = "Column1"
            Me.Column1.[ReadOnly] = True
            Me.Column1.Visible = False
            Me.Column3.HeaderText = "Product Name"
            Me.Column3.Name = "Column3"
            Me.Column3.[ReadOnly] = True
            Me.Column3.Width = 150
            Me.Column2.HeaderText = "Warehouse"
            Me.Column2.Name = "Column2"
            Me.Column2.[ReadOnly] = True
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.Column4.DefaultCellStyle = dataGridViewCellStyle6
            Me.Column4.HeaderText = "Qty."
            Me.Column4.Name = "Column4"
            Me.Column4.[ReadOnly] = True
            Me.Column4.Width = 70
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.Column5.DefaultCellStyle = dataGridViewCellStyle7
            Me.Column5.HeaderText = "Price Per Unit"
            Me.Column5.Name = "Column5"
            Me.Column5.[ReadOnly] = True
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.Column6.DefaultCellStyle = dataGridViewCellStyle8
            Me.Column6.HeaderText = "Total Amount"
            Me.Column6.Name = "Column6"
            Me.Column6.[ReadOnly] = True
            Me.Column7.HeaderText = "Has Expiry Date ?"
            Me.Column7.Name = "Column7"
            Me.Column7.[ReadOnly] = True
            Me.Column8.HeaderText = "Expiry Date"
            Me.Column8.Name = "Column8"
            Me.Column8.[ReadOnly] = True
            Me.GroupBox2.Controls.Add(Me.Button2)
            Me.GroupBox2.Controls.Add(Me.Button1)
            Me.GroupBox2.Controls.Add(Me.lblUnit)
            Me.GroupBox2.Controls.Add(Me.dtpExpiryDate)
            Me.GroupBox2.Controls.Add(label)
            Me.GroupBox2.Controls.Add(Me.chkHasExpiryDate)
            Me.GroupBox2.Controls.Add(Me.cmbWarehouse)
            Me.GroupBox2.Controls.Add(Me.Label7)
            Me.GroupBox2.Controls.Add(Me.btnRemove)
            Me.GroupBox2.Controls.Add(Me.btnAdd)
            Me.GroupBox2.Controls.Add(Me.cmbProductName)
            Me.GroupBox2.Controls.Add(Me.txtTotalAmount)
            Me.GroupBox2.Controls.Add(Me.txtPricePerQty)
            Me.GroupBox2.Controls.Add(Me.txtQty)
            Me.GroupBox2.Controls.Add(Me.Label9)
            Me.GroupBox2.Controls.Add(Me.Label6)
            Me.GroupBox2.Controls.Add(Me.Label4)
            Me.GroupBox2.Controls.Add(Me.Label8)
            Dim groupBox5 As System.Windows.Forms.GroupBox = Me.GroupBox2
            location = New System.Drawing.Point(11, 252)
            groupBox5.Location = location
            Me.GroupBox2.Name = "GroupBox2"
            Dim groupBox6 As System.Windows.Forms.GroupBox = Me.GroupBox2
            size = New System.Drawing.Size(511, 185)
            groupBox6.Size = size
            Me.GroupBox2.TabIndex = 2
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Product Info"
            Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.Button2.Image = RestaurantPOS14.My.Resources.Resources._1__2_
            Dim button13 As System.Windows.Forms.Button = Me.Button2
            location = New System.Drawing.Point(281, 61)
            button13.Location = location
            Me.Button2.Name = "Button2"
            Dim button14 As System.Windows.Forms.Button = Me.Button2
            size = New System.Drawing.Size(31, 23)
            button14.Size = size
            Me.Button2.TabIndex = 333
            Me.Button2.UseVisualStyleBackColor = True
            Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.Button1.Image = RestaurantPOS14.My.Resources.Resources._1__2_
            Dim button15 As System.Windows.Forms.Button = Me.Button1
            location = New System.Drawing.Point(372, 34)
            button15.Location = location
            Me.Button1.Name = "Button1"
            Dim button16 As System.Windows.Forms.Button = Me.Button1
            size = New System.Drawing.Size(31, 23)
            button16.Size = size
            Me.Button1.TabIndex = 332
            Me.Button1.UseVisualStyleBackColor = True
            Me.lblUnit.AutoSize = True
            Dim label40 As System.Windows.Forms.Label = Me.lblUnit
            location = New System.Drawing.Point(187, 93)
            label40.Location = location
            Me.lblUnit.Name = "lblUnit"
            Dim label41 As System.Windows.Forms.Label = Me.lblUnit
            size = New System.Drawing.Size(26, 13)
            label41.Size = size
            Me.lblUnit.TabIndex = 322
            Me.lblUnit.Text = "Unit"
            Me.lblUnit.Visible = False
            Me.dtpExpiryDate.CustomFormat = "dd/MM/yyyy"
            Me.dtpExpiryDate.Enabled = False
            Me.dtpExpiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Dim dateTimePicker As System.Windows.Forms.DateTimePicker = Me.dtpExpiryDate
            location = New System.Drawing.Point(271, 143)
            dateTimePicker.Location = location
            Me.dtpExpiryDate.Name = "dtpExpiryDate"
            Dim dateTimePicker2 As System.Windows.Forms.DateTimePicker = Me.dtpExpiryDate
            size = New System.Drawing.Size(117, 20)
            dateTimePicker2.Size = size
            Me.dtpExpiryDate.TabIndex = 6
            Me.chkHasExpiryDate.AutoSize = True
            Dim checkBox As System.Windows.Forms.CheckBox = Me.chkHasExpiryDate
            location = New System.Drawing.Point(271, 120)
            checkBox.Location = location
            Me.chkHasExpiryDate.Name = "chkHasExpiryDate"
            Dim checkBox2 As System.Windows.Forms.CheckBox = Me.chkHasExpiryDate
            size = New System.Drawing.Size(111, 17)
            checkBox2.Size = size
            Me.chkHasExpiryDate.TabIndex = 5
            Me.chkHasExpiryDate.Text = "Has Expiry Date ?"
            Me.chkHasExpiryDate.UseVisualStyleBackColor = True
            Me.cmbWarehouse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
            Me.cmbWarehouse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
            Me.cmbWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbWarehouse.FormattingEnabled = True
            Dim comboBox As System.Windows.Forms.ComboBox = Me.cmbWarehouse
            location = New System.Drawing.Point(111, 61)
            comboBox.Location = location
            Me.cmbWarehouse.Name = "cmbWarehouse"
            Dim comboBox2 As System.Windows.Forms.ComboBox = Me.cmbWarehouse
            size = New System.Drawing.Size(164, 21)
            comboBox2.Size = size
            Me.cmbWarehouse.TabIndex = 1
            Me.Label7.AutoSize = True
            Dim label42 As System.Windows.Forms.Label = Me.Label7
            location = New System.Drawing.Point(24, 61)
            label42.Location = location
            Me.Label7.Name = "Label7"
            Dim label43 As System.Windows.Forms.Label = Me.Label7
            size = New System.Drawing.Size(68, 13)
            label43.Size = size
            Me.Label7.TabIndex = 317
            Me.Label7.Text = "Warehouse :"
            Me.btnRemove.Enabled = False
            Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnRemove.Image = CType(componentResourceManager.GetObject("btnRemove.Image"), System.Drawing.Image)
            Me.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button17 As System.Windows.Forms.Button = Me.btnRemove
            location = New System.Drawing.Point(409, 74)
            button17.Location = location
            Me.btnRemove.Name = "btnRemove"
            Dim button18 As System.Windows.Forms.Button = Me.btnRemove
            size = New System.Drawing.Size(90, 34)
            button18.Size = size
            Me.btnRemove.TabIndex = 7
            Me.btnRemove.Text = "&Remove"
            Me.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnRemove.UseVisualStyleBackColor = True
            Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnAdd.Image = CType(componentResourceManager.GetObject("btnAdd.Image"), System.Drawing.Image)
            Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button19 As System.Windows.Forms.Button = Me.btnAdd
            location = New System.Drawing.Point(409, 34)
            button19.Location = location
            Me.btnAdd.Name = "btnAdd"
            Dim button20 As System.Windows.Forms.Button = Me.btnAdd
            size = New System.Drawing.Size(67, 34)
            button20.Size = size
            Me.btnAdd.TabIndex = 8
            Me.btnAdd.Text = "&Add"
            Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnAdd.UseVisualStyleBackColor = True
            Me.cmbProductName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
            Me.cmbProductName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
            Me.cmbProductName.FormattingEnabled = True
            Dim comboBox3 As System.Windows.Forms.ComboBox = Me.cmbProductName
            location = New System.Drawing.Point(111, 34)
            comboBox3.Location = location
            Me.cmbProductName.Name = "cmbProductName"
            Dim comboBox4 As System.Windows.Forms.ComboBox = Me.cmbProductName
            size = New System.Drawing.Size(256, 21)
            comboBox4.Size = size
            Me.cmbProductName.TabIndex = 0
            Me.txtTotalAmount.BackColor = System.Drawing.SystemColors.Control
            Me.txtTotalAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox33 As System.Windows.Forms.TextBox = Me.txtTotalAmount
            location = New System.Drawing.Point(111, 144)
            textBox33.Location = location
            Me.txtTotalAmount.Name = "txtTotalAmount"
            Me.txtTotalAmount.[ReadOnly] = True
            Dim textBox34 As System.Windows.Forms.TextBox = Me.txtTotalAmount
            size = New System.Drawing.Size(70, 21)
            textBox34.Size = size
            Me.txtTotalAmount.TabIndex = 4
            Me.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.txtPricePerQty.BackColor = System.Drawing.SystemColors.ButtonHighlight
            Me.txtPricePerQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox35 As System.Windows.Forms.TextBox = Me.txtPricePerQty
            location = New System.Drawing.Point(111, 115)
            textBox35.Location = location
            Me.txtPricePerQty.Name = "txtPricePerQty"
            Dim textBox36 As System.Windows.Forms.TextBox = Me.txtPricePerQty
            size = New System.Drawing.Size(70, 21)
            textBox36.Size = size
            Me.txtPricePerQty.TabIndex = 3
            Me.txtPricePerQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.txtQty.BackColor = System.Drawing.SystemColors.ButtonHighlight
            Me.txtQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox37 As System.Windows.Forms.TextBox = Me.txtQty
            location = New System.Drawing.Point(111, 88)
            textBox37.Location = location
            Me.txtQty.Name = "txtQty"
            Dim textBox38 As System.Windows.Forms.TextBox = Me.txtQty
            size = New System.Drawing.Size(70, 21)
            textBox38.Size = size
            Me.txtQty.TabIndex = 2
            Me.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.Label9.AutoSize = True
            Dim label44 As System.Windows.Forms.Label = Me.Label9
            location = New System.Drawing.Point(24, 144)
            label44.Location = location
            Me.Label9.Name = "Label9"
            Dim label45 As System.Windows.Forms.Label = Me.Label9
            size = New System.Drawing.Size(76, 13)
            label45.Size = size
            Me.Label9.TabIndex = 29
            Me.Label9.Text = "Total Amount :"
            Me.Label6.AutoSize = True
            Dim label46 As System.Windows.Forms.Label = Me.Label6
            location = New System.Drawing.Point(24, 115)
            label46.Location = location
            Me.Label6.Name = "Label6"
            Dim label47 As System.Windows.Forms.Label = Me.Label6
            size = New System.Drawing.Size(78, 13)
            label47.Size = size
            Me.Label6.TabIndex = 28
            Me.Label6.Text = "Price Per Unit :"
            Me.Label4.AutoSize = True
            Dim label48 As System.Windows.Forms.Label = Me.Label4
            location = New System.Drawing.Point(24, 88)
            label48.Location = location
            Me.Label4.Name = "Label4"
            Dim label49 As System.Windows.Forms.Label = Me.Label4
            size = New System.Drawing.Size(52, 13)
            label49.Size = size
            Me.Label4.TabIndex = 27
            Me.Label4.Text = "Quantity :"
            Me.Label8.AutoSize = True
            Dim label50 As System.Windows.Forms.Label = Me.Label8
            location = New System.Drawing.Point(24, 34)
            label50.Location = location
            Me.Label8.Name = "Label8"
            Dim label51 As System.Windows.Forms.Label = Me.Label8
            size = New System.Drawing.Size(81, 13)
            label51.Size = size
            Me.Label8.TabIndex = 22
            Me.Label8.Text = "Product Name :"
            Me.GroupBox1.Controls.Add(Me.dtpDate)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.txtInvoiceNo)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Dim groupBox7 As System.Windows.Forms.GroupBox = Me.GroupBox1
            location = New System.Drawing.Point(9, 50)
            groupBox7.Location = location
            Me.GroupBox1.Name = "GroupBox1"
            Dim groupBox8 As System.Windows.Forms.GroupBox = Me.GroupBox1
            size = New System.Drawing.Size(242, 90)
            groupBox8.Size = size
            Me.GroupBox1.TabIndex = 0
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Invoice Info"
            Me.dtpDate.CustomFormat = "dd/MM/yyyy"
            Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Dim dateTimePicker3 As System.Windows.Forms.DateTimePicker = Me.dtpDate
            location = New System.Drawing.Point(109, 52)
            dateTimePicker3.Location = location
            Me.dtpDate.Name = "dtpDate"
            Dim dateTimePicker4 As System.Windows.Forms.DateTimePicker = Me.dtpDate
            size = New System.Drawing.Size(124, 20)
            dateTimePicker4.Size = size
            Me.dtpDate.TabIndex = 1
            Me.Label3.AutoSize = True
            Dim label52 As System.Windows.Forms.Label = Me.Label3
            location = New System.Drawing.Point(11, 26)
            label52.Location = location
            Me.Label3.Name = "Label3"
            Dim label53 As System.Windows.Forms.Label = Me.Label3
            size = New System.Drawing.Size(68, 13)
            label53.Size = size
            Me.Label3.TabIndex = 0
            Me.Label3.Text = "Invoice No. :"
            Me.txtInvoiceNo.BackColor = System.Drawing.Color.White
            Me.txtInvoiceNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox39 As System.Windows.Forms.TextBox = Me.txtInvoiceNo
            location = New System.Drawing.Point(109, 26)
            textBox39.Location = location
            Me.txtInvoiceNo.Name = "txtInvoiceNo"
            Dim textBox40 As System.Windows.Forms.TextBox = Me.txtInvoiceNo
            size = New System.Drawing.Size(124, 21)
            textBox40.Size = size
            Me.txtInvoiceNo.TabIndex = 0
            Me.Label2.AutoSize = True
            Dim label54 As System.Windows.Forms.Label = Me.Label2
            location = New System.Drawing.Point(12, 52)
            label54.Location = location
            Me.Label2.Name = "Label2"
            Dim label55 As System.Windows.Forms.Label = Me.Label2
            size = New System.Drawing.Size(74, 13)
            label55.Size = size
            Me.Label2.TabIndex = 5
            Me.Label2.Text = "Invoice Date :"
            Me.Panel2.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Panel2.Controls.Add(Me.cmbPurchaseType)
            Me.Panel2.Controls.Add(Me.txtProductID)
            Me.Panel2.Controls.Add(Me.lblUserType)
            Me.Panel2.Controls.Add(Me.lblSet)
            Me.Panel2.Controls.Add(Me.lblUser)
            Me.Panel2.Controls.Add(Me.txtSup_ID)
            Me.Panel2.Controls.Add(Me.txtST_ID)
            Me.Panel2.Controls.Add(Me.Label1)
            Dim panel5 As System.Windows.Forms.Panel = Me.Panel2
            location = New System.Drawing.Point(9, 7)
            panel5.Location = location
            Me.Panel2.Name = "Panel2"
            Dim panel6 As System.Windows.Forms.Panel = Me.Panel2
            size = New System.Drawing.Size(705, 37)
            panel6.Size = size
            Me.Panel2.TabIndex = 0
            Me.cmbPurchaseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbPurchaseType.FormattingEnabled = True
            Me.cmbPurchaseType.Items.AddRange(New Object(1) {"Cash", "Credit"})
            Dim comboBox5 As System.Windows.Forms.ComboBox = Me.cmbPurchaseType
            location = New System.Drawing.Point(541, 11)
            comboBox5.Location = location
            Me.cmbPurchaseType.Name = "cmbPurchaseType"
            Dim comboBox6 As System.Windows.Forms.ComboBox = Me.cmbPurchaseType
            size = New System.Drawing.Size(69, 21)
            comboBox6.Size = size
            Me.cmbPurchaseType.TabIndex = 2
            Me.cmbPurchaseType.Visible = False
            Dim textBox41 As System.Windows.Forms.TextBox = Me.txtProductID
            location = New System.Drawing.Point(101, 6)
            textBox41.Location = location
            Me.txtProductID.Name = "txtProductID"
            Dim textBox42 As System.Windows.Forms.TextBox = Me.txtProductID
            size = New System.Drawing.Size(35, 20)
            textBox42.Size = size
            Me.txtProductID.TabIndex = 37
            Me.txtProductID.Visible = False
            Me.lblUserType.AutoSize = True
            Dim label56 As System.Windows.Forms.Label = Me.lblUserType
            location = New System.Drawing.Point(142, 16)
            label56.Location = location
            Me.lblUserType.Name = "lblUserType"
            Dim label57 As System.Windows.Forms.Label = Me.lblUserType
            size = New System.Drawing.Size(56, 13)
            label57.Size = size
            Me.lblUserType.TabIndex = 312
            Me.lblUserType.Text = "User Type"
            Me.lblUserType.Visible = False
            Me.lblSet.AutoSize = True
            Dim label58 As System.Windows.Forms.Label = Me.lblSet
            location = New System.Drawing.Point(187, 30)
            label58.Location = location
            Me.lblSet.Name = "lblSet"
            Dim label59 As System.Windows.Forms.Label = Me.lblSet
            size = New System.Drawing.Size(23, 13)
            label59.Size = size
            Me.lblSet.TabIndex = 311
            Me.lblSet.Text = "Set"
            Me.lblSet.Visible = False
            Me.lblUser.AutoSize = True
            Dim label60 As System.Windows.Forms.Label = Me.lblUser
            location = New System.Drawing.Point(142, 29)
            label60.Location = location
            Me.lblUser.Name = "lblUser"
            Dim label61 As System.Windows.Forms.Label = Me.lblUser
            size = New System.Drawing.Size(29, 13)
            label61.Size = size
            Me.lblUser.TabIndex = 6
            Me.lblUser.Text = "User"
            Me.lblUser.Visible = False
            Dim textBox43 As System.Windows.Forms.TextBox = Me.txtSup_ID
            location = New System.Drawing.Point(60, 6)
            textBox43.Location = location
            Me.txtSup_ID.Name = "txtSup_ID"
            Dim textBox44 As System.Windows.Forms.TextBox = Me.txtSup_ID
            size = New System.Drawing.Size(35, 20)
            textBox44.Size = size
            Me.txtSup_ID.TabIndex = 2
            Me.txtSup_ID.Visible = False
            Dim textBox45 As System.Windows.Forms.TextBox = Me.txtST_ID
            location = New System.Drawing.Point(14, 6)
            textBox45.Location = location
            Me.txtST_ID.Name = "txtST_ID"
            Dim textBox46 As System.Windows.Forms.TextBox = Me.txtST_ID
            size = New System.Drawing.Size(35, 20)
            textBox46.Size = size
            Me.txtST_ID.TabIndex = 1
            Me.txtST_ID.Visible = False
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label1.ForeColor = System.Drawing.Color.White
            Dim label62 As System.Windows.Forms.Label = Me.Label1
            location = New System.Drawing.Point(290, 6)
            label62.Location = location
            Me.Label1.Name = "Label1"
            Dim label63 As System.Windows.Forms.Label = Me.Label1
            size = New System.Drawing.Size(152, 24)
            label63.Size = size
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Purchase Entry"
            Me.txtTotalPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox47 As System.Windows.Forms.TextBox = Me.txtTotalPaid
            location = New System.Drawing.Point(528, 352)
            textBox47.Location = location
            Me.txtTotalPaid.Name = "txtTotalPaid"
            Dim textBox48 As System.Windows.Forms.TextBox = Me.txtTotalPaid
            size = New System.Drawing.Size(44, 20)
            textBox48.Size = size
            Me.txtTotalPaid.TabIndex = 11
            Me.txtTotalPaid.Text = "0.00"
            Me.txtTotalPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.txtTotalPaid.Visible = False
            Me.txtBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox49 As System.Windows.Forms.TextBox = Me.txtBalance
            location = New System.Drawing.Point(528, 376)
            textBox49.Location = location
            Me.txtBalance.Name = "txtBalance"
            Me.txtBalance.[ReadOnly] = True
            Dim textBox50 As System.Windows.Forms.TextBox = Me.txtBalance
            size = New System.Drawing.Size(44, 20)
            textBox50.Size = size
            Me.txtBalance.TabIndex = 12
            Me.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.txtBalance.Visible = False
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            size = New System.Drawing.Size(817, 660)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.Panel1)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MaximizeBox = False
            MyBase.MinimizeBox = False
            MyBase.Name = "frmPurchaseEntry"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.pnlCalc.ResumeLayout(False)
            Me.pnlCalc.PerformLayout()
            Me.GroupBox3.ResumeLayout(False)
            Me.gbPartyInfo.ResumeLayout(False)
            Me.gbPartyInfo.PerformLayout()
            CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            MyBase.ResumeLayout(False)
        End Sub
    End Class
End Namespace
