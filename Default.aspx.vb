Public Class AssignResources
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            connection()
            sql = "select * from Resources"
            queryrd1(sql)
            While sqlReader.Read
                DropDownList4.Items.Add(sqlReader.Item("name"))
            End While
            queryrd2()
            connection()
            sql = "select firstname+' '+secondname as name from student"
            queryrd1(sql)
            While sqlReader.Read
                DropDownList5.Items.Add(sqlReader.Item("name"))
            End While
            queryrd2()
            connection()
            sql = "select firstname+' '+secondname as name from instructor"
            queryrd1(sql)
            While sqlReader.Read
                DropDownList6.Items.Add("name")
            End While
            queryrd2()
            DropDownList4.Items.Insert("0", "select")
            DropDownList5.Items.Insert("0", "select")
            DropDownList6.Items.Insert("0", "select")
            DropDownList7.Items.Insert("0", "choose")
        End If
      
    End Sub

    Protected Sub DropDownList4_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DropDownList4.SelectedIndexChanged

    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        If DropDownList7.Text = "student" Then
            connection()
            sql = "insert into resourcest(resource,student)values('" & DropDownList4.Text & "','" & DropDownList5.Text & "')"
            query(sql)
        ElseIf DropDownList7.Text = "Instructor" Then
            connection()
            sql = "insert into resourcesI(resourceI,instructor)VALUES('" & DropDownList4.Text & "','" & DropDownList6.Text & "')"
            query(sql)
        End If
      
       
    End Sub

    Protected Sub DropDownList7_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DropDownList7.SelectedIndexChanged
       
        If DropDownList7.Text = " student" Then
            Label7.Visible = True
            DropDownList5.Visible = True
            MsgBox("student")
        ElseIf DropDownList7.Text = "instructor" Then
            Label8.Visible = True
            DropDownList6.Visible = True
            MsgBox("teacher")
        End If
        MsgBox("nothing")
    End Sub
End Class