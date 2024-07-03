using System.Diagnostics;

public class ReflectionActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectionActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _prompts = new List<string>();
        _questions = new List<string>();
        _prompts.Add("");


        public void Run()
        {

        }
        public string GetRandomPrompt()
        {

        }
        public string GetRandomQuestion()
        {

        }
        public void DisplayPrompt()
        {
            
        }
        public void DisplayQuestions()
        {

        }
    }


}