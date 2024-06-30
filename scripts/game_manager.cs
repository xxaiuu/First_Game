using Godot;
using System;

public partial class game_manager : Node
{
	int score = 0;

	private Label s_manager;

	public void add_point(){

		s_manager = GetNode<Label>("ScoreLabel");

		score += 1;
		s_manager.Text= "You have collected: " + score + " Coins";
		//GD.Print(score);
	}

}
