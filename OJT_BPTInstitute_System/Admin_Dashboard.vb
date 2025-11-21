Public Class Admin_Dashboard
    Private Sub Admin_Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        DrawPanelBorder(SideFunction_Panel, Color.White, 10)
    End Sub
    Private Sub Home_BTN_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        ShowPanel(Screen_Panel, "Home_Panel")
    End Sub

    Private Sub Profile_BTN_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        ShowPanel(Screen_Panel, "Functions_Panel")
    End Sub

    Private Sub DrawPanelBorder(ByVal pnl As Panel, ByVal borderColor As Color, ByVal borderWidth As Integer)
        AddHandler pnl.Paint, Sub(sender As Object, e As PaintEventArgs)
                                  Dim pen As New Pen(borderColor, borderWidth)
                                  e.Graphics.DrawRectangle(pen, 0, 0, pnl.Width - 1, pnl.Height - 1)
                              End Sub
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