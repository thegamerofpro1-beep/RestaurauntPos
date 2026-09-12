Option Explicit On
Option Strict On

Imports System
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Module SstReportVerification
    Private ReadOnly CustomerReceiptReports As String() = {
        "RestaurantPOS14.rptRestaurantPOSFinalBillKOTInvoice.rpt",
        "RestaurantPOS14.rptRestaurantPOSTAInvoice.rpt",
        "RestaurantPOS14.rptRestaurantPOSHDInvoice.rpt",
        "RestaurantPOS14.rptRestaurantPOSEBInvoice.rpt"
    }

    Public Sub Main(args As String())
        If args.Length <> 1 Then
            Console.Error.WriteLine("Usage: SstReportVerification <report-directory>")
            Environment.ExitCode = 2
            Return
        End If

        For Each reportName In CustomerReceiptReports
            VerifyReport(Path.Combine(Path.GetFullPath(args(0)), reportName))
        Next
    End Sub

    Private Sub VerifyReport(reportPath As String)
        Using report As New ReportDocument()
            report.Load(reportPath, OpenReportMethod.OpenReportByTempCopy)

            Dim percentageFormula = FindFormula(report, "SstReceiptPercentage")
            Dim amountFormula = FindFormula(report, "SstReceiptAmount")
            If percentageFormula Is Nothing OrElse amountFormula Is Nothing Then
                Throw New InvalidOperationException("SST formulas are missing from " & Path.GetFileName(reportPath) & ".")
            End If

            Dim sstLabel As TextObject = Nothing
            Dim subtotalLabel As TextObject = Nothing
            Dim sstPercentage As FieldObject = Nothing
            Dim sstAmount As FieldObject = Nothing

            For Each section As Section In report.ReportDefinition.Sections
                For Each reportObject As ReportObject In section.ReportObjects
                    Dim textObject = TryCast(reportObject, TextObject)
                    If textObject IsNot Nothing Then
                        If textObject.Name = "SstReceiptLabelObject" Then sstLabel = textObject
                        If textObject.Text.IndexOf("Sub Total", StringComparison.OrdinalIgnoreCase) >= 0 Then subtotalLabel = textObject
                    End If

                    Dim fieldObject = TryCast(reportObject, FieldObject)
                    If fieldObject IsNot Nothing Then
                        If fieldObject.Name = "SstReceiptPercentageObject" Then sstPercentage = fieldObject
                        If fieldObject.Name = "SstReceiptAmountObject" Then sstAmount = fieldObject
                    End If
                Next
            Next

            If sstLabel Is Nothing OrElse subtotalLabel Is Nothing OrElse
               sstPercentage Is Nothing OrElse sstAmount Is Nothing Then
                Throw New InvalidOperationException("SST row objects are missing from " & Path.GetFileName(reportPath) & ".")
            End If

            If sstLabel.Text <> "SST" Then
                Throw New InvalidOperationException("Unexpected SST label in " & Path.GetFileName(reportPath) & ".")
            End If
            If sstLabel.Top <= subtotalLabel.Top Then
                Throw New InvalidOperationException("SST row is not below Sub Total in " & Path.GetFileName(reportPath) & ".")
            End If

            Console.WriteLine(
                "VERIFIED|" & Path.GetFileName(reportPath) &
                "|SSTTop=" & sstLabel.Top.ToString() &
                "|SubtotalTop=" & subtotalLabel.Top.ToString() &
                "|PercentFormula=" & percentageFormula.Text.Replace(vbCr, " ").Replace(vbLf, " ") &
                "|AmountFormula=" & amountFormula.Text.Replace(vbCr, " ").Replace(vbLf, " "))
        End Using
    End Sub

    Private Function FindFormula(report As ReportDocument, formulaName As String) As FormulaFieldDefinition
        For Each formula As FormulaFieldDefinition In report.DataDefinition.FormulaFields
            If String.Equals(formula.Name, formulaName, StringComparison.OrdinalIgnoreCase) Then Return formula
        Next
        Return Nothing
    End Function
End Module
