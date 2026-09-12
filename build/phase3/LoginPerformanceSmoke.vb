Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Reflection

Module LoginPerformanceSmoke
    Private Const KnownHash As String = "P1$AQIDBAUGBwg$Qpq5jFYWF2pdeypZkz4Bu_Oz7-0NW8sf"

    Function Main(args As String()) As Integer
        If args.Length <> 1 Then
            Console.Error.WriteLine("Usage: LoginPerformanceSmoke <RestaurantPOS14.exe>")
            Return 2
        End If

        Dim appAssembly As Assembly = Assembly.LoadFrom(IO.Path.GetFullPath(args(0)))
        Dim securityType = appAssembly.GetType("RestaurantPOS14.Security.PinSecurity", True)
        Dim staticFlags = BindingFlags.Public Or BindingFlags.NonPublic Or BindingFlags.Static
        Dim verify = securityType.GetMethod("VerifyPin", staticFlags)
        Dim hash = securityType.GetMethod("HashPin", staticFlags)

        Require(CBool(verify.Invoke(Nothing, New Object() {"1234", KnownHash})), "An existing PBKDF2 PIN hash was rejected.")
        Require(Not CBool(verify.Invoke(Nothing, New Object() {"9999", KnownHash})), "An incorrect PIN was accepted.")
        Dim newHash = CStr(hash.Invoke(Nothing, New Object() {"5678"}))
        Require(CBool(verify.Invoke(Nothing, New Object() {"5678", newHash})), "A newly generated PIN hash did not round-trip.")

        Dim loginType = appAssembly.GetType("RestaurantPOS14.frmLogin", True)
        Dim credentialType = loginType.GetNestedType("LoginCredential", BindingFlags.NonPublic)
        Dim listType = GetType(List(Of )).MakeGenericType(credentialType)
        Dim credentials = Activator.CreateInstance(listType)
        Dim add = listType.GetMethod("Add")

        For index = 0 To 19
            Dim credential = Activator.CreateInstance(credentialType, True)
            credentialType.GetField("UserId").SetValue(credential, "user" & index.ToString())
            credentialType.GetField("UserType").SetValue(credential, "Cashier")
            credentialType.GetField("StoredPin").SetValue(credential, KnownHash)
            add.Invoke(credentials, New Object() {credential})
        Next

        Dim find = loginType.GetMethod("FindMatchingCredential", staticFlags)
        Dim timer = Stopwatch.StartNew()
        Dim noMatch = find.Invoke(Nothing, New Object() {"9999", credentials})
        timer.Stop()
        Require(noMatch Is Nothing, "The parallel login scan accepted an incorrect PIN.")
        Require(timer.ElapsedMilliseconds < 5000, "The 20-user login scan exceeded five seconds.")

        timer.Restart()
        Dim match = find.Invoke(Nothing, New Object() {"1234", credentials})
        timer.Stop()
        Require(match IsNot Nothing, "The parallel login scan did not find a valid PIN.")
        Require(CStr(credentialType.GetField("UserId").GetValue(match)) = "user0", "The login scan did not preserve credential order.")

        Console.WriteLine("ExistingHashCompatible=True")
        Console.WriteLine("ParallelLoginScan20Milliseconds=" & timer.ElapsedMilliseconds.ToString())
        Console.WriteLine("LoginPerformanceSmokeSucceeded=True")
        Return 0
    End Function

    Private Sub Require(condition As Boolean, message As String)
        If Not condition Then Throw New InvalidOperationException(message)
    End Sub
End Module
