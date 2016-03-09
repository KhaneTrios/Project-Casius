Public Class Form1
    Public Shared WarrStr As Integer
    Public Shared WarrAgi As Integer
    Public Shared WarrCon As Integer
    Public Shared WarrLck As Integer
    Public Shared WarrInt As Integer
    Dim Roflmaolol As Integer
    Public Shared charWarr As Integer
    Public Shared charTact As Integer
    Public Shared charMage As Integer
    Public Shared charRogu As Integer
    Public Shared charUnbo As Integer


    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        begin.Show()
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Label2.Text = Start.Variable.asdfmod
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        charWarr = CheckBox1.Enabled
        Form1.WarrStr = 10
        Form1.WarrAgi = 5
        Form1.WarrCon = 7
        Form1.WarrLck = 5
        Form1.WarrInt = 3
        CheckBox1.Enabled = False
        CheckBox2.Enabled = False
        CheckBox3.Enabled = False
        CheckBox4.Enabled = False
        CheckBox5.Enabled = False
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox5.CheckedChanged
        charTact = CheckBox5.Enabled
        Form1.WarrStr = 5
        Form1.WarrAgi = 10
        Form1.WarrCon = 5
        Form1.WarrLck = 7
        Form1.WarrInt = 3
        CheckBox1.Enabled = False
        CheckBox2.Enabled = False
        CheckBox3.Enabled = False
        CheckBox4.Enabled = False
        CheckBox5.Enabled = False
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox2.CheckedChanged
        charUnbo = CheckBox2.Enabled
        Form1.WarrStr = 0
        Form1.WarrAgi = 0
        Form1.WarrCon = 0
        Form1.WarrLck = 0
        Form1.WarrInt = 0
        CheckBox1.Enabled = False
        CheckBox2.Enabled = False
        CheckBox3.Enabled = False
        CheckBox4.Enabled = False
        CheckBox5.Enabled = False
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox4.CheckedChanged
        charMage = CheckBox4.Enabled
        Form1.WarrStr = 3
        Form1.WarrAgi = 5
        Form1.WarrCon = 5
        Form1.WarrLck = 7
        Form1.WarrInt = 10
        CheckBox1.Enabled = False
        CheckBox2.Enabled = False
        CheckBox3.Enabled = False
        CheckBox4.Enabled = False
        CheckBox5.Enabled = False
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox3.CheckedChanged
        charRogu = CheckBox3.Enabled
        Form1.WarrStr = 5
        Form1.WarrAgi = 7
        Form1.WarrCon = 3
        Form1.WarrLck = 10
        Form1.WarrInt = 3
        CheckBox1.Enabled = False
        CheckBox2.Enabled = False
        CheckBox3.Enabled = False
        CheckBox4.Enabled = False
        CheckBox5.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        'clear attributes
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        TheThing.Enabled = True
    End Sub

    Private Sub Updater_Tick(sender As System.Object, e As System.EventArgs) Handles Updater.Tick
        Label4.Text = Form1.WarrStr
        Label5.Text = Form1.WarrAgi
        Label6.Text = Form1.WarrCon
        Label12.Text = Form1.WarrLck
        Label14.Text = Form1.WarrInt
    End Sub

    Private Sub TheThing_Tick(sender As System.Object, e As System.EventArgs) Handles TheThing.Tick
        Form1.WarrStr = 0
        Form1.WarrAgi = 0
        Form1.WarrCon = 0
        Form1.WarrLck = 0
        Form1.WarrInt = 0
        CheckBox1.Enabled = True
        CheckBox2.Enabled = True
        CheckBox3.Enabled = True
        CheckBox4.Enabled = True
        CheckBox5.Enabled = True
        Roflmaolol += 1
        If Roflmaolol = 10 Then
            Roflmaolol = 0
            TheThing.Enabled = False
        End If
    End Sub
End Class
