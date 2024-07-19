using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics;
using System.Dynamic;
using System.Reflection;
using System.Security.Cryptography;

public class Comment
{
    public string _commenter;
    public string _comment;
    public List<Comment> _comments = new List<Comment>();

    public Comment(string commenter, string comment)
    {
        _commenter = commenter;
        _comment = comment;
    }


    public void DisplayComments()
    {
        Console.WriteLine( $" {_commenter}:  {_comment}");
    }
}
