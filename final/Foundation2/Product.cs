using System.Data.Common;
using System.Security.Cryptography;

public class Product
{
    private string _productName;
    private string _productId;
    private decimal _price;
    private int _quantity;

    public Product (string productName, string id, decimal price, int quantity)
    {
        _productName = productName;
        _productId = id;
        _price = price;
        _quantity = quantity;
    }
    public decimal GetTotalPrice()
    {
        return _quantity * _price;
    }

    public void DisplayProduct()
    {
        Console.WriteLine($"{_productName} {_productId}");
    }
}