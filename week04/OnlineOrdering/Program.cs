using System;

class Program
{
    static void Main(string[] args)
    {
        // Order no 1: customer inside the U.S

         Address address1 = new Address("123 Maple Street", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("Jordan Smith", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Wireless Mouse", "WM-1024", 24.99m, 2));
        order1.AddProduct(new Product("Mechanical Keyboard", "MK-2048", 89.50m, 1));
        order1.AddProduct(new Product("USB-C Cable", "UC-4096", 9.99m, 3));

        // Order no 2: customer outside the U.S
        Address address2 = new Address("45 King Street West", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Priya Patel", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Noise-Cancelling Headphones", "NC-5550", 199.00m, 1));
        order2.AddProduct(new Product("Laptop Stand", "LS-6660", 45.75m, 2));

        // Display results 
        DisplayOrder(order1, 1);
        DisplayOrder(order2, 2);
    }

    static void DisplayOrder(Order order, int number)
    {
        Console.WriteLine($"========== ORDER {number} ==========");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order.GetTotalPrice():F2}");
        Console.WriteLine();
    }
}