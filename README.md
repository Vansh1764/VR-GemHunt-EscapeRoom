# VR-GemHunt-EscapeRoom
 
VR Gem Hunt Escape Game
Project Overview
This project is a VR-based escape game developed using Unity. The player must navigate a virtual room, locate three hidden gems, and place them on a designated box. Once all three gems are placed, a door will open, allowing the player to escape the room. The game is controlled using the keyboard (WASD keys), without the need for physical VR controllers.

Features
VR Environment: A fully immersive VR setting using the LowPolyDungeonsLite asset.
Keyboard Controls: Player can move around the room and interact with objects using standard keyboard controls.
WASD for movement.
LSHIFT to grab objects with the right hand.
SPACEBAR to grab objects with the left hand.
Gem Collection: Three gems are hidden in the room. Players must find and place all gems on the box.
Dynamic Door Mechanism: Once all gems are placed, the door opens, allowing the player to escape.
Sound Effects: Audio feedback is provided when grabbing gems or interacting with objects, and background audio is included.
Interactive Objects: Various interactable objects in the environment add to the immersion.
Setup Instructions
Clone the Repository:
Clone this GitHub repository using the following command:

bash
Copy code
git clone https://github.com/YourUsername/YourRepoName.git
Open in Unity:

Open Unity Hub and click on Add.
Browse to the cloned project folder and open the project in Unity.
Ensure you have the correct Unity version installed (Unity 2020.x or later).
Install XR Plugin Management:

Ensure XR Plugin Management is installed via Window -> Package Manager.
Enable OpenXR in Project Settings -> XR Plugin Management.
Play the Game:

Press the Play button in Unity Editor to start the game.
Use keyboard controls to navigate and interact with the VR environment.
Controls
WASD: Move around.
LSHIFT: Grab object with right hand.
SPACEBAR: Grab object with left hand.
Mouse: Look around the environment.
Asset Credits
LowPolyDungeonsLite: Environment assets for the dungeon and room.
Gem Models: Custom 3D models used for the gems hidden in the room.
Audio Assets:
Grab sound: [Audio clip name]
Background music: [Audio clip name]
How the Game Works
The player starts in a locked room.
Explore the environment and locate three hidden gems.
Pick up the gems and place them on the box.
Once all gems are placed, the door will automatically open, and the player can escape.
Known Issues
Audio Toggle: Audio may not work if the Unity scene's audio is disabled. Ensure the audio is toggled on in the scene tab.
Future Enhancements
Improved Object Interactions: Adding more physics-based interactions.
Additional Puzzles: Include more interactive elements and puzzles to solve before escaping.
