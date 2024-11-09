using System;

using System.Collections.Generic;
using System.Linq;

class Program
{
     static void Main(string[] args)
    {
        // Initialize a list to store user input
        List<int> numbers = new List<int>();
        
        // Prompt the user for numbers until they enter 0
        int input;
        do
        {
            Console.Write("Enter a number (0 to stop): ");
            input = int.Parse(Console.ReadLine());

            if (input != 0)
            {
                numbers.Add(input);
            }

        } while (input != 0);

        // Core 1: Compute the sum of the numbers
        int sum = numbers.Sum();
        Console.WriteLine($"The sum of the numbers is: {sum}");

        // Core 2: Compute the average of the numbers
        double average = numbers.Count > 0 ? numbers.Average() : 0;
        Console.WriteLine($"The average of the numbers is: {average}");

        // Core 3: Find the maximum number in the list
        int max = numbers.Count > 0 ? numbers.Max() : 0;
        Console.WriteLine($"The maximum number is: {max}");
    }
}

