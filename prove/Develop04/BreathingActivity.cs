using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

class BreathingActivity : Activity {
    // Properties to store messages and settings specific to BreathingActivity
    private string BreathingWelcomeMsg { get; }
    private string BreathingDescription { get; }
    private string BreathingInMsg { get; }
    private string BreathingOutMsg { get; }
    private int SecondsForCountdown { get; }

    // Constructor for BreathingActivity
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by guiding you in a conscious breathing exercise. Please clear your mind and focus on your breathing.", 0, PauseType.Countdown) {
        // Initialize messages and settings
        BreathingWelcomeMsg = "Welcome to the Breathing Activity!";
        BreathingDescription = "This activity will help you relax by guiding you in a conscious breathing exercise. Please clear your mind and focus on your breathing.";
        BreathingInMsg = "Breathe in...";
        BreathingOutMsg = "Breathe out...";
        SecondsForCountdown = 5;
    }

    // Override the RunActivitySpecific method to implement BreathingActivity-specific behavior
    protected override void RunActivitySpecific() {

        // Perform breathing exercise for the specified duration
        for (int i = 0; i < Duration; i++) {
            // Display "Breathe in..." message
            Console.WriteLine(BreathingInMsg);

            // Perform a countdown for inhaling
            DisplayCountdown(SecondsForCountdown);

            // Display "Breathe out..." message
            Console.WriteLine(BreathingOutMsg);

            // Perform a countdown for exhaling
            DisplayCountdown(SecondsForCountdown);
        }
    }
}