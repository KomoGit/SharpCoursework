using System;

namespace HomeworkFour
{
    class Store
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

        public Phone[] phones = Array.Empty<Phone>();
        public Store(string name, Phone[] PhonesArray)
        {
            _name = name;
            phones = PhonesArray;      
        }
        private decimal _Income;
        public decimal Revenue 
        {
            get 
            { 
                return _Income; 
            } 
            private set { } 
        }

        private void AddPhone(Phone phone)
        {
            Array.Resize(ref phones,phones.Length + 1);
            phones[phones.Length - 1] = phone;
        }

        public void RemovePhone(string id)
        {
            Phone[] newPhones = Array.Empty<Phone>();
            foreach (Phone item in phones)
            {
                if(item.Id != id)
                {
                    if (item.Id != id)
                    {
                        Array.Resize(ref newPhones, newPhones.Length + 1);
                        newPhones[^1] = item;
                    }
                }
            }
            phones = newPhones;
        }
        public void SellItem(string id,int count)
        {
            if(phones.Length < count)
            {
                throw new Exception("Not available.");
            }
            foreach (Phone item in phones)
            {
                if (item.Id == id && item.Count > 0 && item.Count > count)
                {
                    count--;
                    _Income += item.Price * count;
                }   
            }
        }

        public void GetAllPhones()
        {
            if (phones.Length == 0)
            {
                throw new Exception("Phones are empty.");
            }
            foreach (Phone item in phones)
            {
                Console.WriteLine(item.ShowInfo());
            }
        }

        public void GetPhoneInRange(decimal MaxPrice, decimal MinPrice)
        {
            foreach (Phone item in phones)
            {
                if (item.Price <= MaxPrice && item.Price >= MinPrice)
                {
                    Console.WriteLine(item.ShowInfo());
                }
            }
            throw new Exception("Could not find in these parameters.");
        }

        public void GetPhoneInRange(decimal MaxPrice)
        {
            foreach (Phone phone in phones)
            {
                if (phone.Price <= MaxPrice)
                {
                    Console.WriteLine(phone.ShowInfo());
                }            
            }
            throw new Exception("Could not find in this parametes.");
        }
    }
}
