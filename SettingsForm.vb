'Public Class SettingsForm

'    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter
'        ' jhnccj
'    End Sub

'    Private Sub SettingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        Try
'            ' Load the image
'            Dim imagePath As String = System.IO.Path.Combine(Application.StartupPath, "img\profilepicture.jpg")
'            Dim image As Image = Image.FromFile(imagePath)

'            ' Set the PictureBox properties
'            ProfilePictureBox.SizeMode = PictureBoxSizeMode.Zoom
'            ProfilePictureBox.Image = image
'        Catch ex As Exception
'            ' Handle any exceptions
'            MessageBox.Show("Error loading image: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'        End Try
'    End Sub

'    Private Sub BackToSignupButton_Click(sender As Object, e As EventArgs) Handles BackToSignupButton.Click
'        ' Create an instance of the form
'        Dim signupForm As New SignupForm()

'        signupForm.Show()
'        ' HeFitsDashBoardForm.Close() - find soln;
'        Me.Close()

'    End Sub
'End Class

Public Class SettingsForm
    Private ReadOnly loggedInUserID As Integer

    Public Sub New(userId As Integer)
        InitializeComponent()
        loggedInUserID = userId
    End Sub

    ' Add your code for the settings form here

    Private Sub BackToDashboardButton_Click(sender As Object, e As EventArgs) Handles BackToDashboardButton.Click
        ' Go back to the dashboard form
        Dim dashboardForm As New HeFitsDashBoardForm(loggedInUserID)
        dashboardForm.Show()
        Me.Close()
    End Sub
End Class
