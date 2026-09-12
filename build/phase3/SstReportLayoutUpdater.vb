Option Explicit On
Option Strict On

Imports System
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportAppServer.ClientDoc
Imports CrystalDecisions.ReportAppServer.Controllers
Imports CrystalDecisions.ReportAppServer.DataDefModel
Imports CrystalDecisions.ReportAppServer.ReportDefModel
Imports CrystalDecisions.Shared
Imports EngineReportDocument = CrystalDecisions.CrystalReports.Engine.ReportDocument
Imports RasSection = CrystalDecisions.ReportAppServer.ReportDefModel.Section

Module SstReportLayoutUpdater
    Private Const SstLabelFormulaName As String = "SstReceiptPercentage"
    Private Const SstAmountFormulaName As String = "SstReceiptAmount"
    Private Const SstLabelObjectName As String = "SstReceiptLabelObject"
    Private Const SstPercentageObjectName As String = "SstReceiptPercentageObject"
    Private Const SstAmountObjectName As String = "SstReceiptAmountObject"
    Private Const RowHeight As Integer = 221

    Private ReadOnly CustomerReceiptReports As String() = {
        "RestaurantPOS14.rptRestaurantPOSFinalBillKOTInvoice.rpt",
        "RestaurantPOS14.rptRestaurantPOSTAInvoice.rpt",
        "RestaurantPOS14.rptRestaurantPOSHDInvoice.rpt",
        "RestaurantPOS14.rptRestaurantPOSEBInvoice.rpt"
    }

    Public Sub Main(args As String())
        If args.Length <> 2 Then
            Console.Error.WriteLine("Usage: SstReportLayoutUpdater <source-report-directory> <output-directory>")
            Environment.ExitCode = 2
            Return
        End If

        Dim sourceDirectory = Path.GetFullPath(args(0))
        Dim outputDirectory = Path.GetFullPath(args(1))
        Directory.CreateDirectory(outputDirectory)

        For Each reportName In CustomerReceiptReports
            Dim sourcePath = Path.Combine(sourceDirectory, reportName)
            Dim outputPath = Path.Combine(outputDirectory, reportName)
            UpdateReport(sourcePath, outputPath)
        Next
    End Sub

    Private Sub UpdateReport(sourcePath As String, outputPath As String)
        If Not File.Exists(sourcePath) Then
            Throw New FileNotFoundException("Receipt report was not found.", sourcePath)
        End If

        If File.Exists(outputPath) Then File.Delete(outputPath)

        Using report As New EngineReportDocument()
            report.Load(sourcePath, OpenReportMethod.OpenReportByTempCopy)

            Dim clientDocument As ISCDReportClientDocument = report.ReportClientDocument
            Dim reportController As ReportDefController2 = clientDocument.ReportDefController
            For Each runningTotal As ISCRRunningTotalField In clientDocument.DataDefinition.RunningTotalFields
                Console.WriteLine(
                    "RUNNINGTOTAL|" & Path.GetFileName(sourcePath) &
                    "|" & runningTotal.Name &
                    "|Field=" & runningTotal.SummarizedField.FormulaForm &
                    "|Operation=" & runningTotal.Operation.ToString() &
                    "|Evaluate=" & runningTotal.EvaluateConditionType.ToString() &
                    "|EvaluateCondition=" & If(runningTotal.EvaluateCondition Is Nothing, "", runningTotal.EvaluateCondition.ToString()) &
                    "|Reset=" & runningTotal.ResetConditionType.ToString())
            Next
            Dim subtotalSection As RasSection = Nothing
            Dim subtotalLabel As ISCRTextObject = Nothing
            Dim subtotalValue As ISCRFieldObject = Nothing

            FindSubtotalRow(reportController, subtotalSection, subtotalLabel, subtotalValue)
            If subtotalSection Is Nothing OrElse subtotalLabel Is Nothing OrElse subtotalValue Is Nothing Then
                Throw New InvalidOperationException("Could not locate the Sub Total row in " & Path.GetFileName(sourcePath) & ".")
            End If

            Dim percentageFormula = AddFormula(
                clientDocument,
                SstLabelFormulaName,
                """("" & ToText(Maximum ({Restaurant_OrderedProduct.STPer}), 2, """") & ""%) :""",
                CrFieldValueTypeEnum.crFieldValueTypeStringField)
            Dim amountFormula = AddFormula(
                clientDocument,
                SstAmountFormulaName,
                "{#RTotal1}",
                CrFieldValueTypeEnum.crFieldValueTypeNumberField)

            Try
                Dim originalLabelTop = subtotalLabel.Top
                Dim originalValueTop = subtotalValue.Top

                Dim movedSubtotalLabel = DirectCast(subtotalLabel.Clone(True), ISCRTextObject)
                movedSubtotalLabel.Top = originalLabelTop + RowHeight
                reportController.ReportObjectController.Modify(subtotalLabel, movedSubtotalLabel)

                Dim movedSubtotalValue = DirectCast(subtotalValue.Clone(True), ISCRFieldObject)
                movedSubtotalValue.Top = originalValueTop + RowHeight
                reportController.ReportObjectController.Modify(subtotalValue, movedSubtotalValue)

                reportController.ReportSectionController.SetProperty(
                    subtotalSection,
                    CrReportSectionPropertyEnum.crReportSectionPropertyHeight,
                    subtotalSection.Height + RowHeight)

                Dim sstLabel = DirectCast(subtotalLabel.Clone(True), ISCRTextObject)
                sstLabel.Name = SstLabelObjectName
                sstLabel.Top = originalLabelTop
                sstLabel.Width = 600
                sstLabel.Paragraphs = CreateParagraphs("SST")
                reportController.ReportObjectController.Add(sstLabel, subtotalSection, -1)

                Dim sstPercentage = DirectCast(subtotalValue.Clone(True), ISCRFieldObject)
                sstPercentage.Name = SstPercentageObjectName
                sstPercentage.DataSourceName = percentageFormula.FormulaForm
                sstPercentage.FieldValueType = percentageFormula.Type
                sstPercentage.Left = subtotalLabel.Left + 600
                sstPercentage.Top = originalValueTop
                sstPercentage.Width = Math.Max(400, subtotalValue.Left - sstPercentage.Left)
                reportController.ReportObjectController.Add(sstPercentage, subtotalSection, -1)

                Dim sstAmount = DirectCast(subtotalValue.Clone(True), ISCRFieldObject)
                sstAmount.Name = SstAmountObjectName
                sstAmount.DataSourceName = amountFormula.FormulaForm
                sstAmount.FieldValueType = amountFormula.Type
                sstAmount.Top = originalValueTop
                reportController.ReportObjectController.Add(sstAmount, subtotalSection, -1)

            Catch
                Throw
            End Try

            report.SaveAs(outputPath)
            Console.WriteLine("UPDATED|" & Path.GetFileName(sourcePath) & "|" & subtotalSection.Name)
        End Using
    End Sub

    Private Sub FindSubtotalRow(
        reportController As ReportDefController2,
        ByRef subtotalSection As RasSection,
        ByRef subtotalLabel As ISCRTextObject,
        ByRef subtotalValue As ISCRFieldObject)

        For Each section As RasSection In reportController.ReportDefinition.ReportFooterArea.Sections
            Dim foundLabel As ISCRTextObject = Nothing

            For Each reportObject As ISCRReportObject In section.ReportObjects
                Dim textObject = TryCast(reportObject, ISCRTextObject)
                If textObject IsNot Nothing AndAlso
                   textObject.Text.IndexOf("Sub Total", StringComparison.OrdinalIgnoreCase) >= 0 Then
                    foundLabel = textObject
                    Exit For
                End If
            Next

            If foundLabel Is Nothing Then Continue For

            Dim nearestField As ISCRFieldObject = Nothing
            Dim nearestDistance = Integer.MaxValue
            For Each reportObject As ISCRReportObject In section.ReportObjects
                Dim fieldObject = TryCast(reportObject, ISCRFieldObject)
                If fieldObject Is Nothing Then Continue For

                Dim distance = Math.Abs(fieldObject.Top - foundLabel.Top)
                If distance < nearestDistance Then
                    nearestDistance = distance
                    nearestField = fieldObject
                End If
            Next

            subtotalSection = section
            subtotalLabel = foundLabel
            subtotalValue = nearestField
            Return
        Next
    End Sub

    Private Function AddFormula(
        clientDocument As ISCDReportClientDocument,
        formulaName As String,
        formulaText As String,
        formulaType As CrFieldValueTypeEnum) As FormulaField

        Dim formula As FormulaField = New FormulaFieldClass()
        formula.Name = formulaName
        formula.Text = formulaText
        formula.Syntax = CrFormulaSyntaxEnum.crFormulaSyntaxCrystal
        formula.Type = formulaType

        Dim validationError = clientDocument.DataDefController.FormulaFieldController.Check(formula)
        If Not String.IsNullOrWhiteSpace(validationError) Then
            Throw New InvalidOperationException("Invalid formula " & formulaName & ": " & validationError)
        End If

        clientDocument.DataDefController.FormulaFieldController.Add(formula)
        Return formula
    End Function

    Private Function CreateParagraphs(value As String) As Paragraphs
        Dim element As ISCRParagraphTextElement = New ParagraphTextElementClass()
        element.Text = value
        element.Kind = CrParagraphElementKindEnum.crParagraphElementKindText

        Dim elements As ParagraphElements = New ParagraphElementsClass()
        elements.Add(element)

        Dim paragraph As Paragraph = New ParagraphClass()
        paragraph.ParagraphElements = elements

        Dim paragraphs As Paragraphs = New ParagraphsClass()
        paragraphs.Add(paragraph)
        Return paragraphs
    End Function
End Module
