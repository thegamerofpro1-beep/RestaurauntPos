Imports System
Imports System.Windows.Forms
Imports RestaurantPOS14.Configuration

Namespace RestaurantPOS14.Billing
    Friend NotInheritable Class PayableTotal
        Private Sub New()
        End Sub

        Public Shared Sub Apply(totalControl As TextBox, value As Double, customerDisplayEnabled As Boolean)
            ' The same value drives payment validation, change, persisted invoices
            ' and receipt GrandTotal fields. Do not round again while printing.
            totalControl.Text = MoneyMath.FormatPayableTotal(value)
            If customerDisplayEnabled Then
                RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.lblTotal.Text = totalControl.Text
            End If
        End Sub
    End Class
End Namespace
