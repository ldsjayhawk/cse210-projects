using System.Collections;
using System.ComponentModel;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer (string name, Address address)
    {
        _name = name;
        _address = address;
    }
    

    public bool DetermineUsa()
    //Determines if customer is in USA
    {
        return _address.IsUsa();
    }

    public void DisplayCustomer()
    {
        Console.WriteLine($"{_name}");
    }
    public void DisplayAddress()
    {
        _address.DisplayShipping();
    }
}