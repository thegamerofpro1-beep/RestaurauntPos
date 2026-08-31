Imports System
Imports System.Collections.Generic
Imports System.Net.Http
Imports System.Net.Http.Headers
Imports System.Security.Cryptography
Imports System.Text
Imports System.Threading.Tasks
Imports Newtonsoft.Json

Namespace RestaurantPOS14.EInvoicing
    Public Class EInvoiceClient
        Private ReadOnly http As System.Net.Http.HttpClient
        Private ReadOnly cfg As RestaurantPOS14.EInvoicing.EInvoiceConfig
        Private _accessToken As String
        Private _accessTokenExpiration As System.DateTime
        Public Sub New(config As RestaurantPOS14.EInvoicing.EInvoiceConfig)
            'IL_000e: Unknown result type (might be due to invalid IL or missing references)
            'IL_0018: Expected O, but got Unknown
            Me.cfg = config
            Me.http = New System.Net.Http.HttpClient()
            Me.http.BaseAddress = New System.Uri(Me.cfg.BaseUrl)
        End Sub

        Private Async Function GetAccessTokenAsync() As System.Threading.Tasks.Task(Of String)
            If Not String.IsNullOrEmpty(Me._accessToken) AndAlso Me._accessTokenExpiration > System.DateTime.UtcNow.AddMinutes(5.0) Then
                Return Me._accessToken
            End If

            Dim tokenUrl As String = Me.cfg.BaseUrl.TrimEnd("/"c) & "/connect/token"
            Dim content As System.Net.Http.FormUrlEncodedContent = New System.Net.Http.FormUrlEncodedContent(CType(New System.Collections.Generic.KeyValuePair(Of String, String)(2) {New System.Collections.Generic.KeyValuePair(Of String, String)("client_id", Me.cfg.ClientId), New System.Collections.Generic.KeyValuePair(Of String, String)("client_secret", Me.cfg.ClientSecret), New System.Collections.Generic.KeyValuePair(Of String, String)("grant_type", "client_credentials")}, System.Collections.Generic.IEnumerable(Of System.Collections.Generic.KeyValuePair(Of String, String))))
            Dim obj As System.Net.Http.HttpResponseMessage = Await Me.http.PostAsync(tokenUrl, CType(CObj(content), System.Net.Http.HttpContent))
            obj.EnsureSuccessStatusCode()
            Dim tokenResponse As RestaurantPOS14.EInvoicing.SubmissionResult = Newtonsoft.Json.JsonConvert.DeserializeObject(Of RestaurantPOS14.EInvoicing.SubmissionResult)(Await obj.Content.ReadAsStringAsync())
            Me._accessToken = tokenResponse.AccessToken
            Me._accessTokenExpiration = System.DateTime.UtcNow.AddSeconds(tokenResponse.ExpiresIn)
            Return Me._accessToken
        End Function

        Public Async Function SubmitAsync(payload As String) As System.Threading.Tasks.Task(Of RestaurantPOS14.EInvoicing.SubmissionResult)
            Dim r As RestaurantPOS14.EInvoicing.SubmissionResult = New RestaurantPOS14.EInvoicing.SubmissionResult()
            Dim accessToken As String = Await Me.GetAccessTokenAsync()
            Me.http.DefaultRequestHeaders.Authorization = New System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken)
            Dim codeNumber As String = System.Guid.NewGuid().ToString("N")
            Dim docBase64 As String = System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(If(payload, "{}")))
            Dim docHash As String = RestaurantPOS14.EInvoicing.EInvoiceClient.ComputeSha256Hex(If(payload, "{}"))
            Dim obj = New With {
                                .documents = {New With {
                        .format = "JSON",
                        .document = docBase64,
                        .documentHash = docHash,
                        .codeNumber = codeNumber
                                }}
            }
            Dim resp As System.Net.Http.HttpResponseMessage = Await Me.http.PostAsync("/api/v1.0/documentsubmissions/", CType(New System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(obj), System.Text.Encoding.UTF8, "application/json"), System.Net.Http.HttpContent))
            r.Success = resp.IsSuccessStatusCode
            r.Status = resp.StatusCode.ToString()
            If resp.IsSuccessStatusCode Then
                Dim myInvoisResponse As Object = Newtonsoft.Json.JsonConvert.DeserializeObject(Of Object)(Await resp.Content.ReadAsStringAsync())
                Try
                    r.SubmissionId = If(myInvoisResponse.submissionUid, myInvoisResponse.submissionId)
                    If myInvoisResponse.acceptedDocuments IsNot Nothing AndAlso myInvoisResponse.acceptedDocuments.Count > 0 Then
                        r.UIN = myInvoisResponse.acceptedDocuments(CInt((0))).uuid
                    End If

                Catch
                End Try
            Else
                r.ErrorMessage = Await resp.Content.ReadAsStringAsync()
            End If

            Return r
        End Function

        Public Async Function SubmitAsync(payload As String, codeNumber As String) As System.Threading.Tasks.Task(Of RestaurantPOS14.EInvoicing.SubmissionResult)
            Dim r As RestaurantPOS14.EInvoicing.SubmissionResult = New RestaurantPOS14.EInvoicing.SubmissionResult()
            Dim accessToken As String = Await Me.GetAccessTokenAsync()
            Me.http.DefaultRequestHeaders.Authorization = New System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken)
            Dim docBase64 As String = System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(If(payload, "{}")))
            Dim docHash As String = RestaurantPOS14.EInvoicing.EInvoiceClient.ComputeSha256Hex(If(payload, "{}"))
            Dim obj = New With {
                                .documents = {New With {
                        .format = "JSON",
                        .document = docBase64,
                        .documentHash = docHash,
                        .codeNumber = (If(codeNumber, System.Guid.NewGuid().ToString("N")))
                                }}
            }
            Dim resp As System.Net.Http.HttpResponseMessage = Await Me.http.PostAsync("/api/v1.0/documentsubmissions/", CType(New System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(obj), System.Text.Encoding.UTF8, "application/json"), System.Net.Http.HttpContent))
            r.Success = resp.IsSuccessStatusCode
            r.Status = resp.StatusCode.ToString()
            If resp.IsSuccessStatusCode Then
                Dim myInvoisResponse As Object = Newtonsoft.Json.JsonConvert.DeserializeObject(Of Object)(Await resp.Content.ReadAsStringAsync())
                Try
                    r.SubmissionId = If(myInvoisResponse.submissionUid, myInvoisResponse.submissionId)
                    If myInvoisResponse.acceptedDocuments IsNot Nothing AndAlso myInvoisResponse.acceptedDocuments.Count > 0 Then
                        r.UIN = myInvoisResponse.acceptedDocuments(CInt((0))).uuid
                    End If

                Catch
                End Try
            Else
                r.ErrorMessage = Await resp.Content.ReadAsStringAsync()
            End If

            Return r
        End Function

        Public Async Function GetStatusAsync(submissionId As String) As System.Threading.Tasks.Task(Of RestaurantPOS14.EInvoicing.SubmissionResult)
            Dim r As RestaurantPOS14.EInvoicing.SubmissionResult = New RestaurantPOS14.EInvoicing.SubmissionResult()
            Dim accessToken As String = Await Me.GetAccessTokenAsync()
            Me.http.DefaultRequestHeaders.Authorization = New System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken)
            Dim resp As System.Net.Http.HttpResponseMessage = Await Me.http.GetAsync("/api/v1.0/e-invoices/documents/" & submissionId)
            r.Success = resp.IsSuccessStatusCode
            r.Status = resp.StatusCode.ToString()
            If resp.IsSuccessStatusCode Then
                Dim myInvoisResponse As Object = Newtonsoft.Json.JsonConvert.DeserializeObject(Of Object)(Await resp.Content.ReadAsStringAsync())
                r.UIN = myInvoisResponse.uuid
                r.QRUrl = myInvoisResponse.qrCodeUrl
            Else
                r.ErrorMessage = Await resp.Content.ReadAsStringAsync()
            End If

            Return r
        End Function

        Public Async Function CancelAsync(uin As String, reason As String) As System.Threading.Tasks.Task(Of RestaurantPOS14.EInvoicing.SubmissionResult)
            Dim r As RestaurantPOS14.EInvoicing.SubmissionResult = New RestaurantPOS14.EInvoicing.SubmissionResult()
            Dim accessToken As String = Await Me.GetAccessTokenAsync()
            Me.http.DefaultRequestHeaders.Authorization = New System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken)
            Dim content As System.Net.Http.StringContent = New System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(New With {
                    .status = "cancelled",
                    .reason = (If(reason, String.Empty))
                }), System.Text.Encoding.UTF8, "application/json")
            Dim req As System.Net.Http.HttpRequestMessage = New System.Net.Http.HttpRequestMessage(System.Net.Http.HttpMethod.Put, "/api/v1.0/documents/state/" & uin & "/state") With {
        .Content = CType(CObj(content), System.Net.Http.HttpContent)
    }
            Dim resp As System.Net.Http.HttpResponseMessage = Await Me.http.SendAsync(req)
            r.Success = resp.IsSuccessStatusCode
            r.Status = resp.StatusCode.ToString()
            If Not resp.IsSuccessStatusCode Then
                r.ErrorMessage = Await resp.Content.ReadAsStringAsync()
            End If

            Return r
        End Function

        Public Async Function ReplaceAsync(uin As String, payload As String) As System.Threading.Tasks.Task(Of RestaurantPOS14.EInvoicing.SubmissionResult)
            Dim r As RestaurantPOS14.EInvoicing.SubmissionResult = New RestaurantPOS14.EInvoicing.SubmissionResult()
            Dim accessToken As String = Await Me.GetAccessTokenAsync()
            Me.http.DefaultRequestHeaders.Authorization = New System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken)
            Dim codeNumber As String = System.Guid.NewGuid().ToString("N")
            Dim docBase64 As String = System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(If(payload, "{}")))
            Dim docHash As String = RestaurantPOS14.EInvoicing.EInvoiceClient.ComputeSha256Hex(If(payload, "{}"))
            Dim obj = New With {
                                .documents = {New With {
                        .format = "JSON",
                        .document = docBase64,
                        .documentHash = docHash,
                        .codeNumber = codeNumber
                                }}
            }
            Dim resp As System.Net.Http.HttpResponseMessage = Await Me.http.PostAsync("/api/v1.0/documentsubmissions/", CType(New System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(obj), System.Text.Encoding.UTF8, "application/json"), System.Net.Http.HttpContent))
            r.Success = resp.IsSuccessStatusCode
            r.Status = resp.StatusCode.ToString()
            If Not resp.IsSuccessStatusCode Then
                r.ErrorMessage = Await resp.Content.ReadAsStringAsync()
            End If

            Return r
        End Function

        Public Async Function GetSubmissionAsync(submissionUid As String) As System.Threading.Tasks.Task(Of (Boolean, String, String))
            Dim accessToken As String = Await Me.GetAccessTokenAsync()
            Me.http.DefaultRequestHeaders.Authorization = New System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken)
            Dim resp As System.Net.Http.HttpResponseMessage = Await Me.http.GetAsync("/api/v1.0/documentsubmissions/" & submissionUid & "?pageNo=1&pageSize=100")
            If Not resp.IsSuccessStatusCode Then
                Return (False, resp.StatusCode.ToString(), Nothing)
            End If

            Dim jo As Object = Newtonsoft.Json.JsonConvert.DeserializeObject(Of Object)(Await resp.Content.ReadAsStringAsync())
            Dim status As String = jo.overallStatus
            Dim firstUuid As String = Nothing
            Try
                If jo.documentSummary IsNot Nothing AndAlso jo.documentSummary.Count > 0 Then
                    firstUuid = jo.documentSummary(CInt((0))).uuid
                End If

            Catch
            End Try

            Return (True, status, firstUuid)
        End Function

        Private Shared Function ComputeSha256Hex(input As String) As String
            Using sha As System.Security.Cryptography.SHA256 = System.Security.Cryptography.SHA256.Create()
                Dim bytes As Byte() = System.Text.Encoding.UTF8.GetBytes(If(input, String.Empty))
                Dim array As Byte() = sha.ComputeHash(bytes)
                Dim sb As System.Text.StringBuilder = New System.Text.StringBuilder(array.Length * 2)
                Dim array2 As Byte() = array
                For Each b As Byte In array2
                    sb.Append(b.ToString("x2"))
                Next

                Return sb.ToString()
            End Using
        End Function
    End Class
End Namespace
