Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class Update_Account
    Dim user As String = LogIn_Form.LoggedInUser
    Private _targetPanel As String = Nothing

    Dim firstClick As Boolean = False
    Dim emailPattern As String = "^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$"

    Public Sub New(targetPanel As String)
        InitializeComponent()
        _targetPanel = targetPanel
    End Sub

    Private Sub Update_Account_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ShowPanel(Me.Update_Panel, _targetPanel)
    End Sub

    Private Sub Update_Account_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Using con As New MySqlConnection(connString)
                con.Open()
                Dim usertype = "SELECT UserType FROM users WHERE Username = @id"

                Using cmdt As New MySqlCommand(usertype, con)
                    cmdt.Parameters.AddWithValue("@id", user)

                    Using reader = cmdt.ExecuteReader()
                        If reader.Read() Then
                            Select Case reader("UserType")
                                Case "Student"
                                    LoadStudentProfile()
                                Case "Faculty"
                                    LoadFacultyProfile()
                            End Select
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ' Show/Hide Passwords based on checkbox
    Private Sub ChangePass_Showpass_cb_CheckedChanged(sender As Object, e As EventArgs) Handles ChangePass_Showpass_cb.CheckedChanged
        If ChangePass_Showpass_cb.Checked Then
            ChangePass_OldPass_txt.PasswordChar = ""
            ChangePass_NewPass_txt.PasswordChar = ""
            ChangePass_Conpass_txt.PasswordChar = ""
        Else
            ChangePass_OldPass_txt.PasswordChar = "*"
            ChangePass_NewPass_txt.PasswordChar = "*"
            ChangePass_Conpass_txt.PasswordChar = "*"
        End If
    End Sub
    Private Sub Fac_ChangePass_ShowPass_cb_CheckedChanged(sender As Object, e As EventArgs) Handles Fac_ChangePass_ShowPass_cb.CheckedChanged
        If Fac_ChangePass_ShowPass_cb.Checked Then
            Fac_ChangePass_OldPass_txt.PasswordChar = ""
            Fac_ChangePass_NewPass_txt.PasswordChar = ""
            Fac_ChangePass_ConPass_txt.PasswordChar = ""
        Else
            Fac_ChangePass_OldPass_txt.PasswordChar = "*"
            Fac_ChangePass_NewPass_txt.PasswordChar = "*"
            Fac_ChangePass_ConPass_txt.PasswordChar = "*"
        End If
    End Sub

    Private Sub ChangePass_Save_btn_Click(sender As Object, e As EventArgs) Handles ChangePass_Save_btn.Click
        Dim newPasswordRaw As String = ChangePass_NewPass_txt.Text.Trim
        Dim conPasswordRaw As String = ChangePass_Conpass_txt.Text.Trim

        ' Check empty
        If String.IsNullOrWhiteSpace(newPasswordRaw) OrElse String.IsNullOrWhiteSpace(conPasswordRaw) Then
            MsgBox("Password fields cannot be empty!", MsgBoxStyle.Exclamation, "Invalid")
            Return
        End If

        ' Check mismatch
        If newPasswordRaw <> conPasswordRaw Then
            MsgBox("New password and confirm password doesn't match!", MsgBoxStyle.Exclamation, "Invalid")
            Return
        End If

        ' Hash ONLY after validation
        Dim oldPassword As String = HashPassword(ChangePass_OldPass_txt.Text.Trim)
        Dim newPassword As String = HashPassword(newPasswordRaw)
        Dim conPassword As String = HashPassword(conPasswordRaw)

        Try
            Using con As New MySqlConnection(connString)
                con.Open()

                ' Check the old password against the stored password hash
                Dim oPassQuery = "SELECT PasswordHash FROM users WHERE Username = @id"
                Using cmdC As New MySqlCommand(oPassQuery, con)
                    cmdC.Parameters.AddWithValue("@id", user)
                    Using reader = cmdC.ExecuteReader
                        If reader.Read Then
                            If oldPassword <> reader("PasswordHash") Then
                                MsgBox("Incorrect old password!", MsgBoxStyle.Exclamation, "Invalid!")
                                Return
                            End If
                        End If
                    End Using
                End Using

                ' Confirm password change
                If MsgBox("Are you sure you want to change your password?", MsgBoxStyle.YesNo, "Validation") = vbYes Then
                    Dim cPassQuery = "UPDATE users SET PasswordHash = @password WHERE Username = @id"

                    Using cmdCP As New MySqlCommand(cPassQuery, con)
                        cmdCP.Parameters.AddWithValue("@password", newPassword)
                        cmdCP.Parameters.AddWithValue("@id", user)

                        ' Execute query
                        cmdCP.ExecuteNonQuery()
                    End Using

                    MsgBox("Password changed successfully!", MsgBoxStyle.OkOnly, "Success!")
                    ChangePass_OldPass_txt.Text = ""
                    ChangePass_NewPass_txt.Text = ""
                    ChangePass_Conpass_txt.Text = ""
                    Close()
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ' Cancel button action
    Private Sub ChangePass_Cancel_btn_Click(sender As Object, e As EventArgs) Handles ChangePass_Cancel_btn.Click
        If MsgBox("Are you sure you want to cancel?", MsgBoxStyle.YesNo, "Confirmation") = vbYes Then
            Close()
        End If
    End Sub

    ' Load student profile information
    Private Sub LoadStudentProfile()
        Using con As New MySqlConnection(connString)
            Try
                con.Open()
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

                            ' Fill form fields with data
                            UpProf_SFName_txt.Text = reader("StudFName").ToString()
                            UpProf_SMName_txt.Text = reader("StudMName").ToString()
                            UpProf_SLName_txt.Text = reader("StudLName").ToString()
                            UpProf_SSuffix_txt.Text = reader("StudSName").ToString()
                            UpProf_SStud_ID_Mtxt.Text = reader("StudentID").ToString()
                            UpProf_SEmailAdd_txt.Text = reader("StudEmail").ToString()
                            UpProf_SProgName_txt.Text = reader("ProgramName").ToString()
                            UpProf_SDeptID_cmb.Text = reader("DepartmentID").ToString()
                            UpProf_SProgID_cmb.Text = reader("ProgramID").ToString()
                            UpProf_SSection_txt.Text = reader("StudYrLvl").ToString() & "-" & reader("StudSection").ToString()
                            UpProf_SContNum_Mtxt.Text = cont
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Using
    End Sub

    ' Save profile updates
    Private Sub UpProf_SSave_btn_Click(sender As Object, e As EventArgs) Handles UpProf_SSave_btn.Click

        Dim firstName As String = UpProf_SFName_txt.Text.Trim()
        Dim midName As String = UpProf_SMName_txt.Text.Trim()
        Dim lastName As String = UpProf_SLName_txt.Text.Trim()
        Dim suffixName As String = UpProf_SSuffix_txt.Text.Trim()
        Dim emailAdd As String = UpProf_SEmailAdd_txt.Text.Trim()
        Dim rawContNum As String = UpProf_SContNum_Mtxt.Text.Trim()

        ' Validate required fields
        If String.IsNullOrEmpty(firstName) Then
            MsgBox("First Name is required.", MsgBoxStyle.Exclamation, "Validation Error")
            Return
        End If

        If String.IsNullOrEmpty(lastName) Then
            MsgBox("Last Name is required.", MsgBoxStyle.Exclamation, "Validation Error")
            Return
        End If

        If String.IsNullOrWhiteSpace(emailAdd) Then
            MsgBox("Email Address is required.", MsgBoxStyle.Exclamation, "Validation Error")
            Return
        ElseIf Not Regex.IsMatch(emailAdd, emailPattern) Then
            MsgBox("Please enter a valid email address.", MsgBoxStyle.Exclamation, "Validation Error")
            Return
        End If

        ' ============================
        ' NEW CONTACT NUMBER VALIDATION
        ' ============================
        Dim digitsOnly As String = New String(rawContNum.Where(AddressOf Char.IsDigit).ToArray())

        ' Remove the "63" from +63
        If digitsOnly.StartsWith("63") Then
            digitsOnly = digitsOnly.Substring(2)
        End If

        ' Must be exactly 10 digits (9123456789)
        If digitsOnly.Length <> 10 Then
            MsgBox("Contact Number must be 10 digits after +63.", MsgBoxStyle.Exclamation)
            UpProf_SContNum_Mtxt.Focus()
            Return
        End If

        ' Final 11-digit version stored in DB
        Dim contNum As String = "0" & digitsOnly


        Try
            Using con As New MySqlConnection(connString)
                con.Open()

                ' Update profile query
                Dim upProfileQuery = "
                UPDATE students
                SET StudFName = @fname,
                    StudMName = @mname,
                    StudLName = @lname,
                    StudSName = @sname,
                    StudEmail = @email,
                    StudContNo = @contno
                WHERE StudentID = @id
            "

                Using cmdU As New MySqlCommand(upProfileQuery, con)
                    ' Add parameters and handle nullable fields
                    cmdU.Parameters.AddWithValue("@fname", firstName)
                    cmdU.Parameters.AddWithValue("@mname", If(String.IsNullOrEmpty(midName), DBNull.Value, midName))
                    cmdU.Parameters.AddWithValue("@lname", lastName)
                    cmdU.Parameters.AddWithValue("@sname", If(String.IsNullOrEmpty(suffixName), DBNull.Value, suffixName))
                    cmdU.Parameters.AddWithValue("@email", emailAdd)
                    cmdU.Parameters.AddWithValue("@contno", contNum)
                    cmdU.Parameters.AddWithValue("@id", user)

                    Dim rowsAffected = cmdU.ExecuteNonQuery
                    If rowsAffected > 0 Then
                        MsgBox("Profile updated successfully.")
                        Student_Dashboard.LoadStudentProfile()
                        Close()
                    Else
                        MsgBox("No changes were made.")
                        Close()
                    End If
                End Using
            End Using
        Catch ex As MySqlException
            MsgBox("Database error: " & ex.Message)
        Catch ex As Exception
            MsgBox("General error: " & ex.Message)
        End Try

        Student_Dashboard.LoadStudentProfile()

    End Sub

    ' Cancel profile update
    Private Sub UpProf_SCancel_btn_Click(sender As Object, e As EventArgs) Handles UpProf_SCancel_btn.Click
        If MsgBox("Are you sure you want to cancel?", MsgBoxStyle.YesNo, "Confirmation") = vbYes Then
            Close()
        End If
    End Sub

    Private Sub LoadFacultyProfile()
        Try
            Using con As New MySqlConnection(connString)
                con.Open()

                Dim facultyQuery As String = "
                SELECT f.FacFName, f.FacLName, f.FacMName, f.FacSName,
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
                            FacUpdate_FName_txt.Text = reader("FacFName").ToString()
                            FacUpdate_MName_txt.Text = reader("FacMName").ToString()
                            FacUpdate_LName_txt.Text = reader("FacLName").ToString()
                            FacUpdate_SName_txt.Text = reader("FacSName").ToString()
                            FacUpdate_Email_txt.Text = reader("FacultyEmail").ToString()
                            FacUpdate_DeptID_cmb.Text = reader("DepartmentID").ToString()
                            FacUpdate_DeptName_txt.Text = reader("Department_description").ToString()
                            FacUpdate_EmpStat_txt.Text = reader("Emp_Status").ToString()
                            FacUpdate_Position_txt.Text = reader("Position").ToString()
                            FacUpdate_ContNo_Mtxt.Text = contNum
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

    Private Sub FacUpdate_Save_btn_Click(sender As Object, e As EventArgs) Handles FacUpdate_Save_btn.Click

        Dim facFName As String = FacUpdate_FName_txt.Text.Trim
        Dim facMName As String = FacUpdate_MName_txt.Text.Trim
        Dim facLName As String = FacUpdate_LName_txt.Text.Trim
        Dim facSName As String = FacUpdate_SName_txt.Text.Trim
        Dim facemailAdd As String = FacUpdate_Email_txt.Text.Trim
        Dim rawFacContNo As String = FacUpdate_ContNo_Mtxt.Text.Trim

        ' Validate required fields
        If String.IsNullOrEmpty(facFName) Then
            MsgBox("First Name is required.", MsgBoxStyle.Exclamation, "Validation Error")
            Return
        End If

        If String.IsNullOrEmpty(facLName) Then
            MsgBox("Last Name is required.", MsgBoxStyle.Exclamation, "Validation Error")
            Return
        End If

        If String.IsNullOrWhiteSpace(facemailAdd) Then
            MsgBox("Email Address is required.", MsgBoxStyle.Exclamation, "Validation Error")
            Return
        ElseIf Not Regex.IsMatch(facemailAdd, emailPattern) Then
            MsgBox("Please enter a valid email address.", MsgBoxStyle.Exclamation, "Validation Error")
            Return
        End If

        ' ============================
        ' NEW CONTACT NUMBER VALIDATION
        ' ============================
        Dim digitsOnly As String = New String(rawFacContNo.Where(AddressOf Char.IsDigit).ToArray())

        If digitsOnly.StartsWith("63") Then
            digitsOnly = digitsOnly.Substring(2)
        End If

        If digitsOnly.Length <> 10 Then
            MsgBox("Contact Number must be 10 digits after +63.", MsgBoxStyle.Exclamation)
            FacUpdate_ContNo_Mtxt.Focus()
            Return
        End If

        Dim faccontNum As String = "0" & digitsOnly


        Try
            Using con As New MySqlConnection(connString)
                con.Open()

                ' Update profile query
                Dim upFacProfileQuery = "
                UPDATE faculty
                SET FacFName = @fname,
                    FacMName = @mname,
                    FacLName = @lname,
                    FacSName = @sname,
                    FacultyEmail = @email,
                    FacultyContNo = @contno
                WHERE FacultyID = @id
            "

                Using cmdU As New MySqlCommand(upFacProfileQuery, con)
                    ' Add parameters and handle nullable fields
                    cmdU.Parameters.AddWithValue("@fname", facFName)
                    cmdU.Parameters.AddWithValue("@mname", If(String.IsNullOrEmpty(facMName), DBNull.Value, facMName))
                    cmdU.Parameters.AddWithValue("@lname", facLName)
                    cmdU.Parameters.AddWithValue("@sname", If(String.IsNullOrEmpty(facSName), DBNull.Value, facSName))
                    cmdU.Parameters.AddWithValue("@email", facemailAdd)
                    cmdU.Parameters.AddWithValue("@contno", faccontNum)
                    cmdU.Parameters.AddWithValue("@id", user)

                    Dim rowsAffected = cmdU.ExecuteNonQuery
                    If rowsAffected > 0 Then
                        MsgBox("Profile updated successfully.")
                        Faculty_Dashboard.LoadFacultyProfile()
                        Close()
                    Else
                        MsgBox("No changes were made.")
                        Close()
                    End If
                End Using
            End Using
        Catch ex As MySqlException
            MsgBox("Database error: " & ex.Message)
        Catch ex As Exception
            MsgBox("General error: " & ex.Message)
        End Try

    End Sub

    Private Sub FacUpdate_Cancel_btn_Click(sender As Object, e As EventArgs) Handles FacUpdate_Cancel_btn.Click
        If MsgBox("Are you sure you want to cancel?", MsgBoxStyle.YesNo, "Confirmation") = vbYes Then
            Close()
        End If
    End Sub

    Private Sub Fac_ChangePass_Save_btn_Click(sender As Object, e As EventArgs) Handles Fac_ChangePass_Save_btn.Click
        Dim newPasswordRaw As String = Fac_ChangePass_NewPass_txt.Text.Trim
        Dim conPasswordRaw As String = Fac_ChangePass_ConPass_txt.Text.Trim

        ' Check empty
        If String.IsNullOrWhiteSpace(newPasswordRaw) OrElse String.IsNullOrWhiteSpace(conPasswordRaw) Then
            MsgBox("Password fields cannot be empty!", MsgBoxStyle.Exclamation, "Invalid")
            Return
        End If

        ' Check mismatch
        If newPasswordRaw <> conPasswordRaw Then
            MsgBox("New password and confirm password doesn't match!", MsgBoxStyle.Exclamation, "Invalid")
            Return
        End If
        Dim newPassword As String = HashPassword(newPasswordRaw)
        Dim conPassword As String = HashPassword(conPasswordRaw)
        Dim oldPassword As String = HashPassword(Fac_ChangePass_OldPass_txt.Text.Trim())

        Try
            Using con As New MySqlConnection(connString)
                con.Open()

                ' Check the old password against the stored password hash
                Dim oPassQuery = "SELECT PasswordHash FROM users WHERE Username = @id"
                Using cmdC As New MySqlCommand(oPassQuery, con)
                    cmdC.Parameters.AddWithValue("@id", user)
                    Using reader = cmdC.ExecuteReader
                        If reader.Read Then
                            If oldPassword <> reader("PasswordHash") Then
                                MsgBox("Incorrect old password!", MsgBoxStyle.Exclamation, "Invalid!")
                                Return
                            End If
                        End If
                    End Using
                End Using

                ' Confirm password change
                If MsgBox("Are you sure you want to change your password?", MsgBoxStyle.YesNo, "Validation") = vbYes Then
                    Dim cPassQuery = "UPDATE users SET PasswordHash = @password WHERE Username = @id"

                    Using cmdCP As New MySqlCommand(cPassQuery, con)
                        cmdCP.Parameters.AddWithValue("@password", newPassword)
                        cmdCP.Parameters.AddWithValue("@id", user)

                        ' Execute query
                        cmdCP.ExecuteNonQuery()
                    End Using

                    MsgBox("Password changed successfully!", MsgBoxStyle.OkOnly, "Success!")
                    Fac_ChangePass_OldPass_txt.Text = ""
                    Fac_ChangePass_NewPass_txt.Text = ""
                    Fac_ChangePass_ConPass_txt.Text = ""
                    Close()
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Fac_ChangePass_Cancel_btn_Click(sender As Object, e As EventArgs) Handles Fac_ChangePass_Cancel_btn.Click
        If MsgBox("Are you sure you want to cancel?", MsgBoxStyle.YesNo, "Confirmation") = vbYes Then
            Close()
        End If
    End Sub

    Private Sub FacUpdate_ContNo_Mtxt_Click(sender As Object, e As EventArgs) Handles FacUpdate_ContNo_Mtxt.Enter
        MoveCursorToLastDigit()
    End Sub

    Private Sub FacUpdate_ContNo_Mtxt_Click_1(sender As Object, e As EventArgs) Handles FacUpdate_ContNo_Mtxt.Click
        MoveCursorToLastDigit()
    End Sub

    Private Sub UpProf_SContNum_Mtxt_Click(sender As Object, e As EventArgs) Handles UpProf_SContNum_Mtxt.Click
        MoveCursorToLastDigit()
    End Sub

    Private Sub UpProf_SContNum_Mtxt_Enter(sender As Object, e As EventArgs) Handles UpProf_SContNum_Mtxt.Enter
        MoveCursorToLastDigit()
    End Sub

    Private Sub UpProf_SContNum_Mtxt_KeyDown(sender As Object, e As KeyEventArgs) Handles UpProf_SContNum_Mtxt.KeyDown
        If UpProf_SContNum_Mtxt.SelectionStart < 4 Then
            If e.KeyCode = Keys.Back OrElse e.KeyCode = Keys.Delete Then
                e.SuppressKeyPress = True
                UpProf_SContNum_Mtxt.SelectionStart = 4
                Exit Sub
            End If
        End If
    End Sub
    Private Sub FacUpdate_ContNo_Mtxt_KeyDown(sender As Object, e As KeyEventArgs) Handles FacUpdate_ContNo_Mtxt.KeyDown
        If FacUpdate_ContNo_Mtxt.SelectionStart < 4 Then
            If e.KeyCode = Keys.Back OrElse e.KeyCode = Keys.Delete Then
                e.SuppressKeyPress = True
                FacUpdate_ContNo_Mtxt.SelectionStart = 4
                Exit Sub
            End If
        End If
    End Sub

    Private Sub FacUpdate_ContNo_Mtxt_TextChanged(sender As Object, e As EventArgs) Handles FacUpdate_ContNo_Mtxt.TextChanged
        MoveCursorToLastDigit()
    End Sub

    Private Sub UpProf_SContNum_Mtxt_TextChanged(sender As Object, e As EventArgs) Handles UpProf_SContNum_Mtxt.TextChanged
        MoveCursorToLastDigit()
    End Sub

    Private Sub MoveCursorToLastDigit()
        Dim txt = UpProf_SContNum_Mtxt.Text

        'Find last entered digit (0–9)
        Dim lastIndex As Integer = -1
        For i As Integer = 0 To txt.Length - 1
            If Char.IsDigit(txt(i)) Then lastIndex = i
        Next

        If lastIndex < 3 Then
            'No numbers typed → cursor after +63
            UpProf_SContNum_Mtxt.SelectionStart = 4
        Else
            'Move cursor after last digit typed
            UpProf_SContNum_Mtxt.SelectionStart = lastIndex + 1
        End If
    End Sub
End Class
