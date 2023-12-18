Public Class Update_Fees
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            DropDownList1.Items.Insert("0", "select")
        End If
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        connection()
        sql = "insert into FeeU(Course,Amount)values('" & DropDownList1.Text & "','" & TextBox1.Text & "')"
        query(sql)
        
    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DropDownList1.SelectedIndexChanged
        connection()
        sql = "select * from FeeU where Course='" & DropDownList1.Text & "'"
        queryrd11(sql)
        While sqlReader1.Read

            TextBox1.Text = sqlReader1.Item("Amount")
        End While
        queryrd21()
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        connection()
        sql = "UPDATE FEEU SET AMOUNT='" & TextBox1.Text & "' WHERE COURSE='" & DropDownList1.Text & "'"
        query(sql)
       
    End Sub
End Class