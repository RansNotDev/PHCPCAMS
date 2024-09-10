<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnProfile = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbldashboardtime = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTeacherLname = New System.Windows.Forms.TextBox()
        Me.dgvstudentattendance = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTeacherid = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtEndTime = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnTimeIn = New System.Windows.Forms.Button()
        Me.txtTeacherfname = New System.Windows.Forms.TextBox()
        Me.btnTimeout = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtStartTime = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSubjectName = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.RBfemale = New System.Windows.Forms.RadioButton()
        Me.RBmale = New System.Windows.Forms.RadioButton()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtLastname = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtMiddlename = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblStudentidInfo = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.PBupdatepicture = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvstudentattendance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.PBupdatepicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.btnProfile)
        Me.Panel1.Controls.Add(Me.btnDashboard)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblname)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(242, 817)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.PHCPCAMS.My.Resources.Resources._8pxcriclegreen
        Me.PictureBox2.Location = New System.Drawing.Point(29, 189)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(15, 14)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Book Antiqua", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(0, 753)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(240, 64)
        Me.btnLogout.TabIndex = 5
        Me.btnLogout.Text = "Log Out"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnProfile
        '
        Me.btnProfile.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnProfile.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.btnProfile.FlatAppearance.BorderSize = 0
        Me.btnProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.btnProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnProfile.Font = New System.Drawing.Font("Book Antiqua", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProfile.ForeColor = System.Drawing.Color.White
        Me.btnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProfile.Location = New System.Drawing.Point(0, 373)
        Me.btnProfile.Name = "btnProfile"
        Me.btnProfile.Size = New System.Drawing.Size(242, 53)
        Me.btnProfile.TabIndex = 4
        Me.btnProfile.Text = "Profile"
        Me.btnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnProfile.UseVisualStyleBackColor = False
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDashboard.Font = New System.Drawing.Font("Book Antiqua", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.Location = New System.Drawing.Point(0, 317)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(242, 53)
        Me.btnDashboard.TabIndex = 3
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(82, 222)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Student"
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblname.Font = New System.Drawing.Font("Bahnschrift", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.ForeColor = System.Drawing.Color.White
        Me.lblname.Location = New System.Drawing.Point(50, 188)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(48, 18)
        Me.lblname.TabIndex = 1
        Me.lblname.Text = "Name"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PHCPCAMS.My.Resources.Resources.personsetting64px
        Me.PictureBox1.Location = New System.Drawing.Point(41, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(164, 148)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lbldashboardtime)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(242, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1053, 70)
        Me.Panel2.TabIndex = 1
        '
        'lbldashboardtime
        '
        Me.lbldashboardtime.AutoSize = True
        Me.lbldashboardtime.Font = New System.Drawing.Font("digital display tfb", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldashboardtime.ForeColor = System.Drawing.Color.Red
        Me.lbldashboardtime.Location = New System.Drawing.Point(327, 12)
        Me.lbldashboardtime.Name = "lbldashboardtime"
        Me.lbldashboardtime.Size = New System.Drawing.Size(100, 39)
        Me.lbldashboardtime.TabIndex = 0
        Me.lbldashboardtime.Text = "Label15"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Book Antiqua", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(242, 70)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1053, 747)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.TabPage1.BackgroundImage = Global.PHCPCAMS.My.Resources.Resources.finalimageperpsblurred
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.txtTeacherLname)
        Me.TabPage1.Controls.Add(Me.dgvstudentattendance)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txtTeacherid)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.txtEndTime)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.btnTimeIn)
        Me.TabPage1.Controls.Add(Me.txtTeacherfname)
        Me.TabPage1.Controls.Add(Me.btnTimeout)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.txtStartTime)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.txtSubjectName)
        Me.TabPage1.Location = New System.Drawing.Point(4, 31)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1045, 712)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(500, 230)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 19)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Time End"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(219, 230)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 19)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Time Start"
        '
        'txtTeacherLname
        '
        Me.txtTeacherLname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTeacherLname.Location = New System.Drawing.Point(431, 262)
        Me.txtTeacherLname.Multiline = True
        Me.txtTeacherLname.Name = "txtTeacherLname"
        Me.txtTeacherLname.Size = New System.Drawing.Size(235, 27)
        Me.txtTeacherLname.TabIndex = 14
        '
        'dgvstudentattendance
        '
        Me.dgvstudentattendance.AllowUserToAddRows = False
        Me.dgvstudentattendance.AllowUserToDeleteRows = False
        Me.dgvstudentattendance.AllowUserToResizeColumns = False
        Me.dgvstudentattendance.AllowUserToResizeRows = False
        Me.dgvstudentattendance.BackgroundColor = System.Drawing.Color.RoyalBlue
        Me.dgvstudentattendance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvstudentattendance.ColumnHeadersHeight = 30
        Me.dgvstudentattendance.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column6, Me.Column7, Me.Column8, Me.Column4, Me.Column5, Me.Column10, Me.Column9})
        Me.dgvstudentattendance.GridColor = System.Drawing.Color.Black
        Me.dgvstudentattendance.Location = New System.Drawing.Point(6, 405)
        Me.dgvstudentattendance.Name = "dgvstudentattendance"
        Me.dgvstudentattendance.RowHeadersWidth = 10
        Me.dgvstudentattendance.RowTemplate.Height = 24
        Me.dgvstudentattendance.Size = New System.Drawing.Size(1033, 299)
        Me.dgvstudentattendance.TabIndex = 10
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "student_id"
        Me.Column1.HeaderText = "Student ID"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "subject_name"
        Me.Column2.HeaderText = "Subject Name"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 150
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "date"
        Me.Column3.HeaderText = "Date"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "timein"
        Me.Column6.HeaderText = "Time In"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 125
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "timeout"
        Me.Column7.HeaderText = "Time Out"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 125
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "remarks"
        Me.Column8.HeaderText = "Remarks"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 125
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "timestart"
        Me.Column4.HeaderText = "Subject Time Start"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 180
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "timeend"
        Me.Column5.HeaderText = "Subject Time End"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 180
        '
        'Column10
        '
        Me.Column10.DataPropertyName = "teacher_id"
        Me.Column10.HeaderText = "Teacher_id"
        Me.Column10.MinimumWidth = 6
        Me.Column10.Name = "Column10"
        Me.Column10.Width = 125
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "teacher"
        Me.Column9.HeaderText = "Teacher"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 125
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(15, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 23)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "TEACHER ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(371, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(308, 68)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Dashboard"
        '
        'txtTeacherid
        '
        Me.txtTeacherid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTeacherid.Location = New System.Drawing.Point(153, 106)
        Me.txtTeacherid.Multiline = True
        Me.txtTeacherid.Name = "txtTeacherid"
        Me.txtTeacherid.Size = New System.Drawing.Size(247, 27)
        Me.txtTeacherid.TabIndex = 15
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(488, 292)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 19)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = "Lastname"
        '
        'txtEndTime
        '
        Me.txtEndTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEndTime.Location = New System.Drawing.Point(431, 200)
        Me.txtEndTime.Multiline = True
        Me.txtEndTime.Name = "txtEndTime"
        Me.txtEndTime.Size = New System.Drawing.Size(235, 27)
        Me.txtEndTime.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(219, 292)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 19)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Firstname"
        '
        'btnTimeIn
        '
        Me.btnTimeIn.BackColor = System.Drawing.Color.Green
        Me.btnTimeIn.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnTimeIn.FlatAppearance.BorderSize = 0
        Me.btnTimeIn.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue
        Me.btnTimeIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.btnTimeIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.btnTimeIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTimeIn.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimeIn.ForeColor = System.Drawing.Color.White
        Me.btnTimeIn.Location = New System.Drawing.Point(223, 344)
        Me.btnTimeIn.Name = "btnTimeIn"
        Me.btnTimeIn.Size = New System.Drawing.Size(128, 35)
        Me.btnTimeIn.TabIndex = 1
        Me.btnTimeIn.Text = "Time In"
        Me.btnTimeIn.UseVisualStyleBackColor = False
        '
        'txtTeacherfname
        '
        Me.txtTeacherfname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTeacherfname.Location = New System.Drawing.Point(153, 262)
        Me.txtTeacherfname.Multiline = True
        Me.txtTeacherfname.Name = "txtTeacherfname"
        Me.txtTeacherfname.Size = New System.Drawing.Size(247, 27)
        Me.txtTeacherfname.TabIndex = 11
        '
        'btnTimeout
        '
        Me.btnTimeout.BackColor = System.Drawing.Color.Red
        Me.btnTimeout.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnTimeout.FlatAppearance.BorderSize = 0
        Me.btnTimeout.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue
        Me.btnTimeout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnTimeout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnTimeout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTimeout.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimeout.ForeColor = System.Drawing.Color.White
        Me.btnTimeout.Location = New System.Drawing.Point(383, 344)
        Me.btnTimeout.Name = "btnTimeout"
        Me.btnTimeout.Size = New System.Drawing.Size(128, 35)
        Me.btnTimeout.TabIndex = 2
        Me.btnTimeout.Text = "Time out"
        Me.btnTimeout.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(19, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 23)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Subject Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(62, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 23)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Schedule"
        '
        'txtStartTime
        '
        Me.txtStartTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStartTime.Location = New System.Drawing.Point(153, 200)
        Me.txtStartTime.Multiline = True
        Me.txtStartTime.Name = "txtStartTime"
        Me.txtStartTime.Size = New System.Drawing.Size(247, 27)
        Me.txtStartTime.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(15, 262)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(132, 23)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Teacher Name"
        '
        'txtSubjectName
        '
        Me.txtSubjectName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSubjectName.Location = New System.Drawing.Point(153, 154)
        Me.txtSubjectName.Multiline = True
        Me.txtSubjectName.Name = "txtSubjectName"
        Me.txtSubjectName.Size = New System.Drawing.Size(247, 27)
        Me.txtSubjectName.TabIndex = 7
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.TabPage2.BackgroundImage = Global.PHCPCAMS.My.Resources.Resources.finalimageperpsblurred
        Me.TabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage2.Controls.Add(Me.RBfemale)
        Me.TabPage2.Controls.Add(Me.RBmale)
        Me.TabPage2.Controls.Add(Me.Label18)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.btnSave)
        Me.TabPage2.Controls.Add(Me.txtPassword)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.txtLastname)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.txtMiddlename)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.txtFirstname)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.lblStudentidInfo)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.btnUpload)
        Me.TabPage2.Controls.Add(Me.PBupdatepicture)
        Me.TabPage2.Location = New System.Drawing.Point(4, 31)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1045, 712)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        '
        'RBfemale
        '
        Me.RBfemale.AutoSize = True
        Me.RBfemale.ForeColor = System.Drawing.Color.White
        Me.RBfemale.Location = New System.Drawing.Point(254, 367)
        Me.RBfemale.Name = "RBfemale"
        Me.RBfemale.Size = New System.Drawing.Size(85, 26)
        Me.RBfemale.TabIndex = 31
        Me.RBfemale.TabStop = True
        Me.RBfemale.Text = "Female"
        Me.RBfemale.UseVisualStyleBackColor = True
        '
        'RBmale
        '
        Me.RBmale.AutoSize = True
        Me.RBmale.ForeColor = System.Drawing.Color.White
        Me.RBmale.Location = New System.Drawing.Point(165, 367)
        Me.RBmale.Name = "RBmale"
        Me.RBmale.Size = New System.Drawing.Size(69, 26)
        Me.RBmale.TabIndex = 30
        Me.RBmale.TabStop = True
        Me.RBmale.Text = "Male"
        Me.RBmale.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Bahnschrift SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(55, 369)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(97, 24)
        Me.Label18.TabIndex = 29
        Me.Label18.Text = "GENDER :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(318, 3)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(462, 68)
        Me.Label17.TabIndex = 28
        Me.Label17.Text = "Edit Information"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Cascadia Code", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(210, 203)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 20)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Optional"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(188, 635)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(133, 47)
        Me.btnSave.TabIndex = 26
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Location = New System.Drawing.Point(164, 296)
        Me.txtPassword.Multiline = True
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(225, 32)
        Me.txtPassword.TabIndex = 25
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Bahnschrift SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(29, 301)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(123, 24)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "PASSWORD :"
        '
        'txtLastname
        '
        Me.txtLastname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLastname.Location = New System.Drawing.Point(165, 240)
        Me.txtLastname.Multiline = True
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(225, 32)
        Me.txtLastname.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Bahnschrift SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(32, 245)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(120, 24)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "LASTNAME :"
        '
        'txtMiddlename
        '
        Me.txtMiddlename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMiddlename.Location = New System.Drawing.Point(164, 168)
        Me.txtMiddlename.Multiline = True
        Me.txtMiddlename.Name = "txtMiddlename"
        Me.txtMiddlename.Size = New System.Drawing.Size(225, 32)
        Me.txtMiddlename.TabIndex = 21
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Bahnschrift SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(6, 167)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(146, 24)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "MIDDLENAME :"
        '
        'txtFirstname
        '
        Me.txtFirstname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFirstname.Location = New System.Drawing.Point(164, 113)
        Me.txtFirstname.Multiline = True
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(225, 32)
        Me.txtFirstname.TabIndex = 19
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Bahnschrift SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(25, 121)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(127, 24)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "FIRSTNAME :"
        '
        'lblStudentidInfo
        '
        Me.lblStudentidInfo.AutoSize = True
        Me.lblStudentidInfo.Font = New System.Drawing.Font("Bahnschrift SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentidInfo.ForeColor = System.Drawing.Color.White
        Me.lblStudentidInfo.Location = New System.Drawing.Point(184, 78)
        Me.lblStudentidInfo.Name = "lblStudentidInfo"
        Me.lblStudentidInfo.Size = New System.Drawing.Size(107, 24)
        Me.lblStudentidInfo.TabIndex = 17
        Me.lblStudentidInfo.Text = "Student Id "
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Bahnschrift SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(23, 78)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(129, 24)
        Me.Label16.TabIndex = 16
        Me.Label16.Text = "STUDENT ID :"
        '
        'btnUpload
        '
        Me.btnUpload.BackColor = System.Drawing.Color.Lime
        Me.btnUpload.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnUpload.FlatAppearance.BorderSize = 0
        Me.btnUpload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnUpload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpload.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpload.ForeColor = System.Drawing.Color.White
        Me.btnUpload.Location = New System.Drawing.Point(178, 582)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(173, 47)
        Me.btnUpload.TabIndex = 15
        Me.btnUpload.Text = "Upload Image"
        Me.btnUpload.UseVisualStyleBackColor = False
        '
        'PBupdatepicture
        '
        Me.PBupdatepicture.Image = Global.PHCPCAMS.My.Resources.Resources.usernameicon
        Me.PBupdatepicture.Location = New System.Drawing.Point(165, 411)
        Me.PBupdatepicture.Name = "PBupdatepicture"
        Me.PBupdatepicture.Size = New System.Drawing.Size(186, 156)
        Me.PBupdatepicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PBupdatepicture.TabIndex = 14
        Me.PBupdatepicture.TabStop = False
        '
        'Timer1
        '
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'StudentDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1295, 817)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StudentDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StudentDashboard"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgvstudentattendance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PBupdatepicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblname As Label
    Friend WithEvents btnDashboard As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnProfile As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgvstudentattendance As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTeacherfname As TextBox
    Friend WithEvents txtEndTime As TextBox
    Friend WithEvents txtStartTime As TextBox
    Friend WithEvents txtSubjectName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnTimeout As Button
    Friend WithEvents btnTimeIn As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label10 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtLastname As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtMiddlename As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtFirstname As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents lblStudentidInfo As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents btnUpload As Button
    Friend WithEvents PBupdatepicture As PictureBox
    Friend WithEvents RBfemale As RadioButton
    Friend WithEvents RBmale As RadioButton
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents lbldashboardtime As Label
    Friend WithEvents txtTeacherLname As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTeacherid As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
End Class
