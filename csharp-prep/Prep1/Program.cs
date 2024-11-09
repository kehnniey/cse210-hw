using System; 

class Program
{
    // Main method - the entry point of the program
    static void Main(string[] args)
    {
        // Display a welcome message to the user
        Console.WriteLine("Hello Prep1 World!");

        // Ask the user for their first name
        Console.WriteLine("What is your first name?");
        string firstname = Console.ReadLine(); // Store the user's input as their first name

        // Ask the user for their last name
        Console.WriteLine("What is your last name?");
        string lastname = Console.ReadLine(); // Store the user's input as their last name

        // Display the user's full name in a formatted string
        Console.WriteLine($"Your name is {firstname}, {firstname} {lastname}");
    }
}
