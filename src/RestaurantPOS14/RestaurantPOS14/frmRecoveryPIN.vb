Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports RestaurantPOS14.My

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public Class frmRecoveryPIN
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtEmailID")>
        Private _txtEmailID As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label4")>
        Private _Label4 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnSendMail")>
        Private _btnSendMail As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel1")>
        Private _Panel1 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label5")>
        Private _Label5 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnKeyboard")>
        Private _btnKeyboard As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnCancel")>
        Private _btnCancel As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Timer1")>
        Private _Timer1 As System.Windows.Forms.Timer

        Private components As System.ComponentModel.IContainer

        Friend Overridable Property txtEmailID As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtEmailID
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.ComponentModel.CancelEventHandler = AddressOf Me.txtEmailID_Validating
                Dim value3 As System.Windows.Forms.KeyPressEventHandler = AddressOf Me.txtEmailID_KeyPress
                If Me._txtEmailID IsNot Nothing Then
                    RemoveHandler Me._txtEmailID.Validating, value2
                    RemoveHandler Me._txtEmailID.KeyPress, value3
                End If

                Me._txtEmailID = value
                If Me._txtEmailID IsNot Nothing Then
                    AddHandler Me._txtEmailID.Validating, value2
                    AddHandler Me._txtEmailID.KeyPress, value3
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

        Friend Overridable Property btnSendMail As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnSendMail
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.Button1_Click
                If Me._btnSendMail IsNot Nothing Then
                    RemoveHandler Me._btnSendMail.Click, value2
                End If

                Me._btnSendMail = value
                If Me._btnSendMail IsNot Nothing Then
                    AddHandler Me._btnSendMail.Click, value2
                End If
            End Set
        End Property

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

        Friend Overridable Property btnKeyboard As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnKeyboard
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnKeyboard_Click
                If Me._btnKeyboard IsNot Nothing Then
                    RemoveHandler Me._btnKeyboard.Click, value2
                End If

                Me._btnKeyboard = value
                If Me._btnKeyboard IsNot Nothing Then
                    AddHandler Me._btnKeyboard.Click, value2
                End If
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

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            AddHandler MyBase.FormClosing, AddressOf Me.frmChangePassword1_FormClosing
            AddHandler MyBase.Load, AddressOf Me.frmChangePassword_Load
            Call RestaurantPOS14.frmRecoveryPIN.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmRecoveryPIN.__ENCList
                If RestaurantPOS14.frmRecoveryPIN.__ENCList.Count = RestaurantPOS14.frmRecoveryPIN.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmRecoveryPIN.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmRecoveryPIN.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmRecoveryPIN.__ENCList(num) = RestaurantPOS14.frmRecoveryPIN.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmRecoveryPIN.__ENCList.RemoveRange(num, RestaurantPOS14.frmRecoveryPIN.__ENCList.Count - num)
                    RestaurantPOS14.frmRecoveryPIN.__ENCList.Capacity = RestaurantPOS14.frmRecoveryPIN.__ENCList.Count
                End If

                Call RestaurantPOS14.frmRecoveryPIN.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Private Sub Button1_Click(sender As Object, e As System.EventArgs)
            Try
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtEmailID.Text, "", TextCompare:=False) = 0 Then
                    Call System.Windows.Forms.MessageBox.Show("Please enter Email ID", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Me.txtEmailID.Focus()
                    Return
                End If

                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select count(*) from EmailSetting Having count(*) <=0")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call RestaurantPOS14.My.MyProject.Forms.frmCustomDialog15.ShowDialog()
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select EmailID from registration where EmailID=@d1")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtEmailID.Text)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If Not RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call RestaurantPOS14.My.MyProject.Forms.frmCustomDialog14.ShowDialog()
                    Me.txtEmailID.Text = ""
                    Me.txtEmailID.Focus()
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                RestaurantPOS14.ModClasses.con.Close()
                MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Me.Timer1.Enabled = True
                If Not RestaurantPOS14.ModFunc.CheckForInternetConnection() Then
                    Return
                End If

                MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Me.Timer1.Enabled = True
                Dim smtpUser As String = Nothing
                Dim smtpPassword As String = Nothing
                Dim smtpAddress As String = Nothing
                Dim smtpPort As Integer
                Using connection As New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    connection.Open()
                    Using command As New System.Data.SqlClient.SqlCommand("select TOP 1 RTRIM(Username),RTRIM(Password),RTRIM(SMTPAddress),(Port) from EmailSetting where IsDefault='Yes' and IsActive='Yes'", connection)
                        Using reader = command.ExecuteReader(System.Data.CommandBehavior.SingleRow)
                            If Not reader.Read() Then
                                Call RestaurantPOS14.My.MyProject.Forms.frmCustomDialog15.ShowDialog()
                                Return
                            End If
                            smtpUser = If(reader.IsDBNull(0), String.Empty, reader.GetString(0).Trim())
                            smtpPassword = If(reader.IsDBNull(1), String.Empty, RestaurantPOS14.ModFunc.Decrypt(reader.GetString(1).Trim()))
                            smtpAddress = If(reader.IsDBNull(2), String.Empty, reader.GetString(2).Trim())
                            smtpPort = If(reader.IsDBNull(3), 0, Convert.ToInt32(reader.GetValue(3)))
                        End Using
                    End Using
                End Using

                Dim temporaryPin = RestaurantPOS14.Security.PinSecurity.CreateTemporaryPin()
                Dim sent = RestaurantPOS14.ModFunc.SendMail(smtpUser, Me.txtEmailID.Text.Trim(), "Your temporary PIN: " & temporaryPin & ". Change it after signing in.", "Temporary PIN", smtpAddress, smtpPort, smtpUser, smtpPassword)
                If Not sent Then Return

                Using connection As New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    connection.Open()
                    Using command As New System.Data.SqlClient.SqlCommand("UPDATE Registration SET Password=@password WHERE EmailID=@email", connection)
                        command.Parameters.Add("@password", System.Data.SqlDbType.NChar, 50).Value = RestaurantPOS14.Security.PinSecurity.HashPin(temporaryPin)
                        command.Parameters.Add("@email", System.Data.SqlDbType.NChar, 150).Value = Me.txtEmailID.Text.Trim()
                        If command.ExecuteNonQuery() <> 1 Then Throw New InvalidOperationException("The user PIN could not be updated.")
                    End Using
                End Using

                Call System.Windows.Forms.MessageBox.Show("A temporary PIN was sent." & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Please check your mail.", "Thank you", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                MyBase.Hide()
                Call RestaurantPOS14.My.MyProject.Forms.frmLogin.Show()
                RestaurantPOS14.My.MyProject.Forms.frmLogin.UserID.Text = ""
                RestaurantPOS14.My.MyProject.Forms.frmLogin.Password.PasswordChar = Global.Microsoft.VisualBasic.Strings.ChrW(0)
                RestaurantPOS14.My.MyProject.Forms.frmLogin.Password.Text = "ENTER PIN"
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub frmChangePassword1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs)
            MyBase.Hide()
            Call RestaurantPOS14.My.MyProject.Forms.frmLogin.Show()
            RestaurantPOS14.My.MyProject.Forms.frmLogin.UserID.Text = ""
            RestaurantPOS14.My.MyProject.Forms.frmLogin.Password.PasswordChar = Global.Microsoft.VisualBasic.Strings.ChrW(0)
            RestaurantPOS14.My.MyProject.Forms.frmLogin.Password.Text = "ENTER PIN"
        End Sub

        Private Sub frmChangePassword_Load(sender As Object, e As System.EventArgs)
            Dim panel As System.Windows.Forms.Panel = Me.Panel1
            Dim location As System.Drawing.Point = New System.Drawing.Point(CInt(System.Math.Round(CDbl(MyBase.ClientSize.Width) / 2.0 - CDbl(Me.Panel1.Size.Width) / 2.0)), CInt(System.Math.Round(CDbl(MyBase.ClientSize.Height) / 2.0 - CDbl(Me.Panel1.Size.Height) / 2.0)))
            panel.Location = location
            Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        End Sub

        Private Sub btnCancel_Click(sender As Object, e As System.EventArgs)
            MyBase.Hide()
            Call RestaurantPOS14.My.MyProject.Forms.frmLogin.Show()
            RestaurantPOS14.My.MyProject.Forms.frmLogin.UserID.Text = ""
            RestaurantPOS14.My.MyProject.Forms.frmLogin.Password.PasswordChar = Global.Microsoft.VisualBasic.Strings.ChrW(0)
            RestaurantPOS14.My.MyProject.Forms.frmLogin.Password.Text = "ENTER PIN"
        End Sub

        Private Sub btnKeyboard_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.ModFunc.OSKeyboard()
        End Sub

        Private Sub OldPassword_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
            If((e.KeyChar < "0"c) Or (e.KeyChar > "9"c)) And (e.KeyChar <> Global.Microsoft.VisualBasic.Strings.ChrW(8)) Then
                e.Handled = True
            End If
        End Sub

        Private Sub NewPassword_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
            If((e.KeyChar < "0"c) Or (e.KeyChar > "9"c)) And (e.KeyChar <> Global.Microsoft.VisualBasic.Strings.ChrW(8)) Then
                e.Handled = True
            End If
        End Sub

        Private Sub ConfirmPassword_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
            If((e.KeyChar < "0"c) Or (e.KeyChar > "9"c)) And (e.KeyChar <> Global.Microsoft.VisualBasic.Strings.ChrW(8)) Then
                e.Handled = True
            End If
        End Sub

        Private Sub txtEmailID_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
            Dim text As String = "@"
            If e.KeyChar <> Global.Microsoft.VisualBasic.Strings.ChrW(8) AndAlso ((Microsoft.VisualBasic.Strings.Asc(e.KeyChar) < 97) Or (Microsoft.VisualBasic.Strings.Asc(e.KeyChar) > 122)) AndAlso ((Microsoft.VisualBasic.Strings.Asc(e.KeyChar) <> 46) And (Microsoft.VisualBasic.Strings.Asc(e.KeyChar) <> 95)) AndAlso ((Microsoft.VisualBasic.Strings.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Strings.Asc(e.KeyChar) > 57)) Then
                If text.IndexOf(e.KeyChar) = -1 Then
                    e.Handled = True
                ElseIf Me.txtEmailID.Text.Contains("@") And (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Microsoft.VisualBasic.CompilerServices.Conversions.ToString(e.KeyChar), "@", TextCompare:=False) = 0) Then
                    e.Handled = True
                End If
            End If
        End Sub

        Private Sub txtEmailID_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
            Dim pattern As String = "^[a-z][a-z|0-9|]*([_][a-z|0-9]+)*([.][a-z|0-9]+([_][a-z|0-9]+)*)?@[a-z][a-z|0-9|]*\.([a-z][a-z|0-9]*(\.[a-z][a-z|0-9]*)?)$"
            If Not System.Text.RegularExpressions.Regex.Match(CStr((Me.txtEmailID.Text.Trim())), CStr((pattern)), CType((System.Text.RegularExpressions.RegexOptions.IgnoreCase), System.Text.RegularExpressions.RegexOptions)).Success Then
                Call System.Windows.Forms.MessageBox.Show("Please enter a valid email id", "Checking", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                Me.txtEmailID.Clear()
            End If
        End Sub

        Private Sub Timer1_Tick(sender As Object, e As System.EventArgs)
            MyBase.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.Timer1.Enabled = False
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmRecoveryPIN))
            Me.txtEmailID = New System.Windows.Forms.TextBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.btnSendMail = New System.Windows.Forms.Button()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnKeyboard = New System.Windows.Forms.Button()
            Me.Panel1.SuspendLayout()
            MyBase.SuspendLayout()
            Me.txtEmailID.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
            Me.txtEmailID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.txtEmailID.ForeColor = System.Drawing.Color.Black
            Dim textBox As System.Windows.Forms.TextBox = Me.txtEmailID
            Dim location As System.Drawing.Point = New System.Drawing.Point(20, 54)
            textBox.Location = location
            Me.txtEmailID.Name = "txtEmailID"
            Dim textBox2 As System.Windows.Forms.TextBox = Me.txtEmailID
            Dim size As System.Drawing.Size = New System.Drawing.Size(370, 29)
            textBox2.Size = size
            Me.txtEmailID.TabIndex = 10
            Me.Label4.AutoSize = True
            Me.Label4.BackColor = System.Drawing.Color.Transparent
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label4.ForeColor = System.Drawing.Color.Black
            Dim label As System.Windows.Forms.Label = Me.Label4
            location = New System.Drawing.Point(16, 25)
            label.Location = location
            Me.Label4.Name = "Label4"
            Dim label2 As System.Windows.Forms.Label = Me.Label4
            size = New System.Drawing.Size(139, 24)
            label2.Size = size
            Me.Label4.TabIndex = 17
            Me.Label4.Text = "Enter Email ID :"
            Me.Panel1.BackColor = System.Drawing.Color.Snow
            Me.Panel1.Controls.Add(Me.Label4)
            Me.Panel1.Controls.Add(Me.txtEmailID)
            Me.Panel1.Controls.Add(Me.btnSendMail)
            Dim panel As System.Windows.Forms.Panel = Me.Panel1
            location = New System.Drawing.Point(154, 155)
            panel.Location = location
            Me.Panel1.Name = "Panel1"
            Dim panel2 As System.Windows.Forms.Panel = Me.Panel1
            size = New System.Drawing.Size(405, 185)
            panel2.Size = size
            Me.Panel1.TabIndex = 18
            Me.btnSendMail.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.btnSendMail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.btnSendMail.FlatAppearance.BorderSize = 0
            Me.btnSendMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSendMail.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnSendMail.ForeColor = System.Drawing.Color.White
            Dim button As System.Windows.Forms.Button = Me.btnSendMail
            location = New System.Drawing.Point(20, 109)
            button.Location = location
            Me.btnSendMail.Name = "btnSendMail"
            Dim button2 As System.Windows.Forms.Button = Me.btnSendMail
            size = New System.Drawing.Size(147, 57)
            button2.Size = size
            Me.btnSendMail.TabIndex = 15
            Me.btnSendMail.Text = "&Send Email"
            Me.btnSendMail.UseVisualStyleBackColor = False
            Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.Label5.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label5.ForeColor = System.Drawing.Color.White
            Dim label3 As System.Windows.Forms.Label = Me.Label5
            location = New System.Drawing.Point(1, -1)
            label3.Location = location
            Me.Label5.Name = "Label5"
            Dim label4 As System.Windows.Forms.Label = Me.Label5
            size = New System.Drawing.Size(696, 50)
            label4.Size = size
            Me.Label5.TabIndex = 19
            Me.Label5.Text = "PIN Recovery Form"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
            Me.btnCancel.BackColor = System.Drawing.Color.Transparent
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.FlatAppearance.BorderSize = 0
            Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnCancel.Image = CType(componentResourceManager.GetObject("btnCancel.Image"), System.Drawing.Image)
            Dim button3 As System.Windows.Forms.Button = Me.btnCancel
            location = New System.Drawing.Point(759, 0)
            button3.Location = location
            Me.btnCancel.Name = "btnCancel"
            Dim button4 As System.Windows.Forms.Button = Me.btnCancel
            size = New System.Drawing.Size(52, 49)
            button4.Size = size
            Me.btnCancel.TabIndex = 60
            Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnCancel.UseVisualStyleBackColor = False
            Me.btnKeyboard.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
            Me.btnKeyboard.BackColor = System.Drawing.Color.Transparent
            Me.btnKeyboard.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnKeyboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 64, 64)
            Me.btnKeyboard.FlatAppearance.BorderSize = 0
            Me.btnKeyboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnKeyboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnKeyboard.Image = CType(componentResourceManager.GetObject("btnKeyboard.Image"), System.Drawing.Image)
            Dim button5 As System.Windows.Forms.Button = Me.btnKeyboard
            location = New System.Drawing.Point(703, 0)
            button5.Location = location
            Me.btnKeyboard.Name = "btnKeyboard"
            Dim button6 As System.Windows.Forms.Button = Me.btnKeyboard
            size = New System.Drawing.Size(52, 49)
            button6.Size = size
            Me.btnKeyboard.TabIndex = 59
            Me.btnKeyboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnKeyboard.UseVisualStyleBackColor = False
            MyBase.AcceptButton = Me.btnSendMail
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            size = New System.Drawing.Size(810, 434)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.btnCancel)
            MyBase.Controls.Add(Me.btnKeyboard)
            MyBase.Controls.Add(Me.Label5)
            MyBase.Controls.Add(Me.Panel1)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MaximizeBox = False
            MyBase.MinimizeBox = False
            MyBase.Name = "frmRecoveryPIN"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Change Password"
            MyBase.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            MyBase.ResumeLayout(False)
        End Sub
    End Class
End Namespace
