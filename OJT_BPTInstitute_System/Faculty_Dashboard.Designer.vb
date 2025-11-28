<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Faculty_Dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Screen_Panel = New Panel()
        Home_Panel = New Panel()
        Fac_PendingEvals_lbl = New Label()
        DataGridView8 = New DataGridView()
        FacDGV_InternID = New DataGridViewTextBoxColumn()
        FacDGV_StudName = New DataGridViewTextBoxColumn()
        FacDGV_Course = New DataGridViewTextBoxColumn()
        FacDGV_Section = New DataGridViewTextBoxColumn()
        FacDGV_CompName = New DataGridViewTextBoxColumn()
        FacDGV_SVisor = New DataGridViewTextBoxColumn()
        FacDGV_FEval = New DataGridViewTextBoxColumn()
        FacDGV_Stat = New DataGridViewTextBoxColumn()
        Fac_Info_Panel = New Panel()
        Fac_DateTimeNow = New Label()
        Status_Position_lbl = New Label()
        Eval_Form = New LinkLabel()
        Department_lbl = New Label()
        Fac_Greeting_lbl = New Label()
        Fac_User_lbl = New Label()
        Cyanlike_Design = New Panel()
        LighterBlue_Design = New Panel()
        Blue_Design = New Panel()
        DBlue_Design = New Panel()
        Profile_Panel = New Panel()
        ProfTitle_Panel = New Panel()
        Fac_Profiletitle = New Label()
        Design = New Panel()
        FacProfile_Panel = New Panel()
        Faculty_FacEmpStat_txt = New TextBox()
        Faculty_FacEmpStat_lbl = New Label()
        Faculty_FacID_Mtxt = New MaskedTextBox()
        Faculty_FacPosition_txt = New TextBox()
        Faculty_FacPosition_lbl = New Label()
        Faculty_FacCPass_btn = New Button()
        Faculty_FacUpd_btn = New Button()
        Faculty_FacConNum_Mtxt = New MaskedTextBox()
        Faculty_FacContNum_lbl = New Label()
        Faculty_FacEmail_txt = New TextBox()
        Faculty_FacEmail_lbl = New Label()
        Faculty_FacDeptID_Mtxt = New MaskedTextBox()
        Faculty_FacDeptID_lbl = New Label()
        Faculty_FacDepartment_txt = New TextBox()
        Faculty_FacDeptartment_lbl = New Label()
        Faculty_FacID_lbl = New Label()
        Faculty_SName_txt = New TextBox()
        Faculty_LName_txt = New TextBox()
        Faculty_MName_txt = New TextBox()
        Faculty_FName_txt = New TextBox()
        Faculty_SName_lbl = New Label()
        Faculty_LName_lbl = New Label()
        Faculty_MName_lbl = New Label()
        Faculty_FName_lbl = New Label()
        Section_Panel = New Panel()
        Fac_SecSearch_btn = New Button()
        Fac_SecSearch_txt = New TextBox()
        Fac_Section_lbl = New Label()
        Fac_Section_cmb = New ComboBox()
        FilterSec_Panel = New Panel()
        CB_Dropped = New CheckBox()
        CB_Active = New CheckBox()
        CB_Complete = New CheckBox()
        CB_Pending = New CheckBox()
        SectionTitle_Panel = New Panel()
        Fac_SecTitle_lbl = New Label()
        Design2 = New Panel()
        Fac_SecInfo_DTV = New DataGridView()
        studID_col_lbl = New DataGridViewTextBoxColumn()
        studName_col_lbl = New DataGridViewTextBoxColumn()
        CompAssigned_col_lbl = New DataGridViewTextBoxColumn()
        Supervisor_col_column = New DataGridViewTextBoxColumn()
        Stat_col_lbl = New DataGridViewTextBoxColumn()
        Last_vis_col_lbl = New DataGridViewTextBoxColumn()
        Actions_col_lbl = New DataGridViewTextBoxColumn()
        MainMenu_Panel = New Panel()
        SchoolTitle_Panel = New Panel()
        Logo_Pic = New PictureBox()
        SchoolName_Lbl = New Label()
        RightTop_Panel = New Panel()
        Home_Linklbl = New LinkLabel()
        Profile_Linklbl = New LinkLabel()
        Logout_BTN = New LinkLabel()
        Section_Linklbl = New LinkLabel()
        Profile_lbl = New Label()
        Timer1 = New Timer(components)
        Screen_Panel.SuspendLayout()
        Home_Panel.SuspendLayout()
        CType(DataGridView8, ComponentModel.ISupportInitialize).BeginInit()
        Fac_Info_Panel.SuspendLayout()
        Profile_Panel.SuspendLayout()
        ProfTitle_Panel.SuspendLayout()
        FacProfile_Panel.SuspendLayout()
        Section_Panel.SuspendLayout()
        FilterSec_Panel.SuspendLayout()
        SectionTitle_Panel.SuspendLayout()
        CType(Fac_SecInfo_DTV, ComponentModel.ISupportInitialize).BeginInit()
        MainMenu_Panel.SuspendLayout()
        SchoolTitle_Panel.SuspendLayout()
        CType(Logo_Pic, ComponentModel.ISupportInitialize).BeginInit()
        RightTop_Panel.SuspendLayout()
        SuspendLayout()
        ' 
        ' Screen_Panel
        ' 
        Screen_Panel.BackColor = SystemColors.Control
        Screen_Panel.Controls.Add(Home_Panel)
        Screen_Panel.Controls.Add(Profile_Panel)
        Screen_Panel.Controls.Add(Section_Panel)
        Screen_Panel.Controls.Add(MainMenu_Panel)
        Screen_Panel.Dock = DockStyle.Fill
        Screen_Panel.Location = New Point(0, 0)
        Screen_Panel.Name = "Screen_Panel"
        Screen_Panel.Size = New Size(1902, 1055)
        Screen_Panel.TabIndex = 13
        ' 
        ' Home_Panel
        ' 
        Home_Panel.Controls.Add(Fac_PendingEvals_lbl)
        Home_Panel.Controls.Add(DataGridView8)
        Home_Panel.Controls.Add(Fac_Info_Panel)
        Home_Panel.Dock = DockStyle.Fill
        Home_Panel.Location = New Point(0, 225)
        Home_Panel.Name = "Home_Panel"
        Home_Panel.Size = New Size(1902, 830)
        Home_Panel.TabIndex = 16
        ' 
        ' Fac_PendingEvals_lbl
        ' 
        Fac_PendingEvals_lbl.AutoSize = True
        Fac_PendingEvals_lbl.BackColor = Color.Gold
        Fac_PendingEvals_lbl.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Fac_PendingEvals_lbl.ForeColor = SystemColors.MenuText
        Fac_PendingEvals_lbl.Location = New Point(62, 481)
        Fac_PendingEvals_lbl.Name = "Fac_PendingEvals_lbl"
        Fac_PendingEvals_lbl.Size = New Size(358, 32)
        Fac_PendingEvals_lbl.TabIndex = 22
        Fac_PendingEvals_lbl.Text = "PENDING EVALUATIONS"
        ' 
        ' DataGridView8
        ' 
        DataGridView8.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView8.Columns.AddRange(New DataGridViewColumn() {FacDGV_InternID, FacDGV_StudName, FacDGV_Course, FacDGV_Section, FacDGV_CompName, FacDGV_SVisor, FacDGV_FEval, FacDGV_Stat})
        DataGridView8.Location = New Point(62, 516)
        DataGridView8.Name = "DataGridView8"
        DataGridView8.RowHeadersWidth = 51
        DataGridView8.Size = New Size(1790, 290)
        DataGridView8.TabIndex = 23
        ' 
        ' FacDGV_InternID
        ' 
        FacDGV_InternID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        FacDGV_InternID.HeaderText = "INTERNSHIP ID"
        FacDGV_InternID.MinimumWidth = 6
        FacDGV_InternID.Name = "FacDGV_InternID"
        FacDGV_InternID.Width = 128
        ' 
        ' FacDGV_StudName
        ' 
        FacDGV_StudName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        FacDGV_StudName.HeaderText = "STUDENT NAME"
        FacDGV_StudName.MinimumWidth = 6
        FacDGV_StudName.Name = "FacDGV_StudName"
        ' 
        ' FacDGV_Course
        ' 
        FacDGV_Course.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        FacDGV_Course.HeaderText = "COURSE"
        FacDGV_Course.MinimumWidth = 6
        FacDGV_Course.Name = "FacDGV_Course"
        FacDGV_Course.Width = 93
        ' 
        ' FacDGV_Section
        ' 
        FacDGV_Section.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        FacDGV_Section.HeaderText = "SECTION"
        FacDGV_Section.MinimumWidth = 6
        FacDGV_Section.Name = "FacDGV_Section"
        FacDGV_Section.Width = 97
        ' 
        ' FacDGV_CompName
        ' 
        FacDGV_CompName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        FacDGV_CompName.HeaderText = "COMPANY NAME"
        FacDGV_CompName.MinimumWidth = 6
        FacDGV_CompName.Name = "FacDGV_CompName"
        ' 
        ' FacDGV_SVisor
        ' 
        FacDGV_SVisor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        FacDGV_SVisor.HeaderText = "SUPERVISOR"
        FacDGV_SVisor.MinimumWidth = 6
        FacDGV_SVisor.Name = "FacDGV_SVisor"
        ' 
        ' FacDGV_FEval
        ' 
        FacDGV_FEval.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        FacDGV_FEval.HeaderText = "FACULTY EVALUATOR"
        FacDGV_FEval.MinimumWidth = 6
        FacDGV_FEval.Name = "FacDGV_FEval"
        ' 
        ' FacDGV_Stat
        ' 
        FacDGV_Stat.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        FacDGV_Stat.HeaderText = "STATUS"
        FacDGV_Stat.MinimumWidth = 6
        FacDGV_Stat.Name = "FacDGV_Stat"
        FacDGV_Stat.Width = 88
        ' 
        ' Fac_Info_Panel
        ' 
        Fac_Info_Panel.Controls.Add(Fac_DateTimeNow)
        Fac_Info_Panel.Controls.Add(Status_Position_lbl)
        Fac_Info_Panel.Controls.Add(Eval_Form)
        Fac_Info_Panel.Controls.Add(Department_lbl)
        Fac_Info_Panel.Controls.Add(Fac_Greeting_lbl)
        Fac_Info_Panel.Controls.Add(Fac_User_lbl)
        Fac_Info_Panel.Controls.Add(Cyanlike_Design)
        Fac_Info_Panel.Controls.Add(LighterBlue_Design)
        Fac_Info_Panel.Controls.Add(Blue_Design)
        Fac_Info_Panel.Controls.Add(DBlue_Design)
        Fac_Info_Panel.Dock = DockStyle.Top
        Fac_Info_Panel.Location = New Point(0, 0)
        Fac_Info_Panel.Name = "Fac_Info_Panel"
        Fac_Info_Panel.Size = New Size(1902, 438)
        Fac_Info_Panel.TabIndex = 21
        ' 
        ' Fac_DateTimeNow
        ' 
        Fac_DateTimeNow.AutoSize = True
        Fac_DateTimeNow.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Fac_DateTimeNow.Location = New Point(1211, 45)
        Fac_DateTimeNow.Name = "Fac_DateTimeNow"
        Fac_DateTimeNow.Size = New Size(0, 45)
        Fac_DateTimeNow.TabIndex = 20
        ' 
        ' Status_Position_lbl
        ' 
        Status_Position_lbl.Font = New Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Status_Position_lbl.Location = New Point(145, 241)
        Status_Position_lbl.Name = "Status_Position_lbl"
        Status_Position_lbl.Size = New Size(706, 46)
        Status_Position_lbl.TabIndex = 19
        Status_Position_lbl.Text = "[ PLACEHOLDER ]"
        ' 
        ' Eval_Form
        ' 
        Eval_Form.ActiveLinkColor = Color.Goldenrod
        Eval_Form.AutoSize = True
        Eval_Form.Font = New Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Eval_Form.LinkColor = Color.Navy
        Eval_Form.Location = New Point(145, 356)
        Eval_Form.Name = "Eval_Form"
        Eval_Form.Size = New Size(461, 46)
        Eval_Form.TabIndex = 18
        Eval_Form.TabStop = True
        Eval_Form.Text = "Download Evaluation Form"
        ' 
        ' Department_lbl
        ' 
        Department_lbl.Font = New Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Department_lbl.Location = New Point(145, 300)
        Department_lbl.Name = "Department_lbl"
        Department_lbl.Size = New Size(706, 46)
        Department_lbl.TabIndex = 13
        Department_lbl.Text = "[ PLACEHOLDER ]"
        ' 
        ' Fac_Greeting_lbl
        ' 
        Fac_Greeting_lbl.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Fac_Greeting_lbl.Location = New Point(132, 48)
        Fac_Greeting_lbl.Name = "Fac_Greeting_lbl"
        Fac_Greeting_lbl.Size = New Size(325, 42)
        Fac_Greeting_lbl.TabIndex = 6
        Fac_Greeting_lbl.Text = "WELCOME,"
        ' 
        ' Fac_User_lbl
        ' 
        Fac_User_lbl.AutoSize = True
        Fac_User_lbl.Font = New Font("Times New Roman", 55.8000031F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Fac_User_lbl.Location = New Point(121, 90)
        Fac_User_lbl.Name = "Fac_User_lbl"
        Fac_User_lbl.Size = New Size(686, 105)
        Fac_User_lbl.TabIndex = 7
        Fac_User_lbl.Text = "[NAME HERE]"
        Fac_User_lbl.TextAlign = ContentAlignment.MiddleLeft
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
        LighterBlue_Design.Size = New Size(38, 46)
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
        Profile_Panel.Controls.Add(FacProfile_Panel)
        Profile_Panel.Controls.Add(ProfTitle_Panel)
        Profile_Panel.Dock = DockStyle.Fill
        Profile_Panel.Location = New Point(0, 225)
        Profile_Panel.Name = "Profile_Panel"
        Profile_Panel.Size = New Size(1902, 830)
        Profile_Panel.TabIndex = 8
        ' 
        ' ProfTitle_Panel
        ' 
        ProfTitle_Panel.Controls.Add(Fac_Profiletitle)
        ProfTitle_Panel.Controls.Add(Design)
        ProfTitle_Panel.Dock = DockStyle.Top
        ProfTitle_Panel.Location = New Point(0, 0)
        ProfTitle_Panel.Name = "ProfTitle_Panel"
        ProfTitle_Panel.Size = New Size(1902, 177)
        ProfTitle_Panel.TabIndex = 12
        ' 
        ' Fac_Profiletitle
        ' 
        Fac_Profiletitle.AutoSize = True
        Fac_Profiletitle.Font = New Font("Times New Roman", 55.8000031F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Fac_Profiletitle.Location = New Point(132, 48)
        Fac_Profiletitle.Name = "Fac_Profiletitle"
        Fac_Profiletitle.Size = New Size(463, 105)
        Fac_Profiletitle.TabIndex = 8
        Fac_Profiletitle.Text = "PROFILE"
        Fac_Profiletitle.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Design
        ' 
        Design.BackColor = Color.Navy
        Design.Location = New Point(68, 48)
        Design.Name = "Design"
        Design.Size = New Size(38, 105)
        Design.TabIndex = 10
        ' 
        ' FacProfile_Panel
        ' 
        FacProfile_Panel.Controls.Add(Faculty_FacEmpStat_txt)
        FacProfile_Panel.Controls.Add(Faculty_FacEmpStat_lbl)
        FacProfile_Panel.Controls.Add(Faculty_FacID_Mtxt)
        FacProfile_Panel.Controls.Add(Faculty_FacPosition_txt)
        FacProfile_Panel.Controls.Add(Faculty_FacPosition_lbl)
        FacProfile_Panel.Controls.Add(Faculty_FacCPass_btn)
        FacProfile_Panel.Controls.Add(Faculty_FacUpd_btn)
        FacProfile_Panel.Controls.Add(Faculty_FacConNum_Mtxt)
        FacProfile_Panel.Controls.Add(Faculty_FacContNum_lbl)
        FacProfile_Panel.Controls.Add(Faculty_FacEmail_txt)
        FacProfile_Panel.Controls.Add(Faculty_FacEmail_lbl)
        FacProfile_Panel.Controls.Add(Faculty_FacDeptID_Mtxt)
        FacProfile_Panel.Controls.Add(Faculty_FacDeptID_lbl)
        FacProfile_Panel.Controls.Add(Faculty_FacDepartment_txt)
        FacProfile_Panel.Controls.Add(Faculty_FacDeptartment_lbl)
        FacProfile_Panel.Controls.Add(Faculty_FacID_lbl)
        FacProfile_Panel.Controls.Add(Faculty_SName_txt)
        FacProfile_Panel.Controls.Add(Faculty_LName_txt)
        FacProfile_Panel.Controls.Add(Faculty_MName_txt)
        FacProfile_Panel.Controls.Add(Faculty_FName_txt)
        FacProfile_Panel.Controls.Add(Faculty_SName_lbl)
        FacProfile_Panel.Controls.Add(Faculty_LName_lbl)
        FacProfile_Panel.Controls.Add(Faculty_MName_lbl)
        FacProfile_Panel.Controls.Add(Faculty_FName_lbl)
        FacProfile_Panel.Dock = DockStyle.Fill
        FacProfile_Panel.Location = New Point(0, 177)
        FacProfile_Panel.Name = "FacProfile_Panel"
        FacProfile_Panel.Size = New Size(1902, 653)
        FacProfile_Panel.TabIndex = 13
        ' 
        ' Faculty_FacEmpStat_txt
        ' 
        Faculty_FacEmpStat_txt.Enabled = False
        Faculty_FacEmpStat_txt.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Faculty_FacEmpStat_txt.Location = New Point(1114, 264)
        Faculty_FacEmpStat_txt.Name = "Faculty_FacEmpStat_txt"
        Faculty_FacEmpStat_txt.Size = New Size(316, 51)
        Faculty_FacEmpStat_txt.TabIndex = 50
        ' 
        ' Faculty_FacEmpStat_lbl
        ' 
        Faculty_FacEmpStat_lbl.AutoSize = True
        Faculty_FacEmpStat_lbl.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Faculty_FacEmpStat_lbl.Location = New Point(1114, 200)
        Faculty_FacEmpStat_lbl.Name = "Faculty_FacEmpStat_lbl"
        Faculty_FacEmpStat_lbl.Size = New Size(316, 45)
        Faculty_FacEmpStat_lbl.TabIndex = 49
        Faculty_FacEmpStat_lbl.Text = "Employee Status:"
        ' 
        ' Faculty_FacID_Mtxt
        ' 
        Faculty_FacID_Mtxt.Enabled = False
        Faculty_FacID_Mtxt.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Faculty_FacID_Mtxt.Location = New Point(72, 264)
        Faculty_FacID_Mtxt.Mask = "F000"
        Faculty_FacID_Mtxt.Name = "Faculty_FacID_Mtxt"
        Faculty_FacID_Mtxt.Size = New Size(214, 51)
        Faculty_FacID_Mtxt.TabIndex = 47
        ' 
        ' Faculty_FacPosition_txt
        ' 
        Faculty_FacPosition_txt.Enabled = False
        Faculty_FacPosition_txt.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Faculty_FacPosition_txt.Location = New Point(1492, 264)
        Faculty_FacPosition_txt.Name = "Faculty_FacPosition_txt"
        Faculty_FacPosition_txt.Size = New Size(360, 51)
        Faculty_FacPosition_txt.TabIndex = 46
        ' 
        ' Faculty_FacPosition_lbl
        ' 
        Faculty_FacPosition_lbl.AutoSize = True
        Faculty_FacPosition_lbl.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Faculty_FacPosition_lbl.Location = New Point(1492, 200)
        Faculty_FacPosition_lbl.Name = "Faculty_FacPosition_lbl"
        Faculty_FacPosition_lbl.Size = New Size(168, 45)
        Faculty_FacPosition_lbl.TabIndex = 45
        Faculty_FacPosition_lbl.Text = "Position:"
        ' 
        ' Faculty_FacCPass_btn
        ' 
        Faculty_FacCPass_btn.BackColor = Color.Navy
        Faculty_FacCPass_btn.Font = New Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Faculty_FacCPass_btn.ForeColor = Color.Transparent
        Faculty_FacCPass_btn.Location = New Point(1114, 527)
        Faculty_FacCPass_btn.Name = "Faculty_FacCPass_btn"
        Faculty_FacCPass_btn.Size = New Size(362, 76)
        Faculty_FacCPass_btn.TabIndex = 44
        Faculty_FacCPass_btn.Text = "CHANGE PASSWORD"
        Faculty_FacCPass_btn.UseVisualStyleBackColor = False
        ' 
        ' Faculty_FacUpd_btn
        ' 
        Faculty_FacUpd_btn.BackColor = Color.Navy
        Faculty_FacUpd_btn.Font = New Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Faculty_FacUpd_btn.ForeColor = Color.Transparent
        Faculty_FacUpd_btn.Location = New Point(1486, 527)
        Faculty_FacUpd_btn.Name = "Faculty_FacUpd_btn"
        Faculty_FacUpd_btn.Size = New Size(362, 76)
        Faculty_FacUpd_btn.TabIndex = 43
        Faculty_FacUpd_btn.Text = "UPDATE PROFILE"
        Faculty_FacUpd_btn.UseVisualStyleBackColor = False
        ' 
        ' Faculty_FacConNum_Mtxt
        ' 
        Faculty_FacConNum_Mtxt.Enabled = False
        Faculty_FacConNum_Mtxt.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Faculty_FacConNum_Mtxt.Location = New Point(71, 420)
        Faculty_FacConNum_Mtxt.Mask = "+63000-000-0000"
        Faculty_FacConNum_Mtxt.Name = "Faculty_FacConNum_Mtxt"
        Faculty_FacConNum_Mtxt.Size = New Size(474, 51)
        Faculty_FacConNum_Mtxt.TabIndex = 42
        ' 
        ' Faculty_FacContNum_lbl
        ' 
        Faculty_FacContNum_lbl.AutoSize = True
        Faculty_FacContNum_lbl.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Faculty_FacContNum_lbl.Location = New Point(71, 363)
        Faculty_FacContNum_lbl.Name = "Faculty_FacContNum_lbl"
        Faculty_FacContNum_lbl.Size = New Size(318, 45)
        Faculty_FacContNum_lbl.TabIndex = 41
        Faculty_FacContNum_lbl.Text = "Contact Number:"
        ' 
        ' Faculty_FacEmail_txt
        ' 
        Faculty_FacEmail_txt.Enabled = False
        Faculty_FacEmail_txt.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Faculty_FacEmail_txt.Location = New Point(573, 420)
        Faculty_FacEmail_txt.Name = "Faculty_FacEmail_txt"
        Faculty_FacEmail_txt.Size = New Size(477, 51)
        Faculty_FacEmail_txt.TabIndex = 40
        ' 
        ' Faculty_FacEmail_lbl
        ' 
        Faculty_FacEmail_lbl.AutoSize = True
        Faculty_FacEmail_lbl.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Faculty_FacEmail_lbl.Location = New Point(573, 363)
        Faculty_FacEmail_lbl.Name = "Faculty_FacEmail_lbl"
        Faculty_FacEmail_lbl.Size = New Size(284, 45)
        Faculty_FacEmail_lbl.TabIndex = 39
        Faculty_FacEmail_lbl.Text = "Email Address:"
        ' 
        ' Faculty_FacDeptID_Mtxt
        ' 
        Faculty_FacDeptID_Mtxt.Enabled = False
        Faculty_FacDeptID_Mtxt.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Faculty_FacDeptID_Mtxt.Location = New Point(336, 264)
        Faculty_FacDeptID_Mtxt.Mask = "D000"
        Faculty_FacDeptID_Mtxt.Name = "Faculty_FacDeptID_Mtxt"
        Faculty_FacDeptID_Mtxt.Size = New Size(180, 51)
        Faculty_FacDeptID_Mtxt.TabIndex = 38
        ' 
        ' Faculty_FacDeptID_lbl
        ' 
        Faculty_FacDeptID_lbl.AutoSize = True
        Faculty_FacDeptID_lbl.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Faculty_FacDeptID_lbl.Location = New Point(336, 200)
        Faculty_FacDeptID_lbl.Name = "Faculty_FacDeptID_lbl"
        Faculty_FacDeptID_lbl.Size = New Size(180, 45)
        Faculty_FacDeptID_lbl.TabIndex = 23
        Faculty_FacDeptID_lbl.Text = "Dept. ID:"
        ' 
        ' Faculty_FacDepartment_txt
        ' 
        Faculty_FacDepartment_txt.Enabled = False
        Faculty_FacDepartment_txt.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Faculty_FacDepartment_txt.Location = New Point(573, 264)
        Faculty_FacDepartment_txt.Name = "Faculty_FacDepartment_txt"
        Faculty_FacDepartment_txt.Size = New Size(477, 51)
        Faculty_FacDepartment_txt.TabIndex = 20
        ' 
        ' Faculty_FacDeptartment_lbl
        ' 
        Faculty_FacDeptartment_lbl.AutoSize = True
        Faculty_FacDeptartment_lbl.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Faculty_FacDeptartment_lbl.Location = New Point(573, 200)
        Faculty_FacDeptartment_lbl.Name = "Faculty_FacDeptartment_lbl"
        Faculty_FacDeptartment_lbl.Size = New Size(239, 45)
        Faculty_FacDeptartment_lbl.TabIndex = 19
        Faculty_FacDeptartment_lbl.Text = "Department:"
        ' 
        ' Faculty_FacID_lbl
        ' 
        Faculty_FacID_lbl.AutoSize = True
        Faculty_FacID_lbl.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Faculty_FacID_lbl.Location = New Point(71, 200)
        Faculty_FacID_lbl.Name = "Faculty_FacID_lbl"
        Faculty_FacID_lbl.Size = New Size(215, 45)
        Faculty_FacID_lbl.TabIndex = 15
        Faculty_FacID_lbl.Text = "Faculty ID:"
        ' 
        ' Faculty_SName_txt
        ' 
        Faculty_SName_txt.Enabled = False
        Faculty_SName_txt.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Faculty_SName_txt.Location = New Point(1584, 98)
        Faculty_SName_txt.Name = "Faculty_SName_txt"
        Faculty_SName_txt.Size = New Size(268, 51)
        Faculty_SName_txt.TabIndex = 14
        ' 
        ' Faculty_LName_txt
        ' 
        Faculty_LName_txt.Enabled = False
        Faculty_LName_txt.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Faculty_LName_txt.Location = New Point(1082, 98)
        Faculty_LName_txt.Name = "Faculty_LName_txt"
        Faculty_LName_txt.Size = New Size(477, 51)
        Faculty_LName_txt.TabIndex = 13
        ' 
        ' Faculty_MName_txt
        ' 
        Faculty_MName_txt.Enabled = False
        Faculty_MName_txt.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Faculty_MName_txt.Location = New Point(573, 98)
        Faculty_MName_txt.Name = "Faculty_MName_txt"
        Faculty_MName_txt.Size = New Size(477, 51)
        Faculty_MName_txt.TabIndex = 12
        ' 
        ' Faculty_FName_txt
        ' 
        Faculty_FName_txt.Enabled = False
        Faculty_FName_txt.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Faculty_FName_txt.Location = New Point(68, 98)
        Faculty_FName_txt.Name = "Faculty_FName_txt"
        Faculty_FName_txt.Size = New Size(477, 51)
        Faculty_FName_txt.TabIndex = 11
        ' 
        ' Faculty_SName_lbl
        ' 
        Faculty_SName_lbl.AutoSize = True
        Faculty_SName_lbl.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Faculty_SName_lbl.Location = New Point(1584, 41)
        Faculty_SName_lbl.Name = "Faculty_SName_lbl"
        Faculty_SName_lbl.Size = New Size(135, 45)
        Faculty_SName_lbl.TabIndex = 10
        Faculty_SName_lbl.Text = "Suffix:"
        ' 
        ' Faculty_LName_lbl
        ' 
        Faculty_LName_lbl.AutoSize = True
        Faculty_LName_lbl.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Faculty_LName_lbl.Location = New Point(1082, 41)
        Faculty_LName_lbl.Name = "Faculty_LName_lbl"
        Faculty_LName_lbl.Size = New Size(220, 45)
        Faculty_LName_lbl.TabIndex = 9
        Faculty_LName_lbl.Text = "Last Name:"
        ' 
        ' Faculty_MName_lbl
        ' 
        Faculty_MName_lbl.AutoSize = True
        Faculty_MName_lbl.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Faculty_MName_lbl.Location = New Point(573, 41)
        Faculty_MName_lbl.Name = "Faculty_MName_lbl"
        Faculty_MName_lbl.Size = New Size(266, 45)
        Faculty_MName_lbl.TabIndex = 8
        Faculty_MName_lbl.Text = "Middle Name:"
        ' 
        ' Faculty_FName_lbl
        ' 
        Faculty_FName_lbl.AutoSize = True
        Faculty_FName_lbl.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Faculty_FName_lbl.Location = New Point(72, 41)
        Faculty_FName_lbl.Name = "Faculty_FName_lbl"
        Faculty_FName_lbl.Size = New Size(227, 45)
        Faculty_FName_lbl.TabIndex = 48
        Faculty_FName_lbl.Text = "First Name:"
        ' 
        ' Section_Panel
        ' 
        Section_Panel.Controls.Add(Fac_SecSearch_btn)
        Section_Panel.Controls.Add(Fac_SecSearch_txt)
        Section_Panel.Controls.Add(Fac_Section_lbl)
        Section_Panel.Controls.Add(Fac_Section_cmb)
        Section_Panel.Controls.Add(FilterSec_Panel)
        Section_Panel.Controls.Add(SectionTitle_Panel)
        Section_Panel.Controls.Add(Fac_SecInfo_DTV)
        Section_Panel.Dock = DockStyle.Fill
        Section_Panel.Location = New Point(0, 225)
        Section_Panel.Name = "Section_Panel"
        Section_Panel.Size = New Size(1902, 830)
        Section_Panel.TabIndex = 0
        ' 
        ' Fac_SecSearch_btn
        ' 
        Fac_SecSearch_btn.Location = New Point(1737, 256)
        Fac_SecSearch_btn.Name = "Fac_SecSearch_btn"
        Fac_SecSearch_btn.Size = New Size(88, 53)
        Fac_SecSearch_btn.TabIndex = 18
        Fac_SecSearch_btn.Text = "Button1"
        Fac_SecSearch_btn.UseVisualStyleBackColor = True
        ' 
        ' Fac_SecSearch_txt
        ' 
        Fac_SecSearch_txt.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Fac_SecSearch_txt.Location = New Point(1318, 258)
        Fac_SecSearch_txt.Name = "Fac_SecSearch_txt"
        Fac_SecSearch_txt.Size = New Size(413, 51)
        Fac_SecSearch_txt.TabIndex = 17
        ' 
        ' Fac_Section_lbl
        ' 
        Fac_Section_lbl.AutoSize = True
        Fac_Section_lbl.Location = New Point(68, 235)
        Fac_Section_lbl.Name = "Fac_Section_lbl"
        Fac_Section_lbl.Size = New Size(71, 20)
        Fac_Section_lbl.TabIndex = 16
        Fac_Section_lbl.Text = "SECTION:"
        ' 
        ' Fac_Section_cmb
        ' 
        Fac_Section_cmb.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Fac_Section_cmb.FormattingEnabled = True
        Fac_Section_cmb.Location = New Point(68, 258)
        Fac_Section_cmb.Name = "Fac_Section_cmb"
        Fac_Section_cmb.Size = New Size(296, 53)
        Fac_Section_cmb.TabIndex = 15
        ' 
        ' FilterSec_Panel
        ' 
        FilterSec_Panel.Controls.Add(CB_Dropped)
        FilterSec_Panel.Controls.Add(CB_Active)
        FilterSec_Panel.Controls.Add(CB_Complete)
        FilterSec_Panel.Controls.Add(CB_Pending)
        FilterSec_Panel.Location = New Point(429, 218)
        FilterSec_Panel.Name = "FilterSec_Panel"
        FilterSec_Panel.Size = New Size(270, 93)
        FilterSec_Panel.TabIndex = 14
        ' 
        ' CB_Dropped
        ' 
        CB_Dropped.AutoSize = True
        CB_Dropped.Location = New Point(144, 49)
        CB_Dropped.Name = "CB_Dropped"
        CB_Dropped.Size = New Size(91, 24)
        CB_Dropped.TabIndex = 3
        CB_Dropped.Text = "Dropped"
        CB_Dropped.UseVisualStyleBackColor = True
        ' 
        ' CB_Active
        ' 
        CB_Active.AutoSize = True
        CB_Active.Location = New Point(144, 19)
        CB_Active.Name = "CB_Active"
        CB_Active.Size = New Size(72, 24)
        CB_Active.TabIndex = 2
        CB_Active.Text = "Active"
        CB_Active.UseVisualStyleBackColor = True
        ' 
        ' CB_Complete
        ' 
        CB_Complete.AutoSize = True
        CB_Complete.Location = New Point(21, 49)
        CB_Complete.Name = "CB_Complete"
        CB_Complete.Size = New Size(96, 24)
        CB_Complete.TabIndex = 1
        CB_Complete.Text = "Complete"
        CB_Complete.UseVisualStyleBackColor = True
        ' 
        ' CB_Pending
        ' 
        CB_Pending.AutoSize = True
        CB_Pending.Location = New Point(21, 19)
        CB_Pending.Name = "CB_Pending"
        CB_Pending.Size = New Size(84, 24)
        CB_Pending.TabIndex = 0
        CB_Pending.Text = "Pending"
        CB_Pending.UseVisualStyleBackColor = True
        ' 
        ' SectionTitle_Panel
        ' 
        SectionTitle_Panel.Controls.Add(Fac_SecTitle_lbl)
        SectionTitle_Panel.Controls.Add(Design2)
        SectionTitle_Panel.Dock = DockStyle.Top
        SectionTitle_Panel.Location = New Point(0, 0)
        SectionTitle_Panel.Name = "SectionTitle_Panel"
        SectionTitle_Panel.Size = New Size(1902, 177)
        SectionTitle_Panel.TabIndex = 12
        ' 
        ' Fac_SecTitle_lbl
        ' 
        Fac_SecTitle_lbl.AutoSize = True
        Fac_SecTitle_lbl.Font = New Font("Times New Roman", 55.8000031F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Fac_SecTitle_lbl.Location = New Point(132, 48)
        Fac_SecTitle_lbl.Name = "Fac_SecTitle_lbl"
        Fac_SecTitle_lbl.Size = New Size(469, 105)
        Fac_SecTitle_lbl.TabIndex = 8
        Fac_SecTitle_lbl.Text = "SECTION"
        Fac_SecTitle_lbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Design2
        ' 
        Design2.BackColor = Color.Navy
        Design2.Location = New Point(68, 48)
        Design2.Name = "Design2"
        Design2.Size = New Size(38, 105)
        Design2.TabIndex = 10
        ' 
        ' Fac_SecInfo_DTV
        ' 
        Fac_SecInfo_DTV.AllowUserToOrderColumns = True
        Fac_SecInfo_DTV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Fac_SecInfo_DTV.Columns.AddRange(New DataGridViewColumn() {studID_col_lbl, studName_col_lbl, CompAssigned_col_lbl, Supervisor_col_column, Stat_col_lbl, Last_vis_col_lbl, Actions_col_lbl})
        Fac_SecInfo_DTV.Location = New Point(68, 317)
        Fac_SecInfo_DTV.Name = "Fac_SecInfo_DTV"
        Fac_SecInfo_DTV.RowHeadersWidth = 51
        Fac_SecInfo_DTV.Size = New Size(1757, 430)
        Fac_SecInfo_DTV.TabIndex = 4
        ' 
        ' studID_col_lbl
        ' 
        studID_col_lbl.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        studID_col_lbl.HeaderText = "STUDENT ID"
        studID_col_lbl.MinimumWidth = 6
        studID_col_lbl.Name = "studID_col_lbl"
        ' 
        ' studName_col_lbl
        ' 
        studName_col_lbl.HeaderText = "STUDENT NAME"
        studName_col_lbl.MinimumWidth = 6
        studName_col_lbl.Name = "studName_col_lbl"
        studName_col_lbl.Width = 275
        ' 
        ' CompAssigned_col_lbl
        ' 
        CompAssigned_col_lbl.HeaderText = "COMPANY ASSIGNED"
        CompAssigned_col_lbl.MinimumWidth = 6
        CompAssigned_col_lbl.Name = "CompAssigned_col_lbl"
        CompAssigned_col_lbl.Width = 325
        ' 
        ' Supervisor_col_column
        ' 
        Supervisor_col_column.HeaderText = "SUPERVISOR"
        Supervisor_col_column.MinimumWidth = 6
        Supervisor_col_column.Name = "Supervisor_col_column"
        Supervisor_col_column.Width = 275
        ' 
        ' Stat_col_lbl
        ' 
        Stat_col_lbl.HeaderText = "STATUS"
        Stat_col_lbl.MinimumWidth = 6
        Stat_col_lbl.Name = "Stat_col_lbl"
        Stat_col_lbl.Width = 125
        ' 
        ' Last_vis_col_lbl
        ' 
        Last_vis_col_lbl.HeaderText = "LAST VISIT"
        Last_vis_col_lbl.MinimumWidth = 6
        Last_vis_col_lbl.Name = "Last_vis_col_lbl"
        Last_vis_col_lbl.Width = 125
        ' 
        ' Actions_col_lbl
        ' 
        Actions_col_lbl.HeaderText = "ACTIONS"
        Actions_col_lbl.MinimumWidth = 6
        Actions_col_lbl.Name = "Actions_col_lbl"
        Actions_col_lbl.Width = 250
        ' 
        ' MainMenu_Panel
        ' 
        MainMenu_Panel.BackColor = Color.Navy
        MainMenu_Panel.Controls.Add(SchoolTitle_Panel)
        MainMenu_Panel.Controls.Add(RightTop_Panel)
        MainMenu_Panel.Dock = DockStyle.Top
        MainMenu_Panel.Location = New Point(0, 0)
        MainMenu_Panel.Name = "MainMenu_Panel"
        MainMenu_Panel.Size = New Size(1902, 225)
        MainMenu_Panel.TabIndex = 15
        ' 
        ' SchoolTitle_Panel
        ' 
        SchoolTitle_Panel.Controls.Add(Logo_Pic)
        SchoolTitle_Panel.Controls.Add(SchoolName_Lbl)
        SchoolTitle_Panel.Dock = DockStyle.Left
        SchoolTitle_Panel.Location = New Point(0, 0)
        SchoolTitle_Panel.Name = "SchoolTitle_Panel"
        SchoolTitle_Panel.Size = New Size(735, 225)
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
        SchoolName_Lbl.Size = New Size(359, 175)
        SchoolName_Lbl.TabIndex = 10
        SchoolName_Lbl.Text = "Bright Path " & vbCrLf & "Technical " & vbCrLf & "Institute"
        SchoolName_Lbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' RightTop_Panel
        ' 
        RightTop_Panel.Controls.Add(Home_Linklbl)
        RightTop_Panel.Controls.Add(Profile_Linklbl)
        RightTop_Panel.Controls.Add(Logout_BTN)
        RightTop_Panel.Controls.Add(Section_Linklbl)
        RightTop_Panel.Dock = DockStyle.Right
        RightTop_Panel.Location = New Point(1159, 0)
        RightTop_Panel.Name = "RightTop_Panel"
        RightTop_Panel.Size = New Size(743, 225)
        RightTop_Panel.TabIndex = 11
        ' 
        ' Home_Linklbl
        ' 
        Home_Linklbl.ActiveLinkColor = Color.Goldenrod
        Home_Linklbl.BackColor = Color.Navy
        Home_Linklbl.Font = New Font("Arial Rounded MT Bold", 16.2F)
        Home_Linklbl.LinkColor = Color.White
        Home_Linklbl.Location = New Point(116, 3)
        Home_Linklbl.Name = "Home_Linklbl"
        Home_Linklbl.Size = New Size(121, 149)
        Home_Linklbl.TabIndex = 11
        Home_Linklbl.TabStop = True
        Home_Linklbl.Text = "HOME"
        Home_Linklbl.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Profile_Linklbl
        ' 
        Profile_Linklbl.ActiveLinkColor = Color.Goldenrod
        Profile_Linklbl.BackColor = Color.Navy
        Profile_Linklbl.Font = New Font("Arial Rounded MT Bold", 16.2F)
        Profile_Linklbl.LinkColor = Color.White
        Profile_Linklbl.Location = New Point(243, 3)
        Profile_Linklbl.Name = "Profile_Linklbl"
        Profile_Linklbl.Size = New Size(152, 149)
        Profile_Linklbl.TabIndex = 10
        Profile_Linklbl.TabStop = True
        Profile_Linklbl.Text = "PROFILE"
        Profile_Linklbl.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Logout_BTN
        ' 
        Logout_BTN.ActiveLinkColor = Color.Goldenrod
        Logout_BTN.BackColor = Color.Navy
        Logout_BTN.Font = New Font("Arial Rounded MT Bold", 16.2F)
        Logout_BTN.LinkColor = Color.White
        Logout_BTN.Location = New Point(559, 3)
        Logout_BTN.Name = "Logout_BTN"
        Logout_BTN.Size = New Size(159, 149)
        Logout_BTN.TabIndex = 9
        Logout_BTN.TabStop = True
        Logout_BTN.Text = "LOGOUT"
        Logout_BTN.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Section_Linklbl
        ' 
        Section_Linklbl.ActiveLinkColor = Color.Goldenrod
        Section_Linklbl.BackColor = Color.Navy
        Section_Linklbl.Font = New Font("Arial Rounded MT Bold", 16.2F)
        Section_Linklbl.LinkColor = Color.White
        Section_Linklbl.Location = New Point(401, 3)
        Section_Linklbl.Name = "Section_Linklbl"
        Section_Linklbl.Size = New Size(152, 149)
        Section_Linklbl.TabIndex = 8
        Section_Linklbl.TabStop = True
        Section_Linklbl.Text = "SECTION"
        Section_Linklbl.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Profile_lbl
        ' 
        Profile_lbl.Location = New Point(0, 0)
        Profile_lbl.Name = "Profile_lbl"
        Profile_lbl.Size = New Size(100, 23)
        Profile_lbl.TabIndex = 0
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 1000
        ' 
        ' Faculty_Dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(1902, 1055)
        Controls.Add(Screen_Panel)
        Name = "Faculty_Dashboard"
        Text = "w"
        WindowState = FormWindowState.Maximized
        Screen_Panel.ResumeLayout(False)
        Home_Panel.ResumeLayout(False)
        Home_Panel.PerformLayout()
        CType(DataGridView8, ComponentModel.ISupportInitialize).EndInit()
        Fac_Info_Panel.ResumeLayout(False)
        Fac_Info_Panel.PerformLayout()
        Profile_Panel.ResumeLayout(False)
        ProfTitle_Panel.ResumeLayout(False)
        ProfTitle_Panel.PerformLayout()
        FacProfile_Panel.ResumeLayout(False)
        FacProfile_Panel.PerformLayout()
        Section_Panel.ResumeLayout(False)
        Section_Panel.PerformLayout()
        FilterSec_Panel.ResumeLayout(False)
        FilterSec_Panel.PerformLayout()
        SectionTitle_Panel.ResumeLayout(False)
        SectionTitle_Panel.PerformLayout()
        CType(Fac_SecInfo_DTV, ComponentModel.ISupportInitialize).EndInit()
        MainMenu_Panel.ResumeLayout(False)
        SchoolTitle_Panel.ResumeLayout(False)
        CType(Logo_Pic, ComponentModel.ISupportInitialize).EndInit()
        RightTop_Panel.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents Screen_Panel As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Home_Panel As Panel
    Friend WithEvents DeptName_lbl As Label
    Friend WithEvents Time_Position_lbl As Label
    Friend WithEvents FacName_lbl As Label
    Friend WithEvents Greet_Fac_lbl As Label
    Friend WithEvents MainMenu_Panel As Panel
    Friend WithEvents SchoolTitle_Panel As Panel
    Friend WithEvents Logo_Pic As PictureBox
    Friend WithEvents SchoolName_Lbl As Label
    Friend WithEvents RightTop_Panel As Panel
    Friend WithEvents Logout_BTN As LinkLabel
    Friend WithEvents Section_Linklbl As LinkLabel
    Friend WithEvents Home_Linklbl As LinkLabel
    Friend WithEvents Profile_Linklbl As LinkLabel
    Friend WithEvents Section_Panel As Panel
    Friend WithEvents Faculty_DateTime As Label
    Friend WithEvents Fac_SecInfo_DTV As DataGridView
    Friend WithEvents FacInfo_Panel As Panel
    Friend WithEvents Fac_DeptName_lbl As Label
    Friend WithEvents Fac_DeptName__lbl As Label
    Friend WithEvents Fac_DeptID__lbl As Label
    Friend WithEvents Fac_FacID__lbl As Label
    Friend WithEvents Fac_Suffix_lbl As Label
    Friend WithEvents Fac_LName_lbl As Label
    Friend WithEvents Fac_MName_lbl As Label
    Friend WithEvents Fac_Suffix_txt As TextBox
    Friend WithEvents Fac_LName_txt As TextBox
    Friend WithEvents Fac_FName_txt As TextBox
    Friend WithEvents Fac_MName_txt As TextBox
    Friend WithEvents Profile_lbl As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Design2 As Panel
    Friend WithEvents SectionTitle_Panel As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SecTitle_Panel As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Fac_SecSearch_btn As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Profile_Panel As Panel
    Friend WithEvents Fac_SecTitle_lbl As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Fac_DateTimeNow As Label
    Friend WithEvents ProfTitle_Panel As Panel
    Friend WithEvents Fac_Profiletitle As Label
    Friend WithEvents Design As Panel
    Friend WithEvents FilterSec_Panel As Panel
    Friend WithEvents CB_Dropped As CheckBox
    Friend WithEvents CB_Active As CheckBox
    Friend WithEvents CB_Complete As CheckBox
    Friend WithEvents CB_Pending As CheckBox
    Friend WithEvents Fac_Section_lbl As Label
    Friend WithEvents Fac_Section_cmb As ComboBox
    Friend WithEvents Fac_SecSearch_txt As TextBox
    Friend WithEvents studID_col_lbl As DataGridViewTextBoxColumn
    Friend WithEvents studName_col_lbl As DataGridViewTextBoxColumn
    Friend WithEvents CompAssigned_col_lbl As DataGridViewTextBoxColumn
    Friend WithEvents Supervisor_col_column As DataGridViewTextBoxColumn
    Friend WithEvents Stat_col_lbl As DataGridViewTextBoxColumn
    Friend WithEvents Last_vis_col_lbl As DataGridViewTextBoxColumn
    Friend WithEvents Actions_col_lbl As DataGridViewTextBoxColumn
    Friend WithEvents FacProfile_Panel As Panel
    Friend WithEvents Faculty_FacCPass_btn As Button
    Friend WithEvents Faculty_FacUpd_btn As Button
    Friend WithEvents Faculty_FacConNum_Mtxt As MaskedTextBox
    Friend WithEvents Faculty_FacContNum_lbl As Label
    Friend WithEvents Faculty_FacEmail_txt As TextBox
    Friend WithEvents Faculty_FacEmail_lbl As Label
    Friend WithEvents Faculty_FacDeptID_Mtxt As MaskedTextBox
    Friend WithEvents Faculty_FacDeptID_lbl As Label
    Friend WithEvents Faculty_FacDepartment_txt As TextBox
    Friend WithEvents Faculty_FacDeptartment_lbl As Label
    Friend WithEvents Faculty_FacID_lbl As Label
    Friend WithEvents Faculty_SName_txt As TextBox
    Friend WithEvents Faculty_LName_txt As TextBox
    Friend WithEvents Faculty_MName_txt As TextBox
    Friend WithEvents Faculty_FName_txt As TextBox
    Friend WithEvents Faculty_SName_lbl As Label
    Friend WithEvents Faculty_LName_lbl As Label
    Friend WithEvents Faculty_MName_lbl As Label
    Friend WithEvents Faculty_FacPosition_txt As TextBox
    Friend WithEvents Faculty_FacPosition_lbl As Label
    Friend WithEvents Faculty_FacID_Mtxt As MaskedTextBox
    Friend WithEvents Fac_Info_Panel As Panel
    Friend WithEvents Fac_Greeting_lbl As Label
    Friend WithEvents Fac_User_lbl As Label
    Friend WithEvents Assigned_Label As Label
    Friend WithEvents Sup_Label As Label
    Friend WithEvents Assigned_Placeholder_lbl As Label
    Friend WithEvents Department_lbl As Label
    Friend WithEvents Cyanlike_Design As Panel
    Friend WithEvents LighterBlue_Design As Panel
    Friend WithEvents Blue_Design As Panel
    Friend WithEvents DBlue_Design As Panel
    Friend WithEvents Eval_Form As LinkLabel
    Friend WithEvents Fac_PendingEvals_lbl As Label
    Friend WithEvents DataGridView8 As DataGridView
    Friend WithEvents FacDGV_InternID As DataGridViewTextBoxColumn
    Friend WithEvents FacDGV_StudName As DataGridViewTextBoxColumn
    Friend WithEvents FacDGV_Course As DataGridViewTextBoxColumn
    Friend WithEvents FacDGV_Section As DataGridViewTextBoxColumn
    Friend WithEvents FacDGV_CompName As DataGridViewTextBoxColumn
    Friend WithEvents FacDGV_SVisor As DataGridViewTextBoxColumn
    Friend WithEvents FacDGV_FEval As DataGridViewTextBoxColumn
    Friend WithEvents FacDGV_Stat As DataGridViewTextBoxColumn
    Friend WithEvents Status_Position_lbl As Label
    Friend WithEvents Faculty_FName_lbl As Label
    Friend WithEvents Faculty_FacEmpStat_txt As TextBox
    Friend WithEvents Faculty_FacEmpStat_lbl As Label
End Class
