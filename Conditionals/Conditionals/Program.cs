using System;

class Program
{
    private static readonly int age = 19;
    public static void Main(string[] args)
    {
        string result = (age > 18) ? "Welcome to our course!" : "You need to be 18 or up to join our course.";
        Console.WriteLine(result);
    }
}
