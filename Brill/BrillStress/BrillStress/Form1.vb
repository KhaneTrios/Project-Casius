Public Class Form1  'Finally working rng for enemies; thanks to Luke for actually figuring it out so I still have my brain
    Dim Plug As Integer 'For the Randomizer
    Dim Classtho As Integer 'Determines class
    Dim Armortho As Integer 'Determines armor
    Dim Rngsus As New Random 'The best of gods (self explanatory)

    Private Sub UnPlug_Click(sender As System.Object, e As System.EventArgs) Handles UnPlug.Click
        Randomizer.Enabled = False
        Plugger.Enabled = True
        UnPlug.Enabled = False
    End Sub

    Private Sub Plugger_Tick(sender As System.Object, e As System.EventArgs) Handles Plugger.Tick
        Plug += 1
        Classtho = Rngsus.Next(1, 6)
        If Classtho = 1 Then
            LabelClass.Text = "Warrior"
        ElseIf Classtho = 2 Then
            LabelClass.Text = "Rogue"
        ElseIf Classtho = 3 Then
            LabelClass.Text = "Mage"
        ElseIf Classtho = 4 Then
            LabelClass.Text = "Tactician"
        ElseIf Classtho = 5 Then
            LabelClass.Text = "Unborn"
        Else
            LabelClass.Text = "Wtf"
        End If

        If Classtho = 1 Then
            Armortho = Rngsus.Next(2, 5)
            If Armortho = 2 Then
                ArmLabel.Text = "Leather"
            ElseIf Armortho = 3 Then
                ArmLabel.Text = "Chain Mail"
            ElseIf Armortho = 4 Then
                ArmLabel.Text = "Plate Mail"
            Else
                ArmLabel.Text = "Wtf"
            End If

        ElseIf Classtho = 2 Then
            ArmLabel.Text = "Leather"

        ElseIf Classtho = 3 Then
            ArmLabel.Text = "Cloth"

        ElseIf Classtho = 4 Then
            Armortho = Rngsus.Next(1, 3)
            If Armortho = 1 Then
                ArmLabel.Text = "Cloth"
            ElseIf Armortho = 2 Then
                ArmLabel.Text = "Leather"
            ElseIf Armortho = 3 Then
                ArmLabel.Text = "Chain Mail"
            End If

        ElseIf Classtho = 5 Then
            Armortho = Rngsus.Next(1, 5)
            If Armortho = 1 Then
                ArmLabel.Text = "Cloth"
            ElseIf Armortho = 2 Then
                ArmLabel.Text = "Leather"
            ElseIf Armortho = 3 Then
                ArmLabel.Text = "Chain Mail"
            ElseIf Armortho = 4 Then
                ArmLabel.Text = "Plate Mail"
            End If
        End If

        If Plug = 15 Then
            Plugger.Enabled = False
            RePlug.Enabled = True
        End If
    End Sub

    Private Sub Updater_Tick(sender As System.Object, e As System.EventArgs) Handles Updater.Tick
        PlugLabel.Text = Plug
    End Sub

    Private Sub RePlug_Click(sender As System.Object, e As System.EventArgs) Handles RePlug.Click
        Plug = 0
        RePlug.Enabled = False
        Randomizer.Enabled = True
        UnPlug.Enabled = True
    End Sub
End Class
