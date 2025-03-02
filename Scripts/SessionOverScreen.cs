using Godot;
using System;
using System.Runtime.Serialization;


public partial class SessionOverScreen : Control
{
	public override void _Ready()
	{
		
		//Retry button
		var button = GetNode<Button>("Button");
		button.Text = "Retry?";
		button.Pressed += Retry;

		//Avg Player AS Stat
		var playerAvgASLabel = GetNode<Label>("AvgPlayerAS");
		playerAvgASLabel.Text = "Avg. Player Attention Span: "+ GameLogic.Instance.AvgPlayerAS.ToString("0");
	}

	private void Retry()
	{
		GetTree().ChangeSceneToFile("res://Scenes/main.tscn");
	}

}
