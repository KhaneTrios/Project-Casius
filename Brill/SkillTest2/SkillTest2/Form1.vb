Public Class Form1
    Dim PHealth As Integer
    Dim EHealth As Integer
    Dim Turn As Integer
    Dim BurnTick As Integer
    Dim StunGen As New Random
    Dim StunMod As Integer
    Dim Stunned As Integer
    Dim MissChance As New Random
    Dim MissValue As Integer
    Dim Slowtick As Integer
    Dim MissTrue As Integer
    Dim Poke As Integer
    Dim Drip As Integer
    Dim Hemo As Integer
    Dim BldDmg As Integer
    Dim Clot As Integer
    Dim Toxin As Integer
    Dim PsnDmg As Integer
    Dim WarrCD As Integer
    Dim TactCD As Integer
    Dim TactMod As Integer
    Dim RogueCD As Integer
    Dim UnbornCD As Integer
    Dim CDClick As Integer
    Dim BleedChance As New Random
    Dim BCMod As Integer
    Dim BonusDmg As Integer
    Dim TempTick As Integer
    Dim PAttackGen As New Random
    Dim PHit As Integer
    Dim CalCount As Integer
    Dim CalExt As Integer
    Dim TactBonus As Integer
    Dim ToxChance As New Random
    Dim ToxMod As Integer
    Dim RogueMod As Integer
    Dim RogueDmgMod As Integer
    Dim Edmg As Integer
    Dim Ambush As Integer
    Dim RogueLock As Integer
    Dim UnbornMod As Integer
    Dim SpeedMod As Integer
    Dim TrueEDmg = 6
    Dim UnDmg As Integer
    Dim UnHeal As Integer

    Private Sub Updater_Tick(sender As Object, e As EventArgs) Handles Updater.Tick
        PHealthValue.Text = PHealth
        EHealthValue.Text = EHealth
        TurnLabel.Text = Turn
        BleedStack.Text = Hemo
        BldDmg = 1 * Hemo
        PsnDmg = 6 * Toxin
        ToxStack.Text = Toxin
        CdLabel.Text = CDClick
        RDmgLabel.Text = RogueDmgMod
        If UnbornMod = 4 Then
            RageLabel.Text = UnDmg
        End If
        If PHealth > 2000 Then
            PHealth = 2000
            PlayerBar.Increment(PHealth)
        End If
        If TactMod = 1 Then
            RichTextBox1.Text = "Next Player Attack: Guaranteed Hit"
        ElseIf TactMod = 2 Then
            RichTextBox1.Text = "The Enemy is Surrounded By Caltrops"
        End If
        If BonusDmg = 0 Then
            RageLabel.Text = "(Bonus Damage)"
        Else
            RageLabel.Text = BonusDmg
        End If
        RageLabel.Text = BonusDmg
        If PHealth < 2000 Or EHealth < 2000 Then
            Reset.Enabled = True
        Else
            Reset.Enabled = False
        End If
        If PHealth < 0 Then
            PHealth = 0
            BleedTimer.Enabled = False
            ToxinTimer.Enabled = False
            SlowTimer.Enabled = False
        End If
        If EHealth < 0 Then
            EHealth = 0
            BleedTimer.Enabled = False
            ToxinTimer.Enabled = False
            SlowTimer.Enabled = False
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PHealth = 2000
        EHealth = 2000
        PlayerBar.Increment(PHealth)
        EnemyBar.Increment(EHealth)
        Hemo = 1
        Toxin = 1
        RogueDmgMod = 1
    End Sub

    Private Sub BurnTime_Tick(sender As Object, e As EventArgs) Handles BurnTime.Tick
        BurnTick += 1
        If BurnTick = 12 Then
            BurnTime.Enabled = False
            BurnTick = 0
            BurnButton.Enabled = True
        End If
        EnemyBar.Increment(-1)
        EHealth = EHealth - 1
    End Sub

    Private Sub StunTimer_Tick(sender As Object, e As EventArgs) Handles StunTimer.Tick
        Stunned += 1
        EAttack.Enabled = False
        If Poke = 1 Then
            StunCheck.Text = "Yes"
            If Stunned = 12 Then
                StunTimer.Enabled = False
                Stunned = 0
                Stun1.Enabled = True
                Stun2.Enabled = True
                EAttack.Enabled = True
            End If
        End If

        If Poke = 2 Then
            StunCheck.Text = "Yes"
            If Stunned = 12 Then
                StunTimer.Enabled = False
                Stunned = 0
                Stun1.Enabled = True
                Stun2.Enabled = True
                EAttack.Enabled = True
            End If
        End If

        If Poke = 3 Then
            StunCheck.Text = "Yes"
            If Stunned = 20 Then
                StunTimer.Enabled = False
                Stunned = 0
                WarrCharge.Enabled = True
                EAttack.Enabled = True
            End If
        End If

        If Poke = 4 Then
            StunCheck.Text = "Yes"
            If Stunned = 40 Then
                StunTimer.Enabled = False
                Stunned = 0
                EAttack.Enabled = True
            End If
        End If
    End Sub

    Private Sub SlowTimer_Tick(sender As Object, e As EventArgs) Handles SlowTimer.Tick
        Slowtick += 1
        SlowCheck.Text = "Slowed"
        RichTextBox1.Text = "Next attack against you will miss"
        If Slowtick = 1 Then
            SlowTimer.Enabled = False
            Slowtick = 0
            MissTrue = 1
        End If
    End Sub

    Private Sub BleedTimer_Tick(sender As Object, e As EventArgs) Handles BleedTimer.Tick
        Drip += 1
        EnemyBar.Increment(-BldDmg)
        EHealth = EHealth - BldDmg
        If Drip = 10 Then
            BleedTimer.Enabled = False
            Drip = 0
            Hemo = 1
            Bleeding.Enabled = True
            HemoStack.Enabled = True
        End If

        If CalCount = 1 Then
            If Drip = 9 Then
                Drip = 0
                CalExt += 1
            End If
        End If

        If CalExt = 10 Then
            BleedTimer.Enabled = False
            TactCalLaunch.Enabled = True
            CalCount = 0
            Drip = 0
            CalExt = 0
        End If
    End Sub

    Private Sub ToxinTimer_Tick(sender As Object, e As EventArgs) Handles ToxinTimer.Tick
        Clot += 1
        EnemyBar.Increment(-PsnDmg)
        EHealth = EHealth - PsnDmg
        If Clot = 10 Then
            ToxinTimer.Enabled = False
            Clot = 0
            Toxin = 1
            ToxInc.Enabled = True
            ToxDebuff.Enabled = True
        End If
    End Sub

    Private Sub BurnButton_Click_1(sender As Object, e As EventArgs) Handles BurnButton.Click
        BurnTime.Enabled = True
        Turn += 1
        BurnButton.Enabled = False
    End Sub

    Private Sub Stun1_Click(sender As Object, e As EventArgs) Handles Stun1.Click
        Stun1.Enabled = False
        Turn += 1
        Poke = 1
        StunMod = StunGen.Next(1, 101)
        If StunMod >= 20 And StunMod <= 30 Then
            StunTimer.Enabled = True
            EnemyBar.Increment(-2)
            EHealth = EHealth - 2
            If StunTimer.Enabled = True Then
                Stun1.Enabled = False
                Stun2.Enabled = False
            End If
        Else
            StunCheck.Text = "Nope"
            PlayerBar.Increment(-4)
            PHealth = PHealth - 4
            Stun1.Enabled = True
        End If
    End Sub

    Private Sub Stun2_Click(sender As Object, e As EventArgs) Handles Stun2.Click
        Stun2.Enabled = False
        Turn += 1
        Poke = 2
        StunMod = StunGen.Next(1, 101)
        If StunMod >= 30 And StunMod <= 50 Then
            StunTimer.Enabled = True
            EnemyBar.Increment(-1)
            EHealth = EHealth - 1
            If StunTimer.Enabled = True Then
                Stun1.Enabled = False
                Stun2.Enabled = False
            End If
        Else
            StunCheck.Text = "How about no"
            PlayerBar.Increment(-8)
            PHealth = PHealth - 8
            Stun2.Enabled = True
        End If
    End Sub

    Private Sub Slow_Click(sender As Object, e As EventArgs) Handles Slow.Click
        Slow.Enabled = False
        MissValue = MissChance.Next(1, 101)
        Turn += 1
        If MissValue >= 35 And MissValue <= 68 Then
            SlowTimer.Enabled = True
            EnemyBar.Increment(-2)
            EHealth = EHealth - 2
        Else
            PlayerBar.Increment(-2)
            PHealth = PHealth - 2
            Slow.Enabled = True
        End If
    End Sub

    Private Sub Bleeding_Click(sender As Object, e As EventArgs) Handles Bleeding.Click
        Bleeding.Enabled = False
        BleedTimer.Enabled = True
        HemoStack.Enabled = False
    End Sub

    Private Sub ToxDebuff_Click(sender As Object, e As EventArgs) Handles ToxDebuff.Click
        ToxDebuff.Enabled = False
        ToxinTimer.Enabled = True
        ToxInc.Enabled = False
    End Sub

    Private Sub SteelBeams_Click(sender As Object, e As EventArgs) Handles SteelBeams.Click
        ToxinTimer.Enabled = True
        BleedTimer.Enabled = True
        Bleeding.Enabled = False
        HemoStack.Enabled = False
        ToxInc.Enabled = False
        ToxDebuff.Enabled = False
    End Sub

    Private Sub HemoStack_Click(sender As Object, e As EventArgs) Handles HemoStack.Click
        Hemo += 1
        If Hemo = 10 Then
            HemoStack.Enabled = False
        End If
    End Sub

    Private Sub ToxInc_Click(sender As Object, e As EventArgs) Handles ToxInc.Click
        Toxin += 1
        If Toxin = 6 Then
            ToxInc.Enabled = False
        End If
    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        PHealth = 2000
        EHealth = 2000
        PlayerBar.Increment(PHealth)
        EnemyBar.Increment(EHealth)
        Turn = 0
        Toxin = 1
        Hemo = 1
        SlowCheck.Text = "(Slow)"
        StunCheck.Text = "(Stun)"
    End Sub

    Private Sub EAttack_Click(sender As Object, e As EventArgs) Handles EAttack.Click
        If RogueMod = 3 And MissTrue <= 2 Then
            MissTrue -= 1
            PlayerBar.Increment(-0)
            PHealth = PHealth - 0
            If MissTrue = 0 Then
                MissTrue = 0
                RogueMod = 0
            End If

        ElseIf MissTrue = 1 Then
            PlayerBar.Increment(-0)
            PHealth = PHealth - Edmg
            Edmg = 0
            MissTrue = 0
            Slow.Enabled = True
            RichTextBox1.Text = " "
            SlowCheck.Text = "Base Speed"
        ElseIf MissTrue = 1 And TactMod = 3 Then
            PlayerBar.Increment(-0)
            PHealth = PHealth - Edmg
            Edmg = 0
            MissTrue = 0

        ElseIf RogueMod = 2 Then
            EHealth = EHealth - (Edmg / 2)
            Edmg = 6 / 3
            PHealth = PHealth - Edmg
        Else
            PlayerBar.Increment(-6)
            PHealth = PHealth - Edmg
            Edmg = 6
        End If


    End Sub

    Private Sub WarrCharge_Click(sender As Object, e As EventArgs) Handles WarrCharge.Click
        WarrCD += 1
        Turn += 1
        Poke = 3
        CDTimer.Enabled = True
        WarrCharge.Enabled = False
        WarrLash.Enabled = False
        WarrSlam.Enabled = False
        StunMod = StunGen.Next(1, 101)
        EnemyBar.Increment(-10)
        EHealth = EHealth - 10
        BCMod = BleedChance.Next(1, 101)
        If BleedTimer.Enabled = True Then
            Hemo += 1
        End If
        If BCMod >= 1 And BCMod <= 2 Then
            BleedTimer.Enabled = True
        End If
        If StunMod >= 1 And StunMod <= 10 Then
            StunTimer.Enabled = True
        Else
            PHealth = PHealth - 5
            PlayerBar.Increment(-5)
        End If
    End Sub

    Private Sub CDTimer_Tick(sender As Object, e As EventArgs) Handles CDTimer.Tick
        CDClick += 1
        'Warrior CoolDowns
        If WarrCD = 1 And CDClick = 20 Then
            WarrCharge.Enabled = True
            WarrLash.Enabled = True
            WarrSlam.Enabled = True
            WarrRage.Enabled = True
            CDTimer.Enabled = False
            WarrCD = 0
            CDClick = 0
        End If
        If WarrCD = 2 And CDClick = 20 Then
            WarrCharge.Enabled = True
            WarrLash.Enabled = True
            WarrSlam.Enabled = True
            WarrRage.Enabled = True
            CDTimer.Enabled = False
            WarrCD = 0
            CDClick = 0
        End If
        If WarrCD = 3 And CDClick = 60 Then
            WarrCharge.Enabled = True
            WarrLash.Enabled = True
            WarrSlam.Enabled = True
            WarrRage.Enabled = True
            CDTimer.Enabled = False
            WarrCD = 0
            CDClick = 0
        End If
        If WarrCD = 4 And CDClick = 200 Then
            WarrCharge.Enabled = True
            WarrLash.Enabled = True
            WarrSlam.Enabled = True
            WarrRage.Enabled = True
            CDTimer.Enabled = False
            WarrCD = 0
            CDClick = 0
        End If
        'Tactician CoolDowns
        If TactCD = 1 And CDClick = 20 Then
            TactMod = 0
            TactScout.Enabled = True
            TactCalLaunch.Enabled = True
            CDTimer.Enabled = False
            CDClick = 0
            TactCD = 0
        End If
        If TactCD = 2 And CDClick = 419 Then
            TactMod = 0
            TactScout.Enabled = True
            TactCalLaunch.Enabled = True
            CDTimer.Enabled = False
            CDClick = 0
            TactCD = 0
        End If
        If TactCD = 3 And CDClick = 40 Then
            TactMod = 0
            TactCD = 0
            TactPlan.Enabled = True
            TactScout.Enabled = True
            TactBomb.Enabled = True
            TactCalLaunch.Enabled = True
            CDTimer.Enabled = False
            CDClick = 0
            BonusDmg = 0
            RichTextBox1.Text = " "
        End If
        If TactCD = 4 And CDClick = 100 Then
            TactMod = 0
            TactCD = 4
            TactPlan.Enabled = True
            TactScout.Enabled = True
            TactCalLaunch.Enabled = True
            TactBomb.Enabled = True
            CDTimer.Enabled = False
            CDClick = 0
        End If
        'Rogue CoolDowns
        If RogueCD = 1 And CDClick = 200 Then
            RogueCD = 0
            RogueMod = 1
            RoguePar.Enabled = True
            CDTimer.Enabled = False
            CDClick = 0
        End If
        If RogueCD = 2 And CDClick = 60 Then
            RogueCD = 0
            RogueMod = 1
            RoguePar.Enabled = True
            CDClick = 0
            CDTimer.Enabled = False
        End If
        'Unborn CoolDowns
        If UnbornCD = 1 And CDClick = 100 Then
            UnCraze.Enabled = True
            CDTimer.Enabled = False
            CDClick = 0
            UnbornCD = 0
            UnbornMod = 0
        End If
        If UnbornMod = 2 And CDClick = 120 Then
            Edmg = TrueEDmg
            UnbornMod = 0
            CDClick = 0
            CDTimer.Enabled = 0
            UnbornCD = 0
            UnBurden.Enabled = True
            UnCraze.Enabled = True
            UnWild.Enabled = True
        End If
        If UnbornMod = 3 And CDClick = 120 Then
            CDTimer.Enabled = False
            CDClick = 0
            UnbornMod = 0
            UnbornCD = 0
            UnDmg = 0
            PAttack.Enabled = True
        End If
    End Sub

    Private Sub WarrLash_Click(sender As Object, e As EventArgs) Handles WarrLash.Click
        WarrCD += 2
        Turn += 1
        CDTimer.Enabled = True
        WarrCharge.Enabled = False
        WarrLash.Enabled = False
        WarrSlam.Enabled = False
        WarrRage.Enabled = False
        BCMod = BleedChance.Next(1, 101)
        EnemyBar.Increment(-15)
        EHealth = EHealth - 15
        If BCMod >= 40 And BCMod <= 100 Then
            BleedTimer.Enabled = True
            If Hemo = 10 Then
                Hemo = 10
            Else
                Hemo += 2
            End If
        End If
    End Sub

    Private Sub WarrSlam_Click(sender As Object, e As EventArgs) Handles WarrSlam.Click
        WarrCD += 3
        Poke = 4
        Turn += 1
        CDTimer.Enabled = True
        WarrCharge.Enabled = False
        WarrLash.Enabled = False
        WarrSlam.Enabled = False
        WarrRage.Enabled = False
        StunTimer.Enabled = True
        EnemyBar.Increment(-40)
        EHealth = EHealth - 40
    End Sub

    Private Sub WarrRage_Click(sender As Object, e As EventArgs) Handles WarrRage.Click
        WarrCD += 4
        Turn += 1
        CDTimer.Enabled = True
        WarrCharge.Enabled = False
        WarrLash.Enabled = False
        WarrSlam.Enabled = False
        WarrRage.Enabled = False
        If PHealth <= 1000 Then
            PHealth = PHealth + 200
            TempTimer.Enabled = True
        End If
        BonusDmg = 45
    End Sub

    Private Sub TempTimer_Tick(sender As Object, e As EventArgs) Handles TempTimer.Tick
        If WarrCD = 4 Then
            PHealth = PHealth - 1
            TempTick += 1
            If TempTick = 200 Then
                TempTimer.Enabled = False
                BonusDmg = 0
            End If
        End If
    End Sub

    Private Sub TactScout_Click(sender As Object, e As EventArgs) Handles TactScout.Click
        TactCD += 1
        Turn += 1
        TactMod += 1
        CDTimer.Enabled = True
        TactScout.Enabled = False
        TactCalLaunch.Enabled = False
    End Sub

    Private Sub PAttack_Click(sender As Object, e As EventArgs) Handles PAttack.Click
        If TactMod = 1 Then
            EnemyBar.Increment(-25)
            EHealth = EHealth - 25
            TactMod = 0
            TactScout.Enabled = True
            If TactMod = 3 Then
                EnemyBar.Increment(-30)
                EHealth = EHealth - 30
                TactMod = 0
                TactPlan.Enabled = True
                BonusDmg = 0
                CDTimer.Enabled = False
                CDClick = 0
            End If
        End If
        If RogueMod = 1 Then
            EnemyBar.Increment(-(12 * RogueDmgMod))
            EHealth = EHealth - (12 * RogueDmgMod)
            RogueMod = 0
            RogueDmgMod = 1
            CDTimer.Enabled = False
            CDClick = 0
        End If
        If RogueMod = 3 Then
            EnemyBar.Increment(-(12 * RogueDmgMod))
            EHealth = EHealth - (12 * RogueDmgMod)
            RogueMod = 0
        End If
        If RogueMod = 4 Then
            EnemyBar.Increment(-(12 * RogueDmgMod))
            EHealth = EHealth - (12 * RogueDmgMod)
            BleedTimer.Enabled = True
            RogueMod = 0
            RogueDmgMod = 1
            CDTimer.Enabled = False
            CDClick = 0
            RoguePar.Enabled = True
            If RogueLock = 0 Then
                RogueInvis.Enabled = True
            Else
                RogueInvis.Enabled = False
            End If
            If Hemo = 10 Then
                Hemo = 10
            Else
                Hemo += 6
            End If
        End If
        If UnbornMod = 4 Then
            EnemyBar.Increment(-(13 + UnDmg))
            EHealth = EHealth - (13 + UnDmg)
            UnDmg = 0
        End If

    End Sub

    Private Sub TactCalLaunch_Click(sender As Object, e As EventArgs) Handles TactCalLaunch.Click
        TactCD += 2
        Turn += 1
        TactMod += 2
        TactCalLaunch.Enabled = False
        CalCount = 1
        BleedTimer.Enabled = True
        Hemo += 1
        CDTimer.Enabled = True
    End Sub

    Private Sub TactPlan_Click(sender As Object, e As EventArgs) Handles TactPlan.Click
        TactCD += 3
        Turn += 1
        TactMod += 3
        TactPlan.Enabled = False
        BonusDmg += 5
        CDTimer.Enabled = True
        TactScout.Enabled = False
        TactCalLaunch.Enabled = False
        TactBomb.Enabled = False
        MissTrue = 1
        RichTextBox1.Text = "Next attack against you will miss"
    End Sub

    Private Sub TactBomb_Click(sender As Object, e As EventArgs) Handles TactBomb.Click
        Clot += 5
        TactCD = 4
        Turn += 1
        TactMod += 4
        TactBomb.Enabled = False
        TactScout.Enabled = False
        TactCalLaunch.Enabled = False
        TactPlan.Enabled = False
        ToxinTimer.Enabled = True
        CDTimer.Enabled = True
        If Toxin >= 6 Then
            Toxin = 6
        Else
            Toxin += 5

        End If
    End Sub

    Private Sub RogueStab_Click(sender As Object, e As EventArgs) Handles RogueStab.Click
        RogueCD = 1
        Turn += 1
        If RogueMod = 4 Then
            RogueMod = 4
        Else
            RogueMod = 1
        End If
        RogueStab.Enabled = False
        RoguePar.Enabled = False
        RogueInvis.Enabled = False
        CDTimer.Enabled = True
        RogueDmgMod = 30
        If Ambush = 1 Then
            RogueDmgMod = 70
        End If
        If Ambush = 2 Then
            RogueDmgMod = 80
        End If
    End Sub

    Private Sub RoguePar_Click(sender As Object, e As EventArgs) Handles RoguePar.Click
        RogueCD = 2
        RogueMod = 2
        Turn += 1
        RogueStab.Enabled = False
        RoguePar.Enabled = False
        RogueInvis.Enabled = False
        CDTimer.Enabled = True
    End Sub

    Private Sub RogueInvis_Click(sender As Object, e As EventArgs) Handles RogueInvis.Click
        RogueCD = 3
        RogueMod = 3
        MissTrue = 2
        Ambush = 1
        Turn += 1
        RoguePar.Enabled = False
        RogueInvis.Enabled = False
        RogueStrike.Enabled = False
        RogueLock = 1
    End Sub

    Private Sub RogueStrike_Click(sender As Object, e As EventArgs) Handles RogueStrike.Click
        RogueCD = 4
        RogueMod = 4
        Ambush = 2
        RogueStrike.Enabled = False
        RoguePar.Enabled = False
        RogueInvis.Enabled = False
        CDTimer.Enabled = True
    End Sub

    Private Sub UnCraze_Click(sender As Object, e As EventArgs) Handles UnCraze.Click
        UnbornCD = 1
        UnbornMod = 1
        UnCraze.Enabled = False
        UnBurden.Enabled = False
        UnWild.Enabled = False
        UnSpdMod.Enabled = True
        PAttack.Enabled = False
    End Sub

    Private Sub UnSpdMod_Tick(sender As Object, e As EventArgs) Handles UnSpdMod.Tick
        SpeedMod += 1
        If UnbornMod = 1 Then
            If SpeedMod = 1 Or SpeedMod = 10 Then
                EnemyBar.Increment(-13)
                EHealth = EHealth - 13
            End If
            If SpeedMod = 4 Or SpeedMod = 13 Then
                EnemyBar.Increment(-13)
                EHealth = EHealth - 13
            End If
            If SpeedMod = 7 Or SpeedMod = 16 Then
                EnemyBar.Increment(-13)
                EHealth = EHealth - 13
            End If
            If SpeedMod = 17 Then
                UnSpdMod.Enabled = False
                SpeedMod = 0
                PAttack.Enabled = True
            End If
        End If
        If UnbornMod = 2 Then
            Edmg = TrueEDmg / 2
        End If
        If UnbornMod = 3 Then
            If SpeedMod = 1 Or SpeedMod = 10 Or SpeedMod = 19 Then
                EnemyBar.Increment(-(13 + UnDmg))
                EHealth = EHealth - (13 + UnDmg)
                PHealth = PHealth - 10
            End If
            If SpeedMod = 4 Or SpeedMod = 13 Or SpeedMod = 21 Then
                EnemyBar.Increment(-(13 + UnDmg))
                EHealth = EHealth - (13 + UnDmg)
                PHealth = PHealth - 10
            End If
            If SpeedMod = 7 Or SpeedMod = 16 Or SpeedMod = 24 Then
                EnemyBar.Increment(-(13 + UnDmg))
                EHealth = EHealth - (13 + UnDmg)
                PHealth = PHealth - 10
            End If
            If SpeedMod = 25 Then
                UnSpdMod.Enabled = False
                SpeedMod = 0
                PAttack.Enabled = True
            End If
        End If
        If UnbornMod = 4 And CDClick = 200 Then
            UnbornCD = 0
            UnbornMod = 0
            UnDmg = 0
            CDClick = 0
            UnCraze.Enabled = True
            UnBurden.Enabled = True
            UnWild.Enabled = True
            UnSpdMod.Enabled = False
            CDTimer.Enabled = False
        End If
    End Sub

    Private Sub UnBurden_Click(sender As Object, e As EventArgs) Handles UnBurden.Click
        UnbornCD = 2
        UnbornMod = 2
        UnSpdMod.Enabled = True
        UnBurden.Enabled = False
        CDTimer.Enabled = True
    End Sub

    Private Sub UnWild_Click(sender As Object, e As EventArgs) Handles UnWild.Click
        UnbornCD = 3
        UnbornMod = 3
        UnDmg = 13
        UnCraze.Enabled = False
        UnBurden.Enabled = False
        UnWild.Enabled = False
        UnSpdMod.Enabled = True
        CDTimer.Enabled = True
        PAttack.Enabled = False
    End Sub

    Private Sub UnRed_Click(sender As Object, e As EventArgs) Handles UnRed.Click
        UnbornCD = 4
        UnbornMod = 4
        UnDmg = 50
        UnRed.Enabled = False
        UnCraze.Enabled = False
        UnBurden.Enabled = False
        UnWild.Enabled = False
        UnSpdMod.Enabled = True
        CDTimer.Enabled = True
        UnHeal = PHealth / 2
        PHealth = PHealth + UnHeal
        PlayerBar.Increment(+UnHeal)
    End Sub
End Class