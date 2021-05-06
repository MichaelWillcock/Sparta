using System;
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
                Console.WriteLine("Querying for a customer");

                var customerQuery = db.Customers.OrderBy(c => c.ContactName);
                var customer = customerQuery.Where(c => c.ContactName.Contains("Cath")).FirstOrDefault();
                Console.WriteLine($"Customer details: {customer.ContactName} lives in {customer.City}");

                //update a customer
                var nish1 = db.Customers.Find("MANDA");
                nish1.City = "London";
                db.SaveChanges();

                //find a customer and create an order for them
                var nish2 = db.Customers.Find("MANDA");
                nish1.Orders.Add(new Order { CustomerId = "MANDA", OrderDate = DateTime.Now, ShipCountry = "Brazil" });
                db.SaveChanges();

                //create and order and associate it with a customer
                var nish3 = db.Customers.Find("MANDA");
                var order1 = new Order { OrderDate = DateTime.Now, ShipCountry = "India", Customer = nish3 };
                db.SaveChanges();

            }
        }
    }
}
