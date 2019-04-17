Imports System.Data.SqlClient
Public Class login_form

    '******************** CREATING CONNECTION ****************

    Dim CN As New SqlConnection("server=FAIZAN-PC\SQLSERVER;initial catalog=student_registration;integrated security=true")

    '******************** LOGIN FORM LOAD ****************

    Private Sub login_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_password.Text = ""
        txt_username.Text = ""
        txt_username.Focus()
    End Sub

    '******************** CODE FOR OK BUTTON ****************

    Private Sub btn_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ok.Click
        Dim CMD As New SqlCommand("select username,password from login where username=@username and password=@password", CN)
        CMD.Parameters.AddWithValue("@username", txt_username.Text)
        CMD.Parameters.AddWithValue("@password", txt_password.Text)

        Try
            CN.Open()
            Dim DR As SqlDataReader
            DR = CMD.ExecuteReader

            If txt_username.Text <> "" And txt_password.Text <> "" Then
                If DR.Read = True Then
                    
                    If CN.State = ConnectionState.Open Then CN.Close()

                    coleg_main_form.Show()
                    Me.Hide()

                Else
                    MessageBox.Show("Acces denied.. Username and password did not match", "ERROR...", _
                MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txt_password.Text = ""
                    txt_username.Text = ""
                    txt_username.Focus()
                End If
            Else
                If txt_username.Text = "" Or txt_password.Text = "" Then _
                MessageBox.Show("Acces denied.. Please retype username and password", "ERROR...", _
                MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_password.Text = ""
                txt_username.Text = ""
                txt_username.Focus()
                If CN.State = ConnectionState.Open Then CN.Close()
            End If
            CN.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    '******************** CODE FOR CANCEL BUTTON ****************

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        If MessageBox.Show("Do You Really Want To Exit?", "EXIT..", _
 MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            splashscreen.Close()
        Else
            txt_password.Text = ""
            txt_username.Text = ""
            txt_username.Focus()
        End If
    End Sub

    '*********** CODE FOR CHANGING USERNAME & PASSWORD ***********

    Private Sub btn_change_unam_pnam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_change_unam_pnam.Click
        Me.Hide()
        change_ur_ps.ShowDialog()
        Me.Show()
        txt_password.Text = ""
        txt_username.Text = ""
        txt_username.Focus()

    End Sub

    '*************** CODE FOR VALIDATING USERNAME **************

    Private Sub txt_username_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_username.KeyDown

        Dim str As String
        str = txt_username.Text
        If str.Length = 12 Then
            Select Case e.KeyCode
                Case Keys.Back

                Case Else
                    e.SuppressKeyPress = True
                    Beep()

            End Select

        End If
        Select Case e.KeyCode
            Case Keys.A To Keys.Z
            Case Keys.Back
            Case Keys.Space
            Case Keys.NumLock
            Case Keys.NumPad0 To Keys.NumPad9
            Case Keys.ShiftKey
            Case Keys.Left, Keys.Right
            Case Keys.CapsLock
            Case Keys.OemPeriod, Keys.D0 To Keys.D9

            Case Else

                e.SuppressKeyPress = True
                Beep()
        End Select
    End Sub

    '*************** CODE FOR VALIDATING PASSWORD *************

    Private Sub txt_password_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_password.KeyDown

        Dim str As String
        str = txt_password.Text
        If str.Length = 12 Then
            Select Case e.KeyCode
                Case Keys.Back

                Case Else
                    e.SuppressKeyPress = True
                    Beep()

            End Select

        End If

        Select Case e.KeyCode
            Case Keys.A To Keys.Z
            Case Keys.Back
            Case Keys.Space
            Case Keys.NumLock
            Case Keys.NumPad0 To Keys.NumPad9
            Case Keys.CapsLock
            Case Keys.OemPeriod
            Case Keys.ShiftKey
            Case Keys.Left, Keys.Right
            Case Keys.D0 To Keys.D9

            Case Else

                e.SuppressKeyPress = True
                Beep()
        End Select
    End Sub

    Private Sub txt_username_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_username.TextChanged

    End Sub
End Class
