using Godot;
using System;

//Avg Player, loses AS  fast
public partial class player3 : CharacterBody2D
{
	[Export]
	public double attentionSpan = 100;
	public double aSburnSpeed = 20;
	
	public override void _Process(double delta)
	{

		var player3_animatedsprite = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
		var player3ASLabel = GetNode<Label>("player3ASLabel");

		player3ASLabel.Text = attentionSpan.ToString("0");

		if (attentionSpan > 0)
		{
			attentionSpan -= aSburnSpeed*delta;

		}

		if (attentionSpan >70)
		{
			player3_animatedsprite.Play("player3_normal");
		}
		if (attentionSpan <70 & attentionSpan >40)
		{
			player3_animatedsprite.Play("player3_losinginterest");
		}
		if (attentionSpan <40)
		{
			player3_animatedsprite.Play("player3_bored");
		}
		if (attentionSpan < 0)
		{
			player3_animatedsprite.QueueFree();
			GetTree().ChangeSceneToFile("res://Scenes/session_over_screen.tscn");
			Engine.TimeScale = 0.1;
			QueueFree();
		}
	}
}
