using System;

class Program
{
    static void Main(string[] args)
    {
        {
            List<Video> videos = new List<Video>();

            // Create and populate videos
            Video video1 = new Video { Title = "Introduction to C#", Author = "John Doe", LengthInSeconds = 300 };
            video1.AddComment("User1", "Great video!");
            video1.AddComment("User2", "Thanks for the tutorial!");

            Video video2 = new Video { Title = "Web Development Basics", Author = "Jane Smith", LengthInSeconds = 450 };
            video2.AddComment("User3", "This is helpful.");
            video2.AddComment("User4", "I have a question about CSS.");

            // Add videos to the list
            videos.Add(video1);
            videos.Add(video2);

            // Display information for each video
            foreach (var video in videos)
            {
                video.DisplayInformation();
            }
        }
    }

}
