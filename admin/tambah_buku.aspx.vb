Imports System.Data.SqlClient

Partial Class admin_tambah_buku
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        email.Text = "admin@puswil.com"

    End Sub

    Protected Sub tambah_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tambah.Click

        Dim koneksi As New SqlConnection
        Dim xCommand As New SqlCommand
        Dim strSql As String

        koneksi.ConnectionString = "Data Source=vinasantarosa_m\sqlexpress;Initial Catalog=pustaka;Trusted_connection=Yes"
        koneksi.Open()

        'input data dgn executenonquery
        strSql = "insert into [buku] (id_buku,nama_buku,tahun,deskripsi) values ('" + id_buku.Text + "','" + nama_buku.Text + "','" + tahun.Text + "','" + deskripsi.Text + "')"

        xCommand.Connection = koneksi
        xCommand.CommandText = strSql
        xCommand.ExecuteNonQuery()

        koneksi.Close()

        Response.Redirect("buku.aspx")

    End Sub
End Class
