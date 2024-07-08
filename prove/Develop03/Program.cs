using System;

public class Program
{
    static void Main(string[] args)
    {
        //initialize variable to quit
        string quit = "";

        //call reference & scripture classes
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");

        //loop until user quits or all of the words are hidden
        do
        {
            Console.Clear();
            scripture.GetDisplayText();

            //check if all words are hidden.  if not hide more words
            if (scripture.IsCompletelyHidden())
            {
                break;
            }
            else
            {
                scripture.HideRandomWords(3);
            }

            //Display message and get user response
            Console.WriteLine("Please enter to continue or type 'quit' to finish: ");
            quit = Console.ReadLine();
        }
        while (quit != "quit");
    }
}