using Godot;
using System;

public partial class player1 : CharacterBody2D
{
	public int attentionSpan = 1000;
	
	public override void _Process(double delta)
	{
		
		Engine.TimeScale = 0.5;
		

		var player1_animatedsprite = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
		
	
		if (attentionSpan > 0)
		{
			attentionSpan --;
			GD.Print("Current AS:" + attentionSpan); 
		}

		if (attentionSpan >700)
		{
			player1_animatedsprite.Play("player1_normal");
		}
		if (attentionSpan <700 & attentionSpan >400)
		{
			player1_animatedsprite.Play("player1_losinginterest");
		}
		if (attentionSpan <400)
		{
			player1_animatedsprite.Play("player1_bored");
		}
		if (attentionSpan == 0)
		{
			player1_animatedsprite.QueueFree();
		}
	}
}
