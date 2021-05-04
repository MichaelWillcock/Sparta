using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace CSharpwithSQL
{
    class Program
    {
        static void Main(string[] args)
        {
            var customers = new List<Customer>();
            using (var connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                connection.Open();
                Console.WriteLine(connection.State);

                //using (var command = new SqlCommand("select * from customers", connection))
                //{
                //    SqlDataReader sqlReader = command.ExecuteReader();

                //    while (sqlReader.Read())
                //    {
                //        var customerID = sqlReader["CustomerID"].ToString();
                //        var contactName = sqlReader["ContactName"].ToString();
                //        var companyName = sqlReader["CompanyName"].ToString();
                //        var city = sqlReader["City"].ToString();
                //        var contactTitle = sqlReader["ContactTitle"].ToString();

                //        var customer = new Customer
                //        {
                //            ContactTitle = contactTitle,
                //            CustomerID = customerID,
                //            ContactName = contactName,
                //            City = city,
                //            CompanyName = companyName
                //        };
                //        customers.Add(customer);
                //    }
                //    customers.ForEach(c => Console.WriteLine($"Customer {c.GetFullName()} has {c.CustomerID}"));
                //}

                //var newCustomer = new Customer
                //{
                //    CustomerID = "MANDA",
                //    ContactName = "Nish Mandal",
                //    City = "Birmingham",
                //    CompanyName = "Sparta Global"
                //};

                //string sqlString = $"INSERT INTO CUSTOMERS(CustomerID, ContactName, CompanyName, City) VALUES ('{newCustomer}')";
                //using (var command2 = new SqlCommand(sqlString, connection))
                //{
                //    int affected = command2.ExecuteNonQuery();
                //}

                //string sqlUpdateString = $"UPDATE CUSTOMERS SET CITY 'London' WHERE  CustomerID  = 'MANDA'";
                //using(var command3 = new SqlCommand(sqlUpdateString, connection))
                //{
                //    int affected = command3.ExecuteNonQuery();
                //}

                //string sqlDeleteString = $"DELETE FROM CUSTOMERS WHERE CustomerID  = 'MANDA'";
                //using (var command4 = new SqlCommand(sqlDeleteString, connection))
                //{
                //    int affected = command4.ExecuteNonQuery();
                //}

            }
        }

        public class Customer
        {
            public string CustomerID { get; set; }
            public string CompanyName { get; set; }
            public string ContactName { get; set; }
            public string ContactTitle { get; set; }
            public string City { get; set; }

            public string GetFullName()
            {
                return $"{ContactTitle} - {ContactName}";
            }
        }
    }
}
