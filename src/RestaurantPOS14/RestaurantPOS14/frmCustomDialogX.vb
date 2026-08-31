Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data.SqlClient
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
    Public Class frmCustomDialogX
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label2")>
        Private _Label2 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnOK")>
        Private _btnOK As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel1")>
        Private _Panel1 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnCancel")>
        Private _btnCancel As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblSet")>
        Private _lblSet As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtReason")>
        Private _txtReason As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label1")>
        Private _Label1 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("RadVirtualKeyboard1")>
        Private _RadVirtualKeyboard1 As Telerik.WinControls.UI.RadVirtualKeyboard

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("AquaTheme1")>
        Private _AquaTheme1 As Telerik.WinControls.Themes.AquaTheme

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("VisualStudio2012DarkTheme1")>
        Private _VisualStudio2012DarkTheme1 As Telerik.WinControls.Themes.VisualStudio2012DarkTheme

        Private components As System.ComponentModel.IContainer

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

        Friend Overridable Property Panel1 As System.Windows.Forms.Panel
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Panel1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Panel)
                Me._Panel1 = value
            End Set
        End Property

        Friend Overridable Property btnCancel As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnCancel
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnCancel_Click
                If Me._btnCancel IsNot Nothing Then
                    RemoveHandler Me._btnCancel.Click, value2
                End If

                Me._btnCancel = value
                If Me._btnCancel IsNot Nothing Then
                    AddHandler Me._btnCancel.Click, value2
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

        Friend Overridable Property txtReason As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtReason
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtReason = value
            End Set
        End Property

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

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            AddHandler MyBase.Load, AddressOf Me.frmCustomDialog19_Load
            AddHandler MyBase.Shown, AddressOf Me.frmCustomDialogX_Shown
            Call RestaurantPOS14.frmCustomDialogX.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmCustomDialogX.__ENCList
                If RestaurantPOS14.frmCustomDialogX.__ENCList.Count = RestaurantPOS14.frmCustomDialogX.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmCustomDialogX.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmCustomDialogX.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmCustomDialogX.__ENCList(num) = RestaurantPOS14.frmCustomDialogX.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmCustomDialogX.__ENCList.RemoveRange(num, RestaurantPOS14.frmCustomDialogX.__ENCList.Count - num)
                    RestaurantPOS14.frmCustomDialogX.__ENCList.Capacity = RestaurantPOS14.frmCustomDialogX.__ENCList.Count
                End If

                Call RestaurantPOS14.frmCustomDialogX.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Private Sub btnOK_Click(sender As Object, e As System.EventArgs)
            If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.txtReason.Text)) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please enter reason", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtReason.Focus()
                Return
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "Dine In KOT", TextCompare:=False) = 0 Then
                RestaurantPOS14.ModFunc.InvoiceDeleteFunc(RestaurantPOS14.My.MyProject.Forms.frmPOS.lblTicketNo.Text, RestaurantPOS14.My.MyProject.Forms.frmPOS.dtpBillDate.Value, New Decimal(Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBalance.Text)), RestaurantPOS14.My.MyProject.Forms.frmPOS.lblUserVAL.Text, "", Me.txtReason.Text, "Dine In KOT", "Deleted")
                For Each dataGridViewRow As System.Windows.Forms.DataGridViewRow In CType(RestaurantPOS14.My.MyProject.Forms.frmPOS.DataGridView1.Rows, System.Collections.IEnumerable)
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Insert Into DeletedInvoices_Join(BillNo,ItemName,Qty,TotalAmount) Values(@d1,@d2,@d3,@d4)")
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", RestaurantPOS14.My.MyProject.Forms.frmPOS.lblTicketNo.Text)
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", dataGridViewRow.Cells(CInt((0))).Value.ToString())
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((2))).Value)))
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((12))).Value)))
                    RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                    RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                    RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                    RestaurantPOS14.ModClasses.con.Close()
                Next

                Call RestaurantPOS14.My.MyProject.Forms.frmPOS.DeleteRecord()
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "Void KOT", TextCompare:=False) = 0 Then
                RestaurantPOS14.ModFunc.InvoiceDeleteFunc(RestaurantPOS14.My.MyProject.Forms.frmPOS.lblTicketNo.Text, RestaurantPOS14.My.MyProject.Forms.frmPOS.dtpBillDate.Value, New Decimal(Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBalance.Text)), RestaurantPOS14.My.MyProject.Forms.frmPOS.lblUserVAL.Text, "", Me.txtReason.Text, "Dine In KOT", "Canceled")
                For Each dataGridViewRow2 As System.Windows.Forms.DataGridViewRow In CType(RestaurantPOS14.My.MyProject.Forms.frmPOS.DataGridView1.Rows, System.Collections.IEnumerable)
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Insert Into DeletedInvoices_Join(BillNo,ItemName,Qty,TotalAmount) Values(@d1,@d2,@d3,@d4)")
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", RestaurantPOS14.My.MyProject.Forms.frmPOS.lblTicketNo.Text)
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", dataGridViewRow2.Cells(CInt((0))).Value.ToString())
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(CInt((2))).Value)))
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(CInt((12))).Value)))
                    RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                    RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                    RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                    RestaurantPOS14.ModClasses.con.Close()
                Next

                Call RestaurantPOS14.My.MyProject.Forms.frmPOS.VoidBill()
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "Void RKOT", TextCompare:=False) = 0 Then
                RestaurantPOS14.ModFunc.InvoiceDeleteFunc(RestaurantPOS14.My.MyProject.Forms.frmPOS.lblTicketNo.Text, RestaurantPOS14.My.MyProject.Forms.frmPOS.dtpBillDate.Value, New Decimal(Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBalance.Text)), RestaurantPOS14.My.MyProject.Forms.frmPOS.lblUserVAL.Text, "", Me.txtReason.Text, "Dine In KOT", "Canceled")
                For Each dataGridViewRow3 As System.Windows.Forms.DataGridViewRow In CType(RestaurantPOS14.My.MyProject.Forms.frmPOS.DataGridView1.Rows, System.Collections.IEnumerable)
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Insert Into DeletedInvoices_Join(BillNo,ItemName,Qty,TotalAmount) Values(@d1,@d2,@d3,@d4)")
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", RestaurantPOS14.My.MyProject.Forms.frmPOS.lblTicketNo.Text)
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", dataGridViewRow3.Cells(CInt((0))).Value.ToString())
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow3.Cells(CInt((2))).Value)))
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow3.Cells(CInt((12))).Value)))
                    RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                    RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                    RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                    RestaurantPOS14.ModClasses.con.Close()
                Next

                Call RestaurantPOS14.My.MyProject.Forms.frmPOS.RollBackStock()
                Call RestaurantPOS14.My.MyProject.Forms.frmPOS.VoidBill()
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "KOT", TextCompare:=False) = 0 Then
                RestaurantPOS14.ModFunc.InvoiceDeleteFunc(RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBillNo.Text, RestaurantPOS14.My.MyProject.Forms.frmPOS.dtpBillDate.Value, New Decimal(Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtGrandTotal.Text)), RestaurantPOS14.My.MyProject.Forms.frmPOS.lblUserVAL.Text, RestaurantPOS14.My.MyProject.Forms.frmPOS.lblPaymentMode.Text, Me.txtReason.Text, "Dine In Billing", "Deleted")
                For Each dataGridViewRow4 As System.Windows.Forms.DataGridViewRow In CType(RestaurantPOS14.My.MyProject.Forms.frmPOS.DataGridView2.Rows, System.Collections.IEnumerable)
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Insert Into DeletedInvoices_Join(BillNo,ItemName,Qty,TotalAmount) Values(@d1,@d2,@d3,@d4)")
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBillNo.Text)
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", dataGridViewRow4.Cells(CInt((1))).Value.ToString())
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells(CInt((3))).Value)))
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells(CInt((13))).Value)))
                    RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                    RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                    RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                    RestaurantPOS14.ModClasses.con.Close()
                Next

                Call RestaurantPOS14.My.MyProject.Forms.frmPOS.DeleteRecord1()
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "TA", TextCompare:=False) = 0 Then
                RestaurantPOS14.ModFunc.InvoiceDeleteFunc(RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBillNo1.Text, RestaurantPOS14.My.MyProject.Forms.frmPOS.dtpBillDate.Value, New Decimal(Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtGrandTotal1.Text)), RestaurantPOS14.My.MyProject.Forms.frmPOS.lblUserVAL.Text, RestaurantPOS14.My.MyProject.Forms.frmPOS.lblPaymentMode1.Text, Me.txtReason.Text, "Take Away", "Deleted")
                For Each dataGridViewRow5 As System.Windows.Forms.DataGridViewRow In CType(RestaurantPOS14.My.MyProject.Forms.frmPOS.DataGridView3.Rows, System.Collections.IEnumerable)
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Insert Into DeletedInvoices_Join(BillNo,ItemName,Qty,TotalAmount) Values(@d1,@d2,@d3,@d4)")
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBillNo1.Text)
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", dataGridViewRow5.Cells(CInt((0))).Value.ToString())
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow5.Cells(CInt((2))).Value)))
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow5.Cells(CInt((12))).Value)))
                    RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                    RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                    RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                    RestaurantPOS14.ModClasses.con.Close()
                Next

                Call RestaurantPOS14.My.MyProject.Forms.frmPOS.DeleteRecord2()
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "Void TA", TextCompare:=False) = 0 Then
                RestaurantPOS14.ModFunc.InvoiceDeleteFunc(RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBillNo1.Text, RestaurantPOS14.My.MyProject.Forms.frmPOS.dtpBillDate.Value, New Decimal(Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtGrandTotal1.Text)), RestaurantPOS14.My.MyProject.Forms.frmPOS.lblUserVAL.Text, RestaurantPOS14.My.MyProject.Forms.frmPOS.lblPaymentMode1.Text, Me.txtReason.Text, "Take Away", "Canceled")
                For Each dataGridViewRow6 As System.Windows.Forms.DataGridViewRow In CType(RestaurantPOS14.My.MyProject.Forms.frmPOS.DataGridView3.Rows, System.Collections.IEnumerable)
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Insert Into DeletedInvoices_Join(BillNo,ItemName,Qty,TotalAmount) Values(@d1,@d2,@d3,@d4)")
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBillNo1.Text)
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", dataGridViewRow6.Cells(CInt((0))).Value.ToString())
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow6.Cells(CInt((2))).Value)))
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow6.Cells(CInt((12))).Value)))
                    RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                    RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                    RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                    RestaurantPOS14.ModClasses.con.Close()
                Next

                Call RestaurantPOS14.My.MyProject.Forms.frmPOS.VoidBill1()
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "Void RTA", TextCompare:=False) = 0 Then
                RestaurantPOS14.ModFunc.InvoiceDeleteFunc(RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBillNo1.Text, RestaurantPOS14.My.MyProject.Forms.frmPOS.dtpBillDate.Value, New Decimal(Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtGrandTotal1.Text)), RestaurantPOS14.My.MyProject.Forms.frmPOS.lblUserVAL.Text, RestaurantPOS14.My.MyProject.Forms.frmPOS.lblPaymentMode1.Text, Me.txtReason.Text, "Take Away", "Canceled")
                For Each dataGridViewRow7 As System.Windows.Forms.DataGridViewRow In CType(RestaurantPOS14.My.MyProject.Forms.frmPOS.DataGridView3.Rows, System.Collections.IEnumerable)
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Insert Into DeletedInvoices_Join(BillNo,ItemName,Qty,TotalAmount) Values(@d1,@d2,@d3,@d4)")
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBillNo1.Text)
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", dataGridViewRow7.Cells(CInt((0))).Value.ToString())
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow7.Cells(CInt((2))).Value)))
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow7.Cells(CInt((12))).Value)))
                    RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                    RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                    RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                    RestaurantPOS14.ModClasses.con.Close()
                Next

                Call RestaurantPOS14.My.MyProject.Forms.frmPOS.RollBackStock1()
                Call RestaurantPOS14.My.MyProject.Forms.frmPOS.VoidBill1()
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "HD", TextCompare:=False) = 0 Then
                RestaurantPOS14.ModFunc.InvoiceDeleteFunc(RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBillNo2.Text, RestaurantPOS14.My.MyProject.Forms.frmPOS.dtpBillDate.Value, New Decimal(Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtGrandTotal2.Text)), RestaurantPOS14.My.MyProject.Forms.frmPOS.lblUserVAL.Text, RestaurantPOS14.My.MyProject.Forms.frmPOS.lblPaymentMode2.Text, Me.txtReason.Text, "Home Delivery", "Deleted")
                For Each dataGridViewRow8 As System.Windows.Forms.DataGridViewRow In CType(RestaurantPOS14.My.MyProject.Forms.frmPOS.DataGridView4.Rows, System.Collections.IEnumerable)
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Insert Into DeletedInvoices_Join(BillNo,ItemName,Qty,TotalAmount) Values(@d1,@d2,@d3,@d4)")
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBillNo2.Text)
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", dataGridViewRow8.Cells(CInt((0))).Value.ToString())
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow8.Cells(CInt((2))).Value)))
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow8.Cells(CInt((12))).Value)))
                    RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                    RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                    RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                    RestaurantPOS14.ModClasses.con.Close()
                Next

                Call RestaurantPOS14.My.MyProject.Forms.frmPOS.DeleteRecord3()
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "Void HD", TextCompare:=False) = 0 Then
                RestaurantPOS14.ModFunc.InvoiceDeleteFunc(RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBillNo2.Text, RestaurantPOS14.My.MyProject.Forms.frmPOS.dtpBillDate.Value, New Decimal(Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtGrandTotal2.Text)), RestaurantPOS14.My.MyProject.Forms.frmPOS.lblUserVAL.Text, RestaurantPOS14.My.MyProject.Forms.frmPOS.lblPaymentMode2.Text, Me.txtReason.Text, "Home Delivery", "Canceled")
                For Each dataGridViewRow9 As System.Windows.Forms.DataGridViewRow In CType(RestaurantPOS14.My.MyProject.Forms.frmPOS.DataGridView4.Rows, System.Collections.IEnumerable)
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Insert Into DeletedInvoices_Join(BillNo,ItemName,Qty,TotalAmount) Values(@d1,@d2,@d3,@d4)")
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBillNo2.Text)
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", dataGridViewRow9.Cells(CInt((0))).Value.ToString())
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow9.Cells(CInt((2))).Value)))
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow9.Cells(CInt((12))).Value)))
                    RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                    RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                    RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                    RestaurantPOS14.ModClasses.con.Close()
                Next

                Call RestaurantPOS14.My.MyProject.Forms.frmPOS.VoidBill2()
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "Void RHD", TextCompare:=False) = 0 Then
                RestaurantPOS14.ModFunc.InvoiceDeleteFunc(RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBillNo2.Text, RestaurantPOS14.My.MyProject.Forms.frmPOS.dtpBillDate.Value, New Decimal(Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtGrandTotal2.Text)), RestaurantPOS14.My.MyProject.Forms.frmPOS.lblUserVAL.Text, RestaurantPOS14.My.MyProject.Forms.frmPOS.lblPaymentMode2.Text, Me.txtReason.Text, "Home Delivery", "Canceled")
                For Each dataGridViewRow10 As System.Windows.Forms.DataGridViewRow In CType(RestaurantPOS14.My.MyProject.Forms.frmPOS.DataGridView4.Rows, System.Collections.IEnumerable)
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Insert Into DeletedInvoices_Join(BillNo,ItemName,Qty,TotalAmount) Values(@d1,@d2,@d3,@d4)")
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBillNo2.Text)
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", dataGridViewRow10.Cells(CInt((0))).Value.ToString())
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow10.Cells(CInt((2))).Value)))
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow10.Cells(CInt((12))).Value)))
                    RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                    RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                    RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                    RestaurantPOS14.ModClasses.con.Close()
                Next

                Call RestaurantPOS14.My.MyProject.Forms.frmPOS.RollBackStock2()
                Call RestaurantPOS14.My.MyProject.Forms.frmPOS.VoidBill2()
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "EB", TextCompare:=False) = 0 Then
                RestaurantPOS14.ModFunc.InvoiceDeleteFunc(RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBillNo3.Text, RestaurantPOS14.My.MyProject.Forms.frmPOS.dtpBillDate.Value, New Decimal(Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtGrandTotal3.Text)), RestaurantPOS14.My.MyProject.Forms.frmPOS.lblUserVAL.Text, RestaurantPOS14.My.MyProject.Forms.frmPOS.lblPaymentMode3.Text, Me.txtReason.Text, "Express Billing", "Deleted")
                For Each dataGridViewRow11 As System.Windows.Forms.DataGridViewRow In CType(RestaurantPOS14.My.MyProject.Forms.frmPOS.DataGridView5.Rows, System.Collections.IEnumerable)
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Insert Into DeletedInvoices_Join(BillNo,ItemName,Qty,TotalAmount) Values(@d1,@d2,@d3,@d4)")
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBillNo3.Text)
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", dataGridViewRow11.Cells(CInt((0))).Value.ToString())
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow11.Cells(CInt((2))).Value)))
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow11.Cells(CInt((12))).Value)))
                    RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                    RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                    RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                    RestaurantPOS14.ModClasses.con.Close()
                Next

                Call RestaurantPOS14.My.MyProject.Forms.frmPOS.DeleteRecord4()
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "Void EB", TextCompare:=False) = 0 Then
                RestaurantPOS14.ModFunc.InvoiceDeleteFunc(RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBillNo3.Text, RestaurantPOS14.My.MyProject.Forms.frmPOS.dtpBillDate.Value, New Decimal(Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtGrandTotal3.Text)), RestaurantPOS14.My.MyProject.Forms.frmPOS.lblUserVAL.Text, RestaurantPOS14.My.MyProject.Forms.frmPOS.lblPaymentMode3.Text, Me.txtReason.Text, "Express Billing", "Canceled")
                For Each dataGridViewRow12 As System.Windows.Forms.DataGridViewRow In CType(RestaurantPOS14.My.MyProject.Forms.frmPOS.DataGridView5.Rows, System.Collections.IEnumerable)
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Insert Into DeletedInvoices_Join(BillNo,ItemName,Qty,TotalAmount) Values(@d1,@d2,@d3,@d4)")
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBillNo3.Text)
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", dataGridViewRow12.Cells(CInt((0))).Value.ToString())
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow12.Cells(CInt((2))).Value)))
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow12.Cells(CInt((12))).Value)))
                    RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                    RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                    RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                    RestaurantPOS14.ModClasses.con.Close()
                Next

                Call RestaurantPOS14.My.MyProject.Forms.frmPOS.VoidBill3()
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "Void REB", TextCompare:=False) = 0 Then
                RestaurantPOS14.ModFunc.InvoiceDeleteFunc(RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBillNo3.Text, RestaurantPOS14.My.MyProject.Forms.frmPOS.dtpBillDate.Value, New Decimal(Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtGrandTotal3.Text)), RestaurantPOS14.My.MyProject.Forms.frmPOS.lblUserVAL.Text, RestaurantPOS14.My.MyProject.Forms.frmPOS.lblPaymentMode3.Text, Me.txtReason.Text, "Express Billing", "Canceled")
                For Each dataGridViewRow13 As System.Windows.Forms.DataGridViewRow In CType(RestaurantPOS14.My.MyProject.Forms.frmPOS.DataGridView5.Rows, System.Collections.IEnumerable)
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Insert Into DeletedInvoices_Join(BillNo,ItemName,Qty,TotalAmount) Values(@d1,@d2,@d3,@d4)")
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBillNo3.Text)
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", dataGridViewRow13.Cells(CInt((0))).Value.ToString())
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow13.Cells(CInt((2))).Value)))
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow13.Cells(CInt((12))).Value)))
                    RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                    RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                    RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                    RestaurantPOS14.ModClasses.con.Close()
                Next

                Call RestaurantPOS14.My.MyProject.Forms.frmPOS.RollBackStock3()
                Call RestaurantPOS14.My.MyProject.Forms.frmPOS.VoidBill3()
            End If

            Me.lblSet.Text = ""
            MyBase.Close()
        End Sub

        Private Sub btnCancel_Click(sender As Object, e As System.EventArgs)
            MyBase.Close()
        End Sub

        Private Sub frmCustomDialog19_Load(sender As Object, e As System.EventArgs)
            Me.txtReason.Text = ""
            Me.txtReason.Focus()
        End Sub

        Private Sub frmCustomDialogX_Shown(sender As Object, e As System.EventArgs)
            Me.txtReason.Text = ""
            Me.txtReason.Focus()
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
            Me.Label2 = New System.Windows.Forms.Label()
            Me.btnOK = New System.Windows.Forms.Button()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.RadVirtualKeyboard1 = New Telerik.WinControls.UI.RadVirtualKeyboard()
            Me.lblSet = New System.Windows.Forms.Label()
            Me.txtReason = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.AquaTheme1 = New Telerik.WinControls.Themes.AquaTheme()
            Me.VisualStudio2012DarkTheme1 = New Telerik.WinControls.Themes.VisualStudio2012DarkTheme()
            Me.Panel1.SuspendLayout()
            CType(Me.RadVirtualKeyboard1, System.ComponentModel.ISupportInitialize).BeginInit()
            MyBase.SuspendLayout()
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label2.ForeColor = System.Drawing.Color.White
            Dim label As System.Windows.Forms.Label = Me.Label2
            Dim location As System.Drawing.Point = New System.Drawing.Point(253, 4)
            label.Location = location
            Me.Label2.Name = "Label2"
            Dim label2 As System.Windows.Forms.Label = Me.Label2
            Dim size As System.Drawing.Size = New System.Drawing.Size(315, 80)
            label2.Size = size
            Me.Label2.TabIndex = 31
            Me.Label2.Text = "Are you sure want to" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "delete/cancel invoice ?"
            Me.btnOK.BackColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.btnOK.FlatAppearance.BorderSize = 0
            Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnOK.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnOK.ForeColor = System.Drawing.Color.White
            Dim button As System.Windows.Forms.Button = Me.btnOK
            location = New System.Drawing.Point(260, 219)
            button.Location = location
            Me.btnOK.Name = "btnOK"
            Dim button2 As System.Windows.Forms.Button = Me.btnOK
            size = New System.Drawing.Size(124, 62)
            button2.Size = size
            Me.btnOK.TabIndex = 32
            Me.btnOK.Text = "OK"
            Me.btnOK.UseVisualStyleBackColor = False
            Me.Panel1.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.RadVirtualKeyboard1)
            Me.Panel1.Controls.Add(Me.lblSet)
            Me.Panel1.Controls.Add(Me.txtReason)
            Me.Panel1.Controls.Add(Me.Label1)
            Me.Panel1.Controls.Add(Me.btnCancel)
            Me.Panel1.Controls.Add(Me.Label2)
            Me.Panel1.Controls.Add(Me.btnOK)
            Dim panel As System.Windows.Forms.Panel = Me.Panel1
            location = New System.Drawing.Point(0, 0)
            panel.Location = location
            Me.Panel1.Name = "Panel1"
            Dim panel2 As System.Windows.Forms.Panel = Me.Panel1
            size = New System.Drawing.Size(828, 670)
            panel2.Size = size
            Me.Panel1.TabIndex = 33
            Me.RadVirtualKeyboard1.LayoutType = Telerik.WinControls.VirtualKeyboard.KeyboardLayoutType.Simplified
            Dim radVirtualKeyboard As Telerik.WinControls.UI.RadVirtualKeyboard = Me.RadVirtualKeyboard1
            location = New System.Drawing.Point(3, 296)
            radVirtualKeyboard.Location = location
            Me.RadVirtualKeyboard1.Name = "RadVirtualKeyboard1"
            Dim radVirtualKeyboard2 As Telerik.WinControls.UI.RadVirtualKeyboard = Me.RadVirtualKeyboard1
            size = New System.Drawing.Size(820, 369)
            radVirtualKeyboard2.Size = size
            Me.RadVirtualKeyboard1.TabIndex = 34
            Me.RadVirtualKeyboard1.TabStop = False
            Me.RadVirtualKeyboard1.ThemeName = "VisualStudio2012Dark"
            Me.lblSet.AutoSize = True
            Dim label3 As System.Windows.Forms.Label = Me.lblSet
            location = New System.Drawing.Point(478, 70)
            label3.Location = location
            Me.lblSet.Name = "lblSet"
            Dim label4 As System.Windows.Forms.Label = Me.lblSet
            size = New System.Drawing.Size(23, 13)
            label4.Size = size
            Me.lblSet.TabIndex = 36
            Me.lblSet.Text = "Set"
            Me.lblSet.Visible = False
            Me.txtReason.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox As System.Windows.Forms.TextBox = Me.txtReason
            location = New System.Drawing.Point(260, 136)
            textBox.Location = location
            Me.txtReason.Multiline = True
            Me.txtReason.Name = "txtReason"
            Me.txtReason.ScrollBars = System.Windows.Forms.ScrollBars.Both
            Dim textBox2 As System.Windows.Forms.TextBox = Me.txtReason
            size = New System.Drawing.Size(318, 77)
            textBox2.Size = size
            Me.txtReason.TabIndex = 35
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label1.ForeColor = System.Drawing.Color.White
            Dim label5 As System.Windows.Forms.Label = Me.Label1
            location = New System.Drawing.Point(255, 103)
            label5.Location = location
            Me.Label1.Name = "Label1"
            Dim label6 As System.Windows.Forms.Label = Me.Label1
            size = New System.Drawing.Size(181, 30)
            label6.Size = size
            Me.Label1.TabIndex = 34
            Me.Label1.Text = "Enter the reason :"
            Me.btnCancel.BackColor = System.Drawing.Color.Crimson
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.FlatAppearance.BorderSize = 0
            Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnCancel.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnCancel.ForeColor = System.Drawing.Color.White
            Dim button3 As System.Windows.Forms.Button = Me.btnCancel
            location = New System.Drawing.Point(390, 219)
            button3.Location = location
            Me.btnCancel.Name = "btnCancel"
            Dim button4 As System.Windows.Forms.Button = Me.btnCancel
            size = New System.Drawing.Size(128, 62)
            button4.Size = size
            Me.btnCancel.TabIndex = 33
            Me.btnCancel.Text = "Cancel"
            Me.btnCancel.UseVisualStyleBackColor = False
            MyBase.AcceptButton = Me.btnOK
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            MyBase.CancelButton = Me.btnCancel
            size = New System.Drawing.Size(828, 671)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.Panel1)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            MyBase.Name = "frmCustomDialogX"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            CType(Me.RadVirtualKeyboard1, System.ComponentModel.ISupportInitialize).EndInit()
            MyBase.ResumeLayout(False)
        End Sub
    End Class
End Namespace
