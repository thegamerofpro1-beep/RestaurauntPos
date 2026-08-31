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
    Public Class frmCreditCustomerLedger
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel1")>
        Private _Panel1 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel2")>
        Private _Panel2 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label1")>
        Private _Label1 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnClose")>
        Private _btnClose As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnReset")>
        Private _btnReset As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox3")>
        Private _GroupBox3 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Timer1")>
        Private _Timer1 As System.Windows.Forms.Timer

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox2")>
        Private _GroupBox2 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("dtpDateTo")>
        Private _dtpDateTo As System.Windows.Forms.DateTimePicker

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label2")>
        Private _Label2 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label4")>
        Private _Label4 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("dtpDateFrom")>
        Private _dtpDateFrom As System.Windows.Forms.DateTimePicker

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Button1")>
        Private _Button1 As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label3")>
        Private _Label3 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox1")>
        Private _GroupBox1 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Button2")>
        Private _Button2 As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DateTimePicker1")>
        Private _DateTimePicker1 As System.Windows.Forms.DateTimePicker

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label6")>
        Private _Label6 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label7")>
        Private _Label7 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DateTimePicker2")>
        Private _DateTimePicker2 As System.Windows.Forms.DateTimePicker

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnNavigation")>
        Private _btnNavigation As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtCustomerName")>
        Private _txtCustomerName As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label5")>
        Private _Label5 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtCustomerID")>
        Private _txtCustomerID As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Timer2")>
        Private _Timer2 As System.Windows.Forms.Timer

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Button3")>
        Private _Button3 As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtCustID")>
        Private _txtCustID As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Timer3")>
        Private _Timer3 As System.Windows.Forms.Timer

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Timer4")>
        Private _Timer4 As System.Windows.Forms.Timer

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblUser")>
        Private _lblUser As System.Windows.Forms.Label

        Private a As String

        Private b As String

        Private c As String

        Private OBC As Double

        Private OBB As Double

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

        Friend Overridable Property dtpDateTo As System.Windows.Forms.DateTimePicker
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._dtpDateTo
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DateTimePicker)
                Me._dtpDateTo = value
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

        Friend Overridable Property dtpDateFrom As System.Windows.Forms.DateTimePicker
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._dtpDateFrom
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DateTimePicker)
                Me._dtpDateFrom = value
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

        Friend Overridable Property DateTimePicker1 As System.Windows.Forms.DateTimePicker
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._DateTimePicker1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DateTimePicker)
                Me._DateTimePicker1 = value
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

        Friend Overridable Property DateTimePicker2 As System.Windows.Forms.DateTimePicker
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._DateTimePicker2
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DateTimePicker)
                Me._DateTimePicker2 = value
            End Set
        End Property

        Friend Overridable Property btnNavigation As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnNavigation
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnNavigation_Click
                If Me._btnNavigation IsNot Nothing Then
                    RemoveHandler Me._btnNavigation.Click, value2
                End If

                Me._btnNavigation = value
                If Me._btnNavigation IsNot Nothing Then
                    AddHandler Me._btnNavigation.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property txtCustomerName As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtCustomerName
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtCustomerName = value
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

        Friend Overridable Property txtCustomerID As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtCustomerID
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtCustomerID = value
            End Set
        End Property

        Friend Overridable Property Timer2 As System.Windows.Forms.Timer
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Timer2
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Timer)
                Me._Timer2 = value
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

        Friend Overridable Property txtCustID As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtCustID
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtCustID = value
            End Set
        End Property

        Friend Overridable Property Timer3 As System.Windows.Forms.Timer
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Timer3
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Timer)
                Me._Timer3 = value
            End Set
        End Property

        Friend Overridable Property Timer4 As System.Windows.Forms.Timer
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Timer4
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Timer)
                Dim value2 As System.EventHandler = AddressOf Me.Timer4_Tick
                If Me._Timer4 IsNot Nothing Then
                    RemoveHandler Me._Timer4.Tick, value2
                End If

                Me._Timer4 = value
                If Me._Timer4 IsNot Nothing Then
                    AddHandler Me._Timer4.Tick, value2
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
            Call RestaurantPOS14.frmCreditCustomerLedger.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmCreditCustomerLedger.__ENCList
                If RestaurantPOS14.frmCreditCustomerLedger.__ENCList.Count = RestaurantPOS14.frmCreditCustomerLedger.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmCreditCustomerLedger.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmCreditCustomerLedger.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmCreditCustomerLedger.__ENCList(num) = RestaurantPOS14.frmCreditCustomerLedger.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmCreditCustomerLedger.__ENCList.RemoveRange(num, RestaurantPOS14.frmCreditCustomerLedger.__ENCList.Count - num)
                    RestaurantPOS14.frmCreditCustomerLedger.__ENCList.Capacity = RestaurantPOS14.frmCreditCustomerLedger.__ENCList.Count
                End If

                Call RestaurantPOS14.frmCreditCustomerLedger.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Public Sub Reset()
            Me.dtpDateFrom.Value = Microsoft.VisualBasic.DateAndTime.Today
            Me.dtpDateTo.Value = Microsoft.VisualBasic.DateAndTime.Today
            Me.DateTimePicker1.Value = Microsoft.VisualBasic.DateAndTime.Today
            Me.DateTimePicker2.Value = Microsoft.VisualBasic.DateAndTime.Today
            Me.txtCustomerID.Text = ""
            Me.txtCustomerName.Text = ""
            If RestaurantPOS14.ModFunc.IsViewAllowed(Me.lblUser.Text, "Credit Customer") Then
                Me.GroupBox1.Enabled = True
                Me.GroupBox2.Enabled = True
                Me.Button3.Enabled = True
            Else
                Me.GroupBox1.Enabled = False
                Me.GroupBox2.Enabled = False
                Me.Button3.Enabled = False
            End If
        End Sub

        Private Sub btnReset_Click(sender As Object, e As System.EventArgs)
            Me.Reset()
        End Sub

        Private Sub btnClose_Click_1(sender As Object, e As System.EventArgs)
            MyBase.Close()
        End Sub

        Private Sub Button1_Click(sender As Object, e As System.EventArgs)
            Try
                If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.txtCustomerID.Text)) = 0 Then
                    Call System.Windows.Forms.MessageBox.Show("Please retrieve CreditCustomer info", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Me.txtCustomerID.Focus()
                    Return
                End If

                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select PartyID from LedgerBook where PartyID=@d3")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Me.txtCustomerID.Text)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If Not RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Sorry...No record found", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select CASE WHEN IsNULL((Sum(Debit)-Sum(Credit)),0)<= 0 THEN 0 ELSE IsNULL((Sum(Debit)-Sum(Credit)),0) END AS Debit,CASE WHEN IsNULL((Sum(Credit)-Sum(Debit)),0)<= 0 THEN 0 ELSE IsNULL((Sum(Credit)-Sum(debit)),0) END AS Credit from LedgerBook where PartyID=@d1 and CAST(Date AS DATE) <= CAST(@d2 AS DATE)")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtCustomerID.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.dtpDateFrom.Value.[Date].AddDays(-1.0)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.OBB = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                    Me.OBC = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(1))
                End If

                RestaurantPOS14.ModClasses.con.Close()
                MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Me.Timer4.Enabled = True
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Select Date, LedgerNo, Label, Credit, Debit,AccLedger from LedgerBook where Date >=@d1 and Date < @d2 and PartyID=@d3 order by ID,Date,LedgerNo", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.dtpDateFrom.Value.[Date]
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.dtpDateTo.Value.[Date].AddDays(1.0)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Me.txtCustomerID.Text)
                RestaurantPOS14.ModClasses.adp = New System.Data.SqlClient.SqlDataAdapter(RestaurantPOS14.ModClasses.cmd)
                RestaurantPOS14.ModClasses.dtable = New System.Data.DataTable()
                RestaurantPOS14.ModClasses.adp.Fill(RestaurantPOS14.ModClasses.dtable)
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.ds = New System.Data.DataSet()
                RestaurantPOS14.ModClasses.ds.Tables.Add(RestaurantPOS14.ModClasses.dtable)
                RestaurantPOS14.ModClasses.ds.WriteXmlSchema("CreditCustomerLedgerNewX2.xml")
                Dim rptCreditCustomerLedger2 As RestaurantPOS14.rptCreditCustomerLedger = New RestaurantPOS14.rptCreditCustomerLedger()
                rptCreditCustomerLedger2.SetDataSource(RestaurantPOS14.ModClasses.ds)
                rptCreditCustomerLedger2.SetParameterValue("p1", Me.dtpDateFrom.Value.[Date])
                rptCreditCustomerLedger2.SetParameterValue("p2", Me.dtpDateTo.Value.[Date])
                rptCreditCustomerLedger2.SetParameterValue("p3", Me.txtCustomerID.Text)
                rptCreditCustomerLedger2.SetParameterValue("p4", Me.txtCustomerName.Text)
                rptCreditCustomerLedger2.SetParameterValue("OBC", Me.OBC)
                rptCreditCustomerLedger2.SetParameterValue("OBB", Me.OBB)
                RestaurantPOS14.My.MyProject.Forms.frmReport.CrystalReportViewer1.ReportSource = rptCreditCustomerLedger2
                Call RestaurantPOS14.My.MyProject.Forms.frmReport.ShowDialog()
                rptCreditCustomerLedger2.Close()
                rptCreditCustomerLedger2.Dispose()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnNavigation_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmCreditCustomersList.lblSet.Text = "Customer Ledger"
            Call RestaurantPOS14.My.MyProject.Forms.frmCreditCustomersList.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmCreditCustomersList.ShowDialog()
        End Sub

        Private Sub Button2_Click(sender As Object, e As System.EventArgs)
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select CASE WHEN IsNULL((Sum(Debit)-Sum(Credit)),0)<= 0 THEN 0 ELSE IsNULL((Sum(Debit)-Sum(Credit)),0) END AS Debit,CASE WHEN IsNULL((Sum(Credit)-Sum(Debit)),0)<= 0 THEN 0 ELSE IsNULL((Sum(Credit)-Sum(debit)),0) END AS Credit from LedgerBook where CAST(Date AS DATE) <= CAST(@d2 AS DATE) and PartyID like '%CC%'")
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.DateTimePicker2.Value.[Date].AddDays(-1.0)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.OBB = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                    Me.OBC = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(1))
                End If

                RestaurantPOS14.ModClasses.con.Close()
                MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Me.Timer4.Enabled = True
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Select Date, LedgerNo, Label, Credit, Debit,LedgerBook.Name,AccLedger from LedgerBook,CreditCustomer where LedgerBook.PartyID=CreditCustomer.CreditCustomerID and Date >=@d1 and Date < @d2 order by ID,Date,LedgerNo", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.DateTimePicker2.Value.[Date]
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.DateTimePicker1.Value.[Date].AddDays(1.0)
                RestaurantPOS14.ModClasses.adp = New System.Data.SqlClient.SqlDataAdapter(RestaurantPOS14.ModClasses.cmd)
                RestaurantPOS14.ModClasses.dtable = New System.Data.DataTable()
                RestaurantPOS14.ModClasses.adp.Fill(RestaurantPOS14.ModClasses.dtable)
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.ds = New System.Data.DataSet()
                RestaurantPOS14.ModClasses.ds.Tables.Add(RestaurantPOS14.ModClasses.dtable)
                RestaurantPOS14.ModClasses.ds.WriteXmlSchema("CreditCustomerLedgerNew1X2.xml")
                Dim rptCreditCustomerLedger2 As RestaurantPOS14.rptCreditCustomerLedger1 = New RestaurantPOS14.rptCreditCustomerLedger1()
                rptCreditCustomerLedger2.SetDataSource(RestaurantPOS14.ModClasses.ds)
                rptCreditCustomerLedger2.SetParameterValue("p1", Me.DateTimePicker2.Value.[Date])
                rptCreditCustomerLedger2.SetParameterValue("p2", Me.DateTimePicker1.Value.[Date])
                rptCreditCustomerLedger2.SetParameterValue("OBC", Me.OBC)
                rptCreditCustomerLedger2.SetParameterValue("OBB", Me.OBB)
                RestaurantPOS14.My.MyProject.Forms.frmReport.CrystalReportViewer1.ReportSource = rptCreditCustomerLedger2
                Call RestaurantPOS14.My.MyProject.Forms.frmReport.ShowDialog()
                rptCreditCustomerLedger2.Close()
                rptCreditCustomerLedger2.Dispose()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub Button3_Click(sender As Object, e As System.EventArgs)
            Try
                MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Me.Timer4.Enabled = True
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT CreditCustomer.CreditCustomerID,LedgerBook.Name,ContactNo,IsNull(sum(Credit)-sum(Debit),0) as Balance FROM CreditCustomer Inner join LedgerBook on CreditCustomer.CreditCustomerID=LedgerBook.PartyID group by CreditCustomer.CreditCustomerID,LedgerBook.name,ContactNo having (sum(Credit)-sum(Debit)) <> 0 order by Name", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.adp = New System.Data.SqlClient.SqlDataAdapter(RestaurantPOS14.ModClasses.cmd)
                RestaurantPOS14.ModClasses.dtable = New System.Data.DataTable()
                RestaurantPOS14.ModClasses.adp.Fill(RestaurantPOS14.ModClasses.dtable)
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.ds = New System.Data.DataSet()
                RestaurantPOS14.ModClasses.ds.Tables.Add(RestaurantPOS14.ModClasses.dtable)
                RestaurantPOS14.ModClasses.ds.WriteXmlSchema("CreditCustomerBalance.xml")
                Dim rptCreditCustomerBalance2 As RestaurantPOS14.rptCreditCustomerBalance = New RestaurantPOS14.rptCreditCustomerBalance()
                rptCreditCustomerBalance2.SetDataSource(RestaurantPOS14.ModClasses.ds)
                RestaurantPOS14.My.MyProject.Forms.frmReport.CrystalReportViewer1.ReportSource = rptCreditCustomerBalance2
                Call RestaurantPOS14.My.MyProject.Forms.frmReport.ShowDialog()
                rptCreditCustomerBalance2.Close()
                rptCreditCustomerBalance2.Dispose()
            Catch ex As System.Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub Timer4_Tick(sender As Object, e As System.EventArgs)
            MyBase.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.Timer4.Enabled = False
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmCreditCustomerLedger))
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.txtCustID = New System.Windows.Forms.TextBox()
            Me.Button3 = New System.Windows.Forms.Button()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.Button2 = New System.Windows.Forms.Button()
            Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.btnNavigation = New System.Windows.Forms.Button()
            Me.txtCustomerName = New System.Windows.Forms.TextBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.txtCustomerID = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.dtpDateFrom = New System.Windows.Forms.DateTimePicker()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.btnClose = New System.Windows.Forms.Button()
            Me.btnReset = New System.Windows.Forms.Button()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
            Me.lblUser = New System.Windows.Forms.Label()
            Me.Panel1.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            Me.Panel2.SuspendLayout()
            MyBase.SuspendLayout()
            Me.Panel1.BackColor = System.Drawing.Color.White
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.lblUser)
            Me.Panel1.Controls.Add(Me.txtCustID)
            Me.Panel1.Controls.Add(Me.Button3)
            Me.Panel1.Controls.Add(Me.GroupBox1)
            Me.Panel1.Controls.Add(Me.GroupBox2)
            Me.Panel1.Controls.Add(Me.GroupBox3)
            Me.Panel1.Controls.Add(Me.Panel2)
            Dim panel As System.Windows.Forms.Panel = Me.Panel1
            Dim location As System.Drawing.Point = New System.Drawing.Point(7, 6)
            panel.Location = location
            Me.Panel1.Name = "Panel1"
            Dim panel2 As System.Windows.Forms.Panel = Me.Panel1
            Dim size As System.Drawing.Size = New System.Drawing.Size(844, 310)
            panel2.Size = size
            Me.Panel1.TabIndex = 2
            Dim textBox As System.Windows.Forms.TextBox = Me.txtCustID
            location = New System.Drawing.Point(638, 164)
            textBox.Location = location
            Me.txtCustID.Name = "txtCustID"
            Dim textBox2 As System.Windows.Forms.TextBox = Me.txtCustID
            size = New System.Drawing.Size(35, 20)
            textBox2.Size = size
            Me.txtCustID.TabIndex = 21
            Me.txtCustID.Visible = False
            Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim button As System.Windows.Forms.Button = Me.Button3
            location = New System.Drawing.Point(417, 233)
            button.Location = location
            Me.Button3.Name = "Button3"
            Dim button2 As System.Windows.Forms.Button = Me.Button3
            size = New System.Drawing.Size(167, 60)
            button2.Size = size
            Me.Button3.TabIndex = 4
            Me.Button3.Text = "Credit Customers Balance Report"
            Me.Button3.UseVisualStyleBackColor = True
            Me.GroupBox1.Controls.Add(Me.Button2)
            Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
            Me.GroupBox1.Controls.Add(Me.Label6)
            Me.GroupBox1.Controls.Add(Me.Label7)
            Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
            Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim groupBox As System.Windows.Forms.GroupBox = Me.GroupBox1
            location = New System.Drawing.Point(9, 214)
            groupBox.Location = location
            Me.GroupBox1.Name = "GroupBox1"
            Dim groupBox2 As System.Windows.Forms.GroupBox = Me.GroupBox1
            size = New System.Drawing.Size(390, 90)
            groupBox2.Size = size
            Me.GroupBox1.TabIndex = 2
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Search by Date"
            Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim button3 As System.Windows.Forms.Button = Me.Button2
            location = New System.Drawing.Point(289, 39)
            button3.Location = location
            Me.Button2.Name = "Button2"
            Dim button4 As System.Windows.Forms.Button = Me.Button2
            size = New System.Drawing.Size(86, 26)
            button4.Size = size
            Me.Button2.TabIndex = 3
            Me.Button2.Text = "View Report"
            Me.Button2.UseVisualStyleBackColor = True
            Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
            Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Dim dateTimePicker As System.Windows.Forms.DateTimePicker = Me.DateTimePicker1
            location = New System.Drawing.Point(157, 39)
            dateTimePicker.Location = location
            Me.DateTimePicker1.Name = "DateTimePicker1"
            Dim dateTimePicker2 As System.Windows.Forms.DateTimePicker = Me.DateTimePicker1
            size = New System.Drawing.Size(119, 26)
            dateTimePicker2.Size = size
            Me.DateTimePicker1.TabIndex = 2
            Me.Label6.AutoSize = True
            Dim label As System.Windows.Forms.Label = Me.Label6
            location = New System.Drawing.Point(154, 20)
            label.Location = location
            Me.Label6.Name = "Label6"
            Dim label2 As System.Windows.Forms.Label = Me.Label6
            size = New System.Drawing.Size(31, 16)
            label2.Size = size
            Me.Label6.TabIndex = 13
            Me.Label6.Text = "To :"
            Me.Label7.AutoSize = True
            Dim label3 As System.Windows.Forms.Label = Me.Label7
            location = New System.Drawing.Point(14, 20)
            label3.Location = location
            Me.Label7.Name = "Label7"
            Dim label4 As System.Windows.Forms.Label = Me.Label7
            size = New System.Drawing.Size(45, 16)
            label4.Size = size
            Me.Label7.TabIndex = 12
            Me.Label7.Text = "From :"
            Me.DateTimePicker2.CustomFormat = "dd/MM/yyyy"
            Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Dim dateTimePicker3 As System.Windows.Forms.DateTimePicker = Me.DateTimePicker2
            location = New System.Drawing.Point(17, 39)
            dateTimePicker3.Location = location
            Me.DateTimePicker2.Name = "DateTimePicker2"
            Dim dateTimePicker4 As System.Windows.Forms.DateTimePicker = Me.DateTimePicker2
            size = New System.Drawing.Size(119, 26)
            dateTimePicker4.Size = size
            Me.DateTimePicker2.TabIndex = 1
            Me.GroupBox2.Controls.Add(Me.btnNavigation)
            Me.GroupBox2.Controls.Add(Me.txtCustomerName)
            Me.GroupBox2.Controls.Add(Me.Label5)
            Me.GroupBox2.Controls.Add(Me.txtCustomerID)
            Me.GroupBox2.Controls.Add(Me.Label3)
            Me.GroupBox2.Controls.Add(Me.Button1)
            Me.GroupBox2.Controls.Add(Me.dtpDateTo)
            Me.GroupBox2.Controls.Add(Me.Label2)
            Me.GroupBox2.Controls.Add(Me.Label4)
            Me.GroupBox2.Controls.Add(Me.dtpDateFrom)
            Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim groupBox3 As System.Windows.Forms.GroupBox = Me.GroupBox2
            location = New System.Drawing.Point(9, 75)
            groupBox3.Location = location
            Me.GroupBox2.Name = "GroupBox2"
            Dim groupBox4 As System.Windows.Forms.GroupBox = Me.GroupBox2
            size = New System.Drawing.Size(623, 133)
            groupBox4.Size = size
            Me.GroupBox2.TabIndex = 0
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Search by Customer Name and Date"
            Me.btnNavigation.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnNavigation.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnNavigation.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnNavigation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button5 As System.Windows.Forms.Button = Me.btnNavigation
            location = New System.Drawing.Point(514, 31)
            button5.Location = location
            Me.btnNavigation.Name = "btnNavigation"
            Dim button6 As System.Windows.Forms.Button = Me.btnNavigation
            size = New System.Drawing.Size(61, 29)
            button6.Size = size
            Me.btnNavigation.TabIndex = 20
            Me.btnNavigation.Text = "..."
            Me.btnNavigation.TextAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnNavigation.UseVisualStyleBackColor = True
            Me.txtCustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox3 As System.Windows.Forms.TextBox = Me.txtCustomerName
            location = New System.Drawing.Point(188, 36)
            textBox3.Location = location
            Me.txtCustomerName.Name = "txtCustomerName"
            Me.txtCustomerName.[ReadOnly] = True
            Dim textBox4 As System.Windows.Forms.TextBox = Me.txtCustomerName
            size = New System.Drawing.Size(320, 22)
            textBox4.Size = size
            Me.txtCustomerName.TabIndex = 19
            Me.Label5.AutoSize = True
            Dim label5 As System.Windows.Forms.Label = Me.Label5
            location = New System.Drawing.Point(185, 19)
            label5.Location = location
            Me.Label5.Name = "Label5"
            Dim label6 As System.Windows.Forms.Label = Me.Label5
            size = New System.Drawing.Size(111, 16)
            label6.Size = size
            Me.Label5.TabIndex = 18
            Me.Label5.Text = "Customer Name :"
            Me.txtCustomerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox5 As System.Windows.Forms.TextBox = Me.txtCustomerID
            location = New System.Drawing.Point(19, 36)
            textBox5.Location = location
            Me.txtCustomerID.Name = "txtCustomerID"
            Me.txtCustomerID.[ReadOnly] = True
            Dim textBox6 As System.Windows.Forms.TextBox = Me.txtCustomerID
            size = New System.Drawing.Size(163, 22)
            textBox6.Size = size
            Me.txtCustomerID.TabIndex = 17
            Me.Label3.AutoSize = True
            Dim label7 As System.Windows.Forms.Label = Me.Label3
            location = New System.Drawing.Point(16, 19)
            label7.Location = location
            Me.Label3.Name = "Label3"
            Dim label8 As System.Windows.Forms.Label = Me.Label3
            size = New System.Drawing.Size(86, 16)
            label8.Size = size
            Me.Label3.TabIndex = 16
            Me.Label3.Text = "Account No. :"
            Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim button7 As System.Windows.Forms.Button = Me.Button1
            location = New System.Drawing.Point(320, 70)
            button7.Location = location
            Me.Button1.Name = "Button1"
            Dim button8 As System.Windows.Forms.Button = Me.Button1
            size = New System.Drawing.Size(125, 50)
            button8.Size = size
            Me.Button1.TabIndex = 3
            Me.Button1.Text = "View Report"
            Me.Button1.UseVisualStyleBackColor = True
            Me.dtpDateTo.CustomFormat = "dd/MM/yyyy"
            Me.dtpDateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Dim dateTimePicker5 As System.Windows.Forms.DateTimePicker = Me.dtpDateTo
            location = New System.Drawing.Point(159, 89)
            dateTimePicker5.Location = location
            Me.dtpDateTo.Name = "dtpDateTo"
            Dim dateTimePicker6 As System.Windows.Forms.DateTimePicker = Me.dtpDateTo
            size = New System.Drawing.Size(119, 26)
            dateTimePicker6.Size = size
            Me.dtpDateTo.TabIndex = 2
            Me.Label2.AutoSize = True
            Dim label9 As System.Windows.Forms.Label = Me.Label2
            location = New System.Drawing.Point(156, 70)
            label9.Location = location
            Me.Label2.Name = "Label2"
            Dim label10 As System.Windows.Forms.Label = Me.Label2
            size = New System.Drawing.Size(31, 16)
            label10.Size = size
            Me.Label2.TabIndex = 13
            Me.Label2.Text = "To :"
            Me.Label4.AutoSize = True
            Dim label11 As System.Windows.Forms.Label = Me.Label4
            location = New System.Drawing.Point(16, 70)
            label11.Location = location
            Me.Label4.Name = "Label4"
            Dim label12 As System.Windows.Forms.Label = Me.Label4
            size = New System.Drawing.Size(45, 16)
            label12.Size = size
            Me.Label4.TabIndex = 12
            Me.Label4.Text = "From :"
            Me.dtpDateFrom.CustomFormat = "dd/MM/yyyy"
            Me.dtpDateFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Dim dateTimePicker7 As System.Windows.Forms.DateTimePicker = Me.dtpDateFrom
            location = New System.Drawing.Point(19, 89)
            dateTimePicker7.Location = location
            Me.dtpDateFrom.Name = "dtpDateFrom"
            Dim dateTimePicker8 As System.Windows.Forms.DateTimePicker = Me.dtpDateFrom
            size = New System.Drawing.Size(119, 26)
            dateTimePicker8.Size = size
            Me.dtpDateFrom.TabIndex = 1
            Me.GroupBox3.Controls.Add(Me.btnClose)
            Me.GroupBox3.Controls.Add(Me.btnReset)
            Dim groupBox5 As System.Windows.Forms.GroupBox = Me.GroupBox3
            location = New System.Drawing.Point(640, 75)
            groupBox5.Location = location
            Me.GroupBox3.Name = "GroupBox3"
            Dim groupBox6 As System.Windows.Forms.GroupBox = Me.GroupBox3
            size = New System.Drawing.Size(193, 75)
            groupBox6.Size = size
            Me.GroupBox3.TabIndex = 1
            Me.GroupBox3.TabStop = False
            Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnClose.Image = RestaurantPOS14.My.Resources.Resources.Close_32x32
            Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button9 As System.Windows.Forms.Button = Me.btnClose
            location = New System.Drawing.Point(100, 19)
            button9.Location = location
            Me.btnClose.Name = "btnClose"
            Dim button10 As System.Windows.Forms.Button = Me.btnClose
            size = New System.Drawing.Size(82, 45)
            button10.Size = size
            Me.btnClose.TabIndex = 1
            Me.btnClose.Text = "&Close"
            Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnClose.UseVisualStyleBackColor = True
            Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnReset.Image = RestaurantPOS14.My.Resources.Resources.Reset2_32x32
            Me.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button11 As System.Windows.Forms.Button = Me.btnReset
            location = New System.Drawing.Point(12, 19)
            button11.Location = location
            Me.btnReset.Name = "btnReset"
            Dim button12 As System.Windows.Forms.Button = Me.btnReset
            size = New System.Drawing.Size(82, 46)
            button12.Size = size
            Me.btnReset.TabIndex = 0
            Me.btnReset.Text = "&Reset"
            Me.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnReset.UseVisualStyleBackColor = True
            Me.Panel2.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Panel2.Controls.Add(Me.Label1)
            Dim panel3 As System.Windows.Forms.Panel = Me.Panel2
            location = New System.Drawing.Point(9, 7)
            panel3.Location = location
            Me.Panel2.Name = "Panel2"
            Dim panel4 As System.Windows.Forms.Panel = Me.Panel2
            size = New System.Drawing.Size(824, 62)
            panel4.Size = size
            Me.Panel2.TabIndex = 0
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label1.ForeColor = System.Drawing.Color.White
            Dim label13 As System.Windows.Forms.Label = Me.Label1
            location = New System.Drawing.Point(285, 17)
            label13.Location = location
            Me.Label1.Name = "Label1"
            Dim label14 As System.Windows.Forms.Label = Me.Label1
            size = New System.Drawing.Size(232, 24)
            label14.Size = size
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Credit Customer Ledger"
            Me.lblUser.AutoSize = True
            Me.lblUser.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.lblUser.ForeColor = System.Drawing.Color.Black
            Dim label15 As System.Windows.Forms.Label = Me.lblUser
            location = New System.Drawing.Point(400, 148)
            label15.Location = location
            Me.lblUser.Name = "lblUser"
            Dim label16 As System.Windows.Forms.Label = Me.lblUser
            size = New System.Drawing.Size(43, 13)
            label16.Size = size
            Me.lblUser.TabIndex = 322
            Me.lblUser.Text = "lblUser"
            Me.lblUser.Visible = False
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            size = New System.Drawing.Size(857, 322)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.Panel1)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MaximizeBox = False
            MyBase.MinimizeBox = False
            MyBase.Name = "frmCreditCustomerLedger"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.GroupBox3.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            MyBase.ResumeLayout(False)
        End Sub
    End Class
End Namespace
