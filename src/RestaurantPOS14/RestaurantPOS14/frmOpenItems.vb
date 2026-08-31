Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports RestaurantPOS14.My
Imports Telerik.WinControls.Themes
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.VirtualKeyboard

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public Class frmOpenItems
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label1")>
        Private _Label1 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label2")>
        Private _Label2 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtItemName")>
        Private _txtItemName As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtRate")>
        Private _txtRate As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnOK")>
        Private _btnOK As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnReset")>
        Private _btnReset As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblSet")>
        Private _lblSet As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("AquaTheme1")>
        Private _AquaTheme1 As Telerik.WinControls.Themes.AquaTheme

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("RadVirtualKeyboard1")>
        Private _RadVirtualKeyboard1 As Telerik.WinControls.UI.RadVirtualKeyboard

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("VisualStudio2012DarkTheme1")>
        Private _VisualStudio2012DarkTheme1 As Telerik.WinControls.Themes.VisualStudio2012DarkTheme

        Private VatPer As Double

        Private components As System.ComponentModel.IContainer

        Friend Overridable Property Label1 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label1 = value
            End Set
        End Property

        Friend Overridable Property Label2 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label2
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label2 = value
            End Set
        End Property

        Friend Overridable Property txtItemName As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtItemName
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtItemName = value
            End Set
        End Property

        Friend Overridable Property txtRate As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtRate
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.Windows.Forms.KeyPressEventHandler = AddressOf Me.txtRate_KeyPress
                If Me._txtRate IsNot Nothing Then
                    RemoveHandler Me._txtRate.KeyPress, value2
                End If

                Me._txtRate = value
                If Me._txtRate IsNot Nothing Then
                    AddHandler Me._txtRate.KeyPress, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnOK As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnOK
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnOK_Click
                If Me._btnOK IsNot Nothing Then
                    RemoveHandler Me._btnOK.Click, value2
                End If

                Me._btnOK = value
                If Me._btnOK IsNot Nothing Then
                    AddHandler Me._btnOK.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnReset As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnReset
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnReset_Click
                If Me._btnReset IsNot Nothing Then
                    RemoveHandler Me._btnReset.Click, value2
                End If

                Me._btnReset = value
                If Me._btnReset IsNot Nothing Then
                    AddHandler Me._btnReset.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property lblSet As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._lblSet
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._lblSet = value
            End Set
        End Property

        Friend Overridable Property AquaTheme1 As Telerik.WinControls.Themes.AquaTheme
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._AquaTheme1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As Telerik.WinControls.Themes.AquaTheme)
                Me._AquaTheme1 = value
            End Set
        End Property

        Friend Overridable Property RadVirtualKeyboard1 As Telerik.WinControls.UI.RadVirtualKeyboard
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._RadVirtualKeyboard1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As Telerik.WinControls.UI.RadVirtualKeyboard)
                Me._RadVirtualKeyboard1 = value
            End Set
        End Property

        Friend Overridable Property VisualStudio2012DarkTheme1 As Telerik.WinControls.Themes.VisualStudio2012DarkTheme
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._VisualStudio2012DarkTheme1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As Telerik.WinControls.Themes.VisualStudio2012DarkTheme)
                Me._VisualStudio2012DarkTheme1 = value
            End Set
        End Property

        Public Sub New()
            AddHandler MyBase.Shown, AddressOf Me.frmOpenFoods_Shown
            Call RestaurantPOS14.frmOpenItems.__ENCAddToList(Me)
            Me.VatPer = 0.0
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmOpenItems.__ENCList
                If RestaurantPOS14.frmOpenItems.__ENCList.Count = RestaurantPOS14.frmOpenItems.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmOpenItems.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmOpenItems.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmOpenItems.__ENCList(num) = RestaurantPOS14.frmOpenItems.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmOpenItems.__ENCList.RemoveRange(num, RestaurantPOS14.frmOpenItems.__ENCList.Count - num)
                    RestaurantPOS14.frmOpenItems.__ENCList.Capacity = RestaurantPOS14.frmOpenItems.__ENCList.Count
                End If

                Call RestaurantPOS14.frmOpenItems.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Public Sub Reset()
            Me.txtItemName.Text = ""
            Me.txtRate.Text = ""
            Me.VatPer = 0.0
            Me.txtItemName.Focus()
        End Sub

        Private Sub frmOpenFoods_Shown(sender As Object, e As System.EventArgs)
            Me.txtItemName.Focus()
        End Sub

        Private Sub btnOK_Click(sender As Object, e As System.EventArgs)
            If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.txtItemName.Text)) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please enter item name", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtItemName.Focus()
                Return
            End If

            If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.txtRate.Text)) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please enter rate", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtRate.Focus()
                Return
            End If

            Try
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "KOT", TextCompare:=False) = 0 Then
                    Me.VatPer = System.Convert.ToDouble(RestaurantPOS14.ModFunc.GetVATPer("Open Items"))
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.txtVATPer_Food.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Me.VatPer)
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.Compute()
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.DataGridView1.Rows.Add(Me.txtItemName.Text, Microsoft.VisualBasic.Conversion.Val(Me.txtRate.Text), 1, Microsoft.VisualBasic.Conversion.Val(Me.txtRate.Text), 0, 0, 0, 0, Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtVATPer_Food.Text), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtVATAmt_Food.Text), 0, 0, Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtTotalAmt_Food.Text), "", 0, "Open Items", "", "New")
                    Dim value As Double = RestaurantPOS14.My.MyProject.Forms.frmPOS.GrandTotal_Food()
                    value = System.Math.Round(value, 2)
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBalance.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(value)
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.ItemDataSubString(Me.txtItemName.Text)
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.CustomerDisplay(RestaurantPOS14.My.MyProject.Forms.frmPOS.subt, New Decimal(Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtTotalAmt_Food.Text)), New Decimal(Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBalance.Text)))
                    If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtColoredCustomerDisplay.Text, "Yes", TextCompare:=False) = 0 Then
                        Dim screen As System.Windows.Forms.Screen = System.Windows.Forms.Screen.AllScreens(1)
                        RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.StartPosition = System.Windows.Forms.FormStartPosition.Manual
                        Dim obj As RestaurantPOS14.frmSecondaryDisplay = RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay
                        Dim location As System.Drawing.Point = screen.Bounds.Location
                        Dim p As System.Drawing.Point = New System.Drawing.Point(100, 100)
                        obj.Location = location + CType(p, System.Drawing.Size)
                        Call RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.DataGridView1.Rows.Add(Me.txtItemName.Text, Microsoft.VisualBasic.Conversion.Val(Me.txtRate.Text), 1, Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtTotalAmt_Food.Text))
                        RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.lblTotal.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBalance.Text))
                        RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.lblHST.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.H1()))
                        RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.DataGridView1.CurrentCell = RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.DataGridView1.Rows(CInt((RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.DataGridView1.Rows.Count - 1))).Cells(0)
                        Call RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.Show()
                    End If

                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.Clear()
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.Clear1()
                    Me.lblSet.Text = ""
                    Me.Reset()
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.DataGridView1.CurrentCell = RestaurantPOS14.My.MyProject.Forms.frmPOS.DataGridView1.Rows(CInt((RestaurantPOS14.My.MyProject.Forms.frmPOS.DataGridView1.Rows.Count - 1))).Cells(0)
                    MyBase.Close()
                End If

                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "HD", TextCompare:=False) = 0 Then
                    Me.VatPer = System.Convert.ToDouble(RestaurantPOS14.ModFunc.GetVATPer("Open Items"))
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.txtVATPer_Food.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Me.VatPer)
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.Compute()
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.DataGridView4.Rows.Add(Me.txtItemName.Text, Microsoft.VisualBasic.Conversion.Val(Me.txtRate.Text), 1, Microsoft.VisualBasic.Conversion.Val(Me.txtRate.Text), 0, 0, 0, 0, Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtVATPer_Food.Text), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtVATAmt_Food.Text), 0, 0, Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtTotalAmt_Food.Text), "", 0, "Open Items", "")
                    Dim value2 As Double = RestaurantPOS14.My.MyProject.Forms.frmPOS.GrandTotal_Food3()
                    value2 = System.Math.Round(value2, 2)
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBalance2.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(value2)
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.txtSubTotal.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(value2)
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.Calc2()
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.ItemDataSubString(Me.txtItemName.Text)
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.CustomerDisplay(RestaurantPOS14.My.MyProject.Forms.frmPOS.subt, New Decimal(Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtTotalAmt_Food.Text)), New Decimal(Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBalance2.Text)))
                    If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtColoredCustomerDisplay.Text, "Yes", TextCompare:=False) = 0 Then
                        Dim screen2 As System.Windows.Forms.Screen = System.Windows.Forms.Screen.AllScreens(1)
                        RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.StartPosition = System.Windows.Forms.FormStartPosition.Manual
                        Dim obj2 As RestaurantPOS14.frmSecondaryDisplay = RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay
                        Dim location2 As System.Drawing.Point = screen2.Bounds.Location
                        Dim p2 As System.Drawing.Point = New System.Drawing.Point(100, 100)
                        obj2.Location = location2 + CType(p2, System.Drawing.Size)
                        Call RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.DataGridView1.Rows.Add(Me.txtItemName.Text, Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtRate_Food.Text), 1, Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtTotalAmt_Food.Text))
                        RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.lblTotal.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBalance2.Text))
                        RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.lblHST.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.H3()))
                        RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.DataGridView1.CurrentCell = RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.DataGridView1.Rows(CInt((RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.DataGridView1.Rows.Count - 1))).Cells(0)
                        Call RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.Show()
                    End If

                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.Clear1()
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.Clear3()
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.txtHDDiscountPer.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(0)
                    Me.lblSet.Text = ""
                    Me.Reset()
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.DataGridView4.CurrentCell = RestaurantPOS14.My.MyProject.Forms.frmPOS.DataGridView4.Rows(CInt((RestaurantPOS14.My.MyProject.Forms.frmPOS.DataGridView4.Rows.Count - 1))).Cells(0)
                    MyBase.Close()
                End If

                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "TA", TextCompare:=False) = 0 Then
                    Me.VatPer = System.Convert.ToDouble(RestaurantPOS14.ModFunc.GetVATPer("Open Items"))
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.txtVATPer_Food.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Me.VatPer)
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.Compute()
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.DataGridView3.Rows.Add(Me.txtItemName.Text, Microsoft.VisualBasic.Conversion.Val(Me.txtRate.Text), 1, Microsoft.VisualBasic.Conversion.Val(Me.txtRate.Text), 0, 0, 0, 0, Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtVATPer_Food.Text), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtVATAmt_Food.Text), 0, 0, Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtTotalAmt_Food.Text), "", 0, "Open Items", "")
                    Dim value3 As Double = RestaurantPOS14.My.MyProject.Forms.frmPOS.GrandTotal_Food2()
                    value3 = System.Math.Round(value3, 2)
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBalance1.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(value3)
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.txtSubTotal1.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(value3)
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.Calc1()
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.ItemDataSubString(Me.txtItemName.Text)
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.CustomerDisplay(RestaurantPOS14.My.MyProject.Forms.frmPOS.subt, New Decimal(Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtTotalAmt_Food.Text)), New Decimal(Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBalance1.Text)))
                    If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtColoredCustomerDisplay.Text, "Yes", TextCompare:=False) = 0 Then
                        Dim screen3 As System.Windows.Forms.Screen = System.Windows.Forms.Screen.AllScreens(1)
                        RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.StartPosition = System.Windows.Forms.FormStartPosition.Manual
                        Dim obj3 As RestaurantPOS14.frmSecondaryDisplay = RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay
                        Dim location3 As System.Drawing.Point = screen3.Bounds.Location
                        Dim p3 As System.Drawing.Point = New System.Drawing.Point(100, 100)
                        obj3.Location = location3 + CType(p3, System.Drawing.Size)
                        Call RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.DataGridView1.Rows.Add(Me.txtItemName.Text, Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtRate_Food.Text), 1, Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtTotalAmt_Food.Text))
                        RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.lblTotal.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBalance1.Text))
                        RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.lblHST.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.H2()))
                        RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.DataGridView1.CurrentCell = RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.DataGridView1.Rows(CInt((RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.DataGridView1.Rows.Count - 1))).Cells(0)
                        Call RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.Show()
                    End If

                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.fillCurrencyTA()
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.Clear1()
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.Clear2()
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.txtTADiscountPer.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(0)
                    Me.lblSet.Text = ""
                    Me.Reset()
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.DataGridView3.CurrentCell = RestaurantPOS14.My.MyProject.Forms.frmPOS.DataGridView3.Rows(CInt((RestaurantPOS14.My.MyProject.Forms.frmPOS.DataGridView3.Rows.Count - 1))).Cells(0)
                    MyBase.Close()
                End If

                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "EB", TextCompare:=False) = 0 Then
                    Me.VatPer = System.Convert.ToDouble(RestaurantPOS14.ModFunc.GetVATPer("Open Items"))
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.txtVATPer_Food.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Me.VatPer)
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.Compute()
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.DataGridView5.Rows.Add(Me.txtItemName.Text, Microsoft.VisualBasic.Conversion.Val(Me.txtRate.Text), 1, Microsoft.VisualBasic.Conversion.Val(Me.txtRate.Text), 0, 0, 0, 0, Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtVATPer_Food.Text), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtVATAmt_Food.Text), 0, 0, Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtTotalAmt_Food.Text), "", 0, "Open Items", "")
                    Dim value4 As Double = RestaurantPOS14.My.MyProject.Forms.frmPOS.GrandTotal_Food4()
                    value4 = System.Math.Round(value4, 2)
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBalance3.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(value4)
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.txtGrandTotal3.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(value4)
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.Calc3()
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.ItemDataSubString(Me.txtItemName.Text)
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.CustomerDisplay(RestaurantPOS14.My.MyProject.Forms.frmPOS.subt, New Decimal(Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtTotalAmt_Food.Text)), New Decimal(Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBalance3.Text)))
                    If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtColoredCustomerDisplay.Text, "Yes", TextCompare:=False) = 0 Then
                        Dim screen4 As System.Windows.Forms.Screen = System.Windows.Forms.Screen.AllScreens(1)
                        RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.StartPosition = System.Windows.Forms.FormStartPosition.Manual
                        Dim obj4 As RestaurantPOS14.frmSecondaryDisplay = RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay
                        Dim location4 As System.Drawing.Point = screen4.Bounds.Location
                        Dim p4 As System.Drawing.Point = New System.Drawing.Point(100, 100)
                        obj4.Location = location4 + CType(p4, System.Drawing.Size)
                        Call RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.DataGridView1.Rows.Add(Me.txtItemName.Text, Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtRate_Food.Text), 1, Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtTotalAmt_Food.Text))
                        RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.lblTotal.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBalance3.Text))
                        RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.lblHST.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.H4()))
                        RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.DataGridView1.CurrentCell = RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.DataGridView1.Rows(CInt((RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.DataGridView1.Rows.Count - 1))).Cells(0)
                        Call RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.Show()
                    End If

                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.fillCurrencyEB()
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.Clear1()
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.Clear4()
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.txtEBDiscountPer.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(0)
                    Me.lblSet.Text = ""
                    Me.Reset()
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.DataGridView5.CurrentCell = RestaurantPOS14.My.MyProject.Forms.frmPOS.DataGridView5.Rows(CInt((RestaurantPOS14.My.MyProject.Forms.frmPOS.DataGridView5.Rows.Count - 1))).Cells(0)
                    MyBase.Close()
                End If
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnReset_Click(sender As Object, e As System.EventArgs)
            Me.Reset()
        End Sub

        Private Sub txtRate_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
            Dim keyChar As Char = e.KeyChar
            If Char.IsControl(keyChar) Then
                Return
            End If

            If Char.IsDigit(keyChar) OrElse keyChar = "."c Then
                Dim text As String = Me.txtRate.Text
                Dim selectionStart As Integer = Me.txtRate.SelectionStart
                Dim selectionLength As Integer = Me.txtRate.SelectionLength
                text = text.Substring(0, selectionStart) & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(keyChar) & text.Substring(selectionStart + selectionLength)
                Dim s As String = text
                Dim num As Integer = 0
                If Integer.TryParse(s, num) AndAlso text.Length > 16 Then
                    e.Handled = True
                    Return
                End If

                Dim s2 As String = text
                Dim num2 As Double = 0.0
                If Double.TryParse(s2, num2) AndAlso text.IndexOf("."c) < text.Length - 3 Then
                    e.Handled = False
                End If
            Else
                e.Handled = True
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmOpenItems))
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtItemName = New System.Windows.Forms.TextBox()
            Me.txtRate = New System.Windows.Forms.TextBox()
            Me.btnOK = New System.Windows.Forms.Button()
            Me.btnReset = New System.Windows.Forms.Button()
            Me.lblSet = New System.Windows.Forms.Label()
            Me.AquaTheme1 = New Telerik.WinControls.Themes.AquaTheme()
            Me.RadVirtualKeyboard1 = New Telerik.WinControls.UI.RadVirtualKeyboard()
            Me.VisualStudio2012DarkTheme1 = New Telerik.WinControls.Themes.VisualStudio2012DarkTheme()
            CType(Me.RadVirtualKeyboard1, System.ComponentModel.ISupportInitialize).BeginInit()
            MyBase.SuspendLayout()
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label1.ForeColor = System.Drawing.Color.White
            Dim label As System.Windows.Forms.Label = Me.Label1
            Dim location As System.Drawing.Point = New System.Drawing.Point(12, 9)
            label.Location = location
            Me.Label1.Name = "Label1"
            Dim label2 As System.Windows.Forms.Label = Me.Label1
            Dim size As System.Drawing.Size = New System.Drawing.Size(187, 30)
            label2.Size = size
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Enter Item Name :"
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label2.ForeColor = System.Drawing.Color.White
            Dim label3 As System.Windows.Forms.Label = Me.Label2
            location = New System.Drawing.Point(12, 50)
            label3.Location = location
            Me.Label2.Name = "Label2"
            Dim label4 As System.Windows.Forms.Label = Me.Label2
            size = New System.Drawing.Size(123, 30)
            label4.Size = size
            Me.Label2.TabIndex = 1
            Me.Label2.Text = "Enter Rate :"
            Me.txtItemName.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox As System.Windows.Forms.TextBox = Me.txtItemName
            location = New System.Drawing.Point(206, 18)
            textBox.Location = location
            Me.txtItemName.Name = "txtItemName"
            Dim textBox2 As System.Windows.Forms.TextBox = Me.txtItemName
            size = New System.Drawing.Size(410, 35)
            textBox2.Size = size
            Me.txtItemName.TabIndex = 0
            Me.txtRate.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox3 As System.Windows.Forms.TextBox = Me.txtRate
            location = New System.Drawing.Point(206, 59)
            textBox3.Location = location
            Me.txtRate.Name = "txtRate"
            Dim textBox4 As System.Windows.Forms.TextBox = Me.txtRate
            size = New System.Drawing.Size(133, 35)
            textBox4.Size = size
            Me.txtRate.TabIndex = 1
            Me.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.btnOK.BackColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.btnOK.FlatAppearance.BorderSize = 0
            Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnOK.Font = New System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnOK.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Dim button As System.Windows.Forms.Button = Me.btnOK
            location = New System.Drawing.Point(633, 18)
            button.Location = location
            Me.btnOK.Name = "btnOK"
            Dim button2 As System.Windows.Forms.Button = Me.btnOK
            size = New System.Drawing.Size(116, 76)
            button2.Size = size
            Me.btnOK.TabIndex = 493
            Me.btnOK.Text = "OK"
            Me.btnOK.UseVisualStyleBackColor = False
            Me.btnReset.BackColor = System.Drawing.Color.Crimson
            Me.btnReset.FlatAppearance.BorderSize = 0
            Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnReset.Font = New System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Dim button3 As System.Windows.Forms.Button = Me.btnReset
            location = New System.Drawing.Point(755, 18)
            button3.Location = location
            Me.btnReset.Name = "btnReset"
            Dim button4 As System.Windows.Forms.Button = Me.btnReset
            size = New System.Drawing.Size(116, 76)
            button4.Size = size
            Me.btnReset.TabIndex = 492
            Me.btnReset.Text = "Reset"
            Me.btnReset.UseVisualStyleBackColor = False
            Me.lblSet.AutoSize = True
            Dim label5 As System.Windows.Forms.Label = Me.lblSet
            location = New System.Drawing.Point(914, 50)
            label5.Location = location
            Me.lblSet.Name = "lblSet"
            Dim label6 As System.Windows.Forms.Label = Me.lblSet
            size = New System.Drawing.Size(39, 13)
            label6.Size = size
            Me.lblSet.TabIndex = 494
            Me.lblSet.Text = "Label3"
            Me.lblSet.Visible = False
            Me.RadVirtualKeyboard1.LayoutType = Telerik.WinControls.VirtualKeyboard.KeyboardLayoutType.Simplified
            Dim radVirtualKeyboard As Telerik.WinControls.UI.RadVirtualKeyboard = Me.RadVirtualKeyboard1
            location = New System.Drawing.Point(1, 100)
            radVirtualKeyboard.Location = location
            Me.RadVirtualKeyboard1.Name = "RadVirtualKeyboard1"
            Dim radVirtualKeyboard2 As Telerik.WinControls.UI.RadVirtualKeyboard = Me.RadVirtualKeyboard1
            size = New System.Drawing.Size(990, 521)
            radVirtualKeyboard2.Size = size
            Me.RadVirtualKeyboard1.TabIndex = 495
            Me.RadVirtualKeyboard1.TabStop = False
            Me.RadVirtualKeyboard1.ThemeName = "VisualStudio2012Dark"
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            size = New System.Drawing.Size(994, 625)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.RadVirtualKeyboard1)
            MyBase.Controls.Add(Me.lblSet)
            MyBase.Controls.Add(Me.btnOK)
            MyBase.Controls.Add(Me.btnReset)
            MyBase.Controls.Add(Me.txtRate)
            MyBase.Controls.Add(Me.txtItemName)
            MyBase.Controls.Add(Me.Label2)
            MyBase.Controls.Add(Me.Label1)
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MaximizeBox = False
            MyBase.MinimizeBox = False
            MyBase.Name = "frmOpenItems"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Open Items"
            CType(Me.RadVirtualKeyboard1, System.ComponentModel.ISupportInitialize).EndInit()
            MyBase.ResumeLayout(False)
            MyBase.PerformLayout()
        End Sub
    End Class
End Namespace
