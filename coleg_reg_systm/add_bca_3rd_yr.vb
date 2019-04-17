Imports System.Data.SqlClient
Public Class add_bca_3rd_yr

    Dim CN As New SqlConnection("server=FAIZAN-PC\SQLSERVER05;initial catalog=student_registration;integrated security=true")

    Public total As Double = 0


    Private Sub add_bca_3nd_yr_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim CMD1 As New SqlCommand("select admission_no from final_year where admission_no=@txt_admission_no", CN)

        txt_admission_no.Text = coleg_main_form.add_stud_3rd_yr_num

        CMD1.Parameters.AddWithValue("@txt_admission_no", txt_admission_no.Text)

        Try
            CN.Open()
            Dim DR1 As SqlDataReader
            DR1 = CMD1.ExecuteReader
            If DR1.Read = True Then

                MessageBox.Show("Admission number already enrolled", "ERROR...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
                If CN.State = ConnectionState.Open Then CN.Close()
            End If
            CN.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        cmb_joining_class.SelectedIndex = 1

        Dim CMD As New SqlCommand("select admission_no,joining_class , ist_name , last_name ,fathers_name , mothers_name, d_o_b, cell_no , exam_passed,session ,sex, address ,state ,city,pin_no , email_id,picture from second_year where admission_no=@txt_admission_no", CN)

        txt_admission_no.Text = coleg_main_form.add_stud_3rd_yr_num

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
                MessageBox.Show("Student yet not enrolled to 2nd year", "3rd YEAR ADMISSION...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
                If CN.State = ConnectionState.Open Then CN.Close()
            End If
            CN.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try


    End Sub

    Private Sub btn_next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_next.Click
        add_3rd_yr_fee_detail.ShowDialog()
        add_3rd_yr_fee_detail.txt_paid_fee.Focus()
    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        Me.Close()
        coleg_main_form.Focus()
    End Sub
End Class