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
        components = New ComponentModel.Container()
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
        Resources_Panel = New Panel()
        OJT_Guidelines_Linklbl = New LinkLabel()
        GradeSlip_Linklbl = New LinkLabel()
        CompanyMOA_Linklbl = New LinkLabel()
        Resources_lbl = New Label()
        Blue_Design1 = New Panel()
        LighterBlue_Design1 = New Panel()
        Cyanlike_Design1 = New Panel()
        Stud_Info_Panel = New Panel()
        Stud_DateTimeNow_lbl = New Label()
        Stud_Greeting_lbl = New Label()
        Stud_User_lbl = New Label()
        Assigned_Label = New Label()
        Sup_Label = New Label()
        FacEval_Label = New Label()
        Assigned_Placeholder_lbl = New Label()
        Supervised_Placeholder_lbl = New Label()
        FacEval_Placeholder_lbl = New Label()
        Cyanlike_Design = New Panel()
        LighterBlue_Design = New Panel()
        Blue_Design = New Panel()
        DBlue_Design = New Panel()
        Profile_Panel = New Panel()
        StudProfile_Panel = New Panel()
        Stud_StudProgramName_txt = New TextBox()
        Stud_StudentID_Mtxt = New MaskedTextBox()
        Stud_ChangePass_btn = New Button()
        Stud_UpdateProfile_btn = New Button()
        Stud_StudContNum_Mtxt = New MaskedTextBox()
        Stud_StudContNum_lbl = New Label()
        Stud_StudEmailAdd_txt = New TextBox()
        Stud_StudEmailAdd_lbl = New Label()
        Stud_StudDeptID_Mtxt = New MaskedTextBox()
        Stud_StudProgramID_Mtxt = New MaskedTextBox()
        Stud_StudSection_txt = New TextBox()
        Stud_StudSection_lbl = New Label()
        Stud_StudDeptID_lbl = New Label()
        Stud_StudProgramID_lbl = New Label()
        Stud_StudProgram_lbl = New Label()
        Stud_StudID_lbl = New Label()
        Stud_Suffix_txt = New TextBox()
        Stud_LName_txt = New TextBox()
        Stud_MName_txt = New TextBox()
        Stud_FName_txt = New TextBox()
        Stud_Suffix_lbl = New Label()
        Stud_LName_lbl = New Label()
        Stud_MName_lbl = New Label()
        Stud_FName_lbl = New Label()
        ProfileTitle_Panel = New Panel()
        Stud_Profile_Lbl = New Label()
        DarkBlue_Design2 = New Panel()
        Internship_Panel = New Panel()
        IntStatus_Panel = New Panel()
        Stud_InternSemester_cmb = New ComboBox()
        Stud_InternStatus_cmb = New ComboBox()
        Stud_InternStatus_lbl = New Label()
        Stud_InternCompName_txt = New TextBox()
        Stud_InternCompName_lbl = New Label()
        Stud_InternSem_lbl = New Label()
        Stud_InternSY_txt = New TextBox()
        Stud_InternSY_lbl = New Label()
        Stud_InternCompAdd_txt = New TextBox()
        Stud_InternCompAdd_lbl = New Label()
        Stud_InternCompID_Mtxt = New MaskedTextBox()
        Stud_InternCompID_lbl = New Label()
        Stud_InternEDate_txt = New TextBox()
        Stud_InternEDate_lbl = New Label()
        Stud_InternSDate_txt = New TextBox()
        Stud_InternSDate_lbl = New Label()
        Stud_SupervisorName_txt = New TextBox()
        Stud_SupervisorName_lbl = New Label()
        Stud_SupervisorID_Mtxt = New MaskedTextBox()
        Stud_InternSupervisorID_lbl = New Label()
        Stud_InternFacEvalName_txt = New TextBox()
        Stud_InternFacEval_lbl = New Label()
        Stud_InternFacID_Mtxt = New MaskedTextBox()
        Stud_InternFacID_lbl = New Label()
        Stud_InternID_Mtxt = New MaskedTextBox()
        Stud_InternID_lbl = New Label()
        InternTitle_Panel = New Panel()
        Stud_Internship_lbl = New Label()
        DarkBlue_Design3 = New Panel()
        Timer1 = New Timer(components)
        MainMenu_Panel.SuspendLayout()
        SchoolTitle_Panel.SuspendLayout()
        CType(Logo_Pic, ComponentModel.ISupportInitialize).BeginInit()
        Function_Panel.SuspendLayout()
        Screen_Panel.SuspendLayout()
        Home_Panel.SuspendLayout()
        Resources_Panel.SuspendLayout()
        Stud_Info_Panel.SuspendLayout()
        Profile_Panel.SuspendLayout()
        StudProfile_Panel.SuspendLayout()
        ProfileTitle_Panel.SuspendLayout()
        Internship_Panel.SuspendLayout()
        IntStatus_Panel.SuspendLayout()
        InternTitle_Panel.SuspendLayout()
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
        MainMenu_Panel.Size = New Size(1902, 225)
        MainMenu_Panel.TabIndex = 12
        ' 
        ' SchoolTitle_Panel
        ' 
        SchoolTitle_Panel.Controls.Add(Logo_Pic)
        SchoolTitle_Panel.Controls.Add(SchoolName_Lbl)
        SchoolTitle_Panel.Dock = DockStyle.Left
        SchoolTitle_Panel.Location = New Point(0, 0)
        SchoolTitle_Panel.Name = "SchoolTitle_Panel"
        SchoolTitle_Panel.Size = New Size(837, 225)
        SchoolTitle_Panel.TabIndex = 12
        ' 
        ' Logo_Pic
        ' 
        Logo_Pic.Image = My.Resources.Resources.BPTI_Logo1
        Logo_Pic.Location = New Point(62, 25)
        Logo_Pic.Name = "Logo_Pic"
        Logo_Pic.Size = New Size(192, 178)
        Logo_Pic.SizeMode = PictureBoxSizeMode.StretchImage
        Logo_Pic.TabIndex = 0
        Logo_Pic.TabStop = False
        ' 
        ' SchoolName_Lbl
        ' 
        SchoolName_Lbl.BackColor = Color.Navy
        SchoolName_Lbl.Font = New Font("Stencil", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SchoolName_Lbl.ForeColor = Color.Goldenrod
        SchoolName_Lbl.Location = New Point(302, 28)
        SchoolName_Lbl.Name = "SchoolName_Lbl"
        SchoolName_Lbl.Size = New Size(454, 175)
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
        Function_Panel.Location = New Point(1193, 0)
        Function_Panel.Name = "Function_Panel"
        Function_Panel.Size = New Size(709, 225)
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
        Profile_BTN.Location = New Point(145, 0)
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
        Screen_Panel.Controls.Add(Profile_Panel)
        Screen_Panel.Controls.Add(Internship_Panel)
        Screen_Panel.Dock = DockStyle.Fill
        Screen_Panel.Location = New Point(0, 225)
        Screen_Panel.Name = "Screen_Panel"
        Screen_Panel.Size = New Size(1902, 830)
        Screen_Panel.TabIndex = 13
        ' 
        ' Home_Panel
        ' 
        Home_Panel.Controls.Add(Resources_Panel)
        Home_Panel.Controls.Add(Stud_Info_Panel)
        Home_Panel.Dock = DockStyle.Fill
        Home_Panel.Location = New Point(0, 0)
        Home_Panel.Name = "Home_Panel"
        Home_Panel.Size = New Size(1902, 830)
        Home_Panel.TabIndex = 0
        ' 
        ' Resources_Panel
        ' 
        Resources_Panel.Controls.Add(OJT_Guidelines_Linklbl)
        Resources_Panel.Controls.Add(GradeSlip_Linklbl)
        Resources_Panel.Controls.Add(CompanyMOA_Linklbl)
        Resources_Panel.Controls.Add(Resources_lbl)
        Resources_Panel.Controls.Add(Blue_Design1)
        Resources_Panel.Controls.Add(LighterBlue_Design1)
        Resources_Panel.Controls.Add(Cyanlike_Design1)
        Resources_Panel.Dock = DockStyle.Left
        Resources_Panel.Location = New Point(0, 438)
        Resources_Panel.Name = "Resources_Panel"
        Resources_Panel.Size = New Size(545, 392)
        Resources_Panel.TabIndex = 22
        ' 
        ' OJT_Guidelines_Linklbl
        ' 
        OJT_Guidelines_Linklbl.ActiveLinkColor = Color.Gold
        OJT_Guidelines_Linklbl.AutoSize = True
        OJT_Guidelines_Linklbl.Font = New Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        OJT_Guidelines_Linklbl.LinkColor = Color.Navy
        OJT_Guidelines_Linklbl.Location = New Point(132, 174)
        OJT_Guidelines_Linklbl.Name = "OJT_Guidelines_Linklbl"
        OJT_Guidelines_Linklbl.Size = New Size(268, 46)
        OJT_Guidelines_Linklbl.TabIndex = 17
        OJT_Guidelines_Linklbl.TabStop = True
        OJT_Guidelines_Linklbl.Text = "OJT Guidelines"
        ' 
        ' GradeSlip_Linklbl
        ' 
        GradeSlip_Linklbl.ActiveLinkColor = Color.Gold
        GradeSlip_Linklbl.AutoSize = True
        GradeSlip_Linklbl.Font = New Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GradeSlip_Linklbl.LinkColor = Color.Navy
        GradeSlip_Linklbl.Location = New Point(132, 235)
        GradeSlip_Linklbl.Name = "GradeSlip_Linklbl"
        GradeSlip_Linklbl.Size = New Size(190, 46)
        GradeSlip_Linklbl.TabIndex = 18
        GradeSlip_Linklbl.TabStop = True
        GradeSlip_Linklbl.Text = "Grade Slip"
        ' 
        ' CompanyMOA_Linklbl
        ' 
        CompanyMOA_Linklbl.ActiveLinkColor = Color.Gold
        CompanyMOA_Linklbl.AutoSize = True
        CompanyMOA_Linklbl.Font = New Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CompanyMOA_Linklbl.LinkColor = Color.Navy
        CompanyMOA_Linklbl.Location = New Point(132, 296)
        CompanyMOA_Linklbl.Name = "CompanyMOA_Linklbl"
        CompanyMOA_Linklbl.Size = New Size(277, 46)
        CompanyMOA_Linklbl.TabIndex = 19
        CompanyMOA_Linklbl.TabStop = True
        CompanyMOA_Linklbl.Text = "Company MOA"
        ' 
        ' Resources_lbl
        ' 
        Resources_lbl.BackColor = Color.Navy
        Resources_lbl.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Resources_lbl.ForeColor = Color.Transparent
        Resources_lbl.Location = New Point(68, 70)
        Resources_lbl.Name = "Resources_lbl"
        Resources_lbl.Size = New Size(368, 77)
        Resources_lbl.TabIndex = 16
        Resources_lbl.Text = "RESOURCES"
        Resources_lbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Blue_Design1
        ' 
        Blue_Design1.BackColor = Color.RoyalBlue
        Blue_Design1.Location = New Point(68, 174)
        Blue_Design1.Name = "Blue_Design1"
        Blue_Design1.Size = New Size(38, 46)
        Blue_Design1.TabIndex = 20
        ' 
        ' LighterBlue_Design1
        ' 
        LighterBlue_Design1.BackColor = Color.CornflowerBlue
        LighterBlue_Design1.Location = New Point(68, 235)
        LighterBlue_Design1.Name = "LighterBlue_Design1"
        LighterBlue_Design1.Size = New Size(38, 46)
        LighterBlue_Design1.TabIndex = 12
        ' 
        ' Cyanlike_Design1
        ' 
        Cyanlike_Design1.BackColor = Color.LightBlue
        Cyanlike_Design1.Location = New Point(68, 296)
        Cyanlike_Design1.Name = "Cyanlike_Design1"
        Cyanlike_Design1.Size = New Size(38, 46)
        Cyanlike_Design1.TabIndex = 12
        ' 
        ' Stud_Info_Panel
        ' 
        Stud_Info_Panel.Controls.Add(Stud_DateTimeNow_lbl)
        Stud_Info_Panel.Controls.Add(Stud_Greeting_lbl)
        Stud_Info_Panel.Controls.Add(Stud_User_lbl)
        Stud_Info_Panel.Controls.Add(Assigned_Label)
        Stud_Info_Panel.Controls.Add(Sup_Label)
        Stud_Info_Panel.Controls.Add(FacEval_Label)
        Stud_Info_Panel.Controls.Add(Assigned_Placeholder_lbl)
        Stud_Info_Panel.Controls.Add(Supervised_Placeholder_lbl)
        Stud_Info_Panel.Controls.Add(FacEval_Placeholder_lbl)
        Stud_Info_Panel.Controls.Add(Cyanlike_Design)
        Stud_Info_Panel.Controls.Add(LighterBlue_Design)
        Stud_Info_Panel.Controls.Add(Blue_Design)
        Stud_Info_Panel.Controls.Add(DBlue_Design)
        Stud_Info_Panel.Dock = DockStyle.Top
        Stud_Info_Panel.Location = New Point(0, 0)
        Stud_Info_Panel.Name = "Stud_Info_Panel"
        Stud_Info_Panel.Size = New Size(1902, 438)
        Stud_Info_Panel.TabIndex = 21
        ' 
        ' Stud_DateTimeNow_lbl
        ' 
        Stud_DateTimeNow_lbl.AutoSize = True
        Stud_DateTimeNow_lbl.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Stud_DateTimeNow_lbl.Location = New Point(1149, 31)
        Stud_DateTimeNow_lbl.Name = "Stud_DateTimeNow_lbl"
        Stud_DateTimeNow_lbl.Size = New Size(0, 45)
        Stud_DateTimeNow_lbl.TabIndex = 15
        ' 
        ' Stud_Greeting_lbl
        ' 
        Stud_Greeting_lbl.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Stud_Greeting_lbl.Location = New Point(132, 48)
        Stud_Greeting_lbl.Name = "Stud_Greeting_lbl"
        Stud_Greeting_lbl.Size = New Size(325, 42)
        Stud_Greeting_lbl.TabIndex = 6
        Stud_Greeting_lbl.Text = "WELCOME,"
        ' 
        ' Stud_User_lbl
        ' 
        Stud_User_lbl.AutoSize = True
        Stud_User_lbl.Font = New Font("Times New Roman", 55.8000031F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Stud_User_lbl.Location = New Point(121, 90)
        Stud_User_lbl.Name = "Stud_User_lbl"
        Stud_User_lbl.Size = New Size(686, 105)
        Stud_User_lbl.TabIndex = 7
        Stud_User_lbl.Text = "[NAME HERE]"
        Stud_User_lbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Assigned_Label
        ' 
        Assigned_Label.AutoSize = True
        Assigned_Label.Font = New Font("Times New Roman", 24F, FontStyle.Bold)
        Assigned_Label.Location = New Point(146, 241)
        Assigned_Label.Name = "Assigned_Label"
        Assigned_Label.Size = New Size(296, 45)
        Assigned_Label.TabIndex = 8
        Assigned_Label.Text = "ASSIGNED AT:"
        ' 
        ' Sup_Label
        ' 
        Sup_Label.AutoSize = True
        Sup_Label.Font = New Font("Times New Roman", 24F, FontStyle.Bold)
        Sup_Label.Location = New Point(146, 300)
        Sup_Label.Name = "Sup_Label"
        Sup_Label.Size = New Size(349, 45)
        Sup_Label.TabIndex = 8
        Sup_Label.Text = "SUPERVISED BY:"
        ' 
        ' FacEval_Label
        ' 
        FacEval_Label.AutoSize = True
        FacEval_Label.Font = New Font("Times New Roman", 24F, FontStyle.Bold)
        FacEval_Label.Location = New Point(146, 356)
        FacEval_Label.Name = "FacEval_Label"
        FacEval_Label.Size = New Size(478, 45)
        FacEval_Label.TabIndex = 8
        FacEval_Label.Text = "FACULTY EVALUATOR:"
        ' 
        ' Assigned_Placeholder_lbl
        ' 
        Assigned_Placeholder_lbl.AutoSize = True
        Assigned_Placeholder_lbl.Font = New Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Assigned_Placeholder_lbl.Location = New Point(448, 241)
        Assigned_Placeholder_lbl.Name = "Assigned_Placeholder_lbl"
        Assigned_Placeholder_lbl.Size = New Size(351, 46)
        Assigned_Placeholder_lbl.TabIndex = 12
        Assigned_Placeholder_lbl.Text = "[ PLACEHOLDER ]"
        ' 
        ' Supervised_Placeholder_lbl
        ' 
        Supervised_Placeholder_lbl.AutoSize = True
        Supervised_Placeholder_lbl.Font = New Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Supervised_Placeholder_lbl.Location = New Point(501, 300)
        Supervised_Placeholder_lbl.Name = "Supervised_Placeholder_lbl"
        Supervised_Placeholder_lbl.Size = New Size(351, 46)
        Supervised_Placeholder_lbl.TabIndex = 13
        Supervised_Placeholder_lbl.Text = "[ PLACEHOLDER ]"
        ' 
        ' FacEval_Placeholder_lbl
        ' 
        FacEval_Placeholder_lbl.AutoSize = True
        FacEval_Placeholder_lbl.Font = New Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FacEval_Placeholder_lbl.Location = New Point(630, 356)
        FacEval_Placeholder_lbl.Name = "FacEval_Placeholder_lbl"
        FacEval_Placeholder_lbl.Size = New Size(351, 46)
        FacEval_Placeholder_lbl.TabIndex = 14
        FacEval_Placeholder_lbl.Text = "[ PLACEHOLDER ]"
        ' 
        ' Cyanlike_Design
        ' 
        Cyanlike_Design.BackColor = Color.LightBlue
        Cyanlike_Design.Location = New Point(68, 356)
        Cyanlike_Design.Name = "Cyanlike_Design"
        Cyanlike_Design.Size = New Size(38, 46)
        Cyanlike_Design.TabIndex = 11
        ' 
        ' LighterBlue_Design
        ' 
        LighterBlue_Design.BackColor = Color.CornflowerBlue
        LighterBlue_Design.Location = New Point(68, 300)
        LighterBlue_Design.Name = "LighterBlue_Design"
        LighterBlue_Design.Size = New Size(38, 42)
        LighterBlue_Design.TabIndex = 11
        ' 
        ' Blue_Design
        ' 
        Blue_Design.BackColor = Color.RoyalBlue
        Blue_Design.Location = New Point(68, 241)
        Blue_Design.Name = "Blue_Design"
        Blue_Design.Size = New Size(38, 46)
        Blue_Design.TabIndex = 10
        ' 
        ' DBlue_Design
        ' 
        DBlue_Design.BackColor = Color.Navy
        DBlue_Design.Location = New Point(68, 48)
        DBlue_Design.Name = "DBlue_Design"
        DBlue_Design.Size = New Size(38, 156)
        DBlue_Design.TabIndex = 9
        ' 
        ' Profile_Panel
        ' 
        Profile_Panel.Controls.Add(StudProfile_Panel)
        Profile_Panel.Controls.Add(ProfileTitle_Panel)
        Profile_Panel.Dock = DockStyle.Fill
        Profile_Panel.Location = New Point(0, 0)
        Profile_Panel.Name = "Profile_Panel"
        Profile_Panel.Size = New Size(1902, 830)
        Profile_Panel.TabIndex = 1
        ' 
        ' StudProfile_Panel
        ' 
        StudProfile_Panel.Controls.Add(Stud_StudProgramName_txt)
        StudProfile_Panel.Controls.Add(Stud_StudentID_Mtxt)
        StudProfile_Panel.Controls.Add(Stud_ChangePass_btn)
        StudProfile_Panel.Controls.Add(Stud_UpdateProfile_btn)
        StudProfile_Panel.Controls.Add(Stud_StudContNum_Mtxt)
        StudProfile_Panel.Controls.Add(Stud_StudContNum_lbl)
        StudProfile_Panel.Controls.Add(Stud_StudEmailAdd_txt)
        StudProfile_Panel.Controls.Add(Stud_StudEmailAdd_lbl)
        StudProfile_Panel.Controls.Add(Stud_StudDeptID_Mtxt)
        StudProfile_Panel.Controls.Add(Stud_StudProgramID_Mtxt)
        StudProfile_Panel.Controls.Add(Stud_StudSection_txt)
        StudProfile_Panel.Controls.Add(Stud_StudSection_lbl)
        StudProfile_Panel.Controls.Add(Stud_StudDeptID_lbl)
        StudProfile_Panel.Controls.Add(Stud_StudProgramID_lbl)
        StudProfile_Panel.Controls.Add(Stud_StudProgram_lbl)
        StudProfile_Panel.Controls.Add(Stud_StudID_lbl)
        StudProfile_Panel.Controls.Add(Stud_Suffix_txt)
        StudProfile_Panel.Controls.Add(Stud_LName_txt)
        StudProfile_Panel.Controls.Add(Stud_MName_txt)
        StudProfile_Panel.Controls.Add(Stud_FName_txt)
        StudProfile_Panel.Controls.Add(Stud_Suffix_lbl)
        StudProfile_Panel.Controls.Add(Stud_LName_lbl)
        StudProfile_Panel.Controls.Add(Stud_MName_lbl)
        StudProfile_Panel.Controls.Add(Stud_FName_lbl)
        StudProfile_Panel.Dock = DockStyle.Fill
        StudProfile_Panel.Location = New Point(0, 177)
        StudProfile_Panel.Name = "StudProfile_Panel"
        StudProfile_Panel.Size = New Size(1902, 653)
        StudProfile_Panel.TabIndex = 12
        ' 
        ' Stud_StudProgramName_txt
        ' 
        Stud_StudProgramName_txt.Enabled = False
        Stud_StudProgramName_txt.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Stud_StudProgramName_txt.Location = New Point(1082, 267)
        Stud_StudProgramName_txt.Name = "Stud_StudProgramName_txt"
        Stud_StudProgramName_txt.ReadOnly = True
        Stud_StudProgramName_txt.Size = New Size(477, 51)
        Stud_StudProgramName_txt.TabIndex = 46
        ' 
        ' Stud_StudentID_Mtxt
        ' 
        Stud_StudentID_Mtxt.Enabled = False
        Stud_StudentID_Mtxt.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Stud_StudentID_Mtxt.Location = New Point(71, 264)
        Stud_StudentID_Mtxt.Mask = "00-0000"
        Stud_StudentID_Mtxt.Name = "Stud_StudentID_Mtxt"
        Stud_StudentID_Mtxt.ReadOnly = True
        Stud_StudentID_Mtxt.Size = New Size(296, 51)
        Stud_StudentID_Mtxt.TabIndex = 45
        ' 
        ' Stud_ChangePass_btn
        ' 
        Stud_ChangePass_btn.BackColor = Color.Navy
        Stud_ChangePass_btn.Font = New Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Stud_ChangePass_btn.ForeColor = Color.Transparent
        Stud_ChangePass_btn.Location = New Point(1114, 527)
        Stud_ChangePass_btn.Name = "Stud_ChangePass_btn"
        Stud_ChangePass_btn.Size = New Size(362, 76)
        Stud_ChangePass_btn.TabIndex = 44
        Stud_ChangePass_btn.Text = "CHANGE PASSWORD"
        Stud_ChangePass_btn.UseVisualStyleBackColor = False
        ' 
        ' Stud_UpdateProfile_btn
        ' 
        Stud_UpdateProfile_btn.BackColor = Color.Navy
        Stud_UpdateProfile_btn.Font = New Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Stud_UpdateProfile_btn.ForeColor = Color.Transparent
        Stud_UpdateProfile_btn.Location = New Point(1486, 527)
        Stud_UpdateProfile_btn.Name = "Stud_UpdateProfile_btn"
        Stud_UpdateProfile_btn.Size = New Size(362, 76)
        Stud_UpdateProfile_btn.TabIndex = 43
        Stud_UpdateProfile_btn.Text = "UPDATE PROFILE"
        Stud_UpdateProfile_btn.UseVisualStyleBackColor = False
        ' 
        ' Stud_StudContNum_Mtxt
        ' 
        Stud_StudContNum_Mtxt.Enabled = False
        Stud_StudContNum_Mtxt.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Stud_StudContNum_Mtxt.Location = New Point(71, 420)
        Stud_StudContNum_Mtxt.Mask = "+63000-000-0000"
        Stud_StudContNum_Mtxt.Name = "Stud_StudContNum_Mtxt"
        Stud_StudContNum_Mtxt.ReadOnly = True
        Stud_StudContNum_Mtxt.Size = New Size(474, 51)
        Stud_StudContNum_Mtxt.TabIndex = 42
        ' 
        ' Stud_StudContNum_lbl
        ' 
        Stud_StudContNum_lbl.AutoSize = True
        Stud_StudContNum_lbl.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Stud_StudContNum_lbl.Location = New Point(71, 361)
        Stud_StudContNum_lbl.Name = "Stud_StudContNum_lbl"
        Stud_StudContNum_lbl.Size = New Size(318, 45)
        Stud_StudContNum_lbl.TabIndex = 41
        Stud_StudContNum_lbl.Text = "Contact Number:"
        ' 
        ' Stud_StudEmailAdd_txt
        ' 
        Stud_StudEmailAdd_txt.Enabled = False
        Stud_StudEmailAdd_txt.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Stud_StudEmailAdd_txt.Location = New Point(573, 420)
        Stud_StudEmailAdd_txt.Name = "Stud_StudEmailAdd_txt"
        Stud_StudEmailAdd_txt.ReadOnly = True
        Stud_StudEmailAdd_txt.Size = New Size(477, 51)
        Stud_StudEmailAdd_txt.TabIndex = 40
        ' 
        ' Stud_StudEmailAdd_lbl
        ' 
        Stud_StudEmailAdd_lbl.AutoSize = True
        Stud_StudEmailAdd_lbl.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Stud_StudEmailAdd_lbl.Location = New Point(573, 363)
        Stud_StudEmailAdd_lbl.Name = "Stud_StudEmailAdd_lbl"
        Stud_StudEmailAdd_lbl.Size = New Size(284, 45)
        Stud_StudEmailAdd_lbl.TabIndex = 39
        Stud_StudEmailAdd_lbl.Text = "Email Address:"
        ' 
        ' Stud_StudDeptID_Mtxt
        ' 
        Stud_StudDeptID_Mtxt.Enabled = False
        Stud_StudDeptID_Mtxt.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Stud_StudDeptID_Mtxt.Location = New Point(399, 267)
        Stud_StudDeptID_Mtxt.Mask = "D000"
        Stud_StudDeptID_Mtxt.Name = "Stud_StudDeptID_Mtxt"
        Stud_StudDeptID_Mtxt.ReadOnly = True
        Stud_StudDeptID_Mtxt.Size = New Size(264, 51)
        Stud_StudDeptID_Mtxt.TabIndex = 38
        ' 
        ' Stud_StudProgramID_Mtxt
        ' 
        Stud_StudProgramID_Mtxt.Enabled = False
        Stud_StudProgramID_Mtxt.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Stud_StudProgramID_Mtxt.Location = New Point(725, 267)
        Stud_StudProgramID_Mtxt.Mask = "P000"
        Stud_StudProgramID_Mtxt.Name = "Stud_StudProgramID_Mtxt"
        Stud_StudProgramID_Mtxt.ReadOnly = True
        Stud_StudProgramID_Mtxt.Size = New Size(256, 51)
        Stud_StudProgramID_Mtxt.TabIndex = 37
        ' 
        ' Stud_StudSection_txt
        ' 
        Stud_StudSection_txt.Enabled = False
        Stud_StudSection_txt.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Stud_StudSection_txt.Location = New Point(1584, 264)
        Stud_StudSection_txt.Name = "Stud_StudSection_txt"
        Stud_StudSection_txt.ReadOnly = True
        Stud_StudSection_txt.Size = New Size(264, 51)
        Stud_StudSection_txt.TabIndex = 28
        ' 
        ' Stud_StudSection_lbl
        ' 
        Stud_StudSection_lbl.AutoSize = True
        Stud_StudSection_lbl.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Stud_StudSection_lbl.Location = New Point(1584, 200)
        Stud_StudSection_lbl.Name = "Stud_StudSection_lbl"
        Stud_StudSection_lbl.Size = New Size(155, 45)
        Stud_StudSection_lbl.TabIndex = 27
        Stud_StudSection_lbl.Text = "Section:"
        ' 
        ' Stud_StudDeptID_lbl
        ' 
        Stud_StudDeptID_lbl.AutoSize = True
        Stud_StudDeptID_lbl.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Stud_StudDeptID_lbl.Location = New Point(399, 200)
        Stud_StudDeptID_lbl.Name = "Stud_StudDeptID_lbl"
        Stud_StudDeptID_lbl.Size = New Size(180, 45)
        Stud_StudDeptID_lbl.TabIndex = 23
        Stud_StudDeptID_lbl.Text = "Dept. ID:"
        ' 
        ' Stud_StudProgramID_lbl
        ' 
        Stud_StudProgramID_lbl.AutoSize = True
        Stud_StudProgramID_lbl.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Stud_StudProgramID_lbl.Location = New Point(725, 200)
        Stud_StudProgramID_lbl.Name = "Stud_StudProgramID_lbl"
        Stud_StudProgramID_lbl.Size = New Size(241, 45)
        Stud_StudProgramID_lbl.TabIndex = 21
        Stud_StudProgramID_lbl.Text = "Program ID:"
        ' 
        ' Stud_StudProgram_lbl
        ' 
        Stud_StudProgram_lbl.AutoSize = True
        Stud_StudProgram_lbl.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Stud_StudProgram_lbl.Location = New Point(1074, 200)
        Stud_StudProgram_lbl.Name = "Stud_StudProgram_lbl"
        Stud_StudProgram_lbl.Size = New Size(186, 45)
        Stud_StudProgram_lbl.TabIndex = 19
        Stud_StudProgram_lbl.Text = "Program:"
        ' 
        ' Stud_StudID_lbl
        ' 
        Stud_StudID_lbl.AutoSize = True
        Stud_StudID_lbl.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Stud_StudID_lbl.Location = New Point(71, 200)
        Stud_StudID_lbl.Name = "Stud_StudID_lbl"
        Stud_StudID_lbl.Size = New Size(218, 45)
        Stud_StudID_lbl.TabIndex = 15
        Stud_StudID_lbl.Text = "Student ID:"
        ' 
        ' Stud_Suffix_txt
        ' 
        Stud_Suffix_txt.Enabled = False
        Stud_Suffix_txt.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Stud_Suffix_txt.Location = New Point(1584, 98)
        Stud_Suffix_txt.Name = "Stud_Suffix_txt"
        Stud_Suffix_txt.ReadOnly = True
        Stud_Suffix_txt.Size = New Size(268, 51)
        Stud_Suffix_txt.TabIndex = 14
        ' 
        ' Stud_LName_txt
        ' 
        Stud_LName_txt.Enabled = False
        Stud_LName_txt.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Stud_LName_txt.Location = New Point(1082, 98)
        Stud_LName_txt.Name = "Stud_LName_txt"
        Stud_LName_txt.ReadOnly = True
        Stud_LName_txt.Size = New Size(477, 51)
        Stud_LName_txt.TabIndex = 13
        ' 
        ' Stud_MName_txt
        ' 
        Stud_MName_txt.Enabled = False
        Stud_MName_txt.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Stud_MName_txt.Location = New Point(573, 98)
        Stud_MName_txt.Name = "Stud_MName_txt"
        Stud_MName_txt.ReadOnly = True
        Stud_MName_txt.Size = New Size(477, 51)
        Stud_MName_txt.TabIndex = 12
        ' 
        ' Stud_FName_txt
        ' 
        Stud_FName_txt.Enabled = False
        Stud_FName_txt.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Stud_FName_txt.Location = New Point(68, 98)
        Stud_FName_txt.Name = "Stud_FName_txt"
        Stud_FName_txt.ReadOnly = True
        Stud_FName_txt.Size = New Size(477, 51)
        Stud_FName_txt.TabIndex = 11
        ' 
        ' Stud_Suffix_lbl
        ' 
        Stud_Suffix_lbl.AutoSize = True
        Stud_Suffix_lbl.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Stud_Suffix_lbl.Location = New Point(1584, 41)
        Stud_Suffix_lbl.Name = "Stud_Suffix_lbl"
        Stud_Suffix_lbl.Size = New Size(135, 45)
        Stud_Suffix_lbl.TabIndex = 10
        Stud_Suffix_lbl.Text = "Suffix:"
        ' 
        ' Stud_LName_lbl
        ' 
        Stud_LName_lbl.AutoSize = True
        Stud_LName_lbl.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Stud_LName_lbl.Location = New Point(1082, 41)
        Stud_LName_lbl.Name = "Stud_LName_lbl"
        Stud_LName_lbl.Size = New Size(220, 45)
        Stud_LName_lbl.TabIndex = 9
        Stud_LName_lbl.Text = "Last Name:"
        ' 
        ' Stud_MName_lbl
        ' 
        Stud_MName_lbl.AutoSize = True
        Stud_MName_lbl.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Stud_MName_lbl.Location = New Point(573, 41)
        Stud_MName_lbl.Name = "Stud_MName_lbl"
        Stud_MName_lbl.Size = New Size(266, 45)
        Stud_MName_lbl.TabIndex = 8
        Stud_MName_lbl.Text = "Middle Name:"
        ' 
        ' Stud_FName_lbl
        ' 
        Stud_FName_lbl.AutoSize = True
        Stud_FName_lbl.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Stud_FName_lbl.Location = New Point(68, 41)
        Stud_FName_lbl.Name = "Stud_FName_lbl"
        Stud_FName_lbl.Size = New Size(227, 45)
        Stud_FName_lbl.TabIndex = 7
        Stud_FName_lbl.Text = "First Name:"
        ' 
        ' ProfileTitle_Panel
        ' 
        ProfileTitle_Panel.Controls.Add(Stud_Profile_Lbl)
        ProfileTitle_Panel.Controls.Add(DarkBlue_Design2)
        ProfileTitle_Panel.Dock = DockStyle.Top
        ProfileTitle_Panel.Location = New Point(0, 0)
        ProfileTitle_Panel.Name = "ProfileTitle_Panel"
        ProfileTitle_Panel.Size = New Size(1902, 177)
        ProfileTitle_Panel.TabIndex = 11
        ' 
        ' Stud_Profile_Lbl
        ' 
        Stud_Profile_Lbl.AutoSize = True
        Stud_Profile_Lbl.Font = New Font("Times New Roman", 55.8000031F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Stud_Profile_Lbl.Location = New Point(132, 48)
        Stud_Profile_Lbl.Name = "Stud_Profile_Lbl"
        Stud_Profile_Lbl.Size = New Size(463, 105)
        Stud_Profile_Lbl.TabIndex = 8
        Stud_Profile_Lbl.Text = "PROFILE"
        Stud_Profile_Lbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' DarkBlue_Design2
        ' 
        DarkBlue_Design2.BackColor = Color.Navy
        DarkBlue_Design2.Location = New Point(68, 48)
        DarkBlue_Design2.Name = "DarkBlue_Design2"
        DarkBlue_Design2.Size = New Size(38, 105)
        DarkBlue_Design2.TabIndex = 10
        ' 
        ' Internship_Panel
        ' 
        Internship_Panel.Controls.Add(IntStatus_Panel)
        Internship_Panel.Controls.Add(InternTitle_Panel)
        Internship_Panel.Dock = DockStyle.Fill
        Internship_Panel.Location = New Point(0, 0)
        Internship_Panel.Name = "Internship_Panel"
        Internship_Panel.Size = New Size(1902, 830)
        Internship_Panel.TabIndex = 2
        ' 
        ' IntStatus_Panel
        ' 
        IntStatus_Panel.Controls.Add(Stud_InternSemester_cmb)
        IntStatus_Panel.Controls.Add(Stud_InternStatus_cmb)
        IntStatus_Panel.Controls.Add(Stud_InternStatus_lbl)
        IntStatus_Panel.Controls.Add(Stud_InternCompName_txt)
        IntStatus_Panel.Controls.Add(Stud_InternCompName_lbl)
        IntStatus_Panel.Controls.Add(Stud_InternSem_lbl)
        IntStatus_Panel.Controls.Add(Stud_InternSY_txt)
        IntStatus_Panel.Controls.Add(Stud_InternSY_lbl)
        IntStatus_Panel.Controls.Add(Stud_InternCompAdd_txt)
        IntStatus_Panel.Controls.Add(Stud_InternCompAdd_lbl)
        IntStatus_Panel.Controls.Add(Stud_InternCompID_Mtxt)
        IntStatus_Panel.Controls.Add(Stud_InternCompID_lbl)
        IntStatus_Panel.Controls.Add(Stud_InternEDate_txt)
        IntStatus_Panel.Controls.Add(Stud_InternEDate_lbl)
        IntStatus_Panel.Controls.Add(Stud_InternSDate_txt)
        IntStatus_Panel.Controls.Add(Stud_InternSDate_lbl)
        IntStatus_Panel.Controls.Add(Stud_SupervisorName_txt)
        IntStatus_Panel.Controls.Add(Stud_SupervisorName_lbl)
        IntStatus_Panel.Controls.Add(Stud_SupervisorID_Mtxt)
        IntStatus_Panel.Controls.Add(Stud_InternSupervisorID_lbl)
        IntStatus_Panel.Controls.Add(Stud_InternFacEvalName_txt)
        IntStatus_Panel.Controls.Add(Stud_InternFacEval_lbl)
        IntStatus_Panel.Controls.Add(Stud_InternFacID_Mtxt)
        IntStatus_Panel.Controls.Add(Stud_InternFacID_lbl)
        IntStatus_Panel.Controls.Add(Stud_InternID_Mtxt)
        IntStatus_Panel.Controls.Add(Stud_InternID_lbl)
        IntStatus_Panel.Dock = DockStyle.Fill
        IntStatus_Panel.Location = New Point(0, 177)
        IntStatus_Panel.Name = "IntStatus_Panel"
        IntStatus_Panel.Size = New Size(1902, 653)
        IntStatus_Panel.TabIndex = 14
        ' 
        ' Stud_InternSemester_cmb
        ' 
        Stud_InternSemester_cmb.Enabled = False
        Stud_InternSemester_cmb.Font = New Font("Segoe UI", 20F)
        Stud_InternSemester_cmb.FormattingEnabled = True
        Stud_InternSemester_cmb.Location = New Point(1497, 98)
        Stud_InternSemester_cmb.Name = "Stud_InternSemester_cmb"
        Stud_InternSemester_cmb.Size = New Size(242, 53)
        Stud_InternSemester_cmb.TabIndex = 65
        ' 
        ' Stud_InternStatus_cmb
        ' 
        Stud_InternStatus_cmb.Enabled = False
        Stud_InternStatus_cmb.Font = New Font("Segoe UI", 20F)
        Stud_InternStatus_cmb.FormattingEnabled = True
        Stud_InternStatus_cmb.Location = New Point(1497, 380)
        Stud_InternStatus_cmb.Name = "Stud_InternStatus_cmb"
        Stud_InternStatus_cmb.Size = New Size(242, 53)
        Stud_InternStatus_cmb.TabIndex = 64
        ' 
        ' Stud_InternStatus_lbl
        ' 
        Stud_InternStatus_lbl.AutoSize = True
        Stud_InternStatus_lbl.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Stud_InternStatus_lbl.Location = New Point(1497, 321)
        Stud_InternStatus_lbl.Name = "Stud_InternStatus_lbl"
        Stud_InternStatus_lbl.Size = New Size(138, 45)
        Stud_InternStatus_lbl.TabIndex = 63
        Stud_InternStatus_lbl.Text = "Status:"
        ' 
        ' Stud_InternCompName_txt
        ' 
        Stud_InternCompName_txt.Enabled = False
        Stud_InternCompName_txt.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Stud_InternCompName_txt.Location = New Point(514, 380)
        Stud_InternCompName_txt.Name = "Stud_InternCompName_txt"
        Stud_InternCompName_txt.ReadOnly = True
        Stud_InternCompName_txt.Size = New Size(818, 51)
        Stud_InternCompName_txt.TabIndex = 55
        ' 
        ' Stud_InternCompName_lbl
        ' 
        Stud_InternCompName_lbl.AutoSize = True
        Stud_InternCompName_lbl.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Stud_InternCompName_lbl.Location = New Point(514, 321)
        Stud_InternCompName_lbl.Name = "Stud_InternCompName_lbl"
        Stud_InternCompName_lbl.Size = New Size(358, 45)
        Stud_InternCompName_lbl.TabIndex = 54
        Stud_InternCompName_lbl.Text = "Company Assigned:"
        ' 
        ' Stud_InternSem_lbl
        ' 
        Stud_InternSem_lbl.AutoSize = True
        Stud_InternSem_lbl.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Stud_InternSem_lbl.Location = New Point(1486, 41)
        Stud_InternSem_lbl.Name = "Stud_InternSem_lbl"
        Stud_InternSem_lbl.Size = New Size(190, 45)
        Stud_InternSem_lbl.TabIndex = 52
        Stud_InternSem_lbl.Text = "Semester:"
        ' 
        ' Stud_InternSY_txt
        ' 
        Stud_InternSY_txt.Enabled = False
        Stud_InternSY_txt.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Stud_InternSY_txt.Location = New Point(1082, 98)
        Stud_InternSY_txt.Name = "Stud_InternSY_txt"
        Stud_InternSY_txt.ReadOnly = True
        Stud_InternSY_txt.Size = New Size(299, 51)
        Stud_InternSY_txt.TabIndex = 51
        ' 
        ' Stud_InternSY_lbl
        ' 
        Stud_InternSY_lbl.AutoSize = True
        Stud_InternSY_lbl.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Stud_InternSY_lbl.Location = New Point(1082, 41)
        Stud_InternSY_lbl.Name = "Stud_InternSY_lbl"
        Stud_InternSY_lbl.Size = New Size(233, 45)
        Stud_InternSY_lbl.TabIndex = 50
        Stud_InternSY_lbl.Text = "School Year:"
        ' 
        ' Stud_InternCompAdd_txt
        ' 
        Stud_InternCompAdd_txt.Enabled = False
        Stud_InternCompAdd_txt.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Stud_InternCompAdd_txt.Location = New Point(68, 522)
        Stud_InternCompAdd_txt.Name = "Stud_InternCompAdd_txt"
        Stud_InternCompAdd_txt.ReadOnly = True
        Stud_InternCompAdd_txt.Size = New Size(880, 51)
        Stud_InternCompAdd_txt.TabIndex = 49
        ' 
        ' Stud_InternCompAdd_lbl
        ' 
        Stud_InternCompAdd_lbl.AutoSize = True
        Stud_InternCompAdd_lbl.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Stud_InternCompAdd_lbl.Location = New Point(68, 474)
        Stud_InternCompAdd_lbl.Name = "Stud_InternCompAdd_lbl"
        Stud_InternCompAdd_lbl.Size = New Size(345, 45)
        Stud_InternCompAdd_lbl.TabIndex = 48
        Stud_InternCompAdd_lbl.Text = "Company Address:"
        ' 
        ' Stud_InternCompID_Mtxt
        ' 
        Stud_InternCompID_Mtxt.Enabled = False
        Stud_InternCompID_Mtxt.Font = New Font("Segoe UI", 20F)
        Stud_InternCompID_Mtxt.Location = New Point(68, 377)
        Stud_InternCompID_Mtxt.Mask = "\CO-000"
        Stud_InternCompID_Mtxt.Name = "Stud_InternCompID_Mtxt"
        Stud_InternCompID_Mtxt.ReadOnly = True
        Stud_InternCompID_Mtxt.Size = New Size(296, 52)
        Stud_InternCompID_Mtxt.TabIndex = 62
        ' 
        ' Stud_InternCompID_lbl
        ' 
        Stud_InternCompID_lbl.AutoSize = True
        Stud_InternCompID_lbl.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Stud_InternCompID_lbl.Location = New Point(68, 321)
        Stud_InternCompID_lbl.Name = "Stud_InternCompID_lbl"
        Stud_InternCompID_lbl.Size = New Size(252, 45)
        Stud_InternCompID_lbl.TabIndex = 45
        Stud_InternCompID_lbl.Text = "Company ID:"
        ' 
        ' Stud_InternEDate_txt
        ' 
        Stud_InternEDate_txt.Enabled = False
        Stud_InternEDate_txt.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Stud_InternEDate_txt.Location = New Point(725, 98)
        Stud_InternEDate_txt.Name = "Stud_InternEDate_txt"
        Stud_InternEDate_txt.ReadOnly = True
        Stud_InternEDate_txt.Size = New Size(280, 51)
        Stud_InternEDate_txt.TabIndex = 44
        ' 
        ' Stud_InternEDate_lbl
        ' 
        Stud_InternEDate_lbl.AutoSize = True
        Stud_InternEDate_lbl.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Stud_InternEDate_lbl.Location = New Point(725, 41)
        Stud_InternEDate_lbl.Name = "Stud_InternEDate_lbl"
        Stud_InternEDate_lbl.Size = New Size(193, 45)
        Stud_InternEDate_lbl.TabIndex = 43
        Stud_InternEDate_lbl.Text = "End Date:"
        ' 
        ' Stud_InternSDate_txt
        ' 
        Stud_InternSDate_txt.Enabled = False
        Stud_InternSDate_txt.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Stud_InternSDate_txt.Location = New Point(360, 98)
        Stud_InternSDate_txt.Name = "Stud_InternSDate_txt"
        Stud_InternSDate_txt.ReadOnly = True
        Stud_InternSDate_txt.Size = New Size(244, 51)
        Stud_InternSDate_txt.TabIndex = 42
        ' 
        ' Stud_InternSDate_lbl
        ' 
        Stud_InternSDate_lbl.AutoSize = True
        Stud_InternSDate_lbl.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Stud_InternSDate_lbl.Location = New Point(358, 41)
        Stud_InternSDate_lbl.Name = "Stud_InternSDate_lbl"
        Stud_InternSDate_lbl.Size = New Size(209, 45)
        Stud_InternSDate_lbl.TabIndex = 41
        Stud_InternSDate_lbl.Text = "Start Date:"
        ' 
        ' Stud_SupervisorName_txt
        ' 
        Stud_SupervisorName_txt.Enabled = False
        Stud_SupervisorName_txt.Font = New Font("Segoe UI", 20F)
        Stud_SupervisorName_txt.Location = New Point(1272, 231)
        Stud_SupervisorName_txt.Name = "Stud_SupervisorName_txt"
        Stud_SupervisorName_txt.ReadOnly = True
        Stud_SupervisorName_txt.Size = New Size(467, 52)
        Stud_SupervisorName_txt.TabIndex = 61
        ' 
        ' Stud_SupervisorName_lbl
        ' 
        Stud_SupervisorName_lbl.AutoSize = True
        Stud_SupervisorName_lbl.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Stud_SupervisorName_lbl.Location = New Point(1272, 179)
        Stud_SupervisorName_lbl.Name = "Stud_SupervisorName_lbl"
        Stud_SupervisorName_lbl.Size = New Size(218, 45)
        Stud_SupervisorName_lbl.TabIndex = 39
        Stud_SupervisorName_lbl.Text = "Supervisor:"
        ' 
        ' Stud_SupervisorID_Mtxt
        ' 
        Stud_SupervisorID_Mtxt.Enabled = False
        Stud_SupervisorID_Mtxt.Font = New Font("Segoe UI", 20F)
        Stud_SupervisorID_Mtxt.Location = New Point(918, 231)
        Stud_SupervisorID_Mtxt.Mask = "S000"
        Stud_SupervisorID_Mtxt.Name = "Stud_SupervisorID_Mtxt"
        Stud_SupervisorID_Mtxt.ReadOnly = True
        Stud_SupervisorID_Mtxt.Size = New Size(216, 52)
        Stud_SupervisorID_Mtxt.TabIndex = 58
        ' 
        ' Stud_InternSupervisorID_lbl
        ' 
        Stud_InternSupervisorID_lbl.AutoSize = True
        Stud_InternSupervisorID_lbl.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Stud_InternSupervisorID_lbl.Location = New Point(914, 180)
        Stud_InternSupervisorID_lbl.Name = "Stud_InternSupervisorID_lbl"
        Stud_InternSupervisorID_lbl.Size = New Size(272, 45)
        Stud_InternSupervisorID_lbl.TabIndex = 60
        Stud_InternSupervisorID_lbl.Text = "Supervisor ID:"
        ' 
        ' Stud_InternFacEvalName_txt
        ' 
        Stud_InternFacEvalName_txt.Enabled = False
        Stud_InternFacEvalName_txt.Font = New Font("Segoe UI", 20F)
        Stud_InternFacEvalName_txt.Location = New Point(360, 231)
        Stud_InternFacEvalName_txt.Name = "Stud_InternFacEvalName_txt"
        Stud_InternFacEvalName_txt.ReadOnly = True
        Stud_InternFacEvalName_txt.Size = New Size(492, 52)
        Stud_InternFacEvalName_txt.TabIndex = 59
        ' 
        ' Stud_InternFacEval_lbl
        ' 
        Stud_InternFacEval_lbl.AutoSize = True
        Stud_InternFacEval_lbl.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Stud_InternFacEval_lbl.Location = New Point(360, 180)
        Stud_InternFacEval_lbl.Name = "Stud_InternFacEval_lbl"
        Stud_InternFacEval_lbl.Size = New Size(339, 45)
        Stud_InternFacEval_lbl.TabIndex = 35
        Stud_InternFacEval_lbl.Text = "Faculty Evaluator:"
        ' 
        ' Stud_InternFacID_Mtxt
        ' 
        Stud_InternFacID_Mtxt.Enabled = False
        Stud_InternFacID_Mtxt.Font = New Font("Segoe UI", 20F)
        Stud_InternFacID_Mtxt.Location = New Point(68, 231)
        Stud_InternFacID_Mtxt.Mask = "F000"
        Stud_InternFacID_Mtxt.Name = "Stud_InternFacID_Mtxt"
        Stud_InternFacID_Mtxt.ReadOnly = True
        Stud_InternFacID_Mtxt.Size = New Size(215, 52)
        Stud_InternFacID_Mtxt.TabIndex = 57
        ' 
        ' Stud_InternFacID_lbl
        ' 
        Stud_InternFacID_lbl.AutoSize = True
        Stud_InternFacID_lbl.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Stud_InternFacID_lbl.Location = New Point(68, 179)
        Stud_InternFacID_lbl.Name = "Stud_InternFacID_lbl"
        Stud_InternFacID_lbl.Size = New Size(215, 45)
        Stud_InternFacID_lbl.TabIndex = 32
        Stud_InternFacID_lbl.Text = "Faculty ID:"
        ' 
        ' Stud_InternID_Mtxt
        ' 
        Stud_InternID_Mtxt.Enabled = False
        Stud_InternID_Mtxt.Font = New Font("Segoe UI", 20F)
        Stud_InternID_Mtxt.Location = New Point(68, 98)
        Stud_InternID_Mtxt.Mask = "I000"
        Stud_InternID_Mtxt.Name = "Stud_InternID_Mtxt"
        Stud_InternID_Mtxt.ReadOnly = True
        Stud_InternID_Mtxt.Size = New Size(195, 52)
        Stud_InternID_Mtxt.TabIndex = 56
        ' 
        ' Stud_InternID_lbl
        ' 
        Stud_InternID_lbl.AutoSize = True
        Stud_InternID_lbl.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Stud_InternID_lbl.Location = New Point(68, 41)
        Stud_InternID_lbl.Name = "Stud_InternID_lbl"
        Stud_InternID_lbl.Size = New Size(195, 45)
        Stud_InternID_lbl.TabIndex = 7
        Stud_InternID_lbl.Text = "Intern ID:"
        ' 
        ' InternTitle_Panel
        ' 
        InternTitle_Panel.Controls.Add(Stud_Internship_lbl)
        InternTitle_Panel.Controls.Add(DarkBlue_Design3)
        InternTitle_Panel.Dock = DockStyle.Top
        InternTitle_Panel.Location = New Point(0, 0)
        InternTitle_Panel.Name = "InternTitle_Panel"
        InternTitle_Panel.Size = New Size(1902, 177)
        InternTitle_Panel.TabIndex = 13
        ' 
        ' Stud_Internship_lbl
        ' 
        Stud_Internship_lbl.AutoSize = True
        Stud_Internship_lbl.Font = New Font("Times New Roman", 55.8000031F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Stud_Internship_lbl.Location = New Point(132, 48)
        Stud_Internship_lbl.Name = "Stud_Internship_lbl"
        Stud_Internship_lbl.Size = New Size(1002, 105)
        Stud_Internship_lbl.TabIndex = 11
        Stud_Internship_lbl.Text = "INTERNSHIP STATUS"
        Stud_Internship_lbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' DarkBlue_Design3
        ' 
        DarkBlue_Design3.BackColor = Color.Navy
        DarkBlue_Design3.Location = New Point(68, 48)
        DarkBlue_Design3.Name = "DarkBlue_Design3"
        DarkBlue_Design3.Size = New Size(38, 105)
        DarkBlue_Design3.TabIndex = 12
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 1000
        ' 
        ' Student_Dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1902, 1055)
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
        Resources_Panel.ResumeLayout(False)
        Resources_Panel.PerformLayout()
        Stud_Info_Panel.ResumeLayout(False)
        Stud_Info_Panel.PerformLayout()
        Profile_Panel.ResumeLayout(False)
        StudProfile_Panel.ResumeLayout(False)
        StudProfile_Panel.PerformLayout()
        ProfileTitle_Panel.ResumeLayout(False)
        ProfileTitle_Panel.PerformLayout()
        Internship_Panel.ResumeLayout(False)
        IntStatus_Panel.ResumeLayout(False)
        IntStatus_Panel.PerformLayout()
        InternTitle_Panel.ResumeLayout(False)
        InternTitle_Panel.PerformLayout()
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
    Friend WithEvents Internship_Panel As Panel
    Friend WithEvents Profile_Panel As Panel
    Friend WithEvents Stud_Greeting_lbl As Label
    Friend WithEvents Stud_User_lbl As Label
    Friend WithEvents Assigned_Label As Label
    Friend WithEvents Sup_Label As Label
    Friend WithEvents FacEval_Label As Label
    Friend WithEvents Cyanlike_Design As Panel
    Friend WithEvents LighterBlue_Design As Panel
    Friend WithEvents Blue_Design As Panel
    Friend WithEvents DBlue_Design As Panel
    Friend WithEvents FacEval_Placeholder_lbl As Label
    Friend WithEvents Supervised_Placeholder_lbl As Label
    Friend WithEvents Assigned_Placeholder_lbl As Label
    Friend WithEvents Resources_lbl As Label
    Friend WithEvents CompanyMOA_Linklbl As LinkLabel
    Friend WithEvents GradeSlip_Linklbl As LinkLabel
    Friend WithEvents OJT_Guidelines_Linklbl As LinkLabel
    Friend WithEvents Blue_Design1 As Panel
    Friend WithEvents Cyanlike_Design1 As Panel
    Friend WithEvents LighterBlue_Design1 As Panel
    Friend WithEvents Stud_Info_Panel As Panel
    Friend WithEvents Resources_Panel As Panel
    Friend WithEvents DarkBlue_Design2 As Panel
    Friend WithEvents Stud_Profile_Lbl As Label
    Friend WithEvents DarkBlue_Design3 As Panel
    Friend WithEvents Stud_Internship_lbl As Label
    Friend WithEvents ProfileTitle_Panel As Panel
    Friend WithEvents StudProfile_Panel As Panel
    Friend WithEvents Stud_Suffix_lbl As Label
    Friend WithEvents Stud_LName_lbl As Label
    Friend WithEvents Stud_MName_lbl As Label
    Friend WithEvents Stud_FName_lbl As Label
    Friend WithEvents Stud_Suffix_txt As TextBox
    Friend WithEvents Stud_LName_txt As TextBox
    Friend WithEvents Stud_MName_txt As TextBox
    Friend WithEvents Stud_FName_txt As TextBox
    Friend WithEvents Stud_StudID_lbl As Label
    Friend WithEvents Stud_StudDeptID_lbl As Label
    Friend WithEvents Stud_StudProgramID_lbl As Label
    Friend WithEvents Stud_StudProgram_lbl As Label
    Friend WithEvents Stud_StudSection_txt As TextBox
    Friend WithEvents Stud_StudSection_lbl As Label
    Friend WithEvents InternTitle_Panel As Panel
    Friend WithEvents IntStatus_Panel As Panel
    Friend WithEvents Stud_InternID_lbl As Label
    Friend WithEvents TextBox15 As TextBox
    Friend WithEvents Stud_Supervisor_lbl As Label
    Friend WithEvents Stud_InternFacEval_txt As TextBox
    Friend WithEvents Stud_InternFacEval_lbl As Label
    Friend WithEvents Stud_InternFacID_lbl As Label
    Friend WithEvents TextBox16 As TextBox
    Friend WithEvents Stud_SupervisorName_lbl As Label
    Friend WithEvents Stud_InternEDate_txt As TextBox
    Friend WithEvents Stud_InternEDate_lbl As Label
    Friend WithEvents Stud_InternSDate_txt As TextBox
    Friend WithEvents Stud_InternSDate_lbl As Label
    Friend WithEvents Stud_InternCompAdd_txt As TextBox
    Friend WithEvents Stud_InternCompAdd_lbl As Label
    Friend WithEvents Stud_InternCompID_lbl As Label
    Friend WithEvents Stud_InternSY_txt As TextBox
    Friend WithEvents Stud_InternSY_lbl As Label
    Friend WithEvents Stud_InternCompName_txt As TextBox
    Friend WithEvents Stud_InternCompName_lbl As Label
    Friend WithEvents Stud_InternSem_lbl As Label
    Friend WithEvents Stud_StudDeptID_Mtxt As MaskedTextBox
    Friend WithEvents Stud_StudProgramID_Mtxt As MaskedTextBox
    Friend WithEvents Stud_StudContNum_Mtxt As MaskedTextBox
    Friend WithEvents Stud_StudContNum_lbl As Label
    Friend WithEvents Stud_StudEmailAdd_txt As TextBox
    Friend WithEvents Stud_StudEmailAdd_lbl As Label
    Friend WithEvents Stud_ChangePass_btn As Button
    Friend WithEvents Stud_UpdateProfile_btn As Button
    Friend WithEvents Stud_StudentID_Mtxt As MaskedTextBox
    Friend WithEvents Stud_InternID_Mtxt As MaskedTextBox
    Friend WithEvents Stud_InternFacID_Mtxt As MaskedTextBox
    Friend WithEvents Stud_SupervisorID_Mtxt As MaskedTextBox
    Friend WithEvents Stud_InternFacEvalName_txt As TextBox
    Friend WithEvents Stud_SupervisorName_txt As TextBox
    Friend WithEvents Stud_InternSupervisorID_lbl As Label
    Friend WithEvents Stud_InternCompID_Mtxt As MaskedTextBox
    Friend WithEvents Stud_StudProgramName_txt As TextBox
    Friend WithEvents Stud_InternSemester_cmb As ComboBox
    Friend WithEvents Stud_InternStatus_cmb As ComboBox
    Friend WithEvents Stud_InternStatus_lbl As Label
    Friend WithEvents Stud_DateTimeNow_lbl As Label
    Friend WithEvents Timer1 As Timer
End Class
