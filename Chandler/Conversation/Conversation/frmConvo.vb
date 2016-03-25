Public Class frmConvo
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btn5Ok.Click

    End Sub

    Private Sub frmConvo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case Variables.Convo.Type
            Case 1
                grp1.Visible = True
            Case 2
                grp2.Visible = True
            Case 3
                grp3.Visible = True
            Case 4
                grp4.Visible = True
            Case 5
                grp5.Visible = True
        End Select
    End Sub
End Class
