using Godot;
using System;


public partial class kill_zone : Area2D
{
	private Timer _timer;
	private void _on_body_entered(Node2D body)
	{
		GD.Print("You Died!");
		Engine.TimeScale = 0.5;
		_timer =  GetNode<Timer>("Timer");	//references the Timer Node
		body.GetNode<CollisionShape2D>("CollisionShape2D").QueueFree();
		_timer.Start();

	}

	private void _on_timer_timeout()
	{
		Engine.TimeScale = 1;
		GetTree().ReloadCurrentScene();
	}

}

