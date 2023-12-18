Public Class SDetails
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            'Label1.Text = Request.QueryString("id").ToString()
            Dim oRpt As New skul()
            Dim dbtable, str As String
            dbtable = "Student"
            str = " SELECT * FROM Student where RegNo='" & Request.QueryString("id").ToString() & "' "
            queryrptt(str, dbtable)
            oRpt = New skul()
            oRpt.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = oRpt
            Session("Report") = oRpt
            ' MsgBox(ds.Tables(0).Rows.Count)
        Else
            CrystalReportViewer1.ReportSource = Session("Report")
        End If
    End Sub

End Class