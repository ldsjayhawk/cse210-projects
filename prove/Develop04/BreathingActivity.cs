using System.Diagnostics;

public class BreathingActivity : Activity 
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {

    }
    
    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(5);
        int sessionLength = _duration / 10;
        for (int x = sessionLength; x > 0; x--)
        {
            Console.WriteLine();
            Console.Write("Breathe in...");
            ShowCountDown(5);
            Console.WriteLine();
            Console.Write("Now breathe out...");
            ShowCountDown(5);
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("Well done!");
        ShowSpinner(5);
        DisplayEndingMessage();
        ShowSpinner(5);
    }
}