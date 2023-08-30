using System;

namespace Hooomans
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human hobo = new Human("Adrian", 36);
            Developer dev = new Developer("James",23,"GoLang");
            Teacher teacher = new Teacher("Jill", 26, "History");

            Console.WriteLine(dev.IntroduceYourself());           
            Console.WriteLine(teacher.IntroduceYourself());           
            Console.WriteLine(hobo.IntroduceYourself());
        }
    }
}
