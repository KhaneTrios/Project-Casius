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


    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
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
        If EHealth < 0 Then
            EHealth = 0
        End If
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
    End Sub
End Class
