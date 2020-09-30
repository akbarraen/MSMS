Imports System.Data.SqlClient
Public Class empdetail
    Dim empid, row As Integer
    Dim gen As String
    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        newemp.Show()
        loademp()
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        If rbm.Checked = True Then
            gen = "Male"
        ElseIf rbf.Checked = True Then
            gen = "Female"
        End If

            If txtempid.Text = "" Then
            MsgBox("Please select cell or row to make changes", MsgBoxStyle.Exclamation)
            Else
                qry = "UPDATE tbl_empinfo SET emp_name='" & txtempname.Text & "',emp_phone='" & txtnumb.Text & "',emp_add='" & txtadd.Text & "',emp_gender='" & gen & "',emp_doj=CONVERT(date,'" & dtpjoin.Value & "') WHERE emp_id='" & txtempid.Text & "'"
                    exupdate()
            MsgBox("Data Updated Sucessfully", MsgBoxStyle.Information)

        End If
        loademp()
    End Sub
    Public Sub exupdate()
        connectiondb()
        cmd = New SqlCommand(qry, con)
        cmd.ExecuteNonQuery()
        connection_close()
        reset()
        loademp()
    End Sub
    Public Sub reset()
        txtadd.Clear()
        txtempid.Clear()
        txtempname.Clear()
        txtnumb.Clear()
        rbm.Checked = False
        rbf.Checked = False
        dtpjoin.Value = Today.Date
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        empid = dgvempinfo.Rows(row).Cells(0).Value
        If empid <> 0 Then
            Try
                connectiondb()
                qry = "Delete From tbl_empinfo where emp_id='" & empid & "'"
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
            loademp()
        Else
            MsgBox("Please Select One Column of a row to delete entire row and then click delete button to delete", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub empdetail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label7.Text = ""
        Label8.Text = ""
        svalue = "emp"
        loademp()
    End Sub

    Public Sub loademp()
        i = 0
        dgvempinfo.Rows.Clear()
        connectiondb()
        qry = "select * from tbl_empinfo"
        cmd = New SqlCommand(qry, con)
        dr = cmd.ExecuteReader
        While dr.Read = True
            dgvempinfo.Rows.Add()
            dgvempinfo.Item(0, i).Value = dr(0)
            dgvempinfo.Item(1, i).Value = dr(1)
            dgvempinfo.Item(2, i).Value = dr(2)
            dgvempinfo.Item(3, i).Value = dr(3)
            dgvempinfo.Item(4, i).Value = dr(4)
            dgvempinfo.Item(5, i).Value = dr(5)
            i = i + 1
        End While
        connection_close()
    End Sub

    Private Sub dgvempinfo_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvempinfo.CellClick
        Try
            row = dgvempinfo.CurrentCell.RowIndex
            txtempid.Text = dgvempinfo.CurrentRow.Cells(0).Value
        Catch ex As Exception
        End Try
        txtempname.Text = dgvempinfo.Rows(row).Cells(1).Value
        txtnumb.Text = dgvempinfo.Rows(row).Cells(2).Value
        txtadd.Text = dgvempinfo.Rows(row).Cells(3).Value
        Dim gen As String = dgvempinfo.Rows(row).Cells(4).Value
        If gen.Equals("Male") Then
            rbm.Checked = True
        Else
            rbf.Checked = True
        End If
        dtpjoin.Text = Date.Parse(dgvempinfo.Rows(row).Cells(5).Value())
    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        svalue = "emp"
        search.Show()
    End Sub

    Private Sub txtempname_TextChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtempname.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90)) Then
                Label7.Text = "Only Characters are allowed"
                Label7.ForeColor = Color.Red
                e.Handled = True
            Else
                Label7.Text = ""
            End If
        End If
    End Sub

    Private Sub txtnumb_TextChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnumb.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            If Not (Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46) Then
                Label8.Text = "Only Numbers are allowed"
                Label8.ForeColor = Color.Red
                e.Handled = True
            Else
                Label8.Text = ""
            End If
        End If
    End Sub

    Private Sub txtnumb_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnumb.Leave
        If txtnumb.Text.Trim.Length > 10 Or txtnumb.Text.Trim.Length < 10 Then
            Label8.Text = "Invalid Phone No."
        End If
    End Sub
End Class