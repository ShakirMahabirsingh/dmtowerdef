using Godot;
using System;

public partial class Card1 : Node2D
{
	
	public override void _Ready()
	{
		var button = GetNode<Button>("SelectCard");
		button.Pressed += CardSelected;
		
	}

	private void CardSelected()
	{
		GD.Print("click!");
		// var player1bump = GetNode<player1>("player1");	
	 	// player1bump.attentionSpan += 100;
	}
}
