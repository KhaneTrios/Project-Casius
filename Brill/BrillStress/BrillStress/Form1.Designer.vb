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
        Me.UnPlug = New System.Windows.Forms.Button()
        Me.RePlug = New System.Windows.Forms.Button()
        Me.Plugger = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PlugLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelClass = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ArmLabel = New System.Windows.Forms.Label()
        Me.Randomizer = New System.Windows.Forms.Timer(Me.components)
        Me.Updater = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'UnPlug
        '
        Me.UnPlug.Location = New System.Drawing.Point(13, 13)
        Me.UnPlug.Name = "UnPlug"
        Me.UnPlug.Size = New System.Drawing.Size(75, 23)
        Me.UnPlug.TabIndex = 0
        Me.UnPlug.Text = "UnPlug"
        Me.UnPlug.UseVisualStyleBackColor = True
        '
        'RePlug
        '
        Me.RePlug.Enabled = False
        Me.RePlug.Location = New System.Drawing.Point(13, 43)
        Me.RePlug.Name = "RePlug"
        Me.RePlug.Size = New System.Drawing.Size(75, 23)
        Me.RePlug.TabIndex = 1
        Me.RePlug.Text = "RePlug"
        Me.RePlug.UseVisualStyleBackColor = True
        '
        'Plugger
        '
        Me.Plugger.Interval = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(121, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Plugs"
        '
        'PlugLabel
        '
        Me.PlugLabel.AutoSize = True
        Me.PlugLabel.Location = New System.Drawing.Point(161, 13)
        Me.PlugLabel.Name = "PlugLabel"
        Me.PlugLabel.Size = New System.Drawing.Size(31, 13)
        Me.PlugLabel.TabIndex = 3
        Me.PlugLabel.Text = "9999"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(121, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Class"
        '
        'LabelClass
        '
        Me.LabelClass.AutoSize = True
        Me.LabelClass.Location = New System.Drawing.Point(161, 43)
        Me.LabelClass.Name = "LabelClass"
        Me.LabelClass.Size = New System.Drawing.Size(39, 13)
        Me.LabelClass.TabIndex = 5
        Me.LabelClass.Text = "Casual"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(291, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Armor"
        '
        'ArmLabel
        '
        Me.ArmLabel.AutoSize = True
        Me.ArmLabel.Location = New System.Drawing.Point(332, 13)
        Me.ArmLabel.Name = "ArmLabel"
        Me.ArmLabel.Size = New System.Drawing.Size(55, 13)
        Me.ArmLabel.TabIndex = 7
        Me.ArmLabel.Text = "Plot Armor"
        '
        'Randomizer
        '
        Me.Randomizer.Enabled = True
        Me.Randomizer.Interval = 1
        '
        'Updater
        '
        Me.Updater.Enabled = True
        Me.Updater.Interval = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 489)
        Me.Controls.Add(Me.ArmLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LabelClass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PlugLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RePlug)
        Me.Controls.Add(Me.UnPlug)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UnPlug As System.Windows.Forms.Button
    Friend WithEvents RePlug As System.Windows.Forms.Button
    Friend WithEvents Plugger As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PlugLabel As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LabelClass As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ArmLabel As System.Windows.Forms.Label
    Friend WithEvents Randomizer As System.Windows.Forms.Timer
    Friend WithEvents Updater As System.Windows.Forms.Timer

End Class
