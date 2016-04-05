Public Class youWin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub youWin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Variables.Fight.exptimerStop = True
        'expBar.Value = Label2.Text

        'Variables.Fight.playerXP = 1000
        'expBar.Increment = expBar.Value + 50

    End Sub

    Private Sub Updater_Tick(sender As Object, e As EventArgs) Handles Updater.Tick


        Label2.Text = Variables.Fight.playerXP
        If Variables.Fight.exptimerStop = True Then
            Variables.Fight.playerXP += 50
        End If
        If Variables.Fight.playerXP = 50 Then
            Updater.Enabled = False
        End If



    End Sub
End Class