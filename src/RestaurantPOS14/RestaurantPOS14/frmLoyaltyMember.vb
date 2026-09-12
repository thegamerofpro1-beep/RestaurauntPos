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

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public Class frmLoyaltyMember
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel1")>
        Private _Panel1 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel4")>
        Private _Panel4 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label3")>
        Private _Label3 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtMemberID")>
        Private _txtMemberID As System.Windows.Forms.TextBox

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

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label5")>
        Private _Label5 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtContactNo")>
        Private _txtContactNo As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtMemberName")>
        Private _txtMemberName As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblUser")>
        Private _lblUser As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label8")>
        Private _Label8 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("chkActive")>
        Private _chkActive As System.Windows.Forms.CheckBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnClose")>
        Private _btnClose As System.Windows.Forms.Button

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

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtSearchByMemberName")>
        Private _txtSearchByMemberName As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtMemName")>
        Private _txtMemName As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label2")>
        Private _Label2 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtCardNo")>
        Private _txtCardNo As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Description")>
        Private _Description As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column3")>
        Private _Column3 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column1")>
        Private _Column1 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column2")>
        Private _Column2 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column4")>
        Private _Column4 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column7")>
        Private _Column7 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column6")>
        Private _Column6 As System.Windows.Forms.DataGridViewTextBoxColumn

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

        Friend Overridable Property txtMemberID As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtMemberID
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtMemberID = value
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

        Friend Overridable Property txtMemberName As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtMemberName
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtMemberName = value
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

        Friend Overridable Property btnClose As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnClose
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnClose_Click_1
                If Me._btnClose IsNot Nothing Then
                    RemoveHandler Me._btnClose.Click, value2
                End If

                Me._btnClose = value
                If Me._btnClose IsNot Nothing Then
                    AddHandler Me._btnClose.Click, value2
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

        Friend Overridable Property txtSearchByMemberName As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtSearchByMemberName
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.EventHandler = AddressOf Me.txtSearchByMemberName_TextChanged
                If Me._txtSearchByMemberName IsNot Nothing Then
                    RemoveHandler Me._txtSearchByMemberName.TextChanged, value2
                End If

                Me._txtSearchByMemberName = value
                If Me._txtSearchByMemberName IsNot Nothing Then
                    AddHandler Me._txtSearchByMemberName.TextChanged, value2
                End If
            End Set
        End Property

        Friend Overridable Property txtMemName As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtMemName
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtMemName = value
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

        Friend Overridable Property txtCardNo As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtCardNo
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtCardNo = value
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
            AddHandler MyBase.Load, AddressOf Me.frmLoyaltyMember_Load
            Call RestaurantPOS14.frmLoyaltyMember.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmLoyaltyMember.__ENCList
                If RestaurantPOS14.frmLoyaltyMember.__ENCList.Count = RestaurantPOS14.frmLoyaltyMember.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmLoyaltyMember.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmLoyaltyMember.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmLoyaltyMember.__ENCList(num) = RestaurantPOS14.frmLoyaltyMember.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmLoyaltyMember.__ENCList.RemoveRange(num, RestaurantPOS14.frmLoyaltyMember.__ENCList.Count - num)
                    RestaurantPOS14.frmLoyaltyMember.__ENCList.Capacity = RestaurantPOS14.frmLoyaltyMember.__ENCList.Count
                End If

                Call RestaurantPOS14.frmLoyaltyMember.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Public Sub Reset()
            Me.txtContactNo.Text = ""
            Me.txtMemberName.Text = ""
            Me.txtAddress.Text = ""
            Me.txtCardNo.Text = ""
            Me.txtSearchByMemberName.Text = ""
            Me.chkActive.Checked = True
            Me.txtMemberName.Focus()
            If RestaurantPOS14.ModFunc.IsSaveAllowed(Me.lblUser.Text, "Loyalty Card") Then
                Me.btnSave.Enabled = True
            Else
                Me.btnSave.Enabled = False
            End If

            If RestaurantPOS14.ModFunc.IsViewAllowed(Me.lblUser.Text, "Loyalty Card") Then
                Me.Getdata()
                Me.GroupBox1.Enabled = True
            Else
                Me.dgw.Rows.Clear()
                Me.GroupBox1.Enabled = False
            End If

            Me.btnUpdate.Enabled = False
            Me.btnDelete.Enabled = False
            Me.auto()
        End Sub

        Private Sub DeleteRecord()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select MemberID from RestaurantPOS_BillingInfoEB,Member where RestaurantPOS_BillingInfoEB.Member_ID=Member.MemberID and MemberID=@d1")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.Conversion.Val(Me.txtMemberID.Text))
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Unable to delete..Already in use in Restaurant POS", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select MemberID from RestaurantPOS_BillingInfoTA,Member where RestaurantPOS_BillingInfoTA.Member_ID=Member.MemberID and MemberID=@d1")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.Conversion.Val(Me.txtMemberID.Text))
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Unable to delete..Already in use in Restaurant POS", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select MemberID from RestaurantPOS_BillingInfoHD,Member where RestaurantPOS_BillingInfoHD.Member_ID=Member.MemberID and MemberID=@d1")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.Conversion.Val(Me.txtMemberID.Text))
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Unable to delete..Already in use in Restaurant POS", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select MemberID from RestaurantPOS_BillingInfoKOT,Member where RestaurantPOS_BillingInfoKOT.Member_ID=Member.MemberID and MemberID=@d1")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.Conversion.Val(Me.txtMemberID.Text))
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Unable to delete..Already in use in Restaurant POS", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("delete from LoyaltyMember where Memberid='" & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.txtMemberID.Text)) & "'")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                If RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery() > 0 Then
                    Dim st As String = "Deleted the Loyalty Card Member '" & Me.txtMemberID.Text & "' having Member ID '" & Me.txtMemberID.Text & "'"
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

        Public Sub Getdata()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT Memberid, RTRIM(Name),RTRIM(CardNo), RTRIM(Address), RTRIM(ContactNo),RTRIM(Active),RegistrationDate from LoyaltyMember order by Name", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                Me.dgw.Rows.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Me.dgw.Rows.Add(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(0)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(1)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(2)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(3)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(4)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(5)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(6)))
                End While

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
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
                    Me.txtMemberID.Text = dataGridViewRow.Cells(CInt((0))).Value.ToString()
                    Me.txtMemberName.Text = dataGridViewRow.Cells(CInt((1))).Value.ToString()
                    Me.txtMemName.Text = dataGridViewRow.Cells(CInt((1))).Value.ToString()
                    Me.txtCardNo.Text = dataGridViewRow.Cells(CInt((2))).Value.ToString()
                    Me.txtAddress.Text = dataGridViewRow.Cells(CInt((3))).Value.ToString()
                    Me.txtContactNo.Text = dataGridViewRow.Cells(CInt((4))).Value.ToString()
                    If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dataGridViewRow.Cells(CInt((5))).Value.ToString(), "Yes", TextCompare:=False) = 0 Then
                        Me.chkActive.Checked = True
                    Else
                        Me.chkActive.Checked = False
                    End If

                    If RestaurantPOS14.ModFunc.IsDeleteAllowed(Me.lblUser.Text, "Loyalty Card") Then
                        Me.btnDelete.Enabled = True
                    Else
                        Me.btnDelete.Enabled = False
                    End If

                    If RestaurantPOS14.ModFunc.IsUpdateAllowed(Me.lblUser.Text, "Loyalty Card") Then
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

        Private Sub btnClose_Click_1(sender As Object, e As System.EventArgs)
            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "POS", TextCompare:=False) = 0 Then
                Call RestaurantPOS14.My.MyProject.Forms.frmLoyaltyCardMemberPoints.GetData()
            End If

            MyBase.Close()
        End Sub

        Private Sub btnUpdate_Click(sender As Object, e As System.EventArgs)
            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtMemberName.Text, "", TextCompare:=False) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please enter member name", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtMemberName.Focus()
                Return
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtContactNo.Text, "", TextCompare:=False) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please enter contact no.", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtContactNo.Focus()
                Return
            End If

            Try
                If Me.chkActive.Checked Then
                    Me.st1 = "Yes"
                Else
                    Me.st1 = "No"
                End If

                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Update LoyaltyMember set Name=@d2, ContactNo=@d3, Address=@d4, Active=@d5,CardNo=@d6 where MemberID=@d1")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.Conversion.Val(Me.txtMemberID.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Me.txtMemberName.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Me.txtContactNo.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", Me.txtAddress.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d5", Me.st1)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d6", Me.txtCardNo.Text)
                RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                RestaurantPOS14.ModClasses.con.Close()
                Dim st As String = "Updated the Loyalty Card Member '" & Me.txtMemberID.Text & "' having Member ID '" & Me.txtMemberID.Text & "'"
                RestaurantPOS14.ModFunc.LogFunc(Me.lblUser.Text, st)
                Call System.Windows.Forms.MessageBox.Show("Successfully updated", "Member Info", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                Me.btnUpdate.Enabled = False
                Me.Reset()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub Button2_Click(sender As Object, e As System.EventArgs)
            Try
                If System.Windows.Forms.MessageBox.Show("Do you really want to delete this record?", "Confirmation", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Exclamation) = System.Windows.Forms.DialogResult.Yes Then
                    Me.DeleteRecord()
                End If
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub auto()
            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
            RestaurantPOS14.ModClasses.con.Open()
            RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT MAX(MemberID) FROM LoyaltyMember")
            RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
            If Microsoft.VisualBasic.Information.IsDBNull(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.cmd.ExecuteScalar())) Then
                Me.txtMemberID.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(1000000.0 + Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(1.ToString()))
            Else
                Dim num As Integer = Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(RestaurantPOS14.ModClasses.cmd.ExecuteScalar(), 1))
                Me.txtMemberID.Text = num.ToString()
            End If

            RestaurantPOS14.ModClasses.cmd.Dispose()
            RestaurantPOS14.ModClasses.con.Close()
            RestaurantPOS14.ModClasses.con.Dispose()
        End Sub

        Private Sub btnSave_Click(sender As Object, e As System.EventArgs)
            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtMemberName.Text, "", TextCompare:=False) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please enter member name", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtMemberName.Focus()
                Return
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtContactNo.Text, "", TextCompare:=False) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please enter contact no.", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtContactNo.Focus()
                Return
            End If

            Try
                Me.auto()
                If Me.chkActive.Checked Then
                    Me.st1 = "Yes"
                Else
                    Me.st1 = "No"
                End If

                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("insert into LoyaltyMember(MemberID, Name, ContactNo, Address, RegistrationDate, Active,CardNo) VALUES (@d1,@d2,@d3,@d4,@d5,@d6,@d7)")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.Conversion.Val(Me.txtMemberID.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Me.txtMemberName.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Me.txtContactNo.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", Me.txtAddress.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d5", Microsoft.VisualBasic.DateAndTime.Now)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d6", Me.st1)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d7", Me.txtCardNo.Text)
                RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                RestaurantPOS14.ModClasses.con.Close()
                Dim st As String = "added the new Loyalty Card Member '" & Me.txtMemberID.Text & "' having Member ID '" & Me.txtMemberID.Text & "'"
                RestaurantPOS14.ModFunc.LogFunc(Me.lblUser.Text, st)
                Call System.Windows.Forms.MessageBox.Show("Successfully Registered", "Member", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                Me.btnSave.Enabled = False
                Me.Reset()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnNew_Click(sender As Object, e As System.EventArgs)
            Me.Reset()
        End Sub

        Private Sub txtSearchByMemberName_TextChanged(sender As Object, e As System.EventArgs)
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT Memberid, RTRIM(Name),RTRIM(CardNo), RTRIM(Address), RTRIM(ContactNo),RTRIM(Active),RegistrationDate from LoyaltyMember where Name like N'%" & RestaurantPOS14.Security.SqlInput.EscapeLiteral(Me.txtSearchByMemberName.Text) & "%' order by Name", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                Me.dgw.Rows.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Me.dgw.Rows.Add(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(0)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(1)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(2)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(3)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(4)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(5)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(6)))
                End While

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub frmLoyaltyMember_Load(sender As Object, e As System.EventArgs)
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmLoyaltyMember))
            Dim dataGridViewCellStyle As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.btnDelete = New System.Windows.Forms.Button()
            Me.lblSet = New System.Windows.Forms.Label()
            Me.btnUpdate = New System.Windows.Forms.Button()
            Me.btnSave = New System.Windows.Forms.Button()
            Me.txtMemName = New System.Windows.Forms.TextBox()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.txtSearchByMemberName = New System.Windows.Forms.TextBox()
            Me.btnNew = New System.Windows.Forms.Button()
            Me.btnClose = New System.Windows.Forms.Button()
            Me.Panel4 = New System.Windows.Forms.Panel()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtCardNo = New System.Windows.Forms.TextBox()
            Me.txtAddress = New System.Windows.Forms.RichTextBox()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.chkActive = New System.Windows.Forms.CheckBox()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.txtContactNo = New System.Windows.Forms.TextBox()
            Me.txtMemberName = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtMemberID = New System.Windows.Forms.TextBox()
            Me.dgw = New System.Windows.Forms.DataGridView()
            Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.lblUser = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Panel1.SuspendLayout()
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
            Me.Panel1.Controls.Add(Me.txtMemName)
            Me.Panel1.Controls.Add(Me.GroupBox1)
            Me.Panel1.Controls.Add(Me.btnNew)
            Me.Panel1.Controls.Add(Me.btnClose)
            Me.Panel1.Controls.Add(Me.Panel4)
            Me.Panel1.Controls.Add(Me.dgw)
            Me.Panel1.Controls.Add(Me.Panel2)
            Dim panel As System.Windows.Forms.Panel = Me.Panel1
            Dim location As System.Drawing.Point = New System.Drawing.Point(6, 7)
            panel.Location = location
            Me.Panel1.Name = "Panel1"
            Dim panel2 As System.Windows.Forms.Panel = Me.Panel1
            Dim size As System.Drawing.Size = New System.Drawing.Size(794, 637)
            panel2.Size = size
            Me.Panel1.TabIndex = 2
            Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnDelete.Image = CType(componentResourceManager.GetObject("btnDelete.Image"), System.Drawing.Image)
            Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button As System.Windows.Forms.Button = Me.btnDelete
            location = New System.Drawing.Point(514, 175)
            button.Location = location
            Me.btnDelete.Name = "btnDelete"
            Dim button2 As System.Windows.Forms.Button = Me.btnDelete
            size = New System.Drawing.Size(97, 40)
            button2.Size = size
            Me.btnDelete.TabIndex = 1
            Me.btnDelete.Text = "Delete"
            Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnDelete.UseVisualStyleBackColor = True
            Me.lblSet.AutoSize = True
            Dim label As System.Windows.Forms.Label = Me.lblSet
            location = New System.Drawing.Point(679, 111)
            label.Location = location
            Me.lblSet.Name = "lblSet"
            Dim label2 As System.Windows.Forms.Label = Me.lblSet
            size = New System.Drawing.Size(39, 13)
            label2.Size = size
            Me.lblSet.TabIndex = 12
            Me.lblSet.Text = "Label8"
            Me.lblSet.Visible = False
            Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnUpdate.Image = CType(componentResourceManager.GetObject("btnUpdate.Image"), System.Drawing.Image)
            Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button3 As System.Windows.Forms.Button = Me.btnUpdate
            location = New System.Drawing.Point(514, 131)
            button3.Location = location
            Me.btnUpdate.Name = "btnUpdate"
            Dim button4 As System.Windows.Forms.Button = Me.btnUpdate
            size = New System.Drawing.Size(97, 40)
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
            location = New System.Drawing.Point(514, 89)
            button5.Location = location
            Me.btnSave.Name = "btnSave"
            Dim button6 As System.Windows.Forms.Button = Me.btnSave
            size = New System.Drawing.Size(97, 37)
            button6.Size = size
            Me.btnSave.TabIndex = 2
            Me.btnSave.Text = "Save"
            Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnSave.UseVisualStyleBackColor = True
            Me.txtMemName.BackColor = System.Drawing.Color.White
            Me.txtMemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox As System.Windows.Forms.TextBox = Me.txtMemName
            location = New System.Drawing.Point(682, 224)
            textBox.Location = location
            Me.txtMemName.Name = "txtMemName"
            Dim textBox2 As System.Windows.Forms.TextBox = Me.txtMemName
            size = New System.Drawing.Size(79, 21)
            textBox2.Size = size
            Me.txtMemName.TabIndex = 7
            Me.txtMemName.Visible = False
            Me.GroupBox1.Controls.Add(Me.txtSearchByMemberName)
            Dim groupBox As System.Windows.Forms.GroupBox = Me.GroupBox1
            location = New System.Drawing.Point(9, 248)
            groupBox.Location = location
            Me.GroupBox1.Name = "GroupBox1"
            Dim groupBox2 As System.Windows.Forms.GroupBox = Me.GroupBox1
            size = New System.Drawing.Size(235, 68)
            groupBox2.Size = size
            Me.GroupBox1.TabIndex = 6
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Search By Member Name"
            Me.txtSearchByMemberName.BackColor = System.Drawing.Color.White
            Me.txtSearchByMemberName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox3 As System.Windows.Forms.TextBox = Me.txtSearchByMemberName
            location = New System.Drawing.Point(22, 29)
            textBox3.Location = location
            Me.txtSearchByMemberName.Name = "txtSearchByMemberName"
            Dim textBox4 As System.Windows.Forms.TextBox = Me.txtSearchByMemberName
            size = New System.Drawing.Size(207, 21)
            textBox4.Size = size
            Me.txtSearchByMemberName.TabIndex = 0
            Me.btnNew.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnNew.Image = CType(componentResourceManager.GetObject("btnNew.Image"), System.Drawing.Image)
            Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button7 As System.Windows.Forms.Button = Me.btnNew
            location = New System.Drawing.Point(514, 45)
            button7.Location = location
            Me.btnNew.Name = "btnNew"
            Dim button8 As System.Windows.Forms.Button = Me.btnNew
            size = New System.Drawing.Size(97, 40)
            button8.Size = size
            Me.btnNew.TabIndex = 1
            Me.btnNew.Text = "New"
            Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnNew.UseVisualStyleBackColor = True
            Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnClose.Image = CType(componentResourceManager.GetObject("btnClose.Image"), System.Drawing.Image)
            Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button9 As System.Windows.Forms.Button = Me.btnClose
            location = New System.Drawing.Point(710, 4)
            button9.Location = location
            Me.btnClose.Name = "btnClose"
            Dim button10 As System.Windows.Forms.Button = Me.btnClose
            size = New System.Drawing.Size(77, 36)
            button10.Size = size
            Me.btnClose.TabIndex = 5
            Me.btnClose.Text = "Close"
            Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnClose.UseVisualStyleBackColor = True
            Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel4.Controls.Add(Me.Label2)
            Me.Panel4.Controls.Add(Me.txtCardNo)
            Me.Panel4.Controls.Add(Me.txtAddress)
            Me.Panel4.Controls.Add(Me.Label8)
            Me.Panel4.Controls.Add(Me.chkActive)
            Me.Panel4.Controls.Add(Me.Label7)
            Me.Panel4.Controls.Add(Me.Label6)
            Me.Panel4.Controls.Add(Me.Label5)
            Me.Panel4.Controls.Add(Me.txtContactNo)
            Me.Panel4.Controls.Add(Me.txtMemberName)
            Me.Panel4.Controls.Add(Me.Label3)
            Me.Panel4.Controls.Add(Me.txtMemberID)
            Me.Panel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim panel3 As System.Windows.Forms.Panel = Me.Panel4
            location = New System.Drawing.Point(9, 45)
            panel3.Location = location
            Me.Panel4.Name = "Panel4"
            Dim panel4 As System.Windows.Forms.Panel = Me.Panel4
            size = New System.Drawing.Size(499, 200)
            panel4.Size = size
            Me.Panel4.TabIndex = 0
            Me.Label2.AutoSize = True
            Dim label3 As System.Windows.Forms.Label = Me.Label2
            location = New System.Drawing.Point(7, 65)
            label3.Location = location
            Me.Label2.Name = "Label2"
            Dim label4 As System.Windows.Forms.Label = Me.Label2
            size = New System.Drawing.Size(61, 15)
            label4.Size = size
            Me.Label2.TabIndex = 18
            Me.Label2.Text = "Card No. :"
            Me.txtCardNo.BackColor = System.Drawing.Color.White
            Me.txtCardNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox5 As System.Windows.Forms.TextBox = Me.txtCardNo
            location = New System.Drawing.Point(125, 65)
            textBox5.Location = location
            Me.txtCardNo.Name = "txtCardNo"
            Dim textBox6 As System.Windows.Forms.TextBox = Me.txtCardNo
            size = New System.Drawing.Size(227, 21)
            textBox6.Size = size
            Me.txtCardNo.TabIndex = 1
            Dim richTextBox As System.Windows.Forms.RichTextBox = Me.txtAddress
            location = New System.Drawing.Point(125, 92)
            richTextBox.Location = location
            Me.txtAddress.Name = "txtAddress"
            Me.txtAddress.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
            Dim richTextBox2 As System.Windows.Forms.RichTextBox = Me.txtAddress
            size = New System.Drawing.Size(360, 50)
            richTextBox2.Size = size
            Me.txtAddress.TabIndex = 2
            Me.txtAddress.Text = ""
            Me.Label8.AutoSize = True
            Dim label5 As System.Windows.Forms.Label = Me.Label8
            location = New System.Drawing.Point(7, 175)
            label5.Location = location
            Me.Label8.Name = "Label8"
            Dim label6 As System.Windows.Forms.Label = Me.Label8
            size = New System.Drawing.Size(47, 15)
            label6.Size = size
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
            Dim label7 As System.Windows.Forms.Label = Me.Label7
            location = New System.Drawing.Point(7, 148)
            label7.Location = location
            Me.Label7.Name = "Label7"
            Dim label8 As System.Windows.Forms.Label = Me.Label7
            size = New System.Drawing.Size(73, 15)
            label8.Size = size
            Me.Label7.TabIndex = 13
            Me.Label7.Text = "Contact No :"
            Me.Label6.AutoSize = True
            Dim label9 As System.Windows.Forms.Label = Me.Label6
            location = New System.Drawing.Point(7, 92)
            label9.Location = location
            Me.Label6.Name = "Label6"
            Dim label10 As System.Windows.Forms.Label = Me.Label6
            size = New System.Drawing.Size(57, 15)
            label10.Size = size
            Me.Label6.TabIndex = 12
            Me.Label6.Text = "Address :"
            Me.Label5.AutoSize = True
            Dim label11 As System.Windows.Forms.Label = Me.Label5
            location = New System.Drawing.Point(7, 38)
            label11.Location = location
            Me.Label5.Name = "Label5"
            Dim label12 As System.Windows.Forms.Label = Me.Label5
            size = New System.Drawing.Size(97, 15)
            label12.Size = size
            Me.Label5.TabIndex = 11
            Me.Label5.Text = "Member Name :"
            Me.txtContactNo.BackColor = System.Drawing.Color.White
            Me.txtContactNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox7 As System.Windows.Forms.TextBox = Me.txtContactNo
            location = New System.Drawing.Point(125, 148)
            textBox7.Location = location
            Me.txtContactNo.Name = "txtContactNo"
            Dim textBox8 As System.Windows.Forms.TextBox = Me.txtContactNo
            size = New System.Drawing.Size(157, 21)
            textBox8.Size = size
            Me.txtContactNo.TabIndex = 3
            Me.txtMemberName.BackColor = System.Drawing.Color.White
            Me.txtMemberName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox9 As System.Windows.Forms.TextBox = Me.txtMemberName
            location = New System.Drawing.Point(125, 38)
            textBox9.Location = location
            Me.txtMemberName.Name = "txtMemberName"
            Dim textBox10 As System.Windows.Forms.TextBox = Me.txtMemberName
            size = New System.Drawing.Size(297, 21)
            textBox10.Size = size
            Me.txtMemberName.TabIndex = 0
            Me.Label3.AutoSize = True
            Dim label13 As System.Windows.Forms.Label = Me.Label3
            location = New System.Drawing.Point(7, 14)
            label13.Location = location
            Me.Label3.Name = "Label3"
            Dim label14 As System.Windows.Forms.Label = Me.Label3
            size = New System.Drawing.Size(75, 15)
            label14.Size = size
            Me.Label3.TabIndex = 0
            Me.Label3.Text = "Member ID :"
            Me.txtMemberID.BackColor = System.Drawing.SystemColors.Control
            Me.txtMemberID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox11 As System.Windows.Forms.TextBox = Me.txtMemberID
            location = New System.Drawing.Point(125, 11)
            textBox11.Location = location
            Me.txtMemberID.Name = "txtMemberID"
            Me.txtMemberID.[ReadOnly] = True
            Dim textBox12 As System.Windows.Forms.TextBox = Me.txtMemberID
            size = New System.Drawing.Size(157, 21)
            textBox12.Size = size
            Me.txtMemberID.TabIndex = 6
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
            Me.dgw.Columns.AddRange(Me.Description, Me.Column3, Me.Column1, Me.Column2, Me.Column4, Me.Column7, Me.Column6)
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
            location = New System.Drawing.Point(9, 325)
            dataGridView.Location = location
            Me.dgw.MultiSelect = False
            Me.dgw.Name = "dgw"
            Me.dgw.[ReadOnly] = True
            Me.dgw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White
            dataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gainsboro
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgw.RowHeadersDefaultCellStyle = dataGridViewCellStyle4
            Me.dgw.RowHeadersWidth = 25
            Me.dgw.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White
            dataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gainsboro
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
            Me.dgw.RowsDefaultCellStyle = dataGridViewCellStyle5
            Me.dgw.RowTemplate.Height = 21
            Me.dgw.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgw.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Dim dataGridView2 As System.Windows.Forms.DataGridView = Me.dgw
            size = New System.Drawing.Size(779, 305)
            dataGridView2.Size = size
            Me.dgw.TabIndex = 1
            Me.Description.HeaderText = "Member ID"
            Me.Description.Name = "Description"
            Me.Description.[ReadOnly] = True
            Me.Column3.HeaderText = "Member Name"
            Me.Column3.Name = "Column3"
            Me.Column3.[ReadOnly] = True
            Me.Column1.HeaderText = "Card No."
            Me.Column1.Name = "Column1"
            Me.Column1.[ReadOnly] = True
            Me.Column2.HeaderText = "Address"
            Me.Column2.Name = "Column2"
            Me.Column2.[ReadOnly] = True
            Me.Column2.Width = 150
            Me.Column4.HeaderText = "Contact No."
            Me.Column4.Name = "Column4"
            Me.Column4.[ReadOnly] = True
            Me.Column7.HeaderText = "Active"
            Me.Column7.Name = "Column7"
            Me.Column7.[ReadOnly] = True
            dataGridViewCellStyle6.Format = "dd/MM/yyyy hh:mm:ss tt"
            Me.Column6.DefaultCellStyle = dataGridViewCellStyle6
            Me.Column6.HeaderText = "Registered Date"
            Me.Column6.Name = "Column6"
            Me.Column6.[ReadOnly] = True
            Me.Panel2.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Panel2.Controls.Add(Me.lblUser)
            Me.Panel2.Controls.Add(Me.Label1)
            Dim panel5 As System.Windows.Forms.Panel = Me.Panel2
            location = New System.Drawing.Point(9, 7)
            panel5.Location = location
            Me.Panel2.Name = "Panel2"
            Dim panel6 As System.Windows.Forms.Panel = Me.Panel2
            size = New System.Drawing.Size(695, 28)
            panel6.Size = size
            Me.Panel2.TabIndex = 0
            Me.lblUser.AutoSize = True
            Dim label15 As System.Windows.Forms.Label = Me.lblUser
            location = New System.Drawing.Point(86, 12)
            label15.Location = location
            Me.lblUser.Name = "lblUser"
            Dim label16 As System.Windows.Forms.Label = Me.lblUser
            size = New System.Drawing.Size(39, 13)
            label16.Size = size
            Me.lblUser.TabIndex = 5
            Me.lblUser.Text = "Label8"
            Me.lblUser.Visible = False
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label1.ForeColor = System.Drawing.Color.White
            Dim label17 As System.Windows.Forms.Label = Me.Label1
            location = New System.Drawing.Point(265, 1)
            label17.Location = location
            Me.Label1.Name = "Label1"
            Dim label18 As System.Windows.Forms.Label = Me.Label1
            size = New System.Drawing.Size(203, 24)
            label18.Size = size
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Member Registration"
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            size = New System.Drawing.Size(806, 647)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.Panel1)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MaximizeBox = False
            MyBase.MinimizeBox = False
            MyBase.Name = "frmLoyaltyMember"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
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
