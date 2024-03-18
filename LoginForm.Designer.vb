<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        LoginPasswordMaskedTextBox = New MaskedTextBox()
        LoginEmailTextBox = New TextBox()
        LoginButton = New Button()
        Label2 = New Label()
        Label1 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(LoginPasswordMaskedTextBox)
        GroupBox1.Controls.Add(LoginEmailTextBox)
        GroupBox1.Controls.Add(LoginButton)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(102, 55)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(597, 340)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        ' 
        ' LoginPasswordMaskedTextBox
        ' 
        LoginPasswordMaskedTextBox.Location = New Point(189, 119)
        LoginPasswordMaskedTextBox.Name = "LoginPasswordMaskedTextBox"
        LoginPasswordMaskedTextBox.Size = New Size(259, 31)
        LoginPasswordMaskedTextBox.TabIndex = 4
        ' 
        ' LoginEmailTextBox
        ' 
        LoginEmailTextBox.Location = New Point(189, 50)
        LoginEmailTextBox.Name = "LoginEmailTextBox"
        LoginEmailTextBox.Size = New Size(265, 31)
        LoginEmailTextBox.TabIndex = 3
        ' 
        ' LoginButton
        ' 
        LoginButton.Location = New Point(172, 264)
        LoginButton.Name = "LoginButton"
        LoginButton.Size = New Size(211, 49)
        LoginButton.TabIndex = 2
        LoginButton.Text = "Log In"
        LoginButton.UseVisualStyleBackColor = True
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
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(64, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(58, 25)
        Label1.TabIndex = 0
        Label1.Text = "Email:"
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox1)
        Name = "LoginForm"
        Text = "LoginForm"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LoginPasswordMaskedTextBox As MaskedTextBox
    Friend WithEvents LoginEmailTextBox As TextBox
    Friend WithEvents LoginButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
