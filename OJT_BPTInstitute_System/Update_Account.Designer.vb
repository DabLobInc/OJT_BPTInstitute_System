<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Update_Account
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
        Update_Panel = New Panel()
        Faculty_Update = New Panel()
        Fac_Update_Profile_pnl = New Panel()
        FacUpdate_DeptID_cmb = New ComboBox()
        FacUpdate_Cancel_btn = New Button()
        FacUpdate_Save_btn = New Button()
        FacUpdate_Email_txt = New TextBox()
        FacUpdate_Email_lbl = New Label()
        FacUpdate_ContNo_Mtxt = New MaskedTextBox()
        FacUpdate_EmpStat_txt = New TextBox()
        FacUpdate_ContNo_lbl = New Label()
        FacUpdate_FacID_Mtxt = New MaskedTextBox()
        FacUpdate_Position_txt = New TextBox()
        FacUpdate_Position_lbl = New Label()
        FacUpdate_DeptName_lbl = New Label()
        FacUpdate_EmpStat_lbl = New Label()
        FacUpdate_DeptID_lbl = New Label()
        FacUpdate_FacID_lbl = New Label()
        FacUpdate_DeptName_txt = New TextBox()
        FacUpdate_SName_txt = New TextBox()
        FacUpdate_LName_txt = New TextBox()
        FacUpdate_MName_txt = New TextBox()
        FacUpdate_FName_txt = New TextBox()
        FacUpdate_SName_lbl = New Label()
        FacUpdate_LName_lbl = New Label()
        FacUpdate_MName_lbl = New Label()
        FacUpdate_FName_lbl = New Label()
        FacUpdate_Header = New Panel()
        FacUpdateTitle_lbl = New Label()
        Fac_ChangePass_Container_pnl = New Panel()
        Fac_ChangePassword_pnl = New Panel()
        Fac_ChangePass_Cancel_btn = New Button()
        Fac_ChangePass_Save_btn = New Button()
        Fac_ChangePass_ShowPass_cb = New CheckBox()
        Fac_ChangePass_ConPass_lbl = New Label()
        Fac_ChangePass_NewPass_lbl = New Label()
        Fac_ChangePass_OldPass_lbl = New Label()
        Fac_ChangePass_ConPass_txt = New TextBox()
        Fac_ChangePass_NewPass_txt = New TextBox()
        Fac_ChangePass_OldPass_txt = New TextBox()
        Fac_ChangePass_Header = New Panel()
        Fac_ChangePass_lbl = New Label()
        Student_Update = New Panel()
        Stud_Update_Profile_pnl = New Panel()
        UpProf_SProgID_cmb = New ComboBox()
        UpProf_SDeptID_cmb = New ComboBox()
        UpProf_SCancel_btn = New Button()
        UpProf_SSave_btn = New Button()
        UpProf_SEmailAdd_txt = New TextBox()
        UpProf_SEmail_lbl = New Label()
        UpProf_SContNum_Mtxt = New MaskedTextBox()
        UpProf_SContNum_lbl = New Label()
        UpProf_SStud_ID_Mtxt = New MaskedTextBox()
        UpProf_SSection_txt = New TextBox()
        UpProf_SSection_lbl = New Label()
        UpProf_SProgName_lbl = New Label()
        UpProf_SProgID_lbl = New Label()
        UpProf_SDeptID_lbl = New Label()
        UpProf_SStudID_lbl = New Label()
        UpProf_SProgName_txt = New TextBox()
        UpProf_SSuffix_txt = New TextBox()
        UpProf_SLName_txt = New TextBox()
        UpProf_SMName_txt = New TextBox()
        UpProf_SFName_txt = New TextBox()
        UpProf_SSuffix_lbl = New Label()
        UpProf_SLName_lbl = New Label()
        UpProf_SMName_lbl = New Label()
        UpProf__SFName_lbl = New Label()
        UpProfile_Header_Pnl = New Panel()
        UpdateProfile_lbl = New Label()
        Stud_ChangePass_Container_pnl = New Panel()
        Change_Password_Pnl = New Panel()
        ChangePass_Cancel_btn = New Button()
        ChangePass_Save_btn = New Button()
        ChangePass_Showpass_cb = New CheckBox()
        ChangePass_ConPass_lbl = New Label()
        ChangePass_NewPass_lbl = New Label()
        ChangePass_OldPass_lbl = New Label()
        ChangePass_Conpass_txt = New TextBox()
        ChangePass_NewPass_txt = New TextBox()
        ChangePass_OldPass_txt = New TextBox()
        ChangePass_Header = New Panel()
        ChangePass_lbl = New Label()
        Update_Panel.SuspendLayout()
        Faculty_Update.SuspendLayout()
        Fac_Update_Profile_pnl.SuspendLayout()
        FacUpdate_Header.SuspendLayout()
        Fac_ChangePass_Container_pnl.SuspendLayout()
        Fac_ChangePassword_pnl.SuspendLayout()
        Fac_ChangePass_Header.SuspendLayout()
        Student_Update.SuspendLayout()
        Stud_Update_Profile_pnl.SuspendLayout()
        UpProfile_Header_Pnl.SuspendLayout()
        Stud_ChangePass_Container_pnl.SuspendLayout()
        Change_Password_Pnl.SuspendLayout()
        ChangePass_Header.SuspendLayout()
        SuspendLayout()
        ' 
        ' Update_Panel
        ' 
        Update_Panel.Controls.Add(Student_Update)
        Update_Panel.Controls.Add(Faculty_Update)
        Update_Panel.Dock = DockStyle.Fill
        Update_Panel.Location = New Point(0, 0)
        Update_Panel.Name = "Update_Panel"
        Update_Panel.Size = New Size(864, 495)
        Update_Panel.TabIndex = 0
        ' 
        ' Faculty_Update
        ' 
        Faculty_Update.Controls.Add(Fac_Update_Profile_pnl)
        Faculty_Update.Controls.Add(Fac_ChangePass_Container_pnl)
        Faculty_Update.Dock = DockStyle.Fill
        Faculty_Update.Location = New Point(0, 0)
        Faculty_Update.Name = "Faculty_Update"
        Faculty_Update.Size = New Size(864, 495)
        Faculty_Update.TabIndex = 1
        ' 
        ' Fac_Update_Profile_pnl
        ' 
        Fac_Update_Profile_pnl.Controls.Add(FacUpdate_DeptID_cmb)
        Fac_Update_Profile_pnl.Controls.Add(FacUpdate_Cancel_btn)
        Fac_Update_Profile_pnl.Controls.Add(FacUpdate_Save_btn)
        Fac_Update_Profile_pnl.Controls.Add(FacUpdate_Email_txt)
        Fac_Update_Profile_pnl.Controls.Add(FacUpdate_Email_lbl)
        Fac_Update_Profile_pnl.Controls.Add(FacUpdate_ContNo_Mtxt)
        Fac_Update_Profile_pnl.Controls.Add(FacUpdate_EmpStat_txt)
        Fac_Update_Profile_pnl.Controls.Add(FacUpdate_ContNo_lbl)
        Fac_Update_Profile_pnl.Controls.Add(FacUpdate_FacID_Mtxt)
        Fac_Update_Profile_pnl.Controls.Add(FacUpdate_Position_txt)
        Fac_Update_Profile_pnl.Controls.Add(FacUpdate_Position_lbl)
        Fac_Update_Profile_pnl.Controls.Add(FacUpdate_DeptName_lbl)
        Fac_Update_Profile_pnl.Controls.Add(FacUpdate_EmpStat_lbl)
        Fac_Update_Profile_pnl.Controls.Add(FacUpdate_DeptID_lbl)
        Fac_Update_Profile_pnl.Controls.Add(FacUpdate_FacID_lbl)
        Fac_Update_Profile_pnl.Controls.Add(FacUpdate_DeptName_txt)
        Fac_Update_Profile_pnl.Controls.Add(FacUpdate_SName_txt)
        Fac_Update_Profile_pnl.Controls.Add(FacUpdate_LName_txt)
        Fac_Update_Profile_pnl.Controls.Add(FacUpdate_MName_txt)
        Fac_Update_Profile_pnl.Controls.Add(FacUpdate_FName_txt)
        Fac_Update_Profile_pnl.Controls.Add(FacUpdate_SName_lbl)
        Fac_Update_Profile_pnl.Controls.Add(FacUpdate_LName_lbl)
        Fac_Update_Profile_pnl.Controls.Add(FacUpdate_MName_lbl)
        Fac_Update_Profile_pnl.Controls.Add(FacUpdate_FName_lbl)
        Fac_Update_Profile_pnl.Controls.Add(FacUpdate_Header)
        Fac_Update_Profile_pnl.Dock = DockStyle.Fill
        Fac_Update_Profile_pnl.Location = New Point(0, 0)
        Fac_Update_Profile_pnl.Name = "Fac_Update_Profile_pnl"
        Fac_Update_Profile_pnl.Size = New Size(864, 495)
        Fac_Update_Profile_pnl.TabIndex = 2
        ' 
        ' FacUpdate_DeptID_cmb
        ' 
        FacUpdate_DeptID_cmb.Enabled = False
        FacUpdate_DeptID_cmb.FormattingEnabled = True
        FacUpdate_DeptID_cmb.Location = New Point(197, 276)
        FacUpdate_DeptID_cmb.Name = "FacUpdate_DeptID_cmb"
        FacUpdate_DeptID_cmb.Size = New Size(103, 28)
        FacUpdate_DeptID_cmb.TabIndex = 28
        ' 
        ' FacUpdate_Cancel_btn
        ' 
        FacUpdate_Cancel_btn.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        FacUpdate_Cancel_btn.Location = New Point(717, 421)
        FacUpdate_Cancel_btn.Name = "FacUpdate_Cancel_btn"
        FacUpdate_Cancel_btn.Size = New Size(102, 49)
        FacUpdate_Cancel_btn.TabIndex = 27
        FacUpdate_Cancel_btn.Text = "CANCEL"
        FacUpdate_Cancel_btn.UseVisualStyleBackColor = True
        ' 
        ' FacUpdate_Save_btn
        ' 
        FacUpdate_Save_btn.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        FacUpdate_Save_btn.Location = New Point(602, 421)
        FacUpdate_Save_btn.Name = "FacUpdate_Save_btn"
        FacUpdate_Save_btn.Size = New Size(94, 49)
        FacUpdate_Save_btn.TabIndex = 26
        FacUpdate_Save_btn.Text = "SAVE"
        FacUpdate_Save_btn.UseVisualStyleBackColor = True
        ' 
        ' FacUpdate_Email_txt
        ' 
        FacUpdate_Email_txt.Font = New Font("Segoe UI", 10F)
        FacUpdate_Email_txt.Location = New Point(557, 377)
        FacUpdate_Email_txt.Name = "FacUpdate_Email_txt"
        FacUpdate_Email_txt.Size = New Size(233, 30)
        FacUpdate_Email_txt.TabIndex = 25
        ' 
        ' FacUpdate_Email_lbl
        ' 
        FacUpdate_Email_lbl.AutoSize = True
        FacUpdate_Email_lbl.Font = New Font("Segoe UI", 12F)
        FacUpdate_Email_lbl.Location = New Point(557, 348)
        FacUpdate_Email_lbl.Name = "FacUpdate_Email_lbl"
        FacUpdate_Email_lbl.Size = New Size(138, 28)
        FacUpdate_Email_lbl.TabIndex = 24
        FacUpdate_Email_lbl.Text = "Email Address:"
        ' 
        ' FacUpdate_ContNo_Mtxt
        ' 
        FacUpdate_ContNo_Mtxt.Font = New Font("Segoe UI", 10F)
        FacUpdate_ContNo_Mtxt.Location = New Point(296, 379)
        FacUpdate_ContNo_Mtxt.Mask = "+63000-000-0000"
        FacUpdate_ContNo_Mtxt.Name = "FacUpdate_ContNo_Mtxt"
        FacUpdate_ContNo_Mtxt.Size = New Size(161, 30)
        FacUpdate_ContNo_Mtxt.TabIndex = 23
        ' 
        ' FacUpdate_EmpStat_txt
        ' 
        FacUpdate_EmpStat_txt.Enabled = False
        FacUpdate_EmpStat_txt.Font = New Font("Segoe UI", 10F)
        FacUpdate_EmpStat_txt.Location = New Point(631, 276)
        FacUpdate_EmpStat_txt.Name = "FacUpdate_EmpStat_txt"
        FacUpdate_EmpStat_txt.Size = New Size(188, 30)
        FacUpdate_EmpStat_txt.TabIndex = 29
        ' 
        ' FacUpdate_ContNo_lbl
        ' 
        FacUpdate_ContNo_lbl.AutoSize = True
        FacUpdate_ContNo_lbl.Font = New Font("Segoe UI", 12F)
        FacUpdate_ContNo_lbl.Location = New Point(296, 348)
        FacUpdate_ContNo_lbl.Name = "FacUpdate_ContNo_lbl"
        FacUpdate_ContNo_lbl.Size = New Size(161, 28)
        FacUpdate_ContNo_lbl.TabIndex = 22
        FacUpdate_ContNo_lbl.Text = "Contact Number:"
        ' 
        ' FacUpdate_FacID_Mtxt
        ' 
        FacUpdate_FacID_Mtxt.Enabled = False
        FacUpdate_FacID_Mtxt.Location = New Point(37, 276)
        FacUpdate_FacID_Mtxt.Mask = "00-0000"
        FacUpdate_FacID_Mtxt.Name = "FacUpdate_FacID_Mtxt"
        FacUpdate_FacID_Mtxt.Size = New Size(123, 27)
        FacUpdate_FacID_Mtxt.TabIndex = 19
        ' 
        ' FacUpdate_Position_txt
        ' 
        FacUpdate_Position_txt.Enabled = False
        FacUpdate_Position_txt.Font = New Font("Segoe UI", 10F)
        FacUpdate_Position_txt.Location = New Point(35, 380)
        FacUpdate_Position_txt.Name = "FacUpdate_Position_txt"
        FacUpdate_Position_txt.Size = New Size(181, 30)
        FacUpdate_Position_txt.TabIndex = 18
        ' 
        ' FacUpdate_Position_lbl
        ' 
        FacUpdate_Position_lbl.AutoSize = True
        FacUpdate_Position_lbl.Font = New Font("Segoe UI", 12F)
        FacUpdate_Position_lbl.Location = New Point(35, 348)
        FacUpdate_Position_lbl.Name = "FacUpdate_Position_lbl"
        FacUpdate_Position_lbl.Size = New Size(86, 28)
        FacUpdate_Position_lbl.TabIndex = 17
        FacUpdate_Position_lbl.Text = "Position:"
        ' 
        ' FacUpdate_DeptName_lbl
        ' 
        FacUpdate_DeptName_lbl.AutoSize = True
        FacUpdate_DeptName_lbl.Font = New Font("Segoe UI", 12F)
        FacUpdate_DeptName_lbl.Location = New Point(346, 245)
        FacUpdate_DeptName_lbl.Name = "FacUpdate_DeptName_lbl"
        FacUpdate_DeptName_lbl.Size = New Size(178, 28)
        FacUpdate_DeptName_lbl.TabIndex = 16
        FacUpdate_DeptName_lbl.Text = "Department Name:"
        ' 
        ' FacUpdate_EmpStat_lbl
        ' 
        FacUpdate_EmpStat_lbl.AutoSize = True
        FacUpdate_EmpStat_lbl.Font = New Font("Segoe UI", 12F)
        FacUpdate_EmpStat_lbl.Location = New Point(631, 245)
        FacUpdate_EmpStat_lbl.Name = "FacUpdate_EmpStat_lbl"
        FacUpdate_EmpStat_lbl.Size = New Size(156, 28)
        FacUpdate_EmpStat_lbl.TabIndex = 15
        FacUpdate_EmpStat_lbl.Text = "Employee Status"
        ' 
        ' FacUpdate_DeptID_lbl
        ' 
        FacUpdate_DeptID_lbl.AutoSize = True
        FacUpdate_DeptID_lbl.Font = New Font("Segoe UI", 12F)
        FacUpdate_DeptID_lbl.Location = New Point(197, 245)
        FacUpdate_DeptID_lbl.Name = "FacUpdate_DeptID_lbl"
        FacUpdate_DeptID_lbl.Size = New Size(87, 28)
        FacUpdate_DeptID_lbl.TabIndex = 14
        FacUpdate_DeptID_lbl.Text = "Dept. ID:"
        ' 
        ' FacUpdate_FacID_lbl
        ' 
        FacUpdate_FacID_lbl.AutoSize = True
        FacUpdate_FacID_lbl.Font = New Font("Segoe UI", 12F)
        FacUpdate_FacID_lbl.Location = New Point(37, 245)
        FacUpdate_FacID_lbl.Name = "FacUpdate_FacID_lbl"
        FacUpdate_FacID_lbl.Size = New Size(101, 28)
        FacUpdate_FacID_lbl.TabIndex = 13
        FacUpdate_FacID_lbl.Text = "Faculty ID:"
        ' 
        ' FacUpdate_DeptName_txt
        ' 
        FacUpdate_DeptName_txt.Enabled = False
        FacUpdate_DeptName_txt.Font = New Font("Segoe UI", 10F)
        FacUpdate_DeptName_txt.Location = New Point(346, 276)
        FacUpdate_DeptName_txt.Name = "FacUpdate_DeptName_txt"
        FacUpdate_DeptName_txt.Size = New Size(237, 30)
        FacUpdate_DeptName_txt.TabIndex = 12
        ' 
        ' FacUpdate_SName_txt
        ' 
        FacUpdate_SName_txt.Font = New Font("Segoe UI", 10F)
        FacUpdate_SName_txt.Location = New Point(657, 168)
        FacUpdate_SName_txt.Name = "FacUpdate_SName_txt"
        FacUpdate_SName_txt.Size = New Size(162, 30)
        FacUpdate_SName_txt.TabIndex = 11
        ' 
        ' FacUpdate_LName_txt
        ' 
        FacUpdate_LName_txt.Font = New Font("Segoe UI", 10F)
        FacUpdate_LName_txt.Location = New Point(448, 168)
        FacUpdate_LName_txt.Name = "FacUpdate_LName_txt"
        FacUpdate_LName_txt.Size = New Size(162, 30)
        FacUpdate_LName_txt.TabIndex = 10
        ' 
        ' FacUpdate_MName_txt
        ' 
        FacUpdate_MName_txt.Font = New Font("Segoe UI", 10F)
        FacUpdate_MName_txt.Location = New Point(241, 168)
        FacUpdate_MName_txt.Name = "FacUpdate_MName_txt"
        FacUpdate_MName_txt.Size = New Size(162, 30)
        FacUpdate_MName_txt.TabIndex = 9
        ' 
        ' FacUpdate_FName_txt
        ' 
        FacUpdate_FName_txt.Font = New Font("Segoe UI", 10F)
        FacUpdate_FName_txt.Location = New Point(35, 168)
        FacUpdate_FName_txt.Name = "FacUpdate_FName_txt"
        FacUpdate_FName_txt.Size = New Size(162, 30)
        FacUpdate_FName_txt.TabIndex = 8
        ' 
        ' FacUpdate_SName_lbl
        ' 
        FacUpdate_SName_lbl.AutoSize = True
        FacUpdate_SName_lbl.Font = New Font("Segoe UI", 12F)
        FacUpdate_SName_lbl.Location = New Point(657, 137)
        FacUpdate_SName_lbl.Name = "FacUpdate_SName_lbl"
        FacUpdate_SName_lbl.Size = New Size(64, 28)
        FacUpdate_SName_lbl.TabIndex = 7
        FacUpdate_SName_lbl.Text = "Suffix:"
        ' 
        ' FacUpdate_LName_lbl
        ' 
        FacUpdate_LName_lbl.AutoSize = True
        FacUpdate_LName_lbl.Font = New Font("Segoe UI", 12F)
        FacUpdate_LName_lbl.Location = New Point(448, 137)
        FacUpdate_LName_lbl.Name = "FacUpdate_LName_lbl"
        FacUpdate_LName_lbl.Size = New Size(107, 28)
        FacUpdate_LName_lbl.TabIndex = 6
        FacUpdate_LName_lbl.Text = "Last Name:"
        ' 
        ' FacUpdate_MName_lbl
        ' 
        FacUpdate_MName_lbl.AutoSize = True
        FacUpdate_MName_lbl.Font = New Font("Segoe UI", 12F)
        FacUpdate_MName_lbl.Location = New Point(241, 137)
        FacUpdate_MName_lbl.Name = "FacUpdate_MName_lbl"
        FacUpdate_MName_lbl.Size = New Size(135, 28)
        FacUpdate_MName_lbl.TabIndex = 5
        FacUpdate_MName_lbl.Text = "Middle Name:"
        ' 
        ' FacUpdate_FName_lbl
        ' 
        FacUpdate_FName_lbl.AutoSize = True
        FacUpdate_FName_lbl.Font = New Font("Segoe UI", 12F)
        FacUpdate_FName_lbl.Location = New Point(35, 137)
        FacUpdate_FName_lbl.Name = "FacUpdate_FName_lbl"
        FacUpdate_FName_lbl.Size = New Size(110, 28)
        FacUpdate_FName_lbl.TabIndex = 4
        FacUpdate_FName_lbl.Text = "First Name:"
        ' 
        ' FacUpdate_Header
        ' 
        FacUpdate_Header.BackColor = Color.MidnightBlue
        FacUpdate_Header.Controls.Add(FacUpdateTitle_lbl)
        FacUpdate_Header.Dock = DockStyle.Top
        FacUpdate_Header.Location = New Point(0, 0)
        FacUpdate_Header.Name = "FacUpdate_Header"
        FacUpdate_Header.Size = New Size(864, 100)
        FacUpdate_Header.TabIndex = 3
        ' 
        ' FacUpdateTitle_lbl
        ' 
        FacUpdateTitle_lbl.AutoSize = True
        FacUpdateTitle_lbl.Font = New Font("Stencil", 28.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FacUpdateTitle_lbl.ForeColor = Color.Goldenrod
        FacUpdateTitle_lbl.Location = New Point(246, 20)
        FacUpdateTitle_lbl.Name = "FacUpdateTitle_lbl"
        FacUpdateTitle_lbl.Size = New Size(405, 56)
        FacUpdateTitle_lbl.TabIndex = 9
        FacUpdateTitle_lbl.Text = "UPDATE PROFILE"
        ' 
        ' Fac_ChangePass_Container_pnl
        ' 
        Fac_ChangePass_Container_pnl.Controls.Add(Fac_ChangePassword_pnl)
        Fac_ChangePass_Container_pnl.Controls.Add(Fac_ChangePass_Header)
        Fac_ChangePass_Container_pnl.Dock = DockStyle.Fill
        Fac_ChangePass_Container_pnl.Location = New Point(0, 0)
        Fac_ChangePass_Container_pnl.Name = "Fac_ChangePass_Container_pnl"
        Fac_ChangePass_Container_pnl.Size = New Size(864, 495)
        Fac_ChangePass_Container_pnl.TabIndex = 4
        ' 
        ' Fac_ChangePassword_pnl
        ' 
        Fac_ChangePassword_pnl.Controls.Add(Fac_ChangePass_Cancel_btn)
        Fac_ChangePassword_pnl.Controls.Add(Fac_ChangePass_Save_btn)
        Fac_ChangePassword_pnl.Controls.Add(Fac_ChangePass_ShowPass_cb)
        Fac_ChangePassword_pnl.Controls.Add(Fac_ChangePass_ConPass_lbl)
        Fac_ChangePassword_pnl.Controls.Add(Fac_ChangePass_NewPass_lbl)
        Fac_ChangePassword_pnl.Controls.Add(Fac_ChangePass_OldPass_lbl)
        Fac_ChangePassword_pnl.Controls.Add(Fac_ChangePass_ConPass_txt)
        Fac_ChangePassword_pnl.Controls.Add(Fac_ChangePass_NewPass_txt)
        Fac_ChangePassword_pnl.Controls.Add(Fac_ChangePass_OldPass_txt)
        Fac_ChangePassword_pnl.Dock = DockStyle.Fill
        Fac_ChangePassword_pnl.Location = New Point(0, 100)
        Fac_ChangePassword_pnl.Name = "Fac_ChangePassword_pnl"
        Fac_ChangePassword_pnl.Size = New Size(864, 395)
        Fac_ChangePassword_pnl.TabIndex = 3
        ' 
        ' Fac_ChangePass_Cancel_btn
        ' 
        Fac_ChangePass_Cancel_btn.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Fac_ChangePass_Cancel_btn.Location = New Point(739, 319)
        Fac_ChangePass_Cancel_btn.Name = "Fac_ChangePass_Cancel_btn"
        Fac_ChangePass_Cancel_btn.Size = New Size(96, 45)
        Fac_ChangePass_Cancel_btn.TabIndex = 8
        Fac_ChangePass_Cancel_btn.Text = "CANCEL"
        Fac_ChangePass_Cancel_btn.UseVisualStyleBackColor = True
        ' 
        ' Fac_ChangePass_Save_btn
        ' 
        Fac_ChangePass_Save_btn.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Fac_ChangePass_Save_btn.Location = New Point(637, 319)
        Fac_ChangePass_Save_btn.Name = "Fac_ChangePass_Save_btn"
        Fac_ChangePass_Save_btn.Size = New Size(96, 45)
        Fac_ChangePass_Save_btn.TabIndex = 7
        Fac_ChangePass_Save_btn.Text = "SAVE"
        Fac_ChangePass_Save_btn.UseVisualStyleBackColor = True
        ' 
        ' Fac_ChangePass_ShowPass_cb
        ' 
        Fac_ChangePass_ShowPass_cb.AutoSize = True
        Fac_ChangePass_ShowPass_cb.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Fac_ChangePass_ShowPass_cb.Location = New Point(254, 319)
        Fac_ChangePass_ShowPass_cb.Name = "Fac_ChangePass_ShowPass_cb"
        Fac_ChangePass_ShowPass_cb.Size = New Size(130, 24)
        Fac_ChangePass_ShowPass_cb.TabIndex = 6
        Fac_ChangePass_ShowPass_cb.Text = "Show Password"
        Fac_ChangePass_ShowPass_cb.UseVisualStyleBackColor = True
        ' 
        ' Fac_ChangePass_ConPass_lbl
        ' 
        Fac_ChangePass_ConPass_lbl.AutoSize = True
        Fac_ChangePass_ConPass_lbl.Font = New Font("Segoe UI", 14F)
        Fac_ChangePass_ConPass_lbl.Location = New Point(254, 235)
        Fac_ChangePass_ConPass_lbl.Name = "Fac_ChangePass_ConPass_lbl"
        Fac_ChangePass_ConPass_lbl.Size = New Size(209, 32)
        Fac_ChangePass_ConPass_lbl.TabIndex = 5
        Fac_ChangePass_ConPass_lbl.Text = "Confirm Password:"
        ' 
        ' Fac_ChangePass_NewPass_lbl
        ' 
        Fac_ChangePass_NewPass_lbl.AutoSize = True
        Fac_ChangePass_NewPass_lbl.Font = New Font("Segoe UI", 14F)
        Fac_ChangePass_NewPass_lbl.Location = New Point(254, 130)
        Fac_ChangePass_NewPass_lbl.Name = "Fac_ChangePass_NewPass_lbl"
        Fac_ChangePass_NewPass_lbl.Size = New Size(171, 32)
        Fac_ChangePass_NewPass_lbl.TabIndex = 4
        Fac_ChangePass_NewPass_lbl.Text = "New Password:"
        ' 
        ' Fac_ChangePass_OldPass_lbl
        ' 
        Fac_ChangePass_OldPass_lbl.AutoSize = True
        Fac_ChangePass_OldPass_lbl.Font = New Font("Segoe UI", 14F)
        Fac_ChangePass_OldPass_lbl.Location = New Point(254, 22)
        Fac_ChangePass_OldPass_lbl.Name = "Fac_ChangePass_OldPass_lbl"
        Fac_ChangePass_OldPass_lbl.Size = New Size(161, 32)
        Fac_ChangePass_OldPass_lbl.TabIndex = 3
        Fac_ChangePass_OldPass_lbl.Text = "Old Password:"
        ' 
        ' Fac_ChangePass_ConPass_txt
        ' 
        Fac_ChangePass_ConPass_txt.Font = New Font("Segoe UI", 16F)
        Fac_ChangePass_ConPass_txt.Location = New Point(254, 270)
        Fac_ChangePass_ConPass_txt.Name = "Fac_ChangePass_ConPass_txt"
        Fac_ChangePass_ConPass_txt.PasswordChar = "*"c
        Fac_ChangePass_ConPass_txt.Size = New Size(360, 43)
        Fac_ChangePass_ConPass_txt.TabIndex = 2
        ' 
        ' Fac_ChangePass_NewPass_txt
        ' 
        Fac_ChangePass_NewPass_txt.Font = New Font("Segoe UI", 16F)
        Fac_ChangePass_NewPass_txt.Location = New Point(254, 165)
        Fac_ChangePass_NewPass_txt.Name = "Fac_ChangePass_NewPass_txt"
        Fac_ChangePass_NewPass_txt.PasswordChar = "*"c
        Fac_ChangePass_NewPass_txt.Size = New Size(360, 43)
        Fac_ChangePass_NewPass_txt.TabIndex = 1
        ' 
        ' Fac_ChangePass_OldPass_txt
        ' 
        Fac_ChangePass_OldPass_txt.Font = New Font("Segoe UI", 16F)
        Fac_ChangePass_OldPass_txt.Location = New Point(254, 57)
        Fac_ChangePass_OldPass_txt.Name = "Fac_ChangePass_OldPass_txt"
        Fac_ChangePass_OldPass_txt.PasswordChar = "*"c
        Fac_ChangePass_OldPass_txt.Size = New Size(360, 43)
        Fac_ChangePass_OldPass_txt.TabIndex = 0
        ' 
        ' Fac_ChangePass_Header
        ' 
        Fac_ChangePass_Header.BackColor = Color.MidnightBlue
        Fac_ChangePass_Header.Controls.Add(Fac_ChangePass_lbl)
        Fac_ChangePass_Header.Dock = DockStyle.Top
        Fac_ChangePass_Header.Location = New Point(0, 0)
        Fac_ChangePass_Header.Name = "Fac_ChangePass_Header"
        Fac_ChangePass_Header.Size = New Size(864, 100)
        Fac_ChangePass_Header.TabIndex = 2
        ' 
        ' Fac_ChangePass_lbl
        ' 
        Fac_ChangePass_lbl.AutoSize = True
        Fac_ChangePass_lbl.Font = New Font("Stencil", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Fac_ChangePass_lbl.ForeColor = Color.Goldenrod
        Fac_ChangePass_lbl.Location = New Point(241, 27)
        Fac_ChangePass_lbl.Name = "Fac_ChangePass_lbl"
        Fac_ChangePass_lbl.Size = New Size(389, 47)
        Fac_ChangePass_lbl.TabIndex = 9
        Fac_ChangePass_lbl.Text = "CHANGE PASSWORD"
        ' 
        ' Student_Update
        ' 
        Student_Update.Controls.Add(Stud_Update_Profile_pnl)
        Student_Update.Controls.Add(Stud_ChangePass_Container_pnl)
        Student_Update.Dock = DockStyle.Fill
        Student_Update.Location = New Point(0, 0)
        Student_Update.Name = "Student_Update"
        Student_Update.Size = New Size(864, 495)
        Student_Update.TabIndex = 1
        ' 
        ' Stud_Update_Profile_pnl
        ' 
        Stud_Update_Profile_pnl.Controls.Add(UpProf_SProgID_cmb)
        Stud_Update_Profile_pnl.Controls.Add(UpProf_SDeptID_cmb)
        Stud_Update_Profile_pnl.Controls.Add(UpProf_SCancel_btn)
        Stud_Update_Profile_pnl.Controls.Add(UpProf_SSave_btn)
        Stud_Update_Profile_pnl.Controls.Add(UpProf_SEmailAdd_txt)
        Stud_Update_Profile_pnl.Controls.Add(UpProf_SEmail_lbl)
        Stud_Update_Profile_pnl.Controls.Add(UpProf_SContNum_Mtxt)
        Stud_Update_Profile_pnl.Controls.Add(UpProf_SContNum_lbl)
        Stud_Update_Profile_pnl.Controls.Add(UpProf_SStud_ID_Mtxt)
        Stud_Update_Profile_pnl.Controls.Add(UpProf_SSection_txt)
        Stud_Update_Profile_pnl.Controls.Add(UpProf_SSection_lbl)
        Stud_Update_Profile_pnl.Controls.Add(UpProf_SProgName_lbl)
        Stud_Update_Profile_pnl.Controls.Add(UpProf_SProgID_lbl)
        Stud_Update_Profile_pnl.Controls.Add(UpProf_SDeptID_lbl)
        Stud_Update_Profile_pnl.Controls.Add(UpProf_SStudID_lbl)
        Stud_Update_Profile_pnl.Controls.Add(UpProf_SProgName_txt)
        Stud_Update_Profile_pnl.Controls.Add(UpProf_SSuffix_txt)
        Stud_Update_Profile_pnl.Controls.Add(UpProf_SLName_txt)
        Stud_Update_Profile_pnl.Controls.Add(UpProf_SMName_txt)
        Stud_Update_Profile_pnl.Controls.Add(UpProf_SFName_txt)
        Stud_Update_Profile_pnl.Controls.Add(UpProf_SSuffix_lbl)
        Stud_Update_Profile_pnl.Controls.Add(UpProf_SLName_lbl)
        Stud_Update_Profile_pnl.Controls.Add(UpProf_SMName_lbl)
        Stud_Update_Profile_pnl.Controls.Add(UpProf__SFName_lbl)
        Stud_Update_Profile_pnl.Controls.Add(UpProfile_Header_Pnl)
        Stud_Update_Profile_pnl.Dock = DockStyle.Fill
        Stud_Update_Profile_pnl.Location = New Point(0, 0)
        Stud_Update_Profile_pnl.Name = "Stud_Update_Profile_pnl"
        Stud_Update_Profile_pnl.Size = New Size(864, 495)
        Stud_Update_Profile_pnl.TabIndex = 1
        ' 
        ' UpProf_SProgID_cmb
        ' 
        UpProf_SProgID_cmb.Enabled = False
        UpProf_SProgID_cmb.FormattingEnabled = True
        UpProf_SProgID_cmb.Location = New Point(344, 269)
        UpProf_SProgID_cmb.Name = "UpProf_SProgID_cmb"
        UpProf_SProgID_cmb.Size = New Size(103, 28)
        UpProf_SProgID_cmb.TabIndex = 29
        ' 
        ' UpProf_SDeptID_cmb
        ' 
        UpProf_SDeptID_cmb.Enabled = False
        UpProf_SDeptID_cmb.FormattingEnabled = True
        UpProf_SDeptID_cmb.Location = New Point(200, 269)
        UpProf_SDeptID_cmb.Name = "UpProf_SDeptID_cmb"
        UpProf_SDeptID_cmb.Size = New Size(103, 28)
        UpProf_SDeptID_cmb.TabIndex = 28
        ' 
        ' UpProf_SCancel_btn
        ' 
        UpProf_SCancel_btn.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        UpProf_SCancel_btn.Location = New Point(717, 415)
        UpProf_SCancel_btn.Name = "UpProf_SCancel_btn"
        UpProf_SCancel_btn.Size = New Size(102, 49)
        UpProf_SCancel_btn.TabIndex = 27
        UpProf_SCancel_btn.Text = "CANCEL"
        UpProf_SCancel_btn.UseVisualStyleBackColor = True
        ' 
        ' UpProf_SSave_btn
        ' 
        UpProf_SSave_btn.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        UpProf_SSave_btn.Location = New Point(602, 415)
        UpProf_SSave_btn.Name = "UpProf_SSave_btn"
        UpProf_SSave_btn.Size = New Size(94, 49)
        UpProf_SSave_btn.TabIndex = 26
        UpProf_SSave_btn.Text = "SAVE"
        UpProf_SSave_btn.UseVisualStyleBackColor = True
        ' 
        ' UpProf_SEmailAdd_txt
        ' 
        UpProf_SEmailAdd_txt.Font = New Font("Segoe UI", 10F)
        UpProf_SEmailAdd_txt.Location = New Point(283, 377)
        UpProf_SEmailAdd_txt.Name = "UpProf_SEmailAdd_txt"
        UpProf_SEmailAdd_txt.Size = New Size(207, 30)
        UpProf_SEmailAdd_txt.TabIndex = 25
        ' 
        ' UpProf_SEmail_lbl
        ' 
        UpProf_SEmail_lbl.AutoSize = True
        UpProf_SEmail_lbl.Font = New Font("Segoe UI", 12F)
        UpProf_SEmail_lbl.Location = New Point(283, 348)
        UpProf_SEmail_lbl.Name = "UpProf_SEmail_lbl"
        UpProf_SEmail_lbl.Size = New Size(138, 28)
        UpProf_SEmail_lbl.TabIndex = 24
        UpProf_SEmail_lbl.Text = "Email Address:"
        ' 
        ' UpProf_SContNum_Mtxt
        ' 
        UpProf_SContNum_Mtxt.Location = New Point(35, 379)
        UpProf_SContNum_Mtxt.Mask = "\+63000-000-0000"
        UpProf_SContNum_Mtxt.Name = "UpProf_SContNum_Mtxt"
        UpProf_SContNum_Mtxt.Size = New Size(176, 27)
        UpProf_SContNum_Mtxt.TabIndex = 23
        UpProf_SContNum_Mtxt.TextMaskFormat = MaskFormat.IncludePromptAndLiterals
        ' 
        ' UpProf_SContNum_lbl
        ' 
        UpProf_SContNum_lbl.AutoSize = True
        UpProf_SContNum_lbl.Font = New Font("Segoe UI", 12F)
        UpProf_SContNum_lbl.Location = New Point(35, 348)
        UpProf_SContNum_lbl.Name = "UpProf_SContNum_lbl"
        UpProf_SContNum_lbl.Size = New Size(161, 28)
        UpProf_SContNum_lbl.TabIndex = 22
        UpProf_SContNum_lbl.Text = "Contact Number:"
        ' 
        ' UpProf_SStud_ID_Mtxt
        ' 
        UpProf_SStud_ID_Mtxt.Enabled = False
        UpProf_SStud_ID_Mtxt.Location = New Point(37, 269)
        UpProf_SStud_ID_Mtxt.Mask = "00-0000"
        UpProf_SStud_ID_Mtxt.Name = "UpProf_SStud_ID_Mtxt"
        UpProf_SStud_ID_Mtxt.Size = New Size(123, 27)
        UpProf_SStud_ID_Mtxt.TabIndex = 19
        ' 
        ' UpProf_SSection_txt
        ' 
        UpProf_SSection_txt.Enabled = False
        UpProf_SSection_txt.Font = New Font("Segoe UI", 10F)
        UpProf_SSection_txt.Location = New Point(668, 267)
        UpProf_SSection_txt.Name = "UpProf_SSection_txt"
        UpProf_SSection_txt.Size = New Size(151, 30)
        UpProf_SSection_txt.TabIndex = 18
        ' 
        ' UpProf_SSection_lbl
        ' 
        UpProf_SSection_lbl.AutoSize = True
        UpProf_SSection_lbl.Font = New Font("Segoe UI", 12F)
        UpProf_SSection_lbl.Location = New Point(670, 238)
        UpProf_SSection_lbl.Name = "UpProf_SSection_lbl"
        UpProf_SSection_lbl.Size = New Size(81, 28)
        UpProf_SSection_lbl.TabIndex = 17
        UpProf_SSection_lbl.Text = "Section:"
        ' 
        ' UpProf_SProgName_lbl
        ' 
        UpProf_SProgName_lbl.AutoSize = True
        UpProf_SProgName_lbl.Font = New Font("Segoe UI", 12F)
        UpProf_SProgName_lbl.Location = New Point(495, 238)
        UpProf_SProgName_lbl.Name = "UpProf_SProgName_lbl"
        UpProf_SProgName_lbl.Size = New Size(92, 28)
        UpProf_SProgName_lbl.TabIndex = 16
        UpProf_SProgName_lbl.Text = "Program:"
        ' 
        ' UpProf_SProgID_lbl
        ' 
        UpProf_SProgID_lbl.AutoSize = True
        UpProf_SProgID_lbl.Font = New Font("Segoe UI", 12F)
        UpProf_SProgID_lbl.Location = New Point(344, 238)
        UpProf_SProgID_lbl.Name = "UpProf_SProgID_lbl"
        UpProf_SProgID_lbl.Size = New Size(116, 28)
        UpProf_SProgID_lbl.TabIndex = 15
        UpProf_SProgID_lbl.Text = "Program ID:"
        ' 
        ' UpProf_SDeptID_lbl
        ' 
        UpProf_SDeptID_lbl.AutoSize = True
        UpProf_SDeptID_lbl.Font = New Font("Segoe UI", 12F)
        UpProf_SDeptID_lbl.Location = New Point(200, 238)
        UpProf_SDeptID_lbl.Name = "UpProf_SDeptID_lbl"
        UpProf_SDeptID_lbl.Size = New Size(87, 28)
        UpProf_SDeptID_lbl.TabIndex = 14
        UpProf_SDeptID_lbl.Text = "Dept. ID:"
        ' 
        ' UpProf_SStudID_lbl
        ' 
        UpProf_SStudID_lbl.AutoSize = True
        UpProf_SStudID_lbl.Font = New Font("Segoe UI", 12F)
        UpProf_SStudID_lbl.Location = New Point(37, 238)
        UpProf_SStudID_lbl.Name = "UpProf_SStudID_lbl"
        UpProf_SStudID_lbl.Size = New Size(108, 28)
        UpProf_SStudID_lbl.TabIndex = 13
        UpProf_SStudID_lbl.Text = "Student ID:"
        ' 
        ' UpProf_SProgName_txt
        ' 
        UpProf_SProgName_txt.Enabled = False
        UpProf_SProgName_txt.Font = New Font("Segoe UI", 10F)
        UpProf_SProgName_txt.Location = New Point(495, 267)
        UpProf_SProgName_txt.Name = "UpProf_SProgName_txt"
        UpProf_SProgName_txt.Size = New Size(142, 30)
        UpProf_SProgName_txt.TabIndex = 12
        ' 
        ' UpProf_SSuffix_txt
        ' 
        UpProf_SSuffix_txt.Font = New Font("Segoe UI", 10F)
        UpProf_SSuffix_txt.Location = New Point(657, 168)
        UpProf_SSuffix_txt.Name = "UpProf_SSuffix_txt"
        UpProf_SSuffix_txt.Size = New Size(162, 30)
        UpProf_SSuffix_txt.TabIndex = 11
        ' 
        ' UpProf_SLName_txt
        ' 
        UpProf_SLName_txt.Font = New Font("Segoe UI", 10F)
        UpProf_SLName_txt.Location = New Point(448, 168)
        UpProf_SLName_txt.Name = "UpProf_SLName_txt"
        UpProf_SLName_txt.Size = New Size(162, 30)
        UpProf_SLName_txt.TabIndex = 10
        ' 
        ' UpProf_SMName_txt
        ' 
        UpProf_SMName_txt.Font = New Font("Segoe UI", 10F)
        UpProf_SMName_txt.Location = New Point(241, 168)
        UpProf_SMName_txt.Name = "UpProf_SMName_txt"
        UpProf_SMName_txt.Size = New Size(162, 30)
        UpProf_SMName_txt.TabIndex = 9
        ' 
        ' UpProf_SFName_txt
        ' 
        UpProf_SFName_txt.Font = New Font("Segoe UI", 10F)
        UpProf_SFName_txt.Location = New Point(35, 168)
        UpProf_SFName_txt.Name = "UpProf_SFName_txt"
        UpProf_SFName_txt.Size = New Size(162, 30)
        UpProf_SFName_txt.TabIndex = 8
        ' 
        ' UpProf_SSuffix_lbl
        ' 
        UpProf_SSuffix_lbl.AutoSize = True
        UpProf_SSuffix_lbl.Font = New Font("Segoe UI", 12F)
        UpProf_SSuffix_lbl.Location = New Point(657, 137)
        UpProf_SSuffix_lbl.Name = "UpProf_SSuffix_lbl"
        UpProf_SSuffix_lbl.Size = New Size(64, 28)
        UpProf_SSuffix_lbl.TabIndex = 7
        UpProf_SSuffix_lbl.Text = "Suffix:"
        ' 
        ' UpProf_SLName_lbl
        ' 
        UpProf_SLName_lbl.AutoSize = True
        UpProf_SLName_lbl.Font = New Font("Segoe UI", 12F)
        UpProf_SLName_lbl.Location = New Point(448, 137)
        UpProf_SLName_lbl.Name = "UpProf_SLName_lbl"
        UpProf_SLName_lbl.Size = New Size(107, 28)
        UpProf_SLName_lbl.TabIndex = 6
        UpProf_SLName_lbl.Text = "Last Name:"
        ' 
        ' UpProf_SMName_lbl
        ' 
        UpProf_SMName_lbl.AutoSize = True
        UpProf_SMName_lbl.Font = New Font("Segoe UI", 12F)
        UpProf_SMName_lbl.Location = New Point(241, 137)
        UpProf_SMName_lbl.Name = "UpProf_SMName_lbl"
        UpProf_SMName_lbl.Size = New Size(135, 28)
        UpProf_SMName_lbl.TabIndex = 5
        UpProf_SMName_lbl.Text = "Middle Name:"
        ' 
        ' UpProf__SFName_lbl
        ' 
        UpProf__SFName_lbl.AutoSize = True
        UpProf__SFName_lbl.Font = New Font("Segoe UI", 12F)
        UpProf__SFName_lbl.Location = New Point(35, 137)
        UpProf__SFName_lbl.Name = "UpProf__SFName_lbl"
        UpProf__SFName_lbl.Size = New Size(110, 28)
        UpProf__SFName_lbl.TabIndex = 4
        UpProf__SFName_lbl.Text = "First Name:"
        ' 
        ' UpProfile_Header_Pnl
        ' 
        UpProfile_Header_Pnl.BackColor = Color.MidnightBlue
        UpProfile_Header_Pnl.Controls.Add(UpdateProfile_lbl)
        UpProfile_Header_Pnl.Dock = DockStyle.Top
        UpProfile_Header_Pnl.Location = New Point(0, 0)
        UpProfile_Header_Pnl.Name = "UpProfile_Header_Pnl"
        UpProfile_Header_Pnl.Size = New Size(864, 100)
        UpProfile_Header_Pnl.TabIndex = 3
        ' 
        ' UpdateProfile_lbl
        ' 
        UpdateProfile_lbl.AutoSize = True
        UpdateProfile_lbl.Font = New Font("Stencil", 28.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        UpdateProfile_lbl.ForeColor = Color.Goldenrod
        UpdateProfile_lbl.Location = New Point(246, 20)
        UpdateProfile_lbl.Name = "UpdateProfile_lbl"
        UpdateProfile_lbl.Size = New Size(405, 56)
        UpdateProfile_lbl.TabIndex = 9
        UpdateProfile_lbl.Text = "UPDATE PROFILE"
        ' 
        ' Stud_ChangePass_Container_pnl
        ' 
        Stud_ChangePass_Container_pnl.Controls.Add(Change_Password_Pnl)
        Stud_ChangePass_Container_pnl.Controls.Add(ChangePass_Header)
        Stud_ChangePass_Container_pnl.Dock = DockStyle.Fill
        Stud_ChangePass_Container_pnl.Location = New Point(0, 0)
        Stud_ChangePass_Container_pnl.Name = "Stud_ChangePass_Container_pnl"
        Stud_ChangePass_Container_pnl.Size = New Size(864, 495)
        Stud_ChangePass_Container_pnl.TabIndex = 3
        ' 
        ' Change_Password_Pnl
        ' 
        Change_Password_Pnl.Controls.Add(ChangePass_Cancel_btn)
        Change_Password_Pnl.Controls.Add(ChangePass_Save_btn)
        Change_Password_Pnl.Controls.Add(ChangePass_Showpass_cb)
        Change_Password_Pnl.Controls.Add(ChangePass_ConPass_lbl)
        Change_Password_Pnl.Controls.Add(ChangePass_NewPass_lbl)
        Change_Password_Pnl.Controls.Add(ChangePass_OldPass_lbl)
        Change_Password_Pnl.Controls.Add(ChangePass_Conpass_txt)
        Change_Password_Pnl.Controls.Add(ChangePass_NewPass_txt)
        Change_Password_Pnl.Controls.Add(ChangePass_OldPass_txt)
        Change_Password_Pnl.Dock = DockStyle.Fill
        Change_Password_Pnl.Location = New Point(0, 100)
        Change_Password_Pnl.Name = "Change_Password_Pnl"
        Change_Password_Pnl.Size = New Size(864, 395)
        Change_Password_Pnl.TabIndex = 3
        ' 
        ' ChangePass_Cancel_btn
        ' 
        ChangePass_Cancel_btn.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        ChangePass_Cancel_btn.Location = New Point(739, 319)
        ChangePass_Cancel_btn.Name = "ChangePass_Cancel_btn"
        ChangePass_Cancel_btn.Size = New Size(96, 45)
        ChangePass_Cancel_btn.TabIndex = 8
        ChangePass_Cancel_btn.Text = "CANCEL"
        ChangePass_Cancel_btn.UseVisualStyleBackColor = True
        ' 
        ' ChangePass_Save_btn
        ' 
        ChangePass_Save_btn.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        ChangePass_Save_btn.Location = New Point(637, 319)
        ChangePass_Save_btn.Name = "ChangePass_Save_btn"
        ChangePass_Save_btn.Size = New Size(96, 45)
        ChangePass_Save_btn.TabIndex = 7
        ChangePass_Save_btn.Text = "SAVE"
        ChangePass_Save_btn.UseVisualStyleBackColor = True
        ' 
        ' ChangePass_Showpass_cb
        ' 
        ChangePass_Showpass_cb.AutoSize = True
        ChangePass_Showpass_cb.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        ChangePass_Showpass_cb.Location = New Point(254, 319)
        ChangePass_Showpass_cb.Name = "ChangePass_Showpass_cb"
        ChangePass_Showpass_cb.Size = New Size(130, 24)
        ChangePass_Showpass_cb.TabIndex = 6
        ChangePass_Showpass_cb.Text = "Show Password"
        ChangePass_Showpass_cb.UseVisualStyleBackColor = True
        ' 
        ' ChangePass_ConPass_lbl
        ' 
        ChangePass_ConPass_lbl.AutoSize = True
        ChangePass_ConPass_lbl.Font = New Font("Segoe UI", 14F)
        ChangePass_ConPass_lbl.Location = New Point(254, 235)
        ChangePass_ConPass_lbl.Name = "ChangePass_ConPass_lbl"
        ChangePass_ConPass_lbl.Size = New Size(209, 32)
        ChangePass_ConPass_lbl.TabIndex = 5
        ChangePass_ConPass_lbl.Text = "Confirm Password:"
        ' 
        ' ChangePass_NewPass_lbl
        ' 
        ChangePass_NewPass_lbl.AutoSize = True
        ChangePass_NewPass_lbl.Font = New Font("Segoe UI", 14F)
        ChangePass_NewPass_lbl.Location = New Point(254, 130)
        ChangePass_NewPass_lbl.Name = "ChangePass_NewPass_lbl"
        ChangePass_NewPass_lbl.Size = New Size(171, 32)
        ChangePass_NewPass_lbl.TabIndex = 4
        ChangePass_NewPass_lbl.Text = "New Password:"
        ' 
        ' ChangePass_OldPass_lbl
        ' 
        ChangePass_OldPass_lbl.AutoSize = True
        ChangePass_OldPass_lbl.Font = New Font("Segoe UI", 14F)
        ChangePass_OldPass_lbl.Location = New Point(254, 22)
        ChangePass_OldPass_lbl.Name = "ChangePass_OldPass_lbl"
        ChangePass_OldPass_lbl.Size = New Size(161, 32)
        ChangePass_OldPass_lbl.TabIndex = 3
        ChangePass_OldPass_lbl.Text = "Old Password:"
        ' 
        ' ChangePass_Conpass_txt
        ' 
        ChangePass_Conpass_txt.Font = New Font("Segoe UI", 16F)
        ChangePass_Conpass_txt.Location = New Point(254, 270)
        ChangePass_Conpass_txt.Name = "ChangePass_Conpass_txt"
        ChangePass_Conpass_txt.PasswordChar = "*"c
        ChangePass_Conpass_txt.Size = New Size(360, 43)
        ChangePass_Conpass_txt.TabIndex = 2
        ' 
        ' ChangePass_NewPass_txt
        ' 
        ChangePass_NewPass_txt.Font = New Font("Segoe UI", 16F)
        ChangePass_NewPass_txt.Location = New Point(254, 165)
        ChangePass_NewPass_txt.Name = "ChangePass_NewPass_txt"
        ChangePass_NewPass_txt.PasswordChar = "*"c
        ChangePass_NewPass_txt.Size = New Size(360, 43)
        ChangePass_NewPass_txt.TabIndex = 1
        ' 
        ' ChangePass_OldPass_txt
        ' 
        ChangePass_OldPass_txt.Font = New Font("Segoe UI", 16F)
        ChangePass_OldPass_txt.Location = New Point(254, 57)
        ChangePass_OldPass_txt.Name = "ChangePass_OldPass_txt"
        ChangePass_OldPass_txt.PasswordChar = "*"c
        ChangePass_OldPass_txt.Size = New Size(360, 43)
        ChangePass_OldPass_txt.TabIndex = 0
        ' 
        ' ChangePass_Header
        ' 
        ChangePass_Header.BackColor = Color.MidnightBlue
        ChangePass_Header.Controls.Add(ChangePass_lbl)
        ChangePass_Header.Dock = DockStyle.Top
        ChangePass_Header.Location = New Point(0, 0)
        ChangePass_Header.Name = "ChangePass_Header"
        ChangePass_Header.Size = New Size(864, 100)
        ChangePass_Header.TabIndex = 2
        ' 
        ' ChangePass_lbl
        ' 
        ChangePass_lbl.AutoSize = True
        ChangePass_lbl.Font = New Font("Stencil", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ChangePass_lbl.ForeColor = Color.Goldenrod
        ChangePass_lbl.Location = New Point(241, 27)
        ChangePass_lbl.Name = "ChangePass_lbl"
        ChangePass_lbl.Size = New Size(389, 47)
        ChangePass_lbl.TabIndex = 9
        ChangePass_lbl.Text = "CHANGE PASSWORD"
        ' 
        ' Update_Account
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(864, 495)
        Controls.Add(Update_Panel)
        Name = "Update_Account"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Update_Account"
        Update_Panel.ResumeLayout(False)
        Faculty_Update.ResumeLayout(False)
        Fac_Update_Profile_pnl.ResumeLayout(False)
        Fac_Update_Profile_pnl.PerformLayout()
        FacUpdate_Header.ResumeLayout(False)
        FacUpdate_Header.PerformLayout()
        Fac_ChangePass_Container_pnl.ResumeLayout(False)
        Fac_ChangePassword_pnl.ResumeLayout(False)
        Fac_ChangePassword_pnl.PerformLayout()
        Fac_ChangePass_Header.ResumeLayout(False)
        Fac_ChangePass_Header.PerformLayout()
        Student_Update.ResumeLayout(False)
        Stud_Update_Profile_pnl.ResumeLayout(False)
        Stud_Update_Profile_pnl.PerformLayout()
        UpProfile_Header_Pnl.ResumeLayout(False)
        UpProfile_Header_Pnl.PerformLayout()
        Stud_ChangePass_Container_pnl.ResumeLayout(False)
        Change_Password_Pnl.ResumeLayout(False)
        Change_Password_Pnl.PerformLayout()
        ChangePass_Header.ResumeLayout(False)
        ChangePass_Header.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Update_Panel As Panel
    Friend WithEvents Student_Update As Panel
    Friend WithEvents Stud_Update_Profile_pnl As Panel
    Friend WithEvents UpProfile_Header_Pnl As Panel
    Friend WithEvents ChangePass_Header As Panel
    Friend WithEvents ChangePass_lbl As Label
    Friend WithEvents UpdateProfile_lbl As Label
    Friend WithEvents Stud_ChangePass_Container_pnl As Panel
    Friend WithEvents Change_Password_Pnl As Panel
    Friend WithEvents ChangePass_Cancel_btn As Button
    Friend WithEvents ChangePass_Save_btn As Button
    Friend WithEvents ChangePass_Showpass_cb As CheckBox
    Friend WithEvents ChangePass_ConPass_lbl As Label
    Friend WithEvents ChangePass_NewPass_lbl As Label
    Friend WithEvents ChangePass_OldPass_lbl As Label
    Friend WithEvents ChangePass_Conpass_txt As TextBox
    Friend WithEvents ChangePass_NewPass_txt As TextBox
    Friend WithEvents ChangePass_OldPass_txt As TextBox
    Friend WithEvents UpProf_SSuffix_txt As TextBox
    Friend WithEvents UpProf_SLName_txt As TextBox
    Friend WithEvents UpProf_SMName_txt As TextBox
    Friend WithEvents UpProf_SFName_txt As TextBox
    Friend WithEvents UpProf_SSuffix_lbl As Label
    Friend WithEvents UpProf_SLName_lbl As Label
    Friend WithEvents UpProf_SMName_lbl As Label
    Friend WithEvents UpProf__SFName_lbl As Label
    Friend WithEvents UpProf_SSection_lbl As Label
    Friend WithEvents UpProf_SProgName_lbl As Label
    Friend WithEvents UpProf_SProgID_lbl As Label
    Friend WithEvents UpProf_SDeptID_lbl As Label
    Friend WithEvents UpProf_SStudID_lbl As Label
    Friend WithEvents UpProf_SProgName_txt As TextBox
    Friend WithEvents UpProf_SStud_ID_Mtxt As MaskedTextBox
    Friend WithEvents UpProf_SSection_txt As TextBox
    Friend WithEvents UpProf_SCancel_btn As Button
    Friend WithEvents UpProf_SSave_btn As Button
    Friend WithEvents UpProf_SEmailAdd_txt As TextBox
    Friend WithEvents UpProf_SEmail_lbl As Label
    Friend WithEvents UpProf_SContNum_Mtxt As MaskedTextBox
    Friend WithEvents UpProf_SContNum_lbl As Label
    Friend WithEvents UpProf_SProgID_cmb As ComboBox
    Friend WithEvents UpProf_SDeptID_cmb As ComboBox
    Friend WithEvents Faculty_Update As Panel
    Friend WithEvents Fac_ChangePass_Container_pnl As Panel
    Friend WithEvents Fac_ChangePassword_pnl As Panel
    Friend WithEvents Fac_ChangePass_Cancel_btn As Button
    Friend WithEvents Fac_ChangePass_Save_btn As Button
    Friend WithEvents Fac_ChangePass_ShowPass_cb As CheckBox
    Friend WithEvents Fac_ChangePass_ConPass_lbl As Label
    Friend WithEvents Fac_ChangePass_NewPass_lbl As Label
    Friend WithEvents Fac_ChangePass_OldPass_lbl As Label
    Friend WithEvents Fac_ChangePass_ConPass_txt As TextBox
    Friend WithEvents Fac_ChangePass_NewPass_txt As TextBox
    Friend WithEvents Fac_ChangePass_OldPass_txt As TextBox
    Friend WithEvents Fac_ChangePass_Header As Panel
    Friend WithEvents Fac_ChangePass_lbl As Label
    Friend WithEvents Fac_Update_Profile_pnl As Panel
    Friend WithEvents FacUpdate_DeptID_cmb As ComboBox
    Friend WithEvents FacUpdate_Cancel_btn As Button
    Friend WithEvents FacUpdate_Save_btn As Button
    Friend WithEvents FacUpdate_Email_txt As TextBox
    Friend WithEvents FacUpdate_Email_lbl As Label
    Friend WithEvents FacUpdate_ContNo_Mtxt As MaskedTextBox
    Friend WithEvents FacUpdate_EmpStat_txt As TextBox
    Friend WithEvents FacUpdate_ContNo_lbl As Label
    Friend WithEvents FacUpdate_FacID_Mtxt As MaskedTextBox
    Friend WithEvents FacUpdate_Position_txt As TextBox
    Friend WithEvents FacUpdate_Position_lbl As Label
    Friend WithEvents FacUpdate_DeptName_lbl As Label
    Friend WithEvents FacUpdate_EmpStat_lbl As Label
    Friend WithEvents FacUpdate_DeptID_lbl As Label
    Friend WithEvents FacUpdate_FacID_lbl As Label
    Friend WithEvents FacUpdate_DeptName_txt As TextBox
    Friend WithEvents FacUpdate_SName_txt As TextBox
    Friend WithEvents FacUpdate_LName_txt As TextBox
    Friend WithEvents FacUpdate_MName_txt As TextBox
    Friend WithEvents FacUpdate_FName_txt As TextBox
    Friend WithEvents FacUpdate_SName_lbl As Label
    Friend WithEvents FacUpdate_LName_lbl As Label
    Friend WithEvents FacUpdate_MName_lbl As Label
    Friend WithEvents FacUpdate_FName_lbl As Label
    Friend WithEvents FacUpdate_Header As Panel
    Friend WithEvents FacUpdateTitle_lbl As Label
End Class

'Error: 'Update_Profile_Pnl' is ambiguous because multiple kinds of members with this name exist in class 'Update_Account'.