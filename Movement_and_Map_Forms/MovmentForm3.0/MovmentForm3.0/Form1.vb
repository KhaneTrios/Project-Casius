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
    'Merchant spawns
    Dim merchantx As Integer
    Dim merchanty As Integer

    'When a button is pressed. (Movement)
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

        'Map Boundaries
        'If the player passes the x boundary
        If playerx < 0 Or playerx > 8 Then
            'return him to his last coordinate
            playerx = playerbx
        End If
        'If the player passes the y boundary
        If playery < 0 Or playery > 11 Then
            'return him to his last coordinate
            playery = playerbydv
        End If

        'Update the coordinate labels for troubleshooting purposes
        labelx.Text = playerx
        labely.Text = playery

        'Show the player's current coordinates
        showPlayerCoordinate()

        'Triggered
        If playerx = merchantx And playery = merchanty Then
            'Do shit in here.
        End If

    End Sub 'End movement sub

    'Function for clearing the whole fucking map.
    Public Function clearCoordinates() As Boolean
        x0y0.Image = clear.Image
        x0y1.Image = clear.Image
        x0y2.Image = clear.Image
        x0y3.Image = clear.Image
        x0y4.Image = clear.Image
        x0y5.Image = clear.Image
        x0y6.Image = clear.Image
        x0y7.Image = clear.Image
        x0y8.Image = clear.Image
        x0y9.Image = clear.Image
        x0y10.Image = clear.Image
        x0y11.Image = clear.Image
        x1y0.Image = clear.Image
        x1y1.Image = clear.Image
        x1y2.Image = clear.Image
        x1y3.Image = clear.Image
        x1y4.Image = clear.Image
        x1y5.Image = clear.Image
        x1y6.Image = clear.Image
        x1y7.Image = clear.Image
        x1y8.Image = clear.Image
        x1y9.Image = clear.Image
        x1y10.Image = clear.Image
        x1y11.Image = clear.Image
        x2y0.Image = clear.Image
        x2y1.Image = clear.Image
        x2y2.Image = clear.Image
        x2y3.Image = clear.Image
        x2y4.Image = clear.Image
        x2y5.Image = clear.Image
        x2y6.Image = clear.Image
        x2y7.Image = clear.Image
        x2y8.Image = clear.Image
        x2y9.Image = clear.Image
        x2y10.Image = clear.Image
        x2y11.Image = clear.Image
        x3y1.Image = clear.Image
        x3y2.Image = clear.Image
        x3y3.Image = clear.Image
        x3y4.Image = clear.Image
        x3y5.Image = clear.Image
        x3y6.Image = clear.Image
        x3y7.Image = clear.Image
        x3y8.Image = clear.Image
        x3y9.Image = clear.Image
        x3y10.Image = clear.Image
        x3y11.Image = clear.Image
        x4y0.Image = clear.Image
        x4y1.Image = clear.Image
        x4y2.Image = clear.Image
        x4y3.Image = clear.Image
        x4y4.Image = clear.Image
        x4y5.Image = clear.Image
        x4y6.Image = clear.Image
        x4y7.Image = clear.Image
        x4y8.Image = clear.Image
        x4y9.Image = clear.Image
        x4y10.Image = clear.Image
        x4y11.Image = clear.Image
        x5y0.Image = clear.Image
        x5y1.Image = clear.Image
        x5y2.Image = clear.Image
        x5y3.Image = clear.Image
        x5y4.Image = clear.Image
        x5y5.Image = clear.Image
        x5y6.Image = clear.Image
        x5y7.Image = clear.Image
        x5y8.Image = clear.Image
        x5y9.Image = clear.Image
        x5y10.Image = clear.Image
        x5y11.Image = clear.Image
        x6y0.Image = clear.Image
        x6y1.Image = clear.Image
        x6y2.Image = clear.Image
        x6y3.Image = clear.Image
        x6y4.Image = clear.Image
        x6y5.Image = clear.Image
        x6y6.Image = clear.Image
        x6y7.Image = clear.Image
        x6y8.Image = clear.Image
        x6y9.Image = clear.Image
        x6y10.Image = clear.Image
        x6y11.Image = clear.Image
        x7y0.Image = clear.Image
        x7y1.Image = clear.Image
        x7y2.Image = clear.Image
        x7y3.Image = clear.Image
        x7y4.Image = clear.Image
        x7y5.Image = clear.Image
        x7y6.Image = clear.Image
        x7y7.Image = clear.Image
        x7y8.Image = clear.Image
        x7y9.Image = clear.Image
        x7y10.Image = clear.Image
        x7y11.Image = clear.Image
        x8y0.Image = clear.Image
        x8y1.Image = clear.Image
        x8y2.Image = clear.Image
        x8y3.Image = clear.Image
        x8y4.Image = clear.Image
        x8y5.Image = clear.Image
        x8y6.Image = clear.Image
        x8y7.Image = clear.Image
        x8y8.Image = clear.Image
        x8y9.Image = clear.Image
        x8y10.Image = clear.Image
        x8y11.Image = clear.Image
        Return 0
    End Function

    'Function for showing town coordinates.
    Public Function showTown1Coordinate() As Boolean

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

        If playerx = 0 And playery = 3 Then
            clearCoordinates()
            x0y3.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 0 And playery = 4 Then
            clearCoordinates()
            x0y4.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 0 And playery = 5 Then
            clearCoordinates()
            x0y5.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 0 And playery = 6 Then
            clearCoordinates()
            x0y6.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 0 And playery = 7 Then
            clearCoordinates()
            x0y7.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 0 And playery = 8 Then
            clearCoordinates()
            x0y8.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 0 And playery = 9 Then
            clearCoordinates()
            x0y9.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 0 And playery = 10 Then
            clearCoordinates()
            x0y10.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 0 And playery = 11 Then
            clearCoordinates()
            x0y11.Image = player.Image
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

        If playerx = 1 And playery = 3 Then
            clearCoordinates()
            x1y3.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 1 And playery = 4 Then
            clearCoordinates()
            x1y4.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 1 And playery = 5 Then
            clearCoordinates()
            x1y5.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 1 And playery = 6 Then
            clearCoordinates()
            x1y6.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 1 And playery = 7 Then
            clearCoordinates()
            x1y7.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 1 And playery = 8 Then
            clearCoordinates()
            x1y8.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 1 And playery = 9 Then
            clearCoordinates()
            x1y9.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 1 And playery = 10 Then
            clearCoordinates()
            x1y10.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 1 And playery = 11 Then
            clearCoordinates()
            x1y11.Image = player.Image
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

        If playerx = 2 And playery = 3 Then
            clearCoordinates()
            x2y3.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 2 And playery = 4 Then
            clearCoordinates()
            x2y4.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 2 And playery = 5 Then
            clearCoordinates()
            x2y5.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 2 And playery = 6 Then
            clearCoordinates()
            x2y6.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 2 And playery = 7 Then
            clearCoordinates()
            x2y7.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 2 And playery = 8 Then
            clearCoordinates()
            x2y8.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 2 And playery = 9 Then
            clearCoordinates()
            x2y9.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 2 And playery = 10 Then
            clearCoordinates()
            x2y10.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 2 And playery = 11 Then
            clearCoordinates()
            x2y11.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 3 And playery = 0 Then
            clearCoordinates()
            x3y0.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 3 And playery = 1 Then
            clearCoordinates()
            x3y1.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 3 And playery = 2 Then
            clearCoordinates()
            x3y2.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 3 And playery = 3 Then
            clearCoordinates()
            x3y3.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 3 And playery = 4 Then
            clearCoordinates()
            x3y4.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 3 And playery = 5 Then
            clearCoordinates()
            x3y5.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 3 And playery = 6 Then
            clearCoordinates()
            x3y6.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 3 And playery = 7 Then
            clearCoordinates()
            x3y7.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 3 And playery = 8 Then
            clearCoordinates()
            x3y8.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 3 And playery = 9 Then
            clearCoordinates()
            x3y9.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 3 And playery = 10 Then
            clearCoordinates()
            x3y10.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 3 And playery = 11 Then
            clearCoordinates()
            x3y11.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 4 And playery = 0 Then
            clearCoordinates()
            x4y0.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 4 And playery = 1 Then
            clearCoordinates()
            x4y1.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 4 And playery = 2 Then
            clearCoordinates()
            x4y2.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 4 And playery = 3 Then
            clearCoordinates()
            x4y3.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 4 And playery = 4 Then
            clearCoordinates()
            x4y4.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 4 And playery = 5 Then
            clearCoordinates()
            x4y5.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 4 And playery = 6 Then
            clearCoordinates()
            x4y6.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 4 And playery = 7 Then
            clearCoordinates()
            x4y7.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 4 And playery = 8 Then
            clearCoordinates()
            x4y8.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 4 And playery = 9 Then
            clearCoordinates()
            x4y9.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 4 And playery = 10 Then
            clearCoordinates()
            x4y10.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 4 And playery = 11 Then
            clearCoordinates()
            x4y11.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 5 And playery = 0 Then
            clearCoordinates()
            x5y0.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 5 And playery = 1 Then
            clearCoordinates()
            x5y1.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 5 And playery = 2 Then
            clearCoordinates()
            x5y2.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 5 And playery = 3 Then
            clearCoordinates()
            x5y3.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 5 And playery = 4 Then
            clearCoordinates()
            x5y4.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 5 And playery = 5 Then
            clearCoordinates()
            x5y5.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 5 And playery = 6 Then
            clearCoordinates()
            x5y6.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 5 And playery = 7 Then
            clearCoordinates()
            x5y7.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 5 And playery = 8 Then
            clearCoordinates()
            x5y8.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 5 And playery = 9 Then
            clearCoordinates()
            x5y9.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 5 And playery = 10 Then
            clearCoordinates()
            x5y10.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 5 And playery = 11 Then
            clearCoordinates()
            x5y11.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 6 And playery = 0 Then
            clearCoordinates()
            x6y0.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 6 And playery = 1 Then
            clearCoordinates()
            x6y1.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 6 And playery = 2 Then
            clearCoordinates()
            x6y2.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 6 And playery = 3 Then
            clearCoordinates()
            x6y3.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 6 And playery = 4 Then
            clearCoordinates()
            x6y4.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 6 And playery = 5 Then
            clearCoordinates()
            x6y5.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 6 And playery = 6 Then
            clearCoordinates()
            x6y6.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 6 And playery = 7 Then
            clearCoordinates()
            x6y7.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 6 And playery = 8 Then
            clearCoordinates()
            x6y8.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 6 And playery = 9 Then
            clearCoordinates()
            x6y9.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 6 And playery = 10 Then
            clearCoordinates()
            x6y10.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 6 And playery = 11 Then
            clearCoordinates()
            x6y11.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 7 And playery = 0 Then
            clearCoordinates()
            x7y0.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 7 And playery = 1 Then
            clearCoordinates()
            x7y1.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 7 And playery = 2 Then
            clearCoordinates()
            x7y2.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 7 And playery = 3 Then
            clearCoordinates()
            x7y3.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 7 And playery = 4 Then
            clearCoordinates()
            x7y4.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 7 And playery = 5 Then
            clearCoordinates()
            x7y5.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 7 And playery = 6 Then
            clearCoordinates()
            x7y6.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 7 And playery = 7 Then
            clearCoordinates()
            x7y7.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 7 And playery = 8 Then
            clearCoordinates()
            x7y8.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 7 And playery = 9 Then
            clearCoordinates()
            x7y9.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 7 And playery = 10 Then
            clearCoordinates()
            x7y10.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 7 And playery = 11 Then
            clearCoordinates()
            x7y11.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 8 And playery = 0 Then
            clearCoordinates()
            x8y0.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 8 And playery = 1 Then
            clearCoordinates()
            x8y1.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 8 And playery = 2 Then
            clearCoordinates()
            x8y2.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 8 And playery = 3 Then
            clearCoordinates()
            x8y3.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 8 And playery = 4 Then
            clearCoordinates()
            x8y4.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 8 And playery = 5 Then
            clearCoordinates()
            x8y5.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 8 And playery = 6 Then
            clearCoordinates()
            x8y6.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 8 And playery = 7 Then
            clearCoordinates()
            x8y7.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 8 And playery = 8 Then
            clearCoordinates()
            x8y8.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 8 And playery = 9 Then
            clearCoordinates()
            x8y9.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 8 And playery = 10 Then
            clearCoordinates()
            x8y10.Image = player.Image
            showTown1Coordinate()
        End If

        If playerx = 8 And playery = 11 Then
            clearCoordinates()
            x8y11.Image = player.Image
            showTown1Coordinate()
        End If

        Return 0
    End Function 'End movement function

    'When the form loads.
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Randomize()
        'Load the town coordinates.
        town1x = CInt(Int((8 * Rnd()) + 0))
        town1y = CInt(Int((11 * Rnd()) + 0))

        'Update the town's variable labels
        townLabelx.Text = town1x
        townLabely.Text = town1y

        'Load the player's current coordinates.
        showPlayerCoordinate()

    End Sub 'end form load sub

    Private Sub town_Click(sender As System.Object, e As System.EventArgs) Handles town.Click
        Button1.Enabled = False
    End Sub

End Class 'End main class
