Imports CrystalDecisions.CrystalReports.Engine
Public Class UNIK
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '   Dim Field1 As String = (Session("Field1"))
        '  Dim x As Integer = CType(Context.Items("myPara"), Integer)
        If Not IsPostBack Then
            'Label1.Text = Request.QueryString("id").ToString()
            Dim oRpt As New money()
            Dim dbtable, str As String
            dbtable = "RECEIVEF"
            str = " SELECT * FROM RECEIVEF where ReceiptNo='" & Request.QueryString("id").ToString() & "'"
            queryrptt(str, dbtable)
            oRpt = New money()
            oRpt.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = oRpt
            ' MsgBox(ds.Tables(0).Rows.Count)
            Session("Report") = oRpt
        Else
            CrystalReportViewer1.ReportSource = Session("Report")
        End If
       
    End Sub

    Private Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
      
    End Sub
End Class