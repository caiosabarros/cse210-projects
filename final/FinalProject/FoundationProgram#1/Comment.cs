using System;
using System.Collections.Generic;

public class Comment
{
  //A comment should be defined by the Comment class which has the responsibility for tracking both the name of the person who made the comment and the text of the comment.
    public string _name;
    public string _comment;

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Comment: {_comment} comment(s)");
    }
}