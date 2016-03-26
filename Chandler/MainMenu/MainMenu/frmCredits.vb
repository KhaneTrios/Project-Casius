Public Class frmCredits
    Private Sub frmCredits_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Loading the form in the middle of the larger parent form
        Me.StartPosition = 0
        Me.Top = frmMainMenu.Top + 150
        Me.Left = frmMainMenu.Left + frmMainMenu.Width - Me.Width - 175
    End Sub
End Class