<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newmedicine
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
        Me.cmbcatg = New System.Windows.Forms.ComboBox()
        Me.dtpmfg = New System.Windows.Forms.DateTimePicker()
        Me.dtpexpiry = New System.Windows.Forms.DateTimePicker()
        Me.txtmfg = New System.Windows.Forms.TextBox()
        Me.txtmname = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.cmboid = New System.Windows.Forms.ComboBox()
        Me.txtmid = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmbcatg
        '
        Me.cmbcatg.FormattingEnabled = True
        Me.cmbcatg.Items.AddRange(New Object() {"Syrup", "Tablets"})
        Me.cmbcatg.Location = New System.Drawing.Point(90, 104)
        Me.cmbcatg.Name = "cmbcatg"
        Me.cmbcatg.Size = New System.Drawing.Size(121, 21)
        Me.cmbcatg.TabIndex = 26
        '
        'dtpmfg
        '
        Me.dtpmfg.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpmfg.Location = New System.Drawing.Point(432, 149)
        Me.dtpmfg.Name = "dtpmfg"
        Me.dtpmfg.Size = New System.Drawing.Size(129, 20)
        Me.dtpmfg.TabIndex = 25
        '
        'dtpexpiry
        '
        Me.dtpexpiry.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpexpiry.Location = New System.Drawing.Point(432, 97)
        Me.dtpexpiry.Name = "dtpexpiry"
        Me.dtpexpiry.Size = New System.Drawing.Size(129, 20)
        Me.dtpexpiry.TabIndex = 24
        '
        'txtmfg
        '
        Me.txtmfg.Location = New System.Drawing.Point(432, 48)
        Me.txtmfg.Name = "txtmfg"
        Me.txtmfg.Size = New System.Drawing.Size(129, 20)
        Me.txtmfg.TabIndex = 23
        '
        'txtmname
        '
        Me.txtmname.Location = New System.Drawing.Point(90, 149)
        Me.txtmname.Name = "txtmname"
        Me.txtmname.Size = New System.Drawing.Size(121, 20)
        Me.txtmname.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(348, 155)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Mfg Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(338, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Expiry Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(332, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Manufacture"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(0, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Medicine Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Category"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Medicine ID"
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(110, 246)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 28
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnreset
        '
        Me.btnreset.Location = New System.Drawing.Point(218, 246)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(75, 23)
        Me.btnreset.TabIndex = 29
        Me.btnreset.Text = "Reset"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(330, 246)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 30
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'cmboid
        '
        Me.cmboid.FormattingEnabled = True
        Me.cmboid.Location = New System.Drawing.Point(90, 30)
        Me.cmboid.Name = "cmboid"
        Me.cmboid.Size = New System.Drawing.Size(121, 21)
        Me.cmboid.TabIndex = 31
        '
        'txtmid
        '
        Me.txtmid.Location = New System.Drawing.Point(90, 68)
        Me.txtmid.Name = "txtmid"
        Me.txtmid.Size = New System.Drawing.Size(121, 20)
        Me.txtmid.TabIndex = 32
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(0, 38)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Order ID"
        '
        'newmedicine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 301)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtmid)
        Me.Controls.Add(Me.cmboid)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.cmbcatg)
        Me.Controls.Add(Me.dtpmfg)
        Me.Controls.Add(Me.dtpexpiry)
        Me.Controls.Add(Me.txtmfg)
        Me.Controls.Add(Me.txtmname)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "newmedicine"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Medicine Entry"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbcatg As System.Windows.Forms.ComboBox
    Friend WithEvents dtpmfg As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpexpiry As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtmfg As System.Windows.Forms.TextBox
    Friend WithEvents txtmname As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents cmboid As System.Windows.Forms.ComboBox
    Friend WithEvents txtmid As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
