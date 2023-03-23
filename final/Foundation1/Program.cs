using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create 3-4 videos and add comments to them
        var videos = new List<Video>
        {
            new Video("Video 1", "Author 1", 120),
            new Video("Video 2", "Author 2", 180),
            new Video("Video 3", "Author 3", 90),
        };

        foreach (var video in videos)
        {
            video.Comments.Add(new Comment(video.Name, "Commenter 1", "Comment 1"));
            video.Comments.Add(new Comment(video.Name, "Commenter 2", "Comment 2"));
            video.Comments.Add(new Comment(video.Name, "Commenter 3", "Comment 3"));
        }

        // Display information about each video and its comments
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Name}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");

            Console.WriteLine("Comments:");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}
