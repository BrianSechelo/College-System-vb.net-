Public Class Fees
    Inherits System.Web.UI.Page

    Function NumberToText(ByVal n As Integer) As String
        Select Case n
            Case 0
                Return " "
            Case 1 To 19
                Dim arr() As String = {"One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve",
                                     "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"}
                Return arr(n - 1) & " "

            Case 20 To 99
                Dim arr() As String = {"Twenty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"}
                Return arr(n \ 10 - 2) & " " & NumberToText(n Mod 10)

            Case 100 To 199
                Return "One Hundred" & NumberToText(n Mod 100)
            Case 200 To 999
                Return NumberToText(n \ 100) & "Hundred" & NumberToText(n Mod 100)
            Case 1000 To 1999
                Return "One Thousand" & NumberToText(n Mod 1000)
            Case 2000 To 999999
                Return NumberToText(n \ 1000) & "Thousand" & NumberToText(n Mod 1000)
            Case 1000000 To 1999999
                Return "One Million" & NumberToText(n Mod 1000000)
        End Select
        Return n
    End Function
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

       
        If Not IsPostBack Then
            sql = "select distinct regno from studentf"
            queryrd1(sql)
            While sqlReader.Read
                DropDownList1.Items.Add(sqlReader.Item("regno"))
            End While
            queryrd2()
            DropDownList1.Items.Insert("0", "choose")
        End If
       

    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DropDownList1.SelectedIndexChanged
        If IsPostBack Then
            connection()
            sql = "select * from StudentReceivedF where regno='" & DropDownList1.Text & "'"
            queryrd1(sql)
            While sqlReader.Read
                TextBox2.Text = sqlReader.Item("Fees")
                TextBox6.Text = sqlReader.Item("Name")
            End While
            queryrd2()
        End If
       

       
        connection()
        sql = "SELECT max(ReceiptNO) as no FROM ReceiveF"
        queryrd1(sql)
        While sqlReader.Read
            TextBox3.Text = sqlReader.Item("no") + 1
        End While
        queryrd2()
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Dim shaheera As Boolean
        shaheera = False
        Dim k As DateTime
        k = Date.Now
        connection()
        sql = "update StudentReceivedF set Fees='" & TextBox2.Text & "' where regno='" & DropDownList1.Text & "' "
        query(sql)
        sql = "select * from ReceiveF"
        queryrd1(sql)
        While sqlReader.Read
            If TextBox3.Text = sqlReader.Item("ReceiptNO") Then
                shaheera = True
                ' Response.Write("That Receipt No exists")
                Dim err As New CustomValidator
                err.ValidationGroup = "Mygroup"
                err.IsValid = False
                err.ErrorMessage = "That Receipt No exists"
                Page.Validators.Add(err)
                Response.Write("That Receipt No exists")
                Exit Sub
            Else
                shaheera = False

            End If
        End While
        queryrd2()
        If shaheera = False Then
            connection()
            sql = "insert into ReceiveF(Date ,AccountNo ,NAME,Balance ,AmountPaid ,WORDS,ReceiptNO)values('" & k & "','" & DropDownList1.Text & "','" & TextBox6.Text & "','" & TextBox2.Text & "','" & TextBox1.Text & "','" & TextBox4.Text & "','" & TextBox3.Text & "')"
            query(sql)
        End If
        

    End Sub

    Private Sub TextBox1_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.Disposed

    End Sub

    Protected Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox1.TextChanged
        TextBox2.Text = Val(TextBox2.Text) - Val(TextBox1.Text)
        TextBox4.Text = NumberToText(TextBox1.Text)
    End Sub

    Private Sub TextBox1_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.Unload

    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        ' Dim x As Integer
        'Context.Items(" dropdownlist1 ") = x
        'Server.Transfer("UNIK.aspx")

        'Response.Redirect("UNIK.aspx", False)
        'Response.Redirect("UNIK.aspx?Name" = DropDownList1.Text)
        Dim shaheera As Boolean
        shaheera = False
        Dim k As DateTime
        k = Date.Now
        connection()
        sql = "update StudentReceivedF set Fees='" & TextBox2.Text & "' where regno='" & DropDownList1.Text & "' "
        query(sql)
        connection()
        sql = "select * from ReceiveF"
        queryrd1(sql)
        While sqlReader.Read
            If TextBox3.Text = sqlReader.Item("ReceiptNO") Then
                shaheera = True
                ' Response.Write("That Receipt No exists")
                Dim err As New CustomValidator
                err.ValidationGroup = "Mygroup"
                err.IsValid = False
                err.ErrorMessage = "That Receipt No exists"
                Page.Validators.Add(err)
                Response.Write("That Receipt No exists")
                Exit Sub
            Else
                shaheera = False

            End If
        End While
        queryrd2()
        If shaheera = False Then
            connection()
            sql = "insert into ReceiveF(Date ,AccountNo ,NAME,Balance ,AmountPaid ,WORDS,ReceiptNO)values('" & k & "','" & DropDownList1.Text & "','" & TextBox6.Text & "','" & TextBox2.Text & "','" & TextBox1.Text & "','" & TextBox4.Text & "','" & TextBox3.Text & "')"
            query(sql)
        End If
        Response.Redirect("UNIK.aspx?id=" + TextBox3.Text, False)


    End Sub

    Protected Sub Button5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button5.Click
        Response.Redirect("COLLEGE SYSTEM.aspx")
    End Sub

    Private Sub TextBox3_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.Init
       
    End Sub

   
    Protected Sub TextBox3_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox3.TextChanged
       
    End Sub

    Protected Sub Button13_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button13.Click
        Response.Redirect("Update Fees.aspx")
    End Sub
End Class