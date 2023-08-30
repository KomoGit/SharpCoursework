using System;


namespace Practice_5
{
    class Gallery
    {
        private string _name;
        private Car[] Cars = new Car[0];
        public string Name { get { return _name; }  set { _name = value; } }

        public Gallery(string name, Car[] cars)
        {
            _name = name;
            Cars = cars;
        }

        public void AddCar(Car car)
        {
            Array.Resize(ref Cars, Cars.Length + 1);
            Cars[Cars.Length - 1] = car;
        }
        public void GetAllCars()
        {
            foreach (Car item in Cars)
            {
                Console.WriteLine(item);
            }
        }
        public Car FindBySpeed(int maxSpeed,int minSpeed)
        {
            Car ret = default;
            foreach (Car item in Cars)
            {
                if(item.Speed <= maxSpeed && item.Speed >= minSpeed)
                {
                    ret = item; break;
                }
            }
            return ret;
        }
        public Car FindCarById(int id)
        {
            Car ret = default;
            foreach (Car item in Cars)
            {
                if(item.Id == id)
                {
                    ret = item;
                    break;
                }
            }
            return ret;
        }
        public Car FindMostExpensive()
        {
            Car expensiveOne = Cars[0];
            foreach (Car item in Cars)
            {
                if(item.Price > expensiveOne.Price) 
                {
                    expensiveOne = item;
                }
            }
            if(expensiveOne == null)
            {
                return expensiveOne;
            }
            throw new Exception("MALFUNCTION 54");
        }

        public void RemoveCar(int id)
        {
            Car[] newCarGallery = new Car[0];
            foreach (Car item in Cars)
            {
                if (item.Id != id)
                {
                    if (item.Id != id)
                    {
                        Array.Resize(ref newCarGallery, newCarGallery.Length + 1);
                        newCarGallery[newCarGallery.Length - 1] = item;
                    }
                }
            }
            Cars = newCarGallery;
        }
    }
}
