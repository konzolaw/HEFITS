Imports Npgsql

Public Class LoginForm
    Private connectionString As String = "Host=localhost;Username=postgres;Password=pseudo-xkcdpg;Database=hefits;"

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Dim identifier As String = LoginIdentifierTextBox.Text
        Dim password As String = LoginPasswordMaskedTextBox.Text

        ' Validate input fields
        If String.IsNullOrWhiteSpace(identifier) OrElse String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Please enter your username/email and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Using conn As New NpgsqlConnection(connectionString)
                conn.Open()

                ' Check if the identifier is a username or an email
                Dim identifierType As String = "username"
                If identifier.Contains("@") Then
                    identifierType = "email"
                End If

                ' Query to check credentials
                Dim query As String = $"SELECT UserID FROM users WHERE {identifierType} = @identifier AND password = @password"
                Using cmd As New NpgsqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@identifier", identifier)
                    cmd.Parameters.AddWithValue("@password", password)
                    Dim userId As Object = cmd.ExecuteScalar()

                    If userId IsNot Nothing Then
                        ' Open the dashboard form or perform actions after successful login
                        Dim dashboardForm As New HeFitsDashBoardForm()
                        dashboardForm.Show()
                        Me.Hide() ' Optionally hide the login form
                    Else
                        MessageBox.Show("Invalid username/email or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoginPagePictureBox_Click(sender As Object, e As EventArgs) Handles LoginPagePictureBox.Click

    End Sub
    Private Sub SignupLinkLabel_Click(sender As Object, e As EventArgs) Handles SignupLinkLabel.Click
        ' Open the signup form when the signup link is clicked
        Dim signupForm As New SignupForm()
        signupForm.Show()
        Me.Hide() ' Optionally hide the login form
    End Sub


    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
