using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine("Learning Activity - C# Prep 5");
        Console.WriteLine("------------------------------");
        Console.WriteLine("");

        DisplayWelcome("Welcome to the Program!");
        string name = PromptUserName("Please enter your name: ");
        int number = PromptUserNumber("Please enter your favorite number: ");
        int squaredNumber = SquareNumber(number);
        DisplayResult(name, squaredNumber);
    }

    static void DisplayWelcome(string message)
    {
        Console.WriteLine(message);
    }

    static string PromptUserName(string prompt)
    {   
        Console.Write(prompt);
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber(string prompt)
    {
        Console.Write(prompt);
        string userNumber = Console.ReadLine();
        int intNumber = int.Parse(userNumber);
        return intNumber;
    }

    static int SquareNumber(int numberToSquare)
    {
        int square = numberToSquare * numberToSquare;
        return square;
    }

    static void DisplayResult(string userName, int squaredNumber)
    {
        Console.WriteLine($"{userName}, the square of you number is {squaredNumber}");
    }
}