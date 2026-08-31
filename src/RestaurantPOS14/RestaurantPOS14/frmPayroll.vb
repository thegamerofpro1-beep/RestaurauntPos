Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Text
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports CButtonLib
Imports Microsoft.VisualBasic.CompilerServices
Imports RestaurantPOS14.My

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public Class frmPayroll
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnHB")>
        Private _btnHB As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnMB")>
        Private _btnMB As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblUser")>
        Private _lblUser As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnClose")>
        Private _btnClose As System.Windows.Forms.Button

        Private components As System.ComponentModel.IContainer

        Friend Overridable Property btnHB As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnHB
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnHB_Click
                If Me._btnHB IsNot Nothing Then
                    RemoveHandler Me._btnHB.Click, value2
                End If

                Me._btnHB = value
                If Me._btnHB IsNot Nothing Then
                    AddHandler Me._btnHB.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnMB As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnMB
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnMB_Click
                If Me._btnMB IsNot Nothing Then
                    RemoveHandler Me._btnMB.Click, value2
                End If

                Me._btnMB = value
                If Me._btnMB IsNot Nothing Then
                    AddHandler Me._btnMB.Click, value2
                End If
            End Set
        End Property

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
                Dim value2 As System.EventHandler = AddressOf Me.btnClose_Click_1
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
            Call RestaurantPOS14.frmPayroll.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmPayroll.__ENCList
                If RestaurantPOS14.frmPayroll.__ENCList.Count = RestaurantPOS14.frmPayroll.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmPayroll.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmPayroll.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmPayroll.__ENCList(num) = RestaurantPOS14.frmPayroll.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmPayroll.__ENCList.RemoveRange(num, RestaurantPOS14.frmPayroll.__ENCList.Count - num)
                    RestaurantPOS14.frmPayroll.__ENCList.Capacity = RestaurantPOS14.frmPayroll.__ENCList.Count
                End If

                Call RestaurantPOS14.frmPayroll.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Private Sub btnHB_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmPayroll_HB.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmPayroll_HB.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmPayroll_HB.ShowDialog()
        End Sub

        Private Sub btnMB_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmPayroll_MB.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmPayroll_MB.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmPayroll_MB.ShowDialog()
        End Sub

        Private Sub btnClose_Click_1(sender As Object, e As System.EventArgs)
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmPayroll))
            Me.btnHB = New CButtonLib.CButton()
            Me.lblUser = New System.Windows.Forms.Label()
            Me.btnMB = New CButtonLib.CButton()
            Me.btnClose = New System.Windows.Forms.Button()
            MyBase.SuspendLayout()
            Me.btnHB.BackColor = System.Drawing.Color.Transparent
            Me.btnHB.BorderShow = False
            cBlendItems.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnHB.ColorFillBlend = cBlendItems
            Me.btnHB.Corners.All = 3
            Me.btnHB.Corners.LowerLeft = 3
            Me.btnHB.Corners.LowerRight = 3
            Me.btnHB.Corners.UpperLeft = 3
            Me.btnHB.Corners.UpperRight = 3
            Me.btnHB.DesignerSelected = False
            Me.btnHB.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnHB.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnHB.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnHB.ImageIndex = 0
            Dim cButton As CButtonLib.CButton = Me.btnHB
            Dim location As System.Drawing.Point = New System.Drawing.Point(12, 43)
            cButton.Location = location
            Me.btnHB.Name = "btnHB"
            Dim cButton2 As CButtonLib.CButton = Me.btnHB
            Dim size As System.Drawing.Size = New System.Drawing.Size(217, 111)
            cButton2.Size = size
            Me.btnHB.TabIndex = 28
            Me.btnHB.Text = "Hourly Basis"
            Me.btnHB.TextShadowShow = False
            Me.btnHB.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.lblUser.AutoSize = True
            Dim label As System.Windows.Forms.Label = Me.lblUser
            location = New System.Drawing.Point(50, 9)
            label.Location = location
            Me.lblUser.Name = "lblUser"
            Dim label2 As System.Windows.Forms.Label = Me.lblUser
            size = New System.Drawing.Size(29, 13)
            label2.Size = size
            Me.lblUser.TabIndex = 332
            Me.lblUser.Text = "User"
            Me.lblUser.Visible = False
            Me.btnMB.BackColor = System.Drawing.Color.Transparent
            Me.btnMB.BorderShow = False
            cBlendItems2.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems2.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnMB.ColorFillBlend = cBlendItems2
            Me.btnMB.Corners.All = 3
            Me.btnMB.Corners.LowerLeft = 3
            Me.btnMB.Corners.LowerRight = 3
            Me.btnMB.Corners.UpperLeft = 3
            Me.btnMB.Corners.UpperRight = 3
            Me.btnMB.DesignerSelected = False
            Me.btnMB.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnMB.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnMB.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnMB.ImageIndex = 0
            Dim cButton3 As CButtonLib.CButton = Me.btnMB
            location = New System.Drawing.Point(235, 43)
            cButton3.Location = location
            Me.btnMB.Name = "btnMB"
            Dim cButton4 As CButtonLib.CButton = Me.btnMB
            size = New System.Drawing.Size(217, 111)
            cButton4.Size = size
            Me.btnMB.TabIndex = 323
            Me.btnMB.Text = "Monthly Basis"
            Me.btnMB.TextShadowShow = False
            Me.btnMB.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.btnClose.BackColor = System.Drawing.Color.Transparent
            Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnClose.FlatAppearance.BorderSize = 0
            Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnClose.Image = CType(componentResourceManager.GetObject("btnClose.Image"), System.Drawing.Image)
            Dim button As System.Windows.Forms.Button = Me.btnClose
            location = New System.Drawing.Point(427, 0)
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
            size = New System.Drawing.Size(469, 166)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.btnClose)
            MyBase.Controls.Add(Me.lblUser)
            MyBase.Controls.Add(Me.btnMB)
            MyBase.Controls.Add(Me.btnHB)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            MyBase.Name = "frmPayroll"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "frmSettings"
            MyBase.ResumeLayout(False)
            MyBase.PerformLayout()
        End Sub
    End Class
End Namespace
