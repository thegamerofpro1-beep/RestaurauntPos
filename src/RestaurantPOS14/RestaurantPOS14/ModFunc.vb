Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing.Printing
Imports System.IO
Imports System.Net
Imports System.Net.Mail
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports CrystalDecisions.CrystalReports.Engine
Imports Microsoft.Office.Interop.Excel
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports RestaurantPOS14.My

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.StandardModuleAttribute>
    Friend NotInheritable Class ModFunc
        Private Shared st As String
        Private Shared ReadOnly UserRightsCacheSync As New Object()
        Private Shared CachedUserRightsUserId As String = String.Empty
        Private Shared CachedUserRightsLoaded As Boolean
        Private Shared CachedUserRights As New System.Collections.Generic.Dictionary(Of String, UserPermissionFlags)(System.StringComparer.OrdinalIgnoreCase)

        Private NotInheritable Class UserPermissionFlags
            Public SaveAllowed As Boolean
            Public UpdateAllowed As Boolean
            Public DeleteAllowed As Boolean
            Public ViewAllowed As Boolean
        End Class
        <System.Runtime.InteropServices.DllImportAttribute("kernel32.dll", SetLastError:=True)>
        Private Shared Function Wow64DisableWow64FsRedirection(ByRef oldValue As System.IntPtr) As Boolean
        End Function
        <System.Runtime.InteropServices.DllImportAttribute("kernel32.dll", SetLastError:=True)>
        Private Shared Function Wow64RevertWow64FsRedirection(oldValue As System.IntPtr) As Boolean
        End Function
        Public Shared Sub OSKeyboard()
            Dim oldValue As System.IntPtr = System.IntPtr.Zero
            Dim redirectionDisabled As Boolean = False
            Try
                If System.Environment.Is64BitOperatingSystem AndAlso Not System.Environment.Is64BitProcess Then
                    redirectionDisabled = RestaurantPOS14.ModFunc.Wow64DisableWow64FsRedirection(oldValue)
                End If
                Dim startInfo As New System.Diagnostics.ProcessStartInfo("osk.exe") With {.UseShellExecute = True}
                Call System.Diagnostics.Process.Start(startInfo)
            Catch ex As System.Exception
                RestaurantPOS14.Diagnostics.ApplicationDiagnostics.ReportNonFatal("Open on-screen keyboard", ex)
                Call System.Windows.Forms.MessageBox.Show("The Windows on-screen keyboard could not be opened.", "Keyboard", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning)
            Finally
                If redirectionDisabled Then RestaurantPOS14.ModFunc.Wow64RevertWow64FsRedirection(oldValue)
            End Try
        End Sub

        Public Shared Function CheckForInternetConnection() As Boolean
            Try
                Dim uri = RestaurantPOS14.Security.ExternalResourceGuard.RequireHttpUri("https://www.google.com/generate_204", False)
                Dim request = RestaurantPOS14.Security.ExternalResourceGuard.CreateRequest(uri, 5000)
                request.Method = "HEAD"
                Using response = DirectCast(request.GetResponse(), System.Net.HttpWebResponse)
                    Return CInt(response.StatusCode) >= 200 AndAlso CInt(response.StatusCode) < 400
                End Using
            Catch ex As System.Exception
                RestaurantPOS14.Diagnostics.ApplicationDiagnostics.ReportNonFatal("Internet connectivity check", ex)
                Return False
            End Try
        End Function

        Public Shared Function SendMail(s1 As String, s2 As String, s3 As String, s5 As String, s6 As String, s7 As Integer, s8 As String, s9 As String) As Boolean
            Try
                If String.IsNullOrWhiteSpace(s6) Then Throw New ArgumentException("The SMTP server is not configured.")
                If s7 < 1 OrElse s7 > 65535 Then Throw New ArgumentOutOfRangeException(NameOf(s7), "The SMTP port is invalid.")
                Using mailMessage As New System.Net.Mail.MailMessage()
                    mailMessage.From = New System.Net.Mail.MailAddress(s1)
                    mailMessage.[To].Add(New System.Net.Mail.MailAddress(s2))
                    mailMessage.Body = If(s3, String.Empty)
                    mailMessage.IsBodyHtml = True
                    mailMessage.Subject = If(s5, String.Empty)
                    Using smtpClient As New System.Net.Mail.SmtpClient(s6.Trim(), s7)
                        smtpClient.Credentials = New System.Net.NetworkCredential(s8, s9)
                        smtpClient.EnableSsl = True
                        smtpClient.Timeout = 30000
                        smtpClient.Send(mailMessage)
                    End Using
                End Using
                Return True
            Catch ex As System.Exception
                RestaurantPOS14.Diagnostics.ApplicationDiagnostics.ReportNonFatal("Send email", ex)
                Call System.Windows.Forms.MessageBox.Show("The email could not be sent. Check the email settings and connection.", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                Return False
            End Try
        End Function

        Public Shared Sub SendMail1(s1 As String, s2 As String, s3 As String, s4 As String, s5 As String, s6 As String, s7 As Integer, s8 As String, s9 As String)
            Try
                If String.IsNullOrWhiteSpace(s6) Then Throw New ArgumentException("The SMTP server is not configured.")
                If s7 < 1 OrElse s7 > 65535 Then Throw New ArgumentOutOfRangeException(NameOf(s7), "The SMTP port is invalid.")
                If String.IsNullOrWhiteSpace(s4) OrElse Not System.IO.File.Exists(s4) Then Throw New System.IO.FileNotFoundException("The email attachment was not found.", s4)
                Using mailMessage As New System.Net.Mail.MailMessage()
                    mailMessage.From = New System.Net.Mail.MailAddress(s1)
                    mailMessage.[To].Add(New System.Net.Mail.MailAddress(s2))
                    mailMessage.Body = If(s3, String.Empty)
                    mailMessage.Attachments.Add(New System.Net.Mail.Attachment(s4))
                    mailMessage.IsBodyHtml = True
                    mailMessage.Subject = If(s5, String.Empty)
                    Using smtpClient As New System.Net.Mail.SmtpClient(s6.Trim(), s7)
                        smtpClient.Credentials = New System.Net.NetworkCredential(s8, s9)
                        smtpClient.EnableSsl = True
                        smtpClient.Timeout = 30000
                        smtpClient.Send(mailMessage)
                    End Using
                End Using
            Catch ex As System.Exception
                RestaurantPOS14.Diagnostics.ApplicationDiagnostics.ReportNonFatal("Send email attachment", ex)
                Call System.Windows.Forms.MessageBox.Show("The email could not be sent. Check the attachment, email settings, and connection.", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Shared Function IsConnectionAvailable() As Boolean
            Return CheckForInternetConnection()
        End Function

        Public Shared Sub LogFunc(st1 As String, st2 As String)
            Try
                Using connection As New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    connection.Open()
                    Using command As New System.Data.SqlClient.SqlCommand("insert into Logs(UserID,Date,Operation) VALUES (@d1,@d2,@d3)", connection)
                        command.Parameters.Add("@d1", System.Data.SqlDbType.NVarChar, 100).Value = If(st1, String.Empty)
                        command.Parameters.Add("@d2", System.Data.SqlDbType.DateTime).Value = System.DateTime.Now
                        command.Parameters.Add("@d3", System.Data.SqlDbType.NVarChar, -1).Value = If(st2, String.Empty)
                        command.ExecuteNonQuery()
                    End Using
                End Using
            Catch ex As System.Exception
                RestaurantPOS14.Diagnostics.ApplicationDiagnostics.ReportNonFatal("Write audit log", ex)
            End Try
        End Sub

        Public Shared Sub LogFuncAsync(st1 As String, st2 As String)
            ' Audit logging must not hold the navigation UI while SQL Server writes
            ' a non-critical login record. LogFunc already records and contains any
            ' database failure, so this fire-and-forget task is safe for the caller.
            System.Threading.Tasks.Task.Run(Sub() LogFunc(st1, st2))
        End Sub

        Public Shared Sub SMSFunc(st1 As String, st2 As String, st3 As String)
            If String.IsNullOrWhiteSpace(st3) Then Throw New InvalidOperationException("The SMS service URL is not configured.")
            Dim endpoint = st3.Replace("@MobileNo", System.Uri.EscapeDataString(If(st1, String.Empty))).Replace("@Message", System.Uri.EscapeDataString(If(st2, String.Empty)))
            Dim uri = RestaurantPOS14.Security.ExternalResourceGuard.RequireHttpUri(endpoint, True)
            Dim request = RestaurantPOS14.Security.ExternalResourceGuard.CreateRequest(uri, 15000)
            request.Method = "GET"
            Using response = DirectCast(request.GetResponse(), System.Net.HttpWebResponse)
                If CInt(response.StatusCode) < 200 OrElse CInt(response.StatusCode) >= 300 Then
                    Throw New System.Net.WebException("The SMS service returned HTTP " & CInt(response.StatusCode).ToString() & ".")
                End If
            End Using
        End Sub

        Public Shared Function Encrypt(password As String) As String
            If password Is Nothing Then Throw New System.ArgumentNullException(NameOf(password))
            Return System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(password))
        End Function

        Public Shared Function Decrypt(encryptpwd As String) As String
            If String.IsNullOrWhiteSpace(encryptpwd) Then Return String.Empty
            If RestaurantPOS14.Security.PinSecurity.IsStrongHash(encryptpwd) Then Return "••••"
            Dim decoder As System.Text.Decoder = New System.Text.UTF8Encoding().GetDecoder()
            Dim array As Byte()
            Try
                array = System.Convert.FromBase64String(encryptpwd.Trim())
            Catch ex As System.FormatException
                RestaurantPOS14.Diagnostics.ApplicationDiagnostics.ReportNonFatal("Decode legacy protected value", ex)
                Return String.Empty
            End Try
            Dim array2 As Char() = New Char(decoder.GetCharCount(array, 0, array.Length) - 1 + 1 - 1) {}
            decoder.GetChars(array, 0, array.Length, array2, 0)
            Return New String(array2)
        End Function

        Public Shared Function SafeDivide(numerator As Double, denominator As Double) As Double
            If Double.IsNaN(numerator) OrElse Double.IsInfinity(numerator) Then Return 0.0
            If Double.IsNaN(denominator) OrElse Double.IsInfinity(denominator) OrElse Math.Abs(denominator) < 0.000000000001 Then Return 0.0
            Return numerator / denominator
        End Function

        Public Shared Sub RefreshRecord2()
            CType(System.Windows.Forms.Application.OpenForms(CStr(("frmDish"))), RestaurantPOS14.frmMenuItem).fillCombo()
        End Sub

        Public Shared Sub RefreshRecord3()
            CType(System.Windows.Forms.Application.OpenForms(CStr(("frmRestaurantPOS"))), RestaurantPOS14.frmPOS).fillTableNo()
        End Sub

        Public Shared Sub copyAlltoClipboard(st As Object)
            Call Microsoft.VisualBasic.CompilerServices.NewLateBinding.LateSet(st, Nothing, "RowHeadersVisible", New Object(0) {False}, Nothing, Nothing)
            Call Microsoft.VisualBasic.CompilerServices.NewLateBinding.LateSet(st, Nothing, "MultiSelect", New Object(0) {True}, Nothing, Nothing)
            Call Microsoft.VisualBasic.CompilerServices.NewLateBinding.LateCall(st, Nothing, "SelectAll", New Object(-1) {}, Nothing, Nothing, Nothing, IgnoreReturn:=True)
            Dim dataObject As System.Windows.Forms.DataObject = CType(Microsoft.VisualBasic.CompilerServices.NewLateBinding.LateGet(st, Nothing, "GetClipboardContent", New Object(-1) {}, Nothing, Nothing, Nothing), System.Windows.Forms.DataObject)
            If dataObject IsNot Nothing Then
                Call System.Windows.Forms.Clipboard.SetDataObject(dataObject)
            End If
        End Sub

        Public Shared Sub ExportExcel(st As Object)
            If System.Type.GetTypeFromProgID("Excel.Application") Is Nothing Then
                Call System.Windows.Forms.MessageBox.Show("Microsoft Excel is not installed in this PC.", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                Return
            End If

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            If Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Microsoft.VisualBasic.CompilerServices.NewLateBinding.LateGet(Microsoft.VisualBasic.CompilerServices.NewLateBinding.LateGet(st, Nothing, "Rows", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "count", New Object(-1) {}, Nothing, Nothing, Nothing), 0, TextCompare:=False) Then
                Call System.Windows.Forms.MessageBox.Show("There is no any data in DataGridView for excel export.", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                Return
            End If

            Try
                Call RestaurantPOS14.ModFunc.copyAlltoClipboard(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(st))
                Dim value As Object = System.Reflection.Missing.Value
                Dim obj As Microsoft.Office.Interop.Excel.Application = CType(System.Activator.CreateInstance(System.Type.GetTypeFromCLSID(New System.Guid("00024500-0000-0000-C000-000000000046"))), Microsoft.Office.Interop.Excel.Application)
                obj.Visible = True
                Dim worksheet As Microsoft.Office.Interop.Excel.Worksheet = CType(obj.Workbooks.Add(CObj((System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(CObj((value)))))).Worksheets(1), Microsoft.Office.Interop.Excel.Worksheet)
                Dim range As Microsoft.Office.Interop.Excel.Range = CType(worksheet.Cells(1, 1), Microsoft.Office.Interop.Excel.Range)
                range.[Select]()
                worksheet.PasteSpecial(range, System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(System.Type.Missing), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(System.Type.Missing), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(System.Type.Missing), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(System.Type.Missing), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(System.Type.Missing), True)
                Call Microsoft.VisualBasic.CompilerServices.NewLateBinding.LateSetComplex(Microsoft.VisualBasic.CompilerServices.NewLateBinding.LateGet(worksheet.Rows("1:1", System.Reflection.Missing.Value), Nothing, "Font", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "FontStyle", New Object(0) {"Bold"}, Nothing, Nothing, OptimisticSet:=False, RValueBase:=True)
                Call Microsoft.VisualBasic.CompilerServices.NewLateBinding.LateSetComplex(Microsoft.VisualBasic.CompilerServices.NewLateBinding.LateGet(worksheet.Rows("1:1", System.Reflection.Missing.Value), Nothing, "Font", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Size", New Object(0) {12}, Nothing, Nothing, OptimisticSet:=False, RValueBase:=True)
                worksheet.Cells.Columns.AutoFit()
                worksheet.Cells.[Select]()
                worksheet.Cells.EntireColumn.AutoFit()
                Call Microsoft.VisualBasic.CompilerServices.NewLateBinding.LateCall(worksheet.Cells(1, 1), Nothing, "Select", New Object(-1) {}, Nothing, Nothing, Nothing, IgnoreReturn:=True)
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            Finally
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.[Default]
                Call Microsoft.VisualBasic.CompilerServices.NewLateBinding.LateCall(st, Nothing, "clearSelection", New Object(-1) {}, Nothing, Nothing, Nothing, IgnoreReturn:=True)
                Call Microsoft.VisualBasic.CompilerServices.NewLateBinding.LateSet(st, Nothing, "RowHeadersVisible", New Object(0) {True}, Nothing, Nothing)
                Call Microsoft.VisualBasic.CompilerServices.NewLateBinding.LateSet(st, Nothing, "MultiSelect", New Object(0) {False}, Nothing, Nothing)
            End Try
        End Sub

        Public Shared Function IsChecklistEnabled() As Boolean
            Return RestaurantPOS14.Configuration.SettingsHost.Current.Features.Checklist
        End Function

        Public Shared Function IsMyInvoisEnabled() As Boolean
            Return RestaurantPOS14.Configuration.SettingsHost.Current.Features.EInvoicing
        End Function

        Public Shared Sub SupplierLedgerSave(a As System.DateTime, b As String, c As String, d As String, e As Decimal, f As Decimal, g As String)
            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
            RestaurantPOS14.ModClasses.con.Open()
            RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("insert into SupplierLedgerBook(Date, Name, LedgerNo, Label,Debit,Credit,PartyID) Values (@d1,@d2,@d3,@d4,@d5,@d6,@d7)")
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", a)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", b)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", c)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", d)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d5", e)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d6", f)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d7", g)
            RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
            RestaurantPOS14.ModClasses.cmd.ExecuteReader()
            RestaurantPOS14.ModClasses.con.Close()
        End Sub

        Public Shared Sub SupplierLedgerDelete(a As String)
            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
            RestaurantPOS14.ModClasses.con.Open()
            RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("delete from SupplierLedgerBook where LedgerNo=@d1")
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", a)
            RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
            RestaurantPOS14.ModClasses.cmd.ExecuteReader()
            RestaurantPOS14.ModClasses.con.Close()
        End Sub

        Public Shared Sub SupplierLedgerUpdate(a As System.DateTime, b As String, e As Decimal, f As Decimal, g As String, h As String)
            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
            RestaurantPOS14.ModClasses.con.Open()
            RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Update SupplierLedgerBook set Date=@d1, Name=@d2,Debit=@d3,Credit=@d4 where LedgerNo=@d5 and Label=@d6")
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", a)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", b)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", e)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", f)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d5", g)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d6", h)
            RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
            RestaurantPOS14.ModClasses.cmd.ExecuteReader()
            RestaurantPOS14.ModClasses.con.Close()
        End Sub

        Public Shared Sub LedgerSave(a As System.DateTime, b As String, c As String, d As String, e As Decimal, f As Decimal, g As String, h As String)
            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
            RestaurantPOS14.ModClasses.con.Open()
            RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("insert into LedgerBook(Date, Name, LedgerNo, Label,Debit,Credit,PartyID,AccLedger) Values (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8)")
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", a)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", b)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", c)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", d)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d5", e)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d6", f)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d7", g)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d8", h)
            RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
            RestaurantPOS14.ModClasses.cmd.ExecuteReader()
            RestaurantPOS14.ModClasses.con.Close()
        End Sub

        Public Shared Sub LedgerDelete(a As String, b As String)
            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
            RestaurantPOS14.ModClasses.con.Open()
            RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("delete from LedgerBook where LedgerNo=@d1 and Label=@d2")
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", a)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", b)
            RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
            RestaurantPOS14.ModClasses.cmd.ExecuteReader()
            RestaurantPOS14.ModClasses.con.Close()
        End Sub

        Public Shared Sub LedgerUpdate(a As System.DateTime, b As String, e As Decimal, f As Decimal, g As String, h As String, i As String)
            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
            RestaurantPOS14.ModClasses.con.Open()
            RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Update LedgerBook set Date=@d1, Name=@d2,Debit=@d3,Credit=@d4,PartyID=@d5 where LedgerNo=@d6 and Label=@d7")
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", a)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", b)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", e)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", f)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d5", g)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d6", h)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d7", i)
            RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
            RestaurantPOS14.ModClasses.cmd.ExecuteReader()
            RestaurantPOS14.ModClasses.con.Close()
        End Sub

        Public Shared Sub LedgerUpdate1(a As System.DateTime, b As String, e As Decimal, f As Decimal, g As String, h As String, i As String)
            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
            RestaurantPOS14.ModClasses.con.Open()
            RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Update LedgerBook set Date=@d1, Name=@d2,Debit=@d3,Credit=@d4 where LedgerNo=@d6 and Label=@d7 and PartyID=@d5 ")
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", a)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", b)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", e)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", f)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d5", g)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d6", h)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d7", i)
            RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
            RestaurantPOS14.ModClasses.cmd.ExecuteReader()
            RestaurantPOS14.ModClasses.con.Close()
        End Sub

        Public Shared Sub CreditCustomerLedgerSave(a As System.DateTime, c As String, d As String, e As Decimal, f As Decimal, g As Integer)
            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
            RestaurantPOS14.ModClasses.con.Open()
            RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("insert into CreditCustomerLedger(Date, LedgerNo, Label,Debit,Credit,CreditCustomer_ID) Values (@d1,@d3,@d4,@d5,@d6,@d7)")
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", a)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", c)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", d)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d5", e)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d6", f)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d7", g)
            RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
            RestaurantPOS14.ModClasses.cmd.ExecuteReader()
            RestaurantPOS14.ModClasses.con.Close()
        End Sub

        Public Shared Sub CreditCustomerLedgerDelete(a As String, b As String)
            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
            RestaurantPOS14.ModClasses.con.Open()
            RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("delete from CreditCustomerLedger where LedgerNo=@d1 and Label=@d2")
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", a)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", b)
            RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
            RestaurantPOS14.ModClasses.cmd.ExecuteReader()
            RestaurantPOS14.ModClasses.con.Close()
        End Sub

        Public Shared Sub CreditCustomerLedgerUpdate(a As System.DateTime, e As Decimal, f As Decimal, g As Integer, h As String, i As String)
            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
            RestaurantPOS14.ModClasses.con.Open()
            RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Update CreditCustomerLedger set Date=@d1,Debit=@d3,Credit=@d4,CreditCustomer_ID=@d5 where LedgerNo=@d6 and Label=@d7")
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", a)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", e)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", f)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d5", g)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d6", h)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d7", i)
            RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
            RestaurantPOS14.ModClasses.cmd.ExecuteReader()
            RestaurantPOS14.ModClasses.con.Close()
        End Sub

        Public Shared Sub ODN(a As String, b As String)
            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
            RestaurantPOS14.ModClasses.con.Open()
            RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Insert into tblOrder(ODNo,BillNo) values(@d1,@d2)")
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", a)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", b)
            RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
            RestaurantPOS14.ModClasses.cmd.ExecuteReader()
            RestaurantPOS14.ModClasses.con.Close()
        End Sub

        Public Shared Sub RawMaterialUsed(st1 As Integer, st2 As String)
            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
            RestaurantPOS14.ModClasses.con.Open()
            RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("insert into RM_Used(RM_ID,BillDate,BillNo) VALUES (@d1,@d2,@d3)")
            RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", st1)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", System.DateTime.Now)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", st2)
            RestaurantPOS14.ModClasses.cmd.ExecuteReader()
            RestaurantPOS14.ModClasses.con.Close()
        End Sub

        Public Shared Sub RawMaterialUsedDel(st1 As String)
            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
            RestaurantPOS14.ModClasses.con.Open()
            RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Delete from RM_Used where BillNo=@d1")
            RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", st1)
            RestaurantPOS14.ModClasses.cmd.ExecuteReader()
            RestaurantPOS14.ModClasses.con.Close()
        End Sub

        Public Shared Sub MemberLedgerSave(a As System.DateTime, b As Integer, c As String, d As String, e As Decimal, f As Decimal, g As Integer)
            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
            RestaurantPOS14.ModClasses.con.Open()
            RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("insert into MemberLedger(Date,ID, LedgerNo, Label,Debit,Credit,MemberID) Values (@d1,@d2,@d3,@d4,@d5,@d6,@d7)")
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", a)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", b)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", c)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", d)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d5", e)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d6", f)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d7", g)
            RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
            RestaurantPOS14.ModClasses.cmd.ExecuteReader()
            RestaurantPOS14.ModClasses.con.Close()
        End Sub

        Public Shared Sub MemberLedgerDelete(a As String, b As String)
            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
            RestaurantPOS14.ModClasses.con.Open()
            RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("delete from MemberLedger where LedgerNo=@d1 and Label=@d2")
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", a)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", b)
            RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
            RestaurantPOS14.ModClasses.cmd.ExecuteReader()
            RestaurantPOS14.ModClasses.con.Close()
        End Sub

        Public Shared Sub MemberLedgerUpdate(a As System.DateTime, b As Integer, e As Decimal, f As Decimal, g As Integer, h As String, i As String)
            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
            RestaurantPOS14.ModClasses.con.Open()
            RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Update MemberLedger set Date=@d1,ID=@d2,Debit=@d3,Credit=@d4,memberID=@d5 where LedgerNo=@d6 and Label=@d7")
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", a)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", b)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", e)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", f)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d5", g)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d6", h)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d7", i)
            RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
            RestaurantPOS14.ModClasses.cmd.ExecuteReader()
            RestaurantPOS14.ModClasses.con.Close()
        End Sub

        Public Shared Sub LoyaltyCardMemberLedgerSave(a As System.DateTime, c As String, d As String, e As Integer, f As Integer, g As Integer)
            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
            RestaurantPOS14.ModClasses.con.Open()
            RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("insert into LoyaltyMemberLedgerBook(Date, LedgerNo, Label,PointsEarned,PointsRedeem,MemberID) Values (@d1,@d3,@d4,@d5,@d6,@d7)")
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", a)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", c)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", d)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d5", e)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d6", f)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d7", g)
            RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
            RestaurantPOS14.ModClasses.cmd.ExecuteReader()
            RestaurantPOS14.ModClasses.con.Close()
        End Sub

        Public Shared Sub LoyaltyCardMemberLedgerDelete(a As String, b As String)
            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
            RestaurantPOS14.ModClasses.con.Open()
            RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("delete from LoyaltyMemberLedgerBook where LedgerNo=@d1 and Label=@d2")
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", a)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", b)
            RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
            RestaurantPOS14.ModClasses.cmd.ExecuteReader()
            RestaurantPOS14.ModClasses.con.Close()
        End Sub

        Public Shared Sub ClockINSave(b As String)
            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
            RestaurantPOS14.ModClasses.con.Open()
            RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("insert into ClockIN(UserID,ClockINDate) Values (@d2,@d3)")
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", b)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", System.DateTime.Now)
            RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
            RestaurantPOS14.ModClasses.cmd.ExecuteReader()
            RestaurantPOS14.ModClasses.con.Close()
        End Sub

        Public Shared Sub ClockOUTSave(a As Integer)
            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
            RestaurantPOS14.ModClasses.con.Open()
            RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("insert into ClockOUT(ClockINID,ClockOUTDate) Values (@d2,@d3)")
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", a)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", System.DateTime.Now)
            RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
            RestaurantPOS14.ModClasses.cmd.ExecuteReader()
            RestaurantPOS14.ModClasses.con.Close()
        End Sub

        Public Shared Sub ClockINSaveX(b As String, c As System.DateTime)
            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
            RestaurantPOS14.ModClasses.con.Open()
            RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("insert into ClockIN(UserID,ClockINDate) Values (@d2,@d3)")
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", b)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", c)
            RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
            RestaurantPOS14.ModClasses.cmd.ExecuteReader()
            RestaurantPOS14.ModClasses.con.Close()
        End Sub

        Public Shared Sub ClockOUTSaveX(a As Integer, c As System.DateTime)
            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
            RestaurantPOS14.ModClasses.con.Open()
            RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("insert into ClockOUT(ClockINID,ClockOUTDate) Values (@d2,@d3)")
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", a)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", c)
            RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
            RestaurantPOS14.ModClasses.cmd.ExecuteReader()
            RestaurantPOS14.ModClasses.con.Close()
        End Sub

        Public Shared Sub BankAccountLedgerSave(a As System.DateTime, b As String, c As String, d As String, e As Decimal, f As Decimal)
            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
            RestaurantPOS14.ModClasses.con.Open()
            RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("insert into BankAccountLedger(Date,AccNo, LedgerNo, Label,Debit,Credit) Values (@d1,@d2,@d3,@d4,@d5,@d6)")
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", a)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", b)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", c)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", d)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d5", e)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d6", f)
            RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
            RestaurantPOS14.ModClasses.cmd.ExecuteReader()
            RestaurantPOS14.ModClasses.con.Close()
        End Sub

        Public Shared Sub BankAccountLedgerDelete(a As String, b As String)
            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
            RestaurantPOS14.ModClasses.con.Open()
            RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("delete from BankAccountLedger where LedgerNo=@d1 and Label=@d2")
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", a)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", b)
            RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
            RestaurantPOS14.ModClasses.cmd.ExecuteReader()
            RestaurantPOS14.ModClasses.con.Close()
        End Sub

        Public Shared Sub BankAccountLedgerUpdate(a As System.DateTime, b As String, e As Decimal, f As Decimal, h As String, i As String)
            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
            RestaurantPOS14.ModClasses.con.Open()
            RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Update BankAccountLedger set Date=@d1, AccNo=@d2,Debit=@d3,Credit=@d4 where LedgerNo=@d6 and Label=@d7")
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", a)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", b)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", e)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", f)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d6", h)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d7", i)
            RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
            RestaurantPOS14.ModClasses.cmd.ExecuteReader()
            RestaurantPOS14.ModClasses.con.Close()
        End Sub

        Public Shared Sub InvoiceDeleteFunc(a As String, b As System.DateTime, c As Decimal, d As String, e As String, f As String, g As String, h As String)
            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
            RestaurantPOS14.ModClasses.con.Open()
            RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Insert Into DeletedInvoices(BillNo, BillDate, GrandTotal, Operator, PaymentMode, Reason, DeletedDate,BillType,Canceled_Deleted) Values(@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9)")
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", a)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", b)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", c)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", d)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d5", e)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d6", f)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d7", System.DateTime.Now)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d8", g)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d9", h)
            RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
            RestaurantPOS14.ModClasses.cmd.ExecuteReader()
            RestaurantPOS14.ModClasses.con.Close()
        End Sub

        Public Shared Sub DeleteTable(a As String)
            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
            RestaurantPOS14.ModClasses.con.Open()
            RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Delete from TableLayout where TableNo=@d1")
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", a)
            RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
            RestaurantPOS14.ModClasses.cmd.ExecuteReader()
            RestaurantPOS14.ModClasses.con.Close()
        End Sub

        Public Shared Sub GetPrinterName(TillID As String, rpt As Object)
            Try
                Call RestaurantPOS14.ModFunc.ApplyServiceChargeLabelFix(rpt)
            Catch suppressedException As System.Exception
                RestaurantPOS14.Diagnostics.ApplicationDiagnostics.ReportNonFatal("Suppressed exception in ModFunc", suppressedException)
            End Try
            Dim report = TryCast(rpt, CrystalDecisions.CrystalReports.Engine.ReportDocument)
            If report Is Nothing Then Return

            Dim settings = RestaurantPOS14.Configuration.SettingsHost.Current
            ' Terminal Setting is the source of truth for the current till. Read it
            ' at print time so a printer changed during this session is used at once.
            Dim terminalPrinterName = ResolveLegacyPrinterName(TillID)
            Dim configuredPrinterName = If(String.IsNullOrWhiteSpace(terminalPrinterName), settings.Printing.DefaultPrinterName, terminalPrinterName)

            Dim resolver As New RestaurantPOS14.Customization.ReportProfileResolver(settings.Reports, configuredPrinterName)
            Dim profile = resolver.Resolve(report.GetType().Name)
            If String.IsNullOrWhiteSpace(profile.PrinterName) Then profile.PrinterName = configuredPrinterName
            Dim job As New RestaurantPOS14.Extensions.Printing.PrintJob With {
                .DocumentName = profile.ReportName,
                .PrinterName = profile.PrinterName,
                .Copies = 1,
                .Payload = report
            }
            Dim result = RestaurantPOS14.Extensions.Printing.PrintServiceHost.Current.Print(job)
            If result Is Nothing OrElse Not result.Accepted Then
                Dim message = If(result Is Nothing OrElse String.IsNullOrWhiteSpace(result.Message), "The print service did not accept the invoice.", result.Message)
                Throw New InvalidOperationException(message)
            End If

            If System.IO.Path.IsPathRooted(result.Message) AndAlso System.IO.File.Exists(result.Message) Then
                Call System.Windows.Forms.MessageBox.Show("Invoice PDF saved successfully:" & Global.Microsoft.VisualBasic.Constants.vbCrLf & result.Message, "Invoice saved", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information)
            End If
        End Sub

        Private Shared Function ResolveLegacyPrinterName(tillID As String) As String
            Dim resolvedTillID = If(tillID, String.Empty).Trim()
            If String.IsNullOrWhiteSpace(resolvedTillID) Then resolvedTillID = System.Net.Dns.GetHostName()

            Try
                Using connection As New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    connection.Open()
                    Const sql = "SELECT TOP 1 RTRIM(PrinterName) FROM dbo.POSPrinterSetting WHERE TillID=@TillID AND IsEnabled='Yes' AND NULLIF(LTRIM(RTRIM(PrinterName)),'') IS NOT NULL"
                    Using command As New System.Data.SqlClient.SqlCommand(sql, connection)
                        command.Parameters.Add("@TillID", System.Data.SqlDbType.NVarChar, 100).Value = resolvedTillID
                        Dim value = command.ExecuteScalar()
                        If value Is Nothing OrElse value Is System.DBNull.Value Then Return String.Empty
                        Return System.Convert.ToString(value).Trim()
                    End Using
                End Using
            Catch ex As Exception
                Throw New InvalidOperationException("The printer setting for till '" & resolvedTillID & "' could not be read. " & ex.Message, ex)
            End Try
        End Function

        Public Shared Sub ApplyServiceChargeLabelFix(rptObj As Object)
            Dim reportDocument As CrystalDecisions.CrystalReports.Engine.ReportDocument = TryCast(rptObj, CrystalDecisions.CrystalReports.Engine.ReportDocument)
            If reportDocument IsNot Nothing Then
                Call RestaurantPOS14.ModFunc.FixDocApplyServiceChargeLabel(reportDocument)
                ' The label cleanup above exists for reports recovered from the
                ' original application. Always normalize receipt field formulas
                ' afterwards so no legacy label conversion can make them invalid.
                RestaurantPOS14.Reporting.ReceiptReportCompatibility.Apply(reportDocument)
            End If
        End Sub

        Public Shared Function GetHoldBillTotal(st As String) As Decimal
            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
            RestaurantPOS14.ModClasses.con.Open()
            RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT SUM(IsNull(TotalAmount,0)) FROM HoldItems where BillID=@d1", RestaurantPOS14.ModClasses.con)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", st)
            Dim sqlDataReader As System.Data.SqlClient.SqlDataReader = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
            Dim value As Decimal = 0D
            If sqlDataReader.Read() AndAlso Not sqlDataReader.IsDBNull(0) Then
                value = RestaurantPOS14.Configuration.MoneyMath.RoundCurrency(System.Convert.ToDecimal(sqlDataReader.GetValue(0)))
            End If
            RestaurantPOS14.ModClasses.con.Close()
            Return value
        End Function

        Public Shared Sub HoldBillDelete(a As String)
            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
            RestaurantPOS14.ModClasses.con.Open()
            RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("delete from HoldBill where HoldID=@d1")
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", a)
            RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
            RestaurantPOS14.ModClasses.cmd.ExecuteReader()
            RestaurantPOS14.ModClasses.con.Close()
        End Sub

        Public Shared Sub ClearUserRightsCache()
            SyncLock UserRightsCacheSync
                CachedUserRightsUserId = String.Empty
                CachedUserRightsLoaded = False
                CachedUserRights = New System.Collections.Generic.Dictionary(Of String, UserPermissionFlags)(System.StringComparer.OrdinalIgnoreCase)
            End SyncLock
        End Sub

        Public Shared Function LoadUserRightsCache(userId As String) As Boolean
            Dim normalizedUserId = If(userId, String.Empty).Trim()
            Dim permissions As New System.Collections.Generic.Dictionary(Of String, UserPermissionFlags)(System.StringComparer.OrdinalIgnoreCase)

            Using connection As New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                connection.Open()
                Using command As New System.Data.SqlClient.SqlCommand("SELECT RTRIM(ModuleName), ISNULL(UR_Save,0), ISNULL(UR_Update,0), ISNULL(UR_Delete,0), ISNULL(UR_View,0) FROM UserRights WHERE UserID=@userId", connection)
                    command.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                    command.Parameters.Add("@userId", System.Data.SqlDbType.NVarChar, 100).Value = normalizedUserId
                    Using reader = command.ExecuteReader()
                        While reader.Read()
                            Dim moduleName = If(reader.IsDBNull(0), String.Empty, reader.GetString(0).Trim())
                            If moduleName.Length > 0 Then
                                permissions(moduleName) = New UserPermissionFlags With {
                                    .SaveAllowed = System.Convert.ToBoolean(reader.GetValue(1)),
                                    .UpdateAllowed = System.Convert.ToBoolean(reader.GetValue(2)),
                                    .DeleteAllowed = System.Convert.ToBoolean(reader.GetValue(3)),
                                    .ViewAllowed = System.Convert.ToBoolean(reader.GetValue(4))
                                }
                            End If
                        End While
                    End Using
                End Using
            End Using

            SyncLock UserRightsCacheSync
                CachedUserRightsUserId = normalizedUserId
                CachedUserRights = permissions
                CachedUserRightsLoaded = True
            End SyncLock
            Return permissions.Count > 0
        End Function

        Public Shared Function HasAnyUserRights(userId As String) As Boolean
            EnsureUserRightsCache(userId)
            SyncLock UserRightsCacheSync
                Return CachedUserRights.Count > 0
            End SyncLock
        End Function

        Public Shared Function IsSaveAllowed(UserID As String, ModuleName As String) As Boolean
            Return GetUserPermission(UserID, ModuleName, 0)
        End Function

        Public Shared Function IsViewAllowed(UserID As String, ModuleName As String) As Boolean
            Return GetUserPermission(UserID, ModuleName, 3)
        End Function

        Public Shared Function IsUpdateAllowed(UserID As String, ModuleName As String) As Boolean
            Return GetUserPermission(UserID, ModuleName, 1)
        End Function

        Public Shared Function IsDeleteAllowed(UserID As String, ModuleName As String) As Boolean
            Return GetUserPermission(UserID, ModuleName, 2)
        End Function

        Private Shared Sub EnsureUserRightsCache(userId As String)
            Dim normalizedUserId = If(userId, String.Empty).Trim()
            SyncLock UserRightsCacheSync
                If CachedUserRightsLoaded AndAlso String.Equals(CachedUserRightsUserId, normalizedUserId, StringComparison.OrdinalIgnoreCase) Then Return
            End SyncLock
            LoadUserRightsCache(normalizedUserId)
        End Sub

        Private Shared Function GetUserPermission(userId As String, moduleName As String, permissionIndex As Integer) As Boolean
            EnsureUserRightsCache(userId)
            Dim flags As UserPermissionFlags = Nothing
            SyncLock UserRightsCacheSync
                If Not CachedUserRights.TryGetValue(If(moduleName, String.Empty).Trim(), flags) Then Return False
                Select Case permissionIndex
                    Case 0
                        Return flags.SaveAllowed
                    Case 1
                        Return flags.UpdateAllowed
                    Case 2
                        Return flags.DeleteAllowed
                    Case 3
                        Return flags.ViewAllowed
                    Case Else
                        Return False
                End Select
            End SyncLock
        End Function

        Public Shared Function GetParamValue(st As String, st1 As System.DateTime, st2 As System.DateTime) As Double
            Call System.Data.SqlClient.SqlConnection.ClearAllPools()
            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
            RestaurantPOS14.ModClasses.con.Open()
            RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand(st, RestaurantPOS14.ModClasses.con)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", st1)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", st2)
            RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
            Dim sqlDataReader As System.Data.SqlClient.SqlDataReader = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
            Dim result As Double = 0.0
            If sqlDataReader.Read() AndAlso Not sqlDataReader.IsDBNull(0) Then
                result = System.Convert.ToDouble(RestaurantPOS14.Configuration.MoneyMath.RoundCurrency(System.Convert.ToDecimal(sqlDataReader.GetValue(0))))
            End If
            RestaurantPOS14.ModClasses.con.Close()
            Return result
        End Function

        Public Shared Function DBBackupLocation() As String
            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
            RestaurantPOS14.ModClasses.con.Open()
            RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT RTRIM(DBLocation) from hotel", RestaurantPOS14.ModClasses.con)
            Dim sqlDataReader As System.Data.SqlClient.SqlDataReader = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
            Dim result As String = (If((Not sqlDataReader.Read()), "", sqlDataReader.GetValue(CInt((0))).ToString()))
            RestaurantPOS14.ModClasses.con.Close()
            Return result
        End Function

        Public Shared Function AutoLogoutWaiter(UName As String) As String
            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
            RestaurantPOS14.ModClasses.con.Open()
            RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT RTRIM(AutoLogout) from Registration where UserType='Waiter' and UserID=@d1", RestaurantPOS14.ModClasses.con)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", UName)
            Dim sqlDataReader As System.Data.SqlClient.SqlDataReader = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
            Dim result As String = (If((Not sqlDataReader.Read()), "", sqlDataReader.GetValue(CInt((0))).ToString()))
            RestaurantPOS14.ModClasses.con.Close()
            Return result
        End Function

        Public Shared Function TLAP() As String
            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
            RestaurantPOS14.ModClasses.con.Open()
            RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT RTRIM(TLAP) from OtherSetting", RestaurantPOS14.ModClasses.con)
            Dim sqlDataReader As System.Data.SqlClient.SqlDataReader = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
            Dim result As String = (If((Not sqlDataReader.Read()), "", sqlDataReader.GetValue(CInt((0))).ToString()))
            RestaurantPOS14.ModClasses.con.Close()
            Return result
        End Function

        Public Shared Function GetVATPer(st As String) As Decimal
            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
            RestaurantPOS14.ModClasses.con.Open()
            RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT VAT from Category where CategoryName=@d1", RestaurantPOS14.ModClasses.con)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", st)
            Dim sqlDataReader As System.Data.SqlClient.SqlDataReader = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
            Dim value As Double = 0.0
            If sqlDataReader.Read() Then
                value = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(sqlDataReader.GetValue(0))
            End If

            RestaurantPOS14.ModClasses.con.Close()
            Return New Decimal(value)
        End Function

        Public Shared Function ReadLC() As String
            Using streamReader As System.IO.StreamReader = New System.IO.StreamReader(System.Windows.Forms.Application.StartupPath & "\LC.txt")
                RestaurantPOS14.ModFunc.st = streamReader.ReadLine()
            End Using

            Return RestaurantPOS14.ModFunc.st
        End Function

        Public Shared Function HandleTrialRegistry() As Boolean
            Dim dateTime As System.DateTime = Microsoft.VisualBasic.CompilerServices.Conversions.ToDate(RestaurantPOS14.My.MyProject.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\DotNetFramework45", "Set", Nothing))
            If System.DateTime.Compare(dateTime, System.DateTime.MinValue) = 0 Then
                dateTime = System.DateTime.Today.[Date]
                Call RestaurantPOS14.My.MyProject.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\DotNetFramework45", "Set", dateTime)
            ElseIf (Microsoft.VisualBasic.DateAndTime.Now - dateTime).Days > 15 Then
                Return False
            End If

            Return True
        End Function

        Public Shared Function HandleFirstRunDate() As Boolean
            Dim dateTime As System.DateTime = Microsoft.VisualBasic.CompilerServices.Conversions.ToDate(RestaurantPOS14.My.MyProject.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\DotNetFramework45X", "Set", Nothing))
            If System.DateTime.Compare(dateTime, System.DateTime.MinValue) = 0 Then
                dateTime = System.DateTime.Today.[Date]
                Call RestaurantPOS14.My.MyProject.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\DotNetFramework45X", "Set", dateTime)
            ElseIf System.DateTime.Compare(Microsoft.VisualBasic.DateAndTime.Today, dateTime) < 0 Then
                Return False
            End If

            Return True
        End Function

        Public Shared Function HandleRenewalRegistry() As Boolean
            Dim dateTime As System.DateTime = Microsoft.VisualBasic.CompilerServices.Conversions.ToDate(RestaurantPOS14.My.MyProject.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\DotNetFramework45", "Set", Nothing))
            If System.DateTime.Compare(dateTime, System.DateTime.MinValue) = 0 Then
                dateTime = System.DateTime.Today.[Date]
                Call RestaurantPOS14.My.MyProject.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\DotNetFramework45", "Set", dateTime)
            ElseIf (dateTime - Microsoft.VisualBasic.DateAndTime.Today).Days <= 0 Then
                Return False
            End If

            Return True
        End Function

        Friend Shared Sub FixDocApplyServiceChargeLabel(d As CrystalDecisions.CrystalReports.Engine.ReportDocument)

            Dim textObject As CrystalDecisions.CrystalReports.Engine.TextObject = Nothing, text As String = Nothing, fieldHeadingObject As CrystalDecisions.CrystalReports.Engine.FieldHeadingObject = Nothing, text2 As String = Nothing
            For Each section As CrystalDecisions.CrystalReports.Engine.Section In d.ReportDefinition.Sections
                For Each reportObject As CrystalDecisions.CrystalReports.Engine.ReportObject In section.ReportObjects
                    textObject = TryCast(reportObject, CrystalDecisions.CrystalReports.Engine.TextObject)
                    text = If(textObject Is Nothing, Nothing, textObject.Text)
                    If textObject IsNot Nothing AndAlso text IsNot Nothing Then
                        If text.IndexOf("VAT", System.StringComparison.OrdinalIgnoreCase) >= 0 Then
                            textObject.Text = text.Replace(CStr(("VAT%")), CStr(("service charge"))).Replace(CStr(("VAT :")), CStr(("service charge"))).Replace("VAT", "service charge")
                            text = textObject.Text
                        End If

                        If text.IndexOf("Service Charge", System.StringComparison.OrdinalIgnoreCase) >= 0 AndAlso text.IndexOf("service charge", System.StringComparison.OrdinalIgnoreCase) < 0 Then
                            textObject.Text = System.Text.RegularExpressions.Regex.Replace(text, "(?i)service\s*charge(\s*%)?\s*:", "service charge")
                            If textObject.Text.Equals(text, System.StringComparison.Ordinal) Then
                                textObject.Text = "service charge"
                            End If
                        End If
                    End If

                    fieldHeadingObject = TryCast(reportObject, CrystalDecisions.CrystalReports.Engine.FieldHeadingObject)
                    text2 = If(fieldHeadingObject Is Nothing, Nothing, fieldHeadingObject.Text)
                    If Not (fieldHeadingObject IsNot Nothing AndAlso text2 IsNot Nothing) Then
                        Continue For
                    End If

                    If text2.IndexOf("VAT", System.StringComparison.OrdinalIgnoreCase) >= 0 Then
                        fieldHeadingObject.Text = text2.Replace(CStr(("VAT%")), CStr(("service charge"))).Replace(CStr(("VAT :")), CStr(("service charge"))).Replace("VAT", "service charge")
                        text2 = fieldHeadingObject.Text
                    End If

                    If text2.IndexOf("Service Charge", System.StringComparison.OrdinalIgnoreCase) >= 0 AndAlso text2.IndexOf("service charge", System.StringComparison.OrdinalIgnoreCase) < 0 Then
                        fieldHeadingObject.Text = System.Text.RegularExpressions.Regex.Replace(text2, "(?i)service\s*charge(\s*%)?\s*:", "service charge")
                        If fieldHeadingObject.Text.Equals(text2, System.StringComparison.Ordinal) Then
                            fieldHeadingObject.Text = "service charge"
                        End If
                    End If
                Next
            Next

            For i As Integer = 0 To d.DataDefinition.FormulaFields.Count - 1
                Dim formulaFieldDefinition As CrystalDecisions.CrystalReports.Engine.FormulaFieldDefinition = d.DataDefinition.FormulaFields(i)
                Dim text3 As String = formulaFieldDefinition.Text
                If Equals(text3, Nothing) Then
                    Continue For
                End If

                ' Never perform display-label replacement inside a formula that
                ' references database fields. The old unrestricted Replace changed
                ' {Restaurant_OrderedProduct.VATPer} into a non-existent field and
                ' caused upgraded PCs to fail every receipt at render time.
                If text3.IndexOf("{", System.StringComparison.Ordinal) >= 0 Then
                    Continue For
                End If

                If text3.IndexOf("VAT", System.StringComparison.OrdinalIgnoreCase) >= 0 Then
                    formulaFieldDefinition.Text = text3.Replace(CStr(("VAT%")), CStr(("service charge"))).Replace(CStr(("VAT :")), CStr(("service charge"))).Replace("VAT", "service charge")
                    text3 = formulaFieldDefinition.Text
                End If

                If text3.IndexOf("Service Charge", System.StringComparison.OrdinalIgnoreCase) >= 0 AndAlso text3.IndexOf("service charge", System.StringComparison.OrdinalIgnoreCase) < 0 Then
                    formulaFieldDefinition.Text = System.Text.RegularExpressions.Regex.Replace(text3, "(?i)service\s*charge(\s*%)?\s*:", "service charge")
                    If formulaFieldDefinition.Text.Equals(text3, System.StringComparison.Ordinal) Then
                        formulaFieldDefinition.Text = "service charge"
                    End If
                End If
            Next

            For j As Integer = 0 To d.Subreports.Count - 1
                Call RestaurantPOS14.ModFunc.FixDocApplyServiceChargeLabel(d.Subreports(j))
            Next
        End Sub

    End Class
End Namespace
