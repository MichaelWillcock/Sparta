using System;
using System.Collections.Generic;
using System.Linq;
using CodeFromNorthwind;

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
                ////deffered query
                //var query1 =
                //    from c in db.Customers
                //    where c.City == "London"
                //    select c;

                ////forcing query execution
                //var queryList = query1.ToList();

                //foreach (var item in query1)
                //{
                //    Console.WriteLine(item);
                //}

                //var londonOrBerlinQuery1 =
                //    from customer in db.Customers
                //    where customer.City == "London" || customer.City == "Berlin"
                //    select customer;

                //foreach (var item in londonOrBerlinQuery1)
                //{
                //    Console.WriteLine(item);
                //}

                //var londonOrBerlinQuery2 =
                //    from customer in db.Customers
                //    where customer.City == "London" || customer.City == "Berlin"
                //    select new { CustomerName = customer.CompanyName, Country = customer.Country };

                //foreach (var item in londonOrBerlinQuery2)
                //{
                //    Console.WriteLine(item);
                //}

                //var groupProductsByUnitInStockQuery =
                //    from p in db.Products
                //    group p by p.SupplierId into newGroup
                //    orderby newGroup.Sum(c => c.UnitsInStock) descending
                //    select new
                //    {
                //        SupplierID = newGroup.Key,
                //        UnitsOnStock = newGroup.Sum(c => c.UnitsInStock)
                //    };

                //foreach (var item in groupProductsByUnitInStockQuery)
                //{
                //    Console.WriteLine(item);
                //}

                //var x = db.Products.GroupBy(c => c.SupplierId);

                //var orderProductsByUnitPrice =
                //    from p in db.Products
                //    orderby p.UnitPrice descending
                //    select p;

                //orderProductsByUnitPrice.ToList().ForEach(p => Console.WriteLine($"{p.ProductId} - {p.UnitPrice}"));

                ////CRUD OPERATIONS
                //CREATE
                //var newCustomer = new Customer
                //{
                //    CustomerId = "HARDI",
                //    ContactName = "Callum Harding",
                //    CompanyName = "Sparta Global"
                //};

                //db.Customers.Add(newCustomer);
                //db.SaveChanges();


                //UPDATE
                //var selectedCustomer =
                //    from c in db.Customers
                //    where c.CustomerId == "HARDI"
                //    select c;

                //foreach (var customer in selectedCustomer)
                //{
                //    customer.City = "Paris";
                //}
                //db.SaveChanges();

                //DELETE
                //var selectedCustomer =
                //    from c in db.Customers
                //    where c.CustomerId == "HARDI"
                //    select c;

                //foreach (var customer in selectedCustomer)
                //{
                //    db.Customers.Remove(customer);
                //}
                //db.SaveChanges();

            }
        }
    }
}
