using System;

class Program
{
static void Main(string[] args)
{
Address usaAddress = new Address("123 Main St", "Anytown", "CA", "USA");
Address canadaAddress = new Address("456 First St", "Somewhere", "ON", "Canada");

    Customer usaCustomer = new Customer("John Smith", usaAddress);
    Customer canadaCustomer = new Customer("Gaby Ugarte", canadaAddress);

    List<Product> usaProducts = new List<Product>()
    {
        new Product("Product 1", "P1", 10.0, 2),
        new Product("Product 2", "P2", 5.0, 3),
        new Product("Product 3", "P3", 7.5, 1)
    };
    List<Product> canadaProducts = new List<Product>()
    {
        new Product("Product 4", "P4", 15.0, 1),
        new Product("Product 5", "P5", 20.0, 2)
    };

    Order usaOrder = new Order(usaProducts, usaCustomer);
    Order canadaOrder = new Order(canadaProducts, canadaCustomer);

    Console.WriteLine("USA Order");
    Console.WriteLine("Total Price: $" + usaOrder.CalculateTotalPrice());
    Console.WriteLine("Packing Label:\n" + usaOrder.GetPackingLabel());
    Console.WriteLine("Shipping Label:\n" + usaOrder.GetShippingLabel());

    Console.WriteLine();

    Console.WriteLine("Canada Order");
    Console.WriteLine("Total Price: $" + canadaOrder.CalculateTotalPrice());
    Console.WriteLine("Packing Label:\n" + canadaOrder.GetPackingLabel());
    Console.WriteLine("Shipping Label:\n" + canadaOrder.GetShippingLabel());
}
}

