using System;

    class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();
            bool isRunning = true;

            Console.WriteLine("Welcome to the Journal Program!");

            while (isRunning)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Write a new journal entry");
                Console.WriteLine("2. Display the journal");
                Console.WriteLine("3. Save the journal to a file");
                Console.WriteLine("4. Load the journal from a file");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice (1-5): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        WriteNewEntry(journal);
                        break;

                    case "2":
                        journal.Display();
                        break;

                    case "3":
                        Console.Write("\nEnter filename to save the journal: ");
                        string saveFilename = Console.ReadLine();
                        journal.Save(saveFilename);
                        break;

                    case "4":
                        Console.Write("\nEnter filename to load the journal: ");
                        string loadFilename = Console.ReadLine();
                        journal.Load(loadFilename);
                        break;

                    case "5":
                        isRunning = false;
                        Console.WriteLine("\nGoodbye! See you later");
                        break;

                    default:
                        Console.WriteLine("\nInvalid choice. Please try again.");
                        break;
                }
            }
        }

        // Write a new journal entry
        private static void WriteNewEntry(Journal journal)
        {
            // Use PromptGenerator to select a random prompt
            string prompt = PromptGenerator.SelectPrompt();
            Console.WriteLine($"\nPrompt: {prompt}");
            Console.Write("Your response: ");
            string response = Console.ReadLine();
            string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            Entry newEntry = new Entry(date, prompt, response);
            journal.AddEntry(newEntry);

            Console.WriteLine("\nNew entry added to the journal.");
        }
    }

