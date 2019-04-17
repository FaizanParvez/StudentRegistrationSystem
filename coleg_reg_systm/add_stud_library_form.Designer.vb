<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_stud_library_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(add_stud_library_form))
        Me.btn_exit = New System.Windows.Forms.Button
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.lbl_heading_admission_form = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btn_go = New System.Windows.Forms.Button
        Me.txt_admission_no = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_exit.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.ForeColor = System.Drawing.Color.Black
        Me.btn_exit.Location = New System.Drawing.Point(259, 260)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(86, 27)
        Me.btn_exit.TabIndex = 187
        Me.btn_exit.Text = "&Exit"
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'ToolTip
        '
        Me.ToolTip.ForeColor = System.Drawing.Color.Purple
        '
        'lbl_heading_admission_form
        '
        Me.lbl_heading_admission_form.AutoSize = True
        Me.lbl_heading_admission_form.BackColor = System.Drawing.Color.Transparent
        Me.lbl_heading_admission_form.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_heading_admission_form.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_heading_admission_form.Location = New System.Drawing.Point(-3, 9)
        Me.lbl_heading_admission_form.Name = "lbl_heading_admission_form"
        Me.lbl_heading_admission_form.Size = New System.Drawing.Size(412, 43)
        Me.lbl_heading_admission_form.TabIndex = 188
        Me.lbl_heading_admission_form.Text = "LIBRARY INFORMATION"
        Me.lbl_heading_admission_form.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_go)
        Me.GroupBox1.Controls.Add(Me.txt_admission_no)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(319, 42)
        Me.GroupBox1.TabIndex = 189
        Me.GroupBox1.TabStop = False
        '
        'btn_go
        '
        Me.btn_go.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_go.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_go.ForeColor = System.Drawing.Color.Black
        Me.btn_go.Location = New System.Drawing.Point(239, 13)
        Me.btn_go.Name = "btn_go"
        Me.btn_go.Size = New System.Drawing.Size(50, 23)
        Me.btn_go.TabIndex = 2
        Me.btn_go.Text = "GO"
        Me.btn_go.UseVisualStyleBackColor = False
        '
        'txt_admission_no
        '
        Me.txt_admission_no.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_admission_no.Location = New System.Drawing.Point(153, 13)
        Me.txt_admission_no.Name = "txt_admission_no"
        Me.txt_admission_no.Size = New System.Drawing.Size(80, 23)
        Me.txt_admission_no.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter the Admission No."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(5, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 43)
        Me.Label2.TabIndex = 191
        Me.Label2.Text = "Books Issued"
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(3, 148)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(190, 139)
        Me.ListBox1.TabIndex = 192
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(242, 121)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(119, 133)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 194
        Me.PictureBox1.TabStop = False
        '
        'add_stud_library_form
        '
        Me.AcceptButton = Me.btn_go
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.CancelButton = Me.btn_exit
        Me.ClientSize = New System.Drawing.Size(409, 303)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.lbl_heading_admission_form)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "add_stud_library_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Regestration System "
        Me.ToolTip.SetToolTip(Me, "Enter the admission no.")
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_exit As System.Windows.Forms.Button
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents lbl_heading_admission_form As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_go As System.Windows.Forms.Button
    Friend WithEvents txt_admission_no As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
