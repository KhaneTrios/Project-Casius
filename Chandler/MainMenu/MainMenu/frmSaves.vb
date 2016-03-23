Public Class frmSaves

    Private Sub btnSave1_Click(sender As System.Object, e As System.EventArgs) Handles btnSave1.Click
        Select Variables.Overall.saveLoad
            Case 1
                Variables.Overall.fileNumber = FreeFile()
                FileOpen(Variables.Overall.fileNumber, "FILE01.TXT", OpenMode.Output)
                PrintLine(Variables.Overall.fileNumber, Variables.Overall.name)
                PrintLine(Variables.Overall.fileNumber, Variables.Overall.num)
                FileClose(Variables.Overall.fileNumber)
            Case 2
                Variables.Overall.fileNumber = FreeFile()
                FileOpen(Variables.Overall.fileNumber, "FILE01.TXT", OpenMode.Input)
                Input(Variables.Overall.fileNumber, Variables.Overall.name)
                Input(Variables.Overall.fileNumber, Variables.Overall.num)
                FileClose(Variables.Overall.fileNumber)
        End Select
    End Sub

    Private Sub btnSave2_Click(sender As System.Object, e As System.EventArgs) Handles btnSave2.Click
        Select Case Variables.Overall.saveLoad
            Case 1
                Variables.Overall.fileNumber = FreeFile()
                FileOpen(Variables.Overall.fileNumber, "FILE02.TXT", OpenMode.Output)
                PrintLine(Variables.Overall.fileNumber, Variables.Overall.name)
                PrintLine(Variables.Overall.fileNumber, Variables.Overall.num)
                FileClose(Variables.Overall.fileNumber)
            Case 2
                Variables.Overall.fileNumber = FreeFile()
                FileOpen(Variables.Overall.fileNumber, "FILE02.TXT", OpenMode.Input)
                Input(Variables.Overall.fileNumber, Variables.Overall.name)
                Input(Variables.Overall.fileNumber, Variables.Overall.num)
                FileClose(Variables.Overall.fileNumber)
        End Select
    End Sub

    Private Sub btnSave3_Click(sender As System.Object, e As System.EventArgs) Handles btnSave3.Click
        Select Case Variables.Overall.saveLoad
            Case 1
                Variables.Overall.fileNumber = FreeFile()
                FileOpen(Variables.Overall.fileNumber, "FILE03.TXT", OpenMode.Output)
                PrintLine(Variables.Overall.fileNumber, Variables.Overall.name)
                PrintLine(Variables.Overall.fileNumber, Variables.Overall.num)
                FileClose(Variables.Overall.fileNumber)
            Case 2
                Variables.Overall.fileNumber = FreeFile()
                FileOpen(Variables.Overall.fileNumber, "FILE03.TXT", OpenMode.Input)
                Input(Variables.Overall.fileNumber, Variables.Overall.name)
                Input(Variables.Overall.fileNumber, Variables.Overall.num)
                FileClose(Variables.Overall.fileNumber)
        End Select
    End Sub

    Private Sub frmSaves_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.StartPosition = 0
        Me.Top = frmMainMenu.Top + 150
        Me.Left = frmMainMenu.Left + frmMainMenu.Width - Me.Width - 175

        Variables.Overall.fileNumber = FreeFile()
        FileOpen(Variables.Overall.fileNumber, "FILE01.TXT", OpenMode.Input)
        Input(Variables.Overall.fileNumber, Variables.Overall.save1)
        FileClose(Variables.Overall.fileNumber)

        btnSave1.Text = Variables.Overall.save1
    End Sub
End Class