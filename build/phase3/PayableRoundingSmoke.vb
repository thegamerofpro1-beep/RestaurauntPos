Option Explicit On
Option Strict On
Imports System
Imports System.Drawing
Imports System.Globalization
Imports System.Reflection
Imports System.Windows.Forms
Imports RestaurantPOS14
Imports RestaurantPOS14.Configuration

Module PayableRoundingSmoke
    Private checks As Integer

    Private Class DisplayPreview
        Inherits frmSecondaryDisplay
        Protected Overrides Sub OnLoad(e As EventArgs)
            ' Skip database/image loading; this is an offscreen synthetic preview.
        End Sub
    End Class

    <STAThread>
    Sub Main(args As String())
        Try
            Dim cases As Decimal(,) = {{0D, 0D}, {1.64D, 1.6D}, {1.65D, 1.7D}, {1.67D, 1.7D}, {1.74D, 1.7D}, {1.75D, 1.8D}, {1.649D, 1.6D}, {121.85D, 121.9D}, {999999.99D, 1000000D}, {-1.65D, -1.7D}}
            For i = 0 To cases.GetLength(0) - 1
                Equal(MoneyMath.RoundPayableTotal(cases(i, 0)), cases(i, 1), "rounding boundary")
                Equal(MoneyMath.RoundPayableTotal(cases(i, 1)), cases(i, 1), "idempotence")
            Next
            Dim originalCulture = Globalization.CultureInfo.CurrentCulture
            Globalization.CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("de-DE")
            If MoneyMath.FormatPayableTotal(1.67) <> "1.70" Then Throw New Exception("Legacy numeric parsing needs an invariant decimal point")
            Globalization.CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-MY")
            ' Use a process-local empty permissions cache. No database or sale mutations.
            Dim rightsType = GetType(frmPOS).Assembly.GetType("RestaurantPOS14.ModFunc", True)
            rightsType.GetMethod("ClearUserRightsCache").Invoke(Nothing, Nothing)
            rightsType.GetField("CachedUserRightsLoaded", BindingFlags.Static Or BindingFlags.NonPublic).SetValue(Nothing, True)
            Application.EnableVisualStyles()
            Using pos As New frmPOS()
                ControlOf(Of TextBox)(pos, "txtColoredCustomerDisplay").Text = "No"
                ControlOf(Of Label)(pos, "lblUserVAL").Text = ""
                Dim grids = New DataGridView() {ControlOf(Of DataGridView)(pos, "DataGridView2"), ControlOf(Of DataGridView)(pos, "DataGridView3"), ControlOf(Of DataGridView)(pos, "DataGridView4"), ControlOf(Of DataGridView)(pos, "DataGridView5")}
                Dim combos = New ComboBox() {ControlOf(Of ComboBox)(pos, "cmbKOTDiscountType"), ControlOf(Of ComboBox)(pos, "cmbTADiscountType"), ControlOf(Of ComboBox)(pos, "cmbHDDiscountType"), ControlOf(Of ComboBox)(pos, "cmbEBDiscountType")}
                Dim totals = New TextBox() {ControlOf(Of TextBox)(pos, "txtGrandTotal"), ControlOf(Of TextBox)(pos, "txtGrandTotal1"), ControlOf(Of TextBox)(pos, "txtGrandTotal2"), ControlOf(Of TextBox)(pos, "txtGrandTotal3")}
                Dim cash = New TextBox() {ControlOf(Of TextBox)(pos, "txtCash"), ControlOf(Of TextBox)(pos, "txtCash1"), Nothing, ControlOf(Of TextBox)(pos, "txtCash3")}
                Dim change = New TextBox() {ControlOf(Of TextBox)(pos, "txtChange"), ControlOf(Of TextBox)(pos, "txtChange1"), Nothing, ControlOf(Of TextBox)(pos, "txtChange3")}
                Dim calculate = New Action() {AddressOf pos.Calc, AddressOf pos.Calc1, AddressOf pos.Calc2, AddressOf pos.Calc3}
                For mode = 0 To 3
                    For discountMode = 0 To 1
                        grids(mode).Rows.Clear()
                        combos(mode).SelectedIndex = discountMode
                        AddLine(grids(mode), mode = 0, 1.67D)
                        If cash(mode) IsNot Nothing Then cash(mode).Text = "2.00"
                        calculate(mode)()
                        Equal(Decimal.Parse(totals(mode).Text, CultureInfo.InvariantCulture), 1.7D, "payable mode " & mode & "/" & discountMode)
                        If change(mode) IsNot Nothing Then Equal(Decimal.Parse(change(mode).Text, CultureInfo.InvariantCulture), 0.3D, "change mode " & mode)
                        Equal(Convert.ToDecimal(grids(mode).Rows(0).Cells(If(mode = 0, 13, 12)).Value), 1.67D, "line amount must not round to 10 sen")
                        calculate(mode)()
                        Equal(Decimal.Parse(totals(mode).Text, CultureInfo.InvariantCulture), 1.7D, "recalculate")
                    Next
                Next
                ' Delivery is applied before rounding, not rounded separately.
                ControlOf(Of TextBox)(pos, "txtDeliveryCharges").Text = "0.07"
                pos.Calc2()
                Equal(Decimal.Parse(ControlOf(Of TextBox)(pos, "txtGrandTotal2").Text, CultureInfo.InvariantCulture), 1.7D, "1.67 + 0.07 before rounding")
                ControlOf(Of TextBox)(pos, "txtTip2").Text = "0.01"
                pos.Calc2()
                Equal(Decimal.Parse(ControlOf(Of TextBox)(pos, "txtGrandTotal2").Text, CultureInfo.InvariantCulture), 1.8D, "tip applied before rounding")
            End Using
            Using split As New frmBillSplit()
                ControlOf(Of Label)(split, "lblUserVAL").Text = ""
                For discountMode = 0 To 1
                    ControlOf(Of DataGridView)(split, "DataGridView2").Rows.Clear()
                    ControlOf(Of ComboBox)(split, "cmbKOTDiscountType").SelectedIndex = discountMode
                    AddLine(ControlOf(Of DataGridView)(split, "DataGridView2"), True, 1.67D)
                    ControlOf(Of TextBox)(split, "txtCash").Text = "2.00"
                    split.Calc()
                    Equal(Decimal.Parse(ControlOf(Of TextBox)(split, "txtGrandTotal").Text, CultureInfo.InvariantCulture), 1.7D, "split payable")
                    Equal(Decimal.Parse(ControlOf(Of TextBox)(split, "txtChange").Text, CultureInfo.InvariantCulture), 0.3D, "split change")
                Next
            End Using
            ' Exercise the actual display formatting without showing a live POS window.
            Using display As New DisplayPreview()
                display.StartPosition = FormStartPosition.Manual
                display.WindowState = FormWindowState.Normal
                display.Location = New Point(-32000, -32000)
                display.ClientSize = New Size(1200, 720)
                display.Show()
                ControlOf(Of Label)(display, "lblTotal").Text = MoneyMath.FormatPayableTotal(1.67)
                If ControlOf(Of Label)(display, "lblTotal").Text <> "RM 1.70" Then Throw New Exception("Customer total format mismatch: " & ControlOf(Of Label)(display, "lblTotal").Text)
                ControlOf(Of Label)(display, "lblHST").Text = "0.07"
                If ControlOf(Of Label)(display, "lblHST").Text <> "RM 0.07" Then Throw New Exception("Service charge was rounded incorrectly")
                ControlOf(Of Label)(display, "lblTotal").Text = "1.67"
                If ControlOf(Of Label)(display, "lblTotal").Text <> "RM 1.67" Then Throw New Exception("Historical saved total must not be changed by formatting")
                ControlOf(Of Label)(display, "lblTotal").Text = MoneyMath.FormatPayableTotal(1091.67)
                If ControlOf(Of Label)(display, "lblTotal").Right > display.ClientSize.Width Then Throw New Exception("Total clipped")
                If args.Length > 0 Then
                    Using bitmap As New Bitmap(display.Width, display.Height)
                        display.DrawToBitmap(bitmap, New Rectangle(Point.Empty, display.Size))
                        bitmap.Save(args(0), Imaging.ImageFormat.Png)
                    End Using
                End If
            End Using
            CultureInfo.CurrentCulture = originalCulture
            Console.WriteLine("PASS|PayableRounding|Checks=" & checks & "|FourModes|BothDiscountModes|Split|Change|Display|NoSalesWritten")
        Catch ex As Exception
            Console.Error.WriteLine(ex.ToString())
            Environment.ExitCode = 1
        End Try
    End Sub

    Private Function ControlOf(Of T As Control)(form As Object, name As String) As T
        Dim flags = BindingFlags.Instance Or BindingFlags.Public Or BindingFlags.NonPublic
        Dim controlType = form.GetType()
        While controlType IsNot Nothing
            Dim prop = controlType.GetProperty(name, flags)
            If prop IsNot Nothing Then Return DirectCast(prop.GetValue(form, Nothing), T)
            Dim field = controlType.GetField(name, flags)
            If field IsNot Nothing Then Return DirectCast(field.GetValue(form), T)
            controlType = controlType.BaseType
        End While
        Throw New Exception("Control not found: " & form.GetType().Name & "." & name)
    End Function

    Private Sub AddLine(grid As DataGridView, dineIn As Boolean, amount As Decimal)
        Dim values(grid.Columns.Count - 1) As Object
        For i = 0 To values.Length - 1
            values(i) = 0D
        Next
        values(0) = If(dineIn, "TABLE 1", "TEST ITEM")
        If dineIn Then values(1) = "TEST ITEM"
        values(If(dineIn, 2, 1)) = amount
        values(If(dineIn, 3, 2)) = 1D
        values(If(dineIn, 4, 3)) = amount
        values(If(dineIn, 13, 12)) = amount
        grid.Rows.Add(values)
    End Sub

    Private Sub Equal(actual As Decimal, expected As Decimal, name As String)
        If actual <> expected Then Throw New Exception(name & ": expected " & expected & ", got " & actual)
        checks += 1
    End Sub
End Module
