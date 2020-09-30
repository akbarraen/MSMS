<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.lbuser = New System.Windows.Forms.Label()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.lbpass = New System.Windows.Forms.Label()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.btlogin = New System.Windows.Forms.Button()
        Me.btcancel = New System.Windows.Forms.Button()
        Me.btclear = New System.Windows.Forms.Button()
        Me.lbutype = New System.Windows.Forms.Label()
        Me.usertype = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbuser
        '
        Me.lbuser.AutoSize = True
        Me.lbuser.BackColor = System.Drawing.Color.Transparent
        Me.lbuser.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbuser.Location = New System.Drawing.Point(78, 105)
        Me.lbuser.Name = "lbuser"
        Me.lbuser.Size = New System.Drawing.Size(74, 20)
        Me.lbuser.TabIndex = 0
        Me.lbuser.Text = "User Name"
        '
        'txtuser
        '
        Me.txtuser.Location = New System.Drawing.Point(196, 107)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(157, 20)
        Me.txtuser.TabIndex = 1
        '
        'lbpass
        '
        Me.lbpass.AutoSize = True
        Me.lbpass.BackColor = System.Drawing.Color.Transparent
        Me.lbpass.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbpass.Location = New System.Drawing.Point(83, 161)
        Me.lbpass.Name = "lbpass"
        Me.lbpass.Size = New System.Drawing.Size(69, 20)
        Me.lbpass.TabIndex = 2
        Me.lbpass.Text = "Password"
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(196, 161)
        Me.txtpass.MaxLength = 12
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass.Size = New System.Drawing.Size(157, 20)
        Me.txtpass.TabIndex = 3
        '
        'btlogin
        '
        Me.btlogin.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btlogin.Location = New System.Drawing.Point(85, 236)
        Me.btlogin.Name = "btlogin"
        Me.btlogin.Size = New System.Drawing.Size(75, 23)
        Me.btlogin.TabIndex = 4
        Me.btlogin.Text = "Login"
        Me.btlogin.UseVisualStyleBackColor = False
        '
        'btcancel
        '
        Me.btcancel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btcancel.Location = New System.Drawing.Point(196, 236)
        Me.btcancel.Name = "btcancel"
        Me.btcancel.Size = New System.Drawing.Size(75, 23)
        Me.btcancel.TabIndex = 5
        Me.btcancel.Text = "Cancel"
        Me.btcancel.UseVisualStyleBackColor = False
        '
        'btclear
        '
        Me.btclear.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btclear.Location = New System.Drawing.Point(314, 236)
        Me.btclear.Name = "btclear"
        Me.btclear.Size = New System.Drawing.Size(75, 23)
        Me.btclear.TabIndex = 6
        Me.btclear.Text = "Clear"
        Me.btclear.UseVisualStyleBackColor = False
        '
        'lbutype
        '
        Me.lbutype.AutoSize = True
        Me.lbutype.BackColor = System.Drawing.Color.Transparent
        Me.lbutype.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbutype.ForeColor = System.Drawing.Color.Black
        Me.lbutype.Location = New System.Drawing.Point(81, 48)
        Me.lbutype.Name = "lbutype"
        Me.lbutype.Size = New System.Drawing.Size(71, 20)
        Me.lbutype.TabIndex = 7
        Me.lbutype.Text = "User Type"
        '
        'usertype
        '
        Me.usertype.FormattingEnabled = True
        Me.usertype.Items.AddRange(New Object() {"ADMIN", "STAFF"})
        Me.usertype.Location = New System.Drawing.Point(196, 47)
        Me.usertype.Name = "usertype"
        Me.usertype.Size = New System.Drawing.Size(157, 21)
        Me.usertype.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(82, 206)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(359, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.Location = New System.Drawing.Point(359, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Visible = False
        '
        'Login
        '
        Me.AcceptButton = Me.btlogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(531, 336)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.usertype)
        Me.Controls.Add(Me.lbutype)
        Me.Controls.Add(Me.btclear)
        Me.Controls.Add(Me.btcancel)
        Me.Controls.Add(Me.btlogin)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.lbpass)
        Me.Controls.Add(Me.txtuser)
        Me.Controls.Add(Me.lbuser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOGIN"
        Me.TransparencyKey = System.Drawing.Color.SandyBrown
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbuser As System.Windows.Forms.Label
    Friend WithEvents txtuser As System.Windows.Forms.TextBox
    Friend WithEvents lbpass As System.Windows.Forms.Label
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents btlogin As System.Windows.Forms.Button
    Friend WithEvents btcancel As System.Windows.Forms.Button
    Friend WithEvents btclear As System.Windows.Forms.Button
    Friend WithEvents lbutype As System.Windows.Forms.Label
    Friend WithEvents usertype As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
