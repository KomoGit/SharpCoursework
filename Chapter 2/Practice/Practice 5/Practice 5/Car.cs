using System;


namespace Practice_5
{
    public class Car
    {
        public int Id;
        private string _name;
        private int _speed;
        private float _price;

        public string Name 
        { 
            get 
            {
                return _name; 
            }
            set 
            { 
                _name = value; 
            } 
        }
        public int Speed 
        { 
            get 
            {
                return _speed; 
            } 
            set
            { _speed = value; 
            } 
        }
        public float Price 
        {
            get 
            { 
                return _price; 
            } 
            set 
            { 
                _price = value; 
            } 
        }

        public Car(int id,string name,int speed,float price)
        {
            Id = id;
            _speed = speed;
            _price = price;
            _name = name;
        }
        public override string ToString()
        {
            return $"{Id} {Name} {Price} {Speed}";
        }
    }
}
