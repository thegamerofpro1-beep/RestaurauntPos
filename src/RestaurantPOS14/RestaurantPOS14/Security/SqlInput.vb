Imports System
Imports System.Collections.Generic
Imports System.Globalization

Namespace RestaurantPOS14.Security

    ''' <summary>
    ''' Compatibility guards for the remaining decompiled SQL strings. New code
    ''' should use SqlParameter; these methods make legacy dynamic fragments fail
    ''' closed instead of accepting executable input.
    ''' </summary>
    Friend NotInheritable Class SqlInput
        Private Sub New()
        End Sub

        Public Shared Function EscapeLiteral(value As String) As String
            value = If(value, String.Empty)
            If value.Length > 512 Then Throw New ArgumentOutOfRangeException(NameOf(value), "Search text is too long.")
            If value.IndexOf(ChrW(0)) >= 0 Then Throw New ArgumentException("Search text contains an invalid character.", NameOf(value))
            Return value.Replace("'", "''")
        End Function

        Public Shared Function RequireInteger(value As String, fieldName As String) As String
            Dim parsed As Integer
            If Not Integer.TryParse(If(value, String.Empty).Trim(), NumberStyles.Integer, CultureInfo.InvariantCulture, parsed) OrElse parsed < 0 Then
                Throw New ArgumentException(If(fieldName, "Value") & " must be a non-negative whole number.")
            End If
            Return parsed.ToString(CultureInfo.InvariantCulture)
        End Function

        Public Shared Function RequireDecimal(value As String, fieldName As String) As String
            Dim parsed As Decimal
            Dim text = If(value, String.Empty).Trim()
            If Not Decimal.TryParse(text, NumberStyles.Number, CultureInfo.CurrentCulture, parsed) AndAlso
               Not Decimal.TryParse(text, NumberStyles.Number, CultureInfo.InvariantCulture, parsed) Then
                Throw New ArgumentException(If(fieldName, "Value") & " must be a valid number.")
            End If
            Return parsed.ToString(CultureInfo.InvariantCulture)
        End Function

        Public Shared Function RequireIntegerList(value As String, fieldName As String) As String
            Dim result As New List(Of String)()
            For Each part In If(value, String.Empty).Split(","c)
                Dim normalized = part.Trim()
                If normalized.Length = 0 Then Continue For
                result.Add(RequireInteger(normalized, fieldName))
            Next
            If result.Count = 0 Then Throw New ArgumentException(If(fieldName, "Value") & " must contain at least one whole number.")
            Return String.Join(",", result)
        End Function
    End Class
End Namespace
