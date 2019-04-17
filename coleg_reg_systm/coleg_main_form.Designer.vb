<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class coleg_main_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(coleg_main_form))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AdmissionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Bca2ndYearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Bca3rdYearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudActivitiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Bca2ndYearToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Bca3rdYearToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepartmentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudDetailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Bca2ndYearToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Bca3ndYearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudActivityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Bca2ndYearToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Bca3rdYearToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudFeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Bca2ndYearToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Bca3rdYearToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudLibraryStatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Bca2ndYearToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Bca3ndYearToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudLibraryToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Bca2ndYearToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Bca3rdYearToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudFeeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Bca2ndYearToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Bca3rdYearToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserSettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Thistle
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 401)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(967, 47)
        Me.Panel1.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(181, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(565, 43)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "STUDENT REGISTRATION SYSTEM"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdmissionsToolStripMenuItem, Me.DepartmentsToolStripMenuItem, Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.UserSettingsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(967, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdmissionsToolStripMenuItem
        '
        Me.AdmissionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentToolStripMenuItem, Me.StudActivitiesToolStripMenuItem})
        Me.AdmissionsToolStripMenuItem.Name = "AdmissionsToolStripMenuItem"
        Me.AdmissionsToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.AdmissionsToolStripMenuItem.Text = "&Add"
        '
        'StudentToolStripMenuItem
        '
        Me.StudentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Bca2ndYearToolStripMenuItem, Me.Bca3rdYearToolStripMenuItem})
        Me.StudentToolStripMenuItem.Name = "StudentToolStripMenuItem"
        Me.StudentToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.StudentToolStripMenuItem.Text = "Student Admission"
        '
        'Bca2ndYearToolStripMenuItem
        '
        Me.Bca2ndYearToolStripMenuItem.Name = "Bca2ndYearToolStripMenuItem"
        Me.Bca2ndYearToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.Bca2ndYearToolStripMenuItem.Text = "Bca 2nd Year"
        '
        'Bca3rdYearToolStripMenuItem
        '
        Me.Bca3rdYearToolStripMenuItem.Name = "Bca3rdYearToolStripMenuItem"
        Me.Bca3rdYearToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.Bca3rdYearToolStripMenuItem.Text = "Bca 3rd Year"
        '
        'StudActivitiesToolStripMenuItem
        '
        Me.StudActivitiesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Bca2ndYearToolStripMenuItem3, Me.Bca3rdYearToolStripMenuItem1})
        Me.StudActivitiesToolStripMenuItem.Name = "StudActivitiesToolStripMenuItem"
        Me.StudActivitiesToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.StudActivitiesToolStripMenuItem.Text = "Stud. Activities"
        '
        'Bca2ndYearToolStripMenuItem3
        '
        Me.Bca2ndYearToolStripMenuItem3.Name = "Bca2ndYearToolStripMenuItem3"
        Me.Bca2ndYearToolStripMenuItem3.Size = New System.Drawing.Size(142, 22)
        Me.Bca2ndYearToolStripMenuItem3.Text = "Bca 2nd Year"
        '
        'Bca3rdYearToolStripMenuItem1
        '
        Me.Bca3rdYearToolStripMenuItem1.Name = "Bca3rdYearToolStripMenuItem1"
        Me.Bca3rdYearToolStripMenuItem1.Size = New System.Drawing.Size(142, 22)
        Me.Bca3rdYearToolStripMenuItem1.Text = "Bca 3rd Year"
        '
        'DepartmentsToolStripMenuItem
        '
        Me.DepartmentsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudDetailToolStripMenuItem, Me.StudActivityToolStripMenuItem, Me.StudFeeToolStripMenuItem, Me.StudLibraryStatusToolStripMenuItem})
        Me.DepartmentsToolStripMenuItem.Name = "DepartmentsToolStripMenuItem"
        Me.DepartmentsToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.DepartmentsToolStripMenuItem.Text = "&View"
        '
        'StudDetailToolStripMenuItem
        '
        Me.StudDetailToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Bca2ndYearToolStripMenuItem1, Me.Bca3ndYearToolStripMenuItem})
        Me.StudDetailToolStripMenuItem.Name = "StudDetailToolStripMenuItem"
        Me.StudDetailToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.StudDetailToolStripMenuItem.Text = "Stud. Detail"
        '
        'Bca2ndYearToolStripMenuItem1
        '
        Me.Bca2ndYearToolStripMenuItem1.Name = "Bca2ndYearToolStripMenuItem1"
        Me.Bca2ndYearToolStripMenuItem1.Size = New System.Drawing.Size(142, 22)
        Me.Bca2ndYearToolStripMenuItem1.Text = "Bca 2nd Year"
        '
        'Bca3ndYearToolStripMenuItem
        '
        Me.Bca3ndYearToolStripMenuItem.Name = "Bca3ndYearToolStripMenuItem"
        Me.Bca3ndYearToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.Bca3ndYearToolStripMenuItem.Text = "Bca 3rd Year"
        '
        'StudActivityToolStripMenuItem
        '
        Me.StudActivityToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Bca2ndYearToolStripMenuItem4, Me.Bca3rdYearToolStripMenuItem2})
        Me.StudActivityToolStripMenuItem.Name = "StudActivityToolStripMenuItem"
        Me.StudActivityToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.StudActivityToolStripMenuItem.Text = "Stud. Activity"
        '
        'Bca2ndYearToolStripMenuItem4
        '
        Me.Bca2ndYearToolStripMenuItem4.Name = "Bca2ndYearToolStripMenuItem4"
        Me.Bca2ndYearToolStripMenuItem4.Size = New System.Drawing.Size(142, 22)
        Me.Bca2ndYearToolStripMenuItem4.Text = "Bca 2nd Year"
        '
        'Bca3rdYearToolStripMenuItem2
        '
        Me.Bca3rdYearToolStripMenuItem2.Name = "Bca3rdYearToolStripMenuItem2"
        Me.Bca3rdYearToolStripMenuItem2.Size = New System.Drawing.Size(142, 22)
        Me.Bca3rdYearToolStripMenuItem2.Text = "Bca 3rd Year"
        '
        'StudFeeToolStripMenuItem
        '
        Me.StudFeeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Bca2ndYearToolStripMenuItem6, Me.Bca3rdYearToolStripMenuItem4})
        Me.StudFeeToolStripMenuItem.Name = "StudFeeToolStripMenuItem"
        Me.StudFeeToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.StudFeeToolStripMenuItem.Text = "Stud. Fee"
        '
        'Bca2ndYearToolStripMenuItem6
        '
        Me.Bca2ndYearToolStripMenuItem6.Name = "Bca2ndYearToolStripMenuItem6"
        Me.Bca2ndYearToolStripMenuItem6.Size = New System.Drawing.Size(142, 22)
        Me.Bca2ndYearToolStripMenuItem6.Text = "Bca 2nd Year"
        '
        'Bca3rdYearToolStripMenuItem4
        '
        Me.Bca3rdYearToolStripMenuItem4.Name = "Bca3rdYearToolStripMenuItem4"
        Me.Bca3rdYearToolStripMenuItem4.Size = New System.Drawing.Size(142, 22)
        Me.Bca3rdYearToolStripMenuItem4.Text = "Bca 3rd Year"
        '
        'StudLibraryStatusToolStripMenuItem
        '
        Me.StudLibraryStatusToolStripMenuItem.Name = "StudLibraryStatusToolStripMenuItem"
        Me.StudLibraryStatusToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.StudLibraryStatusToolStripMenuItem.Text = "Stud. library Status"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudDetailsToolStripMenuItem, Me.StudLibraryToolStripMenuItem1, Me.StudFeeToolStripMenuItem1})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'StudDetailsToolStripMenuItem
        '
        Me.StudDetailsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Bca2ndYearToolStripMenuItem2, Me.Bca3ndYearToolStripMenuItem1})
        Me.StudDetailsToolStripMenuItem.Name = "StudDetailsToolStripMenuItem"
        Me.StudDetailsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.StudDetailsToolStripMenuItem.Text = "Stud. Details"
        '
        'Bca2ndYearToolStripMenuItem2
        '
        Me.Bca2ndYearToolStripMenuItem2.Name = "Bca2ndYearToolStripMenuItem2"
        Me.Bca2ndYearToolStripMenuItem2.Size = New System.Drawing.Size(142, 22)
        Me.Bca2ndYearToolStripMenuItem2.Text = "Bca 2nd Year"
        '
        'Bca3ndYearToolStripMenuItem1
        '
        Me.Bca3ndYearToolStripMenuItem1.Name = "Bca3ndYearToolStripMenuItem1"
        Me.Bca3ndYearToolStripMenuItem1.Size = New System.Drawing.Size(142, 22)
        Me.Bca3ndYearToolStripMenuItem1.Text = "Bca 3rd Year"
        '
        'StudLibraryToolStripMenuItem1
        '
        Me.StudLibraryToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Bca2ndYearToolStripMenuItem5, Me.Bca3rdYearToolStripMenuItem3})
        Me.StudLibraryToolStripMenuItem1.Name = "StudLibraryToolStripMenuItem1"
        Me.StudLibraryToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.StudLibraryToolStripMenuItem1.Text = "Stud. Activities"
        '
        'Bca2ndYearToolStripMenuItem5
        '
        Me.Bca2ndYearToolStripMenuItem5.Name = "Bca2ndYearToolStripMenuItem5"
        Me.Bca2ndYearToolStripMenuItem5.Size = New System.Drawing.Size(142, 22)
        Me.Bca2ndYearToolStripMenuItem5.Text = "Bca 2nd Year"
        '
        'Bca3rdYearToolStripMenuItem3
        '
        Me.Bca3rdYearToolStripMenuItem3.Name = "Bca3rdYearToolStripMenuItem3"
        Me.Bca3rdYearToolStripMenuItem3.Size = New System.Drawing.Size(142, 22)
        Me.Bca3rdYearToolStripMenuItem3.Text = "Bca 3rd Year"
        '
        'StudFeeToolStripMenuItem1
        '
        Me.StudFeeToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Bca2ndYearToolStripMenuItem7, Me.Bca3rdYearToolStripMenuItem5})
        Me.StudFeeToolStripMenuItem1.Name = "StudFeeToolStripMenuItem1"
        Me.StudFeeToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.StudFeeToolStripMenuItem1.Text = "Stud. Fee"
        '
        'Bca2ndYearToolStripMenuItem7
        '
        Me.Bca2ndYearToolStripMenuItem7.Name = "Bca2ndYearToolStripMenuItem7"
        Me.Bca2ndYearToolStripMenuItem7.Size = New System.Drawing.Size(142, 22)
        Me.Bca2ndYearToolStripMenuItem7.Text = "Bca 2nd Year"
        '
        'Bca3rdYearToolStripMenuItem5
        '
        Me.Bca3rdYearToolStripMenuItem5.Name = "Bca3rdYearToolStripMenuItem5"
        Me.Bca3rdYearToolStripMenuItem5.Size = New System.Drawing.Size(142, 22)
        Me.Bca3rdYearToolStripMenuItem5.Text = "Bca 3rd Year"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentToolStripMenuItem1})
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.DeleteToolStripMenuItem.Text = "&Delete"
        '
        'StudentToolStripMenuItem1
        '
        Me.StudentToolStripMenuItem1.Name = "StudentToolStripMenuItem1"
        Me.StudentToolStripMenuItem1.Size = New System.Drawing.Size(115, 22)
        Me.StudentToolStripMenuItem1.Text = "Student"
        '
        'UserSettingsToolStripMenuItem
        '
        Me.UserSettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserSettingToolStripMenuItem})
        Me.UserSettingsToolStripMenuItem.Name = "UserSettingsToolStripMenuItem"
        Me.UserSettingsToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.UserSettingsToolStripMenuItem.Text = "&Other"
        '
        'UserSettingToolStripMenuItem
        '
        Me.UserSettingToolStripMenuItem.Name = "UserSettingToolStripMenuItem"
        Me.UserSettingToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.UserSettingToolStripMenuItem.Text = "User Settings"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(770, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 18)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "1"
        '
        'Timer2
        '
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(866, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 18)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "3"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.hello
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(967, 377)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'coleg_main_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 448)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "coleg_main_form"
        Me.Text = "Student Registration System "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AdmissionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DepartmentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserSettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudActivitiesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudLibraryToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudentToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserSettingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudDetailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents StudActivityToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudFeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudFeeToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Bca2ndYearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Bca3rdYearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Bca2ndYearToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Bca3ndYearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Bca2ndYearToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Bca3ndYearToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudLibraryStatusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Bca2ndYearToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Bca3rdYearToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Bca2ndYearToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Bca3rdYearToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Bca2ndYearToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Bca3rdYearToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Bca2ndYearToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Bca3rdYearToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Bca2ndYearToolStripMenuItem7 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Bca3rdYearToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
End Class
