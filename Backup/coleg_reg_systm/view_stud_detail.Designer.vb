<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class view_stud_detail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(view_stud_detail))
        Me.btn_close = New System.Windows.Forms.Button
        Me.lbl_heading_admission_form = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lbl_pin_no = New System.Windows.Forms.Label
        Me.lbl_email = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txt_email = New System.Windows.Forms.MaskedTextBox
        Me.cmb_state = New System.Windows.Forms.ComboBox
        Me.cmb_city = New System.Windows.Forms.ComboBox
        Me.txt_pin_no = New System.Windows.Forms.TextBox
        Me.lbl_city = New System.Windows.Forms.Label
        Me.lbl_state = New System.Windows.Forms.Label
        Me.lbl_address = New System.Windows.Forms.Label
        Me.txt_address = New System.Windows.Forms.TextBox
        Me.txt_name = New System.Windows.Forms.TextBox
        Me.lbl_name = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.txt_exam_passed = New System.Windows.Forms.TextBox
        Me.msk_cell_no = New System.Windows.Forms.MaskedTextBox
        Me.rdb_female = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_admission_no = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.lbl_admission_no = New System.Windows.Forms.Label
        Me.cmb_joining_class = New System.Windows.Forms.ComboBox
        Me.txt_mothers_name = New System.Windows.Forms.TextBox
        Me.txt_fathers_name = New System.Windows.Forms.TextBox
        Me.lbl_student_last_examination_passed = New System.Windows.Forms.Label
        Me.lbl_cell_no = New System.Windows.Forms.Label
        Me.lbl_birthdate = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmb_session = New System.Windows.Forms.TextBox
        Me.lbl_class_of_joining = New System.Windows.Forms.Label
        Me.rdb_male = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_close.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_close.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_close.Location = New System.Drawing.Point(534, 351)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(86, 27)
        Me.btn_close.TabIndex = 196
        Me.btn_close.Text = "&Close"
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'lbl_heading_admission_form
        '
        Me.lbl_heading_admission_form.AutoSize = True
        Me.lbl_heading_admission_form.BackColor = System.Drawing.Color.Transparent
        Me.lbl_heading_admission_form.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_heading_admission_form.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_heading_admission_form.Location = New System.Drawing.Point(120, -2)
        Me.lbl_heading_admission_form.Name = "lbl_heading_admission_form"
        Me.lbl_heading_admission_form.Size = New System.Drawing.Size(373, 57)
        Me.lbl_heading_admission_form.TabIndex = 197
        Me.lbl_heading_admission_form.Text = "VIEW STUDENT"
        Me.lbl_heading_admission_form.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(443, 58)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(177, 131)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 205
        Me.PictureBox1.TabStop = False
        '
        'lbl_pin_no
        '
        Me.lbl_pin_no.AutoSize = True
        Me.lbl_pin_no.BackColor = System.Drawing.Color.Transparent
        Me.lbl_pin_no.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pin_no.ForeColor = System.Drawing.Color.Black
        Me.lbl_pin_no.Location = New System.Drawing.Point(7, 93)
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
        Me.lbl_email.Location = New System.Drawing.Point(8, 121)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(40, 15)
        Me.lbl_email.TabIndex = 171
        Me.lbl_email.Text = "E-Mail"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_email)
        Me.GroupBox2.Controls.Add(Me.cmb_state)
        Me.GroupBox2.Controls.Add(Me.cmb_city)
        Me.GroupBox2.Controls.Add(Me.txt_pin_no)
        Me.GroupBox2.Controls.Add(Me.lbl_pin_no)
        Me.GroupBox2.Controls.Add(Me.lbl_email)
        Me.GroupBox2.Controls.Add(Me.lbl_city)
        Me.GroupBox2.Controls.Add(Me.lbl_state)
        Me.GroupBox2.Controls.Add(Me.lbl_address)
        Me.GroupBox2.Controls.Add(Me.txt_address)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(379, 195)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(280, 147)
        Me.GroupBox2.TabIndex = 204
        Me.GroupBox2.TabStop = False
        '
        'txt_email
        '
        Me.txt_email.BackColor = System.Drawing.SystemColors.Info
        Me.txt_email.Enabled = False
        Me.txt_email.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_email.Location = New System.Drawing.Point(64, 118)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(210, 23)
        Me.txt_email.TabIndex = 18
        '
        'cmb_state
        '
        Me.cmb_state.BackColor = System.Drawing.SystemColors.Info
        Me.cmb_state.Enabled = False
        Me.cmb_state.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_state.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmb_state.FormattingEnabled = True
        Me.cmb_state.Items.AddRange(New Object() {"J&K", "Punjab", "Delhi", "Amritsar", "Assam", "Jharkhand", "Bangalore", "Mumbai", "Pune", "Kolkatta", "Lahore", "Baloghistan", "Karachi", "Rawalpindi", "Faisalabad", "Islambad", "Kabul", "Colombo", "Dhaka"})
        Me.cmb_state.Location = New System.Drawing.Point(64, 34)
        Me.cmb_state.Name = "cmb_state"
        Me.cmb_state.Size = New System.Drawing.Size(126, 23)
        Me.cmb_state.TabIndex = 15
        Me.cmb_state.Text = "Select"
        '
        'cmb_city
        '
        Me.cmb_city.BackColor = System.Drawing.SystemColors.Info
        Me.cmb_city.Enabled = False
        Me.cmb_city.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_city.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmb_city.FormattingEnabled = True
        Me.cmb_city.Items.AddRange(New Object() {"Srinagar", "Badgam", "Islamadad", "Sopore", "Punch", "Rajouri"})
        Me.cmb_city.Location = New System.Drawing.Point(64, 62)
        Me.cmb_city.Name = "cmb_city"
        Me.cmb_city.Size = New System.Drawing.Size(126, 23)
        Me.cmb_city.TabIndex = 16
        Me.cmb_city.Text = "Select"
        '
        'txt_pin_no
        '
        Me.txt_pin_no.BackColor = System.Drawing.SystemColors.Info
        Me.txt_pin_no.Enabled = False
        Me.txt_pin_no.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pin_no.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_pin_no.Location = New System.Drawing.Point(64, 90)
        Me.txt_pin_no.Name = "txt_pin_no"
        Me.txt_pin_no.Size = New System.Drawing.Size(126, 23)
        Me.txt_pin_no.TabIndex = 17
        '
        'lbl_city
        '
        Me.lbl_city.AutoSize = True
        Me.lbl_city.BackColor = System.Drawing.Color.Transparent
        Me.lbl_city.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_city.ForeColor = System.Drawing.Color.Black
        Me.lbl_city.Location = New System.Drawing.Point(8, 65)
        Me.lbl_city.Name = "lbl_city"
        Me.lbl_city.Size = New System.Drawing.Size(28, 15)
        Me.lbl_city.TabIndex = 169
        Me.lbl_city.Text = "City"
        '
        'lbl_state
        '
        Me.lbl_state.AutoSize = True
        Me.lbl_state.BackColor = System.Drawing.Color.Transparent
        Me.lbl_state.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_state.ForeColor = System.Drawing.Color.Black
        Me.lbl_state.Location = New System.Drawing.Point(8, 37)
        Me.lbl_state.Name = "lbl_state"
        Me.lbl_state.Size = New System.Drawing.Size(36, 15)
        Me.lbl_state.TabIndex = 170
        Me.lbl_state.Text = "State"
        '
        'lbl_address
        '
        Me.lbl_address.AutoSize = True
        Me.lbl_address.BackColor = System.Drawing.Color.Transparent
        Me.lbl_address.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_address.ForeColor = System.Drawing.Color.Black
        Me.lbl_address.Location = New System.Drawing.Point(7, 11)
        Me.lbl_address.Name = "lbl_address"
        Me.lbl_address.Size = New System.Drawing.Size(51, 15)
        Me.lbl_address.TabIndex = 173
        Me.lbl_address.Text = "Address"
        '
        'txt_address
        '
        Me.txt_address.BackColor = System.Drawing.SystemColors.Info
        Me.txt_address.Enabled = False
        Me.txt_address.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_address.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_address.Location = New System.Drawing.Point(64, 8)
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(210, 23)
        Me.txt_address.TabIndex = 14
        '
        'txt_name
        '
        Me.txt_name.BackColor = System.Drawing.SystemColors.Info
        Me.txt_name.Enabled = False
        Me.txt_name.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.ForeColor = System.Drawing.Color.Black
        Me.txt_name.Location = New System.Drawing.Point(127, 69)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(233, 23)
        Me.txt_name.TabIndex = 1004
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.BackColor = System.Drawing.Color.Transparent
        Me.lbl_name.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.ForeColor = System.Drawing.Color.Black
        Me.lbl_name.Location = New System.Drawing.Point(12, 72)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(40, 15)
        Me.lbl_name.TabIndex = 1003
        Me.lbl_name.Text = "Name"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(128, 162)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(233, 23)
        Me.DateTimePicker1.TabIndex = 7
        '
        'txt_exam_passed
        '
        Me.txt_exam_passed.BackColor = System.Drawing.SystemColors.Info
        Me.txt_exam_passed.Enabled = False
        Me.txt_exam_passed.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_exam_passed.Location = New System.Drawing.Point(128, 225)
        Me.txt_exam_passed.Name = "txt_exam_passed"
        Me.txt_exam_passed.ReadOnly = True
        Me.txt_exam_passed.Size = New System.Drawing.Size(126, 23)
        Me.txt_exam_passed.TabIndex = 9
        '
        'msk_cell_no
        '
        Me.msk_cell_no.BackColor = System.Drawing.SystemColors.Info
        Me.msk_cell_no.Enabled = False
        Me.msk_cell_no.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msk_cell_no.Location = New System.Drawing.Point(128, 195)
        Me.msk_cell_no.Mask = "(999) 000-0000"
        Me.msk_cell_no.Name = "msk_cell_no"
        Me.msk_cell_no.Size = New System.Drawing.Size(126, 23)
        Me.msk_cell_no.TabIndex = 8
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 258)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 15)
        Me.Label1.TabIndex = 1001
        Me.Label1.Text = "Session"
        '
        'txt_admission_no
        '
        Me.txt_admission_no.BackColor = System.Drawing.SystemColors.Info
        Me.txt_admission_no.Enabled = False
        Me.txt_admission_no.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_admission_no.ForeColor = System.Drawing.Color.Red
        Me.txt_admission_no.Location = New System.Drawing.Point(128, 9)
        Me.txt_admission_no.Name = "txt_admission_no"
        Me.txt_admission_no.ReadOnly = True
        Me.txt_admission_no.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_admission_no.Size = New System.Drawing.Size(63, 23)
        Me.txt_admission_no.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(12, 138)
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
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(12, 108)
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
        Me.lbl_admission_no.ForeColor = System.Drawing.Color.Black
        Me.lbl_admission_no.Location = New System.Drawing.Point(12, 12)
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
        Me.cmb_joining_class.Location = New System.Drawing.Point(128, 39)
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
        Me.txt_mothers_name.Location = New System.Drawing.Point(128, 135)
        Me.txt_mothers_name.Name = "txt_mothers_name"
        Me.txt_mothers_name.Size = New System.Drawing.Size(233, 23)
        Me.txt_mothers_name.TabIndex = 6
        '
        'txt_fathers_name
        '
        Me.txt_fathers_name.BackColor = System.Drawing.SystemColors.Info
        Me.txt_fathers_name.Enabled = False
        Me.txt_fathers_name.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fathers_name.ForeColor = System.Drawing.Color.Black
        Me.txt_fathers_name.Location = New System.Drawing.Point(128, 105)
        Me.txt_fathers_name.Name = "txt_fathers_name"
        Me.txt_fathers_name.Size = New System.Drawing.Size(233, 23)
        Me.txt_fathers_name.TabIndex = 5
        '
        'lbl_student_last_examination_passed
        '
        Me.lbl_student_last_examination_passed.AutoSize = True
        Me.lbl_student_last_examination_passed.BackColor = System.Drawing.Color.Transparent
        Me.lbl_student_last_examination_passed.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_student_last_examination_passed.ForeColor = System.Drawing.Color.Black
        Me.lbl_student_last_examination_passed.Location = New System.Drawing.Point(12, 228)
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
        Me.lbl_cell_no.Location = New System.Drawing.Point(12, 198)
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
        Me.lbl_birthdate.Location = New System.Drawing.Point(12, 168)
        Me.lbl_birthdate.Name = "lbl_birthdate"
        Me.lbl_birthdate.Size = New System.Drawing.Size(37, 15)
        Me.lbl_birthdate.TabIndex = 180
        Me.lbl_birthdate.Text = "D.O.B"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmb_session)
        Me.GroupBox1.Controls.Add(Me.txt_name)
        Me.GroupBox1.Controls.Add(Me.lbl_name)
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
        Me.GroupBox1.Controls.Add(Me.lbl_student_last_examination_passed)
        Me.GroupBox1.Controls.Add(Me.lbl_cell_no)
        Me.GroupBox1.Controls.Add(Me.lbl_birthdate)
        Me.GroupBox1.Controls.Add(Me.lbl_class_of_joining)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(367, 288)
        Me.GroupBox1.TabIndex = 202
        Me.GroupBox1.TabStop = False
        '
        'cmb_session
        '
        Me.cmb_session.BackColor = System.Drawing.SystemColors.Info
        Me.cmb_session.Enabled = False
        Me.cmb_session.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_session.Location = New System.Drawing.Point(127, 255)
        Me.cmb_session.Name = "cmb_session"
        Me.cmb_session.ReadOnly = True
        Me.cmb_session.Size = New System.Drawing.Size(126, 23)
        Me.cmb_session.TabIndex = 1024
        '
        'lbl_class_of_joining
        '
        Me.lbl_class_of_joining.AutoSize = True
        Me.lbl_class_of_joining.BackColor = System.Drawing.Color.Transparent
        Me.lbl_class_of_joining.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_class_of_joining.ForeColor = System.Drawing.Color.Black
        Me.lbl_class_of_joining.Location = New System.Drawing.Point(12, 42)
        Me.lbl_class_of_joining.Name = "lbl_class_of_joining"
        Me.lbl_class_of_joining.Size = New System.Drawing.Size(33, 15)
        Me.lbl_class_of_joining.TabIndex = 178
        Me.lbl_class_of_joining.Text = "Class"
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
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rdb_male)
        Me.GroupBox3.Controls.Add(Me.rdb_female)
        Me.GroupBox3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(6, 348)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(148, 32)
        Me.GroupBox3.TabIndex = 203
        Me.GroupBox3.TabStop = False
        '
        'ToolTip
        '
        Me.ToolTip.ForeColor = System.Drawing.Color.Purple
        '
        'view_stud_detail
        '
        Me.AcceptButton = Me.btn_close
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.CancelButton = Me.btn_close
        Me.ClientSize = New System.Drawing.Size(665, 388)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.lbl_heading_admission_form)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "view_stud_detail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "STUDENTS REGESTRATION SYSTEM"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents lbl_heading_admission_form As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_pin_no As System.Windows.Forms.Label
    Friend WithEvents lbl_email As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_email As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmb_state As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_city As System.Windows.Forms.ComboBox
    Friend WithEvents txt_pin_no As System.Windows.Forms.TextBox
    Friend WithEvents lbl_city As System.Windows.Forms.Label
    Friend WithEvents lbl_state As System.Windows.Forms.Label
    Friend WithEvents lbl_address As System.Windows.Forms.Label
    Friend WithEvents txt_address As System.Windows.Forms.TextBox
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents lbl_name As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_exam_passed As System.Windows.Forms.TextBox
    Friend WithEvents msk_cell_no As System.Windows.Forms.MaskedTextBox
    Friend WithEvents rdb_female As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_admission_no As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lbl_admission_no As System.Windows.Forms.Label
    Friend WithEvents cmb_joining_class As System.Windows.Forms.ComboBox
    Friend WithEvents txt_mothers_name As System.Windows.Forms.TextBox
    Friend WithEvents txt_fathers_name As System.Windows.Forms.TextBox
    Friend WithEvents lbl_student_last_examination_passed As System.Windows.Forms.Label
    Friend WithEvents lbl_cell_no As System.Windows.Forms.Label
    Friend WithEvents lbl_birthdate As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_class_of_joining As System.Windows.Forms.Label
    Friend WithEvents rdb_male As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents cmb_session As System.Windows.Forms.TextBox
End Class
