Imports System.Data.SqlClient

Partial Class daftar
    Inherits System.Web.UI.Page

    Protected Sub regis_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles regis.Click

        Dim koneksi As New SqlConnection
        Dim xCommand As New SqlCommand
        Dim strSql As String

        koneksi.ConnectionString = "Data Source=vinasantarosa_m\sqlexpress;Initial Catalog=pustaka;Trusted_connection=Yes"
        koneksi.Open()

        'input data dgn executenonquery
        strSql = "insert into [pengguna] (nama,email,password,no_hp) values ('" + nama.Text + "','" + email.Text + "','" + password.Text + "','" + no_hp.Text + "')"

        xCommand.Connection = koneksi
        xCommand.CommandText = strSql
        xCommand.ExecuteNonQuery()

        koneksi.Close()

        Response.Redirect("masuk.aspx")

    End Sub
End Class
