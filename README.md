# About
First Game on Godot following the youtube tutorial, "How to make a Video Game - Godot Beginner Tutorial" <br>
but instead of using the godot language, I will be working through the tutorial in C#


Goals
- Become more familiar with Godot
- Learn the syntax of C# and become more comfortable programming in it
- Be able to take this "base" program and expand on it
- Have fun!


<br>
Resources
https://cyoann.github.io/GodotSharpAPI/html/c7d41d90-59b4-4e80-d334-bd2586caedfd.htm
<br>
<br>
Notes
- Project setting > Rendering > Textures 
  - set default texture filter to "Nearest" to disable the smoothing affect
- Scenes are reusable building blocks
- Nodes are the objects being made
  - (sub nodes) charaistics such as hitbox, what it looks like/sprite
  - (main nodes) actual objects such as player or the camera
- script is the coding aspect
  - behavior/how to act
- StaticBody2D is great for nonmoving objects such as ground
- TileMap is great for 2D games as you lay out the field like tiles
  - Make sure tile size is correct, same as your tile pixel art
  - configure tiles first with TileSet before using the TileMap
  - players will fall off unless you put in a physics layer (tile map property)
    - go to TileSet to select which tile you want to collide with
    - you don't want to collide with everything! example, the tree can be a background image instead of something that you can collide with
      - you can do this by "painting" physics layer on selected tiles
- Ordering of scenes can be changed with the properties instead of changing the order on the tree
- Can think of Scenes like templates
  - can edit one particular one to do something extra in the main scene
- Area2D detects collision on an area rather than colliding with said area
  - make a script to define what happens when it is being interacted with
  - moving platform can also interact with this
    - can be fixed through code or through properties
    - in this game, we will make our player a different physic property
      - Collision > Layer > change from 1 to 2
      - In Coin, Mask it such that only 2 will be triggered
- We can see all the signals relating to the node when clicking on the node tab on the right side
  - connecting signals does not work with an external editor such as VS Code, will need to turn it off in order for it to generate

