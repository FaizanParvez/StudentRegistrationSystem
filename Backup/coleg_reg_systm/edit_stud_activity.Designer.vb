<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class edit_stud_activity
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(edit_stud_activity))
        Me.lbl_admission_no = New System.Windows.Forms.Label
        Me.cmb_joining_class = New System.Windows.Forms.ComboBox
        Me.btn_exit = New System.Windows.Forms.Button
        Me.lbl_class_of_joining = New System.Windows.Forms.Label
        Me.btn_update = New System.Windows.Forms.Button
        Me.txt_admission_no = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmb_quiz = New System.Windows.Forms.ComboBox
        Me.cmb_debate = New System.Windows.Forms.ComboBox
        Me.cmb_swimming = New System.Windows.Forms.ComboBox
        Me.cmb_Athletics_Games = New System.Windows.Forms.ComboBox
        Me.cmb_camps_mount = New System.Windows.Forms.ComboBox
        Me.cmb_cross_country = New System.Windows.Forms.ComboBox
        Me.lbl_quiz = New System.Windows.Forms.Label
        Me.lbl_swimming = New System.Windows.Forms.Label
        Me.lbl_debate = New System.Windows.Forms.Label
        Me.lbl_Athletics_Games = New System.Windows.Forms.Label
        Me.lbl_camps_mount = New System.Windows.Forms.Label
        Me.lbl_cross_country = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmb_session = New System.Windows.Forms.TextBox
        Me.lbl_student_last_name = New System.Windows.Forms.Label
        Me.txt_student_last_name = New System.Windows.Forms.TextBox
        Me.txt_student_ist_name = New System.Windows.Forms.TextBox
        Me.lbl_student_ist_name = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbl_address = New System.Windows.Forms.Label
        Me.txt_address = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txt_fathers_name = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lbl_heading_admission_form = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_admission_no
        '
        Me.lbl_admission_no.AutoSize = True
        Me.lbl_admission_no.BackColor = System.Drawing.Color.Transparent
        Me.lbl_admission_no.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_admission_no.ForeColor = System.Drawing.Color.Black
        Me.lbl_admission_no.Location = New System.Drawing.Point(6, 18)
        Me.lbl_admission_no.Name = "lbl_admission_no"
        Me.lbl_admission_no.Size = New System.Drawing.Size(85, 15)
        Me.lbl_admission_no.TabIndex = 189
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
        Me.cmb_joining_class.Location = New System.Drawing.Point(108, 44)
        Me.cmb_joining_class.Name = "cmb_joining_class"
        Me.cmb_joining_class.Size = New System.Drawing.Size(126, 23)
        Me.cmb_joining_class.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.cmb_joining_class, "Select the class")
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_exit.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.ForeColor = System.Drawing.Color.Black
        Me.btn_exit.Location = New System.Drawing.Point(458, 389)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(86, 27)
        Me.btn_exit.TabIndex = 16
        Me.btn_exit.Text = "&Exit"
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'lbl_class_of_joining
        '
        Me.lbl_class_of_joining.AutoSize = True
        Me.lbl_class_of_joining.BackColor = System.Drawing.Color.Transparent
        Me.lbl_class_of_joining.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_class_of_joining.ForeColor = System.Drawing.Color.Black
        Me.lbl_class_of_joining.Location = New System.Drawing.Point(6, 47)
        Me.lbl_class_of_joining.Name = "lbl_class_of_joining"
        Me.lbl_class_of_joining.Size = New System.Drawing.Size(33, 15)
        Me.lbl_class_of_joining.TabIndex = 188
        Me.lbl_class_of_joining.Text = "Class"
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_update.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.Color.Black
        Me.btn_update.Location = New System.Drawing.Point(367, 389)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(86, 27)
        Me.btn_update.TabIndex = 15
        Me.btn_update.Text = "&Update"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'txt_admission_no
        '
        Me.txt_admission_no.BackColor = System.Drawing.SystemColors.Info
        Me.txt_admission_no.Enabled = False
        Me.txt_admission_no.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_admission_no.ForeColor = System.Drawing.Color.Black
        Me.txt_admission_no.Location = New System.Drawing.Point(108, 15)
        Me.txt_admission_no.Name = "txt_admission_no"
        Me.txt_admission_no.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_admission_no.Size = New System.Drawing.Size(55, 23)
        Me.txt_admission_no.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmb_quiz)
        Me.GroupBox2.Controls.Add(Me.cmb_debate)
        Me.GroupBox2.Controls.Add(Me.cmb_swimming)
        Me.GroupBox2.Controls.Add(Me.cmb_Athletics_Games)
        Me.GroupBox2.Controls.Add(Me.cmb_camps_mount)
        Me.GroupBox2.Controls.Add(Me.cmb_cross_country)
        Me.GroupBox2.Controls.Add(Me.lbl_quiz)
        Me.GroupBox2.Controls.Add(Me.lbl_swimming)
        Me.GroupBox2.Controls.Add(Me.lbl_debate)
        Me.GroupBox2.Controls.Add(Me.lbl_Athletics_Games)
        Me.GroupBox2.Controls.Add(Me.lbl_camps_mount)
        Me.GroupBox2.Controls.Add(Me.lbl_cross_country)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(3, 277)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(549, 106)
        Me.GroupBox2.TabIndex = 1015
        Me.GroupBox2.TabStop = False
        '
        'cmb_quiz
        '
        Me.cmb_quiz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_quiz.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_quiz.ForeColor = System.Drawing.Color.Black
        Me.cmb_quiz.FormattingEnabled = True
        Me.cmb_quiz.Items.AddRange(New Object() {"Yes", "No"})
        Me.cmb_quiz.Location = New System.Drawing.Point(447, 76)
        Me.cmb_quiz.Name = "cmb_quiz"
        Me.cmb_quiz.Size = New System.Drawing.Size(87, 23)
        Me.cmb_quiz.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.cmb_quiz, "Select the activity")
        '
        'cmb_debate
        '
        Me.cmb_debate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_debate.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_debate.ForeColor = System.Drawing.Color.Black
        Me.cmb_debate.FormattingEnabled = True
        Me.cmb_debate.Items.AddRange(New Object() {"Yes", "No"})
        Me.cmb_debate.Location = New System.Drawing.Point(447, 18)
        Me.cmb_debate.Name = "cmb_debate"
        Me.cmb_debate.Size = New System.Drawing.Size(87, 23)
        Me.cmb_debate.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.cmb_debate, "Select the activity")
        '
        'cmb_swimming
        '
        Me.cmb_swimming.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_swimming.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_swimming.ForeColor = System.Drawing.Color.Black
        Me.cmb_swimming.FormattingEnabled = True
        Me.cmb_swimming.Items.AddRange(New Object() {"Yes", "No"})
        Me.cmb_swimming.Location = New System.Drawing.Point(447, 47)
        Me.cmb_swimming.Name = "cmb_swimming"
        Me.cmb_swimming.Size = New System.Drawing.Size(87, 23)
        Me.cmb_swimming.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.cmb_swimming, "Select the activity")
        '
        'cmb_Athletics_Games
        '
        Me.cmb_Athletics_Games.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Athletics_Games.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Athletics_Games.ForeColor = System.Drawing.Color.Black
        Me.cmb_Athletics_Games.FormattingEnabled = True
        Me.cmb_Athletics_Games.Items.AddRange(New Object() {"Yes", "No"})
        Me.cmb_Athletics_Games.Location = New System.Drawing.Point(172, 47)
        Me.cmb_Athletics_Games.Name = "cmb_Athletics_Games"
        Me.cmb_Athletics_Games.Size = New System.Drawing.Size(87, 23)
        Me.cmb_Athletics_Games.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.cmb_Athletics_Games, "Select the activity")
        '
        'cmb_camps_mount
        '
        Me.cmb_camps_mount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_camps_mount.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_camps_mount.ForeColor = System.Drawing.Color.Black
        Me.cmb_camps_mount.FormattingEnabled = True
        Me.cmb_camps_mount.Items.AddRange(New Object() {"Yes", "No"})
        Me.cmb_camps_mount.Location = New System.Drawing.Point(172, 76)
        Me.cmb_camps_mount.Name = "cmb_camps_mount"
        Me.cmb_camps_mount.Size = New System.Drawing.Size(87, 23)
        Me.cmb_camps_mount.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.cmb_camps_mount, "Select the activity")
        '
        'cmb_cross_country
        '
        Me.cmb_cross_country.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_cross_country.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_cross_country.ForeColor = System.Drawing.Color.Black
        Me.cmb_cross_country.FormattingEnabled = True
        Me.cmb_cross_country.Items.AddRange(New Object() {"Yes", "No"})
        Me.cmb_cross_country.Location = New System.Drawing.Point(172, 18)
        Me.cmb_cross_country.Name = "cmb_cross_country"
        Me.cmb_cross_country.Size = New System.Drawing.Size(87, 23)
        Me.cmb_cross_country.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.cmb_cross_country, "Select the activity")
        '
        'lbl_quiz
        '
        Me.lbl_quiz.AutoSize = True
        Me.lbl_quiz.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_quiz.ForeColor = System.Drawing.Color.Black
        Me.lbl_quiz.Location = New System.Drawing.Point(360, 79)
        Me.lbl_quiz.Name = "lbl_quiz"
        Me.lbl_quiz.Size = New System.Drawing.Size(31, 15)
        Me.lbl_quiz.TabIndex = 1013
        Me.lbl_quiz.Text = "Quiz"
        '
        'lbl_swimming
        '
        Me.lbl_swimming.AutoSize = True
        Me.lbl_swimming.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_swimming.ForeColor = System.Drawing.Color.Black
        Me.lbl_swimming.Location = New System.Drawing.Point(360, 50)
        Me.lbl_swimming.Name = "lbl_swimming"
        Me.lbl_swimming.Size = New System.Drawing.Size(64, 15)
        Me.lbl_swimming.TabIndex = 1012
        Me.lbl_swimming.Text = "Swimming"
        '
        'lbl_debate
        '
        Me.lbl_debate.AutoSize = True
        Me.lbl_debate.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_debate.ForeColor = System.Drawing.Color.Black
        Me.lbl_debate.Location = New System.Drawing.Point(360, 21)
        Me.lbl_debate.Name = "lbl_debate"
        Me.lbl_debate.Size = New System.Drawing.Size(47, 15)
        Me.lbl_debate.TabIndex = 1011
        Me.lbl_debate.Text = "Debate"
        '
        'lbl_Athletics_Games
        '
        Me.lbl_Athletics_Games.AutoSize = True
        Me.lbl_Athletics_Games.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Athletics_Games.ForeColor = System.Drawing.Color.Black
        Me.lbl_Athletics_Games.Location = New System.Drawing.Point(6, 50)
        Me.lbl_Athletics_Games.Name = "lbl_Athletics_Games"
        Me.lbl_Athletics_Games.Size = New System.Drawing.Size(118, 15)
        Me.lbl_Athletics_Games.TabIndex = 1009
        Me.lbl_Athletics_Games.Text = "Athletics and Games"
        '
        'lbl_camps_mount
        '
        Me.lbl_camps_mount.AutoSize = True
        Me.lbl_camps_mount.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_camps_mount.ForeColor = System.Drawing.Color.Black
        Me.lbl_camps_mount.Location = New System.Drawing.Point(6, 79)
        Me.lbl_camps_mount.Name = "lbl_camps_mount"
        Me.lbl_camps_mount.Size = New System.Drawing.Size(157, 15)
        Me.lbl_camps_mount.TabIndex = 1010
        Me.lbl_camps_mount.Text = "Camps and Mountaineering"
        '
        'lbl_cross_country
        '
        Me.lbl_cross_country.AutoSize = True
        Me.lbl_cross_country.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cross_country.ForeColor = System.Drawing.Color.Black
        Me.lbl_cross_country.Location = New System.Drawing.Point(6, 21)
        Me.lbl_cross_country.Name = "lbl_cross_country"
        Me.lbl_cross_country.Size = New System.Drawing.Size(83, 15)
        Me.lbl_cross_country.TabIndex = 0
        Me.lbl_cross_country.Text = "Cross Country"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmb_session)
        Me.GroupBox1.Controls.Add(Me.lbl_student_last_name)
        Me.GroupBox1.Controls.Add(Me.txt_student_last_name)
        Me.GroupBox1.Controls.Add(Me.txt_student_ist_name)
        Me.GroupBox1.Controls.Add(Me.lbl_student_ist_name)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lbl_address)
        Me.GroupBox1.Controls.Add(Me.txt_address)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txt_fathers_name)
        Me.GroupBox1.Controls.Add(Me.txt_admission_no)
        Me.GroupBox1.Controls.Add(Me.lbl_admission_no)
        Me.GroupBox1.Controls.Add(Me.cmb_joining_class)
        Me.GroupBox1.Controls.Add(Me.lbl_class_of_joining)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(343, 216)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'cmb_session
        '
        Me.cmb_session.BackColor = System.Drawing.SystemColors.Info
        Me.cmb_session.Enabled = False
        Me.cmb_session.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_session.Location = New System.Drawing.Point(108, 189)
        Me.cmb_session.Name = "cmb_session"
        Me.cmb_session.ReadOnly = True
        Me.cmb_session.Size = New System.Drawing.Size(126, 23)
        Me.cmb_session.TabIndex = 1022
        '
        'lbl_student_last_name
        '
        Me.lbl_student_last_name.AutoSize = True
        Me.lbl_student_last_name.BackColor = System.Drawing.Color.Transparent
        Me.lbl_student_last_name.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_student_last_name.ForeColor = System.Drawing.Color.Black
        Me.lbl_student_last_name.Location = New System.Drawing.Point(6, 105)
        Me.lbl_student_last_name.Name = "lbl_student_last_name"
        Me.lbl_student_last_name.Size = New System.Drawing.Size(65, 15)
        Me.lbl_student_last_name.TabIndex = 1011
        Me.lbl_student_last_name.Text = "Last Name"
        '
        'txt_student_last_name
        '
        Me.txt_student_last_name.BackColor = System.Drawing.SystemColors.Info
        Me.txt_student_last_name.Enabled = False
        Me.txt_student_last_name.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_student_last_name.ForeColor = System.Drawing.Color.Black
        Me.txt_student_last_name.Location = New System.Drawing.Point(108, 102)
        Me.txt_student_last_name.Name = "txt_student_last_name"
        Me.txt_student_last_name.Size = New System.Drawing.Size(229, 23)
        Me.txt_student_last_name.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.txt_student_last_name, "Enter the last name")
        '
        'txt_student_ist_name
        '
        Me.txt_student_ist_name.BackColor = System.Drawing.SystemColors.Info
        Me.txt_student_ist_name.Enabled = False
        Me.txt_student_ist_name.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_student_ist_name.ForeColor = System.Drawing.Color.Black
        Me.txt_student_ist_name.Location = New System.Drawing.Point(108, 73)
        Me.txt_student_ist_name.Name = "txt_student_ist_name"
        Me.txt_student_ist_name.Size = New System.Drawing.Size(228, 23)
        Me.txt_student_ist_name.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.txt_student_ist_name, "Enter the ist name")
        '
        'lbl_student_ist_name
        '
        Me.lbl_student_ist_name.AutoSize = True
        Me.lbl_student_ist_name.BackColor = System.Drawing.Color.Transparent
        Me.lbl_student_ist_name.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_student_ist_name.ForeColor = System.Drawing.Color.Black
        Me.lbl_student_ist_name.Location = New System.Drawing.Point(6, 76)
        Me.lbl_student_ist_name.Name = "lbl_student_ist_name"
        Me.lbl_student_ist_name.Size = New System.Drawing.Size(54, 15)
        Me.lbl_student_ist_name.TabIndex = 1010
        Me.lbl_student_ist_name.Text = "Ist name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 192)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 15)
        Me.Label1.TabIndex = 1006
        Me.Label1.Text = "Session"
        '
        'lbl_address
        '
        Me.lbl_address.AutoSize = True
        Me.lbl_address.BackColor = System.Drawing.Color.Transparent
        Me.lbl_address.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_address.ForeColor = System.Drawing.Color.Black
        Me.lbl_address.Location = New System.Drawing.Point(6, 163)
        Me.lbl_address.Name = "lbl_address"
        Me.lbl_address.Size = New System.Drawing.Size(51, 15)
        Me.lbl_address.TabIndex = 1005
        Me.lbl_address.Text = "Address"
        '
        'txt_address
        '
        Me.txt_address.BackColor = System.Drawing.SystemColors.Info
        Me.txt_address.Enabled = False
        Me.txt_address.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_address.ForeColor = System.Drawing.Color.Black
        Me.txt_address.Location = New System.Drawing.Point(108, 160)
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(228, 23)
        Me.txt_address.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.txt_address, "Enter the adress")
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(6, 134)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 15)
        Me.Label11.TabIndex = 193
        Me.Label11.Text = "Father's Name"
        '
        'txt_fathers_name
        '
        Me.txt_fathers_name.BackColor = System.Drawing.SystemColors.Info
        Me.txt_fathers_name.Enabled = False
        Me.txt_fathers_name.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fathers_name.ForeColor = System.Drawing.Color.Black
        Me.txt_fathers_name.Location = New System.Drawing.Point(108, 131)
        Me.txt_fathers_name.Name = "txt_fathers_name"
        Me.txt_fathers_name.Size = New System.Drawing.Size(228, 23)
        Me.txt_fathers_name.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.txt_fathers_name, "Enter the father's name")
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(375, 82)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 131)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1018
        Me.PictureBox1.TabStop = False
        '
        'lbl_heading_admission_form
        '
        Me.lbl_heading_admission_form.AutoSize = True
        Me.lbl_heading_admission_form.BackColor = System.Drawing.Color.Transparent
        Me.lbl_heading_admission_form.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_heading_admission_form.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_heading_admission_form.Location = New System.Drawing.Point(68, -1)
        Me.lbl_heading_admission_form.Name = "lbl_heading_admission_form"
        Me.lbl_heading_admission_form.Size = New System.Drawing.Size(435, 57)
        Me.lbl_heading_admission_form.TabIndex = 1021
        Me.lbl_heading_admission_form.Text = "ACTIVITY DETAILS"
        Me.lbl_heading_admission_form.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'edit_stud_activity
        '
        Me.AcceptButton = Me.btn_update
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.CancelButton = Me.btn_exit
        Me.ClientSize = New System.Drawing.Size(557, 422)
        Me.Controls.Add(Me.lbl_heading_admission_form)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "edit_stud_activity"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Regestration System "
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_admission_no As System.Windows.Forms.Label
    Friend WithEvents cmb_joining_class As System.Windows.Forms.ComboBox
    Friend WithEvents btn_exit As System.Windows.Forms.Button
    Friend WithEvents lbl_class_of_joining As System.Windows.Forms.Label
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents txt_admission_no As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_quiz As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_debate As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_swimming As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_Athletics_Games As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_camps_mount As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_cross_country As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_quiz As System.Windows.Forms.Label
    Friend WithEvents lbl_swimming As System.Windows.Forms.Label
    Friend WithEvents lbl_debate As System.Windows.Forms.Label
    Friend WithEvents lbl_Athletics_Games As System.Windows.Forms.Label
    Friend WithEvents lbl_camps_mount As System.Windows.Forms.Label
    Friend WithEvents lbl_cross_country As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_address As System.Windows.Forms.Label
    Friend WithEvents txt_address As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_fathers_name As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_student_last_name As System.Windows.Forms.Label
    Friend WithEvents txt_student_last_name As System.Windows.Forms.TextBox
    Friend WithEvents txt_student_ist_name As System.Windows.Forms.TextBox
    Friend WithEvents lbl_student_ist_name As System.Windows.Forms.Label
    Friend WithEvents lbl_heading_admission_form As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents cmb_session As System.Windows.Forms.TextBox
End Class
