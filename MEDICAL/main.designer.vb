<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.empdetailmenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.salarydetailmenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedicineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedicineDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrderDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewSales = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupplierDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedicineToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdmiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfigurationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserCreationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbtime = New System.Windows.Forms.Label()
        Me.lbday = New System.Windows.Forms.Label()
        Me.lbdate = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btncal = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserToolStripMenuItem, Me.EmployeeToolStripMenuItem, Me.MedicineToolStripMenuItem, Me.SupplierToolStripMenuItem, Me.ReportToolStripMenuItem, Me.AdmiToolStripMenuItem, Me.AboutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1354, 29)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangePasswordToolStripMenuItem2, Me.LogoutToolStripMenuItem})
        Me.UserToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(54, 25)
        Me.UserToolStripMenuItem.Text = "&User"
        '
        'ChangePasswordToolStripMenuItem2
        '
        Me.ChangePasswordToolStripMenuItem2.Name = "ChangePasswordToolStripMenuItem2"
        Me.ChangePasswordToolStripMenuItem2.Size = New System.Drawing.Size(203, 26)
        Me.ChangePasswordToolStripMenuItem2.Text = "Change Password"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(203, 26)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'EmployeeToolStripMenuItem
        '
        Me.EmployeeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.empdetailmenu, Me.salarydetailmenu})
        Me.EmployeeToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeToolStripMenuItem.Name = "EmployeeToolStripMenuItem"
        Me.EmployeeToolStripMenuItem.Size = New System.Drawing.Size(90, 25)
        Me.EmployeeToolStripMenuItem.Text = "&Employee"
        '
        'empdetailmenu
        '
        Me.empdetailmenu.Name = "empdetailmenu"
        Me.empdetailmenu.Size = New System.Drawing.Size(199, 26)
        Me.empdetailmenu.Text = "Employee Details"
        '
        'salarydetailmenu
        '
        Me.salarydetailmenu.Name = "salarydetailmenu"
        Me.salarydetailmenu.Size = New System.Drawing.Size(199, 26)
        Me.salarydetailmenu.Text = "Salary Detail"
        '
        'MedicineToolStripMenuItem
        '
        Me.MedicineToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MedicineDetailsToolStripMenuItem, Me.OrderDetailsToolStripMenuItem, Me.StockDetailsToolStripMenuItem, Me.SalesDetailsToolStripMenuItem})
        Me.MedicineToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedicineToolStripMenuItem.Name = "MedicineToolStripMenuItem"
        Me.MedicineToolStripMenuItem.Size = New System.Drawing.Size(85, 25)
        Me.MedicineToolStripMenuItem.Text = "&Medicine"
        '
        'MedicineDetailsToolStripMenuItem
        '
        Me.MedicineDetailsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem})
        Me.MedicineDetailsToolStripMenuItem.Name = "MedicineDetailsToolStripMenuItem"
        Me.MedicineDetailsToolStripMenuItem.Size = New System.Drawing.Size(194, 26)
        Me.MedicineDetailsToolStripMenuItem.Text = "Medicine Details"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(112, 26)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'OrderDetailsToolStripMenuItem
        '
        Me.OrderDetailsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewOrderToolStripMenuItem})
        Me.OrderDetailsToolStripMenuItem.Name = "OrderDetailsToolStripMenuItem"
        Me.OrderDetailsToolStripMenuItem.Size = New System.Drawing.Size(194, 26)
        Me.OrderDetailsToolStripMenuItem.Text = "Purchase Details"
        '
        'NewOrderToolStripMenuItem
        '
        Me.NewOrderToolStripMenuItem.Name = "NewOrderToolStripMenuItem"
        Me.NewOrderToolStripMenuItem.Size = New System.Drawing.Size(112, 26)
        Me.NewOrderToolStripMenuItem.Text = "New"
        '
        'StockDetailsToolStripMenuItem
        '
        Me.StockDetailsToolStripMenuItem.Name = "StockDetailsToolStripMenuItem"
        Me.StockDetailsToolStripMenuItem.Size = New System.Drawing.Size(194, 26)
        Me.StockDetailsToolStripMenuItem.Text = "Stock Details"
        '
        'SalesDetailsToolStripMenuItem
        '
        Me.SalesDetailsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewSales})
        Me.SalesDetailsToolStripMenuItem.Name = "SalesDetailsToolStripMenuItem"
        Me.SalesDetailsToolStripMenuItem.Size = New System.Drawing.Size(194, 26)
        Me.SalesDetailsToolStripMenuItem.Text = "Sales Details"
        '
        'NewSales
        '
        Me.NewSales.Name = "NewSales"
        Me.NewSales.Size = New System.Drawing.Size(112, 26)
        Me.NewSales.Text = "New"
        '
        'SupplierToolStripMenuItem
        '
        Me.SupplierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SupplierDetailsToolStripMenuItem})
        Me.SupplierToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SupplierToolStripMenuItem.Name = "SupplierToolStripMenuItem"
        Me.SupplierToolStripMenuItem.Size = New System.Drawing.Size(80, 25)
        Me.SupplierToolStripMenuItem.Text = "&Supplier"
        '
        'SupplierDetailsToolStripMenuItem
        '
        Me.SupplierDetailsToolStripMenuItem.Name = "SupplierDetailsToolStripMenuItem"
        Me.SupplierDetailsToolStripMenuItem.Size = New System.Drawing.Size(189, 26)
        Me.SupplierDetailsToolStripMenuItem.Text = "Supplier Details"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpToolStripMenuItem, Me.MedicineToolStripMenuItem1, Me.SalesToolStripMenuItem})
        Me.ReportToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(69, 25)
        Me.ReportToolStripMenuItem.Text = "&Report"
        '
        'EmpToolStripMenuItem
        '
        Me.EmpToolStripMenuItem.Name = "EmpToolStripMenuItem"
        Me.EmpToolStripMenuItem.Size = New System.Drawing.Size(148, 26)
        Me.EmpToolStripMenuItem.Text = "Employee"
        '
        'MedicineToolStripMenuItem1
        '
        Me.MedicineToolStripMenuItem1.Name = "MedicineToolStripMenuItem1"
        Me.MedicineToolStripMenuItem1.Size = New System.Drawing.Size(148, 26)
        Me.MedicineToolStripMenuItem1.Text = "Purchase"
        '
        'SalesToolStripMenuItem
        '
        Me.SalesToolStripMenuItem.Name = "SalesToolStripMenuItem"
        Me.SalesToolStripMenuItem.Size = New System.Drawing.Size(148, 26)
        Me.SalesToolStripMenuItem.Text = "Sales"
        '
        'AdmiToolStripMenuItem
        '
        Me.AdmiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfigurationToolStripMenuItem})
        Me.AdmiToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdmiToolStripMenuItem.Name = "AdmiToolStripMenuItem"
        Me.AdmiToolStripMenuItem.Size = New System.Drawing.Size(57, 25)
        Me.AdmiToolStripMenuItem.Text = "&Tools"
        '
        'ConfigurationToolStripMenuItem
        '
        Me.ConfigurationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserCreationToolStripMenuItem, Me.ChangePasswordToolStripMenuItem, Me.RemoveUserToolStripMenuItem})
        Me.ConfigurationToolStripMenuItem.Name = "ConfigurationToolStripMenuItem"
        Me.ConfigurationToolStripMenuItem.Size = New System.Drawing.Size(176, 26)
        Me.ConfigurationToolStripMenuItem.Text = "Configuration"
        '
        'UserCreationToolStripMenuItem
        '
        Me.UserCreationToolStripMenuItem.Name = "UserCreationToolStripMenuItem"
        Me.UserCreationToolStripMenuItem.Size = New System.Drawing.Size(203, 26)
        Me.UserCreationToolStripMenuItem.Text = "User Creation"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(203, 26)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'RemoveUserToolStripMenuItem
        '
        Me.RemoveUserToolStripMenuItem.Name = "RemoveUserToolStripMenuItem"
        Me.RemoveUserToolStripMenuItem.Size = New System.Drawing.Size(203, 26)
        Me.RemoveUserToolStripMenuItem.Text = "&Remove User"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(64, 25)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(46, 25)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lbtime)
        Me.GroupBox1.Controls.Add(Me.lbday)
        Me.GroupBox1.Controls.Add(Me.lbdate)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 47)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(300, 161)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'lbtime
        '
        Me.lbtime.AutoSize = True
        Me.lbtime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbtime.Location = New System.Drawing.Point(64, 124)
        Me.lbtime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbtime.Name = "lbtime"
        Me.lbtime.Size = New System.Drawing.Size(55, 16)
        Me.lbtime.TabIndex = 3
        Me.lbtime.Text = "Label6"
        '
        'lbday
        '
        Me.lbday.AutoSize = True
        Me.lbday.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbday.Location = New System.Drawing.Point(64, 93)
        Me.lbday.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbday.Name = "lbday"
        Me.lbday.Size = New System.Drawing.Size(55, 16)
        Me.lbday.TabIndex = 2
        Me.lbday.Text = "Label5"
        '
        'lbdate
        '
        Me.lbdate.AutoSize = True
        Me.lbdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbdate.Location = New System.Drawing.Point(64, 62)
        Me.lbdate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbdate.Name = "lbdate"
        Me.lbdate.Size = New System.Drawing.Size(55, 16)
        Me.lbdate.TabIndex = 1
        Me.lbdate.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btncal)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(0, 235)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox2.Size = New System.Drawing.Size(300, 123)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Utilities"
        '
        'btncal
        '
        Me.btncal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncal.Location = New System.Drawing.Point(10, 37)
        Me.btncal.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btncal.Name = "btncal"
        Me.btncal.Size = New System.Drawing.Size(112, 30)
        Me.btncal.TabIndex = 0
        Me.btncal.Text = "Calculator"
        Me.btncal.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(0, 387)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox3.Size = New System.Drawing.Size(300, 105)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "About"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(9, 71)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(202, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Email:- dbzraen@gmail.com"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 34)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(192, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Developed by Akbar Raen"
        '
        'Timer1
        '
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1354, 662)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Medical Store Management System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AdmiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfigurationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserCreationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btncal As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbtime As System.Windows.Forms.Label
    Friend WithEvents lbday As System.Windows.Forms.Label
    Friend WithEvents lbdate As System.Windows.Forms.Label
    Friend WithEvents EmployeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents empdetailmenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents salarydetailmenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MedicineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MedicineDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrderDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StockDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupplierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupplierDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MedicineToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalesDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewSales As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewOrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
