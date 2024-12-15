using System;

class Program
{
    // Main entry point of the application.
    static void Main(string[] args)
    {
        // Display a welcome message when the program starts.
        Console.WriteLine("Welcome to the Goal Tracker!");

        // Create an instance of the GoalManager class.
        GoalManager goalManager = new GoalManager();

        // Start the goal tracking process (displays menu and handles user interaction).
        goalManager.Start();

        // Display a goodbye message when the program ends.
        Console.WriteLine("Thank you for using the Goal Tracker. Goodbye!");
    }
}
