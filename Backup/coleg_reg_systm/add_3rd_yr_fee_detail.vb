Imports System.Data
Imports System.Data.SqlClient
Public Class add_3rd_yr_fee_detail

    Dim CN As New SqlConnection("server=AMIRRESHI-PC\SQLSERVER05;initial catalog=Coleg_RS;integrated security=true")

    Private Sub add_3nd_yr_fee_detail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim dt As Integer
        dt = Val(Now.Year)
        cmb_session.Text = dt.ToString + "-" + (dt + 1).ToString
        add_bca_3rd_yr.txt_exam_passed.Text = "2ND YEAR"

        txt_admission_no.Text = add_bca_3rd_yr.txt_admission_no.Text

        cmb_joining_class.SelectedIndex = 2

        txt_name.Text = add_bca_3rd_yr.txt_student_ist_name.Text & " " & add_bca_3rd_yr.txt_student_last_name.Text
        txt_fathers_name.Text = add_bca_3rd_yr.txt_fathers_name.Text
        cmb_session.Text = cmb_session.Text

        Dim CMD As New SqlCommand("select tution_fee,library_fee , university_fee , other_charges ,total_fee from fee", CN)

        If CN.State = ConnectionState.Open Then CN.Close()

        Try

            CN.Open()
            Dim DR As SqlDataReader
            DR = CMD.ExecuteReader
            If DR.Read = True Then
                lbl_tution_fee.Text = DR.Item(0).ToString
                lbl_library_fee.Text = DR.Item(1).ToString
                lbl_university_fee.Text = DR.Item(2).ToString
                lbl_tother_charges_fee.Text = DR.Item(3).ToString
                lbl_total_fee.Text = DR.Item(4).ToString
                add_bca_2nd_yr.total = Val(DR.Item(4))
            End If
            CN.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        txt_paid_fee.Focus()

    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click

        If (Val(txt_paid_fee.Text) < 10000) Then
            txt_paid_fee.Clear()
            MessageBox.Show("Paid fee must be equal or greater than 10,000", "ERROR...", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txt_paid_fee.Focus()
            lbl_balance_fee.Text = ""
            Exit Sub
        ElseIf (Val(txt_paid_fee.Text) > 20000) Then
            txt_paid_fee.Clear()
            MessageBox.Show("Paid fee must be less or equal to 20,000", "ERROR...", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txt_paid_fee.Focus()
            lbl_balance_fee.Text = ""
            Exit Sub
        End If

        Dim CMD As New SqlCommand("insert into final_year (admission_no,joining_class , ist_name , last_name , fathers_name , mothers_name,d_o_b, cell_no , exam_passed, session, address ,state ,city ,pin_no,email_id, picture,sex,balance) values (@txt_admission_no, @cmb_joining_class , @txt_student_ist_name , @txt_student_last_name ,          @txt_fathers_name ,@txt_mothers_name ,@d_o_b, @msk_cell_no , @txt_exam_passed ,@cmb_session,@txt_address , @txt_state , @txt_city ,@txt_pin_no, @msk_email, @picture,@sex,@balance)", CN)

        txt_admission_no.Text = coleg_main_form.add_stud_3rd_yr_num

        CMD.Parameters.AddWithValue("@txt_admission_no", txt_admission_no.Text)
        CMD.Parameters.AddWithValue("@cmb_joining_class", cmb_joining_class.Text)
        CMD.Parameters.AddWithValue("@txt_student_ist_name", add_bca_3rd_yr.txt_student_ist_name.Text)
        CMD.Parameters.AddWithValue("@txt_student_last_name", add_bca_3rd_yr.txt_student_last_name.Text)
        CMD.Parameters.AddWithValue("@txt_fathers_name", add_bca_3rd_yr.txt_fathers_name.Text)
        CMD.Parameters.AddWithValue("@txt_mothers_name", add_bca_3rd_yr.txt_mothers_name.Text)
        CMD.Parameters.AddWithValue("@d_o_b", add_bca_3rd_yr.DateTimePicker1.Value.Date)
        CMD.Parameters.AddWithValue("@msk_cell_no", add_bca_3rd_yr.msk_cell_no.Text)
        CMD.Parameters.AddWithValue("@txt_exam_passed", add_bca_3rd_yr.txt_exam_passed.Text)
        CMD.Parameters.AddWithValue("@cmb_session", cmb_session.Text)

        CMD.Parameters.AddWithValue("@txt_address", add_bca_3rd_yr.txt_address.Text)
        CMD.Parameters.AddWithValue("@txt_state", add_bca_3rd_yr.cmb_state.Text)
        CMD.Parameters.AddWithValue("@txt_city", add_bca_3rd_yr.cmb_city.Text)
        CMD.Parameters.AddWithValue("@txt_pin_no", add_bca_3rd_yr.txt_pin_no.Text)
        CMD.Parameters.AddWithValue("@msk_email", add_bca_3rd_yr.msk_email.Text)
        CMD.Parameters.AddWithValue("@balance", lbl_balance_fee.Text)
        CMD.Parameters.AddWithValue("@picture", add_bca_3rd_yr.PictureBox1.ImageLocation)

        If add_bca_3rd_yr.rdb_male.Checked = True Then
            CMD.Parameters.AddWithValue("@sex", add_bca_3rd_yr.rdb_male.Text)

        Else
            CMD.Parameters.AddWithValue("@sex", add_bca_3rd_yr.rdb_female.Text)

        End If

        Try
            If CN.State = ConnectionState.Open Then CN.Close()

            If add_bca_3rd_yr.cmb_joining_class.Text <> "" And add_bca_3rd_yr.txt_student_ist_name.Text <> "" And add_bca_3rd_yr.txt_student_last_name.Text <> "" And add_bca_3rd_yr.txt_fathers_name.Text <> "" And add_bca_3rd_yr.txt_mothers_name.Text <> "" And add_bca_3rd_yr.txt_exam_passed.Text <> "" And add_bca_3rd_yr.cmb_session.Text <> "" And add_bca_3rd_yr.txt_address.Text <> "" And add_bca_3rd_yr.cmb_state.Text <> "" And add_bca_3rd_yr.cmb_city.Text <> "" And add_bca_3rd_yr.txt_pin_no.Text <> "" And add_bca_3rd_yr.PictureBox1.ImageLocation <> "" And (add_bca_3rd_yr.rdb_male.Checked = True Or add_bca_3rd_yr.rdb_female.Checked = True) Then

                Try
                    CN.Open()
                    CMD.ExecuteNonQuery()
                    If CN.State = ConnectionState.Open Then CN.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)

                End Try

                MessageBox.Show("Student enrolled to 3rd year", "3RD YEAR ADMISSION...", MessageBoxButtons.OK, MessageBoxIcon.Information)

                txt_paid_fee.Text = ""
                Me.Close()
                add_bca_3rd_yr.Close()

            Else
                MessageBox.Show("Please click BACK and enter all details with picture", "ERROR...", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txt_paid_fee_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_paid_fee.LostFocus
        lbl_balance_fee.Text = (lbl_total_fee.Text - (Val(txt_paid_fee.Text)))
    End Sub


    Private Sub btn_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click
        Me.Close()
        add_bca_3rd_yr.Show()
    End Sub

    Private Sub btn_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click

        If MessageBox.Show("Do You Really Want To Exit Student 2nd Year Admission ?", "EXIT..", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            add_bca_3rd_yr.Close()
            coleg_main_form.Show()
            coleg_main_form.Focus()

        End If
    End Sub

End Class