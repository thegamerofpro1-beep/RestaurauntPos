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

Module ReceiptCurrencyLayoutVerification
    Private ReadOnly CustomerReceiptReports As String() = {
        "RestaurantPOS14.rptRestaurantPOSFinalBillKOTInvoice.rpt",
        "RestaurantPOS14.rptRestaurantPOSTAInvoice.rpt",
        "RestaurantPOS14.rptRestaurantPOSHDInvoice.rpt",
        "RestaurantPOS14.rptRestaurantPOSEBInvoice.rpt"
    }

    Private ReadOnly CurrencyObjectNames As New HashSet(Of String)(StringComparer.OrdinalIgnoreCase) From {
        "Fx1", "SstReceiptAmountObject", "RTotal31", "LA1", "LA2", "GiftCardAmount1",
        "RTotal21", "RTotal61", "Tip1", "GrandTotal1", "Cash1", "Card1", "Change1",
        "ParcelCharges1", "HomeDeliveryCharges1"
    }

    Public Sub Main(args As String())
        If args.Length <> 1 Then
            Console.Error.WriteLine("Usage: ReceiptCurrencyLayoutVerification <report-directory>")
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

            VerifyFormulaPrefix(clientDocument, "RateX")
            VerifyFormulaPrefix(clientDocument, "AmountX")

            Dim currencyCount = 0
            Dim sstCount = 0
            For Each area As ISCRArea In clientDocument.ReportDefinition.Areas
                For Each section As RasSection In area.Sections
                    For Each reportObject As ISCRReportObject In section.ReportObjects
                        Dim fieldObject = TryCast(reportObject, ISCRFieldObject)
                        If fieldObject IsNot Nothing AndAlso CurrencyObjectNames.Contains(fieldObject.Name) Then
                            Dim numericFormat = fieldObject.FieldFormat.NumericFormat
                            If Not String.Equals(numericFormat.CurrencySymbol.Trim(), "RM", StringComparison.OrdinalIgnoreCase) OrElse
                               numericFormat.CurrencySymbolFormat = CrCurrencySymbolTypeEnum.crCurrencySymbolTypeNoSymbol Then
                                Throw New InvalidOperationException("RM format is missing from " & fieldObject.Name & " in " & Path.GetFileName(reportPath) & ".")
                            End If
                            currencyCount += 1
                        End If

                        If reportObject.Name.StartsWith("SstReceipt", StringComparison.OrdinalIgnoreCase) AndAlso
                           reportObject.Name.EndsWith("Object", StringComparison.OrdinalIgnoreCase) Then
                            If reportObject.Height > 180 Then
                                Throw New InvalidOperationException("SST object is too tall in " & Path.GetFileName(reportPath) & ".")
                            End If
                            If GetFontSize(reportObject) > 8D Then
                                Throw New InvalidOperationException("SST object font is too large in " & Path.GetFileName(reportPath) & ".")
                            End If
                            sstCount += 1
                        End If
                    Next
                Next
            Next

            If currencyCount < 8 OrElse sstCount <> 3 Then
                Throw New InvalidOperationException("Receipt formatting object count is incomplete in " & Path.GetFileName(reportPath) & ".")
            End If

            Console.WriteLine(
                "VERIFIED|" & Path.GetFileName(reportPath) &
                "|CurrencyFields=" & currencyCount.ToString() &
                "|SSTObjects=" & sstCount.ToString())
        End Using
    End Sub

    Private Sub VerifyFormulaPrefix(clientDocument As ISCDReportClientDocument, formulaName As String)
        For Each formula As FormulaField In clientDocument.DataDefinition.FormulaFields
            If String.Equals(formula.Name, formulaName, StringComparison.OrdinalIgnoreCase) Then
                If formula.Text.IndexOf("RM ", StringComparison.OrdinalIgnoreCase) < 0 Then
                    Throw New InvalidOperationException("Formula " & formulaName & " does not include RM.")
                End If
                Return
            End If
        Next
        Throw New InvalidOperationException("Formula " & formulaName & " was not found.")
    End Sub

    Private Function GetFontSize(reportObject As ISCRReportObject) As Decimal
        Dim fieldObject = TryCast(reportObject, ISCRFieldObject)
        If fieldObject IsNot Nothing Then Return fieldObject.FontColor.Font.Size

        Dim textObject = TryCast(reportObject, ISCRTextObject)
        If textObject IsNot Nothing Then Return textObject.FontColor.Font.Size

        Return 0D
    End Function
End Module
