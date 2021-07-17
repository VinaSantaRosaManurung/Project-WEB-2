Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient

Partial Class pengguna_pinjam
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        dropBuku()
    End Sub

    Private Function dropBuku()
        If Not Me.IsPostBack Then
            Dim constr As String = ConfigurationManager.ConnectionStrings("pustakaConnectionString").ConnectionString
            Using con As New SqlConnection(constr)
                Using cmd As New SqlCommand("SELECT id_buku FROM [buku]")
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = con
                    con.Open()
                    id_buku.DataSource = cmd.ExecuteReader()
                    id_buku.DataTextField = "id_buku"
                    id_buku.DataValueField = "id_buku"
                    id_buku.DataBind()
                    con.Close()
                End Using
            End Using
            id_buku.Items.Insert(0, New ListItem("--Pilih Buku--", "0"))
        End If
    End Function

    Protected Sub pinjam_Click(sender As Object, e As EventArgs) Handles pinjam.Click
        Dim koneksi As New SqlConnection
        Dim xCommand As New SqlCommand
        Dim strSql As String

        koneksi.ConnectionString = "Data Source=vinasantarosa_m\sqlexpress;Initial Catalog=pustaka;Trusted_connection=Yes"
        koneksi.Open()

        'input data dgn executenonquery
        strSql = "insert into [peminjaman] (nama_buku,tgl,no_ktp,status) values ('" + nama_buku.Text + "','" + tgl.Text + "','" + no_ktp.Text + "','" + status.Text + "')"

        xCommand.Connection = koneksi
        xCommand.CommandText = strSql
        xCommand.ExecuteNonQuery()

        koneksi.Close()

        Response.Redirect("peminjaman.aspx")
    End Sub
End Class
