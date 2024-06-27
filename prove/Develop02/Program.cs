using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

public class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        Journal myJournal = new Journal();

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
                string _dateText = theCurrentTime.ToShortDateString();
                
                PromptGenerator myPrompt = new PromptGenerator();
                string _prompt = myPrompt.GetRandomPrompt();

                Console.WriteLine(_prompt);
                string _response = Console.ReadLine();

                Console.WriteLine("Enter location of entry");
                string _userLocation = Console.ReadLine();                
                
                Entry entry = new Entry();
                entry._entryDate = _dateText;
                entry._location = _userLocation;
                entry._promptText = _prompt;
                entry._entryText = _response;

                myJournal.AddEntry(entry);
            }

            else if (choice == "2")
            {
                myJournal.DisplayAll();
            }

            else if (choice == "3")
            {
                myJournal = new Journal();
                myJournal.LoadFile("Journal.txt");
            }

            else if (choice == "4")
            {
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