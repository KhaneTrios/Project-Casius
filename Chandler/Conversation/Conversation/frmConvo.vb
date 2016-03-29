Public Class frmConvo

    Private Sub frmConvo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNPCName.Text = Variables.Convo.NPCName
        lblMoney.Text = "Frill: " & Variables.Convo.money

        Select Case Variables.Convo.Type
            Case 1
                btnAction1.Text = "Talk"
                btnAction2.Visible = False
                btnAction3.Text = "Recruit"
                btnAction4.Visible = False
                btnAction5.Visible = False
                btnAction6.Text = "Leave"
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
                        answer = "Thank you for saving us!"
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
                Select Case Variables.Overall.charTag
                    Case "a"
                        answer = "Do I look like I'm running a store here?"
                    Case "b"
                        answer = "I don't have anything to trade."
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

    Private Sub picChar_Click(sender As Object, e As EventArgs) Handles picChar.Click

    End Sub
End Class
