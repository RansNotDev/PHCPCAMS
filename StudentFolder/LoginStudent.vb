Imports System.IO
Imports MySql.Data.MySqlClient

Public Class LoginStudent
    ' Connection string for MySQL
    Dim connectionString As String = "server=localhost;user id=root;password=;database=phcpcams"
    Dim connection As New MySqlConnection(connectionString)

    Public Class GlobalVariables
        Public Shared loggedInStudentID As String
    End Class

    Private Sub LoginStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim studentId As String = txtStudentId.Text
        Dim password As String = txtPassword.Text

        Try
            connection.Open()
            Using cmd As New MySqlCommand("SELECT * FROM tbl_students WHERE student_id = @student_id", connection)
                cmd.Parameters.AddWithValue("@student_id", studentId)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        ' Use String.Equals for case-sensitive comparison
                        If String.Equals(password, reader("password").ToString(), StringComparison.Ordinal) Then
                            GlobalVariables.loggedInStudentID = studentId
                            StudentDashboard.Show()
                            Me.Hide()
                            txtStudentId.Clear()
                            txtPassword.Clear()
                            PictureBox2.Image = Nothing
                        Else
                            'make the error message 5 seconds only then clear

                            lblerrormessage.Text = "Invalid student ID or password."
                            errortimer.Interval = 2000
                            ' Start the timer
                            errortimer.Start()
                        End If
                    Else
                        lblerrormessage.Text = "Invalid student ID or password."
                        errortimer.Interval = 2000
                        ' Start the timer
                        errortimer.Start()
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("An error occurred while logging in. Please try again.")
        Finally
            connection.Close()
        End Try
    End Sub
    Private Sub errortimer_Tick(sender As Object, e As EventArgs) Handles errortimer.Tick
        lblerrormessage.Text = ""

        ' Stop the timer
        errortimer.Stop()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Display day of the week
        lblday.Text = Date.Now.ToString("dddd")

        ' Display the current morning, afternoon, or evening
        Dim currentHour As Integer = Date.Now.Hour
        If currentHour >= 5 AndAlso currentHour < 12 Then
            lblmorning.Text = "Morning"
        ElseIf currentHour >= 12 AndAlso currentHour < 18 Then
            lblmorning.Text = "Afternoon"
        Else
            lblmorning.Text = "Evening"
        End If

        ' Display other date and time components
        lblhour.Text = Date.Now.ToString("hh:mm:ss")
        lblam.Text = Date.Now.ToString("tt")
        lblmonth.Text = Date.Now.ToString("MMMM dd, yyyy")

    End Sub

    Private Sub DisplayPicture(imageData As Byte())
        If imageData IsNot Nothing AndAlso imageData.Length > 0 Then
            Try
                Using stream As New MemoryStream(imageData)
                    Dim originalImage As New Bitmap(stream)
                    PictureBox2.Image = New Bitmap(originalImage, PictureBox2.Width, PictureBox2.Height)
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading image: " & ex.Message)
                DisplayDefaultPicture()
            End Try
        Else
            DisplayDefaultPicture()
        End If
    End Sub
    Private Sub DisplayDefaultPicture()
        PictureBox2.Image = My.Resources.personsetting64px
    End Sub
    Private Sub txtStudentid_TextChanged(sender As Object, e As EventArgs) Handles txtStudentId.TextChanged
        RetrieveAndDisplayPicture()
    End Sub
    Private Sub RetrieveAndDisplayPicture()
        Dim studentId As String = txtStudentId.Text
        If Not String.IsNullOrEmpty(studentId) Then
            Using cmd As New MySqlCommand("SELECT image FROM tbl_students WHERE student_id = @student_id", connection)
                cmd.Parameters.AddWithValue("@student_id", studentId)
                Try
                    connection.Open()
                    Dim imageData As Byte() = DirectCast(cmd.ExecuteScalar(), Byte())
                    DisplayPicture(imageData)
                Catch ex As Exception
                    MessageBox.Show("An error occurred: " & ex.Message)
                Finally
                    connection.Close()
                End Try
            End Using
        Else
            DisplayDefaultPicture()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txtStudentid_GotFocus(sender As Object, e As EventArgs) Handles txtStudentId.GotFocus
        If txtStudentId.Text = "Enter Student ID" Then
            txtStudentId.Text = ""
        End If
    End Sub

    Private Sub txtStudentid_LostFocus(sender As Object, e As EventArgs) Handles txtStudentId.LostFocus
        If txtStudentId.Text = "" Then
            txtStudentId.Text = "Enter Student ID"
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to go in the Welcome Page?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then

            WelcomePage.Show()
            Me.Hide()
        End If
    End Sub
End Class