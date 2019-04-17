Imports System.Data
Imports System.Data.SqlClient
Public Class add_stud_library_form

    '******************** CREATING CONNECTION ****************

    Dim CN As New SqlConnection("server=FAIZAN-PC\SQLSERVER05;initial catalog=student_registration;integrated security=true")

    '*********** CODE FOR LIBRARY FORM LOAD ****************

    Private Sub add_stud_library_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_admission_no.Focus()

    End Sub

    '***************** CODE FOR GO BUTTON ****************

    Private Sub btn_go_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_go.Click
        ListBox1.Items.Clear()
        Dim str(4) As String
        Dim cmd As New SqlCommand("select * from debit where admission_no = @admno", CN)
        cmd.Parameters.AddWithValue("@admno", Val(txt_admission_no.Text))
        Dim dr As SqlDataReader

        Try
            CN.Open()
            dr = cmd.ExecuteReader
            If (dr.Read = False) Then
                MessageBox.Show("Record not found", "ERROR...", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                Exit Sub
            Else
                For i As Integer = 1 To 4
                    str(i - 1) = dr.Item(i).ToString
                Next
            End If

            CN.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        For i As Integer = 0 To 3
            Dim cmd1 As New SqlCommand("select * from books where isbn = @isbn", CN)
            cmd1.Parameters.AddWithValue("@isbn", Val(str(i)))

            Try

                CN.Open()
                dr = cmd1.ExecuteReader
                While (dr.Read = True)
                    ListBox1.Items.Add(dr.Item(0).ToString & "  " & dr.Item(1).ToString)

                End While
                CN.Close()
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        Next

        Dim cmd2 As New SqlCommand("select picture from admission where admission_no = @txt_admission", CN)

        cmd2.Parameters.AddWithValue("@txt_admission", txt_admission_no.Text)

        Try

            CN.Open()
            Dim DR2 As SqlDataReader
            DR2 = cmd2.ExecuteReader
            If DR2.Read = True Then
                PictureBox1.ImageLocation = DR2.Item("picture").ToString
            End If
            CN.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try


    End Sub

    '*************** CODE FOR EXIT BUTTON ****************

    Private Sub btn_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    '********** CODE FOR VALIDATING ADMISSION TEXTBOX *************

    Private Sub txt_admission_no_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_admission_no.KeyDown
        Select Case e.KeyCode
            Case Keys.Back
            Case Keys.NumPad0 To Keys.NumPad9, Keys.NumLock
            Case Keys.Left, Keys.Right
            Case Keys.D0 To Keys.D9

            Case Else

                e.SuppressKeyPress = True
                Beep()
        End Select
    End Sub

    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txt_admission_no.Focus()

    End Sub
End Class
