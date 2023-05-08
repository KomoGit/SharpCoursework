using System;
using System.Linq;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ThirdPractice third = new ThirdPractice();
            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9,10};
            //char[] chars = { 'a', 'b', 'c', 'd', 'e' };
            //string[] strings = {"a","b","c","d","e" };
            //Console.WriteLine(third.FindIndexOfElement(strings,"a"));
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] % 2 == 0)
            //    {
            //        Console.WriteLine(nums[i]);
            //    }
            //}
            FourthPratcice fourth = new FourthPratcice();
            //Console.WriteLine(fourth.LengthOfWord("Hello!"));
            //Console.WriteLine(fourth.ReturnSurname("James Clyde"));
            //Console.WriteLine(fourth.PalindromeText("James","Ray"));
            Console.WriteLine(fourth.SortByAlphabeticalOrder("James"));

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

internal class FourthPratcice
{
    public int LengthOfWord(string str)
    {
        return str.Length;
    }

    public string ReturnSurname(string fullname)
    {
        string[] split = fullname.Split(' ');
        return split[1];
    }

    public string SortByAlphabeticalOrder(string text)
    {
        string a = text.ToLower();
        char[] chars = a.ToCharArray();
        Array.Sort(chars);
        return new string(chars);
    }

    public bool PalindromeText(string text1,string text2)
    {
        string a = text1.ToLower();
        string b = text2.ToLower();
        char c = a[0];
        char d = b[text2.Length - 1];
        if (c == d) 
        { 
            return true; 
        }
        return false;
    }
}