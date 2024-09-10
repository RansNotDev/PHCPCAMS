Imports System.Globalization
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Dashboard

    Public ConnectionString As String = "server=localhost;user id=root;password=;database=phcpcams;"
    Public Connection As MySqlConnection


    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Tabconntrol appearance settings

        TabControl1.Appearance = TabAppearance.FlatButtons
        TabControl1.ItemSize = New Size(0, 1)
        TabControl1.SizeMode = TabSizeMode.Fixed


        'Load All Students
        StudentsList()
        StudentTotalRecords()
        MaleStudentTotalRecords()
        FemaleStudentTotalRecords()
        GeneratedStudentID()
        DashboardTotalStudent()

        'Load all teachers
        TeachersList()
        TeacherTotalRecords()
        FemaleTeacherTotalRecords()
        MaleTeacherTotalRecords()
        GeneratedTeacherID()
        DashboardTeacherTotal()

        'Load All Subject
        SubjectList()
        DashboardAllSubjects()
        SubjectLogs()
        LoadTimeValues()
        LoadSubjectNames()
        CountAllSubjects()
        ClearsubjectFields()

        'Attendances
        AttendanceHistory()
        CurrentAttendance()
        AllTeacher()
        AllStudents()

        'Timer
        Timer1.Start()
    End Sub
    'Functions for the buttons
    Private Sub Button_Click(sender As Object, e As EventArgs) Handles btnHome.Click, btnStudentlist.Click, btnTeacherlist.Click, btnSubjectlist.Click, btnReports.Click
        Dim clickedButton As Button = DirectCast(sender, Button)

        Select Case clickedButton.Name
            Case "btnHome"
                TabControl1.SelectedTab = TabPage1
            Case "btnStudentlist"
                TabControl1.SelectedTab = TabPage2
            Case "btnTeacherlist"
                TabControl1.SelectedTab = TabPage3
            Case "btnSubjectlist"
                TabControl1.SelectedTab = TabPage4
            Case "btnReports"
                TabControl1.SelectedTab = TabPage5

        End Select

    End Sub

    'Add Student Here Nigga

    'Functions to generate randon Student Id in the textbox
    Private Sub GeneratedStudentID()
        Dim prefix As String = "c21-"
        Dim FirstPasrt As String = randomIdNumber(4)
        Dim SecondPart As String = randomIdNumber(3)
        Dim generatedID As String = $"{prefix}{FirstPasrt}-{SecondPart}"
        SLtxtStudentID.Text = generatedID
    End Sub

    'Random numbers
    Private Function randomIdNumber(digits As Integer) As String
        Dim random As New Random()
        Dim randomNumber As Integer = random.Next(10 ^ (digits - 1), 10 ^ digits)
        Return randomNumber.ToString().PadLeft(digits, "0"c)
    End Function

    Private Sub SLbtnNewStudent_Click(sender As Object, e As EventArgs) Handles SLbtnNewStudent.Click
        SLtxtfirstname.Clear()
        SLtxtMiddlename.Clear()
        SLtxtLastname.Clear()
        SLRBmale.Checked = False
        SLRBfemale.Checked = False
        GeneratedStudentID()
    End Sub

    Private Sub SLbtnAddStudent_Click(sender As Object, e As EventArgs) Handles SLbtnAddStudent.Click
        Dim connectionString As String = "server = localhost;user id=root;password=;database=phcpcams;"
        Try
            Dim SLgender As String = ""

            If SLRBmale.Checked Then
                SLgender = "Male"
            ElseIf SLRBfemale.Checked Then
                SLgender = "Female"
            End If

            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim sql As String = "INSERT INTO tbl_students(student_id,firstname,middlename,lastname,password,gender)VALUES(@student_id,@firstname,@middlename,@lastname,@password,@gender)"

                Using command As New MySqlCommand(sql, connection)

                    command.Parameters.AddWithValue("@student_id", SLtxtStudentID.Text)
                    command.Parameters.AddWithValue("@firstname", SLtxtfirstname.Text)
                    command.Parameters.AddWithValue("@middlename", SLtxtMiddlename.Text)
                    command.Parameters.AddWithValue("@lastname", SLtxtLastname.Text)
                    command.Parameters.AddWithValue("@password", SLtxtPassword.Text)

                    command.Parameters.AddWithValue("@gender", SLgender)

                    command.ExecuteNonQuery()

                    MessageBox.Show("Student Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    StudentsList()
                    StudentTotalRecords()
                    MaleStudentTotalRecords()
                    FemaleStudentTotalRecords()
                    GeneratedStudentID()
                    DashboardTotalStudent()
                    ClearStudentInputFields()
                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show("Error adding student: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SLbtnEditSatudent_Click(sender As Object, e As EventArgs) Handles SLbtnEditSatudent.Click
        Try
            Dim studentID As String = SLtxtStudentID.Text
            Dim SLfirstname As String = SLtxtfirstname.Text
            Dim SLmiddlename As String = SLtxtMiddlename.Text
            Dim SLlastname As String = SLtxtLastname.Text
            Dim SLpassword As String = SLtxtPassword.Text
            Dim SLgender As String = ""

            If SLRBmale.Checked Then
                SLgender = "Male"
            ElseIf SLRBfemale.Checked Then
                SLgender = "Female"
            End If

            Dim connectionString As String = "server = localhost;user id=root;password=;database=phcpcams;"
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim sql As String = "UPDATE tbl_students SET firstname=@firstname, middlename=@middlename, lastname=@lastname, password=@password, gender=@gender WHERE student_id=@student_id"

                Using command As New MySqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@student_id", studentID)
                    command.Parameters.AddWithValue("@firstname", SLfirstname)
                    command.Parameters.AddWithValue("@middlename", SLmiddlename)
                    command.Parameters.AddWithValue("@lastname", SLlastname)
                    command.Parameters.AddWithValue("@password", SLpassword)
                    command.Parameters.AddWithValue("@gender", SLgender)

                    command.ExecuteNonQuery()

                    MessageBox.Show("Student Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    StudentsList()
                    StudentTotalRecords()
                    MaleStudentTotalRecords()
                    FemaleStudentTotalRecords()
                    GeneratedStudentID()
                    DashboardTotalStudent()
                    ClearStudentInputFields()
                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show("Error updating student: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SLbtnDeleteStudent_Click(sender As Object, e As EventArgs) Handles SLbtnDeleteStudent.Click
        Try
            Dim studentID As String = SLtxtStudentID.Text

            Dim connectionString As String = "server = localhost;user id=root;password=;database=phcpcams;"
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim sql As String = "DELETE FROM tbl_students WHERE student_id=@student_id"

                Using command As New MySqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@student_id", studentID)

                    command.ExecuteNonQuery()

                    MessageBox.Show("Student Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    StudentsList()
                    StudentTotalRecords()
                    MaleStudentTotalRecords()
                    FemaleStudentTotalRecords()
                    GeneratedStudentID()
                    DashboardTotalStudent()
                    ClearStudentInputFields()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error deleting student: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ClearStudentInputFields()
        SLtxtStudentID.Clear()
        GeneratedStudentID()
        SLtxtfirstname.Clear()
        SLtxtMiddlename.Clear()
        SLtxtLastname.Clear()
        SLRBmale.Checked = False
        SLRBfemale.Checked = False
        SLtxtPassword.Clear()
    End Sub
    Private Sub SLtxtSearch_TextChanged(sender As Object, e As EventArgs) Handles SLtxtSearch.TextChanged
        Try
            Dim keyword As String = SLtxtSearch.Text.Trim().ToLower()

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
        Dim keyword As String = SLtxtSearch.Text.Trim().ToLower()
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
            Using command As New MySqlCommand("SELECT student_id, firstname,middlename,lastname,gender,image FROM tbl_students", connection)
                Using adapter As New MySqlDataAdapter(command)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    STUDENTDataGridView.DataSource = table
                    STUDENTDataGridView.ForeColor = Color.Black
                End Using
            End Using
        End Using
    End Sub
    Private Sub DashboardTotalStudent()
        Try
            Using connection As New MySqlConnection("server=localhost;user id=root;password=;database=phcpcams;")
                connection.Open()
                Using command As New MySqlCommand("SELECT COUNT(*) FROM tbl_students", connection)
                    Dim totalRecords As Integer = Convert.ToInt32(command.ExecuteScalar())
                    lblDashboardStudent.Text = $"{totalRecords}"
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error retrieving total records: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub StudentTotalRecords()
        Try
            Using connection As New MySqlConnection("server=localhost;user id=root;password=;database=phcpcams;")
                connection.Open()
                Using command As New MySqlCommand("SELECT COUNT(*) FROM tbl_students", connection)
                    Dim totalRecords As Integer = Convert.ToInt32(command.ExecuteScalar())
                    SLlblRecords.Text = $"{totalRecords}"
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error retrieving total records: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MaleStudentTotalRecords()
        Try
            Using connection As New MySqlConnection("server=localhost;user id=root;password=;database=phcpcams;")
                connection.Open()
                Using command As New MySqlCommand("SELECT COUNT(*) FROM tbl_students WHERE gender = 'Male'", connection)
                    Dim totalMaleRecords As Integer = Convert.ToInt32(command.ExecuteScalar())
                    SLlblMale.Text = $"{totalMaleRecords}"
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error retrieving total male records: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FemaleStudentTotalRecords()
        Try
            Using connection As New MySqlConnection("server=localhost;user id=root;password=;database=phcpcams;")
                connection.Open()
                Using command As New MySqlCommand("SELECT COUNT(*) FROM tbl_students WHERE gender = 'Female'", connection)
                    Dim totalFemaleRecords As Integer = Convert.ToInt32(command.ExecuteScalar())
                    SLlblFemale.Text = $"{totalFemaleRecords}"
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error retrieving total female records: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub STUDENTDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles STUDENTDataGridView.CellClick
        If e.RowIndex >= 0 Then
            SLtxtStudentID.Text = STUDENTDataGridView.Rows(e.RowIndex).Cells("student_id").Value.ToString()
            SLtxtfirstname.Text = STUDENTDataGridView.Rows(e.RowIndex).Cells("firstname").Value.ToString()
            SLtxtMiddlename.Text = STUDENTDataGridView.Rows(e.RowIndex).Cells("middlename").Value.ToString()
            SLtxtLastname.Text = STUDENTDataGridView.Rows(e.RowIndex).Cells("lastname").Value.ToString()


            Dim gender As String = STUDENTDataGridView.Rows(e.RowIndex).Cells("gender").Value.ToString()
            If gender = "Male" Then
                SLRBmale.Checked = True
                SLRBfemale.Checked = False
            ElseIf gender = "Female" Then
                SLRBmale.Checked = False
                SLRBfemale.Checked = True
            End If
        End If
    End Sub

    'Add teacher here nigga

    Private Sub GeneratedTeacherID()
        Dim prefix As String = "t00-"
        Dim FirstPasrt As String = randomTeacherNumber(4)
        Dim SecondPart As String = randomTeacherNumber(3)
        Dim generatedTeacherID As String = $"{prefix}{FirstPasrt}-{SecondPart}"
        TLtxtteacherid.Text = generatedTeacherID
    End Sub
    Private Function randomTeacherNumber(digits As Integer) As String
        Dim random As New Random()
        Dim randomNumber As Integer = random.Next(10 ^ (digits - 1), 10 ^ digits)
        Return randomNumber.ToString().PadLeft(digits, "0"c)
    End Function

    Private Sub ClearTeacherInputFields()

        TLtxtteacherid.Clear()
        GeneratedTeacherID()
        TLtxtFirstname.Clear()
        TLtxtmiddlename.Clear()
        TLtxtlastname.Clear()
        TLRBmale.Checked = False
        TLRBfemale.Checked = False
        TLCBsubject_name.Items.Clear()
        CBtimestart.Items.Clear()
        CBtimeend.Items.Clear()
    End Sub

    Private Sub TLnewteacher_Click(sender As Object, e As EventArgs) Handles TLnewteacher.Click
        LoadSubjectNames() ' Load subject names before clearing
        ClearTeacherInputFields()
    End Sub

    Private Sub TLbtnAddTeacher_Click(sender As Object, e As EventArgs) Handles TLbtnAddTeacher.Click
        Try
            ' Retrieve input values
            Dim teacherID As String = TLtxtteacherid.Text
            Dim TLfirstname As String = TLtxtFirstname.Text
            Dim TLmiddlename As String = TLtxtmiddlename.Text
            Dim TLlastname As String = TLtxtlastname.Text
            Dim TLpassword As String = TLtxtpassword.Text
            Dim TLgender As String = If(TLRBmale.Checked, "Male", "Female")
            Dim selectedSubjectName As String = TLCBsubject_name.SelectedItem.ToString()
            Dim selectedTimeStart As String = CBtimestart.SelectedItem.ToString()
            Dim selectedTimeEnd As String = CBtimeend.SelectedItem.ToString()
            ' Convert selectedTimeStart and selectedTimeEnd to DateTime objects
            Dim startTime As DateTime = DateTime.Parse(selectedTimeStart)
            Dim endTime As DateTime = DateTime.Parse(selectedTimeEnd)

            ' Format the DateTime objects in 12-hour format with AM/PM
            selectedTimeStart = startTime.ToString("hh:mm tt")
            selectedTimeEnd = endTime.ToString("hh:mm tt")

            ' Check if the time range is available
            If Not IsTimeRangeAvailable(selectedTimeStart, selectedTimeEnd, "") Then
                MessageBox.Show("The selected time range is already occupied. Please choose a different time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Database connection string
            Dim connectionString As String = "server=localhost;user id=root;password=;database=phcpcams;"

            ' Insert the teacher into the database
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Use STR_TO_DATE function to convert the time to MySQL format
                Dim sql As String = "INSERT INTO tbl_teacher(teacher_id, firstname, middlename, lastname, password, gender, subject_name, subject_timestart, subject_timeend) " & "VALUES(@teacher_id, @firstname, @middlename, @lastname, @password, @gender, @subject_name, STR_TO_DATE(@subject_timestart, '%h:%i %p'), STR_TO_DATE(@subject_timeend, '%h:%i %p'))"

                Using cmd As New MySqlCommand(sql, connection)
                    cmd.Parameters.AddWithValue("@teacher_id", teacherID)
                    cmd.Parameters.AddWithValue("@firstname", TLfirstname)
                    cmd.Parameters.AddWithValue("@middlename", TLmiddlename)
                    cmd.Parameters.AddWithValue("@lastname", TLlastname)
                    cmd.Parameters.AddWithValue("@password", TLpassword)
                    cmd.Parameters.AddWithValue("@gender", TLgender)
                    cmd.Parameters.AddWithValue("@subject_name", selectedSubjectName)
                    cmd.Parameters.AddWithValue("@subject_timestart", selectedTimeStart)
                    cmd.Parameters.AddWithValue("@subject_timeend", selectedTimeEnd)

                    ' Execute the SQL command
                    cmd.ExecuteNonQuery()

                    ' Display success message
                    MessageBox.Show("Teacher Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Load subject names after adding a teacher
                    LoadSubjectNames()

                    ' Clear input fields
                    ClearTeacherInputFields()

                    ' Update teacher lists and totals
                    TeachersList()
                    TeacherTotalRecords()
                    FemaleTeacherTotalRecords()
                    MaleTeacherTotalRecords()
                    DashboardTeacherTotal()
                End Using
            End Using

        Catch ex As Exception
            ' Display error message if an exception occurs
            MessageBox.Show("Error adding teacher: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Function IsTimeRangeAvailable(timeStart As String, timeEnd As String, teacherID As String) As Boolean
        Try
            ' Convert time strings to DateTime for comparison
            Dim selectedTimeStart As DateTime = DateTime.ParseExact(timeStart, "hh:mm tt", CultureInfo.InvariantCulture)
            Dim selectedTimeEnd As DateTime = DateTime.ParseExact(timeEnd, "hh:mm tt", CultureInfo.InvariantCulture)

            Using connection As New MySqlConnection("server=localhost;user id=root;password=;database=phcpcams;")
                connection.Open()

                ' Check if the time range is available
                Using command As New MySqlCommand("SELECT COUNT(*) FROM tbl_teacher WHERE NOT ((subject_timeend <= @TimeStart) OR (subject_timestart >= @TimeEnd)) AND teacher_id <> @TeacherID", connection)
                    command.Parameters.AddWithValue("@TimeStart", selectedTimeStart.TimeOfDay)
                    command.Parameters.AddWithValue("@TimeEnd", selectedTimeEnd.TimeOfDay)
                    command.Parameters.AddWithValue("@TeacherID", teacherID)

                    Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                    Return count = 0
                End Using
            End Using
        Catch ex As Exception
            ' Handle the exception, e.g., display an error message or log the error
            MessageBox.Show("Error converting time: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False ' Indicate that the time range is not available (assuming an error means not available)
        End Try
    End Function

    Private Sub LoadSubjectNames()
        Dim connectionString As String = "server=localhost;user id=root;password=;database=phcpcams;"
        Try
            SubjectList()
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim sql As String = "SELECT DISTINCT subject_name FROM tbl_subjects"
                Using command As New MySqlCommand(sql, connection)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        TLCBsubject_name.Items.Clear()
                        While reader.Read()
                            TLCBsubject_name.Items.Add(reader("subject_name"))
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading subject names: " & ex.Message)
        End Try
    End Sub

    Private Sub CBsubject_name_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TLCBsubject_name.SelectedIndexChanged
        LoadTimeValues()
    End Sub

    Private Sub LoadTimeValues()
        Dim connectionString As String = "server=localhost;user id=root;password=;database=phcpcams;"
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                SubjectList()
                Dim sql As String = "SELECT subject_timestart, subject_timeend FROM tbl_subjects WHERE subject_name=@subject_name"
                Using command As New MySqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@subject_name", TLCBsubject_name.Text)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        CBtimestart.Items.Clear()
                        CBtimeend.Items.Clear()
                        While reader.Read()
                            CBtimestart.Items.Add(reader("subject_timestart"))
                            CBtimeend.Items.Add(reader("subject_timeend"))
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading time values: " & ex.Message)
        End Try
    End Sub

    ' Update button click event handler
    Private Sub TLeditteacher_Click(sender As Object, e As EventArgs) Handles TLeditteacher.Click
        Try
            ' Validate required fields
            If String.IsNullOrWhiteSpace(TLtxtteacherid.Text) OrElse
           String.IsNullOrWhiteSpace(TLtxtFirstname.Text) OrElse
           String.IsNullOrWhiteSpace(TLtxtmiddlename.Text) OrElse
           String.IsNullOrWhiteSpace(TLtxtlastname.Text) OrElse
           String.IsNullOrWhiteSpace(TLtxtpassword.Text) Then
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim teacherID As String = TLtxtteacherid.Text
            Dim TLfirstname As String = TLtxtFirstname.Text
            Dim TLmiddlename As String = TLtxtmiddlename.Text
            Dim TLlastname As String = TLtxtlastname.Text
            Dim TLpassword As String = TLtxtpassword.Text
            Dim TLgender As String = If(TLRBmale.Checked, "Male", "Female")
            Dim selectedSubjectName As String = If(TLCBsubject_name.SelectedItem IsNot Nothing, TLCBsubject_name.SelectedItem.ToString(), "")
            Dim selectedTimeStart As String = If(CBtimestart.SelectedItem IsNot Nothing, CBtimestart.SelectedItem.ToString(), "")
            Dim selectedTimeEnd As String = If(CBtimeend.SelectedItem IsNot Nothing, CBtimeend.SelectedItem.ToString(), "")

            ' Convert selectedTimeStart and selectedTimeEnd to DateTime objects
            Dim startTime As DateTime = DateTime.Parse(selectedTimeStart)
            Dim endTime As DateTime = DateTime.Parse(selectedTimeEnd)

            ' Format the DateTime objects in 12-hour format with AM/PM
            selectedTimeStart = startTime.ToString("hh:mm tt")
            selectedTimeEnd = endTime.ToString("hh:mm tt")

            Dim connectionString As String = "server=localhost;user id=root;password=;database=phcpcams;"
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim sql As String = "UPDATE tbl_teacher SET firstname = @firstname, middlename = @middlename, lastname = @lastname, password = @password, gender = @gender, subject_name = @subject_name, subject_timestart = @subject_timestart, subject_timeend = @subject_timeend WHERE teacher_id = @teacher_id"
                Using cmd As New MySqlCommand(sql, connection)
                    cmd.Parameters.AddWithValue("@teacher_id", teacherID)
                    cmd.Parameters.AddWithValue("@firstname", TLfirstname)
                    cmd.Parameters.AddWithValue("@middlename", TLmiddlename)
                    cmd.Parameters.AddWithValue("@lastname", TLlastname)
                    cmd.Parameters.AddWithValue("@password", TLpassword)
                    cmd.Parameters.AddWithValue("@gender", TLgender)
                    cmd.Parameters.AddWithValue("@subject_name", selectedSubjectName)
                    cmd.Parameters.AddWithValue("@subject_timestart", selectedTimeStart)
                    cmd.Parameters.AddWithValue("@subject_timeend", selectedTimeEnd)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Teacher Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    TeachersList()
                    FemaleTeacherTotalRecords()
                    MaleTeacherTotalRecords()
                    ClearTeacherInputFields()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating teacher: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    ' Delete button click event handler
    Private Sub TLdeleteteacher_Click(sender As Object, e As EventArgs) Handles TLdeleteteacher.Click
        Try
            Dim teacherID As String = TLtxtteacherid.Text

            Dim connectionString As String = "server=localhost;user id=root;password=;database=phcpcams;"
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim sql As String = "DELETE FROM tbl_teacher WHERE teacher_id = @teacher_id"
                Using cmd As New MySqlCommand(sql, connection)
                    cmd.Parameters.AddWithValue("@teacher_id", teacherID)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Teacher Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    TeachersList()
                    FemaleTeacherTotalRecords()
                    MaleTeacherTotalRecords()
                    DashboardTeacherTotal()
                    ClearTeacherInputFields()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error deleting teacher: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TLsearch_TextChanged(sender As Object, e As EventArgs) Handles TLsearch.TextChanged
        Try
            Dim keyword As String = TLsearch.Text.Trim().ToLower()
            If String.IsNullOrEmpty(keyword) Then
                TeachersList()
            Else
                ApplyTeacherFilter()
            End If
        Catch ex As Exception
            MessageBox.Show("Error filtering data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ApplyTeacherFilter()
        Dim keyword As String = TLsearch.Text.Trim().ToLower()
        Dim originalTable As DataTable = DirectCast(TLDataGridView.DataSource, DataTable)
        Dim filteredTable As DataTable = originalTable.Clone()

        For Each row As DataRow In originalTable.Rows
            Dim selectedColumns As String() = {"teacher_id", "firstname", "lastname"}
            If selectedColumns.Any(Function(col) row(col).ToString().ToLower().Contains(keyword)) Then
                filteredTable.ImportRow(row)
            End If
        Next
        TLDataGridView.DataSource = filteredTable
    End Sub
    Private Sub TeachersList()
        Try
            Using connection As New MySqlConnection("server=localhost;user id=root;password=;database=phcpcams;")
                Using command As New MySqlCommand("SELECT teacher_id, firstname, middlename, lastname, gender, subject_name, DATE_FORMAT(subject_timestart, '%h:%i %p') AS subject_timestart, DATE_FORMAT(subject_timeend, '%h:%i %p') AS subject_timeend FROM tbl_teacher", connection)
                    Using adapter As New MySqlDataAdapter(command)
                        Dim table As New DataTable()
                        adapter.Fill(table)
                        TLDataGridView.DataSource = table
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error retrieving teachers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TLDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TLDataGridView.CellClick
        If e.RowIndex >= 0 Then
            TLtxtteacherid.Text = TLDataGridView.Rows(e.RowIndex).Cells("teacher_id").Value.ToString()
            TLtxtFirstname.Text = TLDataGridView.Rows(e.RowIndex).Cells("TLfirstname").Value.ToString()
            TLtxtmiddlename.Text = TLDataGridView.Rows(e.RowIndex).Cells("TLmiddlename").Value.ToString()
            TLtxtlastname.Text = TLDataGridView.Rows(e.RowIndex).Cells("TLlastname").Value.ToString()

            Dim gender As String = TLDataGridView.Rows(e.RowIndex).Cells("TLgender").Value.ToString()
            If gender = "Male" Then
                SLRBmale.Checked = True
                SLRBfemale.Checked = False
            ElseIf gender = "Female" Then
                SLRBmale.Checked = False
                SLRBfemale.Checked = True
            End If
            TLCBsubject_name.SelectedItem = TLDataGridView.Rows(e.RowIndex).Cells("TLsubjectname").Value.ToString()
        End If
    End Sub

    Private Sub DashboardTeacherTotal()
        Try
            Using connection As New MySqlConnection("server=localhost;user id=root;password=;database=phcpcams;")
                connection.Open()
                Using command As New MySqlCommand("SELECT COUNT(*) FROM tbl_teacher", connection)
                    Dim totalRecords As Integer = Convert.ToInt32(command.ExecuteScalar())
                    lblDashboardTeacher.Text = $"{totalRecords}"
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error retrieving total records: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub TeacherTotalRecords()
        Try
            Using connection As New MySqlConnection("server=localhost;user id=root;password=;database=phcpcams;")
                connection.Open()

                Using command As New MySqlCommand("SELECT COUNT(*) FROM tbl_teacher", connection)
                    Dim totalRecords As Integer = Convert.ToInt32(command.ExecuteScalar())
                    TLlblrcords.Text = $"{totalRecords}"
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error retrieving total records: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MaleTeacherTotalRecords()
        Try
            Using connection As New MySqlConnection("server=localhost;user id=root;password=;database=phcpcams;")
                connection.Open()

                Using command As New MySqlCommand("SELECT COUNT(*) FROM tbl_teacher WHERE gender = 'Male'", connection)
                    Dim totalMaleRecords As Integer = Convert.ToInt32(command.ExecuteScalar())

                    TLlblmale.Text = $"{totalMaleRecords}"
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error retrieving total male records: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FemaleTeacherTotalRecords()
        Try
            Using connection As New MySqlConnection("server=localhost;user id=root;password=;database=phcpcams;")
                connection.Open()

                Using command As New MySqlCommand("SELECT COUNT(*) FROM tbl_teacher WHERE gender = 'Female'", connection)
                    Dim totalFemaleRecords As Integer = Convert.ToInt32(command.ExecuteScalar())
                    TLlblfemale.Text = $"{totalFemaleRecords}"
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error retrieving total female records: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub




    'Add SUbjects Here Nigga

    Private Sub btnAddSubject_Click(sender As Object, e As EventArgs) Handles btnAddSubject.Click
        Try
            Dim SubjectTimeStart As TimeSpan
            If Not dtpSubjectTimeStart.Value.Equals(Nothing) Then
                SubjectTimeStart = dtpSubjectTimeStart.Value.TimeOfDay
            Else
                MessageBox.Show("Please select a valid starting time for the subject.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim SubjectTimeEnd As TimeSpan
            If Not dtpSubjectTimeEnd.Value.Equals(Nothing) Then
                SubjectTimeEnd = dtpSubjectTimeEnd.Value.TimeOfDay
            Else
                MessageBox.Show("Please select a valid ending time for the subject.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Check if the time range is available
            If Not IsTimeRangeAvailable(SubjectTimeStart, SubjectTimeEnd, "") Then
                MessageBox.Show("The selected time range is already occupied. Please choose a different time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If Not SubjectExists(txtSubject_code.Text, txtsubjectname.Text, "") Then
                Using connection As New MySqlConnection("server=localhost;user id=root;password=;database=phcpcams;")
                    connection.Open()

                    Using command As New MySqlCommand("INSERT INTO tbl_subjects (subject_id, subject_code, subject_name, subject_timestart, subject_timeend) VALUES (@SubjectID, @SubjectCode, @SubjectName, @SubjectTimeStart, @SubjectTimeEnd)", connection)
                        command.Parameters.AddWithValue("@SubjectID", txtsubjectid.Text)
                        command.Parameters.AddWithValue("@SubjectCode", txtSubject_code.Text)
                        command.Parameters.AddWithValue("@SubjectName", txtsubjectname.Text)
                        command.Parameters.AddWithValue("@SubjectTimeStart", SubjectTimeStart)
                        command.Parameters.AddWithValue("@SubjectTimeEnd", SubjectTimeEnd)

                        command.ExecuteNonQuery()
                    End Using
                End Using

                MessageBox.Show("Subject added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                SubjectList() ' Refresh the subject list
                CountAllSubjects() ' Update the count
                DashboardAllSubjects() ' Update the dashboard count
                ClearsubjectFields() ' Clear the input fields
            Else
                MessageBox.Show("Subject with the same code or name already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show($"Error adding subject: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnUpdateSubject_Click(sender As Object, e As EventArgs) Handles btnUpdateSubject.Click
        Try
            Dim SubjectTimeStart As TimeSpan
            If Not dtpSubjectTimeStart.Value.Equals(Nothing) Then
                SubjectTimeStart = dtpSubjectTimeStart.Value.TimeOfDay
            Else
                MessageBox.Show("Please select a valid starting time for the subject.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim SubjectTimeEnd As TimeSpan
            If Not dtpSubjectTimeEnd.Value.Equals(Nothing) Then
                SubjectTimeEnd = dtpSubjectTimeEnd.Value.TimeOfDay
            Else
                MessageBox.Show("Please select a valid ending time for the subject.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Check if the time range is available
            If Not IsTimeRangeAvailable(SubjectTimeStart, SubjectTimeEnd, txtsubjectid.Text) Then
                MessageBox.Show("The selected time range is already occupied. Please choose a different time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Using connection As New MySqlConnection("server=localhost;user id=root;password=;database=phcpcams;")
                connection.Open()
                Using command As New MySqlCommand("UPDATE tbl_subjects SET subject_name = @SubjectName, subject_code = @SubjectCode, subject_timestart = @SubjectTimeStart, subject_timeend = @SubjectTimeEnd WHERE subject_id = @SubjectID", connection)
                    command.Parameters.AddWithValue("@SubjectName", txtsubjectname.Text)
                    command.Parameters.AddWithValue("@SubjectCode", txtSubject_code.Text)
                    command.Parameters.AddWithValue("@SubjectTimeStart", SubjectTimeStart)
                    command.Parameters.AddWithValue("@SubjectTimeEnd", SubjectTimeEnd)
                    command.Parameters.AddWithValue("@SubjectID", txtsubjectid.Text)

                    command.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Subject updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            SubjectList()
            CountAllSubjects()
            DashboardAllSubjects()
            ClearsubjectFields()

        Catch ex As Exception
            MessageBox.Show($"Error updating subject: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Function IsTimeRangeAvailable(timeStart As TimeSpan, timeEnd As TimeSpan, subjectID As String) As Boolean
        Using connection As New MySqlConnection("server=localhost;user id=root;password=;database=phcpcams;")
            connection.Open()

            Using command As New MySqlCommand("SELECT COUNT(*) FROM tbl_subjects WHERE NOT ((subject_timeend <= @TimeStart) OR (subject_timestart >= @TimeEnd)) AND subject_id <> @SubjectID", connection)
                command.Parameters.AddWithValue("@TimeStart", timeStart)
                command.Parameters.AddWithValue("@TimeEnd", timeEnd)
                command.Parameters.AddWithValue("@SubjectID", subjectID)

                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                Return count = 0
            End Using
        End Using
    End Function


    Private Function SubjectExists(subjectCode As String, subjectName As String, subjectID As String) As Boolean
        Using connection As New MySqlConnection("server=localhost;user id=root;password=;database=phcpcams;")
            connection.Open()
            Using command As New MySqlCommand("SELECT COUNT(*) FROM tbl_subjects WHERE (subject_code = @SubjectCode OR subject_name = @SubjectName) AND subject_id <> @SubjectID", connection)
                command.Parameters.AddWithValue("@SubjectCode", subjectCode)
                command.Parameters.AddWithValue("@SubjectName", subjectName)
                command.Parameters.AddWithValue("@SubjectID", subjectID)

                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                Return count > 0
            End Using
        End Using
    End Function

    Private Sub btnDeleteSubject_Click(sender As Object, e As EventArgs) Handles btnDeleteSubject.Click
        Try
            Using connection As New MySqlConnection("server=localhost;user id=root;password=;database=phcpcams;")
                connection.Open()

                Using command As New MySqlCommand("DELETE FROM tbl_subjects WHERE subject_id = @SubjectID", connection)
                    command.Parameters.AddWithValue("@SubjectID", txtsubjectid.Text)
                    command.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Subject deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            SubjectList()
            ClearsubjectFields()
            CountAllSubjects()
            DashboardAllSubjects()
        Catch ex As Exception
            MessageBox.Show($"Error deleting subject: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SubjectList()
        Try
            Using connection As New MySqlConnection("server=localhost;user id=root;password=;database=phcpcams;")
                Using command As New MySqlCommand("SELECT subject_id, subject_code, subject_name, DATE_FORMAT(subject_timestart, '%h:%i %p') AS subjecttimestart, DATE_FORMAT(subject_timeend, '%h:%i %p') AS subjecttimeend FROM tbl_subjects", connection)
                    Using adapter As New MySqlDataAdapter(command)
                        Dim table As New DataTable()
                        adapter.Fill(table)
                        SubjectDataGridView.DataSource = table
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error retrieving subjects: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SubjectDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles SubjectDataGridView.CellClick
        Try
            If e.RowIndex >= 0 Then
                txtsubjectid.Text = SubjectDataGridView.Rows(e.RowIndex).Cells("SLsubject_id").Value.ToString()
                txtSubject_code.Text = SubjectDataGridView.Rows(e.RowIndex).Cells("SLsubject_code").Value.ToString()
                txtsubjectname.Text = SubjectDataGridView.Rows(e.RowIndex).Cells("SLsubject_name").Value.ToString()

                ' Handle DateTimePicker controls
                If SubjectDataGridView.Rows(e.RowIndex).Cells("SLsubject_timestart").Value IsNot Nothing Then
                    Dim timeStart As DateTime = DateTime.Parse(SubjectDataGridView.Rows(e.RowIndex).Cells("SLsubject_timestart").Value.ToString())
                    dtpSubjectTimeStart.Value = timeStart
                Else
                    dtpSubjectTimeStart.Value = DateTime.Now ' Set a default value or handle accordingly
                End If

                If SubjectDataGridView.Rows(e.RowIndex).Cells("SLsubject_timeend").Value IsNot Nothing Then
                    Dim timeEnd As DateTime = DateTime.Parse(SubjectDataGridView.Rows(e.RowIndex).Cells("SLsubject_timeend").Value.ToString())
                    dtpSubjectTimeEnd.Value = timeEnd
                Else
                    dtpSubjectTimeEnd.Value = DateTime.Now ' Set a default value or handle accordingly
                End If
            End If
        Catch ex As Exception
            ' Log the exception information
            MessageBox.Show($"Error in CellClick: {ex.Message}{vbCrLf}{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CountAllSubjects()
        'Count All Subjects
        Try
            Using connection As New MySqlConnection("server=localhost;user id=root;password=;database=phcpcams;")
                connection.Open()

                Using command As New MySqlCommand("SELECT COUNT(*) FROM tbl_subjects", connection)
                    Dim totalRecords As Integer = Convert.ToInt32(command.ExecuteScalar())
                    lblsubjectstotal.Text = $"{totalRecords}"
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error retrieving total records: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DashboardAllSubjects()
        Try
            Using connection As New MySqlConnection("server=localhost;user id=root;password=;database=phcpcams;")
                connection.Open()

                Using command As New MySqlCommand("SELECT COUNT(*) FROM tbl_subjects", connection)
                    Dim totalSubjects As Integer = Convert.ToInt32(command.ExecuteScalar())
                    lblsubjectstotal.Text = $"{totalSubjects}"
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error retrieving total subjects: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        Adminlogin.Show()
    End Sub

    Private Sub btnNewsubject_Click(sender As Object, e As EventArgs) Handles btnNewsubject.Click
        ClearsubjectFields()
    End Sub
    Private Sub ClearsubjectFields()
        txtsubjectid.Clear()
        txtsubjectname.Clear()
        txtSubject_code.Clear()
        txtsubjectid.Clear()
        dtpSubjectTimeStart.ResetText()
        dtpSubjectTimeEnd.ResetText()
    End Sub
    Private Sub SubjectLogs()
        Try

            Using connection As New MySqlConnection("server=localhost;user id=root;password=;database=phcpcams;")
                connection.Open()

                Using command As New MySqlCommand("SELECT student_id, subject_name, timein, timeout FROM tbl_attendance", connection)


                    Using adapter As New MySqlDataAdapter(command)
                        Dim table As New DataTable()
                        adapter.Fill(table)
                        dgvSubjectLogs.DataSource = table
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"An error occurred while retrieving today's attendance: {vbCrLf}{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'Printables
    'list of all students

    Private Sub AllStudents()
        Try
            Using connection As New MySqlConnection("server=localhost;user id=root;password=;database=phcpcams;")
                connection.Open()
                Using command As New MySqlCommand("SELECT student_id, firstname, middlename, lastname,gender FROM tbl_students", connection)
                    Using adapter As New MySqlDataAdapter(command)
                        Dim table As New DataTable()
                        adapter.Fill(table)
                        DataGridView5.DataSource = table
                        DataGridView5.ForeColor = Color.Black
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'List of all Teacher
    Private Sub AllTeacher()
        Try
            Using connection As New MySqlConnection("server=localhost;user id=root;password=;database=phcpcams;")
                connection.Open()
                Using command As New MySqlCommand("SELECT teacher_id, firstname, middlename,lastname, gender, subject_name, subject_timestart, subject_timeend FROM tbl_teacher", connection)
                    Using adapter As New MySqlDataAdapter(command)
                        Dim table As New DataTable()
                        adapter.Fill(table)
                        DataGridView6.DataSource = table
                        DataGridView6.ForeColor = Color.Black
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Current Attendance for today
    Private Sub CurrentAttendance()
        Try
            Dim currentDate As String = DateTime.Now.ToString("yyyy-MM-dd")

            Using connection As New MySqlConnection("server=localhost;user id=root;password=;database=phcpcams;")
                connection.Open()

                Using command As New MySqlCommand("SELECT * FROM tbl_attendance WHERE date = @currentDate", connection)
                    command.Parameters.AddWithValue("@currentDate", currentDate)

                    Using adapter As New MySqlDataAdapter(command)
                        Dim table As New DataTable()
                        adapter.Fill(table)
                        DataGridView2.DataSource = table
                        DataGridView2.ForeColor = Color.Black
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"An error occurred while retrieving subject logs for today: {vbCrLf}{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AttendanceHistory()
        Try
            Using connection As New MySqlConnection("server=localhost;user id=root;password=;database=phcpcams;")
                connection.Open()

                Using command As New MySqlCommand("SELECT * FROM tbl_attendance", connection)
                    Using adapter As New MySqlDataAdapter(command)
                        Dim table As New DataTable()
                        adapter.Fill(table)
                        DataGridView1.DataSource = table
                        DataGridView1.ForeColor = Color.Black
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"An error occurred while retrieving attendance history: {vbCrLf}{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'get current date and time
        lbldashboardtime.Text = DateTime.Now.ToString("hh:mm:ss tt dddd-MMMM-dd-yyyy")
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

    Private Sub btnPrintStudent_Click(sender As Object, e As EventArgs) Handles btnPrintStudent.Click
        PrintDataGridView(DataGridView5)
    End Sub

    Private Sub btnPrintTeacher_Click(sender As Object, e As EventArgs) Handles btnPrintTeacher.Click
        PrintDataGridView(DataGridView6)
    End Sub

    Private Sub btnPrintAttendance_Click(sender As Object, e As EventArgs) Handles btnPrintAttendance.Click
        PrintDataGridView(DataGridView2)
    End Sub

    Private Sub btnPrintAttendanceHistory_Click(sender As Object, e As EventArgs) Handles btnPrintAttendanceHistory.Click
        PrintDataGridView(DataGridView1)
    End Sub
End Class