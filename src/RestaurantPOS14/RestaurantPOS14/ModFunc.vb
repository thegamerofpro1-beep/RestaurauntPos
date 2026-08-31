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
        <System.Runtime.InteropServices.DllImportAttribute("kernel32", CharSet:=System.Runtime.InteropServices.CharSet.Ansi, ExactSpelling:=True, SetLastError:=True)>
        Public Shared Function Wow64DisableWow64FsRedirection(ByRef oldvalue As Long) As Boolean
        End Function
        <System.Runtime.InteropServices.DllImportAttribute("kernel32", CharSet:=System.Runtime.InteropServices.CharSet.Ansi, ExactSpelling:=True, SetLastError:=True)>
        Public Shared Function Wow64EnableWow64FsRedirection(ByRef oldvalue As Long) As Boolean
        End Function
        Public Shared Sub OSKeyboard()
            Dim num As Long = 0L
            If System.Environment.Is64BitOperatingSystem Then
                Call System.Diagnostics.Process.Start("osk.exe")
            ElseIf RestaurantPOS14.ModFunc.Wow64DisableWow64FsRedirection(num) Then
                Call System.Diagnostics.Process.Start("osk.exe")
                Call RestaurantPOS14.ModFunc.Wow64EnableWow64FsRedirection(num)
            End If
        End Sub

        Public Shared Function CheckForInternetConnection() As Boolean
            Try
                Using webClient As System.Net.WebClient = New System.Net.WebClient()
                    Using webClient.OpenRead("http://www.google.com")
                        Return True
                    End Using
                End Using
            Catch __unusedException1__ As System.Exception
                Return False
            End Try
        End Function

        Public Shared Sub SendMail(s1 As String, s2 As String, s3 As String, s5 As String, s6 As String, s7 As Integer, s8 As String, s9 As String)
            Dim mailMessage As System.Net.Mail.MailMessage = New System.Net.Mail.MailMessage()
            Try
                mailMessage.From = New System.Net.Mail.MailAddress(s1)
                mailMessage.[To].Add(s2)
                mailMessage.Body = s3
                mailMessage.IsBodyHtml = True
                mailMessage.Subject = s5
                Dim smtpClient As System.Net.Mail.SmtpClient = New System.Net.Mail.SmtpClient(s6)
                smtpClient.Port = s7
                smtpClient.Credentials = New System.Net.NetworkCredential(s8, s9)
                smtpClient.EnableSsl = True
                smtpClient.Send(mailMessage)
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Shared Sub SendMail1(s1 As String, s2 As String, s3 As String, s4 As String, s5 As String, s6 As String, s7 As Integer, s8 As String, s9 As String)
            Dim mailMessage As System.Net.Mail.MailMessage = New System.Net.Mail.MailMessage()
            Try
                mailMessage.From = New System.Net.Mail.MailAddress(s1)
                mailMessage.[To].Add(s2)
                mailMessage.Body = s3
                mailMessage.Attachments.Add(New System.Net.Mail.Attachment(s4))
                mailMessage.IsBodyHtml = True
                mailMessage.Subject = s5
                Dim smtpClient As System.Net.Mail.SmtpClient = New System.Net.Mail.SmtpClient(s6)
                smtpClient.Port = s7
                smtpClient.Credentials = New System.Net.NetworkCredential(s8, s9)
                smtpClient.EnableSsl = True
                smtpClient.Send(mailMessage)
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Shared Function IsConnectionAvailable() As Boolean
            Dim webRequest As System.Net.WebRequest = System.Net.WebRequest.Create(New System.Uri("http://www.google.com"))
            Try
                webRequest.GetResponse().Close()
                Return True
            Catch __unusedException1__ As System.Exception
                Return False
            End Try
        End Function

        Public Shared Sub LogFunc(st1 As String, st2 As String)
            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
            RestaurantPOS14.ModClasses.con.Open()
            RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("insert into Logs(UserID,Date,Operation) VALUES (@d1,@d2,@d3)")
            RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", st1)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", System.DateTime.Now)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", st2)
            RestaurantPOS14.ModClasses.cmd.ExecuteReader()
            RestaurantPOS14.ModClasses.con.Close()
        End Sub

        Public Shared Sub SMSFunc(st1 As String, st2 As String, st3 As String)
            System.Net.ServicePointManager.MaxServicePointIdleTime = 1000
            System.Net.ServicePointManager.Expect100Continue = True
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls11 Or System.Net.SecurityProtocolType.Tls12
            st3 = st3.Replace(CStr(("@MobileNo")), CStr((st1))).Replace("@Message", st2)
            Dim response As System.Net.HttpWebResponse = CType(CType(System.Net.WebRequest.Create(New System.Uri(st3)), System.Net.HttpWebRequest).GetResponse(), System.Net.HttpWebResponse)
        End Sub

        Public Shared Function Encrypt(password As String) As String
            Return System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(password))
        End Function

        Public Shared Function Decrypt(encryptpwd As String) As String
            Dim decoder As System.Text.Decoder = New System.Text.UTF8Encoding().GetDecoder()
            Dim array As Byte() = System.Convert.FromBase64String(encryptpwd)
            Dim array2 As Char() = New Char(decoder.GetCharCount(array, 0, array.Length) - 1 + 1 - 1) {}
            decoder.GetChars(array, 0, array.Length, array2, 0)
            Return New String(array2)
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
            Catch
            End Try
            Dim report = TryCast(rpt, CrystalDecisions.CrystalReports.Engine.ReportDocument)
            If report Is Nothing Then Return

            Dim settings = RestaurantPOS14.Configuration.SettingsHost.Current
            Dim resolver As New RestaurantPOS14.Customization.ReportProfileResolver(settings.Reports, settings.Printing.DefaultPrinterName)
            Dim profile = resolver.Resolve(report.GetType().Name)
            Dim job As New RestaurantPOS14.Extensions.Printing.PrintJob With {
                .DocumentName = profile.ReportName,
                .PrinterName = profile.PrinterName,
                .Copies = 1,
                .Payload = report
            }
            Call RestaurantPOS14.Extensions.Printing.PrintServiceHost.Current.Print(job)
        End Sub

        Public Shared Sub ApplyServiceChargeLabelFix(rptObj As Object)
            Dim reportDocument As CrystalDecisions.CrystalReports.Engine.ReportDocument = TryCast(rptObj, CrystalDecisions.CrystalReports.Engine.ReportDocument)
            If reportDocument IsNot Nothing Then
                Call RestaurantPOS14.ModFunc.FixDocApplyServiceChargeLabel(reportDocument)
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

        Public Shared Function IsSaveAllowed(UserID As String, ModuleName As String) As Boolean
            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
            RestaurantPOS14.ModClasses.con.Open()
            RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Select UR_Save from UserRights where UserID=@d1 and ModuleName=@d2")
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", UserID)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", ModuleName)
            RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
            RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
            RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
            Dim result As Boolean = False
            If RestaurantPOS14.ModClasses.rdr.Read() Then
                result = RestaurantPOS14.ModClasses.rdr.GetBoolean(0)
            End If

            RestaurantPOS14.ModClasses.con.Close()
            Return result
        End Function

        Public Shared Function IsViewAllowed(UserID As String, ModuleName As String) As Boolean
            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
            RestaurantPOS14.ModClasses.con.Open()
            RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Select UR_View from UserRights where UserID=@d1 and ModuleName=@d2")
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", UserID)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", ModuleName)
            RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
            RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
            RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
            Dim result As Boolean = False
            If RestaurantPOS14.ModClasses.rdr.Read() Then
                result = RestaurantPOS14.ModClasses.rdr.GetBoolean(0)
            End If

            RestaurantPOS14.ModClasses.con.Close()
            Return result
        End Function

        Public Shared Function IsUpdateAllowed(UserID As String, ModuleName As String) As Boolean
            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
            RestaurantPOS14.ModClasses.con.Open()
            RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Select UR_Update from UserRights where UserID=@d1 and ModuleName=@d2")
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", UserID)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", ModuleName)
            RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
            RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
            RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
            Dim result As Boolean = False
            If RestaurantPOS14.ModClasses.rdr.Read() Then
                result = RestaurantPOS14.ModClasses.rdr.GetBoolean(0)
            End If

            RestaurantPOS14.ModClasses.con.Close()
            Return result
        End Function

        Public Shared Function IsDeleteAllowed(UserID As String, ModuleName As String) As Boolean
            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
            RestaurantPOS14.ModClasses.con.Open()
            RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Select UR_Delete from UserRights where UserID=@d1 and ModuleName=@d2")
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", UserID)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", ModuleName)
            RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
            RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
            RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
            Dim result As Boolean = False
            If RestaurantPOS14.ModClasses.rdr.Read() Then
                result = RestaurantPOS14.ModClasses.rdr.GetBoolean(0)
            End If

            RestaurantPOS14.ModClasses.con.Close()
            Return result
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
