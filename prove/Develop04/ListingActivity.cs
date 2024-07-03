using System.Diagnostics;

public class ListingActivity : Activity
{

    private int _count;
    private List<string> _prompts;

    public ListingActivity(string name, string description, int duration,int count) : base(name, description, duration)
    {
        _count = count;
        _prompts = new List<string>();
    }

    public void vRun()
    {

    }
    public void GetRandomPrompt()
    {

    }
    
    public void GetListFromUser()
    {

    }
}