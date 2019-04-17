<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class edit_stud_details_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(edit_stud_details_form))
        Me.btn_exit = New System.Windows.Forms.Button
        Me.txt_exam_passed = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmb_session = New System.Windows.Forms.TextBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_admission_no = New System.Windows.Forms.TextBox
        Me.msk_cell_no = New System.Windows.Forms.MaskedTextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.lbl_admission_no = New System.Windows.Forms.Label
        Me.cmb_joining_class = New System.Windows.Forms.ComboBox
        Me.txt_mothers_name = New System.Windows.Forms.TextBox
        Me.txt_fathers_name = New System.Windows.Forms.TextBox
        Me.txt_student_last_name = New System.Windows.Forms.TextBox
        Me.txt_student_ist_name = New System.Windows.Forms.TextBox
        Me.lbl_student_last_examination_passed = New System.Windows.Forms.Label
        Me.lbl_cell_no = New System.Windows.Forms.Label
        Me.lbl_birthdate = New System.Windows.Forms.Label
        Me.lbl_student_last_name = New System.Windows.Forms.Label
        Me.lbl_student_ist_name = New System.Windows.Forms.Label
        Me.lbl_class_of_joining = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.txt_address = New System.Windows.Forms.TextBox
        Me.btn_update = New System.Windows.Forms.Button
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.txt_email = New System.Windows.Forms.TextBox
        Me.txt_pin_no = New System.Windows.Forms.TextBox
        Me.cmb_state = New System.Windows.Forms.ComboBox
        Me.cmb_city = New System.Windows.Forms.ComboBox
        Me.rdb_male = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.rdb_female = New System.Windows.Forms.RadioButton
        Me.btn_clear_all = New System.Windows.Forms.Button
        Me.lbl_heading_admission_form = New System.Windows.Forms.Label
        Me.lbl_address = New System.Windows.Forms.Label
        Me.lbl_state = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lbl_pin_no = New System.Windows.Forms.Label
        Me.lbl_email = New System.Windows.Forms.Label
        Me.lbl_city = New System.Windows.Forms.Label
        Me.btn_pic = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_exit.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.ForeColor = System.Drawing.Color.Black
        Me.btn_exit.Location = New System.Drawing.Point(577, 387)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(86, 27)
        Me.btn_exit.TabIndex = 21
        Me.btn_exit.Text = "&Exit"
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'txt_exam_passed
        '
        Me.txt_exam_passed.BackColor = System.Drawing.SystemColors.Info
        Me.txt_exam_passed.Enabled = False
        Me.txt_exam_passed.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_exam_passed.Location = New System.Drawing.Point(125, 244)
        Me.txt_exam_passed.Name = "txt_exam_passed"
        Me.txt_exam_passed.ReadOnly = True
        Me.txt_exam_passed.Size = New System.Drawing.Size(130, 23)
        Me.txt_exam_passed.TabIndex = 9
        Me.txt_exam_passed.Text = "Select"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmb_session)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_exam_passed)
        Me.GroupBox1.Controls.Add(Me.txt_admission_no)
        Me.GroupBox1.Controls.Add(Me.msk_cell_no)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.lbl_admission_no)
        Me.GroupBox1.Controls.Add(Me.cmb_joining_class)
        Me.GroupBox1.Controls.Add(Me.txt_mothers_name)
        Me.GroupBox1.Controls.Add(Me.txt_fathers_name)
        Me.GroupBox1.Controls.Add(Me.txt_student_last_name)
        Me.GroupBox1.Controls.Add(Me.txt_student_ist_name)
        Me.GroupBox1.Controls.Add(Me.lbl_student_last_examination_passed)
        Me.GroupBox1.Controls.Add(Me.lbl_cell_no)
        Me.GroupBox1.Controls.Add(Me.lbl_birthdate)
        Me.GroupBox1.Controls.Add(Me.lbl_student_last_name)
        Me.GroupBox1.Controls.Add(Me.lbl_student_ist_name)
        Me.GroupBox1.Controls.Add(Me.lbl_class_of_joining)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(373, 307)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'cmb_session
        '
        Me.cmb_session.BackColor = System.Drawing.SystemColors.Info
        Me.cmb_session.Enabled = False
        Me.cmb_session.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_session.Location = New System.Drawing.Point(125, 273)
        Me.cmb_session.Name = "cmb_session"
        Me.cmb_session.ReadOnly = True
        Me.cmb_session.Size = New System.Drawing.Size(126, 23)
        Me.cmb_session.TabIndex = 1023
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(125, 186)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(242, 23)
        Me.DateTimePicker1.TabIndex = 7
        Me.ToolTip.SetToolTip(Me.DateTimePicker1, "Select the date of birth")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(6, 276)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 15)
        Me.Label1.TabIndex = 1004
        Me.Label1.Text = "Session"
        '
        'txt_admission_no
        '
        Me.txt_admission_no.BackColor = System.Drawing.SystemColors.Info
        Me.txt_admission_no.Enabled = False
        Me.txt_admission_no.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_admission_no.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_admission_no.Location = New System.Drawing.Point(125, 13)
        Me.txt_admission_no.Name = "txt_admission_no"
        Me.txt_admission_no.ReadOnly = True
        Me.txt_admission_no.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_admission_no.Size = New System.Drawing.Size(55, 23)
        Me.txt_admission_no.TabIndex = 1
        '
        'msk_cell_no
        '
        Me.msk_cell_no.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msk_cell_no.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.msk_cell_no.Location = New System.Drawing.Point(125, 215)
        Me.msk_cell_no.Mask = "(999) 000-0000"
        Me.msk_cell_no.Name = "msk_cell_no"
        Me.msk_cell_no.Size = New System.Drawing.Size(130, 23)
        Me.msk_cell_no.TabIndex = 8
        Me.ToolTip.SetToolTip(Me.msk_cell_no, "Enter the cell no.")
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(6, 160)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(93, 15)
        Me.Label12.TabIndex = 189
        Me.Label12.Text = "Mother's Name"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(6, 131)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 15)
        Me.Label11.TabIndex = 190
        Me.Label11.Text = "Father's Name"
        '
        'lbl_admission_no
        '
        Me.lbl_admission_no.AutoSize = True
        Me.lbl_admission_no.BackColor = System.Drawing.Color.Transparent
        Me.lbl_admission_no.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_admission_no.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_admission_no.Location = New System.Drawing.Point(6, 16)
        Me.lbl_admission_no.Name = "lbl_admission_no"
        Me.lbl_admission_no.Size = New System.Drawing.Size(85, 15)
        Me.lbl_admission_no.TabIndex = 185
        Me.lbl_admission_no.Text = "Admission No."
        '
        'cmb_joining_class
        '
        Me.cmb_joining_class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_joining_class.Enabled = False
        Me.cmb_joining_class.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_joining_class.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmb_joining_class.FormattingEnabled = True
        Me.cmb_joining_class.Items.AddRange(New Object() {"BCA IST YEAR", "BCA 2ND YEAR", "BCA 3RD YEAR"})
        Me.cmb_joining_class.Location = New System.Drawing.Point(125, 42)
        Me.cmb_joining_class.Name = "cmb_joining_class"
        Me.cmb_joining_class.Size = New System.Drawing.Size(126, 23)
        Me.cmb_joining_class.TabIndex = 2
        Me.ToolTip.SetToolTip(Me.cmb_joining_class, "Select the class to join")
        '
        'txt_mothers_name
        '
        Me.txt_mothers_name.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_mothers_name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_mothers_name.Location = New System.Drawing.Point(125, 157)
        Me.txt_mothers_name.Name = "txt_mothers_name"
        Me.txt_mothers_name.Size = New System.Drawing.Size(240, 23)
        Me.txt_mothers_name.TabIndex = 6
        Me.ToolTip.SetToolTip(Me.txt_mothers_name, "Enter mother's name")
        '
        'txt_fathers_name
        '
        Me.txt_fathers_name.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fathers_name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_fathers_name.Location = New System.Drawing.Point(125, 128)
        Me.txt_fathers_name.Name = "txt_fathers_name"
        Me.txt_fathers_name.Size = New System.Drawing.Size(240, 23)
        Me.txt_fathers_name.TabIndex = 5
        Me.ToolTip.SetToolTip(Me.txt_fathers_name, "Enter father's name")
        '
        'txt_student_last_name
        '
        Me.txt_student_last_name.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_student_last_name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_student_last_name.Location = New System.Drawing.Point(125, 99)
        Me.txt_student_last_name.Name = "txt_student_last_name"
        Me.txt_student_last_name.Size = New System.Drawing.Size(241, 23)
        Me.txt_student_last_name.TabIndex = 4
        Me.ToolTip.SetToolTip(Me.txt_student_last_name, "Enter last name")
        '
        'txt_student_ist_name
        '
        Me.txt_student_ist_name.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_student_ist_name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_student_ist_name.Location = New System.Drawing.Point(125, 71)
        Me.txt_student_ist_name.Name = "txt_student_ist_name"
        Me.txt_student_ist_name.Size = New System.Drawing.Size(241, 23)
        Me.txt_student_ist_name.TabIndex = 3
        Me.ToolTip.SetToolTip(Me.txt_student_ist_name, "Enter ist name")
        '
        'lbl_student_last_examination_passed
        '
        Me.lbl_student_last_examination_passed.AutoSize = True
        Me.lbl_student_last_examination_passed.BackColor = System.Drawing.Color.Transparent
        Me.lbl_student_last_examination_passed.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_student_last_examination_passed.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_student_last_examination_passed.Location = New System.Drawing.Point(6, 247)
        Me.lbl_student_last_examination_passed.Name = "lbl_student_last_examination_passed"
        Me.lbl_student_last_examination_passed.Size = New System.Drawing.Size(104, 15)
        Me.lbl_student_last_examination_passed.TabIndex = 182
        Me.lbl_student_last_examination_passed.Text = "Last Exam. passed"
        '
        'lbl_cell_no
        '
        Me.lbl_cell_no.AutoSize = True
        Me.lbl_cell_no.BackColor = System.Drawing.Color.Transparent
        Me.lbl_cell_no.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cell_no.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_cell_no.Location = New System.Drawing.Point(6, 218)
        Me.lbl_cell_no.Name = "lbl_cell_no"
        Me.lbl_cell_no.Size = New System.Drawing.Size(49, 15)
        Me.lbl_cell_no.TabIndex = 181
        Me.lbl_cell_no.Text = "Cell No."
        '
        'lbl_birthdate
        '
        Me.lbl_birthdate.AutoSize = True
        Me.lbl_birthdate.BackColor = System.Drawing.Color.Transparent
        Me.lbl_birthdate.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_birthdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_birthdate.Location = New System.Drawing.Point(6, 192)
        Me.lbl_birthdate.Name = "lbl_birthdate"
        Me.lbl_birthdate.Size = New System.Drawing.Size(37, 15)
        Me.lbl_birthdate.TabIndex = 180
        Me.lbl_birthdate.Text = "D.O.B"
        '
        'lbl_student_last_name
        '
        Me.lbl_student_last_name.AutoSize = True
        Me.lbl_student_last_name.BackColor = System.Drawing.Color.Transparent
        Me.lbl_student_last_name.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_student_last_name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_student_last_name.Location = New System.Drawing.Point(6, 102)
        Me.lbl_student_last_name.Name = "lbl_student_last_name"
        Me.lbl_student_last_name.Size = New System.Drawing.Size(65, 15)
        Me.lbl_student_last_name.TabIndex = 188
        Me.lbl_student_last_name.Text = "Last Name"
        '
        'lbl_student_ist_name
        '
        Me.lbl_student_ist_name.AutoSize = True
        Me.lbl_student_ist_name.BackColor = System.Drawing.Color.Transparent
        Me.lbl_student_ist_name.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_student_ist_name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_student_ist_name.Location = New System.Drawing.Point(6, 74)
        Me.lbl_student_ist_name.Name = "lbl_student_ist_name"
        Me.lbl_student_ist_name.Size = New System.Drawing.Size(54, 15)
        Me.lbl_student_ist_name.TabIndex = 184
        Me.lbl_student_ist_name.Text = "Ist name"
        '
        'lbl_class_of_joining
        '
        Me.lbl_class_of_joining.AutoSize = True
        Me.lbl_class_of_joining.BackColor = System.Drawing.Color.Transparent
        Me.lbl_class_of_joining.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_class_of_joining.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_class_of_joining.Location = New System.Drawing.Point(6, 45)
        Me.lbl_class_of_joining.Name = "lbl_class_of_joining"
        Me.lbl_class_of_joining.Size = New System.Drawing.Size(86, 15)
        Me.lbl_class_of_joining.TabIndex = 178
        Me.lbl_class_of_joining.Text = "Class of joining"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(446, 69)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(149, 124)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 189
        Me.PictureBox1.TabStop = False
        '
        'txt_address
        '
        Me.txt_address.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_address.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_address.Location = New System.Drawing.Point(73, 12)
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(210, 23)
        Me.txt_address.TabIndex = 14
        Me.ToolTip.SetToolTip(Me.txt_address, "Enter address")
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_update.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.Color.Black
        Me.btn_update.Location = New System.Drawing.Point(393, 387)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(86, 27)
        Me.btn_update.TabIndex = 19
        Me.btn_update.Text = "&Update"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'ToolTip
        '
        Me.ToolTip.ForeColor = System.Drawing.Color.Purple
        '
        'txt_email
        '
        Me.txt_email.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_email.Location = New System.Drawing.Point(73, 128)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(210, 23)
        Me.txt_email.TabIndex = 18
        Me.ToolTip.SetToolTip(Me.txt_email, "Enter email id.")
        '
        'txt_pin_no
        '
        Me.txt_pin_no.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pin_no.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_pin_no.Location = New System.Drawing.Point(73, 99)
        Me.txt_pin_no.Name = "txt_pin_no"
        Me.txt_pin_no.Size = New System.Drawing.Size(126, 23)
        Me.txt_pin_no.TabIndex = 17
        Me.ToolTip.SetToolTip(Me.txt_pin_no, "Enter Pin no.")
        '
        'cmb_state
        '
        Me.cmb_state.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_state.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmb_state.FormattingEnabled = True
        Me.cmb_state.Items.AddRange(New Object() {"J&K", "Punjab", "Delhi", "Amritsar", "Assam", "Jharkhand", "Bangalore", "Mumbai", "Pune", "Kolkatta", "Lahore", "Baloghistan", "Karachi", "Rawalpindi", "Faisalabad", "Islambad", "Kabul", "Colombo", "Dhaka"})
        Me.cmb_state.Location = New System.Drawing.Point(73, 41)
        Me.cmb_state.Name = "cmb_state"
        Me.cmb_state.Size = New System.Drawing.Size(126, 23)
        Me.cmb_state.TabIndex = 15
        Me.cmb_state.Text = "Select"
        Me.ToolTip.SetToolTip(Me.cmb_state, "Select the state")
        '
        'cmb_city
        '
        Me.cmb_city.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_city.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmb_city.FormattingEnabled = True
        Me.cmb_city.Items.AddRange(New Object() {"Srinagar", "Badgam", "Islamadad", "Sopore", "Punch", "Rajouri"})
        Me.cmb_city.Location = New System.Drawing.Point(73, 70)
        Me.cmb_city.Name = "cmb_city"
        Me.cmb_city.Size = New System.Drawing.Size(126, 23)
        Me.cmb_city.TabIndex = 16
        Me.cmb_city.Text = "Select"
        Me.ToolTip.SetToolTip(Me.cmb_city, "Select the city")
        '
        'rdb_male
        '
        Me.rdb_male.AutoSize = True
        Me.rdb_male.Checked = True
        Me.rdb_male.Location = New System.Drawing.Point(19, 10)
        Me.rdb_male.Name = "rdb_male"
        Me.rdb_male.Size = New System.Drawing.Size(52, 19)
        Me.rdb_male.TabIndex = 12
        Me.rdb_male.TabStop = True
        Me.rdb_male.Text = "Male"
        Me.rdb_male.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rdb_male)
        Me.GroupBox3.Controls.Add(Me.rdb_female)
        Me.GroupBox3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox3.Location = New System.Drawing.Point(6, 365)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(180, 33)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        '
        'rdb_female
        '
        Me.rdb_female.AutoSize = True
        Me.rdb_female.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_female.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdb_female.Location = New System.Drawing.Point(104, 10)
        Me.rdb_female.Name = "rdb_female"
        Me.rdb_female.Size = New System.Drawing.Size(65, 19)
        Me.rdb_female.TabIndex = 13
        Me.rdb_female.Text = "Female"
        Me.rdb_female.UseVisualStyleBackColor = True
        '
        'btn_clear_all
        '
        Me.btn_clear_all.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_clear_all.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear_all.ForeColor = System.Drawing.Color.Black
        Me.btn_clear_all.Location = New System.Drawing.Point(485, 387)
        Me.btn_clear_all.Name = "btn_clear_all"
        Me.btn_clear_all.Size = New System.Drawing.Size(86, 27)
        Me.btn_clear_all.TabIndex = 20
        Me.btn_clear_all.Text = "Clear &All"
        Me.btn_clear_all.UseVisualStyleBackColor = False
        '
        'lbl_heading_admission_form
        '
        Me.lbl_heading_admission_form.AutoSize = True
        Me.lbl_heading_admission_form.BackColor = System.Drawing.Color.Transparent
        Me.lbl_heading_admission_form.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_heading_admission_form.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_heading_admission_form.Location = New System.Drawing.Point(23, 9)
        Me.lbl_heading_admission_form.Name = "lbl_heading_admission_form"
        Me.lbl_heading_admission_form.Size = New System.Drawing.Size(572, 57)
        Me.lbl_heading_admission_form.TabIndex = 188
        Me.lbl_heading_admission_form.Text = "STUDENT INFORMATION"
        Me.lbl_heading_admission_form.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_address
        '
        Me.lbl_address.AutoSize = True
        Me.lbl_address.BackColor = System.Drawing.Color.Transparent
        Me.lbl_address.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_address.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_address.Location = New System.Drawing.Point(6, 15)
        Me.lbl_address.Name = "lbl_address"
        Me.lbl_address.Size = New System.Drawing.Size(51, 15)
        Me.lbl_address.TabIndex = 173
        Me.lbl_address.Text = "Address"
        '
        'lbl_state
        '
        Me.lbl_state.AutoSize = True
        Me.lbl_state.BackColor = System.Drawing.Color.Transparent
        Me.lbl_state.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_state.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_state.Location = New System.Drawing.Point(6, 44)
        Me.lbl_state.Name = "lbl_state"
        Me.lbl_state.Size = New System.Drawing.Size(36, 15)
        Me.lbl_state.TabIndex = 170
        Me.lbl_state.Text = "State"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmb_state)
        Me.GroupBox2.Controls.Add(Me.cmb_city)
        Me.GroupBox2.Controls.Add(Me.txt_pin_no)
        Me.GroupBox2.Controls.Add(Me.lbl_pin_no)
        Me.GroupBox2.Controls.Add(Me.lbl_email)
        Me.GroupBox2.Controls.Add(Me.lbl_city)
        Me.GroupBox2.Controls.Add(Me.lbl_state)
        Me.GroupBox2.Controls.Add(Me.lbl_address)
        Me.GroupBox2.Controls.Add(Me.txt_email)
        Me.GroupBox2.Controls.Add(Me.txt_address)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox2.Location = New System.Drawing.Point(380, 223)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(289, 158)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        '
        'lbl_pin_no
        '
        Me.lbl_pin_no.AutoSize = True
        Me.lbl_pin_no.BackColor = System.Drawing.Color.Transparent
        Me.lbl_pin_no.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pin_no.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_pin_no.Location = New System.Drawing.Point(6, 102)
        Me.lbl_pin_no.Name = "lbl_pin_no"
        Me.lbl_pin_no.Size = New System.Drawing.Size(49, 15)
        Me.lbl_pin_no.TabIndex = 174
        Me.lbl_pin_no.Text = "Pin_No."
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.BackColor = System.Drawing.Color.Transparent
        Me.lbl_email.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_email.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_email.Location = New System.Drawing.Point(6, 131)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(40, 15)
        Me.lbl_email.TabIndex = 171
        Me.lbl_email.Text = "E-Mail"
        '
        'lbl_city
        '
        Me.lbl_city.AutoSize = True
        Me.lbl_city.BackColor = System.Drawing.Color.Transparent
        Me.lbl_city.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_city.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_city.Location = New System.Drawing.Point(6, 73)
        Me.lbl_city.Name = "lbl_city"
        Me.lbl_city.Size = New System.Drawing.Size(28, 15)
        Me.lbl_city.TabIndex = 169
        Me.lbl_city.Text = "City"
        '
        'btn_pic
        '
        Me.btn_pic.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_pic.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_pic.ForeColor = System.Drawing.Color.Black
        Me.btn_pic.Location = New System.Drawing.Point(466, 199)
        Me.btn_pic.Name = "btn_pic"
        Me.btn_pic.Size = New System.Drawing.Size(113, 23)
        Me.btn_pic.TabIndex = 190
        Me.btn_pic.Text = "Click for picture"
        Me.btn_pic.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'edit_stud_details_form
        '
        Me.AcceptButton = Me.btn_update
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.CancelButton = Me.btn_exit
        Me.ClientSize = New System.Drawing.Size(676, 425)
        Me.Controls.Add(Me.btn_pic)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btn_clear_all)
        Me.Controls.Add(Me.lbl_heading_admission_form)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "edit_stud_details_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "STUDENT REGESTRATION SYSTEM"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_exit As System.Windows.Forms.Button
    Friend WithEvents txt_exam_passed As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_admission_no As System.Windows.Forms.TextBox
    Friend WithEvents msk_cell_no As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lbl_admission_no As System.Windows.Forms.Label
    Friend WithEvents cmb_joining_class As System.Windows.Forms.ComboBox
    Friend WithEvents txt_mothers_name As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents txt_fathers_name As System.Windows.Forms.TextBox
    Friend WithEvents txt_student_last_name As System.Windows.Forms.TextBox
    Friend WithEvents txt_student_ist_name As System.Windows.Forms.TextBox
    Friend WithEvents lbl_student_last_examination_passed As System.Windows.Forms.Label
    Friend WithEvents lbl_cell_no As System.Windows.Forms.Label
    Friend WithEvents lbl_birthdate As System.Windows.Forms.Label
    Friend WithEvents lbl_student_last_name As System.Windows.Forms.Label
    Friend WithEvents lbl_student_ist_name As System.Windows.Forms.Label
    Friend WithEvents lbl_class_of_joining As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_address As System.Windows.Forms.TextBox
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents txt_pin_no As System.Windows.Forms.TextBox
    Friend WithEvents rdb_male As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_female As System.Windows.Forms.RadioButton
    Friend WithEvents btn_clear_all As System.Windows.Forms.Button
    Friend WithEvents lbl_heading_admission_form As System.Windows.Forms.Label
    Friend WithEvents lbl_address As System.Windows.Forms.Label
    Friend WithEvents lbl_state As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_state As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_city As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_pin_no As System.Windows.Forms.Label
    Friend WithEvents lbl_email As System.Windows.Forms.Label
    Friend WithEvents lbl_city As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmb_session As System.Windows.Forms.TextBox
    Friend WithEvents btn_pic As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
