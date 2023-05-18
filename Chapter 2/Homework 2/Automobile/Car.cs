namespace Automobile
{
    public class Car
    {
        private readonly string Manufacturer,Year;
        public Car()
        {

        }
        public Car(string manufacturer, string year)
        {
            Manufacturer = manufacturer;
            Year = year;
        }
        public virtual string ReturnData()
        {
            return $"{Manufacturer} {Year}";
        }
        public virtual bool StartCar() { return true; }
    }
}
