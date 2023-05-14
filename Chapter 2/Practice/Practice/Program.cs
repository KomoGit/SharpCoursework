using System;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FirstPractice first = new FirstPractice();
            char[] index = { 'c','g' };
            //Console.WriteLine(first.GetLastName("James Clyde Henry"));
            //Console.WriteLine(first.GetLastName("Walter White Hartwell"));
            Console.WriteLine(first.FindRepatedStrings("afcgafcgafcgafafafcgafafafcg",index));
        }
    }

    internal class FirstPractice
    {
        public string GetLastName(string fullname)
        {
            string[] res = fullname.Split(' ');
            return res[1];
        }
        public int FindRepatedStrings(string text,char[] index)
        {
            int res = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == index[0])
                {
                    if (text[i+1] == index[1])
                    {
                        res++;
                    }               
                }
            }
            return res;
        }
    }
}
