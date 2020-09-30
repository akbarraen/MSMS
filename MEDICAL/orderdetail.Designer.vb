<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class orderdetail
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmb_category = New System.Windows.Forms.ComboBox()
        Me.dtporderdate = New System.Windows.Forms.DateTimePicker()
        Me.txttotalAmount = New System.Windows.Forms.TextBox()
        Me.txtpriceperunit = New System.Windows.Forms.TextBox()
        Me.txtmanuf = New System.Windows.Forms.TextBox()
        Me.txtmedname = New System.Windows.Forms.TextBox()
        Me.txtorderid = New System.Windows.Forms.TextBox()
        Me.txtmedunit = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvorder = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnnew = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvorder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmb_category)
        Me.GroupBox1.Controls.Add(Me.dtporderdate)
        Me.GroupBox1.Controls.Add(Me.txttotalAmount)
        Me.GroupBox1.Controls.Add(Me.txtpriceperunit)
        Me.GroupBox1.Controls.Add(Me.txtmanuf)
        Me.GroupBox1.Controls.Add(Me.txtmedname)
        Me.GroupBox1.Controls.Add(Me.txtorderid)
        Me.GroupBox1.Controls.Add(Me.txtmedunit)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(33, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(600, 219)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Purchase Details"
        '
        'cmb_category
        '
        Me.cmb_category.FormattingEnabled = True
        Me.cmb_category.Items.AddRange(New Object() {"Tablet", "Syrup"})
        Me.cmb_category.Location = New System.Drawing.Point(109, 107)
        Me.cmb_category.Name = "cmb_category"
        Me.cmb_category.Size = New System.Drawing.Size(121, 21)
        Me.cmb_category.TabIndex = 15
        '
        'dtporderdate
        '
        Me.dtporderdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtporderdate.Location = New System.Drawing.Point(109, 65)
        Me.dtporderdate.Name = "dtporderdate"
        Me.dtporderdate.Size = New System.Drawing.Size(121, 20)
        Me.dtporderdate.TabIndex = 14
        '
        'txttotalAmount
        '
        Me.txttotalAmount.Location = New System.Drawing.Point(459, 153)
        Me.txttotalAmount.Name = "txttotalAmount"
        Me.txttotalAmount.Size = New System.Drawing.Size(123, 20)
        Me.txttotalAmount.TabIndex = 13
        '
        'txtpriceperunit
        '
        Me.txtpriceperunit.Location = New System.Drawing.Point(459, 107)
        Me.txtpriceperunit.Name = "txtpriceperunit"
        Me.txtpriceperunit.Size = New System.Drawing.Size(123, 20)
        Me.txtpriceperunit.TabIndex = 12
        '
        'txtmanuf
        '
        Me.txtmanuf.Location = New System.Drawing.Point(459, 27)
        Me.txtmanuf.Name = "txtmanuf"
        Me.txtmanuf.Size = New System.Drawing.Size(123, 20)
        Me.txtmanuf.TabIndex = 11
        '
        'txtmedname
        '
        Me.txtmedname.Location = New System.Drawing.Point(109, 153)
        Me.txtmedname.Name = "txtmedname"
        Me.txtmedname.Size = New System.Drawing.Size(121, 20)
        Me.txtmedname.TabIndex = 10
        '
        'txtorderid
        '
        Me.txtorderid.Location = New System.Drawing.Point(109, 19)
        Me.txtorderid.Name = "txtorderid"
        Me.txtorderid.ReadOnly = True
        Me.txtorderid.Size = New System.Drawing.Size(121, 20)
        Me.txtorderid.TabIndex = 9
        '
        'txtmedunit
        '
        Me.txtmedunit.Location = New System.Drawing.Point(459, 64)
        Me.txtmedunit.Name = "txtmedunit"
        Me.txtmedunit.Size = New System.Drawing.Size(123, 20)
        Me.txtmedunit.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(343, 160)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Total Amount"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(343, 114)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Price Per Unit"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(343, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Medicine Unit"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(343, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Manufacture"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(2, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Medicine Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(-3, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Medicine Category"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Order Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Order ID"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvorder)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 237)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(647, 168)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Table Data"
        '
        'dgvorder
        '
        Me.dgvorder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvorder.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.dgvorder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvorder.Location = New System.Drawing.Point(3, 16)
        Me.dgvorder.Name = "dgvorder"
        Me.dgvorder.Size = New System.Drawing.Size(641, 149)
        Me.dgvorder.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Order ID"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Order Date"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Medicine Category"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Medicine Name"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Medicine Manufacture"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Medicine Unit"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Price Per Unit"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Total Amount"
        Me.Column8.Name = "Column8"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btnnew)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnUpdate)
        Me.FlowLayoutPanel1.Controls.Add(Me.btndelete)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnsearch)
        Me.FlowLayoutPanel1.Controls.Add(Me.btncancel)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(101, 411)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(406, 32)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'btnnew
        '
        Me.btnnew.Location = New System.Drawing.Point(3, 3)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(75, 23)
        Me.btnnew.TabIndex = 0
        Me.btnnew.Text = "New Entry"
        Me.btnnew.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(84, 3)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 1
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(165, 3)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 23)
        Me.btndelete.TabIndex = 2
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnsearch
        '
        Me.btnsearch.Location = New System.Drawing.Point(246, 3)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(75, 23)
        Me.btnsearch.TabIndex = 3
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(327, 3)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 4
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'orderdetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 466)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "orderdetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Purchase Details"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvorder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txttotalAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtpriceperunit As System.Windows.Forms.TextBox
    Friend WithEvents txtmanuf As System.Windows.Forms.TextBox
    Friend WithEvents txtmedname As System.Windows.Forms.TextBox
    Friend WithEvents txtorderid As System.Windows.Forms.TextBox
    Friend WithEvents txtmedunit As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents cmb_category As System.Windows.Forms.ComboBox
    Friend WithEvents dtporderdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgvorder As System.Windows.Forms.DataGridView
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
