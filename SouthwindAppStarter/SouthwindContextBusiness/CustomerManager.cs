using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SouthwindApp;

namespace SouthwindContextBusiness
{
    public class CustomerManager
    {
        public Customer selectedCustomer { get; set; }

        public void AddCustomer(string customerId, string contactName)
        {
            var newCust = new Customer() { CustomerId = customerId, ContactName = contactName };
            using (var db = new SouthwindContext())
            {
                db.Customers.Add(newCust);
                db.SaveChanges();
            }
        }
        public void RemoveCustomer(string customerId)
        {
            using (var db = new SouthwindContext())
            {
                var selectedCustomer =
                    from c in db.Customers
                    where c.CustomerId == customerId
                    select c;
                db.Customers.RemoveRange(selectedCustomer);
                db.SaveChanges();

            }
        }
        public List<Customer> RetrieveAll()
        {
            using (var db = new SouthwindContext())
            {
                return db.Customers.ToList();
            }
        }
    }
}
