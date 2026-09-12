Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports MetroFramework
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public Class frmCreditCustomerRegistration
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel1")>
        Private _Panel1 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel4")>
        Private _Panel4 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label3")>
        Private _Label3 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtAccountNo")>
        Private _txtAccountNo As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel3")>
        Private _Panel3 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("dgw")>
        Private _dgw As System.Windows.Forms.DataGridView

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label1")>
        Private _Label1 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label7")>
        Private _Label7 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label6")>
        Private _Label6 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label5")>
        Private _Label5 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtContactNo")>
        Private _txtContactNo As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtCreditCustomerName")>
        Private _txtCreditCustomerName As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblUser")>
        Private _lblUser As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label8")>
        Private _Label8 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("chkActive")>
        Private _chkActive As System.Windows.Forms.CheckBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnNew")>
        Private _btnNew As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnUpdate")>
        Private _btnUpdate As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnDelete")>
        Private _btnDelete As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnSave")>
        Private _btnSave As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtAddress")>
        Private _txtAddress As System.Windows.Forms.RichTextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox1")>
        Private _GroupBox1 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtSearchByCreditCustomerName")>
        Private _txtSearchByCreditCustomerName As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtCustName")>
        Private _txtCustName As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtCC_ID")>
        Private _txtCC_ID As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel2")>
        Private _Panel2 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnCancel")>
        Private _btnCancel As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("cmbOpeningBalanceType")>
        Private _cmbOpeningBalanceType As System.Windows.Forms.ComboBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label15")>
        Private _Label15 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtOpeningBalance")>
        Private _txtOpeningBalance As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column1")>
        Private _Column1 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Description")>
        Private _Description As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column3")>
        Private _Column3 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column2")>
        Private _Column2 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column4")>
        Private _Column4 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column7")>
        Private _Column7 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column5")>
        Private _Column5 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column6")>
        Private _Column6 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox2")>
        Private _GroupBox2 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtSearchByACNo")>
        Private _txtSearchByACNo As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtACNo")>
        Private _txtACNo As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblSet")>
        Private _lblSet As System.Windows.Forms.Label

        Private st1 As String

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

        Friend Overridable Property Panel4 As System.Windows.Forms.Panel
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Panel4
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Panel)
                Me._Panel4 = value
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

        Friend Overridable Property txtAccountNo As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtAccountNo
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtAccountNo = value
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

        Friend Overridable Property txtCreditCustomerName As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtCreditCustomerName
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtCreditCustomerName = value
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

        Friend Overridable Property chkActive As System.Windows.Forms.CheckBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._chkActive
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.CheckBox)
                Me._chkActive = value
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

        Friend Overridable Property btnDelete As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnDelete
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.Button2_Click
                If Me._btnDelete IsNot Nothing Then
                    RemoveHandler Me._btnDelete.Click, value2
                End If

                Me._btnDelete = value
                If Me._btnDelete IsNot Nothing Then
                    AddHandler Me._btnDelete.Click, value2
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

        Friend Overridable Property txtAddress As System.Windows.Forms.RichTextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtAddress
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.RichTextBox)
                Me._txtAddress = value
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

        Friend Overridable Property txtSearchByCreditCustomerName As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtSearchByCreditCustomerName
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.EventHandler = AddressOf Me.txtSearchByCreditCustomerName_TextChanged
                If Me._txtSearchByCreditCustomerName IsNot Nothing Then
                    RemoveHandler Me._txtSearchByCreditCustomerName.TextChanged, value2
                End If

                Me._txtSearchByCreditCustomerName = value
                If Me._txtSearchByCreditCustomerName IsNot Nothing Then
                    AddHandler Me._txtSearchByCreditCustomerName.TextChanged, value2
                End If
            End Set
        End Property

        Friend Overridable Property txtCustName As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtCustName
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtCustName = value
            End Set
        End Property

        Friend Overridable Property txtCC_ID As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtCC_ID
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtCC_ID = value
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

        Friend Overridable Property cmbOpeningBalanceType As System.Windows.Forms.ComboBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._cmbOpeningBalanceType
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ComboBox)
                Me._cmbOpeningBalanceType = value
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

        Friend Overridable Property txtOpeningBalance As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtOpeningBalance
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.Windows.Forms.KeyPressEventHandler = AddressOf Me.txtOpeningBalance_KeyPress
                If Me._txtOpeningBalance IsNot Nothing Then
                    RemoveHandler Me._txtOpeningBalance.KeyPress, value2
                End If

                Me._txtOpeningBalance = value
                If Me._txtOpeningBalance IsNot Nothing Then
                    AddHandler Me._txtOpeningBalance.KeyPress, value2
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

        Friend Overridable Property Description As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Description
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._Description = value
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

        Friend Overridable Property txtSearchByACNo As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtSearchByACNo
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.EventHandler = AddressOf Me.txtSearchByACNo_TextChanged
                If Me._txtSearchByACNo IsNot Nothing Then
                    RemoveHandler Me._txtSearchByACNo.TextChanged, value2
                End If

                Me._txtSearchByACNo = value
                If Me._txtSearchByACNo IsNot Nothing Then
                    AddHandler Me._txtSearchByACNo.TextChanged, value2
                End If
            End Set
        End Property

        Friend Overridable Property txtACNo As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtACNo
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtACNo = value
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

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            AddHandler MyBase.Load, AddressOf Me.frmCreditCustomerRegistration_Load
            Call RestaurantPOS14.frmCreditCustomerRegistration.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmCreditCustomerRegistration.__ENCList
                If RestaurantPOS14.frmCreditCustomerRegistration.__ENCList.Count = RestaurantPOS14.frmCreditCustomerRegistration.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmCreditCustomerRegistration.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmCreditCustomerRegistration.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmCreditCustomerRegistration.__ENCList(num) = RestaurantPOS14.frmCreditCustomerRegistration.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmCreditCustomerRegistration.__ENCList.RemoveRange(num, RestaurantPOS14.frmCreditCustomerRegistration.__ENCList.Count - num)
                    RestaurantPOS14.frmCreditCustomerRegistration.__ENCList.Capacity = RestaurantPOS14.frmCreditCustomerRegistration.__ENCList.Count
                End If

                Call RestaurantPOS14.frmCreditCustomerRegistration.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Public Sub Reset()
            Me.txtContactNo.Text = ""
            Me.txtSearchByACNo.Text = ""
            Me.txtCreditCustomerName.Text = ""
            Me.txtAddress.Text = ""
            Me.txtSearchByCreditCustomerName.Text = ""
            Me.chkActive.Checked = True
            Me.cmbOpeningBalanceType.SelectedIndex = 0
            Me.txtOpeningBalance.Text = "0.00"
            Me.cmbOpeningBalanceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbOpeningBalanceType.Enabled = True
            Me.txtOpeningBalance.[ReadOnly] = False
            Me.txtAccountNo.Text = ""
            Me.txtAccountNo.Focus()
            If RestaurantPOS14.ModFunc.IsSaveAllowed(Me.lblUser.Text, "Credit Customer") Then
                Me.btnSave.Enabled = True
            Else
                Me.btnSave.Enabled = False
            End If

            If RestaurantPOS14.ModFunc.IsViewAllowed(Me.lblUser.Text, "Credit Customer") Then
                Me.Getdata()
                Me.GroupBox1.Enabled = True
                Me.GroupBox2.Enabled = True
            Else
                Me.dgw.Rows.Clear()
                Me.GroupBox1.Enabled = False
                Me.GroupBox2.Enabled = False
            End If

            Me.btnUpdate.Enabled = False
            Me.btnDelete.Enabled = False
            Me.txtACNo.Text = ""
            Me.auto()
        End Sub

        Private Sub DeleteRecord()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT CreditCustomerID FROM CreditCustomer INNER JOIN CreditCustomerPayment ON CreditCustomer.CC_ID = CreditCustomerPayment.CreditCustomer_ID where CreditCustomerID=@d1")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtAccountNo.Text)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    MetroFramework.MetroMessageBox.Show(Me, "Unable to delete..Already in use in Receipt Entry", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select CreditCustomerID from RestaurantPOS_BillingInfoEB,CreditCustomer where RestaurantPOS_BillingInfoEB.Member_ID=CreditCustomer.CreditCustomerID and CreditCustomerID=@d1")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtAccountNo.Text)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    MetroFramework.MetroMessageBox.Show(Me, "Unable to delete..Already in use in Restaurant POS", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select CreditCustomerID from RestaurantPOS_BillingInfoTA,CreditCustomer where RestaurantPOS_BillingInfoTA.Member_ID=CreditCustomer.CreditCustomerID and CreditCustomerID=@d1")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtAccountNo.Text)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    MetroFramework.MetroMessageBox.Show(Me, "Unable to delete..Already in use in Restaurant POS", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select CreditCustomerID from RestaurantPOS_BillingInfoHD,CreditCustomer where RestaurantPOS_BillingInfoHD.Member_ID=CreditCustomer.CreditCustomerID and CreditCustomerID=@d1")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtAccountNo.Text)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    MetroFramework.MetroMessageBox.Show(Me, "Unable to delete..Already in use in Restaurant POS", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select CreditCustomerID from RestaurantPOS_BillingInfoKOT,CreditCustomer where RestaurantPOS_BillingInfoKOT.Member_ID=CreditCustomer.CreditCustomerID and CreditCustomerID=@d1")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtAccountNo.Text)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    MetroFramework.MetroMessageBox.Show(Me, "Unable to delete..Already in use in Restaurant POS", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("delete from CreditCustomer where CC_id=" & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.txtCC_ID.Text)))
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                If RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery() > 0 Then
                    Dim st As String = "Deleted the CreditCustomer having Account No. '" & Me.txtAccountNo.Text & "'"
                    RestaurantPOS14.ModFunc.LogFunc(Me.lblUser.Text, st)
                    RestaurantPOS14.ModFunc.LedgerDelete(Me.txtAccountNo.Text, "Opening Balance")
                    MetroFramework.MetroMessageBox.Show(Me, "Successfully deleted", "Record", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    Me.Reset()
                Else
                    MetroFramework.MetroMessageBox.Show(Me, "No Record found", "Sorry", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    Me.Reset()
                End If

                If RestaurantPOS14.ModClasses.con.State = System.Data.ConnectionState.Open Then
                    RestaurantPOS14.ModClasses.con.Close()
                End If
            Catch ex As System.Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub Getdata()
            Try
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT CC_ID, RTRIM(CreditCustomerid), RTRIM(Name), RTRIM(Address), RTRIM(ContactNo),RTRIM(Active),RTRIM(Convert(nvarchar(50),OpeningBalance) + ' ' + Convert(Nvarchar(50),OpeningBalanceType)),RegistrationDate from CreditCustomer order by Name", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                Me.dgw.Rows.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Me.dgw.Rows.Add(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(0)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(1)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(2)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(3)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(4)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(5)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(6)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(7)))
                End While

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
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

        Private Sub dgw_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs)
            Try
                If Me.dgw.Rows.Count > 0 Then
                    If Me.dgw.SelectedRows.Count = 0 Then Return
                    Dim dataGridViewRow As System.Windows.Forms.DataGridViewRow = Me.dgw.SelectedRows(0)
                    Me.txtCC_ID.Text = dataGridViewRow.Cells(CInt((0))).Value.ToString()
                    Me.txtAccountNo.Text = dataGridViewRow.Cells(CInt((1))).Value.ToString()
                    Me.txtACNo.Text = dataGridViewRow.Cells(CInt((1))).Value.ToString()
                    Me.txtCreditCustomerName.Text = dataGridViewRow.Cells(CInt((2))).Value.ToString()
                    Me.txtCustName.Text = dataGridViewRow.Cells(CInt((2))).Value.ToString()
                    Me.txtAddress.Text = dataGridViewRow.Cells(CInt((3))).Value.ToString()
                    Me.txtContactNo.Text = dataGridViewRow.Cells(CInt((4))).Value.ToString()
                    If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dataGridViewRow.Cells(CInt((5))).Value.ToString(), "Yes", TextCompare:=False) = 0 Then
                        Me.chkActive.Checked = True
                    Else
                        Me.chkActive.Checked = False
                    End If

                    Dim array As String() = dataGridViewRow.Cells(CInt((6))).Value.ToString().Split(" "c)
                    Me.txtOpeningBalance.Text = array(0)
                    Me.cmbOpeningBalanceType.Text = array(1)
                    If RestaurantPOS14.ModFunc.IsDeleteAllowed(Me.lblUser.Text, "Credit Customer") Then
                        Me.btnDelete.Enabled = True
                    Else
                        Me.btnDelete.Enabled = False
                    End If

                    If RestaurantPOS14.ModFunc.IsUpdateAllowed(Me.lblUser.Text, "Credit Customer") Then
                        Me.btnUpdate.Enabled = True
                    Else
                        Me.btnUpdate.Enabled = False
                    End If

                    Me.btnSave.Enabled = False
                    Me.cmbOpeningBalanceType.Enabled = False
                    Me.txtOpeningBalance.[ReadOnly] = True
                End If
            Catch ex As System.Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnUpdate_Click(sender As Object, e As System.EventArgs)
            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtAccountNo.Text, "", TextCompare:=False) = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "Please enter account no.", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtAccountNo.Focus()
                Return
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtCreditCustomerName.Text, "", TextCompare:=False) = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "Please enter CreditCustomer name", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtCreditCustomerName.Focus()
                Return
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtContactNo.Text, "", TextCompare:=False) = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "Please enter contact no.", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtContactNo.Focus()
                Return
            End If

            Try
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtAccountNo.Text, Me.txtACNo.Text, TextCompare:=False) <> 0 Then
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT CreditCustomerID from CreditCustomer where CreditCustomerID=@d1")
                    RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtAccountNo.Text)
                    RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                    If RestaurantPOS14.ModClasses.rdr.Read() Then
                        MetroFramework.MetroMessageBox.Show(Me, "Account No. already exists", "Input Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                        Me.txtAccountNo.Text = ""
                        Me.txtAccountNo.Focus()
                        If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                            RestaurantPOS14.ModClasses.rdr.Close()
                        End If

                        Return
                    End If

                    RestaurantPOS14.ModClasses.con.Close()
                End If

                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("update LedgerBook set Name=@d3 where PartyID=@d1 and Name=@d2")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtAccountNo.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Me.txtCustName.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Me.txtCreditCustomerName.Text)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                RestaurantPOS14.ModClasses.con.Close()
                If Me.chkActive.Checked Then
                    Me.st1 = "Yes"
                Else
                    Me.st1 = "No"
                End If

                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Update CreditCustomer set CreditCustomerID=@d1, Name=@d2, ContactNo=@d3, Address=@d4, Active=@d5 where CC_ID=" & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.txtCC_ID.Text)))
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtAccountNo.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Me.txtCreditCustomerName.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Me.txtContactNo.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", Me.txtAddress.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d5", Me.st1)
                RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                RestaurantPOS14.ModClasses.con.Close()
                Dim st As String = "Updated the CreditCustomer having Account No. '" & Me.txtAccountNo.Text & "'"
                RestaurantPOS14.ModFunc.LogFunc(Me.lblUser.Text, st)
                MetroFramework.MetroMessageBox.Show(Me, "Successfully updated", "Credit Customer Info", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                Me.btnUpdate.Enabled = False
                Me.Reset()
            Catch ex As System.Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub Button2_Click(sender As Object, e As System.EventArgs)
            Try
                If MetroFramework.MetroMessageBox.Show(Me, "Do you really want to delete this record?", "Confirmation", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Exclamation) = System.Windows.Forms.DialogResult.Yes Then
                    Me.DeleteRecord()
                End If
            Catch ex As System.Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Function GenerateID() As String
            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
            Dim text As String = "0000"
            Try
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT TOP 1 CC_ID FROM CreditCustomer ORDER BY CC_ID DESC", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                If RestaurantPOS14.ModClasses.rdr.HasRows Then
                    RestaurantPOS14.ModClasses.rdr.Read()
                    text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr("CC_ID"))
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
                Me.txtCC_ID.Text = Me.GenerateID()
                Me.txtAccountNo.Text = "CC-" & Me.GenerateID()
            Catch ex As System.Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnSave_Click(sender As Object, e As System.EventArgs)
            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtAccountNo.Text, "", TextCompare:=False) = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "Please enter account no.", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtAccountNo.Focus()
                Return
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtCreditCustomerName.Text, "", TextCompare:=False) = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "Please enter CreditCustomer name", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtCreditCustomerName.Focus()
                Return
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtContactNo.Text, "", TextCompare:=False) = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "Please enter contact no.", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtContactNo.Focus()
                Return
            End If

            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT CreditCustomerID from CreditCustomer where CreditCustomerID=@d1")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtAccountNo.Text)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    MetroFramework.MetroMessageBox.Show(Me, "Account No. already exists", "Input Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                    Me.txtAccountNo.Text = ""
                    Me.txtAccountNo.Focus()
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT Name from CreditCustomer where Name=@d1")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtCreditCustomerName.Text)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    MetroFramework.MetroMessageBox.Show(Me, "Name already exists", "Input Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                    Me.txtCreditCustomerName.Text = ""
                    Me.txtCreditCustomerName.Focus()
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                RestaurantPOS14.ModClasses.con.Close()
                Me.auto()
                If Me.chkActive.Checked Then
                    Me.st1 = "Yes"
                Else
                    Me.st1 = "No"
                End If

                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("insert into CreditCustomer(CC_ID,CreditCustomerID, Name, ContactNo, Address, RegistrationDate, Active,OpeningBalanceType,OpeningBalance) VALUES (" & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.txtCC_ID.Text)) & ",@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8)")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtAccountNo.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Me.txtCreditCustomerName.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Me.txtContactNo.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", Me.txtAddress.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d5", Microsoft.VisualBasic.DateAndTime.Now)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d6", Me.st1)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d7", Me.cmbOpeningBalanceType.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d8", Microsoft.VisualBasic.Conversion.Val(Me.txtOpeningBalance.Text))
                RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                RestaurantPOS14.ModClasses.con.Close()
                Dim st As String = "added the new CreditCustomer having Account No. '" & Me.txtAccountNo.Text & "'"
                RestaurantPOS14.ModFunc.LogFunc(Me.lblUser.Text, st)
                If(Me.cmbOpeningBalanceType.SelectedIndex = 0) And (Microsoft.VisualBasic.Conversion.Val(Me.txtOpeningBalance.Text) > 0.0) Then
                    RestaurantPOS14.ModFunc.LedgerSave(Microsoft.VisualBasic.DateAndTime.Today, Me.txtCreditCustomerName.Text, Me.txtAccountNo.Text, "Opening Balance", 0D, New Decimal(Microsoft.VisualBasic.Conversion.Val(Me.txtOpeningBalance.Text)), Me.txtAccountNo.Text, "Opening")
                End If

                If(Me.cmbOpeningBalanceType.SelectedIndex = 1) And (Microsoft.VisualBasic.Conversion.Val(Me.txtOpeningBalance.Text) > 0.0) Then
                    RestaurantPOS14.ModFunc.LedgerSave(Microsoft.VisualBasic.DateAndTime.Today, Me.txtCreditCustomerName.Text, Me.txtAccountNo.Text, "Opening Balance", New Decimal(Microsoft.VisualBasic.Conversion.Val(Me.txtOpeningBalance.Text)), 0D, Me.txtAccountNo.Text, "Opening")
                End If

                MetroFramework.MetroMessageBox.Show(Me, "Successfully Registered", "Credit Customer", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                Me.btnSave.Enabled = False
                Me.Reset()
            Catch ex As System.Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnNew_Click(sender As Object, e As System.EventArgs)
            Me.Reset()
        End Sub

        Private Sub txtSearchByCreditCustomerName_TextChanged(sender As Object, e As System.EventArgs)
            Try
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT CC_ID, RTRIM(CreditCustomerid), RTRIM(Name), RTRIM(Address), RTRIM(ContactNo),RTRIM(Active),RTRIM(Convert(nvarchar(50),OpeningBalance) + ' ' + Convert(Nvarchar(50),OpeningBalanceType)),RegistrationDate from CreditCustomer where Name like N'%" & RestaurantPOS14.Security.SqlInput.EscapeLiteral(Me.txtSearchByCreditCustomerName.Text) & "%' order by Name", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                Me.dgw.Rows.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Me.dgw.Rows.Add(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(0)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(1)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(2)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(3)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(4)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(5)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(6)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(7)))
                End While

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnCancel_Click(sender As Object, e As System.EventArgs)
            MyBase.Close()
        End Sub

        Private Sub txtOpeningBalance_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
            Dim keyChar As Char = e.KeyChar
            If Char.IsControl(keyChar) Then
                Return
            End If

            If Char.IsDigit(keyChar) OrElse keyChar = "."c Then
                Dim text As String = Me.txtOpeningBalance.Text
                Dim selectionStart As Integer = Me.txtOpeningBalance.SelectionStart
                Dim selectionLength As Integer = Me.txtOpeningBalance.SelectionLength
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

        Private Sub txtSearchByACNo_TextChanged(sender As Object, e As System.EventArgs)
            Try
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT CC_ID, RTRIM(CreditCustomerid), RTRIM(Name), RTRIM(Address), RTRIM(ContactNo),RTRIM(Active),RTRIM(Convert(nvarchar(50),OpeningBalance) + ' ' + Convert(Nvarchar(50),OpeningBalanceType)),RegistrationDate from CreditCustomer where CreditCustomerID like N'%" & RestaurantPOS14.Security.SqlInput.EscapeLiteral(Me.txtSearchByACNo.Text) & "%' order by Name", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                Me.dgw.Rows.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Me.dgw.Rows.Add(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(0)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(1)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(2)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(3)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(4)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(5)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(6)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(7)))
                End While

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub frmCreditCustomerRegistration_Load(sender As Object, e As System.EventArgs)
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmCreditCustomerRegistration))
            Dim dataGridViewCellStyle As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.btnDelete = New System.Windows.Forms.Button()
            Me.lblSet = New System.Windows.Forms.Label()
            Me.btnUpdate = New System.Windows.Forms.Button()
            Me.btnSave = New System.Windows.Forms.Button()
            Me.txtACNo = New System.Windows.Forms.TextBox()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.txtSearchByACNo = New System.Windows.Forms.TextBox()
            Me.btnNew = New System.Windows.Forms.Button()
            Me.lblUser = New System.Windows.Forms.Label()
            Me.txtCC_ID = New System.Windows.Forms.TextBox()
            Me.txtCustName = New System.Windows.Forms.TextBox()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.txtSearchByCreditCustomerName = New System.Windows.Forms.TextBox()
            Me.Panel4 = New System.Windows.Forms.Panel()
            Me.cmbOpeningBalanceType = New System.Windows.Forms.ComboBox()
            Me.Label15 = New System.Windows.Forms.Label()
            Me.txtOpeningBalance = New System.Windows.Forms.TextBox()
            Me.txtAddress = New System.Windows.Forms.RichTextBox()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.chkActive = New System.Windows.Forms.CheckBox()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.txtContactNo = New System.Windows.Forms.TextBox()
            Me.txtCreditCustomerName = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtAccountNo = New System.Windows.Forms.TextBox()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.dgw = New System.Windows.Forms.DataGridView()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.Panel1.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.Panel4.SuspendLayout()
            CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel2.SuspendLayout()
            MyBase.SuspendLayout()
            Me.Panel1.BackColor = System.Drawing.Color.White
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.btnDelete)
            Me.Panel1.Controls.Add(Me.lblSet)
            Me.Panel1.Controls.Add(Me.btnUpdate)
            Me.Panel1.Controls.Add(Me.btnSave)
            Me.Panel1.Controls.Add(Me.txtACNo)
            Me.Panel1.Controls.Add(Me.GroupBox2)
            Me.Panel1.Controls.Add(Me.btnNew)
            Me.Panel1.Controls.Add(Me.lblUser)
            Me.Panel1.Controls.Add(Me.txtCC_ID)
            Me.Panel1.Controls.Add(Me.txtCustName)
            Me.Panel1.Controls.Add(Me.GroupBox1)
            Me.Panel1.Controls.Add(Me.Panel4)
            Me.Panel1.Controls.Add(Me.Panel3)
            Me.Panel1.Controls.Add(Me.dgw)
            Dim panel As System.Windows.Forms.Panel = Me.Panel1
            Dim location As System.Drawing.Point = New System.Drawing.Point(6, 52)
            panel.Location = location
            Me.Panel1.Name = "Panel1"
            Dim panel2 As System.Windows.Forms.Panel = Me.Panel1
            Dim size As System.Drawing.Size = New System.Drawing.Size(794, 597)
            panel2.Size = size
            Me.Panel1.TabIndex = 2
            Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnDelete.Image = CType(componentResourceManager.GetObject("btnDelete.Image"), System.Drawing.Image)
            Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button As System.Windows.Forms.Button = Me.btnDelete
            location = New System.Drawing.Point(508, 134)
            button.Location = location
            Me.btnDelete.Name = "btnDelete"
            Dim button2 As System.Windows.Forms.Button = Me.btnDelete
            size = New System.Drawing.Size(106, 40)
            button2.Size = size
            Me.btnDelete.TabIndex = 1
            Me.btnDelete.Text = "Delete"
            Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnDelete.UseVisualStyleBackColor = True
            Me.lblSet.AutoSize = True
            Dim label As System.Windows.Forms.Label = Me.lblSet
            location = New System.Drawing.Point(712, 51)
            label.Location = location
            Me.lblSet.Name = "lblSet"
            Dim label2 As System.Windows.Forms.Label = Me.lblSet
            size = New System.Drawing.Size(33, 13)
            label2.Size = size
            Me.lblSet.TabIndex = 11
            Me.lblSet.Text = "lblSet"
            Me.lblSet.Visible = False
            Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnUpdate.Image = CType(componentResourceManager.GetObject("btnUpdate.Image"), System.Drawing.Image)
            Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button3 As System.Windows.Forms.Button = Me.btnUpdate
            location = New System.Drawing.Point(508, 89)
            button3.Location = location
            Me.btnUpdate.Name = "btnUpdate"
            Dim button4 As System.Windows.Forms.Button = Me.btnUpdate
            size = New System.Drawing.Size(106, 40)
            button4.Size = size
            Me.btnUpdate.TabIndex = 3
            Me.btnUpdate.Text = "Update"
            Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnUpdate.UseVisualStyleBackColor = True
            Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnSave.Image = CType(componentResourceManager.GetObject("btnSave.Image"), System.Drawing.Image)
            Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button5 As System.Windows.Forms.Button = Me.btnSave
            location = New System.Drawing.Point(508, 48)
            button5.Location = location
            Me.btnSave.Name = "btnSave"
            Dim button6 As System.Windows.Forms.Button = Me.btnSave
            size = New System.Drawing.Size(106, 37)
            button6.Size = size
            Me.btnSave.TabIndex = 2
            Me.btnSave.Text = "Save"
            Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnSave.UseVisualStyleBackColor = True
            Me.txtACNo.BackColor = System.Drawing.Color.White
            Me.txtACNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox As System.Windows.Forms.TextBox = Me.txtACNo
            location = New System.Drawing.Point(645, 251)
            textBox.Location = location
            Me.txtACNo.Name = "txtACNo"
            Dim textBox2 As System.Windows.Forms.TextBox = Me.txtACNo
            size = New System.Drawing.Size(79, 21)
            textBox2.Size = size
            Me.txtACNo.TabIndex = 10
            Me.txtACNo.Visible = False
            Me.GroupBox2.Controls.Add(Me.txtSearchByACNo)
            Dim groupBox As System.Windows.Forms.GroupBox = Me.GroupBox2
            location = New System.Drawing.Point(244, 251)
            groupBox.Location = location
            Me.GroupBox2.Name = "GroupBox2"
            Dim groupBox2 As System.Windows.Forms.GroupBox = Me.GroupBox2
            size = New System.Drawing.Size(235, 68)
            groupBox2.Size = size
            Me.GroupBox2.TabIndex = 9
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Search By Account No."
            Me.txtSearchByACNo.BackColor = System.Drawing.Color.White
            Me.txtSearchByACNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox3 As System.Windows.Forms.TextBox = Me.txtSearchByACNo
            location = New System.Drawing.Point(22, 29)
            textBox3.Location = location
            Me.txtSearchByACNo.Name = "txtSearchByACNo"
            Dim textBox4 As System.Windows.Forms.TextBox = Me.txtSearchByACNo
            size = New System.Drawing.Size(207, 22)
            textBox4.Size = size
            Me.txtSearchByACNo.TabIndex = 0
            Me.btnNew.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnNew.Image = CType(componentResourceManager.GetObject("btnNew.Image"), System.Drawing.Image)
            Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button7 As System.Windows.Forms.Button = Me.btnNew
            location = New System.Drawing.Point(508, 4)
            button7.Location = location
            Me.btnNew.Name = "btnNew"
            Dim button8 As System.Windows.Forms.Button = Me.btnNew
            size = New System.Drawing.Size(106, 40)
            button8.Size = size
            Me.btnNew.TabIndex = 0
            Me.btnNew.Text = "New"
            Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnNew.UseVisualStyleBackColor = True
            Me.lblUser.AutoSize = True
            Dim label3 As System.Windows.Forms.Label = Me.lblUser
            location = New System.Drawing.Point(670, 158)
            label3.Location = location
            Me.lblUser.Name = "lblUser"
            Dim label4 As System.Windows.Forms.Label = Me.lblUser
            size = New System.Drawing.Size(39, 13)
            label4.Size = size
            Me.lblUser.TabIndex = 5
            Me.lblUser.Text = "Label8"
            Me.lblUser.Visible = False
            Me.txtCC_ID.BackColor = System.Drawing.SystemColors.Control
            Me.txtCC_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox5 As System.Windows.Forms.TextBox = Me.txtCC_ID
            location = New System.Drawing.Point(682, 188)
            textBox5.Location = location
            Me.txtCC_ID.Name = "txtCC_ID"
            Me.txtCC_ID.[ReadOnly] = True
            Dim textBox6 As System.Windows.Forms.TextBox = Me.txtCC_ID
            size = New System.Drawing.Size(69, 21)
            textBox6.Size = size
            Me.txtCC_ID.TabIndex = 8
            Me.txtCC_ID.Visible = False
            Me.txtCustName.BackColor = System.Drawing.Color.White
            Me.txtCustName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox7 As System.Windows.Forms.TextBox = Me.txtCustName
            location = New System.Drawing.Point(682, 224)
            textBox7.Location = location
            Me.txtCustName.Name = "txtCustName"
            Dim textBox8 As System.Windows.Forms.TextBox = Me.txtCustName
            size = New System.Drawing.Size(79, 21)
            textBox8.Size = size
            Me.txtCustName.TabIndex = 7
            Me.txtCustName.Visible = False
            Me.GroupBox1.Controls.Add(Me.txtSearchByCreditCustomerName)
            Dim groupBox3 As System.Windows.Forms.GroupBox = Me.GroupBox1
            location = New System.Drawing.Point(3, 251)
            groupBox3.Location = location
            Me.GroupBox1.Name = "GroupBox1"
            Dim groupBox4 As System.Windows.Forms.GroupBox = Me.GroupBox1
            size = New System.Drawing.Size(235, 68)
            groupBox4.Size = size
            Me.GroupBox1.TabIndex = 6
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Search By Customer Name"
            Me.txtSearchByCreditCustomerName.BackColor = System.Drawing.Color.White
            Me.txtSearchByCreditCustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox9 As System.Windows.Forms.TextBox = Me.txtSearchByCreditCustomerName
            location = New System.Drawing.Point(22, 29)
            textBox9.Location = location
            Me.txtSearchByCreditCustomerName.Name = "txtSearchByCreditCustomerName"
            Dim textBox10 As System.Windows.Forms.TextBox = Me.txtSearchByCreditCustomerName
            size = New System.Drawing.Size(207, 22)
            textBox10.Size = size
            Me.txtSearchByCreditCustomerName.TabIndex = 0
            Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel4.Controls.Add(Me.cmbOpeningBalanceType)
            Me.Panel4.Controls.Add(Me.Label15)
            Me.Panel4.Controls.Add(Me.txtOpeningBalance)
            Me.Panel4.Controls.Add(Me.txtAddress)
            Me.Panel4.Controls.Add(Me.Label8)
            Me.Panel4.Controls.Add(Me.chkActive)
            Me.Panel4.Controls.Add(Me.Label7)
            Me.Panel4.Controls.Add(Me.Label6)
            Me.Panel4.Controls.Add(Me.Label5)
            Me.Panel4.Controls.Add(Me.txtContactNo)
            Me.Panel4.Controls.Add(Me.txtCreditCustomerName)
            Me.Panel4.Controls.Add(Me.Label3)
            Me.Panel4.Controls.Add(Me.txtAccountNo)
            Me.Panel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim panel3 As System.Windows.Forms.Panel = Me.Panel4
            location = New System.Drawing.Point(3, 4)
            panel3.Location = location
            Me.Panel4.Name = "Panel4"
            Dim panel4 As System.Windows.Forms.Panel = Me.Panel4
            size = New System.Drawing.Size(499, 241)
            panel4.Size = size
            Me.Panel4.TabIndex = 0
            Me.cmbOpeningBalanceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbOpeningBalanceType.FormattingEnabled = True
            Me.cmbOpeningBalanceType.Items.AddRange(New Object(1) {"CR", "DR"})
            Dim comboBox As System.Windows.Forms.ComboBox = Me.cmbOpeningBalanceType
            location = New System.Drawing.Point(240, 203)
            comboBox.Location = location
            Me.cmbOpeningBalanceType.Name = "cmbOpeningBalanceType"
            Dim comboBox2 As System.Windows.Forms.ComboBox = Me.cmbOpeningBalanceType
            size = New System.Drawing.Size(50, 23)
            comboBox2.Size = size
            Me.cmbOpeningBalanceType.TabIndex = 6
            Me.Label15.AutoSize = True
            Dim label5 As System.Windows.Forms.Label = Me.Label15
            location = New System.Drawing.Point(7, 203)
            label5.Location = location
            Me.Label15.Name = "Label15"
            Dim label6 As System.Windows.Forms.Label = Me.Label15
            size = New System.Drawing.Size(108, 15)
            label6.Size = size
            Me.Label15.TabIndex = 309
            Me.Label15.Text = "Opening Balance :"
            Me.txtOpeningBalance.BackColor = System.Drawing.Color.White
            Me.txtOpeningBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox11 As System.Windows.Forms.TextBox = Me.txtOpeningBalance
            location = New System.Drawing.Point(124, 203)
            textBox11.Location = location
            Me.txtOpeningBalance.Name = "txtOpeningBalance"
            Dim textBox12 As System.Windows.Forms.TextBox = Me.txtOpeningBalance
            size = New System.Drawing.Size(110, 21)
            textBox12.Size = size
            Me.txtOpeningBalance.TabIndex = 5
            Me.txtOpeningBalance.Text = "0.00"
            Me.txtOpeningBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Dim richTextBox As System.Windows.Forms.RichTextBox = Me.txtAddress
            location = New System.Drawing.Point(125, 66)
            richTextBox.Location = location
            Me.txtAddress.Name = "txtAddress"
            Me.txtAddress.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
            Dim richTextBox2 As System.Windows.Forms.RichTextBox = Me.txtAddress
            size = New System.Drawing.Size(360, 76)
            richTextBox2.Size = size
            Me.txtAddress.TabIndex = 2
            Me.txtAddress.Text = ""
            Me.Label8.AutoSize = True
            Dim label7 As System.Windows.Forms.Label = Me.Label8
            location = New System.Drawing.Point(7, 175)
            label7.Location = location
            Me.Label8.Name = "Label8"
            Dim label8 As System.Windows.Forms.Label = Me.Label8
            size = New System.Drawing.Size(47, 15)
            label8.Size = size
            Me.Label8.TabIndex = 16
            Me.Label8.Text = "Status :"
            Me.chkActive.AutoSize = True
            Dim checkBox As System.Windows.Forms.CheckBox = Me.chkActive
            location = New System.Drawing.Point(125, 175)
            checkBox.Location = location
            Me.chkActive.Name = "chkActive"
            Dim checkBox2 As System.Windows.Forms.CheckBox = Me.chkActive
            size = New System.Drawing.Size(57, 19)
            checkBox2.Size = size
            Me.chkActive.TabIndex = 4
            Me.chkActive.Text = "Active"
            Me.chkActive.UseVisualStyleBackColor = True
            Me.Label7.AutoSize = True
            Dim label9 As System.Windows.Forms.Label = Me.Label7
            location = New System.Drawing.Point(7, 148)
            label9.Location = location
            Me.Label7.Name = "Label7"
            Dim label10 As System.Windows.Forms.Label = Me.Label7
            size = New System.Drawing.Size(73, 15)
            label10.Size = size
            Me.Label7.TabIndex = 13
            Me.Label7.Text = "Contact No :"
            Me.Label6.AutoSize = True
            Dim label11 As System.Windows.Forms.Label = Me.Label6
            location = New System.Drawing.Point(7, 92)
            label11.Location = location
            Me.Label6.Name = "Label6"
            Dim label12 As System.Windows.Forms.Label = Me.Label6
            size = New System.Drawing.Size(57, 15)
            label12.Size = size
            Me.Label6.TabIndex = 12
            Me.Label6.Text = "Address :"
            Me.Label5.AutoSize = True
            Dim label13 As System.Windows.Forms.Label = Me.Label5
            location = New System.Drawing.Point(7, 38)
            label13.Location = location
            Me.Label5.Name = "Label5"
            Dim label14 As System.Windows.Forms.Label = Me.Label5
            size = New System.Drawing.Size(103, 15)
            label14.Size = size
            Me.Label5.TabIndex = 11
            Me.Label5.Text = "Customer Name :"
            Me.txtContactNo.BackColor = System.Drawing.Color.White
            Me.txtContactNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox13 As System.Windows.Forms.TextBox = Me.txtContactNo
            location = New System.Drawing.Point(125, 148)
            textBox13.Location = location
            Me.txtContactNo.Name = "txtContactNo"
            Dim textBox14 As System.Windows.Forms.TextBox = Me.txtContactNo
            size = New System.Drawing.Size(157, 21)
            textBox14.Size = size
            Me.txtContactNo.TabIndex = 3
            Me.txtCreditCustomerName.BackColor = System.Drawing.Color.White
            Me.txtCreditCustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox15 As System.Windows.Forms.TextBox = Me.txtCreditCustomerName
            location = New System.Drawing.Point(125, 38)
            textBox15.Location = location
            Me.txtCreditCustomerName.Name = "txtCreditCustomerName"
            Dim textBox16 As System.Windows.Forms.TextBox = Me.txtCreditCustomerName
            size = New System.Drawing.Size(297, 21)
            textBox16.Size = size
            Me.txtCreditCustomerName.TabIndex = 1
            Me.Label3.AutoSize = True
            Dim label15 As System.Windows.Forms.Label = Me.Label3
            location = New System.Drawing.Point(7, 14)
            label15.Location = location
            Me.Label3.Name = "Label3"
            Dim label16 As System.Windows.Forms.Label = Me.Label3
            size = New System.Drawing.Size(78, 15)
            label16.Size = size
            Me.Label3.TabIndex = 0
            Me.Label3.Text = "Account No. :"
            Me.txtAccountNo.BackColor = System.Drawing.Color.White
            Me.txtAccountNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox17 As System.Windows.Forms.TextBox = Me.txtAccountNo
            location = New System.Drawing.Point(125, 11)
            textBox17.Location = location
            Me.txtAccountNo.Name = "txtAccountNo"
            Dim textBox18 As System.Windows.Forms.TextBox = Me.txtAccountNo
            size = New System.Drawing.Size(157, 21)
            textBox18.Size = size
            Me.txtAccountNo.TabIndex = 0
            Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Dim panel5 As System.Windows.Forms.Panel = Me.Panel3
            location = New System.Drawing.Point(641, 67)
            panel5.Location = location
            Me.Panel3.Name = "Panel3"
            Dim panel6 As System.Windows.Forms.Panel = Me.Panel3
            size = New System.Drawing.Size(104, 201)
            panel6.Size = size
            Me.Panel3.TabIndex = 1
            Me.Panel3.Visible = False
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
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SaddleBrown
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgw.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2
            Me.dgw.ColumnHeadersHeight = 24
            Me.dgw.Columns.AddRange(Me.Column1, Me.Description, Me.Column3, Me.Column2, Me.Column4, Me.Column7, Me.Column5, Me.Column6)
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
            location = New System.Drawing.Point(6, 325)
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
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgw.RowHeadersDefaultCellStyle = dataGridViewCellStyle4
            Me.dgw.RowHeadersWidth = 25
            Me.dgw.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White
            dataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gainsboro
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
            Me.dgw.RowsDefaultCellStyle = dataGridViewCellStyle5
            Me.dgw.RowTemplate.Height = 21
            Me.dgw.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgw.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Dim dataGridView2 As System.Windows.Forms.DataGridView = Me.dgw
            size = New System.Drawing.Size(779, 264)
            dataGridView2.Size = size
            Me.dgw.TabIndex = 1
            Me.Column1.HeaderText = "CC_ID"
            Me.Column1.Name = "Column1"
            Me.Column1.[ReadOnly] = True
            Me.Column1.Visible = False
            Me.Description.HeaderText = "Account No."
            Me.Description.Name = "Description"
            Me.Description.[ReadOnly] = True
            Me.Column3.HeaderText = "Customer Name"
            Me.Column3.Name = "Column3"
            Me.Column3.[ReadOnly] = True
            Me.Column3.Width = 130
            Me.Column2.HeaderText = "Address"
            Me.Column2.Name = "Column2"
            Me.Column2.[ReadOnly] = True
            Me.Column2.Width = 120
            Me.Column4.HeaderText = "Contact No."
            Me.Column4.Name = "Column4"
            Me.Column4.[ReadOnly] = True
            Me.Column7.HeaderText = "Active"
            Me.Column7.Name = "Column7"
            Me.Column7.[ReadOnly] = True
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.Column5.DefaultCellStyle = dataGridViewCellStyle6
            Me.Column5.HeaderText = "Opening Balance"
            Me.Column5.Name = "Column5"
            Me.Column5.[ReadOnly] = True
            dataGridViewCellStyle7.Format = "dd/MM/yyyy hh:mm:ss tt"
            Me.Column6.DefaultCellStyle = dataGridViewCellStyle7
            Me.Column6.HeaderText = "Registered Date"
            Me.Column6.Name = "Column6"
            Me.Column6.[ReadOnly] = True
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label1.ForeColor = System.Drawing.Color.White
            Dim label17 As System.Windows.Forms.Label = Me.Label1
            location = New System.Drawing.Point(243, 13)
            label17.Location = location
            Me.Label1.Name = "Label1"
            Dim label18 As System.Windows.Forms.Label = Me.Label1
            size = New System.Drawing.Size(276, 24)
            label18.Size = size
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Credit Customer Registration"
            Me.Panel2.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Panel2.Controls.Add(Me.Label1)
            Dim panel7 As System.Windows.Forms.Panel = Me.Panel2
            location = New System.Drawing.Point(0, 1)
            panel7.Location = location
            Me.Panel2.Name = "Panel2"
            Dim panel8 As System.Windows.Forms.Panel = Me.Panel2
            size = New System.Drawing.Size(752, 50)
            panel8.Size = size
            Me.Panel2.TabIndex = 3
            Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
            Me.btnCancel.BackColor = System.Drawing.Color.Transparent
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.FlatAppearance.BorderSize = 0
            Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnCancel.Image = CType(componentResourceManager.GetObject("btnCancel.Image"), System.Drawing.Image)
            Dim button9 As System.Windows.Forms.Button = Me.btnCancel
            location = New System.Drawing.Point(754, 1)
            button9.Location = location
            Me.btnCancel.Name = "btnCancel"
            Dim button10 As System.Windows.Forms.Button = Me.btnCancel
            size = New System.Drawing.Size(52, 50)
            button10.Size = size
            Me.btnCancel.TabIndex = 390
            Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnCancel.UseVisualStyleBackColor = False
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            size = New System.Drawing.Size(806, 655)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.btnCancel)
            MyBase.Controls.Add(Me.Panel2)
            MyBase.Controls.Add(Me.Panel1)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MaximizeBox = False
            MyBase.MinimizeBox = False
            MyBase.Name = "frmCreditCustomerRegistration"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.Panel4.ResumeLayout(False)
            Me.Panel4.PerformLayout()
            CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            MyBase.ResumeLayout(False)
        End Sub
    End Class
End Namespace
