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
        Fac_PendEval_DGV = New DataGridView()
        FacDGV_InternID = New DataGridViewTextBoxColumn()
        FacDGV_StudName = New DataGridViewTextBoxColumn()
        FacDGV_Program = New DataGridViewTextBoxColumn()
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
        Grade_Panel = New Panel()
        Fac_MidGrade_Panel = New Panel()
        Fac_MidGrade_DGV = New DataGridView()
        MG_studID_col_lbl = New DataGridViewTextBoxColumn()
        MG_studName_col_lbl = New DataGridViewTextBoxColumn()
        MG_program_col_lbl = New DataGridViewTextBoxColumn()
        MG_section_col_lbl = New DataGridViewTextBoxColumn()
        MG_week1_col_lbl = New DataGridViewTextBoxColumn()
        MG_week2_col_lbl = New DataGridViewTextBoxColumn()
        MG_week3_col_lbl = New DataGridViewTextBoxColumn()
        MG_week4_col_lbl = New DataGridViewTextBoxColumn()
        MG_week5_col_lbl = New DataGridViewTextBoxColumn()
        MG_week6_col_lbl = New DataGridViewTextBoxColumn()
        MG_week7_col_lbl = New DataGridViewTextBoxColumn()
        MG_week8_col_lbl = New DataGridViewTextBoxColumn()
        MG_week9_col_lbl = New DataGridViewTextBoxColumn()
        Fac_GMImportCSV_btn = New Button()
        Fac_GMSaveDB_btn = New Button()
        Fac_MidFin_Panel = New Panel()
        Fac_FinGrade_btn = New Button()
        Fac_MidGrade_btn = New Button()
        Fac_FinGrade_Panel = New Panel()
        Fac_FinGrade_DGV = New DataGridView()
        FG_studID_col_lbl = New DataGridViewTextBoxColumn()
        FG_studName_col_lbl = New DataGridViewTextBoxColumn()
        FG_program_col_lbl = New DataGridViewTextBoxColumn()
        FG_section_col_lbl = New DataGridViewTextBoxColumn()
        FG_week10_col_lbl = New DataGridViewTextBoxColumn()
        FG_week1_col_lbl = New DataGridViewTextBoxColumn()
        FG_week12_col_lbl = New DataGridViewTextBoxColumn()
        FG_week13_col_lbl = New DataGridViewTextBoxColumn()
        FG_week14_col_lbl = New DataGridViewTextBoxColumn()
        FG_week15_col_lbl = New DataGridViewTextBoxColumn()
        FG_week16_col_lbl = New DataGridViewTextBoxColumn()
        FG_week17_col_lbl = New DataGridViewTextBoxColumn()
        FG_week18_col_lbl = New DataGridViewTextBoxColumn()
        Fac_GFImportCSV_btn = New Button()
        Fac_GFSaveDB_btn = New Button()
        GradeTitle_Panel = New Panel()
        Fac_GSection_lbl = New Label()
        Fac_GSection_cmb = New ComboBox()
        Fac_GSecFilter_btn = New Button()
        Fac_GSecSearch_btn = New Button()
        Fac_GSecSearch_txt = New TextBox()
        Fac_GradeTitle_lbl = New Label()
        Fac_GProgram_lbl = New Label()
        Design3 = New Panel()
        Fac_GProgram_cmb = New ComboBox()
        Section_Panel = New Panel()
        Fac_SaveDB_btn = New Button()
        Fac_ImportCSV_btn = New Button()
        SectionTitle_Panel = New Panel()
        Fac_Section_lbl = New Label()
        Fac_Section_cmb = New ComboBox()
        Fac_SecFilter_btn = New Button()
        Fac_SecSearch_btn = New Button()
        Fac_SecSearch_txt = New TextBox()
        Fac_SecTitle_lbl = New Label()
        Fac_Program_lbl = New Label()
        Design2 = New Panel()
        Fac_Program_cmb = New ComboBox()
        Fac_SecInfo_DGV = New DataGridView()
        studID_col_lbl = New DataGridViewTextBoxColumn()
        studLName_col_lbl = New DataGridViewTextBoxColumn()
        studFName_col_lbl = New DataGridViewTextBoxColumn()
        studMName_col_lbl = New DataGridViewTextBoxColumn()
        studSName_col_lbl = New DataGridViewTextBoxColumn()
        depID_col_lbl = New DataGridViewTextBoxColumn()
        progID_col_lbl = New DataGridViewTextBoxColumn()
        studSec_col_lbl = New DataGridViewTextBoxColumn()
        studStat_col_lbl = New DataGridViewTextBoxColumn()
        Profile_Panel = New Panel()
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
        ProfTitle_Panel = New Panel()
        Fac_Profiletitle = New Label()
        Design = New Panel()
        MainMenu_Panel = New Panel()
        SchoolTitle_Panel = New Panel()
        Logo_Pic = New PictureBox()
        SchoolName_Lbl = New Label()
        RightTop_Panel = New Panel()
        Grade_Linklbl = New LinkLabel()
        Home_Linklbl = New LinkLabel()
        Profile_Linklbl = New LinkLabel()
        Logout_BTN = New LinkLabel()
        Section_Linklbl = New LinkLabel()
        Profile_lbl = New Label()
        Timer1 = New Timer(components)
        Screen_Panel.SuspendLayout()
        Home_Panel.SuspendLayout()
        CType(Fac_PendEval_DGV, ComponentModel.ISupportInitialize).BeginInit()
        Fac_Info_Panel.SuspendLayout()
        Grade_Panel.SuspendLayout()
        Fac_MidGrade_Panel.SuspendLayout()
        CType(Fac_MidGrade_DGV, ComponentModel.ISupportInitialize).BeginInit()
        Fac_MidFin_Panel.SuspendLayout()
        Fac_FinGrade_Panel.SuspendLayout()
        CType(Fac_FinGrade_DGV, ComponentModel.ISupportInitialize).BeginInit()
        GradeTitle_Panel.SuspendLayout()
        Section_Panel.SuspendLayout()
        SectionTitle_Panel.SuspendLayout()
        CType(Fac_SecInfo_DGV, ComponentModel.ISupportInitialize).BeginInit()
        Profile_Panel.SuspendLayout()
        FacProfile_Panel.SuspendLayout()
        ProfTitle_Panel.SuspendLayout()
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
        Screen_Panel.Controls.Add(Grade_Panel)
        Screen_Panel.Controls.Add(Section_Panel)
        Screen_Panel.Controls.Add(Profile_Panel)
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
        Home_Panel.Controls.Add(Fac_PendEval_DGV)
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
        Fac_PendingEvals_lbl.Location = New Point(62, 454)
        Fac_PendingEvals_lbl.Name = "Fac_PendingEvals_lbl"
        Fac_PendingEvals_lbl.Size = New Size(360, 32)
        Fac_PendingEvals_lbl.TabIndex = 22
        Fac_PendingEvals_lbl.Text = "STUDENT INFORMATION"
        ' 
        ' Fac_PendEval_DGV
        ' 
        Fac_PendEval_DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Fac_PendEval_DGV.Columns.AddRange(New DataGridViewColumn() {FacDGV_InternID, FacDGV_StudName, FacDGV_Program, FacDGV_Section, FacDGV_CompName, FacDGV_SVisor, FacDGV_FEval, FacDGV_Stat})
        Fac_PendEval_DGV.Location = New Point(62, 489)
        Fac_PendEval_DGV.Name = "Fac_PendEval_DGV"
        Fac_PendEval_DGV.RowHeadersWidth = 51
        Fac_PendEval_DGV.Size = New Size(1790, 317)
        Fac_PendEval_DGV.TabIndex = 23
        ' 
        ' FacDGV_InternID
        ' 
        FacDGV_InternID.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
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
        ' FacDGV_Program
        ' 
        FacDGV_Program.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        FacDGV_Program.HeaderText = "PROGRAM"
        FacDGV_Program.MinimumWidth = 6
        FacDGV_Program.Name = "FacDGV_Program"
        FacDGV_Program.Width = 108
        ' 
        ' FacDGV_Section
        ' 
        FacDGV_Section.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
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
        FacDGV_Stat.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
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
        ' Grade_Panel
        ' 
        Grade_Panel.Controls.Add(Fac_MidGrade_Panel)
        Grade_Panel.Controls.Add(Fac_MidFin_Panel)
        Grade_Panel.Controls.Add(Fac_FinGrade_Panel)
        Grade_Panel.Controls.Add(GradeTitle_Panel)
        Grade_Panel.Location = New Point(0, 225)
        Grade_Panel.Name = "Grade_Panel"
        Grade_Panel.Size = New Size(1902, 830)
        Grade_Panel.TabIndex = 21
        ' 
        ' Fac_MidGrade_Panel
        ' 
        Fac_MidGrade_Panel.Controls.Add(Fac_MidGrade_DGV)
        Fac_MidGrade_Panel.Controls.Add(Fac_GMImportCSV_btn)
        Fac_MidGrade_Panel.Controls.Add(Fac_GMSaveDB_btn)
        Fac_MidGrade_Panel.Dock = DockStyle.Fill
        Fac_MidGrade_Panel.Location = New Point(0, 238)
        Fac_MidGrade_Panel.Name = "Fac_MidGrade_Panel"
        Fac_MidGrade_Panel.Size = New Size(1902, 592)
        Fac_MidGrade_Panel.TabIndex = 24
        ' 
        ' Fac_MidGrade_DGV
        ' 
        Fac_MidGrade_DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Fac_MidGrade_DGV.Columns.AddRange(New DataGridViewColumn() {MG_studID_col_lbl, MG_studName_col_lbl, MG_program_col_lbl, MG_section_col_lbl, MG_week1_col_lbl, MG_week2_col_lbl, MG_week3_col_lbl, MG_week4_col_lbl, MG_week5_col_lbl, MG_week6_col_lbl, MG_week7_col_lbl, MG_week8_col_lbl, MG_week9_col_lbl})
        Fac_MidGrade_DGV.Location = New Point(62, 6)
        Fac_MidGrade_DGV.Name = "Fac_MidGrade_DGV"
        Fac_MidGrade_DGV.RowHeadersWidth = 51
        Fac_MidGrade_DGV.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Fac_MidGrade_DGV.Size = New Size(1790, 502)
        Fac_MidGrade_DGV.TabIndex = 23
        ' 
        ' MG_studID_col_lbl
        ' 
        MG_studID_col_lbl.HeaderText = "STUDENT ID"
        MG_studID_col_lbl.MinimumWidth = 6
        MG_studID_col_lbl.Name = "MG_studID_col_lbl"
        MG_studID_col_lbl.Width = 125
        ' 
        ' MG_studName_col_lbl
        ' 
        MG_studName_col_lbl.HeaderText = "STUDENT NAME"
        MG_studName_col_lbl.MinimumWidth = 6
        MG_studName_col_lbl.Name = "MG_studName_col_lbl"
        MG_studName_col_lbl.Width = 125
        ' 
        ' MG_program_col_lbl
        ' 
        MG_program_col_lbl.HeaderText = "PROGRAM"
        MG_program_col_lbl.MinimumWidth = 6
        MG_program_col_lbl.Name = "MG_program_col_lbl"
        MG_program_col_lbl.Width = 125
        ' 
        ' MG_section_col_lbl
        ' 
        MG_section_col_lbl.HeaderText = "SECTION"
        MG_section_col_lbl.MinimumWidth = 6
        MG_section_col_lbl.Name = "MG_section_col_lbl"
        MG_section_col_lbl.Width = 125
        ' 
        ' MG_week1_col_lbl
        ' 
        MG_week1_col_lbl.HeaderText = "WEEK 1"
        MG_week1_col_lbl.MinimumWidth = 6
        MG_week1_col_lbl.Name = "MG_week1_col_lbl"
        MG_week1_col_lbl.Width = 125
        ' 
        ' MG_week2_col_lbl
        ' 
        MG_week2_col_lbl.HeaderText = "WEEK 2"
        MG_week2_col_lbl.MinimumWidth = 6
        MG_week2_col_lbl.Name = "MG_week2_col_lbl"
        MG_week2_col_lbl.Width = 125
        ' 
        ' MG_week3_col_lbl
        ' 
        MG_week3_col_lbl.HeaderText = "WEEK 3"
        MG_week3_col_lbl.MinimumWidth = 6
        MG_week3_col_lbl.Name = "MG_week3_col_lbl"
        MG_week3_col_lbl.Width = 125
        ' 
        ' MG_week4_col_lbl
        ' 
        MG_week4_col_lbl.HeaderText = "WEEK 4"
        MG_week4_col_lbl.MinimumWidth = 6
        MG_week4_col_lbl.Name = "MG_week4_col_lbl"
        MG_week4_col_lbl.Width = 125
        ' 
        ' MG_week5_col_lbl
        ' 
        MG_week5_col_lbl.HeaderText = "WEEK 5"
        MG_week5_col_lbl.MinimumWidth = 6
        MG_week5_col_lbl.Name = "MG_week5_col_lbl"
        MG_week5_col_lbl.Width = 125
        ' 
        ' MG_week6_col_lbl
        ' 
        MG_week6_col_lbl.HeaderText = "WEEK 6"
        MG_week6_col_lbl.MinimumWidth = 6
        MG_week6_col_lbl.Name = "MG_week6_col_lbl"
        MG_week6_col_lbl.Width = 125
        ' 
        ' MG_week7_col_lbl
        ' 
        MG_week7_col_lbl.HeaderText = "WEEK 7"
        MG_week7_col_lbl.MinimumWidth = 6
        MG_week7_col_lbl.Name = "MG_week7_col_lbl"
        MG_week7_col_lbl.Width = 125
        ' 
        ' MG_week8_col_lbl
        ' 
        MG_week8_col_lbl.HeaderText = "WEEK 8"
        MG_week8_col_lbl.MinimumWidth = 6
        MG_week8_col_lbl.Name = "MG_week8_col_lbl"
        MG_week8_col_lbl.Width = 125
        ' 
        ' MG_week9_col_lbl
        ' 
        MG_week9_col_lbl.HeaderText = "WEEK 9"
        MG_week9_col_lbl.MinimumWidth = 6
        MG_week9_col_lbl.Name = "MG_week9_col_lbl"
        MG_week9_col_lbl.Width = 125
        ' 
        ' Fac_GMImportCSV_btn
        ' 
        Fac_GMImportCSV_btn.Location = New Point(1693, 514)
        Fac_GMImportCSV_btn.Name = "Fac_GMImportCSV_btn"
        Fac_GMImportCSV_btn.Size = New Size(159, 54)
        Fac_GMImportCSV_btn.TabIndex = 22
        Fac_GMImportCSV_btn.Text = "Import CSV"
        Fac_GMImportCSV_btn.UseVisualStyleBackColor = True
        ' 
        ' Fac_GMSaveDB_btn
        ' 
        Fac_GMSaveDB_btn.Location = New Point(1528, 514)
        Fac_GMSaveDB_btn.Name = "Fac_GMSaveDB_btn"
        Fac_GMSaveDB_btn.Size = New Size(159, 54)
        Fac_GMSaveDB_btn.TabIndex = 21
        Fac_GMSaveDB_btn.Text = "Save to Database"
        Fac_GMSaveDB_btn.UseVisualStyleBackColor = True
        ' 
        ' Fac_MidFin_Panel
        ' 
        Fac_MidFin_Panel.Controls.Add(Fac_FinGrade_btn)
        Fac_MidFin_Panel.Controls.Add(Fac_MidGrade_btn)
        Fac_MidFin_Panel.Dock = DockStyle.Top
        Fac_MidFin_Panel.Location = New Point(0, 177)
        Fac_MidFin_Panel.Name = "Fac_MidFin_Panel"
        Fac_MidFin_Panel.Size = New Size(1902, 61)
        Fac_MidFin_Panel.TabIndex = 23
        ' 
        ' Fac_FinGrade_btn
        ' 
        Fac_FinGrade_btn.BackColor = Color.Goldenrod
        Fac_FinGrade_btn.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Fac_FinGrade_btn.ForeColor = Color.White
        Fac_FinGrade_btn.Location = New Point(962, 0)
        Fac_FinGrade_btn.Name = "Fac_FinGrade_btn"
        Fac_FinGrade_btn.Size = New Size(890, 61)
        Fac_FinGrade_btn.TabIndex = 22
        Fac_FinGrade_btn.Text = "FINAL GRADE"
        Fac_FinGrade_btn.UseVisualStyleBackColor = False
        ' 
        ' Fac_MidGrade_btn
        ' 
        Fac_MidGrade_btn.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Fac_MidGrade_btn.Location = New Point(62, 0)
        Fac_MidGrade_btn.Name = "Fac_MidGrade_btn"
        Fac_MidGrade_btn.Size = New Size(890, 61)
        Fac_MidGrade_btn.TabIndex = 21
        Fac_MidGrade_btn.Text = "MIDTERM GRADE"
        Fac_MidGrade_btn.UseVisualStyleBackColor = True
        ' 
        ' Fac_FinGrade_Panel
        ' 
        Fac_FinGrade_Panel.Controls.Add(Fac_FinGrade_DGV)
        Fac_FinGrade_Panel.Controls.Add(Fac_GFImportCSV_btn)
        Fac_FinGrade_Panel.Controls.Add(Fac_GFSaveDB_btn)
        Fac_FinGrade_Panel.Dock = DockStyle.Fill
        Fac_FinGrade_Panel.Location = New Point(0, 177)
        Fac_FinGrade_Panel.Name = "Fac_FinGrade_Panel"
        Fac_FinGrade_Panel.Size = New Size(1902, 653)
        Fac_FinGrade_Panel.TabIndex = 25
        ' 
        ' Fac_FinGrade_DGV
        ' 
        Fac_FinGrade_DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Fac_FinGrade_DGV.Columns.AddRange(New DataGridViewColumn() {FG_studID_col_lbl, FG_studName_col_lbl, FG_program_col_lbl, FG_section_col_lbl, FG_week10_col_lbl, FG_week1_col_lbl, FG_week12_col_lbl, FG_week13_col_lbl, FG_week14_col_lbl, FG_week15_col_lbl, FG_week16_col_lbl, FG_week17_col_lbl, FG_week18_col_lbl})
        Fac_FinGrade_DGV.Location = New Point(62, 6)
        Fac_FinGrade_DGV.Name = "Fac_FinGrade_DGV"
        Fac_FinGrade_DGV.RowHeadersWidth = 51
        Fac_FinGrade_DGV.Size = New Size(1790, 502)
        Fac_FinGrade_DGV.TabIndex = 23
        ' 
        ' FG_studID_col_lbl
        ' 
        FG_studID_col_lbl.HeaderText = "STUDENT ID"
        FG_studID_col_lbl.MinimumWidth = 6
        FG_studID_col_lbl.Name = "FG_studID_col_lbl"
        FG_studID_col_lbl.Width = 125
        ' 
        ' FG_studName_col_lbl
        ' 
        FG_studName_col_lbl.HeaderText = "STUDENT NAME"
        FG_studName_col_lbl.MinimumWidth = 6
        FG_studName_col_lbl.Name = "FG_studName_col_lbl"
        FG_studName_col_lbl.Width = 125
        ' 
        ' FG_program_col_lbl
        ' 
        FG_program_col_lbl.HeaderText = "PROGRAM"
        FG_program_col_lbl.MinimumWidth = 6
        FG_program_col_lbl.Name = "FG_program_col_lbl"
        FG_program_col_lbl.Width = 125
        ' 
        ' FG_section_col_lbl
        ' 
        FG_section_col_lbl.HeaderText = "SECTION"
        FG_section_col_lbl.MinimumWidth = 6
        FG_section_col_lbl.Name = "FG_section_col_lbl"
        FG_section_col_lbl.Width = 125
        ' 
        ' FG_week10_col_lbl
        ' 
        FG_week10_col_lbl.HeaderText = "WEEK 10"
        FG_week10_col_lbl.MinimumWidth = 6
        FG_week10_col_lbl.Name = "FG_week10_col_lbl"
        FG_week10_col_lbl.Width = 125
        ' 
        ' FG_week1_col_lbl
        ' 
        FG_week1_col_lbl.HeaderText = "WEEK 11"
        FG_week1_col_lbl.MinimumWidth = 6
        FG_week1_col_lbl.Name = "FG_week1_col_lbl"
        FG_week1_col_lbl.Width = 125
        ' 
        ' FG_week12_col_lbl
        ' 
        FG_week12_col_lbl.HeaderText = "WEEK 12"
        FG_week12_col_lbl.MinimumWidth = 6
        FG_week12_col_lbl.Name = "FG_week12_col_lbl"
        FG_week12_col_lbl.Width = 125
        ' 
        ' FG_week13_col_lbl
        ' 
        FG_week13_col_lbl.HeaderText = "WEEK 13"
        FG_week13_col_lbl.MinimumWidth = 6
        FG_week13_col_lbl.Name = "FG_week13_col_lbl"
        FG_week13_col_lbl.Width = 125
        ' 
        ' FG_week14_col_lbl
        ' 
        FG_week14_col_lbl.HeaderText = "WEEK 14"
        FG_week14_col_lbl.MinimumWidth = 6
        FG_week14_col_lbl.Name = "FG_week14_col_lbl"
        FG_week14_col_lbl.Width = 125
        ' 
        ' FG_week15_col_lbl
        ' 
        FG_week15_col_lbl.HeaderText = "WEEK 15"
        FG_week15_col_lbl.MinimumWidth = 6
        FG_week15_col_lbl.Name = "FG_week15_col_lbl"
        FG_week15_col_lbl.Width = 125
        ' 
        ' FG_week16_col_lbl
        ' 
        FG_week16_col_lbl.HeaderText = "WEEK 16"
        FG_week16_col_lbl.MinimumWidth = 6
        FG_week16_col_lbl.Name = "FG_week16_col_lbl"
        FG_week16_col_lbl.Width = 125
        ' 
        ' FG_week17_col_lbl
        ' 
        FG_week17_col_lbl.HeaderText = "WEEK 17"
        FG_week17_col_lbl.MinimumWidth = 6
        FG_week17_col_lbl.Name = "FG_week17_col_lbl"
        FG_week17_col_lbl.Width = 125
        ' 
        ' FG_week18_col_lbl
        ' 
        FG_week18_col_lbl.HeaderText = "WEEK 18"
        FG_week18_col_lbl.MinimumWidth = 6
        FG_week18_col_lbl.Name = "FG_week18_col_lbl"
        FG_week18_col_lbl.Width = 125
        ' 
        ' Fac_GFImportCSV_btn
        ' 
        Fac_GFImportCSV_btn.Location = New Point(1693, 514)
        Fac_GFImportCSV_btn.Name = "Fac_GFImportCSV_btn"
        Fac_GFImportCSV_btn.Size = New Size(159, 54)
        Fac_GFImportCSV_btn.TabIndex = 22
        Fac_GFImportCSV_btn.Text = "Import CSV"
        Fac_GFImportCSV_btn.UseVisualStyleBackColor = True
        ' 
        ' Fac_GFSaveDB_btn
        ' 
        Fac_GFSaveDB_btn.Location = New Point(1528, 514)
        Fac_GFSaveDB_btn.Name = "Fac_GFSaveDB_btn"
        Fac_GFSaveDB_btn.Size = New Size(159, 54)
        Fac_GFSaveDB_btn.TabIndex = 21
        Fac_GFSaveDB_btn.Text = "Save to Database"
        Fac_GFSaveDB_btn.UseVisualStyleBackColor = True
        ' 
        ' GradeTitle_Panel
        ' 
        GradeTitle_Panel.Controls.Add(Fac_GSection_lbl)
        GradeTitle_Panel.Controls.Add(Fac_GSection_cmb)
        GradeTitle_Panel.Controls.Add(Fac_GSecFilter_btn)
        GradeTitle_Panel.Controls.Add(Fac_GSecSearch_btn)
        GradeTitle_Panel.Controls.Add(Fac_GSecSearch_txt)
        GradeTitle_Panel.Controls.Add(Fac_GradeTitle_lbl)
        GradeTitle_Panel.Controls.Add(Fac_GProgram_lbl)
        GradeTitle_Panel.Controls.Add(Design3)
        GradeTitle_Panel.Controls.Add(Fac_GProgram_cmb)
        GradeTitle_Panel.Dock = DockStyle.Top
        GradeTitle_Panel.Location = New Point(0, 0)
        GradeTitle_Panel.Name = "GradeTitle_Panel"
        GradeTitle_Panel.Size = New Size(1902, 177)
        GradeTitle_Panel.TabIndex = 13
        ' 
        ' Fac_GSection_lbl
        ' 
        Fac_GSection_lbl.AutoSize = True
        Fac_GSection_lbl.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Fac_GSection_lbl.Location = New Point(1567, 101)
        Fac_GSection_lbl.Name = "Fac_GSection_lbl"
        Fac_GSection_lbl.Size = New Size(94, 28)
        Fac_GSection_lbl.TabIndex = 20
        Fac_GSection_lbl.Text = "SECTION:"
        ' 
        ' Fac_GSection_cmb
        ' 
        Fac_GSection_cmb.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Fac_GSection_cmb.FormattingEnabled = True
        Fac_GSection_cmb.Items.AddRange(New Object() {"- None -"})
        Fac_GSection_cmb.Location = New Point(1567, 132)
        Fac_GSection_cmb.Name = "Fac_GSection_cmb"
        Fac_GSection_cmb.Size = New Size(179, 39)
        Fac_GSection_cmb.TabIndex = 19
        ' 
        ' Fac_GSecFilter_btn
        ' 
        Fac_GSecFilter_btn.Location = New Point(1752, 133)
        Fac_GSecFilter_btn.Name = "Fac_GSecFilter_btn"
        Fac_GSecFilter_btn.Size = New Size(100, 38)
        Fac_GSecFilter_btn.TabIndex = 19
        Fac_GSecFilter_btn.Text = "Filter"
        Fac_GSecFilter_btn.UseVisualStyleBackColor = True
        ' 
        ' Fac_GSecSearch_btn
        ' 
        Fac_GSecSearch_btn.Location = New Point(1752, 48)
        Fac_GSecSearch_btn.Name = "Fac_GSecSearch_btn"
        Fac_GSecSearch_btn.Size = New Size(100, 38)
        Fac_GSecSearch_btn.TabIndex = 18
        Fac_GSecSearch_btn.Text = "Search"
        Fac_GSecSearch_btn.UseVisualStyleBackColor = True
        ' 
        ' Fac_GSecSearch_txt
        ' 
        Fac_GSecSearch_txt.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Fac_GSecSearch_txt.Location = New Point(1382, 48)
        Fac_GSecSearch_txt.Name = "Fac_GSecSearch_txt"
        Fac_GSecSearch_txt.Size = New Size(364, 38)
        Fac_GSecSearch_txt.TabIndex = 17
        ' 
        ' Fac_GradeTitle_lbl
        ' 
        Fac_GradeTitle_lbl.AutoSize = True
        Fac_GradeTitle_lbl.Font = New Font("Times New Roman", 55.8000031F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Fac_GradeTitle_lbl.Location = New Point(132, 48)
        Fac_GradeTitle_lbl.Name = "Fac_GradeTitle_lbl"
        Fac_GradeTitle_lbl.Size = New Size(437, 105)
        Fac_GradeTitle_lbl.TabIndex = 8
        Fac_GradeTitle_lbl.Text = "GRADES"
        Fac_GradeTitle_lbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Fac_GProgram_lbl
        ' 
        Fac_GProgram_lbl.AutoSize = True
        Fac_GProgram_lbl.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Fac_GProgram_lbl.Location = New Point(1382, 101)
        Fac_GProgram_lbl.Name = "Fac_GProgram_lbl"
        Fac_GProgram_lbl.Size = New Size(111, 28)
        Fac_GProgram_lbl.TabIndex = 16
        Fac_GProgram_lbl.Text = "PROGRAM:"
        ' 
        ' Design3
        ' 
        Design3.BackColor = Color.Navy
        Design3.Location = New Point(68, 48)
        Design3.Name = "Design3"
        Design3.Size = New Size(38, 105)
        Design3.TabIndex = 10
        ' 
        ' Fac_GProgram_cmb
        ' 
        Fac_GProgram_cmb.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Fac_GProgram_cmb.FormattingEnabled = True
        Fac_GProgram_cmb.Items.AddRange(New Object() {"- None -"})
        Fac_GProgram_cmb.Location = New Point(1382, 132)
        Fac_GProgram_cmb.Name = "Fac_GProgram_cmb"
        Fac_GProgram_cmb.Size = New Size(179, 39)
        Fac_GProgram_cmb.TabIndex = 15
        ' 
        ' Section_Panel
        ' 
        Section_Panel.Controls.Add(Fac_SaveDB_btn)
        Section_Panel.Controls.Add(Fac_ImportCSV_btn)
        Section_Panel.Controls.Add(SectionTitle_Panel)
        Section_Panel.Controls.Add(Fac_SecInfo_DGV)
        Section_Panel.Dock = DockStyle.Fill
        Section_Panel.Location = New Point(0, 225)
        Section_Panel.Name = "Section_Panel"
        Section_Panel.Size = New Size(1902, 830)
        Section_Panel.TabIndex = 0
        ' 
        ' Fac_SaveDB_btn
        ' 
        Fac_SaveDB_btn.Location = New Point(1528, 752)
        Fac_SaveDB_btn.Name = "Fac_SaveDB_btn"
        Fac_SaveDB_btn.Size = New Size(159, 54)
        Fac_SaveDB_btn.TabIndex = 24
        Fac_SaveDB_btn.Text = "Save to Database"
        Fac_SaveDB_btn.UseVisualStyleBackColor = True
        ' 
        ' Fac_ImportCSV_btn
        ' 
        Fac_ImportCSV_btn.Location = New Point(1693, 752)
        Fac_ImportCSV_btn.Name = "Fac_ImportCSV_btn"
        Fac_ImportCSV_btn.Size = New Size(159, 54)
        Fac_ImportCSV_btn.TabIndex = 23
        Fac_ImportCSV_btn.Text = "Import CSV"
        Fac_ImportCSV_btn.UseVisualStyleBackColor = True
        ' 
        ' SectionTitle_Panel
        ' 
        SectionTitle_Panel.Controls.Add(Fac_Section_lbl)
        SectionTitle_Panel.Controls.Add(Fac_Section_cmb)
        SectionTitle_Panel.Controls.Add(Fac_SecFilter_btn)
        SectionTitle_Panel.Controls.Add(Fac_SecSearch_btn)
        SectionTitle_Panel.Controls.Add(Fac_SecSearch_txt)
        SectionTitle_Panel.Controls.Add(Fac_SecTitle_lbl)
        SectionTitle_Panel.Controls.Add(Fac_Program_lbl)
        SectionTitle_Panel.Controls.Add(Design2)
        SectionTitle_Panel.Controls.Add(Fac_Program_cmb)
        SectionTitle_Panel.Dock = DockStyle.Top
        SectionTitle_Panel.Location = New Point(0, 0)
        SectionTitle_Panel.Name = "SectionTitle_Panel"
        SectionTitle_Panel.Size = New Size(1902, 177)
        SectionTitle_Panel.TabIndex = 12
        ' 
        ' Fac_Section_lbl
        ' 
        Fac_Section_lbl.AutoSize = True
        Fac_Section_lbl.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Fac_Section_lbl.Location = New Point(1567, 101)
        Fac_Section_lbl.Name = "Fac_Section_lbl"
        Fac_Section_lbl.Size = New Size(94, 28)
        Fac_Section_lbl.TabIndex = 20
        Fac_Section_lbl.Text = "SECTION:"
        ' 
        ' Fac_Section_cmb
        ' 
        Fac_Section_cmb.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Fac_Section_cmb.FormattingEnabled = True
        Fac_Section_cmb.Items.AddRange(New Object() {"- None -"})
        Fac_Section_cmb.Location = New Point(1567, 132)
        Fac_Section_cmb.Name = "Fac_Section_cmb"
        Fac_Section_cmb.Size = New Size(179, 39)
        Fac_Section_cmb.TabIndex = 19
        ' 
        ' Fac_SecFilter_btn
        ' 
        Fac_SecFilter_btn.Location = New Point(1752, 133)
        Fac_SecFilter_btn.Name = "Fac_SecFilter_btn"
        Fac_SecFilter_btn.Size = New Size(100, 38)
        Fac_SecFilter_btn.TabIndex = 19
        Fac_SecFilter_btn.Text = "Filter"
        Fac_SecFilter_btn.UseVisualStyleBackColor = True
        ' 
        ' Fac_SecSearch_btn
        ' 
        Fac_SecSearch_btn.Location = New Point(1752, 48)
        Fac_SecSearch_btn.Name = "Fac_SecSearch_btn"
        Fac_SecSearch_btn.Size = New Size(100, 38)
        Fac_SecSearch_btn.TabIndex = 18
        Fac_SecSearch_btn.Text = "Search"
        Fac_SecSearch_btn.UseVisualStyleBackColor = True
        ' 
        ' Fac_SecSearch_txt
        ' 
        Fac_SecSearch_txt.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Fac_SecSearch_txt.Location = New Point(1382, 48)
        Fac_SecSearch_txt.Name = "Fac_SecSearch_txt"
        Fac_SecSearch_txt.Size = New Size(364, 38)
        Fac_SecSearch_txt.TabIndex = 17
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
        ' Fac_Program_lbl
        ' 
        Fac_Program_lbl.AutoSize = True
        Fac_Program_lbl.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Fac_Program_lbl.Location = New Point(1382, 101)
        Fac_Program_lbl.Name = "Fac_Program_lbl"
        Fac_Program_lbl.Size = New Size(111, 28)
        Fac_Program_lbl.TabIndex = 16
        Fac_Program_lbl.Text = "PROGRAM:"
        ' 
        ' Design2
        ' 
        Design2.BackColor = Color.Navy
        Design2.Location = New Point(68, 48)
        Design2.Name = "Design2"
        Design2.Size = New Size(38, 105)
        Design2.TabIndex = 10
        ' 
        ' Fac_Program_cmb
        ' 
        Fac_Program_cmb.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Fac_Program_cmb.FormattingEnabled = True
        Fac_Program_cmb.Items.AddRange(New Object() {"- None -"})
        Fac_Program_cmb.Location = New Point(1382, 132)
        Fac_Program_cmb.Name = "Fac_Program_cmb"
        Fac_Program_cmb.Size = New Size(179, 39)
        Fac_Program_cmb.TabIndex = 15
        ' 
        ' Fac_SecInfo_DGV
        ' 
        Fac_SecInfo_DGV.AllowUserToOrderColumns = True
        Fac_SecInfo_DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Fac_SecInfo_DGV.Columns.AddRange(New DataGridViewColumn() {studID_col_lbl, studLName_col_lbl, studFName_col_lbl, studMName_col_lbl, studSName_col_lbl, depID_col_lbl, progID_col_lbl, studSec_col_lbl, studStat_col_lbl})
        Fac_SecInfo_DGV.Location = New Point(68, 210)
        Fac_SecInfo_DGV.Name = "Fac_SecInfo_DGV"
        Fac_SecInfo_DGV.RowHeadersWidth = 51
        Fac_SecInfo_DGV.Size = New Size(1784, 536)
        Fac_SecInfo_DGV.TabIndex = 4
        ' 
        ' studID_col_lbl
        ' 
        studID_col_lbl.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        studID_col_lbl.HeaderText = "STUDENT ID"
        studID_col_lbl.MinimumWidth = 6
        studID_col_lbl.Name = "studID_col_lbl"
        studID_col_lbl.Width = 111
        ' 
        ' studLName_col_lbl
        ' 
        studLName_col_lbl.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        studLName_col_lbl.HeaderText = "LAST NAME"
        studLName_col_lbl.MinimumWidth = 6
        studLName_col_lbl.Name = "studLName_col_lbl"
        ' 
        ' studFName_col_lbl
        ' 
        studFName_col_lbl.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        studFName_col_lbl.HeaderText = "FIRST NAME"
        studFName_col_lbl.MinimumWidth = 6
        studFName_col_lbl.Name = "studFName_col_lbl"
        ' 
        ' studMName_col_lbl
        ' 
        studMName_col_lbl.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        studMName_col_lbl.HeaderText = "MIDDLE NAME"
        studMName_col_lbl.MinimumWidth = 6
        studMName_col_lbl.Name = "studMName_col_lbl"
        ' 
        ' studSName_col_lbl
        ' 
        studSName_col_lbl.HeaderText = "SUFFIX"
        studSName_col_lbl.MinimumWidth = 6
        studSName_col_lbl.Name = "studSName_col_lbl"
        studSName_col_lbl.Width = 125
        ' 
        ' depID_col_lbl
        ' 
        depID_col_lbl.HeaderText = "DEPARTMENT ID"
        depID_col_lbl.MinimumWidth = 6
        depID_col_lbl.Name = "depID_col_lbl"
        depID_col_lbl.Width = 125
        ' 
        ' progID_col_lbl
        ' 
        progID_col_lbl.HeaderText = "PROGRAM"
        progID_col_lbl.MinimumWidth = 6
        progID_col_lbl.Name = "progID_col_lbl"
        progID_col_lbl.Width = 125
        ' 
        ' studSec_col_lbl
        ' 
        studSec_col_lbl.HeaderText = "SECTION"
        studSec_col_lbl.MinimumWidth = 6
        studSec_col_lbl.Name = "studSec_col_lbl"
        studSec_col_lbl.Width = 125
        ' 
        ' studStat_col_lbl
        ' 
        studStat_col_lbl.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        studStat_col_lbl.HeaderText = "STATUS"
        studStat_col_lbl.MinimumWidth = 6
        studStat_col_lbl.Name = "studStat_col_lbl"
        studStat_col_lbl.Width = 88
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
        RightTop_Panel.Controls.Add(Grade_Linklbl)
        RightTop_Panel.Controls.Add(Home_Linklbl)
        RightTop_Panel.Controls.Add(Profile_Linklbl)
        RightTop_Panel.Controls.Add(Logout_BTN)
        RightTop_Panel.Controls.Add(Section_Linklbl)
        RightTop_Panel.Dock = DockStyle.Right
        RightTop_Panel.Location = New Point(962, 0)
        RightTop_Panel.Name = "RightTop_Panel"
        RightTop_Panel.Size = New Size(940, 225)
        RightTop_Panel.TabIndex = 11
        ' 
        ' Grade_Linklbl
        ' 
        Grade_Linklbl.ActiveLinkColor = Color.Goldenrod
        Grade_Linklbl.BackColor = Color.Navy
        Grade_Linklbl.Font = New Font("Arial Rounded MT Bold", 16.2F)
        Grade_Linklbl.LinkColor = Color.White
        Grade_Linklbl.Location = New Point(589, 0)
        Grade_Linklbl.Name = "Grade_Linklbl"
        Grade_Linklbl.Size = New Size(152, 149)
        Grade_Linklbl.TabIndex = 12
        Grade_Linklbl.TabStop = True
        Grade_Linklbl.Text = "GRADE"
        Grade_Linklbl.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Home_Linklbl
        ' 
        Home_Linklbl.ActiveLinkColor = Color.Goldenrod
        Home_Linklbl.BackColor = Color.Navy
        Home_Linklbl.Font = New Font("Arial Rounded MT Bold", 16.2F)
        Home_Linklbl.LinkColor = Color.White
        Home_Linklbl.Location = New Point(162, 0)
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
        Profile_Linklbl.Location = New Point(289, 0)
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
        Logout_BTN.Location = New Point(727, 0)
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
        Section_Linklbl.Location = New Point(447, 0)
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
        CType(Fac_PendEval_DGV, ComponentModel.ISupportInitialize).EndInit()
        Fac_Info_Panel.ResumeLayout(False)
        Fac_Info_Panel.PerformLayout()
        Grade_Panel.ResumeLayout(False)
        Fac_MidGrade_Panel.ResumeLayout(False)
        CType(Fac_MidGrade_DGV, ComponentModel.ISupportInitialize).EndInit()
        Fac_MidFin_Panel.ResumeLayout(False)
        Fac_FinGrade_Panel.ResumeLayout(False)
        CType(Fac_FinGrade_DGV, ComponentModel.ISupportInitialize).EndInit()
        GradeTitle_Panel.ResumeLayout(False)
        GradeTitle_Panel.PerformLayout()
        Section_Panel.ResumeLayout(False)
        SectionTitle_Panel.ResumeLayout(False)
        SectionTitle_Panel.PerformLayout()
        CType(Fac_SecInfo_DGV, ComponentModel.ISupportInitialize).EndInit()
        Profile_Panel.ResumeLayout(False)
        FacProfile_Panel.ResumeLayout(False)
        FacProfile_Panel.PerformLayout()
        ProfTitle_Panel.ResumeLayout(False)
        ProfTitle_Panel.PerformLayout()
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
    Friend WithEvents SecTitle_Panel As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Fac_SaveDB_btn As Button
    Friend WithEvents Fac_SecSearch_btn As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Profile_Panel As Panel
    Friend WithEvents Fac_SecTitle_lbl As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Fac_DateTimeNow As Label
    Friend WithEvents ProfTitle_Panel As Panel
    Friend WithEvents Fac_Profiletitle As Label
    Friend WithEvents Design As Panel
    Friend WithEvents Fac_Program_lbl As Label
    Friend WithEvents Fac_Program_cmb As ComboBox
    Friend WithEvents Fac_SecSearch_txt As TextBox
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
    Friend WithEvents Fac_PendEval_DGV As DataGridView
    Friend WithEvents Status_Position_lbl As Label
    Friend WithEvents Faculty_FName_lbl As Label
    Friend WithEvents Faculty_FacEmpStat_txt As TextBox
    Friend WithEvents Faculty_FacEmpStat_lbl As Label
    Friend WithEvents Fac_SecFilter_btn As Button
    Friend WithEvents Fac_Section_lbl As Label
    Friend WithEvents Fac_Section_cmb As ComboBox
    Friend WithEvents FacDGV_InternID As DataGridViewTextBoxColumn
    Friend WithEvents FacDGV_StudName As DataGridViewTextBoxColumn
    Friend WithEvents FacDGV_Program As DataGridViewTextBoxColumn
    Friend WithEvents FacDGV_Section As DataGridViewTextBoxColumn
    Friend WithEvents FacDGV_CompName As DataGridViewTextBoxColumn
    Friend WithEvents FacDGV_SVisor As DataGridViewTextBoxColumn
    Friend WithEvents FacDGV_FEval As DataGridViewTextBoxColumn
    Friend WithEvents FacDGV_Stat As DataGridViewTextBoxColumn
    Friend WithEvents Grade_Linklbl As LinkLabel
    Friend WithEvents Grade_Panel As Panel
    Friend WithEvents GradeTitle_Panel As Panel
    Friend WithEvents Fac_GSection_lbl As Label
    Friend WithEvents Fac_GSection_cmb As ComboBox
    Friend WithEvents Fac_GSecFilter_btn As Button
    Friend WithEvents Fac_GSecSearch_btn As Button
    Friend WithEvents Fac_GSecSearch_txt As TextBox
    Friend WithEvents Fac_GradeTitle_lbl As Label
    Friend WithEvents Fac_GProgram_lbl As Label
    Friend WithEvents Design3 As Panel
    Friend WithEvents Fac_GProgram_cmb As ComboBox
    Friend WithEvents Fac_MidFin_Panel As Panel
    Friend WithEvents Fac_SecInfo_DGV As DataGridView
    Friend WithEvents studID_col_lbl As DataGridViewTextBoxColumn
    Friend WithEvents studLName_col_lbl As DataGridViewTextBoxColumn
    Friend WithEvents studFName_col_lbl As DataGridViewTextBoxColumn
    Friend WithEvents studMName_col_lbl As DataGridViewTextBoxColumn
    Friend WithEvents studSName_col_lbl As DataGridViewTextBoxColumn
    Friend WithEvents depID_col_lbl As DataGridViewTextBoxColumn
    Friend WithEvents progID_col_lbl As DataGridViewTextBoxColumn
    Friend WithEvents studSec_col_lbl As DataGridViewTextBoxColumn
    Friend WithEvents studStat_col_lbl As DataGridViewTextBoxColumn
    Friend WithEvents Fac_ImportCSV_btn As Button
    Friend WithEvents Fac_GMImportCSV_btn As Button
    Friend WithEvents Fac_GMSaveDB_btn As Button
    Friend WithEvents Fac_FinGrade_Panel As Panel
    Friend WithEvents Fac_MidGrade_Panel As Panel
    Friend WithEvents Fac_MidGrade_DGV As DataGridView
    Friend WithEvents Fac_FinGrade_DGV As DataGridView
    Friend WithEvents Fac_GFImportCSV_btn As Button
    Friend WithEvents Fac_GFSaveDB_btn As Button
    Friend WithEvents Fac_FinGrade_btn As Button
    Friend WithEvents Fac_MidGrade_btn As Button
    Friend WithEvents FG_studID_col_lbl As DataGridViewTextBoxColumn
    Friend WithEvents FG_studName_col_lbl As DataGridViewTextBoxColumn
    Friend WithEvents FG_program_col_lbl As DataGridViewTextBoxColumn
    Friend WithEvents FG_section_col_lbl As DataGridViewTextBoxColumn
    Friend WithEvents FG_week10_col_lbl As DataGridViewTextBoxColumn
    Friend WithEvents FG_week1_col_lbl As DataGridViewTextBoxColumn
    Friend WithEvents FG_week12_col_lbl As DataGridViewTextBoxColumn
    Friend WithEvents FG_week13_col_lbl As DataGridViewTextBoxColumn
    Friend WithEvents FG_week14_col_lbl As DataGridViewTextBoxColumn
    Friend WithEvents FG_week15_col_lbl As DataGridViewTextBoxColumn
    Friend WithEvents FG_week16_col_lbl As DataGridViewTextBoxColumn
    Friend WithEvents FG_week17_col_lbl As DataGridViewTextBoxColumn
    Friend WithEvents FG_week18_col_lbl As DataGridViewTextBoxColumn
    Friend WithEvents MG_studID_col_lbl As DataGridViewTextBoxColumn
    Friend WithEvents MG_studName_col_lbl As DataGridViewTextBoxColumn
    Friend WithEvents MG_program_col_lbl As DataGridViewTextBoxColumn
    Friend WithEvents MG_section_col_lbl As DataGridViewTextBoxColumn
    Friend WithEvents MG_week1_col_lbl As DataGridViewTextBoxColumn
    Friend WithEvents MG_week2_col_lbl As DataGridViewTextBoxColumn
    Friend WithEvents MG_week3_col_lbl As DataGridViewTextBoxColumn
    Friend WithEvents MG_week4_col_lbl As DataGridViewTextBoxColumn
    Friend WithEvents MG_week5_col_lbl As DataGridViewTextBoxColumn
    Friend WithEvents MG_week6_col_lbl As DataGridViewTextBoxColumn
    Friend WithEvents MG_week7_col_lbl As DataGridViewTextBoxColumn
    Friend WithEvents MG_week8_col_lbl As DataGridViewTextBoxColumn
    Friend WithEvents MG_week9_col_lbl As DataGridViewTextBoxColumn
End Class
