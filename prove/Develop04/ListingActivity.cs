using System;
using System.Collections.Generic;
using System.Threading;

class ListeningActivity : Activity {
    // Property to store prompts specific to ListeningActivity
    private List<string> Prompts { get; }

    // Constructor for ListeningActivity
    public ListeningActivity() : base("Listening Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0, PauseType.Spinner) {
        // Initialize the prompts specific to the ListeningActivity
        Prompts = new List<string> {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes"
        };
    }

    // Overrides the RunActivitySpecific method to implement ListeningActivity-specific behavior
    protected override void RunActivitySpecific() {

        // Randomly selects and displays a prompt from the list
        string randomPrompt = Prompts[new Random().Next(Prompts.Count)];
        Console.WriteLine($"Prompt: {randomPrompt}");

        // Display a message to prepare the user to start listing items
        Console.WriteLine("Get ready to start listing items.");
        Thread.Sleep(3000);

        int itemCount = 0;

        // Loop for the specified duration
        for (int i = 0; i < Duration; i++) {
            if (i != 0) {
                // Display a countdown before prompting for the next item
                DisplayCountdown(3);
            }

            // Prompt the user to input an item
            Console.WriteLine($"Item {itemCount + 1}: ");
            string item = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(item)) {
                itemCount++;
            }
        }

        // Display the number of items listed by the user
        Console.WriteLine($"You've listed {itemCount} items.");
    }
}