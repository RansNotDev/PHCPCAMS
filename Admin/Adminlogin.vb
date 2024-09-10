Imports MySql.Data.MySqlClient

Public Class Adminlogin
    Dim connectionString As String = "server=localhost;user id=root;password=;database=phcpcams"
    Dim connection As New MySqlConnection(connectionString)

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        WelcomePage.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'get the username and password from the textbox of database  admin and make it also case sensitive
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text
        Try
            connection.Open()
            Using cmd As New MySqlCommand("SELECT * FROM tbl_admin WHERE username = @username", connection)
                cmd.Parameters.AddWithValue("@username", username)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        ' Use String.Equals for case-sensitive comparison
                        If String.Equals(password, reader("password").ToString(), StringComparison.Ordinal) Then
                            Dashboard.Show()
                            Me.Hide()
                            txtUsername.Clear()
                            txtPassword.Clear()
                        Else
                            'make the error message 5 seconds only then clear

                            lblerrormessage.Text = "Invalid username or password."
                            errortimer.Interval = 2000
                            ' Start the timer
                            errortimer.Start()
                        End If
                    Else
                        lblerrormessage.Text = "Invalid username or password."
                        errortimer.Interval = 2000
                        ' Start the timer
                        errortimer.Start()
                    End If
                End Using
            End Using
        Catch ex As Exception

        End Try
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub
End Class