using System;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;

public class Goal {
    private string _name;
    private string _description;
    private int _amountPoints;
    private Boolean _goalCompleted;

    //Constructor for Goal
    public Goal(string name, string description, int amountPoints) {
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
    public virtual void RecordEvent() {
        _goalCompleted = true;
        Console.WriteLine($"Event recorded for '{_name}'.");
    }

    //Virtual method to create new goal
    public virtual void CreateGoal() {
        //Placeholder to be overridden by derived classes
    }
}