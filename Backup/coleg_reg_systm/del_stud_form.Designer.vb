<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class del_stud_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(del_stud_form))
        Me.lbl_state = New System.Windows.Forms.Label
        Me.btn_close = New System.Windows.Forms.Button
        Me.txt_admission_no = New System.Windows.Forms.TextBox
        Me.txt_exam_passed = New System.Windows.Forms.TextBox
        Me.lbl_address = New System.Windows.Forms.Label
        Me.msk_cell_no = New System.Windows.Forms.MaskedTextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmb_state = New System.Windows.Forms.ComboBox
        Me.cmb_city = New System.Windows.Forms.ComboBox
        Me.txt_pin_no = New System.Windows.Forms.TextBox
        Me.lbl_pin_no = New System.Windows.Forms.Label
        Me.lbl_email = New System.Windows.Forms.Label
        Me.lbl_city = New System.Windows.Forms.Label
        Me.txt_email = New System.Windows.Forms.TextBox
        Me.txt_address = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.lbl_heading_admission_form = New System.Windows.Forms.Label
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmb_session = New System.Windows.Forms.TextBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbl_class_of_joining = New System.Windows.Forms.Label
        Me.btn_delete = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.rdb_male = New System.Windows.Forms.RadioButton
        Me.rdb_female = New System.Windows.Forms.RadioButton
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_state
        '
        Me.lbl_state.AutoSize = True
        Me.lbl_state.BackColor = System.Drawing.Color.Transparent
        Me.lbl_state.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_state.ForeColor = System.Drawing.Color.Black
        Me.lbl_state.Location = New System.Drawing.Point(7, 45)
        Me.lbl_state.Name = "lbl_state"
        Me.lbl_state.Size = New System.Drawing.Size(36, 15)
        Me.lbl_state.TabIndex = 170
        Me.lbl_state.Text = "State"
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_close.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_close.ForeColor = System.Drawing.Color.Black
        Me.btn_close.Location = New System.Drawing.Point(578, 373)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(86, 27)
        Me.btn_close.TabIndex = 18
        Me.btn_close.Text = "&Close"
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'txt_admission_no
        '
        Me.txt_admission_no.BackColor = System.Drawing.SystemColors.Info
        Me.txt_admission_no.Enabled = False
        Me.txt_admission_no.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_admission_no.ForeColor = System.Drawing.Color.Black
        Me.txt_admission_no.Location = New System.Drawing.Point(139, 12)
        Me.txt_admission_no.Name = "txt_admission_no"
        Me.txt_admission_no.ReadOnly = True
        Me.txt_admission_no.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_admission_no.Size = New System.Drawing.Size(52, 23)
        Me.txt_admission_no.TabIndex = 1
        '
        'txt_exam_passed
        '
        Me.txt_exam_passed.BackColor = System.Drawing.SystemColors.Info
        Me.txt_exam_passed.Enabled = False
        Me.txt_exam_passed.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_exam_passed.Location = New System.Drawing.Point(139, 232)
        Me.txt_exam_passed.Name = "txt_exam_passed"
        Me.txt_exam_passed.ReadOnly = True
        Me.txt_exam_passed.Size = New System.Drawing.Size(126, 23)
        Me.txt_exam_passed.TabIndex = 9
        Me.txt_exam_passed.Text = "Select"
        '
        'lbl_address
        '
        Me.lbl_address.AutoSize = True
        Me.lbl_address.BackColor = System.Drawing.Color.Transparent
        Me.lbl_address.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_address.ForeColor = System.Drawing.Color.Black
        Me.lbl_address.Location = New System.Drawing.Point(7, 16)
        Me.lbl_address.Name = "lbl_address"
        Me.lbl_address.Size = New System.Drawing.Size(51, 15)
        Me.lbl_address.TabIndex = 173
        Me.lbl_address.Text = "Address"
        '
        'msk_cell_no
        '
        Me.msk_cell_no.BackColor = System.Drawing.SystemColors.Info
        Me.msk_cell_no.Enabled = False
        Me.msk_cell_no.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msk_cell_no.ForeColor = System.Drawing.Color.Black
        Me.msk_cell_no.Location = New System.Drawing.Point(139, 206)
        Me.msk_cell_no.Mask = "(999) 000-0000"
        Me.msk_cell_no.Name = "msk_cell_no"
        Me.msk_cell_no.Size = New System.Drawing.Size(126, 23)
        Me.msk_cell_no.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(13, 127)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 15)
        Me.Label11.TabIndex = 190
        Me.Label11.Text = "Father's Name"
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
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(371, 208)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(307, 159)
        Me.GroupBox2.TabIndex = 193
        Me.GroupBox2.TabStop = False
        '
        'cmb_state
        '
        Me.cmb_state.BackColor = System.Drawing.SystemColors.Info
        Me.cmb_state.Enabled = False
        Me.cmb_state.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_state.ForeColor = System.Drawing.Color.Black
        Me.cmb_state.FormattingEnabled = True
        Me.cmb_state.Items.AddRange(New Object() {"J&K", "Punjab", "Delhi", "Amritsar", "Assam", "Jharkhand", "Bangalore", "Mumbai", "Pune", "Kolkatta", "Lahore", "Baloghistan", "Karachi", "Rawalpindi", "Faisalabad", "Islambad", "Kabul", "Colombo", "Dhaka"})
        Me.cmb_state.Location = New System.Drawing.Point(65, 42)
        Me.cmb_state.Name = "cmb_state"
        Me.cmb_state.Size = New System.Drawing.Size(131, 23)
        Me.cmb_state.TabIndex = 13
        Me.cmb_state.Text = "Select"
        '
        'cmb_city
        '
        Me.cmb_city.BackColor = System.Drawing.SystemColors.Info
        Me.cmb_city.Enabled = False
        Me.cmb_city.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_city.ForeColor = System.Drawing.Color.Black
        Me.cmb_city.FormattingEnabled = True
        Me.cmb_city.Items.AddRange(New Object() {"Srinagar", "Badgam", "Islamadad", "Sopore", "Punch", "Rajouri"})
        Me.cmb_city.Location = New System.Drawing.Point(65, 71)
        Me.cmb_city.Name = "cmb_city"
        Me.cmb_city.Size = New System.Drawing.Size(131, 23)
        Me.cmb_city.TabIndex = 14
        Me.cmb_city.Text = "Select"
        '
        'txt_pin_no
        '
        Me.txt_pin_no.BackColor = System.Drawing.SystemColors.Info
        Me.txt_pin_no.Enabled = False
        Me.txt_pin_no.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pin_no.ForeColor = System.Drawing.Color.Black
        Me.txt_pin_no.Location = New System.Drawing.Point(65, 100)
        Me.txt_pin_no.Name = "txt_pin_no"
        Me.txt_pin_no.Size = New System.Drawing.Size(131, 23)
        Me.txt_pin_no.TabIndex = 15
        '
        'lbl_pin_no
        '
        Me.lbl_pin_no.AutoSize = True
        Me.lbl_pin_no.BackColor = System.Drawing.Color.Transparent
        Me.lbl_pin_no.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pin_no.ForeColor = System.Drawing.Color.Black
        Me.lbl_pin_no.Location = New System.Drawing.Point(7, 103)
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
        Me.lbl_email.ForeColor = System.Drawing.Color.Black
        Me.lbl_email.Location = New System.Drawing.Point(7, 132)
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
        Me.lbl_city.ForeColor = System.Drawing.Color.Black
        Me.lbl_city.Location = New System.Drawing.Point(7, 74)
        Me.lbl_city.Name = "lbl_city"
        Me.lbl_city.Size = New System.Drawing.Size(28, 15)
        Me.lbl_city.TabIndex = 169
        Me.lbl_city.Text = "City"
        '
        'txt_email
        '
        Me.txt_email.BackColor = System.Drawing.SystemColors.Info
        Me.txt_email.Enabled = False
        Me.txt_email.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.ForeColor = System.Drawing.Color.Black
        Me.txt_email.Location = New System.Drawing.Point(65, 129)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(236, 23)
        Me.txt_email.TabIndex = 16
        '
        'txt_address
        '
        Me.txt_address.BackColor = System.Drawing.SystemColors.Info
        Me.txt_address.Enabled = False
        Me.txt_address.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_address.ForeColor = System.Drawing.Color.Black
        Me.txt_address.Location = New System.Drawing.Point(65, 13)
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(236, 23)
        Me.txt_address.TabIndex = 12
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(13, 155)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(93, 15)
        Me.Label12.TabIndex = 189
        Me.Label12.Text = "Mother's Name"
        '
        'lbl_heading_admission_form
        '
        Me.lbl_heading_admission_form.AutoSize = True
        Me.lbl_heading_admission_form.BackColor = System.Drawing.Color.Transparent
        Me.lbl_heading_admission_form.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_heading_admission_form.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_heading_admission_form.Location = New System.Drawing.Point(113, -1)
        Me.lbl_heading_admission_form.Name = "lbl_heading_admission_form"
        Me.lbl_heading_admission_form.Size = New System.Drawing.Size(430, 57)
        Me.lbl_heading_admission_form.TabIndex = 197
        Me.lbl_heading_admission_form.Text = "DELETE STUDENT"
        Me.lbl_heading_admission_form.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_admission_no
        '
        Me.lbl_admission_no.AutoSize = True
        Me.lbl_admission_no.BackColor = System.Drawing.Color.Transparent
        Me.lbl_admission_no.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_admission_no.ForeColor = System.Drawing.Color.Black
        Me.lbl_admission_no.Location = New System.Drawing.Point(13, 13)
        Me.lbl_admission_no.Name = "lbl_admission_no"
        Me.lbl_admission_no.Size = New System.Drawing.Size(85, 15)
        Me.lbl_admission_no.TabIndex = 185
        Me.lbl_admission_no.Text = "Admission No."
        '
        'cmb_joining_class
        '
        Me.cmb_joining_class.BackColor = System.Drawing.SystemColors.Info
        Me.cmb_joining_class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_joining_class.Enabled = False
        Me.cmb_joining_class.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_joining_class.ForeColor = System.Drawing.Color.Black
        Me.cmb_joining_class.FormattingEnabled = True
        Me.cmb_joining_class.Items.AddRange(New Object() {"BCA IST YEAR", "BCA 2ND YEAR", "BCA 3RD YEAR"})
        Me.cmb_joining_class.Location = New System.Drawing.Point(139, 38)
        Me.cmb_joining_class.Name = "cmb_joining_class"
        Me.cmb_joining_class.Size = New System.Drawing.Size(126, 23)
        Me.cmb_joining_class.TabIndex = 2
        '
        'txt_mothers_name
        '
        Me.txt_mothers_name.BackColor = System.Drawing.SystemColors.Info
        Me.txt_mothers_name.Enabled = False
        Me.txt_mothers_name.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_mothers_name.ForeColor = System.Drawing.Color.Black
        Me.txt_mothers_name.Location = New System.Drawing.Point(139, 152)
        Me.txt_mothers_name.Name = "txt_mothers_name"
        Me.txt_mothers_name.Size = New System.Drawing.Size(215, 23)
        Me.txt_mothers_name.TabIndex = 6
        '
        'txt_fathers_name
        '
        Me.txt_fathers_name.BackColor = System.Drawing.SystemColors.Info
        Me.txt_fathers_name.Enabled = False
        Me.txt_fathers_name.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fathers_name.ForeColor = System.Drawing.Color.Black
        Me.txt_fathers_name.Location = New System.Drawing.Point(139, 124)
        Me.txt_fathers_name.Name = "txt_fathers_name"
        Me.txt_fathers_name.Size = New System.Drawing.Size(215, 23)
        Me.txt_fathers_name.TabIndex = 5
        '
        'txt_student_last_name
        '
        Me.txt_student_last_name.BackColor = System.Drawing.SystemColors.Info
        Me.txt_student_last_name.Enabled = False
        Me.txt_student_last_name.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_student_last_name.ForeColor = System.Drawing.Color.Black
        Me.txt_student_last_name.Location = New System.Drawing.Point(139, 96)
        Me.txt_student_last_name.Name = "txt_student_last_name"
        Me.txt_student_last_name.Size = New System.Drawing.Size(216, 23)
        Me.txt_student_last_name.TabIndex = 4
        '
        'txt_student_ist_name
        '
        Me.txt_student_ist_name.BackColor = System.Drawing.SystemColors.Info
        Me.txt_student_ist_name.Enabled = False
        Me.txt_student_ist_name.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_student_ist_name.ForeColor = System.Drawing.Color.Black
        Me.txt_student_ist_name.Location = New System.Drawing.Point(139, 68)
        Me.txt_student_ist_name.Name = "txt_student_ist_name"
        Me.txt_student_ist_name.Size = New System.Drawing.Size(216, 23)
        Me.txt_student_ist_name.TabIndex = 3
        '
        'lbl_student_last_examination_passed
        '
        Me.lbl_student_last_examination_passed.AutoSize = True
        Me.lbl_student_last_examination_passed.BackColor = System.Drawing.Color.Transparent
        Me.lbl_student_last_examination_passed.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_student_last_examination_passed.ForeColor = System.Drawing.Color.Black
        Me.lbl_student_last_examination_passed.Location = New System.Drawing.Point(13, 233)
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
        Me.lbl_cell_no.ForeColor = System.Drawing.Color.Black
        Me.lbl_cell_no.Location = New System.Drawing.Point(13, 207)
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
        Me.lbl_birthdate.ForeColor = System.Drawing.Color.Black
        Me.lbl_birthdate.Location = New System.Drawing.Point(13, 184)
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
        Me.lbl_student_last_name.ForeColor = System.Drawing.Color.Black
        Me.lbl_student_last_name.Location = New System.Drawing.Point(13, 99)
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
        Me.lbl_student_ist_name.ForeColor = System.Drawing.Color.Black
        Me.lbl_student_ist_name.Location = New System.Drawing.Point(13, 71)
        Me.lbl_student_ist_name.Name = "lbl_student_ist_name"
        Me.lbl_student_ist_name.Size = New System.Drawing.Size(54, 15)
        Me.lbl_student_ist_name.TabIndex = 184
        Me.lbl_student_ist_name.Text = "Ist name"
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
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(3, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(362, 291)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'cmb_session
        '
        Me.cmb_session.BackColor = System.Drawing.SystemColors.Info
        Me.cmb_session.Enabled = False
        Me.cmb_session.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_session.Location = New System.Drawing.Point(139, 257)
        Me.cmb_session.Name = "cmb_session"
        Me.cmb_session.ReadOnly = True
        Me.cmb_session.Size = New System.Drawing.Size(126, 23)
        Me.cmb_session.TabIndex = 1008
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(139, 180)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(217, 23)
        Me.DateTimePicker1.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(13, 260)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 15)
        Me.Label1.TabIndex = 1004
        Me.Label1.Text = "Session"
        '
        'lbl_class_of_joining
        '
        Me.lbl_class_of_joining.AutoSize = True
        Me.lbl_class_of_joining.BackColor = System.Drawing.Color.Transparent
        Me.lbl_class_of_joining.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_class_of_joining.ForeColor = System.Drawing.Color.Black
        Me.lbl_class_of_joining.Location = New System.Drawing.Point(13, 41)
        Me.lbl_class_of_joining.Name = "lbl_class_of_joining"
        Me.lbl_class_of_joining.Size = New System.Drawing.Size(86, 15)
        Me.lbl_class_of_joining.TabIndex = 178
        Me.lbl_class_of_joining.Text = "Class of joining"
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_delete.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.Black
        Me.btn_delete.Location = New System.Drawing.Point(481, 373)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(86, 27)
        Me.btn_delete.TabIndex = 17
        Me.btn_delete.Text = "&Delete"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(436, 72)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(167, 131)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 198
        Me.PictureBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rdb_male)
        Me.GroupBox3.Controls.Add(Me.rdb_female)
        Me.GroupBox3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(3, 356)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(148, 32)
        Me.GroupBox3.TabIndex = 204
        Me.GroupBox3.TabStop = False
        '
        'rdb_male
        '
        Me.rdb_male.AutoSize = True
        Me.rdb_male.Checked = True
        Me.rdb_male.Enabled = False
        Me.rdb_male.Location = New System.Drawing.Point(6, 11)
        Me.rdb_male.Name = "rdb_male"
        Me.rdb_male.Size = New System.Drawing.Size(52, 19)
        Me.rdb_male.TabIndex = 12
        Me.rdb_male.TabStop = True
        Me.rdb_male.Text = "Male"
        Me.rdb_male.UseVisualStyleBackColor = True
        '
        'rdb_female
        '
        Me.rdb_female.AutoSize = True
        Me.rdb_female.Enabled = False
        Me.rdb_female.Location = New System.Drawing.Point(77, 11)
        Me.rdb_female.Name = "rdb_female"
        Me.rdb_female.Size = New System.Drawing.Size(65, 19)
        Me.rdb_female.TabIndex = 13
        Me.rdb_female.Text = "Female"
        Me.rdb_female.UseVisualStyleBackColor = True
        '
        'del_stud_form
        '
        Me.AcceptButton = Me.btn_delete
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.CancelButton = Me.btn_close
        Me.ClientSize = New System.Drawing.Size(684, 409)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lbl_heading_admission_form)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_delete)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "del_stud_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Regestration System "
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_state As System.Windows.Forms.Label
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents txt_admission_no As System.Windows.Forms.TextBox
    Friend WithEvents txt_exam_passed As System.Windows.Forms.TextBox
    Friend WithEvents lbl_address As System.Windows.Forms.Label
    Friend WithEvents msk_cell_no As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_state As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_city As System.Windows.Forms.ComboBox
    Friend WithEvents txt_pin_no As System.Windows.Forms.TextBox
    Friend WithEvents lbl_pin_no As System.Windows.Forms.Label
    Friend WithEvents lbl_email As System.Windows.Forms.Label
    Friend WithEvents lbl_city As System.Windows.Forms.Label
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents txt_address As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lbl_heading_admission_form As System.Windows.Forms.Label
    Friend WithEvents lbl_admission_no As System.Windows.Forms.Label
    Friend WithEvents cmb_joining_class As System.Windows.Forms.ComboBox
    Friend WithEvents txt_mothers_name As System.Windows.Forms.TextBox
    Friend WithEvents txt_fathers_name As System.Windows.Forms.TextBox
    Friend WithEvents txt_student_last_name As System.Windows.Forms.TextBox
    Friend WithEvents txt_student_ist_name As System.Windows.Forms.TextBox
    Friend WithEvents lbl_student_last_examination_passed As System.Windows.Forms.Label
    Friend WithEvents lbl_cell_no As System.Windows.Forms.Label
    Friend WithEvents lbl_birthdate As System.Windows.Forms.Label
    Friend WithEvents lbl_student_last_name As System.Windows.Forms.Label
    Friend WithEvents lbl_student_ist_name As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_class_of_joining As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmb_session As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_male As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_female As System.Windows.Forms.RadioButton
End Class
