Public Class About
    Inherits System.Windows.Forms.Form
    
    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click, Button1.Click
        Me.Close()
    End Sub

    
    Private Sub lbemail_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lbemail.LinkClicked
        System.Diagnostics.Process.Start("http:\\mail.gmail.com")
    End Sub
End Class