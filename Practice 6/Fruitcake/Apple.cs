namespace Fruitcake
{
    public class Apple : Fruit
    {
        readonly public float vitAmg;
        readonly public float vitBmg;

        public Apple(string name, string[] vitamins,float price,float vita, float vitb):base(name,vitamins,price)
        {
            vitAmg = vita;
            vitBmg = vitb;
        }

        public override string Taste() => $"It tastes like an apple. Contains {vitAmg} of Vitamin A and {vitBmg} of Vitamin B at the price of {Price}";
    }
}
