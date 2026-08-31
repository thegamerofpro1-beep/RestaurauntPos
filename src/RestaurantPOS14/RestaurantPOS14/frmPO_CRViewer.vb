Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports RestaurantPOS14.My

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public Class frmPO_CRViewer
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("CrystalReportViewer1")>
        Private _CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnSendMail")>
        Private _btnSendMail As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label4")>
        Private _Label4 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtEmailID")>
        Private _txtEmailID As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Timer1")>
        Private _Timer1 As System.Windows.Forms.Timer

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblUser")>
        Private _lblUser As System.Windows.Forms.Label

        Private components As System.ComponentModel.IContainer

        Friend Overridable Property CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._CrystalReportViewer1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CrystalDecisions.Windows.Forms.CrystalReportViewer)
                Me._CrystalReportViewer1 = value
            End Set
        End Property

        Friend Overridable Property btnSendMail As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnSendMail
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnSendMail_Click
                If Me._btnSendMail IsNot Nothing Then
                    RemoveHandler Me._btnSendMail.Click, value2
                End If

                Me._btnSendMail = value
                If Me._btnSendMail IsNot Nothing Then
                    AddHandler Me._btnSendMail.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property Label4 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label4
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label4 = value
            End Set
        End Property

        Friend Overridable Property txtEmailID As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtEmailID
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.ComponentModel.CancelEventHandler = AddressOf Me.txtEmailID_Validating
                Dim value3 As System.Windows.Forms.KeyPressEventHandler = AddressOf Me.txtEmailID_KeyPress
                If Me._txtEmailID IsNot Nothing Then
                    RemoveHandler Me._txtEmailID.Validating, value2
                    RemoveHandler Me._txtEmailID.KeyPress, value3
                End If

                Me._txtEmailID = value
                If Me._txtEmailID IsNot Nothing Then
                    AddHandler Me._txtEmailID.Validating, value2
                    AddHandler Me._txtEmailID.KeyPress, value3
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

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            Call RestaurantPOS14.frmPO_CRViewer.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmPO_CRViewer.__ENCList
                If RestaurantPOS14.frmPO_CRViewer.__ENCList.Count = RestaurantPOS14.frmPO_CRViewer.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmPO_CRViewer.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmPO_CRViewer.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmPO_CRViewer.__ENCList(num) = RestaurantPOS14.frmPO_CRViewer.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmPO_CRViewer.__ENCList.RemoveRange(num, RestaurantPOS14.frmPO_CRViewer.__ENCList.Count - num)
                    RestaurantPOS14.frmPO_CRViewer.__ENCList.Capacity = RestaurantPOS14.frmPO_CRViewer.__ENCList.Count
                End If

                Call RestaurantPOS14.frmPO_CRViewer.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Private Sub btnSendMail_Click(sender As Object, e As System.EventArgs)
            Try
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtEmailID.Text, "", TextCompare:=False) = 0 Then
                    Call System.Windows.Forms.MessageBox.Show("Please enter Email ID", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Me.txtEmailID.Focus()
                    Return
                End If

                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select count(*) from EmailSetting Having count(*) <=0")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call RestaurantPOS14.My.MyProject.Forms.frmCustomDialog15.ShowDialog()
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                RestaurantPOS14.ModClasses.con.Close()
                If Not RestaurantPOS14.ModFunc.CheckForInternetConnection() Then
                    Return
                End If

                MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Me.Timer1.Enabled = True
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select RTRIM(Username),RTRIM(Password),RTRIM(SMTPAddress),(Port) from EmailSetting where IsDefault='Yes' and IsActive='Yes'")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                Dim sqlDataReader As System.Data.SqlClient.SqlDataReader = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If sqlDataReader.Read() Then
                    MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                    Me.Timer1.Enabled = True
                    MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                    Me.Timer1.Enabled = True
                    Dim obj As RestaurantPOS14.rptPurchaseOrder = New RestaurantPOS14.rptPurchaseOrder()
                    Dim sqlCommand As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand()
                    Dim sqlCommand2 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand()
                    Dim sqlDataAdapter As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter()
                    Dim sqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter()
                    Dim dataSet As System.Data.DataSet = New System.Data.DataSet()
                    sqlCommand.Connection = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    Dim sqlConnection As System.Data.SqlClient.SqlConnection = sqlCommand.Connection
                    Dim connection As System.Data.SqlClient.SqlConnection = sqlConnection
                    sqlCommand2.Connection = connection
                    sqlCommand.CommandText = "SELECT TaxType, PurchaseOrder.PO_ID, PurchaseOrder.PONumber, PurchaseOrder.Date, PurchaseOrder.Supplier_ID, PurchaseOrder.Terms, PurchaseOrder.SubTotal, PurchaseOrder.VATPer, PurchaseOrder.VATAmount, PurchaseOrder.GrandTotal, PurchaseOrder_Join.POJ_ID, PurchaseOrder_Join.PurchaseOrderID, PurchaseOrder_Join.ProductID, PurchaseOrder_Join.Qty,PurchaseOrder_Join.PricePerUnit, PurchaseOrder_Join.Amount, Product.PID, Product.ProductCode, Product.ProductName,  Product.Unit, Supplier.ID, Supplier.SupplierID, Supplier.Name,Supplier.Address, Supplier.City, Supplier.State, Supplier.ZipCode, Supplier.ContactNo, Supplier.EmailID, Supplier.Remarks, Supplier.TIN, Supplier.STNo, Supplier.CST, Supplier.PAN, Supplier.AccountName,Supplier.AccountNumber, Supplier.Bank, Supplier.Branch, Supplier.IFSCCode, Supplier.OpeningBalance, Supplier.OpeningBalanceType FROM PurchaseOrder INNER JOIN PurchaseOrder_Join ON PurchaseOrder.PO_ID = PurchaseOrder_Join.PurchaseOrderID INNER JOIN Product ON PurchaseOrder_Join.ProductID = Product.PID INNER JOIN Supplier ON PurchaseOrder.Supplier_ID = Supplier.ID where PO_ID=" & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPurchaseOrder.txtPO_ID.Text))
                    sqlCommand2.CommandText = "SELECT * from Hotel"
                    sqlCommand.CommandType = System.Data.CommandType.Text
                    sqlCommand2.CommandType = System.Data.CommandType.Text
                    sqlDataAdapter.SelectCommand = sqlCommand
                    sqlDataAdapter2.SelectCommand = sqlCommand2
                    sqlDataAdapter.Fill(dataSet, "PurchaseOrder")
                    sqlDataAdapter.Fill(dataSet, "PurchaseOrder_Join")
                    sqlDataAdapter.Fill(dataSet, "Supplier")
                    sqlDataAdapter.Fill(dataSet, "Product")
                    sqlDataAdapter2.Fill(dataSet, "Hotel")
                    obj.SetDataSource(dataSet)
                    Call RestaurantPOS14.My.MyProject.Forms.frmPurchaseOrder.GetRegisteredUserName(Me.lblUser.Text)
                    obj.SetParameterValue("p1", RestaurantPOS14.My.MyProject.Forms.frmPurchaseOrder.lblname)
                    Dim text As String = RestaurantPOS14.Customization.CrystalReportExporter.Export(obj, "rptPurchaseOrder", "PurchaseOrder")
                    RestaurantPOS14.ModFunc.SendMail1(Microsoft.VisualBasic.CompilerServices.Conversions.ToString(sqlDataReader.GetValue(0)), Me.txtEmailID.Text, "Please find the attachment below", text, "Purchase Order", Microsoft.VisualBasic.CompilerServices.Conversions.ToString(sqlDataReader.GetValue(2)), Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(sqlDataReader.GetValue(3)), Microsoft.VisualBasic.CompilerServices.Conversions.ToString(sqlDataReader.GetValue(0)), RestaurantPOS14.ModFunc.Decrypt(Microsoft.VisualBasic.CompilerServices.Conversions.ToString(sqlDataReader.GetValue(1))))
                    sqlDataReader?.Close()
                    obj.Close()
                    obj.Dispose()
                    Call System.Windows.Forms.MessageBox.Show("Successfully send", "Mail", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                End If
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub Timer1_Tick(sender As Object, e As System.EventArgs)
            MyBase.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.Timer1.Enabled = False
        End Sub

        Private Sub txtEmailID_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
            Dim pattern As String = "^[a-z][a-z|0-9|]*([_][a-z|0-9]+)*([.][a-z|0-9]+([_][a-z|0-9]+)*)?@[a-z][a-z|0-9|]*\.([a-z][a-z|0-9]*(\.[a-z][a-z|0-9]*)?)$"
            If Not System.Text.RegularExpressions.Regex.Match(CStr((Me.txtEmailID.Text.Trim())), CStr((pattern)), CType((System.Text.RegularExpressions.RegexOptions.IgnoreCase), System.Text.RegularExpressions.RegexOptions)).Success Then
                Call System.Windows.Forms.MessageBox.Show("Please enter a valid email id", "Checking", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                Me.txtEmailID.Clear()
            End If
        End Sub

        Private Sub txtEmailID_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
            Dim text As String = "@"
            If e.KeyChar <> Global.Microsoft.VisualBasic.Strings.ChrW(8) AndAlso ((Microsoft.VisualBasic.Strings.Asc(e.KeyChar) < 97) Or (Microsoft.VisualBasic.Strings.Asc(e.KeyChar) > 122)) AndAlso ((Microsoft.VisualBasic.Strings.Asc(e.KeyChar) <> 46) And (Microsoft.VisualBasic.Strings.Asc(e.KeyChar) <> 95)) AndAlso ((Microsoft.VisualBasic.Strings.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Strings.Asc(e.KeyChar) > 57)) Then
                If text.IndexOf(e.KeyChar) = -1 Then
                    e.Handled = True
                ElseIf Me.txtEmailID.Text.Contains("@") And (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Microsoft.VisualBasic.CompilerServices.Conversions.ToString(e.KeyChar), "@", TextCompare:=False) = 0) Then
                    e.Handled = True
                End If
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
            Me.components = New System.ComponentModel.Container()
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmPO_CRViewer))
            Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
            Me.btnSendMail = New System.Windows.Forms.Button()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtEmailID = New System.Windows.Forms.TextBox()
            Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.lblUser = New System.Windows.Forms.Label()
            MyBase.SuspendLayout()
            Me.CrystalReportViewer1.ActiveViewIndex = -1
            Me.CrystalReportViewer1.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.[Default]
            Dim crystalReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer = Me.CrystalReportViewer1
            Dim location As System.Drawing.Point = New System.Drawing.Point(0, 69)
            crystalReportViewer.Location = location
            Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
            Me.CrystalReportViewer1.ShowLogo = False
            Dim crystalReportViewer2 As CrystalDecisions.Windows.Forms.CrystalReportViewer = Me.CrystalReportViewer1
            Dim size As System.Drawing.Size = New System.Drawing.Size(855, 459)
            crystalReportViewer2.Size = size
            Me.CrystalReportViewer1.TabIndex = 0
            Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            Me.btnSendMail.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.btnSendMail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.btnSendMail.FlatAppearance.BorderSize = 0
            Me.btnSendMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSendMail.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnSendMail.ForeColor = System.Drawing.Color.White
            Dim button As System.Windows.Forms.Button = Me.btnSendMail
            location = New System.Drawing.Point(283, 6)
            button.Location = location
            Me.btnSendMail.Name = "btnSendMail"
            Dim button2 As System.Windows.Forms.Button = Me.btnSendMail
            size = New System.Drawing.Size(147, 57)
            button2.Size = size
            Me.btnSendMail.TabIndex = 23
            Me.btnSendMail.Text = "&Send Email"
            Me.btnSendMail.UseVisualStyleBackColor = False
            Me.Label4.AutoSize = True
            Me.Label4.BackColor = System.Drawing.Color.Transparent
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label4.ForeColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Dim label As System.Windows.Forms.Label = Me.Label4
            location = New System.Drawing.Point(8, 5)
            label.Location = location
            Me.Label4.Name = "Label4"
            Dim label2 As System.Windows.Forms.Label = Me.Label4
            size = New System.Drawing.Size(139, 24)
            label2.Size = size
            Me.Label4.TabIndex = 22
            Me.Label4.Text = "Enter Email ID :"
            Me.txtEmailID.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
            Me.txtEmailID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.txtEmailID.ForeColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Dim textBox As System.Windows.Forms.TextBox = Me.txtEmailID
            location = New System.Drawing.Point(12, 34)
            textBox.Location = location
            Me.txtEmailID.Name = "txtEmailID"
            Dim textBox2 As System.Windows.Forms.TextBox = Me.txtEmailID
            size = New System.Drawing.Size(265, 29)
            textBox2.Size = size
            Me.txtEmailID.TabIndex = 21
            Me.lblUser.AutoSize = True
            Dim label3 As System.Windows.Forms.Label = Me.lblUser
            location = New System.Drawing.Point(457, 34)
            label3.Location = location
            Me.lblUser.Name = "lblUser"
            Dim label4 As System.Windows.Forms.Label = Me.lblUser
            size = New System.Drawing.Size(29, 13)
            label4.Size = size
            Me.lblUser.TabIndex = 24
            Me.lblUser.Text = "User"
            Me.lblUser.Visible = False
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            size = New System.Drawing.Size(855, 528)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.lblUser)
            MyBase.Controls.Add(Me.btnSendMail)
            MyBase.Controls.Add(Me.Label4)
            MyBase.Controls.Add(Me.txtEmailID)
            MyBase.Controls.Add(Me.CrystalReportViewer1)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MaximizeBox = False
            MyBase.MinimizeBox = False
            MyBase.Name = "frmPO_CRViewer"
            Me.Text = "Report"
            MyBase.WindowState = System.Windows.Forms.FormWindowState.Maximized
            MyBase.ResumeLayout(False)
            MyBase.PerformLayout()
        End Sub

    End Class
End Namespace
