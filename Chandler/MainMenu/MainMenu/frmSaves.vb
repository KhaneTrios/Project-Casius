Public Class frmSaves

    Private Sub btnSave1_Click(sender As System.Object, e As System.EventArgs) Handles btnSave1.Click
        Select Case Variables.Overall.saveLoad                                          'Variable that shows whether you are performing a save or load 1 being save, 2 being load
            Case 1                                                                      'In the case you are saving
                Variables.Overall.fileNumber = FreeFile()                               'Setting the file number variable to the lowest random available file number
                FileOpen(Variables.Overall.fileNumber, "FILE01.txt", OpenMode.Output)   'Open the file to write data to it, read the file number, what is the file name, what kind of file and action are we taking: openning a text file to write to.
                PrintLine(Variables.Overall.fileNumber, Variables.Overall.name)         'Print on the first line of the document, read the file number to know what file is in question, the single variable you are storing on that line.
                PrintLine(Variables.Overall.fileNumber, Variables.Overall.num)          'Print data on the next line of the document, read th file number, write that variable to the document.
                FileClose(Variables.Overall.fileNumber)                                 'Close the file that is referenced by the active file number
            Case 2                                                                      'In the case that you are loading
                Variables.Overall.fileNumber = FreeFile()                               'Setting the file number variable to the lowest random available file number
                FileOpen(Variables.Overall.fileNumber, "FILE01.txt", OpenMode.Input)    'Open the file to read data from it, read the file number, what is the file name, what kind of file and action are we taking: openning a text file to load information from it.
                Input(Variables.Overall.fileNumber, Variables.Overall.name)             'Store the data that is on the first line of the document into the variable we name
                Input(Variables.Overall.fileNumber, Variables.Overall.num)              'Store the data on the next line of the document into the variable we name
                If Variables.Overall.name = "" Then
                    MsgBox("No save file found.", MsgBoxStyle.OkOnly, vbOKOnly)
                    '  Else : frmMovement.Show() : Me.Close()
                End If
                FileClose(Variables.Overall.fileNumber)                                 'Close the file that is referenced by the active file number.

        End Select
    End Sub

    Private Sub btnSave2_Click(sender As System.Object, e As System.EventArgs) Handles btnSave2.Click
        Select Case Variables.Overall.saveLoad
            Case 1
                Variables.Overall.fileNumber = FreeFile()
                FileOpen(Variables.Overall.fileNumber, "FILE02.txt", OpenMode.Output)
                PrintLine(Variables.Overall.fileNumber, Variables.Overall.name)
                PrintLine(Variables.Overall.fileNumber, Variables.Overall.num)
                FileClose(Variables.Overall.fileNumber)
            Case 2
                Variables.Overall.fileNumber = FreeFile()
                FileOpen(Variables.Overall.fileNumber, "FILE02.txt", OpenMode.Input)
                Input(Variables.Overall.fileNumber, Variables.Overall.name)
                'If Variables.Overall.name = "" Then
                'MsgBox("No save file found.", MsgBoxStyle.OkOnly, vbOKOnly)
                '  Else : frmMovement.Show() : Me.Close()
                'End If
                Input(Variables.Overall.fileNumber, Variables.Overall.num)
                FileClose(Variables.Overall.fileNumber)
        End Select
    End Sub

    Private Sub btnSave3_Click(sender As System.Object, e As System.EventArgs) Handles btnSave3.Click
        Select Case Variables.Overall.saveLoad
            Case 1
                Variables.Overall.fileNumber = FreeFile()
                FileOpen(Variables.Overall.fileNumber, "FILE03.txt", OpenMode.Output)
                PrintLine(Variables.Overall.fileNumber, Variables.Overall.name)
                PrintLine(Variables.Overall.fileNumber, Variables.Overall.num)
                FileClose(Variables.Overall.fileNumber)
            Case 2
                Variables.Overall.fileNumber = FreeFile()
                FileOpen(Variables.Overall.fileNumber, "FILE03.txt", OpenMode.Input)
                Input(Variables.Overall.fileNumber, Variables.Overall.name)
                Input(Variables.Overall.fileNumber, Variables.Overall.num)
                FileClose(Variables.Overall.fileNumber)
        End Select
    End Sub

    Private Sub frmSaves_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Loading the form in the middle of the larger parent form
        Me.StartPosition = 0
        Me.Top = frmMainMenu.Top + 150
        Me.Left = frmMainMenu.Left + frmMainMenu.Width - Me.Width - 175

        'Reading the name of the characters stored in each file to make the load buttons the names of the characters in the files
        Variables.Overall.fileNumber = FreeFile()
        FileOpen(Variables.Overall.fileNumber, "FILE01.txt", OpenMode.Input)
        Input(Variables.Overall.fileNumber, Variables.Overall.save1)
        'If Variables.Overall.name = "" Then
        'btnSave1.Enabled = False
        'Else : btnSave1.Text = Variables.Overall.save1
        'End If
        FileClose(Variables.Overall.fileNumber)
        btnSave1.Text = Variables.Overall.save1


        Variables.Overall.fileNumber = FreeFile()
        FileOpen(Variables.Overall.fileNumber, "FILE02.txt", OpenMode.Input)
        Input(Variables.Overall.fileNumber, Variables.Overall.save2)
        'If Variables.Overall.name = "" Then
        'btnSave2.Enabled = False
        'Else : btnSave2.Text = Variables.Overall.save2
        'End If
        FileClose(Variables.Overall.fileNumber)
        btnSave2.Text = Variables.Overall.save2


        Variables.Overall.fileNumber = FreeFile()
        FileOpen(Variables.Overall.fileNumber, "FILE03.txt", OpenMode.Input)
        Input(Variables.Overall.fileNumber, Variables.Overall.save3)
        'If Variables.Overall.name = "" Then
        'btnSave3.Enabled = False
        'Else : btnSave3.Text = Variables.Overall.save3
        'End If
        FileClose(Variables.Overall.fileNumber)
        btnSave3.Text = Variables.Overall.save3

    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class