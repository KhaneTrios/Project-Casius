Public Class frmFollowers
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblSucFail2.Click

    End Sub

    Private Sub frmFollowers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.StartPosition = 0
        Me.Top = frmIdle.Top + 150
        Me.Left = frmIdle.Left + frmIdle.Width - Me.Width - 175

        Select Case Variables.Auto.gamble
            Case 5, 4
                lblSucFail2.Text = "You have successfully recruited followers!"
                lblFollowers2.Text = ("You have " & Variables.Overall.followers & " followers.")
            Case 3, 2, 1
                lblSucFail2.Text = "You have failed to recruit followers..."
                lblFollowers2.Text = ("You have " & Variables.Overall.followers & " followers.")
        End Select
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Me.Close()
    End Sub
End Class