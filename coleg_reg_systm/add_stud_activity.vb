Imports System.Data
Imports System.Data.SqlClient
Public Class add_stud_activity

    '******************** CREATING CONNECTION ****************

    Dim CN As New SqlConnection("server=FAIZAN-PC\SQLSERVER05;initial catalog=student_registration;integrated security=true")

    '************* ADD STUDENT ACTIVITY FORM LOAD ****************

    Private Sub add_stud_activity_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmb_Athletics_Games.SelectedIndex = 1
        cmb_camps_mount.SelectedIndex = 1
        cmb_cross_country.SelectedIndex = 1
        cmb_debate.SelectedIndex = 1
        cmb_quiz.SelectedIndex = 1
        cmb_swimming.SelectedIndex = 1

        Dim CMD As New SqlCommand("select admission_no,joining_class , ist_name , last_name ,fathers_name , address, session,picture from admission where admission_no=@txt_admission_no", CN)

        txt_admission_no.Text = coleg_main_form.add_act_num

        CMD.Parameters.AddWithValue("@txt_admission_no", txt_admission_no.Text)

        Try

            CN.Open()
            Dim DR As SqlDataReader
            DR = CMD.ExecuteReader
            If DR.Read = True Then
                txt_admission_no.Text = DR.Item("admission_no").ToString
                cmb_joining_class.Text = DR.Item("joining_class").ToString
                txt_student_name.Text = DR.Item("ist_name").ToString & " " & DR.Item("last_name").ToString
                txt_fathers_name.Text = DR.Item("fathers_name").ToString
                txt_address.Text = DR.Item("address").ToString
                cmb_session.Text = DR.Item("session").ToString
                PictureBox1.ImageLocation = DR.Item("picture").ToString

                If CN.State = ConnectionState.Open Then CN.Close()

            Else
                MessageBox.Show("Student yet not admitted", "STUDENT DOES NOT EXIST...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
                If CN.State = ConnectionState.Open Then CN.Close()
            End If
            CN.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Dim CMD1 As New SqlCommand("select admission_no from activity where admission_no=@txt_admission_no", CN)

        txt_admission_no.Text = coleg_main_form.add_act_num

        CMD1.Parameters.AddWithValue("@txt_admission_no", txt_admission_no.Text)

        Try
            CN.Open()
            Dim DR1 As SqlDataReader
            DR1 = CMD1.ExecuteReader
            If DR1.Read = True Then
                MessageBox.Show("IST YEAR Student activities already added", "ADDED STUDENT ACTIVITIES...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
                If CN.State = ConnectionState.Open Then CN.Close()
            End If
            CN.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Dim dt As Integer
        dt = Val(Now.Year)
        cmb_session.Text = dt.ToString + "-" + (dt + 1).ToString


    End Sub

    '************* CODE FOR SAVE BUTTON ****************

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click

        Dim CMD As New SqlCommand("insert into activity (admission_no,cross_country , ath_games,camps_mount,debate,swimming,quiz) values (   @txt_admission_no,@cmb_cross_country , @cmb_ath_games,@cmb_camps_mount,@cmb_debate,@cmb_swimming,@cmb_quiz)", CN)

        CMD.Parameters.AddWithValue("@txt_admission_no", txt_admission_no.Text)
        CMD.Parameters.AddWithValue("@cmb_cross_country", cmb_cross_country.Text)
        CMD.Parameters.AddWithValue("@cmb_ath_games", cmb_Athletics_Games.Text)
        CMD.Parameters.AddWithValue("@cmb_camps_mount", cmb_camps_mount.Text)
        CMD.Parameters.AddWithValue("@cmb_debate", cmb_debate.Text)
        CMD.Parameters.AddWithValue("@cmb_swimming", cmb_swimming.Text)

        CMD.Parameters.AddWithValue("@cmb_quiz", cmb_quiz.Text)

        Try
            CN.Open()
            CMD.ExecuteNonQuery()
            CN.Close()
            MessageBox.Show("IST YEAR Student activities added sucessfully", "STUDENT ACTIVITIES...", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    '******************** CODE EXIT BUTTON ****************

    Private Sub btn_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
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

    Private Sub txt_student_name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_student_name.KeyDown
        notext(e, e)
    End Sub

    Private Sub txt_fathers_name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_fathers_name.KeyDown
        notext(e, e)
    End Sub

    Private Sub txt_address_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_address.KeyDown
        notext(e, e)
    End Sub

    Private Sub lbl_heading_admission_form_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_heading_admission_form.Click

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class