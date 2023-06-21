namespace Fruitcake
{
    public abstract class Fruit
    {
        public string Name { get; }
        public string[] Vitamins { get; }
        public float Price { get; }

        public Fruit(string name, string[] vitamins, float price)
        {
            Name = name;
            Vitamins = vitamins;
            Price = price;
        }


        public abstract string Taste();
    }
}
