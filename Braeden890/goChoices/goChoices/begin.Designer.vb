<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class begin
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(begin))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.skillPoints = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Updater = New System.Windows.Forms.Timer(Me.components)
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button25 = New System.Windows.Forms.Button()
        Me.lblAquired = New System.Windows.Forms.Label()
        Me.skillcount = New System.Windows.Forms.Timer(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(214, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SKILLS:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(193, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "SKILL POINTS:"
        '
        'skillPoints
        '
        Me.skillPoints.AutoSize = True
        Me.skillPoints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.skillPoints.Location = New System.Drawing.Point(283, 26)
        Me.skillPoints.Name = "skillPoints"
        Me.skillPoints.Size = New System.Drawing.Size(15, 15)
        Me.skillPoints.TabIndex = 2
        Me.skillPoints.Text = "0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(282, 437)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 46)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(-10, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(649, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = resources.GetString("Label7.Text")
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(186, 437)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 46)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "First free skillpoint!"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Updater
        '
        Me.Updater.Enabled = True
        Me.Updater.Interval = 1
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(9, 21)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "skill -1"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button25
        '
        Me.Button25.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button25.Location = New System.Drawing.Point(371, 382)
        Me.Button25.Name = "Button25"
        Me.Button25.Size = New System.Drawing.Size(106, 102)
        Me.Button25.TabIndex = 33
        Me.Button25.Text = "Fight!"
        Me.Button25.UseVisualStyleBackColor = True
        '
        'lblAquired
        '
        Me.lblAquired.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAquired.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAquired.Location = New System.Drawing.Point(9, 398)
        Me.lblAquired.Name = "lblAquired"
        Me.lblAquired.Size = New System.Drawing.Size(171, 82)
        Me.lblAquired.TabIndex = 34
        Me.lblAquired.Text = "Label3"
        '
        'skillcount
        '
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(186, 386)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(179, 46)
        Me.Button3.TabIndex = 35
        Me.Button3.Text = "Main Menu" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(202, 95)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 52)
        Me.Button5.TabIndex = 36
        Me.Button5.Text = "Button5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(202, 153)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 53)
        Me.Button6.TabIndex = 37
        Me.Button6.Text = "Button6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(202, 212)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 53)
        Me.Button7.TabIndex = 38
        Me.Button7.Text = "Button7"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(202, 271)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 53)
        Me.Button8.TabIndex = 39
        Me.Button8.Text = "Button8"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(218, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 15)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "blank"
        '
        'begin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 486)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.lblAquired)
        Me.Controls.Add(Me.Button25)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.skillPoints)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "begin"
        Me.Text = "Skill Selection"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents skillPoints As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Updater As System.Windows.Forms.Timer
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button25 As System.Windows.Forms.Button
    Friend WithEvents lblAquired As System.Windows.Forms.Label
    Friend WithEvents skillcount As System.Windows.Forms.Timer
    Friend WithEvents Button3 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Label3 As Label
End Class
