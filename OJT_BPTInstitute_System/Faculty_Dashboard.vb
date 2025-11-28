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
        LoadFacultyInfo()
    End Sub

    Private Sub Profile_Linklbl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Profile_Linklbl.LinkClicked
        ShowPanel(Screen_Panel, "Profile_Panel")
        LoadFacultyProfile()
    End Sub

    Private Sub Section_Linklbl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Section_Linklbl.LinkClicked
        ShowPanel(Screen_Panel, "Section_Panel")
    End Sub

    Private Sub Faculty_Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        LoadFacultyInfo()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim ts As String = DateTime.Now.ToString("MMMM dd, yyyy '//' hh:mm:ss ")
        Dim ampm As String = DateTime.Now.ToString("tt").ToUpper()

        Fac_DateTimeNow.Text = ts & ampm
    End Sub
    Public Sub LoadFacultyInfo()
        Using con As New MySqlConnection(connString)
            Try
                Dim user = LogIn_Form.LoggedInUser

                con.Open()

                ' Query to fetch faculty info
                Dim homefacQuery As String = "
                SELECT f.FacLName, f.FacFName, f.FacMName, f.Emp_Status, 
                       f.Position, d.Department_description
                FROM faculty f
                JOIN departments d ON d.DepartmentID = f.DepartmentID
                WHERE FacultyID = @id LIMIT 1
            "

                Using cmdN As New MySqlCommand(homefacQuery, con)
                    cmdN.Parameters.AddWithValue("@id", user)

                    Using reader As MySqlDataReader = cmdN.ExecuteReader()
                        If reader.Read() Then
                            Dim mid As String = reader("FacMName").ToString()
                            Dim middleInitial As String
                            If mid.Length > 0 Then
                                middleInitial = mid.Substring(0, 1) & "."
                            Else
                                middleInitial = ""
                            End If
                            'Dim middleInitial As String = If(mid.Length > 0, mid.Substring(0, 1), "")

                            Dim lastName As String = reader("FacLName").ToString().ToUpper()
                            Dim firstName As String = reader("FacFName").ToString().ToUpper()
                            Dim empStatus As String = reader("Emp_Status").ToString()
                            Dim pos As String = reader("Position").ToString()
                            Dim deptN As String = reader("Department_description").ToString()

                            ' Setting labels with retrieved data
                            Fac_User_lbl.Text = $"{lastName}, {firstName} {middleInitial}"
                            Status_Position_lbl.Text = $"{empStatus} - {pos}"
                            Department_lbl.Text = deptN
                        Else
                            MessageBox.Show("No record found for the faculty.")
                        End If
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub
    Private Sub LoadFacultyProfile()
        Try
            Dim user As String = LogIn_Form.LoggedInUser

            Using con As New MySqlConnection(connString)
                con.Open()

                Dim facultyQuery As String = "
                SELECT f.FacultyID, f.FacFName, f.FacLName, f.FacMName, 
                       f.FacultyEmail, f.FacultyContNo, f.DepartmentID, f.Emp_Status,
                       f.Position, d.Department_description
                FROM faculty f
                JOIN departments d ON d.DepartmentID = f.DepartmentID
                WHERE f.FacultyID = @id LIMIT 1
            "

                Using cmdS As New MySqlCommand(facultyQuery, con)
                    cmdS.Parameters.AddWithValue("@id", user)

                    Using reader As MySqlDataReader = cmdS.ExecuteReader()
                        If reader.Read() Then
                            Dim contNum As String = reader("FacultyContNo").ToString()

                            ' Format the contact number
                            If contNum.StartsWith("0") Then
                                contNum = "+63" & contNum.Substring(1)
                            End If

                            ' Set the values in the textboxes
                            Faculty_FName_txt.Text = reader("FacFName").ToString()
                            Faculty_MName_txt.Text = reader("FacMName").ToString()
                            Faculty_LName_txt.Text = reader("FacLName").ToString()
                            Faculty_FacID_Mtxt.Text = reader("FacultyID").ToString()
                            Faculty_FacEmail_txt.Text = reader("FacultyEmail").ToString()
                            Faculty_FacDeptID_Mtxt.Text = reader("DepartmentID").ToString()
                            Faculty_FacDepartment_txt.Text = reader("Department_description").ToString()
                            Faculty_FacEmpStat_txt.Text = reader("Emp_Status").ToString()
                            Faculty_FacPosition_txt.Text = reader("Position").ToString()
                            Faculty_FacConNum_Mtxt.Text = contNum
                        Else
                            MessageBox.Show("No record found for the faculty.")
                        End If
                    End Using
                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Faculty_FacCPass_btn_Click(sender As Object, e As EventArgs) Handles Faculty_FacCPass_btn.Click
        Me.TopMost = False
        Dim f As New Update_Account
        ShowPanel(f.Update_Panel, "Fac_ChangePassContainer_pnl")

        f.ShowDialog()
        Me.TopMost = True
    End Sub

    Private Sub Faculty_FacUpd_btn_Click(sender As Object, e As EventArgs) Handles Faculty_FacUpd_btn.Click
        Me.TopMost = False
        Dim f As New Update_Account
        ShowPanel(f.Update_Panel, "Fac_Update_Profile_pnl")

        f.ShowDialog()
        Me.TopMost = True
    End Sub
End Class