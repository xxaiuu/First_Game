using Godot;
using System;

public partial class slime : Node2D
{
	private const float speed = 60f;
	private RayCast2D RightRay, LeftRay;
	private AnimatedSprite2D sprite;
	private int direction = 1;
	
	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		RightRay = GetNode<RayCast2D>("RayCastRight");
		LeftRay = GetNode<RayCast2D>("RayCastLeft");
		sprite = GetNode<AnimatedSprite2D>("AnimatedSprite2D");

		if(RightRay.IsColliding())
			direction = -1;
			sprite.FlipH = true;	//flips artwork so it looks like the sprite is walking back and forth
		if(LeftRay.IsColliding())
			direction = 1;
			sprite.FlipH = false;
		Position = new Vector2(Position.X + (direction * speed * (float)delta), Position.Y);
	}
}
