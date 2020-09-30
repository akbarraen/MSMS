Imports System.Data.SqlClient
Public Class search
    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click

        Select Case ComboBox1.Text
            Case "Employee ID", "Name", "Address"
                qry = "select * from tbl_empinfo where ((emp_id like '%" & TextBox1.Text & "%') OR (emp_name like '%" & TextBox1.Text & "%') OR (emp_add like '%" & TextBox1.Text & "%'))"
                search()
            Case "EmployeeId", "Amount"
                qry = "select * from tbl_empsalary where ((emp_id like '%" & TextBox1.Text & "%') OR (sal_amt like '%" & TextBox1.Text & "%'))"
                search()
            Case "Medicine ID", "Category", "Medicine Name", "Manufacture"
                qry = "select * from tbl_medicine where ((m_id like '%" & TextBox1.Text & "%') OR (category like '%" & TextBox1.Text & "%') OR (med_name like '%" & TextBox1.Text & "%') OR (manufacture like '%" & TextBox1.Text & "%'))"
                search()
            Case "Order ID", "Medicine Category", "MedicineName", "manufacture", "Total Amount"
                qry = "select * from tbl_order where ((o_id like '%" & TextBox1.Text & "%') OR (m_category like '%" & TextBox1.Text & "%') OR (m_name like '%" & TextBox1.Text & "%') OR (manufacture like '%" & TextBox1.Text & "%') OR (total_amt like '%" & TextBox1.Text & "%'))"
                search()
            Case "Supplier ID", "OrderID", "MedicineID", "Supplier Name"
                qry = "select * from tbl_supplier where ((s_id like '%" & TextBox1.Text & "%') OR (o_id like '%" & TextBox1.Text & "%') OR (m_id like '%" & TextBox1.Text & "%') OR (s_name like '%" & TextBox1.Text & "%'))"
                search()
            Case "medicineName", "MedicineUnit", "Stock Date"
                qry = "select * from tbl_stock where (((m_name like '%" & TextBox1.Text & "%') OR (munit like '%" & TextBox1.Text & "%') OR (stock_date like '%" & TextBox1.Text & "%'))"
                search()
            Case "Sales ID", "Qty", "Medicine_ID", "MRP"
                qry = "select * from tbl_sales where ((saleid like '%" & TextBox1.Text & "%') OR (qty like '%" & TextBox1.Text & "%') OR (mid like '%" & TextBox1.Text & "%') OR (mrp like '%" & TextBox1.Text & "%'))"
                search()
            Case Else

        End Select
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        svalue = "default"
        Me.Close()
    End Sub
    Private Sub search()
        connectiondb()
        cmd = New SqlCommand(qry, con)
        Dim da As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        If (da.Fill(table)) Then
            dgvempsearch.DataSource = table
            MsgBox("Match Found", MsgBoxStyle.Information)
        Else
            MsgBox("Match Not Found", MsgBoxStyle.Exclamation)
        End If
        connection_close()

    End Sub

    Private Sub search_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If svalue = "emp" Then
            ComboBox1.Items.AddRange({"Employee ID", "Name", "Address"})
        End If
        If svalue = "empsal" Then
            ComboBox1.Items.AddRange({"EmployeeId", "Amount"})
        End If
        If svalue = "med" Then
            ComboBox1.Items.AddRange({"Medicine ID", "Category", "Medicine Name", "Manufacture"})
        End If
        If svalue = "order" Then
            ComboBox1.Items.AddRange({"Order ID", "Medicine Category", "MedicineName", "manufacture", "Total Amount"})
        End If
        If svalue = "supplier" Then
            ComboBox1.Items.AddRange({"Supplier ID", "OrderID", "MedicineID", "Supplier Name"})
        End If
        If svalue = "stock" Then
            ComboBox1.Items.AddRange({"medicineName", "MedicineUnit", "Stock Date"})
        End If
        If svalue = "sale" Then
            ComboBox1.Items.AddRange({"Sales ID", "Qty", "Medicine_ID", "MRP"})
        End If
    End Sub

    Private Sub btndatareset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndatareset.Click
        dgvempsearch.DataSource = Nothing
        dgvempsearch.Refresh()
    End Sub
End Class