using System;
using System.Collections.Generic;
using System.Threading;

class ReflectingActivity : Activity {
    // List to store reflection prompts
    private List<string> ReflectionPrompts { get; }
    
    // List to store reflection questions
    private List<string> ReflectionQuestions { get; }

    // Constructor for ReflectingActivity
    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0, PauseType.Spinner) {
        // Initialize the reflection prompts
        ReflectionPrompts = new List<string> {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        // Initialize the reflection questions
        ReflectionQuestions = new List<string> {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    // Override the RunActivitySpecific method to implement activity-specific logic
    protected override void RunActivitySpecific() {
        Random random = new Random();
        int remainingDuration = Duration;

        // Continue showing random prompts and questions until the specified duration is reached
        while (remainingDuration > 0) {
            string randomPrompt = ReflectionPrompts[random.Next(ReflectionPrompts.Count)];
            
            // Display a random reflection prompt
            Console.WriteLine(randomPrompt);

            // Pause for reflection
            DisplayAnimation();
            Thread.Sleep(3000);

            string randomQuestion = ReflectionQuestions[random.Next(ReflectionQuestions.Count)];
            
            // Display a random reflection question
            Console.WriteLine(randomQuestion);

            // Pause for reflection
            DisplayAnimation();
            Thread.Sleep(3000);

            remainingDuration -= 10; // Subtracting time for each prompt and question
        }
    }
}