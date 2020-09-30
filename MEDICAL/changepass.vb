Imports System.Data.SqlClient
Public Class changepass
    Private Sub btnsavechange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsavechange.Click
        If txtoldpass.Text = "" Or txtnewpass.Text = "" Or txtnewpassconfirm.Text = "" Then
            MsgBox("Please Enter Valid Password", MsgBoxStyle.Exclamation)
        Else
            connectiondb()
            qry = "select * from login where Uname='" & uname & "' and Password='" & txtoldpass.Text & "'"
            cmd = New SqlCommand(qry, con)
            dr = cmd.ExecuteReader

            If dr.Read = False Then
                MsgBox("Incorrect Old Password", MsgBoxStyle.Information)
                txtoldpass.Clear()
            Else
                If txtnewpass.Text <> txtnewpassconfirm.Text Then
                    MsgBox("New Password And Confirm Password Should be Same", MsgBoxStyle.Exclamation)
                    txtnewpass.Clear()
                    txtnewpassconfirm.Clear()
                Else
                    connection_close()
                    connectiondb()
                    qry = "update login set Password='" & txtnewpass.Text & "' where Uname='" & uname & "' and Password='" & txtoldpass.Text & "'"
                    cmd = New SqlCommand(qry, con)
                    cmd.ExecuteNonQuery()
                    connection_close()
                    MsgBox("Password Changed Sucessfully", MsgBoxStyle.Exclamation)
                    reset()
                End If
            End If
        End If
    End Sub
    Public Sub reset()
        txtoldpass.Clear()
        txtnewpass.Clear()
        txtnewpassconfirm.Clear()
    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        reset()
    End Sub
End Class