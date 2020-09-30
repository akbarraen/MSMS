<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class changepass
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(changepass))
        Me.label = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnsavechange = New System.Windows.Forms.Button()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.txtoldpass = New System.Windows.Forms.TextBox()
        Me.txtnewpass = New System.Windows.Forms.TextBox()
        Me.txtnewpassconfirm = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Location = New System.Drawing.Point(68, 38)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(72, 13)
        Me.label.TabIndex = 0
        Me.label.Text = "Old Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "New Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Confirm Password"
        '
        'btnsavechange
        '
        Me.btnsavechange.Location = New System.Drawing.Point(52, 187)
        Me.btnsavechange.Name = "btnsavechange"
        Me.btnsavechange.Size = New System.Drawing.Size(75, 23)
        Me.btnsavechange.TabIndex = 3
        Me.btnsavechange.Text = "Save Changes"
        Me.btnsavechange.UseVisualStyleBackColor = True
        '
        'btnreset
        '
        Me.btnreset.Location = New System.Drawing.Point(204, 187)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(75, 23)
        Me.btnreset.TabIndex = 4
        Me.btnreset.Text = "Reset"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'txtoldpass
        '
        Me.txtoldpass.Location = New System.Drawing.Point(146, 31)
        Me.txtoldpass.Name = "txtoldpass"
        Me.txtoldpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtoldpass.Size = New System.Drawing.Size(100, 20)
        Me.txtoldpass.TabIndex = 5
        '
        'txtnewpass
        '
        Me.txtnewpass.Location = New System.Drawing.Point(146, 78)
        Me.txtnewpass.Name = "txtnewpass"
        Me.txtnewpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtnewpass.Size = New System.Drawing.Size(100, 20)
        Me.txtnewpass.TabIndex = 6
        '
        'txtnewpassconfirm
        '
        Me.txtnewpassconfirm.Location = New System.Drawing.Point(146, 126)
        Me.txtnewpassconfirm.Name = "txtnewpassconfirm"
        Me.txtnewpassconfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtnewpassconfirm.Size = New System.Drawing.Size(100, 20)
        Me.txtnewpassconfirm.TabIndex = 7
        '
        'changepass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(360, 272)
        Me.Controls.Add(Me.txtnewpassconfirm)
        Me.Controls.Add(Me.txtnewpass)
        Me.Controls.Add(Me.txtoldpass)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.btnsavechange)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "changepass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Password"
        Me.TransparencyKey = System.Drawing.Color.Red
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents label As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnsavechange As System.Windows.Forms.Button
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents txtoldpass As System.Windows.Forms.TextBox
    Friend WithEvents txtnewpass As System.Windows.Forms.TextBox
    Friend WithEvents txtnewpassconfirm As System.Windows.Forms.TextBox
End Class
