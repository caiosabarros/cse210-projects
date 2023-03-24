using System;
using System.Collections.Generic;

public class Comment
{
    public string _name;
    public string _comment;

    // Make sure to initialize your list to a new List before you use it.
    // public List<Video> _videos = new List<Video>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Comment: {_comment} comment(s)");
    }
}