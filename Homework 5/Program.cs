using System;

namespace Homework_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(homework.Factiorial(5)); 
        }
    }
}

internal class HomeworkOne
{
    public float Sum(float a ,float b)
    {
        return a + b;
    }
    public float Divide(float a,float b)
    {
        return a - b;
    }
    public float Add(float a, float b)
    {
        return a*b;
    }
    public float Subdivide(float a,float b)
    {
        return a/b;
    }
}

internal class HomeworkTwo 
{ 
    public bool IsPositive(float num)
    {
        return num > 0;
    }
}

internal class HomeworkFour
{
    public void StarDraw(int length)
    {
        for (int i = 0; i != length; i++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}

internal class HomeworkSix
{
    //RECURSION YEEEEEEEEY
    public float Factiorial(int num)
    {
        if (num == 0)
        {
            return 1;
        }
        else
        {
            return num * Factiorial(num - 1);
        }
    }
}