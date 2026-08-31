Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Text
Imports Newtonsoft.Json
Imports RestaurantPOS14.Configuration

Namespace RestaurantPOS14.Customization

    Public NotInheritable Class ReceiptTemplate
        Public Property Name As String = String.Empty
        Public Property Sections As List(Of ReceiptTemplateSection) = New List(Of ReceiptTemplateSection)()
    End Class

    Public NotInheritable Class ReceiptTemplateSection
        Public Property Key As String = String.Empty
        Public Property Order As Integer
        Public Property Visible As Boolean = True
        Public Property Content As String = String.Empty
    End Class

    ''' <summary>
    ''' Loads an optional editable JSON receipt template. An empty TemplatePath means
    ''' the existing Crystal/PrintDocument receipt path remains active.
    ''' </summary>
    Public NotInheritable Class ReceiptTemplateService
        Private Sub New()
        End Sub

        Public Shared Function LoadConfigured(settings As ReceiptSettings) As ReceiptTemplate
            If settings Is Nothing Then Throw New ArgumentNullException(NameOf(settings))
            If String.IsNullOrWhiteSpace(settings.TemplatePath) Then Return Nothing

            Dim path = settings.TemplatePath
            If Not System.IO.Path.IsPathRooted(path) Then path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, path)
            path = System.IO.Path.GetFullPath(path)
            If Not File.Exists(path) Then Throw New FileNotFoundException("The configured receipt template does not exist.", path)

            Dim template As ReceiptTemplate
            Try
                template = JsonConvert.DeserializeObject(Of ReceiptTemplate)(File.ReadAllText(path))
            Catch ex As JsonException
                Throw New InvalidDataException("Receipt template JSON is invalid: " & path, ex)
            End Try
            Validate(template, path)
            Return template
        End Function

        Public Shared Function RenderPlainText(template As ReceiptTemplate, values As IDictionary(Of String, String)) As String
            If template Is Nothing Then Throw New ArgumentNullException(NameOf(template))
            If values Is Nothing Then Throw New ArgumentNullException(NameOf(values))

            Dim output As New StringBuilder()
            For Each section In template.Sections.Where(Function(item) item.Visible).OrderBy(Function(item) item.Order)
                Dim content = If(section.Content, String.Empty)
                For Each value In values
                    content = content.Replace("{{" & value.Key & "}}", If(value.Value, String.Empty))
                Next
                If output.Length > 0 Then output.AppendLine()
                output.Append(content)
            Next
            Return output.ToString()
        End Function

        Private Shared Sub Validate(template As ReceiptTemplate, path As String)
            If template Is Nothing Then Throw New InvalidDataException("Receipt template is empty: " & path)
            If template.Sections Is Nothing Then Throw New InvalidDataException("Receipt template Sections are required: " & path)

            Dim keys As New HashSet(Of String)(StringComparer.OrdinalIgnoreCase)
            For Each section In template.Sections
                If section Is Nothing OrElse String.IsNullOrWhiteSpace(section.Key) Then Throw New InvalidDataException("Every receipt section requires a key: " & path)
                If Not keys.Add(section.Key) Then Throw New InvalidDataException("Duplicate receipt section key '" & section.Key & "': " & path)
            Next
        End Sub
    End Class

End Namespace
