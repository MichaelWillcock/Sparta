using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SouthwindApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new SouthwindContext())
            {
                //Console.WriteLine("Creating two customers");
                //db.Add(new Customer { CustomerId = "MANDA", City = "Birmingham"
                //    , ContactName = "Nish Mandal", Country = "UK", PostalCode = "B74BB" });

                //db.Add(new Customer
                //{
                //    CustomerId = "FRENC",
                //    City = "Birmingham",
                //    ContactName = "Cathy French",
                //    Country = "UK",
                //    PostalCode = "ABC123"
                //});
                //db.SaveChanges();

                //Read a query
                //Console.WriteLine("Querying for a customer");

                //var customerQuery = db.Customers.OrderBy(c => c.ContactName);
                //var customer = customerQuery.Where(c => c.ContactName.Contains("Cath")).FirstOrDefault();
                //Console.WriteLine($"Customer details: {customer.ContactName} lives in {customer.City}");

                ////update a customer
                //var nish1 = db.Customers.Find("MANDA");
                //nish1.City = "London";
                //db.SaveChanges();

                ////find a customer and create an order for them
                //var nish2 = db.Customers.Find("MANDA");
                //nish1.Orders.Add(new Order { CustomerId = "MANDA", OrderDate = DateTime.Now, ShipCountry = "Brazil" });
                //db.SaveChanges();

                ////create and order and associate it with a customer
                //var nish3 = db.Customers.Find("MANDA");
                //var order1 = new Order { OrderDate = DateTime.Now, ShipCountry = "India", Customer = nish3 };
                //db.SaveChanges();

                //var order = db.Orders.Find(1);

                //var orderDetails1 = new OrderDetail { UnitPrice = 30.00m, Discount = 0.5f, Quantity = 2 };
                //var orderDetails2 = new OrderDetail { UnitPrice = 10.00m, Discount = 0.25f, Quantity = 1 };

                //var orderDetailsList = new List<OrderDetail>();
                //orderDetailsList.Add(orderDetails1);
                //orderDetailsList.Add(orderDetails2);

                //order.OrderDetails = orderDetailsList;
                //db.SaveChanges();

                ////Include the list of orders when a customer is retrieved
                ///
                //var custQuery = db.Customers.OrderBy(c => c.ContactName);

                //foreach (var c in custQuery.Include(c => c.Orders))
                //{
                //    Console.WriteLine($"{c.ContactName} live in {c.City}");
                //    if (c.Orders.Count >0)

                //    foreach (var orders in c.Orders)
                //        {
                //            Console.WriteLine($"\tOrder {orders.OrderId} by {orders.Customer.ContactName}" +
                //                $" was made on {orders.OrderDate.Value.Date}");
                //        }
                //}
                //var orderDetails = db.OrderDetails.Include(od => od.Order).ThenInclude(o => o.OrderDetails);
                //orderDetails.ToList().ForEach(od => Console.WriteLine($"{od.Order.Customer.ContactName} made an order" +
                //    $" with ID {od.Order.OrderId} with the unit price of {od.UnitPrice} without discount"));
            }
        }
    }
}
