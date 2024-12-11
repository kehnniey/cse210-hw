using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing", "This activity helps you relax by guiding your breathing slowly.") { }

    protected override void Run()
    {
        for (int i = 0; i < _duration / 4; i++)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(2);
            Console.WriteLine("Breathe out...");
            ShowCountDown(2);
        }
    }
}
