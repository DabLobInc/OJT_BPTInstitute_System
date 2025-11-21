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
        Adm_Greeting_lbl = New Label()
        Adm_User_lbl = New Label()
        SRegis_DateTime = New Label()
        Stud_Regis_Panel = New Panel()
        Registeredlbl = New Label()
        SEval_DateTime = New Label()
        Fac_Eval_Panel = New Panel()
        FEval_DateTime = New Label()
        Evaluatorslbl = New Label()
        Partner_Comp_Panel = New Panel()
        PComp_DateTime = New Label()
        Companieslbl = New Label()
        Side_Panel = New Panel()
        Logout_BTN = New LinkLabel()
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
        LinkLabel1 = New LinkLabel()
        MainMenu_Panel = New Panel()
        SchoolTitle_Panel = New Panel()
        Logo_Pic = New PictureBox()
        SchoolName_Lbl = New Label()
        RightTop_Panel = New Panel()
        Dashboard_BTN = New LinkLabel()
        FunctionOperation_BTN = New LinkLabel()
        Timer1 = New Timer(components)
        Logout_Panel = New Panel()
        Screen_Panel.SuspendLayout()
        Home_Panel.SuspendLayout()
        Content_Panel.SuspendLayout()
        Dashboard_Panel.SuspendLayout()
        Container_Panel.SuspendLayout()
        Stud_Eval_Panel.SuspendLayout()
        Stud_Regis_Panel.SuspendLayout()
        Fac_Eval_Panel.SuspendLayout()
        Partner_Comp_Panel.SuspendLayout()
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
        Logout_Panel.SuspendLayout()
        SuspendLayout()
        ' 
        ' Screen_Panel
        ' 
        Screen_Panel.BackColor = SystemColors.Control
        Screen_Panel.Controls.Add(Logout_Panel)
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
        Home_Panel.Controls.Add(Functions_Panel)
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
        Content_Panel.Dock = DockStyle.Fill
        Content_Panel.Location = New Point(0, 180)
        Content_Panel.Name = "Content_Panel"
        Content_Panel.Size = New Size(1902, 875)
        Content_Panel.TabIndex = 16
        ' 
        ' Dashboard_Panel
        ' 
        Dashboard_Panel.Controls.Add(Container_Panel)
        Dashboard_Panel.Controls.Add(Side_Panel)
        Dashboard_Panel.Dock = DockStyle.Fill
        Dashboard_Panel.Location = New Point(0, 0)
        Dashboard_Panel.Name = "Dashboard_Panel"
        Dashboard_Panel.Size = New Size(1902, 875)
        Dashboard_Panel.TabIndex = 16
        ' 
        ' Container_Panel
        ' 
        Container_Panel.Controls.Add(Stud_Eval_Panel)
        Container_Panel.Controls.Add(Stud_Regis_Panel)
        Container_Panel.Controls.Add(Fac_Eval_Panel)
        Container_Panel.Controls.Add(Partner_Comp_Panel)
        Container_Panel.Dock = DockStyle.Fill
        Container_Panel.Location = New Point(299, 0)
        Container_Panel.Name = "Container_Panel"
        Container_Panel.Size = New Size(1603, 875)
        Container_Panel.TabIndex = 16
        ' 
        ' Stud_Eval_Panel
        ' 
        Stud_Eval_Panel.BackColor = Color.WhiteSmoke
        Stud_Eval_Panel.Controls.Add(Adm_Greeting_lbl)
        Stud_Eval_Panel.Controls.Add(Adm_User_lbl)
        Stud_Eval_Panel.Controls.Add(SRegis_DateTime)
        Stud_Eval_Panel.Location = New Point(21, 32)
        Stud_Eval_Panel.Name = "Stud_Eval_Panel"
        Stud_Eval_Panel.Size = New Size(1576, 848)
        Stud_Eval_Panel.TabIndex = 0
        ' 
        ' Adm_Greeting_lbl
        ' 
        Adm_Greeting_lbl.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Adm_Greeting_lbl.Location = New Point(112, 65)
        Adm_Greeting_lbl.Name = "Adm_Greeting_lbl"
        Adm_Greeting_lbl.Size = New Size(325, 42)
        Adm_Greeting_lbl.TabIndex = 5
        Adm_Greeting_lbl.Text = "WELCOME,"
        ' 
        ' Adm_User_lbl
        ' 
        Adm_User_lbl.Font = New Font("Times New Roman", 55.8000031F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Adm_User_lbl.Location = New Point(112, 107)
        Adm_User_lbl.Name = "Adm_User_lbl"
        Adm_User_lbl.Size = New Size(382, 103)
        Adm_User_lbl.TabIndex = 4
        Adm_User_lbl.Text = "ADMIN"
        ' 
        ' SRegis_DateTime
        ' 
        SRegis_DateTime.Font = New Font("Rockwell", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SRegis_DateTime.Location = New Point(935, 35)
        SRegis_DateTime.Name = "SRegis_DateTime"
        SRegis_DateTime.Size = New Size(589, 49)
        SRegis_DateTime.TabIndex = 3
        ' 
        ' Stud_Regis_Panel
        ' 
        Stud_Regis_Panel.BackColor = Color.WhiteSmoke
        Stud_Regis_Panel.Controls.Add(Registeredlbl)
        Stud_Regis_Panel.Controls.Add(SEval_DateTime)
        Stud_Regis_Panel.Location = New Point(21, 32)
        Stud_Regis_Panel.Name = "Stud_Regis_Panel"
        Stud_Regis_Panel.Size = New Size(1582, 858)
        Stud_Regis_Panel.TabIndex = 1
        ' 
        ' Registeredlbl
        ' 
        Registeredlbl.AutoSize = True
        Registeredlbl.Font = New Font("Times New Roman", 31.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Registeredlbl.Location = New Point(116, 69)
        Registeredlbl.Name = "Registeredlbl"
        Registeredlbl.Size = New Size(679, 62)
        Registeredlbl.TabIndex = 3
        Registeredlbl.Text = "STUDENTS REGISTERED"
        ' 
        ' SEval_DateTime
        ' 
        SEval_DateTime.Font = New Font("Rockwell", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SEval_DateTime.Location = New Point(939, 32)
        SEval_DateTime.Name = "SEval_DateTime"
        SEval_DateTime.Size = New Size(589, 49)
        SEval_DateTime.TabIndex = 2
        ' 
        ' Fac_Eval_Panel
        ' 
        Fac_Eval_Panel.BackColor = Color.WhiteSmoke
        Fac_Eval_Panel.Controls.Add(FEval_DateTime)
        Fac_Eval_Panel.Controls.Add(Evaluatorslbl)
        Fac_Eval_Panel.Location = New Point(21, 32)
        Fac_Eval_Panel.Name = "Fac_Eval_Panel"
        Fac_Eval_Panel.Size = New Size(1580, 852)
        Fac_Eval_Panel.TabIndex = 3
        ' 
        ' FEval_DateTime
        ' 
        FEval_DateTime.Font = New Font("Rockwell", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FEval_DateTime.Location = New Point(939, 39)
        FEval_DateTime.Name = "FEval_DateTime"
        FEval_DateTime.Size = New Size(589, 49)
        FEval_DateTime.TabIndex = 7
        ' 
        ' Evaluatorslbl
        ' 
        Evaluatorslbl.AutoSize = True
        Evaluatorslbl.Font = New Font("Times New Roman", 31.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Evaluatorslbl.Location = New Point(116, 69)
        Evaluatorslbl.Name = "Evaluatorslbl"
        Evaluatorslbl.Size = New Size(654, 62)
        Evaluatorslbl.TabIndex = 6
        Evaluatorslbl.Text = "FACULTY EVALUATORS"
        ' 
        ' Partner_Comp_Panel
        ' 
        Partner_Comp_Panel.BackColor = Color.WhiteSmoke
        Partner_Comp_Panel.Controls.Add(PComp_DateTime)
        Partner_Comp_Panel.Controls.Add(Companieslbl)
        Partner_Comp_Panel.Location = New Point(20, 32)
        Partner_Comp_Panel.Name = "Partner_Comp_Panel"
        Partner_Comp_Panel.Size = New Size(1580, 852)
        Partner_Comp_Panel.TabIndex = 3
        ' 
        ' PComp_DateTime
        ' 
        PComp_DateTime.Font = New Font("Rockwell", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        PComp_DateTime.Location = New Point(940, 39)
        PComp_DateTime.Name = "PComp_DateTime"
        PComp_DateTime.Size = New Size(589, 49)
        PComp_DateTime.TabIndex = 4
        ' 
        ' Companieslbl
        ' 
        Companieslbl.AutoSize = True
        Companieslbl.Font = New Font("Times New Roman", 31.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Companieslbl.Location = New Point(117, 69)
        Companieslbl.Name = "Companieslbl"
        Companieslbl.Size = New Size(622, 62)
        Companieslbl.TabIndex = 5
        Companieslbl.Text = "PARTNER COMPANIES"
        ' 
        ' Side_Panel
        ' 
        Side_Panel.BackColor = Color.WhiteSmoke
        Side_Panel.Controls.Add(SideBar_Panel)
        Side_Panel.Dock = DockStyle.Left
        Side_Panel.Location = New Point(0, 0)
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
        Logout_BTN.Location = New Point(0, 0)
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
        SideFunction_Panel.Controls.Add(Adm_Sel4_Panel)
        SideFunction_Panel.Controls.Add(Adm_Sel3_Panel)
        SideFunction_Panel.Controls.Add(Adm_Sel2_Panel)
        SideFunction_Panel.Controls.Add(Adm_Sel1_Panel)
        SideFunction_Panel.Location = New Point(30, 30)
        SideFunction_Panel.Name = "SideFunction_Panel"
        SideFunction_Panel.Size = New Size(280, 680)
        SideFunction_Panel.TabIndex = 0
        ' 
        ' Adm_Sel4_Panel
        ' 
        Adm_Sel4_Panel.BackColor = Color.Orange
        Adm_Sel4_Panel.Controls.Add(Fac_Eval_Linklbl)
        Adm_Sel4_Panel.Location = New Point(0, 515)
        Adm_Sel4_Panel.Name = "Adm_Sel4_Panel"
        Adm_Sel4_Panel.Size = New Size(265, 125)
        Adm_Sel4_Panel.TabIndex = 17
        ' 
        ' Fac_Eval_Linklbl
        ' 
        Fac_Eval_Linklbl.ActiveLinkColor = Color.Goldenrod
        Fac_Eval_Linklbl.BackColor = Color.Orange
        Fac_Eval_Linklbl.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Fac_Eval_Linklbl.ForeColor = SystemColors.ActiveCaptionText
        Fac_Eval_Linklbl.LinkColor = Color.White
        Fac_Eval_Linklbl.Location = New Point(33, 30)
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
        Adm_Sel3_Panel.Location = New Point(-10, 355)
        Adm_Sel3_Panel.Name = "Adm_Sel3_Panel"
        Adm_Sel3_Panel.Size = New Size(277, 125)
        Adm_Sel3_Panel.TabIndex = 18
        ' 
        ' Partner_Comp_Linklbl
        ' 
        Partner_Comp_Linklbl.ActiveLinkColor = Color.Goldenrod
        Partner_Comp_Linklbl.BackColor = Color.Orange
        Partner_Comp_Linklbl.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Partner_Comp_Linklbl.ForeColor = SystemColors.ActiveCaptionText
        Partner_Comp_Linklbl.LinkColor = Color.White
        Partner_Comp_Linklbl.Location = New Point(42, 26)
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
        Adm_Sel2_Panel.Location = New Point(-10, 200)
        Adm_Sel2_Panel.Name = "Adm_Sel2_Panel"
        Adm_Sel2_Panel.Size = New Size(277, 125)
        Adm_Sel2_Panel.TabIndex = 16
        ' 
        ' Stud_Regis_Linklbl
        ' 
        Stud_Regis_Linklbl.ActiveLinkColor = Color.Goldenrod
        Stud_Regis_Linklbl.BackColor = Color.Orange
        Stud_Regis_Linklbl.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Stud_Regis_Linklbl.ForeColor = SystemColors.ActiveCaptionText
        Stud_Regis_Linklbl.LinkColor = Color.White
        Stud_Regis_Linklbl.Location = New Point(42, 28)
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
        Adm_Sel1_Panel.Location = New Point(-10, 50)
        Adm_Sel1_Panel.Name = "Adm_Sel1_Panel"
        Adm_Sel1_Panel.Size = New Size(277, 125)
        Adm_Sel1_Panel.TabIndex = 15
        ' 
        ' Student_Eval_LinkLbl
        ' 
        Student_Eval_LinkLbl.ActiveLinkColor = Color.Goldenrod
        Student_Eval_LinkLbl.BackColor = SystemColors.Control
        Student_Eval_LinkLbl.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Student_Eval_LinkLbl.ForeColor = SystemColors.ActiveCaptionText
        Student_Eval_LinkLbl.LinkColor = Color.Black
        Student_Eval_LinkLbl.Location = New Point(45, 26)
        Student_Eval_LinkLbl.Name = "Student_Eval_LinkLbl"
        Student_Eval_LinkLbl.Size = New Size(215, 70)
        Student_Eval_LinkLbl.TabIndex = 11
        Student_Eval_LinkLbl.TabStop = True
        Student_Eval_LinkLbl.Text = "STUDENT" & vbCrLf & "EVALUATION"
        Student_Eval_LinkLbl.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Functions_Panel
        ' 
        Functions_Panel.Controls.Add(LinkLabel1)
        Functions_Panel.Dock = DockStyle.Fill
        Functions_Panel.Location = New Point(0, 180)
        Functions_Panel.Name = "Functions_Panel"
        Functions_Panel.Size = New Size(1902, 875)
        Functions_Panel.TabIndex = 11
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.ActiveLinkColor = Color.Goldenrod
        LinkLabel1.BackColor = SystemColors.Control
        LinkLabel1.Font = New Font("Arial Rounded MT Bold", 16.2F)
        LinkLabel1.ForeColor = SystemColors.ActiveCaptionText
        LinkLabel1.LinkColor = Color.Black
        LinkLabel1.Location = New Point(76, 816)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(143, 41)
        LinkLabel1.TabIndex = 11
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "LOGOUT"
        LinkLabel1.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' MainMenu_Panel
        ' 
        MainMenu_Panel.BackColor = Color.Navy
        MainMenu_Panel.Controls.Add(SchoolTitle_Panel)
        MainMenu_Panel.Controls.Add(RightTop_Panel)
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
        ' RightTop_Panel
        ' 
        RightTop_Panel.Controls.Add(Dashboard_BTN)
        RightTop_Panel.Controls.Add(FunctionOperation_BTN)
        RightTop_Panel.Dock = DockStyle.Right
        RightTop_Panel.Location = New Point(1064, 0)
        RightTop_Panel.Name = "RightTop_Panel"
        RightTop_Panel.Size = New Size(838, 180)
        RightTop_Panel.TabIndex = 11
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
        ' FunctionOperation_BTN
        ' 
        FunctionOperation_BTN.ActiveLinkColor = Color.Goldenrod
        FunctionOperation_BTN.BackColor = Color.Navy
        FunctionOperation_BTN.Font = New Font("Arial Rounded MT Bold", 16.2F)
        FunctionOperation_BTN.LinkColor = Color.White
        FunctionOperation_BTN.Location = New Point(387, 3)
        FunctionOperation_BTN.Name = "FunctionOperation_BTN"
        FunctionOperation_BTN.Size = New Size(387, 149)
        FunctionOperation_BTN.TabIndex = 8
        FunctionOperation_BTN.TabStop = True
        FunctionOperation_BTN.Text = "FUNCTIONS & OPERATIONS"
        FunctionOperation_BTN.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' Logout_Panel
        ' 
        Logout_Panel.Controls.Add(Logout_BTN)
        Logout_Panel.Location = New Point(72, 1001)
        Logout_Panel.Name = "Logout_Panel"
        Logout_Panel.Size = New Size(143, 70)
        Logout_Panel.TabIndex = 4
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
        Stud_Regis_Panel.ResumeLayout(False)
        Stud_Regis_Panel.PerformLayout()
        Fac_Eval_Panel.ResumeLayout(False)
        Fac_Eval_Panel.PerformLayout()
        Partner_Comp_Panel.ResumeLayout(False)
        Partner_Comp_Panel.PerformLayout()
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
        Logout_Panel.ResumeLayout(False)
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
    Friend WithEvents Logout_BTN As LinkLabel
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
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Logout_Panel As Panel
End Class
