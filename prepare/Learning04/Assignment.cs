//Begin by creating a new file and a class for your base Assignment class.
using System;

class Assignment
{
//Add the attributes as private member variables.
    protected string _studentName;
    private string _topic;
//Create a constructor for this class that receives a student name and topic and sets the member variables.
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }
//Add the method for GetSummary() to return the student's name and the topic.
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}
//Test your class by returning to the Main method in the Program.cs file. Create a simple assignment, call the method to get the summary, and then display it to the screen.
