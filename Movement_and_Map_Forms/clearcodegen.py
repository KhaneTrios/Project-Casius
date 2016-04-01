"""
script created to generate iterative code in the movement form
for project casius

by tony dougal
"""

x = 0 #x coordinate variable
y = 0 #y coordinate variable
c = 0 #counter variable
v = 180 #break check variable

while True:
    
    print("x",x,"y",y,".Image = clear.Image", sep = '')

    y += 1

    c += 1

    if y == 13:
        y = 0
        x += 1

    #end the program if the counter variable meets the check requirements
    if c == v:
        break
