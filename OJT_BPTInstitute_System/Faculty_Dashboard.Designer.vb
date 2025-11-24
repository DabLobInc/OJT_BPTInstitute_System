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
        Logo_Pic = New PictureBox()
        Home_BTN = New LinkLabel()
        Section_BTN = New LinkLabel()
        Profile_BTN = New LinkLabel()
        Logout_BTN = New LinkLabel()
        SchoolName_Lbl = New Label()
        MainMenu_Panel = New Panel()
        SchoolTitle_Panel = New Panel()
        Function_Panel = New Panel()
        Screen_Panel = New Panel()
        Home_Panel = New Panel()
        Label3 = New Label()
        Section_Panel = New Panel()
        Label2 = New Label()
        Profile_Panel = New Panel()
        Label1 = New Label()
        CType(Logo_Pic, ComponentModel.ISupportInitialize).BeginInit()
        MainMenu_Panel.SuspendLayout()
        SchoolTitle_Panel.SuspendLayout()
        Function_Panel.SuspendLayout()
        Screen_Panel.SuspendLayout()
        Home_Panel.SuspendLayout()
        Section_Panel.SuspendLayout()
        Profile_Panel.SuspendLayout()
        SuspendLayout()
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
        ' Home_BTN
        ' 
        Home_BTN.ActiveLinkColor = Color.Goldenrod
        Home_BTN.BackColor = Color.Navy
        Home_BTN.Font = New Font("Arial Rounded MT Bold", 16.2F)
        Home_BTN.LinkColor = Color.White
        Home_BTN.Location = New Point(22, 0)
        Home_BTN.Name = "Home_BTN"
        Home_BTN.Size = New Size(143, 149)
        Home_BTN.TabIndex = 0
        Home_BTN.TabStop = True
        Home_BTN.Text = "HOME"
        Home_BTN.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Section_BTN
        ' 
        Section_BTN.ActiveLinkColor = Color.Goldenrod
        Section_BTN.BackColor = Color.Navy
        Section_BTN.Font = New Font("Arial Rounded MT Bold", 16.2F)
        Section_BTN.LinkColor = Color.White
        Section_BTN.Location = New Point(304, 0)
        Section_BTN.Name = "Section_BTN"
        Section_BTN.Size = New Size(143, 149)
        Section_BTN.TabIndex = 6
        Section_BTN.TabStop = True
        Section_BTN.Text = "SECTION"
        Section_BTN.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Profile_BTN
        ' 
        Profile_BTN.ActiveLinkColor = Color.Goldenrod
        Profile_BTN.BackColor = Color.Navy
        Profile_BTN.Font = New Font("Arial Rounded MT Bold", 16.2F)
        Profile_BTN.LinkColor = Color.White
        Profile_BTN.Location = New Point(155, 0)
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
        Logout_BTN.Location = New Point(453, 0)
        Logout_BTN.Name = "Logout_BTN"
        Logout_BTN.Size = New Size(143, 149)
        Logout_BTN.TabIndex = 9
        Logout_BTN.TabStop = True
        Logout_BTN.Text = "LOGOUT"
        Logout_BTN.TextAlign = ContentAlignment.BottomCenter
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
        ' MainMenu_Panel
        ' 
        MainMenu_Panel.BackColor = Color.Navy
        MainMenu_Panel.Controls.Add(SchoolTitle_Panel)
        MainMenu_Panel.Controls.Add(Function_Panel)
        MainMenu_Panel.Dock = DockStyle.Top
        MainMenu_Panel.Location = New Point(0, 0)
        MainMenu_Panel.Name = "MainMenu_Panel"
        MainMenu_Panel.Size = New Size(1902, 187)
        MainMenu_Panel.TabIndex = 11
        ' 
        ' SchoolTitle_Panel
        ' 
        SchoolTitle_Panel.Controls.Add(Logo_Pic)
        SchoolTitle_Panel.Controls.Add(SchoolName_Lbl)
        SchoolTitle_Panel.Dock = DockStyle.Left
        SchoolTitle_Panel.Location = New Point(0, 0)
        SchoolTitle_Panel.Name = "SchoolTitle_Panel"
        SchoolTitle_Panel.Size = New Size(713, 187)
        SchoolTitle_Panel.TabIndex = 12
        ' 
        ' Function_Panel
        ' 
        Function_Panel.Anchor = AnchorStyles.Right
        Function_Panel.Controls.Add(Home_BTN)
        Function_Panel.Controls.Add(Profile_BTN)
        Function_Panel.Controls.Add(Logout_BTN)
        Function_Panel.Controls.Add(Section_BTN)
        Function_Panel.Location = New Point(1231, 0)
        Function_Panel.Name = "Function_Panel"
        Function_Panel.Size = New Size(671, 187)
        Function_Panel.TabIndex = 11
        ' 
        ' Screen_Panel
        ' 
        Screen_Panel.BackColor = SystemColors.Control
        Screen_Panel.Controls.Add(Home_Panel)
        Screen_Panel.Controls.Add(Section_Panel)
        Screen_Panel.Controls.Add(Profile_Panel)
        Screen_Panel.Dock = DockStyle.Fill
        Screen_Panel.Location = New Point(0, 0)
        Screen_Panel.Name = "Screen_Panel"
        Screen_Panel.Size = New Size(1902, 1055)
        Screen_Panel.TabIndex = 12
        ' 
        ' Home_Panel
        ' 
        Home_Panel.Controls.Add(Label3)
        Home_Panel.Dock = DockStyle.Fill
        Home_Panel.Location = New Point(0, 0)
        Home_Panel.Name = "Home_Panel"
        Home_Panel.Size = New Size(1902, 1055)
        Home_Panel.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(687, 389)
        Label3.Name = "Label3"
        Label3.Size = New Size(80, 20)
        Label3.TabIndex = 0
        Label3.Text = "Home Test"
        ' 
        ' Section_Panel
        ' 
        Section_Panel.Controls.Add(Label2)
        Section_Panel.Dock = DockStyle.Fill
        Section_Panel.Location = New Point(0, 0)
        Section_Panel.Name = "Section_Panel"
        Section_Panel.Size = New Size(1902, 1055)
        Section_Panel.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(597, 342)
        Label2.Name = "Label2"
        Label2.Size = New Size(88, 20)
        Label2.TabIndex = 0
        Label2.Text = "Section Test"
        ' 
        ' Profile_Panel
        ' 
        Profile_Panel.Controls.Add(Label1)
        Profile_Panel.Dock = DockStyle.Fill
        Profile_Panel.Location = New Point(0, 0)
        Profile_Panel.Name = "Profile_Panel"
        Profile_Panel.Size = New Size(1902, 1055)
        Profile_Panel.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(465, 356)
        Label1.Name = "Label1"
        Label1.Size = New Size(80, 20)
        Label1.TabIndex = 0
        Label1.Text = "Profile test"
        ' 
        ' Faculty_Dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(1902, 1055)
        Controls.Add(MainMenu_Panel)
        Controls.Add(Screen_Panel)
        Name = "Faculty_Dashboard"
        Text = "Faculty"
        WindowState = FormWindowState.Maximized
        CType(Logo_Pic, ComponentModel.ISupportInitialize).EndInit()
        MainMenu_Panel.ResumeLayout(False)
        SchoolTitle_Panel.ResumeLayout(False)
        Function_Panel.ResumeLayout(False)
        Screen_Panel.ResumeLayout(False)
        Home_Panel.ResumeLayout(False)
        Home_Panel.PerformLayout()
        Section_Panel.ResumeLayout(False)
        Section_Panel.PerformLayout()
        Profile_Panel.ResumeLayout(False)
        Profile_Panel.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Logo_Pic As PictureBox
    Friend WithEvents Home_BTN As LinkLabel
    Friend WithEvents Section_BTN As LinkLabel
    Friend WithEvents Profile_BTN As LinkLabel
    Friend WithEvents Logout_BTN As LinkLabel
    Friend WithEvents SchoolName_Lbl As Label
    Friend WithEvents MainMenu_Panel As Panel
    Friend WithEvents Function_Panel As Panel
    Friend WithEvents Screen_Panel As Panel
    Friend WithEvents SchoolTitle_Panel As Panel
    Friend WithEvents Home_Panel As Panel
    Friend WithEvents Section_Panel As Panel
    Friend WithEvents Profile_Panel As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
End Class
