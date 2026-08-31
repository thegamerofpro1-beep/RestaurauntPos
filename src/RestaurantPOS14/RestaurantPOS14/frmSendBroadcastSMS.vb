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
Imports RestaurantPOS14.My.Resources

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public Class frmSendBroadcastSMS
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label1")>
        Private _Label1 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel3")>
        Private _Panel3 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnReset")>
        Private _btnReset As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnSendSMS")>
        Private _btnSendSMS As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("listView1")>
        Private _listView1 As System.Windows.Forms.ListView

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("columnHeader3")>
        Private _columnHeader3 As System.Windows.Forms.ColumnHeader

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Address")>
        Private _Address As System.Windows.Forms.ColumnHeader

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("ColumnHeader2")>
        Private _ColumnHeader2 As System.Windows.Forms.ColumnHeader

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtMessage")>
        Private _txtMessage As System.Windows.Forms.RichTextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label2")>
        Private _Label2 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Timer1")>
        Private _Timer1 As System.Windows.Forms.Timer

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Timer2")>
        Private _Timer2 As System.Windows.Forms.Timer

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

        Friend Overridable Property btnSendSMS As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnSendSMS
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnSendSMS_Click
                If Me._btnSendSMS IsNot Nothing Then
                    RemoveHandler Me._btnSendSMS.Click, value2
                End If

                Me._btnSendSMS = value
                If Me._btnSendSMS IsNot Nothing Then
                    AddHandler Me._btnSendSMS.Click, value2
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

        Friend Overridable Property Address As System.Windows.Forms.ColumnHeader
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Address
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ColumnHeader)
                Me._Address = value
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

        Friend Overridable Property txtMessage As System.Windows.Forms.RichTextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtMessage
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.RichTextBox)
                Me._txtMessage = value
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

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            Call RestaurantPOS14.frmSendBroadcastSMS.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmSendBroadcastSMS.__ENCList
                If RestaurantPOS14.frmSendBroadcastSMS.__ENCList.Count = RestaurantPOS14.frmSendBroadcastSMS.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmSendBroadcastSMS.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmSendBroadcastSMS.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmSendBroadcastSMS.__ENCList(num) = RestaurantPOS14.frmSendBroadcastSMS.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmSendBroadcastSMS.__ENCList.RemoveRange(num, RestaurantPOS14.frmSendBroadcastSMS.__ENCList.Count - num)
                    RestaurantPOS14.frmSendBroadcastSMS.__ENCList.Capacity = RestaurantPOS14.frmSendBroadcastSMS.__ENCList.Count
                End If

                Call RestaurantPOS14.frmSendBroadcastSMS.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Public Sub Reset()
            Me.listView1.Items.Clear()
            Me.txtMessage.Text = ""
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
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Select distinct RTRIM(Customername),RTRIM(Address),RTRIM(ContactNo) from RestaurantPOS_BillingInfoHD Union Select distinct RTRIM(Customername),RTRIM(Address),RTRIM(ContactNo) from HDCustomer order by 1", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                Me.listView1.Items.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Dim listViewItem As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem()
                    listViewItem.Text = RestaurantPOS14.ModClasses.rdr(CInt((0))).ToString().Trim()
                    listViewItem.SubItems.Add(RestaurantPOS14.ModClasses.rdr(CInt((1))).ToString().Trim())
                    listViewItem.SubItems.Add(RestaurantPOS14.ModClasses.rdr(CInt((2))).ToString().Trim())
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
                If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.txtMessage.Text)) = 0 Then
                    Call System.Windows.Forms.MessageBox.Show("Please enter message", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Me.txtMessage.Focus()
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
                    MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                    Me.Timer2.Enabled = True
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select RTRIM(APIURL) from SMSSetting where IsDefault='Yes' and IsEnabled='Yes'")
                    RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                    Dim sqlDataReader As System.Data.SqlClient.SqlDataReader = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                    If sqlDataReader.Read() Then
                        Me.st2 = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(sqlDataReader.GetValue(0))
                        Dim num As Integer = Me.listView1.Items.Count - 1
                        Dim num2 As Integer = 0
                        While True
                            Dim num3 As Integer = num2
                            Dim num4 As Integer = num
                            If num3 > num4 Then
                                Exit While
                            End If

                            If Me.listView1.Items(CInt((num2))).Checked Then
                                Me.st1 = Me.st1 & Me.listView1.Items(CInt((num2))).SubItems(CInt((2))).Text & ","
                            End If

                            num2 += 1
                        End While

                        Me.st1 = Me.st1.Trim().Remove(Me.st1.Length - 1)
                        RestaurantPOS14.ModFunc.SMSFunc(Me.st1, Me.txtMessage.Text, Me.st2)
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmSendBroadcastSMS))
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.btnReset = New System.Windows.Forms.Button()
            Me.btnSendSMS = New System.Windows.Forms.Button()
            Me.listView1 = New System.Windows.Forms.ListView()
            Me.columnHeader3 = New System.Windows.Forms.ColumnHeader()
            Me.Address = New System.Windows.Forms.ColumnHeader()
            Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader()
            Me.txtMessage = New System.Windows.Forms.RichTextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
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
            Dim size As System.Drawing.Size = New System.Drawing.Size(1004, 29)
            label2.Size = size
            Me.Label1.TabIndex = 1
            Me.Label1.Text = "Broadcasting Message To Customers"
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
            Me.btnSendSMS.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnSendSMS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnSendSMS.Image = CType(componentResourceManager.GetObject("btnSendSMS.Image"), System.Drawing.Image)
            Me.btnSendSMS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button3 As System.Windows.Forms.Button = Me.btnSendSMS
            location = New System.Drawing.Point(656, 489)
            button3.Location = location
            Me.btnSendSMS.Name = "btnSendSMS"
            Dim button4 As System.Windows.Forms.Button = Me.btnSendSMS
            size = New System.Drawing.Size(121, 45)
            button4.Size = size
            Me.btnSendSMS.TabIndex = 0
            Me.btnSendSMS.Text = "Send SMS"
            Me.btnSendSMS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnSendSMS.UseVisualStyleBackColor = True
            Me.listView1.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left
            Me.listView1.CheckBoxes = True
            Me.listView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader(2) {Me.columnHeader3, Me.Address, Me.ColumnHeader2})
            Me.listView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.listView1.GridLines = True
            Dim listView As System.Windows.Forms.ListView = Me.listView1
            location = New System.Drawing.Point(13, 110)
            listView.Location = location
            Me.listView1.Name = "listView1"
            Dim listView2 As System.Windows.Forms.ListView = Me.listView1
            size = New System.Drawing.Size(637, 557)
            listView2.Size = size
            Me.listView1.TabIndex = 66
            Me.listView1.UseCompatibleStateImageBehavior = False
            Me.listView1.View = System.Windows.Forms.View.Details
            Me.columnHeader3.Text = "Customer Name"
            Me.columnHeader3.Width = 200
            Me.Address.Text = "Address"
            Me.Address.Width = 300
            Me.ColumnHeader2.Text = "Contact No."
            Me.ColumnHeader2.Width = 132
            Me.txtMessage.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Dim richTextBox As System.Windows.Forms.RichTextBox = Me.txtMessage
            location = New System.Drawing.Point(656, 110)
            richTextBox.Location = location
            Me.txtMessage.Name = "txtMessage"
            Me.txtMessage.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
            Dim richTextBox2 As System.Windows.Forms.RichTextBox = Me.txtMessage
            size = New System.Drawing.Size(338, 373)
            richTextBox2.Size = size
            Me.txtMessage.TabIndex = 67
            Me.txtMessage.Text = ""
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim label3 As System.Windows.Forms.Label = Me.Label2
            location = New System.Drawing.Point(656, 90)
            label3.Location = location
            Me.Label2.Name = "Label2"
            Dim label4 As System.Windows.Forms.Label = Me.Label2
            size = New System.Drawing.Size(59, 15)
            label4.Size = size
            Me.Label2.TabIndex = 68
            Me.Label2.Text = "Message :"
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
            size = New System.Drawing.Size(1002, 671)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.Label2)
            MyBase.Controls.Add(Me.txtMessage)
            MyBase.Controls.Add(Me.btnSendSMS)
            MyBase.Controls.Add(Me.listView1)
            MyBase.Controls.Add(Me.Panel3)
            MyBase.Controls.Add(Me.Label1)
            Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MinimizeBox = False
            MyBase.Name = "frmSendBroadcastSMS"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Send SMS"
            Me.Panel3.ResumeLayout(False)
            MyBase.ResumeLayout(False)
            MyBase.PerformLayout()
        End Sub
    End Class
End Namespace
