using System;

class Program
{
    static void Main(string[] args)
    {
        //us order
        Address addr1 = new Address("649 South 2nd East", "Rexburg", "ID", "USA");
        Customer cust1 = new Customer("Jimmy John", addr1);
        Order order1 = new Order(cust1);

        order1.AddProduct(new Product("Soccerball", "M123", 32.99, 1));
        order1.AddProduct(new Product("Soccer Jursey", "K555", 110.50, 2));

        //not us order 
        Address addr2 = new Address("78 King Road", "Toronto", "ON", "Canada");
        Customer cust2 = new Customer("Ronold McDonold", addr2);
        Order order2 = new Order(cust2);

        order2.AddProduct(new Product("Happy Meal boxes", "C002", 7.99, 5));
        order2.AddProduct(new Product("Makup", "L777", 20.00, 4));

        //showing orders
        DisplayOrder(order1);
        Console.WriteLine("\n");
        DisplayOrder(order2);
    }

    static void DisplayOrder(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"TOTAL PRICE: ${order.GetTotalCost():0.00}");
    }
}
