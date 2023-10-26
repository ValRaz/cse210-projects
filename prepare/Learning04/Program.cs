using System;

class Program
{
    static void Main(string[] args)
    {
        //Assignment class test
        Assignment assignmentTest = new Assignment("David James", "Division");
        Console.WriteLine(assignmentTest.GetSummary());

        //MathAssignment class test
        MathAssignment mathAssignmentTest = new MathAssignment("Justine Farwater", "Calculus", "Section 8.9", "Problems 8-35");
        Console.WriteLine(mathAssignmentTest.GetHomeworkList());

        //WritingAssignment class test
        WritingAssignment writingAssignmentTest = new WritingAssignment("Samantha Blankenship", "Leaps in Quantum Computing", "The Creation of a Time Crystal");
        Console.WriteLine(writingAssignmentTest.GetWritingInformation());
    }
}