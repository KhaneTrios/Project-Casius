Public Class begin
    Dim skill As Integer
    Private Sub begin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If Form1.charWarr = True Then
            Button9.Enabled = False
            Button10.Enabled = False
            Button11.Enabled = False
            Button12.Enabled = False
            Button13.Enabled = False
            Button14.Enabled = False
            Button15.Enabled = False
            Button16.Enabled = False
            Button17.Enabled = False
            Button18.Enabled = False
            Button19.Enabled = False
            Button20.Enabled = False
            Button21.Enabled = False
            Button22.Enabled = False
            Button23.Enabled = False
            Button24.Enabled = False
        ElseIf Form1.charTact = True Then
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button13.Enabled = False
            Button14.Enabled = False
            Button15.Enabled = False
            Button16.Enabled = False
            Button17.Enabled = False
            Button18.Enabled = False
            Button19.Enabled = False
            Button20.Enabled = False
            Button21.Enabled = False
            Button22.Enabled = False
            Button23.Enabled = False
            Button24.Enabled = False
        ElseIf Form1.charMage = True Then
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
            Button10.Enabled = False
            Button11.Enabled = False
            Button12.Enabled = False
            Button17.Enabled = False
            Button18.Enabled = False
            Button19.Enabled = False
            Button20.Enabled = False
            Button21.Enabled = False
            Button22.Enabled = False
            Button23.Enabled = False
            Button24.Enabled = False
        ElseIf Form1.charRogu = True Then
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
            Button10.Enabled = False
            Button11.Enabled = False
            Button12.Enabled = False
            Button13.Enabled = False
            Button14.Enabled = False
            Button15.Enabled = False
            Button16.Enabled = False
            Button21.Enabled = False
            Button22.Enabled = False
            Button23.Enabled = False
            Button24.Enabled = False
        ElseIf Form1.charUnbo = True Then
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
            Button10.Enabled = False
            Button11.Enabled = False
            Button12.Enabled = False
            Button13.Enabled = False
            Button14.Enabled = False
            Button15.Enabled = False
            Button16.Enabled = False
            Button17.Enabled = False
            Button18.Enabled = False
            Button19.Enabled = False
            Button20.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        skill += 1
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Updater.Tick
        Label3.Text = skill
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        skillcount.Enabled = True
    End Sub

    Private Sub skillcount_Tick(sender As System.Object, e As System.EventArgs) Handles skillcount.Tick
        skill += 1
        If skill = 10 Then
            skillcount.Enabled = False
        End If
        If skill < 10 And skillcount.Interval = 100 Then
            skillcount.Enabled = True
        End If
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        skill -= 1
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        MessageBox.Show("The warrior runs at the enemy at full force and deals a devistating blow with his shoulder.", "Charge")
    End Sub

    Private Sub Button25_Click(sender As System.Object, e As System.EventArgs) Handles Button25.Click
        Fight.Show()
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        MessageBox.Show("While attacking the enemy, the warrior flails and twirls his weapon to hit the enemy for piercing damage while thrusting his weapon backwards into the opponent.", "Backwards Lash")
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        MessageBox.Show("You channel your anger and skill to increase all of your damage values by 5%", "Enrage")
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        MessageBox.Show("The warrior picks ups his opponent and slams him into the ground with all of his force", "Core Slam")
    End Sub

    Private Sub Button12_Click_1(sender As System.Object, e As System.EventArgs) Handles Button12.Click
        MessageBox.Show("The tactician scouts the immediate area and gets a knoweldge bonus which gives him an edge in battle.", "Scout")
    End Sub

    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        MessageBox.Show("Throw out a dozen caltrops for your opponent to step on and take damage from, also slows them down.", "Caltrop Launch")
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        MessageBox.Show("As a tactician, you have the best tools of the trade. That being said, the tactician deploys a series of poison bombs that damage the enemy right away, as well as over time.", "Poison Bomb Barrage")
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        MessageBox.Show("The tactician gathers and uses the data from the current battle to give him/her self a damage and agility boost.", "Over-Plan")
    End Sub

    Private Sub Button16_Click(sender As System.Object, e As System.EventArgs) Handles Button16.Click

    End Sub
End Class