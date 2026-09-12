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
    Public Class frmRecipe
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

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtQty")>
        Private _txtQty As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("cmbItemName")>
        Private _cmbItemName As System.Windows.Forms.ComboBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox4")>
        Private _GroupBox4 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtID")>
        Private _txtID As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label7")>
        Private _Label7 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnRemove")>
        Private _btnRemove As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnAdd")>
        Private _btnAdd As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnPrint")>
        Private _btnPrint As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtProductID")>
        Private _txtProductID As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnGetData")>
        Private _btnGetData As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Timer1")>
        Private _Timer1 As System.Windows.Forms.Timer

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtDescription")>
        Private _txtDescription As System.Windows.Forms.RichTextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtTotalCost")>
        Private _txtTotalCost As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label10")>
        Private _Label10 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtCategory")>
        Private _txtCategory As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label5")>
        Private _Label5 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtRecipeName")>
        Private _txtRecipeName As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label4")>
        Private _Label4 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("cmbProductName")>
        Private _cmbProductName As System.Windows.Forms.ComboBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label8")>
        Private _Label8 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnUpdate")>
        Private _btnUpdate As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtTotalItemCost")>
        Private _txtTotalItemCost As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblUnit")>
        Private _lblUnit As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnGridUpdate")>
        Private _btnGridUpdate As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label9")>
        Private _Label9 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtCostPerUnit")>
        Private _txtCostPerUnit As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column2")>
        Private _Column2 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column3")>
        Private _Column3 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column5")>
        Private _Column5 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column1")>
        Private _Column1 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column6")>
        Private _Column6 As System.Windows.Forms.DataGridViewTextBoxColumn

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

        Friend Overridable Property txtQty As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtQty
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.EventHandler = AddressOf Me.txtQty_TextChanged
                Dim value3 As System.Windows.Forms.KeyPressEventHandler = AddressOf Me.txtTransferQty_KeyPress
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

        Friend Overridable Property cmbItemName As System.Windows.Forms.ComboBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._cmbItemName
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ComboBox)
                Dim value2 As System.EventHandler = AddressOf Me.cmbItemName_SelectedIndexChanged
                If Me._cmbItemName IsNot Nothing Then
                    RemoveHandler Me._cmbItemName.SelectedIndexChanged, value2
                End If

                Me._cmbItemName = value
                If Me._cmbItemName IsNot Nothing Then
                    AddHandler Me._cmbItemName.SelectedIndexChanged, value2
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

        Friend Overridable Property txtDescription As System.Windows.Forms.RichTextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtDescription
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.RichTextBox)
                Me._txtDescription = value
            End Set
        End Property

        Friend Overridable Property txtTotalCost As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtTotalCost
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtTotalCost = value
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

        Friend Overridable Property txtCategory As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtCategory
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtCategory = value
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

        Friend Overridable Property txtRecipeName As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtRecipeName
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtRecipeName = value
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

        Friend Overridable Property txtTotalItemCost As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtTotalItemCost
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtTotalItemCost = value
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

        Friend Overridable Property btnGridUpdate As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnGridUpdate
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnGridUpdate_Click
                If Me._btnGridUpdate IsNot Nothing Then
                    RemoveHandler Me._btnGridUpdate.Click, value2
                End If

                Me._btnGridUpdate = value
                If Me._btnGridUpdate IsNot Nothing Then
                    AddHandler Me._btnGridUpdate.Click, value2
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

        Friend Overridable Property txtCostPerUnit As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtCostPerUnit
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.EventHandler = AddressOf Me.txtCostPerUnit_TextChanged
                Dim value3 As System.Windows.Forms.KeyPressEventHandler = AddressOf Me.txtCostPerUnit_KeyPress
                If Me._txtCostPerUnit IsNot Nothing Then
                    RemoveHandler Me._txtCostPerUnit.TextChanged, value2
                    RemoveHandler Me._txtCostPerUnit.KeyPress, value3
                End If

                Me._txtCostPerUnit = value
                If Me._txtCostPerUnit IsNot Nothing Then
                    AddHandler Me._txtCostPerUnit.TextChanged, value2
                    AddHandler Me._txtCostPerUnit.KeyPress, value3
                End If
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
            Call RestaurantPOS14.frmRecipe.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmRecipe.__ENCList
                If RestaurantPOS14.frmRecipe.__ENCList.Count = RestaurantPOS14.frmRecipe.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmRecipe.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmRecipe.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmRecipe.__ENCList(num) = RestaurantPOS14.frmRecipe.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmRecipe.__ENCList.RemoveRange(num, RestaurantPOS14.frmRecipe.__ENCList.Count - num)
                    RestaurantPOS14.frmRecipe.__ENCList.Capacity = RestaurantPOS14.frmRecipe.__ENCList.Count
                End If

                Call RestaurantPOS14.frmRecipe.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Public Sub FillItems()
            Try
                Dim sqlConnection As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                sqlConnection.Open()
                RestaurantPOS14.ModClasses.adp = New System.Data.SqlClient.SqlDataAdapter()
                RestaurantPOS14.ModClasses.adp.SelectCommand = New System.Data.SqlClient.SqlCommand("SELECT distinct RTRIM(DishName) FROM Dish", sqlConnection)
                RestaurantPOS14.ModClasses.ds = New System.Data.DataSet("ds")
                RestaurantPOS14.ModClasses.adp.Fill(RestaurantPOS14.ModClasses.ds)
                RestaurantPOS14.ModClasses.dtable = RestaurantPOS14.ModClasses.ds.Tables(0)
                Me.cmbItemName.Items.Clear()
                For Each dataRow As System.Data.DataRow In RestaurantPOS14.ModClasses.dtable.Rows
                    Me.cmbItemName.Items.Add(dataRow(CInt((0))).ToString())
                Next
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub Reset()
            Me.cmbItemName.Text = ""
            Me.txtCategory.Text = ""
            Me.txtRecipeName.Text = ""
            Me.txtDescription.Text = ""
            Me.txtTotalCost.Text = "0.00"
            Me.lblUnit.Text = "Unit"
            Me.dgw.Rows.Clear()
            If RestaurantPOS14.ModFunc.IsViewAllowed(Me.lblUser.Text, "Recipe") Then
                Me.btnGetData.Enabled = True
            Else
                Me.btnGetData.Enabled = False
            End If

            If RestaurantPOS14.ModFunc.IsSaveAllowed(Me.lblUser.Text, "Recipe") Then
                Me.btnSave.Enabled = True
            Else
                Me.btnSave.Enabled = False
            End If

            Me.btnDelete.Enabled = False
            Me.btnPrint.Enabled = False
            Me.btnRemove.Enabled = False
            Me.btnAdd.Enabled = True
            Me.Clear()
        End Sub

        Private Sub btnClose_Click(sender As Object, e As System.EventArgs)
            MyBase.Close()
        End Sub

        Private Function GenerateID() As String
            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
            Dim text As String = "0000"
            Try
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT TOP 1 R_ID FROM Recipe ORDER BY R_ID DESC", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                If RestaurantPOS14.ModClasses.rdr.HasRows Then
                    RestaurantPOS14.ModClasses.rdr.Read()
                    text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr("R_ID"))
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
                If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.txtRecipeName.Text)) = 0 Then
                    Call System.Windows.Forms.MessageBox.Show("Please enter recipe name", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Me.txtRecipeName.Focus()
                    Return
                End If

                If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.cmbItemName.Text)) = 0 Then
                    Call System.Windows.Forms.MessageBox.Show("Please select item name", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Me.cmbItemName.Focus()
                    Return
                End If

                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtTotalCost.Text, "", TextCompare:=False) = 0 Then
                    Call System.Windows.Forms.MessageBox.Show("Please enter fixed cost", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Me.txtTotalCost.Focus()
                    Return
                End If

                If Me.dgw.Rows.Count = 0 Then
                    Call System.Windows.Forms.MessageBox.Show("sorry no product added to grid", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Return
                End If

                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select RecipeName from Recipe where RecipeName=@d1")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtRecipeName.Text)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Recipe Name Already Exists", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                    Me.txtRecipeName.Text = ""
                    Me.txtRecipeName.Focus()
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select Dish from Recipe where Dish=@d1")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.cmbItemName.Text)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Recipe Already Exists for selected item", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                Me.auto()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("insert into Recipe(R_ID,RecipeName,Dish,FixedCost,Description) VALUES (@d1,@d2,@d3,@d4,@d5)")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.Conversion.Val(Me.txtID.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Me.txtRecipeName.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Me.cmbItemName.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", Microsoft.VisualBasic.Conversion.Val(Me.txtTotalCost.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d5", Me.txtDescription.Text)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("insert into Recipe_Join(RecipeID,ProductID,Quantity,CostPerUnit,TotalItemCost) VALUES (" & RestaurantPOS14.Security.SqlInput.RequireInteger(Me.txtID.Text, "Record ID") & ",@d1,@d2,@d3,@d4)")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Prepare()
                For Each dataGridViewRow As System.Windows.Forms.DataGridViewRow In CType(Me.dgw.Rows, System.Collections.IEnumerable)
                    If Not dataGridViewRow.IsNewRow Then
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((0))).Value)))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((2))).Value)))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((3))).Value)))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((4))).Value)))
                        RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                        RestaurantPOS14.ModClasses.cmd.Parameters.Clear()
                    End If
                Next

                RestaurantPOS14.ModFunc.LogFunc(Me.lblUser.Text, "Added the new Receipe '" & Me.txtRecipeName.Text & "' having Recipe ID '" & Me.txtID.Text & "'")
                Call System.Windows.Forms.MessageBox.Show("Successfully saved", "Record", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                Me.btnSave.Enabled = False
                RestaurantPOS14.ModClasses.con.Close()
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
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("delete from Recipe where R_ID=@d1")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.Conversion.Val(Me.txtID.Text))
                If RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery() > 0 Then
                    RestaurantPOS14.ModFunc.LogFunc(Me.lblUser.Text, "Deleted the Receipe '" & Me.txtRecipeName.Text & "' having Recipe ID '" & Me.txtID.Text & "'")
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
            Me.FillItems()
            Me.fillProduct()
        End Sub

        Public Sub Clear()
            Me.cmbProductName.Text = ""
            Me.txtTotalItemCost.Text = "0.00"
            Me.txtCostPerUnit.Text = "0.00"
            Me.lblUnit.Text = "Unit"
            Me.btnGridUpdate.Enabled = False
            Me.btnRemove.Enabled = False
            Me.btnAdd.Enabled = True
            Me.txtQty.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(1)
        End Sub

        Public Function TotalCost() As Double
            Dim num As Double = 0.0
            Try
                For Each dataGridViewRow As System.Windows.Forms.DataGridViewRow In CType(Me.dgw.Rows, System.Collections.IEnumerable)
                    num = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(num, dataGridViewRow.Cells(CInt((4))).Value))
                Next
            Catch ex As System.Exception
                Call Microsoft.VisualBasic.Interaction.MsgBox(ex.Message)
            End Try

            Return num
        End Function

        Private Sub btnRemoveFromGridOS_Click(sender As Object, e As System.EventArgs)
            Try
                If Me.dgw.Rows.Count <= 0 Then
                    Return
                End If

                For Each dataGridViewRow As System.Windows.Forms.DataGridViewRow In Me.dgw.SelectedRows
                    Me.dgw.Rows.Remove(dataGridViewRow)
                Next

                Dim value As Double = Me.TotalCost()
                value = System.Math.Round(value, 2)
                Me.txtTotalCost.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(value)
                Me.btnRemove.Enabled = False
                Me.Clear()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnAddOS_Click(sender As Object, e As System.EventArgs)
            Try
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.cmbProductName.Text, "", TextCompare:=False) = 0 Then
                    Call System.Windows.Forms.MessageBox.Show("Please select product name", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Me.cmbProductName.Focus()
                    Return
                End If

                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtQty.Text, "", TextCompare:=False) = 0 Then
                    Call System.Windows.Forms.MessageBox.Show("Please enter qty", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Me.txtQty.Focus()
                    Return
                End If

                If Microsoft.VisualBasic.Conversion.Val(Me.txtQty.Text) = 0.0 Then
                    Call System.Windows.Forms.MessageBox.Show("Quantity must be greater than zero", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Me.txtQty.Focus()
                    Return
                End If

                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtTotalItemCost.Text, "", TextCompare:=False) = 0 Then
                    Call System.Windows.Forms.MessageBox.Show("Please enter cost", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Me.txtTotalItemCost.Focus()
                    Return
                End If

                If Me.dgw.Rows.Count = 0 Then
                    Me.dgw.Rows.Add(Microsoft.VisualBasic.Conversion.Val(Me.txtProductID.Text), Me.cmbProductName.Text, Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.txtQty.Text)) & " " & Me.lblUnit.Text, Microsoft.VisualBasic.Conversion.Val(Me.txtCostPerUnit.Text), Microsoft.VisualBasic.Conversion.Val(Me.txtTotalItemCost.Text))
                    Dim value As Double = Me.TotalCost()
                    value = System.Math.Round(value, 2)
                    Me.txtTotalCost.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(value)
                    Me.Clear()
                    Return
                End If

                For Each dataGridViewRow As System.Windows.Forms.DataGridViewRow In CType(Me.dgw.Rows, System.Collections.IEnumerable)
                    If Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.OrObject(Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(Me.txtProductID.Text) = Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((0))).Value)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(Me.cmbProductName.Text, dataGridViewRow.Cells(CInt((1))).Value, TextCompare:=False))) Then
                        Call System.Windows.Forms.MessageBox.Show("Already added to grid", "Input Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                        Me.Clear()
                        Return
                    End If
                Next

                Me.dgw.Rows.Add(Microsoft.VisualBasic.Conversion.Val(Me.txtProductID.Text), Me.cmbProductName.Text, Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.txtQty.Text)) & " " & Me.lblUnit.Text, Microsoft.VisualBasic.Conversion.Val(Me.txtCostPerUnit.Text), Microsoft.VisualBasic.Conversion.Val(Me.txtTotalItemCost.Text))
                Dim value2 As Double = Me.TotalCost()
                value2 = System.Math.Round(value2, 2)
                Me.txtTotalCost.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(value2)
                Me.Clear()
            Catch ex As System.Exception
                Call Microsoft.VisualBasic.Interaction.MsgBox(ex.Message)
            End Try
        End Sub

        Private Sub txtTransferQty_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
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

        Private Sub btnGetData_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmRecipeRecord.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmRecipeRecord.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmRecipeRecord.ShowDialog()
        End Sub

        Private Sub dgw_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs)
            If Me.dgw.Rows.Count > 0 Then
                Me.btnRemove.Enabled = True
                Me.btnAdd.Enabled = False
                Me.btnGridUpdate.Enabled = True
                If Me.dgw.SelectedRows.Count = 0 Then Return
                Dim dataGridViewRow As System.Windows.Forms.DataGridViewRow = Me.dgw.SelectedRows(0)
                Me.txtProductID.Text = dataGridViewRow.Cells(CInt((0))).Value.ToString()
                Me.cmbProductName.Text = dataGridViewRow.Cells(CInt((1))).Value.ToString()
                Dim array As String() = dataGridViewRow.Cells(CInt((2))).Value.ToString().Split(" "c)
                Me.txtQty.Text = array(0)
                Me.lblUnit.Text = array(1)
                Me.txtTotalItemCost.Text = dataGridViewRow.Cells(CInt((4))).Value.ToString()
                Me.txtCostPerUnit.Text = dataGridViewRow.Cells(CInt((3))).Value.ToString()
            End If
        End Sub

        Private Sub btnPrint_Click(sender As Object, e As System.EventArgs)
            Try
                MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Me.Timer1.Enabled = True
                Dim rptRecipe2 As RestaurantPOS14.rptRecipe = New RestaurantPOS14.rptRecipe()
                Dim sqlCommand As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand()
                Dim sqlCommand2 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand()
                Dim sqlDataAdapter As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter()
                Dim sqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter()
                Dim dataSet As System.Data.DataSet = New System.Data.DataSet()
                sqlCommand.Connection = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                Dim sqlConnection As System.Data.SqlClient.SqlConnection = sqlCommand.Connection
                Dim connection As System.Data.SqlClient.SqlConnection = sqlConnection
                sqlCommand2.Connection = connection
                sqlCommand.CommandText = "SELECT Unit,Recipe.R_ID, Recipe.RecipeName, Recipe.Dish, Recipe.FixedCost, Recipe.Description, Recipe_Join.RJ_ID, Recipe_Join.RecipeID, Recipe_Join.ProductID, Recipe_Join.Quantity, Recipe_Join.CostPerUnit,TotalItemCost,Dish.DishName, Dish.Category, Product.PID, Product.ProductCode, Product.ProductName, Product.Category AS Expr1, Product.Description AS Expr2,Product.Unit AS Expr3, Product.Price, Product.ReorderPoint FROM Recipe INNER JOIN Recipe_Join ON Recipe.R_ID = Recipe_Join.RecipeID INNER JOIN Dish ON Recipe.Dish = Dish.DishName INNER JOIN Product ON Recipe_Join.ProductID = Product.PID where R_ID=" & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.txtID.Text))
                sqlCommand2.CommandText = "SELECT * from Hotel"
                sqlCommand.CommandType = System.Data.CommandType.Text
                sqlCommand2.CommandType = System.Data.CommandType.Text
                sqlDataAdapter.SelectCommand = sqlCommand
                sqlDataAdapter2.SelectCommand = sqlCommand2
                sqlDataAdapter.Fill(dataSet, "Recipe")
                sqlDataAdapter.Fill(dataSet, "Recipe_Join")
                sqlDataAdapter.Fill(dataSet, "Dish")
                sqlDataAdapter.Fill(dataSet, "Product")
                sqlDataAdapter2.Fill(dataSet, "Hotel")
                rptRecipe2.SetDataSource(dataSet)
                RestaurantPOS14.My.MyProject.Forms.frmReport.CrystalReportViewer1.ReportSource = rptRecipe2
                Call RestaurantPOS14.My.MyProject.Forms.frmReport.ShowDialog()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub Timer1_Tick(sender As Object, e As System.EventArgs)
            MyBase.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.Timer1.Enabled = False
        End Sub

        Private Sub cmbItemName_SelectedIndexChanged(sender As Object, e As System.EventArgs)
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = RestaurantPOS14.ModClasses.con.CreateCommand()
                RestaurantPOS14.ModClasses.cmd.CommandText = "SELECT Category from Dish where DishName=@d1"
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.cmbItemName.Text)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.txtCategory.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                    Me.txtRecipeName.Text = ""
                    Me.txtRecipeName.Text = Me.cmbItemName.Text & " Recipe"
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

        Private Sub cmbProductName_SelectedIndexChanged(sender As Object, e As System.EventArgs)
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = RestaurantPOS14.ModClasses.con.CreateCommand()
                RestaurantPOS14.ModClasses.cmd.CommandText = "SELECT RTRIM(Unit),PID,Price from Product where ProductName=@d1"
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.cmbProductName.Text)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.lblUnit.Text = RestaurantPOS14.ModClasses.rdr.GetValue(CInt((0))).ToString()
                    Me.txtProductID.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(1))
                    Me.txtQty.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(1)
                    Me.txtCostPerUnit.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(2))
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

        Public Sub fillProduct()
            Try
                Dim sqlConnection As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                sqlConnection.Open()
                RestaurantPOS14.ModClasses.adp = New System.Data.SqlClient.SqlDataAdapter()
                RestaurantPOS14.ModClasses.adp.SelectCommand = New System.Data.SqlClient.SqlCommand("SELECT ProductName FROM Product order by 1", sqlConnection)
                RestaurantPOS14.ModClasses.ds = New System.Data.DataSet("ds")
                RestaurantPOS14.ModClasses.adp.Fill(RestaurantPOS14.ModClasses.ds)
                RestaurantPOS14.ModClasses.dtable = RestaurantPOS14.ModClasses.ds.Tables(0)
                Me.cmbProductName.Items.Clear()
                For Each dataRow As System.Data.DataRow In RestaurantPOS14.ModClasses.dtable.Rows
                    Me.cmbProductName.Items.Add(dataRow(CInt((0))).ToString())
                Next
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub cmbProductName_Format(sender As Object, e As System.Windows.Forms.ListControlConvertEventArgs)
            If e.DesiredType Is GetType(String) Then
                e.Value = e.Value.ToString().Trim()
            End If
        End Sub

        Private Sub cmbUnit_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
            If Char.IsLetter(e.KeyChar) Then
                e.KeyChar = Char.ToUpper(e.KeyChar)
            End If
        End Sub

        Private Sub btnUpdate_Click(sender As Object, e As System.EventArgs)
            Try
                If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.txtRecipeName.Text)) = 0 Then
                    Call System.Windows.Forms.MessageBox.Show("Please enter recipe name", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Me.txtRecipeName.Focus()
                    Return
                End If

                If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.cmbItemName.Text)) = 0 Then
                    Call System.Windows.Forms.MessageBox.Show("Please select item name", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Me.cmbItemName.Focus()
                    Return
                End If

                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtTotalCost.Text, "", TextCompare:=False) = 0 Then
                    Call System.Windows.Forms.MessageBox.Show("Please enter fixed cost", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Me.txtTotalCost.Focus()
                    Return
                End If

                If Me.dgw.Rows.Count = 0 Then
                    Call System.Windows.Forms.MessageBox.Show("sorry no product added to grid", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Return
                End If

                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Update Recipe set RecipeName=@d2,Dish=@d3,FixedCost=@d4,Description=@d5 where R_ID=@d1")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.Conversion.Val(Me.txtID.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Me.txtRecipeName.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Me.cmbItemName.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", Microsoft.VisualBasic.Conversion.Val(Me.txtTotalCost.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d5", Me.txtDescription.Text)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("delete from Recipe_Join where RecipeID=@d1")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.Conversion.Val(Me.txtID.Text))
                RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("insert into Recipe_Join(RecipeID,ProductID,Quantity,CostPerUnit,TotalItemCost) VALUES (" & RestaurantPOS14.Security.SqlInput.RequireInteger(Me.txtID.Text, "Record ID") & ",@d1,@d2,@d3,@d4)")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Prepare()
                For Each dataGridViewRow As System.Windows.Forms.DataGridViewRow In CType(Me.dgw.Rows, System.Collections.IEnumerable)
                    If Not dataGridViewRow.IsNewRow Then
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((0))).Value)))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((2))).Value)))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((3))).Value)))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((4))).Value)))
                        RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                        RestaurantPOS14.ModClasses.cmd.Parameters.Clear()
                    End If
                Next

                RestaurantPOS14.ModFunc.LogFunc(Me.lblUser.Text, "Updated the Receipe '" & Me.txtRecipeName.Text & "' having Recipe ID '" & Me.txtID.Text & "'")
                Call System.Windows.Forms.MessageBox.Show("Successfully updated", "Record", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                Me.btnUpdate.Enabled = False
                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnGridUpdate_Click(sender As Object, e As System.EventArgs)
            Try
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.cmbProductName.Text, "", TextCompare:=False) = 0 Then
                    Call System.Windows.Forms.MessageBox.Show("Please select product name", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Me.cmbProductName.Focus()
                    Return
                End If

                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtQty.Text, "", TextCompare:=False) = 0 Then
                    Call System.Windows.Forms.MessageBox.Show("Please enter qty", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Me.txtQty.Focus()
                    Return
                End If

                If Microsoft.VisualBasic.Conversion.Val(Me.txtQty.Text) = 0.0 Then
                    Call System.Windows.Forms.MessageBox.Show("Quantity must be greater than zero", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Me.txtQty.Focus()
                    Return
                End If

                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtTotalItemCost.Text, "", TextCompare:=False) = 0 Then
                    Call System.Windows.Forms.MessageBox.Show("Please enter cost", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Me.txtTotalItemCost.Focus()
                    Return
                End If

                If Me.dgw.Rows.Count > 0 Then
                    For Each dataGridViewRow As System.Windows.Forms.DataGridViewRow In Me.dgw.SelectedRows
                        Me.dgw.Rows.Remove(dataGridViewRow)
                    Next
                End If

                Me.dgw.Rows.Add(Microsoft.VisualBasic.Conversion.Val(Me.txtProductID.Text), Me.cmbProductName.Text, Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.txtQty.Text)) & " " & Me.lblUnit.Text, Microsoft.VisualBasic.Conversion.Val(Me.txtCostPerUnit.Text), Microsoft.VisualBasic.Conversion.Val(Me.txtTotalItemCost.Text))
                Dim value As Double = Me.TotalCost()
                value = System.Math.Round(value, 2)
                Me.txtTotalCost.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(value)
                Me.Clear()
            Catch ex As System.Exception
                Call Microsoft.VisualBasic.Interaction.MsgBox(ex.Message)
            End Try
        End Sub

        Public Sub Compute()
            Dim value As Double = Microsoft.VisualBasic.Conversion.Val(Me.txtCostPerUnit.Text) * Microsoft.VisualBasic.Conversion.Val(Me.txtQty.Text)
            value = System.Math.Round(value, 2)
            Me.txtTotalItemCost.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(value)
        End Sub

        Private Sub txtQty_TextChanged(sender As Object, e As System.EventArgs)
            Me.Compute()
        End Sub

        Private Sub txtCostPerUnit_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
            Dim keyChar As Char = e.KeyChar
            If Char.IsControl(keyChar) Then
                Return
            End If

            If Char.IsDigit(keyChar) OrElse keyChar = "."c Then
                Dim text As String = Me.txtCostPerUnit.Text
                Dim selectionStart As Integer = Me.txtCostPerUnit.SelectionStart
                Dim selectionLength As Integer = Me.txtCostPerUnit.SelectionLength
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

        Private Sub txtCostPerUnit_TextChanged(sender As Object, e As System.EventArgs)
            Me.Compute()
        End Sub

        Private Sub Button1_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmMenuItem.lblUser.Text = Me.lblUser.Text
            RestaurantPOS14.My.MyProject.Forms.frmMenuItem.lblSet.Text = "Recipe"
            Call RestaurantPOS14.My.MyProject.Forms.frmMenuItem.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmMenuItem.ShowDialog()
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmRecipe))
            Dim dataGridViewCellStyle As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.txtDescription = New System.Windows.Forms.RichTextBox()
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.txtTotalCost = New System.Windows.Forms.TextBox()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.txtCategory = New System.Windows.Forms.TextBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.txtRecipeName = New System.Windows.Forms.TextBox()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.cmbItemName = New System.Windows.Forms.ComboBox()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.btnUpdate = New System.Windows.Forms.Button()
            Me.btnGetData = New System.Windows.Forms.Button()
            Me.btnPrint = New System.Windows.Forms.Button()
            Me.btnDelete = New System.Windows.Forms.Button()
            Me.btnNew = New System.Windows.Forms.Button()
            Me.btnSave = New System.Windows.Forms.Button()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.txtCostPerUnit = New System.Windows.Forms.TextBox()
            Me.btnGridUpdate = New System.Windows.Forms.Button()
            Me.lblUnit = New System.Windows.Forms.Label()
            Me.txtTotalItemCost = New System.Windows.Forms.TextBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.cmbProductName = New System.Windows.Forms.ComboBox()
            Me.btnRemove = New System.Windows.Forms.Button()
            Me.btnAdd = New System.Windows.Forms.Button()
            Me.txtQty = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.btnClose = New System.Windows.Forms.Button()
            Me.dgw = New System.Windows.Forms.DataGridView()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.txtID = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.lblSet = New System.Windows.Forms.Label()
            Me.txtProductID = New System.Windows.Forms.TextBox()
            Me.lblUser = New System.Windows.Forms.Label()
            Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.Button1 = New System.Windows.Forms.Button()
            Me.Panel1.SuspendLayout()
            Me.GroupBox4.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel2.SuspendLayout()
            MyBase.SuspendLayout()
            Me.Panel1.BackColor = System.Drawing.Color.White
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.Label8)
            Me.Panel1.Controls.Add(Me.txtDescription)
            Me.Panel1.Controls.Add(Me.GroupBox4)
            Me.Panel1.Controls.Add(Me.GroupBox3)
            Me.Panel1.Controls.Add(Me.GroupBox2)
            Me.Panel1.Controls.Add(Me.btnClose)
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
            Me.Label8.AutoSize = True
            Dim label As System.Windows.Forms.Label = Me.Label8
            location = New System.Drawing.Point(451, 44)
            label.Location = location
            Me.Label8.Name = "Label8"
            Dim label2 As System.Windows.Forms.Label = Me.Label8
            size = New System.Drawing.Size(66, 13)
            label2.Size = size
            Me.Label8.TabIndex = 21
            Me.Label8.Text = "Description :"
            Dim richTextBox As System.Windows.Forms.RichTextBox = Me.txtDescription
            location = New System.Drawing.Point(454, 66)
            richTextBox.Location = location
            Me.txtDescription.Name = "txtDescription"
            Dim richTextBox2 As System.Windows.Forms.RichTextBox = Me.txtDescription
            size = New System.Drawing.Size(446, 485)
            richTextBox2.Size = size
            Me.txtDescription.TabIndex = 2
            Me.txtDescription.Text = ""
            Me.GroupBox4.Controls.Add(Me.Button1)
            Me.GroupBox4.Controls.Add(Me.txtTotalCost)
            Me.GroupBox4.Controls.Add(Me.Label10)
            Me.GroupBox4.Controls.Add(Me.txtCategory)
            Me.GroupBox4.Controls.Add(Me.Label5)
            Me.GroupBox4.Controls.Add(Me.txtRecipeName)
            Me.GroupBox4.Controls.Add(Me.Label7)
            Me.GroupBox4.Controls.Add(Me.cmbItemName)
            Me.GroupBox4.Controls.Add(Me.Label6)
            Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim groupBox As System.Windows.Forms.GroupBox = Me.GroupBox4
            location = New System.Drawing.Point(4, 39)
            groupBox.Location = location
            Me.GroupBox4.Name = "GroupBox4"
            Dim groupBox2 As System.Windows.Forms.GroupBox = Me.GroupBox4
            size = New System.Drawing.Size(381, 145)
            groupBox2.Size = size
            Me.GroupBox4.TabIndex = 0
            Me.GroupBox4.TabStop = False
            Me.GroupBox4.Text = "Recipe Info"
            Dim textBox As System.Windows.Forms.TextBox = Me.txtTotalCost
            location = New System.Drawing.Point(118, 108)
            textBox.Location = location
            Me.txtTotalCost.Name = "txtTotalCost"
            Me.txtTotalCost.[ReadOnly] = True
            Dim textBox2 As System.Windows.Forms.TextBox = Me.txtTotalCost
            size = New System.Drawing.Size(103, 21)
            textBox2.Size = size
            Me.txtTotalCost.TabIndex = 3
            Me.txtTotalCost.Text = "0.00"
            Me.txtTotalCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.Label10.AutoSize = True
            Dim label3 As System.Windows.Forms.Label = Me.Label10
            location = New System.Drawing.Point(10, 110)
            label3.Location = location
            Me.Label10.Name = "Label10"
            Dim label4 As System.Windows.Forms.Label = Me.Label10
            size = New System.Drawing.Size(67, 15)
            label4.Size = size
            Me.Label10.TabIndex = 20
            Me.Label10.Text = "Total Cost :"
            Dim textBox3 As System.Windows.Forms.TextBox = Me.txtCategory
            location = New System.Drawing.Point(118, 81)
            textBox3.Location = location
            Me.txtCategory.Name = "txtCategory"
            Me.txtCategory.[ReadOnly] = True
            Dim textBox4 As System.Windows.Forms.TextBox = Me.txtCategory
            size = New System.Drawing.Size(253, 21)
            textBox4.Size = size
            Me.txtCategory.TabIndex = 2
            Me.Label5.AutoSize = True
            Dim label5 As System.Windows.Forms.Label = Me.Label5
            location = New System.Drawing.Point(10, 81)
            label5.Location = location
            Me.Label5.Name = "Label5"
            Dim label6 As System.Windows.Forms.Label = Me.Label5
            size = New System.Drawing.Size(61, 15)
            label6.Size = size
            Me.Label5.TabIndex = 18
            Me.Label5.Text = "Category :"
            Dim textBox5 As System.Windows.Forms.TextBox = Me.txtRecipeName
            location = New System.Drawing.Point(118, 27)
            textBox5.Location = location
            Me.txtRecipeName.Name = "txtRecipeName"
            Dim textBox6 As System.Windows.Forms.TextBox = Me.txtRecipeName
            size = New System.Drawing.Size(253, 21)
            textBox6.Size = size
            Me.txtRecipeName.TabIndex = 0
            Me.Label7.AutoSize = True
            Dim label7 As System.Windows.Forms.Label = Me.Label7
            location = New System.Drawing.Point(10, 27)
            label7.Location = location
            Me.Label7.Name = "Label7"
            Dim label8 As System.Windows.Forms.Label = Me.Label7
            size = New System.Drawing.Size(89, 15)
            label8.Size = size
            Me.Label7.TabIndex = 16
            Me.Label7.Text = "Recipe Name :"
            Me.cmbItemName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
            Me.cmbItemName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
            Me.cmbItemName.FormattingEnabled = True
            Dim comboBox As System.Windows.Forms.ComboBox = Me.cmbItemName
            location = New System.Drawing.Point(118, 53)
            comboBox.Location = location
            Me.cmbItemName.Name = "cmbItemName"
            Dim comboBox2 As System.Windows.Forms.ComboBox = Me.cmbItemName
            size = New System.Drawing.Size(220, 23)
            comboBox2.Size = size
            Me.cmbItemName.TabIndex = 1
            Me.Label6.AutoSize = True
            Dim label9 As System.Windows.Forms.Label = Me.Label6
            location = New System.Drawing.Point(10, 53)
            label9.Location = location
            Me.Label6.Name = "Label6"
            Dim label10 As System.Windows.Forms.Label = Me.Label6
            size = New System.Drawing.Size(74, 15)
            label10.Size = size
            Me.Label6.TabIndex = 10
            Me.Label6.Text = "Item Name :"
            Me.GroupBox3.Controls.Add(Me.btnUpdate)
            Me.GroupBox3.Controls.Add(Me.btnGetData)
            Me.GroupBox3.Controls.Add(Me.btnPrint)
            Me.GroupBox3.Controls.Add(Me.btnDelete)
            Me.GroupBox3.Controls.Add(Me.btnNew)
            Me.GroupBox3.Controls.Add(Me.btnSave)
            Dim groupBox3 As System.Windows.Forms.GroupBox = Me.GroupBox3
            location = New System.Drawing.Point(906, 50)
            groupBox3.Location = location
            Me.GroupBox3.Name = "GroupBox3"
            Dim groupBox4 As System.Windows.Forms.GroupBox = Me.GroupBox3
            size = New System.Drawing.Size(99, 272)
            groupBox4.Size = size
            Me.GroupBox3.TabIndex = 4
            Me.GroupBox3.TabStop = False
            Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnUpdate.Image = CType(componentResourceManager.GetObject("btnUpdate.Image"), System.Drawing.Image)
            Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
            Dim button As System.Windows.Forms.Button = Me.btnUpdate
            location = New System.Drawing.Point(8, 99)
            button.Location = location
            Me.btnUpdate.Name = "btnUpdate"
            Dim button2 As System.Windows.Forms.Button = Me.btnUpdate
            size = New System.Drawing.Size(82, 37)
            button2.Size = size
            Me.btnUpdate.TabIndex = 10
            Me.btnUpdate.Text = "Update"
            Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnUpdate.UseVisualStyleBackColor = True
            Me.btnGetData.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnGetData.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnGetData.Image = CType(componentResourceManager.GetObject("btnGetData.Image"), System.Drawing.Image)
            Me.btnGetData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button3 As System.Windows.Forms.Button = Me.btnGetData
            location = New System.Drawing.Point(6, 224)
            button3.Location = location
            Me.btnGetData.Name = "btnGetData"
            Dim button4 As System.Windows.Forms.Button = Me.btnGetData
            size = New System.Drawing.Size(84, 34)
            button4.Size = size
            Me.btnGetData.TabIndex = 9
            Me.btnGetData.Text = "Get Data"
            Me.btnGetData.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnGetData.UseVisualStyleBackColor = True
            Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnPrint.Enabled = False
            Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnPrint.Image = CType(componentResourceManager.GetObject("btnPrint.Image"), System.Drawing.Image)
            Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button5 As System.Windows.Forms.Button = Me.btnPrint
            location = New System.Drawing.Point(8, 182)
            button5.Location = location
            Me.btnPrint.Name = "btnPrint"
            Dim button6 As System.Windows.Forms.Button = Me.btnPrint
            size = New System.Drawing.Size(82, 37)
            button6.Size = size
            Me.btnPrint.TabIndex = 8
            Me.btnPrint.Text = "Print"
            Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnPrint.UseVisualStyleBackColor = True
            Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnDelete.Image = CType(componentResourceManager.GetObject("btnDelete.Image"), System.Drawing.Image)
            Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button7 As System.Windows.Forms.Button = Me.btnDelete
            location = New System.Drawing.Point(8, 140)
            button7.Location = location
            Me.btnDelete.Name = "btnDelete"
            Dim button8 As System.Windows.Forms.Button = Me.btnDelete
            size = New System.Drawing.Size(82, 37)
            button8.Size = size
            Me.btnDelete.TabIndex = 3
            Me.btnDelete.Text = "Delete"
            Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnDelete.UseVisualStyleBackColor = True
            Me.btnNew.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnNew.Image = CType(componentResourceManager.GetObject("btnNew.Image"), System.Drawing.Image)
            Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button9 As System.Windows.Forms.Button = Me.btnNew
            location = New System.Drawing.Point(8, 15)
            button9.Location = location
            Me.btnNew.Name = "btnNew"
            Dim button10 As System.Windows.Forms.Button = Me.btnNew
            size = New System.Drawing.Size(82, 37)
            button10.Size = size
            Me.btnNew.TabIndex = 0
            Me.btnNew.Text = "New"
            Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnNew.UseVisualStyleBackColor = True
            Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnSave.Image = CType(componentResourceManager.GetObject("btnSave.Image"), System.Drawing.Image)
            Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button11 As System.Windows.Forms.Button = Me.btnSave
            location = New System.Drawing.Point(8, 57)
            button11.Location = location
            Me.btnSave.Name = "btnSave"
            Dim button12 As System.Windows.Forms.Button = Me.btnSave
            size = New System.Drawing.Size(82, 37)
            button12.Size = size
            Me.btnSave.TabIndex = 1
            Me.btnSave.Text = "Save"
            Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnSave.UseVisualStyleBackColor = True
            Me.GroupBox2.Controls.Add(Me.Label9)
            Me.GroupBox2.Controls.Add(Me.txtCostPerUnit)
            Me.GroupBox2.Controls.Add(Me.btnGridUpdate)
            Me.GroupBox2.Controls.Add(Me.lblUnit)
            Me.GroupBox2.Controls.Add(Me.txtTotalItemCost)
            Me.GroupBox2.Controls.Add(Me.Label4)
            Me.GroupBox2.Controls.Add(Me.cmbProductName)
            Me.GroupBox2.Controls.Add(Me.btnRemove)
            Me.GroupBox2.Controls.Add(Me.btnAdd)
            Me.GroupBox2.Controls.Add(Me.txtQty)
            Me.GroupBox2.Controls.Add(Me.Label2)
            Me.GroupBox2.Controls.Add(Me.Label3)
            Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim groupBox5 As System.Windows.Forms.GroupBox = Me.GroupBox2
            location = New System.Drawing.Point(3, 190)
            groupBox5.Location = location
            Me.GroupBox2.Name = "GroupBox2"
            Dim groupBox6 As System.Windows.Forms.GroupBox = Me.GroupBox2
            size = New System.Drawing.Size(445, 151)
            groupBox6.Size = size
            Me.GroupBox2.TabIndex = 1
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Product Info"
            Me.Label9.AutoSize = True
            Dim label11 As System.Windows.Forms.Label = Me.Label9
            location = New System.Drawing.Point(11, 84)
            label11.Location = location
            Me.Label9.Name = "Label9"
            Dim label12 As System.Windows.Forms.Label = Me.Label9
            size = New System.Drawing.Size(84, 15)
            label12.Size = size
            Me.Label9.TabIndex = 12
            Me.Label9.Text = "Cost Per Unit :"
            Me.txtCostPerUnit.BackColor = System.Drawing.Color.White
            Me.txtCostPerUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox7 As System.Windows.Forms.TextBox = Me.txtCostPerUnit
            location = New System.Drawing.Point(109, 84)
            textBox7.Location = location
            Me.txtCostPerUnit.Name = "txtCostPerUnit"
            Dim textBox8 As System.Windows.Forms.TextBox = Me.txtCostPerUnit
            size = New System.Drawing.Size(120, 21)
            textBox8.Size = size
            Me.txtCostPerUnit.TabIndex = 2
            Me.txtCostPerUnit.Text = "0.00"
            Me.txtCostPerUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.btnGridUpdate.BackColor = System.Drawing.SystemColors.Control
            Me.btnGridUpdate.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnGridUpdate.Enabled = False
            Me.btnGridUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnGridUpdate.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnGridUpdate.ForeColor = System.Drawing.Color.Black
            Me.btnGridUpdate.Image = CType(componentResourceManager.GetObject("btnGridUpdate.Image"), System.Drawing.Image)
            Me.btnGridUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button13 As System.Windows.Forms.Button = Me.btnGridUpdate
            location = New System.Drawing.Point(345, 105)
            button13.Location = location
            Me.btnGridUpdate.Name = "btnGridUpdate"
            Dim button14 As System.Windows.Forms.Button = Me.btnGridUpdate
            size = New System.Drawing.Size(90, 37)
            button14.Size = size
            Me.btnGridUpdate.TabIndex = 6
            Me.btnGridUpdate.Text = "Update"
            Me.btnGridUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnGridUpdate.UseVisualStyleBackColor = False
            Me.lblUnit.AutoSize = True
            Dim label13 As System.Windows.Forms.Label = Me.lblUnit
            location = New System.Drawing.Point(236, 60)
            label13.Location = location
            Me.lblUnit.Name = "lblUnit"
            Dim label14 As System.Windows.Forms.Label = Me.lblUnit
            size = New System.Drawing.Size(29, 15)
            label14.Size = size
            Me.lblUnit.TabIndex = 9
            Me.lblUnit.Text = "Unit"
            Dim textBox9 As System.Windows.Forms.TextBox = Me.txtTotalItemCost
            location = New System.Drawing.Point(109, 111)
            textBox9.Location = location
            Me.txtTotalItemCost.Name = "txtTotalItemCost"
            Me.txtTotalItemCost.[ReadOnly] = True
            Dim textBox10 As System.Windows.Forms.TextBox = Me.txtTotalItemCost
            size = New System.Drawing.Size(120, 21)
            textBox10.Size = size
            Me.txtTotalItemCost.TabIndex = 3
            Me.txtTotalItemCost.Text = "0.00"
            Me.txtTotalItemCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.Label4.AutoSize = True
            Dim label15 As System.Windows.Forms.Label = Me.Label4
            location = New System.Drawing.Point(11, 111)
            label15.Location = location
            Me.Label4.Name = "Label4"
            Dim label16 As System.Windows.Forms.Label = Me.Label4
            size = New System.Drawing.Size(94, 15)
            label16.Size = size
            Me.Label4.TabIndex = 8
            Me.Label4.Text = "Total Item Cost :"
            Me.cmbProductName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
            Me.cmbProductName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
            Me.cmbProductName.FormattingEnabled = True
            Dim comboBox3 As System.Windows.Forms.ComboBox = Me.cmbProductName
            location = New System.Drawing.Point(109, 26)
            comboBox3.Location = location
            Me.cmbProductName.Name = "cmbProductName"
            Dim comboBox4 As System.Windows.Forms.ComboBox = Me.cmbProductName
            size = New System.Drawing.Size(230, 23)
            comboBox4.Size = size
            Me.cmbProductName.TabIndex = 0
            Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnRemove.Image = CType(componentResourceManager.GetObject("btnRemove.Image"), System.Drawing.Image)
            Me.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button15 As System.Windows.Forms.Button = Me.btnRemove
            location = New System.Drawing.Point(345, 65)
            button15.Location = location
            Me.btnRemove.Name = "btnRemove"
            Dim button16 As System.Windows.Forms.Button = Me.btnRemove
            size = New System.Drawing.Size(90, 34)
            button16.Size = size
            Me.btnRemove.TabIndex = 5
            Me.btnRemove.Text = "&Remove"
            Me.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnRemove.UseVisualStyleBackColor = True
            Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnAdd.Image = CType(componentResourceManager.GetObject("btnAdd.Image"), System.Drawing.Image)
            Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button17 As System.Windows.Forms.Button = Me.btnAdd
            location = New System.Drawing.Point(345, 26)
            button17.Location = location
            Me.btnAdd.Name = "btnAdd"
            Dim button18 As System.Windows.Forms.Button = Me.btnAdd
            size = New System.Drawing.Size(90, 34)
            button18.Size = size
            Me.btnAdd.TabIndex = 4
            Me.btnAdd.Text = "&Add"
            Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnAdd.UseVisualStyleBackColor = True
            Me.txtQty.BackColor = System.Drawing.Color.White
            Me.txtQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox11 As System.Windows.Forms.TextBox = Me.txtQty
            location = New System.Drawing.Point(109, 55)
            textBox11.Location = location
            Me.txtQty.Name = "txtQty"
            Dim textBox12 As System.Windows.Forms.TextBox = Me.txtQty
            size = New System.Drawing.Size(120, 21)
            textBox12.Size = size
            Me.txtQty.TabIndex = 1
            Me.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.Label2.AutoSize = True
            Dim label17 As System.Windows.Forms.Label = Me.Label2
            location = New System.Drawing.Point(11, 55)
            label17.Location = location
            Me.Label2.Name = "Label2"
            Dim label18 As System.Windows.Forms.Label = Me.Label2
            size = New System.Drawing.Size(57, 15)
            label18.Size = size
            Me.Label2.TabIndex = 5
            Me.Label2.Text = "Quantity :"
            Me.Label3.AutoSize = True
            Dim label19 As System.Windows.Forms.Label = Me.Label3
            location = New System.Drawing.Point(11, 26)
            label19.Location = location
            Me.Label3.Name = "Label3"
            Dim label20 As System.Windows.Forms.Label = Me.Label3
            size = New System.Drawing.Size(92, 15)
            label20.Size = size
            Me.Label3.TabIndex = 0
            Me.Label3.Text = "Product Name :"
            Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnClose.Image = CType(componentResourceManager.GetObject("btnClose.Image"), System.Drawing.Image)
            Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button19 As System.Windows.Forms.Button = Me.btnClose
            location = New System.Drawing.Point(923, 4)
            button19.Location = location
            Me.btnClose.Name = "btnClose"
            Dim button20 As System.Windows.Forms.Button = Me.btnClose
            size = New System.Drawing.Size(82, 44)
            button20.Size = size
            Me.btnClose.TabIndex = 4
            Me.btnClose.Text = "Close"
            Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnClose.UseVisualStyleBackColor = True
            Me.dgw.AllowUserToAddRows = False
            Me.dgw.AllowUserToDeleteRows = False
            dataGridViewCellStyle.BackColor = System.Drawing.Color.FloralWhite
            Me.dgw.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle
            Me.dgw.BackgroundColor = System.Drawing.Color.White
            Me.dgw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            dataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgw.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2
            Me.dgw.ColumnHeadersHeight = 30
            Me.dgw.Columns.AddRange(Me.Column2, Me.Column3, Me.Column5, Me.Column1, Me.Column6)
            Me.dgw.Cursor = System.Windows.Forms.Cursors.Hand
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            dataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgw.DefaultCellStyle = dataGridViewCellStyle3
            Me.dgw.EnableHeadersVisualStyles = False
            Me.dgw.GridColor = System.Drawing.Color.White
            Dim dataGridView As System.Windows.Forms.DataGridView = Me.dgw
            location = New System.Drawing.Point(4, 347)
            dataGridView.Location = location
            Me.dgw.MultiSelect = False
            Me.dgw.Name = "dgw"
            Me.dgw.[ReadOnly] = True
            Me.dgw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White
            dataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gainsboro
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgw.RowHeadersDefaultCellStyle = dataGridViewCellStyle4
            Me.dgw.RowHeadersWidth = 25
            Me.dgw.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White
            dataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gainsboro
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
            Me.dgw.RowsDefaultCellStyle = dataGridViewCellStyle5
            Me.dgw.RowTemplate.Height = 18
            Me.dgw.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgw.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Dim dataGridView2 As System.Windows.Forms.DataGridView = Me.dgw
            size = New System.Drawing.Size(445, 204)
            dataGridView2.Size = size
            Me.dgw.TabIndex = 1
            Me.Column2.HeaderText = "Product ID"
            Me.Column2.Name = "Column2"
            Me.Column2.[ReadOnly] = True
            Me.Column2.Visible = False
            Me.Column3.HeaderText = "Product Name"
            Me.Column3.Name = "Column3"
            Me.Column3.[ReadOnly] = True
            Me.Column3.Width = 215
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.Column5.DefaultCellStyle = dataGridViewCellStyle6
            Me.Column5.HeaderText = "Qty."
            Me.Column5.Name = "Column5"
            Me.Column5.[ReadOnly] = True
            Me.Column5.Width = 60
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.Column1.DefaultCellStyle = dataGridViewCellStyle7
            Me.Column1.HeaderText = "Cost Per Unit"
            Me.Column1.Name = "Column1"
            Me.Column1.[ReadOnly] = True
            Me.Column1.Width = 70
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.Column6.DefaultCellStyle = dataGridViewCellStyle8
            Me.Column6.HeaderText = "Total Item Cost"
            Me.Column6.Name = "Column6"
            Me.Column6.[ReadOnly] = True
            Me.Column6.Width = 70
            Me.Panel2.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Panel2.Controls.Add(Me.txtID)
            Me.Panel2.Controls.Add(Me.Label1)
            Me.Panel2.Controls.Add(Me.lblSet)
            Me.Panel2.Controls.Add(Me.txtProductID)
            Me.Panel2.Controls.Add(Me.lblUser)
            Dim panel3 As System.Windows.Forms.Panel = Me.Panel2
            location = New System.Drawing.Point(4, 4)
            panel3.Location = location
            Me.Panel2.Name = "Panel2"
            Dim panel4 As System.Windows.Forms.Panel = Me.Panel2
            size = New System.Drawing.Size(913, 28)
            panel4.Size = size
            Me.Panel2.TabIndex = 0
            Dim textBox13 As System.Windows.Forms.TextBox = Me.txtID
            location = New System.Drawing.Point(97, 3)
            textBox13.Location = location
            Me.txtID.Name = "txtID"
            Me.txtID.[ReadOnly] = True
            Dim textBox14 As System.Windows.Forms.TextBox = Me.txtID
            size = New System.Drawing.Size(38, 20)
            textBox14.Size = size
            Me.txtID.TabIndex = 0
            Me.txtID.Visible = False
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label1.ForeColor = System.Drawing.Color.White
            Dim label21 As System.Windows.Forms.Label = Me.Label1
            location = New System.Drawing.Point(421, 0)
            label21.Location = location
            Me.Label1.Name = "Label1"
            Dim label22 As System.Windows.Forms.Label = Me.Label1
            size = New System.Drawing.Size(76, 24)
            label22.Size = size
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Recipe"
            Me.lblSet.AutoSize = True
            Dim label23 As System.Windows.Forms.Label = Me.lblSet
            location = New System.Drawing.Point(207, 7)
            label23.Location = location
            Me.lblSet.Name = "lblSet"
            Dim label24 As System.Windows.Forms.Label = Me.lblSet
            size = New System.Drawing.Size(23, 13)
            label24.Size = size
            Me.lblSet.TabIndex = 47
            Me.lblSet.Text = "Set"
            Me.lblSet.Visible = False
            Dim textBox15 As System.Windows.Forms.TextBox = Me.txtProductID
            location = New System.Drawing.Point(324, 4)
            textBox15.Location = location
            Me.txtProductID.Name = "txtProductID"
            Dim textBox16 As System.Windows.Forms.TextBox = Me.txtProductID
            size = New System.Drawing.Size(47, 20)
            textBox16.Size = size
            Me.txtProductID.TabIndex = 50
            Me.txtProductID.Visible = False
            Me.lblUser.AutoSize = True
            Dim label25 As System.Windows.Forms.Label = Me.lblUser
            location = New System.Drawing.Point(255, 7)
            label25.Location = location
            Me.lblUser.Name = "lblUser"
            Dim label26 As System.Windows.Forms.Label = Me.lblUser
            size = New System.Drawing.Size(39, 13)
            label26.Size = size
            Me.lblUser.TabIndex = 5
            Me.lblUser.Text = "Label8"
            Me.lblUser.Visible = False
            Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.Button1.Image = RestaurantPOS14.My.Resources.Resources._1__2_
            Dim button21 As System.Windows.Forms.Button = Me.Button1
            location = New System.Drawing.Point(340, 53)
            button21.Location = location
            Me.Button1.Name = "Button1"
            Dim button22 As System.Windows.Forms.Button = Me.Button1
            size = New System.Drawing.Size(31, 23)
            button22.Size = size
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
            MyBase.Name = "frmRecipe"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
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
