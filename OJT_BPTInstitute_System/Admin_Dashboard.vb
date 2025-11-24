Public Class Admin_Dashboard
    Private Sub Admin_Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        DrawPanelBorder(SideFunction_Panel, Color.White, 10)
    End Sub

    Private Sub Dashboard_BTN_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Dashboard_BTN.LinkClicked
        ShowPanel(Screen_Panel, "Content_Panel")

        Adm_Sel1_Panel.BackColor = Color.White
        Adm_Sel2_Panel.BackColor = Color.Orange
        Adm_Sel3_Panel.BackColor = Color.Orange
        Adm_Sel4_Panel.BackColor = Color.Orange

        Student_Eval_LinkLbl.LinkColor = Color.Black
        Stud_Regis_Linklbl.LinkColor = Color.White
        Partner_Comp_Linklbl.LinkColor = Color.White
        Fac_Eval_Linklbl.LinkColor = Color.White

        Student_Eval_LinkLbl.BackColor = Color.White
        Stud_Regis_Linklbl.BackColor = Color.Orange
        Partner_Comp_Linklbl.BackColor = Color.Orange
        Fac_Eval_Linklbl.BackColor = Color.Orange

        Stud_Eval_Panel.Show()
        Stud_Regis_Panel.Hide()
        Partner_Comp_Panel.Hide()
        Fac_Eval_Panel.Hide()
    End Sub

    Private Sub FunctionOperation_BTN_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles FunctionOperation_BTN.LinkClicked
        ShowPanel(Screen_Panel, "Functions_Panel")
    End Sub

    Private Sub DrawPanelBorder(ByVal pnl As Panel, ByVal borderColor As Color, ByVal borderWidth As Integer)
        AddHandler pnl.Paint, Sub(sender As Object, e As PaintEventArgs)
                                  Dim pen As New Pen(borderColor, borderWidth)
                                  e.Graphics.DrawRectangle(pen, 0, 0, pnl.Width - 1, pnl.Height - 1)
                              End Sub
    End Sub

    Private Sub Student_Eval_LinkLbl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Student_Eval_LinkLbl.LinkClicked
        Adm_Sel1_Panel.BackColor = Color.White
        Adm_Sel2_Panel.BackColor = Color.Orange
        Adm_Sel3_Panel.BackColor = Color.Orange
        Adm_Sel4_Panel.BackColor = Color.Orange

        Student_Eval_LinkLbl.LinkColor = Color.Black
        Stud_Regis_Linklbl.LinkColor = Color.White
        Partner_Comp_Linklbl.LinkColor = Color.White
        Fac_Eval_Linklbl.LinkColor = Color.White

        Student_Eval_LinkLbl.BackColor = Color.White
        Stud_Regis_Linklbl.BackColor = Color.Orange
        Partner_Comp_Linklbl.BackColor = Color.Orange
        Fac_Eval_Linklbl.BackColor = Color.Orange

        Stud_Eval_Panel.Show()
        Stud_Regis_Panel.Hide()
        Partner_Comp_Panel.Hide()
        Fac_Eval_Panel.Hide()
    End Sub

    Private Sub Stud_Regis_Linklbl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Stud_Regis_Linklbl.LinkClicked
        Adm_Sel1_Panel.BackColor = Color.Orange
        Adm_Sel2_Panel.BackColor = Color.White
        Adm_Sel3_Panel.BackColor = Color.Orange
        Adm_Sel4_Panel.BackColor = Color.Orange

        Student_Eval_LinkLbl.LinkColor = Color.White
        Stud_Regis_Linklbl.LinkColor = Color.Black
        Partner_Comp_Linklbl.LinkColor = Color.White
        Fac_Eval_Linklbl.LinkColor = Color.White

        Student_Eval_LinkLbl.BackColor = Color.Orange
        Stud_Regis_Linklbl.BackColor = Color.White
        Partner_Comp_Linklbl.BackColor = Color.Orange
        Fac_Eval_Linklbl.BackColor = Color.Orange

        Stud_Eval_Panel.Hide()
        Stud_Regis_Panel.Show()
        Partner_Comp_Panel.Hide()
        Fac_Eval_Panel.Hide()
    End Sub

    Private Sub Partner_Comp_Linklbl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Partner_Comp_Linklbl.LinkClicked
        Adm_Sel1_Panel.BackColor = Color.Orange
        Adm_Sel2_Panel.BackColor = Color.Orange
        Adm_Sel3_Panel.BackColor = Color.White
        Adm_Sel4_Panel.BackColor = Color.Orange

        Student_Eval_LinkLbl.LinkColor = Color.White
        Stud_Regis_Linklbl.LinkColor = Color.White
        Partner_Comp_Linklbl.LinkColor = Color.Black
        Fac_Eval_Linklbl.LinkColor = Color.White

        Student_Eval_LinkLbl.BackColor = Color.Orange
        Stud_Regis_Linklbl.BackColor = Color.Orange
        Partner_Comp_Linklbl.BackColor = Color.White
        Fac_Eval_Linklbl.BackColor = Color.Orange

        Stud_Eval_Panel.Hide()
        Stud_Regis_Panel.Hide()
        Partner_Comp_Panel.Show()
        Fac_Eval_Panel.Hide()
    End Sub

    Private Sub Fac_Eval_Linklbl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Fac_Eval_Linklbl.LinkClicked
        Adm_Sel1_Panel.BackColor = Color.Orange
        Adm_Sel2_Panel.BackColor = Color.Orange
        Adm_Sel3_Panel.BackColor = Color.Orange
        Adm_Sel4_Panel.BackColor = Color.White

        Student_Eval_LinkLbl.LinkColor = Color.White
        Stud_Regis_Linklbl.LinkColor = Color.White
        Partner_Comp_Linklbl.LinkColor = Color.White
        Fac_Eval_Linklbl.LinkColor = Color.Black

        Student_Eval_LinkLbl.BackColor = Color.Orange
        Stud_Regis_Linklbl.BackColor = Color.Orange
        Partner_Comp_Linklbl.BackColor = Color.Orange
        Fac_Eval_Linklbl.BackColor = Color.White

        Stud_Eval_Panel.Hide()
        Stud_Regis_Panel.Hide()
        Partner_Comp_Panel.Hide()
        Fac_Eval_Panel.Show()
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
            LogIn_Form.Show()
            LogIn_Form.Name_Input.Clear()
            LogIn_Form.Pass_Input.Clear()
        End If
    End Sub

End Class
