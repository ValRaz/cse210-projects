using System;
using System.ComponentModel;

public class SimpleGoal : Goal {
    //Constructor for a simple goal
    public SimpleGoal(string name, string description, int amountPoints) : base(name, description, amountPoints){      
    }

    //Override method to calculate total points for the simple goal
    public override int GetPoints()
    {
        return base.GetPoints();
    }
}