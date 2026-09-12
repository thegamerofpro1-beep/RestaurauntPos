Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices
Imports RestaurantPOS14.My

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public Class frmPrintLoyaltyCard
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnViewReport")>
        Private _btnViewReport As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Timer1")>
        Private _Timer1 As System.Windows.Forms.Timer

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("listView1")>
        Private _listView1 As System.Windows.Forms.ListView

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("columnHeader1")>
        Private _columnHeader1 As System.Windows.Forms.ColumnHeader

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("columnHeader3")>
        Private _columnHeader3 As System.Windows.Forms.ColumnHeader

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("ColumnHeader2")>
        Private _ColumnHeader2 As System.Windows.Forms.ColumnHeader

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("ColumnHeader4")>
        Private _ColumnHeader4 As System.Windows.Forms.ColumnHeader

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnReset")>
        Private _btnReset As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox1")>
        Private _GroupBox1 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtMemberName")>
        Private _txtMemberName As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox2")>
        Private _GroupBox2 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtMemberID")>
        Private _txtMemberID As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtHotelName")>
        Private _txtHotelName As System.Windows.Forms.TextBox

        Private st As String

        Private components As System.ComponentModel.IContainer

        Friend Overridable Property btnViewReport As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnViewReport
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnGenerateBarcode_Click
                If Me._btnViewReport IsNot Nothing Then
                    RemoveHandler Me._btnViewReport.Click, value2
                End If

                Me._btnViewReport = value
                If Me._btnViewReport IsNot Nothing Then
                    AddHandler Me._btnViewReport.Click, value2
                End If
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

        Friend Overridable Property listView1 As System.Windows.Forms.ListView
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._listView1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ListView)
                Me._listView1 = value
            End Set
        End Property

        Friend Overridable Property columnHeader1 As System.Windows.Forms.ColumnHeader
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._columnHeader1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ColumnHeader)
                Me._columnHeader1 = value
            End Set
        End Property

        Friend Overridable Property columnHeader3 As System.Windows.Forms.ColumnHeader
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._columnHeader3
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ColumnHeader)
                Me._columnHeader3 = value
            End Set
        End Property

        Friend Overridable Property ColumnHeader2 As System.Windows.Forms.ColumnHeader
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._ColumnHeader2
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ColumnHeader)
                Me._ColumnHeader2 = value
            End Set
        End Property

        Friend Overridable Property ColumnHeader4 As System.Windows.Forms.ColumnHeader
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._ColumnHeader4
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ColumnHeader)
                Me._ColumnHeader4 = value
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

        Friend Overridable Property GroupBox1 As System.Windows.Forms.GroupBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._GroupBox1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.GroupBox)
                Me._GroupBox1 = value
            End Set
        End Property

        Friend Overridable Property txtMemberName As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtMemberName
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.EventHandler = AddressOf Me.txtMemberName_TextChanged
                If Me._txtMemberName IsNot Nothing Then
                    RemoveHandler Me._txtMemberName.TextChanged, value2
                End If

                Me._txtMemberName = value
                If Me._txtMemberName IsNot Nothing Then
                    AddHandler Me._txtMemberName.TextChanged, value2
                End If
            End Set
        End Property

        Friend Overridable Property GroupBox2 As System.Windows.Forms.GroupBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._GroupBox2
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.GroupBox)
                Me._GroupBox2 = value
            End Set
        End Property

        Friend Overridable Property txtMemberID As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtMemberID
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.EventHandler = AddressOf Me.txtMemberID_TextChanged
                If Me._txtMemberID IsNot Nothing Then
                    RemoveHandler Me._txtMemberID.TextChanged, value2
                End If

                Me._txtMemberID = value
                If Me._txtMemberID IsNot Nothing Then
                    AddHandler Me._txtMemberID.TextChanged, value2
                End If
            End Set
        End Property

        Friend Overridable Property txtHotelName As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtHotelName
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtHotelName = value
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            AddHandler MyBase.Load, AddressOf Me.frmPrintCard_Load
            Call RestaurantPOS14.frmPrintLoyaltyCard.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmPrintLoyaltyCard.__ENCList
                If RestaurantPOS14.frmPrintLoyaltyCard.__ENCList.Count = RestaurantPOS14.frmPrintLoyaltyCard.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmPrintLoyaltyCard.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmPrintLoyaltyCard.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmPrintLoyaltyCard.__ENCList(num) = RestaurantPOS14.frmPrintLoyaltyCard.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmPrintLoyaltyCard.__ENCList.RemoveRange(num, RestaurantPOS14.frmPrintLoyaltyCard.__ENCList.Count - num)
                    RestaurantPOS14.frmPrintLoyaltyCard.__ENCList.Capacity = RestaurantPOS14.frmPrintLoyaltyCard.__ENCList.Count
                End If

                Call RestaurantPOS14.frmPrintLoyaltyCard.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Private Sub btnGenerateBarcode_Click(sender As Object, e As System.EventArgs)
            If Me.listView1.Items.Count = 0 Then
                Call System.Windows.Forms.MessageBox.Show("There is no members's record in listview to generate barcode ", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Return
            End If

            Try
                If Me.listView1.CheckedItems.Count <= 0 Then
                    Return
                End If

                Dim text As String = ""
                Dim num As Integer = Me.listView1.CheckedItems.Count - 1
                Dim num2 As Integer = 0
                While True
                    Dim num3 As Integer = num2
                    Dim num4 As Integer = num
                    If num3 > num4 Then
                        Exit While
                    End If

                    text = text & Me.listView1.CheckedItems(CInt((num2))).Text & ","
                    num2 += 1
                End While

                text = text.Substring(0, text.Length - 1)
                MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Me.Timer1.Enabled = True
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Select MemberID,RTRIM(Name),RTRIM(Address),RTRIM(ContactNo) from LoyaltyMember where MemberID in (" & text & ") order by Name", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.adp = New System.Data.SqlClient.SqlDataAdapter(RestaurantPOS14.ModClasses.cmd)
                RestaurantPOS14.ModClasses.dtable = New System.Data.DataTable()
                RestaurantPOS14.ModClasses.adp.Fill(RestaurantPOS14.ModClasses.dtable)
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.ds = New System.Data.DataSet()
                RestaurantPOS14.ModClasses.ds.Tables.Add(RestaurantPOS14.ModClasses.dtable)
                RestaurantPOS14.ModClasses.ds.WriteXmlSchema("LoyaltyCard1.xml")
                Dim rptLoyaltyCard2 As RestaurantPOS14.rptLoyaltyCard = New RestaurantPOS14.rptLoyaltyCard()
                rptLoyaltyCard2.SetDataSource(RestaurantPOS14.ModClasses.ds)
                rptLoyaltyCard2.SetParameterValue("p1", Me.txtHotelName.Text)
                RestaurantPOS14.My.MyProject.Forms.frmReport.CrystalReportViewer1.ReportSource = rptLoyaltyCard2
                Call RestaurantPOS14.My.MyProject.Forms.frmReport.ShowDialog()
                rptLoyaltyCard2.Close()
                rptLoyaltyCard2.Dispose()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub Reset()
            Me.txtMemberID.Text = ""
            Me.txtMemberName.Text = ""
            Me.GetData()
        End Sub

        Private Sub btnReset_Click(sender As Object, e As System.EventArgs)
            Me.Reset()
        End Sub

        Private Sub Timer1_Tick(sender As Object, e As System.EventArgs)
            MyBase.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.Timer1.Enabled = False
        End Sub

        Private Sub txtMemberName_TextChanged(sender As Object, e As System.EventArgs)
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Select RTRIM(MemberID),RTRIM(Name),RTRIM(Address),RTRIM(ContactNo) from LoyaltyMember where Name like N'%" & RestaurantPOS14.Security.SqlInput.EscapeLiteral(Me.txtMemberName.Text) & "%' order by Name", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                Me.listView1.Items.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Dim listViewItem As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem()
                    listViewItem.Text = RestaurantPOS14.ModClasses.rdr(CInt((0))).ToString().Trim()
                    listViewItem.SubItems.Add(RestaurantPOS14.ModClasses.rdr(CInt((1))).ToString().Trim())
                    listViewItem.SubItems.Add(RestaurantPOS14.ModClasses.rdr(CInt((2))).ToString().Trim())
                    listViewItem.SubItems.Add(RestaurantPOS14.ModClasses.rdr(CInt((3))).ToString().Trim())
                    Me.listView1.Items.Add(listViewItem)
                End While

                Dim num As Integer = Me.listView1.Items.Count - 1
                Dim num2 As Integer = 0
                While True
                    Dim num3 As Integer = num2
                    Dim num4 As Integer = num
                    If num3 > num4 Then
                        Exit While
                    End If

                    Me.listView1.Items(CInt((num2))).Checked = True
                    num2 += 1
                End While

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub txtMemberID_TextChanged(sender As Object, e As System.EventArgs)
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Select RTRIM(MemberID),RTRIM(Name),RTRIM(Address),RTRIM(ContactNo) from LoyaltyMember where MemberID like '" & RestaurantPOS14.Security.SqlInput.EscapeLiteral(Me.txtMemberID.Text) & "%'  order by Name", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                Me.listView1.Items.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Dim listViewItem As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem()
                    listViewItem.Text = RestaurantPOS14.ModClasses.rdr(CInt((0))).ToString().Trim()
                    listViewItem.SubItems.Add(RestaurantPOS14.ModClasses.rdr(CInt((1))).ToString().Trim())
                    listViewItem.SubItems.Add(RestaurantPOS14.ModClasses.rdr(CInt((2))).ToString().Trim())
                    listViewItem.SubItems.Add(RestaurantPOS14.ModClasses.rdr(CInt((3))).ToString().Trim())
                    Me.listView1.Items.Add(listViewItem)
                End While

                Dim num As Integer = Me.listView1.Items.Count - 1
                Dim num2 As Integer = 0
                While True
                    Dim num3 As Integer = num2
                    Dim num4 As Integer = num
                    If num3 > num4 Then
                        Exit While
                    End If

                    Me.listView1.Items(CInt((num2))).Checked = True
                    num2 += 1
                End While

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub GetData()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Select RTRIM(MemberID),RTRIM(Name),RTRIM(Address),RTRIM(ContactNo) from LoyaltyMember order by Name", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                Me.listView1.Items.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Dim listViewItem As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem()
                    listViewItem.Text = RestaurantPOS14.ModClasses.rdr(CInt((0))).ToString().Trim()
                    listViewItem.SubItems.Add(RestaurantPOS14.ModClasses.rdr(CInt((1))).ToString().Trim())
                    listViewItem.SubItems.Add(RestaurantPOS14.ModClasses.rdr(CInt((2))).ToString().Trim())
                    listViewItem.SubItems.Add(RestaurantPOS14.ModClasses.rdr(CInt((3))).ToString().Trim())
                    Me.listView1.Items.Add(listViewItem)
                End While

                Dim num As Integer = Me.listView1.Items.Count - 1
                Dim num2 As Integer = 0
                While True
                    Dim num3 As Integer = num2
                    Dim num4 As Integer = num
                    If num3 > num4 Then
                        Exit While
                    End If

                    Me.listView1.Items(CInt((num2))).Checked = True
                    num2 += 1
                End While

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub GetHotelInfo()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = RestaurantPOS14.ModClasses.con.CreateCommand()
                RestaurantPOS14.ModClasses.cmd.CommandText = "SELECT RTRIM(HotelName) from Hotel"
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.txtHotelName.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If

                If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                    RestaurantPOS14.ModClasses.rdr.Close()
                End If

                If RestaurantPOS14.ModClasses.con.State = System.Data.ConnectionState.Open Then
                    RestaurantPOS14.ModClasses.con.Close()
                End If
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub frmPrintCard_Load(sender As Object, e As System.EventArgs)
            Me.GetData()
            Me.GetHotelInfo()
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmPrintLoyaltyCard))
            Me.btnViewReport = New System.Windows.Forms.Button()
            Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.listView1 = New System.Windows.Forms.ListView()
            Me.columnHeader1 = New System.Windows.Forms.ColumnHeader()
            Me.columnHeader3 = New System.Windows.Forms.ColumnHeader()
            Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader()
            Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader()
            Me.btnReset = New System.Windows.Forms.Button()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.txtMemberName = New System.Windows.Forms.TextBox()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.txtMemberID = New System.Windows.Forms.TextBox()
            Me.txtHotelName = New System.Windows.Forms.TextBox()
            Me.GroupBox1.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            MyBase.SuspendLayout()
            Dim button As System.Windows.Forms.Button = Me.btnViewReport
            Dim location As System.Drawing.Point = New System.Drawing.Point(477, 21)
            button.Location = location
            Me.btnViewReport.Name = "btnViewReport"
            Dim button2 As System.Windows.Forms.Button = Me.btnViewReport
            Dim size As System.Drawing.Size = New System.Drawing.Size(86, 43)
            button2.Size = size
            Me.btnViewReport.TabIndex = 2
            Me.btnViewReport.Text = "View Card"
            Me.btnViewReport.UseVisualStyleBackColor = True
            Me.listView1.CheckBoxes = True
            Me.listView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader(3) {Me.columnHeader1, Me.columnHeader3, Me.ColumnHeader4, Me.ColumnHeader2})
            Me.listView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.listView1.GridLines = True
            Dim listView As System.Windows.Forms.ListView = Me.listView1
            location = New System.Drawing.Point(10, 83)
            listView.Location = location
            Me.listView1.Name = "listView1"
            Dim listView2 As System.Windows.Forms.ListView = Me.listView1
            size = New System.Drawing.Size(745, 495)
            listView2.Size = size
            Me.listView1.TabIndex = 67
            Me.listView1.UseCompatibleStateImageBehavior = False
            Me.listView1.View = System.Windows.Forms.View.Details
            Me.columnHeader1.Text = "Member ID"
            Me.columnHeader1.Width = 100
            Me.columnHeader3.Text = "Member Name"
            Me.columnHeader3.Width = 270
            Me.ColumnHeader4.Text = "Address"
            Me.ColumnHeader4.Width = 250
            Me.ColumnHeader2.Text = "Contact No."
            Me.ColumnHeader2.Width = 120
            Dim button3 As System.Windows.Forms.Button = Me.btnReset
            location = New System.Drawing.Point(569, 21)
            button3.Location = location
            Me.btnReset.Name = "btnReset"
            Dim button4 As System.Windows.Forms.Button = Me.btnReset
            size = New System.Drawing.Size(82, 43)
            button4.Size = size
            Me.btnReset.TabIndex = 3
            Me.btnReset.Text = "Reset"
            Me.btnReset.UseVisualStyleBackColor = True
            Me.GroupBox1.Controls.Add(Me.txtMemberName)
            Dim groupBox As System.Windows.Forms.GroupBox = Me.GroupBox1
            location = New System.Drawing.Point(12, 9)
            groupBox.Location = location
            Me.GroupBox1.Name = "GroupBox1"
            Dim groupBox2 As System.Windows.Forms.GroupBox = Me.GroupBox1
            size = New System.Drawing.Size(235, 68)
            groupBox2.Size = size
            Me.GroupBox1.TabIndex = 68
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Search By Member Name"
            Me.txtMemberName.BackColor = System.Drawing.Color.White
            Me.txtMemberName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox As System.Windows.Forms.TextBox = Me.txtMemberName
            location = New System.Drawing.Point(22, 29)
            textBox.Location = location
            Me.txtMemberName.Name = "txtMemberName"
            Dim textBox2 As System.Windows.Forms.TextBox = Me.txtMemberName
            size = New System.Drawing.Size(207, 21)
            textBox2.Size = size
            Me.txtMemberName.TabIndex = 0
            Me.GroupBox2.Controls.Add(Me.txtMemberID)
            Dim groupBox3 As System.Windows.Forms.GroupBox = Me.GroupBox2
            location = New System.Drawing.Point(253, 9)
            groupBox3.Location = location
            Me.GroupBox2.Name = "GroupBox2"
            Dim groupBox4 As System.Windows.Forms.GroupBox = Me.GroupBox2
            size = New System.Drawing.Size(204, 68)
            groupBox4.Size = size
            Me.GroupBox2.TabIndex = 69
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Search By Member ID"
            Me.txtMemberID.BackColor = System.Drawing.Color.White
            Me.txtMemberID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox3 As System.Windows.Forms.TextBox = Me.txtMemberID
            location = New System.Drawing.Point(22, 29)
            textBox3.Location = location
            Me.txtMemberID.Name = "txtMemberID"
            Dim textBox4 As System.Windows.Forms.TextBox = Me.txtMemberID
            size = New System.Drawing.Size(168, 21)
            textBox4.Size = size
            Me.txtMemberID.TabIndex = 0
            Me.txtHotelName.AccessibleRole = System.Windows.Forms.AccessibleRole.Equation
            Dim textBox5 As System.Windows.Forms.TextBox = Me.txtHotelName
            location = New System.Drawing.Point(658, 38)
            textBox5.Location = location
            Me.txtHotelName.Name = "txtHotelName"
            Dim textBox6 As System.Windows.Forms.TextBox = Me.txtHotelName
            size = New System.Drawing.Size(100, 20)
            textBox6.Size = size
            Me.txtHotelName.TabIndex = 70
            Me.txtHotelName.Visible = False
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            size = New System.Drawing.Size(764, 590)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.txtHotelName)
            MyBase.Controls.Add(Me.GroupBox2)
            MyBase.Controls.Add(Me.GroupBox1)
            MyBase.Controls.Add(Me.btnReset)
            MyBase.Controls.Add(Me.btnViewReport)
            MyBase.Controls.Add(Me.listView1)
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MaximizeBox = False
            MyBase.MinimizeBox = False
            MyBase.Name = "frmPrintLoyaltyCard"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Loyalty Card"
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            MyBase.ResumeLayout(False)
            MyBase.PerformLayout()
        End Sub
    End Class
End Namespace
