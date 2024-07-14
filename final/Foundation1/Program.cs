using System;

class Program
{
    static void Main(string[] args)
    {
        // Create video objects
        Video video1 = new Video("Python Tutorial", "John Doe", 600);
        Video video2 = new Video("Cooking Basics", "Jane Smith", 900);
        Video video3 = new Video("Travel Vlog", "Alice Johnson", 1200);

        // Add comments to videos
        video1.AddComment("User1", "Great tutorial!");
        video1.AddComment("User2", "Very helpful, thanks!");

        video2.AddComment("User3", "Nice video!");

        video3.AddComment("User4", "Awesome travel tips!");
        video3.AddComment("User5", "Loved the scenery!");

        // Store videos in a list
    }
}