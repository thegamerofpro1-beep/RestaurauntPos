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
    Public Class frmCreditCustomer
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblUser")>
        Private _lblUser As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnCreditCustomer")>
        Private _btnCreditCustomer As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnPayment")>
        Private _btnPayment As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnCustomerLedger")>
        Private _btnCustomerLedger As CButtonLib.CButton

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

        Friend Overridable Property btnCreditCustomer As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnCreditCustomer
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnAddMember_Click
                If Me._btnCreditCustomer IsNot Nothing Then
                    RemoveHandler Me._btnCreditCustomer.Click, value2
                End If

                Me._btnCreditCustomer = value
                If Me._btnCreditCustomer IsNot Nothing Then
                    AddHandler Me._btnCreditCustomer.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnPayment As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnPayment
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnAddFunds_Click
                If Me._btnPayment IsNot Nothing Then
                    RemoveHandler Me._btnPayment.Click, value2
                End If

                Me._btnPayment = value
                If Me._btnPayment IsNot Nothing Then
                    AddHandler Me._btnPayment.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnCustomerLedger As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnCustomerLedger
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnMemberLedger_Click
                If Me._btnCustomerLedger IsNot Nothing Then
                    RemoveHandler Me._btnCustomerLedger.Click, value2
                End If

                Me._btnCustomerLedger = value
                If Me._btnCustomerLedger IsNot Nothing Then
                    AddHandler Me._btnCustomerLedger.Click, value2
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
            Call RestaurantPOS14.frmCreditCustomer.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmCreditCustomer.__ENCList
                If RestaurantPOS14.frmCreditCustomer.__ENCList.Count = RestaurantPOS14.frmCreditCustomer.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmCreditCustomer.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmCreditCustomer.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmCreditCustomer.__ENCList(num) = RestaurantPOS14.frmCreditCustomer.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmCreditCustomer.__ENCList.RemoveRange(num, RestaurantPOS14.frmCreditCustomer.__ENCList.Count - num)
                    RestaurantPOS14.frmCreditCustomer.__ENCList.Capacity = RestaurantPOS14.frmCreditCustomer.__ENCList.Count
                End If

                Call RestaurantPOS14.frmCreditCustomer.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Private Sub btnAddMember_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmCreditCustomerRegistration.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmCreditCustomerRegistration.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmCreditCustomerRegistration.ShowDialog()
        End Sub

        Private Sub btnAddFunds_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmCreditCustomerReceipt.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmCreditCustomerReceipt.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmCreditCustomerReceipt.ShowDialog()
        End Sub

        Private Sub btnMemberLedger_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmCreditCustomerLedger.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmCreditCustomerLedger.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmCreditCustomerLedger.ShowDialog()
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmCreditCustomer))
            Dim cBlendItems2 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems3 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Me.lblUser = New System.Windows.Forms.Label()
            Me.btnCustomerLedger = New CButtonLib.CButton()
            Me.btnPayment = New CButtonLib.CButton()
            Me.btnCreditCustomer = New CButtonLib.CButton()
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
            Me.btnCustomerLedger.BackColor = System.Drawing.Color.Transparent
            Me.btnCustomerLedger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnCustomerLedger.BorderShow = False
            cBlendItems.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnCustomerLedger.ColorFillBlend = cBlendItems
            Me.btnCustomerLedger.Corners.All = 3
            Me.btnCustomerLedger.Corners.LowerLeft = 3
            Me.btnCustomerLedger.Corners.LowerRight = 3
            Me.btnCustomerLedger.Corners.UpperLeft = 3
            Me.btnCustomerLedger.Corners.UpperRight = 3
            Me.btnCustomerLedger.DesignerSelected = False
            Me.btnCustomerLedger.Font = New System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnCustomerLedger.Image = CType(componentResourceManager.GetObject("btnCustomerLedger.Image"), System.Drawing.Image)
            Me.btnCustomerLedger.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnCustomerLedger.ImageIndex = 0
            Dim cButton As CButtonLib.CButton = Me.btnCustomerLedger
            size = New System.Drawing.Size(256, 256)
            cButton.ImageSize = size
            Dim cButton2 As CButtonLib.CButton = Me.btnCustomerLedger
            location = New System.Drawing.Point(12, 346)
            cButton2.Location = location
            Me.btnCustomerLedger.Name = "btnCustomerLedger"
            Dim cButton3 As CButtonLib.CButton = Me.btnCustomerLedger
            size = New System.Drawing.Size(363, 302)
            cButton3.Size = size
            Me.btnCustomerLedger.TabIndex = 324
            Me.btnCustomerLedger.Text = "Customer Ledger"
            Me.btnCustomerLedger.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnCustomerLedger.TextShadowShow = False
            Me.btnCustomerLedger.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.btnPayment.BackColor = System.Drawing.Color.Transparent
            Me.btnPayment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnPayment.BorderShow = False
            cBlendItems2.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems2.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnPayment.ColorFillBlend = cBlendItems2
            Me.btnPayment.Corners.All = 3
            Me.btnPayment.Corners.LowerLeft = 3
            Me.btnPayment.Corners.LowerRight = 3
            Me.btnPayment.Corners.UpperLeft = 3
            Me.btnPayment.Corners.UpperRight = 3
            Me.btnPayment.DesignerSelected = False
            Me.btnPayment.Font = New System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnPayment.Image = CType(componentResourceManager.GetObject("btnPayment.Image"), System.Drawing.Image)
            Me.btnPayment.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnPayment.ImageIndex = 0
            Dim cButton4 As CButtonLib.CButton = Me.btnPayment
            size = New System.Drawing.Size(256, 256)
            cButton4.ImageSize = size
            Dim cButton5 As CButtonLib.CButton = Me.btnPayment
            location = New System.Drawing.Point(381, 38)
            cButton5.Location = location
            Me.btnPayment.Name = "btnPayment"
            Dim cButton6 As CButtonLib.CButton = Me.btnPayment
            size = New System.Drawing.Size(363, 302)
            cButton6.Size = size
            Me.btnPayment.TabIndex = 52
            Me.btnPayment.Text = "Receipt"
            Me.btnPayment.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnPayment.TextShadowShow = False
            Me.btnPayment.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.btnCreditCustomer.BackColor = System.Drawing.Color.Transparent
            Me.btnCreditCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnCreditCustomer.BorderShow = False
            cBlendItems3.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems3.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnCreditCustomer.ColorFillBlend = cBlendItems3
            Me.btnCreditCustomer.Corners.All = 3
            Me.btnCreditCustomer.Corners.LowerLeft = 3
            Me.btnCreditCustomer.Corners.LowerRight = 3
            Me.btnCreditCustomer.Corners.UpperLeft = 3
            Me.btnCreditCustomer.Corners.UpperRight = 3
            Me.btnCreditCustomer.DesignerSelected = False
            Me.btnCreditCustomer.Font = New System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnCreditCustomer.Image = CType(componentResourceManager.GetObject("btnCreditCustomer.Image"), System.Drawing.Image)
            Me.btnCreditCustomer.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnCreditCustomer.ImageIndex = 0
            Dim cButton7 As CButtonLib.CButton = Me.btnCreditCustomer
            size = New System.Drawing.Size(256, 256)
            cButton7.ImageSize = size
            Dim cButton8 As CButtonLib.CButton = Me.btnCreditCustomer
            location = New System.Drawing.Point(12, 38)
            cButton8.Location = location
            Me.btnCreditCustomer.Name = "btnCreditCustomer"
            Dim cButton9 As CButtonLib.CButton = Me.btnCreditCustomer
            size = New System.Drawing.Size(363, 302)
            cButton9.Size = size
            Me.btnCreditCustomer.TabIndex = 28
            Me.btnCreditCustomer.Text = "Credit Customer"
            Me.btnCreditCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnCreditCustomer.TextShadowShow = False
            Me.btnCreditCustomer.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.btnClose.BackColor = System.Drawing.Color.Transparent
            Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnClose.FlatAppearance.BorderSize = 0
            Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnClose.Image = CType(componentResourceManager.GetObject("btnClose.Image"), System.Drawing.Image)
            Dim button As System.Windows.Forms.Button = Me.btnClose
            location = New System.Drawing.Point(717, 1)
            button.Location = location
            Me.btnClose.Name = "btnClose"
            Dim button2 As System.Windows.Forms.Button = Me.btnClose
            size = New System.Drawing.Size(37, 36)
            button2.Size = size
            Me.btnClose.TabIndex = 345
            Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnClose.UseVisualStyleBackColor = False
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            size = New System.Drawing.Size(757, 660)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.btnClose)
            MyBase.Controls.Add(Me.btnCustomerLedger)
            MyBase.Controls.Add(Me.lblUser)
            MyBase.Controls.Add(Me.btnPayment)
            MyBase.Controls.Add(Me.btnCreditCustomer)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.Name = "frmCreditCustomer"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "frmSettings"
            MyBase.ResumeLayout(False)
            MyBase.PerformLayout()
        End Sub
    End Class
End Namespace
