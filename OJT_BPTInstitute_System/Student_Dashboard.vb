Imports System.Collections.Specialized.BitVector32
Imports System.Net.Http.Headers
Imports System.Net.Mail
Imports MySql.Data.MySqlClient
Imports Windows.Win32.System

Public Class Student_Dashboard
    Private Sub Student_Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        LoadHomePanel()
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

    Private Sub StudLoadProfile()

    End Sub

    Private Sub Home_BTN_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Home_BTN.LinkClicked
        ShowPanel(Screen_Panel, "Home_Panel")
        LoadHomePanel()
    End Sub

    Private Sub Profile_BTN_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Profile_BTN.LinkClicked
        ShowPanel(Screen_Panel, "Profile_Panel")
        LoadStudentProfile()
    End Sub
    Private Sub Internship_BTN_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Internship_BTN.LinkClicked
        ShowPanel(Screen_Panel, "Internship_Panel")
        LoadInternshipProfile()
        LoadInternshipCombos()
    End Sub

    Private Sub LoadHomePanel()
        Using con As New MySqlConnection(connString)
            Try
                Dim user = LogIn_Form.LoggedInUser
                con.Open()

                ' --- Student Name ---
                Dim nameQuery As String = "
                SELECT StudLName, StudFName, StudMName, StudSName
                FROM students 
                WHERE StudentID = @id LIMIT 1
            "
                Using cmd As New MySqlCommand(nameQuery, con)
                    cmd.Parameters.AddWithValue("@id", user)
                    Using reader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim lastName = reader("StudLName").ToString().ToUpper()
                            Dim firstName = reader("StudFName").ToString().ToUpper()
                            Dim mid = reader("StudMName").ToString()
                            Dim middleInitial = If(mid.Length > 0, mid.Substring(0, 1), "")
                            Dim suffixName = reader("StudSName").ToString().ToUpper()

                            Stud_User_lbl.Text = $"{lastName}, {firstName} {middleInitial}. {suffixName}"
                        End If
                    End Using
                End Using

                ' --- Company ---
                Dim compQuery As String = "
                SELECT c.CompanyName, c.CompanyAddress
                FROM company c
                JOIN internship i ON i.CompanyID = c.CompanyID
                WHERE i.StudentID = @id LIMIT 1
            "
                Using cmd As New MySqlCommand(compQuery, con)
                    cmd.Parameters.AddWithValue("@id", user)
                    Using reader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Assigned_Placeholder_lbl.Text =
                                reader("CompanyName").ToString() & " - " & reader("CompanyAddress").ToString()
                        End If
                    End Using
                End Using

                ' --- Supervisor ---
                Dim supQuery As String = "
                SELECT v.SupervisorName
                FROM supervisors v
                JOIN internship i ON i.SupervisorID = v.SupervisorID
                WHERE i.StudentID = @id LIMIT 1
            "
                Using cmd As New MySqlCommand(supQuery, con)
                    cmd.Parameters.AddWithValue("@id", user)
                    Using reader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Supervised_Placeholder_lbl.Text = reader("SupervisorName").ToString()
                        End If
                    End Using
                End Using

                ' --- Faculty ---
                Dim facQuery As String = "
                SELECT f.FacultyName
                FROM faculty f
                JOIN internship i ON i.FacultyID = f.FacultyID
                WHERE i.StudentID = @id LIMIT 1
            "
                Using cmd As New MySqlCommand(facQuery, con)
                    cmd.Parameters.AddWithValue("@id", user)
                    Using reader = cmd.ExecuteReader()
                        If reader.Read() Then
                            FacEval_Placeholder_lbl.Text = reader("FacultyName").ToString()
                        End If
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Public Sub LoadStudentProfile()
        Using con As New MySqlConnection(connString)
            Try
                con.Open()
                Dim user As String = LogIn_Form.LoggedInUser

                Dim studInfo As String = "
                SELECT s.StudentID, s.StudLName, s.StudFName, s.StudMName, s.StudSName,
                       s.StudEmail, s.StudContNo, s.DepartmentID, s.StudSection,
                       s.StudYrLvl, s.ProgramID, p.ProgramName
                FROM students s
                JOIN programs p ON s.ProgramID = p.ProgramID
                WHERE s.StudentID = @id LIMIT 1
            "

                Using cmd As New MySqlCommand(studInfo, con)
                    cmd.Parameters.AddWithValue("@id", user)

                    Using reader = cmd.ExecuteReader()
                        If reader.Read() Then

                            Dim cont = reader("StudContNo").ToString()
                            If cont.StartsWith("0") Then cont = "+63" & cont.Substring(1)

                            Stud_FName_txt.Text = reader("StudFName").ToString()
                            Stud_MName_txt.Text = reader("StudMName").ToString()
                            Stud_LName_txt.Text = reader("StudLName").ToString()
                            Stud_Suffix_txt.Text = reader("StudSName").ToString()
                            Stud_StudentID_Mtxt.Text = reader("StudentID").ToString()
                            Stud_StudEmailAdd_txt.Text = reader("StudEmail").ToString()
                            Stud_StudDeptID_Mtxt.Text = reader("DepartmentID").ToString()
                            Stud_StudProgramID_Mtxt.Text = reader("ProgramID").ToString()
                            Stud_StudProgramName_txt.Text = reader("ProgramName").ToString()

                            Stud_StudSection_txt.Text =
                            reader("StudYrLvl").ToString() & "-" &
                            reader("StudSection").ToString()

                            Stud_StudContNum_Mtxt.Text = cont

                        End If
                    End Using
                End Using

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Using
    End Sub

    Private Sub LoadInternshipProfile()
        Using con As New MySqlConnection(connString)
            Try
                con.Open()
                Dim user As String = LogIn_Form.LoggedInUser

                Dim query As String = "
                SELECT 
                    i.InternID, i.StartDate, i.EndDate, i.SchoolYr,
                    i.FacultyID, f.FacultyName,
                    i.SupervisorID, v.SupervisorName,
                    i.CompanyID, c.CompanyName, c.CompanyAddress
                FROM internship i
                JOIN students s ON i.StudentID = s.StudentID
                JOIN faculty f ON f.FacultyID = i.FacultyID
                JOIN supervisors v ON v.SupervisorID = i.SupervisorID
                JOIN company c ON c.CompanyID = i.CompanyID
                WHERE s.StudentID = @id
                LIMIT 1
            "

                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@id", user)

                    Using reader = cmd.ExecuteReader()
                        If reader.Read() Then

                            Stud_InternID_Mtxt.Text = reader("InternID").ToString()
                            Stud_InternSDate_txt.Text = Convert.ToDateTime(reader("StartDate")).ToShortDateString()
                            Stud_InternEDate_txt.Text = Convert.ToDateTime(reader("EndDate")).ToShortDateString()
                            Stud_InternSY_txt.Text = reader("SchoolYr").ToString()

                            Stud_InternFacID_Mtxt.Text = reader("FacultyID").ToString()
                            Stud_InternFacEvalName_txt.Text = reader("FacultyName").ToString()

                            Stud_SupervisorID_Mtxt.Text = reader("SupervisorID").ToString()
                            Stud_SupervisorName_txt.Text = reader("SupervisorName").ToString()

                            Stud_InternCompID_Mtxt.Text = reader("CompanyID").ToString()
                            Stud_InternCompName_txt.Text = reader("CompanyName").ToString()
                            Stud_InternCompAdd_txt.Text = reader("CompanyAddress").ToString()

                        End If
                    End Using
                End Using

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Using

    End Sub

    Private Sub LoadInternshipCombos()
        Using con As New MySqlConnection(connString)
            Try
                con.Open()

                ' --- Load Semester ComboBox ---
                Dim dtSemester As New DataTable
                Dim daSemester As New MySqlDataAdapter("SELECT StudentID, StudSem FROM students", con)
                daSemester.Fill(dtSemester)

                Stud_InternSemester_cmb.DataSource = dtSemester
                Stud_InternSemester_cmb.DisplayMember = "StudSem"
                Stud_InternSemester_cmb.ValueMember = "StudentID"

                ' --- Load Internship Status ComboBox ---
                Dim dtStatus As New DataTable
                Dim daStatus As New MySqlDataAdapter("SELECT InternID, Status FROM internship", con)
                daStatus.Fill(dtStatus)

                Stud_InternStatus_cmb.DataSource = dtStatus
                Stud_InternStatus_cmb.DisplayMember = "Status"
                Stud_InternStatus_cmb.ValueMember = "InternID"

            Catch ex As Exception
                MessageBox.Show("Error loading combos: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Stud_ChangePass_btn_Click(sender As Object, e As EventArgs) Handles Stud_ChangePass_btn.Click
        Me.TopMost = False
        Dim f As New Update_Account
        ShowPanel(f.Update_Panel, "ChangePass_Container_pnl")

        f.ShowDialog()
        Me.TopMost = True
    End Sub

    Private Sub Stud_UpdateProfile_btn_Click(sender As Object, e As EventArgs) Handles Stud_UpdateProfile_btn.Click
        Me.TopMost = False
        Dim f As New Update_Account
        ShowPanel(f.Update_Panel, "Update_Profile_pnl")

        f.ShowDialog()
        Me.TopMost = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Stud_DateTimeNow_lbl.Text = DateTime.Now.ToString("MMMM dd, yyyy // hh:mm:ss tt").ToUpper()
    End Sub
End Class