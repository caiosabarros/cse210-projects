using System;

class MathAssignment:Assignment 
{
    private string _textbookSection;
    private string _problems;

    public string GetHomeworkList()
    {
        return $"{_textbookSection} {_problems}";
        //"Section 7.3 Problems 8-19"
    }
    //Create a constructor for your class that accepts all four parameters, have it call the base class constructor to set the base class attributes that way.
    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }


}
