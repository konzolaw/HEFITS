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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SignupForm))
        GroupBox1 = New GroupBox()
        SignupUsernameTextBox = New TextBox()
        Label3 = New Label()
        SignupPasswordMaskedTextBox = New MaskedTextBox()
        SignupEmailTextBox = New TextBox()
        SignupButton = New Button()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        GroupBox1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Gray
        GroupBox1.Controls.Add(PictureBox1)
        GroupBox1.Controls.Add(SignupUsernameTextBox)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(SignupPasswordMaskedTextBox)
        GroupBox1.Controls.Add(SignupEmailTextBox)
        GroupBox1.Controls.Add(SignupButton)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(879, 426)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        ' 
        ' SignupUsernameTextBox
        ' 
        SignupUsernameTextBox.Location = New Point(189, 98)
        SignupUsernameTextBox.Name = "SignupUsernameTextBox"
        SignupUsernameTextBox.Size = New Size(259, 31)
        SignupUsernameTextBox.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(64, 96)
        Label3.Name = "Label3"
        Label3.Size = New Size(95, 25)
        Label3.TabIndex = 5
        Label3.Text = "Username:"
        ' 
        ' SignupPasswordMaskedTextBox
        ' 
        SignupPasswordMaskedTextBox.Location = New Point(189, 148)
        SignupPasswordMaskedTextBox.Name = "SignupPasswordMaskedTextBox"
        SignupPasswordMaskedTextBox.Size = New Size(259, 31)
        SignupPasswordMaskedTextBox.TabIndex = 4
        ' 
        ' SignupEmailTextBox
        ' 
        SignupEmailTextBox.Location = New Point(189, 50)
        SignupEmailTextBox.Name = "SignupEmailTextBox"
        SignupEmailTextBox.Size = New Size(265, 31)
        SignupEmailTextBox.TabIndex = 3
        ' 
        ' SignupButton
        ' 
        SignupButton.BackColor = Color.Olive
        SignupButton.FlatStyle = FlatStyle.Popup
        SignupButton.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SignupButton.ForeColor = SystemColors.ActiveCaptionText
        SignupButton.Location = New Point(267, 243)
        SignupButton.Name = "SignupButton"
        SignupButton.Size = New Size(97, 50)
        SignupButton.TabIndex = 2
        SignupButton.Text = "Sign Up"
        SignupButton.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(70, 148)
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
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(517, 44)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(337, 356)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' SignupForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Silver
        ClientSize = New Size(903, 450)
        Controls.Add(GroupBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "SignupForm"
        Text = "SignupForm"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SignupButton As Button
    Friend WithEvents SignupPasswordMaskedTextBox As MaskedTextBox
    Friend WithEvents SignupEmailTextBox As TextBox
    Friend WithEvents SignupUsernameTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
