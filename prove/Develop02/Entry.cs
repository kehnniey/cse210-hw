
    public class Entry
    {
        // Attributes with public properties
        public string Date { get; }
        public string Prompt { get; }
        public string Response { get; }

        // Initializing my entry with date, prompt, and response
        public Entry(string date, string prompt, string response)
        {
            Date = date;
            Prompt = prompt;
            Response = response;
        }

        // I want this to Display a single entry
        public void Display()
        {
            Console.WriteLine($"Date: {Date}");
            Console.WriteLine($"Prompt: {Prompt}");
            Console.WriteLine($"Response: {Response}");
            Console.WriteLine("------------------------------");
        }
    }

