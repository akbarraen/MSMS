Imports System.Data.SqlClient
Public Class main
    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub btncal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncal.Click
        Shell("calc.exe", AppWinStyle.NormalFocus)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        If MsgBoxResult.Yes = MsgBox("Do you want to Exit?", MsgBoxStyle.YesNo) Then
            Me.Close()
        End If
    End Sub

    Private Sub main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        UserToolStripMenuItem.Text = Uname.ToUpper
        Label1.Text = "Welcome " + Uname.ToUpper
        lbday.Text = WeekdayName(Weekday(Today))
        lbdate.Text = Today
        If Utype = "STAFF" Then
            AdmiToolStripMenuItem.Visible = False
            EmployeeToolStripMenuItem.Visible = False
            RemoveUserToolStripMenuItem.Visible = False
            OrderDetailsToolStripMenuItem.Visible = False
            EmpToolStripMenuItem.Visible = False
            MedicineToolStripMenuItem1.Visible = False
        Else
            ChangePasswordToolStripMenuItem2.Visible = False
        End If
    End Sub

    Private Sub UserCreationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserCreationToolStripMenuItem.Click
        usercreation.Show()
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        changepass.Show()
    End Sub

    Private Sub empdetailmenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles empdetailmenu.Click
        empdetail.Show()
    End Sub

    Private Sub salarydetailmenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles salarydetailmenu.Click
        empsalary.Show()
    End Sub

    Private Sub MedicineDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MedicineDetailsToolStripMenuItem.Click
        medicinedetail.Show()
    End Sub

    Private Sub OrderDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrderDetailsToolStripMenuItem.Click
        orderdetail.Show()
    End Sub

    Private Sub StockDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockDetailsToolStripMenuItem.Click
        stock.Show()
    End Sub

    Private Sub SupplierDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplierDetailsToolStripMenuItem.Click
        supplier.Show()
    End Sub

    Private Sub EmpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpToolStripMenuItem.Click
        empreportvb.Show()
    End Sub

    Private Sub NewSales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewSales.Click
        newsale.Show()
    End Sub

    Private Sub SalesDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesDetailsToolStripMenuItem.Click
        sales.Show()
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        newmedicine.Show()
    End Sub

    Private Sub NewOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewOrderToolStripMenuItem.Click
        neworder.Show()
    End Sub

    Private Sub ChangePasswordToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePasswordToolStripMenuItem2.Click
        changepass.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub SalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesToolStripMenuItem.Click
        Formsalesreport.Show()
    End Sub

    Private Sub MedicineToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MedicineToolStripMenuItem1.Click
        orderReport.Show()
    End Sub

    Private Sub RemoveUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveUserToolStripMenuItem.Click
        removeuser.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lbtime.Text = DateTime.Now.ToString("hh:mm:ss tt")
    End Sub
End Class