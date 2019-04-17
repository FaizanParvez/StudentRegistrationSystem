<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class change_ur_ps
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
        Me.txt_new_password = New System.Windows.Forms.TextBox()
        Me.txt_new_username = New System.Windows.Forms.TextBox()
        Me.lbl_new_password = New System.Windows.Forms.Label()
        Me.lbl_new_username = New System.Windows.Forms.Label()
        Me.btn_clearall = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_update_password = New System.Windows.Forms.Button()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.lbl_password = New System.Windows.Forms.Label()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'txt_new_password
        '
        Me.txt_new_password.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_new_password.Location = New System.Drawing.Point(112, 85)
        Me.txt_new_password.Name = "txt_new_password"
        Me.txt_new_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_new_password.Size = New System.Drawing.Size(184, 23)
        Me.txt_new_password.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.txt_new_password, "Enter the newpassword")
        '
        'txt_new_username
        '
        Me.txt_new_username.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_new_username.Location = New System.Drawing.Point(112, 59)
        Me.txt_new_username.Name = "txt_new_username"
        Me.txt_new_username.Size = New System.Drawing.Size(184, 23)
        Me.txt_new_username.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.txt_new_username, "Enter the newusername")
        '
        'lbl_new_password
        '
        Me.lbl_new_password.AutoSize = True
        Me.lbl_new_password.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_new_password.Location = New System.Drawing.Point(5, 88)
        Me.lbl_new_password.Name = "lbl_new_password"
        Me.lbl_new_password.Size = New System.Drawing.Size(88, 15)
        Me.lbl_new_password.TabIndex = 30
        Me.lbl_new_password.Text = "New Password"
        '
        'lbl_new_username
        '
        Me.lbl_new_username.AutoSize = True
        Me.lbl_new_username.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_new_username.Location = New System.Drawing.Point(5, 62)
        Me.lbl_new_username.Name = "lbl_new_username"
        Me.lbl_new_username.Size = New System.Drawing.Size(92, 15)
        Me.lbl_new_username.TabIndex = 29
        Me.lbl_new_username.Text = "New Username"
        '
        'btn_clearall
        '
        Me.btn_clearall.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_clearall.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clearall.Location = New System.Drawing.Point(132, 114)
        Me.btn_clearall.Name = "btn_clearall"
        Me.btn_clearall.Size = New System.Drawing.Size(77, 23)
        Me.btn_clearall.TabIndex = 5
        Me.btn_clearall.Text = "Clear &All"
        Me.btn_clearall.UseVisualStyleBackColor = False
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cancel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.Location = New System.Drawing.Point(215, 114)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(77, 23)
        Me.btn_cancel.TabIndex = 6
        Me.btn_cancel.Text = "&Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'btn_update_password
        '
        Me.btn_update_password.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_update_password.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update_password.Location = New System.Drawing.Point(53, 114)
        Me.btn_update_password.Name = "btn_update_password"
        Me.btn_update_password.Size = New System.Drawing.Size(77, 23)
        Me.btn_update_password.TabIndex = 4
        Me.btn_update_password.Text = "&Update Password"
        Me.btn_update_password.UseVisualStyleBackColor = False
        '
        'txt_password
        '
        Me.txt_password.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password.Location = New System.Drawing.Point(112, 33)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.Size = New System.Drawing.Size(184, 23)
        Me.txt_password.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txt_password, "Eenter the password")
        '
        'lbl_password
        '
        Me.lbl_password.AutoSize = True
        Me.lbl_password.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_password.Location = New System.Drawing.Point(3, 36)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(105, 15)
        Me.lbl_password.TabIndex = 28
        Me.lbl_password.Text = "Current Password"
        '
        'lbl_username
        '
        Me.lbl_username.AutoSize = True
        Me.lbl_username.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_username.Location = New System.Drawing.Point(3, 10)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(109, 15)
        Me.lbl_username.TabIndex = 27
        Me.lbl_username.Text = "Current Username"
        '
        'txt_username
        '
        Me.txt_username.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_username.Location = New System.Drawing.Point(112, 7)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(184, 23)
        Me.txt_username.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.txt_username, "Enter the username")
        '
        'change_ur_ps
        '
        Me.AcceptButton = Me.btn_update_password
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.CancelButton = Me.btn_cancel
        Me.ClientSize = New System.Drawing.Size(308, 147)
        Me.Controls.Add(Me.txt_new_password)
        Me.Controls.Add(Me.txt_new_username)
        Me.Controls.Add(Me.lbl_new_password)
        Me.Controls.Add(Me.lbl_new_username)
        Me.Controls.Add(Me.btn_clearall)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_update_password)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.lbl_password)
        Me.Controls.Add(Me.lbl_username)
        Me.Controls.Add(Me.txt_username)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "change_ur_ps"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_new_password As System.Windows.Forms.TextBox
    Friend WithEvents txt_new_username As System.Windows.Forms.TextBox
    Friend WithEvents lbl_new_password As System.Windows.Forms.Label
    Friend WithEvents lbl_new_username As System.Windows.Forms.Label
    Friend WithEvents btn_clearall As System.Windows.Forms.Button
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents btn_update_password As System.Windows.Forms.Button
    Friend WithEvents txt_password As System.Windows.Forms.TextBox
    Friend WithEvents lbl_password As System.Windows.Forms.Label
    Friend WithEvents lbl_username As System.Windows.Forms.Label
    Friend WithEvents txt_username As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
