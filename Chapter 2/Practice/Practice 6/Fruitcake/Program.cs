namespace Fruitcake
{
    class Program
    {
        readonly static string[] appleVit = { "A","B"};
        readonly static string[] pinVit = { "E", "D" };
        readonly static string[] orangeVit = { "C" };
        readonly static Pineapple pineapple = new("George", pinVit, 21, 0.500f, 0.600f);
        readonly static Apple apple = new("Steve",appleVit,21,0.500f,0.600f);
        readonly static Orange orange = new("Annoying",orangeVit,23,0.500f);
        readonly static Fruit[] basket = new Fruit[] { apple, pineapple, orange };

        public static void Main()
        {
            foreach (Fruit item in basket)
            {
                Console.WriteLine(item.Taste());          
                if (item is Apple apple) Console.WriteLine(apple.Vitamins[0], apple.Vitamins[1]);
                else if (item is Pineapple pine) Console.WriteLine(pine.Vitamins[0], pine.Vitamins[1]);
                else if (item is Orange org) Console.WriteLine(org.Vitamins[0]);
                else throw new Exception("No fruits in the basket!");
            }
        }
    }
}