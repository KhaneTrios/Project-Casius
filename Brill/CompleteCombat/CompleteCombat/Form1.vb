Public Class Form1
    Public Shared Rngsus As New Random
    Public Shared Rngsus2 As New Random
    Public Shared Rngsus3 As New Random
    Public Shared TierNum As Integer
    Public Shared ClassGen As Integer
    Public Shared ClassTag As String
    Public Shared Wep1 As Integer 'Weapon Choice
    Public Shared WepA1 As Integer 'Weapon Damage
    Public Shared WepA As String 'Weapon Name
    Public Shared Arm1 As Integer 'Armor Choice
    Public Shared ArmA As String 'Armor Name
    Public Shared ArmBonus As Integer 'Bonus from Armor
    Dim Health = 2000
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
    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        classchoice()
        armorgen()
        TierNum = Rngsus3.Next(1, 4)
    End Sub

    Private Sub Updater_Tick(sender As Object, e As EventArgs) Handles Updater.Tick
        ClassLabel.Text = ClassTag
        Label2.Text = WepA
        Label3.Text = WepA1
        Label4.Text = ArmA
        Label8.Text = ArmBonus
        Label11.Text = Health + ArmBonus
        Label12.Text = TierNum
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
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        TierNum += 1
        If TierNum = 4 Then
            TierNum = 1
        End If
    End Sub
End Class