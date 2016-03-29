Public Class ClothMod  'Finally working rng for enemies; thanks to Luke for actually figuring it out so I still have my brain
    Dim Plug As Integer 'For the Randomizer
    Dim Classtho As Integer 'Determines class
    Dim Classtho2 As Integer 'Determines class 2
    Dim Classtho3 As Integer 'Determines class 3
    Dim Classtho4 As Integer 'Determines class 4
    Dim Classtho5 As Integer 'Determines class 5
    Dim Armortho As Integer 'Determines armor
    Dim Armortho2 As Integer 'Determines armor 2
    Dim Armortho3 As Integer 'Determines armor 3
    Dim Armortho4 As Integer 'Determines armor 4
    Dim Armortho5 As Integer 'Determines armor 5
    Dim WepThreat As Integer 'Determines weapon
    Dim WepThreat2 As Integer 'Determines weapon 2
    Dim WepThreat3 As Integer 'Determines weapon 3
    Dim WepThreat4 As Integer 'Determines weapon 4
    Dim WepThreat5 As Integer 'Determines weapon 5
    Dim E1Num As Integer 'Number of enemies in Bracket 1
    Dim E2Num As Integer 'Number of enemies in Bracket 2
    Dim E3Num As Integer 'Number of enemies in Bracket 3
    Dim E4Num As Integer 'Number of enemies in Bracket 4
    Dim E5Num As Integer 'Number of enemies in Bracket 5
    Dim Rngsus As New Random 'The best of gods (self explanatory)
    Dim SecondRngsus As New Random 'The second coming of the best of gods
    Dim TripleRngsus As New Random '#diedForTheseSpins
    Dim ClothValue As Integer 'Cloth Armor Health Variable
    Dim LeatherValue As Integer 'Leather Armor Health Variable
    Dim ChainValue As Integer 'Chain Armor Health Variable
    Dim PlateValue As Integer 'Plate Armor Health Variable
    Dim Dagger As Integer 'Damage Value: Dagger
    Dim Shorty As Integer 'Damage Value: Short Sword
    Dim Tacgnol As Integer 'Damage Value: Long Sword
    Dim Deucey As Integer 'Damage Value: Two-handed Sword
    Dim Gandalf As Integer 'Damage Value: Staff
    Dim Pewpew As Integer 'Damage Value: Bow
    Dim E1TrueH As Integer 'Total Health of Enemy Bracket 1
    Dim E2TrueH As Integer 'Total Health of Enemy Bracket 2
    Dim E3TrueH As Integer 'Total Health of Enemy Bracket 3
    Dim E4TrueH As Integer 'Total Health of Enemy Bracket 4
    Dim E5TrueH As Integer 'Total Health of Enemy Bracket 5
    Dim WepName As String 'Weapon Name: Bracket 1
    Dim WepName2 As String 'Weapon Name: Bracket 2
    Dim WepName3 As String 'Weapon Name: Bracket 3
    Dim WepName4 As String 'Weapon Name: Bracket 4
    Dim WepName5 As String 'Weapon Name: Bracket 5
    Dim EDmg1 As Integer 'Bracket 1 Damage
    Dim EDmg2 As Integer 'Bracket 2 Damage
    Dim EDmg3 As Integer 'Bracket 3 Damage
    Dim EDmg4 As Integer 'Bracket 4 Damage
    Dim EDmg5 As Integer 'Bracket 5 Damage
    Dim TierCheck As Integer 'Selects the Tier for Weapon/Armor Modifications
    Dim ClothCheck As Integer 'Total Health gained from Armor based on Tier
    Dim LeatherCheck As Integer 'Total Health gained from Armor based on Tier
    Dim ChainCheck As Integer 'Total Health gained from Armor based on Tier
    Dim PlateCheck As Integer 'Total Health gained from Armor based on Tier
    Dim Scrub As Integer 'For DeChecker

    Private Sub UnPlug_Click(sender As System.Object, e As System.EventArgs) Handles UnPlug.Click
        Plugger.Enabled = True
        UnPlug.Enabled = False
    End Sub

    Private Sub Plugger_Tick(sender As System.Object, e As System.EventArgs) Handles Plugger.Tick
        Plug += 1
        If Plug = 20 Then
            Plugger.Enabled = False
            RePlug.Enabled = True
        End If
        Classtho = Rngsus.Next(1, 6)
        Classtho2 = Rngsus.Next(1, 6)
        Classtho3 = Rngsus.Next(1, 6)
        Classtho4 = Rngsus.Next(1, 6)
        Classtho5 = Rngsus.Next(1, 6)
        E1Num = SecondRngsus.Next(1, 181)
        E2Num = SecondRngsus.Next(1, 181)
        E3Num = SecondRngsus.Next(1, 180)
        E4Num = SecondRngsus.Next(1, 181)
        E5Num = SecondRngsus.Next(1, 181)

        'Generator 1
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
            WepThreat = TripleRngsus.Next(1, 4)
            If WepThreat = 1 Then
                WepName = "Short Sword"
            ElseIf WepThreat = 2 Then
                WepName = "Long Sword"
            ElseIf WepThreat = 3 Then
                WepName = "Two-handed Sword"
            End If

        ElseIf Classtho = 2 Then
            ArmLabel.Text = "Leather"
            WepThreat = TripleRngsus.Next(1, 4)
            If WepThreat = 1 Then
                WepName = "Dagger"
            ElseIf WepThreat = 2 Then
                WepName = "Short Sword"
            ElseIf WepThreat = 3 Then
                WepName = "Long Sword"
            End If

        ElseIf Classtho = 3 Then
            LabelClass.Text = "Mage"
            ArmLabel.Text = "Cloth"
            WepThreat = 1
            WepName = "Staff"

        ElseIf Classtho = 4 Then
            WepThreat = 1
            WepName = "Bow"
            Armortho = Rngsus.Next(1, 4)
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
            WepThreat = TripleRngsus.Next(1, 7)
            If WepThreat = 1 Then
                WepName = "Dagger"
            End If
            If WepThreat = 2 Then
                WepName = "Short Sword"
            End If
            If WepThreat = 3 Then
                WepName = "Long Sword"
            End If
            If WepThreat = 4 Then
                WepName = "Two-handed Sword"
            End If
            If WepThreat = 5 Then
                WepName = "Staff"
            End If
            If WepThreat = 6 Then
                WepName = "Bow"
            End If
        End If

        'Generator 2
        If Classtho2 = 1 Then
            LabelClass2.Text = "Warrior"
        ElseIf Classtho2 = 2 Then
            LabelClass2.Text = "Rogue"
        ElseIf Classtho2 = 3 Then
            LabelClass2.Text = "Mage"
            ArmLabel2.Text = "Cloth"
            WepThreat2 = 1
            WepName2 = "Staff"
        ElseIf Classtho2 = 4 Then
            LabelClass2.Text = "Tactician"
            WepThreat2 = 1
            WepName2 = "Bow"
        ElseIf Classtho2 = 5 Then
            LabelClass2.Text = "Unborn"
        Else
            LabelClass2.Text = "Wtf"
        End If

        If Classtho2 = 1 Then
            Armortho2 = Rngsus.Next(2, 5)
            If Armortho2 = 2 Then
                ArmLabel2.Text = "Leather"
            ElseIf Armortho2 = 3 Then
                ArmLabel2.Text = "Chain Mail"
            ElseIf Armortho2 = 4 Then
                ArmLabel2.Text = "Plate Mail"
            Else
                ArmLabel2.Text = "Wtf"
            End If
            WepThreat2 = TripleRngsus.Next(1, 4)
            If WepThreat2 = 1 Then
                WepName2 = "Short Sword"
            ElseIf WepThreat2 = 2 Then
                WepName2 = "Long Sword"
            ElseIf WepThreat2 = 3 Then
                WepName2 = "Two-handed Sword"
            End If

        ElseIf Classtho2 = 2 Then
            ArmLabel2.Text = "Leather"
            WepThreat2 = TripleRngsus.Next(1, 4)
            If WepThreat2 = 1 Then
                WepName2 = "Dagger"
            ElseIf WepThreat2 = 2 Then
                WepName2 = "Short Sword"
            ElseIf WepThreat2 = 3 Then
                WepName2 = "Long Sword"
            End If

        ElseIf Classtho2 = 4 Then
            Armortho2 = Rngsus.Next(1, 3)
            WepThreat2 = 1
            If Armortho2 = 1 Then
                ArmLabel2.Text = "Cloth"
            ElseIf Armortho2 = 2 Then
                ArmLabel2.Text = "Leather"
            ElseIf Armortho2 = 3 Then
                ArmLabel2.Text = "Chain Mail"
            End If
            WepThreat2 = 1

        ElseIf Classtho2 = 5 Then
            Armortho2 = Rngsus.Next(1, 5)
            If Armortho2 = 1 Then
                ArmLabel2.Text = "Cloth"
            ElseIf Armortho2 = 2 Then
                ArmLabel2.Text = "Leather"
            ElseIf Armortho2 = 3 Then
                ArmLabel2.Text = "Chain Mail"
            ElseIf Armortho2 = 4 Then
                ArmLabel2.Text = "Plate Mail"
            End If
            WepThreat2 = TripleRngsus.Next(1, 7)
            If WepThreat2 = 1 Then
                WepName2 = "Dagger"
            End If
            If WepThreat2 = 2 Then
                WepName2 = "Short Sword"
            End If
            If WepThreat2 = 3 Then
                WepName2 = "Long Sword"
            End If
            If WepThreat2 = 4 Then
                WepName2 = "Two-handed Sword"
            End If
            If WepThreat2 = 5 Then
                WepName2 = "Staff"
            End If
            If WepThreat2 = 6 Then
                WepName2 = "Bow"
            End If
        End If

        'Generator 3
        If Classtho3 = 1 Then
            LabelClass3.Text = "Warrior"
            WepThreat3 = TripleRngsus.Next(1, 4)
            If WepThreat3 = 1 Then
                WepName3 = "Short Sword"
            ElseIf WepThreat3 = 2 Then
                WepName3 = "Long Sword"
            ElseIf WepThreat3 = 3 Then
                WepName3 = "Two-handed Sword"
            End If
        ElseIf Classtho3 = 2 Then
            LabelClass3.Text = "Rogue"

        ElseIf Classtho3 = 3 Then
            LabelClass3.Text = "Mage"
            ArmLabel3.Text = "Cloth"
            WepThreat3 = 1
            WepName3 = "Staff"

        ElseIf Classtho3 = 4 Then
            WepThreat3 = 1
            LabelClass3.Text = "Tactician"
            WepName3 = "Bow"

        ElseIf Classtho3 = 5 Then
            LabelClass3.Text = "Unborn"

        Else
            LabelClass3.Text = "Wtf"
        End If

        If Classtho3 = 1 Then
            Armortho3 = Rngsus.Next(2, 5)
            If Armortho3 = 2 Then
                ArmLabel3.Text = "Leather"
            ElseIf Armortho3 = 3 Then
                ArmLabel3.Text = "Chain Mail"
            ElseIf Armortho3 = 4 Then
                ArmLabel3.Text = "Plate Mail"
            Else
                ArmLabel3.Text = "Wtf"
            End If

        ElseIf Classtho3 = 2 Then
            ArmLabel3.Text = "Leather"
            WepThreat3 = TripleRngsus.Next(1, 4)
            If WepThreat3 = 1 Then
                WepName3 = "Dagger"
            ElseIf WepThreat3 = 2 Then
                WepName3 = "Short Sword"
            ElseIf WepThreat3 = 3 Then
                WepName3 = "Long Sword"
            End If


        ElseIf Classtho3 = 4 Then
            Armortho3 = Rngsus.Next(1, 4)
            If Armortho3 = 1 Then
                ArmLabel3.Text = "Cloth"
            ElseIf Armortho3 = 2 Then
                ArmLabel3.Text = "Leather"
            ElseIf Armortho3 = 3 Then
                ArmLabel3.Text = "Chain Mail"
            End If
            WepThreat3 = 1

        ElseIf Classtho3 = 5 Then
            Armortho3 = Rngsus.Next(1, 5)
            If Armortho3 = 1 Then
                ArmLabel3.Text = "Cloth"
            ElseIf Armortho3 = 2 Then
                ArmLabel3.Text = "Leather"
            ElseIf Armortho3 = 3 Then
                ArmLabel3.Text = "Chain Mail"
            ElseIf Armortho3 = 4 Then
                ArmLabel3.Text = "Plate Mail"
            End If
            WepThreat3 = TripleRngsus.Next(1, 7)
            If WepThreat3 = 1 Then
                WepName3 = "Dagger"
            End If
            If WepThreat3 = 2 Then
                WepName3 = "Short Sword"
            End If
            If WepThreat3 = 3 Then
                WepName3 = "Long Sword"
            End If
            If WepThreat3 = 4 Then
                WepName3 = "Two-handed Sword"
            End If
            If WepThreat3 = 5 Then
                WepName3 = "Staff"
            End If
            If WepThreat3 = 6 Then
                WepName3 = "Bow"
            End If
        End If

        'Generator 4
        If Classtho4 = 1 Then
            LabelClass4.Text = "Warrior"

        ElseIf Classtho4 = 2 Then
            LabelClass4.Text = "Rogue"

        ElseIf Classtho4 = 3 Then
            WepThreat4 = 1
            LabelClass4.Text = "Mage"
            ArmLabel4.Text = "Cloth"
            WepName4 = "Staff"

        ElseIf Classtho4 = 4 Then
            WepThreat4 = 1
            LabelClass4.Text = "Tactician"
            WepName4 = "Bow"

        ElseIf Classtho4 = 5 Then
            LabelClass4.Text = "Unborn"
        Else
            LabelClass4.Text = "Wtf"
        End If

        If Classtho4 = 1 Then
            Armortho4 = Rngsus.Next(2, 5)
            If Armortho4 = 2 Then
                ArmLabel4.Text = "Leather"
            ElseIf Armortho4 = 3 Then
                ArmLabel4.Text = "Chain Mail"
            ElseIf Armortho4 = 4 Then
                ArmLabel4.Text = "Plate Mail"
            Else
                ArmLabel4.Text = "Wtf"
            End If
            WepThreat4 = TripleRngsus.Next(1, 4)
            If WepThreat4 = 1 Then
                WepName4 = "Short Sword"
            ElseIf WepThreat4 = 2 Then
                WepName4 = "Long Sword"
            ElseIf WepThreat4 = 3 Then
                WepName4 = "Two-handed Sword"
            End If

        ElseIf Classtho4 = 2 Then
            ArmLabel4.Text = "Leather"
            WepThreat4 = TripleRngsus.Next(1, 4)
            If WepThreat4 = 1 Then
                WepName4 = "Dagger"
            ElseIf WepThreat4 = 2 Then
                WepName4 = "Short Sword"
            ElseIf WepThreat4 = 3 Then
                WepName4 = "Long Sword"
            End If

        ElseIf Classtho4 = 4 Then
            Armortho4 = Rngsus.Next(1, 4)
            If Armortho4 = 1 Then
                ArmLabel4.Text = "Cloth"
            ElseIf Armortho4 = 2 Then
                ArmLabel4.Text = "Leather"
            ElseIf Armortho4 = 3 Then
                ArmLabel4.Text = "Chain Mail"
            End If

        ElseIf Classtho4 = 5 Then
            Armortho4 = Rngsus.Next(1, 5)
            If Armortho4 = 1 Then
                ArmLabel4.Text = "Cloth"
            ElseIf Armortho4 = 2 Then
                ArmLabel4.Text = "Leather"
            ElseIf Armortho4 = 3 Then
                ArmLabel4.Text = "Chain Mail"
            ElseIf Armortho4 = 4 Then
                ArmLabel4.Text = "Plate Mail"
            End If
            WepThreat4 = TripleRngsus.Next(1, 7)
            If WepThreat4 = 1 Then
                WepName4 = "Dagger"
            End If
            If WepThreat4 = 2 Then
                WepName4 = "Short Sword"
            End If
            If WepThreat4 = 3 Then
                WepName4 = "Long Sword"
            End If
            If WepThreat4 = 4 Then
                WepName4 = "Two-handed Sword"
            End If
            If WepThreat4 = 5 Then
                WepName4 = "Staff"
            End If
            If WepThreat4 = 6 Then
                WepName4 = "Bow"
            End If
        End If

        'Generator 5
        If Classtho5 = 1 Then
            LabelClass5.Text = "Warrior"

        ElseIf Classtho5 = 2 Then
            LabelClass5.Text = "Rogue"


        ElseIf Classtho5 = 3 Then
            WepThreat5 = 1
            LabelClass5.Text = "Mage"
            ArmLabel5.Text = "Cloth"
            WepName5 = "Staff"

        ElseIf Classtho5 = 4 Then
            WepThreat5 = 1
            LabelClass5.Text = "Tactician"
            WepName5 = "Bow"

        ElseIf Classtho5 = 5 Then
            LabelClass5.Text = "Unborn"
        Else
            LabelClass5.Text = "Wtf"
        End If

        If Classtho5 = 1 Then
            Armortho5 = Rngsus.Next(2, 5)
            If Armortho5 = 2 Then
                ArmLabel5.Text = "Leather"
            ElseIf Armortho5 = 3 Then
                ArmLabel5.Text = "Chain Mail"
            ElseIf Armortho5 = 4 Then
                ArmLabel5.Text = "Plate Mail"
            Else
                ArmLabel5.Text = "Wtf"
            End If
            WepThreat5 = TripleRngsus.Next(1, 4)
            If WepThreat5 = 1 Then
                WepName5 = "Short Sword"
            ElseIf WepThreat5 = 2 Then
                WepName5 = "Long Sword"
            ElseIf WepThreat5 = 3 Then
                WepName5 = "Two-handed Sword"
            End If

        ElseIf Classtho5 = 2 Then
            ArmLabel5.Text = "Leather"
            WepThreat5 = TripleRngsus.Next(1, 4)
            If WepThreat5 = 1 Then
                WepName5 = "Dagger"
            ElseIf WepThreat5 = 2 Then
                WepName5 = "Short Sword"
            ElseIf WepThreat5 = 3 Then
                WepName5 = "Long Sword"
            End If

        ElseIf Classtho5 = 4 Then
            Armortho5 = Rngsus.Next(1, 4)
            WepThreat5 = 1
            If Armortho5 = 1 Then
                ArmLabel5.Text = "Cloth"
            ElseIf Armortho5 = 2 Then
                ArmLabel5.Text = "Leather"
            ElseIf Armortho5 = 3 Then
                ArmLabel5.Text = "Chain Mail"
            End If

        ElseIf Classtho5 = 5 Then
            Armortho5 = Rngsus.Next(1, 5)
            If Armortho5 = 1 Then
                ArmLabel5.Text = "Cloth"
            ElseIf Armortho5 = 2 Then
                ArmLabel5.Text = "Leather"
            ElseIf Armortho5 = 3 Then
                ArmLabel5.Text = "Chain Mail"
            ElseIf Armortho5 = 4 Then
                ArmLabel5.Text = "Plate Mail"
            End If
            WepThreat5 = TripleRngsus.Next(1, 7)
            If WepThreat5 = 1 Then
                WepName5 = "Dagger"
            End If
            If WepThreat5 = 2 Then
                WepName5 = "Short Sword"
            End If
            If WepThreat5 = 3 Then
                WepName5 = "Long Sword"
            End If
            If WepThreat3 = 4 Then
                WepName5 = "Two-handed Sword"
            End If
            If WepThreat3 = 5 Then
                WepName5 = "Staff"
            End If
            If WepThreat3 = 6 Then
                WepName5 = "Bow"
            End If
        End If
    End Sub

    Private Sub Updater_Tick(sender As System.Object, e As System.EventArgs) Handles Updater.Tick
        TierNumber.Text = TierCheck
        TownMultiE1.Text = E1Num
        TownMultiE2.Text = E2Num
        TownMultiE3.Text = E3Num
        TownMultiE4.Text = E4Num
        TownMultiE5.Text = E5Num
        LabelAssault.Text = E1Num + E2Num + E3Num + E4Num + E5Num
        E1Health.Text = E1TrueH
        E2Health.Text = E2TrueH
        E3Health.Text = E3TrueH
        E4Health.Text = E4TrueH
        E5Health.Text = E5TrueH
        E1Wep.Text = WepName
        E2Wep.Text = WepName2
        E3Wep.Text = WepName3
        E4Wep.Text = WepName4
        E5Wep.Text = WepName5
        InvasionHealth.Text = E1TrueH + E2TrueH + E3TrueH + E4TrueH + E5TrueH
        InvasionDamage.Text = EDmg1 + EDmg2 + EDmg3 + EDmg4 + EDmg5
        E1Dmg.Text = EDmg1
        E2Dmg.Text = EDmg2
        E3Dmg.Text = EDmg3
        E4Dmg.Text = EDmg4
        E5Dmg.Text = EDmg5
        ClothCheck = 100 + ClothValue
        LeatherCheck = 100 + LeatherValue
        ChainCheck = 100 + ChainValue
        PlateCheck = 100 + PlateValue
        ClothHealth.Text = ClothCheck
        LeatherHealth.Text = LeatherCheck
        ChainHealth.Text = ChainCheck
        PlateHealth.Text = PlateCheck
        '////////////////////////////////////////////
        If TierCheck = 1 Then
            ClothValue = 5
            LeatherValue = 10
            ChainValue = 20
            PlateValue = 30
            MetalsLabel.Text = "Iron"
            WoodLabel.Text = "Maple Wood"
        End If
        If TierCheck = 2 Then
            ClothValue = 10
            LeatherValue = 20
            ChainValue = 30
            PlateValue = 40
            MetalsLabel.Text = "Mithril"
            WoodLabel.Text = "Silver"
        End If
        If TierCheck = 3 Then
            ClothValue = 20
            LeatherValue = 40
            ChainValue = 60
            PlateValue = 80
            MetalsLabel.Text = "Adamantine"
            WoodLabel.Text = "Ironwood"
        End If
        '////////////////////////////////////////////
        If ArmLabel.Text = "Cloth" Then
            E1TrueH = E1Num * ClothCheck
        ElseIf ArmLabel.Text = "Leather" Then
            E1TrueH = E1Num * LeatherCheck
        ElseIf ArmLabel.Text = "Chain Mail" Then
            E1TrueH = E1Num * ChainCheck
        ElseIf ArmLabel.Text = "Plate Mail" Then
            E1TrueH = E1Num * PlateCheck
        End If
        '////////////////////////////////////////////
        If ArmLabel2.Text = "Cloth" Then
            E2TrueH = E2Num * ClothCheck
        ElseIf ArmLabel2.Text = "Leather" Then
            E2TrueH = E2Num * LeatherCheck
        ElseIf ArmLabel2.Text = "Chain Mail" Then
            E2TrueH = E2Num * ChainCheck
        ElseIf ArmLabel2.Text = "Plate Mail" Then
            E2TrueH = E2Num * PlateCheck
        End If
        '////////////////////////////////////////////
        If ArmLabel3.Text = "Cloth" Then
            E3TrueH = E3Num * ClothCheck
        ElseIf ArmLabel3.Text = "Leather" Then
            E3TrueH = E3Num * LeatherCheck
        ElseIf ArmLabel3.Text = "Chain Mail" Then
            E3TrueH = E3Num * ChainCheck
        ElseIf ArmLabel3.Text = "Plate Mail" Then
            E3TrueH = E3Num * PlateCheck
        End If
        '/////////////////////////////////////////////
        If ArmLabel4.Text = "Cloth" Then
            E4TrueH = E4Num * ClothCheck
        ElseIf ArmLabel4.Text = "Leather" Then
            E4TrueH = E4Num * LeatherCheck
        ElseIf ArmLabel4.Text = "Chain Mail" Then
            E4TrueH = E4Num * ChainCheck
        ElseIf ArmLabel4.Text = "Plate Mail" Then
            E4TrueH = E4Num * PlateCheck
        End If
        '//////////////////////////////////////////////
        If ArmLabel5.Text = "Cloth" Then
            E5TrueH = E5Num * ClothCheck
        ElseIf ArmLabel5.Text = "Leather" Then
            E5TrueH = E5Num * LeatherCheck
        ElseIf ArmLabel5.Text = "Chain Mail" Then
            E5TrueH = E5Num * ChainCheck
        ElseIf ArmLabel5.Text = "Plate Mail" Then
            E5TrueH = E5Num * PlateCheck
        End If
        '/////////////////////////
        'Scratch Pad 2.0 Code Goes Here If Applicable
        '/////////////////////////
        'Type 1
        'Warrior
        If Classtho = 1 And WepThreat = 1 Then 'Short 
            EDmg1 = E1Num * Shorty
            If TierCheck = 2 Then
                Shorty = 15 + 5
            ElseIf TierCheck = 3 Then
                Shorty = 15 + 10
            Else
                Shorty = 15
            End If

        ElseIf Classtho = 1 And WepThreat = 2 Then 'Long
            EDmg1 = E1Num * Tacgnol
            If TierCheck = 2 Then
                Tacgnol = 16 + 5
            ElseIf TierCheck = 3 Then
                Tacgnol = 16 + 10
            Else
                Tacgnol = 16
            End If
        ElseIf Classtho = 1 And WepThreat = 3 Then 'Two
            EDmg1 = E1Num * Deucey
            If TierCheck = 2 Then
                Deucey = 45 + 5
            ElseIf TierCheck = 3 Then
                Deucey = 45 + 10
            Else
                Deucey = 45
            End If

        End If
        '/////////////////////////
        'Type1
        'Rogue
        If Classtho = 2 And WepThreat = 1 Then 'Dagger
            EDmg1 = E1Num * Dagger
            If TierCheck = 2 Then
                Dagger = 12 + 5
            ElseIf TierCheck = 3 Then
                Dagger = 12 + 10
            Else
                Dagger = 12
            End If
        ElseIf Classtho = 2 And WepThreat = 2 Then 'Short
            EDmg1 = E1Num * Shorty
            If TierCheck = 2 Then
                Shorty = 14 + 5
            ElseIf TierCheck = 3 Then
                Shorty = 14 + 10
            Else
                Shorty = 14
            End If
        ElseIf Classtho = 2 And WepThreat = 3 Then 'Long
            EDmg1 = E1Num * Tacgnol
            If TierCheck = 2 Then
                Tacgnol = 15 + 5
            ElseIf TierCheck = 3 Then
                Tacgnol = 15 + 10
            Else
                Tacgnol = 15
            End If
        End If
        '/////////////////////////
        'Type 1
        'Mage
        If Classtho = 3 And WepThreat = 1 Then
            EDmg1 = E1Num * Gandalf
            If TierCheck = 2 Then
                Gandalf = 5 + 2
            ElseIf TierCheck = 3 Then
                Gandalf = 5 + 5
            Else
                Gandalf = 5
            End If
        End If
        '/////////////////////////
        'Type 1
        'Tactician
        If Classtho = 4 And WepThreat = 1 Then
            EDmg1 = E1Num * Pewpew
            If TierCheck = 2 Then
                Pewpew = 25 + 5
            ElseIf TierCheck = 3 Then
                Pewpew = 25 + 10
            Else
                Pewpew = 25
            End If
        End If
        '/////////////////////////
        'Type 1
        'Unborn
        If Classtho = 5 And WepThreat = 1 Then
            EDmg1 = E1Num * Dagger
            If TierCheck = 2 Then
                Dagger = 8 + 5
            ElseIf TierCheck = 3 Then
                Dagger = 8 + 10
            Else
                Dagger = 8
            End If
        ElseIf Classtho = 5 And WepThreat = 2 Then
            EDmg1 = E1Num * Shorty
            If TierCheck = 2 Then
                Shorty = 10 + 5
            ElseIf TierCheck = 3 Then
                Shorty = 10 + 10
            Else
                Shorty = 10
            End If
        ElseIf Classtho = 5 And WepThreat = 3 Then
            EDmg1 = E1Num * Tacgnol
            If TierCheck = 2 Then
                Tacgnol = 12 + 5
            ElseIf TierCheck = 3 Then
                Tacgnol = 12 + 10
            Else
                Tacgnol = 12
            End If
        ElseIf Classtho = 5 And WepThreat = 4 Then
            EDmg1 = E1Num * Deucey
            If TierCheck = 2 Then
                Deucey = 20 + 5
            ElseIf TierCheck = 3 Then
                Deucey = 20 + 10
            Else
                Deucey = 20
            End If
        ElseIf Classtho = 5 And WepThreat = 5 Then
            EDmg1 = E1Num * Gandalf
            If TierCheck = 2 Then
                Gandalf = 13 + 5
            ElseIf TierCheck = 3 Then
                Gandalf = 13 + 10
            Else
                Gandalf = 13
            End If
        ElseIf Classtho = 5 And WepThreat = 6 Then
            EDmg1 = E1Num * Pewpew
            If TierCheck = 2 Then
                Pewpew = 15 + 5
            ElseIf TierCheck = 3 Then
                Pewpew = 15 + 10
            Else
                Pewpew = 15
            End If
        End If
        '/////////////////////////
        'Type 2
        'Warrior
        If Classtho2 = 1 And WepThreat2 = 1 Then
            EDmg2 = E2Num * Shorty
            If TierCheck = 2 Then
                Shorty = 15 + 5
            ElseIf TierCheck = 3 Then
                Shorty = 15 + 10
            Else
                Shorty = 15
            End If
        ElseIf Classtho2 = 1 And WepThreat2 = 2 Then
            EDmg2 = E2Num * Tacgnol
            If TierCheck = 2 Then
                Tacgnol = 16 + 5
            ElseIf TierCheck = 3 Then
                Tacgnol = 16 + 10
            Else
                Tacgnol = 16
            End If
        ElseIf Classtho2 = 1 And WepThreat2 = 3 Then
            EDmg2 = E2Num * Deucey
            If TierCheck = 2 Then
                Deucey = 45 + 5
            ElseIf TierCheck = 3 Then
                Deucey = 45 + 10
            Else
                Deucey = 45
            End If
        End If
        '/////////////////////////
        'Type 2
        'Rogue
        If Classtho2 = 2 And WepThreat2 = 1 Then
            EDmg2 = E2Num * Dagger
            If TierCheck = 2 Then
                Dagger = 12 + 5
            ElseIf TierCheck = 3 Then
                Dagger = 12 + 10
            Else
                Dagger = 12
            End If
        ElseIf Classtho2 = 2 And WepThreat2 = 2 Then
            EDmg2 = E2Num * Shorty
            If TierCheck = 2 Then
                Shorty = 14 + 5
            ElseIf TierCheck = 3 Then
                Shorty = 14 + 10
            Else
                Shorty = 14
            End If
        ElseIf Classtho2 = 2 And WepThreat2 = 3 Then
            EDmg2 = E2Num * Tacgnol
            If TierCheck = 2 Then
                Tacgnol = 15 + 5
            ElseIf TierCheck = 3 Then
                Tacgnol = 15 + 10
            Else
                Tacgnol = 15
            End If
        End If
        '/////////////////////////
        'Type 2
        'Mage
        If Classtho2 = 3 And WepThreat2 = 1 Then
            EDmg2 = E2Num * Gandalf
            If TierCheck = 2 Then
                Gandalf = 5 + 2
            ElseIf TierCheck = 3 Then
                Gandalf = 5 + 5
            Else
                Gandalf = 5
            End If
        End If
        '/////////////////////////
        'Type 2
        'Tactician
        If Classtho2 = 4 And WepThreat2 = 1 Then
            EDmg2 = E2Num * Pewpew
            If TierCheck = 2 Then
                Pewpew = 25 + 5
            ElseIf TierCheck = 3 Then
                Pewpew = 25 + 10
            Else
                Pewpew = 25
            End If
        End If
        '/////////////////////////
        'Type 2
        'Unborn
        If Classtho2 = 5 And WepThreat2 = 1 Then
            EDmg2 = E2Num * Dagger
            If TierCheck = 2 Then
                Dagger = 8 + 5
            ElseIf TierCheck = 3 Then
                Dagger = 8 + 10
            Else
                Dagger = 8
            End If
        ElseIf Classtho2 = 5 And WepThreat2 = 2 Then
            EDmg2 = E2Num * Shorty
            If TierCheck = 2 Then
                Shorty = 10 + 5
            ElseIf TierCheck = 3 Then
                Shorty = 10 + 10
            Else
                Shorty = 10
            End If
        ElseIf Classtho2 = 5 And WepThreat2 = 3 Then
            EDmg2 = E2Num * Tacgnol
            If TierCheck = 2 Then
                Tacgnol = 12 + 5
            ElseIf TierCheck = 3 Then
                Tacgnol = 12 + 10
            Else
                Tacgnol = 12
            End If
        ElseIf Classtho2 = 5 And WepThreat2 = 4 Then
            EDmg2 = E2Num * Deucey
            If TierCheck = 2 Then
                Deucey = 20 + 5
            ElseIf TierCheck = 3 Then
                Deucey = 20 + 10
            Else
                Deucey = 20
            End If
        ElseIf Classtho2 = 5 And WepThreat2 = 5 Then
            EDmg2 = E2Num * Gandalf
            If TierCheck = 2 Then
                Gandalf = 13 + 5
            ElseIf TierCheck = 3 Then
                Gandalf = 13 + 10
            Else
                Gandalf = 13
            End If
        ElseIf Classtho2 = 5 And WepThreat2 = 6 Then
            EDmg2 = E2Num * Pewpew
            If TierCheck = 2 Then
                Pewpew = 15 + 5
            ElseIf TierCheck = 3 Then
                Pewpew = 15 + 10
            Else
                Pewpew = 15
            End If
        End If
        '/////////////////////////
        'Type 3
        'Warrior
        If Classtho3 = 1 And WepThreat3 = 1 Then
            EDmg3 = E3Num * Shorty
            If TierCheck = 2 Then
                Shorty = 15 + 5
            ElseIf TierCheck = 3 Then
                Shorty = 15 + 10
            Else
                Shorty = 15
            End If
        ElseIf Classtho3 = 1 And WepThreat3 = 2 Then
            EDmg3 = E3Num * Tacgnol
            If TierCheck = 2 Then
                Tacgnol = 16 + 5
            ElseIf TierCheck = 3 Then
                Tacgnol = 16 + 10
            Else
                Tacgnol = 16
            End If
        ElseIf Classtho3 = 1 And WepThreat3 = 3 Then
            EDmg3 = E3Num * Deucey
            If TierCheck = 2 Then
                Deucey = 45 + 5
            ElseIf TierCheck = 3 Then
                Deucey = 45 + 10
            Else
                Deucey = 45
            End If
        End If
        '/////////////////////////
        'Type 3
        'Rogue
        If Classtho3 = 2 And WepThreat3 = 1 Then
            EDmg3 = E3Num * Dagger
            If TierCheck = 2 Then
                Dagger = 12 + 5
            ElseIf TierCheck = 3 Then
                Dagger = 12 + 10
            Else
                Dagger = 12
            End If
        ElseIf Classtho3 = 2 And WepThreat3 = 2 Then
            EDmg3 = E3Num * Shorty
            If TierCheck = 2 Then
                Shorty = 14 + 5
            ElseIf TierCheck = 3 Then
                Shorty = 14 + 10
            Else
                Shorty = 14
            End If
        ElseIf Classtho3 = 2 And WepThreat3 = 3 Then
            EDmg3 = E3Num * Tacgnol
            If TierCheck = 2 Then
                Tacgnol = 15 + 5
            ElseIf TierCheck = 3 Then
                Tacgnol = 15 + 10
            Else
                Tacgnol = 15
            End If
        End If
        '/////////////////////////
        'Type 3
        'Mage
        If Classtho3 = 3 And WepThreat3 = 1 Then
            EDmg3 = E3Num * Gandalf
            If TierCheck = 2 Then
                Gandalf = 5 + 2
            ElseIf TierCheck = 3 Then
                Gandalf = 5 + 5
            Else
                Gandalf = 5
            End If
        End If
        '/////////////////////////
        'Type 3
        'Tactician
        If Classtho3 = 4 And WepThreat3 = 1 Then
            EDmg3 = E3Num * Pewpew
            If TierCheck = 2 Then
                Pewpew = 25 + 5
            ElseIf TierCheck = 3 Then
                Pewpew = 25 + 10
            Else
                Pewpew = 25
            End If
        End If
        '/////////////////////////
        'Type 3
        'Unborn
        If Classtho3 = 5 And WepThreat3 = 1 Then
            EDmg3 = E3Num * Dagger
            If TierCheck = 2 Then
                Dagger = 8 + 5
            ElseIf TierCheck = 3 Then
                Dagger = 8 + 10
            Else
                Dagger = 8
            End If
        ElseIf Classtho3 = 5 And WepThreat3 = 2 Then
            EDmg3 = E3Num * Shorty
            If TierCheck = 2 Then
                Shorty = 10 + 5
            ElseIf TierCheck = 3 Then
                Shorty = 10 + 10
            Else
                Shorty = 10
            End If
        ElseIf Classtho3 = 5 And WepThreat3 = 3 Then
            EDmg3 = E3Num * Tacgnol
            If TierCheck = 2 Then
                Tacgnol = 12 + 5
            ElseIf TierCheck = 3 Then
                Tacgnol = 12 + 10
            Else
                Tacgnol = 12
            End If
        ElseIf Classtho3 = 5 And WepThreat3 = 4 Then
            EDmg3 = E3Num * Deucey
            If TierCheck = 2 Then
                Deucey = 20 + 5
            ElseIf TierCheck = 3 Then
                Deucey = 20 + 10
            Else
                Deucey = 20
            End If
        ElseIf Classtho3 = 5 And WepThreat3 = 5 Then
            EDmg3 = E3Num * Gandalf
            If TierCheck = 2 Then
                Gandalf = 13 + 5
            ElseIf TierCheck = 3 Then
                Gandalf = 13 + 10
            Else
                Gandalf = 13
            End If
        ElseIf Classtho3 = 5 And WepThreat3 = 6 Then
            EDmg3 = E3Num * Pewpew
            If TierCheck = 2 Then
                Pewpew = 15 + 5
            ElseIf TierCheck = 3 Then
                Pewpew = 15 + 10
            Else
                Pewpew = 15
            End If
        End If
        '/////////////////////////
        'Type 4
        'Warrior
        If Classtho4 = 1 And WepThreat4 = 1 Then
            EDmg4 = E4Num * Shorty
            If TierCheck = 2 Then
                Shorty = 15 + 5
            ElseIf TierCheck = 3 Then
                Shorty = 15 + 10
            Else
                Shorty = 15
            End If
        ElseIf Classtho4 = 1 And WepThreat4 = 2 Then
            EDmg4 = E4Num * Tacgnol
            If TierCheck = 2 Then
                Tacgnol = 16 + 5
            ElseIf TierCheck = 3 Then
                Tacgnol = 16 + 10
            Else
                Tacgnol = 16
            End If
        ElseIf Classtho4 = 1 And WepThreat4 = 3 Then
            EDmg4 = E4Num * Deucey
            If TierCheck = 2 Then
                Deucey = 45 + 5
            ElseIf TierCheck = 3 Then
                Deucey = 45 + 10
            Else
                Deucey = 45
            End If
        End If
        '/////////////////////////
        'Type 4
        'Rogue
        If Classtho4 = 2 And WepThreat4 = 1 Then
            EDmg4 = E4Num * Dagger
            If TierCheck = 2 Then
                Dagger = 12 + 5
            ElseIf TierCheck = 3 Then
                Dagger = 12 + 10
            Else
                Dagger = 12
            End If
        ElseIf Classtho4 = 2 And WepThreat4 = 2 Then
            EDmg4 = E4Num * Shorty
            If TierCheck = 2 Then
                Shorty = 14 + 5
            ElseIf TierCheck = 3 Then
                Shorty = 14 + 10
            Else
                Shorty = 14
            End If
        ElseIf Classtho4 = 2 And WepThreat4 = 3 Then
            EDmg4 = E4Num * Tacgnol
            If TierCheck = 2 Then
                Tacgnol = 15 + 5
            ElseIf TierCheck = 3 Then
                Tacgnol = 15 + 10
            Else
                Tacgnol = 15
            End If
        End If
        '/////////////////////////
        'Type 4
        'Mage
        If Classtho4 = 3 And WepThreat4 = 1 Then
            EDmg4 = E4Num * Gandalf
            If TierCheck = 2 Then
                Gandalf = 5 + 2
            ElseIf TierCheck = 3 Then
                Gandalf = 5 + 5
            Else
                Gandalf = 5
            End If
        End If
        '/////////////////////////
        'Type 4
        'Tactician
        If Classtho4 = 4 And WepThreat4 = 1 Then
            EDmg4 = E4Num * Pewpew
            If TierCheck = 2 Then
                Pewpew = 25 + 5
            ElseIf TierCheck = 3 Then
                Pewpew = 25 + 10
            Else
                Pewpew = 25
            End If
        End If
        '/////////////////////////
        'Type 4
        'Unborn
        If Classtho4 = 5 And WepThreat4 = 1 Then
            EDmg4 = E4Num * Dagger
            If TierCheck = 2 Then
                Dagger = 8 + 5
            ElseIf TierCheck = 3 Then
                Dagger = 8 + 10
            Else
                Dagger = 8
            End If
        ElseIf Classtho4 = 5 And WepThreat4 = 2 Then
            EDmg4 = E4Num * Shorty
            If TierCheck = 2 Then
                Shorty = 10 + 5
            ElseIf TierCheck = 3 Then
                Shorty = 10 + 10
            Else
                Shorty = 10
            End If
        ElseIf Classtho4 = 5 And WepThreat4 = 3 Then
            EDmg4 = E4Num * Tacgnol
            If TierCheck = 2 Then
                Tacgnol = 12 + 5
            ElseIf TierCheck = 3 Then
                Tacgnol = 12 + 10
            Else
                Tacgnol = 12
            End If
        ElseIf Classtho4 = 5 And WepThreat4 = 4 Then
            EDmg4 = E4Num * Deucey
            If TierCheck = 2 Then
                Deucey = 20 + 5
            ElseIf TierCheck = 3 Then
                Deucey = 20 + 10
            Else
                Deucey = 20
            End If
        ElseIf Classtho4 = 5 And WepThreat4 = 5 Then
            EDmg4 = E4Num * Gandalf
            If TierCheck = 2 Then
                Gandalf = 13 + 5
            ElseIf TierCheck = 3 Then
                Gandalf = 13 + 10
            Else
                Gandalf = 13
            End If
        ElseIf Classtho4 = 5 And WepThreat4 = 6 Then
            EDmg4 = E4Num * Pewpew
            If TierCheck = 2 Then
                Pewpew = 15 + 5
            ElseIf TierCheck = 3 Then
                Pewpew = 15 + 10
            Else
                Pewpew = 15
            End If
        End If
        '/////////////////////////
        'Type 5
        'Warrior
        If Classtho5 = 1 And WepThreat5 = 1 Then
            EDmg5 = E5Num * Shorty
            If TierCheck = 2 Then
                Shorty = 15 + 5
            ElseIf TierCheck = 3 Then
                Shorty = 15 + 10
            Else
                Shorty = 15
            End If
        ElseIf Classtho4 = 1 And WepThreat5 = 2 Then
            EDmg5 = E5Num * Tacgnol
            If TierCheck = 2 Then
                Tacgnol = 16 + 5
            ElseIf TierCheck = 3 Then
                Tacgnol = 16 + 10
            Else
                Tacgnol = 16
            End If
        ElseIf Classtho = 1 And WepThreat5 = 3 Then
            EDmg5 = E5Num * Deucey
            If TierCheck = 2 Then
                Deucey = 45 + 5
            ElseIf TierCheck = 3 Then
                Deucey = 45 + 10
            Else
                Deucey = 45
            End If
        End If
        '/////////////////////////
        'Type 5
        'Rogue
        If Classtho5 = 2 And WepThreat5 = 1 Then
            EDmg5 = E5Num * Dagger
            If TierCheck = 2 Then
                Dagger = 12 + 5
            ElseIf TierCheck = 3 Then
                Dagger = 12 + 10
            Else
                Dagger = 12
            End If
        ElseIf Classtho5 = 2 And WepThreat5 = 2 Then
            EDmg5 = E5Num * Shorty
            If TierCheck = 2 Then
                Shorty = 14 + 5
            ElseIf TierCheck = 3 Then
                Shorty = 14 + 10
            Else
                Shorty = 14
            End If
        ElseIf Classtho5 = 2 And WepThreat5 = 3 Then
            EDmg5 = E5Num * Tacgnol
            If TierCheck = 2 Then
                Tacgnol = 15 + 5
            ElseIf TierCheck = 3 Then
                Tacgnol = 15 + 10
            Else
                Tacgnol = 15
            End If
        End If
        '/////////////////////////
        'Type 5
        'Mage
        If Classtho5 = 3 And WepThreat5 = 1 Then
            EDmg5 = E5Num * Gandalf
            If TierCheck = 2 Then
                Gandalf = 5 + 2
            ElseIf TierCheck = 3 Then
                Gandalf = 5 + 5
            Else
                Gandalf = 5
            End If
        End If
        '/////////////////////////
        'Type 5
        'Tactician
        If Classtho5 = 4 And WepThreat5 = 1 Then
            EDmg5 = E5Num * Pewpew
            If TierCheck = 2 Then
                Pewpew = 25 + 5
            ElseIf TierCheck = 3 Then
                Pewpew = 25 + 10
            Else
                Pewpew = 25
            End If
        End If
        '/////////////////////////
        'Type 5
        'Unborn
        If Classtho5 = 5 And WepThreat5 = 1 Then
            EDmg5 = E5Num * Dagger
            If TierCheck = 2 Then
                Dagger = 8 + 5
            ElseIf TierCheck = 3 Then
                Dagger = 8 + 10
            Else
                Dagger = 8
            End If
        ElseIf Classtho5 = 5 And WepThreat5 = 2 Then
            EDmg5 = E5Num * Shorty
            If TierCheck = 2 Then
                Shorty = 10 + 5
            ElseIf TierCheck = 3 Then
                Shorty = 10 + 10
            Else
                Shorty = 10
            End If
        ElseIf Classtho5 = 5 And WepThreat5 = 3 Then
            EDmg5 = E5Num * Tacgnol
            If TierCheck = 2 Then
                Tacgnol = 12 + 5
            ElseIf TierCheck = 3 Then
                Tacgnol = 12 + 10
            Else
                Tacgnol = 12
            End If
        ElseIf Classtho5 = 5 And WepThreat5 = 4 Then
            EDmg5 = E5Num * Deucey
            If TierCheck = 2 Then
                Deucey = 20 + 5
            ElseIf TierCheck = 3 Then
                Deucey = 20 + 10
            Else
                Deucey = 20
            End If
        ElseIf Classtho5 = 5 And WepThreat5 = 5 Then
            EDmg5 = E5Num * Gandalf
            If TierCheck = 2 Then
                Gandalf = 13 + 5
            ElseIf TierCheck = 3 Then
                Gandalf = 13 + 10
            Else
                Gandalf = 13
            End If
        ElseIf Classtho5 = 5 And WepThreat5 = 6 Then
            EDmg5 = E5Num * Pewpew
            If TierCheck = 2 Then
                Pewpew = 15 + 5
            ElseIf TierCheck = 3 Then
                Pewpew = 15 + 10
            Else
                Pewpew = 15
            End If
        End If
    End Sub

    Private Sub RePlug_Click(sender As System.Object, e As System.EventArgs) Handles RePlug.Click
        Plug = 0
        RePlug.Enabled = False
        UnPlug.Enabled = True
        E1Num = 0
        E2Num = 0
        E3Num = 0
        E4Num = 0
        E5Num = 0
        E1TrueH = 0
        E2TrueH = 0
        E3TrueH = 0
        E4TrueH = 0
        E5TrueH = 0
        LabelClass.Text = "Casual"
        LabelClass2.Text = "Casual"
        LabelClass3.Text = "Casual"
        LabelClass4.Text = "Casual"
        LabelClass5.Text = "Casual"
        ArmLabel.Text = "Plot Armor"
        ArmLabel2.Text = "Plot Armor"
        ArmLabel3.Text = "Plot Armor"
        ArmLabel4.Text = "Plot Armor"
        ArmLabel5.Text = "Plot Armor"
        WepName = "Edge of Edge"
        WepName2 = "Edge of Edge"
        WepName3 = "Edge of Edge"
        WepName4 = "Edge of Edge"
        WepName5 = "Edge of Edge"
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TierCheck = 1
        WepName = "Edge of Edge"
        WepName2 = "Edge of Edge"
        WepName3 = "Edge of Edge"
        WepName4 = "Edge of Edge"
        WepName5 = "Edge of Edge"
        E1Dmg.Text = "9.99e261^99999999"
        E2Dmg.Text = "9.99e261^99999999"
        E3Dmg.Text = "9.99e261^99999999"
        E4Dmg.Text = "9.99e261^99999999"
        E5Dmg.Text = "9.99e261^99999999"
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        TierCheck = 2
        CheckBox1.Enabled = False
        CheckBox2.Enabled = False

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox2.CheckedChanged
        TierCheck = 3
        CheckBox2.Enabled = False
        CheckBox1.Enabled = False

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As System.Object, e As System.EventArgs)
        TierCheck = 1
        CheckBox2.Enabled = False
        CheckBox1.Enabled = False


    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        DeCheck.Enabled = True
        Button1.Enabled = False
    End Sub

    Private Sub DeCheck_Tick(sender As System.Object, e As System.EventArgs) Handles DeCheck.Tick
        Scrub += 1
        If Scrub = 10 Then
            TierCheck = 1
            DeCheck.Enabled = False
            Button1.Enabled = True
            Scrub = 0
        End If
        CheckBox2.Enabled = True
        CheckBox1.Enabled = True
        CheckBox1.Checked = False
        CheckBox2.Checked = False
    End Sub
End Class