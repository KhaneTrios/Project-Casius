Public Class mainMenu
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        begin.Show()
    End Sub

    Private Sub mainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Variables.Fight.charWarr = True Then
            className.Text = "Warrior"
        End If
        If Variables.Fight.charTact = True Then
            className.Text = "Tactician"
        End If
        If Variables.Fight.charMage = True Then
            className.Text = "Mage"
        End If
        If Variables.Fight.charRogu = True Then
            className.Text = "Rogue"
        End If
        If Variables.Fight.charUnbo = True Then
            className.Text = "Unborn"
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Fight.Show()
    End Sub
End Class