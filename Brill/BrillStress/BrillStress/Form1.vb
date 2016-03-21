Public Class Form1
    Dim Plug As Integer
    Dim EClass As Integer
    Dim Classtho As String
    Dim RanGen As New Random
    Dim ArmGen As New Random
    Dim ArmSelect As Integer
    Dim ArmTho As String
    Dim XGen As Integer
    Dim YGen As Integer
    Dim ArmTick As Integer

    Private Sub UnPlug_Click(sender As System.Object, e As System.EventArgs) Handles UnPlug.Click
        Plugger.Enabled = True
        Randomizer.Enabled = False
        RandomArmor.Enabled = False
        UnPlug.Enabled = False
        RePlug.Enabled = True
        
    End Sub

    Private Sub RePlug_Click(sender As System.Object, e As System.EventArgs) Handles RePlug.Click
        Plugger.Enabled = False
        Randomizer.Enabled = True
        Plug = 0
        RePlug.Enabled = False
        UnPlug.Enabled = True
        RandomArmor.Enabled = True
    End Sub

    Private Sub Updater_Tick(sender As System.Object, e As System.EventArgs) Handles Updater.Tick
        PlugLabel.Text = Plug
        LabelClass.Text = Classtho
        ArmLabel.Text = ArmTho
        If ArmSelect = 1 Then
            ArmTho = "Cloth"
        End If

        If ArmSelect = 2 Then
            ArmTho = "Leather"
        End If

        If ArmSelect = 3 Then
            ArmTho = "Chain Mail"
        End If

        If ArmSelect = 4 Then
            ArmTho = "Plate Mail"
        End If
    End Sub

        Private Sub Plugger_Tick(sender As System.Object, e As System.EventArgs) Handles Plugger.Tick
            Plug += 1
        End Sub

        Private Sub Randomizer_Tick(sender As System.Object, e As System.EventArgs) Handles Randomizer.Tick
        EClass = RanGen.Next(1, 6)
        
        End Sub

    Private Sub RandomArmor_Tick(sender As System.Object, e As System.EventArgs) Handles RandomArmor.Tick
        ArmSelect = ArmGen.Next(XGen, YGen)
        ArmTick += 1
        If EClass = 1 Then
            Classtho = "Warrior"
            'RandomArmor.Enabled = True
            XGen = 2
            YGen = 5
        ElseIf EClass = 2 Then
            Classtho = "Rogue"
            'RandomArmor.Enabled = True
            ArmSelect = 2
        ElseIf EClass = 3 Then
            Classtho = "Mage"
            'RandomArmor.Enabled = True
            ArmSelect = 1
        ElseIf EClass = 4 Then
            Classtho = "Tactician"
            'RandomArmor.Enabled = True
            XGen = 1
            YGen = 3
        ElseIf EClass = 5 Then
            Classtho = "Unborn"
            'RandomArmor.Enabled = True
            XGen = 1
            YGen = 5
        End If
        If ArmTick = 10 Then
            RandomArmor.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
     

       
    End Sub
End Class
