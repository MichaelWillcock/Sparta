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
        public Customer SelectedCustomer { get; set; }

        public void AddCustomer(string customerId, string contactName, string companyName)
        {
            var newCust = new Customer() { CustomerId = customerId, ContactName = contactName, CompanyName = companyName };
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
        public void SetSelectedCustomer(object selectedItem)
        {
            SelectedCustomer = (Customer)selectedItem;
        }
        public void UpdateCustomer(string customerId, string contactName, string companyName, string city, string country, string postCode)
        {
            using (var db = new SouthwindContext())
            {
                SelectedCustomer = db.Customers.Where(c => c.CustomerId == customerId).FirstOrDefault();
                SelectedCustomer.ContactName = contactName;
                SelectedCustomer.CompanyName = companyName;
                SelectedCustomer.City = city;
                SelectedCustomer.Country = country;
                SelectedCustomer.PostalCode = postCode;
                // write changes to database
                db.SaveChanges();
            }
        }
    }
}
