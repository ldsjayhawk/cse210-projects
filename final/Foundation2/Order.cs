using System.Runtime.CompilerServices;

public class Order
{
    List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product newProduct)
    {
        _products.Add(newProduct);
    }
    
    public void CalculateTotal()
    {
        decimal subtotal = 0;
        decimal shippingCost = 5;
        foreach (Product p in _products)
        {
            subtotal += p.GetTotalPrice();
        }
                
        if (!_customer.DetermineUsa())
            shippingCost = 35;

        decimal orderTotal = subtotal + shippingCost; 

        Console.WriteLine(orderTotal);
    }

    public void PackingLabel()
    {
        Console.WriteLine("Packing Info");
        Console.WriteLine("-------------");
        foreach(Product p in _products)
            p.DisplayProduct();
    }


    public void ShippingLabel()
    {
        Console.WriteLine("-------------");
        Console.WriteLine("Ship To:");
        Console.WriteLine("-------------");

        _customer.DisplayCustomer();
        _customer.DisplayAddress();
    }
    
}