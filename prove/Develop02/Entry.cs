    
    public class Entry
    {
        // Attributes
        public string _date { get; }
        public string _prompt { get; }
        public string _response { get; }

        // Constructor: Initialize entry with date, prompt, and response
        public Entry(string date, string prompt, string response)
        {
            _date = date;
            _prompt = prompt;
            _response = response;
        }

        // Method: Display entry details
        public void Display()
        {
            Console.WriteLine($"\nDate: {_date}");
            Console.WriteLine($"Prompt: {_prompt}");
            Console.WriteLine($"Response: {_response}");
        }
    }
