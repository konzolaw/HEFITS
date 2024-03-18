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
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        GroupBox3 = New GroupBox()
        Label1 = New Label()
        Label2 = New Label()
        CyclingDurationTextBox = New TextBox()
        CyclingCaloriesTextBox = New TextBox()
        TreadmillCaloriesTextBox = New TextBox()
        TreadmillDurationTextBox = New TextBox()
        Label7 = New Label()
        Label8 = New Label()
        WeightLiftingMETTextBox = New TextBox()
        WeightLiftingDurationTextBox = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        WeightLiftingCaloriesTextBox = New TextBox()
        Label5 = New Label()
        WeightLiftingSubmitButton = New Button()
        TreadmillSubmitButton = New Button()
        CyclingSubmitButton = New Button()
        BackToDashboardButton = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(CyclingSubmitButton)
        GroupBox1.Controls.Add(CyclingCaloriesTextBox)
        GroupBox1.Controls.Add(CyclingDurationTextBox)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(39, 35)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(294, 182)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Cycling:"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(TreadmillSubmitButton)
        GroupBox2.Controls.Add(TreadmillCaloriesTextBox)
        GroupBox2.Controls.Add(TreadmillDurationTextBox)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Location = New Point(440, 44)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(294, 173)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Treadmill:"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(WeightLiftingSubmitButton)
        GroupBox3.Controls.Add(WeightLiftingCaloriesTextBox)
        GroupBox3.Controls.Add(Label5)
        GroupBox3.Controls.Add(WeightLiftingMETTextBox)
        GroupBox3.Controls.Add(WeightLiftingDurationTextBox)
        GroupBox3.Controls.Add(Label3)
        GroupBox3.Controls.Add(Label4)
        GroupBox3.Location = New Point(39, 233)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(299, 224)
        GroupBox3.TabIndex = 1
        GroupBox3.TabStop = False
        GroupBox3.Text = "Weight Lifting:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(24, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(83, 25)
        Label1.TabIndex = 0
        Label1.Text = "duration:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(22, 73)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 25)
        Label2.TabIndex = 1
        Label2.Text = "calories:"
        ' 
        ' CyclingDurationTextBox
        ' 
        CyclingDurationTextBox.Location = New Point(128, 30)
        CyclingDurationTextBox.Name = "CyclingDurationTextBox"
        CyclingDurationTextBox.Size = New Size(121, 31)
        CyclingDurationTextBox.TabIndex = 2
        ' 
        ' CyclingCaloriesTextBox
        ' 
        CyclingCaloriesTextBox.Location = New Point(128, 73)
        CyclingCaloriesTextBox.Name = "CyclingCaloriesTextBox"
        CyclingCaloriesTextBox.Size = New Size(121, 31)
        CyclingCaloriesTextBox.TabIndex = 3
        ' 
        ' TreadmillCaloriesTextBox
        ' 
        TreadmillCaloriesTextBox.Location = New Point(131, 70)
        TreadmillCaloriesTextBox.Name = "TreadmillCaloriesTextBox"
        TreadmillCaloriesTextBox.Size = New Size(121, 31)
        TreadmillCaloriesTextBox.TabIndex = 7
        ' 
        ' TreadmillDurationTextBox
        ' 
        TreadmillDurationTextBox.Location = New Point(131, 33)
        TreadmillDurationTextBox.Name = "TreadmillDurationTextBox"
        TreadmillDurationTextBox.Size = New Size(121, 31)
        TreadmillDurationTextBox.TabIndex = 6
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(25, 70)
        Label7.Name = "Label7"
        Label7.Size = New Size(75, 25)
        Label7.TabIndex = 5
        Label7.Text = "calories:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(27, 33)
        Label8.Name = "Label8"
        Label8.Size = New Size(83, 25)
        Label8.TabIndex = 4
        Label8.Text = "duration:"
        ' 
        ' WeightLiftingMETTextBox
        ' 
        WeightLiftingMETTextBox.Location = New Point(138, 77)
        WeightLiftingMETTextBox.Name = "WeightLiftingMETTextBox"
        WeightLiftingMETTextBox.Size = New Size(121, 31)
        WeightLiftingMETTextBox.TabIndex = 11
        ' 
        ' WeightLiftingDurationTextBox
        ' 
        WeightLiftingDurationTextBox.Location = New Point(138, 40)
        WeightLiftingDurationTextBox.Name = "WeightLiftingDurationTextBox"
        WeightLiftingDurationTextBox.Size = New Size(121, 31)
        WeightLiftingDurationTextBox.TabIndex = 10
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(34, 40)
        Label3.Name = "Label3"
        Label3.Size = New Size(83, 25)
        Label3.TabIndex = 8
        Label3.Text = "duration:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(32, 77)
        Label4.Name = "Label4"
        Label4.Size = New Size(50, 25)
        Label4.TabIndex = 9
        Label4.Text = "MET:"
        ' 
        ' WeightLiftingCaloriesTextBox
        ' 
        WeightLiftingCaloriesTextBox.Location = New Point(138, 114)
        WeightLiftingCaloriesTextBox.Name = "WeightLiftingCaloriesTextBox"
        WeightLiftingCaloriesTextBox.Size = New Size(121, 31)
        WeightLiftingCaloriesTextBox.TabIndex = 13
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(32, 114)
        Label5.Name = "Label5"
        Label5.Size = New Size(75, 25)
        Label5.TabIndex = 12
        Label5.Text = "calories:"
        ' 
        ' WeightLiftingSubmitButton
        ' 
        WeightLiftingSubmitButton.Location = New Point(93, 171)
        WeightLiftingSubmitButton.Name = "WeightLiftingSubmitButton"
        WeightLiftingSubmitButton.Size = New Size(128, 36)
        WeightLiftingSubmitButton.TabIndex = 14
        WeightLiftingSubmitButton.Text = "Submit"
        WeightLiftingSubmitButton.UseVisualStyleBackColor = True
        ' 
        ' TreadmillSubmitButton
        ' 
        TreadmillSubmitButton.Location = New Point(79, 123)
        TreadmillSubmitButton.Name = "TreadmillSubmitButton"
        TreadmillSubmitButton.Size = New Size(128, 36)
        TreadmillSubmitButton.TabIndex = 15
        TreadmillSubmitButton.Text = "Submit"
        TreadmillSubmitButton.UseVisualStyleBackColor = True
        ' 
        ' CyclingSubmitButton
        ' 
        CyclingSubmitButton.Location = New Point(82, 132)
        CyclingSubmitButton.Name = "CyclingSubmitButton"
        CyclingSubmitButton.Size = New Size(128, 36)
        CyclingSubmitButton.TabIndex = 15
        CyclingSubmitButton.Text = "Submit"
        CyclingSubmitButton.UseVisualStyleBackColor = True
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
        ' ActivityTrackingForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 501)
        Controls.Add(BackToDashboardButton)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "ActivityTrackingForm"
        Text = "ActivityTrackingForm"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CyclingCaloriesTextBox As TextBox
    Friend WithEvents CyclingDurationTextBox As TextBox
    Friend WithEvents TreadmillCaloriesTextBox As TextBox
    Friend WithEvents TreadmillDurationTextBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents WeightLiftingMETTextBox As TextBox
    Friend WithEvents WeightLiftingDurationTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents WeightLiftingCaloriesTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents WeightLiftingSubmitButton As Button
    Friend WithEvents TreadmillSubmitButton As Button
    Friend WithEvents CyclingSubmitButton As Button
    Friend WithEvents BackToDashboardButton As Button
End Class
