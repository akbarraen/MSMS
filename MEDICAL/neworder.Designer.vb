<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class neworder
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
        Me.cmb_category = New System.Windows.Forms.ComboBox()
        Me.dtporderdate = New System.Windows.Forms.DateTimePicker()
        Me.txtpriceperunit = New System.Windows.Forms.TextBox()
        Me.txtmanuf = New System.Windows.Forms.TextBox()
        Me.txtmedname = New System.Windows.Forms.TextBox()
        Me.txtmedunit = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.txtorderid = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmb_category
        '
        Me.cmb_category.FormattingEnabled = True
        Me.cmb_category.Items.AddRange(New Object() {"Tablet", "Syrup"})
        Me.cmb_category.Location = New System.Drawing.Point(135, 110)
        Me.cmb_category.Name = "cmb_category"
        Me.cmb_category.Size = New System.Drawing.Size(121, 21)
        Me.cmb_category.TabIndex = 31
        '
        'dtporderdate
        '
        Me.dtporderdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtporderdate.Location = New System.Drawing.Point(135, 68)
        Me.dtporderdate.Name = "dtporderdate"
        Me.dtporderdate.Size = New System.Drawing.Size(121, 20)
        Me.dtporderdate.TabIndex = 30
        '
        'txtpriceperunit
        '
        Me.txtpriceperunit.Location = New System.Drawing.Point(133, 281)
        Me.txtpriceperunit.Name = "txtpriceperunit"
        Me.txtpriceperunit.Size = New System.Drawing.Size(123, 20)
        Me.txtpriceperunit.TabIndex = 28
        '
        'txtmanuf
        '
        Me.txtmanuf.Location = New System.Drawing.Point(133, 201)
        Me.txtmanuf.Name = "txtmanuf"
        Me.txtmanuf.Size = New System.Drawing.Size(123, 20)
        Me.txtmanuf.TabIndex = 27
        '
        'txtmedname
        '
        Me.txtmedname.Location = New System.Drawing.Point(135, 156)
        Me.txtmedname.Name = "txtmedname"
        Me.txtmedname.Size = New System.Drawing.Size(121, 20)
        Me.txtmedname.TabIndex = 26
        '
        'txtmedunit
        '
        Me.txtmedunit.Location = New System.Drawing.Point(133, 238)
        Me.txtmedunit.Name = "txtmedunit"
        Me.txtmedunit.Size = New System.Drawing.Size(123, 20)
        Me.txtmedunit.TabIndex = 24
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 288)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Price Per Unit"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 245)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Medicine Unit"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Manufacture"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Medicine Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Medicine Category"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Order Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Order ID"
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(20, 352)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 32
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnreset
        '
        Me.btnreset.Location = New System.Drawing.Point(135, 352)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(75, 23)
        Me.btnreset.TabIndex = 33
        Me.btnreset.Text = "Reset"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(266, 352)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 34
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'txtorderid
        '
        Me.txtorderid.Location = New System.Drawing.Point(135, 21)
        Me.txtorderid.Name = "txtorderid"
        Me.txtorderid.Size = New System.Drawing.Size(121, 20)
        Me.txtorderid.TabIndex = 35
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(263, 163)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Label8"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(263, 207)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Label9"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(263, 245)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Label10"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(266, 288)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "Label11"
        '
        'neworder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 420)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtorderid)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.cmb_category)
        Me.Controls.Add(Me.dtporderdate)
        Me.Controls.Add(Me.txtpriceperunit)
        Me.Controls.Add(Me.txtmanuf)
        Me.Controls.Add(Me.txtmedname)
        Me.Controls.Add(Me.txtmedunit)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "neworder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Purchase Entry"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmb_category As System.Windows.Forms.ComboBox
    Friend WithEvents dtporderdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtpriceperunit As System.Windows.Forms.TextBox
    Friend WithEvents txtmanuf As System.Windows.Forms.TextBox
    Friend WithEvents txtmedname As System.Windows.Forms.TextBox
    Friend WithEvents txtmedunit As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents txtorderid As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
