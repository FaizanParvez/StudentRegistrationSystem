Imports System.Data
Imports System.Data.SqlClient
Public Class view_stud_2nd_yr_fee

    '******************** CREATING CONNECTION ****************

    Dim CN As New SqlConnection("server=AMIRRESHI-PC\SQLSERVER05;initial catalog=Coleg_RS;integrated security=true")


    Private Sub view_stud_2nd_yr_fee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim CMD As New SqlCommand("select admission_no,joining_class , ist_name , last_name ,fathers_name, session,balance from second_year where admission_no=@txt_admission_no", CN)

        txt_admission_no.Text = coleg_main_form.view_stud_2nd_yr_fee_num

        CMD.Parameters.AddWithValue("@txt_admission_no", txt_admission_no.Text)

        Try
            CN.Open()
            Dim DR As SqlDataReader
            DR = CMD.ExecuteReader
            If DR.Read = True Then
                txt_admission_no.Text = DR.Item("admission_no").ToString
                cmb_class.Text = DR.Item("joining_class").ToString
                txt_name.Text = DR.Item("ist_name").ToString & " " & DR.Item("last_name").ToString
                txt_fathers_name.Text = DR.Item("fathers_name").ToString
                cmb_session.Text = DR.Item("session").ToString
                lbl_balance_fee.Text = DR.Item("balance").ToString
                If CN.State = ConnectionState.Open Then CN.Close()

            Else
                MessageBox.Show("Student yet not enrolled to 2nd year", "STUDENT DOES NOT EXIST...", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Me.Close()
                If CN.State = ConnectionState.Open Then CN.Close()
            End If
            CN.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Dim CMD1 As New SqlCommand("select tution_fee,library_fee , university_fee , other_charges ,total_fee from fee", CN)

        Try
            CN.Open()
            Dim DR1 As SqlDataReader
            DR1 = CMD1.ExecuteReader
            If DR1.Read = True Then
                lbl_tution_fee.Text = DR1.Item("tution_fee").ToString
                lbl_library_fee.Text = DR1.Item("library_fee").ToString

                lbl_university_fee.Text = DR1.Item("university_fee").ToString
                lbl_other_charges_fee.Text = DR1.Item("other_charges").ToString
                lbl_total_fee.Text = DR1.Item("total_fee").ToString
                If CN.State = ConnectionState.Open Then CN.Close()
            Else
                Me.Close()
                If CN.State = ConnectionState.Open Then CN.Close()
            End If
            CN.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub btn_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        Me.Close()

    End Sub
End Class