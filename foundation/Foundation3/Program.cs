using System;
using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            // Create activities
            Running run1 = new Running(new DateTime(2022, 11, 3), 30, 4.8);
            Cycling cycle1 = new Cycling(new DateTime(2022, 11, 4), 45, 20);
            Swimming swim1 = new Swimming(new DateTime(2022, 11, 5), 25, 20);

            // Add activities to a list
            List<Activity> activities = new List<Activity> { run1, cycle1, swim1 };

            // Display summaries
            foreach (Activity activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }

