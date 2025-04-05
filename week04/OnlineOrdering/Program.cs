using System;

class Program
{
    static void Main(string[] args)
    {
        Address addr1 = new Address("123 Apple St", "New York", "NY", "USA");
        Customer cust1 = new Customer("Alice Johnson", addr1);
        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Notebook", "A101", 3.50, 4));
        order1.AddProduct(new Product("Pen", "B202", 1.25, 10));
        order1.AddProduct(new Product("Pillow", "A576", 30.00, 2));

        Address addr2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");
        Customer cust2 = new Customer("Carlos Ruiz", addr2);
        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("Backpack", "C303", 25.00, 1));
        order2.AddProduct(new Product("Binder", "D404", 4.75, 2));

        List<Order> orders = new List<Order> {order1, order2};

        foreach (Order order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order.GetTotalCost():F2}\n");
        }

    }
}