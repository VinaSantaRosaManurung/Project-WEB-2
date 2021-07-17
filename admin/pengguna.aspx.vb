
Partial Class admin_pengguna
    Inherits System.Web.UI.Page

    Protected Sub logout_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles logout.Click
        Session.RemoveAll()
        Response.Redirect("../masuk.aspx")
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        email.Text = "santa@gmail.com"

    End Sub

End Class
