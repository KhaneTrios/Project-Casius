Public Class DevConsole

    Private Sub btnLoad_Click(sender As System.Object, e As System.EventArgs) Handles btnLoad.Click
        Select Case Variables.Convo.Type
            Case 1, 2, 3, 4, 5
                frmConvo.Show()
                Me.Close()
            Case Else
                MessageBox.Show("You must set the city size to 1, 2, 3, 4, or 5.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub

    Private Sub btnEnd_Click(sender As System.Object, e As System.EventArgs) Handles btnEnd.Click
        End
    End Sub

    Private Sub DevConsole_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSet_Click(sender As System.Object, e As System.EventArgs) Handles btnSet.Click
        Variables.Convo.Type = cmboType.Text
    End Sub

    Private Sub txtSet_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkComplete.CheckedChanged

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles chkRecruit.CheckedChanged

    End Sub

    Private Sub cmboSize_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmboType.SelectedIndexChanged

    End Sub
End Class