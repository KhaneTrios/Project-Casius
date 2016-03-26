﻿Public Class frmMainMenu
    Dim fileNumber As Integer

    Private Sub frmMainMenu_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        chkCreds.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkCreds.Size = New System.Drawing.Size(208, 80)
    End Sub

    Private Sub btnClick_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Oemtilde

        End Select
    End Sub

    Private Sub btnName_Click(sender As Object, e As EventArgs) Handles btnName.Click
        Variables.Overall.name = txtName.Text
        Variables.Overall.num = txtNum.Text
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        fileNumber = FreeFile()
        FileOpen(fileNumber, "TEST.TXT", OpenMode.Output)
        PrintLine(fileNumber, Variables.Overall.name)
        PrintLine(fileNumber, Variables.Overall.num)
        FileClose(fileNumber)
    End Sub

    Private Sub btnLd_Click(sender As Object, e As EventArgs) Handles btnLd.Click
        fileNumber = FreeFile()
        FileOpen(fileNumber, "TEST.TXT", OpenMode.Input)
        Input(fileNumber, Variables.Overall.name)
        Input(fileNumber, Variables.Overall.num)
    End Sub

    Private Sub lblName_Click(sender As Object, e As EventArgs) Handles lblName.Click
        lblName.Text = Variables.Overall.name
    End Sub

    Private Sub lblNum_Click(sender As Object, e As EventArgs) Handles lblNum.Click
        lblNum.Text = Variables.Overall.num
    End Sub

    Private Sub btnQuit_Click(sender As System.Object, e As System.EventArgs) Handles btnQuit.Click
        End
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub btnLoadGame_Click(sender As System.Object, e As System.EventArgs) Handles btnLoadGame.Click
        Variables.Overall.saveLoad = 2
        frmSaves.Show()
    End Sub

    Private Sub btnNewGame_Click(sender As System.Object, e As System.EventArgs) Handles btnNewGame.Click
        Variables.Overall.saveLoad = 1
        frmSaves.Show()
    End Sub


    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles rtxtCred.TextChanged

    End Sub
End Class
