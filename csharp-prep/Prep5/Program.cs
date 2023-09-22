using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        
        string userName = PromptUserName();
        int faveNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(faveNumber);
        
        DisplayResult(userName, squaredNumber);
    }
    //calls each declared function displaying output where appropriate

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    //declares a function to display a welcome message

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }
    //declares function to accept user name input

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string userInput = Console.ReadLine();
        return int.Parse(userInput);
    }
    //declares funtction to get user number input

    static int SquareNumber(int number)
    {
        return number * number;
    }
    //declares function to calculate the square of the user's number

    static void DisplayResult(string userName, int squaredNumber)
    {
        Console.WriteLine($"{userName}, the square of your number is {squaredNumber}");
    }
    //declares function to display the calculated square of users number
}
   