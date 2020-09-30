Imports System.Data.SqlClient

Public Class Formsalesreport

    Private Sub Formsalesreport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        connectiondb()
        qry = "select * from tbl_sales"
        cmd = New SqlCommand(qry, con)
        cmd.ExecuteNonQuery()
        Dim adp As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        adp.Fill(dt)
        Dim report As salesReport = New salesReport
        report.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = report
        CrystalReportViewer1.Refresh()
        connection_close()
    End Sub
End Class