Public Class orderReport

    Private Sub medReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MEDDATADataSet.tbl_order' table. You can move, or remove it, as needed.
        Me.tbl_orderTableAdapter.Fill(Me.MEDDATADataSet.tbl_order)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class