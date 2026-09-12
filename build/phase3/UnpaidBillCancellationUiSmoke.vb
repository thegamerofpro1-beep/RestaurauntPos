Option Explicit On
Option Strict On

Imports System
Imports System.Data
Imports System.Drawing
Imports System.Reflection
Imports System.Windows.Forms
Imports RestaurantPOS14

Module UnpaidBillCancellationUiSmoke
    Private Class PreviewDialog
        Inherits frmCancelUnpaidBill
        Public Sub New()
            MyBase.New("", "cashier")
        End Sub
        Protected Overrides Sub OnShown(e As EventArgs)
            ' Render fixture controls only; never run the real database-load event.
        End Sub
    End Class
    <STAThread>
    Public Sub Main(args As String())
        If args.Length <> 1 Then Throw New ArgumentException("Expected PNG output path.")
        Application.EnableVisualStyles()
        Using dialog As New PreviewDialog()
            dialog.StartPosition = FormStartPosition.Manual
            dialog.Location = New Point(-32000, -32000)
            dialog.ShowInTaskbar = False
            Dim table As New DataTable()
            table.Columns.Add("ID", GetType(Integer))
            table.Columns.Add("BillNo", GetType(String))
            table.Columns.Add("BillDate", GetType(DateTime))
            table.Columns.Add("Operator", GetType(String))
            table.Columns.Add("GrandTotal", GetType(Decimal))
            table.Columns.Add("BillType", GetType(String))
            table.Columns.Add("Tables", GetType(String))
            table.Rows.Add(10, "DIB-0010", New DateTime(2026,9,4,13,25,0), "other-cashier", 125.4D, "Normal Bill", "TABLE 4, TABLE 10")
            table.Rows.Add(11, "DIB-0011", New DateTime(2026,9,3,11,0,0), "waiter", 25D, "Normal Bill", "Chef's Table")
            Dim grid = DirectCast(GetType(frmCancelUnpaidBill).GetField("bills", BindingFlags.NonPublic Or BindingFlags.Instance).GetValue(dialog), DataGridView)
            grid.DataSource = table
            dialog.Show()
            Application.DoEvents()
            grid.Columns("ID").Visible = False
            grid.Columns("BillDate").DefaultCellStyle.Format = "dd/MM/yyyy HH:mm"
            grid.Columns("GrandTotal").DefaultCellStyle.Format = "'RM ' #,##0.00"
            grid.Columns("Tables").FillWeight = 150
            dialog.PerformLayout()
            Using bitmap As New Bitmap(dialog.Width, dialog.Height)
                dialog.DrawToBitmap(bitmap, New Rectangle(Point.Empty, dialog.Size))
                bitmap.Save(args(0), Imaging.ImageFormat.Png)
            End Using
            dialog.Hide()
            If Not DirectCast(GetType(frmCancelUnpaidBill).GetField("cancelBill", BindingFlags.NonPublic Or BindingFlags.Instance).GetValue(dialog), Button).Enabled Then
                Throw New InvalidOperationException("Cancellation action is not available to a cashier.")
            End If
            Console.WriteLine("PASS|CashierActionEnabled|OffscreenUiRendered|NoLiveActions")
        End Using
    End Sub
End Module
