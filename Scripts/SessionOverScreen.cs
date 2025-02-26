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
	}

	private void Retry()
	{
		GetTree().ChangeSceneToFile("res://Scenes/main.tscn");
	}

}
