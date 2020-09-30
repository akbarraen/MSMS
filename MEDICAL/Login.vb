Imports System.Data.SqlClient
Public Class Login
    Dim user, pass, u, p As String
    Dim ds1 As New DataSet
    Private Sub btclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btclear.Click
        usertype.Text = ""
        txtuser.Clear()
        txtpass.Clear()
    End Sub

    Private Sub btcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btcancel.Click
        Me.Close()
    End Sub

    Private Sub btlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btlogin.Click
        If usertype.Text = "" Or txtpass.Text = "" Or txtuser.Text = "" Then
            MsgBox("Please enter the login details", MsgBoxStyle.Exclamation)
        Else
            connectiondb()
            qry = "select * from login where Utype='" & usertype.Text & "' and Uname='" & txtuser.Text & "' and Password='" & txtpass.Text & "'"
            cmd = New SqlCommand(qry, con)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                Utype = usertype.Text
                Uname = txtuser.Text
                Password = txtpass.Text
                main.Show()
                Me.Close()
            Else
                MsgBox("Wrong Usertype", MsgBoxStyle.Exclamation)
                txtpass.Clear()
                txtuser.Clear()
            End If
            connection_close()
        End If
    End Sub

    Private Sub txtuser_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtuser.TextChanged
        Dim u, user As String
        u = ""
        user = txtuser.Text
        connectiondb()
        qry = "select * from login where ((Uname like '%" & txtuser.Text & "%'))"
        cmd = New SqlCommand(qry, con)
        dr = cmd.ExecuteReader
        While dr.Read()
            u = dr(1)
        End While
        If user.Equals(u) Then
            Label2.Visible = True
        Else
            Label2.Visible = False
        End If
        connection_close()
    End Sub

    Private Sub txtpass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpass.TextChanged
        Dim p, pass As String
        p = ""
        pass = txtpass.Text
        connectiondb()
        qry = "select * from login where ((Password like '%" & txtpass.Text & "%'))"
        cmd = New SqlCommand(qry, con)
        dr = cmd.ExecuteReader
        While dr.Read()
            p = dr(2)
        End While
        If pass.Equals(p) Then
            Label3.Visible = True
        Else
            Label3.Visible = False
        End If
        connection_close()
    End Sub
    Private Sub txtuser_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtuser.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Back) Then
            txtuser.Clear()
        End If
    End Sub
    Private Sub txtpass_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpass.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Back) Then
            txtpass.Clear()
        End If
    End Sub
End Class
