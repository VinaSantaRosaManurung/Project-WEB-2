Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Partial Class pengguna_buku
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then

            BindDataList()

        End If

    End Sub

    Protected Sub BindDataList()

        Dim dt As New DataTable()
        Dim con As New SqlConnection(ConfigurationManager.ConnectionStrings("pustakaConnectionString").ConnectionString)
        Try
            Dim adp As New SqlDataAdapter("select * from [buku]", con)
            adp.Fill(dt)
            nama_buku.DataSource = dt
            nama_buku.DataBind()
        Catch ex As Exception
            Response.Write("Error occured: " & ex.Message.ToString())
        Finally
            dt.Clear()
            dt.Dispose()
            con.Close()
        End Try
    End Sub



End Class


