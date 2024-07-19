using System;

class Program
{
    static void Main(string[] args)
    {
        Lecture lecture1 = new Lecture("Science", "Theory of Relativity", "science lecture", "Sept 1", "8 AM", "801 Spruce St", "Albert Einstein", 120);
        Reception reception1 = new Reception("Reception", "Altman Reception", "wedding reception", "Sept 1", "3 PM", "1022 Dartmouth Rd", "reception@altman.com");
        Outdoor outdoor1 = new Outdoor("Concert", "Chicago", "concert tour" , "Oct 3", "7 PM", "10001 Amphitheatre Dr", "Sunny 75 degrees");

        Console.Clear();

        lecture1.StandardDetails();
        lecture1.FullDetails();
        lecture1.ShortDetails();
        Console.WriteLine();

        reception1.StandardDetails();
        reception1.FullDetails();
        reception1.ShortDetails();
        Console.WriteLine();

        outdoor1.StandardDetails();
        outdoor1.FullDetails();
        outdoor1.ShortDetails();
    }
}