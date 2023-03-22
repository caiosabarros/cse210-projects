using System;

class Program
{
    static void Main(string[] args)
    {
        //write a program that creates 3-4 videos, sets the appropriate values 
        Video firstVideo = new Video();
        firstVideo._title = "C# Introduction";
        firstVideo._author = "Microsoft";
        firstVideo._length = 500;

        Video secondVideo = new Video();
        secondVideo._title = "Comparison Between Solidity and C#";
        secondVideo._author = "Caio";
        secondVideo._length = 180;

        Video thirdVideo = new Video();
        thirdVideo._author = "Victor";
        thirdVideo._title = "How to get the Growth Mindset!";
        thirdVideo._length = 360;

        Video fourthVideo = new Video();
        fourthVideo._author = "Nathan"; 
        fourthVideo._title = "How to Get an A in the Programming With Classes class"; 
        fourthVideo._length = 720; 

        //for each one add a list of 3-4 comments (with the commenter's name and text

        Comment comment = new Comment();
        comment._name = "Bianca Antunes";
        comment._comment = "C# is like Solidity, I believe!";

        Comment secondComment = new Comment();
        secondComment._name = "Antunes";
        secondComment._comment = "C# < Solidity, I believe!";

        Comment thirdComment = new Comment();
        thirdComment._name = "Caio";
        thirdComment._comment = "I hope C# helps me learn Solidity!";
      
        //Put each of these videos in a list.
        firstVideo._comments.Add(comment);
        secondVideo._comments.Add(secondComment);
        secondVideo._comments.Add(thirdComment);

        firstVideo.DisplayComments();
        secondVideo.DisplayComments();
    }
}