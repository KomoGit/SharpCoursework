namespace Automobile
{
    public class Hatchback:Car
    {
        public Hatchback(string name, string year) : base(name, year)
        {

        }
        public override string ReturnData()
        {
            return $"{base.ReturnData()} Hatchback";
        }
        public override bool StartCar()
        {
            return base.StartCar();
        }
    }
}
