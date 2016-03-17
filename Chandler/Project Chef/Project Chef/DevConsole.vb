Public Class DevConsole

    Private Sub btnLoad_Click(sender As System.Object, e As System.EventArgs) Handles btnLoad.Click
        If Variables.Movement.townSize = 1 Then
            frmIdle.Show()
            Me.Close()
        ElseIf Variables.Movement.townSize = 2 Then
            frmIdle.Show()
            Me.Close()
        ElseIf Variables.Movement.townSize = 3 Then
            frmIdle.Show()
            Me.Close()
        Else : MessageBox.Show("You must set the city size to 1, 2, or 3.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnEnd_Click(sender As System.Object, e As System.EventArgs) Handles btnEnd.Click
        End
    End Sub

    Private Sub DevConsole_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSet_Click(sender As System.Object, e As System.EventArgs) Handles btnSet.Click
        Variables.Movement.townSize = cmboSize.Text
    End Sub

    Private Sub txtSet_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkComplete.CheckedChanged
        If chkComplete.Checked Then
            frmIdle.btnDone.Enabled = True
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles chkRecruit.CheckedChanged
        'Variables.Auto.amount = 10000000000
        'frmIdle.btnAuto9.Enabled = True
    End Sub
End Class