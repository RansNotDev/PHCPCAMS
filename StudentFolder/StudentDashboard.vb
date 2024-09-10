Imports System.Globalization
Imports System.IO
Imports MySql.Data.MySqlClient
Imports PHCPCAMS.LoginStudent

Public Class StudentDashboard
    Dim connectionString As String = "server=localhost;database=phcpcams;user id=root;password=;"
    Dim connection As New MySqlConnection(connectionString)

    'for global variable declaration
    Private Shared LoggedInStudentID

    'Timer
    Dim UpdateInterval As Integer = 10000
    Private WithEvents updateTimer As New Timer()

    Private Sub StudentDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabControl1.Appearance = TabAppearance.FlatButtons
        TabControl1.ItemSize = New Size(0, 1)
        TabControl1.SizeMode = TabSizeMode.Fixed

        DisplayStudentFullName()
        lblStudentidInfo.Text = $"{LoginStudent.GlobalVariables.loggedInStudentID}"
        'For timer
        updateTimer.Interval = UpdateInterval
        updateTimer.Start()
        UpdateTimeIfSubjectStartsNow()
        Timer1.Start()
        AttendanceList()
    End Sub
    Private Sub DisplayStudentFullName()
        Try
            connection.Open()

            Using cmd As New MySqlCommand("SELECT firstname, lastname, image FROM tbl_students WHERE student_id = @student_id", connection)
                cmd.Parameters.AddWithValue("@student_id", LoginStudent.GlobalVariables.loggedInStudentID)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    Dim firstName As String = reader("firstname").ToString()
                    Dim lastName As String = reader("lastname").ToString()
                    Dim imageData As Byte() = DirectCast(reader("image"), Byte())

                    ' Display the student's full name
                    lblname.Text = $"{firstName} {lastName}"

                    ' Display the image if available
                    If imageData IsNot Nothing AndAlso imageData.Length > 0 Then
                        Using ms As New MemoryStream(imageData)
                            PictureBox1.Image = Image.FromStream(ms)
                        End Using
                    Else
                        PictureBox1.Image = My.Resources.personsetting64px
                    End If
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while retrieving student information. Please try again." & vbCrLf & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click, btnProfile.Click
        Dim clickedButton As Button = DirectCast(sender, Button)
        Select Case clickedButton.Name
            Case "btnDashboard"
                TabControl1.SelectedTab = TabPage1
            Case "btnProfile"
                TabControl1.SelectedTab = TabPage2
        End Select
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        UpdateTimeIfSubjectStartsNow()
        'get the current time and date
        lbldashboardtime.Text = DateTime.Now.ToString("hh:mm:ss tt dddd-MMMM-dd-yyyy")
    End Sub

    Private Sub UpdateTimeIfSubjectStartsNow()
        Dim currentTime As TimeSpan = DateTime.Now.TimeOfDay
        Dim query As String = "SELECT teacher_id, subject_name, subject_timestart, subject_timeend, firstname, lastname  FROM tbl_teacher"
        Try
            If connection.State <> ConnectionState.Open Then
                connection.Open()
            End If
            Using cmd As New MySqlCommand(query, connection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    Dim teacherId As String = reader("teacher_id").ToString()
                    Dim subjectName As String = reader("subject_name").ToString()
                    Dim startTime As TimeSpan = TimeSpan.Parse(reader("subject_timestart").ToString())
                    Dim endTime As TimeSpan = TimeSpan.Parse(reader("subject_timeend").ToString())
                    Dim TeacherFName As String = reader("firstname").ToString()
                    Dim TeacherLName As String = reader("lastname").ToString()
                    If currentTime >= startTime AndAlso currentTime < endTime Then
                        UpdateTime(startTime)
                        txtTeacherid.Text = teacherId
                        txtSubjectName.Text = subjectName
                        txtEndTime.Text = endTime.ToString("hh\:mm\:ss")
                        txtTeacherfname.Text = TeacherFName
                        txtTeacherLname.Text = TeacherLName
                        Exit Sub
                    End If
                End While
                ClearTextBoxes()
            End Using
        Catch ex As Exception
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub UpdateTime(subjectStartTime As TimeSpan)
        Dim currentTime As String = DateTime.Now.Date.Add(subjectStartTime).ToString("HH:mm:ss")
        txtStartTime.Text = currentTime
    End Sub


    Private Sub ClearTextBoxes()
        txtTeacherid.Clear()
        txtSubjectName.Clear()
        txtStartTime.Clear()
        txtEndTime.Clear()
        txtTeacherfname.Clear()
        txtTeacherLname.Clear()
    End Sub

    Private Sub btnTimeIn_Click(sender As Object, e As EventArgs) Handles btnTimeIn.Click

        Dim hasTimedIn As Boolean = CheckIfStudentTimedIn()

        If hasTimedIn Then
            MessageBox.Show("You have already timed in for the day.")
            Return
        End If

        Dim startTime As DateTime = DateTime.ParseExact(txtStartTime.Text, "HH:mm:ss", CultureInfo.InvariantCulture)
        Dim endTime As DateTime = DateTime.ParseExact(txtEndTime.Text, "HH:mm:ss", CultureInfo.InvariantCulture)

        Dim timeDifference As TimeSpan = DateTime.Now - startTime

        Dim onTimeThreshold As TimeSpan = TimeSpan.FromMinutes(15)

        Dim remarks As String = ""

        If timeDifference <= onTimeThreshold Then
            remarks = "On Time"
            MessageBox.Show("You are on time!")
        ElseIf timeDifference > onTimeThreshold Then
            remarks = "Late"
            MessageBox.Show("You are late!")
        Else
            remarks = "Absent"
        End If
        If (txtTeacherid.Text = "" Or txtSubjectName.Text = "" Or txtStartTime.Text = "" Or txtEndTime.Text = "" Or txtTeacherfname.Text = "" Or txtTeacherLname.Text = "") Then
            MessageBox.Show("You dont Have Class Today")
            Return
        End If

        Try
            connection.Open()
            Using cmd As New MySqlCommand("INSERT INTO tbl_attendance (student_id, subject_name, date, timestart,timeend, remarks, teacher, timein,teacher_id) VALUES (@student_id, @subject_name, @date, @timestart,@timeend, @remarks, @teacher, @timein,@teacher_id)", connection)
                cmd.Parameters.AddWithValue("@student_id", LoginStudent.GlobalVariables.loggedInStudentID)
                cmd.Parameters.AddWithValue("@teacher_id", txtTeacherid.Text)
                cmd.Parameters.AddWithValue("@subject_name", txtSubjectName.Text)
                cmd.Parameters.AddWithValue("@date", DateTime.Now.Date)
                cmd.Parameters.AddWithValue("@timestart", startTime)
                cmd.Parameters.AddWithValue("@timeend", endTime)
                cmd.Parameters.AddWithValue("@remarks", remarks)
                cmd.Parameters.AddWithValue("@teacher", txtTeacherfname.Text + " " + txtTeacherLname.Text)
                cmd.Parameters.AddWithValue("@timein", DateTime.Now)
                cmd.ExecuteNonQuery()
            End Using
            MessageBox.Show("Attendance recorded successfully!")
            AttendanceList()
        Catch ex As Exception
            MessageBox.Show("An error occurred while logging in. Please try again." & vbCrLf & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub
    Private Function CheckIfStudentTimedIn() As Boolean
        Try
            connection.Open()
            Using cmd As New MySqlCommand("SELECT COUNT(*) FROM tbl_attendance WHERE student_id = @student_id AND timein IS NOT NULL AND timestart <= @currentTime AND timeend >= @currentTime", connection)
                cmd.Parameters.AddWithValue("@student_id", LoginStudent.GlobalVariables.loggedInStudentID)
                cmd.Parameters.AddWithValue("@currentTime", DateTime.Now.TimeOfDay)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return count > 0
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while checking if the student timed in. Please try again." & vbCrLf & ex.Message)
        Finally
            connection.Close()
        End Try
        Return False
    End Function




    Private Sub btnTimeout_Click(sender As Object, e As EventArgs) Handles btnTimeout.Click

        Dim hasTimedIn As Boolean = CheckIfStudentTimedIn()

        If Not hasTimedIn Then
            MessageBox.Show("You need to time in before timing out.")
            Return
        End If

        Try
            connection.Open()

            Using cmd As New MySqlCommand("UPDATE tbl_attendance SET timeout = @timeout WHERE student_id = @student_id AND date = @date", connection)
                cmd.Parameters.AddWithValue("@student_id", LoginStudent.GlobalVariables.loggedInStudentID)
                cmd.Parameters.AddWithValue("@date", DateTime.Now.Date)
                cmd.Parameters.AddWithValue("@timeout", DateTime.Now)
                cmd.ExecuteNonQuery()
            End Using
            MessageBox.Show("Time-out recorded successfully!")
            AttendanceList()
        Catch ex As Exception
            MessageBox.Show("An error occurred while recording time-out. Please try again." & vbCrLf & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub


    Private Sub AttendanceList()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT student_id, subject_name, date, timestart, timeend, remarks, teacher, teacher_id, timein, timeout FROM tbl_attendance WHERE student_id = @student_id"
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@student_id", GlobalVariables.loggedInStudentID)
                    Using da As New MySqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        da.Fill(dt)
                        dgvstudentattendance.DataSource = dt
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while retrieving attendance list. Please try again." & vbCrLf & ex.Message)
        End Try

    End Sub


    Private Sub EditInformation()
        Try
            connection.Open()

            Dim gender As String = ""
            If RBmale.Checked Then
                gender = "Male"
            ElseIf RBfemale.Checked Then
                gender = "Female"
            Else
                MsgBox("Please select gender first")
                Return ' Exit the method if gender is not selected
            End If

            ' Update student information
            Using cmd As New MySqlCommand("UPDATE tbl_students SET firstname = @firstname, middlename = @middlename, lastname = @lastname, gender = @gender, password = @password WHERE student_id = @student_id", connection)
                cmd.Parameters.AddWithValue("@firstname", txtFirstname.Text)
                cmd.Parameters.AddWithValue("@middlename", txtMiddlename.Text)
                cmd.Parameters.AddWithValue("@lastname", txtLastname.Text)
                cmd.Parameters.AddWithValue("@gender", gender)
                cmd.Parameters.AddWithValue("@password", txtPassword.Text)
                cmd.Parameters.AddWithValue("@student_id", LoginStudent.GlobalVariables.loggedInStudentID)
                cmd.ExecuteNonQuery()
            End Using

            ' Set profile picture if selected
            If OpenFileDialog1.FileName <> "" Then
                ' Read the image file into a byte array
                Dim imageBytes As Byte() = File.ReadAllBytes(OpenFileDialog1.FileName)

                ' Update student information with image
                Using cmd As New MySqlCommand("UPDATE tbl_students SET image = @image WHERE student_id = @student_id", connection)
                    cmd.Parameters.AddWithValue("@image", imageBytes)
                    cmd.Parameters.AddWithValue("@student_id", LoginStudent.GlobalVariables.loggedInStudentID)
                    cmd.ExecuteNonQuery()
                End Using

                ' Display the uploaded image in the PictureBox
                PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
                PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            End If

            MessageBox.Show("Student information updated successfully!")
        Catch ex As Exception
            MessageBox.Show("An error occurred while updating student information. Please try again." & vbCrLf & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        ' Show the file dialog to choose a profile picture
        OpenFileDialog1.Filter = "Image Files (*.jpg, *.png, *.bmp)|*.jpg;*.png;*.bmp"
        OpenFileDialog1.Title = "Select Profile Picture"
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Call the method to edit information and set the profile picture
        EditInformation()
        'clear all fields
        txtFirstname.Clear()
        txtMiddlename.Clear()
        txtLastname.Clear()
        txtPassword.Clear()
        RBmale.Checked = False
        RBfemale.Checked = False

    End Sub


    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Close()
            LoginStudent.Show()
        End If
    End Sub
End Class