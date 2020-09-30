Imports System.Data.SqlClient
Public Class usercreation

    Private Sub btncreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncreate.Click
        If txtconfirm.Text = "" Or txtname.Text = "" Or txtpwd.Text = "" Then
            MsgBox("Please Enter Required Fields", MsgBoxStyle.Exclamation)
        ElseIf txtpwd.Text <> txtconfirm.Text Then
            MsgBox("Please Confirm The Password", MsgBoxStyle.Exclamation)
            txtpwd.Clear()
            txtconfirm.Clear()
        Else
            connectiondb()
            qry = "insert into login(Utype,Uname,Password)values ('" & cmbutype.Text & "','" & txtname.Text & "','" & txtpwd.Text & "')"
            cmd = New SqlCommand(qry, con)
            cmd.ExecuteNonQuery()
            connection_close()
            MsgBox(txtname.Text + "  USER added to the system", MsgBoxStyle.Information)
            reset()
        End If
    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        reset()
    End Sub
    Public Sub reset()
        cmbutype.Text() = ""
        txtname.Clear()
        txtpwd.Clear()
        txtconfirm.Clear()
    End Sub
End Class