<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.WarriorBox = New System.Windows.Forms.CheckBox()
        Me.UnBox = New System.Windows.Forms.CheckBox()
        Me.RogueBox = New System.Windows.Forms.CheckBox()
        Me.MageBox = New System.Windows.Forms.CheckBox()
        Me.TactBox = New System.Windows.Forms.CheckBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Updater = New System.Windows.Forms.Timer(Me.components)
        Me.ResetTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(335, 311)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 64)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Pick your first skill!"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 336)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 39)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Exit" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(283, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(134, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Our new hero is named..."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(405, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "The fates allow you to pick one specialization, hero. Make it worth while."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(139, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(14, 15)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(139, 181)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(14, 15)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(139, 196)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(14, 15)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(90, 166)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(22, 15)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Str"
        Me.ToolTip1.SetToolTip(Me.Label7, "Character physical strength")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(90, 181)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 15)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Agi"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(90, 196)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(28, 15)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Con"
        '
        'WarriorBox
        '
        Me.WarriorBox.Appearance = System.Windows.Forms.Appearance.Button
        Me.WarriorBox.AutoSize = True
        Me.WarriorBox.Location = New System.Drawing.Point(74, 86)
        Me.WarriorBox.Name = "WarriorBox"
        Me.WarriorBox.Size = New System.Drawing.Size(62, 25)
        Me.WarriorBox.TabIndex = 22
        Me.WarriorBox.Text = "Warrior"
        Me.ToolTip1.SetToolTip(Me.WarriorBox, """You have the mark of a warrior, and youre not afraid to show off your skill in f" & _
        "ighting. The majority of your skill is put to the test with weapons and attack d" & _
        "amage.""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.WarriorBox.UseVisualStyleBackColor = True
        '
        'UnBox
        '
        Me.UnBox.Appearance = System.Windows.Forms.Appearance.Button
        Me.UnBox.AutoSize = True
        Me.UnBox.Location = New System.Drawing.Point(323, 86)
        Me.UnBox.Name = "UnBox"
        Me.UnBox.Size = New System.Drawing.Size(58, 25)
        Me.UnBox.TabIndex = 23
        Me.UnBox.Text = "Unborn"
        Me.ToolTip1.SetToolTip(Me.UnBox, resources.GetString("UnBox.ToolTip"))
        Me.UnBox.UseVisualStyleBackColor = True
        '
        'RogueBox
        '
        Me.RogueBox.Appearance = System.Windows.Forms.Appearance.Button
        Me.RogueBox.AutoSize = True
        Me.RogueBox.Location = New System.Drawing.Point(267, 86)
        Me.RogueBox.Name = "RogueBox"
        Me.RogueBox.Size = New System.Drawing.Size(50, 25)
        Me.RogueBox.TabIndex = 24
        Me.RogueBox.Text = "Rogue"
        Me.ToolTip1.SetToolTip(Me.RogueBox, resources.GetString("RogueBox.ToolTip"))
        Me.RogueBox.UseVisualStyleBackColor = True
        '
        'MageBox
        '
        Me.MageBox.Appearance = System.Windows.Forms.Appearance.Button
        Me.MageBox.AutoSize = True
        Me.MageBox.Location = New System.Drawing.Point(214, 86)
        Me.MageBox.Name = "MageBox"
        Me.MageBox.Size = New System.Drawing.Size(47, 25)
        Me.MageBox.TabIndex = 25
        Me.MageBox.Text = "Mage"
        Me.ToolTip1.SetToolTip(Me.MageBox, resources.GetString("MageBox.ToolTip"))
        Me.MageBox.UseVisualStyleBackColor = True
        '
        'TactBox
        '
        Me.TactBox.Appearance = System.Windows.Forms.Appearance.Button
        Me.TactBox.AutoSize = True
        Me.TactBox.Location = New System.Drawing.Point(142, 86)
        Me.TactBox.Name = "TactBox"
        Me.TactBox.Size = New System.Drawing.Size(66, 25)
        Me.TactBox.TabIndex = 26
        Me.TactBox.Text = "Tactician"
        Me.ToolTip1.SetToolTip(Me.TactBox, resources.GetString("TactBox.ToolTip"))
        Me.TactBox.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(105, 335)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(87, 40)
        Me.Button3.TabIndex = 27
        Me.Button3.Text = "Class reset" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(90, 151)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 15)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Attributes: "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(90, 211)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(24, 15)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Lck"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(139, 211)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(14, 15)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(90, 226)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(22, 15)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Int"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(139, 226)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(14, 15)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "0"
        '
        'Updater
        '
        Me.Updater.Enabled = True
        Me.Updater.Interval = 1
        '
        'ResetTimer
        '
        Me.ResetTimer.Interval = 2
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(211, 151)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(41, 15)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "To Hit:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(197, 181)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(21, 15)
        Me.Label16.TabIndex = 34
        Me.Label16.Text = "99"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(224, 181)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(10, 15)
        Me.Label17.TabIndex = 35
        Me.Label17.Text = ":"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(240, 181)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(21, 15)
        Me.Label18.TabIndex = 36
        Me.Label18.Text = "99"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(301, 151)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(80, 15)
        Me.Label19.TabIndex = 37
        Me.Label19.Text = "Base Damage"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(320, 181)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(21, 15)
        Me.Label20.TabIndex = 38
        Me.Label20.Text = "99"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 387)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TactBox)
        Me.Controls.Add(Me.MageBox)
        Me.Controls.Add(Me.RogueBox)
        Me.Controls.Add(Me.UnBox)
        Me.Controls.Add(Me.WarriorBox)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Class Selection"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents WarriorBox As System.Windows.Forms.CheckBox
    Friend WithEvents UnBox As System.Windows.Forms.CheckBox
    Friend WithEvents RogueBox As System.Windows.Forms.CheckBox
    Friend WithEvents MageBox As System.Windows.Forms.CheckBox
    Friend WithEvents TactBox As System.Windows.Forms.CheckBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Updater As System.Windows.Forms.Timer
    Friend WithEvents ResetTimer As System.Windows.Forms.Timer
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label

End Class
