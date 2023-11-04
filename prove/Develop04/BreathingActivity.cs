using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

class BreathingActivity : Activity {
    // Properties to store messages and settings specific to BreathingActivity
    private string BreathingInMsg { get; }
    private string BreathingOutMsg { get; }
    private int SecondsForCountdown { get; }

    // Constructor for BreathingActivity
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by guiding you in a conscious breathing exercise. Please clear your mind and focus on your breathing.") {
        // Initialize messages and settings
        BreathingInMsg = "Breathe in...";
        BreathingOutMsg = "Breathe out...";
        SecondsForCountdown = 5;
    }

    // Run the BreathingActivity
    public void RunBreathingActivity() {
        SetDurationFromUserInput();
        DateTime endTime = DateTime.Now.AddSeconds(Duration);

        // Call DisplayAnimation method
        DisplayAnimation(5);

        while (DateTime.Now < endTime) {
         // Perform breathing exercise for the specified duration
            // Display "Breathe in..." message
            Console.WriteLine(BreathingInMsg);

            // Perform a countdown for inhaling
            DisplayCountdown(SecondsForCountdown);

            // Display "Breathe out..." message
            Console.WriteLine(BreathingOutMsg);

            // Perform a countdown for exhaling
            DisplayCountdown(SecondsForCountdown);
        }

        // Display the ending message
        Console.WriteLine(EndingMessage());
        Thread.Sleep(3000);
    }
}