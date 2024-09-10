Public Class WelcomePage
    Private Sub StudentPanel_Click(sender As Object, e As EventArgs) Handles StudentPanel.Click
        LoginStudent.Show()
        Me.Hide()
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        LoginStudent.Show()
        Me.Hide()
    End Sub

    Private Sub TeacherPanel_Click(sender As Object, e As EventArgs) Handles TeacherPanel.Click
        TeacherLogin.Show()
        Me.Hide()

    End Sub
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        TeacherLogin.Show()
        Me.Hide()
    End Sub
    Private Sub AdminPanel_Click(sender As Object, e As EventArgs) Handles AdminPanel.Click
        Adminlogin.Show()
        Me.Hide()
    End Sub
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Adminlogin.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class