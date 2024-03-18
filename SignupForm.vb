Public Class SignupForm
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub SignupButton_Click(sender As Object, e As EventArgs) Handles SignupButton.Click
        ' Create an instance of the LoginForm
        Dim loginForm As New LoginForm()

        ' Show the LoginForm
        loginForm.Show()

        ' Optionally, hide the current form
        ' Me.Hide()
    End Sub

    Private Sub SignupPasswordMaskedTextBox_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles SignupPasswordMaskedTextBox.MaskInputRejected

    End Sub

    Private Sub SignupEmailTextBox_TextChanged(sender As Object, e As EventArgs) Handles SignupEmailTextBox.TextChanged

    End Sub
End Class
