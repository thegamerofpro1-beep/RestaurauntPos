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
    Public Class frmVoucher
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel1")>
        Private _Panel1 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel2")>
        Private _Panel2 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label1")>
        Private _Label1 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtVoucherID")>
        Private _txtVoucherID As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblUser")>
        Private _lblUser As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnPrint")>
        Private _btnPrint As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnGetData")>
        Private _btnGetData As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnDelete")>
        Private _btnDelete As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnClose")>
        Private _btnClose As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnUpdate")>
        Private _btnUpdate As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnSave")>
        Private _btnSave As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnNew")>
        Private _btnNew As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox2")>
        Private _GroupBox2 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label8")>
        Private _Label8 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label11")>
        Private _Label11 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnAdd")>
        Private _btnAdd As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label12")>
        Private _Label12 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtAmount")>
        Private _txtAmount As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox4")>
        Private _GroupBox4 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("dtpDate")>
        Private _dtpDate As System.Windows.Forms.DateTimePicker

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtVoucherNo")>
        Private _txtVoucherNo As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label2")>
        Private _Label2 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtGrandTotal")>
        Private _txtGrandTotal As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DataGridView1")>
        Private _DataGridView1 As System.Windows.Forms.DataGridView

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnRemove")>
        Private _btnRemove As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Button1")>
        Private _Button1 As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("ToolTip1")>
        Private _ToolTip1 As System.Windows.Forms.ToolTip

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Timer1")>
        Private _Timer1 As System.Windows.Forms.Timer

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label3")>
        Private _Label3 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label4")>
        Private _Label4 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtDetails")>
        Private _txtDetails As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtName")>
        Private _txtName As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtNotes")>
        Private _txtNotes As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("cmbParticulars")>
        Private _cmbParticulars As System.Windows.Forms.ComboBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox5")>
        Private _GroupBox5 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox3")>
        Private _GroupBox3 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox1")>
        Private _GroupBox1 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column1")>
        Private _Column1 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column2")>
        Private _Column2 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column3")>
        Private _Column3 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label6")>
        Private _Label6 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("cmbPaymentMode")>
        Private _cmbPaymentMode As System.Windows.Forms.ComboBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Button2")>
        Private _Button2 As System.Windows.Forms.Button

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

        Friend Overridable Property txtVoucherID As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtVoucherID
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtVoucherID = value
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

        Friend Overridable Property btnAdd As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnAdd
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.Button7_Click
                If Me._btnAdd IsNot Nothing Then
                    RemoveHandler Me._btnAdd.Click, value2
                End If

                Me._btnAdd = value
                If Me._btnAdd IsNot Nothing Then
                    AddHandler Me._btnAdd.Click, value2
                End If
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

        Friend Overridable Property txtAmount As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtAmount
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.Windows.Forms.KeyPressEventHandler = AddressOf Me.txtAmount_KeyPress
                If Me._txtAmount IsNot Nothing Then
                    RemoveHandler Me._txtAmount.KeyPress, value2
                End If

                Me._txtAmount = value
                If Me._txtAmount IsNot Nothing Then
                    AddHandler Me._txtAmount.KeyPress, value2
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

        Friend Overridable Property txtVoucherNo As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtVoucherNo
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtVoucherNo = value
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

        Friend Overridable Property DataGridView1 As System.Windows.Forms.DataGridView
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._DataGridView1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridView)
                Dim value2 As System.Windows.Forms.MouseEventHandler = AddressOf Me.DataGridView1_MouseClick
                If Me._DataGridView1 IsNot Nothing Then
                    RemoveHandler Me._DataGridView1.MouseClick, value2
                End If

                Me._DataGridView1 = value
                If Me._DataGridView1 IsNot Nothing Then
                    AddHandler Me._DataGridView1.MouseClick, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnRemove As System.Windows.Forms.Button
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

        Friend Overridable Property Button1 As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Button1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Me._Button1 = value
            End Set
        End Property

        Friend Overridable Property ToolTip1 As System.Windows.Forms.ToolTip
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._ToolTip1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ToolTip)
                Me._ToolTip1 = value
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

        Friend Overridable Property txtDetails As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtDetails
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtDetails = value
            End Set
        End Property

        Friend Overridable Property txtName As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtName
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtName = value
            End Set
        End Property

        Friend Overridable Property txtNotes As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtNotes
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtNotes = value
            End Set
        End Property

        Friend Overridable Property cmbParticulars As System.Windows.Forms.ComboBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._cmbParticulars
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ComboBox)
                Me._cmbParticulars = value
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

        Friend Overridable Property cmbPaymentMode As System.Windows.Forms.ComboBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._cmbPaymentMode
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ComboBox)
                Me._cmbPaymentMode = value
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
                Dim value2 As System.EventHandler = AddressOf Me.Button2_Click
                If Me._Button2 IsNot Nothing Then
                    RemoveHandler Me._Button2.Click, value2
                End If

                Me._Button2 = value
                If Me._Button2 IsNot Nothing Then
                    AddHandler Me._Button2.Click, value2
                End If
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            AddHandler MyBase.Load, AddressOf Me.frmVoucher_Load
            Call RestaurantPOS14.frmVoucher.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmVoucher.__ENCList
                If RestaurantPOS14.frmVoucher.__ENCList.Count = RestaurantPOS14.frmVoucher.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmVoucher.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmVoucher.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmVoucher.__ENCList(num) = RestaurantPOS14.frmVoucher.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmVoucher.__ENCList.RemoveRange(num, RestaurantPOS14.frmVoucher.__ENCList.Count - num)
                    RestaurantPOS14.frmVoucher.__ENCList.Capacity = RestaurantPOS14.frmVoucher.__ENCList.Count
                End If

                Call RestaurantPOS14.frmVoucher.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Private Sub btnClose_Click(sender As Object, e As System.EventArgs)
            MyBase.Close()
        End Sub

        Public Sub Reset()
            Me.txtVoucherID.Text = ""
            Me.txtName.Text = ""
            Me.txtDetails.Text = ""
            Me.cmbParticulars.SelectedIndex = -1
            Me.txtNotes.Text = ""
            Me.txtVoucherNo.Text = ""
            Me.txtAmount.Text = ""
            Me.txtGrandTotal.Text = ""
            Me.dtpDate.Value = Microsoft.VisualBasic.DateAndTime.Now
            Me.DataGridView1.Rows.Clear()
            Me.btnPrint.Enabled = False
            If RestaurantPOS14.ModFunc.IsViewAllowed(Me.lblUser.Text, "Voucher") Then
                Me.btnGetData.Enabled = True
            Else
                Me.btnGetData.Enabled = False
            End If

            If RestaurantPOS14.ModFunc.IsSaveAllowed(Me.lblUser.Text, "Voucher") Then
                Me.btnSave.Enabled = True
            Else
                Me.btnSave.Enabled = False
            End If

            Me.btnDelete.Enabled = False
            Me.btnUpdate.Enabled = False
            Me.btnAdd.Enabled = True
            Me.btnRemove.Enabled = False
            Me.cmbPaymentMode.Enabled = True
            Me.Clear()
            Me.auto()
        End Sub

        Private Sub Button7_Click(sender As Object, e As System.EventArgs)
            Try
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.cmbParticulars.Text, "", TextCompare:=False) = 0 Then
                    Call System.Windows.Forms.MessageBox.Show("Please enter particulars", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Me.cmbParticulars.Focus()
                ElseIf Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtAmount.Text, "", TextCompare:=False) = 0 Then
                    Call System.Windows.Forms.MessageBox.Show("Please enter amount", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Me.txtAmount.Focus()
                ElseIf Me.DataGridView1.Rows.Count = 0 Then
                    Me.DataGridView1.Rows.Add(Me.cmbParticulars.Text, Me.txtAmount.Text, Me.txtNotes.Text)
                    Dim value As Double = Me.GrandTotal()
                    value = System.Math.Round(value, 2)
                    Me.txtGrandTotal.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(value)
                    Me.Clear()
                Else
                    Me.DataGridView1.Rows.Add(Me.cmbParticulars.Text, Me.txtAmount.Text, Me.txtNotes.Text)
                    Dim value2 As Double = Me.GrandTotal()
                    value2 = System.Math.Round(value2, 2)
                    Me.txtGrandTotal.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(value2)
                    Me.Clear()
                End If
            Catch ex As System.Exception
                Call Microsoft.VisualBasic.Interaction.MsgBox(ex.Message)
            End Try
        End Sub

        Public Sub Clear()
            Me.cmbParticulars.SelectedIndex = -1
            Me.txtAmount.Text = ""
            Me.txtNotes.Text = ""
            Me.btnAdd.Enabled = True
            Me.btnRemove.Enabled = False
        End Sub

        Public Function GrandTotal() As Double
            Dim num As Double = 0.0
            Try
                For Each dataGridViewRow As System.Windows.Forms.DataGridViewRow In CType(Me.DataGridView1.Rows, System.Collections.IEnumerable)
                    num = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(num, dataGridViewRow.Cells(CInt((1))).Value))
                Next
            Catch ex As System.Exception
                Call Microsoft.VisualBasic.Interaction.MsgBox(ex.Message)
            End Try

            Return num
        End Function

        Private Sub btnNew_Click(sender As Object, e As System.EventArgs)
            Me.Reset()
            Me.Reset()
        End Sub

        Private Sub auto()
            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
            RestaurantPOS14.ModClasses.con.Open()
            RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT MAX(ID) from Voucher")
            RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
            If Microsoft.VisualBasic.Information.IsDBNull(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.cmd.ExecuteScalar())) Then
                Dim num As Integer = 1
                Me.txtVoucherID.Text = num.ToString()
                Me.txtVoucherNo.Text = "V-" & num.ToString()
            Else
                Dim num2 As Integer = Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(RestaurantPOS14.ModClasses.cmd.ExecuteScalar(), 1))
                Me.txtVoucherID.Text = num2.ToString()
                Me.txtVoucherNo.Text = "V-" & num2.ToString()
            End If

            RestaurantPOS14.ModClasses.cmd.Dispose()
            RestaurantPOS14.ModClasses.con.Close()
            RestaurantPOS14.ModClasses.con.Dispose()
        End Sub

        Public Sub Print()
            Try
                MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Me.Timer1.Enabled = True
                Dim rptVoucher2 As RestaurantPOS14.rptVoucher = New RestaurantPOS14.rptVoucher()
                Dim sqlCommand As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand()
                Dim sqlCommand2 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand()
                Dim sqlDataAdapter As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter()
                Dim sqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter()
                Dim dataSet As System.Data.DataSet = New System.Data.DataSet()
                sqlCommand.Connection = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                Dim sqlConnection As System.Data.SqlClient.SqlConnection = sqlCommand.Connection
                Dim connection As System.Data.SqlClient.SqlConnection = sqlConnection
                sqlCommand2.Connection = connection
                sqlCommand.CommandText = "SELECT Voucher.ID, Voucher.VoucherNo,Voucher.PaymentMode, Voucher.Date, Voucher.Name, Voucher.Details, Voucher.GrandTotal, Voucher_OtherDetails.VD_ID, Voucher_OtherDetails.VoucherID,Voucher_OtherDetails.Particulars, Voucher_OtherDetails.Amount, Voucher_OtherDetails.Note FROM Voucher INNER JOIN Voucher_OtherDetails ON Voucher.ID = Voucher_OtherDetails.VoucherID  where VoucherNo='" & Me.txtVoucherNo.Text & "'"
                sqlCommand2.CommandText = "SELECT * from Hotel"
                sqlCommand.CommandType = System.Data.CommandType.Text
                sqlCommand2.CommandType = System.Data.CommandType.Text
                sqlDataAdapter.SelectCommand = sqlCommand
                sqlDataAdapter2.SelectCommand = sqlCommand2
                sqlDataAdapter.Fill(dataSet, "Voucher")
                sqlDataAdapter.Fill(dataSet, "Voucher_OtherDetails")
                sqlDataAdapter2.Fill(dataSet, "Hotel")
                rptVoucher2.SetDataSource(dataSet)
                RestaurantPOS14.My.MyProject.Forms.frmReport.CrystalReportViewer1.ReportSource = rptVoucher2
                Call RestaurantPOS14.My.MyProject.Forms.frmReport.ShowDialog()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnSave_Click(sender As Object, e As System.EventArgs)
            Try
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtName.Text, "", TextCompare:=False) = 0 Then
                    Call System.Windows.Forms.MessageBox.Show("Please enter voucher name", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Me.txtName.Focus()
                    Return
                End If

                If Me.DataGridView1.Rows.Count = 0 Then
                    Call System.Windows.Forms.MessageBox.Show("sorry no data added to grid", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Return
                End If

                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.cmbPaymentMode.Text, "", TextCompare:=False) = 0 Then
                    Call System.Windows.Forms.MessageBox.Show("Please select payment mode", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Me.cmbPaymentMode.Focus()
                    Return
                End If

                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("insert into Voucher( Id, VoucherNo, Date,Name,Details,GrandTotal,PaymentMode) Values (@d1,@d2,@d3,@d4,@d5,@d7,@d6)")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.Conversion.Val(Me.txtVoucherID.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Me.txtVoucherNo.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Me.dtpDate.Value)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", Me.txtName.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d5", Me.txtDetails.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d7", Microsoft.VisualBasic.Conversion.Val(Me.txtGrandTotal.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d6", Me.cmbPaymentMode.Text)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("insert into Voucher_OtherDetails(VoucherID,Particulars,Amount,Note) VALUES (" & RestaurantPOS14.Security.SqlInput.RequireInteger(Me.txtVoucherID.Text, "Record ID") & ",@d1,@d2,@d3)")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Prepare()
                For Each dataGridViewRow As System.Windows.Forms.DataGridViewRow In CType(Me.DataGridView1.Rows, System.Collections.IEnumerable)
                    If Not dataGridViewRow.IsNewRow Then
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((0))).Value))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((1))).Value)))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((2))).Value))
                        RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                        RestaurantPOS14.ModClasses.cmd.Parameters.Clear()
                    End If
                Next

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModFunc.LedgerSave(Me.dtpDate.Value.[Date], "Expense A/c", Me.txtVoucherNo.Text, "Voucher", New Decimal(Microsoft.VisualBasic.Conversion.Val(Me.txtGrandTotal.Text)), 0D, Me.txtVoucherNo.Text, "Cash")
                RestaurantPOS14.ModFunc.LedgerSave(Me.dtpDate.Value.[Date], "Cash", Me.txtVoucherNo.Text, "Voucher", 0D, New Decimal(Microsoft.VisualBasic.Conversion.Val(Me.txtGrandTotal.Text)), "", "Expenses")
                Dim st As String = "added the new voucher having voucher no.'" & Me.txtVoucherNo.Text & "'"
                RestaurantPOS14.ModFunc.LogFunc(Me.lblUser.Text, st)
                Me.btnSave.Enabled = False
                Call System.Windows.Forms.MessageBox.Show("Successfully saved", "Voucher", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                Me.Print()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub DeleteRecord()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("delete from Voucher where ID=" & RestaurantPOS14.Security.SqlInput.RequireInteger(Me.txtVoucherID.Text, "Record ID"))
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                Dim num As Integer = RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                If RestaurantPOS14.ModClasses.con.State = System.Data.ConnectionState.Open Then
                    RestaurantPOS14.ModClasses.con.Close()
                End If

                If num > 0 Then
                    RestaurantPOS14.ModFunc.LedgerDelete(Me.txtVoucherNo.Text, "Voucher")
                    Dim st As String = "deleted the voucher having voucher no.'" & Me.txtVoucherNo.Text & "'"
                    RestaurantPOS14.ModFunc.LogFunc(Me.lblUser.Text, st)
                    Call System.Windows.Forms.MessageBox.Show("Successfully deleted", "Record", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    Me.Reset()
                    Me.Reset()
                Else
                    Call System.Windows.Forms.MessageBox.Show("No record found/tewali kyetulaba", "Sorry", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    Me.Reset()
                End If

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

        Private Sub btnUpdate_Click(sender As Object, e As System.EventArgs)
            Try
                If Me.DataGridView1.Rows.Count = 0 Then
                    Call System.Windows.Forms.MessageBox.Show("sorry no data added to grid", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Return
                End If

                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.cmbPaymentMode.Text, "", TextCompare:=False) = 0 Then
                    Call System.Windows.Forms.MessageBox.Show("Please select payment mode", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Me.cmbPaymentMode.Focus()
                    Return
                End If

                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Update Voucher set VoucherNo=@d2, Date=@d3,Name=@d4,Details=@d5,GrandTotal=@d7,PaymentMode=@d6 where ID=@d1")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.Conversion.Val(Me.txtVoucherID.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Me.txtVoucherNo.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Me.dtpDate.Value)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", Me.txtName.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d5", Me.txtDetails.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d7", Microsoft.VisualBasic.Conversion.Val(Me.txtGrandTotal.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d6", Me.cmbPaymentMode.Text)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("delete from Voucher_OtherDetails where VoucherID=" & RestaurantPOS14.Security.SqlInput.RequireInteger(Me.txtVoucherID.Text, "Record ID"))
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("insert into Voucher_OtherDetails(VoucherID,Particulars,Amount,Note) VALUES (" & RestaurantPOS14.Security.SqlInput.RequireInteger(Me.txtVoucherID.Text, "Record ID") & ",@d1,@d2,@d3)")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Prepare()
                For Each dataGridViewRow As System.Windows.Forms.DataGridViewRow In CType(Me.DataGridView1.Rows, System.Collections.IEnumerable)
                    If Not dataGridViewRow.IsNewRow Then
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((0))).Value))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((1))).Value)))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((2))).Value))
                        RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                        RestaurantPOS14.ModClasses.cmd.Parameters.Clear()
                    End If
                Next

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModFunc.LedgerUpdate1(Me.dtpDate.Value.[Date], "Expense Account", New Decimal(Microsoft.VisualBasic.Conversion.Val(Me.txtGrandTotal.Text)), 0D, Me.txtVoucherNo.Text, Me.txtVoucherNo.Text, "Voucher")
                RestaurantPOS14.ModFunc.LedgerUpdate1(Me.dtpDate.Value.[Date], "Cash", 0D, New Decimal(Microsoft.VisualBasic.Conversion.Val(Me.txtGrandTotal.Text)), "", Me.txtVoucherNo.Text, "Voucher")
                Dim st As String = "updated the voucher having voucher no.'" & Me.txtVoucherNo.Text & "'"
                RestaurantPOS14.ModFunc.LogFunc(Me.lblUser.Text, st)
                Me.btnUpdate.Enabled = False
                Call System.Windows.Forms.MessageBox.Show("Successfully updated", "Voucher", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub DataGridView1_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs)
            Me.btnRemove.Enabled = True
        End Sub

        Private Sub btnRemove_Click(sender As Object, e As System.EventArgs)
            Try
                For Each dataGridViewRow As System.Windows.Forms.DataGridViewRow In Me.DataGridView1.SelectedRows
                    Me.DataGridView1.Rows.Remove(dataGridViewRow)
                Next

                Dim value As Double = Me.GrandTotal()
                value = System.Math.Round(value, 2)
                Me.txtGrandTotal.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(value)
                Me.btnRemove.Enabled = False
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnPrint_Click(sender As Object, e As System.EventArgs)
            Me.Print()
        End Sub

        Private Sub Timer1_Tick(sender As Object, e As System.EventArgs)
            MyBase.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.Timer1.Enabled = False
        End Sub

        Private Sub txtAmount_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
            Dim keyChar As Char = e.KeyChar
            If Char.IsControl(keyChar) Then
                Return
            End If

            If Char.IsDigit(keyChar) OrElse keyChar = "."c Then
                Dim text As String = Me.txtAmount.Text
                Dim selectionStart As Integer = Me.txtAmount.SelectionStart
                Dim selectionLength As Integer = Me.txtAmount.SelectionLength
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
            RestaurantPOS14.My.MyProject.Forms.frmVoucherRecord.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmVoucherRecord.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmVoucherRecord.ShowDialog()
        End Sub

        Public Sub fillCombo()
            Try
                Dim sqlConnection As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                sqlConnection.Open()
                RestaurantPOS14.ModClasses.adp = New System.Data.SqlClient.SqlDataAdapter()
                RestaurantPOS14.ModClasses.adp.SelectCommand = New System.Data.SqlClient.SqlCommand("SELECT distinct RTRIM(ExpenseName) FROM Expense", sqlConnection)
                RestaurantPOS14.ModClasses.ds = New System.Data.DataSet("ds")
                RestaurantPOS14.ModClasses.adp.Fill(RestaurantPOS14.ModClasses.ds)
                Dim dataTable As System.Data.DataTable = RestaurantPOS14.ModClasses.ds.Tables(0)
                Me.cmbParticulars.Items.Clear()
                For Each dataRow As System.Data.DataRow In dataTable.Rows
                    Me.cmbParticulars.Items.Add(dataRow(CInt((0))).ToString())
                Next
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub frmVoucher_Load(sender As Object, e As System.EventArgs)
            Me.fillCombo()
        End Sub

        Private Sub Button2_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmExpense.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmExpense.Reset()
            RestaurantPOS14.My.MyProject.Forms.frmExpense.lblSet.Text = "Expense"
            Call RestaurantPOS14.My.MyProject.Forms.frmExpense.ShowDialog()
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmVoucher))
            Dim dataGridViewCellStyle As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.GroupBox5 = New System.Windows.Forms.GroupBox()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.btnPrint = New System.Windows.Forms.Button()
            Me.btnGetData = New System.Windows.Forms.Button()
            Me.btnUpdate = New System.Windows.Forms.Button()
            Me.btnDelete = New System.Windows.Forms.Button()
            Me.btnNew = New System.Windows.Forms.Button()
            Me.btnSave = New System.Windows.Forms.Button()
            Me.btnClose = New System.Windows.Forms.Button()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.txtGrandTotal = New System.Windows.Forms.TextBox()
            Me.DataGridView1 = New System.Windows.Forms.DataGridView()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.lblUser = New System.Windows.Forms.Label()
            Me.txtVoucherID = New System.Windows.Forms.TextBox()
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.cmbPaymentMode = New System.Windows.Forms.ComboBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtDetails = New System.Windows.Forms.TextBox()
            Me.txtName = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.dtpDate = New System.Windows.Forms.DateTimePicker()
            Me.txtVoucherNo = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.Button2 = New System.Windows.Forms.Button()
            Me.cmbParticulars = New System.Windows.Forms.ComboBox()
            Me.btnRemove = New System.Windows.Forms.Button()
            Me.txtNotes = New System.Windows.Forms.TextBox()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.btnAdd = New System.Windows.Forms.Button()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.txtAmount = New System.Windows.Forms.TextBox()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
            Dim label As System.Windows.Forms.Label = New System.Windows.Forms.Label()
            Me.Panel1.SuspendLayout()
            Me.GroupBox5.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox4.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.Panel2.SuspendLayout()
            MyBase.SuspendLayout()
            label.AutoSize = True
            label.ForeColor = System.Drawing.Color.Black
            Dim location As System.Drawing.Point = New System.Drawing.Point(26, 18)
            label.Location = location
            Dim margin As System.Windows.Forms.Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
            label.Margin = margin
            label.Name = "Label5"
            Dim size As System.Drawing.Size = New System.Drawing.Size(73, 13)
            label.Size = size
            label.TabIndex = 268
            label.Text = "Voucher No. :"
            Me.Panel1.BackColor = System.Drawing.Color.White
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.GroupBox5)
            Me.Panel1.Controls.Add(Me.btnClose)
            Me.Panel1.Controls.Add(Me.GroupBox1)
            Me.Panel1.Controls.Add(Me.DataGridView1)
            Me.Panel1.Controls.Add(Me.lblUser)
            Me.Panel1.Controls.Add(Me.txtVoucherID)
            Me.Panel1.Controls.Add(Me.GroupBox4)
            Me.Panel1.Controls.Add(Me.GroupBox2)
            Me.Panel1.Controls.Add(Me.Panel2)
            Dim panel As System.Windows.Forms.Panel = Me.Panel1
            location = New System.Drawing.Point(3, 3)
            panel.Location = location
            Me.Panel1.Name = "Panel1"
            Dim panel2 As System.Windows.Forms.Panel = Me.Panel1
            size = New System.Drawing.Size(670, 665)
            panel2.Size = size
            Me.Panel1.TabIndex = 2
            Me.GroupBox5.Controls.Add(Me.GroupBox3)
            Me.GroupBox5.Controls.Add(Me.btnSave)
            Dim groupBox As System.Windows.Forms.GroupBox = Me.GroupBox5
            location = New System.Drawing.Point(530, 42)
            groupBox.Location = location
            Me.GroupBox5.Name = "GroupBox5"
            Dim groupBox2 As System.Windows.Forms.GroupBox = Me.GroupBox5
            size = New System.Drawing.Size(135, 317)
            groupBox2.Size = size
            Me.GroupBox5.TabIndex = 8
            Me.GroupBox5.TabStop = False
            Me.GroupBox5.Text = "Action Buttons"
            Me.GroupBox3.Controls.Add(Me.btnPrint)
            Me.GroupBox3.Controls.Add(Me.btnGetData)
            Me.GroupBox3.Controls.Add(Me.btnUpdate)
            Me.GroupBox3.Controls.Add(Me.btnDelete)
            Me.GroupBox3.Controls.Add(Me.btnNew)
            Dim groupBox3 As System.Windows.Forms.GroupBox = Me.GroupBox3
            location = New System.Drawing.Point(12, 13)
            groupBox3.Location = location
            Me.GroupBox3.Name = "GroupBox3"
            Dim groupBox4 As System.Windows.Forms.GroupBox = Me.GroupBox3
            size = New System.Drawing.Size(110, 246)
            groupBox4.Size = size
            Me.GroupBox3.TabIndex = 7
            Me.GroupBox3.TabStop = False
            Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnPrint.Enabled = False
            Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnPrint.Image = CType(componentResourceManager.GetObject("btnPrint.Image"), System.Drawing.Image)
            Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
            Dim button As System.Windows.Forms.Button = Me.btnPrint
            location = New System.Drawing.Point(10, 151)
            button.Location = location
            Me.btnPrint.Name = "btnPrint"
            Dim button2 As System.Windows.Forms.Button = Me.btnPrint
            size = New System.Drawing.Size(91, 39)
            button2.Size = size
            Me.btnPrint.TabIndex = 5
            Me.btnPrint.Text = "Print"
            Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnPrint.UseVisualStyleBackColor = True
            Me.btnGetData.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnGetData.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnGetData.Image = CType(componentResourceManager.GetObject("btnGetData.Image"), System.Drawing.Image)
            Me.btnGetData.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
            Dim button3 As System.Windows.Forms.Button = Me.btnGetData
            location = New System.Drawing.Point(10, 106)
            button3.Location = location
            Me.btnGetData.Name = "btnGetData"
            Dim button4 As System.Windows.Forms.Button = Me.btnGetData
            size = New System.Drawing.Size(91, 39)
            button4.Size = size
            Me.btnGetData.TabIndex = 4
            Me.btnGetData.Text = "Get Data"
            Me.btnGetData.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnGetData.UseVisualStyleBackColor = True
            Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnUpdate.Enabled = False
            Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnUpdate.Image = CType(componentResourceManager.GetObject("btnUpdate.Image"), System.Drawing.Image)
            Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
            Dim button5 As System.Windows.Forms.Button = Me.btnUpdate
            location = New System.Drawing.Point(10, 61)
            button5.Location = location
            Me.btnUpdate.Name = "btnUpdate"
            Dim button6 As System.Windows.Forms.Button = Me.btnUpdate
            size = New System.Drawing.Size(91, 39)
            button6.Size = size
            Me.btnUpdate.TabIndex = 2
            Me.btnUpdate.Text = "Update"
            Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnUpdate.UseVisualStyleBackColor = True
            Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnDelete.Enabled = False
            Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnDelete.Image = CType(componentResourceManager.GetObject("btnDelete.Image"), System.Drawing.Image)
            Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
            Dim button7 As System.Windows.Forms.Button = Me.btnDelete
            location = New System.Drawing.Point(10, 196)
            button7.Location = location
            Me.btnDelete.Name = "btnDelete"
            Dim button8 As System.Windows.Forms.Button = Me.btnDelete
            size = New System.Drawing.Size(91, 39)
            button8.Size = size
            Me.btnDelete.TabIndex = 3
            Me.btnDelete.Text = "Delete"
            Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnDelete.UseVisualStyleBackColor = True
            Me.btnNew.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnNew.Image = CType(componentResourceManager.GetObject("btnNew.Image"), System.Drawing.Image)
            Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
            Dim button9 As System.Windows.Forms.Button = Me.btnNew
            location = New System.Drawing.Point(10, 16)
            button9.Location = location
            Me.btnNew.Name = "btnNew"
            Dim button10 As System.Windows.Forms.Button = Me.btnNew
            size = New System.Drawing.Size(91, 39)
            button10.Size = size
            Me.btnNew.TabIndex = 0
            Me.btnNew.Text = "New"
            Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnNew.UseVisualStyleBackColor = True
            Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnSave.Image = CType(componentResourceManager.GetObject("btnSave.Image"), System.Drawing.Image)
            Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
            Dim button11 As System.Windows.Forms.Button = Me.btnSave
            location = New System.Drawing.Point(16, 269)
            button11.Location = location
            Me.btnSave.Name = "btnSave"
            Dim button12 As System.Windows.Forms.Button = Me.btnSave
            size = New System.Drawing.Size(102, 39)
            button12.Size = size
            Me.btnSave.TabIndex = 1
            Me.btnSave.Text = "Save + Print"
            Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnSave.UseVisualStyleBackColor = True
            Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnClose.Image = CType(componentResourceManager.GetObject("btnClose.Image"), System.Drawing.Image)
            Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
            Dim button13 As System.Windows.Forms.Button = Me.btnClose
            location = New System.Drawing.Point(589, 1)
            button13.Location = location
            Me.btnClose.Name = "btnClose"
            Dim button14 As System.Windows.Forms.Button = Me.btnClose
            size = New System.Drawing.Size(76, 39)
            button14.Size = size
            Me.btnClose.TabIndex = 6
            Me.btnClose.Text = "Close"
            Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnClose.UseVisualStyleBackColor = True
            Me.GroupBox1.Controls.Add(Me.txtGrandTotal)
            Dim groupBox5 As System.Windows.Forms.GroupBox = Me.GroupBox1
            location = New System.Drawing.Point(530, 598)
            groupBox5.Location = location
            Me.GroupBox1.Name = "GroupBox1"
            Dim groupBox6 As System.Windows.Forms.GroupBox = Me.GroupBox1
            size = New System.Drawing.Size(135, 55)
            groupBox6.Size = size
            Me.GroupBox1.TabIndex = 6
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Grand Total :"
            Me.txtGrandTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox As System.Windows.Forms.TextBox = Me.txtGrandTotal
            location = New System.Drawing.Point(7, 22)
            textBox.Location = location
            Me.txtGrandTotal.Name = "txtGrandTotal"
            Me.txtGrandTotal.[ReadOnly] = True
            Dim textBox2 As System.Windows.Forms.TextBox = Me.txtGrandTotal
            size = New System.Drawing.Size(123, 20)
            textBox2.Size = size
            Me.txtGrandTotal.TabIndex = 5
            Me.txtGrandTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
            Me.DataGridView1.Columns.AddRange(Me.Column1, Me.Column2, Me.Column3)
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
            location = New System.Drawing.Point(3, 360)
            dataGridView.Location = location
            Me.DataGridView1.Name = "DataGridView1"
            Me.DataGridView1.[ReadOnly] = True
            Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White
            dataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gainsboro
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4
            Me.DataGridView1.RowHeadersWidth = 25
            Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White
            dataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gainsboro
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
            Me.DataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5
            Me.DataGridView1.RowTemplate.Height = 18
            Me.DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Dim dataGridView2 As System.Windows.Forms.DataGridView = Me.DataGridView1
            size = New System.Drawing.Size(516, 293)
            dataGridView2.Size = size
            Me.DataGridView1.TabIndex = 2
            Me.Column1.HeaderText = "Particulars"
            Me.Column1.Name = "Column1"
            Me.Column1.[ReadOnly] = True
            Me.Column1.Width = 250
            Me.Column2.HeaderText = "Amount"
            Me.Column2.Name = "Column2"
            Me.Column2.[ReadOnly] = True
            Me.Column3.HeaderText = "Notes"
            Me.Column3.Name = "Column3"
            Me.Column3.[ReadOnly] = True
            Me.Column3.Width = 140
            Me.lblUser.AutoSize = True
            Dim label2 As System.Windows.Forms.Label = Me.lblUser
            location = New System.Drawing.Point(390, 202)
            label2.Location = location
            Me.lblUser.Name = "lblUser"
            Dim label3 As System.Windows.Forms.Label = Me.lblUser
            size = New System.Drawing.Size(39, 13)
            label3.Size = size
            Me.lblUser.TabIndex = 5
            Me.lblUser.Text = "Label8"
            Me.lblUser.Visible = False
            Dim textBox3 As System.Windows.Forms.TextBox = Me.txtVoucherID
            location = New System.Drawing.Point(393, 179)
            textBox3.Location = location
            Me.txtVoucherID.Name = "txtVoucherID"
            Dim textBox4 As System.Windows.Forms.TextBox = Me.txtVoucherID
            size = New System.Drawing.Size(23, 20)
            textBox4.Size = size
            Me.txtVoucherID.TabIndex = 4
            Me.txtVoucherID.Visible = False
            Me.GroupBox4.Controls.Add(Me.Label6)
            Me.GroupBox4.Controls.Add(Me.cmbPaymentMode)
            Me.GroupBox4.Controls.Add(Me.Label4)
            Me.GroupBox4.Controls.Add(Me.txtDetails)
            Me.GroupBox4.Controls.Add(Me.txtName)
            Me.GroupBox4.Controls.Add(Me.Label3)
            Me.GroupBox4.Controls.Add(Me.dtpDate)
            Me.GroupBox4.Controls.Add(Me.txtVoucherNo)
            Me.GroupBox4.Controls.Add(Me.Label2)
            Me.GroupBox4.Controls.Add(label)
            Dim groupBox7 As System.Windows.Forms.GroupBox = Me.GroupBox4
            location = New System.Drawing.Point(4, 42)
            groupBox7.Location = location
            Me.GroupBox4.Name = "GroupBox4"
            Dim groupBox8 As System.Windows.Forms.GroupBox = Me.GroupBox4
            size = New System.Drawing.Size(364, 157)
            groupBox8.Size = size
            Me.GroupBox4.TabIndex = 0
            Me.GroupBox4.TabStop = False
            Me.GroupBox4.Text = "Voucher Info"
            Me.Label6.AutoSize = True
            Dim label4 As System.Windows.Forms.Label = Me.Label6
            location = New System.Drawing.Point(26, 126)
            label4.Location = location
            Dim label5 As System.Windows.Forms.Label = Me.Label6
            margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
            label5.Margin = margin
            Me.Label6.Name = "Label6"
            Dim label6 As System.Windows.Forms.Label = Me.Label6
            size = New System.Drawing.Size(84, 13)
            label6.Size = size
            Me.Label6.TabIndex = 341
            Me.Label6.Text = "Payment Mode :"
            Me.cmbPaymentMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbPaymentMode.FormattingEnabled = True
            Me.cmbPaymentMode.Items.AddRange(New Object(1) {"By Cash", "By Cheque"})
            Dim comboBox As System.Windows.Forms.ComboBox = Me.cmbPaymentMode
            location = New System.Drawing.Point(121, 126)
            comboBox.Location = location
            Me.cmbPaymentMode.Name = "cmbPaymentMode"
            Dim comboBox2 As System.Windows.Forms.ComboBox = Me.cmbPaymentMode
            size = New System.Drawing.Size(229, 21)
            comboBox2.Size = size
            Me.cmbPaymentMode.TabIndex = 4
            Me.Label4.AutoSize = True
            Dim label7 As System.Windows.Forms.Label = Me.Label4
            location = New System.Drawing.Point(26, 98)
            label7.Location = location
            Dim label8 As System.Windows.Forms.Label = Me.Label4
            margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
            label8.Margin = margin
            Me.Label4.Name = "Label4"
            Dim label9 As System.Windows.Forms.Label = Me.Label4
            size = New System.Drawing.Size(45, 13)
            label9.Size = size
            Me.Label4.TabIndex = 339
            Me.Label4.Text = "Details :"
            Me.txtDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox5 As System.Windows.Forms.TextBox = Me.txtDetails
            location = New System.Drawing.Point(121, 100)
            textBox5.Location = location
            Me.txtDetails.Name = "txtDetails"
            Me.txtDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Dim textBox6 As System.Windows.Forms.TextBox = Me.txtDetails
            size = New System.Drawing.Size(229, 20)
            textBox6.Size = size
            Me.txtDetails.TabIndex = 3
            Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox7 As System.Windows.Forms.TextBox = Me.txtName
            location = New System.Drawing.Point(121, 72)
            textBox7.Location = location
            Me.txtName.Name = "txtName"
            Dim textBox8 As System.Windows.Forms.TextBox = Me.txtName
            size = New System.Drawing.Size(229, 20)
            textBox8.Size = size
            Me.txtName.TabIndex = 2
            Me.Label3.AutoSize = True
            Dim label10 As System.Windows.Forms.Label = Me.Label3
            location = New System.Drawing.Point(26, 72)
            label10.Location = location
            Dim label11 As System.Windows.Forms.Label = Me.Label3
            margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
            label11.Margin = margin
            Me.Label3.Name = "Label3"
            Dim label12 As System.Windows.Forms.Label = Me.Label3
            size = New System.Drawing.Size(41, 13)
            label12.Size = size
            Me.Label3.TabIndex = 336
            Me.Label3.Text = "Name :"
            Me.dtpDate.CustomFormat = "dd/MM/yyyy"
            Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Dim dateTimePicker As System.Windows.Forms.DateTimePicker = Me.dtpDate
            location = New System.Drawing.Point(121, 47)
            dateTimePicker.Location = location
            Dim dateTimePicker2 As System.Windows.Forms.DateTimePicker = Me.dtpDate
            margin = New System.Windows.Forms.Padding(2)
            dateTimePicker2.Margin = margin
            Me.dtpDate.Name = "dtpDate"
            Dim dateTimePicker3 As System.Windows.Forms.DateTimePicker = Me.dtpDate
            size = New System.Drawing.Size(96, 20)
            dateTimePicker3.Size = size
            Me.dtpDate.TabIndex = 1
            Dim textBox9 As System.Windows.Forms.TextBox = Me.txtVoucherNo
            location = New System.Drawing.Point(121, 18)
            textBox9.Location = location
            Me.txtVoucherNo.Name = "txtVoucherNo"
            Me.txtVoucherNo.[ReadOnly] = True
            Dim textBox10 As System.Windows.Forms.TextBox = Me.txtVoucherNo
            size = New System.Drawing.Size(96, 20)
            textBox10.Size = size
            Me.txtVoucherNo.TabIndex = 0
            Me.Label2.AutoSize = True
            Dim label13 As System.Windows.Forms.Label = Me.Label2
            location = New System.Drawing.Point(26, 47)
            label13.Location = location
            Dim label14 As System.Windows.Forms.Label = Me.Label2
            margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
            label14.Margin = margin
            Me.Label2.Name = "Label2"
            Dim label15 As System.Windows.Forms.Label = Me.Label2
            size = New System.Drawing.Size(36, 13)
            label15.Size = size
            Me.Label2.TabIndex = 335
            Me.Label2.Text = "Date :"
            Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox2.Controls.Add(Me.Button2)
            Me.GroupBox2.Controls.Add(Me.cmbParticulars)
            Me.GroupBox2.Controls.Add(Me.btnRemove)
            Me.GroupBox2.Controls.Add(Me.txtNotes)
            Me.GroupBox2.Controls.Add(Me.Label8)
            Me.GroupBox2.Controls.Add(Me.Label11)
            Me.GroupBox2.Controls.Add(Me.btnAdd)
            Me.GroupBox2.Controls.Add(Me.Label12)
            Me.GroupBox2.Controls.Add(Me.txtAmount)
            Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim groupBox9 As System.Windows.Forms.GroupBox = Me.GroupBox2
            location = New System.Drawing.Point(4, 204)
            groupBox9.Location = location
            Me.GroupBox2.Name = "GroupBox2"
            Dim groupBox10 As System.Windows.Forms.GroupBox = Me.GroupBox2
            size = New System.Drawing.Size(515, 150)
            groupBox10.Size = size
            Me.GroupBox2.TabIndex = 1
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Other Details"
            Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.Button2.Image = RestaurantPOS14.My.Resources.Resources._1__2_
            Dim button15 As System.Windows.Forms.Button = Me.Button2
            location = New System.Drawing.Point(271, 24)
            button15.Location = location
            Me.Button2.Name = "Button2"
            Dim button16 As System.Windows.Forms.Button = Me.Button2
            size = New System.Drawing.Size(31, 23)
            button16.Size = size
            Me.Button2.TabIndex = 313
            Me.Button2.UseVisualStyleBackColor = True
            Me.cmbParticulars.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbParticulars.FormattingEnabled = True
            Dim comboBox3 As System.Windows.Forms.ComboBox = Me.cmbParticulars
            location = New System.Drawing.Point(73, 26)
            comboBox3.Location = location
            Me.cmbParticulars.Name = "cmbParticulars"
            Dim comboBox4 As System.Windows.Forms.ComboBox = Me.cmbParticulars
            size = New System.Drawing.Size(192, 21)
            comboBox4.Size = size
            Me.cmbParticulars.TabIndex = 96
            Me.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnRemove.Enabled = False
            Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnRemove.Image = CType(componentResourceManager.GetObject("btnRemove.Image"), System.Drawing.Image)
            Me.btnRemove.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
            Dim button17 As System.Windows.Forms.Button = Me.btnRemove
            location = New System.Drawing.Point(415, 18)
            button17.Location = location
            Me.btnRemove.Name = "btnRemove"
            Dim button18 As System.Windows.Forms.Button = Me.btnRemove
            size = New System.Drawing.Size(85, 36)
            button18.Size = size
            Me.btnRemove.TabIndex = 4
            Me.btnRemove.Text = "Remove"
            Me.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnRemove.UseVisualStyleBackColor = True
            Me.txtNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox11 As System.Windows.Forms.TextBox = Me.txtNotes
            location = New System.Drawing.Point(73, 79)
            textBox11.Location = location
            Me.txtNotes.Multiline = True
            Me.txtNotes.Name = "txtNotes"
            Me.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Dim textBox12 As System.Windows.Forms.TextBox = Me.txtNotes
            size = New System.Drawing.Size(427, 62)
            textBox12.Size = size
            Me.txtNotes.TabIndex = 2
            Me.Label8.AutoSize = True
            Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label16 As System.Windows.Forms.Label = Me.Label8
            location = New System.Drawing.Point(10, 30)
            label16.Location = location
            Me.Label8.Name = "Label8"
            Dim label17 As System.Windows.Forms.Label = Me.Label8
            size = New System.Drawing.Size(62, 13)
            label17.Size = size
            Me.Label8.TabIndex = 95
            Me.Label8.Text = "Particulars :"
            Me.Label11.AutoSize = True
            Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label18 As System.Windows.Forms.Label = Me.Label11
            location = New System.Drawing.Point(10, 104)
            label18.Location = location
            Me.Label11.Name = "Label11"
            Dim label19 As System.Windows.Forms.Label = Me.Label11
            size = New System.Drawing.Size(41, 13)
            label19.Size = size
            Me.Label11.TabIndex = 89
            Me.Label11.Text = "Notes :"
            Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnAdd.Image = CType(componentResourceManager.GetObject("btnAdd.Image"), System.Drawing.Image)
            Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
            Dim button19 As System.Windows.Forms.Button = Me.btnAdd
            location = New System.Drawing.Point(308, 18)
            button19.Location = location
            Me.btnAdd.Name = "btnAdd"
            Dim button20 As System.Windows.Forms.Button = Me.btnAdd
            size = New System.Drawing.Size(101, 36)
            button20.Size = size
            Me.btnAdd.TabIndex = 3
            Me.btnAdd.Text = "&Add To Grid"
            Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnAdd.UseVisualStyleBackColor = True
            Me.Label12.AutoSize = True
            Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label20 As System.Windows.Forms.Label = Me.Label12
            location = New System.Drawing.Point(10, 57)
            label20.Location = location
            Me.Label12.Name = "Label12"
            Dim label21 As System.Windows.Forms.Label = Me.Label12
            size = New System.Drawing.Size(49, 13)
            label21.Size = size
            Me.Label12.TabIndex = 87
            Me.Label12.Text = "Amount :"
            Me.txtAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox13 As System.Windows.Forms.TextBox = Me.txtAmount
            location = New System.Drawing.Point(218, 53)
            textBox13.Location = location
            Me.txtAmount.Name = "txtAmount"
            Dim textBox14 As System.Windows.Forms.TextBox = Me.txtAmount
            size = New System.Drawing.Size(84, 20)
            textBox14.Size = size
            Me.txtAmount.TabIndex = 1
            Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.Panel2.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Panel2.Controls.Add(Me.Label1)
            Dim panel3 As System.Windows.Forms.Panel = Me.Panel2
            location = New System.Drawing.Point(4, 3)
            panel3.Location = location
            Me.Panel2.Name = "Panel2"
            Dim panel4 As System.Windows.Forms.Panel = Me.Panel2
            size = New System.Drawing.Size(579, 32)
            panel4.Size = size
            Me.Panel2.TabIndex = 0
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label1.ForeColor = System.Drawing.Color.White
            Dim label22 As System.Windows.Forms.Label = Me.Label1
            location = New System.Drawing.Point(247, 4)
            label22.Location = location
            Me.Label1.Name = "Label1"
            Dim label23 As System.Windows.Forms.Label = Me.Label1
            size = New System.Drawing.Size(90, 24)
            label23.Size = size
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Voucher"
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            size = New System.Drawing.Size(677, 671)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.Panel1)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MaximizeBox = False
            MyBase.MinimizeBox = False
            MyBase.Name = "frmVoucher"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.GroupBox5.ResumeLayout(False)
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox4.ResumeLayout(False)
            Me.GroupBox4.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            MyBase.ResumeLayout(False)
        End Sub

    End Class
End Namespace
