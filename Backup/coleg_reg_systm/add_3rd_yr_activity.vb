Imports System.Data
Imports System.Data.SqlClient
Public Class add_3rd_yr_activity

    '******************** CREATING CONNECTION ****************

    Dim CN As New SqlConnection("server=AMIRRESHI-PC\SQLSERVER05;initial catalog=Coleg_RS;integrated security=true")

    '************* ADD STUDENT ACTIVITY FORM LOAD ****************

    Private Sub add_3rd_yr_activity_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cmb_Athletics_Games.SelectedIndex = 1
        cmb_camps_mount.SelectedIndex = 1
        cmb_cross_country.SelectedIndex = 1
        cmb_debate.SelectedIndex = 1
        cmb_quiz.SelectedIndex = 1
        cmb_swimming.SelectedIndex = 1

        Dim CMD As New SqlCommand("select admission_no,joining_class , ist_name , last_name ,fathers_name , address, session,picture from final_year where admission_no=@txt_admission_no", CN)

        txt_admission_no.Text = coleg_main_form.add_3rd_yr_act_num

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
                MessageBox.Show("Student yet not enrolled to 3rd year", "ADD 3RD YEAR ACTIVITIES...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
                If CN.State = ConnectionState.Open Then CN.Close()
            End If
            CN.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        Dim CMD1 As New SqlCommand("select admission_no from activity_fin_yr where admission_no=@txt_admission_no", CN)

        txt_admission_no.Text = coleg_main_form.add_3rd_yr_act_num

        CMD1.Parameters.AddWithValue("@txt_admission_no", txt_admission_no.Text)

        Try
            CN.Open()
            Dim DR1 As SqlDataReader
            DR1 = CMD1.ExecuteReader
            If DR1.Read = True Then
                MessageBox.Show("3RD YEAR Student activities already added", "ERROR...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
                If CN.State = ConnectionState.Open Then CN.Close()
            End If
            CN.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click

        Dim CMD As New SqlCommand("insert into activity_fin_yr (admission_no,cross_country , ath_games,camps_mount,debate,swimming,quiz) values (   @txt_admission_no,@cmb_cross_country , @cmb_ath_games,@cmb_camps_mount,@cmb_debate,@cmb_swimming,@cmb_quiz)", CN)

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
            MessageBox.Show("3rd year Student activities added sucessfully", "STUDENT 3RD YEAR ACTIVITIES...", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub btn_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        Me.Close()

    End Sub
End Class