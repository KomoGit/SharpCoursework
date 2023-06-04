using Homework_Five.Model;

namespace Homework_Five
{
    class Program
    {
        public static void Main(string[] args)
        {
            Teacher teacher = new("Walter White",42,"Chemistry");
            SomethingSomething s1 = new SomethingSomething();
            Console.WriteLine(teacher.IntroduceYourself());
        }
    }
    class SomethingSomething
    {
        string defaultAccessModifierVar = "Hello";
    }
}