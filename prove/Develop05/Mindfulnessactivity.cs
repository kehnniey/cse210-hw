using System;
using System.Threading;

public abstract class MindfulnessActivity
{
    protected int duration; // Duration in seconds

    public void StartActivity()
    {
        DisplayStartMessage();
        SetDuration();
        PrepareToBegin();
        Run();
        DisplayEndMessage();
    }

    // Abstract method for activity execution
    protected abstract void Run();

    private void DisplayStartMessage()
    {
        Console.WriteLine($"Starting the {this.GetType().Name}...");
        Console.WriteLine($"This activity will help you with {GetActivityDescription()}.");
    }

    private void SetDuration()
    {
        Console.Write("Enter the duration of the activity in seconds: ");
        duration = int.Parse(Console.ReadLine());
    }

    private void PrepareToBegin()
    {
        Console.WriteLine("Get ready to begin...");
        Pause(5);  // Wait for a few seconds before starting
    }

    private void DisplayEndMessage()
    {
        Console.WriteLine("Well done! You've completed the activity.");
        Console.WriteLine($"You spent {duration} seconds on this activity.");
        Pause(5);  // Wait for a few seconds before finishing
    }

   
    protected void Pause(int seconds)
{
    for (int i = seconds; i > 0; i--)
    {
        Console.Write($"\r{i} seconds remaining... "); // Display remaining seconds
        Thread.Sleep(1000);
    }
    Console.WriteLine(); // Move to the next line after the pause
}

    protected abstract string GetActivityDescription(); 
}
