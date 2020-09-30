<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usercreation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usercreation))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbutype = New System.Windows.Forms.ComboBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtpwd = New System.Windows.Forms.TextBox()
        Me.txtconfirm = New System.Windows.Forms.TextBox()
        Me.btncreate = New System.Windows.Forms.Button()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User Type"
        '
        'TextBox1
        '
        Me.TextBox1.AutoSize = True
        Me.TextBox1.Location = New System.Drawing.Point(56, 102)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(60, 13)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "User Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(63, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Confirm Password"
        '
        'cmbutype
        '
        Me.cmbutype.FormattingEnabled = True
        Me.cmbutype.Items.AddRange(New Object() {"ADMIN", "STAFF"})
        Me.cmbutype.Location = New System.Drawing.Point(141, 54)
        Me.cmbutype.Name = "cmbutype"
        Me.cmbutype.Size = New System.Drawing.Size(121, 21)
        Me.cmbutype.TabIndex = 4
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(141, 95)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(121, 20)
        Me.txtname.TabIndex = 5
        '
        'txtpwd
        '
        Me.txtpwd.Location = New System.Drawing.Point(141, 139)
        Me.txtpwd.Name = "txtpwd"
        Me.txtpwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpwd.Size = New System.Drawing.Size(121, 20)
        Me.txtpwd.TabIndex = 6
        '
        'txtconfirm
        '
        Me.txtconfirm.Location = New System.Drawing.Point(141, 184)
        Me.txtconfirm.Name = "txtconfirm"
        Me.txtconfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtconfirm.Size = New System.Drawing.Size(121, 20)
        Me.txtconfirm.TabIndex = 7
        '
        'btncreate
        '
        Me.btncreate.Location = New System.Drawing.Point(66, 235)
        Me.btncreate.Name = "btncreate"
        Me.btncreate.Size = New System.Drawing.Size(75, 23)
        Me.btncreate.TabIndex = 8
        Me.btncreate.Text = "Create"
        Me.btncreate.UseVisualStyleBackColor = True
        '
        'btnreset
        '
        Me.btnreset.Location = New System.Drawing.Point(205, 235)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(75, 23)
        Me.btnreset.TabIndex = 9
        Me.btnreset.Text = "Reset"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'usercreation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(383, 322)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.btncreate)
        Me.Controls.Add(Me.txtconfirm)
        Me.Controls.Add(Me.txtpwd)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.cmbutype)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "usercreation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New User Creation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbutype As System.Windows.Forms.ComboBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtpwd As System.Windows.Forms.TextBox
    Friend WithEvents txtconfirm As System.Windows.Forms.TextBox
    Friend WithEvents btncreate As System.Windows.Forms.Button
    Friend WithEvents btnreset As System.Windows.Forms.Button
End Class
