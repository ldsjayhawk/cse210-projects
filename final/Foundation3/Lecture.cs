public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string type, string title, string description, string date, string time, string address, string speaker, int capacity) : base(type, title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public void FullDetails()  //move to each class
    {
        Console.WriteLine("-----------------------------------------------------");
        Console.WriteLine($"{_title} {_description}");
        Console.WriteLine($"Speaker: {_speaker} ");
        Console.WriteLine($"When: {_date} @ {_time}");
        Console.WriteLine($"Where: {_address}");
        Console.WriteLine($"Capacity: {_capacity}");
        Console.WriteLine("-----------------------------------------------------");
    }

}