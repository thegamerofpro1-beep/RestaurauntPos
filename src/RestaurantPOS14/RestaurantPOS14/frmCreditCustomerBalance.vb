Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports GelButtons
Imports Microsoft.VisualBasic.CompilerServices
Imports RestaurantPOS14.My

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public Class frmCreditCustomerBalance
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("dgw")>
        Private _dgw As System.Windows.Forms.DataGridView

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column5")>
        Private _Column5 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column1")>
        Private _Column1 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column2")>
        Private _Column2 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column3")>
        Private _Column3 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column4")>
        Private _Column4 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblUser")>
        Private _lblUser As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox4")>
        Private _GroupBox4 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnSearch")>
        Private _btnSearch As GelButtons.GelButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label2")>
        Private _Label2 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GelButton1")>
        Private _GelButton1 As GelButtons.GelButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtKeyword")>
        Private _txtKeyword As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label1")>
        Private _Label1 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("cmbFilterBy")>
        Private _cmbFilterBy As System.Windows.Forms.ComboBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnShowALL")>
        Private _btnShowALL As GelButtons.GelButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnAddNew")>
        Private _btnAddNew As GelButtons.GelButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblSet")>
        Private _lblSet As System.Windows.Forms.Label

        Private components As System.ComponentModel.IContainer

        Friend Overridable Property dgw As System.Windows.Forms.DataGridView
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._dgw
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridView)
                Dim value2 As System.Windows.Forms.MouseEventHandler = AddressOf Me.dgw_MouseClick
                Dim value3 As System.Windows.Forms.DataGridViewRowPostPaintEventHandler = AddressOf Me.dgw_RowPostPaint
                If Me._dgw IsNot Nothing Then
                    RemoveHandler Me._dgw.MouseClick, value2
                    RemoveHandler Me._dgw.RowPostPaint, value3
                End If

                Me._dgw = value
                If Me._dgw IsNot Nothing Then
                    AddHandler Me._dgw.MouseClick, value2
                    AddHandler Me._dgw.RowPostPaint, value3
                End If
            End Set
        End Property

        Friend Overridable Property Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Column5
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._Column5 = value
            End Set
        End Property

        Friend Overridable Property Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Column1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._Column1 = value
            End Set
        End Property

        Friend Overridable Property Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Column2
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._Column2 = value
            End Set
        End Property

        Friend Overridable Property Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Column3
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._Column3 = value
            End Set
        End Property

        Friend Overridable Property Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Column4
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._Column4 = value
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

        Friend Overridable Property GroupBox4 As System.Windows.Forms.GroupBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._GroupBox4
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.GroupBox)
                Me._GroupBox4 = value
            End Set
        End Property

        Friend Overridable Property btnSearch As GelButtons.GelButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnSearch
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As GelButtons.GelButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnSearch_Click
                If Me._btnSearch IsNot Nothing Then
                    RemoveHandler Me._btnSearch.Click, value2
                End If

                Me._btnSearch = value
                If Me._btnSearch IsNot Nothing Then
                    AddHandler Me._btnSearch.Click, value2
                End If
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

        Friend Overridable Property GelButton1 As GelButtons.GelButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._GelButton1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As GelButtons.GelButton)
                Dim value2 As System.EventHandler = AddressOf Me.GelButton1_Click
                If Me._GelButton1 IsNot Nothing Then
                    RemoveHandler Me._GelButton1.Click, value2
                End If

                Me._GelButton1 = value
                If Me._GelButton1 IsNot Nothing Then
                    AddHandler Me._GelButton1.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property txtKeyword As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtKeyword
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtKeyword = value
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

        Friend Overridable Property cmbFilterBy As System.Windows.Forms.ComboBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._cmbFilterBy
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ComboBox)
                Dim value2 As System.EventHandler = AddressOf Me.cmbFilterBy_SelectedIndexChanged
                If Me._cmbFilterBy IsNot Nothing Then
                    RemoveHandler Me._cmbFilterBy.SelectedIndexChanged, value2
                End If

                Me._cmbFilterBy = value
                If Me._cmbFilterBy IsNot Nothing Then
                    AddHandler Me._cmbFilterBy.SelectedIndexChanged, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnShowALL As GelButtons.GelButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnShowALL
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As GelButtons.GelButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnShowALL_Click
                If Me._btnShowALL IsNot Nothing Then
                    RemoveHandler Me._btnShowALL.Click, value2
                End If

                Me._btnShowALL = value
                If Me._btnShowALL IsNot Nothing Then
                    AddHandler Me._btnShowALL.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnAddNew As GelButtons.GelButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnAddNew
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As GelButtons.GelButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnAddNew_Click
                If Me._btnAddNew IsNot Nothing Then
                    RemoveHandler Me._btnAddNew.Click, value2
                End If

                Me._btnAddNew = value
                If Me._btnAddNew IsNot Nothing Then
                    AddHandler Me._btnAddNew.Click, value2
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

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            Call RestaurantPOS14.frmCreditCustomerBalance.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmCreditCustomerBalance.__ENCList
                If RestaurantPOS14.frmCreditCustomerBalance.__ENCList.Count = RestaurantPOS14.frmCreditCustomerBalance.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmCreditCustomerBalance.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmCreditCustomerBalance.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmCreditCustomerBalance.__ENCList(num) = RestaurantPOS14.frmCreditCustomerBalance.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmCreditCustomerBalance.__ENCList.RemoveRange(num, RestaurantPOS14.frmCreditCustomerBalance.__ENCList.Count - num)
                    RestaurantPOS14.frmCreditCustomerBalance.__ENCList.Capacity = RestaurantPOS14.frmCreditCustomerBalance.__ENCList.Count
                End If

                Call RestaurantPOS14.frmCreditCustomerBalance.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Public Sub Reset()
            Me.cmbFilterBy.SelectedIndex = 0
            Me.txtKeyword.Text = ""
            Me.dgw.Rows.Clear()
            Me.txtKeyword.Focus()
        End Sub

        Public Sub GetData()
            Try
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT CC_ID,CreditCustomer.CreditCustomerID,RTRIM(CreditCustomer.Name),RTRIM(ContactNo),IsNull(sum(Credit)-sum(Debit),0) FROM CreditCustomer Left join LedgerBook on CreditCustomer.CreditCustomerID=LedgerBook.PartyID where Active='Yes' group by CC_ID, CreditCustomerID,CreditCustomer.name,ContactNo order by CreditCustomer.Name", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                Me.dgw.Rows.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Me.dgw.Rows.Add(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(0)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(1)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(2)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(3)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(4)))
                End While

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub dgw_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs)
            Try
                If Me.dgw.Rows.Count > 0 Then
                    Dim dataGridViewRow As System.Windows.Forms.DataGridViewRow = Me.dgw.SelectedRows(0)
                    If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "HD", TextCompare:=False) = 0 Then
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.lblPaymentMode2.Text = "Credit Customer"
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.lblMemberID.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(dataGridViewRow.Cells(CInt((1))).Value)
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtCustID.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(dataGridViewRow.Cells(CInt((0))).Value)
                        Me.POSHeaderClear()
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.lblCustName.Visible = True
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.lblCustNameVAL.Visible = True
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.lblCustNameVAL.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(dataGridViewRow.Cells(CInt((2))).Value)
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.btnCash2.Enabled = False
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.btnCreditCard2.Enabled = False
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.btnDebitCard2.Enabled = False
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.btnCards2.Enabled = False
                        MyBase.Close()
                    End If

                    If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "Dine In Billing", TextCompare:=False) = 0 Then
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.lblPaymentMode.Text = "Credit Customer"
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.lblMemberID.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(dataGridViewRow.Cells(CInt((1))).Value)
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtCustID.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(dataGridViewRow.Cells(CInt((0))).Value)
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtCash.[ReadOnly] = True
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtCard.[ReadOnly] = True
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtCash.Text = "0.00"
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtCard.Text = "0.00"
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtChange.Text = "0.00"
                        Me.POSHeaderClear()
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.lblCustName.Visible = True
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.lblCustNameVAL.Visible = True
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.lblCustNameVAL.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(dataGridViewRow.Cells(CInt((2))).Value)
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.btnCash.Enabled = False
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.btnCreditCard.Enabled = False
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.btnDebitCard.Enabled = False
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.btnCards.Enabled = False
                        MyBase.Close()
                    End If

                    If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "TA", TextCompare:=False) = 0 Then
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.lblPaymentMode1.Text = "Credit Customer"
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.lblMemberID.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(dataGridViewRow.Cells(CInt((1))).Value)
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtCustID.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(dataGridViewRow.Cells(CInt((0))).Value)
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtCash1.[ReadOnly] = True
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtCard1.[ReadOnly] = True
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtCash1.Text = "0.00"
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtCard1.Text = "0.00"
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtChange1.Text = "0.00"
                        Me.POSHeaderClear()
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.lblCustName.Visible = True
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.lblCustNameVAL.Visible = True
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.lblCustNameVAL.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(dataGridViewRow.Cells(CInt((2))).Value)
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.btnCash1.Enabled = False
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.btnCreditCard1.Enabled = False
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.btnDebitCard1.Enabled = False
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.btnCards1.Enabled = False
                        MyBase.Close()
                    End If

                    If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "EB", TextCompare:=False) = 0 Then
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.lblPaymentMode3.Text = "Credit Customer"
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.lblMemberID.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(dataGridViewRow.Cells(CInt((1))).Value)
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtCustID.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(dataGridViewRow.Cells(CInt((0))).Value)
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtCash3.[ReadOnly] = True
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtCard3.[ReadOnly] = True
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtCash3.Text = "0.00"
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtCard3.Text = "0.00"
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtChange3.Text = "0.00"
                        Me.POSHeaderClear()
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.lblCustName.Visible = True
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.lblCustNameVAL.Visible = True
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.lblCustNameVAL.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(dataGridViewRow.Cells(CInt((2))).Value)
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.btnCash3.Enabled = False
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.btnCreditCard3.Enabled = False
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.btnDebitCard3.Enabled = False
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.btnCards3.Enabled = False
                        MyBase.Close()
                    End If

                    If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "CEB", TextCompare:=False) = 0 Then
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.lblPaymentMode3.Text = "Credit Customer"
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.lblMemberID.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(dataGridViewRow.Cells(CInt((1))).Value)
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtCustID.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(dataGridViewRow.Cells(CInt((0))).Value)
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtCash3.[ReadOnly] = True
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtCard3.[ReadOnly] = True
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtCash3.Text = "0.00"
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtCard3.Text = "0.00"
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtChange3.Text = "0.00"
                        Me.POSHeaderClear()
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.lblCustName.Visible = True
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.lblCustNameVAL.Visible = True
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.lblCustNameVAL.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(dataGridViewRow.Cells(CInt((2))).Value)
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.btnCash3.Enabled = False
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.btnCreditCard3.Enabled = False
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.btnDebitCard3.Enabled = False
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.btnCards3.Enabled = False
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.tlPanel.Enabled = False
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.btnSendOrder1.Enabled = False
                        MyBase.Close()
                    End If

                    Me.lblSet.Text = ""
                End If
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub POSHeaderClear()
            RestaurantPOS14.My.MyProject.Forms.frmPOS.lblPOS.Visible = False
            RestaurantPOS14.My.MyProject.Forms.frmPOS.lblU.Visible = False
            RestaurantPOS14.My.MyProject.Forms.frmPOS.lblUserVAL.Visible = False
            RestaurantPOS14.My.MyProject.Forms.frmPOS.lblOD.Visible = False
            RestaurantPOS14.My.MyProject.Forms.frmPOS.lblOrderNo.Visible = False
        End Sub

        Private Sub dgw_RowPostPaint(sender As Object, e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs)
            Dim text As String =(e.RowIndex + 1).ToString()
            Dim sizeF As System.Drawing.SizeF = e.Graphics.MeasureString(text, MyBase.Font)
            If Me.dgw.RowHeadersWidth < System.Convert.ToInt32(sizeF.Width + 20F) Then
                Me.dgw.RowHeadersWidth = System.Convert.ToInt32(sizeF.Width + 20F)
            End If

            Dim controlText As System.Drawing.Brush = System.Drawing.SystemBrushes.ControlText
            e.Graphics.DrawString(text, MyBase.Font, controlText, e.RowBounds.Location.X + 15, CSng(e.RowBounds.Location.Y) + (CSng(e.RowBounds.Height) - sizeF.Height) / 2F)
        End Sub

        Private Sub btnAddNew_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmCreditCustomerRegistration.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmCreditCustomerRegistration.Reset()
            RestaurantPOS14.My.MyProject.Forms.frmCreditCustomerRegistration.lblSet.Text = "POS"
            Call RestaurantPOS14.My.MyProject.Forms.frmCreditCustomerRegistration.ShowDialog()
        End Sub

        Private Sub GelButton1_Click(sender As Object, e As System.EventArgs)
            Me.Reset()
        End Sub

        Private Sub btnShowALL_Click(sender As Object, e As System.EventArgs)
            Me.GetData()
        End Sub

        Private Sub btnSearch_Click(sender As Object, e As System.EventArgs)
            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtKeyword.Text, "", TextCompare:=False) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please enter search keyword(s)", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtKeyword.Focus()
                Return
            End If

            If Me.cmbFilterBy.SelectedIndex = 0 Then
                Try
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT CC_ID,CreditCustomer.CreditCustomerID,RTRIM(CreditCustomer.Name),RTRIM(ContactNo),IsNull(sum(Credit)-sum(Debit),0) FROM CreditCustomer Left join LedgerBook on CreditCustomer.CreditCustomerID=LedgerBook.PartyID where Active='Yes' and CreditCustomer.Name like N'%" & Me.txtKeyword.Text & "%' group by CC_ID, CreditCustomerID,CreditCustomer.name,ContactNo order by CreditCustomer.Name", RestaurantPOS14.ModClasses.con)
                    RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                    Me.dgw.Rows.Clear()
                    While RestaurantPOS14.ModClasses.rdr.Read()
                        Me.dgw.Rows.Add(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(0)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(1)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(2)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(3)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(4)))
                    End While

                    RestaurantPOS14.ModClasses.con.Close()
                Catch ex As System.Exception
                    Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                End Try
            End If

            If Me.cmbFilterBy.SelectedIndex <> 1 Then
                Return
            End If

            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT CC_ID,CreditCustomer.CreditCustomerID,RTRIM(CreditCustomer.Name),RTRIM(ContactNo),IsNull(sum(Credit)-sum(Debit),0) FROM CreditCustomer Left join LedgerBook on CreditCustomer.CreditCustomerID=LedgerBook.PartyID where Active='Yes' and ContactNo like N'%" & Me.txtKeyword.Text & "%' group by CC_ID, CreditCustomerID,CreditCustomer.name,ContactNo order by CreditCustomer.Name", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                Me.dgw.Rows.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Me.dgw.Rows.Add(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(0)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(1)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(2)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(3)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(4)))
                End While

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex2 As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex2.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub cmbFilterBy_SelectedIndexChanged(sender As Object, e As System.EventArgs)
            Me.txtKeyword.Focus()
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
            Dim dataGridViewCellStyle As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmCreditCustomerBalance))
            Me.dgw = New System.Windows.Forms.DataGridView()
            Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.lblUser = New System.Windows.Forms.Label()
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.btnSearch = New GelButtons.GelButton()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.GelButton1 = New GelButtons.GelButton()
            Me.txtKeyword = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.cmbFilterBy = New System.Windows.Forms.ComboBox()
            Me.btnShowALL = New GelButtons.GelButton()
            Me.btnAddNew = New GelButtons.GelButton()
            Me.lblSet = New System.Windows.Forms.Label()
            CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox4.SuspendLayout()
            MyBase.SuspendLayout()
            Me.dgw.AllowUserToAddRows = False
            Me.dgw.AllowUserToDeleteRows = False
            dataGridViewCellStyle.BackColor = System.Drawing.Color.FloralWhite
            Me.dgw.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle
            Me.dgw.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.dgw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            Me.dgw.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
            Me.dgw.BackgroundColor = System.Drawing.Color.White
            Me.dgw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            dataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgw.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2
            Me.dgw.ColumnHeadersHeight = 40
            Me.dgw.Columns.AddRange(Me.Column5, Me.Column1, Me.Column2, Me.Column3, Me.Column4)
            Me.dgw.Cursor = System.Windows.Forms.Cursors.Hand
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            dataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgw.DefaultCellStyle = dataGridViewCellStyle3
            Me.dgw.EnableHeadersVisualStyles = False
            Me.dgw.GridColor = System.Drawing.Color.White
            Dim dataGridView As System.Windows.Forms.DataGridView = Me.dgw
            Dim location As System.Drawing.Point = New System.Drawing.Point(1, 91)
            dataGridView.Location = location
            Me.dgw.MultiSelect = False
            Me.dgw.Name = "dgw"
            Me.dgw.[ReadOnly] = True
            Me.dgw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White
            dataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gainsboro
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgw.RowHeadersDefaultCellStyle = dataGridViewCellStyle4
            Me.dgw.RowHeadersWidth = 25
            Me.dgw.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White
            dataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gainsboro
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
            Me.dgw.RowsDefaultCellStyle = dataGridViewCellStyle5
            Me.dgw.RowTemplate.Height = 50
            Me.dgw.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgw.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Dim dataGridView2 As System.Windows.Forms.DataGridView = Me.dgw
            Dim size As System.Drawing.Size = New System.Drawing.Size(986, 448)
            dataGridView2.Size = size
            Me.dgw.TabIndex = 41
            Me.Column5.HeaderText = "CC_ID"
            Me.Column5.Name = "Column5"
            Me.Column5.[ReadOnly] = True
            Me.Column5.Visible = False
            Me.Column1.FillWeight = 76.53061F
            Me.Column1.HeaderText = "Customer ID"
            Me.Column1.Name = "Column1"
            Me.Column1.[ReadOnly] = True
            Me.Column2.FillWeight = 162.7349F
            Me.Column2.HeaderText = "Customer Name"
            Me.Column2.Name = "Column2"
            Me.Column2.[ReadOnly] = True
            Me.Column3.FillWeight = 69.71115F
            Me.Column3.HeaderText = "Contact No."
            Me.Column3.Name = "Column3"
            Me.Column3.[ReadOnly] = True
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.Column4.DefaultCellStyle = dataGridViewCellStyle6
            Me.Column4.FillWeight = 91.02331F
            Me.Column4.HeaderText = "Balance"
            Me.Column4.Name = "Column4"
            Me.Column4.[ReadOnly] = True
            Me.lblUser.AutoSize = True
            Dim label As System.Windows.Forms.Label = Me.lblUser
            location = New System.Drawing.Point(900, 14)
            label.Location = location
            Me.lblUser.Name = "lblUser"
            Dim label2 As System.Windows.Forms.Label = Me.lblUser
            size = New System.Drawing.Size(39, 13)
            label2.Size = size
            Me.lblUser.TabIndex = 402
            Me.lblUser.Text = "Label8"
            Me.lblUser.Visible = False
            Me.GroupBox4.Controls.Add(Me.btnSearch)
            Me.GroupBox4.Controls.Add(Me.Label2)
            Me.GroupBox4.Controls.Add(Me.GelButton1)
            Me.GroupBox4.Controls.Add(Me.txtKeyword)
            Me.GroupBox4.Controls.Add(Me.Label1)
            Me.GroupBox4.Controls.Add(Me.cmbFilterBy)
            Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim groupBox As System.Windows.Forms.GroupBox = Me.GroupBox4
            location = New System.Drawing.Point(6, -1)
            groupBox.Location = location
            Me.GroupBox4.Name = "GroupBox4"
            Dim groupBox2 As System.Windows.Forms.GroupBox = Me.GroupBox4
            size = New System.Drawing.Size(583, 86)
            groupBox2.Size = size
            Me.GroupBox4.TabIndex = 403
            Me.GroupBox4.TabStop = False
            Me.GroupBox4.Text = "Search By Keyword"
            Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnSearch.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnSearch.ForeColor = System.Drawing.Color.White
            Me.btnSearch.GradientBottom = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.btnSearch.GradientTop = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.btnSearch.Image = CType(componentResourceManager.GetObject("btnSearch.Image"), System.Drawing.Image)
            Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim gelButton As GelButtons.GelButton = Me.btnSearch
            location = New System.Drawing.Point(394, 31)
            gelButton.Location = location
            Me.btnSearch.Name = "btnSearch"
            Dim gelButton2 As GelButtons.GelButton = Me.btnSearch
            size = New System.Drawing.Size(91, 47)
            gelButton2.Size = size
            Me.btnSearch.TabIndex = 2
            Me.btnSearch.Text = "&Search"
            Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnSearch.UseVisualStyleBackColor = False
            Me.Label2.AutoSize = True
            Dim label3 As System.Windows.Forms.Label = Me.Label2
            location = New System.Drawing.Point(190, 25)
            label3.Location = location
            Me.Label2.Name = "Label2"
            Dim label4 As System.Windows.Forms.Label = Me.Label2
            size = New System.Drawing.Size(82, 17)
            label4.Size = size
            Me.Label2.TabIndex = 14
            Me.Label2.Text = "Keyword(s) :"
            Me.GelButton1.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.GelButton1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.GelButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.GelButton1.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.GelButton1.ForeColor = System.Drawing.Color.White
            Me.GelButton1.GradientBottom = System.Drawing.Color.Crimson
            Me.GelButton1.GradientTop = System.Drawing.Color.Crimson
            Me.GelButton1.Image = CType(componentResourceManager.GetObject("GelButton1.Image"), System.Drawing.Image)
            Me.GelButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim gelButton3 As GelButtons.GelButton = Me.GelButton1
            location = New System.Drawing.Point(491, 31)
            gelButton3.Location = location
            Me.GelButton1.Name = "GelButton1"
            Dim gelButton4 As GelButtons.GelButton = Me.GelButton1
            size = New System.Drawing.Size(81, 47)
            gelButton4.Size = size
            Me.GelButton1.TabIndex = 3
            Me.GelButton1.Text = "Reset"
            Me.GelButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.GelButton1.UseVisualStyleBackColor = False
            Me.txtKeyword.Font = New System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox As System.Windows.Forms.TextBox = Me.txtKeyword
            location = New System.Drawing.Point(193, 45)
            textBox.Location = location
            Me.txtKeyword.Name = "txtKeyword"
            Dim textBox2 As System.Windows.Forms.TextBox = Me.txtKeyword
            size = New System.Drawing.Size(195, 29)
            textBox2.Size = size
            Me.txtKeyword.TabIndex = 0
            Me.Label1.AutoSize = True
            Dim label5 As System.Windows.Forms.Label = Me.Label1
            location = New System.Drawing.Point(7, 25)
            label5.Location = location
            Me.Label1.Name = "Label1"
            Dim label6 As System.Windows.Forms.Label = Me.Label1
            size = New System.Drawing.Size(64, 17)
            label6.Size = size
            Me.Label1.TabIndex = 13
            Me.Label1.Text = "Filter By :"
            Me.cmbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbFilterBy.Font = New System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.cmbFilterBy.FormattingEnabled = True
            Me.cmbFilterBy.Items.AddRange(New Object(1) {"Customer Name", "Contact No."})
            Dim comboBox As System.Windows.Forms.ComboBox = Me.cmbFilterBy
            location = New System.Drawing.Point(10, 45)
            comboBox.Location = location
            Me.cmbFilterBy.Name = "cmbFilterBy"
            Dim comboBox2 As System.Windows.Forms.ComboBox = Me.cmbFilterBy
            size = New System.Drawing.Size(177, 29)
            comboBox2.Size = size
            Me.cmbFilterBy.TabIndex = 1
            Me.btnShowALL.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.btnShowALL.FlatAppearance.BorderSize = 0
            Me.btnShowALL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnShowALL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnShowALL.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnShowALL.GradientBottom = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.btnShowALL.GradientTop = System.Drawing.Color.FromArgb(102, 106, 105)
            Dim gelButton5 As GelButtons.GelButton = Me.btnShowALL
            location = New System.Drawing.Point(693, 12)
            gelButton5.Location = location
            Me.btnShowALL.Name = "btnShowALL"
            Dim gelButton6 As GelButtons.GelButton = Me.btnShowALL
            size = New System.Drawing.Size(141, 61)
            gelButton6.Size = size
            Me.btnShowALL.TabIndex = 404
            Me.btnShowALL.Text = "Show All " & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Customers"
            Me.btnShowALL.UseVisualStyleBackColor = False
            Me.btnAddNew.BackColor = System.Drawing.Color.Navy
            Me.btnAddNew.FlatAppearance.BorderSize = 0
            Me.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnAddNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnAddNew.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnAddNew.GradientBottom = System.Drawing.Color.Crimson
            Me.btnAddNew.GradientTop = System.Drawing.Color.Crimson
            Dim gelButton7 As GelButtons.GelButton = Me.btnAddNew
            location = New System.Drawing.Point(840, 12)
            gelButton7.Location = location
            Me.btnAddNew.Name = "btnAddNew"
            Dim gelButton8 As GelButtons.GelButton = Me.btnAddNew
            size = New System.Drawing.Size(141, 61)
            gelButton8.Size = size
            Me.btnAddNew.TabIndex = 405
            Me.btnAddNew.Text = "Add New Customer"
            Me.btnAddNew.UseVisualStyleBackColor = False
            Me.lblSet.AutoSize = True
            Dim label7 As System.Windows.Forms.Label = Me.lblSet
            location = New System.Drawing.Point(637, 36)
            label7.Location = location
            Me.lblSet.Name = "lblSet"
            Dim label8 As System.Windows.Forms.Label = Me.lblSet
            size = New System.Drawing.Size(23, 13)
            label8.Size = size
            Me.lblSet.TabIndex = 406
            Me.lblSet.Text = "Set"
            Me.lblSet.Visible = False
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            size = New System.Drawing.Size(993, 540)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.lblSet)
            MyBase.Controls.Add(Me.btnShowALL)
            MyBase.Controls.Add(Me.btnAddNew)
            MyBase.Controls.Add(Me.GroupBox4)
            MyBase.Controls.Add(Me.lblUser)
            MyBase.Controls.Add(Me.dgw)
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.Name = "frmCreditCustomerBalance"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Credit Customers"
            MyBase.WindowState = System.Windows.Forms.FormWindowState.Maximized
            CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox4.ResumeLayout(False)
            Me.GroupBox4.PerformLayout()
            MyBase.ResumeLayout(False)
            MyBase.PerformLayout()
        End Sub
    End Class
End Namespace
