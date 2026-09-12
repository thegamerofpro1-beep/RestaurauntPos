Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Net
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Newtonsoft.Json
Imports RestaurantPOS14.My

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public Class frmWalletList
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("flpWallet")>
        Private _flpWallet As System.Windows.Forms.FlowLayoutPanel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Timer1")>
        Private _Timer1 As System.Windows.Forms.Timer

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label5")>
        Private _Label5 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnClose")>
        Private _btnClose As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblSet")>
        Private _lblSet As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label3")>
        Private _Label3 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label2")>
        Private _Label2 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label1")>
        Private _Label1 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtMpesaNumber")>
        Private _txtMpesaNumber As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Timer2")>
        Private _Timer2 As System.Windows.Forms.Timer

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtOAuthURL")>
        Private _txtOAuthURL As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtActiveMpesa")>
        Private _txtActiveMpesa As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtShortCode")>
        Private _txtShortCode As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtC2BSimulateURL")>
        Private _txtC2BSimulateURL As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtConsumerSecret")>
        Private _txtConsumerSecret As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtConsumerKey")>
        Private _txtConsumerKey As System.Windows.Forms.TextBox

        Private UserButtons As System.Collections.Generic.List(Of System.Windows.Forms.Button)

        Private TokenKey As String

        Private StatusX As String

        Private components As System.ComponentModel.IContainer

        Friend Overridable Property flpWallet As System.Windows.Forms.FlowLayoutPanel
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._flpWallet
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.FlowLayoutPanel)
                Me._flpWallet = value
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
                Me._Timer1 = value
            End Set
        End Property

        Friend Overridable Property Label5 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label5
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label5 = value
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
                Dim value2 As System.EventHandler = AddressOf Me.btnLogout_Click
                If Me._btnClose IsNot Nothing Then
                    RemoveHandler Me._btnClose.Click, value2
                End If

                Me._btnClose = value
                If Me._btnClose IsNot Nothing Then
                    AddHandler Me._btnClose.Click, value2
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

        Friend Overridable Property txtMpesaNumber As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtMpesaNumber
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtMpesaNumber = value
            End Set
        End Property

        Friend Overridable Property Timer2 As System.Windows.Forms.Timer
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Timer2
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Timer)
                Dim value2 As System.EventHandler = AddressOf Me.Timer2_Tick
                If Me._Timer2 IsNot Nothing Then
                    RemoveHandler Me._Timer2.Tick, value2
                End If

                Me._Timer2 = value
                If Me._Timer2 IsNot Nothing Then
                    AddHandler Me._Timer2.Tick, value2
                End If
            End Set
        End Property

        Friend Overridable Property txtOAuthURL As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtOAuthURL
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtOAuthURL = value
            End Set
        End Property

        Friend Overridable Property txtActiveMpesa As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtActiveMpesa
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtActiveMpesa = value
            End Set
        End Property

        Friend Overridable Property txtShortCode As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtShortCode
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtShortCode = value
            End Set
        End Property

        Friend Overridable Property txtC2BSimulateURL As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtC2BSimulateURL
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtC2BSimulateURL = value
            End Set
        End Property

        Friend Overridable Property txtConsumerSecret As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtConsumerSecret
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtConsumerSecret = value
            End Set
        End Property

        Friend Overridable Property txtConsumerKey As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtConsumerKey
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtConsumerKey = value
            End Set
        End Property

        Public Sub New()
            AddHandler MyBase.Load, AddressOf Me.frmTables_Load
            Call RestaurantPOS14.frmWalletList.__ENCAddToList(Me)
            Me.UserButtons = New System.Collections.Generic.List(Of System.Windows.Forms.Button)()
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmWalletList.__ENCList
                If RestaurantPOS14.frmWalletList.__ENCList.Count = RestaurantPOS14.frmWalletList.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmWalletList.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmWalletList.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmWalletList.__ENCList(num) = RestaurantPOS14.frmWalletList.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmWalletList.__ENCList.RemoveRange(num, RestaurantPOS14.frmWalletList.__ENCList.Count - num)
                    RestaurantPOS14.frmWalletList.__ENCList.Capacity = RestaurantPOS14.frmWalletList.__ENCList.Count
                End If

                Call RestaurantPOS14.frmWalletList.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Public Sub FillWallet()
            Try
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT RTRIM(WalletType) from Wallet order by 1")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                Me.flpWallet.Controls.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Dim button As System.Windows.Forms.Button = New System.Windows.Forms.Button()
                    button.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                    button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
                    Dim backColor As System.Drawing.Color = System.Drawing.Color.FromArgb(102, 106, 105)
                    button.BackColor = backColor
                    button.ForeColor = System.Drawing.Color.White
                    button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
                    button.Width = 180
                    button.Height = 80
                    button.Font = New System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
                    Me.UserButtons.Add(button)
                    Me.flpWallet.Controls.Add(button)
                    AddHandler button.Click, AddressOf Me.Button2_Click
                End While

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Function PGMpesa(OAuthURL As String, ConsumerKey As String, ConsumerSecret As String, C2BSimulateURL As String, ShortCode As String, SalesAmount As Integer, MesaNumber As String, BillReferenceNumber As String) As String
            If String.IsNullOrWhiteSpace(ConsumerKey) OrElse String.IsNullOrWhiteSpace(ConsumerSecret) Then Throw New InvalidOperationException("M-PESA credentials are not configured.")
            If SalesAmount <= 0 Then Throw New ArgumentOutOfRangeException(NameOf(SalesAmount), "The M-PESA amount must be greater than zero.")
            If String.IsNullOrWhiteSpace(ShortCode) OrElse String.IsNullOrWhiteSpace(MesaNumber) OrElse String.IsNullOrWhiteSpace(BillReferenceNumber) Then Throw New ArgumentException("M-PESA short code, mobile number, and bill reference are required.")

            Dim oauthUri = RestaurantPOS14.Security.ExternalResourceGuard.RequireHttpUri(OAuthURL, False)
            Dim paymentUri = RestaurantPOS14.Security.ExternalResourceGuard.RequireHttpUri(C2BSimulateURL, False)
            Dim authorization As String = System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(ConsumerKey.Trim() & ":" & ConsumerSecret))
            Dim tokenRequest = RestaurantPOS14.Security.ExternalResourceGuard.CreateRequest(oauthUri, 20000)
            tokenRequest.Headers.Add("Authorization", "Basic " & authorization)
            tokenRequest.Accept = "application/json"
            tokenRequest.Headers.Add("cache-control", "no-cache")
            tokenRequest.Method = "GET"

            Try
                Using tokenResponse = DirectCast(tokenRequest.GetResponse(), System.Net.HttpWebResponse)
                    Using reader As New System.IO.StreamReader(tokenResponse.GetResponseStream(), System.Text.Encoding.UTF8)
                        Dim payload = Newtonsoft.Json.Linq.JObject.Parse(reader.ReadToEnd())
                        Me.TokenKey = Convert.ToString(payload("access_token"))
                    End Using
                End Using
            Catch ex As System.Net.WebException
                RestaurantPOS14.Diagnostics.ApplicationDiagnostics.ReportNonFatal("M-PESA token request", ex)
                Throw New InvalidOperationException("M-PESA authentication failed. Check the endpoint and credentials.", ex)
            End Try
            If String.IsNullOrWhiteSpace(Me.TokenKey) Then Throw New InvalidOperationException("M-PESA did not return an access token.")

            Dim paymentRequest = RestaurantPOS14.Security.ExternalResourceGuard.CreateRequest(paymentUri, 30000)
            paymentRequest.Method = "POST"
            paymentRequest.Accept = "application/json"
            paymentRequest.Headers.Add("Authorization", "Bearer " & Me.TokenKey)
            paymentRequest.ContentType = "application/json; charset=utf-8"
            Dim json = Newtonsoft.Json.JsonConvert.SerializeObject(New With {
                .ShortCode = ShortCode.Trim(),
                .CommandID = "CustomerPayBillOnline",
                .Amount = SalesAmount,
                .Msisdn = MesaNumber.Trim(),
                .BillRefNumber = BillReferenceNumber.Trim()
            })
            Using writer As New System.IO.StreamWriter(paymentRequest.GetRequestStream(), System.Text.Encoding.UTF8)
                writer.Write(json)
            End Using

            Try
                Using paymentResponse = DirectCast(paymentRequest.GetResponse(), System.Net.HttpWebResponse)
                    Using reader As New System.IO.StreamReader(paymentResponse.GetResponseStream(), System.Text.Encoding.UTF8)
                        reader.ReadToEnd()
                    End Using
                    Return CInt(paymentResponse.StatusCode).ToString()
                End Using
            Catch ex As System.Net.WebException
                RestaurantPOS14.Diagnostics.ApplicationDiagnostics.ReportNonFatal("M-PESA payment request", ex)
                Throw New InvalidOperationException("The M-PESA payment request failed. Verify the number and service settings.", ex)
            End Try
        End Function

        Private Sub Button2_Click(sender As Object, e As System.EventArgs)
            Try
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "Takeaway", TextCompare:=False) = 0 Then
                    Dim text As String = CType(sender, System.Windows.Forms.Button).Text.Trim()
                    Me.ReadMPESASetting()
                    If(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtActiveMpesa.Text, "Yes", TextCompare:=False) = 0) And (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "M-PESA", TextCompare:=False) = 0) Then
                        MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                        Me.Timer2.Enabled = True
                        Me.StatusX = Me.PGMpesa(Me.txtOAuthURL.Text, Me.txtConsumerKey.Text, Me.txtConsumerSecret.Text, Me.txtC2BSimulateURL.Text, Me.txtShortCode.Text, CInt(System.Math.Round(Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtGrandTotal1.Text))), Me.txtMpesaNumber.Text, RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBillNo1.Text)
                        If Me.StatusX.Contains("OK") Or Me.StatusX.Contains("True") Or Me.StatusX.Contains("200") Then
                            RestaurantPOS14.My.MyProject.Forms.frmPOS.lblPaymentMode1.Text = text
                            RestaurantPOS14.My.MyProject.Forms.frmPOS.txtCash1.Text = "0.00"
                            RestaurantPOS14.My.MyProject.Forms.frmPOS.txtCard1.Text = RestaurantPOS14.My.MyProject.Forms.frmPOS.txtGrandTotal1.Text
                            RestaurantPOS14.My.MyProject.Forms.frmPOS.txtChange1.Text = "0.00"
                            If RestaurantPOS14.My.MyProject.Forms.frmPOS.btnSave2.Enabled Then
                                Call RestaurantPOS14.My.MyProject.Forms.frmPOS.btnSave2_Click(Me, System.EventArgs.Empty)
                            Else
                                Call RestaurantPOS14.My.MyProject.Forms.frmPOS.btnUpdateTA_Click(Me, System.EventArgs.Empty)
                            End If

                            Call RestaurantPOS14.My.MyProject.Forms.frmCards_POS.Hide()
                            MyBase.Close()
                        Else
                            Call System.Windows.Forms.MessageBox.Show(Me.StatusX, "Transaction failed", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                        End If

                        Return
                    End If

                    RestaurantPOS14.My.MyProject.Forms.frmPOS.lblPaymentMode1.Text = text
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.txtCash1.Text = "0.00"
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.txtCard1.Text = RestaurantPOS14.My.MyProject.Forms.frmPOS.txtGrandTotal1.Text
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.txtChange1.Text = "0.00"
                    If RestaurantPOS14.My.MyProject.Forms.frmPOS.btnSave2.Enabled Then
                        Call RestaurantPOS14.My.MyProject.Forms.frmPOS.btnSave2_Click(Me, System.EventArgs.Empty)
                    Else
                        Call RestaurantPOS14.My.MyProject.Forms.frmPOS.btnUpdateTA_Click(Me, System.EventArgs.Empty)
                    End If

                    Call RestaurantPOS14.My.MyProject.Forms.frmCards_POS.Hide()
                    MyBase.Close()
                End If

                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "Express Billing", TextCompare:=False) = 0 Then
                    Dim text2 As String = CType(sender, System.Windows.Forms.Button).Text.Trim()
                    Me.ReadMPESASetting()
                    If(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtActiveMpesa.Text, "Yes", TextCompare:=False) = 0) And (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text2, "M-PESA", TextCompare:=False) = 0) Then
                        MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                        Me.Timer2.Enabled = True
                        Me.StatusX = Me.PGMpesa(Me.txtOAuthURL.Text, Me.txtConsumerKey.Text, Me.txtConsumerSecret.Text, Me.txtC2BSimulateURL.Text, Me.txtShortCode.Text, CInt(System.Math.Round(Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtGrandTotal3.Text))), Me.txtMpesaNumber.Text, RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBillNo3.Text)
                        If Me.StatusX.Contains("OK") Or Me.StatusX.Contains("True") Or Me.StatusX.Contains("200") Then
                            RestaurantPOS14.My.MyProject.Forms.frmPOS.lblPaymentMode3.Text = text2
                            RestaurantPOS14.My.MyProject.Forms.frmPOS.txtCash3.Text = "0.00"
                            RestaurantPOS14.My.MyProject.Forms.frmPOS.txtCard3.Text = RestaurantPOS14.My.MyProject.Forms.frmPOS.txtGrandTotal3.Text
                            RestaurantPOS14.My.MyProject.Forms.frmPOS.txtChange3.Text = "0.00"
                            If RestaurantPOS14.My.MyProject.Forms.frmPOS.btnSave4.Enabled Then
                                Call RestaurantPOS14.My.MyProject.Forms.frmPOS.btnSave4_Click(Me, System.EventArgs.Empty)
                            Else
                                Call RestaurantPOS14.My.MyProject.Forms.frmPOS.btnUpdate_Click(Me, System.EventArgs.Empty)
                            End If

                            Call RestaurantPOS14.My.MyProject.Forms.frmCards_POS.Hide()
                            MyBase.Close()
                        Else
                            Call System.Windows.Forms.MessageBox.Show(Me.StatusX, "Transaction failed", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                        End If

                        Return
                    End If

                    RestaurantPOS14.My.MyProject.Forms.frmPOS.lblPaymentMode3.Text = text2
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.txtCash3.Text = "0.00"
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.txtCard3.Text = RestaurantPOS14.My.MyProject.Forms.frmPOS.txtGrandTotal3.Text
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.txtChange3.Text = "0.00"
                    If RestaurantPOS14.My.MyProject.Forms.frmPOS.btnSave4.Enabled Then
                        Call RestaurantPOS14.My.MyProject.Forms.frmPOS.btnSave4_Click(Me, System.EventArgs.Empty)
                    Else
                        Call RestaurantPOS14.My.MyProject.Forms.frmPOS.btnUpdate_Click(Me, System.EventArgs.Empty)
                    End If

                    Call RestaurantPOS14.My.MyProject.Forms.frmCards_POS.Hide()
                    MyBase.Close()
                End If

                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "Home Delivery", TextCompare:=False) = 0 Then
                    Dim text3 As String = CType(sender, System.Windows.Forms.Button).Text.Trim()
                    Me.ReadMPESASetting()
                    If(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtActiveMpesa.Text, "Yes", TextCompare:=False) = 0) And (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text3, "M-PESA", TextCompare:=False) = 0) Then
                        MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                        Me.Timer2.Enabled = True
                        Me.StatusX = Me.PGMpesa(Me.txtOAuthURL.Text, Me.txtConsumerKey.Text, Me.txtConsumerSecret.Text, Me.txtC2BSimulateURL.Text, Me.txtShortCode.Text, CInt(System.Math.Round(Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtGrandTotal2.Text))), Me.txtMpesaNumber.Text, RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBillNo2.Text)
                        If Me.StatusX.Contains("OK") Or Me.StatusX.Contains("True") Or Me.StatusX.Contains("200") Then
                            RestaurantPOS14.My.MyProject.Forms.frmPOS.lblPaymentMode2.Text = text3
                            If RestaurantPOS14.My.MyProject.Forms.frmPOS.btnSave3.Enabled Then
                                Call RestaurantPOS14.My.MyProject.Forms.frmPOS.btnSave3_Click(Me, System.EventArgs.Empty)
                            End If

                            Call RestaurantPOS14.My.MyProject.Forms.frmCards_POS.Hide()
                            MyBase.Close()
                        Else
                            Call System.Windows.Forms.MessageBox.Show(Me.StatusX, "Transaction failed", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                        End If

                        Return
                    End If

                    RestaurantPOS14.My.MyProject.Forms.frmPOS.lblPaymentMode2.Text = text3
                    If RestaurantPOS14.My.MyProject.Forms.frmPOS.btnSave3.Enabled Then
                        Call RestaurantPOS14.My.MyProject.Forms.frmPOS.btnSave3_Click(Me, System.EventArgs.Empty)
                    End If

                    Call RestaurantPOS14.My.MyProject.Forms.frmCards_POS.Hide()
                    MyBase.Close()
                End If

                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "KOT", TextCompare:=False) = 0 Then
                    Dim text4 As String = CType(sender, System.Windows.Forms.Button).Text.Trim()
                    Me.ReadMPESASetting()
                    If(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtActiveMpesa.Text, "Yes", TextCompare:=False) = 0) And (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text4, "M-PESA", TextCompare:=False) = 0) Then
                        MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                        Me.Timer2.Enabled = True
                        Me.StatusX = Me.PGMpesa(Me.txtOAuthURL.Text, Me.txtConsumerKey.Text, Me.txtConsumerSecret.Text, Me.txtC2BSimulateURL.Text, Me.txtShortCode.Text, CInt(System.Math.Round(Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtGrandTotal.Text))), Me.txtMpesaNumber.Text, RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBillNo.Text)
                        If Me.StatusX.Contains("OK") Or Me.StatusX.Contains("True") Or Me.StatusX.Contains("200") Then
                            RestaurantPOS14.My.MyProject.Forms.frmPOS.lblPaymentMode.Text = text4
                            RestaurantPOS14.My.MyProject.Forms.frmPOS.txtCash.Text = "0.00"
                            RestaurantPOS14.My.MyProject.Forms.frmPOS.txtCard.Text = RestaurantPOS14.My.MyProject.Forms.frmPOS.txtGrandTotal.Text
                            RestaurantPOS14.My.MyProject.Forms.frmPOS.txtChange.Text = "0.00"
                            If RestaurantPOS14.My.MyProject.Forms.frmPOS.btnSave1.Enabled Then
                                Call RestaurantPOS14.My.MyProject.Forms.frmPOS.btnSave1_Click(Me, System.EventArgs.Empty)
                            Else
                                Call RestaurantPOS14.My.MyProject.Forms.frmPOS.btnUpdateDIB_Click(Me, System.EventArgs.Empty)
                            End If

                            Call RestaurantPOS14.My.MyProject.Forms.frmCards_POS.Hide()
                            MyBase.Close()
                        Else
                            Call System.Windows.Forms.MessageBox.Show(Me.StatusX, "Transaction failed", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                        End If

                        Return
                    End If

                    RestaurantPOS14.My.MyProject.Forms.frmPOS.lblPaymentMode.Text = text4
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.txtCash.Text = "0.00"
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.txtCard.Text = RestaurantPOS14.My.MyProject.Forms.frmPOS.txtGrandTotal.Text
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.txtChange.Text = "0.00"
                    If RestaurantPOS14.My.MyProject.Forms.frmPOS.btnSave1.Enabled Then
                        Call RestaurantPOS14.My.MyProject.Forms.frmPOS.btnSave1_Click(Me, System.EventArgs.Empty)
                    Else
                        Call RestaurantPOS14.My.MyProject.Forms.frmPOS.btnUpdateDIB_Click(Me, System.EventArgs.Empty)
                    End If

                    Call RestaurantPOS14.My.MyProject.Forms.frmCards_POS.Hide()
                    MyBase.Close()
                End If

                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "Bill Split", TextCompare:=False) <> 0 Then
                    Return
                End If

                Dim text5 As String = CType(sender, System.Windows.Forms.Button).Text.Trim()
                Me.ReadMPESASetting()
                If(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtActiveMpesa.Text, "Yes", TextCompare:=False) = 0) And (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text5, "M-PESA", TextCompare:=False) = 0) Then
                    MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                    Me.Timer2.Enabled = True
                    Me.StatusX = Me.PGMpesa(Me.txtOAuthURL.Text, Me.txtConsumerKey.Text, Me.txtConsumerSecret.Text, Me.txtC2BSimulateURL.Text, Me.txtShortCode.Text, CInt(System.Math.Round(Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmBillSplit.txtGrandTotal.Text))), Me.txtMpesaNumber.Text, RestaurantPOS14.My.MyProject.Forms.frmBillSplit.lblBillNo.Text)
                    If Me.StatusX.Contains("OK") Or Me.StatusX.Contains("True") Or Me.StatusX.Contains("200") Then
                        RestaurantPOS14.My.MyProject.Forms.frmBillSplit.lblPaymentMode.Text = text5
                        RestaurantPOS14.My.MyProject.Forms.frmBillSplit.txtCash.Text = "0.00"
                        RestaurantPOS14.My.MyProject.Forms.frmBillSplit.txtCard.Text = RestaurantPOS14.My.MyProject.Forms.frmBillSplit.txtGrandTotal.Text
                        RestaurantPOS14.My.MyProject.Forms.frmBillSplit.txtChange.Text = "0.00"
                        If RestaurantPOS14.My.MyProject.Forms.frmBillSplit.btnSave1.Enabled Then
                            Call RestaurantPOS14.My.MyProject.Forms.frmBillSplit.btnSave1.PerformClick()
                        End If

                        Call RestaurantPOS14.My.MyProject.Forms.frmCards_POS.Hide()
                        MyBase.Close()
                    Else
                        Call System.Windows.Forms.MessageBox.Show(Me.StatusX, "Transaction failed", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                    End If
                Else
                    RestaurantPOS14.My.MyProject.Forms.frmBillSplit.lblPaymentMode.Text = text5
                    RestaurantPOS14.My.MyProject.Forms.frmBillSplit.txtCash.Text = "0.00"
                    RestaurantPOS14.My.MyProject.Forms.frmBillSplit.txtCard.Text = RestaurantPOS14.My.MyProject.Forms.frmBillSplit.txtGrandTotal.Text
                    RestaurantPOS14.My.MyProject.Forms.frmBillSplit.txtChange.Text = "0.00"
                    If RestaurantPOS14.My.MyProject.Forms.frmBillSplit.btnSave1.Enabled Then
                        Call RestaurantPOS14.My.MyProject.Forms.frmBillSplit.btnSave1.PerformClick()
                    End If

                    Call RestaurantPOS14.My.MyProject.Forms.frmCards_POS.Hide()
                    MyBase.Close()
                End If
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub frmTables_Load(sender As Object, e As System.EventArgs)
            Me.txtMpesaNumber.Text = "254"
            Me.txtMpesaNumber.Focus()
            Me.FillWallet()
        End Sub

        Private Sub btnLogout_Click(sender As Object, e As System.EventArgs)
            MyBase.Close()
        End Sub

        Public Sub ReadMPESASetting()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Select RTRIM(C1),RTRIM(C2),RTRIM(C3),RTRIM(C4),RTRIM(C5),RTRIM(C6) from MpesaSetting")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.txtActiveMpesa.Text = RestaurantPOS14.ModClasses.rdr.GetValue(CInt((0))).ToString()
                    Me.txtOAuthURL.Text = RestaurantPOS14.ModClasses.rdr.GetValue(CInt((1))).ToString()
                    Me.txtConsumerKey.Text = RestaurantPOS14.ModClasses.rdr.GetValue(CInt((2))).ToString()
                    Me.txtConsumerSecret.Text = RestaurantPOS14.ModClasses.rdr.GetValue(CInt((3))).ToString()
                    Me.txtC2BSimulateURL.Text = RestaurantPOS14.ModClasses.rdr.GetValue(CInt((4))).ToString()
                    Me.txtShortCode.Text = RestaurantPOS14.ModClasses.rdr.GetValue(CInt((5))).ToString()
                End If

                If RestaurantPOS14.ModClasses.con.State = System.Data.ConnectionState.Open Then
                    RestaurantPOS14.ModClasses.con.Close()
                End If
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub Timer2_Tick(sender As Object, e As System.EventArgs)
            MyBase.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.Timer2.Enabled = False
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmWalletList))
            Me.flpWallet = New System.Windows.Forms.FlowLayoutPanel()
            Me.txtOAuthURL = New System.Windows.Forms.TextBox()
            Me.txtActiveMpesa = New System.Windows.Forms.TextBox()
            Me.txtShortCode = New System.Windows.Forms.TextBox()
            Me.txtC2BSimulateURL = New System.Windows.Forms.TextBox()
            Me.txtConsumerSecret = New System.Windows.Forms.TextBox()
            Me.txtConsumerKey = New System.Windows.Forms.TextBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.lblSet = New System.Windows.Forms.Label()
            Me.btnClose = New System.Windows.Forms.Button()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtMpesaNumber = New System.Windows.Forms.TextBox()
            Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
            Me.flpWallet.SuspendLayout()
            MyBase.SuspendLayout()
            Me.flpWallet.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.flpWallet.AutoScroll = True
            Me.flpWallet.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.flpWallet.Controls.Add(Me.txtOAuthURL)
            Me.flpWallet.Controls.Add(Me.txtActiveMpesa)
            Me.flpWallet.Controls.Add(Me.txtShortCode)
            Me.flpWallet.Controls.Add(Me.txtC2BSimulateURL)
            Me.flpWallet.Controls.Add(Me.txtConsumerSecret)
            Me.flpWallet.Controls.Add(Me.txtConsumerKey)
            Dim flowLayoutPanel As System.Windows.Forms.FlowLayoutPanel = Me.flpWallet
            Dim location As System.Drawing.Point = New System.Drawing.Point(0, 99)
            flowLayoutPanel.Location = location
            Me.flpWallet.Name = "flpWallet"
            Dim flowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel = Me.flpWallet
            Dim size As System.Drawing.Size = New System.Drawing.Size(817, 334)
            flowLayoutPanel2.Size = size
            Me.flpWallet.TabIndex = 4
            Dim textBox As System.Windows.Forms.TextBox = Me.txtOAuthURL
            location = New System.Drawing.Point(3, 3)
            textBox.Location = location
            Me.txtOAuthURL.Name = "txtOAuthURL"
            Dim textBox2 As System.Windows.Forms.TextBox = Me.txtOAuthURL
            size = New System.Drawing.Size(100, 20)
            textBox2.Size = size
            Me.txtOAuthURL.TabIndex = 401
            Me.txtOAuthURL.Visible = False
            Dim textBox3 As System.Windows.Forms.TextBox = Me.txtActiveMpesa
            location = New System.Drawing.Point(109, 3)
            textBox3.Location = location
            Me.txtActiveMpesa.Name = "txtActiveMpesa"
            Dim textBox4 As System.Windows.Forms.TextBox = Me.txtActiveMpesa
            size = New System.Drawing.Size(100, 20)
            textBox4.Size = size
            Me.txtActiveMpesa.TabIndex = 406
            Me.txtActiveMpesa.Visible = False
            Dim textBox5 As System.Windows.Forms.TextBox = Me.txtShortCode
            location = New System.Drawing.Point(215, 3)
            textBox5.Location = location
            Me.txtShortCode.Name = "txtShortCode"
            Dim textBox6 As System.Windows.Forms.TextBox = Me.txtShortCode
            size = New System.Drawing.Size(100, 20)
            textBox6.Size = size
            Me.txtShortCode.TabIndex = 405
            Me.txtShortCode.Visible = False
            Dim textBox7 As System.Windows.Forms.TextBox = Me.txtC2BSimulateURL
            location = New System.Drawing.Point(321, 3)
            textBox7.Location = location
            Me.txtC2BSimulateURL.Name = "txtC2BSimulateURL"
            Dim textBox8 As System.Windows.Forms.TextBox = Me.txtC2BSimulateURL
            size = New System.Drawing.Size(100, 20)
            textBox8.Size = size
            Me.txtC2BSimulateURL.TabIndex = 404
            Me.txtC2BSimulateURL.Visible = False
            Dim textBox9 As System.Windows.Forms.TextBox = Me.txtConsumerSecret
            location = New System.Drawing.Point(427, 3)
            textBox9.Location = location
            Me.txtConsumerSecret.Name = "txtConsumerSecret"
            Dim textBox10 As System.Windows.Forms.TextBox = Me.txtConsumerSecret
            size = New System.Drawing.Size(100, 20)
            textBox10.Size = size
            Me.txtConsumerSecret.TabIndex = 403
            Me.txtConsumerSecret.Visible = False
            Dim textBox11 As System.Windows.Forms.TextBox = Me.txtConsumerKey
            location = New System.Drawing.Point(533, 3)
            textBox11.Location = location
            Me.txtConsumerKey.Name = "txtConsumerKey"
            Dim textBox12 As System.Windows.Forms.TextBox = Me.txtConsumerKey
            size = New System.Drawing.Size(100, 20)
            textBox12.Size = size
            Me.txtConsumerKey.TabIndex = 402
            Me.txtConsumerKey.Visible = False
            Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.Label5.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label5.ForeColor = System.Drawing.Color.White
            Dim label As System.Windows.Forms.Label = Me.Label5
            location = New System.Drawing.Point(1, 1)
            label.Location = location
            Me.Label5.Name = "Label5"
            Dim label2 As System.Windows.Forms.Label = Me.Label5
            size = New System.Drawing.Size(754, 50)
            label2.Size = size
            Me.Label5.TabIndex = 390
            Me.Label5.Text = "List of Wallets"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.lblSet.AutoSize = True
            Dim label3 As System.Windows.Forms.Label = Me.lblSet
            location = New System.Drawing.Point(46, 22)
            label3.Location = location
            Me.lblSet.Name = "lblSet"
            Dim label4 As System.Windows.Forms.Label = Me.lblSet
            size = New System.Drawing.Size(23, 13)
            label4.Size = size
            Me.lblSet.TabIndex = 3
            Me.lblSet.Text = "Set"
            Me.lblSet.Visible = False
            Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
            Me.btnClose.BackColor = System.Drawing.Color.Transparent
            Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnClose.FlatAppearance.BorderSize = 0
            Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnClose.Image = CType(componentResourceManager.GetObject("btnClose.Image"), System.Drawing.Image)
            Dim button As System.Windows.Forms.Button = Me.btnClose
            location = New System.Drawing.Point(761, 2)
            button.Location = location
            Me.btnClose.Name = "btnClose"
            Dim button2 As System.Windows.Forms.Button = Me.btnClose
            size = New System.Drawing.Size(52, 49)
            button2.Size = size
            Me.btnClose.TabIndex = 392
            Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnClose.UseVisualStyleBackColor = False
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label3.ForeColor = System.Drawing.Color.White
            Dim label5 As System.Windows.Forms.Label = Me.Label3
            location = New System.Drawing.Point(272, 65)
            label5.Location = location
            Me.Label3.Name = "Label3"
            Dim label6 As System.Windows.Forms.Label = Me.Label3
            size = New System.Drawing.Size(202, 13)
            label6.Size = size
            Me.Label3.TabIndex = 400
            Me.Label3.Text = "*Only Applicable for African Countries.*"
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label2.ForeColor = System.Drawing.Color.White
            Dim label7 As System.Windows.Forms.Label = Me.Label2
            location = New System.Drawing.Point(5, 83)
            label7.Location = location
            Me.Label2.Name = "Label2"
            Dim label8 As System.Windows.Forms.Label = Me.Label2
            size = New System.Drawing.Size(291, 13)
            label8.Size = size
            Me.Label2.TabIndex = 399
            Me.Label2.Text = "*This is the phone number initiating the C2B transaction.*"
            Me.Label1.AutoSize = True
            Me.Label1.ForeColor = System.Drawing.Color.White
            Dim label9 As System.Windows.Forms.Label = Me.Label1
            location = New System.Drawing.Point(5, 60)
            label9.Location = location
            Me.Label1.Name = "Label1"
            Dim label10 As System.Windows.Forms.Label = Me.Label1
            size = New System.Drawing.Size(89, 13)
            label10.Size = size
            Me.Label1.TabIndex = 398
            Me.Label1.Text = "M-PESA Msisdn :"
            Dim textBox13 As System.Windows.Forms.TextBox = Me.txtMpesaNumber
            location = New System.Drawing.Point(101, 60)
            textBox13.Location = location
            Me.txtMpesaNumber.Name = "txtMpesaNumber"
            Dim textBox14 As System.Windows.Forms.TextBox = Me.txtMpesaNumber
            size = New System.Drawing.Size(165, 20)
            textBox14.Size = size
            Me.txtMpesaNumber.TabIndex = 397
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            size = New System.Drawing.Size(817, 433)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.Label3)
            MyBase.Controls.Add(Me.Label2)
            MyBase.Controls.Add(Me.Label1)
            MyBase.Controls.Add(Me.txtMpesaNumber)
            MyBase.Controls.Add(Me.lblSet)
            MyBase.Controls.Add(Me.btnClose)
            MyBase.Controls.Add(Me.Label5)
            MyBase.Controls.Add(Me.flpWallet)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.Name = "frmWalletList"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Tables"
            Me.flpWallet.ResumeLayout(False)
            Me.flpWallet.PerformLayout()
            MyBase.ResumeLayout(False)
            MyBase.PerformLayout()
        End Sub
    End Class
End Namespace
