using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("The Art of Creative Thinking", "John Smith", 320);
        video1.AddComment(new Comment("Katarzyna", "Great video!"));
        video1.AddComment(new Comment("Robert", "Very informative."));
        video1.AddComment(new Comment("Oliwia", "Loved it!"));

        Video video2 = new Video("C# Classes Explained", "DevNerd", 410);
        video2.AddComment(new Comment("Marzena", "Super helpful!"));
        video2.AddComment(new Comment("Mateusz", "I finally understand classes."));
        video2.AddComment(new Comment("Anna", "Please make one on inheritance."));

        Video video3 = new Video("Epic Mountain Biking", "ExtremeSports", 290);
        video3.AddComment(new Comment("Tomasz", "Insane ride!"));
        video3.AddComment(new Comment("Julia", "Where is this trail?"));
        video3.AddComment(new Comment("Jakub", "Loved the camera work."));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.DisplayVideo();
        }
    }
}