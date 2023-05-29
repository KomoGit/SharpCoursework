using Homework_Five.Model;

namespace Homework_Five
{
    class Program
    {
        public static void Main(string[] args)
        {
            Teacher teacher = new("Walter White",42,"Chemistry");
            Console.WriteLine(teacher.IntroduceYourself());
        }
    }
}