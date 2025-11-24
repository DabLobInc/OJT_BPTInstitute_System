<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Faculty_Dashboard
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
        Faculty_DateTime = New Label()
        DeptName_lbl = New Label()
        FacName_lbl = New Label()
        Time_Position_lbl = New Label()
        Greet_Fac_lbl = New Label()
        Section_Panel = New Panel()
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
        Section_lbl = New Label()
        Profile_Panel = New Panel()
        Fac_UpdProfile_Btn = New Button()
        Fac_ChangePass_Btn = New Button()
        Fac_EmailAdd_Mtxt = New MaskedTextBox()
        Fac_ContNum_Mtxt = New MaskedTextBox()
        Fac_DeptID_mtxt = New MaskedTextBox()
        Fac_FacID_mtxt = New MaskedTextBox()
        Fac_EmailAdd_lbl = New Label()
        Fac_Postion_txt = New TextBox()
        Fac_ContNum__lbl = New Label()
        Fac_Position__lbl = New Label()
        TextBox7 = New TextBox()
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
        Home_Panel.SuspendLayout()
        Section_Panel.SuspendLayout()
        CType(Fac_SecInfo_DTV, ComponentModel.ISupportInitialize).BeginInit()
        Profile_Panel.SuspendLayout()
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
        Home_Panel.Controls.Add(Faculty_DateTime)
        Home_Panel.Controls.Add(DeptName_lbl)
        Home_Panel.Controls.Add(FacName_lbl)
        Home_Panel.Controls.Add(Time_Position_lbl)
        Home_Panel.Controls.Add(Greet_Fac_lbl)
        Home_Panel.Dock = DockStyle.Fill
        Home_Panel.Location = New Point(0, 225)
        Home_Panel.Name = "Home_Panel"
        Home_Panel.Size = New Size(1902, 830)
        Home_Panel.TabIndex = 16
        ' 
        ' Faculty_DateTime
        ' 
        Faculty_DateTime.Font = New Font("Rockwell", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Faculty_DateTime.Location = New Point(1123, 49)
        Faculty_DateTime.Name = "Faculty_DateTime"
        Faculty_DateTime.Size = New Size(695, 49)
        Faculty_DateTime.TabIndex = 8
        ' 
        ' DeptName_lbl
        ' 
        DeptName_lbl.AutoSize = True
        DeptName_lbl.Font = New Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DeptName_lbl.Location = New Point(112, 291)
        DeptName_lbl.Name = "DeptName_lbl"
        DeptName_lbl.Size = New Size(279, 38)
        DeptName_lbl.TabIndex = 7
        DeptName_lbl.Text = "[DEPARTMENT]"
        ' 
        ' FacName_lbl
        ' 
        FacName_lbl.AutoSize = True
        FacName_lbl.Font = New Font("Times New Roman", 64.2000046F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FacName_lbl.Location = New Point(112, 96)
        FacName_lbl.Name = "FacName_lbl"
        FacName_lbl.Size = New Size(981, 122)
        FacName_lbl.TabIndex = 5
        FacName_lbl.Text = "[FACULTY NAME]"
        ' 
        ' Time_Position_lbl
        ' 
        Time_Position_lbl.AutoSize = True
        Time_Position_lbl.Font = New Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Time_Position_lbl.Location = New Point(112, 244)
        Time_Position_lbl.Name = "Time_Position_lbl"
        Time_Position_lbl.Size = New Size(522, 38)
        Time_Position_lbl.TabIndex = 6
        Time_Position_lbl.Text = "[FULL/PART TIME - POSITION]"
        ' 
        ' Greet_Fac_lbl
        ' 
        Greet_Fac_lbl.AutoSize = True
        Greet_Fac_lbl.Font = New Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Greet_Fac_lbl.Location = New Point(112, 43)
        Greet_Fac_lbl.Name = "Greet_Fac_lbl"
        Greet_Fac_lbl.Size = New Size(295, 53)
        Greet_Fac_lbl.TabIndex = 0
        Greet_Fac_lbl.Text = "WELCOME!"
        ' 
        ' Section_Panel
        ' 
        Section_Panel.Controls.Add(Fac_SecInfo_DTV)
        Section_Panel.Controls.Add(Fac_Search_txt)
        Section_Panel.Controls.Add(Undecided_Filter)
        Section_Panel.Controls.Add(Fac_SelSec_Cmb)
        Section_Panel.Controls.Add(Section_lbl)
        Section_Panel.Dock = DockStyle.Fill
        Section_Panel.Location = New Point(0, 225)
        Section_Panel.Name = "Section_Panel"
        Section_Panel.Size = New Size(1902, 830)
        Section_Panel.TabIndex = 0
        ' 
        ' Fac_SecInfo_DTV
        ' 
        Fac_SecInfo_DTV.AllowUserToOrderColumns = True
        Fac_SecInfo_DTV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Fac_SecInfo_DTV.Columns.AddRange(New DataGridViewColumn() {studID_col_lbl, studName_col_lbl, CompAssigned_col_lbl, Supervisor_col_column, Stat_col_lbl, Last_vis_col_lbl, Actions_col_lbl})
        Fac_SecInfo_DTV.Location = New Point(102, 401)
        Fac_SecInfo_DTV.Name = "Fac_SecInfo_DTV"
        Fac_SecInfo_DTV.RowHeadersWidth = 51
        Fac_SecInfo_DTV.Size = New Size(1610, 188)
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
        Fac_Search_txt.Location = New Point(1350, 239)
        Fac_Search_txt.Name = "Fac_Search_txt"
        Fac_Search_txt.Size = New Size(295, 56)
        Fac_Search_txt.TabIndex = 3
        ' 
        ' Undecided_Filter
        ' 
        Undecided_Filter.Font = New Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Undecided_Filter.FormattingEnabled = True
        Undecided_Filter.Items.AddRange(New Object() {"FILTER BY"})
        Undecided_Filter.Location = New Point(656, 243)
        Undecided_Filter.Name = "Undecided_Filter"
        Undecided_Filter.Size = New Size(206, 54)
        Undecided_Filter.TabIndex = 2
        ' 
        ' Fac_SelSec_Cmb
        ' 
        Fac_SelSec_Cmb.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Fac_SelSec_Cmb.FormattingEnabled = True
        Fac_SelSec_Cmb.Items.AddRange(New Object() {"Sections:", "4A", "4B", "4C", "4D"})
        Fac_SelSec_Cmb.Location = New Point(112, 243)
        Fac_SelSec_Cmb.Name = "Fac_SelSec_Cmb"
        Fac_SelSec_Cmb.Size = New Size(386, 53)
        Fac_SelSec_Cmb.TabIndex = 1
        ' 
        ' Section_lbl
        ' 
        Section_lbl.AutoSize = True
        Section_lbl.Font = New Font("Stencil", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Section_lbl.Location = New Point(134, 43)
        Section_lbl.Name = "Section_lbl"
        Section_lbl.Size = New Size(409, 95)
        Section_lbl.TabIndex = 0
        Section_lbl.Text = "SECTIONS"
        ' 
        ' Profile_Panel
        ' 
        Profile_Panel.Controls.Add(Fac_UpdProfile_Btn)
        Profile_Panel.Controls.Add(Fac_ChangePass_Btn)
        Profile_Panel.Controls.Add(Fac_EmailAdd_Mtxt)
        Profile_Panel.Controls.Add(Fac_ContNum_Mtxt)
        Profile_Panel.Controls.Add(Fac_DeptID_mtxt)
        Profile_Panel.Controls.Add(Fac_FacID_mtxt)
        Profile_Panel.Controls.Add(Fac_EmailAdd_lbl)
        Profile_Panel.Controls.Add(Fac_Postion_txt)
        Profile_Panel.Controls.Add(Fac_ContNum__lbl)
        Profile_Panel.Controls.Add(Fac_Position__lbl)
        Profile_Panel.Controls.Add(TextBox7)
        Profile_Panel.Controls.Add(Fac_DeptName__lbl)
        Profile_Panel.Controls.Add(Fac_DeptID__lbl)
        Profile_Panel.Controls.Add(Fac_FacID__lbl)
        Profile_Panel.Controls.Add(Fac_Suffix_txt)
        Profile_Panel.Controls.Add(Fac_LName_txt)
        Profile_Panel.Controls.Add(Fac_MName_txt)
        Profile_Panel.Controls.Add(Fac_FName_txt)
        Profile_Panel.Controls.Add(Fac_Suffix_lbl)
        Profile_Panel.Controls.Add(Fac_LName_lbl)
        Profile_Panel.Controls.Add(Fac_MName_lbl)
        Profile_Panel.Controls.Add(Fac_FName_lbl)
        Profile_Panel.Controls.Add(Profile_lbl)
        Profile_Panel.Dock = DockStyle.Fill
        Profile_Panel.Location = New Point(0, 225)
        Profile_Panel.Name = "Profile_Panel"
        Profile_Panel.Size = New Size(1902, 830)
        Profile_Panel.TabIndex = 8
        ' 
        ' Fac_UpdProfile_Btn
        ' 
        Fac_UpdProfile_Btn.Font = New Font("Stencil", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Fac_UpdProfile_Btn.Location = New Point(922, 699)
        Fac_UpdProfile_Btn.Name = "Fac_UpdProfile_Btn"
        Fac_UpdProfile_Btn.Size = New Size(461, 63)
        Fac_UpdProfile_Btn.TabIndex = 24
        Fac_UpdProfile_Btn.Text = "UPDATE PROFILE"
        Fac_UpdProfile_Btn.UseVisualStyleBackColor = True
        ' 
        ' Fac_ChangePass_Btn
        ' 
        Fac_ChangePass_Btn.Font = New Font("Stencil", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Fac_ChangePass_Btn.Location = New Point(392, 699)
        Fac_ChangePass_Btn.Name = "Fac_ChangePass_Btn"
        Fac_ChangePass_Btn.Size = New Size(461, 63)
        Fac_ChangePass_Btn.TabIndex = 23
        Fac_ChangePass_Btn.Text = "CHANGE PASSWORD"
        Fac_ChangePass_Btn.UseVisualStyleBackColor = True
        ' 
        ' Fac_EmailAdd_Mtxt
        ' 
        Fac_EmailAdd_Mtxt.Font = New Font("Verdana", 13.8F)
        Fac_EmailAdd_Mtxt.Location = New Point(759, 570)
        Fac_EmailAdd_Mtxt.Name = "Fac_EmailAdd_Mtxt"
        Fac_EmailAdd_Mtxt.Size = New Size(508, 35)
        Fac_EmailAdd_Mtxt.TabIndex = 22
        ' 
        ' Fac_ContNum_Mtxt
        ' 
        Fac_ContNum_Mtxt.Font = New Font("Verdana", 13.8F)
        Fac_ContNum_Mtxt.Location = New Point(198, 570)
        Fac_ContNum_Mtxt.Mask = "+63-000-00-0000"
        Fac_ContNum_Mtxt.Name = "Fac_ContNum_Mtxt"
        Fac_ContNum_Mtxt.Size = New Size(237, 35)
        Fac_ContNum_Mtxt.TabIndex = 21
        ' 
        ' Fac_DeptID_mtxt
        ' 
        Fac_DeptID_mtxt.Font = New Font("Verdana", 13.8F)
        Fac_DeptID_mtxt.Location = New Point(456, 401)
        Fac_DeptID_mtxt.Mask = "D-____"
        Fac_DeptID_mtxt.Name = "Fac_DeptID_mtxt"
        Fac_DeptID_mtxt.Size = New Size(190, 35)
        Fac_DeptID_mtxt.TabIndex = 20
        ' 
        ' Fac_FacID_mtxt
        ' 
        Fac_FacID_mtxt.Font = New Font("Verdana", 13.8F)
        Fac_FacID_mtxt.Location = New Point(198, 401)
        Fac_FacID_mtxt.Mask = "F-___"
        Fac_FacID_mtxt.Name = "Fac_FacID_mtxt"
        Fac_FacID_mtxt.Size = New Size(177, 35)
        Fac_FacID_mtxt.TabIndex = 19
        ' 
        ' Fac_EmailAdd_lbl
        ' 
        Fac_EmailAdd_lbl.AutoSize = True
        Fac_EmailAdd_lbl.Font = New Font("Lucida Bright", 18F)
        Fac_EmailAdd_lbl.Location = New Point(759, 502)
        Fac_EmailAdd_lbl.Name = "Fac_EmailAdd_lbl"
        Fac_EmailAdd_lbl.Size = New Size(243, 34)
        Fac_EmailAdd_lbl.TabIndex = 18
        Fac_EmailAdd_lbl.Text = "Email Address :"
        ' 
        ' Fac_Postion_txt
        ' 
        Fac_Postion_txt.Font = New Font("Verdana", 13.8F)
        Fac_Postion_txt.Location = New Point(1275, 401)
        Fac_Postion_txt.Name = "Fac_Postion_txt"
        Fac_Postion_txt.Size = New Size(208, 35)
        Fac_Postion_txt.TabIndex = 17
        ' 
        ' Fac_ContNum__lbl
        ' 
        Fac_ContNum__lbl.AutoSize = True
        Fac_ContNum__lbl.Font = New Font("Lucida Bright", 18F)
        Fac_ContNum__lbl.Location = New Point(198, 502)
        Fac_ContNum__lbl.Name = "Fac_ContNum__lbl"
        Fac_ContNum__lbl.Size = New Size(274, 34)
        Fac_ContNum__lbl.TabIndex = 16
        Fac_ContNum__lbl.Text = "Contact Number :"
        ' 
        ' Fac_Position__lbl
        ' 
        Fac_Position__lbl.AutoSize = True
        Fac_Position__lbl.Font = New Font("Lucida Bright", 18F)
        Fac_Position__lbl.Location = New Point(1275, 341)
        Fac_Position__lbl.Name = "Fac_Position__lbl"
        Fac_Position__lbl.Size = New Size(151, 34)
        Fac_Position__lbl.TabIndex = 15
        Fac_Position__lbl.Text = "Position :"
        ' 
        ' TextBox7
        ' 
        TextBox7.Font = New Font("Verdana", 13.8F)
        TextBox7.Location = New Point(794, 401)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(398, 35)
        TextBox7.TabIndex = 14
        ' 
        ' Fac_DeptName__lbl
        ' 
        Fac_DeptName__lbl.AutoSize = True
        Fac_DeptName__lbl.Font = New Font("Lucida Bright", 18F)
        Fac_DeptName__lbl.Location = New Point(794, 341)
        Fac_DeptName__lbl.Name = "Fac_DeptName__lbl"
        Fac_DeptName__lbl.Size = New Size(208, 34)
        Fac_DeptName__lbl.TabIndex = 11
        Fac_DeptName__lbl.Text = "Department :"
        ' 
        ' Fac_DeptID__lbl
        ' 
        Fac_DeptID__lbl.AutoSize = True
        Fac_DeptID__lbl.Font = New Font("Lucida Bright", 18F)
        Fac_DeptID__lbl.Location = New Point(456, 341)
        Fac_DeptID__lbl.Name = "Fac_DeptID__lbl"
        Fac_DeptID__lbl.Size = New Size(249, 34)
        Fac_DeptID__lbl.TabIndex = 10
        Fac_DeptID__lbl.Text = "Department ID :"
        ' 
        ' Fac_FacID__lbl
        ' 
        Fac_FacID__lbl.AutoSize = True
        Fac_FacID__lbl.Font = New Font("Lucida Bright", 18F)
        Fac_FacID__lbl.Location = New Point(198, 341)
        Fac_FacID__lbl.Name = "Fac_FacID__lbl"
        Fac_FacID__lbl.Size = New Size(177, 34)
        Fac_FacID__lbl.TabIndex = 9
        Fac_FacID__lbl.Text = "Faculty ID :"
        ' 
        ' Fac_Suffix_txt
        ' 
        Fac_Suffix_txt.Font = New Font("Verdana", 13.8F)
        Fac_Suffix_txt.Location = New Point(1350, 244)
        Fac_Suffix_txt.Name = "Fac_Suffix_txt"
        Fac_Suffix_txt.Size = New Size(133, 35)
        Fac_Suffix_txt.TabIndex = 8
        ' 
        ' Fac_LName_txt
        ' 
        Fac_LName_txt.Font = New Font("Verdana", 13.8F)
        Fac_LName_txt.Location = New Point(998, 244)
        Fac_LName_txt.Name = "Fac_LName_txt"
        Fac_LName_txt.Size = New Size(233, 35)
        Fac_LName_txt.TabIndex = 7
        ' 
        ' Fac_MName_txt
        ' 
        Fac_MName_txt.Font = New Font("Verdana", 13.8F)
        Fac_MName_txt.Location = New Point(615, 244)
        Fac_MName_txt.Name = "Fac_MName_txt"
        Fac_MName_txt.Size = New Size(247, 35)
        Fac_MName_txt.TabIndex = 6
        ' 
        ' Fac_FName_txt
        ' 
        Fac_FName_txt.Font = New Font("Verdana", 13.8F)
        Fac_FName_txt.Location = New Point(198, 244)
        Fac_FName_txt.Name = "Fac_FName_txt"
        Fac_FName_txt.Size = New Size(300, 35)
        Fac_FName_txt.TabIndex = 5
        ' 
        ' Fac_Suffix_lbl
        ' 
        Fac_Suffix_lbl.AutoSize = True
        Fac_Suffix_lbl.Font = New Font("Lucida Bright", 18F)
        Fac_Suffix_lbl.Location = New Point(1350, 180)
        Fac_Suffix_lbl.Name = "Fac_Suffix_lbl"
        Fac_Suffix_lbl.Size = New Size(118, 34)
        Fac_Suffix_lbl.TabIndex = 4
        Fac_Suffix_lbl.Text = "Suffix :"
        ' 
        ' Fac_LName_lbl
        ' 
        Fac_LName_lbl.AutoSize = True
        Fac_LName_lbl.Font = New Font("Lucida Bright", 18F)
        Fac_LName_lbl.Location = New Point(998, 180)
        Fac_LName_lbl.Name = "Fac_LName_lbl"
        Fac_LName_lbl.Size = New Size(185, 34)
        Fac_LName_lbl.TabIndex = 3
        Fac_LName_lbl.Text = "Last Name :"
        ' 
        ' Fac_MName_lbl
        ' 
        Fac_MName_lbl.AutoSize = True
        Fac_MName_lbl.Font = New Font("Lucida Bright", 18F)
        Fac_MName_lbl.Location = New Point(615, 180)
        Fac_MName_lbl.Name = "Fac_MName_lbl"
        Fac_MName_lbl.Size = New Size(222, 34)
        Fac_MName_lbl.TabIndex = 2
        Fac_MName_lbl.Text = "Middle Name :"
        ' 
        ' Fac_FName_lbl
        ' 
        Fac_FName_lbl.AutoSize = True
        Fac_FName_lbl.Font = New Font("Lucida Bright", 18F)
        Fac_FName_lbl.Location = New Point(198, 180)
        Fac_FName_lbl.Name = "Fac_FName_lbl"
        Fac_FName_lbl.Size = New Size(190, 34)
        Fac_FName_lbl.TabIndex = 1
        Fac_FName_lbl.Text = "First Name :"
        ' 
        ' Profile_lbl
        ' 
        Profile_lbl.AutoSize = True
        Profile_lbl.Font = New Font("Stencil", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Profile_lbl.Location = New Point(188, 64)
        Profile_lbl.Name = "Profile_lbl"
        Profile_lbl.Size = New Size(365, 95)
        Profile_lbl.TabIndex = 0
        Profile_lbl.Text = "PROFILE"
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
        Home_Panel.ResumeLayout(False)
        Home_Panel.PerformLayout()
        Section_Panel.ResumeLayout(False)
        Section_Panel.PerformLayout()
        CType(Fac_SecInfo_DTV, ComponentModel.ISupportInitialize).EndInit()
        Profile_Panel.ResumeLayout(False)
        Profile_Panel.PerformLayout()
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
    Friend WithEvents Profile_Panel As Panel
    Friend WithEvents Section_Panel As Panel
    Friend WithEvents Faculty_DateTime As Label
    Friend WithEvents Profile_lbl As Label
    Friend WithEvents Fac_Suffix_lbl As Label
    Friend WithEvents Fac_LName_lbl As Label
    Friend WithEvents Fac_MName_lbl As Label
    Friend WithEvents Fac_FName_lbl As Label
    Friend WithEvents Fac_Position__lbl As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Fac_DeptName__lbl As Label
    Friend WithEvents Fac_DeptID__lbl As Label
    Friend WithEvents Fac_FacID__lbl As Label
    Friend WithEvents Fac_Suffix_txt As TextBox
    Friend WithEvents Fac_LName_txt As TextBox
    Friend WithEvents Fac_MName_txt As TextBox
    Friend WithEvents Fac_FName_txt As TextBox
    Friend WithEvents Fac_ContNum__lbl As Label
    Friend WithEvents Fac_FacID_mtxt As MaskedTextBox
    Friend WithEvents Fac_EmailAdd_lbl As Label
    Friend WithEvents Fac_Postion_txt As TextBox
    Friend WithEvents Fac_ContNum_Mtxt As MaskedTextBox
    Friend WithEvents Fac_DeptID_mtxt As MaskedTextBox
    Friend WithEvents Fac_UpdProfile_Btn As Button
    Friend WithEvents Fac_ChangePass_Btn As Button
    Friend WithEvents Fac_EmailAdd_Mtxt As MaskedTextBox
    Friend WithEvents Section_lbl As Label
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
End Class
