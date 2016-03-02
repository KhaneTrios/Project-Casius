Public Class Fight

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Fight_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Label1.Text = ProgressBar1.Value
        Label4.Text = ProgressBar2.Value
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        ProgressBar2.Value = ProgressBar2.Value - 5
        Label1.Text = ProgressBar1.Value
        Label4.Text = ProgressBar2.Value
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        ProgressBar1.Value = ProgressBar1.Value - 5
        Label1.Text = ProgressBar1.Value
        Label4.Text = ProgressBar2.Value
    End Sub
End Class