Public Class StartupForm
    Private Sub StartupForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub StartupButton_Click(sender As Object, e As EventArgs) Handles StartupButton.Click

        Dim dashboardForm As New HeFitsDashBoardForm()
        dashboardForm.Show()
    End Sub

    Private Sub ExitHeFitsButton_Click(sender As Object, e As EventArgs) Handles ExitHeFitsButton.Click
        ' terminate the application/welcome form
        Me.Close()
    End Sub
End Class
