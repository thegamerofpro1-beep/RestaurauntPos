Imports System
Imports CrystalDecisions.CrystalReports.Engine

Module ReportLayoutProbe
    Public Sub Main()
        Probe(New RestaurantPOS14.rptRestaurantPOSFinalBillKOTInvoice())
        Probe(New RestaurantPOS14.rptRestaurantPOSTAInvoice())
        Probe(New RestaurantPOS14.rptRestaurantPOSHDInvoice())
        Probe(New RestaurantPOS14.rptRestaurantPOSEBInvoice())
    End Sub

    Private Sub Probe(report As ReportDocument)
        Using report
            Console.WriteLine("=== " & report.GetType().Name & " ===")
            For Each section As Section In report.ReportDefinition.Sections
                Console.WriteLine("SECTION|" & section.Name & "|Height=" & section.Height.ToString() & "|Suppress=" & section.SectionFormat.EnableSuppress.ToString())
                For Each item As ReportObject In section.ReportObjects
                    Dim description = item.GetType().Name & "|" & item.Name & "|L=" & item.Left.ToString() & "|T=" & item.Top.ToString() & "|W=" & item.Width.ToString() & "|H=" & item.Height.ToString() & "|Suppress=" & item.ObjectFormat.EnableSuppress.ToString()
                    Dim textObject = TryCast(item, TextObject)
                    If textObject IsNot Nothing Then description &= "|Text=" & textObject.Text.Replace(vbCr, " ").Replace(vbLf, " ")
                    Dim fieldObject = TryCast(item, FieldObject)
                    If fieldObject IsNot Nothing AndAlso fieldObject.DataSource IsNot Nothing Then
                        description &= "|Data=" & fieldObject.DataSource.ToString() & "|DataName=" & fieldObject.DataSource.Name
                    End If
                    Console.WriteLine("OBJECT|" & description)
                Next
            Next

            For Each formula As FormulaFieldDefinition In report.DataDefinition.FormulaFields
                Console.WriteLine("FORMULA|" & formula.Name & "|" & If(formula.Text, String.Empty).Replace(vbCr, " ").Replace(vbLf, " "))
            Next
        End Using
    End Sub
End Module
