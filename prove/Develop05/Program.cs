using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nChoose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflecting Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > 4)
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                continue;
            }

            if (choice == 4)
            {
                Console.WriteLine("Thank you for using the Mindfulness Program. Goodbye!");
                break;
            }

            Activity activity = choice switch
            {
                1 => new BreathingActivity(),
                2 => new ListingActivity(),
                3 => new ReflectingActivity(),
                _ => null
            };

            activity?.StartActivity();
        }
    }
}
