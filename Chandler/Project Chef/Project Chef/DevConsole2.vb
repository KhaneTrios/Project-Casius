Public Class DevConsole2

    Private Sub btnLoad_Click(sender As System.Object, e As System.EventArgs) Handles btnLoad.Click
        Select Case Variables.Movement.townSize
            Case 1, 2, 3
                frmIdle.Show()
                Me.Close()
            Case Else
                MessageBox.Show("You must set the city size to 1, 2, or 3.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub

    Private Sub btnEnd_Click(sender As System.Object, e As System.EventArgs) Handles btnEnd.Click
        End
    End Sub

    Private Sub btnSet_Click(sender As System.Object, e As System.EventArgs) Handles btnSet.Click
        Variables.Movement.townSize = cmboSize.Text
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkComplete.CheckedChanged
        If chkComplete.Checked Then
            frmIdle.btnDone.Enabled = True
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles chkRecruit.CheckedChanged
        If chkRecruit.Checked Then

        End If
    End Sub
End Class