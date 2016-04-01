"""
script created to generate iterative code in the movement form
for project casius

by tony dougal
"""

x = 0 #x coordinate variable
y = 0 #y coordinate variable
c = 0 #counter variable
v = 169 #break check variable

while True:
    print("If playerx =", x, " And playery =", y, "Then")
    print("clearCoordinates()")
    print("x",x,"y",y,".Image = player.Image", sep = '')
    print("showTown1Coordinate()")
    print("End If")
    print("")
    

    y += 1 #gspot

    c += 1

    if y == 13:
        y = 0
        x += 1 #end of gspot

    #end the program if the counter variable meets the check requirements
    if c == v:
        break
