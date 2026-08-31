Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms
Imports MessagingToolkit.QRCode.Codec

Namespace RestaurantPOS14
    Public Class frmEInvoicePreview
        Inherits System.Windows.Forms.Form
        Private ReadOnly billId As Integer
        Private ReadOnly billType As String
        Private lblTitle As System.Windows.Forms.Label
        Private lblUIN As System.Windows.Forms.Label
        Private picQR As System.Windows.Forms.PictureBox
        Private btnOpenQR As System.Windows.Forms.Button
        Private btnClose As System.Windows.Forms.Button
        Public Sub New(billId As Integer, billType As String)
            Me.billId = billId
            Me.billType = billType
            MyBase.Text = "E-Invoice Preview"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            MyBase.Width = 480
            MyBase.Height = 600
            MyBase.TopMost = True
            Me.lblTitle = New System.Windows.Forms.Label With {
        .Text = "UIN:",
        .Left = 12,
        .Top = 12,
        .Width = 40
    }
            Me.lblUIN = New System.Windows.Forms.Label With {
        .Left = 60,
        .Top = 12,
        .Width = 380
    }
            Me.picQR = New System.Windows.Forms.PictureBox With {
        .Left = 12,
        .Top = 44,
        .Width = 440,
        .Height = 440,
        .BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle,
        .SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
    }
            Me.btnOpenQR = New System.Windows.Forms.Button With {
        .Text = "Open QR",
        .Left = 12,
        .Top = 500,
        .Width = 100
    }
            Me.btnClose = New System.Windows.Forms.Button With {
        .Text = "Close",
        .Left = 352,
        .Top = 500,
        .Width = 100
    }
            AddHandler Me.btnOpenQR.Click, Sub() Me.OpenQR()
            AddHandler Me.btnClose.Click, Sub() MyBase.Close()
            MyBase.Controls.Add(Me.lblTitle)
            MyBase.Controls.Add(Me.lblUIN)
            MyBase.Controls.Add(Me.picQR)
            MyBase.Controls.Add(Me.btnOpenQR)
            MyBase.Controls.Add(Me.btnClose)
            AddHandler MyBase.Load, Sub() Me.LoadData()
        End Sub

        Private Sub LoadData()
            Try
                Dim table As String = (If((Equals(Me.billType, "EB")), "RestaurantPOS_BillingInfoEB", (If((Equals(Me.billType, "TA")), "RestaurantPOS_BillingInfoTA", (If((Equals(Me.billType, "HD")), "RestaurantPOS_BillingInfoHD", "RestaurantPOS_BillingInfoKOT"))))))
                Using con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    con.Open()
                    Using cmd As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT UIN, QRUrl FROM " & table & " WHERE Id=@id", con)
                        cmd.Parameters.AddWithValue("@id", Me.billId)
                        Using r As System.Data.SqlClient.SqlDataReader = cmd.ExecuteReader()
                            If Not r.Read() Then
                                Return
                            End If

                            Dim uin As String = (If(r.IsDBNull(0), String.Empty, r.GetString(CInt((0))).Trim()))
                            Dim qr As String = (If(r.IsDBNull(1), String.Empty, r.GetString(CInt((1))).Trim()))
                            Me.lblUIN.Text = If(uin, String.Empty)
                            If Not String.IsNullOrEmpty(qr) Then
                                Try
                                    Dim bmp As System.Drawing.Bitmap = New MessagingToolkit.QRCode.Codec.QRCodeEncoder().Encode(qr)
                                    Me.picQR.Image = bmp
                                    Return
                                Catch
                                    Return
                                End Try
                            End If
                        End Using
                    End Using
                End Using

            Catch
                Me.lblUIN.Text = String.Empty
                Me.picQR.Image = Nothing
            End Try
        End Sub

        Private Sub OpenQR()
            Try
                Dim table As String = (If((Equals(Me.billType, "EB")), "RestaurantPOS_BillingInfoEB", (If((Equals(Me.billType, "TA")), "RestaurantPOS_BillingInfoTA", (If((Equals(Me.billType, "HD")), "RestaurantPOS_BillingInfoHD", "RestaurantPOS_BillingInfoKOT"))))))
                Using con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    con.Open()
                    Using cmd As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT QRUrl FROM " & table & " WHERE Id=@id", con)
                        cmd.Parameters.AddWithValue("@id", Me.billId)
                        Dim val As String = TryCast(cmd.ExecuteScalar(), String)
                        If Not String.IsNullOrEmpty(val) Then
                            Try
                                Call System.Diagnostics.Process.Start(val)
                                Return
                            Catch
                                Return
                            End Try
                        End If
                    End Using
                End Using

            Catch
            End Try
        End Sub

        Public Shared Sub ShowFor(billId As Integer, billType As String)
            Using f As RestaurantPOS14.frmEInvoicePreview = New RestaurantPOS14.frmEInvoicePreview(billId, billType)
                f.ShowDialog()
            End Using
        End Sub
    End Class
End Namespace
