using System;

class Program
{
    static void Main(string[] args)
    {
         List<Video> videos = new List<Video>();

        // Video No 1
        Video video1 = new Video("I Tested 5 Kitchen Gadgets (Honest Review)", "GadgetLab", 742);
        video1.AddComment(new Comment("Alice", "That blender blew my mind at 4:32!"));
        video1.AddComment(new Comment("Marcus", "Great review, but I wish you tested the air fryer too."));
        video1.AddComment(new Comment("Priya", "Bought the second gadget because of this. No regrets."));
        video1.AddComment(new Comment("Tom", "The slow-mo shots are so satisfying."));
        videos.Add(video1);

        // Video No 2
        Video video2 = new Video("Unboxing the New Nomad Phone", "TechTalkDaily", 1085);
        video2.AddComment(new Comment("Sofia", "The camera sample at the end sold me."));
        video2.AddComment(new Comment("David", "Why does every flagship look the same now?"));
        video2.AddComment(new Comment("Kenji", "Battery life numbers would be nice in the next video."));
        videos.Add(video2);

        // Video No 3 
        Video video3 = new Video("$50 Gaming Mouse vs $150 Gaming Mouse", "ProSettings", 593);
        video3.AddComment(new Comment("Hannah", "The sensor test was way more scientific than I expected."));
        video3.AddComment(new Comment("Luis", "Still using my $20 mouse and winning, just saying."));
        video3.AddComment(new Comment("Grace", "Clicked subscribe at the teardown section."));
        video3.AddComment(new Comment("Omar", "Can you do keyboards next?"));
        videos.Add(video3);

        // Video No 4
        Video video4 = new Video("Morning Routine with the BrewMaster Pro", "CoffeeWithChloe", 428);
        video4.AddComment(new Comment("Emma", "That pour-over technique is so relaxing to watch."));
        video4.AddComment(new Comment("Noah", "Mine arrives Friday, I can't wait."));
        video4.AddComment(new Comment("Ava", "Please do a cheaper alternative video!"));
        videos.Add(video4);

        // Display every video comments
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLengthInSeconds()} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  - {comment.GetCommenterName()}: {comment.GetText()}");
            }

            Console.WriteLine(new string('-', 60));
            Console.WriteLine();
        }
    }
}