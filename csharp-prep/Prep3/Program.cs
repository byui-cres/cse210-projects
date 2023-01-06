using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Guess My Number!");
        Console.WriteLine("Note: I do not want to remove the core requirements. I let the user choose instead...");
        Console.WriteLine();
        Console.WriteLine("type '1' to randomly generate number, '2' to manually enter a number ");
        Console.WriteLine();
        Console.Write("Answer: ");
        string mode = Console.ReadLine();
        int guessNumber = 0;
        int magicNumber = 0;
        Console.WriteLine();
        if (mode == "1")
        {
        Console.WriteLine("Generating random number from 1 to 100...");
        Random randomNumber = new Random();
        magicNumber = randomNumber.Next(1, 100); 
        }
        else
        {
        Console.Write("What is the magic number? ");
        string magicInput = Console.ReadLine();
        magicNumber = int.Parse(magicInput);   
        }
        Console.WriteLine();
        do
        {
        Console.Write("What is your guess? ");
        string guessInput = Console.ReadLine();
        guessNumber = int.Parse(guessInput);
        //Console.WriteLine(magicNumber);
        if (guessNumber < magicNumber)
        {
            Console.WriteLine("Higher");
            Console.WriteLine();
        }
        else if (guessNumber > magicNumber)
        {
            Console.WriteLine("Lower");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine($"Congratulations! {guessNumber} is correct!");
        }
        }
        while (guessNumber != magicNumber);

        Console.WriteLine();
       
    }
}