using System.Collections.Generic;

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
        private readonly List<Phone> _Phones = new List<Phone>();
        public Store(string name,List<Phone> phones)
        {
            _name = name;
            _Phones = phones;
        }

        private decimal _Income;

        public decimal Revenue { get { return _Income; } private set { } }

        public void SellItem(string id, int count)
        {
            foreach (Phone item in _Phones)
            {
                if (item.Id == id)
                {
                    count--;
                    _Income += item.Price;
                    //_Phones.Remove(item);
                    // return;
                }
            }
        }

        public void RemovePhone(string id)
        {
            foreach (Phone item in _Phones)
            {
                if (item.Id == id)
                {
                    _Phones.Remove(item);
                }
            }
        }

        public List<Phone> GetAllPhones()
        {
            return _Phones;
        }

        public string GetPhoneInRange(decimal MaxPrice, decimal MinPrice)
        {
            foreach (Phone phone in _Phones)
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
            foreach (Phone phone in _Phones)
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
