using NUnit.Framework;
using SouthwindApp;
using SouthwindContextBusiness;
using System.Linq;
using System.Threading;

namespace SouthwindTests
{
    public class Tests
    {
        CustomerManager _customerManager;
        [SetUp]
        public void Setup()
        {
            _customerManager = new CustomerManager();
            using (var db = new SouthwindContext())
            {
                var query =
                    from c in db.Customers
                    where c.CustomerId == "WILLC"
                    select c;
                db.RemoveRange(query);
                db.SaveChanges();
            }

        }

        [Test]
        public void CreatedANewCustomer()
        {
            using(var db = new SouthwindContext())
            {
                var x = db.Customers.Count();
                _customerManager.AddCustomer("WILLC", "Michael Willcock");
                var y = db.Customers.Count();
                Assert.AreEqual(y, x + 1);
            }
        }

        [TearDown]
        public void TearDown()
        {
            using (var db = new SouthwindContext())
            {
                var selectedCustomer =
                from c in db.Customers
                where c.CustomerId == "WILLC"
                select c;

                db.Customers.RemoveRange(selectedCustomer);
                db.SaveChanges();
            }
        }
    }
}