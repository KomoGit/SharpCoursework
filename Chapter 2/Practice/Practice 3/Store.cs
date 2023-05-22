using System;
using System.Collections.Generic;
using System.Security.Policy;

namespace Practice_3
{
    internal class Store
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length >= 3) _name = value;
            }
        }

        public Phone[] phones = new Phone[0];
        public Store(string name, Phone[] phones)
        {
            _name = name;
            
        }

        private decimal _Income;

        public decimal Revenue { get { return _Income; } private set { } }

        public void AddPhone(Phone phone)
        {
            Array.Resize(ref phones,phones.Length + 1);
            phones[phones.Length - 1] = phone;
        }

        public void RemovePhone(string id)
        {
            Phone[] newPhones = new Phone[0];
            foreach (Phone item in phones)
            {
                if(item.Id != id)
                {
                    if (item.Id != id)
                    {
                        Array.Resize(ref newPhones, newPhones.Length + 1);
                        newPhones[newPhones.Length - 1] = item;
                    }
                }
            }
            phones = newPhones;
        }
        public void SellItem(string id,int count)
        {
            foreach (Phone item in phones)
            {
                if (item.Id == id && item.Count > 0 && item.Count > count)
                {
                    count--;
                    _Income += item.Price * count;
                }
                throw new Exception("Not available.");
            }
        }

        public Phone GetAllPhones()
        {
            if (phones.Length != 0)
            {
                foreach (Phone item in phones)
                {
                    return item;
                }
            }
            throw new Exception("Phones are empty.");
        }

        public string GetPhoneInRange(decimal MaxPrice, decimal MinPrice)
        {
            foreach (Phone phone in phones)
            {
                if (phone.Price <= MaxPrice && phone.Price >= MinPrice)
                {
                    return phone.ShowInfo();
                }
            }
            return "Could not be found in these parameters";
        }

        public string GetPhoneInRange(decimal MaxPrice)
        {
            foreach (Phone phone in phones)
            {
                if (phone.Price <= MaxPrice)
                {
                    return phone.ShowInfo();
                }
            }
            return "Could not be found in these parameters";
        }
    }
}
