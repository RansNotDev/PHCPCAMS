<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TeacherLogin
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblmonth = New System.Windows.Forms.Label()
        Me.lblam = New System.Windows.Forms.Label()
        Me.lblhour = New System.Windows.Forms.Label()
        Me.lblmorning = New System.Windows.Forms.Label()
        Me.lblday = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtTeacherID = New System.Windows.Forms.TextBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtTeacherPassword = New System.Windows.Forms.TextBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.CBshowpassword = New System.Windows.Forms.CheckBox()
        Me.lblerror = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.PHCPCAMS.My.Resources.Resources.Graphicloads_100_Flat_2_Arrow_back_256
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(801, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(39, 41)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(840, 143)
        Me.Panel1.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift Condensed", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(124, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(567, 57)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Perpetual Help College Pangasinan"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.PHCPCAMS.My.Resources.Resources.uphsl_logo1
        Me.PictureBox2.Location = New System.Drawing.Point(3, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(115, 140)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblmonth)
        Me.Panel2.Controls.Add(Me.lblam)
        Me.Panel2.Controls.Add(Me.lblhour)
        Me.Panel2.Controls.Add(Me.lblmorning)
        Me.Panel2.Controls.Add(Me.lblday)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(380, 143)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(460, 448)
        Me.Panel2.TabIndex = 2
        '
        'lblmonth
        '
        Me.lblmonth.AutoSize = True
        Me.lblmonth.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmonth.Location = New System.Drawing.Point(46, 283)
        Me.lblmonth.Name = "lblmonth"
        Me.lblmonth.Size = New System.Drawing.Size(192, 35)
        Me.lblmonth.TabIndex = 14
        Me.lblmonth.Text = "NOVEMBER"
        '
        'lblam
        '
        Me.lblam.AutoSize = True
        Me.lblam.Font = New System.Drawing.Font("digital display tfb", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblam.Location = New System.Drawing.Point(268, 219)
        Me.lblam.Name = "lblam"
        Me.lblam.Size = New System.Drawing.Size(44, 39)
        Me.lblam.TabIndex = 13
        Me.lblam.Text = "AM"
        '
        'lblhour
        '
        Me.lblhour.AutoSize = True
        Me.lblhour.Font = New System.Drawing.Font("digital display tfb", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhour.Location = New System.Drawing.Point(114, 196)
        Me.lblhour.Name = "lblhour"
        Me.lblhour.Size = New System.Drawing.Size(62, 62)
        Me.lblhour.TabIndex = 12
        Me.lblhour.Text = "11:11"
        '
        'lblmorning
        '
        Me.lblmorning.AutoSize = True
        Me.lblmorning.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmorning.Location = New System.Drawing.Point(158, 153)
        Me.lblmorning.Name = "lblmorning"
        Me.lblmorning.Size = New System.Drawing.Size(92, 26)
        Me.lblmorning.TabIndex = 11
        Me.lblmorning.Text = "Morning"
        '
        'lblday
        '
        Me.lblday.AutoSize = True
        Me.lblday.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblday.Location = New System.Drawing.Point(175, 98)
        Me.lblday.Name = "lblday"
        Me.lblday.Size = New System.Drawing.Size(72, 26)
        Me.lblday.TabIndex = 10
        Me.lblday.Text = "Friday"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(12, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(437, 74)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "PHCP Classroom Attendance " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "            Monitoring System"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.PHCPCAMS.My.Resources.Resources.teacherrr
        Me.PictureBox3.Location = New System.Drawing.Point(137, 163)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(118, 114)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txtTeacherID)
        Me.Panel3.Controls.Add(Me.PictureBox4)
        Me.Panel3.Location = New System.Drawing.Point(30, 333)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(331, 60)
        Me.Panel3.TabIndex = 1
        '
        'txtTeacherID
        '
        Me.txtTeacherID.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtTeacherID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTeacherID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTeacherID.Location = New System.Drawing.Point(61, 12)
        Me.txtTeacherID.Multiline = True
        Me.txtTeacherID.Name = "txtTeacherID"
        Me.txtTeacherID.Size = New System.Drawing.Size(269, 35)
        Me.txtTeacherID.TabIndex = 1
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.PHCPCAMS.My.Resources.Resources.user24px
        Me.PictureBox4.Location = New System.Drawing.Point(5, 6)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(50, 46)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 0
        Me.PictureBox4.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.txtTeacherPassword)
        Me.Panel4.Controls.Add(Me.PictureBox5)
        Me.Panel4.Location = New System.Drawing.Point(30, 401)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(331, 60)
        Me.Panel4.TabIndex = 2
        '
        'txtTeacherPassword
        '
        Me.txtTeacherPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTeacherPassword.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTeacherPassword.Location = New System.Drawing.Point(61, 13)
        Me.txtTeacherPassword.Name = "txtTeacherPassword"
        Me.txtTeacherPassword.Size = New System.Drawing.Size(269, 30)
        Me.txtTeacherPassword.TabIndex = 1
        Me.txtTeacherPassword.UseSystemPasswordChar = True
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.PHCPCAMS.My.Resources.Resources.password24px
        Me.PictureBox5.Location = New System.Drawing.Point(5, 3)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(50, 46)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 0
        Me.PictureBox5.TabStop = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.LimeGreen
        Me.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen
        Me.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogin.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(117, 510)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(125, 48)
        Me.btnLogin.TabIndex = 7
        Me.btnLogin.Text = "Log In"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'CBshowpassword
        '
        Me.CBshowpassword.AutoSize = True
        Me.CBshowpassword.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBshowpassword.Location = New System.Drawing.Point(104, 467)
        Me.CBshowpassword.Name = "CBshowpassword"
        Me.CBshowpassword.Size = New System.Drawing.Size(160, 26)
        Me.CBshowpassword.TabIndex = 6
        Me.CBshowpassword.Text = "Show Password"
        Me.CBshowpassword.UseVisualStyleBackColor = True
        '
        'lblerror
        '
        Me.lblerror.AutoSize = True
        Me.lblerror.ForeColor = System.Drawing.Color.Red
        Me.lblerror.Location = New System.Drawing.Point(101, 314)
        Me.lblerror.Name = "lblerror"
        Me.lblerror.Size = New System.Drawing.Size(0, 16)
        Me.lblerror.TabIndex = 8
        '
        'Timer1
        '
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(99, 289)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(220, 25)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "TEACHER SIGN IN"
        '
        'TeacherLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(840, 591)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblerror)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.CBshowpassword)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TeacherLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TeacherLogin"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents txtTeacherID As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents CBshowpassword As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblmonth As Label
    Friend WithEvents lblam As Label
    Friend WithEvents lblhour As Label
    Friend WithEvents lblmorning As Label
    Friend WithEvents lblday As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblerror As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtTeacherPassword As TextBox
    Friend WithEvents Label2 As Label
End Class
