// using System;
// using System.Collections.Generic;

// // Note: Comment out Program I(in Videotracker folder) to run Program II 

// // This program is for the Online Order System

// // Program II

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Create products
//             Product product1 = new Product("Laptop", "P001", 800, 1);
//             Product product2 = new Product("Mouse", "P002", 25, 2);
//             Product product3 = new Product("Keyboard", "P003", 45, 1);

//             Product product4 = new Product("Smartphone", "P004", 600, 1);
//             Product product5 = new Product("Charger", "P005", 20, 3);

//             // Create customers and addresses
//             Address address1 = new Address("123 Main St", "New York", "NY", "USA");
//             Customer customer1 = new Customer("Alice", address1);

//             Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
//             Customer customer2 = new Customer("Bob", address2);

//             // Create orders
//             Order order1 = new Order(customer1);
//             order1.AddProduct(product1);
//             order1.AddProduct(product2);
//             order1.AddProduct(product3);

//             Order order2 = new Order(customer2);
//             order2.AddProduct(product4);
//             order2.AddProduct(product5);

//             // Display order details
//             Console.WriteLine("Order 1:");
//             Console.WriteLine(order1.GetPackingLabel());
//             Console.WriteLine(order1.GetShippingLabel());
//             Console.WriteLine($"Total Price: ${order1.GetTotalPrice():0.00}\n");

//             Console.WriteLine("Order 2:");
//             Console.WriteLine(order2.GetPackingLabel());
//             Console.WriteLine(order2.GetShippingLabel());
//             Console.WriteLine($"Total Price: ${order2.GetTotalPrice():0.00}\n");
//         }
//     }

