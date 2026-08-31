Imports System
Imports System.Diagnostics
Imports System.Runtime.InteropServices
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.StandardModuleAttribute>
    Friend NotInheritable Class ModCashDrawer

        Public Class RawPrinter

            <System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet:=System.Runtime.InteropServices.CharSet.Unicode)>
            Public Structure DOCINFO

                <System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)>
                Public pDocName As String

                <System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)>
                Public pOutputFile As String

                <System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)>
                Public pDataType As String
            End Structure

            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Public Sub New()
            End Sub

            <System.Runtime.InteropServices.DllImportAttribute("winspool.drv", CallingConvention:=System.Runtime.InteropServices.CallingConvention.StdCall, CharSet:=System.Runtime.InteropServices.CharSet.Unicode, EntryPoint:="OpenPrinterW", ExactSpelling:=True, SetLastError:=True)>
            Public Shared Function OpenPrinter(printerName As String, ByRef hPrinter As System.IntPtr, printerDefaults As Integer) As Boolean
            End Function

            <System.Runtime.InteropServices.DllImportAttribute("winspool.drv", CallingConvention:=System.Runtime.InteropServices.CallingConvention.StdCall, CharSet:=System.Runtime.InteropServices.CharSet.Unicode, ExactSpelling:=True, SetLastError:=True)>
            Public Shared Function ClosePrinter(hPrinter As System.IntPtr) As Boolean
            End Function

            <System.Runtime.InteropServices.DllImportAttribute("winspool.drv", CallingConvention:=System.Runtime.InteropServices.CallingConvention.StdCall, CharSet:=System.Runtime.InteropServices.CharSet.Unicode, EntryPoint:="StartDocPrinterW", ExactSpelling:=True, SetLastError:=True)>
            Public Shared Function StartDocPrinter(hPrinter As System.IntPtr, level As Integer, ByRef documentInfo As RestaurantPOS14.ModCashDrawer.RawPrinter.DOCINFO) As Boolean
            End Function

            <System.Runtime.InteropServices.DllImportAttribute("winspool.drv", CallingConvention:=System.Runtime.InteropServices.CallingConvention.StdCall, CharSet:=System.Runtime.InteropServices.CharSet.Unicode, ExactSpelling:=True, SetLastError:=True)>
            Public Shared Function EndDocPrinter(hPrinter As System.IntPtr) As Boolean
            End Function

            <System.Runtime.InteropServices.DllImportAttribute("winspool.drv", CallingConvention:=System.Runtime.InteropServices.CallingConvention.StdCall, CharSet:=System.Runtime.InteropServices.CharSet.Unicode, ExactSpelling:=True, SetLastError:=True)>
            Public Shared Function StartPagePrinter(hPrinter As System.IntPtr) As Boolean
            End Function

            <System.Runtime.InteropServices.DllImportAttribute("winspool.drv", CallingConvention:=System.Runtime.InteropServices.CallingConvention.StdCall, CharSet:=System.Runtime.InteropServices.CharSet.Unicode, ExactSpelling:=True, SetLastError:=True)>
            Public Shared Function EndPagePrinter(hPrinter As System.IntPtr) As Boolean
            End Function

            <System.Runtime.InteropServices.DllImportAttribute("winspool.drv", CallingConvention:=System.Runtime.InteropServices.CallingConvention.StdCall, CharSet:=System.Runtime.InteropServices.CharSet.Unicode, ExactSpelling:=True, SetLastError:=True)>
            Public Shared Function WritePrinter(hPrinter As System.IntPtr, buffer As System.IntPtr, bufferLength As Integer, ByRef bytesWritten As Integer) As Boolean
            End Function

            Public Shared Function PrintRaw(printerName As String, origString As String) As Boolean
                Dim docinfo As RestaurantPOS14.ModCashDrawer.RawPrinter.DOCINFO = DirectCast(Nothing, Global.RestaurantPOS14.ModCashDrawer.RawPrinter.DOCINFO)
                Dim length As Integer = origString.Length
                Dim intPtr As System.IntPtr = System.Runtime.InteropServices.Marshal.StringToCoTaskMemAnsi(origString)
                docinfo.pDocName = "OpenDrawer"
                docinfo.pDataType = "RAW"
                Try
                    Dim hPrinter As System.IntPtr = System.IntPtr.Zero
                    Call RestaurantPOS14.ModCashDrawer.RawPrinter.OpenPrinter(printerName, hPrinter, 0)
                    Call RestaurantPOS14.ModCashDrawer.RawPrinter.StartDocPrinter(hPrinter, 1, docinfo)
                    Call RestaurantPOS14.ModCashDrawer.RawPrinter.StartPagePrinter(hPrinter)
                    Dim num As Integer = 0
                    Call RestaurantPOS14.ModCashDrawer.RawPrinter.WritePrinter(hPrinter, intPtr, length, num)
                    Call RestaurantPOS14.ModCashDrawer.RawPrinter.EndPagePrinter(hPrinter)
                    Call RestaurantPOS14.ModCashDrawer.RawPrinter.EndDocPrinter(hPrinter)
                    Call RestaurantPOS14.ModCashDrawer.RawPrinter.ClosePrinter(hPrinter)
                    Return True
                Catch ex As System.Exception
                    Call Microsoft.VisualBasic.Interaction.MsgBox("Error occurred: " & ex.ToString())
                    Return False
                Finally
                    Call System.Runtime.InteropServices.Marshal.FreeCoTaskMem(intPtr)
                End Try
            End Function
        End Class
    End Class
End Namespace
