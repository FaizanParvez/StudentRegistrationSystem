Imports System.Data.SqlClient
Public Class change_ur_ps

    '******************** CREATING CONNECTION ****************

    Dim CN As New SqlConnection("server=FAIZAN-PC\SQLSERVER05;initial catalog=student_registration;integrated security=true")

    '***************** CHANGE PASSWORD FORM LOAD ****************

    Private Sub change_ur_ps_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Focus()
        txt_username.Text = ""
        txt_password.Text = ""
        txt_new_username.Text = ""
        txt_new_password.Text = ""
        txt_username.Focus()
    End Sub

    '****************** CODE FOR UPDATE PASSWORD ****************

    Private Sub btn_update_password_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update_password.Click

        Dim CMD As New SqlCommand("select username,password from login where username=@username and password=@password;update login set username=@nu,password=@np where username=@username and password=@password", CN)

        CMD.Parameters.AddWithValue("@username", txt_username.Text)
        CMD.Parameters.AddWithValue("@password", txt_password.Text)

        CMD.Parameters.AddWithValue("@nu", txt_new_username.Text)
        CMD.Parameters.AddWithValue("@np", txt_new_password.Text)

        Try
            CN.Open()
            Dim DR As SqlDataReader
            DR = CMD.ExecuteReader

            If txt_username.Text <> "" And txt_password.Text <> "" _
               And txt_new_username.Text <> "" And txt_new_password.Text <> "" Then
                If DR.Read = True Then
                    If CN.State = ConnectionState.Open Then CN.Close()
                    If MessageBox.Show("Congrats Password Changed Sucessfully...", "PASSWORD UPDATED...", MessageBoxButtons.OK, MessageBoxIcon.Information) = Windows.Forms.DialogResult.OK Then
                        Me.Close()

                    End If
                Else
                    MessageBox.Show("Sorry Your Current Username And Password Didn't Match.. Try again", "CURRENT USERNAME AND PASSWORD DIDN'T MATCH", _
                MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txt_password.Text = ""
                    txt_username.Text = ""
                    txt_new_username.Text = ""
                    txt_new_password.Text = ""
                    txt_username.Focus()
                    If CN.State = ConnectionState.Open Then CN.Close()

                End If
            Else
                If txt_username.Text = "" Or txt_password.Text = "" Or _
                   txt_new_username.Text = "" Or txt_new_password.Text = "" Then _
                MessageBox.Show("Acces denied.. Please enter details correctly...", "ERROR...", _
                MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_password.Text = ""
                txt_username.Text = ""
                txt_new_username.Text = ""
                txt_new_password.Text = ""
                txt_username.Focus()
                If CN.State = ConnectionState.Open Then CN.Close()
            End If
            CN.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    '******************** CODE FOR CLEARALL BUTTON ****************

    Private Sub btn_clearall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_clearall.Click
        txt_username.Text = ""
        txt_password.Text = ""
        txt_new_username.Text = ""
        txt_new_password.Text = ""
        txt_username.Focus()
    End Sub

    '******************** CODE FOR CANCEL BUTTON ****************

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        Me.Close()
        txt_username.Text = ""
        txt_password.Text = ""
        txt_new_username.Text = ""
        txt_new_password.Text = ""
        txt_username.Focus()

    End Sub

    Private Sub txt_password_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_password.TextChanged

    End Sub
End Class