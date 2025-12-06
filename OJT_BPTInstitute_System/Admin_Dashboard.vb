Imports MySql.Data.MySqlClient

Public Class Admin_Dashboard
    Private Sub Admin_Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        DrawPanelBorder(DashSide_INNER, Color.White, 10)

        Dashboard_Panel.Show()
        Stud_Eval_Panel.Show()
        Function_Panel.Hide()

        Faculty_Dashboard.StyleDGV(SE_DGV)
        Faculty_Dashboard.StyleDGV(VL_DGV)
        Faculty_Dashboard.StyleDGV(FE_DGV)
        Faculty_Dashboard.StyleDGV(SR_DGV)
        Faculty_Dashboard.StyleDGV(PC_DGV)

        Faculty_Dashboard.StyleDGV(STUD_DGV)
        Faculty_Dashboard.StyleDGV(FAC_DGV)
        Faculty_Dashboard.StyleDGV(Adm_Intern_DGV)
        Faculty_Dashboard.StyleDGV(Adm_Sup_DGV)
        Faculty_Dashboard.StyleDGV(Adm_Comp_DGV)
        Faculty_Dashboard.StyleDGV(Adm_Course_DGV)
        Faculty_Dashboard.StyleDGV(Adm_Dept_DGV)

        LoadEvaluations()
    End Sub

    Private Sub Dashboard_BTN_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Dashboard_BTN.LinkClicked
        ShowPanel(Screen_Panel, "Content_Panel")
        Dashboard_Panel.Show()
        Function_Panel.Hide()


        SE_BackPan.BackColor = Color.White
        SR_BackPan.BackColor = Color.Orange
        PC_BackPan.BackColor = Color.Orange
        FE_BackPan.BackColor = Color.Orange
        VL_BackPan.BackColor = Color.Orange

        SE_LinkLbl.LinkColor = Color.Black
        SR_LinkLbl.LinkColor = Color.White
        PC_LinkLbl.LinkColor = Color.White
        FE_LinkLbl.LinkColor = Color.White
        VL_LinkLbl.LinkColor = Color.White

        SE_LinkLbl.BackColor = Color.White
        SR_LinkLbl.BackColor = Color.Orange
        PC_LinkLbl.BackColor = Color.Orange
        FE_LinkLbl.BackColor = Color.Orange
        VL_LinkLbl.BackColor = Color.Orange

        Stud_Eval_Panel.Show()
        Stud_Regis_Panel.Hide()
        Partner_Comp_Panel.Hide()
        Fac_Eval_Panel.Hide()
        Visit_LogPanel.Hide()
    End Sub

    Private Sub DrawPanelBorder(ByVal pnl As Panel, ByVal borderColor As Color, ByVal borderWidth As Integer)
        AddHandler pnl.Paint, Sub(sender As Object, e As PaintEventArgs)
                                  Dim pen As New Pen(borderColor, borderWidth)
                                  e.Graphics.DrawRectangle(pen, 0, 0, pnl.Width - 1, pnl.Height - 1)
                              End Sub
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim ts As String = DateTime.Now.ToString("MMMM dd, yyyy '//' hh:mm:ss ")
        Dim ampm As String = DateTime.Now.ToString("tt").ToUpper()

        SEval_DateTime.Text = ts & ampm
        SRegis_DateTime.Text = ts & ampm
        PComp_DateTime.Text = ts & ampm
        FEval_DateTime.Text = ts & ampm

    End Sub

    Private Sub Logout_BTN_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Logout_BTN.LinkClicked
        Dim result = MessageBox.Show("Do you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Hide()
            LogIn_Form.ShowPass_BTN.Checked = False
            LogIn_Form.Show()
            LogIn_Form.Name_Input.Clear()
            LogIn_Form.Pass_Input.Clear()
        End If
    End Sub

    Private Sub Functions_BTN_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Functions_BTN.LinkClicked
        Dashboard_Panel.Hide()
        Function_Panel.Show()

        RoundedButtons(Me, 25)

        DrawPanelBorder(FuncSidePanel_INNER, Color.White, 10)
    End Sub

    Private Sub SE_LinkLbl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles SE_LinkLbl.LinkClicked

        SE_BackPan.BackColor = Color.White
        SR_BackPan.BackColor = Color.Orange
        PC_BackPan.BackColor = Color.Orange
        FE_BackPan.BackColor = Color.Orange
        VL_BackPan.BackColor = Color.Orange

        SE_LinkLbl.LinkColor = Color.Black
        SR_LinkLbl.LinkColor = Color.White
        PC_LinkLbl.LinkColor = Color.White
        FE_LinkLbl.LinkColor = Color.White
        VL_LinkLbl.LinkColor = Color.White

        SE_LinkLbl.BackColor = Color.White
        SR_LinkLbl.BackColor = Color.Orange
        PC_LinkLbl.BackColor = Color.Orange
        FE_LinkLbl.BackColor = Color.Orange
        VL_LinkLbl.BackColor = Color.Orange

        Stud_Eval_Panel.Show()
        Stud_Regis_Panel.Hide()
        Partner_Comp_Panel.Hide()
        Fac_Eval_Panel.Hide()
        Visit_LogPanel.Hide()
    End Sub

    Private Sub SR_LinkLbl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles SR_LinkLbl.LinkClicked

        SE_BackPan.BackColor = Color.Orange
        SR_BackPan.BackColor = Color.White
        PC_BackPan.BackColor = Color.Orange
        FE_BackPan.BackColor = Color.Orange
        VL_BackPan.BackColor = Color.Orange

        SE_LinkLbl.LinkColor = Color.White
        SR_LinkLbl.LinkColor = Color.Black
        PC_LinkLbl.LinkColor = Color.White
        FE_LinkLbl.LinkColor = Color.White
        VL_LinkLbl.LinkColor = Color.White

        SE_LinkLbl.BackColor = Color.Orange
        SR_LinkLbl.BackColor = Color.White
        PC_LinkLbl.BackColor = Color.Orange
        FE_LinkLbl.BackColor = Color.Orange
        VL_LinkLbl.BackColor = Color.Orange

        Stud_Eval_Panel.Hide()
        Stud_Regis_Panel.Show()
        Partner_Comp_Panel.Hide()
        Fac_Eval_Panel.Hide()
        Visit_LogPanel.Hide()
    End Sub

    Private Sub PC_LinkLbl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles PC_LinkLbl.LinkClicked

        SE_BackPan.BackColor = Color.Orange
        SR_BackPan.BackColor = Color.Orange
        PC_BackPan.BackColor = Color.White
        FE_BackPan.BackColor = Color.Orange
        VL_BackPan.BackColor = Color.Orange

        SE_LinkLbl.LinkColor = Color.White
        SR_LinkLbl.LinkColor = Color.White
        PC_LinkLbl.LinkColor = Color.Black
        FE_LinkLbl.LinkColor = Color.White
        VL_LinkLbl.LinkColor = Color.White

        SE_LinkLbl.BackColor = Color.Orange
        SR_LinkLbl.BackColor = Color.Orange
        PC_LinkLbl.BackColor = Color.White
        FE_LinkLbl.BackColor = Color.Orange
        VL_LinkLbl.BackColor = Color.Orange

        Stud_Eval_Panel.Hide()
        Stud_Regis_Panel.Hide()
        Partner_Comp_Panel.Show()
        Fac_Eval_Panel.Hide()
        Visit_LogPanel.Hide()
    End Sub

    Private Sub FE_LinkLbl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles FE_LinkLbl.LinkClicked

        SE_BackPan.BackColor = Color.Orange
        SR_BackPan.BackColor = Color.Orange
        PC_BackPan.BackColor = Color.Orange
        FE_BackPan.BackColor = Color.White
        VL_BackPan.BackColor = Color.Orange

        SE_LinkLbl.LinkColor = Color.White
        SR_LinkLbl.LinkColor = Color.White
        PC_LinkLbl.LinkColor = Color.White
        FE_LinkLbl.LinkColor = Color.Black
        VL_LinkLbl.LinkColor = Color.White

        SE_LinkLbl.BackColor = Color.Orange
        SR_LinkLbl.BackColor = Color.Orange
        PC_LinkLbl.BackColor = Color.Orange
        FE_LinkLbl.BackColor = Color.White
        VL_LinkLbl.BackColor = Color.Orange

        Stud_Eval_Panel.Hide()
        Stud_Regis_Panel.Hide()
        Partner_Comp_Panel.Hide()
        Fac_Eval_Panel.Show()
        Visit_LogPanel.Hide()
    End Sub

    Private Sub VL_LinkLbl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles VL_LinkLbl.LinkClicked

        SE_BackPan.BackColor = Color.Orange
        SR_BackPan.BackColor = Color.Orange
        PC_BackPan.BackColor = Color.Orange
        FE_BackPan.BackColor = Color.Orange
        VL_BackPan.BackColor = Color.White

        SE_LinkLbl.LinkColor = Color.White
        SR_LinkLbl.LinkColor = Color.White
        PC_LinkLbl.LinkColor = Color.White
        FE_LinkLbl.LinkColor = Color.White
        VL_LinkLbl.LinkColor = Color.Black

        SE_LinkLbl.BackColor = Color.Orange
        SR_LinkLbl.BackColor = Color.Orange
        PC_LinkLbl.BackColor = Color.Orange
        FE_LinkLbl.BackColor = Color.Orange
        VL_LinkLbl.BackColor = Color.White

        Stud_Eval_Panel.Hide()
        Stud_Regis_Panel.Hide()
        Partner_Comp_Panel.Hide()
        Fac_Eval_Panel.Hide()
        Visit_LogPanel.Show()

    End Sub

    Private Sub FuncStudLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles FuncStudLink.LinkClicked

        FuncStudPnl.BackColor = Color.White
        FuncFacPnl.BackColor = Color.Orange
        FuncDepPnl.BackColor = Color.Orange
        FuncCoursePnl.BackColor = Color.Orange
        FuncComPnl.BackColor = Color.Orange
        FuncSupPnl.BackColor = Color.Orange
        FuncIntPnl.BackColor = Color.Orange

        FuncStudLink.LinkColor = Color.Black
        FuncFacLink.LinkColor = Color.White
        FuncDepLink.LinkColor = Color.White
        FuncCourseLink.LinkColor = Color.White
        FuncComLink.LinkColor = Color.White
        FuncSupLink.LinkColor = Color.White
        FuncIntLink.LinkColor = Color.White

        FuncStudLink.BackColor = Color.White
        FuncFacLink.BackColor = Color.Orange
        FuncDepLink.BackColor = Color.Orange
        FuncCourseLink.BackColor = Color.Orange
        FuncComLink.BackColor = Color.Orange
        FuncSupLink.BackColor = Color.Orange
        FuncIntLink.BackColor = Color.Orange

        ADM_STUDPAN.Show()
        ADM_FACPAN.Hide()
        ADM_DEPTPAN.Hide()
        ADM_COURSEPAN.Hide()
        ADM_COMPAN.Hide()
        ADM_SUPERPAN.Hide()
        ADM_INTERPAN.Hide()
    End Sub

    Private Sub FuncFacLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles FuncFacLink.LinkClicked
        FuncStudPnl.BackColor = Color.Orange
        FuncFacPnl.BackColor = Color.White
        FuncDepPnl.BackColor = Color.Orange
        FuncCoursePnl.BackColor = Color.Orange
        FuncComPnl.BackColor = Color.Orange
        FuncSupPnl.BackColor = Color.Orange
        FuncIntPnl.BackColor = Color.Orange

        FuncStudLink.LinkColor = Color.White
        FuncFacLink.LinkColor = Color.Black
        FuncDepLink.LinkColor = Color.White
        FuncCourseLink.LinkColor = Color.White
        FuncComLink.LinkColor = Color.White
        FuncSupLink.LinkColor = Color.White
        FuncIntLink.LinkColor = Color.White

        FuncStudLink.BackColor = Color.Orange
        FuncFacLink.BackColor = Color.White
        FuncDepLink.BackColor = Color.Orange
        FuncCourseLink.BackColor = Color.Orange
        FuncComLink.BackColor = Color.Orange
        FuncSupLink.BackColor = Color.Orange
        FuncIntLink.BackColor = Color.Orange

        ADM_STUDPAN.Hide()
        ADM_FACPAN.Show()
        ADM_DEPTPAN.Hide()
        ADM_COURSEPAN.Hide()
        ADM_COMPAN.Hide()
        ADM_SUPERPAN.Hide()
        ADM_INTERPAN.Hide()
    End Sub

    Private Sub FuncDepLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles FuncDepLink.LinkClicked
        FuncStudPnl.BackColor = Color.Orange
        FuncFacPnl.BackColor = Color.Orange
        FuncDepPnl.BackColor = Color.White
        FuncCoursePnl.BackColor = Color.Orange
        FuncComPnl.BackColor = Color.Orange
        FuncSupPnl.BackColor = Color.Orange
        FuncIntPnl.BackColor = Color.Orange

        FuncStudLink.LinkColor = Color.White
        FuncFacLink.LinkColor = Color.White
        FuncDepLink.LinkColor = Color.Black
        FuncCourseLink.LinkColor = Color.White
        FuncComLink.LinkColor = Color.White
        FuncSupLink.LinkColor = Color.White
        FuncIntLink.LinkColor = Color.White

        FuncStudLink.BackColor = Color.Orange
        FuncFacLink.BackColor = Color.Orange
        FuncDepLink.BackColor = Color.White
        FuncCourseLink.BackColor = Color.Orange
        FuncComLink.BackColor = Color.Orange
        FuncSupLink.BackColor = Color.Orange
        FuncIntLink.BackColor = Color.Orange

        ADM_STUDPAN.Hide()
        ADM_FACPAN.Hide()
        ADM_DEPTPAN.Show()
        ADM_COURSEPAN.Hide()
        ADM_COMPAN.Hide()
        ADM_SUPERPAN.Hide()
        ADM_INTERPAN.Hide()
    End Sub

    Private Sub FuncCourseLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles FuncCourseLink.LinkClicked
        FuncStudPnl.BackColor = Color.Orange
        FuncFacPnl.BackColor = Color.Orange
        FuncDepPnl.BackColor = Color.Orange
        FuncCoursePnl.BackColor = Color.White
        FuncComPnl.BackColor = Color.Orange
        FuncSupPnl.BackColor = Color.Orange
        FuncIntPnl.BackColor = Color.Orange

        FuncStudLink.LinkColor = Color.White
        FuncFacLink.LinkColor = Color.White
        FuncDepLink.LinkColor = Color.White
        FuncCourseLink.LinkColor = Color.Black
        FuncComLink.LinkColor = Color.White
        FuncSupLink.LinkColor = Color.White
        FuncIntLink.LinkColor = Color.White

        FuncStudLink.BackColor = Color.Orange
        FuncFacLink.BackColor = Color.Orange
        FuncDepLink.BackColor = Color.Orange
        FuncCourseLink.BackColor = Color.White
        FuncComLink.BackColor = Color.Orange
        FuncSupLink.BackColor = Color.Orange
        FuncIntLink.BackColor = Color.Orange

        ADM_STUDPAN.Hide()
        ADM_FACPAN.Hide()
        ADM_DEPTPAN.Hide()
        ADM_COURSEPAN.Show()
        ADM_COMPAN.Hide()
        ADM_SUPERPAN.Hide()
        ADM_INTERPAN.Hide()
    End Sub

    Private Sub FuncComLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles FuncComLink.LinkClicked
        FuncStudPnl.BackColor = Color.Orange
        FuncFacPnl.BackColor = Color.Orange
        FuncDepPnl.BackColor = Color.Orange
        FuncCoursePnl.BackColor = Color.Orange
        FuncComPnl.BackColor = Color.White
        FuncSupPnl.BackColor = Color.Orange
        FuncIntPnl.BackColor = Color.Orange

        FuncStudLink.LinkColor = Color.White
        FuncFacLink.LinkColor = Color.White
        FuncDepLink.LinkColor = Color.White
        FuncCourseLink.LinkColor = Color.White
        FuncComLink.LinkColor = Color.Black
        FuncSupLink.LinkColor = Color.White
        FuncIntLink.LinkColor = Color.White

        FuncStudLink.BackColor = Color.Orange
        FuncFacLink.BackColor = Color.Orange
        FuncDepLink.BackColor = Color.Orange
        FuncCourseLink.BackColor = Color.Orange
        FuncComLink.BackColor = Color.White
        FuncSupLink.BackColor = Color.Orange
        FuncIntLink.BackColor = Color.Orange

        ADM_STUDPAN.Hide()
        ADM_FACPAN.Hide()
        ADM_DEPTPAN.Hide()
        ADM_COURSEPAN.Hide()
        ADM_COMPAN.Show()
        ADM_SUPERPAN.Hide()
        ADM_INTERPAN.Hide()
    End Sub

    Private Sub FuncSupLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles FuncSupLink.LinkClicked
        FuncStudPnl.BackColor = Color.Orange
        FuncFacPnl.BackColor = Color.Orange
        FuncDepPnl.BackColor = Color.Orange
        FuncCoursePnl.BackColor = Color.Orange
        FuncComPnl.BackColor = Color.Orange
        FuncSupPnl.BackColor = Color.White
        FuncIntPnl.BackColor = Color.Orange

        FuncStudLink.LinkColor = Color.White
        FuncFacLink.LinkColor = Color.White
        FuncDepLink.LinkColor = Color.White
        FuncCourseLink.LinkColor = Color.White
        FuncComLink.LinkColor = Color.White
        FuncSupLink.LinkColor = Color.Black
        FuncIntLink.LinkColor = Color.White

        FuncStudLink.BackColor = Color.Orange
        FuncFacLink.BackColor = Color.Orange
        FuncDepLink.BackColor = Color.Orange
        FuncCourseLink.BackColor = Color.Orange
        FuncComLink.BackColor = Color.Orange
        FuncSupLink.BackColor = Color.White
        FuncIntLink.BackColor = Color.Orange

        ADM_STUDPAN.Hide()
        ADM_FACPAN.Hide()
        ADM_DEPTPAN.Hide()
        ADM_COURSEPAN.Hide()
        ADM_COMPAN.Hide()
        ADM_SUPERPAN.Show()
        ADM_INTERPAN.Hide()
    End Sub

    Private Sub FuncIntLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles FuncIntLink.LinkClicked
        FuncStudPnl.BackColor = Color.Orange
        FuncFacPnl.BackColor = Color.Orange
        FuncDepPnl.BackColor = Color.Orange
        FuncCoursePnl.BackColor = Color.Orange
        FuncComPnl.BackColor = Color.Orange
        FuncSupPnl.BackColor = Color.Orange
        FuncIntPnl.BackColor = Color.White

        FuncStudLink.LinkColor = Color.White
        FuncFacLink.LinkColor = Color.White
        FuncDepLink.LinkColor = Color.White
        FuncCourseLink.LinkColor = Color.White
        FuncComLink.LinkColor = Color.White
        FuncSupLink.LinkColor = Color.White
        FuncIntLink.LinkColor = Color.Black

        FuncStudLink.BackColor = Color.Orange
        FuncFacLink.BackColor = Color.Orange
        FuncDepLink.BackColor = Color.Orange
        FuncCourseLink.BackColor = Color.Orange
        FuncComLink.BackColor = Color.Orange
        FuncSupLink.BackColor = Color.Orange
        FuncIntLink.BackColor = Color.White

        ADM_STUDPAN.Hide()
        ADM_FACPAN.Hide()
        ADM_DEPTPAN.Hide()
        ADM_COURSEPAN.Hide()
        ADM_COMPAN.Hide()
        ADM_SUPERPAN.Hide()
        ADM_INTERPAN.Show()
    End Sub

    Public Sub LoadEvaluations()
        Using con As New MySqlConnection(connString)
            Try
                con.Open()

                Dim evalQuery As String = "
                    SELECT i.InternID,
                    CONCAT(s.StudLName, ', ', s.StudFName, ' ',
                    CASE WHEN s.StudMName IS NULL OR s.StudMName = '' 
                    THEN '' ELSE CONCAT(LEFT(s.StudMName, 1), '.') END) AS StudentName,
                            p.ProgramName,
                            s.StudSection,
                            c.CompanyName,
                            sup.SupervisorName,
                            CONCAT(f.FacLName, ', ', f.FacFName, ' ', f.FacMName) AS FacultyEvaluator,
                            i.Status
                    FROM internship i
                    JOIN students s ON s.StudentID = i.StudentID
                    JOIN programs p ON p.ProgramID = s.ProgramID
                    JOIN company c ON c.CompanyID = i.CompanyID
                    JOIN supervisors sup ON sup.SupervisorID = i.SupervisorID
                    JOIN faculty f ON f.FacultyID = i.FacultyID
                    "

                Using cmd As New MySqlCommand(evalQuery, con)

                    Using da As New MySqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        da.Fill(dt)

                        ' Prevent automatic generation of columns
                        SE_DGV.AutoGenerateColumns = False

                        ' Map DataTable columns to existing DGV columns
                        SE_DGV_IntID.DataPropertyName = "InternID"
                        SE_DGV_StudName.DataPropertyName = "StudentName"
                        SE_DGV_Course.DataPropertyName = "ProgramName"
                        SE_DGV_Section.DataPropertyName = "StudSection"
                        SE_DGV_CompName.DataPropertyName = "CompanyName"
                        SE_DGV_SVisor.DataPropertyName = "SupervisorName"
                        SE_DGV_FacEval.DataPropertyName = "FacultyEvaluator"
                        SE_DGV_Stat.DataPropertyName = "Status"

                        ' Bind DataTable to DGV
                        SE_DGV.DataSource = dt
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    'tugay

End Class
