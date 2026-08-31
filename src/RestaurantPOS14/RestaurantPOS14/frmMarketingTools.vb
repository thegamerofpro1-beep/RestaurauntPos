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
    Public Class frmMarketingTools
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("OpenFileDialog1")>
        Private _OpenFileDialog1 As System.Windows.Forms.OpenFileDialog

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Timer2")>
        Private _Timer2 As System.Windows.Forms.Timer

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnSendSMS")>
        Private _btnSendSMS As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnSendEmail")>
        Private _btnSendEmail As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnClose")>
        Private _btnClose As System.Windows.Forms.Button

        Private components As System.ComponentModel.IContainer

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

        Friend Overridable Property btnSendSMS As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnSendSMS
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
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

        Friend Overridable Property btnSendEmail As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnSendEmail
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnSendEmail_Click
                If Me._btnSendEmail IsNot Nothing Then
                    RemoveHandler Me._btnSendEmail.Click, value2
                End If

                Me._btnSendEmail = value
                If Me._btnSendEmail IsNot Nothing Then
                    AddHandler Me._btnSendEmail.Click, value2
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
            Call RestaurantPOS14.frmMarketingTools.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmMarketingTools.__ENCList
                If RestaurantPOS14.frmMarketingTools.__ENCList.Count = RestaurantPOS14.frmMarketingTools.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmMarketingTools.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmMarketingTools.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmMarketingTools.__ENCList(num) = RestaurantPOS14.frmMarketingTools.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmMarketingTools.__ENCList.RemoveRange(num, RestaurantPOS14.frmMarketingTools.__ENCList.Count - num)
                    RestaurantPOS14.frmMarketingTools.__ENCList.Capacity = RestaurantPOS14.frmMarketingTools.__ENCList.Count
                End If

                Call RestaurantPOS14.frmMarketingTools.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Private Sub btnSendSMS_Click(sender As Object, e As System.EventArgs)
            Call RestaurantPOS14.My.MyProject.Forms.frmSendBroadcastSMS.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmSendBroadcastSMS.ShowDialog()
        End Sub

        Private Sub btnSendEmail_Click(sender As Object, e As System.EventArgs)
            Call RestaurantPOS14.My.MyProject.Forms.frmSendEmail.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmSendEmail.ShowDialog()
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmMarketingTools))
            Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
            Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
            Me.btnSendSMS = New CButtonLib.CButton()
            Me.btnSendEmail = New CButtonLib.CButton()
            Me.btnClose = New System.Windows.Forms.Button()
            MyBase.SuspendLayout()
            Me.OpenFileDialog1.FileName = "OpenFileDialog1"
            Me.btnSendSMS.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.btnSendSMS.BackColor = System.Drawing.Color.Transparent
            Me.btnSendSMS.BorderShow = False
            cBlendItems.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnSendSMS.ColorFillBlend = cBlendItems
            Me.btnSendSMS.Corners.All = 3
            Me.btnSendSMS.Corners.LowerLeft = 3
            Me.btnSendSMS.Corners.LowerRight = 3
            Me.btnSendSMS.Corners.UpperLeft = 3
            Me.btnSendSMS.Corners.UpperRight = 3
            Me.btnSendSMS.DesignerSelected = False
            Me.btnSendSMS.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnSendSMS.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnSendSMS.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnSendSMS.ImageIndex = 0
            Dim cButton As CButtonLib.CButton = Me.btnSendSMS
            Dim location As System.Drawing.Point = New System.Drawing.Point(9, 39)
            cButton.Location = location
            Me.btnSendSMS.Name = "btnSendSMS"
            Dim cButton2 As CButtonLib.CButton = Me.btnSendSMS
            Dim size As System.Drawing.Size = New System.Drawing.Size(217, 88)
            cButton2.Size = size
            Me.btnSendSMS.TabIndex = 323
            Me.btnSendSMS.Text = "Send SMS"
            Me.btnSendSMS.TextShadowShow = False
            Me.btnSendSMS.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.btnSendEmail.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.btnSendEmail.BackColor = System.Drawing.Color.Transparent
            Me.btnSendEmail.BorderShow = False
            cBlendItems2.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems2.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnSendEmail.ColorFillBlend = cBlendItems2
            Me.btnSendEmail.Corners.All = 3
            Me.btnSendEmail.Corners.LowerLeft = 3
            Me.btnSendEmail.Corners.LowerRight = 3
            Me.btnSendEmail.Corners.UpperLeft = 3
            Me.btnSendEmail.Corners.UpperRight = 3
            Me.btnSendEmail.DesignerSelected = False
            Me.btnSendEmail.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnSendEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnSendEmail.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnSendEmail.ImageIndex = 0
            Dim cButton3 As CButtonLib.CButton = Me.btnSendEmail
            location = New System.Drawing.Point(232, 39)
            cButton3.Location = location
            Me.btnSendEmail.Name = "btnSendEmail"
            Dim cButton4 As CButtonLib.CButton = Me.btnSendEmail
            size = New System.Drawing.Size(217, 88)
            cButton4.Size = size
            Me.btnSendEmail.TabIndex = 324
            Me.btnSendEmail.Text = "Send Email"
            Me.btnSendEmail.TextShadowShow = False
            Me.btnSendEmail.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.btnClose.BackColor = System.Drawing.Color.Transparent
            Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnClose.FlatAppearance.BorderSize = 0
            Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnClose.Image = CType(componentResourceManager.GetObject("btnClose.Image"), System.Drawing.Image)
            Dim button As System.Windows.Forms.Button = Me.btnClose
            location = New System.Drawing.Point(424, 0)
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
            size = New System.Drawing.Size(462, 139)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.btnClose)
            MyBase.Controls.Add(Me.btnSendEmail)
            MyBase.Controls.Add(Me.btnSendSMS)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            MyBase.Name = "frmMarketingTools"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "frmSettings"
            MyBase.ResumeLayout(False)
            MyBase.PerformLayout()
        End Sub
    End Class
End Namespace
