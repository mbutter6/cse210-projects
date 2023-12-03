using System;

class Program
{
    static void Main(string[] args)
    {
        {
            Address address1 = new Address { Street = "123 Main St", City = "Anytown", State = "CA", Country = "USA" };
            Customer customer1 = new Customer { Name = "John Doe", Address = address1 };

            Address address2 = new Address { Street = "456 Oak St", City = "Another City", State = "NY", Country = "Canada" };
            Customer customer2 = new Customer { Name = "Jane Smith", Address = address2 };

            Product product1 = new Product { Name = "Laptop", ProductId = 1, Price = 800, Quantity = 2 };
            Product product2 = new Product { Name = "Mouse", ProductId = 2, Price = 20, Quantity = 3 };

            Order order1 = new Order(customer1);
            order1.AddProduct(product1);
            order1.AddProduct(product2);

            Order order2 = new Order(customer2);
            order2.AddProduct(product1);

            // Display results
            Console.WriteLine("Order 1:");
            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order1.CalculateTotalCost()}");

            Console.WriteLine("\nOrder 2:");
            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order2.CalculateTotalCost()}");
        }
    }

}
