using System;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FirstPractice first = new FirstPractice();
            //char[] index = { 'c','g' };
            //Console.WriteLine(first.GetLastName("James Clyde Henry"));
            //Console.WriteLine(first.GetLastName("Walter White Hartwell"));
            //Console.WriteLine(first.FindRepatedStrings("afcgafcgafcgafafafcgafafafcg",index));

            SecondPractice second = new SecondPractice();
            //second.ReturnRandomCollection(10);
            //second.ReturnRandomCharacther(10);
            second.ReturnRandomCombination(10);
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

    internal class SecondPractice
    {
        private readonly Random rnd = new Random();

        public void ReturnRandomCollection(int randomRange)
        {
            int prev = 0;
            for (int i = 0; i < randomRange; i++)
            {
                int current = rnd.Next(1, randomRange);
                if (current != prev)
                {
                    Console.Write(current);
                    prev = current;
                }              
            }
            Console.WriteLine("");
        }
        
        public void ReturnRandomCharacther(int randomRange)
        {
            char prev = default;
            for (int i = 0; i < randomRange; i++)
            {
                char current = (char)rnd.Next(1, randomRange);
                if (current != prev)
                {
                    Console.Write(current);
                    prev = current;
                }
            }
            Console.WriteLine("");
        }

        public void ReturnRandomCombination(int randomRange)
        {
            bool swtc = default;
            for (int i = 0; i < randomRange; i++)
            {
                if (swtc)
                {
                    Console.WriteLine((char)rnd.Next(1,randomRange));
                    swtc = false;
                }
                else
                {
                    Console.WriteLine(rnd.Next(1,randomRange));
                    swtc = true;
                }
            }
            //for (int i = 0; i < randomRange; i++)
            //{
            //    char current = (char)rnd.Next(1, randomRange);
            //    if (current != prev)
            //    {
            //        Console.Write(current);
            //        prev = current;
            //    }
            //}
        }
    }
}
