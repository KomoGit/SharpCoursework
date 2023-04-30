using System;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9,10};

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] % 2 == 0)
            //    {
            //        Console.WriteLine(nums[i]);
            //    }
            //}
        }
    }

    internal class SecondPractice
    {
        //One and two could not be overloaded as their parameters are similar.
        public float Area(float p,float r)
        {
            return p * r * r;
        }
        public float Area(float a ,float b ,float c)
        {
            return 2 * (a * b + a * c + b * c);
        }
        public float Area(float a,float b,float c,float r,float p)
        {
            p = (a + b + c) / 2;
            var s = p * r; //Cannot return s? What purpose does it have here?      
            return s;
        }
        public float DArea(float a, float b)
        {
            return a * b;
        }
    }
}
