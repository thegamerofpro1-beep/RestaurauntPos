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
    Public Class frmStockTransfer
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel1")>
        Private _Panel1 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label3")>
        Private _Label3 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnDelete")>
        Private _btnDelete As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnClose")>
        Private _btnClose As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnSave")>
        Private _btnSave As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnNew")>
        Private _btnNew As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("dgw")>
        Private _dgw As System.Windows.Forms.DataGridView

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel2")>
        Private _Panel2 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label1")>
        Private _Label1 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label4")>
        Private _Label4 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label2")>
        Private _Label2 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblUser")>
        Private _lblUser As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label6")>
        Private _Label6 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox3")>
        Private _GroupBox3 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox2")>
        Private _GroupBox2 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblSet")>
        Private _lblSet As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtTransferQty")>
        Private _txtTransferQty As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("cmbKitchen")>
        Private _cmbKitchen As System.Windows.Forms.ComboBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("dtpDate")>
        Private _dtpDate As System.Windows.Forms.DateTimePicker

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label5")>
        Private _Label5 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox4")>
        Private _GroupBox4 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtID")>
        Private _txtID As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label7")>
        Private _Label7 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label8")>
        Private _Label8 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtAvailableQty")>
        Private _txtAvailableQty As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnRemove")>
        Private _btnRemove As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnAdd")>
        Private _btnAdd As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DataGridView1")>
        Private _DataGridView1 As System.Windows.Forms.DataGridView

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label9")>
        Private _Label9 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtExpiryDate")>
        Private _txtExpiryDate As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtProductName")>
        Private _txtProductName As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtWarehouse")>
        Private _txtWarehouse As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel3")>
        Private _Panel3 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtSearchByProductName")>
        Private _txtSearchByProductName As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label10")>
        Private _Label10 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnPrint")>
        Private _btnPrint As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtProductID")>
        Private _txtProductID As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column1")>
        Private _Column1 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column2")>
        Private _Column2 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column3")>
        Private _Column3 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column6")>
        Private _Column6 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column5")>
        Private _Column5 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DataGridViewTextBoxColumn1")>
        Private _DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DataGridViewTextBoxColumn2")>
        Private _DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DataGridViewTextBoxColumn3")>
        Private _DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column4")>
        Private _Column4 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DataGridViewTextBoxColumn4")>
        Private _DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DataGridViewTextBoxColumn5")>
        Private _DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblUnit")>
        Private _lblUnit As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblQty")>
        Private _lblQty As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnGetData")>
        Private _btnGetData As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Timer1")>
        Private _Timer1 As System.Windows.Forms.Timer

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Button1")>
        Private _Button1 As System.Windows.Forms.Button

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

        Friend Overridable Property dgw As System.Windows.Forms.DataGridView
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._dgw
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridView)
                Dim value2 As System.Windows.Forms.DataGridViewRowPostPaintEventHandler = AddressOf Me.dgw_RowPostPaint
                Dim value3 As System.Windows.Forms.MouseEventHandler = AddressOf Me.dgw_MouseClick
                If Me._dgw IsNot Nothing Then
                    RemoveHandler Me._dgw.RowPostPaint, value2
                    RemoveHandler Me._dgw.MouseClick, value3
                End If

                Me._dgw = value
                If Me._dgw IsNot Nothing Then
                    AddHandler Me._dgw.RowPostPaint, value2
                    AddHandler Me._dgw.MouseClick, value3
                End If
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

        Friend Overridable Property txtTransferQty As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtTransferQty
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.Windows.Forms.KeyPressEventHandler = AddressOf Me.txtTransferQty_KeyPress
                If Me._txtTransferQty IsNot Nothing Then
                    RemoveHandler Me._txtTransferQty.KeyPress, value2
                End If

                Me._txtTransferQty = value
                If Me._txtTransferQty IsNot Nothing Then
                    AddHandler Me._txtTransferQty.KeyPress, value2
                End If
            End Set
        End Property

        Friend Overridable Property cmbKitchen As System.Windows.Forms.ComboBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._cmbKitchen
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ComboBox)
                Me._cmbKitchen = value
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

        Friend Overridable Property txtID As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtID
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtID = value
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

        Friend Overridable Property txtAvailableQty As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtAvailableQty
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtAvailableQty = value
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
                Dim value2 As System.EventHandler = AddressOf Me.btnRemoveFromGridOS_Click
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
                Dim value2 As System.EventHandler = AddressOf Me.btnAddOS_Click
                If Me._btnAdd IsNot Nothing Then
                    RemoveHandler Me._btnAdd.Click, value2
                End If

                Me._btnAdd = value
                If Me._btnAdd IsNot Nothing Then
                    AddHandler Me._btnAdd.Click, value2
                End If
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

        Friend Overridable Property txtExpiryDate As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtExpiryDate
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtExpiryDate = value
            End Set
        End Property

        Friend Overridable Property txtProductName As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtProductName
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtProductName = value
            End Set
        End Property

        Friend Overridable Property txtWarehouse As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtWarehouse
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtWarehouse = value
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

        Friend Overridable Property txtSearchByProductName As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtSearchByProductName
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.EventHandler = AddressOf Me.txtSearchByProductName_TextChanged
                If Me._txtSearchByProductName IsNot Nothing Then
                    RemoveHandler Me._txtSearchByProductName.TextChanged, value2
                End If

                Me._txtSearchByProductName = value
                If Me._txtSearchByProductName IsNot Nothing Then
                    AddHandler Me._txtSearchByProductName.TextChanged, value2
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

        Friend Overridable Property DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._DataGridViewTextBoxColumn1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._DataGridViewTextBoxColumn1 = value
            End Set
        End Property

        Friend Overridable Property DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._DataGridViewTextBoxColumn2
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._DataGridViewTextBoxColumn2 = value
            End Set
        End Property

        Friend Overridable Property DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._DataGridViewTextBoxColumn3
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._DataGridViewTextBoxColumn3 = value
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

        Friend Overridable Property DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._DataGridViewTextBoxColumn4
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._DataGridViewTextBoxColumn4 = value
            End Set
        End Property

        Friend Overridable Property DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._DataGridViewTextBoxColumn5
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._DataGridViewTextBoxColumn5 = value
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

        Friend Overridable Property lblQty As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._lblQty
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._lblQty = value
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
            AddHandler MyBase.Load, AddressOf Me.frmStore_Load
            Call RestaurantPOS14.frmStockTransfer.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmStockTransfer.__ENCList
                If RestaurantPOS14.frmStockTransfer.__ENCList.Count = RestaurantPOS14.frmStockTransfer.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmStockTransfer.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmStockTransfer.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmStockTransfer.__ENCList(num) = RestaurantPOS14.frmStockTransfer.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmStockTransfer.__ENCList.RemoveRange(num, RestaurantPOS14.frmStockTransfer.__ENCList.Count - num)
                    RestaurantPOS14.frmStockTransfer.__ENCList.Capacity = RestaurantPOS14.frmStockTransfer.__ENCList.Count
                End If

                Call RestaurantPOS14.frmStockTransfer.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Public Sub FillStore()
            Try
                Dim sqlConnection As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                sqlConnection.Open()
                RestaurantPOS14.ModClasses.adp = New System.Data.SqlClient.SqlDataAdapter()
                RestaurantPOS14.ModClasses.adp.SelectCommand = New System.Data.SqlClient.SqlCommand("SELECT distinct RTRIM(KitchenName) FROM Kitchen", sqlConnection)
                RestaurantPOS14.ModClasses.ds = New System.Data.DataSet("ds")
                RestaurantPOS14.ModClasses.adp.Fill(RestaurantPOS14.ModClasses.ds)
                RestaurantPOS14.ModClasses.dtable = RestaurantPOS14.ModClasses.ds.Tables(0)
                Me.cmbKitchen.Items.Clear()
                For Each dataRow As System.Data.DataRow In RestaurantPOS14.ModClasses.dtable.Rows
                    Me.cmbKitchen.Items.Add(dataRow(CInt((0))).ToString())
                Next
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub Reset()
            Me.dtpDate.Value = Microsoft.VisualBasic.DateAndTime.Today
            Me.txtAvailableQty.Text = ""
            Me.txtExpiryDate.Text = ""
            Me.txtProductName.Text = ""
            Me.txtSearchByProductName.Text = ""
            Me.cmbKitchen.SelectedIndex = -1
            Me.txtTransferQty.Text = ""
            Me.txtWarehouse.Text = ""
            Me.dgw.Rows.Clear()
            If RestaurantPOS14.ModFunc.IsViewAllowed(Me.lblUser.Text, "Stock Transfer") Then
                Me.btnGetData.Enabled = True
            Else
                Me.btnGetData.Enabled = False
            End If

            If RestaurantPOS14.ModFunc.IsSaveAllowed(Me.lblUser.Text, "Stock Transfer") Then
                Me.btnSave.Enabled = True
            Else
                Me.btnSave.Enabled = False
            End If

            Me.btnDelete.Enabled = False
            Me.btnPrint.Enabled = False
            Me.btnRemove.Enabled = False
            Me.btnAdd.Enabled = True
            Me.lblUnit.Visible = False
            Me.lblQty.Text = ""
            Me.lblSet.Text = ""
            Me.Getdata()
            Me.auto()
        End Sub

        Private Sub btnClose_Click(sender As Object, e As System.EventArgs)
            MyBase.Close()
        End Sub

        Private Function GenerateID() As String
            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
            Dim text As String = "0000"
            Try
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT TOP 1 ST_ID FROM StockTransfer ORDER BY ST_ID DESC", RestaurantPOS14.ModClasses.con)
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
                Me.txtID.Text = Me.GenerateID()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnSave_Click(sender As Object, e As System.EventArgs)
            Try
                If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.cmbKitchen.Text)) = 0 Then
                    Call System.Windows.Forms.MessageBox.Show("Please select kitchen/section", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Me.cmbKitchen.Focus()
                    Return
                End If

                If Me.dgw.Rows.Count = 0 Then
                    Call System.Windows.Forms.MessageBox.Show("sorry no product added to grid", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Return
                End If

                For Each dataGridViewRow As System.Windows.Forms.DataGridViewRow In CType(Me.dgw.Rows, System.Collections.IEnumerable)
                    Dim sqlConnection As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    sqlConnection.Open()
                    Dim sqlCommand As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT qty from Temp_Stock where Warehouse=@d1 and ProductID=@d2 and ExpiryDate=@d3", sqlConnection)
                    sqlCommand.Parameters.AddWithValue("@d1", System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((0))).Value))
                    sqlCommand.Parameters.AddWithValue("@d2", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((1))).Value)))
                    sqlCommand.Parameters.AddWithValue("@d3", System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((3))).Value))
                    Dim sqlDataAdapter As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(sqlCommand)
                    Dim dataSet As System.Data.DataSet = New System.Data.DataSet()
                    sqlDataAdapter.Fill(dataSet)
                    If dataSet.Tables(CInt((0))).Rows.Count > 0 Then
                        Me.lblQty.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(dataSet.Tables(CInt((0))).Rows(0)("Qty"))
                        If Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((4))).Value)) > Microsoft.VisualBasic.Conversion.Val(Me.lblQty.Text) Then
                            Call System.Windows.Forms.MessageBox.Show(Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject("added qty. to grid are more than" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "available qty. of Product name '", dataGridViewRow.Cells(CInt((2))).Value), "' from Warehouse '"), dataGridViewRow.Cells(CInt((0))).Value), "'")), "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                            Return
                        End If
                    End If

                    sqlConnection.Close()
                Next

                For Each dataGridViewRow2 As System.Windows.Forms.DataGridViewRow In CType(Me.dgw.Rows, System.Collections.IEnumerable)
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select WareHouse,ProductID,ExpiryDate from temp_Stock where Warehouse=@d1 and ProductID=@d2 and ExpiryDate=@d3")
                    RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(CInt((0))).Value))
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(CInt((1))).Value)))
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(CInt((3))).Value))
                    RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                    If RestaurantPOS14.ModClasses.rdr.Read() Then
                        RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                        RestaurantPOS14.ModClasses.con.Open()
                        RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Update Temp_Stock set Qty=Qty - " & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(CInt((4))).Value))) & " where Warehouse=@d1 and ProductID=@d2 and ExpiryDate=@d3")
                        RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(CInt((0))).Value))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(CInt((1))).Value)))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(CInt((3))).Value))
                        RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                        RestaurantPOS14.ModClasses.con.Close()
                    End If
                Next

                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("insert into StockTransfer(ST_ID, Date,Kitchen) VALUES (@d1,@d2,@d3)")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.Conversion.Val(Me.txtID.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Me.dtpDate.Value.[Date])
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Me.cmbKitchen.Text)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("insert into StockTransfer_Join(StockTransferID,Warehouse,ProductID,ExpiryDate,Qty) VALUES (" & RestaurantPOS14.Security.SqlInput.RequireInteger(Me.txtID.Text, "Record ID") & ",@d1,@d2,@d3,@d4)")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Prepare()
                For Each dataGridViewRow3 As System.Windows.Forms.DataGridViewRow In CType(Me.dgw.Rows, System.Collections.IEnumerable)
                    If Not dataGridViewRow3.IsNewRow Then
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow3.Cells(CInt((0))).Value))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow3.Cells(CInt((1))).Value)))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow3.Cells(CInt((3))).Value))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow3.Cells(CInt((4))).Value)))
                        RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                        RestaurantPOS14.ModClasses.cmd.Parameters.Clear()
                    End If
                Next

                For Each dataGridViewRow4 As System.Windows.Forms.DataGridViewRow In CType(Me.dgw.Rows, System.Collections.IEnumerable)
                    If Not dataGridViewRow4.IsNewRow Then
                        RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                        RestaurantPOS14.ModClasses.con.Open()
                        RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select ProductID from Temp_Stock_RM where ProductID=@d1")
                        RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells(CInt((1))).Value)))
                        RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                        If RestaurantPOS14.ModClasses.rdr.Read() Then
                            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                            RestaurantPOS14.ModClasses.con.Open()
                            RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand(Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject("Update Temp_Stock_RM set Qty = Qty + ", dataGridViewRow4.Cells(CInt((4))).Value), " where ProductID=@d1")))
                            RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells(CInt((1))).Value)))
                            RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                            RestaurantPOS14.ModClasses.con.Close()
                        Else
                            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                            RestaurantPOS14.ModClasses.con.Open()
                            RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("insert into Temp_Stock_RM(ProductID,Qty) VALUES (@d1,@d2)")
                            RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells(CInt((1))).Value)))
                            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells(CInt((4))).Value)))
                            RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                            RestaurantPOS14.ModClasses.con.Close()
                        End If
                    End If
                Next

                RestaurantPOS14.ModFunc.LogFunc(Me.lblUser.Text, "added the new Stock Transfer having Transfer ID '" & Me.txtID.Text & "'")
                Call System.Windows.Forms.MessageBox.Show("Successfully saved", "Stock Transfer", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                Me.btnSave.Enabled = False
                RestaurantPOS14.ModClasses.con.Close()
                Me.Getdata()
                Me.btnPrint.Enabled = True
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

        Private Sub DeleteRecord()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("delete from StockTransfer where ST_ID=@d1")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.Conversion.Val(Me.txtID.Text))
                If RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery() > 0 Then
                    For Each dataGridViewRow As System.Windows.Forms.DataGridViewRow In CType(Me.dgw.Rows, System.Collections.IEnumerable)
                        RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                        RestaurantPOS14.ModClasses.con.Open()
                        RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select WareHouse,ProductID,ExpiryDate from temp_Stock where Warehouse=@d1 and ProductID=@d2 and ExpiryDate=@d3")
                        RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((0))).Value))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((1))).Value)))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((3))).Value))
                        RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                        If RestaurantPOS14.ModClasses.rdr.Read() Then
                            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                            RestaurantPOS14.ModClasses.con.Open()
                            RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Update Temp_Stock set Qty=Qty + " & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((4))).Value))) & " where Warehouse=@d1 and ProductID=@d2 and ExpiryDate=@d3")
                            RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((0))).Value))
                            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((1))).Value)))
                            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((3))).Value))
                            RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                            RestaurantPOS14.ModClasses.con.Close()
                        End If
                    Next

                    For Each dataGridViewRow2 As System.Windows.Forms.DataGridViewRow In CType(Me.dgw.Rows, System.Collections.IEnumerable)
                        If Not dataGridViewRow2.IsNewRow Then
                            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                            RestaurantPOS14.ModClasses.con.Open()
                            RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand(Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject("Update Temp_Stock_RM set Qty = Qty - ", dataGridViewRow2.Cells(CInt((4))).Value), " where ProductID=@d1")))
                            RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(CInt((1))).Value)))
                            RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                            RestaurantPOS14.ModClasses.con.Close()
                        End If
                    Next

                    RestaurantPOS14.ModFunc.LogFunc(Me.lblUser.Text, "Deleted the Stock Transfer having Transfer ID '" & Me.txtID.Text & "'")
                    Call System.Windows.Forms.MessageBox.Show("Successfully deleted", "Record", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    Me.Getdata()
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

        Public Sub Getdata()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT RTRIM(WareHouse),RTRIM(ProductID),RTRIM(ProductName),RTRIM(Unit),RTRIM(ExpiryDate),Qty from Temp_Stock,Product where Temp_Stock.ProductID=Product.PID and Qty > 0 order by ProductName", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                Me.DataGridView1.Rows.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Me.DataGridView1.Rows.Add(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(0)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(1)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(2)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(3)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(4)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(5)))
                End While

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnNew_Click(sender As Object, e As System.EventArgs)
            Me.Reset()
        End Sub

        Private Sub dgw_RowPostPaint(sender As Object, e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs)
            Dim text As String =(e.RowIndex + 1).ToString()
            Dim sizeF As System.Drawing.SizeF = e.Graphics.MeasureString(text, MyBase.Font)
            If Me.dgw.RowHeadersWidth < System.Convert.ToInt32(sizeF.Width + 20F) Then
                Me.dgw.RowHeadersWidth = System.Convert.ToInt32(sizeF.Width + 20F)
            End If

            Dim controlText As System.Drawing.Brush = System.Drawing.SystemBrushes.ControlText
            e.Graphics.DrawString(text, MyBase.Font, controlText, e.RowBounds.Location.X + 15, CSng(e.RowBounds.Location.Y) + (CSng(e.RowBounds.Height) - sizeF.Height) / 2F)
        End Sub

        Private Sub frmStore_Load(sender As Object, e As System.EventArgs)
            Me.Getdata()
            Me.FillStore()
        End Sub

        Private Sub DataGridView1_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs)
            Try
                If Me.DataGridView1.Rows.Count > 0 Then
                    If Me.DataGridView1.SelectedRows.Count = 0 Then Return
                    Dim dataGridViewRow As System.Windows.Forms.DataGridViewRow = Me.DataGridView1.SelectedRows(0)
                    Me.txtWarehouse.Text = dataGridViewRow.Cells(CInt((0))).Value.ToString()
                    Me.txtProductID.Text = dataGridViewRow.Cells(CInt((1))).Value.ToString()
                    Me.txtProductName.Text = dataGridViewRow.Cells(CInt((2))).Value.ToString()
                    Me.lblUnit.Visible = True
                    Me.lblUnit.Text = dataGridViewRow.Cells(CInt((3))).Value.ToString()
                    Me.txtExpiryDate.Text = dataGridViewRow.Cells(CInt((4))).Value.ToString()
                    Me.txtAvailableQty.Text = dataGridViewRow.Cells(CInt((5))).Value.ToString()
                End If
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
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

        Public Sub Clear()
            Me.txtWarehouse.Text = ""
            Me.txtProductName.Text = ""
            Me.txtProductID.Text = ""
            Me.txtExpiryDate.Text = ""
            Me.txtAvailableQty.Text = ""
            Me.txtTransferQty.Text = ""
            Me.btnRemove.Enabled = False
            Me.lblUnit.Visible = False
        End Sub

        Private Sub btnRemoveFromGridOS_Click(sender As Object, e As System.EventArgs)
            Try
                If Me.dgw.Rows.Count <= 0 Then
                    Return
                End If

                For Each dataGridViewRow As System.Windows.Forms.DataGridViewRow In Me.dgw.SelectedRows
                    Me.dgw.Rows.Remove(dataGridViewRow)
                Next

                Me.btnRemove.Enabled = False
                Me.Clear()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnAddOS_Click(sender As Object, e As System.EventArgs)
            Try
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtWarehouse.Text, "", TextCompare:=False) = 0 Then
                    Call System.Windows.Forms.MessageBox.Show("Please retrieve warehouse", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Me.txtWarehouse.Focus()
                    Return
                End If

                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtTransferQty.Text, "", TextCompare:=False) = 0 Then
                    Call System.Windows.Forms.MessageBox.Show("Please enter qty", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Me.txtTransferQty.Focus()
                    Return
                End If

                If Microsoft.VisualBasic.Conversion.Val(Me.txtTransferQty.Text) = 0.0 Then
                    Call System.Windows.Forms.MessageBox.Show("Transferred quantity must be greater than zero", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Me.txtTransferQty.Focus()
                    Return
                End If

                If Microsoft.VisualBasic.Conversion.Val(Me.txtAvailableQty.Text) < Microsoft.VisualBasic.Conversion.Val(Me.txtTransferQty.Text) Then
                    Call System.Windows.Forms.MessageBox.Show("Transferred quantity must be less than available quantity", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Me.txtTransferQty.Focus()
                    Return
                End If

                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtExpiryDate.Text, "", TextCompare:=False) <> 0 Then
                    For Each dataGridViewRow As System.Windows.Forms.DataGridViewRow In CType(Me.dgw.Rows, System.Collections.IEnumerable)
                        If Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(Me.txtWarehouse.Text, dataGridViewRow.Cells(CInt((0))).Value, TextCompare:=False), Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(Me.txtProductID.Text) = Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((1))).Value))), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(Me.txtExpiryDate.Text, dataGridViewRow.Cells(CInt((3))).Value, TextCompare:=False))) Then
                            dataGridViewRow.Cells(CInt((0))).Value = Me.txtWarehouse.Text
                            dataGridViewRow.Cells(CInt((1))).Value = Microsoft.VisualBasic.Conversion.Val(Me.txtProductID.Text)
                            dataGridViewRow.Cells(CInt((2))).Value = Me.txtProductName.Text
                            dataGridViewRow.Cells(CInt((3))).Value = Me.txtExpiryDate.Text
                            Dim dataGridViewCell As System.Windows.Forms.DataGridViewCell = dataGridViewRow.Cells(4)
                            dataGridViewCell.Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(dataGridViewCell.Value, Microsoft.VisualBasic.Conversion.Val(Me.txtTransferQty.Text))
                            Me.Clear()
                            Return
                        End If
                    Next
                End If

                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtExpiryDate.Text, "", TextCompare:=False) = 0 Then
                    For Each dataGridViewRow2 As System.Windows.Forms.DataGridViewRow In CType(Me.dgw.Rows, System.Collections.IEnumerable)
                        If Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(Me.txtWarehouse.Text, dataGridViewRow2.Cells(CInt((0))).Value, TextCompare:=False), Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(Me.txtProductID.Text) = Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(CInt((1))).Value))), Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtExpiryDate.Text, "", TextCompare:=False) = 0)) Then
                            dataGridViewRow2.Cells(CInt((0))).Value = Me.txtWarehouse.Text
                            dataGridViewRow2.Cells(CInt((1))).Value = Microsoft.VisualBasic.Conversion.Val(Me.txtProductID.Text)
                            dataGridViewRow2.Cells(CInt((2))).Value = Me.txtProductName.Text
                            dataGridViewRow2.Cells(CInt((3))).Value = Me.txtExpiryDate.Text
                            Dim dataGridViewCell2 As System.Windows.Forms.DataGridViewCell = dataGridViewRow2.Cells(4)
                            dataGridViewCell2.Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(dataGridViewCell2.Value, Microsoft.VisualBasic.Conversion.Val(Me.txtTransferQty.Text))
                            Me.Clear()
                            Return
                        End If
                    Next
                End If

                Me.dgw.Rows.Add(Me.txtWarehouse.Text, Microsoft.VisualBasic.Conversion.Val(Me.txtProductID.Text), Me.txtProductName.Text, Me.txtExpiryDate.Text, Microsoft.VisualBasic.Conversion.Val(Me.txtTransferQty.Text))
                Me.Clear()
            Catch ex As System.Exception
                Call Microsoft.VisualBasic.Interaction.MsgBox(ex.Message)
            End Try
        End Sub

        Private Sub txtSearchByProductName_TextChanged(sender As Object, e As System.EventArgs)
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT RTRIM(WareHouse),RTRIM(ProductID),RTRIM(ProductName),RTRIM(Unit),RTRIM(ExpiryDate),Qty from Temp_Stock,Product where Temp_Stock.ProductID=Product.PID and Productname like N'%" & RestaurantPOS14.Security.SqlInput.EscapeLiteral(Me.txtSearchByProductName.Text) & "%' and Qty > 0 order by ProductName", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                Me.DataGridView1.Rows.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Me.DataGridView1.Rows.Add(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(0)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(1)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(2)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(3)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(4)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(5)))
                End While

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub txtTransferQty_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
            Dim keyChar As Char = e.KeyChar
            If Char.IsControl(keyChar) Then
                Return
            End If

            If Char.IsDigit(keyChar) OrElse keyChar = "."c Then
                Dim text As String = Me.txtTransferQty.Text
                Dim selectionStart As Integer = Me.txtTransferQty.SelectionStart
                Dim selectionLength As Integer = Me.txtTransferQty.SelectionLength
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

        Private Sub btnGetData_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmStockTransferRecord.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmStockTransferRecord.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmStockTransferRecord.ShowDialog()
        End Sub

        Private Sub dgw_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs)
            If Me.dgw.Rows.Count > 0 Then
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "Not allowed", TextCompare:=False) = 0 Then
                    Me.btnRemove.Enabled = False
                Else
                    Me.btnRemove.Enabled = True
                End If
            End If
        End Sub

        Private Sub btnPrint_Click(sender As Object, e As System.EventArgs)
            Try
                MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Me.Timer1.Enabled = True
                Dim rptStockTransferInvoice2 As RestaurantPOS14.rptStockTransferInvoice = New RestaurantPOS14.rptStockTransferInvoice()
                Dim sqlCommand As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand()
                Dim sqlCommand2 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand()
                Dim sqlDataAdapter As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter()
                Dim sqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter()
                Dim dataSet As System.Data.DataSet = New System.Data.DataSet()
                sqlCommand.Connection = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                Dim sqlConnection As System.Data.SqlClient.SqlConnection = sqlCommand.Connection
                Dim connection As System.Data.SqlClient.SqlConnection = sqlConnection
                sqlCommand2.Connection = connection
                sqlCommand.CommandText = "SELECT StockTransfer.ST_ID, StockTransfer.Date, StockTransfer.Kitchen, StockTransfer_Join.STJ_ID, StockTransfer_Join.StockTransferID, StockTransfer_Join.Warehouse, StockTransfer_Join.ProductID,StockTransfer_Join.ExpiryDate, StockTransfer_Join.Qty, Product.PID, Product.ProductCode, Product.ProductName, Product.Category, Product.Description, Product.Unit, Product.Price, Product.ReorderPoint FROM StockTransfer INNER JOIN StockTransfer_Join ON StockTransfer.ST_ID = StockTransfer_Join.StockTransferID INNER JOIN Product ON StockTransfer_Join.ProductID = Product.PID where ST_ID=" & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.txtID.Text)) & " order by StockTransfer.Date"
                sqlCommand2.CommandText = "SELECT * from Hotel"
                sqlCommand.CommandType = System.Data.CommandType.Text
                sqlCommand2.CommandType = System.Data.CommandType.Text
                sqlDataAdapter.SelectCommand = sqlCommand
                sqlDataAdapter2.SelectCommand = sqlCommand2
                sqlDataAdapter.Fill(dataSet, "StockTransfer")
                sqlDataAdapter.Fill(dataSet, "StockTransfer_Join")
                sqlDataAdapter.Fill(dataSet, "Product")
                sqlDataAdapter2.Fill(dataSet, "Hotel")
                rptStockTransferInvoice2.SetDataSource(dataSet)
                RestaurantPOS14.My.MyProject.Forms.frmReport.CrystalReportViewer1.ReportSource = rptStockTransferInvoice2
                Call RestaurantPOS14.My.MyProject.Forms.frmReport.ShowDialog()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub Timer1_Tick(sender As Object, e As System.EventArgs)
            MyBase.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.Timer1.Enabled = False
        End Sub

        Private Sub Button1_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmKitchen_Section.lblUser.Text = Me.lblUser.Text
            RestaurantPOS14.My.MyProject.Forms.frmKitchen_Section.lblSet.Text = "ST"
            Call RestaurantPOS14.My.MyProject.Forms.frmKitchen_Section.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmKitchen_Section.ShowDialog()
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
            Dim dataGridViewCellStyle As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmStockTransfer))
            Dim dataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.lblQty = New System.Windows.Forms.Label()
            Me.txtProductID = New System.Windows.Forms.TextBox()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.txtSearchByProductName = New System.Windows.Forms.TextBox()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.DataGridView1 = New System.Windows.Forms.DataGridView()
            Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.txtID = New System.Windows.Forms.TextBox()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.cmbKitchen = New System.Windows.Forms.ComboBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.dtpDate = New System.Windows.Forms.DateTimePicker()
            Me.lblSet = New System.Windows.Forms.Label()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.btnGetData = New System.Windows.Forms.Button()
            Me.btnPrint = New System.Windows.Forms.Button()
            Me.btnDelete = New System.Windows.Forms.Button()
            Me.btnNew = New System.Windows.Forms.Button()
            Me.btnSave = New System.Windows.Forms.Button()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.lblUnit = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.txtExpiryDate = New System.Windows.Forms.TextBox()
            Me.txtProductName = New System.Windows.Forms.TextBox()
            Me.txtWarehouse = New System.Windows.Forms.TextBox()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.txtAvailableQty = New System.Windows.Forms.TextBox()
            Me.btnRemove = New System.Windows.Forms.Button()
            Me.btnAdd = New System.Windows.Forms.Button()
            Me.txtTransferQty = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.btnClose = New System.Windows.Forms.Button()
            Me.lblUser = New System.Windows.Forms.Label()
            Me.dgw = New System.Windows.Forms.DataGridView()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.Button1 = New System.Windows.Forms.Button()
            Me.Panel1.SuspendLayout()
            Me.Panel3.SuspendLayout()
            CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox4.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel2.SuspendLayout()
            MyBase.SuspendLayout()
            Me.Panel1.BackColor = System.Drawing.Color.White
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.lblQty)
            Me.Panel1.Controls.Add(Me.txtProductID)
            Me.Panel1.Controls.Add(Me.Panel3)
            Me.Panel1.Controls.Add(Me.DataGridView1)
            Me.Panel1.Controls.Add(Me.GroupBox4)
            Me.Panel1.Controls.Add(Me.lblSet)
            Me.Panel1.Controls.Add(Me.GroupBox3)
            Me.Panel1.Controls.Add(Me.GroupBox2)
            Me.Panel1.Controls.Add(Me.btnClose)
            Me.Panel1.Controls.Add(Me.lblUser)
            Me.Panel1.Controls.Add(Me.dgw)
            Me.Panel1.Controls.Add(Me.Panel2)
            Dim panel As System.Windows.Forms.Panel = Me.Panel1
            Dim location As System.Drawing.Point = New System.Drawing.Point(3, 3)
            panel.Location = location
            Me.Panel1.Name = "Panel1"
            Dim panel2 As System.Windows.Forms.Panel = Me.Panel1
            Dim size As System.Drawing.Size = New System.Drawing.Size(1013, 556)
            panel2.Size = size
            Me.Panel1.TabIndex = 2
            Me.lblQty.AutoSize = True
            Dim label As System.Windows.Forms.Label = Me.lblQty
            location = New System.Drawing.Point(381, 109)
            label.Location = location
            Me.lblQty.Name = "lblQty"
            Dim label2 As System.Windows.Forms.Label = Me.lblQty
            size = New System.Drawing.Size(45, 13)
            label2.Size = size
            Me.lblQty.TabIndex = 51
            Me.lblQty.Text = "Label11"
            Me.lblQty.Visible = False
            Dim textBox As System.Windows.Forms.TextBox = Me.txtProductID
            location = New System.Drawing.Point(369, 70)
            textBox.Location = location
            Me.txtProductID.Name = "txtProductID"
            Dim textBox2 As System.Windows.Forms.TextBox = Me.txtProductID
            size = New System.Drawing.Size(47, 20)
            textBox2.Size = size
            Me.txtProductID.TabIndex = 50
            Me.txtProductID.Visible = False
            Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel3.Controls.Add(Me.txtSearchByProductName)
            Me.Panel3.Controls.Add(Me.Label10)
            Dim panel3 As System.Windows.Forms.Panel = Me.Panel3
            location = New System.Drawing.Point(456, 49)
            panel3.Location = location
            Me.Panel3.Name = "Panel3"
            Dim panel4 As System.Windows.Forms.Panel = Me.Panel3
            size = New System.Drawing.Size(186, 70)
            panel4.Size = size
            Me.Panel3.TabIndex = 49
            Me.txtSearchByProductName.BackColor = System.Drawing.Color.White
            Me.txtSearchByProductName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox3 As System.Windows.Forms.TextBox = Me.txtSearchByProductName
            location = New System.Drawing.Point(13, 30)
            textBox3.Location = location
            Me.txtSearchByProductName.Name = "txtSearchByProductName"
            Dim textBox4 As System.Windows.Forms.TextBox = Me.txtSearchByProductName
            size = New System.Drawing.Size(159, 21)
            textBox4.Size = size
            Me.txtSearchByProductName.TabIndex = 13
            Me.Label10.AutoSize = True
            Dim label3 As System.Windows.Forms.Label = Me.Label10
            location = New System.Drawing.Point(10, 10)
            label3.Location = location
            Me.Label10.Name = "Label10"
            Dim label4 As System.Windows.Forms.Label = Me.Label10
            size = New System.Drawing.Size(133, 13)
            label4.Size = size
            Me.Label10.TabIndex = 12
            Me.Label10.Text = "Search By Product Name :"
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
            Me.DataGridView1.Columns.AddRange(Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.Column4, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5)
            Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.DataGridView1.EnableHeadersVisualStyles = False
            Me.DataGridView1.GridColor = System.Drawing.Color.White
            Dim dataGridView As System.Windows.Forms.DataGridView = Me.DataGridView1
            location = New System.Drawing.Point(456, 125)
            dataGridView.Location = location
            Me.DataGridView1.MultiSelect = False
            Me.DataGridView1.Name = "DataGridView1"
            Me.DataGridView1.[ReadOnly] = True
            Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White
            dataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3
            Me.DataGridView1.RowHeadersWidth = 25
            Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White
            dataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gainsboro
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
            Me.DataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4
            Me.DataGridView1.RowTemplate.Height = 18
            Me.DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Dim dataGridView2 As System.Windows.Forms.DataGridView = Me.DataGridView1
            size = New System.Drawing.Size(445, 426)
            dataGridView2.Size = size
            Me.DataGridView1.TabIndex = 48
            Me.DataGridViewTextBoxColumn1.HeaderText = "Warehouse"
            Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
            Me.DataGridViewTextBoxColumn1.[ReadOnly] = True
            Me.DataGridViewTextBoxColumn1.Width = 90
            Me.DataGridViewTextBoxColumn2.HeaderText = "Product ID"
            Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
            Me.DataGridViewTextBoxColumn2.[ReadOnly] = True
            Me.DataGridViewTextBoxColumn2.Visible = False
            Me.DataGridViewTextBoxColumn3.HeaderText = "Product Name"
            Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
            Me.DataGridViewTextBoxColumn3.[ReadOnly] = True
            Me.Column4.HeaderText = "Unit"
            Me.Column4.Name = "Column4"
            Me.Column4.[ReadOnly] = True
            Me.Column4.Width = 60
            dataGridViewCellStyle5.Format = "dd/MM/yyyy"
            Me.DataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle5
            Me.DataGridViewTextBoxColumn4.HeaderText = "Expiry Date"
            Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
            Me.DataGridViewTextBoxColumn4.[ReadOnly] = True
            Me.DataGridViewTextBoxColumn4.Width = 80
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.DataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle6
            Me.DataGridViewTextBoxColumn5.HeaderText = "Available Qty."
            Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
            Me.DataGridViewTextBoxColumn5.[ReadOnly] = True
            Me.DataGridViewTextBoxColumn5.Width = 86
            Me.GroupBox4.Controls.Add(Me.Button1)
            Me.GroupBox4.Controls.Add(Me.txtID)
            Me.GroupBox4.Controls.Add(Me.Label7)
            Me.GroupBox4.Controls.Add(Me.cmbKitchen)
            Me.GroupBox4.Controls.Add(Me.Label5)
            Me.GroupBox4.Controls.Add(Me.Label6)
            Me.GroupBox4.Controls.Add(Me.dtpDate)
            Dim groupBox As System.Windows.Forms.GroupBox = Me.GroupBox4
            location = New System.Drawing.Point(4, 39)
            groupBox.Location = location
            Me.GroupBox4.Name = "GroupBox4"
            Dim groupBox2 As System.Windows.Forms.GroupBox = Me.GroupBox4
            size = New System.Drawing.Size(301, 112)
            groupBox2.Size = size
            Me.GroupBox4.TabIndex = 0
            Me.GroupBox4.TabStop = False
            Me.GroupBox4.Text = "Transfer/Issue Info"
            Dim textBox5 As System.Windows.Forms.TextBox = Me.txtID
            location = New System.Drawing.Point(118, 27)
            textBox5.Location = location
            Me.txtID.Name = "txtID"
            Me.txtID.[ReadOnly] = True
            Dim textBox6 As System.Windows.Forms.TextBox = Me.txtID
            size = New System.Drawing.Size(100, 20)
            textBox6.Size = size
            Me.txtID.TabIndex = 0
            Me.Label7.AutoSize = True
            Dim label5 As System.Windows.Forms.Label = Me.Label7
            location = New System.Drawing.Point(10, 27)
            label5.Location = location
            Me.Label7.Name = "Label7"
            Dim label6 As System.Windows.Forms.Label = Me.Label7
            size = New System.Drawing.Size(66, 13)
            label6.Size = size
            Me.Label7.TabIndex = 16
            Me.Label7.Text = "Transfer ID :"
            Me.cmbKitchen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbKitchen.FormattingEnabled = True
            Dim comboBox As System.Windows.Forms.ComboBox = Me.cmbKitchen
            location = New System.Drawing.Point(118, 81)
            comboBox.Location = location
            Me.cmbKitchen.Name = "cmbKitchen"
            Dim comboBox2 As System.Windows.Forms.ComboBox = Me.cmbKitchen
            size = New System.Drawing.Size(138, 21)
            comboBox2.Size = size
            Me.cmbKitchen.TabIndex = 2
            Me.Label5.AutoSize = True
            Dim label7 As System.Windows.Forms.Label = Me.Label5
            location = New System.Drawing.Point(10, 53)
            label7.Location = location
            Me.Label5.Name = "Label5"
            Dim label8 As System.Windows.Forms.Label = Me.Label5
            size = New System.Drawing.Size(36, 13)
            label8.Size = size
            Me.Label5.TabIndex = 15
            Me.Label5.Text = "Date :"
            Me.Label6.AutoSize = True
            Dim label9 As System.Windows.Forms.Label = Me.Label6
            location = New System.Drawing.Point(10, 81)
            label9.Location = location
            Me.Label6.Name = "Label6"
            Dim label10 As System.Windows.Forms.Label = Me.Label6
            size = New System.Drawing.Size(90, 13)
            label10.Size = size
            Me.Label6.TabIndex = 10
            Me.Label6.Text = "Kitchen/Section :"
            Me.dtpDate.CustomFormat = "dd/MM/yyyy"
            Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Dim dateTimePicker As System.Windows.Forms.DateTimePicker = Me.dtpDate
            location = New System.Drawing.Point(118, 53)
            dateTimePicker.Location = location
            Me.dtpDate.Name = "dtpDate"
            Dim dateTimePicker2 As System.Windows.Forms.DateTimePicker = Me.dtpDate
            size = New System.Drawing.Size(158, 20)
            dateTimePicker2.Size = size
            Me.dtpDate.TabIndex = 1
            Me.lblSet.AutoSize = True
            Dim label11 As System.Windows.Forms.Label = Me.lblSet
            location = New System.Drawing.Point(366, 39)
            label11.Location = location
            Me.lblSet.Name = "lblSet"
            Dim label12 As System.Windows.Forms.Label = Me.lblSet
            size = New System.Drawing.Size(23, 13)
            label12.Size = size
            Me.lblSet.TabIndex = 47
            Me.lblSet.Text = "Set"
            Me.lblSet.Visible = False
            Me.GroupBox3.Controls.Add(Me.btnGetData)
            Me.GroupBox3.Controls.Add(Me.btnPrint)
            Me.GroupBox3.Controls.Add(Me.btnDelete)
            Me.GroupBox3.Controls.Add(Me.btnNew)
            Me.GroupBox3.Controls.Add(Me.btnSave)
            Dim groupBox3 As System.Windows.Forms.GroupBox = Me.GroupBox3
            location = New System.Drawing.Point(906, 58)
            groupBox3.Location = location
            Me.GroupBox3.Name = "GroupBox3"
            Dim groupBox4 As System.Windows.Forms.GroupBox = Me.GroupBox3
            size = New System.Drawing.Size(99, 223)
            groupBox4.Size = size
            Me.GroupBox3.TabIndex = 4
            Me.GroupBox3.TabStop = False
            Me.btnGetData.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnGetData.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnGetData.Image = CType(componentResourceManager.GetObject("btnGetData.Image"), System.Drawing.Image)
            Me.btnGetData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button As System.Windows.Forms.Button = Me.btnGetData
            location = New System.Drawing.Point(6, 181)
            button.Location = location
            Me.btnGetData.Name = "btnGetData"
            Dim button2 As System.Windows.Forms.Button = Me.btnGetData
            size = New System.Drawing.Size(84, 34)
            button2.Size = size
            Me.btnGetData.TabIndex = 9
            Me.btnGetData.Text = "Get Data"
            Me.btnGetData.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnGetData.UseVisualStyleBackColor = True
            Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnPrint.Enabled = False
            Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnPrint.Image = CType(componentResourceManager.GetObject("btnPrint.Image"), System.Drawing.Image)
            Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button3 As System.Windows.Forms.Button = Me.btnPrint
            location = New System.Drawing.Point(8, 139)
            button3.Location = location
            Me.btnPrint.Name = "btnPrint"
            Dim button4 As System.Windows.Forms.Button = Me.btnPrint
            size = New System.Drawing.Size(82, 37)
            button4.Size = size
            Me.btnPrint.TabIndex = 8
            Me.btnPrint.Text = "Print"
            Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnPrint.UseVisualStyleBackColor = True
            Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnDelete.Image = CType(componentResourceManager.GetObject("btnDelete.Image"), System.Drawing.Image)
            Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button5 As System.Windows.Forms.Button = Me.btnDelete
            location = New System.Drawing.Point(8, 97)
            button5.Location = location
            Me.btnDelete.Name = "btnDelete"
            Dim button6 As System.Windows.Forms.Button = Me.btnDelete
            size = New System.Drawing.Size(82, 37)
            button6.Size = size
            Me.btnDelete.TabIndex = 3
            Me.btnDelete.Text = "Delete"
            Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnDelete.UseVisualStyleBackColor = True
            Me.btnNew.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnNew.Image = CType(componentResourceManager.GetObject("btnNew.Image"), System.Drawing.Image)
            Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button7 As System.Windows.Forms.Button = Me.btnNew
            location = New System.Drawing.Point(8, 15)
            button7.Location = location
            Me.btnNew.Name = "btnNew"
            Dim button8 As System.Windows.Forms.Button = Me.btnNew
            size = New System.Drawing.Size(82, 37)
            button8.Size = size
            Me.btnNew.TabIndex = 0
            Me.btnNew.Text = "New"
            Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnNew.UseVisualStyleBackColor = True
            Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnSave.Image = CType(componentResourceManager.GetObject("btnSave.Image"), System.Drawing.Image)
            Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button9 As System.Windows.Forms.Button = Me.btnSave
            location = New System.Drawing.Point(8, 57)
            button9.Location = location
            Me.btnSave.Name = "btnSave"
            Dim button10 As System.Windows.Forms.Button = Me.btnSave
            size = New System.Drawing.Size(82, 37)
            button10.Size = size
            Me.btnSave.TabIndex = 1
            Me.btnSave.Text = "Save"
            Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnSave.UseVisualStyleBackColor = True
            Me.GroupBox2.Controls.Add(Me.lblUnit)
            Me.GroupBox2.Controls.Add(Me.Label9)
            Me.GroupBox2.Controls.Add(Me.txtExpiryDate)
            Me.GroupBox2.Controls.Add(Me.txtProductName)
            Me.GroupBox2.Controls.Add(Me.txtWarehouse)
            Me.GroupBox2.Controls.Add(Me.Label8)
            Me.GroupBox2.Controls.Add(Me.txtAvailableQty)
            Me.GroupBox2.Controls.Add(Me.btnRemove)
            Me.GroupBox2.Controls.Add(Me.btnAdd)
            Me.GroupBox2.Controls.Add(Me.txtTransferQty)
            Me.GroupBox2.Controls.Add(Me.Label2)
            Me.GroupBox2.Controls.Add(Me.Label3)
            Me.GroupBox2.Controls.Add(Me.Label4)
            Dim groupBox5 As System.Windows.Forms.GroupBox = Me.GroupBox2
            location = New System.Drawing.Point(4, 155)
            groupBox5.Location = location
            Me.GroupBox2.Name = "GroupBox2"
            Dim groupBox6 As System.Windows.Forms.GroupBox = Me.GroupBox2
            size = New System.Drawing.Size(445, 162)
            groupBox6.Size = size
            Me.GroupBox2.TabIndex = 1
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Product Info"
            Me.lblUnit.AutoSize = True
            Dim label13 As System.Windows.Forms.Label = Me.lblUnit
            location = New System.Drawing.Point(237, 108)
            label13.Location = location
            Me.lblUnit.Name = "lblUnit"
            Dim label14 As System.Windows.Forms.Label = Me.lblUnit
            size = New System.Drawing.Size(26, 13)
            label14.Size = size
            Me.lblUnit.TabIndex = 19
            Me.lblUnit.Text = "Unit"
            Me.Label9.AutoSize = True
            Dim label15 As System.Windows.Forms.Label = Me.Label9
            location = New System.Drawing.Point(6, 79)
            label15.Location = location
            Me.Label9.Name = "Label9"
            Dim label16 As System.Windows.Forms.Label = Me.Label9
            size = New System.Drawing.Size(67, 13)
            label16.Size = size
            Me.Label9.TabIndex = 18
            Me.Label9.Text = "Expiry Date :"
            Dim textBox7 As System.Windows.Forms.TextBox = Me.txtExpiryDate
            location = New System.Drawing.Point(110, 79)
            textBox7.Location = location
            Me.txtExpiryDate.Name = "txtExpiryDate"
            Me.txtExpiryDate.[ReadOnly] = True
            Dim textBox8 As System.Windows.Forms.TextBox = Me.txtExpiryDate
            size = New System.Drawing.Size(120, 20)
            textBox8.Size = size
            Me.txtExpiryDate.TabIndex = 2
            Dim textBox9 As System.Windows.Forms.TextBox = Me.txtProductName
            location = New System.Drawing.Point(110, 53)
            textBox9.Location = location
            Me.txtProductName.Name = "txtProductName"
            Me.txtProductName.[ReadOnly] = True
            Dim textBox10 As System.Windows.Forms.TextBox = Me.txtProductName
            size = New System.Drawing.Size(222, 20)
            textBox10.Size = size
            Me.txtProductName.TabIndex = 1
            Dim textBox11 As System.Windows.Forms.TextBox = Me.txtWarehouse
            location = New System.Drawing.Point(110, 26)
            textBox11.Location = location
            Me.txtWarehouse.Name = "txtWarehouse"
            Me.txtWarehouse.[ReadOnly] = True
            Dim textBox12 As System.Windows.Forms.TextBox = Me.txtWarehouse
            size = New System.Drawing.Size(222, 20)
            textBox12.Size = size
            Me.txtWarehouse.TabIndex = 0
            Me.Label8.AutoSize = True
            Dim label17 As System.Windows.Forms.Label = Me.Label8
            location = New System.Drawing.Point(6, 105)
            label17.Location = location
            Me.Label8.Name = "Label8"
            Dim label18 As System.Windows.Forms.Label = Me.Label8
            size = New System.Drawing.Size(78, 13)
            label18.Size = size
            Me.Label8.TabIndex = 14
            Me.Label8.Text = "Available Qty. :"
            Me.txtAvailableQty.BackColor = System.Drawing.SystemColors.Control
            Me.txtAvailableQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox13 As System.Windows.Forms.TextBox = Me.txtAvailableQty
            location = New System.Drawing.Point(110, 105)
            textBox13.Location = location
            Me.txtAvailableQty.Name = "txtAvailableQty"
            Me.txtAvailableQty.[ReadOnly] = True
            Dim textBox14 As System.Windows.Forms.TextBox = Me.txtAvailableQty
            size = New System.Drawing.Size(120, 21)
            textBox14.Size = size
            Me.txtAvailableQty.TabIndex = 3
            Me.txtAvailableQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnRemove.Image = CType(componentResourceManager.GetObject("btnRemove.Image"), System.Drawing.Image)
            Me.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button11 As System.Windows.Forms.Button = Me.btnRemove
            location = New System.Drawing.Point(345, 65)
            button11.Location = location
            Me.btnRemove.Name = "btnRemove"
            Dim button12 As System.Windows.Forms.Button = Me.btnRemove
            size = New System.Drawing.Size(90, 34)
            button12.Size = size
            Me.btnRemove.TabIndex = 6
            Me.btnRemove.Text = "&Remove"
            Me.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnRemove.UseVisualStyleBackColor = True
            Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnAdd.Image = CType(componentResourceManager.GetObject("btnAdd.Image"), System.Drawing.Image)
            Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button13 As System.Windows.Forms.Button = Me.btnAdd
            location = New System.Drawing.Point(345, 26)
            button13.Location = location
            Me.btnAdd.Name = "btnAdd"
            Dim button14 As System.Windows.Forms.Button = Me.btnAdd
            size = New System.Drawing.Size(67, 34)
            button14.Size = size
            Me.btnAdd.TabIndex = 5
            Me.btnAdd.Text = "&Add"
            Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnAdd.UseVisualStyleBackColor = True
            Me.txtTransferQty.BackColor = System.Drawing.Color.White
            Me.txtTransferQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox15 As System.Windows.Forms.TextBox = Me.txtTransferQty
            location = New System.Drawing.Point(110, 132)
            textBox15.Location = location
            Me.txtTransferQty.Name = "txtTransferQty"
            Dim textBox16 As System.Windows.Forms.TextBox = Me.txtTransferQty
            size = New System.Drawing.Size(120, 21)
            textBox16.Size = size
            Me.txtTransferQty.TabIndex = 4
            Me.txtTransferQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.Label2.AutoSize = True
            Dim label19 As System.Windows.Forms.Label = Me.Label2
            location = New System.Drawing.Point(6, 132)
            label19.Location = location
            Me.Label2.Name = "Label2"
            Dim label20 As System.Windows.Forms.Label = Me.Label2
            size = New System.Drawing.Size(94, 13)
            label20.Size = size
            Me.Label2.TabIndex = 5
            Me.Label2.Text = "Transfer Quantity :"
            Me.Label3.AutoSize = True
            Dim label21 As System.Windows.Forms.Label = Me.Label3
            location = New System.Drawing.Point(6, 26)
            label21.Location = location
            Me.Label3.Name = "Label3"
            Dim label22 As System.Windows.Forms.Label = Me.Label3
            size = New System.Drawing.Size(68, 13)
            label22.Size = size
            Me.Label3.TabIndex = 0
            Me.Label3.Text = "Warehouse :"
            Me.Label4.AutoSize = True
            Dim label23 As System.Windows.Forms.Label = Me.Label4
            location = New System.Drawing.Point(6, 53)
            label23.Location = location
            Me.Label4.Name = "Label4"
            Dim label24 As System.Windows.Forms.Label = Me.Label4
            size = New System.Drawing.Size(81, 13)
            label24.Size = size
            Me.Label4.TabIndex = 6
            Me.Label4.Text = "Product Name :"
            Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnClose.Image = CType(componentResourceManager.GetObject("btnClose.Image"), System.Drawing.Image)
            Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button15 As System.Windows.Forms.Button = Me.btnClose
            location = New System.Drawing.Point(923, 4)
            button15.Location = location
            Me.btnClose.Name = "btnClose"
            Dim button16 As System.Windows.Forms.Button = Me.btnClose
            size = New System.Drawing.Size(82, 37)
            button16.Size = size
            Me.btnClose.TabIndex = 4
            Me.btnClose.Text = "Close"
            Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnClose.UseVisualStyleBackColor = True
            Me.lblUser.AutoSize = True
            Dim label25 As System.Windows.Forms.Label = Me.lblUser
            location = New System.Drawing.Point(366, 60)
            label25.Location = location
            Me.lblUser.Name = "lblUser"
            Dim label26 As System.Windows.Forms.Label = Me.lblUser
            size = New System.Drawing.Size(39, 13)
            label26.Size = size
            Me.lblUser.TabIndex = 5
            Me.lblUser.Text = "Label8"
            Me.lblUser.Visible = False
            Me.dgw.AllowUserToAddRows = False
            Me.dgw.AllowUserToDeleteRows = False
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FloralWhite
            Me.dgw.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7
            Me.dgw.BackgroundColor = System.Drawing.Color.White
            Me.dgw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            dataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightSteelBlue
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgw.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8
            Me.dgw.ColumnHeadersHeight = 24
            Me.dgw.Columns.AddRange(Me.Column1, Me.Column2, Me.Column3, Me.Column6, Me.Column5)
            Me.dgw.Cursor = System.Windows.Forms.Cursors.Hand
            Me.dgw.EnableHeadersVisualStyles = False
            Me.dgw.GridColor = System.Drawing.Color.White
            Dim dataGridView3 As System.Windows.Forms.DataGridView = Me.dgw
            location = New System.Drawing.Point(4, 325)
            dataGridView3.Location = location
            Me.dgw.MultiSelect = False
            Me.dgw.Name = "dgw"
            Me.dgw.[ReadOnly] = True
            Me.dgw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White
            dataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Gainsboro
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.Desktop
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgw.RowHeadersDefaultCellStyle = dataGridViewCellStyle9
            Me.dgw.RowHeadersWidth = 25
            Me.dgw.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White
            dataGridViewCellStyle10.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Gainsboro
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black
            Me.dgw.RowsDefaultCellStyle = dataGridViewCellStyle10
            Me.dgw.RowTemplate.Height = 18
            Me.dgw.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgw.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Dim dataGridView4 As System.Windows.Forms.DataGridView = Me.dgw
            size = New System.Drawing.Size(445, 226)
            dataGridView4.Size = size
            Me.dgw.TabIndex = 1
            Me.Column1.HeaderText = "Warehouse"
            Me.Column1.Name = "Column1"
            Me.Column1.[ReadOnly] = True
            Me.Column2.HeaderText = "Product ID"
            Me.Column2.Name = "Column2"
            Me.Column2.[ReadOnly] = True
            Me.Column2.Visible = False
            Me.Column3.HeaderText = "Product Name"
            Me.Column3.Name = "Column3"
            Me.Column3.[ReadOnly] = True
            Me.Column3.Width = 117
            dataGridViewCellStyle11.NullValue = "dd/MM/yyyy"
            Me.Column6.DefaultCellStyle = dataGridViewCellStyle11
            Me.Column6.HeaderText = "Expiry Date"
            Me.Column6.Name = "Column6"
            Me.Column6.[ReadOnly] = True
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.Column5.DefaultCellStyle = dataGridViewCellStyle12
            Me.Column5.HeaderText = "Transfer Qty."
            Me.Column5.Name = "Column5"
            Me.Column5.[ReadOnly] = True
            Me.Panel2.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Panel2.Controls.Add(Me.Label1)
            Dim panel5 As System.Windows.Forms.Panel = Me.Panel2
            location = New System.Drawing.Point(4, 4)
            panel5.Location = location
            Me.Panel2.Name = "Panel2"
            Dim panel6 As System.Windows.Forms.Panel = Me.Panel2
            size = New System.Drawing.Size(913, 28)
            panel6.Size = size
            Me.Panel2.TabIndex = 0
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label1.ForeColor = System.Drawing.Color.White
            Dim label27 As System.Windows.Forms.Label = Me.Label1
            location = New System.Drawing.Point(396, 0)
            label27.Location = location
            Me.Label1.Name = "Label1"
            Dim label28 As System.Windows.Forms.Label = Me.Label1
            size = New System.Drawing.Size(199, 24)
            label28.Size = size
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Stock Issue/Transfer"
            Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.Button1.Image = RestaurantPOS14.My.Resources.Resources._1__2_
            Dim button17 As System.Windows.Forms.Button = Me.Button1
            location = New System.Drawing.Point(262, 79)
            button17.Location = location
            Me.Button1.Name = "Button1"
            Dim button18 As System.Windows.Forms.Button = Me.Button1
            size = New System.Drawing.Size(31, 23)
            button18.Size = size
            Me.Button1.TabIndex = 313
            Me.Button1.UseVisualStyleBackColor = True
            MyBase.AcceptButton = Me.btnSave
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            size = New System.Drawing.Size(1018, 562)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.Panel1)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MaximizeBox = False
            MyBase.MinimizeBox = False
            MyBase.Name = "frmStockTransfer"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.Panel3.ResumeLayout(False)
            Me.Panel3.PerformLayout()
            CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox4.ResumeLayout(False)
            Me.GroupBox4.PerformLayout()
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            MyBase.ResumeLayout(False)
        End Sub

    End Class
End Namespace
