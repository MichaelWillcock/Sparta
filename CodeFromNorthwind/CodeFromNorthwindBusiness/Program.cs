using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using CodeFromNorthwind;
using Microsoft.EntityFrameworkCore;

namespace CodeFromNorthwindBusiness
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (var db = new NorthwindContext())
            //{
            //    ////READ
            //    //foreach (var c in db.Customers)
            //    //{
            //    //    Console.WriteLine(c);
            //    //}

            //    ////CREATE
            //    //var newCustomer = new Customer
            //    //{
            //    //    CustomerId = "FRENC",
            //    //    ContactName = "Cathy French",
            //    //    CompanyName = "Sparta Global"
            //    //};

            //    //db.Customers.Add(newCustomer);
            //    //db.SaveChanges();

            //    ////UPDATE
            //    //var selectedCustomer = db.Customers.Where(c => c.CustomerId == "FRENC").FirstOrDefault();

            //    //change city of selected customer
            //    //selectedCustomer.City = "Ottowa";
            //    //save changes to db
            //    //db.SaveChanges();

            //    ////DELETE
            //    var selectedCustomer = db.Customers.Where(c => c.CustomerId == "FRENC").FirstOrDefault();

            //    //delete customer
            //    db.Customers.Remove(selectedCustomer);
            //    db.SaveChanges();
            //}

            using (var db = new NorthwindContext())
            {
                //var orderQuery =
                //    from order in db.Orders.Include(o => o.Customer)
                //    where order.Freight > 750
                //    select order;

                //foreach (var order in orderQuery)
                //{
                //    Console.WriteLine($"{order.Customer.CompanyName} paid {order.Freight} for shipping to {order.ShipCity}");
                //}

                var orderQueryWithCust =
                    db.Orders.Include(o => o.Customer).Include(o => o.OrderDetails).ThenInclude(od => od.Product);

                foreach (var o in orderQueryWithCust)
                {
                    Console.WriteLine($"Order {o.OrderId} was made by {o.Customer.CompanyName}");
                    foreach (var od in o.OrderDetails)
                    {
                        Console.WriteLine($"\t Product: {od.Product.ProductName} - Quantity: {od.Quantity}");
                    }
                }
            }


        }
    }
    //    static bool isYoung(Person P)
    //    {
    //        return P.Age < 30;
    //    }
    //    static bool isEven(int x)
    //    {
    //        return x % 2 == 0;
    //    }
    //}
    //public class Person
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }
    //}
}
