using NUnit.Framework;
using StoreManagementProject.Model;
using System;
using System.Collections.Generic;

namespace StoreManagementProject.Tests
{
    [TestFixture]
    internal class TestCustomerClass
    {
        private readonly Customer customer = new Customer("James", "Clyde", "0102322023");
        [Test]
        public void TestCustomerFullName()
        {
            string expected = "James Clyde";
            Assert.AreEqual(expected,customer.GetFullName());
        }
        [Test]
        public void TestCustomerContactNumber()
        {
            string expected = "0102322023";
            Assert.AreEqual(expected,customer.ContactNumber);
        }
    }
    [TestFixture]
    internal class TestProductClass
    {
        private readonly Product product = new Product("T-Shirt Gucci",300.50f,10);

        [Test]
        public void TestRetrieveAllData()
        {
            string expected = "T-Shirt Gucci 300.5 10";
            Assert.AreEqual(expected,product.RetrieveAllData());
        }
    }
    [TestFixture]
    internal class TestStoreClass
    {
        private readonly Customer customer1 = new Customer("James", "Clyde", "0102322023");
        private readonly Customer customer2 = new Customer("Walter", "White", "0232323232");
        private readonly Product product1 = new Product("T-Shirt Gucci", 300.50f, 10);
        private readonly Product product2 = new Product("T-Shirt plain white", 320f, 100);
        private readonly List<Customer> customers = new List<Customer>();
        private readonly List<Product> products = new List<Product>();

        [TestCase]
        public void TestGetAllCustomers()
        {
            Store store = new Store("H&M Store", customers, products);
            customers.Add(customer1);
            customers.Add(customer2);
            products.Add(product2);
            products.Add(product1);
            Assert.AreEqual(customers,store.GetAllCustomers());
        }
        [TestCase]
        public void TestGetByContact()
        {
            customers.Add(customer1);
            customers.Add(customer2);
            products.Add(product2);
            products.Add(product1);
            Store store = new Store("H&M Store", customers, products);
            string expected = "Walter White";
            Assert.AreEqual(expected, store.GetCustomerByContact("0232323232").GetFullName());
        }
        [TestCase]
        public void TestGetCustomersEmpty()
        {
            Store store = new Store("H&M Store", customers, products);
            Assert.Throws<Exception>(() => store.GetAllCustomers());
        }
        [TestCase]
        public void TestInvalidContactNumber()
        {
            Store store = new Store("H&M Store", customers, products);
            Assert.Throws<Exception>(() => store.GetCustomerByContact(""));
        }
        [TestCase]
        public void TestGetAllProductsEmpty()
        {
            Store store = new Store("H&M Store", customers, products);
            Assert.Throws<Exception>(() => store.GetAllProducts());
        }
        [TestCase]
        public void TestGetAllProducts()
        {
            customers.Add(customer1);
            customers.Add(customer2);
            products.Add(product2);
            products.Add(product1);
            Store store = new Store("H&M Store", customers, products);
            Assert.AreEqual(products,store.GetAllProducts());
        }
        [TestCase]
        public void TestGetProductByName()
        {
            customers.Add(customer1);
            customers.Add(customer2);
            products.Add(product2);
            products.Add(product1);
            Store store = new Store("H&M Store", customers, products);
            string expected = "T-Shirt Gucci";
            Assert.AreEqual(expected,store.GetProductByName(expected).Name);
        }
        [TestCase]
        public void TestInvalidProductName()
        {
            customers.Add(customer1);
            customers.Add(customer2);
            products.Add(product2);
            products.Add(product1);
            Store store = new Store("H&M Store", customers, products);
            Assert.Throws<Exception>(() => store.GetProductByName(""));
        }
    }
}
