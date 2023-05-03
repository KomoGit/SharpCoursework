using System;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ThirdPractice third = new ThirdPractice();
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9,10};
            char[] chars = { 'a', 'b', 'c', 'd', 'e' };
            string[] strings = {"a","b","c","d","e" };
            Console.WriteLine(third.FindIndexOfElement(strings,"a"));
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
            var s = p * r;   
            return s;
        }
        public float DArea(float a, float b)
        {
            return a * b;
        }
    }
}

internal class ThirdPractice 
{ 
    public int FindIndexOfElement<T>(T[] charArr, dynamic identifier)
    {
        for (int i = 0; i < charArr.Length; i++)
        {
            if (charArr[i] == identifier)
            {
                return i;
            }
        }
        return -1;
    }
}