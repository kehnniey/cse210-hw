// Assignment.cs
using System;

public class Assignment
{
    private string _studentName;
    private string _topic;

    // Constructor
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Method to return the summary of the assignment
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

    // //  Method to get the student name (if needed for derived classes)
    // public string GetStudentName()
    // {
    //     return _studentName;
    // }
}
