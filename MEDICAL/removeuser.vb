Imports System.Data.SqlClient

Public Class removeuser

    Private Sub removeuser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        useradd()
    End Sub
    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub
    Private Sub btnconfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconfirm.Click
        Dim user As String = cmbname.Text
        Dim u As String = ""
        connectiondb()
        qry = "select * from login where Uname='" & cmbname.Text & "' and Password='" & txtpass.Text & "'"
        cmd = New SqlCommand(qry, con)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            u = dr(1).ToString()
        Else
            MsgBox("Invalid Password", MsgBoxStyle.Exclamation)
            txtpass.Clear()
        End If
        connection_close()
        If user.Equals(u) Then
            connectiondb()
            qry = "delete from login where Uname='" & cmbname.Text.Trim() & "'"
            If MessageBox.Show("Do you really want to Delete this Record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
                MsgBox("Operation Cancelled")
                Exit Sub
            End If
            cmd = New SqlCommand(qry, con)
            cmd.ExecuteNonQuery()
            MsgBox(u + " username has removed from system", MsgBoxStyle.Information)
        End If
        useradd()
    End Sub
    Public Sub useradd()
        connectiondb()
        qry = "Select uname from login"
        cmd = New SqlCommand(qry, con)
        dr = cmd.ExecuteReader()
        While dr.Read()
            cmbname.Items.Add(dr(0).ToString)
        End While
        connection_close()
    End Sub
End Class