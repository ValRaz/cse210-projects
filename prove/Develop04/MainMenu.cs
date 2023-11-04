using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

class MainMenu {
    public void ShowMenu() {
        List<string> activityNames = new List<string> {
            "Breathing Activity",
            "Listening Activity",
            "Reflecting Activity",
            "Quit"
        };

        while (true) {
            // Display the main menu and handle user input.
            Console.WriteLine("Main Menu:");
            Console.WriteLine("Select an activity to start:");

            // Display the list of available activities and options.
            for (int i = 0; i < activityNames.Count; i++) {
                Console.WriteLine($"{i + 1}. {activityNames[i]}");
            }

            int choice;

            if (int.TryParse(Console.ReadLine(), out choice)) {
                if (choice == activityNames.Count) {
                    // Exit the program if the user chooses to quit.
                    Console.WriteLine("Goodbye!");
                    break;
                }
                else if (choice > 0 && choice <= activityNames.Count) {
                    switch (choice) {
                        case 1:
                            BreathingActivity breathingActivity = new BreathingActivity();
                            Console.Clear();
                            breathingActivity.RunBreathingActivity();
                            Console.Clear();
                            break;
                        case 2:
                            ListingActivity listingActivity = new ListingActivity();
                            Console.Clear();
                            listingActivity.RunListingActivity();
                            Console.Clear();
                            break;
                        case 3:
                            ReflectingActivity reflectingActivity = new ReflectingActivity();
                            Console.Clear();
                            reflectingActivity.RunReflectingActivity();
                            Console.Clear();
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please select a valid activity.");
                            break;
                    }
                }
                else {
                    Console.WriteLine("Invalid choice. Please select a valid activity.");
                }
            }
            else {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }
}