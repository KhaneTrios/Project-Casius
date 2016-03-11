Public Class begin
    Dim skill As Integer
    Private Sub begin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If Form1.charWarr = True Then
            Button9.Enabled = False
            Button10.Enabled = False
            Button11.Enabled = False
            Button12.Enabled = False
            Button13.Enabled = False
            Button14.Enabled = False
            Button15.Enabled = False
            Button16.Enabled = False
            Button17.Enabled = False
            Button18.Enabled = False
            Button19.Enabled = False
            Button20.Enabled = False
            Button21.Enabled = False
            Button22.Enabled = False
            Button23.Enabled = False
            Button24.Enabled = False
        ElseIf Form1.charTact = True Then
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button13.Enabled = False
            Button14.Enabled = False
            Button15.Enabled = False
            Button16.Enabled = False
            Button17.Enabled = False
            Button18.Enabled = False
            Button19.Enabled = False
            Button20.Enabled = False
            Button21.Enabled = False
            Button22.Enabled = False
            Button23.Enabled = False
            Button24.Enabled = False
        ElseIf Form1.charMage = True Then
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
            Button10.Enabled = False
            Button11.Enabled = False
            Button12.Enabled = False
            Button17.Enabled = False
            Button18.Enabled = False
            Button19.Enabled = False
            Button20.Enabled = False
            Button21.Enabled = False
            Button22.Enabled = False
            Button23.Enabled = False
            Button24.Enabled = False
        ElseIf Form1.charRogu = True Then
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
            Button10.Enabled = False
            Button11.Enabled = False
            Button12.Enabled = False
            Button13.Enabled = False
            Button14.Enabled = False
            Button15.Enabled = False
            Button16.Enabled = False
            Button21.Enabled = False
            Button22.Enabled = False
            Button23.Enabled = False
            Button24.Enabled = False
        ElseIf Form1.charUnbo = True Then
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
            Button10.Enabled = False
            Button11.Enabled = False
            Button12.Enabled = False
            Button13.Enabled = False
            Button14.Enabled = False
            Button15.Enabled = False
            Button16.Enabled = False
            Button17.Enabled = False
            Button18.Enabled = False
            Button19.Enabled = False
            Button20.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        skill += 1
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Updater.Tick
        Label3.Text = skill
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        skillcount.Enabled = True
    End Sub

    Private Sub skillcount_Tick(sender As System.Object, e As System.EventArgs) Handles skillcount.Tick
        skill += 1
        If skill = 10 Then
            skillcount.Enabled = False
        End If
        If skill < 10 And skillcount.Interval = 100 Then
            skillcount.Enabled = True
        End If
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        skill -= 1
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click

    End Sub

    Private Sub Button25_Click(sender As System.Object, e As System.EventArgs) Handles Button25.Click
        Fight.Show()
        Me.Close()
    End Sub
End Class