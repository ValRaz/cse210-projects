using System;
using System.Collections.Generic;
using System.Linq; // Import the LINQ library for sorting

class Program
{
    static void Main(string[] args)
    {
        List<int> numberList = new List<int>();

        int userNumber = 1;
        while (userNumber != 0)
        {
            Console.Write("Enter a number (0 to quit): ");

            string userData = Console.ReadLine();
            userNumber = int.Parse(userData);

            numberList.Add(userNumber);
        }
        //Gathers numbers from the user and stores them as values in a list.
        
        numberList.RemoveAt(numberList.Count - 1);
        // Removes the last 0 from the list as it was used to exit the loop

        int sum = numberList.Sum();
        Console.WriteLine($"The sum is: {sum}");
        // Calculates and displays the sum of the entered numbers

        float average = (float)sum / numberList.Count;
        Console.WriteLine($"The average is: {average}");
        // Calculate and display the average of the entered numbers

        int max = numberList.Max();
        Console.WriteLine($"The largest number is: {max}");
        // Finds and displays the largest number in the list

        int smallestPositive = numberList.Where(n => n > 0).DefaultIfEmpty(0).Min();
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        // Finds and displays the smallest positive number closest to zero

        numberList.Sort();

        Console.WriteLine("The sorted list is:");
        foreach (int number in numberList)
        {
            Console.WriteLine(number);
        }
        // Sorts the list and displays the sorted values
    }
}