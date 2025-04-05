using System;

class Program
{
    static void Main(string[] args)
    {
        Address addr1 = new Address("123 Apple St", "New York", "NY", "USA");
        Customer cust1 = new Customer("Alice Johnson", addr1);
        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Notebook", "A101", 3.50, 4));
        
    }
}