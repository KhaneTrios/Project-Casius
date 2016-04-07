"""
script created to generate iterative code in the movement form
for project casius

by tony dougal
"""

c = 0 #counter variable
v = 13 #break check variable

while True:
    print("Dim tree", c, "x As Integer : Dim tree", c,"y As Integer", sep = '')
    c += 1
    if c == v:
        break
