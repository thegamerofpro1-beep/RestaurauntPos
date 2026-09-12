Imports System
Imports System.Data.SqlClient
Imports System.Windows.Forms

Namespace RestaurantPOS14
    Public Class frmAdvancedSettings
        Inherits System.Windows.Forms.Form
        Friend lblUser As System.Windows.Forms.Label
        Private chkChecklist As System.Windows.Forms.CheckBox
        Private chkMyInvois As System.Windows.Forms.CheckBox
        Private lblBaseUrl As System.Windows.Forms.Label
        Private txtBaseUrl As System.Windows.Forms.TextBox
        Private lblClientId As System.Windows.Forms.Label
        Private txtClientId As System.Windows.Forms.TextBox
        Private lblClientSecret As System.Windows.Forms.Label
        Private txtClientSecret As System.Windows.Forms.TextBox
        Private lblEnvironment As System.Windows.Forms.Label
        Private cboEnvironment As System.Windows.Forms.ComboBox
        Private btnSave As System.Windows.Forms.Button
        Private btnClose As System.Windows.Forms.Button
        Public Sub New()
            MyBase.Text = "Advanced Setting"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            MyBase.Width = 620
            MyBase.Height = 420
            MyBase.TopMost = True
            Me.lblUser = New System.Windows.Forms.Label With {
        .Left = 12,
        .Top = 12,
        .Width = 200,
        .Text = ""
    }
            Me.chkChecklist = New System.Windows.Forms.CheckBox With {
        .Left = 12,
        .Top = 50,
        .Width = 420,
        .Text = "Enable Checklist"
    }
            Me.chkMyInvois = New System.Windows.Forms.CheckBox With {
        .Left = 12,
        .Top = 80,
        .Width = 420,
        .Text = "Enable MyInvois (E-Invoice)"
    }
            Me.lblBaseUrl = New System.Windows.Forms.Label With {
        .Left = 12,
        .Top = 120,
        .Width = 160,
        .Text = "API Base URL"
    }
            Me.txtBaseUrl = New System.Windows.Forms.TextBox With {
        .Left = 180,
        .Top = 116,
        .Width = 400
    }
            Me.lblClientId = New System.Windows.Forms.Label With {
        .Left = 12,
        .Top = 160,
        .Width = 160,
        .Text = "Client ID"
    }
            Me.txtClientId = New System.Windows.Forms.TextBox With {
        .Left = 180,
        .Top = 156,
        .Width = 400
    }
            Me.lblClientSecret = New System.Windows.Forms.Label With {
        .Left = 12,
        .Top = 200,
        .Width = 160,
        .Text = "Client Secret"
    }
            Me.txtClientSecret = New System.Windows.Forms.TextBox With {
        .Left = 180,
        .Top = 196,
        .Width = 400,
        .UseSystemPasswordChar = True
    }
            Me.lblEnvironment = New System.Windows.Forms.Label With {
        .Left = 12,
        .Top = 240,
        .Width = 160,
        .Text = "Environment"
    }
            Me.cboEnvironment = New System.Windows.Forms.ComboBox With {
        .Left = 180,
        .Top = 236,
        .Width = 200,
        .DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    }
            Me.cboEnvironment.Items.AddRange(New Object(1) {"Sandbox", "Production"})
            Me.btnSave = New System.Windows.Forms.Button With {
        .Left = 12,
        .Top = 300,
        .Width = 140,
        .Text = "Save"
    }
            Me.btnClose = New System.Windows.Forms.Button With {
        .Left = 440,
        .Top = 300,
        .Width = 140,
        .Text = "Close"
    }
            AddHandler Me.btnSave.Click, Sub() Me.Save()
            AddHandler Me.btnClose.Click, Sub() MyBase.Close()
            MyBase.Controls.Add(Me.lblUser)
            MyBase.Controls.Add(Me.chkChecklist)
            MyBase.Controls.Add(Me.chkMyInvois)
            MyBase.Controls.Add(Me.lblBaseUrl)
            MyBase.Controls.Add(Me.txtBaseUrl)
            MyBase.Controls.Add(Me.lblClientId)
            MyBase.Controls.Add(Me.txtClientId)
            MyBase.Controls.Add(Me.lblClientSecret)
            MyBase.Controls.Add(Me.txtClientSecret)
            MyBase.Controls.Add(Me.lblEnvironment)
            MyBase.Controls.Add(Me.cboEnvironment)
            MyBase.Controls.Add(Me.btnSave)
            MyBase.Controls.Add(Me.btnClose)
            AddHandler MyBase.Load, Sub() Me.Reset()
        End Sub

        Public Sub Reset()
            Me.btnSave.Enabled = RestaurantPOS14.ModFunc.IsSaveAllowed(Me.lblUser.Text, "Settings")
            Try
                Me.EnsureSchema()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show("Advanced Setting storage could not be upgraded." & System.Environment.NewLine & System.Environment.NewLine & ex.Message, "Advanced Setting", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
            Me.LoadFlags()
        End Sub

        Private Sub EnsureSchema()
            Using con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                con.Open()
                RestaurantPOS14.Configuration.DatabaseMaintenance.EnsureCompatibleSchema(con)
            End Using
        End Sub

        Private Sub LoadFlags()
            Try
                RestaurantPOS14.Configuration.SettingsHost.Service.Reload()
                Dim settings = RestaurantPOS14.Configuration.SettingsHost.Current
                Me.chkChecklist.Checked = settings.Features.Checklist
                Me.chkMyInvois.Checked = settings.Features.EInvoicing
                Me.txtBaseUrl.Text = settings.EInvoice.BaseUrl
                Me.txtClientId.Text = settings.EInvoice.ClientId
                Me.txtClientSecret.Text = settings.EInvoice.ClientSecret
                Me.cboEnvironment.SelectedIndex = (If(String.Equals(settings.EInvoice.Environment, "Production", System.StringComparison.OrdinalIgnoreCase), 1, 0))

            Catch
                Me.chkChecklist.Checked = False
                Me.chkMyInvois.Checked = False
                Me.txtBaseUrl.Text = "https://preprod-api.myinvois.hasil.gov.my"
                Me.txtClientId.Text = String.Empty
                Me.txtClientSecret.Text = String.Empty
                Me.cboEnvironment.SelectedIndex = 0
            End Try
        End Sub

        Private Sub Save()
            Try
                Dim baseUrl As System.Uri = Nothing
                If Not System.Uri.TryCreate(Me.txtBaseUrl.Text, System.UriKind.Absolute, baseUrl) OrElse Not String.Equals(baseUrl.Scheme, System.Uri.UriSchemeHttps, System.StringComparison.OrdinalIgnoreCase) Then
                    Throw New System.InvalidOperationException("The MyInvois base URL must be an absolute HTTPS URL.")
                End If
                If Me.chkMyInvois.Checked AndAlso (String.IsNullOrWhiteSpace(Me.txtClientId.Text) OrElse String.IsNullOrWhiteSpace(Me.txtClientSecret.Text)) Then
                    Throw New System.InvalidOperationException("Client ID and client secret are required when MyInvois is enabled.")
                End If

                Dim secrets = RestaurantPOS14.Configuration.SettingsHost.SecretStore
                If String.IsNullOrWhiteSpace(Me.txtClientId.Text) Then
                    secrets.RemoveSecret("EInvoice.ClientId")
                Else
                    secrets.SetSecret("EInvoice.ClientId", Me.txtClientId.Text.Trim())
                End If
                If String.IsNullOrWhiteSpace(Me.txtClientSecret.Text) Then
                    secrets.RemoveSecret("EInvoice.ClientSecret")
                Else
                    secrets.SetSecret("EInvoice.ClientSecret", Me.txtClientSecret.Text)
                End If

                Using con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    con.Open()
                    RestaurantPOS14.Configuration.DatabaseMaintenance.EnsureCompatibleSchema(con)
                    Dim affected As Integer = 0
                    Using cmd As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("UPDATE OtherSetting SET EnableChecklist=@c, EnableMyInvois=@m, MyInvoisBaseUrl=@u, MyInvoisClientId=@ci, MyInvoisClientSecret=@cs, MyInvoisEnvironment=@e", con)
                        cmd.Parameters.AddWithValue("@c", If(Me.chkChecklist.Checked, "Yes", "No"))
                        cmd.Parameters.AddWithValue("@m", If(Me.chkMyInvois.Checked, "Yes", "No"))
                        cmd.Parameters.AddWithValue("@u", If(Me.txtBaseUrl.Text, String.Empty))
                        cmd.Parameters.AddWithValue("@ci", String.Empty)
                        cmd.Parameters.AddWithValue("@cs", String.Empty)
                        cmd.Parameters.AddWithValue("@e", If((Me.cboEnvironment.SelectedIndex = 1), "Production", "Sandbox"))
                        affected = cmd.ExecuteNonQuery()
                    End Using

                    If affected = 0 Then
                        Using ins As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("INSERT INTO OtherSetting (EnableChecklist, EnableMyInvois, MyInvoisBaseUrl, MyInvoisClientId, MyInvoisClientSecret, MyInvoisEnvironment) VALUES (@c,@m,@u,@ci,@cs,@e)", con)
                            ins.Parameters.AddWithValue("@c", If(Me.chkChecklist.Checked, "Yes", "No"))
                            ins.Parameters.AddWithValue("@m", If(Me.chkMyInvois.Checked, "Yes", "No"))
                            ins.Parameters.AddWithValue("@u", If(Me.txtBaseUrl.Text, String.Empty))
                            ins.Parameters.AddWithValue("@ci", String.Empty)
                            ins.Parameters.AddWithValue("@cs", String.Empty)
                            ins.Parameters.AddWithValue("@e", If((Me.cboEnvironment.SelectedIndex = 1), "Production", "Sandbox"))
                            ins.ExecuteNonQuery()
                        End Using
                    End If
                End Using

                RestaurantPOS14.Configuration.SettingsHost.Service.Reload()
                Call System.Windows.Forms.MessageBox.Show("Successfully updated", "Advanced Setting", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                MyBase.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub
    End Class
End Namespace
