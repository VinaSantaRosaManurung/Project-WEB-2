Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Partial Class admin_buku
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then

            BindDataList()

        End If

        email.Text = "santa@gmail.com"

    End Sub

    Protected Sub BindDataList()

        Dim dt As New DataTable()
        Dim con As New SqlConnection(ConfigurationManager.ConnectionStrings("pustakaConnectionString").ConnectionString)
        Try
            Dim adp As New SqlDataAdapter("select * from [buku]", con)
            adp.Fill(dt)
            dlBuku.DataSource = dt
            dlBuku.DataBind()
        Catch ex As Exception
            Response.Write("Error occured: " & ex.Message.ToString())
        Finally
            dt.Clear()
            dt.Dispose()
            con.Close()
        End Try
    End Sub

End Class
