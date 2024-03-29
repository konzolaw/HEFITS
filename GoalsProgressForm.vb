Public Class GoalsProgressForm
    Private ReadOnly loggedInUserID As Integer

    Public Sub New(userId As Integer)
        InitializeComponent()
        loggedInUserID = userId
    End Sub

    ' Add your code for the goals progress form here

    Private Sub BackToDashboardButton_Click(sender As Object, e As EventArgs) Handles BackToDashboardButton.Click
        ' Go back to the dashboard form
        Dim dashboardForm As New HeFitsDashBoardForm(loggedInUserID)
        dashboardForm.Show()
        Me.Close()
    End Sub
End Class
