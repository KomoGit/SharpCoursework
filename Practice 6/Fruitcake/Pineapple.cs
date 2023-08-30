namespace Fruitcake
{
    internal class Pineapple : Fruit
    {
        readonly float vitEmg;
        readonly float vitDmg;

        public Pineapple(string name, string[] vitamins, float price,float vite,float vitb) : base(name, vitamins, price)
        {
            vitEmg = vite;
            vitDmg = vitb;
        }

        public override string Taste() => $"Ohhh who lives in a pineapple under the sea? It stings when eating. Has {vitEmg} of Vitamin E and {vitDmg} of Vitamin D at the price of {Price}";
    }
}
