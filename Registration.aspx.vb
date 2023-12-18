Public Class Registration
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            DropDownList1.Items.Insert("0", "select")
            DropDownList2.Items.Insert("0", "select")
           
        End If
      
      
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click

        Dim g As String = TextBox5.Text
       
       
        Dim DERICK As Boolean
        DERICK = False
        sql = "Select * from student"
        queryrd1(sql)
        While sqlReader.Read
            If TextBox5.Text = sqlReader.Item("REGNO") Then
                DERICK = True
                Response.Write("EXISTS")
                Exit Sub
            Else
                DERICK = False
            End If
        End While
        queryrd2()

        If DERICK = False Then


            connection()
            sql = "insert into student(Branch,Name,Mobileno,idno,regno,Gender,Coursetype)VALUES('" & TextBox6.Text & "','" & TextBox1.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & DropDownList2.Text & "','" & DropDownList1.Text & "')"
            Response.Write("OK")
            query(sql)
        End If
        
     


        connection()
        sql = "select Amount from FeeU WHERE COURSE='" & DropDownList1.Text & "'"
        queryrd11(sql)
        While sqlReader1.Read
            connection()
            sql = "insert into studentReceivedF(Regno,Name,Fees)values('" & TextBox5.Text & "','" & TextBox1.Text & "','" & sqlReader1.Item("Amount") & "')"
            query(sql)
            connection()
            sql = "insert into studentF(Regno,Name,Fees)values('" & TextBox5.Text & "','" & TextBox1.Text & "','" & sqlReader1.Item("Amount") & "')"
            query(sql)
            connection()
            sql = "UPDATE STUDENT SET FEE='" & sqlReader1.Item("Amount") & "' where regno='" & TextBox5.Text & "'"
            query(sql)
        End While
        queryrd21()
        sql = "select max(no) as no from serial"
        queryrd1(sql)
        While sqlReader.Read
            g = g.Remove(0, 4)
            If g = 999 Then

                connection()
                sql = "INSERT INTO serial(no)values(" & sqlReader.Item("no") + 1 & " )"
                query(sql)
            End If

        End While
        queryrd2()
      
    End Sub

    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.Click

        connection()
        sql = "select min(id) as min from student"
        queryrd1(sql)
        While sqlReader.Read
            ' MsgBox(sqlReader.Item("min"))
            TextBox5.Text = sqlReader.Item("min") + 1
        End While
        queryrd2()
        connection()
        sql = "select * from student where id='" & TextBox5.Text & "'"
        queryrd1(sql)
        While sqlReader.Read
            TextBox5.Text = sqlReader.Item("Regno")
            TextBox6.Text = sqlReader.Item("Branch")
            TextBox3.Text = sqlReader.Item("mobileno")
            TextBox4.Text = sqlReader.Item("idno")
            TextBox1.Text = sqlReader.Item("name")
            DropDownList1.Text = sqlReader.Item("Coursetype")
            DropDownList2.Text = sqlReader.Item("Gender")
        End While
        queryrd2()
    End Sub

    Protected Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox5_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox5.Init
        Dim d As String
        Dim j As String
       
        sql = "select regno from student where ID = IDENT_CURRENT('student')"
        queryrd11(sql)
        While sqlReader1.Read
            sql = "select  no from serial where ID = IDENT_CURRENT('serial')"
            queryrd1(sql)

            While sqlReader.Read
                d = sqlReader.Item("no") & "/"

                    Dim k As String = sqlReader1.Item("regno")
                    k = k.Remove(0, 4)

                    TextBox5.Text = k
                    If k = 999 Then
                        k = 1
                        j = d & k
                        TextBox5.Text = j
                    Else
                        k = k + 1
                        k = d & k
                        TextBox5.Text = k
                    End If

            End While
            queryrd2()
        End While
        queryrd21()

      

    End Sub

    Private Sub TextBox5_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox5.Load
      
    End Sub

    Protected Sub TextBox5_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox5.TextChanged
        connection()
        sql = "select * from student where regno='" & TextBox5.Text & "'"
        queryrd1(sql)
        While sqlReader.Read
            TextBox6.Text = sqlReader.Item("Branch")
            TextBox3.Text = sqlReader.Item("mobileno")
            TextBox4.Text = sqlReader.Item("idno")
            TextBox1.Text = sqlReader.Item("name")
            DropDownList1.Text = sqlReader.Item("Coursetype")
            DropDownList2.Text = sqlReader.Item("Gender")
            End While
        queryrd2()
      
    End Sub

    Protected Sub Button6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button6.Click
        connection()
        sql = "select max(id) as max from student"
        queryrd1(sql)
        While sqlReader.Read
            'MsgBox(sqlReader.Item("min"))
            TextBox5.Text = sqlReader.Item("max")
        End While
        queryrd2()
        connection()
        sql = "select * from student where id='" & TextBox5.Text & "'"
        queryrd1(sql)
        While sqlReader.Read
            TextBox5.Text = sqlReader.Item("Regno")
            TextBox6.Text = sqlReader.Item("Branch")
            TextBox3.Text = sqlReader.Item("mobileno")
            TextBox4.Text = sqlReader.Item("idno")
            TextBox1.Text = sqlReader.Item("name")
            DropDownList1.Text = sqlReader.Item("Coursetype")
            DropDownList2.Text = sqlReader.Item("Gender")
        End While
        queryrd2()
    End Sub

    Protected Sub Button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button4.Click
        connection()
        sql = "select id from student where regno='" & TextBox5.Text & "'"
        queryrd1(sql)
        While sqlReader.Read
            TextBox5.Text = sqlReader.Item("id") + 1
        End While
        queryrd2()
        connection()
        sql = "select * from student where id='" & TextBox5.Text & "'"
        queryrd1(sql)
        While sqlReader.Read
            TextBox5.Text = sqlReader.Item("Regno")
            TextBox6.Text = sqlReader.Item("Branch")
            TextBox3.Text = sqlReader.Item("mobileno")
            TextBox4.Text = sqlReader.Item("idno")
            TextBox1.Text = sqlReader.Item("name")
            DropDownList1.Text = sqlReader.Item("Coursetype")
            DropDownList2.Text = sqlReader.Item("Gender")
        End While
        queryrd2()
    End Sub

    Protected Sub Button5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button5.Click
        connection()
        sql = "select id from student where regno='" & TextBox5.Text & "'"
        queryrd1(sql)
        While sqlReader.Read
            TextBox5.Text = sqlReader.Item("id") - 1
        End While
        queryrd2()
        connection()
        sql = "select * from student where id='" & TextBox5.Text & "'"
        queryrd1(sql)
        While sqlReader.Read
            TextBox5.Text = sqlReader.Item("regno")
            TextBox6.Text = sqlReader.Item("Branch")
            TextBox3.Text = sqlReader.Item("mobileno")
            TextBox4.Text = sqlReader.Item("idno")
            TextBox1.Text = sqlReader.Item("name")
            DropDownList1.Text = sqlReader.Item("Coursetype")
            DropDownList2.Text = sqlReader.Item("Gender")
        End While
        queryrd2()
    End Sub

    Protected Sub Button10_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button10.Click
        Response.Redirect("Fees.aspx")
    End Sub

    Protected Sub Button8_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button8.Click
        connection()
        sql = "update student set Firstname='" & TextBox1.Text & "',Mobileno='" & TextBox3.Text & "',idno='" & TextBox4.Text & "',regno='" & TextBox5.Text & "',CourseType='" & DropDownList1.Text & "',Gender='" & DropDownList2.Text & "' where regno='" & TextBox5.Text & "'"
        query(sql)
        TextBox1.Text = " "
        TextBox4.Text = " "
        TextBox3.Text = " "
        TextBox5.Text = " "
        TextBox6.Text = " "
        DropDownList1.Items.Clear()
        DropDownList2.Items.Clear()
    End Sub

    Protected Sub TextBox3_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox3.TextChanged
        If TextBox3.Text.Length > 13 Then
            MsgBox("invalid format")
        End If
    End Sub

    Protected Sub TextBox6_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
      

        Response.Redirect("SDetails.aspx?id=" + TextBox5.Text, False)
    End Sub

    Protected Sub TextBox4_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox4.TextChanged
        If TextBox4.Text.Length > 8 Then
            Response.Write("invalid format")
        End If
    End Sub

    Protected Sub Button11_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button11.Click
        TextBox1.Text = " "
        TextBox4.Text = " "
        TextBox3.Text = " "
        TextBox5.Text = " "
        TextBox6.Text = " "
       
        Dim d As String
        Dim j As String

        sql = "select regno from student where ID = IDENT_CURRENT('student')"
        queryrd11(sql)
        While sqlReader1.Read
            sql = "select max(no) as no from serial"
            queryrd1(sql)
            While sqlReader.Read
                d = sqlReader.Item("no") & "/"

                Dim k As String = sqlReader1.Item("regno")
                k = k.Remove(0, 4)



                TextBox5.Text = k
                If k = 999 Then
                    k = 1
                    j = d & k
                    TextBox5.Text = j
                Else
                    k = k + 1
                    k = d & k
                    TextBox5.Text = k
                End If

            End While
            queryrd2()
        End While
        queryrd21()
    End Sub

    Protected Sub Button12_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button12.Click
        Response.Redirect("Update Fees.aspx")
    End Sub

    Protected Sub Button7_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button7.Click
        Response.Redirect("COLLEGE SYSTEM.aspx")
    End Sub
End Class