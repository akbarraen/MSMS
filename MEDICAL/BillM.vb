Imports System.Data.SqlClient

Public Class BillM

    Private Sub bill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connectiondb()
        Integer.Parse(id)
        qry = "select saleid,cus_name,med_name,qty,vat,total from tbl_sales where saleid='" & id & "'"
        cmd = New SqlCommand(qry, con)
        cmd.ExecuteNonQuery()
        Dim adp As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        adp.Fill(dt)
        Dim report As billreport = New billreport
        report.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = report
        CrystalReportViewer1.Refresh()
        connection_close()
    End Sub
End Class