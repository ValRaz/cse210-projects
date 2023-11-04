using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

class ReflectingActivity : Activity {
    // List to store reflection prompts
    private List<string> _reflectionPrompts { get; }

    // List to store reflection questions
    private List<string> _reflectionQuestions { get; }

    // Constructor for ReflectingActivity
    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.") {
        // Initialize the reflection prompts
        _reflectionPrompts = new List<string> {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        // Initialize the reflection questions
        _reflectionQuestions = new List<string> {
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

    // Run the ReflectingActivity
    public void RunReflectingActivity() {
        SetDurationFromUserInput();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        Random random = new Random();
        int remainingDuration = _duration;

        while (DateTime.Now < endTime) {
            // Randomly selects and displays a prompt from the list
            string randomPrompt = _reflectionPrompts[random.Next(_reflectionPrompts.Count)];
            Console.WriteLine(randomPrompt);

            // Pause for reflection
            DisplayAnimation(5);
            Thread.Sleep(3000);

            string randomQuestion = _reflectionQuestions[random.Next(_reflectionQuestions.Count)];
            Console.WriteLine(randomQuestion);

            // Pause for reflection
            DisplayAnimation(5);
            Thread.Sleep(3000);

            remainingDuration -= 10;
        }
    }
}