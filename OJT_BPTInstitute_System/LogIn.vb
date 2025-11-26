Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class LogIn_Form

    ' Hash function (SHA-256)
    Private Function HashPassword(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes() As Byte = Encoding.UTF8.GetBytes(password)
            Dim hash() As Byte = sha256.ComputeHash(bytes)
            Dim sb As New StringBuilder()
            For Each b As Byte In hash
                sb.Append(b.ToString("x2"))
            Next
            Return sb.ToString()
        End Using
    End Function

    Private Sub Login_BTN_Click(sender As Object, e As EventArgs) Handles Login_BTN.Click
        Dim username As String = Name_Input.Text.Trim()
        Dim password As String = Pass_Input.Text.Trim()

        If username = "" Then
            MessageBox.Show("Please enter a username.")
            Exit Sub
        End If

        If password = "" Then
            MessageBox.Show("Please enter a password.")
            Exit Sub
        End If

        ' Hash the entered password
        Dim hashedPassword As String = HashPassword(password)

        ' Query Users table
        Dim query As String = "SELECT UserType FROM Users WHERE Username=@username AND PasswordHash=@password"

        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", hashedPassword)

                    Dim result As Object = cmd.ExecuteScalar()

                    If result IsNot Nothing Then
                        Dim userType As String = result.ToString()

                        Select Case userType
                            Case "Student"
                                Dim f As New Student_Dashboard
                                f.Show()
                            Case "Faculty"
                                Dim f As New Faculty_Dashboard
                                f.Show()
                            Case "Admin"
                                Dim f As New Admin_Dashboard
                                f.Show()
                        End Select

                        Me.Hide()
                    Else
                        MessageBox.Show("Invalid username or password.")
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
        Pass_Input.UseSystemPasswordChar = Not ShowPass_BTN.Checked
    End Sub

End Class
