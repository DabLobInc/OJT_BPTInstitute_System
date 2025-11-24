Imports MySql.Data.MySqlClient
Public Class Faculty_Dashboard
    Private Sub Logout_BTN_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Logout_BTN.LinkClicked
        Dim result = MessageBox.Show("Do you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Hide()
            LogIn_Form.Show()
            LogIn_Form.Name_Input.Clear()
            LogIn_Form.Pass_Input.Clear()
        End If
    End Sub

    Private Sub Home_Linklbl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Home_Linklbl.LinkClicked
        ShowPanel(Screen_Panel, "Home_Panel")
    End Sub

    Private Sub Profile_Linklbl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Profile_Linklbl.LinkClicked
        ShowPanel(Screen_Panel, "Profile_Panel")
    End Sub

    Private Sub Section_Linklbl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Section_Linklbl.LinkClicked
        ShowPanel(Screen_Panel, "Section_Panel")
    End Sub

    Private Sub Faculty_Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim ts As String = DateTime.Now.ToString("MMMM dd, yyyy '//' hh:mm:ss ")
        Dim ampm As String = DateTime.Now.ToString("tt").ToUpper()

        Faculty_DateTime.Text = ts & ampm
    End Sub

End Class