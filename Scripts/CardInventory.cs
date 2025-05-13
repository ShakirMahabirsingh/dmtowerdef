using Godot; 
using System;
using System.Collections.Generic;


public partial class CardInventory : Node
{
    public static CardInventory Instance { get; private set;}
    
    public Dictionary<int, string> CardDictionary = new()
    {
        { 0, "A dragon swoops down upon your party, poised and ready to attack. Get ready for battle!"},
        { 1, "A party of goblins appears before you. Everyone draws their weapons."},
        { 2, "You enter the town and find and old man peddling suspicious wares."},
        { 3, "A mysterious man catches your eye. He approaches with a sinister smile."},
        { 4, "You found a dog! You pet him!"},
        { 5, "This is option 5."}

    };
    public override void _Ready()
    {
        Instance = this;
        
    }


}