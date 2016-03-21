'Movement Form 3.0 by Tony Dougal
'This is the real shit, Kid.
'Smash that mofo star button if you think this isn't cancerous.

Public Class Form1

    'Declare variables for the player's current and former coordinates.
    Dim playerx As Integer : Dim playerbx As Integer
    Dim playery As Integer : Dim playerby As Integer

    'When a button is pressed.
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Dim bHandled As Boolean = False

        Select Case e.KeyCode
            'If the arrow key is hit
            Case Keys.Right
                'Save the latest coordinate.
                playerbx = playerx
                'Make the move
                playerx += 1
                'Idk what this is but its needed. Do not remove this line
                e.Handled = True

            Case Keys.Left
                playerbx = playerx
                playerx -= 1
                e.Handled = True

            Case Keys.Up
                playerby = playery
                playery += 1
                e.Handled = True

            Case Keys.Down
                playerby = playery
                playery -= 1
                e.Handled = True

        End Select 'End select/switch

        'Update the coordinate labels for troubleshooting purposes
        labelx.Text = playerx
        labely.Text = playery

        If playerx = 0 And playery = 0 Then
            x0y0.Image = player.Image
        End If

        If playerx = 0 And playery = 1 Then
            x0y1.Image = player.Image
        End If

        If playerx = 0 And playery = 2 Then
            x0y2.Image = player.Image
        End If

        If playerx = 1 And playery = 0 Then
            x1y0.Image = player.Image
        End If

        If playerx = 1 And playery = 1 Then
            x1y1.Image = player.Image
        End If

        If playerx = 1 And playery = 2 Then
            x1y2.Image = player.Image
        End If

        If playerx = 2 And playery = 0 Then
            x2y0.Image = player.Image
        End If

        If playerx = 2 And playery = 1 Then
            x2y1.Image = player.Image
        End If

        If playerx = 2 And playery = 2 Then
            x2y2.Image = player.Image
        End If
		
    End Sub 'End movement sub

    'Function for clearing all the coordinates on the fucking map.
    Public Function clearLastCoordinate() As Boolean
        Select Case playerbx And playerby
            Case 0 And 0
                x0y0.Image = clear.Image
            Case 0 And 1
                x0y1.Image = clear.Image
            Case 0 And 2
                x0y2.Image = clear.Image
            Case 1 And 0
                x1y0.Image = clear.Image
            Case 1 And 1
                x1y1.Image = clear.Image
            Case 1 And 2
                x1y2.Image = clear.Image
            Case 2 And 0
                x2y0.Image = clear.Image
            Case 2 And 1
                x2y1.Image = clear.Image
            Case 2 And 2
                x2y2.Image = clear.Image
        End Select
        Return 0
    End Function 'End clearing function

End Class 'End main class
