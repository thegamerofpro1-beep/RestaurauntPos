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
    Public Class frmPizza
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference)

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnPizzaSize")>
        Private _btnPizzaSize As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnPizzaToppings")>
        Private _btnPizzaToppings As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblUser")>
        Private _lblUser As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnPizzaMaster")>
        Private _btnPizzaMaster As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnPizzaModifiers")>
        Private _btnPizzaModifiers As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnClose")>
        Private _btnClose As System.Windows.Forms.Button

        Private components As System.ComponentModel.IContainer

        Friend Overridable Property btnPizzaSize As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnPizzaSize
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnPizzaSize_Click
                If Me._btnPizzaSize IsNot Nothing Then
                    RemoveHandler Me._btnPizzaSize.Click, value2
                End If

                Me._btnPizzaSize = value
                If Me._btnPizzaSize IsNot Nothing Then
                    AddHandler Me._btnPizzaSize.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnPizzaToppings As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnPizzaToppings
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnPizzaToppings_Click
                If Me._btnPizzaToppings IsNot Nothing Then
                    RemoveHandler Me._btnPizzaToppings.Click, value2
                End If

                Me._btnPizzaToppings = value
                If Me._btnPizzaToppings IsNot Nothing Then
                    AddHandler Me._btnPizzaToppings.Click, value2
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

        Friend Overridable Property btnPizzaMaster As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnPizzaMaster
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnPizzaMaster_Click
                If Me._btnPizzaMaster IsNot Nothing Then
                    RemoveHandler Me._btnPizzaMaster.Click, value2
                End If

                Me._btnPizzaMaster = value
                If Me._btnPizzaMaster IsNot Nothing Then
                    AddHandler Me._btnPizzaMaster.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnPizzaModifiers As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnPizzaModifiers
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnPizzaModifiers_Click
                If Me._btnPizzaModifiers IsNot Nothing Then
                    RemoveHandler Me._btnPizzaModifiers.Click, value2
                End If

                Me._btnPizzaModifiers = value
                If Me._btnPizzaModifiers IsNot Nothing Then
                    AddHandler Me._btnPizzaModifiers.Click, value2
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
            Call RestaurantPOS14.frmPizza.__ENCAddToList(Me)
            Me.InitializeComponent()
            MyBase.Hide()
            Me._btnPizzaSize.Visible = False
            Me._btnPizzaSize.Enabled = False
            Me._btnPizzaSize.Text = ""
            Me._btnPizzaToppings.Visible = False
            Me._btnPizzaToppings.Enabled = False
            Me._btnPizzaToppings.Text = ""
            Me._btnPizzaMaster.Visible = False
            Me._btnPizzaMaster.Enabled = False
            Me._btnPizzaMaster.Text = ""
            Me._btnPizzaModifiers.Visible = False
            Me._btnPizzaModifiers.Enabled = False
            Me._btnPizzaModifiers.Text = ""
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmPizza.__ENCList
                If RestaurantPOS14.frmPizza.__ENCList.Count = RestaurantPOS14.frmPizza.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmPizza.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmPizza.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmPizza.__ENCList(num) = RestaurantPOS14.frmPizza.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmPizza.__ENCList.RemoveRange(num, RestaurantPOS14.frmPizza.__ENCList.Count - num)
                    RestaurantPOS14.frmPizza.__ENCList.Capacity = RestaurantPOS14.frmPizza.__ENCList.Count
                End If

                Call RestaurantPOS14.frmPizza.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Private Sub btnPizzaSize_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmPizzaSize.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmPizzaSize.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmPizzaSize.ShowDialog()
        End Sub

        Private Sub btnPizzaToppings_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmPizzaToppings.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmPizzaToppings.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmPizzaToppings.ShowDialog()
        End Sub

        Private Sub btnPizzaMaster_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmPizzaMaster.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmPizzaMaster.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmPizzaMaster.ShowDialog()
        End Sub

        Private Sub btnPizzaModifiers_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmPizzaModifiers.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmPizzaModifiers.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmPizzaModifiers.ShowDialog()
        End Sub

        Private Sub btnClose_Click_1(sender As Object, e As System.EventArgs)
            MyBase.Close()
        End Sub

        Shared Sub New()
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmPizza))
            Dim cBlendItems2 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems3 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems4 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Me.lblUser = New System.Windows.Forms.Label()
            Me.btnPizzaModifiers = New CButtonLib.CButton()
            Me.btnPizzaMaster = New CButtonLib.CButton()
            Me.btnPizzaToppings = New CButtonLib.CButton()
            Me.btnPizzaSize = New CButtonLib.CButton()
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
            Me.btnPizzaModifiers.BackColor = System.Drawing.Color.Transparent
            Me.btnPizzaModifiers.BorderColor = System.Drawing.Color.Transparent
            Me.btnPizzaModifiers.BorderShow = False
            cBlendItems.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnPizzaModifiers.ColorFillBlend = cBlendItems
            Me.btnPizzaModifiers.Corners.All = 3
            Me.btnPizzaModifiers.Corners.LowerLeft = 3
            Me.btnPizzaModifiers.Corners.LowerRight = 3
            Me.btnPizzaModifiers.Corners.UpperLeft = 3
            Me.btnPizzaModifiers.Corners.UpperRight = 3
            Me.btnPizzaModifiers.DesignerSelected = False
            Me.btnPizzaModifiers.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnPizzaModifiers.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnPizzaModifiers.Image = CType(componentResourceManager.GetObject("btnPizzaModifiers.Image"), System.Drawing.Image)
            Me.btnPizzaModifiers.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnPizzaModifiers.ImageIndex = 0
            Dim cButton As CButtonLib.CButton = Me.btnPizzaModifiers
            size = New System.Drawing.Size(48, 48)
            cButton.ImageSize = size
            Dim cButton2 As CButtonLib.CButton = Me.btnPizzaModifiers
            location = New System.Drawing.Point(235, 119)
            cButton2.Location = location
            Me.btnPizzaModifiers.Name = "btnPizzaModifiers"
            Dim cButton3 As CButtonLib.CButton = Me.btnPizzaModifiers
            size = New System.Drawing.Size(217, 75)
            cButton3.Size = size
            Me.btnPizzaModifiers.TabIndex = 324
            Me.btnPizzaModifiers.Text = "Pizza Modifiers"
            Me.btnPizzaModifiers.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnPizzaModifiers.TextShadowShow = False
            Me.btnPizzaModifiers.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.btnPizzaMaster.BackColor = System.Drawing.Color.Transparent
            Me.btnPizzaMaster.BorderColor = System.Drawing.Color.Transparent
            Me.btnPizzaMaster.BorderShow = False
            cBlendItems2.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems2.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnPizzaMaster.ColorFillBlend = cBlendItems2
            Me.btnPizzaMaster.Corners.All = 3
            Me.btnPizzaMaster.Corners.LowerLeft = 3
            Me.btnPizzaMaster.Corners.LowerRight = 3
            Me.btnPizzaMaster.Corners.UpperLeft = 3
            Me.btnPizzaMaster.Corners.UpperRight = 3
            Me.btnPizzaMaster.DesignerSelected = False
            Me.btnPizzaMaster.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnPizzaMaster.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnPizzaMaster.Image = CType(componentResourceManager.GetObject("btnPizzaMaster.Image"), System.Drawing.Image)
            Me.btnPizzaMaster.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnPizzaMaster.ImageIndex = 0
            Dim cButton4 As CButtonLib.CButton = Me.btnPizzaMaster
            size = New System.Drawing.Size(48, 48)
            cButton4.ImageSize = size
            Dim cButton5 As CButtonLib.CButton = Me.btnPizzaMaster
            location = New System.Drawing.Point(12, 119)
            cButton5.Location = location
            Me.btnPizzaMaster.Name = "btnPizzaMaster"
            Dim cButton6 As CButtonLib.CButton = Me.btnPizzaMaster
            size = New System.Drawing.Size(217, 75)
            cButton6.Size = size
            Me.btnPizzaMaster.TabIndex = 323
            Me.btnPizzaMaster.Text = "Pizza Master"
            Me.btnPizzaMaster.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnPizzaMaster.TextShadowShow = False
            Me.btnPizzaMaster.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.btnPizzaToppings.BackColor = System.Drawing.Color.Transparent
            Me.btnPizzaToppings.BorderColor = System.Drawing.Color.Transparent
            Me.btnPizzaToppings.BorderShow = False
            cBlendItems3.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems3.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnPizzaToppings.ColorFillBlend = cBlendItems3
            Me.btnPizzaToppings.Corners.All = 3
            Me.btnPizzaToppings.Corners.LowerLeft = 3
            Me.btnPizzaToppings.Corners.LowerRight = 3
            Me.btnPizzaToppings.Corners.UpperLeft = 3
            Me.btnPizzaToppings.Corners.UpperRight = 3
            Me.btnPizzaToppings.DesignerSelected = False
            Me.btnPizzaToppings.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnPizzaToppings.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnPizzaToppings.Image = CType(componentResourceManager.GetObject("btnPizzaToppings.Image"), System.Drawing.Image)
            Me.btnPizzaToppings.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnPizzaToppings.ImageIndex = 0
            Dim cButton7 As CButtonLib.CButton = Me.btnPizzaToppings
            size = New System.Drawing.Size(48, 48)
            cButton7.ImageSize = size
            Dim cButton8 As CButtonLib.CButton = Me.btnPizzaToppings
            location = New System.Drawing.Point(235, 38)
            cButton8.Location = location
            Me.btnPizzaToppings.Name = "btnPizzaToppings"
            Dim cButton9 As CButtonLib.CButton = Me.btnPizzaToppings
            size = New System.Drawing.Size(217, 75)
            cButton9.Size = size
            Me.btnPizzaToppings.TabIndex = 52
            Me.btnPizzaToppings.Text = "Pizza Toppings"
            Me.btnPizzaToppings.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnPizzaToppings.TextShadowShow = False
            Me.btnPizzaToppings.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.btnPizzaSize.BackColor = System.Drawing.Color.Transparent
            Me.btnPizzaSize.BorderColor = System.Drawing.Color.Transparent
            Me.btnPizzaSize.BorderShow = False
            cBlendItems4.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems4.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnPizzaSize.ColorFillBlend = cBlendItems4
            Me.btnPizzaSize.Corners.All = 3
            Me.btnPizzaSize.Corners.LowerLeft = 3
            Me.btnPizzaSize.Corners.LowerRight = 3
            Me.btnPizzaSize.Corners.UpperLeft = 3
            Me.btnPizzaSize.Corners.UpperRight = 3
            Me.btnPizzaSize.DesignerSelected = False
            Me.btnPizzaSize.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnPizzaSize.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnPizzaSize.Image = CType(componentResourceManager.GetObject("btnPizzaSize.Image"), System.Drawing.Image)
            Me.btnPizzaSize.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnPizzaSize.ImageIndex = 0
            Dim cButton10 As CButtonLib.CButton = Me.btnPizzaSize
            size = New System.Drawing.Size(48, 48)
            cButton10.ImageSize = size
            Dim cButton11 As CButtonLib.CButton = Me.btnPizzaSize
            location = New System.Drawing.Point(12, 38)
            cButton11.Location = location
            Me.btnPizzaSize.Name = "btnPizzaSize"
            Dim cButton12 As CButtonLib.CButton = Me.btnPizzaSize
            size = New System.Drawing.Size(217, 75)
            cButton12.Size = size
            Me.btnPizzaSize.TabIndex = 28
            Me.btnPizzaSize.Text = "Pizza Size"
            Me.btnPizzaSize.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnPizzaSize.TextShadowShow = False
            Me.btnPizzaSize.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.btnClose.BackColor = System.Drawing.Color.Transparent
            Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnClose.FlatAppearance.BorderSize = 0
            Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnClose.Image = CType(componentResourceManager.GetObject("btnClose.Image"), System.Drawing.Image)
            Dim button As System.Windows.Forms.Button = Me.btnClose
            location = New System.Drawing.Point(422, 1)
            button.Location = location
            Me.btnClose.Name = "btnClose"
            Dim button2 As System.Windows.Forms.Button = Me.btnClose
            size = New System.Drawing.Size(37, 36)
            button2.Size = size
            Me.btnClose.TabIndex = 341
            Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnClose.UseVisualStyleBackColor = False
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            size = New System.Drawing.Size(462, 206)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.btnClose)
            MyBase.Controls.Add(Me.btnPizzaModifiers)
            MyBase.Controls.Add(Me.btnPizzaMaster)
            MyBase.Controls.Add(Me.lblUser)
            MyBase.Controls.Add(Me.btnPizzaToppings)
            MyBase.Controls.Add(Me.btnPizzaSize)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            MyBase.Name = "frmPizza"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "frmSettings"
            MyBase.ResumeLayout(False)
            MyBase.PerformLayout()
        End Sub
    End Class
End Namespace
