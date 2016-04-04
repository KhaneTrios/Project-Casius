Public Class frmTrade
    Private Sub SplitContainer1_Panel1_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub

    Private Sub SplitContainer1_Panel2_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel2.Paint

    End Sub

    Private Sub frmTrade_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chkItem1.Text = Variables.Overall.item1
        chkItem2.Text = Variables.Overall.item2
        chkItem3.Text = Variables.Overall.item3
        chkItem4.Text = Variables.Overall.item4
        chkItem5.Text = Variables.Overall.item5

        chkMerch1.Text = Variables.Functions.merch()
        chkMerch2.Text = Variables.Functions.merch()
        chkMerch3.Text = Variables.Functions.merch()
        chkMerch4.Text = Variables.Functions.merch()
        chkMerch5.Text = Variables.Functions.merch()

    End Sub
End Class