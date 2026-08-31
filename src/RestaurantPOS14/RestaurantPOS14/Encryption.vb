Imports System
Imports System.Diagnostics
Imports System.Text

Namespace RestaurantPOS14

    Public Class Encryption

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
        End Sub

        Public Shared Function InverseByBase(st As String, MoveBase As Integer) As String
            Dim stringBuilder As System.Text.StringBuilder = New System.Text.StringBuilder()
            Dim i As Integer = 0
            While i < st.Length
                Dim length As Integer =(If((i + MoveBase <= st.Length - 1), MoveBase, (st.Length - i)))
                stringBuilder.Append(RestaurantPOS14.Encryption.InverseString(st.Substring(i, length)))
                i += MoveBase
            End While

            Return stringBuilder.ToString()
        End Function

        Public Shared Function InverseString(st As String) As String
            Dim stringBuilder As System.Text.StringBuilder = New System.Text.StringBuilder()
            Dim num As Integer = st.Length - 1
            While True
                Dim num2 As Integer = num
                Dim num3 As Integer = 0
                If num2 < num3 Then
                    Exit While
                End If

                stringBuilder.Append(st(num))
                num += -1
            End While

            Return stringBuilder.ToString()
        End Function

        Public Shared Function ConvertToLetterDigit(st As String) As String
            Dim stringBuilder As System.Text.StringBuilder = New System.Text.StringBuilder()
            Dim i As Integer = 0
            Dim length As Integer = st.Length
            While i < length
                Dim c As Char = st(i)
                If Not Char.IsLetterOrDigit(c) Then
                    stringBuilder.Append(System.Convert.ToInt16(CChar((c))).ToString())
                Else
                    stringBuilder.Append(c)
                End If

                i = i + 1
            End While

            Return stringBuilder.ToString()
        End Function

        ''' <summary>
        '''  moving all characters in string insert then into new index
        '''  </summary>
        ''' <param name="st">string to moving characters</param>
        ''' <returns>moved characters string</returns>
        Public Shared Function Boring(st As String) As String
            Dim num As Integer = st.Length - 1
            Dim num2 As Integer = 0
            While True
                Dim num3 As Integer = num2
                Dim num4 As Integer = num
                If num3 > num4 Then
                    Exit While
                End If

                Dim num5 As Integer = num2 * System.Convert.ToUInt16(st(num2))
                num5 = num5 Mod st.Length
                Dim c As Char = st(num2)
                st = st.Remove(num2, 1)
                st = st.Insert(num5, c.ToString())
                num2 += 1
            End While

            Return st
        End Function

        Public Shared Function MakePassword(st As String, Identifier As String) As String
            If Identifier.Length <> 3 Then
                Throw New System.ArgumentException("Identifier must be 3 character length")
            End If

            Dim array As Integer() = New Integer(2) {System.Convert.ToInt32(Identifier(CInt((0))).ToString(), 10), System.Convert.ToInt32(Identifier(CInt((1))).ToString(), 10), System.Convert.ToInt32(Identifier(CInt((2))).ToString(), 10)}
            st = RestaurantPOS14.Encryption.Boring(st)
            st = RestaurantPOS14.Encryption.InverseByBase(st, array(0))
            st = RestaurantPOS14.Encryption.InverseByBase(st, array(1))
            st = RestaurantPOS14.Encryption.InverseByBase(st, array(2))
            Dim stringBuilder As System.Text.StringBuilder = New System.Text.StringBuilder()
            Dim text As String = st
            Dim i As Integer = 0
            Dim length As Integer = text.Length
            While i < length
                Dim ch As Char = text(i)
                stringBuilder.Append(RestaurantPOS14.Encryption.ChangeChar(ch, array))
                i = i + 1
            End While

            Return stringBuilder.ToString()
        End Function

        Private Shared Function ChangeChar(ch As Char, EnCode As Integer()) As Char
            ch = Char.ToUpper(ch)
            If ch >= "A"c AndAlso ch <= "H"c Then
                Return System.Convert.ToChar(System.Convert.ToInt16(ch) + 2 * EnCode(0))
            End If

            If ch >= "I"c AndAlso ch <= "P"c Then
                Return System.Convert.ToChar(System.Convert.ToInt16(ch) - EnCode(2))
            End If

            If ch >= "Q"c AndAlso ch <= "Z"c Then
                Return System.Convert.ToChar(System.Convert.ToInt16(ch) - EnCode(1))
            End If

            If ch >= "0"c AndAlso ch <= "4"c Then
                Return System.Convert.ToChar(System.Convert.ToInt16(ch) + 5)
            End If

            If ch >= "5"c AndAlso ch <= "9"c Then
                Return System.Convert.ToChar(System.Convert.ToInt16(ch) - 5)
            End If

            Return "0"c
        End Function
    End Class
End Namespace
