using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

class ListingActivity : Activity {
    // Property to store prompts specific to ListingActivity
    private List<string> Prompts { get; }

    // Constructor for ListeningActivity
    public ListingActivity() : base("Listening Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") {
        // Initialize the prompts specific to the ListingActivity
        Prompts = new List<string> {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes"
        };
    }

    // Run the ListeningActivity
    public void RunListingActivity() {
        SetDurationFromUserInput();

        // Call DisplayAnimation method for 3 seconds
        DisplayAnimation(3);

        DateTime endTime = DateTime.Now.AddSeconds(Duration);

        int itemCount = 0;

        while (DateTime.Now < endTime) {
            // Randomly selects and displays a prompt from the list
            string randomPrompt = Prompts[new Random().Next(Prompts.Count)];
            Console.WriteLine($"Prompt: {randomPrompt}");

            // Display a countdown before prompting for the next item
            DisplayCountdown(3);

            // Prompt the user to input an item
            Console.WriteLine($"Item {itemCount + 1}: ");
            string item = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(item)) {
                itemCount++;
            }
        }

        Console.WriteLine($"You've listed {itemCount} items.");
    }
}