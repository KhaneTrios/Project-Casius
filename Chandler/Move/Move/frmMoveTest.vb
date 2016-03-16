Public Class frmMoveTest
    Dim collision As Boolean = False
    Private Sub Form1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                picAvatar.Top = picAvatar.Top - 5
            Case Keys.Down
                picAvatar.Top = picAvatar.Top + 5
            Case Keys.Left
                picAvatar.Left = picAvatar.Left - picAvatar.Width + picAvatar.Width - 5
            Case Keys.Right
                picAvatar.Left = picAvatar.Left - picAvatar.Width + picAvatar.Width + 5
        End Select
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub


    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles picTrigger.Click

    End Sub

    Private Sub tmrUpdate_Tick(sender As System.Object, e As System.EventArgs) Handles tmrUpdate.Tick
        If tmrUpdate.Interval <= 1 Then
            If picAvatar.Location = picTrigger.Location Then
                MessageBox.Show("The city is not strong enough.", "No", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            For Each PictureBox In Me.Controls
                If PictureBox IsNot picAvatar AndAlso picAvatar.Bounds.IntersectsWith(PictureBox.Bounds) Then
                    collision = True
                    Exit For 'Exit when at least one collision found 
                Else : collision = False
                End If
            Next

            collision = False
            For Each PictureBox In Me.Controls
                If PictureBox IsNot picAvatar AndAlso picAvatar.Bounds.IntersectsWith(PictureBox.Bounds) Then
                    collision = True
                    Exit For
                End If
            Next
        End If
    End Sub
End Class
