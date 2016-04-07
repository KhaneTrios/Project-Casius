Public Class frmIdle
    Private Sub btnClick_Click(sender As System.Object, e As System.EventArgs) Handles btnClick.Click

        Variables.Auto.amount = Val(Variables.Auto.amount + (1))
        Variables.Auto.civ += 1


        If Variables.Auto.up1On = True Then
            Variables.Auto.amount = Val(Variables.Auto.amount + (Variables.Auto.up1Val))
        End If
        If Variables.Auto.up2On = True Then
            Variables.Auto.amount = Val(Variables.Auto.amount + (Variables.Auto.up2Val))
        End If
        If Variables.Auto.up3On = True Then
            Variables.Auto.amount = Val(Variables.Auto.amount + (Variables.Auto.up3Val))
        End If
    End Sub
    Private Sub frmMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblCity1.Text = Variables.Movement.townName         'Looking for the name of the town and setting the Rebuild tab town name label to it
        lblCity2.Text = Variables.Movement.townSize         'Looking for the size of the town to determine the variable values needed for the rest of the autoclicker.
        lblSize.Text = Variables.Movement.townSize


        Select Case Variables.Movement.townSize
            Case 1
                Variables.Auto.auto2Max = 150        'The total amount needed to max out and complete the building of the houses
                Variables.Auto.auto3Max = 500        'The total amount needed to max out and complete the building of the walls
                Variables.Auto.auto4Max = 300        'The total amount needed to max out and complete the building of the barracks
                Variables.Auto.auto5Max = 2          'The total amount needed to max out and complete the building of thr churches
                Variables.Auto.auto6Max = 20         'The total amount needed to max out and complete the building of the shops
                Variables.Auto.auto7Max = 5         'The total amount needed to max out and complete the building of the banks
            Case 2
                Variables.Auto.auto2Max = 500
                Variables.Auto.auto3Max = 1000
                Variables.Auto.auto4Max = 600
                Variables.Auto.auto5Max = 5
                Variables.Auto.auto6Max = 50
                Variables.Auto.auto7Max = 10
            Case 3
                Variables.Auto.auto2Max = 1500
                Variables.Auto.auto3Max = 5000
                Variables.Auto.auto4Max = 1200
                Variables.Auto.auto5Max = 15
                Variables.Auto.auto6Max = 300
                Variables.Auto.auto7Max = 20
        End Select

        Variables.Auto.up1Val = 50
        Variables.Auto.up1Cost = 10000
        Variables.Auto.up2Val = 100
        Variables.Auto.up2Cost = 50000
        Variables.Auto.up3Val = 500
        Variables.Auto.up3Cost = 100000

        'Progress bar max value sets
        barAuto2.Maximum = Variables.Auto.auto2Max              'Setting the progress bar maximum value to the value of the maximum variable due to varying city sizes.
        barAuto3.Maximum = Variables.Auto.auto3Max
        barAuto4.Maximum = Variables.Auto.auto4Max
        barAuto5.Maximum = Variables.Auto.auto5Max
        barAuto6.Maximum = Variables.Auto.auto6Max
        barAuto7.Maximum = Variables.Auto.auto7Max
        barAuto2Col.Maximum = tmrAuto2.Interval

        'Amount of clicks gained linking and loading
        Variables.Auto.amount = Val(0)               'Setting the amount variable to 0 on load.

        'Auto Clicker linking and loading
        'Auto 1
        lblAuto1N.Text = Variables.Auto.auto1        'Setting the label for the number of the first auto-clickers you have bought
        Variables.Auto.auto1 = Val(0)                'Setting the number of the first auto-clickers to 0 on load
        Variables.Auto.auto1Val = Val(1)             'Setting the value-gain the first auto clicker has.
        Variables.Auto.auto1Item = 0                 'Setting the experience value the first auto clicker gains.
        Variables.Auto.auto1Cost = Val(50)           'Setting the cost of the item to purchase.
        Variables.Auto.auto1Bought = False

        'Auto 2
        lblAuto2N.Text = Variables.Auto.auto2        'Setting the label for the number of the second auto-clickers you have bought
        Variables.Auto.auto2 = Val(0)                'Setting the number of the second auto-clickers to 0 on load
        Variables.Auto.auto2Val = Val(10)            'Setting the value-gain the second auto clicker has.
        Variables.Auto.auto2Item = 1                 'Setting the experience value the second auto clicker gains
        Variables.Auto.auto2Cost = Val(100)          'Setting the cost of the item to purchase.
        Variables.Auto.auto2Off = False              'Setting if the button should be disabled yet
        Variables.Auto.auto2Bought = False           'Setting if the user has bought at least one of the item yet

        'Auto 3
        lblAuto3N.Text = Variables.Auto.auto3        'Setting the label for the number of the third auto-clickers you have bought
        Variables.Auto.auto3 = Val(0)                'Setting the number of the third auto-clickers to 0 on load
        Variables.Auto.auto3Val = Val(25)            'Setting the value-gain the third auto clicker has.
        Variables.Auto.auto3Item = 1                 'Setting the experience value the third auto clicker gains
        Variables.Auto.auto3Cost = Val(1000)         'Setting the cost of the item to purchase.
        Variables.Auto.auto3Off = False
        Variables.Auto.auto3Bought = False

        'Auto 4
        lblAuto4N.Text = Variables.Auto.auto4        'Setting the label for the number of the third auto-clickers you have bought
        Variables.Auto.auto4 = Val(0)                'Setting the number of the third auto-clickers to 0 on load
        Variables.Auto.auto4Val = Val(50)            'Setting the value-gain the third auto clicker has.
        Variables.Auto.auto4Item = 1                 'Setting the experience value the third auto clicker gains
        Variables.Auto.auto4Cost = Val(6000)         'Setting the cost of the item to purchase.
        Variables.Auto.auto4Off = False
        Variables.Auto.auto4Bought = False

        'Auto 5
        lblAuto5N.Text = Variables.Auto.auto5        'Setting the label for the number of the third auto-clickers you have bought
        Variables.Auto.auto5 = Val(0)                'Setting the number of the third auto-clickers to 0 on load
        Variables.Auto.auto5Val = Val(100)           'Setting the value-gain the third auto clicker has.
        Variables.Auto.auto5Item = 1                 'Setting the experience value the third auto clicker gains
        Variables.Auto.auto5Cost = Val(10000)        'Setting the cost of the item to purchase.
        Variables.Auto.auto5Off = False
        Variables.Auto.auto5Bought = False

        'Auto 6
        lblAuto4N.Text = Variables.Auto.auto6        'Setting the label for the number of the third auto-clickers you have bought
        Variables.Auto.auto6 = Val(0)                'Setting the number of the third auto-clickers to 0 on load
        Variables.Auto.auto6Val = Val(200)           'Setting the value-gain the third auto clicker has.
        Variables.Auto.auto6Item = 1                 'Setting the experience value the third auto clicker gains
        Variables.Auto.auto6Cost = Val(17000)        'Setting the cost of the item to purchase.
        Variables.Auto.auto6Off = False
        Variables.Auto.auto6Bought = False

        'Auto 7
        lblAuto7N.Text = Variables.Auto.auto7        'Setting the label for the number of the third auto-clickers you have bought
        Variables.Auto.auto7 = Val(0)                'Setting the number of the third auto-clickers to 0 on load
        Variables.Auto.auto7Val = Val(500)           'Setting the value-gain the third auto clicker has.
        Variables.Auto.auto7Item = 1                 'Setting the experience value the third auto clicker gains
        Variables.Auto.auto7Cost = Val(30000)        'Setting the cost of the item to purchase.
        Variables.Auto.auto7Off = False
        Variables.Auto.auto7Bought = False

        'Auto 8
        lblAuto8N.Text = Variables.Auto.auto8        'Setting the label for the number of the third auto-clickers you have bought
        Variables.Auto.auto8 = Val(0)                'Setting the number of the third auto-clickers to 0 on load
        Variables.Auto.auto8Val = Val(1000)          'Setting the value-gain the third auto clicker has.
        Variables.Auto.auto8Item = 1                 'Setting the experience value the third auto clicker gains
        Variables.Auto.auto8Cost = Val(50000)        'Setting the cost of the item to purchase.
        Variables.Auto.auto8Off = False
        Variables.Auto.auto8Bought = False

        'Auto 9
        lblAuto9N.Text = Variables.Auto.auto9        'Setting the label for the number of the third auto-clickers you have bought
        Variables.Auto.auto9 = Val(0)                'Setting the number of the third auto-clickers to 0 on load
        Variables.Auto.auto9Val = Val(100000000)     'Setting the value-gain the third auto clicker has.
        Variables.Auto.auto9Item = 1000000           'Setting the experience value the third auto clicker gains
        Variables.Auto.auto9Cost = Val(100000000)    'Setting the cost of the item to purchase.
        Variables.Auto.auto9Off = False
    End Sub
    Private Sub btn1_Click(sender As System.Object, e As System.EventArgs) Handles btnAuto1.Click
        'Auto Clicker 1
        If Val((Variables.Auto.amount) >= (Variables.Auto.auto1Cost)) Then          'Checking if the amount of GP you have is greater than or equal to the cost of the item.
            Variables.Auto.auto1 = Val((Variables.Auto.auto1) + (1))                'The number of first autoclicker owned 
            Variables.Auto.amount = Val((Variables.Auto.amount) - (Variables.Auto.auto1Cost))  'The final amount score gets subtracted by the cost of the clicker's price, thus buying the clicker
            Variables.Auto.auto1Cost = Val((50) + (Variables.Auto.auto1Cost))       'The cost of the autoclicker scales up by multiplying the number owned by the cost.
            Variables.Auto.auto1Val = Val((Variables.Auto.auto1Val) + (5))          'Scaling the gain value by adding
            Variables.Auto.auto1Bought = True                                       'The user has bought at least one of this item now.
        Else : MessageBox.Show("The city is not strong enough.", "No", MessageBoxButtons.OK, MessageBoxIcon.Error)     'Error message to handle the button being clicked when there is not enough funds to purchase it.
        End If
    End Sub
    Private Sub btn1_Hover(sender As System.Object, e As System.EventArgs) Handles btnAuto1.MouseHover
        ' Dynamic tooltip text appearing if the mouse hovers over the button. The text changes with the Variables.Auto.
        ToolTip.SetToolTip(Me.btnAuto1, " | Cost: " & Variables.Auto.auto1Cost & " | Gain Per Second: " & Variables.Auto.auto1Val & " |")
    End Sub
    Private Sub btn2_Click(sender As System.Object, e As System.EventArgs) Handles btnAuto2.Click
        'Auto Clicker 2
        If Val((Variables.Auto.amount) >= (Variables.Auto.auto2Cost) And Variables.Auto.auto2Col = False) Then          'Checking if the amount of GP you have is greater than or equal to the cost of the item.
            Variables.Auto.auto2 = Val((Variables.Auto.auto2) + (1))               ' 
            Variables.Auto.amount = Val((Variables.Auto.amount) - (Variables.Auto.auto2Cost))
            Variables.Auto.auto2Cost = Val((200) + (Variables.Auto.auto2Cost))
            Variables.Auto.auto2Val = Val((Variables.Auto.auto2Val) + (10))         'Scaling the gain value by adding
            Variables.Auto.auto2Bought = True
        Else : MessageBox.Show("The city is not strong enough.", "No", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If Variables.Auto.auto2Col = True Then
            Variables.Auto.amount += Variables.Auto.auto2Val
        End If
    End Sub
    Private Sub btn2_Hover(sender As System.Object, e As System.EventArgs) Handles btnAuto2.MouseHover
        ' Dynamic tooltip text appearing if the mouse hovers over the button. The text changes with the Variables.Auto.
        ToolTip.SetToolTip(Me.btnAuto2, " | Cost: " & Variables.Auto.auto2Cost & " | Gain Per Second: " & Variables.Auto.auto2Val & " |")
    End Sub
    Private Sub btn3_Click(sender As System.Object, e As System.EventArgs) Handles btnAuto3.Click
        'Auto Clicker 3
        If Val((Variables.Auto.amount) >= (Variables.Auto.auto3Cost)) Then          'Checking if the amount of GP you have is greater than or equal to the cost of the item.
            Variables.Auto.auto3 = Val((Variables.Auto.auto3) + (1))
            Variables.Auto.amount = Val((Variables.Auto.amount) - (Variables.Auto.auto3Cost))  'The final amount score gets subtracted by the cost of the clicker's price, thus buying the clicker
            Variables.Auto.auto3Cost = Val((3000) + (Variables.Auto.auto3Cost))     'The cost of the autoclicker scales up by multiplying the number owned by the cost.
            Variables.Auto.auto3Val = Val((Variables.Auto.auto3Val) + (50))
            Variables.Auto.auto3Bought = True
        Else : MessageBox.Show("The city is not strong enough.", "No", MessageBoxButtons.OK, MessageBoxIcon.Error)     'Error message to handle the button being clicked when there is not enough funds to purchase it.
        End If
    End Sub
    Private Sub btn3_Hover(sender As System.Object, e As System.EventArgs) Handles btnAuto3.MouseHover
        ' Dynamic tooltip text appearing if the mouse hovers over the button. The text changes with the Variables.Auto.
        ToolTip.SetToolTip(Me.btnAuto3, " | Cost: " & Variables.Auto.auto3Cost & " | Gain Per Second: " & Variables.Auto.auto3Val & " |")
    End Sub

    Private Sub btn4_Click(sender As System.Object, e As System.EventArgs) Handles btnAuto4.Click
        'Auto Clicker 4
        If Val((Variables.Auto.amount) >= (Variables.Auto.auto4Cost)) Then          'Checking if the amount of GP you have is greater than or equal to the cost of the item.
            Variables.Auto.auto4 = Val((Variables.Auto.auto4) + (1))
            Variables.Auto.amount = Val((Variables.Auto.amount) - (Variables.Auto.auto4Cost))
            Variables.Auto.auto4Cost = Val((6000) + (Variables.Auto.auto4Cost))
            Variables.Auto.auto4Val = Val((Variables.Auto.auto4Val) + (100))
            Variables.Auto.auto4Bought = True
        Else : MessageBox.Show("The city is not strong enough.", "No", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub btn4_Hover(sender As System.Object, e As System.EventArgs) Handles btnAuto4.MouseHover
        ' Dynamic tooltip text appearing if the mouse hovers over the button. The text changes with the Variables.Auto.
        ToolTip.SetToolTip(Me.btnAuto4, " | Cost: " & Variables.Auto.auto4Cost & " | Gain Per Second: " & Variables.Auto.auto4Val & " |")
    End Sub
    Private Sub btn5_Click(sender As System.Object, e As System.EventArgs) Handles btnAuto5.Click
        'Auto Clicker 5
        If Val((Variables.Auto.amount) >= (Variables.Auto.auto5Cost)) Then          'Checking if the amount of GP you have is greater than or equal to the cost of the item.
            Variables.Auto.auto5 = Val((Variables.Auto.auto5) + (1))
            Variables.Auto.amount = Val((Variables.Auto.amount) - (Variables.Auto.auto5Cost))  'The final amount score gets subtracted by the cost of the clicker's price, thus buying the clicker
            Variables.Auto.auto5Cost = Val((10000) + (Variables.Auto.auto5Cost))    'The cost of the autoclicker scales up by multiplying the number owned by the cost.
            Variables.Auto.auto5Val = Val((Variables.Auto.auto5Val) + (50))
            Variables.Auto.auto5Bought = True
        Else : MessageBox.Show("The city is not strong enough.", "No", MessageBoxButtons.OK, MessageBoxIcon.Error)     'Error message to handle the button being clicked when there is not enough funds to purchase it.
        End If
    End Sub
    Private Sub btn5_Hover(sender As System.Object, e As System.EventArgs) Handles btnAuto5.MouseHover
        ' Dynamic tooltip text appearing if the mouse hovers over the button. The text changes with the Variables.Auto.
        ToolTip.SetToolTip(Me.btnAuto5, " | Cost: " & Variables.Auto.auto5Cost & " | Gain Per Second: " & Variables.Auto.auto5Val & " |")
    End Sub
    Private Sub btn6_Click(sender As System.Object, e As System.EventArgs) Handles btnAuto6.Click
        'Auto Clicker 6
        If Val((Variables.Auto.amount) >= (Variables.Auto.auto6Cost)) Then        'Checking if the amount of GP you have is greater than or equal to the cost of the item.
            Variables.Auto.auto6 = Val((Variables.Auto.auto6) + (1))
            Variables.Auto.amount = Val((Variables.Auto.amount) - (Variables.Auto.auto6Cost))  'The final amount score gets subtracted by the cost of the clicker's price, thus buying the clicker
            Variables.Auto.auto6Cost = Val((15000) + (Variables.Auto.auto6Cost))    'The cost of the autoclicker scales up by multiplying the number owned by the cost.
            Variables.Auto.auto6Val = Val((Variables.Auto.auto6Val) + (100))
            Variables.Auto.auto6Bought = True
        Else : MessageBox.Show("The city is not strong enough.", "No", MessageBoxButtons.OK, MessageBoxIcon.Error)     'Error message to handle the button being clicked when there is not enough funds to purchase it.
        End If
    End Sub
    Private Sub btn6_Hover(sender As System.Object, e As System.EventArgs) Handles btnAuto6.MouseHover
        ' Dynamic tooltip text appearing if the mouse hovers over the button. The text changes with the Variables.Auto.
        ToolTip.SetToolTip(Me.btnAuto6, " | Cost: " & Variables.Auto.auto6Cost & " | Gain Per Second: " & Variables.Auto.auto6Val & " |")
    End Sub
    Private Sub btn7_Click(sender As System.Object, e As System.EventArgs) Handles btnAuto7.Click
        'Auto Clicker 7
        If Val((Variables.Auto.amount) >= (Variables.Auto.auto7Cost)) Then              'Checking if the amount of GP you have is greater than or equal to the cost of the item.
            Variables.Auto.auto7 = Val((Variables.Auto.auto7) + (1))
            Variables.Auto.amount = Val((Variables.Auto.amount) - (Variables.Auto.auto7Cost))  'The final amount score gets subtracted by the cost of the clicker's price, thus buying the clicker
            Variables.Auto.auto7Cost = Val((20000) + (Variables.Auto.auto7Cost))       'The cost of the autoclicker scales up by multiplying the number owned by the cost.
            Variables.Auto.auto7Val = Val((Variables.Auto.auto7Val) + (500))
            Variables.Auto.auto7Bought = True
        Else : MessageBox.Show("The city is not strong enough.", "No", MessageBoxButtons.OK, MessageBoxIcon.Error)     'Error message to handle the button being clicked when there is not enough funds to purchase it.
        End If
    End Sub
    Private Sub btn7_Hover(sender As System.Object, e As System.EventArgs) Handles btnAuto7.MouseHover
        ' Dynamic tooltip text appearing if the mouse hovers over the button. The text changes with the Variables.Auto.
        ToolTip.SetToolTip(Me.btnAuto7, " | Cost: " & Variables.Auto.auto7Cost & " | Gain Per Second: " & Variables.Auto.auto7Val & " |")
    End Sub
    Private Sub btn8_Click(sender As System.Object, e As System.EventArgs) Handles btnAuto8.Click
        'Auto Clicker 8 
        If Val((Variables.Auto.amount) >= (Variables.Auto.auto8Cost)) Then              'Checking if the amount of GP you have is greater than or equal to the cost of the item.
            Variables.Auto.auto8 = Val((Variables.Auto.auto8) + (1))
            Variables.Auto.amount = Val((Variables.Auto.amount) - (Variables.Auto.auto8Cost))  'The final amount score gets subtracted by the cost of the clicker's price, thus buying the clicker
            Variables.Auto.auto8Cost = Val((30000) + (Variables.Auto.auto8Cost))       'The cost of the autoclicker scales up by multiplying the number owned by the cost.
            Variables.Auto.auto8Val = Val((Variables.Auto.auto8Val) + (1000))
            Variables.Auto.auto8Bought = True
        Else : MessageBox.Show("The city is not strong enough.", "No", MessageBoxButtons.OK, MessageBoxIcon.Error)     'Error message to handle the button being clicked when there is not enough funds to purchase it.
        End If
    End Sub
    Private Sub btn8_Hover(sender As System.Object, e As System.EventArgs) Handles btnAuto8.MouseHover
        ' Dynamic tooltip text appearing if the mouse hovers over the button. The text changes with the Variables.Auto.
        ToolTip.SetToolTip(Me.btnAuto8, " | Cost: " & Variables.Auto.auto8Cost & " | Gain Per Second: " & Variables.Auto.auto8Val & " |")
    End Sub
    Private Sub btn9_Click(sender As System.Object, e As System.EventArgs) Handles btnAuto9.Click
        If Variables.Auto.recAsk = False Then
            Recruit.Show()
        End If

        If Variables.Auto.recAsk = True Then
            If Val((Variables.Auto.amount) >= (Variables.Auto.auto9Cost)) Then          'Checking if the amount of GP you have is greater than or equal to the cost of the item.
                Variables.Auto.amount = Val((Variables.Auto.amount) - (Variables.Auto.auto9Cost))  'The final amount score gets subtracted by the cost of the clicker's price, thus buying the clicker

                Randomize()                                                             'Initializxing the random number generator function
                Variables.Auto.gamble = (Int((5 * Rnd()) + 1))                          'The variable is a random integer between 5 and 1.

                Select Case Variables.Auto.gamble
                    Case 5, 4
                        Select Case Variables.Movement.townSize
                            Case 1
                                Variables.Overall.followers += 100
                            Case 2
                                Variables.Overall.followers += 1000
                            Case 3
                                Variables.Overall.followers += 10000
                        End Select
                End Select

                If Variables.Auto.gamble = 5 Then
                    Variables.Auto.amount = Val(Variables.Auto.amount + (Variables.Auto.auto9Val) * (2))
                    frmFollowers.Show()
                ElseIf Variables.Auto.gamble = 4 Then
                    Variables.Auto.amount = Val(Variables.Auto.amount + (Variables.Auto.auto9Val) * (2))
                    frmFollowers.Show()
                Else : frmFollowers.Show()
                End If
            Else : MessageBox.Show("The city is not strong enough.", "No", MessageBoxButtons.OK, MessageBoxIcon.Error)     'Error message to handle the button being clicked when there is not enough funds to purchase it.
            End If
        End If
    End Sub
    Private Sub btn9_Hover(sender As System.Object, e As System.EventArgs) Handles btnAuto9.MouseHover
        ' Dynamic tooltip text appearing if the mouse hovers over the button. The text changes with the Variables.Auto.
        ToolTip.SetToolTip(Me.btnAuto9, " | Cost: " & Variables.Auto.auto9Cost & " | Gain Per Second: " & Variables.Auto.auto9Val & " |")
    End Sub
    Private Sub tmrAmount_Tick(sender As System.Object, e As System.EventArgs) Handles tmrAmount.Tick
        If (tmrAmount.Interval = 1000 And Variables.Auto.auto1 > 0) Then     ' Checking for the timer reaching 1000 (1 second) milliseconds and if you own at least one auto clicker.
            Variables.Auto.amount = Val(Variables.Auto.amount + (Variables.Auto.auto1Val + Variables.Auto.auto1))     'The total final score amount equals the current final amount added to the product of the value of the auto clicker and the number owned.
        End If

        If (tmrAmount.Interval = 1000 And Variables.Auto.auto2 > 0) Then     ' Checking for the timer reaching 1000 (1 second) milliseconds and if you own at least one auto clicker.
            Variables.Auto.amount = Val(Variables.Auto.amount + (Variables.Auto.auto2Val + Variables.Auto.auto2))     'The total final score amount equals the current final amount added to the product of the value of the auto clicker and the number owned.
            Variables.Auto.home = Val(Variables.Auto.home + (Variables.Auto.auto2Item * Variables.Auto.auto2) + (1))
        End If

        If (tmrAmount.Interval = 1000 And Variables.Auto.auto3 > 0) Then     ' Checking for the timer reaching 1000 (1 second) milliseconds and if you own at least one auto clicker.
            Variables.Auto.amount = Val(Variables.Auto.amount + (Variables.Auto.auto3Val + Variables.Auto.auto3))     'The total final score amount equals the current final amount added to the product of the value of the auto clicker and the number owned.
            Variables.Auto.wall = Val(Variables.Auto.wall + (Variables.Auto.auto3Item * +Variables.Auto.auto3))
        End If

        If (tmrAmount.Interval = 1000 And Variables.Auto.auto4 > 0) Then     ' Checking for the timer reaching 1000 (1 second) milliseconds and if you own at least one auto clicker.
            Variables.Auto.amount = Val(Variables.Auto.amount + (Variables.Auto.auto4Val * Variables.Auto.auto4))     'The total final score amount equals the current final amount added to the product of the value of the auto clicker and the number owned.
            Variables.Auto.guard = Val(Variables.Auto.guard + (Variables.Auto.auto4Item * Variables.Auto.auto4))
        End If

        If (tmrAmount.Interval = 1000 And Variables.Auto.auto5 > 0) Then     ' Checking for the timer reaching 1000 (1 second) milliseconds and if you own at least one auto clicker.
            Variables.Auto.amount = Val(Variables.Auto.amount + (Variables.Auto.auto5Val * Variables.Auto.auto5))     'The total final score amount equals the current final amount added to the product of the value of the auto clicker and the number owned.
            'Variables.Auto.church = Val(Variables.Auto.church + (Variables.Auto.auto5Item * Variables.Auto.auto5))
        End If

        If (tmrAmount.Interval = 1000 And Variables.Auto.auto6 > 0) Then     ' Checking for the timer reaching 1000 (1 second) milliseconds and if you own at least one auto clicker.
            Variables.Auto.amount = Val(Variables.Auto.amount + (Variables.Auto.auto6Val * Variables.Auto.auto6))     'The total final score amount equals the current final amount added to the product of the value of the auto clicker and the number owned.
            Variables.Auto.shop = Val(Variables.Auto.shop + (Variables.Auto.auto6Item * Variables.Auto.auto6))
        End If

        If (tmrAmount.Interval = 1000 And Variables.Auto.auto7 > 0) Then     ' Checking for the timer reaching 1000 (1 second) milliseconds and if you own at least one auto clicker.
            Variables.Auto.amount = Val(Variables.Auto.amount + (Variables.Auto.auto7Val * Variables.Auto.auto7))     'The total final score amount equals the current final amount added to the product of the value of the auto clicker and the number owned.
            'Variables.Auto.bank = Val(Variables.Auto.bank + (Variables.Auto.auto7Item * Variables.Auto.auto7))
        End If

        If (tmrAmount.Interval = 1000 And Variables.Auto.auto8 > 0) Then     ' Checking for the timer reaching 1000 (1 second) milliseconds and if you own at least one auto clicker.
            Variables.Auto.amount = Val(Variables.Auto.amount + (Variables.Auto.auto8Val * Variables.Auto.auto8))     'The total final score amount equals the current final amount added to the product of the value of the auto clicker and the number owned.
        End If
    End Sub
    Private Sub tmrUpdate_Tick(sender As System.Object, e As System.EventArgs) Handles tmrUpdate.Tick
        ' --- Constant update function using a timer ---
        ' The timer has a max interval of 1, the if statement checks to see if the interval 
        ' is less than or equal to 1. The only two possible intervals are 0 and 1, 
        ' so every millisecond or less the function performs its tasks, 
        ' such as keeping labels updated at all times.
        If (tmrUpdate.Interval <= 1) Then
            ' Constant updating all auto clicker labels
            lblAmount.Text = Variables.Auto.amount               ' Setting the label to display your total score
            lblauto1Cost.Text = Variables.Auto.auto1Cost         ' Setting the label to display the total cost of that auto clicker
            lblAuto1N.Text = Variables.Auto.auto1                ' Setting the label to display the total amount of that auto clicker that you own
            lblAuto1Val.Text = Variables.Auto.auto1Val           ' Setting the label to display the total value (gain) amount that auto clicker gives you
            lblauto2Cost.Text = Variables.Auto.auto2Cost
            lblAuto2N.Text = Variables.Auto.auto2
            lblAuto2Val.Text = Variables.Auto.auto2Val
            lblauto3Cost.Text = Variables.Auto.auto3Cost
            lblAuto3N.Text = Variables.Auto.auto3
            lblAuto3Val.Text = Variables.Auto.auto3Val
            lblauto4Cost.Text = Variables.Auto.auto4Cost
            lblAuto4N.Text = Variables.Auto.auto4
            lblAuto4Val.Text = Variables.Auto.auto4Val
            lblauto5Cost.Text = Variables.Auto.auto5Cost
            lblAuto5N.Text = Variables.Auto.auto5
            lblAuto5Val.Text = Variables.Auto.auto5Val
            lblauto6Cost.Text = Variables.Auto.auto6Cost
            lblAuto6N.Text = Variables.Auto.auto6
            lblAuto6Val.Text = Variables.Auto.auto6Val
            lblauto7Cost.Text = Variables.Auto.auto7Cost
            lblAuto7N.Text = Variables.Auto.auto7
            lblAuto7Val.Text = Variables.Auto.auto7Val
            lblauto8Cost.Text = Variables.Auto.auto8Cost
            lblAuto8N.Text = Variables.Auto.auto8
            lblAuto8Val.Text = Variables.Auto.auto8Val
            lblauto9Cost.Text = Variables.Auto.auto9Cost
            lblAuto9N.Text = Variables.Auto.auto9
            lblAuto9Val.Text = Variables.Auto.auto9Val
            lblGamble.Text = Variables.Auto.gamble
            lblBar2Col.Text = barAuto2Col.Value
            lblFollowers.Text = Variables.Overall.followers
            
            ' --- Skills text display ---
            ' Constant updating all skill labels
            lblCivilians.Text = Variables.Auto.civ
            lblHomes.Text = Variables.Auto.home
            lblShops.Text = Variables.Auto.shop
            lblWalls.Text = Variables.Auto.wall
            lblChurch.Text = Variables.Auto.auto5
            lblBanks.Text = Variables.Auto.auto7
            lblHall.Text = Variables.Auto.auto8
            lblGuards.Text = Variables.Auto.guard

          

            ' --- Bars Stopping when maxed, disabling buttons and variables ---
            If Variables.Auto.home >= Variables.Auto.auto2Max Then      'If the variable for the item amount built, is greater than or equal to the maximum amount you can have then
                barAuto2.Enabled = False                                'The progress bar is disabled
                lblHomes.Enabled = False                                'The label for the variable of the item owned is disabled
                Variables.Auto.home = Variables.Auto.auto2Max           'Catch to make sure the variable doesn't go over the max amount, if it does, it gets reset to exactly the amount of the max
                btnAuto2.Enabled = False                               'The button is disabled and can't be clicked on
                Variables.Auto.auto2 = 1                              'The amount of the item purchased is reset to zero and locked there which in turn stops profit coming in from that item
                Variables.Auto.auto2Off = True                         'Switching the variable that turns the clicker off, to true. This is because the update function will not allow the button to be disabled without the use of this bool variable to catch another condition being met.
                tmrAuto2.Enabled = True
                'barAuto2Col.Increment(18)
                'System.Threading.Thread.VolatileRead(500)
            End If                                                      'End of if statement
            If Variables.Auto.wall >= Variables.Auto.auto3Max Then
                barAuto3.Enabled = False
                lblWalls.Enabled = False
                Variables.Auto.wall = Variables.Auto.auto3Max
                btnAuto3.Enabled = False
                Variables.Auto.auto3 = 1
                Variables.Auto.auto3Off = True
            End If
            If Variables.Auto.guard >= Variables.Auto.auto4Max Then
                barAuto4.Enabled = False
                lblGuards.Enabled = False
                Variables.Auto.guard = Variables.Auto.auto4Max
                btnAuto4.Enabled = False
                Variables.Auto.auto4 = 1
                Variables.Auto.auto4Off = True
            End If
            If Variables.Auto.auto5 >= Variables.Auto.auto5Max Then
                barAuto5.Enabled = False
                barAuto5.Value = 5
                lblChurch.Enabled = False
                Variables.Auto.church = Variables.Auto.auto5Max
                btnAuto5.Enabled = False
                Variables.Auto.auto5Off = True
            End If
            If Variables.Auto.shop >= Variables.Auto.auto6Max Then
                barAuto6.Enabled = False
                lblShops.Enabled = False
                Variables.Auto.shop = Variables.Auto.auto6Max
                btnAuto6.Enabled = False
                Variables.Auto.auto6 = 1
                Variables.Auto.auto6Off = True
            End If
            If Variables.Auto.auto7 >= Variables.Auto.auto7Max Then
                barAuto7.Enabled = False
                lblBanks.Enabled = False
                Variables.Auto.bank = Variables.Auto.auto7Max
                btnAuto7.Enabled = False
                Variables.Auto.auto7Off = True
            End If
            If Variables.Auto.auto8 >= 1 Then
                'barAuto8.Enabled = False
                lblHall.Enabled = False
                Variables.Auto.auto8 = 1
                btnAuto8.Enabled = False
                Variables.Auto.auto8Off = True
            End If

            ' --- Bars ---
            ' The bar progression is linked to the variable value of how many of the item has been "built"
            barAuto2.Value = Variables.Auto.home
            barAuto3.Value = Variables.Auto.wall
            barAuto4.Value = Variables.Auto.guard
            barAuto5.Value = Variables.Auto.auto5
            barAuto6.Value = Variables.Auto.shop
            barAuto7.Value = Variables.Auto.auto7
            barAuto8.Value = Variables.Auto.auto8

          
            ' --- Button-enabling check ---
            ' Constant check for the conditions to be met to enable the next auto clicker button in order
            If (Variables.Auto.amount >= Variables.Auto.auto1Cost) Then       ' If your total score is higher or equal to the cost of the first auto clicker, then 
                btnAuto1.Enabled = True                             ' The first auto clicker button becomes enabled to click on and use
            Else : btnAuto1.Enabled = False                         ' If that absolute condition is not met then the button remains disabled and can't be used.
            End If                                                  ' End of if statement

            If Val(Variables.Auto.auto1Bought = True And (Variables.Auto.amount) >= (Variables.Auto.auto2Cost) And Variables.Auto.auto2Off = False) Then     'If you own at least one or more of the second auto clicker, and your total score is equal to or greater than the cost of the third auto clicker then
                btnAuto2.Enabled = True             ' The auto clicker button becomes enabled to click on and use
            Else : btnAuto2.Enabled = False         ' If that absolute condition is not met then the button remains disabled and can't be used.
            End If                                  ' End of if statement

            If Val((Variables.Auto.auto2Bought = True And (Variables.Auto.amount) >= (Variables.Auto.auto3Cost) And Variables.Auto.auto3Off = False)) Then     'If you own at least one or more of the second auto clicker, and your total score is equal to or greater than the cost of the third auto clicker then
                btnAuto3.Enabled = True             ' The auto clicker button becomes enabled to click on and use
            Else : btnAuto3.Enabled = False         ' If that absolute condition is not met then the button remains disabled and can't be used.
            End If                                  ' End of if statement

            If Val((Variables.Auto.auto3Bought = True And (Variables.Auto.amount) >= (Variables.Auto.auto4Cost) And Variables.Auto.auto4Off = False)) Then
                btnAuto4.Enabled = True
            Else : btnAuto4.Enabled = False
            End If

            If Val((Variables.Auto.auto4Bought = True And (Variables.Auto.amount) >= (Variables.Auto.auto5Cost) And Variables.Auto.auto5Off = False)) Then
                btnAuto5.Enabled = True
            Else : btnAuto5.Enabled = False
            End If

            If Val((Variables.Auto.auto5Bought = True And (Variables.Auto.amount) >= (Variables.Auto.auto6Cost) And Variables.Auto.auto6Off = False)) Then
                btnAuto6.Enabled = True
            Else : btnAuto6.Enabled = False
            End If

            If Val((Variables.Auto.auto6Bought = True And (Variables.Auto.amount) >= (Variables.Auto.auto7Cost) And Variables.Auto.auto7Off = False)) Then
                btnAuto7.Enabled = True
            Else : btnAuto7.Enabled = False
            End If

            If Val((Variables.Auto.auto7Bought = True And (Variables.Auto.amount) >= (Variables.Auto.auto8Cost) And Variables.Auto.auto8Off = False)) Then
                btnAuto8.Enabled = True
            Else : btnAuto8.Enabled = False
            End If

            If Val((Variables.Auto.auto8Bought = True And (Variables.Auto.amount) >= (Variables.Auto.auto9Cost) And Variables.Auto.auto9Off = False)) Then
                btnAuto9.Enabled = True
            Else : btnAuto9.Enabled = False
            End If

            If Variables.Auto.auto2Off And Variables.Auto.auto3Off And Variables.Auto.auto4Off And Variables.Auto.auto5Off And Variables.Auto.auto6Off And Variables.Auto.auto7Off And Variables.Auto.auto8Off Then
                btnDone.Enabled = True
            End If

            If Variables.Auto.amount >= Variables.Auto.up1Cost Then
                btnUp1.Enabled = True
                Else : btnUp1.Enabled = False
            End If
            If Variables.Auto.amount >= Variables.Auto.up2Cost And Variables.Auto.up1On Then
                btnUp2.Enabled = True
            Else : btnUp2.Enabled = False
            End If
            If Variables.Auto.amount >= Variables.Auto.up3Cost And Variables.Auto.up2On Then
                btnUp3.Enabled = True
            Else : btnUp3.Enabled = False
            End If
        End If
    End Sub
    Private Sub btnCheat_Click(sender As System.Object, e As System.EventArgs) Handles btnCheat.Click
        ' --- Development cheat box ---
        ' Allows to quickly gain any desired amount of score to check parts of the game
        Variables.Auto.amount = Val(Variables.Auto.amount) + (txtCheat.Text)          ' Adds the number you entered in the textbox to the total score variable
    End Sub
    'Public Event KeyDown As KeyEventHandler
    Public Sub frmIdle_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

    End Sub
    Private Sub btnDone_Click(sender As System.Object, e As System.EventArgs) Handles btnDone.Click
        frmChoice.Show()
    End Sub
    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Variables.Overall.fileNumber = FreeFile()
        FileOpen(Variables.Overall.fileNumber, "TEST.TXT", OpenMode.Output)
        PrintLine(Variables.Overall.fileNumber, Variables.Auto.amount)
        FileClose(Variables.Overall.fileNumber)
    End Sub

    Private Sub btnLd_Click(sender As System.Object, e As System.EventArgs) Handles btnLd.Click
        Variables.Overall.fileNumber = FreeFile()
        FileOpen(Variables.Overall.fileNumber, "TEST.TXT", OpenMode.Input)
        Input(Variables.Overall.fileNumber, Variables.Auto.amount)
        FileClose(Variables.Overall.fileNumber)
    End Sub

    Private Sub btnClick_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles btnClick.KeyDown
           Select e.KeyCode
            Case Keys.F1
                txtCheat.Select()
                txtCheat.Enabled = True
                txtCheat.Visible = True
                btnCheat.Enabled = True
                btnCheat.Visible = True
            Case Keys.Oemtilde
                DevConsole2.Show()
                Me.Close()
        End Select
    End Sub

    Private Sub tmrAuto2_Tick(sender As System.Object, e As System.EventArgs) Handles tmrAuto2.Tick
        If tmrAuto2.Interval = 5000 Then
            btnAuto2.Text = "Collect"
            Variables.Auto.auto2Col = True
            btnAuto2.Enabled = True
            Variables.Auto.auto2Off = False
        End If
    End Sub

    Private Sub btnUp1_Click(sender As System.Object, e As System.EventArgs) Handles btnUp1.Click
        Variables.Auto.up1On = True
        btnUp1.Visible = False
        Variables.Auto.amount += -(Variables.Auto.up1Cost)
    End Sub
    Private Sub btnUp1_Hover(sender As System.Object, e As System.EventArgs) Handles btnUp1.MouseHover
        ' Dynamic tooltip text appearing if the mouse hovers over the button. The text changes with the Variables.
        ToolTip.SetToolTip(Me.btnUp1, "Heal civilian wounds | Cost: " & Variables.Auto.up1Cost & " | Gain Per Click: " & Variables.Auto.up1Val & " |")
    End Sub

    Private Sub btnUp2_Click(sender As System.Object, e As System.EventArgs) Handles btnUp2.Click
        Variables.Auto.up2On = True
        Variables.Auto.up1On = False
        btnUp2.Visible = False
        Variables.Auto.amount += -(Variables.Auto.up2Cost)
    End Sub
    Private Sub btnUp2_Hover(sender As System.Object, e As System.EventArgs) Handles btnUp2.MouseHover
        ' Dynamic tooltip text appearing if the mouse hovers over the button. The text changes with the Variables.
        ToolTip.SetToolTip(Me.btnUp2, " | Cost: " & Variables.Auto.up2Cost & " | Gain Per Click: " & Variables.Auto.up2Val & " |")
    End Sub

    Private Sub btnUp3_Click(sender As System.Object, e As System.EventArgs) Handles btnUp3.Click
        Variables.Auto.up3On = True
        Variables.Auto.up2On = False
        btnUp3.Visible = False
        Variables.Auto.amount += -(Variables.Auto.up3Cost)
    End Sub
    Private Sub btnUp3_Hover(sender As System.Object, e As System.EventArgs) Handles btnUp3.MouseHover
        ' Dynamic tooltip text appearing if the mouse hovers over the button. The text changes with the Variables.
        ToolTip.SetToolTip(Me.btnUp3, " | Cost: " & Variables.Auto.up3Cost & " | Gain Per Click: " & Variables.Auto.up3Val & " |")
    End Sub

    Private Sub lblCity1_Click(sender As Object, e As EventArgs) Handles lblCity1.Click

    End Sub

    Private Sub tabRebuild_Click(sender As Object, e As EventArgs) Handles tabRebuild.Click

    End Sub
End Class
