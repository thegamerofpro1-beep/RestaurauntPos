Option Explicit On
Option Strict On

Imports System
Imports System.IO
Imports System.Reflection
Imports CrystalDecisions.CrystalReports.Engine

Module ReceiptUpgradeFormulaSmoke
    Private ReadOnly ReceiptTypeNames As String() = {
        "RestaurantPOS14.rptRestaurantPOSFinalBillKOTInvoice",
        "RestaurantPOS14.rptRestaurantPOSTAInvoice",
        "RestaurantPOS14.rptRestaurantPOSHDInvoice",
        "RestaurantPOS14.rptRestaurantPOSEBInvoice"
    }

    Public Sub Main(args As String())
        If args.Length <> 1 Then
            Console.Error.WriteLine("Usage: ReceiptUpgradeFormulaSmoke <RestaurantPOS14.exe>")
            Environment.ExitCode = 2
            Return
        End If

        Try
            Dim applicationPath = Path.GetFullPath(args(0))
            Dim applicationAssembly = Assembly.LoadFrom(applicationPath)
            Dim repairType = applicationAssembly.GetType(
                "RestaurantPOS14.Reporting.ReceiptReportCompatibility", True)
            Dim applyMethod = repairType.GetMethod(
                "Apply", BindingFlags.Public Or BindingFlags.Static)
            If applyMethod Is Nothing Then
                Throw New MissingMethodException(repairType.FullName, "Apply")
            End If
            Dim printBoundaryType = applicationAssembly.GetType("RestaurantPOS14.ModFunc", True)
            Dim printBoundaryMethod = printBoundaryType.GetMethod(
                "ApplyServiceChargeLabelFix", BindingFlags.Public Or BindingFlags.Static)
            If printBoundaryMethod Is Nothing Then
                Throw New MissingMethodException(printBoundaryType.FullName, "ApplyServiceChargeLabelFix")
            End If

            For Each receiptTypeName In ReceiptTypeNames
                VerifyReceipt(applicationAssembly, applyMethod, printBoundaryMethod, receiptTypeName)
            Next
        Catch ex As Exception
            Console.Error.WriteLine(ex.ToString())
            Environment.ExitCode = 1
        End Try
    End Sub

    Private Sub VerifyReceipt(applicationAssembly As Assembly,
                              applyMethod As MethodInfo,
                              printBoundaryMethod As MethodInfo,
                              receiptTypeName As String)
        Dim receiptType = applicationAssembly.GetType(receiptTypeName, True)

        Using report = DirectCast(Activator.CreateInstance(receiptType), ReportDocument)
            Dim serviceFormula = FindFormula(report, "ServiceChargeReceiptPercentage")
            Dim sstFormula = FindFormula(report, "SstReceiptPercentage")
            If serviceFormula Is Nothing OrElse sstFormula Is Nothing Then
                Throw New InvalidOperationException(
                    receiptTypeName & " is missing a required percentage formula.")
            End If

            ' Reproduce the field name captured in the failed upgraded-PC report.
            ' Some Crystal builds reject it immediately; a harmless wrong literal
            ' is used in that case so the repair path is still exercised.
            Dim staleFormulaAccepted As Boolean = True
            Try
                serviceFormula.Text =
                    """("" & ToText(Maximum ({Restaurant_OrderedProduct.servicechargePer}), 2, """") & ""%) :"""
            Catch
                staleFormulaAccepted = False
                serviceFormula.Text = """(99.00%) :"""
            End Try

            ' Exercise the same label-normalization boundary used by Save & Print.
            ' It must repair the stale formula and must not corrupt VATPer again.
            printBoundaryMethod.Invoke(Nothing, New Object() {report})

            Dim repairedServiceText = serviceFormula.Text
            Dim repairedSstText = sstFormula.Text
            If repairedServiceText.IndexOf("VATPer", StringComparison.OrdinalIgnoreCase) < 0 OrElse
               repairedServiceText.IndexOf("servicechargePer", StringComparison.OrdinalIgnoreCase) >= 0 Then
                Throw New InvalidOperationException(
                    receiptTypeName & " did not repair the stale Service Charge formula: " &
                    repairedServiceText)
            End If
            If repairedSstText.IndexOf("STPer", StringComparison.OrdinalIgnoreCase) < 0 Then
                Throw New InvalidOperationException(
                    receiptTypeName & " did not normalize the SST formula: " & repairedSstText)
            End If

            ' A second pass proves the print-boundary cleanup is idempotent.
            printBoundaryMethod.Invoke(Nothing, New Object() {report})
            If serviceFormula.Text.IndexOf("VATPer", StringComparison.OrdinalIgnoreCase) < 0 Then
                Throw New InvalidOperationException(
                    receiptTypeName & " corrupted VATPer during repeated label cleanup: " &
                    serviceFormula.Text)
            End If

            Console.WriteLine(
                "VERIFIED|" & receiptTypeName &
                "|StaleFormulaAccepted=" & staleFormulaAccepted.ToString() &
                "|ServiceFormula=" & repairedServiceText &
                "|SstFormula=" & repairedSstText)
        End Using
    End Sub

    Private Function FindFormula(report As ReportDocument,
                                 formulaName As String) As FormulaFieldDefinition
        For Each formula As FormulaFieldDefinition In report.DataDefinition.FormulaFields
            If String.Equals(formula.Name, formulaName, StringComparison.OrdinalIgnoreCase) Then
                Return formula
            End If
        Next

        Return Nothing
    End Function
End Module
