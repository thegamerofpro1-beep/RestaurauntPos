Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports CrystalDecisions.Shared
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports RestaurantPOS14.My

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public Class frmWorkPeriod
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel1")>
        Private _Panel1 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label1")>
        Private _Label1 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblDateTime")>
        Private _lblDateTime As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnCancel")>
        Private _btnCancel As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Timer1")>
        Private _Timer1 As System.Windows.Forms.Timer

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label2")>
        Private _Label2 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnStartWP")>
        Private _btnStartWP As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnEndWP")>
        Private _btnEndWP As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblWPDate")>
        Private _lblWPDate As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblTotalWT")>
        Private _lblTotalWT As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblWorkPeriodDate")>
        Private _lblWorkPeriodDate As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblTotalWorkTime")>
        Private _lblTotalWorkTime As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("dgw")>
        Private _dgw As System.Windows.Forms.DataGridView

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtID")>
        Private _txtID As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Timer2")>
        Private _Timer2 As System.Windows.Forms.Timer

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblUser")>
        Private _lblUser As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column1")>
        Private _Column1 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column2")>
        Private _Column2 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblUserType")>
        Private _lblUserType As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Timer3")>
        Private _Timer3 As System.Windows.Forms.Timer

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtEmailID")>
        Private _txtEmailID As System.Windows.Forms.TextBox

        Private Filename As String

        Private a As Double

        Private b As Double

        Private b1 As Double

        Private b2 As Double

        Private b3 As Double

        Private b4 As Double

        Private b5 As Double

        Private Z1 As Double

        Private Z2 As Double

        Private G1 As Double

        Private G2 As Double

        Private G3 As Double

        Private G4 As Double

        Private T1 As Double

        Private G5 As Double

        Private D1 As Double

        Private M3 As Double

        Private M4 As Double

        Private CX As Double

        Private S1 As Double

        Private S2 As Double

        Private S3 As Double

        Private S4 As Double

        Private S5 As Double

        Private TC As Integer

        Private M1 As Integer

        Private M2 As Integer

        Private StartDate As System.DateTime

        Private EndDate As System.DateTime

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

        Friend Overridable Property lblDateTime As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._lblDateTime
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._lblDateTime = value
            End Set
        End Property

        Friend Overridable Property btnCancel As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnCancel
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnCancel_Click
                If Me._btnCancel IsNot Nothing Then
                    RemoveHandler Me._btnCancel.Click, value2
                End If

                Me._btnCancel = value
                If Me._btnCancel IsNot Nothing Then
                    AddHandler Me._btnCancel.Click, value2
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
                Dim value2 As System.EventHandler = AddressOf Me.Timer1_Tick
                If Me._Timer1 IsNot Nothing Then
                    RemoveHandler Me._Timer1.Tick, value2
                End If

                Me._Timer1 = value
                If Me._Timer1 IsNot Nothing Then
                    AddHandler Me._Timer1.Tick, value2
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

        Friend Overridable Property btnStartWP As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnStartWP
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnStartWP_Click
                If Me._btnStartWP IsNot Nothing Then
                    RemoveHandler Me._btnStartWP.Click, value2
                End If

                Me._btnStartWP = value
                If Me._btnStartWP IsNot Nothing Then
                    AddHandler Me._btnStartWP.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnEndWP As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnEndWP
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnEndWP_Click
                If Me._btnEndWP IsNot Nothing Then
                    RemoveHandler Me._btnEndWP.Click, value2
                End If

                Me._btnEndWP = value
                If Me._btnEndWP IsNot Nothing Then
                    AddHandler Me._btnEndWP.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property lblWPDate As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._lblWPDate
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._lblWPDate = value
            End Set
        End Property

        Friend Overridable Property lblTotalWT As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._lblTotalWT
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._lblTotalWT = value
            End Set
        End Property

        Friend Overridable Property lblWorkPeriodDate As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._lblWorkPeriodDate
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._lblWorkPeriodDate = value
            End Set
        End Property

        Friend Overridable Property lblTotalWorkTime As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._lblTotalWorkTime
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._lblTotalWorkTime = value
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
                Me._dgw = value
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

        Friend Overridable Property Timer2 As System.Windows.Forms.Timer
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Timer2
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Timer)
                Dim value2 As System.EventHandler = AddressOf Me.Timer2_Tick
                If Me._Timer2 IsNot Nothing Then
                    RemoveHandler Me._Timer2.Tick, value2
                End If

                Me._Timer2 = value
                If Me._Timer2 IsNot Nothing Then
                    AddHandler Me._Timer2.Tick, value2
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

        Friend Overridable Property Timer3 As System.Windows.Forms.Timer
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Timer3
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Timer)
                Dim value2 As System.EventHandler = AddressOf Me.Timer3_Tick
                If Me._Timer3 IsNot Nothing Then
                    RemoveHandler Me._Timer3.Tick, value2
                End If

                Me._Timer3 = value
                If Me._Timer3 IsNot Nothing Then
                    AddHandler Me._Timer3.Tick, value2
                End If
            End Set
        End Property

        Friend Overridable Property txtEmailID As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtEmailID
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtEmailID = value
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            AddHandler MyBase.Load, AddressOf Me.frmWorkPeriod_Load
            Call RestaurantPOS14.frmWorkPeriod.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmWorkPeriod.__ENCList
                If RestaurantPOS14.frmWorkPeriod.__ENCList.Count = RestaurantPOS14.frmWorkPeriod.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmWorkPeriod.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmWorkPeriod.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmWorkPeriod.__ENCList(num) = RestaurantPOS14.frmWorkPeriod.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmWorkPeriod.__ENCList.RemoveRange(num, RestaurantPOS14.frmWorkPeriod.__ENCList.Count - num)
                    RestaurantPOS14.frmWorkPeriod.__ENCList.Capacity = RestaurantPOS14.frmWorkPeriod.__ENCList.Count
                End If

                Call RestaurantPOS14.frmWorkPeriod.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Private Sub Timer1_Tick(sender As Object, e As System.EventArgs)
            Me.lblDateTime.Text = Microsoft.VisualBasic.DateAndTime.Now.ToString("dddd, dd MMMM yyyy hh:mm:ss tt")
        End Sub

        Public Sub GetEmail()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = RestaurantPOS14.ModClasses.con.CreateCommand()
                RestaurantPOS14.ModClasses.cmd.CommandText = "SELECT RTRIM(EmailID) from Hotel"
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.txtEmailID.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(0))
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

        Private Sub btnCancel_Click(sender As Object, e As System.EventArgs)
            MyBase.Hide()
            RestaurantPOS14.My.MyProject.Forms.frmFrontOffice.lblUserType.Text = Me.lblUserType.Text
            RestaurantPOS14.My.MyProject.Forms.frmFrontOffice.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmFrontOffice.Show()
        End Sub

        Private Sub btnStartWP_Click(sender As Object, e As System.EventArgs)
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Update WorkPeriodStart set Status='Inactive'")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("insert into WorkPeriodStart(WPStart,Status) VALUES (@d1,'Active')")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", System.DateTime.Now)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                RestaurantPOS14.ModClasses.con.Close()
                Call RestaurantPOS14.My.MyProject.Forms.frmCustomDialog1.ShowDialog()
                Me.GetData()
                Me.FillDataGridview()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub GetData()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT ID,WPStart from WorkPeriodStart where Status='Active'")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.lblTotalWorkTime.Visible = True
                    Me.lblTotalWT.Visible = True
                    Me.lblWorkPeriodDate.Visible = True
                    Me.lblWPDate.Visible = True
                    Me.txtID.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                    Me.lblWorkPeriodDate.Text = RestaurantPOS14.ModClasses.rdr.GetDateTime(CInt((1))).ToString("dd/MM/yyyy hh:mm:ss tt")
                    Me.btnStartWP.Enabled = False
                Else
                    Me.lblTotalWorkTime.Visible = False
                    Me.lblTotalWT.Visible = False
                    Me.lblWorkPeriodDate.Visible = False
                    Me.lblWPDate.Visible = False
                    Me.btnStartWP.Enabled = True
                    Me.btnEndWP.Enabled = False
                End If

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub frmWorkPeriod_Load(sender As Object, e As System.EventArgs)
            Me.GetData()
            Me.GetEmail()
            Me.FillDataGridview()
            Me.dgw.ClearSelection()
        End Sub

        Private Sub Timer2_Tick(sender As Object, e As System.EventArgs)
            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
            RestaurantPOS14.ModClasses.con.Open()
            RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT WPStart from WorkPeriodStart where Status='Active'")
            RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
            RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
            If RestaurantPOS14.ModClasses.rdr.Read() Then
                Dim now As System.DateTime = System.DateTime.Now
                Dim dateTime As System.DateTime = RestaurantPOS14.ModClasses.rdr.GetDateTime(0)
                Dim timeSpan As System.TimeSpan = now.Subtract(dateTime)
                Dim days As Integer = timeSpan.Days
                Dim hours As Integer = timeSpan.Hours
                Dim minutes As Integer = timeSpan.Minutes
                If days > 0 AndAlso hours > 0 AndAlso minutes > 0 Then
                    Me.btnEndWP.Enabled = True
                End If

                If days > 0 AndAlso hours = 0 AndAlso minutes = 0 Then
                    Me.btnEndWP.Enabled = True
                End If

                If days > 0 AndAlso hours > 0 AndAlso minutes = 0 Then
                    Me.btnEndWP.Enabled = True
                End If

                If days = 0 AndAlso hours = 0 AndAlso minutes > 0 Then
                    Me.btnEndWP.Enabled = True
                End If

                If days = 0 AndAlso hours > 0 AndAlso minutes = 0 Then
                    Me.btnEndWP.Enabled = True
                End If

                If days = 0 AndAlso hours > 0 AndAlso minutes > 0 Then
                    Me.btnEndWP.Enabled = True
                End If

                If days > 0 AndAlso hours = 0 AndAlso minutes > 0 Then
                    Me.btnEndWP.Enabled = True
                End If

                If days = 0 AndAlso hours = 0 AndAlso minutes >= 0 Then
                    If minutes <= 1 Then
                        Me.lblTotalWorkTime.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(minutes) & " Minute"
                    Else
                        Me.lblTotalWorkTime.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(minutes) & " Minutes"
                    End If
                End If

                If days = 0 AndAlso hours > 0 AndAlso minutes >= 0 Then
                    If hours <= 1 AndAlso minutes <= 1 Then
                        Me.lblTotalWorkTime.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(hours) & " Hour " & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(minutes) & " Minute"
                    ElseIf hours <= 1 AndAlso minutes >= 1 Then
                        Me.lblTotalWorkTime.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(hours) & " Hour " & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(minutes) & " Minutes"
                    ElseIf hours > 1 AndAlso minutes <= 1 Then
                        Me.lblTotalWorkTime.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(hours) & " Hours " & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(minutes) & " Minute"
                    ElseIf hours > 1 AndAlso minutes > 1 Then
                        Me.lblTotalWorkTime.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(hours) & " Hours " & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(minutes) & " Minutes"
                    End If
                End If

                If days > 0 AndAlso hours >= 0 AndAlso minutes >= 0 Then
                    If days <= 1 AndAlso hours <= 1 AndAlso minutes <= 1 Then
                        Me.lblTotalWorkTime.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(days) & " Day " & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(hours) & " Hour " & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(minutes) & " Minute"
                    ElseIf days > 1 AndAlso hours > 1 AndAlso minutes > 1 Then
                        Me.lblTotalWorkTime.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(days) & " Days " & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(hours) & " Hours " & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(minutes) & " Minutes"
                    ElseIf days > 1 AndAlso hours <= 1 AndAlso minutes <= 1 Then
                        Me.lblTotalWorkTime.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(days) & " Days " & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(hours) & " Hour " & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(minutes) & " Minute"
                    ElseIf days > 1 AndAlso hours > 1 AndAlso minutes <= 1 Then
                        Me.lblTotalWorkTime.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(days) & " Days " & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(hours) & " Hours " & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(minutes) & " Minute"
                    ElseIf days <= 1 AndAlso hours <= 1 AndAlso minutes > 1 Then
                        Me.lblTotalWorkTime.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(days) & " Day " & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(hours) & " Hour " & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(minutes) & " Minutes"
                    ElseIf days <= 1 AndAlso hours > 1 AndAlso minutes <= 1 Then
                        Me.lblTotalWorkTime.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(days) & " Day " & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(hours) & " Hours " & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(minutes) & " Minute"
                    ElseIf days > 1 AndAlso hours <= 1 AndAlso minutes > 1 Then
                        Me.lblTotalWorkTime.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(days) & " Days " & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(hours) & " Hour " & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(minutes) & " Minutes"
                    ElseIf days <= 1 AndAlso hours > 1 AndAlso minutes > 1 Then
                        Me.lblTotalWorkTime.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(days) & " Day " & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(hours) & " Hours " & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(minutes) & " Minutes"
                    End If
                End If
            End If

            RestaurantPOS14.ModClasses.con.Close()
        End Sub

        Public Sub FillDataGridview()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT * from WorkPeriodStart")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If Not RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.dgw.Enabled = False
                End If

                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT WPStart,WPEnd from WorkPeriodStart left join WorkPeriodEnd On WorkperiodStart.ID=WorkPeriodEnd.ID  order by WPStart desc", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                Me.dgw.Rows.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Me.dgw.Rows.Add(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(0)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(1)))
                End While

                RestaurantPOS14.ModClasses.con.Close()
                Me.dgw.ClearSelection()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnEndWP_Click(sender As Object, e As System.EventArgs)
            Try
                Dim flag As Boolean = False
                Dim flag2 As Boolean = False
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT KOT_Status from RestaurantPOS_OrderInfoKOT where KOT_Status in ('Open','Prepared','Served')")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    flag = True
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT DIB_Status from RestaurantPOS_BillingInfoKOT where DIB_Status in ('Unpaid') UNION select TA_Status from RestaurantPOS_BillingInfoTA where TA_Status in ('Prepared','Unpaid') UNION SELECT EB_Status from RestaurantPOS_BillingInfoEB where EB_Status in ('Prepared','Unpaid')")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    flag2 = True
                End If

                RestaurantPOS14.ModClasses.con.Close()
                If(flag OrElse flag2) AndAlso System.Windows.Forms.MessageBox.Show("There are open or unpaid orders/bills. End work period anyway?", "Confirm End Work Period", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Exclamation) <> System.Windows.Forms.DialogResult.Yes Then
                    Return
                End If

                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("insert into WorkPeriodEnd(ID,WPEnd) VALUES (" & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.txtID.Text)) & ",@d1)")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", System.DateTime.Now)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Update WorkPeriodStart set Status='Inactive'")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Delete from tblOrder")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Update RestaurantPOS_BillingInfoTA set TA_Status='Closed' where TA_Status not in ('Void')")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Update RestaurantPOS_BillingInfoEB set EB_Status='Closed' where EB_Status not in ('Void')")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                RestaurantPOS14.ModClasses.con.Close()
                Call RestaurantPOS14.My.MyProject.Forms.frmCustomDialog2.ShowDialog()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.ReadCS())
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Delete from HoldBill")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                RestaurantPOS14.ModClasses.con.Close()
                Me.GetData()
                Me.FillDataGridview()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT top 1 WpStart,WpEnd FROM WorkPeriodStart,WorkPeriodEnd where WorkPeriodStart.ID=WorkPeriodEnd.ID order by WorkPeriodStart.ID desc")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.StartDate = RestaurantPOS14.ModClasses.rdr.GetDateTime(0)
                    Me.EndDate = RestaurantPOS14.ModClasses.rdr.GetDateTime(1)
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.Extensions.Events.IntegrationEventHost.PublishDayClosed(Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(Microsoft.VisualBasic.Conversion.Val(Me.txtID.Text)), Me.StartDate, Me.EndDate)
                If(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblUserType.Text, "Admin", TextCompare:=False) = 0) Or (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblUserType.Text, "Super Admin", TextCompare:=False) = 0) Then
                    MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                    Me.Timer3.Enabled = True
                    Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    Dim sqlCommand As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("select Operator from RestaurantPOS_BillingInfoKOT where BillDate >=@d1 and BillDate < @d2 and DIB_Status not in ('Unpaid','Changed to Split Bill') union select Operator from RestaurantPOS_BillingInfoTA where BillDate >=@d1 and BillDate < @d2 and TA_Status not in ('Void','Unpaid','Prepared') union select Operator from RestaurantPOS_BillingInfoHD where BillDate >=@d1 and BillDate < @d2 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') Union select Operator from RestaurantPOS_BillingInfoEB where BillDate >=@d1 and BillDate < @d2 and EB_Status not in ('Void','Unpaid','Prepared')")
                    sqlCommand.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.StartDate
                    sqlCommand.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.EndDate
                    sqlCommand.Connection = RestaurantPOS14.ModClasses.con
                    sqlCommand.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                    RestaurantPOS14.ModClasses.rdr = sqlCommand.ExecuteReader()
                    If Not RestaurantPOS14.ModClasses.rdr.Read() Then
                        Call System.Windows.Forms.MessageBox.Show("Sorry..No record found between selected dates", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                        If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                            RestaurantPOS14.ModClasses.rdr.Close()
                        End If

                        Return
                    End If

                    Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    Dim sqlCommand2 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT * from Hotel", RestaurantPOS14.ModClasses.con)
                    Dim sqlDataAdapter As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(sqlCommand2)
                    sqlCommand2.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                    Dim sqlCommand3 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT Operator,Sum(GrandTotal) as [GrandTotal] from(Select Operator,(GrandTotal*ExchangeRate) as [GrandTotal] from RestaurantPOS_BillingInfoKOT where BillDate >=@d1 and BillDate < @d2 and DIB_Status not in ('Unpaid','Changed to Split Bill')  Union all Select Operator,(GrandTotal*ExchangeRate) as [GrandTotal] from RestaurantPOS_BillingInfoTA where BillDate >=@d1 and BillDate < @d2 and TA_Status not in ('Void','Unpaid','Prepared') Union all Select Operator,GrandTotal as [GrandTotal] from RestaurantPOS_BillingInfoHD where BillDate >=@d1 and BillDate < @d2 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') Union all Select Operator,(GrandTotal*ExchangeRate) as [GrandTotal] from RestaurantPOS_BillingInfoEB where BillDate >=@d1 and BillDate < @d2 and EB_Status not in ('Void','Unpaid','Prepared'))G  group by Operator order by 1", RestaurantPOS14.ModClasses.con)
                    sqlCommand3.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.StartDate
                    sqlCommand3.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.EndDate
                    sqlCommand3.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                    Dim sqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(sqlCommand3)
                    Dim sqlCommand4 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT Category,Sum(TotalAmount) as Total from (Select category,(TotalAmount*ExchangeRate) as [TotalAmount] from RestaurantPOS_OrderedProductBillKOT, RestaurantPOS_BillingInfoKOT where RestaurantPOS_BillingInfoKOT.ID=RestaurantPOS_OrderedProductBillKOT.BillID and BillDate >=@d3 and BillDate < @d4 and DIB_Status not in ('Unpaid','Changed to Split Bill') UNION ALL Select category,(TotalAmount*ExchangeRate) as [TotalAmount] from RestaurantPOS_OrderedProductBillTA, RestaurantPOS_BillingInfoTA where RestaurantPOS_BillingInfoTA.ID=RestaurantPOS_OrderedProductBillTA.BillID and BillDate >=@d3 and BillDate < @d4 and TA_Status not in ('Void','Unpaid','Prepared') UNION ALL Select category,(TotalAmount) as [TotalAmount] from RestaurantPOS_OrderedProductBillHD, RestaurantPOS_BillingInfoHD where RestaurantPOS_BillingInfoHD.ID=RestaurantPOS_OrderedProductBillHD.BillID and BillDate >=@d3 and BillDate < @d4 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') Union all Select category,(TotalAmount*ExchangeRate) as [TotalAmount] from RestaurantPOS_OrderedProductBillEB, RestaurantPOS_BillingInfoEB where RestaurantPOS_BillingInfoEB.ID=RestaurantPOS_OrderedProductBillEB.BillID and BillDate >=@d3 and BillDate < @d4 and EB_Status not in ('Void','Unpaid','Prepared'))C group by Category order by 1", RestaurantPOS14.ModClasses.con)
                    sqlCommand4.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.StartDate
                    sqlCommand4.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.EndDate
                    sqlCommand4.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                    Dim sqlDataAdapter3 As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(sqlCommand4)
                    Dim sqlCommand5 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT Category,Sum(Quantity) as TotalQuantity from (Select category,Quantity from RestaurantPOS_OrderedProductBillKOT, RestaurantPOS_BillingInfoKOT where RestaurantPOS_BillingInfoKOT.ID=RestaurantPOS_OrderedProductBillKOT.BillID and BillDate >=@d5 and BillDate < @d6 and DIB_Status not in ('Unpaid','Changed to Split Bill') UNION ALL Select category,Quantity from RestaurantPOS_OrderedProductBillTA, RestaurantPOS_BillingInfoTA where RestaurantPOS_BillingInfoTA.ID=RestaurantPOS_OrderedProductBillTA.BillID and BillDate >=@d5 and BillDate < @d6 and TA_Status not in ('Void','Unpaid','Prepared') UNION ALL Select category,Quantity from RestaurantPOS_OrderedProductBillHD, RestaurantPOS_BillingInfoHD where RestaurantPOS_BillingInfoHD.ID=RestaurantPOS_OrderedProductBillHD.BillID and BillDate >=@d5 and BillDate < @d6 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') Union all Select category,Quantity from RestaurantPOS_OrderedProductBillEB, RestaurantPOS_BillingInfoEB where RestaurantPOS_BillingInfoEB.ID=RestaurantPOS_OrderedProductBillEB.BillID and BillDate >=@d5 and BillDate < @d6 and EB_Status not in ('Void','Unpaid','Prepared'))C group by Category order by 1", RestaurantPOS14.ModClasses.con)
                    sqlCommand5.Parameters.Add(CStr(("@d5")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.StartDate
                    sqlCommand5.Parameters.Add(CStr(("@d6")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.EndDate
                    sqlCommand5.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                    Dim sqlDataAdapter4 As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(sqlCommand5)
                    Dim sqlCommand6 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT Dish,Sum(Quantity) as [Quantity],Sum(TotalAmount) as [Amount] from (Select Dish,Quantity,(TotalAmount*ExchangeRate) as [TotalAmount] from RestaurantPOS_OrderedProductBillKOT,RestaurantPOS_BillingInfoKOT where BillDate >=@d7 and BillDate < @d8 and DIB_Status not in ('Unpaid','Changed to Split Bill') and RestaurantPOS_BillingInfoKOT.ID=RestaurantPOS_OrderedProductBillKOT.BillID Union All Select Dish,Quantity,(TotalAmount*ExchangeRate) as [TotalAmount] from RestaurantPOS_OrderedProductBillTA,RestaurantPOS_BillingInfoTA where BillDate >=@d7 and BillDate < @d8 and RestaurantPOS_BillingInfoTA.ID=RestaurantPOS_OrderedProductBillTA.BillID and TA_Status not in ('Void','Unpaid','Prepared') Union All Select Dish,Quantity,TotalAmount as [TotalAmount] from RestaurantPOS_OrderedProductBillHD,RestaurantPOS_BillingInfoHD where BillDate >=@d7 and BillDate < @d8 and RestaurantPOS_BillingInfoHD.ID=RestaurantPOS_OrderedProductBillHD.BillID and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') Union all Select Dish,Quantity,(TotalAmount*ExchangeRate) as [TotalAmount] from RestaurantPOS_OrderedProductBillEB,RestaurantPOS_BillingInfoEB where BillDate >=@d7 and BillDate < @d8 and RestaurantPOS_BillingInfoEB.ID=RestaurantPOS_OrderedProductBillEB.BillID and EB_Status not in ('Void','Unpaid','Prepared'))G  group by Dish order by 1", RestaurantPOS14.ModClasses.con)
                    sqlCommand6.Parameters.Add(CStr(("@d7")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.StartDate
                    sqlCommand6.Parameters.Add(CStr(("@d8")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.EndDate
                    sqlCommand6.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                    Dim sqlDataAdapter5 As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(sqlCommand6)
                    Dim sqlCommand7 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT PaymentMode,IsNull(Sum(Card),0) as [Card] from (Select PaymentMode,Card as [Card] from RestaurantPOS_BillingInfoKOT where BillDate >=@d11 and BillDate < @d12 and DIB_Status not in ('Unpaid','Changed to Split Bill') and PaymentMode Not in ('Cash','Credit Card','Debit Card','Credit Customer','VIP Member Card') Union All Select  PaymentMode,(Card) as [Card] from RestaurantPOS_BillingInfoTA where BillDate >=@d11 and BillDate < @d12 and TA_Status not in ('Void','Unpaid','Prepared') and PaymentMode Not in ('Cash','Credit Card','Debit Card','Credit Customer','VIP Member Card') Union All Select  PaymentMode,GrandTotal as [Card] from RestaurantPOS_BillingInfoHD where BillDate >=@d11 and BillDate < @d12 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') and PaymentMode Not in ('Cash','Credit Card','Debit Card','Credit Customer','VIP Member Card') Union all Select PaymentMode,(Card) as [Card] from RestaurantPOS_BillingInfoEB where BillDate >=@d11 and BillDate < @d12 and EB_Status not in ('Void','Unpaid','Prepared') and PaymentMode Not in ('Cash','Credit Card','Debit Card','Credit Customer','VIP Member Card'))G  group by PaymentMode order by 1", RestaurantPOS14.ModClasses.con)
                    sqlCommand7.Parameters.Add(CStr(("@d11")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.StartDate
                    sqlCommand7.Parameters.Add(CStr(("@d12")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.EndDate
                    sqlCommand7.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                    Dim sqlDataAdapter6 As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(sqlCommand7)
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    Dim sqlCommand8 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("select IsNull(Sum(HomeDeliveryCharges),0) from RestaurantPOS_BillingInfoHD where BillDate >=@d9 and BillDate < @d10 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched')")
                    sqlCommand8.Parameters.Add(CStr(("@d9")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.StartDate
                    sqlCommand8.Parameters.Add(CStr(("@d10")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.EndDate
                    sqlCommand8.Connection = RestaurantPOS14.ModClasses.con
                    sqlCommand8.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                    RestaurantPOS14.ModClasses.rdr = sqlCommand8.ExecuteReader()
                    If RestaurantPOS14.ModClasses.rdr.Read() Then
                        Me.a = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                    End If

                    RestaurantPOS14.ModClasses.con.Close()
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    Dim sqlCommand9 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("select IsNull(Sum(ParcelCharges*ExchangeRate),0) from RestaurantPOS_BillingInfoTA where BillDate >=@d11 and BillDate < @d12 and TA_Status not in ('Void','Unpaid','Prepared')")
                    sqlCommand9.Parameters.Add(CStr(("@d11")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.StartDate
                    sqlCommand9.Parameters.Add(CStr(("@d12")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.EndDate
                    sqlCommand9.Connection = RestaurantPOS14.ModClasses.con
                    sqlCommand9.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                    RestaurantPOS14.ModClasses.rdr = sqlCommand9.ExecuteReader()
                    If RestaurantPOS14.ModClasses.rdr.Read() Then
                        Me.b = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                    End If

                    RestaurantPOS14.ModClasses.con.Close()
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    Dim sqlCommand10 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("Select IsNull(Sum(GrandTotal*ExchangeRate),0)  from RestaurantPOS_BillingInfoKOT where BillDate >=@d13 and BillDate < @d14 and DIB_Status not in ('Unpaid','Changed to Split Bill')")
                    sqlCommand10.Parameters.Add(CStr(("@d13")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.StartDate
                    sqlCommand10.Parameters.Add(CStr(("@d14")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.EndDate
                    sqlCommand10.Connection = RestaurantPOS14.ModClasses.con
                    sqlCommand10.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                    RestaurantPOS14.ModClasses.rdr = sqlCommand10.ExecuteReader()
                    If RestaurantPOS14.ModClasses.rdr.Read() Then
                        Me.b1 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                    End If

                    RestaurantPOS14.ModClasses.con.Close()
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    Dim sqlCommand11 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("Select IsNull(Sum(GrandTotal*ExchangeRate),0)  from RestaurantPOS_BillingInfoTA where BillDate >=@d13 and BillDate < @d14 and TA_Status not in ('Void','Unpaid','Prepared')")
                    sqlCommand11.Parameters.Add(CStr(("@d13")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.StartDate
                    sqlCommand11.Parameters.Add(CStr(("@d14")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.EndDate
                    sqlCommand11.Connection = RestaurantPOS14.ModClasses.con
                    sqlCommand11.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                    RestaurantPOS14.ModClasses.rdr = sqlCommand11.ExecuteReader()
                    If RestaurantPOS14.ModClasses.rdr.Read() Then
                        Me.b2 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                    End If

                    RestaurantPOS14.ModClasses.con.Close()
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    Dim sqlCommand12 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("Select IsNull(Sum(GrandTotal),0)  from RestaurantPOS_BillingInfoHD where BillDate >=@d13 and BillDate < @d14 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched')")
                    sqlCommand12.Parameters.Add(CStr(("@d13")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.StartDate
                    sqlCommand12.Parameters.Add(CStr(("@d14")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.EndDate
                    sqlCommand12.Connection = RestaurantPOS14.ModClasses.con
                    sqlCommand12.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                    RestaurantPOS14.ModClasses.rdr = sqlCommand12.ExecuteReader()
                    If RestaurantPOS14.ModClasses.rdr.Read() Then
                        Me.b3 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                    End If

                    RestaurantPOS14.ModClasses.con.Close()
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    Dim sqlCommand13 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("Select IsNull(Sum(GrandTotal*ExchangeRate),0)  from RestaurantPOS_BillingInfoEB where BillDate >=@d13 and BillDate < @d14 and EB_Status not in ('Void','Unpaid','Prepared')")
                    sqlCommand13.Parameters.Add(CStr(("@d13")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.StartDate
                    sqlCommand13.Parameters.Add(CStr(("@d14")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.EndDate
                    sqlCommand13.Connection = RestaurantPOS14.ModClasses.con
                    sqlCommand13.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                    RestaurantPOS14.ModClasses.rdr = sqlCommand13.ExecuteReader()
                    If RestaurantPOS14.ModClasses.rdr.Read() Then
                        Me.b4 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                    End If

                    RestaurantPOS14.ModClasses.con.Close()
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    Dim sqlCommand14 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT Sum(TotalVAT) as TotalVAT,SUM(TotalDiscount) as TotalDicount from (Select VATAmount as [TotalVAT],DiscountAmount as [TotalDiscount] from RestaurantPOS_OrderedProductBillKOT, RestaurantPOS_BillingInfoKOT where RestaurantPOS_BillingInfoKOT.ID=RestaurantPOS_OrderedProductBillKOT.BillID and BillDate >=@d3 and BillDate < @d4 and DIB_Status not in ('Unpaid','Changed to Split Bill') UNION ALL Select VATAmount as [TotalVAT],DiscountAmount as [TotalDiscount] from RestaurantPOS_OrderedProductBillTA, RestaurantPOS_BillingInfoTA where RestaurantPOS_BillingInfoTA.ID=RestaurantPOS_OrderedProductBillTA.BillID and BillDate >=@d3 and BillDate < @d4 and TA_Status not in ('Void','Unpaid','Prepared') UNION ALL Select VATAmount as [TotalVAT],DiscountAmount as [TotalDiscount] from RestaurantPOS_OrderedProductBillHD, RestaurantPOS_BillingInfoHD where RestaurantPOS_BillingInfoHD.ID=RestaurantPOS_OrderedProductBillHD.BillID and BillDate >=@d3 and BillDate < @d4 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') Union all Select VATAmount as [TotalVAT],DiscountAmount as [TotalDiscount] from RestaurantPOS_OrderedProductBillEB, RestaurantPOS_BillingInfoEB where RestaurantPOS_BillingInfoEB.ID=RestaurantPOS_OrderedProductBillEB.BillID and BillDate >=@d3 and BillDate < @d4 and EB_Status not in ('Void','Unpaid','Prepared'))C")
                    sqlCommand14.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.StartDate
                    sqlCommand14.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.EndDate
                    sqlCommand14.Connection = RestaurantPOS14.ModClasses.con
                    sqlCommand14.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                    RestaurantPOS14.ModClasses.rdr = sqlCommand14.ExecuteReader()
                    If RestaurantPOS14.ModClasses.rdr.Read() Then
                        Me.b5 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                        Me.D1 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(1))
                    End If

                    RestaurantPOS14.ModClasses.con.Close()
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    Dim sqlCommand15 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT Sum(LA) as [LA] from(Select LA as [LA] from RestaurantPOS_BillingInfoKOT where BillDate >=@d3 and BillDate < @d4 and DIB_Status not in ('Unpaid','Changed to Split Bill')  Union all Select LA as [LA] from RestaurantPOS_BillingInfoTA where BillDate >=@d3 and BillDate < @d4 and TA_Status not in ('Void','Unpaid','Prepared') Union all Select LA as [LA] from RestaurantPOS_BillingInfoHD where BillDate >=@d3 and BillDate < @d4 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') Union all Select LA as [LA] from RestaurantPOS_BillingInfoEB where BillDate >=@d3 and BillDate < @d4 and EB_Status not in ('Void','Unpaid','Prepared'))G")
                    sqlCommand15.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.StartDate
                    sqlCommand15.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.EndDate
                    sqlCommand15.Connection = RestaurantPOS14.ModClasses.con
                    sqlCommand15.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                    RestaurantPOS14.ModClasses.rdr = sqlCommand15.ExecuteReader()
                    If RestaurantPOS14.ModClasses.rdr.Read() Then
                        Me.Z1 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                    End If

                    RestaurantPOS14.ModClasses.con.Close()
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    Dim sqlCommand16 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT Sum(GCA) as [GCA] from(Select GiftCardAmount as [GCA] from RestaurantPOS_BillingInfoKOT where BillDate >=@d3 and BillDate < @d4 and DIB_Status not in ('Unpaid','Changed to Split Bill')  Union all Select GiftCardAmount as [GCA] from RestaurantPOS_BillingInfoTA where BillDate >=@d3 and BillDate < @d4 and TA_Status not in ('Void','Unpaid','Prepared') Union all Select GiftCardAmount as [GCA] from RestaurantPOS_BillingInfoHD where BillDate >=@d3 and BillDate < @d4 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') Union all Select GiftCardAmount as [GCA] from RestaurantPOS_BillingInfoEB where BillDate >=@d3 and BillDate < @d4 and EB_Status not in ('Void','Unpaid','Prepared'))G")
                    sqlCommand16.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.StartDate
                    sqlCommand16.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.EndDate
                    sqlCommand16.Connection = RestaurantPOS14.ModClasses.con
                    sqlCommand16.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                    RestaurantPOS14.ModClasses.rdr = sqlCommand16.ExecuteReader()
                    If RestaurantPOS14.ModClasses.rdr.Read() Then
                        Me.Z2 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                    End If

                    RestaurantPOS14.ModClasses.con.Close()
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    Dim sqlCommand17 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("Select IsNull(Sum(Cash),0) as [Cash] from(Select Cash - Change as [Cash] from RestaurantPOS_BillingInfoKOT where BillDate >=@d3 and BillDate < @d4 and DIB_Status not in ('Unpaid','Changed to Split Bill')  Union all Select Cash - Change as [Cash] from RestaurantPOS_BillingInfoTA where BillDate >=@d3 and BillDate < @d4 and TA_Status not in ('Void','Unpaid','Prepared') Union all Select GrandTotal as [Cash] from RestaurantPOS_BillingInfoHD where BillDate >=@d3 and BillDate < @d4 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') and PaymentMode='Cash' Union all Select Cash - Change as [Cash] from RestaurantPOS_BillingInfoEB where BillDate >=@d3 and BillDate < @d4 and EB_Status not in ('Void','Unpaid','Prepared'))G")
                    sqlCommand17.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.StartDate
                    sqlCommand17.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.EndDate
                    sqlCommand17.Connection = RestaurantPOS14.ModClasses.con
                    sqlCommand17.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                    RestaurantPOS14.ModClasses.rdr = sqlCommand17.ExecuteReader()
                    If RestaurantPOS14.ModClasses.rdr.Read() Then
                        Me.G1 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                    End If

                    RestaurantPOS14.ModClasses.con.Close()
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    Dim sqlCommand18 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("Select IsNull(Sum(Cash),0) as [Cash] from(Select Card-Change as [Cash] from RestaurantPOS_BillingInfoKOT where BillDate >=@d3 and BillDate < @d4 and DIB_Status not in ('Unpaid','Changed to Split Bill') and PaymentMode='Credit Card'  Union all Select Card-Change as [Cash] from RestaurantPOS_BillingInfoTA where BillDate >=@d3 and BillDate < @d4 and TA_Status not in ('Void','Unpaid','Prepared') and PaymentMode='Credit Card' Union all Select GrandTotal as [Cash] from RestaurantPOS_BillingInfoHD where BillDate >=@d3 and BillDate < @d4 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') and PaymentMode='Credit Card' Union all Select Card-Change as [Cash] from RestaurantPOS_BillingInfoEB where BillDate >=@d3 and BillDate < @d4 and EB_Status not in ('Void','Unpaid','Prepared') and PaymentMode='Credit Card')G")
                    sqlCommand18.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.StartDate
                    sqlCommand18.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.EndDate
                    sqlCommand18.Connection = RestaurantPOS14.ModClasses.con
                    sqlCommand18.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                    RestaurantPOS14.ModClasses.rdr = sqlCommand18.ExecuteReader()
                    If RestaurantPOS14.ModClasses.rdr.Read() Then
                        Me.G2 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                    End If

                    RestaurantPOS14.ModClasses.con.Close()
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    Dim sqlCommand19 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("Select IsNull(Sum(Cash),0) as [Cash] from(Select Card-Change as [Cash] from RestaurantPOS_BillingInfoKOT where BillDate >=@d3 and BillDate < @d4 and DIB_Status not in ('Unpaid','Changed to Split Bill') and PaymentMode='Debit Card'  Union all Select Card-Change as [Cash] from RestaurantPOS_BillingInfoTA where BillDate >=@d3 and BillDate < @d4 and TA_Status not in ('Void','Unpaid','Prepared') and PaymentMode='Debit Card' Union all Select GrandTotal as [Cash] from RestaurantPOS_BillingInfoHD where BillDate >=@d3 and BillDate < @d4 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') and PaymentMode='Debit Card' Union all Select Card-Change as [Cash] from RestaurantPOS_BillingInfoEB where BillDate >=@d3 and BillDate < @d4 and EB_Status not in ('Void','Unpaid','Prepared') and PaymentMode='Debit Card')G")
                    sqlCommand19.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.StartDate
                    sqlCommand19.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.EndDate
                    sqlCommand19.Connection = RestaurantPOS14.ModClasses.con
                    sqlCommand19.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                    RestaurantPOS14.ModClasses.rdr = sqlCommand19.ExecuteReader()
                    If RestaurantPOS14.ModClasses.rdr.Read() Then
                        Me.G3 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                    End If

                    RestaurantPOS14.ModClasses.con.Close()
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    Dim sqlCommand20 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT IsNull(Sum(Cash),0) as [Cash] from(Select Card-Change as [Cash] from RestaurantPOS_BillingInfoKOT where BillDate >=@d3 and BillDate < @d4 and DIB_Status not in ('Unpaid','Changed to Split Bill') and PaymentMode='VIP Member Card'  Union all Select Card-Change as [Cash] from RestaurantPOS_BillingInfoTA where BillDate >=@d3 and BillDate < @d4 and TA_Status not in ('Void','Unpaid','Prepared') and PaymentMode='VIP Member Card' Union all Select GrandTotal as [Cash] from RestaurantPOS_BillingInfoHD where BillDate >=@d3 and BillDate < @d4 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') and PaymentMode='VIP Member Card' Union all Select Card-Change as [Cash] from RestaurantPOS_BillingInfoEB where BillDate >=@d3 and BillDate < @d4 and EB_Status not in ('Void','Unpaid','Prepared') and PaymentMode='VIP Member Card')G")
                    sqlCommand20.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.StartDate
                    sqlCommand20.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.EndDate
                    sqlCommand20.Connection = RestaurantPOS14.ModClasses.con
                    sqlCommand20.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                    RestaurantPOS14.ModClasses.rdr = sqlCommand20.ExecuteReader()
                    If RestaurantPOS14.ModClasses.rdr.Read() Then
                        Me.G4 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                    End If

                    RestaurantPOS14.ModClasses.con.Close()
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    Dim sqlCommand21 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT IsNull(Sum(GrandTotal),0) as [GrandTotal] from(Select GrandTotal as [GrandTotal] from RestaurantPOS_BillingInfoKOT where BillDate >=@d3 and BillDate < @d4 and DIB_Status not in ('Unpaid','Changed to Split Bill') and PaymentMode='Credit Customer'  Union all Select GrandTotal as [GrandTotal] from RestaurantPOS_BillingInfoTA where BillDate >=@d3 and BillDate < @d4 and TA_Status not in ('Void','Unpaid','Prepared') and PaymentMode='Credit Customer' Union all Select GrandTotal as [GrandTotal] from RestaurantPOS_BillingInfoHD where BillDate >=@d3 and BillDate < @d4 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') and PaymentMode='Credit Customer' Union all Select GrandTotal as [GrandTotal] from RestaurantPOS_BillingInfoEB where BillDate >=@d3 and BillDate < @d4 and EB_Status not in ('Void','Unpaid','Prepared') and PaymentMode='Credit Customer')G")
                    sqlCommand21.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.StartDate
                    sqlCommand21.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.EndDate
                    sqlCommand21.Connection = RestaurantPOS14.ModClasses.con
                    sqlCommand21.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                    RestaurantPOS14.ModClasses.rdr = sqlCommand21.ExecuteReader()
                    If RestaurantPOS14.ModClasses.rdr.Read() Then
                        Me.G5 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                    End If

                    RestaurantPOS14.ModClasses.con.Close()
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    Dim sqlCommand22 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT IsNull(Sum(TIP),0) as [TIP] from(Select Tip as [TIP] from RestaurantPOS_BillingInfoKOT where BillDate >=@d3 and BillDate < @d4 and DIB_Status not in ('Unpaid','Changed to Split Bill') Union all Select TIP as [TIP] from RestaurantPOS_BillingInfoTA where BillDate >=@d3 and BillDate < @d4 and TA_Status not in ('Void','Unpaid','Prepared')  Union all Select TIP as [TIP] from RestaurantPOS_BillingInfoHD where BillDate >=@d3 and BillDate < @d4 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched')  Union all Select TIP as [TIP] from RestaurantPOS_BillingInfoEB where BillDate >=@d3 and BillDate < @d4 and EB_Status not in ('Void','Unpaid','Prepared') )G")
                    sqlCommand22.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.StartDate
                    sqlCommand22.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.EndDate
                    sqlCommand22.Connection = RestaurantPOS14.ModClasses.con
                    sqlCommand22.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                    RestaurantPOS14.ModClasses.rdr = sqlCommand22.ExecuteReader()
                    If RestaurantPOS14.ModClasses.rdr.Read() Then
                        Me.T1 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                    End If

                    RestaurantPOS14.ModClasses.con.Close()
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    Dim sqlCommand23 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("select IsNull(Sum(NoOfPerson),0) from RestaurantPOS_OrderInfoKOT where BillDate >=@d9 and BillDate < @d10 and KOT_Status <> 'Void'")
                    sqlCommand23.Parameters.Add(CStr(("@d9")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.StartDate
                    sqlCommand23.Parameters.Add(CStr(("@d10")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.EndDate
                    sqlCommand23.Connection = RestaurantPOS14.ModClasses.con
                    sqlCommand23.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                    RestaurantPOS14.ModClasses.rdr = sqlCommand23.ExecuteReader()
                    If RestaurantPOS14.ModClasses.rdr.Read() Then
                        Me.TC = Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                    End If

                    RestaurantPOS14.ModClasses.con.Close()
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    Dim sqlCommand24 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT IsNULL(Count(Case when Canceled_Deleted ='Canceled' then 1 else NULL end),0),IsNULL(Count(Case when Canceled_Deleted ='Deleted' then 1 else NULL end),0),IsNULL(Sum(Case when Canceled_Deleted in ('Canceled') then GrandTotal else 0 end),0),IsNULL(Sum(Case when Canceled_Deleted in ('Deleted') then GrandTotal else 0 end),0) from DeletedInvoices where deletedDate >=@d13 and DeletedDate < @d14")
                    sqlCommand24.Parameters.Add(CStr(("@d13")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.StartDate
                    sqlCommand24.Parameters.Add(CStr(("@d14")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.EndDate
                    sqlCommand24.Connection = RestaurantPOS14.ModClasses.con
                    sqlCommand24.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                    RestaurantPOS14.ModClasses.rdr = sqlCommand24.ExecuteReader()
                    If RestaurantPOS14.ModClasses.rdr.Read() Then
                        Me.M1 = Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                        Me.M2 = Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(RestaurantPOS14.ModClasses.rdr.GetValue(1))
                        Me.M3 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(2))
                        Me.M4 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(3))
                    End If

                    RestaurantPOS14.ModClasses.con.Close()
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    Dim sqlCommand25 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT iSNULL(SUM(TotalDiscount),0) as TotalDiscount from (Select DiscountAmount as [TotalDiscount] from RestaurantPOS_OrderedProductBillKOT, RestaurantPOS_BillingInfoKOT where RestaurantPOS_BillingInfoKOT.ID=RestaurantPOS_OrderedProductBillKOT.BillID and BillDate >=@d3 and BillDate < @d4 and PaymentMode='Complimentary' and DIB_Status not in ('Unpaid','Changed to Split Bill') UNION ALL Select DiscountAmount as [TotalDiscount] from RestaurantPOS_OrderedProductBillTA, RestaurantPOS_BillingInfoTA where RestaurantPOS_BillingInfoTA.ID=RestaurantPOS_OrderedProductBillTA.BillID and BillDate >=@d3 and BillDate < @d4 and PaymentMode='Complimentary' and TA_Status not in ('Void','Unpaid','Prepared') UNION ALL Select DiscountAmount as [TotalDiscount] from RestaurantPOS_OrderedProductBillHD, RestaurantPOS_BillingInfoHD where RestaurantPOS_BillingInfoHD.ID=RestaurantPOS_OrderedProductBillHD.BillID and BillDate >=@d3 and BillDate < @d4 and PaymentMode='Complimentary' and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') Union all Select DiscountAmount as [TotalDiscount] from RestaurantPOS_OrderedProductBillEB, RestaurantPOS_BillingInfoEB where RestaurantPOS_BillingInfoEB.ID=RestaurantPOS_OrderedProductBillEB.BillID and BillDate >=@d3 and BillDate < @d4 and PaymentMode='Complimentary' and EB_Status not in ('Void','Unpaid','Prepared'))C")
                    sqlCommand25.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.StartDate
                    sqlCommand25.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.EndDate
                    sqlCommand25.Connection = RestaurantPOS14.ModClasses.con
                    sqlCommand25.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                    RestaurantPOS14.ModClasses.rdr = sqlCommand25.ExecuteReader()
                    If RestaurantPOS14.ModClasses.rdr.Read() Then
                        Me.CX = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                    End If

                    RestaurantPOS14.ModClasses.con.Close()
                    Me.S1 = RestaurantPOS14.ModFunc.GetParamValue("select IsNull(Sum(Amount),0) from Payment where Date >=@d1 and Date < @d2", Me.StartDate, Me.EndDate)
                    Me.S2 = RestaurantPOS14.ModFunc.GetParamValue("select IsNull(Sum(Amount),0) from CreditCustomerPayment where Date >=@d1 and Date < @d2", Me.StartDate, Me.EndDate)
                    Me.S3 = RestaurantPOS14.ModFunc.GetParamValue("select IsNull(Sum(GrandTotal),0) from Voucher where Date >=@d1 and Date < @d2", Me.StartDate, Me.EndDate)
                    Me.S4 = RestaurantPOS14.ModFunc.GetParamValue("select IsNull(Sum(GrandTotal),0) from RestaurantPOS_BillingInfoHD where BillDate >=@d1 and BillDate < @d2 and HD_Status not in ('Cancelled') and PaymentMode in ('Cash')", Me.StartDate, Me.EndDate)
                    Me.S5 = RestaurantPOS14.ModFunc.GetParamValue("select IsNull(Sum(GrandTotal),0)-IsNull(Sum(AmtReceived),0) from RestaurantPOS_BillingInfoHD where BillDate >=@d1 and BillDate < @d2 and HD_Status not in ('Cancelled') and PaymentMode in ('Cash')", Me.StartDate, Me.EndDate)
                    Dim dataTable As System.Data.DataTable = New System.Data.DataTable()
                    Dim dataTable2 As System.Data.DataTable = New System.Data.DataTable()
                    Dim dataTable3 As System.Data.DataTable = New System.Data.DataTable()
                    Dim dataTable4 As System.Data.DataTable = New System.Data.DataTable()
                    Dim dataTable5 As System.Data.DataTable = New System.Data.DataTable()
                    Dim dataTable6 As System.Data.DataTable = New System.Data.DataTable()
                    sqlDataAdapter.Fill(dataTable)
                    sqlDataAdapter2.Fill(dataTable2)
                    sqlDataAdapter3.Fill(dataTable3)
                    sqlDataAdapter4.Fill(dataTable4)
                    sqlDataAdapter5.Fill(dataTable5)
                    sqlDataAdapter6.Fill(dataTable6)
                    Dim dataSet As System.Data.DataSet = New System.Data.DataSet()
                    dataSet.Tables.Add(dataTable)
                    dataSet.Tables.Add(dataTable2)
                    dataSet.Tables.Add(dataTable3)
                    dataSet.Tables.Add(dataTable4)
                    dataSet.Tables.Add(dataTable5)
                    dataSet.Tables.Add(dataTable6)
                    dataSet.WriteXmlSchema("RPOSLatest.xml")
                    Dim rptRPOS3 As RestaurantPOS14.rptRPOS = New RestaurantPOS14.rptRPOS()
                    rptRPOS3.Subreports(CInt((0))).SetDataSource(dataSet)
                    rptRPOS3.Subreports(CInt((1))).SetDataSource(dataSet)
                    rptRPOS3.Subreports(CInt((2))).SetDataSource(dataSet)
                    rptRPOS3.Subreports(CInt((3))).SetDataSource(dataSet)
                    rptRPOS3.Subreports(CInt((4))).SetDataSource(dataSet)
                    rptRPOS3.Subreports(CInt((5))).SetDataSource(dataSet)
                    rptRPOS3.SetDataSource(dataSet)
                    rptRPOS3.SetParameterValue("p1", Me.StartDate.ToString("dd/MM/yyyy hh:mm:ss tt"))
                    rptRPOS3.SetParameterValue("p2", Me.EndDate.ToString("dd/MM/yyyy hh:mm:ss tt"))
                    rptRPOS3.SetParameterValue("p3", Me.a)
                    rptRPOS3.SetParameterValue("p4", Me.b)
                    rptRPOS3.SetParameterValue("p5", Me.a)
                    rptRPOS3.SetParameterValue("p6", Me.b)
                    rptRPOS3.SetParameterValue("b1", Me.b1)
                    rptRPOS3.SetParameterValue("b2", Me.b2)
                    rptRPOS3.SetParameterValue("b3", Me.b3)
                    rptRPOS3.SetParameterValue("b4", Me.b4)
                    rptRPOS3.SetParameterValue("b1x", Me.b1)
                    rptRPOS3.SetParameterValue("b2x", Me.b2)
                    rptRPOS3.SetParameterValue("b3x", Me.b3)
                    rptRPOS3.SetParameterValue("b4x", Me.b4)
                    rptRPOS3.SetParameterValue("b5", Me.b5)
                    rptRPOS3.SetParameterValue("Z1", Me.Z1)
                    rptRPOS3.SetParameterValue("Z2", Me.Z2)
                    rptRPOS3.SetParameterValue("Z3", Me.Z1)
                    rptRPOS3.SetParameterValue("Z4", Me.Z2)
                    rptRPOS3.SetParameterValue("G1", Me.G1)
                    rptRPOS3.SetParameterValue("G2", Me.G2)
                    rptRPOS3.SetParameterValue("G3", Me.G3)
                    rptRPOS3.SetParameterValue("G4", Me.G4)
                    rptRPOS3.SetParameterValue("G5", Me.G5)
                    rptRPOS3.SetParameterValue("T1", Me.T1)
                    rptRPOS3.SetParameterValue("T2", Me.T1)
                    rptRPOS3.SetParameterValue("T3", Me.T1)
                    rptRPOS3.SetParameterValue("CS", Me.TC)
                    rptRPOS3.SetParameterValue("D1", Me.D1)
                    rptRPOS3.SetParameterValue("M1", Me.M1)
                    rptRPOS3.SetParameterValue("M2", Me.M2)
                    rptRPOS3.SetParameterValue("M3", Me.M3)
                    rptRPOS3.SetParameterValue("M4", Me.M4)
                    rptRPOS3.SetParameterValue("CX", Me.CX)
                    rptRPOS3.SetParameterValue("S1", Me.S1)
                    rptRPOS3.SetParameterValue("S2", Me.S2)
                    rptRPOS3.SetParameterValue("S3", Me.S3)
                    rptRPOS3.SetParameterValue("S4", Me.S4)
                    rptRPOS3.SetParameterValue("S5", Me.S5)
                    RestaurantPOS14.My.MyProject.Forms.frmWPReport_CRViewer.CrystalReportViewer1.ReportSource = rptRPOS3
                    RestaurantPOS14.My.MyProject.Forms.frmWPReport_CRViewer.dtpDateFrom.Value = Me.StartDate
                    RestaurantPOS14.My.MyProject.Forms.frmWPReport_CRViewer.dtpDateTo.Value = Me.EndDate
                    RestaurantPOS14.My.MyProject.Forms.frmWPReport_CRViewer.txtEmailID.Text = ""
                    Call RestaurantPOS14.My.MyProject.Forms.frmWPReport_CRViewer.ShowDialog()
                    rptRPOS3.Close()
                    rptRPOS3.Dispose()
                End If

                RestaurantPOS14.ModClasses.con.Close()
                If Not RestaurantPOS14.ModFunc.CheckForInternetConnection() Then
                    Return
                End If

                MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Me.Timer3.Enabled = True
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select RTRIM(Username),RTRIM(Password),RTRIM(SMTPAddress),(Port) from EmailSetting where IsDefault='Yes' and IsActive='Yes'")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                Dim sqlDataReader As System.Data.SqlClient.SqlDataReader = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If Not sqlDataReader.Read() Then
                    Return
                End If

                MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Me.Timer3.Enabled = True
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand26 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("select Operator from RestaurantPOS_BillingInfoKOT where BillDate >=@d1 and BillDate < @d2 and DIB_Status not in ('Unpaid','Changed to Split Bill') union select Operator from RestaurantPOS_BillingInfoTA where BillDate >=@d1 and BillDate < @d2 and TA_Status not in ('Void','Unpaid','Prepared') union select Operator from RestaurantPOS_BillingInfoHD where BillDate >=@d1 and BillDate < @d2 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') Union select Operator from RestaurantPOS_BillingInfoEB where BillDate >=@d1 and BillDate < @d2 and EB_Status not in ('Void','Unpaid','Prepared')")
                sqlCommand26.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.StartDate
                sqlCommand26.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.EndDate
                sqlCommand26.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand26.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand26.ExecuteReader()
                If Not RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Sorry..No record found between selected dates", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand27 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT * from Hotel", RestaurantPOS14.ModClasses.con)
                Dim sqlDataAdapter7 As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(sqlCommand27)
                sqlCommand27.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                Dim sqlCommand28 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT Operator,Sum(GrandTotal) as [GrandTotal] from(Select Operator,(GrandTotal*ExchangeRate) as [GrandTotal] from RestaurantPOS_BillingInfoKOT where BillDate >=@d1 and BillDate < @d2 and DIB_Status not in ('Unpaid','Changed to Split Bill')  Union all Select Operator,(GrandTotal*ExchangeRate) as [GrandTotal] from RestaurantPOS_BillingInfoTA where BillDate >=@d1 and BillDate < @d2 and TA_Status not in ('Void','Unpaid','Prepared') Union all Select Operator,GrandTotal as [GrandTotal] from RestaurantPOS_BillingInfoHD where BillDate >=@d1 and BillDate < @d2 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') Union all Select Operator,(GrandTotal*ExchangeRate) as [GrandTotal] from RestaurantPOS_BillingInfoEB where BillDate >=@d1 and BillDate < @d2 and EB_Status not in ('Void','Unpaid','Prepared'))G  group by Operator order by 1", RestaurantPOS14.ModClasses.con)
                sqlCommand28.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.StartDate
                sqlCommand28.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.EndDate
                sqlCommand28.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                Dim sqlDataAdapter8 As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(sqlCommand28)
                Dim sqlCommand29 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT Category,Sum(TotalAmount) as Total from (Select category,(TotalAmount*ExchangeRate) as [TotalAmount] from RestaurantPOS_OrderedProductBillKOT, RestaurantPOS_BillingInfoKOT where RestaurantPOS_BillingInfoKOT.ID=RestaurantPOS_OrderedProductBillKOT.BillID and BillDate >=@d3 and BillDate < @d4 and DIB_Status not in ('Unpaid','Changed to Split Bill') UNION ALL Select category,(TotalAmount*ExchangeRate) as [TotalAmount] from RestaurantPOS_OrderedProductBillTA, RestaurantPOS_BillingInfoTA where RestaurantPOS_BillingInfoTA.ID=RestaurantPOS_OrderedProductBillTA.BillID and BillDate >=@d3 and BillDate < @d4 and TA_Status not in ('Void','Unpaid','Prepared') UNION ALL Select category,(TotalAmount) as [TotalAmount] from RestaurantPOS_OrderedProductBillHD, RestaurantPOS_BillingInfoHD where RestaurantPOS_BillingInfoHD.ID=RestaurantPOS_OrderedProductBillHD.BillID and BillDate >=@d3 and BillDate < @d4 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') Union all Select category,(TotalAmount*ExchangeRate) as [TotalAmount] from RestaurantPOS_OrderedProductBillEB, RestaurantPOS_BillingInfoEB where RestaurantPOS_BillingInfoEB.ID=RestaurantPOS_OrderedProductBillEB.BillID and BillDate >=@d3 and BillDate < @d4 and EB_Status not in ('Void','Unpaid','Prepared'))C group by Category order by 1", RestaurantPOS14.ModClasses.con)
                sqlCommand29.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.StartDate
                sqlCommand29.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.EndDate
                sqlCommand29.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                Dim sqlDataAdapter9 As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(sqlCommand29)
                Dim sqlCommand30 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT Category,Sum(Quantity) as TotalQuantity from (Select category,Quantity from RestaurantPOS_OrderedProductBillKOT, RestaurantPOS_BillingInfoKOT where RestaurantPOS_BillingInfoKOT.ID=RestaurantPOS_OrderedProductBillKOT.BillID and BillDate >=@d5 and BillDate < @d6 and DIB_Status not in ('Unpaid','Changed to Split Bill') UNION ALL Select category,Quantity from RestaurantPOS_OrderedProductBillTA, RestaurantPOS_BillingInfoTA where RestaurantPOS_BillingInfoTA.ID=RestaurantPOS_OrderedProductBillTA.BillID and BillDate >=@d5 and BillDate < @d6 and TA_Status not in ('Void','Unpaid','Prepared') UNION ALL Select category,Quantity from RestaurantPOS_OrderedProductBillHD, RestaurantPOS_BillingInfoHD where RestaurantPOS_BillingInfoHD.ID=RestaurantPOS_OrderedProductBillHD.BillID and BillDate >=@d5 and BillDate < @d6 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') Union all Select category,Quantity from RestaurantPOS_OrderedProductBillEB, RestaurantPOS_BillingInfoEB where RestaurantPOS_BillingInfoEB.ID=RestaurantPOS_OrderedProductBillEB.BillID and BillDate >=@d5 and BillDate < @d6 and EB_Status not in ('Void','Unpaid','Prepared'))C group by Category order by 1", RestaurantPOS14.ModClasses.con)
                sqlCommand30.Parameters.Add(CStr(("@d5")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.StartDate
                sqlCommand30.Parameters.Add(CStr(("@d6")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.EndDate
                sqlCommand30.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                Dim sqlDataAdapter10 As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(sqlCommand30)
                Dim sqlCommand31 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT Dish,Sum(Quantity) as [Quantity],Sum(TotalAmount) as [Amount] from (Select Dish,Quantity,(TotalAmount*ExchangeRate) as [TotalAmount] from RestaurantPOS_OrderedProductBillKOT,RestaurantPOS_BillingInfoKOT where BillDate >=@d7 and BillDate < @d8 and DIB_Status not in ('Unpaid','Changed to Split Bill') and RestaurantPOS_BillingInfoKOT.ID=RestaurantPOS_OrderedProductBillKOT.BillID Union All Select Dish,Quantity,(TotalAmount*ExchangeRate) as [TotalAmount] from RestaurantPOS_OrderedProductBillTA,RestaurantPOS_BillingInfoTA where BillDate >=@d7 and BillDate < @d8 and RestaurantPOS_BillingInfoTA.ID=RestaurantPOS_OrderedProductBillTA.BillID and TA_Status not in ('Void','Unpaid','Prepared') Union All Select Dish,Quantity,TotalAmount as [TotalAmount] from RestaurantPOS_OrderedProductBillHD,RestaurantPOS_BillingInfoHD where BillDate >=@d7 and BillDate < @d8 and RestaurantPOS_BillingInfoHD.ID=RestaurantPOS_OrderedProductBillHD.BillID and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') Union all Select Dish,Quantity,(TotalAmount*ExchangeRate) as [TotalAmount] from RestaurantPOS_OrderedProductBillEB,RestaurantPOS_BillingInfoEB where BillDate >=@d7 and BillDate < @d8 and RestaurantPOS_BillingInfoEB.ID=RestaurantPOS_OrderedProductBillEB.BillID and EB_Status not in ('Void','Unpaid','Prepared'))G  group by Dish order by 1", RestaurantPOS14.ModClasses.con)
                sqlCommand31.Parameters.Add(CStr(("@d7")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.StartDate
                sqlCommand31.Parameters.Add(CStr(("@d8")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.EndDate
                sqlCommand31.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                Dim sqlDataAdapter11 As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(sqlCommand31)
                Dim sqlCommand32 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT PaymentMode,IsNull(Sum(Card),0) as [Card] from (Select PaymentMode,Card as [Card] from RestaurantPOS_BillingInfoKOT where BillDate >=@d11 and BillDate < @d12 and DIB_Status not in ('Unpaid','Changed to Split Bill') and PaymentMode Not in ('Cash','Credit Card','Debit Card','Credit Customer','VIP Member Card') Union All Select  PaymentMode,(Card) as [Card] from RestaurantPOS_BillingInfoTA where BillDate >=@d11 and BillDate < @d12 and TA_Status not in ('Void','Unpaid','Prepared') and PaymentMode Not in ('Cash','Credit Card','Debit Card','Credit Customer','VIP Member Card') Union All Select  PaymentMode,GrandTotal as [Card] from RestaurantPOS_BillingInfoHD where BillDate >=@d11 and BillDate < @d12 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') and PaymentMode Not in ('Cash','Credit Card','Debit Card','Credit Customer','VIP Member Card') Union all Select PaymentMode,(Card) as [Card] from RestaurantPOS_BillingInfoEB where BillDate >=@d11 and BillDate < @d12 and EB_Status not in ('Void','Unpaid','Prepared') and PaymentMode Not in ('Cash','Credit Card','Debit Card','Credit Customer','VIP Member Card'))G  group by PaymentMode order by 1", RestaurantPOS14.ModClasses.con)
                sqlCommand32.Parameters.Add(CStr(("@d11")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.StartDate
                sqlCommand32.Parameters.Add(CStr(("@d12")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.EndDate
                sqlCommand32.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                Dim sqlDataAdapter12 As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(sqlCommand32)
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand33 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("select IsNull(Sum(HomeDeliveryCharges),0) from RestaurantPOS_BillingInfoHD where BillDate >=@d9 and BillDate < @d10 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched')")
                sqlCommand33.Parameters.Add(CStr(("@d9")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.StartDate
                sqlCommand33.Parameters.Add(CStr(("@d10")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.EndDate
                sqlCommand33.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand33.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand33.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.a = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand34 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("select IsNull(Sum(ParcelCharges*ExchangeRate),0) from RestaurantPOS_BillingInfoTA where BillDate >=@d11 and BillDate < @d12 and TA_Status not in ('Void','Unpaid','Prepared')")
                sqlCommand34.Parameters.Add(CStr(("@d11")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.StartDate
                sqlCommand34.Parameters.Add(CStr(("@d12")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.EndDate
                sqlCommand34.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand34.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand34.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.b = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand35 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("Select IsNull(Sum(GrandTotal*ExchangeRate),0)  from RestaurantPOS_BillingInfoKOT where BillDate >=@d13 and BillDate < @d14 and DIB_Status not in ('Unpaid','Changed to Split Bill')")
                sqlCommand35.Parameters.Add(CStr(("@d13")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.StartDate
                sqlCommand35.Parameters.Add(CStr(("@d14")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.EndDate
                sqlCommand35.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand35.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand35.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.b1 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand36 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("Select IsNull(Sum(GrandTotal*ExchangeRate),0)  from RestaurantPOS_BillingInfoTA where BillDate >=@d13 and BillDate < @d14 and TA_Status not in ('Void','Unpaid','Prepared')")
                sqlCommand36.Parameters.Add(CStr(("@d13")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.StartDate
                sqlCommand36.Parameters.Add(CStr(("@d14")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.EndDate
                sqlCommand36.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand36.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand36.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.b2 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand37 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("Select IsNull(Sum(GrandTotal),0)  from RestaurantPOS_BillingInfoHD where BillDate >=@d13 and BillDate < @d14 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched')")
                sqlCommand37.Parameters.Add(CStr(("@d13")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.StartDate
                sqlCommand37.Parameters.Add(CStr(("@d14")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.EndDate
                sqlCommand37.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand37.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand37.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.b3 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand38 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("Select IsNull(Sum(GrandTotal*ExchangeRate),0)  from RestaurantPOS_BillingInfoEB where BillDate >=@d13 and BillDate < @d14 and EB_Status not in ('Void','Unpaid','Prepared')")
                sqlCommand38.Parameters.Add(CStr(("@d13")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.StartDate
                sqlCommand38.Parameters.Add(CStr(("@d14")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.EndDate
                sqlCommand38.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand38.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand38.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.b4 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand39 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT Sum(TotalVAT) as TotalVAT,SUM(TotalDiscount) as TotalDicount from (Select VATAmount as [TotalVAT],DiscountAmount as [TotalDiscount] from RestaurantPOS_OrderedProductBillKOT, RestaurantPOS_BillingInfoKOT where RestaurantPOS_BillingInfoKOT.ID=RestaurantPOS_OrderedProductBillKOT.BillID and BillDate >=@d3 and BillDate < @d4 and DIB_Status not in ('Unpaid','Changed to Split Bill') UNION ALL Select VATAmount as [TotalVAT],DiscountAmount as [TotalDiscount] from RestaurantPOS_OrderedProductBillTA, RestaurantPOS_BillingInfoTA where RestaurantPOS_BillingInfoTA.ID=RestaurantPOS_OrderedProductBillTA.BillID and BillDate >=@d3 and BillDate < @d4 and TA_Status not in ('Void','Unpaid','Prepared') UNION ALL Select VATAmount as [TotalVAT],DiscountAmount as [TotalDiscount] from RestaurantPOS_OrderedProductBillHD, RestaurantPOS_BillingInfoHD where RestaurantPOS_BillingInfoHD.ID=RestaurantPOS_OrderedProductBillHD.BillID and BillDate >=@d3 and BillDate < @d4 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') Union all Select VATAmount as [TotalVAT],DiscountAmount as [TotalDiscount] from RestaurantPOS_OrderedProductBillEB, RestaurantPOS_BillingInfoEB where RestaurantPOS_BillingInfoEB.ID=RestaurantPOS_OrderedProductBillEB.BillID and BillDate >=@d3 and BillDate < @d4 and EB_Status not in ('Void','Unpaid','Prepared'))C")
                sqlCommand39.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.StartDate
                sqlCommand39.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.EndDate
                sqlCommand39.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand39.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand39.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.b5 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                    Me.D1 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(1))
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand40 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT Sum(LA) as [LA] from(Select LA as [LA] from RestaurantPOS_BillingInfoKOT where BillDate >=@d3 and BillDate < @d4 and DIB_Status not in ('Unpaid','Changed to Split Bill')  Union all Select LA as [LA] from RestaurantPOS_BillingInfoTA where BillDate >=@d3 and BillDate < @d4 and TA_Status not in ('Void','Unpaid','Prepared') Union all Select LA as [LA] from RestaurantPOS_BillingInfoHD where BillDate >=@d3 and BillDate < @d4 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') Union all Select LA as [LA] from RestaurantPOS_BillingInfoEB where BillDate >=@d3 and BillDate < @d4 and EB_Status not in ('Void','Unpaid','Prepared'))G")
                sqlCommand40.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.StartDate
                sqlCommand40.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.EndDate
                sqlCommand40.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand40.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand40.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.Z1 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand41 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT Sum(GCA) as [GCA] from(Select GiftCardAmount as [GCA] from RestaurantPOS_BillingInfoKOT where BillDate >=@d3 and BillDate < @d4 and DIB_Status not in ('Unpaid','Changed to Split Bill')  Union all Select GiftCardAmount as [GCA] from RestaurantPOS_BillingInfoTA where BillDate >=@d3 and BillDate < @d4 and TA_Status not in ('Void','Unpaid','Prepared') Union all Select GiftCardAmount as [GCA] from RestaurantPOS_BillingInfoHD where BillDate >=@d3 and BillDate < @d4 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') Union all Select GiftCardAmount as [GCA] from RestaurantPOS_BillingInfoEB where BillDate >=@d3 and BillDate < @d4 and EB_Status not in ('Void','Unpaid','Prepared'))G")
                sqlCommand41.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.StartDate
                sqlCommand41.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.EndDate
                sqlCommand41.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand41.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand41.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.Z2 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand42 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("Select IsNull(Sum(Cash),0) as [Cash] from(Select Cash - Change as [Cash] from RestaurantPOS_BillingInfoKOT where BillDate >=@d3 and BillDate < @d4 and DIB_Status not in ('Unpaid','Changed to Split Bill')  Union all Select Cash - Change as [Cash] from RestaurantPOS_BillingInfoTA where BillDate >=@d3 and BillDate < @d4 and TA_Status not in ('Void','Unpaid','Prepared') Union all Select GrandTotal as [Cash] from RestaurantPOS_BillingInfoHD where BillDate >=@d3 and BillDate < @d4 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') and PaymentMode='Cash' Union all Select Cash - Change as [Cash] from RestaurantPOS_BillingInfoEB where BillDate >=@d3 and BillDate < @d4 and EB_Status not in ('Void','Unpaid','Prepared'))G")
                sqlCommand42.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.StartDate
                sqlCommand42.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.EndDate
                sqlCommand42.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand42.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand42.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.G1 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand43 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("Select IsNull(Sum(Cash),0) as [Cash] from(Select Card-Change as [Cash] from RestaurantPOS_BillingInfoKOT where BillDate >=@d3 and BillDate < @d4 and DIB_Status not in ('Unpaid','Changed to Split Bill') and PaymentMode='Credit Card'  Union all Select Card-Change as [Cash] from RestaurantPOS_BillingInfoTA where BillDate >=@d3 and BillDate < @d4 and TA_Status not in ('Void','Unpaid','Prepared') and PaymentMode='Credit Card' Union all Select GrandTotal as [Cash] from RestaurantPOS_BillingInfoHD where BillDate >=@d3 and BillDate < @d4 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') and PaymentMode='Credit Card' Union all Select Card-Change as [Cash] from RestaurantPOS_BillingInfoEB where BillDate >=@d3 and BillDate < @d4 and EB_Status not in ('Void','Unpaid','Prepared') and PaymentMode='Credit Card')G")
                sqlCommand43.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.StartDate
                sqlCommand43.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.EndDate
                sqlCommand43.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand43.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand43.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.G2 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand44 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("Select IsNull(Sum(Cash),0) as [Cash] from(Select Card-Change as [Cash] from RestaurantPOS_BillingInfoKOT where BillDate >=@d3 and BillDate < @d4 and DIB_Status not in ('Unpaid','Changed to Split Bill') and PaymentMode='Debit Card'  Union all Select Card-Change as [Cash] from RestaurantPOS_BillingInfoTA where BillDate >=@d3 and BillDate < @d4 and TA_Status not in ('Void','Unpaid','Prepared') and PaymentMode='Debit Card' Union all Select GrandTotal as [Cash] from RestaurantPOS_BillingInfoHD where BillDate >=@d3 and BillDate < @d4 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') and PaymentMode='Debit Card' Union all Select Card-Change as [Cash] from RestaurantPOS_BillingInfoEB where BillDate >=@d3 and BillDate < @d4 and EB_Status not in ('Void','Unpaid','Prepared') and PaymentMode='Debit Card')G")
                sqlCommand44.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.StartDate
                sqlCommand44.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.EndDate
                sqlCommand44.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand44.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand44.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.G3 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand45 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT IsNull(Sum(Cash),0) as [Cash] from(Select Card-Change as [Cash] from RestaurantPOS_BillingInfoKOT where BillDate >=@d3 and BillDate < @d4 and DIB_Status not in ('Unpaid','Changed to Split Bill') and PaymentMode='VIP Member Card'  Union all Select Card-Change as [Cash] from RestaurantPOS_BillingInfoTA where BillDate >=@d3 and BillDate < @d4 and TA_Status not in ('Void','Unpaid','Prepared') and PaymentMode='VIP Member Card' Union all Select GrandTotal as [Cash] from RestaurantPOS_BillingInfoHD where BillDate >=@d3 and BillDate < @d4 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') and PaymentMode='VIP Member Card' Union all Select Card-Change as [Cash] from RestaurantPOS_BillingInfoEB where BillDate >=@d3 and BillDate < @d4 and EB_Status not in ('Void','Unpaid','Prepared') and PaymentMode='VIP Member Card')G")
                sqlCommand45.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.StartDate
                sqlCommand45.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.EndDate
                sqlCommand45.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand45.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand45.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.G4 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand46 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT IsNull(Sum(GrandTotal),0) as [GrandTotal] from(Select GrandTotal as [GrandTotal] from RestaurantPOS_BillingInfoKOT where BillDate >=@d3 and BillDate < @d4 and DIB_Status not in ('Unpaid','Changed to Split Bill') and PaymentMode='Credit Customer'  Union all Select GrandTotal as [GrandTotal] from RestaurantPOS_BillingInfoTA where BillDate >=@d3 and BillDate < @d4 and TA_Status not in ('Void','Unpaid','Prepared') and PaymentMode='Credit Customer' Union all Select GrandTotal as [GrandTotal] from RestaurantPOS_BillingInfoHD where BillDate >=@d3 and BillDate < @d4 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') and PaymentMode='Credit Customer' Union all Select GrandTotal as [GrandTotal] from RestaurantPOS_BillingInfoEB where BillDate >=@d3 and BillDate < @d4 and EB_Status not in ('Void','Unpaid','Prepared') and PaymentMode='Credit Customer')G")
                sqlCommand46.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.StartDate
                sqlCommand46.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.EndDate
                sqlCommand46.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand46.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand46.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.G5 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand47 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT IsNull(Sum(TIP),0) as [TIP] from(Select Tip as [TIP] from RestaurantPOS_BillingInfoKOT where BillDate >=@d3 and BillDate < @d4 and DIB_Status not in ('Unpaid','Changed to Split Bill') Union all Select TIP as [TIP] from RestaurantPOS_BillingInfoTA where BillDate >=@d3 and BillDate < @d4 and TA_Status not in ('Void','Unpaid','Prepared')  Union all Select TIP as [TIP] from RestaurantPOS_BillingInfoHD where BillDate >=@d3 and BillDate < @d4 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched')  Union all Select TIP as [TIP] from RestaurantPOS_BillingInfoEB where BillDate >=@d3 and BillDate < @d4 and EB_Status not in ('Void','Unpaid','Prepared') )G")
                sqlCommand47.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.StartDate
                sqlCommand47.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.EndDate
                sqlCommand47.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand47.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand47.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.T1 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand48 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("select IsNull(Sum(NoOfPerson),0) from RestaurantPOS_OrderInfoKOT where BillDate >=@d9 and BillDate < @d10 and KOT_Status <> 'Void'")
                sqlCommand48.Parameters.Add(CStr(("@d9")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.StartDate
                sqlCommand48.Parameters.Add(CStr(("@d10")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.EndDate
                sqlCommand48.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand48.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand48.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.TC = Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand49 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT IsNULL(Count(Case when Canceled_Deleted ='Canceled' then 1 else NULL end),0),IsNULL(Count(Case when Canceled_Deleted ='Deleted' then 1 else NULL end),0),IsNULL(Sum(Case when Canceled_Deleted in ('Canceled') then GrandTotal else 0 end),0),IsNULL(Sum(Case when Canceled_Deleted in ('Deleted') then GrandTotal else 0 end),0) from DeletedInvoices where deletedDate >=@d13 and DeletedDate < @d14")
                sqlCommand49.Parameters.Add(CStr(("@d13")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.StartDate
                sqlCommand49.Parameters.Add(CStr(("@d14")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.EndDate
                sqlCommand49.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand49.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand49.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.M1 = Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                    Me.M2 = Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(RestaurantPOS14.ModClasses.rdr.GetValue(1))
                    Me.M3 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(2))
                    Me.M4 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(3))
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand50 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT iSNULL(SUM(TotalDiscount),0) as TotalDiscount from (Select DiscountAmount as [TotalDiscount] from RestaurantPOS_OrderedProductBillKOT, RestaurantPOS_BillingInfoKOT where RestaurantPOS_BillingInfoKOT.ID=RestaurantPOS_OrderedProductBillKOT.BillID and BillDate >=@d3 and BillDate < @d4 and PaymentMode='Complimentary' and DIB_Status not in ('Unpaid','Changed to Split Bill') UNION ALL Select DiscountAmount as [TotalDiscount] from RestaurantPOS_OrderedProductBillTA, RestaurantPOS_BillingInfoTA where RestaurantPOS_BillingInfoTA.ID=RestaurantPOS_OrderedProductBillTA.BillID and BillDate >=@d3 and BillDate < @d4 and PaymentMode='Complimentary' and TA_Status not in ('Void','Unpaid','Prepared') UNION ALL Select DiscountAmount as [TotalDiscount] from RestaurantPOS_OrderedProductBillHD, RestaurantPOS_BillingInfoHD where RestaurantPOS_BillingInfoHD.ID=RestaurantPOS_OrderedProductBillHD.BillID and BillDate >=@d3 and BillDate < @d4 and PaymentMode='Complimentary' and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') Union all Select DiscountAmount as [TotalDiscount] from RestaurantPOS_OrderedProductBillEB, RestaurantPOS_BillingInfoEB where RestaurantPOS_BillingInfoEB.ID=RestaurantPOS_OrderedProductBillEB.BillID and BillDate >=@d3 and BillDate < @d4 and PaymentMode='Complimentary' and EB_Status not in ('Void','Unpaid','Prepared'))C")
                sqlCommand50.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.StartDate
                sqlCommand50.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.EndDate
                sqlCommand50.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand50.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand50.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.CX = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If

                RestaurantPOS14.ModClasses.con.Close()
                Me.S1 = RestaurantPOS14.ModFunc.GetParamValue("select IsNull(Sum(Amount),0) from Payment where Date >=@d1 and Date < @d2", Me.StartDate, Me.EndDate)
                Me.S2 = RestaurantPOS14.ModFunc.GetParamValue("select IsNull(Sum(Amount),0) from CreditCustomerPayment where Date >=@d1 and Date < @d2", Me.StartDate, Me.EndDate)
                Me.S3 = RestaurantPOS14.ModFunc.GetParamValue("select IsNull(Sum(GrandTotal),0) from Voucher where Date >=@d1 and Date < @d2", Me.StartDate, Me.EndDate)
                Me.S4 = RestaurantPOS14.ModFunc.GetParamValue("select IsNull(Sum(GrandTotal),0) from RestaurantPOS_BillingInfoHD where BillDate >=@d1 and BillDate < @d2 and HD_Status not in ('Cancelled') and PaymentMode in ('Cash')", Me.StartDate, Me.EndDate)
                Me.S5 = RestaurantPOS14.ModFunc.GetParamValue("select IsNull(Sum(GrandTotal),0)-IsNull(Sum(AmtReceived),0) from RestaurantPOS_BillingInfoHD where BillDate >=@d1 and BillDate < @d2 and HD_Status not in ('Cancelled') and PaymentMode in ('Cash')", Me.StartDate, Me.EndDate)
                Dim dataTable7 As System.Data.DataTable = New System.Data.DataTable()
                Dim dataTable8 As System.Data.DataTable = New System.Data.DataTable()
                Dim dataTable9 As System.Data.DataTable = New System.Data.DataTable()
                Dim dataTable10 As System.Data.DataTable = New System.Data.DataTable()
                Dim dataTable11 As System.Data.DataTable = New System.Data.DataTable()
                Dim dataTable12 As System.Data.DataTable = New System.Data.DataTable()
                sqlDataAdapter7.Fill(dataTable7)
                sqlDataAdapter8.Fill(dataTable8)
                sqlDataAdapter9.Fill(dataTable9)
                sqlDataAdapter10.Fill(dataTable10)
                sqlDataAdapter11.Fill(dataTable11)
                sqlDataAdapter12.Fill(dataTable12)
                Dim dataSet2 As System.Data.DataSet = New System.Data.DataSet()
                dataSet2.Tables.Add(dataTable7)
                dataSet2.Tables.Add(dataTable8)
                dataSet2.Tables.Add(dataTable9)
                dataSet2.Tables.Add(dataTable10)
                dataSet2.Tables.Add(dataTable11)
                dataSet2.Tables.Add(dataTable12)
                dataSet2.WriteXmlSchema("RPOSLatest.xml")
                Dim obj As RestaurantPOS14.rptRPOS = New RestaurantPOS14.rptRPOS()
                obj.Subreports(CInt((0))).SetDataSource(dataSet2)
                obj.Subreports(CInt((1))).SetDataSource(dataSet2)
                obj.Subreports(CInt((2))).SetDataSource(dataSet2)
                obj.Subreports(CInt((3))).SetDataSource(dataSet2)
                obj.Subreports(CInt((4))).SetDataSource(dataSet2)
                obj.Subreports(CInt((5))).SetDataSource(dataSet2)
                obj.SetDataSource(dataSet2)
                obj.SetParameterValue("p1", Me.StartDate.ToString("dd/MM/yyyy hh:mm:ss tt"))
                obj.SetParameterValue("p2", Me.EndDate.ToString("dd/MM/yyyy hh:mm:ss tt"))
                obj.SetParameterValue("p3", Me.a)
                obj.SetParameterValue("p4", Me.b)
                obj.SetParameterValue("p5", Me.a)
                obj.SetParameterValue("p6", Me.b)
                obj.SetParameterValue("b1", Me.b1)
                obj.SetParameterValue("b2", Me.b2)
                obj.SetParameterValue("b3", Me.b3)
                obj.SetParameterValue("b4", Me.b4)
                obj.SetParameterValue("b1x", Me.b1)
                obj.SetParameterValue("b2x", Me.b2)
                obj.SetParameterValue("b3x", Me.b3)
                obj.SetParameterValue("b4x", Me.b4)
                obj.SetParameterValue("b5", Me.b5)
                obj.SetParameterValue("Z1", Me.Z1)
                obj.SetParameterValue("Z2", Me.Z2)
                obj.SetParameterValue("Z3", Me.Z1)
                obj.SetParameterValue("Z4", Me.Z2)
                obj.SetParameterValue("G1", Me.G1)
                obj.SetParameterValue("G2", Me.G2)
                obj.SetParameterValue("G3", Me.G3)
                obj.SetParameterValue("G4", Me.G4)
                obj.SetParameterValue("G5", Me.G5)
                obj.SetParameterValue("T1", Me.T1)
                obj.SetParameterValue("T2", Me.T1)
                obj.SetParameterValue("T3", Me.T1)
                obj.SetParameterValue("CS", Me.TC)
                obj.SetParameterValue("D1", Me.D1)
                obj.SetParameterValue("M1", Me.M1)
                obj.SetParameterValue("M2", Me.M2)
                obj.SetParameterValue("M3", Me.M3)
                obj.SetParameterValue("M4", Me.M4)
                obj.SetParameterValue("CX", Me.CX)
                obj.SetParameterValue("S1", Me.S1)
                obj.SetParameterValue("S2", Me.S2)
                obj.SetParameterValue("S3", Me.S3)
                obj.SetParameterValue("S4", Me.S4)
                obj.SetParameterValue("S5", Me.S5)
                Dim text As String = RestaurantPOS14.Customization.CrystalReportExporter.Export(obj, obj.GetType().Name, "WorkPeriodReport")
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtEmailID.Text, "", TextCompare:=False) <> 0 Then
                    RestaurantPOS14.ModFunc.SendMail1(Microsoft.VisualBasic.CompilerServices.Conversions.ToString(sqlDataReader.GetValue(0)), Me.txtEmailID.Text, "Please find the attachment below", text, "Work Period Report", Microsoft.VisualBasic.CompilerServices.Conversions.ToString(sqlDataReader.GetValue(2)), Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(sqlDataReader.GetValue(3)), Microsoft.VisualBasic.CompilerServices.Conversions.ToString(sqlDataReader.GetValue(0)), RestaurantPOS14.ModFunc.Decrypt(Microsoft.VisualBasic.CompilerServices.Conversions.ToString(sqlDataReader.GetValue(1))))
                End If

                sqlDataReader?.Close()
                obj.Close()
                obj.Dispose()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub Timer3_Tick(sender As Object, e As System.EventArgs)
            MyBase.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.Timer3.Enabled = False
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
            Dim dataGridViewCellStyle As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmWorkPeriod))
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.lblDateTime = New System.Windows.Forms.Label()
            Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.Label2 = New System.Windows.Forms.Label()
            Me.btnStartWP = New System.Windows.Forms.Button()
            Me.btnEndWP = New System.Windows.Forms.Button()
            Me.lblWPDate = New System.Windows.Forms.Label()
            Me.lblTotalWT = New System.Windows.Forms.Label()
            Me.lblWorkPeriodDate = New System.Windows.Forms.Label()
            Me.lblTotalWorkTime = New System.Windows.Forms.Label()
            Me.dgw = New System.Windows.Forms.DataGridView()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.txtID = New System.Windows.Forms.TextBox()
            Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
            Me.lblUser = New System.Windows.Forms.Label()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.lblUserType = New System.Windows.Forms.Label()
            Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
            Me.txtEmailID = New System.Windows.Forms.TextBox()
            Me.Panel1.SuspendLayout()
            CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
            MyBase.SuspendLayout()
            Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.Panel1.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.Label1)
            Me.Panel1.Controls.Add(Me.lblDateTime)
            Dim panel As System.Windows.Forms.Panel = Me.Panel1
            Dim location As System.Drawing.Point = New System.Drawing.Point(1, 1)
            panel.Location = location
            Me.Panel1.Name = "Panel1"
            Dim panel2 As System.Windows.Forms.Panel = Me.Panel1
            Dim size As System.Drawing.Size = New System.Drawing.Size(856, 49)
            panel2.Size = size
            Me.Panel1.TabIndex = 3
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label1.ForeColor = System.Drawing.Color.White
            Dim label As System.Windows.Forms.Label = Me.Label1
            location = New System.Drawing.Point(3, 5)
            label.Location = location
            Me.Label1.Name = "Label1"
            Dim label2 As System.Windows.Forms.Label = Me.Label1
            size = New System.Drawing.Size(167, 37)
            label2.Size = size
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Work Period"
            Me.lblDateTime.AutoSize = True
            Me.lblDateTime.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.lblDateTime.ForeColor = System.Drawing.Color.White
            Dim label3 As System.Windows.Forms.Label = Me.lblDateTime
            location = New System.Drawing.Point(281, 5)
            label3.Location = location
            Me.lblDateTime.Name = "lblDateTime"
            Dim label4 As System.Windows.Forms.Label = Me.lblDateTime
            size = New System.Drawing.Size(134, 37)
            label4.Size = size
            Me.lblDateTime.TabIndex = 3
            Me.lblDateTime.Text = "DateTime"
            Me.Timer1.Enabled = True
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label2.ForeColor = System.Drawing.Color.White
            Dim label5 As System.Windows.Forms.Label = Me.Label2
            location = New System.Drawing.Point(12, 68)
            label5.Location = location
            Me.Label2.Name = "Label2"
            Dim label6 As System.Windows.Forms.Label = Me.Label2
            size = New System.Drawing.Size(371, 32)
            label6.Size = size
            Me.Label2.TabIndex = 30
            Me.Label2.Text = "Start Work Period to enable POS"
            Me.btnStartWP.BackColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.btnStartWP.FlatAppearance.BorderSize = 0
            Me.btnStartWP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnStartWP.Font = New System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnStartWP.ForeColor = System.Drawing.Color.White
            Dim button As System.Windows.Forms.Button = Me.btnStartWP
            location = New System.Drawing.Point(18, 114)
            button.Location = location
            Me.btnStartWP.Name = "btnStartWP"
            Dim button2 As System.Windows.Forms.Button = Me.btnStartWP
            size = New System.Drawing.Size(226, 71)
            button2.Size = size
            Me.btnStartWP.TabIndex = 31
            Me.btnStartWP.Text = "Start Work Period"
            Me.btnStartWP.UseVisualStyleBackColor = False
            Me.btnEndWP.BackColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.btnEndWP.Enabled = False
            Me.btnEndWP.FlatAppearance.BorderSize = 0
            Me.btnEndWP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnEndWP.Font = New System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnEndWP.ForeColor = System.Drawing.Color.White
            Dim button3 As System.Windows.Forms.Button = Me.btnEndWP
            location = New System.Drawing.Point(18, 191)
            button3.Location = location
            Me.btnEndWP.Name = "btnEndWP"
            Dim button4 As System.Windows.Forms.Button = Me.btnEndWP
            size = New System.Drawing.Size(226, 71)
            button4.Size = size
            Me.btnEndWP.TabIndex = 32
            Me.btnEndWP.Text = "End Work Period"
            Me.btnEndWP.UseVisualStyleBackColor = False
            Me.lblWPDate.AutoSize = True
            Me.lblWPDate.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.lblWPDate.ForeColor = System.Drawing.Color.White
            Dim label7 As System.Windows.Forms.Label = Me.lblWPDate
            location = New System.Drawing.Point(269, 114)
            label7.Location = location
            Me.lblWPDate.Name = "lblWPDate"
            Dim label8 As System.Windows.Forms.Label = Me.lblWPDate
            size = New System.Drawing.Size(219, 30)
            label8.Size = size
            Me.lblWPDate.TabIndex = 33
            Me.lblWPDate.Text = "Date of Work Period :"
            Me.lblWPDate.Visible = False
            Me.lblTotalWT.AutoSize = True
            Me.lblTotalWT.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.lblTotalWT.ForeColor = System.Drawing.Color.White
            Dim label9 As System.Windows.Forms.Label = Me.lblTotalWT
            location = New System.Drawing.Point(269, 155)
            label9.Location = location
            Me.lblTotalWT.Name = "lblTotalWT"
            Dim label10 As System.Windows.Forms.Label = Me.lblTotalWT
            size = New System.Drawing.Size(181, 30)
            label10.Size = size
            Me.lblTotalWT.TabIndex = 35
            Me.lblTotalWT.Text = "Total Work Time :"
            Me.lblTotalWT.Visible = False
            Me.lblWorkPeriodDate.AutoSize = True
            Me.lblWorkPeriodDate.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.lblWorkPeriodDate.ForeColor = System.Drawing.Color.White
            Dim label11 As System.Windows.Forms.Label = Me.lblWorkPeriodDate
            location = New System.Drawing.Point(483, 114)
            label11.Location = location
            Me.lblWorkPeriodDate.Name = "lblWorkPeriodDate"
            Dim label12 As System.Windows.Forms.Label = Me.lblWorkPeriodDate
            size = New System.Drawing.Size(81, 30)
            label12.Size = size
            Me.lblWorkPeriodDate.TabIndex = 36
            Me.lblWorkPeriodDate.Text = "lblDate"
            Me.lblWorkPeriodDate.Visible = False
            Me.lblTotalWorkTime.AutoSize = True
            Me.lblTotalWorkTime.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.lblTotalWorkTime.ForeColor = System.Drawing.Color.White
            Dim label13 As System.Windows.Forms.Label = Me.lblTotalWorkTime
            location = New System.Drawing.Point(483, 155)
            label13.Location = location
            Me.lblTotalWorkTime.Name = "lblTotalWorkTime"
            Dim label14 As System.Windows.Forms.Label = Me.lblTotalWorkTime
            size = New System.Drawing.Size(181, 30)
            label14.Size = size
            Me.lblTotalWorkTime.TabIndex = 38
            Me.lblTotalWorkTime.Text = "lblTotalWorkTime"
            Me.lblTotalWorkTime.Visible = False
            Me.dgw.AllowUserToAddRows = False
            Me.dgw.AllowUserToDeleteRows = False
            dataGridViewCellStyle.BackColor = System.Drawing.Color.FloralWhite
            Me.dgw.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle
            Me.dgw.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.dgw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            Me.dgw.BackgroundColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.dgw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            dataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgw.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2
            Me.dgw.ColumnHeadersHeight = 40
            Me.dgw.Columns.AddRange(Me.Column1, Me.Column2)
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
            location = New System.Drawing.Point(18, 268)
            dataGridView.Location = location
            Me.dgw.MultiSelect = False
            Me.dgw.Name = "dgw"
            Me.dgw.[ReadOnly] = True
            Me.dgw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSeaGreen
            dataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Orange
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgw.RowHeadersDefaultCellStyle = dataGridViewCellStyle4
            Me.dgw.RowHeadersVisible = False
            Me.dgw.RowHeadersWidth = 25
            Me.dgw.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White
            dataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Black
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
            Me.dgw.RowsDefaultCellStyle = dataGridViewCellStyle5
            Me.dgw.RowTemplate.Height = 40
            Me.dgw.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgw.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Dim dataGridView2 As System.Windows.Forms.DataGridView = Me.dgw
            size = New System.Drawing.Size(897, 406)
            dataGridView2.Size = size
            Me.dgw.TabIndex = 41
            dataGridViewCellStyle6.Format = "dddd, dd MMMM yyyy hh:mm:ss tt"
            Me.Column1.DefaultCellStyle = dataGridViewCellStyle6
            Me.Column1.HeaderText = "Start Date"
            Me.Column1.Name = "Column1"
            Me.Column1.[ReadOnly] = True
            dataGridViewCellStyle7.Format = "dddd, dd MMMM yyyy hh:mm:ss tt"
            Me.Column2.DefaultCellStyle = dataGridViewCellStyle7
            Me.Column2.HeaderText = "End Date"
            Me.Column2.Name = "Column2"
            Me.Column2.[ReadOnly] = True
            Dim textBox As System.Windows.Forms.TextBox = Me.txtID
            location = New System.Drawing.Point(274, 211)
            textBox.Location = location
            Me.txtID.Name = "txtID"
            Dim textBox2 As System.Windows.Forms.TextBox = Me.txtID
            size = New System.Drawing.Size(28, 20)
            textBox2.Size = size
            Me.txtID.TabIndex = 42
            Me.txtID.Visible = False
            Me.Timer2.Enabled = True
            Me.lblUser.AutoSize = True
            Dim label15 As System.Windows.Forms.Label = Me.lblUser
            location = New System.Drawing.Point(444, 333)
            label15.Location = location
            Me.lblUser.Name = "lblUser"
            Dim label16 As System.Windows.Forms.Label = Me.lblUser
            size = New System.Drawing.Size(29, 13)
            label16.Size = size
            Me.lblUser.TabIndex = 110
            Me.lblUser.Text = "User"
            Me.lblUser.Visible = False
            Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
            Me.btnCancel.BackColor = System.Drawing.Color.Transparent
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.FlatAppearance.BorderSize = 0
            Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnCancel.Image = CType(componentResourceManager.GetObject("btnCancel.Image"), System.Drawing.Image)
            Dim button5 As System.Windows.Forms.Button = Me.btnCancel
            location = New System.Drawing.Point(861, 1)
            button5.Location = location
            Me.btnCancel.Name = "btnCancel"
            Dim button6 As System.Windows.Forms.Button = Me.btnCancel
            size = New System.Drawing.Size(52, 49)
            button6.Size = size
            Me.btnCancel.TabIndex = 29
            Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnCancel.UseVisualStyleBackColor = False
            Me.lblUserType.AutoSize = True
            Me.lblUserType.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.lblUserType.ForeColor = System.Drawing.Color.PaleGoldenrod
            Dim label17 As System.Windows.Forms.Label = Me.lblUserType
            location = New System.Drawing.Point(639, 68)
            label17.Location = location
            Me.lblUserType.Name = "lblUserType"
            Dim label18 As System.Windows.Forms.Label = Me.lblUserType
            size = New System.Drawing.Size(130, 37)
            label18.Size = size
            Me.lblUserType.TabIndex = 323
            Me.lblUserType.Text = "UserType"
            Me.lblUserType.Visible = False
            Me.txtEmailID.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
            Me.txtEmailID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.txtEmailID.ForeColor = System.Drawing.Color.Black
            Dim textBox3 As System.Windows.Forms.TextBox = Me.txtEmailID
            location = New System.Drawing.Point(592, 203)
            textBox3.Location = location
            Me.txtEmailID.Name = "txtEmailID"
            Dim textBox4 As System.Windows.Forms.TextBox = Me.txtEmailID
            size = New System.Drawing.Size(120, 29)
            textBox4.Size = size
            Me.txtEmailID.TabIndex = 324
            Me.txtEmailID.Visible = False
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            size = New System.Drawing.Size(916, 678)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.txtEmailID)
            MyBase.Controls.Add(Me.lblUserType)
            MyBase.Controls.Add(Me.lblUser)
            MyBase.Controls.Add(Me.txtID)
            MyBase.Controls.Add(Me.dgw)
            MyBase.Controls.Add(Me.lblTotalWorkTime)
            MyBase.Controls.Add(Me.lblWorkPeriodDate)
            MyBase.Controls.Add(Me.lblTotalWT)
            MyBase.Controls.Add(Me.lblWPDate)
            MyBase.Controls.Add(Me.btnEndWP)
            MyBase.Controls.Add(Me.btnStartWP)
            MyBase.Controls.Add(Me.Label2)
            MyBase.Controls.Add(Me.btnCancel)
            MyBase.Controls.Add(Me.Panel1)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.Name = "frmWorkPeriod"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            MyBase.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
            MyBase.ResumeLayout(False)
            MyBase.PerformLayout()
        End Sub
    End Class
End Namespace
