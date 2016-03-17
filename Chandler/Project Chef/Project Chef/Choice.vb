Public Class frmChoice

    Private Sub btnDestroy_Click(sender As System.Object, e As System.EventArgs) Handles btnDestroy.Click
        MessageBox.Show("Are you sure? This will kill all residents and completely destroy the city.", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmChoice_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.StartPosition = 0
        Me.Top = frmIdle.Top + 150
        Me.Left = frmIdle.Left + frmIdle.Width - Me.Width - 175
    End Sub

    Private Sub btnLeave_Click(sender As Object, e As EventArgs) Handles btnLeave.Click
        Me.Close()
        frmIdle.Close()
        ' ok
    End Sub
End Class