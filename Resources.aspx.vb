Public Class Resources
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            ComboBox1.Items.Insert("0", "choose")
            DropDownList2.Items.Insert("0", "choose")
            DropDownList3.Items.Insert("0", "choose")
            sql = "select * from Resources"
            queryrd1(sql)
            While sqlReader.Read
                ComboBox1.Items.Add(sqlReader.Item("Instructor"))
                DropDownList2.Items.Add(sqlReader.Item("Identifyn"))
            End While
            queryrd2()
            sql = "SELECT * FROM STUDENT"
            queryrd1(sql)
            While sqlReader.Read
                DropDownList3.Items.Add(sqlReader.Item("REGNO"))
            End While
            queryrd2()
        End If
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Dim v As Boolean
        v = False
        sql = "select * from Resources"
        queryrd1(sql)
        While sqlReader.Read
            If TextBox2.Text = sqlReader.Item("Identifyn") Then
                v = True
                Response.Write("exist")
            Else
                v = False
            End If
        End While
        queryrd2()
        If v = False Then
            connection()
            sql = "insert into Resources(name,Identifyn,Instructor)values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & ComboBox1.Text & "')"
            query(sql)
        End If
        
    End Sub

    Protected Sub Button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button4.Click
        connection()
        sql = "insert into resourcest(Identifyn,Resource,student,Instructor)values('" & DropDownList2.Text & "','" & TextBox3.Text & "','" & DropDownList3.Text & "','" & TextBox5.Text & "')"
        query(sql)
    End Sub

    Protected Sub Button5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button5.Click
        connection()
        sql = "Update resourcest  set Identifyn='" & DropDownList2.Text & "',Resource='" & TextBox3.Text & "',student='" & DropDownList3.Text & "',instructor='" & TextBox5.Text & "' where identifyn='" & DropDownList2.Text & "'"
        query(sql)
    End Sub

    Protected Sub DropDownList2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DropDownList2.SelectedIndexChanged

        sql = "select * from Resources where Identifyn='" & DropDownList2.Text & "'"
        queryrd1(sql)
        While sqlReader.Read
            TextBox3.Text = sqlReader.Item("name")
            TextBox5.Text = sqlReader.Item("instructor")
        End While
        queryrd2()
    End Sub

    Protected Sub Button6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button6.Click
        Response.Redirect("COLLEGE SYSTEM.aspx")
    End Sub

    Protected Sub DropDownList3_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DropDownList3.SelectedIndexChanged
        connection()
        sql = "select * from resourcest where Student='" & DropDownList3.Text & "'"
        queryrd1(sql)
        While sqlReader.Read
            TextBox3.Text = sqlReader.Item("Resource")

            TextBox5.Text = sqlReader.Item("Instructor")
            DropDownList2.Text = sqlReader.Item("Identifyn")
        End While
        queryrd2()
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        connection()
        sql = "update Resources set name='" & TextBox1.Text & "',Identifyn='" & TextBox1.Text & "' where Entryno=" & TextBox6.Text & " "
        query(sql)
    End Sub
End Class