Public Class BrillTest
    Dim WeaponDmg As Integer
    Dim AC As Integer
    Dim MinHit As Integer
    Dim MaxHit As Integer
    Dim Armor As String
    Dim HealBonus As Integer
    Dim EHealth As Integer
    Dim EHealth2 As Integer
    Dim RHealth As Integer
    Dim HoldWep As String
    Dim TierNum As Integer
    Dim EClass As Integer
    Dim RanGen As New Random
    Dim EHealBonus As Integer
    Dim EAC As Integer
    Dim EDamage As Integer
    Dim EWep As Integer
    Dim Plug As Integer
    Dim EWepGen As New Random
    Dim PRanGen As New Random
    Dim Xgen As Integer
    Dim Ygen As Integer
    Dim GenNum As Integer
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If TierNum = 1 Then
            Weapon1.Text = "Short Sword"
            Weapon2.Text = "Long Sword"
            Weapon3.Text = "Two-handed Sword"
            Weapon1.Visible = True
            Weapon2.Visible = True
            Weapon3.Visible = True
            Clothie.Visible = True
            Clothie.Enabled = False
            Leather.Visible = True
            Chain.Visible = True
            Chain.Enabled = True
            Kitchen.Enabled = True
            Kitchen.Visible = True
            Clothie.Text = "Cloth Armor T1"
            Leather.Text = "Leather Armor T1"
            Chain.Text = "Chain Armor T1"
            Kitchen.Text = "Plate Armor T1"
        End If
        If TierNum = 2 Then
            Weapon1.Text = "Short Sword v2"
            Weapon2.Text = "Long Sword v2"
            Weapon3.Text = "Two-handed Sword v2"
            Weapon1.Visible = True
            Weapon2.Visible = True
            Weapon3.Visible = True
            Clothie.Visible = True
            Clothie.Enabled = False
            Leather.Visible = True
            Chain.Visible = True
            Chain.Enabled = True
            Kitchen.Enabled = True
            Kitchen.Visible = True
            Clothie.Text = "Cloth Armor T2"
            Leather.Text = "Leather Armor T2"
            Chain.Text = "Chain Armor T2"
            Kitchen.Text = "Plate Armor T2"
        End If
        If TierNum = 3 Then
            Weapon1.Text = "Short Sword v3"
            Weapon2.Text = "Long Sword v3"
            Weapon3.Text = "Two-handed Sword v3"
            Weapon1.Visible = True
            Weapon2.Visible = True
            Weapon3.Visible = True
            Clothie.Visible = True
            Clothie.Enabled = False
            Leather.Visible = True
            Chain.Visible = True
            Chain.Enabled = True
            Kitchen.Enabled = True
            Kitchen.Visible = True
            Clothie.Text = "Cloth Armor T3"
            Leather.Text = "Leather Armor T3"
            Chain.Text = "Chain Armor T3"
            Kitchen.Text = "Plate Armor T3"
        End If
    End Sub

    Private Sub Updater_Tick(sender As System.Object, e As System.EventArgs) Handles Updater.Tick
        TotalHealth.Text = 100 + HealBonus
        ProgressBar1.Maximum = 100 + AC
        ProgressBar1.Value = 100 + HealBonus
        DamageLabel.Text = WeaponDmg
        MinLabel.Text = MinHit
        MaxLabel.Text = MaxHit
        AddHealth.Text = AC
        ArmLabel.Text = Armor
        Label11.Text = EHealth
        WepLabel.Text = HoldWep
        Label16.Text = TierNum
        RanLabel.Text = EClass
        ActEHealth.Text = 100 + EHealBonus
        ClassE.Text = EClass
        If EHealth < 0 Then
            EHealth = 0
        End If
        If EClass = 1 Then
            ClassE.Text = "Warrior"
            EnemyGen.Enabled = True
        ElseIf EClass = 2 Then
            ClassE.Text = "Rogue"
        ElseIf EClass = 3 Then
            ClassE.Text = "Mage"
        ElseIf EClass = 4 Then
            ClassE.Text = "Tactician"
        ElseIf EClass = 5 Then
            ClassE.Text = "Unborn"
        End If
        Label21.Text = EDamage
        Label24.Text = Plug
        Label28.Text = GenNum
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Weapon1.Click
        If Weapon1.Text = "Short Sword" Then
            WeaponDmg = 15
            MinHit = 0
            MaxHit = 50
            HoldWep = "Short Sword"
        End If
        If Weapon1.Text = "Dagger" Then
            WeaponDmg = 12
            MinHit = 0
            MaxHit = 75
            HoldWep = "Dagger"
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Weapon2.Click
        If Weapon2.Text = "Long Sword" Then
            MinHit = 33
            MaxHit = 66
            WeaponDmg = 20
            HoldWep = "Long Sword"
        End If
        If Weapon2.Text = "Short Sword" Then
            WeaponDmg = 14
            MinHit = 0
            MaxHit = 50
            HoldWep = "Short Sword"
        End If

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Weapon3.Click
        If Weapon3.Text = "Two-handed Sword" Then
            MinHit = 25
            MaxHit = 50
            WeaponDmg = 45
            HoldWep = "Two-handed Sword"
        End If
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Leather.Click
        Armor = "Leather"
        AC = 10
        HealBonus = 10
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Chain.Click
        Armor = "Chain Mail"
        AC = 20
        HealBonus = 20
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Kitchen.Click
        Armor = "Plate Mail"
        AC = 30
        HealBonus = 30
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        ProgressBar2.Increment(-WeaponDmg)
        EHealth = EHealth - WeaponDmg
    End Sub

    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        ProgressBar2.Increment(100)
        EHealth = 100
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        Weapon1.Text = "Dagger"
        Weapon2.Text = "Short Sword"
        Weapon1.Visible = True
        Weapon2.Visible = True
        Weapon3.Visible = False
        Clothie.Visible = True
        Clothie.Enabled = True
        Leather.Visible = True
        Chain.Visible = True
        Chain.Enabled = False
        Kitchen.Enabled = False
        Kitchen.Visible = True
        If TierNum = 1 Then
            Weapon1.Text = "Dagger"
            Weapon2.Text = "Short Sword"
            Weapon1.Visible = True
            Weapon2.Visible = True
            Clothie.Visible = True
            Clothie.Enabled = False
            Leather.Visible = True
            Chain.Visible = True
            Chain.Enabled = False
            Kitchen.Enabled = False
            Kitchen.Visible = True
            Clothie.Text = "Cloth Armor T1"
            Leather.Text = "Leather Armor T1"
            Chain.Text = "Chain Armor T1"
            Kitchen.Text = "Plate Armor T1"
        End If
        If TierNum = 2 Then
            Weapon1.Text = "Dagger v2"
            Weapon2.Text = "Short Sword v2"
            Weapon1.Visible = True
            Weapon2.Visible = True
            Weapon3.Visible = False
            Clothie.Visible = True
            Clothie.Enabled = False
            Leather.Visible = True
            Chain.Visible = True
            Chain.Enabled = False
            Kitchen.Enabled = False
            Kitchen.Visible = True
            Clothie.Text = "Cloth Armor T2"
            Leather.Text = "Leather Armor T2"
            Chain.Text = "Chain Armor T2"
            Kitchen.Text = "Plate Armor T2"
        End If
        If TierNum = 3 Then
            Weapon1.Text = "Short Sword v3"
            Weapon2.Text = "Long Sword v3"
            Weapon3.Text = "Two-handed Sword v3"
            Weapon1.Visible = True
            Weapon2.Visible = True
            Weapon3.Visible = False
            Clothie.Visible = True
            Clothie.Enabled = False
            Leather.Visible = True
            Chain.Visible = True
            Chain.Enabled = False
            Kitchen.Enabled = False
            Kitchen.Visible = True
            Clothie.Text = "Cloth Armor T3"
            Leather.Text = "Leather Armor T3"
            Chain.Text = "Chain Armor T3"
            Kitchen.Text = "Plate Armor T3"
        End If
    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If ComboBox1.Text = 1 Then
            ComboBox1.Enabled = False
            TierNum = 1
        End If
        If ComboBox1.Text = 2 Then
            ComboBox1.Enabled = False
            TierNum = 2
        End If
        If ComboBox1.Text = 3 Then
            ComboBox1.Enabled = False
            TierNum = 3
        End If
        Button2.Visible = True
        Button9.Visible = True
    End Sub

    Private Sub Button3_Click_1(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        ComboBox1.Text = " "
        Weapon1.Text = " "
        Weapon2.Text = " "
        Weapon3.Text = " "
        Clothie.Text = " "
        Leather.Text = " "
        Chain.Text = " "
        Kitchen.Text = " "
        TierNum = 0
        ComboBox1.Enabled = True
        Button2.Visible = False
        Button9.Visible = False
        Weapon1.Visible = False
        Weapon2.Visible = False
        Weapon3.Visible = False
        Clothie.Visible = False
        Leather.Visible = False
        Chain.Visible = False
        Kitchen.Visible = False
    End Sub

    Private Sub Button4_Click_1(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Plugger.Enabled = True
    End Sub

    Private Sub Randomizer_Tick_1(sender As System.Object, e As System.EventArgs) Handles Randomizer.Tick
        EClass = RanGen.Next(1, 6) 'Warrior, Rogue, Mage, Tact, Un
    End Sub

    Private Sub Plugger_Tick(sender As System.Object, e As System.EventArgs) Handles Plugger.Tick
        Plug += 1
        Randomizer.Enabled = False
        EnemyGen.Enabled = False

        If Plug = 2000 Then
            Randomizer.Enabled = True
            Plugger.Enabled = False
            Plug = 0
        End If
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Plug = 0
        Randomizer.Enabled = True
        Plugger.Enabled = False
    End Sub

    Private Sub WarriorGen_Tick(sender As System.Object, e As System.EventArgs) Handles EnemyGen.Tick
        If GenNum = 200 Then
            EnemyGen.Enabled = False
        End If
        EWep = RanGen.Next(2, 5)
        GenNum += 1
        If EWep = 2 Then
            Label23.Text = "Short Sword"
            EDamage = 15
            EnemyGen.Enabled = False
        End If
        If EWep = 3 Then
            Label23.Text = "Long Sword"
            EDamage = 20
            EnemyGen.Enabled = False
        End If
        If EWep = 4 Then
            Label23.Text = "Two-handed Sword"
            EDamage = 45
            EnemyGen.Enabled = False
        End If
    End Sub

End Class
