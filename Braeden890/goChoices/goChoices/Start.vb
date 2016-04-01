Public Class Start

    Private Property TextBox As String

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub heroname_TextChanged(sender As System.Object, e As System.EventArgs) Handles heroname.TextChanged
        Variables.Fight.asdfmod = heroname.Text
    End Sub
    Private Sub Start_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MessageBox.Show("A FRIENDLY FIRE GAME-PROJECT", "Project Casius")
        MessageBox.Show("Please enter a character name before you proceed with your adventure!", "Reminder!")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("This game was created in an attempt to push ourselvs as programmers, friends, and game designers. We thank anyone who decides to give Project Casius a try and truly appreciate the patience of our testers with all of the bugs. To everyone who had a hand in helping make this game a reality, we thank you. This project was created by 4 friends and proves that the sky is the limit.", "A special thanks from Friendly Fire")
    End Sub
End Class