
Public Class splashscreen

    Dim i As Single = 0
    Dim j As Single = 1

    '******************** SPLASHSCREEN FORM LOAD ****************

    Private Sub splashscreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Opacity = i
        Timer1.Enabled = True
    End Sub

    '******************** CODE FOR TIMER ****************

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If i < 1 Then
            i += 0.005
            Me.Opacity = i
            Me.Refresh()
        Else
            Timer1.Enabled = False
            Me.Hide()
            login_form.Show()

        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
