<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GoalsProgressForm
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
        TextBox1 = New TextBox()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        Label2 = New Label()
        BackToDashboardButton = New Button()
        GoalsProgressSubmitButton = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(GoalsProgressSubmitButton)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(59, 36)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(650, 136)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "GOALS AND PROGRESS:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(218, 58)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(219, 31)
        TextBox1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(16, 64)
        Label1.Name = "Label1"
        Label1.Size = New Size(156, 25)
        Label1.TabIndex = 0
        Label1.Text = "Weight goal in kg:"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Location = New Point(59, 223)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(564, 215)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "MONTHLY PROGRESS:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(159, 81)
        Label2.Name = "Label2"
        Label2.Size = New Size(174, 25)
        Label2.TabIndex = 0
        Label2.Text = "DRAW GRAPH HERE"
        ' 
        ' BackToDashboardButton
        ' 
        BackToDashboardButton.Location = New Point(670, 354)
        BackToDashboardButton.Name = "BackToDashboardButton"
        BackToDashboardButton.Size = New Size(102, 57)
        BackToDashboardButton.TabIndex = 2
        BackToDashboardButton.Text = "<<< Back"
        BackToDashboardButton.UseVisualStyleBackColor = True
        ' 
        ' GoalsProgressSubmitButton
        ' 
        GoalsProgressSubmitButton.Location = New Point(500, 50)
        GoalsProgressSubmitButton.Name = "GoalsProgressSubmitButton"
        GoalsProgressSubmitButton.Size = New Size(102, 47)
        GoalsProgressSubmitButton.TabIndex = 3
        GoalsProgressSubmitButton.Text = "Submit"
        GoalsProgressSubmitButton.UseVisualStyleBackColor = True
        ' 
        ' GoalsProgressForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(BackToDashboardButton)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "GoalsProgressForm"
        Text = "GoalsProgressForm"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BackToDashboardButton As Button
    Friend WithEvents GoalsProgressSubmitButton As Button
End Class
