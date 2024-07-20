using System;

class Program
{
    static void Main(string[] args)
    {

        Address a1 = new Address("123 Main St","Los Angeles", "CA", "USA");
        Customer c1 = new Customer("Johnny Rockstar",a1);
        Order o1 = new Order(c1);

        Product p1 = new Product("apple", "f001", 1.99m, 1);
        Product p2 = new Product("ribeye steak", "m033", 7.99m, 2);
        Product p3 = new Product("Cocoa Krispies", "ce023", 5.99m, 3);
        Product p4 = new Product("tomato soup", "cg114", 1.49m, 6);

        o1.AddProduct(p1);
        o1.AddProduct(p2);
        o1.AddProduct(p3);
        o1.AddProduct(p4);

        Console.Clear();
        Console.WriteLine("-------------");
        o1.PackingLabel();
        Console.WriteLine("-------------");
        Console.Write("Order Total: ");
        o1.CalculateTotal();
        Console.WriteLine();
        o1.ShippingLabel();
        Console.WriteLine();

        Address a2 = new Address("123 Water St","Toronto", "ON", "Canada");
        Customer c2 = new Customer("George Ballplayer",a2);
        Order o2 = new Order(c2);

        Product p5 = new Product("Sofa", "LR1", 899.99m, 1);
        Product p6 = new Product("Recliner", "LR2", 499.99m, 2);
        Product p7 = new Product("Coffee Table", "LR3", 199.99m, 2);
        Product p8 = new Product("Dining Chairs", "DR2", 49.99m, 4);

        o2.AddProduct(p5);
        o2.AddProduct(p6);
        o2.AddProduct(p7);
        o2.AddProduct(p8);

        Console.WriteLine("-------------");
        o2.PackingLabel();
        Console.WriteLine("-------------");
        Console.Write("Order Total: ");
        o2.CalculateTotal();
        Console.WriteLine();
        o2.ShippingLabel();
        Console.WriteLine();
    }
}