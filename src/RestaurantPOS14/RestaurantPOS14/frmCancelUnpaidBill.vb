Option Explicit On
Option Strict On

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Globalization
Imports System.Windows.Forms
Imports RestaurantPOS14.Billing

Namespace RestaurantPOS14
    Public Class frmCancelUnpaidBill
        Inherits Form

        Private ReadOnly databaseConnection As String
        Private ReadOnly signedInUser As String
        Private ReadOnly bills As New DataGridView()
        Private ReadOnly reason As New TextBox()
        Private ReadOnly cancelBill As New Button()
        Private ReadOnly refreshBills As New Button()
        Public Property BillWasCancelled As Boolean
        Public Property CancelledBillId As Integer

        Public Sub New(connectionString As String, actor As String)
            databaseConnection = connectionString
            signedInUser = actor
            Text = "Cancel Unpaid Bill"
            StartPosition = FormStartPosition.CenterParent
            Size = New Size(920, 600)
            MinimumSize = New Size(780, 520)
            Font = New Font("Segoe UI", 10.0F)
            MinimizeBox = False

            Dim layout As New TableLayoutPanel With {.Dock = DockStyle.Fill, .Padding = New Padding(14), .ColumnCount = 1, .RowCount = 5}
            layout.RowStyles.Add(New RowStyle(SizeType.Absolute, 58))
            layout.RowStyles.Add(New RowStyle(SizeType.Percent, 100))
            layout.RowStyles.Add(New RowStyle(SizeType.Absolute, 28))
            layout.RowStyles.Add(New RowStyle(SizeType.Absolute, 65))
            layout.RowStyles.Add(New RowStyle(SizeType.Absolute, 52))
            layout.Controls.Add(New Label With {
                .Dock = DockStyle.Fill,
                .Text = "Available to all users. Select a fully unpaid normal bill (any date/operator)." & vbCrLf &
                    "Kitchen orders and stock stay unchanged. Split bills or bills with payment/account entries need reconciliation."}, 0, 0)

            bills.Dock = DockStyle.Fill
            bills.ReadOnly = True
            bills.AllowUserToAddRows = False
            bills.AllowUserToDeleteRows = False
            bills.MultiSelect = False
            bills.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            bills.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            bills.AutoGenerateColumns = True
            bills.BackgroundColor = Color.White
            layout.Controls.Add(bills, 0, 1)
            layout.Controls.Add(New Label With {.Text = "Cancellation reason (required, up to 200 characters):", .Dock = DockStyle.Fill, .TextAlign = ContentAlignment.BottomLeft}, 0, 2)
            reason.Multiline = True
            reason.MaxLength = 200
            reason.Dock = DockStyle.Fill
            layout.Controls.Add(reason, 0, 3)

            Dim actions As New FlowLayoutPanel With {.Dock = DockStyle.Fill, .FlowDirection = FlowDirection.RightToLeft, .Padding = New Padding(0, 8, 0, 0)}
            Dim closeButton As New Button With {.Text = "Close", .Width = 100, .Height = 34}
            cancelBill.Text = "Cancel Selected Bill"
            cancelBill.Width = 190
            cancelBill.Height = 34
            refreshBills.Text = "Refresh"
            refreshBills.Width = 100
            refreshBills.Height = 34
            actions.Controls.Add(closeButton)
            actions.Controls.Add(cancelBill)
            actions.Controls.Add(refreshBills)
            layout.Controls.Add(actions, 0, 4)
            Controls.Add(layout)
            CancelButton = closeButton
            AddHandler closeButton.Click, Sub() Close()
            AddHandler refreshBills.Click, Sub() ReloadBills()
            AddHandler cancelBill.Click, AddressOf CancelSelectedBill
            AddHandler Shown, Sub() ReloadBills()
        End Sub

        Private Sub ReloadBills()
            Try
                Using connection As New SqlConnection(databaseConnection)
                    connection.Open()
                    Configuration.DatabaseMaintenance.EnsureCompatibleSchema(connection)
                    bills.DataSource = UnpaidBillCancellation.ListUnpaid(connection)
                End Using
                bills.Columns("ID").Visible = False
                bills.Columns("BillNo").HeaderText = "Bill No."
                bills.Columns("BillDate").HeaderText = "Bill Date"
                bills.Columns("BillDate").DefaultCellStyle.Format = "dd/MM/yyyy HH:mm"
                bills.Columns("GrandTotal").HeaderText = "Total"
                bills.Columns("GrandTotal").DefaultCellStyle.Format = "'RM ' #,##0.00"
                bills.Columns("BillType").HeaderText = "Bill Type"
                bills.Columns("Tables").FillWeight = 150
                bills.ClearSelection()
                cancelBill.Enabled = bills.Rows.Count > 0
            Catch ex As Exception
                cancelBill.Enabled = False
                Diagnostics.ApplicationDiagnostics.ReportNonFatal("Load unpaid bills for cancellation", ex)
                MessageBox.Show(Me, ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub CancelSelectedBill(sender As Object, e As EventArgs)
            If bills.SelectedRows.Count <> 1 Then
                MessageBox.Show(Me, "Select the unpaid bill to cancel.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
            If String.IsNullOrWhiteSpace(reason.Text) Then
                MessageBox.Show(Me, "Enter a cancellation reason.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                reason.Focus()
                Return
            End If
            Dim row = DirectCast(bills.SelectedRows(0).DataBoundItem, DataRowView).Row
            Dim billNo = CStr(row("BillNo"))
            Dim amount = CDec(row("GrandTotal"))
            Dim confirmation = "Cancel " & billNo & " (RM " & amount.ToString("N2", CultureInfo.InvariantCulture) & ")?" & vbCrLf &
                "Affected tables: " & Convert.ToString(row("Tables")) & vbCrLf &
                "This cancels the whole bill, including all merged tables. No payment or refund will be recorded." & vbCrLf &
                "Kitchen orders remain available. Cancellation is permanent and recorded under " & signedInUser & "." & vbCrLf &
                "Reason: " & reason.Text.Trim()
            If MessageBox.Show(Me, confirmation, Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) <> DialogResult.Yes Then Return
            cancelBill.Enabled = False
            refreshBills.Enabled = False
            Try
                Using connection As New SqlConnection(databaseConnection)
                    connection.Open()
                    UnpaidBillCancellation.Cancel(connection, CInt(row("ID")), billNo, amount, signedInUser, reason.Text)
                End Using
                BillWasCancelled = True
                CancelledBillId = CInt(row("ID"))
                MessageBox.Show(Me, billNo & " was cancelled and archived. No cash payment was recorded." & vbCrLf &
                    "Return to Dine In, select the table/order again, make the correction, then generate a new bill.",
                    Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                DialogResult = DialogResult.OK
                Close()
            Catch ex As Exception
                Diagnostics.ApplicationDiagnostics.ReportNonFatal("Cancel unpaid dine-in bill", ex)
                MessageBox.Show(Me, ex.Message & vbCrLf & "Refresh the bill list before trying again; do not record a payment to clear this warning.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                ReloadBills()
            Finally
                refreshBills.Enabled = True
            End Try
        End Sub
    End Class
End Namespace
