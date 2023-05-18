namespace Automobile
{
    public class SUV : Car
    {
        public SUV(string name, string year) : base(name, year)
        {

        }
        public override string ReturnData()
        {
            return $"{base.ReturnData()} SUV";
        }
        public override bool StartCar()
        {
            return base.StartCar();
        }
    }
}
