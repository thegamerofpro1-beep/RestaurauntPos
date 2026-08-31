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
    Public Class frmLoyaltyCard
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnAddMember")>
        Private _btnAddMember As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnPrintCards")>
        Private _btnPrintCards As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnLoyaltySetting")>
        Private _btnLoyaltySetting As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblUser")>
        Private _lblUser As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnClose")>
        Private _btnClose As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnMemberLedger")>
        Private _btnMemberLedger As System.Windows.Forms.Button

        Private components As System.ComponentModel.IContainer

        Friend Overridable Property btnAddMember As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnAddMember
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnAddMember_Click
                If Me._btnAddMember IsNot Nothing Then
                    RemoveHandler Me._btnAddMember.Click, value2
                End If

                Me._btnAddMember = value
                If Me._btnAddMember IsNot Nothing Then
                    AddHandler Me._btnAddMember.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnPrintCards As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnPrintCards
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnPrintCards_Click
                If Me._btnPrintCards IsNot Nothing Then
                    RemoveHandler Me._btnPrintCards.Click, value2
                End If

                Me._btnPrintCards = value
                If Me._btnPrintCards IsNot Nothing Then
                    AddHandler Me._btnPrintCards.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnLoyaltySetting As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnLoyaltySetting
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnAddFunds_Click
                If Me._btnLoyaltySetting IsNot Nothing Then
                    RemoveHandler Me._btnLoyaltySetting.Click, value2
                End If

                Me._btnLoyaltySetting = value
                If Me._btnLoyaltySetting IsNot Nothing Then
                    AddHandler Me._btnLoyaltySetting.Click, value2
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

        Friend Overridable Property btnMemberLedger As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnMemberLedger
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnMemberLedger_Click
                If Me._btnMemberLedger IsNot Nothing Then
                    RemoveHandler Me._btnMemberLedger.Click, value2
                End If

                Me._btnMemberLedger = value
                If Me._btnMemberLedger IsNot Nothing Then
                    AddHandler Me._btnMemberLedger.Click, value2
                End If
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            Call RestaurantPOS14.frmLoyaltyCard.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmLoyaltyCard.__ENCList
                If RestaurantPOS14.frmLoyaltyCard.__ENCList.Count = RestaurantPOS14.frmLoyaltyCard.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmLoyaltyCard.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmLoyaltyCard.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmLoyaltyCard.__ENCList(num) = RestaurantPOS14.frmLoyaltyCard.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmLoyaltyCard.__ENCList.RemoveRange(num, RestaurantPOS14.frmLoyaltyCard.__ENCList.Count - num)
                    RestaurantPOS14.frmLoyaltyCard.__ENCList.Capacity = RestaurantPOS14.frmLoyaltyCard.__ENCList.Count
                End If

                Call RestaurantPOS14.frmLoyaltyCard.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Private Sub btnClose_Click(sender As Object, e As System.EventArgs)
            MyBase.Close()
        End Sub

        Private Sub btnAddMember_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmLoyaltyMember.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmLoyaltyMember.Reset()
            RestaurantPOS14.My.MyProject.Forms.frmLoyaltyMember.lblSet.Text = ""
            RestaurantPOS14.My.MyProject.Forms.frmLoyaltyMember.btnUpdate.Visible = True
            RestaurantPOS14.My.MyProject.Forms.frmLoyaltyMember.btnDelete.Visible = True
            Call RestaurantPOS14.My.MyProject.Forms.frmLoyaltyMember.ShowDialog()
        End Sub

        Private Sub btnAddFunds_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmLoyaltySetting.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmLoyaltySetting.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmLoyaltySetting.ShowDialog()
        End Sub

        Private Sub btnPrintCards_Click(sender As Object, e As System.EventArgs)
            Call RestaurantPOS14.My.MyProject.Forms.frmPrintLoyaltyCard.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmPrintLoyaltyCard.ShowDialog()
        End Sub

        Private Sub btnMemberLedger_Click(sender As Object, e As System.EventArgs)
            Call RestaurantPOS14.My.MyProject.Forms.frmLoyaltyCardMemberLedger.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmLoyaltyCardMemberLedger.ShowDialog()
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmLoyaltyCard))
            Me.lblUser = New System.Windows.Forms.Label()
            Me.btnMemberLedger = New System.Windows.Forms.Button()
            Me.btnClose = New System.Windows.Forms.Button()
            Me.btnLoyaltySetting = New System.Windows.Forms.Button()
            Me.btnPrintCards = New System.Windows.Forms.Button()
            Me.btnAddMember = New System.Windows.Forms.Button()
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
            Me.btnMemberLedger.AutoSize = True
            Me.btnMemberLedger.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.btnMemberLedger.FlatAppearance.BorderSize = 0
            Me.btnMemberLedger.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnMemberLedger.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnMemberLedger.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnMemberLedger.Image = CType(componentResourceManager.GetObject("btnMemberLedger.Image"), System.Drawing.Image)
            Me.btnMemberLedger.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Dim button As System.Windows.Forms.Button = Me.btnMemberLedger
            location = New System.Drawing.Point(238, 103)
            button.Location = location
            Me.btnMemberLedger.Name = "btnMemberLedger"
            Dim button2 As System.Windows.Forms.Button = Me.btnMemberLedger
            size = New System.Drawing.Size(217, 65)
            button2.Size = size
            Me.btnMemberLedger.TabIndex = 324
            Me.btnMemberLedger.Text = "Member Ledger"
            Me.btnMemberLedger.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnMemberLedger.UseVisualStyleBackColor = False
            Me.btnClose.BackColor = System.Drawing.Color.Transparent
            Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnClose.FlatAppearance.BorderSize = 0
            Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnClose.Image = CType(componentResourceManager.GetObject("btnClose.Image"), System.Drawing.Image)
            Dim button3 As System.Windows.Forms.Button = Me.btnClose
            location = New System.Drawing.Point(428, -5)
            button3.Location = location
            Me.btnClose.Name = "btnClose"
            Dim button4 As System.Windows.Forms.Button = Me.btnClose
            size = New System.Drawing.Size(37, 36)
            button4.Size = size
            Me.btnClose.TabIndex = 322
            Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnClose.UseVisualStyleBackColor = False
            Me.btnLoyaltySetting.AutoSize = True
            Me.btnLoyaltySetting.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.btnLoyaltySetting.FlatAppearance.BorderSize = 0
            Me.btnLoyaltySetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnLoyaltySetting.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnLoyaltySetting.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnLoyaltySetting.Image = CType(componentResourceManager.GetObject("btnLoyaltySetting.Image"), System.Drawing.Image)
            Me.btnLoyaltySetting.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Dim button5 As System.Windows.Forms.Button = Me.btnLoyaltySetting
            location = New System.Drawing.Point(15, 32)
            button5.Location = location
            Me.btnLoyaltySetting.Name = "btnLoyaltySetting"
            Dim button6 As System.Windows.Forms.Button = Me.btnLoyaltySetting
            size = New System.Drawing.Size(217, 65)
            button6.Size = size
            Me.btnLoyaltySetting.TabIndex = 52
            Me.btnLoyaltySetting.Text = "Loyalty Setting"
            Me.btnLoyaltySetting.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnLoyaltySetting.UseVisualStyleBackColor = False
            Me.btnPrintCards.AutoSize = True
            Me.btnPrintCards.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.btnPrintCards.FlatAppearance.BorderSize = 0
            Me.btnPrintCards.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnPrintCards.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnPrintCards.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnPrintCards.Image = CType(componentResourceManager.GetObject("btnPrintCards.Image"), System.Drawing.Image)
            Me.btnPrintCards.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Dim button7 As System.Windows.Forms.Button = Me.btnPrintCards
            location = New System.Drawing.Point(15, 103)
            button7.Location = location
            Me.btnPrintCards.Name = "btnPrintCards"
            Dim button8 As System.Windows.Forms.Button = Me.btnPrintCards
            size = New System.Drawing.Size(217, 65)
            button8.Size = size
            Me.btnPrintCards.TabIndex = 51
            Me.btnPrintCards.Text = "Print Cards"
            Me.btnPrintCards.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnPrintCards.UseVisualStyleBackColor = False
            Me.btnAddMember.AutoSize = True
            Me.btnAddMember.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.btnAddMember.FlatAppearance.BorderSize = 0
            Me.btnAddMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnAddMember.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnAddMember.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnAddMember.Image = CType(componentResourceManager.GetObject("btnAddMember.Image"), System.Drawing.Image)
            Me.btnAddMember.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Dim button9 As System.Windows.Forms.Button = Me.btnAddMember
            location = New System.Drawing.Point(238, 32)
            button9.Location = location
            Me.btnAddMember.Name = "btnAddMember"
            Dim button10 As System.Windows.Forms.Button = Me.btnAddMember
            size = New System.Drawing.Size(217, 65)
            button10.Size = size
            Me.btnAddMember.TabIndex = 28
            Me.btnAddMember.Text = "Add Member"
            Me.btnAddMember.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnAddMember.UseVisualStyleBackColor = False
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            size = New System.Drawing.Size(462, 185)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.btnMemberLedger)
            MyBase.Controls.Add(Me.btnClose)
            MyBase.Controls.Add(Me.lblUser)
            MyBase.Controls.Add(Me.btnLoyaltySetting)
            MyBase.Controls.Add(Me.btnPrintCards)
            MyBase.Controls.Add(Me.btnAddMember)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            MyBase.Name = "frmLoyaltyCard"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "frmSettings"
            MyBase.ResumeLayout(False)
            MyBase.PerformLayout()
        End Sub
    End Class
End Namespace
