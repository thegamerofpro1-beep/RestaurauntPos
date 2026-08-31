Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Text
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports CButtonLib
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public Class frmAttendance
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnClockIN")>
        Private _btnClockIN As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnClockOUT")>
        Private _btnClockOUT As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("OpenFileDialog1")>
        Private _OpenFileDialog1 As System.Windows.Forms.OpenFileDialog

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Timer2")>
        Private _Timer2 As System.Windows.Forms.Timer

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtCurrentClockInID")>
        Private _txtCurrentClockInID As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label2")>
        Private _Label2 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("cmbUserID")>
        Private _cmbUserID As System.Windows.Forms.ComboBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtClockInID")>
        Private _txtClockInID As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label1")>
        Private _Label1 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("dtpDateTime")>
        Private _dtpDateTime As System.Windows.Forms.DateTimePicker

        Private components As System.ComponentModel.IContainer

        Friend Overridable Property btnClockIN As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnClockIN
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnClockIN_Click
                If Me._btnClockIN IsNot Nothing Then
                    RemoveHandler Me._btnClockIN.Click, value2
                End If

                Me._btnClockIN = value
                If Me._btnClockIN IsNot Nothing Then
                    AddHandler Me._btnClockIN.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnClockOUT As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnClockOUT
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnClockOUT_Click
                If Me._btnClockOUT IsNot Nothing Then
                    RemoveHandler Me._btnClockOUT.Click, value2
                End If

                Me._btnClockOUT = value
                If Me._btnClockOUT IsNot Nothing Then
                    AddHandler Me._btnClockOUT.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._OpenFileDialog1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.OpenFileDialog)
                Me._OpenFileDialog1 = value
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

        Friend Overridable Property txtCurrentClockInID As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtCurrentClockInID
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtCurrentClockInID = value
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

        Friend Overridable Property txtClockInID As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtClockInID
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtClockInID = value
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

        Friend Overridable Property dtpDateTime As System.Windows.Forms.DateTimePicker
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._dtpDateTime
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DateTimePicker)
                Me._dtpDateTime = value
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            AddHandler MyBase.Load, AddressOf Me.frmClockINandOUT_Load
            Call RestaurantPOS14.frmAttendance.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmAttendance.__ENCList
                If RestaurantPOS14.frmAttendance.__ENCList.Count = RestaurantPOS14.frmAttendance.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmAttendance.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmAttendance.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmAttendance.__ENCList(num) = RestaurantPOS14.frmAttendance.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmAttendance.__ENCList.RemoveRange(num, RestaurantPOS14.frmAttendance.__ENCList.Count - num)
                    RestaurantPOS14.frmAttendance.__ENCList.Capacity = RestaurantPOS14.frmAttendance.__ENCList.Count
                End If

                Call RestaurantPOS14.frmAttendance.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Private Sub btnClose_Click(sender As Object, e As System.EventArgs)
            MyBase.Close()
        End Sub

        Private Sub btnClockOUT_Click(sender As Object, e As System.EventArgs)
            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.cmbUserID.Text, "", TextCompare:=False) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please select user id", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.cmbUserID.Focus()
                Return
            End If

            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = RestaurantPOS14.ModClasses.con.CreateCommand()
                RestaurantPOS14.ModClasses.cmd.CommandText = "SELECT Top 1 ClockIN.ID from ClockIN where UserID=@d1 order by ClockIN.ID Desc"
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.cmbUserID.Text)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.txtClockInID.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                    RestaurantPOS14.ModFunc.ClockOUTSaveX(Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(Me.txtClockInID.Text), Me.dtpDateTime.Value)
                End If

                If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                    RestaurantPOS14.ModClasses.rdr.Close()
                End If

                If RestaurantPOS14.ModClasses.con.State = System.Data.ConnectionState.Open Then
                    RestaurantPOS14.ModClasses.con.Close()
                End If

                Call System.Windows.Forms.MessageBox.Show("Successfully Clokced OUT", "Info", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                Me.Reset()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub CheckFirstTimeClockInX(User As String)
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = RestaurantPOS14.ModClasses.con.CreateCommand()
                RestaurantPOS14.ModClasses.cmd.CommandText = "SELECT * from ClockIN where UserID=@d1"
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", User)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If Not RestaurantPOS14.ModClasses.rdr.Read() Then
                    RestaurantPOS14.ModFunc.ClockINSaveX(User, Me.dtpDateTime.Value)
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

        Public Sub CheckExistingClockIn(User As String)
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = RestaurantPOS14.ModClasses.con.CreateCommand()
                RestaurantPOS14.ModClasses.cmd.CommandText = "SELECT Top 1 ClockIN.ID from ClockIN where UserID=@d1 order by ClockIN.ID Desc"
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", User)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.txtCurrentClockInID.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                Else
                    Me.txtCurrentClockInID.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(0)
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
                RestaurantPOS14.ModClasses.cmd.CommandText = "SELECT ClockINID from ClockOUT where ClockInID=@d1"
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.Conversion.Val(Me.txtCurrentClockInID.Text))
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    RestaurantPOS14.ModFunc.ClockINSaveX(User, Me.dtpDateTime.Value)
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

        Private Sub btnClockIN_Click(sender As Object, e As System.EventArgs)
            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.cmbUserID.Text, "", TextCompare:=False) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please select user id", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.cmbUserID.Focus()
                Return
            End If

            Me.CheckFirstTimeClockInX(Me.cmbUserID.Text)
            Me.CheckExistingClockIn(Me.cmbUserID.Text)
            Call System.Windows.Forms.MessageBox.Show("Successfully Clokced IN", "Info", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
            Me.Reset()
        End Sub

        Public Sub DisableClockIN()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = RestaurantPOS14.ModClasses.con.CreateCommand()
                RestaurantPOS14.ModClasses.cmd.CommandText = "SELECT Top 1 ClockIN.ID from ClockIN where UserID=@d1 order by ClockIN.ID Desc"
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.cmbUserID.Text)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.txtCurrentClockInID.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                Else
                    Me.txtCurrentClockInID.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(0)
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
                RestaurantPOS14.ModClasses.cmd.CommandText = "SELECT ClockINID from ClockOUT where ClockInID=@d1"
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.Conversion.Val(Me.txtCurrentClockInID.Text))
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If Not RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.btnClockIN.Enabled = False
                Else
                    Me.btnClockIN.Enabled = True
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

        Public Sub DisableClockOUT()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = RestaurantPOS14.ModClasses.con.CreateCommand()
                RestaurantPOS14.ModClasses.cmd.CommandText = "SELECT Top 1 ClockIN.ID from ClockIN where UserID=@d1 order by ClockIN.ID Desc"
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.cmbUserID.Text)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.txtCurrentClockInID.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                Else
                    Me.txtCurrentClockInID.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(0)
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
                RestaurantPOS14.ModClasses.cmd.CommandText = "SELECT ClockINID from ClockOUT where ClockInID=@d1"
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.Conversion.Val(Me.txtCurrentClockInID.Text))
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.btnClockOUT.Enabled = False
                Else
                    Me.btnClockOUT.Enabled = True
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

        Private Sub frmClockINandOUT_Load(sender As Object, e As System.EventArgs)
            Me.fillCombo()
        End Sub

        Public Sub fillCombo()
            Try
                Dim sqlConnection As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                sqlConnection.Open()
                RestaurantPOS14.ModClasses.adp = New System.Data.SqlClient.SqlDataAdapter()
                RestaurantPOS14.ModClasses.adp.SelectCommand = New System.Data.SqlClient.SqlCommand("SELECT distinct RTRIM(UserID) FROM Registration order by 1", sqlConnection)
                RestaurantPOS14.ModClasses.ds = New System.Data.DataSet("ds")
                RestaurantPOS14.ModClasses.adp.Fill(RestaurantPOS14.ModClasses.ds)
                Dim dataTable As System.Data.DataTable = RestaurantPOS14.ModClasses.ds.Tables(0)
                Me.cmbUserID.Items.Clear()
                For Each dataRow As System.Data.DataRow In dataTable.Rows
                    Me.cmbUserID.Items.Add(dataRow(CInt((0))).ToString())
                Next

                sqlConnection.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub Reset()
            Me.cmbUserID.SelectedIndex = -1
            Me.btnClockIN.Enabled = True
            Me.btnClockOUT.Enabled = True
            Me.txtCurrentClockInID.Text = ""
            Me.txtClockInID.Text = ""
        End Sub

        Public Sub CheckFirstTimeClockIn()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = RestaurantPOS14.ModClasses.con.CreateCommand()
                RestaurantPOS14.ModClasses.cmd.CommandText = "SELECT * from ClockIN where UserID=@d1"
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.cmbUserID.Text)
                Dim sqlDataReader As System.Data.SqlClient.SqlDataReader = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If sqlDataReader.Read() Then
                    Me.DisableClockIN()
                    Me.DisableClockOUT()
                Else
                    Me.btnClockIN.Enabled = True
                    Me.btnClockOUT.Enabled = False
                End If

                sqlDataReader?.Close()
                If RestaurantPOS14.ModClasses.con.State = System.Data.ConnectionState.Open Then
                    RestaurantPOS14.ModClasses.con.Close()
                End If
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub cmbUserID_SelectedIndexChanged(sender As Object, e As System.EventArgs)
            Me.CheckFirstTimeClockIn()
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
            Dim cBlendItems As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems2 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmAttendance))
            Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
            Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
            Me.txtCurrentClockInID = New System.Windows.Forms.TextBox()
            Me.btnClockOUT = New CButtonLib.CButton()
            Me.btnClockIN = New CButtonLib.CButton()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.cmbUserID = New System.Windows.Forms.ComboBox()
            Me.txtClockInID = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.dtpDateTime = New System.Windows.Forms.DateTimePicker()
            MyBase.SuspendLayout()
            Me.OpenFileDialog1.FileName = "OpenFileDialog1"
            Dim textBox As System.Windows.Forms.TextBox = Me.txtCurrentClockInID
            Dim location As System.Drawing.Point = New System.Drawing.Point(235, 5)
            textBox.Location = location
            Me.txtCurrentClockInID.Name = "txtCurrentClockInID"
            Dim textBox2 As System.Windows.Forms.TextBox = Me.txtCurrentClockInID
            Dim size As System.Drawing.Size = New System.Drawing.Size(40, 20)
            textBox2.Size = size
            Me.txtCurrentClockInID.TabIndex = 325
            Me.txtCurrentClockInID.Visible = False
            Me.btnClockOUT.BackColor = System.Drawing.Color.Transparent
            Me.btnClockOUT.BorderShow = False
            cBlendItems.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnClockOUT.ColorFillBlend = cBlendItems
            Me.btnClockOUT.Corners.All = 3
            Me.btnClockOUT.Corners.LowerLeft = 3
            Me.btnClockOUT.Corners.LowerRight = 3
            Me.btnClockOUT.Corners.UpperLeft = 3
            Me.btnClockOUT.Corners.UpperRight = 3
            Me.btnClockOUT.DesignerSelected = False
            Me.btnClockOUT.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnClockOUT.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnClockOUT.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnClockOUT.ImageIndex = 0
            Dim cButton As CButtonLib.CButton = Me.btnClockOUT
            location = New System.Drawing.Point(239, 128)
            cButton.Location = location
            Me.btnClockOUT.Name = "btnClockOUT"
            Dim cButton2 As CButtonLib.CButton = Me.btnClockOUT
            size = New System.Drawing.Size(217, 76)
            cButton2.Size = size
            Me.btnClockOUT.TabIndex = 324
            Me.btnClockOUT.Text = "Clock OUT"
            Me.btnClockOUT.TextShadowShow = False
            Me.btnClockOUT.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.btnClockIN.BackColor = System.Drawing.Color.Transparent
            Me.btnClockIN.BorderShow = False
            cBlendItems2.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems2.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnClockIN.ColorFillBlend = cBlendItems2
            Me.btnClockIN.Corners.All = 3
            Me.btnClockIN.Corners.LowerLeft = 3
            Me.btnClockIN.Corners.LowerRight = 3
            Me.btnClockIN.Corners.UpperLeft = 3
            Me.btnClockIN.Corners.UpperRight = 3
            Me.btnClockIN.DesignerSelected = False
            Me.btnClockIN.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnClockIN.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnClockIN.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnClockIN.ImageIndex = 0
            Dim cButton3 As CButtonLib.CButton = Me.btnClockIN
            location = New System.Drawing.Point(16, 128)
            cButton3.Location = location
            Me.btnClockIN.Name = "btnClockIN"
            Dim cButton4 As CButtonLib.CButton = Me.btnClockIN
            size = New System.Drawing.Size(217, 76)
            cButton4.Size = size
            Me.btnClockIN.TabIndex = 323
            Me.btnClockIN.Text = "Clock IN"
            Me.btnClockIN.TextShadowShow = False
            Me.btnClockIN.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label2.ForeColor = System.Drawing.Color.White
            Dim label As System.Windows.Forms.Label = Me.Label2
            location = New System.Drawing.Point(12, 20)
            label.Location = location
            Me.Label2.Name = "Label2"
            Dim label2 As System.Windows.Forms.Label = Me.Label2
            size = New System.Drawing.Size(81, 24)
            label2.Size = size
            Me.Label2.TabIndex = 14
            Me.Label2.Text = "User ID :"
            Me.cmbUserID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbUserID.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.cmbUserID.FormattingEnabled = True
            Dim comboBox As System.Windows.Forms.ComboBox = Me.cmbUserID
            location = New System.Drawing.Point(163, 20)
            comboBox.Location = location
            Me.cmbUserID.Name = "cmbUserID"
            Dim comboBox2 As System.Windows.Forms.ComboBox = Me.cmbUserID
            size = New System.Drawing.Size(289, 39)
            comboBox2.Size = size
            Me.cmbUserID.TabIndex = 13
            Dim textBox3 As System.Windows.Forms.TextBox = Me.txtClockInID
            location = New System.Drawing.Point(395, 5)
            textBox3.Location = location
            Me.txtClockInID.Name = "txtClockInID"
            Dim textBox4 As System.Windows.Forms.TextBox = Me.txtClockInID
            size = New System.Drawing.Size(100, 20)
            textBox4.Size = size
            Me.txtClockInID.TabIndex = 326
            Me.txtClockInID.Visible = False
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label1.ForeColor = System.Drawing.Color.White
            Dim label3 As System.Windows.Forms.Label = Me.Label1
            location = New System.Drawing.Point(12, 66)
            label3.Location = location
            Me.Label1.Name = "Label1"
            Dim label4 As System.Windows.Forms.Label = Me.Label1
            size = New System.Drawing.Size(143, 24)
            label4.Size = size
            Me.Label1.TabIndex = 327
            Me.Label1.Text = "Date and Time :"
            Me.dtpDateTime.CustomFormat = "dd/MM/yyyy hh:mm tt"
            Me.dtpDateTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.dtpDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Dim dateTimePicker As System.Windows.Forms.DateTimePicker = Me.dtpDateTime
            location = New System.Drawing.Point(163, 66)
            dateTimePicker.Location = location
            Me.dtpDateTime.Name = "dtpDateTime"
            Dim dateTimePicker2 As System.Windows.Forms.DateTimePicker = Me.dtpDateTime
            size = New System.Drawing.Size(289, 31)
            dateTimePicker2.Size = size
            Me.dtpDateTime.TabIndex = 328
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            size = New System.Drawing.Size(466, 212)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.dtpDateTime)
            MyBase.Controls.Add(Me.Label1)
            MyBase.Controls.Add(Me.txtClockInID)
            MyBase.Controls.Add(Me.cmbUserID)
            MyBase.Controls.Add(Me.Label2)
            MyBase.Controls.Add(Me.txtCurrentClockInID)
            MyBase.Controls.Add(Me.btnClockOUT)
            MyBase.Controls.Add(Me.btnClockIN)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MaximizeBox = False
            MyBase.MinimizeBox = False
            MyBase.Name = "frmAttendance"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Attendance"
            MyBase.ResumeLayout(False)
            MyBase.PerformLayout()
        End Sub
    End Class
End Namespace
