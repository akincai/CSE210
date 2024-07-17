using System;

class Program
{
    static void Main(string[] args)
    {
        Customer c1 = new Customer("Jasper Imanez", new Address("123 End Way", "Townsville", "Georgia", "USA"));
        Order o1 = new Order(c1);
        o1.AddProducts(new List<Product>{
            new Product("banana", "B005", .95f, 12),
            new Product("diapers", "D024", 19.25f, 3)
        });
        
        Customer c2 = new Customer("Matthew Brown", new Address("425 Hockey Court", "Vancouver", "British Columbia", "Canada"));
        Order o2 = new Order(c2);
        //showcasing both functionalities of .AddProducts()
        o2.AddProducts(new Product("potato chips", "P063", 4.99f, 8));
        o2.AddProducts(new Product("maple syrup", "m124", 6.52f, 10));

        Console.WriteLine(o1.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(o1.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"${o1.CalculateSubtotal()}");

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine(o2.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(o2.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"${o2.CalculateSubtotal()}");

    }
}