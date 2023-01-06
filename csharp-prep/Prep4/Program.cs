using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine("Learning Activity - C# Prep 4");
        Console.WriteLine("------------------------------");
        Console.WriteLine("Core Requirements & Strech challenge");
        Console.WriteLine("");
        Console.WriteLine("Enter a list of numbers including negative numbers, type '0' when finished...");
        // Declare variables
        List<int> numList = new List<int>();
        int newNum = -1;
        int sum = -1;
        int smallest = 9999;
        int smallestPositive = 9999;
        int largest = -1;
        
        
        // Loop until user enters zero
        do
        {
            Console.Write("Enter number: ");
            string numInput = Console.ReadLine();
            newNum = int.Parse(numInput);
            // Adding all list entries except 0
            if (newNum != 0)
            {numList.Add(newNum);}
        }
        while (newNum != 0);

        // finding the sum, smallest and largest number among the list of numbers
        foreach (int num in numList)
        {
            sum += num;
            if (smallest > num){
                smallest = num;
            }
            if (num > 0 && smallestPositive > num){
                smallestPositive = num;
            }
            
            if (largest < num){
                largest = num;
            }
        }

        // computing the average number in the list
        int numListCount = numList.Count;
        float average = ((float)sum) / numListCount;

        // Printing results

        Console.Write($"The number of items in the list: {numListCount}");
        Console.WriteLine();

        Console.Write($"The sum is: {sum}");
        Console.WriteLine();

        Console.Write($"The average is: {average}");
        Console.WriteLine();

        Console.Write($"The largest number is: {largest}");
        Console.WriteLine();

        Console.Write($"The smallest number is: {smallest}");
        Console.WriteLine();

        Console.Write($"The smallest positive number is: {smallestPositive}");
        Console.WriteLine();

        Console.Write("The sorted list is: ");

        // Sorting numbers
        numList.Sort();
        Console.WriteLine(string.Join(", ", numList));

    }
}