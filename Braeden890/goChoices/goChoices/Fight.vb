Public Class Fight
    Dim AttackGen As New Random 'Self Explanatory
    Dim opponentName As New Random 'random opponent class above opponent picture
    Dim HC As Integer           'Player Hit chance
    Dim Plug As Integer         'Stops randomizer
    Dim EHC As Integer          'Enemy Hit chance
    Dim Jerkwad As String
    Dim Choices As Integer
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Fight_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'This is for the class name at the top of the screen 3/15
        If Form1.charWarr = True Then
            className.Text = "Warrior"
        End If
        If Form1.charMage = True Then
            className.Text = "Mage"
        End If
        If Form1.charRogu = True Then
            className.Text = "Rogue"
        End If
        If Form1.charTact = True Then
            className.Text = "Tactician"
        End If
        If Form1.charUnbo = True Then
            className.Text = "Unborn"
        End If
        If Start.Variable.asdfmod = "Hooty McOwlface" Then
            className.Text = "God Damned Owl"
        End If
        If Start.Variable.asdfmod = "tedcruz" Then
            className.Text = "The Zodiac Killer"
        End If
        If Start.Variable.asdfmod = "Ted Cruz" Then
            className.Text = "The Zodiac Killer"
        End If
        'End of class name at the top of the screen

        'This is the for the skill buttons on the screen 3/15
        If Form1.charWarr = True Then
            skillOne.Text = "Charge"
            skillTwo.Text = "Backwards Lash"
            skillThree.Text = "Enrage"
            skillFour.Text = "Core Slam"

        End If
        'If Form1.charWarr = True Then
        'End If
        'If Form1.charWarr = True Then

        'End If
        'If Form1.charWarr = True Then

        'End If
        If Form1.charTact = True Then
            skillOne.Text = "Scout"
            skillTwo.Text = "Caltrop Launch"
            skillThree.Text = "Over-Plan"
            skillFour.Text = "Poison Bomb Barrage"
        End If
        'If Form1.charTact = True Then

        'End If
        'If Form1.charTact = True Then

        'End If
        'If Form1.charTact = True Then

        'End If
        If Form1.charMage = True Then
            skillOne.Text = "Shards of Ice"
            skillFour.Text = "Arcane Whirlwind"
            skillTwo.Text = "Lightning Wave"
            skillThree.Text = "Fire Cage"
        End If
        'If Form1.charMage = True Then

        'End If
        'If Form1.charMage = True Then

        'End If
        'If Form1.charMage = True Then

        'End If
        If Form1.charRogu = True Then
            skillOne.Text = "Backstab"
            skillFour.Text = "Shadow Strike"
            skillTwo.Text = "Parry"
            skillThree.Text = "Invisible"
        End If
        'If Form1.charRogu = True Then

        'End If
        'If Form1.charRogu = True Then

        'End If
        'If Form1.charRogu = True Then

        'End If
        If Form1.charUnbo = True Then
            skillOne.Text = "Burden"
            skillFour.Text = "Redemption"
            skillTwo.Text = "Craze"
            skillThree.Text = "Wild"
        End If
        'If Form1.charUnbo = True Then

        'End If
        'If Form1.charUnbo = True Then

        'End If
        'If Form1.charUnbo = True Then

        'End If
        If Start.Variable.asdfmod = "Hooty McOwlface" Then
            skillOne.Text = "Hoot"
            skillTwo.Text = "More Hoot"
            skillThree.Text = "Dat Swoop"
            skillFour.Text = "Ever Effective Screech"
        End If
        'hero name above hero picture box
        Label13.Text = Start.Variable.asdfmod


        'enemy name above enemy pic
        Choices = opponentName.Next(1, 6)
        If Choices = 1 Then
            Jerkwad = "Random Warrior"
        End If
        If Choices = 2 Then
            Jerkwad = "Random Rogue"
        End If
        If Choices = 3 Then
            Jerkwad = "Random Mage"
        End If
        If Choices = 4 Then
            Jerkwad = "Random Unborn"
        End If
        If Choices = 5 Then
            Jerkwad = "Random Tactician"
        End If

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        ProgressBar2.Value = ProgressBar2.Value - 5
        Label1.Text = ProgressBar1.Value
        Label4.Text = ProgressBar2.Value
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        ProgressBar1.Value = ProgressBar1.Value - 5
        Label1.Text = ProgressBar1.Value
        Label4.Text = ProgressBar2.Value
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles skillOne.Click
        If Form1.charWarr = True Then
            heroMana.Value = heroMana.Value - 10
        End If
        If Form1.charWarr = True Then
            ProgressBar2.Value = ProgressBar2.Value - 10
        End If
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles heroName.Click
        'this is the random fighting button
        PluggerV2.Enabled = True
        If ProgressBar1.Value = 0 Then
            MessageBox.Show("You have been defeated!", "Dead")
        End If

    End Sub

    Private Sub Updater_Tick(sender As System.Object, e As System.EventArgs) Handles Updater.Tick
        Label6.Text = HC
        Label7.Text = EHC
        Label1.Text = ProgressBar1.Value
        Label4.Text = ProgressBar2.Value
        Label8.Text = Form1.PlayerHX
        Label10.Text = Form1.PlayerHY
        Label11.Text = Form1.PlayerDmg
        If ProgressBar2.Value < 0 Then
            ProgressBar2.Value = 0
        End If
        If ProgressBar1.Value = 0 Then
            heroName.Enabled = False
            RandomizerV2.Enabled = False
        End If
        If ProgressBar2.Value = 0 Then
            heroName.Enabled = False
            RandomizerV2.Enabled = False
        End If
        enemyName.Text = Jerkwad
    End Sub

    Private Sub PluggerV2_Tick(sender As System.Object, e As System.EventArgs) Handles PluggerV2.Tick
        Plug += 1
        RandomizerV2.Enabled = False
        If RandomizerV2.Enabled = False And EHC >= 51 And EHC <= 101 Then
            ProgressBar1.Value = ProgressBar1.Value - 10
            If ProgressBar1.Value < 0 Then
                ProgressBar1.Value = 0
            End If
        End If
        If RandomizerV2.Enabled = False And HC >= Form1.PlayerHX And HC <= Form1.PlayerHY Then

            If ProgressBar2.Value > 0 Then
                If ProgressBar2.Value < 0 Then
                    ProgressBar2.Value = 0
                End If
                ProgressBar2.Value = ProgressBar2.Value - Form1.PlayerDmg
                Plug = 2
            End If
        End If
        If Plug = 2 Then
            RandomizerV2.Enabled = True
            PluggerV2.Enabled = False
            Plug = 0
        End If
    End Sub

    Private Sub RandomizerV2_Tick(sender As System.Object, e As System.EventArgs) Handles RandomizerV2.Tick
        HC = AttackGen.Next(0, 101)
        EHC = AttackGen.Next(0, 101)
    End Sub
End Class