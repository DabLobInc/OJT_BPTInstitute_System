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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Faculty_Dashboard))
        Logo_Pic = New PictureBox()
        Home_BTN = New LinkLabel()
        About_BTN = New LinkLabel()
        MyAcc_BTN = New LinkLabel()
        Logout_BTN = New LinkLabel()
        SchoolName_Lbl = New Label()
        MainMenu_Panel = New Panel()
        Screen_Panel = New Panel()
        Home_Panel = New Panel()
        Label7 = New Label()
        About_Panel = New Panel()
        Label6 = New Label()
        Label5 = New Label()
        PictureBox2 = New PictureBox()
        Account_Panel = New Panel()
        Panel1 = New Panel()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Label1 = New Label()
        CType(Logo_Pic, ComponentModel.ISupportInitialize).BeginInit()
        MainMenu_Panel.SuspendLayout()
        Screen_Panel.SuspendLayout()
        Home_Panel.SuspendLayout()
        About_Panel.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Account_Panel.SuspendLayout()
        Panel1.SuspendLayout()
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
        MainMenu_Panel.Location = New Point(0, 0)
        MainMenu_Panel.Name = "MainMenu_Panel"
        MainMenu_Panel.Size = New Size(853, 106)
        MainMenu_Panel.TabIndex = 11
        ' 
        ' Screen_Panel
        ' 
        Screen_Panel.Controls.Add(Home_Panel)
        Screen_Panel.Controls.Add(About_Panel)
        Screen_Panel.Controls.Add(Account_Panel)
        Screen_Panel.Location = New Point(0, 107)
        Screen_Panel.Name = "Screen_Panel"
        Screen_Panel.Size = New Size(850, 425)
        Screen_Panel.TabIndex = 11
        ' 
        ' Home_Panel
        ' 
        Home_Panel.Controls.Add(Label7)
        Home_Panel.Location = New Point(0, 0)
        Home_Panel.Name = "Home_Panel"
        Home_Panel.Size = New Size(856, 427)
        Home_Panel.TabIndex = 12
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
        Label7.Text = "DASHBOARD"
        Label7.TextAlign = ContentAlignment.MiddleCenter
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
        Account_Panel.Controls.Add(Panel1)
        Account_Panel.Controls.Add(Label1)
        Account_Panel.Location = New Point(0, 0)
        Account_Panel.Name = "Account_Panel"
        Account_Panel.Size = New Size(853, 422)
        Account_Panel.TabIndex = 4
        Account_Panel.Visible = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Location = New Point(1, -2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(174, 421)
        Panel1.TabIndex = 5
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(21, 203)
        Button3.Name = "Button3"
        Button3.Size = New Size(150, 49)
        Button3.TabIndex = 2
        Button3.Text = "Button3"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(21, 135)
        Button2.Name = "Button2"
        Button2.Size = New Size(150, 49)
        Button2.TabIndex = 1
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(21, 67)
        Button1.Name = "Button1"
        Button1.Size = New Size(150, 49)
        Button1.TabIndex = 0
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Stencil", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(173, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(680, 62)
        Label1.TabIndex = 4
        Label1.Text = "ACCOUNT"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Faculty_Dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(852, 527)
        Controls.Add(MainMenu_Panel)
        Controls.Add(Screen_Panel)
        Name = "Faculty_Dashboard"
        Text = "Faculty"
        CType(Logo_Pic, ComponentModel.ISupportInitialize).EndInit()
        MainMenu_Panel.ResumeLayout(False)
        MainMenu_Panel.PerformLayout()
        Screen_Panel.ResumeLayout(False)
        Home_Panel.ResumeLayout(False)
        About_Panel.ResumeLayout(False)
        About_Panel.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Account_Panel.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents Logo_Pic As PictureBox
    Friend WithEvents Home_BTN As LinkLabel
    Friend WithEvents About_BTN As LinkLabel
    Friend WithEvents MyAcc_BTN As LinkLabel
    Friend WithEvents Logout_BTN As LinkLabel
    Friend WithEvents SchoolName_Lbl As Label
    Friend WithEvents MainMenu_Panel As Panel
    Friend WithEvents Screen_Panel As Panel
    Friend WithEvents Home_Panel As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents About_Panel As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Account_Panel As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
End Class
