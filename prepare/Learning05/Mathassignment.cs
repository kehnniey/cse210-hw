using System;

public class MathAssignment : Assignment
{
    private string _section;
    private string _problems;

    // Constructor
    public MathAssignment(string studentName, string topic, string section, string problems)
        : base(studentName, topic)
    {
        _section = section;
        _problems = problems;
    }

    // Method to return homework list for Math assignment
    public string GetHomeworkList()
    {
        return $"Section {_section} Problems {_problems}";
    }
}
