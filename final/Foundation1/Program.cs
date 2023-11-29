using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        //Creates a list of videos and adds comments for each one
        List<Video> videos = new List<Video>();

        //Creates first video and comments
        Video video1 = new Video("Classic Games", "AtariFan", 230);
        video1.AddComment("user1", "Too right, classics FTW!");
        video1.AddComment("user2", "I mean respect but you Old bro");
        video1.AddComment("user3", "Solid video, points well thought out, and articulated.");

        //Creates second video and comments
        Video video2 = new Video("Game can be Art", "NPC.rpg", 345);
        video2.AddComment("user4", "Gorgeous exmaples, nice vid fam!");
        video2.AddComment("user5", "Yeah I mean sure great art blah blah but perfomance is king yo.");
        video2.AddComment("user6", "You're clearly a nerd but points for passion.");

        //Creates third video and comments
        Video video3 = new Video("CODGod232!", "Nadedyou.dead", 160);
        video3.AddComment("user7", "Lame dude hackers ruin good games");
        video3.AddComment("user8", "Well say goodbye to these next patch but hey til then merc 'em all!");
        video3.AddComment("user9", "Cool bro thanks for sharing");

        //Adds videos to the list
        videos.AddRange(new List<Video> {video1, video2, video3});

        //Displays video details for each video in the list
        foreach (Video video in videos) {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLengthInSeconds()}");
            Console.WriteLine($"Number of Comments: {video.GetcountOfComments()}");

            //Displays comment author and text per video
            foreach (Comment comment in video.GetComments()) {
                Console.WriteLine($"Comment by {comment.GetCommenterName()}: {comment.GetCommentText()}");
            }
            //Gives a single line of blank space
            Console.WriteLine();
        }
    }
}