Imports System.Data.SqlClient
Public Class newmedicine

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If cmboid.Text = "" Or txtmfg.Text = "" Or txtmname.Text = "" Then
            MsgBox("Please Enter valid Details", MsgBoxStyle.Exclamation)
        Else
            connectiondb()
            qry = "insert into tbl_medicine(m_id,category,med_name,manufacture,exp_date,mfg_date) values('" & txtmid.Text & "','" & cmbcatg.Text & "','" & txtmname.Text & "','" & txtmfg.Text & "',CONVERT(date,'" & dtpexpiry.Text & "'),CONVERT(date,'" & dtpmfg.Text & "'))"
            cmd = New SqlCommand(qry, con)
            cmd.ExecuteNonQuery()
            connection_close()
            MsgBox("Medicine Details added", MsgBoxStyle.Information)
            inc()
        End If
        medicinedetail.loadmed()
    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        txtmfg.Text = ""
        cmboid.Text = ""
        txtmid.Text = ""
        txtmname.Text = ""
        cmbcatg.Text = ""
        dtpexpiry.Value = Today.Date
        dtpexpiry.Value = Today.Date
        inc()
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub newmedicine_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connectiondb()
        qry = "Select * from tbl_order"
        cmd = New SqlCommand(qry, con)
        dr = cmd.ExecuteReader()
        While (dr.Read())
            cmboid.Items.Add(dr(0))
        End While
        connection_close()
        inc()
    End Sub

    Private Sub cmboid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmboid.SelectedIndexChanged
        connectiondb()
        qry = "Select * from tbl_order where o_id=" & cmboid.Text.Trim() & ""
        cmd = New SqlCommand(qry, con)
        dr = cmd.ExecuteReader()
        While (dr.Read())
            cmbcatg.Text = dr(2).ToString()
            txtmname.Text = dr(3).ToString()
            txtmfg.Text = dr(4).ToString()
        End While
        connection_close()
        inc()
    End Sub
    Public Sub inc()
        connectiondb()
        Dim midc As Integer = 1
        qry = "Select * from tbl_medicine"
        cmd = New SqlCommand(qry, con)
        dr = cmd.ExecuteReader()
        While (dr.Read())
            midc = Integer.Parse(dr(0).ToString()) + 1
        End While
        txtmid.Text = midc
        connection_close()
    End Sub
End Class