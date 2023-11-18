using System;

public class Goal {
    private string _name;
    private string _description;
    private int _amountPoints;
    private Boolean _goalCompleted;

    //Constructor for Goal
    public Goal(string name, string description, int amountPoints = 15) {
        _name = name;
        _description = description;
        _amountPoints = amountPoints;
        _goalCompleted = false;
    }

    //Method to get the name of a goal
    public string GetName() {
        return _name;
    }

    //Method to get competion status of a goal
    public virtual string GetCompletion() {
        return _goalCompleted ? "[x]" : "[ ]";
    } 

    //Virtual method to get points for a goal
    public virtual int GetPoints() {
        return _amountPoints;
    }

    //Method to record an event and mark the goal as accomplished
    public virtual void RecordGoalEvent() {
        _goalCompleted = true;
        Console.WriteLine($"Event recorded for '{_name}'.");
    }

    //Getter for goal completion status
    public bool IsGoalCompleted() {
        return _goalCompleted;
    }

    //Protected setter for goal completion status
    protected void SetGoalCompleted(bool completed) {
        _goalCompleted = completed;
    }

    //Virtual method to create new goal
    public virtual void CreateGoal() {
        //Placeholder to be overridden by derived classes
    }
}