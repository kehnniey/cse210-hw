public class SimpleGoal : Goal
{
    // Indicates if the goal is complete.
    private bool _isComplete;

    // Initializes the SimpleGoal with its name, description, and points.
    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false; // Goal starts as incomplete.
    }

    // Marks the goal as complete by setting _isComplete to true.
    public override void RecordEvent()
    {
        _isComplete = true;
    }

    // Checks and returns whether the goal is complete.
    public override bool IsComplete()
    {
        return _isComplete;
    }

    // Returns a formatted string with details about the goal.
    public override string GetDetailsString()
    {
        return $"{Name} (Simple Goal) - {Description} - Points: {Points} - Complete: {_isComplete}";
    }

    // Provides a string representation of the goal for saving or debugging.
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal\n{Name}\n{Description}\n{Points}\n{_isComplete}";
    }
}
