using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{  
    internal class Program
    {
        private static FirstHomework firstHomework = new FirstHomework();
        private static SecondHomework secondHomework = new SecondHomework();
        static void Main(string[] args)
        {
            int[] arr = { 4, 7, 9, 12, 14 };
            //firstHomework.DividesToThree(7,18);
            secondHomework.MinimumMaximum(arr);
        }
    }
}

class FirstHomework
{
    public void DividesToThree(int range1, int range2)
    {
        for (int i = range1; i <= range2; i++)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine(i);
            }           
        }
    }
}

class SecondHomework
{
    public void MinimumMaximum(int[] arr)
    {
        int min = arr[0];
        int max = arr[0];
        for (int i = 0; i < arr.Length; i++) 
        {
            if(arr[i] > max)
            {
                max = arr[i];             
            }
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }
        Console.WriteLine(min);
        Console.WriteLine(max);
    }
}

class ThirdHomework
{

}

class FourthHomework
{

}