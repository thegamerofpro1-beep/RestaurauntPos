Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.SqlServer.Management.Common
Imports Microsoft.SqlServer.Management.Smo
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public Class frmExecuteQuery
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnExecuteQuery")>
        Private _btnExecuteQuery As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label3")>
        Private _Label3 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtFilePath")>
        Private _txtFilePath As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnBrowse")>
        Private _btnBrowse As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("OpenFileDialog1")>
        Private _OpenFileDialog1 As System.Windows.Forms.OpenFileDialog

        Private st As String

        Private components As System.ComponentModel.IContainer

        Friend Overridable Property btnExecuteQuery As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnExecuteQuery
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.Button1_Click
                If Me._btnExecuteQuery IsNot Nothing Then
                    RemoveHandler Me._btnExecuteQuery.Click, value2
                End If

                Me._btnExecuteQuery = value
                If Me._btnExecuteQuery IsNot Nothing Then
                    AddHandler Me._btnExecuteQuery.Click, value2
                End If
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
            AddHandler MyBase.Load, AddressOf Me.frmExecuteQuery_Load
            Call RestaurantPOS14.frmExecuteQuery.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmExecuteQuery.__ENCList
                If RestaurantPOS14.frmExecuteQuery.__ENCList.Count = RestaurantPOS14.frmExecuteQuery.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmExecuteQuery.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmExecuteQuery.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmExecuteQuery.__ENCList(num) = RestaurantPOS14.frmExecuteQuery.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmExecuteQuery.__ENCList.RemoveRange(num, RestaurantPOS14.frmExecuteQuery.__ENCList.Count - num)
                    RestaurantPOS14.frmExecuteQuery.__ENCList.Capacity = RestaurantPOS14.frmExecuteQuery.__ENCList.Count
                End If

                Call RestaurantPOS14.frmExecuteQuery.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Private Sub Button1_Click(sender As Object, e As System.EventArgs)
            Try
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtFilePath.Text, "", TextCompare:=False) = 0 Then
                    Call System.Windows.Forms.MessageBox.Show("Please browse file path", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Me.txtFilePath.Focus()
                    Return
                End If

                Using streamReader As System.IO.StreamReader = New System.IO.StreamReader(Me.txtFilePath.Text)
                    Me.st = streamReader.ReadToEnd()
                    Call New Microsoft.SqlServer.Management.Smo.Server(CType((New Microsoft.SqlServer.Management.Common.ServerConnection(CType((RestaurantPOS14.ModClasses.con), System.Data.SqlClient.SqlConnection))), Microsoft.SqlServer.Management.Common.ServerConnection)).ConnectionContext.ExecuteNonQuery(Me.st)
                End Using

                Call System.Windows.Forms.MessageBox.Show("Successfully executed", "Query", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnBrowse_Click(sender As Object, e As System.EventArgs)
            Try
                Dim openFileDialog As System.Windows.Forms.OpenFileDialog = Me.OpenFileDialog1
                openFileDialog.Filter = "SQL Files |*.sql;"
                openFileDialog.FilterIndex = 4
                Me.OpenFileDialog1.FileName = ""
                If Me.OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                    Me.txtFilePath.Text = Me.OpenFileDialog1.FileName
                End If
            Catch ex As System.Exception
                Call Microsoft.VisualBasic.Interaction.MsgBox(ex.ToString())
            End Try
        End Sub

        Private Sub frmExecuteQuery_Load(sender As Object, e As System.EventArgs)
            Me.txtFilePath.Text = ""
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmExecuteQuery))
            Me.btnExecuteQuery = New System.Windows.Forms.Button()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtFilePath = New System.Windows.Forms.TextBox()
            Me.btnBrowse = New System.Windows.Forms.Button()
            Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
            MyBase.SuspendLayout()
            Me.btnExecuteQuery.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim button As System.Windows.Forms.Button = Me.btnExecuteQuery
            Dim location As System.Drawing.Point = New System.Drawing.Point(71, 47)
            button.Location = location
            Me.btnExecuteQuery.Name = "btnExecuteQuery"
            Dim button2 As System.Windows.Forms.Button = Me.btnExecuteQuery
            Dim size As System.Drawing.Size = New System.Drawing.Size(185, 79)
            button2.Size = size
            Me.btnExecuteQuery.TabIndex = 0
            Me.btnExecuteQuery.Text = "Execute Query"
            Me.btnExecuteQuery.UseVisualStyleBackColor = True
            Me.Label3.AutoSize = True
            Dim label As System.Windows.Forms.Label = Me.Label3
            location = New System.Drawing.Point(11, 16)
            label.Location = location
            Me.Label3.Name = "Label3"
            Dim label2 As System.Windows.Forms.Label = Me.Label3
            size = New System.Drawing.Size(54, 13)
            label2.Size = size
            Me.Label3.TabIndex = 2
            Me.Label3.Text = "File Path :"
            Me.txtFilePath.BackColor = System.Drawing.SystemColors.Control
            Me.txtFilePath.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox As System.Windows.Forms.TextBox = Me.txtFilePath
            location = New System.Drawing.Point(71, 16)
            textBox.Location = location
            Me.txtFilePath.Name = "txtFilePath"
            Me.txtFilePath.[ReadOnly] = True
            Dim textBox2 As System.Windows.Forms.TextBox = Me.txtFilePath
            size = New System.Drawing.Size(233, 21)
            textBox2.Size = size
            Me.txtFilePath.TabIndex = 1
            Dim button3 As System.Windows.Forms.Button = Me.btnBrowse
            location = New System.Drawing.Point(309, 15)
            button3.Location = location
            Me.btnBrowse.Name = "btnBrowse"
            Dim button4 As System.Windows.Forms.Button = Me.btnBrowse
            size = New System.Drawing.Size(30, 23)
            button4.Size = size
            Me.btnBrowse.TabIndex = 3
            Me.btnBrowse.Text = "..."
            Me.btnBrowse.UseVisualStyleBackColor = True
            Me.OpenFileDialog1.FileName = "OpenFileDialog1"
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            size = New System.Drawing.Size(353, 137)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.btnBrowse)
            MyBase.Controls.Add(Me.Label3)
            MyBase.Controls.Add(Me.txtFilePath)
            MyBase.Controls.Add(Me.btnExecuteQuery)
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MaximizeBox = False
            MyBase.MinimizeBox = False
            MyBase.Name = "frmExecuteQuery"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Execute Query"
            MyBase.ResumeLayout(False)
            MyBase.PerformLayout()
        End Sub
    End Class
End Namespace
