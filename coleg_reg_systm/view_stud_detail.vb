Imports System.Data.SqlClient
Public Class view_stud_detail

    '******************** CREATING CONNECTION ****************

    Dim CN As New SqlConnection("server=FAIZAN-PC\SQLSERVER05;initial catalog=student_registration;integrated security=true")

    '*************** VIEW STUDENT DETAIL FORM LOAD ****************

    Private Sub view_stud_detail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim CMD As New SqlCommand("select admission_no,joining_class , ist_name , last_name ,fathers_name , mothers_name, d_o_b, cell_no , exam_passed,session ,sex, address ,state ,city,pin_no , email_id,picture from admission where admission_no=@txt_admission_no", CN)

        txt_admission_no.Text = coleg_main_form.view_stud_num

        CMD.Parameters.AddWithValue("@txt_admission_no", txt_admission_no.Text)

        Try
            CN.Open()
            Dim DR As SqlDataReader
            DR = CMD.ExecuteReader
            If DR.Read = True Then
                txt_admission_no.Text = DR.Item("admission_no").ToString
                cmb_joining_class.Text = DR.Item("joining_class").ToString
                txt_name.Text = DR.Item("ist_name").ToString & " " & DR.Item("last_name").ToString
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
                txt_email.Text = DR.Item("email_id").ToString
                PictureBox1.ImageLocation = DR.Item("picture").ToString

                If DR.Item("sex").ToString = "Male" Then
                    rdb_male.Checked = True
                Else
                    rdb_female.Checked = True
                End If

                If CN.State = ConnectionState.Open Then CN.Close()

            Else
                MessageBox.Show("Record not found", "ERROR...", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                If CN.State = ConnectionState.Open Then CN.Close()
            End If
            CN.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    '******************** CODE FOR CLOSE BUTTON ****************

    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Me.Close()

    End Sub

    '******************** CODE FOR VALIDATION ****************

    Private Sub notext(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Select Case e.KeyCode

            Case Else

                e.SuppressKeyPress = True
                Beep()

        End Select
    End Sub

    Private Sub txt_name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        notext(e, e)
    End Sub

    Private Sub txt_admission_no_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        notext(e, e)
    End Sub

    Private Sub txt_fathers_name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        notext(e, e)
    End Sub


    Private Sub txt_mothers_name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        notext(e, e)
    End Sub

    Private Sub DateTimePicker1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        notext(e, e)
    End Sub

    Private Sub msk_cell_no_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        notext(e, e)
    End Sub

    Private Sub txt_exam_passed_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        notext(e, e)
    End Sub
    
    Private Sub rdb_male_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        notext(e, e)
    End Sub

    Private Sub rdb_female_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        notext(e, e)
    End Sub

    Private Sub txt_address_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        notext(e, e)
    End Sub


    Private Sub txt_pin_no_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        notext(e, e)
    End Sub

    Private Sub txt_email_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        notext(e, e)
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub lbl_student_last_examination_passed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub lbl_class_of_joining_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub lbl_birthdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub lbl_cell_no_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub lbl_admission_no_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub lbl_nme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub txt_fathers_name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub txt_mothers_name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub cmb_joining_class_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub msk_cell_no_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs)

    End Sub
    Private Sub txt_admission_no_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub txt_exam_passed_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub cmb_session_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub txt_name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class