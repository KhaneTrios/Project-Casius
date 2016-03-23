Public Class Variables

    Structure Auto
        'Globally declaring variables to use anywhere
        Public Shared amount As Long                ' Total amount of clicks (score), data type "Long" so the score can get very very large.
        Public Shared auto1 As Integer              ' Number of first auto clicker owned.
        Public Shared auto1Val As Integer           ' Value of first auto clicker.
        Public Shared auto1Item As Integer            ' How much experience the action gives
        Public Shared auto1Cool As Integer          ' Cooldown of clicker
        Public Shared auto1Cost As Integer          ' Cost to purchase item
        Public Shared auto2 As Integer : Public Shared auto2Val As Integer : Public Shared auto2Cost : Public Shared auto2Item As Integer
        Public Shared auto3 As Integer : Public Shared auto3Val As Integer : Public Shared auto3Cost : Public Shared auto3Item As Integer : Public Shared auto3Skill As String
        Public Shared auto4 As Integer : Public Shared auto4Val As Integer : Public Shared auto4Cost : Public Shared auto4Item As Integer : Public Shared auto4Skill As String
        Public Shared auto5 As Integer : Public Shared auto5Val As Integer : Public Shared auto5Cost : Public Shared auto5Item As Integer : Public Shared auto5Skill As String
        Public Shared auto6 As Integer : Public Shared auto6Val As Integer : Public Shared auto6Cost : Public Shared auto6Item As Integer : Public Shared auto6Skill As String
        Public Shared auto7 As Integer : Public Shared auto7Val As Integer : Public Shared auto7Cost : Public Shared auto7Item As Integer : Public Shared auto7Skill As String
        Public Shared auto8 As Integer : Public Shared auto8Val As Integer : Public Shared auto8Cost : Public Shared auto8Item As Integer : Public Shared auto8Skill As String
        Public Shared auto9 As Integer : Public Shared auto9Val As Integer : Public Shared auto9Cost : Public Shared auto9Item As Integer : Public Shared auto9Skill As String
        Public Shared add As Integer                ' Amount of clicks gained by the action taken.
        Public Shared addamount As Integer          ' Amount that is being added into the total amount (add variable)
        Public Shared GPPS As Integer               ' Total Points gained per second.
        ' Variables for the auto clicker buttons to be enabled or not.
        Public Shared auto2Off As Boolean : Public Shared auto3Off As Boolean : Public Shared auto4Off As Boolean : Public Shared auto5Off As Boolean : Public Shared auto6Off As Boolean : Public Shared auto7Off As Boolean : Public Shared auto8Off As Boolean : Public Shared auto9Off As Boolean
        Public Shared auto1Bought As Boolean : Public Shared auto2Bought As Boolean : Public Shared auto3Bought As Boolean : Public Shared auto4Bought As Boolean : Public Shared auto5Bought As Boolean : Public Shared auto6Bought As Boolean : Public Shared auto7Bought As Boolean : Public Shared auto8Bought As Boolean
        ' --- Rebuilding Stat Variables ---
        ' Variables for the total amounts of rebuilding stats
        Public Shared home As Integer : Public Shared guard As Integer : Public Shared civ As Integer : Public Shared church As Integer : Public Shared shop As Integer : Public Shared wall As Integer : Public Shared bank As Integer : Public Shared hall As Integer
        Public Shared gamble As Integer 'Used for Auto clicker 9
        Public Shared auto1Max As Integer : Public Shared auto2Max As Integer : Public Shared auto3Max As Integer : Public Shared auto4Max As Integer : Public Shared auto5Max As Integer : Public Shared auto6Max As Integer : Public Shared auto7Max As Integer : Public Shared auto8Max As Integer
        Public Shared recAsk As Boolean = False
        Public Shared auto2Col As Boolean = False : Public Shared auto3Col As Boolean = False : Public Shared auto4Col As Boolean = False : Public Shared auto6Col As Boolean = False
    End Structure
    Structure Fight

    End Structure

    Structure Movement
        Public Shared cordx As Integer = 0 'player x coordinate 
        Public Shared cordy As Integer = 0 'player y coordinate 
        Public Shared cordbx As Integer = 0 'player's last x coordinate 
        Public Shared cordby As Integer = 0 'player's last y coordinate 
        Public Shared townName As String 'Town name 
        Public Shared townSize As Integer 'Town size 
    End Structure

    Structure Overall
        Public Shared name As String
        Public Shared num As Integer
        Public Shared fileNumber As Integer
        Public Shared saveLoad As Integer
        Public Shared save1 As String : Public Shared save2 As String : Public Shared save3 As String
        Public Shared oneWritten As Boolean = False : Public Shared twoWritten As Boolean = False : Public Shared threeWritten As Boolean = False

    End Structure
End Class
