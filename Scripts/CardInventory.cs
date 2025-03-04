using Godot; 
using System;
using System.Collections.Generic;


public partial class CardInventory : Node
{
    public static CardInventory Instance { get; private set;}
    
    public override void _Ready()
    {
        Instance = this;
        
        var CardDict = new Godot.Collections.Dictionary
        {
            { 0, "A dragon swoops down upon your party, poised and ready to attack. Get ready for battle!"},
            { 1, "A party of goblins appears before you. Everyone draws their weapons."}

        };
    }
    

    


}