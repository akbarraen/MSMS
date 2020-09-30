<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newsale
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
        Me.dtpmfg = New System.Windows.Forms.DateTimePicker()
        Me.dtpexp = New System.Windows.Forms.DateTimePicker()
        Me.txtqty = New System.Windows.Forms.TextBox()
        Me.txtmrp = New System.Windows.Forms.TextBox()
        Me.txtsaleid = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtvat = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.cmbn_name = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'dtpmfg
        '
        Me.dtpmfg.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpmfg.Location = New System.Drawing.Point(93, 148)
        Me.dtpmfg.Name = "dtpmfg"
        Me.dtpmfg.Size = New System.Drawing.Size(100, 20)
        Me.dtpmfg.TabIndex = 25
        '
        'dtpexp
        '
        Me.dtpexp.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpexp.Location = New System.Drawing.Point(431, 38)
        Me.dtpexp.Name = "dtpexp"
        Me.dtpexp.Size = New System.Drawing.Size(100, 20)
        Me.dtpexp.TabIndex = 24
        '
        'txtqty
        '
        Me.txtqty.Location = New System.Drawing.Point(431, 73)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(100, 20)
        Me.txtqty.TabIndex = 23
        '
        'txtmrp
        '
        Me.txtmrp.Location = New System.Drawing.Point(431, 148)
        Me.txtmrp.Name = "txtmrp"
        Me.txtmrp.Size = New System.Drawing.Size(100, 20)
        Me.txtmrp.TabIndex = 22
        '
        'txtsaleid
        '
        Me.txtsaleid.Location = New System.Drawing.Point(93, 38)
        Me.txtsaleid.Name = "txtsaleid"
        Me.txtsaleid.ReadOnly = True
        Me.txtsaleid.Size = New System.Drawing.Size(100, 20)
        Me.txtsaleid.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(352, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "MRP"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(360, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Qty"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(332, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Exp Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "MFG Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Medicine Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Sales ID"
        '
        'txtvat
        '
        Me.txtvat.Location = New System.Drawing.Point(431, 113)
        Me.txtvat.Name = "txtvat"
        Me.txtvat.Size = New System.Drawing.Size(100, 20)
        Me.txtvat.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(355, 113)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 13)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "VAT"
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(74, 234)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 28
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnreset
        '
        Me.btnreset.Location = New System.Drawing.Point(212, 234)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(75, 23)
        Me.btnreset.TabIndex = 29
        Me.btnreset.Text = "Reset"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(355, 234)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 30
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'cmbn_name
        '
        Me.cmbn_name.FormattingEnabled = True
        Me.cmbn_name.Location = New System.Drawing.Point(93, 114)
        Me.cmbn_name.Name = "cmbn_name"
        Me.cmbn_name.Size = New System.Drawing.Size(100, 21)
        Me.cmbn_name.TabIndex = 31
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 76)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 13)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Customer Name"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(93, 77)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(100, 20)
        Me.txtname.TabIndex = 33
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(538, 75)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Label9"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(541, 113)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "Label10"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(200, 83)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "Label11"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(541, 152)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 13)
        Me.Label12.TabIndex = 37
        Me.Label12.Text = "Label12"
        '
        'newsale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 323)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmbn_name)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtvat)
        Me.Controls.Add(Me.dtpmfg)
        Me.Controls.Add(Me.dtpexp)
        Me.Controls.Add(Me.txtqty)
        Me.Controls.Add(Me.txtmrp)
        Me.Controls.Add(Me.txtsaleid)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "newsale"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Sale Entry"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpmfg As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpexp As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtqty As System.Windows.Forms.TextBox
    Friend WithEvents txtmrp As System.Windows.Forms.TextBox
    Friend WithEvents txtsaleid As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtvat As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents cmbn_name As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
