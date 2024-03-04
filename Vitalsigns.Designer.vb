<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Vitalsigns
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Vitalsigns))
        Label1 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        heartbeat_list = New ComboBox()
        bloodpressure_list = New ComboBox()
        weight_list = New ComboBox()
        Heartbeat_box = New Label()
        Bloodpressure_box = New Label()
        Weight_box = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Bernard MT Condensed", 16.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(39, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(168, 38)
        Label1.TabIndex = 0
        Label1.Text = "VITAL SIGNS"
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaption
        Button1.Font = New Font("Lucida Sans", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.Black
        Button1.Location = New Point(59, 399)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 1
        Button1.Text = "<<BACK"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ActiveCaption
        Button2.Font = New Font("Lucida Sans", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.Black
        Button2.Location = New Point(640, 396)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 34)
        Button2.TabIndex = 2
        Button2.Text = "NEXT>>"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' heartbeat_list
        ' 
        heartbeat_list.FormattingEnabled = True
        heartbeat_list.Items.AddRange(New Object() {"0-10", "10-20", "20-30", "30-40", "40-50", "50-60", "60-70", "70-80", "80-90", "90-100", "100-110", "110-ubnormal"})
        heartbeat_list.Location = New Point(337, 91)
        heartbeat_list.Name = "heartbeat_list"
        heartbeat_list.Size = New Size(182, 33)
        heartbeat_list.TabIndex = 3
        heartbeat_list.Text = "choose here>>"
        ' 
        ' bloodpressure_list
        ' 
        bloodpressure_list.FormattingEnabled = True
        bloodpressure_list.Items.AddRange(New Object() {"0-10", "10-20", "20-30", "30-40", "40-50", "50-60", "60-70", "70-80", "80-90", "90-100", "100-110", "110-120", "120-130", "130-140"})
        bloodpressure_list.Location = New Point(337, 160)
        bloodpressure_list.Name = "bloodpressure_list"
        bloodpressure_list.Size = New Size(182, 33)
        bloodpressure_list.TabIndex = 4
        bloodpressure_list.Text = "choose here>>"
        ' 
        ' weight_list
        ' 
        weight_list.FormattingEnabled = True
        weight_list.Items.AddRange(New Object() {"0 - 4", "5 - 9", "10 - 14", "15 - 19", "20 - 24", "25 - 29", "30 - 34", "35 - 39", "40 - 44", "45 - 49", "50 - 54", "55 - 59", "60 - 64", "65 - 69", "70 - 74", "75 - 79", "80 - 84", "85 - 89", "90 - 94", "95 - 99", "100 - 104", "105 - 109", "110 - 114", "115 - 119", "120 - 124", "125 - 129", "130 - 134", "135 - 139", "140 - 144", "145 - 149", "150 - 154", "155 - 159", "160 - 164", "165 - 169", "170 - 174", "175 - 179", "180 - 184", "185 - 189", "190 - 194", "195 - 199", "200"})
        weight_list.Location = New Point(337, 220)
        weight_list.Name = "weight_list"
        weight_list.Size = New Size(182, 33)
        weight_list.TabIndex = 5
        weight_list.Text = "choose here >>"
        ' 
        ' Heartbeat_box
        ' 
        Heartbeat_box.AutoSize = True
        Heartbeat_box.BackColor = Color.Transparent
        Heartbeat_box.Font = New Font("Lucida Sans Typewriter", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Heartbeat_box.ForeColor = SystemColors.ButtonFace
        Heartbeat_box.Location = New Point(12, 91)
        Heartbeat_box.Name = "Heartbeat_box"
        Heartbeat_box.Size = New Size(208, 21)
        Heartbeat_box.TabIndex = 6
        Heartbeat_box.Text = "Heart beat (bpm) :"
        ' 
        ' Bloodpressure_box
        ' 
        Bloodpressure_box.AutoSize = True
        Bloodpressure_box.BackColor = Color.Black
        Bloodpressure_box.Font = New Font("Lucida Sans Typewriter", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Bloodpressure_box.ForeColor = SystemColors.ButtonFace
        Bloodpressure_box.Location = New Point(12, 160)
        Bloodpressure_box.Name = "Bloodpressure_box"
        Bloodpressure_box.Size = New Size(252, 21)
        Bloodpressure_box.TabIndex = 7
        Bloodpressure_box.Text = "Blood pressure (mmHG):"
        ' 
        ' Weight_box
        ' 
        Weight_box.AutoSize = True
        Weight_box.BackColor = Color.Black
        Weight_box.Font = New Font("Lucida Sans Typewriter", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Weight_box.ForeColor = SystemColors.ButtonFace
        Weight_box.Location = New Point(12, 226)
        Weight_box.Name = "Weight_box"
        Weight_box.Size = New Size(164, 21)
        Weight_box.TabIndex = 8
        Weight_box.Text = "Weight in KG :"
        ' 
        ' Vitalsigns
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Weight_box)
        Controls.Add(Bloodpressure_box)
        Controls.Add(Heartbeat_box)
        Controls.Add(weight_list)
        Controls.Add(bloodpressure_list)
        Controls.Add(heartbeat_list)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Name = "Vitalsigns"
        Text = "Vital signs"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents heartbeat_list As ComboBox
    Friend WithEvents bloodpressure_list As ComboBox
    Friend WithEvents weight_list As ComboBox
    Friend WithEvents Heartbeat_box As Label
    Friend WithEvents Bloodpressure_box As Label
    Friend WithEvents Weight_box As Label

End Class
