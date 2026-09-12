Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports RestaurantPOS14.My
Imports RestaurantPOS14.My.Resources

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public Class frmPurchaseOrder
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel1")>
        Private _Panel1 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label3")>
        Private _Label3 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtPONo")>
        Private _txtPONo As System.Windows.Forms.TextBox

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

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtTerms")>
        Private _txtTerms As System.Windows.Forms.RichTextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label12")>
        Private _Label12 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtSup_ID")>
        Private _txtSup_ID As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtPO_ID")>
        Private _txtPO_ID As System.Windows.Forms.TextBox

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

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("pnlCalc")>
        Private _pnlCalc As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtVATAmt")>
        Private _txtVATAmt As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label45")>
        Private _Label45 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label46")>
        Private _Label46 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtVAT")>
        Private _txtVAT As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtSubTotal")>
        Private _txtSubTotal As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label31")>
        Private _Label31 As System.Windows.Forms.Label

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

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblUnit")>
        Private _lblUnit As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label16")>
        Private _Label16 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtGrandTotal")>
        Private _txtGrandTotal As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnUpdate")>
        Private _btnUpdate As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnPrint")>
        Private _btnPrint As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Timer1")>
        Private _Timer1 As System.Windows.Forms.Timer

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label13")>
        Private _Label13 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("cmbTaxType")>
        Private _cmbTaxType As System.Windows.Forms.ComboBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnClear")>
        Private _btnClear As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnCancel")>
        Private _btnCancel As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column1")>
        Private _Column1 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column3")>
        Private _Column3 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column4")>
        Private _Column4 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column5")>
        Private _Column5 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column6")>
        Private _Column6 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtEmailID")>
        Private _txtEmailID As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Button1")>
        Private _Button1 As System.Windows.Forms.Button

        Private str As String

        Public st As String

        Public lblname As String

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

        Friend Overridable Property txtPONo As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtPONo
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtPONo = value
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
                Dim value2 As System.Windows.Forms.MouseEventHandler = AddressOf Me.DataGridView1_MouseClick
                Dim value3 As System.Windows.Forms.DataGridViewRowPostPaintEventHandler = AddressOf Me.DataGridView1_RowPostPaint
                If Me._DataGridView1 IsNot Nothing Then
                    RemoveHandler Me._DataGridView1.MouseClick, value2
                    RemoveHandler Me._DataGridView1.RowPostPaint, value3
                End If

                Me._DataGridView1 = value
                If Me._DataGridView1 IsNot Nothing Then
                    AddHandler Me._DataGridView1.MouseClick, value2
                    AddHandler Me._DataGridView1.RowPostPaint, value3
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

        Friend Overridable Property txtTerms As System.Windows.Forms.RichTextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtTerms
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.RichTextBox)
                Me._txtTerms = value
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

        Friend Overridable Property txtPO_ID As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtPO_ID
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtPO_ID = value
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

        Friend Overridable Property txtVAT As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtVAT
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.Windows.Forms.KeyPressEventHandler = AddressOf Me.txtDiscPer_KeyPress
                Dim value3 As System.EventHandler = AddressOf Me.txtDiscPer_TextChanged
                If Me._txtVAT IsNot Nothing Then
                    RemoveHandler Me._txtVAT.KeyPress, value2
                    RemoveHandler Me._txtVAT.TextChanged, value3
                End If

                Me._txtVAT = value
                If Me._txtVAT IsNot Nothing Then
                    AddHandler Me._txtVAT.KeyPress, value2
                    AddHandler Me._txtVAT.TextChanged, value3
                End If
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
                Dim value2 As System.EventHandler = AddressOf Me.txtSubTotal_TextChanged
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
                Dim value2 As System.Windows.Forms.ListControlConvertEventHandler = AddressOf Me.cmbProductName_Format
                Dim value3 As System.EventHandler = AddressOf Me.cmbProductName_SelectedIndexChanged
                If Me._cmbProductName IsNot Nothing Then
                    RemoveHandler Me._cmbProductName.Format, value2
                    RemoveHandler Me._cmbProductName.SelectedIndexChanged, value3
                End If

                Me._cmbProductName = value
                If Me._cmbProductName IsNot Nothing Then
                    AddHandler Me._cmbProductName.Format, value2
                    AddHandler Me._cmbProductName.SelectedIndexChanged, value3
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

        Friend Overridable Property btnUpdate As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnUpdate
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnUpdate_Click
                If Me._btnUpdate IsNot Nothing Then
                    RemoveHandler Me._btnUpdate.Click, value2
                End If

                Me._btnUpdate = value
                If Me._btnUpdate IsNot Nothing Then
                    AddHandler Me._btnUpdate.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnPrint As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnPrint
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnPrint_Click
                If Me._btnPrint IsNot Nothing Then
                    RemoveHandler Me._btnPrint.Click, value2
                End If

                Me._btnPrint = value
                If Me._btnPrint IsNot Nothing Then
                    AddHandler Me._btnPrint.Click, value2
                End If
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

        Friend Overridable Property Label13 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label13
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label13 = value
            End Set
        End Property

        Friend Overridable Property cmbTaxType As System.Windows.Forms.ComboBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._cmbTaxType
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ComboBox)
                Dim value2 As System.EventHandler = AddressOf Me.cmbTaxType_SelectedIndexChanged
                If Me._cmbTaxType IsNot Nothing Then
                    RemoveHandler Me._cmbTaxType.SelectedIndexChanged, value2
                End If

                Me._cmbTaxType = value
                If Me._cmbTaxType IsNot Nothing Then
                    AddHandler Me._cmbTaxType.SelectedIndexChanged, value2
                End If
            End Set
        End Property

        Public Overridable Property btnClear As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnClear
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnClear_Click
                If Me._btnClear IsNot Nothing Then
                    RemoveHandler Me._btnClear.Click, value2
                End If

                Me._btnClear = value
                If Me._btnClear IsNot Nothing Then
                    AddHandler Me._btnClear.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnCancel As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnCancel
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnCancel_Click
                If Me._btnCancel IsNot Nothing Then
                    RemoveHandler Me._btnCancel.Click, value2
                End If

                Me._btnCancel = value
                If Me._btnCancel IsNot Nothing Then
                    AddHandler Me._btnCancel.Click, value2
                End If
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

        Friend Overridable Property txtEmailID As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtEmailID
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtEmailID = value
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

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            Call RestaurantPOS14.frmPurchaseOrder.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmPurchaseOrder.__ENCList
                If RestaurantPOS14.frmPurchaseOrder.__ENCList.Count = RestaurantPOS14.frmPurchaseOrder.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmPurchaseOrder.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmPurchaseOrder.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmPurchaseOrder.__ENCList(num) = RestaurantPOS14.frmPurchaseOrder.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmPurchaseOrder.__ENCList.RemoveRange(num, RestaurantPOS14.frmPurchaseOrder.__ENCList.Count - num)
                    RestaurantPOS14.frmPurchaseOrder.__ENCList.Capacity = RestaurantPOS14.frmPurchaseOrder.__ENCList.Count
                End If

                Call RestaurantPOS14.frmPurchaseOrder.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Private Function GenerateID() As String
            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
            Dim text As String = "0000"
            Try
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT TOP 1 PO_ID FROM PurchaseOrder ORDER BY PO_ID DESC", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                If RestaurantPOS14.ModClasses.rdr.HasRows Then
                    RestaurantPOS14.ModClasses.rdr.Read()
                    text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr("PO_ID"))
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

        Public Sub GetRegisteredUserName(st As String)
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT RTRIM(Name) from Registration where UserID=@d1")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", st)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.lblname = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                Else
                    Me.lblname = ""
                End If

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub auto()
            Try
                Me.txtPO_ID.Text = Me.GenerateID()
                Me.txtPONo.Text = "PO-" & Me.GenerateID()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub Reset()
            Me.txtSupplierID.Text = ""
            Me.txtSupplierName.Text = ""
            Me.txtAddress.Text = ""
            Me.txtCity.Text = ""
            Me.txtContactNo.Text = ""
            Me.txtVAT.Text = "0.00"
            Me.txtVATAmt.Text = "0.00"
            Me.txtSubTotal.Text = "0.00"
            Me.txtSup_ID.Text = ""
            Me.txtGrandTotal.Text = ""
            Me.txtPONo.Text = ""
            Me.txtTerms.Text = ""
            Me.dtpDate.Value = Microsoft.VisualBasic.DateAndTime.Today
            If RestaurantPOS14.ModFunc.IsViewAllowed(Me.lblUser.Text, "Purchase Order") Then
                Me.btnGetData.Enabled = True
            Else
                Me.btnGetData.Enabled = False
            End If

            If RestaurantPOS14.ModFunc.IsSaveAllowed(Me.lblUser.Text, "Purchase Order") Then
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
            Me.txtPONo.[ReadOnly] = False
            Me.txtPONo.BackColor = System.Drawing.Color.White
            Me.DataGridView1.Rows.Clear()
            Me.cmbTaxType.SelectedIndex = 1
            Me.cmbTaxType.Enabled = True
            Me.btnSelection.Enabled = True
            Me.btnPrint.Enabled = False
            Me.lblSet.Text = ""
            Me.txtEmailID.Text = ""
            Me.cmbProductName.Items.Clear()
            Me.Clear()
            Me.auto()
        End Sub

        Public Function SubTotal() As Double
            Dim num As Double = 0.0
            Try
                For Each dataGridViewRow As System.Windows.Forms.DataGridViewRow In CType(Me.DataGridView1.Rows, System.Collections.IEnumerable)
                    num = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(num, dataGridViewRow.Cells(CInt((4))).Value))
                Next
            Catch ex As System.Exception
                Call Microsoft.VisualBasic.Interaction.MsgBox(ex.Message)
            End Try

            Return num
        End Function

        Public Sub Clear()
            Me.cmbProductName.Text = ""
            Me.cmbProductName.SelectedIndex = -1
            Me.lblUnit.Visible = False
            Me.txtQty.Text = ""
            Me.txtPricePerQty.Text = ""
            Me.txtTotalAmount.Text = ""
            Me.cmbProductName.Focus()
        End Sub

        Public Sub Compute()
            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.cmbTaxType.Text, "Inclusive", TextCompare:=False) = 0 Then
                Me.num6 = New Decimal(Microsoft.VisualBasic.Conversion.Val(Me.txtSubTotal.Text) - Microsoft.VisualBasic.Conversion.Val(Me.txtSubTotal.Text) / (1.0 + Microsoft.VisualBasic.Conversion.Val(Me.txtVAT.Text) / 100.0))
                Me.num6 = System.Math.Round(Me.num6, 2)
                Me.txtVATAmt.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Me.num6)
                Me.num1 = New Decimal(Microsoft.VisualBasic.Conversion.Val(Me.txtSubTotal.Text))
                Me.num1 = System.Math.Round(Me.num1, 2)
                Me.txtGrandTotal.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Me.num1)
            Else
                Me.num6 = New Decimal(Microsoft.VisualBasic.Conversion.Val(Me.txtSubTotal.Text) * Microsoft.VisualBasic.Conversion.Val(Me.txtVAT.Text) / 100.0)
                Me.num6 = System.Math.Round(Me.num6, 2)
                Me.txtVATAmt.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Me.num6)
                Me.num1 = New Decimal(System.Convert.ToDouble(Me.num6) + Microsoft.VisualBasic.Conversion.Val(Me.txtSubTotal.Text))
                Me.num1 = System.Math.Round(Me.num1, 2)
                Me.txtGrandTotal.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Me.num1)
            End If
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

        Private Sub txtPricePerQty_TextChanged(sender As Object, e As System.EventArgs)
            Me.Calc()
        End Sub

        Public Sub Calc()
            Dim value As Double = Microsoft.VisualBasic.Conversion.Val(Me.txtQty.Text) * Microsoft.VisualBasic.Conversion.Val(Me.txtPricePerQty.Text)
            value = System.Math.Round(value, 2)
            Me.txtTotalAmount.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(value)
        End Sub

        Private Sub txtQty_TextChanged(sender As Object, e As System.EventArgs)
            Me.Calc()
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

        Public Sub GetSupplierBalance()
            Try
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

                    Me.lblBalance.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(System.Math.Abs(Microsoft.VisualBasic.Conversion.Val(Me.lblBalance.Text)))
                    Me.lblBalance.Text =(Me.lblBalance.Text & " " & Me.str).ToString()
                Catch ex As System.Exception
                    Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                End Try
            Catch ex2 As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex2.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
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

        Private Sub DeleteRecord()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("delete from PurchaseOrder where PO_ID=@d1")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.Conversion.Val(Me.txtPO_ID.Text))
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                If RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery() > 0 Then
                    RestaurantPOS14.ModFunc.LogFunc(Me.lblUser.Text, "deleted the purchase order record having PO No. '" & Me.txtPONo.Text & "'")
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
            RestaurantPOS14.My.MyProject.Forms.frmSupplierRecord.lblSet.Text = "Purchase Order"
            RestaurantPOS14.My.MyProject.Forms.frmSupplierRecord.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmSupplierRecord.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmSupplierRecord.ShowDialog()
        End Sub

        Private Sub txtDiscPer_TextChanged(sender As Object, e As System.EventArgs)
            Me.Compute()
        End Sub

        Private Sub txtSubTotal_TextChanged(sender As Object, e As System.EventArgs)
            Me.Compute()
        End Sub

        Private Sub btnNew_Click(sender As Object, e As System.EventArgs)
            Me.Reset()
        End Sub

        Private Sub btnSave_Click(sender As Object, e As System.EventArgs)
            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtPONo.Text, "", TextCompare:=False) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please enter PO No.", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtPONo.Focus()
                Return
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtSup_ID.Text, "", TextCompare:=False) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please retrieve supplier id", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtSupplierID.Focus()
                Return
            End If

            If Me.DataGridView1.Rows.Count = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Sorry no product info added to grid", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Return
            End If

            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select PONumber from PurchaseOrder where PONumber=@d1")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtPONo.Text)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Purchase Order No. Already Exists", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                    Me.txtPONo.Text = ""
                    Me.txtPONo.Focus()
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("insert into PurchaseOrder(PO_ID,PONumber, Date,Supplier_ID,Terms,SubTotal,VATPer,VATAmount,GrandTotal,TaxType) VALUES (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d11,@d12)")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.Conversion.Val(Me.txtPO_ID.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Me.txtPONo.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Me.dtpDate.Value.[Date])
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", Microsoft.VisualBasic.Conversion.Val(Me.txtSup_ID.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d5", Me.txtTerms.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d6", Microsoft.VisualBasic.Conversion.Val(Me.txtSubTotal.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d7", Microsoft.VisualBasic.Conversion.Val(Me.txtVAT.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d8", Microsoft.VisualBasic.Conversion.Val(Me.txtVATAmt.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d11", Microsoft.VisualBasic.Conversion.Val(Me.txtGrandTotal.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d12", Me.cmbTaxType.Text)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                RestaurantPOS14.ModClasses.con.Close()
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("insert into PurchaseOrder_Join(PurchaseOrderID,ProductID,Qty,PricePerUnit,Amount) VALUES (" & RestaurantPOS14.Security.SqlInput.RequireInteger(Me.txtPO_ID.Text, "Record ID") & ",@d1,@d2,@d3,@d4)")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Prepare()
                For Each dataGridViewRow As System.Windows.Forms.DataGridViewRow In CType(Me.DataGridView1.Rows, System.Collections.IEnumerable)
                    If Not dataGridViewRow.IsNewRow Then
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((0))).Value)))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((2))).Value)))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((3))).Value)))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((4))).Value)))
                        RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                        RestaurantPOS14.ModClasses.cmd.Parameters.Clear()
                    End If
                Next

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModFunc.LogFunc(Me.lblUser.Text, "added the new Purchase Order having PO No. '" & Me.txtPONo.Text & "'")
                Call System.Windows.Forms.MessageBox.Show("Successfully saved", "Purchase Order", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                Me.btnSave.Enabled = False
                RestaurantPOS14.ModClasses.con.Close()
                Me.btnPrint.Enabled = True
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub fillCombo()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Select RTRIM(ProductName) from Product where P_Supplier=@d1 order by 1")
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtSupplierName.Text)
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
            RestaurantPOS14.My.MyProject.Forms.frmPurchaseOrderRecord.lblSet.Text = "PO"
            RestaurantPOS14.My.MyProject.Forms.frmPurchaseOrderRecord.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmPurchaseOrderRecord.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmPurchaseOrderRecord.ShowDialog()
        End Sub

        Private Sub cmbProductName_Format(sender As Object, e As System.Windows.Forms.ListControlConvertEventArgs)
            If e.DesiredType Is GetType(String) Then
                e.Value = e.Value.ToString().Trim()
            End If
        End Sub

        Private Sub cmbProductName_SelectedIndexChanged(sender As Object, e As System.EventArgs)
            Try
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

                Me.txtQty.Focus()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnAdd_Click(sender As Object, e As System.EventArgs)
            Try
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.cmbProductName.Text, "", TextCompare:=False) = 0 Then
                    Call System.Windows.Forms.MessageBox.Show("Please select product name", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Me.cmbProductName.Focus()
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

                If Me.DataGridView1.Rows.Count = 0 Then
                    Me.DataGridView1.Rows.Add(Microsoft.VisualBasic.Conversion.Val(Me.txtProductID.Text), Me.cmbProductName.Text, Microsoft.VisualBasic.Conversion.Val(Me.txtQty.Text), Microsoft.VisualBasic.Conversion.Val(Me.txtPricePerQty.Text), Microsoft.VisualBasic.Conversion.Val(Me.txtTotalAmount.Text))
                    Dim value As Double = Me.SubTotal()
                    value = System.Math.Round(value, 2)
                    Me.txtSubTotal.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(value)
                    Me.Clear()
                    Return
                End If

                For Each dataGridViewRow As System.Windows.Forms.DataGridViewRow In CType(Me.DataGridView1.Rows, System.Collections.IEnumerable)
                    If Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Me.txtProductID.Text, dataGridViewRow.Cells(CInt((0))).Value, TextCompare:=False) Then
                        Call System.Windows.Forms.MessageBox.Show("Already added to grid", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                        Return
                    End If
                Next

                Me.DataGridView1.Rows.Add(Microsoft.VisualBasic.Conversion.Val(Me.txtProductID.Text), Me.cmbProductName.Text, Microsoft.VisualBasic.Conversion.Val(Me.txtQty.Text), Microsoft.VisualBasic.Conversion.Val(Me.txtPricePerQty.Text), Microsoft.VisualBasic.Conversion.Val(Me.txtTotalAmount.Text))
                Dim value2 As Double = Me.SubTotal()
                value2 = System.Math.Round(value2, 2)
                Me.txtSubTotal.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(value2)
                Me.Clear()
            Catch ex As System.Exception
                Call Microsoft.VisualBasic.Interaction.MsgBox(ex.Message)
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

        Private Sub txtDiscPer_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
            Dim keyChar As Char = e.KeyChar
            If Char.IsControl(keyChar) Then
                Return
            End If

            If Char.IsDigit(keyChar) OrElse keyChar = "."c Then
                Dim text As String = Me.txtVAT.Text
                Dim selectionStart As Integer = Me.txtVAT.SelectionStart
                Dim selectionLength As Integer = Me.txtVAT.SelectionLength
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

        Private Sub btnUpdate_Click(sender As Object, e As System.EventArgs)
            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtPONo.Text, "", TextCompare:=False) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please enter PO No.", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtPONo.Focus()
                Return
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtSup_ID.Text, "", TextCompare:=False) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please retrieve supplier id", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtSupplierID.Focus()
                Return
            End If

            If Me.DataGridView1.Rows.Count = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Sorry no product info added to grid", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Return
            End If

            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Update PurchaseOrder Set PONumber=@d2, Date=@d3,Supplier_ID=@d4,Terms=@d5,SubTotal=@d6,VATPer=@d7,VATAmount=@d8,GrandTotal=@d11 where PO_ID=@d1 ")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.Conversion.Val(Me.txtPO_ID.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Me.txtPONo.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Me.dtpDate.Value.[Date])
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", Microsoft.VisualBasic.Conversion.Val(Me.txtSup_ID.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d5", Me.txtTerms.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d6", Microsoft.VisualBasic.Conversion.Val(Me.txtSubTotal.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d7", Microsoft.VisualBasic.Conversion.Val(Me.txtVAT.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d8", Microsoft.VisualBasic.Conversion.Val(Me.txtVATAmt.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d11", Microsoft.VisualBasic.Conversion.Val(Me.txtGrandTotal.Text))
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("delete from PurchaseOrder_Join where PurchaseOrderID=" & RestaurantPOS14.Security.SqlInput.RequireInteger(Me.txtPO_ID.Text, "Record ID"))
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                RestaurantPOS14.ModClasses.con.Close()
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("insert into PurchaseOrder_Join(PurchaseOrderID,ProductID,Qty,PricePerUnit,Amount) VALUES (" & RestaurantPOS14.Security.SqlInput.RequireInteger(Me.txtPO_ID.Text, "Record ID") & ",@d1,@d2,@d3,@d4)")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Prepare()
                For Each dataGridViewRow As System.Windows.Forms.DataGridViewRow In CType(Me.DataGridView1.Rows, System.Collections.IEnumerable)
                    If Not dataGridViewRow.IsNewRow Then
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((0))).Value)))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((2))).Value)))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((3))).Value)))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((4))).Value)))
                        RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                        RestaurantPOS14.ModClasses.cmd.Parameters.Clear()
                    End If
                Next

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModFunc.LogFunc(Me.lblUser.Text, "Updated the Purchase Order having PO No. '" & Me.txtPONo.Text & "'")
                Call System.Windows.Forms.MessageBox.Show("Successfully Updated", "Purchase Order", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                Me.btnUpdate.Enabled = False
                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub txtAddVATAmount_TextChanged(sender As Object, e As System.EventArgs)
            Me.Compute()
        End Sub

        Private Sub txtADDVAT_TextChanged(sender As Object, e As System.EventArgs)
            Me.Compute()
        End Sub

        Private Sub btnPrint_Click(sender As Object, e As System.EventArgs)
            Try
                MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Me.Timer1.Enabled = True
                Dim rptPurchaseOrder2 As RestaurantPOS14.rptPurchaseOrder = New RestaurantPOS14.rptPurchaseOrder()
                Dim sqlCommand As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand()
                Dim sqlCommand2 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand()
                Dim sqlDataAdapter As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter()
                Dim sqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter()
                Dim dataSet As System.Data.DataSet = New System.Data.DataSet()
                sqlCommand.Connection = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                Dim sqlConnection As System.Data.SqlClient.SqlConnection = sqlCommand.Connection
                Dim connection As System.Data.SqlClient.SqlConnection = sqlConnection
                sqlCommand2.Connection = connection
                sqlCommand.CommandText = "SELECT TaxType, PurchaseOrder.PO_ID, PurchaseOrder.PONumber, PurchaseOrder.Date, PurchaseOrder.Supplier_ID, PurchaseOrder.Terms, PurchaseOrder.SubTotal, PurchaseOrder.VATPer, PurchaseOrder.VATAmount, PurchaseOrder.GrandTotal, PurchaseOrder_Join.POJ_ID, PurchaseOrder_Join.PurchaseOrderID, PurchaseOrder_Join.ProductID, PurchaseOrder_Join.Qty,PurchaseOrder_Join.PricePerUnit, PurchaseOrder_Join.Amount, Product.PID, Product.ProductCode, Product.ProductName,  Product.Unit, Supplier.ID, Supplier.SupplierID, Supplier.Name,Supplier.Address, Supplier.City, Supplier.State, Supplier.ZipCode, Supplier.ContactNo, Supplier.EmailID, Supplier.Remarks, Supplier.TIN, Supplier.STNo, Supplier.CST, Supplier.PAN, Supplier.AccountName,Supplier.AccountNumber, Supplier.Bank, Supplier.Branch, Supplier.IFSCCode, Supplier.OpeningBalance, Supplier.OpeningBalanceType FROM PurchaseOrder INNER JOIN PurchaseOrder_Join ON PurchaseOrder.PO_ID = PurchaseOrder_Join.PurchaseOrderID INNER JOIN Product ON PurchaseOrder_Join.ProductID = Product.PID INNER JOIN Supplier ON PurchaseOrder.Supplier_ID = Supplier.ID where PO_ID=" & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.txtPO_ID.Text))
                sqlCommand2.CommandText = "SELECT * from Hotel"
                sqlCommand.CommandType = System.Data.CommandType.Text
                sqlCommand2.CommandType = System.Data.CommandType.Text
                sqlDataAdapter.SelectCommand = sqlCommand
                sqlDataAdapter2.SelectCommand = sqlCommand2
                sqlDataAdapter.Fill(dataSet, "PurchaseOrder")
                sqlDataAdapter.Fill(dataSet, "PurchaseOrder_Join")
                sqlDataAdapter.Fill(dataSet, "Supplier")
                sqlDataAdapter.Fill(dataSet, "Product")
                sqlDataAdapter2.Fill(dataSet, "Hotel")
                rptPurchaseOrder2.SetDataSource(dataSet)
                Me.GetRegisteredUserName(Me.lblUser.Text)
                rptPurchaseOrder2.SetParameterValue("p1", Me.lblname)
                RestaurantPOS14.My.MyProject.Forms.frmPO_CRViewer.CrystalReportViewer1.ReportSource = rptPurchaseOrder2
                RestaurantPOS14.My.MyProject.Forms.frmPO_CRViewer.txtEmailID.Text = Me.txtEmailID.Text
                RestaurantPOS14.My.MyProject.Forms.frmPO_CRViewer.lblUser.Text = Me.lblUser.Text
                Call RestaurantPOS14.My.MyProject.Forms.frmPO_CRViewer.ShowDialog()
                rptPurchaseOrder2.Close()
                rptPurchaseOrder2.Dispose()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub Timer1_Tick(sender As Object, e As System.EventArgs)
            MyBase.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.Timer1.Enabled = False
        End Sub

        Private Sub cmbTaxType_SelectedIndexChanged(sender As Object, e As System.EventArgs)
            Me.Calc()
            Me.Compute()
        End Sub

        Private Sub btnClear_Click(sender As Object, e As System.EventArgs)
            Me.Clear()
        End Sub

        Private Sub btnCancel_Click(sender As Object, e As System.EventArgs)
            MyBase.Close()
        End Sub

        Private Sub Button1_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmProduct.lblUser.Text = Me.lblUser.Text
            RestaurantPOS14.My.MyProject.Forms.frmProduct.lblSet.Text = "Purchase Order"
            Call RestaurantPOS14.My.MyProject.Forms.frmProduct.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmProduct.ShowDialog()
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmPurchaseOrder))
            Dim dataGridViewCellStyle As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.btnPrint = New System.Windows.Forms.Button()
            Me.btnUpdate = New System.Windows.Forms.Button()
            Me.btnNew = New System.Windows.Forms.Button()
            Me.btnGetData = New System.Windows.Forms.Button()
            Me.btnSave = New System.Windows.Forms.Button()
            Me.btnDelete = New System.Windows.Forms.Button()
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
            Me.pnlCalc = New System.Windows.Forms.Panel()
            Me.txtVATAmt = New System.Windows.Forms.TextBox()
            Me.Label45 = New System.Windows.Forms.Label()
            Me.Label46 = New System.Windows.Forms.Label()
            Me.txtVAT = New System.Windows.Forms.TextBox()
            Me.Label16 = New System.Windows.Forms.Label()
            Me.txtGrandTotal = New System.Windows.Forms.TextBox()
            Me.txtSubTotal = New System.Windows.Forms.TextBox()
            Me.Label31 = New System.Windows.Forms.Label()
            Me.txtTerms = New System.Windows.Forms.RichTextBox()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.DataGridView1 = New System.Windows.Forms.DataGridView()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.btnClear = New System.Windows.Forms.Button()
            Me.lblUnit = New System.Windows.Forms.Label()
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
            Me.Label13 = New System.Windows.Forms.Label()
            Me.cmbTaxType = New System.Windows.Forms.ComboBox()
            Me.dtpDate = New System.Windows.Forms.DateTimePicker()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtPONo = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.txtEmailID = New System.Windows.Forms.TextBox()
            Me.txtProductID = New System.Windows.Forms.TextBox()
            Me.lblUserType = New System.Windows.Forms.Label()
            Me.lblSet = New System.Windows.Forms.Label()
            Me.lblUser = New System.Windows.Forms.Label()
            Me.txtSup_ID = New System.Windows.Forms.TextBox()
            Me.txtPO_ID = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.Panel1.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            Me.gbPartyInfo.SuspendLayout()
            Me.pnlCalc.SuspendLayout()
            CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox2.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            MyBase.SuspendLayout()
            Me.Panel1.BackColor = System.Drawing.Color.White
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.GroupBox3)
            Me.Panel1.Controls.Add(Me.gbPartyInfo)
            Me.Panel1.Controls.Add(Me.pnlCalc)
            Me.Panel1.Controls.Add(Me.txtTerms)
            Me.Panel1.Controls.Add(Me.Label12)
            Me.Panel1.Controls.Add(Me.DataGridView1)
            Me.Panel1.Controls.Add(Me.GroupBox2)
            Me.Panel1.Controls.Add(Me.GroupBox1)
            Dim panel As System.Windows.Forms.Panel = Me.Panel1
            Dim location As System.Drawing.Point = New System.Drawing.Point(8, 51)
            panel.Location = location
            Me.Panel1.Name = "Panel1"
            Dim panel2 As System.Windows.Forms.Panel = Me.Panel1
            Dim size As System.Drawing.Size = New System.Drawing.Size(992, 622)
            panel2.Size = size
            Me.Panel1.TabIndex = 2
            Me.GroupBox3.Controls.Add(Me.btnPrint)
            Me.GroupBox3.Controls.Add(Me.btnUpdate)
            Me.GroupBox3.Controls.Add(Me.btnNew)
            Me.GroupBox3.Controls.Add(Me.btnGetData)
            Me.GroupBox3.Controls.Add(Me.btnSave)
            Me.GroupBox3.Controls.Add(Me.btnDelete)
            Dim groupBox As System.Windows.Forms.GroupBox = Me.GroupBox3
            location = New System.Drawing.Point(688, 3)
            groupBox.Location = location
            Me.GroupBox3.Name = "GroupBox3"
            Dim groupBox2 As System.Windows.Forms.GroupBox = Me.GroupBox3
            size = New System.Drawing.Size(108, 277)
            groupBox2.Size = size
            Me.GroupBox3.TabIndex = 314
            Me.GroupBox3.TabStop = False
            Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnPrint.Enabled = False
            Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnPrint.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnPrint.ForeColor = System.Drawing.Color.White
            Me.btnPrint.Image = CType(componentResourceManager.GetObject("btnPrint.Image"), System.Drawing.Image)
            Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button As System.Windows.Forms.Button = Me.btnPrint
            location = New System.Drawing.Point(10, 229)
            button.Location = location
            Me.btnPrint.Name = "btnPrint"
            Dim button2 As System.Windows.Forms.Button = Me.btnPrint
            size = New System.Drawing.Size(90, 37)
            button2.Size = size
            Me.btnPrint.TabIndex = 9
            Me.btnPrint.Text = "Print"
            Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnPrint.UseVisualStyleBackColor = False
            Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnUpdate.Enabled = False
            Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnUpdate.ForeColor = System.Drawing.Color.White
            Me.btnUpdate.Image = CType(componentResourceManager.GetObject("btnUpdate.Image"), System.Drawing.Image)
            Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button3 As System.Windows.Forms.Button = Me.btnUpdate
            location = New System.Drawing.Point(9, 102)
            button3.Location = location
            Me.btnUpdate.Name = "btnUpdate"
            Dim button4 As System.Windows.Forms.Button = Me.btnUpdate
            size = New System.Drawing.Size(91, 37)
            button4.Size = size
            Me.btnUpdate.TabIndex = 6
            Me.btnUpdate.Text = "Update"
            Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnUpdate.UseVisualStyleBackColor = False
            Me.btnNew.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.btnNew.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnNew.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnNew.ForeColor = System.Drawing.Color.White
            Me.btnNew.Image = CType(componentResourceManager.GetObject("btnNew.Image"), System.Drawing.Image)
            Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button5 As System.Windows.Forms.Button = Me.btnNew
            location = New System.Drawing.Point(8, 14)
            button5.Location = location
            Me.btnNew.Name = "btnNew"
            Dim button6 As System.Windows.Forms.Button = Me.btnNew
            size = New System.Drawing.Size(92, 40)
            button6.Size = size
            Me.btnNew.TabIndex = 1
            Me.btnNew.Text = "New"
            Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnNew.UseVisualStyleBackColor = False
            Me.btnGetData.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.btnGetData.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnGetData.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnGetData.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnGetData.ForeColor = System.Drawing.Color.White
            Me.btnGetData.Image = CType(componentResourceManager.GetObject("btnGetData.Image"), System.Drawing.Image)
            Me.btnGetData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button7 As System.Windows.Forms.Button = Me.btnGetData
            location = New System.Drawing.Point(10, 186)
            button7.Location = location
            Me.btnGetData.Name = "btnGetData"
            Dim button8 As System.Windows.Forms.Button = Me.btnGetData
            size = New System.Drawing.Size(90, 40)
            button8.Size = size
            Me.btnGetData.TabIndex = 5
            Me.btnGetData.Text = "Get Data"
            Me.btnGetData.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnGetData.UseVisualStyleBackColor = False
            Me.btnSave.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnSave.ForeColor = System.Drawing.Color.White
            Me.btnSave.Image = CType(componentResourceManager.GetObject("btnSave.Image"), System.Drawing.Image)
            Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button9 As System.Windows.Forms.Button = Me.btnSave
            location = New System.Drawing.Point(9, 58)
            button9.Location = location
            Me.btnSave.Name = "btnSave"
            Dim button10 As System.Windows.Forms.Button = Me.btnSave
            size = New System.Drawing.Size(91, 40)
            button10.Size = size
            Me.btnSave.TabIndex = 2
            Me.btnSave.Text = "Save"
            Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnSave.UseVisualStyleBackColor = False
            Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnDelete.Enabled = False
            Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnDelete.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnDelete.ForeColor = System.Drawing.Color.White
            Me.btnDelete.Image = CType(componentResourceManager.GetObject("btnDelete.Image"), System.Drawing.Image)
            Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button11 As System.Windows.Forms.Button = Me.btnDelete
            location = New System.Drawing.Point(10, 142)
            button11.Location = location
            Me.btnDelete.Name = "btnDelete"
            Dim button12 As System.Windows.Forms.Button = Me.btnDelete
            size = New System.Drawing.Size(90, 40)
            button12.Size = size
            Me.btnDelete.TabIndex = 4
            Me.btnDelete.Text = "Delete"
            Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnDelete.UseVisualStyleBackColor = False
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
            Me.gbPartyInfo.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim groupBox3 As System.Windows.Forms.GroupBox = Me.gbPartyInfo
            location = New System.Drawing.Point(259, 3)
            groupBox3.Location = location
            Me.gbPartyInfo.Name = "gbPartyInfo"
            Dim groupBox4 As System.Windows.Forms.GroupBox = Me.gbPartyInfo
            size = New System.Drawing.Size(423, 196)
            groupBox4.Size = size
            Me.gbPartyInfo.TabIndex = 1
            Me.gbPartyInfo.TabStop = False
            Me.gbPartyInfo.Text = "Supplier Info"
            Dim button13 As System.Windows.Forms.Button = Me.btnSelection
            location = New System.Drawing.Point(201, 23)
            button13.Location = location
            Me.btnSelection.Name = "btnSelection"
            Dim button14 As System.Windows.Forms.Button = Me.btnSelection
            size = New System.Drawing.Size(44, 25)
            button14.Size = size
            Me.btnSelection.TabIndex = 6
            Me.btnSelection.Text = "..."
            Me.btnSelection.UseVisualStyleBackColor = True
            Me.Label10.AutoSize = True
            Dim label As System.Windows.Forms.Label = Me.Label10
            location = New System.Drawing.Point(11, 53)
            label.Location = location
            Me.Label10.Name = "Label10"
            Dim label2 As System.Windows.Forms.Label = Me.Label10
            size = New System.Drawing.Size(88, 13)
            label2.Size = size
            Me.Label10.TabIndex = 36
            Me.Label10.Text = "Supplier Name :"
            Me.txtSupplierID.BackColor = System.Drawing.SystemColors.Control
            Me.txtSupplierID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox As System.Windows.Forms.TextBox = Me.txtSupplierID
            location = New System.Drawing.Point(100, 25)
            textBox.Location = location
            Me.txtSupplierID.Name = "txtSupplierID"
            Me.txtSupplierID.[ReadOnly] = True
            Dim textBox2 As System.Windows.Forms.TextBox = Me.txtSupplierID
            size = New System.Drawing.Size(98, 21)
            textBox2.Size = size
            Me.txtSupplierID.TabIndex = 0
            Me.lblBalance.AutoSize = True
            Me.lblBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.lblBalance.ForeColor = System.Drawing.Color.Maroon
            Dim label3 As System.Windows.Forms.Label = Me.lblBalance
            location = New System.Drawing.Point(96, 166)
            label3.Location = location
            Me.lblBalance.Name = "lblBalance"
            Dim label4 As System.Windows.Forms.Label = Me.lblBalance
            size = New System.Drawing.Size(44, 20)
            label4.Size = size
            Me.lblBalance.TabIndex = 5
            Me.lblBalance.Text = "0.00"
            Me.Label11.AutoSize = True
            Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim label5 As System.Windows.Forms.Label = Me.Label11
            location = New System.Drawing.Point(10, 166)
            label5.Location = location
            Me.Label11.Name = "Label11"
            Dim label6 As System.Windows.Forms.Label = Me.Label11
            size = New System.Drawing.Size(84, 20)
            label6.Size = size
            Me.Label11.TabIndex = 34
            Me.Label11.Text = "Balance :"
            Me.txtContactNo.BackColor = System.Drawing.SystemColors.Control
            Me.txtContactNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox3 As System.Windows.Forms.TextBox = Me.txtContactNo
            location = New System.Drawing.Point(100, 133)
            textBox3.Location = location
            Me.txtContactNo.Name = "txtContactNo"
            Me.txtContactNo.[ReadOnly] = True
            Dim textBox4 As System.Windows.Forms.TextBox = Me.txtContactNo
            size = New System.Drawing.Size(315, 21)
            textBox4.Size = size
            Me.txtContactNo.TabIndex = 4
            Me.txtSupplierName.BackColor = System.Drawing.SystemColors.Control
            Me.txtSupplierName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox5 As System.Windows.Forms.TextBox = Me.txtSupplierName
            location = New System.Drawing.Point(100, 52)
            textBox5.Location = location
            Me.txtSupplierName.Name = "txtSupplierName"
            Me.txtSupplierName.[ReadOnly] = True
            Dim textBox6 As System.Windows.Forms.TextBox = Me.txtSupplierName
            size = New System.Drawing.Size(315, 21)
            textBox6.Size = size
            Me.txtSupplierName.TabIndex = 1
            Me.txtCity.BackColor = System.Drawing.SystemColors.Control
            Me.txtCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox7 As System.Windows.Forms.TextBox = Me.txtCity
            location = New System.Drawing.Point(100, 106)
            textBox7.Location = location
            Me.txtCity.Name = "txtCity"
            Me.txtCity.[ReadOnly] = True
            Dim textBox8 As System.Windows.Forms.TextBox = Me.txtCity
            size = New System.Drawing.Size(315, 21)
            textBox8.Size = size
            Me.txtCity.TabIndex = 3
            Me.txtAddress.BackColor = System.Drawing.SystemColors.Control
            Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox9 As System.Windows.Forms.TextBox = Me.txtAddress
            location = New System.Drawing.Point(100, 79)
            textBox9.Location = location
            Me.txtAddress.Name = "txtAddress"
            Me.txtAddress.[ReadOnly] = True
            Dim textBox10 As System.Windows.Forms.TextBox = Me.txtAddress
            size = New System.Drawing.Size(315, 21)
            textBox10.Size = size
            Me.txtAddress.TabIndex = 2
            Me.Label26.AutoSize = True
            Dim label7 As System.Windows.Forms.Label = Me.Label26
            location = New System.Drawing.Point(11, 133)
            label7.Location = location
            Me.Label26.Name = "Label26"
            Dim label8 As System.Windows.Forms.Label = Me.Label26
            size = New System.Drawing.Size(73, 13)
            label8.Size = size
            Me.Label26.TabIndex = 29
            Me.Label26.Text = "Contact No. :"
            Me.Label29.AutoSize = True
            Dim label9 As System.Windows.Forms.Label = Me.Label29
            location = New System.Drawing.Point(11, 106)
            label9.Location = location
            Me.Label29.Name = "Label29"
            Dim label10 As System.Windows.Forms.Label = Me.Label29
            size = New System.Drawing.Size(33, 13)
            label10.Size = size
            Me.Label29.TabIndex = 27
            Me.Label29.Text = "City :"
            Me.Label30.AutoSize = True
            Dim label11 As System.Windows.Forms.Label = Me.Label30
            location = New System.Drawing.Point(11, 77)
            label11.Location = location
            Me.Label30.Name = "Label30"
            Dim label12 As System.Windows.Forms.Label = Me.Label30
            size = New System.Drawing.Size(54, 13)
            label12.Size = size
            Me.Label30.TabIndex = 26
            Me.Label30.Text = "Address :"
            Me.Label36.AutoSize = True
            Dim label13 As System.Windows.Forms.Label = Me.Label36
            location = New System.Drawing.Point(11, 25)
            label13.Location = location
            Me.Label36.Name = "Label36"
            Dim label14 As System.Windows.Forms.Label = Me.Label36
            size = New System.Drawing.Size(69, 13)
            label14.Size = size
            Me.Label36.TabIndex = 23
            Me.Label36.Text = "Supplier ID :"
            Me.pnlCalc.BackColor = System.Drawing.Color.Transparent
            Me.pnlCalc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlCalc.Controls.Add(Me.txtVATAmt)
            Me.pnlCalc.Controls.Add(Me.Label45)
            Me.pnlCalc.Controls.Add(Me.Label46)
            Me.pnlCalc.Controls.Add(Me.txtVAT)
            Me.pnlCalc.Controls.Add(Me.Label16)
            Me.pnlCalc.Controls.Add(Me.txtGrandTotal)
            Me.pnlCalc.Controls.Add(Me.txtSubTotal)
            Me.pnlCalc.Controls.Add(Me.Label31)
            Dim panel3 As System.Windows.Forms.Panel = Me.pnlCalc
            location = New System.Drawing.Point(528, 508)
            panel3.Location = location
            Me.pnlCalc.Name = "pnlCalc"
            Dim panel4 As System.Windows.Forms.Panel = Me.pnlCalc
            size = New System.Drawing.Size(202, 108)
            panel4.Size = size
            Me.pnlCalc.TabIndex = 1
            Me.txtVATAmt.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox11 As System.Windows.Forms.TextBox = Me.txtVATAmt
            location = New System.Drawing.Point(105, 44)
            textBox11.Location = location
            Me.txtVATAmt.Name = "txtVATAmt"
            Me.txtVATAmt.[ReadOnly] = True
            Dim textBox12 As System.Windows.Forms.TextBox = Me.txtVATAmt
            size = New System.Drawing.Size(88, 23)
            textBox12.Size = size
            Me.txtVATAmt.TabIndex = 2
            Me.txtVATAmt.Text = "0.00"
            Me.txtVATAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.Label45.AutoSize = True
            Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label15 As System.Windows.Forms.Label = Me.Label45
            location = New System.Drawing.Point(78, 48)
            label15.Location = location
            Me.Label45.Name = "Label45"
            Dim label16 As System.Windows.Forms.Label = Me.Label45
            size = New System.Drawing.Size(20, 16)
            label16.Size = size
            Me.Label45.TabIndex = 330
            Me.Label45.Text = "%"
            Me.Label46.AutoSize = True
            Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label17 As System.Windows.Forms.Label = Me.Label46
            location = New System.Drawing.Point(13, 30)
            label17.Location = location
            Me.Label46.Name = "Label46"
            Dim label18 As System.Windows.Forms.Label = Me.Label46
            size = New System.Drawing.Size(34, 13)
            label18.Size = size
            Me.Label46.TabIndex = 329
            Me.Label46.Text = "service charge"
            Me.txtVAT.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox13 As System.Windows.Forms.TextBox = Me.txtVAT
            location = New System.Drawing.Point(13, 46)
            textBox13.Location = location
            Me.txtVAT.Name = "txtVAT"
            Dim textBox14 As System.Windows.Forms.TextBox = Me.txtVAT
            size = New System.Drawing.Size(62, 23)
            textBox14.Size = size
            Me.txtVAT.TabIndex = 1
            Me.txtVAT.Text = "0.00"
            Me.txtVAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.Label16.AutoSize = True
            Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label19 As System.Windows.Forms.Label = Me.Label16
            location = New System.Drawing.Point(13, 80)
            label19.Location = location
            Me.Label16.Name = "Label16"
            Dim label20 As System.Windows.Forms.Label = Me.Label16
            size = New System.Drawing.Size(69, 13)
            label20.Size = size
            Me.Label16.TabIndex = 93
            Me.Label16.Text = "Grand Total :"
            Me.txtGrandTotal.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox15 As System.Windows.Forms.TextBox = Me.txtGrandTotal
            location = New System.Drawing.Point(105, 73)
            textBox15.Location = location
            Me.txtGrandTotal.Name = "txtGrandTotal"
            Me.txtGrandTotal.[ReadOnly] = True
            Dim textBox16 As System.Windows.Forms.TextBox = Me.txtGrandTotal
            size = New System.Drawing.Size(88, 23)
            textBox16.Size = size
            Me.txtGrandTotal.TabIndex = 5
            Me.txtGrandTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.txtSubTotal.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox17 As System.Windows.Forms.TextBox = Me.txtSubTotal
            location = New System.Drawing.Point(105, 9)
            textBox17.Location = location
            Me.txtSubTotal.Name = "txtSubTotal"
            Me.txtSubTotal.[ReadOnly] = True
            Dim textBox18 As System.Windows.Forms.TextBox = Me.txtSubTotal
            size = New System.Drawing.Size(88, 23)
            textBox18.Size = size
            Me.txtSubTotal.TabIndex = 0
            Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.Label31.AutoSize = True
            Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label21 As System.Windows.Forms.Label = Me.Label31
            location = New System.Drawing.Point(13, 9)
            label21.Location = location
            Me.Label31.Name = "Label31"
            Dim label22 As System.Windows.Forms.Label = Me.Label31
            size = New System.Drawing.Size(59, 13)
            label22.Size = size
            Me.Label31.TabIndex = 84
            Me.Label31.Text = "Sub Total :"
            Dim richTextBox As System.Windows.Forms.RichTextBox = Me.txtTerms
            location = New System.Drawing.Point(528, 288)
            richTextBox.Location = location
            Me.txtTerms.Name = "txtTerms"
            Me.txtTerms.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
            Dim richTextBox2 As System.Windows.Forms.RichTextBox = Me.txtTerms
            size = New System.Drawing.Size(455, 163)
            richTextBox2.Size = size
            Me.txtTerms.TabIndex = 310
            Me.txtTerms.Text = ""
            Me.Label12.AutoSize = True
            Dim label23 As System.Windows.Forms.Label = Me.Label12
            location = New System.Drawing.Point(525, 272)
            label23.Location = location
            Me.Label12.Name = "Label12"
            Dim label24 As System.Windows.Forms.Label = Me.Label12
            size = New System.Drawing.Size(115, 13)
            label24.Size = size
            Me.Label12.TabIndex = 309
            Me.Label12.Text = "Terms and Conditions :"
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
            Me.DataGridView1.Columns.AddRange(Me.Column1, Me.Column3, Me.Column4, Me.Column5, Me.Column6)
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
            location = New System.Drawing.Point(9, 359)
            dataGridView.Location = location
            Me.DataGridView1.Name = "DataGridView1"
            Me.DataGridView1.[ReadOnly] = True
            Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White
            dataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Moccasin
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4
            Me.DataGridView1.RowHeadersWidth = 25
            Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White
            dataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Moccasin
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
            Me.DataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5
            Me.DataGridView1.RowTemplate.Height = 18
            Me.DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Dim dataGridView2 As System.Windows.Forms.DataGridView = Me.DataGridView1
            size = New System.Drawing.Size(513, 257)
            dataGridView2.Size = size
            Me.DataGridView1.TabIndex = 5
            Me.Column1.HeaderText = "PID"
            Me.Column1.Name = "Column1"
            Me.Column1.[ReadOnly] = True
            Me.Column1.Visible = False
            Me.Column3.HeaderText = "Product Name"
            Me.Column3.Name = "Column3"
            Me.Column3.[ReadOnly] = True
            Me.Column3.Width = 210
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
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.Column6.DefaultCellStyle = dataGridViewCellStyle8
            Me.Column6.HeaderText = "Total Amount"
            Me.Column6.Name = "Column6"
            Me.Column6.[ReadOnly] = True
            Me.GroupBox2.Controls.Add(Me.Button1)
            Me.GroupBox2.Controls.Add(Me.btnClear)
            Me.GroupBox2.Controls.Add(Me.lblUnit)
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
            Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim groupBox5 As System.Windows.Forms.GroupBox = Me.GroupBox2
            location = New System.Drawing.Point(11, 205)
            groupBox5.Location = location
            Me.GroupBox2.Name = "GroupBox2"
            Dim groupBox6 As System.Windows.Forms.GroupBox = Me.GroupBox2
            size = New System.Drawing.Size(511, 148)
            groupBox6.Size = size
            Me.GroupBox2.TabIndex = 2
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Product Info"
            Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.Button1.Image = RestaurantPOS14.My.Resources.Resources._1__2_
            Dim button15 As System.Windows.Forms.Button = Me.Button1
            location = New System.Drawing.Point(365, 33)
            button15.Location = location
            Me.Button1.Name = "Button1"
            Dim button16 As System.Windows.Forms.Button = Me.Button1
            size = New System.Drawing.Size(31, 23)
            button16.Size = size
            Me.Button1.TabIndex = 352
            Me.Button1.UseVisualStyleBackColor = True
            Me.btnClear.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnClear.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnClear.ForeColor = System.Drawing.Color.White
            Me.btnClear.Image = CType(componentResourceManager.GetObject("btnClear.Image"), System.Drawing.Image)
            Me.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button17 As System.Windows.Forms.Button = Me.btnClear
            location = New System.Drawing.Point(406, 27)
            button17.Location = location
            Me.btnClear.Name = "btnClear"
            Dim button18 As System.Windows.Forms.Button = Me.btnClear
            size = New System.Drawing.Size(90, 34)
            button18.Size = size
            Me.btnClear.TabIndex = 351
            Me.btnClear.Text = "&Clear"
            Me.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnClear.UseVisualStyleBackColor = False
            Me.lblUnit.AutoSize = True
            Dim label25 As System.Windows.Forms.Label = Me.lblUnit
            location = New System.Drawing.Point(187, 66)
            label25.Location = location
            Me.lblUnit.Name = "lblUnit"
            Dim label26 As System.Windows.Forms.Label = Me.lblUnit
            size = New System.Drawing.Size(28, 13)
            label26.Size = size
            Me.lblUnit.TabIndex = 322
            Me.lblUnit.Text = "Unit"
            Me.lblUnit.Visible = False
            Me.btnRemove.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.btnRemove.Enabled = False
            Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnRemove.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnRemove.ForeColor = System.Drawing.Color.White
            Me.btnRemove.Image = CType(componentResourceManager.GetObject("btnRemove.Image"), System.Drawing.Image)
            Me.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button19 As System.Windows.Forms.Button = Me.btnRemove
            location = New System.Drawing.Point(406, 102)
            button19.Location = location
            Me.btnRemove.Name = "btnRemove"
            Dim button20 As System.Windows.Forms.Button = Me.btnRemove
            size = New System.Drawing.Size(90, 34)
            button20.Size = size
            Me.btnRemove.TabIndex = 6
            Me.btnRemove.Text = "&Remove"
            Me.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnRemove.UseVisualStyleBackColor = False
            Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnAdd.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnAdd.ForeColor = System.Drawing.Color.White
            Me.btnAdd.Image = CType(componentResourceManager.GetObject("btnAdd.Image"), System.Drawing.Image)
            Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button21 As System.Windows.Forms.Button = Me.btnAdd
            location = New System.Drawing.Point(406, 64)
            button21.Location = location
            Me.btnAdd.Name = "btnAdd"
            Dim button22 As System.Windows.Forms.Button = Me.btnAdd
            size = New System.Drawing.Size(90, 34)
            button22.Size = size
            Me.btnAdd.TabIndex = 5
            Me.btnAdd.Text = "&Add"
            Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnAdd.UseVisualStyleBackColor = False
            Me.cmbProductName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
            Me.cmbProductName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
            Me.cmbProductName.FormattingEnabled = True
            Dim comboBox As System.Windows.Forms.ComboBox = Me.cmbProductName
            location = New System.Drawing.Point(111, 34)
            comboBox.Location = location
            Me.cmbProductName.Name = "cmbProductName"
            Dim comboBox2 As System.Windows.Forms.ComboBox = Me.cmbProductName
            size = New System.Drawing.Size(249, 21)
            comboBox2.Size = size
            Me.cmbProductName.TabIndex = 0
            Me.txtTotalAmount.BackColor = System.Drawing.SystemColors.Control
            Me.txtTotalAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox19 As System.Windows.Forms.TextBox = Me.txtTotalAmount
            location = New System.Drawing.Point(111, 115)
            textBox19.Location = location
            Me.txtTotalAmount.Name = "txtTotalAmount"
            Me.txtTotalAmount.[ReadOnly] = True
            Dim textBox20 As System.Windows.Forms.TextBox = Me.txtTotalAmount
            size = New System.Drawing.Size(102, 21)
            textBox20.Size = size
            Me.txtTotalAmount.TabIndex = 4
            Me.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.txtPricePerQty.BackColor = System.Drawing.SystemColors.ButtonHighlight
            Me.txtPricePerQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox21 As System.Windows.Forms.TextBox = Me.txtPricePerQty
            location = New System.Drawing.Point(111, 88)
            textBox21.Location = location
            Me.txtPricePerQty.Name = "txtPricePerQty"
            Dim textBox22 As System.Windows.Forms.TextBox = Me.txtPricePerQty
            size = New System.Drawing.Size(70, 21)
            textBox22.Size = size
            Me.txtPricePerQty.TabIndex = 3
            Me.txtPricePerQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.txtQty.BackColor = System.Drawing.SystemColors.ButtonHighlight
            Me.txtQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox23 As System.Windows.Forms.TextBox = Me.txtQty
            location = New System.Drawing.Point(111, 61)
            textBox23.Location = location
            Me.txtQty.Name = "txtQty"
            Dim textBox24 As System.Windows.Forms.TextBox = Me.txtQty
            size = New System.Drawing.Size(70, 21)
            textBox24.Size = size
            Me.txtQty.TabIndex = 2
            Me.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.Label9.AutoSize = True
            Dim label27 As System.Windows.Forms.Label = Me.Label9
            location = New System.Drawing.Point(24, 115)
            label27.Location = location
            Me.Label9.Name = "Label9"
            Dim label28 As System.Windows.Forms.Label = Me.Label9
            size = New System.Drawing.Size(81, 13)
            label28.Size = size
            Me.Label9.TabIndex = 29
            Me.Label9.Text = "Total Amount :"
            Me.Label6.AutoSize = True
            Dim label29 As System.Windows.Forms.Label = Me.Label6
            location = New System.Drawing.Point(24, 88)
            label29.Location = location
            Me.Label6.Name = "Label6"
            Dim label30 As System.Windows.Forms.Label = Me.Label6
            size = New System.Drawing.Size(80, 13)
            label30.Size = size
            Me.Label6.TabIndex = 28
            Me.Label6.Text = "Price Per Unit :"
            Me.Label4.AutoSize = True
            Dim label31 As System.Windows.Forms.Label = Me.Label4
            location = New System.Drawing.Point(24, 61)
            label31.Location = location
            Me.Label4.Name = "Label4"
            Dim label32 As System.Windows.Forms.Label = Me.Label4
            size = New System.Drawing.Size(56, 13)
            label32.Size = size
            Me.Label4.TabIndex = 27
            Me.Label4.Text = "Quantity :"
            Me.Label8.AutoSize = True
            Dim label33 As System.Windows.Forms.Label = Me.Label8
            location = New System.Drawing.Point(24, 34)
            label33.Location = location
            Me.Label8.Name = "Label8"
            Dim label34 As System.Windows.Forms.Label = Me.Label8
            size = New System.Drawing.Size(85, 13)
            label34.Size = size
            Me.Label8.TabIndex = 22
            Me.Label8.Text = "Product Name :"
            Me.GroupBox1.Controls.Add(Me.Label13)
            Me.GroupBox1.Controls.Add(Me.cmbTaxType)
            Me.GroupBox1.Controls.Add(Me.dtpDate)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.txtPONo)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim groupBox7 As System.Windows.Forms.GroupBox = Me.GroupBox1
            location = New System.Drawing.Point(9, 3)
            groupBox7.Location = location
            Me.GroupBox1.Name = "GroupBox1"
            Dim groupBox8 As System.Windows.Forms.GroupBox = Me.GroupBox1
            size = New System.Drawing.Size(242, 119)
            groupBox8.Size = size
            Me.GroupBox1.TabIndex = 0
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Purchase Order Info"
            Me.Label13.AutoSize = True
            Dim label35 As System.Windows.Forms.Label = Me.Label13
            location = New System.Drawing.Point(11, 81)
            label35.Location = location
            Me.Label13.Name = "Label13"
            Dim label36 As System.Windows.Forms.Label = Me.Label13
            size = New System.Drawing.Size(57, 13)
            label36.Size = size
            Me.Label13.TabIndex = 7
            Me.Label13.Text = "Tax Type :"
            Me.cmbTaxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbTaxType.FormattingEnabled = True
            Me.cmbTaxType.Items.AddRange(New Object(1) {"Inclusive", "Exclusive"})
            Dim comboBox3 As System.Windows.Forms.ComboBox = Me.cmbTaxType
            location = New System.Drawing.Point(109, 81)
            comboBox3.Location = location
            Me.cmbTaxType.Name = "cmbTaxType"
            Dim comboBox4 As System.Windows.Forms.ComboBox = Me.cmbTaxType
            size = New System.Drawing.Size(127, 21)
            comboBox4.Size = size
            Me.cmbTaxType.TabIndex = 6
            Me.dtpDate.CustomFormat = "dd/MM/yyyy"
            Me.dtpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Dim dateTimePicker As System.Windows.Forms.DateTimePicker = Me.dtpDate
            location = New System.Drawing.Point(109, 52)
            dateTimePicker.Location = location
            Me.dtpDate.Name = "dtpDate"
            Dim dateTimePicker2 As System.Windows.Forms.DateTimePicker = Me.dtpDate
            size = New System.Drawing.Size(124, 21)
            dateTimePicker2.Size = size
            Me.dtpDate.TabIndex = 1
            Me.Label3.AutoSize = True
            Dim label37 As System.Windows.Forms.Label = Me.Label3
            location = New System.Drawing.Point(11, 26)
            label37.Location = location
            Me.Label3.Name = "Label3"
            Dim label38 As System.Windows.Forms.Label = Me.Label3
            size = New System.Drawing.Size(48, 13)
            label38.Size = size
            Me.Label3.TabIndex = 0
            Me.Label3.Text = "PO No. :"
            Me.txtPONo.BackColor = System.Drawing.Color.White
            Me.txtPONo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox25 As System.Windows.Forms.TextBox = Me.txtPONo
            location = New System.Drawing.Point(109, 26)
            textBox25.Location = location
            Me.txtPONo.Name = "txtPONo"
            Dim textBox26 As System.Windows.Forms.TextBox = Me.txtPONo
            size = New System.Drawing.Size(124, 21)
            textBox26.Size = size
            Me.txtPONo.TabIndex = 0
            Me.Label2.AutoSize = True
            Dim label39 As System.Windows.Forms.Label = Me.Label2
            location = New System.Drawing.Point(11, 52)
            label39.Location = location
            Me.Label2.Name = "Label2"
            Dim label40 As System.Windows.Forms.Label = Me.Label2
            size = New System.Drawing.Size(54, 13)
            label40.Size = size
            Me.Label2.TabIndex = 5
            Me.Label2.Text = "PO Date :"
            Me.Panel2.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Panel2.Controls.Add(Me.txtEmailID)
            Me.Panel2.Controls.Add(Me.txtProductID)
            Me.Panel2.Controls.Add(Me.lblUserType)
            Me.Panel2.Controls.Add(Me.lblSet)
            Me.Panel2.Controls.Add(Me.lblUser)
            Me.Panel2.Controls.Add(Me.txtSup_ID)
            Me.Panel2.Controls.Add(Me.txtPO_ID)
            Me.Panel2.Controls.Add(Me.Label1)
            Dim panel5 As System.Windows.Forms.Panel = Me.Panel2
            location = New System.Drawing.Point(-1, 1)
            panel5.Location = location
            Me.Panel2.Name = "Panel2"
            Dim panel6 As System.Windows.Forms.Panel = Me.Panel2
            size = New System.Drawing.Size(946, 50)
            panel6.Size = size
            Me.Panel2.TabIndex = 0
            Dim textBox27 As System.Windows.Forms.TextBox = Me.txtEmailID
            location = New System.Drawing.Point(190, 3)
            textBox27.Location = location
            Me.txtEmailID.Name = "txtEmailID"
            Dim textBox28 As System.Windows.Forms.TextBox = Me.txtEmailID
            size = New System.Drawing.Size(35, 20)
            textBox28.Size = size
            Me.txtEmailID.TabIndex = 313
            Me.txtEmailID.Visible = False
            Dim textBox29 As System.Windows.Forms.TextBox = Me.txtProductID
            location = New System.Drawing.Point(101, 6)
            textBox29.Location = location
            Me.txtProductID.Name = "txtProductID"
            Dim textBox30 As System.Windows.Forms.TextBox = Me.txtProductID
            size = New System.Drawing.Size(35, 20)
            textBox30.Size = size
            Me.txtProductID.TabIndex = 37
            Me.txtProductID.Visible = False
            Me.lblUserType.AutoSize = True
            Dim label41 As System.Windows.Forms.Label = Me.lblUserType
            location = New System.Drawing.Point(142, 16)
            label41.Location = location
            Me.lblUserType.Name = "lblUserType"
            Dim label42 As System.Windows.Forms.Label = Me.lblUserType
            size = New System.Drawing.Size(56, 13)
            label42.Size = size
            Me.lblUserType.TabIndex = 312
            Me.lblUserType.Text = "User Type"
            Me.lblUserType.Visible = False
            Me.lblSet.AutoSize = True
            Dim label43 As System.Windows.Forms.Label = Me.lblSet
            location = New System.Drawing.Point(187, 30)
            label43.Location = location
            Me.lblSet.Name = "lblSet"
            Dim label44 As System.Windows.Forms.Label = Me.lblSet
            size = New System.Drawing.Size(23, 13)
            label44.Size = size
            Me.lblSet.TabIndex = 311
            Me.lblSet.Text = "Set"
            Me.lblSet.Visible = False
            Me.lblUser.AutoSize = True
            Dim label45 As System.Windows.Forms.Label = Me.lblUser
            location = New System.Drawing.Point(142, 29)
            label45.Location = location
            Me.lblUser.Name = "lblUser"
            Dim label46 As System.Windows.Forms.Label = Me.lblUser
            size = New System.Drawing.Size(29, 13)
            label46.Size = size
            Me.lblUser.TabIndex = 6
            Me.lblUser.Text = "User"
            Me.lblUser.Visible = False
            Dim textBox31 As System.Windows.Forms.TextBox = Me.txtSup_ID
            location = New System.Drawing.Point(60, 6)
            textBox31.Location = location
            Me.txtSup_ID.Name = "txtSup_ID"
            Dim textBox32 As System.Windows.Forms.TextBox = Me.txtSup_ID
            size = New System.Drawing.Size(35, 20)
            textBox32.Size = size
            Me.txtSup_ID.TabIndex = 2
            Me.txtSup_ID.Visible = False
            Dim textBox33 As System.Windows.Forms.TextBox = Me.txtPO_ID
            location = New System.Drawing.Point(14, 6)
            textBox33.Location = location
            Me.txtPO_ID.Name = "txtPO_ID"
            Dim textBox34 As System.Windows.Forms.TextBox = Me.txtPO_ID
            size = New System.Drawing.Size(35, 20)
            textBox34.Size = size
            Me.txtPO_ID.TabIndex = 1
            Me.txtPO_ID.Visible = False
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label1.ForeColor = System.Drawing.Color.White
            Dim label47 As System.Windows.Forms.Label = Me.Label1
            location = New System.Drawing.Point(371, 10)
            label47.Location = location
            Me.Label1.Name = "Label1"
            Dim label48 As System.Windows.Forms.Label = Me.Label1
            size = New System.Drawing.Size(217, 30)
            label48.Size = size
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Purchase Order Entry"
            Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
            Me.btnCancel.BackColor = System.Drawing.Color.Transparent
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.FlatAppearance.BorderSize = 0
            Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnCancel.Image = CType(componentResourceManager.GetObject("btnCancel.Image"), System.Drawing.Image)
            Dim button23 As System.Windows.Forms.Button = Me.btnCancel
            location = New System.Drawing.Point(951, 1)
            button23.Location = location
            Me.btnCancel.Name = "btnCancel"
            Dim button24 As System.Windows.Forms.Button = Me.btnCancel
            size = New System.Drawing.Size(52, 50)
            button24.Size = size
            Me.btnCancel.TabIndex = 399
            Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnCancel.UseVisualStyleBackColor = False
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            size = New System.Drawing.Size(1004, 677)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.btnCancel)
            MyBase.Controls.Add(Me.Panel1)
            MyBase.Controls.Add(Me.Panel2)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MaximizeBox = False
            MyBase.MinimizeBox = False
            MyBase.Name = "frmPurchaseOrder"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.GroupBox3.ResumeLayout(False)
            Me.gbPartyInfo.ResumeLayout(False)
            Me.gbPartyInfo.PerformLayout()
            Me.pnlCalc.ResumeLayout(False)
            Me.pnlCalc.PerformLayout()
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
