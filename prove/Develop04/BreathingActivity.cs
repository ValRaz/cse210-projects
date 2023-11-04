using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

class BreathingActivity : Activity {
    // Properties to store messages and settings specific to BreathingActivity
    private string _breathingInMsg { get; }
    private string _breathingOutMsg { get; }
    private int _secondsForCountdown { get; }

    // Constructor for BreathingActivity
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by guiding you in a conscious breathing exercise. Please clear your mind and focus on your breathing.") {
        // Initialize messages and settings
        _breathingInMsg = "Breathe in...";
        _breathingOutMsg = "Breathe out...";
        _secondsForCountdown = 5;
    }

    // Run the BreathingActivity
    public void RunBreathingActivity() {
        SetDurationFromUserInput();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        // Call DisplayAnimation method
        DisplayAnimation(5);

        while (DateTime.Now < endTime) {
            // Perform breathing exercise for the specified duration
            // Display "Breathe in..." message
            Console.WriteLine(_breathingInMsg);

            // Perform a countdown for inhaling
            DisplayCountdown(_secondsForCountdown);

            // Display "Breathe out..." message
            Console.WriteLine(_breathingOutMsg);

            // Perform a countdown for exhaling
            DisplayCountdown(_secondsForCountdown);
        }

        // Display the ending message
        Console.WriteLine(EndingMessage());
        Thread.Sleep(3000);
    }
}