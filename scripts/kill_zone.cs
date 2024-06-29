using Godot;
using System;


public partial class kill_zone : Area2D
{
	private Timer _timer;
	
	private void _on_body_entered(Node2D body)
	{
		GD.Print("You Died!");
		_timer =  GetNode<Timer>("Timer");
		_timer.Start();
		
	}

	private void _on_timer_timeout()
	{
		GetTree().ReloadCurrentScene();
	}

}

