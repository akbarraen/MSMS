Imports System.Data.SqlClient
Public Class orderdetail
    Dim row, oid As Integer

    Private Sub btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click
        neworder.Show()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If txtorderid.Text = "" Then
            MsgBox("Please Enter Order ID & value to update then click update button", MsgBoxStyle.Exclamation)
        Else
                qry = "UPDATE tbl_order SET m_name='" & txtmedname.Text & "',m_unit='" & txtmedunit.Text & "',manufacture='" & txtmanuf.Text & "',priceunit='" & txtpriceperunit.Text & "',o_date=CONVERT(date,'" & dtporderdate.Value & "'),total_amt='" & txttotalAmount.Text & "' WHERE o_id='" & txtorderid.Text & "'"
            exupdate()
            qry = "update tbl_stock SET m_name'" & txtmedname.Text & "',munit='" & txtmedunit.Text & "',stock=CONVERT(date,'" & dtporderdate.Value & "') WHERE m_name='" & txtmedname.Text & "'"
                MsgBox("Data Updated sucessfully", MsgBoxStyle.Information)
        End If
        loadorder()
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        oid = dgvorder.Rows(row).Cells(0).Value
        If oid <> 0 Then
            Try
                connectiondb()
                qry = "Delete From tbl_order where o_id='" & oid & "'"
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
            loadorder()
        Else
            MsgBox("Please Select One Column of a row to delete entire row and then click delete button to delete", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        search.Show()
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub dgvorder_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvorder.CellClick
        Try
            row = dgvorder.CurrentCell.RowIndex
            txtorderid.Text = dgvorder.CurrentRow.Cells(0).Value
        Catch ex As Exception
        End Try
        dtporderdate.Text = dgvorder.Rows(row).Cells(1).Value
        cmb_category.Text = dgvorder.Rows(row).Cells(2).Value
        txtmedname.Text = dgvorder.Rows(row).Cells(3).Value
        txtmanuf.Text = dgvorder.Rows(row).Cells(4).Value
        txtmedunit.Text = dgvorder.Rows(row).Cells(5).Value
        txtpriceperunit.Text = dgvorder.Rows(row).Cells(6).Value
        txttotalAmount.Text = dgvorder.Rows(row).Cells(7).Value
    End Sub
    Public Sub exupdate()
        connectiondb()
        cmd = New SqlCommand(qry, con)
        cmd.ExecuteNonQuery()
        connection_close()
        reset()
        loadorder()
    End Sub
    Public Sub reset()
        txtorderid.Clear()
        txtmanuf.Clear()
        txtmedname.Clear()
        txtmedunit.Clear()
        cmb_category.ResetText()
        txtpriceperunit.Clear()
        txttotalAmount.Clear()
        dtporderdate.Value = Today.Date
    End Sub
    Public Sub loadorder()
        i = 0
        dgvorder.Rows.Clear()
        connectiondb()
        qry = "select * from tbl_order"
        cmd = New SqlCommand(qry, con)
        dr = cmd.ExecuteReader
        While dr.Read = True
            dgvorder.Rows.Add()
            dgvorder.Item(0, i).Value = dr(0)
            dgvorder.Item(1, i).Value = dr(1)
            dgvorder.Item(2, i).Value = dr(2)
            dgvorder.Item(3, i).Value = dr(3)
            dgvorder.Item(4, i).Value = dr(4)
            dgvorder.Item(5, i).Value = dr(5)
            dgvorder.Item(6, i).Value = dr(6)
            dgvorder.Item(7, i).Value = dr(7)
            i = i + 1
        End While
        connection_close()
    End Sub

    Private Sub orderdetail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        svalue = "order"
        loadorder()
    End Sub
End Class