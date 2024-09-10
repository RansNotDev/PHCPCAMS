Imports MySql.Data.MySqlClient
Imports System.IO
Imports Mysqlx
Imports PHCPCAMS.TeacherLogin

Public Class TeacherDashboard
    'get the global variable from teacher login
    Private Shared loggedInTeacherID
    Dim connectionString As String = "server=localhost;database=phcpcams;user id=root;password=;"
    Dim connection As New MySqlConnection(connectionString)

    Private Sub TeacherDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabControl1.Appearance = TabAppearance.FlatButtons
        TabControl1.ItemSize = New Size(0, 1)
        TabControl1.SizeMode = TabSizeMode.Fixed

        'total students
        lblTeacherInfo.Text = $"{TeacherLogin.GlobalVariables.loggedInTeacherID}"
        DashboardTotalStudent()
        StudentsList()
        attendanceHistory()
        StudentsLateForToday()
        StudentsOnTimeForToday()
        SubjectLogsForToday()
        AttendanceHistory()
        TodayAttendance()
        Timer1.Start()

        EditTeacherInformation()
        DisplayTeacherFullName()
    End Sub
    Private Sub DisplayTeacherFullName()
        Try
            connection.Open()

            Using cmd As New MySqlCommand("SELECT firstname, lastname, image FROM tbl_teacher WHERE teacher_id = @teacher_id", connection)
                cmd.Parameters.AddWithValue("@teacher_id", TeacherLogin.GlobalVariables.loggedInTeacherID)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    Dim firstName As String = reader("firstname").ToString()
                    Dim lastName As String = reader("lastname").ToString()
                    Dim imageData As Byte() = DirectCast(reader("image"), Byte())

                    ' Display the student's full name
                    lblteachername.Text = $"{firstName} {lastName}"

                    ' Display the image if available
                    If imageData IsNot Nothing AndAlso imageData.Length > 0 Then
                        Using ms As New MemoryStream(imageData)
                            ' Create a new Bitmap directly from the MemoryStream
                            Dim studentImage As New Bitmap(ms)

                            ' Set the PictureBox image to the new Bitmap
                            PictureBox1.Image = studentImage
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


    Private Sub Clickedbutton_Click(sender As Object, e As EventArgs) Handles btndashboard.Click, btnaddstudents.Click, btnattendance.Click, btnattendancehistory.Click, btnProfile.Click
        Dim clickbutton As Button = DirectCast(sender, Button)
        Select Case clickbutton.Name
            Case "btndashboard"
                TabControl1.SelectedTab = TabPage1
            Case "btnaddstudents"
                TabControl1.SelectedTab = TabPage2
            Case "btnattendance"
                TabControl1.SelectedTab = TabPage3
            Case "btnattendancehistory"
                TabControl1.SelectedTab = TabPage4
            Case "btnProfile"
                TabControl1.SelectedTab = TabPage5
        End Select

    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Close()
            TeacherLogin.Show()
        End If
    End Sub


    'Teacher Dashboard here nigga
    Private Sub DashboardTotalStudent()
        Try
            Using connection As New MySqlConnection("server=localhost;user id=root;password=;database=phcpcams;")
                connection.Open()
                Using command As New MySqlCommand("SELECT COUNT(*) FROM tbl_students", connection)

                    Dim totalRecords As Integer = Convert.ToInt32(command.ExecuteScalar())
                    lblstudentstotal.Text = $"{totalRecords}"
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error retrieving total records: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    'add students here nigga

    Private Sub btnAddstudent_Click(sender As Object, e As EventArgs) Handles btnAddstudent.Click
        Dim connectionString As String = "server = localhost;user id=root;password=;database=phcpcams;"
        Try
            Dim gender As String = ""

            If RBmale.Checked Then
                gender = "Male"
            ElseIf RBfemale.Checked Then
                gender = "Female"
            End If

            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim sql As String = "INSERT INTO tbl_students(student_id,firstname,middlename,lastname,password,gender)VALUES(@student_id,@firstname,@middlename,@lastname,@password,@gender)"

                Using command As New MySqlCommand(sql, connection)

                    command.Parameters.AddWithValue("@student_id", txtStudentID.Text)
                    command.Parameters.AddWithValue("@firstname", txtfirstname.Text)
                    command.Parameters.AddWithValue("@middlename", txtMiddlename.Text)
                    command.Parameters.AddWithValue("@lastname", txtLastname.Text)
                    command.Parameters.AddWithValue("@password", txtstudentPassword.Text)
                    command.Parameters.AddWithValue("@gender", gender)
                    command.ExecuteNonQuery()
                    MessageBox.Show("Student Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    DashboardTotalStudent()
                    StudentsList()
                    attendanceHistory()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error adding student: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'edit teacher her neigga

    Private Sub btnupdatestudent_Click(sender As Object, e As EventArgs) Handles btnupdatestudent.Click
        Try

            Dim gender As String = ""

            If RBmale.Checked Then
                gender = "Male"
            ElseIf RBfemale.Checked Then
                gender = "Female"
            End If
            Dim connectionString As String = "server = localhost;user id=root;password=;database=phcpcams;"
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim sql As String = "UPDATE tbl_students SET firstname=@firstname, middlename=@middlename, lastname=@lastname, password=@password, gender=@gender WHERE student_id=@student_id"
                Using command As New MySqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@student_id", txtStudentID.Text)
                    command.Parameters.AddWithValue("@firstname", txtfirstname.Text)
                    command.Parameters.AddWithValue("@middlename", txtMiddlename.Text)
                    command.Parameters.AddWithValue("@lastname", txtLastname.Text)
                    command.Parameters.AddWithValue("@password", txtstudentPassword.Text)
                    command.Parameters.AddWithValue("@gender", gender)
                    command.ExecuteNonQuery()
                    MessageBox.Show("Student Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    DashboardTotalStudent()
                    StudentsList()
                    attendanceHistory()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating student: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub SLtxtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            Dim keyword As String = txtSearch.Text.Trim().ToLower()
            If String.IsNullOrEmpty(keyword) Then
                StudentsList()
            Else
                ApplyFilter()
            End If
        Catch ex As Exception
            MessageBox.Show("Error filtering data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ApplyFilter()
        Dim keyword As String = txtSearch.Text.Trim().ToLower()
        Dim originalTable As DataTable = DirectCast(STUDENTDataGridView.DataSource, DataTable)
        Dim filteredTable As DataTable = originalTable.Clone()

        For Each row As DataRow In originalTable.Rows
            Dim selectedColumns As String() = {"student_id", "firstname", "lastname"}
            If selectedColumns.Any(Function(col) row(col).ToString().ToLower().Contains(keyword)) Then
                filteredTable.ImportRow(row)
            End If
        Next
        STUDENTDataGridView.DataSource = filteredTable
    End Sub

    Private Sub StudentsList()
        Using connection As New MySqlConnection("server=localhost;user id=root;password=;database=phcpcams;")
            Using command As New MySqlCommand("SELECT student_id, firstname, middlename, lastname, gender,image FROM tbl_students", connection)
                Using adapter As New MySqlDataAdapter(command)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    STUDENTDataGridView.DataSource = table
                End Using
            End Using
        End Using
    End Sub

    Private Sub StudentsOnTimeForToday()
        Try
            Dim currentDate As String = DateTime.Now.ToString("yyyy-MM-dd")

            Using connection As New MySqlConnection("server=localhost;user id=root;password=;database=phcpcams;")
                connection.Open()

                Using command As New MySqlCommand("SELECT COUNT(*) AS remarks FROM tbl_attendance WHERE teacher_id = @teacher_id AND remarks='On Time' AND date = @currentDate", connection)
                    command.Parameters.AddWithValue("@teacher_id", GlobalVariables.loggedInTeacherID)
                    command.Parameters.AddWithValue("@currentDate", currentDate)

                    Dim OntimeStudents As Integer = Convert.ToInt32(command.ExecuteScalar())
                    lblontimecount.Text = $"{OntimeStudents}"
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error retrieving on-time records: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub StudentsLateForToday()
        Try
            Dim currentDate As String = DateTime.Now.ToString("yyyy-MM-dd")

            Using connection As New MySqlConnection("server=localhost;user id=root;password=;database=phcpcams;")
                connection.Open()

                Using command As New MySqlCommand("SELECT COUNT(*) AS remarks FROM tbl_attendance WHERE teacher_id = @teacher_id AND remarks='Late' AND date = @currentDate", connection)
                    command.Parameters.AddWithValue("@teacher_id", GlobalVariables.loggedInTeacherID)
                    command.Parameters.AddWithValue("@currentDate", currentDate)

                    Dim LateStudents As Integer = Convert.ToInt32(command.ExecuteScalar())
                    lblLatecount.Text = $"{LateStudents}"
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error retrieving late records: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub SubjectLogsForToday()
        Try
            Dim currentDate As String = DateTime.Now.ToString("yyyy-MM-dd")

            Using connection As New MySqlConnection("server=localhost;user id=root;password=;database=phcpcams;")
                connection.Open()

                Using command As New MySqlCommand("SELECT student_id, subject_name, timein, timeout FROM tbl_attendance WHERE teacher_id = @teacher_id AND date = @currentDate", connection)
                    command.Parameters.AddWithValue("@teacher_id", GlobalVariables.loggedInTeacherID)
                    command.Parameters.AddWithValue("@currentDate", currentDate)

                    Using adapter As New MySqlDataAdapter(command)
                        Dim table As New DataTable()
                        adapter.Fill(table)
                        dgvSubjectLogs.DataSource = table
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"An error occurred while retrieving subject logs for today: {vbCrLf}{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub TodayAttendance()
        Try
            Dim currentDate As String = DateTime.Now.ToString("yyyy-MM-dd")

            Using connection As New MySqlConnection("server=localhost;user id=root;password=;database=phcpcams;")
                connection.Open()

                Using command As New MySqlCommand("SELECT student_id, subject_name, timein, timeout FROM tbl_attendance WHERE teacher_id = @teacher_id AND date = @currentDate", connection)
                    command.Parameters.AddWithValue("@teacher_id", GlobalVariables.loggedInTeacherID)
                    command.Parameters.AddWithValue("@currentDate", currentDate)

                    Using adapter As New MySqlDataAdapter(command)
                        Dim table As New DataTable()
                        adapter.Fill(table)
                        DataGridView2.DataSource = table
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"An error occurred while retrieving today's attendance: {vbCrLf}{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub AttendanceHistory()
        Try
            ' Create the connection and open it
            Using connection As New MySqlConnection("server=localhost;user id=root;password=;database=phcpcams;")
                connection.Open()

                ' Create the command with parameters
                Using command As New MySqlCommand("SELECT * FROM tbl_attendance WHERE teacher_id = @teacher_id", connection)
                    ' Add parameters
                    command.Parameters.AddWithValue("@teacher_id", GlobalVariables.loggedInTeacherID)

                    ' Create and fill the data adapter
                    Using adapter As New MySqlDataAdapter(command)
                        Dim table As New DataTable()
                        adapter.Fill(table)

                        ' Set the data source for the DataGridView
                        dgvAttendancehistory.DataSource = table
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"An error occurred while retrieving attendance history: {vbCrLf}{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Get the current date and time
        lbldashboardtime.Text = DateTime.Now.ToString("hh:mm:ss tt dddd-MMMM-dd-yyyy")
    End Sub

    Private Sub EditTeacherInformation()
        Try
            connection.Open()

            Dim gender As String = ""
            If RBteacherMale.Checked Then
                gender = "Male"
            ElseIf RBteacherFemale.Checked Then
                gender = "Female"
            Else
                Return ' Exit the method
            End If

            ' Update teacher information
            Using cmd As New MySqlCommand("UPDATE tbl_teacher SET firstname = @firstname, middlename = @middlename, lastname = @lastname, gender = @gender, password = @password WHERE teacher_id = @teacher_id", connection)
                cmd.Parameters.AddWithValue("@firstname", txtTeacherfname.Text)
                cmd.Parameters.AddWithValue("@middlename", txtTeacherMiddlename.Text)
                cmd.Parameters.AddWithValue("@lastname", txtTeacherlastname.Text)
                cmd.Parameters.AddWithValue("@gender", gender)
                cmd.Parameters.AddWithValue("@password", txtTeacherPassword.Text)
                cmd.Parameters.AddWithValue("@teacher_id", GlobalVariables.loggedInTeacherID)


            End Using




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
        EditTeacherInformation()
        'clear all fields
        txtTeacherfname.Clear()
        txtTeacherMiddlename.Clear()
        txtTeacherlastname.Clear()
        txtTeacherPassword.Clear()
        RBteacherMale.Checked = False
        RBteacherFemale.Checked = False


    End Sub


    Private Sub PrintDataGridView(dataGridView As DataGridView)
        Dim printDialog As New PrintDialog()
        Dim printDocument As New Printing.PrintDocument()

        printDialog.Document = printDocument

        If printDialog.ShowDialog() = DialogResult.OK Then
            Dim printArea As RectangleF = printDocument.DefaultPageSettings.PrintableArea
            Dim totalHeight As Integer = 0
            Dim gridHeight As Integer = dataGridView.Height
            Dim rowsPerPage As Integer = CInt(Math.Floor(printArea.Height / dataGridView.Rows(0).Height))
            Dim rowIndex As Integer = 0

            AddHandler printDocument.PrintPage,
                Sub(sender As Object, e As Printing.PrintPageEventArgs)
                    Dim bmp As New Bitmap(dataGridView.Width, dataGridView.Height)
                    dataGridView.DrawToBitmap(bmp, New Rectangle(0, 0, dataGridView.Width, dataGridView.Height))

                    Dim ratio As Single = CSng(bmp.Width / dataGridView.Width)
                    Dim newHeight As Integer = CInt(gridHeight * ratio)

                    If totalHeight + newHeight > printArea.Height Then
                        e.HasMorePages = True
                        totalHeight = 0
                    Else
                        e.HasMorePages = False
                    End If

                    e.Graphics.DrawImage(bmp, 10, 10 + totalHeight, bmp.Width, newHeight)
                    totalHeight += newHeight

                    ' Print the next set of rows
                    For i As Integer = 0 To rowsPerPage - 1
                        If rowIndex < dataGridView.Rows.Count Then
                            rowIndex += 1
                            Dim rowHeight As Integer = dataGridView.Rows(rowIndex - 1).Height
                            totalHeight += rowHeight
                        End If
                    Next
                End Sub

            printDocument.Print()
        End If
    End Sub

    Private Sub btnPrintAttendance_Click(sender As Object, e As EventArgs) Handles btnPrintAttendance.Click
        PrintDataGridView(DataGridView2)
    End Sub

    Private Sub btnPrintAttendanceHistory_Click(sender As Object, e As EventArgs) Handles btnPrintAttendanceHistory.Click
        PrintDataGridView(dgvAttendancehistory)
    End Sub
End Class