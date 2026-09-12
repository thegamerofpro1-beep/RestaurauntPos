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
Imports RestaurantPOS14.My
Imports RestaurantPOS14.My.Resources

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public Class frmBranchMaster_Bank
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel1")>
        Private _Panel1 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label3")>
        Private _Label3 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtBranchName")>
        Private _txtBranchName As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("dgw")>
        Private _dgw As System.Windows.Forms.DataGridView

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel2")>
        Private _Panel2 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label1")>
        Private _Label1 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label7")>
        Private _Label7 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label6")>
        Private _Label6 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtIFSCCode")>
        Private _txtIFSCCode As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtSwiftCode")>
        Private _txtSwiftCode As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtContactNo")>
        Private _txtContactNo As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label4")>
        Private _Label4 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label2")>
        Private _Label2 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtID")>
        Private _txtID As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblUser")>
        Private _lblUser As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtAddress")>
        Private _txtAddress As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("cmbBank")>
        Private _cmbBank As System.Windows.Forms.ComboBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label14")>
        Private _Label14 As System.Windows.Forms.Label

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

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox1")>
        Private _GroupBox1 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column1")>
        Private _Column1 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column2")>
        Private _Column2 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column10")>
        Private _Column10 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column3")>
        Private _Column3 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column4")>
        Private _Column4 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column5")>
        Private _Column5 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column6")>
        Private _Column6 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnAddCategory")>
        Private _btnAddCategory As System.Windows.Forms.Button

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

        Friend Overridable Property txtBranchName As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtBranchName
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtBranchName = value
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

        Friend Overridable Property txtIFSCCode As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtIFSCCode
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtIFSCCode = value
            End Set
        End Property

        Friend Overridable Property txtSwiftCode As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtSwiftCode
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtSwiftCode = value
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

        Friend Overridable Property cmbBank As System.Windows.Forms.ComboBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._cmbBank
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ComboBox)
                Me._cmbBank = value
            End Set
        End Property

        Friend Overridable Property Label14 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label14
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label14 = value
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

        Friend Overridable Property btnAddCategory As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnAddCategory
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnAddCategory_Click
                If Me._btnAddCategory IsNot Nothing Then
                    RemoveHandler Me._btnAddCategory.Click, value2
                End If

                Me._btnAddCategory = value
                If Me._btnAddCategory IsNot Nothing Then
                    AddHandler Me._btnAddCategory.Click, value2
                End If
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            AddHandler MyBase.Load, AddressOf Me.frmRegistration_Load
            Call RestaurantPOS14.frmBranchMaster_Bank.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmBranchMaster_Bank.__ENCList
                If RestaurantPOS14.frmBranchMaster_Bank.__ENCList.Count = RestaurantPOS14.frmBranchMaster_Bank.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmBranchMaster_Bank.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmBranchMaster_Bank.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmBranchMaster_Bank.__ENCList(num) = RestaurantPOS14.frmBranchMaster_Bank.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmBranchMaster_Bank.__ENCList.RemoveRange(num, RestaurantPOS14.frmBranchMaster_Bank.__ENCList.Count - num)
                    RestaurantPOS14.frmBranchMaster_Bank.__ENCList.Capacity = RestaurantPOS14.frmBranchMaster_Bank.__ENCList.Count
                End If

                Call RestaurantPOS14.frmBranchMaster_Bank.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Private Sub auto()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT MAX(ID) FROM BankBranch")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                If Microsoft.VisualBasic.Information.IsDBNull(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.cmd.ExecuteScalar())) Then
                    Me.txtID.Text = 1.ToString()
                Else
                    Dim num As Integer = Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(RestaurantPOS14.ModClasses.cmd.ExecuteScalar(), 1))
                    Me.txtID.Text = num.ToString()
                End If

                RestaurantPOS14.ModClasses.cmd.Dispose()
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con.Dispose()
            Catch ex As System.Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub fillCombo()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.adp = New System.Data.SqlClient.SqlDataAdapter()
                RestaurantPOS14.ModClasses.adp.SelectCommand = New System.Data.SqlClient.SqlCommand("SELECT distinct RTRIM(BankName) FROM Bank", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.ds = New System.Data.DataSet("ds")
                RestaurantPOS14.ModClasses.adp.Fill(RestaurantPOS14.ModClasses.ds)
                RestaurantPOS14.ModClasses.dtable = RestaurantPOS14.ModClasses.ds.Tables(0)
                Me.cmbBank.Items.Clear()
                For Each dataRow As System.Data.DataRow In RestaurantPOS14.ModClasses.dtable.Rows
                    Me.cmbBank.Items.Add(dataRow(CInt((0))).ToString())
                Next
            Catch ex As System.Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub Reset()
            Me.txtAddress.Text = ""
            Me.txtContactNo.Text = ""
            Me.txtIFSCCode.Text = ""
            Me.txtSwiftCode.Text = ""
            Me.txtBranchName.Text = ""
            Me.cmbBank.SelectedIndex = -1
            If RestaurantPOS14.ModFunc.IsSaveAllowed(Me.lblUser.Text, "Banking") Then
                Me.btnSave.Enabled = True
            Else
                Me.btnSave.Enabled = False
            End If

            If RestaurantPOS14.ModFunc.IsViewAllowed(Me.lblUser.Text, "Banking") Then
                Me.Getdata()
            Else
                Me.dgw.Rows.Clear()
            End If

            Me.btnUpdate.Enabled = False
            Me.btnDelete.Enabled = False
            Me.auto()
        End Sub

        Private Sub btnClose_Click(sender As Object, e As System.EventArgs)
            MyBase.Close()
        End Sub

        Private Sub btnSave_Click(sender As Object, e As System.EventArgs)
            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.cmbBank.Text, "", TextCompare:=False) = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "Please select bank", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.cmbBank.Focus()
                Return
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtBranchName.Text, "", TextCompare:=False) = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "Please enter branch name", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtBranchName.Focus()
                Return
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtAddress.Text, "", TextCompare:=False) = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "Please enter address", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtAddress.Focus()
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
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select BranchName from BankBranch where BranchName=@d1")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtBranchName.Text)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    MetroFramework.MetroMessageBox.Show(Me, "Branch Name Already Exists", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                    Me.txtBranchName.Text = ""
                    Me.txtBranchName.Focus()
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                Me.auto()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("insert into BankBranch(ID,BranchName,Address,ContactNo,SwiftCode,IFSCCode,BankName) VALUES (@d1,@d2,@d3,@d4,@d5,@d6,@d7)")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.Conversion.Val(Me.txtID.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Me.txtBranchName.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Me.txtAddress.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", Me.txtContactNo.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d5", Me.txtSwiftCode.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d6", Me.txtIFSCCode.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d7", Me.cmbBank.Text)
                RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                RestaurantPOS14.ModClasses.con.Close()
                Dim st As String = "added the new bank's branch '" & Me.txtBranchName.Text & "' info"
                RestaurantPOS14.ModFunc.LogFunc(Me.lblUser.Text, st)
                MetroFramework.MetroMessageBox.Show(Me, "Successfully saved", "Record", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                Me.Reset()
            Catch ex As System.Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnUpdate_Click(sender As Object, e As System.EventArgs)
            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.cmbBank.Text, "", TextCompare:=False) = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "Please select bank", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.cmbBank.Focus()
                Return
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtBranchName.Text, "", TextCompare:=False) = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "Please enter branch name", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtBranchName.Focus()
                Return
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtAddress.Text, "", TextCompare:=False) = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "Please enter address", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtAddress.Focus()
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
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Update BankBranch set BranchName=@d2,Address=@d3,ContactNo=@d4,SwiftCode=@d5,IFSCCode=@d6,BankName=@d7 where ID=@d1")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.Conversion.Val(Me.txtID.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Me.txtBranchName.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Me.txtAddress.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", Me.txtContactNo.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d5", Me.txtSwiftCode.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d6", Me.txtIFSCCode.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d7", Me.cmbBank.Text)
                RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                RestaurantPOS14.ModClasses.con.Close()
                Dim st As String = "updated the bank's branch '" & Me.txtBranchName.Text & "' info"
                RestaurantPOS14.ModFunc.LogFunc(Me.lblUser.Text, st)
                MetroFramework.MetroMessageBox.Show(Me, "Successfully updated", "Record", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                Me.Reset()
            Catch ex As System.Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub Getdata()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT RTRIM(ID),RTRIM(BankName), RTRIM(BranchName), RTRIM(Address), RTRIM(ContactNo), RTRIM(SwiftCode), RTRIM(IFSCCode) from BankBranch order by BranchName", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                Me.dgw.Rows.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Me.dgw.Rows.Add(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(0)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(1)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(2)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(3)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(4)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(5)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(6)))
                End While

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
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

        Private Sub frmRegistration_Load(sender As Object, e As System.EventArgs)
            Me.fillCombo()
        End Sub

        Private Sub dgw_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs)
            Try
                If Me.dgw.Rows.Count > 0 Then
                    If Me.dgw.SelectedRows.Count = 0 Then Return
                    Dim dataGridViewRow As System.Windows.Forms.DataGridViewRow = Me.dgw.SelectedRows(0)
                    Me.txtID.Text = dataGridViewRow.Cells(CInt((0))).Value.ToString()
                    Me.cmbBank.Text = dataGridViewRow.Cells(CInt((1))).Value.ToString()
                    Me.txtBranchName.Text = dataGridViewRow.Cells(CInt((2))).Value.ToString()
                    Me.txtAddress.Text = dataGridViewRow.Cells(CInt((3))).Value.ToString()
                    Me.txtContactNo.Text = dataGridViewRow.Cells(CInt((4))).Value.ToString()
                    Me.txtSwiftCode.Text = dataGridViewRow.Cells(CInt((5))).Value.ToString()
                    Me.txtIFSCCode.Text = dataGridViewRow.Cells(CInt((6))).Value.ToString()
                    Me.btnSave.Enabled = False
                    If RestaurantPOS14.ModFunc.IsDeleteAllowed(Me.lblUser.Text, "Banking") Then
                        Me.btnDelete.Enabled = True
                    Else
                        Me.btnDelete.Enabled = False
                    End If

                    If RestaurantPOS14.ModFunc.IsUpdateAllowed(Me.lblUser.Text, "Banking") Then
                        Me.btnUpdate.Enabled = True
                    Else
                        Me.btnUpdate.Enabled = False
                    End If
                End If
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
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select BankBranch.ID from BankBranch,BankAccountRegistration where BankBranch.ID=BankAccountRegistration.BranchID and BankBranch.ID=@d1")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.Conversion.Val(Me.txtID.Text))
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    MetroFramework.MetroMessageBox.Show(Me, "Unable to delete..Already in use in Bank Accounts Registration", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("delete from BankBranch where ID=" & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.txtID.Text)))
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                If RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery() > 0 Then
                    Dim st As String = "deleted the Bank's branch '" & Me.txtBranchName.Text & "' record"
                    RestaurantPOS14.ModFunc.LogFunc(Me.lblUser.Text, st)
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

        Private Sub btnAddCategory_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmBank.lblUser.Text = Me.lblUser.Text
            RestaurantPOS14.My.MyProject.Forms.frmBank.lblSet.Text = "Branch"
            Call RestaurantPOS14.My.MyProject.Forms.frmBank.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmBank.ShowDialog()
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmBranchMaster_Bank))
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.btnDelete = New System.Windows.Forms.Button()
            Me.btnUpdate = New System.Windows.Forms.Button()
            Me.btnNew = New System.Windows.Forms.Button()
            Me.btnSave = New System.Windows.Forms.Button()
            Me.btnClose = New System.Windows.Forms.Button()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.cmbBank = New System.Windows.Forms.ComboBox()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.txtContactNo = New System.Windows.Forms.TextBox()
            Me.txtSwiftCode = New System.Windows.Forms.TextBox()
            Me.txtAddress = New System.Windows.Forms.TextBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtBranchName = New System.Windows.Forms.TextBox()
            Me.txtIFSCCode = New System.Windows.Forms.TextBox()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.lblUser = New System.Windows.Forms.Label()
            Me.txtID = New System.Windows.Forms.TextBox()
            Me.dgw = New System.Windows.Forms.DataGridView()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.btnAddCategory = New System.Windows.Forms.Button()
            Me.Panel1.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel2.SuspendLayout()
            MyBase.SuspendLayout()
            Me.Panel1.BackColor = System.Drawing.Color.White
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.GroupBox2)
            Me.Panel1.Controls.Add(Me.btnClose)
            Me.Panel1.Controls.Add(Me.GroupBox1)
            Me.Panel1.Controls.Add(Me.lblUser)
            Me.Panel1.Controls.Add(Me.txtID)
            Me.Panel1.Controls.Add(Me.dgw)
            Me.Panel1.Controls.Add(Me.Panel2)
            Dim panel As System.Windows.Forms.Panel = Me.Panel1
            Dim location As System.Drawing.Point = New System.Drawing.Point(4, 3)
            panel.Location = location
            Me.Panel1.Name = "Panel1"
            Dim panel2 As System.Windows.Forms.Panel = Me.Panel1
            Dim size As System.Drawing.Size = New System.Drawing.Size(651, 545)
            panel2.Size = size
            Me.Panel1.TabIndex = 2
            Me.GroupBox2.Controls.Add(Me.btnDelete)
            Me.GroupBox2.Controls.Add(Me.btnUpdate)
            Me.GroupBox2.Controls.Add(Me.btnNew)
            Me.GroupBox2.Controls.Add(Me.btnSave)
            Dim groupBox As System.Windows.Forms.GroupBox = Me.GroupBox2
            location = New System.Drawing.Point(546, 63)
            groupBox.Location = location
            Me.GroupBox2.Name = "GroupBox2"
            Dim groupBox2 As System.Windows.Forms.GroupBox = Me.GroupBox2
            size = New System.Drawing.Size(100, 185)
            groupBox2.Size = size
            Me.GroupBox2.TabIndex = 6
            Me.GroupBox2.TabStop = False
            Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnDelete.Image = RestaurantPOS14.My.Resources.Resources.Delete_32x32
            Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button As System.Windows.Forms.Button = Me.btnDelete
            location = New System.Drawing.Point(10, 134)
            button.Location = location
            Me.btnDelete.Name = "btnDelete"
            Dim button2 As System.Windows.Forms.Button = Me.btnDelete
            size = New System.Drawing.Size(80, 37)
            button2.Size = size
            Me.btnDelete.TabIndex = 5
            Me.btnDelete.Text = "Delete"
            Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnDelete.UseVisualStyleBackColor = True
            Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnUpdate.Image = RestaurantPOS14.My.Resources.Resources._9
            Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button3 As System.Windows.Forms.Button = Me.btnUpdate
            location = New System.Drawing.Point(10, 93)
            button3.Location = location
            Me.btnUpdate.Name = "btnUpdate"
            Dim button4 As System.Windows.Forms.Button = Me.btnUpdate
            size = New System.Drawing.Size(80, 37)
            button4.Size = size
            Me.btnUpdate.TabIndex = 2
            Me.btnUpdate.Text = "Update"
            Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnUpdate.UseVisualStyleBackColor = True
            Me.btnNew.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnNew.Image = RestaurantPOS14.My.Resources.Resources.AddFile_32x32
            Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button5 As System.Windows.Forms.Button = Me.btnNew
            location = New System.Drawing.Point(10, 13)
            button5.Location = location
            Me.btnNew.Name = "btnNew"
            Dim button6 As System.Windows.Forms.Button = Me.btnNew
            size = New System.Drawing.Size(80, 37)
            button6.Size = size
            Me.btnNew.TabIndex = 0
            Me.btnNew.Text = "New"
            Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnNew.UseVisualStyleBackColor = True
            Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnSave.Image = RestaurantPOS14.My.Resources.Resources.Save_32x32
            Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button7 As System.Windows.Forms.Button = Me.btnSave
            location = New System.Drawing.Point(10, 53)
            button7.Location = location
            Me.btnSave.Name = "btnSave"
            Dim button8 As System.Windows.Forms.Button = Me.btnSave
            size = New System.Drawing.Size(80, 37)
            button8.Size = size
            Me.btnSave.TabIndex = 1
            Me.btnSave.Text = "Save"
            Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnSave.UseVisualStyleBackColor = True
            Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnClose.Image = RestaurantPOS14.My.Resources.Resources.Close_32x32
            Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button9 As System.Windows.Forms.Button = Me.btnClose
            location = New System.Drawing.Point(570, 2)
            button9.Location = location
            Me.btnClose.Name = "btnClose"
            Dim button10 As System.Windows.Forms.Button = Me.btnClose
            size = New System.Drawing.Size(75, 37)
            button10.Size = size
            Me.btnClose.TabIndex = 4
            Me.btnClose.Text = "Close"
            Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnClose.UseVisualStyleBackColor = True
            Me.GroupBox1.Controls.Add(Me.btnAddCategory)
            Me.GroupBox1.Controls.Add(Me.cmbBank)
            Me.GroupBox1.Controls.Add(Me.Label14)
            Me.GroupBox1.Controls.Add(Me.txtContactNo)
            Me.GroupBox1.Controls.Add(Me.txtSwiftCode)
            Me.GroupBox1.Controls.Add(Me.txtAddress)
            Me.GroupBox1.Controls.Add(Me.Label4)
            Me.GroupBox1.Controls.Add(Me.txtBranchName)
            Me.GroupBox1.Controls.Add(Me.txtIFSCCode)
            Me.GroupBox1.Controls.Add(Me.Label7)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.Label6)
            Dim groupBox3 As System.Windows.Forms.GroupBox = Me.GroupBox1
            location = New System.Drawing.Point(4, 42)
            groupBox3.Location = location
            Me.GroupBox1.Name = "GroupBox1"
            Dim groupBox4 As System.Windows.Forms.GroupBox = Me.GroupBox1
            size = New System.Drawing.Size(342, 233)
            groupBox4.Size = size
            Me.GroupBox1.TabIndex = 6
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Bank Info"
            Me.cmbBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbBank.FormattingEnabled = True
            Dim comboBox As System.Windows.Forms.ComboBox = Me.cmbBank
            location = New System.Drawing.Point(88, 25)
            comboBox.Location = location
            Me.cmbBank.Name = "cmbBank"
            Dim comboBox2 As System.Windows.Forms.ComboBox = Me.cmbBank
            size = New System.Drawing.Size(213, 21)
            comboBox2.Size = size
            Me.cmbBank.TabIndex = 0
            Me.Label14.AutoSize = True
            Dim label As System.Windows.Forms.Label = Me.Label14
            location = New System.Drawing.Point(6, 29)
            label.Location = location
            Me.Label14.Name = "Label14"
            Dim label2 As System.Windows.Forms.Label = Me.Label14
            size = New System.Drawing.Size(38, 13)
            label2.Size = size
            Me.Label14.TabIndex = 32
            Me.Label14.Text = "Bank :"
            Me.txtContactNo.BackColor = System.Drawing.Color.White
            Me.txtContactNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox As System.Windows.Forms.TextBox = Me.txtContactNo
            location = New System.Drawing.Point(88, 148)
            textBox.Location = location
            Me.txtContactNo.Name = "txtContactNo"
            Dim textBox2 As System.Windows.Forms.TextBox = Me.txtContactNo
            size = New System.Drawing.Size(122, 21)
            textBox2.Size = size
            Me.txtContactNo.TabIndex = 3
            Me.txtSwiftCode.BackColor = System.Drawing.Color.White
            Me.txtSwiftCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox3 As System.Windows.Forms.TextBox = Me.txtSwiftCode
            location = New System.Drawing.Point(88, 174)
            textBox3.Location = location
            Me.txtSwiftCode.Name = "txtSwiftCode"
            Dim textBox4 As System.Windows.Forms.TextBox = Me.txtSwiftCode
            size = New System.Drawing.Size(122, 21)
            textBox4.Size = size
            Me.txtSwiftCode.TabIndex = 4
            Me.txtAddress.BackColor = System.Drawing.Color.White
            Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox5 As System.Windows.Forms.TextBox = Me.txtAddress
            location = New System.Drawing.Point(88, 89)
            textBox5.Location = location
            Me.txtAddress.Multiline = True
            Me.txtAddress.Name = "txtAddress"
            Dim textBox6 As System.Windows.Forms.TextBox = Me.txtAddress
            size = New System.Drawing.Size(213, 53)
            textBox6.Size = size
            Me.txtAddress.TabIndex = 2
            Me.Label4.AutoSize = True
            Dim label3 As System.Windows.Forms.Label = Me.Label4
            location = New System.Drawing.Point(6, 152)
            label3.Location = location
            Me.Label4.Name = "Label4"
            Dim label4 As System.Windows.Forms.Label = Me.Label4
            size = New System.Drawing.Size(70, 13)
            label4.Size = size
            Me.Label4.TabIndex = 6
            Me.Label4.Text = "Contact No. :"
            Me.txtBranchName.BackColor = System.Drawing.Color.White
            Me.txtBranchName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox7 As System.Windows.Forms.TextBox = Me.txtBranchName
            location = New System.Drawing.Point(88, 57)
            textBox7.Location = location
            Me.txtBranchName.Name = "txtBranchName"
            Dim textBox8 As System.Windows.Forms.TextBox = Me.txtBranchName
            size = New System.Drawing.Size(213, 21)
            textBox8.Size = size
            Me.txtBranchName.TabIndex = 1
            Me.txtIFSCCode.BackColor = System.Drawing.Color.White
            Me.txtIFSCCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox9 As System.Windows.Forms.TextBox = Me.txtIFSCCode
            location = New System.Drawing.Point(88, 200)
            textBox9.Location = location
            Me.txtIFSCCode.Name = "txtIFSCCode"
            Dim textBox10 As System.Windows.Forms.TextBox = Me.txtIFSCCode
            size = New System.Drawing.Size(122, 21)
            textBox10.Size = size
            Me.txtIFSCCode.TabIndex = 5
            Me.Label7.AutoSize = True
            Dim label5 As System.Windows.Forms.Label = Me.Label7
            location = New System.Drawing.Point(6, 204)
            label5.Location = location
            Me.Label7.Name = "Label7"
            Dim label6 As System.Windows.Forms.Label = Me.Label7
            size = New System.Drawing.Size(75, 13)
            label6.Size = size
            Me.Label7.TabIndex = 13
            Me.Label7.Text = "Branch Code :"
            Me.Label2.AutoSize = True
            Dim label7 As System.Windows.Forms.Label = Me.Label2
            location = New System.Drawing.Point(6, 109)
            label7.Location = location
            Me.Label2.Name = "Label2"
            Dim label8 As System.Windows.Forms.Label = Me.Label2
            size = New System.Drawing.Size(51, 13)
            label8.Size = size
            Me.Label2.TabIndex = 5
            Me.Label2.Text = "Address :"
            Me.Label3.AutoSize = True
            Dim label9 As System.Windows.Forms.Label = Me.Label3
            location = New System.Drawing.Point(6, 61)
            label9.Location = location
            Me.Label3.Name = "Label3"
            Dim label10 As System.Windows.Forms.Label = Me.Label3
            size = New System.Drawing.Size(78, 13)
            label10.Size = size
            Me.Label3.TabIndex = 0
            Me.Label3.Text = "Branch Name :"
            Me.Label6.AutoSize = True
            Dim label11 As System.Windows.Forms.Label = Me.Label6
            location = New System.Drawing.Point(6, 178)
            label11.Location = location
            Me.Label6.Name = "Label6"
            Dim label12 As System.Windows.Forms.Label = Me.Label6
            size = New System.Drawing.Size(64, 13)
            label12.Size = size
            Me.Label6.TabIndex = 12
            Me.Label6.Text = "Swift Code :"
            Me.lblUser.AutoSize = True
            Dim label13 As System.Windows.Forms.Label = Me.lblUser
            location = New System.Drawing.Point(338, 195)
            label13.Location = location
            Me.lblUser.Name = "lblUser"
            Dim label14 As System.Windows.Forms.Label = Me.lblUser
            size = New System.Drawing.Size(39, 13)
            label14.Size = size
            Me.lblUser.TabIndex = 5
            Me.lblUser.Text = "Label8"
            Me.lblUser.Visible = False
            Dim textBox11 As System.Windows.Forms.TextBox = Me.txtID
            location = New System.Drawing.Point(341, 144)
            textBox11.Location = location
            Me.txtID.Name = "txtID"
            Dim textBox12 As System.Windows.Forms.TextBox = Me.txtID
            size = New System.Drawing.Size(20, 20)
            textBox12.Size = size
            Me.txtID.TabIndex = 4
            Me.txtID.Visible = False
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
            Me.dgw.ColumnHeadersHeight = 24
            Me.dgw.Columns.AddRange(Me.Column1, Me.Column2, Me.Column10, Me.Column3, Me.Column4, Me.Column5, Me.Column6)
            Me.dgw.Cursor = System.Windows.Forms.Cursors.Hand
            Me.dgw.EnableHeadersVisualStyles = False
            Me.dgw.GridColor = System.Drawing.Color.White
            Dim dataGridView As System.Windows.Forms.DataGridView = Me.dgw
            location = New System.Drawing.Point(4, 285)
            dataGridView.Location = location
            Me.dgw.MultiSelect = False
            Me.dgw.Name = "dgw"
            Me.dgw.[ReadOnly] = True
            Me.dgw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White
            dataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Moccasin
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgw.RowHeadersDefaultCellStyle = dataGridViewCellStyle3
            Me.dgw.RowHeadersWidth = 25
            Me.dgw.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White
            dataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Moccasin
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
            Me.dgw.RowsDefaultCellStyle = dataGridViewCellStyle4
            Me.dgw.RowTemplate.Height = 18
            Me.dgw.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgw.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Dim dataGridView2 As System.Windows.Forms.DataGridView = Me.dgw
            size = New System.Drawing.Size(642, 254)
            dataGridView2.Size = size
            Me.dgw.TabIndex = 1
            Me.Column1.HeaderText = "ID"
            Me.Column1.Name = "Column1"
            Me.Column1.[ReadOnly] = True
            Me.Column1.Visible = False
            Me.Column2.HeaderText = "Bank"
            Me.Column2.Name = "Column2"
            Me.Column2.[ReadOnly] = True
            Me.Column10.HeaderText = "Branch Name"
            Me.Column10.Name = "Column10"
            Me.Column10.[ReadOnly] = True
            Me.Column10.Width = 114
            Me.Column3.HeaderText = "Address"
            Me.Column3.Name = "Column3"
            Me.Column3.[ReadOnly] = True
            Me.Column4.HeaderText = "Contact No."
            Me.Column4.Name = "Column4"
            Me.Column4.[ReadOnly] = True
            Me.Column5.HeaderText = "Swift Code"
            Me.Column5.Name = "Column5"
            Me.Column5.[ReadOnly] = True
            Me.Column6.HeaderText = "Branch Code"
            Me.Column6.Name = "Column6"
            Me.Column6.[ReadOnly] = True
            Me.Panel2.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Panel2.Controls.Add(Me.Label1)
            Dim panel3 As System.Windows.Forms.Panel = Me.Panel2
            location = New System.Drawing.Point(4, 3)
            panel3.Location = location
            Me.Panel2.Name = "Panel2"
            Dim panel4 As System.Windows.Forms.Panel = Me.Panel2
            size = New System.Drawing.Size(561, 31)
            panel4.Size = size
            Me.Panel2.TabIndex = 0
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label1.ForeColor = System.Drawing.Color.White
            Dim label15 As System.Windows.Forms.Label = Me.Label1
            location = New System.Drawing.Point(227, 3)
            label15.Location = location
            Me.Label1.Name = "Label1"
            Dim label16 As System.Windows.Forms.Label = Me.Label1
            size = New System.Drawing.Size(130, 24)
            label16.Size = size
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Branch Entry"
            Me.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnAddCategory.Image = RestaurantPOS14.My.Resources.Resources._1__2_
            Dim button11 As System.Windows.Forms.Button = Me.btnAddCategory
            location = New System.Drawing.Point(307, 25)
            button11.Location = location
            Me.btnAddCategory.Name = "btnAddCategory"
            Dim button12 As System.Windows.Forms.Button = Me.btnAddCategory
            size = New System.Drawing.Size(31, 23)
            button12.Size = size
            Me.btnAddCategory.TabIndex = 311
            Me.btnAddCategory.UseVisualStyleBackColor = True
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            size = New System.Drawing.Size(658, 551)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.Panel1)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MaximizeBox = False
            MyBase.MinimizeBox = False
            MyBase.Name = "frmBranchMaster_Bank"
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
