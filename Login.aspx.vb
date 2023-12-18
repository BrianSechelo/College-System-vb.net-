Public Class Login1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click

        sql = "SELECT * FROM USERS WHERE EMAIL='" & TextBox1.Text & "'"
        queryrd1(sql)
        While sqlReader.Read
            If TextBox2.Text = sqlReader.Item("PASSWORD") Then
                Session("EMAIL") = TextBox1.Text
                Response.Write("Password is correct")
                If TextBox1.Text = "admin@gmail.com" Then
                    Response.Redirect("ADMIN PANEL.aspx")
                Else
                    Response.Redirect("COLLEGE SYSTEM.aspx")
                End If

            Else
                Response.Write("Password Not Correct")

            End If
        End While
        queryrd2()
    End Sub
End Class