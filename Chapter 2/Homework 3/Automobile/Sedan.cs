namespace Automobile
{
    public class Sedan : Car
    {
        public Sedan(string name,string year):base(name,year) 
        { 

        }
        public override string ReturnData()
        {
            return $"{base.ReturnData()} Sedan";
        }
        public override bool StartCar()
        {
            return base.StartCar();
        }
    }
}
