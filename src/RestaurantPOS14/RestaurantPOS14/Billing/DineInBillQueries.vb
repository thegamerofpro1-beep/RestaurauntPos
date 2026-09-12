Option Explicit On
Option Strict On

Imports System
Imports System.Data
Imports System.Data.SqlClient

Namespace RestaurantPOS14.Billing
    Friend NotInheritable Class DineInBillQueries
        Private Sub New()
        End Sub

        Public Shared Function CreateUnpaidBillItemsCommand(connection As SqlConnection, billId As Integer) As SqlCommand
            If connection Is Nothing Then Throw New ArgumentNullException(NameOf(connection))
            If billId <= 0 Then Throw New ArgumentOutOfRangeException(NameOf(billId))

            ' TableNo is a text key in the first-version database. Select the
            ' bill's tables directly instead of parsing names as integer/SQL lists.
            ' Preserve the existing grid's 18-column order and aggregation rules.
            Dim sql =
                "SELECT RTRIM(O.TableNo),RTRIM(P.Dish),P.Rate,SUM(P.Quantity),SUM(P.Amount)," &
                "P.DiscountPer,SUM(P.DiscountAmount),RTRIM(P.STPer),SUM(P.STAmount)," &
                "RTRIM(P.VATPer),SUM(P.VATAmount),P.SCPer,SUM(P.SCAmount),SUM(P.TotalAmount)," &
                "RTRIM(O.GroupName),P.DiscountPer,RTRIM(P.Category),RTRIM(P.DishNameArabic) " &
                "FROM RestaurantPOS_OrderedProductKOT P " &
                "INNER JOIN RestaurantPOS_OrderInfoKOT O ON P.TicketID=O.ID " &
                "WHERE O.TableNo IN (SELECT B.TableNo FROM RestaurantPOS_OrderedProductBillKOT B WHERE B.BillID=@BillID) " &
                "AND O.KOT_Status IN ('Open','Served','Prepared') AND P.ItemStatus <> 'Canceled' " &
                "GROUP BY O.TableNo,P.Dish,P.Rate,P.DiscountPer,P.STPer,P.VATPer,P.SCPer," &
                "O.GroupName,P.Category,P.DishNameArabic ORDER BY O.TableNo"

            Dim command As New SqlCommand(sql, connection)
            command.Parameters.Add("@BillID", SqlDbType.Int).Value = billId
            Return command
        End Function
    End Class
End Namespace
