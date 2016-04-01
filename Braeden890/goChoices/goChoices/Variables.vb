Public Class Variables

    Structure Auto
        'Globally declaring variables to use anywhere
        Public Shared amount As Long                ' Total amount of clicks (score), data type "Long" so the score can get very very large.
        Public Shared auto1 As Integer              ' Number of first auto clicker owned.
        Public Shared auto1Val As Integer           ' Value of first auto clicker.
        Public Shared auto1Item As Integer          ' How much experience the action gives
        Public Shared auto1Cool As Integer          ' Cooldown of clicker
        Public Shared auto1Cost As Integer          ' Cost to purchase item
        Public Shared auto2 As Integer : Public Shared auto2Val As Integer : Public Shared auto2Cost : Public Shared auto2Item As Integer
        Public Shared auto3 As Integer : Public Shared auto3Val As Integer : Public Shared auto3Cost : Public Shared auto3Item As Integer
        Public Shared auto4 As Integer : Public Shared auto4Val As Integer : Public Shared auto4Cost : Public Shared auto4Item As Integer
        Public Shared auto5 As Integer : Public Shared auto5Val As Integer : Public Shared auto5Cost : Public Shared auto5Item As Integer
        Public Shared auto6 As Integer : Public Shared auto6Val As Integer : Public Shared auto6Cost : Public Shared auto6Item As Integer
        Public Shared auto7 As Integer : Public Shared auto7Val As Integer : Public Shared auto7Cost : Public Shared auto7Item As Integer
        Public Shared auto8 As Integer : Public Shared auto8Val As Integer : Public Shared auto8Cost : Public Shared auto8Item As Integer
        Public Shared auto9 As Integer : Public Shared auto9Val As Integer : Public Shared auto9Cost : Public Shared auto9Item As Integer
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
        Public Shared up1Cost As Integer : Public Shared up2Cost As Integer : Public Shared up3Cost
        Public Shared up1 As Boolean : Public Shared up2 As Boolean : Public Shared up3 As Boolean
    End Structure
    Structure Fight
        '\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\
        'Classes in fight screen
        Public Shared charWarr As Integer             'If you pick the warrior class
        Public Shared charTact As Integer       'You're a tactician, Harry
        Public Shared charMage As Integer       'You're a wizard, Harry
        Public Shared charRogu As Integer       'You're a rogue, Harry
        Public Shared charUnbo As Integer        'You're a staircase child, Harry
        '\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\
        Public Shared skill As Integer                  'Actual number of skills you have
        Public Shared skillOneBought As Boolean = False 'First skill button on fight screen
        Public Shared skillTwoBought As Boolean = False 'Second skill button on fight screen
        Public Shared asdfmod As String                 'Player name
        Public Shared AttackGen As New Random           'Self Explanatory
        Public Shared opponentName As New Random        'Random opponent class above opponent picture
        Public Shared HC As Integer                     'Player Hit chance
        Public Shared Plug As Integer                   'Stops randomizer
        Public Shared EHC As Integer                    'Enemy Hit chance
        Public Shared Jerkwad As String                 'Enemy Type (aka Name)
        Public Shared Choices As Integer                'Choice for classes
        Public Shared EHealth As Integer                'Enemy health
        Public Shared plyrDmg As Integer                'Damage being dealt to player
        Public Shared PHealth As Integer                'Player health
        Public Shared eDmg As Integer                   'damage being dealth to enemy
        Public Shared playerHX As Integer               'Min Hit Range
        Public Shared playerHY As Integer               'Max Hit Range
        Public Shared PlayerDmg As Integer              'Base Player Damage
    End Structure

    Structure Skills
        Public Shared Str As Integer 'Arms Warrior: Pow!
        Public Shared Agi As Integer 'Dodge dodge  dodge  dodge  dodge  dodge  dodge  dodge  dodge  dodge  dodge  dodge  dodge.
        Public Shared Con As Integer 'If you were shot in the shoulder; the higher the better.
        Public Shared Lck As Integer '5 shots or 6?
        Public Shared Int As Integer 'Are you going to read a book, or are you dun did gonna learn yerself a book?
        Public Shared Roflmaolol As Integer 'Dat Reset Timer Variable though
        Public Shared playerHX As Integer 'Min Hit Range
        Public Shared playerHY As Integer 'Max Hit Range
        Public Shared PlayerDmg As Integer 'Base Player Damage
        Public Shared activeOnce As Boolean = False 'Variable for finishing the first fight and getting access to the main menu
        '/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\
        'All actual skills
        Public Shared warrCharge = "Charge"
        Public Shared warrBackwards = "Backwards Lash"
        Public Shared warrEnrage = "Enrage"
        Public Shared warrCore = "Core Slam"
        Public Shared tactScout = "Scout"
        Public Shared tactCaltrop = "Caltop Launch"
        Public Shared tactOver = "Over Plan"
        Public Shared tactPoison = "Poison Barrage"
        Public Shared mageShards = "Shards of Ice"
        Public Shared mageLightning = "Lightning Wave"
        Public Shared mageFire = "Fire Cage"
        Public Shared mageArcane = "Arcane Whirlwind"
        Public Shared roguBackstab = "Backstab"
        Public Shared roguParry = "Parry"
        Public Shared roguInvisible = "Invisible"
        Public Shared roguShadow = "Shadow Strike"
        Public Shared unboBurden = "Burden"
        Public Shared unboCraze = "Craze"
        Public Shared unboWild = "Wild"
        Public Shared unboRedemption = "Redemption"
        '/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\
    End Structure

    Structure Inventory




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
        Public Shared fileNumber As Integer 'The file number to read and write to files
    End Structure
End Class
