using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        Console.WriteLine("------------------------------");
        Console.WriteLine("CSE 210: Programming with Classes");
        Console.WriteLine("W03 Prepare: Learning Activity");
        Console.WriteLine("Abstraction Learning Activity");
        Console.WriteLine("");
        Resume resume1 = new Resume();
        resume1._name = "Allison Rose";
        resume1.Display();

        Console.WriteLine("JOBS: ");
        Job job1 = new Job();
        job1._company = "IBM";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 1970;
        job1._endYear = 2022;
        job1.Display();
        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 1980;
        job2._endYear = 2023;
        job2.Display();
        
        Console.WriteLine("");
        Resume resume2 = new Resume();
        resume2._name = "Chres Pabalate";
        resume2.Display();

        Console.WriteLine("JOBS: ");
        Job job3 = new Job();
        job3._company = "Doodle-Ads";
        job3._jobTitle = "Web Admin";
        job3._startYear = 2010;
        job3._endYear = 2022;
        job3.Display();

        Job job4 = new Job();
        job4._company = "Piimag";
        job4._jobTitle = "Web Admin";
        job4._startYear = 2010;
        job4._endYear = 2023;
        job4.Display();



    }
}