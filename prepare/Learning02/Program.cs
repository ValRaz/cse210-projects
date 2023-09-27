using System;
using System.IO.Pipes;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Squire PC";
        job1._startYear = 2000;
        job1._endYear = 2017;
        //Creates job1 instance of the Job class

        Job job2 = new Job();
        job2._jobTitle = "Senior Software Engineer";
        job2._company = "Apple";
        job2._startYear = 2017;
        job2._endYear = 2023;
        //Creates job2 instance of the Job class

        Resume resume1 = new Resume();
        resume1._name = "Jayde Barr";

        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.ShowJobInfo();
    }
}