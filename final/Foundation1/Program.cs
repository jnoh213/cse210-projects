class Program
{
    static void Main(string[] args)
    {
        // Create video objects
        Video video1 = new Video("Intro to C#", "John Doe", 600);
        Video video2 = new Video("Advanced C#", "Jane Smith", 900);
        Video video3 = new Video("C# Design Patterns", "Alice Johnson", 1200);

        // Add comments to video1
        video1.AddComment(new Comment("User1", "Great video!"));
        video1.AddComment(new Comment("User2", "Very helpful, thanks!"));
        video1.AddComment(new Comment("User3", "Awesome content!"));

        // Add comments to video2
        video2.AddComment(new Comment("User4", "Informative!"));
        video2.AddComment(new Comment("User5", "Well explained."));
        video2.AddComment(new Comment("User6", "Loved it!"));

        // Add comments to video3
        video3.AddComment(new Comment("User7", "Excellent tutorial."));
        video3.AddComment(new Comment("User8", "Very clear and concise."));
        video3.AddComment(new Comment("User9", "Helpful for my project."));

        // Store videos in a list
        var videos = new List<Video> { video1, video2, video3 };

        // Display information for each video
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"Comment by {comment.GetName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}
