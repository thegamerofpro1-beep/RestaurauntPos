Imports System
Imports System.CodeDom.Compiler
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.ApplicationServices

Namespace RestaurantPOS14.My

    <System.CodeDom.Compiler.GeneratedCodeAttribute("MyTemplate", "10.0.0.0")>
    <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)>
    Friend Class MyApplication
        Inherits Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.My.MyApplication.__ENCList
                If RestaurantPOS14.My.MyApplication.__ENCList.Count = RestaurantPOS14.My.MyApplication.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.My.MyApplication.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.My.MyApplication.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.My.MyApplication.__ENCList(num) = RestaurantPOS14.My.MyApplication.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.My.MyApplication.__ENCList.RemoveRange(num, RestaurantPOS14.My.MyApplication.__ENCList.Count - num)
                    RestaurantPOS14.My.MyApplication.__ENCList.Capacity = RestaurantPOS14.My.MyApplication.__ENCList.Count
                End If

                Call RestaurantPOS14.My.MyApplication.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.NoInlining Or System.Runtime.CompilerServices.MethodImplOptions.NoOptimization)>
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>
        <System.STAThreadAttribute>
        <System.Diagnostics.DebuggerHiddenAttribute>
        Friend Shared Sub Main(Args As String())
            Call System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase.UseCompatibleTextRendering)
            System.Windows.Forms.Application.SetUnhandledExceptionMode(System.Windows.Forms.UnhandledExceptionMode.CatchException)
            AddHandler System.Windows.Forms.Application.ThreadException, AddressOf RestaurantPOS14.Diagnostics.ApplicationDiagnostics.HandleUnhandledUiException
            AddHandler System.AppDomain.CurrentDomain.UnhandledException, AddressOf RestaurantPOS14.Diagnostics.ApplicationDiagnostics.HandleUnhandledDomainException
            Call RestaurantPOS14.My.MyProject.Application.Run(Args)
        End Sub

        <System.Diagnostics.DebuggerStepThroughAttribute>
        Public Sub New()
            MyBase.New(Microsoft.VisualBasic.ApplicationServices.AuthenticationMode.ApplicationDefined)
            Call RestaurantPOS14.My.MyApplication.__ENCAddToList(Me)
            MyBase.IsSingleInstance = False
            MyBase.EnableVisualStyles = True
            MyBase.SaveMySettingsOnExit = True
            MyBase.ShutdownStyle = Microsoft.VisualBasic.ApplicationServices.ShutdownMode.AfterMainFormCloses
        End Sub

        <System.Diagnostics.DebuggerStepThroughAttribute>
        Protected Overrides Sub OnCreateMainForm()
            RestaurantPOS14.Customization.UiCustomizationHost.Initialize()
            MyBase.MainForm = RestaurantPOS14.My.MyProject.Forms.frmSplash
        End Sub
    End Class
End Namespace
