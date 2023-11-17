using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    // Entry point of the program, handles goal loading, user actions, and goal saving.
    static void Main(string[] args) {
        List<Goal> goals = LoadGoals();
        ProcessUserActions(goals);
        SaveGoals(goals);
    }

    // Loads goals from a file or initializes an empty list if no file exists.
    static List<Goal> LoadGoals(){
        List<Goal> loadedGoals = new List<Goal>();
        // Checks for the existence of the file and loads goal data if available.
        if (File.Exists("Goals.txt")){
            using (StreamReader reader = new StreamReader("Goals.txt")){
                string line;
                // Parses each line from the file to create Goals.
                while ((line = reader.ReadLine()) != null){
                    string[] goalData = line.Split(',');
                    string name = goalData[0].Trim();
                    string completionStatus = goalData[1].Trim();
                    int points = int.Parse(goalData[2].Trim());

                    Goal goal;
                    // Creates goal instances based on completion status.
                    if (completionStatus == "[ ]"){
                        goal = new SimpleGoal(name, completionStatus, points);
                    }
                    else if (completionStatus == "[X]"){
                        goal = new EternalGoal(name, completionStatus, points);
                    }
                    else{
                        goal = new Goal(name, completionStatus, points);
                    }

                    loadedGoals.Add(goal);
                }
            }
        }
        else
        {
            Console.WriteLine("No existing goals found. Initializing an empty list.");
        }

        return loadedGoals;
    }

    // Manages user interactions and processes their chosen actions.
    static void ProcessUserActions(List<Goal> goals){
        Console.WriteLine("1. Create Goal\n2. Record Event\n3. Show Goals\n4. Display User's Score\n5. Exit");
        bool exit = false;
        // Handles user input for goal actions.
        while (!exit)
        {
            Console.Write("Enter your choice: ");
            if (int.TryParse(Console.ReadLine(), out int choice)){
                switch (choice){
                    case 1:
                        CreateGoal(goals);
                        break;
                    case 2:
                        RecordEvent(goals);
                        break;
                    case 3:
                        ShowGoals(goals);
                        break;
                    case 4:
                        DisplayUserScore(goals);
                        break;
                    case 5:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else{
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }

    // Collects user input to create a new goal and adds it to the list.
    static void CreateGoal(List<Goal> goals){
        Console.WriteLine("Creating a Goal:");
        // Collects information for a new goal.
        Console.Write("Enter Goal Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter Goal Description: ");
        string description = Console.ReadLine();
        Console.Write("Enter Amount of Points: ");
        int amountPoints;
        while (!int.TryParse(Console.ReadLine(), out amountPoints)){
            Console.WriteLine("Invalid input. Please enter a valid number.");
            Console.Write("Enter Amount of Points: ");
        }
        // Provides options for goal selection.
        Console.WriteLine("Select Goal Type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        int type;
        while (!int.TryParse(Console.ReadLine(), out type) || (type < 1 || type > 3)){
            Console.WriteLine("Invalid choice. Please enter a number between 1 and 3.");
            Console.WriteLine("Select Goal Type:");
        }

        Goal goal;
        // Creates different goal types based on user input.
        switch (type){
            case 1:
                goal = new SimpleGoal(name, description, amountPoints);
                break;
            case 2:
                goal = new EternalGoal(name, description, amountPoints);
                break;
            case 3:
                Console.Write("Enter Times to Accomplish Goal: ");
                int timesToAccomplish;
                while (!int.TryParse(Console.ReadLine(), out timesToAccomplish))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    Console.Write("Enter Times to Accomplish Goal: ");
                }
                goal = new CheckListGoal(name, description, amountPoints, timesToAccomplish);
                break;
            default:
                goal = new Goal(name, description, amountPoints);
                break;
        }
        goals.Add(goal);
        Console.WriteLine("Goal created successfully!");
    }

    // Records an event for a selected goal and updates status.
    static void RecordEvent(List<Goal> goals){
        Console.WriteLine("Recording an Event:");
        ShowGoals(goals);
        Console.Write("Select a Goal to Record Event (Enter Goal Number): ");
        if (int.TryParse(Console.ReadLine(), out int goalNumber) && goalNumber >= 0 && goalNumber < goals.Count)
        {
            goals[goalNumber].RecordEvent();
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    // Displays the list of goals with completion status and points.
    static void ShowGoals(List<Goal> goals){
        Console.WriteLine("List of Goals:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i}. {goals[i].GetName()} - Completion: {goals[i].GetCompletion()} - Points: {goals[i].GetPoints()}");
        }
    }

    // Calculates and displays the total score of all completed goals.
    static void DisplayUserScore(List<Goal> goals){
        int totalScore = 0;
        foreach (Goal goal in goals)
        {
            totalScore += goal.GetPoints();
        }
        Console.WriteLine($"Total User Score: {totalScore}");
    }

    // Updates the file with most recently updated goal information.
    static void SaveGoals(List<Goal> goals){
        List<string> updatedLines = new List<string>();
        // Checks for the existing file and updates goal information.
        if (File.Exists("prove/Develop05/Goals.txt")){
            string[] lines = File.ReadAllLines("prove/Develop05/Goals.txt");
            
            foreach (var line in lines){
                string[] goalData = line.Split(',');
                string name = goalData[0].Trim();
                string completionStatus = goalData[1].Trim();
                int points = int.Parse(goalData[2].Trim());

                Goal existingGoal = goals.Find(g => g.GetName() == name);
                if (existingGoal != null){
                    if (existingGoal.GetCompletion() == "[X]" && completionStatus == "[ ]"){
                        // Updates completion status to 'Completed' in the file.
                        updatedLines.Add($"{name}, Completed, {points}");
                    }
                    else if (existingGoal is CheckListGoal checklistGoal && completionStatus != "[ ]"){
                        // Updates times completed for the ChecklistGoal in the file.
                        string[] completionParts = completionStatus.Split('/');
                        int timesCompleted = int.Parse(completionParts[0].Substring(completionParts[0].LastIndexOf(' ') + 1));
                        string updatedCompletionStatus = $"Completed {checklistGoal.GetTimesAccomplished()}/{timesCompleted} times";
                        updatedLines.Add($"{name}, {updatedCompletionStatus}, {points}");
                    }
                    else{
                        updatedLines.Add($"{name}, {completionStatus}, {points}");
                    }
                }
                else{
                    updatedLines.Add($"{name}, {completionStatus}, {points}");
                }
            }
        }
        else{
            Console.WriteLine("No existing goals found. Initializing an empty list.");
        }

        // Writes the updated goal information to the file.
        File.WriteAllLines("prove/Develop05/Goals.txt", updatedLines);
        Console.WriteLine("Goals saved to file.");
    }
}