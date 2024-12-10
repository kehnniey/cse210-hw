public class BreathingActivity : MindfulnessActivity
{
    protected override void Run()
    {
        for (int i = 0; i < duration / 4; i++) // Each cycle is 4 seconds
        {
            Console.WriteLine("Breathe in...");
            Pause(2);  // Pause for 2 seconds 

            Console.WriteLine("Breathe out...");
            Pause(2);  
        }
    }

    protected override string GetActivityDescription()
    {
        return "helping you relax by guiding your breathing in and out slowly. Clear your mind and focus on your breathing.";
    }
}
