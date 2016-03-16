Public Class Form1
    'Fixed Variable Names from WarrX to X
    'Renamed CheckBoxes to their respective classes
    'Refer to other comments in the code

    '/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\'

    Public Shared Str As Integer 'Arms Warrior: Pow!
    Public Shared Agi As Integer 'Dodge dodge  dodge  dodge  dodge  dodge  dodge  dodge  dodge  dodge  dodge  dodge  dodge.
    Public Shared Con As Integer 'If you were shot in the shoulder; the higher the better.
    Public Shared Lck As Integer '5 shots or 6?
    Public Shared Int As Integer 'Are you going to read a book, or are you dun did gonna learn yerself a book?
    Dim Roflmaolol As Integer    'Dat Reset Timer Variable though
    Public Shared charWarr As Integer   'You're a warrior, Harry
    Public Shared charTact As Integer   'You're a tactician, Harry
    Public Shared charMage As Integer   'You're a wizard, Harry
    Public Shared charRogu As Integer   'You're a rogue, Harry
    Public Shared charUnbo As Integer   'You're a staircase child, Harry
    Public Shared PlayerHX As Integer   'Min Hit Range
    Public Shared PlayerHY As Integer   'Max Hit Range
    Public Shared PlayerDmg As Integer  'Base Player Damage


    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        begin.Show()
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Label2.Text = Start.Variable.asdfmod
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles WarriorBox.CheckedChanged
        charWarr = WarriorBox.Enabled
        Form1.Str = 10
        Form1.Agi = 5
        Form1.Con = 7
        Form1.Lck = 5
        Form1.Int = 3
        WarriorBox.Enabled = False
        UnBox.Enabled = False
        RogueBox.Enabled = False
        MageBox.Enabled = False
        TactBox.Enabled = False
        Form1.PlayerHX = 0
        Form1.PlayerHY = 50
        Form1.PlayerDmg = 10
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles TactBox.CheckedChanged
        charTact = TactBox.Enabled
        Form1.Str = 7   'Added a bit of beef because bows are tough. Prev 5
        Form1.Agi = 8   'To save disputes versus Rogue. Prev 10
        Form1.Con = 5
        Form1.Lck = 5   'Base luck is base. Prev 7
        Form1.Int = 6   'A tactician is going to have at LEAST slightly above average intelligence (Prev 3)
        WarriorBox.Enabled = False
        UnBox.Enabled = False
        RogueBox.Enabled = False
        MageBox.Enabled = False
        TactBox.Enabled = False
        Form1.PlayerHX = 0
        Form1.PlayerHY = 90
        Form1.PlayerDmg = 5
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles UnBox.CheckedChanged
        charUnbo = UnBox.Enabled
        'Even though you have nothing special about you, you're still going to have some bits to you
        Form1.Str = 2 'Prev 0
        Form1.Agi = 2 'Prev 0
        Form1.Con = 2 'Prev 0
        Form1.Lck = 2 'Prev 0
        Form1.Int = 2 'Prev 0
        WarriorBox.Enabled = False
        UnBox.Enabled = False
        RogueBox.Enabled = False
        MageBox.Enabled = False
        TactBox.Enabled = False
        Form1.PlayerHX = 25
        Form1.PlayerHY = 75
        Form1.PlayerDmg = 25
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles MageBox.CheckedChanged
        charMage = MageBox.Enabled
        Form1.Str = 3
        Form1.Agi = 5
        Form1.Con = 2 'Because glass cannons. Prev 5
        Form1.Lck = 7
        Form1.Int = 10
        WarriorBox.Enabled = False
        UnBox.Enabled = False
        RogueBox.Enabled = False
        MageBox.Enabled = False
        TactBox.Enabled = False
        Form1.PlayerHX = 10
        Form1.PlayerHY = 80
        Form1.PlayerDmg = 15
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RogueBox.CheckedChanged
        charRogu = RogueBox.Enabled
        Form1.Str = 5
        Form1.Agi = 9 'Need them nimble fingers for 100 (legendary 100) Lockpicking skill and cat burglar status. Prev 7
        Form1.Con = 5 'Little more rough about the edges, your bones are no longer glass. Prev 3
        Form1.Lck = 10
        Form1.Int = 3
        WarriorBox.Enabled = False
        UnBox.Enabled = False
        RogueBox.Enabled = False
        MageBox.Enabled = False
        TactBox.Enabled = False
        Form1.PlayerHX = 33
        Form1.PlayerHY = 99
        Form1.PlayerDmg = 12
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
        Label4.Text = Form1.Str
        Label5.Text = Form1.Agi
        Label6.Text = Form1.Con
        Label12.Text = Form1.Lck
        Label14.Text = Form1.Int
        Label16.Text = Form1.PlayerHX
        Label18.Text = Form1.PlayerHY
        Label20.Text = Form1.PlayerDmg
    End Sub

    Private Sub TheThing_Tick(sender As System.Object, e As System.EventArgs) Handles ResetTimer.Tick
        Form1.Str = 0
        Form1.Agi = 0
        Form1.Con = 0
        Form1.Lck = 0
        Form1.Int = 0
        Form1.PlayerHX = 0
        Form1.PlayerHY = 0
        Form1.PlayerDmg = 0
        WarriorBox.Enabled = True
        UnBox.Enabled = True
        RogueBox.Enabled = True
        MageBox.Enabled = True
        TactBox.Enabled = True
        Roflmaolol += 1
        If Roflmaolol = 10 Then
            Roflmaolol = 0
            ResetTimer.Enabled = False
        End If
    End Sub
End Class
