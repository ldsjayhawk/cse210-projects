using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Xml;

public class ReflectionActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    Random randomNumber = new Random();


    public ReflectionActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _prompts = new List<string>();
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _questions = new List<string>();
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(5);
        DisplayPrompt();
        DisplayQuestions();
        Console.WriteLine("Well done!");
        ShowSpinner(5);
        DisplayEndingMessage(); //not running
        ShowSpinner(5);
    }

    public string GetRandomPrompt()
    {
        int p = randomNumber.Next(_prompts.Count);
        string prompt = _prompts[p];
        return prompt;
    }

    public string GetRandomQuestion()
    {
        int q = randomNumber.Next(_questions.Count);
        string question = _questions[q];
        return question;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();
        Console.Write("---");
        Console.Write(GetRandomPrompt());
        Console.WriteLine("---");
        Console.WriteLine();     
        Console.WriteLine("When you have something in mind, press enter to continue.");
        string x = Console.ReadLine();
        Console.WriteLine();
    }

    public void DisplayQuestions()
    {
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {        
            Console.Write(GetRandomQuestion());
            ShowSpinner(10);
            Console.WriteLine();
        }
    }
}