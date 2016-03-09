Public Class Start

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Form1.Show()
    End Sub

    Private Sub heroname_TextChanged(sender As System.Object, e As System.EventArgs) Handles heroname.TextChanged
        Start.Variable.asdfmod = heroname.Text
    End Sub
    Public Class Variable
        Public Shared asdfmod As String
    End Class
End Class