Public Class Student_Dashboard
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

    Private Sub MyAcc_BTN_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles MyAcc_BTN.LinkClicked
        ShowPanel(Screen_Panel, "Account_Panel")
    End Sub

    Private Sub About_BTN_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles About_BTN.LinkClicked
        ShowPanel(Screen_Panel, "About_Panel")
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub
End Class