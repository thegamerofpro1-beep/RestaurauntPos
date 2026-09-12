Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Runtime.InteropServices

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.StandardModuleAttribute>
    Friend NotInheritable Class ModCashDrawer
        Private Const DrawerPulse As String = ChrW(27) & "p0@@"

        Private Sub New()
        End Sub

        ''' <summary>
        ''' Opens the drawer configured for a till. A missing/disabled setting is a
        ''' normal false result with no error text; database, printer, and driver
        ''' failures return a user-readable error and are logged.
        ''' </summary>
        Public Shared Function TryOpenConfiguredDrawer(tillID As String,
                                                       ByRef errorMessage As String) As Boolean
            errorMessage = String.Empty

            Dim printerName As String = String.Empty
            If Not TryResolveConfiguredPrinter(tillID, printerName, errorMessage) Then
                Return False
            End If

            Dim rawError As String = String.Empty
            If Not RawPrinter.TryPrintRaw(printerName, DrawerPulse, rawError) Then
                errorMessage = "Cash Drawer could not be opened through printer '" &
                               printerName & "'. " & rawError
                Return False
            End If

            Return True
        End Function

        Public Shared Function TryResolveConfiguredPrinter(tillID As String,
                                                           ByRef printerName As String,
                                                           ByRef errorMessage As String) As Boolean
            printerName = String.Empty
            errorMessage = String.Empty

            Dim resolvedTillID = If(tillID, String.Empty).Trim()
            If String.IsNullOrWhiteSpace(resolvedTillID) Then
                resolvedTillID = System.Net.Dns.GetHostName()
            End If

            Try
                If String.IsNullOrWhiteSpace(RestaurantPOS14.ConnectionString.cs) Then
                    errorMessage = "The database connection is not configured."
                    Return False
                End If

                Const sql =
                    "SELECT TOP (1) NULLIF(LTRIM(RTRIM(PrinterName)), '') " &
                    "FROM dbo.POSPrinterSetting " &
                    "WHERE LTRIM(RTRIM(TillID))=@TillID " &
                    "AND LTRIM(RTRIM(IsEnabled))='Yes' " &
                    "AND LTRIM(RTRIM(CashDrawer))='Enabled' " &
                    "ORDER BY ID DESC"

                Using connection As New SqlConnection(RestaurantPOS14.ConnectionString.cs),
                      command As New SqlCommand(sql, connection)
                    command.Parameters.Add("@TillID", SqlDbType.NVarChar, 128).Value = resolvedTillID
                    connection.Open()
                    Dim value = command.ExecuteScalar()
                    If value Is Nothing OrElse value Is DBNull.Value Then
                        ' Disabled or unconfigured drawers are intentionally silent
                        ' during automatic cash settlement.
                        Return False
                    End If

                    printerName = Convert.ToString(value).Trim()
                End Using

                Return Not String.IsNullOrWhiteSpace(printerName)
            Catch ex As Exception
                RestaurantPOS14.Diagnostics.ApplicationDiagnostics.ReportNonFatal(
                    "Resolve Cash Drawer printer for till " & resolvedTillID, ex)
                errorMessage = "Cash Drawer settings could not be read. " &
                               ex.GetBaseException().Message
                Return False
            End Try
        End Function

        Public Class RawPrinter

            <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Unicode)>
            Public Structure DOCINFO
                <MarshalAs(UnmanagedType.LPWStr)>
                Public pDocName As String

                <MarshalAs(UnmanagedType.LPWStr)>
                Public pOutputFile As String

                <MarshalAs(UnmanagedType.LPWStr)>
                Public pDataType As String
            End Structure

            Private Sub New()
            End Sub

            <DllImport("winspool.drv", CallingConvention:=CallingConvention.StdCall,
                       CharSet:=CharSet.Unicode, EntryPoint:="OpenPrinterW",
                       ExactSpelling:=True, SetLastError:=True)>
            Private Shared Function OpenPrinter(printerName As String,
                                                ByRef hPrinter As IntPtr,
                                                printerDefaults As IntPtr) As Boolean
            End Function

            <DllImport("winspool.drv", CallingConvention:=CallingConvention.StdCall,
                       CharSet:=CharSet.Unicode, ExactSpelling:=True, SetLastError:=True)>
            Private Shared Function ClosePrinter(hPrinter As IntPtr) As Boolean
            End Function

            <DllImport("winspool.drv", CallingConvention:=CallingConvention.StdCall,
                       CharSet:=CharSet.Unicode, EntryPoint:="StartDocPrinterW",
                       ExactSpelling:=True, SetLastError:=True)>
            Private Shared Function StartDocPrinter(hPrinter As IntPtr,
                                                    level As Integer,
                                                    ByRef documentInfo As DOCINFO) As Integer
            End Function

            <DllImport("winspool.drv", CallingConvention:=CallingConvention.StdCall,
                       CharSet:=CharSet.Unicode, ExactSpelling:=True, SetLastError:=True)>
            Private Shared Function EndDocPrinter(hPrinter As IntPtr) As Boolean
            End Function

            <DllImport("winspool.drv", CallingConvention:=CallingConvention.StdCall,
                       CharSet:=CharSet.Unicode, ExactSpelling:=True, SetLastError:=True)>
            Private Shared Function StartPagePrinter(hPrinter As IntPtr) As Boolean
            End Function

            <DllImport("winspool.drv", CallingConvention:=CallingConvention.StdCall,
                       CharSet:=CharSet.Unicode, ExactSpelling:=True, SetLastError:=True)>
            Private Shared Function EndPagePrinter(hPrinter As IntPtr) As Boolean
            End Function

            <DllImport("winspool.drv", CallingConvention:=CallingConvention.StdCall,
                       CharSet:=CharSet.Unicode, ExactSpelling:=True, SetLastError:=True)>
            Private Shared Function WritePrinter(hPrinter As IntPtr,
                                                 buffer As IntPtr,
                                                 bufferLength As Integer,
                                                 ByRef bytesWritten As Integer) As Boolean
            End Function

            Public Shared Function PrintRaw(printerName As String, origString As String) As Boolean
                Dim ignoredError As String = String.Empty
                Return TryPrintRaw(printerName, origString, ignoredError)
            End Function

            Public Shared Function TryPrintRaw(printerName As String,
                                               origString As String,
                                               ByRef errorMessage As String) As Boolean
                errorMessage = String.Empty
                If String.IsNullOrWhiteSpace(printerName) Then
                    errorMessage = "No receipt printer is configured for the cash drawer."
                    Return False
                End If
                If String.IsNullOrEmpty(origString) Then
                    errorMessage = "The cash-drawer command is empty."
                    Return False
                End If

                Dim hPrinter As IntPtr = IntPtr.Zero
                Dim buffer As IntPtr = IntPtr.Zero
                Dim documentStarted As Boolean = False
                Dim pageStarted As Boolean = False

                Try
                    If Not OpenPrinter(printerName.Trim(), hPrinter, IntPtr.Zero) OrElse
                       hPrinter = IntPtr.Zero Then
                        Throw CreateWin32Exception(
                            "Windows could not open the configured receipt printer.")
                    End If

                    Dim documentInfo As New DOCINFO With {
                        .pDocName = "Open Cash Drawer",
                        .pOutputFile = Nothing,
                        .pDataType = "RAW"
                    }
                    If StartDocPrinter(hPrinter, 1, documentInfo) = 0 Then
                        Throw CreateWin32Exception(
                            "Windows could not start the cash-drawer print job.")
                    End If
                    documentStarted = True

                    If Not StartPagePrinter(hPrinter) Then
                        Throw CreateWin32Exception(
                            "Windows could not start the cash-drawer printer page.")
                    End If
                    pageStarted = True

                    Dim byteCount = System.Text.Encoding.Default.GetByteCount(origString)
                    buffer = Marshal.StringToCoTaskMemAnsi(origString)
                    Dim bytesWritten As Integer = 0
                    If Not WritePrinter(hPrinter, buffer, byteCount, bytesWritten) Then
                        Throw CreateWin32Exception(
                            "Windows could not send the cash-drawer command.")
                    End If
                    If bytesWritten <> byteCount Then
                        Throw New IOException(
                            "The printer accepted only " & bytesWritten.ToString() &
                            " of " & byteCount.ToString() & " cash-drawer command bytes.")
                    End If

                    Return True
                Catch ex As Exception
                    RestaurantPOS14.Diagnostics.ApplicationDiagnostics.ReportNonFatal(
                        "Open Cash Drawer through printer " & printerName, ex)
                    errorMessage = ex.GetBaseException().Message
                    Return False
                Finally
                    If pageStarted Then EndPagePrinter(hPrinter)
                    If documentStarted Then EndDocPrinter(hPrinter)
                    If hPrinter <> IntPtr.Zero Then ClosePrinter(hPrinter)
                    If buffer <> IntPtr.Zero Then Marshal.FreeCoTaskMem(buffer)
                End Try
            End Function

            Private Shared Function CreateWin32Exception(message As String) As Exception
                Dim errorCode = Marshal.GetLastWin32Error()
                If errorCode = 0 Then Return New InvalidOperationException(message)
                Return New Win32Exception(errorCode, message)
            End Function
        End Class
    End Class
End Namespace
