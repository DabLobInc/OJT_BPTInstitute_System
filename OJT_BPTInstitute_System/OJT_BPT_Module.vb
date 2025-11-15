Imports MySql.Data.MySqlClient
Module OJT_BPT_Module
    Public connString As String = "Server=localhost;Database=ojtdb_bptinstitute;Uid=root;"
End Module

Module PanelManager
    Public Sub ShowPanel(parentContainer As Panel, panelName As String)
        For Each ctrl As Control In parentContainer.Controls
            If TypeOf ctrl Is Panel Then
                ctrl.Visible = False

                If ctrl.Name.Equals(panelName, StringComparison.OrdinalIgnoreCase) Then
                    ctrl.Visible = True
                    ctrl.BringToFront()
                End If
            End If
        Next
    End Sub

    Public Sub InitializePanels(parentContainer As Panel)
        ShowPanel(parentContainer, "Home_Panel")
    End Sub
End Module