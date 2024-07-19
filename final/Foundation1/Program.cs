using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {

        Console.Clear();

        List<Video> videos = new List<Video>();

        Video v1 = new Video("Crazy Cats","Arthur Feline",120);
        v1.AddComment(new Comment("catlover555", "Awww! That's cute!"));
        v1.AddComment(new Comment("catsmeow999","I love watching my cat do this"));
        v1.AddComment(new Comment("calico123", "I could watch this all day!"));
        v1.AddComment(new Comment("calico123", "What a cute cat!"));
        videos.Add(v1);
        
        Video v2 = new Video("Scary Rollercoaster","Johnny Thrillseeker",350);
        v2.AddComment(new Comment("causalthrillseeker", "Wow!  That looks intense"));
        v2.AddComment(new Comment("disneynotforme","Add that to my bucket list!"));
        v2.AddComment(new Comment("zambezizinger151", "Been there done that!  Wanna go back again!"));
        videos.Add(v2);

        Video v3 = new Video("Messi Red Card","Jill Referee",35);
        v3.AddComment(new Comment("longliveMessi1929", "BOOOOO Ref!"));
        v3.AddComment(new Comment("messifan1002","That's a yellow, not a red!"));
        v3.AddComment(new Comment("vivaBrazil", "I am not a Messi fan"));
        v3.AddComment(new Comment("luvRonaldo", "Well Deserved!"));

        videos.Add(v3);

        Video v4 = new Video("Porch Pirate Gotcha","Elaine Smith",420);
        v4.AddComment(new Comment("dontstealmypackage", "Not this time!"));
        v4.AddComment(new Comment("packrat999","I love watching porch pirates get caught"));
        v4.AddComment(new Comment("youtubeislife45", "I could watch this all day!"));
        videos.Add(v4);


        foreach (Video v in videos)
        {
            Console.WriteLine();
            v.DisplayVideos();
            Console.WriteLine("-----------------");
            v.DisplayComments();
            Console.WriteLine("------------------");

        }
    }
}