﻿Public Class Fight
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
        'End of class name at the top of the screen

        'This is the for the skill buttons on the screen 3/15
        If Form1.charWarr = True Then
            skillOne.Text = "Charge"
        End If
        If Form1.charWarr = True Then
            skillTwo.Text = "Backwards Lash"
        End If
        If Form1.charWarr = True Then
            skillThree.Text = "Enrage"
        End If
        If Form1.charWarr = True Then
            skillFour.Text = "Core Slam"
        End If
        If Form1.charTact = True Then
            skillOne.Text = "Scout"
        End If
        If Form1.charTact = True Then
            skillTwo.Text = "Caltrop Launch"
        End If
        If Form1.charTact = True Then
            skillThree.Text = "Over-Plan"
        End If
        If Form1.charTact = True Then
            skillFour.Text = "Poison Bomb Barrage"
        End If
        If Form1.charMage = True Then
            skillOne.Text = "Shards of Ice"
        End If
        If Form1.charMage = True Then
            skillTwo.Text = "Lightning Wave"
        End If
        If Form1.charMage = True Then
            skillThree.Text = "Fire Cage"
        End If
        If Form1.charMage = True Then
            skillFour.Text = "Arcane Whirlwind"
        End If
        If Form1.charRogu = True Then
            skillOne.Text = "Backstab"
        End If
        If Form1.charRogu = True Then
            skillTwo.Text = "Parry"
        End If
        If Form1.charRogu = True Then
            skillThree.Text = "Invisible"
        End If
        If Form1.charRogu = True Then
            skillFour.Text = "Shadow Strike"
        End If
        If Form1.charUnbo = True Then
            skillOne.Text = "Burden"
        End If
        If Form1.charUnbo = True Then
            skillTwo.Text = "Craze"
        End If
        If Form1.charUnbo = True Then
            skillThree.Text = "Wild"
        End If
        If Form1.charUnbo = True Then
            skillFour.Text = "Redemption"
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
        ' If Form1.charWarr = True Then
        '     heroMana.Value = heroMana.Value - 10
        ' End If
        ' If Form1.charWarr = True Then
        '    ProgressBar2.Value = ProgressBar2.Value - 10
        'End If
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles heroName.Click
        'this is the random fighting button
        Plugger.Enabled = True

    End Sub

    Private Sub Updaete_Tick(sender As System.Object, e As System.EventArgs)
        Label6.Text = HC
        Label7.Text = EHC
        Label1.Text = ProgressBar1.Value
        Label4.Text = ProgressBar2.Value
        Label8.Text = Form1.PlayerHX
        Label10.Text = Form1.PlayerHY
        Label11.Text = Form1.PlayerDmg
        If ProgressBar1.Value = 0 Then
            heroName.Enabled = False
            Randomizer.Enabled = False
        End If
        If ProgressBar2.Value = 0 Then
            heroName.Enabled = False
            Randomizer.Enabled = False
        End If
        enemyName.Text = Jerkwad
    End Sub

    Private Sub Randomizer_Tick(sender As System.Object, e As System.EventArgs)
        HC = AttackGen.Next(0, 101)
        EHC = AttackGen.Next(0, 101)
    End Sub

    Private Sub Plugger_Tick(sender As System.Object, e As System.EventArgs)
        Plug += 1
        Randomizer.Enabled = False
        If Randomizer.Enabled = False And EHC >= 51 And EHC <= 101 Then
            If ProgressBar1.Value <= 0 Then
                ProgressBar1.Value = 0
            End If
            ProgressBar1.Value = ProgressBar1.Value - 5
            Plug = 2
        End If
        If Randomizer.Enabled = False And HC >= Form1.PlayerHX And HC <= Form1.PlayerHY Then
            If ProgressBar2.Value <= 0 Then
                ProgressBar2.Value = 0
            End If
            ProgressBar2.Value = ProgressBar2.Value - Form1.PlayerDmg
            Plug = 2
        End If
        If Plug = 2 Then
            Randomizer.Enabled = True
            Plugger.Enabled = False
            Plug = 0
        End If
    End Sub
End Class