Public Class Admin_Dashboard
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

    Private Sub About_BTN_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles About_BTN.LinkClicked
        ShowPanel(Screen_Panel, "About_Panel")
    End Sub

    Private Sub AddAcc_BTN_Click(sender As Object, e As EventArgs) Handles AddAcc_BTN.Click
        Dim f As New Account_Form
        f.Mode = "Add"
        f.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim f As New Account_Form
        f.Mode = "Edit"
        f.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim f As New Account_Form
        f.Mode = "Search"
        f.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim f As New Account_Form
        f.Mode = "Delete"
        f.ShowDialog()
    End Sub
End Class