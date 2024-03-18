<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignupForm
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
        Label1 = New Label()
        Label2 = New Label()
        SignupButton = New Button()
        SignupEmailTextBox = New TextBox()
        SignupPasswordMaskedTextBox = New MaskedTextBox()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(SignupPasswordMaskedTextBox)
        GroupBox1.Controls.Add(SignupEmailTextBox)
        GroupBox1.Controls.Add(SignupButton)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(92, 42)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(597, 340)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(64, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(58, 25)
        Label1.TabIndex = 0
        Label1.Text = "Email:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(64, 119)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 25)
        Label2.TabIndex = 1
        Label2.Text = "Password:"
        ' 
        ' SignupButton
        ' 
        SignupButton.Location = New Point(172, 264)
        SignupButton.Name = "SignupButton"
        SignupButton.Size = New Size(211, 49)
        SignupButton.TabIndex = 2
        SignupButton.Text = "Sign Up"
        SignupButton.UseVisualStyleBackColor = True
        ' 
        ' SignupEmailTextBox
        ' 
        SignupEmailTextBox.Location = New Point(189, 50)
        SignupEmailTextBox.Name = "SignupEmailTextBox"
        SignupEmailTextBox.Size = New Size(265, 31)
        SignupEmailTextBox.TabIndex = 3
        ' 
        ' SignupPasswordMaskedTextBox
        ' 
        SignupPasswordMaskedTextBox.Location = New Point(189, 119)
        SignupPasswordMaskedTextBox.Name = "SignupPasswordMaskedTextBox"
        SignupPasswordMaskedTextBox.Size = New Size(259, 31)
        SignupPasswordMaskedTextBox.TabIndex = 4
        ' 
        ' SignupForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox1)
        Name = "SignupForm"
        Text = "SignupForm"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SignupButton As Button
    Friend WithEvents SignupPasswordMaskedTextBox As MaskedTextBox
    Friend WithEvents SignupEmailTextBox As TextBox
End Class
