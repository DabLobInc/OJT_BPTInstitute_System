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
        Profile_Panel = New Panel()
        FacProfile_Panel = New Panel()
        MaskedTextBox1 = New MaskedTextBox()
        TextBox6 = New TextBox()
        Label8 = New Label()
        Button5 = New Button()
        Button4 = New Button()
        MaskedTextBox3 = New MaskedTextBox()
        Label18 = New Label()
        TextBox11 = New TextBox()
        Label17 = New Label()
        MaskedTextBox2 = New MaskedTextBox()
        Label15 = New Label()
        TextBox7 = New TextBox()
        Label13 = New Label()
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
        Section_Panel = New Panel()
        Button1 = New Button()
        TextBox5 = New TextBox()
        Label7 = New Label()
        ComboBox1 = New ComboBox()
        FilterSec_Panel = New Panel()
        CheckBox5 = New CheckBox()
        CheckBox6 = New CheckBox()
        CheckBox7 = New CheckBox()
        CheckBox8 = New CheckBox()
        SectionTitle_Panel = New Panel()
        Label1 = New Label()
        Panel2 = New Panel()
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
        Fac_DeptName__lbl = New Label()
        Fac_DeptID__lbl = New Label()
        Fac_FacID__lbl = New Label()
        Fac_Suffix_txt = New TextBox()
        Fac_LName_txt = New TextBox()
        Fac_MName_txt = New TextBox()
        Fac_FName_txt = New TextBox()
        Fac_Suffix_lbl = New Label()
        Fac_LName_lbl = New Label()
        Fac_MName_lbl = New Label()
        Fac_FName_lbl = New Label()
        Profile_lbl = New Label()
        Timer1 = New Timer(components)
        Screen_Panel.SuspendLayout()
        Profile_Panel.SuspendLayout()
        FacProfile_Panel.SuspendLayout()
        ProfTitle_Panel.SuspendLayout()
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
        Screen_Panel.Controls.Add(Section_Panel)
        Screen_Panel.Controls.Add(Profile_Panel)
        Screen_Panel.Controls.Add(MainMenu_Panel)
        Screen_Panel.Dock = DockStyle.Fill
        Screen_Panel.Location = New Point(0, 0)
        Screen_Panel.Name = "Screen_Panel"
        Screen_Panel.Size = New Size(1902, 1055)
        Screen_Panel.TabIndex = 13
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
        FacProfile_Panel.Controls.Add(MaskedTextBox1)
        FacProfile_Panel.Controls.Add(TextBox6)
        FacProfile_Panel.Controls.Add(Label8)
        FacProfile_Panel.Controls.Add(Button5)
        FacProfile_Panel.Controls.Add(Button4)
        FacProfile_Panel.Controls.Add(MaskedTextBox3)
        FacProfile_Panel.Controls.Add(Label18)
        FacProfile_Panel.Controls.Add(TextBox11)
        FacProfile_Panel.Controls.Add(Label17)
        FacProfile_Panel.Controls.Add(MaskedTextBox2)
        FacProfile_Panel.Controls.Add(Label15)
        FacProfile_Panel.Controls.Add(TextBox7)
        FacProfile_Panel.Controls.Add(Label13)
        FacProfile_Panel.Controls.Add(Label12)
        FacProfile_Panel.Controls.Add(Label11)
        FacProfile_Panel.Controls.Add(TextBox4)
        FacProfile_Panel.Controls.Add(TextBox3)
        FacProfile_Panel.Controls.Add(TextBox2)
        FacProfile_Panel.Controls.Add(TextBox1)
        FacProfile_Panel.Controls.Add(Label10)
        FacProfile_Panel.Controls.Add(Label5)
        FacProfile_Panel.Controls.Add(Label4)
        FacProfile_Panel.Controls.Add(Label2)
        FacProfile_Panel.Dock = DockStyle.Fill
        FacProfile_Panel.Location = New Point(0, 177)
        FacProfile_Panel.Name = "FacProfile_Panel"
        FacProfile_Panel.Size = New Size(1902, 653)
        FacProfile_Panel.TabIndex = 13
        ' 
        ' MaskedTextBox1
        ' 
        MaskedTextBox1.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MaskedTextBox1.Location = New Point(72, 264)
        MaskedTextBox1.Mask = "F000"
        MaskedTextBox1.Name = "MaskedTextBox1"
        MaskedTextBox1.Size = New Size(264, 51)
        MaskedTextBox1.TabIndex = 47
        ' 
        ' TextBox6
        ' 
        TextBox6.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox6.Location = New Point(1259, 264)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(593, 51)
        TextBox6.TabIndex = 46
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Times New Roman", 24.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(1259, 200)
        Label8.Name = "Label8"
        Label8.Size = New Size(168, 45)
        Label8.TabIndex = 45
        Label8.Text = "Position:"
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Navy
        Button5.Font = New Font("Times New Roman", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
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
        Button4.Font = New Font("Times New Roman", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
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
        Label18.Font = New Font("Times New Roman", 24.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
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
        Label17.Font = New Font("Times New Roman", 24.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label17.Location = New Point(573, 363)
        Label17.Name = "Label17"
        Label17.Size = New Size(284, 45)
        Label17.TabIndex = 39
        Label17.Text = "Email Address:"
        ' 
        ' MaskedTextBox2
        ' 
        MaskedTextBox2.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MaskedTextBox2.Location = New Point(361, 264)
        MaskedTextBox2.Mask = "D000"
        MaskedTextBox2.Name = "MaskedTextBox2"
        MaskedTextBox2.Size = New Size(264, 51)
        MaskedTextBox2.TabIndex = 38
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Times New Roman", 24.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(362, 203)
        Label15.Name = "Label15"
        Label15.Size = New Size(180, 45)
        Label15.TabIndex = 23
        Label15.Text = "Dept. ID:"
        ' 
        ' TextBox7
        ' 
        TextBox7.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox7.Location = New Point(650, 264)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(593, 51)
        TextBox7.TabIndex = 20
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Times New Roman", 24.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(650, 200)
        Label13.Name = "Label13"
        Label13.Size = New Size(239, 45)
        Label13.TabIndex = 19
        Label13.Text = "Department:"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Times New Roman", 24.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(389, 200)
        Label12.Name = "Label12"
        Label12.Size = New Size(0, 45)
        Label12.TabIndex = 17
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Times New Roman", 24.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(71, 200)
        Label11.Name = "Label11"
        Label11.Size = New Size(215, 45)
        Label11.TabIndex = 15
        Label11.Text = "Faculty ID:"
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
        Label10.Font = New Font("Times New Roman", 24.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(1584, 41)
        Label10.Name = "Label10"
        Label10.Size = New Size(135, 45)
        Label10.TabIndex = 10
        Label10.Text = "Suffix:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 24.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(1082, 41)
        Label5.Name = "Label5"
        Label5.Size = New Size(220, 45)
        Label5.TabIndex = 9
        Label5.Text = "Last Name:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 24.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(573, 41)
        Label4.Name = "Label4"
        Label4.Size = New Size(266, 45)
        Label4.TabIndex = 8
        Label4.Text = "Middle Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 24.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
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
        ProfTitle_Panel.TabIndex = 12
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
        ' Section_Panel
        ' 
        Section_Panel.Controls.Add(Button1)
        Section_Panel.Controls.Add(TextBox5)
        Section_Panel.Controls.Add(Label7)
        Section_Panel.Controls.Add(ComboBox1)
        Section_Panel.Controls.Add(FilterSec_Panel)
        Section_Panel.Controls.Add(SectionTitle_Panel)
        Section_Panel.Controls.Add(Fac_SecInfo_DTV)
        Section_Panel.Dock = DockStyle.Fill
        Section_Panel.Location = New Point(0, 225)
        Section_Panel.Name = "Section_Panel"
        Section_Panel.Size = New Size(1902, 830)
        Section_Panel.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(1767, 256)
        Button1.Name = "Button1"
        Button1.Size = New Size(58, 53)
        Button1.TabIndex = 18
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox5
        ' 
        TextBox5.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox5.Location = New Point(1348, 258)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(413, 51)
        TextBox5.TabIndex = 17
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(68, 235)
        Label7.Name = "Label7"
        Label7.Size = New Size(71, 20)
        Label7.TabIndex = 16
        Label7.Text = "SECTION:"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(68, 258)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(296, 53)
        ComboBox1.TabIndex = 15
        ' 
        ' FilterSec_Panel
        ' 
        FilterSec_Panel.Controls.Add(CheckBox5)
        FilterSec_Panel.Controls.Add(CheckBox6)
        FilterSec_Panel.Controls.Add(CheckBox7)
        FilterSec_Panel.Controls.Add(CheckBox8)
        FilterSec_Panel.Location = New Point(429, 218)
        FilterSec_Panel.Name = "FilterSec_Panel"
        FilterSec_Panel.Size = New Size(270, 93)
        FilterSec_Panel.TabIndex = 14
        ' 
        ' CheckBox5
        ' 
        CheckBox5.AutoSize = True
        CheckBox5.Location = New Point(144, 49)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(91, 24)
        CheckBox5.TabIndex = 3
        CheckBox5.Text = "Dropped"
        CheckBox5.UseVisualStyleBackColor = True
        ' 
        ' CheckBox6
        ' 
        CheckBox6.AutoSize = True
        CheckBox6.Location = New Point(144, 19)
        CheckBox6.Name = "CheckBox6"
        CheckBox6.Size = New Size(72, 24)
        CheckBox6.TabIndex = 2
        CheckBox6.Text = "Active"
        CheckBox6.UseVisualStyleBackColor = True
        ' 
        ' CheckBox7
        ' 
        CheckBox7.AutoSize = True
        CheckBox7.Location = New Point(21, 49)
        CheckBox7.Name = "CheckBox7"
        CheckBox7.Size = New Size(96, 24)
        CheckBox7.TabIndex = 1
        CheckBox7.Text = "Complete"
        CheckBox7.UseVisualStyleBackColor = True
        ' 
        ' CheckBox8
        ' 
        CheckBox8.AutoSize = True
        CheckBox8.Location = New Point(21, 19)
        CheckBox8.Name = "CheckBox8"
        CheckBox8.Size = New Size(84, 24)
        CheckBox8.TabIndex = 0
        CheckBox8.Text = "Pending"
        CheckBox8.UseVisualStyleBackColor = True
        ' 
        ' SectionTitle_Panel
        ' 
        SectionTitle_Panel.Controls.Add(Label1)
        SectionTitle_Panel.Controls.Add(Panel2)
        SectionTitle_Panel.Dock = DockStyle.Top
        SectionTitle_Panel.Location = New Point(0, 0)
        SectionTitle_Panel.Name = "SectionTitle_Panel"
        SectionTitle_Panel.Size = New Size(1902, 177)
        SectionTitle_Panel.TabIndex = 12
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 55.8000031F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(132, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(469, 105)
        Label1.TabIndex = 8
        Label1.Text = "SECTION"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Navy
        Panel2.Location = New Point(68, 48)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(38, 105)
        Panel2.TabIndex = 10
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
        ' Fac_DeptName__lbl
        ' 
        Fac_DeptName__lbl.Location = New Point(0, 0)
        Fac_DeptName__lbl.Name = "Fac_DeptName__lbl"
        Fac_DeptName__lbl.Size = New Size(100, 23)
        Fac_DeptName__lbl.TabIndex = 0
        ' 
        ' Fac_DeptID__lbl
        ' 
        Fac_DeptID__lbl.Location = New Point(0, 0)
        Fac_DeptID__lbl.Name = "Fac_DeptID__lbl"
        Fac_DeptID__lbl.Size = New Size(100, 23)
        Fac_DeptID__lbl.TabIndex = 0
        ' 
        ' Fac_FacID__lbl
        ' 
        Fac_FacID__lbl.Location = New Point(0, 0)
        Fac_FacID__lbl.Name = "Fac_FacID__lbl"
        Fac_FacID__lbl.Size = New Size(100, 23)
        Fac_FacID__lbl.TabIndex = 0
        ' 
        ' Fac_Suffix_txt
        ' 
        Fac_Suffix_txt.Location = New Point(0, 0)
        Fac_Suffix_txt.Name = "Fac_Suffix_txt"
        Fac_Suffix_txt.Size = New Size(100, 27)
        Fac_Suffix_txt.TabIndex = 0
        ' 
        ' Fac_LName_txt
        ' 
        Fac_LName_txt.Location = New Point(0, 0)
        Fac_LName_txt.Name = "Fac_LName_txt"
        Fac_LName_txt.Size = New Size(100, 27)
        Fac_LName_txt.TabIndex = 0
        ' 
        ' Fac_MName_txt
        ' 
        Fac_MName_txt.Location = New Point(0, 0)
        Fac_MName_txt.Name = "Fac_MName_txt"
        Fac_MName_txt.Size = New Size(100, 27)
        Fac_MName_txt.TabIndex = 0
        ' 
        ' Fac_FName_txt
        ' 
        Fac_FName_txt.Location = New Point(0, 0)
        Fac_FName_txt.Name = "Fac_FName_txt"
        Fac_FName_txt.Size = New Size(100, 27)
        Fac_FName_txt.TabIndex = 0
        ' 
        ' Fac_Suffix_lbl
        ' 
        Fac_Suffix_lbl.Location = New Point(0, 0)
        Fac_Suffix_lbl.Name = "Fac_Suffix_lbl"
        Fac_Suffix_lbl.Size = New Size(100, 23)
        Fac_Suffix_lbl.TabIndex = 0
        ' 
        ' Fac_LName_lbl
        ' 
        Fac_LName_lbl.Location = New Point(0, 0)
        Fac_LName_lbl.Name = "Fac_LName_lbl"
        Fac_LName_lbl.Size = New Size(100, 23)
        Fac_LName_lbl.TabIndex = 0
        ' 
        ' Fac_MName_lbl
        ' 
        Fac_MName_lbl.Location = New Point(0, 0)
        Fac_MName_lbl.Name = "Fac_MName_lbl"
        Fac_MName_lbl.Size = New Size(100, 23)
        Fac_MName_lbl.TabIndex = 0
        ' 
        ' Fac_FName_lbl
        ' 
        Fac_FName_lbl.Location = New Point(0, 0)
        Fac_FName_lbl.Name = "Fac_FName_lbl"
        Fac_FName_lbl.Size = New Size(100, 23)
        Fac_FName_lbl.TabIndex = 0
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
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(1902, 1055)
        Controls.Add(Screen_Panel)
        Name = "Faculty_Dashboard"
        Text = "w"
        WindowState = FormWindowState.Maximized
        Screen_Panel.ResumeLayout(False)
        Profile_Panel.ResumeLayout(False)
        FacProfile_Panel.ResumeLayout(False)
        FacProfile_Panel.PerformLayout()
        ProfTitle_Panel.ResumeLayout(False)
        ProfTitle_Panel.PerformLayout()
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
    Friend WithEvents Fac_FName_lbl As Label
    Friend WithEvents Fac_MName_lbl As Label
    Friend WithEvents Fac_Suffix_txt As TextBox
    Friend WithEvents Fac_LName_txt As TextBox
    Friend WithEvents Fac_FName_txt As TextBox
    Friend WithEvents Fac_MName_txt As TextBox
    Friend WithEvents Profile_lbl As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents SectionTitle_Panel As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SecTitle_Panel As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Profile_Panel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents ProfTitle_Panel As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents FilterSec_Panel As Panel
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents studID_col_lbl As DataGridViewTextBoxColumn
    Friend WithEvents studName_col_lbl As DataGridViewTextBoxColumn
    Friend WithEvents CompAssigned_col_lbl As DataGridViewTextBoxColumn
    Friend WithEvents Supervisor_col_column As DataGridViewTextBoxColumn
    Friend WithEvents Stat_col_lbl As DataGridViewTextBoxColumn
    Friend WithEvents Last_vis_col_lbl As DataGridViewTextBoxColumn
    Friend WithEvents Actions_col_lbl As DataGridViewTextBoxColumn
    Friend WithEvents FacProfile_Panel As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents MaskedTextBox3 As MaskedTextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents MaskedTextBox2 As MaskedTextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
End Class
