Class Test_Form

    'When the ok button is clicked
    Private Sub Test_Form_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'open MovementFormNew
        MovementFormNew.Show() : Me.Close()
    End Sub

End Class