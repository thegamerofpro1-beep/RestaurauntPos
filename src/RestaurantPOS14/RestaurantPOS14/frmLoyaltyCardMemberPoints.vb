Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices
Imports RestaurantPOS14.My

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public Class frmLoyaltyCardMemberPoints
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("dgw")>
        Private _dgw As System.Windows.Forms.DataGridView

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox1")>
        Private _GroupBox1 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtMemberName")>
        Private _txtMemberName As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox2")>
        Private _GroupBox2 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtCardNo")>
        Private _txtCardNo As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Button3")>
        Private _Button3 As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnSearch")>
        Private _btnSearch As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnScanCard")>
        Private _btnScanCard As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnReset")>
        Private _btnReset As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblSet")>
        Private _lblSet As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column1")>
        Private _Column1 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column2")>
        Private _Column2 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column5")>
        Private _Column5 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column3")>
        Private _Column3 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column4")>
        Private _Column4 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnAddNewMember")>
        Private _btnAddNewMember As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblUser")>
        Private _lblUser As System.Windows.Forms.Label

        Private components As System.ComponentModel.IContainer

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

        Friend Overridable Property txtCardNo As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtCardNo
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.Windows.Forms.KeyEventHandler = AddressOf Me.txtMemberID_KeyDown
                If Me._txtCardNo IsNot Nothing Then
                    RemoveHandler Me._txtCardNo.KeyDown, value2
                End If

                Me._txtCardNo = value
                If Me._txtCardNo IsNot Nothing Then
                    AddHandler Me._txtCardNo.KeyDown, value2
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

        Friend Overridable Property btnSearch As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnSearch
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnSearch_Click
                If Me._btnSearch IsNot Nothing Then
                    RemoveHandler Me._btnSearch.Click, value2
                End If

                Me._btnSearch = value
                If Me._btnSearch IsNot Nothing Then
                    AddHandler Me._btnSearch.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnScanCard As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnScanCard
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.Button1_Click
                If Me._btnScanCard IsNot Nothing Then
                    RemoveHandler Me._btnScanCard.Click, value2
                End If

                Me._btnScanCard = value
                If Me._btnScanCard IsNot Nothing Then
                    AddHandler Me._btnScanCard.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnReset As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnReset
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnReset_Click
                If Me._btnReset IsNot Nothing Then
                    RemoveHandler Me._btnReset.Click, value2
                End If

                Me._btnReset = value
                If Me._btnReset IsNot Nothing Then
                    AddHandler Me._btnReset.Click, value2
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

        Friend Overridable Property btnAddNewMember As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnAddNewMember
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnAddNewMember_Click
                If Me._btnAddNewMember IsNot Nothing Then
                    RemoveHandler Me._btnAddNewMember.Click, value2
                End If

                Me._btnAddNewMember = value
                If Me._btnAddNewMember IsNot Nothing Then
                    AddHandler Me._btnAddNewMember.Click, value2
                End If
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

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            AddHandler MyBase.Load, AddressOf Me.frmMemberBalance_Load
            Call RestaurantPOS14.frmLoyaltyCardMemberPoints.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmLoyaltyCardMemberPoints.__ENCList
                If RestaurantPOS14.frmLoyaltyCardMemberPoints.__ENCList.Count = RestaurantPOS14.frmLoyaltyCardMemberPoints.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmLoyaltyCardMemberPoints.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmLoyaltyCardMemberPoints.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmLoyaltyCardMemberPoints.__ENCList(num) = RestaurantPOS14.frmLoyaltyCardMemberPoints.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmLoyaltyCardMemberPoints.__ENCList.RemoveRange(num, RestaurantPOS14.frmLoyaltyCardMemberPoints.__ENCList.Count - num)
                    RestaurantPOS14.frmLoyaltyCardMemberPoints.__ENCList.Capacity = RestaurantPOS14.frmLoyaltyCardMemberPoints.__ENCList.Count
                End If

                Call RestaurantPOS14.frmLoyaltyCardMemberPoints.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Public Sub Reset()
            Me.txtCardNo.Text = ""
            Me.txtMemberName.Text = ""
            Me.GetData()
        End Sub

        Public Sub GetData()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT LoyaltyMember.MemberID,RTRIM(Name),RTRIM(CardNo),RTRIM(ContactNo),IsNull(sum(PointsEarned)-sum(PointsRedeem),0) FROM LoyaltyMember Left join LoyaltyMemberLedgerBook on LoyaltyMember.MemberID=LoyaltyMemberLedgerBook.MemberID group by LoyaltyMember.MemberID,name,ContactNo,CardNo order by Name", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                Me.dgw.Rows.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Me.dgw.Rows.Add(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(0)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(1)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(2)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(3)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(4)))
                End While

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub frmMemberBalance_Load(sender As Object, e As System.EventArgs)
            Me.GetData()
        End Sub

        Private Sub Button3_Click(sender As Object, e As System.EventArgs)
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT LoyaltyMember.MemberID,RTRIM(Name),RTRIM(CardNo),RTRIM(ContactNo),IsNull(sum(PointsEarned)-sum(PointsRedeem),0) FROM LoyaltyMember Left join LoyaltyMemberLedgerBook on LoyaltyMember.MemberID=LoyaltyMemberLedgerBook.MemberID where Name like N'%" & Me.txtMemberName.Text & "%' group by LoyaltyMember.MemberID,name,ContactNo,CardNo order by Name", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                Me.dgw.Rows.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Me.dgw.Rows.Add(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(0)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(1)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(2)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(3)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(4)))
                End While

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnSearch_Click(sender As Object, e As System.EventArgs)
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT LoyaltyMember.MemberID,RTRIM(Name),RTRIM(CardNo),RTRIM(ContactNo),IsNull(sum(PointsEarned)-sum(PointsRedeem),0) FROM LoyaltyMember Left join LoyaltyMemberLedgerBook on LoyaltyMember.MemberID=LoyaltyMemberLedgerBook.MemberID where LoyaltyMember.CardNo like N'%" & Me.txtCardNo.Text & "%' group by LoyaltyMember.MemberID,name,ContactNo,CardNo order by Name", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                Me.dgw.Rows.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Me.dgw.Rows.Add(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(0)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(1)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(2)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(3)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(4)))
                End While

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub txtMemberID_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs)
            Try
                If e.KeyCode = System.Windows.Forms.Keys.[Return] Then
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT LoyaltyMember.MemberID,RTRIM(Name),RTRIM(CardNo),RTRIM(ContactNo),IsNull(sum(PointsEarned)-sum(PointsRedeem),0) FROM LoyaltyMember Left join LoyaltyMemberLedgerBook on LoyaltyMember.MemberID=LoyaltyMemberLedgerBook.MemberID where LoyaltyMember.CardNo like N'%" & Me.txtCardNo.Text & "%' group by LoyaltyMember.MemberID,name,ContactNo,CardNo order by Name", RestaurantPOS14.ModClasses.con)
                    RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                    Me.dgw.Rows.Clear()
                    While RestaurantPOS14.ModClasses.rdr.Read()
                        Me.dgw.Rows.Add(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(0)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(1)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(2)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(3)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(4)))
                    End While

                    RestaurantPOS14.ModClasses.con.Close()
                End If
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub Button1_Click(sender As Object, e As System.EventArgs)
            Me.txtCardNo.Focus()
        End Sub

        Private Sub btnReset_Click(sender As Object, e As System.EventArgs)
            Me.Reset()
        End Sub

        Private Sub dgw_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs)
            Try
                If Me.dgw.Rows.Count > 0 Then
                    If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "Dine In Billing", TextCompare:=False) = 0 Then
                        Dim dataGridViewRow As System.Windows.Forms.DataGridViewRow = Me.dgw.SelectedRows(0)
                        MyBase.Hide()
                        Call RestaurantPOS14.My.MyProject.Forms.frmCards_POS.Hide()
                        Call RestaurantPOS14.My.MyProject.Forms.frmPOS.Show()
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.lblMemberID.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(dataGridViewRow.Cells(CInt((0))).Value)
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtLP.[ReadOnly] = False
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtLP.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(dataGridViewRow.Cells(CInt((4))).Value)
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.lblMemberType.Text = "Loyalty Member"
                        Call RestaurantPOS14.My.MyProject.Forms.frmPOS.LoyaltyKOTCalc()
                    End If

                    If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "Split Bill", TextCompare:=False) = 0 Then
                        Dim dataGridViewRow2 As System.Windows.Forms.DataGridViewRow = Me.dgw.SelectedRows(0)
                        MyBase.Hide()
                        Call RestaurantPOS14.My.MyProject.Forms.frmCards_POS.Hide()
                        Call RestaurantPOS14.My.MyProject.Forms.frmBillSplit.Show()
                        RestaurantPOS14.My.MyProject.Forms.frmBillSplit.lblMemberID.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(dataGridViewRow2.Cells(CInt((0))).Value)
                        RestaurantPOS14.My.MyProject.Forms.frmBillSplit.txtLP.[ReadOnly] = False
                        RestaurantPOS14.My.MyProject.Forms.frmBillSplit.txtLP.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(dataGridViewRow2.Cells(CInt((4))).Value)
                        RestaurantPOS14.My.MyProject.Forms.frmBillSplit.lblMemberType.Text = "Loyalty Member"
                        Call RestaurantPOS14.My.MyProject.Forms.frmBillSplit.LoyaltyKOTCalc()
                    End If

                    If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "Home Delivery", TextCompare:=False) = 0 Then
                        Dim dataGridViewRow3 As System.Windows.Forms.DataGridViewRow = Me.dgw.SelectedRows(0)
                        MyBase.Hide()
                        Call RestaurantPOS14.My.MyProject.Forms.frmCards_POS.Hide()
                        Call RestaurantPOS14.My.MyProject.Forms.frmPOS.Show()
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.lblMemberID.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(dataGridViewRow3.Cells(CInt((0))).Value)
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtLP2.[ReadOnly] = False
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtLP2.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(dataGridViewRow3.Cells(CInt((4))).Value)
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.lblMemberType.Text = "Loyalty Member"
                        Call RestaurantPOS14.My.MyProject.Forms.frmPOS.LoyaltyHDCalc()
                    End If

                    If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "Take Away", TextCompare:=False) = 0 Then
                        Dim dataGridViewRow4 As System.Windows.Forms.DataGridViewRow = Me.dgw.SelectedRows(0)
                        MyBase.Hide()
                        Call RestaurantPOS14.My.MyProject.Forms.frmCards_POS.Hide()
                        Call RestaurantPOS14.My.MyProject.Forms.frmPOS.Show()
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.lblMemberID.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(dataGridViewRow4.Cells(CInt((0))).Value)
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtLP1.[ReadOnly] = False
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtLP1.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(dataGridViewRow4.Cells(CInt((4))).Value)
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.lblMemberType.Text = "Loyalty Member"
                        Call RestaurantPOS14.My.MyProject.Forms.frmPOS.LoyaltyTACalc()
                    End If

                    If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "Express Billing", TextCompare:=False) = 0 Then
                        Dim dataGridViewRow5 As System.Windows.Forms.DataGridViewRow = Me.dgw.SelectedRows(0)
                        MyBase.Hide()
                        Call RestaurantPOS14.My.MyProject.Forms.frmCards_POS.Hide()
                        Call RestaurantPOS14.My.MyProject.Forms.frmPOS.Show()
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.lblMemberID.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(dataGridViewRow5.Cells(CInt((0))).Value)
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtLP3.[ReadOnly] = False
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtLP3.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(dataGridViewRow5.Cells(CInt((4))).Value)
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.lblMemberType.Text = "Loyalty Member"
                        Call RestaurantPOS14.My.MyProject.Forms.frmPOS.LoyaltyEBCalc()
                    End If
                End If

                Me.lblSet.Text = ""
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

        Private Sub btnAddNewMember_Click(sender As Object, e As System.EventArgs)
            Call RestaurantPOS14.My.MyProject.Forms.frmLoyaltyMember.Reset()
            RestaurantPOS14.My.MyProject.Forms.frmLoyaltyMember.lblUser.Text = Me.lblUser.Text
            RestaurantPOS14.My.MyProject.Forms.frmLoyaltyMember.lblSet.Text = "POS"
            RestaurantPOS14.My.MyProject.Forms.frmLoyaltyMember.btnUpdate.Visible = False
            RestaurantPOS14.My.MyProject.Forms.frmLoyaltyMember.btnDelete.Visible = False
            Call RestaurantPOS14.My.MyProject.Forms.frmLoyaltyMember.ShowDialog()
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmLoyaltyCardMemberPoints))
            Me.dgw = New System.Windows.Forms.DataGridView()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.lblSet = New System.Windows.Forms.Label()
            Me.Button3 = New System.Windows.Forms.Button()
            Me.txtMemberName = New System.Windows.Forms.TextBox()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.btnSearch = New System.Windows.Forms.Button()
            Me.txtCardNo = New System.Windows.Forms.TextBox()
            Me.btnScanCard = New System.Windows.Forms.Button()
            Me.btnReset = New System.Windows.Forms.Button()
            Me.btnAddNewMember = New System.Windows.Forms.Button()
            Me.lblUser = New System.Windows.Forms.Label()
            CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            MyBase.SuspendLayout()
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
            dataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SkyBlue
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgw.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2
            Me.dgw.ColumnHeadersHeight = 40
            Me.dgw.Columns.AddRange(Me.Column1, Me.Column2, Me.Column5, Me.Column3, Me.Column4)
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
            Dim location As System.Drawing.Point = New System.Drawing.Point(1, 79)
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
            dataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gainsboro
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
            Me.dgw.RowsDefaultCellStyle = dataGridViewCellStyle5
            Me.dgw.RowTemplate.Height = 44
            Me.dgw.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgw.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Dim dataGridView2 As System.Windows.Forms.DataGridView = Me.dgw
            Dim size As System.Drawing.Size = New System.Drawing.Size(941, 460)
            dataGridView2.Size = size
            Me.dgw.TabIndex = 41
            Me.Column1.FillWeight = 76.53061F
            Me.Column1.HeaderText = "Member ID"
            Me.Column1.Name = "Column1"
            Me.Column1.[ReadOnly] = True
            Me.Column2.FillWeight = 162.7349F
            Me.Column2.HeaderText = "Member Name"
            Me.Column2.Name = "Column2"
            Me.Column2.[ReadOnly] = True
            Me.Column5.HeaderText = "Card No."
            Me.Column5.Name = "Column5"
            Me.Column5.[ReadOnly] = True
            Me.Column3.FillWeight = 69.71115F
            Me.Column3.HeaderText = "Contact No."
            Me.Column3.Name = "Column3"
            Me.Column3.[ReadOnly] = True
            Me.Column4.FillWeight = 91.02331F
            Me.Column4.HeaderText = "Balance"
            Me.Column4.Name = "Column4"
            Me.Column4.[ReadOnly] = True
            Me.GroupBox1.Controls.Add(Me.lblSet)
            Me.GroupBox1.Controls.Add(Me.Button3)
            Me.GroupBox1.Controls.Add(Me.txtMemberName)
            Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim groupBox As System.Windows.Forms.GroupBox = Me.GroupBox1
            location = New System.Drawing.Point(6, 5)
            groupBox.Location = location
            Me.GroupBox1.Name = "GroupBox1"
            Dim groupBox2 As System.Windows.Forms.GroupBox = Me.GroupBox1
            size = New System.Drawing.Size(300, 68)
            groupBox2.Size = size
            Me.GroupBox1.TabIndex = 42
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Search By Member Name"
            Me.lblSet.AutoSize = True
            Dim label As System.Windows.Forms.Label = Me.lblSet
            location = New System.Drawing.Point(227, 4)
            label.Location = location
            Me.lblSet.Name = "lblSet"
            Dim label2 As System.Windows.Forms.Label = Me.lblSet
            size = New System.Drawing.Size(34, 20)
            label2.Size = size
            Me.lblSet.TabIndex = 399
            Me.lblSet.Text = "Set"
            Me.lblSet.Visible = False
            Me.Button3.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Button3.FlatAppearance.BorderSize = 0
            Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Dim button As System.Windows.Forms.Button = Me.Button3
            location = New System.Drawing.Point(190, 29)
            button.Location = location
            Me.Button3.Name = "Button3"
            Dim button2 As System.Windows.Forms.Button = Me.Button3
            size = New System.Drawing.Size(99, 26)
            button2.Size = size
            Me.Button3.TabIndex = 398
            Me.Button3.Text = "Search"
            Me.Button3.UseVisualStyleBackColor = False
            Me.txtMemberName.BackColor = System.Drawing.Color.White
            Me.txtMemberName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox As System.Windows.Forms.TextBox = Me.txtMemberName
            location = New System.Drawing.Point(22, 29)
            textBox.Location = location
            Me.txtMemberName.Name = "txtMemberName"
            Dim textBox2 As System.Windows.Forms.TextBox = Me.txtMemberName
            size = New System.Drawing.Size(162, 26)
            textBox2.Size = size
            Me.txtMemberName.TabIndex = 0
            Me.GroupBox2.Controls.Add(Me.btnSearch)
            Me.GroupBox2.Controls.Add(Me.txtCardNo)
            Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim groupBox3 As System.Windows.Forms.GroupBox = Me.GroupBox2
            location = New System.Drawing.Point(312, 5)
            groupBox3.Location = location
            Me.GroupBox2.Name = "GroupBox2"
            Dim groupBox4 As System.Windows.Forms.GroupBox = Me.GroupBox2
            size = New System.Drawing.Size(277, 68)
            groupBox4.Size = size
            Me.GroupBox2.TabIndex = 43
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Search By Card No."
            Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.btnSearch.FlatAppearance.BorderSize = 0
            Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Dim button3 As System.Windows.Forms.Button = Me.btnSearch
            location = New System.Drawing.Point(170, 29)
            button3.Location = location
            Me.btnSearch.Name = "btnSearch"
            Dim button4 As System.Windows.Forms.Button = Me.btnSearch
            size = New System.Drawing.Size(99, 26)
            button4.Size = size
            Me.btnSearch.TabIndex = 397
            Me.btnSearch.Text = "Search"
            Me.btnSearch.UseVisualStyleBackColor = False
            Me.txtCardNo.BackColor = System.Drawing.Color.White
            Me.txtCardNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox3 As System.Windows.Forms.TextBox = Me.txtCardNo
            location = New System.Drawing.Point(6, 29)
            textBox3.Location = location
            Me.txtCardNo.Name = "txtCardNo"
            Dim textBox4 As System.Windows.Forms.TextBox = Me.txtCardNo
            size = New System.Drawing.Size(158, 26)
            textBox4.Size = size
            Me.txtCardNo.TabIndex = 0
            Me.btnScanCard.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.btnScanCard.FlatAppearance.BorderSize = 0
            Me.btnScanCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnScanCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnScanCard.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Dim button5 As System.Windows.Forms.Button = Me.btnScanCard
            location = New System.Drawing.Point(595, 12)
            button5.Location = location
            Me.btnScanCard.Name = "btnScanCard"
            Dim button6 As System.Windows.Forms.Button = Me.btnScanCard
            size = New System.Drawing.Size(99, 61)
            button6.Size = size
            Me.btnScanCard.TabIndex = 397
            Me.btnScanCard.Text = "Scan Card"
            Me.btnScanCard.UseVisualStyleBackColor = False
            Me.btnReset.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.btnReset.FlatAppearance.BorderSize = 0
            Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Dim button7 As System.Windows.Forms.Button = Me.btnReset
            location = New System.Drawing.Point(700, 12)
            button7.Location = location
            Me.btnReset.Name = "btnReset"
            Dim button8 As System.Windows.Forms.Button = Me.btnReset
            size = New System.Drawing.Size(99, 61)
            button8.Size = size
            Me.btnReset.TabIndex = 398
            Me.btnReset.Text = "Reset"
            Me.btnReset.UseVisualStyleBackColor = False
            Me.btnAddNewMember.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.btnAddNewMember.FlatAppearance.BorderSize = 0
            Me.btnAddNewMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnAddNewMember.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnAddNewMember.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Dim button9 As System.Windows.Forms.Button = Me.btnAddNewMember
            location = New System.Drawing.Point(805, 12)
            button9.Location = location
            Me.btnAddNewMember.Name = "btnAddNewMember"
            Dim button10 As System.Windows.Forms.Button = Me.btnAddNewMember
            size = New System.Drawing.Size(99, 61)
            button10.Size = size
            Me.btnAddNewMember.TabIndex = 402
            Me.btnAddNewMember.Text = "Add New Member"
            Me.btnAddNewMember.UseVisualStyleBackColor = False
            Me.lblUser.AutoSize = True
            Dim label3 As System.Windows.Forms.Label = Me.lblUser
            location = New System.Drawing.Point(903, 12)
            label3.Location = location
            Me.lblUser.Name = "lblUser"
            Dim label4 As System.Windows.Forms.Label = Me.lblUser
            size = New System.Drawing.Size(39, 13)
            label4.Size = size
            Me.lblUser.TabIndex = 403
            Me.lblUser.Text = "Label8"
            Me.lblUser.Visible = False
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            size = New System.Drawing.Size(948, 540)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.lblUser)
            MyBase.Controls.Add(Me.btnAddNewMember)
            MyBase.Controls.Add(Me.btnReset)
            MyBase.Controls.Add(Me.btnScanCard)
            MyBase.Controls.Add(Me.GroupBox2)
            MyBase.Controls.Add(Me.GroupBox1)
            MyBase.Controls.Add(Me.dgw)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MaximizeBox = False
            MyBase.MinimizeBox = False
            MyBase.Name = "frmLoyaltyCardMemberPoints"
            Me.Text = "Loyalty Card Members List"
            MyBase.WindowState = System.Windows.Forms.FormWindowState.Maximized
            CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            MyBase.ResumeLayout(False)
            MyBase.PerformLayout()
        End Sub
    End Class
End Namespace
