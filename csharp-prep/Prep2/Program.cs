using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine("Core Requirements...");
        Console.WriteLine("");
        Console.Write("What is your grade percentage? ");
        string gradeInput = Console.ReadLine();
        float grade = float.Parse(gradeInput);
        string letter = "";

        int lastDigit = (int)(grade % 10);
        //Console.WriteLine(lastDigit);

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        string positive = "+";
        string negative = "-";
        if (grade < 97 && grade >= 60)
        {
            if (lastDigit >= 7)
            {
                letter = letter + positive;
            }
            else if (lastDigit < 3)
            {
                letter = letter + negative;
            }
        }
        

        Console.WriteLine($"Your grade: {grade} = {letter}"); 
        Console.WriteLine("");

        float passingGrade = 70;

        if (passingGrade >= 70)
        {
            Console.WriteLine("Congratulations! You passed...");
        }
        else
        {
            Console.WriteLine("Don't Worry you can still do best next time.");
        }

        Console.WriteLine("");
    }
}