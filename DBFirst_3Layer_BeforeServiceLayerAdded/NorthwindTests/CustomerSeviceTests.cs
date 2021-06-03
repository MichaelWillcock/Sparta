using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindBusiness;
using NorthwindData;
using Microsoft.EntityFrameworkCore;

namespace NorthwindTests
{
    class CustomerSeviceTests
    {
        private CustomerService _sut;
        private NorthwindContext _context;

        [OneTimeSetUp]
        public void SetUp()
        {
            //options are that the database will have the same structure as the northwind database, but
            //will be stored in memory 
            var options = new DbContextOptionsBuilder<NorthwindContext>().UseInMemoryDatabase(databaseName: "Example_DB").Options;
            _context = new NorthwindContext(options);
            _sut = new CustomerService(_context);

            //Add stuff to our in memory database
            _sut.CreateCustomer(new Customer { CustomerId = "MANDA", ContactName = "Nish Mandal", CompanyName = "Sparta Global", City = "Birmingham" });
            _sut.CreateCustomer(new Customer { CustomerId = "FRENC", ContactName = "Cathy French", CompanyName = "Sparta Global", City = "Ottowa" });
        }

        [Test]
        public void GivenANewCustomer_CreateCustomersAddsThemToTheDataBase()
        {
            var numberOfCustomersBefore = _context.Customers.Count();
            var newCustomer = new Customer { CustomerId = "NELSO", ContactName = "Ramone Nelson", CompanyName = "Sparta Global", City = "Luton" };
            _sut.CreateCustomer(newCustomer);
            var numberOfCustomersAfter = _context.Customers.Count();
            Assert.That(numberOfCustomersAfter, Is.EqualTo(numberOfCustomersBefore + 1));
            var result = _sut.GetCustomerById("NELSO");
            Assert.That(result, Is.TypeOf<Customer>());
            Assert.That(result.ContactName, Is.EqualTo("Ramone Nelson"));
            Assert.That(result.CompanyName, Is.EqualTo("Sparta Global"));
            Assert.That(result.City, Is.EqualTo("Luton"));


            //Clean Up
            _context.Customers.Remove(newCustomer);
            _context.SaveChanges();
        }
        [Test]
        public void GivenWrongCustomerId_GetCustomerIdReturnsNull()
        {
            Assert.That(_sut.GetCustomerById("NELSO"), Is.Null);
        }
        [Test]
        public void GivenACustomerIsDeleted_TheyAreRemovedFromTheDataBase()
        {
            var numberOfCustomersBeforeDeletion = _context.Customers.Count();
            var customer = _sut.GetCustomerById("MANDA");
            _context.Customers.Remove(customer);
            _context.SaveChanges();
            var numberOfCustomersAfterDeletion = _context.Customers.Count();
            Assert.That(numberOfCustomersBeforeDeletion, Is.EqualTo(numberOfCustomersAfterDeletion + 1));
            Assert.That(_sut.GetCustomerById("MANDA"), Is.Null);
            
        }
    }
}
