Imports System.Data
Imports System.Data.SqlClient
Public Class edit_stud_2nd_yr_detail

    Dim flag As Boolean = False

    Dim CN As New SqlConnection("server=AMIRRESHI-PC\SQLSERVER05;initial catalog=Coleg_RS;integrated security=true")

    Private Sub edit_stud_2nd_yr_detail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cmb_joining_class.SelectedIndex = 1
        txt_exam_passed.Text = "IST YEAR"

        Dim dt As Integer
        dt = Val(Now.Year)
        cmb_session.Text = dt.ToString + "-" + (dt + 1).ToString

        Dim CMD As New SqlCommand("select admission_no,joining_class , ist_name , last_name ,fathers_name , mothers_name, d_o_b, cell_no , exam_passed,session ,sex, address ,state ,city,pin_no , email_id,picture from second_year where admission_no=@txt_admission_no", CN)

        txt_admission_no.Text = coleg_main_form.edit_stud_2nd_yr_num

        CMD.Parameters.AddWithValue("@txt_admission_no", txt_admission_no.Text)

        Try
            CN.Open()
            Dim DR As SqlDataReader
            DR = CMD.ExecuteReader
            If DR.Read = True Then
                txt_admission_no.Text = DR.Item("admission_no").ToString
                cmb_joining_class.Text = DR.Item("joining_class").ToString
                txt_student_ist_name.Text = DR.Item("ist_name").ToString
                txt_student_last_name.Text = DR.Item("last_name").ToString
                txt_fathers_name.Text = DR.Item("fathers_name").ToString
                txt_mothers_name.Text = DR.Item("mothers_name").ToString
                DateTimePicker1.Value = CDate(DR.Item("d_o_b"))
                msk_cell_no.Text = DR.Item("cell_no").ToString
                txt_exam_passed.Text = DR.Item("exam_passed").ToString
                cmb_session.Text = DR.Item("session").ToString
                txt_address.Text = DR.Item("address").ToString
                cmb_state.Text = DR.Item("state").ToString
                cmb_city.Text = DR.Item("city").ToString
                txt_pin_no.Text = DR.Item("pin_no").ToString
                msk_email.Text = DR.Item("email_id").ToString
                PictureBox1.ImageLocation = DR.Item("picture").ToString

                If DR.Item("sex").ToString = "Male" Then
                    rdb_male.Checked = True
                Else
                    rdb_female.Checked = True
                End If

                If CN.State = ConnectionState.Open Then CN.Close()

            Else
                MessageBox.Show("Student yet not enrolled to 2nd year", "UPDATE 2ND YEAR ADMISSION...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
                If CN.State = ConnectionState.Open Then CN.Close()
            End If
            CN.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try


    End Sub

    '******************** CLEARALL FUNCTION ****************

    Public Sub clear_all()
        cmb_joining_class.SelectedIndex = 1
        rdb_male.Checked = True
        txt_exam_passed.Text = "IST YEAR"
        txt_student_ist_name.Text = ""
        txt_student_last_name.Text = ""
        txt_fathers_name.Text = ""
        txt_mothers_name.Text = ""
        msk_cell_no.Text = ""
        Dim dt As Integer
        dt = Val(Now.Year)
        cmb_session.Text = dt.ToString + "-" + (dt + 1).ToString
        txt_address.Text = ""
        cmb_state.Text = "Select"
        cmb_city.Text = "Select"
        txt_pin_no.Text = ""
        msk_email.Text = ""
        PictureBox1.ImageLocation = ""
        cmb_joining_class.Focus()

    End Sub

    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        If flag = False Then
            Dim CMD As New SqlCommand("update second_year set admission_no=    @msk_admission_no, joining_class = @cmb_joining_class ,ist_name=@txt_student_ist_name,last_name=@txt_student_last_name ,fathers_name=@txt_fathers_name , mothers_name=@txt_mothers_name,d_o_b=@d_o_b, cell_no=@msk_cell_no , exam_passed=@cmb_exam_passed,session=@session , address= @txt_address ,sex=@sex,state=@txt_state ,city= @txt_city,pin_no=@pin_no , email_id=@txt_email where admission_no=@msk_admission_no", CN)
            CMD.Parameters.AddWithValue("@msk_admission_no", txt_admission_no.Text)
            CMD.Parameters.AddWithValue("@cmb_joining_class", cmb_joining_class.Text)
            CMD.Parameters.AddWithValue("@txt_student_ist_name", txt_student_ist_name.Text)
            CMD.Parameters.AddWithValue("@txt_student_last_name", txt_student_last_name.Text)
            CMD.Parameters.AddWithValue("@txt_fathers_name", txt_fathers_name.Text)
            CMD.Parameters.AddWithValue("@txt_mothers_name", txt_mothers_name.Text)
            CMD.Parameters.AddWithValue("@d_o_b", DateTimePicker1.Value.Date)
            CMD.Parameters.AddWithValue("@msk_cell_no", msk_cell_no.Text)
            CMD.Parameters.AddWithValue("@cmb_exam_passed", txt_exam_passed.Text)
            CMD.Parameters.AddWithValue("@session", cmb_session.Text)
            CMD.Parameters.AddWithValue("@pin_no", txt_pin_no.Text)
            CMD.Parameters.AddWithValue("@txt_address", txt_address.Text)
            CMD.Parameters.AddWithValue("@txt_state", cmb_state.Text)
            CMD.Parameters.AddWithValue("@txt_city", cmb_city.Text)
            CMD.Parameters.AddWithValue("@txt_email", msk_email.Text)

            If rdb_male.Checked = True Then
                CMD.Parameters.AddWithValue("@sex", rdb_male.Text)

            Else
                CMD.Parameters.AddWithValue("@sex", rdb_female.Text)

            End If

            If txt_admission_no.Text <> "" And cmb_joining_class.Text <> "" And txt_student_ist_name.Text <> "" And txt_student_last_name.Text <> "" And txt_fathers_name.Text <> "" And txt_mothers_name.Text <> "" And txt_exam_passed.Text <> "" And cmb_session.Text <> "" And txt_address.Text <> "" And cmb_state.Text <> "" And cmb_city.Text <> "" And txt_pin_no.Text <> "" And (rdb_male.Checked = True Or rdb_female.Checked = True) Then

                Try
                    CN.Open()
                    CMD.ExecuteNonQuery()
                    If CN.State = ConnectionState.Open Then CN.Close()
                    MessageBox.Show("Student information updated sucessfully", "STUDENT UPDATED...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MessageBox.Show("Enter all details correctly", "ERROR...", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            CN.Close()
        Else
            Dim CMD As New SqlCommand("update second_year set admission_no=    @msk_admission_no, joining_class = @cmb_joining_class ,ist_name=@txt_student_ist_name,last_name=@txt_student_last_name ,fathers_name=@txt_fathers_name , mothers_name=@txt_mothers_name,d_o_b=@d_o_b, cell_no=@msk_cell_no , exam_passed=@cmb_exam_passed,session=@session , address= @txt_address ,sex=@sex,state=@txt_state ,city= @txt_city,pin_no=@pin_no , email_id=@txt_email,picture = @picture where admission_no=@msk_admission_no", CN)
            CMD.Parameters.AddWithValue("@msk_admission_no", txt_admission_no.Text)
            CMD.Parameters.AddWithValue("@cmb_joining_class", cmb_joining_class.Text)
            CMD.Parameters.AddWithValue("@txt_student_ist_name", txt_student_ist_name.Text)
            CMD.Parameters.AddWithValue("@txt_student_last_name", txt_student_last_name.Text)
            CMD.Parameters.AddWithValue("@txt_fathers_name", txt_fathers_name.Text)
            CMD.Parameters.AddWithValue("@txt_mothers_name", txt_mothers_name.Text)
            CMD.Parameters.AddWithValue("@d_o_b", DateTimePicker1.Value.Date)
            CMD.Parameters.AddWithValue("@msk_cell_no", msk_cell_no.Text)
            CMD.Parameters.AddWithValue("@cmb_exam_passed", txt_exam_passed.Text)
            CMD.Parameters.AddWithValue("@session", cmb_session.Text)
            CMD.Parameters.AddWithValue("@pin_no", txt_pin_no.Text)
            CMD.Parameters.AddWithValue("@txt_address", txt_address.Text)
            CMD.Parameters.AddWithValue("@txt_state", cmb_state.Text)
            CMD.Parameters.AddWithValue("@txt_city", cmb_city.Text)
            CMD.Parameters.AddWithValue("@txt_email", msk_email.Text)
            CMD.Parameters.AddWithValue("@picture", OpenFileDialog1.FileName)
            If rdb_male.Checked = True Then
                CMD.Parameters.AddWithValue("@sex", rdb_male.Text)

            Else
                CMD.Parameters.AddWithValue("@sex", rdb_female.Text)

            End If

            If txt_admission_no.Text <> "" And cmb_joining_class.Text <> "" And txt_student_ist_name.Text <> "" And txt_student_last_name.Text <> "" And txt_fathers_name.Text <> "" And txt_mothers_name.Text <> "" And txt_exam_passed.Text <> "" And cmb_session.Text <> "" And txt_address.Text <> "" And cmb_state.Text <> "" And cmb_city.Text <> "" And txt_pin_no.Text <> "" And (rdb_male.Checked = True Or rdb_female.Checked = True) Then

                Try
                    CN.Open()
                    CMD.ExecuteNonQuery()
                    If CN.State = ConnectionState.Open Then CN.Close()
                    MessageBox.Show("Student information updated sucessfully", "STUDENT UPDATED...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MessageBox.Show("Enter all details correctly", "ERROR...", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            CN.Close()
        End If

    End Sub

    Private Sub btn_pic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pic.Click

        Dim filename As String
        PictureBox1.ImageLocation = ""
        OpenFileDialog1.Filter = "image files (*.jpeg,*.jpg)|*.jpg"
        OpenFileDialog1.InitialDirectory = "~\stud_reg_systm\coleg_reg_systm\Resources\"

        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then

            filename = OpenFileDialog1.FileName

            Dim cmd As New SqlCommand("select picture from second_year where admission_no <> @msk_admission_no", CN)

            txt_admission_no.Text = coleg_main_form.edit_stud_2nd_yr_num

            cmd.Parameters.AddWithValue("@msk_admission_no", txt_admission_no.Text)
            Dim dr3 As SqlDataReader
            Try
                CN.Open()
                dr3 = cmd.ExecuteReader
                While (dr3.Read = True)
                    If (dr3.Item(0).ToString = filename) Then
                        OpenFileDialog1.FileName = ""
                        MessageBox.Show("This picture already exists", "PICTURE ALREADY EXISTS...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        CN.Close()
                        PictureBox1.ImageLocation = ""
                        Exit Sub
                    End If

                End While
                CN.Close()
                PictureBox1.ImageLocation = filename
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
            'PictureBox1.Refresh()
            'PictureBox1.Image = _
            'Image.FromFile("C:\Users\AMIRRESHI\Pictures\tht.jpg")
            flag = True
        End If

    End Sub

    Private Sub btn_clear_all_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_clear_all.Click

        clear_all()

    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        Me.Close()
        coleg_main_form.Focus()
    End Sub

    Private Sub alphabet(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.A To Keys.Z
            Case Keys.Back
            Case Keys.Space
            Case Keys.ShiftKey
            Case Keys.CapsLock
            Case Keys.Left, Keys.Right
            Case Keys.ControlKey
            Case Else

                e.SuppressKeyPress = True
                Beep()

        End Select
    End Sub

    Private Sub txt_student_ist_name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_student_ist_name.KeyDown

        alphabet(e, e)
    End Sub

    Private Sub txt_student_last_name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_student_last_name.KeyDown
        alphabet(e, e)
    End Sub

    Private Sub txt_fathers_name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_fathers_name.KeyDown
        alphabet(e, e)
    End Sub

    Private Sub txt_mothers_name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_mothers_name.KeyDown
        alphabet(e, e)
    End Sub

    Private Sub txt_pin_no_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_pin_no.KeyDown
        Select Case e.KeyCode
            Case Keys.Back
            Case Keys.NumLock
            Case Keys.D0 To Keys.D9
            Case Keys.NumPad0 To Keys.NumPad9
            Case Keys.Left, Keys.Right
            Case Keys.ControlKey

            Case Else
                e.SuppressKeyPress = True
                Beep()

        End Select
    End Sub

End Class