using Godot;
using System;


//Avg Player, doesn't lose AS very fast
public partial class player1 : CharacterBody2D
{
	[Export] 
	public double attentionSpan = 100;
	public double aSburnSpeed = 5.0;
	
	public override void _Process(double delta)
	{

		var player1_animatedsprite = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
		var player1ASLabel = GetNode<Label>("player1ASLabel");

		player1ASLabel.Text = attentionSpan.ToString("0");

	
		if (attentionSpan > 0)
		{
			attentionSpan -= aSburnSpeed * delta;
		}

		if (attentionSpan >70)
		{
			player1_animatedsprite.Play("player1_normal");
		}
		if (attentionSpan <70 & attentionSpan >40)
		{
			player1_animatedsprite.Play("player1_losinginterest");
		}
		if (attentionSpan <40)
		{
			player1_animatedsprite.Play("player1_bored");
		}
		if (attentionSpan < 0)
		{
			player1_animatedsprite.QueueFree();
		 	Engine.TimeScale = 0.1;
			GetTree().ChangeSceneToFile("res://Scenes/session_over_screen.tscn");
			QueueFree();
		}
	}
}
