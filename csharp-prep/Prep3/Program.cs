using System;

class Program
{
    static void Main(string[] args)
    {
        // Generating a random magic number between 1 and 100.
        Random random = new Random();
        int magicNumber = random.Next(1, 101);  // Random number between 1 and 100.

        // Initializing variables for my guessing loop.
        int guess = -1; // Any number that is not valid (because guesses are from 1 to 100)
        
        //  Looping until the user guesses the correct number.
        Console.WriteLine("Welcome to 'Guess My Number'!");
        
        // Continue to prompt the user until guess is right.
        while (guess != magicNumber)
        {
            // Asking the user's to guess.
            Console.Write("What is your guess? ");
            
            // Try to parse the user input as an integer.
            bool isValid = int.TryParse(Console.ReadLine(), out guess);
            
            if (!isValid || guess < 1 || guess > 100)
            {
                // Invalid guess.
                Console.WriteLine("Please enter a valid number between 1 and 100.");
                continue; // Skip the rest of the loop and ask again.
            }
            
            // Provide feedback about the guess.
            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
        
        // End the game once guess is correct.
        Console.WriteLine("Congratulations! You've guessed the magic number.");
    }
}
