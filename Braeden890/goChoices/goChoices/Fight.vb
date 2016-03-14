Public Class Fight
    Dim AttackGen As New Random 'Self Explanatory
    Dim HC As Integer           'Player Hit chance
    Dim Plug As Integer         'Stops randomizer
    Dim EHC As Integer          'Enemy Hit chance
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Fight_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        ProgressBar2.Value = ProgressBar2.Value - 5
        Label1.Text = ProgressBar1.Value
        Label4.Text = ProgressBar2.Value
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        ProgressBar1.Value = ProgressBar1.Value - 5
        Label1.Text = ProgressBar1.Value
        Label4.Text = ProgressBar2.Value
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click

    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Plugger.Enabled = True

    End Sub

    Private Sub Updaete_Tick(sender As System.Object, e As System.EventArgs) Handles Updaete.Tick
        Label6.Text = HC
        Label7.Text = EHC
        Label1.Text = ProgressBar1.Value
        Label4.Text = ProgressBar2.Value
        Label8.Text = Form1.PlayerHX
        Label10.Text = Form1.PlayerHY
        Label11.Text = Form1.PlayerDmg
        If ProgressBar1.Value = 0 Then
            Button5.Enabled = False
            Randomizer.Enabled = False
        End If
        If ProgressBar2.Value = 0 Then
            Button5.Enabled = False
            Randomizer.Enabled = False
        End If
    End Sub

    Private Sub Randomizer_Tick(sender As System.Object, e As System.EventArgs) Handles Randomizer.Tick
        HC = AttackGen.Next(0, 101)
        EHC = AttackGen.Next(0, 101)
    End Sub

    Private Sub Plugger_Tick(sender As System.Object, e As System.EventArgs) Handles Plugger.Tick
        Plug += 1
        Randomizer.Enabled = False
        If Randomizer.Enabled = False And EHC >= 51 And EHC <= 101 Then
            If ProgressBar1.Value <= 0 Then
                ProgressBar1.Value = 0
            End If
            ProgressBar1.Value = ProgressBar1.Value - 5
            Plug = 2
        End If
        If Randomizer.Enabled = False And HC >= Form1.PlayerHX And HC <= Form1.PlayerHY Then
            If ProgressBar2.Value <= 0 Then
                ProgressBar2.Value = 0
            End If
            ProgressBar2.Value = ProgressBar2.Value - Form1.PlayerDmg
            Plug = 2
        End If
        If Plug = 2 Then
            Randomizer.Enabled = True
            Plugger.Enabled = False
            Plug = 0
        End If
    End Sub
End Class