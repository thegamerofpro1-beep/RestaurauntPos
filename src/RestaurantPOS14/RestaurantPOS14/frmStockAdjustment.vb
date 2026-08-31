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
    Public Class frmStockAdjustment
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnStockTransfer_W2S")>
        Private _btnStockTransfer_W2S As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnStockTransfer_W2W")>
        Private _btnStockTransfer_W2W As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnClose")>
        Private _btnClose As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblUser")>
        Private _lblUser As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnMenuItems")>
        Private _btnMenuItems As System.Windows.Forms.Button

        Private components As System.ComponentModel.IContainer

        Friend Overridable Property btnStockTransfer_W2S As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnStockTransfer_W2S
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnStockTransfer_W2S_Click
                If Me._btnStockTransfer_W2S IsNot Nothing Then
                    RemoveHandler Me._btnStockTransfer_W2S.Click, value2
                End If

                Me._btnStockTransfer_W2S = value
                If Me._btnStockTransfer_W2S IsNot Nothing Then
                    AddHandler Me._btnStockTransfer_W2S.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnStockTransfer_W2W As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnStockTransfer_W2W
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnStockTransfer_W2W_Click
                If Me._btnStockTransfer_W2W IsNot Nothing Then
                    RemoveHandler Me._btnStockTransfer_W2W.Click, value2
                End If

                Me._btnStockTransfer_W2W = value
                If Me._btnStockTransfer_W2W IsNot Nothing Then
                    AddHandler Me._btnStockTransfer_W2W.Click, value2
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

        Friend Overridable Property btnMenuItems As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnMenuItems
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnMenuItems_Click
                If Me._btnMenuItems IsNot Nothing Then
                    RemoveHandler Me._btnMenuItems.Click, value2
                End If

                Me._btnMenuItems = value
                If Me._btnMenuItems IsNot Nothing Then
                    AddHandler Me._btnMenuItems.Click, value2
                End If
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            Call RestaurantPOS14.frmStockAdjustment.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmStockAdjustment.__ENCList
                If RestaurantPOS14.frmStockAdjustment.__ENCList.Count = RestaurantPOS14.frmStockAdjustment.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmStockAdjustment.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmStockAdjustment.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmStockAdjustment.__ENCList(num) = RestaurantPOS14.frmStockAdjustment.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmStockAdjustment.__ENCList.RemoveRange(num, RestaurantPOS14.frmStockAdjustment.__ENCList.Count - num)
                    RestaurantPOS14.frmStockAdjustment.__ENCList.Capacity = RestaurantPOS14.frmStockAdjustment.__ENCList.Count
                End If

                Call RestaurantPOS14.frmStockAdjustment.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Private Sub btnClose_Click(sender As Object, e As System.EventArgs)
            MyBase.Close()
        End Sub

        Private Sub btnStockTransfer_W2S_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmStockAdjustment_Store.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmStockAdjustment_Store.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmStockAdjustment_Store.ShowDialog()
        End Sub

        Private Sub btnStockTransfer_W2W_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmStockAdjustment_Warehouse.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmStockAdjustment_Warehouse.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmStockAdjustment_Warehouse.ShowDialog()
        End Sub

        Private Sub btnMenuItems_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmStockAdjustment_MI.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmStockAdjustment_MI.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmStockAdjustment_MI.ShowDialog()
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmStockAdjustment))
            Me.btnStockTransfer_W2S = New System.Windows.Forms.Button()
            Me.btnStockTransfer_W2W = New System.Windows.Forms.Button()
            Me.lblUser = New System.Windows.Forms.Label()
            Me.btnClose = New System.Windows.Forms.Button()
            Me.btnMenuItems = New System.Windows.Forms.Button()
            MyBase.SuspendLayout()
            Me.btnStockTransfer_W2S.AutoSize = True
            Me.btnStockTransfer_W2S.BackColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.btnStockTransfer_W2S.FlatAppearance.BorderSize = 0
            Me.btnStockTransfer_W2S.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnStockTransfer_W2S.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnStockTransfer_W2S.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Dim button As System.Windows.Forms.Button = Me.btnStockTransfer_W2S
            Dim location As System.Drawing.Point = New System.Drawing.Point(12, 41)
            button.Location = location
            Me.btnStockTransfer_W2S.Name = "btnStockTransfer_W2S"
            Dim button2 As System.Windows.Forms.Button = Me.btnStockTransfer_W2S
            Dim size As System.Drawing.Size = New System.Drawing.Size(217, 65)
            button2.Size = size
            Me.btnStockTransfer_W2S.TabIndex = 28
            Me.btnStockTransfer_W2S.Text = "Kitchen Raw Materials"
            Me.btnStockTransfer_W2S.UseVisualStyleBackColor = False
            Me.btnStockTransfer_W2W.AutoSize = True
            Me.btnStockTransfer_W2W.BackColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.btnStockTransfer_W2W.FlatAppearance.BorderSize = 0
            Me.btnStockTransfer_W2W.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnStockTransfer_W2W.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnStockTransfer_W2W.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnStockTransfer_W2W.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Dim button3 As System.Windows.Forms.Button = Me.btnStockTransfer_W2W
            location = New System.Drawing.Point(235, 41)
            button3.Location = location
            Me.btnStockTransfer_W2W.Name = "btnStockTransfer_W2W"
            Dim button4 As System.Windows.Forms.Button = Me.btnStockTransfer_W2W
            size = New System.Drawing.Size(217, 65)
            button4.Size = size
            Me.btnStockTransfer_W2W.TabIndex = 29
            Me.btnStockTransfer_W2W.Text = "Warehouse Raw " & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Materials"
            Me.btnStockTransfer_W2W.UseVisualStyleBackColor = False
            Me.lblUser.AutoSize = True
            Dim label As System.Windows.Forms.Label = Me.lblUser
            location = New System.Drawing.Point(393, 8)
            label.Location = location
            Me.lblUser.Name = "lblUser"
            Dim label2 As System.Windows.Forms.Label = Me.lblUser
            size = New System.Drawing.Size(29, 13)
            label2.Size = size
            Me.lblUser.TabIndex = 323
            Me.lblUser.Text = "User"
            Me.lblUser.Visible = False
            Me.btnClose.BackColor = System.Drawing.Color.Transparent
            Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnClose.FlatAppearance.BorderSize = 0
            Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnClose.Image = CType(componentResourceManager.GetObject("btnClose.Image"), System.Drawing.Image)
            Dim button5 As System.Windows.Forms.Button = Me.btnClose
            location = New System.Drawing.Point(646, 2)
            button5.Location = location
            Me.btnClose.Name = "btnClose"
            Dim button6 As System.Windows.Forms.Button = Me.btnClose
            size = New System.Drawing.Size(37, 36)
            button6.Size = size
            Me.btnClose.TabIndex = 322
            Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnClose.UseVisualStyleBackColor = False
            Me.btnMenuItems.AutoSize = True
            Me.btnMenuItems.BackColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.btnMenuItems.FlatAppearance.BorderSize = 0
            Me.btnMenuItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnMenuItems.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnMenuItems.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnMenuItems.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Dim button7 As System.Windows.Forms.Button = Me.btnMenuItems
            location = New System.Drawing.Point(458, 41)
            button7.Location = location
            Me.btnMenuItems.Name = "btnMenuItems"
            Dim button8 As System.Windows.Forms.Button = Me.btnMenuItems
            size = New System.Drawing.Size(217, 65)
            button8.Size = size
            Me.btnMenuItems.TabIndex = 324
            Me.btnMenuItems.Text = "Menu Items"
            Me.btnMenuItems.UseVisualStyleBackColor = False
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            size = New System.Drawing.Size(687, 122)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.btnMenuItems)
            MyBase.Controls.Add(Me.lblUser)
            MyBase.Controls.Add(Me.btnClose)
            MyBase.Controls.Add(Me.btnStockTransfer_W2W)
            MyBase.Controls.Add(Me.btnStockTransfer_W2S)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.Name = "frmStockAdjustment"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "frmSettings"
            MyBase.ResumeLayout(False)
            MyBase.PerformLayout()
        End Sub
    End Class
End Namespace
