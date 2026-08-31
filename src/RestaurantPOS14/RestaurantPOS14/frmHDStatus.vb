Imports System
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

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public Class frmHDStatus
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnDelivered")>
        Private _btnDelivered As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnCancelled")>
        Private _btnCancelled As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtHdID")>
        Private _txtHdID As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label1")>
        Private _Label1 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtAmountReceived")>
        Private _txtAmountReceived As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnCash2")>
        Private _btnCash2 As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnCreditCard2")>
        Private _btnCreditCard2 As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnDebitCard2")>
        Private _btnDebitCard2 As System.Windows.Forms.Button

        Private components As System.ComponentModel.IContainer

        Friend Overridable Property btnDelivered As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnDelivered
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnBackOffice_Click
                If Me._btnDelivered IsNot Nothing Then
                    RemoveHandler Me._btnDelivered.Click, value2
                End If

                Me._btnDelivered = value
                If Me._btnDelivered IsNot Nothing Then
                    AddHandler Me._btnDelivered.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnCancelled As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnCancelled
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnCancelled_Click
                If Me._btnCancelled IsNot Nothing Then
                    RemoveHandler Me._btnCancelled.Click, value2
                End If

                Me._btnCancelled = value
                If Me._btnCancelled IsNot Nothing Then
                    AddHandler Me._btnCancelled.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property txtHdID As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtHdID
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtHdID = value
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

        Friend Overridable Property txtAmountReceived As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtAmountReceived
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.Windows.Forms.KeyPressEventHandler = AddressOf Me.txtAmountReceived_KeyPress
                If Me._txtAmountReceived IsNot Nothing Then
                    RemoveHandler Me._txtAmountReceived.KeyPress, value2
                End If

                Me._txtAmountReceived = value
                If Me._txtAmountReceived IsNot Nothing Then
                    AddHandler Me._txtAmountReceived.KeyPress, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnCash2 As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnCash2
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnCash2_Click
                If Me._btnCash2 IsNot Nothing Then
                    RemoveHandler Me._btnCash2.Click, value2
                End If

                Me._btnCash2 = value
                If Me._btnCash2 IsNot Nothing Then
                    AddHandler Me._btnCash2.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnCreditCard2 As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnCreditCard2
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnCreditCard2_Click
                If Me._btnCreditCard2 IsNot Nothing Then
                    RemoveHandler Me._btnCreditCard2.Click, value2
                End If

                Me._btnCreditCard2 = value
                If Me._btnCreditCard2 IsNot Nothing Then
                    AddHandler Me._btnCreditCard2.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnDebitCard2 As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnDebitCard2
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnDebitCard2_Click
                If Me._btnDebitCard2 IsNot Nothing Then
                    RemoveHandler Me._btnDebitCard2.Click, value2
                End If

                Me._btnDebitCard2 = value
                If Me._btnDebitCard2 IsNot Nothing Then
                    AddHandler Me._btnDebitCard2.Click, value2
                End If
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            Call RestaurantPOS14.frmHDStatus.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmHDStatus.__ENCList
                If RestaurantPOS14.frmHDStatus.__ENCList.Count = RestaurantPOS14.frmHDStatus.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmHDStatus.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmHDStatus.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmHDStatus.__ENCList(num) = RestaurantPOS14.frmHDStatus.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmHDStatus.__ENCList.RemoveRange(num, RestaurantPOS14.frmHDStatus.__ENCList.Count - num)
                    RestaurantPOS14.frmHDStatus.__ENCList.Capacity = RestaurantPOS14.frmHDStatus.__ENCList.Count
                End If

                Call RestaurantPOS14.frmHDStatus.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Private Sub btnBackOffice_Click(sender As Object, e As System.EventArgs)
            Try
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(RestaurantPOS14.My.MyProject.Forms.frmPOS.lblPaymentMode2.Text, "Credit Customer", TextCompare:=False) <> 0 Then
                    If Microsoft.VisualBasic.Conversion.Val(Me.txtAmountReceived.Text) < Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtGrandTotal2.Text) Then
                        Call System.Windows.Forms.MessageBox.Show("Amount received can't be less than bill total amount.", "Input Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                        Me.txtAmountReceived.Text = ""
                        Me.txtAmountReceived.Focus()
                        Return
                    End If

                    If Microsoft.VisualBasic.Conversion.Val(Me.txtAmountReceived.Text) > Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtGrandTotal2.Text) Then
                        Call System.Windows.Forms.MessageBox.Show("Amount received can't be more than bill total amount.", "Input Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                        Me.txtAmountReceived.Text = ""
                        Me.txtAmountReceived.Focus()
                        Return
                    End If
                End If

                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Update RestaurantPOS_BillingInfoHD Set HD_Status='Delivered',AmtReceived=" & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.txtAmountReceived.Text)) & ",PaymentMode=@d1 where ID=" & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.txtHdID.Text)))
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", RestaurantPOS14.My.MyProject.Forms.frmPOS.lblPaymentMode2.Text)
                RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.Extensions.Events.IntegrationEventHost.PublishBillSettledIfEligible(Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(Microsoft.VisualBasic.Conversion.Val(Me.txtHdID.Text)), "HD")
                Call System.Windows.Forms.MessageBox.Show("Successfully Changed", "Status", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                MyBase.Close()
                Call RestaurantPOS14.My.MyProject.Forms.frmPOS.Reset3()
                Call RestaurantPOS14.My.MyProject.Forms.frmPOS.Reset3()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnCancelled_Click(sender As Object, e As System.EventArgs)
            Try
                If System.Windows.Forms.MessageBox.Show("Do you really want to cancel the bill?", "Confirmation", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                    If System.Windows.Forms.MessageBox.Show("Does the stock affected?", "Confirmation", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                        RestaurantPOS14.My.MyProject.Forms.frmCustomDialogX.lblSet.Text = "Void HD"
                        Call RestaurantPOS14.My.MyProject.Forms.frmCustomDialogX.ShowDialog()
                    Else
                        RestaurantPOS14.My.MyProject.Forms.frmCustomDialogX.lblSet.Text = "Void RHD"
                        Call RestaurantPOS14.My.MyProject.Forms.frmCustomDialogX.ShowDialog()
                        MyBase.Close()
                    End If
                End If
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub txtAmountReceived_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
            Dim keyChar As Char = e.KeyChar
            If Char.IsControl(keyChar) Then
                Return
            End If

            If Char.IsDigit(keyChar) OrElse keyChar = "."c Then
                Dim text As String = Me.txtAmountReceived.Text
                Dim selectionStart As Integer = Me.txtAmountReceived.SelectionStart
                Dim selectionLength As Integer = Me.txtAmountReceived.SelectionLength
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

        Private Sub btnCreditCard2_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmPOS.lblPaymentMode2.Text = Me.btnCreditCard2.Text
            Me.txtAmountReceived.Text = RestaurantPOS14.My.MyProject.Forms.frmPOS.txtGrandTotal2.Text
        End Sub

        Private Sub btnDebitCard2_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmPOS.lblPaymentMode2.Text = Me.btnDebitCard2.Text
            Me.txtAmountReceived.Text = RestaurantPOS14.My.MyProject.Forms.frmPOS.txtGrandTotal2.Text
        End Sub

        Private Sub btnCash2_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmPOS.lblPaymentMode2.Text = Me.btnCash2.Text
            Me.txtAmountReceived.Text = RestaurantPOS14.My.MyProject.Forms.frmPOS.txtGrandTotal2.Text
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmHDStatus))
            Me.btnDelivered = New System.Windows.Forms.Button()
            Me.btnCancelled = New System.Windows.Forms.Button()
            Me.txtHdID = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtAmountReceived = New System.Windows.Forms.TextBox()
            Me.btnCash2 = New System.Windows.Forms.Button()
            Me.btnCreditCard2 = New System.Windows.Forms.Button()
            Me.btnDebitCard2 = New System.Windows.Forms.Button()
            MyBase.SuspendLayout()
            Me.btnDelivered.BackColor = System.Drawing.Color.Green
            Me.btnDelivered.FlatAppearance.BorderSize = 0
            Me.btnDelivered.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnDelivered.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnDelivered.ForeColor = System.Drawing.Color.White
            Dim button As System.Windows.Forms.Button = Me.btnDelivered
            Dim location As System.Drawing.Point = New System.Drawing.Point(143, 98)
            button.Location = location
            Me.btnDelivered.Name = "btnDelivered"
            Dim button2 As System.Windows.Forms.Button = Me.btnDelivered
            Dim size As System.Drawing.Size = New System.Drawing.Size(282, 88)
            button2.Size = size
            Me.btnDelivered.TabIndex = 1
            Me.btnDelivered.Text = "Delivered"
            Me.btnDelivered.UseVisualStyleBackColor = False
            Me.btnCancelled.BackColor = System.Drawing.Color.Crimson
            Me.btnCancelled.FlatAppearance.BorderSize = 0
            Me.btnCancelled.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnCancelled.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnCancelled.ForeColor = System.Drawing.Color.White
            Dim button3 As System.Windows.Forms.Button = Me.btnCancelled
            location = New System.Drawing.Point(143, 192)
            button3.Location = location
            Me.btnCancelled.Name = "btnCancelled"
            Dim button4 As System.Windows.Forms.Button = Me.btnCancelled
            size = New System.Drawing.Size(282, 97)
            button4.Size = size
            Me.btnCancelled.TabIndex = 2
            Me.btnCancelled.Text = "Cancelled"
            Me.btnCancelled.UseVisualStyleBackColor = False
            Dim textBox As System.Windows.Forms.TextBox = Me.txtHdID
            location = New System.Drawing.Point(514, 3)
            textBox.Location = location
            Me.txtHdID.Name = "txtHdID"
            Dim textBox2 As System.Windows.Forms.TextBox = Me.txtHdID
            size = New System.Drawing.Size(100, 20)
            textBox2.Size = size
            Me.txtHdID.TabIndex = 3
            Me.txtHdID.Visible = False
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label1.ForeColor = System.Drawing.Color.White
            Dim label As System.Windows.Forms.Label = Me.Label1
            location = New System.Drawing.Point(13, 13)
            label.Location = location
            Me.Label1.Name = "Label1"
            Dim label2 As System.Windows.Forms.Label = Me.Label1
            size = New System.Drawing.Size(359, 25)
            label2.Size = size
            Me.Label1.TabIndex = 4
            Me.Label1.Text = "Amount Received from Delivery Person :"
            Me.txtAmountReceived.BackColor = System.Drawing.SystemColors.Info
            Me.txtAmountReceived.Font = New System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox3 As System.Windows.Forms.TextBox = Me.txtAmountReceived
            location = New System.Drawing.Point(18, 41)
            textBox3.Location = location
            Me.txtAmountReceived.Name = "txtAmountReceived"
            Dim textBox4 As System.Windows.Forms.TextBox = Me.txtAmountReceived
            size = New System.Drawing.Size(160, 43)
            textBox4.Size = size
            Me.txtAmountReceived.TabIndex = 5
            Me.txtAmountReceived.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.btnCash2.BackColor = System.Drawing.Color.Green
            Me.btnCash2.FlatAppearance.BorderSize = 0
            Me.btnCash2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnCash2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnCash2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Dim button5 As System.Windows.Forms.Button = Me.btnCash2
            location = New System.Drawing.Point(18, 98)
            button5.Location = location
            Me.btnCash2.Name = "btnCash2"
            Dim button6 As System.Windows.Forms.Button = Me.btnCash2
            size = New System.Drawing.Size(119, 63)
            button6.Size = size
            Me.btnCash2.TabIndex = 370
            Me.btnCash2.Text = "Cash"
            Me.btnCash2.UseVisualStyleBackColor = False
            Me.btnCreditCard2.BackColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.btnCreditCard2.FlatAppearance.BorderSize = 0
            Me.btnCreditCard2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnCreditCard2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnCreditCard2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Dim button7 As System.Windows.Forms.Button = Me.btnCreditCard2
            location = New System.Drawing.Point(18, 167)
            button7.Location = location
            Me.btnCreditCard2.Name = "btnCreditCard2"
            Dim button8 As System.Windows.Forms.Button = Me.btnCreditCard2
            size = New System.Drawing.Size(119, 60)
            button8.Size = size
            Me.btnCreditCard2.TabIndex = 371
            Me.btnCreditCard2.Text = "Credit Card"
            Me.btnCreditCard2.UseVisualStyleBackColor = False
            Me.btnDebitCard2.BackColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.btnDebitCard2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnDebitCard2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnDebitCard2.ForeColor = System.Drawing.Color.White
            Dim button9 As System.Windows.Forms.Button = Me.btnDebitCard2
            location = New System.Drawing.Point(18, 232)
            button9.Location = location
            Me.btnDebitCard2.Name = "btnDebitCard2"
            Dim button10 As System.Windows.Forms.Button = Me.btnDebitCard2
            size = New System.Drawing.Size(119, 57)
            button10.Size = size
            Me.btnDebitCard2.TabIndex = 372
            Me.btnDebitCard2.Text = "Debit Card"
            Me.btnDebitCard2.UseVisualStyleBackColor = False
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            size = New System.Drawing.Size(435, 302)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.btnCash2)
            MyBase.Controls.Add(Me.btnCreditCard2)
            MyBase.Controls.Add(Me.btnDebitCard2)
            MyBase.Controls.Add(Me.txtAmountReceived)
            MyBase.Controls.Add(Me.Label1)
            MyBase.Controls.Add(Me.txtHdID)
            MyBase.Controls.Add(Me.btnCancelled)
            MyBase.Controls.Add(Me.btnDelivered)
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MaximizeBox = False
            MyBase.MinimizeBox = False
            MyBase.Name = "frmHDStatus"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Change Status"
            MyBase.ResumeLayout(False)
            MyBase.PerformLayout()
        End Sub
    End Class
End Namespace
