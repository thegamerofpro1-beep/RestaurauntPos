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

Module ServiceChargeReceiptLayoutUpdater
    Private Const PercentageFormulaName As String = "ServiceChargeReceiptPercentage"
    Private Const PercentageObjectName As String = "ServiceChargeReceiptPercentageObject"

    Private ReadOnly CustomerReceiptReports As String() = {
        "RestaurantPOS14.rptRestaurantPOSFinalBillKOTInvoice.rpt",
        "RestaurantPOS14.rptRestaurantPOSTAInvoice.rpt",
        "RestaurantPOS14.rptRestaurantPOSHDInvoice.rpt",
        "RestaurantPOS14.rptRestaurantPOSEBInvoice.rpt"
    }

    Public Sub Main(args As String())
        If args.Length <> 2 Then
            Console.Error.WriteLine("Usage: ServiceChargeReceiptLayoutUpdater <source-report-directory> <output-directory>")
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
            Dim percentageFormula = UpsertPercentageFormula(clientDocument)

            Dim itemAmount As ISCRFieldObject = Nothing
            Dim serviceSection As RasSection = Nothing
            Dim serviceLabel As ISCRTextObject = Nothing
            Dim serviceAmount As ISCRFieldObject = Nothing
            Dim existingPercentage As ISCRFieldObject = Nothing

            For Each area As ISCRArea In reportController.ReportDefinition.Areas
                For Each section As RasSection In area.Sections
                    For Each reportObject As ISCRReportObject In section.ReportObjects
                        Dim fieldObject = TryCast(reportObject, ISCRFieldObject)
                        If fieldObject IsNot Nothing Then
                            If String.Equals(fieldObject.Name, "AmountX1", StringComparison.OrdinalIgnoreCase) Then itemAmount = fieldObject
                            If String.Equals(fieldObject.Name, "RTotal21", StringComparison.OrdinalIgnoreCase) Then
                                serviceSection = section
                                serviceAmount = fieldObject
                            End If
                            If String.Equals(fieldObject.Name, PercentageObjectName, StringComparison.OrdinalIgnoreCase) Then
                                existingPercentage = fieldObject
                            End If
                        End If

                        Dim textObject = TryCast(reportObject, ISCRTextObject)
                        If textObject IsNot Nothing Then
                            Dim textValue = If(textObject.Text, String.Empty)
                            If String.Equals(textObject.Name, "Text11", StringComparison.OrdinalIgnoreCase) OrElse
                               textValue.IndexOf("service charge", StringComparison.OrdinalIgnoreCase) >= 0 Then
                                serviceLabel = textObject
                            End If
                        End If
                    Next
                Next
            Next

            If itemAmount Is Nothing OrElse serviceSection Is Nothing OrElse
               serviceLabel Is Nothing OrElse serviceAmount Is Nothing Then
                Console.Error.WriteLine(
                    "MISSING|" & Path.GetFileName(sourcePath) &
                    "|ItemAmount=" & (itemAmount IsNot Nothing).ToString() &
                    "|Section=" & (serviceSection IsNot Nothing).ToString() &
                    "|Label=" & (serviceLabel IsNot Nothing).ToString() &
                    "|Amount=" & (serviceAmount IsNot Nothing).ToString())
                Throw New InvalidOperationException("Required Service Charge objects are missing from " & Path.GetFileName(sourcePath) & ".")
            End If

            Dim amountRight = itemAmount.Left + itemAmount.Width
            Dim movedAmount = DirectCast(serviceAmount.Clone(True), ISCRFieldObject)
            movedAmount.Left = amountRight - movedAmount.Width
            reportController.ReportObjectController.Modify(serviceAmount, movedAmount)

            Dim movedLabel = DirectCast(serviceLabel.Clone(True), ISCRTextObject)
            movedLabel.Width = 1680
            movedLabel.Paragraphs = CreateParagraphs("Service Charge", movedLabel.FontColor)
            movedLabel.Height = serviceAmount.Height
            reportController.ReportObjectController.Modify(serviceLabel, movedLabel)

            Dim percentageLeft = movedLabel.Left + movedLabel.Width
            Dim percentageWidth = movedAmount.Left - percentageLeft
            If percentageWidth < 360 Then
                Throw New InvalidOperationException("Insufficient room for the Service Charge percentage in " & Path.GetFileName(sourcePath) & ".")
            End If

            If existingPercentage Is Nothing Then
                Dim percentage = DirectCast(serviceAmount.Clone(True), ISCRFieldObject)
                percentage.Name = PercentageObjectName
                percentage.DataSourceName = percentageFormula.FormulaForm
                percentage.FieldValueType = percentageFormula.Type
                percentage.Left = percentageLeft
                percentage.Top = serviceAmount.Top
                percentage.Width = percentageWidth
                percentage.Height = serviceAmount.Height
                reportController.ReportObjectController.Add(percentage, serviceSection, -1)
            Else
                Dim percentage = DirectCast(existingPercentage.Clone(True), ISCRFieldObject)
                percentage.DataSourceName = percentageFormula.FormulaForm
                percentage.FieldValueType = percentageFormula.Type
                percentage.Left = percentageLeft
                percentage.Top = serviceAmount.Top
                percentage.Width = percentageWidth
                percentage.Height = serviceAmount.Height
                reportController.ReportObjectController.Modify(existingPercentage, percentage)
            End If

            report.SaveAs(outputPath)
            Console.WriteLine(
                "UPDATED|" & Path.GetFileName(sourcePath) &
                "|AmountRight=" & amountRight.ToString() &
                "|PercentLeft=" & percentageLeft.ToString() &
                "|PercentWidth=" & percentageWidth.ToString())
        End Using
    End Sub

    Private Function UpsertPercentageFormula(clientDocument As ISCDReportClientDocument) As FormulaField
        Dim existing As FormulaField = Nothing
        For Each formula As FormulaField In clientDocument.DataDefinition.FormulaFields
            If String.Equals(formula.Name, PercentageFormulaName, StringComparison.OrdinalIgnoreCase) Then
                existing = formula
                Exit For
            End If
        Next

        Dim updated As FormulaField
        If existing Is Nothing Then
            updated = New FormulaFieldClass()
            updated.Name = PercentageFormulaName
            updated.Syntax = CrFormulaSyntaxEnum.crFormulaSyntaxCrystal
            updated.Type = CrFieldValueTypeEnum.crFieldValueTypeStringField
        Else
            updated = DirectCast(existing.Clone(True), FormulaField)
        End If

        updated.Text = """("" & ToText(Maximum ({Restaurant_OrderedProduct.VATPer}), 2, """") & ""%) :"""
        Dim validationError = clientDocument.DataDefController.FormulaFieldController.Check(updated)
        If Not String.IsNullOrWhiteSpace(validationError) Then
            Throw New InvalidOperationException("Invalid Service Charge percentage formula: " & validationError)
        End If

        If existing Is Nothing Then
            clientDocument.DataDefController.FormulaFieldController.Add(updated)
        Else
            clientDocument.DataDefController.FormulaFieldController.Modify(existing, updated)
        End If
        Return updated
    End Function

    Private Function CreateParagraphs(value As String, fontColor As FontColor) As Paragraphs
        Dim element As ISCRParagraphTextElement = New ParagraphTextElementClass()
        element.Text = value
        element.Kind = CrParagraphElementKindEnum.crParagraphElementKindText
        element.FontColor = fontColor

        Dim elements As ParagraphElements = New ParagraphElementsClass()
        elements.Add(element)

        Dim paragraph As Paragraph = New ParagraphClass()
        paragraph.ParagraphElements = elements

        Dim paragraphs As Paragraphs = New ParagraphsClass()
        paragraphs.Add(paragraph)
        Return paragraphs
    End Function
End Module
