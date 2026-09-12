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

Module ReceiptCurrencyLayoutUpdater
    Private Const SstFontSize As Decimal = 8D
    Private Const SstObjectHeight As Integer = 180

    Private ReadOnly CustomerReceiptReports As String() = {
        "RestaurantPOS14.rptRestaurantPOSFinalBillKOTInvoice.rpt",
        "RestaurantPOS14.rptRestaurantPOSTAInvoice.rpt",
        "RestaurantPOS14.rptRestaurantPOSHDInvoice.rpt",
        "RestaurantPOS14.rptRestaurantPOSEBInvoice.rpt"
    }

    Private ReadOnly CurrencyObjectNames As New HashSet(Of String)(StringComparer.OrdinalIgnoreCase) From {
        "Fx1",
        "SstReceiptAmountObject",
        "RTotal31",
        "LA1",
        "LA2",
        "GiftCardAmount1",
        "RTotal21",
        "RTotal61",
        "Tip1",
        "GrandTotal1",
        "Cash1",
        "Card1",
        "Change1",
        "ParcelCharges1",
        "HomeDeliveryCharges1"
    }

    Public Sub Main(args As String())
        If args.Length <> 2 Then
            Console.Error.WriteLine("Usage: ReceiptCurrencyLayoutUpdater <source-report-directory> <output-directory>")
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

            PrefixItemFormula(clientDocument, "RateX")
            PrefixItemFormula(clientDocument, "AmountX")

            Dim currencyFieldsUpdated = 0
            Dim sstObjectsUpdated = 0
            For Each area As ISCRArea In reportController.ReportDefinition.Areas
                For Each section As RasSection In area.Sections
                    Dim sectionObjects As New List(Of ISCRReportObject)()
                    For Each reportObject As ISCRReportObject In section.ReportObjects
                        sectionObjects.Add(reportObject)
                    Next

                    For Each reportObject In sectionObjects
                        Dim fieldObject = TryCast(reportObject, ISCRFieldObject)
                        If fieldObject IsNot Nothing AndAlso CurrencyObjectNames.Contains(fieldObject.Name) Then
                            Dim modifiedField = DirectCast(fieldObject.Clone(True), ISCRFieldObject)
                            ApplyRinggitFormat(modifiedField)
                            If IsSstObject(fieldObject.Name) Then
                                ApplyFontSize(modifiedField.FontColor, SstFontSize)
                                modifiedField.Height = SstObjectHeight
                                sstObjectsUpdated += 1
                            End If
                            reportController.ReportObjectController.Modify(fieldObject, modifiedField)
                            currencyFieldsUpdated += 1
                            Continue For
                        End If

                        If String.Equals(reportObject.Name, "SstReceiptPercentageObject", StringComparison.OrdinalIgnoreCase) Then
                            Dim modifiedPercentage = DirectCast(reportObject.Clone(True), ISCRFieldObject)
                            ApplyFontSize(modifiedPercentage.FontColor, SstFontSize)
                            modifiedPercentage.Height = SstObjectHeight
                            reportController.ReportObjectController.Modify(reportObject, modifiedPercentage)
                            sstObjectsUpdated += 1
                            Continue For
                        End If

                        If String.Equals(reportObject.Name, "SstReceiptLabelObject", StringComparison.OrdinalIgnoreCase) Then
                            Dim textObject = DirectCast(reportObject, ISCRTextObject)
                            Dim modifiedLabel = DirectCast(textObject.Clone(True), ISCRTextObject)
                            ApplyFontSize(modifiedLabel.FontColor, SstFontSize)
                            ApplyParagraphFontSize(modifiedLabel, SstFontSize)
                            modifiedLabel.Height = SstObjectHeight
                            reportController.ReportObjectController.Modify(textObject, modifiedLabel)
                            sstObjectsUpdated += 1
                        End If
                    Next
                Next
            Next

            If currencyFieldsUpdated < 8 Then
                Throw New InvalidOperationException("Too few currency fields were updated in " & Path.GetFileName(sourcePath) & ".")
            End If
            If sstObjectsUpdated <> 3 Then
                Throw New InvalidOperationException("Expected three SST row objects in " & Path.GetFileName(sourcePath) & ".")
            End If

            report.SaveAs(outputPath)
            Console.WriteLine(
                "UPDATED|" & Path.GetFileName(sourcePath) &
                "|CurrencyFields=" & currencyFieldsUpdated.ToString() &
                "|SSTObjects=" & sstObjectsUpdated.ToString())
        End Using
    End Sub

    Private Sub PrefixItemFormula(clientDocument As ISCDReportClientDocument, formulaName As String)
        Dim originalFormula As FormulaField = Nothing
        For Each formula As FormulaField In clientDocument.DataDefinition.FormulaFields
            If String.Equals(formula.Name, formulaName, StringComparison.OrdinalIgnoreCase) Then
                originalFormula = formula
                Exit For
            End If
        Next

        If originalFormula Is Nothing Then
            Throw New InvalidOperationException("Formula " & formulaName & " was not found.")
        End If
        If originalFormula.Text.IndexOf("RM ", StringComparison.OrdinalIgnoreCase) >= 0 Then Return

        Dim modifiedFormula = DirectCast(originalFormula.Clone(True), FormulaField)
        modifiedFormula.Text = """RM "" & (" & originalFormula.Text & ")"

        Dim validationError = clientDocument.DataDefController.FormulaFieldController.Check(modifiedFormula)
        If Not String.IsNullOrWhiteSpace(validationError) Then
            Throw New InvalidOperationException("Invalid " & formulaName & " formula: " & validationError)
        End If

        clientDocument.DataDefController.FormulaFieldController.Modify(originalFormula, modifiedFormula)
    End Sub

    Private Sub ApplyRinggitFormat(fieldObject As ISCRFieldObject)
        Dim fieldFormat = fieldObject.FieldFormat
        Dim numericFormat = fieldFormat.NumericFormat
        numericFormat.CurrencySymbol = "RM "
        numericFormat.CurrencySymbolFormat = CrCurrencySymbolTypeEnum.crCurrencySymbolTypeFloatingSymbol
        numericFormat.CurrencyPosition = CrCurrencyPositionFormatEnum.crCurrencyPositionFormatLeadingCurrencyOutsideNegative
        fieldFormat.NumericFormat = numericFormat

        Dim commonFormat = fieldFormat.CommonFormat
        commonFormat.EnableSystemDefault = False
        fieldFormat.CommonFormat = commonFormat
        fieldObject.FieldFormat = fieldFormat
    End Sub

    Private Sub ApplyParagraphFontSize(textObject As ISCRTextObject, fontSize As Decimal)
        For Each paragraph As Paragraph In textObject.Paragraphs
            For Each element As ISCRParagraphElement In paragraph.ParagraphElements
                Dim textElement = TryCast(element, ISCRParagraphTextElement)
                If textElement IsNot Nothing Then ApplyFontSize(textElement.FontColor, fontSize)
            Next
        Next
    End Sub

    Private Sub ApplyFontSize(fontColor As FontColor, fontSize As Decimal)
        Dim font = fontColor.Font
        font.Size = fontSize
        fontColor.Font = font
    End Sub

    Private Function IsSstObject(objectName As String) As Boolean
        Return String.Equals(objectName, "SstReceiptAmountObject", StringComparison.OrdinalIgnoreCase)
    End Function
End Module
