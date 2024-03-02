<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StartupForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        GroupBox1 = New GroupBox()
        Label1 = New Label()
        Label2 = New Label()
        StartupButton = New Button()
        ExitHeFitsButton = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.ButtonShadow
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(198, 24)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(375, 149)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Bernard MT Condensed", 16.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(62, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(275, 38)
        Label1.TabIndex = 0
        Label1.Text = "WELCOME TO HeFits "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(82, 91)
        Label2.Name = "Label2"
        Label2.Size = New Size(217, 21)
        Label2.TabIndex = 1
        Label2.Text = "Your Path to Peak Health!"
        ' 
        ' StartupButton
        ' 
        StartupButton.BackColor = Color.LawnGreen
        StartupButton.Location = New Point(240, 412)
        StartupButton.Name = "StartupButton"
        StartupButton.Size = New Size(184, 61)
        StartupButton.TabIndex = 3
        StartupButton.Text = "Get Started"
        StartupButton.UseVisualStyleBackColor = False
        ' 
        ' ExitHeFitsButton
        ' 
        ExitHeFitsButton.BackColor = Color.DarkRed
        ExitHeFitsButton.ForeColor = SystemColors.ButtonFace
        ExitHeFitsButton.Location = New Point(696, 413)
        ExitHeFitsButton.Name = "ExitHeFitsButton"
        ExitHeFitsButton.Size = New Size(77, 60)
        ExitHeFitsButton.TabIndex = 4
        ExitHeFitsButton.Text = "Close"
        ExitHeFitsButton.UseVisualStyleBackColor = False
        ' 
        ' StartupForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 500)
        Controls.Add(ExitHeFitsButton)
        Controls.Add(StartupButton)
        Controls.Add(GroupBox1)
        Name = "StartupForm"
        Text = "HeFits App"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents StartupButton As Button
    Friend WithEvents ExitHeFitsButton As Button

End Class
