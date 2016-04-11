Public Class Form1
    Public Shared Rngsus As New Random 'Class Gen
    Public Shared Rngsus2 As New Random 'Armor Gen
    Public Shared Rngsus3 As New Random 'Tier Gen
    Public Shared Rngsus4 As New Random 'Attack Gen
    Public Shared Rngsus5 As New Random 'Enemy Gen
    Public Shared toHit As Integer 'Attack Hit
    Public Shared TierNum As Integer '=Tier
    Public Shared ClassGen As Integer '=Class
    Public Shared ClassTag As String '=Class Name
    Public Shared EGen As Integer 'Enemy Class
    Public Shared ETag As String 'Enemy Class Name
    Public Shared Wep1 As Integer 'Weapon Choice
    Public Shared WepA1 As Integer 'Weapon Damage
    Public Shared WepA As String 'Weapon Name
    Public Shared Arm1 As Integer 'Armor Choice
    Public Shared ArmA As String 'Armor Name
    Public Shared ArmBonus As Integer 'Bonus from Armor
    Dim Health = 2000
    Dim EHealth = 2000
    Dim PHealth As Integer
    Dim Dmg As Integer
    Dim EDmg As Integer
    Dim DmgMod As Integer
    Dim Count As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TierNum = 1
    End Sub
    Public Shared Function classchoice() As Integer
        classchoice = Rngsus.Next(1, 6)
        Select Case classchoice
            Case 1
                ClassGen = 1
                ClassTag = "Warrior"
                Wep1 = Rngsus.Next(1, 4)
                Select Case Wep1
                    Case 1
                        WepA1 = 15
                        WepA = "Short Sword"

                    Case 2
                        WepA1 = 16
                        WepA = "Long Sword"

                    Case 3
                        WepA1 = 45
                        WepA = "Two-handed Sword"
                End Select
            Case 2
                ClassGen = 2
                ClassTag = "Rogue"
                Wep1 = Rngsus.Next(1, 4)
                Arm1 = 1
                Select Case Wep1
                    Case 1
                        WepA1 = 12
                        WepA = "Dagger"
                    Case 2
                        WepA1 = 14
                        WepA = "Short Sword"
                    Case 3
                        WepA1 = 15
                        WepA = "Long Sword"
                End Select
            Case 3
                ClassGen = 3
                ClassTag = "Mage"
                Wep1 = 1
                Arm1 = 1
                Select Case Wep1
                    Case 1
                        WepA1 = 5
                        WepA = "Staff"
                End Select
            Case 4
                ClassGen = 4
                ClassTag = "Tactician"
                Wep1 = 1
                Select Case Wep1
                    Case 1
                        WepA1 = 6
                        WepA = "Bow"
                End Select
            Case 5
                ClassGen = 5
                ClassTag = "Unborn"
                Wep1 = Rngsus.Next(1, 7)
                Select Case Wep1
                    Case 1
                        WepA1 = 8
                        WepA = "Dagger"
                    Case 2
                        WepA1 = 10
                        WepA = "Short Sword"
                    Case 3
                        WepA1 = 12
                        WepA = "Long Sword"
                    Case 4
                        WepA1 = 20
                        WepA = "Two-handed Sword"
                    Case 5
                        WepA1 = 13
                        WepA = "Staff"
                    Case 6
                        WepA1 = 15
                        WepA = "Bow"
                End Select
        End Select
        Return classchoice
    End Function
    Public Shared Function armorgen() As Integer
        If ClassGen = 1 Then 'Warrior
            Arm1 = Rngsus2.Next(1, 4)
        ElseIf ClassGen = 4 Then
            Arm1 = Rngsus2.Next(1, 4)
        Else
            Arm1 = Rngsus2.Next(1, 5)
        End If

        If ClassGen = 2 Then 'Rogue
            Arm1 = 1
        End If

        If ClassGen = 3 Then 'Mage
            Arm1 = 1
        End If

        If ClassGen = 4 Then 'Tactician
            Arm1 = Rngsus2.Next(1, 4)
        End If

        'Warrior Armor Gen: Start
        Select Case Arm1 And ClassGen = 1
            Case 1
                armorgen = 2
                ArmA = "Leather"
                ArmBonus = 100
            Case 2
                armorgen = 3
                ArmA = "Chain"
                ArmBonus = 200
            Case 3
                armorgen = 4
                ArmA = "Plate"
                ArmBonus = 400
        End Select
        'Warrior Armor Gen: End

        'Rogue Armor Gen: Start
        Select Case Arm1 And ClassGen = 2
            Case 1
                armorgen = 2
                ArmA = "Leather"
                ArmBonus = 100
        End Select
        'Rogue Armor Gen: End

        'Mage Armor Gen: Start
        Select Case Arm1 And ClassGen = 3
            Case 1
                armorgen = 1
                ArmA = "Cloth"
                ArmBonus = 50
        End Select
        'Mage Armor Gen: End

        'Tactician Armor Gen: Start
        Select Case Arm1 And ClassGen = 4
            Case 1
                armorgen = 1
                ArmA = "Cloth"
                ArmBonus = 50
            Case 2
                armorgen = 2
                ArmA = "Leather"
                ArmBonus = 100
            Case 3
                armorgen = 3
                ArmA = "Chain"
                ArmBonus = 200
        End Select
        'Tactician Armor Gen: End

        'Unborn Armor Gen: Start
        Select Case Arm1 And ClassGen = 5
            Case 1
                armorgen = 1
                ArmA = "Cloth"
                ArmBonus = 50
            Case 2
                armorgen = 2
                ArmA = "Leather"
                ArmBonus = 100
            Case 3
                armorgen = 3
                ArmA = "Chain"
                ArmBonus = 200
            Case 4
                armorgen = 4
                ArmA = "Plate"
                ArmBonus = 400
        End Select
        Return armorgen
    End Function
    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles GenButton.Click
        classchoice()
        armorgen()
        echoice()
        TierNum = Rngsus3.Next(1, 4)
    End Sub
    Private Sub Updater_Tick(sender As Object, e As EventArgs) Handles Updater.Tick
        ClassLabel.Text = ClassTag
        ELabel.Text = ETag
        Label2.Text = WepA
        Label3.Text = WepA1
        Label4.Text = ArmA
        Label8.Text = ArmBonus
        Label11.Text = Health + ArmBonus
        Label12.Text = TierNum
        Label15.Text = toHit
        Label17.Text = PHealth
        PHealth = Health + ArmBonus
        Label20.Text = Count
        Label22.Text = EHealth
        'Tier Information Begins
        If TierNum = 1 Then
            If ArmA = "Cloth" Then
                ArmBonus = 50
            ElseIf ArmA = "Leather" Then
                ArmBonus = 100
            ElseIf ArmA = "Chain" Then
                ArmBonus = 200
            ElseIf ArmA = "Plate" Then
                ArmBonus = 400
            Else
                ArmBonus = -1
            End If
        ElseIf TierNum = 2 Then
            If ArmA = "Cloth" Then
                ArmBonus = 100
            ElseIf ArmA = "Leather" Then
                ArmBonus = 200
            ElseIf ArmA = "Chain" Then
                ArmBonus = 400
            ElseIf ArmA = "Plate" Then
                ArmBonus = 800
            Else
                ArmBonus = -1
            End If
        ElseIf TierNum = 3 Then
            If ArmA = "Cloth" Then
                ArmBonus = 200
            ElseIf ArmA = "Leather" Then
                ArmBonus = 400
            ElseIf ArmA = "Chain" Then
                ArmBonus = 800
            ElseIf ArmA = "Plate" Then
                ArmBonus = 1600
            Else
                ArmBonus = -1
            End If
        End If
        'Tier Information Ends
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        TierNum += 1
        If TierNum = 4 Then
            TierNum = 1
        End If
    End Sub
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Attack.Click
        toHit = Rngsus4.Next(1, 101)
        'Warrior Gen Begins
        If ClassGen = 1 And (toHit >= 1 And toHit <= 50) Then
            Dmg = 55
            EHealth = EHealth - Dmg
        ElseIf ClassGen = 1 And toHit = 5 And Not EGen = 1 Then
            Dmg = 55
            EHealth = EHealth - Dmg
            Label19.Text = "Stunned"
            Count = 40
            KeepCount.Enabled = True
        End If
        'Warrior Gen Ends
        'Rogue Gen Begins
        If ClassGen = 2 And (toHit >= 1 And toHit <= 75) Then
            Dmg = 22
            EHealth = EHealth - Dmg
        ElseIf ClassGen = 2 And toHit = 16 And Not EGen = 2 Then
            Dmg = 22 + DmgMod
            DmgMod = 10
            EHealth = EHealth - Dmg
            PHealth = PHealth + 5
            Label19.Text = "Shiv Effect"
        End If
        'Rogue Gen Ends
        'Mage Gen Begins
        If ClassGen = 3 And (toHit >= 1 And toHit <= 25) Then
            Dmg = 5
            EHealth = EHealth - Dmg
        ElseIf ClassGen = 3 And toHit = 15 And Not EGen = 3 Then
            Dmg = 5 + DmgMod
            DmgMod = 15
            EHealth = EHealth - Dmg
            Label19.Text = "Stunned"
            Count = 20
            KeepCount.Enabled = True
        End If
        'Mage Gen Ends
        'Tactician Gen Begins
        If ClassGen = 4 And (toHit >= 1 And toHit <= 50) Then
            Dmg = 20
            EHealth = EHealth - Dmg
        ElseIf ClassGen = 4 And toHit = 26 And Not EGen = 4 Then
            Dmg = 20 + DmgMod
            EHealth = EHealth - Dmg
            Label19.Text = "Headshot"
        End If
        'Tactician Gen Ends
        'Unborn Gen Begins
        If ClassGen = 5 And (toHit >= 1 And toHit <= 20) And (Wep1 = 1 Or Wep1 = 2 Or Wep1 = 3 Or Wep1 = 4 Or Wep1 = 5) Then
            If Wep1 = 1 Then
                Dmg = 8
                EHealth = EHealth - Dmg
            ElseIf ClassGen = 5 And Wep1 = 1 And toHit = 99 And Not EGen = 5 Then
                Dmg = 8
                EHealth = EHealth - Dmg
                Label19.Text = "Stunned"
                Count = 40
                KeepCount.Enabled = True
            ElseIf ClassGen = 5 And Wep1 = 1 And toHit = 99 And EGen = 5 Then
                Dmg = 8
                EHealth = EHealth - Dmg
                Label19.Text = "Immune"
            End If
        End If

        If Wep1 = 2 Then
            Dmg = 10
            EHealth = EHealth - Dmg
        ElseIf ClassGen = 5 And Wep1 = 2 And toHit = 99 And Not EGen = 5 Then
            Dmg = 10
            EHealth = EHealth - Dmg
            Label19.Text = "Stunned"
            Count = 40
            KeepCount.Enabled = True
        ElseIf ClassGen = 5 And Wep1 = 2 And toHit = 99 And EGen = 5 Then
            Dmg = 8
            EHealth = EHealth - Dmg
            Label19.Text = "Immune"
        End If

        If Wep1 = 3 Then
                Dmg = 12
                EHealth = EHealth - Dmg
            ElseIf ClassGen = 5 And Wep1 = 3 And toHit = 99 And Not EGen = 5 Then
            Dmg = 12
            EHealth = EHealth - Dmg
                Label19.Text = "Stunned"
                Count = 40
                KeepCount.Enabled = True
            ElseIf ClassGen = 5 And Wep1 = 3 And toHit = 99 And EGen = 5 Then
            Dmg = 12
            EHealth = EHealth - Dmg
                Label19.Text = "Immune"
            End If

        If Wep1 = 4 Then
            Dmg = 20
            EHealth = EHealth - Dmg
        ElseIf ClassGen = 5 And Wep1 = 4 And toHit = 99 And Not EGen = 5 Then
            Dmg = 8
            EHealth = EHealth - Dmg
            Label19.Text = "Stunned"
            Count = 40
            KeepCount.Enabled = True
        ElseIf ClassGen = 5 And Wep1 = 4 And toHit = 99 And EGen = 5 Then
            Dmg = 8
            EHealth = EHealth - Dmg
            Label19.Text = "Immune"
        End If

        If Wep1 = 5 Then
            Dmg = 13
            EHealth = EHealth - Dmg
        ElseIf ClassGen = 5 And Wep1 = 5 And toHit = 99 And Not EGen = 5 Then
            Dmg = 8
            EHealth = EHealth - Dmg
            Label19.Text = "Stunned"
            Count = 40
            KeepCount.Enabled = True
        ElseIf ClassGen = 5 And Wep1 = 5 And toHit = 99 And EGen = 5 Then
            Dmg = 13
            EHealth = EHealth - Dmg
            Label19.Text = "Immune"
        End If

        If ClassGen = 5 And (toHit >= 1 And toHit <= 20) And Wep1 = 6 Then
            Dmg = 15
            EHealth = EHealth - Dmg
        ElseIf ClassGen = 5 And Wep1 = 6 And toHit = 99 And Not EGen = 5 Then
            Dmg = 15
            EHealth = EHealth - Dmg
            Label19.Text = "Bleeding"
            Count = 100
        ElseIf ClassGen = 5 And Wep1 = 6 And toHit = 99 And EGen = 5 Then
            Dmg = 15
            EHealth = EHealth - Dmg
            Label19.Text = "Immune"
        End If
        'Unborn Gen Ends
    End Sub
    Private Sub KeepCount_Tick(sender As Object, e As EventArgs) Handles KeepCount.Tick
        Count -= 1
        If Count = 0 Then
            KeepCount.Enabled = False
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles WarrForce.Click
        toHit = 5
        If ClassGen = 1 And toHit = 5 And EGen = 1 Then
            Label19.Text = "Immune"
        ElseIf ClassGen = 1 And toHit = 5 Then
            Dmg = 55
            EHealth = EHealth - Dmg
            Label19.Text = "Stunned"
            Count = 40
            KeepCount.Enabled = True
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles RogueForce.Click
        toHit = 16
        If ClassGen = 2 And toHit = 16 And EGen = 2 Then
            Label19.Text = "Immune"
        ElseIf ClassGen = 2 And toHit = 16 Then
            Dmg = 22 + DmgMod
            DmgMod = 10
            EHealth = EHealth - Dmg
            PHealth = PHealth + 5
            Label19.Text = "Shiv Effect"
        End If
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles MageForce.Click
        toHit = 15
        If ClassGen = 3 And toHit = 15 And EGen = 3 Then
            Label19.Text = "Immune"
        ElseIf ClassGen = 3 And toHit = 15 Then
            Dmg = 5 + DmgMod
            DmgMod = 15
            EHealth = EHealth - Dmg
            Label19.Text = "Stunned"
            Count = 20
            KeepCount.Enabled = True
        End If
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles TactForce.Click
        toHit = 26
        If ClassGen = 4 And toHit = 26 And EGen = 4 Then
            Label19.Text = "Immune"
        ElseIf ClassGen = 4 And toHit = 26 Then
            Dmg = 20 + DmgMod
                EHealth = EHealth - Dmg
                Label19.Text = "Headshot"
            End If
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles UnForce.Click
        toHit = 99
        If ClassGen = 5 And Wep1 = 1 And toHit = 99 And EGen = 5 Then
            Label19.Text = "Immune"
        ElseIf ClassGen = 5 And Wep1 = 1 And toHit = 99 Then
            Dmg = 8
            EHealth = EHealth - Dmg
            Label19.Text = "Stunned"
            Count = 40
            KeepCount.Enabled = True
        End If

        If ClassGen = 5 And Wep1 = 2 And toHit = 99 And EGen = 5 Then
            Label19.Text = "Immune"
        ElseIf ClassGen = 5 And Wep1 = 2 And toHit = 99 Then
            Dmg = 10
            EHealth = EHealth - Dmg
            Label19.Text = "Stunned"
            Count = 40
            KeepCount.Enabled = True
        End If

        If ClassGen = 5 And Wep1 = 3 And toHit = 99 And EGen = 5 Then
            Label19.Text = "Immune"
        ElseIf ClassGen = 5 And Wep1 = 3 And toHit = 99 Then
            Dmg = 12
            EHealth = EHealth - Dmg
            Label19.Text = "Stunned"
            Count = 40
            KeepCount.Enabled = True
        End If

        If ClassGen = 5 And Wep1 = 4 And toHit = 99 And EGen = 5 Then
            Label19.Text = "Immune"
        ElseIf ClassGen = 5 And Wep1 = 4 And toHit = 99 Then
            Dmg = 20
            EHealth = EHealth - Dmg
            Label19.Text = "Stunned"
            Count = 40
            KeepCount.Enabled = True
        End If

        If ClassGen = 5 And Wep1 = 5 And toHit = 99 And EGen = 5 Then
            Label19.Text = "Immune"
        ElseIf ClassGen = 5 And Wep1 = 5 And toHit = 99 Then
            Dmg = 13
            EHealth = EHealth - Dmg
            Label19.Text = "Stunned"
            Count = 40
            KeepCount.Enabled = True
        End If

        If ClassGen = 5 And Wep1 = 6 And toHit = 99 And EGen = 5 Then
            Label19.Text = "Immune"
        ElseIf ClassGen = 5 And Wep1 = 6 And toHit = 99 Then
            Dmg = 15
            EHealth = EHealth - Dmg
            Label19.Text = "Bleeding"
            Count = 100
            KeepCount.Enabled = True
        End If
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Reset.Click
        Health = 2000
        EHealth = 2000
    End Sub
    Public Shared Function echoice()
        echoice = Rngsus5.Next(1, 6)
        Select Case echoice
            Case 1
                EGen = 1
                ETag = "Warrior"
            Case 2
                EGen = 2
                ETag = "Rogue"
            Case 3
                EGen = 3
                ETag = "Mage"
            Case 4
                EGen = 4
                ETag = "Tactician"
            Case 5
                EGen = 5
                ETag = "Unborn"
        End Select
        Return echoice
    End Function
End Class