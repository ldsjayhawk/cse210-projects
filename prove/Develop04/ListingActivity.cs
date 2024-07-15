using System.Diagnostics;
using System.Security.Principal;

public class ListingActivity : Activity
{

    private List<string> _prompts;
    Random randomNumber = new Random();


    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _prompts = new List<string>();
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");       
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");        
        _prompts.Add("Who are some of your personal heroes?");            
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(5);
        Console.WriteLine("List as many responses as you can to the following prompt: ");
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine();
        Console.Write("You may begin in: ");
        Console.WriteLine();
        ShowCountDown(10);
        GetListFromUser();
        ShowSpinner(5);
        DisplayEndingMessage();
        ShowSpinner(5);
    }

    public string GetRandomPrompt()
    {
        int p = randomNumber.Next(_prompts.Count);
        string prompt = _prompts[p];
        return prompt;
    }
    
    public void GetListFromUser()
    {
        int count = 0;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {        
            Console.Write(">");
            string x = Console.ReadLine();
            count ++;
        }


        Console.WriteLine($"You listed {count} items"!);
        Console.WriteLine();
        Console.WriteLine("Well Done!");
    }
}