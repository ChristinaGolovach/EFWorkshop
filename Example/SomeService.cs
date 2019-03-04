using System;
using System.Linq;
using System.Data.Entity;
using DAL.Context;

namespace Example
{
    public class SomeService
    {
        public void DoSmth()
        {
            using (var context = new AppDbContext())
            {
                var items = context.Items.ToList();

                Console.WriteLine($"Items number: {items.Count}");

                foreach (var item in items)
                {
                    Console.WriteLine($"{item.Id} - {item.Description} - {item.Price}");
                }
            }
        }

        public void ShowCustomers()
        {
            using (var context = new AppDbContext())
            {
                var customers = context.Customers.Include(c => c.Orders).ToList();

                Console.WriteLine(Environment.NewLine + "The list of customers:");

                foreach (var customer in customers)
                {
                    var orders = customer.Orders;

                    Console.WriteLine(Environment.NewLine + $"Customer: ID - {customer.Id}, Name - {customer.Name}, Order count:{orders.Count}");
                    Console.WriteLine($"Orders:");

                    foreach(var order in orders)
                    {
                        Console.WriteLine($"ID - {order.Id}, Date - {order.Date}");
                    }
                }
            }
        }
    }
}