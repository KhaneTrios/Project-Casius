Public Class begin
    'The names of each skill represented as an integer 3/15
    Public Shared warrCharge As Integer
    Public Shared warrBackwards As Integer
    Public Shared warrEnrage As Integer
    Public Shared warrCore As Integer
    Public Shared tactScout As Integer
    Public Shared tactCaltrop As Integer
    Public Shared tactOver As Integer
    Public Shared tactPoison As Integer
    Public Shared mageShards As Integer
    Public Shared mageLightning As Integer
    Public Shared mageFire As Integer
    Public Shared mageArcane As Integer
    Public Shared roguBackstab As Integer
    Public Shared roguParry As Integer
    Public Shared roguInvisible As Integer
    Public Shared roguShadow As Integer
    Public Shared unboBurden As Integer
    Public Shared unboCraze As Integer
    Public Shared unboWild As Integer
    Public Shared unboRedemption As Integer

    Private Sub begin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'The NAMES of each skill representing its respective button 3/15
        If Variables.Fight.charWarr = True Then
            'asdasda
            charge.Enabled = False
            'asdasda
            poisonBomb.Enabled = False
            overPlan.Enabled = False
            caltropLaunch.Enabled = False
            scout.Enabled = False
            arcaneWhirlwind.Enabled = False
            fireCage.Enabled = False
            lightningWave.Enabled = False
            shards.Enabled = False
            shadowStrike.Enabled = False
            invisible.Enabled = False
            parry.Enabled = False
            backstab.Enabled = False
            redmption.Enabled = False
            wild.Enabled = False
            craze.Enabled = False
            burden.Enabled = False
        ElseIf Form1.charTact = True Then
            charge.Enabled = False
            backwardsLash.Enabled = False
            enrage.Enabled = False
            coreSlam.Enabled = False
            arcaneWhirlwind.Enabled = False
            fireCage.Enabled = False
            lightningWave.Enabled = False
            shards.Enabled = False
            shadowStrike.Enabled = False
            invisible.Enabled = False
            parry.Enabled = False
            backstab.Enabled = False
            redmption.Enabled = False
            wild.Enabled = False
            craze.Enabled = False
            burden.Enabled = False
        ElseIf Form1.charMage = True Then
            charge.Enabled = False
            backwardsLash.Enabled = False
            enrage.Enabled = False
            coreSlam.Enabled = False
            poisonBomb.Enabled = False
            overPlan.Enabled = False
            caltropLaunch.Enabled = False
            scout.Enabled = False
            shadowStrike.Enabled = False
            invisible.Enabled = False
            parry.Enabled = False
            backstab.Enabled = False
            redmption.Enabled = False
            wild.Enabled = False
            craze.Enabled = False
            burden.Enabled = False
        ElseIf Form1.charRogu = True Then
            charge.Enabled = False
            backwardsLash.Enabled = False
            enrage.Enabled = False
            coreSlam.Enabled = False
            poisonBomb.Enabled = False
            overPlan.Enabled = False
            caltropLaunch.Enabled = False
            scout.Enabled = False
            arcaneWhirlwind.Enabled = False
            fireCage.Enabled = False
            lightningWave.Enabled = False
            shards.Enabled = False
            redmption.Enabled = False
            wild.Enabled = False
            craze.Enabled = False
            burden.Enabled = False
        ElseIf Form1.charUnbo = True Then
            charge.Enabled = False
            backwardsLash.Enabled = False
            enrage.Enabled = False
            coreSlam.Enabled = False
            poisonBomb.Enabled = False
            overPlan.Enabled = False
            caltropLaunch.Enabled = False
            scout.Enabled = False
            arcaneWhirlwind.Enabled = False
            fireCage.Enabled = False
            lightningWave.Enabled = False
            shards.Enabled = False
            shadowStrike.Enabled = False
            invisible.Enabled = False
            parry.Enabled = False
            backstab.Enabled = False
        End If
        'Brill made a Debug name! Yay for him!
        If Variables.Fight.asdfmod = "Hooty McOwlface" Then
            Variables.Fight.skill = 9999
            Fight.className.Text = "God damned Owl"
        End If
        Button4.Visible = False
        Button25.Visible = False
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        charge.Enabled = True
        Variables.Fight.skill += 1




        Button25.Visible = True
        Button2.Visible = False
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Updater.Tick
        skillPoints.Text = Variables.Fight.skill
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs)
        'skillcount.Enabled = True
    End Sub

    Private Sub skillcount_Tick(sender As System.Object, e As System.EventArgs) Handles skillcount.Tick
        Variables.Fight.skill += 1
        If Variables.Fight.skill = 10 Then
            skillcount.Enabled = False
        End If
        If Variables.Fight.skill < 10 And skillcount.Interval = 100 Then
            skillcount.Enabled = True
        End If
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Variables.Fight.skill -= 1
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles charge.Click
        If Variables.Fight.skill = 1 Then
            charge.Enabled = True
        End If

        MessageBox.Show("The warrior runs at the enemy at full force and deals a devistating blow with his shoulder.", "Charge")
        Label3.Text = "Skills acquired: Charge"


        Variables.Fight.skillOneBought = True

        Variables.Fight.skill = Variables.Fight.skill - 1
        If Variables.Fight.skill = -1 Then
            Variables.Fight.skill = 0 And
                MessageBox.Show("You already have acquired this skill!", "Error")
        End If
    End Sub

    Private Sub Button25_Click(sender As System.Object, e As System.EventArgs) Handles Button25.Click
        Fight.Show()
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles backwardsLash.Click
        MessageBox.Show("While attacking the enemy, the warrior flails and twirls his weapon to hit the enemy for piercing damage while thrusting his weapon backwards into the opponent.", "Backwards Lash")
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles enrage.Click
        MessageBox.Show("You channel your anger and skill to increase all of your damage values by 5%", "Enrage")
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles coreSlam.Click
        MessageBox.Show("The warrior picks ups his opponent and slams him into the ground with all of his force", "Core Slam")
    End Sub

    Private Sub Button12_Click_1(sender As System.Object, e As System.EventArgs) Handles scout.Click
        MessageBox.Show("The tactician scouts the immediate area and gets a knoweldge bonus which gives him an edge in battle.", "Scout")
    End Sub

    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles caltropLaunch.Click
        MessageBox.Show("Throw out a dozen caltrops for your opponent to step on and take damage from, also slows them down.", "Caltrop Launch")
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles poisonBomb.Click
        MessageBox.Show("As a tactician, you have the best tools of the trade. That being said, the tactician deploys a series of poison bombs that damage the enemy right away, as well as over time.", "Poison Bomb Barrage")
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles overPlan.Click
        MessageBox.Show("The tactician gathers and uses the data from the current battle to give him/her self a damage and agility boost.", "Over-Plan")
    End Sub

    Private Sub Button16_Click(sender As System.Object, e As System.EventArgs) Handles shards.Click

    End Sub
End Class