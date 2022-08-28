# Dont drop the ball
 
itch.io link: https://barakam.itch.io/dont-drop-the-ball

A movement ball game.
## player
* controls with the keyboard arrows. ---> [PlayerControl.cs](https://github.com/barakamram/Ex4_2---Dont_Drop_The_Ball/blob/main/Assets/Scripts/PlayerControl.cs)
* jumps with space, he can jump only when he is on the ground.
* can restart the phase/scene with left-shift. ---> [RestartLevelWithKey.cs](https://github.com/barakamram/Ex4_2---Dont_Drop_The_Ball/blob/main/Assets/Scripts/RestartLevelWithKey.cs)

## game
* the camera follows after the player. ---> [CopyPlayerPosition.cs](https://github.com/barakamram/Ex4_2---Dont_Drop_The_Ball/blob/main/Assets/Scripts/CopyPlayerPosition.cs)
* player cannot move on the lava.
* when the player touching the lava, he starts the phase/scene again. ---> [RestartLevelOnCollision.cs](https://github.com/barakamram/Ex4_2---Dont_Drop_The_Ball/blob/main/Assets/Scripts/RestartLevelOnCollision.cs)
* when the player touching the NextLevel Cube, he will move to the next level(the next scene). ---> [NextLevel.cs](https://github.com/barakamram/Ex4_2---Dont_Drop_The_Ball/blob/main/Assets/Scripts/NextLevel.cs)
* There are walls "Dont touch me" in the game, you can touch them, they even help in the game.

