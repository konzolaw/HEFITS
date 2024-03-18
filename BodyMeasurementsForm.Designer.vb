<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BodyMeasurementsForm
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
        BodyMeasurementsSubmitButton = New Button()
        Label3 = New Label()
        TextBox3 = New TextBox()
        Label2 = New Label()
        TextBox2 = New TextBox()
        Label1 = New Label()
        TextBox1 = New TextBox()
        BackToDashboardButton = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(BodyMeasurementsSubmitButton)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Location = New Point(60, 60)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(584, 317)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "BODY MEASUREMENTS:"
        ' 
        ' BodyMeasurementsSubmitButton
        ' 
        BodyMeasurementsSubmitButton.Location = New Point(155, 242)
        BodyMeasurementsSubmitButton.Name = "BodyMeasurementsSubmitButton"
        BodyMeasurementsSubmitButton.Size = New Size(136, 39)
        BodyMeasurementsSubmitButton.TabIndex = 6
        BodyMeasurementsSubmitButton.Text = "Submit"
        BodyMeasurementsSubmitButton.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(190, 170)
        Label3.Name = "Label3"
        Label3.Size = New Size(47, 25)
        Label3.TabIndex = 5
        Label3.Text = "BMI:"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(278, 164)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(150, 31)
        TextBox3.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(85, 101)
        Label2.Name = "Label2"
        Label2.Size = New Size(152, 25)
        Label2.TabIndex = 3
        Label2.Text = " Height in metres:"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(278, 95)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(150, 31)
        TextBox2.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(78, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(159, 25)
        Label1.TabIndex = 1
        Label1.Text = "Body weight in kg:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(278, 41)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(150, 31)
        TextBox1.TabIndex = 0
        ' 
        ' BackToDashboardButton
        ' 
        BackToDashboardButton.Location = New Point(578, 383)
        BackToDashboardButton.Name = "BackToDashboardButton"
        BackToDashboardButton.Size = New Size(114, 55)
        BackToDashboardButton.TabIndex = 7
        BackToDashboardButton.Text = "<<< Back"
        BackToDashboardButton.UseVisualStyleBackColor = True
        ' 
        ' BodyMeasurementsForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(736, 450)
        Controls.Add(BackToDashboardButton)
        Controls.Add(GroupBox1)
        Name = "BodyMeasurementsForm"
        Text = "BodyMeasurementsForm"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BodyMeasurementsSubmitButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BackToDashboardButton As Button
End Class
