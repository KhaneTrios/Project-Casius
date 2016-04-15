Public Class Form1
    Public Shared plyrexp As Integer
    Public Shared plyrexp2 As Integer
    Public Shared level As Integer
    Public Shared lvltot = 50
    Public Shared lvlNext As Integer
    Public Shared plyrexptot As Integer
    Dim plyrmod As Integer
    Dim Rngsus As New Random
    Dim ExpMod = 1
    Dim ExpBonus As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox2.Checked = True Then
            plyrexp += ((5 + plyrmod) * ExpMod)
            ProgressBar1.Increment(+(5 + plyrmod) * ExpMod)
        Else
            plyrexp += (5 + plyrmod)
            ProgressBar1.Increment(+(5 + plyrmod))
        End If

    End Sub

    Private Sub Updater_Tick(sender As Object, e As EventArgs) Handles Updater.Tick
        ExpShow.Text = plyrexp
        LvlShow.Text = level
        TotLvl.Text = lvlNext
        lvlNext = lvltot
        lvlNow()
        exptot.Text = plyrexptot
        plyrexptot = plyrexp2
        If level = 6 Then
            CheckBox1.Visible = True
        End If
        If level = 9 Then
            CheckBox3.Visible = True
        End If
        If level = 12 Then
            CheckBox4.Visible = True
        End If
        If level = 15 Then
            CheckBox5.Visible = True
        End If
        Label4.Text = ExpBonus
        Label5.Text = ExpMod
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        level = 1
        ProgressBar1.Maximum = 50
        ExpMod = 1
    End Sub

    Public Shared Function lvlNow()
        If plyrexp >= lvlNext Then
            level += 1
            plyrexp2 += plyrexp
            lvltot = lvltot * 2
            plyrexp = 0
            Form1.ProgressBar1.Increment(-Form1.ProgressBar1.Maximum)
            Form1.ProgressBar1.Maximum = lvltot
        End If
        Return 0
    End Function

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CheckBox1.Enabled = False
            plyrexp2 -= 1000
            plyrmod += 20
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        ExpMod = 1
        If CheckBox2.Checked = True Then
            CheckBox2.Enabled = False
        End If
    End Sub

    Private Sub exp_Tick(sender As Object, e As EventArgs) Handles exp.Tick
        If CheckBox2.Checked = True Then
            ExpBonus = Rngsus.Next(1, 51)
            'General Exp Bonus
            If ExpBonus = 1 Then
                ExpMod = 2
            ElseIf ExpBonus = 2 Then
                ExpMod = 3
            ElseIf ExpBonus = 30 Then
                ExpMod = 3
            ElseIf ExpBonus = 4 Then
                ExpMod = 2
            ElseIf ExpBonus = 5 Then
                ExpMod = 2
            ElseIf ExpBonus = 16 Then
                ExpMod = 3
            ElseIf ExpBonus = 7 Then
                ExpMod = 4
            ElseIf ExpBonus = 18 Then
                ExpMod = 5
            ElseIf ExpBonus = 26 Then
                ExpMod = 4
            ElseIf ExpBonus = 22 Then
                ExpMod = 5
            ElseIf ExpBonus = 11 Then
                ExpMod = 7
            ElseIf ExpBonus = 42 Then
                ExpMod = 6
            ElseIf ExpBonus = 13 Then
                ExpMod = 1
            ElseIf ExpBonus = 20 Then
                ExpMod = 6
            ElseIf ExpBonus = 15 Then
                ExpMod = 7
            ElseIf ExpBonus = 33 Then
                ExpMod = 1
            ElseIf ExpBonus = 41 Then
                ExpMod = 8
            ElseIf ExpBonus = 19 Then
                ExpMod = 10
            Else
                ExpMod = 1
            End If
        End If

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        CheckBox2.Enabled = True
        CheckBox2.Checked = False
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            CheckBox3.Enabled = False
            plyrexp2 -= 10000
            plyrmod += 45
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            CheckBox4.Enabled = False
            plyrexp2 -= 90000
            plyrmod += 80
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            CheckBox5.Enabled = False
            plyrexp2 -= 600000
            plyrmod += 360
        End If
    End Sub
End Class
