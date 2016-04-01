Public Class Form1
    Public Shared Rngsus As New Random
    Public Shared Rngsus2 As New Random
    Public Shared ClassGen As Integer
    Public Shared ClassTag As String
    Public Shared Wep1 As Integer
    Public Shared WepA1 As Integer
    Public Shared WepA As String
    Public Shared Arm1 As Integer
    Public Shared ArmA As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Shared Function classchoice() As Integer
        classchoice = 1 'Rngsus.Next(1, 7)

        Select Case classchoice
            Case 1
                ClassGen = 1
                ClassTag = "Warrior"
                Wep1 = Rngsus.Next(1, 4)
                Select Case Wep1
                    Case 1
                        WepA1 = 15
                        WepA = "Short Sword"

                    Case 2
                        WepA1 = 16
                        WepA = "Long Sword"

                    Case 3
                        WepA1 = 45
                        WepA = "Two-handed Sword"

                End Select

                'Case 4

                'Case 5

                'Case 6

        End Select

        Return classchoice
    End Function
    Public Shared Function armorgen() As Integer
        Arm1 = Rngsus2.Next(1, 5)
        Select Case Arm1
            Case 1
                armorgen = 1
                ArmA = "Cloth"
            Case 2
                armorgen = 2
                ArmA = "Leather"
            Case 3
                armorgen = 3
                ArmA = "Chain"
            Case 4
                armorgen = 4
                ArmA = "Plate"
        End Select
        Return armorgen
    End Function
    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        classchoice()
        'armorgen()
        Label1.Text = ClassTag
        Label2.Text = WepA
        Label3.Text = WepA1
        'Label4.Text = ArmA
    End Sub

    Private Sub Updater_Tick(sender As Object, e As EventArgs) Handles Updater.Tick
        If ClassGen = 1 Then

            If Wep1 = 1 Then

            ElseIf Wep1 = 2 Then

            ElseIf Wep1 = 3 Then

            End If
        End If
    End Sub
End Class