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

    Private Sub Updater_Tick(sender As Object, e As EventArgs) Handles Updater.Tick
        PHealthValue.Text = PHealth
        EHealthValue.Text = EHealth
        TurnLabel.Text = Turn
        BleedStack.Text = Hemo
        BldDmg = 1 * Hemo
        PsnDmg = 6 * Toxin
        ToxStack.Text = Toxin
        If PHealth < 1000 Or EHealth < 1000 Then
            Reset.Enabled = True
        Else
            Reset.Enabled = False
        End If
        If PHealth < 0 Then
            PHealth = 0
        End If
        If EHealth < 0 Then
            EHealth = 0
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PHealth = 1000
        EHealth = 1000
        PlayerBar.Increment(1000)
        EnemyBar.Increment(1000)
        Hemo = 1
        Toxin = 1
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
        If Poke = 1 Then
            StunCheck.Text = "Yes"
            If Stunned = 12 Then
                StunTimer.Enabled = False
                Stunned = 0
                Stun1.Enabled = True
                Stun2.Enabled = True
            End If
        End If

        If Poke = 2 Then
            StunCheck.Text = "Yes"
            If Stunned = 12 Then
                StunTimer.Enabled = False
                Stunned = 0
                Stun1.Enabled = True
                Stun2.Enabled = True
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
        PHealth = 1000
        EHealth = 1000
        PlayerBar.Increment(1000)
        EnemyBar.Increment(1000)
        Turn = 0
        Toxin = 1
        Hemo = 1
        SlowCheck.Text = "(Slow)"
        StunCheck.Text = "(Stun)"
    End Sub

    Private Sub EAttack_Click(sender As Object, e As EventArgs) Handles EAttack.Click
        If MissTrue = 1 Then
            PlayerBar.Increment(-0)
            PHealth = PHealth - 0
            MissTrue = 0
            Slow.Enabled = True
            RichTextBox1.Text = " "
            SlowCheck.Text = "Base Speed"
        Else
            PlayerBar.Increment(-5)
            PHealth = PHealth - 5
        End If
    End Sub
End Class


