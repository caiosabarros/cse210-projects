using System;

public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments = new List<Comment>();
    public List<Video> videos = new List<Video>();
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

    public int CommentsNumber() {
      return _comments.Count;
    }
  
}