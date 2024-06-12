using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Customers
{
    public int  CustomID { get; set; }
    public string Name { get; set; }
}
public class Order
{
    public int OrderID { get; set; }
    public int CustomID { get; set; }
    public decimal TotalAmount { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        List<Customers> customers = new List<Customers>()
        {
            new Customers { CustomID = 1, Name = "Alice"},
            new Customers { CustomID = 2, Name = "Bob"},
            new Customers { CustomID = 3, Name = "Charlie"},

        };
        List<Order> orders = new List<Order>()
        {
            new Order { OrderID = 101, CustomID = 1, TotalAmount = 50.75m },
            new Order { OrderID = 102, CustomID = 1, TotalAmount = 30.20m },
            new Order { OrderID = 103, CustomID = 3, TotalAmount = 100.00m },
        };
        var query = from customer in customers
                    join order in orders on customer.CustomID equals order.CustomID
                    select new
                    {
                        customer.Name,
                        order.OrderID,
                        order.TotalAmount,
                    };
        foreach (var item in query)
        {
            Console.WriteLine($"Customer: { item.Name}, OrderID: {item.OrderID}, Total Amount: {item.TotalAmount}");
        }
    }
}

