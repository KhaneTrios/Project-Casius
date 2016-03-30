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
        Me.EAttack = New System.Windows.Forms.Button()
        Me.SteelBeams = New System.Windows.Forms.Button()
        Me.ToxDebuff = New System.Windows.Forms.Button()
        Me.Reset = New System.Windows.Forms.Button()
        Me.ToxStack = New System.Windows.Forms.Label()
        Me.BleedStack = New System.Windows.Forms.Label()
        Me.ToxInc = New System.Windows.Forms.Button()
        Me.HemoStack = New System.Windows.Forms.Button()
        Me.Bleeding = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.SlowCheck = New System.Windows.Forms.Label()
        Me.Slow = New System.Windows.Forms.Button()
        Me.StunCheck = New System.Windows.Forms.Label()
        Me.Stun2 = New System.Windows.Forms.Button()
        Me.Stun1 = New System.Windows.Forms.Button()
        Me.BurnCheck = New System.Windows.Forms.Label()
        Me.BurnButton = New System.Windows.Forms.Button()
        Me.TurnLabel = New System.Windows.Forms.Label()
        Me.EHealthValue = New System.Windows.Forms.Label()
        Me.PHealthValue = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EnemyBar = New System.Windows.Forms.ProgressBar()
        Me.PlayerBar = New System.Windows.Forms.ProgressBar()
        Me.Updater = New System.Windows.Forms.Timer(Me.components)
        Me.BurnTime = New System.Windows.Forms.Timer(Me.components)
        Me.StunTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SlowTimer = New System.Windows.Forms.Timer(Me.components)
        Me.BleedTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ToxinTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'EAttack
        '
        Me.EAttack.Location = New System.Drawing.Point(365, 59)
        Me.EAttack.Name = "EAttack"
        Me.EAttack.Size = New System.Drawing.Size(28, 23)
        Me.EAttack.TabIndex = 47
        Me.EAttack.Text = "X"
        Me.EAttack.UseVisualStyleBackColor = True
        '
        'SteelBeams
        '
        Me.SteelBeams.Location = New System.Drawing.Point(11, 256)
        Me.SteelBeams.Name = "SteelBeams"
        Me.SteelBeams.Size = New System.Drawing.Size(98, 23)
        Me.SteelBeams.TabIndex = 46
        Me.SteelBeams.Text = "Grinder Perk"
        Me.ToolTip1.SetToolTip(Me.SteelBeams, """Grinder Perk Actually Melts Steel Buildings"" -Braeden Mackereth, playing a PayDa" &
        "y2 Grinder Build")
        Me.SteelBeams.UseVisualStyleBackColor = True
        '
        'ToxDebuff
        '
        Me.ToxDebuff.Location = New System.Drawing.Point(11, 226)
        Me.ToxDebuff.Name = "ToxDebuff"
        Me.ToxDebuff.Size = New System.Drawing.Size(97, 23)
        Me.ToxDebuff.TabIndex = 45
        Me.ToxDebuff.Text = "Poison Debuff"
        Me.ToxDebuff.UseVisualStyleBackColor = True
        '
        'Reset
        '
        Me.Reset.Location = New System.Drawing.Point(160, 31)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(75, 23)
        Me.Reset.TabIndex = 44
        Me.Reset.Text = "Reset"
        Me.Reset.UseVisualStyleBackColor = True
        '
        'ToxStack
        '
        Me.ToxStack.AutoSize = True
        Me.ToxStack.Location = New System.Drawing.Point(165, 230)
        Me.ToxStack.Name = "ToxStack"
        Me.ToxStack.Size = New System.Drawing.Size(13, 13)
        Me.ToxStack.TabIndex = 43
        Me.ToxStack.Text = "0"
        '
        'BleedStack
        '
        Me.BleedStack.AutoSize = True
        Me.BleedStack.Location = New System.Drawing.Point(165, 201)
        Me.BleedStack.Name = "BleedStack"
        Me.BleedStack.Size = New System.Drawing.Size(13, 13)
        Me.BleedStack.TabIndex = 42
        Me.BleedStack.Text = "0"
        '
        'ToxInc
        '
        Me.ToxInc.Location = New System.Drawing.Point(115, 225)
        Me.ToxInc.Name = "ToxInc"
        Me.ToxInc.Size = New System.Drawing.Size(44, 23)
        Me.ToxInc.TabIndex = 41
        Me.ToxInc.Text = "Toxin"
        Me.ToxInc.UseVisualStyleBackColor = True
        '
        'HemoStack
        '
        Me.HemoStack.Location = New System.Drawing.Point(115, 196)
        Me.HemoStack.Name = "HemoStack"
        Me.HemoStack.Size = New System.Drawing.Size(44, 23)
        Me.HemoStack.TabIndex = 40
        Me.HemoStack.Text = "Hemo"
        Me.HemoStack.UseVisualStyleBackColor = True
        '
        'Bleeding
        '
        Me.Bleeding.Location = New System.Drawing.Point(12, 197)
        Me.Bleeding.Name = "Bleeding"
        Me.Bleeding.Size = New System.Drawing.Size(97, 23)
        Me.Bleeding.TabIndex = 39
        Me.Bleeding.Text = "Bleed Debuff"
        Me.Bleeding.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RichTextBox1.Cursor = System.Windows.Forms.Cursors.No
        Me.RichTextBox1.Enabled = False
        Me.RichTextBox1.Location = New System.Drawing.Point(115, 144)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.RichTextBox1.ShowSelectionMargin = True
        Me.RichTextBox1.Size = New System.Drawing.Size(80, 46)
        Me.RichTextBox1.TabIndex = 38
        Me.RichTextBox1.Text = ""
        '
        'SlowCheck
        '
        Me.SlowCheck.AutoSize = True
        Me.SlowCheck.Location = New System.Drawing.Point(251, 75)
        Me.SlowCheck.Name = "SlowCheck"
        Me.SlowCheck.Size = New System.Drawing.Size(36, 13)
        Me.SlowCheck.TabIndex = 37
        Me.SlowCheck.Text = "(Slow)"
        '
        'Slow
        '
        Me.Slow.Location = New System.Drawing.Point(15, 144)
        Me.Slow.Name = "Slow"
        Me.Slow.Size = New System.Drawing.Size(94, 46)
        Me.Slow.TabIndex = 36
        Me.Slow.Text = "Slow Debuff"
        Me.Slow.UseVisualStyleBackColor = True
        '
        'StunCheck
        '
        Me.StunCheck.AutoSize = True
        Me.StunCheck.Location = New System.Drawing.Point(251, 51)
        Me.StunCheck.Name = "StunCheck"
        Me.StunCheck.Size = New System.Drawing.Size(35, 13)
        Me.StunCheck.TabIndex = 35
        Me.StunCheck.Text = "(Stun)"
        '
        'Stun2
        '
        Me.Stun2.Location = New System.Drawing.Point(15, 114)
        Me.Stun2.Name = "Stun2"
        Me.Stun2.Size = New System.Drawing.Size(94, 23)
        Me.Stun2.TabIndex = 34
        Me.Stun2.Text = "Stun Debuff 2"
        Me.Stun2.UseVisualStyleBackColor = True
        '
        'Stun1
        '
        Me.Stun1.Location = New System.Drawing.Point(15, 84)
        Me.Stun1.Name = "Stun1"
        Me.Stun1.Size = New System.Drawing.Size(94, 23)
        Me.Stun1.TabIndex = 33
        Me.Stun1.Text = "Stun Debuff 1"
        Me.Stun1.UseVisualStyleBackColor = True
        '
        'BurnCheck
        '
        Me.BurnCheck.AutoSize = True
        Me.BurnCheck.Location = New System.Drawing.Point(126, 59)
        Me.BurnCheck.Name = "BurnCheck"
        Me.BurnCheck.Size = New System.Drawing.Size(13, 13)
        Me.BurnCheck.TabIndex = 32
        Me.BurnCheck.Text = "0"
        '
        'BurnButton
        '
        Me.BurnButton.Location = New System.Drawing.Point(15, 54)
        Me.BurnButton.Name = "BurnButton"
        Me.BurnButton.Size = New System.Drawing.Size(94, 23)
        Me.BurnButton.TabIndex = 31
        Me.BurnButton.Text = "Burn Debuff"
        Me.BurnButton.UseVisualStyleBackColor = True
        '
        'TurnLabel
        '
        Me.TurnLabel.AutoSize = True
        Me.TurnLabel.Location = New System.Drawing.Point(189, 12)
        Me.TurnLabel.Name = "TurnLabel"
        Me.TurnLabel.Size = New System.Drawing.Size(19, 13)
        Me.TurnLabel.TabIndex = 30
        Me.TurnLabel.Text = "99"
        '
        'EHealthValue
        '
        Me.EHealthValue.AutoSize = True
        Me.EHealthValue.Location = New System.Drawing.Point(328, 36)
        Me.EHealthValue.Name = "EHealthValue"
        Me.EHealthValue.Size = New System.Drawing.Size(25, 13)
        Me.EHealthValue.TabIndex = 29
        Me.EHealthValue.Text = "999"
        '
        'PHealthValue
        '
        Me.PHealthValue.AutoSize = True
        Me.PHealthValue.Location = New System.Drawing.Point(89, 37)
        Me.PHealthValue.Name = "PHealthValue"
        Me.PHealthValue.Size = New System.Drawing.Size(25, 13)
        Me.PHealthValue.TabIndex = 28
        Me.PHealthValue.Text = "999"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(248, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Enemy Health"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Player Health"
        '
        'EnemyBar
        '
        Me.EnemyBar.BackColor = System.Drawing.SystemColors.ControlText
        Me.EnemyBar.ForeColor = System.Drawing.Color.DarkRed
        Me.EnemyBar.Location = New System.Drawing.Point(251, 12)
        Me.EnemyBar.Maximum = 1000
        Me.EnemyBar.Name = "EnemyBar"
        Me.EnemyBar.Size = New System.Drawing.Size(142, 18)
        Me.EnemyBar.TabIndex = 25
        '
        'PlayerBar
        '
        Me.PlayerBar.BackColor = System.Drawing.SystemColors.ControlText
        Me.PlayerBar.ForeColor = System.Drawing.Color.DarkRed
        Me.PlayerBar.Location = New System.Drawing.Point(12, 12)
        Me.PlayerBar.Maximum = 1000
        Me.PlayerBar.Name = "PlayerBar"
        Me.PlayerBar.Size = New System.Drawing.Size(142, 18)
        Me.PlayerBar.TabIndex = 24
        '
        'Updater
        '
        Me.Updater.Enabled = True
        Me.Updater.Interval = 1
        '
        'BurnTime
        '
        '
        'StunTimer
        '
        '
        'SlowTimer
        '
        '
        'BleedTimer
        '
        Me.BleedTimer.Interval = 500
        '
        'ToxinTimer
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 293)
        Me.Controls.Add(Me.EAttack)
        Me.Controls.Add(Me.SteelBeams)
        Me.Controls.Add(Me.ToxDebuff)
        Me.Controls.Add(Me.Reset)
        Me.Controls.Add(Me.ToxStack)
        Me.Controls.Add(Me.BleedStack)
        Me.Controls.Add(Me.ToxInc)
        Me.Controls.Add(Me.HemoStack)
        Me.Controls.Add(Me.Bleeding)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.SlowCheck)
        Me.Controls.Add(Me.Slow)
        Me.Controls.Add(Me.StunCheck)
        Me.Controls.Add(Me.Stun2)
        Me.Controls.Add(Me.Stun1)
        Me.Controls.Add(Me.BurnCheck)
        Me.Controls.Add(Me.BurnButton)
        Me.Controls.Add(Me.TurnLabel)
        Me.Controls.Add(Me.EHealthValue)
        Me.Controls.Add(Me.PHealthValue)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.EnemyBar)
        Me.Controls.Add(Me.PlayerBar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EAttack As Button
    Friend WithEvents SteelBeams As Button
    Friend WithEvents ToxDebuff As Button
    Friend WithEvents Reset As Button
    Friend WithEvents ToxStack As Label
    Friend WithEvents BleedStack As Label
    Friend WithEvents ToxInc As Button
    Friend WithEvents HemoStack As Button
    Friend WithEvents Bleeding As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents SlowCheck As Label
    Friend WithEvents Slow As Button
    Friend WithEvents StunCheck As Label
    Friend WithEvents Stun2 As Button
    Friend WithEvents Stun1 As Button
    Friend WithEvents BurnCheck As Label
    Friend WithEvents BurnButton As Button
    Friend WithEvents TurnLabel As Label
    Friend WithEvents EHealthValue As Label
    Friend WithEvents PHealthValue As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents EnemyBar As ProgressBar
    Friend WithEvents PlayerBar As ProgressBar
    Friend WithEvents Updater As Timer
    Friend WithEvents BurnTime As Timer
    Friend WithEvents StunTimer As Timer
    Friend WithEvents SlowTimer As Timer
    Friend WithEvents BleedTimer As Timer
    Friend WithEvents ToxinTimer As Timer
    Friend WithEvents ToolTip1 As ToolTip
End Class
