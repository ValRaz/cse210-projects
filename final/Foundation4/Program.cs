using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Creates running activities
        Activity running1 = new Running(new DateTime(2023, 5, 4), 45, 4.7);
        Activity running2 = new Running(new DateTime(2023, 7, 16), 30, 3.2);

        //Creates Cycling activities
        Activity cycling1 = new Cycling(new DateTime(2023, 7, 9), 45, 30);
        Activity cycling2 = new Cycling(new DateTime(2023, 7, 10), 45, 30);

        //Creates swimming activities
        Activity swimming1 = new Swimming(new DateTime(2023, 8, 5), 67, 37);
        Activity swimming2 = new Swimming(new DateTime(2023, 8, 17), 55, 45);

        //Adds activities to a list
        var activities = new List<Activity>();
        activities.Add(running1);
        activities.Add(running2);
        activities.Add(cycling1);
        activities.Add(cycling2);
        activities.Add(swimming1);
        activities.Add(swimming2);

        foreach(var activity in activities) {
            Console.WriteLine(activity.GetSummary());
        }
    }
}