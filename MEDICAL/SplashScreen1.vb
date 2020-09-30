Public NotInheritable Class SplashScreen1


    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.ProgressBar1.Style = ProgressBarStyle.Continuous
        Dim frm As New Login
        Label3.Text = ProgressBar1.Value & "%"
        Me.ProgressBar1.Value = Me.ProgressBar1.Value + 1
        If Me.ProgressBar1.Value = 100 Then
            frm.Show()
            Timer1.Enabled = False
            Me.Hide()
        End If
    End Sub
End Class
