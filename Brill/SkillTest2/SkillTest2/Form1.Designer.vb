<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.WarrCharge = New System.Windows.Forms.Button()
        Me.CDTimer = New System.Windows.Forms.Timer(Me.components)
        Me.CdLabel = New System.Windows.Forms.Label()
        Me.BleedLabel = New System.Windows.Forms.Label()
        Me.WarrLash = New System.Windows.Forms.Button()
        Me.WarrSlam = New System.Windows.Forms.Button()
        Me.RageLabel = New System.Windows.Forms.Label()
        Me.WarrRage = New System.Windows.Forms.Button()
        Me.TempTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TactScout = New System.Windows.Forms.Button()
        Me.PAttack = New System.Windows.Forms.Button()
        Me.TactCalLaunch = New System.Windows.Forms.Button()
        Me.TactPlan = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TactBomb = New System.Windows.Forms.Button()
        Me.ProgressBar3 = New System.Windows.Forms.ProgressBar()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RogueStab = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.RDmgLabel = New System.Windows.Forms.Label()
        Me.RoguePar = New System.Windows.Forms.Button()
        Me.RogueInvis = New System.Windows.Forms.Button()
        Me.RogueStrike = New System.Windows.Forms.Button()
        Me.ProgressBar4 = New System.Windows.Forms.ProgressBar()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.UnCraze = New System.Windows.Forms.Button()
        Me.UnSpdMod = New System.Windows.Forms.Timer(Me.components)
        Me.UnBurden = New System.Windows.Forms.Button()
        Me.UnWild = New System.Windows.Forms.Button()
        Me.UnRed = New System.Windows.Forms.Button()
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
        Me.SteelBeams.BackColor = System.Drawing.Color.Purple
        Me.SteelBeams.Location = New System.Drawing.Point(11, 256)
        Me.SteelBeams.Name = "SteelBeams"
        Me.SteelBeams.Size = New System.Drawing.Size(98, 23)
        Me.SteelBeams.TabIndex = 46
        Me.SteelBeams.Text = "Grinder Perk"
        Me.ToolTip1.SetToolTip(Me.SteelBeams, """Grinder Perk Actually Melts Steel Buildings"" -Braeden Mackereth, playing a PayDa" &
        "y2 Grinder Build")
        Me.SteelBeams.UseVisualStyleBackColor = False
        '
        'ToxDebuff
        '
        Me.ToxDebuff.BackColor = System.Drawing.Color.LightCoral
        Me.ToxDebuff.Location = New System.Drawing.Point(11, 226)
        Me.ToxDebuff.Name = "ToxDebuff"
        Me.ToxDebuff.Size = New System.Drawing.Size(97, 23)
        Me.ToxDebuff.TabIndex = 45
        Me.ToxDebuff.Text = "Poison Debuff"
        Me.ToxDebuff.UseVisualStyleBackColor = False
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
        Me.ToxInc.BackColor = System.Drawing.Color.Lime
        Me.ToxInc.Location = New System.Drawing.Point(115, 225)
        Me.ToxInc.Name = "ToxInc"
        Me.ToxInc.Size = New System.Drawing.Size(44, 23)
        Me.ToxInc.TabIndex = 41
        Me.ToxInc.Text = "Toxin"
        Me.ToxInc.UseVisualStyleBackColor = False
        '
        'HemoStack
        '
        Me.HemoStack.BackColor = System.Drawing.Color.DarkRed
        Me.HemoStack.Location = New System.Drawing.Point(115, 196)
        Me.HemoStack.Name = "HemoStack"
        Me.HemoStack.Size = New System.Drawing.Size(44, 23)
        Me.HemoStack.TabIndex = 40
        Me.HemoStack.Text = "Hemo"
        Me.HemoStack.UseVisualStyleBackColor = False
        '
        'Bleeding
        '
        Me.Bleeding.BackColor = System.Drawing.Color.LightCoral
        Me.Bleeding.Location = New System.Drawing.Point(12, 197)
        Me.Bleeding.Name = "Bleeding"
        Me.Bleeding.Size = New System.Drawing.Size(97, 23)
        Me.Bleeding.TabIndex = 39
        Me.Bleeding.Text = "Bleed Debuff"
        Me.Bleeding.UseVisualStyleBackColor = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RichTextBox1.Cursor = System.Windows.Forms.Cursors.No
        Me.RichTextBox1.ForeColor = System.Drawing.Color.LawnGreen
        Me.RichTextBox1.Location = New System.Drawing.Point(115, 136)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.RichTextBox1.ShowSelectionMargin = True
        Me.RichTextBox1.Size = New System.Drawing.Size(190, 54)
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
        Me.Slow.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Slow.Location = New System.Drawing.Point(15, 144)
        Me.Slow.Name = "Slow"
        Me.Slow.Size = New System.Drawing.Size(94, 46)
        Me.Slow.TabIndex = 36
        Me.Slow.Text = "Slow Debuff"
        Me.Slow.UseVisualStyleBackColor = False
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
        Me.Stun2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Stun2.Location = New System.Drawing.Point(15, 114)
        Me.Stun2.Name = "Stun2"
        Me.Stun2.Size = New System.Drawing.Size(94, 23)
        Me.Stun2.TabIndex = 34
        Me.Stun2.Text = "Stun Debuff 2"
        Me.Stun2.UseVisualStyleBackColor = False
        '
        'Stun1
        '
        Me.Stun1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Stun1.Location = New System.Drawing.Point(15, 84)
        Me.Stun1.Name = "Stun1"
        Me.Stun1.Size = New System.Drawing.Size(94, 23)
        Me.Stun1.TabIndex = 33
        Me.Stun1.Text = "Stun Debuff 1"
        Me.Stun1.UseVisualStyleBackColor = False
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
        Me.BurnButton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BurnButton.Location = New System.Drawing.Point(15, 54)
        Me.BurnButton.Name = "BurnButton"
        Me.BurnButton.Size = New System.Drawing.Size(94, 23)
        Me.BurnButton.TabIndex = 31
        Me.BurnButton.Text = "Burn Debuff"
        Me.BurnButton.UseVisualStyleBackColor = False
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
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.Black
        Me.ProgressBar1.Location = New System.Drawing.Point(400, -2)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(10, 304)
        Me.ProgressBar1.TabIndex = 48
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(416, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Warrior Skills"
        '
        'WarrCharge
        '
        Me.WarrCharge.BackColor = System.Drawing.Color.Firebrick
        Me.WarrCharge.Location = New System.Drawing.Point(420, 31)
        Me.WarrCharge.Name = "WarrCharge"
        Me.WarrCharge.Size = New System.Drawing.Size(65, 23)
        Me.WarrCharge.TabIndex = 50
        Me.WarrCharge.Text = "Charge"
        Me.WarrCharge.UseVisualStyleBackColor = False
        '
        'CDTimer
        '
        '
        'CdLabel
        '
        Me.CdLabel.AutoSize = True
        Me.CdLabel.Location = New System.Drawing.Point(362, 271)
        Me.CdLabel.Name = "CdLabel"
        Me.CdLabel.Size = New System.Drawing.Size(13, 13)
        Me.CdLabel.TabIndex = 51
        Me.CdLabel.Text = "0"
        '
        'BleedLabel
        '
        Me.BleedLabel.AutoSize = True
        Me.BleedLabel.Location = New System.Drawing.Point(251, 94)
        Me.BleedLabel.Name = "BleedLabel"
        Me.BleedLabel.Size = New System.Drawing.Size(40, 13)
        Me.BleedLabel.TabIndex = 53
        Me.BleedLabel.Text = "(Bleed)"
        '
        'WarrLash
        '
        Me.WarrLash.BackColor = System.Drawing.Color.Firebrick
        Me.WarrLash.Location = New System.Drawing.Point(420, 58)
        Me.WarrLash.Name = "WarrLash"
        Me.WarrLash.Size = New System.Drawing.Size(65, 39)
        Me.WarrLash.TabIndex = 54
        Me.WarrLash.Text = "Back Lash"
        Me.WarrLash.UseVisualStyleBackColor = False
        '
        'WarrSlam
        '
        Me.WarrSlam.BackColor = System.Drawing.Color.Firebrick
        Me.WarrSlam.Location = New System.Drawing.Point(420, 104)
        Me.WarrSlam.Name = "WarrSlam"
        Me.WarrSlam.Size = New System.Drawing.Size(65, 23)
        Me.WarrSlam.TabIndex = 56
        Me.WarrSlam.Text = "Core Slam"
        Me.WarrSlam.UseVisualStyleBackColor = False
        '
        'RageLabel
        '
        Me.RageLabel.AutoSize = True
        Me.RageLabel.Location = New System.Drawing.Point(362, 247)
        Me.RageLabel.Name = "RageLabel"
        Me.RageLabel.Size = New System.Drawing.Size(13, 13)
        Me.RageLabel.TabIndex = 58
        Me.RageLabel.Text = "0"
        '
        'WarrRage
        '
        Me.WarrRage.BackColor = System.Drawing.Color.Firebrick
        Me.WarrRage.Location = New System.Drawing.Point(420, 133)
        Me.WarrRage.Name = "WarrRage"
        Me.WarrRage.Size = New System.Drawing.Size(65, 41)
        Me.WarrRage.TabIndex = 59
        Me.WarrRage.Text = "Enrage"
        Me.WarrRage.UseVisualStyleBackColor = False
        '
        'TempTimer
        '
        '
        'ProgressBar2
        '
        Me.ProgressBar2.BackColor = System.Drawing.Color.Black
        Me.ProgressBar2.Location = New System.Drawing.Point(491, -2)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(10, 304)
        Me.ProgressBar2.TabIndex = 60
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(507, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Tactician Skills"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(297, 271)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Cool Down"
        '
        'TactScout
        '
        Me.TactScout.BackColor = System.Drawing.Color.Coral
        Me.TactScout.Location = New System.Drawing.Point(507, 30)
        Me.TactScout.Name = "TactScout"
        Me.TactScout.Size = New System.Drawing.Size(85, 23)
        Me.TactScout.TabIndex = 63
        Me.TactScout.Text = "Scout"
        Me.TactScout.UseVisualStyleBackColor = False
        '
        'PAttack
        '
        Me.PAttack.Location = New System.Drawing.Point(116, 76)
        Me.PAttack.Name = "PAttack"
        Me.PAttack.Size = New System.Drawing.Size(75, 54)
        Me.PAttack.TabIndex = 64
        Me.PAttack.Text = "Attack"
        Me.PAttack.UseVisualStyleBackColor = True
        '
        'TactCalLaunch
        '
        Me.TactCalLaunch.BackColor = System.Drawing.Color.Coral
        Me.TactCalLaunch.Location = New System.Drawing.Point(507, 58)
        Me.TactCalLaunch.Name = "TactCalLaunch"
        Me.TactCalLaunch.Size = New System.Drawing.Size(85, 38)
        Me.TactCalLaunch.TabIndex = 65
        Me.TactCalLaunch.Text = "Caltrop Launch"
        Me.TactCalLaunch.UseVisualStyleBackColor = False
        '
        'TactPlan
        '
        Me.TactPlan.BackColor = System.Drawing.Color.Coral
        Me.TactPlan.Location = New System.Drawing.Point(507, 102)
        Me.TactPlan.Name = "TactPlan"
        Me.TactPlan.Size = New System.Drawing.Size(85, 23)
        Me.TactPlan.TabIndex = 66
        Me.TactPlan.Text = "Over-plan"
        Me.TactPlan.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(276, 247)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "Bonus Damage"
        '
        'TactBomb
        '
        Me.TactBomb.BackColor = System.Drawing.Color.Coral
        Me.TactBomb.Location = New System.Drawing.Point(507, 134)
        Me.TactBomb.Name = "TactBomb"
        Me.TactBomb.Size = New System.Drawing.Size(85, 38)
        Me.TactBomb.TabIndex = 68
        Me.TactBomb.Text = "Poison-bomb Barrage"
        Me.TactBomb.UseVisualStyleBackColor = False
        '
        'ProgressBar3
        '
        Me.ProgressBar3.BackColor = System.Drawing.Color.Black
        Me.ProgressBar3.Location = New System.Drawing.Point(598, -2)
        Me.ProgressBar3.Name = "ProgressBar3"
        Me.ProgressBar3.Size = New System.Drawing.Size(10, 304)
        Me.ProgressBar3.TabIndex = 69
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(614, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 70
        Me.Label7.Text = "Rogue Skills"
        '
        'RogueStab
        '
        Me.RogueStab.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.RogueStab.Location = New System.Drawing.Point(614, 31)
        Me.RogueStab.Name = "RogueStab"
        Me.RogueStab.Size = New System.Drawing.Size(75, 23)
        Me.RogueStab.TabIndex = 71
        Me.RogueStab.Text = "Backstab"
        Me.RogueStab.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(276, 226)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 72
        Me.Label8.Text = "Rogue Bonus"
        '
        'RDmgLabel
        '
        Me.RDmgLabel.AutoSize = True
        Me.RDmgLabel.Location = New System.Drawing.Point(362, 225)
        Me.RDmgLabel.Name = "RDmgLabel"
        Me.RDmgLabel.Size = New System.Drawing.Size(13, 13)
        Me.RDmgLabel.TabIndex = 73
        Me.RDmgLabel.Text = "0"
        '
        'RoguePar
        '
        Me.RoguePar.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.RoguePar.Location = New System.Drawing.Point(614, 65)
        Me.RoguePar.Name = "RoguePar"
        Me.RoguePar.Size = New System.Drawing.Size(75, 23)
        Me.RoguePar.TabIndex = 74
        Me.RoguePar.Text = "Parry"
        Me.RoguePar.UseVisualStyleBackColor = False
        '
        'RogueInvis
        '
        Me.RogueInvis.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.RogueInvis.Location = New System.Drawing.Point(614, 102)
        Me.RogueInvis.Name = "RogueInvis"
        Me.RogueInvis.Size = New System.Drawing.Size(75, 23)
        Me.RogueInvis.TabIndex = 75
        Me.RogueInvis.Text = "Invisibility"
        Me.RogueInvis.UseVisualStyleBackColor = False
        '
        'RogueStrike
        '
        Me.RogueStrike.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.RogueStrike.Location = New System.Drawing.Point(614, 134)
        Me.RogueStrike.Name = "RogueStrike"
        Me.RogueStrike.Size = New System.Drawing.Size(75, 39)
        Me.RogueStrike.TabIndex = 76
        Me.RogueStrike.Text = "Shadow Strike"
        Me.RogueStrike.UseVisualStyleBackColor = False
        '
        'ProgressBar4
        '
        Me.ProgressBar4.BackColor = System.Drawing.Color.Black
        Me.ProgressBar4.Location = New System.Drawing.Point(695, -2)
        Me.ProgressBar4.Name = "ProgressBar4"
        Me.ProgressBar4.Size = New System.Drawing.Size(10, 304)
        Me.ProgressBar4.TabIndex = 78
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(711, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 13)
        Me.Label10.TabIndex = 79
        Me.Label10.Text = "Unborn Skills"
        '
        'UnCraze
        '
        Me.UnCraze.BackColor = System.Drawing.Color.SaddleBrown
        Me.UnCraze.Location = New System.Drawing.Point(713, 33)
        Me.UnCraze.Name = "UnCraze"
        Me.UnCraze.Size = New System.Drawing.Size(67, 23)
        Me.UnCraze.TabIndex = 80
        Me.UnCraze.Text = "Crazed"
        Me.UnCraze.UseVisualStyleBackColor = False
        '
        'UnSpdMod
        '
        '
        'UnBurden
        '
        Me.UnBurden.BackColor = System.Drawing.Color.SaddleBrown
        Me.UnBurden.Location = New System.Drawing.Point(710, 66)
        Me.UnBurden.Name = "UnBurden"
        Me.UnBurden.Size = New System.Drawing.Size(70, 23)
        Me.UnBurden.TabIndex = 81
        Me.UnBurden.Text = "Burden"
        Me.UnBurden.UseVisualStyleBackColor = False
        '
        'UnWild
        '
        Me.UnWild.BackColor = System.Drawing.Color.SaddleBrown
        Me.UnWild.Location = New System.Drawing.Point(710, 104)
        Me.UnWild.Name = "UnWild"
        Me.UnWild.Size = New System.Drawing.Size(70, 23)
        Me.UnWild.TabIndex = 82
        Me.UnWild.Text = "Hysteria"
        Me.UnWild.UseVisualStyleBackColor = False
        '
        'UnRed
        '
        Me.UnRed.BackColor = System.Drawing.Color.SaddleBrown
        Me.UnRed.Location = New System.Drawing.Point(714, 136)
        Me.UnRed.Name = "UnRed"
        Me.UnRed.Size = New System.Drawing.Size(75, 38)
        Me.UnRed.TabIndex = 83
        Me.UnRed.Text = "Redemption"
        Me.UnRed.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 293)
        Me.Controls.Add(Me.UnRed)
        Me.Controls.Add(Me.UnWild)
        Me.Controls.Add(Me.UnBurden)
        Me.Controls.Add(Me.UnCraze)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ProgressBar4)
        Me.Controls.Add(Me.RogueStrike)
        Me.Controls.Add(Me.RogueInvis)
        Me.Controls.Add(Me.RoguePar)
        Me.Controls.Add(Me.RDmgLabel)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.RogueStab)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ProgressBar3)
        Me.Controls.Add(Me.TactBomb)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TactPlan)
        Me.Controls.Add(Me.TactCalLaunch)
        Me.Controls.Add(Me.PAttack)
        Me.Controls.Add(Me.TactScout)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ProgressBar2)
        Me.Controls.Add(Me.WarrRage)
        Me.Controls.Add(Me.RageLabel)
        Me.Controls.Add(Me.WarrSlam)
        Me.Controls.Add(Me.WarrLash)
        Me.Controls.Add(Me.BleedLabel)
        Me.Controls.Add(Me.CdLabel)
        Me.Controls.Add(Me.WarrCharge)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ProgressBar1)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
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
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label3 As Label
    Friend WithEvents WarrCharge As Button
    Friend WithEvents CDTimer As Timer
    Friend WithEvents CdLabel As Label
    Friend WithEvents BleedLabel As Label
    Friend WithEvents WarrLash As Button
    Friend WithEvents WarrSlam As Button
    Friend WithEvents RageLabel As Label
    Friend WithEvents WarrRage As Button
    Friend WithEvents TempTimer As Timer
    Friend WithEvents ProgressBar2 As ProgressBar
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TactScout As Button
    Friend WithEvents PAttack As Button
    Friend WithEvents TactCalLaunch As Button
    Friend WithEvents TactPlan As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TactBomb As Button
    Friend WithEvents ProgressBar3 As ProgressBar
    Friend WithEvents Label7 As Label
    Friend WithEvents RogueStab As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents RDmgLabel As Label
    Friend WithEvents RoguePar As Button
    Friend WithEvents RogueInvis As Button
    Friend WithEvents RogueStrike As Button
    Friend WithEvents ProgressBar4 As ProgressBar
    Friend WithEvents Label10 As Label
    Friend WithEvents UnCraze As Button
    Friend WithEvents UnSpdMod As Timer
    Friend WithEvents UnBurden As Button
    Friend WithEvents UnWild As Button
    Friend WithEvents UnRed As Button
End Class
