Imports System.Data.SqlClient

Partial Class pengguna_tambah_pinjam
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        email.Text = "pengguna@puswil.com"

    End Sub

    Protected Sub tambah_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tambah.Click

        Dim koneksi As New SqlConnection
        Dim xCommand As New SqlCommand
        Dim strSql As String

        koneksi.ConnectionString = "Data Source=vinasantarosa_m\sqlexpress;Initial Catalog=pustaka;Trusted_connection=Yes"
        koneksi.Open()

        'input data dgn executenonquery
        strSql = "insert into [peminjaman] (id,nama_buku,tgl,no_ktp,status) values ('" + id.Text + "','" + nama_buku.Text + "','" + tgl.Text + "','" + no_ktp.Text + "','" + status.Text + "')"

        xCommand.Connection = koneksi
        xCommand.CommandText = strSql
        xCommand.ExecuteNonQuery()

        koneksi.Close()

        Response.Redirect("peminjaman.aspx")

    End Sub
End Class
