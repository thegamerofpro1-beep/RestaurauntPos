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
    Public Class frmStock_Store
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel1")>
        Private _Panel1 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label3")>
        Private _Label3 As System.Windows.Forms.Label

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

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtQty")>
        Private _txtQty As System.Windows.Forms.TextBox

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

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtST_ID")>
        Private _txtST_ID As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblUser")>
        Private _lblUser As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblSet")>
        Private _lblSet As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblUserType")>
        Private _lblUserType As System.Windows.Forms.Label

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

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("cmbItemName")>
        Private _cmbItemName As System.Windows.Forms.ComboBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnRemove")>
        Private _btnRemove As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnAdd")>
        Private _btnAdd As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column3")>
        Private _Column3 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column4")>
        Private _Column4 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Button1")>
        Private _Button1 As System.Windows.Forms.Button

        Private str As String

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

        Friend Overridable Property cmbItemName As System.Windows.Forms.ComboBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._cmbItemName
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ComboBox)
                Dim value2 As System.Windows.Forms.ListControlConvertEventHandler = AddressOf Me.cmbProductName_Format
                If Me._cmbItemName IsNot Nothing Then
                    RemoveHandler Me._cmbItemName.Format, value2
                End If

                Me._cmbItemName = value
                If Me._cmbItemName IsNot Nothing Then
                    AddHandler Me._cmbItemName.Format, value2
                End If
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
            AddHandler MyBase.Load, AddressOf Me.frmPurchase_Load
            Call RestaurantPOS14.frmStock_Store.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmStock_Store.__ENCList
                If RestaurantPOS14.frmStock_Store.__ENCList.Count = RestaurantPOS14.frmStock_Store.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmStock_Store.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmStock_Store.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmStock_Store.__ENCList(num) = RestaurantPOS14.frmStock_Store.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmStock_Store.__ENCList.RemoveRange(num, RestaurantPOS14.frmStock_Store.__ENCList.Count - num)
                    RestaurantPOS14.frmStock_Store.__ENCList.Capacity = RestaurantPOS14.frmStock_Store.__ENCList.Count
                End If

                Call RestaurantPOS14.frmStock_Store.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Private Sub auto()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT MAX(ST_ID) FROM Stock_Store")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                If Microsoft.VisualBasic.Information.IsDBNull(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.cmd.ExecuteScalar())) Then
                    Me.txtST_ID.Text = 1.ToString()
                Else
                    Dim num As Integer = Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(RestaurantPOS14.ModClasses.cmd.ExecuteScalar(), 1))
                    Me.txtST_ID.Text = num.ToString()
                End If

                RestaurantPOS14.ModClasses.cmd.Dispose()
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con.Dispose()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub Reset()
            Me.dtpDate.Value = Microsoft.VisualBasic.DateAndTime.Today
            If RestaurantPOS14.ModFunc.IsViewAllowed(Me.lblUser.Text, "Items Stock") Then
                Me.btnGetData.Enabled = True
            Else
                Me.btnGetData.Enabled = False
            End If

            If RestaurantPOS14.ModFunc.IsSaveAllowed(Me.lblUser.Text, "Items Stock") Then
                Me.btnSave.Enabled = True
            Else
                Me.btnSave.Enabled = False
            End If

            Me.btnDelete.Enabled = False
            Me.DataGridView1.Enabled = True
            Me.btnAdd.Enabled = True
            Me.btnRemove.Enabled = False
            Me.DataGridView1.Rows.Clear()
            Me.lblSet.Text = ""
            Me.Clear()
            Me.auto()
        End Sub

        Public Sub Clear()
            Me.cmbItemName.Text = ""
            Me.txtQty.Text = ""
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
            Me.fillItem()
        End Sub

        Private Sub DeleteRecord()
            Try
                For Each dataGridViewRow As System.Windows.Forms.DataGridViewRow In CType(Me.DataGridView1.Rows, System.Collections.IEnumerable)
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select Dish from temp_Stock_Store where Dish=@d1")
                    RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((0))).Value))
                    RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                    If RestaurantPOS14.ModClasses.rdr.Read() Then
                        RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                        RestaurantPOS14.ModClasses.con.Open()
                        RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Update Temp_Stock_store set Qty=Qty - " & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((1))).Value))) & " where Dish=@d1")
                        RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((0))).Value))
                        RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                        RestaurantPOS14.ModClasses.con.Close()
                    End If
                Next

                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("delete from Stock_Store where ST_ID=@d1")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.Conversion.Val(Me.txtST_ID.Text))
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                If RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery() > 0 Then
                    RestaurantPOS14.ModFunc.LogFunc(Me.lblUser.Text, "deleted the item stock record having Stock ID '" & Me.txtST_ID.Text & "'")
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
            If Me.DataGridView1.Rows.Count = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Sorry no item info added to grid", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Return
            End If

            Try
                For Each dataGridViewRow As System.Windows.Forms.DataGridViewRow In CType(Me.DataGridView1.Rows, System.Collections.IEnumerable)
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select Dish from temp_Stock_Store where Dish=@d1")
                    RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((0))).Value))
                    RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                    If RestaurantPOS14.ModClasses.rdr.Read() Then
                        RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                        RestaurantPOS14.ModClasses.con.Open()
                        RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Update Temp_Stock_store set Qty=Qty + " & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((1))).Value))) & " where Dish=@d1")
                        RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((0))).Value))
                        RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                        RestaurantPOS14.ModClasses.con.Close()
                    Else
                        RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                        RestaurantPOS14.ModClasses.con.Open()
                        RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Insert Into Temp_Stock_Store(Dish,Qty) values (@d1,@d2)")
                        RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((0))).Value))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((1))).Value)))
                        RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                        RestaurantPOS14.ModClasses.con.Close()
                    End If
                Next

                Me.auto()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("insert into Stock_Store(ST_ID,Date,Remarks) VALUES (@d1,@d2,@d3)")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.Conversion.Val(Me.txtST_ID.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Me.dtpDate.Value.[Date])
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Me.txtRemarks.Text)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("insert into Stock_Store_Join(StockID,Dish,Qty) VALUES (" & RestaurantPOS14.Security.SqlInput.RequireInteger(Me.txtST_ID.Text, "Record ID") & ",@d1,@d2)")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Prepare()
                For Each dataGridViewRow2 As System.Windows.Forms.DataGridViewRow In CType(Me.DataGridView1.Rows, System.Collections.IEnumerable)
                    If Not dataGridViewRow2.IsNewRow Then
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(CInt((0))).Value))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(CInt((1))).Value)))
                        RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                        RestaurantPOS14.ModClasses.cmd.Parameters.Clear()
                    End If
                Next

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModFunc.LogFunc(Me.lblUser.Text, "added the new Item Stock having Stock ID '" & Me.txtST_ID.Text & "'")
                Call System.Windows.Forms.MessageBox.Show("Successfully saved", "Record", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                Me.btnSave.Enabled = False
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
            Call RestaurantPOS14.My.MyProject.Forms.frmStock_StoreRecord.Reset()
            RestaurantPOS14.My.MyProject.Forms.frmStock_StoreRecord.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmStock_StoreRecord.ShowDialog()
        End Sub

        Private Sub cmbProductName_Format(sender As Object, e As System.Windows.Forms.ListControlConvertEventArgs)
            If e.DesiredType Is GetType(String) Then
                e.Value = e.Value.ToString().Trim()
            End If
        End Sub

        Private Sub btnAdd_Click(sender As Object, e As System.EventArgs)
            Try
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.cmbItemName.Text, "", TextCompare:=False) = 0 Then
                    Call System.Windows.Forms.MessageBox.Show("Please select item name", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Me.cmbItemName.Focus()
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

                If Me.DataGridView1.Rows.Count = 0 Then
                    Me.DataGridView1.Rows.Add(Me.cmbItemName.Text, Microsoft.VisualBasic.Conversion.Val(Me.txtQty.Text))
                    Me.Clear()
                    Return
                End If

                For Each dataGridViewRow As System.Windows.Forms.DataGridViewRow In CType(Me.DataGridView1.Rows, System.Collections.IEnumerable)
                    If Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells(CInt((0))).Value, Me.cmbItemName.Text, TextCompare:=False) Then
                        dataGridViewRow.Cells(CInt((0))).Value = Me.cmbItemName.Text
                        dataGridViewRow.Cells(CInt((1))).Value = Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((1))).Value)) + Microsoft.VisualBasic.Conversion.Val(Me.txtQty.Text)
                        Me.Clear()
                        Return
                    End If
                Next

                Me.DataGridView1.Rows.Add(Me.cmbItemName.Text, Microsoft.VisualBasic.Conversion.Val(Me.txtQty.Text))
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

                Me.btnRemove.Enabled = False
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
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

        Public Sub fillItem()
            Try
                Dim sqlConnection As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                sqlConnection.Open()
                RestaurantPOS14.ModClasses.adp = New System.Data.SqlClient.SqlDataAdapter()
                RestaurantPOS14.ModClasses.adp.SelectCommand = New System.Data.SqlClient.SqlCommand("SELECT distinct RTRIM(DishName) FROM Dish order by 1", sqlConnection)
                RestaurantPOS14.ModClasses.ds = New System.Data.DataSet("ds")
                RestaurantPOS14.ModClasses.adp.Fill(RestaurantPOS14.ModClasses.ds)
                Dim dataTable As System.Data.DataTable = RestaurantPOS14.ModClasses.ds.Tables(0)
                Me.cmbItemName.Items.Clear()
                For Each dataRow As System.Data.DataRow In dataTable.Rows
                    Me.cmbItemName.Items.Add(dataRow(CInt((0))).ToString())
                Next
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub Button1_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmMenuItem.lblUser.Text = Me.lblUser.Text
            RestaurantPOS14.My.MyProject.Forms.frmMenuItem.lblSet.Text = "Stock"
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmStock_Store))
            Dim dataGridViewCellStyle As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.btnNew = New System.Windows.Forms.Button()
            Me.btnGetData = New System.Windows.Forms.Button()
            Me.btnSave = New System.Windows.Forms.Button()
            Me.btnDelete = New System.Windows.Forms.Button()
            Me.btnClose = New System.Windows.Forms.Button()
            Me.txtRemarks = New System.Windows.Forms.RichTextBox()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.DataGridView1 = New System.Windows.Forms.DataGridView()
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.btnRemove = New System.Windows.Forms.Button()
            Me.btnAdd = New System.Windows.Forms.Button()
            Me.cmbItemName = New System.Windows.Forms.ComboBox()
            Me.txtQty = New System.Windows.Forms.TextBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.dtpDate = New System.Windows.Forms.DateTimePicker()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtST_ID = New System.Windows.Forms.TextBox()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.lblUserType = New System.Windows.Forms.Label()
            Me.lblSet = New System.Windows.Forms.Label()
            Me.lblUser = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.Panel1.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox2.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            MyBase.SuspendLayout()
            Me.Panel1.BackColor = System.Drawing.Color.White
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.GroupBox3)
            Me.Panel1.Controls.Add(Me.btnClose)
            Me.Panel1.Controls.Add(Me.txtRemarks)
            Me.Panel1.Controls.Add(Me.Label12)
            Me.Panel1.Controls.Add(Me.DataGridView1)
            Me.Panel1.Controls.Add(Me.GroupBox2)
            Me.Panel1.Controls.Add(Me.GroupBox1)
            Me.Panel1.Controls.Add(Me.Panel2)
            Dim panel As System.Windows.Forms.Panel = Me.Panel1
            Dim location As System.Drawing.Point = New System.Drawing.Point(8, 7)
            panel.Location = location
            Me.Panel1.Name = "Panel1"
            Dim panel2 As System.Windows.Forms.Panel = Me.Panel1
            Dim size As System.Drawing.Size = New System.Drawing.Size(530, 647)
            panel2.Size = size
            Me.Panel1.TabIndex = 2
            Me.GroupBox3.Controls.Add(Me.btnNew)
            Me.GroupBox3.Controls.Add(Me.btnGetData)
            Me.GroupBox3.Controls.Add(Me.btnSave)
            Me.GroupBox3.Controls.Add(Me.btnDelete)
            Dim groupBox As System.Windows.Forms.GroupBox = Me.GroupBox3
            location = New System.Drawing.Point(414, 50)
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
            location = New System.Drawing.Point(446, 6)
            button9.Location = location
            Me.btnClose.Name = "btnClose"
            Dim button10 As System.Windows.Forms.Button = Me.btnClose
            size = New System.Drawing.Size(76, 38)
            button10.Size = size
            Me.btnClose.TabIndex = 313
            Me.btnClose.Text = "Close"
            Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnClose.UseVisualStyleBackColor = True
            Dim richTextBox As System.Windows.Forms.RichTextBox = Me.txtRemarks
            location = New System.Drawing.Point(9, 154)
            richTextBox.Location = location
            Me.txtRemarks.Name = "txtRemarks"
            Dim richTextBox2 As System.Windows.Forms.RichTextBox = Me.txtRemarks
            size = New System.Drawing.Size(390, 92)
            richTextBox2.Size = size
            Me.txtRemarks.TabIndex = 1
            Me.txtRemarks.Text = ""
            Me.Label12.AutoSize = True
            Dim label As System.Windows.Forms.Label = Me.Label12
            location = New System.Drawing.Point(8, 135)
            label.Location = location
            Me.Label12.Name = "Label12"
            Dim label2 As System.Windows.Forms.Label = Me.Label12
            size = New System.Drawing.Size(55, 13)
            label2.Size = size
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
            Me.DataGridView1.Columns.AddRange(Me.Column3, Me.Column4)
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
            location = New System.Drawing.Point(9, 377)
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
            size = New System.Drawing.Size(513, 263)
            dataGridView2.Size = size
            Me.DataGridView1.TabIndex = 5
            Me.Column3.HeaderText = "Item Name"
            Me.Column3.Name = "Column3"
            Me.Column3.[ReadOnly] = True
            Me.Column3.Width = 390
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.Column4.DefaultCellStyle = dataGridViewCellStyle6
            Me.Column4.HeaderText = "Qty."
            Me.Column4.Name = "Column4"
            Me.Column4.[ReadOnly] = True
            Me.Column4.Width = 94
            Me.GroupBox2.Controls.Add(Me.Button1)
            Me.GroupBox2.Controls.Add(Me.btnRemove)
            Me.GroupBox2.Controls.Add(Me.btnAdd)
            Me.GroupBox2.Controls.Add(Me.cmbItemName)
            Me.GroupBox2.Controls.Add(Me.txtQty)
            Me.GroupBox2.Controls.Add(Me.Label4)
            Me.GroupBox2.Controls.Add(Me.Label8)
            Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim groupBox3 As System.Windows.Forms.GroupBox = Me.GroupBox2
            location = New System.Drawing.Point(11, 252)
            groupBox3.Location = location
            Me.GroupBox2.Name = "GroupBox2"
            Dim groupBox4 As System.Windows.Forms.GroupBox = Me.GroupBox2
            size = New System.Drawing.Size(511, 119)
            groupBox4.Size = size
            Me.GroupBox2.TabIndex = 2
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Item Info"
            Me.btnRemove.Enabled = False
            Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnRemove.Image = CType(componentResourceManager.GetObject("btnRemove.Image"), System.Drawing.Image)
            Me.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button11 As System.Windows.Forms.Button = Me.btnRemove
            location = New System.Drawing.Point(411, 74)
            button11.Location = location
            Me.btnRemove.Name = "btnRemove"
            Dim button12 As System.Windows.Forms.Button = Me.btnRemove
            size = New System.Drawing.Size(90, 34)
            button12.Size = size
            Me.btnRemove.TabIndex = 3
            Me.btnRemove.Text = "&Remove"
            Me.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnRemove.UseVisualStyleBackColor = True
            Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnAdd.Image = CType(componentResourceManager.GetObject("btnAdd.Image"), System.Drawing.Image)
            Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button13 As System.Windows.Forms.Button = Me.btnAdd
            location = New System.Drawing.Point(411, 34)
            button13.Location = location
            Me.btnAdd.Name = "btnAdd"
            Dim button14 As System.Windows.Forms.Button = Me.btnAdd
            size = New System.Drawing.Size(67, 34)
            button14.Size = size
            Me.btnAdd.TabIndex = 2
            Me.btnAdd.Text = "&Add"
            Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnAdd.UseVisualStyleBackColor = True
            Me.cmbItemName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
            Me.cmbItemName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
            Me.cmbItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.cmbItemName.FormattingEnabled = True
            Dim comboBox As System.Windows.Forms.ComboBox = Me.cmbItemName
            location = New System.Drawing.Point(111, 34)
            comboBox.Location = location
            Me.cmbItemName.Name = "cmbItemName"
            Dim comboBox2 As System.Windows.Forms.ComboBox = Me.cmbItemName
            size = New System.Drawing.Size(257, 28)
            comboBox2.Size = size
            Me.cmbItemName.TabIndex = 0
            Me.txtQty.BackColor = System.Drawing.SystemColors.ButtonHighlight
            Me.txtQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox As System.Windows.Forms.TextBox = Me.txtQty
            location = New System.Drawing.Point(111, 68)
            textBox.Location = location
            Me.txtQty.Name = "txtQty"
            Dim textBox2 As System.Windows.Forms.TextBox = Me.txtQty
            size = New System.Drawing.Size(70, 26)
            textBox2.Size = size
            Me.txtQty.TabIndex = 1
            Me.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label3 As System.Windows.Forms.Label = Me.Label4
            location = New System.Drawing.Point(24, 68)
            label3.Location = location
            Me.Label4.Name = "Label4"
            Dim label4 As System.Windows.Forms.Label = Me.Label4
            size = New System.Drawing.Size(62, 16)
            label4.Size = size
            Me.Label4.TabIndex = 27
            Me.Label4.Text = "Quantity :"
            Me.Label8.AutoSize = True
            Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label5 As System.Windows.Forms.Label = Me.Label8
            location = New System.Drawing.Point(24, 34)
            label5.Location = location
            Me.Label8.Name = "Label8"
            Dim label6 As System.Windows.Forms.Label = Me.Label8
            size = New System.Drawing.Size(79, 16)
            label6.Size = size
            Me.Label8.TabIndex = 22
            Me.Label8.Text = "Item Name :"
            Me.GroupBox1.Controls.Add(Me.dtpDate)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.txtST_ID)
            Dim groupBox5 As System.Windows.Forms.GroupBox = Me.GroupBox1
            location = New System.Drawing.Point(9, 50)
            groupBox5.Location = location
            Me.GroupBox1.Name = "GroupBox1"
            Dim groupBox6 As System.Windows.Forms.GroupBox = Me.GroupBox1
            size = New System.Drawing.Size(242, 82)
            groupBox6.Size = size
            Me.GroupBox1.TabIndex = 0
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Invoice Info"
            Me.dtpDate.CustomFormat = "dd/MM/yyyy"
            Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Dim dateTimePicker As System.Windows.Forms.DateTimePicker = Me.dtpDate
            location = New System.Drawing.Point(109, 52)
            dateTimePicker.Location = location
            Me.dtpDate.Name = "dtpDate"
            Dim dateTimePicker2 As System.Windows.Forms.DateTimePicker = Me.dtpDate
            size = New System.Drawing.Size(124, 20)
            dateTimePicker2.Size = size
            Me.dtpDate.TabIndex = 1
            Me.Label3.AutoSize = True
            Dim label7 As System.Windows.Forms.Label = Me.Label3
            location = New System.Drawing.Point(11, 26)
            label7.Location = location
            Me.Label3.Name = "Label3"
            Dim label8 As System.Windows.Forms.Label = Me.Label3
            size = New System.Drawing.Size(55, 13)
            label8.Size = size
            Me.Label3.TabIndex = 0
            Me.Label3.Text = "Stock ID :"
            Me.Label2.AutoSize = True
            Dim label9 As System.Windows.Forms.Label = Me.Label2
            location = New System.Drawing.Point(12, 52)
            label9.Location = location
            Me.Label2.Name = "Label2"
            Dim label10 As System.Windows.Forms.Label = Me.Label2
            size = New System.Drawing.Size(36, 13)
            label10.Size = size
            Me.Label2.TabIndex = 5
            Me.Label2.Text = "Date :"
            Dim textBox3 As System.Windows.Forms.TextBox = Me.txtST_ID
            location = New System.Drawing.Point(109, 23)
            textBox3.Location = location
            Me.txtST_ID.Name = "txtST_ID"
            Me.txtST_ID.[ReadOnly] = True
            Dim textBox4 As System.Windows.Forms.TextBox = Me.txtST_ID
            size = New System.Drawing.Size(124, 20)
            textBox4.Size = size
            Me.txtST_ID.TabIndex = 0
            Me.Panel2.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Panel2.Controls.Add(Me.lblUserType)
            Me.Panel2.Controls.Add(Me.lblSet)
            Me.Panel2.Controls.Add(Me.lblUser)
            Me.Panel2.Controls.Add(Me.Label1)
            Dim panel3 As System.Windows.Forms.Panel = Me.Panel2
            location = New System.Drawing.Point(9, 7)
            panel3.Location = location
            Me.Panel2.Name = "Panel2"
            Dim panel4 As System.Windows.Forms.Panel = Me.Panel2
            size = New System.Drawing.Size(431, 37)
            panel4.Size = size
            Me.Panel2.TabIndex = 0
            Me.lblUserType.AutoSize = True
            Dim label11 As System.Windows.Forms.Label = Me.lblUserType
            location = New System.Drawing.Point(22, 6)
            label11.Location = location
            Me.lblUserType.Name = "lblUserType"
            Dim label12 As System.Windows.Forms.Label = Me.lblUserType
            size = New System.Drawing.Size(56, 13)
            label12.Size = size
            Me.lblUserType.TabIndex = 312
            Me.lblUserType.Text = "User Type"
            Me.lblUserType.Visible = False
            Me.lblSet.AutoSize = True
            Dim label13 As System.Windows.Forms.Label = Me.lblSet
            location = New System.Drawing.Point(187, 30)
            label13.Location = location
            Me.lblSet.Name = "lblSet"
            Dim label14 As System.Windows.Forms.Label = Me.lblSet
            size = New System.Drawing.Size(23, 13)
            label14.Size = size
            Me.lblSet.TabIndex = 311
            Me.lblSet.Text = "Set"
            Me.lblSet.Visible = False
            Me.lblUser.AutoSize = True
            Dim label15 As System.Windows.Forms.Label = Me.lblUser
            location = New System.Drawing.Point(142, 29)
            label15.Location = location
            Me.lblUser.Name = "lblUser"
            Dim label16 As System.Windows.Forms.Label = Me.lblUser
            size = New System.Drawing.Size(29, 13)
            label16.Size = size
            Me.lblUser.TabIndex = 6
            Me.lblUser.Text = "User"
            Me.lblUser.Visible = False
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label1.ForeColor = System.Drawing.Color.White
            Dim label17 As System.Windows.Forms.Label = Me.Label1
            location = New System.Drawing.Point(152, 6)
            label17.Location = location
            Me.Label1.Name = "Label1"
            Dim label18 As System.Windows.Forms.Label = Me.Label1
            size = New System.Drawing.Size(115, 24)
            label18.Size = size
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Stock Entry"
            Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.Button1.Image = RestaurantPOS14.My.Resources.Resources._1__2_
            Dim button15 As System.Windows.Forms.Button = Me.Button1
            location = New System.Drawing.Point(374, 34)
            button15.Location = location
            Me.Button1.Name = "Button1"
            Dim button16 As System.Windows.Forms.Button = Me.Button1
            size = New System.Drawing.Size(31, 28)
            button16.Size = size
            Me.Button1.TabIndex = 314
            Me.Button1.UseVisualStyleBackColor = True
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            size = New System.Drawing.Size(544, 660)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.Panel1)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MaximizeBox = False
            MyBase.MinimizeBox = False
            MyBase.Name = "frmStock_Store"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.GroupBox3.ResumeLayout(False)
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
