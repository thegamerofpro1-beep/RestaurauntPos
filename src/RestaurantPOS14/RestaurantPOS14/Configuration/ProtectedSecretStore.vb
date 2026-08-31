Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports Newtonsoft.Json

Namespace RestaurantPOS14.Configuration

    Public NotInheritable Class ProtectedSecretStore
        Implements ISecretStore

        Private Shared ReadOnly Entropy As Byte() = Encoding.UTF8.GetBytes("RestaurantPOS14.Configuration.v1")
        Private ReadOnly _path As String
        Private ReadOnly _gate As New Object()

        Public Sub New(path As String)
            If String.IsNullOrWhiteSpace(path) Then Throw New ArgumentException("A secret-store path is required.", NameOf(path))
            _path = System.IO.Path.GetFullPath(path)
        End Sub

        Public ReadOnly Property FilePath As String
            Get
                Return _path
            End Get
        End Property

        Public Function TryGetSecret(key As String, ByRef value As String) As Boolean Implements ISecretStore.TryGetSecret
            ValidateKey(key)
            SyncLock _gate
                Dim values = LoadValues()
                Dim protectedText As String = Nothing
                If Not values.TryGetValue(key, protectedText) Then
                    value = Nothing
                    Return False
                End If

                Try
                    Dim protectedBytes = Convert.FromBase64String(protectedText)
                    Dim plainBytes = ProtectedData.Unprotect(protectedBytes, Entropy, DataProtectionScope.CurrentUser)
                    value = Encoding.UTF8.GetString(plainBytes)
                    Return True
                Catch ex As Exception When TypeOf ex Is CryptographicException OrElse TypeOf ex Is FormatException
                    Throw New InvalidDataException("The protected value '" & key & "' could not be decrypted for the current Windows user.", ex)
                End Try
            End SyncLock
        End Function

        Public Sub SetSecret(key As String, value As String) Implements ISecretStore.SetSecret
            ValidateKey(key)
            If value Is Nothing Then Throw New ArgumentNullException(NameOf(value))
            SyncLock _gate
                Dim values = LoadValues()
                Dim plainBytes = Encoding.UTF8.GetBytes(value)
                Dim protectedBytes = ProtectedData.Protect(plainBytes, Entropy, DataProtectionScope.CurrentUser)
                values(key) = Convert.ToBase64String(protectedBytes)
                SaveValues(values)
            End SyncLock
        End Sub

        Public Sub RemoveSecret(key As String) Implements ISecretStore.RemoveSecret
            ValidateKey(key)
            SyncLock _gate
                Dim values = LoadValues()
                If values.Remove(key) Then SaveValues(values)
            End SyncLock
        End Sub

        Private Function LoadValues() As Dictionary(Of String, String)
            If Not File.Exists(_path) Then Return New Dictionary(Of String, String)(StringComparer.OrdinalIgnoreCase)
            Try
                Dim loaded = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(File.ReadAllText(_path))
                If loaded Is Nothing Then Return New Dictionary(Of String, String)(StringComparer.OrdinalIgnoreCase)
                Return New Dictionary(Of String, String)(loaded, StringComparer.OrdinalIgnoreCase)
            Catch ex As JsonException
                Throw New InvalidDataException("The DPAPI secret store is not valid JSON: " & _path, ex)
            End Try
        End Function

        Private Sub SaveValues(values As Dictionary(Of String, String))
            Dim directory = System.IO.Path.GetDirectoryName(_path)
            System.IO.Directory.CreateDirectory(directory)
            Dim temporary = _path & ".tmp"
            File.WriteAllText(temporary, JsonConvert.SerializeObject(values, Formatting.Indented), New UTF8Encoding(False))
            If File.Exists(_path) Then
                File.Replace(temporary, _path, Nothing)
            Else
                File.Move(temporary, _path)
            End If
        End Sub

        Private Shared Sub ValidateKey(key As String)
            If String.IsNullOrWhiteSpace(key) Then Throw New ArgumentException("A secret key is required.", NameOf(key))
        End Sub
    End Class

End Namespace
