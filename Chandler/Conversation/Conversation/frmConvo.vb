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
        End Select
    End Sub
    Private Sub btnAction1_Click(sender As Object, e As EventArgs) Handles btnAction1.Click
        Dim answer As String

        Select Case Variables.Convo.Type
            Case 1
                Select Case Variables.Overall.charTag
                    Case "a"
                        answer = "Hey, my name is " & Variables.Convo.NPCName & "."
                    Case "b"
                        answer = "You're the one they all keep talking about..."
                    Case "c"
                        answer = "What are you lookin' at?"
                End Select

            Case 2
                Select Case Variables.Overall.charTag
                    Case "a"
                        answer = "Talk cannot save you."
                    Case "b"
                        answer = "You will die here."
                    Case "c"
                        answer = "Where are your followers to save you now?"
                End Select

            Case 3
                Select Case Variables.Overall.charTag
                    Case "a"
                        answer = "Who are you?"
                    Case "b"
                        answer = "I have nothing to say to you."
                End Select

            Case 4
                Select Case Variables.Overall.charTag
                    Case "a"
                        answer = "You gonna buy something or what?"
                    Case "b"
                        answer = "I don't have all day..."
                End Select
        End Select

        rtxtNPC.Text = answer
    End Sub

    Private Sub btnAction2_Click(sender As Object, e As EventArgs) Handles btnAction2.Click
        Dim answer As String
        Dim trade As Boolean
        Dim canTrade As Boolean = False

        Select Case Variables.Convo.Type
            Case 2
                Select Case Variables.Overall.charTag
                    Case "a"
                        answer = "You don't scare me, " & Variables.Overall.name & "."
                    Case "b"
                        answer = "Don't kill me."
                    Case "c"
                        answer = "Hahahaha"
                End Select

            Case 3
                If canTrade = False Then
                    trade = Variables.Functions.lowChance()
                    Select Case trade
                        Case True
                            canTrade = True
                            tmrPause1.Enabled = True
                            Select Case Variables.Overall.charTag
                                Case "a"
                                    answer = "I do actually have a few things..."
                                Case "b"
                                    answer = "I'll show you what I got, but this isn't a charity."
                                Case "c"
                                    answer = "I think I have some things you might be interested in."
                            End Select
                        Case False
                            btnAction2.Enabled = False
                            Select Case Variables.Overall.charTag
                                Case "a"
                                    answer = "Do I look like I'm running a store here?"
                                Case "b"
                                    answer = "I have nothing to offer someone like you."
                                Case "c"
                                    answer = "I don't have anything to trade."
                            End Select
                    End Select


                ElseIf canTrade = True Then
                    frmConvo.trade()
                    End If

                    Case 4
                Select Case Variables.Overall.charTag
                    Case "a"
                        answer = "You gonna buy something or what?"
                    Case "b"
                        answer = "I don't have all day..."
                End Select
        End Select

        rtxtNPC.Text = answer
    End Sub

    Private Sub btnAction3_Click(sender As Object, e As EventArgs) Handles btnAction3.Click
        Dim answer As String

        Select Case Variables.Convo.Type
            Case 1
                frmConvo.follow()

            Case 2
                tmrPause2.Enabled = True
                btnAction1.Enabled = False
                btnAction2.Enabled = False
                btnAction3.Enabled = False
                btnAction6.Enabled = False
                Select Case Variables.Overall.charTag
                    Case "a"
                        answer = "Time to die."
                    Case "b"
                        answer = "I will crush you."
                    Case "c"
                        answer = "Nobody will save you now."
                End Select

            Case 3
                frmConvo.follow()

            Case 4
                Select Case Variables.Overall.charTag
                    Case "a"
                        answer = "You gonna buy something or what?"
                    Case "b"
                        answer = "I don't have all day..."
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
        End If
    End Sub

    Private Sub tmrPause_Tick(sender As Object, e As EventArgs) Handles tmrPause2.Tick
        If tmrPause2.Interval = 2000 Then
            MessageBox.Show("Fight.", "Popup", MessageBoxButtons.OK, MessageBoxIcon.Information)     'Error message to handle no save file
            'frmBattle.Show()
            tmrPause2.Enabled = False
        End If
    End Sub

    Private Sub tmrPause1_Tick(sender As Object, e As EventArgs) Handles tmrPause1.Tick
        If tmrPause1.Interval = 1000 Then
            MessageBox.Show("Trade.", "Trade", MessageBoxButtons.OK, MessageBoxIcon.Information)     'Error message to handle no save file
            tmrPause1.Enabled = False
        End If
    End Sub

    Public Shared Function trade() As Integer
        Dim answer As String = ""
        frmConvo.tmrPause1.Enabled = True
        Select Case Variables.Overall.charTag
            Case "a"
                answer = "I do actually have a few things..."
            Case "b"
                answer = "I'll show you what I got, but this isn't a charity."
            Case "c"
                answer = "I think I have some things you might be interested in."
        End Select

        frmConvo.rtxtNPC.Text = answer
        Return 0
    End Function

    Public Shared Function follow() As Integer
        Dim answer As String = ""
        Dim recruit As Boolean
        recruit = Variables.Functions.fairChance()
        frmConvo.btnAction3.Enabled = False
        frmConvo.lblFollowers.Visible = True

        Select Case recruit
            Case True
                frmConvo.btnAction4.Enabled = False
                Variables.Overall.followers += 1
                Select Case Variables.Overall.charTag
                    Case "a"
                        answer = "Sure, I'll join you."
                    Case "b"
                        answer = "I don't like you, but I respect you... count me in."
                    Case "c"
                        answer = "Let's get to work."
                End Select
            Case False
                Select Case Variables.Overall.charTag
                    Case "a"
                        answer = "I won't join you."
                    Case "b"
                        answer = "I'll never join you!"
                    Case "c"
                        answer = "I have other things to worry about right now."
                End Select
        End Select

        frmConvo.rtxtNPC.Text = answer
        Return 0
    End Function
End Class
