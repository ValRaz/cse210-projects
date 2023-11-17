using System;

public class EternalGoal : Goal {
    //Constructor for Eternal Goal
    public EternalGoal(string name, string description, int amountPoints) : base(name, description, amountPoints) {
    }

    //Override method to calculate the points for this event
    public override int GetPoints()
    {
        return base.GetPoints();
    }

    //Override method to record event and mark eternal goal event accomplished
    public override void RecordEvent()
    {
        base.RecordEvent();
        Console.WriteLine($"Eternal goal '{GetName()}' Points added: {GetPoints()}.");
    }
}