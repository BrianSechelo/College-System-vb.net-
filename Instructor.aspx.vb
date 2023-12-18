Public Class Instructor
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Dim v As Boolean
        v = False
        sql = "select * from instructor"
        queryrd1(sql)
        While sqlReader.Read
            If TextBox3.Text = sqlReader.Item("idno") Then
                v = True
                Response.Write("exists")
                Exit Sub
            Else
                v = False
            End If
        End While
        queryrd2()
        If v = False Then
            connection()
            sql = "Insert into instructor(Name ,mobileno,idno,Responsibility)values('" & TextBox1.Text & "'," & TextBox2.Text & "," & TextBox3.Text & ",'" & TextBox5.Text & "')"
            query(sql)
        End If
       
    End Sub

    Protected Sub Button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button4.Click

        connection()
        sql = "Update instructor set Name='" & TextBox1.Text & "',mobileno='" & TextBox2.Text & "',idno=" & TextBox3.Text & ",Responsibility='" & TextBox5.Text & "' where idno=" & TextBox3.Text & ""
        query(sql)
    End Sub

    Protected Sub TextBox3_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox3.TextChanged
        If TextBox3.Text.Length > 8 Then
            Response.Write("invalid format")
        End If
        connection()
        sql = "select * from instructor where idno='" & TextBox3.Text & "'"
        queryrd1(sql)
        While sqlReader.Read
            TextBox1.Text = sqlReader.Item("Name")
            TextBox2.Text = sqlReader.Item("mobileno")
            TextBox3.Text = sqlReader.Item("idno")

            TextBox5.Text = sqlReader.Item("Responsibility")
        End While
        queryrd2()
    End Sub

    Protected Sub Button5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button5.Click
        Response.Redirect("COLLEGE SYSTEM.aspx")
    End Sub

    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.Click

    End Sub
End Class