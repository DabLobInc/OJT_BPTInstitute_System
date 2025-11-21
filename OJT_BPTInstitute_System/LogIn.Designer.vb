<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LogIn_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LogIn_Form))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Name_Input = New TextBox()
        Pass_Input = New TextBox()
        ShowPass_BTN = New CheckBox()
        Login_BTN = New Button()
        Exit_BTN = New Button()
        Label4 = New Label()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Navy
        Label1.Location = New Point(-1, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(561, 119)
        Label1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(45, 153)
        Label2.Name = "Label2"
        Label2.Size = New Size(103, 28)
        Label2.TabIndex = 1
        Label2.Text = "Username:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.Location = New Point(45, 231)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 28)
        Label3.TabIndex = 2
        Label3.Text = "Password:"
        ' 
        ' Name_Input
        ' 
        Name_Input.Location = New Point(45, 184)
        Name_Input.Name = "Name_Input"
        Name_Input.Size = New Size(467, 27)
        Name_Input.TabIndex = 3
        ' 
        ' Pass_Input
        ' 
        Pass_Input.Location = New Point(45, 262)
        Pass_Input.Name = "Pass_Input"
        Pass_Input.Size = New Size(467, 27)
        Pass_Input.TabIndex = 4
        Pass_Input.UseSystemPasswordChar = True
        ' 
        ' ShowPass_BTN
        ' 
        ShowPass_BTN.AutoSize = True
        ShowPass_BTN.Location = New Point(45, 295)
        ShowPass_BTN.Name = "ShowPass_BTN"
        ShowPass_BTN.Size = New Size(134, 24)
        ShowPass_BTN.TabIndex = 5
        ShowPass_BTN.Text = "Show password"
        ShowPass_BTN.UseVisualStyleBackColor = True
        ' 
        ' Login_BTN
        ' 
        Login_BTN.Location = New Point(303, 333)
        Login_BTN.Name = "Login_BTN"
        Login_BTN.Size = New Size(94, 36)
        Login_BTN.TabIndex = 6
        Login_BTN.Text = "Log In"
        Login_BTN.UseVisualStyleBackColor = True
        ' 
        ' Exit_BTN
        ' 
        Exit_BTN.Location = New Point(418, 333)
        Exit_BTN.Name = "Exit_BTN"
        Exit_BTN.Size = New Size(94, 36)
        Exit_BTN.TabIndex = 7
        Exit_BTN.Text = "Exit"
        Exit_BTN.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.BackColor = Color.Navy
        Label4.Font = New Font("Stencil", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Goldenrod
        Label4.Location = New Point(155, 25)
        Label4.Name = "Label4"
        Label4.Size = New Size(357, 73)
        Label4.TabIndex = 8
        Label4.Text = "Bright Path " & vbCrLf & "Technical Institute"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Navy
        PictureBox1.BackgroundImageLayout = ImageLayout.Center
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(21, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(111, 94)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' LogIn_Form
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(560, 397)
        Controls.Add(PictureBox1)
        Controls.Add(Label4)
        Controls.Add(Exit_BTN)
        Controls.Add(Login_BTN)
        Controls.Add(ShowPass_BTN)
        Controls.Add(Pass_Input)
        Controls.Add(Name_Input)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "LogIn_Form"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Log In"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Name_Input As TextBox
    Friend WithEvents Pass_Input As TextBox
    Friend WithEvents ShowPass_BTN As CheckBox
    Friend WithEvents Login_BTN As Button
    Friend WithEvents Exit_BTN As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox

End Class
