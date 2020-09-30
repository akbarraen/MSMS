Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class supplier
    Dim row, sid As Integer

    Private Sub btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click
        newsupplier.Show()
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        If txtsid.Text = "" Then
            MsgBox("Please Enter Supplier ID & value to update then click update button", MsgBoxStyle.Exclamation)
        Else
            qry = "UPDATE tbl_supplier SET o_id='" & txtoid.Text & "',s_name='" & txtsname.Text & "',email='" & txtemail.Text & "',s_date=CONVERT(date,'" & dtpsupply.Value & "') WHERE s_id='" & txtsid.Text & "'"
            exupdate()
            MsgBox("Data Updated sucessfully", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        sid = dgvsupplier.Rows(row).Cells(0).Value
        If sid <> 0 Then
            Try
                connectiondb()
                qry = "Delete From tbl_supplier where s_id='" & sid & "'"
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
            loadsupp()
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
    Public Sub exupdate()
        connectiondb()
        cmd = New SqlCommand(qry, con)
        cmd.ExecuteNonQuery()
        connection_close()
        reset()
        loadsupp()
    End Sub
    Public Sub reset()
        txtoid.Clear()
        txtsid.Clear()
        txtsname.Clear()
        dtpsupply.Value = Today.Date
    End Sub
    Public Sub loadsupp()
        i = 0
        dgvsupplier.Rows.Clear()
        connectiondb()
        qry = "select * from tbl_supplier"
        cmd = New SqlCommand(qry, con)
        dr = cmd.ExecuteReader
        While dr.Read = True
            dgvsupplier.Rows.Add()
            dgvsupplier.Item(0, i).Value = dr(0)
            dgvsupplier.Item(1, i).Value = dr(1)
            dgvsupplier.Item(2, i).Value = dr(2)
            dgvsupplier.Item(3, i).Value = dr(3)
            dgvsupplier.Item(4, i).Value = dr(4)
            i = i + 1
        End While
        connection_close()
    End Sub

    Private Sub dgvsupplier_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvsupplier.CellClick
        Try
            row = dgvsupplier.CurrentCell.RowIndex
            txtsid.Text = dgvsupplier.CurrentRow.Cells(0).Value
        Catch ex As Exception
        End Try
        txtoid.Text = dgvsupplier.Rows(row).Cells(1).Value
        txtemail.Text = dgvsupplier.Rows(row).Cells(2).Value
        txtsname.Text = dgvsupplier.Rows(row).Cells(3).Value
        dtpsupply.Text = dgvsupplier.Rows(row).Cells(4).Value
    End Sub

    Private Sub supplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label6.Text = ""
        Label7.Text = ""
        Label8.Text = ""
        svalue = "supplier"
        loadsupp()
    End Sub

    Private Sub txtemail_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtemail.Leave
        Dim pattern As String = "^[a-z][a-z|0-9|]*([_][a-z|0-9]+)*([.][a-z|0-9]+([_][a-z|0-9]+)*)?@[a-z][a-z|0-9|]*\.([a-z][a-z|0-9]*(\.[a-z][a-z|0-9]*)?)$"
        If (Regex.IsMatch(txtemail.Text, pattern)) Then
            Label6.Text = ""
        Else
            Label6.Text = "Not a Valid Email"
            Label6.ForeColor = Color.Red
            txtemail.Clear()
        End If
    End Sub

    Private Sub txtsname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsname.TextChanged
        Dim pattern As String = "^[a-zA-Z\s]+$"
        If (Regex.IsMatch(txtsname.Text, pattern)) Then
            Label7.Text = ""
        Else
            Label7.Text = "Only Characters are allowed"
            Label7.ForeColor = Color.Red
            txtsname.Clear()
        End If
    End Sub

    Private Sub txtoid_Keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtoid.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            If Not (Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46) Then
                Label8.Text = "Only Numbers are allowed"
                Label8.ForeColor = Color.Red
            Else
                Label8.Text = ""
            End If
        End If
    End Sub
End Class