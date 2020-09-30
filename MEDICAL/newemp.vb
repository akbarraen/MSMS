Imports System.Data.SqlClient
Public Class newemp
    Dim gen
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If txtempname.Text = "" Or txtnumb.Text = "" Or txtadd.Text = "" Or (rbm.Checked = False And rbf.Checked = False) Then
            MsgBox("Please Enter valid Details", MsgBoxStyle.Exclamation)
        ElseIf txtnumb.Text.Length < 10 Or txtnumb.Text.Length > 10 Then
            MsgBox("Invalid Phone Number", MsgBoxStyle.Exclamation)
            txtnumb.Focus()
        Else
            If rbm.Checked = True Then
                gen = "Male"
            ElseIf rbf.Checked = True Then
                gen = "Female"
            End If
            connectiondb()
            qry = "insert into tbl_empinfo(emp_id,emp_name,emp_phone,emp_add,emp_gender,emp_doj) values('" & txtempid.Text & "','" & txtempname.Text & "','" & txtnumb.Text & "','" & txtadd.Text & "','" & gen & "',CONVERT(date,'" & dtpjoin.Value & "'))"
            cmd = New SqlCommand(qry, con)
            cmd.ExecuteNonQuery()
            connection_close()
            MsgBox("Employee Details added", MsgBoxStyle.Information)
            reset()
            inc()
        End If
        empdetail.loademp()
    End Sub
    Public Sub reset()
        txtadd.Clear()
        txtempname.Clear()
        txtnumb.Clear()
        txtempid.Clear()
        rbf.Checked = False
        rbm.Checked = False
        dtpjoin.Value = Today.Date
    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        reset()
        inc()
    End Sub

    Private Sub newemp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label7.Text = ""
        Label8.Text = ""
        dtpjoin.Format = DateTimePickerFormat.Custom
        dtpjoin.CustomFormat = " "
        inc()
    End Sub

    Private Sub txtnumb_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnumb.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            If Not (Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46) Then
                Label7.Text = "Only Numbers are allowed"
                Label7.ForeColor = Color.Red
                e.Handled = True
            Else
                Label7.Text = ""
            End If
        End If
    End Sub

    Private Sub txtempname_TextChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtempname.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90)) Then
                Label8.Text = "Only Characters are allowed"
                Label8.ForeColor = Color.Red
                e.Handled = True
            Else
                Label8.Text = ""
            End If
        End If
    End Sub
    Public Sub inc()
        Dim value As Integer = 1
        connectiondb()
        qry = "Select * from tbl_empinfo"
        cmd = New SqlCommand(qry, con)
        dr = cmd.ExecuteReader()
        While (dr.Read())
            value = Integer.Parse(dr(0).ToString()) + 1
        End While
        txtempid.Text = value
        connection_close()
    End Sub
End Class