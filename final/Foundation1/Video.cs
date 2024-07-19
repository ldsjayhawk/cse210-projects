using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics;
using System.Net;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

public class Video
{
    // create variables
    public string _title;
    public string _author;
    public int _length; //seconds
    public List<Video> _videos = new List<Video>();

    public List<Comment> _comments = new List<Comment>();


    public void AddComment(Comment newcomment)
    {
        _comments.Add(newcomment);
    }

    public Video (string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    public int DisplayNumberComments()
    {
        int count = 0;
        foreach (Comment c in _comments)
        {
            count++;
        }
        return count;
    }


    // Display video list
    public void DisplayVideos()
    {
        Console.WriteLine($"Video: {_title} by {_author} ({_length} seconds)");
    }

    public void DisplayComments()
    {
        Console.Write("Number of Comments: ");
        Console.WriteLine(DisplayNumberComments());
        foreach(Comment c in _comments)
            c.DisplayComments();
    }
}