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

        ' 1. Find the target
        Dim target As Panel = FindPanel(root, targetName)
        If target Is Nothing Then Exit Sub

        ' 2. Hide ONLY direct child panels of root EXCEPT MainMenu & Logout
        For Each ctrl As Control In root.Controls
            If TypeOf ctrl Is Panel Then
                If ctrl.Name <> MainMenuName Then
                    ctrl.Visible = False
                End If
            End If
        Next

        ' 3. Show target and all parent panels
        Dim cur As Control = target
        While cur IsNot Nothing AndAlso TypeOf cur Is Panel
            cur.Visible = True
            cur = cur.Parent
        End While

        ' 4. Bring target to front
        target.BringToFront()

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
    Public Function FindPanel(container As Control, name As String) As Panel
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

Module UIButtons

    Public Sub RoundedButtons(parent As Control, Optional radius As Integer = 20)

        For Each ctrl As Control In parent.Controls

            If TypeOf ctrl Is Button Then
                Dim btn As Button = DirectCast(ctrl, Button)
                ApplyRoundedRegion(btn, radius)

                AddHandler btn.Resize, Sub() ApplyRoundedRegion(btn, radius)
            End If

            If ctrl.HasChildren Then
                RoundedButtons(ctrl, radius)
            End If

        Next
    End Sub

    Private Sub ApplyRoundedRegion(btn As Button, radius As Integer)
        Dim path As New Drawing.Drawing2D.GraphicsPath()
        Dim r As Integer = radius * 2

        path.AddArc(0, 0, r, r, 180, 90)
        path.AddArc(btn.Width - r, 0, r, r, 270, 90)
        path.AddArc(btn.Width - r, btn.Height - r, r, r, 0, 90)
        path.AddArc(0, btn.Height - r, r, r, 90, 90)
        path.CloseFigure()

        btn.Region = New Region(path)
    End Sub

End Module


