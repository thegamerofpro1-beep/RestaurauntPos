Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports MetroFramework
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.Win32

Namespace RestaurantPOS14
    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public Class frmCustomDialog8X
        Inherits System.Windows.Forms.Form
        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label2")>
        Private _Label2 As System.Windows.Forms.Label
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnOK")>
        Private _btnOK As System.Windows.Forms.Button
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel1")>
        Private _Panel1 As System.Windows.Forms.Panel
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnCancel")>
        Private _btnCancel As System.Windows.Forms.Button
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Timer2")>
        Private _Timer2 As System.Windows.Forms.Timer
        Private Filename As String
        Private components As System.ComponentModel.IContainer
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

        Friend Overridable Property btnOK As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnOK
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnOK_Click
                If Me._btnOK IsNot Nothing Then
                    RemoveHandler Me._btnOK.Click, value2
                End If

                Me._btnOK = value
                If Me._btnOK IsNot Nothing Then
                    AddHandler Me._btnOK.Click, value2
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
            Call RestaurantPOS14.frmCustomDialog8X.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmCustomDialog8X.__ENCList
                If RestaurantPOS14.frmCustomDialog8X.__ENCList.Count = RestaurantPOS14.frmCustomDialog8X.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmCustomDialog8X.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmCustomDialog8X.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmCustomDialog8X.__ENCList(num) = RestaurantPOS14.frmCustomDialog8X.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmCustomDialog8X.__ENCList.RemoveRange(num, RestaurantPOS14.frmCustomDialog8X.__ENCList.Count - num)
                    RestaurantPOS14.frmCustomDialog8X.__ENCList.Capacity = RestaurantPOS14.frmCustomDialog8X.__ENCList.Count
                End If

                Call RestaurantPOS14.frmCustomDialog8X.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Protected Overrides Sub OnShown(e As System.EventArgs)
            MyBase.OnShown(e)
            MyBase.Opacity = 0.0
            Me.PerformAutomaticBackup()
        End Sub

        Private Sub PerformAutomaticBackup()
            Try
                Dim text As String = RestaurantPOS14.Customization.ApplicationPathResolver.GetBackupDirectory()

                Using folderBrowserDialog As System.Windows.Forms.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
                    folderBrowserDialog.Description = "Select backup folder"
                    folderBrowserDialog.ShowNewFolderButton = True
                    folderBrowserDialog.SelectedPath = text
                    Dim text2 As String = (If((folderBrowserDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK AndAlso Not String.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath)), folderBrowserDialog.SelectedPath, text))
                    Call System.IO.Directory.CreateDirectory(text2)
                    Dim path As String = RestaurantPOS14.Configuration.DatabaseMaintenance.BuildBackupFileName()
                    Me.Filename = System.IO.Path.Combine(text2, path)
                    RestaurantPOS14.Customization.ApplicationPathResolver.RememberBackupDirectory(text2)
                End Using

                MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Me.Timer2.Enabled = True
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = RestaurantPOS14.Configuration.DatabaseMaintenance.CreateBackupCommand(RestaurantPOS14.ModClasses.con, Me.Filename)
                RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.Diagnostics.ApplicationLifecycle.ExitApplication()
            Catch ex As System.Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.NoInlining Or System.Runtime.CompilerServices.MethodImplOptions.NoOptimization)>
        Private Sub btnOK_Click(sender As Object, e As System.EventArgs)
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

                Catch suppressedException As System.Exception
                    RestaurantPOS14.Diagnostics.ApplicationDiagnostics.ReportNonFatal("Suppressed exception in frmCustomDialog8X", suppressedException)
                End Try

                MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Me.Timer2.Enabled = True
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = RestaurantPOS14.Configuration.DatabaseMaintenance.CreateBackupCommand(RestaurantPOS14.ModClasses.con, Me.Filename)
                RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.Diagnostics.ApplicationLifecycle.ExitApplication()
            Catch ex As System.Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.NoInlining Or System.Runtime.CompilerServices.MethodImplOptions.NoOptimization)>
        Private Sub btnCancel_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.Diagnostics.ApplicationLifecycle.ExitApplication()
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
            Me.Label2 = New System.Windows.Forms.Label()
            Me.btnOK = New System.Windows.Forms.Button()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
            Me.Panel1.SuspendLayout()
            MyBase.SuspendLayout()
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label2.ForeColor = System.Drawing.Color.White
            Dim label As System.Windows.Forms.Label = Me.Label2
            Dim location As System.Drawing.Point = New System.Drawing.Point(31, 33)
            label.Location = location
            Me.Label2.Name = "Label2"
            Dim label2 As System.Windows.Forms.Label = Me.Label2
            Dim size As System.Drawing.Size = New System.Drawing.Size(447, 80)
            label2.Size = size
            Me.Label2.TabIndex = 31
            Me.Label2.Text = "Do you want to backup database" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "before closing the application ?"
            Me.btnOK.BackColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.btnOK.FlatAppearance.BorderSize = 0
            Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnOK.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnOK.ForeColor = System.Drawing.Color.White
            Dim button As System.Windows.Forms.Button = Me.btnOK
            location = New System.Drawing.Point(129, 166)
            button.Location = location
            Me.btnOK.Name = "btnOK"
            Dim button2 As System.Windows.Forms.Button = Me.btnOK
            size = New System.Drawing.Size(124, 62)
            button2.Size = size
            Me.btnOK.TabIndex = 32
            Me.btnOK.Text = "Yes"
            Me.btnOK.UseVisualStyleBackColor = False
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.btnCancel)
            Me.Panel1.Controls.Add(Me.Label2)
            Me.Panel1.Controls.Add(Me.btnOK)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Dim panel As System.Windows.Forms.Panel = Me.Panel1
            location = New System.Drawing.Point(0, 0)
            panel.Location = location
            Me.Panel1.Name = "Panel1"
            Dim panel2 As System.Windows.Forms.Panel = Me.Panel1
            size = New System.Drawing.Size(507, 261)
            panel2.Size = size
            Me.Panel1.TabIndex = 33
            Me.btnCancel.BackColor = System.Drawing.Color.Crimson
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.FlatAppearance.BorderSize = 0
            Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnCancel.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnCancel.ForeColor = System.Drawing.Color.White
            Dim button3 As System.Windows.Forms.Button = Me.btnCancel
            location = New System.Drawing.Point(262, 166)
            button3.Location = location
            Me.btnCancel.Name = "btnCancel"
            Dim button4 As System.Windows.Forms.Button = Me.btnCancel
            size = New System.Drawing.Size(128, 62)
            button4.Size = size
            Me.btnCancel.TabIndex = 33
            Me.btnCancel.Text = "No"
            Me.btnCancel.UseVisualStyleBackColor = False
            MyBase.AcceptButton = Me.btnOK
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            MyBase.CancelButton = Me.btnCancel
            size = New System.Drawing.Size(507, 261)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.Panel1)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            MyBase.Name = "frmCustomDialog8X"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            MyBase.ResumeLayout(False)
        End Sub
    End Class
End Namespace
