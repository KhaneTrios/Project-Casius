Public Class Start

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub heroname_TextChanged(sender As System.Object, e As System.EventArgs) Handles heroname.TextChanged
        Start.Variable.asdfmod = heroname.Text
    End Sub
    Public Class Variable
        Public Shared asdfmod As String
    End Class

    Private Sub Start_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MessageBox.Show("A FRIENDLY FIRE GAME-PROJECT", "Project Casius")
    End Sub
End Class