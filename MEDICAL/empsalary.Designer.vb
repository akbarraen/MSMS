<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class empsalary
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtsalary = New System.Windows.Forms.TextBox()
        Me.txtsaladv = New System.Windows.Forms.TextBox()
        Me.dtpsalary = New System.Windows.Forms.DateTimePicker()
        Me.btncalsal = New System.Windows.Forms.Button()
        Me.txtcalsal = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtempid = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvempsal = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BTNupdate = New System.Windows.Forms.Button()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnnewentry = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvempsal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Emp ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Salary Amount"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(358, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Salary Advance"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(378, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Salary Date"
        '
        'txtsalary
        '
        Me.txtsalary.Location = New System.Drawing.Point(81, 63)
        Me.txtsalary.Name = "txtsalary"
        Me.txtsalary.Size = New System.Drawing.Size(100, 20)
        Me.txtsalary.TabIndex = 5
        '
        'txtsaladv
        '
        Me.txtsaladv.Location = New System.Drawing.Point(442, 19)
        Me.txtsaladv.Name = "txtsaladv"
        Me.txtsaladv.Size = New System.Drawing.Size(122, 20)
        Me.txtsaladv.TabIndex = 6
        '
        'dtpsalary
        '
        Me.dtpsalary.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpsalary.Location = New System.Drawing.Point(442, 64)
        Me.dtpsalary.Name = "dtpsalary"
        Me.dtpsalary.Size = New System.Drawing.Size(122, 20)
        Me.dtpsalary.TabIndex = 7
        '
        'btncalsal
        '
        Me.btncalsal.Location = New System.Drawing.Point(277, 129)
        Me.btncalsal.Name = "btncalsal"
        Me.btncalsal.Size = New System.Drawing.Size(150, 23)
        Me.btncalsal.TabIndex = 8
        Me.btncalsal.Text = "Calculate Remaining Salary"
        Me.btncalsal.UseVisualStyleBackColor = True
        '
        'txtcalsal
        '
        Me.txtcalsal.Location = New System.Drawing.Point(442, 131)
        Me.txtcalsal.Name = "txtcalsal"
        Me.txtcalsal.Size = New System.Drawing.Size(122, 20)
        Me.txtcalsal.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.btncalsal)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtcalsal)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtpsalary)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtsaladv)
        Me.GroupBox1.Controls.Add(Me.txtempid)
        Me.GroupBox1.Controls.Add(Me.txtsalary)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(745, 170)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Salary Details"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(570, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Label6"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(188, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Label5"
        '
        'txtempid
        '
        Me.txtempid.Location = New System.Drawing.Point(81, 30)
        Me.txtempid.Name = "txtempid"
        Me.txtempid.ReadOnly = True
        Me.txtempid.Size = New System.Drawing.Size(100, 20)
        Me.txtempid.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvempsal)
        Me.GroupBox2.Location = New System.Drawing.Point(93, 206)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(547, 144)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Details"
        '
        'dgvempsal
        '
        Me.dgvempsal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvempsal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgvempsal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvempsal.Location = New System.Drawing.Point(3, 16)
        Me.dgvempsal.Name = "dgvempsal"
        Me.dgvempsal.Size = New System.Drawing.Size(541, 125)
        Me.dgvempsal.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Emp ID"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Salary Amount"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Salary Advance"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Salary Date"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Remaining Salary"
        Me.Column5.Name = "Column5"
        '
        'BTNupdate
        '
        Me.BTNupdate.Location = New System.Drawing.Point(84, 3)
        Me.BTNupdate.Name = "BTNupdate"
        Me.BTNupdate.Size = New System.Drawing.Size(75, 23)
        Me.BTNupdate.TabIndex = 11
        Me.BTNupdate.Text = "Update"
        Me.BTNupdate.UseVisualStyleBackColor = True
        '
        'btnsearch
        '
        Me.btnsearch.Location = New System.Drawing.Point(246, 3)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(75, 23)
        Me.btnsearch.TabIndex = 12
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(327, 3)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 13
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnnewentry
        '
        Me.btnnewentry.Location = New System.Drawing.Point(3, 3)
        Me.btnnewentry.Name = "btnnewentry"
        Me.btnnewentry.Size = New System.Drawing.Size(75, 23)
        Me.btnnewentry.TabIndex = 14
        Me.btnnewentry.Text = "New Entry"
        Me.btnnewentry.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btnnewentry)
        Me.FlowLayoutPanel1.Controls.Add(Me.BTNupdate)
        Me.FlowLayoutPanel1.Controls.Add(Me.btndelete)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnsearch)
        Me.FlowLayoutPanel1.Controls.Add(Me.btncancel)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnreset)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(121, 363)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(500, 39)
        Me.FlowLayoutPanel1.TabIndex = 15
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(165, 3)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 23)
        Me.btndelete.TabIndex = 15
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnreset
        '
        Me.btnreset.Location = New System.Drawing.Point(408, 3)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(75, 23)
        Me.btnreset.TabIndex = 16
        Me.btnreset.Text = "Reset"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'empsalary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 414)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "empsalary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Salary Details"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvempsal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtsalary As System.Windows.Forms.TextBox
    Friend WithEvents txtsaladv As System.Windows.Forms.TextBox
    Friend WithEvents dtpsalary As System.Windows.Forms.DateTimePicker
    Friend WithEvents btncalsal As System.Windows.Forms.Button
    Friend WithEvents txtcalsal As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvempsal As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BTNupdate As System.Windows.Forms.Button
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnnewentry As System.Windows.Forms.Button
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents txtempid As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
