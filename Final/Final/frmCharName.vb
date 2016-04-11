Public Class frmCharName
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtName.Text = Variables.Overall.name
        Me.Close()
    End Sub
End Class