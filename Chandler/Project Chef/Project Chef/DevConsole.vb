﻿Public Class DevConsole

    Private Sub btnLoad_Click(sender As System.Object, e As System.EventArgs) Handles btnLoad.Click
        frmIdle.Show()
        Me.Close()
    End Sub

    Private Sub btnEnd_Click(sender As System.Object, e As System.EventArgs) Handles btnEnd.Click
        End
    End Sub

    Private Sub DevConsole_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSet_Click(sender As System.Object, e As System.EventArgs) Handles btnSet.Click
        Variables.Movement.townSize = txtSet.Text
    End Sub

    Private Sub txtSet_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtSet.Click
        txtSet.Clear()
    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs)

    End Sub
End Class