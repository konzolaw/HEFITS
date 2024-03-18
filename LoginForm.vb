Public Class LoginForm
    Private Sub LoginEmailTextBox_TextChanged(sender As Object, e As EventArgs) Handles LoginEmailTextBox.TextChanged

    End Sub

    Private Sub LoginPasswordMaskedTextBox_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles LoginPasswordMaskedTextBox.MaskInputRejected

    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Dim dashboardForm As New HeFitsDashBoardForm()
        dashboardForm.Show()
        ' Me.Hide()
    End Sub
End Class
