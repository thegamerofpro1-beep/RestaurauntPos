Option Explicit On
Option Strict On

Imports System
Imports System.Collections.Generic
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportAppServer.ClientDoc
Imports CrystalDecisions.ReportAppServer.DataDefModel
Imports CrystalDecisions.ReportAppServer.ReportDefModel
Imports CrystalDecisions.Shared
Imports EngineReportDocument = CrystalDecisions.CrystalReports.Engine.ReportDocument
Imports RasSection = CrystalDecisions.ReportAppServer.ReportDefModel.Section

Module ReceiptQuantityAndFooterLayoutVerification
    Private ReadOnly CustomerReceiptReports As String() = {
        "RestaurantPOS14.rptRestaurantPOSFinalBillKOTInvoice.rpt",
        "RestaurantPOS14.rptRestaurantPOSTAInvoice.rpt",
        "RestaurantPOS14.rptRestaurantPOSHDInvoice.rpt",
        "RestaurantPOS14.rptRestaurantPOSEBInvoice.rpt"
    }

    Public Sub Main(args As String())
        If args.Length <> 1 Then
            Console.Error.WriteLine("Usage: ReceiptQuantityAndFooterLayoutVerification <report-directory>")
            Environment.ExitCode = 2
            Return
        End If

        For Each reportName In CustomerReceiptReports
            VerifyReport(Path.Combine(Path.GetFullPath(args(0)), reportName))
        Next
    End Sub

    Private Sub VerifyReport(reportPath As String)
        Using report As New EngineReportDocument()
            report.Load(reportPath, OpenReportMethod.OpenReportByTempCopy)
            Dim clientDocument As ISCDReportClientDocument = report.ReportClientDocument

            Dim qtyFormula = FindFormula(clientDocument, "QtyX")
            If qtyFormula Is Nothing OrElse
               qtyFormula.Text.IndexOf("ToText({Restaurant_OrderedProduct.Quantity}, 0)", StringComparison.OrdinalIgnoreCase) < 0 OrElse
               qtyFormula.Text.IndexOf("then", StringComparison.OrdinalIgnoreCase) >= 0 Then
                Throw New InvalidOperationException("QtyX is not formatted as a whole number in " & Path.GetFileName(reportPath) & ".")
            End If

            Dim itemAmount As ISCRFieldObject = Nothing
            Dim itemQuantity As ISCRFieldObject = Nothing
            Dim quantityTotal As ISCRFieldObject = Nothing
            Dim quantityLabel As ISCRTextObject = Nothing
            Dim subtotalLabel As ISCRTextObject = Nothing
            Dim subtotalAmount As ISCRFieldObject = Nothing
            Dim sstLabel As ISCRTextObject = Nothing
            Dim sstPercentage As ISCRFieldObject = Nothing
            Dim sstAmount As ISCRFieldObject = Nothing

            For Each area As ISCRArea In clientDocument.ReportDefinition.Areas
                For Each section As RasSection In area.Sections
                    Dim sectionSubtotal As ISCRTextObject = Nothing
                    Dim sectionFields As New List(Of ISCRFieldObject)()

                    For Each reportObject As ISCRReportObject In section.ReportObjects
                        Dim fieldObject = TryCast(reportObject, ISCRFieldObject)
                        If fieldObject IsNot Nothing Then
                            sectionFields.Add(fieldObject)
                            If String.Equals(fieldObject.Name, "AmountX1", StringComparison.OrdinalIgnoreCase) Then itemAmount = fieldObject
                            If String.Equals(fieldObject.Name, "QtyX1", StringComparison.OrdinalIgnoreCase) Then itemQuantity = fieldObject
                            If String.Equals(fieldObject.Name, "RTotal51", StringComparison.OrdinalIgnoreCase) Then quantityTotal = fieldObject
                            If String.Equals(fieldObject.Name, "SstReceiptPercentageObject", StringComparison.OrdinalIgnoreCase) Then sstPercentage = fieldObject
                            If String.Equals(fieldObject.Name, "SstReceiptAmountObject", StringComparison.OrdinalIgnoreCase) Then sstAmount = fieldObject
                        End If

                        Dim textObject = TryCast(reportObject, ISCRTextObject)
                        If textObject IsNot Nothing Then
                            If String.Equals(textObject.Text.Trim(), "Qty. :", StringComparison.OrdinalIgnoreCase) Then quantityLabel = textObject
                            If textObject.Text.IndexOf("Sub Total", StringComparison.OrdinalIgnoreCase) >= 0 Then sectionSubtotal = textObject
                            If String.Equals(textObject.Name, "SstReceiptLabelObject", StringComparison.OrdinalIgnoreCase) Then sstLabel = textObject
                        End If
                    Next

                    If sectionSubtotal IsNot Nothing Then
                        subtotalLabel = sectionSubtotal
                        Dim nearestDistance = Integer.MaxValue
                        For Each fieldObject In sectionFields
                            If fieldObject.Name.StartsWith("SstReceipt", StringComparison.OrdinalIgnoreCase) Then Continue For
                            Dim distance = Math.Abs(fieldObject.Top - sectionSubtotal.Top)
                            If distance < nearestDistance Then
                                nearestDistance = distance
                                subtotalAmount = fieldObject
                            End If
                        Next
                    End If
                Next
            Next

            If itemAmount Is Nothing OrElse itemQuantity Is Nothing OrElse quantityLabel Is Nothing OrElse
               quantityTotal Is Nothing OrElse subtotalLabel Is Nothing OrElse
               subtotalAmount Is Nothing OrElse sstLabel Is Nothing OrElse sstAmount Is Nothing Then
                Throw New InvalidOperationException("Required verification objects are missing from " & Path.GetFileName(reportPath) & ".")
            End If

            If quantityTotal.FieldFormat.NumericFormat.NDecimalPlaces <> 0 Then
                Throw New InvalidOperationException("Quantity total still has decimal places in " & Path.GetFileName(reportPath) & ".")
            End If
            If quantityTotal.Left <> itemQuantity.Left OrElse quantityTotal.Width <> itemQuantity.Width OrElse
               quantityTotal.Format.HorizontalAlignment <> itemQuantity.Format.HorizontalAlignment Then
                Throw New InvalidOperationException("Total quantity is not aligned with the item quantity column in " & Path.GetFileName(reportPath) & ".")
            End If
            If quantityLabel.Left + quantityLabel.Width >= quantityTotal.Left Then
                Throw New InvalidOperationException("Quantity label overlaps the total quantity column in " & Path.GetFileName(reportPath) & ".")
            End If
            If subtotalLabel.Top >= sstLabel.Top OrElse subtotalAmount.Top >= sstAmount.Top Then
                Throw New InvalidOperationException("Sub Total is not above SST in " & Path.GetFileName(reportPath) & ".")
            End If
            If subtotalLabel.Top + subtotalLabel.Height > sstLabel.Top Then
                Throw New InvalidOperationException("Sub Total overlaps SST in " & Path.GetFileName(reportPath) & ".")
            End If
            If sstPercentage Is Nothing OrElse sstPercentage.Width < 720 OrElse
               sstPercentage.Left + sstPercentage.Width > sstAmount.Left Then
                Throw New InvalidOperationException("SST percentage is clipped or overlaps its amount in " & Path.GetFileName(reportPath) & ".")
            End If

            Dim amountRight = itemAmount.Left + itemAmount.Width
            Dim subtotalRight = subtotalAmount.Left + subtotalAmount.Width
            Dim sstRight = sstAmount.Left + sstAmount.Width
            If subtotalRight <> amountRight OrElse sstRight <> amountRight Then
                Throw New InvalidOperationException("Footer amounts are not aligned with the Amount column in " & Path.GetFileName(reportPath) & ".")
            End If

            Console.WriteLine(
                "VERIFIED|" & Path.GetFileName(reportPath) &
                "|QtyDecimals=0" &
                "|QuantityColumnAligned=True" &
                "|SubtotalTop=" & subtotalLabel.Top.ToString() &
                "|SSTTop=" & sstLabel.Top.ToString() &
                "|AmountRight=" & amountRight.ToString())
        End Using
    End Sub

    Private Function FindFormula(clientDocument As ISCDReportClientDocument, formulaName As String) As FormulaField
        For Each formula As FormulaField In clientDocument.DataDefinition.FormulaFields
            If String.Equals(formula.Name, formulaName, StringComparison.OrdinalIgnoreCase) Then Return formula
        Next
        Return Nothing
    End Function
End Module
