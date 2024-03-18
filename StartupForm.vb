Public Class StartupForm
    Private Sub StartupForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Load the image
            Dim imagePath As String = System.IO.Path.Combine(Application.StartupPath, "img\HeFitsLogo.jpg")
            Dim image As Image = Image.FromFile(imagePath)

            ' Set the PictureBox properties
            LogoPictureBox.SizeMode = PictureBoxSizeMode.Zoom
            LogoPictureBox.Image = image
        Catch ex As Exception
            ' Handle any exceptions
            MessageBox.Show("Error loading image: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub StartupButton_Click(sender As Object, e As EventArgs) Handles StartupButton.Click
        ' Create an instance of the signupForm
        Dim signupForm As New SignupForm()

        ' Show the signupForm
        signupForm.Show()

        ' Optionally, hide the current form
        ' Me.Hide()
    End Sub

    Private Sub ExitHeFitsButton_Click(sender As Object, e As EventArgs) Handles ExitHeFitsButton.Click
        ' terminate the application/welcome form
        Me.Close()
    End Sub

    Private Sub LogoPictureBox_Click(sender As Object, e As EventArgs) Handles LogoPictureBox.Click

    End Sub
End Class
