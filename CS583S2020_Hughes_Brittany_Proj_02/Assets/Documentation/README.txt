Title:2D top down minature Role Playing Game(RPG)
Class: CS 583 3D Game Programming 
Author: Brittany Hughes 
Art: Brittany Hughes  

GAME INSTRUCTIONS

ART
Sprites Made using Piskel.com 
Animations made using Piskel.com

TUTORIALS USED
[Blackthornprod].(2017, Dec. 28). Shooting/Follow/Retreat Enemy AI with unity and C#- easy tutorial [Video File]. Retrieved from https://www.youtube.com/watch?v=_Z1t7MNk0c4&t=1s
                 (2018, Aug. 27). How to make an inventory with unity & c# - beginner tutorial - 1/2 [Video File]. Retrieved from https://www.youtube.com/watch?v=DLAIYSMYy2g&t=308s
[Comphonia].(2016, May. 12). How to Create Rolling End credits in unity with only unity UI(No code)[Video File]. Retrieved from https://www.youtube.com/watch?v=yDkZ5QIkfSc
[Mister Taft Creates]. (2018, Dec. 3). Part30- Context clues: make a game like zelda using unity and c# [Video File]. Retrieved from https://www.youtube.com/watch?v=ct_5AvIk3vc&t=332s 
                       (2018, Aug. 17). Part 4- Tilemaps with collisions: make a game like legend of zelda with unity and c# [Video file]. Retrieved from https://www.youtube.com/watch?v=zA8wa-L5xek 
                       (2018, Aug. 30). Part 10 - Signs and Dialog: Make a game like the legend od zelda using unity and c# [Video File]. Retrieved from https://www.youtube.com/watch?v=1NCvpZDtTMI
[Brackeys].(2017, Dec, 20). Pause menu in unity [Video File]. Retrieved from https://www.youtube.com/watch?v=JivuXdrIHK0&t=459s
           (2017, May. 31). Introdution to audio in unity [Video File]. Retrieved from https://www.youtube.com/watch?v=6OT43pvUyfY&t=236s

MUSIC USED
Sonatina for Piano and Cello by Martijn de Boer (NiGiD) (c) copyright 2020 Licensed under a Creative Commons Attribution Noncommercial  (3.0) license. http://dig.ccmixter.org/files/NiGiD/61232 Ft: Doxent Zsigmond
Dee_Yan-Key_-_03_-_Goddess_of_Flowers https://freemusicarchive.org/music/Dee_Yan-Key
Game Audio -UI SFX Teleport space morph Free Sound.org https://freesound.org/people/GameAudio/sounds/220209/
Game Audio - UI SFX PingBing Februaty 22, 2014 https://freesound.org/people/GameAudio/sounds/220212/

LOGS: 
February 29, 2020
	Today I created the project for this 2D game. I established the basic screen with a placeholder for the title
	and four buttons: New game, load game, options, quit. 
	I began to work on the main character and the supporting character the main character will be interacting with
	at the beginning of the game. I completed the basic look and color using piskel.com. I completed two walk cycles for the main 
	character and two idle positions for the supporting character. 
March 1, 2020
	I began workig on drawing the side positions of the main character. Drawing the first position was difficult. After I drew the first position I 
	mirrored it to save time and did the same with the animation. Out of all of the animations I have done so far this proved to be the most difficult. 
	Using another Brackeys tutorial I imported all of my sprites for my main character and rigged up the animation movements.  
March 2, 2020
	I completed the shield positions for the main character. I didn't draw a sheild for the upper position because I felt that it was
	not necessary. Not my best artwork.
	I created a function called shield. I made a simple if statement to see if I could get the input of a single key. I did the same for the attack 
	fuction. 
	I got the shooting mechanic to work partially. It shoots but it doesn't change the direction when the character changes direction. Also It disappears
	when I put a collider around the charater. 
