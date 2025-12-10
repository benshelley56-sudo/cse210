using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        // first video
        Video video1 = new Video("Real!? or Cake?!", "Estheticalvids", 300);

        video1.AddComment(new Comment("Alice", "Wow! I don’t know how you kids make these cakes look so real nowadays. I had to squint at the screen just to tell what was what! Very impressive craftsmanship. Keep up the great work."));
        video1.AddComment(new Comment("James", "ot me having 99 problems but deciding whether it’s cake is now one of them 😂 This video triggered every episode of Cake or Not Cake I’ve ever seen. Amazing job, honestly."));
        video1.AddComment(new Comment("Zayden", "bro I was CONVINCED that thing was real 😭😭 the plot twist had me questioning my whole life. u def cooked (literally) 🔥🍰"));

        // second video
        Video video2 = new Video("10 Hours of Relaxing Music", "Daily Calm", 36000);

        video2.AddComment(new Comment("Jane", "Very peaceful. They don’t make music like this on the radio anymore. I put this on while reading my book and almost fell asleep — in a good way. Thank you for sharing."));
        video2.AddComment(new Comment("Steven", "Finally, something to drown out my anxiety while I pretend to get my life together 😌✨ Perfect background vibes for work, cleaning, or just trying to exist."));
        video2.AddComment(new Comment("Abcde", "nah this got me relaxing like a cat in a sunbeam 😭✨ vibes are IMMACULATE. brb ascending to another dimension 🌌"));


        //third video
        Video video3 = new Video("Beating Minecraft as Mojang intended", "Pewdiepie", 1200);

        video3.AddComment(new Comment("Robert", "I remember when games didn’t have all these complicated updates. Nice to see someone play it the ‘proper’ way without all the fancy modifications. Looks like a good honest challenge."));
        video3.AddComment(new Comment("Olivia", "Ah yes, playing Minecraft the way Mojang intended… aka the way I played it in 2012 before life responsibilities hit 😂 This really brings back the nostalgia. Great run!"));
        video3.AddComment(new Comment("Mackinzleigh", "bro actually playing minecraft legit is wild 💀💀 no mods, no datapacks, just raw survival energy. ngl you popped OFF tho 😭🔥"));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (Video video in videos)
        {
            Console.WriteLine($"\nTitle: {video._vTitle}");
            Console.WriteLine($"Channel: {video._vAuther}");
            Console.WriteLine($"Length: {video._vTime} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (Comment c in video._videoComments)
            {
                Console.WriteLine($"  - {c._cName}: {c._cText}");
            }
        }
    }
}