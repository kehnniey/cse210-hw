public class ChecklistGoal : Goal
{
    // Tracks the current progress of completing the checklist.
    private int _currentProgress;

    // The total number of steps required to complete the goal.
    private readonly int _target;

    // The bonus points awarded when the goal is completed.
    public int BonusPoints { get; }

    // Initializes the ChecklistGoal with name, description, points, target steps, and bonus points.
    public ChecklistGoal(string name, string description, int points, int target, int bonusPoints)
        : base(name, description, points)
    {
        _target = target; // Set the target steps.
        BonusPoints = bonusPoints; // Set the bonus points.
        _currentProgress = 0; // Initialize progress to 0.
    }

    // Increments progress by one step if the target has not been reached.
    public override void RecordEvent()
    {
        if (_currentProgress < _target)
        {
            _currentProgress++;
        }
    }

    // Checks if the goal is complete (i.e., current progress has reached or exceeded the target).
    public override bool IsComplete()
    {
        return _currentProgress >= _target;
    }

    // Returns a formatted string with details about the checklist goal, including progress and bonus points.
    public override string GetDetailsString()
    {
        return $"{Name} (Checklist Goal) - {Description} - Points: {Points} - Progress: {_currentProgress}/{_target} - Bonus: {BonusPoints}";
    }

    // Provides a string representation of the checklist goal for saving or debugging.
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal\n{Name}\n{Description}\n{Points}\n{_currentProgress}\n{_target}\n{BonusPoints}";
    }
}
