from pygame import  * 
from sys    import  * 
from random import  * 
import os 
 

def DrawCharacter(scr): 
    BLUE=(0,0,255)
    draw.rect(scr,BLUE,(200,150,100,50),0)

def DrawWindow(setX,setY):
    window = display.set_mode((700, 500))
    display.set_caption("First Project")  
    display.update()  
    DrawCharacter(window)

gameIsOn = True

while gameIsOn:
    time.delay(50)
    DrawWindow(500,700)   
    for e in event.get():
        if e.type == KEYDOWN: 
            if e.key == K_SPACE:
                gameIsOn = False
 
