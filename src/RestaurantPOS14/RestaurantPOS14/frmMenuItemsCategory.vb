Imports System
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
    Public Class frmMenuItemsCategory
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel1")>
        Private _Panel1 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtCategory")>
        Private _txtCategory As System.Windows.Forms.TextBox

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

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtServiceTax")>
        Private _txtServiceTax As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label2")>
        Private _Label2 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtCategoryName")>
        Private _txtCategoryName As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblUser")>
        Private _lblUser As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtVAT")>
        Private _txtVAT As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox2")>
        Private _GroupBox2 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox1")>
        Private _GroupBox1 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label3")>
        Private _Label3 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("ColorDialog1")>
        Private _ColorDialog1 As System.Windows.Forms.ColorDialog

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("LinkLabel1")>
        Private _LinkLabel1 As System.Windows.Forms.LinkLabel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnUIColor")>
        Private _btnUIColor As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtSCPer")>
        Private _txtSCPer As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label4")>
        Private _Label4 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("cmbKitchen")>
        Private _cmbKitchen As System.Windows.Forms.ComboBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnExportExcel")>
        Private _btnExportExcel As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnAdd")>
        Private _btnAdd As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblSet")>
        Private _lblSet As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column1")>
        Private _Column1 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column6")>
        Private _Column6 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column2")>
        Private _Column2 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column3")>
        Private _Column3 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column5")>
        Private _Column5 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column4")>
        Private _Column4 As System.Windows.Forms.DataGridViewTextBoxColumn

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

        Friend Overridable Property txtServiceTax As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtServiceTax
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.Windows.Forms.KeyPressEventHandler = AddressOf Me.txtServiceTax_KeyPress
                If Me._txtServiceTax IsNot Nothing Then
                    RemoveHandler Me._txtServiceTax.KeyPress, value2
                End If

                Me._txtServiceTax = value
                If Me._txtServiceTax IsNot Nothing Then
                    AddHandler Me._txtServiceTax.KeyPress, value2
                End If
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

        Friend Overridable Property txtCategoryName As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtCategoryName
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtCategoryName = value
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

        Friend Overridable Property txtVAT As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtVAT
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.Windows.Forms.KeyPressEventHandler = AddressOf Me.txtVAT_KeyPress
                If Me._txtVAT IsNot Nothing Then
                    RemoveHandler Me._txtVAT.KeyPress, value2
                End If

                Me._txtVAT = value
                If Me._txtVAT IsNot Nothing Then
                    AddHandler Me._txtVAT.KeyPress, value2
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

        Friend Overridable Property txtSCPer As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtSCPer
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.Windows.Forms.KeyPressEventHandler = AddressOf Me.txtSCPer_KeyPress
                If Me._txtSCPer IsNot Nothing Then
                    RemoveHandler Me._txtSCPer.KeyPress, value2
                End If

                Me._txtSCPer = value
                If Me._txtSCPer IsNot Nothing Then
                    AddHandler Me._txtSCPer.KeyPress, value2
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

        Friend Overridable Property btnAdd As System.Windows.Forms.Button
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

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            AddHandler MyBase.Load, AddressOf Me.frmCategory_Load
            Call RestaurantPOS14.frmMenuItemsCategory.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmMenuItemsCategory.__ENCList
                If RestaurantPOS14.frmMenuItemsCategory.__ENCList.Count = RestaurantPOS14.frmMenuItemsCategory.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmMenuItemsCategory.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmMenuItemsCategory.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmMenuItemsCategory.__ENCList(num) = RestaurantPOS14.frmMenuItemsCategory.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmMenuItemsCategory.__ENCList.RemoveRange(num, RestaurantPOS14.frmMenuItemsCategory.__ENCList.Count - num)
                    RestaurantPOS14.frmMenuItemsCategory.__ENCList.Capacity = RestaurantPOS14.frmMenuItemsCategory.__ENCList.Count
                End If

                Call RestaurantPOS14.frmMenuItemsCategory.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Public Sub fillCombo()
            Try
                Dim sqlConnection As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                sqlConnection.Open()
                RestaurantPOS14.ModClasses.adp = New System.Data.SqlClient.SqlDataAdapter()
                RestaurantPOS14.ModClasses.adp.SelectCommand = New System.Data.SqlClient.SqlCommand("SELECT distinct RTRIM(KitchenName) FROM Kitchen order by 1", sqlConnection)
                RestaurantPOS14.ModClasses.ds = New System.Data.DataSet("ds")
                RestaurantPOS14.ModClasses.adp.Fill(RestaurantPOS14.ModClasses.ds)
                Dim dataTable As System.Data.DataTable = RestaurantPOS14.ModClasses.ds.Tables(0)
                Me.cmbKitchen.Items.Clear()
                For Each dataRow As System.Data.DataRow In dataTable.Rows
                    Me.cmbKitchen.Items.Add(dataRow(CInt((0))).ToString())
                Next

                sqlConnection.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub Reset()
            Me.txtCategory.Text = ""
            Me.cmbKitchen.SelectedIndex = -1
            Me.txtCategory.Focus()
            If RestaurantPOS14.ModFunc.IsSaveAllowed(Me.lblUser.Text, "Categories") Then
                Me.btnSave.Enabled = True
                Me.btnExportExcel.Enabled = True
            Else
                Me.btnSave.Enabled = False
                Me.btnExportExcel.Enabled = False
            End If

            If RestaurantPOS14.ModFunc.IsViewAllowed(Me.lblUser.Text, "Categories") Then
                Me.Getdata()
            Else
                Me.dgw.Rows.Clear()
            End If

            Me.btnUpdate.Enabled = False
            Me.btnDelete.Enabled = False
            Me.btnUIColor.BackColor = System.Drawing.Color.Crimson
        End Sub

        Private Sub btnClose_Click(sender As Object, e As System.EventArgs)
            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "MI", TextCompare:=False) = 0 Then
                Call RestaurantPOS14.My.MyProject.Forms.frmMenuItem.fillCombo()
            End If

            MyBase.Close()
        End Sub

        Private Sub btnSave_Click(sender As Object, e As System.EventArgs)
            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtCategory.Text, "", TextCompare:=False) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please enter category name", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtCategory.Focus()
                Return
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.cmbKitchen.Text, "", TextCompare:=False) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please select kitchen", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.cmbKitchen.Focus()
                Return
            End If

            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select CategoryName from Category where CategoryName=@d1")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtCategory.Text)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Category Already Exists", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                    Me.txtCategory.Text = ""
                    Me.txtCategory.Focus()
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("insert into Category(CategoryName,VAT,ST,SC,BackColor,Kitchen) VALUES (@d1," & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.txtVAT.Text)) & "," & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.txtServiceTax.Text)) & "," & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.txtSCPer.Text)) & ",@d2,@d3)")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtCategory.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Me.btnUIColor.BackColor.ToArgb())
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Me.cmbKitchen.Text)
                RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                RestaurantPOS14.ModClasses.con.Close()
                Dim st As String = "added the new category '" & Me.txtCategory.Text & "'"
                RestaurantPOS14.ModFunc.LogFunc(Me.lblUser.Text, st)
                Call System.Windows.Forms.MessageBox.Show("Successfully saved", "Category", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                If RestaurantPOS14.ModFunc.IsViewAllowed(Me.lblUser.Text, "Categories") Then
                    Me.Getdata()
                Else
                    Me.dgw.Rows.Clear()
                End If

                Me.txtCategory.Text = ""
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
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select CategoryName from Dish,Category where Dish.Category=Category.CategoryName and CategoryName=@d1")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtCategory.Text)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Unable to delete..Already in use in Menu Items Entry", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("delete from Category where CategoryName=@d1")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtCategory.Text)
                If RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery() > 0 Then
                    Dim st As String = "deleted the category '" & Me.txtCategory.Text & "'"
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
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtCategory.Text, "", TextCompare:=False) = 0 Then
                    Call System.Windows.Forms.MessageBox.Show("Please enter category name", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Me.txtCategory.Focus()
                    Return
                End If

                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.cmbKitchen.Text, "", TextCompare:=False) = 0 Then
                    Call System.Windows.Forms.MessageBox.Show("Please select kitchen", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Me.cmbKitchen.Focus()
                    Return
                End If

                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("update RestaurantPOS_OrderedProductKOT set Category=@d1 where Category=@d2")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtCategory.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Me.txtCategoryName.Text)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("update RestaurantPOS_OrderedProductBillTA set Category=@d1 where Category=@d2")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtCategory.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Me.txtCategoryName.Text)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("update RestaurantPOS_OrderedProductBillKOT set Category=@d1 where Category=@d2")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtCategory.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Me.txtCategoryName.Text)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("update RestaurantPOS_OrderedProductBillEB set Category=@d1 where Category=@d2")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtCategory.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Me.txtCategoryName.Text)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("update RestaurantPOS_OrderedProductBillHD set Category=@d1 where Category=@d2")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtCategory.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Me.txtCategoryName.Text)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("update Category set CategoryName=@d1,VAT=" & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.txtVAT.Text)) & ",ST=" & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.txtServiceTax.Text)) & ",SC=" & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.txtSCPer.Text)) & ",BackColor=@d3,Kitchen=@d4 where CategoryName=@d2")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtCategory.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Me.txtCategoryName.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Me.btnUIColor.BackColor.ToArgb())
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", Me.cmbKitchen.Text)
                RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                RestaurantPOS14.ModClasses.con.Close()
                Dim st As String = "updated the category '" & Me.txtCategory.Text & "' details"
                RestaurantPOS14.ModFunc.LogFunc(Me.lblUser.Text, st)
                Call System.Windows.Forms.MessageBox.Show("Successfully updated", "Category Info", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                Me.Reset()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub Getdata()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT RTRIM(CategoryName),RTRIM(Kitchen), (VAT), (ST),SC,BackColor from Category order by Cat_ID", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                Me.dgw.Rows.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Me.dgw.Rows.Add(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(0)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(1)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(2)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(3)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(4)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(5)))
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

        Private Sub frmCategory_Load(sender As Object, e As System.EventArgs)
            Me.GetTaxes()
            Me.fillCombo()
        End Sub

        Private Sub dgw_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs)
            Try
                If Me.dgw.Rows.Count > 0 Then
                    If Me.dgw.SelectedRows.Count = 0 Then Return
                    Dim dataGridViewRow As System.Windows.Forms.DataGridViewRow = Me.dgw.SelectedRows(0)
                    Me.txtCategory.Text = dataGridViewRow.Cells(CInt((0))).Value.ToString()
                    Me.txtCategoryName.Text = dataGridViewRow.Cells(CInt((0))).Value.ToString()
                    Me.cmbKitchen.Text = dataGridViewRow.Cells(CInt((1))).Value.ToString()
                    Me.txtVAT.Text = dataGridViewRow.Cells(CInt((2))).Value.ToString()
                    Me.txtServiceTax.Text = dataGridViewRow.Cells(CInt((3))).Value.ToString()
                    Me.txtSCPer.Text = dataGridViewRow.Cells(CInt((4))).Value.ToString()
                    Dim backColor As System.Drawing.Color = System.Drawing.Color.FromArgb(Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(dataGridViewRow.Cells(CInt((5))).Value))
                    Me.btnUIColor.BackColor = backColor
                    If RestaurantPOS14.ModFunc.IsDeleteAllowed(Me.lblUser.Text, "Categories") Then
                        Me.btnDelete.Enabled = True
                    Else
                        Me.btnDelete.Enabled = False
                    End If

                    If RestaurantPOS14.ModFunc.IsUpdateAllowed(Me.lblUser.Text, "Categories") Then
                        Me.btnUpdate.Enabled = True
                    Else
                        Me.btnUpdate.Enabled = False
                    End If

                    Me.btnSave.Enabled = False
                End If
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub txtVAT_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
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

        Private Sub txtServiceTax_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
            Dim keyChar As Char = e.KeyChar
            If Char.IsControl(keyChar) Then
                Return
            End If

            If Char.IsDigit(keyChar) OrElse keyChar = "."c Then
                Dim text As String = Me.txtServiceTax.Text
                Dim selectionStart As Integer = Me.txtServiceTax.SelectionStart
                Dim selectionLength As Integer = Me.txtServiceTax.SelectionLength
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

        Private Sub LinkLabel1_LinkClicked(sender As Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
            Try
                If Me.ColorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                    Me.btnUIColor.BackColor = Me.ColorDialog1.Color
                End If
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub GetTaxes()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = RestaurantPOS14.ModClasses.con.CreateCommand()
                RestaurantPOS14.ModClasses.cmd.CommandText = "SELECT IsNull(ServiceTax,0.00),IsNull(VAT,0.00),IsNull(ServiceCharges,0.00) from OtherSetting"
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.txtServiceTax.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                    Me.txtVAT.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(1))
                    Me.txtSCPer.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(2))
                Else
                    Me.txtServiceTax.Text = "0.00"
                    Me.txtVAT.Text = "0.00"
                    Me.txtSCPer.Text = "0.00"
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

        Private Sub txtSCPer_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
            Dim keyChar As Char = e.KeyChar
            If Char.IsControl(keyChar) Then
                Return
            End If

            If Char.IsDigit(keyChar) OrElse keyChar = "."c Then
                Dim text As String = Me.txtSCPer.Text
                Dim selectionStart As Integer = Me.txtSCPer.SelectionStart
                Dim selectionLength As Integer = Me.txtSCPer.SelectionLength
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

        Private Sub btnExportExcel_Click(sender As Object, e As System.EventArgs)
            Call RestaurantPOS14.My.MyProject.Forms.frmCategoriesExportImport.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmCategoriesExportImport.ShowDialog()
        End Sub

        Private Sub btnAdd_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmKitchen_Section.lblUser.Text = Me.lblUser.Text
            RestaurantPOS14.My.MyProject.Forms.frmKitchen_Section.lblSet.Text = "Category"
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmMenuItemsCategory))
            Dim dataGridViewCellStyle As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.lblSet = New System.Windows.Forms.Label()
            Me.btnExportExcel = New System.Windows.Forms.Button()
            Me.txtSCPer = New System.Windows.Forms.TextBox()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.btnDelete = New System.Windows.Forms.Button()
            Me.btnUpdate = New System.Windows.Forms.Button()
            Me.btnNew = New System.Windows.Forms.Button()
            Me.btnSave = New System.Windows.Forms.Button()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.btnAdd = New System.Windows.Forms.Button()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.cmbKitchen = New System.Windows.Forms.ComboBox()
            Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
            Me.btnUIColor = New System.Windows.Forms.Button()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtVAT = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtCategory = New System.Windows.Forms.TextBox()
            Me.lblUser = New System.Windows.Forms.Label()
            Me.txtCategoryName = New System.Windows.Forms.TextBox()
            Me.btnClose = New System.Windows.Forms.Button()
            Me.dgw = New System.Windows.Forms.DataGridView()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtServiceTax = New System.Windows.Forms.TextBox()
            Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
            Me.Panel1.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel2.SuspendLayout()
            MyBase.SuspendLayout()
            Me.Panel1.BackColor = System.Drawing.Color.White
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.lblSet)
            Me.Panel1.Controls.Add(Me.btnExportExcel)
            Me.Panel1.Controls.Add(Me.txtSCPer)
            Me.Panel1.Controls.Add(Me.GroupBox2)
            Me.Panel1.Controls.Add(Me.GroupBox1)
            Me.Panel1.Controls.Add(Me.lblUser)
            Me.Panel1.Controls.Add(Me.txtCategoryName)
            Me.Panel1.Controls.Add(Me.btnClose)
            Me.Panel1.Controls.Add(Me.dgw)
            Me.Panel1.Controls.Add(Me.Panel2)
            Me.Panel1.Controls.Add(Me.txtServiceTax)
            Dim panel As System.Windows.Forms.Panel = Me.Panel1
            Dim location As System.Drawing.Point = New System.Drawing.Point(4, 4)
            panel.Location = location
            Me.Panel1.Name = "Panel1"
            Dim panel2 As System.Windows.Forms.Panel = Me.Panel1
            Dim size As System.Drawing.Size = New System.Drawing.Size(480, 592)
            panel2.Size = size
            Me.Panel1.TabIndex = 0
            Me.lblSet.AutoSize = True
            Dim label As System.Windows.Forms.Label = Me.lblSet
            location = New System.Drawing.Point(223, 289)
            label.Location = location
            Me.lblSet.Name = "lblSet"
            Dim label2 As System.Windows.Forms.Label = Me.lblSet
            size = New System.Drawing.Size(33, 13)
            label2.Size = size
            Me.lblSet.TabIndex = 9
            Me.lblSet.Text = "lblSet"
            Me.lblSet.Visible = False
            Me.btnExportExcel.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnExportExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnExportExcel.Image = CType(componentResourceManager.GetObject("btnExportExcel.Image"), System.Drawing.Image)
            Me.btnExportExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button As System.Windows.Forms.Button = Me.btnExportExcel
            location = New System.Drawing.Point(347, 432)
            button.Location = location
            Me.btnExportExcel.Name = "btnExportExcel"
            Dim button2 As System.Windows.Forms.Button = Me.btnExportExcel
            size = New System.Drawing.Size(129, 49)
            button2.Size = size
            Me.btnExportExcel.TabIndex = 7
            Me.btnExportExcel.Text = "Import/Export Excel"
            Me.btnExportExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnExportExcel.UseVisualStyleBackColor = True
            Me.txtSCPer.BackColor = System.Drawing.Color.White
            Me.txtSCPer.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox As System.Windows.Forms.TextBox = Me.txtSCPer
            location = New System.Drawing.Point(4, 349)
            textBox.Location = location
            Me.txtSCPer.Name = "txtSCPer"
            Dim textBox2 As System.Windows.Forms.TextBox = Me.txtSCPer
            size = New System.Drawing.Size(61, 23)
            textBox2.Size = size
            Me.txtSCPer.TabIndex = 2
            Me.txtSCPer.Text = "0.00"
            Me.txtSCPer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.txtSCPer.Visible = False
            Me.GroupBox2.Controls.Add(Me.btnDelete)
            Me.GroupBox2.Controls.Add(Me.btnUpdate)
            Me.GroupBox2.Controls.Add(Me.btnNew)
            Me.GroupBox2.Controls.Add(Me.btnSave)
            Dim groupBox As System.Windows.Forms.GroupBox = Me.GroupBox2
            location = New System.Drawing.Point(375, 40)
            groupBox.Location = location
            Me.GroupBox2.Name = "GroupBox2"
            Dim groupBox2 As System.Windows.Forms.GroupBox = Me.GroupBox2
            size = New System.Drawing.Size(98, 193)
            groupBox2.Size = size
            Me.GroupBox2.TabIndex = 4
            Me.GroupBox2.TabStop = False
            Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnDelete.Image = CType(componentResourceManager.GetObject("btnDelete.Image"), System.Drawing.Image)
            Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button3 As System.Windows.Forms.Button = Me.btnDelete
            location = New System.Drawing.Point(8, 146)
            button3.Location = location
            Me.btnDelete.Name = "btnDelete"
            Dim button4 As System.Windows.Forms.Button = Me.btnDelete
            size = New System.Drawing.Size(83, 40)
            button4.Size = size
            Me.btnDelete.TabIndex = 3
            Me.btnDelete.Text = "Delete"
            Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnDelete.UseVisualStyleBackColor = True
            Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnUpdate.Image = CType(componentResourceManager.GetObject("btnUpdate.Image"), System.Drawing.Image)
            Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button5 As System.Windows.Forms.Button = Me.btnUpdate
            location = New System.Drawing.Point(8, 102)
            button5.Location = location
            Me.btnUpdate.Name = "btnUpdate"
            Dim button6 As System.Windows.Forms.Button = Me.btnUpdate
            size = New System.Drawing.Size(83, 40)
            button6.Size = size
            Me.btnUpdate.TabIndex = 2
            Me.btnUpdate.Text = "Update"
            Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnUpdate.UseVisualStyleBackColor = True
            Me.btnNew.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnNew.Image = CType(componentResourceManager.GetObject("btnNew.Image"), System.Drawing.Image)
            Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button7 As System.Windows.Forms.Button = Me.btnNew
            location = New System.Drawing.Point(8, 14)
            button7.Location = location
            Me.btnNew.Name = "btnNew"
            Dim button8 As System.Windows.Forms.Button = Me.btnNew
            size = New System.Drawing.Size(83, 40)
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
            location = New System.Drawing.Point(8, 58)
            button9.Location = location
            Me.btnSave.Name = "btnSave"
            Dim button10 As System.Windows.Forms.Button = Me.btnSave
            size = New System.Drawing.Size(83, 40)
            button10.Size = size
            Me.btnSave.TabIndex = 1
            Me.btnSave.Text = "Save"
            Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnSave.UseVisualStyleBackColor = True
            Me.GroupBox1.Controls.Add(Me.btnAdd)
            Me.GroupBox1.Controls.Add(Me.Label4)
            Me.GroupBox1.Controls.Add(Me.cmbKitchen)
            Me.GroupBox1.Controls.Add(Me.LinkLabel1)
            Me.GroupBox1.Controls.Add(Me.btnUIColor)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.txtVAT)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.txtCategory)
            Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim groupBox3 As System.Windows.Forms.GroupBox = Me.GroupBox1
            location = New System.Drawing.Point(3, 424)
            groupBox3.Location = location
            Me.GroupBox1.Name = "GroupBox1"
            Dim groupBox4 As System.Windows.Forms.GroupBox = Me.GroupBox1
            size = New System.Drawing.Size(341, 163)
            groupBox4.Size = size
            Me.GroupBox1.TabIndex = 0
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Category Info :"
            Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnAdd.Image = RestaurantPOS14.My.Resources.Resources._1__2_
            Dim button11 As System.Windows.Forms.Button = Me.btnAdd
            location = New System.Drawing.Point(294, 81)
            button11.Location = location
            Me.btnAdd.Name = "btnAdd"
            Dim button12 As System.Windows.Forms.Button = Me.btnAdd
            size = New System.Drawing.Size(31, 23)
            button12.Size = size
            Me.btnAdd.TabIndex = 10
            Me.btnAdd.UseVisualStyleBackColor = True
            Me.Label4.AutoSize = True
            Dim label3 As System.Windows.Forms.Label = Me.Label4
            location = New System.Drawing.Point(15, 81)
            label3.Location = location
            Me.Label4.Name = "Label4"
            Dim label4 As System.Windows.Forms.Label = Me.Label4
            size = New System.Drawing.Size(98, 15)
            label4.Size = size
            Me.Label4.TabIndex = 9
            Me.Label4.Text = "Kitchen/Section :"
            Me.cmbKitchen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbKitchen.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.cmbKitchen.FormattingEnabled = True
            Dim comboBox As System.Windows.Forms.ComboBox = Me.cmbKitchen
            location = New System.Drawing.Point(119, 81)
            comboBox.Location = location
            Me.cmbKitchen.Name = "cmbKitchen"
            Dim comboBox2 As System.Windows.Forms.ComboBox = Me.cmbKitchen
            size = New System.Drawing.Size(170, 23)
            comboBox2.Size = size
            Me.cmbKitchen.TabIndex = 2
            Me.LinkLabel1.AutoSize = True
            Dim linkLabel As System.Windows.Forms.LinkLabel = Me.LinkLabel1
            location = New System.Drawing.Point(130, 127)
            linkLabel.Location = location
            Me.LinkLabel1.Name = "LinkLabel1"
            Dim linkLabel2 As System.Windows.Forms.LinkLabel = Me.LinkLabel1
            size = New System.Drawing.Size(70, 15)
            linkLabel2.Size = size
            Me.LinkLabel1.TabIndex = 4
            Me.LinkLabel1.TabStop = True
            Me.LinkLabel1.Text = "Select Color"
            Me.btnUIColor.BackColor = System.Drawing.Color.Crimson
            Me.btnUIColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnUIColor.ForeColor = System.Drawing.Color.White
            Dim button13 As System.Windows.Forms.Button = Me.btnUIColor
            location = New System.Drawing.Point(18, 119)
            button13.Location = location
            Me.btnUIColor.Name = "btnUIColor"
            Dim button14 As System.Windows.Forms.Button = Me.btnUIColor
            size = New System.Drawing.Size(106, 31)
            button14.Size = size
            Me.btnUIColor.TabIndex = 3
            Me.btnUIColor.Text = "Button UI Color"
            Me.btnUIColor.UseVisualStyleBackColor = False
            Me.Label3.AutoSize = True
            Dim label5 As System.Windows.Forms.Label = Me.Label3
            location = New System.Drawing.Point(15, 22)
            label5.Location = location
            Me.Label3.Name = "Label3"
            Dim label6 As System.Windows.Forms.Label = Me.Label3
            size = New System.Drawing.Size(60, 15)
            label6.Size = size
            Me.Label3.TabIndex = 7
            Me.Label3.Text = "Category :"
            Me.txtVAT.BackColor = System.Drawing.Color.White
            Me.txtVAT.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox3 As System.Windows.Forms.TextBox = Me.txtVAT
            location = New System.Drawing.Point(264, 52)
            textBox3.Location = location
            Me.txtVAT.Name = "txtVAT"
            Dim textBox4 As System.Windows.Forms.TextBox = Me.txtVAT
            size = New System.Drawing.Size(61, 23)
            textBox4.Size = size
            Me.txtVAT.TabIndex = 1
            Me.txtVAT.Text = "0.00"
            Me.txtVAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.Label2.AutoSize = True
            Dim label7 As System.Windows.Forms.Label = Me.Label2
            location = New System.Drawing.Point(15, 52)
            label7.Location = location
            Me.Label2.Name = "Label2"
            Dim label8 As System.Windows.Forms.Label = Me.Label2
            size = New System.Drawing.Size(47, 15)
            label8.Size = size
            Me.Label2.TabIndex = 5
            Me.Label2.Text = "service charge% :"
            Me.txtCategory.BackColor = System.Drawing.Color.White
            Me.txtCategory.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox5 As System.Windows.Forms.TextBox = Me.txtCategory
            location = New System.Drawing.Point(119, 22)
            textBox5.Location = location
            Me.txtCategory.Name = "txtCategory"
            Dim textBox6 As System.Windows.Forms.TextBox = Me.txtCategory
            size = New System.Drawing.Size(206, 23)
            textBox6.Size = size
            Me.txtCategory.TabIndex = 0
            Me.lblUser.AutoSize = True
            Dim label9 As System.Windows.Forms.Label = Me.lblUser
            location = New System.Drawing.Point(17, 333)
            label9.Location = location
            Me.lblUser.Name = "lblUser"
            Dim label10 As System.Windows.Forms.Label = Me.lblUser
            size = New System.Drawing.Size(39, 13)
            label10.Size = size
            Me.lblUser.TabIndex = 5
            Me.lblUser.Text = "Label8"
            Me.lblUser.Visible = False
            Dim textBox7 As System.Windows.Forms.TextBox = Me.txtCategoryName
            location = New System.Drawing.Point(7, 293)
            textBox7.Location = location
            Me.txtCategoryName.Name = "txtCategoryName"
            Dim textBox8 As System.Windows.Forms.TextBox = Me.txtCategoryName
            size = New System.Drawing.Size(49, 20)
            textBox8.Size = size
            Me.txtCategoryName.TabIndex = 4
            Me.txtCategoryName.Visible = False
            Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnClose.Image = CType(componentResourceManager.GetObject("btnClose.Image"), System.Drawing.Image)
            Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button15 As System.Windows.Forms.Button = Me.btnClose
            location = New System.Drawing.Point(396, 4)
            button15.Location = location
            Me.btnClose.Name = "btnClose"
            Dim button16 As System.Windows.Forms.Button = Me.btnClose
            size = New System.Drawing.Size(78, 33)
            button16.Size = size
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
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgw.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2
            Me.dgw.ColumnHeadersHeight = 30
            Me.dgw.Columns.AddRange(Me.Column1, Me.Column6, Me.Column2, Me.Column3, Me.Column5, Me.Column4)
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
            location = New System.Drawing.Point(5, 40)
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
            dataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gainsboro
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
            Me.dgw.RowsDefaultCellStyle = dataGridViewCellStyle5
            Me.dgw.RowTemplate.Height = 18
            Me.dgw.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgw.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Dim dataGridView2 As System.Windows.Forms.DataGridView = Me.dgw
            size = New System.Drawing.Size(365, 378)
            dataGridView2.Size = size
            Me.dgw.TabIndex = 1
            Me.Column1.HeaderText = "Category"
            Me.Column1.Name = "Column1"
            Me.Column1.[ReadOnly] = True
            Me.Column1.Width = 150
            Me.Column6.HeaderText = "Kitchen"
            Me.Column6.Name = "Column6"
            Me.Column6.[ReadOnly] = True
            Me.Column6.Width = 115
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            Me.Column2.DefaultCellStyle = dataGridViewCellStyle6
            Me.Column2.HeaderText = "service charge%"
            Me.Column2.Name = "Column2"
            Me.Column2.[ReadOnly] = True
            Me.Column2.Width = 70
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.Column3.DefaultCellStyle = dataGridViewCellStyle7
            Me.Column3.HeaderText = "Service Tax %"
            Me.Column3.Name = "Column3"
            Me.Column3.[ReadOnly] = True
            Me.Column3.Visible = False
            Me.Column3.Width = 135
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.Column5.DefaultCellStyle = dataGridViewCellStyle8
            Me.Column5.HeaderText = "service charges %"
            Me.Column5.Name = "Column5"
            Me.Column5.[ReadOnly] = True
            Me.Column5.Visible = False
            Me.Column5.Width = 117
            Me.Column4.HeaderText = "Button UI Color"
            Me.Column4.Name = "Column4"
            Me.Column4.[ReadOnly] = True
            Me.Column4.Visible = False
            Me.Panel2.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Panel2.Controls.Add(Me.Label1)
            Dim panel3 As System.Windows.Forms.Panel = Me.Panel2
            location = New System.Drawing.Point(4, 4)
            panel3.Location = location
            Me.Panel2.Name = "Panel2"
            Dim panel4 As System.Windows.Forms.Panel = Me.Panel2
            size = New System.Drawing.Size(391, 31)
            panel4.Size = size
            Me.Panel2.TabIndex = 0
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label1.ForeColor = System.Drawing.Color.White
            Dim label11 As System.Windows.Forms.Label = Me.Label1
            location = New System.Drawing.Point(92, 3)
            label11.Location = location
            Me.Label1.Name = "Label1"
            Dim label12 As System.Windows.Forms.Label = Me.Label1
            size = New System.Drawing.Size(215, 24)
            label12.Size = size
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "List of Item Categories"
            Me.txtServiceTax.BackColor = System.Drawing.Color.White
            Me.txtServiceTax.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox9 As System.Windows.Forms.TextBox = Me.txtServiceTax
            location = New System.Drawing.Point(7, 290)
            textBox9.Location = location
            Me.txtServiceTax.Name = "txtServiceTax"
            Dim textBox10 As System.Windows.Forms.TextBox = Me.txtServiceTax
            size = New System.Drawing.Size(23, 23)
            textBox10.Size = size
            Me.txtServiceTax.TabIndex = 2
            Me.txtServiceTax.Text = "0.00"
            Me.txtServiceTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.txtServiceTax.Visible = False
            MyBase.AcceptButton = Me.btnSave
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            size = New System.Drawing.Size(488, 599)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.Panel1)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MaximizeBox = False
            MyBase.MinimizeBox = False
            MyBase.Name = "frmMenuItemsCategory"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            MyBase.ResumeLayout(False)
        End Sub
    End Class
End Namespace
