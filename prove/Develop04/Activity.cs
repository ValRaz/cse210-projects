using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

class Activity
{
    protected string Name { get; private set; }
    private string Description { get; }
    protected int Duration { get; private set; }
    private PauseType ActivityPauseType { get; }
    private DateTime TimeToPause { get; set; }

    public enum PauseType {
        Spinner, Countdown
    }

    // Activity constructor
    public Activity(string name, string description) {
        Name = name;
        Description = description;
    }

    // Starting message
    protected string StartingMessage() {
        return $"Welcome to {Name}!\n{Description}\nPlease set the Duration for this activity in seconds.";
    }

    // Ending message
    protected string EndingMessage() {
        return $"You've completed {Duration} seconds of {Name} today, well done!";
    }

    // Display animation during pauses
    protected void DisplayAnimation(int durationInSeconds) {
        string[] spinnerSequence = { "|", "/", "-", "\\" };
        int spinnerIndex = 0;

        DateTime endTime = DateTime.Now.AddSeconds(durationInSeconds);

        while (DateTime.Now < endTime) {
            Console.Write($"{spinnerSequence[spinnerIndex]}\r");
            spinnerIndex = (spinnerIndex + 1) % spinnerSequence.Length;
            Thread.Sleep(500);
        }

        Console.Write($"{new string(' ', spinnerSequence[spinnerIndex].Length)}\r");
    }

    // Set activity duration based on user input
    public void SetDurationFromUserInput() {
        Console.WriteLine(StartingMessage());
        Duration = int.Parse(Console.ReadLine());
    }

    // Display a countdown during pauses
    protected void DisplayCountdown(int seconds) {
        for (int countdown = seconds; countdown > 0; countdown--) {
            Console.WriteLine(countdown);
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}