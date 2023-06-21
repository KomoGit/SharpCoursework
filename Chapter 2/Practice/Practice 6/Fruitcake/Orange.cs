namespace Fruitcake
{
    internal class Orange : Fruit
    {
        readonly float vitCmg;
        public Orange(string name, string[] vitamins, float price, float vitc) : base(name, vitamins, price)
        {
            vitCmg = vitc;
        }

        public override string Taste() => $"It tastes sour. Contains {vitCmg} of Vitamin A at the price of {Price}";
    }
}
