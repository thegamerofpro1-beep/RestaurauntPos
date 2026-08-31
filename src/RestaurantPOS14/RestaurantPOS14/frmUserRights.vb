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
Imports MetroFramework
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports RestaurantPOS14.My

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public Class frmUserRights
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label1")>
        Private _Label1 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnUpdate")>
        Private _btnUpdate As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnSave")>
        Private _btnSave As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnNew")>
        Private _btnNew As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox1")>
        Private _GroupBox1 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label3")>
        Private _Label3 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtUserType")>
        Private _txtUserType As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label2")>
        Private _Label2 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("cmbUserID")>
        Private _cmbUserID As System.Windows.Forms.ComboBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label4")>
        Private _Label4 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtName")>
        Private _txtName As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("dgw")>
        Private _dgw As System.Windows.Forms.DataGridView

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox2")>
        Private _GroupBox2 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnDelete")>
        Private _btnDelete As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column1")>
        Private _Column1 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("chkSave")>
        Private _chkSave As System.Windows.Forms.DataGridViewCheckBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("chkUpdate")>
        Private _chkUpdate As System.Windows.Forms.DataGridViewCheckBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("chkDelete")>
        Private _chkDelete As System.Windows.Forms.DataGridViewCheckBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("chkViewRecords")>
        Private _chkViewRecords As System.Windows.Forms.DataGridViewCheckBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column2")>
        Private _Column2 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblUser")>
        Private _lblUser As System.Windows.Forms.Label

        Private TotalCheckBoxes As Integer

        Private TotalCheckedCheckBoxes As Integer

        Private HeaderCheckBox1 As System.Windows.Forms.CheckBox

        Private HeaderCheckBox2 As System.Windows.Forms.CheckBox

        Private HeaderCheckBox3 As System.Windows.Forms.CheckBox

        Private HeaderCheckBox4 As System.Windows.Forms.CheckBox

        Private IsHeaderCheckBoxClicked As Boolean

        Private components As System.ComponentModel.IContainer

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

        Friend Overridable Property txtUserType As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtUserType
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtUserType = value
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

        Friend Overridable Property cmbUserID As System.Windows.Forms.ComboBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._cmbUserID
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ComboBox)
                Dim value2 As System.EventHandler = AddressOf Me.cmbUserID_SelectedIndexChanged
                If Me._cmbUserID IsNot Nothing Then
                    RemoveHandler Me._cmbUserID.SelectedIndexChanged, value2
                End If

                Me._cmbUserID = value
                If Me._cmbUserID IsNot Nothing Then
                    AddHandler Me._cmbUserID.SelectedIndexChanged, value2
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

        Friend Overridable Property dgw As System.Windows.Forms.DataGridView
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._dgw
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridView)
                Dim value2 As System.Windows.Forms.DataGridViewRowPostPaintEventHandler = AddressOf Me.dgw_RowPostPaint
                If Me._dgw IsNot Nothing Then
                    RemoveHandler Me._dgw.RowPostPaint, value2
                End If

                Me._dgw = value
                If Me._dgw IsNot Nothing Then
                    AddHandler Me._dgw.RowPostPaint, value2
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

        Friend Overridable Property chkSave As System.Windows.Forms.DataGridViewCheckBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._chkSave
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewCheckBoxColumn)
                Me._chkSave = value
            End Set
        End Property

        Friend Overridable Property chkUpdate As System.Windows.Forms.DataGridViewCheckBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._chkUpdate
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewCheckBoxColumn)
                Me._chkUpdate = value
            End Set
        End Property

        Friend Overridable Property chkDelete As System.Windows.Forms.DataGridViewCheckBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._chkDelete
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewCheckBoxColumn)
                Me._chkDelete = value
            End Set
        End Property

        Friend Overridable Property chkViewRecords As System.Windows.Forms.DataGridViewCheckBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._chkViewRecords
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewCheckBoxColumn)
                Me._chkViewRecords = value
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

        Public Sub New()
            AddHandler MyBase.FormClosing, AddressOf Me.frmUserRights_FormClosing
            AddHandler MyBase.Load, AddressOf Me.frmUserRights_Load
            Call RestaurantPOS14.frmUserRights.__ENCAddToList(Me)
            Me.TotalCheckBoxes = 0
            Me.TotalCheckedCheckBoxes = 0
            Me.HeaderCheckBox1 = Nothing
            Me.HeaderCheckBox2 = Nothing
            Me.HeaderCheckBox3 = Nothing
            Me.HeaderCheckBox4 = Nothing
            Me.IsHeaderCheckBoxClicked = False
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmUserRights.__ENCList
                If RestaurantPOS14.frmUserRights.__ENCList.Count = RestaurantPOS14.frmUserRights.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmUserRights.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmUserRights.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmUserRights.__ENCList(num) = RestaurantPOS14.frmUserRights.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmUserRights.__ENCList.RemoveRange(num, RestaurantPOS14.frmUserRights.__ENCList.Count - num)
                    RestaurantPOS14.frmUserRights.__ENCList.Capacity = RestaurantPOS14.frmUserRights.__ENCList.Count
                End If

                Call RestaurantPOS14.frmUserRights.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Private Sub HeaderCheckBoxClick1(HCheckBox As System.Windows.Forms.CheckBox)
            Me.IsHeaderCheckBoxClicked = True
            For Each item As System.Windows.Forms.DataGridViewRow In CType(Me.dgw.Rows, System.Collections.IEnumerable)
                CType(item.Cells(CStr(("chkSave"))), System.Windows.Forms.DataGridViewCheckBoxCell).Value = HCheckBox.Checked
            Next

            Me.dgw.RefreshEdit()
            Me.TotalCheckedCheckBoxes =(If(HCheckBox.Checked, Me.TotalCheckBoxes, 0))
            Me.IsHeaderCheckBoxClicked = False
        End Sub

        Private Sub HeaderCheckBoxClick2(HCheckBox As System.Windows.Forms.CheckBox)
            Me.IsHeaderCheckBoxClicked = True
            For Each item As System.Windows.Forms.DataGridViewRow In CType(Me.dgw.Rows, System.Collections.IEnumerable)
                CType(item.Cells(CStr(("chkUpdate"))), System.Windows.Forms.DataGridViewCheckBoxCell).Value = HCheckBox.Checked
            Next

            Me.dgw.RefreshEdit()
            Me.TotalCheckedCheckBoxes =(If(HCheckBox.Checked, Me.TotalCheckBoxes, 0))
            Me.IsHeaderCheckBoxClicked = False
        End Sub

        Private Sub HeaderCheckBoxClick3(HCheckBox As System.Windows.Forms.CheckBox)
            Me.IsHeaderCheckBoxClicked = True
            For Each item As System.Windows.Forms.DataGridViewRow In CType(Me.dgw.Rows, System.Collections.IEnumerable)
                CType(item.Cells(CStr(("chkDelete"))), System.Windows.Forms.DataGridViewCheckBoxCell).Value = HCheckBox.Checked
            Next

            Me.dgw.RefreshEdit()
            Me.TotalCheckedCheckBoxes =(If(HCheckBox.Checked, Me.TotalCheckBoxes, 0))
            Me.IsHeaderCheckBoxClicked = False
        End Sub

        Private Sub HeaderCheckBoxClick4(HCheckBox As System.Windows.Forms.CheckBox)
            Me.IsHeaderCheckBoxClicked = True
            For Each item As System.Windows.Forms.DataGridViewRow In CType(Me.dgw.Rows, System.Collections.IEnumerable)
                CType(item.Cells(CStr(("chkViewRecords"))), System.Windows.Forms.DataGridViewCheckBoxCell).Value = HCheckBox.Checked
            Next

            Me.dgw.RefreshEdit()
            Me.TotalCheckedCheckBoxes =(If(HCheckBox.Checked, Me.TotalCheckBoxes, 0))
            Me.IsHeaderCheckBoxClicked = False
        End Sub

        Private Sub AddHeaderCheckBox1()
            Me.HeaderCheckBox1 = New System.Windows.Forms.CheckBox()
            Dim headerCheckBox As System.Windows.Forms.CheckBox = Me.HeaderCheckBox1
            Dim size As System.Drawing.Size = New System.Drawing.Size(15, 15)
            headerCheckBox.Size = size
            Me.dgw.Controls.Add(Me.HeaderCheckBox1)
        End Sub

        Private Sub AddHeaderCheckBox2()
            Me.HeaderCheckBox2 = New System.Windows.Forms.CheckBox()
            Dim headerCheckBox As System.Windows.Forms.CheckBox = Me.HeaderCheckBox2
            Dim size As System.Drawing.Size = New System.Drawing.Size(15, 15)
            headerCheckBox.Size = size
            Me.dgw.Controls.Add(Me.HeaderCheckBox2)
        End Sub

        Private Sub AddHeaderCheckBox3()
            Me.HeaderCheckBox3 = New System.Windows.Forms.CheckBox()
            Dim headerCheckBox As System.Windows.Forms.CheckBox = Me.HeaderCheckBox3
            Dim size As System.Drawing.Size = New System.Drawing.Size(15, 15)
            headerCheckBox.Size = size
            Me.dgw.Controls.Add(Me.HeaderCheckBox3)
        End Sub

        Private Sub AddHeaderCheckBox4()
            Me.HeaderCheckBox4 = New System.Windows.Forms.CheckBox()
            Dim headerCheckBox As System.Windows.Forms.CheckBox = Me.HeaderCheckBox4
            Dim size As System.Drawing.Size = New System.Drawing.Size(15, 15)
            headerCheckBox.Size = size
            Me.dgw.Controls.Add(Me.HeaderCheckBox4)
        End Sub

        Private Sub dgw_CurrentCellDirtyStateChanged(sender As Object, e As System.EventArgs)
            If TypeOf Me.dgw.CurrentCell Is System.Windows.Forms.DataGridViewCheckBoxCell Then
                Me.dgw.CommitEdit(System.Windows.Forms.DataGridViewDataErrorContexts.Commit)
            End If
        End Sub

        Private Sub HeaderCheckBox1_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs)
            Me.HeaderCheckBoxClick1(CType(sender, System.Windows.Forms.CheckBox))
        End Sub

        Private Sub HeaderCheckBox1_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs)
            If e.KeyCode = System.Windows.Forms.Keys.Space Then
                Me.HeaderCheckBoxClick1(CType(sender, System.Windows.Forms.CheckBox))
            End If
        End Sub

        Private Sub HeaderCheckBox2_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs)
            Me.HeaderCheckBoxClick2(CType(sender, System.Windows.Forms.CheckBox))
        End Sub

        Private Sub HeaderCheckBox2_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs)
            If e.KeyCode = System.Windows.Forms.Keys.Space Then
                Me.HeaderCheckBoxClick2(CType(sender, System.Windows.Forms.CheckBox))
            End If
        End Sub

        Private Sub frmUserRights_Load(sender As Object, e As System.EventArgs)
            Try
                Me.AddHeaderCheckBox3()
                Me.AddHeaderCheckBox1()
                Me.AddHeaderCheckBox2()
                Me.AddHeaderCheckBox4()
                AddHandler Me.dgw.CurrentCellDirtyStateChanged, AddressOf Me.dgw_CurrentCellDirtyStateChanged
                AddHandler Me.HeaderCheckBox1.KeyUp, AddressOf Me.HeaderCheckBox1_KeyUp
                AddHandler Me.HeaderCheckBox1.MouseClick, AddressOf Me.HeaderCheckBox1_MouseClick
                AddHandler Me.HeaderCheckBox2.KeyUp, AddressOf Me.HeaderCheckBox2_KeyUp
                AddHandler Me.HeaderCheckBox2.MouseClick, AddressOf Me.HeaderCheckBox2_MouseClick
                AddHandler Me.HeaderCheckBox3.KeyUp, AddressOf Me.HeaderCheckBox3_KeyUp
                AddHandler Me.HeaderCheckBox3.MouseClick, AddressOf Me.HeaderCheckBox3_MouseClick
                AddHandler Me.HeaderCheckBox4.KeyUp, AddressOf Me.HeaderCheckBox4_KeyUp
                AddHandler Me.HeaderCheckBox4.MouseClick, AddressOf Me.HeaderCheckBox4_MouseClick
                AddHandler Me.dgw.CellPainting, AddressOf Me.dgw_CellPainting
                Me.dgw.Rows.Clear()
                Me.AddForms()
                Me.fillUserID()
                Me.cmbUserID.SelectedIndex = -1
                Me.txtUserType.Text = ""
                Me.txtName.Text = ""
                Me.dgw.ClearSelection()
            Catch ex As System.Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub fillUserID()
            Try
                Dim sqlConnection As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                sqlConnection.Open()
                RestaurantPOS14.ModClasses.adp = New System.Data.SqlClient.SqlDataAdapter()
                RestaurantPOS14.ModClasses.adp.SelectCommand = New System.Data.SqlClient.SqlCommand("SELECT RTRIM(UserID) FROM Registration where UserType not in('Kitchen User','Waiter') and Active='Yes' order by 1", sqlConnection)
                RestaurantPOS14.ModClasses.ds = New System.Data.DataSet("ds")
                RestaurantPOS14.ModClasses.adp.Fill(RestaurantPOS14.ModClasses.ds)
                Dim dataTable As System.Data.DataTable = RestaurantPOS14.ModClasses.ds.Tables(0)
                Me.cmbUserID.Items.Clear()
                For Each dataRow As System.Data.DataRow In dataTable.Rows
                    Me.cmbUserID.Items.Add(dataRow(CInt((0))).ToString())
                Next

                sqlConnection.Close()
            Catch ex As System.Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub AddForms()
            Me.dgw.Rows.Add("Restaurant Master")
            Me.dgw.Rows.Add("Settings")
            Me.dgw.Rows.Add("Database")
            Me.dgw.Rows.Add("Kitchen/Section")
            Me.dgw.Rows.Add("Categories")
            Me.dgw.Rows.Add("Menu Items")
            Me.dgw.Rows.Add("Modifiers")
            Me.dgw.Rows.Add("Pizza")
            Me.dgw.Rows.Add("Items Stock")
            Me.dgw.Rows.Add("Tables")
            Me.dgw.Rows.Add("Loyalty Card")
            Me.dgw.Rows.Add("VIP Member Card")
            Me.dgw.Rows.Add("Gift Card")
            Me.dgw.Rows.Add("Payroll")
            Me.dgw.Rows.Add("Credit Customer")
            Me.dgw.Rows.Add("Raw Materials")
            Me.dgw.Rows.Add("Supplier")
            Me.dgw.Rows.Add("Purchase Order")
            Me.dgw.Rows.Add("Purchase Entry")
            Me.dgw.Rows.Add("Payment")
            Me.dgw.Rows.Add("Banking")
            Me.dgw.Rows.Add("Stock Transfer")
            Me.dgw.Rows.Add("Stock Adjustment")
            Me.dgw.Rows.Add("Voucher")
            Me.dgw.Rows.Add("Home Delivery")
            Me.dgw.Rows.Add("Recipe")
            Me.dgw.Rows.Add("Send SMS")
            Me.dgw.Rows.Add("Send Email")
            Me.dgw.Rows.Add("POS Report")
            Me.dgw.Rows.Add("Work Period Report")
            Me.dgw.Rows.Add("Accounting Report")
            Me.dgw.Rows.Add("Change Price(POS)")
            Me.dgw.Rows.Add("Bill Discount(POS)")
        End Sub

        Private Sub dgw_CellPainting(sender As Object, e As System.Windows.Forms.DataGridViewCellPaintingEventArgs)
            If e.RowIndex = -1 AndAlso e.ColumnIndex = 1 Then
                Me.ResetHeaderCheckBoxLocation1(e.ColumnIndex, e.RowIndex)
            End If

            If e.RowIndex = -1 AndAlso e.ColumnIndex = 2 Then
                Me.ResetHeaderCheckBoxLocation2(e.ColumnIndex, e.RowIndex)
            End If

            If e.RowIndex = -1 AndAlso e.ColumnIndex = 3 Then
                Me.ResetHeaderCheckBoxLocation3(e.ColumnIndex, e.RowIndex)
            End If

            If e.RowIndex = -1 AndAlso e.ColumnIndex = 4 Then
                Me.ResetHeaderCheckBoxLocation4(e.ColumnIndex, e.RowIndex)
            End If
        End Sub

        Private Sub HeaderCheckBox3_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs)
            Me.HeaderCheckBoxClick3(CType(sender, System.Windows.Forms.CheckBox))
        End Sub

        Private Sub HeaderCheckBox3_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs)
            If e.KeyCode = System.Windows.Forms.Keys.Space Then
                Me.HeaderCheckBoxClick3(CType(sender, System.Windows.Forms.CheckBox))
            End If
        End Sub

        Private Sub HeaderCheckBox4_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs)
            Me.HeaderCheckBoxClick4(CType(sender, System.Windows.Forms.CheckBox))
        End Sub

        Private Sub HeaderCheckBox4_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs)
            If e.KeyCode = System.Windows.Forms.Keys.Space Then
                Me.HeaderCheckBoxClick4(CType(sender, System.Windows.Forms.CheckBox))
            End If
        End Sub

        Private Sub ResetHeaderCheckBoxLocation1(ColumnIndex As Integer, RowIndex As Integer)
            Dim cellDisplayRectangle As System.Drawing.Rectangle = Me.dgw.GetCellDisplayRectangle(ColumnIndex, RowIndex, cutOverflow:=True)
            Dim location As System.Drawing.Point = New System.Drawing.Point With {.X = CInt(System.Math.Round(CDbl(cellDisplayRectangle.Location.X) + CDbl((cellDisplayRectangle.Width - Me.HeaderCheckBox1.Width)) / 2.0 + 1.0)), .Y = CInt(System.Math.Round(CDbl(cellDisplayRectangle.Location.Y) + CDbl((cellDisplayRectangle.Height - Me.HeaderCheckBox1.Height)) / 2.0 + 1.0))}
            Me.HeaderCheckBox1.Location = location
        End Sub

        Private Sub ResetHeaderCheckBoxLocation2(ColumnIndex As Integer, RowIndex As Integer)
            Dim cellDisplayRectangle As System.Drawing.Rectangle = Me.dgw.GetCellDisplayRectangle(ColumnIndex, RowIndex, cutOverflow:=True)
            Dim location As System.Drawing.Point = New System.Drawing.Point With {.X = CInt(System.Math.Round(CDbl(cellDisplayRectangle.Location.X) + CDbl((cellDisplayRectangle.Width - Me.HeaderCheckBox2.Width)) / 2.0 + 1.0)), .Y = CInt(System.Math.Round(CDbl(cellDisplayRectangle.Location.Y) + CDbl((cellDisplayRectangle.Height - Me.HeaderCheckBox2.Height)) / 2.0 + 1.0))}
            Me.HeaderCheckBox2.Location = location
        End Sub

        Private Sub ResetHeaderCheckBoxLocation3(ColumnIndex As Integer, RowIndex As Integer)
            Dim cellDisplayRectangle As System.Drawing.Rectangle = Me.dgw.GetCellDisplayRectangle(ColumnIndex, RowIndex, cutOverflow:=True)
            Dim location As System.Drawing.Point = New System.Drawing.Point With {.X = CInt(System.Math.Round(CDbl(cellDisplayRectangle.Location.X) + CDbl((cellDisplayRectangle.Width - Me.HeaderCheckBox3.Width)) / 2.0 + 1.0)), .Y = CInt(System.Math.Round(CDbl(cellDisplayRectangle.Location.Y) + CDbl((cellDisplayRectangle.Height - Me.HeaderCheckBox3.Height)) / 2.0 + 1.0))}
            Me.HeaderCheckBox3.Location = location
        End Sub

        Private Sub ResetHeaderCheckBoxLocation4(ColumnIndex As Integer, RowIndex As Integer)
            Dim cellDisplayRectangle As System.Drawing.Rectangle = Me.dgw.GetCellDisplayRectangle(ColumnIndex, RowIndex, cutOverflow:=True)
            Dim location As System.Drawing.Point = New System.Drawing.Point With {.X = CInt(System.Math.Round(CDbl(cellDisplayRectangle.Location.X) + CDbl((cellDisplayRectangle.Width - Me.HeaderCheckBox3.Width)) / 2.0 + 1.0)), .Y = CInt(System.Math.Round(CDbl(cellDisplayRectangle.Location.Y) + CDbl((cellDisplayRectangle.Height - Me.HeaderCheckBox3.Height)) / 2.0 + 1.0))}
            Me.HeaderCheckBox4.Location = location
        End Sub

        Public Sub Reset()
            Me.dgw.Rows.Clear()
            Me.AddForms()
            Me.HeaderCheckBox1.Checked = False
            Me.HeaderCheckBox2.Checked = False
            Me.HeaderCheckBox3.Checked = False
            Me.HeaderCheckBox4.Checked = False
            Me.btnUpdate.Enabled = False
            Me.btnDelete.Enabled = False
            Me.btnSave.Enabled = True
            Me.dgw.ClearSelection()
            Me.cmbUserID.SelectedIndex = -1
            Me.txtUserType.Text = ""
            Me.txtName.Text = ""
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
            If e.RowIndex = 1 Then
                Dim dataGridViewCell As System.Windows.Forms.DataGridViewCell = Me.dgw.Rows(CInt((28))).Cells(1)
                Dim obj As System.Windows.Forms.DataGridViewCheckBoxCell = TryCast(dataGridViewCell, System.Windows.Forms.DataGridViewCheckBoxCell)
                obj.Value = False
                obj.FlatStyle = System.Windows.Forms.FlatStyle.Flat
                obj.Style.ForeColor = System.Drawing.Color.LightSeaGreen
                dataGridViewCell.[ReadOnly] = True
                Dim dataGridViewCell2 As System.Windows.Forms.DataGridViewCell = Me.dgw.Rows(CInt((29))).Cells(1)
                Dim obj2 As System.Windows.Forms.DataGridViewCheckBoxCell = TryCast(dataGridViewCell2, System.Windows.Forms.DataGridViewCheckBoxCell)
                obj2.Value = False
                obj2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
                obj2.Style.ForeColor = System.Drawing.Color.LightSeaGreen
                dataGridViewCell2.[ReadOnly] = True
                Dim dataGridViewCell3 As System.Windows.Forms.DataGridViewCell = Me.dgw.Rows(CInt((30))).Cells(1)
                Dim obj3 As System.Windows.Forms.DataGridViewCheckBoxCell = TryCast(dataGridViewCell3, System.Windows.Forms.DataGridViewCheckBoxCell)
                obj3.Value = False
                obj3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
                obj3.Style.ForeColor = System.Drawing.Color.LightSeaGreen
                dataGridViewCell3.[ReadOnly] = True
            End If

            If e.RowIndex = 2 Then
                Dim dataGridViewCell4 As System.Windows.Forms.DataGridViewCell = Me.dgw.Rows(CInt((28))).Cells(2)
                Dim obj4 As System.Windows.Forms.DataGridViewCheckBoxCell = TryCast(dataGridViewCell4, System.Windows.Forms.DataGridViewCheckBoxCell)
                obj4.Value = False
                obj4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
                obj4.Style.ForeColor = System.Drawing.Color.LightSeaGreen
                dataGridViewCell4.[ReadOnly] = True
                Dim dataGridViewCell5 As System.Windows.Forms.DataGridViewCell = Me.dgw.Rows(CInt((29))).Cells(2)
                Dim obj5 As System.Windows.Forms.DataGridViewCheckBoxCell = TryCast(dataGridViewCell5, System.Windows.Forms.DataGridViewCheckBoxCell)
                obj5.Value = False
                obj5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
                obj5.Style.ForeColor = System.Drawing.Color.LightSeaGreen
                dataGridViewCell5.[ReadOnly] = True
                Dim dataGridViewCell6 As System.Windows.Forms.DataGridViewCell = Me.dgw.Rows(CInt((30))).Cells(2)
                Dim obj6 As System.Windows.Forms.DataGridViewCheckBoxCell = TryCast(dataGridViewCell6, System.Windows.Forms.DataGridViewCheckBoxCell)
                obj6.Value = False
                obj6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
                obj6.Style.ForeColor = System.Drawing.Color.LightSeaGreen
                dataGridViewCell6.[ReadOnly] = True
                Dim dataGridViewCell7 As System.Windows.Forms.DataGridViewCell = Me.dgw.Rows(CInt((31))).Cells(2)
                Dim obj7 As System.Windows.Forms.DataGridViewCheckBoxCell = TryCast(dataGridViewCell7, System.Windows.Forms.DataGridViewCheckBoxCell)
                obj7.Value = False
                obj7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
                obj7.Style.ForeColor = System.Drawing.Color.LightSeaGreen
                dataGridViewCell7.[ReadOnly] = True
                Dim dataGridViewCell8 As System.Windows.Forms.DataGridViewCell = Me.dgw.Rows(CInt((32))).Cells(2)
                Dim obj8 As System.Windows.Forms.DataGridViewCheckBoxCell = TryCast(dataGridViewCell8, System.Windows.Forms.DataGridViewCheckBoxCell)
                obj8.Value = False
                obj8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
                obj8.Style.ForeColor = System.Drawing.Color.LightSeaGreen
                dataGridViewCell8.[ReadOnly] = True
                Dim dataGridViewCell9 As System.Windows.Forms.DataGridViewCell = Me.dgw.Rows(CInt((26))).Cells(2)
                Dim obj9 As System.Windows.Forms.DataGridViewCheckBoxCell = TryCast(dataGridViewCell9, System.Windows.Forms.DataGridViewCheckBoxCell)
                obj9.Value = False
                obj9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
                obj9.Style.ForeColor = System.Drawing.Color.LightSeaGreen
                dataGridViewCell9.[ReadOnly] = True
                Dim dataGridViewCell10 As System.Windows.Forms.DataGridViewCell = Me.dgw.Rows(CInt((27))).Cells(2)
                Dim obj10 As System.Windows.Forms.DataGridViewCheckBoxCell = TryCast(dataGridViewCell10, System.Windows.Forms.DataGridViewCheckBoxCell)
                obj10.Value = False
                obj10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
                obj10.Style.ForeColor = System.Drawing.Color.LightSeaGreen
                dataGridViewCell10.[ReadOnly] = True
            End If

            If e.RowIndex = 3 Then
                Dim dataGridViewCell11 As System.Windows.Forms.DataGridViewCell = Me.dgw.Rows(CInt((28))).Cells(3)
                Dim obj11 As System.Windows.Forms.DataGridViewCheckBoxCell = TryCast(dataGridViewCell11, System.Windows.Forms.DataGridViewCheckBoxCell)
                obj11.Value = False
                obj11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
                obj11.Style.ForeColor = System.Drawing.Color.LightSeaGreen
                dataGridViewCell11.[ReadOnly] = True
                Dim dataGridViewCell12 As System.Windows.Forms.DataGridViewCell = Me.dgw.Rows(CInt((29))).Cells(3)
                Dim obj12 As System.Windows.Forms.DataGridViewCheckBoxCell = TryCast(dataGridViewCell12, System.Windows.Forms.DataGridViewCheckBoxCell)
                obj12.Value = False
                obj12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
                obj12.Style.ForeColor = System.Drawing.Color.LightSeaGreen
                dataGridViewCell12.[ReadOnly] = True
                Dim dataGridViewCell13 As System.Windows.Forms.DataGridViewCell = Me.dgw.Rows(CInt((30))).Cells(3)
                Dim obj13 As System.Windows.Forms.DataGridViewCheckBoxCell = TryCast(dataGridViewCell13, System.Windows.Forms.DataGridViewCheckBoxCell)
                obj13.Value = False
                obj13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
                obj13.Style.ForeColor = System.Drawing.Color.LightSeaGreen
                dataGridViewCell13.[ReadOnly] = True
                Dim dataGridViewCell14 As System.Windows.Forms.DataGridViewCell = Me.dgw.Rows(CInt((31))).Cells(3)
                Dim obj14 As System.Windows.Forms.DataGridViewCheckBoxCell = TryCast(dataGridViewCell14, System.Windows.Forms.DataGridViewCheckBoxCell)
                obj14.Value = False
                obj14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
                obj14.Style.ForeColor = System.Drawing.Color.LightSeaGreen
                dataGridViewCell14.[ReadOnly] = True
                Dim dataGridViewCell15 As System.Windows.Forms.DataGridViewCell = Me.dgw.Rows(CInt((32))).Cells(3)
                Dim obj15 As System.Windows.Forms.DataGridViewCheckBoxCell = TryCast(dataGridViewCell15, System.Windows.Forms.DataGridViewCheckBoxCell)
                obj15.Value = False
                obj15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
                obj15.Style.ForeColor = System.Drawing.Color.LightSeaGreen
                dataGridViewCell15.[ReadOnly] = True
                Dim dataGridViewCell16 As System.Windows.Forms.DataGridViewCell = Me.dgw.Rows(CInt((26))).Cells(3)
                Dim obj16 As System.Windows.Forms.DataGridViewCheckBoxCell = TryCast(dataGridViewCell16, System.Windows.Forms.DataGridViewCheckBoxCell)
                obj16.Value = False
                obj16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
                obj16.Style.ForeColor = System.Drawing.Color.LightSeaGreen
                dataGridViewCell16.[ReadOnly] = True
                Dim dataGridViewCell17 As System.Windows.Forms.DataGridViewCell = Me.dgw.Rows(CInt((27))).Cells(3)
                Dim obj17 As System.Windows.Forms.DataGridViewCheckBoxCell = TryCast(dataGridViewCell17, System.Windows.Forms.DataGridViewCheckBoxCell)
                obj17.Value = False
                obj17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
                obj17.Style.ForeColor = System.Drawing.Color.LightSeaGreen
                dataGridViewCell17.[ReadOnly] = True
            End If

            If e.RowIndex = 4 Then
                Dim dataGridViewCell18 As System.Windows.Forms.DataGridViewCell = Me.dgw.Rows(CInt((31))).Cells(4)
                Dim obj18 As System.Windows.Forms.DataGridViewCheckBoxCell = TryCast(dataGridViewCell18, System.Windows.Forms.DataGridViewCheckBoxCell)
                obj18.Value = False
                obj18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
                obj18.Style.ForeColor = System.Drawing.Color.LightSeaGreen
                dataGridViewCell18.[ReadOnly] = True
                Dim dataGridViewCell19 As System.Windows.Forms.DataGridViewCell = Me.dgw.Rows(CInt((32))).Cells(4)
                Dim obj19 As System.Windows.Forms.DataGridViewCheckBoxCell = TryCast(dataGridViewCell19, System.Windows.Forms.DataGridViewCheckBoxCell)
                obj19.Value = False
                obj19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
                obj19.Style.ForeColor = System.Drawing.Color.LightSeaGreen
                dataGridViewCell19.[ReadOnly] = True
                Dim dataGridViewCell20 As System.Windows.Forms.DataGridViewCell = Me.dgw.Rows(CInt((26))).Cells(4)
                Dim obj20 As System.Windows.Forms.DataGridViewCheckBoxCell = TryCast(dataGridViewCell20, System.Windows.Forms.DataGridViewCheckBoxCell)
                obj20.Value = False
                obj20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
                obj20.Style.ForeColor = System.Drawing.Color.LightSeaGreen
                dataGridViewCell20.[ReadOnly] = True
                Dim dataGridViewCell21 As System.Windows.Forms.DataGridViewCell = Me.dgw.Rows(CInt((27))).Cells(4)
                Dim obj21 As System.Windows.Forms.DataGridViewCheckBoxCell = TryCast(dataGridViewCell21, System.Windows.Forms.DataGridViewCheckBoxCell)
                obj21.Value = False
                obj21.FlatStyle = System.Windows.Forms.FlatStyle.Flat
                obj21.Style.ForeColor = System.Drawing.Color.LightSeaGreen
                dataGridViewCell21.[ReadOnly] = True
            End If
        End Sub

        Private Sub cmbUserID_SelectedIndexChanged(sender As Object, e As System.EventArgs)
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = RestaurantPOS14.ModClasses.con.CreateCommand()
                RestaurantPOS14.ModClasses.cmd.CommandText = "SELECT RTRIM(UserType),RTRIM(Name) FROM Registration WHERE UserID=@d1"
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.cmbUserID.Text)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.txtUserType.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                    Me.txtName.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(1))
                End If

                If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                    RestaurantPOS14.ModClasses.rdr.Close()
                End If

                If RestaurantPOS14.ModClasses.con.State = System.Data.ConnectionState.Open Then
                    RestaurantPOS14.ModClasses.con.Close()
                End If

                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = RestaurantPOS14.ModClasses.con.CreateCommand()
                RestaurantPOS14.ModClasses.cmd.CommandText = "SELECT RTRIM(ModuleName),UR_Save,UR_Update,UR_Delete,UR_View,ID FROM UserRights WHERE UserID=@d1"
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.cmbUserID.Text)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                Me.dgw.Rows.Clear()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.LoadData()
                Else
                    Me.AddForms()
                End If

                If RestaurantPOS14.ModClasses.con.State = System.Data.ConnectionState.Open Then
                    RestaurantPOS14.ModClasses.con.Close()
                End If
            Catch ex As System.Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub LoadData()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = RestaurantPOS14.ModClasses.con.CreateCommand()
                RestaurantPOS14.ModClasses.cmd.CommandText = "SELECT RTRIM(ModuleName),UR_Save,UR_Update,UR_Delete,UR_View,ID FROM UserRights WHERE UserID=@d1 order by ID"
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.cmbUserID.Text)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                Me.dgw.Rows.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Me.btnUpdate.Enabled = True
                    Me.btnDelete.Enabled = True
                    Me.btnSave.Enabled = False
                    Me.dgw.Rows.Add(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(0)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(1)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(2)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(3)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(4)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(5)))
                End While

                If RestaurantPOS14.ModClasses.con.State = System.Data.ConnectionState.Open Then
                    RestaurantPOS14.ModClasses.con.Close()
                End If
            Catch ex As System.Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnSave_Click(sender As Object, e As System.EventArgs)
            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.cmbUserID.Text, "", TextCompare:=False) = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "Please select user id", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.cmbUserID.Focus()
                Return
            End If

            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select userid from UserRights where userid=@d1")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.cmbUserID.Text)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    MetroFramework.MetroMessageBox.Show(Me, "Record Already Exists", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                RestaurantPOS14.ModClasses.con.Close()
                For Each dataGridViewRow As System.Windows.Forms.DataGridViewRow In CType(Me.dgw.Rows, System.Collections.IEnumerable)
                    If Not dataGridViewRow.IsNewRow Then
                        RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                        RestaurantPOS14.ModClasses.con.Open()
                        RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("insert into UserRights(ModuleName,UR_Save,UR_Update,UR_Delete,UR_View,UserID) VALUES (@d1,@d2,@d3,@d4,@d5,@d6)")
                        RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                        RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((0))).Value))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", System.Convert.ToBoolean(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((1))).Value)))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", System.Convert.ToBoolean(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((2))).Value)))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", System.Convert.ToBoolean(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((3))).Value)))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d5", System.Convert.ToBoolean(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((4))).Value)))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d6", Me.cmbUserID.Text)
                        RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                        RestaurantPOS14.ModClasses.cmd.Parameters.Clear()
                    End If
                Next

                RestaurantPOS14.ModClasses.con.Close()
                MetroFramework.MetroMessageBox.Show(Me, "Successfully granted", "User Rights", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                Me.Check()
                Me.Reset()
            Catch ex As System.Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnUpdate_Click(sender As Object, e As System.EventArgs)
            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.cmbUserID.Text, "", TextCompare:=False) = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "Please select user id", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.cmbUserID.Focus()
                Return
            End If

            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Update UserRights set ModuleName=@d1,UR_Save=@d2,UR_Update=@d3,UR_Delete=@d4,UR_View=@d5 where ID=@d6")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.cmd.Prepare()
                For Each dataGridViewRow As System.Windows.Forms.DataGridViewRow In CType(Me.dgw.Rows, System.Collections.IEnumerable)
                    If Not dataGridViewRow.IsNewRow Then
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((0))).Value))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", System.Convert.ToBoolean(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((1))).Value)))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", System.Convert.ToBoolean(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((2))).Value)))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", System.Convert.ToBoolean(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((3))).Value)))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d5", System.Convert.ToBoolean(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((4))).Value)))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d6", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((5))).Value)))
                        RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                        RestaurantPOS14.ModClasses.cmd.Parameters.Clear()
                    End If
                Next

                RestaurantPOS14.ModClasses.con.Close()
                MetroFramework.MetroMessageBox.Show(Me, "Successfully Updated", "User Rights", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                Me.Check()
                Me.Reset()
                Me.Reset()
            Catch ex As System.Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnDelete_Click(sender As Object, e As System.EventArgs)
            Try
                If MetroFramework.MetroMessageBox.Show(Me, "Do you really want to delete this record?", "Confirmation", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Exclamation) = System.Windows.Forms.DialogResult.Yes Then
                    Me.DeleteRecord()
                End If
            Catch ex As System.Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub DeleteRecord()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("delete from UserRights where UserID=@d1")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.cmbUserID.Text)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                If RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery() > 0 Then
                    MetroFramework.MetroMessageBox.Show(Me, "Successfully deleted", "Record", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    Me.Reset()
                    Me.Reset()
                    Me.Check()
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

        Public Sub Check()
            If RestaurantPOS14.ModFunc.IsViewAllowed(Me.lblUser.Text, "POS Report") Then
                RestaurantPOS14.My.MyProject.Forms.frmBackOffice.btnPOSReport.Enabled = True
            Else
                RestaurantPOS14.My.MyProject.Forms.frmBackOffice.btnPOSReport.Enabled = False
            End If

            If RestaurantPOS14.ModFunc.IsViewAllowed(Me.lblUser.Text, "Work Period Report") Then
                RestaurantPOS14.My.MyProject.Forms.frmBackOffice.btnWorkPeriodReport.Enabled = True
            Else
                RestaurantPOS14.My.MyProject.Forms.frmBackOffice.btnWorkPeriodReport.Enabled = False
            End If

            If RestaurantPOS14.ModFunc.IsViewAllowed(Me.lblUser.Text, "Accounting Report") Then
                RestaurantPOS14.My.MyProject.Forms.frmBackOffice.btnAccountingReports.Enabled = True
            Else
                RestaurantPOS14.My.MyProject.Forms.frmBackOffice.btnAccountingReports.Enabled = False
            End If
        End Sub

        Private Sub frmUserRights_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs)
            Me.Check()
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
            Dim dataGridViewCellStyle As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmUserRights))
            Me.Label1 = New System.Windows.Forms.Label()
            Me.dgw = New System.Windows.Forms.DataGridView()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.chkSave = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.chkUpdate = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.chkDelete = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.chkViewRecords = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtName = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtUserType = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.cmbUserID = New System.Windows.Forms.ComboBox()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.lblUser = New System.Windows.Forms.Label()
            Me.btnDelete = New System.Windows.Forms.Button()
            Me.btnNew = New System.Windows.Forms.Button()
            Me.btnSave = New System.Windows.Forms.Button()
            Me.btnUpdate = New System.Windows.Forms.Button()
            CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            MyBase.SuspendLayout()
            Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.Label1.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Dim label As System.Windows.Forms.Label = Me.Label1
            Dim location As System.Drawing.Point = New System.Drawing.Point(-2, -1)
            label.Location = location
            Me.Label1.Name = "Label1"
            Dim label2 As System.Windows.Forms.Label = Me.Label1
            Dim size As System.Drawing.Size = New System.Drawing.Size(996, 34)
            label2.Size = size
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "User Rights Management"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.dgw.AllowUserToAddRows = False
            Me.dgw.AllowUserToDeleteRows = False
            dataGridViewCellStyle.BackColor = System.Drawing.Color.FloralWhite
            Me.dgw.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle
            Me.dgw.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.dgw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            Me.dgw.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
            Me.dgw.BackgroundColor = System.Drawing.Color.White
            Me.dgw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            dataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgw.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2
            Me.dgw.ColumnHeadersHeight = 24
            Me.dgw.Columns.AddRange(Me.Column1, Me.chkSave, Me.chkUpdate, Me.chkDelete, Me.chkViewRecords, Me.Column2)
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
            location = New System.Drawing.Point(7, 122)
            dataGridView.Location = location
            Me.dgw.MultiSelect = False
            Me.dgw.Name = "dgw"
            Me.dgw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White
            dataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Moccasin
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgw.RowHeadersDefaultCellStyle = dataGridViewCellStyle4
            Me.dgw.RowHeadersWidth = 25
            Me.dgw.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White
            dataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Moccasin
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
            Me.dgw.RowsDefaultCellStyle = dataGridViewCellStyle5
            Me.dgw.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgw.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Dim dataGridView2 As System.Windows.Forms.DataGridView = Me.dgw
            size = New System.Drawing.Size(977, 489)
            dataGridView2.Size = size
            Me.dgw.TabIndex = 41
            Me.Column1.FillWeight = 220.1257F
            Me.Column1.HeaderText = "Forms"
            Me.Column1.Name = "Column1"
            Me.Column1.[ReadOnly] = True
            Me.chkSave.FillWeight = 76.69115F
            Me.chkSave.HeaderText = "Save"
            Me.chkSave.Name = "chkSave"
            Me.chkSave.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.chkSave.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.chkUpdate.FillWeight = 66.80138F
            Me.chkUpdate.HeaderText = "Update"
            Me.chkUpdate.Name = "chkUpdate"
            Me.chkUpdate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.chkUpdate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.chkDelete.FillWeight = 58.11202F
            Me.chkDelete.HeaderText = "Delete"
            Me.chkDelete.Name = "chkDelete"
            Me.chkDelete.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.chkDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.chkViewRecords.FillWeight = 78.26968F
            Me.chkViewRecords.HeaderText = "View Data"
            Me.chkViewRecords.Name = "chkViewRecords"
            Me.chkViewRecords.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.chkViewRecords.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.Column2.HeaderText = "ID"
            Me.Column2.Name = "Column2"
            Me.Column2.Visible = False
            Me.GroupBox1.Controls.Add(Me.Label4)
            Me.GroupBox1.Controls.Add(Me.txtName)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.txtUserType)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.cmbUserID)
            Dim groupBox As System.Windows.Forms.GroupBox = Me.GroupBox1
            location = New System.Drawing.Point(7, 35)
            groupBox.Location = location
            Me.GroupBox1.Name = "GroupBox1"
            Dim groupBox2 As System.Windows.Forms.GroupBox = Me.GroupBox1
            size = New System.Drawing.Size(574, 81)
            groupBox2.Size = size
            Me.GroupBox1.TabIndex = 4
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "User"
            Me.Label4.AutoSize = True
            Dim label3 As System.Windows.Forms.Label = Me.Label4
            location = New System.Drawing.Point(379, 21)
            label3.Location = location
            Me.Label4.Name = "Label4"
            Dim label4 As System.Windows.Forms.Label = Me.Label4
            size = New System.Drawing.Size(35, 13)
            label4.Size = size
            Me.Label4.TabIndex = 5
            Me.Label4.Text = "Name"
            Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox As System.Windows.Forms.TextBox = Me.txtName
            location = New System.Drawing.Point(382, 40)
            textBox.Location = location
            Me.txtName.Name = "txtName"
            Me.txtName.[ReadOnly] = True
            Dim textBox2 As System.Windows.Forms.TextBox = Me.txtName
            size = New System.Drawing.Size(186, 26)
            textBox2.Size = size
            Me.txtName.TabIndex = 4
            Me.Label3.AutoSize = True
            Dim label5 As System.Windows.Forms.Label = Me.Label3
            location = New System.Drawing.Point(214, 21)
            label5.Location = location
            Me.Label3.Name = "Label3"
            Dim label6 As System.Windows.Forms.Label = Me.Label3
            size = New System.Drawing.Size(56, 13)
            label6.Size = size
            Me.Label3.TabIndex = 3
            Me.Label3.Text = "User Type"
            Me.txtUserType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox3 As System.Windows.Forms.TextBox = Me.txtUserType
            location = New System.Drawing.Point(217, 40)
            textBox3.Location = location
            Me.txtUserType.Name = "txtUserType"
            Me.txtUserType.[ReadOnly] = True
            Dim textBox4 As System.Windows.Forms.TextBox = Me.txtUserType
            size = New System.Drawing.Size(159, 26)
            textBox4.Size = size
            Me.txtUserType.TabIndex = 2
            Me.Label2.AutoSize = True
            Dim label7 As System.Windows.Forms.Label = Me.Label2
            location = New System.Drawing.Point(17, 21)
            label7.Location = location
            Me.Label2.Name = "Label2"
            Dim label8 As System.Windows.Forms.Label = Me.Label2
            size = New System.Drawing.Size(43, 13)
            label8.Size = size
            Me.Label2.TabIndex = 1
            Me.Label2.Text = "User ID"
            Me.cmbUserID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbUserID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.cmbUserID.FormattingEnabled = True
            Dim comboBox As System.Windows.Forms.ComboBox = Me.cmbUserID
            location = New System.Drawing.Point(20, 40)
            comboBox.Location = location
            Me.cmbUserID.Name = "cmbUserID"
            Dim comboBox2 As System.Windows.Forms.ComboBox = Me.cmbUserID
            size = New System.Drawing.Size(191, 28)
            comboBox2.Size = size
            Me.cmbUserID.TabIndex = 0
            Me.GroupBox2.Controls.Add(Me.lblUser)
            Me.GroupBox2.Controls.Add(Me.btnDelete)
            Me.GroupBox2.Controls.Add(Me.btnNew)
            Me.GroupBox2.Controls.Add(Me.btnSave)
            Me.GroupBox2.Controls.Add(Me.btnUpdate)
            Dim groupBox3 As System.Windows.Forms.GroupBox = Me.GroupBox2
            location = New System.Drawing.Point(607, 35)
            groupBox3.Location = location
            Me.GroupBox2.Name = "GroupBox2"
            Dim groupBox4 As System.Windows.Forms.GroupBox = Me.GroupBox2
            size = New System.Drawing.Size(362, 81)
            groupBox4.Size = size
            Me.GroupBox2.TabIndex = 42
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Action Buttons"
            Me.lblUser.AutoSize = True
            Dim label9 As System.Windows.Forms.Label = Me.lblUser
            location = New System.Drawing.Point(-3, 68)
            label9.Location = location
            Me.lblUser.Name = "lblUser"
            Dim label10 As System.Windows.Forms.Label = Me.lblUser
            size = New System.Drawing.Size(39, 13)
            label10.Size = size
            Me.lblUser.TabIndex = 43
            Me.lblUser.Text = "Label8"
            Me.lblUser.Visible = False
            Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnDelete.Enabled = False
            Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnDelete.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnDelete.ForeColor = System.Drawing.Color.White
            Me.btnDelete.Image = CType(componentResourceManager.GetObject("btnDelete.Image"), System.Drawing.Image)
            Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button As System.Windows.Forms.Button = Me.btnDelete
            location = New System.Drawing.Point(262, 24)
            button.Location = location
            Me.btnDelete.Name = "btnDelete"
            Dim button2 As System.Windows.Forms.Button = Me.btnDelete
            size = New System.Drawing.Size(92, 40)
            button2.Size = size
            Me.btnDelete.TabIndex = 5
            Me.btnDelete.Text = "Delete"
            Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnDelete.UseVisualStyleBackColor = False
            Me.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.btnNew.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnNew.Image = CType(componentResourceManager.GetObject("btnNew.Image"), System.Drawing.Image)
            Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button3 As System.Windows.Forms.Button = Me.btnNew
            location = New System.Drawing.Point(13, 23)
            button3.Location = location
            Me.btnNew.Name = "btnNew"
            Dim button4 As System.Windows.Forms.Button = Me.btnNew
            size = New System.Drawing.Size(75, 45)
            button4.Size = size
            Me.btnNew.TabIndex = 0
            Me.btnNew.Text = "New"
            Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnNew.UseVisualStyleBackColor = True
            Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnSave.Image = CType(componentResourceManager.GetObject("btnSave.Image"), System.Drawing.Image)
            Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button5 As System.Windows.Forms.Button = Me.btnSave
            location = New System.Drawing.Point(94, 23)
            button5.Location = location
            Me.btnSave.Name = "btnSave"
            Dim button6 As System.Windows.Forms.Button = Me.btnSave
            size = New System.Drawing.Size(74, 45)
            button6.Size = size
            Me.btnSave.TabIndex = 1
            Me.btnSave.Text = "Save"
            Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnSave.UseVisualStyleBackColor = True
            Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnUpdate.Enabled = False
            Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnUpdate.Image = CType(componentResourceManager.GetObject("btnUpdate.Image"), System.Drawing.Image)
            Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button7 As System.Windows.Forms.Button = Me.btnUpdate
            location = New System.Drawing.Point(174, 23)
            button7.Location = location
            Me.btnUpdate.Name = "btnUpdate"
            Dim button8 As System.Windows.Forms.Button = Me.btnUpdate
            size = New System.Drawing.Size(82, 43)
            button8.Size = size
            Me.btnUpdate.TabIndex = 2
            Me.btnUpdate.Text = "Update"
            Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnUpdate.UseVisualStyleBackColor = True
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
            size = New System.Drawing.Size(993, 623)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.GroupBox2)
            MyBase.Controls.Add(Me.dgw)
            MyBase.Controls.Add(Me.GroupBox1)
            MyBase.Controls.Add(Me.Label1)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MinimizeBox = False
            MyBase.Name = "frmUserRights"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "User Management"
            CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            MyBase.ResumeLayout(False)
        End Sub
    End Class
End Namespace
