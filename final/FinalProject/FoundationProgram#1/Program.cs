using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //       Once you have the classes in place, write a program that creates 3-4 videos, sets the appropriate values,
        Video video = new Video("C#", "Caio", 3000, "José", "hello");
        video.videos.Add(video);
        // for each one add a list of 3-4 comments (with the commenter's name and text).
        video.AddComment(0, "C#", "A", 3000, "hello", "C# looks like Solidity!");
        video.AddComment(0, "C#", "B", 3000, "hello", "C# looks like Solidity!");
        video.AddComment(0, "C#", "C", 3000, "hello", "C# looks like Solidity!");

        Video secondVideo = new Video("Second", "Nathan", 5000, "Pedro", "world!");
        video.videos.Add(secondVideo);

        secondVideo.AddComment(0, "C#", "D", 3000, "A", "C# looks like Solidity!");
        secondVideo.AddComment(0, "C#", "E", 3000, "B", "C# looks like Solidity!");
        secondVideo.AddComment(0, "C#", "F", 3000, "C", "C# looks like Solidity!");

        Video thirdVideo = new Video("Third", "Victor", 5500, "Amanda", "C# is hard!");
        video.videos.Add(thirdVideo);

        thirdVideo.AddComment(0, "C#", "G", 3000, "hello", "C# looks like Solidity!");
        thirdVideo.AddComment(0, "C#", "H", 3000, "hello", "C# looks like Solidity!");
        thirdVideo.AddComment(0, "C#", "I", 3000, "hello", "C# looks like Solidity!");

        // List<Comment> comment = secondVideo.comments;
        // foreach(var com in comment){
        //   Console.WriteLine($"{com.ReturnName()}");
        // }

        List<Video> vid = secondVideo.videos;
        foreach (var vi in vid)
        {
            Console.WriteLine($"1_{vi.DisplayComments()} 1");
            Console.WriteLine($"2_{vi.DisplayComments()} 2");
            Console.WriteLine($"3_{vi.DisplayComments()} 3");
        }

        //       Once you have the classes in place, write a program that creates 3-4 videos, sets the appropriate values, and for each one add a list of 3-4 comments (with the commenter's name and text). Put each of these videos in a list.

        // Then, have your program iterate through the list of videos and for each one, display the title, author, length, number of comments (from the method) and then list out all of the comments for that video. Repeat this display for each video in the list.

    }
}