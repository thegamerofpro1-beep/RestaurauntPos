Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports MetroFramework.Controls
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports RestaurantPOS14.My

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public Class frmSplash
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Timer1")>
        Private _Timer1 As System.Windows.Forms.Timer

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("TextBox1")>
        Private _TextBox1 As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtActivationID")>
        Private _txtActivationID As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtHardwareID")>
        Private _txtHardwareID As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Timer2")>
        Private _Timer2 As System.Windows.Forms.Timer

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel1")>
        Private _Panel1 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label3")>
        Private _Label3 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("ProgressBar1")>
        Private _ProgressBar1 As MetroFramework.Controls.MetroProgressSpinner

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label2")>
        Private _Label2 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label1")>
        Private _Label1 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("PictureBox1")>
        Private _PictureBox1 As System.Windows.Forms.PictureBox

        Private components As System.ComponentModel.IContainer

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

        Friend Overridable Property TextBox1 As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._TextBox1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._TextBox1 = value
            End Set
        End Property

        Friend Overridable Property txtActivationID As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtActivationID
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtActivationID = value
            End Set
        End Property

        Friend Overridable Property txtHardwareID As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtHardwareID
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtHardwareID = value
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

        Friend Overridable Property ProgressBar1 As MetroFramework.Controls.MetroProgressSpinner
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._ProgressBar1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As MetroFramework.Controls.MetroProgressSpinner)
                Me._ProgressBar1 = value
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

        Friend Overridable Property PictureBox1 As System.Windows.Forms.PictureBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._PictureBox1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.PictureBox)
                Me._PictureBox1 = value
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            Call RestaurantPOS14.frmSplash.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmSplash.__ENCList
                If RestaurantPOS14.frmSplash.__ENCList.Count = RestaurantPOS14.frmSplash.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmSplash.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmSplash.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmSplash.__ENCList(num) = RestaurantPOS14.frmSplash.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmSplash.__ENCList.RemoveRange(num, RestaurantPOS14.frmSplash.__ENCList.Count - num)
                    RestaurantPOS14.frmSplash.__ENCList.Capacity = RestaurantPOS14.frmSplash.__ENCList.Count
                End If

                Call RestaurantPOS14.frmSplash.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Private Sub Timer2_Tick(sender As Object, e As System.EventArgs)
            Try
                Me.Label3.Visible = Not Me.Label3.Visible
                If RestaurantPOS14.Configuration.DatabaseConnectionSettings.HasConfiguredConnection() Then
                    Me.ProgressBar1.Value += 2
                    If Me.ProgressBar1.Value = 10 Then
                        Me.Label3.Text = "Loading..."
                    ElseIf Me.ProgressBar1.Value = 20 Then
                        Me.Label3.Text = "Loading..."
                    ElseIf Me.ProgressBar1.Value = 40 Then
                        Me.Label3.Text = "Loading..."
                    ElseIf Me.ProgressBar1.Value = 60 Then
                        Me.Label3.Text = "Loading..."
                    ElseIf Me.ProgressBar1.Value = 80 Then
                        Me.Label3.Text = "Loading..."
                    ElseIf Me.ProgressBar1.Value = 100 Then
                        Me.Timer2.Enabled = False
                        MyBase.Hide()
                        Call RestaurantPOS14.My.MyProject.Forms.frmLogin.Show()
                    End If

                    Return
                End If

                Me.ProgressBar1.Value += 2
                If Me.ProgressBar1.Value = 10 Then
                    Me.Label3.Text = "Loading..."
                ElseIf Me.ProgressBar1.Value = 20 Then
                    Me.Label3.Text = "Loading..."
                ElseIf Me.ProgressBar1.Value = 40 Then
                    Me.Label3.Text = "Loading..."
                ElseIf Me.ProgressBar1.Value = 60 Then
                    Me.Label3.Text = "Loading..."
                ElseIf Me.ProgressBar1.Value = 80 Then
                    Me.Label3.Text = "Loading..."
                ElseIf Me.ProgressBar1.Value = 100 Then
                    Me.Timer2.Enabled = False
                    MyBase.Hide()
                    Call RestaurantPOS14.My.MyProject.Forms.frmSqlServerSetting.Reset()
                    Call RestaurantPOS14.My.MyProject.Forms.frmSqlServerSetting.Show()
                End If
            Catch ex As System.Exception
                Call Microsoft.VisualBasic.Interaction.MsgBox(ex.Message, Microsoft.VisualBasic.MsgBoxStyle.Critical, "Error!")
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmSplash))
            Me.TextBox1 = New System.Windows.Forms.TextBox()
            Me.txtActivationID = New System.Windows.Forms.TextBox()
            Me.txtHardwareID = New System.Windows.Forms.TextBox()
            Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.ProgressBar1 = New MetroFramework.Controls.MetroProgressSpinner()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            MyBase.SuspendLayout()
            Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox As System.Windows.Forms.TextBox = Me.TextBox1
            Dim location As System.Drawing.Point = New System.Drawing.Point(63, 12)
            textBox.Location = location
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.[ReadOnly] = True
            Dim textBox2 As System.Windows.Forms.TextBox = Me.TextBox1
            Dim size As System.Drawing.Size = New System.Drawing.Size(24, 22)
            textBox2.Size = size
            Me.TextBox1.TabIndex = 12
            Me.TextBox1.Visible = False
            Me.txtActivationID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtActivationID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox3 As System.Windows.Forms.TextBox = Me.txtActivationID
            location = New System.Drawing.Point(0, 27)
            textBox3.Location = location
            Me.txtActivationID.Name = "txtActivationID"
            Dim textBox4 As System.Windows.Forms.TextBox = Me.txtActivationID
            size = New System.Drawing.Size(24, 22)
            textBox4.Size = size
            Me.txtActivationID.TabIndex = 11
            Me.txtActivationID.Visible = False
            Me.txtHardwareID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox5 As System.Windows.Forms.TextBox = Me.txtHardwareID
            location = New System.Drawing.Point(30, 12)
            textBox5.Location = location
            Me.txtHardwareID.Name = "txtHardwareID"
            Me.txtHardwareID.[ReadOnly] = True
            Dim textBox6 As System.Windows.Forms.TextBox = Me.txtHardwareID
            size = New System.Drawing.Size(10, 22)
            textBox6.Size = size
            Me.txtHardwareID.TabIndex = 10
            Me.txtHardwareID.Visible = False
            Me.Timer2.Enabled = True
            Dim panel As System.Windows.Forms.Panel = Me.Panel1
            location = New System.Drawing.Point(30, 37)
            panel.Location = location
            Me.Panel1.Name = "Panel1"
            Dim panel2 As System.Windows.Forms.Panel = Me.Panel1
            size = New System.Drawing.Size(27, 26)
            panel2.Size = size
            Me.Panel1.TabIndex = 14
            Me.Panel1.Visible = False
            Me.Label3.BackColor = System.Drawing.Color.Transparent
            Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label3.ForeColor = System.Drawing.Color.White
            Dim label As System.Windows.Forms.Label = Me.Label3
            location = New System.Drawing.Point(7, 282)
            label.Location = location
            Me.Label3.Name = "Label3"
            Dim label2 As System.Windows.Forms.Label = Me.Label3
            size = New System.Drawing.Size(144, 25)
            label2.Size = size
            Me.Label3.TabIndex = 5
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Dim progressBar As MetroFramework.Controls.MetroProgressSpinner = Me.ProgressBar1
            location = New System.Drawing.Point(47, 103)
            progressBar.Location = location
            Me.ProgressBar1.Maximum = 100
            Me.ProgressBar1.Name = "ProgressBar1"
            Dim progressBar2 As MetroFramework.Controls.MetroProgressSpinner = Me.ProgressBar1
            size = New System.Drawing.Size(10, 22)
            progressBar2.Size = size
            Me.ProgressBar1.TabIndex = 15
            Me.ProgressBar1.UseSelectable = True
            Me.ProgressBar1.Visible = False
            Me.Label2.BackColor = System.Drawing.Color.DarkGoldenrod
            Me.Label2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label2.ForeColor = System.Drawing.Color.White
            Dim label3 As System.Windows.Forms.Label = Me.Label2
            location = New System.Drawing.Point(0, 316)
            label3.Location = location
            Me.Label2.Name = "Label2"
            Dim label4 As System.Windows.Forms.Label = Me.Label2
            size = New System.Drawing.Size(613, 20)
            label4.Size = size
            Me.Label2.TabIndex = 26
            Me.Label2.Text = "Restaurant POS 14 Premium Edition"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label1.ForeColor = System.Drawing.Color.Gold
            Dim label5 As System.Windows.Forms.Label = Me.Label1
            location = New System.Drawing.Point(382, 222)
            label5.Location = location
            Me.Label1.Name = "Label1"
            Dim label6 As System.Windows.Forms.Label = Me.Label1
            size = New System.Drawing.Size(226, 85)
            label6.Size = size
            Me.Label1.TabIndex = 27
            Me.Label1.Text = "POINT OF SALE SYSTEM"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
            Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
            Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
            Me.PictureBox1.Image = CType(componentResourceManager.GetObject("PictureBox1.Image"), System.Drawing.Image)
            Dim pictureBox As System.Windows.Forms.PictureBox = Me.PictureBox1
            location = New System.Drawing.Point(512, 1)
            pictureBox.Location = location
            Me.PictureBox1.Name = "PictureBox1"
            Dim pictureBox2 As System.Windows.Forms.PictureBox = Me.PictureBox1
            size = New System.Drawing.Size(101, 104)
            pictureBox2.Size = size
            Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.PictureBox1.TabIndex = 28
            Me.PictureBox1.TabStop = False
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.BackgroundImage = CType(componentResourceManager.GetObject("$this.BackgroundImage"), System.Drawing.Image)
            Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            size = New System.Drawing.Size(613, 336)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.PictureBox1)
            MyBase.Controls.Add(Me.Label1)
            MyBase.Controls.Add(Me.Label2)
            MyBase.Controls.Add(Me.ProgressBar1)
            MyBase.Controls.Add(Me.Label3)
            MyBase.Controls.Add(Me.Panel1)
            MyBase.Controls.Add(Me.TextBox1)
            MyBase.Controls.Add(Me.txtActivationID)
            MyBase.Controls.Add(Me.txtHardwareID)
            Me.DoubleBuffered = True
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            MyBase.Name = "frmSplash"
            MyBase.ShowIcon = False
            MyBase.ShowInTaskbar = False
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Form1"
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            MyBase.ResumeLayout(False)
            MyBase.PerformLayout()
        End Sub
    End Class
End Namespace
