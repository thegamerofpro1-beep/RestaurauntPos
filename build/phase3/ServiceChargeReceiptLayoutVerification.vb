Option Explicit On
Option Strict On

Imports System
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportAppServer.ClientDoc
Imports CrystalDecisions.ReportAppServer.DataDefModel
Imports CrystalDecisions.ReportAppServer.ReportDefModel
Imports CrystalDecisions.Shared
Imports EngineReportDocument = CrystalDecisions.CrystalReports.Engine.ReportDocument
Imports RasSection = CrystalDecisions.ReportAppServer.ReportDefModel.Section

Module ServiceChargeReceiptLayoutVerification
    Private ReadOnly CustomerReceiptReports As String() = {
        "RestaurantPOS14.rptRestaurantPOSFinalBillKOTInvoice.rpt",
        "RestaurantPOS14.rptRestaurantPOSTAInvoice.rpt",
        "RestaurantPOS14.rptRestaurantPOSHDInvoice.rpt",
        "RestaurantPOS14.rptRestaurantPOSEBInvoice.rpt"
    }

    Public Sub Main(args As String())
        If args.Length <> 1 Then
            Console.Error.WriteLine("Usage: ServiceChargeReceiptLayoutVerification <report-directory>")
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

            Dim formula As FormulaField = Nothing
            For Each item As FormulaField In clientDocument.DataDefinition.FormulaFields
                If String.Equals(item.Name, "ServiceChargeReceiptPercentage", StringComparison.OrdinalIgnoreCase) Then
                    formula = item
                    Exit For
                End If
            Next
            If formula Is Nothing OrElse formula.Text.IndexOf("VATPer", StringComparison.OrdinalIgnoreCase) < 0 Then
                Throw New InvalidOperationException("Dynamic Service Charge percentage is missing from " & Path.GetFileName(reportPath) & ".")
            End If
            If formula.Text.IndexOf("servicechargePer", StringComparison.OrdinalIgnoreCase) >= 0 Then
                Throw New InvalidOperationException("Stale Service Charge field remains in " & Path.GetFileName(reportPath) & ".")
            End If

            Dim itemAmount As ISCRFieldObject = Nothing
            Dim serviceLabel As ISCRTextObject = Nothing
            Dim servicePercentage As ISCRFieldObject = Nothing
            Dim serviceAmount As ISCRFieldObject = Nothing

            For Each area As ISCRArea In clientDocument.ReportDefinition.Areas
                For Each section As RasSection In area.Sections
                    For Each reportObject As ISCRReportObject In section.ReportObjects
                        Dim fieldObject = TryCast(reportObject, ISCRFieldObject)
                        If fieldObject IsNot Nothing Then
                            If String.Equals(fieldObject.Name, "AmountX1", StringComparison.OrdinalIgnoreCase) Then itemAmount = fieldObject
                            If String.Equals(fieldObject.Name, "RTotal21", StringComparison.OrdinalIgnoreCase) Then serviceAmount = fieldObject
                            If String.Equals(fieldObject.Name, "ServiceChargeReceiptPercentageObject", StringComparison.OrdinalIgnoreCase) Then servicePercentage = fieldObject
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

            If itemAmount Is Nothing OrElse serviceLabel Is Nothing OrElse
               servicePercentage Is Nothing OrElse serviceAmount Is Nothing Then
                Throw New InvalidOperationException("Service Charge receipt objects are incomplete in " & Path.GetFileName(reportPath) & ".")
            End If
            If Not String.Equals(serviceLabel.Text.Trim(), "Service Charge", StringComparison.OrdinalIgnoreCase) Then
                Throw New InvalidOperationException("Service Charge label still contains a hard-coded percentage in " & Path.GetFileName(reportPath) & ".")
            End If

            Dim amountRight = itemAmount.Left + itemAmount.Width
            Dim serviceRight = serviceAmount.Left + serviceAmount.Width
            If serviceRight <> amountRight Then
                Throw New InvalidOperationException("Service Charge amount is not aligned with the Amount column in " & Path.GetFileName(reportPath) & ".")
            End If
            If servicePercentage.Left < serviceLabel.Left + serviceLabel.Width OrElse
               servicePercentage.Left + servicePercentage.Width > serviceAmount.Left Then
                Throw New InvalidOperationException("Service Charge percentage overlaps another footer field in " & Path.GetFileName(reportPath) & ".")
            End If

            Console.WriteLine(
                "VERIFIED|" & Path.GetFileName(reportPath) &
                "|DynamicPercent=True" &
                "|AmountRight=" & amountRight.ToString() &
                "|PercentWidth=" & servicePercentage.Width.ToString())
        End Using
    End Sub
End Module
