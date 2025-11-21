<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_Dashboard
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
        Screen_Panel = New Panel()
        Main_Panel = New Panel()
        Content_Panel = New Panel()
        Label3 = New Label()
        Side_Panel = New Panel()
        Logout_BTN = New LinkLabel()
        SideBar_Panel = New Panel()
        SideFunction_Panel = New Panel()
        Fac_Eval_Linklbl = New LinkLabel()
        Partner_Comp_Linklbl = New LinkLabel()
        Stud_Regis_Linklbl = New LinkLabel()
        Student_Eval_LinkLbl = New LinkLabel()
        MainMenu_Panel = New Panel()
        SchoolTitle_Panel = New Panel()
        Logo_Pic = New PictureBox()
        SchoolName_Lbl = New Label()
        Function_Panel = New Panel()
        Dashboard_BTN = New LinkLabel()
        Profile_BTN = New LinkLabel()
        Functions_Panel = New Panel()
        Label2 = New Label()
        Screen_Panel.SuspendLayout()
        Main_Panel.SuspendLayout()
        Content_Panel.SuspendLayout()
        Side_Panel.SuspendLayout()
        SideBar_Panel.SuspendLayout()
        SideFunction_Panel.SuspendLayout()
        MainMenu_Panel.SuspendLayout()
        SchoolTitle_Panel.SuspendLayout()
        CType(Logo_Pic, ComponentModel.ISupportInitialize).BeginInit()
        Function_Panel.SuspendLayout()
        Functions_Panel.SuspendLayout()
        SuspendLayout()
        ' 
        ' Screen_Panel
        ' 
        Screen_Panel.BackColor = SystemColors.Control
        Screen_Panel.Controls.Add(Main_Panel)
        Screen_Panel.Controls.Add(Functions_Panel)
        Screen_Panel.Dock = DockStyle.Fill
        Screen_Panel.Location = New Point(0, 0)
        Screen_Panel.Name = "Screen_Panel"
        Screen_Panel.Size = New Size(1902, 1055)
        Screen_Panel.TabIndex = 13
        ' 
        ' Main_Panel
        ' 
        Main_Panel.Controls.Add(Content_Panel)
        Main_Panel.Controls.Add(Side_Panel)
        Main_Panel.Controls.Add(MainMenu_Panel)
        Main_Panel.Dock = DockStyle.Fill
        Main_Panel.Location = New Point(0, 0)
        Main_Panel.Name = "Main_Panel"
        Main_Panel.Size = New Size(1902, 1055)
        Main_Panel.TabIndex = 0
        ' 
        ' Content_Panel
        ' 
        Content_Panel.BackColor = SystemColors.ButtonFace
        Content_Panel.Controls.Add(Label3)
        Content_Panel.Dock = DockStyle.Fill
        Content_Panel.Location = New Point(299, 180)
        Content_Panel.Name = "Content_Panel"
        Content_Panel.Size = New Size(1603, 875)
        Content_Panel.TabIndex = 16
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.Control
        Label3.Location = New Point(498, 291)
        Label3.Name = "Label3"
        Label3.Size = New Size(80, 20)
        Label3.TabIndex = 0
        Label3.Text = "Home Test"
        ' 
        ' Side_Panel
        ' 
        Side_Panel.BackColor = SystemColors.Control
        Side_Panel.Controls.Add(Logout_BTN)
        Side_Panel.Controls.Add(SideBar_Panel)
        Side_Panel.Dock = DockStyle.Left
        Side_Panel.Location = New Point(0, 180)
        Side_Panel.Name = "Side_Panel"
        Side_Panel.Size = New Size(299, 875)
        Side_Panel.TabIndex = 15
        ' 
        ' Logout_BTN
        ' 
        Logout_BTN.ActiveLinkColor = Color.Goldenrod
        Logout_BTN.BackColor = SystemColors.Control
        Logout_BTN.Font = New Font("Arial Rounded MT Bold", 16.2F)
        Logout_BTN.ForeColor = SystemColors.ActiveCaptionText
        Logout_BTN.LinkColor = Color.Black
        Logout_BTN.Location = New Point(76, 816)
        Logout_BTN.Name = "Logout_BTN"
        Logout_BTN.Size = New Size(143, 41)
        Logout_BTN.TabIndex = 10
        Logout_BTN.TabStop = True
        Logout_BTN.Text = "LOGOUT"
        Logout_BTN.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' SideBar_Panel
        ' 
        SideBar_Panel.BackColor = Color.Orange
        SideBar_Panel.Controls.Add(SideFunction_Panel)
        SideBar_Panel.Location = New Point(-56, 50)
        SideBar_Panel.Name = "SideBar_Panel"
        SideBar_Panel.Size = New Size(336, 736)
        SideBar_Panel.TabIndex = 0
        ' 
        ' SideFunction_Panel
        ' 
        SideFunction_Panel.Controls.Add(Fac_Eval_Linklbl)
        SideFunction_Panel.Controls.Add(Partner_Comp_Linklbl)
        SideFunction_Panel.Controls.Add(Stud_Regis_Linklbl)
        SideFunction_Panel.Controls.Add(Student_Eval_LinkLbl)
        SideFunction_Panel.Location = New Point(30, 30)
        SideFunction_Panel.Name = "SideFunction_Panel"
        SideFunction_Panel.Size = New Size(280, 680)
        SideFunction_Panel.TabIndex = 0
        ' 
        ' Fac_Eval_Linklbl
        ' 
        Fac_Eval_Linklbl.ActiveLinkColor = Color.Goldenrod
        Fac_Eval_Linklbl.BackColor = Color.Orange
        Fac_Eval_Linklbl.Font = New Font("Arial Rounded MT Bold", 16.2F)
        Fac_Eval_Linklbl.ForeColor = SystemColors.ActiveCaptionText
        Fac_Eval_Linklbl.LinkColor = Color.White
        Fac_Eval_Linklbl.Location = New Point(55, 518)
        Fac_Eval_Linklbl.Name = "Fac_Eval_Linklbl"
        Fac_Eval_Linklbl.Size = New Size(215, 70)
        Fac_Eval_Linklbl.TabIndex = 14
        Fac_Eval_Linklbl.TabStop = True
        Fac_Eval_Linklbl.Text = "FACULTY" & vbCrLf & "EVALUATORS"
        Fac_Eval_Linklbl.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Partner_Comp_Linklbl
        ' 
        Partner_Comp_Linklbl.ActiveLinkColor = Color.Goldenrod
        Partner_Comp_Linklbl.BackColor = Color.Orange
        Partner_Comp_Linklbl.Font = New Font("Arial Rounded MT Bold", 16.2F)
        Partner_Comp_Linklbl.ForeColor = SystemColors.ActiveCaptionText
        Partner_Comp_Linklbl.LinkColor = Color.White
        Partner_Comp_Linklbl.Location = New Point(50, 377)
        Partner_Comp_Linklbl.Name = "Partner_Comp_Linklbl"
        Partner_Comp_Linklbl.Size = New Size(215, 70)
        Partner_Comp_Linklbl.TabIndex = 13
        Partner_Comp_Linklbl.TabStop = True
        Partner_Comp_Linklbl.Text = "PARTNER" & vbCrLf & "COMPANIES"
        Partner_Comp_Linklbl.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Stud_Regis_Linklbl
        ' 
        Stud_Regis_Linklbl.ActiveLinkColor = Color.Goldenrod
        Stud_Regis_Linklbl.BackColor = Color.Orange
        Stud_Regis_Linklbl.Font = New Font("Arial Rounded MT Bold", 16.2F)
        Stud_Regis_Linklbl.ForeColor = SystemColors.ActiveCaptionText
        Stud_Regis_Linklbl.LinkColor = Color.White
        Stud_Regis_Linklbl.Location = New Point(50, 236)
        Stud_Regis_Linklbl.Name = "Stud_Regis_Linklbl"
        Stud_Regis_Linklbl.Size = New Size(215, 70)
        Stud_Regis_Linklbl.TabIndex = 12
        Stud_Regis_Linklbl.TabStop = True
        Stud_Regis_Linklbl.Text = "STUDENTS" & vbCrLf & "REGISTERED"
        Stud_Regis_Linklbl.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Student_Eval_LinkLbl
        ' 
        Student_Eval_LinkLbl.ActiveLinkColor = Color.Goldenrod
        Student_Eval_LinkLbl.BackColor = Color.Orange
        Student_Eval_LinkLbl.Font = New Font("Arial Rounded MT Bold", 16.2F)
        Student_Eval_LinkLbl.ForeColor = SystemColors.ActiveCaptionText
        Student_Eval_LinkLbl.LinkColor = Color.White
        Student_Eval_LinkLbl.Location = New Point(50, 95)
        Student_Eval_LinkLbl.Name = "Student_Eval_LinkLbl"
        Student_Eval_LinkLbl.Size = New Size(215, 70)
        Student_Eval_LinkLbl.TabIndex = 11
        Student_Eval_LinkLbl.TabStop = True
        Student_Eval_LinkLbl.Text = "STUDENT" & vbCrLf & "EVALUATION"
        Student_Eval_LinkLbl.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' MainMenu_Panel
        ' 
        MainMenu_Panel.BackColor = Color.Navy
        MainMenu_Panel.Controls.Add(SchoolTitle_Panel)
        MainMenu_Panel.Controls.Add(Function_Panel)
        MainMenu_Panel.Dock = DockStyle.Top
        MainMenu_Panel.Location = New Point(0, 0)
        MainMenu_Panel.Name = "MainMenu_Panel"
        MainMenu_Panel.Size = New Size(1902, 180)
        MainMenu_Panel.TabIndex = 14
        ' 
        ' SchoolTitle_Panel
        ' 
        SchoolTitle_Panel.Controls.Add(Logo_Pic)
        SchoolTitle_Panel.Controls.Add(SchoolName_Lbl)
        SchoolTitle_Panel.Dock = DockStyle.Left
        SchoolTitle_Panel.Location = New Point(0, 0)
        SchoolTitle_Panel.Name = "SchoolTitle_Panel"
        SchoolTitle_Panel.Size = New Size(713, 180)
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
        Function_Panel.Controls.Add(Dashboard_BTN)
        Function_Panel.Controls.Add(Profile_BTN)
        Function_Panel.Dock = DockStyle.Right
        Function_Panel.Location = New Point(1064, 0)
        Function_Panel.Name = "Function_Panel"
        Function_Panel.Size = New Size(838, 180)
        Function_Panel.TabIndex = 11
        ' 
        ' Dashboard_BTN
        ' 
        Dashboard_BTN.ActiveLinkColor = Color.Goldenrod
        Dashboard_BTN.BackColor = Color.Navy
        Dashboard_BTN.Font = New Font("Arial Rounded MT Bold", 16.2F)
        Dashboard_BTN.LinkColor = Color.White
        Dashboard_BTN.Location = New Point(122, 3)
        Dashboard_BTN.Name = "Dashboard_BTN"
        Dashboard_BTN.Size = New Size(203, 149)
        Dashboard_BTN.TabIndex = 0
        Dashboard_BTN.TabStop = True
        Dashboard_BTN.Text = "DASHBOARD"
        Dashboard_BTN.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Profile_BTN
        ' 
        Profile_BTN.ActiveLinkColor = Color.Goldenrod
        Profile_BTN.BackColor = Color.Navy
        Profile_BTN.Font = New Font("Arial Rounded MT Bold", 16.2F)
        Profile_BTN.LinkColor = Color.White
        Profile_BTN.Location = New Point(387, 3)
        Profile_BTN.Name = "Profile_BTN"
        Profile_BTN.Size = New Size(387, 149)
        Profile_BTN.TabIndex = 8
        Profile_BTN.TabStop = True
        Profile_BTN.Text = "FUNCTIONS & OPERATIONS"
        Profile_BTN.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Functions_Panel
        ' 
        Functions_Panel.Controls.Add(Label2)
        Functions_Panel.Dock = DockStyle.Fill
        Functions_Panel.Location = New Point(0, 0)
        Functions_Panel.Name = "Functions_Panel"
        Functions_Panel.Size = New Size(1902, 1055)
        Functions_Panel.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(597, 342)
        Label2.Name = "Label2"
        Label2.Size = New Size(95, 20)
        Label2.TabIndex = 0
        Label2.Text = "Function Test"
        ' 
        ' Admin_Dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1902, 1055)
        Controls.Add(Screen_Panel)
        Name = "Admin_Dashboard"
        Text = "Admin_Dashbord"
        Screen_Panel.ResumeLayout(False)
        Main_Panel.ResumeLayout(False)
        Content_Panel.ResumeLayout(False)
        Content_Panel.PerformLayout()
        Side_Panel.ResumeLayout(False)
        SideBar_Panel.ResumeLayout(False)
        SideFunction_Panel.ResumeLayout(False)
        MainMenu_Panel.ResumeLayout(False)
        SchoolTitle_Panel.ResumeLayout(False)
        CType(Logo_Pic, ComponentModel.ISupportInitialize).EndInit()
        Function_Panel.ResumeLayout(False)
        Functions_Panel.ResumeLayout(False)
        Functions_Panel.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Screen_Panel As Panel
    Friend WithEvents Main_Panel As Panel
    Friend WithEvents Functions_Panel As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents MainMenu_Panel As Panel
    Friend WithEvents SchoolTitle_Panel As Panel
    Friend WithEvents Logo_Pic As PictureBox
    Friend WithEvents SchoolName_Lbl As Label
    Friend WithEvents Function_Panel As Panel
    Friend WithEvents Dashboard_BTN As LinkLabel
    Friend WithEvents Profile_BTN As LinkLabel
    Friend WithEvents Side_Panel As Panel
    Friend WithEvents Content_Panel As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents SideBar_Panel As Panel
    Friend WithEvents Logout_BTN As LinkLabel
    Friend WithEvents SideFunction_Panel As Panel
    Friend WithEvents Student_Eval_LinkLbl As LinkLabel
    Friend WithEvents Stud_Regis_Linklbl As LinkLabel
    Friend WithEvents Fac_Eval_Linklbl As LinkLabel
    Friend WithEvents Partner_Comp_Linklbl As LinkLabel
End Class
