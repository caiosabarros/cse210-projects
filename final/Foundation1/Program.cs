using System;
using System.Collections.Generic;

class Program
{
    static List<Video> videos = new List<Video>();
    static void Main(string[] args)
    {
        //write a program that creates 3-4 videos, sets the appropriate values 
        Video firstVideo = new Video();
        firstVideo._title = "Comparison Between Solidity and C#";
        firstVideo._author = "Microsoft";
        firstVideo._length = 500;

        Video secondVideo = new Video();
        secondVideo._title = "C# Introduction";
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

        Comment firstCommentForFirstVideo = new Comment();
        firstCommentForFirstVideo._name = "Bianca Antunes";
        firstCommentForFirstVideo._comment = "C# is like Solidity, I believe!";

        Comment secondCommentForFirstVideo = new Comment();
        secondCommentForFirstVideo._name = "Antunes";
        secondCommentForFirstVideo._comment = "C# < Solidity, I believe!";

        Comment thirdCommentForFirstVideo = new Comment();
        thirdCommentForFirstVideo._name = "Caio";
        thirdCommentForFirstVideo._comment = "I hope C# helps me learn Solidity!";
      
        Comment firstCommentForSecondVideo = new Comment();
        firstCommentForSecondVideo._name = "João Siqueira";
        firstCommentForSecondVideo._comment = "C# seems to be harder than Python";

        Comment secondCommentForSecondVideo = new Comment();
        secondCommentForSecondVideo._name = "Joel";
        secondCommentForSecondVideo._comment = "Yes, I agree that Python is much easier!";

        Comment thirdCommentForSecondVideo = new Comment();
        thirdCommentForSecondVideo._name = "Claudio";
        thirdCommentForSecondVideo._comment = "I hope C# gets easier with time!";

        Comment firstCommentForThirdVideo = new Comment();
        firstCommentForThirdVideo._name = "Chris Brown";
        firstCommentForThirdVideo._comment = "I've got the growth mindset after much practice of the good habits";

        Comment secondCommentForThirdVideo = new Comment();
        secondCommentForThirdVideo._name = "Lady Gaga";
        secondCommentForThirdVideo._comment = "Yes, the growth mindset truly helps!";

        Comment thirdCommentForThirdVideo = new Comment();
        thirdCommentForThirdVideo._name = "Connor Price";
        thirdCommentForThirdVideo._comment = "Been doing the growth mindset! It's awesome!";

        Comment firstCommentForFourthVideo = new Comment();
        firstCommentForFourthVideo._name = "Chris Rock";
        firstCommentForFourthVideo._comment = "I hope this class isn't harder than Will Smith";

        Comment secondCommentForFourthVideo = new Comment();
        secondCommentForFourthVideo._name = "Will Smith";
        secondCommentForFourthVideo._comment = "Imagine myself doing a movie being a programmer in C#!";

        Comment thirdCommentForFourthVideo = new Comment();
        thirdCommentForFourthVideo._name = "Ronaldinho";
        thirdCommentForFourthVideo._comment = "C# isn't that fancy as my incredible skills!";
        //for each one add a list of 3-4 comments (with the commenter's name and text
        firstVideo._comments.Add(firstCommentForFirstVideo);
        firstVideo._comments.Add(secondCommentForFirstVideo);
        firstVideo._comments.Add(thirdCommentForFirstVideo);

        secondVideo._comments.Add(firstCommentForSecondVideo);
        secondVideo._comments.Add(secondCommentForSecondVideo);
        secondVideo._comments.Add(thirdCommentForSecondVideo);

        thirdVideo._comments.Add(firstCommentForThirdVideo);
        thirdVideo._comments.Add(secondCommentForThirdVideo);
        thirdVideo._comments.Add(thirdCommentForThirdVideo);

        fourthVideo._comments.Add(firstCommentForFourthVideo);
        fourthVideo._comments.Add(secondCommentForFourthVideo);
        fourthVideo._comments.Add(thirdCommentForFourthVideo);

        //Put each of these videos in a list.
        videos.Add(firstVideo);
        videos.Add(secondVideo);
        videos.Add(thirdVideo);
        videos.Add(fourthVideo);

        // firstVideo.DisplayComments();
        // secondVideo.DisplayComments();

        // Then, have your program iterate through the list of videos and for each one, display the title, author, length, number of comments (from the method) and then list out all of the comments for that video. Repeat this display for each video in the list.
        foreach(Video video in videos){
          Console.WriteLine($"Title: {video._title} \r\n Author: {video._author} \r\n Length: {video._length} seconds \r\n Comments Number:{video.CommentsNumber()}");
          Console.WriteLine($"The comments in the video are the following:");
          video.DisplayComments();
          } 
    }
}
