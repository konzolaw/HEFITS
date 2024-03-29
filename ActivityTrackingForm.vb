Imports Npgsql

Public Class ActivityTrackingForm
    Private ReadOnly loggedInUserID As Integer

    Public Sub New(userId As Integer)
        InitializeComponent()
        loggedInUserID = userId
    End Sub

    Private connectionString As String = "Host=localhost;Username=postgres;Password=pseudo-xkcdpg;Database=hefits;"

    ' Method to calculate calories based on the input values and update CaloriesTextBox
    Private Sub CalculateCalories()
        Dim duration As Integer
        Dim met As Double

        If Not Integer.TryParse(DurationComboBox.SelectedItem?.ToString(), duration) Then
            Return
        End If

        If Not Double.TryParse(METTextBox.Text, met) Then
            Return
        End If

        ' Calculate calories using the formula calories = MET * 70 * duration (assuming weight is 70 kg)
        Dim calories As Double = met * 70 * duration
        CaloriesTextBox.Text = calories.ToString()
    End Sub

    ' Event handlers for ComboBox and TextBox text changed events to calculate calories
    Private Sub DurationComboBox_TextChanged(sender As Object, e As EventArgs) Handles DurationComboBox.TextChanged
        CalculateCalories()
    End Sub

    Private Sub METTextBox_TextChanged(sender As Object, e As EventArgs) Handles METTextBox.TextChanged
        CalculateCalories()
    End Sub

    Private Sub ActivitytypeComboBox_TextChanged(sender As Object, e As EventArgs) Handles ActivitytypeComboBox.TextChanged
        CalculateCalories()
    End Sub

    ' Submit button click event to insert data into the database
    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        Try
            Using conn As New NpgsqlConnection(connectionString)
                conn.Open()

                ' Get the activity type from the ComboBox
                Dim activityType As String = ActivitytypeComboBox.SelectedItem?.ToString()

                ' Parse the duration value to ensure it is an integer
                Dim duration As Integer
                If Not Integer.TryParse(DurationComboBox.SelectedItem?.ToString(), duration) Then
                    MessageBox.Show("Invalid duration value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                ' Parse the MET value to ensure it is a double
                Dim met As Double
                If Not Double.TryParse(METTextBox.Text, met) Then
                    MessageBox.Show("Invalid MET value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                ' Parse the calories value to ensure it is a double
                Dim calories As Double
                If Not Double.TryParse(CaloriesTextBox.Text, calories) Then
                    MessageBox.Show("Invalid calories value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                ' Insert the activity log into the database
                Dim query As String = "INSERT INTO activitylog (userid, activitytype, duration, met, calories) VALUES (@userid, @activitytype, @duration, @met, @calories)"
                Using cmd As New NpgsqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@userid", loggedInUserID)
                    cmd.Parameters.AddWithValue("@activitytype", activityType)
                    cmd.Parameters.AddWithValue("@duration", duration)
                    cmd.Parameters.AddWithValue("@met", met)
                    cmd.Parameters.AddWithValue("@calories", calories)
                    cmd.ExecuteNonQuery()

                    DurationComboBox.SelectedIndex = -1
                    METTextBox.Clear()
                    CaloriesTextBox.Clear()
                    ActivitytypeComboBox.SelectedIndex = -1

                    ' Notify the user about the successful submission
                    MessageBox.Show("Activity logged successfully!", "HeFits", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error adding activity: " & ex.Message, "HeFits - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BackToDashboardButton_Click(sender As Object, e As EventArgs) Handles BackToDashboardButton.Click
        ' Return to the dashboard form
        Dim dashboardForm As New HeFitsDashBoardForm(loggedInUserID)
        dashboardForm.Show()
        Me.Close()
    End Sub
End Class
