<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Account_Form
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
        Logo_Pic = New PictureBox()
        Back_BTN = New LinkLabel()
        SchoolName_Lbl = New Label()
        Screen_Panel = New Panel()
        Add_Panel = New Panel()
        Edit_Panel = New Panel()
        Search_Panel = New Panel()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        MainMenu_Panel.SuspendLayout()
        CType(Logo_Pic, ComponentModel.ISupportInitialize).BeginInit()
        Screen_Panel.SuspendLayout()
        Add_Panel.SuspendLayout()
        Edit_Panel.SuspendLayout()
        Search_Panel.SuspendLayout()
        SuspendLayout()
        ' 
        ' MainMenu_Panel
        ' 
        MainMenu_Panel.BackColor = Color.Navy
        MainMenu_Panel.Controls.Add(Logo_Pic)
        MainMenu_Panel.Controls.Add(Back_BTN)
        MainMenu_Panel.Controls.Add(SchoolName_Lbl)
        MainMenu_Panel.Location = New Point(0, 0)
        MainMenu_Panel.Name = "MainMenu_Panel"
        MainMenu_Panel.Size = New Size(800, 106)
        MainMenu_Panel.TabIndex = 12
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
        ' Back_BTN
        ' 
        Back_BTN.ActiveLinkColor = Color.Goldenrod
        Back_BTN.AutoSize = True
        Back_BTN.BackColor = Color.Navy
        Back_BTN.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Back_BTN.LinkColor = Color.White
        Back_BTN.Location = New Point(718, 56)
        Back_BTN.Name = "Back_BTN"
        Back_BTN.Size = New Size(44, 23)
        Back_BTN.TabIndex = 9
        Back_BTN.TabStop = True
        Back_BTN.Text = "EXIT"
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
        ' Screen_Panel
        ' 
        Screen_Panel.Controls.Add(Add_Panel)
        Screen_Panel.Controls.Add(Edit_Panel)
        Screen_Panel.Controls.Add(Search_Panel)
        Screen_Panel.Location = New Point(0, 107)
        Screen_Panel.Name = "Screen_Panel"
        Screen_Panel.Size = New Size(800, 344)
        Screen_Panel.TabIndex = 13
        ' 
        ' Add_Panel
        ' 
        Add_Panel.Controls.Add(Label3)
        Add_Panel.Location = New Point(0, 0)
        Add_Panel.Name = "Add_Panel"
        Add_Panel.Size = New Size(800, 344)
        Add_Panel.TabIndex = 0
        ' 
        ' Edit_Panel
        ' 
        Edit_Panel.Controls.Add(Label2)
        Edit_Panel.Location = New Point(0, 0)
        Edit_Panel.Name = "Edit_Panel"
        Edit_Panel.Size = New Size(800, 344)
        Edit_Panel.TabIndex = 1
        ' 
        ' Search_Panel
        ' 
        Search_Panel.Controls.Add(Label1)
        Search_Panel.Location = New Point(0, 0)
        Search_Panel.Name = "Search_Panel"
        Search_Panel.Size = New Size(800, 344)
        Search_Panel.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(262, 115)
        Label1.Name = "Label1"
        Label1.Size = New Size(83, 20)
        Label1.TabIndex = 0
        Label1.Text = "Search Test"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(207, 98)
        Label2.Name = "Label2"
        Label2.Size = New Size(65, 20)
        Label2.TabIndex = 0
        Label2.Text = "Edit Test"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(228, 95)
        Label3.Name = "Label3"
        Label3.Size = New Size(67, 20)
        Label3.TabIndex = 0
        Label3.Text = "Add Test"
        ' 
        ' Account_Form
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(MainMenu_Panel)
        Controls.Add(Screen_Panel)
        Name = "Account_Form"
        Text = "Account"
        MainMenu_Panel.ResumeLayout(False)
        MainMenu_Panel.PerformLayout()
        CType(Logo_Pic, ComponentModel.ISupportInitialize).EndInit()
        Screen_Panel.ResumeLayout(False)
        Add_Panel.ResumeLayout(False)
        Add_Panel.PerformLayout()
        Edit_Panel.ResumeLayout(False)
        Edit_Panel.PerformLayout()
        Search_Panel.ResumeLayout(False)
        Search_Panel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents MainMenu_Panel As Panel
    Friend WithEvents Logo_Pic As PictureBox
    Friend WithEvents Back_BTN As LinkLabel
    Friend WithEvents SchoolName_Lbl As Label
    Friend WithEvents Screen_Panel As Panel
    Friend WithEvents Edit_Panel As Panel
    Friend WithEvents Add_Panel As Panel
    Friend WithEvents Search_Panel As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
