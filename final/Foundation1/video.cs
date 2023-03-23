using System.Collections.Generic;

public class Video : VideoContent
{
    public string Author { get; set; }
    public int Length { get; set; }
    public List<Comment> Comments { get; set; }

    public Video(string name, string author, int length) : base(name)
    {
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    public int GetNumberOfComments()
    {
        return Comments.Count;
    }
}
