Imports System.Data.SqlClient
Public Class del_stud_form

    '******************** CREATING CONNECTION ****************

    Dim CN As New SqlConnection("server=AMIRRESHI-PC\SQLSERVER05;initial catalog=Coleg_RS;integrated security=true")

    '******************** DELETE STUDENT FORM LOAD ****************

    Private Sub del_stud_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim CMD As New SqlCommand("select admission_no,joining_class , ist_name , last_name ,fathers_name , mothers_name, d_o_b, cell_no , exam_passed,sex,session , address ,state ,city ,pin_no, email_id,picture from admission where admission_no=@msk_admission_no", CN)

        txt_admission_no.Text = coleg_main_form.del_num

        CMD.Parameters.AddWithValue("@msk_admission_no", txt_admission_no.Text)

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
                msk_cell_no.Text = DR.Item("cell_no").ToString
                txt_exam_passed.Text = DR.Item("exam_passed").ToString
                txt_address.Text = DR.Item("address").ToString
                cmb_state.Text = DR.Item("state").ToString
                cmb_session.Text = DR.Item("session").ToString
                cmb_city.Text = DR.Item("city").ToString
                txt_email.Text = DR.Item("email_id").ToString
                txt_pin_no.Text = DR.Item("pin_no").ToString
                DateTimePicker1.Value = CDate(DR.Item("d_o_b"))

                If DR.Item("sex").ToString = "Male" Then
                    rdb_male.Checked = True
                Else
                    rdb_female.Checked = True
                End If

                PictureBox1.ImageLocation = DR.Item("picture").ToString
                If CN.State = ConnectionState.Open Then CN.Close()

            Else
                MessageBox.Show("Record not found", "ERROR...", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                Me.Refresh()
                If CN.State = ConnectionState.Open Then CN.Close()
            End If
            CN.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    '******************** CODE FOR DELETE BUTTON ****************

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click

        Dim CMD As New SqlCommand("delete from admission where admission_no=@msk_admission_no", CN)

        txt_admission_no.Text = coleg_main_form.del_num

        CMD.Parameters.AddWithValue("@msk_admission_no", txt_admission_no.Text)

        Try

            CN.Open()
            CMD.ExecuteNonQuery()
            If CN.State = ConnectionState.Open Then CN.Close()
            MessageBox.Show("Student deleted sucessfully", "STUDENT DELETED...", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        CN.Close()

        Dim CMD2 As New SqlCommand("delete from second_year where admission_no=@msk_admission_no", CN)
        txt_admission_no.Text = coleg_main_form.del_num
        CMD2.Parameters.AddWithValue("@msk_admission_no", txt_admission_no.Text)

        Try

            CN.Open()
            CMD2.ExecuteNonQuery()
            If CN.State = ConnectionState.Open Then CN.Close()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        CN.Close()

        Dim CMD3 As New SqlCommand("delete from final_year where admission_no=@msk_admission_no", CN)

        txt_admission_no.Text = coleg_main_form.del_num

        CMD3.Parameters.AddWithValue("@msk_admission_no", txt_admission_no.Text)

        Try

            CN.Open()
            CMD3.ExecuteNonQuery()
            If CN.State = ConnectionState.Open Then CN.Close()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        CN.Close()

        Dim CMD4 As New SqlCommand("delete from activity where admission_no=@msk_admission_no", CN)

        txt_admission_no.Text = coleg_main_form.del_num

        CMD4.Parameters.AddWithValue("@msk_admission_no", txt_admission_no.Text)

        Try

            CN.Open()
            CMD4.ExecuteNonQuery()
            If CN.State = ConnectionState.Open Then CN.Close()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        CN.Close()

        Dim CMD5 As New SqlCommand("delete from final_year where admission_no=@msk_admission_no", CN)

        txt_admission_no.Text = coleg_main_form.del_num

        CMD5.Parameters.AddWithValue("@msk_admission_no", txt_admission_no.Text)

        Try

            CN.Open()
            CMD5.ExecuteNonQuery()
            If CN.State = ConnectionState.Open Then CN.Close()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        CN.Close()

        Dim CMD6 As New SqlCommand("delete from final_year where admission_no=@msk_admission_no", CN)

        txt_admission_no.Text = coleg_main_form.del_num

        CMD6.Parameters.AddWithValue("@msk_admission_no", txt_admission_no.Text)

        Try

            CN.Open()
            CMD6.ExecuteNonQuery()
            If CN.State = ConnectionState.Open Then CN.Close()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        CN.Close()
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

    Private Sub txt_admission_no_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_admission_no.KeyDown
        notext(e, e)
    End Sub

    Private Sub txt_student_ist_name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_student_ist_name.KeyDown
        notext(e, e)
    End Sub

    Private Sub txt_student_last_name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_student_last_name.KeyDown
        notext(e, e)
    End Sub

    Private Sub txt_fathers_name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_fathers_name.KeyDown
        notext(e, e)
    End Sub

    Private Sub txt_mothers_name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_mothers_name.KeyDown
        notext(e, e)
    End Sub

    Private Sub DateTimePicker1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DateTimePicker1.KeyDown
        notext(e, e)
    End Sub

    Private Sub msk_cell_no_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles msk_cell_no.KeyDown
        notext(e, e)
    End Sub

    Private Sub txt_exam_passed_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_exam_passed.KeyDown
        notext(e, e)
    End Sub

    Private Sub rdb_male_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        notext(e, e)
    End Sub

    Private Sub rdb_female_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        notext(e, e)
    End Sub

    Private Sub txt_address_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_address.KeyDown
        notext(e, e)
    End Sub

    Private Sub txt_pin_no_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_pin_no.KeyDown
        notext(e, e)
    End Sub

    Private Sub txt_email_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_email.KeyDown
        notext(e, e)
    End Sub

End Class