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

                //var orderQueryWithCust =
                //    db.Orders.Include(o => o.Customer).Include(o => o.OrderDetails).ThenInclude(od => od.Product);

                //foreach (var o in orderQueryWithCust)
                //{
                //    Console.WriteLine($"Order {o.OrderId} was made by {o.Customer.CompanyName}");
                //    foreach (var od in o.OrderDetails)
                //    {
                //        Console.WriteLine($"\t Product: {od.Product.ProductName} - Quantity: {od.Quantity}");
                //    }
                //}


                //////SQL MINI PROJECT
                //QUESTION 1.1 Query Syntax
                //var customersInParisOrLondonQuery =
                //    from c in db.Customers
                //    where c.City == "London" || c.City == "Paris"
                //    select c;
                //Question 1.1 Method Syntax
                //var customersInParisOrLondonQuery2 = db.Customers.Where(c => c.City == "London" || c.City == "Paris");
                //foreach (var item in customersInParisOrLondonQuery2)
                //{
                //    Console.WriteLine($"{c.CompanyName} is located in {c.City},{c.Country}");
                //}

                ////Question 1.2 Query Syntax
                //var productsInBottlesQuery =
                //    from p in db.Products
                //    where p.QuantityPerUnit.Contains("bottle")
                //    select p;
                //foreach (var product in bottleQuery)
                //{
                //    Console.WriteLine($"Products which are contained in bottles are {product.ProductName}. Quantity Per Unit: {product.QuantityPerUnit}");
                //}
                ////Question 1.2 Method Syntax
                //var productsInBottlesQuery2 =
                //    db.Products.Where(p => p.QuantityPerUnit.Contains("bottle"));
                //foreach (var p in productsInBottlesQuery2)
                //{
                //    Console.WriteLine($"Products which are contained in bottles are {p.ProductName}. Quantity Per Unit: {p.QuantityPerUnit}");
                //}

                ////Question 1.3 Query Syntax
                //var productsInBottlesQuery =
                //    from products in db.Products
                //    join supplier in db.Suppliers on product.SupplierId equals supplier.SupplierId
                //    where products.QuantityPerUnit.Contains("bottle")
                //    select new { productName = products.ProductName, supplierName = supplier.CompanyName, quantityPerUnit = product.QuantityPerUnit };
                //foreach (var result in bottleQueryJoin)
                //{
                //    Console.WriteLine($"Product:{result.productName}. Company Name: {result.supplierName}. Quantity per Unit: {result.quantityPerUnit}");
                //}
                ////Question 1.3 Method Syntax
                //var productsInBottlesQuery =
                //    db.Products.Where(p => p.QuantityPerUnit.Contains("bottle")).Include(s => s.Supplier);
                //foreach (var p in productsInBottlesQuery)
                //{
                //    Console.WriteLine($"Product:{p.ProductName}. Company Name: {p.CompanyName}. Quantity per Unit: {p.QuantityPerUnit}");
                //}

                ////Question 1.4 Query Syntax
                //var productsGroupedByCategoryQuery =
                //    from products in db.Products
                //    join category in db.Categories on product.CategoryId equals category.CategoryId
                //    group products by category.CategoryName into newGroup
                //    select new { Category = newGroup.Key, NumOfProd = newGroup.Count() };
                //foreach (var result in productsGroupedByCategoryQuery)
                //{
                //    Console.WriteLine($"{result.Category} - {result.NumOfProd}");
                //}
                ////Question 1.4 Method Syntax
                //var productsGroupedByCategoryQuery2 =
                //    db.Products.Include(c => c.Category).ToList().GroupBy(C => C.Category.CategoryName);
                //foreach (var result in productsGroupedByCategoryQuery2)
                //{
                //    Console.WriteLine($"{result.Key} - {result.Count()}");
                //}

                ////Question 1.5 Query Syntax
                //var ukResidentsQuery =
                //    from e in db.Employees
                //    where e.Country == "UK"
                //select new { firstName = emp.FirstName, lastName = emp.LastName, Country = emp.Country };
                //foreach (var item in ukResidentsQuery)
                //{
                //Console.WriteLine($"{result.firstName} {result.lastName} - {result.Country}");
                //}
                ////Question 1.6 Method Syntax
                //var ukResidentsQuery2 =
                //    db.Employees.Where(e => e.Country == "UK");
                //foreach (var result in ukResidentsQuery2)
                //{
                //    Console.WriteLine($"{result.FirstName} {result.LastName} - {result.Country}");
                //}

                ////Question 1.6 Query Syntax
                //var manyJoinsQuery =
                //    from r in db.Regions
                //    join t in db.Territories on r.RegionId equals t.RegionId
                //    join et in db.EmployeeTerritories on t.TerritoryId equals et.TerritoryId
                //    join o in db.Orders on et.EmployeeId equals o.EmployeeId
                //    join od in db.OrderDetails on o.OrderId equals od.OrderId
                //    group od by new { r.RegionId, r.RegionDescription } into g
                //    where g.Sum(od => od.Quantity * od.UnitPrice * (decimal)(1 - od.Discount)) > 1000000
                //    select new
                //    {
                //        g.Key.RegionId,
                //        Region = g.Key.RegionDescription,
                //        SalesTotal = Math.Round(g.Sum(od => od.Quantity * od.UnitPrice * (decimal)(1 - od.Discount)), 2)
                //    };
                ////Question 1.6 Method Syntax
                //var manyJoinsQuery2 = db.Regions
                //    .Include(r => r.Territories)
                //    .ThenInclude(t => t.EmployeeTerritories)
                //    .ThenInclude(et => et.Employee)
                //    .ThenInclude(e => e.Orders)
                //    .ThenInclude(o => o.OrderDetails)
                //    .Select(r => new { r.RegionId, r.RegionDescription, r.Territories });
                //foreach (var region in manyJoinsQuery2)
                //{
                //    decimal sum = 0;

                //    foreach (var territory in region.Territories)
                //    {
                //        foreach (var employeeTerritory in territory.EmployeeTerritories)
                //        {
                //            foreach (var order in employeeTerritory.Employee.Orders)
                //            {
                //                foreach (var orderDetails in order.OrderDetails)
                //                {
                //                    sum += orderDetails.UnitPrice * orderDetails.Quantity * (decimal)(1 - orderDetails.Discount);
                //                }
                //            }
                //        }
                //    }

                //    if (sum > 1000000)
                //    {
                //        Console.WriteLine($"RegionId: {region.RegionId}, Region: {region.RegionDescription}, Sales Total: {Math.Round(sum, 2)}");
                //    }
                //}

                ////Question 1.7 Query Syntax
                //var moreThan100OrdersUKUSQuery =
                //    (from order in db.Orders
                //     where order.Freight > 100 && (order.ShipCountry == "UK" || order.ShipCountry == "USA")
                //     select order).Count();
                //Console.WriteLine($"{moreThan100OrdersUKUSQuery}");
                ////Question 1.7 Method Syntax
                //var moreThan100OrdersUKUSQuery2 =
                //    db.Orders.Where(x => x.Freight > 100).Where(y => y.ShipCountry.Contains("USA") || y.ShipCountry.Contains("UK")).Count();

                //Console.WriteLine($"No. of Order >100 from US or UK {moreThan100OrdersUKUSQuery2}");

                ////Question 1.8 Query Syntax
                //var query1_8q =
                //    (
                //        from o in db.Orders
                //        join od in db.OrderDetails on o.OrderId equals od.OrderId
                //        orderby o.OrderDetails.Sum(od => (float)od.UnitPrice * od.Quantity * od.Discount) descending
                //        select new { o.OrderId, Discount = o.OrderDetails.Sum(od => (float)od.UnitPrice * od.Quantity * od.Discount) }
                //    ).First();
                ////Question 1.8 Method
                //var query1_8m = db.Orders
                //    .Include(o => o.OrderDetails)
                //    .OrderByDescending(o => o.OrderDetails.Sum(od => (float)od.UnitPrice * od.Quantity * od.Discount))
                //    .Select(o => new { o.OrderId, Discount = o.OrderDetails.Sum(od => (float)od.UnitPrice * od.Quantity * od.Discount) }).First();

                ////3.1
                //var query3_1q =
                //    from e in db.Employees
                //    join s in db.Employees on e.ReportsTo equals s.EmployeeId into grp
                //    from g in grp.DefaultIfEmpty()
                //    select new
                //    {
                //        e.EmployeeId,
                //        Name = e.FirstName + ' ' + e.LastName,
                //        SupervisorId = g.EmployeeId,
                //        Supervisor = g != null ? g.FirstName + ' ' + g.LastName : "No-one"
                //    };

                ////3.2
                //var query3_2q =
                //   from s in db.Suppliers
                //   join p in db.Products on s.SupplierId equals p.SupplierId
                //   join od in db.OrderDetails on p.ProductId equals od.ProductId
                //   group od by new { s.SupplierId, Supplier = s.CompanyName } into g
                //   where g.Sum(od => od.Quantity * od.UnitPrice * (decimal)(1 - od.Discount)) > 10000
                //   select new { g.Key.SupplierId, g.Key.Supplier, TotalSales = g.Sum(od => od.Quantity * od.UnitPrice * (decimal)(1 - od.Discount)) };
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
