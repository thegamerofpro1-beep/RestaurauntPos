Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports RestaurantPOS14.My
Imports RestaurantPOS14.My.Resources

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public Class frmSendEmail
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label1")>
        Private _Label1 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel3")>
        Private _Panel3 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnReset")>
        Private _btnReset As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnSendEmail")>
        Private _btnSendEmail As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("listView1")>
        Private _listView1 As System.Windows.Forms.ListView

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("columnHeader3")>
        Private _columnHeader3 As System.Windows.Forms.ColumnHeader

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("ColumnHeader2")>
        Private _ColumnHeader2 As System.Windows.Forms.ColumnHeader

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtBody")>
        Private _txtBody As System.Windows.Forms.RichTextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label2")>
        Private _Label2 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Timer1")>
        Private _Timer1 As System.Windows.Forms.Timer

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Timer2")>
        Private _Timer2 As System.Windows.Forms.Timer

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtSubject")>
        Private _txtSubject As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label3")>
        Private _Label3 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtFilePath")>
        Private _txtFilePath As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnBrowse")>
        Private _btnBrowse As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label4")>
        Private _Label4 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("OpenFileDialog1")>
        Private _OpenFileDialog1 As System.Windows.Forms.OpenFileDialog

        Private st1 As String

        Private st2 As String

        Private st3 As String

        Private components As System.ComponentModel.IContainer

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

        Friend Overridable Property Panel3 As System.Windows.Forms.Panel
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Panel3
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Panel)
                Me._Panel3 = value
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

        Friend Overridable Property btnSendEmail As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnSendEmail
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnSendSMS_Click
                If Me._btnSendEmail IsNot Nothing Then
                    RemoveHandler Me._btnSendEmail.Click, value2
                End If

                Me._btnSendEmail = value
                If Me._btnSendEmail IsNot Nothing Then
                    AddHandler Me._btnSendEmail.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property listView1 As System.Windows.Forms.ListView
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._listView1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ListView)
                Me._listView1 = value
            End Set
        End Property

        Friend Overridable Property columnHeader3 As System.Windows.Forms.ColumnHeader
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._columnHeader3
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ColumnHeader)
                Me._columnHeader3 = value
            End Set
        End Property

        Friend Overridable Property ColumnHeader2 As System.Windows.Forms.ColumnHeader
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._ColumnHeader2
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ColumnHeader)
                Me._ColumnHeader2 = value
            End Set
        End Property

        Friend Overridable Property txtBody As System.Windows.Forms.RichTextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtBody
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.RichTextBox)
                Me._txtBody = value
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

        Friend Overridable Property txtSubject As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtSubject
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtSubject = value
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

        Friend Overridable Property txtFilePath As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtFilePath
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtFilePath = value
            End Set
        End Property

        Friend Overridable Property btnBrowse As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnBrowse
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnBrowse_Click
                If Me._btnBrowse IsNot Nothing Then
                    RemoveHandler Me._btnBrowse.Click, value2
                End If

                Me._btnBrowse = value
                If Me._btnBrowse IsNot Nothing Then
                    AddHandler Me._btnBrowse.Click, value2
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

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            Call RestaurantPOS14.frmSendEmail.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmSendEmail.__ENCList
                If RestaurantPOS14.frmSendEmail.__ENCList.Count = RestaurantPOS14.frmSendEmail.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmSendEmail.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmSendEmail.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmSendEmail.__ENCList(num) = RestaurantPOS14.frmSendEmail.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmSendEmail.__ENCList.RemoveRange(num, RestaurantPOS14.frmSendEmail.__ENCList.Count - num)
                    RestaurantPOS14.frmSendEmail.__ENCList.Capacity = RestaurantPOS14.frmSendEmail.__ENCList.Count
                End If

                Call RestaurantPOS14.frmSendEmail.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Public Sub Reset()
            Me.listView1.Items.Clear()
            Me.txtBody.Text = ""
            Me.txtSubject.Text = ""
            Me.txtFilePath.Text = ""
            Me.st1 = ""
            Me.GetData()
        End Sub

        Private Sub btnReset_Click(sender As Object, e As System.EventArgs)
            Me.Reset()
        End Sub

        Public Sub GetData()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Select distinct RTRIM(Customername),RTRIM(EmailID) from RestaurantPOS_BillingInfoKOT where EmailID is NOT NULL and EmailID <> '' order by 1", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                Me.listView1.Items.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Dim listViewItem As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem()
                    listViewItem.Text = RestaurantPOS14.ModClasses.rdr(CInt((0))).ToString().Trim()
                    listViewItem.SubItems.Add(RestaurantPOS14.ModClasses.rdr(CInt((1))).ToString().Trim())
                    Me.listView1.Items.Add(listViewItem)
                End While

                Dim num As Integer = Me.listView1.Items.Count - 1
                Dim num2 As Integer = 0
                While True
                    Dim num3 As Integer = num2
                    Dim num4 As Integer = num
                    If num3 > num4 Then
                        Exit While
                    End If

                    Me.listView1.Items(CInt((num2))).Checked = True
                    num2 += 1
                End While

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnSendSMS_Click(sender As Object, e As System.EventArgs)
            Try
                If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.txtSubject.Text)) = 0 Then
                    Call System.Windows.Forms.MessageBox.Show("Please enter subject", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Me.txtSubject.Focus()
                    Return
                End If

                If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.txtBody.Text)) = 0 Then
                    Call System.Windows.Forms.MessageBox.Show("Please enter body", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Me.txtBody.Focus()
                    Return
                End If

                If Me.listView1.Items.Count = 0 Then
                    Call System.Windows.Forms.MessageBox.Show("Please retrieve customers list", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Return
                End If

                If Me.listView1.CheckedItems.Count = 0 Then
                    Call System.Windows.Forms.MessageBox.Show("Please select at least one customer", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Return
                End If

                If RestaurantPOS14.ModFunc.CheckForInternetConnection() Then
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
                    MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                    Me.Timer2.Enabled = True
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select RTRIM(Username),RTRIM(Password),RTRIM(SMTPAddress),(Port) from EmailSetting where IsDefault='Yes' and IsActive='Yes'")
                    RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                    RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                    If RestaurantPOS14.ModClasses.rdr.Read() Then
                        Dim num As Integer = Me.listView1.Items.Count - 1
                        Dim num2 As Integer = 0
                        While True
                            Dim num3 As Integer = num2
                            Dim num4 As Integer = num
                            If num3 > num4 Then
                                Exit While
                            End If

                            If Me.listView1.Items(CInt((num2))).Checked Then
                                Me.st1 = Me.st1 & Me.listView1.Items(CInt((num2))).SubItems(CInt((1))).Text & ","
                            End If

                            num2 += 1
                        End While

                        Me.st1 = Me.st1.Trim().Remove(Me.st1.Length - 1)
                        If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtFilePath.Text, "", TextCompare:=False) = 0 Then
                            RestaurantPOS14.ModFunc.SendMail(RestaurantPOS14.ModClasses.rdr.GetValue(CInt((0))).ToString(), Me.st1, Me.txtBody.Text, Me.txtSubject.Text, Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(2)), Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(RestaurantPOS14.ModClasses.rdr.GetValue(3)), Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(0)), RestaurantPOS14.ModFunc.Decrypt(Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(1))))
                        Else
                            RestaurantPOS14.ModFunc.SendMail1(RestaurantPOS14.ModClasses.rdr.GetValue(CInt((0))).ToString(), Me.st1, Me.txtBody.Text, Me.txtFilePath.Text, Me.txtSubject.Text, Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(2)), Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(RestaurantPOS14.ModClasses.rdr.GetValue(3)), Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(0)), RestaurantPOS14.ModFunc.Decrypt(Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(1))))
                        End If

                        If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                            RestaurantPOS14.ModClasses.rdr.Close()
                        End If
                    End If
                End If

                Me.Reset()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub Timer2_Tick(sender As Object, e As System.EventArgs)
            MyBase.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.Timer2.Enabled = False
        End Sub

        Private Sub btnBrowse_Click(sender As Object, e As System.EventArgs)
            Try
                Dim openFileDialog As System.Windows.Forms.OpenFileDialog = Me.OpenFileDialog1
                openFileDialog.Filter = "All Files |*.*;"
                openFileDialog.FilterIndex = 4
                Me.OpenFileDialog1.FileName = ""
                If Me.OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                    Me.txtFilePath.Text = Me.OpenFileDialog1.FileName
                End If
            Catch ex As System.Exception
                Call Microsoft.VisualBasic.Interaction.MsgBox(ex.ToString())
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
            Me.components = New System.ComponentModel.Container()
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmSendEmail))
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.btnReset = New System.Windows.Forms.Button()
            Me.btnSendEmail = New System.Windows.Forms.Button()
            Me.listView1 = New System.Windows.Forms.ListView()
            Me.columnHeader3 = New System.Windows.Forms.ColumnHeader()
            Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader()
            Me.txtBody = New System.Windows.Forms.RichTextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
            Me.txtSubject = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtFilePath = New System.Windows.Forms.TextBox()
            Me.btnBrowse = New System.Windows.Forms.Button()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
            Me.Panel3.SuspendLayout()
            MyBase.SuspendLayout()
            Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.Label1.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Dim label As System.Windows.Forms.Label = Me.Label1
            Dim location As System.Drawing.Point = New System.Drawing.Point(0, 0)
            label.Location = location
            Me.Label1.Name = "Label1"
            Dim label2 As System.Windows.Forms.Label = Me.Label1
            Dim size As System.Drawing.Size = New System.Drawing.Size(1000, 29)
            label2.Size = size
            Me.Label1.TabIndex = 1
            Me.Label1.Text = "Email To Customers"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel3.Controls.Add(Me.btnReset)
            Dim panel As System.Windows.Forms.Panel = Me.Panel3
            location = New System.Drawing.Point(13, 48)
            panel.Location = location
            Me.Panel3.Name = "Panel3"
            Dim panel2 As System.Windows.Forms.Panel = Me.Panel3
            size = New System.Drawing.Size(126, 57)
            panel2.Size = size
            Me.Panel3.TabIndex = 3
            Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnReset.Image = RestaurantPOS14.My.Resources.Resources.Reset2_32x32
            Me.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button As System.Windows.Forms.Button = Me.btnReset
            location = New System.Drawing.Point(13, 9)
            button.Location = location
            Me.btnReset.Name = "btnReset"
            Dim button2 As System.Windows.Forms.Button = Me.btnReset
            size = New System.Drawing.Size(104, 37)
            button2.Size = size
            Me.btnReset.TabIndex = 3
            Me.btnReset.Text = "Reset"
            Me.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnReset.UseVisualStyleBackColor = True
            Me.btnSendEmail.Anchor = System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left
            Me.btnSendEmail.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnSendEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnSendEmail.Image = CType(componentResourceManager.GetObject("btnSendEmail.Image"), System.Drawing.Image)
            Me.btnSendEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button3 As System.Windows.Forms.Button = Me.btnSendEmail
            location = New System.Drawing.Point(574, 520)
            button3.Location = location
            Me.btnSendEmail.Name = "btnSendEmail"
            Dim button4 As System.Windows.Forms.Button = Me.btnSendEmail
            size = New System.Drawing.Size(121, 45)
            button4.Size = size
            Me.btnSendEmail.TabIndex = 2
            Me.btnSendEmail.Text = "Send Email"
            Me.btnSendEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnSendEmail.UseVisualStyleBackColor = True
            Me.listView1.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left
            Me.listView1.CheckBoxes = True
            Me.listView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader(1) {Me.columnHeader3, Me.ColumnHeader2})
            Me.listView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.listView1.GridLines = True
            Dim listView As System.Windows.Forms.ListView = Me.listView1
            location = New System.Drawing.Point(13, 110)
            listView.Location = location
            Me.listView1.Name = "listView1"
            Dim listView2 As System.Windows.Forms.ListView = Me.listView1
            size = New System.Drawing.Size(556, 557)
            listView2.Size = size
            Me.listView1.TabIndex = 66
            Me.listView1.UseCompatibleStateImageBehavior = False
            Me.listView1.View = System.Windows.Forms.View.Details
            Me.columnHeader3.Text = "Customer Name"
            Me.columnHeader3.Width = 200
            Me.ColumnHeader2.Text = "Email"
            Me.ColumnHeader2.Width = 350
            Me.txtBody.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.txtBody.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim richTextBox As System.Windows.Forms.RichTextBox = Me.txtBody
            location = New System.Drawing.Point(575, 178)
            richTextBox.Location = location
            Me.txtBody.Name = "txtBody"
            Me.txtBody.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
            Dim richTextBox2 As System.Windows.Forms.RichTextBox = Me.txtBody
            size = New System.Drawing.Size(415, 288)
            richTextBox2.Size = size
            Me.txtBody.TabIndex = 1
            Me.txtBody.Text = ""
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim label3 As System.Windows.Forms.Label = Me.Label2
            location = New System.Drawing.Point(575, 160)
            label3.Location = location
            Me.Label2.Name = "Label2"
            Dim label4 As System.Windows.Forms.Label = Me.Label2
            size = New System.Drawing.Size(40, 15)
            label4.Size = size
            Me.Label2.TabIndex = 68
            Me.Label2.Text = "Body :"
            Me.txtSubject.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.txtSubject.Font = New System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox As System.Windows.Forms.TextBox = Me.txtSubject
            location = New System.Drawing.Point(578, 128)
            textBox.Location = location
            Me.txtSubject.Name = "txtSubject"
            Dim textBox2 As System.Windows.Forms.TextBox = Me.txtSubject
            size = New System.Drawing.Size(408, 29)
            textBox2.Size = size
            Me.txtSubject.TabIndex = 0
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim label5 As System.Windows.Forms.Label = Me.Label3
            location = New System.Drawing.Point(575, 110)
            label5.Location = location
            Me.Label3.Name = "Label3"
            Dim label6 As System.Windows.Forms.Label = Me.Label3
            size = New System.Drawing.Size(53, 15)
            label6.Size = size
            Me.Label3.TabIndex = 70
            Me.Label3.Text = "Subject :"
            Me.txtFilePath.Anchor = System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.txtFilePath.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox3 As System.Windows.Forms.TextBox = Me.txtFilePath
            location = New System.Drawing.Point(574, 492)
            textBox3.Location = location
            Me.txtFilePath.Name = "txtFilePath"
            Me.txtFilePath.[ReadOnly] = True
            Dim textBox4 As System.Windows.Forms.TextBox = Me.txtFilePath
            size = New System.Drawing.Size(329, 22)
            textBox4.Size = size
            Me.txtFilePath.TabIndex = 72
            Me.btnBrowse.Anchor = System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right
            Dim button5 As System.Windows.Forms.Button = Me.btnBrowse
            location = New System.Drawing.Point(909, 472)
            button5.Location = location
            Me.btnBrowse.Name = "btnBrowse"
            Dim button6 As System.Windows.Forms.Button = Me.btnBrowse
            size = New System.Drawing.Size(77, 42)
            button6.Size = size
            Me.btnBrowse.TabIndex = 73
            Me.btnBrowse.Text = "Browse..."
            Me.btnBrowse.UseVisualStyleBackColor = True
            Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim label7 As System.Windows.Forms.Label = Me.Label4
            location = New System.Drawing.Point(571, 472)
            label7.Location = location
            Me.Label4.Name = "Label4"
            Dim label8 As System.Windows.Forms.Label = Me.Label4
            size = New System.Drawing.Size(87, 17)
            label8.Size = size
            Me.Label4.TabIndex = 71
            Me.Label4.Text = "Attachment :"
            Me.OpenFileDialog1.FileName = "OpenFileDialog1"
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
            size = New System.Drawing.Size(998, 671)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.txtFilePath)
            MyBase.Controls.Add(Me.btnBrowse)
            MyBase.Controls.Add(Me.Label4)
            MyBase.Controls.Add(Me.Label3)
            MyBase.Controls.Add(Me.txtSubject)
            MyBase.Controls.Add(Me.Label2)
            MyBase.Controls.Add(Me.txtBody)
            MyBase.Controls.Add(Me.btnSendEmail)
            MyBase.Controls.Add(Me.listView1)
            MyBase.Controls.Add(Me.Panel3)
            MyBase.Controls.Add(Me.Label1)
            Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MinimizeBox = False
            MyBase.Name = "frmSendEmail"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Send Email"
            Me.Panel3.ResumeLayout(False)
            MyBase.ResumeLayout(False)
            MyBase.PerformLayout()
        End Sub
    End Class
End Namespace
