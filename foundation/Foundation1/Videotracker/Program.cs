using System;
using System.Collections.Generic;
// Note: Comment out Program II(in Onlineorder folder) to run Program I
// This program is for the Youtube Comment tracker

// Program I
    class Program
    {
        static void Main(string[] args)
        {
            // Create videos and add comments
            List<YouTubeVideo> videos = new List<YouTubeVideo>
            {
                new YouTubeVideo("Exploring Space", "Dr. John Smith", 300)
                    .AddComment("Alice", "Amazing video!")
                    .AddComment("Bob", "Very informative.")
                    .AddComment("Charlie", "Loved the visuals!"),

                new YouTubeVideo("Cooking 101", "Chef Alex", 180)
                    .AddComment("Diana", "Great tips for beginners.")
                    .AddComment("Eve", "Loved the recipes!"),

                new YouTubeVideo("Top 10 Movies", "Cinema Reviews", 240)
                    .AddComment("Frank", "Nice compilation.")
                    .AddComment("Grace", "Some great picks here.")
                    .AddComment("Heidi", "This was so fun to watch!")
                    .AddComment("Ivy", "Thanks for the recommendations.")
            };

            // Display video details
            foreach (var video in videos)
            {
                Console.WriteLine(video.GetVideoDetails());
                Console.WriteLine("Comments:");
                foreach (var comment in video.GetComments())
                {
                    Console.WriteLine(comment);
                }
                Console.WriteLine();
            }
        }
    }


