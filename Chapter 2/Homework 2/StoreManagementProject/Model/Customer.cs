using System;
using System.Collections.Generic;

namespace StoreManagementProject.Model
{
    public class Customer
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ContactNumber { get; set; }

        public Customer(string name,string surname,string contactNumber)
        {
            Name = name;
            Surname = surname;
            ContactNumber = contactNumber;
        }

        public string GetFullName()
        {
            return $"{Name} {Surname}";
        }
    }
}
