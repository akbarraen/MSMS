<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newemp
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtempid = New System.Windows.Forms.TextBox()
        Me.txtempname = New System.Windows.Forms.TextBox()
        Me.txtnumb = New System.Windows.Forms.TextBox()
        Me.txtadd = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbf = New System.Windows.Forms.RadioButton()
        Me.rbm = New System.Windows.Forms.RadioButton()
        Me.dtpjoin = New System.Windows.Forms.DateTimePicker()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Employee ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Employee Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Contact"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(396, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(396, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Gender"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(396, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Date Of Join"
        '
        'txtempid
        '
        Me.txtempid.Location = New System.Drawing.Point(115, 21)
        Me.txtempid.Name = "txtempid"
        Me.txtempid.Size = New System.Drawing.Size(100, 20)
        Me.txtempid.TabIndex = 6
        '
        'txtempname
        '
        Me.txtempname.Location = New System.Drawing.Point(115, 69)
        Me.txtempname.Name = "txtempname"
        Me.txtempname.Size = New System.Drawing.Size(100, 20)
        Me.txtempname.TabIndex = 7
        '
        'txtnumb
        '
        Me.txtnumb.Location = New System.Drawing.Point(115, 112)
        Me.txtnumb.Name = "txtnumb"
        Me.txtnumb.Size = New System.Drawing.Size(100, 20)
        Me.txtnumb.TabIndex = 8
        '
        'txtadd
        '
        Me.txtadd.Location = New System.Drawing.Point(471, 21)
        Me.txtadd.Multiline = True
        Me.txtadd.Name = "txtadd"
        Me.txtadd.Size = New System.Drawing.Size(146, 34)
        Me.txtadd.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbf)
        Me.GroupBox1.Controls.Add(Me.rbm)
        Me.GroupBox1.Location = New System.Drawing.Point(471, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(146, 37)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gender"
        '
        'rbf
        '
        Me.rbf.AutoSize = True
        Me.rbf.Location = New System.Drawing.Point(57, 14)
        Me.rbf.Name = "rbf"
        Me.rbf.Size = New System.Drawing.Size(59, 17)
        Me.rbf.TabIndex = 1
        Me.rbf.TabStop = True
        Me.rbf.Text = "Female"
        Me.rbf.UseVisualStyleBackColor = True
        '
        'rbm
        '
        Me.rbm.AutoSize = True
        Me.rbm.Location = New System.Drawing.Point(3, 16)
        Me.rbm.Name = "rbm"
        Me.rbm.Size = New System.Drawing.Size(48, 17)
        Me.rbm.TabIndex = 0
        Me.rbm.TabStop = True
        Me.rbm.Text = "Male"
        Me.rbm.UseVisualStyleBackColor = True
        '
        'dtpjoin
        '
        Me.dtpjoin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpjoin.Location = New System.Drawing.Point(471, 123)
        Me.dtpjoin.Name = "dtpjoin"
        Me.dtpjoin.Size = New System.Drawing.Size(146, 20)
        Me.dtpjoin.TabIndex = 11
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(209, 230)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 12
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnreset
        '
        Me.btnreset.Location = New System.Drawing.Point(387, 230)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(75, 23)
        Me.btnreset.TabIndex = 13
        Me.btnreset.Text = "Reset"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(221, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Label7"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(221, 76)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Label8"
        '
        'newemp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(727, 312)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.dtpjoin)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtadd)
        Me.Controls.Add(Me.txtnumb)
        Me.Controls.Add(Me.txtempname)
        Me.Controls.Add(Me.txtempid)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "newemp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Employee Entry"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtempid As System.Windows.Forms.TextBox
    Friend WithEvents txtempname As System.Windows.Forms.TextBox
    Friend WithEvents txtnumb As System.Windows.Forms.TextBox
    Friend WithEvents txtadd As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbf As System.Windows.Forms.RadioButton
    Friend WithEvents rbm As System.Windows.Forms.RadioButton
    Friend WithEvents dtpjoin As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
