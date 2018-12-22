River

HOW TO PLAY:

ON PC/MAC/LINUX SYSTEMS:

	A: Moves character left 
	D: Moves character right
///OR///
	Left Arrow: Character moves left.
	Right Arrow: Character moves right.
ON ANDROID:

	Tapping/Holding to the left of the screen: Character moves left.
	Tapping/Holding to the right of the screen: Character moves right.

OVERVIEW:

	River: My endless runner is a proceedually generated runner that gets harder the farther you go. Difficutly increases with speed as River runs along
a dried up river to save her village from thirst and starvation. To save memory blocks behing you are destroyed and new blocks are generated 11 blocks ahead of the 
player. A score is kept in a text UI at the top of the screen, and the players highscore is displayed proudly on the menu screen.

COMPLETED DELIVERABLES:

	Tracked Camera Narrative: At the start of the endless runner the camera starts from above the character and slowly comes down during a three second
animation. The camera then follows the player at an offset and will stay centered as the player moves side to side. 
	Save/Load: The system automatically saves the players highscore after each session. The game is then loaded back up at the start, resetting the difficulty
level.
	Reactive Environments: Although I' not sure if this counts I'll display it here anyway because it's an object in my environment that "reacts" to the player.
Coins are created along the river bed and when River touches one she collects it and it disapears.
	Builds for Android: My game has code that allows Android users to play just as easily as PC users, and can easily be built in that environment.
	5 Particle Effects: 5 different particle effects appear in my game. One at the foot of the player and another on the floor of the river bed to
simulate disturbed rocks. 2 different fire effects, one off to the left that is constant and short and one to the right that is long but pauses after releasign one 
round of shots. The final effect shoots out from the top of the coin to make it more desirable to pick-up.
	Animated GUI: Almost all of my buttons are animated, most on highlight, aside from the "Available soon" button in the shop and the "Highscore" button in the 
menu are constantly moving.
	Cel Shader: All of my obsticle components have their own cell shader, both of the rocks use a grey variant and the wooden logs use a brown variant. The color
can easily be changed in the shader menu.

UNCOMPLETED DELIVERABLES AND WHY (I'm not explaining these as an excuse I would genueinly love an answer on how to solve these issues):

	Branching Level, Level-Modifiers, Power-ups, 5 "Levels": Due to my inexperience with coding and my fear of disturbing my code to the point where it was
no longer functional I was not able to complete these deliverables. I have my code set to spawn specific prefabs into the scene at a certain point right off of the 
last prefab, but because this all works along the X-Axis I didn't know how I would go about changing the direction of the integration. While i tried I soon realized 
that decisions you make early on in the coding proccess can easily come back to haunt you down the line. With these deliverables I learned that you should take your 
end product into consideration before blindly getting the things right in front of you done in the most obvious way. Which brings me to my next deliverables.
	Modular Models and "Pay" store Interface: These two where suposed to be implimented, this is why the Store menu and the coins in the game exsist. But like my
earlier problem, because of the way i set up my code it was impossible to remove the prefabs from the scene and have the code still work. I attached code to the
player that enabled me to control their speed and monitor their score, which sounds like an easy fix just add the same code to each of the other models and make
them all prefabs. Then just spawn them in at 0,0,0 and all will be good in the world. Not quite. The score script and the main camera script both rely on a lot of 
different factors and in order to get those has spaces to drag and drop public variables into, these variables are unable to save after they are removed from the 
scene even if they're part of a prefab. I was not aware of this. And in the end I spent so much time trying to figure out these problems and it was effecting my 
progress on the core game itself.