Imports System.Data
Imports System.Data.SqlClient
Public Class coleg_main_form

    '******************** CREATING CONNECTION ****************

    Dim CN As New SqlConnection("server=FAIZAN-PC\SQLSERVER05;initial catalog=student_registration;integrated security=true")

    '**************** DECLARING PUBLIC VARIABLES ****************


    Public add_stud_2nd_yr_num As Integer
    Public add_stud_3rd_yr_num As Integer

    Public add_act_num As Integer
    Public add_2nd_yr_act_num As Integer
    Public add_3rd_yr_act_num As Integer

    Public view_stud_num As Integer
    Public view_stud_2nd_yr_num As Integer
    Public view_stud_3rd_yr_num As Integer

    Public view_stud_act_num As Integer
    Public view_stud_2nd_yr_act_num As Integer
    Public view_stud_3rd_yr_act_num As Integer

    Public view_stud_fee_num As Integer
    Public view_stud_2nd_yr_fee_num As Integer
    Public view_stud_3rd_yr_fee_num As Integer


    Public edit_stud_det_num As Integer
    Public edit_stud_2nd_yr_num As Integer
    Public edit_stud_3rd_yr_num As Integer

    Public edit_stud_act_num As Integer
    Public edit_stud_2nd_yr_act_num As Integer
    Public edit_stud_3rd_yr_act_num As Integer


    Public edit_stud_fee_num As Integer
    Public edit_stud_2nd_yr_fee_num As Integer
    Public edit_stud_3rd_yr_fee_num As Integer

    Public del_num As Integer

    Dim i As Integer = Me.Width
    Dim flag As Boolean = False

    '******************** CODE FOR MARQUE ****************

    Private Sub coleg_main_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer2.Enabled = True
        Label2.Left = Me.Width - Label2.Width
    End Sub

    '********** CODE FOR STUDENT ADMISSION FORM ************

    Private Sub StudentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentToolStripMenuItem.Click
        add_stud_admission_form.ShowDialog()
    End Sub

    '********** CODE FOR STUDENT LIBRARY FORM ***********

    Private Sub StudLibraryStatusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudLibraryStatusToolStripMenuItem.Click
        add_stud_library_form.Show()
        add_stud_library_form.txt_admission_no.Focus()
    End Sub


    '********** CODE FOR STUDENT ACTIVITY FORM ***********

    Private Sub StudActivitiesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudActivitiesToolStripMenuItem.Click
        add_act_num = Val(InputBox("Enter the admission Number to add student activities ?"))
        add_stud_activity.Show()
    End Sub

    '********** CODE TO VIEW STUDENT DETAIL FORM ***********

    Private Sub StudDetailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudDetailToolStripMenuItem.Click
        view_stud_num = Val(InputBox("Enter the admission Number to view student detail?"))
        view_stud_detail.Show()

    End Sub

    '********** CODE TO VIEW STUDENT ACTIVITY FORM ***********

    Private Sub StudActivityToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudActivityToolStripMenuItem.Click

        view_stud_activity.Show()

    End Sub

    '********** CODE TO VIEW STUDENT FEE FORM ***********

    Private Sub StudFeeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudFeeToolStripMenuItem.Click
        view_stud_fee_num = Val(InputBox("Enter the admission Number to view student fee details ?"))
        view_stud_fee.Show()
    End Sub

    '********** CODE TO EDIT STUDENT DETAIL FORM ***********

    Private Sub StudDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudDetailsToolStripMenuItem.Click
        edit_stud_det_num = Val(InputBox("Enter the admission Number to update the student details ?"))
        edit_stud_details_form.Show()
    End Sub

    '********** CODE TO EDIT STUDENT ACTIVITY FORM ***********

    Private Sub StudActivitiesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudLibraryToolStripMenuItem1.Click
        edit_stud_act_num = Val(InputBox("Enter the admission Number to update the student activities ?"))
        edit_stud_activity.Show()
    End Sub

    '********** CODE TO EDIT STUDENT FEE FORM ***********

    Private Sub StudFeeToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudFeeToolStripMenuItem1.Click
        edit_stud_fee_num = Val(InputBox("Enter the admission Number to update the fee details ?"))
        edit_stud_fee.Show()

    End Sub

    '********** CODE TO DELETE STUDENT ***********

    Private Sub StudentToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentToolStripMenuItem1.Click
        del_num = Val(InputBox("Enter the admission Number to delete the student ?"))
        del_stud_form.Show()
    End Sub
    
    '********** CODE FOR USER SETTING FORM ***********

    Private Sub UserSettingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserSettingToolStripMenuItem.Click
        change_ur_ps.ShowDialog()
    End Sub

    '********** CODE TO EXIT COLLEG MAIN FORM ***********

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        If MessageBox.Show("Do You Really Want To Exit?", "EXIT..", _
MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            'Me.Close()
            change_ur_ps.Close()
            login_form.Close()
            splashscreen.Close()

        End If

    End Sub

    '********** CODE FOR DATE AND TIME ***********

    Private Sub Timer2_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Dim dateresults As Date
        dateresults = Now
        Label1.Text = dateresults.ToLongDateString
        Label3.Text = dateresults.ToLongTimeString
    End Sub

    '************ CODE FOR CAPTURING FORM CLOSING EVENT **************
    Private Sub coleg_main_form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Do You Really Want To Exit?", "Message....", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            change_ur_ps.Close()
            login_form.Close()
            splashscreen.Close()

        Else
            e.Cancel = True

        End If

    End Sub

    '******************** CODE FOR TIMER ****************

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If flag = False Then
            If Label2.Left > 0 Then
                Label2.Left -= 1
            Else
                flag = True
            End If
        Else
            If Label2.Left < Me.Width - Label2.Width Then
                Label2.Left += 1
            Else
                flag = False
            End If
        End If
    End Sub

   
    Private Sub Bca2ndYearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bca2ndYearToolStripMenuItem.Click
        add_stud_2nd_yr_num = Val(InputBox("Enter the admission Number to add 2nd year student details ?"))
        add_bca_2nd_yr.ShowDialog()
    End Sub

    Private Sub Bca3rdYearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bca3rdYearToolStripMenuItem.Click
        add_stud_3rd_yr_num = Val(InputBox("Enter the admission Number to add 3rd year student details ?"))
        add_bca_3rd_yr.ShowDialog()
    End Sub

    Private Sub Bca2ndYearToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bca2ndYearToolStripMenuItem1.Click

        view_stud_2nd_yr_num = Val(InputBox("Enter the admission Number to view 2nd year student details ?"))
        view_stud_2nd_yr.Show()

    End Sub

    Private Sub Bca3ndYearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bca3ndYearToolStripMenuItem.Click

        view_stud_3rd_yr_num = Val(InputBox("Enter the admission Number to view 3rd year student details ?"))
        view_stud_3rd_yr.Show()
    End Sub

    Private Sub Bca2ndYearToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bca2ndYearToolStripMenuItem2.Click

        edit_stud_2nd_yr_num = Val(InputBox("Enter the admission Number to update 2nd year student details ?"))
        edit_stud_2nd_yr_detail.Show()

    End Sub

    Private Sub Bca3ndYearToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bca3ndYearToolStripMenuItem1.Click

        edit_stud_3rd_yr_num = Val(InputBox("Enter the admission Number to update 3rd year student details ?"))
        edit_stud_3rd_yr_detail.Show()


    End Sub

    Private Sub DepartmentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepartmentsToolStripMenuItem.Click

    End Sub

    Private Sub Bca2ndYearToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bca2ndYearToolStripMenuItem3.Click

        add_2nd_yr_act_num = Val(InputBox("Enter the admission Number to add 2nd year student activities ?"))
        add_2nd_yr_activity.Show()
    End Sub

    Private Sub Bca3rdYearToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bca3rdYearToolStripMenuItem1.Click

        add_3rd_yr_act_num = Val(InputBox("Enter the admission Number to add 3rd year student activities ?"))
        add_3rd_yr_activity.Show()
    End Sub

    Private Sub Bca2ndYearToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bca2ndYearToolStripMenuItem4.Click

        view_stud_2nd_yr_act_num = Val(InputBox("Enter the admission Number to view 2nd year student activities ?"))
        view_stud_2nd_yr_activity.Show()

    End Sub

    Private Sub Bca3rdYearToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bca3rdYearToolStripMenuItem2.Click
        view_stud_3rd_yr_act_num = Val(InputBox("Enter the admission Number to view 3rd year student activities ?"))
        view_stud_3rd_yr_activity.Show()
    End Sub

    Private Sub Bca2ndYearToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bca2ndYearToolStripMenuItem5.Click
        edit_stud_2nd_yr_act_num = Val(InputBox("Enter the admission Number to update 2nd year student activities ?"))
        edit_stud_2nd_yr_activity.Show()
    End Sub

    Private Sub Bca3rdYearToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bca3rdYearToolStripMenuItem3.Click
        edit_stud_3rd_yr_act_num = Val(InputBox("Enter the admission Number to update 3rd year student activities ?"))
        edit_stud_3rd_yr_activity.Show()
    End Sub

    Private Sub Bca2ndYearToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bca2ndYearToolStripMenuItem6.Click
        view_stud_2nd_yr_fee_num = Val(InputBox("Enter the admission Number to view 2nd year student fee ?"))
        view_stud_2nd_yr_fee.Show()

    End Sub

    Private Sub Bca3rdYearToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bca3rdYearToolStripMenuItem4.Click
        view_stud_3rd_yr_fee_num = Val(InputBox("Enter the admission Number to view 3rd year student fee ?"))
        view_stud_3rd_yr_fee.Show()
    End Sub

    Private Sub Bca2ndYearToolStripMenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bca2ndYearToolStripMenuItem7.Click
        edit_stud_2nd_yr_fee_num = Val(InputBox("Enter the admission Number to update 2nd year student fee ?"))
        edit_stud_2nd_yr_fee.Show()
    End Sub

    Private Sub Bca3rdYearToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bca3rdYearToolStripMenuItem5.Click
        edit_stud_3rd_yr_fee_num = Val(InputBox("Enter the admission Number to update 3rd year student fee ?"))
        edit_stud_3rd_yr_fee.Show()

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class