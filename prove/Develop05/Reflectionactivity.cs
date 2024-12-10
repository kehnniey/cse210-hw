public class ReflectionActivity : MindfulnessActivity
{
    private static readonly string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need."
    };

    private static readonly string[] questions = {
        "Why was this experience meaningful to you?",
        "How did you feel when it was complete?",
        "What did you learn about yourself?"
    };

    protected override void Run()
    {
        Random rand = new Random();
        string selectedPrompt = prompts[rand.Next(prompts.Length)];
        Console.WriteLine(selectedPrompt);
        Pause(5);  // Pause before starting to reflect

        foreach (var question in questions)
        {
            Console.WriteLine(question);
            Pause(5);  // Pause for user to reflect and think
        }
    }

    protected override string GetActivityDescription()
    {
        return "reflecting on times in your life when you have shown strength and resilience.";
    }
}
