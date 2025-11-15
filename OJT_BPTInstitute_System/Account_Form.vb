Public Class Account_Form
    Private Sub Back_BTN_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Back_BTN.LinkClicked
        If MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNo, "EXIT") = vbYes Then
            Me.Close()
        End If
    End Sub

    Public Property Mode As String = "Add"

    Private Sub Account_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case Mode.ToLower()
            Case "add"
                ShowPanel(Screen_Panel, "Add_Panel")

            Case "edit"
                ShowPanel(Screen_Panel, "Edit_Panel")

            Case "search"
                ShowPanel(Screen_Panel, "Search_Panel")

            Case "delete"
                ShowPanel(Screen_Panel, "Delete_Panel")
        End Select
        Me.Text = Mode & " Account"
    End Sub
    'jAS
    'mea
    'paging-ging


End Class