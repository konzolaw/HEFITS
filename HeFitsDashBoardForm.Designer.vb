<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HeFitsDashBoardForm
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
        Label2 = New Label()
        Label1 = New Label()
        GoalsProgressButton = New Button()
        SettingsButton = New Button()
        BodyMeasurementsButton = New Button()
        ActivityTrackingButton = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Font = New Font("Bernard MT Condensed", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(33, 24)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(423, 175)
        GroupBox1.TabIndex = 6
        GroupBox1.TabStop = False
        GroupBox1.Text = "DASHBOARD"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BorderStyle = BorderStyle.Fixed3D
        Label2.Font = New Font("Lucida Sans Typewriter", 13F)
        Label2.Location = New Point(6, 113)
        Label2.Name = "Label2"
        Label2.Size = New Size(255, 31)
        Label2.TabIndex = 1
        Label2.Text = "Upcoming goals:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BorderStyle = BorderStyle.Fixed3D
        Label1.Font = New Font("Lucida Sans Typewriter", 13F)
        Label1.Location = New Point(6, 71)
        Label1.Name = "Label1"
        Label1.Size = New Size(287, 31)
        Label1.TabIndex = 0
        Label1.Text = "Today's Progress:"
        ' 
        ' GoalsProgressButton
        ' 
        GoalsProgressButton.BackColor = SystemColors.InactiveCaption
        GoalsProgressButton.ForeColor = Color.Blue
        GoalsProgressButton.Location = New Point(497, 320)
        GoalsProgressButton.Name = "GoalsProgressButton"
        GoalsProgressButton.Size = New Size(215, 34)
        GoalsProgressButton.TabIndex = 4
        GoalsProgressButton.Text = "Goals/Progress"
        GoalsProgressButton.TextAlign = ContentAlignment.MiddleLeft
        GoalsProgressButton.UseVisualStyleBackColor = False
        ' 
        ' SettingsButton
        ' 
        SettingsButton.BackColor = SystemColors.InactiveCaption
        SettingsButton.ForeColor = Color.Blue
        SettingsButton.Location = New Point(497, 205)
        SettingsButton.Name = "SettingsButton"
        SettingsButton.Size = New Size(215, 34)
        SettingsButton.TabIndex = 5
        SettingsButton.Text = "Settings"
        SettingsButton.TextAlign = ContentAlignment.MiddleLeft
        SettingsButton.UseVisualStyleBackColor = False
        ' 
        ' BodyMeasurementsButton
        ' 
        BodyMeasurementsButton.BackColor = SystemColors.InactiveCaption
        BodyMeasurementsButton.ForeColor = Color.Blue
        BodyMeasurementsButton.Location = New Point(33, 320)
        BodyMeasurementsButton.Name = "BodyMeasurementsButton"
        BodyMeasurementsButton.Size = New Size(215, 34)
        BodyMeasurementsButton.TabIndex = 2
        BodyMeasurementsButton.Text = "Body Measurements"
        BodyMeasurementsButton.TextAlign = ContentAlignment.MiddleLeft
        BodyMeasurementsButton.UseVisualStyleBackColor = False
        ' 
        ' ActivityTrackingButton
        ' 
        ActivityTrackingButton.BackColor = SystemColors.InactiveCaption
        ActivityTrackingButton.ForeColor = Color.Blue
        ActivityTrackingButton.Location = New Point(33, 205)
        ActivityTrackingButton.Name = "ActivityTrackingButton"
        ActivityTrackingButton.Size = New Size(215, 34)
        ActivityTrackingButton.TabIndex = 0
        ActivityTrackingButton.Text = "Activity Tracking"
        ActivityTrackingButton.TextAlign = ContentAlignment.MiddleLeft
        ActivityTrackingButton.UseVisualStyleBackColor = False
        ' 
        ' HeFitsDashBoardForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(745, 411)
        Controls.Add(GroupBox1)
        Controls.Add(SettingsButton)
        Controls.Add(GoalsProgressButton)
        Controls.Add(BodyMeasurementsButton)
        Controls.Add(ActivityTrackingButton)
        Name = "HeFitsDashBoardForm"
        Text = "HeFits App :)"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents NutritionButton As Button
    Friend WithEvents VitalSignsButton As Button
    Friend WithEvents FeedbackButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents WellnessInsightsButton As Button
    Friend WithEvents GoalsProgressButton As Button
    Friend WithEvents SettingsButton As Button
    Friend WithEvents BodyMeasurementsButton As Button
    Friend WithEvents ActivityTrackingButton As Button
End Class
