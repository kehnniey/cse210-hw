using System;
using System.Collections.Generic;
using System.IO;

// GoalManager class manages a list of goals and the player's score.
public class GoalManager
{
    private List<Goal> _goals;  // List to store all goals.
    private int _score;         // Keeps track of the total score.

    // Constructor initializes an empty goal list and sets score to 0.
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }
// ###############################################################################
    // Start method runs the main menu and handles user interactions.
    public void Start()
    {
        while (true)
        {
            Console.Clear();
            DisplayPlayerInfo(); // Displays the player's score.
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");

            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    CreateGoal();  // Call method to create a new goal.
                    break;
                case "2":
                    ListGoalDetails();  // Call method to list goal details.
                    break;
                case "3":
                    RecordEvent();  // Call method to record an event for a goal.
                    break;
                case "4":
                    SaveGoals();  // Save the goals to a file.
                    break;
                case "5":
                    LoadGoals();  // Load goals from a file.
                    break;
                case "6":
                    return;  // Exit the application.
                default:
                    Console.WriteLine("Invalid option, Press Enter, to try again.");
                    Console.ReadLine(); // Wait for user input before returning to menu.
                    break;
            }
        }
    }
// ###############################################################################
    // Displays the player's current total score.
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Total Score: {_score}");
    }

    // Lists all the names of the goals.
    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].Name}");
        }
    }

    // Lists detailed information for each goal.
    public void ListGoalDetails()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());  // Outputs goal details.
        }
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine(); // Wait for user input to continue.
    }

// ###############################################################################
    // Allows the user to create a new goal, prompting for goal details.
    public void CreateGoal()
    {
        Console.WriteLine("Choose Goal Type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Your choice: ");
        var choice = Console.ReadLine();

        // Prompting the user for goal details (name, description, points).
        Console.Write("Enter goal name: ");
        var name = Console.ReadLine();
        Console.Write("Enter description: ");
        var description = Console.ReadLine();
        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        // Based on user choice, create the respective goal type.
        switch (choice)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points)); // Add SimpleGoal.
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points)); // Add EternalGoal.
                break;
            case "3":
                Console.Write("Enter target completions: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus)); // Add ChecklistGoal.
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

// ###############################################################################
    // Allows the user to select a goal and record an event for it.
    public void RecordEvent()
    {
        Console.WriteLine("Select a goal to record an event:");
        ListGoalNames(); // List all goal names for selection.
        Console.Write("Your choice: ");
        int choice = int.Parse(Console.ReadLine()) - 1;

        if (choice >= 0 && choice < _goals.Count)
        {
            var goal = _goals[choice];
            goal.RecordEvent();  // Record an event for the selected goal.

            // Add points for the recorded event.
            _score += goal.Points;

            // If it's a checklist goal and now complete, add bonus points.
            if (goal is ChecklistGoal checklistGoal && checklistGoal.IsComplete())
            {
                _score += checklistGoal.BonusPoints;
            }

            Console.WriteLine("Event recorded successfully!");
        }
        else
        {
            Console.WriteLine("Invalid goal selection.");
        }

        Console.WriteLine("Press Enter to return to the menu.");
        Console.ReadLine(); // Wait for user input to return to the menu.
    }
// ###############################################################################
    // Saves the current goals and score to a text file.
    public void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(_score); // Save the current score.
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation()); // Serialize each goal.
            }
        }
        Console.WriteLine("Goals saved successfully!");
        Console.ReadLine(); // Wait for user input to continue.
    }

// ###############################################################################
    // Loads saved goals and score from a file.
    public void LoadGoals()
    {
        if (File.Exists("goals.txt"))
        {
            _goals.Clear(); // Clear existing goals before loading new ones.
            using (StreamReader reader = new StreamReader("goals.txt"))
            {
                _score = int.Parse(reader.ReadLine()); // Load the saved score.
                while (!reader.EndOfStream)
                {
                    var goalType = reader.ReadLine(); // Read goal type from file.
                    var name = reader.ReadLine(); // Read goal name.
                    var description = reader.ReadLine(); // Read goal description.
                    var points = int.Parse(reader.ReadLine()); // Read goal points.

                    // Load the appropriate goal based on the type.
                    switch (goalType)
                    {
                        case "SimpleGoal":
                            bool isComplete = bool.Parse(reader.ReadLine());
                            var simpleGoal = new SimpleGoal(name, description, points);
                            if (isComplete) simpleGoal.RecordEvent(); // Record event if goal is complete.
                            _goals.Add(simpleGoal);
                            break;

                        case "EternalGoal":
                            _goals.Add(new EternalGoal(name, description, points));
                            break;

                        case "ChecklistGoal":
                            int currentProgress = int.Parse(reader.ReadLine());
                            int target = int.Parse(reader.ReadLine());
                            int bonusPoints = int.Parse(reader.ReadLine());
                            var checklistGoal = new ChecklistGoal(name, description, points, target, bonusPoints);
                            for (int i = 0; i < currentProgress; i++) checklistGoal.RecordEvent(); // Record progress.
                            _goals.Add(checklistGoal);
                            break;

                        default:
                            Console.WriteLine($"Unknown goal type: {goalType}");
                            break;
                    }
                }
            }
            Console.WriteLine("Goals loaded successfully!");
        }
        else
        {
            Console.WriteLine("No saved goals found.");
        }
        Console.WriteLine("Press Enter to return to the menu.");
        Console.ReadLine(); // Wait for user input to continue.
    }
}
