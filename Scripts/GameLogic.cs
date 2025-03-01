using Godot;
using System;

public partial class GameLogic : Node
{
public override void _Ready()
{
    var player1AS = GetNode<player1>("player1").attentionSpan;
    var player2AS = GetNode<player2>("player2").attentionSpan;
    var player3AS = GetNode<player3>("player3").attentionSpan;

}

}
