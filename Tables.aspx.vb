Public Class Tables
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        connection()
        sql = "create database Driving"
        query(sql)
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        connection()
        sql = "drop table student"
        query(sql)
        connection()
        sql = "create table student(id int identity(1,1),Branch varchar(50),Name varchar(50),Regno varchar(50),mobileno int,idno int,Gender varchar(20),Coursetype varchar(50),FEE varchar(50),WORDS varchar(50))"
        query(sql)
        connection()
        sql = "insert into student(regno)values('288/0')"
        query(sql)

    End Sub

    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.Click
        connection()
        sql = "drop table instructor"
        query(sql)
        connection()
        sql = "create table instructor(Name varchar(50),mobileno int,idno int,Responsibility varchar(50))"
        query(sql)
    End Sub

    Protected Sub Button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button4.Click
        connection()
        sql = "drop table resources"
        query(sql)
        connection()
        sql = "create table resources(Entryno int identity(1,1), name varchar(50),Identifyn varchar(50),INSTRUCTOR varchar(50))"
        query(sql)
    End Sub

    Protected Sub Button5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button5.Click
        connection()
        sql = "drop table resourceSt"
        query(sql)
        connection()
        sql = "create table resourceSt(Identifyn varchar(50),Resource varchar(50),Student varchar(50),Instructor varchar(50))"
        query(sql)
    End Sub

    Protected Sub Button6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button6.Click
        connection()
        sql = "create table resourceI(ResourceI varchar(50),Instructor varchar(50))"
        query(sql)
    End Sub

    Protected Sub Button7_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button7.Click
        connection()
        sql = "drop table FeeU"
        query(sql)
        connection()
        sql = "create table FeeU(Course varchar(50),Amount int)"
        query(sql)

    End Sub

    Protected Sub Button8_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button8.Click
        connection()
        sql = "drop table ReceiveF"
        query(sql)
        connection()
        sql = "create table ReceiveF(Date datetime,ReceiptNO int,AccountNo varchar(50),Name varchar(50),AmountPaid int,Words varchar(50),Balance int)"
        query(sql)
    End Sub

    Protected Sub Button9_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button9.Click
        '  connection()
        ' sql = "Drop table users"
        'query(sql)
        'connection()
        'sql = "create table users(Name varchar(50),Email varchar(50),Idno int,Password varchar(50))"
        'query(sql)
        connection()
        sql = "insert into users(Name,Email,Password)values('Admin','admin@gmail.com','admin')"
        query(sql)
    End Sub

    Protected Sub Button10_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button10.Click
        connection()
        sql = "create table course(Name varchar(50),code varchar(50))"
        query(sql)
    End Sub

    Protected Sub Button11_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button11.Click
        connection()
        sql = "drop table studentA"
        query(sql)
        connection()
        sql = "create table studentA(RegNo varchar(50),Name varchar(50),Course varchar(50))"
        query(sql)
    End Sub

    Protected Sub Button12_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button12.Click
        connection()
        sql = "drop table studentF"
        query(sql)
        connection()

        sql = "create table studentF(RegNo varchar(50),Name varchar(50),Fees int)"
        query(sql)
    End Sub

    Protected Sub Button13_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button13.Click
        connection()
        sql = "drop table studentReceivedF"
        query(sql)
        connection()
        sql = "create table studentReceivedF(Date datetime,RegNo varchar(50),Name varchar(50),Receiptno int,Paid int,Fees int)"
        query(sql)
    End Sub

    Protected Sub Button14_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button14.Click
        connection()
        sql = "drop table LICENSE"
        query(sql)
        connection()
        sql = "CREATE TABLE LICENSE(Branch varchar(50),NAME VARCHAR(50),IDNO INT,CFCNO INT,DLNO INT,INTNO INT,DOI VARCHAR(50),ISSUE DATETIME,STATUS varchar(50))"
        query(sql)
    End Sub

    Protected Sub Button15_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button15.Click

        'connection()
        'sql = "DROP TABLE serial"
        'query(sql)
        'connection()
        ' sql = "create Table serial(ID INT IDENTITY(1,1),no int)"
        '  query(sql)
        connection()
        sql = "INSERT INTO SERIAL(NO)VALUES(288)"
        query(sql)
    End Sub
End Class