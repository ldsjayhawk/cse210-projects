using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

public class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        do
        { 
            Console.WriteLine("Welcome to your journal");
            Console.WriteLine("Please select an option below:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.WriteLine("What would you like to do?");
            choice = Console.ReadLine();

            if (choice == "1")
            {            
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                
                PromptGenerator myPrompt = new PromptGenerator();
                string prompt = myPrompt.GetRandomPrompt();

                Console.WriteLine(prompt);
                string response = Console.ReadLine();
                
                Entry entry = new Entry();
                entry._entryDate = dateText;
                entry._promptText = prompt;
                entry._entryText = response;

                Journal myJournal = new Journal();
                myJournal.AddEntry(entry);
            }

            else if (choice == "2")
            {
                Journal myJournal = new Journal();
                myJournal.DisplayAll();
            }

            else if (choice == "3")
            {
                Journal myJournal = new Journal();
                myJournal.LoadFile("Journal.txt");
            }

            else if (choice == "4")
            {
                Journal myJournal = new Journal();
                myJournal.SaveFile("Journal.txt");
            }

            else if (choice == "5")
            {
                Console.WriteLine("Thank you.  Goodbye!");
            }

            else
            {
                Console.WriteLine("Please select an option 1-5.");
            }
        }
        while (choice != "5");
    }
}