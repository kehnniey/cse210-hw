using System;
using System.Collections.Generic;


    public static class PromptGenerator
    {
        // Predefined list of prompts
        private static readonly List<string> prompts = new List<string>
        {
            "What made you smile today?",
            "What did you learn today?",
            "What are you grateful for today?",
            "Describe something you accomplished today.",
            "How are you feeling right now?"
        };

        // Method to select a random prompt from the list
        public static string SelectPrompt()
        {
            Random random = new Random();
            return prompts[random.Next(prompts.Count)];
        }
    }
