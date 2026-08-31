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
Imports RestaurantPOS14.My.Resources

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public Class frmCMISetting
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel1")>
        Private _Panel1 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label1")>
        Private _Label1 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtID")>
        Private _txtID As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnSave")>
        Private _btnSave As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox2")>
        Private _GroupBox2 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtF2")>
        Private _txtF2 As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label5")>
        Private _Label5 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtW2")>
        Private _txtW2 As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label6")>
        Private _Label6 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtH2")>
        Private _txtH2 As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label7")>
        Private _Label7 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label9")>
        Private _Label9 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label2")>
        Private _Label2 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnDefault")>
        Private _btnDefault As System.Windows.Forms.Button

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

        Friend Overridable Property btnSave As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnSave
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.Button4_Click
                If Me._btnSave IsNot Nothing Then
                    RemoveHandler Me._btnSave.Click, value2
                End If

                Me._btnSave = value
                If Me._btnSave IsNot Nothing Then
                    AddHandler Me._btnSave.Click, value2
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

        Friend Overridable Property txtF2 As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtF2
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.Windows.Forms.KeyPressEventHandler = AddressOf Me.txtH1_KeyPress
                If Me._txtF2 IsNot Nothing Then
                    RemoveHandler Me._txtF2.KeyPress, value2
                End If

                Me._txtF2 = value
                If Me._txtF2 IsNot Nothing Then
                    AddHandler Me._txtF2.KeyPress, value2
                End If
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

        Friend Overridable Property txtW2 As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtW2
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.Windows.Forms.KeyPressEventHandler = AddressOf Me.txtH1_KeyPress
                If Me._txtW2 IsNot Nothing Then
                    RemoveHandler Me._txtW2.KeyPress, value2
                End If

                Me._txtW2 = value
                If Me._txtW2 IsNot Nothing Then
                    AddHandler Me._txtW2.KeyPress, value2
                End If
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

        Friend Overridable Property txtH2 As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtH2
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.Windows.Forms.KeyPressEventHandler = AddressOf Me.txtH1_KeyPress
                If Me._txtH2 IsNot Nothing Then
                    RemoveHandler Me._txtH2.KeyPress, value2
                End If

                Me._txtH2 = value
                If Me._txtH2 IsNot Nothing Then
                    AddHandler Me._txtH2.KeyPress, value2
                End If
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

        Friend Overridable Property Label9 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label9
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label9 = value
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

        Friend Overridable Property btnDefault As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnDefault
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnDefault_Click
                If Me._btnDefault IsNot Nothing Then
                    RemoveHandler Me._btnDefault.Click, value2
                End If

                Me._btnDefault = value
                If Me._btnDefault IsNot Nothing Then
                    AddHandler Me._btnDefault.Click, value2
                End If
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            AddHandler MyBase.Load, AddressOf Me.frmInvCode_Load
            AddHandler MyBase.KeyDown, AddressOf Me.frmInvoiceCode_KeyDown
            Call RestaurantPOS14.frmCMISetting.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmCMISetting.__ENCList
                If RestaurantPOS14.frmCMISetting.__ENCList.Count = RestaurantPOS14.frmCMISetting.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmCMISetting.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmCMISetting.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmCMISetting.__ENCList(num) = RestaurantPOS14.frmCMISetting.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmCMISetting.__ENCList.RemoveRange(num, RestaurantPOS14.frmCMISetting.__ENCList.Count - num)
                    RestaurantPOS14.frmCMISetting.__ENCList.Capacity = RestaurantPOS14.frmCMISetting.__ENCList.Count
                End If

                Call RestaurantPOS14.frmCMISetting.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Private Sub frmInvCode_Load(sender As Object, e As System.EventArgs)
            Me.Getdata()
        End Sub

        Private Sub Getdata()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = RestaurantPOS14.ModClasses.con.CreateCommand()
                RestaurantPOS14.ModClasses.cmd.CommandText = "SELECT ID,(c4), (c5), (c6) from CMISetting"
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.txtID.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                    Me.txtH2.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(1))
                    Me.txtW2.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(2))
                    Me.txtF2.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(3))
                Else
                    Me.txtID.Text = ""
                    Me.txtH2.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(60)
                    Me.txtW2.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(105)
                    Me.txtF2.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(9)
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

        Private Sub Button4_Click(sender As Object, e As System.EventArgs)
            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtH2.Text, "", TextCompare:=False) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please Enter Height(MI)", "Warning", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtH2.Focus()
                Return
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtW2.Text, "", TextCompare:=False) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please Enter Width(MI)", "Warning", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtW2.Focus()
                Return
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtF2.Text, "", TextCompare:=False) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please Enter Font Size(MI)", "Warning", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtF2.Focus()
                Return
            End If

            Try
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtID.Text, "", TextCompare:=False) = 0 Then
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.ReadCS())
                    RestaurantPOS14.ModClasses.con.Open()
                    RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Insert into CMISetting(C4,C5,C6) Values (@d4,@d5,@d6)")
                    RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", Microsoft.VisualBasic.Conversion.Val(Me.txtH2.Text))
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d5", Microsoft.VisualBasic.Conversion.Val(Me.txtW2.Text))
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d6", Microsoft.VisualBasic.Conversion.Val(Me.txtF2.Text))
                    RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                    Call System.Windows.Forms.MessageBox.Show("Successfully Saved", "Information", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    Me.Getdata()
                Else
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.ReadCS())
                    RestaurantPOS14.ModClasses.con.Open()
                    RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Update CMISetting set c4=@d4,c5=@d5,c6=@d6 where ID=@d0")
                    RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d0", Microsoft.VisualBasic.Conversion.Val(Me.txtID.Text))
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", Microsoft.VisualBasic.Conversion.Val(Me.txtH2.Text))
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d5", Microsoft.VisualBasic.Conversion.Val(Me.txtW2.Text))
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d6", Microsoft.VisualBasic.Conversion.Val(Me.txtF2.Text))
                    RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                    Call System.Windows.Forms.MessageBox.Show("Successfully Saved", "Information", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    Me.Getdata()
                End If
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub frmInvoiceCode_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs)
            If e.KeyCode = System.Windows.Forms.Keys.[Return] Then
                MyBase.SelectNextControl(MyBase.ActiveControl, forward:=True, tabStopOnly:=True, nested:=True, wrap:=False)
            End If
        End Sub

        Private Sub txtH1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
            If((e.KeyChar < "0"c) Or (e.KeyChar > "9"c)) And (e.KeyChar <> Global.Microsoft.VisualBasic.Strings.ChrW(8)) Then
                e.Handled = True
            End If
        End Sub

        Private Sub btnDefault_Click(sender As Object, e As System.EventArgs)
            Try
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtID.Text, "", TextCompare:=False) = 0 Then
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.ReadCS())
                    RestaurantPOS14.ModClasses.con.Open()
                    RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Insert into CMISetting(C4,C5,C6) Values (@d4,@d5,@d6)")
                    RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", 60)
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d5", 105)
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d6", 9.0)
                    RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                    Call System.Windows.Forms.MessageBox.Show("Successfully Saved", "Information", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    Me.Getdata()
                Else
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.ReadCS())
                    RestaurantPOS14.ModClasses.con.Open()
                    RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Update CMISetting set c4=@d4,c5=@d5,c6=@d6 where ID=@d0")
                    RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d0", Microsoft.VisualBasic.Conversion.Val(Me.txtID.Text))
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", 60)
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d5", 105)
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d6", 9.0)
                    RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                    Call System.Windows.Forms.MessageBox.Show("Successfully Reset", "Information", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    Me.Getdata()
                End If
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmCMISetting))
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.txtF2 = New System.Windows.Forms.TextBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.txtW2 = New System.Windows.Forms.TextBox()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.txtH2 = New System.Windows.Forms.TextBox()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.btnSave = New System.Windows.Forms.Button()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtID = New System.Windows.Forms.TextBox()
            Me.btnDefault = New System.Windows.Forms.Button()
            Me.Panel1.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            MyBase.SuspendLayout()
            Me.Panel1.BackColor = System.Drawing.Color.White
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.btnDefault)
            Me.Panel1.Controls.Add(Me.Label2)
            Me.Panel1.Controls.Add(Me.Label9)
            Me.Panel1.Controls.Add(Me.GroupBox2)
            Me.Panel1.Controls.Add(Me.btnSave)
            Me.Panel1.Controls.Add(Me.Label1)
            Me.Panel1.Controls.Add(Me.txtID)
            Dim panel As System.Windows.Forms.Panel = Me.Panel1
            Dim location As System.Drawing.Point = New System.Drawing.Point(7, 7)
            panel.Location = location
            Me.Panel1.Name = "Panel1"
            Dim panel2 As System.Windows.Forms.Panel = Me.Panel1
            Dim size As System.Drawing.Size = New System.Drawing.Size(479, 333)
            panel2.Size = size
            Me.Panel1.TabIndex = 0
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label2.ForeColor = System.Drawing.Color.Maroon
            Dim label As System.Windows.Forms.Label = Me.Label2
            location = New System.Drawing.Point(5, 300)
            label.Location = location
            Me.Label2.Name = "Label2"
            Dim label2 As System.Windows.Forms.Label = Me.Label2
            size = New System.Drawing.Size(218, 30)
            label2.Size = size
            Me.Label2.TabIndex = 417
            Me.Label2.Text = "Note : This setting apply only for layout" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "button shows item name."
            Me.Label9.AutoSize = True
            Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label9.ForeColor = System.Drawing.Color.Red
            Dim label3 As System.Windows.Forms.Label = Me.Label9
            location = New System.Drawing.Point(5, 223)
            label3.Location = location
            Me.Label9.Name = "Label9"
            Dim label4 As System.Windows.Forms.Label = Me.Label9
            size = New System.Drawing.Size(177, 60)
            label4.Size = size
            Me.Label9.TabIndex = 416
            Me.Label9.Text = "Default Setting for Menu Items :" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Height - 60" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Width - 105" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Font Size - 9"
            Me.GroupBox2.Controls.Add(Me.txtF2)
            Me.GroupBox2.Controls.Add(Me.Label5)
            Me.GroupBox2.Controls.Add(Me.txtW2)
            Me.GroupBox2.Controls.Add(Me.Label6)
            Me.GroupBox2.Controls.Add(Me.txtH2)
            Me.GroupBox2.Controls.Add(Me.Label7)
            Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim groupBox As System.Windows.Forms.GroupBox = Me.GroupBox2
            location = New System.Drawing.Point(86, 41)
            groupBox.Location = location
            Me.GroupBox2.Name = "GroupBox2"
            Dim groupBox2 As System.Windows.Forms.GroupBox = Me.GroupBox2
            size = New System.Drawing.Size(307, 179)
            groupBox2.Size = size
            Me.GroupBox2.TabIndex = 1
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Menu Items Button UI"
            Me.txtF2.Font = New System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox As System.Windows.Forms.TextBox = Me.txtF2
            location = New System.Drawing.Point(143, 121)
            textBox.Location = location
            Me.txtF2.Name = "txtF2"
            Dim textBox2 As System.Windows.Forms.TextBox = Me.txtF2
            size = New System.Drawing.Size(147, 39)
            textBox2.Size = size
            Me.txtF2.TabIndex = 2
            Me.txtF2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim label5 As System.Windows.Forms.Label = Me.Label5
            location = New System.Drawing.Point(15, 121)
            label5.Location = location
            Me.Label5.Name = "Label5"
            Dim label6 As System.Windows.Forms.Label = Me.Label5
            size = New System.Drawing.Size(132, 32)
            label6.Size = size
            Me.Label5.TabIndex = 6
            Me.Label5.Text = "Font Size :"
            Me.txtW2.Font = New System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox3 As System.Windows.Forms.TextBox = Me.txtW2
            location = New System.Drawing.Point(143, 76)
            textBox3.Location = location
            Me.txtW2.Name = "txtW2"
            Dim textBox4 As System.Windows.Forms.TextBox = Me.txtW2
            size = New System.Drawing.Size(147, 39)
            textBox4.Size = size
            Me.txtW2.TabIndex = 1
            Me.txtW2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.Label6.AutoSize = True
            Me.Label6.Font = New System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim label7 As System.Windows.Forms.Label = Me.Label6
            location = New System.Drawing.Point(15, 76)
            label7.Location = location
            Me.Label6.Name = "Label6"
            Dim label8 As System.Windows.Forms.Label = Me.Label6
            size = New System.Drawing.Size(98, 32)
            label8.Size = size
            Me.Label6.TabIndex = 4
            Me.Label6.Text = "Width :"
            Me.txtH2.Font = New System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox5 As System.Windows.Forms.TextBox = Me.txtH2
            location = New System.Drawing.Point(143, 31)
            textBox5.Location = location
            Me.txtH2.Name = "txtH2"
            Dim textBox6 As System.Windows.Forms.TextBox = Me.txtH2
            size = New System.Drawing.Size(147, 39)
            textBox6.Size = size
            Me.txtH2.TabIndex = 0
            Me.txtH2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.Label7.AutoSize = True
            Me.Label7.Font = New System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim label9 As System.Windows.Forms.Label = Me.Label7
            location = New System.Drawing.Point(15, 31)
            label9.Location = location
            Me.Label7.Name = "Label7"
            Dim label10 As System.Windows.Forms.Label = Me.Label7
            size = New System.Drawing.Size(105, 32)
            label10.Size = size
            Me.Label7.TabIndex = 0
            Me.Label7.Text = "Height :"
            Me.btnSave.BackColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.btnSave.BackgroundImage = CType(componentResourceManager.GetObject("btnSave.BackgroundImage"), System.Drawing.Image)
            Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnSave.Font = New System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnSave.ForeColor = System.Drawing.Color.White
            Me.btnSave.Image = CType(componentResourceManager.GetObject("btnSave.Image"), System.Drawing.Image)
            Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button As System.Windows.Forms.Button = Me.btnSave
            location = New System.Drawing.Point(216, 231)
            button.Location = location
            Me.btnSave.Name = "btnSave"
            Dim button2 As System.Windows.Forms.Button = Me.btnSave
            size = New System.Drawing.Size(95, 55)
            button2.Size = size
            Me.btnSave.TabIndex = 2
            Me.btnSave.Text = "&Save"
            Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnSave.UseVisualStyleBackColor = False
            Me.Label1.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Label1.Font = New System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label1.ForeColor = System.Drawing.Color.White
            Dim label11 As System.Windows.Forms.Label = Me.Label1
            location = New System.Drawing.Point(4, 4)
            label11.Location = location
            Me.Label1.Name = "Label1"
            Dim label12 As System.Windows.Forms.Label = Me.Label1
            size = New System.Drawing.Size(468, 31)
            label12.Size = size
            Me.Label1.TabIndex = 46
            Me.Label1.Text = "Menu Items Button UI Setting"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.txtID.BackColor = System.Drawing.SystemColors.Control
            Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox7 As System.Windows.Forms.TextBox = Me.txtID
            location = New System.Drawing.Point(77, 8)
            textBox7.Location = location
            Me.txtID.Name = "txtID"
            Me.txtID.[ReadOnly] = True
            Dim textBox8 As System.Windows.Forms.TextBox = Me.txtID
            size = New System.Drawing.Size(27, 21)
            textBox8.Size = size
            Me.txtID.TabIndex = 414
            Me.txtID.TabStop = False
            Me.txtID.Visible = False
            Me.btnDefault.BackColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.btnDefault.BackgroundImage = CType(componentResourceManager.GetObject("btnDefault.BackgroundImage"), System.Drawing.Image)
            Me.btnDefault.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnDefault.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnDefault.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnDefault.Font = New System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnDefault.ForeColor = System.Drawing.Color.White
            Me.btnDefault.Image = RestaurantPOS14.My.Resources.Resources.Reset2_32x32
            Me.btnDefault.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button3 As System.Windows.Forms.Button = Me.btnDefault
            location = New System.Drawing.Point(317, 231)
            button3.Location = location
            Me.btnDefault.Name = "btnDefault"
            Dim button4 As System.Windows.Forms.Button = Me.btnDefault
            size = New System.Drawing.Size(155, 55)
            button4.Size = size
            Me.btnDefault.TabIndex = 418
            Me.btnDefault.Text = "&Reset to Default"
            Me.btnDefault.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnDefault.UseVisualStyleBackColor = False
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            size = New System.Drawing.Size(491, 346)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.Panel1)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.KeyPreview = True
            MyBase.MaximizeBox = False
            MyBase.MinimizeBox = False
            MyBase.Name = "frmCMISetting"
            MyBase.ShowInTaskbar = False
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Menu Items Button UI Setting"
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            MyBase.ResumeLayout(False)
        End Sub
    End Class
End Namespace
