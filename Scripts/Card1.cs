using Godot;
using System;
using System.Collections.Generic;

public partial class Card1 : Node2D
{
	
	public override void _Ready()
	{
		var button = GetNode<Button>("SelectCard");
		button.Pressed += CardSelected;
		
	}

	private void CardSelected()
	{
		
		GD.Print(""+ CardInventory.Instance.CardDict);
		var player1bump = GetNode<player1>("../../player1");

		if (player1bump.attentionSpan != 100)
		{
			player1bump.attentionSpan += (100-player1bump.attentionSpan);
		}
		else GD.Print("Player 1 is Max AS!!!"); //rarely show, AS always decreasing
	}
}
