Imports System.Data
Imports System.Data.SqlClient
Public Class add_stud_admission_form

    '******************** CREATING CONNECTION ****************

    Dim CN As New SqlConnection("server=AMIRRESHI-PC\SQLSERVER05;initial catalog=Coleg_RS;integrated security=true")
    Public value As Double = 0
    Public test As Double = 0
    Public total As Double = 0

    '*************** ADMISSION FORM LOAD ****************

    Public Sub add_stud_admission_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txt_admission_no.Text = test + 1
        cmb_joining_class.SelectedIndex = 0
        txt_exam_passed.Text = "12th"

        Dim dt As Integer
        dt = Val(Now.Year)
        cmb_session.Text = dt.ToString + "-" + (dt + 1).ToString


        Dim command As New SqlCommand("select admission_no from admission", CN)
        Dim dr As SqlDataReader
        Try
            If CN.State = ConnectionState.Open Then CN.Close()
            CN.Open()
            dr = command.ExecuteReader
            While (dr.Read = True)
                value = Val(dr.Item("admission_no"))
                If value > test Then
                    test = value
                    txt_admission_no.Text = test + 1

                End If
            End While
            CN.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
       
    End Sub

    '*************** CLEARALL FUNCTION ****************

    Public Sub clear_all()
        cmb_joining_class.SelectedIndex = 0
        txt_exam_passed.Text = "12th"
        txt_student_ist_name.Text = ""
        txt_student_last_name.Text = ""
        txt_fathers_name.Text = ""
        txt_mothers_name.Text = ""
        msk_cell_no.Text = ""
        Dim dt As Integer
        dt = Val(Now.Year)
        cmb_session.Text = dt.ToString + "-" + (dt + 1).ToString
        txt_address.Text = ""
        cmb_state.Text = "Select"
        cmb_city.Text = "Select"
        txt_pin_no.Text = ""
        msk_email.Text = ""
        PictureBox1.ImageLocation = ""
        cmb_joining_class.Focus()

    End Sub

    '*************** CODE FOR PICTURE ****************

    Private Sub btn_pic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pic.Click

        Dim filename As String
        PictureBox1.ImageLocation = ""
        OpenFileDialog1.Filter = "image files (*.jpeg,*.jpg)|*.jpg"
        OpenFileDialog1.InitialDirectory = "~\stud_reg_systm\coleg_reg_systm\Resources\"

        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then

            filename = OpenFileDialog1.FileName

            Dim cmd As New SqlCommand("select picture from admission", CN)
            Dim dr3 As SqlDataReader
            Try
                CN.Open()
                dr3 = cmd.ExecuteReader
                While (dr3.Read = True)
                    If (dr3.Item(0).ToString = filename) Then
                        OpenFileDialog1.FileName = ""
                        MessageBox.Show("This picture already exists", "PICTURE ALREADY EXISTS...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        CN.Close()
                        PictureBox1.ImageLocation = ""
                        Exit Sub
                    End If

                End While
                CN.Close()
                PictureBox1.ImageLocation = filename
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try


            'PictureBox1.Refresh()
            'PictureBox1.Image = _
            'Image.FromFile("C:\Users\AMIRRESHI\Pictures\tht.jpg")
        End If

    End Sub

    '*************** CODE FOR NEXT BUTTON ****************

    Private Sub btn_next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_next.Click

        fee_details_form.txt_admission_no.Text = Me.txt_admission_no.Text
        fee_details_form.cmb_class.Text = Me.cmb_joining_class.Text
        fee_details_form.txt_name.Text = Me.txt_student_ist_name.Text & " " & Me.txt_student_last_name.Text
        fee_details_form.txt_fathers_name.Text = Me.txt_fathers_name.Text
        fee_details_form.cmb_session.Text = Me.cmb_session.Text

        Dim CMD As New SqlCommand("select tution_fee,library_fee , university_fee , other_charges ,total_fee from fee", CN)

        If CN.State = ConnectionState.Open Then CN.Close()

        Try

            CN.Open()
            Dim DR As SqlDataReader
            DR = CMD.ExecuteReader
            If DR.Read = True Then
                fee_details_form.lbl_tution_fee.Text = DR.Item(0).ToString
                fee_details_form.lbl_library_fee.Text = DR.Item(1).ToString
                fee_details_form.lbl_university_fee.Text = DR.Item(2).ToString
                fee_details_form.lbl_tother_charges_fee.Text = DR.Item(3).ToString
                fee_details_form.lbl_total_fee.Text = DR.Item(4).ToString
                total = Val(DR.Item(4))
            End If
            CN.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        fee_details_form.ShowDialog()
        fee_details_form.txt_paid_fee.Focus()
        txt_admission_no.Text = test + 1


    End Sub


    '*************** CALLING FUNCTION FOR CLEARALL BUTTON ************

    Private Sub btn_clear_all_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_clear_all.Click
        clear_all()
    End Sub

    '*************** CODE FOR CANCEL BUTTON ****************

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        'If MessageBox.Show("Do You Really Want To Cancel Student Admission ?", "EXIT..", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
        Me.Close()
        clear_all()
        coleg_main_form.Focus()

        'End If
    End Sub

    '*************** CODE FOR SELECTVALUE CHANGE EVENT ****************

    Private Sub cmb_joining_class_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_joining_class.SelectedValueChanged
        Select Case cmb_joining_class.Text
            Case "BCA IST YEAR"
                txt_exam_passed.Text = "12th"
            Case "BCA 2ND YEAR"
                txt_exam_passed.Text = "BCA IST YEAR"
            Case "BCA 3RD YEAR"
                txt_exam_passed.Text = "BCA 2ND YEAR"
        End Select
    End Sub

    'Private Sub txt_email_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_email.KeyDown
    '    Select Case e.KeyCode
    '        Case Keys.A To Keys.Z, Keys.Space, Keys.Back
    '        Case Keys.D2
    '        Case Keys.NumLock
    '        Case Keys.NumPad0 To Keys.NumPad9
    '        Case Keys.Shift

    '        Case Else
    '            e.SuppressKeyPress = True
    '            Beep()

    '    End Select
    'End Sub

    '*************** CODE FOR VALIDATION ****************

    Private Sub alphabet(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        
        Select Case e.KeyCode
            Case Keys.A To Keys.Z
            Case Keys.Back
            Case Keys.Space
            Case Keys.ShiftKey
            Case Keys.CapsLock
            Case Keys.Left, Keys.Right
            Case Keys.ControlKey
            Case Else

                e.SuppressKeyPress = True
                Beep()

        End Select
    End Sub

    '********** CALLING ALPHABET FUNCTION FOR VALIDATION ************

    Private Sub txt_student_ist_name_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_student_ist_name.KeyDown
        alphabet(e, e)

    End Sub

    Private Sub txt_student_last_name_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_student_last_name.KeyDown
        alphabet(e, e)
    End Sub

    Private Sub txt_fathers_name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_fathers_name.KeyDown
        alphabet(e, e)
    End Sub

    Private Sub txt_mothers_name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_mothers_name.KeyDown
        alphabet(e, e)
    End Sub

    '*************** CODE FOR VALIDATING PINNO ****************

    Private Sub txt_pin_no_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_pin_no.KeyDown

        Select Case e.KeyCode
            Case Keys.Back
            Case Keys.NumLock
            Case Keys.D0 To Keys.D9
            Case Keys.NumPad0 To Keys.NumPad9
            Case Keys.Left, Keys.Right
            Case Keys.ControlKey


            Case Else
                e.SuppressKeyPress = True

                Beep()

        End Select
    End Sub
End Class
