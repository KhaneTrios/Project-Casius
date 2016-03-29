Public Class Fight
    'no more variables C:
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Fight_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If Variables.Fight.skillOneBought = True Then
            skillOne.Text = "Charge"
        End If

        'This is for the class name at the top of the screen 3/15
        If Variables.Fight.charWarr = True Then
            className.Text = "Warrior"
        End If
        If Variables.Fight.charMage = True Then
            className.Text = "Mage"
        End If
        If Variables.Fight.charRogu = True Then
            className.Text = "Rogue"
        End If
        If Variables.Fight.charTact = True Then
            className.Text = "Tactician"
        End If
        If Variables.Fight.charUnbo = True Then
            className.Text = "Unborn"
        End If
        If Variables.Fight.asdfmod = "Hooty McOwlface" Then
            className.Text = "God Damned Owl"
        End If
        If Variables.Fight.asdfmod = "tedcruz" Or Variables.Fight.asdfmod = "Ted Cruz" Then
            className.Text = "Zodiac Killer"
        End If
        'End of class name at the top of the screen

        'This is the for the skill buttons on the screen 3/15
        'If Form1.charWarr = True Then
        'skillOne.Text = "Charge"
        'skillTwo.Text = "Backwards Lash"
        'skillThree.Text = "Enrage"
        'skillFour.Text = "Core Slam"

        If Variables.Fight.charTact = True Then
            skillOne.Text = "Scout"
            skillTwo.Text = "Caltrop Launch"
            skillThree.Text = "Over-Plan"
            skillFour.Text = "Poison Bomb Barrage"
        End If

        If Variables.Fight.charMage = True Then
            skillOne.Text = "Shards of Ice"
            skillFour.Text = "Arcane Whirlwind"
            skillTwo.Text = "Lightning Wave"
            skillThree.Text = "Fire Cage"
        End If

        If Variables.Fight.charRogu = True Then
            skillOne.Text = "Backstab"
            skillFour.Text = "Shadow Strike"
            skillTwo.Text = "Parry"
            skillThree.Text = "Invisible"
        End If

        If Variables.Fight.charUnbo = True Then
            skillOne.Text = "Burden"
            skillFour.Text = "Redemption"
            skillTwo.Text = "Craze"
            skillThree.Text = "Wild"
        End If

        If Variables.Fight.asdfmod = "Hooty McOwlface" Then
            skillOne.Text = "Hoot"
            skillTwo.Text = "More Hoot"
            skillThree.Text = "Dat Swoop"
            skillFour.Text = "Ever Effective Screech"
        End If
        'hero name above hero picture box
        Label13.Text = Variables.Fight.asdfmod


        'enemy name above enemy pic
        Variables.Fight.Choices = Variables.Fight.opponentName.Next(1, 6)
        If Variables.Fight.Choices = 1 Then
            Variables.Fight.Jerkwad = "Random Warrior"
        End If
        If Variables.Fight.Choices = 2 Then
            Variables.Fight.Jerkwad = "Random Rogue"
        End If
        If Variables.Fight.Choices = 3 Then
            Variables.Fight.Jerkwad = "Random Mage"
        End If
        If Variables.Fight.Choices = 4 Then
            Variables.Fight.Jerkwad = "Random Unborn"
        End If
        If Variables.Fight.Choices = 5 Then
            Variables.Fight.Jerkwad = "Random Tactician"
        End If
        Variables.Fight.PHealth = 100
        Variables.Fight.EHealth = 100
        ProgressBar2.Increment(100)

        Label4.Text = Variables.Fight.EHealth
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        'ProgressBar2.Value = ProgressBar2.Value - 5
        'Label1.Text = ProgressBar1.Value
        'Label4.Text = ProgressBar2.Value
        Variables.Fight.plyrDmg = 5
        Variables.Fight.EHealth = Variables.Fight.EHealth - Variables.Fight.plyrDmg
        ProgressBar2.Increment(-Variables.Fight.plyrDmg)

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        'ProgressBar1.Value = ProgressBar1.Value - 5
        'Label1.Text = ProgressBar1.Value
        'Label4.Text = ProgressBar2.Value
        Variables.Fight.eDmg = 5
        Variables.Fight.PHealth = Variables.Fight.PHealth - Variables.Fight.eDmg
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles skillOne.Click
        If skillOne.Text = "Charge" Then
            ProgressBar2.Value = ProgressBar2.Value - 5
        End If
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles heroName.Click
        'this is the random fighting button
        PluggerV2.Enabled = True
        'If ProgressBar1.Value = 0 Then
        'MessageBox.Show("You have been defeated!", "Dead")
        'End If
        'If ProgressBar2.Value = 0 Then
        'MessageBox.Show("You have won!", "Opponent Slain!")
        'End If
    End Sub

    Private Sub Updater_Tick(sender As System.Object, e As System.EventArgs) Handles Updater.Tick
        Label6.Text = Variables.Fight.HC
        Label7.Text = Variables.Fight.EHC
        'Label1.Text = ProgressBar1.Value
        'Label4.Text = ProgressBar2.Value
        Label8.Text = Variables.Fight.playerHX
        Label10.Text = Variables.Fight.playerHY
        Label11.Text = Variables.Fight.PlayerDmg
        Label1.Text = Variables.Fight.PHealth
        Label4.Text = Variables.Fight.EHealth

        If Variables.Fight.PHealth < 0 Then
            Variables.Fight.PHealth = 0
        End If
        If Variables.Fight.EHealth < 0 Then
            Variables.Fight.EHealth = 0
        End If
        If ProgressBar1.Value = 0 Then
            heroName.Enabled = False
            RandomizerV2.Enabled = False
        End If
        If ProgressBar2.Value = 0 Then
            heroName.Enabled = False
            RandomizerV2.Enabled = False
        End If
        enemyName.Text = Variables.Fight.Jerkwad
    End Sub

    Private Sub PluggerV2_Tick(sender As System.Object, e As System.EventArgs) Handles PluggerV2.Tick
        Variables.Fight.Plug += 1
        RandomizerV2.Enabled = False
        If RandomizerV2.Enabled = False And Variables.Fight.EHC >= 51 And Variables.Fight.EHC <= 101 Then
            ProgressBar1.Value = ProgressBar1.Value - 10
            If ProgressBar1.Value < 0 Then
                ProgressBar1.Value = 0
            End If
        End If
        If RandomizerV2.Enabled = False And Variables.Fight.HC >= Variables.Fight.playerHX And Variables.Fight.HC <= Variables.Fight.playerHY Then

            If ProgressBar2.Value > 0 Then
                If ProgressBar2.Value < 0 Then
                    ProgressBar2.Value = 0
                End If
                ProgressBar2.Value = ProgressBar2.Value - Variables.Fight.PlayerDmg
                Variables.Fight.Plug = 2
            End If
        End If
        If Variables.Fight.Plug = 2 Then
            RandomizerV2.Enabled = True
            PluggerV2.Enabled = False
            Variables.Fight.Plug = 0
        End If
    End Sub

    Private Sub RandomizerV2_Tick(sender As System.Object, e As System.EventArgs) Handles RandomizerV2.Tick
        Variables.Fight.HC = Variables.Fight.AttackGen.Next(0, 101)
        Variables.Fight.EHC = Variables.Fight.AttackGen.Next(0, 101)
    End Sub

    Private Sub Button4_Click_1(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Variables.Fight.EHealth = 100
        Variables.Fight.PHealth = 100
        ProgressBar1.Increment(100)
        ProgressBar2.Increment(100)
    End Sub

    Private Sub Button5_Click_1(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        begin.Show()
        Me.Close()
    End Sub
End Class