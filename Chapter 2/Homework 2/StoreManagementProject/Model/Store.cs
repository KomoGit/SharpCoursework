using System;
using System.Collections.Generic;

namespace StoreManagementProject.Model
{
    public class Store
    {
        public string Name { get; set; }
        private readonly List<Customer> Customers = new List<Customer>();
        private readonly List<Product> Products = new List<Product>();
        public Store(string name, List<Customer> customers, List<Product> products)
        {
            Name = name;
            Customers = customers;
            Products = products;
        }

        public List<Customer> GetAllCustomers()
        {
            if(Customers != null)
            {
                return Customers;
            }
            throw new Exception("No customers in database");
        }
        public Customer GetCustomerByContact(string contact) 
        {
            foreach(Customer customer in Customers)
            {
                if (customer.ContactNumber.Equals(contact))
                {
                    return customer;
                }
            }
            throw new Exception("Customer could not be found");
        }
        public List<Product> GetAllProducts()
        {
            if(Products != null)
            {
                return Products;
            }
            throw new Exception("No products are available.");
        }
        public Product GetProductByName(string prodName) 
        {
            foreach (Product item in Products)
            {
                if (item.Name.Equals(prodName))
                {
                    return item;
                }
            }
            throw new Exception($"Product {prodName} could not be found");
        }
    }
}
