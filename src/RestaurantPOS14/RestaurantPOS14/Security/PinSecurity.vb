Imports System
Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography
Imports System.Text

Namespace RestaurantPOS14.Security

    ''' <summary>
    ''' Password/PIN compatibility layer. New values use a salted, deliberately slow
    ''' hash that fits the legacy nchar(50) column. Existing Base64 PINs remain valid
    ''' and are upgraded after the next successful login.
    ''' </summary>
    Friend NotInheritable Class PinSecurity
        Private Const Prefix As String = "P1$"
        Private Const Iterations As Integer = 100000
        Private Const SaltBytes As Integer = 8
        Private Const HashBytes As Integer = 24
        Private Const MaximumFailures As Integer = 5
        Private Const BCryptAlgHandleHmacFlag As Integer = &H8
        Private Shared ReadOnly FailureSync As New Object()
        Private Shared ReadOnly Failures As New Dictionary(Of String, FailureState)(StringComparer.OrdinalIgnoreCase)

        <DllImport("bcrypt.dll", CharSet:=CharSet.Unicode)>
        Private Shared Function BCryptOpenAlgorithmProvider(ByRef algorithmHandle As IntPtr, algorithmId As String, implementation As String, flags As Integer) As Integer
        End Function

        <DllImport("bcrypt.dll")>
        Private Shared Function BCryptDeriveKeyPBKDF2(algorithmHandle As IntPtr, password As Byte(), passwordLength As Integer, salt As Byte(), saltLength As Integer, iterationCount As ULong, derivedKey As Byte(), derivedKeyLength As Integer, flags As Integer) As Integer
        End Function

        <DllImport("bcrypt.dll")>
        Private Shared Function BCryptCloseAlgorithmProvider(algorithmHandle As IntPtr, flags As Integer) As Integer
        End Function

        Private Sub New()
        End Sub

        Public Shared Function HashPin(pin As String) As String
            ValidatePin(pin)
            Dim salt(SaltBytes - 1) As Byte
            Using rng = RandomNumberGenerator.Create()
                rng.GetBytes(salt)
            End Using
            Dim derived = Derive(pin, salt)
            Return Prefix & ToCompactBase64(salt) & "$" & ToCompactBase64(derived)
        End Function

        Public Shared Function VerifyPin(pin As String, storedValue As String) As Boolean
            If String.IsNullOrEmpty(pin) OrElse String.IsNullOrWhiteSpace(storedValue) Then Return False
            storedValue = storedValue.Trim()

            If storedValue.StartsWith(Prefix, StringComparison.Ordinal) Then
                Dim parts = storedValue.Split("$"c)
                If parts.Length <> 3 Then Return False
                Try
                    Dim salt = FromCompactBase64(parts(1))
                    Dim expected = FromCompactBase64(parts(2))
                    If salt.Length <> SaltBytes OrElse expected.Length <> HashBytes Then Return False
                    Return FixedTimeEquals(expected, Derive(pin, salt))
                Catch ex As FormatException
                    Return False
                End Try
            End If

            ' First-version databases stored UTF-8 PINs as Base64.  Compare without
            ' exposing the decoded value and migrate it after a successful login.
            Try
                Dim legacy = Convert.FromBase64String(storedValue)
                Return FixedTimeEquals(legacy, Encoding.UTF8.GetBytes(pin))
            Catch ex As FormatException
                Return False
            End Try
        End Function

        Public Shared Function IsStrongHash(storedValue As String) As Boolean
            Return Not String.IsNullOrWhiteSpace(storedValue) AndAlso storedValue.Trim().StartsWith(Prefix, StringComparison.Ordinal)
        End Function

        Public Shared Sub ValidatePin(pin As String)
            If pin Is Nothing OrElse pin.Length <> 4 Then Throw New ArgumentException("The PIN must contain exactly four digits.", NameOf(pin))
            For Each c In pin
                If Not Char.IsDigit(c) Then Throw New ArgumentException("The PIN must contain digits only.", NameOf(pin))
            Next
        End Sub

        Public Shared Function CanAttempt(key As String, ByRef waitSeconds As Integer) As Boolean
            key = If(key, String.Empty)
            SyncLock FailureSync
                Dim state As FailureState = Nothing
                If Not Failures.TryGetValue(key, state) OrElse state.LockedUntilUtc <= DateTime.UtcNow Then
                    If state IsNot Nothing AndAlso state.LockedUntilUtc <= DateTime.UtcNow Then Failures.Remove(key)
                    waitSeconds = 0
                    Return True
                End If
                waitSeconds = Math.Max(1, CInt(Math.Ceiling((state.LockedUntilUtc - DateTime.UtcNow).TotalSeconds)))
                Return False
            End SyncLock
        End Function

        Public Shared Sub RegisterFailure(key As String)
            key = If(key, String.Empty)
            SyncLock FailureSync
                Dim state As FailureState = Nothing
                If Not Failures.TryGetValue(key, state) Then
                    state = New FailureState()
                    Failures(key) = state
                End If
                state.Count += 1
                If state.Count >= MaximumFailures Then
                    state.Count = 0
                    state.LockedUntilUtc = DateTime.UtcNow.AddSeconds(30)
                End If
            End SyncLock
        End Sub

        Public Shared Sub ResetFailures(key As String)
            SyncLock FailureSync
                Failures.Remove(If(key, String.Empty))
            End SyncLock
        End Sub

        Public Shared Function CreateTemporaryPin() As String
            Dim bytes(3) As Byte
            Using rng = RandomNumberGenerator.Create()
                Do
                    rng.GetBytes(bytes)
                    Dim candidate = BitConverter.ToUInt32(bytes, 0)
                    If candidate <= UInt32.MaxValue - (UInt32.MaxValue Mod 10000UI) Then Return (candidate Mod 10000UI).ToString("0000")
                Loop
            End Using
        End Function

        Private Shared Function Derive(pin As String, salt As Byte()) As Byte()
            ' Windows CNG produces the same PBKDF2-HMAC-SHA1 bytes as the managed
            ' implementation, but is several times faster on the x86 POS build.
            ' Keep the managed fallback so existing hashes remain usable on any
            ' supported Windows installation where CNG is unavailable.
            Try
                Return DeriveWithWindowsCng(pin, salt)
            Catch ex As DllNotFoundException
            Catch ex As EntryPointNotFoundException
            Catch ex As CryptographicException
            End Try

            Using deriveBytes As New Rfc2898DeriveBytes(pin, salt, Iterations)
                Return deriveBytes.GetBytes(HashBytes)
            End Using
        End Function

        Private Shared Function DeriveWithWindowsCng(pin As String, salt As Byte()) As Byte()
            Dim algorithmHandle As IntPtr = IntPtr.Zero
            Dim status = BCryptOpenAlgorithmProvider(algorithmHandle, "SHA1", Nothing, BCryptAlgHandleHmacFlag)
            If status <> 0 Then Throw New CryptographicException("BCryptOpenAlgorithmProvider failed with status 0x" & status.ToString("X8"))

            Try
                Dim passwordBytes = Encoding.UTF8.GetBytes(pin)
                Dim derived(HashBytes - 1) As Byte
                status = BCryptDeriveKeyPBKDF2(algorithmHandle, passwordBytes, passwordBytes.Length, salt, salt.Length, CULng(Iterations), derived, derived.Length, 0)
                If status <> 0 Then Throw New CryptographicException("BCryptDeriveKeyPBKDF2 failed with status 0x" & status.ToString("X8"))
                Return derived
            Finally
                If algorithmHandle <> IntPtr.Zero Then BCryptCloseAlgorithmProvider(algorithmHandle, 0)
            End Try
        End Function

        Private Shared Function FixedTimeEquals(left As Byte(), right As Byte()) As Boolean
            If left Is Nothing OrElse right Is Nothing OrElse left.Length <> right.Length Then Return False
            Dim difference As Integer = 0
            For index = 0 To left.Length - 1
                difference = difference Or (left(index) Xor right(index))
            Next
            Return difference = 0
        End Function

        Private Shared Function ToCompactBase64(value As Byte()) As String
            Return Convert.ToBase64String(value).TrimEnd("="c).Replace("+"c, "-"c).Replace("/"c, "_"c)
        End Function

        Private Shared Function FromCompactBase64(value As String) As Byte()
            Dim normalized = value.Replace("-"c, "+"c).Replace("_"c, "/"c)
            normalized &= New String("="c, (4 - normalized.Length Mod 4) Mod 4)
            Return Convert.FromBase64String(normalized)
        End Function

        Private NotInheritable Class FailureState
            Public Count As Integer
            Public LockedUntilUtc As DateTime
        End Class
    End Class
End Namespace
