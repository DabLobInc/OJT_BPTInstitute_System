Imports MySql.Data.MySqlClient
Imports System.IO
Public Class Faculty_Dashboard

    Private FullCSV As DataTable
    Private isEditingSecInfo As Boolean = False

    Private FullCSV_MidGrades As DataTable
    Private FullCSV_FinGrades As DataTable


    Private Sub Logout_BTN_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Logout_BTN.LinkClicked
        Dim result = MessageBox.Show("Do you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Hide()
            LogIn_Form.ShowPass_BTN.Checked = False
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

    Private Sub Grade_Linklbl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Grade_Linklbl.LinkClicked
        ShowPanel(Screen_Panel, "Grade_Panel")
        LoadGradeFilters()
    End Sub

    Private Sub Faculty_Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        RestoreDefaultSectionDGV()
        Fac_SecInfo_DGV.AutoGenerateColumns = False
        LoadEvaluations()
        LoadFacultyInfo()
        LoadFacultyFilters()

        RestoreDefaultMidGradeDGV()
        RestoreDefaultFinGradeDGV()

        StyleDGV(Fac_PendEval_DGV)
        StyleDGV(Fac_SecInfo_DGV)

        Fac_Program_cmb.Text = "- None -"
        Fac_Section_cmb.Text = "- None -"
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

                            Dim lastName As String = reader("FacLName").ToString().ToUpper()
                            Dim firstName As String = reader("FacFName").ToString().ToUpper()
                            Dim empStatus As String = reader("Emp_Status").ToString()
                            Dim pos As String = reader("Position").ToString()
                            Dim deptN As String = reader("Department_description").ToString()

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

    Public Sub LoadFacultyProfile()
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

    Public Sub LoadEvaluations()
        Using con As New MySqlConnection(connString)
            Try
                Dim user = LogIn_Form.LoggedInUser
                con.Open()

                Dim evalQuery As String = "
                    SELECT 
                        i.InternID,
                        CONCAT(s.StudLName, ', ', s.StudFName, ' ',
                            CASE WHEN s.StudMName IS NULL OR s.StudMName = '' 
                                THEN '' ELSE CONCAT(LEFT(s.StudMName, 1), '.') END) AS StudentName,
                        p.ProgramName,
                        s.StudSection,
                        c.CompanyName,
                        sup.SupervisorName,
                        CONCAT(f.FacLName, ', ', f.FacFName, ' ', f.FacMName) AS FacultyEvaluator,
                        i.Status
                    FROM internship i
                    JOIN students s ON s.StudentID = i.StudentID
                    JOIN programs p ON p.ProgramID = s.ProgramID
                    JOIN company c ON c.CompanyID = i.CompanyID
                    JOIN supervisors sup ON sup.SupervisorID = i.SupervisorID
                    JOIN faculty f ON f.FacultyID = i.FacultyID
                    WHERE i.FacultyID = @id
                "

                Using cmd As New MySqlCommand(evalQuery, con)
                    cmd.Parameters.AddWithValue("@id", user)

                    Using da As New MySqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        da.Fill(dt)

                        Fac_PendEval_DGV.AutoGenerateColumns = False

                        FacDGV_InternID.DataPropertyName = "InternID"
                        FacDGV_StudName.DataPropertyName = "StudentName"
                        FacDGV_Program.DataPropertyName = "ProgramName"
                        FacDGV_Section.DataPropertyName = "StudSection"
                        FacDGV_CompName.DataPropertyName = "CompanyName"
                        FacDGV_SVisor.DataPropertyName = "SupervisorName"
                        FacDGV_FEval.DataPropertyName = "FacultyEvaluator"
                        FacDGV_Stat.DataPropertyName = "Status"

                        Fac_PendEval_DGV.DataSource = dt
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub LoadFacultyFilters()
        Dim fid As String = LogIn_Form.LoggedInUser

        Dim sql As String =
        "SELECT DISTINCT p.ProgramName, s.StudSection
         FROM students s
         JOIN internship i ON i.StudentID = s.StudentID
         JOIN programs p ON p.ProgramID = s.ProgramID
         WHERE i.FacultyID = @fid
         ORDER BY p.ProgramName, s.StudSection"

        Dim dt = GetDataTable(sql, New Dictionary(Of String, Object) From {{"@fid", fid}})

        Dim noneText As String = "- None -"
        Fac_Program_cmb.Items.Clear()
        Fac_Section_cmb.Items.Clear()
        Fac_Program_cmb.Items.Add(noneText)
        Fac_Section_cmb.Items.Add(noneText)

        Dim programSet As New HashSet(Of String)
        Dim sectionSet As New HashSet(Of String)

        For Each row As DataRow In dt.Rows
            Dim prog = row("ProgramName").ToString()
            Dim sec = row("StudSection").ToString()

            If prog <> "" AndAlso programSet.Add(prog) Then
                If prog <> noneText Then Fac_Program_cmb.Items.Add(prog)
            End If
            If sec <> "" AndAlso sectionSet.Add(sec) Then
                If sec <> noneText Then Fac_Section_cmb.Items.Add(sec)
            End If
        Next

        If Fac_Program_cmb.Items.Count > 0 AndAlso Fac_Program_cmb.Text = "" Then Fac_Program_cmb.Text = noneText
        If Fac_Section_cmb.Items.Count > 0 AndAlso Fac_Section_cmb.Text = "" Then Fac_Section_cmb.Text = noneText
    End Sub
    Private Sub LoadGradeFilters()
        Dim fid As String = LogIn_Form.LoggedInUser

        Dim sql As String =
            "SELECT DISTINCT p.ProgramName, s.StudSection
            FROM students s
            JOIN internship i ON i.StudentID = s.StudentID
            JOIN programs p ON p.ProgramID = s.ProgramID
            WHERE i.FacultyID = @fid
            ORDER BY p.ProgramName, s.StudSection"

        Dim dt = GetDataTable(sql, New Dictionary(Of String, Object) From {{"@fid", fid}})

        Dim noneText As String = "- None -"
        Fac_GProgram_cmb.Items.Clear()
        Fac_GSection_cmb.Items.Clear()
        Fac_GProgram_cmb.Items.Add(noneText)
        Fac_GSection_cmb.Items.Add(noneText)

        Dim programSet As New HashSet(Of String)
        Dim sectionSet As New HashSet(Of String)

        For Each row As DataRow In dt.Rows
            Dim prog = row("ProgramName").ToString()
            Dim sec = row("StudSection").ToString()

            If prog <> "" AndAlso programSet.Add(prog) Then
                If prog <> noneText Then Fac_GProgram_cmb.Items.Add(prog)
            End If
            If sec <> "" AndAlso sectionSet.Add(sec) Then
                If sec <> noneText Then Fac_GSection_cmb.Items.Add(sec)
            End If
        Next

        ' Force visual refresh by setting text
        Fac_GProgram_cmb.Text = noneText
        Fac_GSection_cmb.Text = noneText
    End Sub

    Private Sub PopulateProgramSectionFromGrid()
        Dim noneText As String = "- None -"

        Fac_Program_cmb.Items.Clear()
        Fac_Section_cmb.Items.Clear()

        Fac_Program_cmb.Items.Add(noneText)
        Fac_Section_cmb.Items.Add(noneText)

        Dim programs As New HashSet(Of String)()
        Dim sections As New HashSet(Of String)()

        For Each row As DataGridViewRow In Fac_SecInfo_DGV.Rows
            If row.IsNewRow Then Continue For

            Dim prog = If(row.Cells("progID_col_lbl").Value, "").ToString()
            Dim sec = If(row.Cells("studSec_col_lbl").Value, "").ToString()

            If prog <> "" AndAlso programs.Add(prog) Then
                If prog <> noneText Then Fac_Program_cmb.Items.Add(prog)
            End If

            If sec <> "" AndAlso sections.Add(sec) Then
                If sec <> noneText Then Fac_Section_cmb.Items.Add(sec)
            End If
        Next

        Fac_Program_cmb.Text = noneText
        Fac_Section_cmb.Text = noneText
    End Sub

    Private Sub Faculty_FacCPass_btn_Click(sender As Object, e As EventArgs) Handles Faculty_FacCPass_btn.Click
        Me.TopMost = False
        Dim f As New Update_Account("Fac_ChangePass_Container_pnl")
        f.ShowDialog()
        Me.TopMost = True
    End Sub

    Private Sub Faculty_FacUpd_btn_Click(sender As Object, e As EventArgs) Handles Faculty_FacUpd_btn.Click
        Me.TopMost = False
        Dim f As New Update_Account("Fac_Update_Profile_pnl")
        f.ShowDialog()
        Me.TopMost = True
    End Sub

    Private Function ParseCsvLine(line As String) As List(Of String)
        Dim result As New List(Of String)()
        Dim cur As String = ""
        Dim inQuotes As Boolean = False

        For i As Integer = 0 To line.Length - 1
            Dim c As Char = line(i)

            If c = """"c Then
                inQuotes = Not inQuotes
            ElseIf c = ","c AndAlso Not inQuotes Then
                result.Add(cur)
                cur = ""
            Else
                cur &= c
            End If
        Next

        result.Add(cur)
        Return result
    End Function

    Private Sub Fac_ImportCSV_btn_Click(sender As Object, e As EventArgs) Handles Fac_ImportCSV_btn.Click
        Try
            Dim ofd As New OpenFileDialog
            ofd.Filter = "CSV Files (*.csv)|*.csv"

            If ofd.ShowDialog <> DialogResult.OK Then Exit Sub

            Dim lines = File.ReadAllLines(ofd.FileName)
            If lines.Length <= 1 Then
                MessageBox.Show("CSV file is empty.")
                Exit Sub
            End If

            ' Temporarily allow auto columns so we can show the imported headers
            Fac_SecInfo_DGV.Columns.Clear()
            Fac_SecInfo_DGV.AutoGenerateColumns = True

            Dim dt As New DataTable

            Dim headers = ParseCsvLine(lines(0))
            For Each h In headers
                dt.Columns.Add(h.Trim)
            Next

            For r = 1 To lines.Length - 1
                If String.IsNullOrWhiteSpace(lines(r)) Then Continue For
                Dim values = ParseCsvLine(lines(r))
                While values.Count < headers.Count
                    values.Add("")
                End While
                dt.Rows.Add(values.ToArray)
            Next

            FullCSV = dt
            Fac_SecInfo_DGV.DataSource = FullCSV

            ' --- Build filters from CSV (only from imported rows) ---
            Dim noneText = "- None -"
            Fac_Program_cmb.Items.Clear()
            Fac_Section_cmb.Items.Clear()
            Fac_Program_cmb.Items.Add(noneText)
            Fac_Section_cmb.Items.Add(noneText)

            ' support multiple possible header names robustly
            Dim progCols = {"Program ID", "Program", "ProgramName", "ProgramName"}
            Dim secCols = {"Section", "StudSection", "SectionName"}

            Dim progColumnName As String = Nothing
            Dim secColumnName As String = Nothing

            For Each c In progCols
                If FullCSV.Columns.Contains(c) Then
                    progColumnName = c
                    Exit For
                End If
            Next
            For Each c In secCols
                If FullCSV.Columns.Contains(c) Then
                    secColumnName = c
                    Exit For
                End If
            Next

            Dim progSet As New HashSet(Of String)
            Dim secSet As New HashSet(Of String)

            For Each row As DataRow In FullCSV.Rows
                If progColumnName IsNot Nothing Then
                    Dim v = If(IsDBNull(row(progColumnName)), "", row(progColumnName).ToString.Trim)
                    If v <> "" Then progSet.Add(v)
                End If
                If secColumnName IsNot Nothing Then
                    Dim v2 = If(IsDBNull(row(secColumnName)), "", row(secColumnName).ToString.Trim)
                    If v2 <> "" Then secSet.Add(v2)
                End If
            Next

            For Each p In progSet
                If p <> noneText Then Fac_Program_cmb.Items.Add(p)
            Next
            For Each s In secSet
                If s <> noneText Then Fac_Section_cmb.Items.Add(s)
            Next

            Fac_Program_cmb.Text = noneText
            Fac_Section_cmb.Text = noneText

            MessageBox.Show("CSV imported successfully. Now review before saving to database.")

        Catch ex As Exception
            MessageBox.Show("Error importing CSV: " & ex.Message)
        End Try

        Fac_SecInfo_DGV.AutoGenerateColumns = False
    End Sub

    Public Sub RestoreDefaultSectionDGV()
        Fac_SecInfo_DGV.DataSource = Nothing
        Fac_SecInfo_DGV.AutoGenerateColumns = False
        Fac_SecInfo_DGV.Columns.Clear()

        Fac_SecInfo_DGV.Columns.Add(New DataGridViewTextBoxColumn() With {
            .Name = "studID_col_lbl",
            .HeaderText = "Student ID",
            .DataPropertyName = "StudentID"
        })

        Fac_SecInfo_DGV.Columns.Add(New DataGridViewTextBoxColumn() With {
            .Name = "studLName_col_lbl",
            .HeaderText = "Last Name",
            .DataPropertyName = "StudLName"
        })

        Fac_SecInfo_DGV.Columns.Add(New DataGridViewTextBoxColumn() With {
            .Name = "studFName_col_lbl",
            .HeaderText = "First Name",
            .DataPropertyName = "StudFName"
        })

        Fac_SecInfo_DGV.Columns.Add(New DataGridViewTextBoxColumn() With {
            .Name = "studMName_col_lbl",
            .HeaderText = "Middle Name",
            .DataPropertyName = "StudMName"
        })

        Fac_SecInfo_DGV.Columns.Add(New DataGridViewTextBoxColumn() With {
            .Name = "studSName_col_lbl",
            .HeaderText = "Suffix",
            .DataPropertyName = "StudSName"
        })

        Fac_SecInfo_DGV.Columns.Add(New DataGridViewTextBoxColumn() With {
            .Name = "depID_col_lbl",
            .HeaderText = "Department",
            .DataPropertyName = "DepartmentName"
        })

        Fac_SecInfo_DGV.Columns.Add(New DataGridViewTextBoxColumn() With {
            .Name = "progID_col_lbl",
            .HeaderText = "Program",
            .DataPropertyName = "ProgramName"
        })

        Fac_SecInfo_DGV.Columns.Add(New DataGridViewTextBoxColumn() With {
            .Name = "studSec_col_lbl",
            .HeaderText = "Section",
            .DataPropertyName = "StudSection"
        })

        Fac_SecInfo_DGV.Columns.Add(New DataGridViewTextBoxColumn() With {
            .Name = "studStat_col_lbl",
            .HeaderText = "Status",
            .DataPropertyName = "InternshipStatus"
        })
    End Sub

    Public Function GetDataTable(sql As String, params As Dictionary(Of String, Object)) As DataTable
        Dim dt As New DataTable()

        Using con As New MySqlConnection(connString)
            con.Open()

            Using cmd As New MySqlCommand(sql, con)

                If params IsNot Nothing Then
                    For Each kvp In params
                        cmd.Parameters.AddWithValue(kvp.Key, kvp.Value)
                    Next
                End If

                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using

            End Using
        End Using

        Return dt
    End Function


    Private Function GetNextInternID(con As MySqlConnection) As String
        Dim sql As String = "SELECT MAX(InternID) FROM internship WHERE InternID LIKE 'I%';"
        Dim maxID As Object = Nothing
        Using cmd As New MySqlCommand(sql, con)
            maxID = cmd.ExecuteScalar()
        End Using

        If maxID Is Nothing OrElse IsDBNull(maxID) Then
            Return "I001"
        End If

        Dim s As String = maxID.ToString()
        Dim numPart As String = New String(s.Where(AddressOf Char.IsDigit).ToArray())
        Dim n As Integer = 0
        If Integer.TryParse(numPart, n) Then
            n += 1
        Else
            n = 1
        End If
        Return "I" & n.ToString("D3")
    End Function

    Private Function NormalizeDate(dateValue As String) As Object
        If String.IsNullOrWhiteSpace(dateValue) Then
            Return DBNull.Value
        End If

        Dim parsed As Date
        If Date.TryParse(dateValue, parsed) Then
            Return parsed.ToString("yyyy-MM-dd")
        End If

        Return DBNull.Value   ' invalid date
    End Function

    Private Sub Fac_SaveDB_btn_Click(sender As Object, e As EventArgs) Handles Fac_SaveDB_btn.Click

        If FullCSV Is Nothing OrElse FullCSV.Rows.Count = 0 Then
            MsgBox("No CSV data loaded.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Using con As New MySqlConnection(connString)
            con.Open()
            Dim facultyID = LogIn_Form.LoggedInUser

            Try
                For Each row As DataRow In FullCSV.Rows

                    Dim studID = row("Student ID").ToString.Trim

                    Dim insertStudent =
                        "INSERT INTO students 
                        (StudentID, StudLName, StudFName, StudMName, StudSName,
                         StudYrLvl, StudSem, StudEmail, StudContNo,
                         DepartmentID, ProgramID, StudSection)
                         VALUES
                        (@id, @ln, @fn, @mn, @sn,
                         @lvl, @sem, @email, @contact,
                         @dep, @prog, @sec)"

                    Using cmd As New MySqlCommand(insertStudent, con)
                        cmd.Parameters.AddWithValue("@id", studID)
                        cmd.Parameters.AddWithValue("@ln", row("Last Name"))
                        cmd.Parameters.AddWithValue("@fn", row("First Name"))
                        cmd.Parameters.AddWithValue("@mn", row("Middle Name"))
                        cmd.Parameters.AddWithValue("@sn", row("Suffix"))
                        cmd.Parameters.AddWithValue("@lvl", row("Student Year Level"))
                        cmd.Parameters.AddWithValue("@sem", row("Semester"))
                        cmd.Parameters.AddWithValue("@email", row("Student Email"))
                        cmd.Parameters.AddWithValue("@contact", row("Student Contact Number"))
                        cmd.Parameters.AddWithValue("@dep", row("Department ID"))
                        cmd.Parameters.AddWithValue("@prog", row("Program ID"))
                        cmd.Parameters.AddWithValue("@sec", row("Section"))
                        cmd.ExecuteNonQuery()
                    End Using

                    Dim username = studID
                    Dim password = row("Last Name").ToString.ToLower & "_" &
                                             row("First Name").ToString.Split(" "c)(0).ToLower

                    Dim insertUser =
                        "INSERT INTO users (Username, PasswordHash, UserType)
                         VALUES (@u, SHA2(@p,256), 'Student')"

                    Using cmdUser As New MySqlCommand(insertUser, con)
                        cmdUser.Parameters.AddWithValue("@u", username)
                        cmdUser.Parameters.AddWithValue("@p", password)
                        cmdUser.ExecuteNonQuery()
                    End Using

                    Dim newInternID = GetNextInternID(con)

                    Dim insertIntern =
                        "INSERT INTO internship
                         (InternID, StudentID, SchoolYr, StartDate, EndDate, Status,
                          CompanyID, SupervisorID, FacultyID)
                         VALUES
                         (@iid, @sid, @sy, @st, @ed, @stat,
                          @comp, @sup, @fid)"

                    Using cmdInt As New MySqlCommand(insertIntern, con)
                        cmdInt.Parameters.AddWithValue("@iid", newInternID)
                        cmdInt.Parameters.AddWithValue("@sid", studID)
                        cmdInt.Parameters.AddWithValue("@sy", row("School Year"))

                        ' Convert blank/empty date strings to DBNull to avoid SQL date conversion errors
                        If FullCSV.Columns.Contains("Start Date") AndAlso Not IsDBNull(row("Start Date")) AndAlso row("Start Date").ToString.Trim <> "" Then
                            cmdInt.Parameters.AddWithValue("@st", NormalizeDate(row("Start Date").ToString))
                        Else
                            cmdInt.Parameters.AddWithValue("@st", DBNull.Value)
                        End If

                        If FullCSV.Columns.Contains("End Date") AndAlso Not IsDBNull(row("End Date")) AndAlso row("End Date").ToString.Trim <> "" Then
                            cmdInt.Parameters.AddWithValue("@ed", NormalizeDate(row("End Date").ToString))
                        Else
                            cmdInt.Parameters.AddWithValue("@ed", DBNull.Value)
                        End If

                        cmdInt.Parameters.AddWithValue("@stat", row("Status"))
                        cmdInt.Parameters.AddWithValue("@comp", row("Company ID"))
                        cmdInt.Parameters.AddWithValue("@sup", row("Supervisor ID"))
                        cmdInt.Parameters.AddWithValue("@fid", facultyID)
                        cmdInt.ExecuteNonQuery()
                    End Using

                Next

                MsgBox("Import completed successfully!", MsgBoxStyle.Information)

            Catch ex As MySqlException
                MsgBox("IMPORT FAILED: " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
                Exit Sub

            Catch ex As Exception
                MsgBox("ERROR: " & ex.Message, MsgBoxStyle.Critical)
                Exit Sub
            End Try
        End Using

        RestoreDefaultSectionDGV()
        LoadFacultyFilters()
        LoadGradeFilters()
        LoadEvaluations()

        ShowPanel(Screen_Panel, "Section_Panel")
    End Sub

    Private Sub Fac_SecFilter_btn_Click(sender As Object, e As EventArgs) Handles Fac_SecFilter_btn.Click
        Fac_SecInfo_DGV.AutoGenerateColumns = False

        Dim p = Fac_Program_cmb.Text.Trim
        Dim s = Fac_Section_cmb.Text.Trim
        Dim fid = LogIn_Form.LoggedInUser

        Dim noneText = "- None -"
        Dim sql =
                "SELECT s.StudentID,
                        s.StudLName,
                        s.StudFName,
                        s.StudMName,
                        s.StudSName,
                        d.Department_description AS DepartmentName,
                        p2.ProgramName AS ProgramName,
                        s.StudSection,
                        IFNULL(i.Status, '') AS InternshipStatus
                 FROM students s
                 JOIN internship i ON i.StudentID = s.StudentID
                 JOIN programs p2 ON p2.ProgramID = s.ProgramID
                 JOIN departments d ON d.DepartmentID = s.DepartmentID
                 WHERE i.FacultyID = @fid"

        Dim params As New Dictionary(Of String, Object) From {{"@fid", fid}}

        If p <> "" And p <> noneText Then
            sql &= " AND p2.ProgramName = @prog"
            params.Add("@prog", p)
        End If
        If s <> "" And s <> noneText Then
            sql &= " AND s.StudSection = @sec"
            params.Add("@sec", s)
        End If

        ' If both are none, no additional filters (shows all)
        Dim dt = GetDataTable(sql, params)
        Fac_SecInfo_DGV.DataSource = dt
    End Sub

    Private Sub Fac_SecSearch_btn_Click(sender As Object, e As EventArgs) Handles Fac_SecSearch_btn.Click
        Fac_SecInfo_DGV.AutoGenerateColumns = False

        Dim k = Fac_SecSearch_txt.Text.Trim
        Dim fid = LogIn_Form.LoggedInUser

        If k = "" Then
            MessageBox.Show("Enter keyword to search.")
            Exit Sub
        End If

        Dim sql =
            "SELECT s.StudentID,
                s.StudLName,
                s.StudFName,
                s.StudMName,
                s.StudSName,
                d.Department_description AS DepartmentName,
                p.ProgramName AS ProgramName,
                s.StudSection,
                IFNULL(i.Status, '') AS InternshipStatus
         FROM students s
         JOIN internship i ON i.StudentID = s.StudentID
         JOIN programs p ON p.ProgramID = s.ProgramID
         JOIN departments d ON d.DepartmentID = s.DepartmentID
         WHERE i.FacultyID = @fid
           AND (s.StudentID LIKE @k
             OR s.StudLName LIKE @k
             OR s.StudFName LIKE @k
             OR s.StudMName LIKE @k
             OR s.StudSection LIKE @k
             OR p.ProgramName LIKE @k
             OR d.Department_description LIKE @k)"

        Fac_SecInfo_DGV.DataSource = GetDataTable(sql,
                New Dictionary(Of String, Object) From {
                    {"@fid", fid},
                    {"@k", "%" & k & "%"}
                })

        LoadFacultyFilters()
        LoadEvaluations()
    End Sub

    Private Sub Eval_Form_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Eval_Form.LinkClicked
        Me.TopMost = False
        Process.Start(New ProcessStartInfo With {
        .FileName = "D:\Jas\Projects (2ndYr - 1st Sem)\INFORMATION MANAGEMENT\IM-VB_SYSTEM\File for System\Individual-form.docx",
        .UseShellExecute = True
    })
    End Sub

    Private Sub Fac_MidGrade_btn_Click(sender As Object, e As EventArgs) Handles Fac_MidGrade_btn.Click
        ShowPanel(Screen_Panel, "Fac_MidGrade_Panel")
        Fac_MidGrade_btn.BackColor = Color.White
        Fac_MidGrade_btn.ForeColor = Color.Black

        Fac_FinGrade_btn.BackColor = Color.Goldenrod
        Fac_FinGrade_btn.ForeColor = Color.White
        LoadGradeFilters()
    End Sub

    Private Sub Fac_FinGrade_btn_Click(sender As Object, e As EventArgs) Handles Fac_FinGrade_btn.Click
        ShowPanel(Screen_Panel, "Fac_FinGrade_Panel")
        Fac_MidGrade_btn.BackColor = Color.Goldenrod
        Fac_MidGrade_btn.ForeColor = Color.White

        Fac_FinGrade_btn.BackColor = Color.White
        Fac_FinGrade_btn.ForeColor = Color.Black
        LoadGradeFilters()
    End Sub

    Private Sub Fac_GSecFilter_btn_Click(sender As Object, e As EventArgs) Handles Fac_GSecFilter_btn.Click
        ' ----------------------------
        ' 1) Determine active grade panel
        ' ----------------------------
        Dim gradeDGV As DataGridView
        Dim startWeek As Integer
        Dim endWeek As Integer
        Dim evalColName As String

        If Fac_MidGrade_Panel.Visible Then
            gradeDGV = Fac_MidGrade_DGV
            startWeek = 1
            endWeek = 9
            evalColName = "Midterms_Eval"
        ElseIf Fac_FinGrade_Panel.Visible Then
            gradeDGV = Fac_FinGrade_DGV
            startWeek = 10
            endWeek = 18
            evalColName = "Finals_Eval"
        Else
            MessageBox.Show("No grade panel is active.")
            Exit Sub
        End If

        gradeDGV.AutoGenerateColumns = True ' Let DGV automatically generate columns

        ' ----------------------------
        ' 2) Get filter values
        ' ----------------------------
        Dim progFilter As String = Fac_GProgram_cmb.Text.Trim()
        Dim secFilter As String = Fac_GSection_cmb.Text.Trim()
        Dim fid As String = LogIn_Form.LoggedInUser
        Dim noneText As String = "- None -"

        ' ----------------------------
        ' 3) Build week column list
        ' ----------------------------
        Dim weekCols As New List(Of String)
        For wk As Integer = startWeek To endWeek
            weekCols.Add($"g.Week{wk}")
        Next
        Dim selectWeekCols As String = If(weekCols.Count > 0, ", " & String.Join(", ", weekCols), "")

        ' ----------------------------
        ' 4) Build SQL query
        ' ----------------------------
        Dim sql As String =
        "SELECT s.StudentID,
                CONCAT(s.StudLName, ', ', s.StudFName, ' ', IFNULL(s.StudMName, '')) AS StudentName,
                p.ProgramName,
                s.StudSection,
                IFNULL(g." & evalColName & ", '') AS EvalGrade" & selectWeekCols & "
         FROM students s
         JOIN internship i ON i.StudentID = s.StudentID
         JOIN programs p ON p.ProgramID = s.ProgramID
         LEFT JOIN grades g ON g.StudentID = s.StudentID
         WHERE i.FacultyID = @fid"

        Dim params As New Dictionary(Of String, Object) From {{"@fid", fid}}

        ' Apply filters using LIKE
        If progFilter <> "" And progFilter <> noneText Then
            sql &= " AND p.ProgramName LIKE @prog"
            params.Add("@prog", "%" & progFilter & "%")
        End If
        If secFilter <> "" And secFilter <> noneText Then
            sql &= " AND s.StudSection LIKE @sec"
            params.Add("@sec", "%" & secFilter & "%")
        End If

        ' ----------------------------
        ' 5) Fetch data
        ' ----------------------------
        Dim dt As DataTable = GetDataTable(sql, params)

        ' ----------------------------
        ' 6) Prepare DataTable for DGV
        ' ----------------------------
        Dim formattedDt As New DataTable()
        formattedDt.Columns.Add("StudentID", GetType(String))
        formattedDt.Columns.Add("StudentName", GetType(String))
        formattedDt.Columns.Add("ProgramName", GetType(String))
        formattedDt.Columns.Add("StudSection", GetType(String))
        formattedDt.Columns.Add(evalColName, GetType(String)) ' Midterm/Final Eval

        For wk As Integer = startWeek To endWeek
            formattedDt.Columns.Add("Week" & wk, GetType(String))
        Next

        For Each dr As DataRow In dt.Rows
            Dim newRow As DataRow = formattedDt.NewRow()
            newRow("StudentID") = If(IsDBNull(dr("StudentID")), "", dr("StudentID").ToString())
            newRow("StudentName") = If(IsDBNull(dr("StudentName")), "", dr("StudentName").ToString())
            newRow("ProgramName") = If(IsDBNull(dr("ProgramName")), "", dr("ProgramName").ToString())
            newRow("StudSection") = If(IsDBNull(dr("StudSection")), "", dr("StudSection").ToString())
            newRow(evalColName) = If(IsDBNull(dr("EvalGrade")), "", dr("EvalGrade").ToString())

            For wk As Integer = startWeek To endWeek
                Dim colName = "Week" & wk
                If dt.Columns.Contains(colName) Then
                    newRow(colName) = If(IsDBNull(dr(colName)), "", dr(colName).ToString())
                Else
                    newRow(colName) = ""
                End If
            Next

            formattedDt.Rows.Add(newRow)
        Next

        ' ----------------------------
        ' 7) Bind to DataGridView
        ' ----------------------------
        gradeDGV.DataSource = formattedDt

        ' ----------------------------
        ' 8) Apply styling (optional)
        ' ----------------------------
        StyleDGV(gradeDGV)
    End Sub



    Private Sub Fac_GMImportCSV_btn_Click(sender As Object, e As EventArgs) Handles Fac_GMImportCSV_btn.Click
        Try
            Dim ofd As New OpenFileDialog
            ofd.Filter = "CSV Files (*.csv)|*.csv"

            If ofd.ShowDialog <> DialogResult.OK Then Exit Sub

            Dim lines = File.ReadAllLines(ofd.FileName)
            If lines.Length <= 1 Then
                MessageBox.Show("CSV file is empty.")
                Exit Sub
            End If

            ' Temporarily allow auto columns so we can show the imported headers
            Fac_MidGrade_DGV.Columns.Clear()
            Fac_MidGrade_DGV.AutoGenerateColumns = True

            Dim dt As New DataTable

            Dim headers = ParseCsvLine(lines(0))
            For Each h In headers
                dt.Columns.Add(h.Trim)
            Next

            For r = 1 To lines.Length - 1
                If String.IsNullOrWhiteSpace(lines(r)) Then Continue For
                Dim values = ParseCsvLine(lines(r))
                While values.Count < headers.Count
                    values.Add("")
                End While
                dt.Rows.Add(values.ToArray)
            Next

            FullCSV_MidGrades = dt  ' Set the midterm-specific variable
            Fac_MidGrade_DGV.DataSource = FullCSV_MidGrades

            ' --- Build filters from CSV (only from imported rows) ---
            Dim noneText = "- None -"
            Fac_GProgram_cmb.Items.Clear()
            Fac_GSection_cmb.Items.Clear()
            Fac_GProgram_cmb.Items.Add(noneText)
            Fac_GSection_cmb.Items.Add(noneText)

            ' Support multiple possible header names robustly
            Dim progCols = {"Program ID", "Program", "ProgramName"}
            Dim secCols = {"Section", "StudSection", "SectionName"}

            Dim progColumnName As String = Nothing
            Dim secColumnName As String = Nothing

            For Each c In progCols
                If FullCSV_MidGrades.Columns.Contains(c) Then
                    progColumnName = c
                    Exit For
                End If
            Next
            For Each c In secCols
                If FullCSV_MidGrades.Columns.Contains(c) Then
                    secColumnName = c
                    Exit For
                End If
            Next

            Dim progSet As New HashSet(Of String)
            Dim secSet As New HashSet(Of String)

            For Each row As DataRow In FullCSV_MidGrades.Rows
                If progColumnName IsNot Nothing Then
                    Dim v = If(IsDBNull(row(progColumnName)), "", row(progColumnName).ToString.Trim)
                    If v <> "" Then progSet.Add(v)
                End If
                If secColumnName IsNot Nothing Then
                    Dim v2 = If(IsDBNull(row(secColumnName)), "", row(secColumnName).ToString.Trim)
                    If v2 <> "" Then secSet.Add(v2)
                End If
            Next

            For Each p In progSet
                If p <> noneText Then Fac_GProgram_cmb.Items.Add(p)
            Next
            For Each s In secSet
                If s <> noneText Then Fac_GSection_cmb.Items.Add(s)
            Next

            Fac_GProgram_cmb.Text = noneText
            Fac_GSection_cmb.Text = noneText

            ' Validation: Ensure the variable is set
            If FullCSV_MidGrades Is Nothing OrElse FullCSV_MidGrades.Rows.Count = 0 Then
                MessageBox.Show("Failed to load CSV data. Please check the file.")
            Else
                MessageBox.Show("CSV imported successfully for Midterm. Now review before saving to database.")
            End If

        Catch ex As Exception
            MessageBox.Show("Error importing CSV: " & ex.Message)
        End Try

        Fac_MidGrade_DGV.AutoGenerateColumns = False
    End Sub

    Private Sub Fac_GFImportCSV_btn_Click(sender As Object, e As EventArgs) Handles Fac_GFImportCSV_btn.Click
        Try
            Dim ofd As New OpenFileDialog
            ofd.Filter = "CSV Files (*.csv)|*.csv"

            If ofd.ShowDialog <> DialogResult.OK Then Exit Sub

            Dim lines = File.ReadAllLines(ofd.FileName)
            If lines.Length <= 1 Then
                MessageBox.Show("CSV file is empty.")
                Exit Sub
            End If

            ' Temporarily allow auto columns so we can show the imported headers
            Fac_FinGrade_DGV.Columns.Clear()
            Fac_FinGrade_DGV.AutoGenerateColumns = True

            Dim dt As New DataTable

            Dim headers = ParseCsvLine(lines(0))
            For Each h In headers
                dt.Columns.Add(h.Trim)
            Next

            For r = 1 To lines.Length - 1
                If String.IsNullOrWhiteSpace(lines(r)) Then Continue For
                Dim values = ParseCsvLine(lines(r))
                While values.Count < headers.Count
                    values.Add("")
                End While
                dt.Rows.Add(values.ToArray)
            Next

            FullCSV_FinGrades = dt  ' Set the finals-specific variable
            Fac_FinGrade_DGV.DataSource = FullCSV_FinGrades

            ' --- Build filters from CSV (only from imported rows) ---
            Dim noneText = "- None -"
            Fac_GProgram_cmb.Items.Clear()
            Fac_GSection_cmb.Items.Clear()
            Fac_GProgram_cmb.Items.Add(noneText)
            Fac_GSection_cmb.Items.Add(noneText)

            ' Support multiple possible header names robustly
            Dim progCols = {"Program ID", "Program", "ProgramName"}
            Dim secCols = {"Section", "StudSection", "SectionName"}

            Dim progColumnName As String = Nothing
            Dim secColumnName As String = Nothing

            For Each c In progCols
                If FullCSV_FinGrades.Columns.Contains(c) Then
                    progColumnName = c
                    Exit For
                End If
            Next
            For Each c In secCols
                If FullCSV_FinGrades.Columns.Contains(c) Then
                    secColumnName = c
                    Exit For
                End If
            Next

            Dim progSet As New HashSet(Of String)
            Dim secSet As New HashSet(Of String)

            For Each row As DataRow In FullCSV_FinGrades.Rows
                If progColumnName IsNot Nothing Then
                    Dim v = If(IsDBNull(row(progColumnName)), "", row(progColumnName).ToString.Trim)
                    If v <> "" Then progSet.Add(v)
                End If
                If secColumnName IsNot Nothing Then
                    Dim v2 = If(IsDBNull(row(secColumnName)), "", row(secColumnName).ToString.Trim)
                    If v2 <> "" Then secSet.Add(v2)
                End If
            Next

            For Each p In progSet
                If p <> noneText Then Fac_GProgram_cmb.Items.Add(p)
            Next
            For Each s In secSet
                If s <> noneText Then Fac_GSection_cmb.Items.Add(s)
            Next

            Fac_GProgram_cmb.Text = noneText
            Fac_GSection_cmb.Text = noneText

            ' Validation: Ensure the variable is set
            If FullCSV_FinGrades Is Nothing OrElse FullCSV_FinGrades.Rows.Count = 0 Then
                MessageBox.Show("Failed to load CSV data. Please check the file.")
            Else
                MessageBox.Show("CSV imported successfully for Finals. Now review before saving to database.")
            End If

        Catch ex As Exception
            MessageBox.Show("Error importing CSV: " & ex.Message)
        End Try

        Fac_FinGrade_DGV.AutoGenerateColumns = False
    End Sub

    Private Sub Fac_GMSaveDB_btn_Click(sender As Object, e As EventArgs) Handles Fac_GMSaveDB_btn.Click
        SaveGradesToDB(FullCSV_MidGrades, 1, 9)  ' Midterm: Weeks 1-9
    End Sub

    Private Sub Fac_GFSaveDB_btn_Click(sender As Object, e As EventArgs) Handles Fac_GFSaveDB_btn.Click
        SaveGradesToDB(FullCSV_FinGrades, 10, 18)  ' Finals: Weeks 10-18
    End Sub

    Private Sub SaveGradesToDB(dt As DataTable, startWeek As Integer, endWeek As Integer)

        If dt Is Nothing OrElse dt.Rows.Count = 0 Then
            MsgBox("No CSV data loaded for this grade type.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Using con As New MySqlConnection(connString)
            con.Open()

            Try
                For Each row As DataRow In dt.Rows

                    ' --- Detect Student ID ---
                    Dim studID As String = ""
                    If dt.Columns.Contains("Student ID") Then
                        studID = row("Student ID").ToString.Trim
                    ElseIf dt.Columns.Contains("Stud ID") Then
                        studID = row("Stud ID").ToString.Trim
                    End If

                    If studID = "" Then Continue For

                    ' 1) CHECK IF THE STUDENT ALREADY HAS A ROW IN GRADES TABLE
                    Dim existsQuery As String = "SELECT COUNT(*) FROM grades WHERE StudentID = @sid"
                    Dim exists As Integer

                    Using cmd As New MySqlCommand(existsQuery, con)
                        cmd.Parameters.AddWithValue("@sid", studID)
                        exists = CInt(cmd.ExecuteScalar())
                    End Using

                    ' 2) IF NO ROW → INSERT A BLANK ROW FIRST
                    If exists = 0 Then
                        Dim insertBlank As String =
                            "INSERT INTO grades (StudentID) VALUES (@sid)"
                        Using cmd As New MySqlCommand(insertBlank, con)
                            cmd.Parameters.AddWithValue("@sid", studID)
                            cmd.ExecuteNonQuery()
                        End Using
                    End If

                    ' 3) UPDATE WEEK COLUMNS BASED ON MIDTERM/FINALS IMPORT
                    For w As Integer = startWeek To endWeek

                        Dim col1 As String = "Week " & w
                        Dim col2 As String = "Week" & w
                        Dim gradeStr As String = ""

                        ' Accept both "Week1" and "Week 1"
                        If dt.Columns.Contains(col1) Then
                            gradeStr = row(col1).ToString.Trim
                        ElseIf dt.Columns.Contains(col2) Then
                            gradeStr = row(col2).ToString.Trim
                        Else
                            Continue For
                        End If

                        If gradeStr = "" Then Continue For

                        Dim grade As Decimal
                        If Not Decimal.TryParse(gradeStr, grade) Then Continue For

                        ' Update the specific Week column
                        Dim updateSql As String =
                            $"UPDATE grades SET Week{w} = @g WHERE StudentID = @sid"

                        Using cmd As New MySqlCommand(updateSql, con)
                            cmd.Parameters.AddWithValue("@g", grade)
                            cmd.Parameters.AddWithValue("@sid", studID)
                            cmd.ExecuteNonQuery()
                        End Using
                    Next
                Next

                MsgBox("Grades imported successfully!", MsgBoxStyle.Information)

            Catch ex As Exception
                MsgBox("Error saving grades: " & ex.Message, MsgBoxStyle.Critical)
            End Try

        End Using
    End Sub

    Public Sub RestoreDefaultMidGradeDGV()
        Fac_MidGrade_DGV.DataSource = Nothing
        Fac_MidGrade_DGV.AutoGenerateColumns = False
        Fac_MidGrade_DGV.Columns.Clear()

        ' Add columns based on expected data (e.g., from grades table or student info)
        Fac_MidGrade_DGV.Columns.Add(New DataGridViewTextBoxColumn() With {
                .Name = "studID_col",
                .HeaderText = "Student ID",
                .DataPropertyName = "StudentID",
                .Width = 100
            })
        Fac_MidGrade_DGV.Columns.Add(New DataGridViewTextBoxColumn() With {
                .Name = "studName_col",
                .HeaderText = "Student Name",
                .DataPropertyName = "StudentName",
                .Width = 150
            })
        ' Add Week columns (1-9) with fixed widths
        For i As Integer = 1 To 9
            Fac_MidGrade_DGV.Columns.Add(New DataGridViewTextBoxColumn() With {
                    .Name = "week" & i & "_col",
                    .HeaderText = "Week " & i,
                    .DataPropertyName = "Week" & i,
                    .Width = 80
                })
        Next
        StyleDGV(Fac_MidGrade_DGV)
    End Sub

    Public Sub RestoreDefaultFinGradeDGV()
        Fac_FinGrade_DGV.DataSource = Nothing
        Fac_FinGrade_DGV.AutoGenerateColumns = False
        Fac_FinGrade_DGV.Columns.Clear()

        Fac_FinGrade_DGV.Columns.Add(New DataGridViewTextBoxColumn() With {
                .Name = "studID_col",
                .HeaderText = "Student ID",
                .DataPropertyName = "StudentID",
                .Width = 100
            })
        Fac_FinGrade_DGV.Columns.Add(New DataGridViewTextBoxColumn() With {
                .Name = "studName_col",
                .HeaderText = "Student Name",
                .DataPropertyName = "StudentName",
                .Width = 150
            })
        ' Add Week columns (10-18) with fixed widths
        For i As Integer = 10 To 18
            Fac_FinGrade_DGV.Columns.Add(New DataGridViewTextBoxColumn() With {
                    .Name = "week" & i & "_col",
                    .HeaderText = "Week " & i,
                    .DataPropertyName = "Week" & i,
                    .Width = 80
                })
        Next
        StyleDGV(Fac_FinGrade_DGV)
    End Sub

    Public Sub StyleDGV(dgv As DataGridView)

        dgv.EnableHeadersVisualStyles = False
        dgv.BorderStyle = BorderStyle.None
        dgv.BackgroundColor = Color.White
        dgv.GridColor = Color.LightGray
        dgv.AllowUserToAddRows = False
        dgv.AllowUserToResizeRows = False
        dgv.AllowUserToOrderColumns = False
        dgv.RowHeadersVisible = False

        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.MidnightBlue
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgv.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv.ColumnHeadersHeight = 40

        dgv.DefaultCellStyle.Font = New Font("Segoe UI", 10)
        dgv.DefaultCellStyle.BackColor = Color.White
        dgv.DefaultCellStyle.ForeColor = Color.Black
        dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(224, 242, 253)
        dgv.DefaultCellStyle.SelectionForeColor = Color.Black
        dgv.DefaultCellStyle.Padding = New Padding(4)

        dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 248, 250)

        dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None

        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect

    End Sub

    Private Sub Fac_GSecSearch_btn_Click(sender As Object, e As EventArgs) Handles Fac_GSecSearch_btn.Click
        ' ----------------------------
        ' 1) Determine active grade panel
        ' ----------------------------
        Dim gradeDGV As DataGridView
        Dim startWeek As Integer
        Dim endWeek As Integer
        Dim evalColName As String

        If Fac_MidGrade_Panel.Visible Then
            gradeDGV = Fac_MidGrade_DGV
            startWeek = 1
            endWeek = 9
            evalColName = "Midterms_Eval"
        ElseIf Fac_FinGrade_Panel.Visible Then
            gradeDGV = Fac_FinGrade_DGV
            startWeek = 10
            endWeek = 18
            evalColName = "Finals_Eval"
        Else
            MessageBox.Show("No grade panel is active.")
            Exit Sub
        End If

        gradeDGV.AutoGenerateColumns = True ' Let DGV automatically generate columns

        ' ----------------------------
        ' 2) Get search keyword
        ' ----------------------------
        Dim k As String = Fac_GSecSearch_txt.Text.Trim()
        Dim fid As String = LogIn_Form.LoggedInUser

        If k = "" Then
            MessageBox.Show("Enter keyword to search.")
            Exit Sub
        End If

        ' ----------------------------
        ' 3) Build week column list
        ' ----------------------------
        Dim weekCols As New List(Of String)
        For wk As Integer = startWeek To endWeek
            weekCols.Add($"g.Week{wk}")
        Next
        Dim selectWeekCols As String = If(weekCols.Count > 0, ", " & String.Join(", ", weekCols), "")

        ' ----------------------------
        ' 4) Build SQL query including Eval column
        ' ----------------------------
        Dim sql As String =
        "SELECT s.StudentID,
                CONCAT(s.StudLName, ', ', s.StudFName, ' ', IFNULL(s.StudMName, '')) AS StudentName,
                p.ProgramName,
                s.StudSection,
                IFNULL(g." & evalColName & ", '') AS EvalGrade" & selectWeekCols & "
         FROM students s
         JOIN internship i ON i.StudentID = s.StudentID
         JOIN programs p ON p.ProgramID = s.ProgramID
         LEFT JOIN grades g ON g.StudentID = s.StudentID
         WHERE i.FacultyID = @fid
           AND (s.StudentID LIKE @k
             OR s.StudLName LIKE @k
             OR s.StudFName LIKE @k
             OR s.StudSection LIKE @k
             OR p.ProgramName LIKE @k)"

        ' ----------------------------
        ' 5) Fetch data
        ' ----------------------------
        Dim dt As DataTable = GetDataTable(sql,
        New Dictionary(Of String, Object) From {
            {"@fid", fid},
            {"@k", "%" & k & "%"}
        })

        ' ----------------------------
        ' 6) Replace NULL week grades with empty string
        ' ----------------------------
        For Each col As DataColumn In dt.Columns
            If col.ColumnName.StartsWith("Week") OrElse col.ColumnName = "EvalGrade" Then
                For Each row As DataRow In dt.Rows
                    If IsDBNull(row(col)) Then row(col) = ""
                Next
            End If
        Next

        ' ----------------------------
        ' 7) Bind to DataGridView
        ' ----------------------------
        gradeDGV.DataSource = dt

        ' ----------------------------
        ' 8) Refresh grade filters (optional)
        ' ----------------------------
        LoadGradeFilters()
    End Sub

End Class
