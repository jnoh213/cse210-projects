using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create address objects
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Elm St", "Shelbyville", "IL", "Canada");

        // Create customer objects
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create product objects
        Product product1 = new Product("Laptop", "P001", 1000, 1);
        Product product2 = new Product("Mouse", "P002", 50, 2);
        Product product3 = new Product("Keyboard", "P003", 80, 1);
        Product product4 = new Product("Monitor", "P004", 300, 1);

        // Create order objects
        Order order1 = new Order(customer1, new List<Product> { product1, product2 });
        Order order2 = new Order(customer2, new List<Product> { product3, product4 });

        // Display information for each order
        foreach (var order in new List<Order> { order1, order2 })
        {
            order.DisplayPackingLabel();
            Console.WriteLine();
            order.DisplayShippingLabel();
            Console.WriteLine();
            Console.WriteLine($"Total Cost: ${order.GetTotalCost()}");
            Console.WriteLine();
        }
    }
}
