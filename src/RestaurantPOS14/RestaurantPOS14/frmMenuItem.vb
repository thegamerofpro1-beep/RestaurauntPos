Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Text
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports CButtonLib
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports RestaurantPOS14.My
Imports RestaurantPOS14.My.Resources

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public Class frmMenuItem
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel1")>
        Private _Panel1 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label3")>
        Private _Label3 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtItemName")>
        Private _txtItemName As System.Windows.Forms.TextBox

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

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("dgw")>
        Private _dgw As System.Windows.Forms.DataGridView

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel2")>
        Private _Panel2 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label1")>
        Private _Label1 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtDIRate")>
        Private _txtDIRate As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label4")>
        Private _Label4 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label2")>
        Private _Label2 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtDish")>
        Private _txtDish As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblUser")>
        Private _lblUser As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtSearchByDish")>
        Private _txtSearchByDish As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("cmbCategory")>
        Private _cmbCategory As System.Windows.Forms.ComboBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox1")>
        Private _GroupBox1 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox3")>
        Private _GroupBox3 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox2")>
        Private _GroupBox2 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("LinkLabel1")>
        Private _LinkLabel1 As System.Windows.Forms.LinkLabel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnUIColor")>
        Private _btnUIColor As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("ColorDialog1")>
        Private _ColorDialog1 As System.Windows.Forms.ColorDialog

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnExportExcel")>
        Private _btnExportExcel As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("chkActive")>
        Private _chkActive As System.Windows.Forms.CheckBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label7")>
        Private _Label7 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtBarcode")>
        Private _txtBarcode As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtBCode")>
        Private _txtBCode As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtDishID")>
        Private _txtDishID As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label9")>
        Private _Label9 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtHDRate")>
        Private _txtHDRate As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label8")>
        Private _Label8 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtTARate")>
        Private _txtTARate As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnBarcodePrint")>
        Private _btnBarcodePrint As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Picture")>
        Private _Picture As System.Windows.Forms.PictureBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("BRemove")>
        Private _BRemove As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Browse")>
        Private _Browse As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("OpenFileDialog1")>
        Private _OpenFileDialog1 As System.Windows.Forms.OpenFileDialog

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtImagePath")>
        Private _txtImagePath As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label5")>
        Private _Label5 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtItemNameArabic")>
        Private _txtItemNameArabic As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnAddItems")>
        Private _btnAddItems As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label6")>
        Private _Label6 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnAdd")>
        Private _btnAdd As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblSet")>
        Private _lblSet As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("cmbFColor")>
        Private _cmbFColor As System.Windows.Forms.ComboBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label10")>
        Private _Label10 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox4")>
        Private _GroupBox4 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtSearchByCategory")>
        Private _txtSearchByCategory As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column1")>
        Private _Column1 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column10")>
        Private _Column10 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column2")>
        Private _Column2 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column3")>
        Private _Column3 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column4")>
        Private _Column4 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column9")>
        Private _Column9 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column8")>
        Private _Column8 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column5")>
        Private _Column5 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column7")>
        Private _Column7 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column6")>
        Private _Column6 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column11")>
        Private _Column11 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnMenuItemsModifiers")>
        Private _btnMenuItemsModifiers As CButtonLib.CButton

        Private Item As String

        Private ImagePath As String

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

        Friend Overridable Property txtItemName As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtItemName
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtItemName = value
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

        Friend Overridable Property dgw As System.Windows.Forms.DataGridView
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._dgw
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridView)
                Dim value2 As System.Windows.Forms.MouseEventHandler = AddressOf Me.dgw_MouseClick
                Dim value3 As System.Windows.Forms.DataGridViewRowPostPaintEventHandler = AddressOf Me.dgw_RowPostPaint
                If Me._dgw IsNot Nothing Then
                    RemoveHandler Me._dgw.MouseClick, value2
                    RemoveHandler Me._dgw.RowPostPaint, value3
                End If

                Me._dgw = value
                If Me._dgw IsNot Nothing Then
                    AddHandler Me._dgw.MouseClick, value2
                    AddHandler Me._dgw.RowPostPaint, value3
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

        Friend Overridable Property txtDIRate As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtDIRate
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.Windows.Forms.KeyPressEventHandler = AddressOf Me.txtServiceTax_KeyPress
                If Me._txtDIRate IsNot Nothing Then
                    RemoveHandler Me._txtDIRate.KeyPress, value2
                End If

                Me._txtDIRate = value
                If Me._txtDIRate IsNot Nothing Then
                    AddHandler Me._txtDIRate.KeyPress, value2
                End If
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

        Friend Overridable Property txtDish As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtDish
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtDish = value
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

        Friend Overridable Property txtSearchByDish As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtSearchByDish
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.EventHandler = AddressOf Me.txtFirstName_TextChanged
                If Me._txtSearchByDish IsNot Nothing Then
                    RemoveHandler Me._txtSearchByDish.TextChanged, value2
                End If

                Me._txtSearchByDish = value
                If Me._txtSearchByDish IsNot Nothing Then
                    AddHandler Me._txtSearchByDish.TextChanged, value2
                End If
            End Set
        End Property

        Friend Overridable Property cmbCategory As System.Windows.Forms.ComboBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._cmbCategory
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ComboBox)
                Me._cmbCategory = value
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

        Friend Overridable Property LinkLabel1 As System.Windows.Forms.LinkLabel
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._LinkLabel1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.LinkLabel)
                Dim value2 As System.Windows.Forms.LinkLabelLinkClickedEventHandler = AddressOf Me.LinkLabel1_LinkClicked
                If Me._LinkLabel1 IsNot Nothing Then
                    RemoveHandler Me._LinkLabel1.LinkClicked, value2
                End If

                Me._LinkLabel1 = value
                If Me._LinkLabel1 IsNot Nothing Then
                    AddHandler Me._LinkLabel1.LinkClicked, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnUIColor As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnUIColor
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Me._btnUIColor = value
            End Set
        End Property

        Friend Overridable Property ColorDialog1 As System.Windows.Forms.ColorDialog
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._ColorDialog1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ColorDialog)
                Me._ColorDialog1 = value
            End Set
        End Property

        Friend Overridable Property btnExportExcel As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnExportExcel
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnExportExcel_Click
                If Me._btnExportExcel IsNot Nothing Then
                    RemoveHandler Me._btnExportExcel.Click, value2
                End If

                Me._btnExportExcel = value
                If Me._btnExportExcel IsNot Nothing Then
                    AddHandler Me._btnExportExcel.Click, value2
                End If
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

        Friend Overridable Property txtBarcode As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtBarcode
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtBarcode = value
            End Set
        End Property

        Friend Overridable Property txtBCode As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtBCode
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtBCode = value
            End Set
        End Property

        Friend Overridable Property txtDishID As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtDishID
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtDishID = value
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

        Friend Overridable Property txtHDRate As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtHDRate
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.Windows.Forms.KeyPressEventHandler = AddressOf Me.txtHDRate_KeyPress
                If Me._txtHDRate IsNot Nothing Then
                    RemoveHandler Me._txtHDRate.KeyPress, value2
                End If

                Me._txtHDRate = value
                If Me._txtHDRate IsNot Nothing Then
                    AddHandler Me._txtHDRate.KeyPress, value2
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

        Friend Overridable Property txtTARate As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtTARate
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.Windows.Forms.KeyPressEventHandler = AddressOf Me.txtTARate_KeyPress
                If Me._txtTARate IsNot Nothing Then
                    RemoveHandler Me._txtTARate.KeyPress, value2
                End If

                Me._txtTARate = value
                If Me._txtTARate IsNot Nothing Then
                    AddHandler Me._txtTARate.KeyPress, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnBarcodePrint As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnBarcodePrint
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnBarcodePrint_Click
                If Me._btnBarcodePrint IsNot Nothing Then
                    RemoveHandler Me._btnBarcodePrint.Click, value2
                End If

                Me._btnBarcodePrint = value
                If Me._btnBarcodePrint IsNot Nothing Then
                    AddHandler Me._btnBarcodePrint.Click, value2
                End If
            End Set
        End Property

        Public Overridable Property Picture As System.Windows.Forms.PictureBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Picture
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.PictureBox)
                Me._Picture = value
            End Set
        End Property

        Friend Overridable Property BRemove As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._BRemove
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.BRemove_Click
                If Me._BRemove IsNot Nothing Then
                    RemoveHandler Me._BRemove.Click, value2
                End If

                Me._BRemove = value
                If Me._BRemove IsNot Nothing Then
                    AddHandler Me._BRemove.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property Browse As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Browse
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.Browse_Click
                If Me._Browse IsNot Nothing Then
                    RemoveHandler Me._Browse.Click, value2
                End If

                Me._Browse = value
                If Me._Browse IsNot Nothing Then
                    AddHandler Me._Browse.Click, value2
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

        Friend Overridable Property txtImagePath As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtImagePath
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtImagePath = value
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

        Friend Overridable Property txtItemNameArabic As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtItemNameArabic
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtItemNameArabic = value
            End Set
        End Property

        Public Overridable Property btnAddItems As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnAddItems
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnAddItems_Click
                If Me._btnAddItems IsNot Nothing Then
                    RemoveHandler Me._btnAddItems.Click, value2
                End If

                Me._btnAddItems = value
                If Me._btnAddItems IsNot Nothing Then
                    AddHandler Me._btnAddItems.Click, value2
                End If
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

        Friend Overridable Property btnAdd As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnAdd
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnAdd_Click_1
                If Me._btnAdd IsNot Nothing Then
                    RemoveHandler Me._btnAdd.Click, value2
                End If

                Me._btnAdd = value
                If Me._btnAdd IsNot Nothing Then
                    AddHandler Me._btnAdd.Click, value2
                End If
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

        Friend Overridable Property cmbFColor As System.Windows.Forms.ComboBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._cmbFColor
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ComboBox)
                Dim value2 As System.EventHandler = AddressOf Me.cmbFColor_SelectedIndexChanged
                If Me._cmbFColor IsNot Nothing Then
                    RemoveHandler Me._cmbFColor.SelectedIndexChanged, value2
                End If

                Me._cmbFColor = value
                If Me._cmbFColor IsNot Nothing Then
                    AddHandler Me._cmbFColor.SelectedIndexChanged, value2
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

        Friend Overridable Property txtSearchByCategory As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtSearchByCategory
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.EventHandler = AddressOf Me.txtSearchByCategory_TextChanged
                If Me._txtSearchByCategory IsNot Nothing Then
                    RemoveHandler Me._txtSearchByCategory.TextChanged, value2
                End If

                Me._txtSearchByCategory = value
                If Me._txtSearchByCategory IsNot Nothing Then
                    AddHandler Me._txtSearchByCategory.TextChanged, value2
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

        Friend Overridable Property Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Column10
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._Column10 = value
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

        Friend Overridable Property Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Column9
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._Column9 = value
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

        Friend Overridable Property Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Column11
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._Column11 = value
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
                Dim obj As CButtonLib.CButton.ClickButtonAreaEventHandler = AddressOf Me.btnMenuItemsModifiers_ClickButtonArea
                If Me._btnMenuItemsModifiers IsNot Nothing Then
                    RemoveHandler Me._btnMenuItemsModifiers.ClickButtonArea, obj
                End If

                Me._btnMenuItemsModifiers = value
                If Me._btnMenuItemsModifiers IsNot Nothing Then
                    AddHandler Me._btnMenuItemsModifiers.ClickButtonArea, obj
                End If
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            AddHandler MyBase.Load, AddressOf Me.frmDish_Load
            Call RestaurantPOS14.frmMenuItem.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmMenuItem.__ENCList
                If RestaurantPOS14.frmMenuItem.__ENCList.Count = RestaurantPOS14.frmMenuItem.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmMenuItem.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmMenuItem.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmMenuItem.__ENCList(num) = RestaurantPOS14.frmMenuItem.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmMenuItem.__ENCList.RemoveRange(num, RestaurantPOS14.frmMenuItem.__ENCList.Count - num)
                    RestaurantPOS14.frmMenuItem.__ENCList.Capacity = RestaurantPOS14.frmMenuItem.__ENCList.Count
                End If

                Call RestaurantPOS14.frmMenuItem.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Public Sub GenerateBarcode()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT MAX(DishID) FROM Dish")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                If Microsoft.VisualBasic.Information.IsDBNull(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.cmd.ExecuteScalar())) Then
                    Me.txtBarcode.Text = 1.ToString()
                Else
                    Dim num As Integer = Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(RestaurantPOS14.ModClasses.cmd.ExecuteScalar(), 1))
                    Me.txtBarcode.Text = num.ToString()
                End If

                RestaurantPOS14.ModClasses.cmd.Dispose()
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con.Dispose()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub GenerateDishID()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT MAX(DishID) FROM Dish")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                If Microsoft.VisualBasic.Information.IsDBNull(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.cmd.ExecuteScalar())) Then
                    Me.txtDishID.Text = 1.ToString()
                Else
                    Dim num As Integer = Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(RestaurantPOS14.ModClasses.cmd.ExecuteScalar(), 1))
                    Me.txtDishID.Text = num.ToString()
                End If

                RestaurantPOS14.ModClasses.cmd.Dispose()
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con.Dispose()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub fillCombo()
            Try
                Dim sqlConnection As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.ReadCS())
                sqlConnection.Open()
                RestaurantPOS14.ModClasses.adp = New System.Data.SqlClient.SqlDataAdapter()
                RestaurantPOS14.ModClasses.adp.SelectCommand = New System.Data.SqlClient.SqlCommand("SELECT distinct RTRIM(CategoryName),Cat_ID FROM Category where CategoryName not in ('ZZ_DISABLED_PIZZA','Open Items') order by 2", sqlConnection)
                RestaurantPOS14.ModClasses.ds = New System.Data.DataSet("ds")
                RestaurantPOS14.ModClasses.adp.Fill(RestaurantPOS14.ModClasses.ds)
                Dim dataTable As System.Data.DataTable = RestaurantPOS14.ModClasses.ds.Tables(0)
                Me.cmbCategory.Items.Clear()
                For Each dataRow As System.Data.DataRow In dataTable.Rows
                    Me.cmbCategory.Items.Add(dataRow(CInt((0))).ToString())
                Next

                sqlConnection.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub Reset()
            Me.cmbCategory.SelectedIndex = -1
            Me.txtHDRate.Text = ""
            Me.txtTARate.Text = ""
            Me.txtDIRate.Text = ""
            Me.txtSearchByDish.Text = ""
            Me.txtItemName.Text = ""
            Me.txtItemNameArabic.Text = ""
            If RestaurantPOS14.ModFunc.IsSaveAllowed(Me.lblUser.Text, "Menu Items") Then
                Me.btnSave.Enabled = True
                Me.btnExportExcel.Enabled = True
            Else
                Me.btnSave.Enabled = False
                Me.btnExportExcel.Enabled = False
            End If

            If RestaurantPOS14.ModFunc.IsViewAllowed(Me.lblUser.Text, "Menu Items") Then
                Me.Getdata()
                Me.GroupBox1.Enabled = True
                Me.btnBarcodePrint.Enabled = True
            Else
                Me.btnBarcodePrint.Enabled = False
                Me.GroupBox1.Enabled = False
                Me.dgw.Rows.Clear()
            End If

            Me.btnUpdate.Enabled = False
            Me.btnDelete.Enabled = False
            Me.btnUIColor.BackColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.chkActive.Checked = True
            Me.txtBarcode.Text = ""
            Me.txtBCode.Text = ""
            Me.Picture.Image = RestaurantPOS14.My.Resources.Resources._12
            Me.txtImagePath.Text = ""
            Me.cmbFColor.SelectedIndex = 0
            Me.txtSearchByCategory.Text = ""
            Me.btnUIColor.ForeColor = System.Drawing.Color.White
            Me.GenerateBarcode()
        End Sub

        Private Sub btnClose_Click(sender As Object, e As System.EventArgs)
            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "Stock", TextCompare:=False) = 0 Then
                Call RestaurantPOS14.My.MyProject.Forms.frmStock_Store.fillItem()
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "Modifier", TextCompare:=False) = 0 Then
                Call RestaurantPOS14.My.MyProject.Forms.frmMenuItemsModifiers.fillCombo()
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "Recipe", TextCompare:=False) = 0 Then
                Call RestaurantPOS14.My.MyProject.Forms.frmRecipe.FillItems()
            End If

            MyBase.Close()
        End Sub

        Private Sub btnSave_Click(sender As Object, e As System.EventArgs)
            If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.txtItemName.Text)) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please enter item name", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtItemName.Focus()
                Return
            End If

            If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.cmbCategory.Text)) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please select category", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.cmbCategory.Focus()
                Return
            End If

            If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.txtBarcode.Text)) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please enter barcode", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtBarcode.Focus()
                Return
            End If

            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select DishName from Dish where DishName=@d1")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtItemName.Text)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Item Name Already Exists", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                    Me.txtItemName.Text = ""
                    Me.txtItemName.Focus()
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select Barcode from Dish where Barcode=@d1")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtBarcode.Text)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Barcode Already Exists", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                    Me.txtBarcode.Focus()
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                If Me.chkActive.Checked Then
                    Me.Item = "Active"
                Else
                    Me.Item = "Inactive"
                End If

                Me.GenerateDishID()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("insert into Dish(DishName,Category,DIRate,TARate,HDRate,BackColor,MI_Status,Barcode,DishID,Photo,DishNameArabic,FColor) VALUES (@d1,@d2," & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.txtDIRate.Text)) & "," & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.txtTARate.Text)) & "," & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.txtHDRate.Text)) & ",@d3,@d5,@d6," & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.txtDishID.Text)) & ",@d7,@d8,@d9)")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtItemName.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Me.cmbCategory.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Me.btnUIColor.BackColor.ToArgb())
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d5", Me.Item)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d6", Me.txtBarcode.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d8", Me.txtItemNameArabic.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d9", Me.cmbFColor.Text)
                If Not System.IO.Directory.Exists(RestaurantPOS14.Customization.ApplicationPathResolver.GetMenuImageDirectory()) Then
                    Call System.IO.Directory.CreateDirectory(RestaurantPOS14.Customization.ApplicationPathResolver.GetMenuImageDirectory())
                End If

                Me.ImagePath = System.Guid.NewGuid().ToString()
                Me.Picture.Image.Save(System.IO.Path.Combine(RestaurantPOS14.Customization.ApplicationPathResolver.GetMenuImageDirectory(), Me.ImagePath & ".jpg"))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d7", "\Menu Items Image\" & Me.ImagePath & ".jpg")
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                RestaurantPOS14.ModClasses.con.Close()
                Dim st As String = "added the new item '" & Me.txtItemName.Text & "'"
                RestaurantPOS14.ModFunc.LogFunc(Me.lblUser.Text, st)
                Call System.Windows.Forms.MessageBox.Show("Successfully saved", "Record", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                Me.txtItemName.Text = ""
                Me.txtDish.Text = ""
                If RestaurantPOS14.ModFunc.IsViewAllowed(Me.lblUser.Text, "Menu Items") Then
                    Me.Getdata()
                    Me.GroupBox1.Enabled = True
                    Me.btnBarcodePrint.Enabled = True
                Else
                    Me.btnBarcodePrint.Enabled = False
                    Me.GroupBox1.Enabled = False
                    Me.dgw.Rows.Clear()
                End If

                Me.GenerateBarcode()
                Me.Picture.Image = RestaurantPOS14.My.Resources.Resources._12
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
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select Dish.Dishname from Stock_Store_Join,Dish where Stock_Store_Join.Dish=Dish.DishName and Dish.DishName=@d1")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtItemName.Text)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Unable to delete..Already in use in Store Stock Entry", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select Dish.Dishname from Recipe,Dish where Recipe.Dish=Dish.DishName and Dish.DishName=@d1")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtItemName.Text)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Unable to delete..Already in use in Recipe", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select Dish.Dishname from RestaurantPOS_OrderedProductBillEB,Dish where RestaurantPOS_OrderedProductBillEB.Dish=Dish.DishName and Dish.DishName=@d1")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtItemName.Text)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Unable to delete..Already in use in Restaurant POS", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select Dish.Dishname from RestaurantPOS_OrderedProductBillHD,Dish where RestaurantPOS_OrderedProductBillHD.Dish=Dish.DishName and Dish.DishName=@d1")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtItemName.Text)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Unable to delete..Already in use in Restaurant POS", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select Dish.Dishname from RestaurantPOS_OrderedProductBillTA,Dish where RestaurantPOS_OrderedProductBillTA.Dish=Dish.DishName and Dish.DishName=@d1")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtItemName.Text)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Unable to delete..Already in use in Restaurant POS", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select Dish.Dishname from RestaurantPOS_OrderedProductBillKOT,Dish where RestaurantPOS_OrderedProductBillKOT.Dish=Dish.DishName and Dish.DishName=@d1")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtItemName.Text)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Unable to delete..Already in use in Restaurant POS", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select Dish.DishName from RestaurantPOS_OrderedProductKOT,Dish where RestaurantPOS_OrderedProductKOT.Dish=Dish.DishName and Dish.DishName=@d1")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtItemName.Text)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Unable to delete..Already in use in Restaurant POS", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("delete from Dish where DishName=@d1")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtItemName.Text)
                If RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery() > 0 Then
                    Dim st As String = "deleted the item '" & Me.txtItemName.Text & "'"
                    RestaurantPOS14.ModFunc.LogFunc(Me.lblUser.Text, st)
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

        Private Sub btnUpdate_Click(sender As Object, e As System.EventArgs)
            Try
                If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.txtItemName.Text)) = 0 Then
                    Call System.Windows.Forms.MessageBox.Show("Please enter item name", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Me.txtItemName.Focus()
                    Return
                End If

                If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.cmbCategory.Text)) = 0 Then
                    Call System.Windows.Forms.MessageBox.Show("Please select category", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Me.cmbCategory.Focus()
                    Return
                End If

                If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.txtBarcode.Text)) = 0 Then
                    Call System.Windows.Forms.MessageBox.Show("Please enter barcode", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Me.txtBarcode.Focus()
                    Return
                End If

                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtBarcode.Text, Me.txtBCode.Text, TextCompare:=False) <> 0 Then
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select Barcode from Dish where Barcode=@d1")
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtBarcode.Text)
                    RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                    RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                    If RestaurantPOS14.ModClasses.rdr.Read() Then
                        Call System.Windows.Forms.MessageBox.Show("Barcode Already Exists", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                        Me.txtBarcode.Text = ""
                        Me.txtBarcode.Focus()
                        If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                            RestaurantPOS14.ModClasses.rdr.Close()
                        End If

                        Return
                    End If
                End If

                If Me.chkActive.Checked Then
                    Me.Item = "Active"
                Else
                    Me.Item = "Inactive"
                End If

                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("update Dish set DishName=@d1,Category=@d2,DIRate=" & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.txtDIRate.Text)) & ",TARate=" & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.txtTARate.Text)) & ",HDRate=" & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.txtHDRate.Text)) & ",BackColor=@d4,MI_Status=@d6,Barcode=@d7,DishNameArabic=@d8,Photo=@d9,FColor=@d10 where DishName=@d3")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtItemName.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Me.cmbCategory.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Me.txtDish.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", Me.btnUIColor.BackColor.ToArgb())
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d6", Me.Item)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d7", Me.txtBarcode.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d8", Me.txtItemNameArabic.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d10", Me.cmbFColor.Text)
                If Not System.IO.Directory.Exists(RestaurantPOS14.Customization.ApplicationPathResolver.GetMenuImageDirectory()) Then
                    Call System.IO.Directory.CreateDirectory(RestaurantPOS14.Customization.ApplicationPathResolver.GetMenuImageDirectory())
                End If

                Me.ImagePath = System.Guid.NewGuid().ToString()
                Me.Picture.Image.Save(System.IO.Path.Combine(RestaurantPOS14.Customization.ApplicationPathResolver.GetMenuImageDirectory(), Me.ImagePath & ".jpg"))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d9", "\Menu Items Image\" & Me.ImagePath & ".jpg")
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                RestaurantPOS14.ModClasses.con.Close()
                Dim st As String = "updated the item '" & Me.txtItemName.Text & "' details"
                RestaurantPOS14.ModFunc.LogFunc(Me.lblUser.Text, st)
                Call System.Windows.Forms.MessageBox.Show("Successfully updated", "Item Info", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                Me.Reset()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub Getdata()
            Try
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT RTRIM(DishName),RTRIM(DishNameArabic), RTRIM(Category),DIRate,TARate,HDRate,RTRIM(Barcode),BackColor,RTRIM(MI_Status),RTRIM(Photo),RTRIM(FColor) from Dish order by DishName", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                Me.dgw.Rows.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Me.dgw.Rows.Add(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(0)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(1)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(2)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(3)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(4)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(5)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(6)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(7)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(8)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(9)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(10)))
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

        Private Sub frmDish_Load(sender As Object, e As System.EventArgs)
            Me.fillCombo()
        End Sub

        Private Sub dgw_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs)
            Try
                If Me.dgw.Rows.Count <= 0 Then
                    Return
                End If

                Dim dataGridViewRow As System.Windows.Forms.DataGridViewRow = Me.dgw.SelectedRows(0)
                Me.txtItemName.Text = dataGridViewRow.Cells(CInt((0))).Value.ToString()
                Me.txtDish.Text = dataGridViewRow.Cells(CInt((0))).Value.ToString()
                Me.txtItemNameArabic.Text = dataGridViewRow.Cells(CInt((1))).Value.ToString()
                Me.cmbCategory.Text = dataGridViewRow.Cells(CInt((2))).Value.ToString()
                Me.txtDIRate.Text = dataGridViewRow.Cells(CInt((3))).Value.ToString()
                Me.txtTARate.Text = dataGridViewRow.Cells(CInt((4))).Value.ToString()
                Me.txtHDRate.Text = dataGridViewRow.Cells(CInt((5))).Value.ToString()
                Me.txtBarcode.Text = dataGridViewRow.Cells(CInt((6))).Value.ToString()
                Me.txtBCode.Text = dataGridViewRow.Cells(CInt((6))).Value.ToString()
                Dim backColor As System.Drawing.Color = System.Drawing.Color.FromArgb(Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(dataGridViewRow.Cells(CInt((7))).Value))
                If Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells(CInt((8))).Value, "Active", TextCompare:=False) Then
                    Me.chkActive.Checked = True
                Else
                    Me.chkActive.Checked = False
                End If

                Me.txtImagePath.Text = dataGridViewRow.Cells(CInt((9))).Value.ToString()
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dataGridViewRow.Cells(CInt((9))).Value.ToString(), "", TextCompare:=False) = 0 Then
                    Me.Picture.Image = RestaurantPOS14.My.Resources.Resources._12
                Else
                    Dim path As String = System.Windows.Forms.Application.StartupPath & dataGridViewRow.Cells(CInt((9))).Value.ToString()
                    Dim path2 As String = RestaurantPOS14.Customization.ApplicationPathResolver.GetMenuImageDirectory()
                    Dim fileName As String = System.IO.Path.GetFileName(path)
                    If System.IO.File.Exists(System.IO.Path.Combine(path2, fileName)) Then
                        Me.Picture.Image = System.Drawing.Image.FromFile(System.IO.Path.Combine(path2, fileName))
                    Else
                        Me.Picture.Image = RestaurantPOS14.My.Resources.Resources._12
                    End If
                End If

                Me.btnUIColor.BackColor = backColor
                If RestaurantPOS14.ModFunc.IsDeleteAllowed(Me.lblUser.Text, "Menu Items") Then
                    Me.btnDelete.Enabled = True
                Else
                    Me.btnDelete.Enabled = False
                End If

                If RestaurantPOS14.ModFunc.IsUpdateAllowed(Me.lblUser.Text, "Menu Items") Then
                    Me.btnUpdate.Enabled = True
                Else
                    Me.btnUpdate.Enabled = False
                End If

                Me.btnSave.Enabled = False
                Me.cmbFColor.Text = dataGridViewRow.Cells(CInt((10))).Value.ToString()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub txtServiceTax_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
            Dim keyChar As Char = e.KeyChar
            If Char.IsControl(keyChar) Then
                Return
            End If

            If Char.IsDigit(keyChar) OrElse keyChar = "."c Then
                Dim text As String = Me.txtDIRate.Text
                Dim selectionStart As Integer = Me.txtDIRate.SelectionStart
                Dim selectionLength As Integer = Me.txtDIRate.SelectionLength
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

        Private Sub txtFirstName_TextChanged(sender As Object, e As System.EventArgs)
            Try
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT RTRIM(DishName),RTRIM(DishNameArabic), RTRIM(Category),DIRate,TARate,HDRate,RTRIM(Barcode),BackColor,RTRIM(MI_Status),RTRIM(Photo),RTRIM(FColor) from Dish where DishName like N'%" & Me.txtSearchByDish.Text & "%' order by DishName", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                Me.dgw.Rows.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Me.dgw.Rows.Add(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(0)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(1)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(2)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(3)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(4)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(5)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(6)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(7)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(8)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(9)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(10)))
                End While

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub LinkLabel1_LinkClicked(sender As Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
            Try
                If Me.ColorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                    Me.btnUIColor.BackColor = Me.ColorDialog1.Color
                End If
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnExportExcel_Click(sender As Object, e As System.EventArgs)
            Call RestaurantPOS14.My.MyProject.Forms.frmMenuItemsExportImport.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmMenuItemsExportImport.ShowDialog()
        End Sub

        Private Sub txtTARate_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
            Dim keyChar As Char = e.KeyChar
            If Char.IsControl(keyChar) Then
                Return
            End If

            If Char.IsDigit(keyChar) OrElse keyChar = "."c Then
                Dim text As String = Me.txtTARate.Text
                Dim selectionStart As Integer = Me.txtTARate.SelectionStart
                Dim selectionLength As Integer = Me.txtTARate.SelectionLength
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

        Private Sub txtHDRate_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
            Dim keyChar As Char = e.KeyChar
            If Char.IsControl(keyChar) Then
                Return
            End If

            If Char.IsDigit(keyChar) OrElse keyChar = "."c Then
                Dim text As String = Me.txtHDRate.Text
                Dim selectionStart As Integer = Me.txtHDRate.SelectionStart
                Dim selectionLength As Integer = Me.txtHDRate.SelectionLength
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

        Private Sub btnBarcodePrint_Click(sender As Object, e As System.EventArgs)
            Call RestaurantPOS14.My.MyProject.Forms.frmBarcodeLabelPrinting.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmBarcodeLabelPrinting.ShowDialog()
        End Sub

        Private Sub Browse_Click(sender As Object, e As System.EventArgs)
            Try
                Dim openFileDialog As System.Windows.Forms.OpenFileDialog = Me.OpenFileDialog1
                openFileDialog.Filter = "Images |*.png; *.bmp; *.jpg;*.jpeg; *.gif;"
                openFileDialog.FilterIndex = 4
                Me.OpenFileDialog1.FileName = ""
                If Me.OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                    Me.Picture.Image = System.Drawing.Image.FromFile(Me.OpenFileDialog1.FileName)
                End If
            Catch ex As System.Exception
                Call Microsoft.VisualBasic.Interaction.MsgBox(ex.ToString())
            End Try
        End Sub

        Private Sub BRemove_Click(sender As Object, e As System.EventArgs)
            Me.Picture.Image = RestaurantPOS14.My.Resources.Resources._12
        End Sub

        Private Sub btnUpdateImage_Click(sender As Object, e As System.EventArgs)
            Try
                If Not System.IO.Directory.Exists(RestaurantPOS14.Customization.ApplicationPathResolver.GetMenuImageDirectory()) Then
                    Call System.IO.Directory.CreateDirectory(RestaurantPOS14.Customization.ApplicationPathResolver.GetMenuImageDirectory())
                End If

                Me.Picture.Image.Save(System.Windows.Forms.Application.StartupPath & Me.txtImagePath.Text)
                Call System.Windows.Forms.MessageBox.Show("Successfully updated", "Item Image", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                Me.Getdata()
                Me.Reset()
            Catch __unusedException1__ As System.Exception
                Call System.Windows.Forms.MessageBox.Show("Unable to update image because same image is " & Global.Microsoft.VisualBasic.Constants.vbCrLf & "already used by another process." & Global.Microsoft.VisualBasic.Constants.vbCrLf & "restart the application and try again!", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnAddItems_Click(sender As Object, e As System.EventArgs)
            Call RestaurantPOS14.My.MyProject.Forms.frmMenuItemsList.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmMenuItemsList.ShowDialog()
        End Sub

        Private Sub btnAdd_Click_1(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmMenuItemsCategory.lblUser.Text = Me.lblUser.Text
            RestaurantPOS14.My.MyProject.Forms.frmMenuItemsCategory.lblSet.Text = "MI"
            Call RestaurantPOS14.My.MyProject.Forms.frmMenuItemsCategory.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmMenuItemsCategory.ShowDialog()
        End Sub

        Private Sub txtSearchByCategory_TextChanged(sender As Object, e As System.EventArgs)
            Try
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT RTRIM(DishName),RTRIM(DishNameArabic), RTRIM(Category),DIRate,TARate,HDRate,RTRIM(Barcode),BackColor,RTRIM(MI_Status),RTRIM(Photo),RTRIM(FColor) from Dish where Category like N'%" & Me.txtSearchByCategory.Text & "%' order by DishName", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                Me.dgw.Rows.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Me.dgw.Rows.Add(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(0)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(1)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(2)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(3)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(4)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(5)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(6)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(7)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(8)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(9)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(10)))
                End While

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnMenuItemsModifiers_ClickButtonArea(Sender As Object, e As System.Windows.Forms.MouseEventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmMenuItemsModifiers.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmMenuItemsModifiers.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmMenuItemsModifiers.ShowDialog()
        End Sub

        Private Sub cmbFColor_SelectedIndexChanged(sender As Object, e As System.EventArgs)
            If Me.cmbFColor.SelectedIndex = 0 Then
                Me.btnUIColor.ForeColor = System.Drawing.Color.White
            Else
                Me.btnUIColor.ForeColor = System.Drawing.Color.Black
            End If
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmMenuItem))
            Dim dataGridViewCellStyle As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.btnMenuItemsModifiers = New CButtonLib.CButton()
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.txtSearchByCategory = New System.Windows.Forms.TextBox()
            Me.lblSet = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.txtImagePath = New System.Windows.Forms.TextBox()
            Me.Picture = New System.Windows.Forms.PictureBox()
            Me.BRemove = New System.Windows.Forms.Button()
            Me.Browse = New System.Windows.Forms.Button()
            Me.btnBarcodePrint = New System.Windows.Forms.Button()
            Me.btnExportExcel = New System.Windows.Forms.Button()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.btnDelete = New System.Windows.Forms.Button()
            Me.btnUpdate = New System.Windows.Forms.Button()
            Me.btnNew = New System.Windows.Forms.Button()
            Me.btnSave = New System.Windows.Forms.Button()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.cmbFColor = New System.Windows.Forms.ComboBox()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.btnAdd = New System.Windows.Forms.Button()
            Me.btnAddItems = New System.Windows.Forms.Button()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.txtItemNameArabic = New System.Windows.Forms.TextBox()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.txtHDRate = New System.Windows.Forms.TextBox()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.txtTARate = New System.Windows.Forms.TextBox()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.txtBarcode = New System.Windows.Forms.TextBox()
            Me.chkActive = New System.Windows.Forms.CheckBox()
            Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
            Me.btnUIColor = New System.Windows.Forms.Button()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtItemName = New System.Windows.Forms.TextBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtDIRate = New System.Windows.Forms.TextBox()
            Me.cmbCategory = New System.Windows.Forms.ComboBox()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.txtSearchByDish = New System.Windows.Forms.TextBox()
            Me.btnClose = New System.Windows.Forms.Button()
            Me.dgw = New System.Windows.Forms.DataGridView()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.txtDishID = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtBCode = New System.Windows.Forms.TextBox()
            Me.txtDish = New System.Windows.Forms.TextBox()
            Me.lblUser = New System.Windows.Forms.Label()
            Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
            Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
            Me.Panel1.SuspendLayout()
            Me.GroupBox4.SuspendLayout()
            CType(Me.Picture, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox3.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel2.SuspendLayout()
            MyBase.SuspendLayout()
            Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.Panel1.BackColor = System.Drawing.Color.White
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.btnMenuItemsModifiers)
            Me.Panel1.Controls.Add(Me.GroupBox4)
            Me.Panel1.Controls.Add(Me.lblSet)
            Me.Panel1.Controls.Add(Me.Label6)
            Me.Panel1.Controls.Add(Me.txtImagePath)
            Me.Panel1.Controls.Add(Me.Picture)
            Me.Panel1.Controls.Add(Me.BRemove)
            Me.Panel1.Controls.Add(Me.Browse)
            Me.Panel1.Controls.Add(Me.btnBarcodePrint)
            Me.Panel1.Controls.Add(Me.btnExportExcel)
            Me.Panel1.Controls.Add(Me.GroupBox3)
            Me.Panel1.Controls.Add(Me.GroupBox2)
            Me.Panel1.Controls.Add(Me.GroupBox1)
            Me.Panel1.Controls.Add(Me.btnClose)
            Me.Panel1.Controls.Add(Me.dgw)
            Me.Panel1.Controls.Add(Me.Panel2)
            Me.Panel1.Controls.Add(Me.txtDish)
            Me.Panel1.Controls.Add(Me.lblUser)
            Dim panel As System.Windows.Forms.Panel = Me.Panel1
            Dim location As System.Drawing.Point = New System.Drawing.Point(3, 3)
            panel.Location = location
            Me.Panel1.Name = "Panel1"
            Dim panel2 As System.Windows.Forms.Panel = Me.Panel1
            Dim size As System.Drawing.Size = New System.Drawing.Size(1009, 653)
            panel2.Size = size
            Me.Panel1.TabIndex = 2
            Me.btnMenuItemsModifiers.BackColor = System.Drawing.Color.Transparent
            Me.btnMenuItemsModifiers.BorderColor = System.Drawing.Color.Transparent
            cBlendItems.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnMenuItemsModifiers.ColorFillBlend = cBlendItems
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
            Dim cButton As CButtonLib.CButton = Me.btnMenuItemsModifiers
            size = New System.Drawing.Size(50, 50)
            cButton.ImageSize = size
            Dim cButton2 As CButtonLib.CButton = Me.btnMenuItemsModifiers
            location = New System.Drawing.Point(700, 284)
            cButton2.Location = location
            Dim cButton3 As CButtonLib.CButton = Me.btnMenuItemsModifiers
            Dim margin As System.Windows.Forms.Padding = New System.Windows.Forms.Padding(1)
            cButton3.Margin = margin
            Me.btnMenuItemsModifiers.Name = "btnMenuItemsModifiers"
            Dim cButton4 As CButtonLib.CButton = Me.btnMenuItemsModifiers
            size = New System.Drawing.Size(179, 72)
            cButton4.Size = size
            Me.btnMenuItemsModifiers.TabIndex = 299
            Me.btnMenuItemsModifiers.Text = "Menu Items Modifiers"
            Me.btnMenuItemsModifiers.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnMenuItemsModifiers.TextShadowShow = False
            Me.btnMenuItemsModifiers.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.GroupBox4.Controls.Add(Me.txtSearchByCategory)
            Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim groupBox As System.Windows.Forms.GroupBox = Me.GroupBox4
            location = New System.Drawing.Point(212, 288)
            groupBox.Location = location
            Me.GroupBox4.Name = "GroupBox4"
            Dim groupBox2 As System.Windows.Forms.GroupBox = Me.GroupBox4
            size = New System.Drawing.Size(202, 68)
            groupBox2.Size = size
            Me.GroupBox4.TabIndex = 298
            Me.GroupBox4.TabStop = False
            Me.GroupBox4.Text = "Search By Category :"
            Me.txtSearchByCategory.BackColor = System.Drawing.Color.White
            Me.txtSearchByCategory.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox As System.Windows.Forms.TextBox = Me.txtSearchByCategory
            location = New System.Drawing.Point(22, 29)
            textBox.Location = location
            Me.txtSearchByCategory.Name = "txtSearchByCategory"
            Dim textBox2 As System.Windows.Forms.TextBox = Me.txtSearchByCategory
            size = New System.Drawing.Size(172, 23)
            textBox2.Size = size
            Me.txtSearchByCategory.TabIndex = 0
            Me.lblSet.AutoSize = True
            Dim label As System.Windows.Forms.Label = Me.lblSet
            location = New System.Drawing.Point(357, 379)
            label.Location = location
            Me.lblSet.Name = "lblSet"
            Dim label2 As System.Windows.Forms.Label = Me.lblSet
            size = New System.Drawing.Size(33, 13)
            label2.Size = size
            Me.lblSet.TabIndex = 297
            Me.lblSet.Text = "lblSet"
            Me.lblSet.Visible = False
            Me.Label6.AutoSize = True
            Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label6.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0)
            Dim label3 As System.Windows.Forms.Label = Me.Label6
            location = New System.Drawing.Point(527, 233)
            label3.Location = location
            Me.Label6.Name = "Label6"
            Dim label4 As System.Windows.Forms.Label = Me.Label6
            size = New System.Drawing.Size(157, 30)
            label4.Size = size
            Me.Label6.TabIndex = 296
            Me.Label6.Text = "(Browse Image of Max Size" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "15 to 20 KB only.)"
            Dim textBox3 As System.Windows.Forms.TextBox = Me.txtImagePath
            location = New System.Drawing.Point(424, 313)
            textBox3.Location = location
            Me.txtImagePath.Name = "txtImagePath"
            Dim textBox4 As System.Windows.Forms.TextBox = Me.txtImagePath
            size = New System.Drawing.Size(100, 20)
            textBox4.Size = size
            Me.txtImagePath.TabIndex = 295
            Me.txtImagePath.Visible = False
            Me.Picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Picture.Image = RestaurantPOS14.My.Resources.Resources._12
            Dim picture As System.Windows.Forms.PictureBox = Me.Picture
            location = New System.Drawing.Point(530, 47)
            picture.Location = location
            Me.Picture.Name = "Picture"
            Dim picture2 As System.Windows.Forms.PictureBox = Me.Picture
            size = New System.Drawing.Size(112, 94)
            picture2.Size = size
            Me.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.Picture.TabIndex = 294
            Me.Picture.TabStop = False
            Me.BRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.BRemove.ForeColor = System.Drawing.Color.Black
            Me.BRemove.Image = CType(componentResourceManager.GetObject("BRemove.Image"), System.Drawing.Image)
            Me.BRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim bRemove As System.Windows.Forms.Button = Me.BRemove
            location = New System.Drawing.Point(530, 180)
            bRemove.Location = location
            Me.BRemove.Name = "BRemove"
            Dim bRemove2 As System.Windows.Forms.Button = Me.BRemove
            size = New System.Drawing.Size(112, 35)
            bRemove2.Size = size
            Me.BRemove.TabIndex = 1
            Me.BRemove.Text = "Remove"
            Me.BRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.BRemove.UseVisualStyleBackColor = True
            Me.Browse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.Browse.ForeColor = System.Drawing.Color.Black
            Me.Browse.Image = CType(componentResourceManager.GetObject("Browse.Image"), System.Drawing.Image)
            Me.Browse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim browse As System.Windows.Forms.Button = Me.Browse
            location = New System.Drawing.Point(530, 144)
            browse.Location = location
            Me.Browse.Name = "Browse"
            Dim browse2 As System.Windows.Forms.Button = Me.Browse
            size = New System.Drawing.Size(112, 35)
            browse2.Size = size
            Me.Browse.TabIndex = 0
            Me.Browse.Text = "Browse..."
            Me.Browse.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Browse.UseVisualStyleBackColor = True
            Me.btnBarcodePrint.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnBarcodePrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnBarcodePrint.Image = CType(componentResourceManager.GetObject("btnBarcodePrint.Image"), System.Drawing.Image)
            Me.btnBarcodePrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button As System.Windows.Forms.Button = Me.btnBarcodePrint
            location = New System.Drawing.Point(567, 284)
            button.Location = location
            Me.btnBarcodePrint.Name = "btnBarcodePrint"
            Dim button2 As System.Windows.Forms.Button = Me.btnBarcodePrint
            size = New System.Drawing.Size(129, 72)
            button2.Size = size
            Me.btnBarcodePrint.TabIndex = 8
            Me.btnBarcodePrint.Text = "Barcode Print"
            Me.btnBarcodePrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnBarcodePrint.UseVisualStyleBackColor = True
            Me.btnExportExcel.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnExportExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnExportExcel.Image = CType(componentResourceManager.GetObject("btnExportExcel.Image"), System.Drawing.Image)
            Me.btnExportExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button3 As System.Windows.Forms.Button = Me.btnExportExcel
            location = New System.Drawing.Point(432, 284)
            button3.Location = location
            Me.btnExportExcel.Name = "btnExportExcel"
            Dim button4 As System.Windows.Forms.Button = Me.btnExportExcel
            size = New System.Drawing.Size(129, 72)
            button4.Size = size
            Me.btnExportExcel.TabIndex = 6
            Me.btnExportExcel.Text = "Import/Export Excel"
            Me.btnExportExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnExportExcel.UseVisualStyleBackColor = True
            Me.GroupBox3.Controls.Add(Me.btnDelete)
            Me.GroupBox3.Controls.Add(Me.btnUpdate)
            Me.GroupBox3.Controls.Add(Me.btnNew)
            Me.GroupBox3.Controls.Add(Me.btnSave)
            Dim groupBox3 As System.Windows.Forms.GroupBox = Me.GroupBox3
            location = New System.Drawing.Point(646, 38)
            groupBox3.Location = location
            Me.GroupBox3.Name = "GroupBox3"
            Dim groupBox4 As System.Windows.Forms.GroupBox = Me.GroupBox3
            size = New System.Drawing.Size(99, 191)
            groupBox4.Size = size
            Me.GroupBox3.TabIndex = 4
            Me.GroupBox3.TabStop = False
            Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnDelete.Image = CType(componentResourceManager.GetObject("btnDelete.Image"), System.Drawing.Image)
            Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button5 As System.Windows.Forms.Button = Me.btnDelete
            location = New System.Drawing.Point(8, 141)
            button5.Location = location
            Me.btnDelete.Name = "btnDelete"
            Dim button6 As System.Windows.Forms.Button = Me.btnDelete
            size = New System.Drawing.Size(82, 37)
            button6.Size = size
            Me.btnDelete.TabIndex = 3
            Me.btnDelete.Text = "Delete"
            Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnDelete.UseVisualStyleBackColor = True
            Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnUpdate.Image = CType(componentResourceManager.GetObject("btnUpdate.Image"), System.Drawing.Image)
            Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button7 As System.Windows.Forms.Button = Me.btnUpdate
            location = New System.Drawing.Point(8, 99)
            button7.Location = location
            Me.btnUpdate.Name = "btnUpdate"
            Dim button8 As System.Windows.Forms.Button = Me.btnUpdate
            size = New System.Drawing.Size(82, 37)
            button8.Size = size
            Me.btnUpdate.TabIndex = 2
            Me.btnUpdate.Text = "Update"
            Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnUpdate.UseVisualStyleBackColor = True
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
            Me.GroupBox2.Controls.Add(Me.cmbFColor)
            Me.GroupBox2.Controls.Add(Me.Label10)
            Me.GroupBox2.Controls.Add(Me.btnAdd)
            Me.GroupBox2.Controls.Add(Me.btnAddItems)
            Me.GroupBox2.Controls.Add(Me.Label5)
            Me.GroupBox2.Controls.Add(Me.txtItemNameArabic)
            Me.GroupBox2.Controls.Add(Me.Label9)
            Me.GroupBox2.Controls.Add(Me.txtHDRate)
            Me.GroupBox2.Controls.Add(Me.Label8)
            Me.GroupBox2.Controls.Add(Me.txtTARate)
            Me.GroupBox2.Controls.Add(Me.Label7)
            Me.GroupBox2.Controls.Add(Me.txtBarcode)
            Me.GroupBox2.Controls.Add(Me.chkActive)
            Me.GroupBox2.Controls.Add(Me.LinkLabel1)
            Me.GroupBox2.Controls.Add(Me.btnUIColor)
            Me.GroupBox2.Controls.Add(Me.Label3)
            Me.GroupBox2.Controls.Add(Me.Label2)
            Me.GroupBox2.Controls.Add(Me.txtItemName)
            Me.GroupBox2.Controls.Add(Me.Label4)
            Me.GroupBox2.Controls.Add(Me.txtDIRate)
            Me.GroupBox2.Controls.Add(Me.cmbCategory)
            Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim groupBox5 As System.Windows.Forms.GroupBox = Me.GroupBox2
            location = New System.Drawing.Point(4, 38)
            groupBox5.Location = location
            Me.GroupBox2.Name = "GroupBox2"
            Dim groupBox6 As System.Windows.Forms.GroupBox = Me.GroupBox2
            size = New System.Drawing.Size(520, 244)
            groupBox6.Size = size
            Me.GroupBox2.TabIndex = 0
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Item Details"
            Me.cmbFColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbFColor.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.cmbFColor.FormattingEnabled = True
            Me.cmbFColor.Items.AddRange(New Object(1) {"White", "Black"})
            Dim comboBox As System.Windows.Forms.ComboBox = Me.cmbFColor
            location = New System.Drawing.Point(125, 207)
            comboBox.Location = location
            Me.cmbFColor.Name = "cmbFColor"
            Dim comboBox2 As System.Windows.Forms.ComboBox = Me.cmbFColor
            size = New System.Drawing.Size(128, 23)
            comboBox2.Size = size
            Me.cmbFColor.TabIndex = 9
            Me.Label10.AutoSize = True
            Dim label5 As System.Windows.Forms.Label = Me.Label10
            location = New System.Drawing.Point(6, 210)
            label5.Location = location
            Me.Label10.Name = "Label10"
            Dim label6 As System.Windows.Forms.Label = Me.Label10
            size = New System.Drawing.Size(103, 15)
            label6.Size = size
            Me.Label10.TabIndex = 314
            Me.Label10.Text = "Button ForeColor :"
            Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnAdd.Image = RestaurantPOS14.My.Resources.Resources._1__2_
            Dim button13 As System.Windows.Forms.Button = Me.btnAdd
            location = New System.Drawing.Point(259, 109)
            button13.Location = location
            Me.btnAdd.Name = "btnAdd"
            Dim button14 As System.Windows.Forms.Button = Me.btnAdd
            size = New System.Drawing.Size(31, 23)
            button14.Size = size
            Me.btnAdd.TabIndex = 313
            Me.btnAdd.UseVisualStyleBackColor = True
            Me.btnAddItems.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.btnAddItems.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnAddItems.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnAddItems.ForeColor = System.Drawing.Color.White
            Me.btnAddItems.Image = CType(componentResourceManager.GetObject("btnAddItems.Image"), System.Drawing.Image)
            Me.btnAddItems.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button15 As System.Windows.Forms.Button = Me.btnAddItems
            location = New System.Drawing.Point(478, 24)
            button15.Location = location
            Me.btnAddItems.Name = "btnAddItems"
            Dim button16 As System.Windows.Forms.Button = Me.btnAddItems
            size = New System.Drawing.Size(39, 34)
            button16.Size = size
            Me.btnAddItems.TabIndex = 312
            Me.btnAddItems.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnAddItems.UseVisualStyleBackColor = False
            Me.Label5.AutoSize = True
            Dim label7 As System.Windows.Forms.Label = Me.Label5
            location = New System.Drawing.Point(6, 66)
            label7.Location = location
            Me.Label5.Name = "Label5"
            Dim label8 As System.Windows.Forms.Label = Me.Label5
            size = New System.Drawing.Size(118, 15)
            label8.Size = size
            Me.Label5.TabIndex = 311
            Me.Label5.Text = "Item Name (Arabic) :"
            Me.txtItemNameArabic.BackColor = System.Drawing.Color.White
            Me.txtItemNameArabic.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox5 As System.Windows.Forms.TextBox = Me.txtItemNameArabic
            location = New System.Drawing.Point(125, 66)
            textBox5.Location = location
            Me.txtItemNameArabic.Multiline = True
            Me.txtItemNameArabic.Name = "txtItemNameArabic"
            Me.txtItemNameArabic.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.txtItemNameArabic.ScrollBars = System.Windows.Forms.ScrollBars.Both
            Dim textBox6 As System.Windows.Forms.TextBox = Me.txtItemNameArabic
            size = New System.Drawing.Size(350, 37)
            textBox6.Size = size
            Me.txtItemNameArabic.TabIndex = 1
            Me.Label9.AutoSize = True
            Dim label9 As System.Windows.Forms.Label = Me.Label9
            location = New System.Drawing.Point(396, 122)
            label9.Location = location
            Me.Label9.Name = "Label9"
            Dim label10 As System.Windows.Forms.Label = Me.Label9
            size = New System.Drawing.Size(118, 15)
            label10.Size = size
            Me.Label9.TabIndex = 309
            Me.Label9.Text = "Home Delivery Rate :"
            Me.txtHDRate.BackColor = System.Drawing.Color.White
            Me.txtHDRate.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox7 As System.Windows.Forms.TextBox = Me.txtHDRate
            location = New System.Drawing.Point(397, 140)
            textBox7.Location = location
            Me.txtHDRate.Name = "txtHDRate"
            Dim textBox8 As System.Windows.Forms.TextBox = Me.txtHDRate
            size = New System.Drawing.Size(94, 23)
            textBox8.Size = size
            Me.txtHDRate.TabIndex = 5
            Me.txtHDRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.Label8.AutoSize = True
            Dim label11 As System.Windows.Forms.Label = Me.Label8
            location = New System.Drawing.Point(294, 122)
            label11.Location = location
            Me.Label8.Name = "Label8"
            Dim label12 As System.Windows.Forms.Label = Me.Label8
            size = New System.Drawing.Size(95, 15)
            label12.Size = size
            Me.Label8.TabIndex = 307
            Me.Label8.Text = "Take Away Rate :"
            Me.txtTARate.BackColor = System.Drawing.Color.White
            Me.txtTARate.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox9 As System.Windows.Forms.TextBox = Me.txtTARate
            location = New System.Drawing.Point(297, 140)
            textBox9.Location = location
            Me.txtTARate.Name = "txtTARate"
            Dim textBox10 As System.Windows.Forms.TextBox = Me.txtTARate
            size = New System.Drawing.Size(94, 23)
            textBox10.Size = size
            Me.txtTARate.TabIndex = 4
            Me.txtTARate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.Label7.AutoSize = True
            Dim label13 As System.Windows.Forms.Label = Me.Label7
            location = New System.Drawing.Point(334, 167)
            label13.Location = location
            Me.Label7.Name = "Label7"
            Dim label14 As System.Windows.Forms.Label = Me.Label7
            size = New System.Drawing.Size(56, 15)
            label14.Size = size
            Me.Label7.TabIndex = 305
            Me.Label7.Text = "Barcode :"
            Me.txtBarcode.BackColor = System.Drawing.Color.White
            Me.txtBarcode.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox11 As System.Windows.Forms.TextBox = Me.txtBarcode
            location = New System.Drawing.Point(337, 185)
            textBox11.Location = location
            Me.txtBarcode.Name = "txtBarcode"
            Dim textBox12 As System.Windows.Forms.TextBox = Me.txtBarcode
            size = New System.Drawing.Size(173, 23)
            textBox12.Size = size
            Me.txtBarcode.TabIndex = 8
            Me.txtBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.chkActive.AutoSize = True
            Me.chkActive.Font = New System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim checkBox As System.Windows.Forms.CheckBox = Me.chkActive
            location = New System.Drawing.Point(238, 166)
            checkBox.Location = location
            Me.chkActive.Name = "chkActive"
            Dim checkBox2 As System.Windows.Forms.CheckBox = Me.chkActive
            size = New System.Drawing.Size(85, 29)
            checkBox2.Size = size
            Me.chkActive.TabIndex = 7
            Me.chkActive.Text = "Active"
            Me.chkActive.UseVisualStyleBackColor = True
            Me.LinkLabel1.AutoSize = True
            Me.LinkLabel1.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim linkLabel As System.Windows.Forms.LinkLabel = Me.LinkLabel1
            location = New System.Drawing.Point(121, 170)
            linkLabel.Location = location
            Me.LinkLabel1.Name = "LinkLabel1"
            Dim linkLabel2 As System.Windows.Forms.LinkLabel = Me.LinkLabel1
            size = New System.Drawing.Size(101, 21)
            linkLabel2.Size = size
            Me.LinkLabel1.TabIndex = 6
            Me.LinkLabel1.TabStop = True
            Me.LinkLabel1.Text = "Select Color"
            Me.btnUIColor.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.btnUIColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnUIColor.ForeColor = System.Drawing.Color.White
            Dim button17 As System.Windows.Forms.Button = Me.btnUIColor
            location = New System.Drawing.Point(9, 167)
            button17.Location = location
            Me.btnUIColor.Name = "btnUIColor"
            Dim button18 As System.Windows.Forms.Button = Me.btnUIColor
            size = New System.Drawing.Size(106, 31)
            button18.Size = size
            Me.btnUIColor.TabIndex = 10
            Me.btnUIColor.Text = "Button UI Color"
            Me.btnUIColor.UseVisualStyleBackColor = False
            Me.Label3.AutoSize = True
            Dim label15 As System.Windows.Forms.Label = Me.Label3
            location = New System.Drawing.Point(6, 26)
            label15.Location = location
            Me.Label3.Name = "Label3"
            Dim label16 As System.Windows.Forms.Label = Me.Label3
            size = New System.Drawing.Size(99, 15)
            label16.Size = size
            Me.Label3.TabIndex = 0
            Me.Label3.Text = "Item Name (EN) :"
            Me.Label2.AutoSize = True
            Dim label17 As System.Windows.Forms.Label = Me.Label2
            location = New System.Drawing.Point(6, 109)
            label17.Location = location
            Me.Label2.Name = "Label2"
            Dim label18 As System.Windows.Forms.Label = Me.Label2
            size = New System.Drawing.Size(60, 15)
            label18.Size = size
            Me.Label2.TabIndex = 5
            Me.Label2.Text = "Category :"
            Me.txtItemName.BackColor = System.Drawing.Color.White
            Me.txtItemName.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox13 As System.Windows.Forms.TextBox = Me.txtItemName
            location = New System.Drawing.Point(125, 23)
            textBox13.Location = location
            Me.txtItemName.Multiline = True
            Me.txtItemName.Name = "txtItemName"
            Me.txtItemName.ScrollBars = System.Windows.Forms.ScrollBars.Both
            Dim textBox14 As System.Windows.Forms.TextBox = Me.txtItemName
            size = New System.Drawing.Size(350, 38)
            textBox14.Size = size
            Me.txtItemName.TabIndex = 0
            Me.Label4.AutoSize = True
            Dim label19 As System.Windows.Forms.Label = Me.Label4
            location = New System.Drawing.Point(6, 140)
            label19.Location = location
            Me.Label4.Name = "Label4"
            Dim label20 As System.Windows.Forms.Label = Me.Label4
            size = New System.Drawing.Size(125, 15)
            label20.Size = size
            Me.Label4.TabIndex = 6
            Me.Label4.Text = "Dine In /Express Rate :"
            Me.txtDIRate.BackColor = System.Drawing.Color.White
            Me.txtDIRate.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox15 As System.Windows.Forms.TextBox = Me.txtDIRate
            location = New System.Drawing.Point(196, 138)
            textBox15.Location = location
            Me.txtDIRate.Name = "txtDIRate"
            Dim textBox16 As System.Windows.Forms.TextBox = Me.txtDIRate
            size = New System.Drawing.Size(94, 23)
            textBox16.Size = size
            Me.txtDIRate.TabIndex = 3
            Me.txtDIRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbCategory.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.cmbCategory.FormattingEnabled = True
            Dim comboBox3 As System.Windows.Forms.ComboBox = Me.cmbCategory
            location = New System.Drawing.Point(125, 109)
            comboBox3.Location = location
            Me.cmbCategory.Name = "cmbCategory"
            Dim comboBox4 As System.Windows.Forms.ComboBox = Me.cmbCategory
            size = New System.Drawing.Size(128, 23)
            comboBox4.Size = size
            Me.cmbCategory.TabIndex = 2
            Me.GroupBox1.Controls.Add(Me.txtSearchByDish)
            Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim groupBox7 As System.Windows.Forms.GroupBox = Me.GroupBox1
            location = New System.Drawing.Point(4, 288)
            groupBox7.Location = location
            Me.GroupBox1.Name = "GroupBox1"
            Dim groupBox8 As System.Windows.Forms.GroupBox = Me.GroupBox1
            size = New System.Drawing.Size(202, 68)
            groupBox8.Size = size
            Me.GroupBox1.TabIndex = 3
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Search By Item Name (EN) :"
            Me.txtSearchByDish.BackColor = System.Drawing.Color.White
            Me.txtSearchByDish.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox17 As System.Windows.Forms.TextBox = Me.txtSearchByDish
            location = New System.Drawing.Point(22, 29)
            textBox17.Location = location
            Me.txtSearchByDish.Name = "txtSearchByDish"
            Dim textBox18 As System.Windows.Forms.TextBox = Me.txtSearchByDish
            size = New System.Drawing.Size(172, 23)
            textBox18.Size = size
            Me.txtSearchByDish.TabIndex = 0
            Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
            Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnClose.Image = CType(componentResourceManager.GetObject("btnClose.Image"), System.Drawing.Image)
            Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button19 As System.Windows.Forms.Button = Me.btnClose
            location = New System.Drawing.Point(918, 2)
            button19.Location = location
            Me.btnClose.Name = "btnClose"
            Dim button20 As System.Windows.Forms.Button = Me.btnClose
            size = New System.Drawing.Size(82, 37)
            button20.Size = size
            Me.btnClose.TabIndex = 4
            Me.btnClose.Text = "Close"
            Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnClose.UseVisualStyleBackColor = True
            Me.dgw.AllowUserToAddRows = False
            Me.dgw.AllowUserToDeleteRows = False
            dataGridViewCellStyle.BackColor = System.Drawing.Color.FloralWhite
            Me.dgw.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle
            Me.dgw.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.dgw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            Me.dgw.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
            Me.dgw.BackgroundColor = System.Drawing.Color.White
            Me.dgw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            dataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgw.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2
            Me.dgw.ColumnHeadersHeight = 40
            Me.dgw.Columns.AddRange(Me.Column1, Me.Column10, Me.Column2, Me.Column3, Me.Column4, Me.Column9, Me.Column8, Me.Column5, Me.Column7, Me.Column6, Me.Column11)
            Me.dgw.Cursor = System.Windows.Forms.Cursors.Hand
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            dataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgw.DefaultCellStyle = dataGridViewCellStyle3
            Me.dgw.EnableHeadersVisualStyles = False
            Me.dgw.GridColor = System.Drawing.Color.White
            Dim dataGridView As System.Windows.Forms.DataGridView = Me.dgw
            location = New System.Drawing.Point(4, 362)
            dataGridView.Location = location
            Me.dgw.MultiSelect = False
            Me.dgw.Name = "dgw"
            Me.dgw.[ReadOnly] = True
            Me.dgw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White
            dataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Moccasin
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgw.RowHeadersDefaultCellStyle = dataGridViewCellStyle4
            Me.dgw.RowHeadersWidth = 25
            Me.dgw.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White
            dataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Moccasin
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
            Me.dgw.RowsDefaultCellStyle = dataGridViewCellStyle5
            Me.dgw.RowTemplate.Height = 18
            Me.dgw.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgw.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Dim dataGridView2 As System.Windows.Forms.DataGridView = Me.dgw
            size = New System.Drawing.Size(997, 282)
            dataGridView2.Size = size
            Me.dgw.TabIndex = 1
            Me.Column1.HeaderText = "Item Name - EN"
            Me.Column1.Name = "Column1"
            Me.Column1.[ReadOnly] = True
            Me.Column10.HeaderText = "Item Name - Arabic"
            Me.Column10.Name = "Column10"
            Me.Column10.[ReadOnly] = True
            Me.Column2.HeaderText = "Category"
            Me.Column2.Name = "Column2"
            Me.Column2.[ReadOnly] = True
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.Column3.DefaultCellStyle = dataGridViewCellStyle6
            Me.Column3.HeaderText = "Dine In/Express Rate"
            Me.Column3.Name = "Column3"
            Me.Column3.[ReadOnly] = True
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.Column4.DefaultCellStyle = dataGridViewCellStyle7
            Me.Column4.HeaderText = "Take Away Rate"
            Me.Column4.Name = "Column4"
            Me.Column4.[ReadOnly] = True
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.Column9.DefaultCellStyle = dataGridViewCellStyle8
            Me.Column9.HeaderText = "Home Delivery Rate"
            Me.Column9.Name = "Column9"
            Me.Column9.[ReadOnly] = True
            Me.Column8.HeaderText = "Barcode"
            Me.Column8.Name = "Column8"
            Me.Column8.[ReadOnly] = True
            Me.Column5.HeaderText = "BackColor"
            Me.Column5.Name = "Column5"
            Me.Column5.[ReadOnly] = True
            Me.Column5.Visible = False
            Me.Column7.HeaderText = "Status"
            Me.Column7.Name = "Column7"
            Me.Column7.[ReadOnly] = True
            Me.Column6.HeaderText = "Image Path"
            Me.Column6.Name = "Column6"
            Me.Column6.[ReadOnly] = True
            Me.Column6.Visible = False
            Me.Column11.HeaderText = "Button ForeColor"
            Me.Column11.Name = "Column11"
            Me.Column11.[ReadOnly] = True
            Me.Column11.Visible = False
            Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.Panel2.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Panel2.Controls.Add(Me.txtDishID)
            Me.Panel2.Controls.Add(Me.Label1)
            Me.Panel2.Controls.Add(Me.txtBCode)
            Dim panel3 As System.Windows.Forms.Panel = Me.Panel2
            location = New System.Drawing.Point(4, 4)
            panel3.Location = location
            Me.Panel2.Name = "Panel2"
            Dim panel4 As System.Windows.Forms.Panel = Me.Panel2
            size = New System.Drawing.Size(908, 28)
            panel4.Size = size
            Me.Panel2.TabIndex = 0
            Dim textBox19 As System.Windows.Forms.TextBox = Me.txtDishID
            location = New System.Drawing.Point(479, 4)
            textBox19.Location = location
            Me.txtDishID.Name = "txtDishID"
            Dim textBox20 As System.Windows.Forms.TextBox = Me.txtDishID
            size = New System.Drawing.Size(59, 20)
            textBox20.Size = size
            Me.txtDishID.TabIndex = 9
            Me.txtDishID.Visible = False
            Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label1.ForeColor = System.Drawing.Color.White
            Dim label21 As System.Windows.Forms.Label = Me.Label1
            location = New System.Drawing.Point(0, 2)
            label21.Location = location
            Me.Label1.Name = "Label1"
            Dim label22 As System.Windows.Forms.Label = Me.Label1
            size = New System.Drawing.Size(905, 24)
            label22.Size = size
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Menu Items Entry"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Dim textBox21 As System.Windows.Forms.TextBox = Me.txtBCode
            location = New System.Drawing.Point(544, 6)
            textBox21.Location = location
            Me.txtBCode.Name = "txtBCode"
            Dim textBox22 As System.Windows.Forms.TextBox = Me.txtBCode
            size = New System.Drawing.Size(59, 20)
            textBox22.Size = size
            Me.txtBCode.TabIndex = 8
            Me.txtBCode.Visible = False
            Dim textBox23 As System.Windows.Forms.TextBox = Me.txtDish
            location = New System.Drawing.Point(567, 280)
            textBox23.Location = location
            Me.txtDish.Name = "txtDish"
            Dim textBox24 As System.Windows.Forms.TextBox = Me.txtDish
            size = New System.Drawing.Size(40, 20)
            textBox24.Size = size
            Me.txtDish.TabIndex = 4
            Me.txtDish.Visible = False
            Me.lblUser.AutoSize = True
            Dim label23 As System.Windows.Forms.Label = Me.lblUser
            location = New System.Drawing.Point(630, 313)
            label23.Location = location
            Me.lblUser.Name = "lblUser"
            Dim label24 As System.Windows.Forms.Label = Me.lblUser
            size = New System.Drawing.Size(39, 13)
            label24.Size = size
            Me.lblUser.TabIndex = 5
            Me.lblUser.Text = "Label8"
            Me.lblUser.Visible = False
            Me.OpenFileDialog1.FileName = "OpenFileDialog1"
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            size = New System.Drawing.Size(1016, 598)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.Panel1)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MaximizeBox = False
            MyBase.MinimizeBox = False
            MyBase.Name = "frmMenuItem"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            MyBase.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.GroupBox4.ResumeLayout(False)
            Me.GroupBox4.PerformLayout()
            CType(Me.Picture, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            MyBase.ResumeLayout(False)
        End Sub
    End Class
End Namespace
