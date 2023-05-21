using System;

namespace Practice_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student("Walter","White","Chemistry",89,true);
            Console.WriteLine(stu.GetStudentInfo());
            Console.WriteLine(stu.HasStudentGraduated());
            Console.WriteLine(stu.GetDiplomaDegree());
        }
    }
}
