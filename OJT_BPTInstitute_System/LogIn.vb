Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient
Class LogIn_Form
    Function IsStudent(username As String) As Boolean
        Return Regex.IsMatch(username, "^\d{2}-\d{4}$")   ' Example: 24-0001
    End Function

    Function IsFaculty(username As String) As Boolean
        Return Regex.IsMatch(username, "^F\d{3}$")        ' Example: F001
    End Function

    Private Sub Login_BTN_Click(sender As Object, e As EventArgs) Handles Login_BTN.Click
        Dim username As String = Name_Input.Text.Trim()
        Dim password As String = Pass_Input.Text.Trim()

        ' Temporary password check
        If password <> "1234" Then
            MessageBox.Show("Incorrect password. (Testing password is 1234)")
            Exit Sub
        End If

        If username = "" Then
            MessageBox.Show("Please enter a username.")
            Exit Sub
        End If

        Dim connString As String = "server=localhost;user id=root;password=;database=OJTDB_BPTInstitute;"
        Dim query As String = ""

        ' Determine type based on format
        If Regex.IsMatch(username, "^\d{2}-\d{4}$") Then
            ' STUDENT
            query = "SELECT StudentID FROM students WHERE StudentID=@id"

        ElseIf Regex.IsMatch(username, "^F\d{3}$") Then
            ' FACULTY
            query = "SELECT FacultyID FROM faculty WHERE FacultyID=@id"

        ElseIf Name_Input.Text = "admin" Then
            ' ADMIN (straightforward)
            Dim f As New Admin_Dashboard()
            f.Show()
            Me.Hide()
            Exit Sub
        Else
            MessageBox.Show("Invalid username format.")
            Exit Sub
        End If

        ' Query DB
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", username)
                    Dim result = cmd.ExecuteScalar()

                    If result IsNot Nothing Then
                        ' Redirect based on which pattern matched
                        If Regex.IsMatch(username, "^\d{2}-\d{4}$") Then
                            Dim f As New Student_Dashboard()
                            f.Show()
                            Me.Hide()

                        ElseIf Regex.IsMatch(username, "^F\d{3}$") Then
                            Dim f As New Faculty_Dashboard()
                            f.Show()
                            Me.Hide()

                        End If

                    Else
                        MessageBox.Show("No account found.")
                    End If
                End Using

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Exit_BTN_Click(sender As Object, e As EventArgs) Handles Exit_BTN.Click
        If MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNo, "EXIT") = vbYes Then
            End
        End If
    End Sub

    Private Sub ShowPass_BTN_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPass_BTN.CheckedChanged
        If ShowPass_BTN.Checked Then
            Pass_Input.UseSystemPasswordChar = False
        Else
            Pass_Input.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub LogIn_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
