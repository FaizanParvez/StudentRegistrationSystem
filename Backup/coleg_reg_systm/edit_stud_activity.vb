Imports System.Data
Imports System.Data.SqlClient

Public Class edit_stud_activity

    '******************** CREATING CONNECTION ****************

    Dim CN As New SqlConnection("server=AMIRRESHI-PC\SQLSERVER05;initial catalog=Coleg_RS;integrated security=true")
    Dim flag As Boolean = False

    '*************** UPDATE STUDENT ACTIVITY FORM LOAD ****************

    Private Sub edit_stud_activity_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If flag = False Then

            Dim CMD As New SqlCommand("select admission_no,joining_class , ist_name , last_name ,fathers_name , address, session,picture from admission where admission_no=@txt_admission_no", CN)

            txt_admission_no.Text = coleg_main_form.edit_stud_act_num

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
                    txt_address.Text = DR.Item("address").ToString
                    cmb_session.Text = DR.Item("session").ToString
                    PictureBox1.ImageLocation = DR.Item("picture").ToString

                    If CN.State = ConnectionState.Open Then CN.Close()
                    GoTo amir
                Else
                    MessageBox.Show("Student yet not admitted", "STUDENT DOES NOT EXIST...", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Me.Close()
                    If CN.State = ConnectionState.Open Then CN.Close()
                End If
                CN.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
amir:

            Dim CMD2 As New SqlCommand("select admission_no,cross_country , ath_games , camps_mount ,debate , swimming, quiz from activity where admission_no=@txt_admission_no", CN)

            txt_admission_no.Text = coleg_main_form.edit_stud_act_num

            CMD2.Parameters.AddWithValue("@txt_admission_no", txt_admission_no.Text)

            Try

                CN.Open()
                Dim DR1 As SqlDataReader
                DR1 = CMD2.ExecuteReader
                If DR1.Read = True Then
                    cmb_cross_country.Text = DR1.Item("cross_country").ToString
                    cmb_Athletics_Games.Text = DR1.Item("ath_games").ToString
                    cmb_camps_mount.Text = DR1.Item("camps_mount").ToString
                    cmb_debate.Text = DR1.Item("debate").ToString
                    cmb_swimming.Text = DR1.Item("swimming").ToString
                    cmb_quiz.Text = DR1.Item("quiz").ToString

                    If CN.State = ConnectionState.Open Then CN.Close()

                Else
                    MessageBox.Show("Ist Year Student activities yet not added", "view Ist YEAR ACTIVITIES...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                    If CN.State = ConnectionState.Open Then CN.Close()
                End If
                CN.Close()
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        End If
    End Sub

    '******************** CODE FOR UPDATE BUTTON ****************

    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        Dim CMD As New SqlCommand("update activity set admission_no =  @txt_admission_no,cross_country=@cmb_cross_country ,    ath_games  =   @cmb_ath_games,camps_mount=@cmb_camps_mount,debate=@cmb_debate,swimming=@cmb_swimming,quiz=@cmb_quiz where admission_no=@txt_admission_no", CN)
        txt_admission_no.Text = coleg_main_form.edit_stud_act_num

        
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
            MessageBox.Show("Student activities updated sucessfully", "STUDENT ACTIVITIES...", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        

    End Sub

    '******************** CODE FOR EXIT BUTTON ****************

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

    Private Sub txt_student_ist_name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_student_ist_name.KeyDown
        notext(e, e)
    End Sub

    Private Sub txt_student_last_name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_student_last_name.KeyDown
        notext(e, e)
    End Sub

    Private Sub txt_fathers_name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_fathers_name.KeyDown
        notext(e, e)
    End Sub

    Private Sub txt_address_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_address.KeyDown
        notext(e, e)
    End Sub

End Class