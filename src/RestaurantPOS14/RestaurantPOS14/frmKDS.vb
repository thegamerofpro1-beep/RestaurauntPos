Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports CButtonLib
Imports MetroFramework.Controls
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports RestaurantPOS14.My

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public Class frmKDS
        Inherits System.Windows.Forms.Form
        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("flpOrders")>
        Private _flpOrders As System.Windows.Forms.FlowLayoutPanel
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("cmbKOT")>
        Private _cmbKOT As System.Windows.Forms.ComboBox
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Timer1")>
        Private _Timer1 As System.Windows.Forms.Timer
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label1")>
        Private _Label1 As System.Windows.Forms.Label
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("MetroToggle1")>
        Private _MetroToggle1 As MetroFramework.Controls.MetroToggle
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label2")>
        Private _Label2 As System.Windows.Forms.Label
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblUserType")>
        Private _lblUserType As System.Windows.Forms.Label
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnCancel")>
        Private _btnCancel As CButtonLib.CButton
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel1")>
        Private _Panel1 As System.Windows.Forms.Panel
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label30")>
        Private _Label30 As System.Windows.Forms.Label
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label3")>
        Private _Label3 As System.Windows.Forms.Label
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblUser")>
        Private _lblUser As System.Windows.Forms.Label
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("dgwDI")>
        Private _dgwDI As System.Windows.Forms.DataGridView
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column1")>
        Private _Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column2")>
        Private _Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column3")>
        Private _Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column4")>
        Private _Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column5")>
        Private _Column5 As System.Windows.Forms.DataGridViewButtonColumn
        Private s1 As String
        Private s2 As String
        Private components As System.ComponentModel.IContainer
        Friend Overridable Property flpOrders As System.Windows.Forms.FlowLayoutPanel
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._flpOrders
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.FlowLayoutPanel)
                Me._flpOrders = value
            End Set
        End Property

        Friend Overridable Property cmbKOT As System.Windows.Forms.ComboBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._cmbKOT
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ComboBox)
                Me._cmbKOT = value
            End Set
        End Property

        Friend Overridable Property Timer1 As System.Windows.Forms.Timer
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Timer1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Timer)
                Dim value2 As System.EventHandler = AddressOf Me.Timer1_Tick
                If Me._Timer1 IsNot Nothing Then
                    RemoveHandler Me._Timer1.Tick, value2
                End If

                Me._Timer1 = value
                If Me._Timer1 IsNot Nothing Then
                    AddHandler Me._Timer1.Tick, value2
                End If
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

        Friend Overridable Property MetroToggle1 As MetroFramework.Controls.MetroToggle
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._MetroToggle1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As MetroFramework.Controls.MetroToggle)
                Dim value2 As System.EventHandler = AddressOf Me.MetroToggle1_CheckedChanged
                If Me._MetroToggle1 IsNot Nothing Then
                    RemoveHandler Me._MetroToggle1.CheckedChanged, value2
                End If

                Me._MetroToggle1 = value
                If Me._MetroToggle1 IsNot Nothing Then
                    AddHandler Me._MetroToggle1.CheckedChanged, value2
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

        Friend Overridable Property lblUserType As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._lblUserType
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._lblUserType = value
            End Set
        End Property

        Friend Overridable Property btnCancel As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnCancel
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim obj As CButtonLib.CButton.ClickButtonAreaEventHandler = AddressOf Me.btnCancel_ClickButtonArea
                If Me._btnCancel IsNot Nothing Then
                    RemoveHandler Me._btnCancel.ClickButtonArea, obj
                End If

                Me._btnCancel = value
                If Me._btnCancel IsNot Nothing Then
                    AddHandler Me._btnCancel.ClickButtonArea, obj
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

        Friend Overridable Property Label30 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label30
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label30 = value
            End Set
        End Property

        Friend Overridable Property Label3 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label3
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label3 = value
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

        Friend Overridable Property dgwDI As System.Windows.Forms.DataGridView
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._dgwDI
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridView)
                Me._dgwDI = value
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

        Friend Overridable Property Column5 As System.Windows.Forms.DataGridViewButtonColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Column5
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewButtonColumn)
                Me._Column5 = value
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            AddHandler MyBase.Load, AddressOf Me.frmKDS_Load
            Call RestaurantPOS14.frmKDS.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmKDS.__ENCList
                If RestaurantPOS14.frmKDS.__ENCList.Count = RestaurantPOS14.frmKDS.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmKDS.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmKDS.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmKDS.__ENCList(num) = RestaurantPOS14.frmKDS.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmKDS.__ENCList.RemoveRange(num, RestaurantPOS14.frmKDS.__ENCList.Count - num)
                    RestaurantPOS14.frmKDS.__ENCList.Capacity = RestaurantPOS14.frmKDS.__ENCList.Count
                End If

                Call RestaurantPOS14.frmKDS.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.NoInlining Or System.Runtime.CompilerServices.MethodImplOptions.NoOptimization)>
        Public Sub GetData()
            Try
                If Not Me.DBConnectionStatus() Then
                    Call System.Windows.Forms.MessageBox.Show("Failed to connect with Database", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                    Call Microsoft.VisualBasic.CompilerServices.ProjectData.EndApp()
                End If

                Me.flpOrders.Controls.Clear()
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                Dim sqlConnection As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                sqlConnection.Open()
                RestaurantPOS14.ModClasses.adp = New System.Data.SqlClient.SqlDataAdapter()
                RestaurantPOS14.ModClasses.adp.SelectCommand = New System.Data.SqlClient.SqlCommand("SELECT RTRIM(TicketNo),BillDate from RestaurantPOS_OrderInfoKOT where KOT_Status='Open'  UNION SELECT RTRIM(BillNo),BillDate from RestaurantPOS_BillingInfoTA where TA_Status in ('Unpaid','Paid Directly') UNION SELECT RTRIM(BillNo),BillDate from RestaurantPOS_BillingInfoHD where HD_Status='Confirmed' UNION SELECT RTRIM(BillNo),BillDate from RestaurantPOS_BillingInfoEB where EB_Status in ('Unpaid','Paid Directly') order by 2", sqlConnection)
                RestaurantPOS14.ModClasses.ds = New System.Data.DataSet("ds")
                RestaurantPOS14.ModClasses.adp.Fill(RestaurantPOS14.ModClasses.ds)
                Dim dataTable As System.Data.DataTable = RestaurantPOS14.ModClasses.ds.Tables(0)
                Me.cmbKOT.Items.Clear()
                For Each dataRow As System.Data.DataRow In dataTable.Rows
                    Me.cmbKOT.Items.Add(dataRow(CInt((0))).ToString())
                Next

                sqlConnection.Close()
                For Each item As Object In Me.cmbKOT.Items
                    Dim text As String = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(item)
                    Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Select Distinct RTRIM(Dish),Quantity,RTRIM(TableNo),RTRIM(Notes),BillDate,RTRIM(ODNX) from RestaurantPOS_OrderedProductKOT,RestaurantPOS_OrderInfoKOT where RestaurantPOS_OrderInfoKOT.ID=RestaurantPOS_OrderedProductKOT.TicketID and TicketNo=@d1 and KOT_Status='Open' UNION SELECT Distinct RTRIM(Dish),Quantity,'',RTRIM(Notes),BillDate,RTRIM(ODN) from RestaurantPOS_BillingInfoTA,RestaurantPOS_OrderedProductBillTA where RestaurantPOS_BillingInfoTA.ID=RestaurantPOS_OrderedProductBillTA.BillID and BillNo=@d1 and TA_Status in ('Unpaid','Paid Directly') UNION SELECT Distinct RTRIM(Dish),Quantity,'',RTRIM(Notes),BillDate,RTRIM(ODN) from RestaurantPOS_BillingInfoHD,RestaurantPOS_OrderedProductBillHD where RestaurantPOS_BillingInfoHD.ID=RestaurantPOS_OrderedProductBillHD.BillID and BillNo=@d1 and HD_Status='Confirmed' UNION SELECT Distinct RTRIM(Dish),Quantity,'',RTRIM(Notes),BillDate,RTRIM(ODN) from RestaurantPOS_BillingInfoEB,RestaurantPOS_OrderedProductBillEB where RestaurantPOS_BillingInfoEB.ID=RestaurantPOS_OrderedProductBillEB.BillID and BillNo=@d1 and EB_Status in ('Unpaid','Paid Directly') order by 5")
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", text)
                    RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                    RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                    RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                    Dim flowLayoutPanel As System.Windows.Forms.FlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
                    Dim size As System.Drawing.Size = New System.Drawing.Size(295, 460)
                    flowLayoutPanel.Size = size
                    flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
                    flowLayoutPanel.AutoSize = False
                    Dim label As System.Windows.Forms.Label = New System.Windows.Forms.Label()
                    Dim label2 As System.Windows.Forms.Label = New System.Windows.Forms.Label()
                    label.AutoSize = True
                    label2.AutoSize = True
                    Dim dataGridViewCellStyle As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
                    Dim dataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
                    Dim dataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
                    Dim unusedDataGridViewCellStyle As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
                    Me.dgwDI = New System.Windows.Forms.DataGridView()
                    Me.dgwDI.EnableHeadersVisualStyles = False
                    dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
                    dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
                    Me.dgwDI.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
                    Me.dgwDI.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2
                    Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
                    Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
                    Me.dgwDI.GridColor = System.Drawing.Color.White
                    Me.dgwDI.AllowUserToAddRows = False
                    Me.dgwDI.AllowUserToDeleteRows = False
                    Me.dgwDI.AllowUserToOrderColumns = False
                    Me.dgwDI.AllowUserToResizeColumns = False
                    Me.dgwDI.MultiSelect = False
                    Me.dgwDI.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
                    Me.dgwDI.AutoSize = False
                    Me.dgwDI.BackgroundColor = System.Drawing.Color.White
                    Me.Column1.HeaderText = "Item Name"
                    Me.Column1.Name = "Column1"
                    Me.Column1.[ReadOnly] = True
                    Me.Column1.Width = 190
                    dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
                    Me.Column2.DefaultCellStyle = dataGridViewCellStyle
                    Me.Column2.HeaderText = "Quantity"
                    Me.Column2.Name = "Column2"
                    Me.Column2.[ReadOnly] = True
                    Me.Column2.Width = 80
                    Me.dgwDI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
                    Me.dgwDI.Columns.AddRange(Me.Column1, Me.Column2)
                    Me.dgwDI.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
                    Me.dgwDI.RowHeadersVisible = False
                    Me.dgwDI.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
                    Me.dgwDI.Columns(CInt((0))).DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
                    Dim dataGridView As System.Windows.Forms.DataGridView = Me.dgwDI
                    size = New System.Drawing.Size(275, 350)
                    dataGridView.Size = size
                    Me.dgwDI.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
                    Me.dgwDI.BackgroundColor = System.Drawing.Color.FromArgb(102, 106, 105)
                    dataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
                    Me.dgwDI.RowsDefaultCellStyle = dataGridViewCellStyle3
                    Dim button As System.Windows.Forms.Button = New System.Windows.Forms.Button()
                    size = New System.Drawing.Size(100, 50)
                    button.Size = size
                    button.Text = "BUMP " & text
                    button.UseVisualStyleBackColor = True
                    button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
                    button.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
                    button.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
                    button.ForeColor = System.Drawing.Color.White
                    While RestaurantPOS14.ModClasses.rdr.Read()
                        Dim text2 As String = (If((Microsoft.VisualBasic.CompilerServices.Operators.CompareString(RestaurantPOS14.ModClasses.rdr.GetValue(CInt((3))).ToString(), "", TextCompare:=False) <> 0), Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(RestaurantPOS14.ModClasses.rdr.GetValue(0), Global.Microsoft.VisualBasic.Constants.vbCrLf), RestaurantPOS14.ModClasses.rdr.GetValue(CInt((3))).ToString())), RestaurantPOS14.ModClasses.rdr.GetValue(CInt((0))).ToString()))
                        Me.dgwDI.Rows.Add(text2, System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(1)))
                        label.Text = text
                        If label.Text.Contains("KOT") Then
                            label.Text = "KNo.: " & text & "  ODN : " & RestaurantPOS14.ModClasses.rdr.GetValue(CInt((5))).ToString() & "  TNo.: " & RestaurantPOS14.ModClasses.rdr.GetValue(CInt((2))).ToString()
                        Else
                            label.Text = "Bill No.: " & text & "           Order No.: " & RestaurantPOS14.ModClasses.rdr.GetValue(CInt((5))).ToString()
                        End If

                        label.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
                        label.ForeColor = System.Drawing.Color.White
                        flowLayoutPanel.Controls.Add(label)
                        Dim now As System.DateTime = System.DateTime.Now
                        Dim d As System.DateTime = Microsoft.VisualBasic.CompilerServices.Conversions.ToDate(RestaurantPOS14.ModClasses.rdr.GetValue(4))
                        Dim timeSpan As System.TimeSpan = now - d
                        label2.Text = "Running since " & (timeSpan.Days * 24 * 60 + timeSpan.Hours * 60 + timeSpan.Minutes).ToString() & " Minutes."
                        label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
                        label2.ForeColor = System.Drawing.Color.White
                        If (timeSpan.Days * 24 * 60 + timeSpan.Hours * 60 + timeSpan.Minutes >= 0) And (timeSpan.Days * 24 * 60 + timeSpan.Hours * 60 + timeSpan.Minutes < 10) Then
                            flowLayoutPanel.BackColor = System.Drawing.Color.LightGreen
                        ElseIf (timeSpan.Days * 24 * 60 + timeSpan.Hours * 60 + timeSpan.Minutes >= 10) And (timeSpan.Days * 24 * 60 + timeSpan.Hours * 60 + timeSpan.Minutes < 15) Then
                            flowLayoutPanel.BackColor = System.Drawing.Color.DarkGoldenrod
                        Else
                            flowLayoutPanel.BackColor = System.Drawing.Color.Red
                        End If

                        flowLayoutPanel.Controls.Add(label2)
                        flowLayoutPanel.Controls.Add(Me.dgwDI)
                        flowLayoutPanel.Controls.Add(button)
                        Me.flpOrders.Controls.Add(flowLayoutPanel)
                        Me.dgwDI.ClearSelection()
                    End While

                    RestaurantPOS14.ModClasses.con.Close()
                    RestaurantPOS14.ModClasses.con.Dispose()
                    RestaurantPOS14.ModClasses.cmd.Dispose()
                    AddHandler button.Click, AddressOf Me.ButtonDineIn_Click
                Next
            Catch __unusedException1__ As System.Exception
                Call Microsoft.VisualBasic.CompilerServices.ProjectData.EndApp()
            Finally
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con.Dispose()
                RestaurantPOS14.ModClasses.cmd.Dispose()
            End Try
        End Sub

        Private Sub ButtonDineIn_Click(sender As Object, e As System.EventArgs)
            Try
                Dim text As String = Microsoft.VisualBasic.Strings.Split(CType(sender, System.Windows.Forms.Button).Text.Trim())(1)
                If text.Contains("KOT") Then
                    Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Update RestaurantPOS_OrderInfoKOT set KOT_Status='Prepared' where TicketNo=@d1")
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", text)
                    RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                    RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                    RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                    RestaurantPOS14.ModClasses.con.Close()
                End If

                If text.Contains("TA") Then
                    Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Update RestaurantPOS_BillingInfoTA set TA_Status='Prepared' where BillNo=@d1 and TA_Status <> 'Paid Directly'")
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", text)
                    RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                    RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                    RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                    RestaurantPOS14.ModClasses.con.Close()
                    Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Update RestaurantPOS_BillingInfoTA set TA_Status='Closed' where BillNo=@d1 and TA_Status = 'Paid Directly'")
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", text)
                    RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                    RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                    RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                    RestaurantPOS14.ModClasses.con.Close()
                End If

                If text.Contains("HD") Then
                    Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Update RestaurantPOS_BillingInfoHD set HD_Status='Prepared' where BillNo=@d1")
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", text)
                    RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                    RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                    RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                    RestaurantPOS14.ModClasses.con.Close()
                End If

                If text.Contains("EB") Then
                    Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Update RestaurantPOS_BillingInfoEB set EB_Status='Prepared' where BillNo=@d1 and EB_Status <> 'Paid Directly'")
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", text)
                    RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                    RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                    RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                    RestaurantPOS14.ModClasses.con.Close()
                    Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Update RestaurantPOS_BillingInfoEB set EB_Status='Closed' where BillNo=@d1 and EB_Status = 'Paid Directly'")
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", text)
                    RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                    RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                    RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                    RestaurantPOS14.ModClasses.con.Close()
                End If

                Me.GetData()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Function DBConnectionStatus() As Boolean
            Try
                Using sqlConnection As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    sqlConnection.Open()
                    Return sqlConnection.State = System.Data.ConnectionState.Open
                End Using
            Catch __unusedSqlException1__ As System.Data.SqlClient.SqlException
                Return False
            Catch __unusedException2__ As System.Exception
                Return False
            End Try
        End Function

        Private Sub frmKDS_Load(sender As Object, e As System.EventArgs)
            Me.flpOrders.HorizontalScroll.Maximum = 0
            Me.flpOrders.AutoScroll = False
            Me.flpOrders.VerticalScroll.Visible = False
            Me.flpOrders.AutoScroll = True
            Me.GetData()
        End Sub

        Private Sub Timer1_Tick(sender As Object, e As System.EventArgs)
            Me.GetData()
        End Sub

        Private Sub MetroToggle1_CheckedChanged(sender As Object, e As System.EventArgs)
            If Me.MetroToggle1.Checked Then
                Me.flpOrders.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
                MyBase.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
                Me.Label1.ForeColor = System.Drawing.Color.White
                Me.Label2.ForeColor = System.Drawing.Color.White
            Else
                Me.flpOrders.BackColor = System.Drawing.Color.White
                MyBase.BackColor = System.Drawing.Color.White
                Me.Label1.ForeColor = System.Drawing.Color.Black
                Me.Label2.ForeColor = System.Drawing.Color.Black
            End If
        End Sub

        Private Sub btnCancel_ClickButtonArea(Sender As Object, e As System.Windows.Forms.MouseEventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmFrontOffice.lblUser.Text = Me.lblUser.Text
            RestaurantPOS14.My.MyProject.Forms.frmFrontOffice.lblUserType.Text = Me.lblUserType.Text
            MyBase.Hide()
            Call RestaurantPOS14.My.MyProject.Forms.frmFrontOffice.Show()
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmKDS))
            Me.flpOrders = New System.Windows.Forms.FlowLayoutPanel()
            Me.cmbKOT = New System.Windows.Forms.ComboBox()
            Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.Label1 = New System.Windows.Forms.Label()
            Me.MetroToggle1 = New MetroFramework.Controls.MetroToggle()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.lblUserType = New System.Windows.Forms.Label()
            Me.btnCancel = New CButtonLib.CButton()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Label30 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.lblUser = New System.Windows.Forms.Label()
            Me.Panel1.SuspendLayout()
            MyBase.SuspendLayout()
            Me.flpOrders.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.flpOrders.BackColor = System.Drawing.Color.White
            Dim flowLayoutPanel As System.Windows.Forms.FlowLayoutPanel = Me.flpOrders
            Dim location As System.Drawing.Point = New System.Drawing.Point(2, 98)
            flowLayoutPanel.Location = location
            Me.flpOrders.Name = "flpOrders"
            Dim flowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel = Me.flpOrders
            Dim size As System.Drawing.Size = New System.Drawing.Size(994, 487)
            flowLayoutPanel2.Size = size
            Me.flpOrders.TabIndex = 0
            Me.cmbKOT.FormattingEnabled = True
            Dim comboBox As System.Windows.Forms.ComboBox = Me.cmbKOT
            location = New System.Drawing.Point(817, 63)
            comboBox.Location = location
            Me.cmbKOT.Name = "cmbKOT"
            Dim comboBox2 As System.Windows.Forms.ComboBox = Me.cmbKOT
            size = New System.Drawing.Size(121, 21)
            comboBox2.Size = size
            Me.cmbKOT.TabIndex = 0
            Me.cmbKOT.Visible = False
            Me.Timer1.Enabled = True
            Me.Timer1.Interval = 30000
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label1.ForeColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Dim label As System.Windows.Forms.Label = Me.Label1
            location = New System.Drawing.Point(5, 57)
            label.Location = location
            Me.Label1.Name = "Label1"
            Dim label2 As System.Windows.Forms.Label = Me.Label1
            size = New System.Drawing.Size(517, 25)
            label2.Size = size
            Me.Label1.TabIndex = 393
            Me.Label1.Text = "(All Orders will be automatically refresh after 30 seconds)"
            Dim metroToggle As MetroFramework.Controls.MetroToggle = Me.MetroToggle1
            location = New System.Drawing.Point(670, 57)
            metroToggle.Location = location
            Me.MetroToggle1.Name = "MetroToggle1"
            Dim metroToggle2 As MetroFramework.Controls.MetroToggle = Me.MetroToggle1
            size = New System.Drawing.Size(104, 35)
            metroToggle2.Size = size
            Me.MetroToggle1.TabIndex = 395
            Me.MetroToggle1.Text = "Off"
            Me.MetroToggle1.UseSelectable = True
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label2.ForeColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Dim label3 As System.Windows.Forms.Label = Me.Label2
            location = New System.Drawing.Point(545, 57)
            label3.Location = location
            Me.Label2.Name = "Label2"
            Dim label4 As System.Windows.Forms.Label = Me.Label2
            size = New System.Drawing.Size(119, 25)
            label4.Size = size
            Me.Label2.TabIndex = 396
            Me.Label2.Text = "Dark Theme"
            Me.lblUserType.AutoSize = True
            Dim label5 As System.Windows.Forms.Label = Me.lblUserType
            location = New System.Drawing.Point(930, 29)
            label5.Location = location
            Me.lblUserType.Name = "lblUserType"
            Dim label6 As System.Windows.Forms.Label = Me.lblUserType
            size = New System.Drawing.Size(39, 13)
            label6.Size = size
            Me.lblUserType.TabIndex = 397
            Me.lblUserType.Text = "Label8"
            Me.lblUserType.Visible = False
            Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
            Me.btnCancel.BackColor = System.Drawing.Color.Transparent
            Me.btnCancel.BorderColor = System.Drawing.Color.Transparent
            cBlendItems.iColor = New System.Drawing.Color(2) {System.Drawing.Color.AliceBlue, System.Drawing.Color.Navy, System.Drawing.Color.Navy}
            cBlendItems.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnCancel.ColorFillBlend = cBlendItems
            Me.btnCancel.Corners.All = 5
            Me.btnCancel.Corners.LowerLeft = 5
            Me.btnCancel.Corners.LowerRight = 5
            Me.btnCancel.Corners.UpperLeft = 5
            Me.btnCancel.Corners.UpperRight = 5
            Me.btnCancel.DesignerSelected = True
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnCancel.Image = CType(componentResourceManager.GetObject("btnCancel.Image"), System.Drawing.Image)
            Me.btnCancel.ImageIndex = 0
            Dim cButton As CButtonLib.CButton = Me.btnCancel
            size = New System.Drawing.Size(64, 64)
            cButton.ImageSize = size
            Dim cButton2 As CButtonLib.CButton = Me.btnCancel
            location = New System.Drawing.Point(944, 2)
            cButton2.Location = location
            Me.btnCancel.Name = "btnCancel"
            Dim cButton3 As CButtonLib.CButton = Me.btnCancel
            size = New System.Drawing.Size(52, 49)
            cButton3.Size = size
            Me.btnCancel.TabIndex = 399
            Me.btnCancel.Text = ""
            Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnCancel.TextShadowShow = False
            Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.Panel1.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.Label30)
            Me.Panel1.Controls.Add(Me.Label3)
            Me.Panel1.Controls.Add(Me.lblUser)
            Dim panel As System.Windows.Forms.Panel = Me.Panel1
            location = New System.Drawing.Point(1, 1)
            panel.Location = location
            Me.Panel1.Name = "Panel1"
            Dim panel2 As System.Windows.Forms.Panel = Me.Panel1
            size = New System.Drawing.Size(937, 49)
            panel2.Size = size
            Me.Panel1.TabIndex = 398
            Me.Label30.BackColor = System.Drawing.Color.Transparent
            Me.Label30.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label30.ForeColor = System.Drawing.Color.White
            Dim label7 As System.Windows.Forms.Label = Me.Label30
            location = New System.Drawing.Point(339, 5)
            label7.Location = location
            Me.Label30.Name = "Label30"
            Dim label8 As System.Windows.Forms.Label = Me.Label30
            size = New System.Drawing.Size(178, 37)
            label8.Size = size
            Me.Label30.TabIndex = 321
            Me.Label30.Text = "Operator ID :"
            Me.Label3.AutoSize = True
            Me.Label3.BackColor = System.Drawing.Color.Transparent
            Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label3.ForeColor = System.Drawing.Color.White
            Dim label9 As System.Windows.Forms.Label = Me.Label3
            location = New System.Drawing.Point(3, 5)
            label9.Location = location
            Me.Label3.Name = "Label3"
            Dim label10 As System.Windows.Forms.Label = Me.Label3
            size = New System.Drawing.Size(206, 37)
            label10.Size = size
            Me.Label3.TabIndex = 0
            Me.Label3.Text = "Kitchen Display"
            Me.lblUser.AutoSize = True
            Me.lblUser.BackColor = System.Drawing.Color.Transparent
            Me.lblUser.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.lblUser.ForeColor = System.Drawing.Color.White
            Dim label11 As System.Windows.Forms.Label = Me.lblUser
            location = New System.Drawing.Point(512, 5)
            label11.Location = location
            Me.lblUser.Name = "lblUser"
            Dim label12 As System.Windows.Forms.Label = Me.lblUser
            size = New System.Drawing.Size(0, 37)
            label12.Size = size
            Me.lblUser.TabIndex = 320
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            size = New System.Drawing.Size(998, 586)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.btnCancel)
            MyBase.Controls.Add(Me.Panel1)
            MyBase.Controls.Add(Me.lblUserType)
            MyBase.Controls.Add(Me.cmbKOT)
            MyBase.Controls.Add(Me.flpOrders)
            MyBase.Controls.Add(Me.Label2)
            MyBase.Controls.Add(Me.MetroToggle1)
            MyBase.Controls.Add(Me.Label1)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MaximizeBox = False
            MyBase.Name = "frmKDS"
            Me.Text = "Kitchen Display"
            MyBase.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            MyBase.ResumeLayout(False)
            MyBase.PerformLayout()
        End Sub
    End Class
End Namespace
