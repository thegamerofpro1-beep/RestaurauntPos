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
    Public Class frmBankReconciliation
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblUser")>
        Private _lblUser As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnClose")>
        Private _btnClose As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnBankMaster")>
        Private _btnBankMaster As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnBranchMaster")>
        Private _btnBranchMaster As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnBankAccountRegistration")>
        Private _btnBankAccountRegistration As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnFundDeposit")>
        Private _btnFundDeposit As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnFundTransfer")>
        Private _btnFundTransfer As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnPayment_Withdrawl")>
        Private _btnPayment_Withdrawl As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnBankAccountStatements")>
        Private _btnBankAccountStatements As System.Windows.Forms.Button

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

        Friend Overridable Property btnBankMaster As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnBankMaster
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnBankMaster_Click
                If Me._btnBankMaster IsNot Nothing Then
                    RemoveHandler Me._btnBankMaster.Click, value2
                End If

                Me._btnBankMaster = value
                If Me._btnBankMaster IsNot Nothing Then
                    AddHandler Me._btnBankMaster.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnBranchMaster As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnBranchMaster
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnBranchMaster_Click
                If Me._btnBranchMaster IsNot Nothing Then
                    RemoveHandler Me._btnBranchMaster.Click, value2
                End If

                Me._btnBranchMaster = value
                If Me._btnBranchMaster IsNot Nothing Then
                    AddHandler Me._btnBranchMaster.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnBankAccountRegistration As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnBankAccountRegistration
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnBankAccountRegistration_Click
                If Me._btnBankAccountRegistration IsNot Nothing Then
                    RemoveHandler Me._btnBankAccountRegistration.Click, value2
                End If

                Me._btnBankAccountRegistration = value
                If Me._btnBankAccountRegistration IsNot Nothing Then
                    AddHandler Me._btnBankAccountRegistration.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnFundDeposit As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnFundDeposit
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnFundDeposit_Click
                If Me._btnFundDeposit IsNot Nothing Then
                    RemoveHandler Me._btnFundDeposit.Click, value2
                End If

                Me._btnFundDeposit = value
                If Me._btnFundDeposit IsNot Nothing Then
                    AddHandler Me._btnFundDeposit.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnFundTransfer As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnFundTransfer
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnFundTransfer_Click
                If Me._btnFundTransfer IsNot Nothing Then
                    RemoveHandler Me._btnFundTransfer.Click, value2
                End If

                Me._btnFundTransfer = value
                If Me._btnFundTransfer IsNot Nothing Then
                    AddHandler Me._btnFundTransfer.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnPayment_Withdrawl As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnPayment_Withdrawl
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnPayment_Withdrawl_Click
                If Me._btnPayment_Withdrawl IsNot Nothing Then
                    RemoveHandler Me._btnPayment_Withdrawl.Click, value2
                End If

                Me._btnPayment_Withdrawl = value
                If Me._btnPayment_Withdrawl IsNot Nothing Then
                    AddHandler Me._btnPayment_Withdrawl.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnBankAccountStatements As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnBankAccountStatements
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnBankAccountStatements_Click
                If Me._btnBankAccountStatements IsNot Nothing Then
                    RemoveHandler Me._btnBankAccountStatements.Click, value2
                End If

                Me._btnBankAccountStatements = value
                If Me._btnBankAccountStatements IsNot Nothing Then
                    AddHandler Me._btnBankAccountStatements.Click, value2
                End If
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            AddHandler MyBase.KeyDown, AddressOf Me.frmBankReconciliation_KeyDown
            Call RestaurantPOS14.frmBankReconciliation.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmBankReconciliation.__ENCList
                If RestaurantPOS14.frmBankReconciliation.__ENCList.Count = RestaurantPOS14.frmBankReconciliation.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmBankReconciliation.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmBankReconciliation.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmBankReconciliation.__ENCList(num) = RestaurantPOS14.frmBankReconciliation.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmBankReconciliation.__ENCList.RemoveRange(num, RestaurantPOS14.frmBankReconciliation.__ENCList.Count - num)
                    RestaurantPOS14.frmBankReconciliation.__ENCList.Capacity = RestaurantPOS14.frmBankReconciliation.__ENCList.Count
                End If

                Call RestaurantPOS14.frmBankReconciliation.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Private Sub btnBankMaster_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmBank.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmBank.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmBank.ShowDialog()
        End Sub

        Private Sub btnBranchMaster_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmBranchMaster_Bank.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmBranchMaster_Bank.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmBranchMaster_Bank.ShowDialog()
        End Sub

        Private Sub btnBankAccountRegistration_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmBankAccountRegistration.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmBankAccountRegistration.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmBankAccountRegistration.ShowDialog()
        End Sub

        Private Sub btnFundDeposit_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmFundDeposit.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmFundDeposit.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmFundDeposit.ShowDialog()
        End Sub

        Private Sub btnFundTransfer_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmFundTransfer.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmFundTransfer.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmFundTransfer.ShowDialog()
        End Sub

        Private Sub btnPayment_Withdrawl_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmPayment_Withdrawal.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmPayment_Withdrawal.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmPayment_Withdrawal.ShowDialog()
        End Sub

        Private Sub btnBankAccountStatements_Click(sender As Object, e As System.EventArgs)
            Call RestaurantPOS14.My.MyProject.Forms.frmBankAccountStatements.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmBankAccountStatements.ShowDialog()
        End Sub

        Private Sub btnClose_Click_1(sender As Object, e As System.EventArgs)
            MyBase.Close()
        End Sub

        Private Sub frmBankReconciliation_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs)
            If e.KeyCode = System.Windows.Forms.Keys.[Return] Then
                MyBase.SelectNextControl(MyBase.ActiveControl, forward:=True, tabStopOnly:=True, nested:=True, wrap:=False)
            End If
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmBankReconciliation))
            Me.lblUser = New System.Windows.Forms.Label()
            Me.btnBranchMaster = New System.Windows.Forms.Button()
            Me.btnBankMaster = New System.Windows.Forms.Button()
            Me.btnBankAccountRegistration = New System.Windows.Forms.Button()
            Me.btnFundDeposit = New System.Windows.Forms.Button()
            Me.btnFundTransfer = New System.Windows.Forms.Button()
            Me.btnPayment_Withdrawl = New System.Windows.Forms.Button()
            Me.btnBankAccountStatements = New System.Windows.Forms.Button()
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
            Me.btnBranchMaster.AutoSize = True
            Me.btnBranchMaster.BackColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.btnBranchMaster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnBranchMaster.FlatAppearance.BorderSize = 0
            Me.btnBranchMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnBranchMaster.Font = New System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnBranchMaster.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnBranchMaster.Image = CType(componentResourceManager.GetObject("btnBranchMaster.Image"), System.Drawing.Image)
            Me.btnBranchMaster.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Dim button As System.Windows.Forms.Button = Me.btnBranchMaster
            location = New System.Drawing.Point(256, 37)
            button.Location = location
            Me.btnBranchMaster.Name = "btnBranchMaster"
            Dim button2 As System.Windows.Forms.Button = Me.btnBranchMaster
            size = New System.Drawing.Size(228, 170)
            button2.Size = size
            Me.btnBranchMaster.TabIndex = 52
            Me.btnBranchMaster.Text = "Branch Master"
            Me.btnBranchMaster.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnBranchMaster.UseVisualStyleBackColor = False
            Me.btnBankMaster.AutoSize = True
            Me.btnBankMaster.BackColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.btnBankMaster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnBankMaster.FlatAppearance.BorderSize = 0
            Me.btnBankMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnBankMaster.Font = New System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnBankMaster.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnBankMaster.Image = CType(componentResourceManager.GetObject("btnBankMaster.Image"), System.Drawing.Image)
            Me.btnBankMaster.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Dim button3 As System.Windows.Forms.Button = Me.btnBankMaster
            location = New System.Drawing.Point(22, 36)
            button3.Location = location
            Me.btnBankMaster.Name = "btnBankMaster"
            Dim button4 As System.Windows.Forms.Button = Me.btnBankMaster
            size = New System.Drawing.Size(228, 170)
            button4.Size = size
            Me.btnBankMaster.TabIndex = 28
            Me.btnBankMaster.Text = "Bank Master"
            Me.btnBankMaster.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnBankMaster.UseVisualStyleBackColor = False
            Me.btnBankAccountRegistration.AutoSize = True
            Me.btnBankAccountRegistration.BackColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.btnBankAccountRegistration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnBankAccountRegistration.FlatAppearance.BorderSize = 0
            Me.btnBankAccountRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnBankAccountRegistration.Font = New System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnBankAccountRegistration.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnBankAccountRegistration.Image = CType(componentResourceManager.GetObject("btnBankAccountRegistration.Image"), System.Drawing.Image)
            Me.btnBankAccountRegistration.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Dim button5 As System.Windows.Forms.Button = Me.btnBankAccountRegistration
            location = New System.Drawing.Point(490, 37)
            button5.Location = location
            Me.btnBankAccountRegistration.Name = "btnBankAccountRegistration"
            Dim button6 As System.Windows.Forms.Button = Me.btnBankAccountRegistration
            size = New System.Drawing.Size(329, 170)
            button6.Size = size
            Me.btnBankAccountRegistration.TabIndex = 323
            Me.btnBankAccountRegistration.Text = "Bank Account Registration"
            Me.btnBankAccountRegistration.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnBankAccountRegistration.UseVisualStyleBackColor = False
            Me.btnFundDeposit.AutoSize = True
            Me.btnFundDeposit.BackColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.btnFundDeposit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnFundDeposit.FlatAppearance.BorderSize = 0
            Me.btnFundDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnFundDeposit.Font = New System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnFundDeposit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnFundDeposit.Image = CType(componentResourceManager.GetObject("btnFundDeposit.Image"), System.Drawing.Image)
            Me.btnFundDeposit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Dim button7 As System.Windows.Forms.Button = Me.btnFundDeposit
            location = New System.Drawing.Point(256, 213)
            button7.Location = location
            Me.btnFundDeposit.Name = "btnFundDeposit"
            Dim button8 As System.Windows.Forms.Button = Me.btnFundDeposit
            size = New System.Drawing.Size(228, 170)
            button8.Size = size
            Me.btnFundDeposit.TabIndex = 324
            Me.btnFundDeposit.Text = "Fund Deposit"
            Me.btnFundDeposit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnFundDeposit.UseVisualStyleBackColor = False
            Me.btnFundTransfer.AutoSize = True
            Me.btnFundTransfer.BackColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.btnFundTransfer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnFundTransfer.FlatAppearance.BorderSize = 0
            Me.btnFundTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnFundTransfer.Font = New System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnFundTransfer.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnFundTransfer.Image = CType(componentResourceManager.GetObject("btnFundTransfer.Image"), System.Drawing.Image)
            Me.btnFundTransfer.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Dim button9 As System.Windows.Forms.Button = Me.btnFundTransfer
            location = New System.Drawing.Point(22, 212)
            button9.Location = location
            Me.btnFundTransfer.Name = "btnFundTransfer"
            Dim button10 As System.Windows.Forms.Button = Me.btnFundTransfer
            size = New System.Drawing.Size(228, 170)
            button10.Size = size
            Me.btnFundTransfer.TabIndex = 325
            Me.btnFundTransfer.Text = "Fund Transfer"
            Me.btnFundTransfer.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnFundTransfer.UseVisualStyleBackColor = False
            Me.btnPayment_Withdrawl.AutoSize = True
            Me.btnPayment_Withdrawl.BackColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.btnPayment_Withdrawl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnPayment_Withdrawl.FlatAppearance.BorderSize = 0
            Me.btnPayment_Withdrawl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnPayment_Withdrawl.Font = New System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnPayment_Withdrawl.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnPayment_Withdrawl.Image = CType(componentResourceManager.GetObject("btnPayment_Withdrawl.Image"), System.Drawing.Image)
            Me.btnPayment_Withdrawl.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Dim button11 As System.Windows.Forms.Button = Me.btnPayment_Withdrawl
            location = New System.Drawing.Point(490, 212)
            button11.Location = location
            Me.btnPayment_Withdrawl.Name = "btnPayment_Withdrawl"
            Dim button12 As System.Windows.Forms.Button = Me.btnPayment_Withdrawl
            size = New System.Drawing.Size(329, 170)
            button12.Size = size
            Me.btnPayment_Withdrawl.TabIndex = 326
            Me.btnPayment_Withdrawl.Text = "Payment/Withdrawal"
            Me.btnPayment_Withdrawl.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnPayment_Withdrawl.UseVisualStyleBackColor = False
            Me.btnBankAccountStatements.AutoSize = True
            Me.btnBankAccountStatements.BackColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.btnBankAccountStatements.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnBankAccountStatements.FlatAppearance.BorderSize = 0
            Me.btnBankAccountStatements.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnBankAccountStatements.Font = New System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnBankAccountStatements.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnBankAccountStatements.Image = CType(componentResourceManager.GetObject("btnBankAccountStatements.Image"), System.Drawing.Image)
            Me.btnBankAccountStatements.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Dim button13 As System.Windows.Forms.Button = Me.btnBankAccountStatements
            location = New System.Drawing.Point(22, 389)
            button13.Location = location
            Me.btnBankAccountStatements.Name = "btnBankAccountStatements"
            Dim button14 As System.Windows.Forms.Button = Me.btnBankAccountStatements
            size = New System.Drawing.Size(797, 170)
            button14.Size = size
            Me.btnBankAccountStatements.TabIndex = 327
            Me.btnBankAccountStatements.Text = "Bank Account Statements"
            Me.btnBankAccountStatements.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnBankAccountStatements.UseVisualStyleBackColor = False
            Me.btnClose.BackColor = System.Drawing.Color.Transparent
            Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnClose.FlatAppearance.BorderSize = 0
            Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnClose.Image = CType(componentResourceManager.GetObject("btnClose.Image"), System.Drawing.Image)
            Dim button15 As System.Windows.Forms.Button = Me.btnClose
            location = New System.Drawing.Point(782, 1)
            button15.Location = location
            Me.btnClose.Name = "btnClose"
            Dim button16 As System.Windows.Forms.Button = Me.btnClose
            size = New System.Drawing.Size(37, 32)
            button16.Size = size
            Me.btnClose.TabIndex = 328
            Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnClose.UseVisualStyleBackColor = False
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            size = New System.Drawing.Size(833, 575)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.btnClose)
            MyBase.Controls.Add(Me.btnBankAccountStatements)
            MyBase.Controls.Add(Me.btnPayment_Withdrawl)
            MyBase.Controls.Add(Me.btnFundTransfer)
            MyBase.Controls.Add(Me.btnFundDeposit)
            MyBase.Controls.Add(Me.btnBankAccountRegistration)
            MyBase.Controls.Add(Me.lblUser)
            MyBase.Controls.Add(Me.btnBranchMaster)
            MyBase.Controls.Add(Me.btnBankMaster)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            MyBase.KeyPreview = True
            MyBase.Name = "frmBankReconciliation"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "frmSettings"
            MyBase.ResumeLayout(False)
            MyBase.PerformLayout()
        End Sub
    End Class
End Namespace
