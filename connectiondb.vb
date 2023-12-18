Imports System.Data.SqlClient
Module connectiondb
    Public conn As SqlConnection
    Public cmd As SqlCommand
    Public da As SqlDataAdapter
    Public da1 As SqlDataAdapter
    Public ds As DataSet
    Public connetionString As String
    Public cnn As SqlConnection
    Public sql, db, username, upassword As String
    Public sqlReader As SqlDataReader
    Public sqlReader1 As SqlDataReader
    Public sqlReader11, sqlReader111 As SqlDataReader
    Public itemcoll(100) As String
    Dim server As String = ".\SQLEXPRESS"
    Public commandbuilder As SqlCommandBuilder
    Public commandbuilder1 As SqlCommandBuilder
    Public dt As New DataTable
    Public dt1 As New DataTable
    'User ID=alicia;Password=alicia
    'Public wdbs As String = "test"
    ' Public wdbs As String = Tables.driving



    Public Sub queryrptt(ByVal sql As String, ByVal dbtable As String)
        cnn = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=driving;integrated security=SSPI;Connect Timeout=3000; pooling='true'; Max Pool Size=3000")
        da = New SqlDataAdapter(sql, cnn)
        ds = New DataSet
        cnn.Open()
        da.Fill(ds, "" & dbtable & "")
        cnn.Close()

    End Sub
    Public Sub queryudvr(ByVal sql As String, ByVal datagridview1 As Object)
        cnn = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=driving;integrated security=SSPI;Connect Timeout=3000; pooling='true'; Max Pool Size=3000")
        dt = New DataTable
        da = New SqlDataAdapter(sql, cnn)
        commandbuilder = New SqlCommandBuilder(da)

        da.Fill(dt)
        datagridview1.DataSource = dt

    End Sub




    Public Sub connection()
        connetionString = "Data Source=.\SQLEXPRESS;Initial Catalog=driving;integrated security=SSPI;Connect Timeout=3000; pooling='true'; Max Pool Size=3000"
        cnn = New SqlConnection(connetionString)
        cnn.Open()

    End Sub
    Public Sub connection1()
        connetionString = "Data Source=.\SQLEXPRESS;Initial Catalog=master;integrated security=SSPI;Connect Timeout=3000; pooling='true'; Max Pool Size=3000"
        cnn = New SqlConnection(connetionString)
        cnn.Open()
    End Sub
    Public Sub query(ByVal sql As String)
        cmd = New SqlCommand(sql, cnn)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        cnn.Close()
        Beep()
    End Sub
    Public Sub query1(ByVal sql As String)
        cmd = New SqlCommand(sql, cnn)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        cnn.Close()
        Beep()
    End Sub
    Public Sub queryrd1111(ByVal sql As String)
        connetionString = "Data Source=.\SQLEXPRESS;Initial Catalog=driving;integrated security=SSPI;Connect Timeout=3000; pooling='true'; Max Pool Size=3000"
        cnn = New SqlConnection(connetionString)
        cnn.Open()
        cmd = New SqlCommand(sql, cnn)
        sqlReader111 = cmd.ExecuteReader()

    End Sub
    Public Sub queryrd2111()
        sqlReader111.Close()
        cmd.Dispose()
        cnn.Close()
    End Sub
    Public Sub queryrd1(ByVal sql As String)
        connetionString = "Data Source=.\SQLEXPRESS;Initial Catalog=driving;integrated security=SSPI;Connect Timeout=3000; pooling='true'; Max Pool Size=3000"
        cnn = New SqlConnection(connetionString)
        cnn.Open()
        cmd = New SqlCommand(sql, cnn)
        sqlReader = cmd.ExecuteReader()

    End Sub
    Public Sub queryrd2()
        sqlReader.Close()
        cmd.Dispose()
        cnn.Close()
    End Sub




    Public Sub querychart(ByVal sql As String, ByVal chart1 As Object)
        cnn = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=driving;integrated security=SSPI;Connect Timeout=3000; pooling='true'; Max Pool Size=3000")
        cmd = New SqlCommand(sql, cnn)
        da = New SqlDataAdapter(sql, cnn)
        ds = New DataSet()

        cnn.Open()
        da.Fill(ds, "Authors_table")
        cnn.Close()
        chart1.DataSource = ds.Tables("Authors_table")

    End Sub



    Public Sub queryrd111(ByVal sql As String)
        connetionString = "Data Source=.\SQLEXPRESS;Initial Catalog=driving;integrated security=SSPI;Connect Timeout=3000; pooling='true'; Max Pool Size=3000"
        cnn = New SqlConnection(connetionString)
        cnn.Open()
        cmd = New SqlCommand(sql, cnn)
        sqlReader11 = cmd.ExecuteReader()

    End Sub
    Public Sub queryrd211()
        sqlReader11.Close()
        cmd.Dispose()
        cnn.Close()
    End Sub

    Public Sub queryrd11(ByVal sql As String)
        connetionString = "Data Source=.\SQLEXPRESS;Initial Catalog=driving;integrated security=SSPI;Connect Timeout=3000; pooling='true'; Max Pool Size=3000"
        cnn = New SqlConnection(connetionString)
        cnn.Open()
        cmd = New SqlCommand(sql, cnn)
        sqlReader1 = cmd.ExecuteReader()

    End Sub
    Public Sub querynv(ByVal Str As String)
        cnn = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=driving;integrated security=SSPI;Connect Timeout=3000; pooling='true'; Max Pool Size=3000")
        dt = New DataTable
        da = New SqlDataAdapter(Str, cnn)
        commandbuilder = New SqlCommandBuilder(da)
        da.Fill(dt)

    End Sub
    Public Sub queryrd21()
        sqlReader1.Close()
        cmd.Dispose()
        cnn.Close()
    End Sub
    Public Sub querybc()
        Using bulkCopy As SqlBulkCopy = New SqlBulkCopy(cnn)
            bulkCopy.DestinationTableName = "AVERAGEmaster"
            Try
                sqlReader = cmd.ExecuteReader
                bulkCopy.WriteToServer(sqlReader)
                sqlReader.Close()
                cnn.Close()

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Using
    End Sub


    Public Sub rpt2(ByVal dset As DataSet)
        cmd.CommandType = CommandType.Text
        da = New SqlClient.SqlDataAdapter()
        da.SelectCommand = cmd
        ds = New DataSet
        da.Fill(ds, "sdetails")
    End Sub
    Public Function pointstograde(ByVal mango As Double) As String
        pointstograde = ""
        If mango > 0 And mango < 1.5 Then
            pointstograde = "E"
        ElseIf mango >= 1.5 And mango < 2.5 Then
            pointstograde = "D-"
        ElseIf mango >= 2.5 And mango < 3.5 Then
            pointstograde = "D"
        ElseIf mango >= 3.5 And mango < 4.5 Then
            pointstograde = "D+"
        ElseIf mango >= 4.5 And mango < 5.5 Then
            pointstograde = "C-"
        ElseIf mango >= 5.5 And mango < 6.5 Then
            pointstograde = "C"
        ElseIf mango >= 6.5 And mango < 7.5 Then
            pointstograde = "C+"
        ElseIf mango >= 7.5 And mango < 8.5 Then
            pointstograde = "B-"
        ElseIf mango >= 8.5 And mango < 9.5 Then
            pointstograde = "B"
        ElseIf mango >= 9.5 And mango < 10.5 Then
            pointstograde = "B+"
        ElseIf mango >= 10.5 And mango < 11.5 Then
            pointstograde = "A-"
        ElseIf mango >= 11.5 And mango <= 12 Then
            pointstograde = "A"
        Else
            'MsgBox "invalid points"
        End If
        Return pointstograde
    End Function
    Public Function gradetopts(ByVal grade As String) As Double
        If grade = "A" Then
            gradetopts = 12
        ElseIf grade = "A-" Then
            gradetopts = 11
        ElseIf grade = "B+" Then
            gradetopts = 10
        ElseIf grade = "B" Then
            gradetopts = 9
        ElseIf grade = "B-" Then
            gradetopts = 8
        ElseIf grade = "C+" Then
            gradetopts = 7
        ElseIf grade = "C" Then
            gradetopts = 6
        ElseIf grade = "C-" Then
            gradetopts = 5
        ElseIf grade = "D+" Then
            gradetopts = 4
        ElseIf grade = "D" Then
            gradetopts = 3
        ElseIf grade = "D-" Then
            gradetopts = 2
        ElseIf grade = "E" Then
            gradetopts = 1
        ElseIf grade = "-" Then
            gradetopts = 0
        Else
            gradetopts = 0

        End If
    End Function

    Public Function promomks(ByVal MARKS As Double) As String
        Dim str As String

        str = "select * from GRADING WHERE NUM=2"
        queryrd1(str)


        While sqlReader.Read
            If MARKS >= sqlReader.Item("APLAINU") And MARKS <= sqlReader.Item("APLAINL") Then
                Return "A"
            ElseIf MARKS >= sqlReader.Item("AMINUSU") And MARKS <= sqlReader.Item("AMINUSL") + 0.999999 Then
                Return "A-"
            ElseIf MARKS >= sqlReader.Item("BPLUSU") And MARKS <= sqlReader.Item("BPLUSL") + 0.999999 Then
                Return "B+"
            ElseIf MARKS >= sqlReader.Item("BPLAINU") And MARKS <= sqlReader.Item("BPLAINL") + 0.999999 Then
                Return "B"
            ElseIf MARKS >= sqlReader.Item("BMINUSU") And MARKS <= sqlReader.Item("BMINUSL") + 0.999999 Then
                Return "B-"
            ElseIf MARKS >= sqlReader.Item("CPLUSU") And MARKS <= sqlReader.Item("CPLUSL") + 0.999999 Then
                Return "C+"
            ElseIf MARKS >= sqlReader.Item("CPLAINU") And MARKS <= sqlReader.Item("CPLAINL") + 0.999999 Then
                Return "C"
            ElseIf MARKS >= sqlReader.Item("CMINUSU") And MARKS <= sqlReader.Item("CMINUSL") + 0.999999 Then
                Return "C-"
            ElseIf MARKS >= sqlReader.Item("DPLUSU") And MARKS <= sqlReader.Item("DPLUSL") + 0.999999 Then
                Return "D+"
            ElseIf MARKS >= sqlReader.Item("DPLAINU") And MARKS <= sqlReader.Item("DPLAINL") + 0.999999 Then
                Return "D"
            ElseIf MARKS >= sqlReader.Item("DMINUSU") And MARKS <= sqlReader.Item("DMINUSL") + 0.999999 Then
                Return "D-"
            ElseIf MARKS >= sqlReader.Item("EPLAINU") And MARKS <= sqlReader.Item("EPLAINL") + 0.999999 Then
                Return "E"
            ElseIf MARKS > 100 Then
                MsgBox("YOUR MARKS" & MARKS & " WAS MORE THAN 100")
                If MARKS = 111 Then
                    MsgBox("ALLOWED FOR IRREGULARITIES")
                    Return "Y"
                ElseIf MARKS = 112 Then
                    MsgBox("ALLOWED FOR MISS")
                    Return "X"
                End If
            ElseIf MARKS < 0 Then
                MsgBox("YOUR MARKS" & MARKS & " WAS LESS THAN 0")
            End If
        End While
        Return "XY"
    End Function
End Module
