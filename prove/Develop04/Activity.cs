using System.Diagnostics;
using System.Runtime.CompilerServices;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    protected List<string> _spinner;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
        _spinner = new List<string>();
        _spinner.Add("|");
        _spinner.Add("/");
        _spinner.Add("-");
        _spinner.Add("\\");
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} activity");
        Console.WriteLine();
        Console.WriteLine($"{_description}");
        Console.WriteLine();
        Console.WriteLine($"How long in seconds would you like your session to last? ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"You have completed {_duration} seconds of the {_name} activity");
    }

    public void ShowSpinner(int seconds)
    {
        
        for (int i = seconds; i > 0; i--)
        {
            foreach (string s in _spinner)
            {
                Console.Write(s);
                Thread.Sleep(250); // 1 second wait for every 1000 ms
                Console.Write("\b \b");
            }
        }

    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000); // 1 second wait for every 1000 ms

            if(i >= 10)
                Console.Write("\b\b  \b\b"); // Erase the + character -- need 2 for 2x digits}
            else
                Console.Write("\b \b");
        }
    }
}