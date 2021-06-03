using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using NorthwindData;

namespace NorthwindBusiness
{
    public class CustomerManager
    {
        public Customer SelectedCustomer { get; set; }

        //I want a permanant connection to the service.

        private ICustomerService _service;

        //We didn't have a constructor now we have two

        //No argument constructor so that our code doesn't break
        public CustomerManager()
        {
            _service = new CustomerService();
        }
        public CustomerManager(ICustomerService service)
        {
            _service = service;
        }
        public void CreateCustomer(string customerId, string contactName = null, string city = null, string postalCode = null, string country = null, string companyName = "")
        {
            var newCust = new Customer() { CustomerId = customerId, ContactName = contactName, City = city, PostalCode = postalCode, Country = country, CompanyName = companyName };
            _service.CreateCustomer(newCust);
        }

        public bool UpdateCustomer(string customerId, string contactName, string city, string postcode, string country, string companyName)
        {
            SelectedCustomer = _service.GetCustomerById(customerId);
            if (SelectedCustomer == null)
            {
                return false;
            }
            {
                SelectedCustomer.ContactName = contactName;
                SelectedCustomer.City = city;
                SelectedCustomer.PostalCode = postcode;
                SelectedCustomer.Country = country;
                SelectedCustomer.CompanyName = companyName;

                try
                {
                    _service.SaveCustomerChanges();
                }
                catch(DbUpdateConcurrencyException e) // an exception will be thrown if the database had been updated since last loaded
                {
                    Debug.WriteLine($"Error updating {customerId}");
                    return false;
                }
                return true;
            }
        }


        public List<Customer> RetrieveAllCustomers()
        {
            return _service.GetCustomerList();
        }

        public void SetSelectedCustomer(object selectedItem)
        {
            SelectedCustomer = (Customer)selectedItem;
        }

        public bool DeleteCustomer(string customerid)
        {
            SelectedCustomer = _service.GetCustomerById(customerid);
            if (SelectedCustomer == null)
            {
                Debug.WriteLine($"Can't find {customerid}");
                return false;
            }
            _service.RemoveCustomer(SelectedCustomer);
            SelectedCustomer = null;
            return true;

        }

        public bool CheckCustomerExists(string customerid)
        {
            var customer = _service.GetCustomerById(customerid);
            return customer != null ? true : false;
        }
    }
}
