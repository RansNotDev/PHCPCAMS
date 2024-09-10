<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WelcomePage
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.AdminPanel = New System.Windows.Forms.Panel()
        Me.TeacherPanel = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.StudentPanel = New System.Windows.Forms.Panel()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("NSimSun", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(1, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(877, 37)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "PHCP Classroom Attendance Monitoring System"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift Condensed", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gold
        Me.Label3.Location = New System.Drawing.Point(110, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(399, 40)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Perpetual Help College Pangasinan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift Condensed", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(68, 379)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 40)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "STUDENT"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift Condensed", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gold
        Me.Label4.Location = New System.Drawing.Point(379, 379)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 40)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "TEACHER"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift Condensed", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gold
        Me.Label5.Location = New System.Drawing.Point(689, 379)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 40)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "ADMIN"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.PHCPCAMS.My.Resources.Resources.closeicon
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(851, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(27, 32)
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'AdminPanel
        '
        Me.AdminPanel.BackColor = System.Drawing.Color.Blue
        Me.AdminPanel.BackgroundImage = Global.PHCPCAMS.My.Resources.Resources.adminicon
        Me.AdminPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AdminPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AdminPanel.Location = New System.Drawing.Point(622, 195)
        Me.AdminPanel.Name = "AdminPanel"
        Me.AdminPanel.Size = New System.Drawing.Size(230, 181)
        Me.AdminPanel.TabIndex = 11
        '
        'TeacherPanel
        '
        Me.TeacherPanel.BackColor = System.Drawing.Color.Blue
        Me.TeacherPanel.BackgroundImage = Global.PHCPCAMS.My.Resources.Resources.Custom_Icon_Design_Pretty_Office_10_Teachers_512
        Me.TeacherPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TeacherPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TeacherPanel.Location = New System.Drawing.Point(322, 195)
        Me.TeacherPanel.Name = "TeacherPanel"
        Me.TeacherPanel.Size = New System.Drawing.Size(230, 181)
        Me.TeacherPanel.TabIndex = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PHCPCAMS.My.Resources.Resources.uphsl_logo1
        Me.PictureBox1.Location = New System.Drawing.Point(5, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(99, 127)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'StudentPanel
        '
        Me.StudentPanel.BackColor = System.Drawing.Color.Blue
        Me.StudentPanel.BackgroundImage = Global.PHCPCAMS.My.Resources.Resources.online_lesson
        Me.StudentPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.StudentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StudentPanel.Location = New System.Drawing.Point(16, 195)
        Me.StudentPanel.Name = "StudentPanel"
        Me.StudentPanel.Size = New System.Drawing.Size(230, 181)
        Me.StudentPanel.TabIndex = 9
        '
        'WelcomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(880, 450)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.AdminPanel)
        Me.Controls.Add(Me.TeacherPanel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.StudentPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "WelcomePage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AdminPanel As Panel
    Friend WithEvents TeacherPanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents StudentPanel As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
