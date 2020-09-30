Imports System.Data.SqlClient
Public Class neworder
    Dim price, unit, total As Integer
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If txtmanuf.Text = "" And txtmedname.Text = "" And txtmedunit.Text = "" And txtorderid.Text = "" And txtpriceperunit.Text = "" Then
            MsgBox("Please Fill all Details to Make a New Entry", MsgBoxStyle.Exclamation)
        Else
            price = Integer.Parse(txtpriceperunit.Text)
            unit = Integer.Parse(txtmedunit.Text)
            total = unit * price
            connectiondb()
            qry = "insert into tbl_order(o_id,o_date,m_category,m_name,manufacture,m_unit,priceunit,total_amt) values('" & txtorderid.Text & "',Convert(date,'" & dtporderdate.Text & "'),'" & cmb_category.Text & "','" & txtmedname.Text & "','" & txtmanuf.Text & "','" & txtmedunit.Text & "','" & txtpriceperunit.Text & "','" & total & "')"
            cmd = New SqlCommand(qry, con)
            cmd.ExecuteNonQuery()
            connection_close()
            connectiondb() 'entry for a medicine stock
            qry = "insert into tbl_stock values('" & txtmedname.Text & "','" & txtmedunit.Text & "',CONVERT(date,'" & dtporderdate.Value & "'))"
            cmd = New SqlCommand(qry, con)
            cmd.ExecuteNonQuery()
            connection_close()
            MsgBox("Order Details added", MsgBoxStyle.Information)
            reset()
            inc()
        End If
        orderdetail.loadorder()
    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        reset()
        inc()
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub
    Public Sub reset()
        txtorderid.ResetText()
        txtmanuf.Clear()
        txtmedname.Clear()
        txtmedunit.Clear()
        cmb_category.ResetText()
        txtpriceperunit.Clear()
        dtporderdate.Value = Today.Date
    End Sub

    Private Sub neworder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label8.Text = ""
        Label9.Text = ""
        Label10.Text = ""
        Label11.Text = ""
        inc()
    End Sub
    Public Sub inc()
        Dim value As Integer = 1
        connectiondb()
        qry = "Select * from tbl_order"
        cmd = New SqlCommand(qry, con)
        dr = cmd.ExecuteReader()
        While (dr.Read())
            value = Integer.Parse(dr(0).ToString()) + 1
        End While
        txtorderid.Text = value
        connection_close()
    End Sub

    Private Sub txtmedname_TextChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmedname.KeyPress
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

    Private Sub txtpriceperunit_TextChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpriceperunit.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            If Not (Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46) Then
                Label11.Text = "Only Numbers are allowed"
                Label11.ForeColor = Color.Red
                e.Handled = True
            Else
                Label11.Text = ""
            End If
        End If
    End Sub

    Private Sub txtmedunit_TextChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmedunit.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            If Not (Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46) Then
                Label10.Text = "Only Numbers are allowed"
                Label10.ForeColor = Color.Red
                e.Handled = True
            Else
                Label10.Text = ""
            End If
        End If
    End Sub

    Private Sub txtmanuf_TextChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmanuf.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90)) Then
                Label9.Text = "Only Characters are allowed"
                Label9.ForeColor = Color.Red
                e.Handled = True
            Else
                Label9.Text = ""
            End If
        End If
    End Sub
End Class