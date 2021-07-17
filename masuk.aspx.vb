Imports System.Data.SqlClient
Imports System.Configuration

Partial Class masuk
    Inherits System.Web.UI.Page

    'Dim koneksi As SqlConnection
    Dim xReader As SqlDataReader
    Dim xCommand As SqlCommand

    Protected Sub login_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles login.Click

        Dim strConn As New SqlConnection(ConfigurationManager.ConnectionStrings("pustakaConnectionString").ConnectionString)

        Try

            strConn.Open()

            Dim sqlNama As String
            sqlNama = String.Format("select * from [pengguna] where email = '{0}' and password = '{1}'", Me.email.Text.Trim(), Me.password.Text.Trim())

            Dim com As New SqlCommand(sqlNama, strConn)
            com.Parameters.AddWithValue("email", email.Text)
            com.Parameters.AddWithValue("password", password.Text)

            Dim currentNama As String
            currentNama = CStr(com.ExecuteScalar)


            If currentNama <> "" And email.Text = "admin@puswil.com" Then
                MsgBox("Berhasil Login")
                Session("email") = email.Text
                Response.Redirect("admin/dashboard.aspx")
            ElseIf currentNama <> "" Then
                MsgBox("Berhasil Login")
                Session("email") = email.Text
                Response.Redirect("pengguna/dashboard.aspx")
            Else
                MsgBox("Email dan Password Salah")
                Response.Redirect("masuk.aspx")
                Session("email") = ""
            End If

            'koneksi = New SqlConnection
            'koneksi.ConnectionString = "Data Source=vinasantarosa_m\sqlexpress;Initial Catalog=pustaka;Trusted_connection=Yes"

            'Try
            '    koneksi.Open()
            '    Dim query As String
            '    query = String.Format("select * from [pengguna] where email = '{0}' and password = '{1}'", Me.nama.Text.Trim(), Me.password.Text.Trim())
            '    xCommand = New SqlCommand(query, koneksi)
            '    xReader = xCommand.ExecuteReader

            '    Dim count As Integer
            '    count = 0
            '    While xReader.Read
            '        count = count + 1
            '    End While

            '    If count = 1 And nama.Text = "admin@puswil.com" Then
            '        MsgBox("Berhasil Login")
            '        Response.Redirect("admin/dashboard.aspx")
            '    ElseIf count = 1 Then
            '        MsgBox("Berhasil Login")
            '        Response.Redirect("pengguna/dashboard.aspx")
            '    Else
            '        MsgBox("Email dan Password Salah")
            '        Response.Redirect("masuk.aspx")
            '    End If
            '    koneksi.Close()
            'Catch ex As SqlException
            '    MsgBox(ex.Message)
            'Finally
            '    koneksi.Dispose()
            'End Try

        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            strConn.Dispose()
        End Try
    End Sub

End Class
