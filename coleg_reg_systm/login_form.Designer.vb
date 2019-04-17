<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login_form
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
        Me.components = New System.ComponentModel.Container
        Me.btn_ok = New System.Windows.Forms.Button
        Me.btn_change_unam_pnam = New System.Windows.Forms.Button
        Me.btn_cancel = New System.Windows.Forms.Button
        Me.txt_password = New System.Windows.Forms.TextBox
        Me.lbl_password = New System.Windows.Forms.Label
        Me.lbl_username = New System.Windows.Forms.Label
        Me.txt_username = New System.Windows.Forms.TextBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_ok
        '
        Me.btn_ok.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_ok.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ok.Location = New System.Drawing.Point(184, 70)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(75, 23)
        Me.btn_ok.TabIndex = 13
        Me.btn_ok.Text = "&Ok"
        Me.btn_ok.UseVisualStyleBackColor = False
        '
        'btn_change_unam_pnam
        '
        Me.btn_change_unam_pnam.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_change_unam_pnam.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_change_unam_pnam.Location = New System.Drawing.Point(144, 99)
        Me.btn_change_unam_pnam.Name = "btn_change_unam_pnam"
        Me.btn_change_unam_pnam.Size = New System.Drawing.Size(225, 23)
        Me.btn_change_unam_pnam.TabIndex = 15
        Me.btn_change_unam_pnam.Text = "Change Password And Username"
        Me.btn_change_unam_pnam.UseVisualStyleBackColor = False
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cancel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.Location = New System.Drawing.Point(265, 70)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancel.TabIndex = 14
        Me.btn_cancel.Text = "&Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'txt_password
        '
        Me.txt_password.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_password.Location = New System.Drawing.Point(229, 39)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.Size = New System.Drawing.Size(147, 23)
        Me.txt_password.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.txt_password, "Enter the password")
        '
        'lbl_password
        '
        Me.lbl_password.AutoSize = True
        Me.lbl_password.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_password.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_password.Location = New System.Drawing.Point(127, 42)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(59, 15)
        Me.lbl_password.TabIndex = 17
        Me.lbl_password.Text = "Password"
        '
        'lbl_username
        '
        Me.lbl_username.AutoSize = True
        Me.lbl_username.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_username.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_username.Location = New System.Drawing.Point(127, 16)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(96, 15)
        Me.lbl_username.TabIndex = 16
        Me.lbl_username.Text = "Enter Username"
        '
        'txt_username
        '
        Me.txt_username.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_username.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_username.Location = New System.Drawing.Point(229, 13)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(147, 23)
        Me.txt_username.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.txt_username, "Enter the user name")
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.Access_Application
        Me.PictureBox1.Location = New System.Drawing.Point(12, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 107)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'login_form
        '
        Me.AcceptButton = Me.btn_ok
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Thistle
        Me.CancelButton = Me.btn_cancel
        Me.ClientSize = New System.Drawing.Size(387, 132)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.btn_change_unam_pnam)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.lbl_password)
        Me.Controls.Add(Me.lbl_username)
        Me.Controls.Add(Me.txt_username)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "login_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_ok As System.Windows.Forms.Button
    Friend WithEvents btn_change_unam_pnam As System.Windows.Forms.Button
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents txt_password As System.Windows.Forms.TextBox
    Friend WithEvents lbl_password As System.Windows.Forms.Label
    Friend WithEvents lbl_username As System.Windows.Forms.Label
    Friend WithEvents txt_username As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
