<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Student_Dashboard
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
        MainMenu_Panel = New Panel()
        SchoolTitle_Panel = New Panel()
        Logo_Pic = New PictureBox()
        SchoolName_Lbl = New Label()
        Function_Panel = New Panel()
        Home_BTN = New LinkLabel()
        Profile_BTN = New LinkLabel()
        Logout_BTN = New LinkLabel()
        Internship_BTN = New LinkLabel()
        Screen_Panel = New Panel()
        Home_Panel = New Panel()
        Label3 = New Label()
        Section_Panel = New Panel()
        Label2 = New Label()
        Profile_Panel = New Panel()
        Label1 = New Label()
        MainMenu_Panel.SuspendLayout()
        SchoolTitle_Panel.SuspendLayout()
        CType(Logo_Pic, ComponentModel.ISupportInitialize).BeginInit()
        Function_Panel.SuspendLayout()
        Screen_Panel.SuspendLayout()
        Home_Panel.SuspendLayout()
        Section_Panel.SuspendLayout()
        Profile_Panel.SuspendLayout()
        SuspendLayout()
        ' 
        ' MainMenu_Panel
        ' 
        MainMenu_Panel.BackColor = Color.Navy
        MainMenu_Panel.Controls.Add(SchoolTitle_Panel)
        MainMenu_Panel.Controls.Add(Function_Panel)
        MainMenu_Panel.Dock = DockStyle.Top
        MainMenu_Panel.Location = New Point(0, 0)
        MainMenu_Panel.Name = "MainMenu_Panel"
        MainMenu_Panel.Size = New Size(1428, 187)
        MainMenu_Panel.TabIndex = 12
        ' 
        ' SchoolTitle_Panel
        ' 
        SchoolTitle_Panel.Controls.Add(Logo_Pic)
        SchoolTitle_Panel.Controls.Add(SchoolName_Lbl)
        SchoolTitle_Panel.Dock = DockStyle.Left
        SchoolTitle_Panel.Location = New Point(0, 0)
        SchoolTitle_Panel.Name = "SchoolTitle_Panel"
        SchoolTitle_Panel.Size = New Size(713, 187)
        SchoolTitle_Panel.TabIndex = 12
        ' 
        ' Logo_Pic
        ' 
        Logo_Pic.Image = My.Resources.Resources.BPTI_Logo1
        Logo_Pic.Location = New Point(68, 3)
        Logo_Pic.Name = "Logo_Pic"
        Logo_Pic.Size = New Size(192, 178)
        Logo_Pic.SizeMode = PictureBoxSizeMode.StretchImage
        Logo_Pic.TabIndex = 0
        Logo_Pic.TabStop = False
        ' 
        ' SchoolName_Lbl
        ' 
        SchoolName_Lbl.BackColor = Color.Navy
        SchoolName_Lbl.Font = New Font("Stencil", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SchoolName_Lbl.ForeColor = Color.Goldenrod
        SchoolName_Lbl.Location = New Point(286, 12)
        SchoolName_Lbl.Name = "SchoolName_Lbl"
        SchoolName_Lbl.Size = New Size(296, 175)
        SchoolName_Lbl.TabIndex = 10
        SchoolName_Lbl.Text = "Bright Path " & vbCrLf & "Technical " & vbCrLf & "Institute"
        SchoolName_Lbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Function_Panel
        ' 
        Function_Panel.Controls.Add(Home_BTN)
        Function_Panel.Controls.Add(Profile_BTN)
        Function_Panel.Controls.Add(Logout_BTN)
        Function_Panel.Controls.Add(Internship_BTN)
        Function_Panel.Dock = DockStyle.Right
        Function_Panel.Location = New Point(719, 0)
        Function_Panel.Name = "Function_Panel"
        Function_Panel.Size = New Size(709, 187)
        Function_Panel.TabIndex = 11
        ' 
        ' Home_BTN
        ' 
        Home_BTN.ActiveLinkColor = Color.Goldenrod
        Home_BTN.BackColor = Color.Navy
        Home_BTN.Font = New Font("Arial Rounded MT Bold", 16.2F)
        Home_BTN.LinkColor = Color.White
        Home_BTN.Location = New Point(6, 0)
        Home_BTN.Name = "Home_BTN"
        Home_BTN.Size = New Size(143, 149)
        Home_BTN.TabIndex = 0
        Home_BTN.TabStop = True
        Home_BTN.Text = "HOME"
        Home_BTN.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Profile_BTN
        ' 
        Profile_BTN.ActiveLinkColor = Color.Goldenrod
        Profile_BTN.BackColor = Color.Navy
        Profile_BTN.Font = New Font("Arial Rounded MT Bold", 16.2F)
        Profile_BTN.LinkColor = Color.White
        Profile_BTN.Location = New Point(155, 0)
        Profile_BTN.Name = "Profile_BTN"
        Profile_BTN.Size = New Size(143, 149)
        Profile_BTN.TabIndex = 8
        Profile_BTN.TabStop = True
        Profile_BTN.Text = "PROFILE"
        Profile_BTN.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Logout_BTN
        ' 
        Logout_BTN.ActiveLinkColor = Color.Goldenrod
        Logout_BTN.BackColor = Color.Navy
        Logout_BTN.Font = New Font("Arial Rounded MT Bold", 16.2F)
        Logout_BTN.LinkColor = Color.White
        Logout_BTN.Location = New Point(516, 0)
        Logout_BTN.Name = "Logout_BTN"
        Logout_BTN.Size = New Size(143, 149)
        Logout_BTN.TabIndex = 9
        Logout_BTN.TabStop = True
        Logout_BTN.Text = "LOGOUT"
        Logout_BTN.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Internship_BTN
        ' 
        Internship_BTN.ActiveLinkColor = Color.Goldenrod
        Internship_BTN.BackColor = Color.Navy
        Internship_BTN.Font = New Font("Arial Rounded MT Bold", 16.2F)
        Internship_BTN.LinkColor = Color.White
        Internship_BTN.Location = New Point(304, 0)
        Internship_BTN.Name = "Internship_BTN"
        Internship_BTN.Size = New Size(206, 149)
        Internship_BTN.TabIndex = 6
        Internship_BTN.TabStop = True
        Internship_BTN.Text = "INTERNSHIP"
        Internship_BTN.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Screen_Panel
        ' 
        Screen_Panel.BackColor = SystemColors.Control
        Screen_Panel.Controls.Add(Home_Panel)
        Screen_Panel.Controls.Add(Section_Panel)
        Screen_Panel.Controls.Add(Profile_Panel)
        Screen_Panel.Dock = DockStyle.Fill
        Screen_Panel.Location = New Point(0, 187)
        Screen_Panel.Name = "Screen_Panel"
        Screen_Panel.Size = New Size(1428, 390)
        Screen_Panel.TabIndex = 13
        ' 
        ' Home_Panel
        ' 
        Home_Panel.Controls.Add(Label3)
        Home_Panel.Dock = DockStyle.Fill
        Home_Panel.Location = New Point(0, 0)
        Home_Panel.Name = "Home_Panel"
        Home_Panel.Size = New Size(1428, 390)
        Home_Panel.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(687, 389)
        Label3.Name = "Label3"
        Label3.Size = New Size(80, 20)
        Label3.TabIndex = 0
        Label3.Text = "Home Test"
        ' 
        ' Section_Panel
        ' 
        Section_Panel.Controls.Add(Label2)
        Section_Panel.Dock = DockStyle.Fill
        Section_Panel.Location = New Point(0, 0)
        Section_Panel.Name = "Section_Panel"
        Section_Panel.Size = New Size(1428, 390)
        Section_Panel.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(597, 342)
        Label2.Name = "Label2"
        Label2.Size = New Size(88, 20)
        Label2.TabIndex = 0
        Label2.Text = "Section Test"
        ' 
        ' Profile_Panel
        ' 
        Profile_Panel.Controls.Add(Label1)
        Profile_Panel.Dock = DockStyle.Fill
        Profile_Panel.Location = New Point(0, 0)
        Profile_Panel.Name = "Profile_Panel"
        Profile_Panel.Size = New Size(1428, 390)
        Profile_Panel.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(465, 356)
        Label1.Name = "Label1"
        Label1.Size = New Size(80, 20)
        Label1.TabIndex = 0
        Label1.Text = "Profile test"
        ' 
        ' Student_Dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1428, 577)
        Controls.Add(Screen_Panel)
        Controls.Add(MainMenu_Panel)
        Name = "Student_Dashboard"
        Text = "Student_Dashboard"
        MainMenu_Panel.ResumeLayout(False)
        SchoolTitle_Panel.ResumeLayout(False)
        CType(Logo_Pic, ComponentModel.ISupportInitialize).EndInit()
        Function_Panel.ResumeLayout(False)
        Screen_Panel.ResumeLayout(False)
        Home_Panel.ResumeLayout(False)
        Home_Panel.PerformLayout()
        Section_Panel.ResumeLayout(False)
        Section_Panel.PerformLayout()
        Profile_Panel.ResumeLayout(False)
        Profile_Panel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents MainMenu_Panel As Panel
    Friend WithEvents SchoolTitle_Panel As Panel
    Friend WithEvents Logo_Pic As PictureBox
    Friend WithEvents SchoolName_Lbl As Label
    Friend WithEvents Function_Panel As Panel
    Friend WithEvents Home_BTN As LinkLabel
    Friend WithEvents Profile_BTN As LinkLabel
    Friend WithEvents Logout_BTN As LinkLabel
    Friend WithEvents Internship_BTN As LinkLabel
    Friend WithEvents Screen_Panel As Panel
    Friend WithEvents Home_Panel As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Section_Panel As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Profile_Panel As Panel
    Friend WithEvents Label1 As Label
End Class
