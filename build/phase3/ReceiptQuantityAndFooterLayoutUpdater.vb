Option Explicit On
Option Strict On

Imports System
Imports System.Collections.Generic
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportAppServer.ClientDoc
Imports CrystalDecisions.ReportAppServer.Controllers
Imports CrystalDecisions.ReportAppServer.DataDefModel
Imports CrystalDecisions.ReportAppServer.ReportDefModel
Imports CrystalDecisions.Shared
Imports EngineReportDocument = CrystalDecisions.CrystalReports.Engine.ReportDocument
Imports RasSection = CrystalDecisions.ReportAppServer.ReportDefModel.Section

Module ReceiptQuantityAndFooterLayoutUpdater
    Private ReadOnly CustomerReceiptReports As String() = {
        "RestaurantPOS14.rptRestaurantPOSFinalBillKOTInvoice.rpt",
        "RestaurantPOS14.rptRestaurantPOSTAInvoice.rpt",
        "RestaurantPOS14.rptRestaurantPOSHDInvoice.rpt",
        "RestaurantPOS14.rptRestaurantPOSEBInvoice.rpt"
    }

    Public Sub Main(args As String())
        If args.Length <> 2 Then
            Console.Error.WriteLine("Usage: ReceiptQuantityAndFooterLayoutUpdater <source-report-directory> <output-directory>")
            Environment.ExitCode = 2
            Return
        End If

        Dim sourceDirectory = Path.GetFullPath(args(0))
        Dim outputDirectory = Path.GetFullPath(args(1))
        Directory.CreateDirectory(outputDirectory)

        For Each reportName In CustomerReceiptReports
            UpdateReport(
                Path.Combine(sourceDirectory, reportName),
                Path.Combine(outputDirectory, reportName))
        Next
    End Sub

    Private Sub UpdateReport(sourcePath As String, outputPath As String)
        If Not File.Exists(sourcePath) Then Throw New FileNotFoundException("Receipt report was not found.", sourcePath)
        If File.Exists(outputPath) Then File.Delete(outputPath)

        Using report As New EngineReportDocument()
            report.Load(sourcePath, OpenReportMethod.OpenReportByTempCopy)

            Dim clientDocument As ISCDReportClientDocument = report.ReportClientDocument
            Dim reportController As ReportDefController2 = clientDocument.ReportDefController

            FormatItemQuantityAsWholeNumber(clientDocument)

            Dim itemAmount As ISCRFieldObject = Nothing
            Dim itemQuantity As ISCRFieldObject = Nothing
            Dim quantityTotal As ISCRFieldObject = Nothing
            Dim quantityLabel As ISCRTextObject = Nothing
            Dim subtotalLabel As ISCRTextObject = Nothing
            Dim subtotalAmount As ISCRFieldObject = Nothing
            Dim sstLabel As ISCRTextObject = Nothing
            Dim sstPercentage As ISCRFieldObject = Nothing
            Dim sstAmount As ISCRFieldObject = Nothing

            FindReceiptObjects(
                reportController,
                itemAmount,
                itemQuantity,
                quantityTotal,
                quantityLabel,
                subtotalLabel,
                subtotalAmount,
                sstLabel,
                sstPercentage,
                sstAmount)

            If itemAmount Is Nothing OrElse itemQuantity Is Nothing OrElse
               quantityTotal Is Nothing OrElse quantityLabel Is Nothing OrElse
               subtotalLabel Is Nothing OrElse subtotalAmount Is Nothing OrElse
               sstLabel Is Nothing OrElse sstPercentage Is Nothing OrElse sstAmount Is Nothing Then
                Throw New InvalidOperationException("Required quantity or footer objects are missing from " & Path.GetFileName(sourcePath) & ".")
            End If

            AlignQuantityTotal(reportController, itemQuantity, quantityTotal, quantityLabel)

            Dim amountRight = itemAmount.Left + itemAmount.Width
            Dim firstLabelTop = Math.Min(subtotalLabel.Top, sstLabel.Top)
            Dim secondLabelTop = Math.Max(subtotalLabel.Top, sstLabel.Top)
            Dim firstAmountTop = Math.Min(subtotalAmount.Top, sstAmount.Top)
            Dim secondAmountTop = Math.Max(subtotalAmount.Top, sstAmount.Top)

            Dim movedSubtotalLabel = DirectCast(subtotalLabel.Clone(True), ISCRTextObject)
            movedSubtotalLabel.Top = firstLabelTop
            reportController.ReportObjectController.Modify(subtotalLabel, movedSubtotalLabel)

            Dim movedSubtotalAmount = DirectCast(subtotalAmount.Clone(True), ISCRFieldObject)
            movedSubtotalAmount.Top = firstAmountTop
            movedSubtotalAmount.Left = amountRight - movedSubtotalAmount.Width
            reportController.ReportObjectController.Modify(subtotalAmount, movedSubtotalAmount)

            Dim movedSstLabel = DirectCast(sstLabel.Clone(True), ISCRTextObject)
            movedSstLabel.Top = secondLabelTop
            reportController.ReportObjectController.Modify(sstLabel, movedSstLabel)

            Dim movedSstPercentage = DirectCast(sstPercentage.Clone(True), ISCRFieldObject)
            movedSstPercentage.Top = secondAmountTop
            movedSstPercentage.Width = Math.Min(
                sstAmount.Left - movedSstPercentage.Left,
                Math.Max(movedSstPercentage.Width, 900))
            reportController.ReportObjectController.Modify(sstPercentage, movedSstPercentage)

            Dim movedSstAmount = DirectCast(sstAmount.Clone(True), ISCRFieldObject)
            movedSstAmount.Top = secondAmountTop
            movedSstAmount.Left = amountRight - movedSstAmount.Width
            reportController.ReportObjectController.Modify(sstAmount, movedSstAmount)

            report.SaveAs(outputPath)
            Console.WriteLine(
                "UPDATED|" & Path.GetFileName(sourcePath) &
                "|AmountRight=" & amountRight.ToString() &
                "|SSTTop=" & secondLabelTop.ToString() &
                "|SubtotalTop=" & firstLabelTop.ToString() &
                "|QuantityColumnLeft=" & itemQuantity.Left.ToString())
        End Using
    End Sub

    Private Sub FormatItemQuantityAsWholeNumber(clientDocument As ISCDReportClientDocument)
        Dim originalFormula As FormulaField = Nothing
        For Each formula As FormulaField In clientDocument.DataDefinition.FormulaFields
            If String.Equals(formula.Name, "QtyX", StringComparison.OrdinalIgnoreCase) Then
                originalFormula = formula
                Exit For
            End If
        Next

        If originalFormula Is Nothing Then Throw New InvalidOperationException("Formula QtyX was not found.")

        Dim modifiedFormula = DirectCast(originalFormula.Clone(True), FormulaField)
        modifiedFormula.Text = "ToText({Restaurant_OrderedProduct.Quantity}, 0)"

        Dim validationError = clientDocument.DataDefController.FormulaFieldController.Check(modifiedFormula)
        If Not String.IsNullOrWhiteSpace(validationError) Then
            Throw New InvalidOperationException("Invalid QtyX formula: " & validationError)
        End If

        clientDocument.DataDefController.FormulaFieldController.Modify(originalFormula, modifiedFormula)
    End Sub

    Private Sub AlignQuantityTotal(
        reportController As ReportDefController2,
        itemQuantity As ISCRFieldObject,
        quantityTotal As ISCRFieldObject,
        quantityLabel As ISCRTextObject)

        Dim modifiedQuantityTotal = DirectCast(quantityTotal.Clone(True), ISCRFieldObject)
        ' Use the same centered column for detail and total quantities, including
        ' multi-digit totals. Leave the footer label outside the numeric column.
        modifiedQuantityTotal.Left = itemQuantity.Left
        modifiedQuantityTotal.Width = itemQuantity.Width
        Dim objectFormat = modifiedQuantityTotal.Format
        objectFormat.HorizontalAlignment = itemQuantity.Format.HorizontalAlignment
        modifiedQuantityTotal.Format = objectFormat
        Dim fieldFormat = modifiedQuantityTotal.FieldFormat
        Dim numericFormat = fieldFormat.NumericFormat
        numericFormat.NDecimalPlaces = 0
        fieldFormat.NumericFormat = numericFormat

        Dim commonFormat = fieldFormat.CommonFormat
        commonFormat.EnableSystemDefault = False
        fieldFormat.CommonFormat = commonFormat
        modifiedQuantityTotal.FieldFormat = fieldFormat

        reportController.ReportObjectController.Modify(quantityTotal, modifiedQuantityTotal)

        Dim movedQuantityLabel = DirectCast(quantityLabel.Clone(True), ISCRTextObject)
        movedQuantityLabel.Left = itemQuantity.Left - 30 - movedQuantityLabel.Width
        reportController.ReportObjectController.Modify(quantityLabel, movedQuantityLabel)
    End Sub

    Private Sub FindReceiptObjects(
        reportController As ReportDefController2,
        ByRef itemAmount As ISCRFieldObject,
        ByRef itemQuantity As ISCRFieldObject,
        ByRef quantityTotal As ISCRFieldObject,
        ByRef quantityLabel As ISCRTextObject,
        ByRef subtotalLabel As ISCRTextObject,
        ByRef subtotalAmount As ISCRFieldObject,
        ByRef sstLabel As ISCRTextObject,
        ByRef sstPercentage As ISCRFieldObject,
        ByRef sstAmount As ISCRFieldObject)

        For Each area As ISCRArea In reportController.ReportDefinition.Areas
            For Each section As RasSection In area.Sections
                Dim sectionSubtotalLabel As ISCRTextObject = Nothing
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
                        If textObject.Text.IndexOf("Sub Total", StringComparison.OrdinalIgnoreCase) >= 0 Then sectionSubtotalLabel = textObject
                        If String.Equals(textObject.Name, "SstReceiptLabelObject", StringComparison.OrdinalIgnoreCase) Then sstLabel = textObject
                    End If
                Next

                If sectionSubtotalLabel IsNot Nothing Then
                    subtotalLabel = sectionSubtotalLabel
                    Dim nearestDistance = Integer.MaxValue
                    For Each fieldObject In sectionFields
                        If String.Equals(fieldObject.Name, "SstReceiptPercentageObject", StringComparison.OrdinalIgnoreCase) OrElse
                           String.Equals(fieldObject.Name, "SstReceiptAmountObject", StringComparison.OrdinalIgnoreCase) Then
                            Continue For
                        End If

                        Dim distance = Math.Abs(fieldObject.Top - sectionSubtotalLabel.Top)
                        If distance < nearestDistance Then
                            nearestDistance = distance
                            subtotalAmount = fieldObject
                        End If
                    Next
                End If
            Next
        Next
    End Sub
End Module
