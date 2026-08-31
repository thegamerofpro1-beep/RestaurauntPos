Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Text
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports CButtonLib
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.Win32

Namespace RestaurantPOS14
    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public Class frmDatabase
        Inherits System.Windows.Forms.Form
        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblUser")>
        Private _lblUser As System.Windows.Forms.Label
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnDBBackup")>
        Private _btnDBBackup As CButtonLib.CButton
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnDBRestore")>
        Private _btnDBRestore As CButtonLib.CButton
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("OpenFileDialog1")>
        Private _OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Timer2")>
        Private _Timer2 As System.Windows.Forms.Timer
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnClose")>
        Private _btnClose As System.Windows.Forms.Button
        Private Filename As String
        Private components As System.ComponentModel.IContainer
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

        Friend Overridable Property btnDBBackup As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnDBBackup
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnDBBackup_Click
                If Me._btnDBBackup IsNot Nothing Then
                    RemoveHandler Me._btnDBBackup.Click, value2
                End If

                Me._btnDBBackup = value
                If Me._btnDBBackup IsNot Nothing Then
                    AddHandler Me._btnDBBackup.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnDBRestore As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnDBRestore
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnDBRestore_Click
                If Me._btnDBRestore IsNot Nothing Then
                    RemoveHandler Me._btnDBRestore.Click, value2
                End If

                Me._btnDBRestore = value
                If Me._btnDBRestore IsNot Nothing Then
                    AddHandler Me._btnDBRestore.Click, value2
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

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            Call RestaurantPOS14.frmDatabase.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmDatabase.__ENCList
                If RestaurantPOS14.frmDatabase.__ENCList.Count = RestaurantPOS14.frmDatabase.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmDatabase.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmDatabase.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmDatabase.__ENCList(num) = RestaurantPOS14.frmDatabase.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmDatabase.__ENCList.RemoveRange(num, RestaurantPOS14.frmDatabase.__ENCList.Count - num)
                    RestaurantPOS14.frmDatabase.__ENCList.Capacity = RestaurantPOS14.frmDatabase.__ENCList.Count
                End If

                Call RestaurantPOS14.frmDatabase.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Public Sub Backup()
            Try
                Dim fileName As String = RestaurantPOS14.Configuration.DatabaseMaintenance.BuildBackupFileName()
                Dim saveFileDialog As System.Windows.Forms.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
                saveFileDialog.FileName = fileName
                saveFileDialog.InitialDirectory = RestaurantPOS14.Customization.ApplicationPathResolver.GetBackupDirectory()

                saveFileDialog.ShowDialog()
                Me.Filename = saveFileDialog.FileName
                Try
                    If Not String.IsNullOrWhiteSpace(Me.Filename) Then
                        Dim dir As String = System.IO.Path.GetDirectoryName(Me.Filename)
                        If Not String.IsNullOrWhiteSpace(dir) Then
                            RestaurantPOS14.Customization.ApplicationPathResolver.RememberBackupDirectory(dir)
                        End If
                    End If

                Catch
                End Try

                MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Me.Timer2.Enabled = True
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = RestaurantPOS14.Configuration.DatabaseMaintenance.CreateBackupCommand(RestaurantPOS14.ModClasses.con, Me.Filename)
                RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnDBRestore_Click(sender As Object, e As System.EventArgs)
            Try
                Dim openFileDialog As System.Windows.Forms.OpenFileDialog = Me.OpenFileDialog1
                openFileDialog.Filter = "DB Backup File|*.bak;"
                openFileDialog.FilterIndex = 4
                Me.OpenFileDialog1.FileName = ""
                If Me.OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                    MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                    Me.Timer2.Enabled = True
                    Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    RestaurantPOS14.ModClasses.cmd = RestaurantPOS14.Configuration.DatabaseMaintenance.CreateRestoreCommand(RestaurantPOS14.ModClasses.con, Me.OpenFileDialog1.FileName)
                    RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                    RestaurantPOS14.ModClasses.con.Close()
                    Dim st As String = "Sucessfully performed the restore"
                    RestaurantPOS14.ModFunc.LogFunc(Me.lblUser.Text, st)
                    Call System.Windows.Forms.MessageBox.Show("Successfully performed", "Database Restore", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                End If
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub Timer2_Tick(sender As Object, e As System.EventArgs)
            MyBase.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.Timer2.Enabled = False
        End Sub

        Private Sub btnDBBackup_Click(sender As Object, e As System.EventArgs)
            Me.Backup()
        End Sub

        Private Sub btnClose_Click(sender As Object, e As System.EventArgs)
            MyBase.Close()
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmDatabase))
            Me.lblUser = New System.Windows.Forms.Label()
            Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
            Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
            Me.btnDBRestore = New CButtonLib.CButton()
            Me.btnDBBackup = New CButtonLib.CButton()
            Me.btnClose = New System.Windows.Forms.Button()
            MyBase.SuspendLayout()
            Me.lblUser.AutoSize = True
            Me.lblUser.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.lblUser.ForeColor = System.Drawing.Color.Black
            Dim label As System.Windows.Forms.Label = Me.lblUser
            Dim location As System.Drawing.Point = New System.Drawing.Point(12, 4)
            label.Location = location
            Me.lblUser.Name = "lblUser"
            Dim label2 As System.Windows.Forms.Label = Me.lblUser
            Dim size As System.Drawing.Size = New System.Drawing.Size(43, 13)
            label2.Size = size
            Me.lblUser.TabIndex = 321
            Me.lblUser.Text = "lblUser"
            Me.lblUser.Visible = False
            Me.OpenFileDialog1.FileName = "OpenFileDialog1"
            Me.btnDBRestore.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.btnDBRestore.BackColor = System.Drawing.Color.Transparent
            Me.btnDBRestore.BorderShow = False
            cBlendItems.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnDBRestore.ColorFillBlend = cBlendItems
            Me.btnDBRestore.Corners.All = 3
            Me.btnDBRestore.Corners.LowerLeft = 3
            Me.btnDBRestore.Corners.LowerRight = 3
            Me.btnDBRestore.Corners.UpperLeft = 3
            Me.btnDBRestore.Corners.UpperRight = 3
            Me.btnDBRestore.DesignerSelected = False
            Me.btnDBRestore.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnDBRestore.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnDBRestore.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnDBRestore.ImageIndex = 0
            Dim cButton As CButtonLib.CButton = Me.btnDBRestore
            location = New System.Drawing.Point(238, 36)
            cButton.Location = location
            Me.btnDBRestore.Name = "btnDBRestore"
            Dim cButton2 As CButtonLib.CButton = Me.btnDBRestore
            size = New System.Drawing.Size(217, 96)
            cButton2.Size = size
            Me.btnDBRestore.TabIndex = 324
            Me.btnDBRestore.Text = "DB Restore"
            Me.btnDBRestore.TextShadowShow = False
            Me.btnDBRestore.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.btnDBBackup.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.btnDBBackup.BackColor = System.Drawing.Color.Transparent
            Me.btnDBBackup.BorderShow = False
            cBlendItems2.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems2.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnDBBackup.ColorFillBlend = cBlendItems2
            Me.btnDBBackup.Corners.All = 3
            Me.btnDBBackup.Corners.LowerLeft = 3
            Me.btnDBBackup.Corners.LowerRight = 3
            Me.btnDBBackup.Corners.UpperLeft = 3
            Me.btnDBBackup.Corners.UpperRight = 3
            Me.btnDBBackup.DesignerSelected = False
            Me.btnDBBackup.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnDBBackup.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnDBBackup.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnDBBackup.ImageIndex = 0
            Dim cButton3 As CButtonLib.CButton = Me.btnDBBackup
            location = New System.Drawing.Point(15, 36)
            cButton3.Location = location
            Me.btnDBBackup.Name = "btnDBBackup"
            Dim cButton4 As CButtonLib.CButton = Me.btnDBBackup
            size = New System.Drawing.Size(217, 96)
            cButton4.Size = size
            Me.btnDBBackup.TabIndex = 323
            Me.btnDBBackup.Text = "DB Backup"
            Me.btnDBBackup.TextShadowShow = False
            Me.btnDBBackup.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.btnClose.BackColor = System.Drawing.Color.Transparent
            Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnClose.FlatAppearance.BorderSize = 0
            Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnClose.Image = CType(componentResourceManager.GetObject("btnClose.Image"), System.Drawing.Image)
            Dim button As System.Windows.Forms.Button = Me.btnClose
            location = New System.Drawing.Point(423, 0)
            button.Location = location
            Me.btnClose.Name = "btnClose"
            Dim button2 As System.Windows.Forms.Button = Me.btnClose
            size = New System.Drawing.Size(37, 36)
            button2.Size = size
            Me.btnClose.TabIndex = 342
            Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnClose.UseVisualStyleBackColor = False
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            size = New System.Drawing.Size(462, 144)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.btnClose)
            MyBase.Controls.Add(Me.btnDBRestore)
            MyBase.Controls.Add(Me.btnDBBackup)
            MyBase.Controls.Add(Me.lblUser)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            MyBase.Name = "frmDatabase"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "frmSettings"
            MyBase.ResumeLayout(False)
            MyBase.PerformLayout()
        End Sub
    End Class
End Namespace
