Imports System.Data.SqlClient
Public Class empsalary
    Dim row, empid As Integer

    Private Sub btnnewentry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnewentry.Click
        newsalary.Show()
        loadsal()
    End Sub

    Private Sub empsalary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label5.Text = ""
        Label6.Text = ""
        loadsal()
    End Sub

    Private Sub BTNupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNupdate.Click
        If txtempid.Text = "" Then
            MsgBox("Please click on any row to update", MsgBoxStyle.Exclamation)
        Else
            qry = "UPDATE tbl_empsalary SET sal_amt='" & txtsalary.Text & "',sal_adv='" & txtsaladv.Text & "',sal_remain='" & txtcalsal.Text & "',sal_date=CONVERT(date,'" & dtpsalary.Value & "') WHERE emp_id='" & txtempid.Text & "'"
            exupdate()
            MsgBox("Salary Amount Updated", MsgBoxStyle.Information)

        End If
    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        svalue = "empsal"
        search.Show()
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub
    Public Sub exupdate()
        connectiondb()
        cmd = New SqlCommand(qry, con)
        cmd.ExecuteNonQuery()
        connection_close()
        loadsal()
    End Sub
    Private Sub reset()
        txtcalsal.Text = ""
        txtempid.Text = ""
        txtsaladv.Text = ""
        txtsalary.Text = ""
        dtpsalary.Value = Today.Date
    End Sub
    Public Sub loadsal()
        i = 0
        dgvempsal.Rows.Clear()
        connectiondb()
        qry = "select * from tbl_empsalary"
        cmd = New SqlCommand(qry, con)
        dr = cmd.ExecuteReader
        While dr.Read = True
            dgvempsal.Rows.Add()
            dgvempsal.Item(0, i).Value = dr(0)
            dgvempsal.Item(1, i).Value = dr(1)
            dgvempsal.Item(2, i).Value = dr(2)
            dgvempsal.Item(3, i).Value = dr(3)
            dgvempsal.Item(4, i).Value = dr(4)
            i = i + 1
        End While
        connection_close()
    End Sub

    Private Sub btncalsal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncalsal.Click
        Dim a, b, c As Integer
        If txtempid.Text = "" Or txtsaladv.Text = "" Or txtsalary.Text = "" Then
            MsgBox("Enter ID,Salary and Advance Salary to Calculate Remaining salary")

        Else
            a = Integer.Parse(txtsalary.Text)
            b = Integer.Parse(txtsaladv.Text)
            c = a - b
            txtcalsal.Text = c
            MsgBox("Remaining Salary value is updated to table")
            qry = "UPDATE tbl_empsalary SET sal_remain='" & c & "' WHERE emp_id='" & txtempid.Text & "'"
            exupdate()
        End If

    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        empid = dgvempsal.Rows(row).Cells(0).Value
        If empid <> 0 Then
            Try
                connectiondb()
                qry = "Delete From tbl_empsalary where emp_id='" & empid & "'"
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
            loadsal()
        Else
            MsgBox("Please Select One Column of a row to delete entire row and then click delete button to delete", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub dgvempsal_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvempsal.CellClick
        Try
            row = dgvempsal.CurrentCell.RowIndex
            txtempid.Text = dgvempsal.CurrentRow.Cells(0).Value
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        reset()
    End Sub

    Private Sub txtempid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtempid.TextChanged
        txtsalary.Text = dgvempsal.Rows(row).Cells(1).Value
        txtsaladv.Text = dgvempsal.Rows(row).Cells(2).Value
        dtpsalary.Text = dgvempsal.Rows(row).Cells(3).Value
        txtcalsal.Text = dgvempsal.Rows(row).Cells(4).Value
    End Sub

    Private Sub txtsalary_TextChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsalary.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            If Not (Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46) Then
                Label5.Text = "Only Numbers are allowed"
                Label5.ForeColor = Color.Red
                e.Handled = True
            Else
                Label5.Text = ""
            End If
        End If
    End Sub

    Private Sub txtsaladv_TextChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsaladv.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            If Not (Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46) Then
                Label6.Text = "Only Numbers are allowed"
                Label6.ForeColor = Color.Red
                e.Handled = True
            Else
                Label6.Text = ""
            End If
        End If
    End Sub

End Class