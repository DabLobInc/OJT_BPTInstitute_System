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
        Fac_Eval_Panel = New Panel()
        FEval_DateTime = New Label()
        Evaluatorslbl = New Label()
        Stud_Eval_Panel = New Panel()
        Adm_Greeting_lbl = New Label()
        Adm_User_lbl = New Label()
        SRegis_DateTime = New Label()
        Partner_Comp_Panel = New Panel()
        PComp_DateTime = New Label()
        Companieslbl = New Label()
        Stud_Regis_Panel = New Panel()
        Registeredlbl = New Label()
        SEval_DateTime = New Label()
        Side_Panel = New Panel()
        SideBar_Panel = New Panel()
        SideFunction_Panel = New Panel()
        Adm_Sel4_Panel = New Panel()
        Fac_Eval_Linklbl = New LinkLabel()
        Adm_Sel3_Panel = New Panel()
        Partner_Comp_Linklbl = New LinkLabel()
        Adm_Sel2_Panel = New Panel()
        Stud_Regis_Linklbl = New LinkLabel()
        Adm_Sel1_Panel = New Panel()
        Student_Eval_LinkLbl = New LinkLabel()
        Functions_Panel = New Panel()
        MainMenu_Panel = New Panel()
        SchoolTitle_Panel = New Panel()
        Logo_Pic = New PictureBox()
        SchoolName_Lbl = New Label()
        RightTop_Panel = New Panel()
        Logout_BTN = New LinkLabel()
        Dashboard_BTN = New LinkLabel()
        FunctionOperation_BTN = New LinkLabel()
        Timer1 = New Timer(components)
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Panel4 = New Panel()
        LinkLabel1 = New LinkLabel()
        Panel5 = New Panel()
        LinkLabel2 = New LinkLabel()
        Panel6 = New Panel()
        LinkLabel3 = New LinkLabel()
        Panel7 = New Panel()
        LinkLabel4 = New LinkLabel()
        FuncSide_Panel = New Panel()
        Panel9 = New Panel()
        Panel10 = New Panel()
        Panel11 = New Panel()
        Panel12 = New Panel()
        LinkLabel5 = New LinkLabel()
        Panel13 = New Panel()
        LinkLabel6 = New LinkLabel()
        Panel14 = New Panel()
        LinkLabel7 = New LinkLabel()
        Panel15 = New Panel()
        LinkLabel8 = New LinkLabel()
        Panel16 = New Panel()
        Panel17 = New Panel()
        Panel18 = New Panel()
        LinkLabel9 = New LinkLabel()
        Panel19 = New Panel()
        LinkLabel10 = New LinkLabel()
        Panel20 = New Panel()
        LinkLabel11 = New LinkLabel()
        Panel21 = New Panel()
        LinkLabel12 = New LinkLabel()
        Panel8 = New Panel()
        Panel22 = New Panel()
        Screen_Panel.SuspendLayout()
        Home_Panel.SuspendLayout()
        Content_Panel.SuspendLayout()
        Dashboard_Panel.SuspendLayout()
        Container_Panel.SuspendLayout()
        Fac_Eval_Panel.SuspendLayout()
        Stud_Eval_Panel.SuspendLayout()
        Partner_Comp_Panel.SuspendLayout()
        Stud_Regis_Panel.SuspendLayout()
        Side_Panel.SuspendLayout()
        SideBar_Panel.SuspendLayout()
        SideFunction_Panel.SuspendLayout()
        Adm_Sel4_Panel.SuspendLayout()
        Adm_Sel3_Panel.SuspendLayout()
        Adm_Sel2_Panel.SuspendLayout()
        Adm_Sel1_Panel.SuspendLayout()
        Functions_Panel.SuspendLayout()
        MainMenu_Panel.SuspendLayout()
        SchoolTitle_Panel.SuspendLayout()
        CType(Logo_Pic, ComponentModel.ISupportInitialize).BeginInit()
        RightTop_Panel.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        Panel6.SuspendLayout()
        Panel7.SuspendLayout()
        FuncSide_Panel.SuspendLayout()
        Panel9.SuspendLayout()
        Panel10.SuspendLayout()
        Panel11.SuspendLayout()
        Panel12.SuspendLayout()
        Panel13.SuspendLayout()
        Panel14.SuspendLayout()
        Panel15.SuspendLayout()
        Panel16.SuspendLayout()
        Panel17.SuspendLayout()
        Panel18.SuspendLayout()
        Panel19.SuspendLayout()
        Panel20.SuspendLayout()
        Panel21.SuspendLayout()
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
        Content_Panel.Controls.Add(Functions_Panel)
        Content_Panel.Controls.Add(Dashboard_Panel)
        Content_Panel.Dock = DockStyle.Fill
        Content_Panel.Location = New Point(0, 225)
        Content_Panel.Name = "Content_Panel"
        Content_Panel.Size = New Size(1902, 830)
        Content_Panel.TabIndex = 16
        ' 
        ' Dashboard_Panel
        ' 
        Dashboard_Panel.Controls.Add(Container_Panel)
        Dashboard_Panel.Controls.Add(Side_Panel)
        Dashboard_Panel.Dock = DockStyle.Fill
        Dashboard_Panel.Location = New Point(0, 0)
        Dashboard_Panel.Name = "Dashboard_Panel"
        Dashboard_Panel.Size = New Size(1902, 830)
        Dashboard_Panel.TabIndex = 16
        ' 
        ' Container_Panel
        ' 
        Container_Panel.Controls.Add(Fac_Eval_Panel)
        Container_Panel.Controls.Add(Stud_Eval_Panel)
        Container_Panel.Controls.Add(Partner_Comp_Panel)
        Container_Panel.Controls.Add(Stud_Regis_Panel)
        Container_Panel.Dock = DockStyle.Fill
        Container_Panel.Location = New Point(354, 0)
        Container_Panel.Name = "Container_Panel"
        Container_Panel.Size = New Size(1548, 830)
        Container_Panel.TabIndex = 16
        ' 
        ' Fac_Eval_Panel
        ' 
        Fac_Eval_Panel.BackColor = Color.WhiteSmoke
        Fac_Eval_Panel.Controls.Add(FEval_DateTime)
        Fac_Eval_Panel.Controls.Add(Evaluatorslbl)
        Fac_Eval_Panel.Location = New Point(20, 30)
        Fac_Eval_Panel.Name = "Fac_Eval_Panel"
        Fac_Eval_Panel.Size = New Size(1515, 780)
        Fac_Eval_Panel.TabIndex = 3
        ' 
        ' FEval_DateTime
        ' 
        FEval_DateTime.Font = New Font("Rockwell", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FEval_DateTime.Location = New Point(735, 32)
        FEval_DateTime.Name = "FEval_DateTime"
        FEval_DateTime.Size = New Size(695, 49)
        FEval_DateTime.TabIndex = 7
        ' 
        ' Evaluatorslbl
        ' 
        Evaluatorslbl.AutoSize = True
        Evaluatorslbl.Font = New Font("Times New Roman", 31.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Evaluatorslbl.Location = New Point(116, 96)
        Evaluatorslbl.Name = "Evaluatorslbl"
        Evaluatorslbl.Size = New Size(654, 62)
        Evaluatorslbl.TabIndex = 6
        Evaluatorslbl.Text = "FACULTY EVALUATORS"
        ' 
        ' Stud_Eval_Panel
        ' 
        Stud_Eval_Panel.BackColor = Color.WhiteSmoke
        Stud_Eval_Panel.Controls.Add(Adm_Greeting_lbl)
        Stud_Eval_Panel.Controls.Add(Adm_User_lbl)
        Stud_Eval_Panel.Controls.Add(SRegis_DateTime)
        Stud_Eval_Panel.Location = New Point(20, 30)
        Stud_Eval_Panel.Name = "Stud_Eval_Panel"
        Stud_Eval_Panel.Size = New Size(1515, 780)
        Stud_Eval_Panel.TabIndex = 0
        ' 
        ' Adm_Greeting_lbl
        ' 
        Adm_Greeting_lbl.Font = New Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Adm_Greeting_lbl.Location = New Point(116, 75)
        Adm_Greeting_lbl.Name = "Adm_Greeting_lbl"
        Adm_Greeting_lbl.Size = New Size(325, 42)
        Adm_Greeting_lbl.TabIndex = 5
        Adm_Greeting_lbl.Text = "WELCOME,"
        ' 
        ' Adm_User_lbl
        ' 
        Adm_User_lbl.Font = New Font("Times New Roman", 64.2000046F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Adm_User_lbl.Location = New Point(116, 129)
        Adm_User_lbl.Name = "Adm_User_lbl"
        Adm_User_lbl.Size = New Size(440, 124)
        Adm_User_lbl.TabIndex = 4
        Adm_User_lbl.Text = "ADMIN"
        ' 
        ' SRegis_DateTime
        ' 
        SRegis_DateTime.Font = New Font("Rockwell", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SRegis_DateTime.Location = New Point(735, 32)
        SRegis_DateTime.Name = "SRegis_DateTime"
        SRegis_DateTime.Size = New Size(695, 49)
        SRegis_DateTime.TabIndex = 3
        ' 
        ' Partner_Comp_Panel
        ' 
        Partner_Comp_Panel.BackColor = Color.WhiteSmoke
        Partner_Comp_Panel.Controls.Add(PComp_DateTime)
        Partner_Comp_Panel.Controls.Add(Companieslbl)
        Partner_Comp_Panel.Location = New Point(20, 30)
        Partner_Comp_Panel.Name = "Partner_Comp_Panel"
        Partner_Comp_Panel.Size = New Size(1515, 780)
        Partner_Comp_Panel.TabIndex = 3
        ' 
        ' PComp_DateTime
        ' 
        PComp_DateTime.Font = New Font("Rockwell", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        PComp_DateTime.Location = New Point(735, 32)
        PComp_DateTime.Name = "PComp_DateTime"
        PComp_DateTime.Size = New Size(695, 49)
        PComp_DateTime.TabIndex = 4
        ' 
        ' Companieslbl
        ' 
        Companieslbl.AutoSize = True
        Companieslbl.Font = New Font("Times New Roman", 31.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Companieslbl.Location = New Point(116, 96)
        Companieslbl.Name = "Companieslbl"
        Companieslbl.Size = New Size(622, 62)
        Companieslbl.TabIndex = 5
        Companieslbl.Text = "PARTNER COMPANIES"
        ' 
        ' Stud_Regis_Panel
        ' 
        Stud_Regis_Panel.BackColor = Color.WhiteSmoke
        Stud_Regis_Panel.Controls.Add(Registeredlbl)
        Stud_Regis_Panel.Controls.Add(SEval_DateTime)
        Stud_Regis_Panel.Location = New Point(20, 30)
        Stud_Regis_Panel.Name = "Stud_Regis_Panel"
        Stud_Regis_Panel.Size = New Size(1515, 780)
        Stud_Regis_Panel.TabIndex = 1
        ' 
        ' Registeredlbl
        ' 
        Registeredlbl.AutoSize = True
        Registeredlbl.Font = New Font("Times New Roman", 31.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Registeredlbl.Location = New Point(116, 81)
        Registeredlbl.Name = "Registeredlbl"
        Registeredlbl.Size = New Size(679, 62)
        Registeredlbl.TabIndex = 3
        Registeredlbl.Text = "STUDENTS REGISTERED"
        ' 
        ' SEval_DateTime
        ' 
        SEval_DateTime.Font = New Font("Rockwell", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SEval_DateTime.Location = New Point(735, 32)
        SEval_DateTime.Name = "SEval_DateTime"
        SEval_DateTime.Size = New Size(695, 49)
        SEval_DateTime.TabIndex = 2
        ' 
        ' Side_Panel
        ' 
        Side_Panel.BackColor = SystemColors.Info
        Side_Panel.Controls.Add(Panel1)
        Side_Panel.Controls.Add(SideBar_Panel)
        Side_Panel.Dock = DockStyle.Left
        Side_Panel.Location = New Point(0, 0)
        Side_Panel.Name = "Side_Panel"
        Side_Panel.Size = New Size(354, 830)
        Side_Panel.TabIndex = 15
        ' 
        ' SideBar_Panel
        ' 
        SideBar_Panel.BackColor = Color.Orange
        SideBar_Panel.Controls.Add(SideFunction_Panel)
        SideBar_Panel.Location = New Point(-56, 50)
        SideBar_Panel.Name = "SideBar_Panel"
        SideBar_Panel.Size = New Size(384, 736)
        SideBar_Panel.TabIndex = 0
        ' 
        ' SideFunction_Panel
        ' 
        SideFunction_Panel.Controls.Add(Adm_Sel4_Panel)
        SideFunction_Panel.Controls.Add(Adm_Sel3_Panel)
        SideFunction_Panel.Controls.Add(Adm_Sel2_Panel)
        SideFunction_Panel.Controls.Add(Adm_Sel1_Panel)
        SideFunction_Panel.Location = New Point(30, 30)
        SideFunction_Panel.Name = "SideFunction_Panel"
        SideFunction_Panel.Size = New Size(334, 680)
        SideFunction_Panel.TabIndex = 0
        ' 
        ' Adm_Sel4_Panel
        ' 
        Adm_Sel4_Panel.BackColor = Color.Orange
        Adm_Sel4_Panel.Controls.Add(Fac_Eval_Linklbl)
        Adm_Sel4_Panel.Location = New Point(3, 505)
        Adm_Sel4_Panel.Name = "Adm_Sel4_Panel"
        Adm_Sel4_Panel.Size = New Size(303, 125)
        Adm_Sel4_Panel.TabIndex = 17
        ' 
        ' Fac_Eval_Linklbl
        ' 
        Fac_Eval_Linklbl.ActiveLinkColor = Color.Goldenrod
        Fac_Eval_Linklbl.BackColor = Color.Orange
        Fac_Eval_Linklbl.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Fac_Eval_Linklbl.ForeColor = SystemColors.ActiveCaptionText
        Fac_Eval_Linklbl.LinkColor = Color.White
        Fac_Eval_Linklbl.Location = New Point(62, 26)
        Fac_Eval_Linklbl.Name = "Fac_Eval_Linklbl"
        Fac_Eval_Linklbl.Size = New Size(215, 70)
        Fac_Eval_Linklbl.TabIndex = 11
        Fac_Eval_Linklbl.TabStop = True
        Fac_Eval_Linklbl.Text = "FACULTY" & vbCrLf & "EVALUATORS"
        Fac_Eval_Linklbl.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Adm_Sel3_Panel
        ' 
        Adm_Sel3_Panel.BackColor = Color.Orange
        Adm_Sel3_Panel.Controls.Add(Partner_Comp_Linklbl)
        Adm_Sel3_Panel.ForeColor = Color.White
        Adm_Sel3_Panel.Location = New Point(3, 353)
        Adm_Sel3_Panel.Name = "Adm_Sel3_Panel"
        Adm_Sel3_Panel.Size = New Size(303, 125)
        Adm_Sel3_Panel.TabIndex = 18
        ' 
        ' Partner_Comp_Linklbl
        ' 
        Partner_Comp_Linklbl.ActiveLinkColor = Color.Goldenrod
        Partner_Comp_Linklbl.BackColor = Color.Orange
        Partner_Comp_Linklbl.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Partner_Comp_Linklbl.ForeColor = SystemColors.ActiveCaptionText
        Partner_Comp_Linklbl.LinkColor = Color.White
        Partner_Comp_Linklbl.Location = New Point(62, 26)
        Partner_Comp_Linklbl.Name = "Partner_Comp_Linklbl"
        Partner_Comp_Linklbl.Size = New Size(215, 70)
        Partner_Comp_Linklbl.TabIndex = 11
        Partner_Comp_Linklbl.TabStop = True
        Partner_Comp_Linklbl.Text = "PARTNER" & vbCrLf & "COMPANIES"
        Partner_Comp_Linklbl.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Adm_Sel2_Panel
        ' 
        Adm_Sel2_Panel.BackColor = Color.Orange
        Adm_Sel2_Panel.Controls.Add(Stud_Regis_Linklbl)
        Adm_Sel2_Panel.Location = New Point(-7, 202)
        Adm_Sel2_Panel.Name = "Adm_Sel2_Panel"
        Adm_Sel2_Panel.Size = New Size(313, 125)
        Adm_Sel2_Panel.TabIndex = 16
        ' 
        ' Stud_Regis_Linklbl
        ' 
        Stud_Regis_Linklbl.ActiveLinkColor = Color.Goldenrod
        Stud_Regis_Linklbl.BackColor = Color.Orange
        Stud_Regis_Linklbl.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Stud_Regis_Linklbl.ForeColor = SystemColors.ActiveCaptionText
        Stud_Regis_Linklbl.LinkColor = Color.White
        Stud_Regis_Linklbl.Location = New Point(72, 27)
        Stud_Regis_Linklbl.Name = "Stud_Regis_Linklbl"
        Stud_Regis_Linklbl.Size = New Size(215, 70)
        Stud_Regis_Linklbl.TabIndex = 11
        Stud_Regis_Linklbl.TabStop = True
        Stud_Regis_Linklbl.Text = "STUDENTS" & vbCrLf & "REGISTERED"
        Stud_Regis_Linklbl.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Adm_Sel1_Panel
        ' 
        Adm_Sel1_Panel.BackColor = Color.White
        Adm_Sel1_Panel.Controls.Add(Student_Eval_LinkLbl)
        Adm_Sel1_Panel.Location = New Point(3, 59)
        Adm_Sel1_Panel.Name = "Adm_Sel1_Panel"
        Adm_Sel1_Panel.Size = New Size(303, 125)
        Adm_Sel1_Panel.TabIndex = 15
        ' 
        ' Student_Eval_LinkLbl
        ' 
        Student_Eval_LinkLbl.ActiveLinkColor = Color.Goldenrod
        Student_Eval_LinkLbl.BackColor = SystemColors.Control
        Student_Eval_LinkLbl.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Student_Eval_LinkLbl.ForeColor = SystemColors.ActiveCaptionText
        Student_Eval_LinkLbl.LinkColor = Color.Black
        Student_Eval_LinkLbl.Location = New Point(62, 22)
        Student_Eval_LinkLbl.Name = "Student_Eval_LinkLbl"
        Student_Eval_LinkLbl.Size = New Size(215, 70)
        Student_Eval_LinkLbl.TabIndex = 11
        Student_Eval_LinkLbl.TabStop = True
        Student_Eval_LinkLbl.Text = "STUDENT" & vbCrLf & "EVALUATION"
        Student_Eval_LinkLbl.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Functions_Panel
        ' 
        Functions_Panel.Controls.Add(Panel8)
        Functions_Panel.Controls.Add(Panel22)
        Functions_Panel.Controls.Add(FuncSide_Panel)
        Functions_Panel.Dock = DockStyle.Fill
        Functions_Panel.Location = New Point(0, 0)
        Functions_Panel.Name = "Functions_Panel"
        Functions_Panel.Size = New Size(1902, 830)
        Functions_Panel.TabIndex = 11
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
        RightTop_Panel.Controls.Add(FunctionOperation_BTN)
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
        Logout_BTN.Location = New Point(812, 3)
        Logout_BTN.Name = "Logout_BTN"
        Logout_BTN.Size = New Size(159, 149)
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
        Dashboard_BTN.Location = New Point(181, 3)
        Dashboard_BTN.Name = "Dashboard_BTN"
        Dashboard_BTN.Size = New Size(203, 149)
        Dashboard_BTN.TabIndex = 0
        Dashboard_BTN.TabStop = True
        Dashboard_BTN.Text = "DASHBOARD"
        Dashboard_BTN.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' FunctionOperation_BTN
        ' 
        FunctionOperation_BTN.ActiveLinkColor = Color.Goldenrod
        FunctionOperation_BTN.BackColor = Color.Navy
        FunctionOperation_BTN.Font = New Font("Arial Rounded MT Bold", 16.2F)
        FunctionOperation_BTN.LinkColor = Color.White
        FunctionOperation_BTN.Location = New Point(390, 3)
        FunctionOperation_BTN.Name = "FunctionOperation_BTN"
        FunctionOperation_BTN.Size = New Size(416, 149)
        FunctionOperation_BTN.TabIndex = 8
        FunctionOperation_BTN.TabStop = True
        FunctionOperation_BTN.Text = "FUNCTIONS && OPERATIONS"
        FunctionOperation_BTN.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 1000
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.Info
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(354, 830)
        Panel1.TabIndex = 16
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Orange
        Panel2.Controls.Add(Panel3)
        Panel2.Location = New Point(-56, 50)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(384, 736)
        Panel2.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Panel4)
        Panel3.Controls.Add(Panel5)
        Panel3.Controls.Add(Panel6)
        Panel3.Controls.Add(Panel7)
        Panel3.Location = New Point(30, 30)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(334, 680)
        Panel3.TabIndex = 0
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Orange
        Panel4.Controls.Add(LinkLabel1)
        Panel4.Location = New Point(3, 505)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(303, 125)
        Panel4.TabIndex = 17
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.ActiveLinkColor = Color.Goldenrod
        LinkLabel1.BackColor = Color.Orange
        LinkLabel1.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LinkLabel1.ForeColor = SystemColors.ActiveCaptionText
        LinkLabel1.LinkColor = Color.White
        LinkLabel1.Location = New Point(62, 26)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(215, 70)
        LinkLabel1.TabIndex = 11
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "FACULTY" & vbCrLf & "EVALUATORS"
        LinkLabel1.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.Orange
        Panel5.Controls.Add(LinkLabel2)
        Panel5.ForeColor = Color.White
        Panel5.Location = New Point(3, 353)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(303, 125)
        Panel5.TabIndex = 18
        ' 
        ' LinkLabel2
        ' 
        LinkLabel2.ActiveLinkColor = Color.Goldenrod
        LinkLabel2.BackColor = Color.Orange
        LinkLabel2.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LinkLabel2.ForeColor = SystemColors.ActiveCaptionText
        LinkLabel2.LinkColor = Color.White
        LinkLabel2.Location = New Point(62, 26)
        LinkLabel2.Name = "LinkLabel2"
        LinkLabel2.Size = New Size(215, 70)
        LinkLabel2.TabIndex = 11
        LinkLabel2.TabStop = True
        LinkLabel2.Text = "PARTNER" & vbCrLf & "COMPANIES"
        LinkLabel2.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.Orange
        Panel6.Controls.Add(LinkLabel3)
        Panel6.Location = New Point(-7, 202)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(313, 125)
        Panel6.TabIndex = 16
        ' 
        ' LinkLabel3
        ' 
        LinkLabel3.ActiveLinkColor = Color.Goldenrod
        LinkLabel3.BackColor = Color.Orange
        LinkLabel3.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LinkLabel3.ForeColor = SystemColors.ActiveCaptionText
        LinkLabel3.LinkColor = Color.White
        LinkLabel3.Location = New Point(72, 27)
        LinkLabel3.Name = "LinkLabel3"
        LinkLabel3.Size = New Size(215, 70)
        LinkLabel3.TabIndex = 11
        LinkLabel3.TabStop = True
        LinkLabel3.Text = "STUDENTS" & vbCrLf & "REGISTERED"
        LinkLabel3.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.White
        Panel7.Controls.Add(LinkLabel4)
        Panel7.Location = New Point(3, 59)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(303, 125)
        Panel7.TabIndex = 15
        ' 
        ' LinkLabel4
        ' 
        LinkLabel4.ActiveLinkColor = Color.Goldenrod
        LinkLabel4.BackColor = SystemColors.Control
        LinkLabel4.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LinkLabel4.ForeColor = SystemColors.ActiveCaptionText
        LinkLabel4.LinkColor = Color.Black
        LinkLabel4.Location = New Point(62, 22)
        LinkLabel4.Name = "LinkLabel4"
        LinkLabel4.Size = New Size(215, 70)
        LinkLabel4.TabIndex = 11
        LinkLabel4.TabStop = True
        LinkLabel4.Text = "STUDENT" & vbCrLf & "EVALUATION"
        LinkLabel4.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' FuncSide_Panel
        ' 
        FuncSide_Panel.BackColor = SystemColors.Info
        FuncSide_Panel.Controls.Add(Panel9)
        FuncSide_Panel.Controls.Add(Panel16)
        FuncSide_Panel.Dock = DockStyle.Left
        FuncSide_Panel.Location = New Point(0, 0)
        FuncSide_Panel.Name = "FuncSide_Panel"
        FuncSide_Panel.Size = New Size(354, 830)
        FuncSide_Panel.TabIndex = 16
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = SystemColors.Info
        Panel9.Controls.Add(Panel10)
        Panel9.Dock = DockStyle.Left
        Panel9.Location = New Point(0, 0)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(354, 830)
        Panel9.TabIndex = 16
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = Color.Orange
        Panel10.Controls.Add(Panel11)
        Panel10.Location = New Point(-56, 50)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(384, 736)
        Panel10.TabIndex = 0
        ' 
        ' Panel11
        ' 
        Panel11.Controls.Add(Panel12)
        Panel11.Controls.Add(Panel13)
        Panel11.Controls.Add(Panel14)
        Panel11.Controls.Add(Panel15)
        Panel11.Location = New Point(30, 30)
        Panel11.Name = "Panel11"
        Panel11.Size = New Size(334, 680)
        Panel11.TabIndex = 0
        ' 
        ' Panel12
        ' 
        Panel12.BackColor = Color.Orange
        Panel12.Controls.Add(LinkLabel5)
        Panel12.Location = New Point(3, 505)
        Panel12.Name = "Panel12"
        Panel12.Size = New Size(303, 125)
        Panel12.TabIndex = 17
        ' 
        ' LinkLabel5
        ' 
        LinkLabel5.ActiveLinkColor = Color.Goldenrod
        LinkLabel5.BackColor = Color.Orange
        LinkLabel5.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LinkLabel5.ForeColor = SystemColors.ActiveCaptionText
        LinkLabel5.LinkColor = Color.White
        LinkLabel5.Location = New Point(62, 26)
        LinkLabel5.Name = "LinkLabel5"
        LinkLabel5.Size = New Size(215, 70)
        LinkLabel5.TabIndex = 11
        LinkLabel5.TabStop = True
        LinkLabel5.Text = "FACULTY" & vbCrLf & "EVALUATORS"
        LinkLabel5.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Panel13
        ' 
        Panel13.BackColor = Color.Orange
        Panel13.Controls.Add(LinkLabel6)
        Panel13.ForeColor = Color.White
        Panel13.Location = New Point(3, 353)
        Panel13.Name = "Panel13"
        Panel13.Size = New Size(303, 125)
        Panel13.TabIndex = 18
        ' 
        ' LinkLabel6
        ' 
        LinkLabel6.ActiveLinkColor = Color.Goldenrod
        LinkLabel6.BackColor = Color.Orange
        LinkLabel6.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LinkLabel6.ForeColor = SystemColors.ActiveCaptionText
        LinkLabel6.LinkColor = Color.White
        LinkLabel6.Location = New Point(62, 26)
        LinkLabel6.Name = "LinkLabel6"
        LinkLabel6.Size = New Size(215, 70)
        LinkLabel6.TabIndex = 11
        LinkLabel6.TabStop = True
        LinkLabel6.Text = "PARTNER" & vbCrLf & "COMPANIES"
        LinkLabel6.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Panel14
        ' 
        Panel14.BackColor = Color.Orange
        Panel14.Controls.Add(LinkLabel7)
        Panel14.Location = New Point(-7, 202)
        Panel14.Name = "Panel14"
        Panel14.Size = New Size(313, 125)
        Panel14.TabIndex = 16
        ' 
        ' LinkLabel7
        ' 
        LinkLabel7.ActiveLinkColor = Color.Goldenrod
        LinkLabel7.BackColor = Color.Orange
        LinkLabel7.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LinkLabel7.ForeColor = SystemColors.ActiveCaptionText
        LinkLabel7.LinkColor = Color.White
        LinkLabel7.Location = New Point(72, 27)
        LinkLabel7.Name = "LinkLabel7"
        LinkLabel7.Size = New Size(215, 70)
        LinkLabel7.TabIndex = 11
        LinkLabel7.TabStop = True
        LinkLabel7.Text = "STUDENTS" & vbCrLf & "REGISTERED"
        LinkLabel7.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Panel15
        ' 
        Panel15.BackColor = Color.White
        Panel15.Controls.Add(LinkLabel8)
        Panel15.Location = New Point(3, 25)
        Panel15.Name = "Panel15"
        Panel15.Size = New Size(303, 125)
        Panel15.TabIndex = 15
        ' 
        ' LinkLabel8
        ' 
        LinkLabel8.ActiveLinkColor = Color.Goldenrod
        LinkLabel8.BackColor = SystemColors.Control
        LinkLabel8.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LinkLabel8.ForeColor = SystemColors.ActiveCaptionText
        LinkLabel8.LinkColor = Color.Black
        LinkLabel8.Location = New Point(62, 22)
        LinkLabel8.Name = "LinkLabel8"
        LinkLabel8.Size = New Size(215, 70)
        LinkLabel8.TabIndex = 11
        LinkLabel8.TabStop = True
        LinkLabel8.Text = "STUDENT" & vbCrLf & "EVALUATION"
        LinkLabel8.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Panel16
        ' 
        Panel16.BackColor = Color.Orange
        Panel16.Controls.Add(Panel17)
        Panel16.Location = New Point(-56, 50)
        Panel16.Name = "Panel16"
        Panel16.Size = New Size(384, 736)
        Panel16.TabIndex = 0
        ' 
        ' Panel17
        ' 
        Panel17.Controls.Add(Panel18)
        Panel17.Controls.Add(Panel19)
        Panel17.Controls.Add(Panel20)
        Panel17.Controls.Add(Panel21)
        Panel17.Location = New Point(30, 30)
        Panel17.Name = "Panel17"
        Panel17.Size = New Size(334, 680)
        Panel17.TabIndex = 0
        ' 
        ' Panel18
        ' 
        Panel18.BackColor = Color.Orange
        Panel18.Controls.Add(LinkLabel9)
        Panel18.Location = New Point(3, 505)
        Panel18.Name = "Panel18"
        Panel18.Size = New Size(303, 125)
        Panel18.TabIndex = 17
        ' 
        ' LinkLabel9
        ' 
        LinkLabel9.ActiveLinkColor = Color.Goldenrod
        LinkLabel9.BackColor = Color.Orange
        LinkLabel9.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LinkLabel9.ForeColor = SystemColors.ActiveCaptionText
        LinkLabel9.LinkColor = Color.White
        LinkLabel9.Location = New Point(62, 26)
        LinkLabel9.Name = "LinkLabel9"
        LinkLabel9.Size = New Size(215, 70)
        LinkLabel9.TabIndex = 11
        LinkLabel9.TabStop = True
        LinkLabel9.Text = "FACULTY" & vbCrLf & "EVALUATORS"
        LinkLabel9.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Panel19
        ' 
        Panel19.BackColor = Color.Orange
        Panel19.Controls.Add(LinkLabel10)
        Panel19.ForeColor = Color.White
        Panel19.Location = New Point(3, 353)
        Panel19.Name = "Panel19"
        Panel19.Size = New Size(303, 125)
        Panel19.TabIndex = 18
        ' 
        ' LinkLabel10
        ' 
        LinkLabel10.ActiveLinkColor = Color.Goldenrod
        LinkLabel10.BackColor = Color.Orange
        LinkLabel10.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LinkLabel10.ForeColor = SystemColors.ActiveCaptionText
        LinkLabel10.LinkColor = Color.White
        LinkLabel10.Location = New Point(62, 26)
        LinkLabel10.Name = "LinkLabel10"
        LinkLabel10.Size = New Size(215, 70)
        LinkLabel10.TabIndex = 11
        LinkLabel10.TabStop = True
        LinkLabel10.Text = "PARTNER" & vbCrLf & "COMPANIES"
        LinkLabel10.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Panel20
        ' 
        Panel20.BackColor = Color.Orange
        Panel20.Controls.Add(LinkLabel11)
        Panel20.Location = New Point(-7, 202)
        Panel20.Name = "Panel20"
        Panel20.Size = New Size(313, 125)
        Panel20.TabIndex = 16
        ' 
        ' LinkLabel11
        ' 
        LinkLabel11.ActiveLinkColor = Color.Goldenrod
        LinkLabel11.BackColor = Color.Orange
        LinkLabel11.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LinkLabel11.ForeColor = SystemColors.ActiveCaptionText
        LinkLabel11.LinkColor = Color.White
        LinkLabel11.Location = New Point(72, 27)
        LinkLabel11.Name = "LinkLabel11"
        LinkLabel11.Size = New Size(215, 70)
        LinkLabel11.TabIndex = 11
        LinkLabel11.TabStop = True
        LinkLabel11.Text = "STUDENTS" & vbCrLf & "REGISTERED"
        LinkLabel11.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Panel21
        ' 
        Panel21.BackColor = Color.White
        Panel21.Controls.Add(LinkLabel12)
        Panel21.Location = New Point(3, 59)
        Panel21.Name = "Panel21"
        Panel21.Size = New Size(303, 125)
        Panel21.TabIndex = 15
        ' 
        ' LinkLabel12
        ' 
        LinkLabel12.ActiveLinkColor = Color.Goldenrod
        LinkLabel12.BackColor = SystemColors.Control
        LinkLabel12.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LinkLabel12.ForeColor = SystemColors.ActiveCaptionText
        LinkLabel12.LinkColor = Color.Black
        LinkLabel12.Location = New Point(62, 22)
        LinkLabel12.Name = "LinkLabel12"
        LinkLabel12.Size = New Size(215, 70)
        LinkLabel12.TabIndex = 11
        LinkLabel12.TabStop = True
        LinkLabel12.Text = "STUDENT" & vbCrLf & "EVALUATION"
        LinkLabel12.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Panel8
        ' 
        Panel8.Dock = DockStyle.Fill
        Panel8.Location = New Point(354, 0)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(1548, 830)
        Panel8.TabIndex = 17
        ' 
        ' Panel22
        ' 
        Panel22.Dock = DockStyle.Fill
        Panel22.Location = New Point(354, 0)
        Panel22.Name = "Panel22"
        Panel22.Size = New Size(1548, 830)
        Panel22.TabIndex = 0
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
        Fac_Eval_Panel.ResumeLayout(False)
        Fac_Eval_Panel.PerformLayout()
        Stud_Eval_Panel.ResumeLayout(False)
        Partner_Comp_Panel.ResumeLayout(False)
        Partner_Comp_Panel.PerformLayout()
        Stud_Regis_Panel.ResumeLayout(False)
        Stud_Regis_Panel.PerformLayout()
        Side_Panel.ResumeLayout(False)
        SideBar_Panel.ResumeLayout(False)
        SideFunction_Panel.ResumeLayout(False)
        Adm_Sel4_Panel.ResumeLayout(False)
        Adm_Sel3_Panel.ResumeLayout(False)
        Adm_Sel2_Panel.ResumeLayout(False)
        Adm_Sel1_Panel.ResumeLayout(False)
        Functions_Panel.ResumeLayout(False)
        MainMenu_Panel.ResumeLayout(False)
        SchoolTitle_Panel.ResumeLayout(False)
        CType(Logo_Pic, ComponentModel.ISupportInitialize).EndInit()
        RightTop_Panel.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        Panel7.ResumeLayout(False)
        FuncSide_Panel.ResumeLayout(False)
        Panel9.ResumeLayout(False)
        Panel10.ResumeLayout(False)
        Panel11.ResumeLayout(False)
        Panel12.ResumeLayout(False)
        Panel13.ResumeLayout(False)
        Panel14.ResumeLayout(False)
        Panel15.ResumeLayout(False)
        Panel16.ResumeLayout(False)
        Panel17.ResumeLayout(False)
        Panel18.ResumeLayout(False)
        Panel19.ResumeLayout(False)
        Panel20.ResumeLayout(False)
        Panel21.ResumeLayout(False)
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
    Friend WithEvents FunctionOperation_BTN As LinkLabel
    Friend WithEvents Side_Panel As Panel
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
    Friend WithEvents Stud_Eval_Panel As Panel
    Friend WithEvents Stud_Regis_Panel As Panel
    Friend WithEvents Fac_Eval_Panel As Panel
    Friend WithEvents Partner_Comp_Panel As Panel
    Friend WithEvents SEval_DateTime As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents SRegis_DateTime As Label
    Friend WithEvents PComp_DateTime As Label
    Friend WithEvents Companieslbl As Label
    Friend WithEvents Evaluatorslbl As Label
    Friend WithEvents FEval_DateTime As Label
    Friend WithEvents Adm_Greeting_lbl As Label
    Friend WithEvents Adm_User_lbl As Label
    Friend WithEvents Registeredlbl As Label
    Friend WithEvents Functions_Panel As Panel
    Friend WithEvents Dashboard_Panel As Panel
    Friend WithEvents Container_Panel As Panel
    Friend WithEvents Logout_BTN As LinkLabel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents FuncSide_Panel As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents LinkLabel5 As LinkLabel
    Friend WithEvents Panel13 As Panel
    Friend WithEvents LinkLabel6 As LinkLabel
    Friend WithEvents Panel14 As Panel
    Friend WithEvents LinkLabel7 As LinkLabel
    Friend WithEvents Panel15 As Panel
    Friend WithEvents LinkLabel8 As LinkLabel
    Friend WithEvents Panel16 As Panel
    Friend WithEvents Panel17 As Panel
    Friend WithEvents Panel18 As Panel
    Friend WithEvents LinkLabel9 As LinkLabel
    Friend WithEvents Panel19 As Panel
    Friend WithEvents LinkLabel10 As LinkLabel
    Friend WithEvents Panel20 As Panel
    Friend WithEvents LinkLabel11 As LinkLabel
    Friend WithEvents Panel21 As Panel
    Friend WithEvents LinkLabel12 As LinkLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents LinkLabel4 As LinkLabel
    Friend WithEvents Panel22 As Panel
End Class
