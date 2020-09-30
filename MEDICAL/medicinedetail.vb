Imports System.Data.SqlClient
Public Class medicinedetail
    Dim mid, row As Integer

    Private Sub btnnewentry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnewentry.Click
        newmedicine.Show()
        loadmed()
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        If txtmid.Text = "" Then
            MsgBox("Please Enter Medicine ID & then value to update then click update button", MsgBoxStyle.Exclamation)
        Else
            qry = "UPDATE tbl_medicine SET category='" & cmbcatg.Text & "',med_name='" & txtmname.Text & "',manufacture='" & txtmfg.Text & "',exp_date=CONVERT(date,'" & dtpexpiry.Value & "'),mfg_date=CONVERT(date,'" & dtpmfg.Value & "') WHERE m_id='" & txtmid.Text & "'"
                exupdate()
            MsgBox("Data Updated sucessfully", MsgBoxStyle.Information)
        End If
        loadmed()
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        mid = dgvmedicine.Rows(row).Cells(0).Value
        If mid <> 0 Then
            Try
                connectiondb()
                qry = "Delete From tbl_medicine where m_id='" & mid & "'"
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
            loadmed()
        Else
            MsgBox("Please Select One Column of a row to delete entire row and then click delete button to delete", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        svalue = "med"
        search.Show()
    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        reset()
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub medicinedetail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        svalue = "med"
        loadmed()
    End Sub
    Public Sub exupdate()
        connectiondb()
        cmd = New SqlCommand(qry, con)
        cmd.ExecuteNonQuery()
        connection_close()
        reset()
        loadmed()
    End Sub
    Public Sub reset()
        txtmid.Clear()
        txtmname.Clear()
        txtmfg.Clear()
        cmbcatg.ResetText()
        dtpexpiry.Value = Today.Date
        dtpmfg.Value = Today.Date
    End Sub
    Public Sub loadmed()
        i = 0
        dgvmedicine.Rows.Clear()
        connectiondb()
        qry = "select * from tbl_medicine"
        cmd = New SqlCommand(qry, con)
        dr = cmd.ExecuteReader
        While dr.Read = True
            dgvmedicine.Rows.Add()
            dgvmedicine.Item(0, i).Value = dr(0)
            dgvmedicine.Item(1, i).Value = dr(1)
            dgvmedicine.Item(2, i).Value = dr(2)
            dgvmedicine.Item(3, i).Value = dr(3)
            dgvmedicine.Item(4, i).Value = dr(4)
            dgvmedicine.Item(5, i).Value = dr(5)
            i = i + 1
        End While
        connection_close()
    End Sub
    Private Sub dgvmedicine_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvmedicine.CellClick
        Try
            row = dgvmedicine.CurrentCell.RowIndex
            txtmid.Text = dgvmedicine.CurrentRow.Cells(0).Value
        Catch ex As Exception
        End Try
        cmbcatg.Text = dgvmedicine.Rows(row).Cells(1).Value
        txtmname.Text = dgvmedicine.Rows(row).Cells(2).Value
        txtmfg.Text = dgvmedicine.Rows(row).Cells(3).Value
        dtpexpiry.Text = dgvmedicine.Rows(row).Cells(4).Value
        dtpmfg.Text = dgvmedicine.Rows(row).Cells(5).Value
    End Sub
End Class