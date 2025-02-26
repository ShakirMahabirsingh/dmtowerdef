using Godot;
using System;


public partial class mainscene : Node
{

    public override void _Ready() //First init
    {
        GD.Print("Hello Dev!");

        var countdownlabel = GetNode<Label>("Label");
        var countdowntimer = GetNode<Timer>("Timer");
        
        countdowntimer.Start();
        countdowntimer.Timeout += OnTimerTimeout;
        Engine.TimeScale = 0.5;
  

    }

    public override void _Process(double delta) //Updates every frame
    {

        var countdownlabel = GetNode<Label>("Label"); //<node name>
        var countdowntimer = GetNode<Timer>("Timer"); // "variable in UI"
    
        countdownlabel.Text = countdowntimer.TimeLeft.ToString("0");

    }


    private void OnTimerTimeout()
    {
        GD.Print("SESSION OVER!!!");
        GetTree().ChangeSceneToFile("res://Scenes/session_over_screen.tscn");
        
    }

    private void CardSelected()
	{
		
		var player1bump = GetNode<player1>("player1");
		player1bump.attentionSpan += 100;
	}

}
