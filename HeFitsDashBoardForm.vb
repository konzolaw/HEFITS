Public Class HeFitsDashBoardForm
    Private Sub ActivityTrackingButton_Click(sender As Object, e As EventArgs) Handles ActivityTrackingButton.Click
        ' Create an instance of the form
        Dim activityForm As New ActivityTrackingForm()

        activityForm.Show()
    End Sub

    Private Sub HeFitsDashBoardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub SettingsButton_Click(sender As Object, e As EventArgs) Handles SettingsButton.Click
        ' Create an instance of the form
        Dim settingForm As New SettingsForm()

        settingForm.Show()
    End Sub

    Private Sub BodyMeasurementsButton_Click(sender As Object, e As EventArgs) Handles BodyMeasurementsButton.Click
        ' Create an instance of the form
        Dim bodymeasurementsForm As New BodyMeasurementsForm()

        bodymeasurementsForm.Show()
    End Sub

    Private Sub GoalsProgressButton_Click(sender As Object, e As EventArgs) Handles GoalsProgressButton.Click
        ' Create an instance of the form
        Dim goalsprogressForm As New GoalsProgressForm()

        goalsprogressForm.Show()
    End Sub

    Private Sub BackToStartScreenButton_Click(sender As Object, e As EventArgs) Handles BackToStartScreenButton.Click
        ' go to start screen
        Me.Close()
    End Sub
End Class