Public Class Form1
    Public Shared plyrexp As Integer
    Public Shared plyrexp2 As Integer
    Public Shared level As Integer
    Public Shared lvltot = 50
    Public Shared lvlNext As Integer
    Public Shared plyrexptot As Integer
    Dim plyrmod As Integer
    ' Public Shared expGen As New Random
    ' Dim expinc As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'plyrexp += expGen.Next(1, 51)
        'expinc = plyrexp
        ' ProgressBar1.Increment(+expinc)
        plyrexp += (5 + plyrmod)
        ProgressBar1.Increment(+(5 + plyrmod))

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
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        level = 1
        ProgressBar1.Maximum = 50

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
            plyrmod += 15
        End If
    End Sub
End Class
