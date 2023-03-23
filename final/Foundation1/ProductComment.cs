public class Comment : VideoContent
{
    public string CommenterName { get; set; }
    public string Text { get; set; }

    public Comment(string name, string commenterName, string text) : base(name)
    {
        CommenterName = commenterName;
        Text = text;
    }
}
