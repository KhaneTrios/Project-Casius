Public Class frmSaves

    Private Sub btnSave1_Click(sender As System.Object, e As System.EventArgs) Handles btnSave1.Click
        Select Case Variables.Overall.saveLoad                                          'Variable that shows whether you are performing a save or load 1 being save, 2 being load
            Case 1                                                                      'In the case you are saving
                Variables.Overall.oneWritten = True
                Variables.Overall.fileNumber = FreeFile()                               'Setting the file number variable to the lowest random available file number
                FileOpen(Variables.Overall.fileNumber, "FILE01.txt", OpenMode.Output)   'Open the file to write data to it, read the file number, what is the file name, what kind of file and action are we taking: openning a text file to write to.
                PrintLine(Variables.Overall.fileNumber, Variables.Overall.oneWritten)
                PrintLine(Variables.Overall.fileNumber, Variables.Overall.name)         'Print on the first line of the document, read the file number to know what file is in question, the single variable you are storing on that line.
                PrintLine(Variables.Overall.fileNumber, Variables.Overall.num)          'Print data on the next line of the document, read th file number, write that variable to the document.
                FileClose(Variables.Overall.fileNumber)                                 'Close the file that is referenced by the active file number
                Variables.Overall.oneWritten = True
            Case 2                                                                      'In the case that you are loading
                If Variables.Overall.oneWritten = True Then
                    Variables.Overall.fileNumber = FreeFile()                               'Setting the file number variable to the lowest random available file number
                    FileOpen(Variables.Overall.fileNumber, "FILE01.txt", OpenMode.Input)    'Open the file to read data from it, read the file number, what is the file name, what kind of file and action are we taking: openning a text file to load information from it.
                    Input(Variables.Overall.fileNumber, Variables.Overall.oneWritten)
                    Input(Variables.Overall.fileNumber, Variables.Overall.name)             'Store the data that is on the first line of the document into the variable we name
                    Input(Variables.Overall.fileNumber, Variables.Overall.num)              'Store the data on the next line of the document into the variable we name
                    FileClose(Variables.Overall.fileNumber)                                 'Close the file that is referenced by the active file number.
                    Me.Close()
                Else : MessageBox.Show("No save file detected.", "No save file", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

        End Select
    End Sub

    Private Sub btnSave2_Click(sender As System.Object, e As System.EventArgs) Handles btnSave2.Click
        Select Case Variables.Overall.saveLoad
            Case 1
                Variables.Overall.twoWritten = True
                Variables.Overall.fileNumber = FreeFile()
                FileOpen(Variables.Overall.fileNumber, "FILE02.txt", OpenMode.Output)
                PrintLine(Variables.Overall.fileNumber, Variables.Overall.twoWritten)
                PrintLine(Variables.Overall.fileNumber, Variables.Overall.name)
                PrintLine(Variables.Overall.fileNumber, Variables.Overall.num)
                FileClose(Variables.Overall.fileNumber)
            Case 2
                If Variables.Overall.twoWritten = True Then
                    Variables.Overall.fileNumber = FreeFile()
                    FileOpen(Variables.Overall.fileNumber, "FILE02.txt", OpenMode.Input)
                    Input(Variables.Overall.fileNumber, Variables.Overall.twoWritten)
                    Input(Variables.Overall.fileNumber, Variables.Overall.name)
                    Input(Variables.Overall.fileNumber, Variables.Overall.num)
                    FileClose(Variables.Overall.fileNumber)
                    Me.Close()
                Else : MessageBox.Show("No save file detected.", "No save file", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
        End Select
    End Sub

    Private Sub btnSave3_Click(sender As System.Object, e As System.EventArgs) Handles btnSave3.Click
        Select Case Variables.Overall.saveLoad
            Case 1
                Variables.Overall.threeWritten = True
                Variables.Overall.fileNumber = FreeFile()
                FileOpen(Variables.Overall.fileNumber, "FILE03.txt", OpenMode.Output)
                PrintLine(Variables.Overall.fileNumber, Variables.Overall.threeWritten)
                PrintLine(Variables.Overall.fileNumber, Variables.Overall.name)
                PrintLine(Variables.Overall.fileNumber, Variables.Overall.num)
                FileClose(Variables.Overall.fileNumber)
            Case 2
                If Variables.Overall.threeWritten = True Then
                    Variables.Overall.fileNumber = FreeFile()
                    FileOpen(Variables.Overall.fileNumber, "FILE03.txt", OpenMode.Input)
                    Input(Variables.Overall.fileNumber, Variables.Overall.threeWritten)
                    Input(Variables.Overall.fileNumber, Variables.Overall.name)
                    Input(Variables.Overall.fileNumber, Variables.Overall.num)
                    FileClose(Variables.Overall.fileNumber)
                    Me.Close()
                Else : MessageBox.Show("No save file detected.", "No save file", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
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
        Input(Variables.Overall.fileNumber, Variables.Overall.oneWritten)
        If Variables.Overall.oneWritten = True Then
            btnSave1.Enabled = True
            Input(Variables.Overall.fileNumber, Variables.Overall.save1)
            FileClose(Variables.Overall.fileNumber)
            btnSave1.Text = Variables.Overall.save1
        Else : btnSave1.Text = "Save Slot 1" : FileClose(Variables.Overall.fileNumber)
        End If

        Variables.Overall.fileNumber = FreeFile()
        FileOpen(Variables.Overall.fileNumber, "FILE02.txt", OpenMode.Input)
        Input(Variables.Overall.fileNumber, Variables.Overall.twoWritten)
        If Variables.Overall.twoWritten = True Then
            btnSave2.Enabled = True
            Input(Variables.Overall.fileNumber, Variables.Overall.save2)
            FileClose(Variables.Overall.fileNumber)
            btnSave2.Text = Variables.Overall.save2
        Else : btnSave2.Text = "Save Slot 2" : FileClose(Variables.Overall.fileNumber)
        End If

        Variables.Overall.fileNumber = FreeFile()
        FileOpen(Variables.Overall.fileNumber, "FILE03.txt", OpenMode.Input)
        Input(Variables.Overall.fileNumber, Variables.Overall.threeWritten)
        If Variables.Overall.threeWritten = True Then
            btnSave3.Enabled = True
            Input(Variables.Overall.fileNumber, Variables.Overall.save3)
            FileClose(Variables.Overall.fileNumber)
            btnSave3.Text = Variables.Overall.save3
        Else : btnSave3.Text = "Save Slot 3" : FileClose(Variables.Overall.fileNumber)
        End If

    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnDelete1_Click(sender As Object, e As EventArgs) Handles btnDelete1.Click
        MessageBox.Show("Are you sure you want to delete this save file?.", "Delete save file?", MessageBoxButtons.YesNo, MessageBoxIcon.Stop)     'Error message to handle no save file
        If DialogResult.Yes Then
            Variables.Overall.oneWritten = False
            Variables.Overall.fileNumber = FreeFile()
            FileOpen(Variables.Overall.fileNumber, "FILE01.txt", OpenMode.Output)
            PrintLine(Variables.Overall.fileNumber, Variables.Overall.oneWritten)
            FileClose(Variables.Overall.fileNumber)
        End If
    End Sub

    Private Sub btnDelete2_Click(sender As Object, e As EventArgs) Handles btnDelete2.Click
        MessageBox.Show("Are you sure you want to delete this save file?.", "Delete save file?", MessageBoxButtons.YesNo, MessageBoxIcon.Stop)     'Error message to handle no save file
        If DialogResult.Yes Then
            Variables.Overall.twoWritten = False
            Variables.Overall.fileNumber = FreeFile()
            FileOpen(Variables.Overall.fileNumber, "FILE02.txt", OpenMode.Output)
            PrintLine(Variables.Overall.fileNumber, Variables.Overall.twoWritten)
            FileClose(Variables.Overall.fileNumber)
        End If
    End Sub

    Private Sub btnDelete3_Click(sender As Object, e As EventArgs) Handles btnDelete3.Click
        MessageBox.Show("Are you sure you want to delete this save file?.", "Delete save file?", MessageBoxButtons.YesNo, MessageBoxIcon.Stop)     'Error message to handle no save file
        If DialogResult.Yes Then
            Variables.Overall.threeWritten = False
            Variables.Overall.fileNumber = FreeFile()
            FileOpen(Variables.Overall.fileNumber, "FILE03.txt", OpenMode.Output)
            PrintLine(Variables.Overall.fileNumber, Variables.Overall.threeWritten)
            FileClose(Variables.Overall.fileNumber)
        End If
    End Sub
End Class