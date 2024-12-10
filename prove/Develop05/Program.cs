class Program
{
    static void Main()
    {
        while (true) 
        {
            Console.WriteLine("\nChoose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            
            if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > 4)
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                continue; 
            }

            if (choice == 4) 
            {
                Console.WriteLine("Thank you for using the Mindfulness Program. Goodbye!");
                break; 
            }

            // Create the selected activity
            MindfulnessActivity activity = choice switch
            {
                1 => new BreathingActivity(),
                2 => new ReflectionActivity(),
                3 => new ListingActivity(),
                _ => null
            };

            // Start the activity if the available choice was made
            activity?.StartActivity();
        }
    }
}
