Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices
Imports RestaurantPOS14.My

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public Class frmFrontOffice_Report
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblUser")>
        Private _lblUser As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnClose")>
        Private _btnClose As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnPOSReport")>
        Private _btnPOSReport As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnWorkPeriodReport")>
        Private _btnWorkPeriodReport As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("OpenFileDialog1")>
        Private _OpenFileDialog1 As System.Windows.Forms.OpenFileDialog

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Timer2")>
        Private _Timer2 As System.Windows.Forms.Timer

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblUserType")>
        Private _lblUserType As System.Windows.Forms.Label

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

        Friend Overridable Property btnPOSReport As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnPOSReport
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnPOSReport_Click
                If Me._btnPOSReport IsNot Nothing Then
                    RemoveHandler Me._btnPOSReport.Click, value2
                End If

                Me._btnPOSReport = value
                If Me._btnPOSReport IsNot Nothing Then
                    AddHandler Me._btnPOSReport.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnWorkPeriodReport As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnWorkPeriodReport
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnWorkPeriodReport_Click
                If Me._btnWorkPeriodReport IsNot Nothing Then
                    RemoveHandler Me._btnWorkPeriodReport.Click, value2
                End If

                Me._btnWorkPeriodReport = value
                If Me._btnWorkPeriodReport IsNot Nothing Then
                    AddHandler Me._btnWorkPeriodReport.Click, value2
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
                Me._Timer2 = value
            End Set
        End Property

        Friend Overridable Property lblUserType As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._lblUserType
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._lblUserType = value
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            Call RestaurantPOS14.frmFrontOffice_Report.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmFrontOffice_Report.__ENCList
                If RestaurantPOS14.frmFrontOffice_Report.__ENCList.Count = RestaurantPOS14.frmFrontOffice_Report.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmFrontOffice_Report.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmFrontOffice_Report.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmFrontOffice_Report.__ENCList(num) = RestaurantPOS14.frmFrontOffice_Report.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmFrontOffice_Report.__ENCList.RemoveRange(num, RestaurantPOS14.frmFrontOffice_Report.__ENCList.Count - num)
                    RestaurantPOS14.frmFrontOffice_Report.__ENCList.Capacity = RestaurantPOS14.frmFrontOffice_Report.__ENCList.Count
                End If

                Call RestaurantPOS14.frmFrontOffice_Report.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Private Sub btnClose_Click(sender As Object, e As System.EventArgs)
            MyBase.Close()
        End Sub

        Private Sub btnPOSReport_Click(sender As Object, e As System.EventArgs)
            Call RestaurantPOS14.My.MyProject.Forms.frmPOSReport.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmPOSReport.ShowDialog()
        End Sub

        Private Sub btnWorkPeriodReport_Click(sender As Object, e As System.EventArgs)
            Call RestaurantPOS14.My.MyProject.Forms.frmWorkPeriodReport.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmWorkPeriodReport.ShowDialog()
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmFrontOffice_Report))
            Me.lblUser = New System.Windows.Forms.Label()
            Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
            Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
            Me.btnWorkPeriodReport = New System.Windows.Forms.Button()
            Me.btnPOSReport = New System.Windows.Forms.Button()
            Me.btnClose = New System.Windows.Forms.Button()
            Me.lblUserType = New System.Windows.Forms.Label()
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
            Me.btnWorkPeriodReport.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.btnWorkPeriodReport.AutoSize = True
            Me.btnWorkPeriodReport.BackColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.btnWorkPeriodReport.FlatAppearance.BorderSize = 0
            Me.btnWorkPeriodReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnWorkPeriodReport.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnWorkPeriodReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnWorkPeriodReport.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Dim button As System.Windows.Forms.Button = Me.btnWorkPeriodReport
            location = New System.Drawing.Point(238, 36)
            button.Location = location
            Me.btnWorkPeriodReport.Name = "btnWorkPeriodReport"
            Dim button2 As System.Windows.Forms.Button = Me.btnWorkPeriodReport
            size = New System.Drawing.Size(217, 76)
            button2.Size = size
            Me.btnWorkPeriodReport.TabIndex = 324
            Me.btnWorkPeriodReport.Text = "Work Period Report"
            Me.btnWorkPeriodReport.UseVisualStyleBackColor = False
            Me.btnPOSReport.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.btnPOSReport.AutoSize = True
            Me.btnPOSReport.BackColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.btnPOSReport.FlatAppearance.BorderSize = 0
            Me.btnPOSReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnPOSReport.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnPOSReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnPOSReport.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Dim button3 As System.Windows.Forms.Button = Me.btnPOSReport
            location = New System.Drawing.Point(15, 36)
            button3.Location = location
            Me.btnPOSReport.Name = "btnPOSReport"
            Dim button4 As System.Windows.Forms.Button = Me.btnPOSReport
            size = New System.Drawing.Size(217, 76)
            button4.Size = size
            Me.btnPOSReport.TabIndex = 323
            Me.btnPOSReport.Text = "POS Report"
            Me.btnPOSReport.UseVisualStyleBackColor = False
            Me.btnClose.BackColor = System.Drawing.Color.Transparent
            Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnClose.FlatAppearance.BorderSize = 0
            Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnClose.Image = CType(componentResourceManager.GetObject("btnClose.Image"), System.Drawing.Image)
            Dim button5 As System.Windows.Forms.Button = Me.btnClose
            location = New System.Drawing.Point(428, -2)
            button5.Location = location
            Me.btnClose.Name = "btnClose"
            Dim button6 As System.Windows.Forms.Button = Me.btnClose
            size = New System.Drawing.Size(37, 36)
            button6.Size = size
            Me.btnClose.TabIndex = 322
            Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnClose.UseVisualStyleBackColor = False
            Me.lblUserType.AutoSize = True
            Me.lblUserType.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.lblUserType.ForeColor = System.Drawing.Color.Black
            Dim label3 As System.Windows.Forms.Label = Me.lblUserType
            location = New System.Drawing.Point(77, 4)
            label3.Location = location
            Me.lblUserType.Name = "lblUserType"
            Dim label4 As System.Windows.Forms.Label = Me.lblUserType
            size = New System.Drawing.Size(41, 13)
            label4.Size = size
            Me.lblUserType.TabIndex = 325
            Me.lblUserType.Text = "Label1"
            Me.lblUserType.Visible = False
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            size = New System.Drawing.Size(462, 120)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.lblUserType)
            MyBase.Controls.Add(Me.btnWorkPeriodReport)
            MyBase.Controls.Add(Me.btnPOSReport)
            MyBase.Controls.Add(Me.btnClose)
            MyBase.Controls.Add(Me.lblUser)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            MyBase.Name = "frmFrontOffice_Report"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "frmSettings"
            MyBase.ResumeLayout(False)
            MyBase.PerformLayout()
        End Sub
    End Class
End Namespace
