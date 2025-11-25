Imports System.Text
Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient
Module OJT_BPT_Module
    Public connString As String = "Server=localhost;Database=ojtdb_bptinstitute;Uid=root;"
End Module

Module PanelManager

    ' Name of the panel to never hide
    Private Const MainMenuName As String = "MainMenu_Panel"
    Private Const LogOutName As String = "Logout_Panel"

    Public Sub ShowPanel(root As Panel, targetName As String)

        ' 1. Find the target panel
        Dim targetPanel As Panel = FindPanel(root, targetName)
        If targetPanel Is Nothing Then Exit Sub

        ' 2. Hide all panels EXCEPT MainMenu_Panel
        HideAllPanels(root)

        ' 3. Ensure MainMenu_Panel is always visible
        Dim mainMenu = FindPanel(root, MainMenuName)
        If mainMenu IsNot Nothing Then ShowPanelAndChildren(mainMenu)

        Dim logout = FindPanel(root, LogOutName)
        If logout IsNot Nothing Then ShowPanelAndChildren(logout)

        ' 4. Show the target panel and all its parent panels
        Dim cur As Control = targetPanel
        While cur IsNot Nothing AndAlso TypeOf cur Is Panel
            ShowPanelAndChildren(DirectCast(cur, Panel))
            cur = cur.Parent
        End While

        ' 5. Bring the selected panel to front
        targetPanel.BringToFront()

    End Sub

    '==================== HELPERS =========================

    ' Recursively hide all panels and controls, skipping MainMenu_Panel
    Private Sub HideAllPanels(container As Control)
        For Each ctrl As Control In container.Controls

            ' Skip MainMenu_Panel
            If TypeOf ctrl Is Panel AndAlso (ctrl.Name = MainMenuName OrElse ctrl.Name = LogOutName) Then
                Continue For
            End If

            ctrl.Visible = False

            If TypeOf ctrl Is Panel Then
                HideAllPanels(ctrl) ' recursive
            End If
        Next
    End Sub

    ' Recursively show a panel and all its child controls
    Private Sub ShowPanelAndChildren(panel As Panel)
        panel.Visible = True
        For Each ctrl As Control In panel.Controls
            ctrl.Visible = True
            If TypeOf ctrl Is Panel Then
                ShowPanelAndChildren(DirectCast(ctrl, Panel))
            End If
        Next
    End Sub

    ' Recursively find a panel by name
    Private Function FindPanel(container As Control, name As String) As Panel
        For Each ctrl As Control In container.Controls
            If TypeOf ctrl Is Panel Then
                If ctrl.Name.Equals(name, StringComparison.OrdinalIgnoreCase) Then
                    Return DirectCast(ctrl, Panel)
                End If

                Dim result As Panel = FindPanel(ctrl, name)
                If result IsNot Nothing Then Return result
            End If
        Next
        Return Nothing
    End Function

End Module

Module SecurityModule

    ' Function to hash a password using SHA-256
    Public Function HashPassword(password As String) As String
        Using sha256 As SHA256 = sha256.Create()
            Dim bytes() As Byte = Encoding.UTF8.GetBytes(password)
            Dim hash() As Byte = sha256.ComputeHash(bytes)
            Dim sb As New StringBuilder()
            For Each b As Byte In hash
                sb.Append(b.ToString("x2")) ' converts to lowercase hex
            Next
            Return sb.ToString()
        End Using
    End Function

End Module


