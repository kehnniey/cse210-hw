using System;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "How did you feel when it was complete?",
        "What did you learn about yourself?"
    };

    public ReflectingActivity()
        : base("Reflecting", "This activity helps you reflect on moments of strength and resilience.") { }

    protected override void Run()
    {
        var random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine(prompt);

        ShowCountDown(5);

        foreach (var question in _questions)
        {
            Console.WriteLine(question);
            ShowCountDown(5);
        }
    }
}
