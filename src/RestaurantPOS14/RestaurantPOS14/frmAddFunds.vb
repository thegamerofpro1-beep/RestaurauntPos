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
    Public Class frmAddFunds
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel1")>
        Private _Panel1 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel2")>
        Private _Panel2 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label1")>
        Private _Label1 As System.Windows.Forms.Label

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

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Timer1")>
        Private _Timer1 As System.Windows.Forms.Timer

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtID")>
        Private _txtID As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblUser")>
        Private _lblUser As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox2")>
        Private _GroupBox2 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtAmount")>
        Private _txtAmount As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtMemberName")>
        Private _txtMemberName As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtMemberID")>
        Private _txtMemberID As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("dtpEntryDate")>
        Private _dtpEntryDate As System.Windows.Forms.DateTimePicker

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label2")>
        Private _Label2 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label5")>
        Private _Label5 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label4")>
        Private _Label4 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label3")>
        Private _Label3 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnGetData")>
        Private _btnGetData As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("dgw")>
        Private _dgw As System.Windows.Forms.DataGridView

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox1")>
        Private _GroupBox1 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox4")>
        Private _GroupBox4 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Button2")>
        Private _Button2 As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtSearchByMemberName")>
        Private _txtSearchByMemberName As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Button1")>
        Private _Button1 As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column2")>
        Private _Column2 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column3")>
        Private _Column3 As System.Windows.Forms.DataGridViewTextBoxColumn

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

        Friend Overridable Property Timer1 As System.Windows.Forms.Timer
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Timer1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Timer)
                Me._Timer1 = value
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

        Friend Overridable Property dtpEntryDate As System.Windows.Forms.DateTimePicker
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._dtpEntryDate
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DateTimePicker)
                Me._dtpEntryDate = value
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

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            Call RestaurantPOS14.frmAddFunds.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmAddFunds.__ENCList
                If RestaurantPOS14.frmAddFunds.__ENCList.Count = RestaurantPOS14.frmAddFunds.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmAddFunds.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmAddFunds.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmAddFunds.__ENCList(num) = RestaurantPOS14.frmAddFunds.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmAddFunds.__ENCList.RemoveRange(num, RestaurantPOS14.frmAddFunds.__ENCList.Count - num)
                    RestaurantPOS14.frmAddFunds.__ENCList.Capacity = RestaurantPOS14.frmAddFunds.__ENCList.Count
                End If

                Call RestaurantPOS14.frmAddFunds.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Public Sub Reset()
            Me.txtMemberID.Text = ""
            Me.txtMemberName.Text = ""
            Me.txtAmount.Text = ""
            Me.txtSearchByMemberName.Text = ""
            Me.dtpEntryDate.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.DateAndTime.Now)
            Me.GetData()
            Me.btnDelete.Enabled = False
            If RestaurantPOS14.ModFunc.IsViewAllowed(Me.lblUser.Text, "VIP Member Card") Then
                Me.btnGetData.Enabled = True
            Else
                Me.btnGetData.Enabled = False
            End If

            If RestaurantPOS14.ModFunc.IsSaveAllowed(Me.lblUser.Text, "VIP Member Card") Then
                Me.btnSave.Enabled = True
            Else
                Me.btnSave.Enabled = False
            End If

            Me.btnUpdate.Enabled = False
            Me.dtpEntryDate.Enabled = True
        End Sub

        Public Sub GetData()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT RTRIM(Member.MemberID),RTRIM(Name),IsNull(sum(Credit)-sum(Debit),0) FROM Member left join MemberLedger on Member.MemberID=MemberLedger.MemberID group by name,Member.MemberID order by Name", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                Me.dgw.Rows.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Me.dgw.Rows.Add(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(0)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(1)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(2)))
                End While

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnSave_Click(sender As Object, e As System.EventArgs)
            If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.txtMemberID.Text)) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please retrieve Member info", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtMemberID.Focus()
                Return
            End If

            If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.txtAmount.Text)) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please enter Amount", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtAmount.Focus()
                Return
            End If

            Try
                Me.auto()
                RestaurantPOS14.ModFunc.LedgerSave(Me.dtpEntryDate.Value, Me.txtMemberName.Text, Me.txtID.Text, "Added the fund in Member's Account", 0D, New Decimal(Microsoft.VisualBasic.Conversion.Val(Me.txtAmount.Text)), Me.txtMemberID.Text, "Cash")
                RestaurantPOS14.ModFunc.LedgerSave(Me.dtpEntryDate.Value, "Cash", Me.txtID.Text, "Added the fund in Member's Account", New Decimal(Microsoft.VisualBasic.Conversion.Val(Me.txtAmount.Text)), 0D, Me.txtMemberID.Text, Me.txtMemberName.Text)
                RestaurantPOS14.ModFunc.MemberLedgerSave(Me.dtpEntryDate.Value, CInt(System.Math.Round(Microsoft.VisualBasic.Conversion.Val(Me.txtID.Text))), Me.txtID.Text, "Added the fund in Member's Account", 0D, New Decimal(Microsoft.VisualBasic.Conversion.Val(Me.txtAmount.Text)), Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(Me.txtMemberID.Text))
                Dim st As String = "added the fund in Member's Account having transaction id '" & Me.txtID.Text & "'"
                RestaurantPOS14.ModFunc.LogFunc(Me.lblUser.Text, st)
                Call System.Windows.Forms.MessageBox.Show("Successfully saved", "Entry", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                Me.btnSave.Enabled = False
                RestaurantPOS14.ModClasses.con.Close()
                Me.GetData()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnUpdate_Click(sender As Object, e As System.EventArgs)
            If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.txtMemberID.Text)) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please retrieve Member info", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtMemberID.Focus()
                Return
            End If

            If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.txtAmount.Text)) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please enter Amount", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtAmount.Focus()
                Return
            End If

            Try
                RestaurantPOS14.ModFunc.LedgerUpdate(Me.dtpEntryDate.Value, Me.txtMemberName.Text, 0D, New Decimal(Microsoft.VisualBasic.Conversion.Val(Me.txtAmount.Text)), Me.txtMemberID.Text, Me.txtID.Text, "Added the fund in Member's Account")
                RestaurantPOS14.ModFunc.LedgerUpdate(Me.dtpEntryDate.Value, "Cash", New Decimal(Microsoft.VisualBasic.Conversion.Val(Me.txtAmount.Text)), 0D, Me.txtMemberID.Text, Me.txtID.Text, "Added the fund in Member's Account")
                RestaurantPOS14.ModFunc.MemberLedgerUpdate(Me.dtpEntryDate.Value, CInt(System.Math.Round(Microsoft.VisualBasic.Conversion.Val(Me.txtID.Text))), 0D, New Decimal(Microsoft.VisualBasic.Conversion.Val(Me.txtAmount.Text)), Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(Me.txtMemberID.Text), Me.txtID.Text, "Added the fund in Member's Account")
                Dim st As String = "updated the Member's Account (Fund Entry) having id '" & Me.txtID.Text & "'"
                RestaurantPOS14.ModFunc.LogFunc(Me.lblUser.Text, st)
                Call System.Windows.Forms.MessageBox.Show("Successfully updated", "Entry", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                Me.btnUpdate.Enabled = False
                RestaurantPOS14.ModClasses.con.Close()
                Me.GetData()
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
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("delete from MemberLedger where id=" & RestaurantPOS14.Security.SqlInput.RequireInteger(Me.txtID.Text, "Record ID"))
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                If RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery() > 0 Then
                    RestaurantPOS14.ModFunc.LedgerDelete(Me.txtID.Text, "Added the fund in Member's Account")
                    RestaurantPOS14.ModFunc.MemberLedgerDelete(Me.txtID.Text, "Added the fund in Member's Account")
                    Dim st As String = "Deleted the Member's Account (Fund Entry) having id '" & Me.txtID.Text & "'"
                    RestaurantPOS14.ModFunc.LogFunc(Me.lblUser.Text, st)
                    Call System.Windows.Forms.MessageBox.Show("Successfully deleted", "Record", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    Me.GetData()
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

        Private Sub btnClose_Click(sender As Object, e As System.EventArgs)
            MyBase.Close()
        End Sub

        Private Sub btnNew_Click(sender As Object, e As System.EventArgs)
            Me.Reset()
        End Sub

        Private Sub frmMemberLedger_Load(sender As Object, e As System.EventArgs)
            Me.GetData()
        End Sub

        Private Sub dgw_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs)
            Try
                If Me.dgw.Rows.Count > 0 Then
                    If Me.dgw.SelectedRows.Count = 0 Then Return
                    Dim dataGridViewRow As System.Windows.Forms.DataGridViewRow = Me.dgw.SelectedRows(0)
                    Me.txtMemberID.Text = dataGridViewRow.Cells(CInt((0))).Value.ToString()
                    Me.txtMemberName.Text = dataGridViewRow.Cells(CInt((1))).Value.ToString()
                    Me.txtAmount.Focus()
                End If
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

        Private Sub auto()
            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
            RestaurantPOS14.ModClasses.con.Open()
            RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT MAX(ID) FROM MemberLedger")
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
        End Sub

        Private Sub btnGetData_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmAddFundsRecord.lblSet.Text = "Add Fund"
            RestaurantPOS14.My.MyProject.Forms.frmAddFundsRecord.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmAddFundsRecord.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmAddFundsRecord.ShowDialog()
        End Sub

        Private Sub txtSearchByMemberName_TextChanged(sender As Object, e As System.EventArgs)
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT RTRIM(Member.MemberID),RTRIM(Name),IsNull(sum(Credit)-sum(Debit),0) FROM Member left join MemberLedger on Member.MemberID=MemberLedger.MemberID where Name like N'%" & RestaurantPOS14.Security.SqlInput.EscapeLiteral(Me.txtSearchByMemberName.Text) & "%' group by name,Member.MemberID order by Name", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                Me.dgw.Rows.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Me.dgw.Rows.Add(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(0)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(1)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(2)))
                End While

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub Button1_Click(sender As Object, e As System.EventArgs)
            Me.txtSearchByMemberName.Text = ""
        End Sub

        Private Sub Button2_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.ModFunc.ExportExcel(Me.dgw)
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmAddFunds))
            Dim dataGridViewCellStyle As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.Button2 = New System.Windows.Forms.Button()
            Me.txtSearchByMemberName = New System.Windows.Forms.TextBox()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.btnNew = New System.Windows.Forms.Button()
            Me.btnGetData = New System.Windows.Forms.Button()
            Me.btnSave = New System.Windows.Forms.Button()
            Me.btnUpdate = New System.Windows.Forms.Button()
            Me.btnDelete = New System.Windows.Forms.Button()
            Me.dgw = New System.Windows.Forms.DataGridView()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.txtAmount = New System.Windows.Forms.TextBox()
            Me.lblUser = New System.Windows.Forms.Label()
            Me.txtMemberName = New System.Windows.Forms.TextBox()
            Me.txtMemberID = New System.Windows.Forms.TextBox()
            Me.dtpEntryDate = New System.Windows.Forms.DateTimePicker()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.btnClose = New System.Windows.Forms.Button()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtID = New System.Windows.Forms.TextBox()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel1.SuspendLayout()
            Me.GroupBox4.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox2.SuspendLayout()
            Me.Panel2.SuspendLayout()
            MyBase.SuspendLayout()
            Me.Panel1.BackColor = System.Drawing.Color.White
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.GroupBox4)
            Me.Panel1.Controls.Add(Me.GroupBox1)
            Me.Panel1.Controls.Add(Me.dgw)
            Me.Panel1.Controls.Add(Me.GroupBox2)
            Me.Panel1.Controls.Add(Me.btnClose)
            Me.Panel1.Controls.Add(Me.Panel2)
            Dim panel As System.Windows.Forms.Panel = Me.Panel1
            Dim location As System.Drawing.Point = New System.Drawing.Point(4, 3)
            panel.Location = location
            Me.Panel1.Name = "Panel1"
            Dim panel2 As System.Windows.Forms.Panel = Me.Panel1
            Dim size As System.Drawing.Size = New System.Drawing.Size(896, 528)
            panel2.Size = size
            Me.Panel1.TabIndex = 2
            Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox4.Controls.Add(Me.Button2)
            Me.GroupBox4.Controls.Add(Me.txtSearchByMemberName)
            Me.GroupBox4.Controls.Add(Me.Button1)
            Me.GroupBox4.ForeColor = System.Drawing.Color.Black
            Dim groupBox As System.Windows.Forms.GroupBox = Me.GroupBox4
            location = New System.Drawing.Point(345, 51)
            groupBox.Location = location
            Me.GroupBox4.Name = "GroupBox4"
            Dim groupBox2 As System.Windows.Forms.GroupBox = Me.GroupBox4
            size = New System.Drawing.Size(385, 60)
            groupBox2.Size = size
            Me.GroupBox4.TabIndex = 297
            Me.GroupBox4.TabStop = False
            Me.GroupBox4.Text = "Search By Member Name"
            Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
            Me.Button2.Image = CType(componentResourceManager.GetObject("Button2.Image"), System.Drawing.Image)
            Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button As System.Windows.Forms.Button = Me.Button2
            location = New System.Drawing.Point(270, 15)
            button.Location = location
            Me.Button2.Name = "Button2"
            Dim button2 As System.Windows.Forms.Button = Me.Button2
            size = New System.Drawing.Size(106, 38)
            button2.Size = size
            Me.Button2.TabIndex = 2
            Me.Button2.Text = "Export Excel"
            Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Button2.UseVisualStyleBackColor = True
            Dim textBox As System.Windows.Forms.TextBox = Me.txtSearchByMemberName
            location = New System.Drawing.Point(20, 24)
            textBox.Location = location
            Me.txtSearchByMemberName.Name = "txtSearchByMemberName"
            Dim textBox2 As System.Windows.Forms.TextBox = Me.txtSearchByMemberName
            size = New System.Drawing.Size(154, 20)
            textBox2.Size = size
            Me.txtSearchByMemberName.TabIndex = 0
            Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
            Me.Button1.Image = CType(componentResourceManager.GetObject("Button1.Image"), System.Drawing.Image)
            Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button3 As System.Windows.Forms.Button = Me.Button1
            location = New System.Drawing.Point(190, 15)
            button3.Location = location
            Me.Button1.Name = "Button1"
            Dim button4 As System.Windows.Forms.Button = Me.Button1
            size = New System.Drawing.Size(74, 38)
            button4.Size = size
            Me.Button1.TabIndex = 1
            Me.Button1.Text = "Reset"
            Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Button1.UseVisualStyleBackColor = True
            Me.GroupBox1.Controls.Add(Me.btnNew)
            Me.GroupBox1.Controls.Add(Me.btnGetData)
            Me.GroupBox1.Controls.Add(Me.btnSave)
            Me.GroupBox1.Controls.Add(Me.btnUpdate)
            Me.GroupBox1.Controls.Add(Me.btnDelete)
            Dim groupBox3 As System.Windows.Forms.GroupBox = Me.GroupBox1
            location = New System.Drawing.Point(783, 40)
            groupBox3.Location = location
            Me.GroupBox1.Name = "GroupBox1"
            Dim groupBox4 As System.Windows.Forms.GroupBox = Me.GroupBox1
            size = New System.Drawing.Size(107, 252)
            groupBox4.Size = size
            Me.GroupBox1.TabIndex = 296
            Me.GroupBox1.TabStop = False
            Me.btnNew.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnNew.Image = CType(componentResourceManager.GetObject("btnNew.Image"), System.Drawing.Image)
            Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button5 As System.Windows.Forms.Button = Me.btnNew
            location = New System.Drawing.Point(8, 14)
            button5.Location = location
            Me.btnNew.Name = "btnNew"
            Dim button6 As System.Windows.Forms.Button = Me.btnNew
            size = New System.Drawing.Size(90, 41)
            button6.Size = size
            Me.btnNew.TabIndex = 0
            Me.btnNew.Text = "New"
            Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnNew.UseVisualStyleBackColor = True
            Me.btnGetData.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnGetData.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnGetData.Image = CType(componentResourceManager.GetObject("btnGetData.Image"), System.Drawing.Image)
            Me.btnGetData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button7 As System.Windows.Forms.Button = Me.btnGetData
            location = New System.Drawing.Point(8, 201)
            button7.Location = location
            Me.btnGetData.Name = "btnGetData"
            Dim button8 As System.Windows.Forms.Button = Me.btnGetData
            size = New System.Drawing.Size(90, 41)
            button8.Size = size
            Me.btnGetData.TabIndex = 4
            Me.btnGetData.Text = " Get Data"
            Me.btnGetData.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnGetData.UseVisualStyleBackColor = True
            Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnSave.Image = CType(componentResourceManager.GetObject("btnSave.Image"), System.Drawing.Image)
            Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button9 As System.Windows.Forms.Button = Me.btnSave
            location = New System.Drawing.Point(8, 61)
            button9.Location = location
            Me.btnSave.Name = "btnSave"
            Dim button10 As System.Windows.Forms.Button = Me.btnSave
            size = New System.Drawing.Size(90, 41)
            button10.Size = size
            Me.btnSave.TabIndex = 1
            Me.btnSave.Text = "Save"
            Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnSave.UseVisualStyleBackColor = True
            Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnUpdate.Enabled = False
            Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnUpdate.Image = CType(componentResourceManager.GetObject("btnUpdate.Image"), System.Drawing.Image)
            Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button11 As System.Windows.Forms.Button = Me.btnUpdate
            location = New System.Drawing.Point(8, 107)
            button11.Location = location
            Me.btnUpdate.Name = "btnUpdate"
            Dim button12 As System.Windows.Forms.Button = Me.btnUpdate
            size = New System.Drawing.Size(90, 41)
            button12.Size = size
            Me.btnUpdate.TabIndex = 2
            Me.btnUpdate.Text = "Update"
            Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnUpdate.UseVisualStyleBackColor = True
            Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnDelete.Enabled = False
            Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnDelete.Image = CType(componentResourceManager.GetObject("btnDelete.Image"), System.Drawing.Image)
            Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button13 As System.Windows.Forms.Button = Me.btnDelete
            location = New System.Drawing.Point(8, 154)
            button13.Location = location
            Me.btnDelete.Name = "btnDelete"
            Dim button14 As System.Windows.Forms.Button = Me.btnDelete
            size = New System.Drawing.Size(90, 41)
            button14.Size = size
            Me.btnDelete.TabIndex = 3
            Me.btnDelete.Text = "Delete"
            Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnDelete.UseVisualStyleBackColor = True
            Me.dgw.AllowUserToAddRows = False
            Me.dgw.AllowUserToDeleteRows = False
            dataGridViewCellStyle.BackColor = System.Drawing.Color.FloralWhite
            Me.dgw.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle
            Me.dgw.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left
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
            Me.dgw.Columns.AddRange(Me.Column2, Me.Column3, Me.Column4)
            Me.dgw.Cursor = System.Windows.Forms.Cursors.Hand
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            dataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64)
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgw.DefaultCellStyle = dataGridViewCellStyle3
            Me.dgw.EnableHeadersVisualStyles = False
            Me.dgw.GridColor = System.Drawing.Color.White
            Dim dataGridView As System.Windows.Forms.DataGridView = Me.dgw
            location = New System.Drawing.Point(345, 117)
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
            dataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gainsboro
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
            Me.dgw.RowsDefaultCellStyle = dataGridViewCellStyle5
            Me.dgw.RowTemplate.Height = 21
            Me.dgw.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgw.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Dim dataGridView2 As System.Windows.Forms.DataGridView = Me.dgw
            size = New System.Drawing.Size(427, 404)
            dataGridView2.Size = size
            Me.dgw.TabIndex = 295
            Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox2.Controls.Add(Me.txtAmount)
            Me.GroupBox2.Controls.Add(Me.lblUser)
            Me.GroupBox2.Controls.Add(Me.txtMemberName)
            Me.GroupBox2.Controls.Add(Me.txtMemberID)
            Me.GroupBox2.Controls.Add(Me.dtpEntryDate)
            Me.GroupBox2.Controls.Add(Me.Label2)
            Me.GroupBox2.Controls.Add(Me.Label5)
            Me.GroupBox2.Controls.Add(Me.Label4)
            Me.GroupBox2.Controls.Add(Me.Label3)
            Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim groupBox5 As System.Windows.Forms.GroupBox = Me.GroupBox2
            location = New System.Drawing.Point(5, 41)
            groupBox5.Location = location
            Me.GroupBox2.Name = "GroupBox2"
            Dim groupBox6 As System.Windows.Forms.GroupBox = Me.GroupBox2
            size = New System.Drawing.Size(334, 131)
            groupBox6.Size = size
            Me.GroupBox2.TabIndex = 0
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Entry"
            Me.txtAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox3 As System.Windows.Forms.TextBox = Me.txtAmount
            location = New System.Drawing.Point(95, 97)
            textBox3.Location = location
            Me.txtAmount.Name = "txtAmount"
            Dim textBox4 As System.Windows.Forms.TextBox = Me.txtAmount
            size = New System.Drawing.Size(78, 21)
            textBox4.Size = size
            Me.txtAmount.TabIndex = 3
            Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.lblUser.AutoSize = True
            Dim label As System.Windows.Forms.Label = Me.lblUser
            location = New System.Drawing.Point(274, 25)
            label.Location = location
            Me.lblUser.Name = "lblUser"
            Dim label2 As System.Windows.Forms.Label = Me.lblUser
            size = New System.Drawing.Size(39, 13)
            label2.Size = size
            Me.lblUser.TabIndex = 293
            Me.lblUser.Text = "Label8"
            Me.lblUser.Visible = False
            Me.txtMemberName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox5 As System.Windows.Forms.TextBox = Me.txtMemberName
            location = New System.Drawing.Point(95, 70)
            textBox5.Location = location
            Me.txtMemberName.Name = "txtMemberName"
            Me.txtMemberName.[ReadOnly] = True
            Dim textBox6 As System.Windows.Forms.TextBox = Me.txtMemberName
            size = New System.Drawing.Size(218, 21)
            textBox6.Size = size
            Me.txtMemberName.TabIndex = 2
            Me.txtMemberID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox7 As System.Windows.Forms.TextBox = Me.txtMemberID
            location = New System.Drawing.Point(95, 44)
            textBox7.Location = location
            Me.txtMemberID.Name = "txtMemberID"
            Me.txtMemberID.[ReadOnly] = True
            Dim textBox8 As System.Windows.Forms.TextBox = Me.txtMemberID
            size = New System.Drawing.Size(115, 21)
            textBox8.Size = size
            Me.txtMemberID.TabIndex = 1
            Me.dtpEntryDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.dtpEntryDate.CustomFormat = "dd/MM/yyyy"
            Me.dtpEntryDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.dtpEntryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Dim dateTimePicker As System.Windows.Forms.DateTimePicker = Me.dtpEntryDate
            location = New System.Drawing.Point(95, 17)
            dateTimePicker.Location = location
            Me.dtpEntryDate.Name = "dtpEntryDate"
            Dim dateTimePicker2 As System.Windows.Forms.DateTimePicker = Me.dtpEntryDate
            size = New System.Drawing.Size(115, 21)
            dateTimePicker2.Size = size
            Me.dtpEntryDate.TabIndex = 0
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label3 As System.Windows.Forms.Label = Me.Label2
            location = New System.Drawing.Point(13, 68)
            label3.Location = location
            Me.Label2.Name = "Label2"
            Dim label4 As System.Windows.Forms.Label = Me.Label2
            size = New System.Drawing.Size(82, 13)
            label4.Size = size
            Me.Label2.TabIndex = 0
            Me.Label2.Text = "Member Name :"
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label5 As System.Windows.Forms.Label = Me.Label5
            location = New System.Drawing.Point(13, 44)
            label5.Location = location
            Me.Label5.Name = "Label5"
            Dim label6 As System.Windows.Forms.Label = Me.Label5
            size = New System.Drawing.Size(65, 13)
            label6.Size = size
            Me.Label5.TabIndex = 4
            Me.Label5.Text = "Member ID :"
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label7 As System.Windows.Forms.Label = Me.Label4
            location = New System.Drawing.Point(13, 97)
            label7.Location = location
            Me.Label4.Name = "Label4"
            Dim label8 As System.Windows.Forms.Label = Me.Label4
            size = New System.Drawing.Size(49, 13)
            label8.Size = size
            Me.Label4.TabIndex = 3
            Me.Label4.Text = "Amount :"
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label9 As System.Windows.Forms.Label = Me.Label3
            location = New System.Drawing.Point(13, 21)
            label9.Location = location
            Me.Label3.Name = "Label3"
            Dim label10 As System.Windows.Forms.Label = Me.Label3
            size = New System.Drawing.Size(36, 13)
            label10.Size = size
            Me.Label3.TabIndex = 2
            Me.Label3.Text = "Date :"
            Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnClose.Image = CType(componentResourceManager.GetObject("btnClose.Image"), System.Drawing.Image)
            Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button15 As System.Windows.Forms.Button = Me.btnClose
            location = New System.Drawing.Point(816, -3)
            button15.Location = location
            Me.btnClose.Name = "btnClose"
            Dim button16 As System.Windows.Forms.Button = Me.btnClose
            size = New System.Drawing.Size(74, 42)
            button16.Size = size
            Me.btnClose.TabIndex = 5
            Me.btnClose.Text = "Close"
            Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnClose.UseVisualStyleBackColor = True
            Me.Panel2.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Panel2.Controls.Add(Me.Label1)
            Me.Panel2.Controls.Add(Me.txtID)
            Dim panel3 As System.Windows.Forms.Panel = Me.Panel2
            location = New System.Drawing.Point(3, 4)
            panel3.Location = location
            Me.Panel2.Name = "Panel2"
            Dim panel4 As System.Windows.Forms.Panel = Me.Panel2
            size = New System.Drawing.Size(807, 35)
            panel4.Size = size
            Me.Panel2.TabIndex = 0
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label1.ForeColor = System.Drawing.Color.White
            Dim label11 As System.Windows.Forms.Label = Me.Label1
            location = New System.Drawing.Point(312, 4)
            label11.Location = location
            Me.Label1.Name = "Label1"
            Dim label12 As System.Windows.Forms.Label = Me.Label1
            size = New System.Drawing.Size(298, 24)
            label12.Size = size
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Member's Account (Add Fund)"
            Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox9 As System.Windows.Forms.TextBox = Me.txtID
            location = New System.Drawing.Point(181, 8)
            textBox9.Location = location
            Me.txtID.Name = "txtID"
            Dim textBox10 As System.Windows.Forms.TextBox = Me.txtID
            size = New System.Drawing.Size(71, 20)
            textBox10.Size = size
            Me.txtID.TabIndex = 292
            Me.txtID.Visible = False
            Me.Column2.HeaderText = "Member ID"
            Me.Column2.Name = "Column2"
            Me.Column2.[ReadOnly] = True
            Me.Column2.Width = 70
            Me.Column3.HeaderText = "Member Name"
            Me.Column3.Name = "Column3"
            Me.Column3.[ReadOnly] = True
            Me.Column3.Width = 230
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.Column4.DefaultCellStyle = dataGridViewCellStyle6
            Me.Column4.HeaderText = "Balance"
            Me.Column4.Name = "Column4"
            Me.Column4.[ReadOnly] = True
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            size = New System.Drawing.Size(903, 535)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.Panel1)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MaximizeBox = False
            MyBase.MinimizeBox = False
            MyBase.Name = "frmAddFunds"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Panel1.ResumeLayout(False)
            Me.GroupBox4.ResumeLayout(False)
            Me.GroupBox4.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            MyBase.ResumeLayout(False)
        End Sub
    End Class
End Namespace
