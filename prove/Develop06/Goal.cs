// Defines a base class for specific goals.
public abstract class Goal
{
// Read-only property for the goal's name, description, and points earned for completing the goal
    public string Name { get; }
    public string Description { get; }
    public int Points { get; }

    // Constructor to initialize name, description, and points
    protected Goal(string name, string description, int points)
    {
        Name = name;
        Description = description;
        Points = points;
    }

    // Method to log a goal-related event.
    public abstract void RecordEvent();

    // Checks if the goal is completed.
    public abstract bool IsComplete();

    // Gets formatted details about the goal
    public abstract string GetDetailsString();

    // Provides a string version of the goal
    public abstract string GetStringRepresentation();
}
