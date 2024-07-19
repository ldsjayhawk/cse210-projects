public class Outdoor : Event
{
    private string _weather;

    public Outdoor(string type, string title, string description, string date, string time, string address, string weather) : base(type, title, description, date, time, address)
    {
        _weather = weather;
    }
    public void FullDetails()
    {
        Console.WriteLine("-----------------------------------------------------");
        Console.WriteLine($"{_title} {_description}");
        Console.WriteLine($"When: {_date} @ {_time}");
        Console.WriteLine($"Where: {_address}");
        Console.WriteLine("-----------------------------------------------------");
    }
}