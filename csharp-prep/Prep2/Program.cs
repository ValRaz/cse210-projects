using System;

class Program
{
    static void Main(string[] args)
    {
        //Gathers grade percentage from user
        Console.Write("What is your grade percentage? ");
        string gradeInput = Console.ReadLine();

        //Converts user input to int
        int percentage = int.Parse(gradeInput);

        //defines letter grade variable
        string letterGrade = "";

        //Determines letter grade of user input
        if (percentage >= 90)
        {
            letterGrade = "A";
        }

        else if (percentage >= 80)
        {
            letterGrade = "B";
        }

        else if (percentage >= 70)
        {
            letterGrade = "C";
        }

        else if (percentage >= 60)
        {
            letterGrade = "D";
        }

        else
        {
            letterGrade = "F";
        }

        //Determines + or - of letter grade
        string gradeAdditional = "";

        if (percentage % 10 >= 7)
        {
            gradeAdditional = letterGrade + "+";
        }

        else
        {
            gradeAdditional = letterGrade + "-";
        }

        //Recognizes A + and F+/- and adjusts the output accordingly
        if (gradeAdditional == "A+")
        {
            gradeAdditional = "A";
        }

        else if (gradeAdditional == "F+")
        {
            gradeAdditional = "F";
        }

        else if (gradeAdditional == "F-")
        {
            gradeAdditional = "F";
        }

        //Determines pass/fail per percentage and prints apropriate response
        if (percentage >=70)
        {
            Console.WriteLine($"Your grade is {gradeAdditional}, passing this course. Great work!");
        }

        else
        {
            Console.WriteLine($"Your grade is {gradeAdditional}. Better luck next semester!");
        }

    }
}