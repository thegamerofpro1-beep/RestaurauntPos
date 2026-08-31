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
    Public Class frmProduct
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel1")>
        Private _Panel1 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel4")>
        Private _Panel4 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label3")>
        Private _Label3 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtProductCode")>
        Private _txtProductCode As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel2")>
        Private _Panel2 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label1")>
        Private _Label1 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label7")>
        Private _Label7 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label5")>
        Private _Label5 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtFeatures")>
        Private _txtFeatures As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label2")>
        Private _Label2 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblUser")>
        Private _lblUser As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtPrice")>
        Private _txtPrice As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label10")>
        Private _Label10 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("cmbCategory")>
        Private _cmbCategory As System.Windows.Forms.ComboBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtProductName")>
        Private _txtProductName As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblUserType")>
        Private _lblUserType As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtID")>
        Private _txtID As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label6")>
        Private _Label6 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("cmbUnit")>
        Private _cmbUnit As System.Windows.Forms.ComboBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnClose")>
        Private _btnClose As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox2")>
        Private _GroupBox2 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnGetData")>
        Private _btnGetData As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnNew")>
        Private _btnNew As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnUpdate")>
        Private _btnUpdate As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnSave")>
        Private _btnSave As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnDelete")>
        Private _btnDelete As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtReorderPoint")>
        Private _txtReorderPoint As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label4")>
        Private _Label4 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox1")>
        Private _GroupBox1 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox3")>
        Private _GroupBox3 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("dtpExpiryDate")>
        Private _dtpExpiryDate As System.Windows.Forms.DateTimePicker

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("chkHasExpiryDate")>
        Private _chkHasExpiryDate As System.Windows.Forms.CheckBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtQty")>
        Private _txtQty As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnRemoveFromGridOS")>
        Private _btnRemoveFromGridOS As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnAddOS")>
        Private _btnAddOS As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DataGridView1")>
        Private _DataGridView1 As System.Windows.Forms.DataGridView

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("cmbWareHouse")>
        Private _cmbWareHouse As System.Windows.Forms.ComboBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label21")>
        Private _Label21 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label22")>
        Private _Label22 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column2")>
        Private _Column2 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column7")>
        Private _Column7 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column4")>
        Private _Column4 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column5")>
        Private _Column5 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtPName")>
        Private _txtPName As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label9")>
        Private _Label9 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("cmbSupplier")>
        Private _cmbSupplier As System.Windows.Forms.ComboBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnExportExcel")>
        Private _btnExportExcel As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Button4")>
        Private _Button4 As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Button3")>
        Private _Button3 As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Button2")>
        Private _Button2 As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Button1")>
        Private _Button1 As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblSet")>
        Private _lblSet As System.Windows.Forms.Label

        Private st As String

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

        Friend Overridable Property txtProductCode As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtProductCode
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtProductCode = value
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

        Friend Overridable Property txtFeatures As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtFeatures
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtFeatures = value
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

        Friend Overridable Property txtPrice As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtPrice
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.Windows.Forms.KeyPressEventHandler = AddressOf Me.txtPrice_KeyPress
                If Me._txtPrice IsNot Nothing Then
                    RemoveHandler Me._txtPrice.KeyPress, value2
                End If

                Me._txtPrice = value
                If Me._txtPrice IsNot Nothing Then
                    AddHandler Me._txtPrice.KeyPress, value2
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

        Friend Overridable Property cmbCategory As System.Windows.Forms.ComboBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._cmbCategory
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ComboBox)
                Dim value2 As System.Windows.Forms.ListControlConvertEventHandler = AddressOf Me.cmbCategory_Format
                Dim value3 As System.Windows.Forms.KeyPressEventHandler = AddressOf Me.cmbCategory_KeyPress
                If Me._cmbCategory IsNot Nothing Then
                    RemoveHandler Me._cmbCategory.Format, value2
                    RemoveHandler Me._cmbCategory.KeyPress, value3
                End If

                Me._cmbCategory = value
                If Me._cmbCategory IsNot Nothing Then
                    AddHandler Me._cmbCategory.Format, value2
                    AddHandler Me._cmbCategory.KeyPress, value3
                End If
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

        Friend Overridable Property cmbUnit As System.Windows.Forms.ComboBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._cmbUnit
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ComboBox)
                Dim value2 As System.Windows.Forms.KeyPressEventHandler = AddressOf Me.cmbUnit_KeyPress
                Dim value3 As System.Windows.Forms.ListControlConvertEventHandler = AddressOf Me.cmbUnit_Format
                If Me._cmbUnit IsNot Nothing Then
                    RemoveHandler Me._cmbUnit.KeyPress, value2
                    RemoveHandler Me._cmbUnit.Format, value3
                End If

                Me._cmbUnit = value
                If Me._cmbUnit IsNot Nothing Then
                    AddHandler Me._cmbUnit.KeyPress, value2
                    AddHandler Me._cmbUnit.Format, value3
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

        Friend Overridable Property txtReorderPoint As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtReorderPoint
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.Windows.Forms.KeyPressEventHandler = AddressOf Me.txtReorderPoint_KeyPress
                If Me._txtReorderPoint IsNot Nothing Then
                    RemoveHandler Me._txtReorderPoint.KeyPress, value2
                End If

                Me._txtReorderPoint = value
                If Me._txtReorderPoint IsNot Nothing Then
                    AddHandler Me._txtReorderPoint.KeyPress, value2
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

        Friend Overridable Property txtQty As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtQty
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.Windows.Forms.KeyPressEventHandler = AddressOf Me.txtQty_KeyPress
                If Me._txtQty IsNot Nothing Then
                    RemoveHandler Me._txtQty.KeyPress, value2
                End If

                Me._txtQty = value
                If Me._txtQty IsNot Nothing Then
                    AddHandler Me._txtQty.KeyPress, value2
                End If
            End Set
        End Property

        Public Overridable Property btnRemoveFromGridOS As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnRemoveFromGridOS
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnRemoveFromGridOS_Click
                If Me._btnRemoveFromGridOS IsNot Nothing Then
                    RemoveHandler Me._btnRemoveFromGridOS.Click, value2
                End If

                Me._btnRemoveFromGridOS = value
                If Me._btnRemoveFromGridOS IsNot Nothing Then
                    AddHandler Me._btnRemoveFromGridOS.Click, value2
                End If
            End Set
        End Property

        Public Overridable Property btnAddOS As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnAddOS
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnAddOS_Click
                If Me._btnAddOS IsNot Nothing Then
                    RemoveHandler Me._btnAddOS.Click, value2
                End If

                Me._btnAddOS = value
                If Me._btnAddOS IsNot Nothing Then
                    AddHandler Me._btnAddOS.Click, value2
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
                If Me._DataGridView1 IsNot Nothing Then
                    RemoveHandler Me._DataGridView1.MouseClick, value2
                End If

                Me._DataGridView1 = value
                If Me._DataGridView1 IsNot Nothing Then
                    AddHandler Me._DataGridView1.MouseClick, value2
                End If
            End Set
        End Property

        Public Overridable Property cmbWareHouse As System.Windows.Forms.ComboBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._cmbWareHouse
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ComboBox)
                Me._cmbWareHouse = value
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

        Friend Overridable Property Label22 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label22
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label22 = value
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

        Friend Overridable Property txtPName As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtPName
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtPName = value
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

        Friend Overridable Property cmbSupplier As System.Windows.Forms.ComboBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._cmbSupplier
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ComboBox)
                Me._cmbSupplier = value
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

        Friend Overridable Property Button4 As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Button4
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.Button4_Click
                If Me._Button4 IsNot Nothing Then
                    RemoveHandler Me._Button4.Click, value2
                End If

                Me._Button4 = value
                If Me._Button4 IsNot Nothing Then
                    AddHandler Me._Button4.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property Button3 As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Button3
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.Button3_Click
                If Me._Button3 IsNot Nothing Then
                    RemoveHandler Me._Button3.Click, value2
                End If

                Me._Button3 = value
                If Me._Button3 IsNot Nothing Then
                    AddHandler Me._Button3.Click, value2
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
            AddHandler MyBase.Load, AddressOf Me.frmProduct_Load
            Call RestaurantPOS14.frmProduct.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmProduct.__ENCList
                If RestaurantPOS14.frmProduct.__ENCList.Count = RestaurantPOS14.frmProduct.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmProduct.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmProduct.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmProduct.__ENCList(num) = RestaurantPOS14.frmProduct.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmProduct.__ENCList.RemoveRange(num, RestaurantPOS14.frmProduct.__ENCList.Count - num)
                    RestaurantPOS14.frmProduct.__ENCList.Capacity = RestaurantPOS14.frmProduct.__ENCList.Count
                End If

                Call RestaurantPOS14.frmProduct.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
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
                Me.cmbWareHouse.Items.Clear()
                For Each dataRow As System.Data.DataRow In RestaurantPOS14.ModClasses.dtable.Rows
                    Me.cmbWareHouse.Items.Add(dataRow(CInt((0))).ToString())
                Next

                sqlConnection.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Function GenerateID() As String
            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
            Dim text As String = "0000"
            Try
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT TOP 1 PID FROM Product ORDER BY PID DESC", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                If RestaurantPOS14.ModClasses.rdr.HasRows Then
                    RestaurantPOS14.ModClasses.rdr.Read()
                    text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr("PID"))
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
                Me.txtProductCode.Text = "P-" & Me.GenerateID()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub Reset()
            Me.txtProductCode.Text = ""
            Me.cmbUnit.SelectedIndex = -1
            Me.txtPrice.Text = "0.00"
            Me.txtFeatures.Text = ""
            Me.txtProductName.Text = ""
            Me.cmbCategory.SelectedIndex = -1
            Me.txtProductName.Focus()
            If RestaurantPOS14.ModFunc.IsViewAllowed(Me.lblUser.Text, "Raw Materials") Then
                Me.btnGetData.Enabled = True
            Else
                Me.btnGetData.Enabled = False
            End If

            If RestaurantPOS14.ModFunc.IsSaveAllowed(Me.lblUser.Text, "Raw Materials") Then
                Me.btnSave.Enabled = True
                Me.btnExportExcel.Enabled = True
            Else
                Me.btnSave.Enabled = False
                Me.btnExportExcel.Enabled = False
            End If

            Me.btnUpdate.Enabled = False
            Me.btnDelete.Enabled = False
            Me.DataGridView1.Enabled = True
            Me.btnAddOS.Enabled = True
            Me.auto()
            Me.txtReorderPoint.Text = ""
            Me.txtPName.Text = ""
            Me.cmbSupplier.SelectedIndex = -1
            Me.DataGridView1.Rows.Clear()
            Me.Clear()
        End Sub

        Public Sub fillUnit()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.adp = New System.Data.SqlClient.SqlDataAdapter()
                RestaurantPOS14.ModClasses.adp.SelectCommand = New System.Data.SqlClient.SqlCommand("SELECT distinct RTRIM(Unit) FROM UnitMaster order by 1", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.ds = New System.Data.DataSet("ds")
                RestaurantPOS14.ModClasses.adp.Fill(RestaurantPOS14.ModClasses.ds)
                RestaurantPOS14.ModClasses.dtable = RestaurantPOS14.ModClasses.ds.Tables(0)
                Me.cmbUnit.Items.Clear()
                For Each dataRow As System.Data.DataRow In RestaurantPOS14.ModClasses.dtable.Rows
                    Me.cmbUnit.Items.Add(dataRow(CInt((0))).ToString())
                Next

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub fillSupplier()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.adp = New System.Data.SqlClient.SqlDataAdapter()
                RestaurantPOS14.ModClasses.adp.SelectCommand = New System.Data.SqlClient.SqlCommand("SELECT distinct RTRIM(Name) FROM Supplier order by 1", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.ds = New System.Data.DataSet("ds")
                RestaurantPOS14.ModClasses.adp.Fill(RestaurantPOS14.ModClasses.ds)
                RestaurantPOS14.ModClasses.dtable = RestaurantPOS14.ModClasses.ds.Tables(0)
                Me.cmbSupplier.Items.Clear()
                For Each dataRow As System.Data.DataRow In RestaurantPOS14.ModClasses.dtable.Rows
                    Me.cmbSupplier.Items.Add(dataRow(CInt((0))).ToString())
                Next

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub fillCategory()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.adp = New System.Data.SqlClient.SqlDataAdapter()
                RestaurantPOS14.ModClasses.adp.SelectCommand = New System.Data.SqlClient.SqlCommand("SELECT distinct RTRIM(CategoryName) FROM RMCategory order by 1", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.ds = New System.Data.DataSet("ds")
                RestaurantPOS14.ModClasses.adp.Fill(RestaurantPOS14.ModClasses.ds)
                RestaurantPOS14.ModClasses.dtable = RestaurantPOS14.ModClasses.ds.Tables(0)
                Me.cmbCategory.Items.Clear()
                For Each dataRow As System.Data.DataRow In RestaurantPOS14.ModClasses.dtable.Rows
                    Me.cmbCategory.Items.Add(dataRow(CInt((0))).ToString())
                Next

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub DeleteRecord()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT PID FROM Product INNER JOIN StockAdjustment_Store ON Product.PID = StockAdjustment_Store.ProductID where PID=@d1")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.Conversion.Val(Me.txtID.Text))
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Unable to delete..Already in use in Stock Adjustment(S)", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT PID FROM Product INNER JOIN StockAdjustment_Warehouse ON Product.PID = StockAdjustment_Warehouse.ProductID where PID=@d1")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.Conversion.Val(Me.txtID.Text))
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Unable to delete..Already in use in Stock Adjustment(W)", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select PID from PurchaseOrder_Join,Product where Product.PID=PurchaseOrder_Join.ProductID and PID=@d1")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.Conversion.Val(Me.txtID.Text))
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Unable to delete..Already in use in Purchase order Entry", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT PID FROM Product INNER JOIN Recipe_Join ON Product.PID = Recipe_Join.ProductID where PID=@d1")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.Conversion.Val(Me.txtID.Text))
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Unable to delete..Already in use in Recipe", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT PID FROM Product INNER JOIN StockTransfer_Join ON Product.PID = StockTransfer_Join.ProductID where PID=@d1")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.Conversion.Val(Me.txtID.Text))
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Unable to delete..Already in use in Stock Transfer/Issue Entry", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT PID FROM Product INNER JOIN Purchase_Join ON Product.PID = Purchase_Join.ProductID where PID=@d1")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.Conversion.Val(Me.txtID.Text))
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Unable to delete..Already in use in Purchase Entry", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("delete from Product where PID=@d1")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.Conversion.Val(Me.txtID.Text))
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                If RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery() > 0 Then
                    RestaurantPOS14.ModFunc.LogFunc(Me.lblUser.Text, "deleted the Product '" & Me.txtProductName.Text & "' having Product code '" & Me.txtProductCode.Text & "'")
                    Call System.Windows.Forms.MessageBox.Show("Successfully deleted", "Record", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    Me.Reset()
                Else
                    Call System.Windows.Forms.MessageBox.Show("No record found", "Sorry", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    Me.Reset()
                    If RestaurantPOS14.ModClasses.con.State = System.Data.ConnectionState.Open Then
                        RestaurantPOS14.ModClasses.con.Close()
                    End If

                    RestaurantPOS14.ModClasses.con.Close()
                End If
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub frmProduct_Load(sender As Object, e As System.EventArgs)
            Me.fillCategory()
            Me.fillUnit()
            Me.FillWarehouse()
            Me.fillSupplier()
        End Sub

        Private Sub cmbUnit_Format(sender As Object, e As System.Windows.Forms.ListControlConvertEventArgs)
            If e.DesiredType Is GetType(String) Then
                e.Value = e.Value.ToString().Trim()
            End If
        End Sub

        Private Sub btnNew_Click(sender As Object, e As System.EventArgs)
            Me.Reset()
        End Sub

        Private Sub btnSave_Click(sender As Object, e As System.EventArgs)
            If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.txtProductName.Text)) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please enter product name", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtProductName.Focus()
                Return
            End If

            If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.cmbCategory.Text)) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please enter/select category", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.cmbCategory.Focus()
                Return
            End If

            If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.cmbSupplier.Text)) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please select supplier", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.cmbSupplier.Focus()
                Return
            End If

            If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.cmbUnit.Text)) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please enter/select unit", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.cmbUnit.Focus()
                Return
            End If

            If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.txtPrice.Text)) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please enter price", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtPrice.Focus()
                Return
            End If

            If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.txtReorderPoint.Text)) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please enter reorder point", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtReorderPoint.Focus()
                Return
            End If

            If Me.DataGridView1.Rows.Count = 0 Then
                Call System.Windows.Forms.MessageBox.Show("sorry no opening stock info added to grid", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Return
            End If

            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select ProductName from Product where ProductName=@d1")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtProductName.Text)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Product Name Already Exists", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                    Me.txtProductName.Text = ""
                    Me.txtProductName.Focus()
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("insert into Product(PID,ProductCode, Productname,Category, Description,Unit,Price,ReorderPoint,P_Supplier) VALUES (" & Me.txtID.Text & ",@d1,@d2,@d3,@d4,@d5,@d6," & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.txtReorderPoint.Text)) & ",@d7)")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtProductCode.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Me.txtProductName.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Me.cmbCategory.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", Me.txtFeatures.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d5", Me.cmbUnit.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d6", Microsoft.VisualBasic.Conversion.Val(Me.txtPrice.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d7", Me.cmbSupplier.Text)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("insert into Product_OpeningStock(ProductID,Warehouse,Qty,HasExpiryDate,ExpiryDate) VALUES (" & Me.txtID.Text & " ,@d1,@d2,@d3,@d4)")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Prepare()
                For Each dataGridViewRow As System.Windows.Forms.DataGridViewRow In CType(Me.DataGridView1.Rows, System.Collections.IEnumerable)
                    If Not dataGridViewRow.IsNewRow Then
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((0))).Value))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((1))).Value)))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((2))).Value))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((3))).Value))
                        RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                        RestaurantPOS14.ModClasses.cmd.Parameters.Clear()
                    End If
                Next

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("insert into Temp_Stock(ProductID,Warehouse,Qty,HasExpiryDate,ExpiryDate) VALUES (" & Me.txtID.Text & " ,@d1,@d2,@d3,@d4)")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Prepare()
                For Each dataGridViewRow2 As System.Windows.Forms.DataGridViewRow In CType(Me.DataGridView1.Rows, System.Collections.IEnumerable)
                    If Not dataGridViewRow2.IsNewRow Then
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(CInt((0))).Value))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(CInt((1))).Value)))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(CInt((2))).Value))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(CInt((3))).Value))
                        RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                        RestaurantPOS14.ModClasses.cmd.Parameters.Clear()
                    End If
                Next

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModFunc.LogFunc(Me.lblUser.Text, "added the new Product '" & Me.txtProductName.Text & "' having Product code '" & Me.txtProductCode.Text & "'")
                Call System.Windows.Forms.MessageBox.Show("Successfully saved", "Product Record", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                Me.auto()
                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnUpdate_Click(sender As Object, e As System.EventArgs)
            If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.txtProductName.Text)) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please enter product name", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtProductName.Focus()
                Return
            End If

            If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.cmbCategory.Text)) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please enter/select category", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.cmbCategory.Focus()
                Return
            End If

            If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.cmbSupplier.Text)) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please select supplier", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.cmbSupplier.Focus()
                Return
            End If

            If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.cmbUnit.Text)) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please enter/select unit", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.cmbUnit.Focus()
                Return
            End If

            If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.txtPrice.Text)) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please enter price", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtPrice.Focus()
                Return
            End If

            If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.txtReorderPoint.Text)) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please enter reorder point", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtReorderPoint.Focus()
                Return
            End If

            If Me.DataGridView1.Rows.Count = 0 Then
                Call System.Windows.Forms.MessageBox.Show("sorry no opening stock info added to grid", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Return
            End If

            Try
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtProductName.Text, Me.txtPName.Text, TextCompare:=False) <> 0 Then
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select ProductName from Product where ProductName=@d1")
                    RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtProductName.Text)
                    RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                    If RestaurantPOS14.ModClasses.rdr.Read() Then
                        Call System.Windows.Forms.MessageBox.Show("Product Name Already Exists", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                        Me.txtProductName.Text = ""
                        Me.txtProductName.Focus()
                        If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                            RestaurantPOS14.ModClasses.rdr.Close()
                        End If

                        Return
                    End If
                End If

                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Update Product set Productname=@d2, Category=@d3, Description=@d4,Unit=@d5,Price=@d6,ReorderPoint=" & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.txtReorderPoint.Text)) & ",ProductCode=@d1,P_Supplier=@d7 where PID=" & Me.txtID.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Me.txtProductName.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Me.cmbCategory.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", Me.txtFeatures.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d5", Me.cmbUnit.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d6", Microsoft.VisualBasic.Conversion.Val(Me.txtPrice.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d7", Me.cmbSupplier.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtProductCode.Text)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModFunc.LogFunc(Me.lblUser.Text, "updated the Product '" & Me.txtProductName.Text & "' having Product code '" & Me.txtProductCode.Text & "'")
                Call System.Windows.Forms.MessageBox.Show("Successfully updated", "Product Record", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                Me.btnUpdate.Enabled = False
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
            RestaurantPOS14.My.MyProject.Forms.frmProductRecord.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmProductRecord.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmProductRecord.ShowDialog()
        End Sub

        Private Sub cmbCategory_Format(sender As Object, e As System.Windows.Forms.ListControlConvertEventArgs)
            If e.DesiredType Is GetType(String) Then
                e.Value = e.Value.ToString().Trim()
            End If
        End Sub

        Private Sub txtPrice_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
            Dim keyChar As Char = e.KeyChar
            If Char.IsControl(keyChar) Then
                Return
            End If

            If Char.IsDigit(keyChar) OrElse keyChar = "."c Then
                Dim text As String = Me.txtPrice.Text
                Dim selectionStart As Integer = Me.txtPrice.SelectionStart
                Dim selectionLength As Integer = Me.txtPrice.SelectionLength
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

        Private Sub btnClose_Click(sender As Object, e As System.EventArgs)
            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "Purchase Order", TextCompare:=False) = 0 Then
                Call RestaurantPOS14.My.MyProject.Forms.frmPurchaseOrder.fillCombo()
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "Purchase Entry", TextCompare:=False) = 0 Then
                Call RestaurantPOS14.My.MyProject.Forms.frmPurchaseEntry.fillCombo()
            End If

            MyBase.Close()
        End Sub

        Private Sub cmbUnit_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
            If Char.IsLetter(e.KeyChar) Then
                e.KeyChar = Char.ToUpper(e.KeyChar)
            End If
        End Sub

        Private Sub cmbCategory_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
            If Char.IsLetter(e.KeyChar) Then
                e.KeyChar = Char.ToUpper(e.KeyChar)
            End If
        End Sub

        Private Sub btnAddOS_Click(sender As Object, e As System.EventArgs)
            Try
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.cmbWareHouse.Text, "", TextCompare:=False) = 0 Then
                    Call System.Windows.Forms.MessageBox.Show("Please select warehouse", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Me.cmbWareHouse.Focus()
                    Return
                End If

                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtQty.Text, "", TextCompare:=False) = 0 Then
                    Call System.Windows.Forms.MessageBox.Show("Please enter qty", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Me.txtQty.Focus()
                    Return
                End If

                If Me.chkHasExpiryDate.Checked Then
                    Me.st = "Yes"
                Else
                    Me.st = "No"
                End If

                For Each dataGridViewRow As System.Windows.Forms.DataGridViewRow In Me.DataGridView1.SelectedRows
                    If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.st, "Yes", TextCompare:=False) = 0 AndAlso Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(Me.cmbWareHouse.Text, dataGridViewRow.Cells(CInt((0))).Value, TextCompare:=False), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(Me.dtpExpiryDate.Text, dataGridViewRow.Cells(CInt((3))).Value, TextCompare:=False))) Then
                        Call System.Windows.Forms.MessageBox.Show("Record already added", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                        Return
                    End If

                    If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.st, "No", TextCompare:=False) = 0 AndAlso Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Me.cmbWareHouse.Text, dataGridViewRow.Cells(CInt((0))).Value, TextCompare:=False) Then
                        Call System.Windows.Forms.MessageBox.Show("Record already added", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                        Return
                    End If
                Next

                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.st, "Yes", TextCompare:=False) = 0 Then
                    Me.DataGridView1.Rows.Add(Me.cmbWareHouse.Text, Microsoft.VisualBasic.Conversion.Val(Me.txtQty.Text), Me.st, Me.dtpExpiryDate.Text)
                Else
                    Me.DataGridView1.Rows.Add(Me.cmbWareHouse.Text, Microsoft.VisualBasic.Conversion.Val(Me.txtQty.Text), Me.st, "")
                End If

                Me.Clear()
            Catch ex As System.Exception
                Call Microsoft.VisualBasic.Interaction.MsgBox(ex.Message)
            End Try
        End Sub

        Private Sub btnRemoveFromGridOS_Click(sender As Object, e As System.EventArgs)
            Try
                If Me.DataGridView1.Rows.Count <= 0 Then
                    Return
                End If

                For Each dataGridViewRow As System.Windows.Forms.DataGridViewRow In Me.DataGridView1.SelectedRows
                    Me.DataGridView1.Rows.Remove(dataGridViewRow)
                Next

                Me.btnRemoveFromGridOS.Enabled = False
                Me.Clear()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub Clear()
            Me.cmbWareHouse.SelectedIndex = -1
            Me.txtQty.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(0)
            Me.chkHasExpiryDate.Checked = False
            Me.dtpExpiryDate.Enabled = False
            Me.btnRemoveFromGridOS.Enabled = False
            Me.dtpExpiryDate.Value = Microsoft.VisualBasic.DateAndTime.Today
        End Sub

        Private Sub DataGridView1_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs)
            Me.btnRemoveFromGridOS.Enabled = True
        End Sub

        Private Sub txtReorderPoint_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
            If((e.KeyChar < "0"c) Or (e.KeyChar > "9"c)) And (e.KeyChar <> Global.Microsoft.VisualBasic.Strings.ChrW(8)) Then
                e.Handled = True
            End If
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

        Private Sub chkHasExpiryDate_CheckedChanged(sender As Object, e As System.EventArgs)
            If Me.chkHasExpiryDate.Checked Then
                Me.dtpExpiryDate.Enabled = True
            Else
                Me.dtpExpiryDate.Enabled = False
            End If
        End Sub

        Private Sub btnExportExcel_Click(sender As Object, e As System.EventArgs)
            Call RestaurantPOS14.My.MyProject.Forms.frmImportExportExcel_Products.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmImportExportExcel_Products.ShowDialog()
        End Sub

        Private Sub Button1_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmRawMaterialsCategory.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmRawMaterialsCategory.Reset()
            RestaurantPOS14.My.MyProject.Forms.frmRawMaterialsCategory.lblSet.Text = "Category"
            Call RestaurantPOS14.My.MyProject.Forms.frmRawMaterialsCategory.ShowDialog()
        End Sub

        Private Sub Button2_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmSupplier.lblUser.Text = Me.lblUser.Text
            RestaurantPOS14.My.MyProject.Forms.frmSupplier.lblSet.Text = "Product"
            Call RestaurantPOS14.My.MyProject.Forms.frmSupplier.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmSupplier.ShowDialog()
        End Sub

        Private Sub Button3_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmUnit.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmUnit.Reset()
            RestaurantPOS14.My.MyProject.Forms.frmUnit.lblSet.Text = "Unit"
            Call RestaurantPOS14.My.MyProject.Forms.frmUnit.ShowDialog()
        End Sub

        Private Sub Button4_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmWarehouse.lblUser.Text = Me.lblUser.Text
            RestaurantPOS14.My.MyProject.Forms.frmWarehouse.lblSet.Text = "Product"
            Call RestaurantPOS14.My.MyProject.Forms.frmWarehouse.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmWarehouse.ShowDialog()
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmProduct))
            Dim dataGridViewCellStyle As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.btnExportExcel = New System.Windows.Forms.Button()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.dtpExpiryDate = New System.Windows.Forms.DateTimePicker()
            Me.chkHasExpiryDate = New System.Windows.Forms.CheckBox()
            Me.txtQty = New System.Windows.Forms.TextBox()
            Me.btnRemoveFromGridOS = New System.Windows.Forms.Button()
            Me.btnAddOS = New System.Windows.Forms.Button()
            Me.DataGridView1 = New System.Windows.Forms.DataGridView()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.cmbWareHouse = New System.Windows.Forms.ComboBox()
            Me.Label21 = New System.Windows.Forms.Label()
            Me.Label22 = New System.Windows.Forms.Label()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.btnGetData = New System.Windows.Forms.Button()
            Me.btnNew = New System.Windows.Forms.Button()
            Me.btnUpdate = New System.Windows.Forms.Button()
            Me.btnSave = New System.Windows.Forms.Button()
            Me.btnDelete = New System.Windows.Forms.Button()
            Me.btnClose = New System.Windows.Forms.Button()
            Me.Panel4 = New System.Windows.Forms.Panel()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.cmbSupplier = New System.Windows.Forms.ComboBox()
            Me.txtReorderPoint = New System.Windows.Forms.TextBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.cmbUnit = New System.Windows.Forms.ComboBox()
            Me.txtID = New System.Windows.Forms.TextBox()
            Me.lblUserType = New System.Windows.Forms.Label()
            Me.txtProductName = New System.Windows.Forms.TextBox()
            Me.cmbCategory = New System.Windows.Forms.ComboBox()
            Me.lblUser = New System.Windows.Forms.Label()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtProductCode = New System.Windows.Forms.TextBox()
            Me.txtFeatures = New System.Windows.Forms.TextBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.txtPrice = New System.Windows.Forms.TextBox()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.txtPName = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.Button2 = New System.Windows.Forms.Button()
            Me.Button3 = New System.Windows.Forms.Button()
            Me.Button4 = New System.Windows.Forms.Button()
            Me.lblSet = New System.Windows.Forms.Label()
            Dim label As System.Windows.Forms.Label = New System.Windows.Forms.Label()
            Dim label2 As System.Windows.Forms.Label = New System.Windows.Forms.Label()
            Dim label3 As System.Windows.Forms.Label = New System.Windows.Forms.Label()
            Me.Panel1.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox2.SuspendLayout()
            Me.Panel4.SuspendLayout()
            Me.Panel2.SuspendLayout()
            MyBase.SuspendLayout()
            label.AutoSize = True
            label.ForeColor = System.Drawing.Color.Black
            Dim location As System.Drawing.Point = New System.Drawing.Point(21, 29)
            label.Location = location
            Dim padding As System.Windows.Forms.Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
            label.Margin = padding
            label.Name = "Label11"
            Dim size As System.Drawing.Size = New System.Drawing.Size(32, 13)
            label.Size = size
            label.TabIndex = 305
            label.Text = "Qty. :"
            label2.AutoSize = True
            label2.ForeColor = System.Drawing.Color.Black
            location = New System.Drawing.Point(21, 22)
            label2.Location = location
            padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
            label2.Margin = padding
            label2.Name = "Label24"
            size = New System.Drawing.Size(68, 13)
            label2.Size = size
            label2.TabIndex = 278
            label2.Text = "Warehouse :"
            label3.AutoSize = True
            label3.ForeColor = System.Drawing.Color.Black
            location = New System.Drawing.Point(21, 87)
            label3.Location = location
            padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
            label3.Margin = padding
            label3.Name = "Label8"
            size = New System.Drawing.Size(67, 13)
            label3.Size = size
            label3.TabIndex = 307
            label3.Text = "Expiry Date :"
            Me.Panel1.BackColor = System.Drawing.Color.White
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.btnExportExcel)
            Me.Panel1.Controls.Add(Me.GroupBox1)
            Me.Panel1.Controls.Add(Me.GroupBox2)
            Me.Panel1.Controls.Add(Me.btnClose)
            Me.Panel1.Controls.Add(Me.Panel4)
            Me.Panel1.Controls.Add(Me.Panel2)
            Dim panel As System.Windows.Forms.Panel = Me.Panel1
            location = New System.Drawing.Point(7, 6)
            panel.Location = location
            Me.Panel1.Name = "Panel1"
            Dim panel2 As System.Windows.Forms.Panel = Me.Panel1
            size = New System.Drawing.Size(995, 395)
            panel2.Size = size
            Me.Panel1.TabIndex = 2
            Me.btnExportExcel.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnExportExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnExportExcel.Image = CType(componentResourceManager.GetObject("btnExportExcel.Image"), System.Drawing.Image)
            Me.btnExportExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button As System.Windows.Forms.Button = Me.btnExportExcel
            location = New System.Drawing.Point(873, 283)
            button.Location = location
            Me.btnExportExcel.Name = "btnExportExcel"
            Dim button2 As System.Windows.Forms.Button = Me.btnExportExcel
            size = New System.Drawing.Size(117, 61)
            button2.Size = size
            Me.btnExportExcel.TabIndex = 10
            Me.btnExportExcel.Text = "Import/" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Export Excel"
            Me.btnExportExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnExportExcel.UseVisualStyleBackColor = True
            Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox1.Controls.Add(Me.lblSet)
            Me.GroupBox1.Controls.Add(Me.Button4)
            Me.GroupBox1.Controls.Add(Me.GroupBox3)
            Me.GroupBox1.Controls.Add(Me.btnRemoveFromGridOS)
            Me.GroupBox1.Controls.Add(Me.btnAddOS)
            Me.GroupBox1.Controls.Add(Me.DataGridView1)
            Me.GroupBox1.Controls.Add(Me.cmbWareHouse)
            Me.GroupBox1.Controls.Add(Me.Label21)
            Me.GroupBox1.Controls.Add(Me.Label22)
            Me.GroupBox1.Controls.Add(label2)
            Dim groupBox As System.Windows.Forms.GroupBox = Me.GroupBox1
            location = New System.Drawing.Point(442, 48)
            groupBox.Location = location
            Dim groupBox2 As System.Windows.Forms.GroupBox = Me.GroupBox1
            padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
            groupBox2.Margin = padding
            Me.GroupBox1.Name = "GroupBox1"
            Dim groupBox3 As System.Windows.Forms.GroupBox = Me.GroupBox1
            padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
            groupBox3.Padding = padding
            Dim groupBox4 As System.Windows.Forms.GroupBox = Me.GroupBox1
            size = New System.Drawing.Size(425, 340)
            groupBox4.Size = size
            Me.GroupBox1.TabIndex = 0
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Product Opening Stock Info"
            Me.GroupBox3.Controls.Add(Me.dtpExpiryDate)
            Me.GroupBox3.Controls.Add(label3)
            Me.GroupBox3.Controls.Add(Me.chkHasExpiryDate)
            Me.GroupBox3.Controls.Add(Me.txtQty)
            Me.GroupBox3.Controls.Add(label)
            Dim groupBox5 As System.Windows.Forms.GroupBox = Me.GroupBox3
            location = New System.Drawing.Point(24, 56)
            groupBox5.Location = location
            Me.GroupBox3.Name = "GroupBox3"
            Dim groupBox6 As System.Windows.Forms.GroupBox = Me.GroupBox3
            size = New System.Drawing.Size(281, 123)
            groupBox6.Size = size
            Me.GroupBox3.TabIndex = 2
            Me.GroupBox3.TabStop = False
            Me.GroupBox3.Text = "Opening Stock"
            Me.dtpExpiryDate.CustomFormat = "dd/MM/yyyy"
            Me.dtpExpiryDate.Enabled = False
            Me.dtpExpiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Dim dateTimePicker As System.Windows.Forms.DateTimePicker = Me.dtpExpiryDate
            location = New System.Drawing.Point(118, 87)
            dateTimePicker.Location = location
            Me.dtpExpiryDate.Name = "dtpExpiryDate"
            Dim dateTimePicker2 As System.Windows.Forms.DateTimePicker = Me.dtpExpiryDate
            size = New System.Drawing.Size(117, 20)
            dateTimePicker2.Size = size
            Me.dtpExpiryDate.TabIndex = 2
            Me.chkHasExpiryDate.AutoSize = True
            Dim checkBox As System.Windows.Forms.CheckBox = Me.chkHasExpiryDate
            location = New System.Drawing.Point(118, 58)
            checkBox.Location = location
            Me.chkHasExpiryDate.Name = "chkHasExpiryDate"
            Dim checkBox2 As System.Windows.Forms.CheckBox = Me.chkHasExpiryDate
            size = New System.Drawing.Size(111, 17)
            checkBox2.Size = size
            Me.chkHasExpiryDate.TabIndex = 1
            Me.chkHasExpiryDate.Text = "Has Expiry Date ?"
            Me.chkHasExpiryDate.UseVisualStyleBackColor = True
            Dim textBox As System.Windows.Forms.TextBox = Me.txtQty
            location = New System.Drawing.Point(118, 26)
            textBox.Location = location
            Me.txtQty.Name = "txtQty"
            Dim textBox2 As System.Windows.Forms.TextBox = Me.txtQty
            size = New System.Drawing.Size(105, 20)
            textBox2.Size = size
            Me.txtQty.TabIndex = 0
            Me.txtQty.Text = "0"
            Me.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.btnRemoveFromGridOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnRemoveFromGridOS.Image = CType(componentResourceManager.GetObject("btnRemoveFromGridOS.Image"), System.Drawing.Image)
            Me.btnRemoveFromGridOS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button3 As System.Windows.Forms.Button = Me.btnRemoveFromGridOS
            location = New System.Drawing.Point(326, 60)
            button3.Location = location
            Me.btnRemoveFromGridOS.Name = "btnRemoveFromGridOS"
            Dim button4 As System.Windows.Forms.Button = Me.btnRemoveFromGridOS
            size = New System.Drawing.Size(90, 34)
            button4.Size = size
            Me.btnRemoveFromGridOS.TabIndex = 5
            Me.btnRemoveFromGridOS.Text = "&Remove"
            Me.btnRemoveFromGridOS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnRemoveFromGridOS.UseVisualStyleBackColor = True
            Me.btnAddOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnAddOS.Image = CType(componentResourceManager.GetObject("btnAddOS.Image"), System.Drawing.Image)
            Me.btnAddOS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button5 As System.Windows.Forms.Button = Me.btnAddOS
            location = New System.Drawing.Point(326, 19)
            button5.Location = location
            Me.btnAddOS.Name = "btnAddOS"
            Dim button6 As System.Windows.Forms.Button = Me.btnAddOS
            size = New System.Drawing.Size(67, 34)
            button6.Size = size
            Me.btnAddOS.TabIndex = 4
            Me.btnAddOS.Text = "&Add"
            Me.btnAddOS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnAddOS.UseVisualStyleBackColor = True
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
            Me.DataGridView1.ColumnHeadersHeight = 33
            Me.DataGridView1.Columns.AddRange(Me.Column2, Me.Column7, Me.Column4, Me.Column5)
            Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.DataGridView1.EnableHeadersVisualStyles = False
            Me.DataGridView1.GridColor = System.Drawing.Color.White
            Dim dataGridView As System.Windows.Forms.DataGridView = Me.DataGridView1
            location = New System.Drawing.Point(24, 185)
            dataGridView.Location = location
            Me.DataGridView1.MultiSelect = False
            Me.DataGridView1.Name = "DataGridView1"
            Me.DataGridView1.[ReadOnly] = True
            Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White
            dataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Moccasin
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3
            Me.DataGridView1.RowHeadersVisible = False
            Me.DataGridView1.RowHeadersWidth = 25
            Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White
            dataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Moccasin
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
            Me.DataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4
            Me.DataGridView1.RowTemplate.Height = 18
            Me.DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Dim dataGridView2 As System.Windows.Forms.DataGridView = Me.DataGridView1
            size = New System.Drawing.Size(383, 146)
            dataGridView2.Size = size
            Me.DataGridView1.TabIndex = 3
            Me.Column2.HeaderText = "Warehouse"
            Me.Column2.Name = "Column2"
            Me.Column2.[ReadOnly] = True
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.Column7.DefaultCellStyle = dataGridViewCellStyle5
            Me.Column7.HeaderText = "Qty."
            Me.Column7.Name = "Column7"
            Me.Column7.[ReadOnly] = True
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.Column4.DefaultCellStyle = dataGridViewCellStyle6
            Me.Column4.HeaderText = "Has Expiry Date ?"
            Me.Column4.Name = "Column4"
            Me.Column4.[ReadOnly] = True
            Me.Column4.Width = 80
            Me.Column5.HeaderText = "Expiry Date"
            Me.Column5.Name = "Column5"
            Me.Column5.[ReadOnly] = True
            Me.cmbWareHouse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
            Me.cmbWareHouse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
            Me.cmbWareHouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbWareHouse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.cmbWareHouse.FormattingEnabled = True
            Me.cmbWareHouse.Items.AddRange(New Object(24) {"Hinduism", "Christianity", "Islam", "Buddhism", "Sikhism", "Jainism", "Taoism", "Shinto", "Judaism", "Korean shamanism", "Confucianism", "Caodaism", "Bahá'í Faith", "Cheondoism", "Secular/Nonreligious/Agnostic/Atheist", "African Traditional & Diasporic", "Spiritism", "Zoroastrianism", "Tenrikyo", "Neo-Paganism", "Rastafarianism", "Hoahaoism", "Chinese folk religion", "Tenriism", "Any Other"})
            Dim comboBox As System.Windows.Forms.ComboBox = Me.cmbWareHouse
            location = New System.Drawing.Point(112, 22)
            comboBox.Location = location
            Me.cmbWareHouse.Name = "cmbWareHouse"
            Dim comboBox2 As System.Windows.Forms.ComboBox = Me.cmbWareHouse
            size = New System.Drawing.Size(168, 23)
            comboBox2.Size = size
            Me.cmbWareHouse.TabIndex = 1
            Me.Label21.Font = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label4 As System.Windows.Forms.Label = Me.Label21
            location = New System.Drawing.Point(589, 266)
            label4.Location = location
            Me.Label21.Name = "Label21"
            Dim label5 As System.Windows.Forms.Label = Me.Label21
            size = New System.Drawing.Size(164, 15)
            label5.Size = size
            Me.Label21.TabIndex = 287
            Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Dim label6 As System.Windows.Forms.Label = Me.Label22
            location = New System.Drawing.Point(0, 0)
            label6.Location = location
            Me.Label22.Name = "Label22"
            Dim label7 As System.Windows.Forms.Label = Me.Label22
            size = New System.Drawing.Size(100, 23)
            label7.Size = size
            Me.Label22.TabIndex = 1
            Me.GroupBox2.Controls.Add(Me.btnGetData)
            Me.GroupBox2.Controls.Add(Me.btnNew)
            Me.GroupBox2.Controls.Add(Me.btnUpdate)
            Me.GroupBox2.Controls.Add(Me.btnSave)
            Me.GroupBox2.Controls.Add(Me.btnDelete)
            Dim groupBox7 As System.Windows.Forms.GroupBox = Me.GroupBox2
            location = New System.Drawing.Point(873, 48)
            groupBox7.Location = location
            Me.GroupBox2.Name = "GroupBox2"
            Dim groupBox8 As System.Windows.Forms.GroupBox = Me.GroupBox2
            size = New System.Drawing.Size(115, 229)
            groupBox8.Size = size
            Me.GroupBox2.TabIndex = 6
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Action Button"
            Me.btnGetData.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnGetData.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnGetData.Image = CType(componentResourceManager.GetObject("btnGetData.Image"), System.Drawing.Image)
            Me.btnGetData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button7 As System.Windows.Forms.Button = Me.btnGetData
            location = New System.Drawing.Point(11, 183)
            button7.Location = location
            Me.btnGetData.Name = "btnGetData"
            Dim button8 As System.Windows.Forms.Button = Me.btnGetData
            size = New System.Drawing.Size(92, 37)
            button8.Size = size
            Me.btnGetData.TabIndex = 7
            Me.btnGetData.Text = "Get Data"
            Me.btnGetData.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnGetData.UseVisualStyleBackColor = True
            Me.btnNew.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnNew.Image = CType(componentResourceManager.GetObject("btnNew.Image"), System.Drawing.Image)
            Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button9 As System.Windows.Forms.Button = Me.btnNew
            location = New System.Drawing.Point(11, 18)
            button9.Location = location
            Me.btnNew.Name = "btnNew"
            Dim button10 As System.Windows.Forms.Button = Me.btnNew
            size = New System.Drawing.Size(92, 37)
            button10.Size = size
            Me.btnNew.TabIndex = 0
            Me.btnNew.Text = "New"
            Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnNew.UseVisualStyleBackColor = True
            Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnUpdate.Image = CType(componentResourceManager.GetObject("btnUpdate.Image"), System.Drawing.Image)
            Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button11 As System.Windows.Forms.Button = Me.btnUpdate
            location = New System.Drawing.Point(11, 99)
            button11.Location = location
            Me.btnUpdate.Name = "btnUpdate"
            Dim button12 As System.Windows.Forms.Button = Me.btnUpdate
            size = New System.Drawing.Size(92, 37)
            button12.Size = size
            Me.btnUpdate.TabIndex = 2
            Me.btnUpdate.Text = "Update"
            Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnUpdate.UseVisualStyleBackColor = True
            Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnSave.Image = CType(componentResourceManager.GetObject("btnSave.Image"), System.Drawing.Image)
            Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button13 As System.Windows.Forms.Button = Me.btnSave
            location = New System.Drawing.Point(11, 58)
            button13.Location = location
            Me.btnSave.Name = "btnSave"
            Dim button14 As System.Windows.Forms.Button = Me.btnSave
            size = New System.Drawing.Size(92, 37)
            button14.Size = size
            Me.btnSave.TabIndex = 1
            Me.btnSave.Text = "Save"
            Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnSave.UseVisualStyleBackColor = True
            Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnDelete.Image = CType(componentResourceManager.GetObject("btnDelete.Image"), System.Drawing.Image)
            Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button15 As System.Windows.Forms.Button = Me.btnDelete
            location = New System.Drawing.Point(11, 141)
            button15.Location = location
            Me.btnDelete.Name = "btnDelete"
            Dim button16 As System.Windows.Forms.Button = Me.btnDelete
            size = New System.Drawing.Size(92, 37)
            button16.Size = size
            Me.btnDelete.TabIndex = 6
            Me.btnDelete.Text = "Delete"
            Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnDelete.UseVisualStyleBackColor = True
            Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnClose.Image = CType(componentResourceManager.GetObject("btnClose.Image"), System.Drawing.Image)
            Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button17 As System.Windows.Forms.Button = Me.btnClose
            location = New System.Drawing.Point(914, 7)
            button17.Location = location
            Me.btnClose.Name = "btnClose"
            Dim button18 As System.Windows.Forms.Button = Me.btnClose
            size = New System.Drawing.Size(74, 37)
            button18.Size = size
            Me.btnClose.TabIndex = 5
            Me.btnClose.Text = "Close"
            Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnClose.UseVisualStyleBackColor = True
            Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel4.Controls.Add(Me.Button3)
            Me.Panel4.Controls.Add(Me.Button2)
            Me.Panel4.Controls.Add(Me.Button1)
            Me.Panel4.Controls.Add(Me.Label9)
            Me.Panel4.Controls.Add(Me.cmbSupplier)
            Me.Panel4.Controls.Add(Me.txtReorderPoint)
            Me.Panel4.Controls.Add(Me.Label4)
            Me.Panel4.Controls.Add(Me.Label6)
            Me.Panel4.Controls.Add(Me.cmbUnit)
            Me.Panel4.Controls.Add(Me.txtID)
            Me.Panel4.Controls.Add(Me.lblUserType)
            Me.Panel4.Controls.Add(Me.txtProductName)
            Me.Panel4.Controls.Add(Me.cmbCategory)
            Me.Panel4.Controls.Add(Me.lblUser)
            Me.Panel4.Controls.Add(Me.Label10)
            Me.Panel4.Controls.Add(Me.Label2)
            Me.Panel4.Controls.Add(Me.Label3)
            Me.Panel4.Controls.Add(Me.txtProductCode)
            Me.Panel4.Controls.Add(Me.txtFeatures)
            Me.Panel4.Controls.Add(Me.Label5)
            Me.Panel4.Controls.Add(Me.Label7)
            Me.Panel4.Controls.Add(Me.txtPrice)
            Me.Panel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim panel3 As System.Windows.Forms.Panel = Me.Panel4
            location = New System.Drawing.Point(9, 54)
            panel3.Location = location
            Me.Panel4.Name = "Panel4"
            Dim panel4 As System.Windows.Forms.Panel = Me.Panel4
            size = New System.Drawing.Size(427, 333)
            panel4.Size = size
            Me.Panel4.TabIndex = 0
            Me.Label9.AutoSize = True
            Dim label8 As System.Windows.Forms.Label = Me.Label9
            location = New System.Drawing.Point(10, 210)
            label8.Location = location
            Me.Label9.Name = "Label9"
            Dim label9 As System.Windows.Forms.Label = Me.Label9
            size = New System.Drawing.Size(59, 15)
            label9.Size = size
            Me.Label9.TabIndex = 330
            Me.Label9.Text = "Supplier :"
            Me.cmbSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
            Me.cmbSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
            Me.cmbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbSupplier.FormattingEnabled = True
            Dim comboBox3 As System.Windows.Forms.ComboBox = Me.cmbSupplier
            location = New System.Drawing.Point(125, 212)
            comboBox3.Location = location
            Me.cmbSupplier.Name = "cmbSupplier"
            Dim comboBox4 As System.Windows.Forms.ComboBox = Me.cmbSupplier
            size = New System.Drawing.Size(257, 23)
            comboBox4.Size = size
            Me.cmbSupplier.TabIndex = 3
            Me.txtReorderPoint.BackColor = System.Drawing.Color.White
            Me.txtReorderPoint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox3 As System.Windows.Forms.TextBox = Me.txtReorderPoint
            location = New System.Drawing.Point(125, 299)
            textBox3.Location = location
            Me.txtReorderPoint.Name = "txtReorderPoint"
            Dim textBox4 As System.Windows.Forms.TextBox = Me.txtReorderPoint
            size = New System.Drawing.Size(111, 21)
            textBox4.Size = size
            Me.txtReorderPoint.TabIndex = 6
            Me.txtReorderPoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.Label4.AutoSize = True
            Dim label10 As System.Windows.Forms.Label = Me.Label4
            location = New System.Drawing.Point(10, 299)
            label10.Location = location
            Me.Label4.Name = "Label4"
            Dim label11 As System.Windows.Forms.Label = Me.Label4
            size = New System.Drawing.Size(89, 15)
            label11.Size = size
            Me.Label4.TabIndex = 328
            Me.Label4.Text = "Reorder Point :"
            Me.Label6.AutoSize = True
            Dim label12 As System.Windows.Forms.Label = Me.Label6
            location = New System.Drawing.Point(10, 241)
            label12.Location = location
            Me.Label6.Name = "Label6"
            Dim label13 As System.Windows.Forms.Label = Me.Label6
            size = New System.Drawing.Size(35, 15)
            label13.Size = size
            Me.Label6.TabIndex = 327
            Me.Label6.Text = "Unit :"
            Me.cmbUnit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
            Me.cmbUnit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
            Me.cmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbUnit.FormattingEnabled = True
            Dim comboBox5 As System.Windows.Forms.ComboBox = Me.cmbUnit
            location = New System.Drawing.Point(125, 241)
            comboBox5.Location = location
            Me.cmbUnit.Name = "cmbUnit"
            Dim comboBox6 As System.Windows.Forms.ComboBox = Me.cmbUnit
            size = New System.Drawing.Size(111, 23)
            comboBox6.Size = size
            Me.cmbUnit.TabIndex = 4
            Dim textBox5 As System.Windows.Forms.TextBox = Me.txtID
            location = New System.Drawing.Point(305, -1)
            textBox5.Location = location
            Me.txtID.Name = "txtID"
            Dim textBox6 As System.Windows.Forms.TextBox = Me.txtID
            size = New System.Drawing.Size(53, 21)
            textBox6.Size = size
            Me.txtID.TabIndex = 323
            Me.txtID.Visible = False
            Me.lblUserType.AutoSize = True
            Dim label14 As System.Windows.Forms.Label = Me.lblUserType
            location = New System.Drawing.Point(320, 11)
            label14.Location = location
            Me.lblUserType.Name = "lblUserType"
            Dim label15 As System.Windows.Forms.Label = Me.lblUserType
            size = New System.Drawing.Size(62, 15)
            label15.Size = size
            Me.lblUserType.TabIndex = 313
            Me.lblUserType.Text = "User Type"
            Me.lblUserType.Visible = False
            Me.txtProductName.BackColor = System.Drawing.SystemColors.ButtonHighlight
            Me.txtProductName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox7 As System.Windows.Forms.TextBox = Me.txtProductName
            location = New System.Drawing.Point(125, 41)
            textBox7.Location = location
            Me.txtProductName.Name = "txtProductName"
            Dim textBox8 As System.Windows.Forms.TextBox = Me.txtProductName
            size = New System.Drawing.Size(257, 21)
            textBox8.Size = size
            Me.txtProductName.TabIndex = 0
            Me.cmbCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
            Me.cmbCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
            Me.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbCategory.FormattingEnabled = True
            Dim comboBox7 As System.Windows.Forms.ComboBox = Me.cmbCategory
            location = New System.Drawing.Point(125, 68)
            comboBox7.Location = location
            Me.cmbCategory.Name = "cmbCategory"
            Dim comboBox8 As System.Windows.Forms.ComboBox = Me.cmbCategory
            size = New System.Drawing.Size(195, 23)
            comboBox8.Size = size
            Me.cmbCategory.TabIndex = 1
            Me.lblUser.AutoSize = True
            Dim label16 As System.Windows.Forms.Label = Me.lblUser
            location = New System.Drawing.Point(265, 12)
            label16.Location = location
            Me.lblUser.Name = "lblUser"
            Dim label17 As System.Windows.Forms.Label = Me.lblUser
            size = New System.Drawing.Size(45, 15)
            label17.Size = size
            Me.lblUser.TabIndex = 12
            Me.lblUser.Text = "Label8"
            Me.lblUser.Visible = False
            Me.Label10.AutoSize = True
            Dim label18 As System.Windows.Forms.Label = Me.Label10
            location = New System.Drawing.Point(10, 270)
            label18.Location = location
            Me.Label10.Name = "Label10"
            Dim label19 As System.Windows.Forms.Label = Me.Label10
            size = New System.Drawing.Size(41, 15)
            label19.Size = size
            Me.Label10.TabIndex = 21
            Me.Label10.Text = "Price :"
            Me.Label2.AutoSize = True
            Dim label20 As System.Windows.Forms.Label = Me.Label2
            location = New System.Drawing.Point(10, 41)
            label20.Location = location
            Me.Label2.Name = "Label2"
            Dim label21 As System.Windows.Forms.Label = Me.Label2
            size = New System.Drawing.Size(92, 15)
            label21.Size = size
            Me.Label2.TabIndex = 5
            Me.Label2.Text = "Product Name :"
            Me.Label3.AutoSize = True
            Dim label22 As System.Windows.Forms.Label = Me.Label3
            location = New System.Drawing.Point(10, 11)
            label22.Location = location
            Me.Label3.Name = "Label3"
            Dim label23 As System.Windows.Forms.Label = Me.Label3
            size = New System.Drawing.Size(87, 15)
            label23.Size = size
            Me.Label3.TabIndex = 0
            Me.Label3.Text = "Product Code :"
            Me.txtProductCode.BackColor = System.Drawing.SystemColors.Control
            Me.txtProductCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox9 As System.Windows.Forms.TextBox = Me.txtProductCode
            location = New System.Drawing.Point(125, 13)
            textBox9.Location = location
            Me.txtProductCode.Name = "txtProductCode"
            Me.txtProductCode.[ReadOnly] = True
            Dim textBox10 As System.Windows.Forms.TextBox = Me.txtProductCode
            size = New System.Drawing.Size(123, 21)
            textBox10.Size = size
            Me.txtProductCode.TabIndex = 7
            Me.txtFeatures.BackColor = System.Drawing.Color.White
            Me.txtFeatures.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox11 As System.Windows.Forms.TextBox = Me.txtFeatures
            location = New System.Drawing.Point(125, 97)
            textBox11.Location = location
            Me.txtFeatures.Multiline = True
            Me.txtFeatures.Name = "txtFeatures"
            Me.txtFeatures.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Dim textBox12 As System.Windows.Forms.TextBox = Me.txtFeatures
            size = New System.Drawing.Size(286, 109)
            textBox12.Size = size
            Me.txtFeatures.TabIndex = 2
            Me.Label5.AutoSize = True
            Dim label24 As System.Windows.Forms.Label = Me.Label5
            location = New System.Drawing.Point(10, 68)
            label24.Location = location
            Me.Label5.Name = "Label5"
            Dim label25 As System.Windows.Forms.Label = Me.Label5
            size = New System.Drawing.Size(61, 15)
            label25.Size = size
            Me.Label5.TabIndex = 11
            Me.Label5.Text = "Category :"
            Me.Label7.AutoSize = True
            Dim label26 As System.Windows.Forms.Label = Me.Label7
            location = New System.Drawing.Point(10, 97)
            label26.Location = location
            Me.Label7.Name = "Label7"
            Dim label27 As System.Windows.Forms.Label = Me.Label7
            size = New System.Drawing.Size(75, 15)
            label27.Size = size
            Me.Label7.TabIndex = 13
            Me.Label7.Text = "Description :"
            Me.txtPrice.BackColor = System.Drawing.Color.White
            Me.txtPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox13 As System.Windows.Forms.TextBox = Me.txtPrice
            location = New System.Drawing.Point(125, 270)
            textBox13.Location = location
            Me.txtPrice.Name = "txtPrice"
            Dim textBox14 As System.Windows.Forms.TextBox = Me.txtPrice
            size = New System.Drawing.Size(111, 21)
            textBox14.Size = size
            Me.txtPrice.TabIndex = 5
            Me.txtPrice.Text = "0.00"
            Me.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.Panel2.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Panel2.Controls.Add(Me.txtPName)
            Me.Panel2.Controls.Add(Me.Label1)
            Dim panel5 As System.Windows.Forms.Panel = Me.Panel2
            location = New System.Drawing.Point(9, 7)
            panel5.Location = location
            Me.Panel2.Name = "Panel2"
            Dim panel6 As System.Windows.Forms.Panel = Me.Panel2
            size = New System.Drawing.Size(899, 36)
            panel6.Size = size
            Me.Panel2.TabIndex = 0
            Me.txtPName.BackColor = System.Drawing.SystemColors.Control
            Me.txtPName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox15 As System.Windows.Forms.TextBox = Me.txtPName
            location = New System.Drawing.Point(72, 8)
            textBox15.Location = location
            Me.txtPName.Name = "txtPName"
            Me.txtPName.[ReadOnly] = True
            Dim textBox16 As System.Windows.Forms.TextBox = Me.txtPName
            size = New System.Drawing.Size(43, 21)
            textBox16.Size = size
            Me.txtPName.TabIndex = 1
            Me.txtPName.Visible = False
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label1.ForeColor = System.Drawing.Color.White
            Dim label28 As System.Windows.Forms.Label = Me.Label1
            location = New System.Drawing.Point(397, 5)
            label28.Location = location
            Me.Label1.Name = "Label1"
            Dim label29 As System.Windows.Forms.Label = Me.Label1
            size = New System.Drawing.Size(136, 24)
            label29.Size = size
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Product Entry"
            Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.Button1.Image = RestaurantPOS14.My.Resources.Resources._1__2_
            Dim button19 As System.Windows.Forms.Button = Me.Button1
            location = New System.Drawing.Point(326, 68)
            button19.Location = location
            Me.Button1.Name = "Button1"
            Dim button20 As System.Windows.Forms.Button = Me.Button1
            size = New System.Drawing.Size(31, 23)
            button20.Size = size
            Me.Button1.TabIndex = 331
            Me.Button1.UseVisualStyleBackColor = True
            Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.Button2.Image = RestaurantPOS14.My.Resources.Resources._1__2_
            Dim button21 As System.Windows.Forms.Button = Me.Button2
            location = New System.Drawing.Point(388, 211)
            button21.Location = location
            Me.Button2.Name = "Button2"
            Dim button22 As System.Windows.Forms.Button = Me.Button2
            size = New System.Drawing.Size(31, 23)
            button22.Size = size
            Me.Button2.TabIndex = 332
            Me.Button2.UseVisualStyleBackColor = True
            Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.Button3.Image = RestaurantPOS14.My.Resources.Resources._1__2_
            Dim button23 As System.Windows.Forms.Button = Me.Button3
            location = New System.Drawing.Point(242, 240)
            button23.Location = location
            Me.Button3.Name = "Button3"
            Dim button24 As System.Windows.Forms.Button = Me.Button3
            size = New System.Drawing.Size(31, 23)
            button24.Size = size
            Me.Button3.TabIndex = 333
            Me.Button3.UseVisualStyleBackColor = True
            Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.Button4.Image = RestaurantPOS14.My.Resources.Resources._1__2_
            Dim button25 As System.Windows.Forms.Button = Me.Button4
            location = New System.Drawing.Point(286, 22)
            button25.Location = location
            Me.Button4.Name = "Button4"
            Dim button26 As System.Windows.Forms.Button = Me.Button4
            size = New System.Drawing.Size(31, 23)
            button26.Size = size
            Me.Button4.TabIndex = 314
            Me.Button4.UseVisualStyleBackColor = True
            Me.lblSet.AutoSize = True
            Dim label30 As System.Windows.Forms.Label = Me.lblSet
            location = New System.Drawing.Point(196, 164)
            label30.Location = location
            Me.lblSet.Name = "lblSet"
            Dim label31 As System.Windows.Forms.Label = Me.lblSet
            size = New System.Drawing.Size(33, 13)
            label31.Size = size
            Me.lblSet.TabIndex = 315
            Me.lblSet.Text = "lblSet"
            Me.lblSet.Visible = False
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            size = New System.Drawing.Size(1009, 410)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.Panel1)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MaximizeBox = False
            MyBase.MinimizeBox = False
            MyBase.Name = "frmProduct"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Panel1.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox3.PerformLayout()
            CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox2.ResumeLayout(False)
            Me.Panel4.ResumeLayout(False)
            Me.Panel4.PerformLayout()
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            MyBase.ResumeLayout(False)
        End Sub
    End Class
End Namespace
