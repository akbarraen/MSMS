Imports System.Data.SqlClient

Public Class empreportvb
    Private Sub empreportvb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connectiondb()
        qry = "select * from tbl_empinfo"
        cmd = New SqlCommand(qry, con)
        cmd.ExecuteNonQuery()
        Dim adp As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        adp.Fill(dt)
        Dim report As empreport = New empreport
        report.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = report
        CrystalReportViewer1.Refresh()
        connection_close()
    End Sub
End Class