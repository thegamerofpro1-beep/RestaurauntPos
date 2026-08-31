Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices
Imports RestaurantPOS14.My
Imports Telerik.WinControls.Themes
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.VirtualKeyboard

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public Class frmNotes1
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtNotes")>
        Private _txtNotes As System.Windows.Forms.RichTextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnClose")>
        Private _btnClose As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnOkay")>
        Private _btnOkay As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnKeyboard")>
        Private _btnKeyboard As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblSet")>
        Private _lblSet As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnClear")>
        Private _btnClear As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("flpNotes")>
        Private _flpNotes As System.Windows.Forms.FlowLayoutPanel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("RadVirtualKeyboard1")>
        Private _RadVirtualKeyboard1 As Telerik.WinControls.UI.RadVirtualKeyboard

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("AquaTheme1")>
        Private _AquaTheme1 As Telerik.WinControls.Themes.AquaTheme

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("VisualStudio2012DarkTheme1")>
        Private _VisualStudio2012DarkTheme1 As Telerik.WinControls.Themes.VisualStudio2012DarkTheme

        Private UserButtons As System.Collections.Generic.List(Of System.Windows.Forms.Button)

        Private components As System.ComponentModel.IContainer

        Friend Overridable Property txtNotes As System.Windows.Forms.RichTextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtNotes
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.RichTextBox)
                Me._txtNotes = value
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

        Friend Overridable Property btnOkay As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnOkay
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnGetData_Click
                If Me._btnOkay IsNot Nothing Then
                    RemoveHandler Me._btnOkay.Click, value2
                End If

                Me._btnOkay = value
                If Me._btnOkay IsNot Nothing Then
                    AddHandler Me._btnOkay.Click, value2
                End If
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

        Friend Overridable Property btnClear As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnClear
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnClear_Click
                If Me._btnClear IsNot Nothing Then
                    RemoveHandler Me._btnClear.Click, value2
                End If

                Me._btnClear = value
                If Me._btnClear IsNot Nothing Then
                    AddHandler Me._btnClear.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property flpNotes As System.Windows.Forms.FlowLayoutPanel
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._flpNotes
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.FlowLayoutPanel)
                Me._flpNotes = value
            End Set
        End Property

        Friend Overridable Property RadVirtualKeyboard1 As Telerik.WinControls.UI.RadVirtualKeyboard
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._RadVirtualKeyboard1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As Telerik.WinControls.UI.RadVirtualKeyboard)
                Me._RadVirtualKeyboard1 = value
            End Set
        End Property

        Friend Overridable Property AquaTheme1 As Telerik.WinControls.Themes.AquaTheme
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._AquaTheme1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As Telerik.WinControls.Themes.AquaTheme)
                Me._AquaTheme1 = value
            End Set
        End Property

        Friend Overridable Property VisualStudio2012DarkTheme1 As Telerik.WinControls.Themes.VisualStudio2012DarkTheme
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._VisualStudio2012DarkTheme1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As Telerik.WinControls.Themes.VisualStudio2012DarkTheme)
                Me._VisualStudio2012DarkTheme1 = value
            End Set
        End Property

        Public Sub New()
            AddHandler MyBase.Load, AddressOf Me.frmNotes_Load
            AddHandler MyBase.Shown, AddressOf Me.frmNotes1_Shown
            Call RestaurantPOS14.frmNotes1.__ENCAddToList(Me)
            Me.UserButtons = New System.Collections.Generic.List(Of System.Windows.Forms.Button)()
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmNotes1.__ENCList
                If RestaurantPOS14.frmNotes1.__ENCList.Count = RestaurantPOS14.frmNotes1.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmNotes1.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmNotes1.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmNotes1.__ENCList(num) = RestaurantPOS14.frmNotes1.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmNotes1.__ENCList.RemoveRange(num, RestaurantPOS14.frmNotes1.__ENCList.Count - num)
                    RestaurantPOS14.frmNotes1.__ENCList.Capacity = RestaurantPOS14.frmNotes1.__ENCList.Count
                End If

                Call RestaurantPOS14.frmNotes1.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Private Sub btnClose_Click(sender As Object, e As System.EventArgs)
            MyBase.Close()
        End Sub

        Public Sub Getdata()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT RTRIM(Notes) from NotesMaster order by Notes")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                Me.flpNotes.Controls.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Dim button As System.Windows.Forms.Button = New System.Windows.Forms.Button()
                    button.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                    button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
                    Dim backColor As System.Drawing.Color = System.Drawing.Color.FromArgb(102, 106, 105)
                    button.BackColor = backColor
                    button.ForeColor = System.Drawing.Color.White
                    button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
                    button.Width = 150
                    button.Height = 60
                    button.Font = New System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
                    Me.UserButtons.Add(button)
                    Me.flpNotes.Controls.Add(button)
                    AddHandler button.Click, AddressOf Me.Button2_Click
                End While

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnGetData_Click(sender As Object, e As System.EventArgs)
            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "KOT", TextCompare:=False) = 0 Then
                MyBase.Hide()
                Call RestaurantPOS14.My.MyProject.Forms.frmPOS.Show()
                RestaurantPOS14.My.MyProject.Forms.frmPOS.txtNotes.Text = Me.txtNotes.Text
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "TA", TextCompare:=False) = 0 Then
                MyBase.Hide()
                Call RestaurantPOS14.My.MyProject.Forms.frmPOS.Show()
                RestaurantPOS14.My.MyProject.Forms.frmPOS.txtNotes.Text = Me.txtNotes.Text
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "HD", TextCompare:=False) = 0 Then
                MyBase.Hide()
                Call RestaurantPOS14.My.MyProject.Forms.frmPOS.Show()
                RestaurantPOS14.My.MyProject.Forms.frmPOS.txtNotes.Text = Me.txtNotes.Text
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "EB", TextCompare:=False) = 0 Then
                MyBase.Hide()
                Call RestaurantPOS14.My.MyProject.Forms.frmPOS.Show()
                RestaurantPOS14.My.MyProject.Forms.frmPOS.txtNotes.Text = Me.txtNotes.Text
            End If
        End Sub

        Public Sub Reset()
            Me.txtNotes.Text = ""
        End Sub

        Private Sub btnKeyboard_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.ModFunc.OSKeyboard()
        End Sub

        Private Sub Button2_Click(sender As Object, e As System.EventArgs)
            Try
                Dim str As String = CType(sender, System.Windows.Forms.Button).Text.Trim()
                Dim richTextBox As System.Windows.Forms.RichTextBox = Me.txtNotes
                richTextBox.Text = richTextBox.Text & str & Global.Microsoft.VisualBasic.Constants.vbCrLf
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub frmNotes_Load(sender As Object, e As System.EventArgs)
            Me.Getdata()
            Me.flpNotes.AutoScroll = False
            Me.flpNotes.HorizontalScroll.Maximum = 0
            Me.flpNotes.HorizontalScroll.Visible = False
            Me.flpNotes.VerticalScroll.Maximum = 0
            Me.flpNotes.VerticalScroll.Visible = False
            Me.flpNotes.AutoScroll = True
            Me.txtNotes.Focus()
        End Sub

        Private Sub btnClear_Click(sender As Object, e As System.EventArgs)
            Me.txtNotes.Text = ""
        End Sub

        Private Sub frmNotes1_Shown(sender As Object, e As System.EventArgs)
            Me.txtNotes.Focus()
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmNotes1))
            Me.txtNotes = New System.Windows.Forms.RichTextBox()
            Me.btnClose = New System.Windows.Forms.Button()
            Me.btnOkay = New System.Windows.Forms.Button()
            Me.btnKeyboard = New System.Windows.Forms.Button()
            Me.lblSet = New System.Windows.Forms.Label()
            Me.btnClear = New System.Windows.Forms.Button()
            Me.flpNotes = New System.Windows.Forms.FlowLayoutPanel()
            Me.RadVirtualKeyboard1 = New Telerik.WinControls.UI.RadVirtualKeyboard()
            Me.AquaTheme1 = New Telerik.WinControls.Themes.AquaTheme()
            Me.VisualStudio2012DarkTheme1 = New Telerik.WinControls.Themes.VisualStudio2012DarkTheme()
            CType(Me.RadVirtualKeyboard1, System.ComponentModel.ISupportInitialize).BeginInit()
            MyBase.SuspendLayout()
            Me.txtNotes.BackColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.txtNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.txtNotes.ForeColor = System.Drawing.Color.White
            Dim richTextBox As System.Windows.Forms.RichTextBox = Me.txtNotes
            Dim location As System.Drawing.Point = New System.Drawing.Point(3, 2)
            richTextBox.Location = location
            Me.txtNotes.Name = "txtNotes"
            Dim richTextBox2 As System.Windows.Forms.RichTextBox = Me.txtNotes
            Dim size As System.Drawing.Size = New System.Drawing.Size(190, 284)
            richTextBox2.Size = size
            Me.txtNotes.TabIndex = 0
            Me.txtNotes.Text = ""
            Me.btnClose.BackColor = System.Drawing.Color.Crimson
            Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Dim button As System.Windows.Forms.Button = Me.btnClose
            location = New System.Drawing.Point(197, 159)
            button.Location = location
            Me.btnClose.Name = "btnClose"
            Dim button2 As System.Windows.Forms.Button = Me.btnClose
            size = New System.Drawing.Size(116, 47)
            button2.Size = size
            Me.btnClose.TabIndex = 2
            Me.btnClose.Text = "Close"
            Me.btnClose.UseVisualStyleBackColor = False
            Me.btnOkay.BackColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.btnOkay.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnOkay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnOkay.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Dim button3 As System.Windows.Forms.Button = Me.btnOkay
            location = New System.Drawing.Point(197, 1)
            button3.Location = location
            Me.btnOkay.Name = "btnOkay"
            Dim button4 As System.Windows.Forms.Button = Me.btnOkay
            size = New System.Drawing.Size(116, 47)
            button4.Size = size
            Me.btnOkay.TabIndex = 1
            Me.btnOkay.Text = "&Okay"
            Me.btnOkay.UseVisualStyleBackColor = False
            Me.btnKeyboard.BackColor = System.Drawing.Color.Green
            Me.btnKeyboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnKeyboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnKeyboard.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Dim button5 As System.Windows.Forms.Button = Me.btnKeyboard
            location = New System.Drawing.Point(197, 53)
            button5.Location = location
            Me.btnKeyboard.Name = "btnKeyboard"
            Dim button6 As System.Windows.Forms.Button = Me.btnKeyboard
            size = New System.Drawing.Size(116, 47)
            button6.Size = size
            Me.btnKeyboard.TabIndex = 368
            Me.btnKeyboard.Text = "Keyboard"
            Me.btnKeyboard.UseVisualStyleBackColor = False
            Me.lblSet.AutoSize = True
            Dim label As System.Windows.Forms.Label = Me.lblSet
            location = New System.Drawing.Point(235, 242)
            label.Location = location
            Me.lblSet.Name = "lblSet"
            Dim label2 As System.Windows.Forms.Label = Me.lblSet
            size = New System.Drawing.Size(23, 13)
            label2.Size = size
            Me.lblSet.TabIndex = 369
            Me.lblSet.Text = "Set"
            Me.lblSet.Visible = False
            Me.btnClear.BackColor = System.Drawing.Color.Crimson
            Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Dim button7 As System.Windows.Forms.Button = Me.btnClear
            location = New System.Drawing.Point(197, 106)
            button7.Location = location
            Me.btnClear.Name = "btnClear"
            Dim button8 As System.Windows.Forms.Button = Me.btnClear
            size = New System.Drawing.Size(116, 47)
            button8.Size = size
            Me.btnClear.TabIndex = 372
            Me.btnClear.Text = "Clear"
            Me.btnClear.UseVisualStyleBackColor = False
            Me.flpNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Dim flowLayoutPanel As System.Windows.Forms.FlowLayoutPanel = Me.flpNotes
            location = New System.Drawing.Point(320, 1)
            flowLayoutPanel.Location = location
            Me.flpNotes.Name = "flpNotes"
            Dim flowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel = Me.flpNotes
            size = New System.Drawing.Size(488, 284)
            flowLayoutPanel2.Size = size
            Me.flpNotes.TabIndex = 373
            Me.RadVirtualKeyboard1.LayoutType = Telerik.WinControls.VirtualKeyboard.KeyboardLayoutType.Simplified
            Dim radVirtualKeyboard As Telerik.WinControls.UI.RadVirtualKeyboard = Me.RadVirtualKeyboard1
            location = New System.Drawing.Point(2, 291)
            radVirtualKeyboard.Location = location
            Me.RadVirtualKeyboard1.Name = "RadVirtualKeyboard1"
            Dim radVirtualKeyboard2 As Telerik.WinControls.UI.RadVirtualKeyboard = Me.RadVirtualKeyboard1
            size = New System.Drawing.Size(806, 384)
            radVirtualKeyboard2.Size = size
            Me.RadVirtualKeyboard1.TabIndex = 376
            Me.RadVirtualKeyboard1.TabStop = False
            Me.RadVirtualKeyboard1.ThemeName = "VisualStudio2012Dark"
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            size = New System.Drawing.Size(811, 678)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.RadVirtualKeyboard1)
            MyBase.Controls.Add(Me.flpNotes)
            MyBase.Controls.Add(Me.btnClear)
            MyBase.Controls.Add(Me.lblSet)
            MyBase.Controls.Add(Me.btnKeyboard)
            MyBase.Controls.Add(Me.btnClose)
            MyBase.Controls.Add(Me.btnOkay)
            MyBase.Controls.Add(Me.txtNotes)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MaximizeBox = False
            MyBase.MinimizeBox = False
            MyBase.Name = "frmNotes1"
            MyBase.ShowIcon = False
            MyBase.ShowInTaskbar = False
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Notes"
            CType(Me.RadVirtualKeyboard1, System.ComponentModel.ISupportInitialize).EndInit()
            MyBase.ResumeLayout(False)
            MyBase.PerformLayout()
        End Sub
    End Class
End Namespace
