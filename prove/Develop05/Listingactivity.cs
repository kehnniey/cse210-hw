using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are your personal strengths?",
        "Who have you helped this week?"
    };

    public ListingActivity()
        : base("Listing", "This activity helps you reflect by listing positive aspects of your life.") { }

    protected override void Run()
    {
        var random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine(prompt);

        Console.WriteLine("Start listing your responses:");
        ShowCountDown(5);

        int count = 0;
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Enter a response: ");
            string response = Console.ReadLine();
            if (!string.IsNullOrEmpty(response))
            {
                count++;
            }
        }

        Console.WriteLine($"You listed {count} items!");
    }
}
