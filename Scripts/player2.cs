using Godot;
using System;

//Avg Player, loses AS moderately 
public partial class player2 : CharacterBody2D
{
	public double attentionSpan = 100;
	public double aSburnSpeed = 10.0;
	
	public override void _Process(double delta)
	{

		var player2_animatedsprite = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
		var player2ASLabel = GetNode<Label>("player2ASLabel");

		player2ASLabel.Text = attentionSpan.ToString("0");

		if (attentionSpan > 0)
		{
			attentionSpan -= aSburnSpeed * delta;

		}

		if (attentionSpan >70)
		{
			player2_animatedsprite.Play("player2_normal");
		}
		if (attentionSpan <70 & attentionSpan >40)
		{
			player2_animatedsprite.Play("player2_losinginterest");
		}
		if (attentionSpan <40)
		{
			player2_animatedsprite.Play("player2_bored");
		}
		if (attentionSpan == 0)
		{
			player2_animatedsprite.QueueFree();
			QueueFree();
		}
	}
}
