using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Creates an address for a customer
        Address address1 = new Address("123 Main St", "Anytown","Anystate", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        //Creates three product for the first order
        Product product1 = new Product("Product A", "PA001", 5, 2);
        Product product2 = new Product("Product B", "PB002", 2, 3);
        Product product3 = new Product("Product C", "PC003", 18, 1);

        //Adds products for order 1 to a list and creates an order
        List<Product> products1 = new List<Product>() {product1, product2, product3};
        Order order1 = new Order(customer1, products1);

        //Creates an address for a second customer
        Address address2 = new Address("456 Terrago Ave", "Charlottetown", "PEI", "Canada");
        Customer customer2 = new Customer("Anne Shirley", address2);

        //Creates 3 products for second customer's first order
        Product product4 = new Product("Product D", "PD004", 30, 2);
        Product product5 = new Product("Product E", "PE005", 16, 1);
        Product product6 = new Product("Product F", "PF006", 3, 4);

        //Adds products for oder2 to a list and creates an order
        List<Product> products2 = new List<Product>() {product4, product5, product6};
        Order order2 = new Order(customer2, products2);

        //Creates three products for second customer's second order
        Product product7 = new Product("Product G", "PG007", 17, 3);
        Product product8 = new Product("Product H", "PH008", 22, 1);
        Product product9 = new Product("Product I", "PI009", 6, 5);

        //Adds products for order 3 to a list and creates an order
        List<Product> products3 = new List<Product>() {product7, product8, product9};
        Order order3 = new Order(customer2, products3);

        //Displays packing label, shipping label and total price for Order 1
        Console.WriteLine($"Order 1, Packing Label:\n{order1.GetPackingLabel()}");
        Console.WriteLine($"\nOrder 1, Shipping Label:\n{order1.GetShippingLabel()}");
        Console.WriteLine($"\nOrder 1, Total Price:\n{order1.CalculateTotalPrice()}");

        //Displays packing label, shipping label and total price for Order 2
        Console.WriteLine($"\n\nOrder 2, Packing Label:\n{order2.GetPackingLabel()}");
        Console.WriteLine($"\nOrder 2, Shipping Label:\n{order2.GetShippingLabel()}");
        Console.WriteLine($"\nOrder 2, Total Price:\n{order2.CalculateTotalPrice()}");

        //Displays packing label, shipping label and total price for Order 3
        Console.WriteLine($"\n\nOrder 3, Packing Label:\n{order3.GetPackingLabel()}");
        Console.WriteLine($"\nOrder 3, Shipping Label:\n{order3.GetShippingLabel()}");
        Console.WriteLine($"\nOrder 3, Total Price:\n{order3.CalculateTotalPrice()}");
    }
}