Imports System.Data.SqlClient
Public Class stock
    Dim row, mname As Integer
    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        svalue = "stock"
        search.Show()
    End Sub

    Private Sub stock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        svalue = "stock"
        stockload()
    End Sub
    Public Sub stockload()
        i = 0
        dgvstock.Rows.Clear()
        connectiondb()
        qry = "select * from tbl_stock"
        cmd = New SqlCommand(qry, con)
        dr = cmd.ExecuteReader
        While dr.Read = True
            dgvstock.Rows.Add()
            dgvstock.Item(0, i).Value = dr(0)
            dgvstock.Item(1, i).Value = dr(1)
            dgvstock.Item(2, i).Value = dr(2)
            i = i + 1
        End While
        connection_close()
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Try
            connectiondb()
            qry = "Delete From tbl_stock where munit='" & mname & "'"
            cmd = New SqlCommand(qry, con)
            cmd.ExecuteNonQuery()
            If MessageBox.Show("Do you really want to Delete this Record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
                MsgBox("Operation Cancelled")
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show("Error while deleting record on table..." & ex.Message, "Delete Records")
        Finally
            connection_close()
        End Try
        stockload()
    End Sub

    Private Sub dgvstock_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvstock.CellClick
        Try
            row = dgvstock.CurrentCell.RowIndex
        Catch ex As Exception
        End Try
        mname = Integer.Parse(dgvstock.Rows(row).Cells(1).Value)
    End Sub
End Class