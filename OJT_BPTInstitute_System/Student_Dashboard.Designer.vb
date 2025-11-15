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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Student_Dashboard))
        Logo_Pic = New PictureBox()
        Home_BTN = New LinkLabel()
        About_BTN = New LinkLabel()
        MyAcc_BTN = New LinkLabel()
        Logout_BTN = New LinkLabel()
        SchoolName_Lbl = New Label()
        MainMenu_Panel = New Panel()
        Label7 = New Label()
        Home_Panel = New Panel()
        Panel4 = New Panel()
        Panel3 = New Panel()
        Button6 = New Button()
        Button5 = New Button()
        Button4 = New Button()
        Panel2 = New Panel()
        Label2 = New Label()
        About_Panel = New Panel()
        Label6 = New Label()
        Label5 = New Label()
        PictureBox2 = New PictureBox()
        Account_Panel = New Panel()
        Label14 = New Label()
        Label13 = New Label()
        Panel8 = New Panel()
        Label11 = New Label()
        Panel7 = New Panel()
        Label10 = New Label()
        Panel6 = New Panel()
        Label9 = New Label()
        Panel5 = New Panel()
        Label8 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Panel1 = New Panel()
        Button2 = New Button()
        Button1 = New Button()
        Screen_Panel = New Panel()
        Label15 = New Label()
        Label1 = New Label()
        Panel10 = New Panel()
        Label16 = New Label()
        Panel11 = New Panel()
        Label17 = New Label()
        Profile = New Panel()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        FlowLayoutPanel2 = New FlowLayoutPanel()
        CType(Logo_Pic, ComponentModel.ISupportInitialize).BeginInit()
        MainMenu_Panel.SuspendLayout()
        Home_Panel.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        About_Panel.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Account_Panel.SuspendLayout()
        Panel8.SuspendLayout()
        Panel7.SuspendLayout()
        Panel6.SuspendLayout()
        Panel5.SuspendLayout()
        Panel1.SuspendLayout()
        Screen_Panel.SuspendLayout()
        Panel10.SuspendLayout()
        Panel11.SuspendLayout()
        SuspendLayout()
        ' 
        ' Logo_Pic
        ' 
        Logo_Pic.Image = My.Resources.Resources.BPTI_Logo1
        Logo_Pic.Location = New Point(12, 15)
        Logo_Pic.Name = "Logo_Pic"
        Logo_Pic.Size = New Size(101, 80)
        Logo_Pic.SizeMode = PictureBoxSizeMode.StretchImage
        Logo_Pic.TabIndex = 0
        Logo_Pic.TabStop = False
        ' 
        ' Home_BTN
        ' 
        Home_BTN.ActiveLinkColor = Color.Goldenrod
        Home_BTN.AutoSize = True
        Home_BTN.BackColor = Color.Navy
        Home_BTN.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Home_BTN.LinkColor = Color.White
        Home_BTN.Location = New Point(433, 56)
        Home_BTN.Name = "Home_BTN"
        Home_BTN.Size = New Size(61, 23)
        Home_BTN.TabIndex = 0
        Home_BTN.TabStop = True
        Home_BTN.Text = "HOME"
        ' 
        ' About_BTN
        ' 
        About_BTN.ActiveLinkColor = Color.Goldenrod
        About_BTN.AutoSize = True
        About_BTN.BackColor = Color.Navy
        About_BTN.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        About_BTN.LinkColor = Color.White
        About_BTN.Location = New Point(672, 56)
        About_BTN.Name = "About_BTN"
        About_BTN.Size = New Size(65, 23)
        About_BTN.TabIndex = 6
        About_BTN.TabStop = True
        About_BTN.Text = "ABOUT"
        ' 
        ' MyAcc_BTN
        ' 
        MyAcc_BTN.ActiveLinkColor = Color.Goldenrod
        MyAcc_BTN.AutoSize = True
        MyAcc_BTN.BackColor = Color.Navy
        MyAcc_BTN.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MyAcc_BTN.LinkColor = Color.White
        MyAcc_BTN.Location = New Point(524, 56)
        MyAcc_BTN.Name = "MyAcc_BTN"
        MyAcc_BTN.Size = New Size(121, 23)
        MyAcc_BTN.TabIndex = 8
        MyAcc_BTN.TabStop = True
        MyAcc_BTN.Text = "MY ACCOUNT"
        ' 
        ' Logout_BTN
        ' 
        Logout_BTN.ActiveLinkColor = Color.Goldenrod
        Logout_BTN.AutoSize = True
        Logout_BTN.BackColor = Color.Navy
        Logout_BTN.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Logout_BTN.LinkColor = Color.White
        Logout_BTN.Location = New Point(763, 56)
        Logout_BTN.Name = "Logout_BTN"
        Logout_BTN.Size = New Size(76, 23)
        Logout_BTN.TabIndex = 9
        Logout_BTN.TabStop = True
        Logout_BTN.Text = "LOGOUT"
        ' 
        ' SchoolName_Lbl
        ' 
        SchoolName_Lbl.BackColor = Color.Navy
        SchoolName_Lbl.Font = New Font("Stencil", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SchoolName_Lbl.ForeColor = Color.Goldenrod
        SchoolName_Lbl.Location = New Point(119, 15)
        SchoolName_Lbl.Name = "SchoolName_Lbl"
        SchoolName_Lbl.Size = New Size(308, 80)
        SchoolName_Lbl.TabIndex = 10
        SchoolName_Lbl.Text = "Bright Path " & vbCrLf & "Technical Institute"
        SchoolName_Lbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' MainMenu_Panel
        ' 
        MainMenu_Panel.BackColor = Color.Navy
        MainMenu_Panel.Controls.Add(Logo_Pic)
        MainMenu_Panel.Controls.Add(Home_BTN)
        MainMenu_Panel.Controls.Add(About_BTN)
        MainMenu_Panel.Controls.Add(MyAcc_BTN)
        MainMenu_Panel.Controls.Add(Logout_BTN)
        MainMenu_Panel.Controls.Add(SchoolName_Lbl)
        MainMenu_Panel.Location = New Point(2, -1)
        MainMenu_Panel.Name = "MainMenu_Panel"
        MainMenu_Panel.Size = New Size(853, 106)
        MainMenu_Panel.TabIndex = 13
        ' 
        ' Label7
        ' 
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Stencil", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(3, 5)
        Label7.Name = "Label7"
        Label7.Size = New Size(853, 62)
        Label7.TabIndex = 3
        Label7.Text = "Welcome [Name]"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Home_Panel
        ' 
        Home_Panel.Controls.Add(Panel4)
        Home_Panel.Controls.Add(Panel3)
        Home_Panel.Controls.Add(Panel2)
        Home_Panel.Controls.Add(Label7)
        Home_Panel.Location = New Point(0, 0)
        Home_Panel.Name = "Home_Panel"
        Home_Panel.Size = New Size(856, 427)
        Home_Panel.TabIndex = 12
        ' 
        ' Panel4
        ' 
        Panel4.Location = New Point(325, 221)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(511, 186)
        Panel4.TabIndex = 6
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Button6)
        Panel3.Controls.Add(Button5)
        Panel3.Controls.Add(Button4)
        Panel3.Location = New Point(325, 71)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(511, 131)
        Panel3.TabIndex = 5
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(0, 83)
        Button6.Name = "Button6"
        Button6.Size = New Size(512, 47)
        Button6.TabIndex = 7
        Button6.Text = "67"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(0, 41)
        Button5.Name = "Button5"
        Button5.Size = New Size(512, 44)
        Button5.TabIndex = 3
        Button5.Text = "EVALUATION"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(0, -1)
        Button4.Name = "Button4"
        Button4.Size = New Size(512, 44)
        Button4.TabIndex = 2
        Button4.Text = "PROFILE"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(22, 70)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(287, 337)
        Panel2.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.Location = New Point(3, 1)
        Label2.Name = "Label2"
        Label2.Size = New Size(281, 44)
        Label2.TabIndex = 0
        Label2.Text = "ANNOUNCEMENTS"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' About_Panel
        ' 
        About_Panel.Controls.Add(Label6)
        About_Panel.Controls.Add(Label5)
        About_Panel.Controls.Add(PictureBox2)
        About_Panel.Location = New Point(0, 0)
        About_Panel.Name = "About_Panel"
        About_Panel.Size = New Size(853, 416)
        About_Panel.TabIndex = 5
        About_Panel.Visible = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(271, 57)
        Label6.Name = "Label6"
        Label6.Size = New Size(518, 80)
        Label6.TabIndex = 3
        Label6.Text = resources.GetString("Label6.Text")
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Stencil", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Navy
        Label5.Location = New Point(271, 17)
        Label5.Name = "Label5"
        Label5.Size = New Size(180, 33)
        Label5.TabIndex = 2
        Label5.Text = "ABOUT LOGO"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(61, 17)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(192, 176)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' Account_Panel
        ' 
        Account_Panel.Controls.Add(FlowLayoutPanel2)
        Account_Panel.Controls.Add(Panel11)
        Account_Panel.Controls.Add(Panel8)
        Account_Panel.Controls.Add(Panel7)
        Account_Panel.Controls.Add(Panel10)
        Account_Panel.Controls.Add(Label1)
        Account_Panel.Controls.Add(Label15)
        Account_Panel.Controls.Add(Label14)
        Account_Panel.Controls.Add(Label13)
        Account_Panel.Controls.Add(Panel6)
        Account_Panel.Controls.Add(Panel5)
        Account_Panel.Controls.Add(Label4)
        Account_Panel.Controls.Add(Label3)
        Account_Panel.Controls.Add(Panel1)
        Account_Panel.Location = New Point(0, 0)
        Account_Panel.Name = "Account_Panel"
        Account_Panel.Size = New Size(853, 422)
        Account_Panel.TabIndex = 4
        Account_Panel.Visible = False
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(199, 226)
        Label14.Name = "Label14"
        Label14.Size = New Size(122, 28)
        Label14.TabIndex = 17
        Label14.Text = "CONTACT :"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(232, 153)
        Label13.Name = "Label13"
        Label13.Size = New Size(88, 28)
        Label13.TabIndex = 16
        Label13.Text = "EMAIL :"
        ' 
        ' Panel8
        ' 
        Panel8.Controls.Add(Label11)
        Panel8.Location = New Point(323, 218)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(501, 49)
        Panel8.TabIndex = 14
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(3, 15)
        Label11.Name = "Label11"
        Label11.Size = New Size(61, 20)
        Label11.TabIndex = 10
        Label11.Text = "Label11"
        ' 
        ' Panel7
        ' 
        Panel7.Controls.Add(Label10)
        Panel7.Location = New Point(323, 144)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(501, 49)
        Panel7.TabIndex = 13
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(3, 14)
        Label10.Name = "Label10"
        Label10.Size = New Size(61, 20)
        Label10.TabIndex = 10
        Label10.Text = "Label10"
        ' 
        ' Panel6
        ' 
        Panel6.Controls.Add(Label9)
        Panel6.Location = New Point(323, 71)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(501, 50)
        Panel6.TabIndex = 12
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(3, 15)
        Label9.Name = "Label9"
        Label9.Size = New Size(53, 20)
        Label9.TabIndex = 10
        Label9.Text = "Label9"
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(Label8)
        Panel5.Location = New Point(310, 14)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(84, 40)
        Panel5.TabIndex = 11
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(3, 10)
        Label8.Name = "Label8"
        Label8.Size = New Size(53, 20)
        Label8.TabIndex = 10
        Label8.Text = "Label8"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(181, 81)
        Label4.Name = "Label4"
        Label4.Size = New Size(140, 28)
        Label4.TabIndex = 8
        Label4.Text = "FULL NAME :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(198, 24)
        Label3.Name = "Label3"
        Label3.Size = New Size(109, 20)
        Label3.TabIndex = 7
        Label3.Text = "STUDENT ID :"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Controls.Add(FlowLayoutPanel1)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Location = New Point(1, -2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(174, 421)
        Panel1.TabIndex = 5
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ButtonHighlight
        Button2.Location = New Point(-3, 74)
        Button2.Name = "Button2"
        Button2.Size = New Size(177, 49)
        Button2.TabIndex = 1
        Button2.Text = "INTERNSHIP STATUS"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(-3, 1)
        Button1.Name = "Button1"
        Button1.Size = New Size(178, 49)
        Button1.TabIndex = 0
        Button1.Text = "PROFILE"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Screen_Panel
        ' 
        Screen_Panel.Controls.Add(Account_Panel)
        Screen_Panel.Controls.Add(Home_Panel)
        Screen_Panel.Controls.Add(About_Panel)
        Screen_Panel.Location = New Point(4, 108)
        Screen_Panel.Name = "Screen_Panel"
        Screen_Panel.Size = New Size(850, 425)
        Screen_Panel.TabIndex = 4
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(400, 24)
        Label15.Name = "Label15"
        Label15.Size = New Size(96, 20)
        Label15.TabIndex = 18
        Label15.Text = "COURSE ID :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(593, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(143, 20)
        Label1.TabIndex = 19
        Label1.Text = "DEPARTMENT ID :"
        ' 
        ' Panel10
        ' 
        Panel10.Controls.Add(Label16)
        Panel10.Location = New Point(500, 14)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(84, 40)
        Panel10.TabIndex = 20
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(3, 10)
        Label16.Name = "Label16"
        Label16.Size = New Size(61, 20)
        Label16.TabIndex = 10
        Label16.Text = "Label16"
        ' 
        ' Panel11
        ' 
        Panel11.Controls.Add(Label17)
        Panel11.Location = New Point(740, 14)
        Panel11.Name = "Panel11"
        Panel11.Size = New Size(84, 40)
        Panel11.TabIndex = 21
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(3, 10)
        Label17.Name = "Label17"
        Label17.Size = New Size(61, 20)
        Label17.TabIndex = 10
        Label17.Text = "Label17"
        ' 
        ' Profile
        ' 
        Profile.Location = New Point(179, 106)
        Profile.Name = "Profile"
        Profile.Size = New Size(675, 421)
        Profile.TabIndex = 22
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Location = New Point(158, 72)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(8, 8)
        FlowLayoutPanel1.TabIndex = 2
        ' 
        ' FlowLayoutPanel2
        ' 
        FlowLayoutPanel2.Location = New Point(271, 320)
        FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        FlowLayoutPanel2.Size = New Size(8, 8)
        FlowLayoutPanel2.TabIndex = 22
        ' 
        ' Student_Dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(852, 527)
        Controls.Add(MainMenu_Panel)
        Controls.Add(Screen_Panel)
        Controls.Add(Profile)
        Name = "Student_Dashboard"
        Text = "Student"
        CType(Logo_Pic, ComponentModel.ISupportInitialize).EndInit()
        MainMenu_Panel.ResumeLayout(False)
        MainMenu_Panel.PerformLayout()
        Home_Panel.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        About_Panel.ResumeLayout(False)
        About_Panel.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Account_Panel.ResumeLayout(False)
        Account_Panel.PerformLayout()
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel1.ResumeLayout(False)
        Screen_Panel.ResumeLayout(False)
        Panel10.ResumeLayout(False)
        Panel10.PerformLayout()
        Panel11.ResumeLayout(False)
        Panel11.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Logo_Pic As PictureBox
    Friend WithEvents Home_BTN As LinkLabel
    Friend WithEvents About_BTN As LinkLabel
    Friend WithEvents MyAcc_BTN As LinkLabel
    Friend WithEvents Logout_BTN As LinkLabel
    Friend WithEvents SchoolName_Lbl As Label
    Friend WithEvents MainMenu_Panel As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Home_Panel As Panel
    Friend WithEvents About_Panel As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Account_Panel As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Screen_Panel As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Label17 As Label
    Friend WithEvents Profile As Panel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
End Class
