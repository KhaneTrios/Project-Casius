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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Updater = New System.Windows.Forms.Timer(Me.components)
        Me.Button4 = New System.Windows.Forms.Button()
        Me.charge = New System.Windows.Forms.Button()
        Me.backwardsLash = New System.Windows.Forms.Button()
        Me.enrage = New System.Windows.Forms.Button()
        Me.coreSlam = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.poisonBomb = New System.Windows.Forms.Button()
        Me.overPlan = New System.Windows.Forms.Button()
        Me.caltropLaunch = New System.Windows.Forms.Button()
        Me.scout = New System.Windows.Forms.Button()
        Me.arcaneWhirlwind = New System.Windows.Forms.Button()
        Me.fireCage = New System.Windows.Forms.Button()
        Me.lightningWave = New System.Windows.Forms.Button()
        Me.shards = New System.Windows.Forms.Button()
        Me.shadowStrike = New System.Windows.Forms.Button()
        Me.invisible = New System.Windows.Forms.Button()
        Me.parry = New System.Windows.Forms.Button()
        Me.backstab = New System.Windows.Forms.Button()
        Me.redmption = New System.Windows.Forms.Button()
        Me.wild = New System.Windows.Forms.Button()
        Me.craze = New System.Windows.Forms.Button()
        Me.burden = New System.Windows.Forms.Button()
        Me.Button25 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.skillcount = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(266, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SKILLS:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(245, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "SKILL POINTS:"
        '
        'skillPoints
        '
        Me.skillPoints.AutoSize = True
        Me.skillPoints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.skillPoints.Location = New System.Drawing.Point(335, 26)
        Me.skillPoints.Name = "skillPoints"
        Me.skillPoints.Size = New System.Drawing.Size(15, 15)
        Me.skillPoints.TabIndex = 2
        Me.skillPoints.Text = "0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Location = New System.Drawing.Point(139, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tactician:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Location = New System.Drawing.Point(269, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Mage:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Location = New System.Drawing.Point(27, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Warrior: "
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(319, 428)
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
        Me.Button2.Location = New System.Drawing.Point(408, 418)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 56)
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
        Me.Button4.Location = New System.Drawing.Point(535, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "skill -1"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'charge
        '
        Me.charge.Location = New System.Drawing.Point(12, 101)
        Me.charge.Name = "charge"
        Me.charge.Size = New System.Drawing.Size(75, 23)
        Me.charge.TabIndex = 11
        Me.charge.Text = "Charge"
        Me.charge.UseVisualStyleBackColor = True
        '
        'backwardsLash
        '
        Me.backwardsLash.Location = New System.Drawing.Point(12, 130)
        Me.backwardsLash.Name = "backwardsLash"
        Me.backwardsLash.Size = New System.Drawing.Size(75, 35)
        Me.backwardsLash.TabIndex = 12
        Me.backwardsLash.Text = "Backwards Lash" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.backwardsLash.UseVisualStyleBackColor = True
        '
        'enrage
        '
        Me.enrage.Location = New System.Drawing.Point(12, 171)
        Me.enrage.Name = "enrage"
        Me.enrage.Size = New System.Drawing.Size(75, 23)
        Me.enrage.TabIndex = 13
        Me.enrage.Text = "Enrage" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.enrage.UseVisualStyleBackColor = True
        '
        'coreSlam
        '
        Me.coreSlam.Location = New System.Drawing.Point(12, 200)
        Me.coreSlam.Name = "coreSlam"
        Me.coreSlam.Size = New System.Drawing.Size(75, 23)
        Me.coreSlam.TabIndex = 14
        Me.coreSlam.Text = "Core Slam"
        Me.coreSlam.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Location = New System.Drawing.Point(381, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 15)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Rogue:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Location = New System.Drawing.Point(504, 66)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 15)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Unborn:"
        '
        'poisonBomb
        '
        Me.poisonBomb.Location = New System.Drawing.Point(130, 200)
        Me.poisonBomb.Name = "poisonBomb"
        Me.poisonBomb.Size = New System.Drawing.Size(75, 51)
        Me.poisonBomb.TabIndex = 20
        Me.poisonBomb.Text = "Poison Bomb Barrage"
        Me.poisonBomb.UseVisualStyleBackColor = True
        '
        'overPlan
        '
        Me.overPlan.Location = New System.Drawing.Point(130, 171)
        Me.overPlan.Name = "overPlan"
        Me.overPlan.Size = New System.Drawing.Size(75, 23)
        Me.overPlan.TabIndex = 19
        Me.overPlan.Text = "Over-Plan"
        Me.overPlan.UseVisualStyleBackColor = True
        '
        'caltropLaunch
        '
        Me.caltropLaunch.Location = New System.Drawing.Point(130, 130)
        Me.caltropLaunch.Name = "caltropLaunch"
        Me.caltropLaunch.Size = New System.Drawing.Size(75, 35)
        Me.caltropLaunch.TabIndex = 18
        Me.caltropLaunch.Text = "Caltrop Launch" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.caltropLaunch.UseVisualStyleBackColor = True
        '
        'scout
        '
        Me.scout.Location = New System.Drawing.Point(130, 101)
        Me.scout.Name = "scout"
        Me.scout.Size = New System.Drawing.Size(75, 23)
        Me.scout.TabIndex = 17
        Me.scout.Text = "Scout"
        Me.scout.UseVisualStyleBackColor = True
        '
        'arcaneWhirlwind
        '
        Me.arcaneWhirlwind.Location = New System.Drawing.Point(254, 217)
        Me.arcaneWhirlwind.Name = "arcaneWhirlwind"
        Me.arcaneWhirlwind.Size = New System.Drawing.Size(75, 34)
        Me.arcaneWhirlwind.TabIndex = 24
        Me.arcaneWhirlwind.Text = "Arcane Whirlwind"
        Me.arcaneWhirlwind.UseVisualStyleBackColor = True
        '
        'fireCage
        '
        Me.fireCage.Location = New System.Drawing.Point(254, 188)
        Me.fireCage.Name = "fireCage"
        Me.fireCage.Size = New System.Drawing.Size(75, 23)
        Me.fireCage.TabIndex = 23
        Me.fireCage.Text = "Fire Cage"
        Me.fireCage.UseVisualStyleBackColor = True
        '
        'lightningWave
        '
        Me.lightningWave.Location = New System.Drawing.Point(254, 142)
        Me.lightningWave.Name = "lightningWave"
        Me.lightningWave.Size = New System.Drawing.Size(75, 40)
        Me.lightningWave.TabIndex = 22
        Me.lightningWave.Text = "Lightning Wave"
        Me.lightningWave.UseVisualStyleBackColor = True
        '
        'shards
        '
        Me.shards.Location = New System.Drawing.Point(254, 101)
        Me.shards.Name = "shards"
        Me.shards.Size = New System.Drawing.Size(75, 35)
        Me.shards.TabIndex = 21
        Me.shards.Text = "Shards of Ice"
        Me.shards.UseVisualStyleBackColor = True
        '
        'shadowStrike
        '
        Me.shadowStrike.Location = New System.Drawing.Point(371, 188)
        Me.shadowStrike.Name = "shadowStrike"
        Me.shadowStrike.Size = New System.Drawing.Size(75, 35)
        Me.shadowStrike.TabIndex = 28
        Me.shadowStrike.Text = "Shadow Strike"
        Me.shadowStrike.UseVisualStyleBackColor = True
        '
        'invisible
        '
        Me.invisible.Location = New System.Drawing.Point(371, 159)
        Me.invisible.Name = "invisible"
        Me.invisible.Size = New System.Drawing.Size(75, 23)
        Me.invisible.TabIndex = 27
        Me.invisible.Text = "Invisible"
        Me.invisible.UseVisualStyleBackColor = True
        '
        'parry
        '
        Me.parry.Location = New System.Drawing.Point(371, 130)
        Me.parry.Name = "parry"
        Me.parry.Size = New System.Drawing.Size(75, 23)
        Me.parry.TabIndex = 26
        Me.parry.Text = "Parry"
        Me.parry.UseVisualStyleBackColor = True
        '
        'backstab
        '
        Me.backstab.Location = New System.Drawing.Point(371, 101)
        Me.backstab.Name = "backstab"
        Me.backstab.Size = New System.Drawing.Size(75, 23)
        Me.backstab.TabIndex = 25
        Me.backstab.Text = "Backstab"
        Me.backstab.UseVisualStyleBackColor = True
        '
        'redmption
        '
        Me.redmption.Location = New System.Drawing.Point(494, 188)
        Me.redmption.Name = "redmption"
        Me.redmption.Size = New System.Drawing.Size(75, 23)
        Me.redmption.TabIndex = 32
        Me.redmption.Text = "Redemption"
        Me.redmption.UseVisualStyleBackColor = True
        '
        'wild
        '
        Me.wild.Location = New System.Drawing.Point(494, 159)
        Me.wild.Name = "wild"
        Me.wild.Size = New System.Drawing.Size(75, 23)
        Me.wild.TabIndex = 31
        Me.wild.Text = "Wild"
        Me.wild.UseVisualStyleBackColor = True
        '
        'craze
        '
        Me.craze.Location = New System.Drawing.Point(494, 130)
        Me.craze.Name = "craze"
        Me.craze.Size = New System.Drawing.Size(75, 23)
        Me.craze.TabIndex = 30
        Me.craze.Text = "Craze"
        Me.craze.UseVisualStyleBackColor = True
        '
        'burden
        '
        Me.burden.Location = New System.Drawing.Point(494, 101)
        Me.burden.Name = "burden"
        Me.burden.Size = New System.Drawing.Size(75, 23)
        Me.burden.TabIndex = 29
        Me.burden.Text = "Burden"
        Me.burden.UseVisualStyleBackColor = True
        '
        'Button25
        '
        Me.Button25.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button25.Location = New System.Drawing.Point(504, 372)
        Me.Button25.Name = "Button25"
        Me.Button25.Size = New System.Drawing.Size(106, 102)
        Me.Button25.TabIndex = 33
        Me.Button25.Text = "Fight!"
        Me.Button25.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 350)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(284, 127)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Label3"
        '
        'skillcount
        '
        '
        'begin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 486)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button25)
        Me.Controls.Add(Me.redmption)
        Me.Controls.Add(Me.wild)
        Me.Controls.Add(Me.craze)
        Me.Controls.Add(Me.burden)
        Me.Controls.Add(Me.shadowStrike)
        Me.Controls.Add(Me.invisible)
        Me.Controls.Add(Me.parry)
        Me.Controls.Add(Me.backstab)
        Me.Controls.Add(Me.arcaneWhirlwind)
        Me.Controls.Add(Me.fireCage)
        Me.Controls.Add(Me.lightningWave)
        Me.Controls.Add(Me.shards)
        Me.Controls.Add(Me.poisonBomb)
        Me.Controls.Add(Me.overPlan)
        Me.Controls.Add(Me.caltropLaunch)
        Me.Controls.Add(Me.scout)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.coreSlam)
        Me.Controls.Add(Me.enrage)
        Me.Controls.Add(Me.backwardsLash)
        Me.Controls.Add(Me.charge)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Updater As System.Windows.Forms.Timer
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents charge As System.Windows.Forms.Button
    Friend WithEvents backwardsLash As System.Windows.Forms.Button
    Friend WithEvents enrage As System.Windows.Forms.Button
    Friend WithEvents coreSlam As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents poisonBomb As System.Windows.Forms.Button
    Friend WithEvents overPlan As System.Windows.Forms.Button
    Friend WithEvents caltropLaunch As System.Windows.Forms.Button
    Friend WithEvents scout As System.Windows.Forms.Button
    Friend WithEvents arcaneWhirlwind As System.Windows.Forms.Button
    Friend WithEvents fireCage As System.Windows.Forms.Button
    Friend WithEvents lightningWave As System.Windows.Forms.Button
    Friend WithEvents shards As System.Windows.Forms.Button
    Friend WithEvents shadowStrike As System.Windows.Forms.Button
    Friend WithEvents invisible As System.Windows.Forms.Button
    Friend WithEvents parry As System.Windows.Forms.Button
    Friend WithEvents backstab As System.Windows.Forms.Button
    Friend WithEvents redmption As System.Windows.Forms.Button
    Friend WithEvents wild As System.Windows.Forms.Button
    Friend WithEvents craze As System.Windows.Forms.Button
    Friend WithEvents burden As System.Windows.Forms.Button
    Friend WithEvents Button25 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents skillcount As System.Windows.Forms.Timer
End Class
