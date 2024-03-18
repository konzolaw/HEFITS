<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        GroupBox1 = New GroupBox()
        BackToSignupButton = New Button()
        BackToDashboardButton = New Button()
        TextBox1 = New TextBox()
        ProfilePictureBox = New PictureBox()
        GroupBox1.SuspendLayout()
        CType(ProfilePictureBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(BackToSignupButton)
        GroupBox1.Controls.Add(BackToDashboardButton)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(ProfilePictureBox)
        GroupBox1.Location = New Point(58, 41)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(659, 366)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "SETTINGS:"
        ' 
        ' BackToSignupButton
        ' 
        BackToSignupButton.Location = New Point(519, 305)
        BackToSignupButton.Name = "BackToSignupButton"
        BackToSignupButton.Size = New Size(112, 34)
        BackToSignupButton.TabIndex = 3
        BackToSignupButton.Text = "Log Out"
        BackToSignupButton.UseVisualStyleBackColor = True
        ' 
        ' BackToDashboardButton
        ' 
        BackToDashboardButton.Location = New Point(21, 305)
        BackToDashboardButton.Name = "BackToDashboardButton"
        BackToDashboardButton.Size = New Size(112, 34)
        BackToDashboardButton.TabIndex = 2
        BackToDashboardButton.Text = "<<< Back"
        BackToDashboardButton.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(434, 87)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(197, 31)
        TextBox1.TabIndex = 1
        ' 
        ' ProfilePictureBox
        ' 
        ProfilePictureBox.Location = New Point(517, 12)
        ProfilePictureBox.Name = "ProfilePictureBox"
        ProfilePictureBox.Size = New Size(114, 69)
        ProfilePictureBox.TabIndex = 0
        ProfilePictureBox.TabStop = False
        ' 
        ' SettingsForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox1)
        Name = "SettingsForm"
        Text = "SettingsForm"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(ProfilePictureBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BackToSignupButton As Button
    Friend WithEvents BackToDashboardButton As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ProfilePictureBox As PictureBox
End Class
