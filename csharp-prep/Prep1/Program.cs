using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string firstname = Console.ReadLine();
        //Retrieves user input storing data in the firstname variable

        Console.Write("What is your last name? ");
        string lastname = Console.ReadLine();
        //Retrieves user input storing data in the lastname variable

        Console.WriteLine($"Your name is {lastname}, {firstname} {lastname}.");
        //Prints Bond style naming to the terminal

    }
}