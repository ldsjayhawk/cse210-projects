using System.Runtime.CompilerServices;

public class Address
{

    private string _street;
    private string _city;
    private string _state;
    private string _country;
    private bool _isUsa;


    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public void SetUsa()
    {
        _isUsa = false;
    }

    public bool IsUsa()
    {
        if (_country == "USA")
            _isUsa = true;

        return _isUsa;
    } 

    public void DisplayShipping()
    {
        Console.WriteLine($"{_street}");
        Console.WriteLine($"{_city}, {_state} \n {_country}");
    }

}