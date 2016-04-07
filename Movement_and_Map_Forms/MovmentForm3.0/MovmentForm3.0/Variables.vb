Public Class Variables

    Structure Auto
        'Globally declaring variables to use anywhere
        'Public Shared profile As String             ' Username.
        Public Shared amount As Long                ' Total amount of clicks (score), data type "Long" so the score can get very very large.
        Public Shared auto1 As Integer              ' Number of first auto clicker owned.
        Public Shared auto1Val As Integer           ' Value of first auto clicker.
        Public Shared auto1XP As Integer            ' How much experience the action gives
        Public Shared auto1Cool As Integer          ' Cooldown of clicker
        Public Shared auto1Cost As Integer          ' Cost to purchase item
        Public Shared auto2 As Integer : Public Shared auto2Val As Integer : Public Shared auto2Cost : Public Shared auto2XP As Integer
        Public Shared auto3 As Integer : Public Shared auto3Val As Integer : Public Shared auto3Cost : Public Shared auto3XP As Integer : Public Shared auto3Skill As String
        Public Shared auto4 As Integer : Public Shared auto4Val As Integer : Public Shared auto4Cost : Public Shared auto4XP As Integer : Public Shared auto4Skill As String
        Public Shared auto5 As Integer : Public Shared auto5Val As Integer : Public Shared auto5Cost : Public Shared auto5XP As Integer : Public Shared auto5Skill As String
        Public Shared auto6 As Integer : Public Shared auto6Val As Integer : Public Shared auto6Cost : Public Shared auto6XP As Integer : Public Shared auto6Skill As String
        Public Shared auto7 As Integer : Public Shared auto7Val As Integer : Public Shared auto7Cost : Public Shared auto7XP As Integer : Public Shared auto7Skill As String
        Public Shared auto8 As Integer : Public Shared auto8Val As Integer : Public Shared auto8Cost : Public Shared auto8XP As Integer : Public Shared auto8Skill As String
        Public Shared auto9 As Integer : Public Shared auto9Val As Integer : Public Shared auto9Cost : Public Shared auto9XP As Integer : Public Shared auto9Skill As String
        Public Shared add As Integer                ' Amount of clicks gained by the action taken.
        Public Shared addamount As Integer          ' Amount that is being added into the total amount (add variable)
        Public Shared GPPS As Integer               ' Total Points gained per second.
        'Public Shared vararry(Variables.auto1, Variables.auto2, Variables.auto3, Variables.auto4, Variables.auto5, Variables.auto6, Variables.auto7, Variables.auto8)
        ' --- Skills Variables
        ' Variables for the total amounts of skill experience you gained
        Public Shared combatXp As Integer : Public Shared magicXp As Integer : Public Shared slayerXp As Integer : Public Shared gamblingXp As Integer : Public Shared craftingXp As Integer
        Public Shared gamble As Integer
    End Structure
    Structure Fight

    End Structure
    Structure Convo
        'Types: 1 (Friendly NPC), 2 (Hostile NPC), 3 (Neutral NPC), 4 (Shopkeeper), 5 (Plot)
        Public Shared Type As Integer
        Public Shared NPCName As String
        Public Shared money As Integer
        Public Shared canTrade As Boolean = False
        Public Shared haggle As Boolean
        Public Shared counter As Integer = 0
        Public Shared intimidate As Boolean
        Public Shared charTag As String
    End Structure


    Structure Movement
        Public Shared cordx As Integer = 0 'player x coordinate
        Public Shared cordy As Integer = 0 'player y coordinate
        Public Shared cordbx As Integer = 0 'player's last x coordinate
        Public Shared cordby As Integer = 0 'player's last y coordinate

        Public Shared town1Cordx As Integer
        Public Shared town1Cordy As Integer
        Public Shared town1Name As String 'Town name
        Public Shared town1Size As Integer 'Town size

        Public Shared spawned As Boolean = False 'whether everything has been spawned

    End Structure

    Structure Overall

    End Structure
End Class
