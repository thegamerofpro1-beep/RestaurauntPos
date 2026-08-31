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

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public Class frmMpesaSetting
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel1")>
        Private _Panel1 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label1")>
        Private _Label1 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel4")>
        Private _Panel4 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label3")>
        Private _Label3 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtOAuthURL")>
        Private _txtOAuthURL As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtC2BSimulateURL")>
        Private _txtC2BSimulateURL As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label5")>
        Private _Label5 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtConsumerSecret")>
        Private _txtConsumerSecret As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label4")>
        Private _Label4 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtConsumerKey")>
        Private _txtConsumerKey As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label2")>
        Private _Label2 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtShortCode")>
        Private _txtShortCode As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label6")>
        Private _Label6 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtID")>
        Private _txtID As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnSave")>
        Private _btnSave As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("chkActive")>
        Private _chkActive As System.Windows.Forms.CheckBox

        Private st As String

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

        Friend Overridable Property txtOAuthURL As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtOAuthURL
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtOAuthURL = value
            End Set
        End Property

        Friend Overridable Property txtC2BSimulateURL As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtC2BSimulateURL
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtC2BSimulateURL = value
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

        Friend Overridable Property txtConsumerSecret As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtConsumerSecret
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtConsumerSecret = value
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

        Friend Overridable Property txtConsumerKey As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtConsumerKey
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtConsumerKey = value
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

        Friend Overridable Property txtShortCode As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtShortCode
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtShortCode = value
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

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            AddHandler MyBase.Load, AddressOf Me.frmInvCode_Load
            AddHandler MyBase.KeyDown, AddressOf Me.frmInvoiceCode_KeyDown
            Call RestaurantPOS14.frmMpesaSetting.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmMpesaSetting.__ENCList
                If RestaurantPOS14.frmMpesaSetting.__ENCList.Count = RestaurantPOS14.frmMpesaSetting.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmMpesaSetting.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmMpesaSetting.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmMpesaSetting.__ENCList(num) = RestaurantPOS14.frmMpesaSetting.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmMpesaSetting.__ENCList.RemoveRange(num, RestaurantPOS14.frmMpesaSetting.__ENCList.Count - num)
                    RestaurantPOS14.frmMpesaSetting.__ENCList.Capacity = RestaurantPOS14.frmMpesaSetting.__ENCList.Count
                End If

                Call RestaurantPOS14.frmMpesaSetting.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Private Sub frmInvCode_Load(sender As Object, e As System.EventArgs)
            Me.Getdata()
        End Sub

        Private Sub Getdata()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.ReadCS())
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = RestaurantPOS14.ModClasses.con.CreateCommand()
                RestaurantPOS14.ModClasses.cmd.CommandText = "SELECT ID,RTRIM(c1), RTRIM(c2), RTRIM(c3), RTRIM(c4), RTRIM(c5), RTRIM(c6) from MpesaSetting"
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.txtID.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                    If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(RestaurantPOS14.ModClasses.rdr.GetValue(CInt((1))).ToString(), "Yes", TextCompare:=False) = 0 Then
                        Me.chkActive.Checked = True
                    Else
                        Me.chkActive.Checked = False
                    End If

                    Me.txtOAuthURL.Text = RestaurantPOS14.ModClasses.rdr.GetValue(CInt((2))).ToString()
                    Me.txtConsumerKey.Text = RestaurantPOS14.ModClasses.rdr.GetValue(CInt((3))).ToString()
                    Me.txtConsumerSecret.Text = RestaurantPOS14.ModClasses.rdr.GetValue(CInt((4))).ToString()
                    Me.txtC2BSimulateURL.Text = RestaurantPOS14.ModClasses.rdr.GetValue(CInt((5))).ToString()
                    Me.txtShortCode.Text = RestaurantPOS14.ModClasses.rdr.GetValue(CInt((6))).ToString()
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
            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtOAuthURL.Text, "", TextCompare:=False) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please Enter OAuth URL", "Warning", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtOAuthURL.Focus()
                Return
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtConsumerKey.Text, "", TextCompare:=False) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please Enter Consumer Key", "Warning", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtConsumerKey.Focus()
                Return
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtConsumerSecret.Text, "", TextCompare:=False) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please Enter Consumer Secret", "Warning", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtConsumerSecret.Focus()
                Return
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtC2BSimulateURL.Text, "", TextCompare:=False) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please Enter C2B Simulate URL", "Warning", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtC2BSimulateURL.Focus()
                Return
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtShortCode.Text, "", TextCompare:=False) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please enter Short Code/Till Number", "Warning", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtShortCode.Focus()
                Return
            End If

            If Me.chkActive.Checked Then
                Me.st = "Yes"
            Else
                Me.st = "No"
            End If

            Try
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtID.Text, "", TextCompare:=False) = 0 Then
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.ReadCS())
                    RestaurantPOS14.ModClasses.con.Open()
                    RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Insert into MpesaSetting(C1,C2,C3,C4,C5,C6) Values (@d1,@d2,@d3,@d4,@d5,@d6)")
                    RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.st)
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Me.txtOAuthURL.Text)
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Me.txtConsumerKey.Text)
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", Me.txtConsumerSecret.Text)
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d5", Me.txtC2BSimulateURL.Text)
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d6", Me.txtShortCode.Text)
                    RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                    Call System.Windows.Forms.MessageBox.Show("Successfully Saved", "Information", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    Me.Getdata()
                Else
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.ReadCS())
                    RestaurantPOS14.ModClasses.con.Open()
                    RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Update MpesaSetting set c1=@d1,c2=@d2,c3=@d3,c4=@d4,c5=@d5,c6=@d6 where ID=@d0")
                    RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d0", Microsoft.VisualBasic.Conversion.Val(Me.txtID.Text))
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.st)
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Me.txtOAuthURL.Text)
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Me.txtConsumerKey.Text)
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", Me.txtConsumerSecret.Text)
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d5", Me.txtC2BSimulateURL.Text)
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d6", Me.txtShortCode.Text)
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmMpesaSetting))
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.btnSave = New System.Windows.Forms.Button()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Panel4 = New System.Windows.Forms.Panel()
            Me.chkActive = New System.Windows.Forms.CheckBox()
            Me.txtShortCode = New System.Windows.Forms.TextBox()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.txtC2BSimulateURL = New System.Windows.Forms.TextBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.txtConsumerSecret = New System.Windows.Forms.TextBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtConsumerKey = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtOAuthURL = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtID = New System.Windows.Forms.TextBox()
            Me.Panel1.SuspendLayout()
            Me.Panel4.SuspendLayout()
            MyBase.SuspendLayout()
            Me.Panel1.BackColor = System.Drawing.Color.White
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.btnSave)
            Me.Panel1.Controls.Add(Me.Label1)
            Me.Panel1.Controls.Add(Me.Panel4)
            Me.Panel1.Controls.Add(Me.txtID)
            Dim panel As System.Windows.Forms.Panel = Me.Panel1
            Dim location As System.Drawing.Point = New System.Drawing.Point(7, 7)
            panel.Location = location
            Me.Panel1.Name = "Panel1"
            Dim panel2 As System.Windows.Forms.Panel = Me.Panel1
            Dim size As System.Drawing.Size = New System.Drawing.Size(639, 291)
            panel2.Size = size
            Me.Panel1.TabIndex = 0
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
            location = New System.Drawing.Point(248, 226)
            button.Location = location
            Me.btnSave.Name = "btnSave"
            Dim button2 As System.Windows.Forms.Button = Me.btnSave
            size = New System.Drawing.Size(95, 55)
            button2.Size = size
            Me.btnSave.TabIndex = 1
            Me.btnSave.Text = "&Save"
            Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnSave.UseVisualStyleBackColor = False
            Me.Label1.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Label1.Font = New System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label1.ForeColor = System.Drawing.Color.White
            Dim label As System.Windows.Forms.Label = Me.Label1
            location = New System.Drawing.Point(4, 4)
            label.Location = location
            Me.Label1.Name = "Label1"
            Dim label2 As System.Windows.Forms.Label = Me.Label1
            size = New System.Drawing.Size(627, 31)
            label2.Size = size
            Me.Label1.TabIndex = 46
            Me.Label1.Text = "M-PESA API Setting"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel4.Controls.Add(Me.chkActive)
            Me.Panel4.Controls.Add(Me.txtShortCode)
            Me.Panel4.Controls.Add(Me.Label6)
            Me.Panel4.Controls.Add(Me.txtC2BSimulateURL)
            Me.Panel4.Controls.Add(Me.Label5)
            Me.Panel4.Controls.Add(Me.txtConsumerSecret)
            Me.Panel4.Controls.Add(Me.Label4)
            Me.Panel4.Controls.Add(Me.txtConsumerKey)
            Me.Panel4.Controls.Add(Me.Label2)
            Me.Panel4.Controls.Add(Me.txtOAuthURL)
            Me.Panel4.Controls.Add(Me.Label3)
            Me.Panel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim panel3 As System.Windows.Forms.Panel = Me.Panel4
            location = New System.Drawing.Point(4, 40)
            panel3.Location = location
            Me.Panel4.Name = "Panel4"
            Dim panel4 As System.Windows.Forms.Panel = Me.Panel4
            size = New System.Drawing.Size(627, 179)
            panel4.Size = size
            Me.Panel4.TabIndex = 0
            Me.chkActive.AutoSize = True
            Dim checkBox As System.Windows.Forms.CheckBox = Me.chkActive
            location = New System.Drawing.Point(185, 8)
            checkBox.Location = location
            Me.chkActive.Name = "chkActive"
            Dim checkBox2 As System.Windows.Forms.CheckBox = Me.chkActive
            size = New System.Drawing.Size(91, 19)
            checkBox2.Size = size
            Me.chkActive.TabIndex = 0
            Me.chkActive.Text = "isEnabled ?"
            Me.chkActive.UseVisualStyleBackColor = True
            Me.txtShortCode.BackColor = System.Drawing.Color.FromArgb(255, 255, 192)
            Me.txtShortCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox As System.Windows.Forms.TextBox = Me.txtShortCode
            location = New System.Drawing.Point(185, 141)
            textBox.Location = location
            Me.txtShortCode.Name = "txtShortCode"
            Dim textBox2 As System.Windows.Forms.TextBox = Me.txtShortCode
            size = New System.Drawing.Size(108, 21)
            textBox2.Size = size
            Me.txtShortCode.TabIndex = 5
            Me.Label6.AutoSize = True
            Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label6.ForeColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Dim label3 As System.Windows.Forms.Label = Me.Label6
            location = New System.Drawing.Point(15, 141)
            label3.Location = location
            Me.Label6.Name = "Label6"
            Dim label4 As System.Windows.Forms.Label = Me.Label6
            size = New System.Drawing.Size(164, 17)
            label4.Size = size
            Me.Label6.TabIndex = 411
            Me.Label6.Text = "Short Code/Till Number :"
            Me.txtC2BSimulateURL.BackColor = System.Drawing.Color.FromArgb(255, 255, 192)
            Me.txtC2BSimulateURL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox3 As System.Windows.Forms.TextBox = Me.txtC2BSimulateURL
            location = New System.Drawing.Point(185, 114)
            textBox3.Location = location
            Me.txtC2BSimulateURL.Name = "txtC2BSimulateURL"
            Dim textBox4 As System.Windows.Forms.TextBox = Me.txtC2BSimulateURL
            size = New System.Drawing.Size(429, 21)
            textBox4.Size = size
            Me.txtC2BSimulateURL.TabIndex = 4
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label5.ForeColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Dim label5 As System.Windows.Forms.Label = Me.Label5
            location = New System.Drawing.Point(15, 114)
            label5.Location = location
            Me.Label5.Name = "Label5"
            Dim label6 As System.Windows.Forms.Label = Me.Label5
            size = New System.Drawing.Size(125, 17)
            label6.Size = size
            Me.Label5.TabIndex = 409
            Me.Label5.Text = "C2B Simulate URL :"
            Me.txtConsumerSecret.BackColor = System.Drawing.Color.FromArgb(255, 255, 192)
            Me.txtConsumerSecret.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox5 As System.Windows.Forms.TextBox = Me.txtConsumerSecret
            location = New System.Drawing.Point(185, 87)
            textBox5.Location = location
            Me.txtConsumerSecret.Name = "txtConsumerSecret"
            Dim textBox6 As System.Windows.Forms.TextBox = Me.txtConsumerSecret
            size = New System.Drawing.Size(313, 21)
            textBox6.Size = size
            Me.txtConsumerSecret.TabIndex = 3
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label4.ForeColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Dim label7 As System.Windows.Forms.Label = Me.Label4
            location = New System.Drawing.Point(15, 87)
            label7.Location = location
            Me.Label4.Name = "Label4"
            Dim label8 As System.Windows.Forms.Label = Me.Label4
            size = New System.Drawing.Size(119, 17)
            label8.Size = size
            Me.Label4.TabIndex = 407
            Me.Label4.Text = "Consumer Secret :"
            Me.txtConsumerKey.BackColor = System.Drawing.Color.FromArgb(255, 255, 192)
            Me.txtConsumerKey.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox7 As System.Windows.Forms.TextBox = Me.txtConsumerKey
            location = New System.Drawing.Point(185, 60)
            textBox7.Location = location
            Me.txtConsumerKey.Name = "txtConsumerKey"
            Dim textBox8 As System.Windows.Forms.TextBox = Me.txtConsumerKey
            size = New System.Drawing.Size(313, 21)
            textBox8.Size = size
            Me.txtConsumerKey.TabIndex = 2
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label2.ForeColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Dim label9 As System.Windows.Forms.Label = Me.Label2
            location = New System.Drawing.Point(15, 60)
            label9.Location = location
            Me.Label2.Name = "Label2"
            Dim label10 As System.Windows.Forms.Label = Me.Label2
            size = New System.Drawing.Size(104, 17)
            label10.Size = size
            Me.Label2.TabIndex = 405
            Me.Label2.Text = "Consumer Key :"
            Me.txtOAuthURL.BackColor = System.Drawing.Color.FromArgb(255, 255, 192)
            Me.txtOAuthURL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox9 As System.Windows.Forms.TextBox = Me.txtOAuthURL
            location = New System.Drawing.Point(185, 33)
            textBox9.Location = location
            Me.txtOAuthURL.Name = "txtOAuthURL"
            Dim textBox10 As System.Windows.Forms.TextBox = Me.txtOAuthURL
            size = New System.Drawing.Size(429, 21)
            textBox10.Size = size
            Me.txtOAuthURL.TabIndex = 1
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label3.ForeColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Dim label11 As System.Windows.Forms.Label = Me.Label3
            location = New System.Drawing.Point(15, 33)
            label11.Location = location
            Me.Label3.Name = "Label3"
            Dim label12 As System.Windows.Forms.Label = Me.Label3
            size = New System.Drawing.Size(84, 17)
            label12.Size = size
            Me.Label3.TabIndex = 0
            Me.Label3.Text = "OAuth URL :"
            Me.txtID.BackColor = System.Drawing.SystemColors.Control
            Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox11 As System.Windows.Forms.TextBox = Me.txtID
            location = New System.Drawing.Point(77, 8)
            textBox11.Location = location
            Me.txtID.Name = "txtID"
            Me.txtID.[ReadOnly] = True
            Dim textBox12 As System.Windows.Forms.TextBox = Me.txtID
            size = New System.Drawing.Size(27, 21)
            textBox12.Size = size
            Me.txtID.TabIndex = 414
            Me.txtID.TabStop = False
            Me.txtID.Visible = False
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            size = New System.Drawing.Size(650, 302)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.Panel1)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.KeyPreview = True
            MyBase.MaximizeBox = False
            MyBase.MinimizeBox = False
            MyBase.Name = "frmMpesaSetting"
            MyBase.ShowInTaskbar = False
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "M-PESA API Setting"
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.Panel4.ResumeLayout(False)
            Me.Panel4.PerformLayout()
            MyBase.ResumeLayout(False)
        End Sub
    End Class
End Namespace
