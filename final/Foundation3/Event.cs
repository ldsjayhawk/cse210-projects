using System.ComponentModel.Design;
using System.Numerics;

public class Event
{
    private string _type;
    protected string _title;
    protected string _description;

    protected string _date;

    protected string _time;

    protected string _address;

    public Event (string type, string title, string description, string date, string time, string address)
    {
        _type = type;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public void StandardDetails()
    {
        Console.WriteLine($"Standard Details:");
        Console.WriteLine($"{_title} {_description}");
        Console.WriteLine($"{_date} {_time} {_address}");
    }

    public void ShortDetails()
    {
        Console.WriteLine("Short Details:");
        Console.WriteLine($"{_type} {_title} {_address}");
    }
}