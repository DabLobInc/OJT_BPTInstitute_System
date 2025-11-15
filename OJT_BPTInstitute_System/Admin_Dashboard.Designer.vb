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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin_Dashboard))
        Logo_Pic = New PictureBox()
        Home_BTN = New LinkLabel()
        About_BTN = New LinkLabel()
        Logout_BTN = New LinkLabel()
        SchoolName_Lbl = New Label()
        MainMenu_Panel = New Panel()
        Screen_Panel = New Panel()
        Home_Panel = New Panel()
        Label1 = New Label()
        TextBox1 = New TextBox()
        Button4 = New Button()
        Button3 = New Button()
        AddAcc_BTN = New Button()
        About_Panel = New Panel()
        Label6 = New Label()
        Label5 = New Label()
        PictureBox2 = New PictureBox()
        DataGridView1 = New DataGridView()
        CType(Logo_Pic, ComponentModel.ISupportInitialize).BeginInit()
        MainMenu_Panel.SuspendLayout()
        Screen_Panel.SuspendLayout()
        Home_Panel.SuspendLayout()
        About_Panel.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
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
        Home_BTN.Location = New Point(582, 56)
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
        MainMenu_Panel.Controls.Add(Logout_BTN)
        MainMenu_Panel.Controls.Add(SchoolName_Lbl)
        MainMenu_Panel.Location = New Point(2, -1)
        MainMenu_Panel.Name = "MainMenu_Panel"
        MainMenu_Panel.Size = New Size(853, 106)
        MainMenu_Panel.TabIndex = 13
        ' 
        ' Screen_Panel
        ' 
        Screen_Panel.Controls.Add(Home_Panel)
        Screen_Panel.Controls.Add(About_Panel)
        Screen_Panel.Location = New Point(2, 105)
        Screen_Panel.Name = "Screen_Panel"
        Screen_Panel.Size = New Size(850, 425)
        Screen_Panel.TabIndex = 14
        ' 
        ' Home_Panel
        ' 
        Home_Panel.Controls.Add(DataGridView1)
        Home_Panel.Controls.Add(Label1)
        Home_Panel.Controls.Add(TextBox1)
        Home_Panel.Controls.Add(Button4)
        Home_Panel.Controls.Add(Button3)
        Home_Panel.Controls.Add(AddAcc_BTN)
        Home_Panel.Location = New Point(0, 0)
        Home_Panel.Name = "Home_Panel"
        Home_Panel.Size = New Size(856, 427)
        Home_Panel.TabIndex = 12
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.ForeColor = SystemColors.ControlDarkDark
        Label1.Location = New Point(434, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(104, 20)
        Label1.TabIndex = 9
        Label1.Text = "Username / ID"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(550, 6)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(176, 27)
        TextBox1.TabIndex = 8
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(13, 363)
        Button4.Name = "Button4"
        Button4.Size = New Size(176, 47)
        Button4.TabIndex = 7
        Button4.Text = "DELETE"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(732, 6)
        Button3.Name = "Button3"
        Button3.Size = New Size(106, 27)
        Button3.TabIndex = 6
        Button3.Text = "SEARCH"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' AddAcc_BTN
        ' 
        AddAcc_BTN.Location = New Point(13, 39)
        AddAcc_BTN.Name = "AddAcc_BTN"
        AddAcc_BTN.Size = New Size(176, 47)
        AddAcc_BTN.TabIndex = 4
        AddAcc_BTN.Text = "ADD NEW ACCOUNT"
        AddAcc_BTN.UseVisualStyleBackColor = True
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
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(195, 39)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(644, 371)
        DataGridView1.TabIndex = 10
        ' 
        ' Admin_Dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(852, 527)
        Controls.Add(MainMenu_Panel)
        Controls.Add(Screen_Panel)
        Name = "Admin_Dashboard"
        Text = "Admin"
        CType(Logo_Pic, ComponentModel.ISupportInitialize).EndInit()
        MainMenu_Panel.ResumeLayout(False)
        MainMenu_Panel.PerformLayout()
        Screen_Panel.ResumeLayout(False)
        Home_Panel.ResumeLayout(False)
        Home_Panel.PerformLayout()
        About_Panel.ResumeLayout(False)
        About_Panel.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Logo_Pic As PictureBox
    Friend WithEvents Home_BTN As LinkLabel
    Friend WithEvents About_BTN As LinkLabel
    Friend WithEvents Logout_BTN As LinkLabel
    Friend WithEvents SchoolName_Lbl As Label
    Friend WithEvents MainMenu_Panel As Panel
    Friend WithEvents Screen_Panel As Panel
    Friend WithEvents Home_Panel As Panel
    Friend WithEvents About_Panel As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents AddAcc_BTN As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
