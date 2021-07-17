Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Data

Partial Class admin_dashboard
    Inherits System.Web.UI.Page

    Private intTotalRec As Integer

    Protected Sub logout_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles logout.Click
        Session.RemoveAll()
        Response.Redirect("../index.aspx")
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        email.Text = "santa@gmail.com"

        jmlBuku.Text = hitungBuku()
        jmlPengguna.Text = hitungPengguna()
        jmlPinjam.Text = hitungPinjam()

    End Sub

    Private Function hitungBuku() As Integer
        Using sqlCmd As New SqlCommand
            Using sqlCon As New SqlConnection

                sqlCon.ConnectionString = "Data Source=vinasantarosa_m\sqlexpress;Initial Catalog=pustaka;Trusted_connection=Yes"
                sqlCon.Open()

                sqlCmd.CommandType = CommandType.Text
                sqlCmd.Connection = sqlCon
                sqlCmd.CommandText = "select count(*) from [buku]"

                If sqlCon.State <> ConnectionState.Open Then sqlCon.Open()

                intTotalRec = Convert.ToInt32(sqlCmd.ExecuteScalar)

                Return intTotalRec

                sqlCon.Close()

            End Using
        End Using
    End Function


    Private Function hitungPengguna() As Integer
        Using sqlCmd As New SqlCommand
            Using sqlCon As New SqlConnection

                sqlCon.ConnectionString = "Data Source=vinasantarosa_m\sqlexpress;Initial Catalog=pustaka;Trusted_connection=Yes"
                sqlCon.Open()

                sqlCmd.CommandType = CommandType.Text
                sqlCmd.Connection = sqlCon
                sqlCmd.CommandText = "select count(*) from [pengguna] where email != 'admin@puswil.com'"

                If sqlCon.State <> ConnectionState.Open Then sqlCon.Open()

                intTotalRec = Convert.ToInt32(sqlCmd.ExecuteScalar)

                Return intTotalRec

                sqlCon.Close()

            End Using
        End Using
    End Function

    Private Function hitungPinjam() As Integer
        Using sqlCmd As New SqlCommand
            Using sqlCon As New SqlConnection

                sqlCon.ConnectionString = "Data Source=vinasantarosa_m\sqlexpress;Initial Catalog=pustaka;Trusted_connection=Yes"
                sqlCon.Open()

                sqlCmd.CommandType = CommandType.Text
                sqlCmd.Connection = sqlCon
                sqlCmd.CommandText = "select count(*) from [peminjaman]"

                If sqlCon.State <> ConnectionState.Open Then sqlCon.Open()

                intTotalRec = Convert.ToInt32(sqlCmd.ExecuteScalar)

                Return intTotalRec

                sqlCon.Close()

            End Using
        End Using
    End Function

End Class
