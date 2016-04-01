Public Class Form1
    'ALL VARIABLES FROM HERE IN VARIABLES.VB
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        begin.Show()
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Label2.Text = Variables.Fight.asdfmod
        Button1.Visible = False
    End Sub
    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles WarriorBox.CheckedChanged
        Variables.Fight.charWarr = 1
        Variables.Fight.charWarr = WarriorBox.Enabled
        Variables.Skills.Str = 10
        Variables.Skills.Agi = 5
        Variables.Skills.Con = 7
        Variables.Skills.Lck = 5
        Variables.Skills.Int = 3
        WarriorBox.Enabled = False
        UnBox.Enabled = False
        RogueBox.Enabled = False
        MageBox.Enabled = False
        TactBox.Enabled = False
        Variables.Skills.PlayerHX = 0
        Variables.Skills.PlayerHY = 50
        Variables.Skills.PlayerDmg = 10
        Button1.Visible = True
        begin.Updater.Enabled = True
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles TactBox.CheckedChanged
        Variables.Fight.charTact = TactBox.Enabled
        Variables.Skills.Str = 7   'Added a bit of beef because bows are tough. Prev 5
        Variables.Skills.Agi = 8   'To save disputes versus Rogue. Prev 10
        Variables.Skills.Con = 5
        Variables.Skills.Lck = 5   'Base luck is base. Prev 7
        Variables.Skills.Int = 6   'A tactician is going to have at LEAST slightly above average intelligence (Prev 3)
        WarriorBox.Enabled = False
        UnBox.Enabled = False
        RogueBox.Enabled = False
        MageBox.Enabled = False
        TactBox.Enabled = False
        Variables.Skills.playerHX = 0
        Variables.Skills.PlayerHY = 90
        Variables.Skills.PlayerDmg = 5
        Button1.Visible = True
        begin.Updater.Enabled = True
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles UnBox.CheckedChanged
        Variables.Fight.charUnbo = UnBox.Enabled
        'Even though you have nothing special about you, you're still going to have some bits to you
        Variables.Skills.Str = 2 'Prev 0
        Variables.Skills.Agi = 2 'Prev 0
        Variables.Skills.Con = 2 'Prev 0
        Variables.Skills.Lck = 2 'Prev 0
        Variables.Skills.Int = 2 'Prev 0
        WarriorBox.Enabled = False
        UnBox.Enabled = False
        RogueBox.Enabled = False
        MageBox.Enabled = False
        TactBox.Enabled = False
        Variables.Skills.playerHX = 25
        Variables.Skills.PlayerHY = 75
        Variables.Skills.PlayerDmg = 25
        Button1.Visible = True
        begin.Updater.Enabled = True
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles MageBox.CheckedChanged
        Variables.Fight.charMage = MageBox.Enabled
        Variables.Skills.Str = 3
        Variables.Skills.Agi = 5
        Variables.Skills.Con = 2 'Because glass cannons. Prev 5
        Variables.Skills.Lck = 7
        Variables.Skills.Int = 10
        WarriorBox.Enabled = False
        UnBox.Enabled = False
        RogueBox.Enabled = False
        MageBox.Enabled = False
        TactBox.Enabled = False
        Variables.Skills.playerHX = 10
        Variables.Skills.PlayerHY = 80
        Variables.Skills.PlayerDmg = 15
        Button1.Visible = True
        begin.Updater.Enabled = True
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RogueBox.CheckedChanged
        Variables.Fight.charRogu = RogueBox.Enabled
        Variables.Skills.Str = 5
        Variables.Skills.Agi = 9 'Need them nimble fingers for 100 (legendary 100) Lockpicking skill and cat burglar status. Prev 7
        Variables.Skills.Con = 5 'Little more rough about the edges, your bones are no longer glass. Prev 3
        Variables.Skills.Lck = 10
        Variables.Skills.Int = 3
        WarriorBox.Enabled = False
        UnBox.Enabled = False
        RogueBox.Enabled = False
        MageBox.Enabled = False
        TactBox.Enabled = False
        Variables.Skills.playerHX = 33
        Variables.Skills.PlayerHY = 99
        Variables.Skills.PlayerDmg = 12
        Button1.Visible = True
        begin.Updater.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        'clear attributes
        WarriorBox.Checked = False
        UnBox.Checked = False
        RogueBox.Checked = False
        MageBox.Checked = False
        TactBox.Checked = False
        ResetTimer.Enabled = True
    End Sub

    Private Sub Updater_Tick(sender As System.Object, e As System.EventArgs) Handles Updater.Tick
        Label4.Text = Variables.Skills.Str
        Label5.Text = Variables.Skills.Agi
        Label6.Text = Variables.Skills.Con
        Label12.Text = Variables.Skills.Lck
        Label14.Text = Variables.Skills.Int
        Label16.Text = Variables.Skills.playerHX
        Label18.Text = Variables.Skills.playerHY
        Label20.Text = Variables.Skills.PlayerDmg
    End Sub

    Private Sub TheThing_Tick(sender As System.Object, e As System.EventArgs) Handles ResetTimer.Tick
        Variables.Skills.Str = 0
        Variables.Skills.Agi = 0
        Variables.Skills.Con = 0
        Variables.Skills.Lck = 0
        Variables.Skills.Int = 0
        Variables.Skills.playerHX = 0
        Variables.Skills.playerHY = 0
        Variables.Skills.PlayerDmg = 0
        WarriorBox.Enabled = True
        UnBox.Enabled = True
        RogueBox.Enabled = True
        MageBox.Enabled = True
        TactBox.Enabled = True
        Variables.Skills.Roflmaolol += 1
        If Variables.Skills.Roflmaolol = 10 Then
            Variables.Skills.Roflmaolol = 0
            ResetTimer.Enabled = False
        End If
    End Sub
End Class
