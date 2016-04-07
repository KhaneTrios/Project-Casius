Public Class frmRecruit

    Private Sub btnRecCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnRecCancel.Click
        Me.Close()
    End Sub

    Private Sub btnRec_Click(sender As System.Object, e As System.EventArgs) Handles btnRec.Click
        If Val((Variables.Auto.amount) >= (Variables.Auto.auto9Cost)) Then        'Checking if the amount of GP you have is greater than or equal to the cost of the item.
            Variables.Auto.amount = Val((Variables.Auto.amount) - (Variables.Auto.auto9Cost))  'The final amount score gets subtracted by the cost of the clicker's price, thus buying the clicker

            Randomize()                                             'Initializxing the random number generator function
            Variables.Auto.gamble = (Int((5 * Rnd()) + 1))          'The variable is a random integer between 5 and 1.

            If Variables.Auto.gamble = 5 Then
                Variables.Auto.amount = Val(Variables.Auto.amount + (Variables.Auto.auto9Val) * (2))
                frmFollowers.Show()
            ElseIf Variables.Auto.gamble = 4 Then
                Variables.Auto.amount = Val(Variables.Auto.amount + (Variables.Auto.auto9Val) * (2))
                frmFollowers.Show()
            Else : frmFollowers.Show()
            End If
            Me.Close()

        Else : MessageBox.Show("The city is not strong enough.", "No", MessageBoxButtons.OK, MessageBoxIcon.Error)     'Error message to handle the button being clicked when there is not enough funds to purchase it.
        End If
    End Sub

    Private Sub Recruit_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.StartPosition = 0
        Me.Top = frmIdle.Top + 150
        Me.Left = frmIdle.Left + frmIdle.Width - Me.Width - 175
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkRecAsk.CheckedChanged
        If chkRecAsk.Checked Then
            Variables.Auto.recAsk = True
        End If
    End Sub
End Class