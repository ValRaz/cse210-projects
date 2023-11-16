using System;

public class CheckListGoal : Goal {
    private int _timesToAccomplishGoal;
    private int _timesAccomplished;

    //Constructor for checklist goal
    public CheckListGoal(string name, string description, int amountPoints, int timesToAccomplishGoal) : base(name, description, amountPoints) {
        _timesToAccomplishGoal = timesToAccomplishGoal;
        _timesAccomplished = 0;
    }

    //Getter method for timesAccomplished
    public int GetTimesAccomplished() {
        return _timesAccomplished;
    }

    //Override method to calculate the amount of points for checklist goal
    public override int GetPoints()
    {
        if (IsGoalCompleted()) {
            return (base.GetPoints() * _timesAccomplished) + base.GetPoints();
        }
        else {
            return base.GetPoints() * _timesAccomplished;
        }
    }

    //Override method to record an event and/or mark checklist completed
    public override void RecordEvent()
    {
        base.RecordEvent();
        _timesAccomplished ++;

        if (_timesAccomplished == _timesToAccomplishGoal) {
            SetGoalCompleted(true);
            Console.WriteLine($"Checklist goal '{GetName}' is now complete!");
        }
    }

    //Override to get a string showing completion status of checklist goal
    public override string GetCompletion()
    {
        if (IsGoalCompleted()) {
            return $"[X] Completed: {_timesToAccomplishGoal}/{_timesToAccomplishGoal} times.";
        }

        else return $"[ ] Completed: {_timesAccomplished}/{_timesToAccomplishGoal} times";
    }
}