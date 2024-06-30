using Godot;
using System;


public partial class coin : Area2D
{

	private game_manager g_manager;
	private AnimationPlayer animationCoin;
	private void _on_body_entered(Node2D body)
	{
		g_manager = GetNode<game_manager>("%GameManager");
		animationCoin = GetNode<AnimationPlayer>("AnimationPlayer");

		g_manager.add_point();
		animationCoin.Play("pickup");

		//GD.Print("+1 coin");
		//QueueFree();	//Before implenmenting the animation player!
					// uncomment to realize why this is an issue (sound doesnt have time to play)
	}


}



