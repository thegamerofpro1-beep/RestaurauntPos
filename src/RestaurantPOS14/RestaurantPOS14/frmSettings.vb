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
    Public Class frmSettings
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnTerminalSetting")>
        Private _btnTerminalSetting As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnOtherCharges")>
        Private _btnOtherCharges As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnEmailSetting")>
        Private _btnEmailSetting As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblUser")>
        Private _lblUser As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Button1")>
        Private _Button1 As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnExpenseType")>
        Private _btnExpenseType As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnExpenses")>
        Private _btnExpenses As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnUnit")>
        Private _btnUnit As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnCategoryMaster")>
        Private _btnCategoryMaster As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnNotes")>
        Private _btnNotes As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnWorkPeriod")>
        Private _btnWorkPeriod As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnWarehouseType")>
        Private _btnWarehouseType As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnWarehouse")>
        Private _btnWarehouse As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnTableLayout")>
        Private _btnTableLayout As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnPromotion")>
        Private _btnPromotion As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnEQ")>
        Private _btnEQ As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnWallet")>
        Private _btnWallet As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnUserRights")>
        Private _btnUserRights As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnClose")>
        Private _btnClose As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnTablesAssign")>
        Private _btnTablesAssign As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnMI")>
        Private _btnMI As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnMpesaSetting")>
        Private _btnMpesaSetting As CButtonLib.CButton

        Private components As System.ComponentModel.IContainer

        Friend Overridable Property btnTerminalSetting As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnTerminalSetting
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnPrinterSetting_Click
                If Me._btnTerminalSetting IsNot Nothing Then
                    RemoveHandler Me._btnTerminalSetting.Click, value2
                End If

                Me._btnTerminalSetting = value
                If Me._btnTerminalSetting IsNot Nothing Then
                    AddHandler Me._btnTerminalSetting.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnOtherCharges As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnOtherCharges
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnOtherCharges_Click
                If Me._btnOtherCharges IsNot Nothing Then
                    RemoveHandler Me._btnOtherCharges.Click, value2
                End If

                Me._btnOtherCharges = value
                If Me._btnOtherCharges IsNot Nothing Then
                    AddHandler Me._btnOtherCharges.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnEmailSetting As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnEmailSetting
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnEmailSetting_Click
                If Me._btnEmailSetting IsNot Nothing Then
                    RemoveHandler Me._btnEmailSetting.Click, value2
                End If

                Me._btnEmailSetting = value
                If Me._btnEmailSetting IsNot Nothing Then
                    AddHandler Me._btnEmailSetting.Click, value2
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

        Friend Overridable Property Button1 As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Button1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.Button1_Click
                If Me._Button1 IsNot Nothing Then
                    RemoveHandler Me._Button1.Click, value2
                End If

                Me._Button1 = value
                If Me._Button1 IsNot Nothing Then
                    AddHandler Me._Button1.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnExpenseType As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnExpenseType
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnExpenseType_Click
                If Me._btnExpenseType IsNot Nothing Then
                    RemoveHandler Me._btnExpenseType.Click, value2
                End If

                Me._btnExpenseType = value
                If Me._btnExpenseType IsNot Nothing Then
                    AddHandler Me._btnExpenseType.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnExpenses As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnExpenses
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnExpenses_Click
                If Me._btnExpenses IsNot Nothing Then
                    RemoveHandler Me._btnExpenses.Click, value2
                End If

                Me._btnExpenses = value
                If Me._btnExpenses IsNot Nothing Then
                    AddHandler Me._btnExpenses.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnUnit As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnUnit
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnUnit_Click
                If Me._btnUnit IsNot Nothing Then
                    RemoveHandler Me._btnUnit.Click, value2
                End If

                Me._btnUnit = value
                If Me._btnUnit IsNot Nothing Then
                    AddHandler Me._btnUnit.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnCategoryMaster As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnCategoryMaster
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnCategoryMaster_Click
                If Me._btnCategoryMaster IsNot Nothing Then
                    RemoveHandler Me._btnCategoryMaster.Click, value2
                End If

                Me._btnCategoryMaster = value
                If Me._btnCategoryMaster IsNot Nothing Then
                    AddHandler Me._btnCategoryMaster.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnNotes As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnNotes
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnNotes_Click
                If Me._btnNotes IsNot Nothing Then
                    RemoveHandler Me._btnNotes.Click, value2
                End If

                Me._btnNotes = value
                If Me._btnNotes IsNot Nothing Then
                    AddHandler Me._btnNotes.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnWorkPeriod As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnWorkPeriod
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnWorkPeriod_Click
                If Me._btnWorkPeriod IsNot Nothing Then
                    RemoveHandler Me._btnWorkPeriod.Click, value2
                End If

                Me._btnWorkPeriod = value
                If Me._btnWorkPeriod IsNot Nothing Then
                    AddHandler Me._btnWorkPeriod.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnWarehouseType As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnWarehouseType
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnWarehouseType_Click
                If Me._btnWarehouseType IsNot Nothing Then
                    RemoveHandler Me._btnWarehouseType.Click, value2
                End If

                Me._btnWarehouseType = value
                If Me._btnWarehouseType IsNot Nothing Then
                    AddHandler Me._btnWarehouseType.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnWarehouse As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnWarehouse
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnWarehouse_Click
                If Me._btnWarehouse IsNot Nothing Then
                    RemoveHandler Me._btnWarehouse.Click, value2
                End If

                Me._btnWarehouse = value
                If Me._btnWarehouse IsNot Nothing Then
                    AddHandler Me._btnWarehouse.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnTableLayout As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnTableLayout
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnTableLayout_Click
                If Me._btnTableLayout IsNot Nothing Then
                    RemoveHandler Me._btnTableLayout.Click, value2
                End If

                Me._btnTableLayout = value
                If Me._btnTableLayout IsNot Nothing Then
                    AddHandler Me._btnTableLayout.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnPromotion As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnPromotion
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnPromotion_Click
                If Me._btnPromotion IsNot Nothing Then
                    RemoveHandler Me._btnPromotion.Click, value2
                End If

                Me._btnPromotion = value
                If Me._btnPromotion IsNot Nothing Then
                    AddHandler Me._btnPromotion.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnEQ As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnEQ
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnEQ_Click
                If Me._btnEQ IsNot Nothing Then
                    RemoveHandler Me._btnEQ.Click, value2
                End If

                Me._btnEQ = value
                If Me._btnEQ IsNot Nothing Then
                    AddHandler Me._btnEQ.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnWallet As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnWallet
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnWallet_Click
                If Me._btnWallet IsNot Nothing Then
                    RemoveHandler Me._btnWallet.Click, value2
                End If

                Me._btnWallet = value
                If Me._btnWallet IsNot Nothing Then
                    AddHandler Me._btnWallet.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnUserRights As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnUserRights
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnUserRights_Click
                If Me._btnUserRights IsNot Nothing Then
                    RemoveHandler Me._btnUserRights.Click, value2
                End If

                Me._btnUserRights = value
                If Me._btnUserRights IsNot Nothing Then
                    AddHandler Me._btnUserRights.Click, value2
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

        Friend Overridable Property btnTablesAssign As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnTablesAssign
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim obj As CButtonLib.CButton.ClickButtonAreaEventHandler = AddressOf Me.btnTablesAssign_ClickButtonArea
                If Me._btnTablesAssign IsNot Nothing Then
                    RemoveHandler Me._btnTablesAssign.ClickButtonArea, obj
                End If

                Me._btnTablesAssign = value
                If Me._btnTablesAssign IsNot Nothing Then
                    AddHandler Me._btnTablesAssign.ClickButtonArea, obj
                End If
            End Set
        End Property

        Friend Overridable Property btnMI As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnMI
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim obj As CButtonLib.CButton.ClickButtonAreaEventHandler = AddressOf Me.btnMI_ClickButtonArea
                If Me._btnMI IsNot Nothing Then
                    RemoveHandler Me._btnMI.ClickButtonArea, obj
                End If

                Me._btnMI = value
                If Me._btnMI IsNot Nothing Then
                    AddHandler Me._btnMI.ClickButtonArea, obj
                End If
            End Set
        End Property

        Friend Overridable Property btnMpesaSetting As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnMpesaSetting
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim obj As CButtonLib.CButton.ClickButtonAreaEventHandler = AddressOf Me.btnMpesaSetting_ClickButtonArea
                If Me._btnMpesaSetting IsNot Nothing Then
                    RemoveHandler Me._btnMpesaSetting.ClickButtonArea, obj
                End If

                Me._btnMpesaSetting = value
                If Me._btnMpesaSetting IsNot Nothing Then
                    AddHandler Me._btnMpesaSetting.ClickButtonArea, obj
                End If
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            Call RestaurantPOS14.frmSettings.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmSettings.__ENCList
                If RestaurantPOS14.frmSettings.__ENCList.Count = RestaurantPOS14.frmSettings.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmSettings.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmSettings.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmSettings.__ENCList(num) = RestaurantPOS14.frmSettings.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmSettings.__ENCList.RemoveRange(num, RestaurantPOS14.frmSettings.__ENCList.Count - num)
                    RestaurantPOS14.frmSettings.__ENCList.Capacity = RestaurantPOS14.frmSettings.__ENCList.Count
                End If

                Call RestaurantPOS14.frmSettings.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Private Sub btnPrinterSetting_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmTerminalSetting.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmTerminalSetting.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmTerminalSetting.ShowDialog()
        End Sub

        Private Sub btnOtherCharges_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmOthersSetting.lblUser.Text = Me.lblUser.Text
            RestaurantPOS14.My.MyProject.Forms.frmOthersSetting.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmOthersSetting.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmOthersSetting.ShowDialog()
        End Sub

        Private Sub btnEmailSetting_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmEmailSetting.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmEmailSetting.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmEmailSetting.ShowDialog()
        End Sub

        Private Sub Button1_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmSMSSetting.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmSMSSetting.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmSMSSetting.ShowDialog()
        End Sub

        Private Sub btnExpenseType_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmExpenseType.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmExpenseType.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmExpenseType.ShowDialog()
        End Sub

        Private Sub btnExpenses_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmExpense.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmExpense.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmExpense.ShowDialog()
        End Sub

        Private Sub btnUnit_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmUnit.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmUnit.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmUnit.ShowDialog()
        End Sub

        Private Sub btnCategoryMaster_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmRawMaterialsCategory.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmRawMaterialsCategory.Reset()
            RestaurantPOS14.My.MyProject.Forms.frmRawMaterialsCategory.lblSet.Text = ""
            Call RestaurantPOS14.My.MyProject.Forms.frmRawMaterialsCategory.ShowDialog()
        End Sub

        Private Sub btnNotes_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmNotesMaster.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmNotesMaster.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmNotesMaster.ShowDialog()
        End Sub

        Private Sub btnWorkPeriod_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmWorkPeriod_Del.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmWorkPeriod_Del.ShowDialog()
        End Sub

        Private Sub btnWarehouseType_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmWarehouseType.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmWarehouseType.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmWarehouseType.ShowDialog()
        End Sub

        Private Sub btnWarehouse_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmWarehouse.lblUser.Text = Me.lblUser.Text
            RestaurantPOS14.My.MyProject.Forms.frmWarehouse.lblSet.Text = ""
            Call RestaurantPOS14.My.MyProject.Forms.frmWarehouse.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmWarehouse.ShowDialog()
        End Sub

        Private Sub btnTableLayout_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmTableLayoutSettings.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmTableLayoutSettings.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmTableLayoutSettings.ShowDialog()
        End Sub

        Private Sub btnPromotion_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmPromotion.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmPromotion.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmPromotion.ShowDialog()
        End Sub

        Private Sub btnEQ_Click(sender As Object, e As System.EventArgs)
            Call RestaurantPOS14.My.MyProject.Forms.frmExecuteQuery.ShowDialog()
        End Sub

        Private Sub btnWallet_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmWalletType.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmWalletType.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmWalletType.ShowDialog()
        End Sub

        Private Sub btnUserRights_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmUserRights.lblUser.Text = Me.lblUser.Text
            RestaurantPOS14.My.MyProject.Forms.frmUserRights.cmbUserID.SelectedIndex = -1
            RestaurantPOS14.My.MyProject.Forms.frmUserRights.txtName.Text = ""
            RestaurantPOS14.My.MyProject.Forms.frmUserRights.txtUserType.Text = ""
            Call RestaurantPOS14.My.MyProject.Forms.frmUserRights.ShowDialog()
        End Sub

        Private Sub btnClose_Click_1(sender As Object, e As System.EventArgs)
            MyBase.Close()
        End Sub

        Private Sub btnTablesAssign_ClickButtonArea(Sender As Object, e As System.Windows.Forms.MouseEventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmTableMapping_Waiter.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmTableMapping_Waiter.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmTableMapping_Waiter.ShowDialog()
        End Sub

        Private Sub btnMI_ClickButtonArea(Sender As Object, e As System.Windows.Forms.MouseEventArgs)
            Call RestaurantPOS14.My.MyProject.Forms.frmCMISetting.ShowDialog()
        End Sub

        Private Sub btnMpesaSetting_ClickButtonArea(Sender As Object, e As System.Windows.Forms.MouseEventArgs)
            Call RestaurantPOS14.My.MyProject.Forms.frmMpesaSetting.ShowDialog()
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmSettings))
            Dim cBlendItems2 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems3 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems4 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems5 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems6 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems7 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems8 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems9 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems10 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems11 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems12 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems13 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems14 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems15 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems16 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems17 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems18 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems19 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems20 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Me.lblUser = New System.Windows.Forms.Label()
            Me.btnTablesAssign = New CButtonLib.CButton()
            Me.btnClose = New System.Windows.Forms.Button()
            Me.btnUserRights = New CButtonLib.CButton()
            Me.btnWallet = New CButtonLib.CButton()
            Me.btnEQ = New CButtonLib.CButton()
            Me.btnPromotion = New CButtonLib.CButton()
            Me.btnTableLayout = New CButtonLib.CButton()
            Me.btnWarehouse = New CButtonLib.CButton()
            Me.btnWarehouseType = New CButtonLib.CButton()
            Me.btnWorkPeriod = New CButtonLib.CButton()
            Me.btnNotes = New CButtonLib.CButton()
            Me.btnExpenses = New CButtonLib.CButton()
            Me.btnCategoryMaster = New CButtonLib.CButton()
            Me.btnUnit = New CButtonLib.CButton()
            Me.btnExpenseType = New CButtonLib.CButton()
            Me.Button1 = New CButtonLib.CButton()
            Me.btnEmailSetting = New CButtonLib.CButton()
            Me.btnOtherCharges = New CButtonLib.CButton()
            Me.btnTerminalSetting = New CButtonLib.CButton()
            Me.btnMI = New CButtonLib.CButton()
            Me.btnMpesaSetting = New CButtonLib.CButton()
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
            Me.btnTablesAssign.BackColor = System.Drawing.Color.Transparent
            Me.btnTablesAssign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnTablesAssign.BorderColor = System.Drawing.Color.Transparent
            cBlendItems.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnTablesAssign.ColorFillBlend = cBlendItems
            Me.btnTablesAssign.Corners.All = 3
            Me.btnTablesAssign.Corners.LowerLeft = 3
            Me.btnTablesAssign.Corners.LowerRight = 3
            Me.btnTablesAssign.Corners.UpperLeft = 3
            Me.btnTablesAssign.Corners.UpperRight = 3
            Me.btnTablesAssign.DesignerSelected = False
            Me.btnTablesAssign.Font = New System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnTablesAssign.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnTablesAssign.Image = CType(componentResourceManager.GetObject("btnTablesAssign.Image"), System.Drawing.Image)
            Me.btnTablesAssign.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnTablesAssign.ImageIndex = 0
            Dim cButton As CButtonLib.CButton = Me.btnTablesAssign
            size = New System.Drawing.Size(100, 100)
            cButton.ImageSize = size
            Dim cButton2 As CButtonLib.CButton = Me.btnTablesAssign
            location = New System.Drawing.Point(235, 416)
            cButton2.Location = location
            Me.btnTablesAssign.Name = "btnTablesAssign"
            Dim cButton3 As CButtonLib.CButton = Me.btnTablesAssign
            size = New System.Drawing.Size(217, 122)
            cButton3.Size = size
            Me.btnTablesAssign.TabIndex = 341
            Me.btnTablesAssign.Text = "Tables Assign"
            Me.btnTablesAssign.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnTablesAssign.TextShadowShow = False
            Me.btnTablesAssign.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnClose.BackColor = System.Drawing.Color.Transparent
            Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnClose.FlatAppearance.BorderSize = 0
            Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnClose.Image = CType(componentResourceManager.GetObject("btnClose.Image"), System.Drawing.Image)
            Dim button As System.Windows.Forms.Button = Me.btnClose
            location = New System.Drawing.Point(875, -3)
            button.Location = location
            Me.btnClose.Name = "btnClose"
            Dim button2 As System.Windows.Forms.Button = Me.btnClose
            size = New System.Drawing.Size(37, 36)
            button2.Size = size
            Me.btnClose.TabIndex = 340
            Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnClose.UseVisualStyleBackColor = False
            Me.btnUserRights.BackColor = System.Drawing.Color.Transparent
            Me.btnUserRights.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnUserRights.BorderColor = System.Drawing.Color.Transparent
            cBlendItems2.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems2.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnUserRights.ColorFillBlend = cBlendItems2
            Me.btnUserRights.Corners.All = 3
            Me.btnUserRights.Corners.LowerLeft = 3
            Me.btnUserRights.Corners.LowerRight = 3
            Me.btnUserRights.Corners.UpperLeft = 3
            Me.btnUserRights.Corners.UpperRight = 3
            Me.btnUserRights.DesignerSelected = False
            Me.btnUserRights.Font = New System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnUserRights.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnUserRights.Image = CType(componentResourceManager.GetObject("btnUserRights.Image"), System.Drawing.Image)
            Me.btnUserRights.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnUserRights.ImageIndex = 0
            Dim cButton4 As CButtonLib.CButton = Me.btnUserRights
            size = New System.Drawing.Size(100, 100)
            cButton4.ImageSize = size
            Dim cButton5 As CButtonLib.CButton = Me.btnUserRights
            location = New System.Drawing.Point(12, 548)
            cButton5.Location = location
            Me.btnUserRights.Name = "btnUserRights"
            Dim cButton6 As CButtonLib.CButton = Me.btnUserRights
            size = New System.Drawing.Size(217, 122)
            cButton6.Size = size
            Me.btnUserRights.TabIndex = 339
            Me.btnUserRights.Text = "User Rights"
            Me.btnUserRights.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnUserRights.TextShadowShow = False
            Me.btnUserRights.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnWallet.BackColor = System.Drawing.Color.Transparent
            Me.btnWallet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnWallet.BorderColor = System.Drawing.Color.Transparent
            cBlendItems3.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems3.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnWallet.ColorFillBlend = cBlendItems3
            Me.btnWallet.Corners.All = 3
            Me.btnWallet.Corners.LowerLeft = 3
            Me.btnWallet.Corners.LowerRight = 3
            Me.btnWallet.Corners.UpperLeft = 3
            Me.btnWallet.Corners.UpperRight = 3
            Me.btnWallet.DesignerSelected = False
            Me.btnWallet.Font = New System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnWallet.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnWallet.Image = CType(componentResourceManager.GetObject("btnWallet.Image"), System.Drawing.Image)
            Me.btnWallet.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnWallet.ImageIndex = 0
            Dim cButton7 As CButtonLib.CButton = Me.btnWallet
            size = New System.Drawing.Size(100, 100)
            cButton7.ImageSize = size
            Dim cButton8 As CButtonLib.CButton = Me.btnWallet
            location = New System.Drawing.Point(681, 416)
            cButton8.Location = location
            Me.btnWallet.Name = "btnWallet"
            Dim cButton9 As CButtonLib.CButton = Me.btnWallet
            size = New System.Drawing.Size(217, 121)
            cButton9.Size = size
            Me.btnWallet.TabIndex = 338
            Me.btnWallet.Text = "Wallet"
            Me.btnWallet.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnWallet.TextShadowShow = False
            Me.btnWallet.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnEQ.BackColor = System.Drawing.Color.Transparent
            Me.btnEQ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnEQ.BorderColor = System.Drawing.Color.Transparent
            cBlendItems4.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems4.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnEQ.ColorFillBlend = cBlendItems4
            Me.btnEQ.Corners.All = 3
            Me.btnEQ.Corners.LowerLeft = 3
            Me.btnEQ.Corners.LowerRight = 3
            Me.btnEQ.Corners.UpperLeft = 3
            Me.btnEQ.Corners.UpperRight = 3
            Me.btnEQ.DesignerSelected = False
            Me.btnEQ.Font = New System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnEQ.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnEQ.Image = CType(componentResourceManager.GetObject("btnEQ.Image"), System.Drawing.Image)
            Me.btnEQ.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnEQ.ImageIndex = 0
            Dim cButton10 As CButtonLib.CButton = Me.btnEQ
            size = New System.Drawing.Size(100, 100)
            cButton10.ImageSize = size
            Dim cButton11 As CButtonLib.CButton = Me.btnEQ
            location = New System.Drawing.Point(681, 543)
            cButton11.Location = location
            Me.btnEQ.Name = "btnEQ"
            Dim cButton12 As CButtonLib.CButton = Me.btnEQ
            size = New System.Drawing.Size(217, 122)
            cButton12.Size = size
            Me.btnEQ.TabIndex = 337
            Me.btnEQ.Text = "Execute Query"
            Me.btnEQ.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnEQ.TextShadowShow = False
            Me.btnEQ.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnPromotion.BackColor = System.Drawing.Color.Transparent
            Me.btnPromotion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnPromotion.BorderColor = System.Drawing.Color.Transparent
            cBlendItems5.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems5.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnPromotion.ColorFillBlend = cBlendItems5
            Me.btnPromotion.Corners.All = 3
            Me.btnPromotion.Corners.LowerLeft = 3
            Me.btnPromotion.Corners.LowerRight = 3
            Me.btnPromotion.Corners.UpperLeft = 3
            Me.btnPromotion.Corners.UpperRight = 3
            Me.btnPromotion.DesignerSelected = False
            Me.btnPromotion.Font = New System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnPromotion.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnPromotion.Image = CType(componentResourceManager.GetObject("btnPromotion.Image"), System.Drawing.Image)
            Me.btnPromotion.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnPromotion.ImageIndex = 0
            Dim cButton13 As CButtonLib.CButton = Me.btnPromotion
            size = New System.Drawing.Size(100, 100)
            cButton13.ImageSize = size
            Dim cButton14 As CButtonLib.CButton = Me.btnPromotion
            location = New System.Drawing.Point(458, 417)
            cButton14.Location = location
            Me.btnPromotion.Name = "btnPromotion"
            Dim cButton15 As CButtonLib.CButton = Me.btnPromotion
            size = New System.Drawing.Size(217, 121)
            cButton15.Size = size
            Me.btnPromotion.TabIndex = 336
            Me.btnPromotion.Text = "Promotion"
            Me.btnPromotion.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnPromotion.TextShadowShow = False
            Me.btnPromotion.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnTableLayout.BackColor = System.Drawing.Color.Transparent
            Me.btnTableLayout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnTableLayout.BorderColor = System.Drawing.Color.Transparent
            cBlendItems6.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems6.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnTableLayout.ColorFillBlend = cBlendItems6
            Me.btnTableLayout.Corners.All = 3
            Me.btnTableLayout.Corners.LowerLeft = 3
            Me.btnTableLayout.Corners.LowerRight = 3
            Me.btnTableLayout.Corners.UpperLeft = 3
            Me.btnTableLayout.Corners.UpperRight = 3
            Me.btnTableLayout.DesignerSelected = False
            Me.btnTableLayout.Font = New System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnTableLayout.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnTableLayout.Image = CType(componentResourceManager.GetObject("btnTableLayout.Image"), System.Drawing.Image)
            Me.btnTableLayout.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnTableLayout.ImageIndex = 0
            Dim cButton16 As CButtonLib.CButton = Me.btnTableLayout
            size = New System.Drawing.Size(100, 100)
            cButton16.ImageSize = size
            Dim cButton17 As CButtonLib.CButton = Me.btnTableLayout
            location = New System.Drawing.Point(12, 416)
            cButton17.Location = location
            Me.btnTableLayout.Name = "btnTableLayout"
            Dim cButton18 As CButtonLib.CButton = Me.btnTableLayout
            size = New System.Drawing.Size(217, 122)
            cButton18.Size = size
            Me.btnTableLayout.TabIndex = 334
            Me.btnTableLayout.Text = "Tables Layout"
            Me.btnTableLayout.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnTableLayout.TextShadowShow = False
            Me.btnTableLayout.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnWarehouse.BackColor = System.Drawing.Color.Transparent
            Me.btnWarehouse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnWarehouse.BorderColor = System.Drawing.Color.Transparent
            cBlendItems7.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems7.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnWarehouse.ColorFillBlend = cBlendItems7
            Me.btnWarehouse.Corners.All = 3
            Me.btnWarehouse.Corners.LowerLeft = 3
            Me.btnWarehouse.Corners.LowerRight = 3
            Me.btnWarehouse.Corners.UpperLeft = 3
            Me.btnWarehouse.Corners.UpperRight = 3
            Me.btnWarehouse.DesignerSelected = False
            Me.btnWarehouse.Font = New System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnWarehouse.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnWarehouse.Image = CType(componentResourceManager.GetObject("btnWarehouse.Image"), System.Drawing.Image)
            Me.btnWarehouse.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnWarehouse.ImageIndex = 0
            Dim cButton19 As CButtonLib.CButton = Me.btnWarehouse
            size = New System.Drawing.Size(100, 100)
            cButton19.ImageSize = size
            Dim cButton20 As CButtonLib.CButton = Me.btnWarehouse
            location = New System.Drawing.Point(681, 161)
            cButton20.Location = location
            Me.btnWarehouse.Name = "btnWarehouse"
            Dim cButton21 As CButtonLib.CButton = Me.btnWarehouse
            size = New System.Drawing.Size(217, 122)
            cButton21.Size = size
            Me.btnWarehouse.TabIndex = 332
            Me.btnWarehouse.Text = "Warehouse"
            Me.btnWarehouse.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnWarehouse.TextShadowShow = False
            Me.btnWarehouse.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnWarehouseType.BackColor = System.Drawing.Color.Transparent
            Me.btnWarehouseType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnWarehouseType.BorderColor = System.Drawing.Color.Transparent
            cBlendItems8.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems8.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnWarehouseType.ColorFillBlend = cBlendItems8
            Me.btnWarehouseType.Corners.All = 3
            Me.btnWarehouseType.Corners.LowerLeft = 3
            Me.btnWarehouseType.Corners.LowerRight = 3
            Me.btnWarehouseType.Corners.UpperLeft = 3
            Me.btnWarehouseType.Corners.UpperRight = 3
            Me.btnWarehouseType.DesignerSelected = False
            Me.btnWarehouseType.Font = New System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnWarehouseType.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnWarehouseType.Image = CType(componentResourceManager.GetObject("btnWarehouseType.Image"), System.Drawing.Image)
            Me.btnWarehouseType.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnWarehouseType.ImageIndex = 0
            Dim cButton22 As CButtonLib.CButton = Me.btnWarehouseType
            size = New System.Drawing.Size(100, 100)
            cButton22.ImageSize = size
            Dim cButton23 As CButtonLib.CButton = Me.btnWarehouseType
            location = New System.Drawing.Point(458, 161)
            cButton23.Location = location
            Me.btnWarehouseType.Name = "btnWarehouseType"
            Dim cButton24 As CButtonLib.CButton = Me.btnWarehouseType
            size = New System.Drawing.Size(217, 122)
            cButton24.Size = size
            Me.btnWarehouseType.TabIndex = 331
            Me.btnWarehouseType.Text = "Warehouse Type"
            Me.btnWarehouseType.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnWarehouseType.TextShadowShow = False
            Me.btnWarehouseType.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnWorkPeriod.BackColor = System.Drawing.Color.Transparent
            Me.btnWorkPeriod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnWorkPeriod.BorderColor = System.Drawing.Color.Transparent
            cBlendItems9.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems9.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnWorkPeriod.ColorFillBlend = cBlendItems9
            Me.btnWorkPeriod.Corners.All = 3
            Me.btnWorkPeriod.Corners.LowerLeft = 3
            Me.btnWorkPeriod.Corners.LowerRight = 3
            Me.btnWorkPeriod.Corners.UpperLeft = 3
            Me.btnWorkPeriod.Corners.UpperRight = 3
            Me.btnWorkPeriod.DesignerSelected = False
            Me.btnWorkPeriod.Font = New System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnWorkPeriod.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnWorkPeriod.Image = CType(componentResourceManager.GetObject("btnWorkPeriod.Image"), System.Drawing.Image)
            Me.btnWorkPeriod.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnWorkPeriod.ImageIndex = 0
            Dim cButton25 As CButtonLib.CButton = Me.btnWorkPeriod
            size = New System.Drawing.Size(100, 100)
            cButton25.ImageSize = size
            Dim cButton26 As CButtonLib.CButton = Me.btnWorkPeriod
            location = New System.Drawing.Point(681, 288)
            cButton26.Location = location
            Me.btnWorkPeriod.Name = "btnWorkPeriod"
            Dim cButton27 As CButtonLib.CButton = Me.btnWorkPeriod
            size = New System.Drawing.Size(217, 122)
            cButton27.Size = size
            Me.btnWorkPeriod.TabIndex = 330
            Me.btnWorkPeriod.Text = "Work Period"
            Me.btnWorkPeriod.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnWorkPeriod.TextShadowShow = False
            Me.btnWorkPeriod.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnNotes.BackColor = System.Drawing.Color.Transparent
            Me.btnNotes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnNotes.BorderColor = System.Drawing.Color.Transparent
            cBlendItems10.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems10.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnNotes.ColorFillBlend = cBlendItems10
            Me.btnNotes.Corners.All = 3
            Me.btnNotes.Corners.LowerLeft = 3
            Me.btnNotes.Corners.LowerRight = 3
            Me.btnNotes.Corners.UpperLeft = 3
            Me.btnNotes.Corners.UpperRight = 3
            Me.btnNotes.DesignerSelected = False
            Me.btnNotes.Font = New System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnNotes.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnNotes.Image = CType(componentResourceManager.GetObject("btnNotes.Image"), System.Drawing.Image)
            Me.btnNotes.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnNotes.ImageIndex = 0
            Dim cButton28 As CButtonLib.CButton = Me.btnNotes
            size = New System.Drawing.Size(100, 100)
            cButton28.ImageSize = size
            Dim cButton29 As CButtonLib.CButton = Me.btnNotes
            location = New System.Drawing.Point(12, 288)
            cButton29.Location = location
            Me.btnNotes.Name = "btnNotes"
            Dim cButton30 As CButtonLib.CButton = Me.btnNotes
            size = New System.Drawing.Size(217, 122)
            cButton30.Size = size
            Me.btnNotes.TabIndex = 329
            Me.btnNotes.Text = "Notes Master"
            Me.btnNotes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnNotes.TextShadowShow = False
            Me.btnNotes.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnExpenses.BackColor = System.Drawing.Color.Transparent
            Me.btnExpenses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnExpenses.BorderColor = System.Drawing.Color.Transparent
            cBlendItems11.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems11.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnExpenses.ColorFillBlend = cBlendItems11
            Me.btnExpenses.Corners.All = 3
            Me.btnExpenses.Corners.LowerLeft = 3
            Me.btnExpenses.Corners.LowerRight = 3
            Me.btnExpenses.Corners.UpperLeft = 3
            Me.btnExpenses.Corners.UpperRight = 3
            Me.btnExpenses.DesignerSelected = False
            Me.btnExpenses.Font = New System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnExpenses.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnExpenses.Image = CType(componentResourceManager.GetObject("btnExpenses.Image"), System.Drawing.Image)
            Me.btnExpenses.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnExpenses.ImageIndex = 0
            Dim cButton31 As CButtonLib.CButton = Me.btnExpenses
            size = New System.Drawing.Size(100, 100)
            cButton31.ImageSize = size
            Dim cButton32 As CButtonLib.CButton = Me.btnExpenses
            location = New System.Drawing.Point(235, 160)
            cButton32.Location = location
            Me.btnExpenses.Name = "btnExpenses"
            Dim cButton33 As CButtonLib.CButton = Me.btnExpenses
            size = New System.Drawing.Size(217, 122)
            cButton33.Size = size
            Me.btnExpenses.TabIndex = 326
            Me.btnExpenses.Text = "Expense Master"
            Me.btnExpenses.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnExpenses.TextShadowShow = False
            Me.btnExpenses.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnCategoryMaster.BackColor = System.Drawing.Color.Transparent
            Me.btnCategoryMaster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnCategoryMaster.BorderColor = System.Drawing.Color.Transparent
            cBlendItems12.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems12.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnCategoryMaster.ColorFillBlend = cBlendItems12
            Me.btnCategoryMaster.Corners.All = 3
            Me.btnCategoryMaster.Corners.LowerLeft = 3
            Me.btnCategoryMaster.Corners.LowerRight = 3
            Me.btnCategoryMaster.Corners.UpperLeft = 3
            Me.btnCategoryMaster.Corners.UpperRight = 3
            Me.btnCategoryMaster.DesignerSelected = False
            Me.btnCategoryMaster.Font = New System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnCategoryMaster.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnCategoryMaster.Image = CType(componentResourceManager.GetObject("btnCategoryMaster.Image"), System.Drawing.Image)
            Me.btnCategoryMaster.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnCategoryMaster.ImageIndex = 0
            Dim cButton34 As CButtonLib.CButton = Me.btnCategoryMaster
            size = New System.Drawing.Size(100, 100)
            cButton34.ImageSize = size
            Dim cButton35 As CButtonLib.CButton = Me.btnCategoryMaster
            location = New System.Drawing.Point(235, 288)
            cButton35.Location = location
            Me.btnCategoryMaster.Name = "btnCategoryMaster"
            Dim cButton36 As CButtonLib.CButton = Me.btnCategoryMaster
            size = New System.Drawing.Size(217, 122)
            cButton36.Size = size
            Me.btnCategoryMaster.TabIndex = 328
            Me.btnCategoryMaster.Text = "Products Category"
            Me.btnCategoryMaster.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnCategoryMaster.TextShadowShow = False
            Me.btnCategoryMaster.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnUnit.BackColor = System.Drawing.Color.Transparent
            Me.btnUnit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnUnit.BorderColor = System.Drawing.Color.Transparent
            cBlendItems13.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems13.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnUnit.ColorFillBlend = cBlendItems13
            Me.btnUnit.Corners.All = 3
            Me.btnUnit.Corners.LowerLeft = 3
            Me.btnUnit.Corners.LowerRight = 3
            Me.btnUnit.Corners.UpperLeft = 3
            Me.btnUnit.Corners.UpperRight = 3
            Me.btnUnit.DesignerSelected = False
            Me.btnUnit.Font = New System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnUnit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnUnit.Image = CType(componentResourceManager.GetObject("btnUnit.Image"), System.Drawing.Image)
            Me.btnUnit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnUnit.ImageIndex = 0
            Dim cButton37 As CButtonLib.CButton = Me.btnUnit
            size = New System.Drawing.Size(100, 100)
            cButton37.ImageSize = size
            Dim cButton38 As CButtonLib.CButton = Me.btnUnit
            location = New System.Drawing.Point(458, 289)
            cButton38.Location = location
            Me.btnUnit.Name = "btnUnit"
            Dim cButton39 As CButtonLib.CButton = Me.btnUnit
            size = New System.Drawing.Size(217, 122)
            cButton39.Size = size
            Me.btnUnit.TabIndex = 327
            Me.btnUnit.Text = "Unit Master"
            Me.btnUnit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnUnit.TextShadowShow = False
            Me.btnUnit.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnExpenseType.BackColor = System.Drawing.Color.Transparent
            Me.btnExpenseType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnExpenseType.BorderColor = System.Drawing.Color.Transparent
            cBlendItems14.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems14.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnExpenseType.ColorFillBlend = cBlendItems14
            Me.btnExpenseType.Corners.All = 3
            Me.btnExpenseType.Corners.LowerLeft = 3
            Me.btnExpenseType.Corners.LowerRight = 3
            Me.btnExpenseType.Corners.UpperLeft = 3
            Me.btnExpenseType.Corners.UpperRight = 3
            Me.btnExpenseType.DesignerSelected = False
            Me.btnExpenseType.Font = New System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnExpenseType.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnExpenseType.Image = CType(componentResourceManager.GetObject("btnExpenseType.Image"), System.Drawing.Image)
            Me.btnExpenseType.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnExpenseType.ImageIndex = 0
            Dim cButton40 As CButtonLib.CButton = Me.btnExpenseType
            size = New System.Drawing.Size(100, 100)
            cButton40.ImageSize = size
            Dim cButton41 As CButtonLib.CButton = Me.btnExpenseType
            location = New System.Drawing.Point(12, 160)
            cButton41.Location = location
            Me.btnExpenseType.Name = "btnExpenseType"
            Dim cButton42 As CButtonLib.CButton = Me.btnExpenseType
            size = New System.Drawing.Size(217, 122)
            cButton42.Size = size
            Me.btnExpenseType.TabIndex = 325
            Me.btnExpenseType.Text = "Expense Type Master"
            Me.btnExpenseType.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnExpenseType.TextShadowShow = False
            Me.btnExpenseType.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.Button1.BackColor = System.Drawing.Color.Transparent
            Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Button1.BorderColor = System.Drawing.Color.Transparent
            cBlendItems15.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems15.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.Button1.ColorFillBlend = cBlendItems15
            Me.Button1.Corners.All = 3
            Me.Button1.Corners.LowerLeft = 3
            Me.Button1.Corners.LowerRight = 3
            Me.Button1.Corners.UpperLeft = 3
            Me.Button1.Corners.UpperRight = 3
            Me.Button1.DesignerSelected = False
            Me.Button1.Font = New System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.Button1.Image = CType(componentResourceManager.GetObject("Button1.Image"), System.Drawing.Image)
            Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.Button1.ImageIndex = 0
            Dim button3 As CButtonLib.CButton = Me.Button1
            size = New System.Drawing.Size(100, 100)
            button3.ImageSize = size
            Dim button4 As CButtonLib.CButton = Me.Button1
            location = New System.Drawing.Point(458, 32)
            button4.Location = location
            Me.Button1.Name = "Button1"
            Dim button5 As CButtonLib.CButton = Me.Button1
            size = New System.Drawing.Size(217, 122)
            button5.Size = size
            Me.Button1.TabIndex = 323
            Me.Button1.Text = "SMS Setting"
            Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.Button1.TextShadowShow = False
            Me.Button1.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnEmailSetting.BackColor = System.Drawing.Color.Transparent
            Me.btnEmailSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnEmailSetting.BorderColor = System.Drawing.Color.Transparent
            cBlendItems16.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems16.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnEmailSetting.ColorFillBlend = cBlendItems16
            Me.btnEmailSetting.Corners.All = 3
            Me.btnEmailSetting.Corners.LowerLeft = 3
            Me.btnEmailSetting.Corners.LowerRight = 3
            Me.btnEmailSetting.Corners.UpperLeft = 3
            Me.btnEmailSetting.Corners.UpperRight = 3
            Me.btnEmailSetting.DesignerSelected = False
            Me.btnEmailSetting.Font = New System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnEmailSetting.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnEmailSetting.Image = CType(componentResourceManager.GetObject("btnEmailSetting.Image"), System.Drawing.Image)
            Me.btnEmailSetting.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnEmailSetting.ImageIndex = 0
            Dim cButton43 As CButtonLib.CButton = Me.btnEmailSetting
            size = New System.Drawing.Size(100, 100)
            cButton43.ImageSize = size
            Dim cButton44 As CButtonLib.CButton = Me.btnEmailSetting
            location = New System.Drawing.Point(235, 32)
            cButton44.Location = location
            Me.btnEmailSetting.Name = "btnEmailSetting"
            Dim cButton45 As CButtonLib.CButton = Me.btnEmailSetting
            size = New System.Drawing.Size(217, 122)
            cButton45.Size = size
            Me.btnEmailSetting.TabIndex = 52
            Me.btnEmailSetting.Text = "Email Setting"
            Me.btnEmailSetting.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnEmailSetting.TextShadowShow = False
            Me.btnEmailSetting.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnOtherCharges.BackColor = System.Drawing.Color.Transparent
            Me.btnOtherCharges.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnOtherCharges.BorderColor = System.Drawing.Color.Transparent
            cBlendItems17.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems17.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnOtherCharges.ColorFillBlend = cBlendItems17
            Me.btnOtherCharges.Corners.All = 3
            Me.btnOtherCharges.Corners.LowerLeft = 3
            Me.btnOtherCharges.Corners.LowerRight = 3
            Me.btnOtherCharges.Corners.UpperLeft = 3
            Me.btnOtherCharges.Corners.UpperRight = 3
            Me.btnOtherCharges.DesignerSelected = False
            Me.btnOtherCharges.Font = New System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnOtherCharges.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnOtherCharges.Image = CType(componentResourceManager.GetObject("btnOtherCharges.Image"), System.Drawing.Image)
            Me.btnOtherCharges.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnOtherCharges.ImageIndex = 0
            Dim cButton46 As CButtonLib.CButton = Me.btnOtherCharges
            size = New System.Drawing.Size(100, 100)
            cButton46.ImageSize = size
            Dim cButton47 As CButtonLib.CButton = Me.btnOtherCharges
            location = New System.Drawing.Point(681, 32)
            cButton47.Location = location
            Me.btnOtherCharges.Name = "btnOtherCharges"
            Dim cButton48 As CButtonLib.CButton = Me.btnOtherCharges
            size = New System.Drawing.Size(217, 122)
            cButton48.Size = size
            Me.btnOtherCharges.TabIndex = 51
            Me.btnOtherCharges.Text = "Other Settings"
            Me.btnOtherCharges.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnOtherCharges.TextShadowShow = False
            Me.btnOtherCharges.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnTerminalSetting.BackColor = System.Drawing.Color.Transparent
            Me.btnTerminalSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnTerminalSetting.BorderColor = System.Drawing.Color.Transparent
            cBlendItems18.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems18.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnTerminalSetting.ColorFillBlend = cBlendItems18
            Me.btnTerminalSetting.Corners.All = 3
            Me.btnTerminalSetting.Corners.LowerLeft = 3
            Me.btnTerminalSetting.Corners.LowerRight = 3
            Me.btnTerminalSetting.Corners.UpperLeft = 3
            Me.btnTerminalSetting.Corners.UpperRight = 3
            Me.btnTerminalSetting.DesignerSelected = True
            Me.btnTerminalSetting.Font = New System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnTerminalSetting.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnTerminalSetting.Image = CType(componentResourceManager.GetObject("btnTerminalSetting.Image"), System.Drawing.Image)
            Me.btnTerminalSetting.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnTerminalSetting.ImageIndex = 0
            Dim cButton49 As CButtonLib.CButton = Me.btnTerminalSetting
            size = New System.Drawing.Size(100, 100)
            cButton49.ImageSize = size
            Dim cButton50 As CButtonLib.CButton = Me.btnTerminalSetting
            location = New System.Drawing.Point(12, 32)
            cButton50.Location = location
            Me.btnTerminalSetting.Name = "btnTerminalSetting"
            Dim cButton51 As CButtonLib.CButton = Me.btnTerminalSetting
            size = New System.Drawing.Size(217, 122)
            cButton51.Size = size
            Me.btnTerminalSetting.TabIndex = 28
            Me.btnTerminalSetting.Text = "Terminal Setting"
            Me.btnTerminalSetting.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnTerminalSetting.TextShadowShow = False
            Me.btnTerminalSetting.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnMI.BackColor = System.Drawing.Color.Transparent
            Me.btnMI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnMI.BorderColor = System.Drawing.Color.Transparent
            cBlendItems19.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems19.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnMI.ColorFillBlend = cBlendItems19
            Me.btnMI.Corners.All = 3
            Me.btnMI.Corners.LowerLeft = 3
            Me.btnMI.Corners.LowerRight = 3
            Me.btnMI.Corners.UpperLeft = 3
            Me.btnMI.Corners.UpperRight = 3
            Me.btnMI.DesignerSelected = False
            Me.btnMI.Font = New System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnMI.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnMI.Image = CType(componentResourceManager.GetObject("btnMI.Image"), System.Drawing.Image)
            Me.btnMI.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnMI.ImageIndex = 0
            Dim cButton52 As CButtonLib.CButton = Me.btnMI
            size = New System.Drawing.Size(100, 100)
            cButton52.ImageSize = size
            Dim cButton53 As CButtonLib.CButton = Me.btnMI
            location = New System.Drawing.Point(235, 548)
            cButton53.Location = location
            Me.btnMI.Name = "btnMI"
            Dim cButton54 As CButtonLib.CButton = Me.btnMI
            size = New System.Drawing.Size(217, 122)
            cButton54.Size = size
            Me.btnMI.TabIndex = 342
            Me.btnMI.Text = "Menu Item Button UI Setting"
            Me.btnMI.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnMI.TextShadowShow = False
            Me.btnMI.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnMpesaSetting.BackColor = System.Drawing.Color.Transparent
            Me.btnMpesaSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnMpesaSetting.BorderColor = System.Drawing.Color.Transparent
            cBlendItems20.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems20.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnMpesaSetting.ColorFillBlend = cBlendItems20
            Me.btnMpesaSetting.Corners.All = 3
            Me.btnMpesaSetting.Corners.LowerLeft = 3
            Me.btnMpesaSetting.Corners.LowerRight = 3
            Me.btnMpesaSetting.Corners.UpperLeft = 3
            Me.btnMpesaSetting.Corners.UpperRight = 3
            Me.btnMpesaSetting.DesignerSelected = False
            Me.btnMpesaSetting.Font = New System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnMpesaSetting.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnMpesaSetting.Image = CType(componentResourceManager.GetObject("btnMpesaSetting.Image"), System.Drawing.Image)
            Me.btnMpesaSetting.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnMpesaSetting.ImageIndex = 0
            Dim cButton55 As CButtonLib.CButton = Me.btnMpesaSetting
            size = New System.Drawing.Size(100, 100)
            cButton55.ImageSize = size
            Dim cButton56 As CButtonLib.CButton = Me.btnMpesaSetting
            location = New System.Drawing.Point(458, 543)
            cButton56.Location = location
            Me.btnMpesaSetting.Name = "btnMpesaSetting"
            Dim cButton57 As CButtonLib.CButton = Me.btnMpesaSetting
            size = New System.Drawing.Size(217, 127)
            cButton57.Size = size
            Me.btnMpesaSetting.TabIndex = 343
            Me.btnMpesaSetting.Text = "M-PESA API Setting"
            Me.btnMpesaSetting.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnMpesaSetting.TextShadowShow = False
            Me.btnMpesaSetting.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            size = New System.Drawing.Size(912, 682)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.btnMpesaSetting)
            MyBase.Controls.Add(Me.btnMI)
            MyBase.Controls.Add(Me.btnTablesAssign)
            MyBase.Controls.Add(Me.btnClose)
            MyBase.Controls.Add(Me.btnUserRights)
            MyBase.Controls.Add(Me.btnWallet)
            MyBase.Controls.Add(Me.btnEQ)
            MyBase.Controls.Add(Me.btnPromotion)
            MyBase.Controls.Add(Me.btnTableLayout)
            MyBase.Controls.Add(Me.btnWarehouse)
            MyBase.Controls.Add(Me.btnWarehouseType)
            MyBase.Controls.Add(Me.btnWorkPeriod)
            MyBase.Controls.Add(Me.btnNotes)
            MyBase.Controls.Add(Me.btnExpenses)
            MyBase.Controls.Add(Me.btnCategoryMaster)
            MyBase.Controls.Add(Me.btnUnit)
            MyBase.Controls.Add(Me.btnExpenseType)
            MyBase.Controls.Add(Me.Button1)
            MyBase.Controls.Add(Me.lblUser)
            MyBase.Controls.Add(Me.btnEmailSetting)
            MyBase.Controls.Add(Me.btnOtherCharges)
            MyBase.Controls.Add(Me.btnTerminalSetting)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.Name = "frmSettings"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "frmSettings"
            MyBase.ResumeLayout(False)
            MyBase.PerformLayout()
        End Sub
    End Class
End Namespace
