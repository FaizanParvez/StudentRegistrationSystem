Imports System.Data
Imports System.Data.SqlClient
Public Class fee_details_form

    '******************** CREATING CONNECTION ****************

    Dim CN As New SqlConnection("server=AMIRRESHI-PC\SQLSERVER05;initial catalog=Coleg_RS;integrated security=true")

    '******************** FEE DETAIL FORM LOAD ****************

    Private Sub fee_details_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_paid_fee.Clear()
        lbl_balance_fee.Text = ""
        txt_paid_fee.Focus()
    End Sub

    '******************** CODE FOR SAVE BUTTON ****************

    Public Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click

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

        Dim CMD As New SqlCommand("insert into admission (admission_no,joining_class , ist_name , last_name ,       fathers_name , mothers_name,d_o_b, cell_no , exam_passed, session, address ,state ,city ,pin_no,email_id, picture,sex,balance) values (@txt_admission_no, @cmb_joining_class , @txt_student_ist_name , @txt_student_last_name ,          @txt_fathers_name ,@txt_mothers_name ,@d_o_b, @msk_cell_no , @txt_exam_passed ,@cmb_session,@txt_address , @txt_state , @txt_city ,@txt_pin_no, @msk_email, @picture,@sex,@balance)", CN)

        CMD.Parameters.AddWithValue("@txt_admission_no", add_stud_admission_form.test + 1)
        CMD.Parameters.AddWithValue("@cmb_joining_class", add_stud_admission_form.cmb_joining_class.Text)
        CMD.Parameters.AddWithValue("@txt_student_ist_name", add_stud_admission_form.txt_student_ist_name.Text)
        CMD.Parameters.AddWithValue("@txt_student_last_name", add_stud_admission_form.txt_student_last_name.Text)
        CMD.Parameters.AddWithValue("@txt_fathers_name", add_stud_admission_form.txt_fathers_name.Text)
        CMD.Parameters.AddWithValue("@txt_mothers_name", add_stud_admission_form.txt_mothers_name.Text)
        CMD.Parameters.AddWithValue("@d_o_b", add_stud_admission_form.DateTimePicker1.Value.Date)
        CMD.Parameters.AddWithValue("@msk_cell_no", add_stud_admission_form.msk_cell_no.Text)
        CMD.Parameters.AddWithValue("@txt_exam_passed", add_stud_admission_form.txt_exam_passed.Text)
        CMD.Parameters.AddWithValue("@cmb_session", cmb_session.Text)

        CMD.Parameters.AddWithValue("@txt_address", add_stud_admission_form.txt_address.Text)
        CMD.Parameters.AddWithValue("@txt_state", add_stud_admission_form.cmb_state.Text)
        CMD.Parameters.AddWithValue("@txt_city", add_stud_admission_form.cmb_city.Text)
        CMD.Parameters.AddWithValue("@txt_pin_no", add_stud_admission_form.txt_pin_no.Text)
        CMD.Parameters.AddWithValue("@msk_email", add_stud_admission_form.msk_email.Text)
        CMD.Parameters.AddWithValue("@balance", lbl_balance_fee.Text)
        CMD.Parameters.AddWithValue("@picture", add_stud_admission_form.OpenFileDialog1.FileName)

        If add_stud_admission_form.rdb_male.Checked = True Then
            CMD.Parameters.AddWithValue("@sex", add_stud_admission_form.rdb_male.Text)

        Else
            CMD.Parameters.AddWithValue("@sex", add_stud_admission_form.rdb_female.Text)

        End If

        Try
            If CN.State = ConnectionState.Open Then CN.Close()

            If add_stud_admission_form.cmb_joining_class.Text <> "" And add_stud_admission_form.txt_student_ist_name.Text <> "" And add_stud_admission_form.txt_student_last_name.Text <> "" And add_stud_admission_form.txt_fathers_name.Text <> "" And add_stud_admission_form.txt_mothers_name.Text <> "" And add_stud_admission_form.txt_exam_passed.Text <> "" And add_stud_admission_form.cmb_session.Text <> "" And add_stud_admission_form.txt_address.Text <> "" And add_stud_admission_form.cmb_state.Text <> "" And add_stud_admission_form.cmb_city.Text <> "" And add_stud_admission_form.txt_pin_no.Text <> "" And add_stud_admission_form.PictureBox1.ImageLocation <> "" And (add_stud_admission_form.rdb_male.Checked = True Or add_stud_admission_form.rdb_female.Checked = True) Then

                Try
                    CN.Open()
                    CMD.ExecuteNonQuery()
                    If CN.State = ConnectionState.Open Then CN.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)

                End Try

                MessageBox.Show("Student added sucessfully", "STUDENT ADMISSION...", MessageBoxButtons.OK, MessageBoxIcon.Information)

                txt_paid_fee.Text = ""
                add_stud_admission_form.clear_all()
                Me.Close()
                add_stud_admission_form.Show()


                Dim command As New SqlCommand("select admission_no from admission", CN)
                Dim dr As SqlDataReader

                Try

                    If CN.State = ConnectionState.Open Then CN.Close()
                    CN.Open()
                    dr = command.ExecuteReader

                    While (dr.Read = True)
                        add_stud_admission_form.value = Val(dr.Item("admission_no"))
                        If add_stud_admission_form.value > add_stud_admission_form.test Then
                            add_stud_admission_form.test = add_stud_admission_form.value
                            txt_admission_no.Text = add_stud_admission_form.test + 1

                        End If
                    End While
                    CN.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                add_stud_admission_form.clear_all()

            Else
                MessageBox.Show("Please click BACK and enter all details with picture", "ERROR...", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    '******************** CODE FOR BACK BUTTON ****************

    Private Sub btn_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click
        Me.Close()
        add_stud_admission_form.Show()
        add_stud_admission_form.txt_admission_no.Text = add_stud_admission_form.test + 1
    End Sub

    '******************** CODE FOR EXIT BUTTON ****************

    Private Sub btn_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        If MessageBox.Show("Do You Really Want To Exit Student Admission ?", "EXIT..", _
MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            add_stud_admission_form.clear_all()
            add_stud_admission_form.Close()
            coleg_main_form.Show()
            coleg_main_form.Focus()

        End If
    End Sub

    Private Sub txt_paid_fee_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_paid_fee.KeyDown

        Select Case e.KeyCode
            Case Keys.Back
            Case Keys.NumPad0 To Keys.NumPad9, Keys.NumLock
            Case Keys.Left, Keys.Right
            Case Keys.D0 To Keys.D9

            Case Else

                e.SuppressKeyPress = True
                Beep()
        End Select
    End Sub

    '******************** CODE FOR FEE BALANCE ****************

    Private Sub txt_paid_fee_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_paid_fee.LostFocus
        lbl_balance_fee.Text = (lbl_total_fee.Text - (Val(txt_paid_fee.Text)))
    End Sub

    Private Sub txt_paid_fee_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_paid_fee.TextChanged

    End Sub
End Class