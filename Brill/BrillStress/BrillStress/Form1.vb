Public Class Form1  'Finally working rng for enemies; thanks to Luke for actually figuring it out so I still have my brain
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
    Dim E1Num As Integer
    Dim E2Num As Integer
    Dim E3Num As Integer
    Dim E4Num As Integer
    Dim E5Num As Integer
    Dim Rngsus As New Random 'The best of gods (self explanatory)
    Dim SecondRngsus As New Random 'The second coming of the best of gods
    Dim TripleRngsus As New Random '#diedForTheseSpins
    Dim ClothValue As Integer
    Dim LeatherValue As Integer
    Dim ChainValue As Integer
    Dim PlateValue As Integer
    Dim Dagger As Integer
    Dim Shorty As Integer
    Dim Tacgnol As Integer
    Dim Deucey As Integer
    Dim Gandalf As Integer
    Dim Pewpew As Integer
    Dim E1TrueH As Integer
    Dim E2TrueH As Integer
    Dim E3TrueH As Integer
    Dim E4TrueH As Integer
    Dim E5TrueH As Integer

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
        E1Num = SecondRngsus.Next(1, 180)
        If Plug = 4 Then
            E2Num = SecondRngsus.Next(1, 180)
        End If
        If Plug = 8 Then
            E3Num = SecondRngsus.Next(1, 180)
        End If
        If Plug = 12 Then
            E4Num = SecondRngsus.Next(1, 180)
        End If
        If Plug = 14 Then
            E5Num = SecondRngsus.Next(1, 180)
        End If
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
            LabelClass.Text = "Mage"
            ArmLabel.Text = "Cloth"
            E1Wep.Text = "Staff"

        ElseIf Classtho = 4 Then
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
        End If

            If Classtho2 = 1 Then
                LabelClass2.Text = "Warrior"
            ElseIf Classtho2 = 2 Then
                LabelClass2.Text = "Rogue"
            ElseIf Classtho2 = 3 Then
                LabelClass2.Text = "Mage"
            ElseIf Classtho2 = 4 Then
                LabelClass2.Text = "Tactician"
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

            ElseIf Classtho2 = 2 Then
                ArmLabel2.Text = "Leather"

            ElseIf Classtho2 = 3 Then
                ArmLabel2.Text = "Cloth"

            ElseIf Classtho2 = 4 Then
                Armortho2 = Rngsus.Next(1, 3)
                If Armortho2 = 1 Then
                    ArmLabel2.Text = "Cloth"
                ElseIf Armortho2 = 2 Then
                    ArmLabel2.Text = "Leather"
                ElseIf Armortho2 = 3 Then
                    ArmLabel2.Text = "Chain Mail"
                End If

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
        End If


        If Classtho3 = 1 Then
            LabelClass3.Text = "Warrior"
        ElseIf Classtho3 = 2 Then
            LabelClass3.Text = "Rogue"
        ElseIf Classtho3 = 3 Then
            LabelClass3.Text = "Mage"
            ArmLabel3.Text = "Cloth"
            E3Wep.Text = "Staff"
        ElseIf Classtho3 = 4 Then
            LabelClass3.Text = "Tactician"
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

            'ElseIf Classtho3 = 3 Then
            'ArmLabel3.Text = "Cloth"
            'E3Wep.Text = "Staff"

        ElseIf Classtho3 = 4 Then
            Armortho3 = Rngsus.Next(1, 4)
            If Armortho3 = 1 Then
                ArmLabel3.Text = "Cloth"
            ElseIf Armortho3 = 2 Then
                ArmLabel3.Text = "Leather"
            ElseIf Armortho3 = 3 Then
                ArmLabel3.Text = "Chain Mail"
            End If
            E3Wep.Text = "Bow"

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
        End If

        If Classtho4 = 1 Then
            LabelClass4.Text = "Warrior"
        ElseIf Classtho4 = 2 Then
            LabelClass4.Text = "Rogue"
        ElseIf Classtho4 = 3 Then
            LabelClass4.Text = "Mage"
        ElseIf Classtho4 = 4 Then
            LabelClass4.Text = "Tactician"
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

        ElseIf Classtho4 = 2 Then
            ArmLabel4.Text = "Leather"

        ElseIf Classtho4 = 3 Then
            ArmLabel4.Text = "Cloth"

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
        End If

        If Classtho5 = 1 Then
            LabelClass5.Text = "Warrior"
        ElseIf Classtho5 = 2 Then
            LabelClass5.Text = "Rogue"
        ElseIf Classtho5 = 3 Then
            LabelClass5.Text = "Mage"
        ElseIf Classtho5 = 4 Then
            LabelClass5.Text = "Tactician"
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

        ElseIf Classtho5 = 2 Then
            ArmLabel5.Text = "Leather"

        ElseIf Classtho5 = 3 Then
            ArmLabel5.Text = "Cloth"

        ElseIf Classtho5 = 4 Then
            Armortho5 = Rngsus.Next(1, 4)
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
        End If

        If Classtho = 1 Then ' Warrior
            '1 shortsword
            '2 longsword
            '3 twohanded
            WepThreat = TripleRngsus.Next(1, 4)
            If WepThreat = 1 Then
                E1Wep.Text = "Short Sword"
            ElseIf WepThreat = 2 Then
                E1Wep.Text = "Long Sword"
            ElseIf WepThreat = 3 Then
                E1Wep.Text = "Two-handed Sword"
            End If
        ElseIf Classtho = 2 Then ' Rogue
            '1 Dagger
            '2 Short Sword
            '3 Long Sword
            WepThreat = TripleRngsus.Next(1, 4)
            If WepThreat = 1 Then
                E1Wep.Text = "Dagger"
            ElseIf WepThreat = 2 Then
                E1Wep.Text = "Short Sword"
            ElseIf WepThreat = 3 Then
                E1Wep.Text = "Long Sword"
            End If
        ElseIf Classtho = 3 Then ' Mage
            E1Wep.Text = "Staff"
        ElseIf Classtho = 4 Then ' Tact
            E1Wep.Text = "Bow"
        ElseIf Classtho = 5 Then ' Unborn
            WepThreat = TripleRngsus.Next(1, 7)
            If WepThreat = 1 Then
                E1Wep.Text = "Dagger"
            End If
            If WepThreat = 2 Then
                E1Wep.Text = "Short Sword"
            End If
            If WepThreat = 3 Then
                E1Wep.Text = "Long Sword"
            End If
            If WepThreat = 4 Then
                E1Wep.Text = "Two-handed Sword"
            End If
            If WepThreat = 5 Then
                E1Wep.Text = "Staff"
            End If
            If WepThreat = 6 Then
                E1Wep.Text = "Bow"
            End If
        End If

        If Classtho2 = 1 Then ' Warrior
            '1 shortsword
            '2 longsword
            '3 twohanded
            WepThreat2 = TripleRngsus.Next(1, 4)
            If WepThreat2 = 1 Then
                E2Wep.Text = "Short Sword"
            ElseIf WepThreat2 = 2 Then
                E2Wep.Text = "Long Sword"
            ElseIf WepThreat2 = 3 Then
                E2Wep.Text = "Two-handed Sword"
            End If
        ElseIf Classtho2 = 2 Then ' Rogue
            '1 Dagger
            '2 Short Sword
            '3 Long Sword
            WepThreat2 = TripleRngsus.Next(1, 4)
            If WepThreat2 = 1 Then
                E2Wep.Text = "Dagger"
            ElseIf WepThreat2 = 2 Then
                E2Wep.Text = "Short Sword"
            ElseIf WepThreat2 = 3 Then
                E2Wep.Text = "Long Sword"
            End If
        ElseIf Classtho2 = 3 Then ' Mage
            E2Wep.Text = "Staff"
        ElseIf Classtho2 = 4 Then ' Tact
            E2Wep.Text = "Bow"
        ElseIf Classtho2 = 5 Then ' Unborn
            WepThreat2 = TripleRngsus.Next(1, 7)
            If WepThreat2 = 1 Then
                E2Wep.Text = "Dagger"
            End If
            If WepThreat2 = 2 Then
                E2Wep.Text = "Short Sword"
            End If
            If WepThreat2 = 3 Then
                E2Wep.Text = "Long Sword"
            End If
            If WepThreat2 = 4 Then
                E2Wep.Text = "Two-handed Sword"
            End If
            If WepThreat2 = 5 Then
                E2Wep.Text = "Staff"
            End If
            If WepThreat2 = 6 Then
                E2Wep.Text = "Bow"
            End If
        End If

        If Classtho3 = 1 Then ' Warrior
            '1 shortsword
            '2 longsword
            '3 twohanded
            WepThreat3 = TripleRngsus.Next(1, 4)
            If WepThreat3 = 1 Then
                E3Wep.Text = "Short Sword"
            ElseIf WepThreat3 = 2 Then
                E3Wep.Text = "Long Sword"
            ElseIf WepThreat3 = 3 Then
                E3Wep.Text = "Two-handed Sword"
            End If
        ElseIf Classtho3 = 2 Then ' Rogue
            '1 Dagger
            '2 Short Sword
            '3 Long Sword
            WepThreat3 = TripleRngsus.Next(1, 4)
            If WepThreat3 = 1 Then
                E3Wep.Text = "Dagger"
            ElseIf WepThreat3 = 2 Then
                E3Wep.Text = "Short Sword"
            ElseIf WepThreat3 = 3 Then
                E3Wep.Text = "Long Sword"
            End If
            'ElseIf Classtho3 = 3 Then ' Mage
            'E3Wep.Text = "Staff"
            'ElseIf Classtho3 = 4 Then ' Tact
            '     E3Wep.Text = "Bow"
        ElseIf Classtho3 = 5 Then ' Unborn
            WepThreat3 = TripleRngsus.Next(1, 7)
            If WepThreat3 = 1 Then
                E3Wep.Text = "Dagger"
            End If
            If WepThreat3 = 2 Then
                E3Wep.Text = "Short Sword"
            End If
            If WepThreat3 = 3 Then
                E3Wep.Text = "Long Sword"
            End If
            If WepThreat3 = 4 Then
                E3Wep.Text = "Two-handed Sword"
            End If
            If WepThreat3 = 5 Then
                E3Wep.Text = "Staff"
            End If
            If WepThreat3 = 6 Then
                E3Wep.Text = "Bow"
            End If
        End If

        If Classtho4 = 1 Then ' Warrior
            '1 shortsword
            '2 longsword
            '3 twohanded
            WepThreat4 = TripleRngsus.Next(1, 4)
            If WepThreat4 = 1 Then
                E4Wep.Text = "Short Sword"
            ElseIf WepThreat4 = 2 Then
                E4Wep.Text = "Long Sword"
            ElseIf WepThreat4 = 3 Then
                E4Wep.Text = "Two-handed Sword"
            End If
        ElseIf Classtho4 = 2 Then ' Rogue
            '1 Dagger
            '2 Short Sword
            '3 Long Sword
            WepThreat4 = TripleRngsus.Next(1, 4)
            If WepThreat4 = 1 Then
                E4Wep.Text = "Dagger"
            ElseIf WepThreat4 = 2 Then
                E4Wep.Text = "Short Sword"
            ElseIf WepThreat4 = 3 Then
                E4Wep.Text = "Long Sword"
            End If
        ElseIf Classtho4 = 3 Then ' Mage
            E4Wep.Text = "Staff"
        ElseIf Classtho4 = 4 Then ' Tact
            E4Wep.Text = "Bow"
        ElseIf Classtho4 = 5 Then ' Unborn
            WepThreat4 = TripleRngsus.Next(1, 7)
            If WepThreat4 = 1 Then
                E4Wep.Text = "Dagger"
            End If
            If WepThreat4 = 2 Then
                E4Wep.Text = "Short Sword"
            End If
            If WepThreat4 = 3 Then
                E4Wep.Text = "Long Sword"
            End If
            If WepThreat4 = 4 Then
                E4Wep.Text = "Two-handed Sword"
            End If
            If WepThreat4 = 5 Then
                E4Wep.Text = "Staff"
            End If
            If WepThreat4 = 6 Then
                E4Wep.Text = "Bow"
            End If
        End If

        If Classtho5 = 1 Then ' Warrior
            '1 shortsword
            '2 longsword
            '3 twohanded
            WepThreat5 = TripleRngsus.Next(1, 4)
            If WepThreat5 = 1 Then
                E5Wep.Text = "Short Sword"
            ElseIf WepThreat5 = 2 Then
                E5Wep.Text = "Long Sword"
            ElseIf WepThreat5 = 3 Then
                E5Wep.Text = "Two-handed Sword"
            End If
        ElseIf Classtho5 = 2 Then ' Rogue
            '1 Dagger
            '2 Short Sword
            '3 Long Sword
            WepThreat5 = TripleRngsus.Next(1, 4)
            If WepThreat5 = 1 Then
                E5Wep.Text = "Dagger"
            ElseIf WepThreat5 = 2 Then
                E5Wep.Text = "Short Sword"
            ElseIf WepThreat5 = 3 Then
                E5Wep.Text = "Long Sword"
            End If
        ElseIf Classtho5 = 3 Then ' Mage
            E5Wep.Text = "Staff"
        ElseIf Classtho5 = 4 Then ' Tact
            E3Wep.Text = "Bow"
        ElseIf Classtho5 = 5 Then ' Unborn
            WepThreat5 = TripleRngsus.Next(1, 7)
            If WepThreat5 = 1 Then
                E5Wep.Text = "Dagger"
            End If
            If WepThreat5 = 2 Then
                E5Wep.Text = "Short Sword"
            End If
            If WepThreat5 = 3 Then
                E5Wep.Text = "Long Sword"
            End If
            If WepThreat3 = 4 Then
                E5Wep.Text = "Two-handed Sword"
            End If
            If WepThreat3 = 5 Then
                E5Wep.Text = "Staff"
            End If
            If WepThreat3 = 6 Then
                E5Wep.Text = "Bow"
            End If
        End If
    End Sub

    Private Sub Updater_Tick(sender As System.Object, e As System.EventArgs) Handles Updater.Tick
        PlugLabel.Text = Plug
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
        '////////////////////////////////////////////
        If ArmLabel.Text = "Cloth" Then
            E1TrueH = E1Num * ClothValue
        ElseIf ArmLabel.Text = "Leather" Then
            E1TrueH = E1Num * LeatherValue
        ElseIf ArmLabel.Text = "Chain Mail" Then
            E1TrueH = E1Num * ChainValue
        ElseIf ArmLabel.Text = "Plate Mail" Then
            E1TrueH = E1Num * PlateValue
        End If
        '////////////////////////////////////////////
        If ArmLabel2.Text = "Cloth" Then
            E2TrueH = E2Num * ClothValue
        ElseIf ArmLabel2.Text = "Leather" Then
            E2TrueH = E2Num * LeatherValue
        ElseIf ArmLabel2.Text = "Chain Mail" Then
            E2TrueH = E2Num * ChainValue
        ElseIf ArmLabel2.Text = "Plate Mail" Then
            E2TrueH = E2Num * PlateValue
        End If
        '////////////////////////////////////////////
        If ArmLabel3.Text = "Cloth" Then
            E3TrueH = E3Num * ClothValue
        ElseIf ArmLabel3.Text = "Leather" Then
            E3TrueH = E3Num * LeatherValue
        ElseIf ArmLabel3.Text = "Chain Mail" Then
            E3TrueH = E3Num * ChainValue
        ElseIf ArmLabel3.Text = "Plate Mail" Then
            E3TrueH = E3Num * PlateValue
        End If
        '/////////////////////////////////////////////
        If ArmLabel4.Text = "Cloth" Then
            E4TrueH = E4Num * ClothValue
        ElseIf ArmLabel4.Text = "Leather" Then
            E4TrueH = E4Num * LeatherValue
        ElseIf ArmLabel4.Text = "Chain Mail" Then
            E4TrueH = E4Num * ChainValue
        ElseIf ArmLabel4.Text = "Plate Mail" Then
            E4TrueH = E4Num * PlateValue
        End If
        '//////////////////////////////////////////////
        If ArmLabel5.Text = "Cloth" Then
            E5TrueH = E5Num * ClothValue
        ElseIf ArmLabel5.Text = "Leather" Then
            E5TrueH = E5Num * LeatherValue
        ElseIf ArmLabel5.Text = "Chain Mail" Then
            E5TrueH = E5Num * ChainValue
        ElseIf ArmLabel5.Text = "Plate Mail" Then
            E5TrueH = E5Num * PlateValue
        End If
        '/////////////////////////
        If Classtho = 1 Then
            Shorty = 15
            Tacgnol = 16
            Deucey = 45
        ElseIf Classtho = 2 Then
            Dagger = 12
            Shorty = 14
            Tacgnol = 15
        ElseIf Classtho = 3 Then
            Gandalf = 5
        ElseIf Classtho = 4 Then
            Pewpew = 25
        ElseIf Classtho = 5 Then
            Dagger = 8
            Shorty = 10
            Tacgnol = 12
            Deucey = 20
            Gandalf = 13
            Pewpew = 15
        End If
        '//////////
        If Classtho2 = 1 Then
            Shorty = 15
            Tacgnol = 16
            Deucey = 45
        ElseIf Classtho2 = 2 Then
            Dagger = 12
            Shorty = 14
            Tacgnol = 15
        ElseIf Classtho2 = 3 Then
            Gandalf = 5
        ElseIf Classtho2 = 4 Then
            Pewpew = 25
        ElseIf Classtho2 = 5 Then
            Dagger = 8
            Shorty = 10
            Tacgnol = 12
            Deucey = 20
            Gandalf = 13
            Pewpew = 15
        End If
        '///////////////
        If Classtho3 = 1 Then
            Shorty = 15
            Tacgnol = 16
            Deucey = 45
        ElseIf Classtho3 = 2 Then
            Dagger = 12
            Shorty = 14
            Tacgnol = 15
        ElseIf Classtho3 = 3 Then
            Gandalf = 5
        ElseIf Classtho3 = 4 Then
            Pewpew = 25
        ElseIf Classtho3 = 5 Then
            Dagger = 8
            Shorty = 10
            Tacgnol = 12
            Deucey = 20
            Gandalf = 13
            Pewpew = 15
        End If
        '////////////////
        If Classtho4 = 1 Then
            Shorty = 15
            Tacgnol = 16
            Deucey = 45
        ElseIf Classtho4 = 2 Then
            Dagger = 12
            Shorty = 14
            Tacgnol = 15
        ElseIf Classtho4 = 3 Then
            Gandalf = 5
        ElseIf Classtho4 = 4 Then
            Pewpew = 25
        ElseIf Classtho4 = 5 Then
            Dagger = 8
            Shorty = 10
            Tacgnol = 12
            Deucey = 20
            Gandalf = 13
            Pewpew = 15
        End If
        '////////////////
        If Classtho5 = 1 Then 'Warrior
            Shorty = 15
            Tacgnol = 16
            Deucey = 45
        ElseIf Classtho5 = 2 Then 'Rogue
            Dagger = 12
            Shorty = 14
            Tacgnol = 15
        ElseIf Classtho5 = 3 Then 'Mage
            Gandalf = 5
        ElseIf Classtho5 = 4 Then 'Tactician
            Pewpew = 25
        ElseIf Classtho5 = 5 Then 'Unborn
            Dagger = 8
            Shorty = 10
            Tacgnol = 12
            Deucey = 20
            Gandalf = 13
            Pewpew = 15
        End If
        '/////////////////////////
        'Type 1
        'Warrior
        If Classtho = 1 And E1Wep.Text = "Short Sword" Then
            E1Dmg.Text = E1Num * Shorty
        ElseIf Classtho = 1 And E1Wep.Text = "Long Sword" Then
            E1Dmg.Text = E1Num * Tacgnol
        ElseIf Classtho = 1 And E1Wep.Text = "Two-Handed Sword" Then
            E1Dmg.Text = E1Num * Deucey
        End If
        '/////////////////////////
        'Type1
        'Rogue
        If Classtho = 2 And E1Wep.Text = "Dagger" Then
            E1Dmg.Text = E1Num * Dagger
        ElseIf Classtho = 2 And E1Wep.Text = "Short Sword" Then
            E1Dmg.Text = E1Num * Shorty
        ElseIf Classtho = 2 And E1Wep.Text = "Long Sword" Then
            E1Dmg.Text = E1Num * Tacgnol
        End If
        '/////////////////////////
        'Type 1
        'Mage
        If Classtho = 3 And E1Wep.Text = "Staff" Then
            E1Dmg.Text = E1Num * Gandalf
        End If
        '/////////////////////////
        'Type 1
        'Tactician
        If Classtho = 4 And E1Wep.Text = "Bow" Then
            E1Dmg.Text = E1Num * Pewpew
        End If
        '/////////////////////////
        'Type 1
        'Unborn
        If Classtho = 5 And E1Wep.Text = "Dagger" Then
            E1Dmg.Text = E1Num * Dagger
        ElseIf Classtho = 5 And E1Wep.Text = "Short Sword" Then
            E1Dmg.Text = E1Num * Shorty
        ElseIf Classtho = 5 And E1Wep.Text = "Long Sword" Then
            E1Dmg.Text = E1Num * Tacgnol
        ElseIf Classtho = 5 And E1Wep.Text = "Two-Handed Sword" Then
            E1Dmg.Text = E1Num * Deucey
        ElseIf Classtho = 5 And E1Wep.Text = "Staff" Then
            E1Dmg.Text = E1Num * Gandalf
        ElseIf Classtho = 5 And E1Wep.Text = "Bow" Then
            E1Dmg.Text = E1Num * Pewpew
        End If
        '/////////////////////////
        'Type 2
        'Warrior
        If Classtho2 = 1 And E2Wep.Text = "Short Sword" Then
            E2Dmg.Text = E2Num * Shorty
        ElseIf Classtho2 = 1 And E2Wep.Text = "Long Sword" Then
            E2Dmg.Text = E2Num * Tacgnol
        ElseIf Classtho2 = 1 And E2Wep.Text = "Two-Handed Sword" Then
            E2Dmg.Text = E2Num * Deucey
        End If
        '/////////////////////////
        'Type 2
        'Rogue
        If Classtho2 = 2 And E2Wep.Text = "Dagger" Then
            E2Dmg.Text = E2Num * Dagger
        ElseIf Classtho2 = 2 And E2Wep.Text = "Short Sword" Then
            E2Dmg.Text = E2Num * Shorty
        ElseIf Classtho2 = 2 And E2Wep.Text = "Long Sword" Then
            E2Dmg.Text = E2Num * Tacgnol
        End If
        '/////////////////////////
        'Type 2
        'Mage
        If Classtho2 = 3 And E2Wep.Text = "Staff" Then
            E2Dmg.Text = E2Num * Gandalf
        End If
        '/////////////////////////
        'Type 2
        'Tactician
        If Classtho2 = 4 And E2Wep.Text = "Bow" Then
            E2Dmg.Text = E2Num * Pewpew
        End If
        '/////////////////////////
        'Type 2
        'Unborn
        If Classtho2 = 5 And E2Wep.Text = "Dagger" Then
            E2Dmg.Text = E2Num * Dagger
        ElseIf Classtho2 = 5 And E1Wep.Text = "Short Sword" Then
            E2Dmg.Text = E2Num * Shorty
        ElseIf Classtho2 = 5 And E2Wep.Text = "Long Sword" Then
            E2Dmg.Text = E2Num * Tacgnol
        ElseIf Classtho2 = 5 And E2Wep.Text = "Two-Handed Sword" Then
            E2Dmg.Text = E2Num * Deucey
        ElseIf Classtho2 = 5 And E2Wep.Text = "Staff" Then
            E2Dmg.Text = E2Num * Gandalf
        ElseIf Classtho2 = 5 And E2Wep.Text = "Bow" Then
            E2Dmg.Text = E2Num * Pewpew
        End If
        '/////////////////////////
        'Type 3
        'Warrior
        If Classtho3 = 1 And E3Wep.Text = "Short Sword" Then
            E3Dmg.Text = E3Num * Shorty
        ElseIf Classtho3 = 1 And E3Wep.Text = "Long Sword" Then
            E3Dmg.Text = E3Num * Tacgnol
        ElseIf Classtho3 = 1 And E3Wep.Text = "Two-Handed Sword" Then
            E3Dmg.Text = E3Num * Deucey
        End If
        '/////////////////////////
        'Type 3
        'Rogue
        If Classtho3 = 2 And E3Wep.Text = "Dagger" Then
            E3Dmg.Text = E3Num * Dagger
        ElseIf Classtho3 = 2 And E3Wep.Text = "Short Sword" Then
            E3Dmg.Text = E3Num * Shorty
        ElseIf Classtho3 = 2 And E3Wep.Text = "Long Sword" Then
            E3Dmg.Text = E3Num * Tacgnol
        End If
        '/////////////////////////
        'Type 3
        'Mage
        If Classtho3 = 3 And E3Wep.Text = "Staff" Then
            E3Dmg.Text = E3Num * Gandalf
        End If
        '/////////////////////////
        'Type 3
        'Tactician
        If Classtho3 = 4 And E3Wep.Text = "Bow" Then
            E3Dmg.Text = E3Num * Pewpew
        End If
        '/////////////////////////
        'Type 3
        'Unborn
        If Classtho3 = 5 And E3Wep.Text = "Dagger" Then
            E3Dmg.Text = E3Num * Dagger
        ElseIf Classtho3 = 5 And E3Wep.Text = "Short Sword" Then
            E3Dmg.Text = E3Num * Shorty
        ElseIf Classtho3 = 5 And E3Wep.Text = "Long Sword" Then
            E3Dmg.Text = E3Num * Tacgnol
        ElseIf Classtho3 = 5 And E3Wep.Text = "Two-Handed Sword" Then
            E3Dmg.Text = E3Num * Deucey
        ElseIf Classtho3 = 5 And E3Wep.Text = "Staff" Then
            E3Dmg.Text = E3Num * Gandalf
        ElseIf Classtho3 = 5 And E3Wep.Text = "Bow" Then
            E3Dmg.Text = E3Num * Pewpew
        End If
        '/////////////////////////
        'Type 4
        'Warrior
        If Classtho4 = 1 And E4Wep.Text = "Short Sword" Then
            E4Dmg.Text = E4Num * Shorty
        ElseIf Classtho4 = 1 And E4Wep.Text = "Long Sword" Then
            E4Dmg.Text = E4Num * Tacgnol
        ElseIf Classtho4 = 1 And E4Wep.Text = "Two-Handed Sword" Then
            E4Dmg.Text = E4Num * Deucey
        End If
        '/////////////////////////
        'Type 4
        'Rogue
        If Classtho4 = 2 And E4Wep.Text = "Dagger" Then
            E4Dmg.Text = E4Num * Dagger
        ElseIf Classtho4 = 2 And E4Wep.Text = "Short Sword" Then
            E4Dmg.Text = E4Num * Shorty
        ElseIf Classtho4 = 2 And E4Wep.Text = "Long Sword" Then
            E4Dmg.Text = E4Num * Tacgnol
        End If
        '/////////////////////////
        'Type 4
        'Mage
        If Classtho4 = 3 And E4Wep.Text = "Staff" Then
            E4Dmg.Text = E4Num * Gandalf
        End If
        '/////////////////////////
        'Type 4
        'Tactician
        If Classtho4 = 4 And E4Wep.Text = "Bow" Then
            E4Dmg.Text = E4Num * Pewpew
        End If
        '/////////////////////////
        'Type 4
        'Unborn
        If Classtho4 = 5 And E4Wep.Text = "Dagger" Then
            E4Dmg.Text = E4Num * Dagger
        ElseIf Classtho4 = 5 And E4Wep.Text = "Short Sword" Then
            E4Dmg.Text = E4Num * Shorty
        ElseIf Classtho4 = 5 And E4Wep.Text = "Long Sword" Then
            E4Dmg.Text = E4Num * Tacgnol
        ElseIf Classtho4 = 5 And E4Wep.Text = "Two-Handed Sword" Then
            E4Dmg.Text = E4Num * Deucey
        ElseIf Classtho4 = 5 And E4Wep.Text = "Staff" Then
            E4Dmg.Text = E4Num * Gandalf
        ElseIf Classtho3 = 5 And E4Wep.Text = "Bow" Then
            E4Dmg.Text = E4Num * Pewpew
        End If
        '/////////////////////////
        'Type 5
        'Warrior
        If Classtho5 = 1 And E5Wep.Text = "Short Sword" Then
            E5Dmg.Text = E5Num * Shorty
        ElseIf Classtho4 = 1 And E4Wep.Text = "Long Sword" Then
            E5Dmg.Text = E5Num * Tacgnol
        ElseIf Classtho = 1 And E4Wep.Text = "Two-Handed Sword" Then
            E5Dmg.Text = E5Num * Deucey
        End If
        '/////////////////////////
        'Type 5
        'Rogue
        If Classtho5 = 2 And E5Wep.Text = "Dagger" Then
            E5Dmg.Text = E5Num * Dagger
        ElseIf Classtho5 = 2 And E5Wep.Text = "Short Sword" Then
            E5Dmg.Text = E5Num * Shorty
        ElseIf Classtho5 = 2 And E5Wep.Text = "Long Sword" Then
            E5Dmg.Text = E5Num * Tacgnol
        End If
        '/////////////////////////
        'Type 5
        'Mage
        If Classtho5 = 3 And E5Wep.Text = "Staff" Then
            E5Dmg.Text = E5Num * Gandalf
        End If
        '/////////////////////////
        'Type 5
        'Tactician
        If Classtho5 = 4 And E5Wep.Text = "Bow" Then
            E5Dmg.Text = E5Num * Pewpew
        End If
        '/////////////////////////
        'Type 5
        'Unborn
        If Classtho5 = 5 And E5Wep.Text = "Dagger" Then
            E5Dmg.Text = E5Num * Dagger
        ElseIf Classtho5 = 5 And E5Wep.Text = "Short Sword" Then
            E5Dmg.Text = E5Num * Shorty
        ElseIf Classtho5 = 5 And E5Wep.Text = "Long Sword" Then
            E5Dmg.Text = E5Num * Tacgnol
        ElseIf Classtho5 = 5 And E5Wep.Text = "Two-Handed Sword" Then
            E5Dmg.Text = E5Num * Deucey
        ElseIf Classtho5 = 5 And E5Wep.Text = "Staff" Then
            E5Dmg.Text = E5Num * Gandalf
        ElseIf Classtho5 = 5 And E5Wep.Text = "Bow" Then
            E5Dmg.Text = E5Num * Pewpew
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
        E1Wep.Text = "Edge of Edge"
        E2Wep.Text = "Edge of Edge"
        E3Wep.Text = "Edge of Edge"
        E4Wep.Text = "Edge of Edge"
        E5Wep.Text = "Edge of Edge"
        E1Health.Text = "9.99e261^99999999"
        E2Health.Text = "9.99e261^99999999"
        E3Health.Text = "9.99e261^99999999"
        E4Health.Text = "9.99e261^99999999"
        E5Health.Text = "9.99e261^99999999"
        E1Dmg.Text = "9.99e261^99999999"
        E2Dmg.Text = "9.99e261^99999999"
        E3Dmg.Text = "9.99e261^99999999"
        E4Dmg.Text = "9.99e261^99999999"
        E5Dmg.Text = "9.99e261^99999999"
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ClothValue = 105
        LeatherValue = 110
        ChainValue = 120
        PlateValue = 130
    End Sub


End Class
