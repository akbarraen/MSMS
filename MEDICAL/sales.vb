Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class sales
    Dim row, saleid As Integer
    Private Sub btnaddnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaddnew.Click
        newsale.Show()
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        If txtsaleid.Text = "" Then
            MsgBox("Please Enter Sales ID & then value to update then click update button", MsgBoxStyle.Exclamation)
        Else
            If txtmid.Text.Trim.Length > 0 Then
                qry = "UPDATE tbl_sales SET med_name='" & txtmid.Text & "',mfgdate=CONVERT(date,'" & dtpmfg.Value & "'),expdate=CONVERT(date,'" & dtpexpdate.Value & "') WHERE saleid='" & txtsaleid.Text & "'"
                exupdate()
                MsgBox("Data Updated sucessfull", MsgBoxStyle.Information)
            End If

        End If
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        saleid = dgvsale.Rows(row).Cells(0).Value
        If saleid <> 0 Then
            Try
                connectiondb()
                qry = "Delete From tbl_sales where saleid='" & saleid & "'"
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
            loadsale()
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

    Private Sub sales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label6.Text = ""
        Label7.Text = ""
        svalue = "sale"
        loadsale()
    End Sub

    Private Sub dgvsale_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvsale.CellClick
        Try
            row = dgvsale.CurrentCell.RowIndex
            id = dgvsale.Rows(row).Cells(0).Value
        Catch ex As Exception
        End Try
        txtsaleid.Text = dgvsale.Rows(row).Cells(0).Value
        txtname.Text = dgvsale.Rows(row).Cells(1).Value
        txtmid.Text = dgvsale.Rows(row).Cells(2).Value
        dtpexpdate.Text = dgvsale.Rows(row).Cells(4).Value
        dtpmfg.Text = dgvsale.Rows(row).Cells(3).Value
    End Sub
    Public Sub reset()
        txtmid.Clear()
        txtsaleid.Clear()
        dtpmfg.Value = Today.Date
        dtpexpdate.Value = Today.Date
    End Sub
    Public Sub loadsale()
        i = 0
        dgvsale.Rows.Clear()
        connectiondb()
        qry = "select * from tbl_sales"
        cmd = New SqlCommand(qry, con)
        dr = cmd.ExecuteReader
        While dr.Read = True
            dgvsale.Rows.Add()
            dgvsale.Item(0, i).Value = dr(0)
            dgvsale.Item(1, i).Value = dr(1)
            dgvsale.Item(2, i).Value = dr(2)
            dgvsale.Item(3, i).Value = dr(3)
            dgvsale.Item(4, i).Value = dr(4)
            dgvsale.Item(5, i).Value = dr(5)
            dgvsale.Item(6, i).Value = dr(6)
            dgvsale.Item(7, i).Value = dr(7)
            dgvsale.Item(8, i).Value = dr(8)
            i = i + 1
        End While
        connection_close()
    End Sub
    Public Sub exupdate()
        connectiondb()
        cmd = New SqlCommand(qry, con)
        cmd.ExecuteNonQuery()
        connection_close()
        reset()
        loadsale()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        BillM.Show()
    End Sub

    Private Sub txtmid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmid.TextChanged
        Dim pattern As String = "^[a-zA-Z\s]+$"
        If (Regex.IsMatch(txtmid.Text, pattern)) Then
            Label7.Text = ""
        Else
            Label7.Text = "Only Characters are allowed"
            Label7.ForeColor = Color.Red
            txtmid.Clear()
        End If
    End Sub

    Private Sub txtname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtname.TextChanged
        Dim pattern As String = "^[a-zA-Z\s]+$"
        If (Regex.IsMatch(txtname.Text, pattern)) Then
            Label7.Text = ""
        Else
            Label7.Text = "Only Characters are allowed"
            Label7.ForeColor = Color.Red
            txtname.Clear()
        End If
    End Sub
End Class