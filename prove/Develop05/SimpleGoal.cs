using System;

public class SimpleGoal : Goal {
    //Constructor for a simple goal
    public SimpleGoal(string name, string description, int amountPoints) : base(name, description, amountPoints){      
    }

    //Override method to calculate total points for the simple goal
    public override int GetPoints() {
        return base.GetPoints();
    }

    //Override to record simple goal event
    public override void RecordGoalEvent() {
        base.RecordGoalEvent();
        Console.WriteLine($"Simple Goal '{GetName()}' Points added: {GetPoints()}.");
    }
}