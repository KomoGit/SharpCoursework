using System;

namespace AnimalKingdom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog
            {
                FurColor = "White"
            };
        }
    }

    public class Cat : Animal
    {
        public Cat():base("Mr.Mittens")
        {
            
        }
        public override string Identify()
        {
            return "Meow";
        }
    }
}
