using System;

namespace Practice_3
{
    internal class Phone
    {
        private readonly string _Id;
        public string Id 
        { 
            get 
            { 
                return _Id; 
            } 
        }
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
        private string _model;
        public string Model 
        {
            get 
            { 
                return _model; 
            }        
            set 
            { 
                if(value.Length >= 3)
                {
                    _model = value;
                }
            } 
        }
        public string SerialNumber;
        public decimal Price;
        private int _count;
        public int Count 
        { 
            get 
            {
                return _count; 
            } 
            set 
            { 
                if (value > 0) _count = value; 
            } 
        }
        public Phone(string id,string name,string model,decimal price,int count)
        {
            _Id = id;
            _name = name;
            _model = model;
            Price = price;
            _count = count;
            GenerateSerialNumber();
        }

        public string ShowInfo()
        {
            return $"{Name} {_Id} {SerialNumber} {Price} USD";
        }

        public void GenerateSerialNumber()
        {
            SerialNumber = _name.Substring(0,2) + _model.Substring(0,2);
        }
    }
}
