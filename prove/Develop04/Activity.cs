using System;
using System.Collections.Generic;
using System.Threading;

class Activity {
    protected string Name { get; private set; }
    private string Description { get; }
    protected int Duration { get; private set; }
    private PauseType ActivityPauseType { get; }
    private DateTime TimeToPause { get; set; }

    public enum PauseType {
        Spinner, Countdown
    }

    // Activity constructor
    public Activity(string name, string description, int duration, PauseType pauseType) {
        Name = name;
        Description = description;
        Duration = duration;
        ActivityPauseType = pauseType;
        TimeToPause = DateTime.Now;
    }

    // Starting message
    protected string StartingMessage() {
        return $"Welcome to {Name}!\n{Description}\nPlease set the Duration for this activity in seconds.";
    }

    // Ending message
    protected string EndingMessage() {
        return $"You've completed {Duration} of {Name} today, well done!";
    }

    // Display animation during pauses
    protected void DisplayAnimation() {
        string[] spinnerSequence = { "|", "/", "-", "\\" };
        int spinnerIndex = 0;

        for (int i = 0; i < Duration; i++) {
            Console.Write($"{spinnerSequence[spinnerIndex]}\r");
            spinnerIndex = (spinnerIndex + 1) % spinnerSequence.Length;
            Thread.Sleep(500);
        }

        Console.Write($"{new string(' ', spinnerSequence[spinnerIndex].Length)}\r");
    }

    // Run activity method
    public void RunActivity() {
        Console.WriteLine(StartingMessage());
        int userDuration = int.Parse(Console.ReadLine());

        Console.WriteLine("Please get ready to start");
        Thread.Sleep(3000);

        for (int i = 0; i < Duration; i++) {
            DisplayAnimation();
            Thread.Sleep(1000);
        }

        RunActivitySpecific();

        Console.WriteLine(EndingMessage());
    }

    // Activity-specific code for derived classes
    protected virtual void RunActivitySpecific() {
        // This will be overridden in the derived classes
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