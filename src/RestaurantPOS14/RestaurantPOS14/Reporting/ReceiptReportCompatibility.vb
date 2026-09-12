Imports System
Imports CrystalDecisions.CrystalReports.Engine

Namespace RestaurantPOS14.Reporting

    ''' <summary>
    ''' Repairs receipt formulas that may have been carried forward from an older
    ''' application build. Crystal formulas persist their table alias and field
    ''' name, so one stale formula can otherwise prevent the whole receipt from
    ''' rendering after an in-place upgrade.
    ''' </summary>
    Friend NotInheritable Class ReceiptReportCompatibility
        Private Const ServiceChargeFormulaName As String = "ServiceChargeReceiptPercentage"
        Private Const SstFormulaName As String = "SstReceiptPercentage"

        Private Shared ReadOnly ServiceChargeFieldNames As String() = {
            "VATPer",
            "ServiceChargePer",
            "servicechargePer",
            "SCPer"
        }

        Private Shared ReadOnly SstFieldNames As String() = {
            "STPer",
            "SSTPer",
            "ServiceTaxPer"
        }

        Private Sub New()
        End Sub

        Public Shared Sub Apply(report As ReportDocument)
            If report Is Nothing Then Return

            Try
                RepairDocument(report)

                For index As Integer = 0 To report.Subreports.Count - 1
                    RepairDocument(report.Subreports(index))
                Next
            Catch ex As Exception
                RestaurantPOS14.Diagnostics.ApplicationDiagnostics.ReportNonFatal(
                    "Repair upgraded receipt formulas", ex)
            End Try
        End Sub

        Private Shared Sub RepairDocument(report As ReportDocument)
            RepairPercentageFormula(report, ServiceChargeFormulaName, ServiceChargeFieldNames)
            RepairPercentageFormula(report, SstFormulaName, SstFieldNames)
        End Sub

        Private Shared Sub RepairPercentageFormula(report As ReportDocument,
                                                   formulaName As String,
                                                   candidateFieldNames As String())
            Dim formula = FindFormula(report, formulaName)
            If formula Is Nothing Then Return

            Dim sourceField = FindDatabaseField(report, candidateFieldNames)
            If sourceField Is Nothing Then
                ' A missing optional percentage must not make an otherwise valid
                ' receipt unprintable. Keep the amount row and suppress only the
                ' percentage text while recording the incompatible report schema.
                formula.Text = """"""
                RestaurantPOS14.Diagnostics.ApplicationDiagnostics.ReportNonFatal(
                    "Repair upgraded receipt formula " & formulaName,
                    New InvalidOperationException(
                        "None of the compatible receipt fields were found: " &
                        String.Join(", ", candidateFieldNames)))
                Return
            End If

            ' FormulaName contains Crystal's real, escaped table/field reference.
            ' Using it avoids depending on a table alias embedded by a prior build.
            formula.Text = """("" & ToText(Maximum (" & sourceField.FormulaName &
                           "), 2, """") & ""%) :"""
        End Sub

        Private Shared Function FindFormula(report As ReportDocument,
                                            formulaName As String) As FormulaFieldDefinition
            For Each formula As FormulaFieldDefinition In report.DataDefinition.FormulaFields
                If String.Equals(formula.Name, formulaName, StringComparison.OrdinalIgnoreCase) Then
                    Return formula
                End If
            Next

            Return Nothing
        End Function

        Private Shared Function FindDatabaseField(report As ReportDocument,
                                                  candidateFieldNames As String()) As DatabaseFieldDefinition
            For Each candidateName In candidateFieldNames
                For Each table As Table In report.Database.Tables
                    For Each field As DatabaseFieldDefinition In table.Fields
                        If String.Equals(field.Name, candidateName, StringComparison.OrdinalIgnoreCase) Then
                            Return field
                        End If
                    Next
                Next
            Next

            Return Nothing
        End Function
    End Class
End Namespace
