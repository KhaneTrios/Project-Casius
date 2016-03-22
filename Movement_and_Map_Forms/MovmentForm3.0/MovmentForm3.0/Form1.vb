'Movement Form 3.0 by Tony Dougal
'This is the real shit, Kid.
'Smash that mofo star button if you think this isn't cancerous.

Public Class Form1

    'Declare variables for the player's current and former coordinates.
    Dim playerx As Integer : Dim playerbx As Integer
    Dim playery As Integer : Dim playerby As Integer
    'Variables for town spawns.
    Dim spawnTown As Integer 'Tells the program whether the town's coordinates have been spawned yet.
    Dim town1x As Integer : Dim town1y As Integer

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

        'Show the player's current coordinates
        showPlayerCoordinate()

    End Sub 'End movement sub

    'Function for clearing the whole fucking map.
    Public Function clearCoordinates() As Boolean
        x0y0.Image = clear.Image
        x0y1.Image = clear.Image
        x0y2.Image = clear.Image
        x1y0.Image = clear.Image
        x1y1.Image = clear.Image
        x1y2.Image = clear.Image
        x2y0.Image = clear.Image
        x2y1.Image = clear.Image
        x2y2.Image = clear.Image
        Return 0
    End Function

    'Function for showing town coordinates.
    Public Function showTown1Coordinate() As Boolean
        'According to the town's current coordinates
        If town1x = 0 And town1y = 0 Then
            'Make the towns's current coordinate's picturebox show the player.
            x0y0.Image = town.Image
        End If

        If town1x = 0 And town1y = 1 Then
            x0y1.Image = town.Image
        End If

        If town1x = 0 And town1y = 2 Then
            x0y2.Image = town.Image
        End If

        If town1x = 1 And town1y = 0 Then
            x1y0.Image = town.Image
        End If

        If town1x = 1 And town1y = 1 Then
            x1y1.Image = town.Image
        End If

        If town1x = 1 And town1y = 2 Then
            x1y2.Image = town.Image
        End If

        If town1x = 2 And town1y = 0 Then
            x2y0.Image = town.Image
        End If

        If town1x = 2 And town1y = 1 Then
            x2y1.Image = town.Image
        End If

        If town1x = 2 And town1y = 2 Then
            x2y2.Image = town.Image
        End If
        Return 0
    End Function

    'Function for showing the player's coordinate.
    Public Function showPlayerCoordinate() As Boolean
        'According to the player's current coordinates
        If playerx = 0 And playery = 0 Then

            'Clear the whole grid
            clearCoordinates()

            'Make the player's current coordinate's picturebox show the player.
            x0y0.Image = player.Image

            'Show the town through the town's current coordinate picturebox.
            showTown1Coordinate()

        End If

        If playerx = 0 And playery = 1 Then
            clearCoordinates()
            x0y1.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 0 And playery = 2 Then
            clearCoordinates()
            x0y2.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 1 And playery = 0 Then
            clearCoordinates()
            x1y0.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 1 And playery = 1 Then
            clearCoordinates()
            x1y1.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 1 And playery = 2 Then
            clearCoordinates()
            x1y2.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 2 And playery = 0 Then
            clearCoordinates()
            x2y0.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 2 And playery = 1 Then
            clearCoordinates()
            x2y1.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 2 And playery = 2 Then
            clearCoordinates()
            x2y2.Image = player.Image
            showTown1Coordinate()
        End If
        Return 0
    End Function 'End movement function

    'When the form loads.
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Randomize()
        'Load the town coordinates.
        town1x = CInt(Int((3 * Rnd()) + 0))
        town1y = CInt(Int((3 * Rnd()) + 0))

        'Update the town's variable labels
        townLabelx.Text = town1x
        townLabely.Text = town1y

        'Load the player's current coordinates.
        showPlayerCoordinate()

    End Sub 'end form load sub

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

    Private Sub town_Click(sender As System.Object, e As System.EventArgs) Handles town.Click
        Button1.Enabled = False
    End Sub
End Class 'End main class
