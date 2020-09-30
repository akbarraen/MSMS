Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class newsupplier
    Dim sid As Integer = 400
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click

        If txtoid.Text = "" And txtsid.Text = "" And txtsname.Text = "" Then
            MsgBox("Please Fill all Details to Make a New Entry", MsgBoxStyle.Exclamation)
        Else
            connectiondb()
            qry = "insert into tbl_supplier(s_id,o_id,s_name,email,s_date) values('" & txtsid.Text & "','" & txtoid.Text & "','" & txtsname.Text & "','" & txtemail.Text & "',CONVERT(date,'" & dtpsupply.Value & "'))"
            cmd = New SqlCommand(qry, con)
            cmd.ExecuteNonQuery()
            connection_close()
            MsgBox("Supplier Details added", MsgBoxStyle.Information)
            reset()
            inc()
        End If
        supplier.loadsupp()
    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        reset()
        inc()
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub
    Public Sub reset()
        txtoid.ResetText()
        txtsid.Clear()
        txtsname.Clear()
        dtpsupply.Value = Today.Date
    End Sub


    Private Sub newsupplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label6.Text = ""
        Label7.Text = ""
        txtsid.Text = sid
        sid = sid + 1
        connectiondb()
        qry = "Select * from tbl_order"
        cmd = New SqlCommand(qry, con)
        dr = cmd.ExecuteReader()
        While (dr.Read())
            txtoid.Items.Add(dr(0))
        End While
        connection_close()
        inc()
    End Sub

    Private Sub txtsname_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsname.Leave
        Dim pattern As String = "^[a-zA-Z\s]+$"
        If (Regex.IsMatch(txtsname.Text, pattern)) Then
            Label6.Text = ""
        Else
            Label6.Text = "Only Characters are allowed"
            Label6.ForeColor = Color.Red
            txtsname.Clear()
        End If
    End Sub

    Private Sub txtemail_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtemail.Leave
        Dim pattern As String = "^[a-z][a-z|0-9|]*([_][a-z|0-9]+)*([.][a-z|0-9]+([_][a-z|0-9]+)*)?@[a-z][a-z|0-9|]*\.([a-z][a-z|0-9]*(\.[a-z][a-z|0-9]*)?)$"
        If (Regex.IsMatch(txtemail.Text, pattern)) Then
            Label7.Text = ""
        Else
            Label7.Text = "Not a Valid Email"
            Label7.ForeColor = Color.Red
            txtemail.Clear()
        End If
    End Sub
    Public Sub inc()
        Dim value As Integer = 300
        connectiondb()
        qry = "Select * from tbl_supplier"
        cmd = New SqlCommand(qry, con)
        dr = cmd.ExecuteReader()
        While (dr.Read())
            value = Integer.Parse(dr(0).ToString()) + 1
        End While
        txtsid.Text = value
    End Sub
End Class