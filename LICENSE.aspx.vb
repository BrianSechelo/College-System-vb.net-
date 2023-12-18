Public Class LICENCE
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        ' Dim dtUserDate As DateTime = dtUserDate
        Dim dtUserDate = Calendar1.SelectedDate
        Dim D As Boolean
        D = False
        sql = "SELECT * FROM LICENSE "
        queryrd1(sql)
        While sqlReader.Read
            If TextBox2.Text = sqlReader.Item("IDNO") Then
                D = True
                Response.Write("RECORD EXISTS")
            Else
                D = False

            End If
        End While
        If D = False Then
            connection()
            sql = "INSERT INTO LICENSE(BRANCH,NAME ,IDNO ,CFCNO,DLNO ,INTNO,DOI,ISSUE,STATUS )values('" & TextBox7.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & dtUserDate & "','NOT COLLECTED')"
            query(sql)
        Else
            Exit Sub
        End If
       
        Button2.Enabled = True
    End Sub

    Protected Sub TextBox2_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox2.TextChanged
        Dim smessage As String = String.Empty
        If Not IsNumeric(TextBox2.Text) Then
            smessage += "The ID must be Numeric!" + Environment.NewLine
        End If
        If TextBox2.Text.Length > 8 Then
            Response.Write("invalid format")
        End If
        If TextBox2.Text.Length < 8 Then
            Response.Write("invalid format")
        End If
        connection()
        sql = "SELECT * FROM LICENSE WHERE IDNO='" & TextBox2.Text & "'"
        queryrd1(sql)
        While sqlReader.Read
            TextBox1.Text = sqlReader.Item("NAME")
            TextBox2.Text = sqlReader.Item("IDNO")
            TextBox3.Text = sqlReader.Item("CFCNO")
            TextBox4.Text = sqlReader.Item("DLNO")
            TextBox5.Text = sqlReader.Item("INTNO")
            TextBox6.Text = sqlReader.Item("DOI")
            TextBox7.Text = sqlReader.Item("BRANCH")
            Label9.Text = sqlReader.Item("STATUS")
            If sqlReader.Item("STATUS") = "NOT COLLECTED" Then
                Button2.Enabled = True
            End If
        End While
        queryrd2()
    End Sub

    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.Click
        Response.Redirect("COLLEGE SYSTEM.aspx")
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        Label9.Text = "Collected"
        
            connection()
        sql = "update LICENSE set status='Collected' where IDNo='" & TextBox2.Text & "'"
            query(sql)
        
    End Sub
End Class