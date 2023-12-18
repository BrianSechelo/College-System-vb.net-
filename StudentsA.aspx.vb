Public Class StudentsA
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            DropDownList1.Items.Insert("0", "select")
        End If
    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DropDownList1.SelectedIndexChanged
        sql = "select Firstname +' '+Secondname as name from student where regno='" & DropDownList1.Text & "'"
        ' MsgBox(sql)
        queryrd1(sql)
        While sqlReader.Read
            TextBox1.Text = sqlReader.Item("name")
        End While
        queryrd2()

    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Dim Eunice As Boolean
        Eunice = False
        Dim k As Single
        sql = "select * from studentA where regno='" & DropDownList1.Text & "'"

        queryrd11(sql)
        While sqlReader1.Read
            If DropDownList2.Text = sqlReader1.Item("Course") Then
                Eunice = True
                MsgBox("exists")
                Exit Sub
            Else
                Eunice = False

            End If
        End While
        queryrd2()
        If Eunice = False Then
            connection()
            sql = "insert into studentA(Regno,Name,Course)values('" & DropDownList1.Text & "','" & TextBox1.Text & "','" & DropDownList2.Text & "')"
            query(sql)
        End If
        
       

        sql = "select * from FeeU where course='" & DropDownList2.Text & "'"
        queryrd1(sql)
        While sqlReader.Read
            sql = "select * from studentF where regno=" & DropDownList1.Text & ""
            queryrd11(sql)
            While sqlReader1.Read
                If IsDBNull(sqlReader1.Item("Fees")) Then
                    k = 0
                Else
                    k = sqlReader1.Item("Fees")

                End If
            End While
            queryrd21()
            k = k + sqlReader.Item("Amount")
        End While
        queryrd2()
        Dim f As DateTime
        f = Date.Now
        connection()
        sql = "update studentF set Fees=" & k & " where regno=" & DropDownList1.Text & " "
        query(sql)

        connection()
        sql = "update studentReceivedF set Fees= " & k & ",Date='" & f & "' where  regno='" & DropDownList1.Text & "'"
        query(sql)

    End Sub

    Private Sub DropDownList1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DropDownList1.TextChanged
        
    End Sub

    Protected Sub SqlDataSource2_Selecting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceSelectingEventArgs) Handles SqlDataSource2.Selecting

    End Sub
End Class