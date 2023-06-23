namespace ConsoleApp1
{
    class Program
    {
        static Dictionary<string, int> Langs = new Dictionary<string,int>();
        public static void Main(string[] args)
        {
            Langs.Add("C#",2000);
            Langs.Add("GoLang",2009);
            Langs.Add("Java",1989);
            Console.WriteLine(Langs["C#"]);
            Console.WriteLine(Langs["Java"]);
            Console.WriteLine(Langs["GoLang"]);
        }
    }
}