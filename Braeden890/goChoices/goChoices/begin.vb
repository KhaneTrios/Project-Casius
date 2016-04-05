Public Class begin
    'ALL VARIABLES ARE IN VARIABLES.VB 
    Private Sub begin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'The NAMES of each skill representing its respective button 3/15

        'Brill made a Debug name! Yay for him!
        If Variables.Fight.asdfmod = "Hooty McOwlface" Then
            Variables.Fight.skill = 9999
            Fight.className.Text = "God damned Owl"
        End If
        'Button4.Visible = False
        'Button25.Visible = False
        'Button3.Visible = False

        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False

        If Variables.Skills.activeOnce = True Then 'if player goes thru one fight gets access to main menu
            Button3.Visible = True
        End If

        Variables.Skills.skillPoint = 0
        skillPoints.Text = Variables.Skills.skillPoint
        Variables.Skills.skillpointreset = False
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

        Variables.Skills.skillpointreset = True
        If Variables.Skills.skillpointreset = True Then
            Variables.Skills.skillPoint += 1
        End If

        Button2.Visible = False

        'Button25.Visible = True
        'Button2.Visible = False
    End Sub

    Public Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Updater.Tick
        'This is the updater

        If Variables.Skills.skillPoint = 1 Then
            Button5.Enabled = True
        End If

        skillPoints.Text = Variables.Skills.skillPoint


        If Variables.Fight.charWarr = True Then
            Label3.Text = "Warrior"
            Button5.Text = Variables.Skills.warrCharge
            Button6.Text = Variables.Skills.warrBackwards
            Button7.Text = Variables.Skills.warrEnrage
            Button8.Text = Variables.Skills.warrCore
        End If

        If Variables.Fight.charTact = True Then
            Label3.Text = "Tactician"
            Button5.Text = Variables.Skills.tactScout
            Button6.Text = Variables.Skills.tactCaltrop
            Button7.Text = Variables.Skills.tactOver
            Button8.Text = Variables.Skills.tactPoison
        End If

        If Variables.Fight.charMage = True Then
            Label3.Text = "Mage"
            Button5.Text = Variables.Skills.mageShards
            Button6.Text = Variables.Skills.mageLightning
            Button7.Text = Variables.Skills.mageFire
            Button8.Text = Variables.Skills.mageArcane
        End If

        If Variables.Fight.charRogu = True Then
            Label3.Text = "Rogue"
            Button5.Text = Variables.Skills.roguBackstab
            Button6.Text = Variables.Skills.roguParry
            Button7.Text = Variables.Skills.roguInvisible
            Button8.Text = Variables.Skills.roguShadow
        End If

        If Variables.Fight.charUnbo = True Then
            Label3.Text = "Unborn"
            Button5.Text = Variables.Skills.unboBurden
            Button6.Text = Variables.Skills.unboCraze
            Button7.Text = Variables.Skills.unboWild
            Button8.Text = Variables.Skills.unboRedemption
        End If

        'If Variables.Skills.skillPoint = 1 Then
        'Button5.Enabled = True
        'End If



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

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs)


        MessageBox.Show("The warrior runs at the enemy at full force and deals a devistating blow with his shoulder.", "Charge")
        lblAquired.Text = "Skills acquired: Charge"


        Variables.Fight.skillOneBought = True 'skill bought

        Variables.Fight.skill = Variables.Fight.skill - 1
        If Variables.Fight.skill = -1 Then
            Variables.Fight.skill = 0 And
                MessageBox.Show("You already have acquired this skill!", "Error")
        End If
    End Sub

    Private Sub Button25_Click(sender As System.Object, e As System.EventArgs) Handles Button25.Click
        Fight.Show()
        Variables.Skills.activeOnce = True
        Me.Close()
    End Sub
    Private Sub lblAquired_Click(sender As Object, e As EventArgs) Handles lblAquired.Click

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        mainMenu.Show()
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        If Button5.Text = Variables.Skills.warrCharge Then
            MessageBox.Show("The warrior runs at the enemy at full force and deals a devistating blow with his shoulder.", "Charge")
            lblAquired.Text = "Skill acquired: Charge"
        End If
        If Button5.Text = Variables.Skills.tactScout Then
            MessageBox.Show("The tactician scouts the immediate area and gets a knoweldge bonus which gives him an edge in battle.", "Scout")
            lblAquired.Text = "Skill acquired: Scout"
        End If
        If Button5.Text = Variables.Skills.mageShards Then
            MessageBox.Show("The mage summons upon the power of ice and conjures huge ice shards to pierce the enemy.")
            lblAquired.Text = "Skill acquired: Shards of Ice"
        End If
        If Button5.Text = Variables.Skills.roguBackstab Then
            MessageBox.Show("The rogue catches their opponent off guard and uses their hidden blade to stab the opponent in the back", "Backstab")
            lblAquired.Text = "Skill acquired: Backstab"
        End If
        If Button5.Text = Variables.Skills.unboBurden Then
            MessageBox.Show("The unborn uses every ounce of sorrow to hurt himself and reflects a percentage of damage back.", "Burden")
            lblAquired.Text = "Skill acquired: Burden"
        End If
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        If Button6.Text = Variables.Skills.warrBackwards Then
            MessageBox.Show("While attacking the enemy, the warrior flails and twirls his weapon to hit the enemy for piercing damage while thrusting his weapon backwards into the opponent.", "Backwards Lash")
            lblAquired.Text = "Skill acquired: Backwards Lash"
        End If
        If Button6.Text = Variables.Skills.tactCaltrop Then
            MessageBox.Show("Throw out a dozen caltrops for your opponent to step on and take damage from, also slows them down.", "Caltrop Launch")
            lblAquired.Text = "Skill acquired: Caltrop launch"
        End If
        If Button6.Text = Variables.Skills.mageLightning Then
            MessageBox.Show("Lightning Wave")
            lblAquired.Text = "Skill acquired: Lightning Wave"
        End If
        If Button6.Text = Variables.Skills.roguParry Then
            MessageBox.Show("Years of practice allows you to counter almost all attacks effortlessly.", "Parry")
            lblAquired.Text = "Skill acquired: Parry"
        End If
        If Button6.Text = Variables.Skills.unboCraze Then
            MessageBox.Show("Seeing red? Your rage bellows to distant lands and increases your raw attack power.", "Craze")
            lblAquired.Text = "Skill acquired: Craze"
        End If
    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        If Button7.Text = Variables.Skills.warrEnrage Then
            MessageBox.Show("You channel your anger and skill to increase all of your damage values by 5%", "Enrage")
            lblAquired.Text = "Skill acquired: Enrage"
        End If
        If Button7.Text = Variables.Skills.tactOver Then
            MessageBox.Show("The tactician gathers and uses the data from the current battle to give him/her self a damage and agility boost.", "Over-Plan")
            lblAquired.Text = "Skill acquired: Over-Plan"
        End If
        If Button7.Text = Variables.Skills.mageFire Then
            MessageBox.Show("Materialize a prison of scorching flames to engulf and trap your opponent, doing them burn damage by the second.", "Fire Cage")
            lblAquired.Text = "Skill acquired: Fire Cage"
        End If
        If Button7.Text = Variables.Skills.roguInvisible Then
            MessageBox.Show("To the rogue, this practice is second nature, go completely invisible.", "Invisible")
            lblAquired.Text = "Skill acquired: Invisible"
        End If
        If Button7.Text = Variables.Skills.unboWild Then
            MessageBox.Show("You give into your feral instincts and resemble a mad man! Speed of all attacks is boosted.", "Wild")
            lblAquired.Text = "Skill acquired: Wild"
        End If
    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click
        If Button8.Text = Variables.Skills.warrCore Then
            MessageBox.Show("The warrior picks ups his opponent and slams him into the ground with all of his force", "Core Slam ")
            lblAquired.Text = "Skill acquired: Core Slam"
        End If
        If Button8.Text = Variables.Skills.tactPoison Then
            MessageBox.Show("As a tactician, you have the best tools of the trade. That being said, the tactician deploys a series of poison bombs that damage the enemy right away, as well as over time.", "Poison Bomb Barrage ")
            lblAquired.Text = "Skill acquired: Poison Barrage"
        End If
        If Button8.Text = Variables.Skills.mageArcane Then
            MessageBox.Show("The mage uses all of his power to conjure up a whirlwind of the elements to deal immense damage to anyone foolish enough not to run away at the sight of this spell.", "Arcane Whirlwind")
            lblAquired.Text = "Skill acquired: Arcane Whirlwind"
        End If
        If Button8.Text = Variables.Skills.roguShadow Then
            MessageBox.Show("Go invisible and quickly manuever to the blind side of the enemy, inflicting critical damage. ")
            lblAquired.Text = "Skill acquired: Shadow Strike"
        End If
        If Button8.Text = Variables.Skills.unboRedemption Then
            MessageBox.Show("The unborn finally finds meaning in his journey and unlocks his full potential. The gods favor you, weakling. All damage taken is decreased by 75% for 5 turns and for 3 of the 5 turns, the damage is reflected back to the enemy.", "Redemption")
            lblAquired.Text = "Skill acquired: Redemption"
        End If
    End Sub
End Class