Imports System.Data
Imports System.Data.SqlClient
Public Class view_stud_2nd_yr_activity

    '******************** CREATING CONNECTION ****************

    Dim CN As New SqlConnection("server=AMIRRESHI-PC\SQLSERVER05;initial catalog=Coleg_RS;integrated security=true")
    Dim flag As Boolean = False

    '******************* VIEW STUDENT FORM LOAD ****************

    Private Sub view_stud_2nd_yr_activity_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If flag = False Then

            Dim CMD As New SqlCommand("select admission_no,joining_class , ist_name , last_name ,fathers_name , address, session,picture from second_year where admission_no=@txt_admission_no", CN)

            txt_admission_no.Text = coleg_main_form.view_stud_2nd_yr_act_num

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
                    GoTo amir
                Else

                    MessageBox.Show("Student yet not enrolled to 2nd year", "STUDENT DOES NOT EXIST...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                    If CN.State = ConnectionState.Open Then CN.Close()
                End If
                CN.Close()
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        Else
amir:

            Dim CMD2 As New SqlCommand("select admission_no,cross_country , ath_games , camps_mount ,debate , swimming, quiz from activity_sec_yr where admission_no=@txt_admission_no", CN)

            txt_admission_no.Text = coleg_main_form.view_stud_2nd_yr_act_num

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
                    MessageBox.Show("2nd Year Student activities yet not added", "view 2ND YEAR ACTIVITIES...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                    If CN.State = ConnectionState.Open Then CN.Close()
                End If
                CN.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If


    End Sub

    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub
End Class