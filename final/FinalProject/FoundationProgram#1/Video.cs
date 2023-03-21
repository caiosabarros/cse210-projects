using System;
using System.Collections.Generic;

class Video
// Your program should have a class for a Video that has the responsibility to track the title, author, and length (in seconds) of the video.
{
    private string _title = "";
    private string _author = "";
    private int _length = 0; //in seconds
//  Each video also has responsibility to store a list of comments
    public List<Comment> comments = new List<Comment>();
    public List<Video> videos = new List<Video>();

    public Video(string title, string author, int length, string name, string comment)
    {
    _title = title;
    _author = author;
    _length = length;
    comments.AddRange(new List<Comment>
    {
      new Comment($"{name}", $"{comment}" ),
    });
    }

    public Video() {
      
    }

    public void AddComment(int videoIndex, string title, string author, int length, string name, string comment){
      videos.Insert(videoIndex,new Video($"{title}", $"{author}", length ,$"{name}", $"{comment}"));
    }
//   List<Person> listofPersons = new List<Person>();
// listofPersons.AddRange(new List<Person>
// {
//     new Person("John1", "Doe" ),
//     new Person("John2", "Doe" ),
//     new Person("John3", "Doe" ),
//  });
  
    public string DisplayComments()
    {
        foreach(var com in comments)
        {
          Console.WriteLine($"{com.ReturnName()}",$"{com.ReturnText()}");
        }
        
        return comments[0].ReturnName().ToString();
    }

// and should have a method to return the number of comments.
    // public string CommentsNumber(int _videoId) {
    //     //get the video in corresponding to the Id
      
    //     //return the number of comments = length of Comments List
    // }

}

