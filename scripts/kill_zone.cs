using Godot;
using System;
public partial class kill_zone : Area2D
{
	private Timer _timer;
	private AudioStreamPlayer2D death_sound;

	private void _on_body_entered(Node2D body)
	{
		_timer =  GetNode<Timer>("Timer");	//references the Timer Node
		death_sound = GetNode<AudioStreamPlayer2D>("death");
		


		GD.Print("You Died!");
		Engine.TimeScale = 0.5;
		death_sound.Play();
		body.GetNode<CollisionShape2D>("CollisionShape2D").QueueFree();

		_timer.Start();
	}
	private void _on_timer_timeout()
	{
		Engine.TimeScale = 1;
		GetTree().ReloadCurrentScene();
	}
}
