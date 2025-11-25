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
        Resources_Panel = New Panel()
        LinkLabel1 = New LinkLabel()
        LinkLabel2 = New LinkLabel()
        LinkLabel3 = New LinkLabel()
        Label9 = New Label()
        Panel5 = New Panel()
        Panel6 = New Panel()
        Panel7 = New Panel()
        Stud_Info_Panel = New Panel()
        Stud_Greeting_lbl = New Label()
        Stud_User_lbl = New Label()
        Assigned_Label = New Label()
        Sup_Label = New Label()
        FacEval_Label = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Panel4 = New Panel()
        Panel3 = New Panel()
        Panel2 = New Panel()
        Panel1 = New Panel()
        Profile_Panel = New Panel()
        StudProfile_Panel = New Panel()
        MaskedTextBox4 = New MaskedTextBox()
        Button5 = New Button()
        Button4 = New Button()
        MaskedTextBox3 = New MaskedTextBox()
        Label18 = New Label()
        TextBox11 = New TextBox()
        Label17 = New Label()
        MaskedTextBox2 = New MaskedTextBox()
        MaskedTextBox1 = New MaskedTextBox()
        TextBox10 = New TextBox()
        Label16 = New Label()
        Label15 = New Label()
        Label14 = New Label()
        TextBox7 = New TextBox()
        Label13 = New Label()
        TextBox6 = New TextBox()
        Label12 = New Label()
        Label11 = New Label()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label10 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        ProfTitle_Panel = New Panel()
        Label3 = New Label()
        Panel8 = New Panel()
        Internship_Panel = New Panel()
        IntStatus_Panel = New Panel()
        TextBox23 = New TextBox()
        Label29 = New Label()
        TextBox22 = New TextBox()
        Label28 = New Label()
        TextBox21 = New TextBox()
        Label25 = New Label()
        TextBox20 = New TextBox()
        Label27 = New Label()
        TextBox19 = New TextBox()
        Label26 = New Label()
        TextBox18 = New TextBox()
        Label24 = New Label()
        TextBox17 = New TextBox()
        Label23 = New Label()
        TextBox16 = New TextBox()
        Label22 = New Label()
        TextBox15 = New TextBox()
        Label21 = New Label()
        TextBox14 = New TextBox()
        Label20 = New Label()
        TextBox13 = New TextBox()
        Label19 = New Label()
        Button2 = New Button()
        TextBox24 = New TextBox()
        Label30 = New Label()
        InternTitle_Panel = New Panel()
        Label1 = New Label()
        Panel9 = New Panel()
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
        ProfTitle_Panel.SuspendLayout()
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
        Screen_Panel.Controls.Add(Profile_Panel)
        Screen_Panel.Controls.Add(Home_Panel)
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
        Resources_Panel.Controls.Add(LinkLabel1)
        Resources_Panel.Controls.Add(LinkLabel2)
        Resources_Panel.Controls.Add(LinkLabel3)
        Resources_Panel.Controls.Add(Label9)
        Resources_Panel.Controls.Add(Panel5)
        Resources_Panel.Controls.Add(Panel6)
        Resources_Panel.Controls.Add(Panel7)
        Resources_Panel.Dock = DockStyle.Left
        Resources_Panel.Location = New Point(0, 438)
        Resources_Panel.Name = "Resources_Panel"
        Resources_Panel.Size = New Size(545, 392)
        Resources_Panel.TabIndex = 22
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.ActiveLinkColor = Color.Gold
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LinkLabel1.LinkColor = Color.Navy
        LinkLabel1.Location = New Point(132, 174)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(268, 46)
        LinkLabel1.TabIndex = 17
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "OJT Guidelines"
        ' 
        ' LinkLabel2
        ' 
        LinkLabel2.ActiveLinkColor = Color.Gold
        LinkLabel2.AutoSize = True
        LinkLabel2.Font = New Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LinkLabel2.LinkColor = Color.Navy
        LinkLabel2.Location = New Point(132, 235)
        LinkLabel2.Name = "LinkLabel2"
        LinkLabel2.Size = New Size(190, 46)
        LinkLabel2.TabIndex = 18
        LinkLabel2.TabStop = True
        LinkLabel2.Text = "Grade Slip"
        ' 
        ' LinkLabel3
        ' 
        LinkLabel3.ActiveLinkColor = Color.Gold
        LinkLabel3.AutoSize = True
        LinkLabel3.Font = New Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LinkLabel3.LinkColor = Color.Navy
        LinkLabel3.Location = New Point(132, 296)
        LinkLabel3.Name = "LinkLabel3"
        LinkLabel3.Size = New Size(277, 46)
        LinkLabel3.TabIndex = 19
        LinkLabel3.TabStop = True
        LinkLabel3.Text = "Company MOA"
        ' 
        ' Label9
        ' 
        Label9.BackColor = Color.Navy
        Label9.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Transparent
        Label9.Location = New Point(68, 70)
        Label9.Name = "Label9"
        Label9.Size = New Size(368, 77)
        Label9.TabIndex = 16
        Label9.Text = "RESOURCES"
        Label9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.RoyalBlue
        Panel5.Location = New Point(68, 174)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(38, 46)
        Panel5.TabIndex = 20
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.CornflowerBlue
        Panel6.Location = New Point(68, 235)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(38, 46)
        Panel6.TabIndex = 12
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.LightBlue
        Panel7.Location = New Point(68, 296)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(38, 46)
        Panel7.TabIndex = 12
        ' 
        ' Stud_Info_Panel
        ' 
        Stud_Info_Panel.Controls.Add(Stud_Greeting_lbl)
        Stud_Info_Panel.Controls.Add(Stud_User_lbl)
        Stud_Info_Panel.Controls.Add(Assigned_Label)
        Stud_Info_Panel.Controls.Add(Sup_Label)
        Stud_Info_Panel.Controls.Add(FacEval_Label)
        Stud_Info_Panel.Controls.Add(Label6)
        Stud_Info_Panel.Controls.Add(Label7)
        Stud_Info_Panel.Controls.Add(Label8)
        Stud_Info_Panel.Controls.Add(Panel4)
        Stud_Info_Panel.Controls.Add(Panel3)
        Stud_Info_Panel.Controls.Add(Panel2)
        Stud_Info_Panel.Controls.Add(Panel1)
        Stud_Info_Panel.Dock = DockStyle.Top
        Stud_Info_Panel.Location = New Point(0, 0)
        Stud_Info_Panel.Name = "Stud_Info_Panel"
        Stud_Info_Panel.Size = New Size(1902, 438)
        Stud_Info_Panel.TabIndex = 21
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
        Stud_User_lbl.Font = New Font("Times New Roman", 55.8000031F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Stud_User_lbl.Location = New Point(121, 90)
        Stud_User_lbl.Name = "Stud_User_lbl"
        Stud_User_lbl.Size = New Size(718, 114)
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
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(448, 241)
        Label6.Name = "Label6"
        Label6.Size = New Size(351, 46)
        Label6.TabIndex = 12
        Label6.Text = "[ PLACEHOLDER ]"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(501, 300)
        Label7.Name = "Label7"
        Label7.Size = New Size(351, 46)
        Label7.TabIndex = 13
        Label7.Text = "[ PLACEHOLDER ]"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(630, 356)
        Label8.Name = "Label8"
        Label8.Size = New Size(351, 46)
        Label8.TabIndex = 14
        Label8.Text = "[ PLACEHOLDER ]"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.LightBlue
        Panel4.Location = New Point(68, 356)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(38, 46)
        Panel4.TabIndex = 11
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.CornflowerBlue
        Panel3.Location = New Point(68, 300)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(38, 42)
        Panel3.TabIndex = 11
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.RoyalBlue
        Panel2.Location = New Point(68, 241)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(38, 46)
        Panel2.TabIndex = 10
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Navy
        Panel1.Location = New Point(68, 48)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(38, 156)
        Panel1.TabIndex = 9
        ' 
        ' Profile_Panel
        ' 
        Profile_Panel.Controls.Add(StudProfile_Panel)
        Profile_Panel.Controls.Add(ProfTitle_Panel)
        Profile_Panel.Dock = DockStyle.Fill
        Profile_Panel.Location = New Point(0, 0)
        Profile_Panel.Name = "Profile_Panel"
        Profile_Panel.Size = New Size(1902, 830)
        Profile_Panel.TabIndex = 1
        ' 
        ' StudProfile_Panel
        ' 
        StudProfile_Panel.Controls.Add(MaskedTextBox4)
        StudProfile_Panel.Controls.Add(Button5)
        StudProfile_Panel.Controls.Add(Button4)
        StudProfile_Panel.Controls.Add(MaskedTextBox3)
        StudProfile_Panel.Controls.Add(Label18)
        StudProfile_Panel.Controls.Add(TextBox11)
        StudProfile_Panel.Controls.Add(Label17)
        StudProfile_Panel.Controls.Add(MaskedTextBox2)
        StudProfile_Panel.Controls.Add(MaskedTextBox1)
        StudProfile_Panel.Controls.Add(TextBox10)
        StudProfile_Panel.Controls.Add(Label16)
        StudProfile_Panel.Controls.Add(Label15)
        StudProfile_Panel.Controls.Add(Label14)
        StudProfile_Panel.Controls.Add(TextBox7)
        StudProfile_Panel.Controls.Add(Label13)
        StudProfile_Panel.Controls.Add(TextBox6)
        StudProfile_Panel.Controls.Add(Label12)
        StudProfile_Panel.Controls.Add(Label11)
        StudProfile_Panel.Controls.Add(TextBox4)
        StudProfile_Panel.Controls.Add(TextBox3)
        StudProfile_Panel.Controls.Add(TextBox2)
        StudProfile_Panel.Controls.Add(TextBox1)
        StudProfile_Panel.Controls.Add(Label10)
        StudProfile_Panel.Controls.Add(Label5)
        StudProfile_Panel.Controls.Add(Label4)
        StudProfile_Panel.Controls.Add(Label2)
        StudProfile_Panel.Dock = DockStyle.Fill
        StudProfile_Panel.Location = New Point(0, 177)
        StudProfile_Panel.Name = "StudProfile_Panel"
        StudProfile_Panel.Size = New Size(1902, 653)
        StudProfile_Panel.TabIndex = 12
        ' 
        ' MaskedTextBox4
        ' 
        MaskedTextBox4.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MaskedTextBox4.Location = New Point(71, 264)
        MaskedTextBox4.Mask = "00-0000"
        MaskedTextBox4.Name = "MaskedTextBox4"
        MaskedTextBox4.Size = New Size(296, 51)
        MaskedTextBox4.TabIndex = 45
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Navy
        Button5.Font = New Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button5.ForeColor = Color.Transparent
        Button5.Location = New Point(1114, 527)
        Button5.Name = "Button5"
        Button5.Size = New Size(362, 76)
        Button5.TabIndex = 44
        Button5.Text = "CHANGE PASSWORD"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Navy
        Button4.Font = New Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.Transparent
        Button4.Location = New Point(1486, 527)
        Button4.Name = "Button4"
        Button4.Size = New Size(362, 76)
        Button4.TabIndex = 43
        Button4.Text = "UPDATE PROFILE"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' MaskedTextBox3
        ' 
        MaskedTextBox3.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MaskedTextBox3.Location = New Point(71, 420)
        MaskedTextBox3.Mask = "+63-000-000-0000"
        MaskedTextBox3.Name = "MaskedTextBox3"
        MaskedTextBox3.Size = New Size(474, 51)
        MaskedTextBox3.TabIndex = 42
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label18.Location = New Point(71, 363)
        Label18.Name = "Label18"
        Label18.Size = New Size(318, 45)
        Label18.TabIndex = 41
        Label18.Text = "Contact Number:"
        ' 
        ' TextBox11
        ' 
        TextBox11.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox11.Location = New Point(573, 420)
        TextBox11.Name = "TextBox11"
        TextBox11.Size = New Size(477, 51)
        TextBox11.TabIndex = 40
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label17.Location = New Point(573, 363)
        Label17.Name = "Label17"
        Label17.Size = New Size(284, 45)
        Label17.TabIndex = 39
        Label17.Text = "Email Address:"
        ' 
        ' MaskedTextBox2
        ' 
        MaskedTextBox2.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MaskedTextBox2.Location = New Point(1294, 261)
        MaskedTextBox2.Mask = "D000"
        MaskedTextBox2.Name = "MaskedTextBox2"
        MaskedTextBox2.Size = New Size(264, 51)
        MaskedTextBox2.TabIndex = 38
        ' 
        ' MaskedTextBox1
        ' 
        MaskedTextBox1.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MaskedTextBox1.Location = New Point(973, 264)
        MaskedTextBox1.Mask = "F000"
        MaskedTextBox1.Name = "MaskedTextBox1"
        MaskedTextBox1.Size = New Size(296, 51)
        MaskedTextBox1.TabIndex = 37
        ' 
        ' TextBox10
        ' 
        TextBox10.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox10.Location = New Point(1584, 264)
        TextBox10.Name = "TextBox10"
        TextBox10.Size = New Size(264, 51)
        TextBox10.TabIndex = 28
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.Location = New Point(1584, 200)
        Label16.Name = "Label16"
        Label16.Size = New Size(155, 45)
        Label16.TabIndex = 27
        Label16.Text = "Section:"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(1295, 200)
        Label15.Name = "Label15"
        Label15.Size = New Size(180, 45)
        Label15.TabIndex = 23
        Label15.Text = "Dept. ID:"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(973, 200)
        Label14.Name = "Label14"
        Label14.Size = New Size(209, 45)
        Label14.TabIndex = 21
        Label14.Text = "Course ID:"
        ' 
        ' TextBox7
        ' 
        TextBox7.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox7.Location = New Point(683, 264)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(264, 51)
        TextBox7.TabIndex = 20
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(683, 200)
        Label13.Name = "Label13"
        Label13.Size = New Size(154, 45)
        Label13.TabIndex = 19
        Label13.Text = "Course:"
        ' 
        ' TextBox6
        ' 
        TextBox6.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox6.Location = New Point(389, 264)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(264, 51)
        TextBox6.TabIndex = 18
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(389, 200)
        Label12.Name = "Label12"
        Label12.Size = New Size(217, 45)
        Label12.TabIndex = 17
        Label12.Text = "Year Level:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(71, 200)
        Label11.Name = "Label11"
        Label11.Size = New Size(218, 45)
        Label11.TabIndex = 15
        Label11.Text = "Student ID:"
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox4.Location = New Point(1584, 98)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(268, 51)
        TextBox4.TabIndex = 14
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox3.Location = New Point(1082, 98)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(477, 51)
        TextBox3.TabIndex = 13
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(573, 98)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(477, 51)
        TextBox2.TabIndex = 12
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(68, 98)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(477, 51)
        TextBox1.TabIndex = 11
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(1584, 41)
        Label10.Name = "Label10"
        Label10.Size = New Size(135, 45)
        Label10.TabIndex = 10
        Label10.Text = "Suffix:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(1082, 41)
        Label5.Name = "Label5"
        Label5.Size = New Size(220, 45)
        Label5.TabIndex = 9
        Label5.Text = "Last Name:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(573, 41)
        Label4.Name = "Label4"
        Label4.Size = New Size(266, 45)
        Label4.TabIndex = 8
        Label4.Text = "Middle Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(68, 41)
        Label2.Name = "Label2"
        Label2.Size = New Size(227, 45)
        Label2.TabIndex = 7
        Label2.Text = "First Name:"
        ' 
        ' ProfTitle_Panel
        ' 
        ProfTitle_Panel.Controls.Add(Label3)
        ProfTitle_Panel.Controls.Add(Panel8)
        ProfTitle_Panel.Dock = DockStyle.Top
        ProfTitle_Panel.Location = New Point(0, 0)
        ProfTitle_Panel.Name = "ProfTitle_Panel"
        ProfTitle_Panel.Size = New Size(1902, 177)
        ProfTitle_Panel.TabIndex = 11
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 55.8000031F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(132, 48)
        Label3.Name = "Label3"
        Label3.Size = New Size(463, 105)
        Label3.TabIndex = 8
        Label3.Text = "PROFILE"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.Navy
        Panel8.Location = New Point(68, 48)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(38, 105)
        Panel8.TabIndex = 10
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
        IntStatus_Panel.Controls.Add(TextBox23)
        IntStatus_Panel.Controls.Add(Label29)
        IntStatus_Panel.Controls.Add(TextBox22)
        IntStatus_Panel.Controls.Add(Label28)
        IntStatus_Panel.Controls.Add(TextBox21)
        IntStatus_Panel.Controls.Add(Label25)
        IntStatus_Panel.Controls.Add(TextBox20)
        IntStatus_Panel.Controls.Add(Label27)
        IntStatus_Panel.Controls.Add(TextBox19)
        IntStatus_Panel.Controls.Add(Label26)
        IntStatus_Panel.Controls.Add(TextBox18)
        IntStatus_Panel.Controls.Add(Label24)
        IntStatus_Panel.Controls.Add(TextBox17)
        IntStatus_Panel.Controls.Add(Label23)
        IntStatus_Panel.Controls.Add(TextBox16)
        IntStatus_Panel.Controls.Add(Label22)
        IntStatus_Panel.Controls.Add(TextBox15)
        IntStatus_Panel.Controls.Add(Label21)
        IntStatus_Panel.Controls.Add(TextBox14)
        IntStatus_Panel.Controls.Add(Label20)
        IntStatus_Panel.Controls.Add(TextBox13)
        IntStatus_Panel.Controls.Add(Label19)
        IntStatus_Panel.Controls.Add(Button2)
        IntStatus_Panel.Controls.Add(TextBox24)
        IntStatus_Panel.Controls.Add(Label30)
        IntStatus_Panel.Dock = DockStyle.Fill
        IntStatus_Panel.Location = New Point(0, 177)
        IntStatus_Panel.Name = "IntStatus_Panel"
        IntStatus_Panel.Size = New Size(1902, 653)
        IntStatus_Panel.TabIndex = 14
        ' 
        ' TextBox23
        ' 
        TextBox23.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox23.Location = New Point(710, 248)
        TextBox23.Name = "TextBox23"
        TextBox23.Size = New Size(818, 51)
        TextBox23.TabIndex = 55
        ' 
        ' Label29
        ' 
        Label29.AutoSize = True
        Label29.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label29.Location = New Point(710, 191)
        Label29.Name = "Label29"
        Label29.Size = New Size(358, 45)
        Label29.TabIndex = 54
        Label29.Text = "Company Assigned:"
        ' 
        ' TextBox22
        ' 
        TextBox22.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox22.Location = New Point(389, 248)
        TextBox22.Name = "TextBox22"
        TextBox22.Size = New Size(299, 51)
        TextBox22.TabIndex = 53
        ' 
        ' Label28
        ' 
        Label28.AutoSize = True
        Label28.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label28.Location = New Point(389, 191)
        Label28.Name = "Label28"
        Label28.Size = New Size(190, 45)
        Label28.TabIndex = 52
        Label28.Text = "Semester:"
        ' 
        ' TextBox21
        ' 
        TextBox21.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox21.Location = New Point(68, 248)
        TextBox21.Name = "TextBox21"
        TextBox21.Size = New Size(299, 51)
        TextBox21.TabIndex = 51
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label25.Location = New Point(68, 191)
        Label25.Name = "Label25"
        Label25.Size = New Size(233, 45)
        Label25.TabIndex = 50
        Label25.Text = "School Year:"
        ' 
        ' TextBox20
        ' 
        TextBox20.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox20.Location = New Point(389, 552)
        TextBox20.Name = "TextBox20"
        TextBox20.Size = New Size(880, 51)
        TextBox20.TabIndex = 49
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label27.Location = New Point(389, 495)
        Label27.Name = "Label27"
        Label27.Size = New Size(345, 45)
        Label27.TabIndex = 48
        Label27.Text = "Company Address:"
        ' 
        ' TextBox19
        ' 
        TextBox19.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox19.Location = New Point(68, 552)
        TextBox19.Name = "TextBox19"
        TextBox19.Size = New Size(299, 51)
        TextBox19.TabIndex = 46
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label26.Location = New Point(68, 495)
        Label26.Name = "Label26"
        Label26.Size = New Size(252, 45)
        Label26.TabIndex = 45
        Label26.Text = "Company ID:"
        ' 
        ' TextBox18
        ' 
        TextBox18.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox18.Location = New Point(970, 98)
        TextBox18.Name = "TextBox18"
        TextBox18.Size = New Size(558, 51)
        TextBox18.TabIndex = 44
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label24.Location = New Point(970, 41)
        Label24.Name = "Label24"
        Label24.Size = New Size(193, 45)
        Label24.TabIndex = 43
        Label24.Text = "End Date:"
        ' 
        ' TextBox17
        ' 
        TextBox17.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox17.Location = New Point(389, 98)
        TextBox17.Name = "TextBox17"
        TextBox17.Size = New Size(558, 51)
        TextBox17.TabIndex = 42
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label23.Location = New Point(389, 41)
        Label23.Name = "Label23"
        Label23.Size = New Size(209, 45)
        Label23.TabIndex = 41
        Label23.Text = "Start Date:"
        ' 
        ' TextBox16
        ' 
        TextBox16.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox16.Location = New Point(1294, 411)
        TextBox16.Name = "TextBox16"
        TextBox16.Size = New Size(558, 51)
        TextBox16.TabIndex = 40
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label22.Location = New Point(1294, 354)
        Label22.Name = "Label22"
        Label22.Size = New Size(218, 45)
        Label22.TabIndex = 39
        Label22.Text = "Supervisor:"
        ' 
        ' TextBox15
        ' 
        TextBox15.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox15.Location = New Point(970, 412)
        TextBox15.Name = "TextBox15"
        TextBox15.Size = New Size(299, 51)
        TextBox15.TabIndex = 38
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label21.Location = New Point(970, 354)
        Label21.Name = "Label21"
        Label21.Size = New Size(272, 45)
        Label21.TabIndex = 37
        Label21.Text = "Supervisor ID:"
        ' 
        ' TextBox14
        ' 
        TextBox14.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox14.Location = New Point(389, 411)
        TextBox14.Name = "TextBox14"
        TextBox14.Size = New Size(558, 51)
        TextBox14.TabIndex = 36
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label20.Location = New Point(389, 354)
        Label20.Name = "Label20"
        Label20.Size = New Size(339, 45)
        Label20.TabIndex = 35
        Label20.Text = "Faculty Evaluator:"
        ' 
        ' TextBox13
        ' 
        TextBox13.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox13.Location = New Point(68, 411)
        TextBox13.Name = "TextBox13"
        TextBox13.Size = New Size(299, 51)
        TextBox13.TabIndex = 33
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label19.Location = New Point(68, 354)
        Label19.Name = "Label19"
        Label19.Size = New Size(215, 45)
        Label19.TabIndex = 32
        Label19.Text = "Faculty ID:"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Navy
        Button2.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.Transparent
        Button2.Location = New Point(1486, 527)
        Button2.Name = "Button2"
        Button2.Size = New Size(362, 76)
        Button2.TabIndex = 31
        Button2.Text = "UPDATE "
        Button2.UseVisualStyleBackColor = False
        ' 
        ' TextBox24
        ' 
        TextBox24.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox24.Location = New Point(68, 98)
        TextBox24.Name = "TextBox24"
        TextBox24.Size = New Size(299, 51)
        TextBox24.TabIndex = 11
        ' 
        ' Label30
        ' 
        Label30.AutoSize = True
        Label30.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label30.Location = New Point(68, 41)
        Label30.Name = "Label30"
        Label30.Size = New Size(195, 45)
        Label30.TabIndex = 7
        Label30.Text = "Intern ID:"
        ' 
        ' InternTitle_Panel
        ' 
        InternTitle_Panel.Controls.Add(Label1)
        InternTitle_Panel.Controls.Add(Panel9)
        InternTitle_Panel.Dock = DockStyle.Top
        InternTitle_Panel.Location = New Point(0, 0)
        InternTitle_Panel.Name = "InternTitle_Panel"
        InternTitle_Panel.Size = New Size(1902, 177)
        InternTitle_Panel.TabIndex = 13
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 55.8000031F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(132, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(1002, 105)
        Label1.TabIndex = 11
        Label1.Text = "INTERNSHIP STATUS"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.Navy
        Panel9.Location = New Point(68, 48)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(38, 105)
        Panel9.TabIndex = 12
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
        ProfTitle_Panel.ResumeLayout(False)
        ProfTitle_Panel.PerformLayout()
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
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Stud_Info_Panel As Panel
    Friend WithEvents Resources_Panel As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ProfTitle_Panel As Panel
    Friend WithEvents StudProfile_Panel As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents InternTitle_Panel As Panel
    Friend WithEvents IntStatus_Panel As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox24 As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents TextBox15 As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents TextBox16 As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents TextBox18 As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents TextBox17 As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents TextBox20 As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents TextBox19 As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents TextBox21 As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents TextBox23 As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents TextBox22 As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents MaskedTextBox2 As MaskedTextBox
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents MaskedTextBox3 As MaskedTextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents MaskedTextBox4 As MaskedTextBox
End Class
