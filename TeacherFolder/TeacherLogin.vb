
Imports System.IO
Imports MySql.Data.MySqlClient
Public Class TeacherLogin
    Dim connectionString As String = "server=localhost;user id=root;password=;database=phcpcams"
    Dim connection As New MySqlConnection(connectionString)

    Public Class GlobalVariables
        Public Shared loggedInTeacherID
    End Class


    Private Sub TeacherLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim teacherId As String = txtTeacherID.Text
        Dim password As String = txtTeacherPassword.Text

        Try
            connection.Open()
            Using cmd As New MySqlCommand("SELECT * FROM tbl_teacher WHERE teacher_id = @teacher_id", connection)
                cmd.Parameters.AddWithValue("@teacher_id", teacherId)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        ' Use String.Equals for case-sensitive comparison
                        If String.Equals(password, reader("password").ToString(), StringComparison.Ordinal) Then
                            GlobalVariables.loggedInTeacherID = teacherId
                            TeacherDashboard.Show()
                            Me.Hide()
                            txtTeacherID.Clear()
                            txtTeacherPassword.Clear()
                            PictureBox2.Image = Nothing
                        Else
                            'make the error message 5 seconds only then clear

                            lblerror.Text = "Invalid teacher ID or password."
                            Timer1.Interval = 2000
                            ' Start the timer
                            Timer1.Start()
                        End If
                    Else
                        lblerror.Text = "Invalid teacher ID or password."
                        Timer1.Interval = 2000
                        ' Start the timer
                        Timer1.Start()
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("An error occurred while logging in. Please try again.")
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
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

    Private Sub CBshowpassword_CheckedChanged(sender As Object, e As EventArgs) Handles CBshowpassword.CheckedChanged
        If CBshowpassword.Checked Then
            txtTeacherPassword.UseSystemPasswordChar = False
        Else
            txtTeacherPassword.UseSystemPasswordChar = True
        End If
    End Sub
    Private Sub txtTeacherID_GotFocus(sender As Object, e As EventArgs) Handles txtTeacherID.GotFocus
        If txtTeacherID.Text = "Enter Student ID" Then
            txtTeacherID.Text = ""
        End If
    End Sub

    Private Sub txtStudentid_LostFocus(sender As Object, e As EventArgs) Handles txtTeacherID.LostFocus
        If txtTeacherID.Text = "" Then
            txtTeacherID.Text = "Enter Student ID"
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        WelcomePage.Show()
        Me.Hide()
    End Sub
    Private Sub DisplayPicture(imageData As Byte())
        If imageData IsNot Nothing AndAlso imageData.Length > 0 Then
            Try
                Using stream As New MemoryStream(imageData)
                    Dim originalImage As New Bitmap(stream)
                    PictureBox3.Image = New Bitmap(originalImage, PictureBox3.Width, PictureBox3.Height)
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
        PictureBox3.Image = My.Resources.teacherrr
    End Sub
    Private Sub txtTeacherID_TextChanged(sender As Object, e As EventArgs) Handles txtTeacherID.TextChanged
        RetrieveAndDisplayPicture()
    End Sub
    Private Sub RetrieveAndDisplayPicture()
        Dim teacherID As String = txtTeacherID.Text
        If Not String.IsNullOrEmpty(teacherID) Then
            Using cmd As New MySqlCommand("SELECT image FROM tbl_teacher WHERE teacher_id = @teacher_id", connection)
                cmd.Parameters.AddWithValue("@teacher_id", teacherID)
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
End Class