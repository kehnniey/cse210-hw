using System;
using System.Threading;

public abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void StartActivity()
    {
        DisplayStartingMessage();
        SetDuration();
        ShowCountDown(3);
        Run();
        DisplayEndingMessage();
    }

    protected abstract void Run();

    protected void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {_name} activity.");
        Console.WriteLine(_description);
    }

    protected void DisplayEndingMessage()
    {
        Console.WriteLine("Well done! You've completed the activity.");
        Console.WriteLine($"You spent {_duration} seconds on the {_name} activity.");
        ShowSpinner(5);
    }

    protected void SetDuration()
    {
        Console.Write("Enter the duration of the activity in seconds: ");
        _duration = int.Parse(Console.ReadLine());
    }

    protected void ShowSpinner(int seconds)
    {
        Console.Write("Loading ");
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    protected void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine($"Starting in {i}...");
            Thread.Sleep(1000);
        }
    }
}
