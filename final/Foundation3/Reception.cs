public class Reception : Event
{
    private string _email;

    public Reception (string type, string title, string description, string date, string time, string address, string email) : base(type, title, description, date, time, address)
    {
        _email = email;
    }
    public void FullDetails()  //move to each class
    {
        Console.WriteLine("-----------------------------------------------------");
        Console.WriteLine($"{_title} {_description}");
        Console.WriteLine($"When: {_date} @ {_time}");
        Console.WriteLine($"Where: {_address}");
        Console.WriteLine($"RSVP: {_email}"); 
        Console.WriteLine("-----------------------------------------------------");
    }
}