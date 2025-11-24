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
        MaskedTextBox3 = New MaskedTextBox()
        MaskedTextBox2 = New MaskedTextBox()
        MaskedTextBox1 = New MaskedTextBox()
        TextBox8 = New TextBox()
        TextBox7 = New TextBox()
        Label6 = New Label()
        Button5 = New Button()
        Button4 = New Button()
        Label18 = New Label()
        Label16 = New Label()
        TextBox11 = New TextBox()
        Label17 = New Label()
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
        Label1 = New Label()
        Panel5 = New Panel()
        Section_Panel = New Panel()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        SecTitle_Panel = New Panel()
        Label3 = New Label()
        Panel8 = New Panel()
        Fac_SecInfo_DTV = New DataGridView()
        studID_col_lbl = New DataGridViewTextBoxColumn()
        studName_col_lbl = New DataGridViewTextBoxColumn()
        CompAssigned_col_lbl = New DataGridViewTextBoxColumn()
        Supervisor_col_column = New DataGridViewTextBoxColumn()
        Stat_col_lbl = New DataGridViewTextBoxColumn()
        Last_vis_col_lbl = New DataGridViewTextBoxColumn()
        Actions_col_lbl = New DataGridViewTextBoxColumn()
        Fac_Search_txt = New TextBox()
        Undecided_Filter = New ComboBox()
        Fac_SelSec_Cmb = New ComboBox()
        Home_Panel = New Panel()
        Label9 = New Label()
        DataGridView1 = New DataGridView()
        LinkLabel1 = New LinkLabel()
        FacInfo_Panel = New Panel()
        Panel4 = New Panel()
        Panel3 = New Panel()
        Panel2 = New Panel()
        Panel1 = New Panel()
        Time_Position_lbl = New Label()
        Greet_Fac_lbl = New Label()
        FacName_lbl = New Label()
        DeptName_lbl = New Label()
        Faculty_DateTime = New Label()
        MainMenu_Panel = New Panel()
        SchoolTitle_Panel = New Panel()
        Logo_Pic = New PictureBox()
        SchoolName_Lbl = New Label()
        RightTop_Panel = New Panel()
        Home_Linklbl = New LinkLabel()
        Profile_Linklbl = New LinkLabel()
        Logout_BTN = New LinkLabel()
        Section_Linklbl = New LinkLabel()
        Timer1 = New Timer(components)
        Screen_Panel.SuspendLayout()
        Profile_Panel.SuspendLayout()
        FacProfile_Panel.SuspendLayout()
        ProfTitle_Panel.SuspendLayout()
        Section_Panel.SuspendLayout()
        SecTitle_Panel.SuspendLayout()
        CType(Fac_SecInfo_DTV, ComponentModel.ISupportInitialize).BeginInit()
        Home_Panel.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        FacInfo_Panel.SuspendLayout()
        MainMenu_Panel.SuspendLayout()
        SchoolTitle_Panel.SuspendLayout()
        CType(Logo_Pic, ComponentModel.ISupportInitialize).BeginInit()
        RightTop_Panel.SuspendLayout()
        SuspendLayout()
        ' 
        ' Screen_Panel
        ' 
        Screen_Panel.BackColor = SystemColors.Control
        Screen_Panel.Controls.Add(Profile_Panel)
        Screen_Panel.Controls.Add(Section_Panel)
        Screen_Panel.Controls.Add(Home_Panel)
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
        FacProfile_Panel.Controls.Add(MaskedTextBox3)
        FacProfile_Panel.Controls.Add(MaskedTextBox2)
        FacProfile_Panel.Controls.Add(MaskedTextBox1)
        FacProfile_Panel.Controls.Add(TextBox8)
        FacProfile_Panel.Controls.Add(TextBox7)
        FacProfile_Panel.Controls.Add(Label6)
        FacProfile_Panel.Controls.Add(Button5)
        FacProfile_Panel.Controls.Add(Button4)
        FacProfile_Panel.Controls.Add(Label18)
        FacProfile_Panel.Controls.Add(Label16)
        FacProfile_Panel.Controls.Add(TextBox11)
        FacProfile_Panel.Controls.Add(Label17)
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
        FacProfile_Panel.TabIndex = 26
        ' 
        ' MaskedTextBox3
        ' 
        MaskedTextBox3.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MaskedTextBox3.Location = New Point(71, 420)
        MaskedTextBox3.Mask = "+63-000-000-0000"
        MaskedTextBox3.Name = "MaskedTextBox3"
        MaskedTextBox3.Size = New Size(474, 51)
        MaskedTextBox3.TabIndex = 38
        ' 
        ' MaskedTextBox2
        ' 
        MaskedTextBox2.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MaskedTextBox2.Location = New Point(389, 264)
        MaskedTextBox2.Mask = "D000"
        MaskedTextBox2.Name = "MaskedTextBox2"
        MaskedTextBox2.Size = New Size(296, 51)
        MaskedTextBox2.TabIndex = 37
        ' 
        ' MaskedTextBox1
        ' 
        MaskedTextBox1.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MaskedTextBox1.Location = New Point(71, 264)
        MaskedTextBox1.Mask = "F000"
        MaskedTextBox1.Name = "MaskedTextBox1"
        MaskedTextBox1.Size = New Size(296, 51)
        MaskedTextBox1.TabIndex = 36
        ' 
        ' TextBox8
        ' 
        TextBox8.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox8.Location = New Point(1295, 264)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(557, 51)
        TextBox8.TabIndex = 35
        ' 
        ' TextBox7
        ' 
        TextBox7.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox7.Location = New Point(708, 264)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(557, 51)
        TextBox7.TabIndex = 34
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(708, 200)
        Label6.Name = "Label6"
        Label6.Size = New Size(239, 45)
        Label6.TabIndex = 33
        Label6.Text = "Department:"
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Navy
        Button5.Font = New Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button5.ForeColor = Color.Transparent
        Button5.Location = New Point(1114, 527)
        Button5.Name = "Button5"
        Button5.Size = New Size(362, 76)
        Button5.TabIndex = 32
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
        Button4.TabIndex = 31
        Button4.Text = "UPDATE PROFILE"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label18.Location = New Point(71, 363)
        Label18.Name = "Label18"
        Label18.Size = New Size(318, 45)
        Label18.TabIndex = 29
        Label18.Text = "Contact Number:"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.Location = New Point(1295, 199)
        Label16.Name = "Label16"
        Label16.Size = New Size(168, 45)
        Label16.TabIndex = 27
        Label16.Text = "Position:"
        ' 
        ' TextBox11
        ' 
        TextBox11.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox11.Location = New Point(573, 420)
        TextBox11.Name = "TextBox11"
        TextBox11.Size = New Size(477, 51)
        TextBox11.TabIndex = 26
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label17.Location = New Point(573, 363)
        Label17.Name = "Label17"
        Label17.Size = New Size(284, 45)
        Label17.TabIndex = 25
        Label17.Text = "Email Address:"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(389, 200)
        Label12.Name = "Label12"
        Label12.Size = New Size(180, 45)
        Label12.TabIndex = 17
        Label12.Text = "Dept. ID:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
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
        ProfTitle_Panel.Controls.Add(Label1)
        ProfTitle_Panel.Controls.Add(Panel5)
        ProfTitle_Panel.Dock = DockStyle.Top
        ProfTitle_Panel.Location = New Point(0, 0)
        ProfTitle_Panel.Name = "ProfTitle_Panel"
        ProfTitle_Panel.Size = New Size(1902, 177)
        ProfTitle_Panel.TabIndex = 25
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 55.8000031F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(132, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(463, 105)
        Label1.TabIndex = 8
        Label1.Text = "PROFILE"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.Navy
        Panel5.Location = New Point(68, 48)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(38, 105)
        Panel5.TabIndex = 10
        ' 
        ' Section_Panel
        ' 
        Section_Panel.Controls.Add(Button3)
        Section_Panel.Controls.Add(Button2)
        Section_Panel.Controls.Add(Button1)
        Section_Panel.Controls.Add(SecTitle_Panel)
        Section_Panel.Controls.Add(Fac_SecInfo_DTV)
        Section_Panel.Controls.Add(Fac_Search_txt)
        Section_Panel.Controls.Add(Undecided_Filter)
        Section_Panel.Controls.Add(Fac_SelSec_Cmb)
        Section_Panel.Dock = DockStyle.Fill
        Section_Panel.Location = New Point(0, 225)
        Section_Panel.Name = "Section_Panel"
        Section_Panel.Size = New Size(1902, 830)
        Section_Panel.TabIndex = 0
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(1783, 206)
        Button3.Name = "Button3"
        Button3.Size = New Size(61, 56)
        Button3.TabIndex = 11
        Button3.Text = "Button3"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Navy
        Button2.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.Transparent
        Button2.Location = New Point(1106, 720)
        Button2.Name = "Button2"
        Button2.Size = New Size(362, 76)
        Button2.TabIndex = 33
        Button2.Text = "UPDATE "
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Navy
        Button1.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.Transparent
        Button1.Location = New Point(1482, 720)
        Button1.Name = "Button1"
        Button1.Size = New Size(362, 76)
        Button1.TabIndex = 32
        Button1.Text = "UPDATE "
        Button1.UseVisualStyleBackColor = False
        ' 
        ' SecTitle_Panel
        ' 
        SecTitle_Panel.Controls.Add(Label3)
        SecTitle_Panel.Controls.Add(Panel8)
        SecTitle_Panel.Dock = DockStyle.Top
        SecTitle_Panel.Location = New Point(0, 0)
        SecTitle_Panel.Name = "SecTitle_Panel"
        SecTitle_Panel.Size = New Size(1902, 177)
        SecTitle_Panel.TabIndex = 12
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 55.8000031F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(132, 48)
        Label3.Name = "Label3"
        Label3.Size = New Size(469, 105)
        Label3.TabIndex = 8
        Label3.Text = "SECTION"
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
        ' Fac_SecInfo_DTV
        ' 
        Fac_SecInfo_DTV.AllowUserToOrderColumns = True
        Fac_SecInfo_DTV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Fac_SecInfo_DTV.Columns.AddRange(New DataGridViewColumn() {studID_col_lbl, studName_col_lbl, CompAssigned_col_lbl, Supervisor_col_column, Stat_col_lbl, Last_vis_col_lbl, Actions_col_lbl})
        Fac_SecInfo_DTV.Location = New Point(62, 268)
        Fac_SecInfo_DTV.Name = "Fac_SecInfo_DTV"
        Fac_SecInfo_DTV.RowHeadersWidth = 51
        Fac_SecInfo_DTV.Size = New Size(1782, 425)
        Fac_SecInfo_DTV.TabIndex = 4
        ' 
        ' studID_col_lbl
        ' 
        studID_col_lbl.HeaderText = "Student ID"
        studID_col_lbl.MinimumWidth = 6
        studID_col_lbl.Name = "studID_col_lbl"
        studID_col_lbl.Width = 175
        ' 
        ' studName_col_lbl
        ' 
        studName_col_lbl.HeaderText = "Student Name"
        studName_col_lbl.MinimumWidth = 6
        studName_col_lbl.Name = "studName_col_lbl"
        studName_col_lbl.Width = 275
        ' 
        ' CompAssigned_col_lbl
        ' 
        CompAssigned_col_lbl.HeaderText = "Company Assigned"
        CompAssigned_col_lbl.MinimumWidth = 6
        CompAssigned_col_lbl.Name = "CompAssigned_col_lbl"
        CompAssigned_col_lbl.Width = 325
        ' 
        ' Supervisor_col_column
        ' 
        Supervisor_col_column.HeaderText = "Supervisor"
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
        Actions_col_lbl.HeaderText = "Actions"
        Actions_col_lbl.MinimumWidth = 6
        Actions_col_lbl.Name = "Actions_col_lbl"
        Actions_col_lbl.Width = 250
        ' 
        ' Fac_Search_txt
        ' 
        Fac_Search_txt.Font = New Font("Verdana", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Fac_Search_txt.Location = New Point(1482, 206)
        Fac_Search_txt.Name = "Fac_Search_txt"
        Fac_Search_txt.Size = New Size(295, 56)
        Fac_Search_txt.TabIndex = 3
        ' 
        ' Undecided_Filter
        ' 
        Undecided_Filter.Font = New Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Undecided_Filter.FormattingEnabled = True
        Undecided_Filter.Items.AddRange(New Object() {"FILTER BY"})
        Undecided_Filter.Location = New Point(656, 208)
        Undecided_Filter.Name = "Undecided_Filter"
        Undecided_Filter.Size = New Size(206, 54)
        Undecided_Filter.TabIndex = 2
        ' 
        ' Fac_SelSec_Cmb
        ' 
        Fac_SelSec_Cmb.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Fac_SelSec_Cmb.FormattingEnabled = True
        Fac_SelSec_Cmb.Items.AddRange(New Object() {"Sections:", "4A", "4B", "4C", "4D"})
        Fac_SelSec_Cmb.Location = New Point(62, 209)
        Fac_SelSec_Cmb.Name = "Fac_SelSec_Cmb"
        Fac_SelSec_Cmb.Size = New Size(386, 53)
        Fac_SelSec_Cmb.TabIndex = 1
        ' 
        ' Home_Panel
        ' 
        Home_Panel.Controls.Add(Label9)
        Home_Panel.Controls.Add(DataGridView1)
        Home_Panel.Controls.Add(LinkLabel1)
        Home_Panel.Controls.Add(FacInfo_Panel)
        Home_Panel.Dock = DockStyle.Fill
        Home_Panel.Location = New Point(0, 225)
        Home_Panel.Name = "Home_Panel"
        Home_Panel.Size = New Size(1902, 830)
        Home_Panel.TabIndex = 16
        ' 
        ' Label9
        ' 
        Label9.BackColor = Color.Navy
        Label9.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Transparent
        Label9.Location = New Point(68, 449)
        Label9.Name = "Label9"
        Label9.Size = New Size(485, 77)
        Label9.TabIndex = 20
        Label9.Text = "Pending Evaluations:"
        Label9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(68, 529)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1776, 267)
        DataGridView1.TabIndex = 19
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.ActiveLinkColor = Color.Goldenrod
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LinkLabel1.LinkColor = Color.Navy
        LinkLabel1.Location = New Point(146, 356)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(461, 46)
        LinkLabel1.TabIndex = 18
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Download Evaluation Form"
        ' 
        ' FacInfo_Panel
        ' 
        FacInfo_Panel.Controls.Add(Panel4)
        FacInfo_Panel.Controls.Add(Panel3)
        FacInfo_Panel.Controls.Add(Panel2)
        FacInfo_Panel.Controls.Add(Panel1)
        FacInfo_Panel.Controls.Add(Time_Position_lbl)
        FacInfo_Panel.Controls.Add(Greet_Fac_lbl)
        FacInfo_Panel.Controls.Add(FacName_lbl)
        FacInfo_Panel.Controls.Add(DeptName_lbl)
        FacInfo_Panel.Controls.Add(Faculty_DateTime)
        FacInfo_Panel.Dock = DockStyle.Top
        FacInfo_Panel.Location = New Point(0, 0)
        FacInfo_Panel.Name = "FacInfo_Panel"
        FacInfo_Panel.Size = New Size(1902, 436)
        FacInfo_Panel.TabIndex = 9
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.LightBlue
        Panel4.Location = New Point(68, 356)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(38, 46)
        Panel4.TabIndex = 15
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.CornflowerBlue
        Panel3.Location = New Point(68, 300)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(38, 42)
        Panel3.TabIndex = 14
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.RoyalBlue
        Panel2.Location = New Point(68, 241)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(38, 46)
        Panel2.TabIndex = 13
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Navy
        Panel1.Location = New Point(68, 48)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(38, 156)
        Panel1.TabIndex = 12
        ' 
        ' Time_Position_lbl
        ' 
        Time_Position_lbl.AutoSize = True
        Time_Position_lbl.Font = New Font("Times New Roman", 24F, FontStyle.Bold)
        Time_Position_lbl.Location = New Point(146, 241)
        Time_Position_lbl.Name = "Time_Position_lbl"
        Time_Position_lbl.Size = New Size(617, 45)
        Time_Position_lbl.TabIndex = 6
        Time_Position_lbl.Text = "[FULL/PART TIME - POSITION]"
        ' 
        ' Greet_Fac_lbl
        ' 
        Greet_Fac_lbl.AutoSize = True
        Greet_Fac_lbl.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Greet_Fac_lbl.Location = New Point(132, 48)
        Greet_Fac_lbl.Name = "Greet_Fac_lbl"
        Greet_Fac_lbl.Size = New Size(252, 45)
        Greet_Fac_lbl.TabIndex = 0
        Greet_Fac_lbl.Text = "WELCOME!"
        ' 
        ' FacName_lbl
        ' 
        FacName_lbl.AutoSize = True
        FacName_lbl.Font = New Font("Times New Roman", 55.8000031F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FacName_lbl.Location = New Point(121, 90)
        FacName_lbl.Name = "FacName_lbl"
        FacName_lbl.Size = New Size(855, 105)
        FacName_lbl.TabIndex = 5
        FacName_lbl.Text = "[FACULTY NAME]"
        ' 
        ' DeptName_lbl
        ' 
        DeptName_lbl.AutoSize = True
        DeptName_lbl.Font = New Font("Times New Roman", 24F, FontStyle.Bold)
        DeptName_lbl.Location = New Point(146, 300)
        DeptName_lbl.Name = "DeptName_lbl"
        DeptName_lbl.Size = New Size(329, 45)
        DeptName_lbl.TabIndex = 7
        DeptName_lbl.Text = "[DEPARTMENT]"
        ' 
        ' Faculty_DateTime
        ' 
        Faculty_DateTime.Font = New Font("Rockwell", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Faculty_DateTime.Location = New Point(1182, 47)
        Faculty_DateTime.Name = "Faculty_DateTime"
        Faculty_DateTime.Size = New Size(695, 49)
        Faculty_DateTime.TabIndex = 8
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
        Text = "Faculty"
        WindowState = FormWindowState.Maximized
        Screen_Panel.ResumeLayout(False)
        Profile_Panel.ResumeLayout(False)
        FacProfile_Panel.ResumeLayout(False)
        FacProfile_Panel.PerformLayout()
        ProfTitle_Panel.ResumeLayout(False)
        ProfTitle_Panel.PerformLayout()
        Section_Panel.ResumeLayout(False)
        Section_Panel.PerformLayout()
        SecTitle_Panel.ResumeLayout(False)
        SecTitle_Panel.PerformLayout()
        CType(Fac_SecInfo_DTV, ComponentModel.ISupportInitialize).EndInit()
        Home_Panel.ResumeLayout(False)
        Home_Panel.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        FacInfo_Panel.ResumeLayout(False)
        FacInfo_Panel.PerformLayout()
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
    Friend WithEvents Fac_SelSec_Cmb As ComboBox
    Friend WithEvents Fac_SecInfo_DTV As DataGridView
    Friend WithEvents Fac_Search_txt As TextBox
    Friend WithEvents Undecided_Filter As ComboBox
    Friend WithEvents studID_col_lbl As DataGridViewTextBoxColumn
    Friend WithEvents studName_col_lbl As DataGridViewTextBoxColumn
    Friend WithEvents CompAssigned_col_lbl As DataGridViewTextBoxColumn
    Friend WithEvents Supervisor_col_column As DataGridViewTextBoxColumn
    Friend WithEvents Stat_col_lbl As DataGridViewTextBoxColumn
    Friend WithEvents Last_vis_col_lbl As DataGridViewTextBoxColumn
    Friend WithEvents Actions_col_lbl As DataGridViewTextBoxColumn
    Friend WithEvents FacInfo_Panel As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SecTitle_Panel As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Profile_Panel As Panel
    Friend WithEvents ProfTitle_Panel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents FacProfile_Panel As Panel
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Label17 As Label
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
    Friend WithEvents MaskedTextBox3 As MaskedTextBox
    Friend WithEvents MaskedTextBox2 As MaskedTextBox
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
End Class
