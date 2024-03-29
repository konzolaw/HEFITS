<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActivityTrackingForm
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
        GroupBox3 = New GroupBox()
        SubmitButton = New Button()
        CaloriesTextBox = New TextBox()
        Label5 = New Label()
        METTextBox = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        BackToDashboardButton = New Button()
        ActivitytypeComboBox = New ComboBox()
        Label10 = New Label()
        DurationComboBox = New ComboBox()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(DurationComboBox)
        GroupBox3.Controls.Add(ActivitytypeComboBox)
        GroupBox3.Controls.Add(Label10)
        GroupBox3.Controls.Add(SubmitButton)
        GroupBox3.Controls.Add(CaloriesTextBox)
        GroupBox3.Controls.Add(Label5)
        GroupBox3.Controls.Add(METTextBox)
        GroupBox3.Controls.Add(Label3)
        GroupBox3.Controls.Add(Label4)
        GroupBox3.Location = New Point(48, 37)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(396, 358)
        GroupBox3.TabIndex = 1
        GroupBox3.TabStop = False
        GroupBox3.Text = "Activity:"
        ' 
        ' SubmitButton
        ' 
        SubmitButton.Location = New Point(120, 254)
        SubmitButton.Name = "SubmitButton"
        SubmitButton.Size = New Size(128, 36)
        SubmitButton.TabIndex = 14
        SubmitButton.Text = "Submit"
        SubmitButton.UseVisualStyleBackColor = True
        ' 
        ' CaloriesTextBox
        ' 
        CaloriesTextBox.Location = New Point(142, 183)
        CaloriesTextBox.Name = "CaloriesTextBox"
        CaloriesTextBox.Size = New Size(187, 31)
        CaloriesTextBox.TabIndex = 13
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(36, 183)
        Label5.Name = "Label5"
        Label5.Size = New Size(75, 25)
        Label5.TabIndex = 12
        Label5.Text = "calories:"
        ' 
        ' METTextBox
        ' 
        METTextBox.Location = New Point(142, 135)
        METTextBox.Name = "METTextBox"
        METTextBox.Size = New Size(187, 31)
        METTextBox.TabIndex = 11
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(38, 84)
        Label3.Name = "Label3"
        Label3.Size = New Size(83, 25)
        Label3.TabIndex = 8
        Label3.Text = "duration:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(36, 135)
        Label4.Name = "Label4"
        Label4.Size = New Size(50, 25)
        Label4.TabIndex = 9
        Label4.Text = "MET:"
        ' 
        ' BackToDashboardButton
        ' 
        BackToDashboardButton.Location = New Point(571, 421)
        BackToDashboardButton.Name = "BackToDashboardButton"
        BackToDashboardButton.Size = New Size(128, 36)
        BackToDashboardButton.TabIndex = 15
        BackToDashboardButton.Text = "<<<Back"
        BackToDashboardButton.UseVisualStyleBackColor = True
        ' 
        ' ActivitytypeComboBox
        ' 
        ActivitytypeComboBox.FormattingEnabled = True
        ActivitytypeComboBox.Items.AddRange(New Object() {"Running", "Weightlifting", "Cycling"})
        ActivitytypeComboBox.Location = New Point(142, 27)
        ActivitytypeComboBox.Name = "ActivitytypeComboBox"
        ActivitytypeComboBox.Size = New Size(182, 33)
        ActivitytypeComboBox.TabIndex = 20
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(38, 30)
        Label10.Name = "Label10"
        Label10.Size = New Size(51, 25)
        Label10.TabIndex = 18
        Label10.Text = "type:"
        ' 
        ' DurationComboBox
        ' 
        DurationComboBox.FormattingEnabled = True
        DurationComboBox.Items.AddRange(New Object() {"10", "15", "30", "45", "60"})
        DurationComboBox.Location = New Point(142, 81)
        DurationComboBox.Name = "DurationComboBox"
        DurationComboBox.Size = New Size(182, 33)
        DurationComboBox.TabIndex = 21
        ' 
        ' ActivityTrackingForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 541)
        Controls.Add(BackToDashboardButton)
        Controls.Add(GroupBox3)
        Name = "ActivityTrackingForm"
        Text = "ActivityTrackingForm"
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents METTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CaloriesTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents SubmitButton As Button
    Friend WithEvents BackToDashboardButton As Button
    Friend WithEvents ActivitytypeComboBox As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents DurationComboBox As ComboBox
End Class
