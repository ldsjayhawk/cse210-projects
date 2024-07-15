using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {

        string choice = "";
        // Journal myJournal = new Journal();

        do
        {
            Console.Clear();
            Console.WriteLine("Menu options:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");

            Console.WriteLine("Please select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                string name = "Breathing";
                string description = "This activity will help you relax by walking you through breathing in and out slowly.  Clear your mind and focus on your breathing.";
                int duration = 0;

                BreathingActivity breathing = new BreathingActivity(name, description, duration);
                breathing.Run();
            }

            else if (choice == "2")
            {
                string name = "Reflection";
                string description = """
                    This activity will help you reflect on times in your life when you have shown strength and resilience.
                    This will help you recognize the power you have and how you can use it in the other aspects of your life.
                    """;
                int duration = 0;

                ReflectionActivity reflection = new ReflectionActivity(name, description, duration);
                reflection.Run();
            }

            else if (choice == "3")
            {
                string name = "Listing";
                string description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
                int seconds = 0;

                ListingActivity listing = new ListingActivity(name, description, seconds);
                listing.Run();
            }

            else if (choice == "4")
            {
                Console.WriteLine("Thank you.  Goodbye!");
            }

            else
            {
                Console.WriteLine("Please select an option between 1 & 4.");
            }
        }
        while (choice != "4");
    }
}
