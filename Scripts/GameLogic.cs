using Godot;
using System;
using System.Collections.Generic;
using System.Linq;

public partial class GameLogic : Node
{
    public static GameLogic Instance { get; private set;}
    
    public double AvgPlayerAS;

public override void _Ready()
{
    Instance = this;
}

public override void _Process(double delta)
{
    var player1 = GetNode<player1>("../player1");
    var player1AS = player1.attentionSpan;

    var player2 = GetNode<player2>("../player2");
    var player2AS = player2.attentionSpan;

    var player3 = GetNode<player3>("../player3");
    var player3AS = player3.attentionSpan;

    AvgPlayerAS = (player1AS + player2AS + player3AS)/(3);
    List<double> AvgPlayerASList = new List<double>{player1AS, player2AS, player3AS};
}

}
