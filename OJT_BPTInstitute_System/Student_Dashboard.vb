Public Class Student_Dashboard
    Private Sub Student_Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Logout_BTN_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Logout_BTN.LinkClicked
        Dim result As DialogResult = MessageBox.Show("Do you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Hide()
            LogIn_Form.Show()
            LogIn_Form.Name_Input.Clear()
            LogIn_Form.Pass_Input.Clear()
        End If
    End Sub

    Private Sub Home_BTN_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Home_BTN.LinkClicked
        ShowPanel(Screen_Panel, "Home_Panel")
    End Sub

    Private Sub Profile_BTN_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Profile_BTN.LinkClicked
        ShowPanel(Screen_Panel, "Profile_Panel")
    End Sub

    Private Sub Section_BTN_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Internship_BTN.LinkClicked
        ShowPanel(Screen_Panel, "Internship_Panel")
    End Sub


    'try push
End Class