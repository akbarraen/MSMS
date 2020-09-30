Imports System.Data.SqlClient
Public Class newsalary

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        connectiondb()
        Dim a, b, c As Integer
        a = Integer.Parse(txtsalary.Text)
        b = Integer.Parse(txtsaladv.Text)
        c = a - b
        qry = "insert into tbl_empsalary(emp_id,sal_amt,sal_adv,sal_date,sal_remain) values('" & txtempid.Text & "','" & txtsalary.Text & "','" & txtsaladv.Text & "',CONVERT(date,'" & dtpsalary.Value & "'),'" & c & "')"
        cmd = New SqlCommand(qry, con)
        cmd.ExecuteNonQuery()
        connection_close()
        empsalary.loadsal()
        MsgBox("Employee Salary Details added", MsgBoxStyle.Information)
        inc()
    End Sub

    Private Sub btreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btreset.Click
        txtempid.Text = ""
        txtsalary.Text = ""
        txtsaladv.Text = ""
        dtpsalary.Value = Today.Date
        inc()
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Hide()
    End Sub

    Private Sub newsalary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label5.Text = ""
        Label6.Text = ""
        inc()
    End Sub

    Private Sub txtsalary_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsalary.KeyPress
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

    Private Sub txtsaladv_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsaladv.KeyPress
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
    Public Sub inc()
        connectiondb()
        qry = "Select * from tbl_empinfo"
        cmd = New SqlCommand(qry, con)
        dr = cmd.ExecuteReader()
        While (dr.Read())
            txtempid.Items.Add(dr(0).ToString())
        End While
        connection_close()
    End Sub
End Class