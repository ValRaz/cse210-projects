using System;

public class EternalGoal : Goal {
    //Constructor for Eternal Goal
    public EternalGoal(string name, string description, int amountPoints) : base(name, description, amountPoints) {
    }

    //Override method to calculate the points for this event
    public override int GetPoints() {
        return base.GetPoints() + 10;
    }

    //Override to record Eternal goal event and mark event accomplished
    public override void RecordGoalEvent() {
        base.RecordGoalEvent();
        Console.WriteLine($"Eternal goal '{GetName()}' Points added: {GetPoints()}.");
    }
}