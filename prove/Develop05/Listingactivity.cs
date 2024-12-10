public class ListingActivity : MindfulnessActivity
{
    private static readonly string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?"
    };

    protected override void Run()
    {
        Random rand = new Random();
        string selectedPrompt = prompts[rand.Next(prompts.Length)];
        Console.WriteLine(selectedPrompt);

        Console.WriteLine("Start listing your responses:");
        Pause(5); // Countdown to begin

        int count = 0;
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Enter an item: ");
            string response = Console.ReadLine();
            if (!string.IsNullOrEmpty(response))
            {
                count++;
            }
        }

        Console.WriteLine($"You listed {count} items!");
    }

    protected override string GetActivityDescription()
    {
        return "reflecting on the good things in your life by listing as many positive items as you can.";
    }
}
