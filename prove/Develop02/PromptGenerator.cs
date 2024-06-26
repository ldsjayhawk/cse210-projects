using System.Formats.Asn1;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "How did I see the hand of the Lord in your life today?",
        "What did the Spirit prompt you to do today?",
        "What was the best part of your day?",
        "What did you learn today?",
        "What was a challenge you faced today?"
    };

    public Random rng = new Random();

    public string GetRandomPrompt()
    {
        int index = rng.Next(1,5);
        return _prompts[index];
    }
}
