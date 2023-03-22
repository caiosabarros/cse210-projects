using System;

public class Video
{
  //Your program should have a class for a Video that has the responsibility to track the title, author, and length (in seconds) of the video.
    public string _title;
    public string _author;
    public int _length;
  //Each video also has responsibility to store a list of comments, 
    public List<Comment> _comments = new List<Comment>();
    public int _counter = 0;
  
    public void DisplayComments(){
        int numberOfComments = CommentsNumber();

        string display = numberOfComments > 1 ? "comments" : "comment"; 
      
        foreach (Comment comment in _comments)
        {
          _counter = _counter + 1;
          Console.WriteLine($"Name: {comment._name}");
          Console.WriteLine($"Comment: {comment._comment}");
        }
          Console.WriteLine($"The video has {CommentsNumber()} {display}" );
    }

    public void DisplayVideos(){
      
    }
    //and should have a method to return the number of comments. 
    public int CommentsNumber() {
      return _comments.Count;
    }
  
}