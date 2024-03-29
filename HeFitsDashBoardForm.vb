Public Class HeFitsDashBoardForm
    Private ReadOnly loggedInUserID As Integer

    ' Constructor with parameter to accept the logged-in user's ID
    Public Sub New(userId As Integer)
        InitializeComponent()
        loggedInUserID = userId
    End Sub

    ' Button click event for activity tracking
    Private Sub ActivityTrackingButton_Click(sender As Object, e As EventArgs) Handles ActivityTrackingButton.Click
        ' Create an instance of the ActivityTrackingForm and pass the user ID
        Dim activityForm As New ActivityTrackingForm(loggedInUserID)

        activityForm.Show()

        ' Close the dashboard form
        Me.Close()
    End Sub

    ' Button click event for body measurements
    Private Sub BodyMeasurementsButton_Click(sender As Object, e As EventArgs) Handles BodyMeasurementsButton.Click
        ' Create an instance of the BodyMeasurementsForm and pass the user ID
        Dim bodyMeasurementsForm As New BodyMeasurementsForm(loggedInUserID)
        bodyMeasurementsForm.Show()

        ' Close the dashboard form
        Me.Close()
    End Sub

    ' Button click event for goals progress
    Private Sub GoalsProgressButton_Click(sender As Object, e As EventArgs) Handles GoalsProgressButton.Click
        ' Create an instance of the GoalsProgressForm and pass the user ID
        Dim goalsProgressForm As New GoalsProgressForm(loggedInUserID)
        goalsProgressForm.Show()

        ' Close the dashboard form
        Me.Close()
    End Sub

    ' Button click event for settings
    Private Sub SettingsButton_Click(sender As Object, e As EventArgs) Handles SettingsButton.Click
        ' Create an instance of the SettingsForm and pass the user ID
        Dim settingsForm As New SettingsForm(loggedInUserID)
        settingsForm.Show()

        ' Close the dashboard form
        Me.Close()
    End Sub
End Class