March 3, 2020
	Created the basic mechanic for the first type of enemy. I created a script where if it gets hit with a game object type dagger, its health decreases
	until it hits 0. When it hits 0 the enemy object destroys itself.
	I began creating basic tiles for the outdoor enviornment. 
March 4, 2020
	I got the camera to follow the player although my player is a bit jittery.
	I fixed the jitters by setting smoothness to 1. I finished laying out the base edges of the levels.  
March 5, 2020
	I got rid of the tiles I had already laid down and made a smaller area. I began to work on the main
	villiage and the dialog system such as reading signs. Im having issues with the collisions and I cant get the dialogue to work.
	The dagger is being affected by the box colliders. 
March 7th, 2020
	I laid out the areas and gave some areas colliders to prevent the player from moving. 
	Worked on enemy movement and AI
March 8th, 2020
	Worked on enemy movement and AI.
March 9th, 2020
	Created health sprites for the player and set up the heart UI
March 10th, 2020
	Went to TA, got sign fixed. 
	Drew out the titlescreen
	Laid out the town
March 11th, 2020
	Added a bit to the title screen and imported it into unity. 
	I created the quit button function and created the credits scene. 
	I laid out the basic bedroom area and created a transition from the main menu to the bedroom level
March 12th, 2020
	I tried to place a Singleton on the main character and the canvas with the ui however it only worked with the ui. For the main character I used the 
	DoNotDestoryOnLoad. I created the bedroom and the downstairs area of the house. I placed a trigger in the bedroom where if the player is in contact
	with it, it transitions to the downstairs area. 
	I created the splash screen
March 13th, 2020
	Finished the thought bubble that pops over the characters head. 
	Placed the singleton on both the player and the ui
	I hooked up the bedroom area with the downstairs area with the outside area however, there are bugs from the downstairs area to the outside area 
	that needs fixing
March 15th 2020
	Im getting rid of the thought bubble
	I somehow got the scenes to line up without the compiler yelling at me......
March 28th, 2020
	I completed the GAMEOVER sequence for the game
	I got the enemies to not immediately follow the player until the player is within a certain distance
March 29th - April 3rd 2020
	I retrieved music for the main menu and the buttons 
	I added music for the main menu and the buttons
	I laid out the stage for the final boss
	I recycled buttons from the UI assignment and added them to the main menu
	I created a pause screen and a coin pickup for the UI
	Began working on inventory 
	
April 4th - April 5th
	Worked on creating a patrolling enemy and inventory sysyem
	Imported sister character and created dialogue
April 6th 2020,
	Created back button for the credits screen
	Created instructions for the game 
	Added more music to the other scenes
	Drew enemy sprites (2) and enemy projectile (1)
April 7th - April 10th
	Added roofs to buildings
	Hooked up buttons on the pause menu 
	Added more enemies, coins and health assets
	Changed the health of the player to 2hp per heart 
	Mute music when pause screen is ativated and when the menu button is pressed, when the player dies and when the player wins
	Took out the player abiity to go back to the house because it would make multiple copies of the player
	Added extra health assets in the boss level
	Finished inventory
	Added apples 
	

BUG LOG
 The camera of the Bedroom level moves dont know why it happened as I was doing the pause menu
 Dagger pushing player back when button is hit
 Dagger isn't changing position as character changes position 

 Camera isnt being attached to the player when outside scene is activated --------> Resolved
 Sheild - removed component
 ? is not activating ----> removed component
 Player isn't taking damage ---> Resolved march 10th  
 Signs can not be read ---> Resolved march 10th 
 Enemy isn't shooting ----> Resolved march 9th 

Color Palletes
	Main Character
		Skin - #fcefc3
		Shadows - #9f0c0c
		Outline - #000000
		Clothes - #ff0000
		Shoes - #9f8429
		shoe shadow - #76611b
		Eyes - #13d5f6
		Arm Highlight - #584b4b
		
		Sheild
			#bafcfc - inner
			#8d9595 - outter
	Misc
		sign - base: #7b561d / writing: #634415
	Cave 
		#19213a
			
