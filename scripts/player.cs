using Godot;
using System;
public partial class player : CharacterBody2D
{
	public const float Speed = 130.0f;	//f means float
	public const float JumpVelocity = -300.0f;
	private AnimatedSprite2D sprite; 
	private AudioStreamPlayer2D death_sound;

	// Get the gravity from the project settings to be synced with RigidBody nodes.
	//by default gravity is 980
	public float gravity = ProjectSettings.GetSetting("physics/2d/default_gravity").AsSingle();
	public override void _PhysicsProcess(double delta)
	{
		Vector2 velocity = Velocity;
		sprite = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
		death_sound = GetNode<AudioStreamPlayer2D>("death");

		// Add the gravity.
		if (!IsOnFloor())
			velocity.Y += gravity * (float)delta;
		// Handle Jump.
		if (Input.IsActionJustPressed("jump") && IsOnFloor())
			velocity.Y = JumpVelocity;


		// Get the input direction and handle the movement/deceleration.
		// direction can be 0 -1 or 1
		Vector2 direction = Input.GetVector("move_left", "move_right", "ui_up", "ui_down");

		//Flip Sprite
		if (direction.X > 0)
			sprite.FlipH = false;
		else if (direction.X < 0)
			sprite.FlipH = true;


		//Play Animations
		if(IsOnFloor()){
			if(direction.X == 0)
				sprite.Play("idle");
			else 
				sprite.Play("run");
		}
		else
			sprite.Play("jump");

		//Apply movement
		if (direction != Vector2.Zero)	//Vector2.Zero is 0,0 coords
		{
			velocity.X = direction.X * Speed;
		}
		else
		{
			velocity.X = Mathf.MoveToward(Velocity.X, 0, Speed);
		}
		Velocity = velocity;
		MoveAndSlide();
	}
}
