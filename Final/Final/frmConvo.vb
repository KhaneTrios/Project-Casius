Public Class frmConvo

    Private Sub frmConvo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNPCName.Text = Variables.Convo.NPCName

        Select Case Variables.Convo.Type
            Case 1
                btnAction1.Text = "Talk"
                btnAction2.Visible = False
                btnAction3.Text = "Recruit"
                btnAction4.Visible = False
                btnAction5.Visible = False
                btnAction6.Text = "Leave"
                lblFollowers.Visible = True
            Case 2
                btnAction1.Text = "Reason"
                btnAction2.Text = "Intimidate"
                btnAction3.Text = "Fight"
                btnAction4.Visible = False
                btnAction5.Visible = False
                btnAction6.Text = "Leave"
            Case 3
                btnAction1.Text = "Talk"
                btnAction2.Text = "Attempt Trade"
                btnAction3.Text = "Recruit"
                btnAction4.Text = "Fight"
                btnAction5.Visible = False
                btnAction6.Text = "Leave"
            Case 4
                btnAction1.Text = "Talk"
                btnAction2.Text = "Haggle Prices"
                btnAction3.Text = "Buy"
                btnAction4.Text = "Sell"
                btnAction5.Visible = False
                btnAction6.Text = "Leave"
                lblMoney.Visible = True
            Case 5
                btnAction1.Visible = False
                btnAction2.Visible = False
                btnAction3.Text = "OK"
                btnAction4.Visible = False
                btnAction5.Visible = False
                btnAction6.Visible = False
                btnAction6.Text = "Leave"
        End Select
    End Sub
    Private Sub btnAction1_Click(sender As Object, e As EventArgs) Handles btnAction1.Click
        Dim answer As String

        Select Case Variables.Convo.Type
            Case 1
                Select Case Variables.Convo.charTag
                    Case "a"
                        answer = "Hey, my name is " & Variables.Convo.NPCName & "."
                    Case "b"
                        answer = "You're the one they all keep talking about..."
                    Case "c"
                        answer = "What are you lookin' at?"
                End Select

            Case 2
                Select Case Variables.Convo.charTag
                    Case "a"
                        answer = "Talk cannot save you."
                    Case "b"
                        answer = "You will die here."
                    Case "c"
                        answer = "Where are your followers to save you now?"
                End Select

            Case 3
                Select Case Variables.Convo.charTag
                    Case "a"
                        answer = "Who are you?"
                    Case "b"
                        answer = "I have nothing to say to you."
                    Case "c"
                        answer = "I thought you would be passing through here."
                End Select

            Case 4
                Select Case Variables.Convo.charTag
                    Case "a"
                        answer = "An adventurer like you needs some good gear to go with him."
                    Case "b"
                        answer = "I don't have all day..."
                    Case "c"
                        answer = "Beautiful day to purchase marvelous wares at my shop eh?"
                End Select
        End Select

        rtxtNPC.Text = answer
    End Sub

    Private Sub btnAction2_Click(sender As Object, e As EventArgs) Handles btnAction2.Click
        Dim answer As String
        Dim trade As Boolean

        Select Case Variables.Convo.Type
            Case 2
                Variables.Convo.intimidate = Variables.Functions.lowChance()
                Select Case Variables.Convo.intimidate
                    Case True
                        Select Case Variables.Convo.charTag
                            Case "a"
                                answer = "You don't scare me, " & Variables.Overall.name & "."
                            Case "b"
                                answer = "Don't kill me."
                            Case "c"
                                answer = "Hahahaha"
                        End Select
                End Select

            Case 3
                If Variables.Convo.canTrade = True Then
                    answer = frmConvo.trade()
                End If

                If Variables.Convo.canTrade = False Then
                    trade = Variables.Functions.lowChance()
                    Select Case trade
                        Case True
                            answer = frmConvo.trade()
                        Case False
                            Variables.Convo.canTrade = False
                            btnAction2.Enabled = False
                            Select Case Variables.Convo.charTag
                                Case "a"
                                    answer = "Do I look like I'm running a store here?"
                                Case "b"
                                    answer = "I have nothing to offer someone like you."
                                Case "c"
                                    answer = "I don't have anything to trade."
                            End Select
                    End Select
                End If

            Case 4
                Variables.Convo.haggle = Variables.Functions.lowChance
                Select Case Variables.Convo.haggle
                    Case True
                        Select Case Variables.Convo.charTag
                            Case "a"
                                answer = "Haha sure, you look like you could use a break!"
                            Case "b"
                                answer = "Heh, reminds me of myself was I was first starting out. I'll cut you some slack."
                            Case "c"
                                answer = "Maybe my prices are a bit steep... I'll give you a bit of a discount."
                        End Select
                    Case False
                        Select Case Variables.Convo.charTag
                            Case "a"
                                answer = "Yeah... I can't do that... sorry."
                            Case "b"
                                answer = "I don't think so, cheapskate."
                            Case "c"
                                answer = "I have a family to feed sir. I can't afford to reduce my prices."
                        End Select
                End Select
        End Select

        rtxtNPC.Text = answer
    End Sub

    Private Sub btnAction3_Click(sender As Object, e As EventArgs) Handles btnAction3.Click
        Dim answer As String

        Select Case Variables.Convo.Type
            Case 1
                answer = follow()

            Case 2
                tmrPause2.Enabled = True
                btnAction1.Enabled = False
                btnAction2.Enabled = False
                btnAction3.Enabled = False
                btnAction6.Enabled = False
                Select Case Variables.Convo.charTag
                    Case "a"
                        answer = "Time to die."
                    Case "b"
                        answer = "I will crush you."
                    Case "c"
                        answer = "Nobody will save you now."
                End Select

            Case 3
                answer = follow()

            Case 4
                tmrPause1.Enabled = True
                Select Case Variables.Convo.charTag
                    Case "a"
                        answer = "Oooh what would you like to purchase today?"
                    Case "b"
                        answer = "I hope you're not just window shopping..."
                    Case "c"
                        answer = "I have so many wonderful items to show you!"
                End Select


            Case 5
                Variables.Convo.counter += 1
                Select Case Variables.Convo.charTag
                    Case "a1"
                        Select Case Variables.Convo.counter
                            Case 1
                                answer = "Greetings, confused one, I am your guide!"
                            Case 2
                                answer = "What? Who am I? Well I am an old Sage. I have seen adventurers like you come through here before."
                            Case 3
                                answer = "Many of them have perished in these harsh lands, and I simply can't stand to see it happen again."
                            Case 4
                                answer = "These lands need a hero who can save us all from the doom that plagues us."
                            Case 5
                                answer = "What doom? The doom currently attacking that nearby town over there!"
                            Case 6
                                answer = "ME?! I'M not saving them because I'M an old man! You're the hero here!"
                            Case 7
                                answer = "Look, I'll explain more later but for now I suggest you go save that town and everyone in it. Unless you're a terrible person?"
                                btnAction3.Enabled = False
                                btnAction6.Visible = True
                        End Select
                    Case "a2"
                        Select Case Variables.Convo.counter
                            Case 1
                                answer = "Good work hero, you saved that village!"
                            Case 2
                                answer = "Now that you have saved the village let me finish what I was saying."
                            Case 3
                                answer = "This kingdom is in great danger and YOU have to save it."
                            Case 4
                                answer = "In order to be prepared to stop them you must aquire the proper resources."
                            Case 5
                                answer = "You'll need Frill to buy proper gear to take them on and you'll need gold bars to build defenses and fortifications."
                            Case 6
                                answer = "You can get gold from your adventures around the land, finding it in dungeons and chests and even some merchants."
                            Case 7
                                answer = "The thing is... gold is pretty scarce... Most towns and cities already have found and mined most of the gold around here."
                            Case 8
                                answer = "Time is of the essance hero, if we are to save the kingdom we will need all of the resources we can get, fast."
                            Case 9
                                answer = "If we don't hurry the entire kingdom will be engulfed by this terrible doom lurking around the corner."
                            Case 10
                                answer = "If we are to successfully ward off this threat, there is going to have to be sacrifices..."
                            Case 11
                                answer = "Gold is our ticket to being strong enought to fend off our attackers... and all the towns control most of the Gold supply."
                            Case 12
                                answer = "Along the way you will encounter more besiged cities, and once you gain access to them and they trust you, you can get at their Gold supply."
                            Case 13
                                answer = "You can use this to your advantage, pillage the city and leave it crippled to gain its gold so you can save the entire kingdom."
                            Case 14
                                answer = "Or you can leave the cities as they are and try to scrounge up as much resources as you can in hopes of having enough to save everyone, including yourself."
                            Case 15
                                answer = "It's hard, I know, but they is no victory without sacrifice."
                            Case 16
                                answer = "We are running out of time however, you must go now and complete your quest. Save the kingdom hero, save us all!"
                                btnAction3.Enabled = False
                                btnAction6.Visible = True
                        End Select
                    Case "b"
                        Select Case Variables.Convo.counter
                            Case 1
                                answer = "YOU ARE THE HUMAN WHO HAS BEEN THWARTING OUR PLANS!"
                            Case 2
                                answer = "YOU HAVE BEEN A THORN IN MY SIDE SINCE YOU HAVE ARRIVED HERE."
                            Case 3
                                answer = "IT IS TIME FOR ME TO END YOU, NUISANCE."
                                btnAction3.Enabled = False
                                tmrPause2.Enabled = True
                        End Select
                End Select
        End Select

        rtxtNPC.Text = answer
    End Sub

    Private Sub picChar_Click(sender As Object, e As EventArgs) Handles picChar.Click

    End Sub

    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click

    End Sub

    Private Sub grpInteract_Enter(sender As Object, e As EventArgs) Handles grpInteract.Enter

    End Sub

    Private Sub tmrUpdate_Tick(sender As Object, e As EventArgs) Handles tmrUpdate.Tick
        If tmrUpdate.Interval <= 1 Then
            lblMoney.Text = "Frill: " & Variables.Convo.money
            lblFollowers.Text = "Followers: " & Variables.Overall.followers
            lblCounter.Text = Variables.Convo.counter
        End If
    End Sub

    Private Sub tmrPause_Tick(sender As Object, e As EventArgs) Handles tmrPause2.Tick
        If tmrPause2.Interval = 2000 Then
            MessageBox.Show("Fight.", "Popup", MessageBoxButtons.OK, MessageBoxIcon.Information)     'Error message to handle no save file
            'frmBattle.Show()
            'Me.Close()
            tmrPause2.Enabled = False
        End If
    End Sub

    Private Sub tmrPause1_Tick(sender As Object, e As EventArgs) Handles tmrPause1.Tick
        If tmrPause1.Interval = 1000 Then
            frmTrade.Show()
            tmrPause1.Enabled = False
        End If
    End Sub

    Public Shared Function trade() As String
        Dim answer As String = ""
        frmConvo.tmrPause1.Enabled = True
        Variables.Convo.canTrade = True

        Select Case Variables.Convo.charTag
            Case "a"
                answer = "I do actually have a few things..."
            Case "b"
                answer = "I'll show you what I got, but this isn't a charity."
            Case "c"
                answer = "I think I have some things you might be interested in."
        End Select

        frmConvo.rtxtNPC.Text = answer
        Return answer
    End Function

    Public Shared Function follow() As String
        Dim answer As String = ""
        Dim recruit As Boolean
        recruit = Variables.Functions.fairChance()
        frmConvo.btnAction3.Enabled = False
        frmConvo.lblFollowers.Visible = True

        Select Case recruit
            Case True
                frmConvo.btnAction4.Enabled = False
                Variables.Overall.followers += 1
                Select Case Variables.Convo.charTag
                    Case "a"
                        answer = "Sure, I'll join you."
                    Case "b"
                        answer = "I don't like you, but I respect you... count me in."
                    Case "c"
                        answer = "Let's get to work."
                End Select
            Case False
                Select Case Variables.Convo.charTag
                    Case "a"
                        answer = "I won't join you."
                    Case "b"
                        answer = "I'll never join you!"
                    Case "c"
                        answer = "I have other things to worry about right now."
                End Select
        End Select

        frmConvo.rtxtNPC.Text = answer
        Return answer
    End Function

    Public Shared Function leave() As String
        Dim answer As String

        frmConvo.tmrPause2.Enabled = True
        Select Case Variables.Convo.charTag
            Case "a"
                answer = "Seeya!"
            Case "b"
                answer = "Yeah, whatever."
            Case "c"
                answer = "Nice talking to you."
        End Select

        'frmMove.Show()
        frmConvo.Close()

        Return answer
    End Function

    Private Sub btnAction4_Click(sender As Object, e As EventArgs) Handles btnAction4.Click
        Dim answer As String

        Select Case Variables.Convo.Type
            Case 3
                tmrPause2.Enabled = True
                Select Case Variables.Convo.charTag
                    Case "a"
                        answer = "Don't make me hurt you"
                    Case "b"
                        answer = "Fool!"
                    Case "c"
                        answer = "I won't let you push me around!"

                End Select
            Case 4
                Select Case Variables.Convo.charTag
                    Case "a"
                        answer = "Let's see what ya got."
                    Case "b"
                        answer = "Better be worth my while."
                    Case "c"
                        answer = "I have Frill to invest in some fine wares."
                End Select
        End Select

        rtxtNPC.Text = answer
    End Sub

    Private Sub btnAction6_Click(sender As Object, e As EventArgs) Handles btnAction6.Click
        leave()
    End Sub
End Class
