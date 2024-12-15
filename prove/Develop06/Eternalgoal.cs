public class EternalGoal : Goal
{
    // Constructor to initialize the EternalGoal with its name, description, and points.
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    // Records an event for the goal, but EternalGoal is never "complete."
    public override void RecordEvent()
    {
        // No completion logic for EternalGoal.
    }

    // Always returns false since EternalGoal is designed to never be complete.
    public override bool IsComplete()
    {
        return false; // EternalGoal is never "complete."
    }

    // Returns a formatted string with details about the EternalGoal.
    public override string GetDetailsString()
    {
        return $"{Name} (Eternal Goal) - {Description} - Points: {Points}";
    }

    // Provides a string representation of the EternalGoal for saving or debugging.
    public override string GetStringRepresentation()
    {
        return $"EternalGoal\n{Name}\n{Description}\n{Points}";
    }
}
