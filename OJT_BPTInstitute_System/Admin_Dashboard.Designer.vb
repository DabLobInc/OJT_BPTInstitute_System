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
        components = New ComponentModel.Container()
        Screen_Panel = New Panel()
        Home_Panel = New Panel()
        Content_Panel = New Panel()
        Dashboard_Panel = New Panel()
        Container_Panel = New Panel()
        Stud_Eval_Panel = New Panel()
        SE_DGV = New DataGridView()
        SE_DGV_IntID = New DataGridViewTextBoxColumn()
        SE_DGV_StudName = New DataGridViewTextBoxColumn()
        SE_DGV_Course = New DataGridViewTextBoxColumn()
        SE_DGV_Section = New DataGridViewTextBoxColumn()
        SE_DGV_CompName = New DataGridViewTextBoxColumn()
        SE_DGV_SVisor = New DataGridViewTextBoxColumn()
        SE_DGV_FacEval = New DataGridViewTextBoxColumn()
        SE_DGV_Stat = New DataGridViewTextBoxColumn()
        PE_Panel = New Panel()
        PE_Lbl = New Label()
        WelcomeLbl = New Label()
        Adm_User_lbl = New Label()
        SRegis_DateTime = New Label()
        Visit_LogPanel = New Panel()
        VL_DGV = New DataGridView()
        VL_DGV_VisitID = New DataGridViewTextBoxColumn()
        VL_DGV_StudName = New DataGridViewTextBoxColumn()
        VL_DGV_CompName = New DataGridViewTextBoxColumn()
        VL_DGV_FacEval = New DataGridViewTextBoxColumn()
        VL_DGV_VisitDT = New DataGridViewTextBoxColumn()
        VL_DGV_Rating = New DataGridViewTextBoxColumn()
        VL_DGV_Remarks = New DataGridViewTextBoxColumn()
        VL_SidePnl = New Panel()
        VL_Lbl = New Label()
        Fac_Eval_Panel = New Panel()
        FE_DeptLbl = New Label()
        FE_DeptCMB = New ComboBox()
        FE_DGV = New DataGridView()
        FE_DGV_FacID = New DataGridViewTextBoxColumn()
        FE_DGV_LastName = New DataGridViewTextBoxColumn()
        FE_DGV_FirstName = New DataGridViewTextBoxColumn()
        FE_DGV_MidName = New DataGridViewTextBoxColumn()
        FE_DGV_Suffix = New DataGridViewTextBoxColumn()
        FE_DGV_Employment = New DataGridViewTextBoxColumn()
        FE_SidePnl = New Panel()
        FE_Lbl = New Label()
        FEval_DateTime = New Label()
        Stud_Regis_Panel = New Panel()
        SR_DeptLbl = New Label()
        SR_DeptCMB = New ComboBox()
        SR_DGV = New DataGridView()
        SR_DGV_StudID = New DataGridViewTextBoxColumn()
        SR_DGV_LastName = New DataGridViewTextBoxColumn()
        SR_DGV_FirstName = New DataGridViewTextBoxColumn()
        SR_DGV_MiddleName = New DataGridViewTextBoxColumn()
        SR_DGV_Suffix = New DataGridViewTextBoxColumn()
        SR_DGV_Course = New DataGridViewTextBoxColumn()
        SR_DGV_Section = New DataGridViewTextBoxColumn()
        SR_SidePnl = New Panel()
        SR_Lbl = New Label()
        SEval_DateTime = New Label()
        Partner_Comp_Panel = New Panel()
        PC_DGV = New DataGridView()
        PC_DGV_CompID = New DataGridViewTextBoxColumn()
        PC_DGV_CompName = New DataGridViewTextBoxColumn()
        PC_DGV_CompAd = New DataGridViewTextBoxColumn()
        PC_DGV_CompEmail = New DataGridViewTextBoxColumn()
        PC_DGV_CompCon = New DataGridViewTextBoxColumn()
        PC_DGV_SVisor = New DataGridViewTextBoxColumn()
        PC_SidePan = New Panel()
        PC_Lbl = New Label()
        PComp_DateTime = New Label()
        DashSideFunc = New Panel()
        DashSide_OUTER = New Panel()
        DashSide_INNER = New Panel()
        VL_BackPan = New Panel()
        VL_LinkLbl = New LinkLabel()
        FE_BackPan = New Panel()
        FE_LinkLbl = New LinkLabel()
        PC_BackPan = New Panel()
        PC_LinkLbl = New LinkLabel()
        SR_BackPan = New Panel()
        SR_LinkLbl = New LinkLabel()
        SE_BackPan = New Panel()
        SE_LinkLbl = New LinkLabel()
        Function_Panel = New Panel()
        Func_Container = New Panel()
        ADM_STUDPAN = New Panel()
        Stud_SecCmb = New ComboBox()
        Stud_SemCmb = New ComboBox()
        Stud_CourseCmb = New ComboBox()
        STUD_ClrBtn = New Button()
        STUD_AddBtn = New Button()
        Stud_EmailTB = New TextBox()
        Stud_SuffixTB = New TextBox()
        Stud_MidTB = New TextBox()
        Stud_FirstTB = New TextBox()
        Stud_LastTB = New TextBox()
        Stud_ConLbl = New Label()
        Stud_ConMTB = New MaskedTextBox()
        Stud_EmLbl = New Label()
        Stud_SemLbl = New Label()
        Stud_CourseLbl = New Label()
        Stud_SufLbl = New Label()
        Stud_MidLbl = New Label()
        Stud_FirstLbl = New Label()
        Stud_LastLbl = New Label()
        Stud_SecLbl = New Label()
        Stud_StudIDPnl = New Label()
        MaskedTextBox1 = New MaskedTextBox()
        STUD_DelBtn = New Button()
        STUD_EdBtn = New Button()
        StudBot_Pnl = New Panel()
        StudTop_Pnl = New Panel()
        FuncStud_NewEnt = New Label()
        FuncStudSPan = New Panel()
        STUD_DGV = New DataGridView()
        Stud_DGV_SID = New DataGridViewTextBoxColumn()
        Stud_DGV_LastN = New DataGridViewTextBoxColumn()
        Stud_DGV_FirstN = New DataGridViewTextBoxColumn()
        Stud_DGV_MidN = New DataGridViewTextBoxColumn()
        Stud_DGV_Suf = New DataGridViewTextBoxColumn()
        Stud_DGV_Course = New DataGridViewTextBoxColumn()
        Stud_DGV_Sem = New DataGridViewTextBoxColumn()
        Stud_DGV_Sec = New DataGridViewTextBoxColumn()
        Stud_DGV_Email = New DataGridViewTextBoxColumn()
        Stud_DGV_Con = New DataGridViewTextBoxColumn()
        STUD_Lbl = New Label()
        Adm_Func_StudDateTime_lbl = New Label()
        ADM_FACPAN = New Panel()
        Fac_PosTB = New TextBox()
        FAC_ClrBtn = New Button()
        FAC_AddBtn = New Button()
        Fac_EmpCmb = New ComboBox()
        Fac_EmpLbl = New Label()
        Fac_ConLbl = New Label()
        Fac_ConMTB = New MaskedTextBox()
        Fac_DeptCmb = New ComboBox()
        Fac_PosLbl = New Label()
        Fac_SufTB = New TextBox()
        Fac_MidTB = New TextBox()
        Fac_SufLbl = New Label()
        Fac_MidLbl = New Label()
        Fac_EmailTB = New TextBox()
        Fac_FirstNTB = New TextBox()
        Fac_LastNTB = New TextBox()
        Fac_EmailLbl = New Label()
        Fac_DeptLbl = New Label()
        Fac_FirstNLbl = New Label()
        Fac_LastNLbl = New Label()
        Fac_FIDLbl = New Label()
        Fac_FID_MTB = New MaskedTextBox()
        FAC_DelBtn = New Button()
        FAC_EdBtn = New Button()
        Fac_BotPnl = New Panel()
        Fac_TopPnl = New Panel()
        Fac_NewEntLbl = New Label()
        FAC_DGV = New DataGridView()
        Fac_DGV_FID = New DataGridViewTextBoxColumn()
        Fac_DGV_LastN = New DataGridViewTextBoxColumn()
        Fac_DGV_FirstN = New DataGridViewTextBoxColumn()
        Fac_DGV_MidN = New DataGridViewTextBoxColumn()
        Fac_DGV_Suf = New DataGridViewTextBoxColumn()
        Fac_DGV_Dept = New DataGridViewTextBoxColumn()
        Fac_DGV_Pos = New DataGridViewTextBoxColumn()
        Fac_DGV_Emp = New DataGridViewTextBoxColumn()
        Fac_DGV_Email = New DataGridViewTextBoxColumn()
        Fac_DGV_Con = New DataGridViewTextBoxColumn()
        Fac_SidePnl = New Panel()
        FAC_Lbl = New Label()
        Adm_func_FacDateTime_lbl = New Label()
        ADM_INTERPAN = New Panel()
        Adm_Intern_Stud_ID = New Label()
        Adm_Intern_SY_Mtx = New MaskedTextBox()
        Adm_Intern_Intern_lbl = New Label()
        Adm_Intern_Del_btn = New Button()
        Adm_Intern_Edit_btn = New Button()
        Adm_Intern_AddEval_txt = New TextBox()
        Adm_Intern_Eval_lbl = New Label()
        Adm_Intern_AddSup_txt = New TextBox()
        Adm_Intern_Sup_lbl = New Label()
        Adm_Intern_AddStat_cmb = New ComboBox()
        Adm_Intern_Stat_lbl = New Label()
        Adm_Intern_AddGrade_txt = New TextBox()
        Adm_Intern_Grade_lbl = New Label()
        Adm_Intern_End_dtp = New DateTimePicker()
        Adm_Intern_End_lbl = New Label()
        Adm_Intern_Start_dtp = New DateTimePicker()
        Adm_Intern_AddFac_cmb = New ComboBox()
        Adm_Intern_FacID_lbl = New Label()
        Adm_Intern_SupID_cmb = New ComboBox()
        Adm_Intern_SupID_lbl = New Label()
        Adm_Intern_AddCompName_txt = New TextBox()
        Adm_Intern_CompName_lbl = New Label()
        Adm_Intern_AddCompID_cmb = New ComboBox()
        Adm_Intern_CompID_lbl = New Label()
        Adm_Intern_AddStudID_Mtxt = New MaskedTextBox()
        Adm_Intern_AddStudName_txt = New TextBox()
        Adm_Intern_StudName_lbl = New Label()
        Adm_Intern_SDate_lbl = New Label()
        Adm_Intern_InternID_lbl = New Label()
        Adm_Intern_AddInternID_Mtxt = New MaskedTextBox()
        Adm_Intern_Clear_btn = New Button()
        Adm_Intern_Add_btn = New Button()
        Adm_Intern_Bpan1 = New Panel()
        Adm_Intern_Bpan2 = New Panel()
        Adm_Intern_newEntry_lbl = New Label()
        Adm_Intern_DGV = New DataGridView()
        Adm_Intern_InternID_col = New DataGridViewTextBoxColumn()
        Adm_Intern_SY_col = New DataGridViewTextBoxColumn()
        Adm_Intern_StudName_col = New DataGridViewTextBoxColumn()
        Adm_Intern_Course_col = New DataGridViewTextBoxColumn()
        Adm_Intern_CompName_col = New DataGridViewTextBoxColumn()
        Adm_Intern_Supervisor_col = New DataGridViewTextBoxColumn()
        Adm_Intern_FacEval_col = New DataGridViewTextBoxColumn()
        Adm_Intern_StartDate_col = New DataGridViewTextBoxColumn()
        Adm_Intern_EndDate_col = New DataGridViewTextBoxColumn()
        Adm_Intern_Status_col = New DataGridViewTextBoxColumn()
        Adm_Intern_Grade_col = New DataGridViewTextBoxColumn()
        Adm_Intern_design = New Panel()
        Adm_InternTitle_lbl = New Label()
        Adm_Intern_DateTime_lbl = New Label()
        ADM_SUPERPAN = New Panel()
        Adm_Sup_Supervisor_cmb = New ComboBox()
        Adm_Sup_Supervisor_lbl = New Label()
        Adm_Sup_Clear_btn = New Button()
        Adm_Sup_Add_btn = New Button()
        Adm_Sup_AddCont_lbl = New Label()
        Adm_Sup_AddCont_txt = New MaskedTextBox()
        Adm_Sup_AddPos_txt = New TextBox()
        Adm_Sup_AddPos_lbl = New Label()
        Adm_Sup_AddSuffix_txt = New TextBox()
        Adm_Sup_AddMName_txt = New TextBox()
        Adm_Sup_AddSuffix_lbl = New Label()
        Adm_Sup_AddMName_lbl = New Label()
        Adm_Sup_Comp_cmb = New ComboBox()
        Adm_Sup_AddAddress_txt = New TextBox()
        Adm_Sup_AddFName_txt = New TextBox()
        Adm_Sup_AddLName_txt = New TextBox()
        Adm_Sup_AddAddress_lbl = New Label()
        Adm_Sup_AddFName_lbl = New Label()
        Adm_Sup_AddLName_lbl = New Label()
        Adm_Sup_Comp_lbl = New Label()
        Adm_Sup_SupID_lbl = New Label()
        Adm_Sup_SupID_Mtxt = New MaskedTextBox()
        Adm_Sup_Del_btn = New Button()
        Adm_Sup_Edit_btn = New Button()
        Adm_Sup_Bpan1 = New Panel()
        Adm_Sup_Bpan2 = New Panel()
        Adm_Sup_newEntry_lbl = New Label()
        Adm_Sup_DGV = New DataGridView()
        Adm_Sup_SupID_col = New DataGridViewTextBoxColumn()
        Adm_Sup_LName_col = New DataGridViewTextBoxColumn()
        Adm_Sup_FName_col = New DataGridViewTextBoxColumn()
        Adm_Sup_MName_col = New DataGridViewTextBoxColumn()
        Adm_Sup_Suffix_col = New DataGridViewTextBoxColumn()
        Adm_Sup_Email_col = New DataGridViewTextBoxColumn()
        Adm_Sup_ContNo_col = New DataGridViewTextBoxColumn()
        Adm_Sup_Pos_col = New DataGridViewTextBoxColumn()
        Adm_Sup_design = New Panel()
        Adm_SupTitle_lbl = New Label()
        Adm_Sup_DateTime_lbl = New Label()
        ADM_COMPAN = New Panel()
        Adm_Comp_Clear_btn = New Button()
        Adm_Comp_Add_btn = New Button()
        Adm_Comp_Cont_lbl = New Label()
        Adm_Comp_Cont_Mtxt = New MaskedTextBox()
        Adm_Comp_CompAdd_txt = New TextBox()
        Adm_Comp_CompAdd_lbl = New Label()
        Adm_Comp_CompEmail_txt = New TextBox()
        Adm_Comp_CompName_txt = New TextBox()
        Adm_Comp_CompEmail_lbl = New Label()
        Adm_Comp_CompName_lbl = New Label()
        Adm_Comp_CompID_lbl = New Label()
        Adm_Comp_CompID_Mtxt = New MaskedTextBox()
        Adm_Comp_Del_btn = New Button()
        Adm_Comp_Edit_btn = New Button()
        Adm_Comp_BPan1 = New Panel()
        Adm_Comp_BPan2 = New Panel()
        Adm_Comp_newEntry_lbl = New Label()
        Adm_Comp_DGV = New DataGridView()
        Adm_Comp_CompID_col = New DataGridViewTextBoxColumn()
        Adm_Comp_CompName_col = New DataGridViewTextBoxColumn()
        Adm_Comp_CompAdd_col = New DataGridViewTextBoxColumn()
        Adm_Comp_CompEmail_col = New DataGridViewTextBoxColumn()
        Adm_Comp_CompCont_col = New DataGridViewTextBoxColumn()
        Adm_Comp_design = New Panel()
        Adm_CompTitle_lbl = New Label()
        Adm_Comp_DateTime_lbl = New Label()
        ADM_COURSEPAN = New Panel()
        Adm_Course_Clear_btn = New Button()
        Adm_Course_Add_btn = New Button()
        Adm_Course_CourseName_txt = New TextBox()
        Adm_Course_CourseName_lbl = New Label()
        Adm_Course_DeptID_cmb = New ComboBox()
        Adm_Course_DeptID_lbl = New Label()
        Adm_Course_CourseID_lbl = New Label()
        Adm_Course_CourseID_Mtxt = New MaskedTextBox()
        Adm_Course_DeptIDDisplay_cmb = New ComboBox()
        Adm_Course_DeptIDDisplay_lbl = New Label()
        Adm_Course_Del_btn = New Button()
        Adm_Course_Edit_btn = New Button()
        Adm_Course_BPan1 = New Panel()
        Adm_Course_Bpan2 = New Panel()
        Adm_Course_newEntry_lbl = New Label()
        Adm_Course_DGV = New DataGridView()
        Adm_Course_CourseID_col = New DataGridViewTextBoxColumn()
        Adm_Course_CourseName_col = New DataGridViewTextBoxColumn()
        Adm_Course_design = New Panel()
        Adm_CourseTitle_lbl = New Label()
        Adm_Course_DateTime_lbl = New Label()
        ADM_DEPTPAN = New Panel()
        Adm_Dept_Clear_btn = New Button()
        Adm_Dept_Add_brn = New Button()
        Adm_Dept_Suffix_txt = New TextBox()
        Adm_Dept_Suffix_lbl = New Label()
        Adm_Dept_MName_txt = New TextBox()
        Adm_Dept_MName_lbl = New Label()
        Adm_Dept_Name_txt = New TextBox()
        Adm_Dept_FName_txt = New TextBox()
        Adm_Dept_LName_txt = New TextBox()
        Adm_Dept_Name_lbl = New Label()
        Adm_Dept_FName_lbl = New Label()
        Adm_Dept_LName_lbl = New Label()
        Adm_Dept_DeptID_lbl = New Label()
        Adm_Dept_DeptID_Mtxt = New MaskedTextBox()
        Adm_Dept_Del_btn = New Button()
        Adm_Dept_Edit_btn = New Button()
        Adm_Dept_BPan = New Panel()
        Adm_Dept_BPan2 = New Panel()
        Adm_Dept_Entry_lbl = New Label()
        Adm_Dept_DGV = New DataGridView()
        Adm_DeptID_col = New DataGridViewTextBoxColumn()
        Adm_DeptName_col = New DataGridViewTextBoxColumn()
        Adm_Dept_LName_col = New DataGridViewTextBoxColumn()
        Adm_Dept_FName_col = New DataGridViewTextBoxColumn()
        Adm_Dept_MName_col = New DataGridViewTextBoxColumn()
        Adm_Dept_Suffix_col = New DataGridViewTextBoxColumn()
        Adm_DeptTitle_lbl = New Label()
        Adm_design = New Panel()
        Adm_Dept_DateTime_lbl = New Label()
        FuncSideBar_Panel = New Panel()
        SideCon_BASE = New Panel()
        FuncSidePanel_OUTER = New Panel()
        FuncSidePanel_INNER = New Panel()
        FuncIntPnl = New Panel()
        FuncIntLink = New LinkLabel()
        FuncSupPnl = New Panel()
        FuncSupLink = New LinkLabel()
        FuncComPnl = New Panel()
        FuncComLink = New LinkLabel()
        FuncCoursePnl = New Panel()
        FuncCourseLink = New LinkLabel()
        FuncDepPnl = New Panel()
        FuncDepLink = New LinkLabel()
        FuncFacPnl = New Panel()
        FuncFacLink = New LinkLabel()
        FuncStudPnl = New Panel()
        FuncStudLink = New LinkLabel()
        MainMenu_Panel = New Panel()
        SchoolTitle_Panel = New Panel()
        Logo_Pic = New PictureBox()
        SchoolName_Lbl = New Label()
        RightTop_Panel = New Panel()
        Logout_BTN = New LinkLabel()
        Dashboard_BTN = New LinkLabel()
        Functions_BTN = New LinkLabel()
        Timer1 = New Timer(components)
        FuncSidePan_INNER = New Panel()
        Panel6 = New Panel()
        LinkLabel5 = New LinkLabel()
        Screen_Panel.SuspendLayout()
        Home_Panel.SuspendLayout()
        Content_Panel.SuspendLayout()
        Dashboard_Panel.SuspendLayout()
        Container_Panel.SuspendLayout()
        Stud_Eval_Panel.SuspendLayout()
        CType(SE_DGV, ComponentModel.ISupportInitialize).BeginInit()
        PE_Panel.SuspendLayout()
        Visit_LogPanel.SuspendLayout()
        CType(VL_DGV, ComponentModel.ISupportInitialize).BeginInit()
        Fac_Eval_Panel.SuspendLayout()
        CType(FE_DGV, ComponentModel.ISupportInitialize).BeginInit()
        Stud_Regis_Panel.SuspendLayout()
        CType(SR_DGV, ComponentModel.ISupportInitialize).BeginInit()
        Partner_Comp_Panel.SuspendLayout()
        CType(PC_DGV, ComponentModel.ISupportInitialize).BeginInit()
        DashSideFunc.SuspendLayout()
        DashSide_OUTER.SuspendLayout()
        DashSide_INNER.SuspendLayout()
        VL_BackPan.SuspendLayout()
        FE_BackPan.SuspendLayout()
        PC_BackPan.SuspendLayout()
        SR_BackPan.SuspendLayout()
        SE_BackPan.SuspendLayout()
        Function_Panel.SuspendLayout()
        Func_Container.SuspendLayout()
        ADM_STUDPAN.SuspendLayout()
        CType(STUD_DGV, ComponentModel.ISupportInitialize).BeginInit()
        ADM_FACPAN.SuspendLayout()
        CType(FAC_DGV, ComponentModel.ISupportInitialize).BeginInit()
        ADM_INTERPAN.SuspendLayout()
        CType(Adm_Intern_DGV, ComponentModel.ISupportInitialize).BeginInit()
        ADM_SUPERPAN.SuspendLayout()
        CType(Adm_Sup_DGV, ComponentModel.ISupportInitialize).BeginInit()
        ADM_COMPAN.SuspendLayout()
        CType(Adm_Comp_DGV, ComponentModel.ISupportInitialize).BeginInit()
        ADM_COURSEPAN.SuspendLayout()
        CType(Adm_Course_DGV, ComponentModel.ISupportInitialize).BeginInit()
        ADM_DEPTPAN.SuspendLayout()
        CType(Adm_Dept_DGV, ComponentModel.ISupportInitialize).BeginInit()
        FuncSideBar_Panel.SuspendLayout()
        SideCon_BASE.SuspendLayout()
        FuncSidePanel_OUTER.SuspendLayout()
        FuncSidePanel_INNER.SuspendLayout()
        FuncIntPnl.SuspendLayout()
        FuncSupPnl.SuspendLayout()
        FuncComPnl.SuspendLayout()
        FuncCoursePnl.SuspendLayout()
        FuncDepPnl.SuspendLayout()
        FuncFacPnl.SuspendLayout()
        FuncStudPnl.SuspendLayout()
        MainMenu_Panel.SuspendLayout()
        SchoolTitle_Panel.SuspendLayout()
        CType(Logo_Pic, ComponentModel.ISupportInitialize).BeginInit()
        RightTop_Panel.SuspendLayout()
        FuncSidePan_INNER.SuspendLayout()
        Panel6.SuspendLayout()
        SuspendLayout()
        ' 
        ' Screen_Panel
        ' 
        Screen_Panel.BackColor = SystemColors.Control
        Screen_Panel.Controls.Add(Home_Panel)
        Screen_Panel.Dock = DockStyle.Fill
        Screen_Panel.Location = New Point(0, 0)
        Screen_Panel.Name = "Screen_Panel"
        Screen_Panel.Size = New Size(1902, 1055)
        Screen_Panel.TabIndex = 13
        ' 
        ' Home_Panel
        ' 
        Home_Panel.Controls.Add(Content_Panel)
        Home_Panel.Controls.Add(MainMenu_Panel)
        Home_Panel.Dock = DockStyle.Fill
        Home_Panel.Location = New Point(0, 0)
        Home_Panel.Name = "Home_Panel"
        Home_Panel.Size = New Size(1902, 1055)
        Home_Panel.TabIndex = 0
        ' 
        ' Content_Panel
        ' 
        Content_Panel.BackColor = SystemColors.Info
        Content_Panel.Controls.Add(Dashboard_Panel)
        Content_Panel.Controls.Add(Function_Panel)
        Content_Panel.Dock = DockStyle.Fill
        Content_Panel.Location = New Point(0, 225)
        Content_Panel.Name = "Content_Panel"
        Content_Panel.Size = New Size(1902, 830)
        Content_Panel.TabIndex = 16
        ' 
        ' Dashboard_Panel
        ' 
        Dashboard_Panel.Controls.Add(Container_Panel)
        Dashboard_Panel.Controls.Add(DashSideFunc)
        Dashboard_Panel.Dock = DockStyle.Fill
        Dashboard_Panel.Location = New Point(0, 0)
        Dashboard_Panel.Name = "Dashboard_Panel"
        Dashboard_Panel.Size = New Size(1902, 830)
        Dashboard_Panel.TabIndex = 16
        ' 
        ' Container_Panel
        ' 
        Container_Panel.Controls.Add(Stud_Eval_Panel)
        Container_Panel.Controls.Add(Visit_LogPanel)
        Container_Panel.Controls.Add(Fac_Eval_Panel)
        Container_Panel.Controls.Add(Stud_Regis_Panel)
        Container_Panel.Controls.Add(Partner_Comp_Panel)
        Container_Panel.Dock = DockStyle.Fill
        Container_Panel.Location = New Point(354, 0)
        Container_Panel.Name = "Container_Panel"
        Container_Panel.Size = New Size(1548, 830)
        Container_Panel.TabIndex = 18
        ' 
        ' Stud_Eval_Panel
        ' 
        Stud_Eval_Panel.BackColor = Color.White
        Stud_Eval_Panel.Controls.Add(SE_DGV)
        Stud_Eval_Panel.Controls.Add(PE_Panel)
        Stud_Eval_Panel.Controls.Add(WelcomeLbl)
        Stud_Eval_Panel.Controls.Add(Adm_User_lbl)
        Stud_Eval_Panel.Controls.Add(SRegis_DateTime)
        Stud_Eval_Panel.Location = New Point(20, 30)
        Stud_Eval_Panel.Name = "Stud_Eval_Panel"
        Stud_Eval_Panel.Size = New Size(1515, 780)
        Stud_Eval_Panel.TabIndex = 0
        ' 
        ' SE_DGV
        ' 
        SE_DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        SE_DGV.Columns.AddRange(New DataGridViewColumn() {SE_DGV_IntID, SE_DGV_StudName, SE_DGV_Course, SE_DGV_Section, SE_DGV_CompName, SE_DGV_SVisor, SE_DGV_FacEval, SE_DGV_Stat})
        SE_DGV.Location = New Point(69, 309)
        SE_DGV.Name = "SE_DGV"
        SE_DGV.RowHeadersWidth = 51
        SE_DGV.Size = New Size(1380, 426)
        SE_DGV.TabIndex = 8
        ' 
        ' SE_DGV_IntID
        ' 
        SE_DGV_IntID.HeaderText = "INTERNSHIP ID"
        SE_DGV_IntID.MinimumWidth = 6
        SE_DGV_IntID.Name = "SE_DGV_IntID"
        SE_DGV_IntID.Width = 165
        ' 
        ' SE_DGV_StudName
        ' 
        SE_DGV_StudName.HeaderText = "STUDENT NAME"
        SE_DGV_StudName.MinimumWidth = 6
        SE_DGV_StudName.Name = "SE_DGV_StudName"
        SE_DGV_StudName.Width = 165
        ' 
        ' SE_DGV_Course
        ' 
        SE_DGV_Course.HeaderText = "COURSE"
        SE_DGV_Course.MinimumWidth = 6
        SE_DGV_Course.Name = "SE_DGV_Course"
        SE_DGV_Course.Width = 165
        ' 
        ' SE_DGV_Section
        ' 
        SE_DGV_Section.HeaderText = "SECTION"
        SE_DGV_Section.MinimumWidth = 6
        SE_DGV_Section.Name = "SE_DGV_Section"
        SE_DGV_Section.Width = 165
        ' 
        ' SE_DGV_CompName
        ' 
        SE_DGV_CompName.HeaderText = "COMPANY NAME"
        SE_DGV_CompName.MinimumWidth = 6
        SE_DGV_CompName.Name = "SE_DGV_CompName"
        SE_DGV_CompName.Width = 165
        ' 
        ' SE_DGV_SVisor
        ' 
        SE_DGV_SVisor.HeaderText = "SUPERVISOR"
        SE_DGV_SVisor.MinimumWidth = 6
        SE_DGV_SVisor.Name = "SE_DGV_SVisor"
        SE_DGV_SVisor.Width = 165
        ' 
        ' SE_DGV_FacEval
        ' 
        SE_DGV_FacEval.HeaderText = "FACULTY EVALUATOR"
        SE_DGV_FacEval.MinimumWidth = 6
        SE_DGV_FacEval.Name = "SE_DGV_FacEval"
        SE_DGV_FacEval.Width = 165
        ' 
        ' SE_DGV_Stat
        ' 
        SE_DGV_Stat.HeaderText = "STATUS"
        SE_DGV_Stat.MinimumWidth = 6
        SE_DGV_Stat.Name = "SE_DGV_Stat"
        SE_DGV_Stat.Width = 165
        ' 
        ' PE_Panel
        ' 
        PE_Panel.BackColor = Color.Gold
        PE_Panel.Controls.Add(PE_Lbl)
        PE_Panel.Location = New Point(69, 252)
        PE_Panel.Name = "PE_Panel"
        PE_Panel.Size = New Size(378, 57)
        PE_Panel.TabIndex = 7
        ' 
        ' PE_Lbl
        ' 
        PE_Lbl.AutoSize = True
        PE_Lbl.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        PE_Lbl.ForeColor = SystemColors.MenuText
        PE_Lbl.Location = New Point(10, 14)
        PE_Lbl.Name = "PE_Lbl"
        PE_Lbl.Size = New Size(360, 32)
        PE_Lbl.TabIndex = 6
        PE_Lbl.Text = "STUDENT INFORMATION"
        ' 
        ' WelcomeLbl
        ' 
        WelcomeLbl.Font = New Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        WelcomeLbl.Location = New Point(71, 64)
        WelcomeLbl.Name = "WelcomeLbl"
        WelcomeLbl.Size = New Size(440, 57)
        WelcomeLbl.TabIndex = 5
        WelcomeLbl.Text = "WELCOME,"
        ' 
        ' Adm_User_lbl
        ' 
        Adm_User_lbl.Font = New Font("Times New Roman", 64.2000046F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Adm_User_lbl.Location = New Point(48, 107)
        Adm_User_lbl.Name = "Adm_User_lbl"
        Adm_User_lbl.Size = New Size(1160, 124)
        Adm_User_lbl.TabIndex = 4
        Adm_User_lbl.Text = "ADMINISTRATOR"
        ' 
        ' SRegis_DateTime
        ' 
        SRegis_DateTime.Font = New Font("Rockwell", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SRegis_DateTime.Location = New Point(735, 32)
        SRegis_DateTime.Name = "SRegis_DateTime"
        SRegis_DateTime.Size = New Size(695, 49)
        SRegis_DateTime.TabIndex = 3
        ' 
        ' Visit_LogPanel
        ' 
        Visit_LogPanel.BackColor = Color.White
        Visit_LogPanel.Controls.Add(VL_DGV)
        Visit_LogPanel.Controls.Add(VL_SidePnl)
        Visit_LogPanel.Controls.Add(VL_Lbl)
        Visit_LogPanel.Location = New Point(20, 30)
        Visit_LogPanel.Name = "Visit_LogPanel"
        Visit_LogPanel.Size = New Size(1515, 780)
        Visit_LogPanel.TabIndex = 0
        ' 
        ' VL_DGV
        ' 
        VL_DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        VL_DGV.Columns.AddRange(New DataGridViewColumn() {VL_DGV_VisitID, VL_DGV_StudName, VL_DGV_CompName, VL_DGV_FacEval, VL_DGV_VisitDT, VL_DGV_Rating, VL_DGV_Remarks})
        VL_DGV.Location = New Point(48, 222)
        VL_DGV.Name = "VL_DGV"
        VL_DGV.RowHeadersWidth = 51
        VL_DGV.Size = New Size(1414, 520)
        VL_DGV.TabIndex = 16
        ' 
        ' VL_DGV_VisitID
        ' 
        VL_DGV_VisitID.HeaderText = "VISIT ID"
        VL_DGV_VisitID.MinimumWidth = 6
        VL_DGV_VisitID.Name = "VL_DGV_VisitID"
        VL_DGV_VisitID.Width = 195
        ' 
        ' VL_DGV_StudName
        ' 
        VL_DGV_StudName.HeaderText = "STUDENT NAME"
        VL_DGV_StudName.MinimumWidth = 6
        VL_DGV_StudName.Name = "VL_DGV_StudName"
        VL_DGV_StudName.Width = 195
        ' 
        ' VL_DGV_CompName
        ' 
        VL_DGV_CompName.HeaderText = "COMPANY NAME"
        VL_DGV_CompName.MinimumWidth = 6
        VL_DGV_CompName.Name = "VL_DGV_CompName"
        VL_DGV_CompName.Width = 195
        ' 
        ' VL_DGV_FacEval
        ' 
        VL_DGV_FacEval.HeaderText = "FACULTY EVALUATOR"
        VL_DGV_FacEval.MinimumWidth = 6
        VL_DGV_FacEval.Name = "VL_DGV_FacEval"
        VL_DGV_FacEval.Width = 195
        ' 
        ' VL_DGV_VisitDT
        ' 
        VL_DGV_VisitDT.HeaderText = "VISIT DATE & TIME"
        VL_DGV_VisitDT.MinimumWidth = 6
        VL_DGV_VisitDT.Name = "VL_DGV_VisitDT"
        VL_DGV_VisitDT.Width = 195
        ' 
        ' VL_DGV_Rating
        ' 
        VL_DGV_Rating.HeaderText = "RATING"
        VL_DGV_Rating.MinimumWidth = 6
        VL_DGV_Rating.Name = "VL_DGV_Rating"
        VL_DGV_Rating.Width = 195
        ' 
        ' VL_DGV_Remarks
        ' 
        VL_DGV_Remarks.HeaderText = "REMARKS"
        VL_DGV_Remarks.MinimumWidth = 6
        VL_DGV_Remarks.Name = "VL_DGV_Remarks"
        VL_DGV_Remarks.Width = 195
        ' 
        ' VL_SidePnl
        ' 
        VL_SidePnl.BackColor = Color.Navy
        VL_SidePnl.Location = New Point(48, 75)
        VL_SidePnl.Name = "VL_SidePnl"
        VL_SidePnl.Size = New Size(39, 72)
        VL_SidePnl.TabIndex = 15
        ' 
        ' VL_Lbl
        ' 
        VL_Lbl.Font = New Font("Times New Roman", 54F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        VL_Lbl.Location = New Point(93, 56)
        VL_Lbl.Name = "VL_Lbl"
        VL_Lbl.Size = New Size(1253, 105)
        VL_Lbl.TabIndex = 14
        VL_Lbl.Text = "VISIT LOGS"
        ' 
        ' Fac_Eval_Panel
        ' 
        Fac_Eval_Panel.BackColor = Color.WhiteSmoke
        Fac_Eval_Panel.Controls.Add(FE_DeptLbl)
        Fac_Eval_Panel.Controls.Add(FE_DeptCMB)
        Fac_Eval_Panel.Controls.Add(FE_DGV)
        Fac_Eval_Panel.Controls.Add(FE_SidePnl)
        Fac_Eval_Panel.Controls.Add(FE_Lbl)
        Fac_Eval_Panel.Controls.Add(FEval_DateTime)
        Fac_Eval_Panel.Location = New Point(20, 30)
        Fac_Eval_Panel.Name = "Fac_Eval_Panel"
        Fac_Eval_Panel.Size = New Size(1515, 780)
        Fac_Eval_Panel.TabIndex = 3
        ' 
        ' FE_DeptLbl
        ' 
        FE_DeptLbl.AutoSize = True
        FE_DeptLbl.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FE_DeptLbl.ForeColor = SystemColors.MenuText
        FE_DeptLbl.Location = New Point(48, 180)
        FE_DeptLbl.Name = "FE_DeptLbl"
        FE_DeptLbl.Size = New Size(221, 32)
        FE_DeptLbl.TabIndex = 16
        FE_DeptLbl.Text = "DEPARTMENT:"
        ' 
        ' FE_DeptCMB
        ' 
        FE_DeptCMB.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FE_DeptCMB.FormattingEnabled = True
        FE_DeptCMB.Location = New Point(270, 177)
        FE_DeptCMB.Name = "FE_DeptCMB"
        FE_DeptCMB.Size = New Size(313, 40)
        FE_DeptCMB.TabIndex = 15
        ' 
        ' FE_DGV
        ' 
        FE_DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        FE_DGV.Columns.AddRange(New DataGridViewColumn() {FE_DGV_FacID, FE_DGV_LastName, FE_DGV_FirstName, FE_DGV_MidName, FE_DGV_Suffix, FE_DGV_Employment})
        FE_DGV.Location = New Point(48, 222)
        FE_DGV.Name = "FE_DGV"
        FE_DGV.RowHeadersWidth = 51
        FE_DGV.Size = New Size(1414, 520)
        FE_DGV.TabIndex = 14
        ' 
        ' FE_DGV_FacID
        ' 
        FE_DGV_FacID.HeaderText = "FACULTY ID"
        FE_DGV_FacID.MinimumWidth = 6
        FE_DGV_FacID.Name = "FE_DGV_FacID"
        FE_DGV_FacID.Width = 225
        ' 
        ' FE_DGV_LastName
        ' 
        FE_DGV_LastName.HeaderText = "LAST NAME"
        FE_DGV_LastName.MinimumWidth = 6
        FE_DGV_LastName.Name = "FE_DGV_LastName"
        FE_DGV_LastName.Width = 225
        ' 
        ' FE_DGV_FirstName
        ' 
        FE_DGV_FirstName.HeaderText = "FIRST NAME"
        FE_DGV_FirstName.MinimumWidth = 6
        FE_DGV_FirstName.Name = "FE_DGV_FirstName"
        FE_DGV_FirstName.Width = 225
        ' 
        ' FE_DGV_MidName
        ' 
        FE_DGV_MidName.HeaderText = "MIDDLE NAME"
        FE_DGV_MidName.MinimumWidth = 6
        FE_DGV_MidName.Name = "FE_DGV_MidName"
        FE_DGV_MidName.Width = 225
        ' 
        ' FE_DGV_Suffix
        ' 
        FE_DGV_Suffix.HeaderText = "SUFFIX"
        FE_DGV_Suffix.MinimumWidth = 6
        FE_DGV_Suffix.Name = "FE_DGV_Suffix"
        FE_DGV_Suffix.Width = 225
        ' 
        ' FE_DGV_Employment
        ' 
        FE_DGV_Employment.HeaderText = "EMPLOYMENT"
        FE_DGV_Employment.MinimumWidth = 6
        FE_DGV_Employment.Name = "FE_DGV_Employment"
        FE_DGV_Employment.Width = 225
        ' 
        ' FE_SidePnl
        ' 
        FE_SidePnl.BackColor = Color.Navy
        FE_SidePnl.Location = New Point(48, 75)
        FE_SidePnl.Name = "FE_SidePnl"
        FE_SidePnl.Size = New Size(39, 72)
        FE_SidePnl.TabIndex = 13
        ' 
        ' FE_Lbl
        ' 
        FE_Lbl.Font = New Font("Times New Roman", 54F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FE_Lbl.Location = New Point(93, 56)
        FE_Lbl.Name = "FE_Lbl"
        FE_Lbl.Size = New Size(1253, 105)
        FE_Lbl.TabIndex = 12
        FE_Lbl.Text = "FACULTY EVALUATORS"
        ' 
        ' FEval_DateTime
        ' 
        FEval_DateTime.Font = New Font("Rockwell", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FEval_DateTime.Location = New Point(528, 5)
        FEval_DateTime.Name = "FEval_DateTime"
        FEval_DateTime.Size = New Size(984, 51)
        FEval_DateTime.TabIndex = 7
        FEval_DateTime.TextAlign = ContentAlignment.TopRight
        ' 
        ' Stud_Regis_Panel
        ' 
        Stud_Regis_Panel.BackColor = Color.WhiteSmoke
        Stud_Regis_Panel.Controls.Add(SR_DeptLbl)
        Stud_Regis_Panel.Controls.Add(SR_DeptCMB)
        Stud_Regis_Panel.Controls.Add(SR_DGV)
        Stud_Regis_Panel.Controls.Add(SR_SidePnl)
        Stud_Regis_Panel.Controls.Add(SR_Lbl)
        Stud_Regis_Panel.Controls.Add(SEval_DateTime)
        Stud_Regis_Panel.Location = New Point(20, 30)
        Stud_Regis_Panel.Name = "Stud_Regis_Panel"
        Stud_Regis_Panel.Size = New Size(1515, 780)
        Stud_Regis_Panel.TabIndex = 1
        ' 
        ' SR_DeptLbl
        ' 
        SR_DeptLbl.AutoSize = True
        SR_DeptLbl.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SR_DeptLbl.ForeColor = SystemColors.MenuText
        SR_DeptLbl.Location = New Point(48, 180)
        SR_DeptLbl.Name = "SR_DeptLbl"
        SR_DeptLbl.Size = New Size(221, 32)
        SR_DeptLbl.TabIndex = 12
        SR_DeptLbl.Text = "DEPARTMENT:"
        ' 
        ' SR_DeptCMB
        ' 
        SR_DeptCMB.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SR_DeptCMB.FormattingEnabled = True
        SR_DeptCMB.Location = New Point(270, 177)
        SR_DeptCMB.Name = "SR_DeptCMB"
        SR_DeptCMB.Size = New Size(313, 40)
        SR_DeptCMB.TabIndex = 11
        ' 
        ' SR_DGV
        ' 
        SR_DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        SR_DGV.Columns.AddRange(New DataGridViewColumn() {SR_DGV_StudID, SR_DGV_LastName, SR_DGV_FirstName, SR_DGV_MiddleName, SR_DGV_Suffix, SR_DGV_Course, SR_DGV_Section})
        SR_DGV.Location = New Point(48, 222)
        SR_DGV.Name = "SR_DGV"
        SR_DGV.RowHeadersWidth = 51
        SR_DGV.Size = New Size(1414, 520)
        SR_DGV.TabIndex = 10
        ' 
        ' SR_DGV_StudID
        ' 
        SR_DGV_StudID.HeaderText = "STUDENT ID"
        SR_DGV_StudID.MinimumWidth = 6
        SR_DGV_StudID.Name = "SR_DGV_StudID"
        SR_DGV_StudID.Width = 195
        ' 
        ' SR_DGV_LastName
        ' 
        SR_DGV_LastName.HeaderText = "LAST NAME"
        SR_DGV_LastName.MinimumWidth = 6
        SR_DGV_LastName.Name = "SR_DGV_LastName"
        SR_DGV_LastName.Width = 195
        ' 
        ' SR_DGV_FirstName
        ' 
        SR_DGV_FirstName.HeaderText = "FIRST NAME"
        SR_DGV_FirstName.MinimumWidth = 6
        SR_DGV_FirstName.Name = "SR_DGV_FirstName"
        SR_DGV_FirstName.Width = 195
        ' 
        ' SR_DGV_MiddleName
        ' 
        SR_DGV_MiddleName.HeaderText = "MIDDLE NAME"
        SR_DGV_MiddleName.MinimumWidth = 6
        SR_DGV_MiddleName.Name = "SR_DGV_MiddleName"
        SR_DGV_MiddleName.Width = 195
        ' 
        ' SR_DGV_Suffix
        ' 
        SR_DGV_Suffix.HeaderText = "SUFFIX"
        SR_DGV_Suffix.MinimumWidth = 6
        SR_DGV_Suffix.Name = "SR_DGV_Suffix"
        SR_DGV_Suffix.Width = 195
        ' 
        ' SR_DGV_Course
        ' 
        SR_DGV_Course.HeaderText = "COURSE"
        SR_DGV_Course.MinimumWidth = 6
        SR_DGV_Course.Name = "SR_DGV_Course"
        SR_DGV_Course.Width = 195
        ' 
        ' SR_DGV_Section
        ' 
        SR_DGV_Section.HeaderText = "SECTION"
        SR_DGV_Section.MinimumWidth = 6
        SR_DGV_Section.Name = "SR_DGV_Section"
        SR_DGV_Section.Width = 195
        ' 
        ' SR_SidePnl
        ' 
        SR_SidePnl.BackColor = Color.Navy
        SR_SidePnl.Location = New Point(48, 75)
        SR_SidePnl.Name = "SR_SidePnl"
        SR_SidePnl.Size = New Size(39, 72)
        SR_SidePnl.TabIndex = 9
        ' 
        ' SR_Lbl
        ' 
        SR_Lbl.Font = New Font("Times New Roman", 54F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SR_Lbl.Location = New Point(93, 56)
        SR_Lbl.Name = "SR_Lbl"
        SR_Lbl.Size = New Size(1253, 105)
        SR_Lbl.TabIndex = 8
        SR_Lbl.Text = "STUDENTS REGISTERED"
        ' 
        ' SEval_DateTime
        ' 
        SEval_DateTime.Font = New Font("Rockwell", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SEval_DateTime.Location = New Point(528, 5)
        SEval_DateTime.Name = "SEval_DateTime"
        SEval_DateTime.Size = New Size(986, 51)
        SEval_DateTime.TabIndex = 2
        SEval_DateTime.TextAlign = ContentAlignment.TopRight
        ' 
        ' Partner_Comp_Panel
        ' 
        Partner_Comp_Panel.BackColor = Color.WhiteSmoke
        Partner_Comp_Panel.Controls.Add(PC_DGV)
        Partner_Comp_Panel.Controls.Add(PC_SidePan)
        Partner_Comp_Panel.Controls.Add(PC_Lbl)
        Partner_Comp_Panel.Controls.Add(PComp_DateTime)
        Partner_Comp_Panel.Location = New Point(20, 30)
        Partner_Comp_Panel.Name = "Partner_Comp_Panel"
        Partner_Comp_Panel.Size = New Size(1515, 780)
        Partner_Comp_Panel.TabIndex = 3
        ' 
        ' PC_DGV
        ' 
        PC_DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        PC_DGV.Columns.AddRange(New DataGridViewColumn() {PC_DGV_CompID, PC_DGV_CompName, PC_DGV_CompAd, PC_DGV_CompEmail, PC_DGV_CompCon, PC_DGV_SVisor})
        PC_DGV.Location = New Point(48, 222)
        PC_DGV.Name = "PC_DGV"
        PC_DGV.RowHeadersWidth = 51
        PC_DGV.Size = New Size(1414, 520)
        PC_DGV.TabIndex = 12
        ' 
        ' PC_DGV_CompID
        ' 
        PC_DGV_CompID.HeaderText = "COMPANY ID"
        PC_DGV_CompID.MinimumWidth = 6
        PC_DGV_CompID.Name = "PC_DGV_CompID"
        PC_DGV_CompID.Width = 225
        ' 
        ' PC_DGV_CompName
        ' 
        PC_DGV_CompName.HeaderText = "COMPANY NAME"
        PC_DGV_CompName.MinimumWidth = 6
        PC_DGV_CompName.Name = "PC_DGV_CompName"
        PC_DGV_CompName.Width = 225
        ' 
        ' PC_DGV_CompAd
        ' 
        PC_DGV_CompAd.HeaderText = "COMPANY ADDRESS"
        PC_DGV_CompAd.MinimumWidth = 6
        PC_DGV_CompAd.Name = "PC_DGV_CompAd"
        PC_DGV_CompAd.Width = 225
        ' 
        ' PC_DGV_CompEmail
        ' 
        PC_DGV_CompEmail.HeaderText = "COMPANY EMAIL"
        PC_DGV_CompEmail.MinimumWidth = 6
        PC_DGV_CompEmail.Name = "PC_DGV_CompEmail"
        PC_DGV_CompEmail.Width = 225
        ' 
        ' PC_DGV_CompCon
        ' 
        PC_DGV_CompCon.HeaderText = "COMPANY CONTACT"
        PC_DGV_CompCon.MinimumWidth = 6
        PC_DGV_CompCon.Name = "PC_DGV_CompCon"
        PC_DGV_CompCon.Width = 225
        ' 
        ' PC_DGV_SVisor
        ' 
        PC_DGV_SVisor.HeaderText = "SUPERVISORS"
        PC_DGV_SVisor.MinimumWidth = 6
        PC_DGV_SVisor.Name = "PC_DGV_SVisor"
        PC_DGV_SVisor.Width = 225
        ' 
        ' PC_SidePan
        ' 
        PC_SidePan.BackColor = Color.Navy
        PC_SidePan.Location = New Point(48, 75)
        PC_SidePan.Name = "PC_SidePan"
        PC_SidePan.Size = New Size(39, 72)
        PC_SidePan.TabIndex = 11
        ' 
        ' PC_Lbl
        ' 
        PC_Lbl.Font = New Font("Times New Roman", 54F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PC_Lbl.Location = New Point(93, 56)
        PC_Lbl.Name = "PC_Lbl"
        PC_Lbl.Size = New Size(1253, 105)
        PC_Lbl.TabIndex = 10
        PC_Lbl.Text = "PARTNER COMPANIES"
        ' 
        ' PComp_DateTime
        ' 
        PComp_DateTime.Font = New Font("Rockwell", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        PComp_DateTime.Location = New Point(528, 5)
        PComp_DateTime.Name = "PComp_DateTime"
        PComp_DateTime.Size = New Size(984, 51)
        PComp_DateTime.TabIndex = 4
        PComp_DateTime.TextAlign = ContentAlignment.TopRight
        ' 
        ' DashSideFunc
        ' 
        DashSideFunc.BackColor = SystemColors.Info
        DashSideFunc.Controls.Add(DashSide_OUTER)
        DashSideFunc.Dock = DockStyle.Left
        DashSideFunc.Location = New Point(0, 0)
        DashSideFunc.Name = "DashSideFunc"
        DashSideFunc.Size = New Size(354, 830)
        DashSideFunc.TabIndex = 17
        ' 
        ' DashSide_OUTER
        ' 
        DashSide_OUTER.BackColor = Color.Orange
        DashSide_OUTER.Controls.Add(DashSide_INNER)
        DashSide_OUTER.Location = New Point(-56, 50)
        DashSide_OUTER.Name = "DashSide_OUTER"
        DashSide_OUTER.Size = New Size(384, 736)
        DashSide_OUTER.TabIndex = 0
        ' 
        ' DashSide_INNER
        ' 
        DashSide_INNER.Controls.Add(VL_BackPan)
        DashSide_INNER.Controls.Add(FE_BackPan)
        DashSide_INNER.Controls.Add(PC_BackPan)
        DashSide_INNER.Controls.Add(SR_BackPan)
        DashSide_INNER.Controls.Add(SE_BackPan)
        DashSide_INNER.Location = New Point(30, 30)
        DashSide_INNER.Name = "DashSide_INNER"
        DashSide_INNER.Size = New Size(334, 680)
        DashSide_INNER.TabIndex = 0
        ' 
        ' VL_BackPan
        ' 
        VL_BackPan.BackColor = Color.Orange
        VL_BackPan.Controls.Add(VL_LinkLbl)
        VL_BackPan.Location = New Point(-1, 549)
        VL_BackPan.Name = "VL_BackPan"
        VL_BackPan.Size = New Size(320, 99)
        VL_BackPan.TabIndex = 22
        ' 
        ' VL_LinkLbl
        ' 
        VL_LinkLbl.ActiveLinkColor = Color.Goldenrod
        VL_LinkLbl.BackColor = Color.Orange
        VL_LinkLbl.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        VL_LinkLbl.ForeColor = SystemColors.ActiveCaptionText
        VL_LinkLbl.LinkColor = Color.White
        VL_LinkLbl.Location = New Point(65, 31)
        VL_LinkLbl.Name = "VL_LinkLbl"
        VL_LinkLbl.Size = New Size(215, 32)
        VL_LinkLbl.TabIndex = 11
        VL_LinkLbl.TabStop = True
        VL_LinkLbl.Text = "VISIT LOGS"
        VL_LinkLbl.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' FE_BackPan
        ' 
        FE_BackPan.BackColor = Color.Orange
        FE_BackPan.Controls.Add(FE_LinkLbl)
        FE_BackPan.Location = New Point(0, 423)
        FE_BackPan.Name = "FE_BackPan"
        FE_BackPan.Size = New Size(319, 99)
        FE_BackPan.TabIndex = 21
        ' 
        ' FE_LinkLbl
        ' 
        FE_LinkLbl.ActiveLinkColor = Color.Goldenrod
        FE_LinkLbl.BackColor = Color.Orange
        FE_LinkLbl.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FE_LinkLbl.ForeColor = SystemColors.ActiveCaptionText
        FE_LinkLbl.LinkColor = Color.White
        FE_LinkLbl.Location = New Point(67, 13)
        FE_LinkLbl.Name = "FE_LinkLbl"
        FE_LinkLbl.Size = New Size(215, 70)
        FE_LinkLbl.TabIndex = 11
        FE_LinkLbl.TabStop = True
        FE_LinkLbl.Text = "FACULTY EVALUATORS"
        FE_LinkLbl.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' PC_BackPan
        ' 
        PC_BackPan.BackColor = Color.Orange
        PC_BackPan.Controls.Add(PC_LinkLbl)
        PC_BackPan.Location = New Point(0, 290)
        PC_BackPan.Name = "PC_BackPan"
        PC_BackPan.Size = New Size(319, 99)
        PC_BackPan.TabIndex = 20
        ' 
        ' PC_LinkLbl
        ' 
        PC_LinkLbl.ActiveLinkColor = Color.Goldenrod
        PC_LinkLbl.BackColor = Color.Orange
        PC_LinkLbl.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        PC_LinkLbl.ForeColor = SystemColors.ActiveCaptionText
        PC_LinkLbl.LinkColor = Color.White
        PC_LinkLbl.Location = New Point(67, 12)
        PC_LinkLbl.Name = "PC_LinkLbl"
        PC_LinkLbl.Size = New Size(215, 70)
        PC_LinkLbl.TabIndex = 11
        PC_LinkLbl.TabStop = True
        PC_LinkLbl.Text = "PARTNER COMPANIES"
        PC_LinkLbl.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' SR_BackPan
        ' 
        SR_BackPan.BackColor = Color.Orange
        SR_BackPan.Controls.Add(SR_LinkLbl)
        SR_BackPan.Location = New Point(0, 160)
        SR_BackPan.Name = "SR_BackPan"
        SR_BackPan.Size = New Size(319, 99)
        SR_BackPan.TabIndex = 19
        ' 
        ' SR_LinkLbl
        ' 
        SR_LinkLbl.ActiveLinkColor = Color.Goldenrod
        SR_LinkLbl.BackColor = Color.Orange
        SR_LinkLbl.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SR_LinkLbl.ForeColor = SystemColors.ActiveCaptionText
        SR_LinkLbl.LinkColor = Color.White
        SR_LinkLbl.Location = New Point(66, 12)
        SR_LinkLbl.Name = "SR_LinkLbl"
        SR_LinkLbl.Size = New Size(215, 70)
        SR_LinkLbl.TabIndex = 11
        SR_LinkLbl.TabStop = True
        SR_LinkLbl.Text = "STUDENTS" & vbCrLf & "REGISTERED"
        SR_LinkLbl.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' SE_BackPan
        ' 
        SE_BackPan.BackColor = Color.White
        SE_BackPan.Controls.Add(SE_LinkLbl)
        SE_BackPan.Location = New Point(3, 30)
        SE_BackPan.Name = "SE_BackPan"
        SE_BackPan.Size = New Size(316, 99)
        SE_BackPan.TabIndex = 15
        ' 
        ' SE_LinkLbl
        ' 
        SE_LinkLbl.ActiveLinkColor = Color.Goldenrod
        SE_LinkLbl.BackColor = Color.Transparent
        SE_LinkLbl.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SE_LinkLbl.ForeColor = SystemColors.ActiveCaptionText
        SE_LinkLbl.LinkColor = Color.Black
        SE_LinkLbl.Location = New Point(63, 14)
        SE_LinkLbl.Name = "SE_LinkLbl"
        SE_LinkLbl.Size = New Size(220, 70)
        SE_LinkLbl.TabIndex = 11
        SE_LinkLbl.TabStop = True
        SE_LinkLbl.Text = "STUDENT" & vbCrLf & "INFORMATION"
        SE_LinkLbl.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Function_Panel
        ' 
        Function_Panel.Controls.Add(Func_Container)
        Function_Panel.Controls.Add(FuncSideBar_Panel)
        Function_Panel.Dock = DockStyle.Fill
        Function_Panel.Location = New Point(0, 0)
        Function_Panel.Name = "Function_Panel"
        Function_Panel.Size = New Size(1902, 830)
        Function_Panel.TabIndex = 11
        ' 
        ' Func_Container
        ' 
        Func_Container.Controls.Add(ADM_STUDPAN)
        Func_Container.Controls.Add(ADM_FACPAN)
        Func_Container.Controls.Add(ADM_INTERPAN)
        Func_Container.Controls.Add(ADM_SUPERPAN)
        Func_Container.Controls.Add(ADM_COMPAN)
        Func_Container.Controls.Add(ADM_COURSEPAN)
        Func_Container.Controls.Add(ADM_DEPTPAN)
        Func_Container.Dock = DockStyle.Fill
        Func_Container.Location = New Point(354, 0)
        Func_Container.Name = "Func_Container"
        Func_Container.Size = New Size(1548, 830)
        Func_Container.TabIndex = 17
        ' 
        ' ADM_STUDPAN
        ' 
        ADM_STUDPAN.BackColor = Color.WhiteSmoke
        ADM_STUDPAN.Controls.Add(Stud_SecCmb)
        ADM_STUDPAN.Controls.Add(Stud_SemCmb)
        ADM_STUDPAN.Controls.Add(Stud_CourseCmb)
        ADM_STUDPAN.Controls.Add(STUD_ClrBtn)
        ADM_STUDPAN.Controls.Add(STUD_AddBtn)
        ADM_STUDPAN.Controls.Add(Stud_EmailTB)
        ADM_STUDPAN.Controls.Add(Stud_SuffixTB)
        ADM_STUDPAN.Controls.Add(Stud_MidTB)
        ADM_STUDPAN.Controls.Add(Stud_FirstTB)
        ADM_STUDPAN.Controls.Add(Stud_LastTB)
        ADM_STUDPAN.Controls.Add(Stud_ConLbl)
        ADM_STUDPAN.Controls.Add(Stud_ConMTB)
        ADM_STUDPAN.Controls.Add(Stud_EmLbl)
        ADM_STUDPAN.Controls.Add(Stud_SemLbl)
        ADM_STUDPAN.Controls.Add(Stud_CourseLbl)
        ADM_STUDPAN.Controls.Add(Stud_SufLbl)
        ADM_STUDPAN.Controls.Add(Stud_MidLbl)
        ADM_STUDPAN.Controls.Add(Stud_FirstLbl)
        ADM_STUDPAN.Controls.Add(Stud_LastLbl)
        ADM_STUDPAN.Controls.Add(Stud_SecLbl)
        ADM_STUDPAN.Controls.Add(Stud_StudIDPnl)
        ADM_STUDPAN.Controls.Add(MaskedTextBox1)
        ADM_STUDPAN.Controls.Add(STUD_DelBtn)
        ADM_STUDPAN.Controls.Add(STUD_EdBtn)
        ADM_STUDPAN.Controls.Add(StudBot_Pnl)
        ADM_STUDPAN.Controls.Add(StudTop_Pnl)
        ADM_STUDPAN.Controls.Add(FuncStud_NewEnt)
        ADM_STUDPAN.Controls.Add(FuncStudSPan)
        ADM_STUDPAN.Controls.Add(STUD_DGV)
        ADM_STUDPAN.Controls.Add(STUD_Lbl)
        ADM_STUDPAN.Controls.Add(Adm_Func_StudDateTime_lbl)
        ADM_STUDPAN.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ADM_STUDPAN.Location = New Point(17, 25)
        ADM_STUDPAN.Name = "ADM_STUDPAN"
        ADM_STUDPAN.Size = New Size(1515, 793)
        ADM_STUDPAN.TabIndex = 1
        ' 
        ' Stud_SecCmb
        ' 
        Stud_SecCmb.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Stud_SecCmb.FormattingEnabled = True
        Stud_SecCmb.Location = New Point(222, 681)
        Stud_SecCmb.Name = "Stud_SecCmb"
        Stud_SecCmb.Size = New Size(142, 40)
        Stud_SecCmb.TabIndex = 45
        ' 
        ' Stud_SemCmb
        ' 
        Stud_SemCmb.FormattingEnabled = True
        Stud_SemCmb.Location = New Point(62, 681)
        Stud_SemCmb.Name = "Stud_SemCmb"
        Stud_SemCmb.Size = New Size(136, 39)
        Stud_SemCmb.TabIndex = 44
        ' 
        ' Stud_CourseCmb
        ' 
        Stud_CourseCmb.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Stud_CourseCmb.FormattingEnabled = True
        Stud_CourseCmb.Location = New Point(1267, 591)
        Stud_CourseCmb.Name = "Stud_CourseCmb"
        Stud_CourseCmb.Size = New Size(187, 40)
        Stud_CourseCmb.TabIndex = 43
        ' 
        ' STUD_ClrBtn
        ' 
        STUD_ClrBtn.BackColor = Color.Orange
        STUD_ClrBtn.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        STUD_ClrBtn.ForeColor = SystemColors.ButtonHighlight
        STUD_ClrBtn.Location = New Point(1303, 669)
        STUD_ClrBtn.Name = "STUD_ClrBtn"
        STUD_ClrBtn.Size = New Size(151, 60)
        STUD_ClrBtn.TabIndex = 42
        STUD_ClrBtn.Text = "CLEAR"
        STUD_ClrBtn.UseVisualStyleBackColor = False
        ' 
        ' STUD_AddBtn
        ' 
        STUD_AddBtn.BackColor = Color.ForestGreen
        STUD_AddBtn.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        STUD_AddBtn.ForeColor = SystemColors.ButtonHighlight
        STUD_AddBtn.Location = New Point(1137, 669)
        STUD_AddBtn.Name = "STUD_AddBtn"
        STUD_AddBtn.Size = New Size(151, 60)
        STUD_AddBtn.TabIndex = 41
        STUD_AddBtn.Text = "ADD"
        STUD_AddBtn.UseVisualStyleBackColor = False
        ' 
        ' Stud_EmailTB
        ' 
        Stud_EmailTB.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Stud_EmailTB.Location = New Point(389, 680)
        Stud_EmailTB.Name = "Stud_EmailTB"
        Stud_EmailTB.Size = New Size(453, 39)
        Stud_EmailTB.TabIndex = 40
        ' 
        ' Stud_SuffixTB
        ' 
        Stud_SuffixTB.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Stud_SuffixTB.Location = New Point(1129, 590)
        Stud_SuffixTB.Name = "Stud_SuffixTB"
        Stud_SuffixTB.Size = New Size(114, 39)
        Stud_SuffixTB.TabIndex = 36
        ' 
        ' Stud_MidTB
        ' 
        Stud_MidTB.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Stud_MidTB.Location = New Point(865, 590)
        Stud_MidTB.Name = "Stud_MidTB"
        Stud_MidTB.Size = New Size(240, 39)
        Stud_MidTB.TabIndex = 35
        ' 
        ' Stud_FirstTB
        ' 
        Stud_FirstTB.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Stud_FirstTB.Location = New Point(485, 590)
        Stud_FirstTB.Name = "Stud_FirstTB"
        Stud_FirstTB.Size = New Size(357, 39)
        Stud_FirstTB.TabIndex = 34
        ' 
        ' Stud_LastTB
        ' 
        Stud_LastTB.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Stud_LastTB.Location = New Point(273, 590)
        Stud_LastTB.Name = "Stud_LastTB"
        Stud_LastTB.Size = New Size(186, 39)
        Stud_LastTB.TabIndex = 33
        ' 
        ' Stud_ConLbl
        ' 
        Stud_ConLbl.AutoSize = True
        Stud_ConLbl.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Stud_ConLbl.Location = New Point(865, 652)
        Stud_ConLbl.Name = "Stud_ConLbl"
        Stud_ConLbl.Size = New Size(145, 27)
        Stud_ConLbl.TabIndex = 32
        Stud_ConLbl.Text = "Contact No."
        Stud_ConLbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Stud_ConMTB
        ' 
        Stud_ConMTB.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Stud_ConMTB.Location = New Point(865, 680)
        Stud_ConMTB.Name = "Stud_ConMTB"
        Stud_ConMTB.Size = New Size(240, 39)
        Stud_ConMTB.TabIndex = 31
        ' 
        ' Stud_EmLbl
        ' 
        Stud_EmLbl.AutoSize = True
        Stud_EmLbl.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Stud_EmLbl.Location = New Point(389, 652)
        Stud_EmLbl.Name = "Stud_EmLbl"
        Stud_EmLbl.Size = New Size(179, 27)
        Stud_EmLbl.TabIndex = 30
        Stud_EmLbl.Text = "Email Address:"
        Stud_EmLbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Stud_SemLbl
        ' 
        Stud_SemLbl.AutoSize = True
        Stud_SemLbl.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Stud_SemLbl.Location = New Point(62, 652)
        Stud_SemLbl.Name = "Stud_SemLbl"
        Stud_SemLbl.Size = New Size(126, 27)
        Stud_SemLbl.TabIndex = 28
        Stud_SemLbl.Text = "Semester:"
        Stud_SemLbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Stud_CourseLbl
        ' 
        Stud_CourseLbl.AutoSize = True
        Stud_CourseLbl.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Stud_CourseLbl.Location = New Point(1267, 561)
        Stud_CourseLbl.Name = "Stud_CourseLbl"
        Stud_CourseLbl.Size = New Size(100, 27)
        Stud_CourseLbl.TabIndex = 26
        Stud_CourseLbl.Text = "Course:"
        Stud_CourseLbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Stud_SufLbl
        ' 
        Stud_SufLbl.AutoSize = True
        Stud_SufLbl.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Stud_SufLbl.Location = New Point(1129, 561)
        Stud_SufLbl.Name = "Stud_SufLbl"
        Stud_SufLbl.Size = New Size(82, 27)
        Stud_SufLbl.TabIndex = 24
        Stud_SufLbl.Text = "Suffix:"
        Stud_SufLbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Stud_MidLbl
        ' 
        Stud_MidLbl.AutoSize = True
        Stud_MidLbl.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Stud_MidLbl.Location = New Point(865, 561)
        Stud_MidLbl.Name = "Stud_MidLbl"
        Stud_MidLbl.Size = New Size(163, 27)
        Stud_MidLbl.TabIndex = 22
        Stud_MidLbl.Text = "Middle Name:"
        Stud_MidLbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Stud_FirstLbl
        ' 
        Stud_FirstLbl.AutoSize = True
        Stud_FirstLbl.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Stud_FirstLbl.Location = New Point(485, 561)
        Stud_FirstLbl.Name = "Stud_FirstLbl"
        Stud_FirstLbl.Size = New Size(140, 27)
        Stud_FirstLbl.TabIndex = 20
        Stud_FirstLbl.Text = "First Name:"
        Stud_FirstLbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Stud_LastLbl
        ' 
        Stud_LastLbl.AutoSize = True
        Stud_LastLbl.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Stud_LastLbl.Location = New Point(273, 561)
        Stud_LastLbl.Name = "Stud_LastLbl"
        Stud_LastLbl.Size = New Size(138, 27)
        Stud_LastLbl.TabIndex = 18
        Stud_LastLbl.Text = "Last Name:"
        Stud_LastLbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Stud_SecLbl
        ' 
        Stud_SecLbl.AutoSize = True
        Stud_SecLbl.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Stud_SecLbl.Location = New Point(222, 652)
        Stud_SecLbl.Name = "Stud_SecLbl"
        Stud_SecLbl.Size = New Size(104, 27)
        Stud_SecLbl.TabIndex = 16
        Stud_SecLbl.Text = "Section:"
        Stud_SecLbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Stud_StudIDPnl
        ' 
        Stud_StudIDPnl.AutoSize = True
        Stud_StudIDPnl.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Stud_StudIDPnl.Location = New Point(62, 561)
        Stud_StudIDPnl.Name = "Stud_StudIDPnl"
        Stud_StudIDPnl.Size = New Size(136, 27)
        Stud_StudIDPnl.TabIndex = 14
        Stud_StudIDPnl.Text = "Student ID:"
        Stud_StudIDPnl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' MaskedTextBox1
        ' 
        MaskedTextBox1.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MaskedTextBox1.Location = New Point(62, 590)
        MaskedTextBox1.Name = "MaskedTextBox1"
        MaskedTextBox1.Size = New Size(186, 39)
        MaskedTextBox1.TabIndex = 13
        ' 
        ' STUD_DelBtn
        ' 
        STUD_DelBtn.BackColor = Color.DarkRed
        STUD_DelBtn.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        STUD_DelBtn.ForeColor = SystemColors.ButtonHighlight
        STUD_DelBtn.Location = New Point(1303, 464)
        STUD_DelBtn.Name = "STUD_DelBtn"
        STUD_DelBtn.Size = New Size(151, 60)
        STUD_DelBtn.TabIndex = 12
        STUD_DelBtn.Text = "DELETE"
        STUD_DelBtn.UseVisualStyleBackColor = False
        ' 
        ' STUD_EdBtn
        ' 
        STUD_EdBtn.BackColor = Color.Navy
        STUD_EdBtn.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        STUD_EdBtn.ForeColor = SystemColors.ButtonHighlight
        STUD_EdBtn.Location = New Point(1137, 464)
        STUD_EdBtn.Name = "STUD_EdBtn"
        STUD_EdBtn.Size = New Size(151, 60)
        STUD_EdBtn.TabIndex = 11
        STUD_EdBtn.Text = "EDIT"
        STUD_EdBtn.UseVisualStyleBackColor = False
        ' 
        ' StudBot_Pnl
        ' 
        StudBot_Pnl.BackColor = Color.Black
        StudBot_Pnl.Location = New Point(51, 526)
        StudBot_Pnl.Name = "StudBot_Pnl"
        StudBot_Pnl.Size = New Size(1054, 10)
        StudBot_Pnl.TabIndex = 10
        ' 
        ' StudTop_Pnl
        ' 
        StudTop_Pnl.BackColor = Color.Black
        StudTop_Pnl.Location = New Point(51, 450)
        StudTop_Pnl.Name = "StudTop_Pnl"
        StudTop_Pnl.Size = New Size(1054, 10)
        StudTop_Pnl.TabIndex = 9
        ' 
        ' FuncStud_NewEnt
        ' 
        FuncStud_NewEnt.AutoSize = True
        FuncStud_NewEnt.Font = New Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FuncStud_NewEnt.Location = New Point(482, 473)
        FuncStud_NewEnt.Name = "FuncStud_NewEnt"
        FuncStud_NewEnt.Size = New Size(222, 39)
        FuncStud_NewEnt.TabIndex = 8
        FuncStud_NewEnt.Text = "NEW ENTRY"
        ' 
        ' FuncStudSPan
        ' 
        FuncStudSPan.BackColor = Color.Navy
        FuncStudSPan.Location = New Point(51, 41)
        FuncStudSPan.Name = "FuncStudSPan"
        FuncStudSPan.Size = New Size(39, 72)
        FuncStudSPan.TabIndex = 7
        ' 
        ' STUD_DGV
        ' 
        STUD_DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        STUD_DGV.Columns.AddRange(New DataGridViewColumn() {Stud_DGV_SID, Stud_DGV_LastN, Stud_DGV_FirstN, Stud_DGV_MidN, Stud_DGV_Suf, Stud_DGV_Course, Stud_DGV_Sem, Stud_DGV_Sec, Stud_DGV_Email, Stud_DGV_Con})
        STUD_DGV.Location = New Point(51, 182)
        STUD_DGV.Name = "STUD_DGV"
        STUD_DGV.RowHeadersWidth = 51
        STUD_DGV.Size = New Size(1403, 252)
        STUD_DGV.TabIndex = 6
        ' 
        ' Stud_DGV_SID
        ' 
        Stud_DGV_SID.HeaderText = "STUDENT ID"
        Stud_DGV_SID.MinimumWidth = 6
        Stud_DGV_SID.Name = "Stud_DGV_SID"
        Stud_DGV_SID.Width = 135
        ' 
        ' Stud_DGV_LastN
        ' 
        Stud_DGV_LastN.HeaderText = "LAST NAME"
        Stud_DGV_LastN.MinimumWidth = 6
        Stud_DGV_LastN.Name = "Stud_DGV_LastN"
        Stud_DGV_LastN.Width = 135
        ' 
        ' Stud_DGV_FirstN
        ' 
        Stud_DGV_FirstN.HeaderText = "FIRST NAME"
        Stud_DGV_FirstN.MinimumWidth = 6
        Stud_DGV_FirstN.Name = "Stud_DGV_FirstN"
        Stud_DGV_FirstN.Width = 135
        ' 
        ' Stud_DGV_MidN
        ' 
        Stud_DGV_MidN.HeaderText = "MIDDLE NAME"
        Stud_DGV_MidN.MinimumWidth = 6
        Stud_DGV_MidN.Name = "Stud_DGV_MidN"
        Stud_DGV_MidN.Width = 135
        ' 
        ' Stud_DGV_Suf
        ' 
        Stud_DGV_Suf.HeaderText = "SUFFIX"
        Stud_DGV_Suf.MinimumWidth = 6
        Stud_DGV_Suf.Name = "Stud_DGV_Suf"
        Stud_DGV_Suf.Width = 135
        ' 
        ' Stud_DGV_Course
        ' 
        Stud_DGV_Course.HeaderText = "COURSE"
        Stud_DGV_Course.MinimumWidth = 6
        Stud_DGV_Course.Name = "Stud_DGV_Course"
        Stud_DGV_Course.Width = 135
        ' 
        ' Stud_DGV_Sem
        ' 
        Stud_DGV_Sem.HeaderText = "SEMESTER"
        Stud_DGV_Sem.MinimumWidth = 6
        Stud_DGV_Sem.Name = "Stud_DGV_Sem"
        Stud_DGV_Sem.Width = 135
        ' 
        ' Stud_DGV_Sec
        ' 
        Stud_DGV_Sec.HeaderText = "SECTION"
        Stud_DGV_Sec.MinimumWidth = 6
        Stud_DGV_Sec.Name = "Stud_DGV_Sec"
        Stud_DGV_Sec.Width = 135
        ' 
        ' Stud_DGV_Email
        ' 
        Stud_DGV_Email.HeaderText = "EMAIL"
        Stud_DGV_Email.MinimumWidth = 6
        Stud_DGV_Email.Name = "Stud_DGV_Email"
        Stud_DGV_Email.Width = 135
        ' 
        ' Stud_DGV_Con
        ' 
        Stud_DGV_Con.HeaderText = "CONTACT NO."
        Stud_DGV_Con.MinimumWidth = 6
        Stud_DGV_Con.Name = "Stud_DGV_Con"
        Stud_DGV_Con.Width = 135
        ' 
        ' STUD_Lbl
        ' 
        STUD_Lbl.Font = New Font("Times New Roman", 54F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        STUD_Lbl.Location = New Point(96, 22)
        STUD_Lbl.Name = "STUD_Lbl"
        STUD_Lbl.Size = New Size(608, 105)
        STUD_Lbl.TabIndex = 4
        STUD_Lbl.Text = "STUDENTS"
        ' 
        ' Adm_Func_StudDateTime_lbl
        ' 
        Adm_Func_StudDateTime_lbl.Font = New Font("Rockwell", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Func_StudDateTime_lbl.Location = New Point(735, 32)
        Adm_Func_StudDateTime_lbl.Name = "Adm_Func_StudDateTime_lbl"
        Adm_Func_StudDateTime_lbl.Size = New Size(695, 49)
        Adm_Func_StudDateTime_lbl.TabIndex = 3
        ' 
        ' ADM_FACPAN
        ' 
        ADM_FACPAN.BackColor = Color.WhiteSmoke
        ADM_FACPAN.Controls.Add(Fac_PosTB)
        ADM_FACPAN.Controls.Add(FAC_ClrBtn)
        ADM_FACPAN.Controls.Add(FAC_AddBtn)
        ADM_FACPAN.Controls.Add(Fac_EmpCmb)
        ADM_FACPAN.Controls.Add(Fac_EmpLbl)
        ADM_FACPAN.Controls.Add(Fac_ConLbl)
        ADM_FACPAN.Controls.Add(Fac_ConMTB)
        ADM_FACPAN.Controls.Add(Fac_DeptCmb)
        ADM_FACPAN.Controls.Add(Fac_PosLbl)
        ADM_FACPAN.Controls.Add(Fac_SufTB)
        ADM_FACPAN.Controls.Add(Fac_MidTB)
        ADM_FACPAN.Controls.Add(Fac_SufLbl)
        ADM_FACPAN.Controls.Add(Fac_MidLbl)
        ADM_FACPAN.Controls.Add(Fac_EmailTB)
        ADM_FACPAN.Controls.Add(Fac_FirstNTB)
        ADM_FACPAN.Controls.Add(Fac_LastNTB)
        ADM_FACPAN.Controls.Add(Fac_EmailLbl)
        ADM_FACPAN.Controls.Add(Fac_DeptLbl)
        ADM_FACPAN.Controls.Add(Fac_FirstNLbl)
        ADM_FACPAN.Controls.Add(Fac_LastNLbl)
        ADM_FACPAN.Controls.Add(Fac_FIDLbl)
        ADM_FACPAN.Controls.Add(Fac_FID_MTB)
        ADM_FACPAN.Controls.Add(FAC_DelBtn)
        ADM_FACPAN.Controls.Add(FAC_EdBtn)
        ADM_FACPAN.Controls.Add(Fac_BotPnl)
        ADM_FACPAN.Controls.Add(Fac_TopPnl)
        ADM_FACPAN.Controls.Add(Fac_NewEntLbl)
        ADM_FACPAN.Controls.Add(FAC_DGV)
        ADM_FACPAN.Controls.Add(Fac_SidePnl)
        ADM_FACPAN.Controls.Add(FAC_Lbl)
        ADM_FACPAN.Controls.Add(Adm_func_FacDateTime_lbl)
        ADM_FACPAN.Location = New Point(17, 25)
        ADM_FACPAN.Name = "ADM_FACPAN"
        ADM_FACPAN.Size = New Size(1515, 793)
        ADM_FACPAN.TabIndex = 2
        ' 
        ' Fac_PosTB
        ' 
        Fac_PosTB.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Fac_PosTB.Location = New Point(1266, 590)
        Fac_PosTB.Name = "Fac_PosTB"
        Fac_PosTB.Size = New Size(189, 39)
        Fac_PosTB.TabIndex = 72
        ' 
        ' FAC_ClrBtn
        ' 
        FAC_ClrBtn.BackColor = Color.Orange
        FAC_ClrBtn.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FAC_ClrBtn.ForeColor = SystemColors.ButtonHighlight
        FAC_ClrBtn.Location = New Point(1303, 725)
        FAC_ClrBtn.Name = "FAC_ClrBtn"
        FAC_ClrBtn.Size = New Size(151, 60)
        FAC_ClrBtn.TabIndex = 71
        FAC_ClrBtn.Text = "CLEAR"
        FAC_ClrBtn.UseVisualStyleBackColor = False
        ' 
        ' FAC_AddBtn
        ' 
        FAC_AddBtn.BackColor = Color.ForestGreen
        FAC_AddBtn.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FAC_AddBtn.ForeColor = SystemColors.ButtonHighlight
        FAC_AddBtn.Location = New Point(1137, 725)
        FAC_AddBtn.Name = "FAC_AddBtn"
        FAC_AddBtn.Size = New Size(151, 60)
        FAC_AddBtn.TabIndex = 70
        FAC_AddBtn.Text = "ADD"
        FAC_AddBtn.UseVisualStyleBackColor = False
        ' 
        ' Fac_EmpCmb
        ' 
        Fac_EmpCmb.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Fac_EmpCmb.FormattingEnabled = True
        Fac_EmpCmb.Location = New Point(62, 680)
        Fac_EmpCmb.Name = "Fac_EmpCmb"
        Fac_EmpCmb.Size = New Size(186, 40)
        Fac_EmpCmb.TabIndex = 69
        ' 
        ' Fac_EmpLbl
        ' 
        Fac_EmpLbl.AutoSize = True
        Fac_EmpLbl.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Fac_EmpLbl.Location = New Point(63, 652)
        Fac_EmpLbl.Name = "Fac_EmpLbl"
        Fac_EmpLbl.Size = New Size(156, 27)
        Fac_EmpLbl.TabIndex = 68
        Fac_EmpLbl.Text = "Employment:"
        Fac_EmpLbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Fac_ConLbl
        ' 
        Fac_ConLbl.AutoSize = True
        Fac_ConLbl.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Fac_ConLbl.Location = New Point(962, 653)
        Fac_ConLbl.Name = "Fac_ConLbl"
        Fac_ConLbl.Size = New Size(145, 27)
        Fac_ConLbl.TabIndex = 67
        Fac_ConLbl.Text = "Contact No."
        Fac_ConLbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Fac_ConMTB
        ' 
        Fac_ConMTB.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Fac_ConMTB.Location = New Point(962, 682)
        Fac_ConMTB.Name = "Fac_ConMTB"
        Fac_ConMTB.Size = New Size(355, 39)
        Fac_ConMTB.TabIndex = 66
        ' 
        ' Fac_DeptCmb
        ' 
        Fac_DeptCmb.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Fac_DeptCmb.FormattingEnabled = True
        Fac_DeptCmb.Location = New Point(273, 680)
        Fac_DeptCmb.Name = "Fac_DeptCmb"
        Fac_DeptCmb.Size = New Size(186, 40)
        Fac_DeptCmb.TabIndex = 65
        ' 
        ' Fac_PosLbl
        ' 
        Fac_PosLbl.AutoSize = True
        Fac_PosLbl.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Fac_PosLbl.Location = New Point(1267, 563)
        Fac_PosLbl.Name = "Fac_PosLbl"
        Fac_PosLbl.Size = New Size(108, 27)
        Fac_PosLbl.TabIndex = 62
        Fac_PosLbl.Text = "Position:"
        Fac_PosLbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Fac_SufTB
        ' 
        Fac_SufTB.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Fac_SufTB.Location = New Point(1129, 590)
        Fac_SufTB.Name = "Fac_SufTB"
        Fac_SufTB.Size = New Size(114, 39)
        Fac_SufTB.TabIndex = 61
        ' 
        ' Fac_MidTB
        ' 
        Fac_MidTB.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Fac_MidTB.Location = New Point(865, 590)
        Fac_MidTB.Name = "Fac_MidTB"
        Fac_MidTB.Size = New Size(240, 39)
        Fac_MidTB.TabIndex = 60
        ' 
        ' Fac_SufLbl
        ' 
        Fac_SufLbl.AutoSize = True
        Fac_SufLbl.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Fac_SufLbl.Location = New Point(1129, 561)
        Fac_SufLbl.Name = "Fac_SufLbl"
        Fac_SufLbl.Size = New Size(82, 27)
        Fac_SufLbl.TabIndex = 59
        Fac_SufLbl.Text = "Suffix:"
        Fac_SufLbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Fac_MidLbl
        ' 
        Fac_MidLbl.AutoSize = True
        Fac_MidLbl.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Fac_MidLbl.Location = New Point(865, 561)
        Fac_MidLbl.Name = "Fac_MidLbl"
        Fac_MidLbl.Size = New Size(163, 27)
        Fac_MidLbl.TabIndex = 58
        Fac_MidLbl.Text = "Middle Name:"
        Fac_MidLbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Fac_EmailTB
        ' 
        Fac_EmailTB.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Fac_EmailTB.Location = New Point(485, 681)
        Fac_EmailTB.Name = "Fac_EmailTB"
        Fac_EmailTB.Size = New Size(453, 39)
        Fac_EmailTB.TabIndex = 55
        ' 
        ' Fac_FirstNTB
        ' 
        Fac_FirstNTB.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Fac_FirstNTB.Location = New Point(485, 590)
        Fac_FirstNTB.Name = "Fac_FirstNTB"
        Fac_FirstNTB.Size = New Size(357, 39)
        Fac_FirstNTB.TabIndex = 54
        ' 
        ' Fac_LastNTB
        ' 
        Fac_LastNTB.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Fac_LastNTB.Location = New Point(273, 590)
        Fac_LastNTB.Name = "Fac_LastNTB"
        Fac_LastNTB.Size = New Size(186, 39)
        Fac_LastNTB.TabIndex = 53
        ' 
        ' Fac_EmailLbl
        ' 
        Fac_EmailLbl.AutoSize = True
        Fac_EmailLbl.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Fac_EmailLbl.Location = New Point(485, 653)
        Fac_EmailLbl.Name = "Fac_EmailLbl"
        Fac_EmailLbl.Size = New Size(179, 27)
        Fac_EmailLbl.TabIndex = 52
        Fac_EmailLbl.Text = "Email Address:"
        Fac_EmailLbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Fac_DeptLbl
        ' 
        Fac_DeptLbl.AutoSize = True
        Fac_DeptLbl.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Fac_DeptLbl.Location = New Point(273, 653)
        Fac_DeptLbl.Name = "Fac_DeptLbl"
        Fac_DeptLbl.Size = New Size(152, 27)
        Fac_DeptLbl.TabIndex = 51
        Fac_DeptLbl.Text = "Department:"
        Fac_DeptLbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Fac_FirstNLbl
        ' 
        Fac_FirstNLbl.AutoSize = True
        Fac_FirstNLbl.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Fac_FirstNLbl.Location = New Point(485, 561)
        Fac_FirstNLbl.Name = "Fac_FirstNLbl"
        Fac_FirstNLbl.Size = New Size(140, 27)
        Fac_FirstNLbl.TabIndex = 50
        Fac_FirstNLbl.Text = "First Name:"
        Fac_FirstNLbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Fac_LastNLbl
        ' 
        Fac_LastNLbl.AutoSize = True
        Fac_LastNLbl.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Fac_LastNLbl.Location = New Point(273, 561)
        Fac_LastNLbl.Name = "Fac_LastNLbl"
        Fac_LastNLbl.Size = New Size(138, 27)
        Fac_LastNLbl.TabIndex = 49
        Fac_LastNLbl.Text = "Last Name:"
        Fac_LastNLbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Fac_FIDLbl
        ' 
        Fac_FIDLbl.AutoSize = True
        Fac_FIDLbl.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Fac_FIDLbl.Location = New Point(62, 561)
        Fac_FIDLbl.Name = "Fac_FIDLbl"
        Fac_FIDLbl.Size = New Size(131, 27)
        Fac_FIDLbl.TabIndex = 47
        Fac_FIDLbl.Text = "Faculty ID:"
        Fac_FIDLbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Fac_FID_MTB
        ' 
        Fac_FID_MTB.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Fac_FID_MTB.Location = New Point(62, 590)
        Fac_FID_MTB.Name = "Fac_FID_MTB"
        Fac_FID_MTB.Size = New Size(186, 39)
        Fac_FID_MTB.TabIndex = 46
        ' 
        ' FAC_DelBtn
        ' 
        FAC_DelBtn.BackColor = Color.DarkRed
        FAC_DelBtn.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FAC_DelBtn.ForeColor = SystemColors.ButtonHighlight
        FAC_DelBtn.Location = New Point(1303, 464)
        FAC_DelBtn.Name = "FAC_DelBtn"
        FAC_DelBtn.Size = New Size(151, 60)
        FAC_DelBtn.TabIndex = 15
        FAC_DelBtn.Text = "DELETE"
        FAC_DelBtn.UseVisualStyleBackColor = False
        ' 
        ' FAC_EdBtn
        ' 
        FAC_EdBtn.BackColor = Color.Navy
        FAC_EdBtn.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FAC_EdBtn.ForeColor = SystemColors.ButtonHighlight
        FAC_EdBtn.Location = New Point(1137, 464)
        FAC_EdBtn.Name = "FAC_EdBtn"
        FAC_EdBtn.Size = New Size(151, 60)
        FAC_EdBtn.TabIndex = 14
        FAC_EdBtn.Text = "EDIT"
        FAC_EdBtn.UseVisualStyleBackColor = False
        ' 
        ' Fac_BotPnl
        ' 
        Fac_BotPnl.BackColor = Color.Black
        Fac_BotPnl.Location = New Point(51, 526)
        Fac_BotPnl.Name = "Fac_BotPnl"
        Fac_BotPnl.Size = New Size(1054, 10)
        Fac_BotPnl.TabIndex = 13
        ' 
        ' Fac_TopPnl
        ' 
        Fac_TopPnl.BackColor = Color.Black
        Fac_TopPnl.Location = New Point(51, 450)
        Fac_TopPnl.Name = "Fac_TopPnl"
        Fac_TopPnl.Size = New Size(1054, 10)
        Fac_TopPnl.TabIndex = 12
        ' 
        ' Fac_NewEntLbl
        ' 
        Fac_NewEntLbl.AutoSize = True
        Fac_NewEntLbl.Font = New Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Fac_NewEntLbl.Location = New Point(482, 473)
        Fac_NewEntLbl.Name = "Fac_NewEntLbl"
        Fac_NewEntLbl.Size = New Size(222, 39)
        Fac_NewEntLbl.TabIndex = 11
        Fac_NewEntLbl.Text = "NEW ENTRY"
        ' 
        ' FAC_DGV
        ' 
        FAC_DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        FAC_DGV.Columns.AddRange(New DataGridViewColumn() {Fac_DGV_FID, Fac_DGV_LastN, Fac_DGV_FirstN, Fac_DGV_MidN, Fac_DGV_Suf, Fac_DGV_Dept, Fac_DGV_Pos, Fac_DGV_Emp, Fac_DGV_Email, Fac_DGV_Con})
        FAC_DGV.Location = New Point(51, 182)
        FAC_DGV.Name = "FAC_DGV"
        FAC_DGV.RowHeadersWidth = 51
        FAC_DGV.Size = New Size(1403, 252)
        FAC_DGV.TabIndex = 9
        ' 
        ' Fac_DGV_FID
        ' 
        Fac_DGV_FID.HeaderText = "FACULTY ID"
        Fac_DGV_FID.MinimumWidth = 6
        Fac_DGV_FID.Name = "Fac_DGV_FID"
        Fac_DGV_FID.Width = 135
        ' 
        ' Fac_DGV_LastN
        ' 
        Fac_DGV_LastN.HeaderText = "LAST NAME"
        Fac_DGV_LastN.MinimumWidth = 6
        Fac_DGV_LastN.Name = "Fac_DGV_LastN"
        Fac_DGV_LastN.Width = 135
        ' 
        ' Fac_DGV_FirstN
        ' 
        Fac_DGV_FirstN.HeaderText = "FIRST NAME"
        Fac_DGV_FirstN.MinimumWidth = 6
        Fac_DGV_FirstN.Name = "Fac_DGV_FirstN"
        Fac_DGV_FirstN.Width = 135
        ' 
        ' Fac_DGV_MidN
        ' 
        Fac_DGV_MidN.HeaderText = "MIDDLE NAME"
        Fac_DGV_MidN.MinimumWidth = 6
        Fac_DGV_MidN.Name = "Fac_DGV_MidN"
        Fac_DGV_MidN.Width = 135
        ' 
        ' Fac_DGV_Suf
        ' 
        Fac_DGV_Suf.HeaderText = "SUFFIX"
        Fac_DGV_Suf.MinimumWidth = 6
        Fac_DGV_Suf.Name = "Fac_DGV_Suf"
        Fac_DGV_Suf.Width = 135
        ' 
        ' Fac_DGV_Dept
        ' 
        Fac_DGV_Dept.HeaderText = "DEPARTMENT"
        Fac_DGV_Dept.MinimumWidth = 6
        Fac_DGV_Dept.Name = "Fac_DGV_Dept"
        Fac_DGV_Dept.Width = 135
        ' 
        ' Fac_DGV_Pos
        ' 
        Fac_DGV_Pos.HeaderText = "POSITION"
        Fac_DGV_Pos.MinimumWidth = 6
        Fac_DGV_Pos.Name = "Fac_DGV_Pos"
        Fac_DGV_Pos.Width = 135
        ' 
        ' Fac_DGV_Emp
        ' 
        Fac_DGV_Emp.HeaderText = "EMPLOYMENT"
        Fac_DGV_Emp.MinimumWidth = 6
        Fac_DGV_Emp.Name = "Fac_DGV_Emp"
        Fac_DGV_Emp.Width = 135
        ' 
        ' Fac_DGV_Email
        ' 
        Fac_DGV_Email.HeaderText = "EMAIL"
        Fac_DGV_Email.MinimumWidth = 6
        Fac_DGV_Email.Name = "Fac_DGV_Email"
        Fac_DGV_Email.Width = 135
        ' 
        ' Fac_DGV_Con
        ' 
        Fac_DGV_Con.HeaderText = "CONTACT NO."
        Fac_DGV_Con.MinimumWidth = 6
        Fac_DGV_Con.Name = "Fac_DGV_Con"
        Fac_DGV_Con.Width = 135
        ' 
        ' Fac_SidePnl
        ' 
        Fac_SidePnl.BackColor = Color.Navy
        Fac_SidePnl.Location = New Point(51, 41)
        Fac_SidePnl.Name = "Fac_SidePnl"
        Fac_SidePnl.Size = New Size(39, 72)
        Fac_SidePnl.TabIndex = 8
        ' 
        ' FAC_Lbl
        ' 
        FAC_Lbl.Font = New Font("Times New Roman", 54F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FAC_Lbl.Location = New Point(96, 22)
        FAC_Lbl.Name = "FAC_Lbl"
        FAC_Lbl.Size = New Size(608, 105)
        FAC_Lbl.TabIndex = 6
        FAC_Lbl.Text = "FACULTY"
        ' 
        ' Adm_func_FacDateTime_lbl
        ' 
        Adm_func_FacDateTime_lbl.Font = New Font("Rockwell", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_func_FacDateTime_lbl.Location = New Point(735, 32)
        Adm_func_FacDateTime_lbl.Name = "Adm_func_FacDateTime_lbl"
        Adm_func_FacDateTime_lbl.Size = New Size(695, 49)
        Adm_func_FacDateTime_lbl.TabIndex = 3
        ' 
        ' ADM_INTERPAN
        ' 
        ADM_INTERPAN.BackColor = Color.WhiteSmoke
        ADM_INTERPAN.Controls.Add(Adm_Intern_Stud_ID)
        ADM_INTERPAN.Controls.Add(Adm_Intern_SY_Mtx)
        ADM_INTERPAN.Controls.Add(Adm_Intern_Intern_lbl)
        ADM_INTERPAN.Controls.Add(Adm_Intern_Del_btn)
        ADM_INTERPAN.Controls.Add(Adm_Intern_Edit_btn)
        ADM_INTERPAN.Controls.Add(Adm_Intern_AddEval_txt)
        ADM_INTERPAN.Controls.Add(Adm_Intern_Eval_lbl)
        ADM_INTERPAN.Controls.Add(Adm_Intern_AddSup_txt)
        ADM_INTERPAN.Controls.Add(Adm_Intern_Sup_lbl)
        ADM_INTERPAN.Controls.Add(Adm_Intern_AddStat_cmb)
        ADM_INTERPAN.Controls.Add(Adm_Intern_Stat_lbl)
        ADM_INTERPAN.Controls.Add(Adm_Intern_AddGrade_txt)
        ADM_INTERPAN.Controls.Add(Adm_Intern_Grade_lbl)
        ADM_INTERPAN.Controls.Add(Adm_Intern_End_dtp)
        ADM_INTERPAN.Controls.Add(Adm_Intern_End_lbl)
        ADM_INTERPAN.Controls.Add(Adm_Intern_Start_dtp)
        ADM_INTERPAN.Controls.Add(Adm_Intern_AddFac_cmb)
        ADM_INTERPAN.Controls.Add(Adm_Intern_FacID_lbl)
        ADM_INTERPAN.Controls.Add(Adm_Intern_SupID_cmb)
        ADM_INTERPAN.Controls.Add(Adm_Intern_SupID_lbl)
        ADM_INTERPAN.Controls.Add(Adm_Intern_AddCompName_txt)
        ADM_INTERPAN.Controls.Add(Adm_Intern_CompName_lbl)
        ADM_INTERPAN.Controls.Add(Adm_Intern_AddCompID_cmb)
        ADM_INTERPAN.Controls.Add(Adm_Intern_CompID_lbl)
        ADM_INTERPAN.Controls.Add(Adm_Intern_AddStudID_Mtxt)
        ADM_INTERPAN.Controls.Add(Adm_Intern_AddStudName_txt)
        ADM_INTERPAN.Controls.Add(Adm_Intern_StudName_lbl)
        ADM_INTERPAN.Controls.Add(Adm_Intern_SDate_lbl)
        ADM_INTERPAN.Controls.Add(Adm_Intern_InternID_lbl)
        ADM_INTERPAN.Controls.Add(Adm_Intern_AddInternID_Mtxt)
        ADM_INTERPAN.Controls.Add(Adm_Intern_Clear_btn)
        ADM_INTERPAN.Controls.Add(Adm_Intern_Add_btn)
        ADM_INTERPAN.Controls.Add(Adm_Intern_Bpan1)
        ADM_INTERPAN.Controls.Add(Adm_Intern_Bpan2)
        ADM_INTERPAN.Controls.Add(Adm_Intern_newEntry_lbl)
        ADM_INTERPAN.Controls.Add(Adm_Intern_DGV)
        ADM_INTERPAN.Controls.Add(Adm_Intern_design)
        ADM_INTERPAN.Controls.Add(Adm_InternTitle_lbl)
        ADM_INTERPAN.Controls.Add(Adm_Intern_DateTime_lbl)
        ADM_INTERPAN.Location = New Point(17, 25)
        ADM_INTERPAN.Name = "ADM_INTERPAN"
        ADM_INTERPAN.Size = New Size(1515, 793)
        ADM_INTERPAN.TabIndex = 7
        ' 
        ' Adm_Intern_Stud_ID
        ' 
        Adm_Intern_Stud_ID.AutoSize = True
        Adm_Intern_Stud_ID.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Intern_Stud_ID.Location = New Point(62, 640)
        Adm_Intern_Stud_ID.Name = "Adm_Intern_Stud_ID"
        Adm_Intern_Stud_ID.Size = New Size(136, 27)
        Adm_Intern_Stud_ID.TabIndex = 87
        Adm_Intern_Stud_ID.Text = "Student ID:"
        Adm_Intern_Stud_ID.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Adm_Intern_SY_Mtx
        ' 
        Adm_Intern_SY_Mtx.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Intern_SY_Mtx.Location = New Point(273, 590)
        Adm_Intern_SY_Mtx.Mask = "0000-0000"
        Adm_Intern_SY_Mtx.Name = "Adm_Intern_SY_Mtx"
        Adm_Intern_SY_Mtx.Size = New Size(195, 39)
        Adm_Intern_SY_Mtx.TabIndex = 85
        ' 
        ' Adm_Intern_Intern_lbl
        ' 
        Adm_Intern_Intern_lbl.AutoSize = True
        Adm_Intern_Intern_lbl.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Intern_Intern_lbl.Location = New Point(273, 562)
        Adm_Intern_Intern_lbl.Name = "Adm_Intern_Intern_lbl"
        Adm_Intern_Intern_lbl.Size = New Size(154, 27)
        Adm_Intern_Intern_lbl.TabIndex = 83
        Adm_Intern_Intern_lbl.Text = "School Year:"
        Adm_Intern_Intern_lbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Adm_Intern_Del_btn
        ' 
        Adm_Intern_Del_btn.BackColor = Color.DarkRed
        Adm_Intern_Del_btn.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Intern_Del_btn.ForeColor = SystemColors.ButtonHighlight
        Adm_Intern_Del_btn.Location = New Point(1303, 608)
        Adm_Intern_Del_btn.Name = "Adm_Intern_Del_btn"
        Adm_Intern_Del_btn.Size = New Size(151, 50)
        Adm_Intern_Del_btn.TabIndex = 82
        Adm_Intern_Del_btn.Text = "DELETE"
        Adm_Intern_Del_btn.UseVisualStyleBackColor = False
        ' 
        ' Adm_Intern_Edit_btn
        ' 
        Adm_Intern_Edit_btn.BackColor = Color.Navy
        Adm_Intern_Edit_btn.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Intern_Edit_btn.ForeColor = SystemColors.ButtonHighlight
        Adm_Intern_Edit_btn.Location = New Point(1137, 608)
        Adm_Intern_Edit_btn.Name = "Adm_Intern_Edit_btn"
        Adm_Intern_Edit_btn.Size = New Size(151, 50)
        Adm_Intern_Edit_btn.TabIndex = 81
        Adm_Intern_Edit_btn.Text = "EDIT"
        Adm_Intern_Edit_btn.UseVisualStyleBackColor = False
        ' 
        ' Adm_Intern_AddEval_txt
        ' 
        Adm_Intern_AddEval_txt.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Intern_AddEval_txt.Location = New Point(981, 748)
        Adm_Intern_AddEval_txt.Name = "Adm_Intern_AddEval_txt"
        Adm_Intern_AddEval_txt.Size = New Size(473, 39)
        Adm_Intern_AddEval_txt.TabIndex = 80
        ' 
        ' Adm_Intern_Eval_lbl
        ' 
        Adm_Intern_Eval_lbl.AutoSize = True
        Adm_Intern_Eval_lbl.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Intern_Eval_lbl.Location = New Point(981, 720)
        Adm_Intern_Eval_lbl.Name = "Adm_Intern_Eval_lbl"
        Adm_Intern_Eval_lbl.Size = New Size(126, 27)
        Adm_Intern_Eval_lbl.TabIndex = 79
        Adm_Intern_Eval_lbl.Text = "Evaluator:"
        Adm_Intern_Eval_lbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Adm_Intern_AddSup_txt
        ' 
        Adm_Intern_AddSup_txt.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Intern_AddSup_txt.Location = New Point(981, 671)
        Adm_Intern_AddSup_txt.Name = "Adm_Intern_AddSup_txt"
        Adm_Intern_AddSup_txt.Size = New Size(473, 39)
        Adm_Intern_AddSup_txt.TabIndex = 78
        ' 
        ' Adm_Intern_Sup_lbl
        ' 
        Adm_Intern_Sup_lbl.AutoSize = True
        Adm_Intern_Sup_lbl.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Intern_Sup_lbl.Location = New Point(981, 643)
        Adm_Intern_Sup_lbl.Name = "Adm_Intern_Sup_lbl"
        Adm_Intern_Sup_lbl.Size = New Size(140, 27)
        Adm_Intern_Sup_lbl.TabIndex = 77
        Adm_Intern_Sup_lbl.Text = "Supervisor:"
        Adm_Intern_Sup_lbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Adm_Intern_AddStat_cmb
        ' 
        Adm_Intern_AddStat_cmb.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Intern_AddStat_cmb.FormattingEnabled = True
        Adm_Intern_AddStat_cmb.Location = New Point(797, 589)
        Adm_Intern_AddStat_cmb.Name = "Adm_Intern_AddStat_cmb"
        Adm_Intern_AddStat_cmb.Size = New Size(186, 40)
        Adm_Intern_AddStat_cmb.TabIndex = 76
        ' 
        ' Adm_Intern_Stat_lbl
        ' 
        Adm_Intern_Stat_lbl.AutoSize = True
        Adm_Intern_Stat_lbl.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Intern_Stat_lbl.Location = New Point(797, 560)
        Adm_Intern_Stat_lbl.Name = "Adm_Intern_Stat_lbl"
        Adm_Intern_Stat_lbl.Size = New Size(90, 27)
        Adm_Intern_Stat_lbl.TabIndex = 75
        Adm_Intern_Stat_lbl.Text = "Status:"
        Adm_Intern_Stat_lbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Adm_Intern_AddGrade_txt
        ' 
        Adm_Intern_AddGrade_txt.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Intern_AddGrade_txt.Location = New Point(1006, 589)
        Adm_Intern_AddGrade_txt.Name = "Adm_Intern_AddGrade_txt"
        Adm_Intern_AddGrade_txt.Size = New Size(101, 39)
        Adm_Intern_AddGrade_txt.TabIndex = 74
        ' 
        ' Adm_Intern_Grade_lbl
        ' 
        Adm_Intern_Grade_lbl.AutoSize = True
        Adm_Intern_Grade_lbl.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Intern_Grade_lbl.Location = New Point(1006, 561)
        Adm_Intern_Grade_lbl.Name = "Adm_Intern_Grade_lbl"
        Adm_Intern_Grade_lbl.Size = New Size(89, 27)
        Adm_Intern_Grade_lbl.TabIndex = 73
        Adm_Intern_Grade_lbl.Text = "Grade:"
        Adm_Intern_Grade_lbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Adm_Intern_End_dtp
        ' 
        Adm_Intern_End_dtp.CalendarFont = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Intern_End_dtp.Font = New Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Intern_End_dtp.Format = DateTimePickerFormat.Short
        Adm_Intern_End_dtp.Location = New Point(642, 595)
        Adm_Intern_End_dtp.Name = "Adm_Intern_End_dtp"
        Adm_Intern_End_dtp.Size = New Size(133, 28)
        Adm_Intern_End_dtp.TabIndex = 72
        ' 
        ' Adm_Intern_End_lbl
        ' 
        Adm_Intern_End_lbl.AutoSize = True
        Adm_Intern_End_lbl.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Intern_End_lbl.Location = New Point(642, 561)
        Adm_Intern_End_lbl.Name = "Adm_Intern_End_lbl"
        Adm_Intern_End_lbl.Size = New Size(121, 27)
        Adm_Intern_End_lbl.TabIndex = 71
        Adm_Intern_End_lbl.Text = "End Date:"
        Adm_Intern_End_lbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Adm_Intern_Start_dtp
        ' 
        Adm_Intern_Start_dtp.CalendarFont = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Intern_Start_dtp.Font = New Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Intern_Start_dtp.Format = DateTimePickerFormat.Short
        Adm_Intern_Start_dtp.Location = New Point(489, 594)
        Adm_Intern_Start_dtp.Name = "Adm_Intern_Start_dtp"
        Adm_Intern_Start_dtp.Size = New Size(133, 28)
        Adm_Intern_Start_dtp.TabIndex = 70
        ' 
        ' Adm_Intern_AddFac_cmb
        ' 
        Adm_Intern_AddFac_cmb.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Intern_AddFac_cmb.FormattingEnabled = True
        Adm_Intern_AddFac_cmb.Location = New Point(770, 746)
        Adm_Intern_AddFac_cmb.Name = "Adm_Intern_AddFac_cmb"
        Adm_Intern_AddFac_cmb.Size = New Size(186, 40)
        Adm_Intern_AddFac_cmb.TabIndex = 65
        ' 
        ' Adm_Intern_FacID_lbl
        ' 
        Adm_Intern_FacID_lbl.AutoSize = True
        Adm_Intern_FacID_lbl.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Intern_FacID_lbl.Location = New Point(770, 717)
        Adm_Intern_FacID_lbl.Name = "Adm_Intern_FacID_lbl"
        Adm_Intern_FacID_lbl.Size = New Size(131, 27)
        Adm_Intern_FacID_lbl.TabIndex = 64
        Adm_Intern_FacID_lbl.Text = "Faculty ID:"
        Adm_Intern_FacID_lbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Adm_Intern_SupID_cmb
        ' 
        Adm_Intern_SupID_cmb.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Intern_SupID_cmb.FormattingEnabled = True
        Adm_Intern_SupID_cmb.Location = New Point(770, 669)
        Adm_Intern_SupID_cmb.Name = "Adm_Intern_SupID_cmb"
        Adm_Intern_SupID_cmb.Size = New Size(186, 40)
        Adm_Intern_SupID_cmb.TabIndex = 63
        ' 
        ' Adm_Intern_SupID_lbl
        ' 
        Adm_Intern_SupID_lbl.AutoSize = True
        Adm_Intern_SupID_lbl.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Intern_SupID_lbl.Location = New Point(770, 640)
        Adm_Intern_SupID_lbl.Name = "Adm_Intern_SupID_lbl"
        Adm_Intern_SupID_lbl.Size = New Size(170, 27)
        Adm_Intern_SupID_lbl.TabIndex = 62
        Adm_Intern_SupID_lbl.Text = "Supervisor ID:"
        Adm_Intern_SupID_lbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Adm_Intern_AddCompName_txt
        ' 
        Adm_Intern_AddCompName_txt.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Intern_AddCompName_txt.Location = New Point(273, 746)
        Adm_Intern_AddCompName_txt.Name = "Adm_Intern_AddCompName_txt"
        Adm_Intern_AddCompName_txt.Size = New Size(473, 39)
        Adm_Intern_AddCompName_txt.TabIndex = 61
        ' 
        ' Adm_Intern_CompName_lbl
        ' 
        Adm_Intern_CompName_lbl.AutoSize = True
        Adm_Intern_CompName_lbl.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Intern_CompName_lbl.Location = New Point(273, 718)
        Adm_Intern_CompName_lbl.Name = "Adm_Intern_CompName_lbl"
        Adm_Intern_CompName_lbl.Size = New Size(195, 27)
        Adm_Intern_CompName_lbl.TabIndex = 60
        Adm_Intern_CompName_lbl.Text = "Company Name:"
        Adm_Intern_CompName_lbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Adm_Intern_AddCompID_cmb
        ' 
        Adm_Intern_AddCompID_cmb.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Intern_AddCompID_cmb.FormattingEnabled = True
        Adm_Intern_AddCompID_cmb.Location = New Point(62, 747)
        Adm_Intern_AddCompID_cmb.Name = "Adm_Intern_AddCompID_cmb"
        Adm_Intern_AddCompID_cmb.Size = New Size(186, 40)
        Adm_Intern_AddCompID_cmb.TabIndex = 59
        ' 
        ' Adm_Intern_CompID_lbl
        ' 
        Adm_Intern_CompID_lbl.AutoSize = True
        Adm_Intern_CompID_lbl.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Intern_CompID_lbl.Location = New Point(62, 718)
        Adm_Intern_CompID_lbl.Name = "Adm_Intern_CompID_lbl"
        Adm_Intern_CompID_lbl.Size = New Size(154, 27)
        Adm_Intern_CompID_lbl.TabIndex = 58
        Adm_Intern_CompID_lbl.Text = "Company ID:"
        Adm_Intern_CompID_lbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Adm_Intern_AddStudID_Mtxt
        ' 
        Adm_Intern_AddStudID_Mtxt.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Intern_AddStudID_Mtxt.Location = New Point(62, 670)
        Adm_Intern_AddStudID_Mtxt.Mask = "00-0000"
        Adm_Intern_AddStudID_Mtxt.Name = "Adm_Intern_AddStudID_Mtxt"
        Adm_Intern_AddStudID_Mtxt.Size = New Size(186, 39)
        Adm_Intern_AddStudID_Mtxt.TabIndex = 86
        ' 
        ' Adm_Intern_AddStudName_txt
        ' 
        Adm_Intern_AddStudName_txt.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Intern_AddStudName_txt.Location = New Point(273, 669)
        Adm_Intern_AddStudName_txt.Name = "Adm_Intern_AddStudName_txt"
        Adm_Intern_AddStudName_txt.Size = New Size(473, 39)
        Adm_Intern_AddStudName_txt.TabIndex = 53
        ' 
        ' Adm_Intern_StudName_lbl
        ' 
        Adm_Intern_StudName_lbl.AutoSize = True
        Adm_Intern_StudName_lbl.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Intern_StudName_lbl.Location = New Point(273, 641)
        Adm_Intern_StudName_lbl.Name = "Adm_Intern_StudName_lbl"
        Adm_Intern_StudName_lbl.Size = New Size(177, 27)
        Adm_Intern_StudName_lbl.TabIndex = 51
        Adm_Intern_StudName_lbl.Text = "Student Name:"
        Adm_Intern_StudName_lbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Adm_Intern_SDate_lbl
        ' 
        Adm_Intern_SDate_lbl.AutoSize = True
        Adm_Intern_SDate_lbl.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Intern_SDate_lbl.Location = New Point(489, 560)
        Adm_Intern_SDate_lbl.Name = "Adm_Intern_SDate_lbl"
        Adm_Intern_SDate_lbl.Size = New Size(133, 27)
        Adm_Intern_SDate_lbl.TabIndex = 49
        Adm_Intern_SDate_lbl.Text = "Start Date:"
        Adm_Intern_SDate_lbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Adm_Intern_InternID_lbl
        ' 
        Adm_Intern_InternID_lbl.AutoSize = True
        Adm_Intern_InternID_lbl.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Intern_InternID_lbl.Location = New Point(62, 561)
        Adm_Intern_InternID_lbl.Name = "Adm_Intern_InternID_lbl"
        Adm_Intern_InternID_lbl.Size = New Size(162, 27)
        Adm_Intern_InternID_lbl.TabIndex = 47
        Adm_Intern_InternID_lbl.Text = "Internship ID:"
        Adm_Intern_InternID_lbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Adm_Intern_AddInternID_Mtxt
        ' 
        Adm_Intern_AddInternID_Mtxt.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Intern_AddInternID_Mtxt.Location = New Point(62, 590)
        Adm_Intern_AddInternID_Mtxt.Mask = "I000"
        Adm_Intern_AddInternID_Mtxt.Name = "Adm_Intern_AddInternID_Mtxt"
        Adm_Intern_AddInternID_Mtxt.Size = New Size(186, 39)
        Adm_Intern_AddInternID_Mtxt.TabIndex = 46
        ' 
        ' Adm_Intern_Clear_btn
        ' 
        Adm_Intern_Clear_btn.BackColor = Color.Orange
        Adm_Intern_Clear_btn.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Intern_Clear_btn.ForeColor = SystemColors.ButtonHighlight
        Adm_Intern_Clear_btn.Location = New Point(1303, 552)
        Adm_Intern_Clear_btn.Name = "Adm_Intern_Clear_btn"
        Adm_Intern_Clear_btn.Size = New Size(151, 50)
        Adm_Intern_Clear_btn.TabIndex = 17
        Adm_Intern_Clear_btn.Text = "CLEAR"
        Adm_Intern_Clear_btn.UseVisualStyleBackColor = False
        ' 
        ' Adm_Intern_Add_btn
        ' 
        Adm_Intern_Add_btn.BackColor = Color.ForestGreen
        Adm_Intern_Add_btn.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Intern_Add_btn.ForeColor = SystemColors.ButtonHighlight
        Adm_Intern_Add_btn.Location = New Point(1137, 552)
        Adm_Intern_Add_btn.Name = "Adm_Intern_Add_btn"
        Adm_Intern_Add_btn.Size = New Size(151, 50)
        Adm_Intern_Add_btn.TabIndex = 16
        Adm_Intern_Add_btn.Text = "ADD"
        Adm_Intern_Add_btn.UseVisualStyleBackColor = False
        ' 
        ' Adm_Intern_Bpan1
        ' 
        Adm_Intern_Bpan1.BackColor = Color.Black
        Adm_Intern_Bpan1.Location = New Point(51, 526)
        Adm_Intern_Bpan1.Name = "Adm_Intern_Bpan1"
        Adm_Intern_Bpan1.Size = New Size(1404, 10)
        Adm_Intern_Bpan1.TabIndex = 15
        ' 
        ' Adm_Intern_Bpan2
        ' 
        Adm_Intern_Bpan2.BackColor = Color.Black
        Adm_Intern_Bpan2.Location = New Point(51, 450)
        Adm_Intern_Bpan2.Name = "Adm_Intern_Bpan2"
        Adm_Intern_Bpan2.Size = New Size(1404, 10)
        Adm_Intern_Bpan2.TabIndex = 14
        ' 
        ' Adm_Intern_newEntry_lbl
        ' 
        Adm_Intern_newEntry_lbl.AutoSize = True
        Adm_Intern_newEntry_lbl.Font = New Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Intern_newEntry_lbl.Location = New Point(616, 473)
        Adm_Intern_newEntry_lbl.Name = "Adm_Intern_newEntry_lbl"
        Adm_Intern_newEntry_lbl.Size = New Size(222, 39)
        Adm_Intern_newEntry_lbl.TabIndex = 13
        Adm_Intern_newEntry_lbl.Text = "NEW ENTRY"
        ' 
        ' Adm_Intern_DGV
        ' 
        Adm_Intern_DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Adm_Intern_DGV.Columns.AddRange(New DataGridViewColumn() {Adm_Intern_InternID_col, Adm_Intern_SY_col, Adm_Intern_StudName_col, Adm_Intern_Course_col, Adm_Intern_CompName_col, Adm_Intern_Supervisor_col, Adm_Intern_FacEval_col, Adm_Intern_StartDate_col, Adm_Intern_EndDate_col, Adm_Intern_Status_col, Adm_Intern_Grade_col})
        Adm_Intern_DGV.Location = New Point(51, 182)
        Adm_Intern_DGV.Name = "Adm_Intern_DGV"
        Adm_Intern_DGV.RowHeadersWidth = 51
        Adm_Intern_DGV.Size = New Size(1403, 252)
        Adm_Intern_DGV.TabIndex = 11
        ' 
        ' Adm_Intern_InternID_col
        ' 
        Adm_Intern_InternID_col.HeaderText = "INTERNSHIP ID"
        Adm_Intern_InternID_col.MinimumWidth = 6
        Adm_Intern_InternID_col.Name = "Adm_Intern_InternID_col"
        Adm_Intern_InternID_col.Width = 123
        ' 
        ' Adm_Intern_SY_col
        ' 
        Adm_Intern_SY_col.HeaderText = "SCHOOL YEAR"
        Adm_Intern_SY_col.MinimumWidth = 6
        Adm_Intern_SY_col.Name = "Adm_Intern_SY_col"
        Adm_Intern_SY_col.Width = 123
        ' 
        ' Adm_Intern_StudName_col
        ' 
        Adm_Intern_StudName_col.HeaderText = "STUDENT NAME"
        Adm_Intern_StudName_col.MinimumWidth = 6
        Adm_Intern_StudName_col.Name = "Adm_Intern_StudName_col"
        Adm_Intern_StudName_col.Width = 123
        ' 
        ' Adm_Intern_Course_col
        ' 
        Adm_Intern_Course_col.HeaderText = "COURSE"
        Adm_Intern_Course_col.MinimumWidth = 6
        Adm_Intern_Course_col.Name = "Adm_Intern_Course_col"
        Adm_Intern_Course_col.Width = 123
        ' 
        ' Adm_Intern_CompName_col
        ' 
        Adm_Intern_CompName_col.HeaderText = "COMPANY NAME"
        Adm_Intern_CompName_col.MinimumWidth = 6
        Adm_Intern_CompName_col.Name = "Adm_Intern_CompName_col"
        Adm_Intern_CompName_col.Width = 123
        ' 
        ' Adm_Intern_Supervisor_col
        ' 
        Adm_Intern_Supervisor_col.HeaderText = "SUPERVISOR"
        Adm_Intern_Supervisor_col.MinimumWidth = 6
        Adm_Intern_Supervisor_col.Name = "Adm_Intern_Supervisor_col"
        Adm_Intern_Supervisor_col.Width = 123
        ' 
        ' Adm_Intern_FacEval_col
        ' 
        Adm_Intern_FacEval_col.HeaderText = "FACULTY EVALUATOR"
        Adm_Intern_FacEval_col.MinimumWidth = 6
        Adm_Intern_FacEval_col.Name = "Adm_Intern_FacEval_col"
        Adm_Intern_FacEval_col.Width = 123
        ' 
        ' Adm_Intern_StartDate_col
        ' 
        Adm_Intern_StartDate_col.HeaderText = "START DATE"
        Adm_Intern_StartDate_col.MinimumWidth = 6
        Adm_Intern_StartDate_col.Name = "Adm_Intern_StartDate_col"
        Adm_Intern_StartDate_col.Width = 123
        ' 
        ' Adm_Intern_EndDate_col
        ' 
        Adm_Intern_EndDate_col.HeaderText = "END DATE"
        Adm_Intern_EndDate_col.MinimumWidth = 6
        Adm_Intern_EndDate_col.Name = "Adm_Intern_EndDate_col"
        Adm_Intern_EndDate_col.Width = 123
        ' 
        ' Adm_Intern_Status_col
        ' 
        Adm_Intern_Status_col.HeaderText = "STATUS"
        Adm_Intern_Status_col.MinimumWidth = 6
        Adm_Intern_Status_col.Name = "Adm_Intern_Status_col"
        Adm_Intern_Status_col.Width = 123
        ' 
        ' Adm_Intern_Grade_col
        ' 
        Adm_Intern_Grade_col.HeaderText = "GRADE"
        Adm_Intern_Grade_col.MinimumWidth = 6
        Adm_Intern_Grade_col.Name = "Adm_Intern_Grade_col"
        Adm_Intern_Grade_col.Width = 123
        ' 
        ' Adm_Intern_design
        ' 
        Adm_Intern_design.BackColor = Color.Navy
        Adm_Intern_design.Location = New Point(51, 41)
        Adm_Intern_design.Name = "Adm_Intern_design"
        Adm_Intern_design.Size = New Size(39, 72)
        Adm_Intern_design.TabIndex = 10
        ' 
        ' Adm_InternTitle_lbl
        ' 
        Adm_InternTitle_lbl.Font = New Font("Times New Roman", 54F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Adm_InternTitle_lbl.Location = New Point(96, 22)
        Adm_InternTitle_lbl.Name = "Adm_InternTitle_lbl"
        Adm_InternTitle_lbl.Size = New Size(914, 105)
        Adm_InternTitle_lbl.TabIndex = 9
        Adm_InternTitle_lbl.Text = "INTERNSHIPS"
        ' 
        ' Adm_Intern_DateTime_lbl
        ' 
        Adm_Intern_DateTime_lbl.Font = New Font("Rockwell", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Intern_DateTime_lbl.Location = New Point(735, 32)
        Adm_Intern_DateTime_lbl.Name = "Adm_Intern_DateTime_lbl"
        Adm_Intern_DateTime_lbl.Size = New Size(695, 49)
        Adm_Intern_DateTime_lbl.TabIndex = 3
        ' 
        ' ADM_SUPERPAN
        ' 
        ADM_SUPERPAN.BackColor = Color.WhiteSmoke
        ADM_SUPERPAN.Controls.Add(Adm_Sup_Supervisor_cmb)
        ADM_SUPERPAN.Controls.Add(Adm_Sup_Supervisor_lbl)
        ADM_SUPERPAN.Controls.Add(Adm_Sup_Clear_btn)
        ADM_SUPERPAN.Controls.Add(Adm_Sup_Add_btn)
        ADM_SUPERPAN.Controls.Add(Adm_Sup_AddCont_lbl)
        ADM_SUPERPAN.Controls.Add(Adm_Sup_AddCont_txt)
        ADM_SUPERPAN.Controls.Add(Adm_Sup_AddPos_txt)
        ADM_SUPERPAN.Controls.Add(Adm_Sup_AddPos_lbl)
        ADM_SUPERPAN.Controls.Add(Adm_Sup_AddSuffix_txt)
        ADM_SUPERPAN.Controls.Add(Adm_Sup_AddMName_txt)
        ADM_SUPERPAN.Controls.Add(Adm_Sup_AddSuffix_lbl)
        ADM_SUPERPAN.Controls.Add(Adm_Sup_AddMName_lbl)
        ADM_SUPERPAN.Controls.Add(Adm_Sup_Comp_cmb)
        ADM_SUPERPAN.Controls.Add(Adm_Sup_AddAddress_txt)
        ADM_SUPERPAN.Controls.Add(Adm_Sup_AddFName_txt)
        ADM_SUPERPAN.Controls.Add(Adm_Sup_AddLName_txt)
        ADM_SUPERPAN.Controls.Add(Adm_Sup_AddAddress_lbl)
        ADM_SUPERPAN.Controls.Add(Adm_Sup_AddFName_lbl)
        ADM_SUPERPAN.Controls.Add(Adm_Sup_AddLName_lbl)
        ADM_SUPERPAN.Controls.Add(Adm_Sup_Comp_lbl)
        ADM_SUPERPAN.Controls.Add(Adm_Sup_SupID_lbl)
        ADM_SUPERPAN.Controls.Add(Adm_Sup_SupID_Mtxt)
        ADM_SUPERPAN.Controls.Add(Adm_Sup_Del_btn)
        ADM_SUPERPAN.Controls.Add(Adm_Sup_Edit_btn)
        ADM_SUPERPAN.Controls.Add(Adm_Sup_Bpan1)
        ADM_SUPERPAN.Controls.Add(Adm_Sup_Bpan2)
        ADM_SUPERPAN.Controls.Add(Adm_Sup_newEntry_lbl)
        ADM_SUPERPAN.Controls.Add(Adm_Sup_DGV)
        ADM_SUPERPAN.Controls.Add(Adm_Sup_design)
        ADM_SUPERPAN.Controls.Add(Adm_SupTitle_lbl)
        ADM_SUPERPAN.Controls.Add(Adm_Sup_DateTime_lbl)
        ADM_SUPERPAN.Location = New Point(17, 25)
        ADM_SUPERPAN.Name = "ADM_SUPERPAN"
        ADM_SUPERPAN.Size = New Size(1515, 793)
        ADM_SUPERPAN.TabIndex = 6
        ' 
        ' Adm_Sup_Supervisor_cmb
        ' 
        Adm_Sup_Supervisor_cmb.Font = New Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Sup_Supervisor_cmb.FormattingEnabled = True
        Adm_Sup_Supervisor_cmb.Location = New Point(210, 134)
        Adm_Sup_Supervisor_cmb.Name = "Adm_Sup_Supervisor_cmb"
        Adm_Sup_Supervisor_cmb.Size = New Size(154, 42)
        Adm_Sup_Supervisor_cmb.TabIndex = 69
        ' 
        ' Adm_Sup_Supervisor_lbl
        ' 
        Adm_Sup_Supervisor_lbl.AutoSize = True
        Adm_Sup_Supervisor_lbl.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Sup_Supervisor_lbl.Location = New Point(51, 142)
        Adm_Sup_Supervisor_lbl.Name = "Adm_Sup_Supervisor_lbl"
        Adm_Sup_Supervisor_lbl.Size = New Size(154, 27)
        Adm_Sup_Supervisor_lbl.TabIndex = 68
        Adm_Sup_Supervisor_lbl.Text = "Company ID:"
        Adm_Sup_Supervisor_lbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Adm_Sup_Clear_btn
        ' 
        Adm_Sup_Clear_btn.BackColor = Color.Orange
        Adm_Sup_Clear_btn.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Sup_Clear_btn.ForeColor = SystemColors.ButtonHighlight
        Adm_Sup_Clear_btn.Location = New Point(1303, 680)
        Adm_Sup_Clear_btn.Name = "Adm_Sup_Clear_btn"
        Adm_Sup_Clear_btn.Size = New Size(151, 60)
        Adm_Sup_Clear_btn.TabIndex = 67
        Adm_Sup_Clear_btn.Text = "CLEAR"
        Adm_Sup_Clear_btn.UseVisualStyleBackColor = False
        ' 
        ' Adm_Sup_Add_btn
        ' 
        Adm_Sup_Add_btn.BackColor = Color.ForestGreen
        Adm_Sup_Add_btn.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Sup_Add_btn.ForeColor = SystemColors.ButtonHighlight
        Adm_Sup_Add_btn.Location = New Point(1137, 680)
        Adm_Sup_Add_btn.Name = "Adm_Sup_Add_btn"
        Adm_Sup_Add_btn.Size = New Size(151, 60)
        Adm_Sup_Add_btn.TabIndex = 66
        Adm_Sup_Add_btn.Text = "ADD"
        Adm_Sup_Add_btn.UseVisualStyleBackColor = False
        ' 
        ' Adm_Sup_AddCont_lbl
        ' 
        Adm_Sup_AddCont_lbl.AutoSize = True
        Adm_Sup_AddCont_lbl.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Sup_AddCont_lbl.Location = New Point(636, 641)
        Adm_Sup_AddCont_lbl.Name = "Adm_Sup_AddCont_lbl"
        Adm_Sup_AddCont_lbl.Size = New Size(145, 27)
        Adm_Sup_AddCont_lbl.TabIndex = 65
        Adm_Sup_AddCont_lbl.Text = "Contact No."
        Adm_Sup_AddCont_lbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Adm_Sup_AddCont_txt
        ' 
        Adm_Sup_AddCont_txt.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Sup_AddCont_txt.Location = New Point(636, 669)
        Adm_Sup_AddCont_txt.Name = "Adm_Sup_AddCont_txt"
        Adm_Sup_AddCont_txt.Size = New Size(374, 39)
        Adm_Sup_AddCont_txt.TabIndex = 64
        ' 
        ' Adm_Sup_AddPos_txt
        ' 
        Adm_Sup_AddPos_txt.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Sup_AddPos_txt.Location = New Point(63, 669)
        Adm_Sup_AddPos_txt.Name = "Adm_Sup_AddPos_txt"
        Adm_Sup_AddPos_txt.Size = New Size(548, 39)
        Adm_Sup_AddPos_txt.TabIndex = 63
        ' 
        ' Adm_Sup_AddPos_lbl
        ' 
        Adm_Sup_AddPos_lbl.AutoSize = True
        Adm_Sup_AddPos_lbl.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Sup_AddPos_lbl.Location = New Point(63, 640)
        Adm_Sup_AddPos_lbl.Name = "Adm_Sup_AddPos_lbl"
        Adm_Sup_AddPos_lbl.Size = New Size(108, 27)
        Adm_Sup_AddPos_lbl.TabIndex = 62
        Adm_Sup_AddPos_lbl.Text = "Position:"
        Adm_Sup_AddPos_lbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Adm_Sup_AddSuffix_txt
        ' 
        Adm_Sup_AddSuffix_txt.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Sup_AddSuffix_txt.Location = New Point(1129, 590)
        Adm_Sup_AddSuffix_txt.Name = "Adm_Sup_AddSuffix_txt"
        Adm_Sup_AddSuffix_txt.Size = New Size(114, 39)
        Adm_Sup_AddSuffix_txt.TabIndex = 61
        ' 
        ' Adm_Sup_AddMName_txt
        ' 
        Adm_Sup_AddMName_txt.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Sup_AddMName_txt.Location = New Point(865, 590)
        Adm_Sup_AddMName_txt.Name = "Adm_Sup_AddMName_txt"
        Adm_Sup_AddMName_txt.Size = New Size(240, 39)
        Adm_Sup_AddMName_txt.TabIndex = 60
        ' 
        ' Adm_Sup_AddSuffix_lbl
        ' 
        Adm_Sup_AddSuffix_lbl.AutoSize = True
        Adm_Sup_AddSuffix_lbl.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Sup_AddSuffix_lbl.Location = New Point(1129, 561)
        Adm_Sup_AddSuffix_lbl.Name = "Adm_Sup_AddSuffix_lbl"
        Adm_Sup_AddSuffix_lbl.Size = New Size(82, 27)
        Adm_Sup_AddSuffix_lbl.TabIndex = 59
        Adm_Sup_AddSuffix_lbl.Text = "Suffix:"
        Adm_Sup_AddSuffix_lbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Adm_Sup_AddMName_lbl
        ' 
        Adm_Sup_AddMName_lbl.AutoSize = True
        Adm_Sup_AddMName_lbl.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Sup_AddMName_lbl.Location = New Point(865, 561)
        Adm_Sup_AddMName_lbl.Name = "Adm_Sup_AddMName_lbl"
        Adm_Sup_AddMName_lbl.Size = New Size(163, 27)
        Adm_Sup_AddMName_lbl.TabIndex = 58
        Adm_Sup_AddMName_lbl.Text = "Middle Name:"
        Adm_Sup_AddMName_lbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Adm_Sup_Comp_cmb
        ' 
        Adm_Sup_Comp_cmb.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Sup_Comp_cmb.FormattingEnabled = True
        Adm_Sup_Comp_cmb.Location = New Point(1266, 590)
        Adm_Sup_Comp_cmb.Name = "Adm_Sup_Comp_cmb"
        Adm_Sup_Comp_cmb.Size = New Size(188, 40)
        Adm_Sup_Comp_cmb.TabIndex = 57
        ' 
        ' Adm_Sup_AddAddress_txt
        ' 
        Adm_Sup_AddAddress_txt.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Sup_AddAddress_txt.Location = New Point(63, 746)
        Adm_Sup_AddAddress_txt.Name = "Adm_Sup_AddAddress_txt"
        Adm_Sup_AddAddress_txt.Size = New Size(779, 39)
        Adm_Sup_AddAddress_txt.TabIndex = 55
        ' 
        ' Adm_Sup_AddFName_txt
        ' 
        Adm_Sup_AddFName_txt.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Sup_AddFName_txt.Location = New Point(485, 590)
        Adm_Sup_AddFName_txt.Name = "Adm_Sup_AddFName_txt"
        Adm_Sup_AddFName_txt.Size = New Size(357, 39)
        Adm_Sup_AddFName_txt.TabIndex = 54
        ' 
        ' Adm_Sup_AddLName_txt
        ' 
        Adm_Sup_AddLName_txt.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Sup_AddLName_txt.Location = New Point(273, 590)
        Adm_Sup_AddLName_txt.Name = "Adm_Sup_AddLName_txt"
        Adm_Sup_AddLName_txt.Size = New Size(186, 39)
        Adm_Sup_AddLName_txt.TabIndex = 53
        ' 
        ' Adm_Sup_AddAddress_lbl
        ' 
        Adm_Sup_AddAddress_lbl.AutoSize = True
        Adm_Sup_AddAddress_lbl.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Sup_AddAddress_lbl.Location = New Point(63, 718)
        Adm_Sup_AddAddress_lbl.Name = "Adm_Sup_AddAddress_lbl"
        Adm_Sup_AddAddress_lbl.Size = New Size(179, 27)
        Adm_Sup_AddAddress_lbl.TabIndex = 52
        Adm_Sup_AddAddress_lbl.Text = "Email Address:"
        Adm_Sup_AddAddress_lbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Adm_Sup_AddFName_lbl
        ' 
        Adm_Sup_AddFName_lbl.AutoSize = True
        Adm_Sup_AddFName_lbl.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Sup_AddFName_lbl.Location = New Point(485, 561)
        Adm_Sup_AddFName_lbl.Name = "Adm_Sup_AddFName_lbl"
        Adm_Sup_AddFName_lbl.Size = New Size(140, 27)
        Adm_Sup_AddFName_lbl.TabIndex = 50
        Adm_Sup_AddFName_lbl.Text = "First Name:"
        Adm_Sup_AddFName_lbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Adm_Sup_AddLName_lbl
        ' 
        Adm_Sup_AddLName_lbl.AutoSize = True
        Adm_Sup_AddLName_lbl.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Sup_AddLName_lbl.Location = New Point(273, 561)
        Adm_Sup_AddLName_lbl.Name = "Adm_Sup_AddLName_lbl"
        Adm_Sup_AddLName_lbl.Size = New Size(138, 27)
        Adm_Sup_AddLName_lbl.TabIndex = 49
        Adm_Sup_AddLName_lbl.Text = "Last Name:"
        Adm_Sup_AddLName_lbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Adm_Sup_Comp_lbl
        ' 
        Adm_Sup_Comp_lbl.AutoSize = True
        Adm_Sup_Comp_lbl.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Sup_Comp_lbl.Location = New Point(1266, 561)
        Adm_Sup_Comp_lbl.Name = "Adm_Sup_Comp_lbl"
        Adm_Sup_Comp_lbl.Size = New Size(154, 27)
        Adm_Sup_Comp_lbl.TabIndex = 48
        Adm_Sup_Comp_lbl.Text = "Company ID:"
        Adm_Sup_Comp_lbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Adm_Sup_SupID_lbl
        ' 
        Adm_Sup_SupID_lbl.AutoSize = True
        Adm_Sup_SupID_lbl.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Sup_SupID_lbl.Location = New Point(62, 561)
        Adm_Sup_SupID_lbl.Name = "Adm_Sup_SupID_lbl"
        Adm_Sup_SupID_lbl.Size = New Size(170, 27)
        Adm_Sup_SupID_lbl.TabIndex = 47
        Adm_Sup_SupID_lbl.Text = "Supervisor ID:"
        Adm_Sup_SupID_lbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Adm_Sup_SupID_Mtxt
        ' 
        Adm_Sup_SupID_Mtxt.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Sup_SupID_Mtxt.Location = New Point(62, 590)
        Adm_Sup_SupID_Mtxt.Name = "Adm_Sup_SupID_Mtxt"
        Adm_Sup_SupID_Mtxt.Size = New Size(186, 39)
        Adm_Sup_SupID_Mtxt.TabIndex = 46
        ' 
        ' Adm_Sup_Del_btn
        ' 
        Adm_Sup_Del_btn.BackColor = Color.DarkRed
        Adm_Sup_Del_btn.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Sup_Del_btn.ForeColor = SystemColors.ButtonHighlight
        Adm_Sup_Del_btn.Location = New Point(1303, 464)
        Adm_Sup_Del_btn.Name = "Adm_Sup_Del_btn"
        Adm_Sup_Del_btn.Size = New Size(151, 60)
        Adm_Sup_Del_btn.TabIndex = 17
        Adm_Sup_Del_btn.Text = "DELETE"
        Adm_Sup_Del_btn.UseVisualStyleBackColor = False
        ' 
        ' Adm_Sup_Edit_btn
        ' 
        Adm_Sup_Edit_btn.BackColor = Color.Navy
        Adm_Sup_Edit_btn.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Sup_Edit_btn.ForeColor = SystemColors.ButtonHighlight
        Adm_Sup_Edit_btn.Location = New Point(1137, 464)
        Adm_Sup_Edit_btn.Name = "Adm_Sup_Edit_btn"
        Adm_Sup_Edit_btn.Size = New Size(151, 60)
        Adm_Sup_Edit_btn.TabIndex = 16
        Adm_Sup_Edit_btn.Text = "EDIT"
        Adm_Sup_Edit_btn.UseVisualStyleBackColor = False
        ' 
        ' Adm_Sup_Bpan1
        ' 
        Adm_Sup_Bpan1.BackColor = Color.Black
        Adm_Sup_Bpan1.Location = New Point(51, 526)
        Adm_Sup_Bpan1.Name = "Adm_Sup_Bpan1"
        Adm_Sup_Bpan1.Size = New Size(1054, 10)
        Adm_Sup_Bpan1.TabIndex = 15
        ' 
        ' Adm_Sup_Bpan2
        ' 
        Adm_Sup_Bpan2.BackColor = Color.Black
        Adm_Sup_Bpan2.Location = New Point(51, 450)
        Adm_Sup_Bpan2.Name = "Adm_Sup_Bpan2"
        Adm_Sup_Bpan2.Size = New Size(1054, 10)
        Adm_Sup_Bpan2.TabIndex = 14
        ' 
        ' Adm_Sup_newEntry_lbl
        ' 
        Adm_Sup_newEntry_lbl.AutoSize = True
        Adm_Sup_newEntry_lbl.Font = New Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Sup_newEntry_lbl.Location = New Point(482, 473)
        Adm_Sup_newEntry_lbl.Name = "Adm_Sup_newEntry_lbl"
        Adm_Sup_newEntry_lbl.Size = New Size(222, 39)
        Adm_Sup_newEntry_lbl.TabIndex = 13
        Adm_Sup_newEntry_lbl.Text = "NEW ENTRY"
        ' 
        ' Adm_Sup_DGV
        ' 
        Adm_Sup_DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Adm_Sup_DGV.Columns.AddRange(New DataGridViewColumn() {Adm_Sup_SupID_col, Adm_Sup_LName_col, Adm_Sup_FName_col, Adm_Sup_MName_col, Adm_Sup_Suffix_col, Adm_Sup_Email_col, Adm_Sup_ContNo_col, Adm_Sup_Pos_col})
        Adm_Sup_DGV.Location = New Point(51, 182)
        Adm_Sup_DGV.Name = "Adm_Sup_DGV"
        Adm_Sup_DGV.RowHeadersWidth = 51
        Adm_Sup_DGV.Size = New Size(1403, 252)
        Adm_Sup_DGV.TabIndex = 10
        ' 
        ' Adm_Sup_SupID_col
        ' 
        Adm_Sup_SupID_col.HeaderText = "SUPERVISOR ID"
        Adm_Sup_SupID_col.MinimumWidth = 6
        Adm_Sup_SupID_col.Name = "Adm_Sup_SupID_col"
        Adm_Sup_SupID_col.Width = 169
        ' 
        ' Adm_Sup_LName_col
        ' 
        Adm_Sup_LName_col.HeaderText = "LAST NAME"
        Adm_Sup_LName_col.MinimumWidth = 6
        Adm_Sup_LName_col.Name = "Adm_Sup_LName_col"
        Adm_Sup_LName_col.Width = 169
        ' 
        ' Adm_Sup_FName_col
        ' 
        Adm_Sup_FName_col.HeaderText = "FIRST NAME"
        Adm_Sup_FName_col.MinimumWidth = 6
        Adm_Sup_FName_col.Name = "Adm_Sup_FName_col"
        Adm_Sup_FName_col.Width = 169
        ' 
        ' Adm_Sup_MName_col
        ' 
        Adm_Sup_MName_col.HeaderText = "MIDDLE NAME"
        Adm_Sup_MName_col.MinimumWidth = 6
        Adm_Sup_MName_col.Name = "Adm_Sup_MName_col"
        Adm_Sup_MName_col.Width = 169
        ' 
        ' Adm_Sup_Suffix_col
        ' 
        Adm_Sup_Suffix_col.HeaderText = "SUFFIX"
        Adm_Sup_Suffix_col.MinimumWidth = 6
        Adm_Sup_Suffix_col.Name = "Adm_Sup_Suffix_col"
        Adm_Sup_Suffix_col.Width = 169
        ' 
        ' Adm_Sup_Email_col
        ' 
        Adm_Sup_Email_col.HeaderText = "EMAIL"
        Adm_Sup_Email_col.MinimumWidth = 6
        Adm_Sup_Email_col.Name = "Adm_Sup_Email_col"
        Adm_Sup_Email_col.Width = 169
        ' 
        ' Adm_Sup_ContNo_col
        ' 
        Adm_Sup_ContNo_col.HeaderText = "CONTACT NO."
        Adm_Sup_ContNo_col.MinimumWidth = 6
        Adm_Sup_ContNo_col.Name = "Adm_Sup_ContNo_col"
        Adm_Sup_ContNo_col.Width = 169
        ' 
        ' Adm_Sup_Pos_col
        ' 
        Adm_Sup_Pos_col.HeaderText = "POSITION"
        Adm_Sup_Pos_col.MinimumWidth = 6
        Adm_Sup_Pos_col.Name = "Adm_Sup_Pos_col"
        Adm_Sup_Pos_col.Width = 169
        ' 
        ' Adm_Sup_design
        ' 
        Adm_Sup_design.BackColor = Color.Navy
        Adm_Sup_design.Location = New Point(51, 41)
        Adm_Sup_design.Name = "Adm_Sup_design"
        Adm_Sup_design.Size = New Size(39, 72)
        Adm_Sup_design.TabIndex = 9
        ' 
        ' Adm_SupTitle_lbl
        ' 
        Adm_SupTitle_lbl.Font = New Font("Times New Roman", 54F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Adm_SupTitle_lbl.Location = New Point(96, 22)
        Adm_SupTitle_lbl.Name = "Adm_SupTitle_lbl"
        Adm_SupTitle_lbl.Size = New Size(894, 105)
        Adm_SupTitle_lbl.TabIndex = 8
        Adm_SupTitle_lbl.Text = "SUPERVISORS"
        ' 
        ' Adm_Sup_DateTime_lbl
        ' 
        Adm_Sup_DateTime_lbl.Font = New Font("Rockwell", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Sup_DateTime_lbl.Location = New Point(735, 32)
        Adm_Sup_DateTime_lbl.Name = "Adm_Sup_DateTime_lbl"
        Adm_Sup_DateTime_lbl.Size = New Size(695, 49)
        Adm_Sup_DateTime_lbl.TabIndex = 3
        ' 
        ' ADM_COMPAN
        ' 
        ADM_COMPAN.BackColor = Color.WhiteSmoke
        ADM_COMPAN.Controls.Add(Adm_Comp_Clear_btn)
        ADM_COMPAN.Controls.Add(Adm_Comp_Add_btn)
        ADM_COMPAN.Controls.Add(Adm_Comp_Cont_lbl)
        ADM_COMPAN.Controls.Add(Adm_Comp_Cont_Mtxt)
        ADM_COMPAN.Controls.Add(Adm_Comp_CompAdd_txt)
        ADM_COMPAN.Controls.Add(Adm_Comp_CompAdd_lbl)
        ADM_COMPAN.Controls.Add(Adm_Comp_CompEmail_txt)
        ADM_COMPAN.Controls.Add(Adm_Comp_CompName_txt)
        ADM_COMPAN.Controls.Add(Adm_Comp_CompEmail_lbl)
        ADM_COMPAN.Controls.Add(Adm_Comp_CompName_lbl)
        ADM_COMPAN.Controls.Add(Adm_Comp_CompID_lbl)
        ADM_COMPAN.Controls.Add(Adm_Comp_CompID_Mtxt)
        ADM_COMPAN.Controls.Add(Adm_Comp_Del_btn)
        ADM_COMPAN.Controls.Add(Adm_Comp_Edit_btn)
        ADM_COMPAN.Controls.Add(Adm_Comp_BPan1)
        ADM_COMPAN.Controls.Add(Adm_Comp_BPan2)
        ADM_COMPAN.Controls.Add(Adm_Comp_newEntry_lbl)
        ADM_COMPAN.Controls.Add(Adm_Comp_DGV)
        ADM_COMPAN.Controls.Add(Adm_Comp_design)
        ADM_COMPAN.Controls.Add(Adm_CompTitle_lbl)
        ADM_COMPAN.Controls.Add(Adm_Comp_DateTime_lbl)
        ADM_COMPAN.Location = New Point(17, 25)
        ADM_COMPAN.Name = "ADM_COMPAN"
        ADM_COMPAN.Size = New Size(1515, 793)
        ADM_COMPAN.TabIndex = 5
        ' 
        ' Adm_Comp_Clear_btn
        ' 
        Adm_Comp_Clear_btn.BackColor = Color.Orange
        Adm_Comp_Clear_btn.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Comp_Clear_btn.ForeColor = SystemColors.ButtonHighlight
        Adm_Comp_Clear_btn.Location = New Point(1303, 671)
        Adm_Comp_Clear_btn.Name = "Adm_Comp_Clear_btn"
        Adm_Comp_Clear_btn.Size = New Size(151, 60)
        Adm_Comp_Clear_btn.TabIndex = 61
        Adm_Comp_Clear_btn.Text = "CLEAR"
        Adm_Comp_Clear_btn.UseVisualStyleBackColor = False
        ' 
        ' Adm_Comp_Add_btn
        ' 
        Adm_Comp_Add_btn.BackColor = Color.ForestGreen
        Adm_Comp_Add_btn.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Comp_Add_btn.ForeColor = SystemColors.ButtonHighlight
        Adm_Comp_Add_btn.Location = New Point(1137, 671)
        Adm_Comp_Add_btn.Name = "Adm_Comp_Add_btn"
        Adm_Comp_Add_btn.Size = New Size(151, 60)
        Adm_Comp_Add_btn.TabIndex = 60
        Adm_Comp_Add_btn.Text = "ADD"
        Adm_Comp_Add_btn.UseVisualStyleBackColor = False
        ' 
        ' Adm_Comp_Cont_lbl
        ' 
        Adm_Comp_Cont_lbl.AutoSize = True
        Adm_Comp_Cont_lbl.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Comp_Cont_lbl.Location = New Point(62, 711)
        Adm_Comp_Cont_lbl.Name = "Adm_Comp_Cont_lbl"
        Adm_Comp_Cont_lbl.Size = New Size(219, 27)
        Adm_Comp_Cont_lbl.TabIndex = 59
        Adm_Comp_Cont_lbl.Text = "Company Contact:"
        Adm_Comp_Cont_lbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Adm_Comp_Cont_Mtxt
        ' 
        Adm_Comp_Cont_Mtxt.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Comp_Cont_Mtxt.Location = New Point(62, 740)
        Adm_Comp_Cont_Mtxt.Name = "Adm_Comp_Cont_Mtxt"
        Adm_Comp_Cont_Mtxt.Size = New Size(379, 39)
        Adm_Comp_Cont_Mtxt.TabIndex = 58
        ' 
        ' Adm_Comp_CompAdd_txt
        ' 
        Adm_Comp_CompAdd_txt.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Comp_CompAdd_txt.Location = New Point(63, 664)
        Adm_Comp_CompAdd_txt.Name = "Adm_Comp_CompAdd_txt"
        Adm_Comp_CompAdd_txt.Size = New Size(827, 39)
        Adm_Comp_CompAdd_txt.TabIndex = 57
        ' 
        ' Adm_Comp_CompAdd_lbl
        ' 
        Adm_Comp_CompAdd_lbl.AutoSize = True
        Adm_Comp_CompAdd_lbl.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Comp_CompAdd_lbl.Location = New Point(63, 636)
        Adm_Comp_CompAdd_lbl.Name = "Adm_Comp_CompAdd_lbl"
        Adm_Comp_CompAdd_lbl.Size = New Size(223, 27)
        Adm_Comp_CompAdd_lbl.TabIndex = 56
        Adm_Comp_CompAdd_lbl.Text = "Company Address:"
        Adm_Comp_CompAdd_lbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Adm_Comp_CompEmail_txt
        ' 
        Adm_Comp_CompEmail_txt.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Comp_CompEmail_txt.Location = New Point(914, 590)
        Adm_Comp_CompEmail_txt.Name = "Adm_Comp_CompEmail_txt"
        Adm_Comp_CompEmail_txt.Size = New Size(540, 39)
        Adm_Comp_CompEmail_txt.TabIndex = 53
        ' 
        ' Adm_Comp_CompName_txt
        ' 
        Adm_Comp_CompName_txt.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Comp_CompName_txt.Location = New Point(273, 590)
        Adm_Comp_CompName_txt.Name = "Adm_Comp_CompName_txt"
        Adm_Comp_CompName_txt.Size = New Size(617, 39)
        Adm_Comp_CompName_txt.TabIndex = 52
        ' 
        ' Adm_Comp_CompEmail_lbl
        ' 
        Adm_Comp_CompEmail_lbl.AutoSize = True
        Adm_Comp_CompEmail_lbl.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Comp_CompEmail_lbl.Location = New Point(914, 562)
        Adm_Comp_CompEmail_lbl.Name = "Adm_Comp_CompEmail_lbl"
        Adm_Comp_CompEmail_lbl.Size = New Size(191, 27)
        Adm_Comp_CompEmail_lbl.TabIndex = 51
        Adm_Comp_CompEmail_lbl.Text = "Company Email:"
        Adm_Comp_CompEmail_lbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Adm_Comp_CompName_lbl
        ' 
        Adm_Comp_CompName_lbl.AutoSize = True
        Adm_Comp_CompName_lbl.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Comp_CompName_lbl.Location = New Point(273, 561)
        Adm_Comp_CompName_lbl.Name = "Adm_Comp_CompName_lbl"
        Adm_Comp_CompName_lbl.Size = New Size(195, 27)
        Adm_Comp_CompName_lbl.TabIndex = 49
        Adm_Comp_CompName_lbl.Text = "Company Name:"
        Adm_Comp_CompName_lbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Adm_Comp_CompID_lbl
        ' 
        Adm_Comp_CompID_lbl.AutoSize = True
        Adm_Comp_CompID_lbl.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Comp_CompID_lbl.Location = New Point(62, 561)
        Adm_Comp_CompID_lbl.Name = "Adm_Comp_CompID_lbl"
        Adm_Comp_CompID_lbl.Size = New Size(154, 27)
        Adm_Comp_CompID_lbl.TabIndex = 47
        Adm_Comp_CompID_lbl.Text = "Company ID:"
        Adm_Comp_CompID_lbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Adm_Comp_CompID_Mtxt
        ' 
        Adm_Comp_CompID_Mtxt.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Comp_CompID_Mtxt.Location = New Point(62, 590)
        Adm_Comp_CompID_Mtxt.Mask = "\C000"
        Adm_Comp_CompID_Mtxt.Name = "Adm_Comp_CompID_Mtxt"
        Adm_Comp_CompID_Mtxt.Size = New Size(186, 39)
        Adm_Comp_CompID_Mtxt.TabIndex = 46
        ' 
        ' Adm_Comp_Del_btn
        ' 
        Adm_Comp_Del_btn.BackColor = Color.DarkRed
        Adm_Comp_Del_btn.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Comp_Del_btn.ForeColor = SystemColors.ButtonHighlight
        Adm_Comp_Del_btn.Location = New Point(1303, 464)
        Adm_Comp_Del_btn.Name = "Adm_Comp_Del_btn"
        Adm_Comp_Del_btn.Size = New Size(151, 60)
        Adm_Comp_Del_btn.TabIndex = 17
        Adm_Comp_Del_btn.Text = "DELETE"
        Adm_Comp_Del_btn.UseVisualStyleBackColor = False
        ' 
        ' Adm_Comp_Edit_btn
        ' 
        Adm_Comp_Edit_btn.BackColor = Color.Navy
        Adm_Comp_Edit_btn.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Comp_Edit_btn.ForeColor = SystemColors.ButtonHighlight
        Adm_Comp_Edit_btn.Location = New Point(1137, 464)
        Adm_Comp_Edit_btn.Name = "Adm_Comp_Edit_btn"
        Adm_Comp_Edit_btn.Size = New Size(151, 60)
        Adm_Comp_Edit_btn.TabIndex = 16
        Adm_Comp_Edit_btn.Text = "EDIT"
        Adm_Comp_Edit_btn.UseVisualStyleBackColor = False
        ' 
        ' Adm_Comp_BPan1
        ' 
        Adm_Comp_BPan1.BackColor = Color.Black
        Adm_Comp_BPan1.Location = New Point(51, 526)
        Adm_Comp_BPan1.Name = "Adm_Comp_BPan1"
        Adm_Comp_BPan1.Size = New Size(1054, 10)
        Adm_Comp_BPan1.TabIndex = 15
        ' 
        ' Adm_Comp_BPan2
        ' 
        Adm_Comp_BPan2.BackColor = Color.Black
        Adm_Comp_BPan2.Location = New Point(51, 450)
        Adm_Comp_BPan2.Name = "Adm_Comp_BPan2"
        Adm_Comp_BPan2.Size = New Size(1054, 10)
        Adm_Comp_BPan2.TabIndex = 14
        ' 
        ' Adm_Comp_newEntry_lbl
        ' 
        Adm_Comp_newEntry_lbl.AutoSize = True
        Adm_Comp_newEntry_lbl.Font = New Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Comp_newEntry_lbl.Location = New Point(482, 473)
        Adm_Comp_newEntry_lbl.Name = "Adm_Comp_newEntry_lbl"
        Adm_Comp_newEntry_lbl.Size = New Size(222, 39)
        Adm_Comp_newEntry_lbl.TabIndex = 13
        Adm_Comp_newEntry_lbl.Text = "NEW ENTRY"
        ' 
        ' Adm_Comp_DGV
        ' 
        Adm_Comp_DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Adm_Comp_DGV.Columns.AddRange(New DataGridViewColumn() {Adm_Comp_CompID_col, Adm_Comp_CompName_col, Adm_Comp_CompAdd_col, Adm_Comp_CompEmail_col, Adm_Comp_CompCont_col})
        Adm_Comp_DGV.Location = New Point(51, 182)
        Adm_Comp_DGV.Name = "Adm_Comp_DGV"
        Adm_Comp_DGV.RowHeadersWidth = 51
        Adm_Comp_DGV.Size = New Size(1403, 252)
        Adm_Comp_DGV.TabIndex = 12
        ' 
        ' Adm_Comp_CompID_col
        ' 
        Adm_Comp_CompID_col.HeaderText = "COMPANY ID"
        Adm_Comp_CompID_col.MinimumWidth = 6
        Adm_Comp_CompID_col.Name = "Adm_Comp_CompID_col"
        Adm_Comp_CompID_col.Width = 270
        ' 
        ' Adm_Comp_CompName_col
        ' 
        Adm_Comp_CompName_col.HeaderText = "COMPANY NAME"
        Adm_Comp_CompName_col.MinimumWidth = 6
        Adm_Comp_CompName_col.Name = "Adm_Comp_CompName_col"
        Adm_Comp_CompName_col.Width = 270
        ' 
        ' Adm_Comp_CompAdd_col
        ' 
        Adm_Comp_CompAdd_col.HeaderText = "COMPANY ADDRESS"
        Adm_Comp_CompAdd_col.MinimumWidth = 6
        Adm_Comp_CompAdd_col.Name = "Adm_Comp_CompAdd_col"
        Adm_Comp_CompAdd_col.Width = 270
        ' 
        ' Adm_Comp_CompEmail_col
        ' 
        Adm_Comp_CompEmail_col.HeaderText = "COMPANY EMAIL"
        Adm_Comp_CompEmail_col.MinimumWidth = 6
        Adm_Comp_CompEmail_col.Name = "Adm_Comp_CompEmail_col"
        Adm_Comp_CompEmail_col.Width = 270
        ' 
        ' Adm_Comp_CompCont_col
        ' 
        Adm_Comp_CompCont_col.HeaderText = "COMPANY CONTACT"
        Adm_Comp_CompCont_col.MinimumWidth = 6
        Adm_Comp_CompCont_col.Name = "Adm_Comp_CompCont_col"
        Adm_Comp_CompCont_col.Width = 270
        ' 
        ' Adm_Comp_design
        ' 
        Adm_Comp_design.BackColor = Color.Navy
        Adm_Comp_design.Location = New Point(51, 41)
        Adm_Comp_design.Name = "Adm_Comp_design"
        Adm_Comp_design.Size = New Size(39, 72)
        Adm_Comp_design.TabIndex = 11
        ' 
        ' Adm_CompTitle_lbl
        ' 
        Adm_CompTitle_lbl.Font = New Font("Times New Roman", 54F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Adm_CompTitle_lbl.Location = New Point(96, 22)
        Adm_CompTitle_lbl.Name = "Adm_CompTitle_lbl"
        Adm_CompTitle_lbl.Size = New Size(608, 105)
        Adm_CompTitle_lbl.TabIndex = 10
        Adm_CompTitle_lbl.Text = "COMPANIES"
        ' 
        ' Adm_Comp_DateTime_lbl
        ' 
        Adm_Comp_DateTime_lbl.Font = New Font("Rockwell", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Comp_DateTime_lbl.Location = New Point(735, 32)
        Adm_Comp_DateTime_lbl.Name = "Adm_Comp_DateTime_lbl"
        Adm_Comp_DateTime_lbl.Size = New Size(695, 49)
        Adm_Comp_DateTime_lbl.TabIndex = 3
        ' 
        ' ADM_COURSEPAN
        ' 
        ADM_COURSEPAN.BackColor = Color.WhiteSmoke
        ADM_COURSEPAN.Controls.Add(Adm_Course_Clear_btn)
        ADM_COURSEPAN.Controls.Add(Adm_Course_Add_btn)
        ADM_COURSEPAN.Controls.Add(Adm_Course_CourseName_txt)
        ADM_COURSEPAN.Controls.Add(Adm_Course_CourseName_lbl)
        ADM_COURSEPAN.Controls.Add(Adm_Course_DeptID_cmb)
        ADM_COURSEPAN.Controls.Add(Adm_Course_DeptID_lbl)
        ADM_COURSEPAN.Controls.Add(Adm_Course_CourseID_lbl)
        ADM_COURSEPAN.Controls.Add(Adm_Course_CourseID_Mtxt)
        ADM_COURSEPAN.Controls.Add(Adm_Course_DeptIDDisplay_cmb)
        ADM_COURSEPAN.Controls.Add(Adm_Course_DeptIDDisplay_lbl)
        ADM_COURSEPAN.Controls.Add(Adm_Course_Del_btn)
        ADM_COURSEPAN.Controls.Add(Adm_Course_Edit_btn)
        ADM_COURSEPAN.Controls.Add(Adm_Course_BPan1)
        ADM_COURSEPAN.Controls.Add(Adm_Course_Bpan2)
        ADM_COURSEPAN.Controls.Add(Adm_Course_newEntry_lbl)
        ADM_COURSEPAN.Controls.Add(Adm_Course_DGV)
        ADM_COURSEPAN.Controls.Add(Adm_Course_design)
        ADM_COURSEPAN.Controls.Add(Adm_CourseTitle_lbl)
        ADM_COURSEPAN.Controls.Add(Adm_Course_DateTime_lbl)
        ADM_COURSEPAN.Location = New Point(17, 25)
        ADM_COURSEPAN.Name = "ADM_COURSEPAN"
        ADM_COURSEPAN.Size = New Size(1515, 793)
        ADM_COURSEPAN.TabIndex = 4
        ' 
        ' Adm_Course_Clear_btn
        ' 
        Adm_Course_Clear_btn.BackColor = Color.Orange
        Adm_Course_Clear_btn.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Course_Clear_btn.ForeColor = SystemColors.ButtonHighlight
        Adm_Course_Clear_btn.Location = New Point(1303, 667)
        Adm_Course_Clear_btn.Name = "Adm_Course_Clear_btn"
        Adm_Course_Clear_btn.Size = New Size(151, 60)
        Adm_Course_Clear_btn.TabIndex = 57
        Adm_Course_Clear_btn.Text = "CLEAR"
        Adm_Course_Clear_btn.UseVisualStyleBackColor = False
        ' 
        ' Adm_Course_Add_btn
        ' 
        Adm_Course_Add_btn.BackColor = Color.ForestGreen
        Adm_Course_Add_btn.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Course_Add_btn.ForeColor = SystemColors.ButtonHighlight
        Adm_Course_Add_btn.Location = New Point(1137, 667)
        Adm_Course_Add_btn.Name = "Adm_Course_Add_btn"
        Adm_Course_Add_btn.Size = New Size(151, 60)
        Adm_Course_Add_btn.TabIndex = 56
        Adm_Course_Add_btn.Text = "ADD"
        Adm_Course_Add_btn.UseVisualStyleBackColor = False
        ' 
        ' Adm_Course_CourseName_txt
        ' 
        Adm_Course_CourseName_txt.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Course_CourseName_txt.Location = New Point(480, 589)
        Adm_Course_CourseName_txt.Name = "Adm_Course_CourseName_txt"
        Adm_Course_CourseName_txt.Size = New Size(804, 39)
        Adm_Course_CourseName_txt.TabIndex = 55
        ' 
        ' Adm_Course_CourseName_lbl
        ' 
        Adm_Course_CourseName_lbl.AutoSize = True
        Adm_Course_CourseName_lbl.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Course_CourseName_lbl.Location = New Point(480, 560)
        Adm_Course_CourseName_lbl.Name = "Adm_Course_CourseName_lbl"
        Adm_Course_CourseName_lbl.Size = New Size(171, 27)
        Adm_Course_CourseName_lbl.TabIndex = 54
        Adm_Course_CourseName_lbl.Text = "Course Name:"
        Adm_Course_CourseName_lbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Adm_Course_DeptID_cmb
        ' 
        Adm_Course_DeptID_cmb.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Course_DeptID_cmb.FormattingEnabled = True
        Adm_Course_DeptID_cmb.Location = New Point(273, 589)
        Adm_Course_DeptID_cmb.Name = "Adm_Course_DeptID_cmb"
        Adm_Course_DeptID_cmb.Size = New Size(182, 40)
        Adm_Course_DeptID_cmb.TabIndex = 53
        ' 
        ' Adm_Course_DeptID_lbl
        ' 
        Adm_Course_DeptID_lbl.AutoSize = True
        Adm_Course_DeptID_lbl.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Course_DeptID_lbl.Location = New Point(273, 560)
        Adm_Course_DeptID_lbl.Name = "Adm_Course_DeptID_lbl"
        Adm_Course_DeptID_lbl.Size = New Size(182, 27)
        Adm_Course_DeptID_lbl.TabIndex = 48
        Adm_Course_DeptID_lbl.Text = "Department ID:"
        Adm_Course_DeptID_lbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Adm_Course_CourseID_lbl
        ' 
        Adm_Course_CourseID_lbl.AutoSize = True
        Adm_Course_CourseID_lbl.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Course_CourseID_lbl.Location = New Point(62, 561)
        Adm_Course_CourseID_lbl.Name = "Adm_Course_CourseID_lbl"
        Adm_Course_CourseID_lbl.Size = New Size(130, 27)
        Adm_Course_CourseID_lbl.TabIndex = 47
        Adm_Course_CourseID_lbl.Text = "Course ID:"
        Adm_Course_CourseID_lbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Adm_Course_CourseID_Mtxt
        ' 
        Adm_Course_CourseID_Mtxt.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Course_CourseID_Mtxt.Location = New Point(62, 590)
        Adm_Course_CourseID_Mtxt.Mask = "\C000"
        Adm_Course_CourseID_Mtxt.Name = "Adm_Course_CourseID_Mtxt"
        Adm_Course_CourseID_Mtxt.Size = New Size(186, 39)
        Adm_Course_CourseID_Mtxt.TabIndex = 46
        ' 
        ' Adm_Course_DeptIDDisplay_cmb
        ' 
        Adm_Course_DeptIDDisplay_cmb.Font = New Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Course_DeptIDDisplay_cmb.FormattingEnabled = True
        Adm_Course_DeptIDDisplay_cmb.Location = New Point(239, 134)
        Adm_Course_DeptIDDisplay_cmb.Name = "Adm_Course_DeptIDDisplay_cmb"
        Adm_Course_DeptIDDisplay_cmb.Size = New Size(299, 42)
        Adm_Course_DeptIDDisplay_cmb.TabIndex = 19
        ' 
        ' Adm_Course_DeptIDDisplay_lbl
        ' 
        Adm_Course_DeptIDDisplay_lbl.AutoSize = True
        Adm_Course_DeptIDDisplay_lbl.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Course_DeptIDDisplay_lbl.Location = New Point(51, 142)
        Adm_Course_DeptIDDisplay_lbl.Name = "Adm_Course_DeptIDDisplay_lbl"
        Adm_Course_DeptIDDisplay_lbl.Size = New Size(182, 27)
        Adm_Course_DeptIDDisplay_lbl.TabIndex = 18
        Adm_Course_DeptIDDisplay_lbl.Text = "Department ID:"
        Adm_Course_DeptIDDisplay_lbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Adm_Course_Del_btn
        ' 
        Adm_Course_Del_btn.BackColor = Color.DarkRed
        Adm_Course_Del_btn.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Course_Del_btn.ForeColor = SystemColors.ButtonHighlight
        Adm_Course_Del_btn.Location = New Point(1303, 464)
        Adm_Course_Del_btn.Name = "Adm_Course_Del_btn"
        Adm_Course_Del_btn.Size = New Size(151, 60)
        Adm_Course_Del_btn.TabIndex = 17
        Adm_Course_Del_btn.Text = "DELETE"
        Adm_Course_Del_btn.UseVisualStyleBackColor = False
        ' 
        ' Adm_Course_Edit_btn
        ' 
        Adm_Course_Edit_btn.BackColor = Color.Navy
        Adm_Course_Edit_btn.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Course_Edit_btn.ForeColor = SystemColors.ButtonHighlight
        Adm_Course_Edit_btn.Location = New Point(1137, 464)
        Adm_Course_Edit_btn.Name = "Adm_Course_Edit_btn"
        Adm_Course_Edit_btn.Size = New Size(151, 60)
        Adm_Course_Edit_btn.TabIndex = 16
        Adm_Course_Edit_btn.Text = "EDIT"
        Adm_Course_Edit_btn.UseVisualStyleBackColor = False
        ' 
        ' Adm_Course_BPan1
        ' 
        Adm_Course_BPan1.BackColor = Color.Black
        Adm_Course_BPan1.Location = New Point(51, 526)
        Adm_Course_BPan1.Name = "Adm_Course_BPan1"
        Adm_Course_BPan1.Size = New Size(1054, 10)
        Adm_Course_BPan1.TabIndex = 15
        ' 
        ' Adm_Course_Bpan2
        ' 
        Adm_Course_Bpan2.BackColor = Color.Black
        Adm_Course_Bpan2.Location = New Point(51, 450)
        Adm_Course_Bpan2.Name = "Adm_Course_Bpan2"
        Adm_Course_Bpan2.Size = New Size(1054, 10)
        Adm_Course_Bpan2.TabIndex = 14
        ' 
        ' Adm_Course_newEntry_lbl
        ' 
        Adm_Course_newEntry_lbl.AutoSize = True
        Adm_Course_newEntry_lbl.Font = New Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Course_newEntry_lbl.Location = New Point(482, 473)
        Adm_Course_newEntry_lbl.Name = "Adm_Course_newEntry_lbl"
        Adm_Course_newEntry_lbl.Size = New Size(222, 39)
        Adm_Course_newEntry_lbl.TabIndex = 13
        Adm_Course_newEntry_lbl.Text = "NEW ENTRY"
        ' 
        ' Adm_Course_DGV
        ' 
        Adm_Course_DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Adm_Course_DGV.Columns.AddRange(New DataGridViewColumn() {Adm_Course_CourseID_col, Adm_Course_CourseName_col})
        Adm_Course_DGV.Location = New Point(51, 182)
        Adm_Course_DGV.Name = "Adm_Course_DGV"
        Adm_Course_DGV.RowHeadersWidth = 51
        Adm_Course_DGV.Size = New Size(1403, 252)
        Adm_Course_DGV.TabIndex = 10
        ' 
        ' Adm_Course_CourseID_col
        ' 
        Adm_Course_CourseID_col.HeaderText = "COURSE ID"
        Adm_Course_CourseID_col.MinimumWidth = 6
        Adm_Course_CourseID_col.Name = "Adm_Course_CourseID_col"
        Adm_Course_CourseID_col.Width = 675
        ' 
        ' Adm_Course_CourseName_col
        ' 
        Adm_Course_CourseName_col.HeaderText = "COURSE NAME"
        Adm_Course_CourseName_col.MinimumWidth = 6
        Adm_Course_CourseName_col.Name = "Adm_Course_CourseName_col"
        Adm_Course_CourseName_col.Width = 675
        ' 
        ' Adm_Course_design
        ' 
        Adm_Course_design.BackColor = Color.Navy
        Adm_Course_design.Location = New Point(51, 41)
        Adm_Course_design.Name = "Adm_Course_design"
        Adm_Course_design.Size = New Size(39, 72)
        Adm_Course_design.TabIndex = 9
        ' 
        ' Adm_CourseTitle_lbl
        ' 
        Adm_CourseTitle_lbl.Font = New Font("Times New Roman", 54F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Adm_CourseTitle_lbl.Location = New Point(96, 22)
        Adm_CourseTitle_lbl.Name = "Adm_CourseTitle_lbl"
        Adm_CourseTitle_lbl.Size = New Size(608, 105)
        Adm_CourseTitle_lbl.TabIndex = 8
        Adm_CourseTitle_lbl.Text = "COURSES"
        ' 
        ' Adm_Course_DateTime_lbl
        ' 
        Adm_Course_DateTime_lbl.Font = New Font("Rockwell", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Course_DateTime_lbl.Location = New Point(735, 32)
        Adm_Course_DateTime_lbl.Name = "Adm_Course_DateTime_lbl"
        Adm_Course_DateTime_lbl.Size = New Size(695, 49)
        Adm_Course_DateTime_lbl.TabIndex = 3
        ' 
        ' ADM_DEPTPAN
        ' 
        ADM_DEPTPAN.BackColor = Color.WhiteSmoke
        ADM_DEPTPAN.Controls.Add(Adm_Dept_Clear_btn)
        ADM_DEPTPAN.Controls.Add(Adm_Dept_Add_brn)
        ADM_DEPTPAN.Controls.Add(Adm_Dept_Suffix_txt)
        ADM_DEPTPAN.Controls.Add(Adm_Dept_Suffix_lbl)
        ADM_DEPTPAN.Controls.Add(Adm_Dept_MName_txt)
        ADM_DEPTPAN.Controls.Add(Adm_Dept_MName_lbl)
        ADM_DEPTPAN.Controls.Add(Adm_Dept_Name_txt)
        ADM_DEPTPAN.Controls.Add(Adm_Dept_FName_txt)
        ADM_DEPTPAN.Controls.Add(Adm_Dept_LName_txt)
        ADM_DEPTPAN.Controls.Add(Adm_Dept_Name_lbl)
        ADM_DEPTPAN.Controls.Add(Adm_Dept_FName_lbl)
        ADM_DEPTPAN.Controls.Add(Adm_Dept_LName_lbl)
        ADM_DEPTPAN.Controls.Add(Adm_Dept_DeptID_lbl)
        ADM_DEPTPAN.Controls.Add(Adm_Dept_DeptID_Mtxt)
        ADM_DEPTPAN.Controls.Add(Adm_Dept_Del_btn)
        ADM_DEPTPAN.Controls.Add(Adm_Dept_Edit_btn)
        ADM_DEPTPAN.Controls.Add(Adm_Dept_BPan)
        ADM_DEPTPAN.Controls.Add(Adm_Dept_BPan2)
        ADM_DEPTPAN.Controls.Add(Adm_Dept_Entry_lbl)
        ADM_DEPTPAN.Controls.Add(Adm_Dept_DGV)
        ADM_DEPTPAN.Controls.Add(Adm_DeptTitle_lbl)
        ADM_DEPTPAN.Controls.Add(Adm_design)
        ADM_DEPTPAN.Controls.Add(Adm_Dept_DateTime_lbl)
        ADM_DEPTPAN.Location = New Point(17, 25)
        ADM_DEPTPAN.Name = "ADM_DEPTPAN"
        ADM_DEPTPAN.Size = New Size(1515, 793)
        ADM_DEPTPAN.TabIndex = 3
        ' 
        ' Adm_Dept_Clear_btn
        ' 
        Adm_Dept_Clear_btn.BackColor = Color.Orange
        Adm_Dept_Clear_btn.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Dept_Clear_btn.ForeColor = SystemColors.ButtonHighlight
        Adm_Dept_Clear_btn.Location = New Point(1303, 664)
        Adm_Dept_Clear_btn.Name = "Adm_Dept_Clear_btn"
        Adm_Dept_Clear_btn.Size = New Size(151, 60)
        Adm_Dept_Clear_btn.TabIndex = 63
        Adm_Dept_Clear_btn.Text = "CLEAR"
        Adm_Dept_Clear_btn.UseVisualStyleBackColor = False
        ' 
        ' Adm_Dept_Add_brn
        ' 
        Adm_Dept_Add_brn.BackColor = Color.ForestGreen
        Adm_Dept_Add_brn.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Dept_Add_brn.ForeColor = SystemColors.ButtonHighlight
        Adm_Dept_Add_brn.Location = New Point(1137, 664)
        Adm_Dept_Add_brn.Name = "Adm_Dept_Add_brn"
        Adm_Dept_Add_brn.Size = New Size(151, 60)
        Adm_Dept_Add_brn.TabIndex = 62
        Adm_Dept_Add_brn.Text = "ADD"
        Adm_Dept_Add_brn.UseVisualStyleBackColor = False
        ' 
        ' Adm_Dept_Suffix_txt
        ' 
        Adm_Dept_Suffix_txt.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Dept_Suffix_txt.Location = New Point(1137, 590)
        Adm_Dept_Suffix_txt.Name = "Adm_Dept_Suffix_txt"
        Adm_Dept_Suffix_txt.Size = New Size(151, 39)
        Adm_Dept_Suffix_txt.TabIndex = 61
        ' 
        ' Adm_Dept_Suffix_lbl
        ' 
        Adm_Dept_Suffix_lbl.AutoSize = True
        Adm_Dept_Suffix_lbl.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Dept_Suffix_lbl.Location = New Point(1137, 561)
        Adm_Dept_Suffix_lbl.Name = "Adm_Dept_Suffix_lbl"
        Adm_Dept_Suffix_lbl.Size = New Size(147, 27)
        Adm_Dept_Suffix_lbl.TabIndex = 60
        Adm_Dept_Suffix_lbl.Text = "Head Suffix:"
        Adm_Dept_Suffix_lbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Adm_Dept_MName_txt
        ' 
        Adm_Dept_MName_txt.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Dept_MName_txt.Location = New Point(884, 590)
        Adm_Dept_MName_txt.Name = "Adm_Dept_MName_txt"
        Adm_Dept_MName_txt.Size = New Size(228, 39)
        Adm_Dept_MName_txt.TabIndex = 59
        ' 
        ' Adm_Dept_MName_lbl
        ' 
        Adm_Dept_MName_lbl.AutoSize = True
        Adm_Dept_MName_lbl.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Dept_MName_lbl.Location = New Point(884, 561)
        Adm_Dept_MName_lbl.Name = "Adm_Dept_MName_lbl"
        Adm_Dept_MName_lbl.Size = New Size(228, 27)
        Adm_Dept_MName_lbl.TabIndex = 58
        Adm_Dept_MName_lbl.Text = "Head Middle Name:"
        Adm_Dept_MName_lbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Adm_Dept_Name_txt
        ' 
        Adm_Dept_Name_txt.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Dept_Name_txt.Location = New Point(62, 677)
        Adm_Dept_Name_txt.Name = "Adm_Dept_Name_txt"
        Adm_Dept_Name_txt.Size = New Size(797, 39)
        Adm_Dept_Name_txt.TabIndex = 55
        ' 
        ' Adm_Dept_FName_txt
        ' 
        Adm_Dept_FName_txt.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Dept_FName_txt.Location = New Point(502, 590)
        Adm_Dept_FName_txt.Name = "Adm_Dept_FName_txt"
        Adm_Dept_FName_txt.Size = New Size(357, 39)
        Adm_Dept_FName_txt.TabIndex = 54
        ' 
        ' Adm_Dept_LName_txt
        ' 
        Adm_Dept_LName_txt.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Dept_LName_txt.Location = New Point(273, 590)
        Adm_Dept_LName_txt.Name = "Adm_Dept_LName_txt"
        Adm_Dept_LName_txt.Size = New Size(203, 39)
        Adm_Dept_LName_txt.TabIndex = 53
        ' 
        ' Adm_Dept_Name_lbl
        ' 
        Adm_Dept_Name_lbl.AutoSize = True
        Adm_Dept_Name_lbl.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Dept_Name_lbl.Location = New Point(62, 649)
        Adm_Dept_Name_lbl.Name = "Adm_Dept_Name_lbl"
        Adm_Dept_Name_lbl.Size = New Size(223, 27)
        Adm_Dept_Name_lbl.TabIndex = 52
        Adm_Dept_Name_lbl.Text = "Department Name:"
        Adm_Dept_Name_lbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Adm_Dept_FName_lbl
        ' 
        Adm_Dept_FName_lbl.AutoSize = True
        Adm_Dept_FName_lbl.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Dept_FName_lbl.Location = New Point(502, 561)
        Adm_Dept_FName_lbl.Name = "Adm_Dept_FName_lbl"
        Adm_Dept_FName_lbl.Size = New Size(205, 27)
        Adm_Dept_FName_lbl.TabIndex = 50
        Adm_Dept_FName_lbl.Text = "Head First Name:"
        Adm_Dept_FName_lbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Adm_Dept_LName_lbl
        ' 
        Adm_Dept_LName_lbl.AutoSize = True
        Adm_Dept_LName_lbl.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Dept_LName_lbl.Location = New Point(273, 561)
        Adm_Dept_LName_lbl.Name = "Adm_Dept_LName_lbl"
        Adm_Dept_LName_lbl.Size = New Size(203, 27)
        Adm_Dept_LName_lbl.TabIndex = 49
        Adm_Dept_LName_lbl.Text = "Head Last Name:"
        Adm_Dept_LName_lbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Adm_Dept_DeptID_lbl
        ' 
        Adm_Dept_DeptID_lbl.AutoSize = True
        Adm_Dept_DeptID_lbl.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Dept_DeptID_lbl.Location = New Point(62, 561)
        Adm_Dept_DeptID_lbl.Name = "Adm_Dept_DeptID_lbl"
        Adm_Dept_DeptID_lbl.Size = New Size(182, 27)
        Adm_Dept_DeptID_lbl.TabIndex = 47
        Adm_Dept_DeptID_lbl.Text = "Department ID:"
        Adm_Dept_DeptID_lbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Adm_Dept_DeptID_Mtxt
        ' 
        Adm_Dept_DeptID_Mtxt.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Dept_DeptID_Mtxt.Location = New Point(62, 590)
        Adm_Dept_DeptID_Mtxt.Mask = "D000"
        Adm_Dept_DeptID_Mtxt.Name = "Adm_Dept_DeptID_Mtxt"
        Adm_Dept_DeptID_Mtxt.Size = New Size(186, 39)
        Adm_Dept_DeptID_Mtxt.TabIndex = 46
        ' 
        ' Adm_Dept_Del_btn
        ' 
        Adm_Dept_Del_btn.BackColor = Color.DarkRed
        Adm_Dept_Del_btn.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Dept_Del_btn.ForeColor = SystemColors.ButtonHighlight
        Adm_Dept_Del_btn.Location = New Point(1303, 464)
        Adm_Dept_Del_btn.Name = "Adm_Dept_Del_btn"
        Adm_Dept_Del_btn.Size = New Size(151, 60)
        Adm_Dept_Del_btn.TabIndex = 17
        Adm_Dept_Del_btn.Text = "DELETE"
        Adm_Dept_Del_btn.UseVisualStyleBackColor = False
        ' 
        ' Adm_Dept_Edit_btn
        ' 
        Adm_Dept_Edit_btn.BackColor = Color.Navy
        Adm_Dept_Edit_btn.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Dept_Edit_btn.ForeColor = SystemColors.ButtonHighlight
        Adm_Dept_Edit_btn.Location = New Point(1137, 464)
        Adm_Dept_Edit_btn.Name = "Adm_Dept_Edit_btn"
        Adm_Dept_Edit_btn.Size = New Size(151, 60)
        Adm_Dept_Edit_btn.TabIndex = 16
        Adm_Dept_Edit_btn.Text = "EDIT"
        Adm_Dept_Edit_btn.UseVisualStyleBackColor = False
        ' 
        ' Adm_Dept_BPan
        ' 
        Adm_Dept_BPan.BackColor = Color.Black
        Adm_Dept_BPan.Location = New Point(51, 526)
        Adm_Dept_BPan.Name = "Adm_Dept_BPan"
        Adm_Dept_BPan.Size = New Size(1054, 10)
        Adm_Dept_BPan.TabIndex = 15
        ' 
        ' Adm_Dept_BPan2
        ' 
        Adm_Dept_BPan2.BackColor = Color.Black
        Adm_Dept_BPan2.Location = New Point(51, 450)
        Adm_Dept_BPan2.Name = "Adm_Dept_BPan2"
        Adm_Dept_BPan2.Size = New Size(1054, 10)
        Adm_Dept_BPan2.TabIndex = 14
        ' 
        ' Adm_Dept_Entry_lbl
        ' 
        Adm_Dept_Entry_lbl.AutoSize = True
        Adm_Dept_Entry_lbl.Font = New Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Dept_Entry_lbl.Location = New Point(482, 473)
        Adm_Dept_Entry_lbl.Name = "Adm_Dept_Entry_lbl"
        Adm_Dept_Entry_lbl.Size = New Size(222, 39)
        Adm_Dept_Entry_lbl.TabIndex = 13
        Adm_Dept_Entry_lbl.Text = "NEW ENTRY"
        ' 
        ' Adm_Dept_DGV
        ' 
        Adm_Dept_DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Adm_Dept_DGV.Columns.AddRange(New DataGridViewColumn() {Adm_DeptID_col, Adm_DeptName_col, Adm_Dept_LName_col, Adm_Dept_FName_col, Adm_Dept_MName_col, Adm_Dept_Suffix_col})
        Adm_Dept_DGV.Location = New Point(51, 182)
        Adm_Dept_DGV.Name = "Adm_Dept_DGV"
        Adm_Dept_DGV.RowHeadersWidth = 51
        Adm_Dept_DGV.Size = New Size(1403, 252)
        Adm_Dept_DGV.TabIndex = 11
        ' 
        ' Adm_DeptID_col
        ' 
        Adm_DeptID_col.HeaderText = "DEPARTMENT ID"
        Adm_DeptID_col.MinimumWidth = 6
        Adm_DeptID_col.Name = "Adm_DeptID_col"
        Adm_DeptID_col.Width = 225
        ' 
        ' Adm_DeptName_col
        ' 
        Adm_DeptName_col.HeaderText = "DEPARTMENT NAME"
        Adm_DeptName_col.MinimumWidth = 6
        Adm_DeptName_col.Name = "Adm_DeptName_col"
        Adm_DeptName_col.Width = 225
        ' 
        ' Adm_Dept_LName_col
        ' 
        Adm_Dept_LName_col.HeaderText = "HEAD LAST NAME"
        Adm_Dept_LName_col.MinimumWidth = 6
        Adm_Dept_LName_col.Name = "Adm_Dept_LName_col"
        Adm_Dept_LName_col.Width = 225
        ' 
        ' Adm_Dept_FName_col
        ' 
        Adm_Dept_FName_col.HeaderText = "HEAD FIRST NAME"
        Adm_Dept_FName_col.MinimumWidth = 6
        Adm_Dept_FName_col.Name = "Adm_Dept_FName_col"
        Adm_Dept_FName_col.Width = 225
        ' 
        ' Adm_Dept_MName_col
        ' 
        Adm_Dept_MName_col.HeaderText = "HEAD MIDDLE NAME"
        Adm_Dept_MName_col.MinimumWidth = 6
        Adm_Dept_MName_col.Name = "Adm_Dept_MName_col"
        Adm_Dept_MName_col.Width = 225
        ' 
        ' Adm_Dept_Suffix_col
        ' 
        Adm_Dept_Suffix_col.HeaderText = "HEAD SUFFIX"
        Adm_Dept_Suffix_col.MinimumWidth = 6
        Adm_Dept_Suffix_col.Name = "Adm_Dept_Suffix_col"
        Adm_Dept_Suffix_col.Width = 225
        ' 
        ' Adm_DeptTitle_lbl
        ' 
        Adm_DeptTitle_lbl.Font = New Font("Times New Roman", 54F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Adm_DeptTitle_lbl.Location = New Point(96, 22)
        Adm_DeptTitle_lbl.Name = "Adm_DeptTitle_lbl"
        Adm_DeptTitle_lbl.Size = New Size(732, 105)
        Adm_DeptTitle_lbl.TabIndex = 10
        Adm_DeptTitle_lbl.Text = "DEPARTMENTS"
        ' 
        ' Adm_design
        ' 
        Adm_design.BackColor = Color.Navy
        Adm_design.Location = New Point(51, 41)
        Adm_design.Name = "Adm_design"
        Adm_design.Size = New Size(39, 72)
        Adm_design.TabIndex = 9
        ' 
        ' Adm_Dept_DateTime_lbl
        ' 
        Adm_Dept_DateTime_lbl.Font = New Font("Rockwell", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Adm_Dept_DateTime_lbl.Location = New Point(735, 32)
        Adm_Dept_DateTime_lbl.Name = "Adm_Dept_DateTime_lbl"
        Adm_Dept_DateTime_lbl.Size = New Size(695, 49)
        Adm_Dept_DateTime_lbl.TabIndex = 3
        ' 
        ' FuncSideBar_Panel
        ' 
        FuncSideBar_Panel.BackColor = SystemColors.Info
        FuncSideBar_Panel.Controls.Add(SideCon_BASE)
        FuncSideBar_Panel.Dock = DockStyle.Left
        FuncSideBar_Panel.Location = New Point(0, 0)
        FuncSideBar_Panel.Name = "FuncSideBar_Panel"
        FuncSideBar_Panel.Size = New Size(354, 830)
        FuncSideBar_Panel.TabIndex = 16
        ' 
        ' SideCon_BASE
        ' 
        SideCon_BASE.BackColor = Color.Orange
        SideCon_BASE.Controls.Add(FuncSidePanel_OUTER)
        SideCon_BASE.Location = New Point(0, 30)
        SideCon_BASE.Name = "SideCon_BASE"
        SideCon_BASE.Size = New Size(325, 780)
        SideCon_BASE.TabIndex = 16
        ' 
        ' FuncSidePanel_OUTER
        ' 
        FuncSidePanel_OUTER.Controls.Add(FuncSidePanel_INNER)
        FuncSidePanel_OUTER.Dock = DockStyle.Fill
        FuncSidePanel_OUTER.Location = New Point(0, 0)
        FuncSidePanel_OUTER.Name = "FuncSidePanel_OUTER"
        FuncSidePanel_OUTER.Size = New Size(325, 780)
        FuncSidePanel_OUTER.TabIndex = 1
        ' 
        ' FuncSidePanel_INNER
        ' 
        FuncSidePanel_INNER.Controls.Add(FuncIntPnl)
        FuncSidePanel_INNER.Controls.Add(FuncSupPnl)
        FuncSidePanel_INNER.Controls.Add(FuncComPnl)
        FuncSidePanel_INNER.Controls.Add(FuncCoursePnl)
        FuncSidePanel_INNER.Controls.Add(FuncDepPnl)
        FuncSidePanel_INNER.Controls.Add(FuncFacPnl)
        FuncSidePanel_INNER.Controls.Add(FuncStudPnl)
        FuncSidePanel_INNER.Location = New Point(-30, 32)
        FuncSidePanel_INNER.Name = "FuncSidePanel_INNER"
        FuncSidePanel_INNER.Size = New Size(326, 721)
        FuncSidePanel_INNER.TabIndex = 0
        ' 
        ' FuncIntPnl
        ' 
        FuncIntPnl.Controls.Add(FuncIntLink)
        FuncIntPnl.Location = New Point(3, 624)
        FuncIntPnl.Name = "FuncIntPnl"
        FuncIntPnl.Size = New Size(307, 61)
        FuncIntPnl.TabIndex = 6
        ' 
        ' FuncIntLink
        ' 
        FuncIntLink.AutoSize = True
        FuncIntLink.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FuncIntLink.LinkColor = Color.White
        FuncIntLink.Location = New Point(66, 16)
        FuncIntLink.Name = "FuncIntLink"
        FuncIntLink.Size = New Size(209, 32)
        FuncIntLink.TabIndex = 0
        FuncIntLink.TabStop = True
        FuncIntLink.Text = "INTERNSHIPS"
        ' 
        ' FuncSupPnl
        ' 
        FuncSupPnl.Controls.Add(FuncSupLink)
        FuncSupPnl.Location = New Point(3, 527)
        FuncSupPnl.Name = "FuncSupPnl"
        FuncSupPnl.Size = New Size(307, 61)
        FuncSupPnl.TabIndex = 5
        ' 
        ' FuncSupLink
        ' 
        FuncSupLink.AutoSize = True
        FuncSupLink.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FuncSupLink.LinkColor = Color.White
        FuncSupLink.Location = New Point(60, 16)
        FuncSupLink.Name = "FuncSupLink"
        FuncSupLink.Size = New Size(220, 32)
        FuncSupLink.TabIndex = 0
        FuncSupLink.TabStop = True
        FuncSupLink.Text = "SUPERVISORS"
        ' 
        ' FuncComPnl
        ' 
        FuncComPnl.Controls.Add(FuncComLink)
        FuncComPnl.Location = New Point(3, 430)
        FuncComPnl.Name = "FuncComPnl"
        FuncComPnl.Size = New Size(307, 61)
        FuncComPnl.TabIndex = 4
        ' 
        ' FuncComLink
        ' 
        FuncComLink.AutoSize = True
        FuncComLink.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FuncComLink.LinkColor = Color.White
        FuncComLink.Location = New Point(76, 16)
        FuncComLink.Name = "FuncComLink"
        FuncComLink.Size = New Size(187, 32)
        FuncComLink.TabIndex = 0
        FuncComLink.TabStop = True
        FuncComLink.Text = "COMPANIES"
        ' 
        ' FuncCoursePnl
        ' 
        FuncCoursePnl.Controls.Add(FuncCourseLink)
        FuncCoursePnl.Location = New Point(3, 333)
        FuncCoursePnl.Name = "FuncCoursePnl"
        FuncCoursePnl.Size = New Size(307, 61)
        FuncCoursePnl.TabIndex = 3
        ' 
        ' FuncCourseLink
        ' 
        FuncCourseLink.AutoSize = True
        FuncCourseLink.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FuncCourseLink.LinkColor = Color.White
        FuncCourseLink.Location = New Point(91, 16)
        FuncCourseLink.Name = "FuncCourseLink"
        FuncCourseLink.Size = New Size(155, 32)
        FuncCourseLink.TabIndex = 0
        FuncCourseLink.TabStop = True
        FuncCourseLink.Text = "COURSES"
        ' 
        ' FuncDepPnl
        ' 
        FuncDepPnl.Controls.Add(FuncDepLink)
        FuncDepPnl.Location = New Point(3, 235)
        FuncDepPnl.Name = "FuncDepPnl"
        FuncDepPnl.Size = New Size(307, 61)
        FuncDepPnl.TabIndex = 2
        ' 
        ' FuncDepLink
        ' 
        FuncDepLink.AutoSize = True
        FuncDepLink.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FuncDepLink.LinkColor = Color.White
        FuncDepLink.Location = New Point(56, 16)
        FuncDepLink.Name = "FuncDepLink"
        FuncDepLink.Size = New Size(231, 32)
        FuncDepLink.TabIndex = 0
        FuncDepLink.TabStop = True
        FuncDepLink.Text = "DEPARTMENTS"
        ' 
        ' FuncFacPnl
        ' 
        FuncFacPnl.Controls.Add(FuncFacLink)
        FuncFacPnl.Location = New Point(3, 138)
        FuncFacPnl.Name = "FuncFacPnl"
        FuncFacPnl.Size = New Size(307, 61)
        FuncFacPnl.TabIndex = 1
        ' 
        ' FuncFacLink
        ' 
        FuncFacLink.AutoSize = True
        FuncFacLink.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FuncFacLink.LinkColor = Color.White
        FuncFacLink.Location = New Point(96, 16)
        FuncFacLink.Name = "FuncFacLink"
        FuncFacLink.Size = New Size(146, 32)
        FuncFacLink.TabIndex = 0
        FuncFacLink.TabStop = True
        FuncFacLink.Text = "FACULTY"
        ' 
        ' FuncStudPnl
        ' 
        FuncStudPnl.Controls.Add(FuncStudLink)
        FuncStudPnl.Location = New Point(4, 40)
        FuncStudPnl.Name = "FuncStudPnl"
        FuncStudPnl.Size = New Size(306, 61)
        FuncStudPnl.TabIndex = 0
        ' 
        ' FuncStudLink
        ' 
        FuncStudLink.AutoSize = True
        FuncStudLink.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FuncStudLink.LinkColor = Color.White
        FuncStudLink.Location = New Point(85, 16)
        FuncStudLink.Name = "FuncStudLink"
        FuncStudLink.Size = New Size(170, 32)
        FuncStudLink.TabIndex = 0
        FuncStudLink.TabStop = True
        FuncStudLink.Text = "STUDENTS"
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
        MainMenu_Panel.TabIndex = 14
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
        RightTop_Panel.Controls.Add(Logout_BTN)
        RightTop_Panel.Controls.Add(Dashboard_BTN)
        RightTop_Panel.Controls.Add(Functions_BTN)
        RightTop_Panel.Dock = DockStyle.Right
        RightTop_Panel.Location = New Point(902, 0)
        RightTop_Panel.Name = "RightTop_Panel"
        RightTop_Panel.Size = New Size(1000, 225)
        RightTop_Panel.TabIndex = 11
        ' 
        ' Logout_BTN
        ' 
        Logout_BTN.ActiveLinkColor = Color.Goldenrod
        Logout_BTN.BackColor = Color.Navy
        Logout_BTN.Font = New Font("Arial Rounded MT Bold", 16.2F)
        Logout_BTN.LinkColor = Color.White
        Logout_BTN.Location = New Point(775, 131)
        Logout_BTN.Name = "Logout_BTN"
        Logout_BTN.Size = New Size(159, 36)
        Logout_BTN.TabIndex = 9
        Logout_BTN.TabStop = True
        Logout_BTN.Text = "LOGOUT"
        Logout_BTN.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Dashboard_BTN
        ' 
        Dashboard_BTN.ActiveLinkColor = Color.Goldenrod
        Dashboard_BTN.BackColor = Color.Navy
        Dashboard_BTN.Font = New Font("Arial Rounded MT Bold", 16.2F)
        Dashboard_BTN.LinkColor = Color.White
        Dashboard_BTN.Location = New Point(353, 131)
        Dashboard_BTN.Name = "Dashboard_BTN"
        Dashboard_BTN.Size = New Size(203, 36)
        Dashboard_BTN.TabIndex = 0
        Dashboard_BTN.TabStop = True
        Dashboard_BTN.Text = "DASHBOARD"
        Dashboard_BTN.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Functions_BTN
        ' 
        Functions_BTN.ActiveLinkColor = Color.Goldenrod
        Functions_BTN.BackColor = Color.Navy
        Functions_BTN.Font = New Font("Arial Rounded MT Bold", 16.2F)
        Functions_BTN.LinkColor = Color.White
        Functions_BTN.Location = New Point(553, 131)
        Functions_BTN.Name = "Functions_BTN"
        Functions_BTN.Size = New Size(233, 36)
        Functions_BTN.TabIndex = 8
        Functions_BTN.TabStop = True
        Functions_BTN.Text = "FUNCTIONS"
        Functions_BTN.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 1000
        ' 
        ' FuncSidePan_INNER
        ' 
        FuncSidePan_INNER.BorderStyle = BorderStyle.Fixed3D
        FuncSidePan_INNER.Controls.Add(Panel6)
        FuncSidePan_INNER.Location = New Point(25, 28)
        FuncSidePan_INNER.Name = "FuncSidePan_INNER"
        FuncSidePan_INNER.Size = New Size(334, 680)
        FuncSidePan_INNER.TabIndex = 1
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.White
        Panel6.Controls.Add(LinkLabel5)
        Panel6.Location = New Point(3, 30)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(331, 63)
        Panel6.TabIndex = 15
        ' 
        ' LinkLabel5
        ' 
        LinkLabel5.ActiveLinkColor = Color.Goldenrod
        LinkLabel5.BackColor = SystemColors.Control
        LinkLabel5.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LinkLabel5.ForeColor = SystemColors.ActiveCaptionText
        LinkLabel5.LinkColor = Color.Black
        LinkLabel5.Location = New Point(63, 14)
        LinkLabel5.Name = "LinkLabel5"
        LinkLabel5.Size = New Size(215, 70)
        LinkLabel5.TabIndex = 11
        LinkLabel5.TabStop = True
        LinkLabel5.Text = "STUDENT" & vbCrLf & "EVALUATION"
        LinkLabel5.TextAlign = ContentAlignment.BottomCenter
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
        Home_Panel.ResumeLayout(False)
        Content_Panel.ResumeLayout(False)
        Dashboard_Panel.ResumeLayout(False)
        Container_Panel.ResumeLayout(False)
        Stud_Eval_Panel.ResumeLayout(False)
        CType(SE_DGV, ComponentModel.ISupportInitialize).EndInit()
        PE_Panel.ResumeLayout(False)
        PE_Panel.PerformLayout()
        Visit_LogPanel.ResumeLayout(False)
        CType(VL_DGV, ComponentModel.ISupportInitialize).EndInit()
        Fac_Eval_Panel.ResumeLayout(False)
        Fac_Eval_Panel.PerformLayout()
        CType(FE_DGV, ComponentModel.ISupportInitialize).EndInit()
        Stud_Regis_Panel.ResumeLayout(False)
        Stud_Regis_Panel.PerformLayout()
        CType(SR_DGV, ComponentModel.ISupportInitialize).EndInit()
        Partner_Comp_Panel.ResumeLayout(False)
        CType(PC_DGV, ComponentModel.ISupportInitialize).EndInit()
        DashSideFunc.ResumeLayout(False)
        DashSide_OUTER.ResumeLayout(False)
        DashSide_INNER.ResumeLayout(False)
        VL_BackPan.ResumeLayout(False)
        FE_BackPan.ResumeLayout(False)
        PC_BackPan.ResumeLayout(False)
        SR_BackPan.ResumeLayout(False)
        SE_BackPan.ResumeLayout(False)
        Function_Panel.ResumeLayout(False)
        Func_Container.ResumeLayout(False)
        ADM_STUDPAN.ResumeLayout(False)
        ADM_STUDPAN.PerformLayout()
        CType(STUD_DGV, ComponentModel.ISupportInitialize).EndInit()
        ADM_FACPAN.ResumeLayout(False)
        ADM_FACPAN.PerformLayout()
        CType(FAC_DGV, ComponentModel.ISupportInitialize).EndInit()
        ADM_INTERPAN.ResumeLayout(False)
        ADM_INTERPAN.PerformLayout()
        CType(Adm_Intern_DGV, ComponentModel.ISupportInitialize).EndInit()
        ADM_SUPERPAN.ResumeLayout(False)
        ADM_SUPERPAN.PerformLayout()
        CType(Adm_Sup_DGV, ComponentModel.ISupportInitialize).EndInit()
        ADM_COMPAN.ResumeLayout(False)
        ADM_COMPAN.PerformLayout()
        CType(Adm_Comp_DGV, ComponentModel.ISupportInitialize).EndInit()
        ADM_COURSEPAN.ResumeLayout(False)
        ADM_COURSEPAN.PerformLayout()
        CType(Adm_Course_DGV, ComponentModel.ISupportInitialize).EndInit()
        ADM_DEPTPAN.ResumeLayout(False)
        ADM_DEPTPAN.PerformLayout()
        CType(Adm_Dept_DGV, ComponentModel.ISupportInitialize).EndInit()
        FuncSideBar_Panel.ResumeLayout(False)
        SideCon_BASE.ResumeLayout(False)
        FuncSidePanel_OUTER.ResumeLayout(False)
        FuncSidePanel_INNER.ResumeLayout(False)
        FuncIntPnl.ResumeLayout(False)
        FuncIntPnl.PerformLayout()
        FuncSupPnl.ResumeLayout(False)
        FuncSupPnl.PerformLayout()
        FuncComPnl.ResumeLayout(False)
        FuncComPnl.PerformLayout()
        FuncCoursePnl.ResumeLayout(False)
        FuncCoursePnl.PerformLayout()
        FuncDepPnl.ResumeLayout(False)
        FuncDepPnl.PerformLayout()
        FuncFacPnl.ResumeLayout(False)
        FuncFacPnl.PerformLayout()
        FuncStudPnl.ResumeLayout(False)
        FuncStudPnl.PerformLayout()
        MainMenu_Panel.ResumeLayout(False)
        SchoolTitle_Panel.ResumeLayout(False)
        CType(Logo_Pic, ComponentModel.ISupportInitialize).EndInit()
        RightTop_Panel.ResumeLayout(False)
        FuncSidePan_INNER.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents Screen_Panel As Panel
    Friend WithEvents Home_Panel As Panel
    Friend WithEvents MainMenu_Panel As Panel
    Friend WithEvents SchoolTitle_Panel As Panel
    Friend WithEvents Logo_Pic As PictureBox
    Friend WithEvents SchoolName_Lbl As Label
    Friend WithEvents RightTop_Panel As Panel
    Friend WithEvents Dashboard_BTN As LinkLabel
    Friend WithEvents Functions_BTN As LinkLabel
    Friend WithEvents FuncSide_Panel As Panel
    Friend WithEvents Content_Panel As Panel
    Friend WithEvents SideBar_Panel As Panel
    Friend WithEvents SideFunction_Panel As Panel
    Friend WithEvents Student_Eval_LinkLbl As LinkLabel
    Friend WithEvents Adm_Sel1_Panel As Panel
    Friend WithEvents Adm_Sel4_Panel As Panel
    Friend WithEvents Fac_Eval_Linklbl As LinkLabel
    Friend WithEvents Adm_Sel3_Panel As Panel
    Friend WithEvents Partner_Comp_Linklbl As LinkLabel
    Friend WithEvents Adm_Sel2_Panel As Panel
    Friend WithEvents Stud_Regis_Linklbl As LinkLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Function_Panel As Panel
    Friend WithEvents Dashboard_Panel As Panel
    Friend WithEvents Logout_BTN As LinkLabel
    Friend WithEvents Func_Container As Panel
    Friend WithEvents FuncSideBar_Panel As Panel
    Friend WithEvents SideCon_BASE As Panel
    Friend WithEvents FuncSidePan_BASE As Panel
    Friend WithEvents FuncSidePan_OUTER As Panel
    Friend WithEvents LinkLabel5 As LinkLabel
    Friend WithEvents FuncSidePan_INNER As Panel
    Friend WithEvents FuncCoursePnl As Panel
    Friend WithEvents FuncStudLink As LinkLabel
    Friend WithEvents FuncComPnl As Panel
    Friend WithEvents FuncFacLink As LinkLabel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents FuncDepLink As LinkLabel
    Friend WithEvents FuncSupPnl As Panel
    Friend WithEvents FuncCourseLink As LinkLabel
    Friend WithEvents FuncSidePanel_OUTER As Panel
    Friend WithEvents FuncSidePanel_INNER As Panel
    Friend WithEvents FuncStudPnl As Panel
    Friend WithEvents FuncComLink As LinkLabel
    Friend WithEvents FuncDepPnl As Panel
    Friend WithEvents FuncFacPnl As Panel
    Friend WithEvents FuncIntPnl As Panel
    Friend WithEvents FuncIntLink As LinkLabel
    Friend WithEvents FuncSupLink As LinkLabel
    Friend WithEvents DashSideFunc As Panel
    Friend WithEvents DashSide_OUTER As Panel
    Friend WithEvents DashSide_INNER As Panel
    Friend WithEvents VL_BackPan As Panel
    Friend WithEvents VL_LinkLbl As LinkLabel
    Friend WithEvents FE_BackPan As Panel
    Friend WithEvents FE_LinkLbl As LinkLabel
    Friend WithEvents PC_BackPan As Panel
    Friend WithEvents PC_LinkLbl As LinkLabel
    Friend WithEvents SR_BackPan As Panel
    Friend WithEvents SR_LinkLbl As LinkLabel
    Friend WithEvents SE_BackPan As Panel
    Friend WithEvents SE_LinkLbl As LinkLabel
    Friend WithEvents Container_Panel As Panel
    Friend WithEvents Visit_LogPanel As Panel
    Friend WithEvents Stud_Eval_Panel As Panel
    Friend WithEvents Adm_User_lbl As Label
    Friend WithEvents SRegis_DateTime As Label
    Friend WithEvents Fac_Eval_Panel As Panel
    Friend WithEvents FEval_DateTime As Label
    Friend WithEvents Partner_Comp_Panel As Panel
    Friend WithEvents PComp_DateTime As Label
    Friend WithEvents Stud_Regis_Panel As Panel
    Friend WithEvents SEval_DateTime As Label
    Friend WithEvents ADM_INTERPAN As Panel
    Friend WithEvents Adm_Intern_DateTime_lbl As Label
    Friend WithEvents ADM_SUPERPAN As Panel
    Friend WithEvents Adm_Sup_DateTime_lbl As Label
    Friend WithEvents ADM_COMPAN As Panel
    Friend WithEvents Adm_Comp_DateTime_lbl As Label
    Friend WithEvents ADM_COURSEPAN As Panel
    Friend WithEvents Adm_Course_DateTime_lbl As Label
    Friend WithEvents ADM_DEPTPAN As Panel
    Friend WithEvents Adm_Dept_DateTime_lbl As Label
    Friend WithEvents ADM_FACPAN As Panel
    Friend WithEvents Adm_func_FacDateTime_lbl As Label
    Friend WithEvents ADM_STUDPAN As Panel
    Friend WithEvents STUD_Lbl As Label
    Friend WithEvents Adm_Func_StudDateTime_lbl As Label
    Friend WithEvents FuncStudSPan As Panel
    Friend WithEvents STUD_DGV As DataGridView
    Friend WithEvents FuncStud_NewEnt As Label
    Friend WithEvents StudBot_Pnl As Panel
    Friend WithEvents StudTop_Pnl As Panel
    Friend WithEvents STUD_DelBtn As Button
    Friend WithEvents STUD_EdBtn As Button
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents Stud_SecLbl As Label
    Friend WithEvents Stud_StudIDPnl As Label
    Friend WithEvents Stud_SufLbl As Label
    Friend WithEvents Stud_MidLbl As Label
    Friend WithEvents Stud_FirstLbl As Label
    Friend WithEvents Stud_LastLbl As Label
    Friend WithEvents Stud_SemLbl As Label
    Friend WithEvents Stud_CourseLbl As Label
    Friend WithEvents Stud_MidTB As TextBox
    Friend WithEvents Stud_FirstTB As TextBox
    Friend WithEvents Stud_LastTB As TextBox
    Friend WithEvents Stud_ConLbl As Label
    Friend WithEvents Stud_ConMTB As MaskedTextBox
    Friend WithEvents Stud_EmLbl As Label
    Friend WithEvents STUD_ClrBtn As Button
    Friend WithEvents STUD_AddBtn As Button
    Friend WithEvents Stud_EmailTB As TextBox
    Friend WithEvents Stud_SuffixTB As TextBox
    Friend WithEvents Stud_SecCmb As ComboBox
    Friend WithEvents Stud_SemCmb As ComboBox
    Friend WithEvents Stud_CourseCmb As ComboBox
    Friend WithEvents Fac_SidePnl As Panel
    Friend WithEvents FAC_Lbl As Label
    Friend WithEvents Adm_DeptTitle_lbl As Label
    Friend WithEvents Adm_design As Panel
    Friend WithEvents FAC_DGV As DataGridView
    Friend WithEvents FAC_DelBtn As Button
    Friend WithEvents FAC_EdBtn As Button
    Friend WithEvents Fac_BotPnl As Panel
    Friend WithEvents Fac_TopPnl As Panel
    Friend WithEvents Fac_NewEntLbl As Label
    Friend WithEvents Fac_EmailTB As TextBox
    Friend WithEvents Fac_FirstNTB As TextBox
    Friend WithEvents Fac_LastNTB As TextBox
    Friend WithEvents Fac_EmailLbl As Label
    Friend WithEvents Fac_DeptLbl As Label
    Friend WithEvents Fac_FirstNLbl As Label
    Friend WithEvents Fac_LastNLbl As Label
    Friend WithEvents Fac_FIDLbl As Label
    Friend WithEvents Fac_DeptCmb As ComboBox
    Friend WithEvents Fac_PosLbl As Label
    Friend WithEvents Fac_SufTB As TextBox
    Friend WithEvents Fac_MidTB As TextBox
    Friend WithEvents Fac_SufLbl As Label
    Friend WithEvents Fac_MidLbl As Label
    Friend WithEvents Fac_EmpCmb As ComboBox
    Friend WithEvents Fac_EmpLbl As Label
    Friend WithEvents Fac_ConLbl As Label
    Friend WithEvents Fac_ConMTB As MaskedTextBox
    Friend WithEvents Fac_FID_MTB As MaskedTextBox
    Friend WithEvents FAC_ClrBtn As Button
    Friend WithEvents FAC_AddBtn As Button
    Friend WithEvents Adm_Dept_Del_btn As Button
    Friend WithEvents Adm_Dept_Edit_btn As Button
    Friend WithEvents Adm_Dept_BPan As Panel
    Friend WithEvents Adm_Dept_BPan2 As Panel
    Friend WithEvents Adm_Dept_Entry_lbl As Label
    Friend WithEvents Adm_Dept_DGV As DataGridView
    Friend WithEvents Adm_Dept_Name_txt As TextBox
    Friend WithEvents Adm_Dept_FName_txt As TextBox
    Friend WithEvents Adm_Dept_LName_txt As TextBox
    Friend WithEvents Adm_Dept_Name_lbl As Label
    Friend WithEvents Adm_Dept_FName_lbl As Label
    Friend WithEvents Adm_Dept_LName_lbl As Label
    Friend WithEvents Adm_Dept_DeptID_lbl As Label
    Friend WithEvents Adm_Dept_DeptID_Mtxt As MaskedTextBox
    Friend WithEvents Adm_Dept_Suffix_txt As TextBox
    Friend WithEvents Adm_Dept_Suffix_lbl As Label
    Friend WithEvents Adm_Dept_MName_txt As TextBox
    Friend WithEvents Adm_Dept_MName_lbl As Label
    Friend WithEvents Adm_Dept_Clear_btn As Button
    Friend WithEvents Adm_Dept_Add_brn As Button
    Friend WithEvents Adm_DeptID_col As DataGridViewTextBoxColumn
    Friend WithEvents Adm_DeptName_col As DataGridViewTextBoxColumn
    Friend WithEvents Adm_Dept_LName_col As DataGridViewTextBoxColumn
    Friend WithEvents Adm_Dept_FName_col As DataGridViewTextBoxColumn
    Friend WithEvents Adm_Dept_MName_col As DataGridViewTextBoxColumn
    Friend WithEvents Adm_Dept_Suffix_col As DataGridViewTextBoxColumn
    Friend WithEvents Adm_Course_DGV As DataGridView
    Friend WithEvents Adm_Course_design As Panel
    Friend WithEvents Adm_CourseTitle_lbl As Label
    Friend WithEvents Adm_Course_DeptIDDisplay_lbl As Label
    Friend WithEvents Adm_Course_Del_btn As Button
    Friend WithEvents Adm_Course_Edit_btn As Button
    Friend WithEvents Adm_Course_BPan1 As Panel
    Friend WithEvents Adm_Course_Bpan2 As Panel
    Friend WithEvents Adm_Course_newEntry_lbl As Label
    Friend WithEvents Adm_Course_DeptIDDisplay_cmb As ComboBox
    Friend WithEvents Adm_Course_CourseID_col As DataGridViewTextBoxColumn
    Friend WithEvents Adm_Course_CourseName_col As DataGridViewTextBoxColumn
    Friend WithEvents Adm_Course_CourseName_txt As TextBox
    Friend WithEvents Adm_Course_CourseName_lbl As Label
    Friend WithEvents Adm_Course_DeptID_cmb As ComboBox
    Friend WithEvents Adm_Course_DeptID_lbl As Label
    Friend WithEvents Adm_Course_CourseID_lbl As Label
    Friend WithEvents Adm_Course_CourseID_Mtxt As MaskedTextBox
    Friend WithEvents Adm_Course_Clear_btn As Button
    Friend WithEvents Adm_Course_Add_btn As Button
    Friend WithEvents Adm_Comp_DGV As DataGridView
    Friend WithEvents Adm_Comp_design As Panel
    Friend WithEvents Adm_CompTitle_lbl As Label
    Friend WithEvents Adm_Comp_CompEmail_txt As TextBox
    Friend WithEvents Adm_Comp_CompName_txt As TextBox
    Friend WithEvents Adm_Comp_CompEmail_lbl As Label
    Friend WithEvents Adm_Comp_CompName_lbl As Label
    Friend WithEvents Adm_Comp_CompID_lbl As Label
    Friend WithEvents Adm_Comp_CompID_Mtxt As MaskedTextBox
    Friend WithEvents Adm_Comp_Del_btn As Button
    Friend WithEvents Adm_Comp_Edit_btn As Button
    Friend WithEvents Adm_Comp_BPan1 As Panel
    Friend WithEvents Adm_Comp_BPan2 As Panel
    Friend WithEvents Adm_Comp_newEntry_lbl As Label
    Friend WithEvents Adm_Comp_Cont_lbl As Label
    Friend WithEvents Adm_Comp_Cont_Mtxt As MaskedTextBox
    Friend WithEvents Adm_Comp_CompAdd_txt As TextBox
    Friend WithEvents Adm_Comp_CompAdd_lbl As Label
    Friend WithEvents Adm_Comp_Clear_btn As Button
    Friend WithEvents Adm_Comp_Add_btn As Button
    Friend WithEvents Adm_Comp_CompID_col As DataGridViewTextBoxColumn
    Friend WithEvents Adm_Comp_CompName_col As DataGridViewTextBoxColumn
    Friend WithEvents Adm_Comp_CompAdd_col As DataGridViewTextBoxColumn
    Friend WithEvents Adm_Comp_CompEmail_col As DataGridViewTextBoxColumn
    Friend WithEvents Adm_Comp_CompCont_col As DataGridViewTextBoxColumn
    Friend WithEvents Adm_Sup_Comp_cmb As ComboBox
    Friend WithEvents Adm_Sup_AddAddress_txt As TextBox
    Friend WithEvents Adm_Sup_AddFName_txt As TextBox
    Friend WithEvents Adm_Sup_AddLName_txt As TextBox
    Friend WithEvents Adm_Sup_AddAddress_lbl As Label
    Friend WithEvents Adm_Sup_AddFName_lbl As Label
    Friend WithEvents Adm_Sup_AddLName_lbl As Label
    Friend WithEvents Adm_Sup_Comp_lbl As Label
    Friend WithEvents Adm_Sup_SupID_lbl As Label
    Friend WithEvents Adm_Sup_SupID_Mtxt As MaskedTextBox
    Friend WithEvents Adm_Sup_Del_btn As Button
    Friend WithEvents Adm_Sup_Edit_btn As Button
    Friend WithEvents Adm_Sup_Bpan1 As Panel
    Friend WithEvents Adm_Sup_Bpan2 As Panel
    Friend WithEvents Adm_Sup_newEntry_lbl As Label
    Friend WithEvents Adm_Sup_DGV As DataGridView
    Friend WithEvents Adm_Sup_design As Panel
    Friend WithEvents Adm_SupTitle_lbl As Label
    Friend WithEvents Adm_Sup_AddPos_txt As TextBox
    Friend WithEvents Adm_Sup_AddPos_lbl As Label
    Friend WithEvents Adm_Sup_AddSuffix_txt As TextBox
    Friend WithEvents Adm_Sup_AddMName_txt As TextBox
    Friend WithEvents Adm_Sup_AddSuffix_lbl As Label
    Friend WithEvents Adm_Sup_AddMName_lbl As Label
    Friend WithEvents Adm_Sup_Supervisor_cmb As ComboBox
    Friend WithEvents Adm_Sup_Supervisor_lbl As Label
    Friend WithEvents Adm_Sup_Clear_btn As Button
    Friend WithEvents Adm_Sup_Add_btn As Button
    Friend WithEvents Adm_Sup_AddCont_lbl As Label
    Friend WithEvents Adm_Sup_AddCont_txt As MaskedTextBox
    Friend WithEvents Fac_DGV_FID As DataGridViewTextBoxColumn
    Friend WithEvents Fac_DGV_LastN As DataGridViewTextBoxColumn
    Friend WithEvents Fac_DGV_FirstN As DataGridViewTextBoxColumn
    Friend WithEvents Fac_DGV_MidN As DataGridViewTextBoxColumn
    Friend WithEvents Fac_DGV_Suf As DataGridViewTextBoxColumn
    Friend WithEvents Fac_DGV_Dept As DataGridViewTextBoxColumn
    Friend WithEvents Fac_DGV_Pos As DataGridViewTextBoxColumn
    Friend WithEvents Fac_DGV_Emp As DataGridViewTextBoxColumn
    Friend WithEvents Fac_DGV_Email As DataGridViewTextBoxColumn
    Friend WithEvents Fac_DGV_Con As DataGridViewTextBoxColumn
    Friend WithEvents Stud_DGV_SID As DataGridViewTextBoxColumn
    Friend WithEvents Stud_DGV_LastN As DataGridViewTextBoxColumn
    Friend WithEvents Stud_DGV_FirstN As DataGridViewTextBoxColumn
    Friend WithEvents Stud_DGV_MidN As DataGridViewTextBoxColumn
    Friend WithEvents Stud_DGV_Suf As DataGridViewTextBoxColumn
    Friend WithEvents Stud_DGV_Course As DataGridViewTextBoxColumn
    Friend WithEvents Stud_DGV_Sem As DataGridViewTextBoxColumn
    Friend WithEvents Stud_DGV_Sec As DataGridViewTextBoxColumn
    Friend WithEvents Stud_DGV_Email As DataGridViewTextBoxColumn
    Friend WithEvents Stud_DGV_Con As DataGridViewTextBoxColumn
    Friend WithEvents Adm_Intern_Clear_btn As Button
    Friend WithEvents Adm_Intern_Add_btn As Button
    Friend WithEvents Adm_Intern_Bpan1 As Panel
    Friend WithEvents Adm_Intern_Bpan2 As Panel
    Friend WithEvents Adm_Intern_newEntry_lbl As Label
    Friend WithEvents Adm_Intern_DGV As DataGridView
    Friend WithEvents Adm_Intern_design As Panel
    Friend WithEvents Adm_InternTitle_lbl As Label
    Friend WithEvents Adm_Intern_AddStudID As ComboBox
    Friend WithEvents Label68 As Label
    Friend WithEvents Adm_Intern_AddStudName_txt As TextBox
    Friend WithEvents Adm_Intern_StudName_lbl As Label
    Friend WithEvents Adm_Intern_SDate_lbl As Label
    Friend WithEvents Adm_Intern_InternID_lbl As Label
    Friend WithEvents Adm_Intern_AddInternID_Mtxt As MaskedTextBox
    Friend WithEvents Adm_Intern_AddFac_cmb As ComboBox
    Friend WithEvents Adm_Intern_FacID_lbl As Label
    Friend WithEvents Adm_Intern_SupID_cmb As ComboBox
    Friend WithEvents Adm_Intern_SupID_lbl As Label
    Friend WithEvents Adm_Intern_AddCompName_txt As TextBox
    Friend WithEvents Adm_Intern_CompName_lbl As Label
    Friend WithEvents Adm_Intern_AddCompID_cmb As ComboBox
    Friend WithEvents Adm_Intern_CompID_lbl As Label
    Friend WithEvents Adm_Intern_End_dtp As DateTimePicker
    Friend WithEvents Adm_Intern_End_lbl As Label
    Friend WithEvents Adm_Intern_Start_dtp As DateTimePicker
    Friend WithEvents Adm_Intern_AddGrade_txt As TextBox
    Friend WithEvents Adm_Intern_Grade_lbl As Label
    Friend WithEvents Adm_Intern_AddEval_txt As TextBox
    Friend WithEvents Adm_Intern_Eval_lbl As Label
    Friend WithEvents Adm_Intern_AddSup_txt As TextBox
    Friend WithEvents Adm_Intern_Sup_lbl As Label
    Friend WithEvents Adm_Intern_AddStat_cmb As ComboBox
    Friend WithEvents Adm_Intern_Stat_lbl As Label
    Friend WithEvents Adm_Intern_Del_btn As Button
    Friend WithEvents Adm_Intern_Edit_btn As Button
    Friend WithEvents Adm_Intern_Intern_lbl As Label
    Friend WithEvents Adm_Sup_SupID_col As DataGridViewTextBoxColumn
    Friend WithEvents Adm_Sup_LName_col As DataGridViewTextBoxColumn
    Friend WithEvents Adm_Sup_FName_col As DataGridViewTextBoxColumn
    Friend WithEvents Adm_Sup_MName_col As DataGridViewTextBoxColumn
    Friend WithEvents Adm_Sup_Suffix_col As DataGridViewTextBoxColumn
    Friend WithEvents Adm_Sup_Email_col As DataGridViewTextBoxColumn
    Friend WithEvents Adm_Sup_ContNo_col As DataGridViewTextBoxColumn
    Friend WithEvents Adm_Sup_Pos_col As DataGridViewTextBoxColumn
    Friend WithEvents Adm_Intern_InternID_col As DataGridViewTextBoxColumn
    Friend WithEvents Adm_Intern_SY_col As DataGridViewTextBoxColumn
    Friend WithEvents Adm_Intern_StudName_col As DataGridViewTextBoxColumn
    Friend WithEvents Adm_Intern_Course_col As DataGridViewTextBoxColumn
    Friend WithEvents Adm_Intern_CompName_col As DataGridViewTextBoxColumn
    Friend WithEvents Adm_Intern_Supervisor_col As DataGridViewTextBoxColumn
    Friend WithEvents Adm_Intern_FacEval_col As DataGridViewTextBoxColumn
    Friend WithEvents Adm_Intern_StartDate_col As DataGridViewTextBoxColumn
    Friend WithEvents Adm_Intern_EndDate_col As DataGridViewTextBoxColumn
    Friend WithEvents Adm_Intern_Status_col As DataGridViewTextBoxColumn
    Friend WithEvents Adm_Intern_Grade_col As DataGridViewTextBoxColumn
    Friend WithEvents WelcomeLbl As Label
    Friend WithEvents SE_DGV As DataGridView
    Friend WithEvents PE_Panel As Panel
    Friend WithEvents PE_Lbl As Label
    Friend WithEvents SE_DGV_IntID As DataGridViewTextBoxColumn
    Friend WithEvents SE_DGV_StudName As DataGridViewTextBoxColumn
    Friend WithEvents SE_DGV_Course As DataGridViewTextBoxColumn
    Friend WithEvents SE_DGV_Section As DataGridViewTextBoxColumn
    Friend WithEvents SE_DGV_CompName As DataGridViewTextBoxColumn
    Friend WithEvents SE_DGV_SVisor As DataGridViewTextBoxColumn
    Friend WithEvents SE_DGV_FacEval As DataGridViewTextBoxColumn
    Friend WithEvents SE_DGV_Stat As DataGridViewTextBoxColumn
    Friend WithEvents SR_DGV As DataGridView
    Friend WithEvents SR_SidePnl As Panel
    Friend WithEvents SR_Lbl As Label
    Friend WithEvents SR_DeptLbl As Label
    Friend WithEvents SR_DeptCMB As ComboBox
    Friend WithEvents PC_DGV As DataGridView
    Friend WithEvents PC_SidePan As Panel
    Friend WithEvents PC_Lbl As Label
    Friend WithEvents SR_DGV_StudID As DataGridViewTextBoxColumn
    Friend WithEvents SR_DGV_LastName As DataGridViewTextBoxColumn
    Friend WithEvents SR_DGV_FirstName As DataGridViewTextBoxColumn
    Friend WithEvents SR_DGV_MiddleName As DataGridViewTextBoxColumn
    Friend WithEvents SR_DGV_Suffix As DataGridViewTextBoxColumn
    Friend WithEvents SR_DGV_Course As DataGridViewTextBoxColumn
    Friend WithEvents SR_DGV_Section As DataGridViewTextBoxColumn
    Friend WithEvents PC_DGV_CompID As DataGridViewTextBoxColumn
    Friend WithEvents PC_DGV_CompName As DataGridViewTextBoxColumn
    Friend WithEvents PC_DGV_CompAd As DataGridViewTextBoxColumn
    Friend WithEvents PC_DGV_CompEmail As DataGridViewTextBoxColumn
    Friend WithEvents PC_DGV_CompCon As DataGridViewTextBoxColumn
    Friend WithEvents PC_DGV_SVisor As DataGridViewTextBoxColumn
    Friend WithEvents FE_DGV As DataGridView
    Friend WithEvents FE_DGV_FacID As DataGridViewTextBoxColumn
    Friend WithEvents FE_DGV_LastName As DataGridViewTextBoxColumn
    Friend WithEvents FE_DGV_FirstName As DataGridViewTextBoxColumn
    Friend WithEvents FE_DGV_MidName As DataGridViewTextBoxColumn
    Friend WithEvents FE_DGV_Suffix As DataGridViewTextBoxColumn
    Friend WithEvents FE_DGV_Employment As DataGridViewTextBoxColumn
    Friend WithEvents FE_SidePnl As Panel
    Friend WithEvents FE_Lbl As Label
    Friend WithEvents VL_DGV As DataGridView
    Friend WithEvents VL_SidePnl As Panel
    Friend WithEvents VL_Lbl As Label
    Friend WithEvents FE_DeptLbl As Label
    Friend WithEvents FE_DeptCMB As ComboBox
    Friend WithEvents VL_DGV_VisitID As DataGridViewTextBoxColumn
    Friend WithEvents VL_DGV_StudName As DataGridViewTextBoxColumn
    Friend WithEvents VL_DGV_CompName As DataGridViewTextBoxColumn
    Friend WithEvents VL_DGV_FacEval As DataGridViewTextBoxColumn
    Friend WithEvents VL_DGV_VisitDT As DataGridViewTextBoxColumn
    Friend WithEvents VL_DGV_Rating As DataGridViewTextBoxColumn
    Friend WithEvents VL_DGV_Remarks As DataGridViewTextBoxColumn
    Friend WithEvents Fac_PosTB As TextBox
    Friend WithEvents Adm_Intern_SY_Mtx As MaskedTextBox
    Friend WithEvents Adm_Intern_AddStudID_Mtxt As MaskedTextBox
    Friend WithEvents Adm_Intern_Stud_ID As Label
End Class
