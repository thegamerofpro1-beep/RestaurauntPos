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
    Public Class frmCards
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblUser")>
        Private _lblUser As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnVIPMemberCard")>
        Private _btnVIPMemberCard As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnLoyaltyCard")>
        Private _btnLoyaltyCard As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnGiftCard")>
        Private _btnGiftCard As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnClose")>
        Private _btnClose As System.Windows.Forms.Button

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

        Friend Overridable Property btnVIPMemberCard As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnVIPMemberCard
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnVIPMemberCard_Click
                If Me._btnVIPMemberCard IsNot Nothing Then
                    RemoveHandler Me._btnVIPMemberCard.Click, value2
                End If

                Me._btnVIPMemberCard = value
                If Me._btnVIPMemberCard IsNot Nothing Then
                    AddHandler Me._btnVIPMemberCard.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnLoyaltyCard As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnLoyaltyCard
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnLoyaltyCard_Click
                If Me._btnLoyaltyCard IsNot Nothing Then
                    RemoveHandler Me._btnLoyaltyCard.Click, value2
                End If

                Me._btnLoyaltyCard = value
                If Me._btnLoyaltyCard IsNot Nothing Then
                    AddHandler Me._btnLoyaltyCard.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnGiftCard As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnGiftCard
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnGiftCard_Click
                If Me._btnGiftCard IsNot Nothing Then
                    RemoveHandler Me._btnGiftCard.Click, value2
                End If

                Me._btnGiftCard = value
                If Me._btnGiftCard IsNot Nothing Then
                    AddHandler Me._btnGiftCard.Click, value2
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
            Call RestaurantPOS14.frmCards.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmCards.__ENCList
                If RestaurantPOS14.frmCards.__ENCList.Count = RestaurantPOS14.frmCards.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmCards.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmCards.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmCards.__ENCList(num) = RestaurantPOS14.frmCards.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmCards.__ENCList.RemoveRange(num, RestaurantPOS14.frmCards.__ENCList.Count - num)
                    RestaurantPOS14.frmCards.__ENCList.Capacity = RestaurantPOS14.frmCards.__ENCList.Count
                End If

                Call RestaurantPOS14.frmCards.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Private Sub btnVIPMemberCard_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmVIPMemberCard.lblUser.Text = Me.lblUser.Text
            If RestaurantPOS14.ModFunc.IsViewAllowed(Me.lblUser.Text, "VIP Member Card") Then
                RestaurantPOS14.My.MyProject.Forms.frmVIPMemberCard.btnMemberLedger.Enabled = True
                RestaurantPOS14.My.MyProject.Forms.frmVIPMemberCard.btnPrintCards.Enabled = True
            Else
                RestaurantPOS14.My.MyProject.Forms.frmVIPMemberCard.btnMemberLedger.Enabled = False
                RestaurantPOS14.My.MyProject.Forms.frmVIPMemberCard.btnPrintCards.Enabled = False
            End If

            Call RestaurantPOS14.My.MyProject.Forms.frmVIPMemberCard.ShowDialog()
        End Sub

        Private Sub btnLoyaltyCard_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmLoyaltyCard.lblUser.Text = Me.lblUser.Text
            If RestaurantPOS14.ModFunc.IsViewAllowed(Me.lblUser.Text, "Loyalty Card") Then
                RestaurantPOS14.My.MyProject.Forms.frmLoyaltyCard.btnMemberLedger.Enabled = True
                RestaurantPOS14.My.MyProject.Forms.frmLoyaltyCard.btnPrintCards.Enabled = True
            Else
                RestaurantPOS14.My.MyProject.Forms.frmLoyaltyCard.btnMemberLedger.Enabled = False
                RestaurantPOS14.My.MyProject.Forms.frmLoyaltyCard.btnPrintCards.Enabled = False
            End If

            Call RestaurantPOS14.My.MyProject.Forms.frmLoyaltyCard.ShowDialog()
        End Sub

        Private Sub btnGiftCard_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmGiftCard.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmGiftCard.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmGiftCard.ShowDialog()
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
            Dim cBlendItems3 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmCards))
            Me.lblUser = New System.Windows.Forms.Label()
            Me.btnVIPMemberCard = New CButtonLib.CButton()
            Me.btnLoyaltyCard = New CButtonLib.CButton()
            Me.btnGiftCard = New CButtonLib.CButton()
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
            Dim size As System.Drawing.Size = New System.Drawing.Size(30, 13)
            label2.Size = size
            Me.lblUser.TabIndex = 321
            Me.lblUser.Text = "User"
            Me.lblUser.Visible = False
            Me.btnVIPMemberCard.BackColor = System.Drawing.Color.Transparent
            Me.btnVIPMemberCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnVIPMemberCard.BorderShow = False
            cBlendItems.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnVIPMemberCard.ColorFillBlend = cBlendItems
            Me.btnVIPMemberCard.Corners.All = 3
            Me.btnVIPMemberCard.Corners.LowerLeft = 3
            Me.btnVIPMemberCard.Corners.LowerRight = 3
            Me.btnVIPMemberCard.Corners.UpperLeft = 3
            Me.btnVIPMemberCard.Corners.UpperRight = 3
            Me.btnVIPMemberCard.DesignerSelected = False
            Me.btnVIPMemberCard.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnVIPMemberCard.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnVIPMemberCard.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnVIPMemberCard.ImageIndex = 0
            Dim cButton As CButtonLib.CButton = Me.btnVIPMemberCard
            location = New System.Drawing.Point(15, 43)
            cButton.Location = location
            Me.btnVIPMemberCard.Name = "btnVIPMemberCard"
            Dim cButton2 As CButtonLib.CButton = Me.btnVIPMemberCard
            size = New System.Drawing.Size(217, 120)
            cButton2.Size = size
            Me.btnVIPMemberCard.TabIndex = 323
            Me.btnVIPMemberCard.Text = "VIP Member" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Card"
            Me.btnVIPMemberCard.TextShadowShow = False
            Me.btnVIPMemberCard.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.btnLoyaltyCard.BackColor = System.Drawing.Color.Transparent
            Me.btnLoyaltyCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnLoyaltyCard.BorderShow = False
            cBlendItems2.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems2.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnLoyaltyCard.ColorFillBlend = cBlendItems2
            Me.btnLoyaltyCard.Corners.All = 3
            Me.btnLoyaltyCard.Corners.LowerLeft = 3
            Me.btnLoyaltyCard.Corners.LowerRight = 3
            Me.btnLoyaltyCard.Corners.UpperLeft = 3
            Me.btnLoyaltyCard.Corners.UpperRight = 3
            Me.btnLoyaltyCard.DesignerSelected = False
            Me.btnLoyaltyCard.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnLoyaltyCard.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnLoyaltyCard.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnLoyaltyCard.ImageIndex = 0
            Dim cButton3 As CButtonLib.CButton = Me.btnLoyaltyCard
            location = New System.Drawing.Point(238, 43)
            cButton3.Location = location
            Me.btnLoyaltyCard.Name = "btnLoyaltyCard"
            Dim cButton4 As CButtonLib.CButton = Me.btnLoyaltyCard
            size = New System.Drawing.Size(217, 120)
            cButton4.Size = size
            Me.btnLoyaltyCard.TabIndex = 324
            Me.btnLoyaltyCard.Text = "Loyalty Card"
            Me.btnLoyaltyCard.TextShadowShow = False
            Me.btnLoyaltyCard.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.btnGiftCard.BackColor = System.Drawing.Color.Transparent
            Me.btnGiftCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnGiftCard.BorderShow = False
            cBlendItems3.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems3.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnGiftCard.ColorFillBlend = cBlendItems3
            Me.btnGiftCard.Corners.All = 3
            Me.btnGiftCard.Corners.LowerLeft = 3
            Me.btnGiftCard.Corners.LowerRight = 3
            Me.btnGiftCard.Corners.UpperLeft = 3
            Me.btnGiftCard.Corners.UpperRight = 3
            Me.btnGiftCard.DesignerSelected = False
            Me.btnGiftCard.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnGiftCard.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnGiftCard.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnGiftCard.ImageIndex = 0
            Dim cButton5 As CButtonLib.CButton = Me.btnGiftCard
            location = New System.Drawing.Point(461, 43)
            cButton5.Location = location
            Me.btnGiftCard.Name = "btnGiftCard"
            Dim cButton6 As CButtonLib.CButton = Me.btnGiftCard
            size = New System.Drawing.Size(217, 120)
            cButton6.Size = size
            Me.btnGiftCard.TabIndex = 326
            Me.btnGiftCard.Text = "Gift Card"
            Me.btnGiftCard.TextShadowShow = False
            Me.btnGiftCard.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.btnClose.BackColor = System.Drawing.Color.Transparent
            Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnClose.FlatAppearance.BorderSize = 0
            Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnClose.Image = CType(componentResourceManager.GetObject("btnClose.Image"), System.Drawing.Image)
            Dim button As System.Windows.Forms.Button = Me.btnClose
            location = New System.Drawing.Point(647, 2)
            button.Location = location
            Me.btnClose.Name = "btnClose"
            Dim button2 As System.Windows.Forms.Button = Me.btnClose
            size = New System.Drawing.Size(37, 36)
            button2.Size = size
            Me.btnClose.TabIndex = 343
            Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnClose.UseVisualStyleBackColor = False
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            size = New System.Drawing.Size(687, 177)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.btnClose)
            MyBase.Controls.Add(Me.btnGiftCard)
            MyBase.Controls.Add(Me.btnLoyaltyCard)
            MyBase.Controls.Add(Me.btnVIPMemberCard)
            MyBase.Controls.Add(Me.lblUser)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            MyBase.Name = "frmCards"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "frmSettings"
            MyBase.ResumeLayout(False)
            MyBase.PerformLayout()
        End Sub
    End Class
End Namespace
