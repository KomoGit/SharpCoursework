namespace Homework_8
{
    class Program
    {
        public static void Main(string[] args)
        {
            Influenza flu = new H1N1();
            H1N1 h1 = new();
            Console.WriteLine(flu.GetSpecies());
            Console.WriteLine(flu.GetRealm());
            Console.WriteLine(h1.GetSpecies());
        }
    }
    internal abstract class Virus
    {
        public abstract string GetRealm();
        public abstract string GetSpecies();
    }

    internal class Influenza : Virus
    {
        private readonly string Realmn = "Riboviria";
        private readonly string Species = "Influenza A Virus";

        public override string GetRealm()
        {
            return Realmn;
        }

        public override string GetSpecies()
        {
            return Species;
        }
    }

    internal class H1N1 : Influenza
    {
        private readonly string Strain = "H1N1/09 Virus";
        public string GetStrain()
        {
            return Strain;
        }
    }
}