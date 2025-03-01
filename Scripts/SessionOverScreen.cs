using Godot;
using System;
using System.Runtime.Serialization;


public partial class SessionOverScreen : Control
{
	public override void _Ready()
	{
		var button = GetNode<Button>("Button");
		button.Text = "Retry?";
		button.Pressed += Retry;

		var playerAvgASLabel = GetNode<Label>("playerAvgASLabel");
		var GameLogic = GetNode<GameLogic>("GameLogicVar");
		playerAvgASLabel.Text = "Avg. Player Attention Span:"+ GameLogic;
	}

	private void Retry()
	{
		GetTree().ChangeSceneToFile("res://Scenes/main.tscn");
	}

}
