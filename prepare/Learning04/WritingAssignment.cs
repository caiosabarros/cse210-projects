using System;

class WritingAssignment:Assignment 
{
//Add the member variables and set up the constructor as you did for the MathAssignment class.
    private string _title;
    //A writing assignment may need to store the student's name, the topic (for example, "European History"), and the title of the assignment (for example, "The Causes of World War II").
    //
    //The writing assignment should have a constructor that requires a value for each of the items that it stores.
    //
    //The writing assignment needs to provide a method to return a summary of the assignment that contains the student's name and the topic, and it also needs to provide a method to get the writing information which consists of the title and the student's name (for example, "The Causes of World War II by Mary Waters").
   public WritingAssignment(string title): base(studentName, topic)
   {
    _title = title;
   }

    public string GetWritingInformation()
    {
        return $"{_title} by {_studentName}";
    }
//Notice that this method needs to access the _studentName variable defined in the base class. Even though WritingAssignment class inherited this attribute, it is private, so you cannot access it directly in the derived class.
//
//
//Return to Main and test your new class.

}
