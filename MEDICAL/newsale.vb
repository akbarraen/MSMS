Imports System.Data.SqlClient

Public Class newsale
    Dim vat, mrp, total, qty, vatcal, t, stock_unit As Integer
    Dim rem_unit As Integer = 0
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If cmbn_name.Text = "" Or txtmrp.Text = "" Or txtqty.Text = "" Or txtsaleid.Text = "" Or txtvat.Text = "" Then
            MsgBox("Please Fill all the Details to make new entry", MsgBoxStyle.Exclamation)
        Else
            If stock_unit > Integer.Parse(txtqty.Text.Trim()) Then
                mrp = Integer.Parse(txtmrp.Text())
                vat = Integer.Parse(txtvat.Text())
                qty = Integer.Parse(txtqty.Text())
                t = qty * mrp
                vatcal = (t * vat) / 100
                total = t + vatcal
                connectiondb()
                qry = "insert into tbl_sales(saleid,cus_name,med_name,mfgdate,expdate,qty,vat,mrp,total) values('" & txtsaleid.Text & "','" & txtname.Text & "','" & cmbn_name.Text & "',CONVERT(date,'" & dtpmfg.Value & "'),CONVERT(date,'" & dtpexp.Value & "'),'" & txtqty.Text & "','" & txtvat.Text & "','" & txtmrp.Text & "','" & total & "')"
                cmd = New SqlCommand(qry, con)
                cmd.ExecuteNonQuery()
                connection_close()
                MsgBox("Sales Details added", MsgBoxStyle.Information)
                'updating medicine stock after sale
                rem_unit = Integer.Parse(stock_unit) - qty
                connectiondb()
                qry = "update tbl_stock SET munit='" & rem_unit & "' where m_name='" & cmbn_name.Text.Trim() & "'"
                cmd = New SqlCommand(qry, con)
                cmd.ExecuteNonQuery()
                connection_close()
                sales.loadsale()
                stock.stockload()
                If MessageBox.Show("Do you want to genrate a bill?", "Generate Bill", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                    id = Integer.Parse(txtsaleid.Text)
                    BillM.Show()
                End If
                reset()
            Else
                MsgBox("Required Medicine Is not In stock available stock is " + stock_unit.ToString)
            End If
        End If
        inc()
    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        reset()
        inc()
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub
    Public Sub reset()
        cmbn_name.ResetText()
        txtmrp.Clear()
        txtqty.Clear()
        txtname.Clear()
        txtsaleid.Clear()
        txtvat.Clear()
        dtpexp.Value = Today.Date
        dtpmfg.Value = Today.Date
    End Sub

    Private Sub newsale_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label11.Text = ""
        Label10.Text = ""
        Label9.Text = ""
        Label12.Text = ""
        inc()
        connectiondb()
        qry = "Select * from tbl_medicine"
        cmd = New SqlCommand(qry, con)
        dr = cmd.ExecuteReader()
        While (dr.Read())
            cmbn_name.Items.Add(dr(2))
        End While
        connection_close()
    End Sub
    Private Sub cmbn_name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbn_name.TextChanged
        connectiondb()
        qry = "select munit from tbl_stock where m_name='" & cmbn_name.Text.Trim() & "'"
        cmd = New SqlCommand(qry, con)
        dr = cmd.ExecuteReader
        While dr.Read()
            stock_unit = Integer.Parse(dr(0))
        End While
        connection_close()
        connectiondb()
        qry = "Select * from tbl_medicine where med_name='" & cmbn_name.Text.Trim() & "'"
        cmd = New SqlCommand(qry, con)
        dr = cmd.ExecuteReader()
        While (dr.Read())
            dtpmfg.Text = dr(5)
            dtpexp.Text = dr(4)
        End While
        connection_close()
        connectiondb() 'retrieving price of a medicine
        qry = "Select * from tbl_order where m_name='" & cmbn_name.Text.Trim() & "'"
        cmd = New SqlCommand(qry, con)
        dr = cmd.ExecuteReader()
        While (dr.Read())
            txtmrp.Text = dr(6).ToString()
        End While
        connection_close()
    End Sub

    Private Sub txtqty_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtqty.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            If Not (Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46) Then
                Label9.Text = "Only Numbers are allowed"
                Label9.ForeColor = Color.Red
                e.Handled = True
            Else
                Label9.Text = ""
            End If
        End If
    End Sub

    Private Sub txtvat_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtvat.KeyPress
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

    Private Sub txtname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtname.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90)) Then
                Label11.Text = "Only Characters are allowed"
                Label11.ForeColor = Color.Red
                e.Handled = True
            Else
                Label11.Text = ""
            End If
        End If
    End Sub
    Public Sub inc()
        connectiondb()
        Dim value As Integer = 1
        qry = "Select * from tbl_sales"
        cmd = New SqlCommand(qry, con)
        dr = cmd.ExecuteReader()
        While (dr.Read())
            value = Integer.Parse(dr(0).ToString()) + 1
        End While
        txtsaleid.Text = value
        connection_close()
    End Sub

    Private Sub txtmrp_TextChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmrp.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            If Not (Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46) Then
                Label12.Text = "Only Numbers are allowed"
                Label12.ForeColor = Color.Red
                e.Handled = True
            Else
                Label12.Text = ""
            End If
        End If
    End Sub
End Class