using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");

        // Creates 3-4 Videos (Sets the appropriate values)
        
        List<Comment> commentsVideo1 = new List<Comment>();
        Comment myComment1 = new Comment("Tom123","Your video helped me a lot!");
        Comment myComment2  = new Comment("Andrea123","Tried that but didn't work");
        Comment myComment3  = new Comment("Sam123","Could you speak more slowly?");

        commentsVideo1.Add(myComment1);
        commentsVideo1.Add(myComment2);
        commentsVideo1.Add(myComment3);

        List<Comment> commentsVideo2 = new List<Comment>();
        Comment myComment4 = new Comment("Tom123","Your video was very useful!");
        Comment myComment5  = new Comment("Phill123","Can you bake it in a brick oven too?");
        Comment myComment6  = new Comment("Jean123","What if I dont't have flour?");
        commentsVideo2.Add(myComment4);
        commentsVideo2.Add(myComment5);
        commentsVideo2.Add(myComment6);

        List<Comment> commentsVideo3 = new List<Comment>();
        Comment myComment7 = new Comment("Tom123","This video helped me a lot on my visit to London!");
        Comment myComment8  = new Comment("Phill123","My visit was too short and I couldn¿t see that theater");
        Comment myComment9  = new Comment("Zack123","Did you had to choose a day so clouded?");
        commentsVideo3.Add(myComment7);
        commentsVideo3.Add(myComment8);
        commentsVideo3.Add(myComment9);

        Video myVideo1 = new Video("How to repair your own bike","Biker Jack",900, commentsVideo1);
        Video myVideo2 = new Video("How to bake a cake", "Baker Jack",1800,commentsVideo2);
        Video myVideo3 = new Video("What to see in London", "Traveller Jack",1800,commentsVideo3); 

        List<Video> allMyVideos = new List<Video>();
        allMyVideos.Add(myVideo1);
        allMyVideos.Add(myVideo2);
        allMyVideos.Add(myVideo3);
       

        foreach (Video thisVideo in allMyVideos)
        {
            Console.WriteLine(thisVideo.GetVideoDetails());
            
        }





    }
}